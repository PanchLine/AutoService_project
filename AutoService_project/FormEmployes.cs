using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService_project
{
    public partial class FormEmployes : Form
    {
        public FormEmployes()
        {
            InitializeComponent();
            ShowProfessions();
            ShowEmployes();
        }

        void ShowProfessions()
        {
            comboBoxProfession.Items.Clear();
            foreach (ProfessionsSet professionsSet in Program.vp.ProfessionsSet)
            {
                string[] item = { professionsSet.Id.ToString() + ".", professionsSet.Profession };
                comboBoxProfession.Items.Add(string.Join(" ", item));
            }
        }

        void ShowEmployes()
        {
            listViewEmployes.Items.Clear();
            foreach (EmployesSet employesSet in Program.vp.EmployesSet)
            {
                ListViewItem item = new ListViewItem(new string[]
               {
                    employesSet.Id.ToString(), employesSet.Name, employesSet.MiddleName,
                    employesSet.LastName, employesSet.DateOfBirth.ToString().Substring(0, employesSet.DateOfBirth.ToString().Length-8), employesSet.ProfessionsSet.Profession, 
                    employesSet.Login, employesSet.Password
               });
                item.Tag = employesSet;
                listViewEmployes.Items.Add(item);
            }
            listViewEmployes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text !="" && textBoxLastName.Text != "" && textBoxDoB.Text != ""&& comboBoxProfession.SelectedItem !=null &&
                textBoxLogin.Text !="" && textBoxPassword.Text != "")
            {
                DateTime temp;
                bool date = DateTime.TryParse(textBoxDoB.Text, out temp);
                if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                else
                {
                    EmployesSet employesSet = new EmployesSet();
                    employesSet.Name = textBoxFirstName.Text;
                    employesSet.MiddleName = textBoxMiddleName.Text;
                    employesSet.LastName = textBoxLastName.Text;
                    employesSet.DateOfBirth = Convert.ToDateTime(textBoxDoB.Text);
                    employesSet.Id_Profession = Convert.ToInt32(comboBoxProfession.SelectedItem.ToString().Split('.')[0]);
                    employesSet.Login = textBoxLogin.Text;
                    employesSet.Password = textBoxPassword.Text;
                    Program.vp.EmployesSet.Add(employesSet);
                    Program.vp.SaveChanges();
                    ShowEmployes();
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {            
            if (listViewEmployes.SelectedItems.Count == 1)
            {
                if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxDoB.Text != "" && comboBoxProfession.SelectedItem != null &&
                textBoxLogin.Text != "" && textBoxPassword.Text != "")
                {
                    DateTime temp;
                    bool date = DateTime.TryParse(textBoxDoB.Text, out temp);
                    if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                    else
                    {
                        EmployesSet employesSet = listViewEmployes.SelectedItems[0].Tag as EmployesSet;
                        employesSet.Name = textBoxFirstName.Text;
                        employesSet.MiddleName = textBoxMiddleName.Text;
                        employesSet.LastName = textBoxLastName.Text;
                        employesSet.DateOfBirth = Convert.ToDateTime(textBoxDoB.Text);
                        employesSet.Id_Profession = Convert.ToInt32(comboBoxProfession.SelectedItem.ToString().Split('.')[0]);
                        employesSet.Login = textBoxLogin.Text;
                        employesSet.Password = textBoxPassword.Text;
                        Program.vp.SaveChanges();
                        ShowEmployes();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEmployes.SelectedItems.Count == 1)
                {
                    EmployesSet employesSet = listViewEmployes.SelectedItems[0].Tag as EmployesSet;
                    Program.vp.EmployesSet.Remove(employesSet);
                    Program.vp.SaveChanges();
                    ShowEmployes();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDoB.Text = "";
                comboBoxProfession.SelectedItem = null;
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewEmployes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmployes.SelectedItems.Count ==1)
            {
                EmployesSet employesSet = listViewEmployes.SelectedItems[0].Tag as EmployesSet;
                textBoxFirstName.Text = employesSet.Name;
                textBoxMiddleName.Text = employesSet.MiddleName;
                textBoxLastName.Text = employesSet.LastName;
                textBoxDoB.Text = employesSet.DateOfBirth.ToString().Substring(0, employesSet.DateOfBirth.ToString().Length - 8);
                comboBoxProfession.SelectedIndex = comboBoxProfession.FindString(employesSet.Id_Profession.ToString());
                textBoxLogin.Text = employesSet.Login;
                textBoxPassword.Text = employesSet.Password;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDoB.Text = "";
                comboBoxProfession.SelectedItem = null;
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void comboBoxProfession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            textBoxFirstName.Clear();
        }

        private void textBoxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            textBoxMiddleName.Clear();
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            textBoxLastName.Clear();
        }
    }
}
