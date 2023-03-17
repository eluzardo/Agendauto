namespace WindowsFormsApp1
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnGuardarAuto = new System.Windows.Forms.Button();
            this.tabAutos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAño = new System.Windows.Forms.DateTimePicker();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.lblMarcaNueva = new System.Windows.Forms.Label();
            this.txtMarcaNueva = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGuardarModelo = new System.Windows.Forms.Button();
            this.cboMarcaModelo = new System.Windows.Forms.ComboBox();
            this.txtModeloNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAutos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(92, 22);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(209, 20);
            this.fecha.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardarAuto
            // 
            this.btnGuardarAuto.Location = new System.Drawing.Point(18, 208);
            this.btnGuardarAuto.Name = "btnGuardarAuto";
            this.btnGuardarAuto.Size = new System.Drawing.Size(139, 26);
            this.btnGuardarAuto.TabIndex = 2;
            this.btnGuardarAuto.Text = "Guardar Auto";
            this.btnGuardarAuto.UseVisualStyleBackColor = true;
            this.btnGuardarAuto.Click += new System.EventHandler(this.btnGuardarAuto_Click);
            // 
            // tabAutos
            // 
            this.tabAutos.Controls.Add(this.tabPage1);
            this.tabAutos.Controls.Add(this.tabPage2);
            this.tabAutos.Controls.Add(this.tabPage3);
            this.tabAutos.Location = new System.Drawing.Point(12, 12);
            this.tabAutos.Name = "tabAutos";
            this.tabAutos.SelectedIndex = 0;
            this.tabAutos.Size = new System.Drawing.Size(1078, 426);
            this.tabAutos.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAño);
            this.tabPage1.Controls.Add(this.txtPatente);
            this.tabPage1.Controls.Add(this.lblPatente);
            this.tabPage1.Controls.Add(this.lblModelo);
            this.tabPage1.Controls.Add(this.lblMarca);
            this.tabPage1.Controls.Add(this.cboModelo);
            this.tabPage1.Controls.Add(this.lblFabricante);
            this.tabPage1.Controls.Add(this.cboMarca);
            this.tabPage1.Controls.Add(this.btnGuardarAuto);
            this.tabPage1.Controls.Add(this.lblFecha);
            this.tabPage1.Controls.Add(this.fecha);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1070, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cargar auto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAño
            // 
            this.txtAño.CustomFormat = "yyyy";
            this.txtAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtAño.Location = new System.Drawing.Point(92, 157);
            this.txtAño.Name = "txtAño";
            this.txtAño.ShowUpDown = true;
            this.txtAño.Size = new System.Drawing.Size(65, 20);
            this.txtAño.TabIndex = 12;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(92, 52);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(90, 20);
            this.txtPatente.TabIndex = 11;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(15, 55);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 10;
            this.lblPatente.Text = "Patente";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(15, 157);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(29, 13);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Año:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(15, 123);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Modelo:";
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(92, 120);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(209, 21);
            this.cboModelo.TabIndex = 5;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(15, 88);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(40, 13);
            this.lblFabricante.TabIndex = 4;
            this.lblFabricante.Text = "Marca:";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(92, 85);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(209, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnGuardarMarca);
            this.tabPage2.Controls.Add(this.lblMarcaNueva);
            this.tabPage2.Controls.Add(this.txtMarcaNueva);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1070, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cargar marca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(480, 294);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(37, 78);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(81, 24);
            this.btnGuardarMarca.TabIndex = 2;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // lblMarcaNueva
            // 
            this.lblMarcaNueva.AutoSize = true;
            this.lblMarcaNueva.Location = new System.Drawing.Point(32, 31);
            this.lblMarcaNueva.Name = "lblMarcaNueva";
            this.lblMarcaNueva.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaNueva.TabIndex = 1;
            this.lblMarcaNueva.Text = "Marca";
            // 
            // txtMarcaNueva
            // 
            this.txtMarcaNueva.Location = new System.Drawing.Point(106, 30);
            this.txtMarcaNueva.Name = "txtMarcaNueva";
            this.txtMarcaNueva.Size = new System.Drawing.Size(233, 20);
            this.txtMarcaNueva.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGuardarModelo);
            this.tabPage3.Controls.Add(this.cboMarcaModelo);
            this.tabPage3.Controls.Add(this.txtModeloNuevo);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1070, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cargar Modelo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGuardarModelo
            // 
            this.btnGuardarModelo.Location = new System.Drawing.Point(25, 87);
            this.btnGuardarModelo.Name = "btnGuardarModelo";
            this.btnGuardarModelo.Size = new System.Drawing.Size(108, 27);
            this.btnGuardarModelo.TabIndex = 4;
            this.btnGuardarModelo.Text = "Guardar modelo";
            this.btnGuardarModelo.UseVisualStyleBackColor = true;
            this.btnGuardarModelo.Click += new System.EventHandler(this.btnGuardarModelo_Click);
            // 
            // cboMarcaModelo
            // 
            this.cboMarcaModelo.FormattingEnabled = true;
            this.cboMarcaModelo.Location = new System.Drawing.Point(71, 44);
            this.cboMarcaModelo.Name = "cboMarcaModelo";
            this.cboMarcaModelo.Size = new System.Drawing.Size(155, 21);
            this.cboMarcaModelo.TabIndex = 3;
            // 
            // txtModeloNuevo
            // 
            this.txtModeloNuevo.Location = new System.Drawing.Point(71, 17);
            this.txtModeloNuevo.Name = "txtModeloNuevo";
            this.txtModeloNuevo.Size = new System.Drawing.Size(155, 20);
            this.txtModeloNuevo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 604);
            this.Controls.Add(this.tabAutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabAutos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnGuardarAuto;
        private System.Windows.Forms.TabControl tabAutos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label lblMarcaNueva;
        private System.Windows.Forms.TextBox txtMarcaNueva;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarModelo;
        private System.Windows.Forms.ComboBox cboMarcaModelo;
        private System.Windows.Forms.TextBox txtModeloNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtAño;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

