namespace SchnitzIssueTracker.Forms
{
    partial class ModifyUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUsers));
            newUserBox = new TextBox();
            existingUserCombo = new ComboBox();
            addUserButton = new Button();
            removeUserButton = new Button();
            closeButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // newUserBox
            // 
            newUserBox.Location = new Point(6, 22);
            newUserBox.Name = "newUserBox";
            newUserBox.Size = new Size(160, 23);
            newUserBox.TabIndex = 1;
            newUserBox.TextChanged += newUserBox_TextChanged;
            // 
            // existingUserCombo
            // 
            existingUserCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            existingUserCombo.FormattingEnabled = true;
            existingUserCombo.Location = new Point(6, 22);
            existingUserCombo.Name = "existingUserCombo";
            existingUserCombo.Size = new Size(160, 23);
            existingUserCombo.TabIndex = 3;
            existingUserCombo.SelectedIndexChanged += existingUserCombo_SelectedIndexChanged;
            // 
            // addUserButton
            // 
            addUserButton.Enabled = false;
            addUserButton.Location = new Point(21, 51);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(130, 23);
            addUserButton.TabIndex = 2;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // removeUserButton
            // 
            removeUserButton.Enabled = false;
            removeUserButton.Location = new Point(24, 51);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(130, 23);
            removeUserButton.TabIndex = 4;
            removeUserButton.Text = "Remove User";
            removeUserButton.UseVisualStyleBackColor = true;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(122, 98);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(130, 23);
            closeButton.TabIndex = 4;
            closeButton.TabStop = false;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(newUserBox);
            groupBox1.Controls.Add(addUserButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(172, 80);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New User";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(existingUserCombo);
            groupBox2.Controls.Add(removeUserButton);
            groupBox2.Location = new Point(190, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(172, 80);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Remove Existing User";
            // 
            // ModifyUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 133);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(closeButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifyUsers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modify Users";
            Load += ModifyUsers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox newUserBox;
        private ComboBox existingUserCombo;
        private Button addUserButton;
        private Button removeUserButton;
        private Button closeButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}