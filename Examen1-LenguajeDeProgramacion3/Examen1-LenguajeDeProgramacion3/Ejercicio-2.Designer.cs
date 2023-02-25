namespace Examen1_LenguajeDeProgramacion3
{
    partial class Ejercicio_2
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
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ltbNombreProducto = new System.Windows.Forms.ListBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.ltbPrecioProducto = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(307, 80);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(120, 20);
            this.txtPrecioProducto.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(174, 254);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 41);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ltbNombreProducto
            // 
            this.ltbNombreProducto.FormattingEnabled = true;
            this.ltbNombreProducto.Location = new System.Drawing.Point(155, 127);
            this.ltbNombreProducto.Name = "ltbNombreProducto";
            this.ltbNombreProducto.Size = new System.Drawing.Size(120, 95);
            this.ltbNombreProducto.TabIndex = 4;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(155, 80);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(120, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // ltbPrecioProducto
            // 
            this.ltbPrecioProducto.FormattingEnabled = true;
            this.ltbPrecioProducto.Location = new System.Drawing.Point(307, 127);
            this.ltbPrecioProducto.Name = "ltbPrecioProducto";
            this.ltbPrecioProducto.Size = new System.Drawing.Size(120, 95);
            this.ltbPrecioProducto.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(48, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(307, 275);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(120, 20);
            this.txtSubtotal.TabIndex = 8;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(304, 254);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(46, 13);
            this.lblSub.TabIndex = 9;
            this.lblSub.Text = "Subtotal";
            // 
            // Ejercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 385);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.ltbPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.ltbNombreProducto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrecioProducto);
            this.Name = "Ejercicio_2";
            this.Text = "Ejercicio_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox ltbNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.ListBox ltbPrecioProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSub;
    }
}