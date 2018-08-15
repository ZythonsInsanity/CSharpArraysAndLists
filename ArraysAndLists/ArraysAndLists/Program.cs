using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        //How to do Lists:
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);  //Lists can be used with all things like strings, int, char, etc.

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //Different ways to do Arrays:
        //Arrays are used over lists when dealing with large amounts of data.
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        string[] stringArray = new string[7];
        stringArray[0] = "red";
        stringArray[1] = "orange";
        stringArray[2] = "yellow";
        stringArray[3] = "green";
        stringArray[4] = "blue";
        stringArray[5] = "indigo";
        stringArray[6] = "violet";

       
        Console.WriteLine("Select an index of my Rainbow Array and it'll display the corresponding color \non the screen!");

        int rainbowArray = Convert.ToInt32(Console.ReadLine());  
        if (rainbowArray > 6)
        {
            Console.WriteLine("Sorry that index doesn't exist in this rainbow!");
        }       
        else
        {
            Console.WriteLine("Your corresponding color is {0}. Press enter to continue!", stringArray[rainbowArray]);
            Console.ReadLine();
        }

        int[] numbaArray = { 6, 9, 21, 23, 124, 65, 786, 2013 };

        Console.WriteLine("Select an index from my \"Favorite Number Array\" and it'll display one of my \nfavorite numbers!");

        int favNumbers = Convert.ToInt32(Console.ReadLine());
        if (favNumbers > 7)
        {
            Console.WriteLine("Sorry that index doesn't exist in my Favorite Number Array!");
        }
        else
        {
            Console.WriteLine("One of my favorite numbers you have found is {0}. Press enter to continue!", numbaArray[favNumbers]);
            Console.ReadLine();
        }

        List<string> noodleList = new List<string>();
        noodleList.Add("cats");
        noodleList.Add("dogs");
        noodleList.Add("snakes");
        noodleList.Add("frogs");

        Console.WriteLine("Select an index from my \"Favorite Animals\" list and you'll see what one of my \nfavorite animals are!");

        int favAnimals = Convert.ToInt32(Console.ReadLine());
        if (favAnimals > 3)
        {
            Console.WriteLine("Sorry that index doesn't exist in my Favorite Animal Array!");
        }
        else
        {
            Console.WriteLine("One of my favorite animals you have found is {0}. Press enter to continue!", noodleList[favAnimals]);

        }

        Console.ReadLine();
        }
    }

