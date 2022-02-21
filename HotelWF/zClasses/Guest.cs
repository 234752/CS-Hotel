using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWF.zClasses
{
    internal class Guest
    {
        private string Name { get; set; }
        private double Balance { get; set; }
        public string getName() { return Name; }
        public double getBalance() { return Balance; }
        public List<Access> accesses { get; set; } = new List<Access> { null, null, null};
        public bool addBalance(double cash)
        {
            if (cash < 0) return false;
            Balance += cash;
            return true;
        }
        public Guest(string name0, double balance0)
        {
            Name = name0;
            Balance = balance0;
        }
        public void addAccess(Access A, int index0)
        {
            if (this.getBalance() < A.getPrice()) throw new Exception();
            accesses[index0] = A;
            this.Balance-=A.getPrice();
        }
        public void removeAccess(int index0)
        {
            this.Balance+=accesses[index0].getPrice();
            accesses[index0] = null;
        }
    }
}
