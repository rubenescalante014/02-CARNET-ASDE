
namespace CARNET_ASDE
{
    partial class Carnet_Honorifico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet_Honorifico));
            this.button1 = new System.Windows.Forms.Button();
            this.bimprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nombre = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.TextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.departamento = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(899, 48);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 116;
            this.button1.Text = "Ajustar Nombre";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.bimprimir.Location = new System.Drawing.Point(899, 12);
            this.bimprimir.Name = "bimprimir";
            this.bimprimir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bimprimir.Size = new System.Drawing.Size(119, 30);
            this.bimprimir.TabIndex = 115;
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
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.cargo);
            this.panel1.Controls.Add(this.imagen);
            this.panel1.Controls.Add(this.departamento);
            this.panel1.Controls.Add(this.cedula);
            this.panel1.Location = new System.Drawing.Point(299, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 674);
            this.panel1.TabIndex = 117;
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(8, 458);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(398, 38);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "#NOMBRE";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            this.nombre.Enter += new System.EventHandler(this.nombre_Enter);
            this.nombre.Leave += new System.EventHandler(this.nombre_Leave);
            // 
            // cargo
            // 
            this.cargo.BackColor = System.Drawing.Color.White;
            this.cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(8, 504);
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Size = new System.Drawing.Size(398, 23);
            this.cargo.TabIndex = 10;
            this.cargo.Text = "HONORIFICO(A)";
            this.cargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // departamento
            // 
            this.departamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamento.Location = new System.Drawing.Point(8, 527);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(398, 23);
            this.departamento.TabIndex = 11;
            this.departamento.Text = "#DIRECCION";
            this.departamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.departamento.Enter += new System.EventHandler(this.departamento_Enter);
            this.departamento.Leave += new System.EventHandler(this.departamento_Leave);
            // 
            // cedula
            // 
            this.cedula.BackColor = System.Drawing.Color.White;
            this.cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.Location = new System.Drawing.Point(8, 551);
            this.cedula.MaxLength = 11;
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(398, 27);
            this.cedula.TabIndex = 12;
            this.cedula.Text = "#CEDULA";
            this.cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cedula.Enter += new System.EventHandler(this.cedula_Enter);
            this.cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedula_KeyPress);
            this.cedula.Leave += new System.EventHandler(this.cedula_Leave);
            // 
            // Carnet_Honorifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1030, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bimprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carnet_Honorifico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Carnet_Honorifico";
            this.Load += new System.EventHandler(this.Carnet_Honorifico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bimprimir;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox nombre;
        public System.Windows.Forms.TextBox cargo;
        public System.Windows.Forms.PictureBox imagen;
        public System.Windows.Forms.TextBox departamento;
        public System.Windows.Forms.TextBox cedula;
    }
}