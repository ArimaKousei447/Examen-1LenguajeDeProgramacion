namespace Examen1_LenguajeDeProgramacion3
{
    partial class Ejercicio_3
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
            this.ltbNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ltbNumeros
            // 
            this.ltbNumeros.FormattingEnabled = true;
            this.ltbNumeros.Location = new System.Drawing.Point(94, 12);
            this.ltbNumeros.Name = "ltbNumeros";
            this.ltbNumeros.Size = new System.Drawing.Size(142, 420);
            this.ltbNumeros.TabIndex = 0;
            // 
            // Ejercicio_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 454);
            this.Controls.Add(this.ltbNumeros);
            this.Name = "Ejercicio_3";
            this.Text = "Ejercicio_3";
            this.Load += new System.EventHandler(this.Ejercicio_3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbNumeros;
    }
}