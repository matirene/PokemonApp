using System.Windows.Forms;

namespace firstApp_pokemon
{
    partial class Pokemons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokemons));
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.dgvElementos = new System.Windows.Forms.DataGridView();
            this.lblElementos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pbxElementos = new System.Windows.Forms.PictureBox();
            this.btnAgregarElem = new System.Windows.Forms.Button();
            this.btnEliminarFisica = new System.Windows.Forms.Button();
            this.btnEliminarLogica = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnInactivos = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.btnEliminarElemento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPokemons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPokemons.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.Location = new System.Drawing.Point(37, 161);
            this.dgvPokemons.MultiSelect = false;
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.ReadOnly = true;
            this.dgvPokemons.RowHeadersVisible = false;
            this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemons.Size = new System.Drawing.Size(597, 257);
            this.dgvPokemons.TabIndex = 5;
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Pokemones";
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.BackColor = System.Drawing.SystemColors.Control;
            this.pbxPokemon.Location = new System.Drawing.Point(693, 161);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(257, 257);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 2;
            this.pbxPokemon.TabStop = false;
            // 
            // dgvElementos
            // 
            this.dgvElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElementos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvElementos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementos.Location = new System.Drawing.Point(37, 535);
            this.dgvElementos.MultiSelect = false;
            this.dgvElementos.Name = "dgvElementos";
            this.dgvElementos.ReadOnly = true;
            this.dgvElementos.RowHeadersVisible = false;
            this.dgvElementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElementos.Size = new System.Drawing.Size(354, 182);
            this.dgvElementos.TabIndex = 12;
            this.dgvElementos.SelectionChanged += new System.EventHandler(this.dgvElementos_SelectionChanged);
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.lblElementos.Location = new System.Drawing.Point(32, 498);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(107, 25);
            this.lblElementos.TabIndex = 4;
            this.lblElementos.Text = "Elementos";
            this.lblElementos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(135, 433);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 40);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(36, 433);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 40);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(237, 433);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 40);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pbxElementos
            // 
            this.pbxElementos.Location = new System.Drawing.Point(437, 535);
            this.pbxElementos.Name = "pbxElementos";
            this.pbxElementos.Size = new System.Drawing.Size(182, 182);
            this.pbxElementos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxElementos.TabIndex = 8;
            this.pbxElementos.TabStop = false;
            // 
            // btnAgregarElem
            // 
            this.btnAgregarElem.Location = new System.Drawing.Point(37, 728);
            this.btnAgregarElem.Name = "btnAgregarElem";
            this.btnAgregarElem.Size = new System.Drawing.Size(85, 40);
            this.btnAgregarElem.TabIndex = 13;
            this.btnAgregarElem.Text = "Agregar";
            this.btnAgregarElem.UseVisualStyleBackColor = true;
            this.btnAgregarElem.Click += new System.EventHandler(this.btnAgregarElem_Click);
            // 
            // btnEliminarFisica
            // 
            this.btnEliminarFisica.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarFisica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarFisica.Location = new System.Drawing.Point(339, 433);
            this.btnEliminarFisica.Name = "btnEliminarFisica";
            this.btnEliminarFisica.Size = new System.Drawing.Size(85, 40);
            this.btnEliminarFisica.TabIndex = 9;
            this.btnEliminarFisica.Text = "Eliminar";
            this.btnEliminarFisica.UseVisualStyleBackColor = false;
            this.btnEliminarFisica.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarLogica
            // 
            this.btnEliminarLogica.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarLogica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarLogica.Location = new System.Drawing.Point(437, 433);
            this.btnEliminarLogica.Name = "btnEliminarLogica";
            this.btnEliminarLogica.Size = new System.Drawing.Size(85, 40);
            this.btnEliminarLogica.TabIndex = 10;
            this.btnEliminarLogica.Text = "Desactivar";
            this.btnEliminarLogica.UseVisualStyleBackColor = false;
            this.btnEliminarLogica.Click += new System.EventHandler(this.btnEliminarLogica_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFiltro.Location = new System.Drawing.Point(34, 82);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(84, 16);
            this.lblFiltro.TabIndex = 12;
            this.lblFiltro.Text = "Filtro Rapido";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(124, 80);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(134, 22);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnInactivos
            // 
            this.btnInactivos.Location = new System.Drawing.Point(529, 433);
            this.btnInactivos.Name = "btnInactivos";
            this.btnInactivos.Size = new System.Drawing.Size(105, 40);
            this.btnInactivos.TabIndex = 11;
            this.btnInactivos.Text = "Ver Inactivos";
            this.btnInactivos.UseVisualStyleBackColor = true;
            this.btnInactivos.Click += new System.EventHandler(this.btnInactivos_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(32, 125);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 15;
            this.lblCampo.Text = "Campo:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(559, 118);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 34);
            this.btnFiltro.TabIndex = 4;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(223, 127);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 22;
            this.lblCriterio.Text = "Criterio:";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAvanzado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(453, 123);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(100, 22);
            this.txtFiltroAvanzado.TabIndex = 3;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(408, 126);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(39, 16);
            this.lblFiltroAvanzado.TabIndex = 24;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(92, 122);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 1;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(281, 123);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbCriterio.TabIndex = 2;
            // 
            // btnEliminarElemento
            // 
            this.btnEliminarElemento.Location = new System.Drawing.Point(135, 728);
            this.btnEliminarElemento.Name = "btnEliminarElemento";
            this.btnEliminarElemento.Size = new System.Drawing.Size(85, 40);
            this.btnEliminarElemento.TabIndex = 25;
            this.btnEliminarElemento.Text = "Eliminar";
            this.btnEliminarElemento.UseVisualStyleBackColor = true;
            this.btnEliminarElemento.Click += new System.EventHandler(this.btnEliminarElemento_Click);
            // 
            // Pokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 780);
            this.Controls.Add(this.btnEliminarElemento);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnInactivos);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminarLogica);
            this.Controls.Add(this.btnEliminarFisica);
            this.Controls.Add(this.btnAgregarElem);
            this.Controls.Add(this.pbxElementos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblElementos);
            this.Controls.Add(this.dgvElementos);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPokemons);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.Pokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemons;
        private Label lblTitulo;
        private PictureBox pbxPokemon;
        private DataGridView dgvElementos;
        private Label lblElementos;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnModificar;
        private PictureBox pbxElementos;
        private Button btnAgregarElem;
        private Button btnEliminarFisica;
        private Button btnEliminarLogica;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private Button btnInactivos;
        private Label lblCampo;
        private Button btnFiltro;
        private Label lblCriterio;
        private TextBox txtFiltroAvanzado;
        private Label lblFiltroAvanzado;
        private ComboBox cbCampo;
        private ComboBox cbCriterio;
        private Button btnEliminarElemento;
    }
}

