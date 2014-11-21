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
            this.button_Query_s2s = new System.Windows.Forms.Button();
            this.textBox_EndStation = new System.Windows.Forms.TextBox();
            this.textBox_StartStation = new System.Windows.Forms.TextBox();
            this.tabPage_line = new System.Windows.Forms.TabPage();
            this.tabPage_station = new System.Windows.Forms.TabPage();
            this.listView_result = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Query_way = new System.Windows.Forms.Button();
            this.tabControl_query_way.SuspendLayout();
            this.tabPage_station2station.SuspendLayout();
            this.tabPage_line.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_query_way
            // 
            this.tabControl_query_way.Controls.Add(this.tabPage_station2station);
            this.tabControl_query_way.Controls.Add(this.tabPage_line);
            this.tabControl_query_way.Controls.Add(this.tabPage_station);
            this.tabControl_query_way.Location = new System.Drawing.Point(16, 16);
            this.tabControl_query_way.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl_query_way.Name = "tabControl_query_way";
            this.tabControl_query_way.SelectedIndex = 0;
            this.tabControl_query_way.Size = new System.Drawing.Size(599, 119);
            this.tabControl_query_way.TabIndex = 0;
            this.tabControl_query_way.Tag = "";
            // 
            // tabPage_station2station
            // 
            this.tabPage_station2station.Controls.Add(this.button_Query_s2s);
            this.tabPage_station2station.Controls.Add(this.textBox_EndStation);
            this.tabPage_station2station.Controls.Add(this.textBox_StartStation);
            this.tabPage_station2station.Location = new System.Drawing.Point(4, 29);
            this.tabPage_station2station.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_station2station.Name = "tabPage_station2station";
            this.tabPage_station2station.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_station2station.Size = new System.Drawing.Size(591, 86);
            this.tabPage_station2station.TabIndex = 0;
            this.tabPage_station2station.Text = "换乘查询";
            this.tabPage_station2station.UseVisualStyleBackColor = true;
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
            // textBox_EndStation
            // 
            this.textBox_EndStation.Location = new System.Drawing.Point(270, 34);
            this.textBox_EndStation.Name = "textBox_EndStation";
            this.textBox_EndStation.Size = new System.Drawing.Size(198, 26);
            this.textBox_EndStation.TabIndex = 1;
            // 
            // textBox_StartStation
            // 
            this.textBox_StartStation.Location = new System.Drawing.Point(24, 34);
            this.textBox_StartStation.Name = "textBox_StartStation";
            this.textBox_StartStation.Size = new System.Drawing.Size(198, 26);
            this.textBox_StartStation.TabIndex = 0;
            // 
            // tabPage_line
            // 
            this.tabPage_line.Controls.Add(this.button_Query_way);
            this.tabPage_line.Controls.Add(this.textBox1);
            this.tabPage_line.Location = new System.Drawing.Point(4, 29);
            this.tabPage_line.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_line.Name = "tabPage_line";
            this.tabPage_line.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_line.Size = new System.Drawing.Size(591, 86);
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
            this.tabPage_station.Size = new System.Drawing.Size(591, 86);
            this.tabPage_station.TabIndex = 2;
            this.tabPage_station.Text = "站点查询";
            this.tabPage_station.UseVisualStyleBackColor = true;
            // 
            // listView_result
            // 
            this.listView_result.Location = new System.Drawing.Point(16, 139);
            this.listView_result.Name = "listView_result";
            this.listView_result.Size = new System.Drawing.Size(596, 367);
            this.listView_result.TabIndex = 1;
            this.listView_result.UseCompatibleStateImageBehavior = false;
            this.listView_result.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 0;
            // 
            // button_Query_way
            // 
            this.button_Query_way.Location = new System.Drawing.Point(386, 34);
            this.button_Query_way.Name = "button_Query_way";
            this.button_Query_way.Size = new System.Drawing.Size(75, 26);
            this.button_Query_way.TabIndex = 1;
            this.button_Query_way.Text = "查询";
            this.button_Query_way.UseVisualStyleBackColor = true;
            this.button_Query_way.Click += new System.EventHandler(this.button_Query_way_Click);
            // 
            // UserQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 520);
            this.Controls.Add(this.listView_result);
            this.Controls.Add(this.tabControl_query_way);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserQueryForm";
            this.Text = "HappyQuery";
            this.Load += new System.EventHandler(this.UserQueryForm_Load);
            this.tabControl_query_way.ResumeLayout(false);
            this.tabPage_station2station.ResumeLayout(false);
            this.tabPage_station2station.PerformLayout();
            this.tabPage_line.ResumeLayout(false);
            this.tabPage_line.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_query_way;
        private System.Windows.Forms.TabPage tabPage_station2station;
        private System.Windows.Forms.TabPage tabPage_line;
        private System.Windows.Forms.TabPage tabPage_station;
        private System.Windows.Forms.Button button_Query_s2s;
        private System.Windows.Forms.TextBox textBox_EndStation;
        private System.Windows.Forms.TextBox textBox_StartStation;
        private System.Windows.Forms.ListView listView_result;
        private System.Windows.Forms.Button button_Query_way;
        private System.Windows.Forms.TextBox textBox1;

    }
}

