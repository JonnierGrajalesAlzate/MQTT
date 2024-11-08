namespace PROCESO_CRUD.Vista
{
    partial class frmMenu
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
            this.bntCRUD = new System.Windows.Forms.Button();
            this.btnMQTTClient = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntCRUD
            // 
            this.bntCRUD.AutoSize = true;
            this.bntCRUD.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCRUD.Location = new System.Drawing.Point(106, 134);
            this.bntCRUD.Name = "bntCRUD";
            this.bntCRUD.Size = new System.Drawing.Size(75, 29);
            this.bntCRUD.TabIndex = 0;
            this.bntCRUD.Text = "CRUD";
            this.bntCRUD.UseVisualStyleBackColor = true;
            this.bntCRUD.Click += new System.EventHandler(this.bntCRUD_Click);
            // 
            // btnMQTTClient
            // 
            this.btnMQTTClient.AutoSize = true;
            this.btnMQTTClient.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMQTTClient.Location = new System.Drawing.Point(92, 65);
            this.btnMQTTClient.Name = "btnMQTTClient";
            this.btnMQTTClient.Size = new System.Drawing.Size(103, 29);
            this.btnMQTTClient.TabIndex = 1;
            this.btnMQTTClient.Text = "MQTT Cliente";
            this.btnMQTTClient.UseVisualStyleBackColor = true;
            this.btnMQTTClient.Click += new System.EventHandler(this.btnMQTTClient_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(106, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 343);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMQTTClient);
            this.Controls.Add(this.bntCRUD);
            this.Name = "frmMenu";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCRUD;
        private System.Windows.Forms.Button btnMQTTClient;
        private System.Windows.Forms.Button btnSalir;
    }
}