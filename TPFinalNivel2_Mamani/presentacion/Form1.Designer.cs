namespace presentacion
{
    partial class frmMain
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
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboCampo2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCriterio2 = new System.Windows.Forms.ComboBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblFiltro2 = new System.Windows.Forms.Label();
            this.txtFiltro2 = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(99, 18);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(183, 23);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(32, 21);
            this.lblBuscador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(54, 15);
            this.lblBuscador.TabIndex = 2;
            this.lblBuscador.Text = "Buscador";
            // 
            // pbArticulos
            // 
            this.pbArticulos.Location = new System.Drawing.Point(723, 60);
            this.pbArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(266, 233);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 2;
            this.pbArticulos.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 60);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 36;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(689, 247);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(35, 327);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 40);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(186, 327);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 40);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(336, 327);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(683, 414);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 32);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(6, 429);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(57, 15);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Categoria";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(64, 420);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(140, 23);
            this.cboCampo.TabIndex = 9;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(228, 429);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(89, 15);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Rango de Precio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(336, 420);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(140, 23);
            this.cboCriterio.TabIndex = 11;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(14, 483);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca";
            // 
            // cboCampo2
            // 
            this.cboCampo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo2.FormattingEnabled = true;
            this.cboCampo2.Location = new System.Drawing.Point(64, 474);
            this.cboCampo2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCampo2.Name = "cboCampo2";
            this.cboCampo2.Size = new System.Drawing.Size(140, 23);
            this.cboCampo2.TabIndex = 13;
            this.cboCampo2.SelectedIndexChanged += new System.EventHandler(this.cboCampo2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 483);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rango de Precio";
            // 
            // cboCriterio2
            // 
            this.cboCriterio2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio2.FormattingEnabled = true;
            this.cboCriterio2.Location = new System.Drawing.Point(336, 474);
            this.cboCriterio2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCriterio2.Name = "cboCriterio2";
            this.cboCriterio2.Size = new System.Drawing.Size(140, 23);
            this.cboCriterio2.TabIndex = 15;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(683, 468);
            this.btnBuscar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(77, 33);
            this.btnBuscar2.TabIndex = 16;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(497, 429);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(35, 15);
            this.lblFiltro.TabIndex = 17;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblFiltro2
            // 
            this.lblFiltro2.AutoSize = true;
            this.lblFiltro2.Location = new System.Drawing.Point(497, 483);
            this.lblFiltro2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro2.Name = "lblFiltro2";
            this.lblFiltro2.Size = new System.Drawing.Size(35, 15);
            this.lblFiltro2.TabIndex = 18;
            this.lblFiltro2.Text = "Filtro";
            // 
            // txtFiltro2
            // 
            this.txtFiltro2.Location = new System.Drawing.Point(538, 475);
            this.txtFiltro2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro2.Name = "txtFiltro2";
            this.txtFiltro2.Size = new System.Drawing.Size(122, 23);
            this.txtFiltro2.TabIndex = 19;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(538, 420);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(122, 23);
            this.txtFiltro.TabIndex = 20;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(480, 327);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(94, 40);
            this.btnDetalle.TabIndex = 21;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 532);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.txtFiltro2);
            this.Controls.Add(this.lblFiltro2);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.cboCriterio2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCampo2);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.txtBuscador);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Articulos";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboCampo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCriterio2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblFiltro2;
        private System.Windows.Forms.TextBox txtFiltro2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnDetalle;
    }
}

