namespace Strategy
{
    partial class CashAccept
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
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(334, 47);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(126, 21);
            this.textPrice.TabIndex = 0;
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(334, 103);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(126, 21);
            this.textNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "计算方式：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(265, 217);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "正常收费",
            "九折",
            "八折",
            "300返100"});
            this.cbType.Location = new System.Drawing.Point(334, 156);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(126, 20);
            this.cbType.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(385, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.ItemHeight = 12;
            this.lboxResult.Location = new System.Drawing.Point(35, 47);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(213, 172);
            this.lboxResult.TabIndex = 10;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(189, 228);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(11, 12);
            this.lbTotal.TabIndex = 11;
            this.lbTotal.Text = "0";
            // 
            // CashAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 305);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.textPrice);
            this.Name = "CashAccept";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lboxResult;
        private System.Windows.Forms.Label lbTotal;
    }
}

