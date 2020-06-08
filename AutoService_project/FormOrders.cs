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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            ShowEmployes();
            ShowClients();
            ShowServices();
            ShowOrders();
        }

        void ShowEmployes()
        {
            comboBoxEmployee.Items.Clear();
            foreach (EmployesSet employesSet in Program.vp.EmployesSet)
            {
                string[] item = {employesSet.Id.ToString()+".", employesSet.Name, employesSet.LastName };
                comboBoxEmployee.Items.Add(string.Join(" ", item));
            }
        }

        void  ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.vp.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.Name, clientsSet.LastName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }

        void ShowServices()
        {
            comboBoxService.Items.Clear();
            foreach (ServicesSet servicesSet in Program.vp.ServicesSet)
            {
                string[] item = { servicesSet.Id.ToString() + ".", servicesSet.Service+" ","(", servicesSet.Price.ToString()+"р"+")" };
                comboBoxService.Items.Add(string.Join(" ", item));
            }
        }

        void ShowOrders()
        {
            listViewOrders.Items.Clear();
            foreach (OrdersSet ordersSet in Program.vp.OrdersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    ordersSet.Id.ToString(), ordersSet.Date.ToString().Substring(0, ordersSet.Date.ToString().Length-8), 
                    ordersSet.EmployesSet.Name+" "+ordersSet.EmployesSet.LastName,
                    ordersSet.ClientsSet.Name+" "+ordersSet.ClientsSet.LastName,
                    ordersSet.ServicesSet.Service,
                    ordersSet.Status,
                    ordersSet.ServicesSet.Price.ToString()+"р"
                });
                item.Tag = ordersSet;
                listViewOrders.Items.Add(item);
            }
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployee.SelectedItem != null || comboBoxClient.SelectedItem !=null ||comboBoxService.SelectedItem != null || 
                comboBoxStatus.SelectedItem !=null ||textBoxDate.Text !="")
            {
                DateTime temp;
                bool date = DateTime.TryParse(textBoxDate.Text, out temp);
                if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                else
                {
                    OrdersSet ordersSet = new OrdersSet();
                    ordersSet.Date = Convert.ToDateTime(textBoxDate.Text);
                    ordersSet.Id_Employee = Convert.ToInt32(comboBoxEmployee.SelectedItem.ToString().Split('.')[0]);
                    ordersSet.Id_Client = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    ordersSet.Id_Service = Convert.ToInt32(comboBoxService.SelectedItem.ToString().Split('.')[0]);
                    ordersSet.Status = comboBoxStatus.SelectedItem.ToString();
                    Program.vp.OrdersSet.Add(ordersSet);
                    Program.vp.SaveChanges();
                    ShowOrders();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count==1)
            {
                if (comboBoxEmployee.SelectedItem != null && comboBoxClient.SelectedItem != null && comboBoxService.SelectedItem != null &&
                comboBoxStatus.SelectedItem != null && textBoxDate.Text != "")
                {
                    DateTime temp;
                    bool date = DateTime.TryParse(textBoxDate.Text, out temp);
                    if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                    else
                    {
                        OrdersSet ordersSet = listViewOrders.SelectedItems[0].Tag as OrdersSet;
                        ordersSet.Date = Convert.ToDateTime(textBoxDate.Text);
                        ordersSet.Id_Employee = Convert.ToInt32(comboBoxEmployee.SelectedItem.ToString().Split('.')[0]);
                        ordersSet.Id_Client = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                        ordersSet.Id_Service = Convert.ToInt32(comboBoxService.SelectedItem.ToString().Split('.')[0]);
                        ordersSet.Status = comboBoxStatus.SelectedItem.ToString();
                        Program.vp.SaveChanges();
                        ShowOrders();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    OrdersSet ordersSet = listViewOrders.SelectedItems[0].Tag as OrdersSet;
                    Program.vp.OrdersSet.Remove(ordersSet);
                    Program.vp.SaveChanges();
                    ShowOrders();
                }
                textBoxDate.Text = "";
                comboBoxEmployee.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxService.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count==1)
            {
                OrdersSet ordersSet = listViewOrders.SelectedItems[0].Tag as OrdersSet;
                textBoxDate.Text = ordersSet.Date.ToString().Substring(0, ordersSet.Date.ToString().Length - 8);
                comboBoxEmployee.SelectedIndex = comboBoxEmployee.FindString(ordersSet.Id_Employee.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(ordersSet.Id_Client.ToString());
                comboBoxService.SelectedIndex = comboBoxService.FindString(ordersSet.Id_Service.ToString());
                comboBoxStatus.SelectedIndex = comboBoxStatus.FindString(ordersSet.Status);
            }
            else
            {
                textBoxDate.Text = "";
                comboBoxEmployee.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxService.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
            }
        }

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
