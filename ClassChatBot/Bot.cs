using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ClassChatBot
{
    public class Bot
    {
        internal string botName = "Шарпик";
        internal string userName = new String("");
        public bool isFinal = false;
        Random randomizer = new Random();
        readonly List<string> ListOfAnswers = new List<string>();

        //StringBuilder answer = new StringBuilder();
        
        public string TakeAnswer(string asking)
        {
            asking = asking.ToLower();
            string answer_line = new string("");

            ListOfAnswers.Clear();
            foreach (var word in asking.Split(" "))
                switch (word)
                {
                    case "анекдот":
                        {
                            return TakeRandAnswer("jok");
                        }
                    case "зовут":
                        {
                                return "Меня зовут "+botName;
                        }
                    case "час":
                    case "времени":
                    case "время":
                        {
                            return DateTime.Now.ToString().Split(" ").ToArray()[1];
                        }
                    case "дата":
                    case "день":
                        {
                            return DateTime.Now.ToString().Split(" ").ToArray()[0];
                        }
                    case "кубик":
                        {
                            return randomizer.Next(0, 6).ToString();
                        }
                    case "монетку":
                        {
                            return (randomizer.Next(0, 6) == 1) ? "Орёл" : "Режка";
                        }
                    case "пока":
                    case "свидания":
                    case "бай":
                    case "bye":
                        {
                            isFinal = true;
                            return "до cвидания, " + userName;
                        }
                    default:
                        {
                           answer_line += "";
                           break;
                        }
                }



            foreach (Question oneQuestion in Question.questions)
            {
                if(oneQuestion.Phrase==asking)
                {
                    if(oneQuestion.type_of_question == "ask")
                    {
                        foreach (Answer an in Answer.answers)
                        {
                            foreach(int id in an.questionIds)
                            {
                                if(oneQuestion.Id==id)
                                {
                                    ListOfAnswers.Add(an.Phrase);
                                }
                            }
                        }

                        var va=TakeRandFromList(ListOfAnswers);
                        va ??= "NAN";
                        return va;
                    }
                }
            }
            answer_line = TakeRandAnswer("ini");
            string secondpart = TakeRandAnswer("aph");
            answer_line += " ";
            answer_line += secondpart;
            return answer_line;
        }

        string TakeRandFromList(List<string> answers)
        {
            int r = randomizer.Next(0, answers.Count());
            var an = answers.Skip(r).Take(1).ToArray();
            return an[0];
        }

        string TakeRandAnswer(string type_of_answer)
        {
            var an = Answer.answers.Where(i => i.type_of_answer == type_of_answer);
            int r = randomizer.Next(0, an.Count());
            var an1 = an.Skip(r).Take(2).ToArray();
            return an1[0].Phrase;
        }
    }
}
