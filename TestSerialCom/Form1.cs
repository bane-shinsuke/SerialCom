using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestSerialCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;

            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                button1.Text = "**open**";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // If the port is closed, don't try to send a character.
            if (!serialPort1.IsOpen) return;

            // If the port is Open, declare a char[] array with one element.

            char[] buff = new char[1];

            // Load element 0 with the key character.
            buff[0] = 'x';

            // Send the one character buffer.
            serialPort1.Write(buff, 0, 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            char[] buff = new char[1];


            
            if (DateTime.Now.Second == 0)
            {

                // Load element 0 with the key character.
                buff[0] = 'o'; 

            }
            else
            {
                buff[0] = 'x'; 
            }
            // Send the one character buffer.
            serialPort1.Write(buff, 0, 1);
        }
    }
}
