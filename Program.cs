using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace CHART
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Play voice greeting
            Console.WriteLine("initiating chartbot....");
            PlayVoiceGreeting();

            // Display ASCII art
            DisplayAsciiArt();

            // Welcome user
            string userName = GetUserName();// Updated method call
            DisplayWelcomeMessage(userName);

            // Start interaction loop
            StartInteraction();

        }
        static void PlayVoiceGreeting()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer("Greeting.wav"))
                {
                    player.PlaySync(); // Play the greeting sound

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing greeting: " + ex.Message);
                Console.WriteLine("");
            }
        }
        static void DisplayAsciiArt()
        {
            string asciiArt = @"
   _____            _                _                _             
  / ____|          | |              | |              | |            
 | |     ___   ___| |__   ___  _ __| |_ ___  ___  __| | ___ _ __  
 | |    / _ \ / __| '_ \ / _ \| '__| __/ _ \/ _ \/ _` |/ _ \ '_ \ 
 | |___| (_) | (__| | | | (_) | |  | ||  __/  __/ (_| |  __/ | | |
  \_____\___/ \___|_| |_|\___/|_|   \__\___|\___|\__,_|\___|_| |_|
    ";
            Console.WriteLine(asciiArt);
        }
        
        static string GetUserName() // Updated method name
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty. Please enter your name: ");
                name = Console.ReadLine();
            }
            return name;
        }
        static void DisplayWelcomeMessage(string userName)
        {
            Console.WriteLine($"\nHello, {userName}! Welcome to the Cybersecurity Awareness Bot.");
            Console.WriteLine("I'm here to help you stay safe online.");
            Console.WriteLine("You can ask me about password safety, phishing, and safe browsing.");
        }
    
      static void StartInteraction()
        {
            while (true)
            {
                Console.Write("\nYou: ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                    continue;
                }

                string response = GetResponse(userInput);
                Console.WriteLine($"Bot: {response}");
            }
        }

        static string GetResponse(string input)
        {
            input = input.ToLower();
            if (input.Contains("how are you"))
            {
                return "I'm just a program, but I'm here to help you!";
            }
            else if (input.Contains("what's your purpose"))
            {
                return "My purpose is to help you understand cybersecurity better.";
            }
            else if (input.Contains("password safety"))
            {
                return "Always use strong passwords and change them regularly.";
            }
            else if (input.Contains("phishing"))
            {
                return "Be cautious of emails or messages asking for personal information.";
            }
            else if (input.Contains("safe browsing"))
            {
                return "Always check the URL and ensure it's secure (https://) before entering personal info.";
            }
            else
            {
                return "I didn't quite understand that. Could you rephrase?";
            }
        }
    }



}

      
    




