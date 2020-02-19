namespace conversor_mundial
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
            this.CboDe = new System.Windows.Forms.ComboBox();
            this.CboA = new System.Windows.Forms.ComboBox();
            this.lblde = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Btnconvertir = new System.Windows.Forms.Button();
            this.Cbtipo = new System.Windows.Forms.ComboBox();
            this.lbltipoconver = new System.Windows.Forms.Label();
            this.lblcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboDe
            // 
            this.CboDe.FormattingEnabled = true;
            this.CboDe.Location = new System.Drawing.Point(10, 145);
            this.CboDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboDe.Name = "CboDe";
            this.CboDe.Size = new System.Drawing.Size(180, 24);
            this.CboDe.TabIndex = 0;
            // 
            // CboA
            // 
            this.CboA.FormattingEnabled = true;
            this.CboA.Location = new System.Drawing.Point(322, 145);
            this.CboA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboA.Name = "CboA";
            this.CboA.Size = new System.Drawing.Size(180, 24);
            this.CboA.TabIndex = 1;
            // 
            // lblde
            // 
            this.lblde.AutoSize = true;
            this.lblde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblde.Location = new System.Drawing.Point(68, 106);
            this.lblde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblde.Name = "lblde";
            this.lblde.Size = new System.Drawing.Size(32, 16);
            this.lblde.TabIndex = 2;
            this.lblde.Text = "De:";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(342, 106);
            this.lbla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(22, 16);
            this.lbla.TabIndex = 3;
            this.lbla.Text = "A:";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.Location = new System.Drawing.Point(319, 233);
            this.lblres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(79, 16);
            this.lblres.TabIndex = 4;
            this.lblres.Text = "Resultado";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(364, 46);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(148, 22);
            this.txtcantidad.TabIndex = 5;
            // 
            // Btnconvertir
            // 
            this.Btnconvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnconvertir.Location = new System.Drawing.Point(38, 223);
            this.Btnconvertir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btnconvertir.Name = "Btnconvertir";
            this.Btnconvertir.Size = new System.Drawing.Size(152, 37);
            this.Btnconvertir.TabIndex = 6;
            this.Btnconvertir.Text = "Convertir";
            this.Btnconvertir.UseVisualStyleBackColor = true;
            this.Btnconvertir.Click += new System.EventHandler(this.Btnconvertir_Click);
            // 
            // Cbtipo
            // 
            this.Cbtipo.FormattingEnabled = true;
            this.Cbtipo.Location = new System.Drawing.Point(24, 46);
            this.Cbtipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbtipo.Name = "Cbtipo";
            this.Cbtipo.Size = new System.Drawing.Size(180, 24);
            this.Cbtipo.TabIndex = 7;
            this.Cbtipo.SelectedIndexChanged += new System.EventHandler(this.Cbtipo_SelectedIndexChanged);
            // 
            // lbltipoconver
            // 
            this.lbltipoconver.AutoSize = true;
            this.lbltipoconver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoconver.Location = new System.Drawing.Point(254, 14);
            this.lbltipoconver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipoconver.Name = "lbltipoconver";
            this.lbltipoconver.Size = new System.Drawing.Size(0, 16);
            this.lbltipoconver.TabIndex = 8;
            // 
            // lblcon
            // 
            this.lblcon.AutoSize = true;
            this.lblcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcon.Location = new System.Drawing.Point(21, 14);
            this.lblcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcon.Name = "lblcon";
            this.lblcon.Size = new System.Drawing.Size(144, 16);
            this.lblcon.TabIndex = 9;
            this.lblcon.Text = "Tipo de Conversion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 331);
            this.Controls.Add(this.lblcon);
            this.Controls.Add(this.lbltipoconver);
            this.Controls.Add(this.Cbtipo);
            this.Controls.Add(this.Btnconvertir);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.lblde);
            this.Controls.Add(this.CboA);
            this.Controls.Add(this.CboDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Conversor Mundial de Divisas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboDe;
        private System.Windows.Forms.ComboBox CboA;
        private System.Windows.Forms.Label lblde;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button Btnconvertir;
        private System.Windows.Forms.ComboBox Cbtipo;
        private System.Windows.Forms.Label lbltipoconver;
        private System.Windows.Forms.Label lblcon;
    }
}

