namespace OrientedModel_Crud_Operations
{
    partial class Form1
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
            label1 = new Label();
            LabelCompanyName = new Label();
            label_ListPrice = new Label();
            button_Add = new Button();
            button_update = new Button();
            button_Delete = new Button();
            button_Preview = new Button();
            textBox_CompanyName = new TextBox();
            textBox_listPrice = new TextBox();
            button_Search = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(618, 71);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 0;
            label1.Text = "Oriented Model Crud Operations";
            // 
            // LabelCompanyName
            // 
            LabelCompanyName.AutoSize = true;
            LabelCompanyName.Location = new Point(535, 156);
            LabelCompanyName.Name = "LabelCompanyName";
            LabelCompanyName.Size = new Size(97, 15);
            LabelCompanyName.TabIndex = 1;
            LabelCompanyName.Text = "Company Name:";
            // 
            // label_ListPrice
            // 
            label_ListPrice.AutoSize = true;
            label_ListPrice.Location = new Point(535, 211);
            label_ListPrice.Name = "label_ListPrice";
            label_ListPrice.Size = new Size(57, 15);
            label_ListPrice.TabIndex = 2;
            label_ListPrice.Text = "List Price:";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(435, 389);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(107, 49);
            button_Add.TabIndex = 3;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(571, 389);
            button_update.Name = "button_update";
            button_update.Size = new Size(93, 49);
            button_update.TabIndex = 4;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(697, 389);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(89, 49);
            button_Delete.TabIndex = 5;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Preview
            // 
            button_Preview.Location = new Point(831, 389);
            button_Preview.Name = "button_Preview";
            button_Preview.Size = new Size(90, 49);
            button_Preview.TabIndex = 6;
            button_Preview.Text = "Preview";
            button_Preview.UseVisualStyleBackColor = true;
            button_Preview.Click += button_Preview_Click;
            // 
            // textBox_CompanyName
            // 
            textBox_CompanyName.Location = new Point(662, 153);
            textBox_CompanyName.Name = "textBox_CompanyName";
            textBox_CompanyName.Size = new Size(313, 23);
            textBox_CompanyName.TabIndex = 7;
            // 
            // textBox_listPrice
            // 
            textBox_listPrice.Location = new Point(662, 203);
            textBox_listPrice.Name = "textBox_listPrice";
            textBox_listPrice.Size = new Size(553, 23);
            textBox_listPrice.TabIndex = 8;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(1004, 152);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(141, 23);
            button_Search.TabIndex = 9;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(343, 458);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(787, 270);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1628, 892);
            Controls.Add(dataGridView1);
            Controls.Add(button_Search);
            Controls.Add(textBox_listPrice);
            Controls.Add(textBox_CompanyName);
            Controls.Add(button_Preview);
            Controls.Add(button_Delete);
            Controls.Add(button_update);
            Controls.Add(button_Add);
            Controls.Add(label_ListPrice);
            Controls.Add(LabelCompanyName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LabelCompanyName;
        private Label label_ListPrice;
        private Button button_Add;
        private Button button_update;
        private Button button_Delete;
        private Button button_Preview;
        private TextBox textBox_CompanyName;
        private TextBox textBox_listPrice;
        private Button button_Search;
        private DataGridView dataGridView1;
    }
}
