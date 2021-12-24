using CoreWebMenu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace CoreWebMenu.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login form)
        {
            ModelState.Clear();
            String id = form.Id;
            String password = form.Password;

            UsersModel model = new UsersModel();

            using (var _db = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.16.99.121)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=SPIPTDEV))); User Id=SPIK; Password=SPIK"))
            {
                Console.WriteLine("Open connection...");
                _db.Open();

                OracleCommand cmd = _db.CreateCommand();
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("SELECT");
                sb.AppendLine(" *");
                sb.AppendLine("FROM");
                sb.AppendLine(" SAMP_M_USER");
                sb.AppendLine("WHERE");
                sb.AppendLine("USER_ID = :userid");
                sb.AppendLine("AND PASSWORD = :pass");
                sb.AppendLine("AND DEL_FLG <> '1'");

                sb.ToString();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sb.ToString();
                OracleParameter userid = new OracleParameter();
                userid.OracleDbType = OracleDbType.Varchar2;
                userid.Value = id;

                OracleParameter pass = new OracleParameter();
                pass.OracleDbType = OracleDbType.Varchar2;
                pass.Value = password;

                cmd.Parameters.Add(userid);
                cmd.Parameters.Add(pass);

                cmd.ExecuteReader();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        model.UserId = reader["USER_ID"].ToString();
                        model.UserNm = reader["USER_NM"].ToString();

                    }
                }
            }

            if (!String.IsNullOrEmpty(model.UserId))
            {
                return RedirectToAction("Menu", "Home");
            } else
            {
                throw new Exception("ログインエラー");
                //form.Error = "該当するユーザーが存在しません";
                //return View("Index", form);
            }
        }

        public IActionResult Login()
        {
            using (var _db = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.16.99.121)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=SPIPTDEV))); User Id=SPIK; Password=SPIK"))
            {
                Console.WriteLine("Open connection...");
                _db.Open();

                OracleCommand cmd = _db.CreateCommand();
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("SELECT");
                sb.AppendLine(" *");
                sb.AppendLine("FROM");
                sb.AppendLine(" SAMP_M_TASK");
                sb.AppendLine("WHERE");
                sb.AppendLine("DEL_FLG <> '1'");

                sb.ToString();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sb.ToString();

                cmd.ExecuteReader();
                List<TaskModel> tasks = new List<TaskModel>();

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaskModel model = new TaskModel();
                        model.TaskId = reader["TASK_ID"].ToString();
                        model.TaskNm = reader["TASK_NM"].ToString();
                        model.TaskUrl = @"http://localhost/" + reader["TASK_ID"].ToString();

                        tasks.Add(model);
                    }
                }
                //list.tasks = tasks;
            }


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
