namespace PROCESO_CRUD.Vista
{
    partial class frmCRUD
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
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvMensajes = new System.Windows.Forms.DataGridView();
            this.gbContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(13, 41);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(16, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Id";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(253, 41);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(47, 13);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Mensaje";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(16, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(255, 57);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(280, 20);
            this.txtMensaje.TabIndex = 4;
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.label2);
            this.gbContenedor.Controls.Add(this.label1);
            this.gbContenedor.Controls.Add(this.txtTema);
            this.gbContenedor.Controls.Add(this.txtClienteID);
            this.gbContenedor.Controls.Add(this.btnEliminar);
            this.gbContenedor.Controls.Add(this.btnActualizar);
            this.gbContenedor.Controls.Add(this.btnGuardar);
            this.gbContenedor.Controls.Add(this.txtId);
            this.gbContenedor.Controls.Add(this.lblCedula);
            this.gbContenedor.Controls.Add(this.txtMensaje);
            this.gbContenedor.Controls.Add(this.lblMensaje);
            this.gbContenedor.Location = new System.Drawing.Point(12, 12);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(542, 129);
            this.gbContenedor.TabIndex = 6;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "Informacion Mensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ClienteID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tema";
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(159, 57);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(84, 20);
            this.txtTema.TabIndex = 10;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(63, 57);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(84, 20);
            this.txtClienteID.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(201, 95);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(110, 95);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(16, 95);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvMensajes
            // 
            this.dgvMensajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMensajes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMensajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensajes.GridColor = System.Drawing.Color.LightGray;
            this.dgvMensajes.Location = new System.Drawing.Point(12, 147);
            this.dgvMensajes.Name = "dgvMensajes";
            this.dgvMensajes.Size = new System.Drawing.Size(542, 176);
            this.dgvMensajes.TabIndex = 7;
            // 
            // frmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 334);
            this.Controls.Add(this.dgvMensajes);
            this.Controls.Add(this.gbContenedor);
            this.Name = "frmCRUD";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCRUD_FormClosing);
            this.Load += new System.EventHandler(this.fmr_Panel_Load);
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvMensajes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TextBox txtClienteID;
    }
}

