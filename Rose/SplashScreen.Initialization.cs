using Rose.Content;
using System.Runtime.InteropServices;

namespace Rose
{
    partial class SplashScreen
    {
        void InitializeApp()
        {
			Console.WriteLine(Resources.Strings.app_initializing);

			if (Environment.OSVersion.Version.Major >= 6)
			{
				try
				{
                    SetProcessDPIAware();
                }
				catch (DllNotFoundException)
				{
					ShowAlertDialog(Resources.Strings.user32_dll_not_found);
				}
				Console.WriteLine(Resources.Strings.visual_enhancement_ok);
			}

			else
			{
				ShowAlertDialog(Resources.Strings.visual_enhancement_error_unvalid_os_version);
				Console.WriteLine(Resources.Strings.ERROR + ": " + Resources.Strings.visual_enhancement_error);
			}

            ThreadStart closeSplashScreen = new ThreadStart(delegate ()
            {
				Console.WriteLine("SplashScreen Kapanıyor...");
                Hide();
                HomePage newForm = new HomePage();
                newForm.ShowDialog();
                Close();
            });
            new Thread(new ThreadStart(delegate ()
            {
                Thread.Sleep(1000);
				Invoke(closeSplashScreen);
            })).Start();

        }

		private void ShowAlertDialog(string msg)
		{
			AlertDialogBuilder alertDialogBuilder = new AlertDialogBuilder(this, msg);
			alertDialogBuilder.Type = AlertDialogBuilder.DialogType.Warning;
			alertDialogBuilder.SetPositiveButton(Resources.Strings.ok, null);

			alertDialogBuilder.Create().ShowDialog();
		}

		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
