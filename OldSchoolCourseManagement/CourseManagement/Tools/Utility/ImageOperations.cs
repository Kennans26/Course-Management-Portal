namespace CourseManagement.Tools.Utility
{
    public class ImageOperations
    {
        //helper prop to get image/photo format for student/course
        public string FormattedImage
        {
            get
            {
                return "Select Photo (*.jpg; *png; *.gif) | *.jpg; *.png; *.gif";
            }
        }

        //helper method to compare images
        public bool ImageEquals(Image img1, Image img2)
        {
            using (MemoryStream ms1 = new MemoryStream(), ms2 = new MemoryStream())
            {
                img1.Save(ms1, img1.RawFormat);
                img2.Save(ms2, img2.RawFormat);

                return ms1.ToArray().SequenceEqual(ms2.ToArray());
            }
        }

        //helper method for call to display default animated photo when user unchoice a both gender
        public void ForDefaultAnimatedPhotoSRP(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.ImageForLoading;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //helper method for call to display default animated photo when user unchoice a both gender
        public void ForDefaultAnimatedPhotoSMP(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.ImageForLoading;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //a method for default course cover photo
        public void DefaultCourseCoverPhotoNCP(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.DefaultCourseCoverImage;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //a method for default course cover photo
        public void DefaultCourseCoverPhotoCMP(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.DefaultCourseCoverImage;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
