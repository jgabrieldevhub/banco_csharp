namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbIdResultado = new System.Windows.Forms.Label();
            this.lbDataResultado = new System.Windows.Forms.Label();
            this.lbServicoResultado = new System.Windows.Forms.Label();
            this.lbNomeResultado = new System.Windows.Forms.Label();
            this.dgvListarTudo = new System.Windows.Forms.DataGridView();
            this.btnConsultarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTudo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(148, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 31);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Location = new System.Drawing.Point(148, 131);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(251, 20);
            this.dtpData.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(21, 232);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(186, 55);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(21, 293);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(186, 55);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(213, 232);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(186, 55);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "btnConsultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(213, 293);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(186, 55);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cbServico
            // 
            this.cbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Items.AddRange(new object[] {
            "Corte",
            "Barba",
            "Lavagem",
            "Qualquer Coisa"});
            this.cbServico.Location = new System.Drawing.Point(148, 86);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(251, 33);
            this.cbServico.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(148, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(251, 31);
            this.txtId.TabIndex = 12;
            // 
            // lbIdResultado
            // 
            this.lbIdResultado.AutoSize = true;
            this.lbIdResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdResultado.Location = new System.Drawing.Point(453, 15);
            this.lbIdResultado.Name = "lbIdResultado";
            this.lbIdResultado.Size = new System.Drawing.Size(29, 25);
            this.lbIdResultado.TabIndex = 17;
            this.lbIdResultado.Text = "Id";
            // 
            // lbDataResultado
            // 
            this.lbDataResultado.AutoSize = true;
            this.lbDataResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataResultado.Location = new System.Drawing.Point(453, 126);
            this.lbDataResultado.Name = "lbDataResultado";
            this.lbDataResultado.Size = new System.Drawing.Size(57, 25);
            this.lbDataResultado.TabIndex = 16;
            this.lbDataResultado.Text = "Data";
            // 
            // lbServicoResultado
            // 
            this.lbServicoResultado.AutoSize = true;
            this.lbServicoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServicoResultado.Location = new System.Drawing.Point(453, 89);
            this.lbServicoResultado.Name = "lbServicoResultado";
            this.lbServicoResultado.Size = new System.Drawing.Size(84, 25);
            this.lbServicoResultado.TabIndex = 15;
            this.lbServicoResultado.Text = "Serviço";
            // 
            // lbNomeResultado
            // 
            this.lbNomeResultado.AutoSize = true;
            this.lbNomeResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeResultado.Location = new System.Drawing.Point(453, 52);
            this.lbNomeResultado.Name = "lbNomeResultado";
            this.lbNomeResultado.Size = new System.Drawing.Size(68, 25);
            this.lbNomeResultado.TabIndex = 14;
            this.lbNomeResultado.Text = "Nome";
            // 
            // dgvListarTudo
            // 
            this.dgvListarTudo.AllowUserToAddRows = false;
            this.dgvListarTudo.AllowUserToDeleteRows = false;
            this.dgvListarTudo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarTudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarTudo.Location = new System.Drawing.Point(422, 176);
            this.dgvListarTudo.Name = "dgvListarTudo";
            this.dgvListarTudo.ReadOnly = true;
            this.dgvListarTudo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarTudo.Size = new System.Drawing.Size(416, 270);
            this.dgvListarTudo.TabIndex = 18;
            // 
            // btnConsultarLista
            // 
            this.btnConsultarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLista.Location = new System.Drawing.Point(21, 354);
            this.btnConsultarLista.Name = "btnConsultarLista";
            this.btnConsultarLista.Size = new System.Drawing.Size(378, 55);
            this.btnConsultarLista.TabIndex = 19;
            this.btnConsultarLista.Text = "btnConsultarLista";
            this.btnConsultarLista.UseVisualStyleBackColor = true;
            this.btnConsultarLista.Click += new System.EventHandler(this.btnConsultarLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 458);
            this.Controls.Add(this.btnConsultarLista);
            this.Controls.Add(this.dgvListarTudo);
            this.Controls.Add(this.lbIdResultado);
            this.Controls.Add(this.lbDataResultado);
            this.Controls.Add(this.lbServicoResultado);
            this.Controls.Add(this.lbNomeResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbServico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbIdResultado;
        private System.Windows.Forms.Label lbDataResultado;
        private System.Windows.Forms.Label lbServicoResultado;
        private System.Windows.Forms.Label lbNomeResultado;
        private System.Windows.Forms.DataGridView dgvListarTudo;
        private System.Windows.Forms.Button btnConsultarLista;
    }
}

