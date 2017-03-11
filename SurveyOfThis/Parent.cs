namespace SurveyOfThis
{
    public class Parent
    {
        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }

        public virtual void accept2(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}