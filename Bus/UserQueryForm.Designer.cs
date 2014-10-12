namespace Bus
{
    partial class UserQueryForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_query_way = new System.Windows.Forms.TabControl();
            this.tabPage_station2station = new System.Windows.Forms.TabPage();
            this.tabPage_line = new System.Windows.Forms.TabPage();
            this.tabPage_station = new System.Windows.Forms.TabPage();
            this.tabControl_query_way.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_query_way
            // 
            this.tabControl_query_way.Controls.Add(this.tabPage_station2station);
            this.tabControl_query_way.Controls.Add(this.tabPage_line);
            this.tabControl_query_way.Controls.Add(this.tabPage_station);
            this.tabControl_query_way.Location = new System.Drawing.Point(12, 21);
            this.tabControl_query_way.Name = "tabControl_query_way";
            this.tabControl_query_way.SelectedIndex = 0;
            this.tabControl_query_way.Size = new System.Drawing.Size(447, 278);
            this.tabControl_query_way.TabIndex = 0;
            this.tabControl_query_way.Tag = "";
            // 
            // tabPage_station2station
            // 
            this.tabPage_station2station.Location = new System.Drawing.Point(4, 22);
            this.tabPage_station2station.Name = "tabPage_station2station";
            this.tabPage_station2station.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_station2station.Size = new System.Drawing.Size(439, 252);
            this.tabPage_station2station.TabIndex = 0;
            this.tabPage_station2station.Text = "换乘查询";
            this.tabPage_station2station.UseVisualStyleBackColor = true;
            // 
            // tabPage_line
            // 
            this.tabPage_line.Location = new System.Drawing.Point(4, 22);
            this.tabPage_line.Name = "tabPage_line";
            this.tabPage_line.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_line.Size = new System.Drawing.Size(439, 252);
            this.tabPage_line.TabIndex = 1;
            this.tabPage_line.Text = "路线查询";
            this.tabPage_line.UseVisualStyleBackColor = true;
            // 
            // tabPage_station
            // 
            this.tabPage_station.Location = new System.Drawing.Point(4, 22);
            this.tabPage_station.Name = "tabPage_station";
            this.tabPage_station.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_station.Size = new System.Drawing.Size(439, 252);
            this.tabPage_station.TabIndex = 2;
            this.tabPage_station.Text = "站点查询";
            this.tabPage_station.UseVisualStyleBackColor = true;
            // 
            // UserQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 322);
            this.Controls.Add(this.tabControl_query_way);
            this.Name = "UserQueryForm";
            this.Text = "HappyQuery";
            this.Load += new System.EventHandler(this.UserQueryForm_Load);
            this.tabControl_query_way.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_query_way;
        private System.Windows.Forms.TabPage tabPage_station2station;
        private System.Windows.Forms.TabPage tabPage_line;
        private System.Windows.Forms.TabPage tabPage_station;

    }
}

