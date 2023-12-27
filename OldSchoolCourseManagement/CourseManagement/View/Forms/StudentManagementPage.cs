using CourseManagement.Models;
using CourseManagement.Services;
using CourseManagement.Tools.Utility;

namespace CourseManagement.View.Forms
{
    public partial class StudentManagementPage : Form
    {
        int currentYear = DateTime.Now.Year;
        const string formattedDate = "yyyy-MM-dd";

        //we'll need it on minimum 1 time in this page...
        OutlookService service = new OutlookService();

        StudentsInfo student = new StudentsInfo();

        //now minimum one time we need it for SOLID
        ImageOperations io = new();
        ShowingTables st = new();

        public StudentManagementPage()
        {
            InitializeComponent();
        }

        //for adding a gif when form is loading
        private void StudentManagementPage_Load(object sender, EventArgs e)
        {
            radioButtonGenderF.Enabled = false;
            radioButtonGenderM.Enabled = false;

            btnForClear_Click(sender, e);

            st.SMP(DataGridViewAboutStudent);
        }


        //for display data from Students (db) to textboxes
        private void DataGridViewAboutStudent_Click(object sender, EventArgs e)
        {
            try
            {
                lblForShowingStdId.Text = DataGridViewAboutStudent.CurrentRow.Cells[0].Value.ToString();
                txtBoxFirstName.Text = DataGridViewAboutStudent.CurrentRow.Cells[1].Value.ToString();
                txtBoxLastName.Text = DataGridViewAboutStudent.CurrentRow.Cells[2].Value.ToString();

                dateTimePickerDOB.Value = (DateTime) DataGridViewAboutStudent.CurrentRow.Cells[3].Value;

                if (DataGridViewAboutStudent.CurrentRow.Cells[4].Value.ToString() == "Male")
                {
                    radioButtonGenderM.Checked = true;
                    radioButtonGenderF.Checked = false;
                }
                else
                {
                    radioButtonGenderM.Checked = false;
                    radioButtonGenderF.Checked = true;
                }

                txtBoxEmail.Text = DataGridViewAboutStudent.CurrentRow.Cells[5].Value.ToString();
                txtBoxAddress.Text = DataGridViewAboutStudent.CurrentRow.Cells[6].Value.ToString();

                try
                {
                    byte[] img = (byte[]) DataGridViewAboutStudent.CurrentRow.Cells[7].Value;
                    MemoryStream ms = new MemoryStream(img);
                    pictureBoxForStudentsImages.Image = Image.FromStream(ms);
                    pictureBoxForStudentsImages.SizeMode = PictureBoxSizeMode.Zoom;
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


        private void btnForClear_Click(object sender, EventArgs e)
        {
            lblStudentId.Visible = false;
            lblForShowingStdId.Visible = false;
            lblForShowingStdId.Text = string.Empty;

            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxEmail.Clear();
            txtBoxAddress.Clear();
            radioButtonGenderF.Checked = false;
            radioButtonGenderM.Checked = false;
            dateTimePickerDOB.Value = DateTime.Now;

            io.ForDefaultAnimatedPhotoSMP(pictureBoxForStudentsImages);
        }

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

        private void btnForUpdate_Click(object sender, EventArgs e)
        {
            //need to check student age
            int bornYear = dateTimePickerDOB.Value.Year;

            if (currentYear - bornYear < 18)
            {
                MessageBox.Show("The student's age must be 18 or more.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (VerifySomeInformationForStudent())
            {
                string Identity = lblForShowingStdId.Text;

                if (student.VerifyStudentEmailMP(Identity, txtBoxEmail))
                {
                    //this regular expression checks for a basic email format
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    {
                        MessageBox.Show("Invalid email address format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //the last station:
                    try
                    {
                        //for update a student record
                        string FirstName = txtBoxFirstName.Text;
                        string LastName = txtBoxLastName.Text;
                        DateTime BirthDate = Convert.ToDateTime(dateTimePickerDOB.Value.ToString(formattedDate));                    
                        string Email = txtBoxEmail.Text;
                        string Gender = radioButtonGenderM.Checked ? "Male" : "Female";
                        string Address = txtBoxAddress.Text;

                        //to get photo from picture box...
                        MemoryStream ms = new MemoryStream();
                        pictureBoxForStudentsImages.Image.Save(ms, pictureBoxForStudentsImages.Image.RawFormat);
                        byte[] Photo = ms.ToArray();

                        if (student.UpdateForStudents(Identity, FirstName, LastName, BirthDate, Gender, Email, Address, Photo))
                        {
                            //for refresh table
                            st.SMP(DataGridViewAboutStudent);

                            service.SendEmail(Email, EmailOptions.GetStudentUpdateConfirmationEmailSubject, EmailOptions.GetStudentUpdateConfirmationEmailBody(FirstName, LastName));

                            //for inform to admin
                            MessageBox.Show("Student data was successfully updated!", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnForClear_Click(sender, e);
                        }
                    }
                    catch (Exception exc)
                    {
                        //for inform to admin...
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
                MessageBox.Show("Please enter the student's information completely!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnForDelete_Click(object sender, EventArgs e)
        {
            if (VerifySomeInformationForStudent())
            {
                //the last station:
                try
                {
                    string Identity = lblForShowingStdId.Text;
                    string FirstName = txtBoxFirstName.Text;
                    string LastName = txtBoxLastName.Text;                 
                    string Email = txtBoxEmail.Text;

                    //confirmation dialog
                    DialogResult result = MessageBox.Show("Are you sure you want to remove this student from app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //generate a 6-digit verification code
                        string verificationCode = CodeGenerator.GenerateVerificationCode();

                        service.SendEmail(service.AdminEmail, EmailOptions.GetStudentRemoveVerificationEmailSubject, EmailOptions.GetStudentRemoveVerificationEmailBody(Identity, verificationCode));

                        //prompt the user to enter the verification code
                        string userEnteredCode = Microsoft.VisualBasic.Interaction.InputBox("Enter the 6-digit verification code sent to admin (personal) email:", "Verification Code");

                        //verify the entered code
                        if (userEnteredCode == verificationCode)
                        {
                            //code is correct, proceed with data delete logic
                            if (student.DeleteStudent(Identity))
                            {
                                //for refresh table
                                st.SMP(DataGridViewAboutStudent);

                                service.SendEmail(service.AdminEmail, EmailOptions.GetStudentRemoveConfirmationEmailSubject, EmailOptions.GetStudentRemoveConfirmationEmailBody(Identity));
                                service.SendEmail(Email, EmailOptions.GetStudentRemoveConfirmationEmailSubject, EmailOptions.GetStudentRemoveConfirmationEmailBody(FirstName, LastName, Identity));

                                //for inform to admin
                                MessageBox.Show("Student data was successfully deleted!", "Remove student", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Please enter the student's information completely!", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void lblForShowingStdId_TextChanged(object sender, EventArgs e)
        {
            if (lblForShowingStdId.Text != string.Empty)
            {
                lblStudentId.Visible = true;
                lblForShowingStdId.Visible = true;
            }
        }

        private void textBoxForSearch_TextChanged(object sender, EventArgs e)
        {
            st.ForSearchSMP(DataGridViewAboutStudent, textBoxForSearch);
        }


        //create a function to verify some data
        private bool VerifySomeInformationForStudent()
        {
            if ((string.IsNullOrWhiteSpace(lblForShowingStdId.Text)) || (string.IsNullOrWhiteSpace(txtBoxFirstName.Text)) || (string.IsNullOrWhiteSpace(txtBoxLastName.Text)) || (string.IsNullOrWhiteSpace(txtBoxEmail.Text))
                || (string.IsNullOrWhiteSpace(txtBoxAddress.Text)) || pictureBoxForStudentsImages.Image == Properties.Resources.ImageForLoading
                || (!radioButtonGenderF.Checked && !radioButtonGenderM.Checked))
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
