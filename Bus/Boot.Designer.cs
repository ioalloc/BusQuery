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
            this.label_welcome.Location = new System.Drawing.Point(90, 39);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(102, 21);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "欢迎使用";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_user
            // 
            this.button_user.Location = new System.Drawing.Point(85, 92);
            this.button_user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(118, 36);
            this.button_user.TabIndex = 1;
            this.button_user.Text = "普通用户入口";
            this.button_user.UseVisualStyleBackColor = true;
            this.button_user.Click += new System.EventHandler(this.User_Acess);
            // 
            // button_admin
            // 
            this.button_admin.Location = new System.Drawing.Point(85, 136);
            this.button_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(118, 36);
            this.button_admin.TabIndex = 2;
            this.button_admin.Text = "管理员入口";
            this.button_admin.UseVisualStyleBackColor = true;
            this.button_admin.Click += new System.EventHandler(this.Admin_Acess);
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 205);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.button_user);
            this.Controls.Add(this.label_welcome);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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