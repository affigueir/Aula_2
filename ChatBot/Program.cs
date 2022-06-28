using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string question, response;

            System.Console.WriteLine("Welcome to Chatbot. To exit type 'EXIT'\n");
            while(true)
            {

            System.Console.WriteLine("Ask me a question.\n");
            question = Console.ReadLine();

            switch (question)
            {
                case "What is your name?":
                    response = "I'm chatbot, nice to meet you.";
                    break;

                case "Where are you from?":
                    response = "From everywhere and nowhere.";
                    break;

                case "Are you real?":
                    response = "Reality is a construct created by humans to define what they see.";
                    break;

                default:
                    response = "I do not know.";
                    break;

            }
            if (question == "EXIT")
                break;

            else
                Console.WriteLine($"{response}\n");
            }
        }
    }
}
