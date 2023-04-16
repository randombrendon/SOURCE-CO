// World Conquer Online Project 2.5517 - Phoenix Project Based
// This project has been created by Felipe Vieira Vendramini
// Source Infrastructure based on Phoenix Source, written by Gareth Jensen
// This source is targeted to Conquer Online, client version 5517
// 
// Computer User: Felipe Vieira
// File Created by:  Felipe Vieira Vendramini 
// zfserver v2.5517 - MsgServer - Warehouse.cs
// Last Edit: 2016/12/06 22:31
// Created: 2016/12/06 22:21

using System.Collections.Generic;
using MsgServer.Structures.Entities;
using ServerCore.Common.Enums;
using ServerCore.Networking.Packets;

namespace MsgServer.Structures.Items
{
    public class Warehouse
    {
        private const int _WAREHOUSE_LIIMIT_I = 40;
        private Character m_pOwner;
        private ushort m_dwIdentity;
        public Dictionary<uint, Item> Items;

        public Warehouse(Character pOwner, ushort pos)
        {
            m_pOwner = pOwner;
            Items = new Dictionary<uint, Item>();
            m_dwIdentity = pos;
        }

        public ushort Identity
        {
            get { return m_dwIdentity; }
        }

        public bool Add(Item item, bool loading = false)
        {
            if (IsFull()) return false;
            if (Items.ContainsKey(item.Identity)) return false;
            if (!loading)
            {
                item.Position = (ItemPosition)Identity;
                item.Save();
                SendSingle(item);
            }
            Items.Add(item.Identity, item);
            return true;
        }

        public bool Remove(uint idItem)
        {
            if (!Items.ContainsKey(idItem))
                return false;
            m_pOwner.Inventory.Add(Items[idItem]);
            Items.Remove(idItem);
            return true;
        }

        public bool Delete(uint idItem)
        {
            if (!Items.ContainsKey(idItem))
                return false;
            Items[idItem].Delete();
            Items.Remove(idItem);
            return true;
        }

        public void SendSingle(Item item)
        {
            int now = ServerCore.Common.UnixTimestamp.Timestamp();
            uint remain = 0;
            if (now < item.RemainingTime)
                remain = (uint)((item.RemainingTime - now));
            var pMsg = new MsgAccountSoftKb
            {
                Action = WarehouseMode.WH_ADDITEM,
                ItemsCount = 1,
                ItemIdentity = item.Identity,
                Itemtype = item.Type,
                Bless = item.ReduceDamage,
                Bound = item.Bound,
                Color = (byte)item.Color,
                Effect = (byte)item.Effect,
                Enchant = item.Enchantment,
                Identity = GetWarehouseIdentity(Identity),
                SocketOne = (byte)item.SocketOne,
                SocketTwo = (byte)item.SocketTwo,
                Type = 10,
                Suspicious = false,
                Plus = item.Plus,
                RemainingTime = remain,
                Locked = item.IsLocked(),
                StackAmount = item.StackAmount
            };
            m_pOwner.Send(pMsg);
            item.TryUnlockItem();
            item.SendPurification(m_pOwner);
            item.SendItemLockTime();
        }

        public void SendAll()
        {
            foreach (var item in Items.Values)
            {
                SendSingle(item);
                //var pMsg = new MsgAccountSoftKb
                //{
                //    Identity = GetWarehouseIdentity(Identity),
                //    Type = 10,
                //    ItemsCount = 0,
                //    Action = WarehouseMode.WH_ADDITEM,
                //    SocketOne = (byte) item.SocketOne,
                //    SocketTwo = (byte) item.SocketTwo,
                //    Plus = item.Plus,
                //    Locked = item.IsLocked(),
                //    Bound = item.Bound,
                //    Effect = (ushort) item.Effect,
                //    Color = (byte) item.Color,
                //    AddLevelExp = item.CompositionProgress,
                //    SocketProgress = item.SocketProgress,
                //    StackAmount = item.StackAmount,
                //    ItemIdentity = item.Identity,
                //    Itemtype = item.Type,
                //    RemainingTime = item.RemainingTime,
                //    Bless = item.ReduceDamage,
                //    Enchant = item.Enchantment,
                //    MaximumAmount = (byte) Items.Count, 
                //    Identifier = Identity
                //};
                ////pMsg.AddItem(item.Identity, item.Type, (byte)item.SocketOne, (byte)item.SocketTwo, item.Plus,
                ////    item.Enchantment, item.ReduceDamage,
                ////    item.Bound, (byte)item.Effect, item.IsLocked(), false, (byte)item.Color);
                //m_pOwner.Send(pMsg);
                //item.TryUnlockItem();
                //item.SendPurification(m_pOwner);
                //item.SendItemLockTime();
            }
        }

        public int RemainingSpace()
        {
            return _WAREHOUSE_LIIMIT_I - Items.Count;
        }

        public bool IsFull()
        {
            return Items.Count >= _WAREHOUSE_LIIMIT_I;
        }

        public static byte GetWarehousePosition(uint itemPos)
        {
            switch (itemPos)
            {
                case 8:
                    return 230;
                case 44:
                    return 231;
                case 4101:
                    return 232;
                case 10011:
                    return 233;
                case 10012:
                    return 234;
                case 10027:
                    return 235;
                case 10028:
                    return 236;
            }
            return 0;
        }

        public static uint GetWarehouseIdentity(uint itemPos)
        {
            switch (itemPos)
            {
                case 230:
                    return 8;
                case 231:
                    return 44;
                case 232:
                    return 4101;
                case 233:
                    return 10011;
                case 234:
                    return 10012;
                case 235:
                    return 10027;
                case 236:
                    return 10028;
            }
            return 0;
        }

        public Item this[uint idItem]
        {
            get
            {
                try
                {
                    return Items[idItem];
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}