Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);




//Dog myDog = new Dog("Good Boy");
Dog neighboursDog = new Dog("Good Girl");



Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}");


myDog.Rename("BAD BOY") ;

while (myDog.LevelofHapiness != 5)

{

    myDog.Bark();
}

myDog.WagTail();
//Console.WriteLine($"Level of happiness: {myDog.LevelofHapiness}") ;

//myDog.Bark();
//Console.WriteLine($"Level of happiness: {myDog.LevelofHapiness}");


class Dog
{
    private string _name = "Koer"; //field
    private int _levelofHapiness = 0;

    //constructor

    public Dog(string name) //name - lets the user name the dog
    { 
    _name= name;
        _levelofHapiness = 0;
    }

    //getter
    public string Name
    { get { return _name; } }


    public int LevelofHapiness
    {
        get { return _levelofHapiness;}
    }
    public void Rename(string newName)
    { 
    _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof");

        _levelofHapiness++;
            }

    public void WagTail()
    {
        Console.WriteLine("Wingle-wigle!");
    }
}
