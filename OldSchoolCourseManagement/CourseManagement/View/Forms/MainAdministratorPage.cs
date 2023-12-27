using CourseManagement.Models;

namespace CourseManagement.View.Forms
{
    public partial class MainAdministratorPage : Form
    {
        StudentsInfo student = new StudentsInfo();

        public MainAdministratorPage()
        {
            InitializeComponent();

            InitializeFadeInTimer();

            CustomizeDesign();
        }


        //for some visual changes, i mean opacity view
        private void InitializeFadeInTimer()
        {
            timerForMAP.Interval = 20;
            this.Opacity = 0;
            timerForMAP.Start();
        }

        private void timerForMAP_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.025;
            }
            else
            {
                timerForMAP.Stop();

                //Information for timerForMAP: it work!
                //MessageBox.Show("timerForMAP was stop now!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void MainAdministratorPage_Load(object sender, EventArgs e)
        {
            ShowStudentCount();
        }


        //when form is opening the left panel's menus must not open, that's why we need to do them .visible = false;
        private void CustomizeDesign()
        {
            panelForStudentsMenu.Visible = false;
            panelForCoursesMenu.Visible = false;
            panelForScoresMenu.Visible = false;
        }


        //we we click a some button for showing data, the left panel's menus must be closed form!
        private void HideSubMenus()
        {
            if (panelForStudentsMenu.Visible == true)
            {
                panelForStudentsMenu.Visible = false;
            }
            if (panelForCoursesMenu.Visible == true)
            {
                panelForCoursesMenu.Visible = false;
            }
            if (panelForScoresMenu.Visible == true)
            {
                panelForScoresMenu.Visible = false;
            }
        }

        private void ShowSubMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        //for open new registration form in main form...
        private Form? activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            panelForMainPageFill.Controls.Add(ChildForm);
            panelForMainPageFill.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        //a function to display student count, may be need call in somewhere...
        private void ShowStudentCount()
        {
            //for display the students values
            lblTotalStudentsIC.Text = "Total Students: " + student.GetTotalStudents();
            lblMGenderIC.Text = "Male: " + student.GetMaleStudents();
            lblFGenderIC.Text = "Female: " + student.GetFemaleStudents();
        }


        //for Students button:
        private void btnStudentsInLSlide_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panelForStudentsMenu);
        }

        #region Students button's sub menu
        private void btnStudentsRegistrationInLSlide_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentRegistrationPage());

            HideSubMenus();
        }

        private void btnStudentsManagementInLSlide_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentManagementPage());

            HideSubMenus();
        }
        #endregion


        //for Courses button:
        private void btnForCoursesLSlide_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panelForCoursesMenu);
        }

        #region Courses button's sub menu
        private void btnCoursesNewCourseInLSlide_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewCoursePage());

            HideSubMenus();
        }

        private void btnCoursesManagementInLSlide_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CourseManagementPage());

            HideSubMenus();
        }
        #endregion


        //for Scores button:
        private void btnForScoresLSlide_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panelForScoresMenu);
        }

        #region Scores button's sub menu
        private void btnScoresNewScoreInLSlide_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewScorePage());

            HideSubMenus();
        }
        #endregion


        #region settings icon changing
        //for settings picture rotation... (visual)
        private void pictureBoxForSettings_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxForSettings.Image = Properties.Resources.Pinions_settings1;
            pictureBoxForSettings.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBoxForSettings_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxForSettings.Image = Properties.Resources.Pinions_settings2;
            pictureBoxForSettings.SizeMode = PictureBoxSizeMode.Zoom;
        }
        #endregion


        private void btnForSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage();
            settingsPage.ShowDialog(this);
        }

        //for Dashboard in button:
        private void btnForDashboard_Click(object sender, EventArgs e)
        {
            HideSubMenus();

            if (activeForm != null)
            {
                activeForm.Close();
            }

            panelForMainPageFill.Controls.Add(panelForUPMainCover);
            //when user wanna to return a dashboard, it must refresh itself
            ShowStudentCount();
        }


        //it need for also close app from back (task manager)
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
