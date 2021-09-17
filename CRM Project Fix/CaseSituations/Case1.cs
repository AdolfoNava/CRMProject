using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Creative_Media_Project.CaseSitutations
{
    class Case1
    {
        public Case1()
        {

        }
        public void Intro()
        {
            Console.WriteLine(@"You see a driver of a silver 2004 volkswagen Phaeton around 43rd st and
Ashland Ave moving north. It appears that the vehicle has been in really good condition.
The driver does not appear to have been wearing a seatbelt and thus you pull over
the vehicle and get to start talking with the person by himself late in the evening.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Pretty late drive at this evening right?");
            TextChange.ChangePrompt(@"Yeah you are right officer. I am pretty tired been working pretty long today.",
                ConsoleColor.Black,ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"What do you want to say to the man in car right now?
-------------------------------------------
1) Sir do you know why I pulled you over?
2) License and Registration please?
3) Why aren't you wearing a seat belt?
4) Step out of the Vehicle sir.
-------------------------------------------");
        }
        public void ChoiceA1()
        {
            Console.WriteLine("Sir do you know why I pulled you over?");
            TextChange.ChangePrompt(@"No officer I don't know.",
                ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine("I pulled you over because I saw that you were driving without a seat belt.");
            Console.ReadKey(true);
            Console.WriteLine("Alright then you just wait right where you are.");
            Console.ReadKey(true);
        }
        public void ChoiceA2()
        {
            Console.WriteLine("License and Registration please?");
            TextChange.ChangePrompt(@"What for officer?",
    ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine("I pulled you over because I saw that you were driving without a seat belt.");
            Console.ReadKey(true);
            Console.WriteLine("Alright then you just wait right where you are.");
            Console.ReadKey(true);
        }
        public void ChoiceA3()
        {
            Console.WriteLine("Why aren't you wearing a seat belt?");
            TextChange.ChangePrompt(@"Oh damn, I forgot to put it on.",
    ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine("Alright then you just wait right where you are.");
            Console.ReadKey(true);
        }
        public void ChoiceA4()
        {
            Console.WriteLine("Step out of the Vehicle sir.");
            TextChange.ChangePrompt(@"What's the problem officer?",
    ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine("I pulled you over because I saw that you were driving without a seat belt.");
            Console.ReadKey(true);
            Console.WriteLine("Alright then you just wait right where you are.");
            Console.ReadKey(true);
        }
        public void Dicovery()
        {
            Console.WriteLine(@"You now have obtained his license and registration without any problem
whatsoever and head over to the police computer and pull information about him the name is 
Conner Masters,
Age: 35
He hasn't been given any citations within the past 12 years. Overall, he seems to have relatively clean
record over the years and now with that information you have to decide how to deal with this issue.
Do you:
------------------------------------------------------
1) Give Connor Masters a ticket
2) Say 'Well next try to be more careful next time.'
------------------------------------------------------
");
            Console.ReadKey(true);
        }
        public void ChoiceB1()
        {
            TextChange.ChangePrompt("This is bullshit!!", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"You sensed intense hostility from Conner now have to make an important decision to make do you:
----------------------------------------------------------------------
1) Well, just don't drive without putting on a seatbelt it's the law.
2) Do you want another ticket?
----------------------------------------------------------------------");
        }
        public void ChoiceB2()
        {
            Console.WriteLine(@"You have decided to now leave the individual alone 
and get back to your vehicle and drive off.");
            Console.ReadKey(true);
            Console.WriteLine(@"You begin to go back into your patrol car go
about your business for the rest of your shift.");
        }
        public void ChoiceC1()
        {
            Console.WriteLine("Well, just don't drive without putting on a seatbelt it's the law.");
            Console.ReadKey(true);
            Console.WriteLine(@"You begin to go back into your patrol car go 
about your business for the rest of your shift.");
        }
        public void ChoiceC2()
        {
            Console.WriteLine("Do you want another ticket?");
            Console.ReadKey(true);
            Console.WriteLine("*Gives them another ticket for contempt*");
            TextChange.ChangePrompt("What the fuck?",ConsoleColor.Black,ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine("Get out of the vehicle");
            Console.Clear();
            Console.ReadKey(true);
            Console.WriteLine("*You now proceed to handcuff the person*");
            Console.ReadKey(true);
            Console.WriteLine(@"You take the driver into your patrol car 
and make a call to have that vehicle towed.");
            Console.ReadKey(true);

        }
        public void End()
        {
            Console.Clear();
            Console.WriteLine("That was the end of Case# 41356");
            Console.ReadKey(true);
        }
    }
}
