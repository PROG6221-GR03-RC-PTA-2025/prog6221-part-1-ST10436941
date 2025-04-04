using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Threading;

namespace PROG6221_POE_PART_1
{
    class Chatbot
    {
        static void Main()
        {
            Console.Title = "Starting Cybersecurity Awareness Bot..."; // Set window title
            Console.ForegroundColor = ConsoleColor.Cyan; // Set text color
            Console.Clear();

            // Play voice greeting
            PlayVoiceGreeting();

            // Display ASCII image
            DisplayAsciiImage();

            // Greet user and ask for their name
            TypeEffect("\nBot: Hello! What's your name? ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string userName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            TypeEffect($"\nBot: Nice to meet you, {userName}! How can I assist you today?\n");
            PrintDivider();

            // Basic chatbot loop for interaction
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You: ");
                string userInput = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Cyan;

                // Check user input and provide relevant responses
                if (userInput.Contains("how are you?"))
                {
                    TypeEffect("Bot: I'm just a program, but I'm here to help you stay safe online! (or type 'exit' to quit)");
                }
                else if (userInput.Contains("what's your purpose?") || userInput.Contains("what can i ask you about?"))
                {
                    TypeEffect("Bot: I provide cybersecurity awareness and help answer security-related questions.  (or type 'exit' to quit)");
                }
                else if (userInput.Contains("please tell me about password safety"))
                {
                    TypeEffect("Bot: Use a strong password with a mix of letters, numbers, and symbols.");
                    TypeEffect("Bot: Avoid using the same password for multiple accounts.  (or type 'exit' to quit)");
                }
                else if (userInput.Contains("how can i protect myself against phishing?"))
                {
                    TypeEffect("Bot: Be cautious of emails or messages asking for personal information.");
                    TypeEffect("Bot: Always verify the sender before clicking on links.  (or type 'exit' to quit)");
                }
                else if (userInput.Contains("please advise on safe browsing"))
                {

                    TypeEffect("Bot: Always check for \"https://\" in the URL (not just \"http://\"). The “S” means the site is encrypted.  (or type 'exit' to quit)");
                }
                else if (userInput.Contains("exit") || userInput.Contains("bye"))
                {
                    TypeEffect($"Bot: Goodbye, {userName}! Stay safe online!");
                    break;
                }
                else
                    TypeEffect("Bot: I didn't quite understand that. Could you rephrase?  (or type 'exit' to quit)");
            }
            PrintDivider();
        }

        static void PlayVoiceGreeting()
        {
            string filePath = "greeting.wav"; // Ensure the file is in the same directory as the executable

            try
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\RC_Student_lab\source\repos\PROG6221 POE PART 1\bin\Debug\voice.wav"))
                {
                    player.PlaySync(); // Play audio synchronously
                }
                Console.WriteLine("Voice greeting played successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing the voice greeting: " + ex.Message);
            }
        }
        static void DisplayAsciiImage()
        {
            string[] botArt = {
            "        [------]        ",
            "        | .  . |        ",
            "        |  --  |        ",
            "        [------]        ",
            "       /  ----  \\      ",
            "      | |      | |      ",
            "      | |      | |      ",
            "      []        []      ",
            "     /_\\        /_\\    "
        };

            foreach (string line in botArt)
            {
                Console.WriteLine(line);
            }
        }

        // Method to create a typing effect
        static void TypeEffect(string message, int delay = 30)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay); // Simulate typing effect
            }
            Console.WriteLine();
        }


        // Method to print a divider line
        static void PrintDivider()
        {
            Console.WriteLine("--------------------------------------------------");
        }
    }
}g