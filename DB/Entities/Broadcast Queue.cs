﻿// World Conquer Project 2.0 - Phoenix Project Based
// Source Development by Felipe Vieira (FTW! Masters)
// Source Infrastructure by Gareth Jensen (Akarui)
// 
// Computer User: Administrador
// File Created by: Felipe Vieira Vendramini
// zfserver - DB - Broadcast Queue.cs
// File Created: 2015/07/31 13:53
namespace DB.Entities
{
    public class DbBroadcastQueue
    {
        public virtual uint Identity { get; set; }
        public virtual uint NextIdentity { get; set; }
        public virtual uint UserIdentity { get; set; }
        public virtual string UserName { get; set; }
        public virtual uint Time { get; set; }
        public virtual ushort Addition { get; set; }
        public virtual string Message { get; set; }
    }
}