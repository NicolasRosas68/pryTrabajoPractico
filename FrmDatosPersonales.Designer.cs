namespace pryTrabajoPractico
{
    partial class FrmDatosPersonales
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
            this.mrcDatosPersonales = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstLocales = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.mrcDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatosPersonales
            // 
            this.mrcDatosPersonales.Controls.Add(this.listBox1);
            this.mrcDatosPersonales.Controls.Add(this.textBox3);
            this.mrcDatosPersonales.Controls.Add(this.textBox2);
            this.mrcDatosPersonales.Controls.Add(this.textBox1);
            this.mrcDatosPersonales.Controls.Add(this.lstLocales);
            this.mrcDatosPersonales.Controls.Add(this.btnVolver);
            this.mrcDatosPersonales.Controls.Add(this.btnConfirmarReserva);
            this.mrcDatosPersonales.Controls.Add(this.lblAsientos);
            this.mrcDatosPersonales.Controls.Add(this.lblNombre);
            this.mrcDatosPersonales.Controls.Add(this.lblDNI);
            this.mrcDatosPersonales.Controls.Add(this.lblFecha);
            this.mrcDatosPersonales.Controls.Add(this.lblTransporte);
            this.mrcDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.mrcDatosPersonales.Name = "mrcDatosPersonales";
            this.mrcDatosPersonales.Size = new System.Drawing.Size(385, 394);
            this.mrcDatosPersonales.TabIndex = 0;
            this.mrcDatosPersonales.TabStop = false;
            this.mrcDatosPersonales.Text = "Datos Personales Del Comprador";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(67, 274);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 109);
            this.listBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 227);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 23);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 23);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 23);
            this.textBox1.TabIndex = 8;
            // 
            // lstLocales
            // 
            this.lstLocales.FormattingEnabled = true;
            this.lstLocales.ItemHeight = 15;
            this.lstLocales.Items.AddRange(new object[] {
            "QUENAKEN",
            "ONAS",
            "TOBAS"});
            this.lstLocales.Location = new System.Drawing.Point(67, 47);
            this.lstLocales.Name = "lstLocales";
            this.lstLocales.Size = new System.Drawing.Size(131, 19);
            this.lstLocales.TabIndex = 7;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(232, 97);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.Location = new System.Drawing.Point(232, 48);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(124, 23);
            this.btnConfirmarReserva.TabIndex = 5;
            this.btnConfirmarReserva.Text = "Confirmar Reserva";
            this.btnConfirmarReserva.UseVisualStyleBackColor = true;
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(9, 274);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(52, 15);
            this.lblAsientos.TabIndex = 4;
            this.lblAsientos.Text = "Asientos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 235);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(6, 170);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 106);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Location = new System.Drawing.Point(6, 48);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(55, 15);
            this.lblTransporte.TabIndex = 0;
            this.lblTransporte.Text = "Trasporte";
            // 
            // FrmDatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 420);
            this.Controls.Add(this.mrcDatosPersonales);
            this.Name = "FrmDatosPersonales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatosPersonales";
            this.Load += new System.EventHandler(this.FrmDatosPersonales_Load);
            this.mrcDatosPersonales.ResumeLayout(false);
            this.mrcDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox mrcDatosPersonales;
        private ListBox listBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox lstLocales;
        private Button btnVolver;
        private Button btnConfirmarReserva;
        private Label lblAsientos;
        private Label lblNombre;
        private Label lblDNI;
        private Label lblFecha;
        private Label lblTransporte;
    }
}