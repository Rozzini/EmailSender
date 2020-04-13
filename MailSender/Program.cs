using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Text;
using FluentScheduler;
using System.Threading;

namespace MailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime thisDate1 = new DateTime(2011, 6, 10);
            //Console.WriteLine("Today is " + thisDate1.ToString("MMMM dd, yyyy") + ".");

            //MM - dd - yyyy - HH - mm { 0:MM - dd - yyyy - HH - mm}
            //DateTime localDate = DateTime.Now;
            //string date = localDate.ToString("MM-dd-yyyy-HH-mm");
            //string fileName = "\\" + date + "-LoggerFile.txt";
            //string path = Directory.GetCurrentDirectory();
            //path += "\\Logger";
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //string filePath = path + fileName;
            //string[] data = {"Logger: " + date};
            //File.AppendAllLines(filePath, data);
        }
    }
}
