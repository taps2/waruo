// Decompiled with JetBrains decompiler
// Type: PlayUO.PDesigner_Build
// Assembly: Ultima.Client, Version=4.0.0.0, Culture=neutral, PublicKeyToken=6cc7e8bd89c5c6bf
// MVID: 0CAC2BC7-B53A-42C2-916C-A40DD9E7563D
// Assembly location: C:\Program Files (x86)\Electronic Arts\Ultima Online Classic\Ultima.Client.exe

namespace PlayUO
{
  internal class PDesigner_Build : Packet
  {
    public PDesigner_Build(Item house, int x, int y, int itemID)
      : base((byte) 215)
    {
      this.m_Stream.Write(house.Serial);
      this.m_Stream.Write((short) 6);
      this.m_Stream.WriteEncoded(itemID);
      this.m_Stream.WriteEncoded(x);
      this.m_Stream.WriteEncoded(y);
    }
  }
}
