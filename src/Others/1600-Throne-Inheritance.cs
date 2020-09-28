public class ThroneInheritance {

    private List<string> orders;
    private Person king;
    private Dictionary<string,Person> family;
    
    public ThroneInheritance(string kingName) {
        
        king = new Person(kingName);
        family = new Dictionary<string,Person>{{kingName, king}};
    }
    
    public void Birth(string parentName, string childName) {
        
        var parent = family[parentName];
        var newPerson = new Person(childName);        
        parent.Childs.Add(newPerson);
        family.Add(childName, newPerson);
    }
    
    public void Death(string name) {
        
        var person = family[name];
        person.Dead = true;
    }
    
    public IList<string> GetInheritanceOrder() {
        
        orders = new List<string>();
        GetOrderInternal(king);
        return orders;
    }
    
    private void GetOrderInternal(Person node)
    {
        if(node == null) return;
        
        if(!node.Dead)
        {
            orders.Add(node.Name);            
        }
        
        foreach(var child in node.Childs)
        {
            GetOrderInternal(child);            
        }                        
    }
}

public class Person {
    
    public List<Person> Childs;
    public bool Dead;
    public string Name;
    
    public Person(string name)
    {
        Name = name;
        Dead = false;
        Childs = new List<Person>();
    }
}

/**
 * Your ThroneInheritance object will be instantiated and called as such:
 * ThroneInheritance obj = new ThroneInheritance(kingName);
 * obj.Birth(parentName,childName);
 * obj.Death(name);
 * IList<string> param_3 = obj.GetInheritanceOrder();
 */
