
namespace PrjCalculadoraBasica
{
    partial class FrmCalculadora
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnDiferenca = new System.Windows.Forms.Button();
            this.btnQuociente = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnResto = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.btnRaizquadrada = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(83, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora Básica";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(85, 133);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(44, 13);
            this.lblValor1.TabIndex = 1;
            this.lblValor1.Text = "Número";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(85, 162);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(44, 13);
            this.lblValor2.TabIndex = 2;
            this.lblValor2.Text = "Número";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(85, 377);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSoma.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(88, 204);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnDiferenca
            // 
            this.btnDiferenca.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDiferenca.Location = new System.Drawing.Point(203, 204);
            this.btnDiferenca.Name = "btnDiferenca";
            this.btnDiferenca.Size = new System.Drawing.Size(75, 23);
            this.btnDiferenca.TabIndex = 5;
            this.btnDiferenca.Text = "-";
            this.btnDiferenca.UseVisualStyleBackColor = false;
            this.btnDiferenca.Click += new System.EventHandler(this.btnDiferenca_Click);
            // 
            // btnQuociente
            // 
            this.btnQuociente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuociente.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuociente.Location = new System.Drawing.Point(88, 245);
            this.btnQuociente.Name = "btnQuociente";
            this.btnQuociente.Size = new System.Drawing.Size(75, 23);
            this.btnQuociente.TabIndex = 6;
            this.btnQuociente.Text = "/";
            this.btnQuociente.UseVisualStyleBackColor = false;
            this.btnQuociente.Click += new System.EventHandler(this.btnQuociente_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnProduto.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Location = new System.Drawing.Point(203, 245);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(75, 23);
            this.btnProduto.TabIndex = 7;
            this.btnProduto.Text = "*";
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnResto
            // 
            this.btnResto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnResto.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResto.Location = new System.Drawing.Point(88, 286);
            this.btnResto.Name = "btnResto";
            this.btnResto.Size = new System.Drawing.Size(75, 23);
            this.btnResto.TabIndex = 8;
            this.btnResto.Text = "Resto Div";
            this.btnResto.UseVisualStyleBackColor = false;
            this.btnResto.Click += new System.EventHandler(this.btnResto_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpar.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(203, 328);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tb_resultado
            // 
            this.tb_resultado.Location = new System.Drawing.Point(178, 374);
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.Size = new System.Drawing.Size(100, 20);
            this.tb_resultado.TabIndex = 10;
            // 
            // tb_num1
            // 
            this.tb_num1.Location = new System.Drawing.Point(178, 130);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(100, 20);
            this.tb_num1.TabIndex = 11;
            this.tb_num1.TextChanged += new System.EventHandler(this.tb_num1_TextChanged);
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(178, 162);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(100, 20);
            this.tb_num2.TabIndex = 12;
            this.tb_num2.TextChanged += new System.EventHandler(this.tb_num2_TextChanged);
            // 
            // btnRaizquadrada
            // 
            this.btnRaizquadrada.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRaizquadrada.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizquadrada.Location = new System.Drawing.Point(203, 286);
            this.btnRaizquadrada.Name = "btnRaizquadrada";
            this.btnRaizquadrada.Size = new System.Drawing.Size(75, 23);
            this.btnRaizquadrada.TabIndex = 13;
            this.btnRaizquadrada.Text = "√x";
            this.btnRaizquadrada.UseVisualStyleBackColor = false;
            this.btnRaizquadrada.Click += new System.EventHandler(this.btnRaizquadrada_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPotencia.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(88, 328);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 23);
            this.btnPotencia.TabIndex = 14;
            this.btnPotencia.Text = "X^n";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnRaizquadrada);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.tb_resultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnResto);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnQuociente);
            this.Controls.Add(this.btnDiferenca);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnDiferenca;
        private System.Windows.Forms.Button btnQuociente;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnResto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tb_resultado;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Button btnRaizquadrada;
        private System.Windows.Forms.Button btnPotencia;
    }
}

