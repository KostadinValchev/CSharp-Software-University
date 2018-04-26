
using System.Collections.Generic;
using Opinion_Poll;

class Over30
{
    private List<Person> members;

    public Over30()
    {
        this.members = new List<Person>();
    }
    public List<Person> Members { get { return this.members; } }

    public void AddMember(Person member)
    {
        this.members.Add(member);
    }
}