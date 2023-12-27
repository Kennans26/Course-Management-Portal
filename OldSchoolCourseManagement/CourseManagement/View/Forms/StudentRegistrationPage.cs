using CourseManagement.Models;
using CourseManagement.Services;
using CourseManagement.Tools.Utility;

namespace CourseManagement.View.Forms
{
    public partial class StudentRegistrationPage : Form
    {
        int currentYear = DateTime.Now.Year;
        const string formattedDate = "yyyy-MM-dd";

        //we'll need it on 1 time in this page...
        OutlookService service = new OutlookService();

        StudentsInfo student = new StudentsInfo();

        //now minimum one time we need it for SOLID
        ImageOperations io = new();
        ShowingTables st = new();

        public StudentRegistrationPage()
        {
            InitializeComponent();
        }

        //for adding a gif when form is loading
        private void StudentRegistrationPage_Load(object sender, EventArgs e)
        {
            btnForClear_Click(sender, e);

            //to show students list in DataGridView
            st.SRP(DataGridViewAboutStudent);
        }


        //for uploading photo for student
        private void btnForUpload_Click(object sender, EventArgs e)
        {
            //browse photo for student from computer...
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = io.FormattedImage;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxForStudentsImages.Image = Image.FromFile(ofd.FileName);
                pictureBoxForStudentsImages.SizeMode = PictureBoxSizeMode.Zoom; //Zoom is more well for gender photos, but not for course photos
            }
        }

        private void btnForAdd_Click(object sender, EventArgs e)
        {
            //need to check student age.
            int bornYear = dateTimePickerDOB.Value.Year;

            if (currentYear - bornYear < 18)
            {
                MessageBox.Show("The student's age must be 18 or more.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (VerifySomeInformationForStudent())
            {
                if (student.VerifyStudentIdentity(txtBoxStudentId))
                {
                    if (student.VerifyStudentEmailRP(txtBoxEmail))
                    {
                        //this regular expression checks for a basic email format
                        if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                        {
                            MessageBox.Show("Invalid email address format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (io.ImageEquals(pictureBoxForStudentsImages.Image, Properties.Resources.DefaultMaleGenderImage) ||
                            io.ImageEquals(pictureBoxForStudentsImages.Image, Properties.Resources.DefaultFemaleGenderImage))
                        {
                            DialogResult result = MessageBox.Show("Sure to adding a new student without adding any image?", "Default Student Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.No)
                            {
                                btnForUpload_Click(sender, new EventArgs());

                                return;
                            }
                        }

                        //the last station:
                        try
                        {
                            //for adding new student
                            string Identity = txtBoxStudentId.Text;
                            string FirstName = txtBoxFirstName.Text;
                            string LastName = txtBoxLastName.Text;
                            DateTime BirthDate = Convert.ToDateTime(dateTimePickerDOB.Value.ToString(formattedDate));
                            string Email = txtBoxEmail.Text;
                            string Gender = radioButtonGenderM.Checked ? "Male" : "Female";
                            string Address = txtBoxAddress.Text;

                            //to get photo from picture box...
                            MemoryStream ms = new MemoryStream();
                            pictureBoxForStudentsImages.Image.Save(ms, pictureBoxForStudentsImages.Image.RawFormat);
                            byte[] Image = ms.ToArray();

                            if (student.InsertStudent(Identity, FirstName, LastName, BirthDate, Gender, Email, Address, Image))
                            {
                                //for refresh table
                                st.SRP(DataGridViewAboutStudent);

                                service.SendEmail(Email, EmailOptions.GetStudentWelcomeEmailSubject, EmailOptions.GetStudentWelcomeEmailBody(FirstName, LastName));

                                //for inform to admin
                                MessageBox.Show("New student was successfully added!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        //for inform to admin...
                        MessageBox.Show($"Please check the email address again, {txtBoxEmail.Text} is already taken!", "Invalid Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //for inform to admin...
                    MessageBox.Show("The student ID already exists. Please enter a unique student ID.", "Duplicate Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //for inform to admin
                MessageBox.Show("Please enter the student's information completely!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnForClear_Click(object sender, EventArgs e)
        {
            txtBoxStudentId.Clear();
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxEmail.Clear();
            txtBoxAddress.Clear();
            radioButtonGenderF.Checked = false;
            radioButtonGenderM.Checked = false;
            dateTimePickerDOB.Value = DateTime.Now;

            io.ForDefaultAnimatedPhotoSRP(pictureBoxForStudentsImages);
        }


        //create a function to verify some data
        private bool VerifySomeInformationForStudent()
        {
            if (string.IsNullOrWhiteSpace(txtBoxStudentId.Text) || string.IsNullOrWhiteSpace(txtBoxFirstName.Text) || string.IsNullOrWhiteSpace(txtBoxLastName.Text) || string.IsNullOrWhiteSpace(txtBoxEmail.Text)
                || string.IsNullOrWhiteSpace(txtBoxAddress.Text) || pictureBoxForStudentsImages.Image == Properties.Resources.ImageForLoading
                || (!radioButtonGenderF.Checked && !radioButtonGenderM.Checked))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void radioButtonGenderM_CheckedChanged(object sender, EventArgs e)
        {
            if (io.ImageEquals(pictureBoxForStudentsImages.Image, Properties.Resources.DefaultMaleGenderImage) ||
                io.ImageEquals(pictureBoxForStudentsImages.Image, Properties.Resources.DefaultFemaleGenderImage) ||
                io.ImageEquals(pictureBoxForStudentsImages.Image, Properties.Resources.ImageForLoading))
            {
                if (radioButtonGenderM.Checked && !radioButtonGenderF.Checked)
                {
                    pictureBoxForStudentsImages.Image = Properties.Resources.DefaultMaleGenderImage;
                    pictureBoxForStudentsImages.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void radioButtonGenderF_CheckedChanged(object sender, EventArgs e)
        {
            if (io.ImageEquals(pictureBoxForStudentsImages.Image, Properties.Resources.DefaultMaleGenderImage) ||
                io.ImageEquals(pictureBoxForStudentsImages.Image, Properties.Resources.DefaultFemaleGenderImage) ||
                io.ImageEquals(pictureBoxForStudentsImages.Image, Properties.Resources.ImageForLoading))
            {
                if (!radioButtonGenderM.Checked && radioButtonGenderF.Checked)
                {
                    pictureBoxForStudentsImages.Image = Properties.Resources.DefaultFemaleGenderImage;
                    pictureBoxForStudentsImages.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }   
        }
    }
}
