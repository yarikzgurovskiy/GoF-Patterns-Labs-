using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Patterns_ {
    public interface IMessageText {
        string AuthorName { get; set; }
        string Text { get; set; }
        void Print();
    }
}
