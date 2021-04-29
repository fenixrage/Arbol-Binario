
namespace WindowsFormsApp1
{
    partial class GUIArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIArbolBinario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.txtOrdenes = new System.Windows.Forms.TextBox();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarArbol = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnContarNodos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtLimpiar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCadena);
            this.panel1.Controls.Add(this.btnPostOrden);
            this.panel1.Controls.Add(this.txtOrdenes);
            this.panel1.Controls.Add(this.btnInOrden);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPreOrden);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 161);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operación";
            // 
            // txtCadena
            // 
            this.txtCadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadena.Location = new System.Drawing.Point(152, 15);
            this.txtCadena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(501, 30);
            this.txtCadena.TabIndex = 0;
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostOrden.Location = new System.Drawing.Point(382, 96);
            this.btnPostOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(149, 41);
            this.btnPostOrden.TabIndex = 8;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // txtOrdenes
            // 
            this.txtOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenes.Location = new System.Drawing.Point(152, 61);
            this.txtOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrdenes.Name = "txtOrdenes";
            this.txtOrdenes.Size = new System.Drawing.Size(501, 30);
            this.txtOrdenes.TabIndex = 4;
            // 
            // btnInOrden
            // 
            this.btnInOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInOrden.Location = new System.Drawing.Point(201, 96);
            this.btnInOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(149, 41);
            this.btnInOrden.TabIndex = 7;
            this.btnInOrden.Text = "InOrden";
            this.btnInOrden.UseVisualStyleBackColor = true;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Orden";
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreOrden.Location = new System.Drawing.Point(28, 96);
            this.btnPreOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(149, 41);
            this.btnPreOrden.TabIndex = 6;
            this.btnPreOrden.Text = "Preorden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimpiar.Location = new System.Drawing.Point(553, 96);
            this.txtLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(100, 41);
            this.txtLimpiar.TabIndex = 9;
            this.txtLimpiar.Text = "Limpiar";
            this.txtLimpiar.UseVisualStyleBackColor = true;
            this.txtLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(185, 615);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(501, 30);
            this.txtResultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado";
            // 
            // btnGenerarArbol
            // 
            this.btnGenerarArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarArbol.Location = new System.Drawing.Point(16, 659);
            this.btnGenerarArbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarArbol.Name = "btnGenerarArbol";
            this.btnGenerarArbol.Size = new System.Drawing.Size(175, 41);
            this.btnGenerarArbol.TabIndex = 10;
            this.btnGenerarArbol.Text = "Generar arbol";
            this.btnGenerarArbol.UseVisualStyleBackColor = true;
            this.btnGenerarArbol.Click += new System.EventHandler(this.btnGenerarArbol_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(215, 659);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(148, 41);
            this.btnResultado.TabIndex = 11;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(16, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 374);
            this.panel2.TabIndex = 12;
            // 
            // btnContarNodos
            // 
            this.btnContarNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContarNodos.Location = new System.Drawing.Point(385, 659);
            this.btnContarNodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContarNodos.Name = "btnContarNodos";
            this.btnContarNodos.Size = new System.Drawing.Size(148, 41);
            this.btnContarNodos.TabIndex = 13;
            this.btnContarNodos.Text = "Contar nodos";
            this.btnContarNodos.UseVisualStyleBackColor = true;
            this.btnContarNodos.Click += new System.EventHandler(this.btnContarNodos_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 659);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Contar nodos hoja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.Location = new System.Drawing.Point(272, 704);
            this.btnAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(196, 41);
            this.btnAltura.TabIndex = 15;
            this.btnAltura.Text = "Altura del arbol";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // GUIArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 751);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnContarNodos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnGenerarArbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUIArbolBinario";
            this.Text = "Arbol Binario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtOrdenes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button txtLimpiar;
        private System.Windows.Forms.Button btnGenerarArbol;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnContarNodos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAltura;
    }
}