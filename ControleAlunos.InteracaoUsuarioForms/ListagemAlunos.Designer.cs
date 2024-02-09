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
            dataGridView1 = new DataGridView();
            botaoRemover = new Button();
            botaoEditar = new Button();
            botaoAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 390);
            dataGridView1.TabIndex = 0;
            // 
            // botaoRemover
            // 
            botaoRemover.Location = new Point(668, 408);
            botaoRemover.Name = "botaoRemover";
            botaoRemover.Size = new Size(120, 33);
            botaoRemover.TabIndex = 1;
            botaoRemover.Text = "Remover";
            botaoRemover.UseVisualStyleBackColor = true;
            // 
            // botaoEditar
            // 
            botaoEditar.Location = new Point(542, 408);
            botaoEditar.Name = "botaoEditar";
            botaoEditar.Size = new Size(120, 33);
            botaoEditar.TabIndex = 2;
            botaoEditar.Text = "Editar";
            botaoEditar.UseVisualStyleBackColor = true;
            // 
            // botaoAdicionar
            // 
            botaoAdicionar.Location = new Point(12, 408);
            botaoAdicionar.Name = "botaoAdicionar";
            botaoAdicionar.Size = new Size(120, 33);
            botaoAdicionar.TabIndex = 3;
            botaoAdicionar.Text = "Adicionar";
            botaoAdicionar.UseVisualStyleBackColor = true;
            botaoAdicionar.Click += Ao_Clicar_Em_Adicionar;
            // 
            // ListagemAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoAdicionar);
            Controls.Add(botaoEditar);
            Controls.Add(botaoRemover);
            Controls.Add(dataGridView1);
            Name = "ListagemAlunos";
            Text = "Listagem de Alunos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button botaoRemover;
        private Button botaoEditar;
        private Button botaoAdicionar;
    }
}
