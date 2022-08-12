namespace NET_GetStartedWithSOA_WCF_Demo2_Server
{
    partial class FormServer
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.uiTextBox_Msg = new Sunny.UI.UITextBox();
            this.uiButton_Publish = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(22, 19);
            this.textBox_Log.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.Size = new System.Drawing.Size(530, 524);
            this.textBox_Log.TabIndex = 0;
            // 
            // uiTextBox_Msg
            // 
            this.uiTextBox_Msg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_Msg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_Msg.Location = new System.Drawing.Point(595, 19);
            this.uiTextBox_Msg.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.uiTextBox_Msg.MinimumSize = new System.Drawing.Size(2, 25);
            this.uiTextBox_Msg.Name = "uiTextBox_Msg";
            this.uiTextBox_Msg.ShowText = false;
            this.uiTextBox_Msg.Size = new System.Drawing.Size(262, 60);
            this.uiTextBox_Msg.TabIndex = 1;
            this.uiTextBox_Msg.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_Msg.Watermark = "";
            this.uiTextBox_Msg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton_Publish
            // 
            this.uiButton_Publish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Publish.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Publish.Location = new System.Drawing.Point(595, 107);
            this.uiButton_Publish.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uiButton_Publish.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton_Publish.Name = "uiButton_Publish";
            this.uiButton_Publish.Size = new System.Drawing.Size(262, 85);
            this.uiButton_Publish.TabIndex = 2;
            this.uiButton_Publish.Text = "发布消息";
            this.uiButton_Publish.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Publish.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton_Publish.Click += new System.EventHandler(this.uiButton_Publish_Click);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 559);
            this.Controls.Add(this.uiButton_Publish);
            this.Controls.Add(this.uiTextBox_Msg);
            this.Controls.Add(this.textBox_Log);
            this.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormServer";
            this.Text = "FormServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing);
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Log;
        private Sunny.UI.UITextBox uiTextBox_Msg;
        private Sunny.UI.UIButton uiButton_Publish;
    }
}

