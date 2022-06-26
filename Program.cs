// See https://aka.ms/new-console-template for more information
// Make a program that creates an array of length 5.
//Ask the user for five numbers and put them in the array.
//Make a second array of length 5
//use a loop to copy the values out of the original array and into the new one
//Display the contents of both arrays one at a time to illustrate that the Replicator of D`To works


int[] original = new int[5];  // Creates a new Array
for (int item = 0; item < 5; item++) //forloop : item = 0 this is the index of the array. if less than 5, then add one (item++)
{
    Console.Write("Enter a number: "); // Ask the user for a number
    int number = Convert.ToInt32(Console.ReadLine()); // Take user input and place it in the number VAR.
    original[item] = number; //array index = user number .  This will now go back to the for look and start again until it matches 5.
}

int[] updated = new int[5];

Array.Copy(original, updated, 5);




