using CourseManagement.View.Forms;
using static CourseManagement.Tools.Enums.CircleTypes;

namespace CourseManagement
{
    public partial class LoadingPage : Form
    {
        //startPointForLP - need for change 3 button's color
        private int startPointForLP = 0;

        public LoadingPage()
        {
            InitializeComponent();

            DisableTabStopForAllControls(this);
        }
        
        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timerForLP.Enabled = true;
        }

        private void timerForLP_Tick(object sender, EventArgs e)
        {
            startPointForLP += 1;

            ChangeCircleColor(CircleType.LDLP, Color.FromArgb(0, 71, startPointForLP));
            ChangeCircleColor(CircleType.LULP, Color.FromArgb(0, 71, startPointForLP));
            ChangeCircleColor(CircleType.RULP, Color.FromArgb(0, 71, startPointForLP));

            ProgressIndicatorForLP.Start();

            if (startPointForLP == 160)
            {
                //the AuthenticationPage' instance was created here!
                AuthenticationPage authenticationPage = new AuthenticationPage();

                ProgressIndicatorForLP.Stop();
                timerForLP.Enabled = false;
                timerForLP.Stop();

                //and the current form was hide
                this.Hide();
                //then authenticationPage's instance was shown!
                authenticationPage.Show();
            }
        }

        private void ChangeCircleColor(CircleType circleType, Color color)
        {
            switch (circleType)
            {
                case CircleType.LDLP:
                    CircleShapeLDLP.FillColor = color;
                    break;
                case CircleType.LULP:
                    CircleShapeLULP.FillColor = color;
                    break;
                case CircleType.RULP:
                    CircleShapeRULP.FillColor = color;
                    break;
            }
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


        //for disabling tab key
        private void DisableTabStopForAllControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                c.TabStop = false;

                //if the control has child controls, also recursively disable TabStop for them as well
                if (c.HasChildren)
                {
                    DisableTabStopForAllControls(c);
                }
            }
        }
    }
}
