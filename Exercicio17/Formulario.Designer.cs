
namespace Exercicio17
{
    partial class Form
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
            this.gbGerente = new System.Windows.Forms.GroupBox();
            this.numericgerente = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbonus = new System.Windows.Forms.TextBox();
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtporcent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMetas = new System.Windows.Forms.TextBox();
            this.gbPeao = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoraExtra = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbGerente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericgerente)).BeginInit();
            this.gbVendedor.SuspendLayout();
            this.gbPeao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGerente
            // 
            this.gbGerente.Controls.Add(this.numericgerente);
            this.gbGerente.Controls.Add(this.btnSave);
            this.gbGerente.Controls.Add(this.label5);
            this.gbGerente.Controls.Add(this.label4);
            this.gbGerente.Controls.Add(this.txtbonus);
            this.gbGerente.Enabled = false;
            this.gbGerente.Location = new System.Drawing.Point(26, 189);
            this.gbGerente.Name = "gbGerente";
            this.gbGerente.Size = new System.Drawing.Size(200, 237);
            this.gbGerente.TabIndex = 0;
            this.gbGerente.TabStop = false;
            this.gbGerente.Text = "Gerente";
            // 
            // numericgerente
            // 
            this.numericgerente.Location = new System.Drawing.Point(15, 122);
            this.numericgerente.Name = "numericgerente";
            this.numericgerente.Size = new System.Drawing.Size(169, 20);
            this.numericgerente.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSave.Location = new System.Drawing.Point(41, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Salvar Dados";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Funcionarios \r\nSubordinados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bonus";
            // 
            // txtbonus
            // 
            this.txtbonus.Location = new System.Drawing.Point(15, 52);
            this.txtbonus.Name = "txtbonus";
            this.txtbonus.Size = new System.Drawing.Size(169, 20);
            this.txtbonus.TabIndex = 10;
            // 
            // gbVendedor
            // 
            this.gbVendedor.Controls.Add(this.button2);
            this.gbVendedor.Controls.Add(this.label9);
            this.gbVendedor.Controls.Add(this.txtporcent);
            this.gbVendedor.Controls.Add(this.label8);
            this.gbVendedor.Controls.Add(this.txtVendas);
            this.gbVendedor.Controls.Add(this.label7);
            this.gbVendedor.Controls.Add(this.txtMetas);
            this.gbVendedor.Enabled = false;
            this.gbVendedor.Location = new System.Drawing.Point(251, 189);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.Size = new System.Drawing.Size(200, 237);
            this.gbVendedor.TabIndex = 1;
            this.gbVendedor.TabStop = false;
            this.gbVendedor.Text = "Vendedor";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Location = new System.Drawing.Point(44, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Salvar Dados";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Porcentagem";
            // 
            // txtporcent
            // 
            this.txtporcent.Location = new System.Drawing.Point(18, 154);
            this.txtporcent.Name = "txtporcent";
            this.txtporcent.Size = new System.Drawing.Size(169, 20);
            this.txtporcent.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vendas";
            // 
            // txtVendas
            // 
            this.txtVendas.Location = new System.Drawing.Point(18, 102);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(169, 20);
            this.txtVendas.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Metas";
            // 
            // txtMetas
            // 
            this.txtMetas.Location = new System.Drawing.Point(19, 52);
            this.txtMetas.Name = "txtMetas";
            this.txtMetas.Size = new System.Drawing.Size(169, 20);
            this.txtMetas.TabIndex = 18;
            // 
            // gbPeao
            // 
            this.gbPeao.Controls.Add(this.button3);
            this.gbPeao.Controls.Add(this.label6);
            this.gbPeao.Controls.Add(this.txtHoraExtra);
            this.gbPeao.Enabled = false;
            this.gbPeao.Location = new System.Drawing.Point(480, 189);
            this.gbPeao.Name = "gbPeao";
            this.gbPeao.Size = new System.Drawing.Size(200, 237);
            this.gbPeao.TabIndex = 1;
            this.gbPeao.TabStop = false;
            this.gbPeao.Text = "Peão";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSalmon;
            this.button3.Location = new System.Drawing.Point(40, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Salvar Dados";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SavePeao);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hora Extra (Reais)";
            // 
            // txtHoraExtra
            // 
            this.txtHoraExtra.Location = new System.Drawing.Point(10, 52);
            this.txtHoraExtra.Name = "txtHoraExtra";
            this.txtHoraExtra.Size = new System.Drawing.Size(169, 20);
            this.txtHoraExtra.TabIndex = 16;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.LightSalmon;
            this.btnExibir.Location = new System.Drawing.Point(567, 122);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(113, 40);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir Dados";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salario";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(403, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(90, 104);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(169, 20);
            this.txtSalario.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Location = new System.Drawing.Point(567, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Acesso ao Sistema";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnAcesso_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(90, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(169, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 438);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.gbPeao);
            this.Controls.Add(this.gbVendedor);
            this.Controls.Add(this.gbGerente);
            this.Name = "Form";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGerente.ResumeLayout(false);
            this.gbGerente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericgerente)).EndInit();
            this.gbVendedor.ResumeLayout(false);
            this.gbVendedor.PerformLayout();
            this.gbPeao.ResumeLayout(false);
            this.gbPeao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGerente;
        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.GroupBox gbPeao;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtbonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoraExtra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtporcent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMetas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericgerente;
    }
}