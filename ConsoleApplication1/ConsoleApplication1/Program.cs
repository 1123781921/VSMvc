using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using( var context=new CourseDBEntities())
            {
                var departments = context.Departments.OrderBy(n => n.Sortcode).ToList();
                foreach (var d in departments)
                    Console.WriteLine("编号{0},部门名称{1},说明{2}",d.Sortcode,d.Name,d.Dscn);
                Console.ReadKey();
            }
                
        }
    }
}
