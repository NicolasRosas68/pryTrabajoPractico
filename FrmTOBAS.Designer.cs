namespace pryTrabajoPractico
{
    partial class FrmTOBAS
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
            this.mrcGrupoTobas = new System.Windows.Forms.GroupBox();
            this.lstRojo = new System.Windows.Forms.ListBox();
            this.lstAzul = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReservarAsientos = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mrcGrupoTobas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcGrupoTobas
            // 
            this.mrcGrupoTobas.Controls.Add(this.dateTimePicker1);
            this.mrcGrupoTobas.Controls.Add(this.lstRojo);
            this.mrcGrupoTobas.Controls.Add(this.lstAzul);
            this.mrcGrupoTobas.Controls.Add(this.label2);
            this.mrcGrupoTobas.Controls.Add(this.label1);
            this.mrcGrupoTobas.Controls.Add(this.lblFecha);
            this.mrcGrupoTobas.Location = new System.Drawing.Point(12, 28);
            this.mrcGrupoTobas.Name = "mrcGrupoTobas";
            this.mrcGrupoTobas.Size = new System.Drawing.Size(229, 386);
            this.mrcGrupoTobas.TabIndex = 1;
            this.mrcGrupoTobas.TabStop = false;
            this.mrcGrupoTobas.Text = "GRUPO TOBAS";
            // 
            // lstRojo
            // 
            this.lstRojo.FormattingEnabled = true;
            this.lstRojo.ItemHeight = 15;
            this.lstRojo.Location = new System.Drawing.Point(17, 267);
            this.lstRojo.Name = "lstRojo";
            this.lstRojo.Size = new System.Drawing.Size(120, 94);
            this.lstRojo.TabIndex = 10;
            // 
            // lstAzul
            // 
            this.lstAzul.FormattingEnabled = true;
            this.lstAzul.ItemHeight = 15;
            this.lstAzul.Location = new System.Drawing.Point(17, 121);
            this.lstAzul.Name = "lstAzul";
            this.lstAzul.Size = new System.Drawing.Size(120, 94);
            this.lstAzul.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Asientos Disponibles (Area Verde)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Asientos Disponibles (Area Azul)";
            // 
            // btnReservarAsientos
            // 
            this.btnReservarAsientos.Location = new System.Drawing.Point(12, 420);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // FrmTOBAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 479);
            this.Controls.Add(this.mrcGrupoTobas);
            this.Controls.Add(this.btnReservarAsientos);
            this.Name = "FrmTOBAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTOBAS";
            this.Load += new System.EventHandler(this.FrmTOBAS_Load);
            this.mrcGrupoTobas.ResumeLayout(false);
            this.mrcGrupoTobas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox mrcGrupoTobas;
        private Button btnReservarAsientos;
        private Label lblFecha;
        private ListBox lstRojo;
        private ListBox lstAzul;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}