using HelpDeskApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskApp.Data.Repository
{
    public class MockCasesRepository : IRepository
    {
        List<CardModel> _cases;

        public MockCasesRepository()
        {
            _cases = new()
            {
                new CardModel()
                {
                    Id = 0,
                    CompanyName = "ООО 'МУЖЧИНА В ДОМЕ'",
                    CreationDay = new(2021, 2, 8),
                    Subject = "Проблема с монитором",
                    Message = "Здравствуйте! У меня на мониторе сидела кошка и он (монитор) перевернулся в вертикальную сторону и я не знаю, как мне поправить на горизонтальное положение.Помогите! Спасибо!",
                    Alarm = AlarmLevel.High,
                    CurrentState = State.Active
                },
                new CardModel()
                {
                    Id = 1,
                    CompanyName = "ООО 'МУЖЧИНА ЭТО БОГ'",
                    CreationDay = new(2021, 2, 23),
                    Subject = "Help",
                    Message = "У меня нет проблемы, просто печалька.",
                    Alarm = AlarmLevel.Medium,
                    CurrentState = State.Active
                },
                new CardModel()
                {
                    Id = 2,
                    CompanyName = "ООО 'ОТЖИГАЙ И ЖГИ'",
                    CreationDay = new(2021, 1, 24),
                    Subject = "Утерян доступ к аккаунту",
                    Message = "Сим карта утеряна, нет доступа чтобы скинуть пароль, можно ли привязать новый номер телевизора?",
                    Alarm = AlarmLevel.Low,
                    CurrentState = State.Active
                },
                new CardModel()
                {
                    Id = 3,
                    CompanyName = "ООО 'ПЫХ - ПЫХ'",
                    CreationDay = new(2021, 1, 1),
                    Subject = "Ударила коробку под столом",
                    Message = "Со злости ударила коробку под столом и теперь мой компьютер постоянно меня атакует , выкидывает со страницы и не дает общаться с людьми.",
                    Alarm = AlarmLevel.None,
                    CurrentState = State.Active
                }
            };
        }
        public List<CardModel> GetAllCases()
        {
            return _cases;
        }
    }
}
