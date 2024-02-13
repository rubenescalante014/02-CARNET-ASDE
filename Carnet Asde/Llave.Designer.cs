
namespace CARNET_ASDE
{
    partial class Llave
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Llave));
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.tbusquedanombre = new System.Windows.Forms.TextBox();
            this.tbusquedacodigo = new System.Windows.Forms.TextBox();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.bbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(1, 92);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgv.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dtgv.RowTemplate.Height = 25;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(954, 407);
            this.dtgv.TabIndex = 105;
            // 
            // tbusquedanombre
            // 
            this.tbusquedanombre.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusquedanombre.ForeColor = System.Drawing.Color.DimGray;
            this.tbusquedanombre.Location = new System.Drawing.Point(128, 12);
            this.tbusquedanombre.Name = "tbusquedanombre";
            this.tbusquedanombre.Size = new System.Drawing.Size(220, 29);
            this.tbusquedanombre.TabIndex = 109;
            this.tbusquedanombre.Text = "Buscar por nombre";
            this.tbusquedanombre.Enter += new System.EventHandler(this.tbusquedanombre_Enter);
            this.tbusquedanombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbusquedanombre_KeyUp);
            this.tbusquedanombre.Leave += new System.EventHandler(this.tbusquedanombre_Leave);
            this.tbusquedanombre.Validated += new System.EventHandler(this.tbusquedanombre_Validated);
            // 
            // tbusquedacodigo
            // 
            this.tbusquedacodigo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusquedacodigo.ForeColor = System.Drawing.Color.DimGray;
            this.tbusquedacodigo.Location = new System.Drawing.Point(12, 12);
            this.tbusquedacodigo.Name = "tbusquedacodigo";
            this.tbusquedacodigo.Size = new System.Drawing.Size(110, 29);
            this.tbusquedacodigo.TabIndex = 108;
            this.tbusquedacodigo.Text = "Buscar por codigo";
            this.tbusquedacodigo.Enter += new System.EventHandler(this.tbusquedacodigo_Enter);
            this.tbusquedacodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbusquedacodigo_KeyUp);
            this.tbusquedacodigo.Leave += new System.EventHandler(this.tbusquedacodigo_Leave);
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdepartamento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbdepartamento.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdepartamento.ForeColor = System.Drawing.Color.DimGray;
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(354, 12);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(496, 29);
            this.cbdepartamento.TabIndex = 216;
            // 
            // bbuscar
            // 
            this.bbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bbuscar.BackColor = System.Drawing.Color.White;
            this.bbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbuscar.FlatAppearance.BorderSize = 0;
            this.bbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bbuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscar.ForeColor = System.Drawing.Color.Black;
            this.bbuscar.Image = ((System.Drawing.Image)(resources.GetObject("bbuscar.Image")));
            this.bbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbuscar.Location = new System.Drawing.Point(892, 12);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bbuscar.Size = new System.Drawing.Size(48, 30);
            this.bbuscar.TabIndex = 217;
            this.bbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bbuscar.UseVisualStyleBackColor = false;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // Llave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 500);
            this.Controls.Add(this.bbuscar);
            this.Controls.Add(this.cbdepartamento);
            this.Controls.Add(this.tbusquedanombre);
            this.Controls.Add(this.tbusquedacodigo);
            this.Controls.Add(this.dtgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Llave";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llaves de Acceso";
            this.Load += new System.EventHandler(this.Llave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox tbusquedanombre;
        private System.Windows.Forms.TextBox tbusquedacodigo;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.Button bbuscar;
    }
}