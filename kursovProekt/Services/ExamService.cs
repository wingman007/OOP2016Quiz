using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using kursovProekt.Models;

namespace kursovProekt.Services
{
    public class ExamService
    {
        public Exam GetExam()
        {
            var exam = new Exam() { ID = 100, Name = "Матура по география" };
            exam.AddQuestion(GetQuestions());

            return exam;
        }
        private IList<Question> GetQuestions()
        {
            var questions = new List<Question>()
            {
                new Question() { Text = "Коя е вярната последователност на изброените геоложки ери от най-старата към най-младата? ", Point = 2, ID = 1, OrderNumber = 0 },
                new Question() { Text = "Кой климатичен пояс се характеризира с целогодишно силно слънчево греене, голямо изпарение и ежедневни валежи? ", Point = 2, ID = 2, OrderNumber = 1 },
                new Question() { Text = "Върху коя от посочените групи континенти се простира тундрата? ", Point = 2, ID = 3, OrderNumber = 2 },
                new Question() { Text = "Рязкото увеличаване на броя на населението в света се определя като: ", Point = 2, ID = 4, OrderNumber = 3 },
                new Question() { Text = "С най-ниска средна гъстота на населението се характеризира:", Point = 2, ID = 5, OrderNumber = 4 },
                new Question() { Text = "Коя от посочените страни НЕ е член на Европейския съюз? ", Point = 2, ID = 6, OrderNumber = 5 },
                new Question() { Text = "В коя група изброените държави са монархии? ", Point = 2, ID = 7, OrderNumber = 6 },
                new Question() { Text = "Най-големите производители на пшеница в света са: ", Point = 2, ID = 8, OrderNumber = 7 },
                new Question() { Text = "Кое твърдение, характеризиращо стопанството на Африка, НЕ е вярно? ", Point = 2, ID = 9, OrderNumber = 8 },
                new Question()
                {
                    Text = "Стопанството на коя от изброените азиатски страни се характеризира със следните особености:"
                        + "Преимуществено развитие на високотехнологичните отрасли; икономиката е ориентирана към външните пазари; инвестира огромни капиталовложения в образованието и науката; заема водещо място в световната икономика.",
                    Point = 2,
                    ID = 10,
                    OrderNumber = 9
                },
                new Question() { Text = "С коя съседна държава България има граница с дължина 165 км. и три ГКПП, но няма железопътна връзка? ", Point = 2, ID = 11, OrderNumber = 10 },
                new Question() { Text = "Коя от морфографските единици е със западно-източна посока на простиране и се характеризира с увеличаване на надморската височина на изток? ", Point = 2, ID = 12, OrderNumber = 11 },
                new Question() { Text = "В Медет, Асарел и Росен има находища на: ", Point = 2, ID = 13, OrderNumber = 12 },
                new Question() { Text = "В коя климатична област е измерена абсолютната минимална температура за България (-38,30С)? ", Point = 2, ID = 14, OrderNumber = 13 },
                new Question() { Text = "Коя от изброените реки се влива в Черноморския отточен басейн? ", Point = 2, ID = 15, OrderNumber = 14 },
                new Question() { Text = "Кой от посочените почвени типове е азонален? ", Point = 2, ID = 16, OrderNumber = 15 },
                new Question() { Text = "Коя от посочените Задбалкански котловини има най-източно географско разположение? ", Point = 2, ID = 17, OrderNumber = 16 },
                new Question() { Text = "Коя от посочените планини НЕ е в обхвата на природногеографската подобласт Краище? ", Point = 2, ID = 18, OrderNumber = 17 },
                new Question() { Text = "При коя от двойките географски обект – местоположение има несъответствие? ", Point = 2, ID = 19, OrderNumber = 18 },
                new Question() { Text = "С най-влошени демографски показатели се характеризира населението в: ", Point = 2, ID = 20, OrderNumber = 19 }
            };

            questions[0].AddChoices(new Choice() { IsAnswer = false, Text = "докамбрий, мезозой, неозой, палеозой ", ID = 1 }); questions[0].AddChoices(new Choice() { IsAnswer = false, Text = "мезозой, неозой, докамбрий, палеозой ", ID = 2 }); questions[0].AddChoices(new Choice() { IsAnswer = false, Text = "палеозой, мезозой, неозой, докамбрий ", ID = 3 }); questions[0].AddChoices(new Choice() { IsAnswer = true, Text = "докамбрий, палеозой, мезозой, неозой", ID = 4 });
            questions[1].AddChoices(new Choice() { IsAnswer = true, Text = "екваториален", ID = 5 }); questions[1].AddChoices(new Choice() { IsAnswer = false, Text = "субекваториален", ID = 6 }); questions[1].AddChoices(new Choice() { IsAnswer = false, Text = "тропичен ", ID = 7 }); questions[1].AddChoices(new Choice() { IsAnswer = false, Text = "умерен ", ID = 8 });
            questions[2].AddChoices(new Choice() { IsAnswer = false, Text = "Северна Америка, Африка, Азия ", ID = 9 }); questions[2].AddChoices(new Choice() { IsAnswer = false, Text = "Азия, Африка, Австралия ", ID = 10 }); questions[2].AddChoices(new Choice() { IsAnswer = true, Text = "Северна Америка, Европа, Азия", ID = 11 }); questions[2].AddChoices(new Choice() { IsAnswer = false, Text = " Южна Америка, Антарктида, Австралия", ID = 12 });
            questions[3].AddChoices(new Choice() { IsAnswer = false, Text = "демографско развитие ", ID = 13 }); questions[3].AddChoices(new Choice() { IsAnswer = false, Text = "демографски преход ", ID = 14 }); questions[3].AddChoices(new Choice() { IsAnswer = true, Text = " демографски взрив", ID = 15 }); questions[3].AddChoices(new Choice() { IsAnswer = false, Text = " демографска криза ", ID = 16 });
            questions[4].AddChoices(new Choice() { IsAnswer = false, Text = "полуостров Индостан и Източна Азия ", ID = 17 }); questions[4].AddChoices(new Choice() { IsAnswer = false, Text = " Западна Европа ", ID = 18 }); questions[4].AddChoices(new Choice() { IsAnswer = false, Text = " източното крайбрежие на Северна Америка", ID = 19 }); questions[4].AddChoices(new Choice() { IsAnswer = true, Text = " Централна Африка ", ID = 20 });
            questions[5].AddChoices(new Choice() { IsAnswer = false, Text = "Германия ", ID = 21 }); questions[5].AddChoices(new Choice() { IsAnswer = false, Text = " Франция ", ID = 22 }); questions[5].AddChoices(new Choice() { IsAnswer = false, Text = " Гърция", ID = 23 }); questions[5].AddChoices(new Choice() { IsAnswer = true, Text = " Норвегия", ID = 24 });
            questions[6].AddChoices(new Choice() { IsAnswer = false, Text = "Италия, Испания, Португалия ", ID = 25 }); questions[6].AddChoices(new Choice() { IsAnswer = false, Text = " САЩ, Русия, Гърция ", ID = 26 }); questions[6].AddChoices(new Choice() { IsAnswer = true, Text = " Великобритания, Испания, Дания", ID = 27 }); questions[6].AddChoices(new Choice() { IsAnswer = false, Text = " Русия, Полша, Франция", ID = 28 });
            questions[7].AddChoices(new Choice() { IsAnswer = true, Text = " Китай, САЩ, Индия ", ID = 29 }); questions[7].AddChoices(new Choice() { IsAnswer = false, Text = " Бразилия, Куба, Боливия", ID = 30 }); questions[7].AddChoices(new Choice() { IsAnswer = false, Text = " Турция, Египет, Еквадор", ID = 31 }); questions[7].AddChoices(new Choice() { IsAnswer = false, Text = " Япония, Тайланд, Индонезия", ID = 32 });
            questions[8].AddChoices(new Choice() { IsAnswer = false, Text = " съществува икономическа зависимост от развитите страни", ID = 33 }); questions[8].AddChoices(new Choice() { IsAnswer = false, Text = " развито е монокултурното земеделие ", ID = 34 }); questions[8].AddChoices(new Choice() { IsAnswer = true, Text = " силно развит е третичният сектор ", ID = 35 }); questions[8].AddChoices(new Choice() { IsAnswer = false, Text = " стопанските отрасли са неравномерно разпределени ", ID = 36 });
            questions[9].AddChoices(new Choice() { IsAnswer = true, Text = " Япония ", ID = 37 }); questions[9].AddChoices(new Choice() { IsAnswer = false, Text = " Виетнам", ID = 38 }); questions[9].AddChoices(new Choice() { IsAnswer = false, Text = " Малайзия", ID = 39 }); questions[9].AddChoices(new Choice() { IsAnswer = false, Text = " Индонезия", ID = 40 });
            questions[10].AddChoices(new Choice() { IsAnswer = false, Text = " Гърция ", ID = 41 }); questions[10].AddChoices(new Choice() { IsAnswer = false, Text = "Турция", ID = 42 }); questions[10].AddChoices(new Choice() { IsAnswer = false, Text = " Сърбия", ID = 43 }); questions[10].AddChoices(new Choice() { IsAnswer = true, Text = " Македония", ID = 44 });
            questions[11].AddChoices(new Choice() { IsAnswer = false, Text = " Предбалкан", ID = 45 }); questions[11].AddChoices(new Choice() { IsAnswer = true, Text = " Дунавска равнина", ID = 46 }); questions[11].AddChoices(new Choice() { IsAnswer = false, Text = " Средногорие ", ID = 47 }); questions[11].AddChoices(new Choice() { IsAnswer = false, Text = " Западни Родопи", ID = 48 });
            questions[12].AddChoices(new Choice() { IsAnswer = false, Text = " хромова руда ", ID = 49 }); questions[12].AddChoices(new Choice() { IsAnswer = true, Text = " медна руда ", ID = 50 }); questions[12].AddChoices(new Choice() { IsAnswer = false, Text = " манганова руда", ID = 51 }); questions[12].AddChoices(new Choice() { IsAnswer = false, Text = " желязна руда ", ID = 52 });
            questions[13].AddChoices(new Choice() { IsAnswer = true, Text = " умереноконтинентална", ID = 53 }); questions[13].AddChoices(new Choice() { IsAnswer = false, Text = " преходноконтинентална", ID = 54 }); questions[13].AddChoices(new Choice() { IsAnswer = false, Text = " континентално-средиземноморска", ID = 55 }); questions[13].AddChoices(new Choice() { IsAnswer = false, Text = " планинска", ID = 56 });
            questions[14].AddChoices(new Choice() { IsAnswer = false, Text = "Марица ", ID = 57 }); questions[14].AddChoices(new Choice() { IsAnswer = false, Text = " Арда ", ID = 58 }); questions[14].AddChoices(new Choice() { IsAnswer = false, Text = " Тунджа", ID = 59 }); questions[14].AddChoices(new Choice() { IsAnswer = true, Text = "Осъм ", ID = 60 });
            questions[15].AddChoices(new Choice() { IsAnswer = false, Text = "смолници", ID = 61 }); questions[15].AddChoices(new Choice() { IsAnswer = false, Text = " планинско-ливадни", ID = 62 }); questions[15].AddChoices(new Choice() { IsAnswer = true, Text = " алувиално-ливадни", ID = 63 }); questions[15].AddChoices(new Choice() { IsAnswer = false, Text = " канелени горски ", ID = 64 });
            questions[16].AddChoices(new Choice() { IsAnswer = false, Text = " Карловска ", ID = 65 }); questions[16].AddChoices(new Choice() { IsAnswer = false, Text = " Казанлъшка", ID = 66 }); questions[16].AddChoices(new Choice() { IsAnswer = true, Text = " Сливенска ", ID = 67 }); questions[16].AddChoices(new Choice() { IsAnswer = false, Text = " Златишко-Пирдопска", ID = 68 });
            questions[17].AddChoices(new Choice() { IsAnswer = false, Text = "Руй ", ID = 69 }); questions[17].AddChoices(new Choice() { IsAnswer = true, Text = " Витоша", ID = 68 }); questions[17].AddChoices(new Choice() { IsAnswer = false, Text = " Земенска", ID = 71 }); questions[17].AddChoices(new Choice() { IsAnswer = false, Text = " Конявска", ID = 72 });
            questions[18].AddChoices(new Choice() { IsAnswer = false, Text = "Самоковска котловина – долина на р. Искър ", ID = 71 }); questions[18].AddChoices(new Choice() { IsAnswer = false, Text = " Казанлъшка котловина – долина на р. Тунджа", ID = 72 }); questions[18].AddChoices(new Choice() { IsAnswer = false, Text = " Разложка котловина – долина на р. Места ", ID = 75 }); questions[18].AddChoices(new Choice() { IsAnswer = true, Text = " Гоцеделчевска котловина – долина на р. Струма", ID = 76 });
            questions[19].AddChoices(new Choice() { IsAnswer = false, Text = "Източни Родопи ", ID = 75 }); questions[19].AddChoices(new Choice() { IsAnswer = false, Text = " Лудогорие ", ID = 76 }); questions[19].AddChoices(new Choice() { IsAnswer = true, Text = " Северозападна България", ID = 79 }); questions[19].AddChoices(new Choice() { IsAnswer = false, Text = "поречието на р. Места", ID = 80 });

            return questions;
        }
        public Grade Grade(Exam gradeExam)
        {
            var completeExam = GetExam();
            var grade = new Grade() { Exam = completeExam };

            foreach (var question in gradeExam.Questions)
            {
                var newQuestion = (from q in completeExam.Questions
                                   where q.ID == question.ID
                                   select q).SingleOrDefault();
                if (newQuestion != null)
                {
                    foreach (var choice in question.Choices)
                    {
                        var answer = (from c in newQuestion.Choices
                                      where c.ID == choice.ID
                                      select c).SingleOrDefault();
                        answer.IsSelected = true;

                        if (answer.IsAnswer)
                        {
                            grade.Score += newQuestion.Point;
                        }
                    }
                }
            }
            return grade;

        }
    }
}