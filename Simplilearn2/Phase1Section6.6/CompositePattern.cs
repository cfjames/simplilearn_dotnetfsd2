using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section6._6
{
    public interface IComponent
    {
        int DisplayPrice();
    }

    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Leaf(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }

        public int DisplayPrice()
        {
            Console.WriteLine(Name + " : " + Price);
            return Price;
        }
    }

    public class Composite : IComponent
    {
        public string Name { get; set; }
        List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            this.Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public int DisplayPrice()
        {
            int totalPrice = 0;
            Console.WriteLine(Name);
            foreach (var item in components)
            {
                totalPrice += item.DisplayPrice();
            }

            return totalPrice;
        }
    }
}
