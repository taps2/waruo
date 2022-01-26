﻿// Decompiled with JetBrains decompiler
// Type: PlayUO.Profiles.SoundData
// Assembly: Ultima.Client, Version=4.0.0.0, Culture=neutral, PublicKeyToken=6cc7e8bd89c5c6bf
// MVID: 0CAC2BC7-B53A-42C2-916C-A40DD9E7563D
// Assembly location: C:\Program Files (x86)\Electronic Arts\Ultima Online Classic\Ultima.Client.exe

using Sallos;

namespace PlayUO.Profiles
{
  public class SoundData : VolumeData
  {
    public static readonly PersistableType TypeCode = new PersistableType("sound", Construct);

    public override PersistableType TypeID
    {
      get
      {
        return SoundData.TypeCode;
      }
    }

    [Optionable("Sound", "Audio")]
    public Volume XYZ
    {
      get
      {
        return this.m_Volume;
      }
      set
      {
      }
    }

    private static PersistableObject Construct()
    {
      return (PersistableObject) new SoundData();
    }
  }
}
