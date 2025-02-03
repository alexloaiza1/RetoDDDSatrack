using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoBanco.Domain.Aggregates
{
    public abstract class Aggregate<T>(T id, DateTime createdOn, DateTime lastModifiedOn) where T : struct
    {

        private readonly IList<IDomainEvent> _domainEvents = [];

        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public IReadOnlyKist<IDomainEvent> GetDomainEvents()
        {
            return [.. _domainEvents];


        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        public T Id { get; private  set; }

        public DateTime CreatedOn { get; private  set; }

        public DateTime LastModifiedOn { get; private set; }
    }

}
