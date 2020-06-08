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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.vp.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsSet.Id.ToString(), clientsSet.Name, clientsSet.MiddleName,
                    clientsSet.LastName, clientsSet.Phone
                });
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text !="" && textBoxLastName.Text != "" && textBoxPhone.Text != "")
            {
                long temp;
                bool phone = Int64.TryParse(textBoxPhone.Text, out temp);
                if (!phone) MessageBox.Show("Номер телефона состоит из цифр", "Неверный тип данных", MessageBoxButtons.OK);
                else
                {
                    ClientsSet clientSet = new ClientsSet();
                    clientSet.Name = textBoxFirstName.Text;
                    clientSet.MiddleName = textBoxMiddleName.Text;
                    clientSet.LastName = textBoxLastName.Text;
                    clientSet.Phone = textBoxPhone.Text;

                    Program.vp.ClientsSet.Add(clientSet);
                    Program.vp.SaveChanges();
                    ShowClient();
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxPhone.Text != "")
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    long temp;
                    bool phone = Int64.TryParse(textBoxPhone.Text, out temp);
                    if (!phone) MessageBox.Show("Номер телефона состоит из цифр", "Неверный тип данных", MessageBoxButtons.OK);
                    else
                    {
                        ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                        clientSet.Name = textBoxFirstName.Text;
                        clientSet.MiddleName = textBoxMiddleName.Text;
                        clientSet.LastName = textBoxLastName.Text;
                        clientSet.Phone = textBoxPhone.Text;
                        Program.vp.SaveChanges();
                        ShowClient();
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    Program.vp.ClientsSet.Remove(clientSet);
                    Program.vp.SaveChanges();
                    ShowClient();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                textBoxFirstName.Text = clientSet.Name;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxPhone.Text = clientSet.Phone;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
            }
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
