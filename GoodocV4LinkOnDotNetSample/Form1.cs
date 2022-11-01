using System;
using System.Runtime.InteropServices;

namespace GoodocV4LinkOnDotNetSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            UInt32.TryParse(textBoxChartCode.Text, out uint chartCode);
            string hospitalCode = textBoxHospitalCode.Text;
            Int32.TryParse(textBoxInitType.Text, out int initType);

            APIWrapper.gdlInit(chartCode, hospitalCode, initType, onCallback);
        }

        private int onCallback(IntPtr json, uint length)
        {
            var jsonString = Marshal.PtrToStringUni(json);
            textBoxReceiveData.Text = jsonString ?? "NULL";

            return 0;
        }

        private void buttonDeinit_Click(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}