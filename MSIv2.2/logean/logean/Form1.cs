using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;



namespace logean
{
    public partial class Form1 : Form
    {
        int wait_time = 2;

        string recep_on_msi = "Application/recep.txt";
        string recep_on_pc = "c:/logean/recep.txt";
        string written_on_msi = "Application/written.txt";

        string errorMsg_tryAgain = "The download is not succesfull, dowload the MSI and try it again!";
        string errorMsg_timeOut = "The download is not succesfull, time is out!";
        string errorMsg_connectFailed = "The connection is failed!";

        string infoMsg_connecting = "Connecting...";
        string infoMsg_downloading = "Downloading...";
        string infoMsg_success = "Success...";
        string infoMsg_failed = "Failed...";

        //general
        string labelText = "";
        string pictureName = "connecting_faild.GIF";
        string errorMsg = "";

        OpenNETCF.Desktop.Communication.RAPI myr;
        
        public Form1()
        {
            InitializeComponent();

            label_status.Text = infoMsg_connecting;
            pictureBox_anim.Visible = true;
            pictureBox_notanim.Visible = false;
            

            if (!Directory.Exists("c:/logean"))
                Directory.CreateDirectory("c:/logean");

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Download();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (button_ok.Text == "Cancel")
            {
                if (label_status.Text == infoMsg_connecting)
                    errorMsg = errorMsg_connectFailed;
                else if (label_status.Text == infoMsg_downloading)
                    errorMsg = errorMsg_tryAgain;

                pictureName = "connecting_faild.GIF";
            }
            else
            {
                label_status.Text = infoMsg_success;
                errorMsg = "";
                pictureName = "connecting_ok.GIF";
            }
            this.Close();
        }

        private void Download()
        {
            //kapcsolodas
           try
            {
                myr = new OpenNETCF.Desktop.Communication.RAPI();
                myr.Connect(true);

                pictureBox_anim.Visible = false;
                label_status.Text = infoMsg_downloading;
                this.Refresh();

            }
            catch
            {
                labelText = infoMsg_failed;
                errorMsg = errorMsg_connectFailed;
                pictureName = "connecting_faild.GIF";
                this.Close();
                return;
            }

            timer1.Enabled = true;
            timer1.Interval = 1000;
            button_ok.Visible = false;
            Form1.ActiveForm.ControlBox = false;
            this.Refresh();
            int min = DateTime.Now.Minute;
            
            timer1.Start();
            
            while (timer1.Enabled)
            {
                try
                {
                    if (DateTime.Now.Minute - min > wait_time)
                    {
                        labelText = infoMsg_failed;
                        errorMsg = errorMsg_timeOut;
                        pictureName = "connecting_faild.GIF";
                        timer1.Stop();
                        this.Close();
                        return;
                    }

                    if (myr.DeviceFileExists(written_on_msi))
                    {
                        if (!myr.DeviceFileExists(recep_on_msi))
                        {
                            labelText = infoMsg_failed;
                            errorMsg = errorMsg_tryAgain;
                            pictureName = "connecting_faild.GIF";
                            timer1.Stop();
                            this.Close();
                            return;
                        }

                        timer1.Stop();

                        myr.CopyFileFromDevice(recep_on_pc, recep_on_msi, true);
                        
                        myr.DeleteDeviceFile(recep_on_msi);
                        myr.DeleteDeviceFile(written_on_msi);
                        
                        myr.Disconnect();

                        button_ok.Text = "Ok";
                        button_ok.Visible = true;
                        Form1.ActiveForm.ControlBox = true;
                        labelText = infoMsg_success;
                        errorMsg = "";
                        pictureName = "connecting_ok.GIF";
                        this.Close();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.StartsWith("No connected"))
                    {
                        labelText = infoMsg_failed;
                        errorMsg = errorMsg_connectFailed;
                        pictureName = "connecting_faild.GIF";
                        this.Close();
                        return;
                    }            
                }
            }
            myr.Disconnect();
        }

      
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult l_dlgresult;

            if (button_ok.Text == "Cancel")
            {
                if (label_status.Text == infoMsg_connecting && errorMsg=="")
                    errorMsg = errorMsg_connectFailed;
                else if (label_status.Text == infoMsg_downloading && errorMsg == "")
                    errorMsg = errorMsg_tryAgain;

                pictureName = "connecting_faild.GIF";
            }
            else
            {
                label_status.Text = infoMsg_success;
                errorMsg = "";
                pictureName = "connecting_ok.GIF";
            }

            label_status.Text = labelText;
            pictureBox_anim.Visible = false;
            pictureBox_notanim.Image = imageList1.Images[pictureName];
            pictureBox_notanim.Visible = true;
            this.Refresh();

            System.Threading.Thread.Sleep(1000);
            if (errorMsg != "")
                l_dlgresult = MessageBox.Show(errorMsg, "", MessageBoxButtons.OK);
             
            if (myr.Connected)
                myr.Disconnect();            
        }
    }
}