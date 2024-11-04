namespace SchnitzIssueTracker.Forms
{
    partial class ResolveIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResolveIssue));
            groupBox1 = new GroupBox();
            label4 = new Label();
            actionReselectBox = new ComboBox();
            editUsersButton = new Button();
            resolutionExplanationBox = new TextBox();
            dateResolvedPicker = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            userSelectionCombo = new ComboBox();
            resolveIssueButton = new Button();
            closeButton = new Button();
            groupBox2 = new GroupBox();
            valueBox = new TextBox();
            dateAddedBox = new TextBox();
            userAddedBox = new TextBox();
            label13 = new Label();
            issueExplanationBox = new TextBox();
            customerPhoneBox = new TextBox();
            actionExplanationBox = new TextBox();
            customerNameBox = new TextBox();
            label9 = new Label();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            label6 = new Label();
            label7 = new Label();
            orderReferenceBox = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(actionReselectBox);
            groupBox1.Controls.Add(editUsersButton);
            groupBox1.Controls.Add(resolutionExplanationBox);
            groupBox1.Controls.Add(dateResolvedPicker);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(userSelectionCombo);
            groupBox1.Location = new Point(12, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mark Issue as Resolved";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 38);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 14;
            label4.Text = "Modify Action:";
            // 
            // actionReselectBox
            // 
            actionReselectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            actionReselectBox.FormattingEnabled = true;
            actionReselectBox.Items.AddRange(new object[] { "Refund", "Remake", "Other" });
            actionReselectBox.Location = new Point(142, 56);
            actionReselectBox.Name = "actionReselectBox";
            actionReselectBox.Size = new Size(130, 23);
            actionReselectBox.TabIndex = 2;
            actionReselectBox.SelectedValueChanged += CheckValidity;
            // 
            // editUsersButton
            // 
            editUsersButton.Location = new Point(6, 100);
            editUsersButton.Name = "editUsersButton";
            editUsersButton.Size = new Size(130, 23);
            editUsersButton.TabIndex = 12;
            editUsersButton.TabStop = false;
            editUsersButton.Text = "Edit Users";
            editUsersButton.UseVisualStyleBackColor = true;
            editUsersButton.Click += editUsersButton_Click;
            // 
            // resolutionExplanationBox
            // 
            resolutionExplanationBox.Location = new Point(278, 37);
            resolutionExplanationBox.Multiline = true;
            resolutionExplanationBox.Name = "resolutionExplanationBox";
            resolutionExplanationBox.ScrollBars = ScrollBars.Vertical;
            resolutionExplanationBox.Size = new Size(180, 111);
            resolutionExplanationBox.TabIndex = 4;
            // 
            // dateResolvedPicker
            // 
            dateResolvedPicker.CustomFormat = " dd/MM/yyyy";
            dateResolvedPicker.Format = DateTimePickerFormat.Custom;
            dateResolvedPicker.Location = new Point(142, 100);
            dateResolvedPicker.Name = "dateResolvedPicker";
            dateResolvedPicker.Size = new Size(130, 23);
            dateResolvedPicker.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 19);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 4;
            label2.Text = "Resolution Explanation:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "User:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 82);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 6;
            label3.Text = "Date:";
            // 
            // userSelectionCombo
            // 
            userSelectionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            userSelectionCombo.FormattingEnabled = true;
            userSelectionCombo.Location = new Point(6, 56);
            userSelectionCombo.Name = "userSelectionCombo";
            userSelectionCombo.Size = new Size(130, 23);
            userSelectionCombo.TabIndex = 1;
            userSelectionCombo.SelectedValueChanged += CheckValidity;
            // 
            // resolveIssueButton
            // 
            resolveIssueButton.Enabled = false;
            resolveIssueButton.Location = new Point(510, 215);
            resolveIssueButton.Name = "resolveIssueButton";
            resolveIssueButton.Size = new Size(130, 23);
            resolveIssueButton.TabIndex = 5;
            resolveIssueButton.Text = "Resolve Issue";
            resolveIssueButton.UseVisualStyleBackColor = true;
            resolveIssueButton.Click += resolveIssueButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(510, 259);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(130, 23);
            closeButton.TabIndex = 11;
            closeButton.TabStop = false;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(valueBox);
            groupBox2.Controls.Add(dateAddedBox);
            groupBox2.Controls.Add(userAddedBox);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(issueExplanationBox);
            groupBox2.Controls.Add(customerPhoneBox);
            groupBox2.Controls.Add(actionExplanationBox);
            groupBox2.Controls.Add(customerNameBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(orderReferenceBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(651, 155);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Issue Details";
            // 
            // valueBox
            // 
            valueBox.Location = new Point(328, 125);
            valueBox.Name = "valueBox";
            valueBox.ReadOnly = true;
            valueBox.Size = new Size(130, 23);
            valueBox.TabIndex = 38;
            valueBox.TabStop = false;
            // 
            // dateAddedBox
            // 
            dateAddedBox.Location = new Point(328, 81);
            dateAddedBox.Name = "dateAddedBox";
            dateAddedBox.ReadOnly = true;
            dateAddedBox.Size = new Size(130, 23);
            dateAddedBox.TabIndex = 37;
            dateAddedBox.TabStop = false;
            // 
            // userAddedBox
            // 
            userAddedBox.Location = new Point(328, 37);
            userAddedBox.Name = "userAddedBox";
            userAddedBox.ReadOnly = true;
            userAddedBox.Size = new Size(130, 23);
            userAddedBox.TabIndex = 35;
            userAddedBox.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(328, 19);
            label13.Name = "label13";
            label13.Size = new Size(71, 15);
            label13.TabIndex = 36;
            label13.Text = "User Added:";
            // 
            // issueExplanationBox
            // 
            issueExplanationBox.Location = new Point(142, 37);
            issueExplanationBox.Multiline = true;
            issueExplanationBox.Name = "issueExplanationBox";
            issueExplanationBox.ReadOnly = true;
            issueExplanationBox.ScrollBars = ScrollBars.Vertical;
            issueExplanationBox.Size = new Size(180, 111);
            issueExplanationBox.TabIndex = 24;
            issueExplanationBox.TabStop = false;
            // 
            // customerPhoneBox
            // 
            customerPhoneBox.Location = new Point(6, 81);
            customerPhoneBox.Name = "customerPhoneBox";
            customerPhoneBox.ReadOnly = true;
            customerPhoneBox.Size = new Size(130, 23);
            customerPhoneBox.TabIndex = 21;
            customerPhoneBox.TabStop = false;
            // 
            // actionExplanationBox
            // 
            actionExplanationBox.Location = new Point(464, 37);
            actionExplanationBox.Multiline = true;
            actionExplanationBox.Name = "actionExplanationBox";
            actionExplanationBox.ReadOnly = true;
            actionExplanationBox.ScrollBars = ScrollBars.Vertical;
            actionExplanationBox.Size = new Size(180, 111);
            actionExplanationBox.TabIndex = 29;
            actionExplanationBox.TabStop = false;
            // 
            // customerNameBox
            // 
            customerNameBox.Location = new Point(6, 37);
            customerNameBox.Name = "customerNameBox";
            customerNameBox.ReadOnly = true;
            customerNameBox.Size = new Size(130, 23);
            customerNameBox.TabIndex = 20;
            customerNameBox.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(464, 19);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 33;
            label9.Text = "Action Explanation:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 19);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 23;
            label12.Text = "Customer Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(328, 107);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 32;
            label8.Text = "Value:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 63);
            label11.Name = "label11";
            label11.Size = new Size(99, 15);
            label11.TabIndex = 25;
            label11.Text = "Customer Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 107);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 31;
            label6.Text = "Order Reference:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(142, 19);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 27;
            label7.Text = "Issue Explanation:";
            // 
            // orderReferenceBox
            // 
            orderReferenceBox.Location = new Point(6, 125);
            orderReferenceBox.Name = "orderReferenceBox";
            orderReferenceBox.ReadOnly = true;
            orderReferenceBox.Size = new Size(130, 23);
            orderReferenceBox.TabIndex = 22;
            orderReferenceBox.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 63);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 30;
            label5.Text = "Date:";
            // 
            // ResolveIssue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 339);
            Controls.Add(groupBox2);
            Controls.Add(closeButton);
            Controls.Add(resolveIssueButton);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResolveIssue";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Resolve Issue";
            Load += ResolveIssue_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox userSelectionCombo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox resolutionExplanationBox;
        private DateTimePicker dateResolvedPicker;
        private Button closeButton;
        private Button resolveIssueButton;
        private Button editUsersButton;
        private ComboBox actionReselectBox;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox userAddedBox;
        private Label label13;
        private TextBox issueExplanationBox;
        private TextBox customerPhoneBox;
        private TextBox actionExplanationBox;
        private TextBox customerNameBox;
        private Label label9;
        private Label label12;
        private Label label8;
        private Label label11;
        private Label label6;
        private Label label7;
        private TextBox orderReferenceBox;
        private Label label5;
        private TextBox valueBox;
        private TextBox dateAddedBox;
    }
}