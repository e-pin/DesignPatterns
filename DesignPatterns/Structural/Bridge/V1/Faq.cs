using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.V1
{
    public class Faq : Manuscript
    {
        public Faq(IFormatter formatter) : base(formatter)
        {
            this.Questions = new Dictionary<string, string>();
        }
        public string Title { get; set; }

        public Dictionary<string, string> Questions { get; set; }

        public override void Print()
        {
            Console.WriteLine("Faq Print");
            Console.WriteLine(this.Title);
            foreach (var question in Questions)
            {
                Console.WriteLine(formatter.Format(question.Key, question.Value));
            }
            Console.WriteLine();
        }

    }
}
