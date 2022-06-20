// See https://aka.ms/new-console-template for more information

string Preamble = "We the People of the United States, in Order to form a more perfect Union, establish Justice, insure domestic Tranquility, provide for the common defence, promote the general Welfare, and secure the Blessings of Liberty to ourselves and our Posterity, do ordain and establish this Constitution for the United States of America.";

string[] subs = Preamble.Split(' ', ',');  // I wasn't sure how to split up each word in the string but I found out that you can seperate them by using the String.Split method from this website https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=net-6.0

int countT = 0; // The count has to start at 0 so that it can add up every word later
int countE = 0;
int countTE = 0;
foreach (var sub in subs)  // This takes every individual word in the Preamble and does the work below
{


    
    if (sub.StartsWith("t") || sub.StartsWith("T")) 
    {
        countT++; // This adds up every word that starts with a t or a T
       
    }

    if (sub.EndsWith("e") || sub.EndsWith("E")) //At first I used an Else If statement but I realized that would not count up all the words correctly so I used seperate If statements
    {
        countE++; // This adds up every word that ends with an e or an E
    }
    
    if (sub.StartsWith("t") && sub.EndsWith("e"))
    {
        countTE++; // This adds up every word that starts with a t and ends wirh an e
    }
    
}
Console.WriteLine("{0} words start with the letter t", countT); // I initially put the WriteLine statements inside of the If statements but that added a WriteLine statement for each individual instance of words that started with t so I had to put them outside of the for each loop
Console.WriteLine("{0} words end with the letter e", countE);
Console.WriteLine("{0} words start with the letter t and end with the letter e", countTE);
