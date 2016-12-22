namespace LotteryMgnt
{
    partial class CustomerTrans
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
            this.btnNew = new System.Windows.Forms.Button();
            this.dtpLotIn = new System.Windows.Forms.DateTimePicker();
            this.dgLotIn = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnTrip = new System.Windows.Forms.MenuStrip();
            this.mnFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPost = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgLotIn)).BeginInit();
            this.panel1.SuspendLayout();
            this.mnTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(155, 28);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 25);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtpLotIn
            // 
            this.dtpLotIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLotIn.Location = new System.Drawing.Point(45, 30);
            this.dtpLotIn.Name = "dtpLotIn";
            this.dtpLotIn.Size = new System.Drawing.Size(104, 20);
            this.dtpLotIn.TabIndex = 1;
            // 
            // dgLotIn
            // 
            this.dgLotIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLotIn.Location = new System.Drawing.Point(12, 96);
            this.dgLotIn.Name = "dgLotIn";
            this.dgLotIn.Size = new System.Drawing.Size(1079, 404);
            this.dgLotIn.TabIndex = 2;
            this.dgLotIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLotIn_CellContentClick);
            this.dgLotIn.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLotIn_CellValidated);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(25, 65);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(91, 25);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "Add Line";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(978, 65);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(92, 25);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mnTrip);
            this.panel1.Location = new System.Drawing.Point(766, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 24);
            this.panel1.TabIndex = 6;
            // 
            // mnTrip
            // 
            this.mnTrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFunc});
            this.mnTrip.Location = new System.Drawing.Point(0, 0);
            this.mnTrip.Name = "mnTrip";
            this.mnTrip.Size = new System.Drawing.Size(194, 24);
            this.mnTrip.TabIndex = 0;
            this.mnTrip.Text = "menuStrip1";
            // 
            // mnFunc
            // 
            this.mnFunc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPost});
            this.mnFunc.Name = "mnFunc";
            this.mnFunc.Size = new System.Drawing.Size(66, 20);
            this.mnFunc.Text = "Function";
            // 
            // mnPost
            // 
            this.mnPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mnPost.Name = "mnPost";
            this.mnPost.Size = new System.Drawing.Size(152, 22);
            this.mnPost.Text = "Post";
            // 
            // CustomerTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgLotIn);
            this.Controls.Add(this.dtpLotIn);
            this.Controls.Add(this.btnNew);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainMenuStrip = this.mnTrip;
            this.Name = "CustomerTrans";
            this.Text = "CustomerTrans";
            this.Load += new System.EventHandler(this.CustomerTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLotIn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnTrip.ResumeLayout(false);
            this.mnTrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DateTimePicker dtpLotIn;
        private System.Windows.Forms.DataGridView dgLotIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mnTrip;
        private System.Windows.Forms.ToolStripMenuItem mnFunc;
        private System.Windows.Forms.ToolStripMenuItem mnPost;
    }
}