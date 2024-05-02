using Rose.Resources;

namespace Rose
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            MenuBar = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            diğerToolStripMenuItem = new ToolStripMenuItem();
            connectADBToolStripMenuItem = new ToolStripMenuItem();
            arcToolStripMenuItem = new ToolStripMenuItem();
            eLibToolStripMenuItem = new ToolStripMenuItem();
            MenuBar.SuspendLayout();
            SuspendLayout();
            // 
            // MenuBar
            // 
            MenuBar.ImageScalingSize = new Size(20, 20);
            MenuBar.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, diğerToolStripMenuItem });
            MenuBar.Location = new Point(0, 0);
            MenuBar.Name = "MenuBar";
            MenuBar.Size = new Size(1062, 28);
            MenuBar.TabIndex = 0;
            MenuBar.Text = "MenuBar";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(64, 24);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // diğerToolStripMenuItem
            // 
            diğerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectADBToolStripMenuItem, arcToolStripMenuItem, eLibToolStripMenuItem });
            diğerToolStripMenuItem.Name = "diğerToolStripMenuItem";
            diğerToolStripMenuItem.Size = new Size(60, 24);
            diğerToolStripMenuItem.Text = "Diğer";
            // 
            // connectADBToolStripMenuItem
            // 
            connectADBToolStripMenuItem.Name = "connectADBToolStripMenuItem";
            connectADBToolStripMenuItem.Size = new Size(224, 26);
            connectADBToolStripMenuItem.Text = "Connect ADB";
            // 
            // arcToolStripMenuItem
            // 
            arcToolStripMenuItem.Name = "arcToolStripMenuItem";
            arcToolStripMenuItem.Size = new Size(224, 26);
            arcToolStripMenuItem.Text = "Arc";
            // 
            // eLibToolStripMenuItem
            // 
            eLibToolStripMenuItem.Name = "eLibToolStripMenuItem";
            eLibToolStripMenuItem.Size = new Size(224, 26);
            eLibToolStripMenuItem.Text = "E-Lib";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1062, 673);
            Controls.Add(MenuBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuBar;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rose";
            MenuBar.ResumeLayout(false);
            MenuBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuBar;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem diğerToolStripMenuItem;
        private ToolStripMenuItem connectADBToolStripMenuItem;
        private ToolStripMenuItem arcToolStripMenuItem;
        private ToolStripMenuItem eLibToolStripMenuItem;
    }
}
