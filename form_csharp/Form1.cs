using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string email = ctEmail.Text;
            string senha = ctSenha.Text;
            if (email.Equals("admin") & senha.Equals("admin")) {
                MessageBox.Show("Entrou!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Não entrou!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo do sistema...", "Sair", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(0);
        }
    }
}
