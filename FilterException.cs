using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c#6 using static class 
using static System.Console;
namespace C_Sharp6
{
    class FilterException
    {
        public void ExcaptionFilterBasedOnMessage()
        {
            try
            {
                throw new IOException("missing");
            }
            catch (IOException ioe) when (ioe.Message == "missing")
            {
                //c#6 refering static method
                WriteLine("The file is missing");
            }
            catch (IOException ioe) when (ioe.Message == "cannot open")
            {
                Console.WriteLine("The file is read-only");
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Some other IO exception: {0}", ioe.Message);
            }
        }
    }
}
