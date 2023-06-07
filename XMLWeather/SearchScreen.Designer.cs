namespace XMLWeather
{
    partial class SearchScreen
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
            this.currentForecast = new System.Windows.Forms.Label();
            this.weeklyForecast = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.intructionLabel = new System.Windows.Forms.Label();
            this.suggestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentForecast
            // 
            this.currentForecast.BackColor = System.Drawing.Color.Transparent;
            this.currentForecast.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentForecast.ForeColor = System.Drawing.Color.White;
            this.currentForecast.Location = new System.Drawing.Point(319, 13);
            this.currentForecast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentForecast.Name = "currentForecast";
            this.currentForecast.Size = new System.Drawing.Size(77, 34);
            this.currentForecast.TabIndex = 71;
            this.currentForecast.Text = "Today";
            this.currentForecast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentForecast.Click += new System.EventHandler(this.currentForecast_Click);
            // 
            // weeklyForecast
            // 
            this.weeklyForecast.BackColor = System.Drawing.Color.Transparent;
            this.weeklyForecast.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyForecast.ForeColor = System.Drawing.Color.White;
            this.weeklyForecast.Location = new System.Drawing.Point(319, 47);
            this.weeklyForecast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weeklyForecast.Name = "weeklyForecast";
            this.weeklyForecast.Size = new System.Drawing.Size(77, 34);
            this.weeklyForecast.TabIndex = 72;
            this.weeklyForecast.Text = "5 Day";
            this.weeklyForecast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weeklyForecast.Click += new System.EventHandler(this.weeklyForecast_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(315, 81);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(85, 34);
            this.searchLabel.TabIndex = 73;
            this.searchLabel.Text = "Search";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(13, 194);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(273, 31);
            this.inputBox.TabIndex = 74;
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.Color.RosyBrown;
            this.errorLabel.Location = new System.Drawing.Point(12, 238);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(318, 29);
            this.errorLabel.TabIndex = 75;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(292, 192);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 34);
            this.searchButton.TabIndex = 76;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // intructionLabel
            // 
            this.intructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.intructionLabel.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold);
            this.intructionLabel.ForeColor = System.Drawing.Color.White;
            this.intructionLabel.Location = new System.Drawing.Point(12, 158);
            this.intructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intructionLabel.Name = "intructionLabel";
            this.intructionLabel.Size = new System.Drawing.Size(318, 34);
            this.intructionLabel.TabIndex = 77;
            this.intructionLabel.Text = "Type in any Country or City";
            this.intructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // suggestLabel
            // 
            this.suggestLabel.BackColor = System.Drawing.Color.Transparent;
            this.suggestLabel.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold);
            this.suggestLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.suggestLabel.Location = new System.Drawing.Point(12, 232);
            this.suggestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.suggestLabel.Name = "suggestLabel";
            this.suggestLabel.Size = new System.Drawing.Size(318, 179);
            this.suggestLabel.TabIndex = 78;
            this.suggestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.suggestLabel);
            this.Controls.Add(this.intructionLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.weeklyForecast);
            this.Controls.Add(this.currentForecast);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(400, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentForecast;
        private System.Windows.Forms.Label weeklyForecast;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label intructionLabel;
        private System.Windows.Forms.Label suggestLabel;
    }
}
