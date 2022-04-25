using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.V1
{
    public static class Context
    {
        public static void Demo()
        {
            List<Manuscript> documents = new List<Manuscript>();

            IFormatter formatter = new ReverseFormatter();

            var faq = new Faq(formatter);
            faq.Title = "The bridge pattern FAQ";
            faq.Questions.Add("What is it?", "A design Pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate abstraction from implementation");
            documents.Add(faq);

            var book = new Book(formatter)
            {
                Title = "Design Patterns",
                Author = "Erich Gamma",
                Text = "Some text from the book"
            };
            documents.Add(book);

            var paper = new TermPaper(formatter) 
            {
                Class = "Design Patterns",
                Student = "John Doe",
                Text = "Some Text",
                References = "Some GOF"
            };
            documents.Add(paper);

            foreach (var document in documents)
            {
                document.Print();
            }

        }
    }
}
