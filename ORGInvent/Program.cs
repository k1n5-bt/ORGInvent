using ORGInvent.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORGInvent
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new Data.MyDbContext())
            {
                if (db.Users.Count() == 0)
                {
                    var data = Encoding.ASCII.GetBytes("secret" + "admin");
                    data = MD5.Create().ComputeHash(data);
                    var hash = Convert.ToBase64String(data);
                    var user = new User() { FullName = "Петров Иван Иванович", IsAdmin = true, Login = "admin", Password = hash };
                    db.Users.Add(user);
                    db.SaveChanges();
                }  
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
