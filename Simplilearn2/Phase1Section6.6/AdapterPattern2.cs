using System;
using System.Collections.Generic;

namespace Phase1Section6._6
{
    public interface ITargetTranslate
    {
        string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
    }

    public class Pam : ITargetTranslate
    {
        static Dictionary<string, string> EnglishFrenchDictionary = new Dictionary<string, string>();
        static Dictionary<string, string> FrenchEnglishDictionary = new Dictionary<string, string>();
        David david = new David();
        John john = new John();

        static Pam()
        {
            EnglishFrenchDictionary.Add("how are you?", "comment allez-vous?");
            EnglishFrenchDictionary.Add("I am in USA", "Je suis aux Etats-Unis");
            FrenchEnglishDictionary.Add("Je vais très bien", "I am fine");
            FrenchEnglishDictionary.Add("où êtes-vous?", "where are you?");
        }
        public string TranslateAndTellToOtherPerson(string Words, string ConvertToWhichLanguage)
        {
            if (ConvertToWhichLanguage.Equals("English", StringComparison.InvariantCultureIgnoreCase))
            {
                string EnglishWords = ConvertToEnglish(Words);
                Console.WriteLine("\nPam Converted \"" + Words + " \" to \"" + EnglishWords + " and send the question to John");
                string EnglishWordsReply = john.AnswerFortheQuestion(EnglishWords);
                Console.WriteLine("Pam Got reply from John in English : " + "\"" + EnglishWordsReply + "\"");
                string FrenchConverted = ConvertToFrench(EnglishWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + EnglishWordsReply + "\"" + " to " + "\"" + FrenchConverted + "\"" + " and send back to David\n");
                return FrenchConverted;
            }
            else if (ConvertToWhichLanguage.Equals("French", StringComparison.InvariantCultureIgnoreCase))
            {
                string FrenchWords = ConvertToFrench(Words);
                Console.WriteLine("\nPam Converted \"" + Words + " \" to \"" + FrenchWords + " and send the question to David");
                string FrenchWordsReply = david.AnswerFortheQuestion(FrenchWords);
                Console.WriteLine("Pam Got reply from David in French : " + "\"" + FrenchWordsReply + "\"");
                string EnglishConverted = ConvertToEnglish(FrenchWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + FrenchWordsReply + "\"" + " to " + "\"" + EnglishConverted + "\"" + " and send back to John\n");
                return EnglishConverted;
            }
            else
            {
                return "Sorry Cannot Covert";
            }
        }
        public string ConvertToFrench(string Words)
        {
            return EnglishFrenchDictionary[Words];
        }
        public string ConvertToEnglish(string Words)
        {
            return FrenchEnglishDictionary[Words];
        }
    }

    public interface ISpeaker
    {
        string AskQuestion(string Words);
        string AnswerFortheQuestion(string Words);
    }

    public class John : ISpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by John [English Speaker and Can understand only English] : " + Words);
            ITargetTranslate target = new Pam();
            string replyFromDavid = target.TranslateAndTellToOtherPerson(Words, "French");
            return replyFromDavid;
        }

        public string AnswerFortheQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("where are you?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "I am in USA";
            }
            return reply;
        }
    }

    public class David : ISpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by David [French Speaker and Can understand only French] : " + Words);
            ITargetTranslate target = new Pam();
            string replyFromJohn = target.TranslateAndTellToOtherPerson(Words, "English");
            return replyFromJohn;
        }
        public string AnswerFortheQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("comment allez-vous?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "Je vais très bien";
            }
            return reply;
        }
    }
}
