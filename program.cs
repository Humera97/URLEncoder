using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool newURL = true;
            while (newURL == true) {
                Console.WriteLine("What is the name of the project? ");
                string project = Console.ReadLine();
                if (project.Contains(""))
                {
                    Console.WriteLine("Invalid input. Please try again. What is the name of your project? ");
                    project = Console.ReadLine();
                }
                project = project.Replace(" ", "%20").Replace("<", "3C").Replace(">", "%3E").Replace("#", "%23").Replace("#", "%23").Replace("%", "%25").Replace("'\u0022'", "%22")
                .Replace(";", "%3B").Replace("/","%2F").Replace("?", "%3F").Replace(":", "%3A").Replace("@", "%40").Replace("&", "%26").Replace("=", "%3D").Replace("+", "%2B").Replace("$", "%24").Replace("{", "%7B")
                .Replace("}", "%7D").Replace("|", "%7C").Replace("^", "%5E").Replace("[", "%5B").Replace("]", "%5D").Replace("`", "%60");
                Console.WriteLine("What is the name of the activity? ");
                string activity = Console.ReadLine();
                if (activity.Contains(""))
                {
                    Console.WriteLine("Invalid input. Please try again. What is the name of your project? ");
                    activity = Console.ReadLine();
                }
                activity = activity.Replace(" ", "%20").Replace("<", "3C").Replace(">", "%3E").Replace("#", "%23").Replace("#", "%23").Replace("%", "%25").Replace("'\u0022'", "%22")
                .Replace(";", "%3B").Replace("/", "%2F").Replace("?", "%3F").Replace(":", "%3A").Replace("@", "%40").Replace("&", "%26").Replace("=", "%3D").Replace("+", "%2B").Replace("$", "%24").Replace("{", "%7B")
                .Replace("}", "%7D").Replace("|", "%7C").Replace("^", "%5E").Replace("[", "%5B").Replace("]", "%5D").Replace("`", "%60");
                Console.WriteLine("What is the name of the activity? ");
                string URL = "https://companyserver.com/content/" + project + "/files/" + activity + "/" + activity + "Report.pdf";
                Console.WriteLine(URL);
                Console.WriteLine("Would like to input another URL? (y/n)");
                string another = Console.ReadLine();
                if (another == "n") {
                    newURL = false;
                }
            
            }
           



        }

    }
}
   



