namespace ConeccionDB
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.Lblapellido = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtApe = new System.Windows.Forms.TextBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnElimi = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(205, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese su nombre";
            // 
            // Lblapellido
            // 
            this.Lblapellido.AutoSize = true;
            this.Lblapellido.Location = new System.Drawing.Point(205, 134);
            this.Lblapellido.Name = "Lblapellido";
            this.Lblapellido.Size = new System.Drawing.Size(95, 13);
            this.Lblapellido.TabIndex = 1;
            this.Lblapellido.Text = "Ingrese su apellido";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(338, 81);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(100, 20);
            this.TxtNom.TabIndex = 2;
            // 
            // TxtApe
            // 
            this.TxtApe.Location = new System.Drawing.Point(338, 134);
            this.TxtApe.Name = "TxtApe";
            this.TxtApe.Size = new System.Drawing.Size(100, 20);
            this.TxtApe.TabIndex = 3;
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(502, 81);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnCrear.TabIndex = 4;
            this.BtnCrear.Text = "Crear usuario";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(502, 36);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar usuario";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnElimi
            // 
            this.BtnElimi.Location = new System.Drawing.Point(633, 81);
            this.BtnElimi.Name = "BtnElimi";
            this.BtnElimi.Size = new System.Drawing.Size(75, 23);
            this.BtnElimi.TabIndex = 6;
            this.BtnElimi.Text = "Eliminar";
            this.BtnElimi.UseVisualStyleBackColor = true;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(633, 36);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 7;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(206, 36);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(68, 13);
            this.LblId.TabIndex = 8;
            this.LblId.Text = "Ingrese su Id";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(338, 36);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 9;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(338, 179);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(100, 20);
            this.TxtCorreo.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(338, 226);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 11;
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(204, 179);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(89, 13);
            this.LblCorreo.TabIndex = 12;
            this.LblCorreo.Text = "Ingrese su correo";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(204, 233);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(97, 13);
            this.LblTel.TabIndex = 13;
            this.LblTel.Text = "Ingrese su telefono";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.BtnElimi);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.TxtApe);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.Lblapellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label Lblapellido;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtApe;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnElimi;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTel;
    }
}

