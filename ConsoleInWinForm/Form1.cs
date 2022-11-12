using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ConsoleInWinForm
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        bool consoleState = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!consoleState)
            {
                AllocConsole();
                Console.WriteLine("runnig....\n");
                consoleState = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (consoleState)
            {
                Console.Clear();

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (consoleState)
            {
                Console.Clear();
                Console.WriteLine("Enter your number: ");
                string message= Console.ReadLine();
                if (Convert.ToInt32(message)==12)
                {
                    Console.WriteLine(" your number is correct ");
                }
                else
                {
                    Console.WriteLine(" your number is wrong! ");
                }
            }
        }
    }
}
