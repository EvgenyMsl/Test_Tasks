using System;
using System.Collections.Generic;
using System.Text;

namespace ClassChatBot
{
    class Question
    {

        public static List<Question> questions = new List<Question>();

        static Question()
        {
            loadBase(questions);
        }

        public Question(string Phrase, string type_of_question)
        {
            newId++;
            this.type_of_question = type_of_question;
            Id = newId;
            this.Phrase = Phrase;
        }

        static void loadBase(List<Question> questions)
        {
            GetQuestionsBase(questions);
        }

        void AddQuestion(List<Question> questions, string text, string type)
        {
            questions.Add(new Question(text, type));
        }


        void DelQuestion(List<Question> questions, string text, string type)
        {
            foreach (Question q in questions)
                if (text == q.Phrase)
                {
                    questions.Remove(q);
                }
        }

        private static int newId = 0;
        public readonly int Id;
        public readonly string Phrase;
        public readonly string type_of_question;

        private static void GetQuestionsBase(List<Question> questions)
        {
            string type_ask = "ask";
            string type_com = "com";

            questions.Add(new Question("хай", type_ask));//0
            questions.Add(new Question("привет", type_ask));//1
            questions.Add(new Question("приветствую", type_ask));//2
            questions.Add(new Question("здравствуй", type_ask));//3
            questions.Add(new Question("здравствуйте", type_ask));//4
            questions.Add(new Question("добрый день", type_ask));//5
            questions.Add(new Question("добрый вечер", type_ask));//6
            questions.Add(new Question("доброе утро", type_ask));//7
            questions.Add(new Question("доброй ночи", type_ask));//8

            questions.Add(new Question("как тебя зовут", type_com));//9
            questions.Add(new Question("анекдот", type_com));//10
            questions.Add(new Question("который час", type_com));//11
            questions.Add(new Question("сколько времени", type_com));//12
            questions.Add(new Question("пока", type_com));//13
            questions.Add(new Question("до свидания", type_com));//14

            questions.Add(new Question("...", type_ask));
        }


       
    }
}
