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
        // String de conexão com o banco de dados.
        /*SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-BBF5M1P\SQLEXPRESS;Initial Catalog=EscolaMusica;Integrated Security=True");*/

        const string StringConexao = @"Data Source=DESKTOP-BBF5M1P\SQLEXPRESS;Initial Catalog=EscolaMusica;Integrated Security=True";

        SqlConnection conexao = new SqlConnection(StringConexao);

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPesquisa frmPesquisa = new FrmPesquisa();
            frmPesquisa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            adicionaAluno();
        }

        void adicionaAluno()
        {
            SqlCommand comando = new SqlCommand("INSERT INTO cadastro (aluno, nascimento, celularAluno, curso, endereco, bairro, cep, emailAluno, mensalidade, responsavel, emailResponsavel, celularResponsavel) VALUES (@aluno, @nascimento, @celularAluno, @curso, @endereco, @bairro, @cep, @emailAluno, @mensalidade, @responsavel, @emailResponsavel, @celularResponsavel)", conexao);

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
            txtNomeAluno.Focus();
        }
    }
}
