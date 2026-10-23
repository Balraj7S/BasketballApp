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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            lblPlayerDetails = new Label();
            dGVSummary = new DataGridView();
            btnBack = new Button();
            btnAddnewPlayer = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVSummary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 10);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 2;
            label1.Text = "Basketball";
            // 
            // lblPlayerDetails
            // 
            lblPlayerDetails.AutoSize = true;
            lblPlayerDetails.Location = new Point(9, 45);
            lblPlayerDetails.Margin = new Padding(0);
            lblPlayerDetails.Name = "lblPlayerDetails";
            lblPlayerDetails.Size = new Size(77, 15);
            lblPlayerDetails.TabIndex = 4;
            lblPlayerDetails.Text = "Player Details";
            // 
            // dGVSummary
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGVSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGVSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dGVSummary.DefaultCellStyle = dataGridViewCellStyle2;
            dGVSummary.Location = new Point(113, 68);
            dGVSummary.Name = "dGVSummary";
            dGVSummary.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dGVSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dGVSummary.Size = new Size(646, 310);
            dGVSummary.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(32, 384);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(145, 62);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddnewPlayer
            // 
            btnAddnewPlayer.Location = new Point(662, 384);
            btnAddnewPlayer.Name = "btnAddnewPlayer";
            btnAddnewPlayer.Size = new Size(142, 62);
            btnAddnewPlayer.TabIndex = 7;
            btnAddnewPlayer.Text = "Add new Player";
            btnAddnewPlayer.UseVisualStyleBackColor = true;
            btnAddnewPlayer.Click += btnAddnewPlayer_Click;
            // 
            // Finish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(btnAddnewPlayer);
            Controls.Add(btnBack);
            Controls.Add(dGVSummary);
            Controls.Add(lblPlayerDetails);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(0, 5, 0, 5);
            Name = "Finish";
            Text = "Finish";
            Load += Finish_Load;
            ((System.ComponentModel.ISupportInitialize)dGVSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPlayerDetails;
        private DataGridView dGVSummary;
        private Button btnBack;
        private Button btnAddnewPlayer;
    }
}