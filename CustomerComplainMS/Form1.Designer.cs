namespace CustomerComplainMS
{
    partial class CustomerComplainForm
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
            this.waitinQueueGroupBox = new System.Windows.Forms.GroupBox();
            this.waitingQueueListView = new System.Windows.Forms.ListView();
            this.serialNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComplainColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnqueueGroupBox = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.enqueueComplainTextBox = new System.Windows.Forms.TextBox();
            this.enqueueNameTextBox = new System.Windows.Forms.TextBox();
            this.enqueueComplainLabel = new System.Windows.Forms.Label();
            this.enqueueNameLabel = new System.Windows.Forms.Label();
            this.dequeueGroupBox = new System.Windows.Forms.GroupBox();
            this.dequeueSerialNoTextBox = new System.Windows.Forms.TextBox();
            this.dequeueSerialNoLabel = new System.Windows.Forms.Label();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.dequeueComplainTextBox = new System.Windows.Forms.TextBox();
            this.dequeueNameTextBox = new System.Windows.Forms.TextBox();
            this.dequeueComplainLabel = new System.Windows.Forms.Label();
            this.dequeueNameLabel = new System.Windows.Forms.Label();
            this.waitinQueueGroupBox.SuspendLayout();
            this.EnqueueGroupBox.SuspendLayout();
            this.dequeueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // waitinQueueGroupBox
            // 
            this.waitinQueueGroupBox.Controls.Add(this.waitingQueueListView);
            this.waitinQueueGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitinQueueGroupBox.Location = new System.Drawing.Point(12, 197);
            this.waitinQueueGroupBox.Name = "waitinQueueGroupBox";
            this.waitinQueueGroupBox.Size = new System.Drawing.Size(780, 181);
            this.waitinQueueGroupBox.TabIndex = 1;
            this.waitinQueueGroupBox.TabStop = false;
            this.waitinQueueGroupBox.Text = "Waiting Queue";
            // 
            // waitingQueueListView
            // 
            this.waitingQueueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNoColumnHeader,
            this.nameColumnHeader,
            this.ComplainColumnHeader});
            this.waitingQueueListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingQueueListView.Location = new System.Drawing.Point(0, 32);
            this.waitingQueueListView.Name = "waitingQueueListView";
            this.waitingQueueListView.Size = new System.Drawing.Size(765, 143);
            this.waitingQueueListView.TabIndex = 0;
            this.waitingQueueListView.UseCompatibleStateImageBehavior = false;
            this.waitingQueueListView.View = System.Windows.Forms.View.Details;
            // 
            // serialNoColumnHeader
            // 
            this.serialNoColumnHeader.Text = "Serial No";
            this.serialNoColumnHeader.Width = 149;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 185;
            // 
            // ComplainColumnHeader
            // 
            this.ComplainColumnHeader.Text = "Complain";
            this.ComplainColumnHeader.Width = 398;
            // 
            // EnqueueGroupBox
            // 
            this.EnqueueGroupBox.Controls.Add(this.enqueueButton);
            this.EnqueueGroupBox.Controls.Add(this.enqueueComplainTextBox);
            this.EnqueueGroupBox.Controls.Add(this.enqueueNameTextBox);
            this.EnqueueGroupBox.Controls.Add(this.enqueueComplainLabel);
            this.EnqueueGroupBox.Controls.Add(this.enqueueNameLabel);
            this.EnqueueGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnqueueGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EnqueueGroupBox.Name = "EnqueueGroupBox";
            this.EnqueueGroupBox.Size = new System.Drawing.Size(388, 179);
            this.EnqueueGroupBox.TabIndex = 2;
            this.EnqueueGroupBox.TabStop = false;
            this.EnqueueGroupBox.Text = "Enqueue Customer";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enqueueButton.Location = new System.Drawing.Point(144, 136);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // enqueueComplainTextBox
            // 
            this.enqueueComplainTextBox.Location = new System.Drawing.Point(108, 67);
            this.enqueueComplainTextBox.Name = "enqueueComplainTextBox";
            this.enqueueComplainTextBox.Size = new System.Drawing.Size(258, 21);
            this.enqueueComplainTextBox.TabIndex = 3;
            // 
            // enqueueNameTextBox
            // 
            this.enqueueNameTextBox.Location = new System.Drawing.Point(108, 37);
            this.enqueueNameTextBox.Name = "enqueueNameTextBox";
            this.enqueueNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.enqueueNameTextBox.TabIndex = 2;
            // 
            // enqueueComplainLabel
            // 
            this.enqueueComplainLabel.AutoSize = true;
            this.enqueueComplainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enqueueComplainLabel.Location = new System.Drawing.Point(21, 75);
            this.enqueueComplainLabel.Name = "enqueueComplainLabel";
            this.enqueueComplainLabel.Size = new System.Drawing.Size(50, 13);
            this.enqueueComplainLabel.TabIndex = 1;
            this.enqueueComplainLabel.Text = "Complain";
            // 
            // enqueueNameLabel
            // 
            this.enqueueNameLabel.AutoSize = true;
            this.enqueueNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enqueueNameLabel.Location = new System.Drawing.Point(36, 41);
            this.enqueueNameLabel.Name = "enqueueNameLabel";
            this.enqueueNameLabel.Size = new System.Drawing.Size(35, 13);
            this.enqueueNameLabel.TabIndex = 0;
            this.enqueueNameLabel.Text = "Name";
            // 
            // dequeueGroupBox
            // 
            this.dequeueGroupBox.Controls.Add(this.dequeueSerialNoTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeueSerialNoLabel);
            this.dequeueGroupBox.Controls.Add(this.dequeueButton);
            this.dequeueGroupBox.Controls.Add(this.dequeueComplainTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeueNameTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeueComplainLabel);
            this.dequeueGroupBox.Controls.Add(this.dequeueNameLabel);
            this.dequeueGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dequeueGroupBox.Location = new System.Drawing.Point(406, 12);
            this.dequeueGroupBox.Name = "dequeueGroupBox";
            this.dequeueGroupBox.Size = new System.Drawing.Size(388, 179);
            this.dequeueGroupBox.TabIndex = 5;
            this.dequeueGroupBox.TabStop = false;
            this.dequeueGroupBox.Text = "Dequeue Customer";
            // 
            // dequeueSerialNoTextBox
            // 
            this.dequeueSerialNoTextBox.Location = new System.Drawing.Point(119, 33);
            this.dequeueSerialNoTextBox.Name = "dequeueSerialNoTextBox";
            this.dequeueSerialNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.dequeueSerialNoTextBox.TabIndex = 6;
            // 
            // dequeueSerialNoLabel
            // 
            this.dequeueSerialNoLabel.AutoSize = true;
            this.dequeueSerialNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dequeueSerialNoLabel.Location = new System.Drawing.Point(30, 36);
            this.dequeueSerialNoLabel.Name = "dequeueSerialNoLabel";
            this.dequeueSerialNoLabel.Size = new System.Drawing.Size(50, 13);
            this.dequeueSerialNoLabel.TabIndex = 5;
            this.dequeueSerialNoLabel.Text = "Serial No";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dequeueButton.Location = new System.Drawing.Point(144, 136);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 4;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // dequeueComplainTextBox
            // 
            this.dequeueComplainTextBox.Location = new System.Drawing.Point(119, 92);
            this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
            this.dequeueComplainTextBox.Size = new System.Drawing.Size(258, 21);
            this.dequeueComplainTextBox.TabIndex = 3;
            // 
            // dequeueNameTextBox
            // 
            this.dequeueNameTextBox.Location = new System.Drawing.Point(119, 62);
            this.dequeueNameTextBox.Name = "dequeueNameTextBox";
            this.dequeueNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.dequeueNameTextBox.TabIndex = 2;
            // 
            // dequeueComplainLabel
            // 
            this.dequeueComplainLabel.AutoSize = true;
            this.dequeueComplainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dequeueComplainLabel.Location = new System.Drawing.Point(30, 97);
            this.dequeueComplainLabel.Name = "dequeueComplainLabel";
            this.dequeueComplainLabel.Size = new System.Drawing.Size(50, 13);
            this.dequeueComplainLabel.TabIndex = 1;
            this.dequeueComplainLabel.Text = "Complain";
            // 
            // dequeueNameLabel
            // 
            this.dequeueNameLabel.AutoSize = true;
            this.dequeueNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dequeueNameLabel.Location = new System.Drawing.Point(45, 67);
            this.dequeueNameLabel.Name = "dequeueNameLabel";
            this.dequeueNameLabel.Size = new System.Drawing.Size(35, 13);
            this.dequeueNameLabel.TabIndex = 0;
            this.dequeueNameLabel.Text = "Name";
            // 
            // CustomerComplainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 390);
            this.Controls.Add(this.dequeueGroupBox);
            this.Controls.Add(this.EnqueueGroupBox);
            this.Controls.Add(this.waitinQueueGroupBox);
            this.Name = "CustomerComplainForm";
            this.Text = "Customer Complain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.waitinQueueGroupBox.ResumeLayout(false);
            this.EnqueueGroupBox.ResumeLayout(false);
            this.EnqueueGroupBox.PerformLayout();
            this.dequeueGroupBox.ResumeLayout(false);
            this.dequeueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox waitinQueueGroupBox;
        private System.Windows.Forms.GroupBox EnqueueGroupBox;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox enqueueComplainTextBox;
        private System.Windows.Forms.TextBox enqueueNameTextBox;
        private System.Windows.Forms.Label enqueueComplainLabel;
        private System.Windows.Forms.Label enqueueNameLabel;
        private System.Windows.Forms.GroupBox dequeueGroupBox;
        private System.Windows.Forms.TextBox dequeueSerialNoTextBox;
        private System.Windows.Forms.Label dequeueSerialNoLabel;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox dequeueComplainTextBox;
        private System.Windows.Forms.TextBox dequeueNameTextBox;
        private System.Windows.Forms.Label dequeueComplainLabel;
        private System.Windows.Forms.Label dequeueNameLabel;
        private System.Windows.Forms.ListView waitingQueueListView;
        private System.Windows.Forms.ColumnHeader serialNoColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader ComplainColumnHeader;
    }
}

