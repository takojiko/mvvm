namespace AndersonMvvm.Views
{
    partial class MainView
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
            this.AAALabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.BBBTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.CCCDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DDDCheckBox = new System.Windows.Forms.CheckBox();
            this.EEEComboBox = new System.Windows.Forms.ComboBox();
            this.MyDataGrid = new System.Windows.Forms.DataGridView();
            this.UpdateAsyncButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SubViewShowButton = new System.Windows.Forms.Button();
            this.BRadioButton = new AndersonMvvm.BindHelpers.BindableRadioButton();
            this.ARadioButton = new AndersonMvvm.BindHelpers.BindableRadioButton();
            this.ProgressManualButton = new System.Windows.Forms.Button();
            this.ProgressAutoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AAALabel
            // 
            this.AAALabel.AutoSize = true;
            this.AAALabel.Location = new System.Drawing.Point(36, 26);
            this.AAALabel.Name = "AAALabel";
            this.AAALabel.Size = new System.Drawing.Size(35, 12);
            this.AAALabel.TabIndex = 0;
            this.AAALabel.Text = "label1";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(142, 21);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(96, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // BBBTextBox
            // 
            this.BBBTextBox.Location = new System.Drawing.Point(38, 75);
            this.BBBTextBox.Name = "BBBTextBox";
            this.BBBTextBox.Size = new System.Drawing.Size(100, 19);
            this.BBBTextBox.TabIndex = 2;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(266, 21);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 3;
            this.CheckButton.Text = "check";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // CCCDateTimePicker
            // 
            this.CCCDateTimePicker.Location = new System.Drawing.Point(38, 120);
            this.CCCDateTimePicker.Name = "CCCDateTimePicker";
            this.CCCDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.CCCDateTimePicker.TabIndex = 4;
            // 
            // DDDCheckBox
            // 
            this.DDDCheckBox.AutoSize = true;
            this.DDDCheckBox.Location = new System.Drawing.Point(38, 163);
            this.DDDCheckBox.Name = "DDDCheckBox";
            this.DDDCheckBox.Size = new System.Drawing.Size(80, 16);
            this.DDDCheckBox.TabIndex = 5;
            this.DDDCheckBox.Text = "checkBox1";
            this.DDDCheckBox.UseVisualStyleBackColor = true;
            // 
            // EEEComboBox
            // 
            this.EEEComboBox.FormattingEnabled = true;
            this.EEEComboBox.Location = new System.Drawing.Point(38, 261);
            this.EEEComboBox.Name = "EEEComboBox";
            this.EEEComboBox.Size = new System.Drawing.Size(121, 20);
            this.EEEComboBox.TabIndex = 9;
            // 
            // MyDataGrid
            // 
            this.MyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataGrid.Location = new System.Drawing.Point(266, 63);
            this.MyDataGrid.Name = "MyDataGrid";
            this.MyDataGrid.RowTemplate.Height = 21;
            this.MyDataGrid.Size = new System.Drawing.Size(240, 150);
            this.MyDataGrid.TabIndex = 10;
            // 
            // UpdateAsyncButton
            // 
            this.UpdateAsyncButton.Location = new System.Drawing.Point(142, 50);
            this.UpdateAsyncButton.Name = "UpdateAsyncButton";
            this.UpdateAsyncButton.Size = new System.Drawing.Size(96, 23);
            this.UpdateAsyncButton.TabIndex = 11;
            this.UpdateAsyncButton.Text = "update async";
            this.UpdateAsyncButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(38, 287);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SubViewShowButton
            // 
            this.SubViewShowButton.Location = new System.Drawing.Point(266, 287);
            this.SubViewShowButton.Name = "SubViewShowButton";
            this.SubViewShowButton.Size = new System.Drawing.Size(96, 23);
            this.SubViewShowButton.TabIndex = 13;
            this.SubViewShowButton.Text = "show";
            this.SubViewShowButton.UseVisualStyleBackColor = true;
            // 
            // BRadioButton
            // 
            this.BRadioButton.AutoCheck = false;
            this.BRadioButton.AutoSize = true;
            this.BRadioButton.Location = new System.Drawing.Point(38, 228);
            this.BRadioButton.Name = "BRadioButton";
            this.BRadioButton.Size = new System.Drawing.Size(134, 16);
            this.BRadioButton.TabIndex = 8;
            this.BRadioButton.TabStop = true;
            this.BRadioButton.Text = "bindableRadioButton2";
            this.BRadioButton.UseVisualStyleBackColor = true;
            // 
            // ARadioButton
            // 
            this.ARadioButton.AutoCheck = false;
            this.ARadioButton.AutoSize = true;
            this.ARadioButton.Location = new System.Drawing.Point(38, 197);
            this.ARadioButton.Name = "ARadioButton";
            this.ARadioButton.Size = new System.Drawing.Size(134, 16);
            this.ARadioButton.TabIndex = 7;
            this.ARadioButton.TabStop = true;
            this.ARadioButton.Text = "bindableRadioButton1";
            this.ARadioButton.UseVisualStyleBackColor = true;
            // 
            // ProgressManualButton
            // 
            this.ProgressManualButton.Location = new System.Drawing.Point(384, 228);
            this.ProgressManualButton.Name = "ProgressManualButton";
            this.ProgressManualButton.Size = new System.Drawing.Size(96, 23);
            this.ProgressManualButton.TabIndex = 15;
            this.ProgressManualButton.Text = "Progress手動";
            this.ProgressManualButton.UseVisualStyleBackColor = true;
            // 
            // ProgressAutoButton
            // 
            this.ProgressAutoButton.Location = new System.Drawing.Point(384, 257);
            this.ProgressAutoButton.Name = "ProgressAutoButton";
            this.ProgressAutoButton.Size = new System.Drawing.Size(96, 23);
            this.ProgressAutoButton.TabIndex = 16;
            this.ProgressAutoButton.Text = "Progress自動";
            this.ProgressAutoButton.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 339);
            this.Controls.Add(this.ProgressAutoButton);
            this.Controls.Add(this.ProgressManualButton);
            this.Controls.Add(this.SubViewShowButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UpdateAsyncButton);
            this.Controls.Add(this.MyDataGrid);
            this.Controls.Add(this.EEEComboBox);
            this.Controls.Add(this.BRadioButton);
            this.Controls.Add(this.ARadioButton);
            this.Controls.Add(this.DDDCheckBox);
            this.Controls.Add(this.CCCDateTimePicker);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.BBBTextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AAALabel);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AAALabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox BBBTextBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.DateTimePicker CCCDateTimePicker;
        private System.Windows.Forms.CheckBox DDDCheckBox;
        private BindHelpers.BindableRadioButton BRadioButton;
        private BindHelpers.BindableRadioButton ARadioButton;
        private System.Windows.Forms.ComboBox EEEComboBox;
        private System.Windows.Forms.DataGridView MyDataGrid;
        private System.Windows.Forms.Button UpdateAsyncButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SubViewShowButton;
        private System.Windows.Forms.Button ProgressManualButton;
        private System.Windows.Forms.Button ProgressAutoButton;
    }
}