using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Patterns_ {
    public class MessageText : IMessageText {
        private string text;
        private string authorName;

        public MessageText(string text, string authorName) {
            this.text = text;
            this.authorName = authorName;
        }

        public void Print() {
            PrintAuthorName();
            Console.Write($"---\"{text}\"---");
            Console.WriteLine("\r\n");
        }

        private void PrintAuthorName() {
            Console.WriteLine($"\r\n========{authorName}:");
        }

        public string AuthorName {
            get { return authorName;  }
            set { if (!String.IsNullOrEmpty(value)) authorName = value; }
        }

        public string Text {
            get { return text; }
            set { if (!String.IsNullOrEmpty(value)) text = value; }
        }
    }
}
