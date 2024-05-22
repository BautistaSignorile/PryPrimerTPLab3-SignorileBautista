namespace PryPrimerTPLab3_SignorileBautista
{
    partial class frmReservaPrincipal
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
            this.lblLocal = new System.Windows.Forms.Label();
            this.cboLocal = new System.Windows.Forms.ComboBox();
            this.mrcDatosAelegir = new System.Windows.Forms.GroupBox();
            this.cboAsiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFila = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.mrcDatosAelegir.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(15, 23);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(38, 15);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "Local:";
            // 
            // cboLocal
            // 
            this.cboLocal.FormattingEnabled = true;
            this.cboLocal.Items.AddRange(new object[] {
            "Quenaken",
            "Onas",
            "Tobas"});
            this.cboLocal.Location = new System.Drawing.Point(63, 20);
            this.cboLocal.Name = "cboLocal";
            this.cboLocal.Size = new System.Drawing.Size(121, 23);
            this.cboLocal.TabIndex = 1;
            // 
            // mrcDatosAelegir
            // 
            this.mrcDatosAelegir.Controls.Add(this.cboAsiento);
            this.mrcDatosAelegir.Controls.Add(this.label4);
            this.mrcDatosAelegir.Controls.Add(this.cboFila);
            this.mrcDatosAelegir.Controls.Add(this.label3);
            this.mrcDatosAelegir.Controls.Add(this.cboArea);
            this.mrcDatosAelegir.Controls.Add(this.label2);
            this.mrcDatosAelegir.Location = new System.Drawing.Point(12, 49);
            this.mrcDatosAelegir.Name = "mrcDatosAelegir";
            this.mrcDatosAelegir.Size = new System.Drawing.Size(178, 100);
            this.mrcDatosAelegir.TabIndex = 2;
            this.mrcDatosAelegir.TabStop = false;
            this.mrcDatosAelegir.Text = "Elegir:";
            // 
            // cboAsiento
            // 
            this.cboAsiento.FormattingEnabled = true;
            this.cboAsiento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.cboAsiento.Location = new System.Drawing.Point(51, 70);
            this.cboAsiento.Name = "cboAsiento";
            this.cboAsiento.Size = new System.Drawing.Size(121, 23);
            this.cboAsiento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asiento:";
            // 
            // cboFila
            // 
            this.cboFila.FormattingEnabled = true;
            this.cboFila.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboFila.Location = new System.Drawing.Point(51, 43);
            this.cboFila.Name = "cboFila";
            this.cboFila.Size = new System.Drawing.Size(121, 23);
            this.cboFila.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fila:";
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Items.AddRange(new object[] {
            "Azul",
            "Verde"});
            this.cboArea.Location = new System.Drawing.Point(50, 16);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(121, 23);
            this.cboArea.TabIndex = 4;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(18, 159);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(108, 159);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(64, 188);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmReservaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 217);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.mrcDatosAelegir);
            this.Controls.Add(this.cboLocal);
            this.Controls.Add(this.lblLocal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReservaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.mrcDatosAelegir.ResumeLayout(false);
            this.mrcDatosAelegir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLocal;
        private ComboBox cboLocal;
        private GroupBox mrcDatosAelegir;
        private ComboBox cboAsiento;
        private Label label4;
        private ComboBox cboFila;
        private Label label3;
        private ComboBox cboArea;
        private Label label2;
        private Button btnGrabar;
        private Button btnMostrar;
        private Button btnCerrar;
    }
}