namespace Pilas {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnApilar = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnVistazo = new System.Windows.Forms.Button();
            this.btnCantidadElementos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilas Stack LIFO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Numero";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnApilar
            // 
            this.btnApilar.Location = new System.Drawing.Point(49, 153);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(94, 26);
            this.btnApilar.TabIndex = 3;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = true;
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(49, 206);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(94, 27);
            this.btnDesapilar.TabIndex = 4;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            // 
            // btnVistazo
            // 
            this.btnVistazo.Location = new System.Drawing.Point(49, 263);
            this.btnVistazo.Name = "btnVistazo";
            this.btnVistazo.Size = new System.Drawing.Size(94, 29);
            this.btnVistazo.TabIndex = 5;
            this.btnVistazo.Text = "Vistazo";
            this.btnVistazo.UseVisualStyleBackColor = true;
            // 
            // btnCantidadElementos
            // 
            this.btnCantidadElementos.Location = new System.Drawing.Point(49, 325);
            this.btnCantidadElementos.Name = "btnCantidadElementos";
            this.btnCantidadElementos.Size = new System.Drawing.Size(94, 36);
            this.btnCantidadElementos.TabIndex = 6;
            this.btnCantidadElementos.Text = "Cantidad De Elementos";
            this.btnCantidadElementos.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(49, 381);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(236, 153);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(157, 264);
            this.listBoxNumeros.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 502);
            this.Controls.Add(this.listBoxNumeros);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCantidadElementos);
            this.Controls.Add(this.btnVistazo);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnApilar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnVistazo;
        private System.Windows.Forms.Button btnCantidadElementos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox listBoxNumeros;
    }
}

