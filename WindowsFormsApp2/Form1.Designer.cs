﻿namespace WindowsFormsApp2
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
			this.drawButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// drawButton
			// 
			this.drawButton.Location = new System.Drawing.Point(62, 31);
			this.drawButton.Name = "drawButton";
			this.drawButton.Size = new System.Drawing.Size(75, 23);
			this.drawButton.TabIndex = 0;
			this.drawButton.Text = "開獎";
			this.drawButton.UseVisualStyleBackColor = true;
			this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.IMG_1042;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(991, 591);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.drawButton);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "槳透開獎";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button drawButton;
		private System.Windows.Forms.Label label1;
	}
}

