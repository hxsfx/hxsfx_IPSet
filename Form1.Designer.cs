namespace hxsfxIPSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_maskCode = new System.Windows.Forms.TextBox();
            this.textBox_gateway = new System.Windows.Forms.TextBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.cb_adapter = new System.Windows.Forms.ComboBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.button_closeForm = new System.Windows.Forms.Button();
            this.btn_getNetworkInterfaceName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网络适配器名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "掩码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "网关：";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(13, 88);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(205, 21);
            this.textBox_ip.TabIndex = 5;
            this.textBox_ip.TextChanged += new System.EventHandler(this.textBox_ip_TextChanged);
            // 
            // textBox_maskCode
            // 
            this.textBox_maskCode.Location = new System.Drawing.Point(14, 127);
            this.textBox_maskCode.Name = "textBox_maskCode";
            this.textBox_maskCode.Size = new System.Drawing.Size(204, 21);
            this.textBox_maskCode.TabIndex = 6;
            // 
            // textBox_gateway
            // 
            this.textBox_gateway.Location = new System.Drawing.Point(14, 166);
            this.textBox_gateway.Name = "textBox_gateway";
            this.textBox_gateway.Size = new System.Drawing.Size(204, 21);
            this.textBox_gateway.TabIndex = 7;
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.Color.White;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Location = new System.Drawing.Point(15, 193);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(203, 30);
            this.btn_modify.TabIndex = 8;
            this.btn_modify.Text = "点击修改";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // cb_adapter
            // 
            this.cb_adapter.FormattingEnabled = true;
            this.cb_adapter.Location = new System.Drawing.Point(15, 50);
            this.cb_adapter.Name = "cb_adapter";
            this.cb_adapter.Size = new System.Drawing.Size(144, 20);
            this.cb_adapter.TabIndex = 10;
            this.cb_adapter.SelectedIndexChanged += new System.EventHandler(this.cb_adapter_SelectedIndexChanged);
            // 
            // lb_title
            // 
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_title.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_title.Location = new System.Drawing.Point(0, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(230, 24);
            this.lb_title.TabIndex = 11;
            this.lb_title.Text = " HXSFX · IP修改";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_title_MouseDown);
            // 
            // button_closeForm
            // 
            this.button_closeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_closeForm.FlatAppearance.BorderSize = 0;
            this.button_closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_closeForm.Location = new System.Drawing.Point(206, -1);
            this.button_closeForm.Name = "button_closeForm";
            this.button_closeForm.Size = new System.Drawing.Size(25, 25);
            this.button_closeForm.TabIndex = 12;
            this.button_closeForm.Text = "×";
            this.button_closeForm.UseVisualStyleBackColor = true;
            this.button_closeForm.Click += new System.EventHandler(this.button_closeForm_Click);
            // 
            // btn_getNetworkInterfaceName
            // 
            this.btn_getNetworkInterfaceName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getNetworkInterfaceName.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getNetworkInterfaceName.Location = new System.Drawing.Point(166, 50);
            this.btn_getNetworkInterfaceName.Name = "btn_getNetworkInterfaceName";
            this.btn_getNetworkInterfaceName.Size = new System.Drawing.Size(52, 20);
            this.btn_getNetworkInterfaceName.TabIndex = 13;
            this.btn_getNetworkInterfaceName.Text = "刷新";
            this.btn_getNetworkInterfaceName.UseVisualStyleBackColor = true;
            this.btn_getNetworkInterfaceName.Click += new System.EventHandler(this.btn_getNetworkInterfaceName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 230);
            this.Controls.Add(this.btn_getNetworkInterfaceName);
            this.Controls.Add(this.button_closeForm);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.cb_adapter);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.textBox_gateway);
            this.Controls.Add(this.textBox_maskCode);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_maskCode;
        private System.Windows.Forms.TextBox textBox_gateway;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.ComboBox cb_adapter;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button button_closeForm;
        private System.Windows.Forms.Button btn_getNetworkInterfaceName;
    }
}

