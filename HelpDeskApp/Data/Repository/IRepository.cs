using HelpDeskApp.Data;
using System.Collections.Generic;

namespace HelpDeskApp.Data.Repository
{
    public interface IRepository
    {
        List<CardModel> GetAllCases();

        void SaveModelChanges(CardModel _modelToSave);
    }
}
