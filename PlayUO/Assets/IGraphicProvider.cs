// Decompiled with JetBrains decompiler
// Type: PlayUO.Assets.IGraphicProvider
// Assembly: Ultima.Client, Version=4.0.0.0, Culture=neutral, PublicKeyToken=6cc7e8bd89c5c6bf
// MVID: 0CAC2BC7-B53A-42C2-916C-A40DD9E7563D
// Assembly location: C:\Program Files (x86)\Electronic Arts\Ultima Online Classic\Ultima.Client.exe

using System;

namespace PlayUO.Assets
{
  public interface IGraphicProvider : IDisposable
  {
    Texture GetItem(int itemId);

    Texture GetGump(int gumpId);

    Texture GetTerrainTexture(int textureId);

    Texture GetTerrainIsometric(int landId);

    Texture GetLight(int lightId);

    Frames GetAnimation(int animationId);
  }
}
