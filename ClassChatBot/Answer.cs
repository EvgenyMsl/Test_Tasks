using System;
using System.Collections.Generic;
using System.Text;

namespace ClassChatBot
{
    class Answer
    {
        public Answer(List<int> questionIds, string Phrase, string type_of_answer)
        {
            newId++;
            Id = newId;
            this.type_of_answer = type_of_answer;
            this.questionIds=questionIds;
            this.Phrase = Phrase;
        }

        private static int newId = 0;
        public readonly int Id;
        public readonly List<int> questionIds;
        public readonly string type_of_answer;
        public string Phrase;

    }
}
