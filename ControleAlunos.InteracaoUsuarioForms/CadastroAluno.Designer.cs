namespace ControleAlunos.InteracaoUsuarioForms
{
    partial class CadastroAluno
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
            textBoxMatricula = new TextBox();
            textBoxEmail = new TextBox();
            textBoxMediaGlobal = new TextBox();
            textBoxNome = new TextBox();
            comboBoxCurso = new ComboBox();
            comboBoxFormacao = new ComboBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(120, 3);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(176, 23);
            textBoxMatricula.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(120, 105);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(176, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxMediaGlobal
            // 
            textBoxMediaGlobal.Location = new Point(120, 156);
            textBoxMediaGlobal.Name = "textBoxMediaGlobal";
            textBoxMediaGlobal.Size = new Size(176, 23);
            textBoxMediaGlobal.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(120, 54);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(176, 23);
            textBoxNome.TabIndex = 3;
            // 
            // comboBoxCurso
            // 
            comboBoxCurso.FormattingEnabled = true;
            comboBoxCurso.Location = new Point(120, 258);
            comboBoxCurso.Name = "comboBoxCurso";
            comboBoxCurso.Size = new Size(176, 23);
            comboBoxCurso.TabIndex = 4;
            // 
            // comboBoxFormacao
            // 
            comboBoxFormacao.FormattingEnabled = true;
            comboBoxFormacao.Location = new Point(120, 207);
            comboBoxFormacao.Name = "comboBoxFormacao";
            comboBoxFormacao.Size = new Size(176, 23);
            comboBoxFormacao.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Matrícula";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(comboBoxCurso, 1, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxMediaGlobal, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxMatricula, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxNome, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxFormacao, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(471, 308);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 255);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 11;
            label6.Text = "Curso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 204);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "Formação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 153);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 9;
            label4.Text = "Média Global";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 102);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 51);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // button1
            // 
            button1.Location = new Point(363, 327);
            button1.Name = "button1";
            button1.Size = new Size(120, 33);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Ao_Clicar_Cancelar;
            // 
            // button2
            // 
            button2.Location = new Point(12, 327);
            button2.Name = "button2";
            button2.Size = new Size(120, 33);
            button2.TabIndex = 9;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Ao_Clicar_Salvar;
            // 
            // CadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 372);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Name = "CadastroAluno";
            Text = "CadastroAluno";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxMatricula;
        private TextBox textBoxEmail;
        private TextBox textBoxMediaGlobal;
        private TextBox textBoxNome;
        private ComboBox comboBoxCurso;
        private ComboBox comboBoxFormacao;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}