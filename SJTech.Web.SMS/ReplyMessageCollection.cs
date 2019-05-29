using System.Collections.Generic;

namespace SJTech.SMS
{
    public class ReplyMessageCollection
    {
        public List<IReplyMessage> MsgCollection { get; set; }

        public ReplyMessageCollection()
        {
            MsgCollection=new List<IReplyMessage>();
        }
    }
}
