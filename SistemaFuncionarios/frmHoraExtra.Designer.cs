namespace SistemaFuncionarios
{
    partial class frmHoraExtra
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
            this.cbProfissionais = new System.Windows.Forms.ComboBox();
            this.numHorasExtras = new System.Windows.Forms.NumericUpDown();
            this.txtSalarioAtual = new System.Windows.Forms.TextBox();
            this.txtValorHoraExtra = new System.Windows.Forms.TextBox();
            this.txtTotalHorasExtras = new System.Windows.Forms.TextBox();
            this.txtSalarioTotal = new System.Windows.Forms.TextBox();
            this.lblPofissionalHE = new System.Windows.Forms.Label();
            this.lblHEtrabalhadas = new System.Windows.Forms.Label();
            this.lblSalarioAtual = new System.Windows.Forms.Label();
            this.lblValorHE = new System.Windows.Forms.Label();
            this.lblSalTotal = new System.Windows.Forms.Label();
            this.btnCalcularHoraExtra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasExtras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProfissionais
            // 
            this.cbProfissionais.FormattingEnabled = true;
            this.cbProfissionais.Location = new System.Drawing.Point(9, 18);
            this.cbProfissionais.Name = "cbProfissionais";
            this.cbProfissionais.Size = new System.Drawing.Size(294, 21);
            this.cbProfissionais.TabIndex = 0;
            this.cbProfissionais.SelectedIndexChanged += new System.EventHandler(this.cbProfissionais_SelectedIndexChanged);
            // 
            // numHorasExtras
            // 
            this.numHorasExtras.Location = new System.Drawing.Point(159, 87);
            this.numHorasExtras.Name = "numHorasExtras";
            this.numHorasExtras.Size = new System.Drawing.Size(56, 20);
            this.numHorasExtras.TabIndex = 1;
            this.numHorasExtras.ValueChanged += new System.EventHandler(this.numHorasExtras_ValueChanged);
            // 
            // txtSalarioAtual
            // 
            this.txtSalarioAtual.Location = new System.Drawing.Point(403, 23);
            this.txtSalarioAtual.Name = "txtSalarioAtual";
            this.txtSalarioAtual.ReadOnly = true;
            this.txtSalarioAtual.Size = new System.Drawing.Size(121, 20);
            this.txtSalarioAtual.TabIndex = 2;
            // 
            // txtValorHoraExtra
            // 
            this.txtValorHoraExtra.Location = new System.Drawing.Point(403, 87);
            this.txtValorHoraExtra.Name = "txtValorHoraExtra";
            this.txtValorHoraExtra.ReadOnly = true;
            this.txtValorHoraExtra.Size = new System.Drawing.Size(121, 20);
            this.txtValorHoraExtra.TabIndex = 3;
            // 
            // txtTotalHorasExtras
            // 
            this.txtTotalHorasExtras.Location = new System.Drawing.Point(178, 66);
            this.txtTotalHorasExtras.Name = "txtTotalHorasExtras";
            this.txtTotalHorasExtras.Size = new System.Drawing.Size(121, 20);
            this.txtTotalHorasExtras.TabIndex = 4;
            // 
            // txtSalarioTotal
            // 
            this.txtSalarioTotal.Location = new System.Drawing.Point(178, 120);
            this.txtSalarioTotal.Name = "txtSalarioTotal";
            this.txtSalarioTotal.Size = new System.Drawing.Size(121, 20);
            this.txtSalarioTotal.TabIndex = 5;
            // 
            // lblPofissionalHE
            // 
            this.lblPofissionalHE.AutoSize = true;
            this.lblPofissionalHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPofissionalHE.Location = new System.Drawing.Point(6, 0);
            this.lblPofissionalHE.Name = "lblPofissionalHE";
            this.lblPofissionalHE.Size = new System.Drawing.Size(147, 15);
            this.lblPofissionalHE.TabIndex = 6;
            this.lblPofissionalHE.Text = "Funcionário Selecionado:";
            // 
            // lblHEtrabalhadas
            // 
            this.lblHEtrabalhadas.AutoSize = true;
            this.lblHEtrabalhadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblHEtrabalhadas.Location = new System.Drawing.Point(11, 87);
            this.lblHEtrabalhadas.Name = "lblHEtrabalhadas";
            this.lblHEtrabalhadas.Size = new System.Drawing.Size(142, 16);
            this.lblHEtrabalhadas.TabIndex = 7;
            this.lblHEtrabalhadas.Text = "Horas Extras (Informe):";
            // 
            // lblSalarioAtual
            // 
            this.lblSalarioAtual.AutoSize = true;
            this.lblSalarioAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblSalarioAtual.Location = new System.Drawing.Point(309, 23);
            this.lblSalarioAtual.Name = "lblSalarioAtual";
            this.lblSalarioAtual.Size = new System.Drawing.Size(88, 16);
            this.lblSalarioAtual.TabIndex = 8;
            this.lblSalarioAtual.Text = "Salário Base:";
            // 
            // lblValorHE
            // 
            this.lblValorHE.AutoSize = true;
            this.lblValorHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblValorHE.Location = new System.Drawing.Point(22, 70);
            this.lblValorHE.Name = "lblValorHE";
            this.lblValorHE.Size = new System.Drawing.Size(127, 16);
            this.lblValorHE.TabIndex = 9;
            this.lblValorHE.Text = "Valor da Hora Extra:";
            // 
            // lblSalTotal
            // 
            this.lblSalTotal.AutoSize = true;
            this.lblSalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblSalTotal.Location = new System.Drawing.Point(7, 121);
            this.lblSalTotal.Name = "lblSalTotal";
            this.lblSalTotal.Size = new System.Drawing.Size(153, 16);
            this.lblSalTotal.TabIndex = 10;
            this.lblSalTotal.Text = "Salário Total deste mês:";
            // 
            // btnCalcularHoraExtra
            // 
            this.btnCalcularHoraExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCalcularHoraExtra.Location = new System.Drawing.Point(6, 19);
            this.btnCalcularHoraExtra.Name = "btnCalcularHoraExtra";
            this.btnCalcularHoraExtra.Size = new System.Drawing.Size(150, 21);
            this.btnCalcularHoraExtra.TabIndex = 11;
            this.btnCalcularHoraExtra.Text = "Calcular Hora Extra";
            this.btnCalcularHoraExtra.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.cbProfissionais);
            this.groupBox1.Controls.Add(this.lblPofissionalHE);
            this.groupBox1.Controls.Add(this.txtValorHoraExtra);
            this.groupBox1.Controls.Add(this.lblSalarioAtual);
            this.groupBox1.Controls.Add(this.txtSalarioAtual);
            this.groupBox1.Controls.Add(this.lblHEtrabalhadas);
            this.groupBox1.Controls.Add(this.numHorasExtras);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 115);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.btnCalcularHoraExtra);
            this.gbResultados.Controls.Add(this.txtSalarioTotal);
            this.gbResultados.Controls.Add(this.lblSalTotal);
            this.gbResultados.Controls.Add(this.txtTotalHorasExtras);
            this.gbResultados.Controls.Add(this.lblValorHE);
            this.gbResultados.Location = new System.Drawing.Point(16, 144);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(532, 163);
            this.gbResultados.TabIndex = 13;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultado:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblInfo.Location = new System.Drawing.Point(305, 87);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(92, 16);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "5% do salário:";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(473, 385);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(0, 13);
            this.lblInfo2.TabIndex = 14;
            // 
            // frmHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 691);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoraExtra";
            this.Text = "frmHoraExtra";
            ((System.ComponentModel.ISupportInitialize)(this.numHorasExtras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProfissionais;
        private System.Windows.Forms.NumericUpDown numHorasExtras;
        private System.Windows.Forms.TextBox txtSalarioAtual;
        private System.Windows.Forms.TextBox txtValorHoraExtra;
        private System.Windows.Forms.TextBox txtTotalHorasExtras;
        private System.Windows.Forms.TextBox txtSalarioTotal;
        private System.Windows.Forms.Label lblPofissionalHE;
        private System.Windows.Forms.Label lblHEtrabalhadas;
        private System.Windows.Forms.Label lblSalarioAtual;
        private System.Windows.Forms.Label lblValorHE;
        private System.Windows.Forms.Label lblSalTotal;
        private System.Windows.Forms.Button btnCalcularHoraExtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblInfo2;
    }
}