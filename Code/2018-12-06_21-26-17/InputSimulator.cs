using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

[assembly: AssemblyTitle("InputSimulator")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyCompany("michaelnoonan")]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyDescription("Provides a useful wrapper around the User32 SendInput and related native Windows functions.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("InputSimulator")]
[assembly: AssemblyCopyright("Copyright © michaelnoonan 2009")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("25871eb0-27d6-42da-a3fe-cb60eb01f15a")]
[assembly: AssemblyFileVersion("0.1.0.0")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: AssemblyVersion("0.1.0.0")]
namespace WindowsInput;

public enum XButton : uint
{
	XBUTTON1 = 1u,
	XBUTTON2
}
[StructLayout(LayoutKind.Explicit)]
internal struct MOUSEKEYBDHARDWAREINPUT
{
	[FieldOffset(0)]
	public MOUSEINPUT Mouse;

	[FieldOffset(0)]
	public KEYBDINPUT Keyboard;

	[FieldOffset(0)]
	public HARDWAREINPUT Hardware;
}
internal struct INPUT
{
	public uint Type;

	public MOUSEKEYBDHARDWAREINPUT Data;
}
public enum VirtualKeyCode : ushort
{
	LBUTTON = 1,
	RBUTTON = 2,
	CANCEL = 3,
	MBUTTON = 4,
	XBUTTON1 = 5,
	XBUTTON2 = 6,
	BACK = 8,
	TAB = 9,
	CLEAR = 12,
	RETURN = 13,
	SHIFT = 16,
	CONTROL = 17,
	MENU = 18,
	PAUSE = 19,
	CAPITAL = 20,
	KANA = 21,
	HANGEUL = 21,
	HANGUL = 21,
	JUNJA = 23,
	FINAL = 24,
	HANJA = 25,
	KANJI = 25,
	ESCAPE = 27,
	CONVERT = 28,
	NONCONVERT = 29,
	ACCEPT = 30,
	MODECHANGE = 31,
	SPACE = 32,
	PRIOR = 33,
	NEXT = 34,
	END = 35,
	HOME = 36,
	LEFT = 37,
	UP = 38,
	RIGHT = 39,
	DOWN = 40,
	SELECT = 41,
	PRINT = 42,
	EXECUTE = 43,
	SNAPSHOT = 44,
	INSERT = 45,
	DELETE = 46,
	HELP = 47,
	VK_0 = 48,
	VK_1 = 49,
	VK_2 = 50,
	VK_3 = 51,
	VK_4 = 52,
	VK_5 = 53,
	VK_6 = 54,
	VK_7 = 55,
	VK_8 = 56,
	VK_9 = 57,
	VK_A = 65,
	VK_B = 66,
	VK_C = 67,
	VK_D = 68,
	VK_E = 69,
	VK_F = 70,
	VK_G = 71,
	VK_H = 72,
	VK_I = 73,
	VK_J = 74,
	VK_K = 75,
	VK_L = 76,
	VK_M = 77,
	VK_N = 78,
	VK_O = 79,
	VK_P = 80,
	VK_Q = 81,
	VK_R = 82,
	VK_S = 83,
	VK_T = 84,
	VK_U = 85,
	VK_V = 86,
	VK_W = 87,
	VK_X = 88,
	VK_Y = 89,
	VK_Z = 90,
	LWIN = 91,
	RWIN = 92,
	APPS = 93,
	SLEEP = 95,
	NUMPAD0 = 96,
	NUMPAD1 = 97,
	NUMPAD2 = 98,
	NUMPAD3 = 99,
	NUMPAD4 = 100,
	NUMPAD5 = 101,
	NUMPAD6 = 102,
	NUMPAD7 = 103,
	NUMPAD8 = 104,
	NUMPAD9 = 105,
	MULTIPLY = 106,
	ADD = 107,
	SEPARATOR = 108,
	SUBTRACT = 109,
	DECIMAL = 110,
	DIVIDE = 111,
	F1 = 112,
	F2 = 113,
	F3 = 114,
	F4 = 115,
	F5 = 116,
	F6 = 117,
	F7 = 118,
	F8 = 119,
	F9 = 120,
	F10 = 121,
	F11 = 122,
	F12 = 123,
	F13 = 124,
	F14 = 125,
	F15 = 126,
	F16 = 127,
	F17 = 128,
	F18 = 129,
	F19 = 130,
	F20 = 131,
	F21 = 132,
	F22 = 133,
	F23 = 134,
	F24 = 135,
	NUMLOCK = 144,
	SCROLL = 145,
	LSHIFT = 160,
	RSHIFT = 161,
	LCONTROL = 162,
	RCONTROL = 163,
	LMENU = 164,
	RMENU = 165,
	BROWSER_BACK = 166,
	BROWSER_FORWARD = 167,
	BROWSER_REFRESH = 168,
	BROWSER_STOP = 169,
	BROWSER_SEARCH = 170,
	BROWSER_FAVORITES = 171,
	BROWSER_HOME = 172,
	VOLUME_MUTE = 173,
	VOLUME_DOWN = 174,
	VOLUME_UP = 175,
	MEDIA_NEXT_TRACK = 176,
	MEDIA_PREV_TRACK = 177,
	MEDIA_STOP = 178,
	MEDIA_PLAY_PAUSE = 179,
	LAUNCH_MAIL = 180,
	LAUNCH_MEDIA_SELECT = 181,
	LAUNCH_APP1 = 182,
	LAUNCH_APP2 = 183,
	OEM_1 = 186,
	OEM_PLUS = 187,
	OEM_COMMA = 188,
	OEM_MINUS = 189,
	OEM_PERIOD = 190,
	OEM_2 = 191,
	OEM_3 = 192,
	OEM_4 = 219,
	OEM_5 = 220,
	OEM_6 = 221,
	OEM_7 = 222,
	OEM_8 = 223,
	OEM_102 = 226,
	PROCESSKEY = 229,
	PACKET = 231,
	ATTN = 246,
	CRSEL = 247,
	EXSEL = 248,
	EREOF = 249,
	PLAY = 250,
	ZOOM = 251,
	NONAME = 252,
	PA1 = 253,
	OEM_CLEAR = 254
}
public enum KeyboardFlag : uint
{
	EXTENDEDKEY = 1u,
	KEYUP = 2u,
	UNICODE = 4u,
	SCANCODE = 8u
}
internal struct KEYBDINPUT
{
	public ushort Vk;

	public ushort Scan;

	public uint Flags;

	public uint Time;

	public IntPtr ExtraInfo;
}
public enum InputType : uint
{
	MOUSE,
	KEYBOARD,
	HARDWARE
}
public static class InputSimulator
{
	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint SendInput(uint numberOfInputs, INPUT[] inputs, int sizeOfInputStructure);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern short GetAsyncKeyState(ushort virtualKeyCode);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern short GetKeyState(ushort virtualKeyCode);

	[DllImport("user32.dll")]
	private static extern IntPtr GetMessageExtraInfo();

	public static bool IsKeyDownAsync(VirtualKeyCode keyCode)
	{
		short asyncKeyState = GetAsyncKeyState((ushort)keyCode);
		return asyncKeyState < 0;
	}

	public static bool IsKeyDown(VirtualKeyCode keyCode)
	{
		short keyState = GetKeyState((ushort)keyCode);
		return keyState < 0;
	}

	public static bool IsTogglingKeyInEffect(VirtualKeyCode keyCode)
	{
		short keyState = GetKeyState((ushort)keyCode);
		return (keyState & 1) == 1;
	}

	public static void SimulateKeyDown(VirtualKeyCode keyCode)
	{
		INPUT iNPUT = default(INPUT);
		iNPUT.Type = 1u;
		iNPUT.Data.Keyboard = default(KEYBDINPUT);
		iNPUT.Data.Keyboard.Vk = (ushort)keyCode;
		iNPUT.Data.Keyboard.Scan = 0;
		iNPUT.Data.Keyboard.Flags = 0u;
		iNPUT.Data.Keyboard.Time = 0u;
		iNPUT.Data.Keyboard.ExtraInfo = IntPtr.Zero;
		if (SendInput(1u, new INPUT[1] { iNPUT }, Marshal.SizeOf(typeof(INPUT))) == 0)
		{
			throw new Exception($"The key down simulation for {keyCode} was not successful.");
		}
	}

	public static void SimulateKeyUp(VirtualKeyCode keyCode)
	{
		INPUT iNPUT = default(INPUT);
		iNPUT.Type = 1u;
		iNPUT.Data.Keyboard = default(KEYBDINPUT);
		iNPUT.Data.Keyboard.Vk = (ushort)keyCode;
		iNPUT.Data.Keyboard.Scan = 0;
		iNPUT.Data.Keyboard.Flags = 2u;
		iNPUT.Data.Keyboard.Time = 0u;
		iNPUT.Data.Keyboard.ExtraInfo = IntPtr.Zero;
		if (SendInput(1u, new INPUT[1] { iNPUT }, Marshal.SizeOf(typeof(INPUT))) == 0)
		{
			throw new Exception($"The key up simulation for {keyCode} was not successful.");
		}
	}

	public static void SimulateKeyPress(VirtualKeyCode keyCode)
	{
		INPUT iNPUT = default(INPUT);
		iNPUT.Type = 1u;
		iNPUT.Data.Keyboard = default(KEYBDINPUT);
		iNPUT.Data.Keyboard.Vk = (ushort)keyCode;
		iNPUT.Data.Keyboard.Scan = 0;
		iNPUT.Data.Keyboard.Flags = 0u;
		iNPUT.Data.Keyboard.Time = 0u;
		iNPUT.Data.Keyboard.ExtraInfo = IntPtr.Zero;
		INPUT iNPUT2 = default(INPUT);
		iNPUT2.Type = 1u;
		iNPUT2.Data.Keyboard = default(KEYBDINPUT);
		iNPUT2.Data.Keyboard.Vk = (ushort)keyCode;
		iNPUT2.Data.Keyboard.Scan = 0;
		iNPUT2.Data.Keyboard.Flags = 2u;
		iNPUT2.Data.Keyboard.Time = 0u;
		iNPUT2.Data.Keyboard.ExtraInfo = IntPtr.Zero;
		if (SendInput(2u, new INPUT[2] { iNPUT, iNPUT2 }, Marshal.SizeOf(typeof(INPUT))) == 0)
		{
			throw new Exception($"The key press simulation for {keyCode} was not successful.");
		}
	}

	public static void SimulateTextEntry(string text)
	{
		if ((long)text.Length > 2147483647L)
		{
			throw new ArgumentException($"The text parameter is too long. It must be less than {2147483647u} characters.", "text");
		}
		byte[] bytes = Encoding.ASCII.GetBytes(text);
		int num = bytes.Length;
		INPUT[] array = new INPUT[num * 2];
		for (int i = 0; i < num; i++)
		{
			ushort num2 = bytes[i];
			INPUT iNPUT = default(INPUT);
			iNPUT.Type = 1u;
			iNPUT.Data.Keyboard = default(KEYBDINPUT);
			iNPUT.Data.Keyboard.Vk = 0;
			iNPUT.Data.Keyboard.Scan = num2;
			iNPUT.Data.Keyboard.Flags = 4u;
			iNPUT.Data.Keyboard.Time = 0u;
			iNPUT.Data.Keyboard.ExtraInfo = IntPtr.Zero;
			INPUT iNPUT2 = default(INPUT);
			iNPUT2.Type = 1u;
			iNPUT2.Data.Keyboard = default(KEYBDINPUT);
			iNPUT2.Data.Keyboard.Vk = 0;
			iNPUT2.Data.Keyboard.Scan = num2;
			iNPUT2.Data.Keyboard.Flags = 6u;
			iNPUT2.Data.Keyboard.Time = 0u;
			iNPUT2.Data.Keyboard.ExtraInfo = IntPtr.Zero;
			if ((num2 & 0xFF00) == 57344)
			{
				iNPUT.Data.Keyboard.Flags |= 1u;
				iNPUT2.Data.Keyboard.Flags |= 1u;
			}
			array[2 * i] = iNPUT;
			array[2 * i + 1] = iNPUT2;
		}
		uint num3 = SendInput((uint)(num * 2), array, Marshal.SizeOf(typeof(INPUT)));
	}

	public static void SimulateModifiedKeyStroke(VirtualKeyCode modifierKeyCode, VirtualKeyCode keyCode)
	{
		SimulateKeyDown(modifierKeyCode);
		SimulateKeyPress(keyCode);
		SimulateKeyUp(modifierKeyCode);
	}

	public static void SimulateModifiedKeyStroke(IEnumerable<VirtualKeyCode> modifierKeyCodes, VirtualKeyCode keyCode)
	{
		modifierKeyCodes?.ToList().ForEach(delegate(VirtualKeyCode x)
		{
			SimulateKeyDown(x);
		});
		SimulateKeyPress(keyCode);
		modifierKeyCodes?.Reverse().ToList().ForEach(delegate(VirtualKeyCode x)
		{
			SimulateKeyUp(x);
		});
	}

	public static void SimulateModifiedKeyStroke(VirtualKeyCode modifierKey, IEnumerable<VirtualKeyCode> keyCodes)
	{
		SimulateKeyDown(modifierKey);
		keyCodes?.ToList().ForEach(delegate(VirtualKeyCode x)
		{
			SimulateKeyPress(x);
		});
		SimulateKeyUp(modifierKey);
	}

	public static void SimulateModifiedKeyStroke(IEnumerable<VirtualKeyCode> modifierKeyCodes, IEnumerable<VirtualKeyCode> keyCodes)
	{
		modifierKeyCodes?.ToList().ForEach(delegate(VirtualKeyCode x)
		{
			SimulateKeyDown(x);
		});
		keyCodes?.ToList().ForEach(delegate(VirtualKeyCode x)
		{
			SimulateKeyPress(x);
		});
		modifierKeyCodes?.Reverse().ToList().ForEach(delegate(VirtualKeyCode x)
		{
			SimulateKeyUp(x);
		});
	}
}
internal struct MOUSEINPUT
{
	public int X;

	public int Y;

	public uint MouseData;

	public uint Flags;

	public uint Time;

	public IntPtr ExtraInfo;
}
public enum MouseFlag : uint
{
	MOVE = 1u,
	LEFTDOWN = 2u,
	LEFTUP = 4u,
	RIGHTDOWN = 8u,
	RIGHTUP = 0x10u,
	MIDDLEDOWN = 0x20u,
	MIDDLEUP = 0x40u,
	XDOWN = 0x80u,
	XUP = 0x100u,
	WHEEL = 0x800u,
	VIRTUALDESK = 0x4000u,
	ABSOLUTE = 0x8000u
}
internal struct HARDWAREINPUT
{
	public uint Msg;

	public ushort ParamL;

	public ushort ParamH;
}
