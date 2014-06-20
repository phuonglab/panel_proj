using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace USBXpress_TestPanel
{
    public partial class TestPanel : Form
    {
        public TestPanel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //on each timer tick we will send out the data from the
            //program to the board and set the appropriate values to
            //the board then, we will read in the data from the board
            //and set the appropriate values to the program

            Int32 IOBufSize = 12;
            Byte[] IOBuf = new Byte[IOBufSize];
            Int32 BytesSucceed = 0;
            Int32 BytesWriteRequest = IOBufSize - 4;
            Int32 BytesReadRequest = IOBufSize - 4;
            
            Byte P0, P1;

            // Get information from form to write to device
            if (checkBox_LED1.Checked)    // LED1
            {
                IOBuf[0] = 1;
            }
            else
            {
                IOBuf[0] = 0;
            }

            if (checkBox_LED2.Checked)    // LED2
            {
                IOBuf[1] = 1;
            }
            else
            {
                IOBuf[1] = 0;
            }

            // Port 1 Bits
            P1 = 0;
            if (checkBox_P10.Checked)
            {
                P1 += 1;
            }
            if (checkBox_P11.Checked)
            {
                P1 += 2;
            }
            if (checkBox_P12.Checked)
            {
                P1 += 4;
            }
            if (checkBox_P13.Checked)
            {
                P1 += 8;
            }
            IOBuf[2] = P1;

            // Send output data out to the board
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(SLUSBXpressDLL.hUSBDevice, ref IOBuf[0], BytesWriteRequest, ref BytesSucceed, 0);

            if ((BytesSucceed != BytesWriteRequest) || (SLUSBXpressDLL.Status != SLUSBXpressDLL.SI_SUCCESS))
            {
                MessageBox.Show("Error writing to USB. Wrote " + BytesSucceed.ToString() + " of " + BytesWriteRequest.ToString() + " bytes. Application is aborting. Reset hardware and try again.");
                Application.Exit();
            }

            //clear out bytessucceed for the next read
            BytesSucceed = 0;

            //read data from the board
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Read(SLUSBXpressDLL.hUSBDevice, ref IOBuf[0], BytesReadRequest, ref BytesSucceed, 0);

            if ((BytesSucceed != BytesReadRequest) || (SLUSBXpressDLL.Status != SLUSBXpressDLL.SI_SUCCESS))
            {
                MessageBox.Show("Error writing to USB. Read " + BytesSucceed.ToString() + " of " + BytesReadRequest.ToString() + " bytes. Application is aborting. Reset hardware and try again.");
                Application.Exit();
            }
            
            //take the newly received array and put it into
            //the form

            //the first two elements have the button status
            if (IOBuf[0] != 0)
            {
                checkBox_Switch1.Checked = true;
            }
            else
            {
                checkBox_Switch1.Checked = false;
            }
            if (IOBuf[1] != 0)
            {
                checkBox_Switch2.Checked = true;
            }
            else
            {
                checkBox_Switch2.Checked = false;
            }
            
            // Display Port 0 Information
            P0 = IOBuf[2];
            if ((P0 & 0x01) == 1)
            {
                checkBox_P00.Checked = true;
            }
            else
            {
                checkBox_P00.Checked = false;
            }
            if ((P0 & 0x02) == 2)
            {
                checkBox_P01.Checked = true;
            }
            else
            {
                checkBox_P01.Checked = false;
            }
            if ((P0 & 0x04) == 4)
            {
                checkBox_P02.Checked = true;
            }
            else
            {
                checkBox_P02.Checked = false;
            }
            if ((P0 & 0x08) == 8)
            {
                checkBox_P03.Checked = true;
            }
            else
            {
                checkBox_P03.Checked = false;
            }

            // Get Analog measurements (Potentiometer and Temp Sensor)
            progressBar_Pot.Value = IOBuf[3];
            label_Pot.Text = IOBuf[3].ToString();
            progressBar_Temp.Value = IOBuf[4];
            label_Temp.Text = IOBuf[4].ToString();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Close(SLUSBXpressDLL.hUSBDevice);
            Application.Exit();    // Exit program
        }

    }
}