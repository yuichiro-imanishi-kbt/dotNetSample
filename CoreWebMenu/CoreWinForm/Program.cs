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
            //// ClickOnceアプリの場合のときのみ以下のコードを実行
            //if (ApplicationDeployment.IsNetworkDeployed == false)
            //{
            //    return;
            //}

            //// 起動URLを取得
            //string url = ApplicationDeployment.CurrentDeployment.ActivationUri.AbsoluteUri;

            //// クエリ部分を抽出
            //Uri myUri = new Uri(url);
            //string queryString = myUri.Query;
            //if (String.IsNullOrEmpty(queryString))
            //{
            //    return;
            //}

            //// 各パラメータを分離して抽出
            //string userName = "名無し";
            //string message = "メッセージはありません";
            //string[] nameValuePairs = queryString.Split('&');
            //foreach (string pair in nameValuePairs)
            //{
            //    string[] vars = pair.Split('=');
            //    if (vars.Length != 2)
            //    {
            //        continue;
            //    }
            //    vars[0] = vars[0].Replace("?", "");  // “?”は削る
            //    if (string.Compare(vars[0], "username", true) == 0)
            //    {
            //        userName = HttpUtility.UrlDecode(vars[1]);
            //    }
            //    else if (string.Compare(vars[0], "message", true) == 0)
            //    {
            //        message = HttpUtility.UrlDecode(vars[1]);
            //    }
            //}

            //// 取得した各パラメータをメッセージボックスで表示
            //MessageBox.Show(userName + "さん、" + message + "。");
        }

    }
}
