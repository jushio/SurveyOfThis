namespace SurveyOfThis
{
    public class Child : Parent
    {
        //public void accept(Visitor visitor)
        //{
        //    visitor.visit(this);
        //}

        public override void acceptOverrided(Visitor visitor)
        {
            visitor.visit(this);
        }

    }
}