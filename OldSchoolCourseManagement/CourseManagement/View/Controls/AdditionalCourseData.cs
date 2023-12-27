using CourseManagement.Tools.Utility;

namespace CourseManagement.View.Controls
{
    public partial class AdditionalCourseData : Form
    {
        //now minimum one time we need it for SOLID
        ShowingTables st = new();

        public AdditionalCourseData()
        {
            InitializeComponent();

            InitializeFadeInTimer();
        }

        //for some visual changes, i mean opacity view
        private void InitializeFadeInTimer()
        {
            timerForACD.Interval = 20;
            this.Opacity = 0;
            timerForACD.Start();
        }

        private void timerForACD_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.025;
            }
            else
            {
                timerForACD.Stop();

                //Information for timerForACD: it work!
                //MessageBox.Show("timerForACD was stop now!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void AdditionalCourseData_Load(object sender, EventArgs e)
        {
            st.ACD(DataGridViewAboutCourse);
        }
    }
}
