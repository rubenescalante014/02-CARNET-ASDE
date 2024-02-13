
namespace CARNET_ASDE
{
    partial class ListadoEmpleados
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEmpleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.tbusquedanombre = new System.Windows.Forms.TextBox();
            this.tbusquedacodigo = new System.Windows.Forms.TextBox();
            this.bnuevo = new System.Windows.Forms.Button();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.bbuscar = new System.Windows.Forms.Button();
            this.bllave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Empleados";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(0, 176);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv.RowTemplate.Height = 25;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1199, 511);
            this.dtgv.TabIndex = 104;
            this.dtgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellDoubleClick);
            this.dtgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_CellMouseClick);
            // 
            // tbusquedanombre
            // 
            this.tbusquedanombre.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusquedanombre.ForeColor = System.Drawing.Color.DimGray;
            this.tbusquedanombre.Location = new System.Drawing.Point(164, 141);
            this.tbusquedanombre.Name = "tbusquedanombre";
            this.tbusquedanombre.Size = new System.Drawing.Size(220, 29);
            this.tbusquedanombre.TabIndex = 107;
            this.tbusquedanombre.Text = "Buscar por nombre";
            this.tbusquedanombre.Enter += new System.EventHandler(this.tbusquedanombre_Enter);
            this.tbusquedanombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbusquedanombre_KeyUp);
            this.tbusquedanombre.Leave += new System.EventHandler(this.tbusquedanombre_Leave);
            // 
            // tbusquedacodigo
            // 
            this.tbusquedacodigo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusquedacodigo.ForeColor = System.Drawing.Color.DimGray;
            this.tbusquedacodigo.Location = new System.Drawing.Point(12, 141);
            this.tbusquedacodigo.Name = "tbusquedacodigo";
            this.tbusquedacodigo.Size = new System.Drawing.Size(146, 29);
            this.tbusquedacodigo.TabIndex = 106;
            this.tbusquedacodigo.Text = "Buscar por codigo";
            this.tbusquedacodigo.Enter += new System.EventHandler(this.tbusquedacodigo_Enter);
            this.tbusquedacodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbusquedacodigo_KeyPress);
            this.tbusquedacodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbusquedacodigo_KeyUp);
            this.tbusquedacodigo.Leave += new System.EventHandler(this.tbusquedacodigo_Leave);
            // 
            // bnuevo
            // 
            this.bnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnuevo.BackColor = System.Drawing.Color.White;
            this.bnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnuevo.FlatAppearance.BorderSize = 0;
            this.bnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.ForeColor = System.Drawing.Color.Black;
            this.bnuevo.Image = ((System.Drawing.Image)(resources.GetObject("bnuevo.Image")));
            this.bnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnuevo.Location = new System.Drawing.Point(1036, 139);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bnuevo.Size = new System.Drawing.Size(154, 30);
            this.bnuevo.TabIndex = 108;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnuevo.UseVisualStyleBackColor = false;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdepartamento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbdepartamento.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdepartamento.ForeColor = System.Drawing.Color.DimGray;
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(390, 141);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(566, 29);
            this.cbdepartamento.TabIndex = 215;
            // 
            // bbuscar
            // 
            this.bbuscar.BackColor = System.Drawing.Color.White;
            this.bbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbuscar.FlatAppearance.BorderSize = 0;
            this.bbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscar.ForeColor = System.Drawing.Color.Black;
            this.bbuscar.Image = ((System.Drawing.Image)(resources.GetObject("bbuscar.Image")));
            this.bbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bbuscar.Location = new System.Drawing.Point(962, 139);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bbuscar.Size = new System.Drawing.Size(51, 30);
            this.bbuscar.TabIndex = 216;
            this.bbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bbuscar.UseVisualStyleBackColor = false;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // bllave
            // 
            this.bllave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bllave.BackColor = System.Drawing.Color.White;
            this.bllave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bllave.FlatAppearance.BorderSize = 0;
            this.bllave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bllave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bllave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bllave.ForeColor = System.Drawing.Color.Black;
            this.bllave.Image = ((System.Drawing.Image)(resources.GetObject("bllave.Image")));
            this.bllave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bllave.Location = new System.Drawing.Point(1036, 107);
            this.bllave.Name = "bllave";
            this.bllave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bllave.Size = new System.Drawing.Size(154, 30);
            this.bllave.TabIndex = 217;
            this.bllave.Text = "Llave";
            this.bllave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bllave.UseVisualStyleBackColor = false;
            this.bllave.Visible = false;
            this.bllave.Click += new System.EventHandler(this.bllave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.llaveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editarToolStripMenuItem.Text = "Editar Datos";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // llaveToolStripMenuItem
            // 
            this.llaveToolStripMenuItem.Name = "llaveToolStripMenuItem";
            this.llaveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.llaveToolStripMenuItem.Text = "Asignar llave";
            this.llaveToolStripMenuItem.Click += new System.EventHandler(this.llaveToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1036, 74);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(154, 30);
            this.button1.TabIndex = 218;
            this.button1.Text = "Honorifico(a)";
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
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1036, 38);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(154, 30);
            this.button2.TabIndex = 219;
            this.button2.Text = "Acceso VIP";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListadoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1199, 699);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bllave);
            this.Controls.Add(this.bbuscar);
            this.Controls.Add(this.cbdepartamento);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.tbusquedanombre);
            this.Controls.Add(this.tbusquedacodigo);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListadoEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoEmpleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListadoEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.ListadoEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbusquedanombre;
        private System.Windows.Forms.TextBox tbusquedacodigo;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.Button bbuscar;
        private System.Windows.Forms.Button bllave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem llaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}