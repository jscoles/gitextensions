﻿namespace GitUI.RepoHosting
{
    partial class CreatePullRequestForm
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
            this._titleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._bodyTB = new System.Windows.Forms.TextBox();
            this._pullReqTargetsCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._createBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _titleTB
            // 
            this._titleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._titleTB.Location = new System.Drawing.Point(46, 19);
            this._titleTB.Name = "_titleTB";
            this._titleTB.Size = new System.Drawing.Size(373, 20);
            this._titleTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Body:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._bodyTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._titleTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pull request data";
            // 
            // _bodyTB
            // 
            this._bodyTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._bodyTB.Location = new System.Drawing.Point(46, 45);
            this._bodyTB.Multiline = true;
            this._bodyTB.Name = "_bodyTB";
            this._bodyTB.Size = new System.Drawing.Size(373, 144);
            this._bodyTB.TabIndex = 3;
            // 
            // _pullReqTargetsCB
            // 
            this._pullReqTargetsCB.DisplayMember = "DisplayData";
            this._pullReqTargetsCB.FormattingEnabled = true;
            this._pullReqTargetsCB.Location = new System.Drawing.Point(138, 14);
            this._pullReqTargetsCB.Name = "_pullReqTargetsCB";
            this._pullReqTargetsCB.Size = new System.Drawing.Size(197, 21);
            this._pullReqTargetsCB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pull request to:";
            // 
            // _createBtn
            // 
            this._createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._createBtn.Location = new System.Drawing.Point(325, 246);
            this._createBtn.Name = "_createBtn";
            this._createBtn.Size = new System.Drawing.Size(112, 33);
            this._createBtn.TabIndex = 6;
            this._createBtn.Text = "Create";
            this._createBtn.UseVisualStyleBackColor = true;
            // 
            // CreatePullRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 288);
            this.Controls.Add(this._createBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._pullReqTargetsCB);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreatePullRequestForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Pull Request";
            this.Load += new System.EventHandler(this.CreatePullRequestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _titleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _bodyTB;
        private System.Windows.Forms.ComboBox _pullReqTargetsCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _createBtn;
    }
}