namespace Semana_Proyecto_Arbol_Binario_Ejemplo {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnRamas = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.radioIzquierda = new System.Windows.Forms.RadioButton();
            this.radioDerecha = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(175, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arbol Binario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Numero";
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(264, 109);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 2;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(65, 190);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(82, 23);
            this.btnRaiz.TabIndex = 3;
            this.btnRaiz.Text = "Insertar Raiz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnRamas
            // 
            this.btnRamas.Location = new System.Drawing.Point(65, 238);
            this.btnRamas.Name = "btnRamas";
            this.btnRamas.Size = new System.Drawing.Size(82, 41);
            this.btnRamas.TabIndex = 4;
            this.btnRamas.Text = "Ingresar Ramas";
            this.btnRamas.UseVisualStyleBackColor = true;
            this.btnRamas.Click += new System.EventHandler(this.btnRamas_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(65, 406);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(82, 23);
            this.btnAltura.TabIndex = 5;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // radioIzquierda
            // 
            this.radioIzquierda.AutoSize = true;
            this.radioIzquierda.Location = new System.Drawing.Point(65, 316);
            this.radioIzquierda.Name = "radioIzquierda";
            this.radioIzquierda.Size = new System.Drawing.Size(68, 17);
            this.radioIzquierda.TabIndex = 6;
            this.radioIzquierda.TabStop = true;
            this.radioIzquierda.Text = "Izquierda";
            this.radioIzquierda.UseVisualStyleBackColor = true;
            // 
            // radioDerecha
            // 
            this.radioDerecha.AutoSize = true;
            this.radioDerecha.Location = new System.Drawing.Point(65, 351);
            this.radioDerecha.Name = "radioDerecha";
            this.radioDerecha.Size = new System.Drawing.Size(66, 17);
            this.radioDerecha.TabIndex = 7;
            this.radioDerecha.TabStop = true;
            this.radioDerecha.Text = "Derecha";
            this.radioDerecha.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(222, 325);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioDerecha);
            this.Controls.Add(this.radioIzquierda);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnRamas);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnRamas;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.RadioButton radioIzquierda;
        private System.Windows.Forms.RadioButton radioDerecha;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

