using System;
using System.Collections.Generic;
using System.Text;

namespace ClassChatBot
{
    class Question
    {
        public Question(string Phrase, string type_of_question)
        {
            newId++;
            this.type_of_question = type_of_question;
            Id = newId;
            this.Phrase = Phrase;
        }

        private static int newId = 0;
        public readonly int Id;
        public readonly string Phrase;
        public readonly string type_of_question;
    }
}
