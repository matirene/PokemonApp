namespace firstApp_pokemon
{
    partial class frmAltaElemento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaElemento));
            this.txtImagenElemento = new System.Windows.Forms.TextBox();
            this.lblImagenElemento = new System.Windows.Forms.Label();
            this.txtDescripcionElemento = new System.Windows.Forms.TextBox();
            this.lblDescripcionElemento = new System.Windows.Forms.Label();
            this.btnCancelarElemento = new System.Windows.Forms.Button();
            this.btnAceptarElemento = new System.Windows.Forms.Button();
            this.pbxNuevoElemento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevoElemento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImagenElemento
            // 
            this.txtImagenElemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagenElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagenElemento.Location = new System.Drawing.Point(141, 103);
            this.txtImagenElemento.Name = "txtImagenElemento";
            this.txtImagenElemento.Size = new System.Drawing.Size(147, 26);
            this.txtImagenElemento.TabIndex = 11;
            this.txtImagenElemento.Leave += new System.EventHandler(this.txtImagenElemento_Leave);
            // 
            // lblImagenElemento
            // 
            this.lblImagenElemento.AutoSize = true;
            this.lblImagenElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblImagenElemento.Location = new System.Drawing.Point(33, 105);
            this.lblImagenElemento.Name = "lblImagenElemento";
            this.lblImagenElemento.Size = new System.Drawing.Size(87, 20);
            this.lblImagenElemento.TabIndex = 12;
            this.lblImagenElemento.Text = "Url Imagen";
            // 
            // txtDescripcionElemento
            // 
            this.txtDescripcionElemento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescripcionElemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionElemento.Location = new System.Drawing.Point(141, 51);
            this.txtDescripcionElemento.Name = "txtDescripcionElemento";
            this.txtDescripcionElemento.Size = new System.Drawing.Size(147, 26);
            this.txtDescripcionElemento.TabIndex = 9;
            // 
            // lblDescripcionElemento
            // 
            this.lblDescripcionElemento.AutoSize = true;
            this.lblDescripcionElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionElemento.Location = new System.Drawing.Point(33, 53);
            this.lblDescripcionElemento.Name = "lblDescripcionElemento";
            this.lblDescripcionElemento.Size = new System.Drawing.Size(65, 20);
            this.lblDescripcionElemento.TabIndex = 10;
            this.lblDescripcionElemento.Text = "Nombre";
            // 
            // btnCancelarElemento
            // 
            this.btnCancelarElemento.Location = new System.Drawing.Point(185, 174);
            this.btnCancelarElemento.Name = "btnCancelarElemento";
            this.btnCancelarElemento.Size = new System.Drawing.Size(88, 34);
            this.btnCancelarElemento.TabIndex = 14;
            this.btnCancelarElemento.Text = "Cancelar";
            this.btnCancelarElemento.UseVisualStyleBackColor = true;
            this.btnCancelarElemento.Click += new System.EventHandler(this.btnCancelarElemento_Click);
            // 
            // btnAceptarElemento
            // 
            this.btnAceptarElemento.Location = new System.Drawing.Point(47, 174);
            this.btnAceptarElemento.Name = "btnAceptarElemento";
            this.btnAceptarElemento.Size = new System.Drawing.Size(89, 34);
            this.btnAceptarElemento.TabIndex = 13;
            this.btnAceptarElemento.Text = "Aceptar";
            this.btnAceptarElemento.UseVisualStyleBackColor = true;
            this.btnAceptarElemento.Click += new System.EventHandler(this.btnAceptarElemento_Click);
            // 
            // pbxNuevoElemento
            // 
            this.pbxNuevoElemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxNuevoElemento.Location = new System.Drawing.Point(347, 33);
            this.pbxNuevoElemento.Name = "pbxNuevoElemento";
            this.pbxNuevoElemento.Size = new System.Drawing.Size(129, 122);
            this.pbxNuevoElemento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNuevoElemento.TabIndex = 15;
            this.pbxNuevoElemento.TabStop = false;
            // 
            // frmAltaElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 244);
            this.Controls.Add(this.pbxNuevoElemento);
            this.Controls.Add(this.btnCancelarElemento);
            this.Controls.Add(this.btnAceptarElemento);
            this.Controls.Add(this.txtImagenElemento);
            this.Controls.Add(this.lblImagenElemento);
            this.Controls.Add(this.txtDescripcionElemento);
            this.Controls.Add(this.lblDescripcionElemento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaElemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Elemento";
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevoElemento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImagenElemento;
        private System.Windows.Forms.Label lblImagenElemento;
        private System.Windows.Forms.TextBox txtDescripcionElemento;
        private System.Windows.Forms.Label lblDescripcionElemento;
        private System.Windows.Forms.Button btnCancelarElemento;
        private System.Windows.Forms.Button btnAceptarElemento;
        private System.Windows.Forms.PictureBox pbxNuevoElemento;
    }
}