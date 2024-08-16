namespace the_note_taking_app
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
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            bttnew = new Button();
            bttsave = new Button();
            bttread = new Button();
            bttDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(159, 41);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(159, 85);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(240, 209);
            txtMessage.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 41);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 85);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Notes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(503, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 253);
            dataGridView1.TabIndex = 4;
            // 
            // bttnew
            // 
            bttnew.Location = new Point(119, 370);
            bttnew.Name = "bttnew";
            bttnew.Size = new Size(75, 23);
            bttnew.TabIndex = 5;
            bttnew.Text = "New";
            bttnew.UseVisualStyleBackColor = true;
            bttnew.Click += bttnew_Click;
            // 
            // bttsave
            // 
            bttsave.Location = new Point(286, 370);
            bttsave.Name = "bttsave";
            bttsave.Size = new Size(75, 23);
            bttsave.TabIndex = 6;
            bttsave.Text = "Save";
            bttsave.UseVisualStyleBackColor = true;
            bttsave.Click += bttsave_Click;
            // 
            // bttread
            // 
            bttread.Location = new Point(461, 370);
            bttread.Name = "bttread";
            bttread.Size = new Size(75, 23);
            bttread.TabIndex = 7;
            bttread.Text = "Read";
            bttread.UseVisualStyleBackColor = true;
            bttread.Click += bttread_Click;
            // 
            // bttDelete
            // 
            bttDelete.Location = new Point(646, 370);
            bttDelete.Name = "bttDelete";
            bttDelete.Size = new Size(75, 23);
            bttDelete.TabIndex = 8;
            bttDelete.Text = "Delete";
            bttDelete.UseVisualStyleBackColor = true;
            bttDelete.Click += bttDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttDelete);
            Controls.Add(bttread);
            Controls.Add(bttsave);
            Controls.Add(bttnew);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtMessage;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button bttnew;
        private Button bttsave;
        private Button bttread;
        private Button bttDelete;
    }
}
