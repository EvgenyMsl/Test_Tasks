using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ClassChatBot
{
    public class Bot
    {
        internal string name = "Шарпик";

        List<Answer> answers = new List<Answer>();
        List<Question> questions = new List<Question>();
        Random randomizer = new Random();

        List<string> LAnswers = new List<string>();

        public Bot()
        {    
            loadBase(questions,answers);
        }

        //StringBuilder answer = new StringBuilder();
        
        public string TakeAnswer(string ask)
        {
            ask=ask.ToLower();
            foreach(Question q in questions)
            {
                if(q.Phrase==ask)
                {
                    switch(q.type_of_question)
                    {
                        case "ask":
                            {
                                foreach (Answer an in answers)
                                {
                                    foreach(int id in an.questionIds)
                                    {
                                        if(an.Id==id)
                                        {
                                            LAnswers.Add(an.Phrase);
                                        }
                                        var va = TakeRandFromList(LAnswers);
                                        LAnswers.Clear();
                                        return va;
                                    }
                                }
                                break;
                            }
                        case "com":
                            {
                                switch(ask)
                                {
                                    case "анекдот":
                                        {
                                            return TakeRandAnswer("jok");
                                        }
                                    case "как тебя зовут":
                                        {
                                            return name;
                                        }
                                    case "коротый час":
                                    case "сколько времени":
                                        {
                                            return gettime().ToString();
                                        }
                                    case "пока":
                                    case "до свидания":
                                        {
                                            return "до cвидания";////////////////////////END
                                        }
                                }
                                break;
                            }
                    }
                }
                break;
            }
            string ans = TakeRandAnswer("ini");
            string secondpart = TakeRandAnswer("aph");
            ans += " ";
            ans += secondpart;
            return ans;
        }

        bool correctingBase()
        {
            return true;
        }

        private static bool loadBase(List<Question> questions, List<Answer> answers)
        {
            GetQuestionsBase(questions);
            GetAnswersBase(answers);
            GetAphorismsBase(answers);
            GetInitialPhrasesBase(answers);
            GetJokesBase(answers);

            return true;
        }

        

        private System.DateTime gettime()//проверить так ли это
        {
            DateTime d = new DateTime();
            return d.Date;
        }

        void Get()
        {

        }

        string TakeRandFromList(List<string> answers)
        {
            int r = randomizer.Next(0, answers.Count());
            var an = answers.Skip(r).Take(1).ToArray();
            return an[0];
        }

        string TakeRandAnswer(string type_of_answer)
        {
            var an = answers.Where(i => i.type_of_answer == type_of_answer);
            int r = randomizer.Next(0, an.Count());
            var an1=an.Skip(r).Take(1).ToArray();
            return an1[0].Phrase;
        }

        void AddQuestion(List<Question> questions, string text, string type)
        {
            questions.Add(new Question(text, type));
        }

        void AddAnswer(List<Answer> answers, List<int> IdQuestions, string text, string type)
        {
            answers.Add(new Answer(IdQuestions, text, type));
        }

        void DelQuestion(List<Question> questions, string text, string type)
        {
            foreach(Question q in questions)
            if(text==q.Phrase)
                {
                    questions.Remove(q);
                }
        }
        void DelAnswer(List<Answer> answers, string text, string type)
        {
            foreach (Answer q in answers)
                if (text == q.Phrase)
                {
                    answers.Remove(q);
                }
        }

        private static void GetQuestionsBase(List<Question> questions)
        {
            string type_ask = "ask";
            string type_com = "com";

            questions.Add(new Question("хай",               type_ask));//0
            questions.Add(new Question("привет",            type_ask));//1
            questions.Add(new Question("приветствую",       type_ask));//2
            questions.Add(new Question("здравствуй",        type_ask));//3
            questions.Add(new Question("здравствуйте",      type_ask));//4
            questions.Add(new Question("добрый день",       type_ask));//5
            questions.Add(new Question("добрый вечер",      type_ask));//6
            questions.Add(new Question("доброе утро",       type_ask));//7
            questions.Add(new Question("доброй ночи",       type_ask));//8

            questions.Add(new Question("как тебя зовут",    type_com));//9
            questions.Add(new Question("анекдот",           type_com));//10
            questions.Add(new Question("который час",       type_com));//11
            questions.Add(new Question("сколько времени",   type_com));//12
            questions.Add(new Question("пока",              type_com));//13
            questions.Add(new Question("до свидания",       type_com));//14

            questions.Add(new Question("...",               type_ask));
        }

        private static void GetAnswersBase(List<Answer> answers)
        {
            string type_ans = "ans";
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Здравствуйте", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Хола", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Ни хао", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Халло", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Шалом", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Буенос диас", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Гутен таг", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Здраво", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Добры ден", type_ans));
            answers.Add(new Answer(new List<int> { 5, 6 }, "Добрый", type_ans));
            answers.Add(new Answer(new List<int> { 8 }, "Доброй", type_ans));
            answers.Add(new Answer(new List<int> { 5, 6 }, "Добрый-добрый", type_ans));
            answers.Add(new Answer(new List<int> { 1, 2, 3 }, "...", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Аве!", type_ans));
        }

        private static void GetAphorismsBase(List<Answer> answers)
        {
            string type_ans = "aph";
            answers.Add(new Answer(new List<int> { }, "Есть опыт учёбы, есть опыт работы, хочу ещё опыт зарплаты.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Самая неподкупная очередь — в туалет", type_ans));
            answers.Add(new Answer(new List<int> { }, "Девушки как печеньки — ломаются, пока не намокнут", type_ans));
            answers.Add(new Answer(new List<int> { }, "Улыбайтесь — это всех раздражает!", type_ans));
            answers.Add(new Answer(new List<int> { }, "Не волнуйтесь, какое бы ни было у вас здоровье — его хватит до конца вашей жизни!", type_ans));
            answers.Add(new Answer(new List<int> { }, "Если хочешь выглядеть молодой и стройной — держись поближе к старым и толстым", type_ans));
            answers.Add(new Answer(new List<int> { }, "Три причины отсутствия студента на занятиях: забыл, запил, забил.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Девушка не воробей, залетит мало не покажется.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Труднее всего тянуть до зарплаты последние 3,5 недели.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Всё, что нас не убивает — впоследствии очень сильно об этом жалеет.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Русский язык без мата превращается в доклад.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Если Вас окружают одни дураки, значит Вы центральный.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Любовь — это когда ты не хочешь засыпать, потому что реальность лучше, чем сон.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Родился сам — помоги другому.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Если у тебя прекрасная жена, офигительная любовница, крутая тачка, нет проблем с властями и налоговыми службами, а когда ты выходишь на улицу всегда светит солнце и прохожие тебе улыбаются — скажи уже НЕТ наркотикам!", type_ans));
            answers.Add(new Answer(new List<int> { }, "Подбитый глаз уменьшает обзор, но увеличивает опыт.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Детство заканчивается тогда, когда хочется, чтобы желания исполнял не Дед Мороз, а Снегурочка.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Каждый человек по-своему прав, а по-моему — нет.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Будет и на вашем кладбище праздник.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Люди, имеющие большие деньги, либо охраняются полицией, либо разыскиваются ею.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Сделать женщину счастливой не трудно, трудно самому при этом остаться счастливым.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Положительные эмоции — это эмоции, которые возникают, если на всё положить.", type_ans));
        }

        private static void GetJokesBase(List<Answer> answers)
        {
            string type_ans = "jok";
            answers.Add(new Answer(new List<int> { }, "Все у меня идет по плану. Осталось узнать - чей это план.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Наступило лето. Девушки достали из шкафов голые коленки...", type_ans));
            answers.Add(new Answer(new List<int> { }, "Выхожу сейчас из квартиры, а там двое прямо на лестничной площадке вакцинируются. Уважуха.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Финансовый совет: если вы не можете купить квартиру, просто унаследуйте ее.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Когда кот сидит у закрытой двери, это не просто кот. Это кот доступа!", type_ans));
            answers.Add(new Answer(new List<int> { }, "Гюльчатай, сними масочку.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Индийское кино без песен и танцев - документальное.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Рабочий лайфхак: чтобы кола не пенилась при наливании в стакан, пейте виски.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Зарплата назывется еще и жалованием, потому что на нее все жалуются.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Прошу осудить мою зарплату за то, что она ограничивает мою свободу передвижения и причиняет мне физическую боль.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Добро пожаловать в мастерскую по ремонту айфонов «Яблочный спас»!", type_ans));
            answers.Add(new Answer(new List<int> { }, "Koмпьютeрщик — этo eдинcтвeнный чeлoвeк, кoтoрый мoжeт пoпрocить у нaчaльникa двecти бaкcoв нa пaмять и иx пoлучить.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Когда захлопнулась ловушка. Я стал метаться и кричать. Но в паспорте уже стояла. Печать", type_ans));
            answers.Add(new Answer(new List<int> { }, "Маньяк-филолог убивает только людей в польтах.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Любая школа автоматически получает статус гимназии, если трудовик и физрук закодируются.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Ненавижу перепады настроения, это просто потрясающе!", type_ans));
            answers.Add(new Answer(new List<int> { }, "Пробка - это две русские беды в одном месте.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Heт, чтo зa люди, a? Зaшлa в гocти чaю пoпить — нa трeтий дeнь чувcтвую: кaк-тo нe oчeнь мнe тут и рaды…", type_ans));
            answers.Add(new Answer(new List<int> { }, "На Василия, который двадцать лет живет в однокомнатной квартире с женой и тещей, комары уже не садятся.", type_ans));
            answers.Add(new Answer(new List<int> { }, "Продавщица в хлебном отделе в моменты одиночества от нечего делать шевелит булками.", type_ans));

        }

        private static void GetInitialPhrasesBase(List<Answer> answers)
        {
            string type_ans = "ini";
            answers.Add(new Answer(new List<int> {}, "Я вас не понял, поэтому лучше пошучу ",type_ans));
            answers.Add(new Answer(new List<int> {}, "Моя твоя не понимайт, держи шутку - ", type_ans));
            answers.Add(new Answer(new List<int> {}, "Я не достаточно умён для такого. Но мудр - ", type_ans));
            answers.Add(new Answer(new List<int> {}, "Эээ... ", type_ans));
        }
    }
}
