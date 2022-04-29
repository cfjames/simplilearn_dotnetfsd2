using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section6._8
{
    abstract class StockType
    {
        private decimal _price;
        private List<Watcher> _watchers = new List<Watcher>();

        public string Name { get; }
        public decimal Price 
        {
            get { return _price; }
            set 
            {
                if (_price != value)
                {
                    _price = value;
                    SendNotifications();
                }

            }
        }

        public StockType() { }
       
        public StockType(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void AddWatcher(Watcher w)
        {
            _watchers.Add(w);
        }

        public void RemoveWatcher(Watcher w)
        {
            _watchers.Remove(w);
        }

        public void SendNotifications()
        {
            foreach (Watcher w in _watchers)
            {
                w.Notify(this);
            }
        }
    }


    interface Watcher
    {
        void Notify(StockType st);
    }

    class Tesla : StockType
    {
        public Tesla() { }

        public Tesla(string name, decimal price) : base(name, price) { }
    }

    class TeslaStockWatcher : Watcher
    {
        private string _name;
        private Tesla _tesla;

        public TeslaStockWatcher() { }

        public TeslaStockWatcher(string name, Tesla tesla)
        {
            _name = name;
            _tesla = tesla;

        }

        public void Notify(StockType st)
        {
            Console.WriteLine($"{_name} ALERT: Stock {_tesla.Name} price is now {_tesla.Price}");
        }
    }

}
