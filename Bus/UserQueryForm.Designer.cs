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
            this.textBox_StartStation = new System.Windows.Forms.TextBox();
            this.textBox_EndStation = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_Query_s2s = new System.Windows.Forms.Button();
            this.tabControl_query_way.SuspendLayout();
            this.tabPage_station2station.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_query_way
            // 
            this.tabControl_query_way.Controls.Add(this.tabPage_station2station);
            this.tabControl_query_way.Controls.Add(this.tabPage_line);
            this.tabControl_query_way.Controls.Add(this.tabPage_station);
            this.tabControl_query_way.Location = new System.Drawing.Point(16, 35);
            this.tabControl_query_way.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl_query_way.Name = "tabControl_query_way";
            this.tabControl_query_way.SelectedIndex = 0;
            this.tabControl_query_way.Size = new System.Drawing.Size(596, 463);
            this.tabControl_query_way.TabIndex = 0;
            this.tabControl_query_way.Tag = "";
            // 
            // tabPage_station2station
            // 
            this.tabPage_station2station.Controls.Add(this.button_Query_s2s);
            this.tabPage_station2station.Controls.Add(this.listView1);
            this.tabPage_station2station.Controls.Add(this.textBox_EndStation);
            this.tabPage_station2station.Controls.Add(this.textBox_StartStation);
            this.tabPage_station2station.Location = new System.Drawing.Point(4, 29);
            this.tabPage_station2station.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_station2station.Name = "tabPage_station2station";
            this.tabPage_station2station.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_station2station.Size = new System.Drawing.Size(588, 430);
            this.tabPage_station2station.TabIndex = 0;
            this.tabPage_station2station.Text = "换乘查询";
            this.tabPage_station2station.UseVisualStyleBackColor = true;
            // 
            // tabPage_line
            // 
            this.tabPage_line.Location = new System.Drawing.Point(4, 29);
            this.tabPage_line.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_line.Name = "tabPage_line";
            this.tabPage_line.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_line.Size = new System.Drawing.Size(588, 430);
            this.tabPage_line.TabIndex = 1;
            this.tabPage_line.Text = "路线查询";
            this.tabPage_line.UseVisualStyleBackColor = true;
            // 
            // tabPage_station
            // 
            this.tabPage_station.Location = new System.Drawing.Point(4, 29);
            this.tabPage_station.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_station.Name = "tabPage_station";
            this.tabPage_station.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_station.Size = new System.Drawing.Size(588, 430);
            this.tabPage_station.TabIndex = 2;
            this.tabPage_station.Text = "站点查询";
            this.tabPage_station.UseVisualStyleBackColor = true;
            // 
            // textBox_StartStation
            // 
            this.textBox_StartStation.Location = new System.Drawing.Point(24, 34);
            this.textBox_StartStation.Name = "textBox_StartStation";
            this.textBox_StartStation.Size = new System.Drawing.Size(198, 26);
            this.textBox_StartStation.TabIndex = 0;
            // 
            // textBox_EndStation
            // 
            this.textBox_EndStation.Location = new System.Drawing.Point(270, 34);
            this.textBox_EndStation.Name = "textBox_EndStation";
            this.textBox_EndStation.Size = new System.Drawing.Size(198, 26);
            this.textBox_EndStation.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(24, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 324);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button_Query_s2s
            // 
            this.button_Query_s2s.Location = new System.Drawing.Point(491, 34);
            this.button_Query_s2s.Name = "button_Query_s2s";
            this.button_Query_s2s.Size = new System.Drawing.Size(75, 26);
            this.button_Query_s2s.TabIndex = 3;
            this.button_Query_s2s.Text = "查询";
            this.button_Query_s2s.UseVisualStyleBackColor = true;
            this.button_Query_s2s.Click += new System.EventHandler(this.button_Query_s2s_Click);
            // 
            // UserQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 537);
            this.Controls.Add(this.tabControl_query_way);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserQueryForm";
            this.Text = "HappyQuery";
            this.Load += new System.EventHandler(this.UserQueryForm_Load);
            this.tabControl_query_way.ResumeLayout(false);
            this.tabPage_station2station.ResumeLayout(false);
            this.tabPage_station2station.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_query_way;
        private System.Windows.Forms.TabPage tabPage_station2station;
        private System.Windows.Forms.TabPage tabPage_line;
        private System.Windows.Forms.TabPage tabPage_station;
        private System.Windows.Forms.Button button_Query_s2s;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox_EndStation;
        private System.Windows.Forms.TextBox textBox_StartStation;

    }
}

