namespace CourseManagement.View.Controls
{
    partial class AdditionalCourseData
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalCourseData));
            DataGridViewAboutCourse = new Guna.UI2.WinForms.Guna2DataGridView();
            timerForACD = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutCourse).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewAboutCourse
            // 
            DataGridViewAboutCourse.AllowUserToAddRows = false;
            DataGridViewAboutCourse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewAboutCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewAboutCourse.BackgroundColor = Color.Gainsboro;
            DataGridViewAboutCourse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewAboutCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewAboutCourse.ColumnHeadersHeight = 22;
            DataGridViewAboutCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewAboutCourse.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewAboutCourse.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutCourse.Location = new Point(0, 0);
            DataGridViewAboutCourse.Name = "DataGridViewAboutCourse";
            DataGridViewAboutCourse.RowHeadersVisible = false;
            DataGridViewAboutCourse.RowHeadersWidth = 25;
            DataGridViewAboutCourse.RowTemplate.Height = 65;
            DataGridViewAboutCourse.Size = new Size(984, 200);
            DataGridViewAboutCourse.TabIndex = 0;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewAboutCourse.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridViewAboutCourse.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.Height = 22;
            DataGridViewAboutCourse.ThemeStyle.ReadOnly = false;
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.Height = 65;
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // timerForACD
            // 
            timerForACD.Tick += timerForACD_Tick;
            // 
            // AdditionalCourseData
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(983, 200);
            Controls.Add(DataGridViewAboutCourse);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimumSize = new Size(999, 239);
            Name = "AdditionalCourseData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Additional Course Data";
            Load += AdditionalCourseData_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewAboutCourse;
        private System.Windows.Forms.Timer timerForACD;
    }
}