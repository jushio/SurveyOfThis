
namespace SurveyOfThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c = new Child();
            Visitor visitor = new Visitor();
            p.acceptOverrided(visitor);    //Visiting parent
            c.acceptOverrided(visitor);    //Visiting child
            p.acceptNotOverrided(visitor); //Parent : Visiting parent
            c.acceptNotOverrided(visitor); //Child : Visiting parent
            p.acceptDynamicType(visitor);    //Visiting parent
            c.acceptDynamicType(visitor);    //Visiting child
        }
    }
}
