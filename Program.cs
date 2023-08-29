// See https://aka.ms/new-console-template for more information





//---------------------------------------------Three Basic Arrays---------------------------------------------
// Create an integer array with the values 0 through 9 inside.
int[] myArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (int val in myArray)
{
    Console.WriteLine(val);
}


// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] namesArray = new string[] { "Tim", "Martin", "Nikki", "Sara" };
foreach (string name in namesArray)
{
    Console.WriteLine(name);
}


// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. 
//(Tip: do this using logic! Do not hard-code the values in!)
bool[] boolArray = new bool[10];
for (int i =0; i<boolArray.Length; i++)
{
    if (i % 2 == 0)
    {
        boolArray[i] = true;
    }
    else
    {
        boolArray[i] = false;
    }
}

foreach (bool val in boolArray)
{
    Console.WriteLine(val);
}





//---------------------------------------------List of Flavors---------------------------------------------
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> Icecream = new();
Icecream.Add("Durian");
Icecream.Add("Abuelita Chocolate");
Icecream.Add("Black Sesame");
Icecream.Add("Lavender");
Icecream.Add("Vietnamese Coffee");

foreach  (string s in Icecream)
{
    Console.WriteLine(s);
}


// Output the length of the List after you added the flavors.
Console.WriteLine($"Our shop has {Icecream.Count} flavors.");


// Output the third flavor in the List.
Console.WriteLine(Icecream[2]);
Console.WriteLine($"My favorite flavor is " + Icecream[2]); 


// Now remove the third flavor using its index location.
Icecream.RemoveAt(2);
foreach  (string s in Icecream)
{
    Console.WriteLine(s);
}

// Output the length of the List again. It should now be one fewer.
Console.WriteLine($"Our shop has {Icecream.Count} flavors.");





//---------------------------------------------User Dictionary---------------------------------------------
// Create a dictionary that will store string keys and string values.
Dictionary<string, string> UserDictionary = new Dictionary <string, string>();
Random RandomType = new Random();

// Add key/value pairs to the dictionary where:
    //Each key is a name from your names array (this can be done by hand or using logic)
    // Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)

UserDictionary.Add(namesArray[0],Icecream[RandomType.Next(0,4)]);
UserDictionary.Add(namesArray[1],Icecream[RandomType.Next(0,4)]);
UserDictionary.Add(namesArray[2],Icecream[RandomType.Next(0,4)]);
UserDictionary.Add(namesArray[3],Icecream[RandomType.Next(0,4)]);



// Loop through the dictionary and print out each user's name and their associated ice cream flavor.
foreach (KeyValuePair<string, string> entry in UserDictionary){
    Console.WriteLine($"User {entry.Key} likes {entry.Value}");
}