namespace Clase4_05_2024
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCredenciales = new System.Windows.Forms.Label();
            this.labelUsu = new System.Windows.Forms.Label();
            this.labelContra = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCredenciales
            // 
            this.labelCredenciales.AutoSize = true;
            this.labelCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredenciales.Location = new System.Drawing.Point(33, 9);
            this.labelCredenciales.Name = "labelCredenciales";
            this.labelCredenciales.Size = new System.Drawing.Size(411, 39);
            this.labelCredenciales.TabIndex = 0;
            this.labelCredenciales.Text = "Ingrese sus Credenciales ";
            // 
            // labelUsu
            // 
            this.labelUsu.AutoSize = true;
            this.labelUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsu.Location = new System.Drawing.Point(84, 101);
            this.labelUsu.Name = "labelUsu";
            this.labelUsu.Size = new System.Drawing.Size(67, 20);
            this.labelUsu.TabIndex = 1;
            this.labelUsu.Text = "Usuario";
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContra.Location = new System.Drawing.Point(84, 172);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(95, 20);
            this.labelContra.TabIndex = 2;
            this.labelContra.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(204, 172);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PasswordChar = '+';
            this.textBoxUsuario.Size = new System.Drawing.Size(207, 22);
            this.textBoxUsuario.TabIndex = 4;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(167, 258);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(120, 47);
            this.buttonIngresar.TabIndex = 5;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clase4_05_2024.Properties.Resources.rei_png;
            this.ClientSize = new System.Drawing.Size(485, 421);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelContra);
            this.Controls.Add(this.labelUsu);
            this.Controls.Add(this.labelCredenciales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MegaApp";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCredenciales;
        private System.Windows.Forms.Label labelUsu;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonIngresar;
    }
}

