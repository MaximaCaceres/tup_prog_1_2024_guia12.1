
namespace _12.Ej2AccesoControl
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
            this.btnVerEstadia = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbPatente = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.tbxPatente = new System.Windows.Forms.TextBox();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.gbxDatosIngreso = new System.Windows.Forms.GroupBox();
            this.gbxDatosIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerEstadia
            // 
            this.btnVerEstadia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerEstadia.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerEstadia.Location = new System.Drawing.Point(384, 42);
            this.btnVerEstadia.Name = "btnVerEstadia";
            this.btnVerEstadia.Size = new System.Drawing.Size(145, 69);
            this.btnVerEstadia.TabIndex = 1;
            this.btnVerEstadia.Text = "Ver Estadia";
            this.btnVerEstadia.UseVisualStyleBackColor = false;
            this.btnVerEstadia.Click += new System.EventHandler(this.btnVerEstadia_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegistrar.Location = new System.Drawing.Point(100, 265);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(145, 69);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(146, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Es electrico?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbPatente
            // 
            this.lbPatente.AutoSize = true;
            this.lbPatente.Location = new System.Drawing.Point(88, 56);
            this.lbPatente.Name = "lbPatente";
            this.lbPatente.Size = new System.Drawing.Size(44, 13);
            this.lbPatente.TabIndex = 4;
            this.lbPatente.Text = "Patente";
            this.lbPatente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(85, 107);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(86, 13);
            this.lbTipo.TabIndex = 5;
            this.lbTipo.Text = "Tipo de vehiculo";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(105, 174);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(140, 13);
            this.lbModelo.TabIndex = 6;
            this.lbModelo.Text = "Modelo (Año de fabricacion)";
            // 
            // tbxPatente
            // 
            this.tbxPatente.Location = new System.Drawing.Point(179, 56);
            this.tbxPatente.Name = "tbxPatente";
            this.tbxPatente.Size = new System.Drawing.Size(152, 20);
            this.tbxPatente.TabIndex = 7;
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(251, 171);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(80, 20);
            this.tbxModelo.TabIndex = 8;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Automovil",
            "Motocicleta",
            "Camioneta",
            "Camion",
            "",
            ""});
            this.cbxTipo.Location = new System.Drawing.Point(177, 104);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(154, 21);
            this.cbxTipo.TabIndex = 9;
            // 
            // gbxDatosIngreso
            // 
            this.gbxDatosIngreso.BackColor = System.Drawing.Color.Snow;
            this.gbxDatosIngreso.Controls.Add(this.lbPatente);
            this.gbxDatosIngreso.Controls.Add(this.checkBox1);
            this.gbxDatosIngreso.Controls.Add(this.btnRegistrar);
            this.gbxDatosIngreso.Controls.Add(this.tbxPatente);
            this.gbxDatosIngreso.Controls.Add(this.cbxTipo);
            this.gbxDatosIngreso.Controls.Add(this.lbModelo);
            this.gbxDatosIngreso.Controls.Add(this.lbTipo);
            this.gbxDatosIngreso.Controls.Add(this.tbxModelo);
            this.gbxDatosIngreso.Location = new System.Drawing.Point(12, 42);
            this.gbxDatosIngreso.Name = "gbxDatosIngreso";
            this.gbxDatosIngreso.Size = new System.Drawing.Size(348, 349);
            this.gbxDatosIngreso.TabIndex = 10;
            this.gbxDatosIngreso.TabStop = false;
            this.gbxDatosIngreso.Text = "Datos de ingreso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(552, 425);
            this.Controls.Add(this.gbxDatosIngreso);
            this.Controls.Add(this.btnVerEstadia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxDatosIngreso.ResumeLayout(false);
            this.gbxDatosIngreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbPatente;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.GroupBox gbxDatosIngreso;
        public System.Windows.Forms.TextBox tbxPatente;
        public System.Windows.Forms.ComboBox cbxTipo;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox tbxModelo;
        public System.Windows.Forms.Button btnVerEstadia;
        public System.Windows.Forms.Button btnRegistrar;
    }
}

