using Apliccation.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
namespace Apliccation.Services
{
    public class CreditCardServices : ICreditCardServices
    {
        private readonly IRepository<CreditCard> _creditCardRepository;

        public CreditCardServices()
        {
        }

        public CreditCardServices(IRepository<CreditCard> creditCardRepository)
        {
            _creditCardRepository = creditCardRepository;
        }
        public void Delete(Guid id)
        {
            _creditCardRepository.Delete(id);
        }

        public IEnumerable<CreditCard> GetAll()
        {
            return _creditCardRepository.GetAll();
        }

        public CreditCard GetById(Guid id)
        {
            return _creditCardRepository.GetById(id);
        }

        public void SaveEntity(CreditCard entity)
        {
            _creditCardRepository.SaveEntity(entity);
        }

        public void Update(CreditCard entity)
        {
            _creditCardRepository.Update(entity);
        }
    }
}
