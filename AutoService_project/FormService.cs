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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
            ShowServices();
        }
        void ShowServices()
        {
            listViewServises.Items.Clear();
            foreach (ServicesSet servicesSet in Program.vp.ServicesSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    servicesSet.Id.ToString(),servicesSet.Service, servicesSet.Price.ToString()+"р"
                });
                item.Tag = servicesSet;
                listViewServises.Items.Add(item);
            }
            listViewServises.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxServiseName.Text != "" && textBoxPrice.Text != "")
            {
                int temp;
                bool price = Int32.TryParse(textBoxPrice.Text, out temp);
                if (!price) MessageBox.Show("введите число в поле Цена", "Неверный тип данных", MessageBoxButtons.OK);
                else
                {
                    ServicesSet servicesSet = new ServicesSet();
                    servicesSet.Service = textBoxServiseName.Text;
                    servicesSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    Program.vp.ServicesSet.Add(servicesSet);
                    Program.vp.SaveChanges();
                    ShowServices();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxServiseName.Text != "" && textBoxPrice.Text != "")
            {
                if (listViewServises.SelectedItems.Count == 1)
                {
                    int temp;
                    bool price = Int32.TryParse(textBoxPrice.Text, out temp);
                    if (!price) MessageBox.Show("введите число в поле Цена", "Неверный тип данных", MessageBoxButtons.OK);
                    else
                    {
                        ServicesSet servicesSet = listViewServises.SelectedItems[0].Tag as ServicesSet;
                        servicesSet.Service = textBoxServiseName.Text;
                        servicesSet.Price = Convert.ToInt32(textBoxPrice.Text);
                        Program.vp.SaveChanges();
                        ShowServices();
                    }
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
                if (listViewServises.SelectedItems.Count == 1)
                {
                    ServicesSet servicesSet = listViewServises.SelectedItems[0].Tag as ServicesSet;
                    Program.vp.ServicesSet.Remove(servicesSet);
                    Program.vp.SaveChanges();
                    ShowServices();
                }
                textBoxServiseName.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewServises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewServises.SelectedItems.Count == 1)
            {
                ServicesSet servicesSet = listViewServises.SelectedItems[0].Tag as ServicesSet;
                textBoxServiseName.Text = servicesSet.Service;
                textBoxPrice.Text = servicesSet.Price.ToString();
            }
            else
            {
                textBoxServiseName.Text = "";
                textBoxPrice.Text = "";
            }
        }
    }
}
