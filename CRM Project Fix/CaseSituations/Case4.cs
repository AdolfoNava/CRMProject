using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Creative_Media_Project.CaseSitutations
{
    class Case4
    {
        public Case4()
        {

        }
        public void Intro()
        {
            Console.WriteLine(@"There was a call in at W 118st where the caller is saying that there were two people
in his front yard coming in to steal his vehicle in the middle of broad daylight. So you arrive on
the scene and there is two slim and young latinos attempting to get inside the car and the owner
of 2002 Honda Accord is a Black man who appears to be in his late 20s.");
            Console.ReadKey(true);
            Console.WriteLine(@"*You begin by aproaching the building and you start to ask what is going on and the 
person who made the call talks to you and says:*");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"I'm getting my car jacked right outside my house right now.", ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine(@" What do you want to do:
-----------------------------------------------------------
1) Talk to the guys who were attempt to take the car away
2) Speak first to the owner
-----------------------------------------------------------");

        }
        public void ChoiceA1()//Left
        {
            Console.WriteLine(@"*You talk with the two men who are attempting to take the car away*");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Officer, I am just trying to take in a car for not paying his monthly payment.", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.ReadKey(true);
            Console.WriteLine(@"What do you say about that:
---------------------------------------------------------------
1) Ask if they already checked about the status of the repo
2) Ask for proof that they were working with the repo company
---------------------------------------------------------------");
        }
        public void ChoiceA2()//Right needs work same as ChoiceC2
        {
            Console.WriteLine(@"So you speak to the owner and he says:");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Listen officer I just earlier today went and paid a portion of what I already owed.", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"What do think that you should do here?
--------------------------------------------------------------------------
1) Calm down both parties
2) Reassure to the repo guys that maybe the car has been somewhat paid for
--------------------------------------------------------------------------");
        }
        public void ChoiceB1()
        {
            Console.WriteLine(@"Did you check with the dealership about the car before coming here?");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"No we haven't gotten in touch with the dealership at all day we have been busy looking for the car.", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.ReadKey(true);
            Console.WriteLine(@"So what do you ask the guys doing the repo job?
----------------------------------------------
1) Start to Disagree with the repo's decision
2) Ask to double check the status of this car
----------------------------------------------");
        }
        public void ChoiceB2()//Get Back to
        {
            Console.WriteLine(@"Do you have proof that you work with the dealership?");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"I can call the boss right now.", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.ReadKey(true);
            Console.WriteLine(@"*The situation gets cleared up about how there was a large payment made to the dealership and they just quickly leave the scene and soon so do you two.*");
        }
        public void ChoiceC1()
        {
            Console.WriteLine(@"Well I don't like how this situation is turning out.");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.ReadKey(true);
            Console.WriteLine(@"What do you wanna do?
---------------------------------------------------------------------------
1) Urge the repo guys to go check it out
2) Suggest the repo team to stop them from making a potential mistake
---------------------------------------------------------------------------");
        }
        public void ChoiceC2()//
        {
            Console.WriteLine(@"*The owner comes over to say:*");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Listen officer I just earlier today went and paid a portion of what I already owed.", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"What do think that you should do here?
--------------------------------------------------------------------------
1) Calm down both parties
2) Reassure to the repo guys that maybe the car has been somewhat paid for
--------------------------------------------------------------------------");
        }
        public void ChoiceD1()//Far Left Done here
        {
            Console.WriteLine(@"Well lets just see if the owner's story checks out with the local dealership");
            Console.ReadKey(true);
            Console.WriteLine(@"*Sure enough the owner was correct the whole time and the guys were doing the repo job
apologized to the owner and went back to work on a another car repo job and you go back to the standard patrol.*");
            Console.ReadKey(true);
        }
        public void ChoiceD2()//Far left Goes into the E choices
        {
            Console.WriteLine(@"Well we can't have you come in making a mistake right now.");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Well I have to take in this car to get paid officer let me go take the car.", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Bullshit! you guys have no right to just take my car!", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"What do you choose to do next:
----------------------------------------------------------------
1) Calm down the owner
2) Discuss with the repos guys about how they shouldn't take it
----------------------------------------------------------------");
        }
        public void ChoiceE1()
        {
            Console.WriteLine(@"Listen sir just calm down.");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Come on officer they are trying to steal my car that I am making payments for.", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Well I am just trying to do my job officer you gotta understand.", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.ReadKey(true);
            Console.WriteLine(@"*The car owner heads back inside to then come moments later to give a glock 9mm handgun.*");
            Console.ReadKey(true);
            Console.WriteLine(@"What do you do about this now:
---------------------------------------------
1) Reassure him that his car won't be taken
2) Tell him to stand down
---------------------------------------------");
        }
        public void ChoiceE2()
        {
            Console.WriteLine(@"*You emphasize to the repo guys that you shouldn't take the car without getting this sorted first*");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"That is shit that he has to deal with the dealer right now not me.", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Hey stop that shit! What the fuck man!", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"*The car owner heads back inside to then come moments later to give a glock 9mm handgun.*");
            Console.ReadKey(true);
            Console.WriteLine(@"What do you do about this now:
---------------------------------------------
1) Reassure him that his car won't be taken
2) Tell him to stand down
---------------------------------------------");
        }
        public void ChoiceF1()//End route here
        {
            Console.WriteLine(@"*you reassure him that his car won't be taken without having everything checkout*.");
            Console.WriteLine(@"*The fear of the whole situation got them to finally check back with the people over 
at the dealership and finally cleared everything up.*");
            Console.ReadKey(true);
            Console.WriteLine(@"*They have profusely apologized direct to the gun owner and have decided not to charge
anyone on the scene once everything was finally settled.*");
        }
        public void ChoiceF2()
        {
            Console.WriteLine(@"*You generally try to calm him down by saying that:* 'he shouldn't do this now.' ");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"I need the car tomorrow for my job they shouldn't get away with taking my car away.", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"This situation has definitely reached the tipping point do you:
------------------------------------------------------------------
1) forcibly disarm him because he is beside you
2) Get in front of the gun and give a final plead to the repo guys
------------------------------------------------------------------");
        }
        public void ChoiceG1()
        {
            Console.WriteLine(@"*You are quickly able to disarm him and detain him for acting irrationally.*");
            Console.ReadKey(true);
            Console.WriteLine(@"*He did legally obtained the firearm but now it is now been confiscated
and charged for threatening the repo guys.*");
            Console.ReadKey(true);
            Console.WriteLine("*You take the owner of the car to the station to be processed.*");
        }
        public void ChoiceG2()
        {
            Console.WriteLine(@"*You tried to get in front of the officer and take one shot to the right side.*");
            Console.ReadKey(true);
            Console.WriteLine(@"*After the shot was fired you gave a final plead to the repo guys to just check in with the repo guys*.");
            Console.ReadKey(true);
            Console.WriteLine(@"*The owner felt deep regret after the whole situation settled down and willingly 
came in to the station firearm but he is officially charged for threatening the repo guys and Injurying a peace
officer. Your injury was worth it because it could've killed one of the repo guys and thankfully the bullet just
travelled to the arm.*");
        }
        public void ChoiceH1()//Choice A2 and C2
        {
            Console.WriteLine(@"Alright let's all stop all this chaos and get the full story.");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Well we gotta take the car and have the dealership and him deal with it.", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.ReadKey(true);
            Console.WriteLine(@"What do you decide on what to do:
----------------------------------------------------------------
1) Calm down the owner
2) Discuss with the repos guys about how they shouldn't take it
----------------------------------------------------------------");
            
        }
        public void ChoiceH2()//bullshit
        {
            Console.WriteLine(@"So essentially, not everything is paid for but you guys are coming in to take the car still.");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Well we didn't hear anything from the dealership so that tells us
something else.", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.ReadKey(true);
            Console.WriteLine(@"What should you do:
--------------------------------------------------------------------------------------
1) Try and convince the repo team to believe the owner
2) Remind them that could have just forgotten about telling you earlier in the day
--------------------------------------------------------------------------------------");
            

        }
        public void ChoiceI1()
        {
            Console.WriteLine(@"*Your attempt at convincing the repo team didn't convince them.*");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Bullshit! You guys have no right to just take my car.", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"What do you choose to do next:
----------------------------------------------------------------
1) Calm down the owner
2) Discuss with the repos guys about how they shouldn't take it
----------------------------------------------------------------");
        }
        public void ChoiceI2()
        {
            Console.WriteLine(@"Haven't you considered that maybe the dealership forgot to let you 
know about the payments that were made earlier today.");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Alright then let's go check in with the dealership about this.", ConsoleColor.Black, ConsoleColor.Yellow);
            Console.WriteLine(@"*The situation finally gets cleared up and the repo team go up to the owner and apologized 
before leaving the area.*");
            Console.ReadKey(true);
            Console.WriteLine(@"*The matter has finally been settled and you go back to standard patrol.*");
        }
        public void End()
        {
            Console.WriteLine("This was the end of Case# 13426.");
            Console.ReadKey(true);
        }
    }
}