namespace HowToUseControls
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exampleButton = new Button();
            homeButton = new Button();
            settingsButton = new Button();
            exampleControl = new Controls.ExampleControl();
            homeControl = new Controls.HomeControl();
            settingsControl = new Controls.SettingsControl();
            SuspendLayout();
            // 
            // exampleButton
            // 
            exampleButton.Location = new Point(12, 12);
            exampleButton.Name = "exampleButton";
            exampleButton.Size = new Size(94, 29);
            exampleButton.TabIndex = 0;
            exampleButton.Text = "Example";
            exampleButton.UseVisualStyleBackColor = true;
            exampleButton.Click += exampleButton_Click;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(12, 47);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(94, 29);
            homeButton.TabIndex = 1;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(12, 82);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(94, 29);
            settingsButton.TabIndex = 2;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // exampleControl
            // 
            exampleControl.Location = new Point(112, 10);
            exampleControl.Name = "exampleControl";
            exampleControl.Size = new Size(1010, 589);
            exampleControl.TabIndex = 3;
            // 
            // homeControl
            // 
            homeControl.Location = new Point(112, 12);
            homeControl.Name = "homeControl";
            homeControl.Size = new Size(1010, 589);
            homeControl.TabIndex = 4;
            // 
            // settingsControl
            // 
            settingsControl.Location = new Point(112, 12);
            settingsControl.Name = "settingsControl";
            settingsControl.Size = new Size(1010, 589);
            settingsControl.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 611);
            Controls.Add(exampleControl);
            Controls.Add(settingsButton);
            Controls.Add(homeButton);
            Controls.Add(exampleButton);
            Controls.Add(settingsControl);
            Controls.Add(homeControl);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button exampleButton;
        private Button homeButton;
        private Button settingsButton;
        private Controls.ExampleControl exampleControl;
        private Controls.HomeControl homeControl;
        private Controls.SettingsControl settingsControl;
    }
}
