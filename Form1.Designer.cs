namespace TimeTracker
{
    partial class F_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.StartAndStop = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ResetTime = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Types = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnQryDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            this.btnUpdate.Location = new System.Drawing.Point(3, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartAndStop,
            this.ResetTime,
            this.Types});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(69)))));
            this.dataGridView2.Location = new System.Drawing.Point(3, 50);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.Size = new System.Drawing.Size(770, 162);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_DefaultValuesNeeded);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            // 
            // StartAndStop
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            this.StartAndStop.DefaultCellStyle = dataGridViewCellStyle3;
            this.StartAndStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartAndStop.HeaderText = "Start and Stop";
            this.StartAndStop.Name = "StartAndStop";
            // 
            // ResetTime
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            this.ResetTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.ResetTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetTime.HeaderText = "Reset Time";
            this.ResetTime.Name = "ResetTime";
            // 
            // Types
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            this.Types.DefaultCellStyle = dataGridViewCellStyle5;
            this.Types.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Types.HeaderText = "Types";
            this.Types.Items.AddRange(new object[] {
            "Meeting",
            "Documentation",
            "Research",
            "Lunch",
            "Development",
            "Planning",
            "Technical Issues",
            "Training",
            "Emails",
            "MISC"});
            this.Types.Name = "Types";
            // 
            // btnQryDate
            // 
            this.btnQryDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnQryDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            this.btnQryDate.Location = new System.Drawing.Point(133, 13);
            this.btnQryDate.Name = "btnQryDate";
            this.btnQryDate.Size = new System.Drawing.Size(75, 23);
            this.btnQryDate.TabIndex = 5;
            this.btnQryDate.Text = "Query Date";
            this.btnQryDate.UseVisualStyleBackColor = false;
            this.btnQryDate.Click += new System.EventHandler(this.btnQryDate_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(773, 253);
            this.Controls.Add(this.btnQryDate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "F_Main";
            this.Opacity = 0.93D;
            this.Text = "TimeTracker";
            this.Load += new System.EventHandler(this.F_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn StartAndStop;
        private System.Windows.Forms.DataGridViewButtonColumn ResetTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn Types;
        private System.Windows.Forms.Button btnQryDate;
    }
}

