﻿// World Conquer Online Project 2.5517 - Phoenix Project Based
// This project has been created by Felipe Vieira Vendramini
// Source Infrastructure based on Phoenix Source, written by Gareth Jensen
// This source is targeted to Conquer Online, client version 5517
// 
// Computer User: Felipe Vieira
// File Created by:  Felipe Vieira Vendramini 
// zfserver v2.5517 - MsgServer - 1102 - MsgAccountSoftKb.cs
// Last Edit: 2016/12/07 04:50
// Created: 2016/12/07 04:50

using MsgServer.Structures.Entities;
using MsgServer.Structures.Items;
using ServerCore.Common.Enums;
using ServerCore.Networking.Packets;

namespace MsgServer.Network.GameServer.Handlers
{
    public static partial class Handlers
    {
        public static void HandleWarehouse(Character pUser, MsgAccountSoftKb pMsg)
        {
            uint dwWarehouse = Warehouse.GetWarehousePosition(pMsg.Identity);
            if (!pUser.Warehouses.ContainsKey(dwWarehouse))
            {
                pUser.Send("Invalid warehouse.");
                return;
            }
            Warehouse wh = pUser.Warehouses[dwWarehouse];
            switch (pMsg.Action)
            {
                #region View Warehouse
                case WarehouseMode.WH_VIEW:
                    wh.SendAll();
                    break;
                #endregion
                #region Warehouse add item
                case WarehouseMode.WH_ADDITEM:
                    if (!wh.IsFull())
                    {
                        uint idItem = pMsg.Identifier;
                        Item item = null;
                        if (!pUser.Inventory.Items.TryGetValue(idItem, out item))
                            return; // item doesnt exist
                        if (!pUser.Inventory.Remove(item.Identity, ItemRemovalType.TAKE_OUT_FROM_INVENTORY_ONLY)) return;
                        wh.Add(item);
                    }
                    else
                    {
                        pUser.Send(ServerString.STR_WAREHOUSE_NO_MORE);
                    }
                    break;
                #endregion
                #region Warehouse remove item
                case WarehouseMode.WH_REMITEM:
                    uint idItem0 = pMsg.Identifier;
                    Item _item = wh[idItem0];
                    if (_item != null)
                    {
                        if (!wh.Remove(_item.Identity))
                            return;
                        pUser.Send(pMsg);
                    }
                    break;
                #endregion
            }
        }
    }
}