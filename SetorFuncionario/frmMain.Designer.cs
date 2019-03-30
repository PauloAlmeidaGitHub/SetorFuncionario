namespace SetorFuncionario
{
    partial class frmMain
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
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSetor = new System.Windows.Forms.Button();
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.txtDataAdmissao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.groupBoxFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(13, 26);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(775, 350);
            this.dgvFuncionarios.TabIndex = 0;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 392);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSetor
            // 
            this.btnSetor.Location = new System.Drawing.Point(107, 392);
            this.btnSetor.Name = "btnSetor";
            this.btnSetor.Size = new System.Drawing.Size(75, 23);
            this.btnSetor.TabIndex = 2;
            this.btnSetor.Text = "Setores";
            this.btnSetor.UseVisualStyleBackColor = true;
            this.btnSetor.Click += new System.EventHandler(this.btnSetor_Click);
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.btnExcluir);
            this.groupBoxFuncionario.Controls.Add(this.btnSalvar);
            this.groupBoxFuncionario.Controls.Add(this.cmbSetor);
            this.groupBoxFuncionario.Controls.Add(this.txtDataAdmissao);
            this.groupBoxFuncionario.Controls.Add(this.txtNome);
            this.groupBoxFuncionario.Controls.Add(this.txtId);
            this.groupBoxFuncionario.Controls.Add(this.label4);
            this.groupBoxFuncionario.Controls.Add(this.label3);
            this.groupBoxFuncionario.Controls.Add(this.label2);
            this.groupBoxFuncionario.Controls.Add(this.label1);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(13, 421);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Size = new System.Drawing.Size(775, 170);
            this.groupBoxFuncionario.TabIndex = 3;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Funcionários";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(114, 141);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 141);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbSetor
            // 
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(80, 98);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(283, 21);
            this.cmbSetor.TabIndex = 7;
            // 
            // txtDataAdmissao
            // 
            this.txtDataAdmissao.Location = new System.Drawing.Point(80, 75);
            this.txtDataAdmissao.Name = "txtDataAdmissao";
            this.txtDataAdmissao.Size = new System.Drawing.Size(100, 20);
            this.txtDataAdmissao.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(80, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 20);
            this.txtId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Setor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admissão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.groupBoxFuncionario);
            this.Controls.Add(this.btnSetor);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvFuncionarios);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setor / Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSetor;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataAdmissao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}

