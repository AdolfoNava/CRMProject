using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Creative_Media_Project.CaseSitutations
{
    class Case2
    {
        Random num = new Random();
        int value;
        public bool attitude;
        public Case2()
        {

            value = num.Next(1, 2);
            if(value == 1)
            {
                attitude = true;
                
            }
            else
            {
                attitude = false;
            }
        }
        public void Intro()
        {
            Console.WriteLine(@"There was an call in at S St Paulina and W 34th st for a noise complaint
from one of the neighbors living in the block. There seems to have been a party going on. You take charge
in the scene with your partner willingly follows your judgement tonight.");
            Console.ReadKey(true);
            Console.WriteLine(@"*You arrive on the scene of the noise complaint and make your way with your
partner to the front door and get the owner of the house.*");
            Console.ReadKey(true);
            Console.WriteLine("*You explain the situation about the call in for the noise complaint.*");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Oh sorry my bad officer we were just having a goood time drinking 
tonight my bad officers.", ConsoleColor.Black, ConsoleColor.Red);
            Console.ReadKey(true);
            Console.WriteLine(@"You look at the way he's been talking to you and been he has been struggling
to speak with you without slurring his words. The most likely guess is that there was a lot of alcohol served here.");
            Console.ReadKey(true);
            Console.WriteLine(@"*What do you say to the owner of the house:*
------------------------------------------------------------------------------
1) Ask if there are anyone here who is under the age of 21 here right now?
2) Immediately try to cancel the party
------------------------------------------------------------------------------");
        }
        public void ChoiceA1()//Left side
        {
            Console.WriteLine(@"Are there anyone who is under the age of 21 in here right now?");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"No officer. There is no one who came here to the party under the age of 21.",ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine(@"*What do you do here:*
---------------------------------
1) Give him the benefit of doubt
2) Disagree with what he said
---------------------------------");
        }
        public void ChoiceA2()
        {
            Console.WriteLine(@"Sorry but the party is cancelled everyone go home now.");
            Console.ReadKey(true);
            Console.WriteLine(@"*You hear everyone's collective disappointment over hearing the both you talk
about the party.*");
            if(attitude)
            {
                TextChange.ChangePrompt(@"Why do we have to cancel our party?", ConsoleColor.Black, ConsoleColor.Red);
                Console.WriteLine(@"What to you have to say about that:
----------------------------
1) Explain your reasoning
2) Act Aggressively
----------------------------");
            }
            else
            {
                TextChange.ChangePrompt(@"Oh alright fine have it your way.", ConsoleColor.Black, ConsoleColor.Red);
                Console.WriteLine(@"*The owner shuts down the party and you go back to the patrol car with your partner*");
                End();
            }
        }

        //Left side
        public void ChoiceB1_1()
        {
            Console.WriteLine(@"Well alright then just be sure to keep it down then or else it won't be
me who comes back have a good night");
            Console.ReadKey(true);
            Console.WriteLine(@"You and your partner walk back into your patrol vehicle after giving them
a warning about the noise and the party starts to die down soon after you went over there.");
        }
        public void ChoiceB1_2()
        {
            Console.WriteLine(@"I'm inclined to disagree.");
            Console.ReadKey(true);
            Console.WriteLine(@"What do you want to do about this situation:
------------------------------------------------------------------------------
1) Give them the benefit of the doubt
2) Make the judgement call to call in for backup to detain the people here
------------------------------------------------------------------------------");
        }

        public void ChoiceD1()
        {
            Console.WriteLine("I wanna give you guys the benefit of the doubt");
            Console.ReadKey(true);
            Console.WriteLine(@"What should you do?
------------------------------------------------------
1) Leave them be
2) Go check inside the house for anything suspicious
------------------------------------------------------
");
        }
        public void ChoiceD2()
        {
            Console.WriteLine(@"*You jump the gun and your deep hunch about something suspicious and call
in for police backup to make the arrests*");
            Console.ReadKey(true);
            Console.WriteLine(@"You and other officers that you called in detained around 18 people. As 
the arrests were being conducted the officers found used syringes in the bathroom
upstairs.");
            Console.ReadKey(true); 
            Console.WriteLine(@"Most of people detained were sent to the drunk tank to be picked up by 
someone who was willing to come in. whereas 4 including the owner of the house was charged
with drug procession.");
        }
        public void ChoiceE1()
        {
            Console.WriteLine(@"You know what I will let this slide just be courteous about the noise
for now on.");
            Console.ReadKey(true);
            Console.WriteLine(@"*You and your partner leave the premises and the party died down quickly
after you left and went on with the rest of your shift.*");
        }
        public void ChoiceE2()
        {
            Console.WriteLine(@"You go inside the building alone to do a quick check in to see if his
story checks out and but you saw how there were people quickly getting away from
the home.");
            Console.WriteLine(@"What would you do:
-----------------------------------------------------------------
1) Make the call that it's fine
2) You start calling for police backup to start detaining people
-----------------------------------------------------------------");
        }
        public void ChoiceC1()
        {
            Console.WriteLine(@"Alright everything seems fine here.");
            Console.ReadKey(true);
            Console.WriteLine(@"*You and your partner leave the premises and the party died down quickly
after you left and went on with the rest of your shift.*");
        }
        public void ChoiceC2()
        {
            Console.WriteLine(@"Your assess the situation and feel that you should start trying to detain
the people who are here in the party.");
            Console.ReadKey(true);
            Console.WriteLine(@"You and other officers that you called in detained around 11 people. As the
arrests were being conducted the officers found used syringes in the bathroom upstairs.");
            Console.ReadKey(true);
            Console.WriteLine(@"Most of people detained were sent to the drunk tank to be picked up by someone
who was willing to come in. whereas 4 including the owner of the house was charged
with drug procession.");
        }

        //Right side
        public void ChoiceB2_1()
        {
            Console.WriteLine(@"You guys over here have been too loud for the neighbors trying to sleep.");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Well what are you gonna do about it?", ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine(@"You call for backup for the people in the house to be detained.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine(@"You make the first arrest to the owner for your partner found used syringes.");
            Console.ReadKey(true);
            Console.WriteLine(@"You failed to arrest everyone who came to the party but you were able to 
detain around 15 people total. Most of them were sent to the drunk tank to be picked up
by someone who was willing to come in.");
            Console.ReadKey(true);
        }
        public void ChoiceB2_2()
        {
            Console.WriteLine(@"Because I said so.");
            Console.ReadKey(true);
            TextChange.ChangePrompt(@"Well what are you gonna do about it?", ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine(@"You make the first arrest to the owner for your partner found used syringes.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine(@"You make the first arrest to the owner for your partner found used syringes.");
            Console.ReadKey(true);
            Console.WriteLine(@"You failed to arrest everyone who came to the party but you were able to detain
around 15 people total. Most of them were sent to the drunk tank to be picked up by someone
who was willing to come in.");
            Console.ReadKey(true);
        }
        public void End()
        {
            Console.Clear();
            Console.WriteLine("This was the end of Case #21526");
            Console.ReadKey(true);
        }
    }
}