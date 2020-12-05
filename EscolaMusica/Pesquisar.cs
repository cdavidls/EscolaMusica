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
    public partial class FrmPesquisa : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-BBF5M1P\SQLEXPRESS;Initial Catalog=EscolaMusica;Integrated Security=True");

        public FrmPesquisa()
        {
            InitializeComponent();
            CarregaCadastros();
        }

        private void FrmPesquisa_Load(object sender, EventArgs e)
        {

        }

        void CarregaCadastros()
        {

            try
            {
                conexao.Open();

                SqlCommand comando = new SqlCommand("SELECT * FROM cadastro WHERE aluno LIKE '%" + txtPesquisa.Text + "%'", conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        // Adiciona na grid os produtos cadastrados no banco de dados.
                        dgvCadastros.Rows.Add(item["codigo"].ToString(), item["aluno"].ToString(), item["nascimento"].ToString(), item["celularAluno"].ToString(), item["curso"].ToString(), item["endereco"].ToString(), item["bairro"].ToString(), item["cep"].ToString(), item["emailAluno"].ToString(), item["mensalidade"].ToString(), item["responsavel"].ToString(), item["emailResponsavel"].ToString(), item["celularResponsavel"].ToString(), item["concluido"].ToString());
                    }
                }
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvCadastros.Rows.Clear();
            CarregaCadastros();
            
            //try
            //{
            //    conexao.Open();

            //    SqlCommand comando = new SqlCommand("SELECT codigo, aluno, nascimento, celularAluno, curso, endereco, bairro, cep, emailAluno, mensalidade, responsavel, emailResponsavel, celularResponsavel, concluido FROM cadastro WHERE aluno LIKE '%" + txtPesquisa.Text + "%'", conexao);
            //    SqlDataAdapter da = new SqlDataAdapter(comando);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
                
            //    if (dt.Rows.Count > 0)
            //    {
                    
            //        foreach (DataRow item in dt.Rows)
            //        {
                        
                        
            //            // Adiciona na grid os produtos cadastrados no banco de dados.
            //            dgvCadastros.Rows.Add(item["codigo"].ToString(), item["aluno"].ToString(), item["nascimento"].ToString(), item["celularAluno"].ToString(), item["curso"].ToString(), item["endereco"].ToString(), item["bairro"].ToString(), item["cep"].ToString(), item["emailAluno"].ToString(), item["mensalidade"].ToString(), item["responsavel"].ToString(), item["emailResponsavel"].ToString(), item["celularResponsavel"].ToString(), item["concluido"].ToString());
            //        }
            //    }
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show(erro.Message);
            //}
            //finally
            //{
            //    conexao.Close();
            //}
        }

        private void dgvCadastros_DoubleClick(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.txtCodigo.Text = this.dgvCadastros.CurrentRow.Cells[0].Value.ToString();
            F1.txtNomeAluno.Text = this.dgvCadastros.CurrentRow.Cells[1].Value.ToString();
            F1.txtNascimento.Text = this.dgvCadastros.CurrentRow.Cells[2].Value.ToString();
            F1.txtCelularAluno.Text = this.dgvCadastros.CurrentRow.Cells[3].Value.ToString();
            F1.txtCurso.Text = this.dgvCadastros.CurrentRow.Cells[4].Value.ToString();
            F1.txtEndereco.Text = this.dgvCadastros.CurrentRow.Cells[5].Value.ToString();
            F1.txtBairro.Text = this.dgvCadastros.CurrentRow.Cells[6].Value.ToString();
            F1.txtCep.Text = this.dgvCadastros.CurrentRow.Cells[7].Value.ToString();
            F1.txtEmailAluno.Text = this.dgvCadastros.CurrentRow.Cells[8].Value.ToString();
            F1.txtMensalidade.Text = this.dgvCadastros.CurrentRow.Cells[9].Value.ToString();
            F1.txtNomeResponsavel.Text = this.dgvCadastros.CurrentRow.Cells[10].Value.ToString();
            F1.txtEmailResponsavel.Text = this.dgvCadastros.CurrentRow.Cells[11].Value.ToString();
            F1.txtCelularResponsavel.Text = this.dgvCadastros.CurrentRow.Cells[12].Value.ToString();
            //F1.rgbConcluido.Checked = this.dgvCadastros.CurrentRow.Cells[13].Value.ToString();
            if (dgvCadastros.CurrentRow.Cells[13].Value.ToString() == "SIM")
                F1.rgbConcluido.Checked = true;
            F1.btnCadastrar.Text = "Atualizar";
            F1.ShowDialog();
        }
    }
}
