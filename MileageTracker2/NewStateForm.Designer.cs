namespace MileageTracker2
{
    partial class NewStateForm
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
            this.createStateButton = new System.Windows.Forms.Button();
            this.stateNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createStateButton
            // 
            this.createStateButton.Location = new System.Drawing.Point(78, 89);
            this.createStateButton.Name = "createStateButton";
            this.createStateButton.Size = new System.Drawing.Size(161, 23);
            this.createStateButton.TabIndex = 1;
            this.createStateButton.Text = "Create New State";
            this.createStateButton.UseVisualStyleBackColor = true;
            this.createStateButton.Click += new System.EventHandler(this.createStateButton_Click);
            // 
            // stateNameComboBox
            // 
            this.stateNameComboBox.FormattingEnabled = true;
            this.stateNameComboBox.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Deleware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina ",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.stateNameComboBox.Location = new System.Drawing.Point(96, 37);
            this.stateNameComboBox.Name = "stateNameComboBox";
            this.stateNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateNameComboBox.TabIndex = 3;
            // 
            // NewStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 197);
            this.Controls.Add(this.stateNameComboBox);
            this.Controls.Add(this.createStateButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewStateForm";
            this.Text = "Choose a State";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createStateButton;
        private System.Windows.Forms.ComboBox stateNameComboBox;
    }
}