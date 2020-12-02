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
        }

        private void FrmPesquisa_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM cadastro", conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        // Adiciona na grid os produtos cadastrados no banco de dados.
                        dgvCadastros.Rows.Add(item["codigo"].ToString(), item["aluno"].ToString(), item["nascimento"].ToString(), item["celularAluno"].ToString(), item["curso"].ToString(), item["endereco"].ToString(), item["bairro"].ToString(), item["cep"].ToString(), item["emailAluno"].ToString(), item["mensalidade"].ToString(), item["responsavel"].ToString(), item["emailResponsavel"].ToString(), item["celularResponsavel"].ToString());
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
    }
}
