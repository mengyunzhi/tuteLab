namespace tool
{
    partial class Form1
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
            this.Gateway_Label = new System.Windows.Forms.Label();
            this.EDIT = new System.Windows.Forms.Button();
            this.Gateway = new System.Windows.Forms.Label();
            this.PoweredBy = new System.Windows.Forms.Label();
            this.yunzhi = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Gateway_Label
            // 
            this.Gateway_Label.AutoSize = true;
            this.Gateway_Label.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Gateway_Label.Location = new System.Drawing.Point(6, 42);
            this.Gateway_Label.Name = "Gateway_Label";
            this.Gateway_Label.Size = new System.Drawing.Size(180, 33);
            this.Gateway_Label.TabIndex = 0;
            this.Gateway_Label.Text = "当前网关：";
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EDIT.Location = new System.Drawing.Point(12, 154);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(363, 72);
            this.EDIT.TabIndex = 2;
            this.EDIT.Text = "一键修改网关";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // Gateway
            // 
            this.Gateway.AutoSize = true;
            this.Gateway.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Gateway.Location = new System.Drawing.Point(160, 42);
            this.Gateway.Name = "Gateway";
            this.Gateway.Size = new System.Drawing.Size(0, 33);
            this.Gateway.TabIndex = 3;
            // 
            // PoweredBy
            // 
            this.PoweredBy.AutoSize = true;
            this.PoweredBy.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PoweredBy.Location = new System.Drawing.Point(8, 282);
            this.PoweredBy.Name = "PoweredBy";
            this.PoweredBy.Size = new System.Drawing.Size(120, 21);
            this.PoweredBy.TabIndex = 4;
            this.PoweredBy.Text = "技术支持：";
            // 
            // yunzhi
            // 
            this.yunzhi.AutoSize = true;
            this.yunzhi.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yunzhi.Location = new System.Drawing.Point(149, 282);
            this.yunzhi.Name = "yunzhi";
            this.yunzhi.Size = new System.Drawing.Size(226, 21);
            this.yunzhi.TabIndex = 5;
            this.yunzhi.TabStop = true;
            this.yunzhi.Text = "www.mengyunzhi.com";
            this.yunzhi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Yunzhi_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 331);
            this.Controls.Add(this.yunzhi);
            this.Controls.Add(this.PoweredBy);
            this.Controls.Add(this.Gateway);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.Gateway_Label);
            this.Name = "Form1";
            this.Text = "网关小助手(请以管理员身份运行)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gateway_Label;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Label Gateway;
        private System.Windows.Forms.Label PoweredBy;
        private System.Windows.Forms.LinkLabel yunzhi;
    }
}

