using _3PidehTravelManagement_Domain.Exceptions;
using _3PidehTravelManagement_Domain.ValueObjects;
using _3PidehTravelManagement_Shared.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Entities
{
    public class TravellerCheckList : AggregateRoot<TravellerCheckListId>
    {
        public TravellerCheckListId Id { get; private set; }
        private TravellerCheckListName _name;
        private Destination _destination;

        private readonly LinkedList<TravellerItem> _items = new();

        public TravellerCheckList()
        {

        }

        internal TravellerCheckList(TravellerCheckListId id, TravellerCheckListName name, Destination destination)
        {
            Id = id;
            _name = name;
            _destination = destination;
        }

        private TravellerCheckList(TravellerCheckListId id, TravellerCheckListName name, Destination destination
            ,LinkedList<TravellerItem> items):this(id,name,destination)
        {
            _items = items;
        }

        public void AddItem(TravellerItem item)
        {
            var alearyExist = _items.Any(x => x.Name == item.Name);

            if (alearyExist)
            {
                throw new TravellerItemAlreadyExistsException(_name,item.Name);
            }

            _items.AddLast(item);
        }

        public void AddItems(IEnumerable<TravellerItem> items)
        {
            foreach (var item in items)
            {
                _items.AddLast(item);
            }
        }

        public void TakeItem(string itemName)
        {
            var item = GetItem(itemName);
            var TravelerItem = item with { IsTaken = true};

            _items.Find(item).Value = TravelerItem;
        }

        private TravellerItem GetItem(string itemName)
        {
            var item = _items.SingleOrDefault(x => x.Name == itemName);

            if (item is null)
            {
                throw new TravellerItemNotFoundException(itemName);
            }

            return item;
        }

        public void Remove(string itemName)
        {
            var item = GetItem(itemName);
            _items.Remove(item);
        }
    }
}
