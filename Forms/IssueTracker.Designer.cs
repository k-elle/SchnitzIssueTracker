namespace SchnitzIssueTracker.Forms
{
    partial class IssueTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueTracker));
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nameSearchBox = new TextBox();
            referenceSearchBox = new TextBox();
            phoneSearchBox = new TextBox();
            groupBox5 = new GroupBox();
            dateFilterAfterRadio = new RadioButton();
            dateFilterCheckbox = new CheckBox();
            dateFilterOnRadio = new RadioButton();
            userFilterCheckbox = new CheckBox();
            dateFilterBeforeRadio = new RadioButton();
            dateFilterPicker = new DateTimePicker();
            userFilterCombo = new ComboBox();
            groupBox4 = new GroupBox();
            refundActionCheckbox = new CheckBox();
            remakeActionCheckbox = new CheckBox();
            tbdActionCheckbox = new CheckBox();
            groupBox3 = new GroupBox();
            unresolvedStatusCheckbox = new CheckBox();
            resolvedStatusCheckbox = new CheckBox();
            resolveIssueButton = new Button();
            addIssueButton = new Button();
            groupBox2 = new GroupBox();
            dataView = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(resolveIssueButton);
            groupBox1.Controls.Add(addIssueButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 172);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(nameSearchBox);
            groupBox6.Controls.Add(referenceSearchBox);
            groupBox6.Controls.Add(phoneSearchBox);
            groupBox6.Location = new Point(6, 100);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(927, 66);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(620, 19);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 9;
            label3.Text = "By Order Reference/Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 19);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "By Phone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 5;
            label1.Text = "By Name:";
            // 
            // nameSearchBox
            // 
            nameSearchBox.Location = new Point(6, 37);
            nameSearchBox.Name = "nameSearchBox";
            nameSearchBox.Size = new Size(301, 23);
            nameSearchBox.TabIndex = 15;
            nameSearchBox.TextChanged += UpdateFilter;
            // 
            // referenceSearchBox
            // 
            referenceSearchBox.Location = new Point(620, 37);
            referenceSearchBox.Name = "referenceSearchBox";
            referenceSearchBox.Size = new Size(301, 23);
            referenceSearchBox.TabIndex = 17;
            referenceSearchBox.TextChanged += UpdateFilter;
            // 
            // phoneSearchBox
            // 
            phoneSearchBox.Location = new Point(313, 37);
            phoneSearchBox.Name = "phoneSearchBox";
            phoneSearchBox.Size = new Size(301, 23);
            phoneSearchBox.TabIndex = 16;
            phoneSearchBox.TextChanged += UpdateFilter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dateFilterAfterRadio);
            groupBox5.Controls.Add(dateFilterCheckbox);
            groupBox5.Controls.Add(dateFilterOnRadio);
            groupBox5.Controls.Add(userFilterCheckbox);
            groupBox5.Controls.Add(dateFilterBeforeRadio);
            groupBox5.Controls.Add(dateFilterPicker);
            groupBox5.Controls.Add(userFilterCombo);
            groupBox5.Location = new Point(544, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(389, 87);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Filter";
            // 
            // dateFilterAfterRadio
            // 
            dateFilterAfterRadio.AutoSize = true;
            dateFilterAfterRadio.Checked = true;
            dateFilterAfterRadio.Enabled = false;
            dateFilterAfterRadio.Location = new Point(298, 63);
            dateFilterAfterRadio.Name = "dateFilterAfterRadio";
            dateFilterAfterRadio.Size = new Size(78, 19);
            dateFilterAfterRadio.TabIndex = 14;
            dateFilterAfterRadio.TabStop = true;
            dateFilterAfterRadio.Text = "After Date";
            dateFilterAfterRadio.UseVisualStyleBackColor = true;
            dateFilterAfterRadio.CheckedChanged += UpdateFilter;
            // 
            // dateFilterCheckbox
            // 
            dateFilterCheckbox.AutoSize = true;
            dateFilterCheckbox.Location = new Point(152, 22);
            dateFilterCheckbox.Name = "dateFilterCheckbox";
            dateFilterCheckbox.Size = new Size(69, 19);
            dateFilterCheckbox.TabIndex = 10;
            dateFilterCheckbox.Text = "By Date:";
            dateFilterCheckbox.UseVisualStyleBackColor = true;
            dateFilterCheckbox.CheckedChanged += UpdateFilter;
            dateFilterCheckbox.CheckStateChanged += dateFilterCheckbox_CheckStateChanged;
            // 
            // dateFilterOnRadio
            // 
            dateFilterOnRadio.AutoSize = true;
            dateFilterOnRadio.Enabled = false;
            dateFilterOnRadio.Location = new Point(298, 38);
            dateFilterOnRadio.Name = "dateFilterOnRadio";
            dateFilterOnRadio.Size = new Size(68, 19);
            dateFilterOnRadio.TabIndex = 13;
            dateFilterOnRadio.Text = "On Date";
            dateFilterOnRadio.UseVisualStyleBackColor = true;
            dateFilterOnRadio.CheckedChanged += UpdateFilter;
            // 
            // userFilterCheckbox
            // 
            userFilterCheckbox.AutoSize = true;
            userFilterCheckbox.Location = new Point(6, 22);
            userFilterCheckbox.Name = "userFilterCheckbox";
            userFilterCheckbox.Size = new Size(68, 19);
            userFilterCheckbox.TabIndex = 8;
            userFilterCheckbox.Text = "By User:";
            userFilterCheckbox.UseVisualStyleBackColor = true;
            userFilterCheckbox.CheckedChanged += UpdateFilter;
            userFilterCheckbox.CheckStateChanged += userFilterCheckbox_CheckStateChanged;
            // 
            // dateFilterBeforeRadio
            // 
            dateFilterBeforeRadio.AutoSize = true;
            dateFilterBeforeRadio.Enabled = false;
            dateFilterBeforeRadio.Location = new Point(298, 13);
            dateFilterBeforeRadio.Name = "dateFilterBeforeRadio";
            dateFilterBeforeRadio.Size = new Size(86, 19);
            dateFilterBeforeRadio.TabIndex = 12;
            dateFilterBeforeRadio.Text = "Before Date";
            dateFilterBeforeRadio.UseVisualStyleBackColor = true;
            dateFilterBeforeRadio.CheckedChanged += UpdateFilter;
            // 
            // dateFilterPicker
            // 
            dateFilterPicker.Enabled = false;
            dateFilterPicker.Format = DateTimePickerFormat.Short;
            dateFilterPicker.Location = new Point(152, 47);
            dateFilterPicker.Name = "dateFilterPicker";
            dateFilterPicker.Size = new Size(140, 23);
            dateFilterPicker.TabIndex = 11;
            dateFilterPicker.ValueChanged += UpdateFilter;
            // 
            // userFilterCombo
            // 
            userFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            userFilterCombo.Enabled = false;
            userFilterCombo.FormattingEnabled = true;
            userFilterCombo.Location = new Point(6, 47);
            userFilterCombo.Name = "userFilterCombo";
            userFilterCombo.Size = new Size(140, 23);
            userFilterCombo.TabIndex = 9;
            userFilterCombo.SelectedValueChanged += UpdateFilter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(refundActionCheckbox);
            groupBox4.Controls.Add(remakeActionCheckbox);
            groupBox4.Controls.Add(tbdActionCheckbox);
            groupBox4.Location = new Point(378, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(160, 87);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Action";
            // 
            // refundActionCheckbox
            // 
            refundActionCheckbox.AutoSize = true;
            refundActionCheckbox.Checked = true;
            refundActionCheckbox.CheckState = CheckState.Checked;
            refundActionCheckbox.Location = new Point(6, 13);
            refundActionCheckbox.Name = "refundActionCheckbox";
            refundActionCheckbox.Size = new Size(101, 19);
            refundActionCheckbox.TabIndex = 5;
            refundActionCheckbox.Text = "Show Refunds";
            refundActionCheckbox.UseVisualStyleBackColor = true;
            refundActionCheckbox.CheckedChanged += UpdateFilter;
            // 
            // remakeActionCheckbox
            // 
            remakeActionCheckbox.AutoSize = true;
            remakeActionCheckbox.Checked = true;
            remakeActionCheckbox.CheckState = CheckState.Checked;
            remakeActionCheckbox.Location = new Point(6, 38);
            remakeActionCheckbox.Name = "remakeActionCheckbox";
            remakeActionCheckbox.Size = new Size(105, 19);
            remakeActionCheckbox.TabIndex = 6;
            remakeActionCheckbox.Text = "Show Remakes";
            remakeActionCheckbox.UseVisualStyleBackColor = true;
            remakeActionCheckbox.CheckedChanged += UpdateFilter;
            // 
            // tbdActionCheckbox
            // 
            tbdActionCheckbox.AutoSize = true;
            tbdActionCheckbox.Checked = true;
            tbdActionCheckbox.CheckState = CheckState.Checked;
            tbdActionCheckbox.Location = new Point(6, 63);
            tbdActionCheckbox.Name = "tbdActionCheckbox";
            tbdActionCheckbox.Size = new Size(114, 19);
            tbdActionCheckbox.TabIndex = 7;
            tbdActionCheckbox.Text = "Show TBD/Other";
            tbdActionCheckbox.UseVisualStyleBackColor = true;
            tbdActionCheckbox.CheckedChanged += UpdateFilter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(unresolvedStatusCheckbox);
            groupBox3.Controls.Add(resolvedStatusCheckbox);
            groupBox3.Location = new Point(212, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(160, 87);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Status";
            // 
            // unresolvedStatusCheckbox
            // 
            unresolvedStatusCheckbox.AutoSize = true;
            unresolvedStatusCheckbox.Checked = true;
            unresolvedStatusCheckbox.CheckState = CheckState.Checked;
            unresolvedStatusCheckbox.Location = new Point(6, 22);
            unresolvedStatusCheckbox.Name = "unresolvedStatusCheckbox";
            unresolvedStatusCheckbox.Size = new Size(151, 19);
            unresolvedStatusCheckbox.TabIndex = 3;
            unresolvedStatusCheckbox.Text = "Show Unresolved Issues";
            unresolvedStatusCheckbox.UseVisualStyleBackColor = true;
            unresolvedStatusCheckbox.CheckedChanged += UpdateFilter;
            // 
            // resolvedStatusCheckbox
            // 
            resolvedStatusCheckbox.AutoSize = true;
            resolvedStatusCheckbox.Location = new Point(6, 47);
            resolvedStatusCheckbox.Name = "resolvedStatusCheckbox";
            resolvedStatusCheckbox.Size = new Size(139, 19);
            resolvedStatusCheckbox.TabIndex = 4;
            resolvedStatusCheckbox.Text = "Show Resolved Issues";
            resolvedStatusCheckbox.UseVisualStyleBackColor = true;
            resolvedStatusCheckbox.CheckedChanged += UpdateFilter;
            // 
            // resolveIssueButton
            // 
            resolveIssueButton.Enabled = false;
            resolveIssueButton.Location = new Point(6, 60);
            resolveIssueButton.Name = "resolveIssueButton";
            resolveIssueButton.Size = new Size(200, 23);
            resolveIssueButton.TabIndex = 2;
            resolveIssueButton.Text = "Mark Selected Issue(s) as Resolved";
            resolveIssueButton.UseVisualStyleBackColor = true;
            resolveIssueButton.Click += resolveIssueButton_Click;
            // 
            // addIssueButton
            // 
            addIssueButton.Location = new Point(6, 31);
            addIssueButton.Name = "addIssueButton";
            addIssueButton.Size = new Size(200, 23);
            addIssueButton.TabIndex = 1;
            addIssueButton.Text = "Add New Issue";
            addIssueButton.UseVisualStyleBackColor = true;
            addIssueButton.Click += addIssueButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataView);
            groupBox2.Location = new Point(12, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(938, 335);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Issues";
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(6, 22);
            dataView.Name = "dataView";
            dataView.ReadOnly = true;
            dataView.RowHeadersVisible = false;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.Size = new Size(926, 307);
            dataView.TabIndex = 0;
            dataView.TabStop = false;
            dataView.CellMouseDown += dataView_CellMouseDown;
            dataView.ColumnHeaderMouseClick += dataView_ColumnHeaderMouseClick;
            dataView.SelectionChanged += dataView_SelectionChanged;
            // 
            // IssueTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 537);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "IssueTracker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schnitz Issue Tracker";
            Load += IssueTracker_Load;
            groupBox1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button resolveIssueButton;
        private Button addIssueButton;
        private CheckBox resolvedStatusCheckbox;
        private CheckBox unresolvedStatusCheckbox;
        private CheckBox tbdActionCheckbox;
        private CheckBox remakeActionCheckbox;
        private CheckBox refundActionCheckbox;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private ComboBox userFilterCombo;
        private CheckBox userFilterCheckbox;
        private DateTimePicker dateFilterPicker;
        private CheckBox dateFilterCheckbox;
        private TextBox nameSearchBox;
        private TextBox phoneSearchBox;
        private TextBox referenceSearchBox;
        private GroupBox groupBox6;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton dateFilterAfterRadio;
        private RadioButton dateFilterOnRadio;
        private RadioButton dateFilterBeforeRadio;
        private DataGridView dataView;
    }
}