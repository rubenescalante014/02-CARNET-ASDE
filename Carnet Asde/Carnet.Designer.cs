
namespace CARNET_ASDE
{
    partial class Carnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.verticalLabel2 = new CARNET_ASDE.VerticalLabel();
            this.cedula = new System.Windows.Forms.TextBox();
            this.departamento = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.bimprimir = new System.Windows.Forms.Button();
            this.verticalLabel1 = new CARNET_ASDE.VerticalLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.verticalLabel1);
            this.panel1.Controls.Add(this.verticalLabel2);
            this.panel1.Controls.Add(this.cedula);
            this.panel1.Controls.Add(this.departamento);
            this.panel1.Controls.Add(this.cargo);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.imagen);
            this.panel1.Location = new System.Drawing.Point(179, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 326);
            this.panel1.TabIndex = 2;
            // 
            // verticalLabel2
            // 
            this.verticalLabel2.BackColor = System.Drawing.Color.Transparent;
            this.verticalLabel2.Flip180 = true;
            this.verticalLabel2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalLabel2.ForeColor = System.Drawing.Color.White;
            this.verticalLabel2.Location = new System.Drawing.Point(14, 133);
            this.verticalLabel2.Name = "verticalLabel2";
            this.verticalLabel2.Size = new System.Drawing.Size(21, 32);
            this.verticalLabel2.TabIndex = 15;
            this.verticalLabel2.Text = "CÓD.";
            // 
            // cedula
            // 
            this.cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedula.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.Location = new System.Drawing.Point(8, 268);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(186, 16);
            this.cedula.TabIndex = 12;
            this.cedula.Text = "40226331243";
            this.cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // departamento
            // 
            this.departamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departamento.Font = new System.Drawing.Font("Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamento.Location = new System.Drawing.Point(8, 257);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(186, 12);
            this.departamento.TabIndex = 11;
            this.departamento.Text = "DIRECCION DE TECNOLOGIA";
            this.departamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cargo
            // 
            this.cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargo.Font = new System.Drawing.Font("Roboto", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(8, 244);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(186, 12);
            this.cargo.TabIndex = 10;
            this.cargo.Text = "ANALISTA DE SISTEMAS";
            this.cargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(7, 221);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(189, 22);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "JENNCY V. BONIFACIO L.";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imagen
            // 
            this.imagen.Image = ((System.Drawing.Image)(resources.GetObject("imagen.Image")));
            this.imagen.Location = new System.Drawing.Point(52, 101);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(101, 114);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            this.imagen.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.bimprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimprimir.ForeColor = System.Drawing.Color.Black;
            this.bimprimir.Image = ((System.Drawing.Image)(resources.GetObject("bimprimir.Image")));
            this.bimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bimprimir.Location = new System.Drawing.Point(231, 376);
            this.bimprimir.Name = "bimprimir";
            this.bimprimir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bimprimir.Size = new System.Drawing.Size(119, 30);
            this.bimprimir.TabIndex = 109;
            this.bimprimir.Text = "Guardar";
            this.bimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bimprimir.UseVisualStyleBackColor = false;
            this.bimprimir.Click += new System.EventHandler(this.bimprimir_Click_1);
            // 
            // verticalLabel1
            // 
            this.verticalLabel1.BackColor = System.Drawing.Color.Transparent;
            this.verticalLabel1.Flip180 = true;
            this.verticalLabel1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalLabel1.ForeColor = System.Drawing.Color.White;
            this.verticalLabel1.Location = new System.Drawing.Point(14, 80);
            this.verticalLabel1.Name = "verticalLabel1";
            this.verticalLabel1.Size = new System.Drawing.Size(21, 53);
            this.verticalLabel1.TabIndex = 16;
            this.verticalLabel1.Text = "CÓD.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Carnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(553, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bimprimir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carnet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnet";
            this.Load += new System.EventHandler(this.Carnet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private VerticalLabel verticalLabel2;
        public System.Windows.Forms.PictureBox imagen;
        public System.Windows.Forms.TextBox nombre;
        public System.Windows.Forms.TextBox cedula;
        public System.Windows.Forms.TextBox departamento;
        public System.Windows.Forms.TextBox cargo;
        private System.Windows.Forms.Button bimprimir;
        private VerticalLabel verticalLabel1;
        public System.Windows.Forms.Label label1;
        //    public VerticalLabel tcodigo;
    }
}