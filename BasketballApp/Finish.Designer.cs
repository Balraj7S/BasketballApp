namespace BasketballApp
{
    partial class Finish
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
            label1 = new Label();
            rtbPlayerDetails = new RichTextBox();
            lblPlayerDetails = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 10);
            label1.Margin = new Padding(0, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 2;
            label1.Text = "Basketball";
            // 
            // rtbPlayerDetails
            // 
            rtbPlayerDetails.Location = new Point(14, 100);
            rtbPlayerDetails.Margin = new Padding(0, 5, 0, 5);
            rtbPlayerDetails.Name = "rtbPlayerDetails";
            rtbPlayerDetails.Size = new Size(774, 319);
            rtbPlayerDetails.TabIndex = 3;
            rtbPlayerDetails.Text = "";
            // 
            // lblPlayerDetails
            // 
            lblPlayerDetails.AutoSize = true;
            lblPlayerDetails.Location = new Point(21, 65);
            lblPlayerDetails.Margin = new Padding(0, 0, 0, 0);
            lblPlayerDetails.Name = "lblPlayerDetails";
            lblPlayerDetails.Size = new Size(77, 15);
            lblPlayerDetails.TabIndex = 4;
            lblPlayerDetails.Text = "Player Details";
            // 
            // Finish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(lblPlayerDetails);
            Controls.Add(rtbPlayerDetails);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(0, 5, 0, 5);
            Name = "Finish";
            Text = "Finish";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbPlayerDetails;
        private Label lblPlayerDetails;
    }
}