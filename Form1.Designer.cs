namespace CatRun
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IntervalTimer = new System.Windows.Forms.Timer(this.components);
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.WhiteCat = new System.Windows.Forms.RadioButton();
            this.BlackCat = new System.Windows.Forms.RadioButton();
            this.CatIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TaskTrayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TasktrayCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IntervalTimer
            // 
            this.IntervalTimer.Enabled = true;
            this.IntervalTimer.Interval = 1500;
            this.IntervalTimer.Tick += new System.EventHandler(this.IntervalTimer_Tick);
            // 
            // FrameTimer
            // 
            this.FrameTimer.Enabled = true;
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // WhiteCat
            // 
            this.WhiteCat.AutoSize = true;
            this.WhiteCat.Location = new System.Drawing.Point(13, 13);
            this.WhiteCat.Margin = new System.Windows.Forms.Padding(4);
            this.WhiteCat.Name = "WhiteCat";
            this.WhiteCat.Size = new System.Drawing.Size(55, 19);
            this.WhiteCat.TabIndex = 0;
            this.WhiteCat.Text = "白猫";
            this.WhiteCat.UseVisualStyleBackColor = true;
            this.WhiteCat.CheckedChanged += new System.EventHandler(this.ColorButton_CheckedChanged);
            // 
            // BlackCat
            // 
            this.BlackCat.AutoSize = true;
            this.BlackCat.Location = new System.Drawing.Point(13, 40);
            this.BlackCat.Margin = new System.Windows.Forms.Padding(4);
            this.BlackCat.Name = "BlackCat";
            this.BlackCat.Size = new System.Drawing.Size(55, 19);
            this.BlackCat.TabIndex = 1;
            this.BlackCat.Text = "黒猫";
            this.BlackCat.UseVisualStyleBackColor = true;
            this.BlackCat.CheckedChanged += new System.EventHandler(this.ColorButton_CheckedChanged);
            // 
            // CatIcon
            // 
            this.CatIcon.Text = "ﾆｬｵ";
            this.CatIcon.Visible = true;
            this.CatIcon.Click += new System.EventHandler(this.CatIcon_Click);
            // 
            // TaskTrayButton
            // 
            this.TaskTrayButton.Location = new System.Drawing.Point(12, 66);
            this.TaskTrayButton.Name = "TaskTrayButton";
            this.TaskTrayButton.Size = new System.Drawing.Size(75, 23);
            this.TaskTrayButton.TabIndex = 3;
            this.TaskTrayButton.Text = "Tasktray";
            this.TaskTrayButton.UseVisualStyleBackColor = true;
            this.TaskTrayButton.Click += new System.EventHandler(this.TaskTrayButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(93, 66);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TasktrayCheck
            // 
            this.TasktrayCheck.AutoSize = true;
            this.TasktrayCheck.Location = new System.Drawing.Point(76, 13);
            this.TasktrayCheck.Name = "TasktrayCheck";
            this.TasktrayCheck.Size = new System.Drawing.Size(86, 19);
            this.TasktrayCheck.TabIndex = 5;
            this.TasktrayCheck.Text = "自動格納";
            this.TasktrayCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 101);
            this.Controls.Add(this.TasktrayCheck);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TaskTrayButton);
            this.Controls.Add(this.BlackCat);
            this.Controls.Add(this.WhiteCat);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "CatRun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer IntervalTimer;
        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.RadioButton WhiteCat;
        private System.Windows.Forms.RadioButton BlackCat;
        private System.Windows.Forms.NotifyIcon CatIcon;
        private System.Windows.Forms.Button TaskTrayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox TasktrayCheck;
    }
}

