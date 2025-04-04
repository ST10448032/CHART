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
    }

}

