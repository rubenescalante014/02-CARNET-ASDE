namespace CARNET_ASDE
{
    partial class Carnet_Acceso_VIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet_Acceso_VIP));
            this.bimprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cedula = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // bimprimir
            // 
            this.bimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bimprimir.BackColor = System.Drawing.Color.White;
            this.bimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bimprimir.FlatAppearance.BorderSize = 0;
            this.bimprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimprimir.ForeColor = System.Drawing.Color.Black;
            this.bimprimir.Image = ((System.Drawing.Image)(resources.GetObject("bimprimir.Image")));
            this.bimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bimprimir.Location = new System.Drawing.Point(845, 40);
            this.bimprimir.Name = "bimprimir";
            this.bimprimir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bimprimir.Size = new System.Drawing.Size(119, 30);
            this.bimprimir.TabIndex = 117;
            this.bimprimir.Text = "Guardar";
            this.bimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bimprimir.UseVisualStyleBackColor = false;
            this.bimprimir.Click += new System.EventHandler(this.bimprimir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cedula);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.imagen);
            this.panel1.Location = new System.Drawing.Point(245, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 674);
            this.panel1.TabIndex = 116;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cedula
            // 
            this.cedula.BackColor = System.Drawing.Color.White;
            this.cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedula.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.ForeColor = System.Drawing.Color.Red;
            this.cedula.Location = new System.Drawing.Point(3, 475);
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Size = new System.Drawing.Size(413, 60);
            this.cedula.TabIndex = 12;
            this.cedula.Text = "ACCESO";
            this.cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(3, 444);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(412, 31);
            this.nombre.TabIndex = 14;
            this.nombre.Text = "#NOMBRE";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.Enter += new System.EventHandler(this.nombre_Enter);
            this.nombre.Leave += new System.EventHandler(this.nombre_Leave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(4, 523);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(412, 64);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "VIP";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(108, 209);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(203, 229);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            this.imagen.Click += new System.EventHandler(this.imagen_Click);
            // 
            // Carnet_Acceso_VIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1030, 749);
            this.Controls.Add(this.bimprimir);
            this.Controls.Add(this.panel1);
            this.Name = "Carnet_Acceso_VIP";
            this.Text = "Carnet_Acceso_VIP";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bimprimir;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.PictureBox imagen;
        public System.Windows.Forms.TextBox cedula;
        public System.Windows.Forms.TextBox nombre;
    }
}