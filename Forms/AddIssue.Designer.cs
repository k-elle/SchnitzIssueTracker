namespace SchnitzIssueTracker.Forms
{
    partial class AddIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIssue));
            groupBox1 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            valueSelection = new NumericUpDown();
            label10 = new Label();
            editUsersButton = new Button();
            actionExplanationBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            actionTakenCombo = new ComboBox();
            label6 = new Label();
            orderReferenceBox = new TextBox();
            label5 = new Label();
            dateAddedPicker = new DateTimePicker();
            issueExplanationBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            customerNameBox = new TextBox();
            customerPhoneBox = new TextBox();
            label1 = new Label();
            userSelectionCombo = new ComboBox();
            addIssueButton = new Button();
            closeButton = new Button();
            userHelp = new Label();
            label14 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valueSelection).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(valueSelection);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(editUsersButton);
            groupBox1.Controls.Add(actionExplanationBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(actionTakenCombo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(orderReferenceBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateAddedPicker);
            groupBox1.Controls.Add(issueExplanationBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(customerNameBox);
            groupBox1.Controls.Add(customerPhoneBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(userSelectionCombo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Issue";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(508, 63);
            label13.Name = "label13";
            label13.Size = new Size(12, 15);
            label13.TabIndex = 21;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(38, 19);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 20;
            label12.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(238, 19);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 4;
            label11.Text = "*";
            // 
            // valueSelection
            // 
            valueSelection.DecimalPlaces = 2;
            valueSelection.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            valueSelection.Location = new Point(475, 125);
            valueSelection.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            valueSelection.Name = "valueSelection";
            valueSelection.Size = new Size(119, 23);
            valueSelection.TabIndex = 8;
            valueSelection.ThousandsSeparator = true;
            valueSelection.ValueChanged += CheckValidity;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(464, 127);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 19;
            label10.Text = "$";
            // 
            // editUsersButton
            // 
            editUsersButton.Location = new Point(6, 80);
            editUsersButton.Name = "editUsersButton";
            editUsersButton.Size = new Size(130, 23);
            editUsersButton.TabIndex = 18;
            editUsersButton.TabStop = false;
            editUsersButton.Text = "Edit Users";
            editUsersButton.UseVisualStyleBackColor = true;
            editUsersButton.Click += editUsersButton_Click;
            // 
            // actionExplanationBox
            // 
            actionExplanationBox.Location = new Point(600, 37);
            actionExplanationBox.Multiline = true;
            actionExplanationBox.Name = "actionExplanationBox";
            actionExplanationBox.ScrollBars = ScrollBars.Vertical;
            actionExplanationBox.Size = new Size(180, 111);
            actionExplanationBox.TabIndex = 9;
            actionExplanationBox.TextChanged += CheckValidity;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(600, 19);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 16;
            label9.Text = "Action Explanation:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(464, 107);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "Value:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 63);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 13;
            label7.Text = "Action:  *";
            // 
            // actionTakenCombo
            // 
            actionTakenCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            actionTakenCombo.FormattingEnabled = true;
            actionTakenCombo.Items.AddRange(new object[] { "Refund", "Remake", "TBD" });
            actionTakenCombo.Location = new Point(464, 81);
            actionTakenCombo.Name = "actionTakenCombo";
            actionTakenCombo.Size = new Size(130, 23);
            actionTakenCombo.TabIndex = 7;
            actionTakenCombo.SelectedValueChanged += CheckValidity;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 107);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 11;
            label6.Text = "Order Reference:";
            // 
            // orderReferenceBox
            // 
            orderReferenceBox.Location = new Point(142, 125);
            orderReferenceBox.Name = "orderReferenceBox";
            orderReferenceBox.Size = new Size(130, 23);
            orderReferenceBox.TabIndex = 4;
            orderReferenceBox.TextChanged += CheckValidity;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 19);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "Date:";
            // 
            // dateAddedPicker
            // 
            dateAddedPicker.CustomFormat = " dd/MM/yyyy";
            dateAddedPicker.Format = DateTimePickerFormat.Custom;
            dateAddedPicker.Location = new Point(464, 37);
            dateAddedPicker.Name = "dateAddedPicker";
            dateAddedPicker.Size = new Size(130, 23);
            dateAddedPicker.TabIndex = 6;
            dateAddedPicker.ValueChanged += CheckValidity;
            // 
            // issueExplanationBox
            // 
            issueExplanationBox.Location = new Point(278, 37);
            issueExplanationBox.Multiline = true;
            issueExplanationBox.Name = "issueExplanationBox";
            issueExplanationBox.ScrollBars = ScrollBars.Vertical;
            issueExplanationBox.Size = new Size(180, 111);
            issueExplanationBox.TabIndex = 5;
            issueExplanationBox.TextChanged += CheckValidity;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 19);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 6;
            label4.Text = "Issue Explanation:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 63);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Customer Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 19);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 4;
            label2.Text = "Customer Name:  *";
            // 
            // customerNameBox
            // 
            customerNameBox.Location = new Point(142, 37);
            customerNameBox.Name = "customerNameBox";
            customerNameBox.Size = new Size(130, 23);
            customerNameBox.TabIndex = 2;
            customerNameBox.TextChanged += CheckValidity;
            // 
            // customerPhoneBox
            // 
            customerPhoneBox.Location = new Point(142, 81);
            customerPhoneBox.Name = "customerPhoneBox";
            customerPhoneBox.Size = new Size(130, 23);
            customerPhoneBox.TabIndex = 3;
            customerPhoneBox.TextChanged += CheckValidity;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "User:  *";
            // 
            // userSelectionCombo
            // 
            userSelectionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            userSelectionCombo.FormattingEnabled = true;
            userSelectionCombo.Location = new Point(6, 37);
            userSelectionCombo.Name = "userSelectionCombo";
            userSelectionCombo.Size = new Size(130, 23);
            userSelectionCombo.TabIndex = 1;
            userSelectionCombo.SelectedValueChanged += CheckValidity;
            // 
            // addIssueButton
            // 
            addIssueButton.Enabled = false;
            addIssueButton.Location = new Point(280, 177);
            addIssueButton.Name = "addIssueButton";
            addIssueButton.Size = new Size(130, 23);
            addIssueButton.TabIndex = 10;
            addIssueButton.Text = "Add Issue";
            addIssueButton.UseVisualStyleBackColor = true;
            addIssueButton.Click += addIssueButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(416, 177);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(130, 23);
            closeButton.TabIndex = 10;
            closeButton.TabStop = false;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // userHelp
            // 
            userHelp.AutoSize = true;
            userHelp.Location = new Point(18, 181);
            userHelp.Name = "userHelp";
            userHelp.Size = new Size(183, 15);
            userHelp.TabIndex = 3;
            userHelp.Text = "Fields marked with * are required.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(119, 181);
            label14.Name = "label14";
            label14.Size = new Size(12, 15);
            label14.TabIndex = 5;
            label14.Text = "*";
            // 
            // AddIssue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 214);
            Controls.Add(label14);
            Controls.Add(userHelp);
            Controls.Add(closeButton);
            Controls.Add(addIssueButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddIssue";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Issue";
            Load += AddIssue_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)valueSelection).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox issueExplanationBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox customerNameBox;
        private TextBox customerPhoneBox;
        private Label label1;
        private ComboBox userSelectionCombo;
        private Label label6;
        private TextBox orderReferenceBox;
        private Label label5;
        private DateTimePicker dateAddedPicker;
        private TextBox actionExplanationBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox actionTakenCombo;
        private Button editUsersButton;
        private Button addIssueButton;
        private Button closeButton;
        private Label userHelp;
        private NumericUpDown valueSelection;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
    }
}