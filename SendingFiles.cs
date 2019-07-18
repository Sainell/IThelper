using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHelper
{
    public class SendingFiles
    {

        public string login;
        public string IPadress;

        ProcessStartInfo process;







        


        public void Ping(string text, out string IPadress)
        {
            login = text;
            
            Process.Start(new ProcessStartInfo { FileName = "cmd.exe", Arguments = $"/c ping {login} -t ", WindowStyle = ProcessWindowStyle.Normal });

            IPadress = login;


        }

        public void Send(string text, out string IPadress)
        {
            login = text;
            process = new ProcessStartInfo(@"cmd.exe", $"/C ping {login}");
            process.WindowStyle = ProcessWindowStyle.Normal;        
            process.RedirectStandardOutput = true;
            process.UseShellExecute = false;
            process.CreateNoWindow = true;
            process.StandardOutputEncoding = Encoding.GetEncoding("CP866");

            Process proc = new Process();
            proc.StartInfo = process;
            proc.Start();


            
            var result = proc.StandardOutput.ReadToEnd();
            //proc.WaitForExit();
            
            IPadress = result;




        }




















    }
}
