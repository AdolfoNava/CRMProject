using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CRM_Creative_Media_Project
{
    class Game
    {
        User User1 = new User();
        ArrayList value;

        CaseSitutations.Case1 Scenario1;
        CaseSitutations.Case2 Scenario2;
        CaseSitutations.Case3 Scenario3; 
        CaseSitutations.Case4 Scenario4; 

        public Game()
        {


                value = RandomNumbers(4);

            GameIntro();
            GameOrder();
            
        }
        
        private int PickNum()
        {
            try
            {
               User1.Choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Please enter numbers only.\n Enter number again..\n");
                PickNum();
            }
            return User1.Choice;
        }
        private void GameOrder()
        {
            for (int count = 0; count <= 4; count++)
            {
                Console.Clear();
                switch (value[count])
                {
                    case 1:
                        Scenario1 = new CaseSitutations.Case1();
                        {
                            Scenario1.Intro();
                            PickNum();
                            while (User1.Choice < 1 || User1.Choice > 4)
                            {
                                Console.WriteLine("You have failed to input a value that was between 1-4 please try again:");
                                PickNum();
                            }
                                switch (User1.Choice)
                                {
                                    case 1:
                                    {
                                        Scenario1.ChoiceA1();
                                        Scenario1.Dicovery();
                                        PickNum();
                                        while (User1.Choice < 1 || User1.Choice > 2)
                                        {
                                            Console.WriteLine("You have failed to input a value that was 1 or 2 please try again:");
                                            PickNum();
                                        }
                                        switch (User1.Choice)
                                        {
                                            case 1:
                                                Scenario1.ChoiceB1();
                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                {
                                                    Console.WriteLine("You have failed to input a value that was 1 or 2 please try again:");
                                                    PickNum();
                                                }
                                                switch (User1.Choice)
                                                {
                                                    case 1:
                                                        Scenario1.ChoiceC1();
                                                        Scenario1.End();
                                                        break;
                                                    case 2:
                                                        Scenario1.ChoiceC2();
                                                        Scenario1.End();
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                break;
                                            case 2:
                                                Scenario1.ChoiceB2();
                                                Scenario1.End();
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                    case 2:
                                    {
                                        Scenario1.ChoiceA2();
                                        Scenario1.Dicovery();
                                        PickNum();
                                        while (User1.Choice < 1 || User1.Choice > 2)
                                        {
                                            Console.WriteLine("You have failed to input a value that was 1 or 2 please try again:");
                                            PickNum();
                                        }
                                        switch (User1.Choice)
                                        {
                                            case 1:
                                                Scenario1.ChoiceB1();
                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                {
                                                    Console.WriteLine("You have failed to input a value that was 1 or 2 please try again:");
                                                    PickNum();
                                                }
                                                switch (User1.Choice)
                                                {
                                                    case 1:
                                                        Scenario1.ChoiceC1();
                                                        Scenario1.End();
                                                        break;
                                                    case 2:
                                                        Scenario1.ChoiceC2();
                                                        Scenario1.End();
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                break;
                                            case 2:
                                                Scenario1.ChoiceB2();
                                                Scenario1.End();
                                                break;
                                            default:
                                                break;
                                        }
                                    
                            }
                                    break;
                                    case 3:
                                    { 
                                        Scenario1.ChoiceA3();
                                        Scenario1.Dicovery();
                                    PickNum();
                                    while (User1.Choice < 1 || User1.Choice > 2)
                                    {
                                        Console.WriteLine("You have failed to input a value that was 1 or 2 please try again:");
                                        PickNum();
                                    }
                                    switch (User1.Choice)
                                    {
                                        case 1:
                                            Scenario1.ChoiceB1();
                                            while (User1.Choice < 1 || User1.Choice > 2)
                                            {
                                                Console.WriteLine("You have failed to input a value that was 1 or 2 please try again:");
                                                PickNum();
                                            }
                                            switch (User1.Choice)
                                            {
                                                case 1:
                                                    Scenario1.ChoiceC1();
                                                    Scenario1.End();
                                                    break;
                                                case 2:
                                                    Scenario1.ChoiceC2();
                                                    Scenario1.End();
                                                    break;
                                                default:
                                                    break;
                                            }
                                            break;
                                        case 2:
                                            Scenario1.ChoiceB2();
                                            Scenario1.End();
                                            break;
                                        default:
                                            break;
                                    }
                            }
                                    break;
                                    case 4:
                                    { 
                                        Scenario1.ChoiceA4();
                                        Scenario1.Dicovery();
                                    PickNum();
                                    while (User1.Choice < 1 || User1.Choice > 2)
                                    {
                                        Console.WriteLine("You have failed to input a value that was 1 or 2 please try again:");
                                        PickNum();
                                    }
                                        switch (User1.Choice)
                                        {
                                            case 1:
                                                Scenario1.ChoiceB1();
                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                {
                                                    Console.WriteLine("You have failed to input a value that was 1 or 2 please try again:");
                                                    PickNum();
                                                }
                                                switch (User1.Choice)
                                                {
                                                    case 1:
                                                        Scenario1.ChoiceC1();
                                                        Scenario1.End();
                                                        break;
                                                    case 2:
                                                        Scenario1.ChoiceC2();
                                                        Scenario1.End();
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                break;
                                            case 2:
                                                Scenario1.ChoiceB2();
                                                Scenario1.End();
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                    default:
                                        break;
                                }
                            
                        }   
                        break;
                    case 2:                            
                        Scenario2 = new CaseSitutations.Case2();
                        {

                            Scenario2.Intro();
                            PickNum();
                            while (User1.Choice < 1 || User1.Choice > 2)
                            {
                                Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                PickNum();
                            }
                            switch (User1.Choice)
                            {
                                case 1:
                                    Scenario2.ChoiceA1();
                                    PickNum();
                                    while (User1.Choice < 1 || User1.Choice > 2)
                                    {
                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                        PickNum();
                                    }
                                    Console.Clear();
                                    switch (User1.Choice)
                                    {
                                        case 1:
                                            Scenario2.ChoiceB1_1();
                                            Console.Clear();
                                            Scenario2.End();
                                            break;
                                        case 2:
                                            Scenario2.ChoiceB1_2();
                                            PickNum();
                                            while (User1.Choice < 1 || User1.Choice > 2)
                                            {
                                                Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                PickNum();
                                            }
                                            Console.Clear();
                                            switch (User1.Choice)
                                            {
                                                case 1:
                                                    Scenario2.ChoiceD1();
                                                    {
                                                        PickNum();
                                                        while (User1.Choice < 1 || User1.Choice > 2)
                                                        {
                                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                            PickNum();
                                                        }
                                                        Console.Clear();
                                                        switch (User1.Choice)
                                                        {
                                                            case 1:
                                                                Scenario2.ChoiceE1();
                                                                Console.Clear();
                                                                Scenario2.End();
                                                                break;
                                                            case 2:
                                                                Scenario2.ChoiceE2();
                                                                {
                                                                    PickNum();
                                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                                    {
                                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                        PickNum();
                                                                    }
                                                                    Console.Clear();
                                                                    switch (User1.Choice)
                                                                    {
                                                                        case 1:
                                                                            Scenario2.ChoiceC1();
                                                                            Console.Clear();
                                                                            Scenario2.End();
                                                                            break;
                                                                        case 2:
                                                                            Scenario2.ChoiceC2();
                                                                            Console.Clear();
                                                                            Scenario2.End();
                                                                            break;
                                                                        default:
                                                                            break;
                                                                    }
                                                                }
                                                                break;
                                                            default:
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    Scenario2.ChoiceD2();
                                                    Console.Clear();
                                                    Scenario2.End();
                                                    break;
                                                default:
                                                    break;
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    Scenario2.ChoiceA2();
                                    {
                                        if (!Scenario2.attitude)
                                        { break; }
                                        else
                                            PickNum();
                                        while (User1.Choice < 1 || User1.Choice > 2)
                                        {
                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                            PickNum();
                                        }
                                        Console.Clear();
                                        switch (User1.Choice)
                                        {
                                            case 1:
                                                Scenario2.ChoiceB2_1();
                                                Console.Clear();
                                                Scenario2.End();
                                                break;
                                            case 2:
                                                Scenario2.ChoiceB2_2();
                                                Console.Clear();
                                                Scenario2.End();
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Scenario3 = new CaseSitutations.Case3();
                        Scenario3.Intro();
                        {
                            PickNum();
                            while (User1.Choice < 1 || User1.Choice > 2)
                            {
                                Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                PickNum();
                            }
                            Console.Clear();
                            switch (User1.Choice)
                            {
                                case 1:
                                    Scenario3.ChoiceA1();
                                    {
                                        PickNum();
                                        while (User1.Choice < 1 || User1.Choice > 2)
                                        {
                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                            PickNum();
                                        }
                                        Console.Clear();
                                        switch (User1.Choice)
                                        {
                                            case 1:
                                                Scenario3.ChoiceB1();
                                                {
                                                    PickNum();
                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                    {
                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                        PickNum();
                                                    }
                                                    Console.Clear();
                                                    switch (User1.Choice)
                                                    {
                                                        case 1:
                                                            Scenario3.ChoiceF();//Remember this
                                                            {
                                                                PickNum();
                                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                                {
                                                                    Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                    PickNum();
                                                                }
                                                                Console.Clear();
                                                                switch (User1.Choice)
                                                                {
                                                                    case 1:
                                                                        Scenario3.ChoiceG1();
                                                                        break;
                                                                    case 2:
                                                                        Scenario3.ChoiceG2();
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        case 2:
                                                            Scenario3.FirearmPull();//REMINDER TO USE THIS
                                                            {
                                                                PickNum();
                                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                                {
                                                                    Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                    PickNum();
                                                                }
                                                                Console.Clear();
                                                                switch (User1.Choice)
                                                                {
                                                                    case 1:
                                                                        Scenario3.ChoiceH1();
                                                                        Console.Clear();
                                                                        Scenario3.End();
                                                                        break;
                                                                    case 2:
                                                                        Scenario3.ChoiceH2();
                                                                        Console.Clear();
                                                                        Scenario3.End();
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                }
                                                break;
                                            case 2:
                                                Scenario3.ChoiceB2();
                                                {
                                                    PickNum();
                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                    {
                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                        PickNum();
                                                    }
                                                    Console.Clear();
                                                    switch (User1.Choice)
                                                    {
                                                        case 1:
                                                            Scenario3.ChoiceF();//Remember this
                                                            {
                                                                PickNum();
                                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                                {
                                                                    Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                    PickNum();
                                                                }
                                                                Console.Clear();
                                                                switch (User1.Choice)
                                                                {
                                                                    case 1:
                                                                        Scenario3.ChoiceG1();
                                                                        break;
                                                                    case 2:
                                                                        Scenario3.ChoiceG2();
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        case 2:
                                                            Scenario3.FirearmPull();//REMINDER TO USE THIS
                                                            {
                                                                PickNum();
                                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                                {
                                                                    Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                    PickNum();
                                                                }
                                                                Console.Clear();
                                                                switch (User1.Choice)
                                                                {
                                                                    case 1:
                                                                        Scenario3.ChoiceH1();
                                                                        Console.Clear();
                                                                        Scenario3.End();
                                                                        break;
                                                                    case 2:
                                                                        Scenario3.ChoiceH2();
                                                                        Console.Clear();
                                                                        Scenario3.End();
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                case 2:
                                    Scenario3.ChoiceA2();
                                    {
                                        PickNum();
                                        while (User1.Choice < 1 || User1.Choice > 2)
                                        {
                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                            PickNum();
                                        }
                                        Console.Clear();
                                        switch (User1.Choice)
                                        {
                                            case 1:
                                                Scenario3.ChoiceC1();
                                                Console.Clear();
                                                Scenario3.End();
                                                break;
                                            case 2:
                                                Scenario3.ChoiceC2();
                                                {
                                                    PickNum();
                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                    {
                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                        PickNum();
                                                    }
                                                    Console.Clear();
                                                    switch (User1.Choice)
                                                    {
                                                        case 1:
                                                            Scenario3.ChoiceD1();
                                                            PickNum();
                                                            while (User1.Choice < 1 || User1.Choice > 2)
                                                            {
                                                                Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                PickNum();
                                                            }
                                                            Console.Clear();
                                                            switch (User1.Choice)
                                                            {
                                                                case 1:
                                                                    Scenario3.ChoiceF();//Remember this
                                                                    {
                                                                        PickNum();
                                                                        while (User1.Choice < 1 || User1.Choice > 2)
                                                                        {
                                                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                            PickNum();
                                                                        }
                                                                        Console.Clear();
                                                                        switch (User1.Choice)
                                                                        {
                                                                            case 1:
                                                                                Scenario3.ChoiceG1();
                                                                                break;
                                                                            case 2:
                                                                                Scenario3.ChoiceG2();
                                                                                break;
                                                                            default:
                                                                                break;
                                                                        }
                                                                    }
                                                                    break;
                                                                case 2:
                                                                    Scenario3.FirearmPull();//REMINDER TO USE THIS
                                                                    {
                                                                        PickNum();
                                                                        while (User1.Choice < 1 || User1.Choice > 2)
                                                                        {
                                                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                            PickNum();
                                                                        }
                                                                        Console.Clear();
                                                                        switch (User1.Choice)
                                                                        {
                                                                            case 1:
                                                                                Scenario3.ChoiceH1();
                                                                                Console.Clear();
                                                                                Scenario3.End();
                                                                                break;
                                                                            case 2:
                                                                                Scenario3.ChoiceH2();
                                                                                Console.Clear();
                                                                                Scenario3.End();
                                                                                break;
                                                                            default:
                                                                                break;
                                                                        }
                                                                    }
                                                                    break;
                                                                default:
                                                                    break;
                                                            }
                                                            break;
                                                        case 2:
                                                            Scenario3.ChoiceD2();
                                                            {
                                                                PickNum();
                                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                                {
                                                                    Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                    PickNum();
                                                                }
                                                                Console.Clear();
                                                                switch (User1.Choice)
                                                                {
                                                                    case 1:
                                                                        Scenario3.ChoiceE1();
                                                                        PickNum();
                                                                        while (User1.Choice < 1 || User1.Choice > 2)
                                                                        {
                                                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                            PickNum();
                                                                        }
                                                                        Console.Clear();
                                                                        switch (User1.Choice)
                                                                        {
                                                                            case 1:
                                                                                Scenario3.ChoiceF();//Remember this
                                                                                {
                                                                                    PickNum();
                                                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                                                    {
                                                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                        PickNum();
                                                                                    }
                                                                                    Console.Clear();
                                                                                    switch (User1.Choice)
                                                                                    {
                                                                                        case 1:
                                                                                            Scenario3.ChoiceG1();
                                                                                            break;
                                                                                        case 2:
                                                                                            Scenario3.ChoiceG2();
                                                                                            break;
                                                                                        default:
                                                                                            break;
                                                                                    }
                                                                                }
                                                                                break;
                                                                            case 2:
                                                                                Scenario3.FirearmPull();//REMINDER TO USE THIS
                                                                                {
                                                                                    PickNum();
                                                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                                                    {
                                                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                        PickNum();
                                                                                    }
                                                                                    Console.Clear();
                                                                                    switch (User1.Choice)
                                                                                    {
                                                                                        case 1:
                                                                                            Scenario3.ChoiceH1();
                                                                                            Console.Clear();
                                                                                            Scenario3.End();
                                                                                            break;
                                                                                        case 2:
                                                                                            Scenario3.ChoiceH2();
                                                                                            Console.Clear();
                                                                                            Scenario3.End();
                                                                                            break;
                                                                                        default:
                                                                                            break;
                                                                                    }
                                                                                }
                                                                                break;
                                                                            default:
                                                                                break;
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        Scenario3.ChoiceE2();
                                                                        PickNum();
                                                                        while (User1.Choice < 1 || User1.Choice > 2)
                                                                        {
                                                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                            PickNum();
                                                                        }
                                                                        Console.Clear();
                                                                        switch (User1.Choice)
                                                                        {
                                                                            case 1:
                                                                                Scenario3.ChoiceF();//Remember this
                                                                                {
                                                                                    PickNum();
                                                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                                                    {
                                                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                        PickNum();
                                                                                    }
                                                                                    Console.Clear();
                                                                                    switch (User1.Choice)
                                                                                    {
                                                                                        case 1:
                                                                                            Scenario3.ChoiceG1();
                                                                                            break;
                                                                                        case 2:
                                                                                            Scenario3.ChoiceG2();
                                                                                            break;
                                                                                        default:
                                                                                            break;
                                                                                    }
                                                                                }
                                                                                break;
                                                                            case 2:
                                                                                Scenario3.FirearmPull();//REMINDER TO USE THIS
                                                                                {
                                                                                    PickNum();
                                                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                                                    {
                                                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                        PickNum();
                                                                                    }
                                                                                    Console.Clear();
                                                                                    switch (User1.Choice)
                                                                                    {
                                                                                        case 1:
                                                                                            Scenario3.ChoiceH1();
                                                                                            Console.Clear();
                                                                                            Scenario3.End();
                                                                                            break;
                                                                                        case 2:
                                                                                            Scenario3.ChoiceH2();
                                                                                            Console.Clear();
                                                                                            Scenario3.End();
                                                                                            break;
                                                                                        default:
                                                                                            break;
                                                                                    }
                                                                                }
                                                                                break;
                                                                            default:
                                                                                break;
                                                                        }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Scenario4 = new CaseSitutations.Case4();
                        Scenario4.Intro();
                        {//Choice A
                            PickNum();
                            while (User1.Choice < 1 || User1.Choice > 2)
                            {
                                Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                PickNum();
                            }
                            Console.Clear();
                            switch (User1.Choice)
                            {
                                case 1:
                                    Scenario4.ChoiceA1();//leads to b
                                    {
                                        PickNum();
                                        while (User1.Choice < 1 || User1.Choice > 2)
                                        {
                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                            PickNum();
                                        }
                                        Console.Clear();
                                        switch (User1.Choice)
                                        {
                                            case 1:
                                                Scenario4.ChoiceB1();//Goes to D
                                                {
                                                    PickNum();
                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                    {
                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                        PickNum();
                                                    }
                                                    Console.Clear();
                                                    switch (User1.Choice)
                                                    {
                                                        case 1:
                                                            Scenario4.ChoiceD1();//Ends here
                                                            Console.Clear();
                                                            Scenario4.End();
                                                            break;
                                                        case 2:
                                                            Scenario4.ChoiceD2();//Goes to E
                                                            {
                                                                PickNum();
                                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                                {
                                                                    Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                    PickNum();
                                                                }
                                                                Console.Clear();
                                                                switch (User1.Choice)
                                                                {
                                                                    case 1:
                                                                        Scenario4.ChoiceE1();
                                                                        switch (User1.Choice)
                                                                        {
                                                                            case 1:
                                                                                Scenario4.ChoiceF1();
                                                                                Console.Clear();
                                                                                Scenario4.End();
                                                                                break;
                                                                            case 2:
                                                                                Scenario4.ChoiceF2();
                                                                                {
                                                                                    PickNum();
                                                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                                                    {
                                                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                        PickNum();
                                                                                    }
                                                                                    Console.Clear();
                                                                                    switch (User1.Choice)
                                                                                    {
                                                                                        case 1:
                                                                                            Scenario4.ChoiceG1();
                                                                                            Console.Clear();
                                                                                            Scenario4.End();
                                                                                            break;
                                                                                        case 2:
                                                                                            Scenario4.ChoiceG2();
                                                                                            Console.Clear();
                                                                                            Scenario4.End();
                                                                                            break;
                                                                                        default:
                                                                                            break;
                                                                                    }
                                                                                }
                                                                                break;
                                                                            default:
                                                                                break;
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        Scenario4.ChoiceE2();
                                                                        {//Copy e1 path
                                                                            PickNum();
                                                                            while (User1.Choice < 1 || User1.Choice > 2)
                                                                            {
                                                                                Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                PickNum();
                                                                            }
                                                                            Console.Clear();
                                                                            switch (User1.Choice)
                                                                            {
                                                                                case 1:
                                                                                    Scenario4.ChoiceF1();
                                                                                    Console.Clear();
                                                                                    Scenario4.End();
                                                                                    break;
                                                                                case 2:
                                                                                    Scenario4.ChoiceF2();
                                                                                    {
                                                                                        PickNum();
                                                                                        while (User1.Choice < 1 || User1.Choice > 2)
                                                                                        {
                                                                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                            PickNum();
                                                                                        }
                                                                                        Console.Clear();
                                                                                        switch (User1.Choice)
                                                                                        {
                                                                                            case 1:
                                                                                                Scenario4.ChoiceG1();
                                                                                                Console.Clear();
                                                                                                Scenario4.End();
                                                                                                break;
                                                                                            case 2:
                                                                                                Scenario4.ChoiceG2();
                                                                                                Console.Clear();
                                                                                                Scenario4.End();
                                                                                                break;
                                                                                            default:
                                                                                                break;
                                                                                        }
                                                                                    }
                                                                                    break;
                                                                                default:
                                                                                    break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                }
                                                break;
                                            case 2:
                                                Scenario4.ChoiceB2();
                                                Console.Clear();
                                                Scenario4.End();
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                case 2:
                                    Scenario4.ChoiceA2();//jumps to h1 just like c2
                                    {
                                        PickNum();
                                        while (User1.Choice < 1 || User1.Choice > 2)
                                        {
                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                            PickNum();
                                        }
                                        Console.Clear();
                                        switch (User1.Choice)
                                        {
                                            case 1:
                                                Scenario4.ChoiceH1();//lead into e1
                                                {
                                                    PickNum();
                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                    {
                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                        PickNum();
                                                    }
                                                    Console.Clear();
                                                    switch (User1.Choice)
                                                    {
                                                        case 1:
                                                            Scenario4.ChoiceE1();
                                                            switch (User1.Choice)
                                                            {
                                                                case 1:
                                                                    Scenario4.ChoiceF1();
                                                                    Console.Clear();
                                                                    Scenario4.End();
                                                                    break;
                                                                case 2:
                                                                    Scenario4.ChoiceF2();
                                                                    {
                                                                        PickNum();
                                                                        while (User1.Choice < 1 || User1.Choice > 2)
                                                                        {
                                                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                            PickNum();
                                                                        }
                                                                        Console.Clear();
                                                                        switch (User1.Choice)
                                                                        {
                                                                            case 1:
                                                                                Scenario4.ChoiceG1();
                                                                                Console.Clear();
                                                                                Scenario4.End();
                                                                                break;
                                                                            case 2:
                                                                                Scenario4.ChoiceG2();
                                                                                Console.Clear();
                                                                                Scenario4.End();
                                                                                break;
                                                                            default:
                                                                                break;
                                                                        }
                                                                    }
                                                                    break;
                                                                default:
                                                                    break;
                                                            }
                                                            break;
                                                        case 2:
                                                            Scenario4.ChoiceE2();
                                                            {//Copy e1 path
                                                                PickNum();
                                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                                {
                                                                    Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                    PickNum();
                                                                }
                                                                Console.Clear();
                                                                switch (User1.Choice)
                                                                {
                                                                    case 1:
                                                                        Scenario4.ChoiceF1();
                                                                        Console.Clear();
                                                                        Scenario4.End();
                                                                        break;
                                                                    case 2:
                                                                        Scenario4.ChoiceF2();
                                                                        {
                                                                            PickNum();
                                                                            while (User1.Choice < 1 || User1.Choice > 2)
                                                                            {
                                                                                Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                PickNum();
                                                                            }
                                                                            Console.Clear();
                                                                            switch (User1.Choice)
                                                                            {
                                                                                case 1:
                                                                                    Scenario4.ChoiceG1();
                                                                                    Console.Clear();
                                                                                    Scenario4.End();
                                                                                    break;
                                                                                case 2:
                                                                                    Scenario4.ChoiceG2();
                                                                                    Console.Clear();
                                                                                    Scenario4.End();
                                                                                    break;
                                                                                default:
                                                                                    break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                }
                                                break;
                                            case 2:
                                                Scenario4.ChoiceH2();
                                                {
                                                    PickNum();
                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                    {
                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                        PickNum();
                                                    }
                                                    Console.Clear();
                                                    switch (User1.Choice)
                                                    {//Goes into the E portion
                                                        case 1:
                                                            Scenario4.ChoiceI1();
                                                            {
                                                                PickNum();
                                                                while (User1.Choice < 1 || User1.Choice > 2)
                                                                {
                                                                    Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                    PickNum();
                                                                }
                                                                Console.Clear();
                                                                switch (User1.Choice)
                                                                {
                                                                    case 1:
                                                                        Scenario4.ChoiceE1();
                                                                        switch (User1.Choice)
                                                                        {
                                                                            case 1:
                                                                                Scenario4.ChoiceF1();
                                                                                Console.Clear();
                                                                                Scenario4.End();
                                                                                break;
                                                                            case 2:
                                                                                Scenario4.ChoiceF2();
                                                                                {
                                                                                    PickNum();
                                                                                    while (User1.Choice < 1 || User1.Choice > 2)
                                                                                    {
                                                                                        Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                        PickNum();
                                                                                    }
                                                                                    Console.Clear();
                                                                                    switch (User1.Choice)
                                                                                    {
                                                                                        case 1:
                                                                                            Scenario4.ChoiceG1();
                                                                                            Console.Clear();
                                                                                            Scenario4.End();
                                                                                            break;
                                                                                        case 2:
                                                                                            Scenario4.ChoiceG2();
                                                                                            Console.Clear();
                                                                                            Scenario4.End();
                                                                                            break;
                                                                                        default:
                                                                                            break;
                                                                                    }
                                                                                }
                                                                                break;
                                                                            default:
                                                                                break;
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        Scenario4.ChoiceE2();
                                                                        {//Copy e1 path
                                                                            PickNum();
                                                                            while (User1.Choice < 1 || User1.Choice > 2)
                                                                            {
                                                                                Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                PickNum();
                                                                            }
                                                                            Console.Clear();
                                                                            switch (User1.Choice)
                                                                            {
                                                                                case 1:
                                                                                    Scenario4.ChoiceF1();
                                                                                    Console.Clear();
                                                                                    Scenario4.End();
                                                                                    break;
                                                                                case 2:
                                                                                    Scenario4.ChoiceF2();
                                                                                    {
                                                                                        PickNum();
                                                                                        while (User1.Choice < 1 || User1.Choice > 2)
                                                                                        {
                                                                                            Console.WriteLine("You have failed to input a value that was between 1 or 2 please try again:");
                                                                                            PickNum();
                                                                                        }
                                                                                        Console.Clear();
                                                                                        switch (User1.Choice)
                                                                                        {
                                                                                            case 1:
                                                                                                Scenario4.ChoiceG1();
                                                                                                Console.Clear();
                                                                                                Scenario4.End();
                                                                                                break;
                                                                                            case 2:
                                                                                                Scenario4.ChoiceG2();
                                                                                                Console.Clear();
                                                                                                Scenario4.End();
                                                                                                break;
                                                                                            default:
                                                                                                break;
                                                                                        }
                                                                                    }
                                                                                    break;
                                                                                default:
                                                                                    break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        case 2:
                                                            Scenario4.ChoiceI2();
                                                            Console.Clear();
                                                            Scenario4.End();
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
                
            }
            End();
        }
        public ArrayList RandomNumbers(int max)
        {
            // Create an ArrayList object that will hold the numbers
            ArrayList lstNumbers = new ArrayList();
            // The Random class will be used to generate numbers
            Random rndNumber = new Random();

            // Generate a random number between 1 and the Max
            int number = rndNumber.Next(1, max + 1);
            // Add this first random number to the list
            lstNumbers.Add(number);
            // Set a count of numbers to 0 to start
            int count = 0;

            do // Repeatedly...
            {
                // ... generate a random number between 1 and the Max
                number = rndNumber.Next(1, max + 1);

                // If the newly generated number in not yet in the list...
                if (!lstNumbers.Contains(number))
                {
                    // ... add it
                    lstNumbers.Add(number);
                }

                // Increase the count
                count++;
            } while (count <= 10 * max); // Do that again

            // Once the list is built, return it
            return lstNumbers;
        }

        public void GameIntro()
        {
            Console.WriteLine(@"Hello and welcome to my completely text based police scenario simulation. I implore you to put yourself
into these situations as an officer making choices based on your own judgement. The path that you 
decide to choose will not be recorded, nor the time of it took to make your decision. All the 
situations that will be presented to you will be purely fictional. Any reference to names, streets, 
and time of occurance are intended to paint a visualization in your head. Now with all that stated 
anytime that you want to continue with the next section of text tap any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine(@"You fill be presented with 5 different situations back to back order so go through the simulation at 
your lesiure. Throughout the simulation all you have to do is input a value that corresponds to the
number ->'*)' found on the left side of the screen and hit enter to confirm your choice.");
        }

        private void End()
        {
            Console.Clear();
            Console.WriteLine(@"Thank you for partaking in this experience. If you want to indulge yourself in this experience again 
then simply close this window and start the build again. The order of the cases you dealt with
will not in fact appear in the same order each time.");
            Console.ReadKey(true);
        }
    }
}
