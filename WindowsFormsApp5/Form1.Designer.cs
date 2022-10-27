namespace WindowsFormsApp5
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
			this.firstNumberTextBox = new System.Windows.Forms.TextBox();
			this.optionCboBox = new System.Windows.Forms.ComboBox();
			this.secondNumberTextBox = new System.Windows.Forms.TextBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.calcButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// firstNumberTextBox
			// 
			this.firstNumberTextBox.Location = new System.Drawing.Point(89, 101);
			this.firstNumberTextBox.MaxLength = 3;
			this.firstNumberTextBox.Name = "firstNumberTextBox";
			this.firstNumberTextBox.Size = new System.Drawing.Size(100, 22);
			this.firstNumberTextBox.TabIndex = 0;
			// 
			// optionCboBox
			// 
			this.optionCboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.optionCboBox.FormattingEnabled = true;
			this.optionCboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
			this.optionCboBox.Location = new System.Drawing.Point(217, 102);
			this.optionCboBox.Name = "optionCboBox";
			this.optionCboBox.Size = new System.Drawing.Size(121, 20);
			this.optionCboBox.TabIndex = 1;
			// 
			// secondNumberTextBox
			// 
			this.secondNumberTextBox.Location = new System.Drawing.Point(370, 100);
			this.secondNumberTextBox.MaxLength = 3;
			this.secondNumberTextBox.Name = "secondNumberTextBox";
			this.secondNumberTextBox.Size = new System.Drawing.Size(100, 22);
			this.secondNumberTextBox.TabIndex = 2;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(520, 110);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(56, 12);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "resultLabel";
			// 
			// calcButton
			// 
			this.calcButton.Location = new System.Drawing.Point(522, 135);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(75, 23);
			this.calcButton.TabIndex = 4;
			this.calcButton.Text = "計算";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.secondNumberTextBox);
			this.Controls.Add(this.optionCboBox);
			this.Controls.Add(this.firstNumberTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstNumberTextBox;
		private System.Windows.Forms.ComboBox optionCboBox;
		private System.Windows.Forms.TextBox secondNumberTextBox;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Button calcButton;
	}
}

