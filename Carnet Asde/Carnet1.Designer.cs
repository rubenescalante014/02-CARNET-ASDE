
namespace CARNET_ASDE
{
    partial class Carnet1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet1));
            this.bimprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcodigo = new CARNET_ASDE.VerticalLabel();
            this.verticalLabel4 = new CARNET_ASDE.VerticalLabel();
            this.nombre = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.TextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.departamento = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.bimprimir.Location = new System.Drawing.Point(899, 12);
            this.bimprimir.Name = "bimprimir";
            this.bimprimir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bimprimir.Size = new System.Drawing.Size(119, 30);
            this.bimprimir.TabIndex = 111;
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
            this.panel1.Controls.Add(this.tcodigo);
            this.panel1.Controls.Add(this.verticalLabel4);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.cargo);
            this.panel1.Controls.Add(this.imagen);
            this.panel1.Controls.Add(this.departamento);
            this.panel1.Controls.Add(this.cedula);
            this.panel1.Location = new System.Drawing.Point(299, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 674);
            this.panel1.TabIndex = 110;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tcodigo
            // 
            this.tcodigo.BackColor = System.Drawing.Color.Transparent;
            this.tcodigo.Flip180 = true;
            this.tcodigo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcodigo.ForeColor = System.Drawing.Color.White;
            this.tcodigo.Location = new System.Drawing.Point(45, 192);
            this.tcodigo.Name = "tcodigo";
            this.tcodigo.Size = new System.Drawing.Size(28, 83);
            this.tcodigo.TabIndex = 16;
            this.tcodigo.Text = "15051";
            this.tcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // verticalLabel4
            // 
            this.verticalLabel4.BackColor = System.Drawing.Color.Transparent;
            this.verticalLabel4.Flip180 = true;
            this.verticalLabel4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalLabel4.ForeColor = System.Drawing.Color.White;
            this.verticalLabel4.Location = new System.Drawing.Point(43, 270);
            this.verticalLabel4.Name = "verticalLabel4";
            this.verticalLabel4.Size = new System.Drawing.Size(30, 56);
            this.verticalLabel4.TabIndex = 20;
            this.verticalLabel4.Text = "COD.";
            this.verticalLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.verticalLabel4.Click += new System.EventHandler(this.verticalLabel4_Click);
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre.Font = new System.Drawing.Font("Roboto", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(8, 458);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(398, 44);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "RUBEN ESCALANTE C.";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // cargo
            // 
            this.cargo.BackColor = System.Drawing.Color.White;
            this.cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cargo.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(8, 504);
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Size = new System.Drawing.Size(398, 27);
            this.cargo.TabIndex = 10;
            this.cargo.Text = "ANALISTA DE SISTEMA";
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
            this.imagen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagen_MouseUp);
            // 
            // departamento
            // 
            this.departamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.departamento.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamento.Location = new System.Drawing.Point(8, 527);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(398, 27);
            this.departamento.TabIndex = 11;
            this.departamento.Text = "DIRECCION DE TECNOLOGIA";
            this.departamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cedula
            // 
            this.cedula.BackColor = System.Drawing.Color.White;
            this.cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedula.Font = new System.Drawing.Font("Roboto", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.Location = new System.Drawing.Point(8, 551);
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Size = new System.Drawing.Size(398, 31);
            this.cedula.TabIndex = 12;
            this.cedula.Text = "40226331243";
            this.cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cedula.TextChanged += new System.EventHandler(this.cedula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "COD.";
            this.label2.Visible = false;
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
            this.button1.TabIndex = 114;
            this.button1.Text = "Ajustar Nombre";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(899, 84);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(119, 30);
            this.button2.TabIndex = 115;
            this.button2.Text = "Ajustar Imagen";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Carnet1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1030, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bimprimir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carnet1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnet";
            this.Load += new System.EventHandler(this.Carnet1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bimprimir;
        private System.Windows.Forms.Panel panel1;
        private VerticalLabel tcodigo;
        public System.Windows.Forms.TextBox cedula;
        public System.Windows.Forms.TextBox departamento;
        public System.Windows.Forms.TextBox cargo;
        public System.Windows.Forms.TextBox nombre;
        public System.Windows.Forms.PictureBox imagen;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private VerticalLabel verticalLabel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}