using CourseManagement.Models;
using CourseManagement.Services;
using CourseManagement.Tools.Utility;

namespace CourseManagement.View.Forms
{
    public partial class CourseManagementPage : Form
    {
        //we'll need it on minimum 1 time in this page...
        OutlookService service = new OutlookService();

        //need a Courses instance, cause a some db connection must be ready to data transfer
        CoursesInfo course = new CoursesInfo();

        //now minimum one time we need it for SOLID
        ImageOperations io = new();
        ShowingTables st = new();

        public CourseManagementPage()
        {
            InitializeComponent();
        }

        private void CourseManagementPage_Load(object sender, EventArgs e)
        {
            btnForClear_Click(sender, e);

            dateTimePickerCCD.Enabled = false;

            //to show courses list in DataGridView
            st.CMP(DataGridViewAboutCourse);
        }


        //for display data from Courses (db) to textboxes
        private void DataGridViewAboutCourse_Click(object sender, EventArgs e)
        {
            try
            {
                lblForShowingCourseId.Text = DataGridViewAboutCourse.CurrentRow.Cells[0].Value.ToString();
                txtBoxCourseName.Text = DataGridViewAboutCourse.CurrentRow.Cells[1].Value.ToString();

                dateTimePickerCCD.Value = (DateTime) DataGridViewAboutCourse.CurrentRow.Cells[2].Value;

                txtBoxHour.Text = DataGridViewAboutCourse.CurrentRow.Cells[3].Value.ToString();
                txtBoxDescription.Text = DataGridViewAboutCourse.CurrentRow.Cells[4].Value.ToString();

                try
                {
                    byte[] img = (byte[]) DataGridViewAboutCourse.CurrentRow.Cells[5].Value;
                    MemoryStream ms = new MemoryStream(img);
                    pictureBoxForCourseCoverImage.Image = Image.FromStream(ms);
                    pictureBoxForCourseCoverImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Error - {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Error - {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnForUpload_Click(object sender, EventArgs e)
        {
            //browse photo for student from computer...
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = io.FormattedImage;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxForCourseCoverImage.Image = Image.FromFile(ofd.FileName);
                pictureBoxForCourseCoverImage.SizeMode = PictureBoxSizeMode.StretchImage; //Zoom is more well for gender photos, but not for course photos
            }
        }

        private void btnForClear_Click(object sender, EventArgs e)
        {
            lblForShowingCourseId.Text = string.Empty;

            txtBoxCourseName.Clear();
            txtBoxHour.Clear();
            txtBoxDescription.Clear();

            HelperMethodForTCFDTP();
            io.DefaultCourseCoverPhotoCMP(pictureBoxForCourseCoverImage);
        }

        private void btnForUpdate_Click(object sender, EventArgs e)
        {
            if (VerifySomeCourseInputs())
            {
                if (course.VerifyCourseHour(txtBoxHour))
                {
                    if (io.ImageEquals(pictureBoxForCourseCoverImage.Image, Properties.Resources.DefaultCourseCoverImage))
                    {
                        DialogResult result = MessageBox.Show("Sure to updating the course with still default cover image?", "Default Course Cover Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.No)
                        {
                            btnForUpload_Click(sender, new EventArgs());

                            return;
                        }
                    }

                    //the last station:
                    try
                    {
                        string Identity = lblForShowingCourseId.Text;
                        string Name = txtBoxCourseName.Text;
                        //DateTime CreationDate = DateTime.Now;
                        int Hour = Convert.ToInt32(txtBoxHour.Text);
                        string Description = txtBoxDescription.Text;

                        //to get photo from picture box...
                        MemoryStream ms = new MemoryStream();
                        pictureBoxForCourseCoverImage.Image.Save(ms, pictureBoxForCourseCoverImage.Image.RawFormat);
                        byte[] Image = ms.ToArray();

                        if (course.UpdateCourse(Identity, Name, Hour, Description, Image))
                        {
                            //for refresh table
                            st.CMP(DataGridViewAboutCourse);

                            service.SendEmail(service.AdminEmail, EmailOptions.GetCourseUpdateNotificationEmailSubject, EmailOptions.GetCourseUpdateNotificationEmailBody(Identity, Name));

                            //for inform to admin
                            MessageBox.Show("Course data was successfully updated!", "Update course", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Please enter a valid (positive) integer for the course hours.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //for inform to admin
                MessageBox.Show("Please enter the course's information completely!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnForDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblForShowingCourseId.Text))
            {
                //the last station:
                try
                {
                    string Identity = lblForShowingCourseId.Text;

                    //confirmation dialog
                    DialogResult result = MessageBox.Show("Are you sure you want to remove this course from app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //generate a 6-digit verification code
                        string verificationCode = CodeGenerator.GenerateVerificationCode();

                        service.SendEmail(service.AdminEmail, EmailOptions.GetStudentRemoveVerificationEmailSubject, EmailOptions.GetCourseRemoveVerificationEmailBody(Identity, verificationCode));

                        //prompt the user to enter the verification code
                        string userEnteredCode = Microsoft.VisualBasic.Interaction.InputBox("Enter the 6-digit verification code sent to admin (personal) email:", "Verification Code");

                        //verify the entered code
                        if (userEnteredCode == verificationCode)
                        {
                            //code is correct, proceed with data delete logic
                            if (course.DeleteCourse(Identity))
                            {
                                //for refresh table
                                st.CMP(DataGridViewAboutCourse);

                                service.SendEmail(service.AdminEmail, EmailOptions.GetCourseRemoveConfirmationEmailSubject, EmailOptions.GetCourseRemoveConfirmationEmailBody(Identity));

                                //for inform to admin
                                MessageBox.Show("Course data was successfully deleted!", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                btnForClear_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Failed to remove the data. Please try again.", "Data Remove Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect verification code. Data remove aborted.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
                //for inform to admin
                MessageBox.Show("Please enter the course's id completely!", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void textBoxForSearch_TextChanged(object sender, EventArgs e)
        {
            st.ForSearchCMP(DataGridViewAboutCourse, textBoxForSearch);
        }


        //method for un visible 2 views
        private void HelperMethodForTCFDTP()
        {
            dateTimePickerCCD.Visible = false;
        }

        //one method consist of 4 parts, i mean @desc, @ch, @ccd, @cid;
        private void TextChangedForDTP(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxCourseName.Text) && !string.IsNullOrWhiteSpace(txtBoxHour.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxDescription.Text) && !string.IsNullOrWhiteSpace(lblForShowingCourseId.Text))
            {
                dateTimePickerCCD.Visible = true;
            }
            else
            {
                HelperMethodForTCFDTP();
            }
        }


        //to create a method for verify some course data
        private bool VerifySomeCourseInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBoxCourseName.Text) || string.IsNullOrWhiteSpace(txtBoxDescription.Text) ||
                string.IsNullOrWhiteSpace(txtBoxHour.Text) || string.IsNullOrWhiteSpace(lblForShowingCourseId.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
