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
            this.txtTema = new System.Windows.Forms.TextBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.btnDataSend = new System.Windows.Forms.Button();
            this.txtDataSend = new System.Windows.Forms.TextBox();
            this.grbDataRecived = new System.Windows.Forms.GroupBox();
            this.lstDataReceived = new System.Windows.Forms.ListBox();
            this.gpbDataSend.SuspendLayout();
            this.grbDataRecived.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDataSend
            // 
            this.gpbDataSend.Controls.Add(this.txtTema);
            this.gpbDataSend.Controls.Add(this.lblTema);
            this.gpbDataSend.Controls.Add(this.btnDataSend);
            this.gpbDataSend.Controls.Add(this.txtDataSend);
            this.gpbDataSend.Location = new System.Drawing.Point(11, 301);
            this.gpbDataSend.Margin = new System.Windows.Forms.Padding(2);
            this.gpbDataSend.Name = "gpbDataSend";
            this.gpbDataSend.Padding = new System.Windows.Forms.Padding(2);
            this.gpbDataSend.Size = new System.Drawing.Size(582, 75);
            this.gpbDataSend.TabIndex = 3;
            this.gpbDataSend.TabStop = false;
            this.gpbDataSend.Text = "Data Send";
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(9, 34);
            this.txtTema.Multiline = true;
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(100, 32);
            this.txtTema.TabIndex = 3;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(6, 15);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(34, 13);
            this.lblTema.TabIndex = 2;
            this.lblTema.Text = "Tema";
            // 
            // btnDataSend
            // 
            this.btnDataSend.Location = new System.Drawing.Point(509, 34);
            this.btnDataSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnDataSend.Name = "btnDataSend";
            this.btnDataSend.Size = new System.Drawing.Size(56, 31);
            this.btnDataSend.TabIndex = 1;
            this.btnDataSend.Text = "Send";
            this.btnDataSend.UseVisualStyleBackColor = true;
            this.btnDataSend.Click += new System.EventHandler(this.btnDataSend_Click);
            // 
            // txtDataSend
            // 
            this.txtDataSend.Location = new System.Drawing.Point(146, 34);
            this.txtDataSend.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataSend.Multiline = true;
            this.txtDataSend.Name = "txtDataSend";
            this.txtDataSend.Size = new System.Drawing.Size(342, 32);
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
            this.grbDataRecived.Text = "Data Received";
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
            // frmMQTTCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 390);
            this.Controls.Add(this.gpbDataSend);
            this.Controls.Add(this.grbDataRecived);
            this.Name = "frmMQTTCliente";
            this.Text = "MQTT Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMQTTCliente_FormClosing_1);
            this.Load += new System.EventHandler(this.frmMQTTCliente_Load_1);
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
    }
}