namespace EscolaMusica
{
    partial class FrmPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisa));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvCadastros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(133, 12);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(335, 26);
            this.txtPesquisa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Aluno:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Turma",
            "Turno"});
            this.comboBox1.Location = new System.Drawing.Point(656, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // dgvCadastros
            // 
            this.dgvCadastros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.aluno,
            this.nascimento,
            this.celularAluno,
            this.curso,
            this.endereco,
            this.bairro,
            this.cep,
            this.emailAluno,
            this.mensalidade,
            this.responsavel,
            this.emailResponsavel,
            this.celularResponsavel});
            this.dgvCadastros.Location = new System.Drawing.Point(9, 64);
            this.dgvCadastros.Name = "dgvCadastros";
            this.dgvCadastros.Size = new System.Drawing.Size(779, 374);
            this.dgvCadastros.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtrar por:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::EscolaMusica.Properties.Resources.zoom;
            this.btnPesquisar.Location = new System.Drawing.Point(474, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(51, 26);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // aluno
            // 
            this.aluno.HeaderText = "Aluno";
            this.aluno.Name = "aluno";
            // 
            // nascimento
            // 
            this.nascimento.HeaderText = "Data de nascimento";
            this.nascimento.Name = "nascimento";
            // 
            // celularAluno
            // 
            this.celularAluno.HeaderText = "Celular do aluno";
            this.celularAluno.Name = "celularAluno";
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            // 
            // bairro
            // 
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            // 
            // cep
            // 
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            // 
            // emailAluno
            // 
            this.emailAluno.HeaderText = "Email do aluno";
            this.emailAluno.Name = "emailAluno";
            // 
            // mensalidade
            // 
            this.mensalidade.HeaderText = "Mensalidade";
            this.mensalidade.Name = "mensalidade";
            // 
            // responsavel
            // 
            this.responsavel.HeaderText = "Nome do responsável";
            this.responsavel.Name = "responsavel";
            // 
            // emailResponsavel
            // 
            this.emailResponsavel.HeaderText = "Email do responsável";
            this.emailResponsavel.Name = "emailResponsavel";
            // 
            // celularResponsavel
            // 
            this.celularResponsavel.HeaderText = "Celular do responsável";
            this.celularResponsavel.Name = "celularResponsavel";
            // 
            // FrmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCadastros);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Pesquisar Aluno :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvCadastros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularResponsavel;
    }
}