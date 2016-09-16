namespace inlämningsUpggift1
{
    partial class Form1
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.ButChanges = new System.Windows.Forms.Button();
            this.butRemove = new System.Windows.Forms.Button();
            this.txtSerach = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(55, 76);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(98, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Firstname";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(55, 164);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(98, 25);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Lastname";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(55, 334);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(82, 25);
            this.lblZip.TabIndex = 3;
            this.lblZip.Text = "Zipcode";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(55, 246);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 25);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 506);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(55, 418);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 25);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(181, 71);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(392, 29);
            this.txtFirstname.TabIndex = 6;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(181, 160);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(392, 29);
            this.txtLastname.TabIndex = 7;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(181, 330);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(392, 29);
            this.txtZip.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(181, 242);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(392, 29);
            this.txtAddress.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(181, 502);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(392, 29);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(181, 414);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(392, 29);
            this.txtPhone.TabIndex = 10;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(60, 605);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(157, 71);
            this.butSave.TabIndex = 12;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // ButChanges
            // 
            this.ButChanges.Location = new System.Drawing.Point(238, 605);
            this.ButChanges.Name = "ButChanges";
            this.ButChanges.Size = new System.Drawing.Size(157, 71);
            this.ButChanges.TabIndex = 13;
            this.ButChanges.Text = "Save Changes";
            this.ButChanges.UseVisualStyleBackColor = true;
            // 
            // butRemove
            // 
            this.butRemove.Location = new System.Drawing.Point(416, 605);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(157, 71);
            this.butRemove.TabIndex = 14;
            this.butRemove.Text = "Remove";
            this.butRemove.UseVisualStyleBackColor = true;
            // 
            // txtSerach
            // 
            this.txtSerach.Location = new System.Drawing.Point(638, 72);
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.Size = new System.Drawing.Size(258, 29);
            this.txtSerach.TabIndex = 15;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(902, 72);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(127, 29);
            this.butSearch.TabIndex = 16;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(638, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(391, 372);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(638, 605);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(0, 25);
            this.lblMessage2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 822);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.txtSerach);
            this.Controls.Add(this.butRemove);
            this.Controls.Add(this.ButChanges);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button ButChanges;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.TextBox txtSerach;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.ListView listView1;
        private string lblMessage;
        private System.Windows.Forms.Label lblMessage2;
    }
}

