using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_chatgpt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //Perform dependency check to make sure all relevant resources are in our output directory.
            Cef.Initialize(new CefSettings()
            {
                CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ChatGPT\\Cache")
            }, performDependencyCheck: true, browserProcessHandler: null);

            InitializeComponent();

            chromiumWebBrowser1.LoadUrl("https://chat.openai.com/");
        }
    }
}
