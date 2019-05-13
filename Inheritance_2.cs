using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ClassRoom
    {
        public string NameOfClass { get; set; }
        public Pupil[] Pupils { get; set; }

        public ClassRoom(string name, params Pupil[] pupils)
        {
            NameOfClass = name;
            if (pupils.Length > 0 && pupils.Length < 5) Pupils = pupils;
            else throw new IndexOutOfRangeException("The number of students must be in the interval [1,4].");
        }

        public void ShowInfo()
        {
            Console.WriteLine(NameOfClass+":\n");
            foreach(Pupil p in Pupils)
            {
                Console.WriteLine(p.Name+" "+p.Surname);
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
        }
        
    }

    public class Pupil
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Pupil(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public virtual void Study()
        {
            Console.Write(" studies ");
        }

        public virtual void Read()
        {
            Console.Write(" reads ");
        }

        public virtual void Write()
        {
            Console.Write(" writes ");
        }

        public virtual void Relax()
        {
            Console.Write(" relaxes ");
        }

    }

    public class ExcelentPupil: Pupil
    {
        public ExcelentPupil(string name, string surname) :base(name, surname)
        { }

        public override void Study()
        {
            base.Study();
            Console.Write("great\n");
        }
        public override void Read()
        {
            base.Read();
            Console.Write("great\n");
        }
        public override void Write()
        {
            base.Write();
            Console.Write("great\n");
        }
        public override void Relax()
        {
            base.Relax();
            Console.Write("badly\n");
        }
    }

    public class GoodPupil:Pupil
    {
        public GoodPupil(string name, string surname) : base(name, surname)
        { }
        
        public override void Study()
        {
            base.Study();
            Console.Write("well\n");
        }
        public override void Read()
        {
            base.Read();
            Console.Write("well\n");
        }
        public override void Write()
        {
            base.Write();
            Console.Write("well\n");
        }
        public override void Relax()
        {
            base.Relax();
            Console.Write("well\n");
        }
    }

    public class BadPupil:Pupil
    {
        public BadPupil(string name, string surname) : base(name, surname)
        { }

        public override void Study()
        {
            base.Study();
            Console.Write("badly\n");
        }
        public override void Read()
        {
            base.Read();
            Console.Write("badly\n");
        }
        public override void Write()
        {
            base.Write();
            Console.Write("badly\n");
        }
        public override void Relax()
        {
            base.Relax();
            Console.Write("great\n");
        }
    }

    class Inheritance_2
    {
        static void Main(string[] args)
        {
            try
            {
                ClassRoom class1 = new ClassRoom("Classroom 1", new ExcelentPupil("Andy", "Warhol"), new GoodPupil("Amy", "Winehouse"), new BadPupil("Leonardo", "DiCaprio"));
                class1.ShowInfo();
                ClassRoom class2 = new ClassRoom("Classroom 2", new ExcelentPupil("Stanley", "Kubrick"), new GoodPupil("David", "Bowie"));
                class2.ShowInfo();
                ClassRoom class3= new ClassRoom("Classroom 3", new ExcelentPupil("Emma", "Watson"), new GoodPupil("David", "Lynch"), new BadPupil("Tim", "Burton"), new GoodPupil("Brendon", "Urie"));
                class3.ShowInfo();
                ClassRoom class4= new ClassRoom("Classroom 4", new ExcelentPupil("Uma", "Thurman"), new GoodPupil("Bruce", "Willis"), new BadPupil("Tim", "Roth"), new GoodPupil("Gerard", "Way"), new ExcelentPupil("Guy", "Ritchie"));
                class4.ShowInfo();
            }
            catch (Exception exp) { Console.WriteLine(exp.Message); }
            Console.ReadKey();
        }
    }
}
