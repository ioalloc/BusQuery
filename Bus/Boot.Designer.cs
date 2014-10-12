namespace Bus
{
    partial class Boot
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
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_user = new System.Windows.Forms.Button();
            this.button_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_welcome.Location = new System.Drawing.Point(103, 40);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(102, 21);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "欢迎使用";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_user
            // 
            this.button_user.Location = new System.Drawing.Point(89, 89);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(131, 37);
            this.button_user.TabIndex = 1;
            this.button_user.Text = "普通用户入口";
            this.button_user.UseVisualStyleBackColor = true;
            // 
            // button_admin
            // 
            this.button_admin.Location = new System.Drawing.Point(89, 138);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(131, 37);
            this.button_admin.TabIndex = 2;
            this.button_admin.Text = "管理员入口";
            this.button_admin.UseVisualStyleBackColor = true;
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 226);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.button_user);
            this.Controls.Add(this.label_welcome);
            this.Name = "Boot";
            this.Text = "启动";
            this.Load += new System.EventHandler(this.Boot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Button button_admin;
    }
}