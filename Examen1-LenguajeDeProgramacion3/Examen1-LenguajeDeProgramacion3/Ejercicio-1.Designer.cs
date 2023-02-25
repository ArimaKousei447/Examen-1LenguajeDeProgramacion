namespace Examen1_LenguajeDeProgramacion3
{
    partial class Ejercicio_1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ltbDatos = new System.Windows.Forms.ListBox();
            this.ltbMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 170);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 50);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ltbDatos
            // 
            this.ltbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbDatos.FormattingEnabled = true;
            this.ltbDatos.ItemHeight = 24;
            this.ltbDatos.Location = new System.Drawing.Point(303, 13);
            this.ltbDatos.Name = "ltbDatos";
            this.ltbDatos.Size = new System.Drawing.Size(166, 340);
            this.ltbDatos.TabIndex = 1;
            // 
            // ltbMeses
            // 
            this.ltbMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbMeses.FormattingEnabled = true;
            this.ltbMeses.ItemHeight = 24;
            this.ltbMeses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo ",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Dicembre"});
            this.ltbMeses.Location = new System.Drawing.Point(125, 13);
            this.ltbMeses.Name = "ltbMeses";
            this.ltbMeses.Size = new System.Drawing.Size(161, 340);
            this.ltbMeses.TabIndex = 2;
            // 
            // Ejercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 364);
            this.Controls.Add(this.ltbMeses);
            this.Controls.Add(this.ltbDatos);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Ejercicio_1";
            this.Text = "Ejercicio_1";
            this.Load += new System.EventHandler(this.Ejercicio_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox ltbDatos;
        private System.Windows.Forms.ListBox ltbMeses;
    }
}