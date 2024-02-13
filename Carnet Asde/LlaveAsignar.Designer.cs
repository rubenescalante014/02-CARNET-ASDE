
namespace CARNET_ASDE
{
    partial class LlaveAsignar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LlaveAsignar));
            this.codigollave = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bimprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codigollave
            // 
            this.codigollave.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigollave.ForeColor = System.Drawing.Color.Black;
            this.codigollave.Location = new System.Drawing.Point(119, 76);
            this.codigollave.MaxLength = 10;
            this.codigollave.Name = "codigollave";
            this.codigollave.Size = new System.Drawing.Size(420, 33);
            this.codigollave.TabIndex = 108;
            this.codigollave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigollave_KeyPress);
            // 
            // cedula
            // 
            this.cedula.BackColor = System.Drawing.Color.White;
            this.cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedula.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.Location = new System.Drawing.Point(119, 45);
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Size = new System.Drawing.Size(420, 26);
            this.cedula.TabIndex = 109;
            this.cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.White;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(119, 10);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(420, 26);
            this.nombre.TabIndex = 110;
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 111;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 112;
            this.label2.Text = "Cedula:";
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
            this.bimprimir.Location = new System.Drawing.Point(223, 114);
            this.bimprimir.Name = "bimprimir";
            this.bimprimir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bimprimir.Size = new System.Drawing.Size(119, 30);
            this.bimprimir.TabIndex = 113;
            this.bimprimir.Text = "Guardar";
            this.bimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bimprimir.UseVisualStyleBackColor = false;
            this.bimprimir.Click += new System.EventHandler(this.bimprimir_Click);
            // 
            // LlaveAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 152);
            this.Controls.Add(this.bimprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.codigollave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LlaveAsignar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Llave Magnetica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigollave;
        public System.Windows.Forms.TextBox cedula;
        public System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bimprimir;
    }
}