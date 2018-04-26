using System.Collections.Generic;
using System.Linq;

namespace Family_Tree
{
    public class Person
    {
        private string name;
        private string birthDate;

        private List<Person> children;

        public Person()
        {
            this.children = new List<Person>();
        }

        public Person(string name, string date) : this()
        {
            this.Name = name;
            this.BirthDate = date;
        }

        public string BirthDate { get; set; }

        public string Name { get; set; }

        public IReadOnlyList<Person> Children
        {
            get { return this.children.AsReadOnly(); }
        }

        public void AddChild(Person child)
        {
            this.children.Add(child);
        }

        public void AddChildrenInfo(string name, string date)
        {
            if (this.children.FirstOrDefault(c => c.Name == name) != null)
            {
                this.children.FirstOrDefault(c => c.Name == name).BirthDate = date;
                return;
            }
            if (this.children.FirstOrDefault(c => c.BirthDate == date) != null)
            {
                this.children.FirstOrDefault(c => c.BirthDate == date).Name = name;
                return;
            }
        }

        public Person FindChildName(string childName)
        {
            return this.children.FirstOrDefault(c => c.Name == childName);
        }
    }
}