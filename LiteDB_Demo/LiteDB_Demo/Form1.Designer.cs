namespace LiteDB_Demo
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            buttonClear = new System.Windows.Forms.Button();
            DataGridView = new System.Windows.Forms.DataGridView();
            textBoxFullName = new System.Windows.Forms.TextBox();
            textBoxPhone = new System.Windows.Forms.TextBox();
            textBoxEmail = new System.Windows.Forms.TextBox();
            textBoxAddress = new System.Windows.Forms.TextBox();
            textBoxSearch = new System.Windows.Forms.TextBox();
            buttonDelete = new System.Windows.Forms.Button();
            buttonUpdate = new System.Windows.Forms.Button();
            buttonNew = new System.Windows.Forms.Button();
            buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(63, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Full name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(63, 121);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(63, 165);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(63, 219);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(63, 269);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Search:";
            // 
            // buttonClear
            // 
            buttonClear.Location = new System.Drawing.Point(729, 301);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new System.Drawing.Size(110, 31);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new System.Drawing.Point(63, 338);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.RowTemplate.Height = 29;
            DataGridView.Size = new System.Drawing.Size(776, 188);
            DataGridView.TabIndex = 6;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new System.Drawing.Point(158, 70);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new System.Drawing.Size(681, 27);
            textBoxFullName.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new System.Drawing.Point(158, 114);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new System.Drawing.Size(681, 27);
            textBoxPhone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new System.Drawing.Point(158, 158);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(681, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new System.Drawing.Point(158, 212);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new System.Drawing.Size(681, 27);
            textBoxAddress.TabIndex = 10;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new System.Drawing.Point(158, 262);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(562, 27);
            textBoxSearch.TabIndex = 11;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(497, 541);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(110, 31);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(613, 541);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(110, 31);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new System.Drawing.Point(729, 541);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new System.Drawing.Size(110, 31);
            buttonNew.TabIndex = 15;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonFind
            // 
            buttonFind.Location = new System.Drawing.Point(729, 262);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new System.Drawing.Size(110, 27);
            buttonFind.TabIndex = 17;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(917, 586);
            Controls.Add(buttonFind);
            Controls.Add(buttonNew);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxSearch);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxFullName);
            Controls.Add(DataGridView);
            Controls.Add(buttonClear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "                           ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonFind;
    }
}
