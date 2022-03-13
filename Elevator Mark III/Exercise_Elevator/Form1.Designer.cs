
namespace Exercise_Elevator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.Close = new System.Windows.Forms.RadioButton();
            this.Open = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.G6 = new System.Windows.Forms.CheckBox();
            this.G5 = new System.Windows.Forms.CheckBox();
            this.G4 = new System.Windows.Forms.CheckBox();
            this.G3 = new System.Windows.Forms.CheckBox();
            this.G2 = new System.Windows.Forms.CheckBox();
            this.G1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.display = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.info = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.door = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Down);
            this.groupBox1.Controls.Add(this.Up);
            this.groupBox1.Controls.Add(this.select);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "電梯外界面";
            // 
            // Down
            // 
            this.Down.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Down.Location = new System.Drawing.Point(208, 356);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(103, 77);
            this.Down.TabIndex = 2;
            this.Down.Text = "下";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.OutsideCC);
            // 
            // Up
            // 
            this.Up.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Up.Location = new System.Drawing.Point(208, 238);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(103, 77);
            this.Up.TabIndex = 1;
            this.Up.Text = "上";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.OutsideCC);
            // 
            // select
            // 
            this.select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.select.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.select.FormattingEnabled = true;
            this.select.Items.AddRange(new object[] {
            "一樓",
            "二樓",
            "三樓",
            "四樓",
            "五樓",
            "六樓"});
            this.select.Location = new System.Drawing.Point(153, 134);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(215, 35);
            this.select.TabIndex = 0;
            this.select.Text = "一樓";
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(576, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 551);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "電梯内界面";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.Close);
            this.groupBox11.Controls.Add(this.Open);
            this.groupBox11.Location = new System.Drawing.Point(330, 468);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(138, 66);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Enabled = false;
            this.Close.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Close.Location = new System.Drawing.Point(72, 25);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(47, 28);
            this.Close.TabIndex = 1;
            this.Close.Text = "關";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.CheckedChanged += new System.EventHandler(this.Close_CheckedChanged);
            // 
            // Open
            // 
            this.Open.AutoSize = true;
            this.Open.Checked = true;
            this.Open.Enabled = false;
            this.Open.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Open.Location = new System.Drawing.Point(19, 25);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(47, 28);
            this.Open.TabIndex = 0;
            this.Open.TabStop = true;
            this.Open.Text = "開";
            this.Open.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.G6);
            this.groupBox10.Controls.Add(this.G5);
            this.groupBox10.Controls.Add(this.G4);
            this.groupBox10.Controls.Add(this.G3);
            this.groupBox10.Controls.Add(this.G2);
            this.groupBox10.Controls.Add(this.G1);
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(330, 123);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(138, 339);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            // 
            // G6
            // 
            this.G6.AutoSize = true;
            this.G6.Location = new System.Drawing.Point(35, 45);
            this.G6.Name = "G6";
            this.G6.Size = new System.Drawing.Size(67, 28);
            this.G6.TabIndex = 5;
            this.G6.Text = "六樓";
            this.G6.UseVisualStyleBackColor = true;
            this.G6.CheckedChanged += new System.EventHandler(this.InsideCC);
            // 
            // G5
            // 
            this.G5.AutoSize = true;
            this.G5.Location = new System.Drawing.Point(35, 91);
            this.G5.Name = "G5";
            this.G5.Size = new System.Drawing.Size(67, 28);
            this.G5.TabIndex = 4;
            this.G5.Text = "五樓";
            this.G5.UseVisualStyleBackColor = true;
            this.G5.CheckedChanged += new System.EventHandler(this.InsideCC);
            // 
            // G4
            // 
            this.G4.AutoSize = true;
            this.G4.Location = new System.Drawing.Point(35, 140);
            this.G4.Name = "G4";
            this.G4.Size = new System.Drawing.Size(67, 28);
            this.G4.TabIndex = 3;
            this.G4.Text = "四樓";
            this.G4.UseVisualStyleBackColor = true;
            this.G4.CheckedChanged += new System.EventHandler(this.InsideCC);
            // 
            // G3
            // 
            this.G3.AutoSize = true;
            this.G3.Location = new System.Drawing.Point(35, 185);
            this.G3.Name = "G3";
            this.G3.Size = new System.Drawing.Size(67, 28);
            this.G3.TabIndex = 2;
            this.G3.Text = "三樓";
            this.G3.UseVisualStyleBackColor = true;
            this.G3.CheckedChanged += new System.EventHandler(this.InsideCC);
            // 
            // G2
            // 
            this.G2.AutoSize = true;
            this.G2.Location = new System.Drawing.Point(35, 233);
            this.G2.Name = "G2";
            this.G2.Size = new System.Drawing.Size(67, 28);
            this.G2.TabIndex = 1;
            this.G2.Text = "二樓";
            this.G2.UseVisualStyleBackColor = true;
            this.G2.CheckedChanged += new System.EventHandler(this.InsideCC);
            // 
            // G1
            // 
            this.G1.AutoSize = true;
            this.G1.Location = new System.Drawing.Point(35, 278);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(67, 28);
            this.G1.TabIndex = 0;
            this.G1.Text = "一樓";
            this.G1.UseVisualStyleBackColor = true;
            this.G1.CheckedChanged += new System.EventHandler(this.InsideCC);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.display);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(330, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 96);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "樓層";
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.display.Location = new System.Drawing.Point(6, 29);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(126, 43);
            this.display.TabIndex = 0;
            this.display.Text = "1";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start.Location = new System.Drawing.Point(55, 42);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(175, 55);
            this.Start.TabIndex = 2;
            this.Start.Text = "開始模擬";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Exit.Location = new System.Drawing.Point(563, 42);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(175, 55);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "結束程式";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.info);
            this.groupBox12.Controls.Add(this.End);
            this.groupBox12.Controls.Add(this.Exit);
            this.groupBox12.Controls.Add(this.Start);
            this.groupBox12.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox12.Location = new System.Drawing.Point(13, 569);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1050, 126);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "模擬控制";
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.info.Location = new System.Drawing.Point(820, 42);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(175, 55);
            this.info.TabIndex = 6;
            this.info.Text = "操作説明";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // End
            // 
            this.End.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.End.Location = new System.Drawing.Point(310, 42);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(175, 55);
            this.End.TabIndex = 5;
            this.End.Text = "停止模擬";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // door
            // 
            this.door.Interval = 5000;
            this.door.Tick += new System.EventHandler(this.door_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 707);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.RadioButton Close;
        private System.Windows.Forms.RadioButton Open;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox G6;
        private System.Windows.Forms.CheckBox G5;
        private System.Windows.Forms.CheckBox G4;
        private System.Windows.Forms.CheckBox G3;
        private System.Windows.Forms.CheckBox G2;
        private System.Windows.Forms.CheckBox G1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Timer door;
    }
}

