using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WordManager : IWordService
    {
        IWordDal _wordDal;

        public WordManager(IWordDal wordDal)
        {
            _wordDal = wordDal;
        }

        [ValidationAspect(typeof(WordValidator))]
        public IResult Add(Word word)
        {
            _wordDal.Add(word);
            return new SuccessResult(Messages.WordAdded);
        }

        public IResult Delete(Word word)
        {
            _wordDal.Delete(word);
            return new SuccessResult(Messages.WordDeleted);
        }

        public IDataResult<List<Word>> GetAll()
        {
            return new SuccessDataResult<List<Word>>(Messages.WordsListed, _wordDal.GetAll());
        }

        public IDataResult<Word> GetById(int id)
        {
            return new SuccessDataResult<Word>(Messages.WordsListed, _wordDal.Get(word => word.Id == id));
        }

        public IDataResult<List<Word>> GetByLevel(string level)
        {
            return new SuccessDataResult<List<Word>>(Messages.WordsListed, _wordDal.GetAll(word => word.Level == level));
        }

        public IResult Update(Word word)
        {
            _wordDal.Update(word);
            return new SuccessResult(Messages.WordUpdated);
        }
    }
}
