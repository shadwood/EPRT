namespace EPRT_C_sharp
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.новыйТурнирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйТурнирToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.текущийРейтингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общийРейтингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйТурнирToolStripMenuItem1,
            this.текущийРейтингToolStripMenuItem,
            this.общийРейтингToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйТурнирToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(155, 26);
            // 
            // новыйТурнирToolStripMenuItem
            // 
            this.новыйТурнирToolStripMenuItem.Name = "новыйТурнирToolStripMenuItem";
            this.новыйТурнирToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.новыйТурнирToolStripMenuItem.Text = "Новый турнир";
            // 
            // новыйТурнирToolStripMenuItem1
            // 
            this.новыйТурнирToolStripMenuItem1.Name = "новыйТурнирToolStripMenuItem1";
            this.новыйТурнирToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.новыйТурнирToolStripMenuItem1.Text = "Новый турнир";
            this.новыйТурнирToolStripMenuItem1.Click += new System.EventHandler(this.NewTurneyToolStripMenuItem1_Click);
            // 
            // текущийРейтингToolStripMenuItem
            // 
            this.текущийРейтингToolStripMenuItem.Name = "текущийРейтингToolStripMenuItem";
            this.текущийРейтингToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.текущийРейтингToolStripMenuItem.Text = "Текущий рейтинг";
            // 
            // общийРейтингToolStripMenuItem
            // 
            this.общийРейтингToolStripMenuItem.Name = "общийРейтингToolStripMenuItem";
            this.общийРейтингToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.общийРейтингToolStripMenuItem.Text = "Общий рейтинг";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 512);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem новыйТурнирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйТурнирToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem текущийРейтингToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общийРейтингToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
    }
}