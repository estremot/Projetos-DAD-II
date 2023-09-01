namespace Aula_11_08
{
    partial class FrmProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessor));
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFormacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblcodprofessor = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscaId = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRelatorio = new System.Windows.Forms.ToolStripButton();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.txtCodProfessor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(405, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Total Registros:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotal.Location = new System.Drawing.Point(500, 152);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 23);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 187);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 180);
            this.dataGridView1.TabIndex = 37;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(358, 107);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(62, 13);
            this.lblSalario.TabIndex = 33;
            this.lblSalario.Text = "Salário (R$)";
            this.lblSalario.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblFormacao
            // 
            this.lblFormacao.AutoSize = true;
            this.lblFormacao.Location = new System.Drawing.Point(12, 107);
            this.lblFormacao.Name = "lblFormacao";
            this.lblFormacao.Size = new System.Drawing.Size(54, 13);
            this.lblFormacao.TabIndex = 31;
            this.lblFormacao.Text = "Formação";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(118, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "Nome";
            // 
            // lblcodprofessor
            // 
            this.lblcodprofessor.AutoSize = true;
            this.lblcodprofessor.Location = new System.Drawing.Point(12, 60);
            this.lblcodprofessor.Name = "lblcodprofessor";
            this.lblcodprofessor.Size = new System.Drawing.Size(16, 13);
            this.lblcodprofessor.TabIndex = 29;
            this.lblcodprofessor.Text = "Id";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbSalvar,
            this.tsbCancelar,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.lblBuscaId,
            this.txtBuscar,
            this.btnBuscar,
            this.toolStripSeparator2,
            this.btnPrimeiro,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator3,
            this.btnRelatorio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "toolStripButton1";
            this.tsbNovo.ToolTipText = "Adicionar Novo Professor";
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvar.Text = "toolStripButton1";
            this.tsbSalvar.ToolTipText = "Salvar Professor";
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "toolStripButton1";
            this.tsbCancelar.ToolTipText = "Cancelar";
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbExcluir.Text = "toolStripButton1";
            this.tsbExcluir.ToolTipText = "Excluir Registro";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscaId
            // 
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(79, 22);
            this.lblBuscaId.Text = "Buscar por Id:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "toolStripButton1";
            this.btnBuscar.ToolTipText = "Buscar Cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiro.Image")));
            this.btnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.btnPrimeiro.Text = "toolStripButton1";
            this.btnPrimeiro.ToolTipText = "Primeiro Registro";
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(23, 22);
            this.btnAnterior.Text = "Registro Anterior";
            // 
            // btnProximo
            // 
            this.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(23, 22);
            this.btnProximo.Text = "toolStripButton1";
            this.btnProximo.ToolTipText = "Próximo Registro";
            // 
            // btnUltimo
            // 
            this.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(23, 22);
            this.btnUltimo.Text = "toolStripButton1";
            this.btnUltimo.ToolTipText = "Último Registro";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(23, 22);
            this.btnRelatorio.Text = "toolStripButton1";
            this.btnRelatorio.ToolTipText = "Gerar Relatório";
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(358, 123);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(199, 20);
            this.txtBairro.TabIndex = 24;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // txtFormacao
            // 
            this.txtFormacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormacao.Location = new System.Drawing.Point(12, 123);
            this.txtFormacao.MaxLength = 50;
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(340, 20);
            this.txtFormacao.TabIndex = 22;
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeProfessor.Location = new System.Drawing.Point(118, 76);
            this.txtNomeProfessor.MaxLength = 50;
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(439, 20);
            this.txtNomeProfessor.TabIndex = 21;
            // 
            // txtCodProfessor
            // 
            this.txtCodProfessor.Location = new System.Drawing.Point(12, 76);
            this.txtCodProfessor.Name = "txtCodProfessor";
            this.txtCodProfessor.ReadOnly = true;
            this.txtCodProfessor.Size = new System.Drawing.Size(100, 20);
            this.txtCodProfessor.TabIndex = 20;
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 390);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblFormacao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblcodprofessor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtFormacao);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.txtCodProfessor);
            this.Name = "FrmProfessor";
            this.Text = "Cadastro de Professores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFormacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblcodprofessor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblBuscaId;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPrimeiro;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRelatorio;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.TextBox txtCodProfessor;
    }
}