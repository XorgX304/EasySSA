﻿#region License
// ====================================================
// EasySSA Copyright(C) 2017 Furkan Türkal
// This program comes with ABSOLUTELY NO WARRANTY; This is free software,
// and you are welcome to redistribute it under certain conditions; See
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion

using EasySilkroadSecurityApi.SSA;

namespace EasySilkroadSecurityApi.Packets.Messages.Server {
    public sealed class ExchangePacket : Packet {

        //Packet -> 0x7081

        public ExchangePacket(ushort opcode) : base(opcode) {
            
        }
    }
}
