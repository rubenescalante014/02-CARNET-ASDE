
namespace CARNET_ASDE
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorpass = new System.Windows.Forms.PictureBox();
            this.erroruser = new System.Windows.Forms.PictureBox();
            this.blogin = new System.Windows.Forms.Button();
            this.tpass = new System.Windows.Forms.TextBox();
            this.tuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroruser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.errorpass);
            this.panel1.Controls.Add(this.erroruser);
            this.panel1.Controls.Add(this.blogin);
            this.panel1.Controls.Add(this.tpass);
            this.panel1.Controls.Add(this.tuser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(245, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 174);
            this.panel1.TabIndex = 0;
            // 
            // errorpass
            // 
            this.errorpass.Image = ((System.Drawing.Image)(resources.GetObject("errorpass.Image")));
            this.errorpass.Location = new System.Drawing.Point(278, 92);
            this.errorpass.Name = "errorpass";
            this.errorpass.Size = new System.Drawing.Size(16, 16);
            this.errorpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.errorpass.TabIndex = 97;
            this.errorpass.TabStop = false;
            this.errorpass.Visible = false;
            // 
            // erroruser
            // 
            this.erroruser.Image = ((System.Drawing.Image)(resources.GetObject("erroruser.Image")));
            this.erroruser.Location = new System.Drawing.Point(278, 58);
            this.erroruser.Name = "erroruser";
            this.erroruser.Size = new System.Drawing.Size(16, 16);
            this.erroruser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.erroruser.TabIndex = 96;
            this.erroruser.TabStop = false;
            this.erroruser.Visible = false;
            this.erroruser.Click += new System.EventHandler(this.erroruser_Click);
            // 
            // blogin
            // 
            this.blogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(168)))), ((int)(((byte)(194)))));
            this.blogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blogin.ForeColor = System.Drawing.Color.White;
            this.blogin.Location = new System.Drawing.Point(78, 130);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(161, 38);
            this.blogin.TabIndex = 95;
            this.blogin.Text = "Login ";
            this.blogin.UseVisualStyleBackColor = false;
            this.blogin.Click += new System.EventHandler(this.blogin_Click);
            // 
            // tpass
            // 
            this.tpass.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpass.ForeColor = System.Drawing.Color.DimGray;
            this.tpass.Location = new System.Drawing.Point(20, 86);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(280, 29);
            this.tpass.TabIndex = 94;
            this.tpass.Text = "Contraseña";
            this.tpass.Enter += new System.EventHandler(this.tpass_Enter);
            this.tpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tpass_KeyPress);
            this.tpass.Leave += new System.EventHandler(this.tpass_Leave);
            // 
            // tuser
            // 
            this.tuser.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuser.ForeColor = System.Drawing.Color.DimGray;
            this.tuser.Location = new System.Drawing.Point(20, 51);
            this.tuser.Name = "tuser";
            this.tuser.Size = new System.Drawing.Size(280, 29);
            this.tuser.TabIndex = 93;
            this.tuser.Text = "Usuario";
            this.tuser.Enter += new System.EventHandler(this.tuser_Enter);
            this.tuser.Leave += new System.EventHandler(this.tuser_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log-in";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(281, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "Ayuntamiento Santo Domingo Este";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(33)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroruser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button blogin;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.TextBox tuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox erroruser;
        private System.Windows.Forms.PictureBox errorpass;
        private System.Windows.Forms.Label label2;
    }
}