namespace firstApp_pokemon
{
    partial class frmPokemonsInactivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokemonsInactivos));
            this.pbxPokemonInactivos = new System.Windows.Forms.PictureBox();
            this.dgvPokemonsInactivos = new System.Windows.Forms.DataGridView();
            this.lblTituloInactivos = new System.Windows.Forms.Label();
            this.btnActivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemonInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemonsInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPokemonInactivos
            // 
            this.pbxPokemonInactivos.BackColor = System.Drawing.SystemColors.Control;
            this.pbxPokemonInactivos.Location = new System.Drawing.Point(530, 70);
            this.pbxPokemonInactivos.Name = "pbxPokemonInactivos";
            this.pbxPokemonInactivos.Size = new System.Drawing.Size(257, 257);
            this.pbxPokemonInactivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemonInactivos.TabIndex = 4;
            this.pbxPokemonInactivos.TabStop = false;
            // 
            // dgvPokemonsInactivos
            // 
            this.dgvPokemonsInactivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPokemonsInactivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPokemonsInactivos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPokemonsInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemonsInactivos.Location = new System.Drawing.Point(26, 70);
            this.dgvPokemonsInactivos.MultiSelect = false;
            this.dgvPokemonsInactivos.Name = "dgvPokemonsInactivos";
            this.dgvPokemonsInactivos.ReadOnly = true;
            this.dgvPokemonsInactivos.RowHeadersVisible = false;
            this.dgvPokemonsInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemonsInactivos.Size = new System.Drawing.Size(449, 257);
            this.dgvPokemonsInactivos.TabIndex = 3;
            this.dgvPokemonsInactivos.SelectionChanged += new System.EventHandler(this.dgvPokemonsInactivos_SelectionChanged);
            // 
            // lblTituloInactivos
            // 
            this.lblTituloInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloInactivos.AutoSize = true;
            this.lblTituloInactivos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInactivos.Location = new System.Drawing.Point(21, 24);
            this.lblTituloInactivos.Name = "lblTituloInactivos";
            this.lblTituloInactivos.Size = new System.Drawing.Size(207, 25);
            this.lblTituloInactivos.TabIndex = 5;
            this.lblTituloInactivos.Text = "Pokemones Inactivos";
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(26, 343);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(82, 33);
            this.btnActivar.TabIndex = 6;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // frmPokemonsInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 398);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.lblTituloInactivos);
            this.Controls.Add(this.pbxPokemonInactivos);
            this.Controls.Add(this.dgvPokemonsInactivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPokemonsInactivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemones Inactivos";
            this.Load += new System.EventHandler(this.frmPokemonsInactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemonInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemonsInactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPokemonInactivos;
        private System.Windows.Forms.DataGridView dgvPokemonsInactivos;
        private System.Windows.Forms.Label lblTituloInactivos;
        private System.Windows.Forms.Button btnActivar;
    }
}