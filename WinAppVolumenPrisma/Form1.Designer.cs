namespace WinAppVolumenPrisma
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelLado = new System.Windows.Forms.Label();
            this.labelVolumen = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxLado = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(42, 34);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(558, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Volúmen de un prisma de base cuadrada  ";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(47, 106);
            this.labelAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(96, 26);
            this.labelAltura.TabIndex = 1;
            this.labelAltura.Text = "Altura= ";
            // 
            // labelLado
            // 
            this.labelLado.AutoSize = true;
            this.labelLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLado.Location = new System.Drawing.Point(47, 166);
            this.labelLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLado.Name = "labelLado";
            this.labelLado.Size = new System.Drawing.Size(143, 26);
            this.labelLado.TabIndex = 2;
            this.labelLado.Text = "Lado base= ";
            // 
            // labelVolumen
            // 
            this.labelVolumen.AutoSize = true;
            this.labelVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumen.Location = new System.Drawing.Point(400, 243);
            this.labelVolumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVolumen.Name = "labelVolumen";
            this.labelVolumen.Size = new System.Drawing.Size(106, 26);
            this.labelVolumen.TabIndex = 3;
            this.labelVolumen.Text = "Volúmen";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(424, 285);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(54, 26);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "0.00";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(194, 106);
            this.textBoxAltura.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(76, 20);
            this.textBoxAltura.TabIndex = 0;
            this.textBoxAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLado_KeyPress);
            // 
            // textBoxLado
            // 
            this.textBoxLado.Location = new System.Drawing.Point(194, 166);
            this.textBoxLado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLado.Name = "textBoxLado";
            this.textBoxLado.Size = new System.Drawing.Size(76, 20);
            this.textBoxLado.TabIndex = 1;
            this.textBoxLado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAltura_KeyPress);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(175)))), ((int)(((byte)(176)))));
            this.buttonCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(96, 231);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(94, 53);
            this.buttonCalcular.TabIndex = 3;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppVolumenPrisma.Properties.Resources.prisma;
            this.pictureBox1.Location = new System.Drawing.Point(331, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(600, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxLado);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelVolumen);
            this.Controls.Add(this.labelLado);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Volumen de un prisma de base cuadrada";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelLado;
        private System.Windows.Forms.Label labelVolumen;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxLado;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

