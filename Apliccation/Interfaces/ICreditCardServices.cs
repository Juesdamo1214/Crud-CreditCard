using Domain.Models;
using System.Collections.Generic;
using System;

namespace Apliccation.Interfaces
{
    public interface ICreditCardServices
    {
        IEnumerable<CreditCard> GetAll();
        CreditCard GetById(Guid id);
        void SaveEntity(CreditCard entity);
        void Update(CreditCard entity);
        void Delete(Guid id);
    }
}