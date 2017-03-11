namespace SurveyOfThis
{
    public interface Visitor
    {
        void visit(Parent c);
        void visit(Child c);
    }
}