namespace AppleBot
{
    partial class UCPhone
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
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbJs = new System.Windows.Forms.TextBox();
            this.btnCopyClipBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(0, 0);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(234, 20);
            this.tbDesc.TabIndex = 0;
            // 
            // tbJs
            // 
            this.tbJs.Location = new System.Drawing.Point(240, 0);
            this.tbJs.Multiline = true;
            this.tbJs.Name = "tbJs";
            this.tbJs.Size = new System.Drawing.Size(341, 20);
            this.tbJs.TabIndex = 1;
            // 
            // btnCopyClipBoard
            // 
            this.btnCopyClipBoard.Location = new System.Drawing.Point(583, 0);
            this.btnCopyClipBoard.Name = "btnCopyClipBoard";
            this.btnCopyClipBoard.Size = new System.Drawing.Size(75, 23);
            this.btnCopyClipBoard.TabIndex = 2;
            this.btnCopyClipBoard.Text = "Copy";
            this.btnCopyClipBoard.UseVisualStyleBackColor = true;
            this.btnCopyClipBoard.Click += new System.EventHandler(this.btnCopyClipBoard_Click);
            // 
            // UCPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopyClipBoard);
            this.Controls.Add(this.tbJs);
            this.Controls.Add(this.tbDesc);
            this.Name = "UCPhone";
            this.Size = new System.Drawing.Size(672, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbDesc;
        public System.Windows.Forms.TextBox tbJs;
        public System.Windows.Forms.Button btnCopyClipBoard;
    }
}
