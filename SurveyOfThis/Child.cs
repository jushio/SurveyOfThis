namespace SurveyOfThis
{
    public class Child : Parent
    {
        //public void accept(Visitor visitor)
        //{
        //    visitor.visit(this);
        //}

        public override void accept2(Visitor visitor)
        {
            visitor.visit(this);
        }

    }
}