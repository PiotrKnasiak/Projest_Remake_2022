using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Projest_Remake_2022
{
    public partial class Form1 : Form
    {
        List<Panel> locations = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            locations.Add(pnlLogin);
            //locations.Add();
            //locations.Add();
            //locations.Add();
            //locations.Add();
            void ChangeWidth(object sender, EventArgs e)
            {
                pnlLogin.Width = this.Width-22;
            }

            this.SizeChanged+=ChangeWidth;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            void FindMiddle(object obj)
            {
                if (obj.GetType() == typeof(Panel))
                {
                    Panel pnl = (Panel)obj;
                    lblTest.Text = (pnl.Width / 2).ToString();
                }
            }

            Stopwatch time = new Stopwatch();

            time.Start();
            FindMiddle(pnlLogin);
        }
        
    }
}