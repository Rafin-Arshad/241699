namespace MyWinArrayApp
{
    partial class ArrayOperation
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
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(13, 58);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(580, 305);
            this.showRichTextBox.TabIndex = 0;
            this.showRichTextBox.Text = "";
            // 
            // ArrayOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showRichTextBox);
            this.Name = "ArrayOperation";
            this.Text = "ArrayOperation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox showRichTextBox;
    }
}