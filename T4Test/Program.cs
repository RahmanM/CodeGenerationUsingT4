using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T4Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var ass = Assembly.ReflectionOnlyLoad("CRM.Entities");
                //var types = ass.GetTypes();

                var dll = Assembly.LoadFile(@"D:\rahman\T4Test\T4Test\bin\Debug\CRM.Entities.dll");
                var types = dll.GetTypes();

                foreach (var type in types)
                {
                    Console.WriteLine(type.Name);
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (Exception exSub in ex.LoaderExceptions)
                {
                    sb.AppendLine(exSub.Message);
                    FileNotFoundException exFileNotFound = exSub as FileNotFoundException;
                    if (exFileNotFound != null)
                    {
                        if (!string.IsNullOrEmpty(exFileNotFound.FusionLog))
                        {
                            sb.AppendLine("Fusion Log:");
                            sb.AppendLine(exFileNotFound.FusionLog);
                        }
                    }
                    sb.AppendLine();
                }
                string errorMessage = sb.ToString();
                //Display or log the error based on your application.
                Console.WriteLine(errorMessage);
            }


            Console.ReadLine();

        }
    }
}
