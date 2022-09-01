namespace StudentMag
{
    partial class ReUserName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsedName = new System.Windows.Forms.TextBox();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(365, 227);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(314, 25);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入修改后的用户名：";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(227, 331);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(133, 41);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "确定";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入现在的用户名：";
            // 
            // tbUsedName
            // 
            this.tbUsedName.Location = new System.Drawing.Point(365, 147);
            this.tbUsedName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsedName.Name = "tbUsedName";
            this.tbUsedName.Size = new System.Drawing.Size(314, 25);
            this.tbUsedName.TabIndex = 4;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(472, 331);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(133, 41);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "返回";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // ReUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 533);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.tbUsedName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReUserName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改用户名";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsedName;
        private System.Windows.Forms.Button btBack;
    }
}