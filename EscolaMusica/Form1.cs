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

namespace EscolaMusica
{
    public partial class Form1 : Form
    {
        const string StringConexao = @"Data Source=DESKTOP-BBF5M1P\SQLEXPRESS;Initial Catalog=EscolaMusica;Integrated Security=True";

        SqlConnection conexao = new SqlConnection(StringConexao);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "Cadastrar")
            {
                if (Validar())
                {
                    adicionaAluno();
                }
            }
            else
            {
                if(btnCadastrar.Text == "Atualizar")
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja ATUALIZAR esse cadastro?", "Atualizar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (Validar())
                        {
                            atualizaAluno();
                        }
                    }
                }
            }
        }
        void atualizaAluno()
        {
            SqlCommand comando = new SqlCommand("UPDATE cadastro SET aluno = @aluno, nascimento = @nascimento, celularAluno = @celularAluno, curso = @curso, endereco = @endereco, bairro = @bairro, cep = @cep, emailAluno = @emailAluno, mensalidade = @mensalidade, responsavel = @responsavel, emailResponsavel = @emailResponsavel, celularResponsavel = @celularResponsavel, concluido = @concluido WHERE codigo = @codigo", conexao);

            SqlParameter codigo = new SqlParameter("codigo", SqlDbType.Int);
            SqlParameter aluno = new SqlParameter("aluno", SqlDbType.VarChar);
            SqlParameter nascimento = new SqlParameter("nascimento", SqlDbType.VarChar);
            SqlParameter celularAluno = new SqlParameter("celularAluno", SqlDbType.VarChar);
            SqlParameter curso = new SqlParameter("curso", SqlDbType.VarChar);
            SqlParameter endereco = new SqlParameter("endereco", SqlDbType.VarChar);
            SqlParameter bairro = new SqlParameter("bairro", SqlDbType.VarChar);
            SqlParameter cep = new SqlParameter("cep", SqlDbType.VarChar);
            SqlParameter emailAluno = new SqlParameter("emailAluno", SqlDbType.VarChar);
            SqlParameter mensalidade = new SqlParameter("mensalidade", SqlDbType.VarChar);
            SqlParameter responsavel = new SqlParameter("responsavel", SqlDbType.VarChar);
            SqlParameter emailResponsavel = new SqlParameter("emailResponsavel", SqlDbType.VarChar);
            SqlParameter celularResponsavel = new SqlParameter("celularResponsavel", SqlDbType.VarChar);
            SqlParameter concluido = new SqlParameter("concluido", SqlDbType.VarChar);

            codigo.Value = txtCodigo.Text;
            aluno.Value = txtNomeAluno.Text;
            nascimento.Value = txtNascimento.Text;
            celularAluno.Value = txtCelularAluno.Text;
            curso.Value = txtCurso.Text;
            endereco.Value = txtEndereco.Text;
            bairro.Value = txtBairro.Text;
            cep.Value = txtCep.Text;
            emailAluno.Value = txtEmailAluno.Text;
            mensalidade.Value = txtMensalidade.Text;
            responsavel.Value = txtNomeResponsavel.Text;
            emailResponsavel.Value = txtEmailResponsavel.Text;
            celularResponsavel.Value = txtCelularResponsavel.Text;
            if (rgbConcluido.Checked)
                concluido.Value = "SIM";
            else
                concluido.Value = "NÃO";

            comando.Parameters.Add(codigo);
            comando.Parameters.Add(aluno);
            comando.Parameters.Add(nascimento);
            comando.Parameters.Add(celularAluno);
            comando.Parameters.Add(curso);
            comando.Parameters.Add(endereco);
            comando.Parameters.Add(bairro);
            comando.Parameters.Add(cep);
            comando.Parameters.Add(emailAluno);
            comando.Parameters.Add(mensalidade);
            comando.Parameters.Add(responsavel);
            comando.Parameters.Add(emailResponsavel);
            comando.Parameters.Add(celularResponsavel);
            comando.Parameters.Add(concluido);

            try
            {
                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro ATUALIZADO com SUCESSO!", "ATUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        void adicionaAluno()
        {
            SqlCommand comando = new SqlCommand("INSERT INTO cadastro (aluno, nascimento, celularAluno, curso, endereco, bairro, cep, emailAluno, mensalidade, responsavel, emailResponsavel, celularResponsavel, concluido) VALUES (@aluno, @nascimento, @celularAluno, @curso, @endereco, @bairro, @cep, @emailAluno, @mensalidade, @responsavel, @emailResponsavel, @celularResponsavel, @concluido)", conexao);

            SqlParameter aluno = new SqlParameter("aluno", SqlDbType.VarChar);
            SqlParameter nascimento = new SqlParameter("nascimento", SqlDbType.VarChar);
            SqlParameter celularAluno = new SqlParameter("celularAluno", SqlDbType.VarChar);
            SqlParameter curso = new SqlParameter("curso", SqlDbType.VarChar);
            SqlParameter endereco = new SqlParameter("endereco", SqlDbType.VarChar);
            SqlParameter bairro = new SqlParameter("bairro", SqlDbType.VarChar);
            SqlParameter cep = new SqlParameter("cep", SqlDbType.VarChar);
            SqlParameter emailAluno = new SqlParameter("emailAluno", SqlDbType.VarChar);
            SqlParameter mensalidade = new SqlParameter("mensalidade", SqlDbType.VarChar);
            SqlParameter responsavel = new SqlParameter("responsavel", SqlDbType.VarChar);
            SqlParameter emailResponsavel = new SqlParameter("emailResponsavel", SqlDbType.VarChar);
            SqlParameter celularResponsavel = new SqlParameter("celularResponsavel", SqlDbType.VarChar);
            SqlParameter concluido = new SqlParameter("concluido", SqlDbType.VarChar);

            aluno.Value = txtNomeAluno.Text;
            nascimento.Value = txtNascimento.Text;
            celularAluno.Value = txtCelularAluno.Text;
            curso.Value = txtCurso.Text;
            endereco.Value = txtEndereco.Text;
            bairro.Value = txtBairro.Text;
            cep.Value = txtCep.Text;
            emailAluno.Value = txtEmailAluno.Text;
            mensalidade.Value = txtMensalidade.Text;
            responsavel.Value = txtNomeResponsavel.Text;
            emailResponsavel.Value = txtEmailResponsavel.Text;
            celularResponsavel.Value = txtCelularResponsavel.Text;
            if (rgbConcluido.Checked)
                concluido.Value = "SIM";
            else
                concluido.Value = "NÃO";

            comando.Parameters.Add(aluno);
            comando.Parameters.Add(nascimento);
            comando.Parameters.Add(celularAluno);
            comando.Parameters.Add(curso);
            comando.Parameters.Add(endereco);
            comando.Parameters.Add(bairro);
            comando.Parameters.Add(cep);
            comando.Parameters.Add(emailAluno);
            comando.Parameters.Add(mensalidade);
            comando.Parameters.Add(responsavel);
            comando.Parameters.Add(emailResponsavel);
            comando.Parameters.Add(celularResponsavel);
            comando.Parameters.Add(concluido);


            try
            {
                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro SALVO com SUCESSO!", "SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sair do Sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        void LimparCampos()
        {
            txtNomeAluno.Text = "";
            txtNascimento.Text = "";
            txtCelularAluno.Text = "";
            txtCurso.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtEmailAluno.Text = "";
            txtMensalidade.Text = "";
            txtNomeResponsavel.Text = "";
            txtEmailResponsavel.Text = "";
            txtCelularResponsavel.Text = "";
            txtCodigo.Text = "";
            rgbConcluido.Checked = false;
            txtNomeAluno.Focus();            
        }

        bool Validar()
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtNomeAluno.Text))
            {
                errorProvider.SetError(txtNomeAluno, "Informe o nome do aluno!");
                errorProvider.SetIconPadding(txtNomeAluno, -20);
                txtNomeAluno.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNascimento.Text))
            {
                errorProvider.SetError(txtNascimento, "Informe a data de nascimento do aluno!");
                errorProvider.SetIconPadding(txtNascimento, -20);
                txtNascimento.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCelularAluno.Text))
            {
                errorProvider.SetError(txtCelularAluno, "Informe o celular do aluno!");
                errorProvider.SetIconPadding(txtCelularAluno, -20);
                txtCelularAluno.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCurso.Text))
            {
                errorProvider.SetError(txtCurso, "Informe o curso!");
                errorProvider.SetIconPadding(txtCurso, -20);
                txtCurso.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                errorProvider.SetError(txtEndereco, "Informe o endereço!");
                errorProvider.SetIconPadding(txtEndereco, -20);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                errorProvider.SetError(txtBairro, "Informe o bairro!");
                errorProvider.SetIconPadding(txtBairro, -20);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                errorProvider.SetError(txtCep, "Informe o cep!");
                errorProvider.SetIconPadding(txtCep, -20);
                txtCep.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmailAluno.Text))
            {
                errorProvider.SetError(txtEmailAluno, "Informe o email do aluno!");
                errorProvider.SetIconPadding(txtEmailAluno, -20);
                txtEmailAluno.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMensalidade.Text))
            {
                errorProvider.SetError(txtMensalidade, "Informe a mensalidade!");
                errorProvider.SetIconPadding(txtMensalidade, -20);
                txtMensalidade.Focus();
                return false;
            }            
            return true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisa frmPesquisa = new FrmPesquisa();
            this.Hide();
            frmPesquisa.ShowDialog();
            this.Close();
        }
    }
}
