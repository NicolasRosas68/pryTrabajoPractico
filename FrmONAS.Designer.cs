namespace pryTrabajoPractico
{
    partial class FrmONAS
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
            this.MrcGrupoOnas = new System.Windows.Forms.GroupBox();
            this.lstRojo = new System.Windows.Forms.ListBox();
            this.lstAzul = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReservarAsientos = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.MrcGrupoOnas.SuspendLayout();
            this.SuspendLayout();
            // 
            // MrcGrupoOnas
            // 
            this.MrcGrupoOnas.Controls.Add(this.dtpFecha);
            this.MrcGrupoOnas.Controls.Add(this.lstRojo);
            this.MrcGrupoOnas.Controls.Add(this.lstAzul);
            this.MrcGrupoOnas.Controls.Add(this.label2);
            this.MrcGrupoOnas.Controls.Add(this.label1);
            this.MrcGrupoOnas.Controls.Add(this.lblFecha);
            this.MrcGrupoOnas.Location = new System.Drawing.Point(12, 21);
            this.MrcGrupoOnas.Name = "MrcGrupoOnas";
            this.MrcGrupoOnas.Size = new System.Drawing.Size(259, 383);
            this.MrcGrupoOnas.TabIndex = 0;
            this.MrcGrupoOnas.TabStop = false;
            this.MrcGrupoOnas.Text = "GRUPO ONAS";
            this.MrcGrupoOnas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstRojo
            // 
            this.lstRojo.FormattingEnabled = true;
            this.lstRojo.ItemHeight = 15;
            this.lstRojo.Location = new System.Drawing.Point(17, 269);
            this.lstRojo.Name = "lstRojo";
            this.lstRojo.Size = new System.Drawing.Size(120, 94);
            this.lstRojo.TabIndex = 6;
            // 
            // lstAzul
            // 
            this.lstAzul.FormattingEnabled = true;
            this.lstAzul.ItemHeight = 15;
            this.lstAzul.Location = new System.Drawing.Point(17, 123);
            this.lstAzul.Name = "lstAzul";
            this.lstAzul.Size = new System.Drawing.Size(120, 94);
            this.lstAzul.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asientos Disponibles (Area Verde)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asientos Disponibles (Area Azul)";
            // 
            // btnReservarAsientos
            // 
            this.btnReservarAsientos.Location = new System.Drawing.Point(12, 422);
            this.btnReservarAsientos.Name = "btnReservarAsientos";
            this.btnReservarAsientos.Size = new System.Drawing.Size(151, 35);
            this.btnReservarAsientos.TabIndex = 2;
            this.btnReservarAsientos.Text = "Reservar Asientos";
            this.btnReservarAsientos.UseVisualStyleBackColor = true;
            this.btnReservarAsientos.Click += new System.EventHandler(this.btnReservarAsientos_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 45);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(75, 37);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(105, 23);
            this.dtpFecha.TabIndex = 7;
            // 
            // FrmONAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 483);
            this.Controls.Add(this.MrcGrupoOnas);
            this.Controls.Add(this.btnReservarAsientos);
            this.Name = "FrmONAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmONAS";
            this.Load += new System.EventHandler(this.FrmONAS_Load);
            this.MrcGrupoOnas.ResumeLayout(false);
            this.MrcGrupoOnas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox MrcGrupoOnas;
        private Button btnReservarAsientos;
        private Label lblFecha;
        private ListBox lstRojo;
        private ListBox lstAzul;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFecha;
    }
}