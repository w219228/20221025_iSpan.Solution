namespace Demo_MDI
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.垂直排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.水平排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.層疊排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem,
            this.視窗ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// form2ToolStripMenuItem
			// 
			this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
			this.form2ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
			this.form2ToolStripMenuItem.Text = "Form2";
			this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
			// 
			// form3ToolStripMenuItem
			// 
			this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
			this.form3ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
			this.form3ToolStripMenuItem.Text = "Form3";
			this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
			// 
			// 視窗ToolStripMenuItem
			// 
			this.視窗ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.垂直排列ToolStripMenuItem,
            this.水平排列ToolStripMenuItem,
            this.層疊排列ToolStripMenuItem});
			this.視窗ToolStripMenuItem.Name = "視窗ToolStripMenuItem";
			this.視窗ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.視窗ToolStripMenuItem.Text = "視窗";
			// 
			// 垂直排列ToolStripMenuItem
			// 
			this.垂直排列ToolStripMenuItem.Name = "垂直排列ToolStripMenuItem";
			this.垂直排列ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.垂直排列ToolStripMenuItem.Text = "垂直排列";
			this.垂直排列ToolStripMenuItem.Click += new System.EventHandler(this.垂直排列ToolStripMenuItem_Click);
			// 
			// 水平排列ToolStripMenuItem
			// 
			this.水平排列ToolStripMenuItem.Name = "水平排列ToolStripMenuItem";
			this.水平排列ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.水平排列ToolStripMenuItem.Text = "水平排列";
			this.水平排列ToolStripMenuItem.Click += new System.EventHandler(this.水平排列ToolStripMenuItem_Click);
			// 
			// 層疊排列ToolStripMenuItem
			// 
			this.層疊排列ToolStripMenuItem.Name = "層疊排列ToolStripMenuItem";
			this.層疊排列ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.層疊排列ToolStripMenuItem.Text = "層疊排列";
			this.層疊排列ToolStripMenuItem.Click += new System.EventHandler(this.層疊排列ToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 視窗ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 垂直排列ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 水平排列ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 層疊排列ToolStripMenuItem;
	}
}

