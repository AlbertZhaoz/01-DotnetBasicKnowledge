namespace NET_GetStartedWithSOA_WCF_Demo2_Client
{
    partial class FormClient
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
            this.textBox_Msg = new System.Windows.Forms.TextBox();
            this.button_Sub = new System.Windows.Forms.Button();
            this.button_UnSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Msg
            // 
            this.textBox_Msg.Location = new System.Drawing.Point(12, 12);
            this.textBox_Msg.Multiline = true;
            this.textBox_Msg.Name = "textBox_Msg";
            this.textBox_Msg.Size = new System.Drawing.Size(340, 652);
            this.textBox_Msg.TabIndex = 0;
            // 
            // button_Sub
            // 
            this.button_Sub.Location = new System.Drawing.Point(382, 12);
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.Size = new System.Drawing.Size(163, 74);
            this.button_Sub.TabIndex = 1;
            this.button_Sub.Text = "订阅服务器消息";
            this.button_Sub.UseVisualStyleBackColor = true;
            this.button_Sub.Click += new System.EventHandler(this.button_Sub_Click);
            // 
            // button_UnSub
            // 
            this.button_UnSub.Location = new System.Drawing.Point(382, 128);
            this.button_UnSub.Name = "button_UnSub";
            this.button_UnSub.Size = new System.Drawing.Size(163, 74);
            this.button_UnSub.TabIndex = 2;
            this.button_UnSub.Text = "取消订阅服务器消息";
            this.button_UnSub.UseVisualStyleBackColor = true;
            this.button_UnSub.Click += new System.EventHandler(this.button_UnSub_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 676);
            this.Controls.Add(this.button_UnSub);
            this.Controls.Add(this.button_Sub);
            this.Controls.Add(this.textBox_Msg);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Msg;
        private System.Windows.Forms.Button button_Sub;
        private System.Windows.Forms.Button button_UnSub;
    }
}

