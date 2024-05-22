namespace pryTrabajoPractico
{
    partial class FrmBienvenidos
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
            this.btnQuenaken = new System.Windows.Forms.Button();
            this.mrcLocal = new System.Windows.Forms.GroupBox();
            this.btnTobas = new System.Windows.Forms.Button();
            this.btnOnas = new System.Windows.Forms.Button();
            this.lblBIenvenidos = new System.Windows.Forms.Label();
            this.mrcLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuenaken
            // 
            this.btnQuenaken.Location = new System.Drawing.Point(43, 48);
            this.btnQuenaken.Name = "btnQuenaken";
            this.btnQuenaken.Size = new System.Drawing.Size(103, 24);
            this.btnQuenaken.TabIndex = 0;
            this.btnQuenaken.Text = "QUENAKEN";
            this.btnQuenaken.UseVisualStyleBackColor = true;
            this.btnQuenaken.Click += new System.EventHandler(this.button1_Click);
            // 
            // mrcLocal
            // 
            this.mrcLocal.Controls.Add(this.btnTobas);
            this.mrcLocal.Controls.Add(this.btnOnas);
            this.mrcLocal.Controls.Add(this.btnQuenaken);
            this.mrcLocal.Location = new System.Drawing.Point(22, 87);
            this.mrcLocal.Name = "mrcLocal";
            this.mrcLocal.Size = new System.Drawing.Size(200, 180);
            this.mrcLocal.TabIndex = 4;
            this.mrcLocal.TabStop = false;
            this.mrcLocal.Text = "Seleccione la Local Pertinente";
            // 
            // btnTobas
            // 
            this.btnTobas.Location = new System.Drawing.Point(43, 128);
            this.btnTobas.Name = "btnTobas";
            this.btnTobas.Size = new System.Drawing.Size(103, 24);
            this.btnTobas.TabIndex = 2;
            this.btnTobas.Text = "TOBAS";
            this.btnTobas.UseVisualStyleBackColor = true;
            this.btnTobas.Click += new System.EventHandler(this.btnTobas_Click);
            // 
            // btnOnas
            // 
            this.btnOnas.Location = new System.Drawing.Point(43, 87);
            this.btnOnas.Name = "btnOnas";
            this.btnOnas.Size = new System.Drawing.Size(103, 24);
            this.btnOnas.TabIndex = 1;
            this.btnOnas.Text = "ONAS";
            this.btnOnas.UseVisualStyleBackColor = true;
            this.btnOnas.Click += new System.EventHandler(this.btnOnas_Click);
            // 
            // lblBIenvenidos
            // 
            this.lblBIenvenidos.AutoSize = true;
            this.lblBIenvenidos.Location = new System.Drawing.Point(79, 40);
            this.lblBIenvenidos.Name = "lblBIenvenidos";
            this.lblBIenvenidos.Size = new System.Drawing.Size(71, 15);
            this.lblBIenvenidos.TabIndex = 3;
            this.lblBIenvenidos.Text = "Bienvenidos";
            // 
            // FrmBienvenidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 315);
            this.Controls.Add(this.mrcLocal);
            this.Controls.Add(this.lblBIenvenidos);
            this.Name = "FrmBienvenidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBienvenidos";
            this.mrcLocal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnQuenaken;
        private GroupBox mrcLocal;
        private Button btnTobas;
        private Button btnOnas;
        private Label lblBIenvenidos;
    }
}