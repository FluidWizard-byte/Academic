
namespace BijayBharatiCW
{
    partial class ratesandCategoriesForm
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
            this.components = new System.ComponentModel.Container();
            this.ratedataGridView = new System.Windows.Forms.DataGridView();
            this.modifyDurationlabel = new System.Windows.Forms.Label();
            this.modifyAdultRatelabel = new System.Windows.Forms.Label();
            this.modifyChildrenRatelabel = new System.Windows.Forms.Label();
            this.modifyDurationtextBox = new System.Windows.Forms.TextBox();
            this.modifyAdultRatetextBox = new System.Windows.Forms.TextBox();
            this.modifyChildrenRatetextBox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.modifybutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.deletelabel = new System.Windows.Forms.Label();
            this.deleteValuetextBox = new System.Windows.Forms.TextBox();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ratedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ratedataGridView
            // 
            this.ratedataGridView.AllowUserToResizeColumns = false;
            this.ratedataGridView.AllowUserToResizeRows = false;
            this.ratedataGridView.AutoGenerateColumns = false;
            this.ratedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.durationDataGridViewTextBoxColumn,
            this.adultRateDataGridViewTextBoxColumn,
            this.childrenRateDataGridViewTextBoxColumn});
            this.ratedataGridView.DataSource = this.ratesBindingSource;
            this.ratedataGridView.Location = new System.Drawing.Point(12, 36);
            this.ratedataGridView.Name = "ratedataGridView";
            this.ratedataGridView.ReadOnly = true;
            this.ratedataGridView.Size = new System.Drawing.Size(338, 150);
            this.ratedataGridView.TabIndex = 0;
            // 
            // modifyDurationlabel
            // 
            this.modifyDurationlabel.AutoSize = true;
            this.modifyDurationlabel.Location = new System.Drawing.Point(64, 229);
            this.modifyDurationlabel.Name = "modifyDurationlabel";
            this.modifyDurationlabel.Size = new System.Drawing.Size(47, 13);
            this.modifyDurationlabel.TabIndex = 1;
            this.modifyDurationlabel.Text = "Duration";
            // 
            // modifyAdultRatelabel
            // 
            this.modifyAdultRatelabel.AutoSize = true;
            this.modifyAdultRatelabel.Location = new System.Drawing.Point(54, 273);
            this.modifyAdultRatelabel.Name = "modifyAdultRatelabel";
            this.modifyAdultRatelabel.Size = new System.Drawing.Size(57, 13);
            this.modifyAdultRatelabel.TabIndex = 2;
            this.modifyAdultRatelabel.Text = "Adult Rate";
            // 
            // modifyChildrenRatelabel
            // 
            this.modifyChildrenRatelabel.AutoSize = true;
            this.modifyChildrenRatelabel.Location = new System.Drawing.Point(41, 316);
            this.modifyChildrenRatelabel.Name = "modifyChildrenRatelabel";
            this.modifyChildrenRatelabel.Size = new System.Drawing.Size(71, 13);
            this.modifyChildrenRatelabel.TabIndex = 3;
            this.modifyChildrenRatelabel.Text = "Children Rate";
            // 
            // modifyDurationtextBox
            // 
            this.modifyDurationtextBox.Location = new System.Drawing.Point(145, 222);
            this.modifyDurationtextBox.Name = "modifyDurationtextBox";
            this.modifyDurationtextBox.Size = new System.Drawing.Size(115, 20);
            this.modifyDurationtextBox.TabIndex = 4;
            // 
            // modifyAdultRatetextBox
            // 
            this.modifyAdultRatetextBox.Location = new System.Drawing.Point(145, 266);
            this.modifyAdultRatetextBox.Name = "modifyAdultRatetextBox";
            this.modifyAdultRatetextBox.Size = new System.Drawing.Size(115, 20);
            this.modifyAdultRatetextBox.TabIndex = 5;
            this.modifyAdultRatetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modifyAdultRatetextBox_KeyPress);
            // 
            // modifyChildrenRatetextBox
            // 
            this.modifyChildrenRatetextBox.Location = new System.Drawing.Point(145, 309);
            this.modifyChildrenRatetextBox.Name = "modifyChildrenRatetextBox";
            this.modifyChildrenRatetextBox.Size = new System.Drawing.Size(115, 20);
            this.modifyChildrenRatetextBox.TabIndex = 6;
            this.modifyChildrenRatetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modifyChildrenRatetextBox_KeyPress);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(145, 362);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(83, 44);
            this.addbutton.TabIndex = 7;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // modifybutton
            // 
            this.modifybutton.Location = new System.Drawing.Point(267, 362);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(83, 44);
            this.modifybutton.TabIndex = 8;
            this.modifybutton.Text = "Modify";
            this.modifybutton.UseVisualStyleBackColor = true;
            this.modifybutton.Click += new System.EventHandler(this.modifybutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(145, 482);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(83, 44);
            this.deletebutton.TabIndex = 9;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // deletelabel
            // 
            this.deletelabel.AutoSize = true;
            this.deletelabel.Location = new System.Drawing.Point(32, 438);
            this.deletelabel.Name = "deletelabel";
            this.deletelabel.Size = new System.Drawing.Size(80, 13);
            this.deletelabel.TabIndex = 10;
            this.deletelabel.Text = "Value to Delete";
            // 
            // deleteValuetextBox
            // 
            this.deleteValuetextBox.Location = new System.Drawing.Point(145, 431);
            this.deleteValuetextBox.Name = "deleteValuetextBox";
            this.deleteValuetextBox.Size = new System.Drawing.Size(115, 20);
            this.deleteValuetextBox.TabIndex = 11;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adultRateDataGridViewTextBoxColumn
            // 
            this.adultRateDataGridViewTextBoxColumn.DataPropertyName = "Adult_Rate";
            this.adultRateDataGridViewTextBoxColumn.HeaderText = "Adult_Rate";
            this.adultRateDataGridViewTextBoxColumn.Name = "adultRateDataGridViewTextBoxColumn";
            this.adultRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childrenRateDataGridViewTextBoxColumn
            // 
            this.childrenRateDataGridViewTextBoxColumn.DataPropertyName = "Children_Rate";
            this.childrenRateDataGridViewTextBoxColumn.HeaderText = "Children_Rate";
            this.childrenRateDataGridViewTextBoxColumn.Name = "childrenRateDataGridViewTextBoxColumn";
            this.childrenRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratesBindingSource
            // 
            this.ratesBindingSource.DataSource = typeof(BijayBharatiCW.Rates);
            // 
            // ratesandCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(372, 538);
            this.Controls.Add(this.deleteValuetextBox);
            this.Controls.Add(this.deletelabel);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.modifybutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.modifyChildrenRatetextBox);
            this.Controls.Add(this.modifyAdultRatetextBox);
            this.Controls.Add(this.modifyDurationtextBox);
            this.Controls.Add(this.modifyChildrenRatelabel);
            this.Controls.Add(this.modifyAdultRatelabel);
            this.Controls.Add(this.modifyDurationlabel);
            this.Controls.Add(this.ratedataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(388, 577);
            this.MinimumSize = new System.Drawing.Size(388, 577);
            this.Name = "ratesandCategoriesForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adjust Rates and Categories";
            this.Load += new System.EventHandler(this.ratesandCategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ratedataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ratesBindingSource;
        private System.Windows.Forms.Label modifyDurationlabel;
        private System.Windows.Forms.Label modifyAdultRatelabel;
        private System.Windows.Forms.Label modifyChildrenRatelabel;
        private System.Windows.Forms.TextBox modifyDurationtextBox;
        private System.Windows.Forms.TextBox modifyAdultRatetextBox;
        private System.Windows.Forms.TextBox modifyChildrenRatetextBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button modifybutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Label deletelabel;
        private System.Windows.Forms.TextBox deleteValuetextBox;
    }
}