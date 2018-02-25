using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Patterns_ {
    public abstract class Decorator : IMessageText {
        private IMessageText messageText;
        public Decorator(IMessageText messageText) {
            this.messageText = messageText;
        }

        public virtual void Print() {
            messageText.Print();
        }

        public string AuthorName {
            get { return messageText.AuthorName;  }
            set { messageText.AuthorName = value;  }
        }

        public string Text {
            get { return messageText.Text;  }
            set { messageText.Text = value; }
        }
    }
}
