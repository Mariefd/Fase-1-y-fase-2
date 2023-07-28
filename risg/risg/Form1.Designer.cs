namespace risg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtDaño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRiesgo = new System.Windows.Forms.TextBox();
            this.txtAnalista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wID = new System.Windows.Forms.Label();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBorar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dtgRiegos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgRiegos1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.v = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRiegos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRiegos1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtFecha);
            this.tabPage1.Controls.Add(this.txtDaño);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtRiesgo);
            this.tabPage1.Controls.Add(this.txtAnalista);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.wID);
            this.tabPage1.Controls.Add(this.txtActivo);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.btnBorar);
            this.tabPage1.Controls.Add(this.btnguardar);
            this.tabPage1.Controls.Add(this.dtgRiegos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "fase #1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Daño";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(255, 105);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 12;
            // 
            // txtDaño
            // 
            this.txtDaño.Location = new System.Drawing.Point(255, 73);
            this.txtDaño.Name = "txtDaño";
            this.txtDaño.Size = new System.Drawing.Size(100, 20);
            this.txtDaño.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Riesgo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Analista";
            // 
            // txtRiesgo
            // 
            this.txtRiesgo.Location = new System.Drawing.Point(255, 40);
            this.txtRiesgo.Name = "txtRiesgo";
            this.txtRiesgo.Size = new System.Drawing.Size(100, 20);
            this.txtRiesgo.TabIndex = 8;
            // 
            // txtAnalista
            // 
            this.txtAnalista.Location = new System.Drawing.Point(58, 102);
            this.txtAnalista.Name = "txtAnalista";
            this.txtAnalista.Size = new System.Drawing.Size(100, 20);
            this.txtAnalista.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Activo";
            // 
            // wID
            // 
            this.wID.AutoSize = true;
            this.wID.Location = new System.Drawing.Point(7, 47);
            this.wID.Name = "wID";
            this.wID.Size = new System.Drawing.Size(18, 13);
            this.wID.TabIndex = 5;
            this.wID.Text = "ID";
            this.wID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtActivo
            // 
            this.txtActivo.Location = new System.Drawing.Point(58, 73);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(100, 20);
            this.txtActivo.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(58, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // btnBorar
            // 
            this.btnBorar.Location = new System.Drawing.Point(655, 97);
            this.btnBorar.Name = "btnBorar";
            this.btnBorar.Size = new System.Drawing.Size(101, 35);
            this.btnBorar.TabIndex = 2;
            this.btnBorar.Text = "Borrar";
            this.btnBorar.UseVisualStyleBackColor = true;
            this.btnBorar.Click += new System.EventHandler(this.btnBorar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(655, 47);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(101, 35);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dtgRiegos
            // 
            this.dtgRiegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRiegos.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dtgRiegos.CausesValidation = false;
            this.dtgRiegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRiegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Activo,
            this.Analista,
            this.Riesgo,
            this.Daño,
            this.fecha});
            this.dtgRiegos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgRiegos.Location = new System.Drawing.Point(6, 164);
            this.dtgRiegos.Name = "dtgRiegos";
            this.dtgRiegos.Size = new System.Drawing.Size(774, 251);
            this.dtgRiegos.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgRiegos1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fase #2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // Analista
            // 
            this.Analista.HeaderText = "Analista";
            this.Analista.Name = "Analista";
            // 
            // Riesgo
            // 
            this.Riesgo.HeaderText = "Riesgo";
            this.Riesgo.Name = "Riesgo";
            // 
            // Daño
            // 
            this.Daño.HeaderText = "Daño";
            this.Daño.Name = "Daño";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // dtgRiegos1
            // 
            this.dtgRiegos1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRiegos1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dtgRiegos1.CausesValidation = false;
            this.dtgRiegos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRiegos1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.s,
            this.f,
            this.p,
            this.A,
            this.v,
            this.e});
            this.dtgRiegos1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgRiegos1.Location = new System.Drawing.Point(10, 167);
            this.dtgRiegos1.Name = "dtgRiegos1";
            this.dtgRiegos1.Size = new System.Drawing.Size(774, 251);
            this.dtgRiegos1.TabIndex = 1;
            this.dtgRiegos1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 132.4226F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 132.4226F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 132.4226F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Riesgo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 132.4226F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Analista";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 132.4226F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Daño";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 132.4226F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // s
            // 
            this.s.FillWeight = 60.9137F;
            this.s.HeaderText = "S";
            this.s.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.s.Name = "s";
            this.s.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.s.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // f
            // 
            this.f.FillWeight = 75.34941F;
            this.f.HeaderText = "F";
            this.f.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.f.Name = "f";
            this.f.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.f.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // p
            // 
            this.p.FillWeight = 72.29737F;
            this.p.HeaderText = "P";
            this.p.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.p.Name = "p";
            this.p.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.p.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // A
            // 
            this.A.FillWeight = 69.08211F;
            this.A.HeaderText = "A";
            this.A.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.A.Name = "A";
            this.A.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.A.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // v
            // 
            this.v.FillWeight = 65.69492F;
            this.v.HeaderText = "V";
            this.v.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.v.Name = "v";
            this.v.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.v.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // e
            // 
            this.e.FillWeight = 62.12658F;
            this.e.HeaderText = "E";
            this.e.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.e.Name = "e";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TABLA DE RIESGO";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRiegos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRiegos1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtDaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRiesgo;
        private System.Windows.Forms.TextBox txtAnalista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wID;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBorar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dtgRiegos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daño;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridView dtgRiegos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn s;
        private System.Windows.Forms.DataGridViewComboBoxColumn f;
        private System.Windows.Forms.DataGridViewComboBoxColumn p;
        private System.Windows.Forms.DataGridViewComboBoxColumn A;
        private System.Windows.Forms.DataGridViewComboBoxColumn v;
        private System.Windows.Forms.DataGridViewComboBoxColumn e;
    }
}

