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
            // Play voice greeting
            PlayVoiceGreeting();
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
                Console.WriteLine("Voice greeting played suc" +
                    "}cessfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing the voice greeting: " + ex.Message);
            }
        }
    }
}