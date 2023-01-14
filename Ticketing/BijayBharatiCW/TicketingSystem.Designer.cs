
namespace BijayBharatiCW
{
    partial class TicketingSystemForm
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
            this.customerTypelabel = new System.Windows.Forms.Label();
            this.customerTypecomboBox = new System.Windows.Forms.ComboBox();
            this.durationlabel = new System.Windows.Forms.Label();
            this.durationcomboBox = new System.Windows.Forms.ComboBox();
            this.grouppanel = new System.Windows.Forms.Panel();
            this.groupSizetextBox = new System.Windows.Forms.TextBox();
            this.groupTypecomboBox = new System.Windows.Forms.ComboBox();
            this.groupTypelabel = new System.Windows.Forms.Label();
            this.groupSizelabel = new System.Windows.Forms.Label();
            this.ticketPricelabel = new System.Windows.Forms.Label();
            this.ticketPricetextBox = new System.Windows.Forms.TextBox();
            this.childrenpanel = new System.Windows.Forms.Panel();
            this.noOfChildrentextBox = new System.Windows.Forms.TextBox();
            this.noOfChildrenlabel = new System.Windows.Forms.Label();
            this.confirmTicketbutton = new System.Windows.Forms.Button();
            this.addCategoriesbutton = new System.Windows.Forms.Button();
            this.resetFieldsbutton = new System.Windows.Forms.Button();
            this.restartbutton = new System.Windows.Forms.Button();
            this.ticketPricebutton = new System.Windows.Forms.Button();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.userNametextBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.userNamelabel = new System.Windows.Forms.Label();
            this.adminLoginlabel = new System.Windows.Forms.Label();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reportbutton = new System.Windows.Forms.Button();
            this.titlelabel = new System.Windows.Forms.Label();
            this.grouppanel.SuspendLayout();
            this.childrenpanel.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerTypelabel
            // 
            this.customerTypelabel.AutoSize = true;
            this.customerTypelabel.Location = new System.Drawing.Point(12, 55);
            this.customerTypelabel.Name = "customerTypelabel";
            this.customerTypelabel.Size = new System.Drawing.Size(78, 13);
            this.customerTypelabel.TabIndex = 0;
            this.customerTypelabel.Text = "Customer Type";
            // 
            // customerTypecomboBox
            // 
            this.customerTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerTypecomboBox.FormattingEnabled = true;
            this.customerTypecomboBox.Location = new System.Drawing.Point(108, 47);
            this.customerTypecomboBox.Name = "customerTypecomboBox";
            this.customerTypecomboBox.Size = new System.Drawing.Size(173, 21);
            this.customerTypecomboBox.TabIndex = 1;
            this.customerTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.customerTypecomboBox_SelectedIndexChanged);
            // 
            // durationlabel
            // 
            this.durationlabel.AutoSize = true;
            this.durationlabel.Location = new System.Drawing.Point(8, 125);
            this.durationlabel.Name = "durationlabel";
            this.durationlabel.Size = new System.Drawing.Size(82, 13);
            this.durationlabel.TabIndex = 2;
            this.durationlabel.Text = "Ticket Category";
            // 
            // durationcomboBox
            // 
            this.durationcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationcomboBox.FormattingEnabled = true;
            this.durationcomboBox.Location = new System.Drawing.Point(108, 117);
            this.durationcomboBox.Name = "durationcomboBox";
            this.durationcomboBox.Size = new System.Drawing.Size(173, 21);
            this.durationcomboBox.TabIndex = 3;
            this.durationcomboBox.SelectedIndexChanged += new System.EventHandler(this.durationcomboBox_SelectedIndexChanged);
            // 
            // grouppanel
            // 
            this.grouppanel.Controls.Add(this.groupSizetextBox);
            this.grouppanel.Controls.Add(this.groupTypecomboBox);
            this.grouppanel.Controls.Add(this.groupTypelabel);
            this.grouppanel.Controls.Add(this.groupSizelabel);
            this.grouppanel.Location = new System.Drawing.Point(421, 38);
            this.grouppanel.Name = "grouppanel";
            this.grouppanel.Size = new System.Drawing.Size(312, 113);
            this.grouppanel.TabIndex = 4;
            // 
            // groupSizetextBox
            // 
            this.groupSizetextBox.Location = new System.Drawing.Point(91, 9);
            this.groupSizetextBox.Name = "groupSizetextBox";
            this.groupSizetextBox.Size = new System.Drawing.Size(173, 20);
            this.groupSizetextBox.TabIndex = 7;
            this.groupSizetextBox.TextChanged += new System.EventHandler(this.groupSizetextBox_TextChanged);
            this.groupSizetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupSizetextBox_KeyPress);
            // 
            // groupTypecomboBox
            // 
            this.groupTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupTypecomboBox.FormattingEnabled = true;
            this.groupTypecomboBox.Location = new System.Drawing.Point(91, 79);
            this.groupTypecomboBox.Name = "groupTypecomboBox";
            this.groupTypecomboBox.Size = new System.Drawing.Size(173, 21);
            this.groupTypecomboBox.TabIndex = 5;
            this.groupTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.groupTypecomboBox_SelectedIndexChanged);
            // 
            // groupTypelabel
            // 
            this.groupTypelabel.AutoSize = true;
            this.groupTypelabel.Location = new System.Drawing.Point(13, 87);
            this.groupTypelabel.Name = "groupTypelabel";
            this.groupTypelabel.Size = new System.Drawing.Size(63, 13);
            this.groupTypelabel.TabIndex = 6;
            this.groupTypelabel.Text = "Group Type";
            // 
            // groupSizelabel
            // 
            this.groupSizelabel.AutoSize = true;
            this.groupSizelabel.Location = new System.Drawing.Point(13, 17);
            this.groupSizelabel.Name = "groupSizelabel";
            this.groupSizelabel.Size = new System.Drawing.Size(59, 13);
            this.groupSizelabel.TabIndex = 5;
            this.groupSizelabel.Text = "Group Size";
            // 
            // ticketPricelabel
            // 
            this.ticketPricelabel.AutoSize = true;
            this.ticketPricelabel.Location = new System.Drawing.Point(26, 196);
            this.ticketPricelabel.Name = "ticketPricelabel";
            this.ticketPricelabel.Size = new System.Drawing.Size(64, 13);
            this.ticketPricelabel.TabIndex = 5;
            this.ticketPricelabel.Text = "Ticket Price";
            // 
            // ticketPricetextBox
            // 
            this.ticketPricetextBox.Location = new System.Drawing.Point(108, 189);
            this.ticketPricetextBox.Name = "ticketPricetextBox";
            this.ticketPricetextBox.ReadOnly = true;
            this.ticketPricetextBox.Size = new System.Drawing.Size(173, 20);
            this.ticketPricetextBox.TabIndex = 6;
            // 
            // childrenpanel
            // 
            this.childrenpanel.Controls.Add(this.noOfChildrentextBox);
            this.childrenpanel.Controls.Add(this.noOfChildrenlabel);
            this.childrenpanel.Location = new System.Drawing.Point(421, 168);
            this.childrenpanel.Name = "childrenpanel";
            this.childrenpanel.Size = new System.Drawing.Size(312, 59);
            this.childrenpanel.TabIndex = 7;
            // 
            // noOfChildrentextBox
            // 
            this.noOfChildrentextBox.Location = new System.Drawing.Point(91, 20);
            this.noOfChildrentextBox.Name = "noOfChildrentextBox";
            this.noOfChildrentextBox.Size = new System.Drawing.Size(173, 20);
            this.noOfChildrentextBox.TabIndex = 8;
            this.noOfChildrentextBox.TextChanged += new System.EventHandler(this.noOfChildrentextBox_TextChanged);
            this.noOfChildrentextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noOfChildrentextBox_KeyPress);
            // 
            // noOfChildrenlabel
            // 
            this.noOfChildrenlabel.AutoSize = true;
            this.noOfChildrenlabel.Location = new System.Drawing.Point(3, 27);
            this.noOfChildrenlabel.Name = "noOfChildrenlabel";
            this.noOfChildrenlabel.Size = new System.Drawing.Size(77, 13);
            this.noOfChildrenlabel.TabIndex = 8;
            this.noOfChildrenlabel.Text = "No. of Children";
            // 
            // confirmTicketbutton
            // 
            this.confirmTicketbutton.Location = new System.Drawing.Point(189, 281);
            this.confirmTicketbutton.Name = "confirmTicketbutton";
            this.confirmTicketbutton.Size = new System.Drawing.Size(104, 37);
            this.confirmTicketbutton.TabIndex = 8;
            this.confirmTicketbutton.Text = "Confirm Ticket";
            this.confirmTicketbutton.UseVisualStyleBackColor = true;
            this.confirmTicketbutton.Click += new System.EventHandler(this.confirmTicketbutton_Click);
            // 
            // addCategoriesbutton
            // 
            this.addCategoriesbutton.Location = new System.Drawing.Point(629, 375);
            this.addCategoriesbutton.Name = "addCategoriesbutton";
            this.addCategoriesbutton.Size = new System.Drawing.Size(104, 37);
            this.addCategoriesbutton.TabIndex = 9;
            this.addCategoriesbutton.Text = "Add Categories";
            this.addCategoriesbutton.UseVisualStyleBackColor = true;
            this.addCategoriesbutton.Click += new System.EventHandler(this.addCategoriesbutton_Click);
            // 
            // resetFieldsbutton
            // 
            this.resetFieldsbutton.Location = new System.Drawing.Point(485, 281);
            this.resetFieldsbutton.Name = "resetFieldsbutton";
            this.resetFieldsbutton.Size = new System.Drawing.Size(104, 37);
            this.resetFieldsbutton.TabIndex = 10;
            this.resetFieldsbutton.Text = "Reset Fields";
            this.resetFieldsbutton.UseVisualStyleBackColor = true;
            this.resetFieldsbutton.Click += new System.EventHandler(this.resetFieldsbutton_Click);
            // 
            // restartbutton
            // 
            this.restartbutton.Location = new System.Drawing.Point(629, 281);
            this.restartbutton.Name = "restartbutton";
            this.restartbutton.Size = new System.Drawing.Size(104, 37);
            this.restartbutton.TabIndex = 11;
            this.restartbutton.Text = "Restart";
            this.restartbutton.UseVisualStyleBackColor = true;
            this.restartbutton.Click += new System.EventHandler(this.restartbutton_Click);
            // 
            // ticketPricebutton
            // 
            this.ticketPricebutton.Location = new System.Drawing.Point(58, 281);
            this.ticketPricebutton.Name = "ticketPricebutton";
            this.ticketPricebutton.Size = new System.Drawing.Size(104, 37);
            this.ticketPricebutton.TabIndex = 12;
            this.ticketPricebutton.Text = "Ticket Price";
            this.ticketPricebutton.UseVisualStyleBackColor = true;
            this.ticketPricebutton.Click += new System.EventHandler(this.ticketPricebutton_Click);
            // 
            // loginpanel
            // 
            this.loginpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginpanel.Controls.Add(this.passwordtextBox);
            this.loginpanel.Controls.Add(this.userNametextBox);
            this.loginpanel.Controls.Add(this.passwordlabel);
            this.loginpanel.Controls.Add(this.userNamelabel);
            this.loginpanel.Controls.Add(this.adminLoginlabel);
            this.loginpanel.Location = new System.Drawing.Point(58, 338);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(372, 100);
            this.loginpanel.TabIndex = 13;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(179, 63);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(173, 20);
            this.passwordtextBox.TabIndex = 18;
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // userNametextBox
            // 
            this.userNametextBox.Location = new System.Drawing.Point(179, 29);
            this.userNametextBox.Name = "userNametextBox";
            this.userNametextBox.Size = new System.Drawing.Size(173, 20);
            this.userNametextBox.TabIndex = 9;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(107, 70);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.passwordlabel.TabIndex = 17;
            this.passwordlabel.Text = "Password";
            // 
            // userNamelabel
            // 
            this.userNamelabel.AutoSize = true;
            this.userNamelabel.Location = new System.Drawing.Point(107, 36);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(55, 13);
            this.userNamelabel.TabIndex = 16;
            this.userNamelabel.Text = "Username";
            // 
            // adminLoginlabel
            // 
            this.adminLoginlabel.AutoSize = true;
            this.adminLoginlabel.Location = new System.Drawing.Point(13, 12);
            this.adminLoginlabel.Name = "adminLoginlabel";
            this.adminLoginlabel.Size = new System.Drawing.Size(65, 13);
            this.adminLoginlabel.TabIndex = 15;
            this.adminLoginlabel.Text = "Admin Login";
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(485, 397);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(104, 37);
            this.logoutbutton.TabIndex = 19;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(485, 351);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(104, 37);
            this.loginbutton.TabIndex = 15;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(793, 342);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // reportbutton
            // 
            this.reportbutton.Location = new System.Drawing.Point(337, 281);
            this.reportbutton.Name = "reportbutton";
            this.reportbutton.Size = new System.Drawing.Size(104, 37);
            this.reportbutton.TabIndex = 15;
            this.reportbutton.Text = "Report";
            this.reportbutton.UseVisualStyleBackColor = true;
            this.reportbutton.Click += new System.EventHandler(this.reportbutton_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.Location = new System.Drawing.Point(295, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(186, 25);
            this.titlelabel.TabIndex = 20;
            this.titlelabel.Text = "Recreation Centre";
            // 
            // TicketingSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.reportbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.ticketPricebutton);
            this.Controls.Add(this.restartbutton);
            this.Controls.Add(this.addCategoriesbutton);
            this.Controls.Add(this.resetFieldsbutton);
            this.Controls.Add(this.confirmTicketbutton);
            this.Controls.Add(this.childrenpanel);
            this.Controls.Add(this.ticketPricetextBox);
            this.Controls.Add(this.ticketPricelabel);
            this.Controls.Add(this.grouppanel);
            this.Controls.Add(this.durationcomboBox);
            this.Controls.Add(this.durationlabel);
            this.Controls.Add(this.customerTypecomboBox);
            this.Controls.Add(this.customerTypelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "TicketingSystemForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticketing System";
            this.Load += new System.EventHandler(this.TicketingSystemForm_Load);
            this.grouppanel.ResumeLayout(false);
            this.grouppanel.PerformLayout();
            this.childrenpanel.ResumeLayout(false);
            this.childrenpanel.PerformLayout();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerTypelabel;
        private System.Windows.Forms.ComboBox customerTypecomboBox;
        private System.Windows.Forms.Label durationlabel;
        private System.Windows.Forms.ComboBox durationcomboBox;
        private System.Windows.Forms.Panel grouppanel;
        private System.Windows.Forms.TextBox groupSizetextBox;
        private System.Windows.Forms.ComboBox groupTypecomboBox;
        private System.Windows.Forms.Label groupTypelabel;
        private System.Windows.Forms.Label groupSizelabel;
        private System.Windows.Forms.Label ticketPricelabel;
        private System.Windows.Forms.TextBox ticketPricetextBox;
        private System.Windows.Forms.Panel childrenpanel;
        private System.Windows.Forms.TextBox noOfChildrentextBox;
        private System.Windows.Forms.Label noOfChildrenlabel;
        private System.Windows.Forms.Button confirmTicketbutton;
        private System.Windows.Forms.Button addCategoriesbutton;
        private System.Windows.Forms.Button resetFieldsbutton;
        private System.Windows.Forms.Button restartbutton;
        private System.Windows.Forms.Button ticketPricebutton;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox userNametextBox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label userNamelabel;
        private System.Windows.Forms.Label adminLoginlabel;
        private System.Windows.Forms.Button reportbutton;
        private System.Windows.Forms.Label titlelabel;
    }
}

