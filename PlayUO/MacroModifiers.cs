﻿// Decompiled with JetBrains decompiler
// Type: PlayUO.MacroModifiers
// Assembly: Ultima.Client, Version=4.0.0.0, Culture=neutral, PublicKeyToken=6cc7e8bd89c5c6bf
// MVID: 0CAC2BC7-B53A-42C2-916C-A40DD9E7563D
// Assembly location: C:\Program Files (x86)\Electronic Arts\Ultima Online Classic\Ultima.Client.exe

using System;

namespace PlayUO
{
  [Flags]
  public enum MacroModifiers
  {
    None = 0,
    All = 1,
    Ctrl = 2,
    Alt = 4,
    Shift = 8,
  }
}
