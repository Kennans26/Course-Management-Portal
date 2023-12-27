using System.Data.SqlClient;
using CourseManagement.Models;
using CourseManagement.Services;
using CourseManagement.View.Controls;
using CourseManagement.Tools.Utility;

namespace CourseManagement.View.Forms
{
    public partial class NewScorePage : Form
    {
        //we'll need it on 1 time in this page...
        OutlookService service = new OutlookService();

        //need a Courses, Students, Scores instance, cause a some db connection must be ready to data transfer
        CoursesInfo course = new CoursesInfo();
        StudentsInfo student = new StudentsInfo();
        ScoresInfo score = new ScoresInfo();

        //now minimum one time we need it for SOLID
        ShowingTables st = new();

        public NewScorePage()
        {
            InitializeComponent();
        }

        private void NewScorePage_Load(object sender, EventArgs e)
        {   
            btnForClear_Click(sender, e);

            HelperMethodForCBFCourse();

            //to show students, scores list in DataGridView
            st.NSPLeft(DataGridViewAboutStudents);
            st.NSPRight(DataGridViewAboutScores);
        }


        private void DataGridViewAboutStudents_Click(object sender, EventArgs e)
        {
            lblForShowingStdId.Text = DataGridViewAboutStudents.CurrentRow.Cells[0].Value.ToString();
        }

        private void DataGridViewAboutScores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            const int courseColumnIndex = 1;

            if (e.ColumnIndex == courseColumnIndex && e.RowIndex >= 0)
            {
                //a MessageBox to ask the user if they want to see all course data
                DialogResult result = MessageBox.Show("Do you want to see all course data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    AdditionalCourseData additionalCourseData = new AdditionalCourseData();
                    additionalCourseData.Show();
                }
            }
        }


        private void btnForAdd_Click(object sender, EventArgs e)
        {
            if (VerifySomeScoreInputs())
            {
                if (score.VerifyScoreValue(txtBoxScore))
                {
                    string StudentIdentity = lblForShowingStdId.Text;
                    string CourseName = comboBoxForCourse.Text;
                    double Score = Convert.ToDouble(txtBoxScore.Text);
                    string Description = txtBoxDescription.Text;

                    string CourseIdentity = score.GetCourseIdentity(CourseName);

                    if (!score.IsStudentAlreadyEnrolled(StudentIdentity, CourseIdentity))
                    {
                        //the last station:
                        try
                        {
                            if (score.InsertScore(StudentIdentity, CourseIdentity, Score, Description))
                            {
                                //for refresh the table
                                st.NSPRight(DataGridViewAboutScores);

                                service.SendEmail(service.AdminEmail, EmailOptions.GetNewScoreNotificationEmailSubject, EmailOptions.GetNewScoreNotificationEmailBody(StudentIdentity, CourseIdentity, Score, Description));

                                //for inform to admin
                                MessageBox.Show("New score was successfully added!", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                btnForClear_Click(sender, e);
                            }
                        }
                        catch (Exception exc)
                        {
                            //for inform to admin
                            MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //student is already enrolled, handle accordingly
                        MessageBox.Show("This student has already taken this course.", "Enrollment Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid (positive) number for the score.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //for inform to admin
                MessageBox.Show("Please enter the score's information completely!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnForClear_Click(object sender, EventArgs e)
        {
            lblForShowingStdId.Visible = false;

            lblForShowingStdId.Text = string.Empty;
            txtBoxScore.Text = string.Empty;
            txtBoxDescription.Text = string.Empty;

            //for setting the default selection to -1 (no selection)
            comboBoxForCourse.SelectedIndex = -1;
        }


        private void HelperMethodForCBFCourse()
        {
            comboBoxForCourse.Items.Clear();
            comboBoxForCourse.DataSource = null;

            //populate the combobox with courses name
            comboBoxForCourse.DataSource = course.GetCoursesList(new SqlCommand("SELECT * FROM Courses;"));

            comboBoxForCourse.DisplayMember = "Name";
            comboBoxForCourse.ValueMember = "Name";

            //for setting the default selection to -1 (no selection)
            comboBoxForCourse.SelectedIndex = -1;
        }

        //to create a method for verify some score data
        private bool VerifySomeScoreInputs()
        {
            if (string.IsNullOrWhiteSpace(lblForShowingStdId.Text) || string.IsNullOrWhiteSpace(txtBoxDescription.Text) ||
                string.IsNullOrWhiteSpace(txtBoxScore.Text) || string.IsNullOrWhiteSpace(comboBoxForCourse.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //for showing the student id section
        private void lblForShowingStdId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblForShowingStdId.Text))
            {
                lblForShowingStdId.Visible = true;
            }
        }
    }
}
