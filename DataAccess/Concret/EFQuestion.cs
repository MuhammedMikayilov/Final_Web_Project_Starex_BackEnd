using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entity.Entities.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concret
{
    public class EFQuestion: EFEntityRepositoryBase<Question, AppDbContext>, IQuestionDal
    {
    }
}
