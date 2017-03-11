using System;

namespace SurveyOfThis
{
    public class PrintVisitor : Visitor
    {
        public void visit(Parent wheel)
        {
            Console.WriteLine("Visiting parent");
        }

        public void visit(Child child) {
            Console.WriteLine("Visiting child");
        }
    }
}
