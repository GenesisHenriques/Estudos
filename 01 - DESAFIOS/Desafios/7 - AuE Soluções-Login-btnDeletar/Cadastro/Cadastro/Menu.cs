using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            desligados();
            txtPesquisa.Enabled = true;
        }

        private void desligados ()
        {
            txtPesquisa.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtSexo.Enabled = false;
            txtDia.Enabled = false;
            txtMes.Enabled = false;
            txtAno.Enabled = false;
        }
        private void ligados()
        {
            txtPesquisa.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtSexo.Enabled = true;
            txtDia.Enabled = true;
            txtMes.Enabled = true;
            txtAno.Enabled = true;
        }
        private void limpar()
        {
            txtPesquisa.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtSexo.Clear();
            txtDia.Clear();
            txtMes.Clear();
            txtAno.Clear();
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Genesis;Data Source=DESKTOP-U3IG6CV\SQLEXPRESS";
        private string strSql = string.Empty;

        private void addFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionar add = new Adicionar();
            add.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ligados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into Clientes (nome, telefone, celular,email,endereco,numero,cidade,sexo, dia, mes, ano) values (@nome, @telefone, @celular, @email, @endereco, @numero, @cidade, @sexo, @dia, @mes, @ano)";
            //Criar a conexão com o banco de dados
            sqlCon = new SqlConnection(strCon);
            //Criar o comando que executa a instrução sql
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@celular", SqlDbType.VarChar).Value = txtCelular.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = txtNumero.Text;
            comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@sexo", SqlDbType.VarChar).Value = txtSexo.Text;
            comando.Parameters.Add("@dia", SqlDbType.VarChar).Value = txtDia.Text;
            comando.Parameters.Add("@mes", SqlDbType.VarChar).Value = txtMes.Text;
            comando.Parameters.Add("@ano", SqlDbType.VarChar).Value = txtAno.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            limpar();
            txtPesquisa.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            strSql = "select*from Clientes where nome = @pesquisa";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txtPesquisa.Text;

            try
            {
                if(txtPesquisa.Text == string.Empty)
                {
                    MessageBox.Show("VOCÊ NÃO DIGITOU UM NOME");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("ESTE NOME NÃO ESTÁ CADASTRADO");
                }
                dr.Read();

                txtNome.Text = Convert.ToString(dr["nome"]);
                txtTelefone.Text = Convert.ToString(dr["telefone"]);
                txtCelular.Text = Convert.ToString(dr["celular"]);
                txtEmail.Text = Convert.ToString(dr["email"]);
                txtEndereco.Text = Convert.ToString(dr["endereco"]);
                txtNumero.Text = Convert.ToString(dr["numero"]);
                txtCidade.Text = Convert.ToString(dr["cidade"]);
                txtSexo.Text = Convert.ToString(dr["sexo"]);
                txtDia.Text = Convert.ToString(dr["dia"]);
                txtMes.Text = Convert.ToString(dr["mes"]);
                txtAno.Text = Convert.ToString(dr["ano"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txtPesquisa.Clear();
            ligados();
            txtPesquisa.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            strSql = "delete from Clientes where nome = @nome ";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("EXCLUSÃO DO CADASTRO FEITO COM SUCESSO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            limpar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "uptade Clientes set nome=@nome, telefone=@telefone, celular=@celular, email=@email, endereco=@endereco, numero=@numero, cidade=@cidade, sexo=@sexo, dia=@dia, mes=@mes, ano=@ano";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@celular", SqlDbType.VarChar).Value = txtCelular.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = txtNumero.Text;
            comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@sexo", SqlDbType.VarChar).Value = txtSexo.Text;
            comando.Parameters.Add("@dia", SqlDbType.VarChar).Value = txtDia.Text;
            comando.Parameters.Add("@mes", SqlDbType.VarChar).Value = txtMes.Text;
            comando.Parameters.Add("@ano", SqlDbType.VarChar).Value = txtAno.Text;  

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO ALTERADO COM SUCESSO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            limpar();
            txtPesquisa.Enabled = true;
        }
    }
}
