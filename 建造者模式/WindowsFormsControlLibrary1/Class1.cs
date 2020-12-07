using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibrary1
{
    public class Class1
    {

        public abstract class PersonBuilder
        {
            protected Graphics g;
            protected Pen p;

            public PersonBuilder(Graphics g, Pen p)
            {
                this.g = g;
                this.p = p;
            }

            public abstract void BuildHead();
            public abstract void BuildBody();
            public abstract void BuildArmLeft();
            public abstract void BuildArmRight();
            public abstract void BuildLegLeft();
            public abstract void BuildLegRight();
           

        }

        public class PersonThinBuilder : PersonBuilder
        {
            public PersonThinBuilder(Graphics g, Pen p):base(g,p)
            { }

            public override void BuildArmLeft()
            {
                g.DrawLine(p, 60, 50, 40, 100);
            }

            public override void BuildArmRight()
            {
                g.DrawLine(p, 70, 50, 90, 100);
            }

            public override void BuildBody()
            {
                g.DrawRectangle(p, 60, 50, 10, 50);
            }

            public override void BuildHead()
            {
                g.DrawEllipse(p, 50, 20, 30, 30);
            }

            public override void BuildLegLeft()
            {
                g.DrawLine(p, 60, 100, 45, 150);
            }

            public override void BuildLegRight()
            {
                g.DrawLine(p, 70, 100, 85, 150);
            }
        }

        public class PersonFatBuilder : PersonBuilder
        {
            public PersonFatBuilder(Graphics g, Pen p) : base(g, p)
            { }

            public override void BuildArmLeft()
            {
                g.DrawLine(p, 45, 50, 40, 100);
            }

            public override void BuildArmRight()
            {
                g.DrawLine(p, 85, 50, 90, 100);
            }

            public override void BuildBody()
            {
                g.DrawRectangle(p, 45, 50, 40, 50);
            }

            public override void BuildHead()
            {
                g.DrawEllipse(p, 50, 20, 30, 30);
            }

            public override void BuildLegLeft()
            {
                g.DrawLine(p, 50, 100, 45, 150);
            }

            public override void BuildLegRight()
            {
                g.DrawLine(p, 80, 100, 85, 150);
            }
        }

        public class PersonDirctor
        {
            private PersonBuilder pb;
            public PersonDirctor(PersonBuilder pb)
            {
                this.pb = pb;
            }

            public void CreatePerson()
            {
                pb.BuildArmLeft();
                pb.BuildArmRight();
                pb.BuildBody();
                pb.BuildHead();
                pb.BuildLegLeft();
                pb.BuildLegRight();
            }

        }
    }
}
