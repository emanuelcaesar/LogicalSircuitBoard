namespace LogicalSircuitBoard
{
    partial class Source
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Location = new System.Drawing.Point(23, 5);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(0, 32);
            this.value.TabIndex = 0;
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.value);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Source";
            this.Size = new System.Drawing.Size(50, 48);
            this.Load += new System.EventHandler(this.Source_Load);
            this.Click += new System.EventHandler(this.Source_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label value;
    }
}
