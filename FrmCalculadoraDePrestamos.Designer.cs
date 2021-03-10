
namespace CalculadoraDePrestamos
{
    partial class FrmCalculadoraDePrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadoraDePrestamos));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblMontoDelPrestamo = new System.Windows.Forms.Label();
            this.LblCantidadDeCuotasMensuales = new System.Windows.Forms.Label();
            this.LblTasaDeInteres = new System.Windows.Forms.Label();
            this.LblCuotaMensual = new System.Windows.Forms.Label();
            this.CbxCantidadDeCuotas = new System.Windows.Forms.ComboBox();
            this.TxtTasaDeInteres = new System.Windows.Forms.TextBox();
            this.CbxTipoDePrestamo = new System.Windows.Forms.ComboBox();
            this.LblTipoDePrestamo = new System.Windows.Forms.Label();
            this.CbNumMontoDePrestamo = new System.Windows.Forms.NumericUpDown();
            this.TxtCuotaMensual = new System.Windows.Forms.TextBox();
            this.BtCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CbNumMontoDePrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Neozoic Trial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblTitulo.Location = new System.Drawing.Point(215, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(292, 29);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Calculadora de Prestamos";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.LblDescripcion.Font = new System.Drawing.Font("Futura LT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(222, 35);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(277, 14);
            this.LblDescripcion.TabIndex = 1;
            this.LblDescripcion.Text = "Complete los campos para visualizar las Cuotas a pagar";
            this.LblDescripcion.Click += new System.EventHandler(this.LblDescripcion_Click);
            // 
            // LblMontoDelPrestamo
            // 
            this.LblMontoDelPrestamo.AutoSize = true;
            this.LblMontoDelPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.LblMontoDelPrestamo.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoDelPrestamo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblMontoDelPrestamo.Location = new System.Drawing.Point(121, 88);
            this.LblMontoDelPrestamo.Name = "LblMontoDelPrestamo";
            this.LblMontoDelPrestamo.Size = new System.Drawing.Size(135, 18);
            this.LblMontoDelPrestamo.TabIndex = 2;
            this.LblMontoDelPrestamo.Text = "Monto del prestamo:";
            this.LblMontoDelPrestamo.Click += new System.EventHandler(this.LblMontoDelPrestamo_Click);
            // 
            // LblCantidadDeCuotasMensuales
            // 
            this.LblCantidadDeCuotasMensuales.AutoSize = true;
            this.LblCantidadDeCuotasMensuales.BackColor = System.Drawing.Color.Transparent;
            this.LblCantidadDeCuotasMensuales.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadDeCuotasMensuales.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblCantidadDeCuotasMensuales.Location = new System.Drawing.Point(60, 191);
            this.LblCantidadDeCuotasMensuales.Name = "LblCantidadDeCuotasMensuales";
            this.LblCantidadDeCuotasMensuales.Size = new System.Drawing.Size(196, 18);
            this.LblCantidadDeCuotasMensuales.TabIndex = 3;
            this.LblCantidadDeCuotasMensuales.Text = "Cantidad de cuotas mensuales:";
            // 
            // LblTasaDeInteres
            // 
            this.LblTasaDeInteres.AutoSize = true;
            this.LblTasaDeInteres.BackColor = System.Drawing.Color.Transparent;
            this.LblTasaDeInteres.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTasaDeInteres.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblTasaDeInteres.Location = new System.Drawing.Point(131, 154);
            this.LblTasaDeInteres.Name = "LblTasaDeInteres";
            this.LblTasaDeInteres.Size = new System.Drawing.Size(126, 18);
            this.LblTasaDeInteres.TabIndex = 4;
            this.LblTasaDeInteres.Text = "Tasa de interes (%):";
            // 
            // LblCuotaMensual
            // 
            this.LblCuotaMensual.AutoSize = true;
            this.LblCuotaMensual.BackColor = System.Drawing.Color.Transparent;
            this.LblCuotaMensual.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuotaMensual.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblCuotaMensual.Location = new System.Drawing.Point(150, 285);
            this.LblCuotaMensual.Name = "LblCuotaMensual";
            this.LblCuotaMensual.Size = new System.Drawing.Size(106, 18);
            this.LblCuotaMensual.TabIndex = 5;
            this.LblCuotaMensual.Text = "Cuota mensual: ";
            // 
            // CbxCantidadDeCuotas
            // 
            this.CbxCantidadDeCuotas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CbxCantidadDeCuotas.FormattingEnabled = true;
            this.CbxCantidadDeCuotas.Location = new System.Drawing.Point(259, 190);
            this.CbxCantidadDeCuotas.Name = "CbxCantidadDeCuotas";
            this.CbxCantidadDeCuotas.Size = new System.Drawing.Size(107, 21);
            this.CbxCantidadDeCuotas.TabIndex = 6;
            // 
            // TxtTasaDeInteres
            // 
            this.TxtTasaDeInteres.Location = new System.Drawing.Point(259, 153);
            this.TxtTasaDeInteres.Name = "TxtTasaDeInteres";
            this.TxtTasaDeInteres.ReadOnly = true;
            this.TxtTasaDeInteres.Size = new System.Drawing.Size(53, 20);
            this.TxtTasaDeInteres.TabIndex = 8;
            this.TxtTasaDeInteres.TextChanged += new System.EventHandler(this.TxtTasaDeInteres_TextChanged);
            // 
            // CbxTipoDePrestamo
            // 
            this.CbxTipoDePrestamo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CbxTipoDePrestamo.FormattingEnabled = true;
            this.CbxTipoDePrestamo.Location = new System.Drawing.Point(260, 118);
            this.CbxTipoDePrestamo.Name = "CbxTipoDePrestamo";
            this.CbxTipoDePrestamo.Size = new System.Drawing.Size(139, 21);
            this.CbxTipoDePrestamo.TabIndex = 10;
            this.CbxTipoDePrestamo.SelectedIndexChanged += new System.EventHandler(this.CbxTipoDePrestamo_SelectedIndexChanged);
            // 
            // LblTipoDePrestamo
            // 
            this.LblTipoDePrestamo.AutoSize = true;
            this.LblTipoDePrestamo.BackColor = System.Drawing.Color.Transparent;
            this.LblTipoDePrestamo.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDePrestamo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblTipoDePrestamo.Location = new System.Drawing.Point(139, 119);
            this.LblTipoDePrestamo.Name = "LblTipoDePrestamo";
            this.LblTipoDePrestamo.Size = new System.Drawing.Size(119, 18);
            this.LblTipoDePrestamo.TabIndex = 9;
            this.LblTipoDePrestamo.Text = "Tipo de Prestamo:";
            // 
            // CbNumMontoDePrestamo
            // 
            this.CbNumMontoDePrestamo.Location = new System.Drawing.Point(263, 88);
            this.CbNumMontoDePrestamo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CbNumMontoDePrestamo.Name = "CbNumMontoDePrestamo";
            this.CbNumMontoDePrestamo.Size = new System.Drawing.Size(136, 20);
            this.CbNumMontoDePrestamo.TabIndex = 11;
            // 
            // TxtCuotaMensual
            // 
            this.TxtCuotaMensual.Location = new System.Drawing.Point(259, 284);
            this.TxtCuotaMensual.Name = "TxtCuotaMensual";
            this.TxtCuotaMensual.ReadOnly = true;
            this.TxtCuotaMensual.Size = new System.Drawing.Size(140, 20);
            this.TxtCuotaMensual.TabIndex = 12;
            // 
            // BtCalcular
            // 
            this.BtCalcular.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtCalcular.Location = new System.Drawing.Point(219, 236);
            this.BtCalcular.Name = "BtCalcular";
            this.BtCalcular.Size = new System.Drawing.Size(93, 23);
            this.BtCalcular.TabIndex = 13;
            this.BtCalcular.Text = "Calcular";
            this.BtCalcular.UseVisualStyleBackColor = false;
            this.BtCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // FrmCalculadoraDePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(531, 321);
            this.Controls.Add(this.BtCalcular);
            this.Controls.Add(this.TxtCuotaMensual);
            this.Controls.Add(this.CbNumMontoDePrestamo);
            this.Controls.Add(this.CbxTipoDePrestamo);
            this.Controls.Add(this.LblTipoDePrestamo);
            this.Controls.Add(this.TxtTasaDeInteres);
            this.Controls.Add(this.CbxCantidadDeCuotas);
            this.Controls.Add(this.LblCuotaMensual);
            this.Controls.Add(this.LblTasaDeInteres);
            this.Controls.Add(this.LblCantidadDeCuotasMensuales);
            this.Controls.Add(this.LblMontoDelPrestamo);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCalculadoraDePrestamos";
            this.Text = "Calculadora de Prestamos";
            this.Load += new System.EventHandler(this.FrmCalculadoraDePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CbNumMontoDePrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblMontoDelPrestamo;
        private System.Windows.Forms.Label LblCantidadDeCuotasMensuales;
        private System.Windows.Forms.Label LblTasaDeInteres;
        private System.Windows.Forms.Label LblCuotaMensual;
        private System.Windows.Forms.ComboBox CbxCantidadDeCuotas;
        private System.Windows.Forms.TextBox TxtTasaDeInteres;
        private System.Windows.Forms.ComboBox CbxTipoDePrestamo;
        private System.Windows.Forms.Label LblTipoDePrestamo;
        private System.Windows.Forms.NumericUpDown CbNumMontoDePrestamo;
        private System.Windows.Forms.TextBox TxtCuotaMensual;
        private System.Windows.Forms.Button BtCalcular;
    }
}

