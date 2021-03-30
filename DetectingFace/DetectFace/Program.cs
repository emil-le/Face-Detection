using DetectFace.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectFace
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = System.Environment.GetEnvironmentVariable("path");
            path += @";c:\temp;C:\Program/ Files\/ (x86)\Intel\iCLS/ Client\;C:\Program/ Files\Intel\iCLS/ Client\;C:\Windows\system32;C:\Windows;C:\Windows\System32\Wbem;C:\Windows\System32\WindowsPowerShell\v1.0\;C:\Program/ Files\Microsoft/ SQL/ Server\110\Tools\Binn\;C:\Program/ Files\Microsoft/ SQL/ Server\120\Tools\Binn\;C:\Program/ Files\Microsoft/ SQL/ Server\Client/ SDK\ODBC\110\Tools\Binn\;C:\Program/ Files/ (x86)\Microsoft/ SQL/ Server\120\Tools\Binn\;C:\Program/ Files\Microsoft/ SQL/ Server\120\DTS\Binn\;C:\Program/ Files/ (x86)\Microsoft/ SQL/ Server\120\Tools\Binn\ManagementStudio\;C:\Program/ Files/ (x86)\Microsoft/ SQL/ Server\120\DTS\Binn\;C:\Windows\system32\config\systemprofile\.dnx\bin;C:\Program Files\Microsoft DNX\Dnvm\;C:\Program/ Files\Git\cmd;C:\Program Files\Microsoft/ SQL/ Server\130\Tools\Binn\;C:\Program/ Files/ (x86)\Microsoft/ SQL/ Server\110\DTS\Binn\;C:\Program Files/ (x86)\Microsoft/ SQL/ Server\130\DTS\Binn\;C:\Program/ Files/ (x86)\Microsoft/ SQL/ Server\140\DTS\Binn\;C:\Users\Zindo\Anaconda3;C:\Users\Zindo\Anaconda3\Library\mingw-w64\bin;C:\Users\Zindo\Anaconda3\Library\usr\bin;C:\Users\Zindo\Anaconda3\Library\bin;C:\Users\Zindo\Anaconda3\Scripts;C:\Users\Zindo\AppData\Local\Programs\Python\Python37-32\Scripts\;C:\Users\Zindo\AppData\Local\Programs\Python\Python37-32\;C:\Users\Zindo\AppData\Local\Microsoft\WindowsApps;C:\Program/ Files\Microsoft/ VS/ Code\bin;D:\python\pycharm\PyCharm/ Community/ Edition/ 2019.1\bin;";
            System.Environment.SetEnvironmentVariable("path", path);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
