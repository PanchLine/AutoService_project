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
    public partial class FormProfession : Form
    {
        public FormProfession()
        {
            InitializeComponent();
            ShowProfession();
        }
        void ShowProfession()
        {
            listViewProfessions.Items.Clear();
            foreach(ProfessionsSet professionsSet in Program.vp.ProfessionsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    professionsSet.Id.ToString(), professionsSet.Profession
                });
                item.Tag = professionsSet;
                listViewProfessions.Items.Add(item);
            }
            listViewProfessions.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxProfession.Text != "")
            {
                ProfessionsSet professionsSet = new ProfessionsSet();
                professionsSet.Profession = textBoxProfession.Text;
                Program.vp.ProfessionsSet.Add(professionsSet);
                Program.vp.SaveChanges();
                ShowProfession();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxProfession.Text != "")
            {
                if (listViewProfessions.SelectedItems.Count == 1)
                {
                    ProfessionsSet professionsSet = listViewProfessions.SelectedItems[0].Tag as ProfessionsSet;
                    professionsSet.Profession = textBoxProfession.Text;
                    Program.vp.SaveChanges();
                    ShowProfession();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProfessions.SelectedItems.Count == 1)
                {
                    ProfessionsSet professionsSet = listViewProfessions.SelectedItems[0].Tag as ProfessionsSet;
                    Program.vp.ProfessionsSet.Remove(professionsSet);
                    Program.vp.SaveChanges();
                    ShowProfession();
                }
                textBoxProfession.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewProfessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProfessions.SelectedItems.Count == 1)
            {
                ProfessionsSet professionsSet = listViewProfessions.SelectedItems[0].Tag as ProfessionsSet;
                textBoxProfession.Text = professionsSet.Profession;
            }
            else
            {
                textBoxProfession.Text = "";
            }
        }
    }
}
