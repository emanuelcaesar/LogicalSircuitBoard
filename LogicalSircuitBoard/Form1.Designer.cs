namespace LogicalSircuitBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbNor = new System.Windows.Forms.PictureBox();
            this.pbOr = new System.Windows.Forms.PictureBox();
            this.pbAnd = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbWorkingPanel = new System.Windows.Forms.GroupBox();
            this.pnlWorking = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.source1 = new LogicalSircuitBoard.Source();
            this.gbOption.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbWorkingPanel.SuspendLayout();
            this.pnlWorking.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOption
            // 
            this.gbOption.BackColor = System.Drawing.Color.White;
            this.gbOption.Controls.Add(this.label6);
            this.gbOption.Controls.Add(this.label5);
            this.gbOption.Controls.Add(this.label4);
            this.gbOption.Controls.Add(this.panel3);
            this.gbOption.Controls.Add(this.panel1);
            this.gbOption.Controls.Add(this.pbNor);
            this.gbOption.Controls.Add(this.pbOr);
            this.gbOption.Controls.Add(this.pbAnd);
            this.gbOption.Controls.Add(this.panel2);
            this.gbOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOption.Location = new System.Drawing.Point(12, 40);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(144, 612);
            this.gbOption.TabIndex = 0;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Elements";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "AND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "OR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOR";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(11, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 5);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 58);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(56, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 45);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sink";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pbNor
            // 
            this.pbNor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbNor.BackgroundImage")));
            this.pbNor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbNor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNor.Location = new System.Drawing.Point(10, 219);
            this.pbNor.Name = "pbNor";
            this.pbNor.Size = new System.Drawing.Size(123, 52);
            this.pbNor.TabIndex = 7;
            this.pbNor.TabStop = false;
            // 
            // pbOr
            // 
            this.pbOr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOr.BackgroundImage")));
            this.pbOr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbOr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOr.Location = new System.Drawing.Point(10, 137);
            this.pbOr.Name = "pbOr";
            this.pbOr.Size = new System.Drawing.Size(123, 52);
            this.pbOr.TabIndex = 3;
            this.pbOr.TabStop = false;
            // 
            // pbAnd
            // 
            this.pbAnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAnd.BackgroundImage")));
            this.pbAnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAnd.Location = new System.Drawing.Point(10, 53);
            this.pbAnd.Name = "pbAnd";
            this.pbAnd.Size = new System.Drawing.Size(123, 52);
            this.pbAnd.TabIndex = 1;
            this.pbAnd.TabStop = false;
            this.pbAnd.Click += new System.EventHandler(this.pbAnd_Click);
            this.pbAnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAnd_MouseDown);
            this.pbAnd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbAnd_MouseMove);
            this.pbAnd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbAnd_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 58);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(56, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 45);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbWorkingPanel
            // 
            this.gbWorkingPanel.Controls.Add(this.pnlWorking);
            this.gbWorkingPanel.Location = new System.Drawing.Point(162, 40);
            this.gbWorkingPanel.Name = "gbWorkingPanel";
            this.gbWorkingPanel.Size = new System.Drawing.Size(629, 506);
            this.gbWorkingPanel.TabIndex = 1;
            this.gbWorkingPanel.TabStop = false;
            this.gbWorkingPanel.Text = "Working Panel";
            this.gbWorkingPanel.Enter += new System.EventHandler(this.gbWorkingPanel_Enter);
            // 
            // pnlWorking
            // 
            this.pnlWorking.BackColor = System.Drawing.Color.LightGray;
            this.pnlWorking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWorking.Controls.Add(this.source1);
            this.pnlWorking.Controls.Add(this.hScrollBar1);
            this.pnlWorking.Location = new System.Drawing.Point(6, 23);
            this.pnlWorking.Name = "pnlWorking";
            this.pnlWorking.Size = new System.Drawing.Size(614, 470);
            this.pnlWorking.TabIndex = 0;
            this.pnlWorking.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlWorking_MouseClick);
            this.pnlWorking.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlWorking_MouseDown);
            this.pnlWorking.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlWorking_MouseUp);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(2, 445);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(609, 21);
            this.hScrollBar1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 49);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 46);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(197, 46);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(197, 46);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(76, 45);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnEnable);
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.btnDelete);
            this.gbControl.Controls.Add(this.btnLine);
            this.gbControl.Controls.Add(this.button2);
            this.gbControl.Location = new System.Drawing.Point(162, 552);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(629, 100);
            this.gbControl.TabIndex = 14;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control Panel";
            // 
            // btnEnable
            // 
            this.btnEnable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnable.BackgroundImage")));
            this.btnEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnable.Enabled = false;
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.Location = new System.Drawing.Point(373, 42);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(115, 47);
            this.btnEnable.TabIndex = 11;
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Action";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(131, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 47);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLine.BackgroundImage")));
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Location = new System.Drawing.Point(10, 42);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(115, 47);
            this.btnLine.TabIndex = 15;
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(252, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // source1
            // 
            this.source1.BackColor = System.Drawing.Color.Gray;
            this.source1.Location = new System.Drawing.Point(68, 53);
            this.source1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.source1.Name = "source1";
            this.source1.Size = new System.Drawing.Size(50, 48);
            this.source1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 670);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbWorkingPanel);
            this.Controls.Add(this.gbOption);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbWorkingPanel.ResumeLayout(false);
            this.pnlWorking.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.PictureBox pbNor;
        private System.Windows.Forms.PictureBox pbAnd;
        private System.Windows.Forms.GroupBox gbWorkingPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlWorking;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbOr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Source source1;
    }
}

