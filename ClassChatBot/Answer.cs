using System;
using System.Collections.Generic;
using System.Text;

namespace ClassChatBot
{
    class Answer
    {
        public static List<Answer> answers = new List<Answer>();

        static Answer()
        {
            loadBase(answers);
        }

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


        static void loadBase(List<Answer> answers)
        {
            GetAnswersBase(answers);
            GetAphorismsBase(answers);
            GetInitialPhrasesBase(answers);
            GetJokesBase(answers);
        }

        void AddAnswer(List<Answer> answers, List<int> IdQuestions, string text, string type)
        {
            answers.Add(new Answer(IdQuestions, text, type));
        }

        void DelAnswer(List<Answer> answers, string text, string type)
        {
            foreach (Answer q in answers)
                if (text == q.Phrase)
                {
                    answers.Remove(q);
                }
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
            answers.Add(new Answer(new List<int> { 5, 6 }, "Добрый", type_ans));
            answers.Add(new Answer(new List<int> { 8 }, "Доброй", type_ans));
            //answers.Add(new Answer(new List<int> { 1, 2, 3 }, "...", type_ans));
            answers.Add(new Answer(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, "Аве!", type_ans));
        }

        private static void GetAphorismsBase(List<Answer> answers)
        {
            string type_ans = "aph";

            answers.Add(new Answer(new List<int> { }, "есть опыт учёбы, есть опыт работы, хочу ещё опыт зарплаты.", type_ans));
            answers.Add(new Answer(new List<int> { }, "самая неподкупная очередь — в туалет", type_ans));
            answers.Add(new Answer(new List<int> { }, "девушки как печеньки — ломаются, пока не намокнут", type_ans));
            answers.Add(new Answer(new List<int> { }, "улыбайтесь — это всех раздражает!", type_ans));
            answers.Add(new Answer(new List<int> { }, "не волнуйтесь, какое бы ни было у вас здоровье — его хватит до конца вашей жизни!", type_ans));
            answers.Add(new Answer(new List<int> { }, "если хочешь выглядеть молодой и стройной — держись поближе к старым и толстым", type_ans));
            answers.Add(new Answer(new List<int> { }, "три причины отсутствия студента на занятиях: забыл, запил, забил.", type_ans));
            answers.Add(new Answer(new List<int> { }, "девушка не воробей, залетит мало не покажется.", type_ans));
            answers.Add(new Answer(new List<int> { }, "труднее всего тянуть до зарплаты последние 3,5 недели.", type_ans));
            answers.Add(new Answer(new List<int> { }, "всё, что нас не убивает — впоследствии очень сильно об этом жалеет.", type_ans));
            answers.Add(new Answer(new List<int> { }, "русский язык без мата превращается в доклад.", type_ans));
            answers.Add(new Answer(new List<int> { }, "если Вас окружают одни дураки, значит Вы центральный.", type_ans));
            answers.Add(new Answer(new List<int> { }, "любовь — это когда ты не хочешь засыпать, потому что реальность лучше, чем сон.", type_ans));
            answers.Add(new Answer(new List<int> { }, "родился сам — помоги другому.", type_ans));
            answers.Add(new Answer(new List<int> { }, "если у тебя прекрасная жена, офигительная любовница, крутая тачка, нет проблем с властями и налоговыми службами, а когда ты выходишь на улицу всегда светит солнце и прохожие тебе улыбаются — скажи уже НЕТ наркотикам!", type_ans));
            answers.Add(new Answer(new List<int> { }, "подбитый глаз уменьшает обзор, но увеличивает опыт.", type_ans));
            answers.Add(new Answer(new List<int> { }, "детство заканчивается тогда, когда хочется, чтобы желания исполнял не Дед Мороз, а Снегурочка.", type_ans));
            answers.Add(new Answer(new List<int> { }, "каждый человек по-своему прав, а по-моему — нет.", type_ans));
            answers.Add(new Answer(new List<int> { }, "будет и на вашем кладбище праздник.", type_ans));
            answers.Add(new Answer(new List<int> { }, "люди, имеющие большие деньги, либо охраняются полицией, либо разыскиваются ею.", type_ans));
            answers.Add(new Answer(new List<int> { }, "сделать женщину счастливой не трудно, трудно самому при этом остаться счастливым.", type_ans));
            answers.Add(new Answer(new List<int> { }, "положительные эмоции — это эмоции, которые возникают, если на всё положить.", type_ans));
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
            answers.Add(new Answer(new List<int> { }, "Продавщица в хлебном отделе в моменты одиночества от нечего делать шевелит булками.", type_ans));
        }

        private static void GetInitialPhrasesBase(List<Answer> answers)
        {
            string type_ans = "ini";
            answers.Add(new Answer(new List<int> { }, "Я вас не понял, поэтому лучше пошучу  :", type_ans));
            answers.Add(new Answer(new List<int> { }, "Моя твоя не понимайт, держи шутку - ", type_ans));
            answers.Add(new Answer(new List<int> { }, "Я не достаточно умён для такого. Но мудр - ", type_ans));
            answers.Add(new Answer(new List<int> { }, "Эээ... ", type_ans));
            answers.Add(new Answer(new List<int> { }, "Эээ... ", type_ans));
        }


    }
}
