using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.BuilderDesignPattern
{
    public class ComputerBuilder
    {

        private string brand;
        private string price;
        private string cpu;
        private string ram;

        public ComputerBuilder setBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public ComputerBuilder setPrice(string price)
        {
            this.price = price;
            return this;
        }

        public ComputerBuilder setCpu(string cpu)
        {
            this.cpu = cpu;
            return this;
        }

        public ComputerBuilder setRam(string ram)
        {
            this.ram = ram;
            return this;
        }

        public Computer buildComputer()
        {
            return new Computer(this.brand, this.price, this.cpu, this.ram);
        }
    }
}
