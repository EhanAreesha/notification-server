using System;
using System.Collections.Generic;

public static class DataManager
{
    public static NotifyMessage GetData()
    {
        var r = new Random();
        string Id = r.Next(1, 40).ToString();
        return new NotifyMessage{ Id = Id, Message = "Message - " + Id + " From Server", CreatedDate = DateTime.Now.ToShortDateString(), IsUnread = true };
    }
}