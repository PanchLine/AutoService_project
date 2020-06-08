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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAutorization.users.type != "1") buttonEmployes.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAutorization.users.login;
        }

        private void buttonProfessions_Click(object sender, EventArgs e)
        {
            Form formProfession = new FormProfession();
            formProfession.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonServise_Click(object sender, EventArgs e)
        {
            Form formService = new FormService();
            formService.Show();
        }

        private void buttonEmployes_Click(object sender, EventArgs e)
        {
            Form formEmployes = new FormEmployes();
            formEmployes.Show();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            Form formOrders = new FormOrders();
            formOrders.Show();
        }
    }
}
