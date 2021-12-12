using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWordService
    {
        public IResult Add(Word word);
        public IResult Delete(Word word);
        public IResult Update(Word word);
        public IDataResult<Word> GetById(int id);
        public IDataResult<List<Word>> GetByLevel(string level);
        public IDataResult<List<Word>> GetAll();
    }
}
