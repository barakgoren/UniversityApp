using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realProject.Data_models
{
    public class Message
    {
        public string MessageId { get; set; }
        public string Sender { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public bool IsImportant { get; set; }
        
        public Message(string MessageId, string Sender, string Content, string Date, bool IsImportant)
        {
            this.MessageId = MessageId;
            this.Sender = Sender;
            this.Content = Content;
            this.Date = Date;
            this.IsImportant = IsImportant;
        }

        public override string ToString()
        {
            return $"{this.MessageId}^{this.Sender}^{this.Content}^{this.Date}^{this.IsImportant}";
        }
    }
}
