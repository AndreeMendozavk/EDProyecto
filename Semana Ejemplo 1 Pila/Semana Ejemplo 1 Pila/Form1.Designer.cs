namespace Semana_Ejemplo_1_Pila
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnApilar = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnVistazo = new System.Windows.Forms.Button();
            this.btnElementos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pila";
            // 
            // btnApilar
            // 
            this.btnApilar.Location = new System.Drawing.Point(53, 158);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(94, 23);
            this.btnApilar.TabIndex = 1;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = true;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(53, 215);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(94, 23);
            this.btnDesapilar.TabIndex = 2;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // btnVistazo
            // 
            this.btnVistazo.Location = new System.Drawing.Point(53, 276);
            this.btnVistazo.Name = "btnVistazo";
            this.btnVistazo.Size = new System.Drawing.Size(94, 23);
            this.btnVistazo.TabIndex = 3;
            this.btnVistazo.Text = "Vistazo";
            this.btnVistazo.UseVisualStyleBackColor = true;
            this.btnVistazo.Click += new System.EventHandler(this.btnVistazo_Click);
            // 
            // btnElementos
            // 
            this.btnElementos.Location = new System.Drawing.Point(53, 338);
            this.btnElementos.Name = "btnElementos";
            this.btnElementos.Size = new System.Drawing.Size(94, 61);
            this.btnElementos.TabIndex = 4;
            this.btnElementos.Text = "Cantidad De Elementos";
            this.btnElementos.UseVisualStyleBackColor = true;
            this.btnElementos.Click += new System.EventHandler(this.btnElementos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(53, 423);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingresar Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(243, 85);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 7;
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.ItemHeight = 16;
            this.listBoxNombres.Location = new System.Drawing.Point(228, 158);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(188, 308);
            this.listBoxNombres.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 523);
            this.Controls.Add(this.listBoxNombres);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnElementos);
            this.Controls.Add(this.btnVistazo);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnApilar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnVistazo;
        private System.Windows.Forms.Button btnElementos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ListBox listBoxNombres;
    }
}

