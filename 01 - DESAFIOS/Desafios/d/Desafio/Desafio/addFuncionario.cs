using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class addFuncionario : Form
    {
        public addFuncionario()
        {
            InitializeComponent();

            txtNomePesquisa.Enabled = false;
            nomeTextBox.Enabled = false;
            celularTextBox.Enabled = false;
            telefoneTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            endereçoTextBox.Enabled = false;
            numeroTextBox.Enabled = false;
            cidadeTextBox.Enabled = false;
            sexoMCheckBox.Enabled = false;
            sexoFCheckBox.Enabled = false;
        }

        private void cadastrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.AuE_SoluçõesDataSet1);

        }

        private void addFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'auE_SoluçõesDataSet1.Cadastros'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrosTableAdapter1.Fill(this.auE_SoluçõesDataSet1.Cadastros);
        }

    }
}
