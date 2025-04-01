using System.Reflection.Metadata.Ecma335;

class Guest {
    string name;
    
    public string Name() {
        return name;
    }
    
    public Guest(string name_) {
        name = name_;
    }
}