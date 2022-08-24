using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FormuLogin : Form
    {
        public FormuLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void FormuLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 150, this.Height / 2 - 175);
            pnlLogin.Visible = true;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(41,125,85);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 105, 70);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void FormuLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }
        private void ChamarLogin()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Preencha o Login");
                txtUsuario.Focus();
                return;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha a Senha");
                txtSenha.Focus();
                return;
            }

            // AQUI VAI O CÓDIGO PARA O LOGIN

            FrmMenu form = new FrmMenu();
            //this.Hide();
            Limpar();
            form.Show();
        }

        private void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void FormuLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 150, this.Height / 2 - 175);
        }
    }
}
