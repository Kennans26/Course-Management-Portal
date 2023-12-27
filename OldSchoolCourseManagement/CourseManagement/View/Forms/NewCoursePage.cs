using CourseManagement.Models;
using CourseManagement.Services;
using CourseManagement.Tools.Utility;

namespace CourseManagement.View.Forms
{
    public partial class NewCoursePage : Form
    {
        //we'll need it on 1 time in this page...
        OutlookService service = new OutlookService();

        //need a Courses instance, cause a some db connection must be ready to data transfer
        CoursesInfo course = new CoursesInfo();

        //now minimum one time we need it for SOLID
        ImageOperations io = new();
        ShowingTables st = new();

        public NewCoursePage()
        {
            InitializeComponent();
        }

        private void NewCoursePage_Load(object sender, EventArgs e)
        {
            btnForClear_Click(sender, e);

            dateTimePickerCCD.Enabled = false;

            //to show courses list in DataGridView
            st.NCP(DataGridViewAboutCourse);
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

        private void btnForAdd_Click(object sender, EventArgs e)
        {
            if (VerifySomeCourseInputs())
            {
                if (course.VerifyCourseIdentityNCP(txtBoxCourseId))
                {
                    if (course.VerifyCourseHour(txtBoxHour))
                    {
                        if (io.ImageEquals(pictureBoxForCourseCoverImage.Image, Properties.Resources.DefaultCourseCoverImage))
                        {
                            DialogResult result = MessageBox.Show("Sure to adding a new course without adding any image?", "Default Course Cover Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.No)
                            {
                                btnForUpload_Click(sender, new EventArgs());

                                return;
                            }
                        }

                        //the last station:
                        try
                        {
                            string Identity = txtBoxCourseId.Text;
                            string Name = txtBoxCourseName.Text;
                            DateTime CreationDate = DateTime.Now;
                            int Hour = Convert.ToInt32(txtBoxHour.Text);
                            string Description = txtBoxDescription.Text;

                            //to get photo from picture box...
                            MemoryStream ms = new MemoryStream();
                            pictureBoxForCourseCoverImage.Image.Save(ms, pictureBoxForCourseCoverImage.Image.RawFormat);
                            byte[] Image = ms.ToArray();

                            if (course.InsertCourse(Identity, Name, CreationDate, Hour, Description, Image))
                            {
                                //for refresh table
                                st.NCP(DataGridViewAboutCourse);

                                service.SendEmail(service.AdminEmail, EmailOptions.GetCourseAddedNotificationEmailSubject, EmailOptions.GetCourseAddedNotificationEmailBody(Name));

                                //for inform to admin
                                MessageBox.Show("New course was successfully added!", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("The course ID already exists. Please enter a unique course ID.", "Duplicate Course ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //for inform to admin
                MessageBox.Show("Please enter the course's information completely!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnForClear_Click(object sender, EventArgs e)
        {
            txtBoxCourseId.Clear();
            txtBoxCourseName.Clear();
            txtBoxHour.Clear();
            txtBoxDescription.Clear();

            HelperMethodForTCFDTP();
            io.DefaultCourseCoverPhotoNCP(pictureBoxForCourseCoverImage);
        }


        //method for un visible 2 views
        private void HelperMethodForTCFDTP()
        {
            lblForCreationDate.Visible = false;
            dateTimePickerCCD.Visible = false;
        } 

        //one method consist of 4 parts, i mean @desc, @ch, @ccd, @cid;
        private void TextChangedForDTP(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxCourseName.Text) && !string.IsNullOrWhiteSpace(txtBoxHour.Text) &&
                !string.IsNullOrWhiteSpace(txtBoxDescription.Text) && !string.IsNullOrWhiteSpace(txtBoxCourseId.Text))
            {
                lblForCreationDate.Visible = true;
                dateTimePickerCCD.Value = DateTime.Now;
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
                string.IsNullOrWhiteSpace(txtBoxHour.Text) || string.IsNullOrWhiteSpace(txtBoxCourseId.Text))
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
