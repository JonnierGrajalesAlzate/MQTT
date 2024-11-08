namespace PROCESO_CRUD.Vista
{
    partial class frmMQTTCliente
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
            this.gpbDataSend = new System.Windows.Forms.GroupBox();
            this.btnDataSend = new System.Windows.Forms.Button();
            this.txtDataSend = new System.Windows.Forms.TextBox();
            this.grbDataRecived = new System.Windows.Forms.GroupBox();
            this.lstDataReceived = new System.Windows.Forms.ListBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.gpbDataSend.SuspendLayout();
            this.grbDataRecived.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDataSend
            // 
            this.gpbDataSend.Controls.Add(this.lblTema);
            this.gpbDataSend.Controls.Add(this.lblClienteID);
            this.gpbDataSend.Controls.Add(this.txtClienteID);
            this.gpbDataSend.Controls.Add(this.txtTema);
            this.gpbDataSend.Controls.Add(this.btnDataSend);
            this.gpbDataSend.Controls.Add(this.txtDataSend);
            this.gpbDataSend.Location = new System.Drawing.Point(11, 301);
            this.gpbDataSend.Margin = new System.Windows.Forms.Padding(2);
            this.gpbDataSend.Name = "gpbDataSend";
            this.gpbDataSend.Padding = new System.Windows.Forms.Padding(2);
            this.gpbDataSend.Size = new System.Drawing.Size(582, 92);
            this.gpbDataSend.TabIndex = 3;
            this.gpbDataSend.TabStop = false;
            this.gpbDataSend.Text = "Datos Enviados";
            // 
            // btnDataSend
            // 
            this.btnDataSend.Location = new System.Drawing.Point(518, 53);
            this.btnDataSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnDataSend.Name = "btnDataSend";
            this.btnDataSend.Size = new System.Drawing.Size(56, 31);
            this.btnDataSend.TabIndex = 1;
            this.btnDataSend.Text = "Enviar";
            this.btnDataSend.UseVisualStyleBackColor = true;
            this.btnDataSend.Click += new System.EventHandler(this.btnDataSend_Click);
            // 
            // txtDataSend
            // 
            this.txtDataSend.Location = new System.Drawing.Point(257, 17);
            this.txtDataSend.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataSend.Multiline = true;
            this.txtDataSend.Name = "txtDataSend";
            this.txtDataSend.Size = new System.Drawing.Size(317, 32);
            this.txtDataSend.TabIndex = 0;
            // 
            // grbDataRecived
            // 
            this.grbDataRecived.Controls.Add(this.lstDataReceived);
            this.grbDataRecived.Location = new System.Drawing.Point(11, 11);
            this.grbDataRecived.Margin = new System.Windows.Forms.Padding(2);
            this.grbDataRecived.Name = "grbDataRecived";
            this.grbDataRecived.Padding = new System.Windows.Forms.Padding(2);
            this.grbDataRecived.Size = new System.Drawing.Size(582, 288);
            this.grbDataRecived.TabIndex = 2;
            this.grbDataRecived.TabStop = false;
            this.grbDataRecived.Text = "Datos Recibidos";
            // 
            // lstDataReceived
            // 
            this.lstDataReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataReceived.FormattingEnabled = true;
            this.lstDataReceived.Location = new System.Drawing.Point(2, 15);
            this.lstDataReceived.Margin = new System.Windows.Forms.Padding(2);
            this.lstDataReceived.Name = "lstDataReceived";
            this.lstDataReceived.Size = new System.Drawing.Size(578, 271);
            this.lstDataReceived.TabIndex = 0;
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(133, 42);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(100, 20);
            this.txtTema.TabIndex = 4;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(11, 42);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(100, 20);
            this.txtClienteID.TabIndex = 5;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(11, 18);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(50, 13);
            this.lblClienteID.TabIndex = 6;
            this.lblClienteID.Text = "ClienteID";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(130, 19);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(34, 13);
            this.lblTema.TabIndex = 7;
            this.lblTema.Text = "Tema";
            // 
            // frmMQTTCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 401);
            this.Controls.Add(this.gpbDataSend);
            this.Controls.Add(this.grbDataRecived);
            this.Name = "frmMQTTCliente";
            this.Text = "Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMQTTCliente_FormClosing);
            this.Load += new System.EventHandler(this.frmMQTTCliente_Load);
            this.gpbDataSend.ResumeLayout(false);
            this.gpbDataSend.PerformLayout();
            this.grbDataRecived.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDataSend;
        private System.Windows.Forms.Button btnDataSend;
        private System.Windows.Forms.TextBox txtDataSend;
        private System.Windows.Forms.GroupBox grbDataRecived;
        private System.Windows.Forms.ListBox lstDataReceived;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.TextBox txtClienteID;
    }
}