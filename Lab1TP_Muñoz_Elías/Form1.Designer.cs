namespace Lab1TP_Muñoz_Elías
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grillDatosIng = new System.Windows.Forms.DataGridView();
            this.columDom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMomentoIngreso = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.cboLugaresCoch = new System.Windows.Forms.ComboBox();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDominioSearch = new System.Windows.Forms.TextBox();
            this.lblimporte = new System.Windows.Forms.Label();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.btnEgresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.horaIngreso = new System.Windows.Forms.Timer(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillDatosIng)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grillDatosIng);
            this.groupBox1.Controls.Add(this.txtMomentoIngreso);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtDominio);
            this.groupBox1.Controls.Add(this.cboLugaresCoch);
            this.groupBox1.Controls.Add(this.cboTipoVehiculo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(404, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            // 
            // grillDatosIng
            // 
            this.grillDatosIng.AllowUserToAddRows = false;
            this.grillDatosIng.AllowUserToDeleteRows = false;
            this.grillDatosIng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grillDatosIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillDatosIng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columDom,
            this.columTipo,
            this.columLugar,
            this.columIngreso});
            this.grillDatosIng.Location = new System.Drawing.Point(7, 224);
            this.grillDatosIng.Name = "grillDatosIng";
            this.grillDatosIng.ReadOnly = true;
            this.grillDatosIng.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grillDatosIng.RowHeadersVisible = false;
            this.grillDatosIng.Size = new System.Drawing.Size(389, 234);
            this.grillDatosIng.TabIndex = 5;
            // 
            // columDom
            // 
            this.columDom.HeaderText = "DOMINIO";
            this.columDom.Name = "columDom";
            this.columDom.ReadOnly = true;
            this.columDom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columTipo
            // 
            this.columTipo.HeaderText = "TIPO";
            this.columTipo.Name = "columTipo";
            this.columTipo.ReadOnly = true;
            this.columTipo.Width = 80;
            // 
            // columLugar
            // 
            this.columLugar.HeaderText = "LUGAR";
            this.columLugar.Name = "columLugar";
            this.columLugar.ReadOnly = true;
            this.columLugar.Width = 60;
            // 
            // columIngreso
            // 
            this.columIngreso.HeaderText = "ENTRADA";
            this.columIngreso.Name = "columIngreso";
            this.columIngreso.ReadOnly = true;
            this.columIngreso.Width = 140;
            // 
            // txtMomentoIngreso
            // 
            this.txtMomentoIngreso.Location = new System.Drawing.Point(177, 117);
            this.txtMomentoIngreso.Name = "txtMomentoIngreso";
            this.txtMomentoIngreso.ReadOnly = true;
            this.txtMomentoIngreso.Size = new System.Drawing.Size(107, 20);
            this.txtMomentoIngreso.TabIndex = 7;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(308, 158);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(88, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "&Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(177, 33);
            this.txtDominio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(107, 20);
            this.txtDominio.TabIndex = 5;
            this.txtDominio.TextChanged += new System.EventHandler(this.txtDominio_TextChanged);
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // cboLugaresCoch
            // 
            this.cboLugaresCoch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLugaresCoch.FormattingEnabled = true;
            this.cboLugaresCoch.Location = new System.Drawing.Point(201, 158);
            this.cboLugaresCoch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboLugaresCoch.Name = "cboLugaresCoch";
            this.cboLugaresCoch.Size = new System.Drawing.Size(83, 21);
            this.cboLugaresCoch.TabIndex = 4;
            this.cboLugaresCoch.SelectedIndexChanged += new System.EventHandler(this.cboLugaresCoch_SelectedIndexChanged);
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Items.AddRange(new object[] {
            "Automóvil",
            "Utilitario"});
            this.cboTipoVehiculo.Location = new System.Drawing.Point(177, 72);
            this.cboTipoVehiculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(107, 21);
            this.cboTipoVehiculo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Momento de Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Vehículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dominio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lugar disponible en Cochera";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDominioSearch);
            this.groupBox2.Controls.Add(this.lblimporte);
            this.groupBox2.Controls.Add(this.lblEgreso);
            this.groupBox2.Controls.Add(this.lblIngreso);
            this.groupBox2.Controls.Add(this.lblUbicacion);
            this.groupBox2.Controls.Add(this.lblTipoVehiculo);
            this.groupBox2.Controls.Add(this.btnEgresar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(426, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(421, 345);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egreso";
            // 
            // txtDominioSearch
            // 
            this.txtDominioSearch.Location = new System.Drawing.Point(123, 43);
            this.txtDominioSearch.MaxLength = 7;
            this.txtDominioSearch.Multiline = true;
            this.txtDominioSearch.Name = "txtDominioSearch";
            this.txtDominioSearch.Size = new System.Drawing.Size(117, 23);
            this.txtDominioSearch.TabIndex = 15;
            this.txtDominioSearch.TextChanged += new System.EventHandler(this.txtDominioSearch_TextChanged);
            this.txtDominioSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominioSearch_KeyPress);
            // 
            // lblimporte
            // 
            this.lblimporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblimporte.Location = new System.Drawing.Point(123, 249);
            this.lblimporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblimporte.Name = "lblimporte";
            this.lblimporte.Size = new System.Drawing.Size(117, 23);
            this.lblimporte.TabIndex = 14;
            this.lblimporte.TextChanged += new System.EventHandler(this.lblimporte_TextChanged);
            // 
            // lblEgreso
            // 
            this.lblEgreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEgreso.Location = new System.Drawing.Point(123, 203);
            this.lblEgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(268, 23);
            this.lblEgreso.TabIndex = 13;
            // 
            // lblIngreso
            // 
            this.lblIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIngreso.Location = new System.Drawing.Point(123, 160);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(268, 23);
            this.lblIngreso.TabIndex = 12;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUbicacion.Location = new System.Drawing.Point(123, 119);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(117, 23);
            this.lblUbicacion.TabIndex = 11;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(123, 84);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(117, 23);
            this.lblTipoVehiculo.TabIndex = 10;
            // 
            // btnEgresar
            // 
            this.btnEgresar.Location = new System.Drawing.Point(303, 249);
            this.btnEgresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEgresar.Name = "btnEgresar";
            this.btnEgresar.Size = new System.Drawing.Size(88, 23);
            this.btnEgresar.TabIndex = 9;
            this.btnEgresar.Text = "&Egresar";
            this.btnEgresar.UseVisualStyleBackColor = true;
            this.btnEgresar.Click += new System.EventHandler(this.btnEgresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(303, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Importe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Egreso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ubicación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo de Vehículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dominio";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(702, 371);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // horaIngreso
            // 
            this.horaIngreso.Enabled = true;
            this.horaIngreso.Tick += new System.EventHandler(this.horaIngreso_Tick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(514, 371);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 488);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Estacionamiento Central";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillDatosIng)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.ComboBox cboLugaresCoch;
        private System.Windows.Forms.ComboBox cboTipoVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEgresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblimporte;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.TextBox txtMomentoIngreso;
        private System.Windows.Forms.TextBox txtDominioSearch;
        private System.Windows.Forms.Timer horaIngreso;
        private System.Windows.Forms.DataGridView grillDatosIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDom;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columLugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columIngreso;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

