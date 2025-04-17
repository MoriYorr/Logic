using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    //ну и что за дела, чего не работаем?
    internal class CreateFile
    {
        static void Main(string name, string format)
        {
            string fullName = name + format;

            try
            {
                using (FileStream fs = File.Create(fullName))
                {

                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}