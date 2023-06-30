namespace x_o_Form
{
    partial class WinnerScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.WScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22.25455F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose The Winner Score 😉";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WScore
            // 
            this.WScore.BackColor = System.Drawing.Color.Transparent;
            this.WScore.Font = new System.Drawing.Font("Segoe Print", 22.25455F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WScore.Location = new System.Drawing.Point(270, 204);
            this.WScore.Name = "WScore";
            this.WScore.Size = new System.Drawing.Size(60, 60);
            this.WScore.TabIndex = 3;
            this.WScore.Text = "1";
            this.WScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(240, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "Done";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 22.25455F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(360, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Increase_Click);
            // 
            // Increase
            // 
            this.Increase.BackColor = System.Drawing.Color.Transparent;
            this.Increase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Increase.FlatAppearance.BorderSize = 0;
            this.Increase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Increase.Font = new System.Drawing.Font("Segoe Print", 22.25455F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Increase.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Increase.Location = new System.Drawing.Point(180, 200);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(60, 69);
            this.Increase.TabIndex = 6;
            this.Increase.Text = "<";
            this.Increase.UseVisualStyleBackColor = false;
            this.Increase.Click += new System.EventHandler(this.Descrease_Click);
            // 
            // WinnerScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::x_o_Form.Properties.Resources.wallpaperflare_com_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 389);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WScore);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "WinnerScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinnerScore";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label WScore;
        private Label label2;
        private Button button1;
        private Button Increase;
    }
}