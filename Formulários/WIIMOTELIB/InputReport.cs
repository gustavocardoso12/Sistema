﻿// Decompiled with JetBrains decompiler
// Type: WiimoteLib.InputReport
// Assembly: WiimoteLib, Version=1.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 28943724-0E4E-4D79-8A57-1C742E32D3E4
// Assembly location: C:\Users\h\Desktop\New Folder (9)\WiimoteLib_1.8\WiimoteLib.dll

namespace WiimoteLib
{
    public enum InputReport : byte
    {
        Status = (byte)32,
        ReadData = (byte)33,
        OutputReportAck = (byte)34,
        Buttons = (byte)48,
        ButtonsAccel = (byte)49,
        IRAccel = (byte)51,
        ButtonsExtension = (byte)52,
        ExtensionAccel = (byte)53,
        IRExtensionAccel = (byte)55,
    }
}
