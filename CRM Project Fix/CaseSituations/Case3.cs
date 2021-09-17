using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Creative_Media_Project.CaseSitutations
{
    class Case3
    {
        public Case3()
        {

        }
        public void Intro()
        {
            Console.WriteLine(@"*You are now going to have a discussion with a suspect who may have or been 
involved a armed robbery that occured the police has identified the lead suspect in this
case his name is Charles James Lockhart he is 6'2 25 years old Black and he lives on
6200 S May St. You were given direct orders to bring him for questioning in the nicest
approach but, you can't ignore the firearm he may be wielding on him.*");
            Console.ReadKey(true);
            Console.WriteLine(@"You start to see Mr. Lockhart walking in the sidewalk what do you do:
---------------------------------------------
1) Approach Lockhart kindly
2) Approach Lockhart in a aggressive manner
---------------------------------------------");
        }
        public void ChoiceA1()//Left Side Start
        {
            Console.WriteLine("*You approach politely by saying 'Hello Mr. Lockhart we have some questions for you.'*");
            Console.ReadKey(true);
            Console.WriteLine(@"*He simply ignores you.*
What do want to do now:
-------------------------
1) Ask him again kindly
2) Start to yell at him
-------------------------");

        }        
        public void ChoiceA2()//Right Side to C
        {
            Console.WriteLine("You immediately approach the suspect in a aggressive matter.");
            Console.ReadKey(true);
            Console.WriteLine(@"*He starts making a break for it and you call for backup to your location prior to actually catching up to him.*");
            Console.ReadKey(true);
            Console.WriteLine(@"What do you do here:
--------------------------------
1) Tackle him down
2) Just begin talking with him
--------------------------------");
        }
        public void ChoiceB1()//Same as B2
        {
            Console.WriteLine("*You reiterate the same sentence*");
            TextChange.ChangePrompt(@"What can I do for you officer?", ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine(@"You explain about the robbery that happened at The 'Windy Food Market' on 63rd St.");
            TextChange.ChangePrompt(@"Well I don't know about the robbery at 'Windy Food Market'.", ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine(@"We have evidence that says something else.");
            Console.WriteLine(@"What do you do here:
---------------------------------------
1) Talk it out peacefully
2) Begin to approach him for an arrest
---------------------------------------");
        }
        public void ChoiceB2()
        {
            Console.WriteLine("Hey! I am trying to talk to you ");
            TextChange.ChangePrompt(@"What can I do for you officer?", ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine(@"You explain about the robbery that happened at The 'Windy Food Market' on 63rd St.");
            TextChange.ChangePrompt(@"Well I don't know about the robbery at 'Windy Food Market'.", ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine(@"We have evidence that says something else.");
            Console.WriteLine(@"What do you do here:
---------------------------------------
1) Talk it out peacefully
2) Begin to approach him for an arrest
---------------------------------------");
        }        
        public void ChoiceC1()//Done here
        {
            Console.WriteLine(@"*You have successfully tackle him down and was able to put the handcuffs on and he did have an firearm on him*");
            Console.WriteLine(@"@You bring him in to the station to begin your interrogation@");
        }
        public void ChoiceC2()//To D
        {
            Console.WriteLine(@"*You start talking to him after being very winded right now*");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"What do you want", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"What do you say here:
------------------------------------------
1) State your reason for talking with him
2) Ask why did you run
------------------------------------------");
        }


        public void ChoiceD1()//Same as E1            
        {
            Console.WriteLine(@"Well there was a robbery that happened over at 'Windy City Market' and wanted to have a word with you over at the station.");
            Console.ReadKey(true);
            Console.WriteLine(@"*He claims that he doesn't know about the robbery in the 'Windy City Market'.");
            Console.ReadKey(true);
            Console.WriteLine("Well it does seem like you know something given your tone.");
            Console.ReadKey(true);
            Console.WriteLine(@"What is your next course of action
--------------------------------
1) Try to defuse the situation
2) Approach him for an arrest
--------------------------------"); //1 goes to F 2 goes to firearmpull
        }
        public void ChoiceD2()
        {
            Console.WriteLine(@"Well why did decide to run from me?");
            Console.ReadKey(true);
            Console.WriteLine(@"*He simply remains silent*");
            Console.ReadKey(true);
            Console.WriteLine(@"What do you say here:
--------------------------------------------------
1) Explain your reason for talking with him
2) Tell him you have a good idea on what happened
--------------------------------------------------");//1) leads to where B goes E 2) to 
        }
        public void ChoiceE1()
        {
            Console.WriteLine(@"Well there was a robbery that happened over at 'Windy City Market' and wanted to have a word with you over at the station.");
            Console.ReadKey(true);
            Console.WriteLine(@"*He claims that he doesn't know about the robbery in the 'Windy City Market'.");
            Console.ReadKey(true);
            Console.WriteLine("Well it does seem like you know something given your tone.");
            Console.ReadKey(true);
            Console.WriteLine(@"What is your next course of action
--------------------------------
1) Try to defuse the situation
2) Approach him for an arrest
--------------------------------"); //1 goes to F 2 goes to firearmpull
        }
        public void ChoiceE2()
        {
            Console.WriteLine(@"Well we over at the station have a good idea for why you were running.");
            TextChange.ChangePrompt(@"Well what if I don't want to head over there you officer?", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"What do you do here:
-------------------------------
1) Try to Defuse the situation
2) Approach him for an arrest
-------------------------------");// 1 goes to F 2 goes to Firearmpull
        }
        public void ChoiceF()
        {
            Console.WriteLine(@"We don't want to start anymore trouble right now let's all be a little more cooperative."); 
            Console.WriteLine(@"What do you do here:
-------------------------------
1) Make a promise with him
2) Quickly go in for an arrest
-------------------------------");
        }
        public void ChoiceG1()
        {
            Console.WriteLine(@"You make a promise to Mr. Lockhart about how you and everyone else at the station will
not get rough with you and treat you with respect and care if you just come in peacefully
to the station for questioning.");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Alright fine I will go with you to the station but you better be true to your word.", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"So you got Mr. Lockhart over to the station the peaceful approach and kept your promise to him about ensuring his safety.");
        }//End
        public void ChoiceG2()
        {
            Console.WriteLine(@"You were pretty swift in getting the jump on him and got him into the patrol car forcefully.
Realzing that he actually had the firearm on him you got him in a vulerable state to your advantage.
Later the officers in charge in the case got him to confess to the robbery and will be going to jail.");
        }//End
        public void ChoiceH1()
        {
            Console.WriteLine(@"*You keep your gun nice and steady but the other officers arrive onto the 
scene where you can't dictate the next course of events anymore and follow your
superior officer on the site.*");
            Console.ReadKey(true);
            Console.WriteLine(@"*Together with 5 other officers you get Charles James Lockhart miraciously 
without anyone obtaining any major injuries.*");
        }//End
        public void ChoiceH2()
        {
            Console.WriteLine(@"*You were put in shock and fear for your own safety so you shoot 
Charles James Lockhart a total of 3 times in his center mass and drops to the floor.*");
            Console.ReadKey(true);
            Console.WriteLine(@"*The paramedics take him to the hospital where he is later brought in for
questioning but you knew in the back of your mind that there was another way.*");
        }//End
        public void FirearmPull()
        {
            Console.WriteLine(@"*As you are approaching him slowly to make an arrest he begins to reach 
in to his backside for a gun and you do as well.*");
            Console.ReadKey(true);
            Console.WriteLine(@"What do you do here:
----------------------------
1) Aim the gun at him
2) Or do you start shooting
----------------------------");//To J
        }
        public void End()
        {
            Console.WriteLine("That was the end of Case #65742");
            Console.ReadKey(true);
        }
    }
}
