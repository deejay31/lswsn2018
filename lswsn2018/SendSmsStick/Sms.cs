using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SendSmsStick
{
    public class Sms
    {
        public static string SendSms(List<SmsDTO> data)
        {
            string result = "Success";

            var info = data.ToList();

            if (data.Count > 0)
            {
                SerialPort serialport = new SerialPort();

                string text = Device.Port;
                if (serialport.IsOpen)
                {
                    serialport.Close();
                }
                try
                {
                    serialport.PortName = text;
                    serialport.BaudRate = 115200;
                    serialport.Parity = Parity.None;
                    serialport.DataBits = 8;
                    serialport.StopBits = StopBits.One;
                    serialport.DtrEnable = true;
                    serialport.RtsEnable = true;
                    serialport.NewLine = System.Environment.NewLine;
                    serialport.Open();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                try
                {
                    foreach (var item in info)
                    {
                        serialport.WriteLine("AT+CMGF=1" + System.Environment.NewLine + (char)(13));
                        Thread.Sleep(200);
                        serialport.WriteLine(("AT+CMGS=\"" + item.number) + "\"");
                        Thread.Sleep(200);
                        serialport.WriteLine(item.message + System.Environment.NewLine + (char)(26));
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                serialport.Close();
            }
            return result;
        }
    }
}
