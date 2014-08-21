namespace CodeWarehoseCrack
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.cb_version = new System.Windows.Forms.ComboBox();
            this.registrationCode = new System.Windows.Forms.Label();
            this.tb_regCode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(97, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.version.Location = new System.Drawing.Point(47, 28);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(108, 15);
            this.version.TabIndex = 1;
            this.version.Text = "Code Warehouse";
            // 
            // cb_version
            // 
            this.cb_version.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_version.FormattingEnabled = true;
            this.cb_version.Items.AddRange(new object[] {
            "2.9"});
            this.cb_version.Location = new System.Drawing.Point(168, 27);
            this.cb_version.Name = "cb_version";
            this.cb_version.Size = new System.Drawing.Size(121, 23);
            this.cb_version.TabIndex = 2;
            // 
            // registrationCode
            // 
            this.registrationCode.AutoSize = true;
            this.registrationCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.registrationCode.Location = new System.Drawing.Point(50, 77);
            this.registrationCode.Name = "registrationCode";
            this.registrationCode.Size = new System.Drawing.Size(112, 15);
            this.registrationCode.TabIndex = 1;
            this.registrationCode.Text = "Registration Code";
            // 
            // tb_regCode
            // 
            this.tb_regCode.Location = new System.Drawing.Point(168, 76);
            this.tb_regCode.Name = "tb_regCode";
            this.tb_regCode.ReadOnly = true;
            this.tb_regCode.Size = new System.Drawing.Size(247, 21);
            this.tb_regCode.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(299, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 185);
            this.Controls.Add(this.tb_regCode);
            this.Controls.Add(this.cb_version);
            this.Controls.Add(this.registrationCode);
            this.Controls.Add(this.version);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Code Warehose Crack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.ComboBox cb_version;
        private System.Windows.Forms.Label registrationCode;
        private System.Windows.Forms.TextBox tb_regCode;
        private System.Windows.Forms.Button button2;
    }
}

