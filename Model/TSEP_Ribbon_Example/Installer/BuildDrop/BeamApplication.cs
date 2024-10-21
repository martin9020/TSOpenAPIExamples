namespace Tekla.Technology.Akit.UserScript 
{
    public class Script
    {
        public static void Run(Tekla.Technology.Akit.IScript akit)
        {
            string XS_Variable = System.Environment.GetEnvironmentVariable("XSDATADIR");
            string BaseAplicationsPath = System.IO.Path.Combine(XS_Variable, "Environments", "common", "extensions" , "TSOpenAPIExamples");
            string TS_Application = System.IO.Path.Combine(BaseAplicationsPath, "BeamApplication.exe");

            if (System.IO.File.Exists(TS_Application))
            {
                System.Diagnostics.Process Process = new System.Diagnostics.Process();
                Process.EnableRaisingEvents = false;
                Process.StartInfo.FileName = TS_Application;
                Process.Start();
                Process.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(TS_Application + " not found, application stopped!", "Tekla Structures", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}

