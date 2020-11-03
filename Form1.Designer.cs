using System.Windows.Forms;

namespace Calculadora_1
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
            this.Boton1 = new System.Windows.Forms.Button();
            this.Boton4 = new System.Windows.Forms.Button();
            this.Boton7 = new System.Windows.Forms.Button();
            this.Boton0 = new System.Windows.Forms.Button();
            this.Boton8 = new System.Windows.Forms.Button();
            this.Boton5 = new System.Windows.Forms.Button();
            this.Boton2 = new System.Windows.Forms.Button();
            this.Boton9 = new System.Windows.Forms.Button();
            this.Boton6 = new System.Windows.Forms.Button();
            this.Boton3 = new System.Windows.Forms.Button();
            this.BotonResta = new System.Windows.Forms.Button();
            this.BotonSuma = new System.Windows.Forms.Button();
            this.BotonMultiplicar = new System.Windows.Forms.Button();
            this.BotonDividir = new System.Windows.Forms.Button();
            this.Pantalla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boton1
            // 
            this.Boton1.Location = new System.Drawing.Point(158, 207);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(50, 60);
            this.Boton1.TabIndex = 0;
            this.Boton1.Text = "1";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.Boton1_Click);
            // 
            // Boton4
            // 
            this.Boton4.Location = new System.Drawing.Point(158, 141);
            this.Boton4.Name = "Boton4";
            this.Boton4.Size = new System.Drawing.Size(50, 60);
            this.Boton4.TabIndex = 1;
            this.Boton4.Text = "4";
            this.Boton4.UseVisualStyleBackColor = true;
            this.Boton4.Click += new System.EventHandler(this.Boton4_Click);
            // 
            // Boton7
            // 
            this.Boton7.Location = new System.Drawing.Point(158, 75);
            this.Boton7.Name = "Boton7";
            this.Boton7.Size = new System.Drawing.Size(50, 60);
            this.Boton7.TabIndex = 2;
            this.Boton7.Text = "7";
            this.Boton7.UseVisualStyleBackColor = true;
            this.Boton7.Click += new System.EventHandler(this.Boton7_Click);
            // 
            // Boton0
            // 
            this.Boton0.Location = new System.Drawing.Point(158, 273);
            this.Boton0.Name = "Boton0";
            this.Boton0.Size = new System.Drawing.Size(106, 60);
            this.Boton0.TabIndex = 3;
            this.Boton0.Text = "0";
            this.Boton0.UseVisualStyleBackColor = true;
            this.Boton0.Click += new System.EventHandler(this.Boton0_Click);
            // 
            // Boton8
            // 
            this.Boton8.Location = new System.Drawing.Point(214, 75);
            this.Boton8.Name = "Boton8";
            this.Boton8.Size = new System.Drawing.Size(50, 60);
            this.Boton8.TabIndex = 6;
            this.Boton8.Text = "8";
            this.Boton8.UseVisualStyleBackColor = true;
            this.Boton8.Click += new System.EventHandler(this.Boton8_Click);
            // 
            // Boton5
            // 
            this.Boton5.Location = new System.Drawing.Point(214, 141);
            this.Boton5.Name = "Boton5";
            this.Boton5.Size = new System.Drawing.Size(50, 60);
            this.Boton5.TabIndex = 5;
            this.Boton5.Text = "5";
            this.Boton5.UseVisualStyleBackColor = true;
            this.Boton5.Click += new System.EventHandler(this.Boton5_Click);
            // 
            // Boton2
            // 
            this.Boton2.Location = new System.Drawing.Point(214, 207);
            this.Boton2.Name = "Boton2";
            this.Boton2.Size = new System.Drawing.Size(50, 60);
            this.Boton2.TabIndex = 4;
            this.Boton2.Text = "2";
            this.Boton2.UseVisualStyleBackColor = true;
            this.Boton2.Click += new System.EventHandler(this.Boton2_Click);
            // 
            // Boton9
            // 
            this.Boton9.Location = new System.Drawing.Point(270, 75);
            this.Boton9.Name = "Boton9";
            this.Boton9.Size = new System.Drawing.Size(50, 60);
            this.Boton9.TabIndex = 10;
            this.Boton9.Text = "9";
            this.Boton9.UseVisualStyleBackColor = true;
            this.Boton9.Click += new System.EventHandler(this.Boton9_Click);
            // 
            // Boton6
            // 
            this.Boton6.Location = new System.Drawing.Point(270, 141);
            this.Boton6.Name = "Boton6";
            this.Boton6.Size = new System.Drawing.Size(50, 60);
            this.Boton6.TabIndex = 9;
            this.Boton6.Text = "6";
            this.Boton6.UseVisualStyleBackColor = true;
            this.Boton6.Click += new System.EventHandler(this.Boton6_Click);
            // 
            // Boton3
            // 
            this.Boton3.Location = new System.Drawing.Point(270, 207);
            this.Boton3.Name = "Boton3";
            this.Boton3.Size = new System.Drawing.Size(50, 60);
            this.Boton3.TabIndex = 8;
            this.Boton3.Text = "3";
            this.Boton3.UseVisualStyleBackColor = true;
            this.Boton3.Click += new System.EventHandler(this.Boton3_Click);
            // 
            // BotonResta
            // 
            this.BotonResta.Location = new System.Drawing.Point(326, 75);
            this.BotonResta.Name = "BotonResta";
            this.BotonResta.Size = new System.Drawing.Size(50, 60);
            this.BotonResta.TabIndex = 15;
            this.BotonResta.Text = "-";
            // 
            // BotonSuma
            // 
            this.BotonSuma.Location = new System.Drawing.Point(326, 141);
            this.BotonSuma.Name = "BotonSuma";
            this.BotonSuma.Size = new System.Drawing.Size(50, 60);
            this.BotonSuma.TabIndex = 14;
            this.BotonSuma.Text = "+";
            // 
            // BotonMultiplicar
            // 
            this.BotonMultiplicar.Location = new System.Drawing.Point(326, 207);
            this.BotonMultiplicar.Name = "BotonMultiplicar";
            this.BotonMultiplicar.Size = new System.Drawing.Size(50, 60);
            this.BotonMultiplicar.TabIndex = 13;
            this.BotonMultiplicar.Text = "*";
            this.BotonMultiplicar.UseVisualStyleBackColor = true;
            // 
            // BotonDividir
            // 
            this.BotonDividir.Location = new System.Drawing.Point(326, 273);
            this.BotonDividir.Name = "BotonDividir";
            this.BotonDividir.Size = new System.Drawing.Size(50, 60);
            this.BotonDividir.TabIndex = 12;
            this.BotonDividir.Text = "/";
            this.BotonDividir.UseVisualStyleBackColor = true;
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.SystemColors.Window;
            this.Pantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pantalla.Location = new System.Drawing.Point(158, 32);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(218, 40);
            this.Pantalla.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(148, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 325);
            this.label1.TabIndex = 17;
            // 
            // ButtonIgual
            // 
            this.ButtonIgual.Location = new System.Drawing.Point(270, 273);
            this.ButtonIgual.Name = "ButtonIgual";
            this.ButtonIgual.Size = new System.Drawing.Size(50, 60);
            this.ButtonIgual.TabIndex = 18;
            this.ButtonIgual.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonIgual);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.BotonResta);
            this.Controls.Add(this.BotonSuma);
            this.Controls.Add(this.BotonMultiplicar);
            this.Controls.Add(this.BotonDividir);
            this.Controls.Add(this.Boton9);
            this.Controls.Add(this.Boton6);
            this.Controls.Add(this.Boton3);
            this.Controls.Add(this.Boton8);
            this.Controls.Add(this.Boton5);
            this.Controls.Add(this.Boton2);
            this.Controls.Add(this.Boton0);
            this.Controls.Add(this.Boton7);
            this.Controls.Add(this.Boton4);
            this.Controls.Add(this.Boton1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton1;
        private System.Windows.Forms.Button Boton4;
        private System.Windows.Forms.Button Boton7;
        private System.Windows.Forms.Button Boton0;
        private System.Windows.Forms.Button Boton8;
        private System.Windows.Forms.Button Boton5;
        private System.Windows.Forms.Button Boton2;
        private System.Windows.Forms.Button Boton9;
        private System.Windows.Forms.Button Boton6;
        private System.Windows.Forms.Button Boton3;
        private System.Windows.Forms.Button BotonResta;
        private System.Windows.Forms.Button BotonSuma;
        private System.Windows.Forms.Button BotonMultiplicar;
        private System.Windows.Forms.Button BotonDividir;
        private System.Windows.Forms.Label Pantalla;
        private readonly ControlEventHandler button4_ControlAdded;
        private Label label1;
        private Button ButtonIgual;
    }
}

