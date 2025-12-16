using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadPriority
{
    public partial class frmTrackThread: Form
    {
        Thread threadA;
        Thread threadB;
        Thread threadC;
        Thread threadD;


        public frmTrackThread()
        {
            InitializeComponent();
        }

        static void ThreadA()
        {
            Console.WriteLine("Thread A - Highest Priority");
        }

        static void ThreadB()
        {
            Console.WriteLine("Thread B - Normal Priority");
        }

        static void ThreadC()
        {
            Console.WriteLine("Thread C - Above Normal Priority");
        }

        static void ThreadD()
        {
            Console.WriteLine("Thread D - Below Normal Priority");
        }




        private void frmTrackThread_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            threadA = new Thread(ThreadA);
            threadB = new Thread(ThreadB);
            threadC = new Thread(ThreadC);
            threadD = new Thread(ThreadD);

            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();


        }
    }
}
