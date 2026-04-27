using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_WorkEase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
            dashboard_Control1.BringToFront();
            centers_Control1.BringToFront();
            addCenter_Control1.BringToFront();
            worker1.BringToFront();
            addWorker_Control1.BringToFront();
            children_Control1.BringToFront();
            addChildren_Control1.BringToFront();
            
        }
        bool menuExpand = false;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 150)
                {
                    CenterTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 58)
                {
                    CenterTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        private void WorkerTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                WorkerContainer.Height += 10;
                if (WorkerContainer.Height >= 150)
                {
                    WorkerTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                WorkerContainer.Height -= 10;
                if (WorkerContainer.Height <= 58)
                {
                    WorkerTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        private void ChildrenTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                ChildrenContainer.Height += 10;
                if (ChildrenContainer.Height >= 150)
                {
                    ChildrenTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                ChildrenContainer.Height -= 10;
                if (ChildrenContainer.Height <= 58)
                {
                    ChildrenTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard_Control1.BringToFront();
        }
        private void Centers_btn_Click(object sender, EventArgs e)
        {
            CenterTransition.Start();
            centers_Control1.BringToFront();
        }
        private void Worker_btn_Click(object sender, EventArgs e)
        {
            WorkerTransition.Start();
            worker1.BringToFront();
        }
        private void Children_btn_Click(object sender, EventArgs e)
        {
            ChildrenTransition.Start();
        }


        private void Attendance_btn_Click(object sender, EventArgs e)
        {

        }
        private void ManageCenter_btn_Click(object sender, EventArgs e)
        {
            centers_Control1.BringToFront();
        }
        private void Edit_btn_Click(object sender, EventArgs e)
        {
           addCenter_Control1.BringToFront();
        }       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditChildren_btn_Click(object sender, EventArgs e)
        {
            addChildren_Control1.BringToFront();
        }

        private void ManageChildren_btn_Click(object sender, EventArgs e)
        {
            children_Control1.BringToFront();
        }

        private void EditWorker_btn_Click(object sender, EventArgs e)
        {
            addWorker_Control1.BringToFront();
        }

        private void ManageWorker_btn_Click(object sender, EventArgs e)
        {
            worker1.BringToFront();
        }
    }
}
