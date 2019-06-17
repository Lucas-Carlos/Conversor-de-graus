namespace Conversor
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
            this.rdbFahrenheitToCelKelv = new System.Windows.Forms.RadioButton();
            this.rdbCelsiusToFahrKelv = new System.Windows.Forms.RadioButton();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.lblFahr = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.rdbKelvinToCelFahr = new System.Windows.Forms.RadioButton();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.lblKelv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbFahrenheitToCelKelv
            // 
            this.rdbFahrenheitToCelKelv.AutoSize = true;
            this.rdbFahrenheitToCelKelv.Location = new System.Drawing.Point(12, 35);
            this.rdbFahrenheitToCelKelv.Name = "rdbFahrenheitToCelKelv";
            this.rdbFahrenheitToCelKelv.Size = new System.Drawing.Size(172, 17);
            this.rdbFahrenheitToCelKelv.TabIndex = 13;
            this.rdbFahrenheitToCelKelv.Text = "Fahrenheit para Celsius/ Kelvin";
            this.rdbFahrenheitToCelKelv.UseVisualStyleBackColor = true;
            this.rdbFahrenheitToCelKelv.CheckedChanged += new System.EventHandler(this.rdbFahrenheitparack_CheckedChanged);
            // 
            // rdbCelsiusToFahrKelv
            // 
            this.rdbCelsiusToFahrKelv.AutoSize = true;
            this.rdbCelsiusToFahrKelv.Location = new System.Drawing.Point(12, 12);
            this.rdbCelsiusToFahrKelv.Name = "rdbCelsiusToFahrKelv";
            this.rdbCelsiusToFahrKelv.Size = new System.Drawing.Size(172, 17);
            this.rdbCelsiusToFahrKelv.TabIndex = 12;
            this.rdbCelsiusToFahrKelv.Text = "Celsius para Fahrenheit/ Kelvin";
            this.rdbCelsiusToFahrKelv.UseVisualStyleBackColor = true;
            this.rdbCelsiusToFahrKelv.CheckedChanged += new System.EventHandler(this.rdbCelsiusparaf_CheckedChanged);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(46, 116);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 11;
            // 
            // lblFahr
            // 
            this.lblFahr.AutoSize = true;
            this.lblFahr.Location = new System.Drawing.Point(153, 119);
            this.lblFahr.Name = "lblFahr";
            this.lblFahr.Size = new System.Drawing.Size(17, 13);
            this.lblFahr.TabIndex = 10;
            this.lblFahr.Text = "°F";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(152, 97);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(18, 13);
            this.lblCel.TabIndex = 9;
            this.lblCel.Text = "°C";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(12, 176);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(170, 40);
            this.btnConverter.TabIndex = 8;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(46, 93);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 7;
            // 
            // rdbKelvinToCelFahr
            // 
            this.rdbKelvinToCelFahr.AutoSize = true;
            this.rdbKelvinToCelFahr.Location = new System.Drawing.Point(12, 58);
            this.rdbKelvinToCelFahr.Name = "rdbKelvinToCelFahr";
            this.rdbKelvinToCelFahr.Size = new System.Drawing.Size(172, 17);
            this.rdbKelvinToCelFahr.TabIndex = 14;
            this.rdbKelvinToCelFahr.Text = "Kelvin para Celsius/ Fahrenheit";
            this.rdbKelvinToCelFahr.UseVisualStyleBackColor = true;
            this.rdbKelvinToCelFahr.CheckedChanged += new System.EventHandler(this.rdbKelvinparacf_CheckedChanged);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(46, 139);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtKelvin.TabIndex = 15;
            // 
            // lblKelv
            // 
            this.lblKelv.AutoSize = true;
            this.lblKelv.Location = new System.Drawing.Point(152, 143);
            this.lblKelv.Name = "lblKelv";
            this.lblKelv.Size = new System.Drawing.Size(18, 13);
            this.lblKelv.TabIndex = 16;
            this.lblKelv.Text = "°K";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 236);
            this.Controls.Add(this.lblKelv);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.rdbKelvinToCelFahr);
            this.Controls.Add(this.rdbFahrenheitToCelKelv);
            this.Controls.Add(this.rdbCelsiusToFahrKelv);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.lblFahr);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtCelsius);
            this.Name = "Form1";
            this.Text = "Conversor de temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbFahrenheitToCelKelv;
        private System.Windows.Forms.RadioButton rdbCelsiusToFahrKelv;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label lblFahr;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.RadioButton rdbKelvinToCelFahr;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Label lblKelv;
    }
}

