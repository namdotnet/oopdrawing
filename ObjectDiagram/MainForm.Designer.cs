namespace ObjectDiagram
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdCreateRectangle = new System.Windows.Forms.ToolStripButton();
            this.cmdCreateTriangle = new System.Windows.Forms.ToolStripButton();
            this.diagramPanel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdCreateRectangle,
            this.cmdCreateTriangle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1021, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdCreateRectangle
            // 
            this.cmdCreateRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdCreateRectangle.Image = ((System.Drawing.Image)(resources.GetObject("cmdCreateRectangle.Image")));
            this.cmdCreateRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCreateRectangle.Name = "cmdCreateRectangle";
            this.cmdCreateRectangle.Size = new System.Drawing.Size(63, 22);
            this.cmdCreateRectangle.Text = "Rectangle";
            this.cmdCreateRectangle.Click += new System.EventHandler(this.cmdCreateRectangle_Click);
            // 
            // cmdCreateTriangle
            // 
            this.cmdCreateTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdCreateTriangle.Image = ((System.Drawing.Image)(resources.GetObject("cmdCreateTriangle.Image")));
            this.cmdCreateTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCreateTriangle.Name = "cmdCreateTriangle";
            this.cmdCreateTriangle.Size = new System.Drawing.Size(52, 22);
            this.cmdCreateTriangle.Text = "Triangle";
            this.cmdCreateTriangle.Click += new System.EventHandler(this.cmdCreateTriangle_Click);
            // 
            // diagramPanel
            // 
            this.diagramPanel.BackColor = System.Drawing.Color.White;
            this.diagramPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramPanel.Location = new System.Drawing.Point(0, 25);
            this.diagramPanel.Name = "diagramPanel";
            this.diagramPanel.Size = new System.Drawing.Size(1021, 516);
            this.diagramPanel.TabIndex = 1;
            this.diagramPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.diagramPanel_MouseDoubleClick);
            this.diagramPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.diagramPanel_OnMouseDown);
            this.diagramPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.diagramPanel_OnMouseMove);
            this.diagramPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.diagramPanel_OnMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 541);
            this.Controls.Add(this.diagramPanel);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Diagram Sample - Nam.NET";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel diagramPanel;
        private System.Windows.Forms.ToolStripButton cmdCreateRectangle;
        private System.Windows.Forms.ToolStripButton cmdCreateTriangle;
    }
}

