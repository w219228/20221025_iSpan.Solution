namespace Demo_RadioButtonList
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
			this.genderGroup = new System.Windows.Forms.GroupBox();
			this.genderRdo1 = new System.Windows.Forms.RadioButton();
			this.genderRdo0 = new System.Windows.Forms.RadioButton();
			this.maritalStatusGroup = new System.Windows.Forms.GroupBox();
			this.maritalStatus1 = new System.Windows.Forms.RadioButton();
			this.maritalStatus2 = new System.Windows.Forms.RadioButton();
			this.maritalStatus3 = new System.Windows.Forms.RadioButton();
			this.maritalStatus4 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.genderGroup.SuspendLayout();
			this.maritalStatusGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// genderGroup
			// 
			this.genderGroup.Controls.Add(this.genderRdo0);
			this.genderGroup.Controls.Add(this.genderRdo1);
			this.genderGroup.Location = new System.Drawing.Point(51, 66);
			this.genderGroup.Name = "genderGroup";
			this.genderGroup.Size = new System.Drawing.Size(282, 63);
			this.genderGroup.TabIndex = 0;
			this.genderGroup.TabStop = false;
			this.genderGroup.Text = "性別";
			// 
			// genderRdo1
			// 
			this.genderRdo1.AutoSize = true;
			this.genderRdo1.Location = new System.Drawing.Point(15, 24);
			this.genderRdo1.Name = "genderRdo1";
			this.genderRdo1.Size = new System.Drawing.Size(43, 19);
			this.genderRdo1.TabIndex = 0;
			this.genderRdo1.TabStop = true;
			this.genderRdo1.Tag = "1";
			this.genderRdo1.Text = "男";
			this.genderRdo1.UseVisualStyleBackColor = true;
			// 
			// genderRdo0
			// 
			this.genderRdo0.AutoSize = true;
			this.genderRdo0.Location = new System.Drawing.Point(77, 24);
			this.genderRdo0.Name = "genderRdo0";
			this.genderRdo0.Size = new System.Drawing.Size(43, 19);
			this.genderRdo0.TabIndex = 1;
			this.genderRdo0.TabStop = true;
			this.genderRdo0.Tag = "0";
			this.genderRdo0.Text = "女";
			this.genderRdo0.UseVisualStyleBackColor = true;
			// 
			// maritalStatusGroup
			// 
			this.maritalStatusGroup.Controls.Add(this.maritalStatus4);
			this.maritalStatusGroup.Controls.Add(this.maritalStatus1);
			this.maritalStatusGroup.Controls.Add(this.maritalStatus3);
			this.maritalStatusGroup.Controls.Add(this.maritalStatus2);
			this.maritalStatusGroup.Location = new System.Drawing.Point(51, 153);
			this.maritalStatusGroup.Name = "maritalStatusGroup";
			this.maritalStatusGroup.Size = new System.Drawing.Size(282, 68);
			this.maritalStatusGroup.TabIndex = 1;
			this.maritalStatusGroup.TabStop = false;
			this.maritalStatusGroup.Text = "婚姻狀況";
			// 
			// maritalStatus1
			// 
			this.maritalStatus1.AutoSize = true;
			this.maritalStatus1.Location = new System.Drawing.Point(15, 24);
			this.maritalStatus1.Name = "maritalStatus1";
			this.maritalStatus1.Size = new System.Drawing.Size(58, 19);
			this.maritalStatus1.TabIndex = 0;
			this.maritalStatus1.TabStop = true;
			this.maritalStatus1.Tag = "1";
			this.maritalStatus1.Text = "已婚";
			this.maritalStatus1.UseVisualStyleBackColor = true;
			// 
			// maritalStatus2
			// 
			this.maritalStatus2.AutoSize = true;
			this.maritalStatus2.Location = new System.Drawing.Point(79, 24);
			this.maritalStatus2.Name = "maritalStatus2";
			this.maritalStatus2.Size = new System.Drawing.Size(58, 19);
			this.maritalStatus2.TabIndex = 1;
			this.maritalStatus2.TabStop = true;
			this.maritalStatus2.Tag = "2";
			this.maritalStatus2.Text = "未婚";
			this.maritalStatus2.UseVisualStyleBackColor = true;
			// 
			// maritalStatus3
			// 
			this.maritalStatus3.AutoSize = true;
			this.maritalStatus3.Location = new System.Drawing.Point(143, 24);
			this.maritalStatus3.Name = "maritalStatus3";
			this.maritalStatus3.Size = new System.Drawing.Size(58, 19);
			this.maritalStatus3.TabIndex = 2;
			this.maritalStatus3.TabStop = true;
			this.maritalStatus3.Tag = "3";
			this.maritalStatus3.Text = "離婚";
			this.maritalStatus3.UseVisualStyleBackColor = true;
			// 
			// maritalStatus4
			// 
			this.maritalStatus4.AutoSize = true;
			this.maritalStatus4.Location = new System.Drawing.Point(207, 24);
			this.maritalStatus4.Name = "maritalStatus4";
			this.maritalStatus4.Size = new System.Drawing.Size(58, 19);
			this.maritalStatus4.TabIndex = 3;
			this.maritalStatus4.TabStop = true;
			this.maritalStatus4.Tag = "4";
			this.maritalStatus4.Text = "喪偶";
			this.maritalStatus4.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(258, 239);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(51, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(282, 25);
			this.textBox1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.maritalStatusGroup);
			this.Controls.Add(this.genderGroup);
			this.Name = "Form1";
			this.Text = "Form1";
			this.genderGroup.ResumeLayout(false);
			this.genderGroup.PerformLayout();
			this.maritalStatusGroup.ResumeLayout(false);
			this.maritalStatusGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox genderGroup;
		private System.Windows.Forms.RadioButton genderRdo0;
		private System.Windows.Forms.RadioButton genderRdo1;
		private System.Windows.Forms.GroupBox maritalStatusGroup;
		private System.Windows.Forms.RadioButton maritalStatus1;
		private System.Windows.Forms.RadioButton maritalStatus2;
		private System.Windows.Forms.RadioButton maritalStatus3;
		private System.Windows.Forms.RadioButton maritalStatus4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
	}
}

