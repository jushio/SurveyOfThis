using System;

namespace SurveyOfThis
{
    public class Parent
    {
        public virtual void acceptOverrided(Visitor visitor)
        {
            visitor.visit(this);
        }

        public void acceptNotOverrided(Visitor visitor)
        {
            Type type = this.GetType();
            Console.Write("This type is" + type.ToString() + ":");
            visitor.visit(this);
        }

        public void acceptDynamicType(Visitor visitor)
        {
            dynamic my = this;
            visitor.visit(my);
        }
    }
}