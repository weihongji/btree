namespace BTree
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusBarLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFile_Circle1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFile_Circle2 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFile_Circle3 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFile_BTree = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(684, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 489);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(684, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusBarLabel1
			// 
			this.statusBarLabel1.Name = "statusBarLabel1";
			this.statusBarLabel1.Size = new System.Drawing.Size(29, 17);
			this.statusBarLabel1.Text = "N/A";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile_Circle1,
            this.menuFile_Circle2,
            this.menuFile_Circle3,
            this.menuFile_BTree,
            this.menuFile_Exit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "&File";
			// 
			// menuFile_Circle1
			// 
			this.menuFile_Circle1.Name = "menuFile_Circle1";
			this.menuFile_Circle1.Size = new System.Drawing.Size(152, 22);
			this.menuFile_Circle1.Text = "Circle &1";
			this.menuFile_Circle1.Click += new System.EventHandler(this.menuFile_Circle1_Click);
			// 
			// menuFile_Circle2
			// 
			this.menuFile_Circle2.Name = "menuFile_Circle2";
			this.menuFile_Circle2.Size = new System.Drawing.Size(152, 22);
			this.menuFile_Circle2.Text = "Circle &2";
			this.menuFile_Circle2.Click += new System.EventHandler(this.menuFile_Circle2_Click);
			// 
			// menuFile_Circle3
			// 
			this.menuFile_Circle3.Name = "menuFile_Circle3";
			this.menuFile_Circle3.Size = new System.Drawing.Size(152, 22);
			this.menuFile_Circle3.Text = "Circle &3";
			this.menuFile_Circle3.Click += new System.EventHandler(this.menuFile_Circle3_Click);
			// 
			// menuFile_BTree
			// 
			this.menuFile_BTree.Name = "menuFile_BTree";
			this.menuFile_BTree.Size = new System.Drawing.Size(152, 22);
			this.menuFile_BTree.Text = "B-&Tree";
			this.menuFile_BTree.Click += new System.EventHandler(this.menuFile_BTree_Click);
			// 
			// menuFile_Exit
			// 
			this.menuFile_Exit.Name = "menuFile_Exit";
			this.menuFile_Exit.Size = new System.Drawing.Size(152, 22);
			this.menuFile_Exit.Text = "E&xit";
			this.menuFile_Exit.Click += new System.EventHandler(this.menuFile_Exit_Click);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(684, 465);
			this.panel1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 511);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuFile_Circle1;
		private System.Windows.Forms.ToolStripMenuItem menuFile_Circle2;
		private System.Windows.Forms.ToolStripMenuItem menuFile_Circle3;
		private System.Windows.Forms.ToolStripMenuItem menuFile_BTree;
		private System.Windows.Forms.ToolStripMenuItem menuFile_Exit;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusBarLabel1;
		private System.Windows.Forms.Panel panel1;
	}
}

