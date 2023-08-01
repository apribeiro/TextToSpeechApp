namespace TextToSpeechApp
{
    using System;
    using System.Speech.Synthesis;

    /// <summary>
    /// A simple C# console application that converts user-input text to speech.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method of the program.
        /// </summary>
        public static void Main()
        {
            try
            {
                using var synthesizer = new SpeechSynthesizer();
                string welcome = "Welcome to the Text-to-Speech Application!\n";
                Console.WriteLine(welcome);
                synthesizer.Speak(welcome);

                while (true)
                {
                    Console.Write("Enter text to convert to speech (type 'q' to quit): ");
                    string? textToSpeak = Console.ReadLine();

                    if (string.IsNullOrEmpty(textToSpeak))
                    {
                        continue;
                    }

                    if (textToSpeak.ToLower() == "q")
                    {
                        string thankYou = "\nThank you for using the Text-to-Speech Application. Goodbye!";
                        Console.WriteLine(thankYou);
                        synthesizer.Speak(thankYou);
                        break; // Exit the while loop and end the program
                    }

                    synthesizer.Speak(textToSpeak);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}