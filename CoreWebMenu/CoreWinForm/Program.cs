using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace CoreWinForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new samp001());
        }

        static void GetUrlParameters()
        {
            //// ClickOnce�A�v���̏ꍇ�̂Ƃ��݈̂ȉ��̃R�[�h�����s
            //if (ApplicationDeployment.IsNetworkDeployed == false)
            //{
            //    return;
            //}

            //// �N��URL���擾
            //string url = ApplicationDeployment.CurrentDeployment.ActivationUri.AbsoluteUri;

            //// �N�G�������𒊏o
            //Uri myUri = new Uri(url);
            //string queryString = myUri.Query;
            //if (String.IsNullOrEmpty(queryString))
            //{
            //    return;
            //}

            //// �e�p�����[�^�𕪗����Ē��o
            //string userName = "������";
            //string message = "���b�Z�[�W�͂���܂���";
            //string[] nameValuePairs = queryString.Split('&');
            //foreach (string pair in nameValuePairs)
            //{
            //    string[] vars = pair.Split('=');
            //    if (vars.Length != 2)
            //    {
            //        continue;
            //    }
            //    vars[0] = vars[0].Replace("?", "");  // �g?�h�͍��
            //    if (string.Compare(vars[0], "username", true) == 0)
            //    {
            //        userName = HttpUtility.UrlDecode(vars[1]);
            //    }
            //    else if (string.Compare(vars[0], "message", true) == 0)
            //    {
            //        message = HttpUtility.UrlDecode(vars[1]);
            //    }
            //}

            //// �擾�����e�p�����[�^�����b�Z�[�W�{�b�N�X�ŕ\��
            //MessageBox.Show(userName + "����A" + message + "�B");
        }

    }
}
