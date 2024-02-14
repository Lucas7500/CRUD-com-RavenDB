namespace ControleAlunos.InteracaoUsuarioForms
{
    partial class ListagemAlunos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ListaAlunos = new DataGridView();
            alunoBindingSource = new BindingSource(components);
            botaoRemover = new Button();
            botaoEditar = new Button();
            botaoAdicionar = new Button();
            colunaId = new DataGridViewTextBoxColumn();
            colunaMatricula = new DataGridViewTextBoxColumn();
            colunaNome = new DataGridViewTextBoxColumn();
            colunaEmail = new DataGridViewTextBoxColumn();
            colunaMediaGlobal = new DataGridViewTextBoxColumn();
            colunaFormacao = new DataGridViewTextBoxColumn();
            colunaCurso = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ListaAlunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alunoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ListaAlunos
            // 
            ListaAlunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ListaAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListaAlunos.AutoGenerateColumns = false;
            ListaAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListaAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListaAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListaAlunos.Columns.AddRange(new DataGridViewColumn[] { colunaId, colunaMatricula, colunaNome, colunaEmail, colunaMediaGlobal, colunaFormacao, colunaCurso });
            ListaAlunos.DataSource = alunoBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListaAlunos.DefaultCellStyle = dataGridViewCellStyle3;
            ListaAlunos.Location = new Point(12, 12);
            ListaAlunos.MultiSelect = false;
            ListaAlunos.Name = "ListaAlunos";
            ListaAlunos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ListaAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ListaAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListaAlunos.Size = new Size(776, 390);
            ListaAlunos.TabIndex = 0;
            // 
            // alunoBindingSource
            // 
            alunoBindingSource.DataSource = typeof(Dominio.Entidades.Aluno);
            // 
            // botaoRemover
            // 
            botaoRemover.Location = new Point(668, 408);
            botaoRemover.Name = "botaoRemover";
            botaoRemover.Size = new Size(120, 33);
            botaoRemover.TabIndex = 3;
            botaoRemover.Text = "Remover";
            botaoRemover.UseVisualStyleBackColor = true;
            botaoRemover.Click += Ao_Clicar_Remover;
            // 
            // botaoEditar
            // 
            botaoEditar.Location = new Point(533, 408);
            botaoEditar.Name = "botaoEditar";
            botaoEditar.Size = new Size(120, 33);
            botaoEditar.TabIndex = 2;
            botaoEditar.Text = "Editar";
            botaoEditar.UseVisualStyleBackColor = true;
            botaoEditar.Click += Ao_Clicar_Editar;
            // 
            // botaoAdicionar
            // 
            botaoAdicionar.Location = new Point(398, 408);
            botaoAdicionar.Name = "botaoAdicionar";
            botaoAdicionar.Size = new Size(120, 33);
            botaoAdicionar.TabIndex = 1;
            botaoAdicionar.Text = "Adicionar";
            botaoAdicionar.UseVisualStyleBackColor = true;
            botaoAdicionar.Click += Ao_Clicar_Em_Adicionar;
            // 
            // colunaId
            // 
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "Id";
            colunaId.Name = "colunaId";
            colunaId.ReadOnly = true;
            colunaId.Visible = false;
            // 
            // colunaMatricula
            // 
            colunaMatricula.DataPropertyName = "Matricula";
            colunaMatricula.HeaderText = "Matrícula";
            colunaMatricula.Name = "colunaMatricula";
            colunaMatricula.ReadOnly = true;
            // 
            // colunaNome
            // 
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome";
            colunaNome.Name = "colunaNome";
            colunaNome.ReadOnly = true;
            // 
            // colunaEmail
            // 
            colunaEmail.DataPropertyName = "Email";
            colunaEmail.HeaderText = "Email";
            colunaEmail.Name = "colunaEmail";
            colunaEmail.ReadOnly = true;
            // 
            // colunaMediaGlobal
            // 
            colunaMediaGlobal.DataPropertyName = "MediaGlobal";
            colunaMediaGlobal.HeaderText = "Média Global";
            colunaMediaGlobal.Name = "colunaMediaGlobal";
            colunaMediaGlobal.ReadOnly = true;
            // 
            // colunaFormacao
            // 
            colunaFormacao.DataPropertyName = "Formacao";
            colunaFormacao.HeaderText = "Formação";
            colunaFormacao.Name = "colunaFormacao";
            colunaFormacao.ReadOnly = true;
            // 
            // colunaCurso
            // 
            colunaCurso.DataPropertyName = "Curso";
            colunaCurso.HeaderText = "Curso";
            colunaCurso.Name = "colunaCurso";
            colunaCurso.ReadOnly = true;
            // 
            // ListagemAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoAdicionar);
            Controls.Add(botaoEditar);
            Controls.Add(botaoRemover);
            Controls.Add(ListaAlunos);
            MaximizeBox = false;
            Name = "ListagemAlunos";
            Text = "Listagem de Alunos";
            ((System.ComponentModel.ISupportInitialize)ListaAlunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)alunoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListaAlunos;
        private Button botaoRemover;
        private Button botaoEditar;
        private Button botaoAdicionar;
        private BindingSource alunoBindingSource;
        private DataGridViewTextBoxColumn colunaId;
        private DataGridViewTextBoxColumn colunaMatricula;
        private DataGridViewTextBoxColumn colunaNome;
        private DataGridViewTextBoxColumn colunaEmail;
        private DataGridViewTextBoxColumn colunaMediaGlobal;
        private DataGridViewTextBoxColumn colunaFormacao;
        private DataGridViewTextBoxColumn colunaCurso;
    }
}
