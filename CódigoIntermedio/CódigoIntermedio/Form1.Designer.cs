namespace CódigoIntermedio
{
    partial class codIntermedio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.btn_leer = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_entrada
            // 
            this.txt_entrada.Location = new System.Drawing.Point(33, 68);
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(100, 20);
            this.txt_entrada.TabIndex = 0;
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(156, 66);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(75, 23);
            this.btn_leer.TabIndex = 1;
            this.btn_leer.Text = "Leer";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(78, 138);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 2;
            // 
            // codIntermedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.txt_entrada);
            this.Name = "codIntermedio";
            this.Text = "Código Intermedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.TextBox txt_result;
    }
}

