
namespace SurveyOfThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c = new Child();
            Visitor printVisitor = new PrintVisitor();
            p.accept(printVisitor); //Visiting parent
            c.accept(printVisitor); //Visiting parent
            p.accept2(printVisitor);    //Visiting parent
            c.accept2(printVisitor);    //Visiting child
        }
    }
}
