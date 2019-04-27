namespace ss_escolar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InsertB = new System.Windows.Forms.Button();
            this.labelmatricula = new System.Windows.Forms.Label();
            this.labelap1 = new System.Windows.Forms.Label();
            this.labelap2 = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelnacimiento = new System.Windows.Forms.Label();
            this.labelcorreo = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxAp1 = new System.Windows.Forms.TextBox();
            this.textBoxAp2 = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labeltelef = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonSQL = new System.Windows.Forms.Button();
            this.buttonCSV = new System.Windows.Forms.Button();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.buttonEXL = new System.Windows.Forms.Button();
            this.buttonWORD = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(794, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // InsertB
            // 
            this.InsertB.Location = new System.Drawing.Point(564, 255);
            this.InsertB.Name = "InsertB";
            this.InsertB.Size = new System.Drawing.Size(101, 37);
            this.InsertB.TabIndex = 1;
            this.InsertB.Text = "Insert";
            this.InsertB.UseVisualStyleBackColor = true;
            this.InsertB.Click += new System.EventHandler(this.InsertB_Click);
            // 
            // labelmatricula
            // 
            this.labelmatricula.AutoSize = true;
            this.labelmatricula.Location = new System.Drawing.Point(12, 267);
            this.labelmatricula.Name = "labelmatricula";
            this.labelmatricula.Size = new System.Drawing.Size(49, 13);
            this.labelmatricula.TabIndex = 2;
            this.labelmatricula.Text = "matricula";
            this.labelmatricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelap1
            // 
            this.labelap1.AutoSize = true;
            this.labelap1.Location = new System.Drawing.Point(12, 301);
            this.labelap1.Name = "labelap1";
            this.labelap1.Size = new System.Drawing.Size(54, 13);
            this.labelap1.TabIndex = 3;
            this.labelap1.Text = "Apellido P";
            // 
            // labelap2
            // 
            this.labelap2.AutoSize = true;
            this.labelap2.Location = new System.Drawing.Point(12, 336);
            this.labelap2.Name = "labelap2";
            this.labelap2.Size = new System.Drawing.Size(56, 13);
            this.labelap2.TabIndex = 4;
            this.labelap2.Text = "Apellido M";
            this.labelap2.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(287, 267);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(44, 13);
            this.labelnombre.TabIndex = 5;
            this.labelnombre.Text = "Nombre";
            this.labelnombre.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelnacimiento
            // 
            this.labelnacimiento.AutoSize = true;
            this.labelnacimiento.Location = new System.Drawing.Point(287, 301);
            this.labelnacimiento.Name = "labelnacimiento";
            this.labelnacimiento.Size = new System.Drawing.Size(60, 13);
            this.labelnacimiento.TabIndex = 6;
            this.labelnacimiento.Text = "Nacimiento";
            // 
            // labelcorreo
            // 
            this.labelcorreo.AutoSize = true;
            this.labelcorreo.Location = new System.Drawing.Point(287, 336);
            this.labelcorreo.Name = "labelcorreo";
            this.labelcorreo.Size = new System.Drawing.Size(38, 13);
            this.labelcorreo.TabIndex = 7;
            this.labelcorreo.Text = "Correo";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(67, 264);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(214, 20);
            this.textBoxMatricula.TabIndex = 8;
            // 
            // textBoxAp1
            // 
            this.textBoxAp1.Location = new System.Drawing.Point(72, 298);
            this.textBoxAp1.Name = "textBoxAp1";
            this.textBoxAp1.Size = new System.Drawing.Size(209, 20);
            this.textBoxAp1.TabIndex = 9;
            // 
            // textBoxAp2
            // 
            this.textBoxAp2.Location = new System.Drawing.Point(53, 333);
            this.textBoxAp2.Name = "textBoxAp2";
            this.textBoxAp2.Size = new System.Drawing.Size(228, 20);
            this.textBoxAp2.TabIndex = 10;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(328, 264);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(228, 20);
            this.textBoxNom.TabIndex = 11;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(328, 329);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(228, 20);
            this.textBoxCorreo.TabIndex = 13;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(328, 371);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(228, 20);
            this.textBoxTel.TabIndex = 15;
            // 
            // labeltelef
            // 
            this.labeltelef.AutoSize = true;
            this.labeltelef.Location = new System.Drawing.Point(287, 378);
            this.labeltelef.Name = "labeltelef";
            this.labeltelef.Size = new System.Drawing.Size(22, 13);
            this.labeltelef.TabIndex = 14;
            this.labeltelef.Text = "Tel";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(671, 255);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(101, 37);
            this.buttonE.TabIndex = 17;
            this.buttonE.Text = "Eliminar";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonSQL
            // 
            this.buttonSQL.Location = new System.Drawing.Point(564, 301);
            this.buttonSQL.Name = "buttonSQL";
            this.buttonSQL.Size = new System.Drawing.Size(101, 60);
            this.buttonSQL.TabIndex = 18;
            this.buttonSQL.Text = "SQL";
            this.buttonSQL.UseVisualStyleBackColor = true;
            this.buttonSQL.Click += new System.EventHandler(this.buttonSQL_Click);
            // 
            // buttonCSV
            // 
            this.buttonCSV.Location = new System.Drawing.Point(671, 301);
            this.buttonCSV.Name = "buttonCSV";
            this.buttonCSV.Size = new System.Drawing.Size(101, 60);
            this.buttonCSV.TabIndex = 19;
            this.buttonCSV.Text = "CSV";
            this.buttonCSV.UseVisualStyleBackColor = true;
            this.buttonCSV.Click += new System.EventHandler(this.buttonCSV_Click);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(564, 367);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(101, 60);
            this.buttonPDF.TabIndex = 20;
            this.buttonPDF.Text = "PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // buttonEXL
            // 
            this.buttonEXL.Location = new System.Drawing.Point(671, 367);
            this.buttonEXL.Name = "buttonEXL";
            this.buttonEXL.Size = new System.Drawing.Size(101, 60);
            this.buttonEXL.TabIndex = 21;
            this.buttonEXL.Text = "EXL";
            this.buttonEXL.UseVisualStyleBackColor = true;
            this.buttonEXL.Click += new System.EventHandler(this.buttonEXL_Click);
            // 
            // buttonWORD
            // 
            this.buttonWORD.Location = new System.Drawing.Point(671, 433);
            this.buttonWORD.Name = "buttonWORD";
            this.buttonWORD.Size = new System.Drawing.Size(101, 60);
            this.buttonWORD.TabIndex = 22;
            this.buttonWORD.Text = "WORD";
            this.buttonWORD.UseVisualStyleBackColor = true;
            // 
            // buttonJson
            // 
            this.buttonJson.Location = new System.Drawing.Point(564, 433);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(101, 60);
            this.buttonJson.TabIndex = 23;
            this.buttonJson.Text = "JSON";
            this.buttonJson.UseVisualStyleBackColor = true;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.buttonJson);
            this.Controls.Add(this.buttonWORD);
            this.Controls.Add(this.buttonEXL);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.buttonCSV);
            this.Controls.Add(this.buttonSQL);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.labeltelef);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxAp2);
            this.Controls.Add(this.textBoxAp1);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.labelcorreo);
            this.Controls.Add(this.labelnacimiento);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelap2);
            this.Controls.Add(this.labelap1);
            this.Controls.Add(this.labelmatricula);
            this.Controls.Add(this.InsertB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InsertB;
        private System.Windows.Forms.Label labelmatricula;
        private System.Windows.Forms.Label labelap1;
        private System.Windows.Forms.Label labelap2;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelnacimiento;
        private System.Windows.Forms.Label labelcorreo;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxAp1;
        private System.Windows.Forms.TextBox textBoxAp2;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labeltelef;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonSQL;
        private System.Windows.Forms.Button buttonCSV;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Button buttonEXL;
        private System.Windows.Forms.Button buttonWORD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonJson;
    }
}

