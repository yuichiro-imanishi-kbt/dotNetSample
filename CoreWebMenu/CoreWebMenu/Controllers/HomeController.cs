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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //TaskViewModel list = new TaskViewModel();

            //using (var _db = new OracleConnection(@"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.16.99.121)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=SPIPTDEV))); User Id=SPIK; Password=SPIK"))
            //{
            //    Console.WriteLine("Open connection...");
            //    _db.Open();

            //    OracleCommand cmd = _db.CreateCommand();
            //    StringBuilder sb = new StringBuilder();

            //    sb.AppendLine("SELECT");
            //    sb.AppendLine(" *");
            //    sb.AppendLine("FROM");
            //    sb.AppendLine(" SAMP_M_TASK");
            //    sb.AppendLine("WHERE");
            //    sb.AppendLine("DEL_FLG <> '1'");

            //    sb.ToString();

            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = sb.ToString();

            //    cmd.ExecuteReader();
            //    List<TaskModel> tasks = new List<TaskModel>();

            //    using (OracleDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            TaskModel model = new TaskModel();
            //            model.TaskId = reader["TASK_ID"].ToString();
            //            model.TaskNm = reader["TASK_NM"].ToString();
            //            model.TaskUrl = @"http://localhost/" + reader["TASK_ID"].ToString();

            //            tasks.Add(model);
            //        }
            //    }
            //    list.tasks = tasks;
            //}

            //View(list);

            return View();
        }

        public IActionResult Menu()
        {
            TaskViewModel list = new TaskViewModel();

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
                        //                        model.TaskUrl = @"http://localhost/" + reader["TASK_ID"].ToString();
                        model.TaskUrl = @"http://localhost/clickonce/CoreWinForm.application";

                        tasks.Add(model);
                    }
                }
                list.tasks = tasks;
            }

            View(list);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
