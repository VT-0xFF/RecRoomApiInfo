using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Platforms.IOS
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum AudioSessionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		GameChat,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Measurement,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		MoviePlayback,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		SpokenAudio,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		VideoChat,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		VideoRecording,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		VoiceChat,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		VoicePrompt
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum AudioSessionCategory
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		Ambient,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		MultiRoute,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		PlayAndRecord,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Playback,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Record,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		SoloAmbient
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Flags]
	public enum AudioSessionCategoryOptions
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		MixWithOthers = 1,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		DuckOthers = 2,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		InterruptSpokenAudio = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		AllowBluetooth = 4,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		AllowBluetoothA2DP = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		AllowAirPlay = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		DefaultToSpeaker = 8,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		MutedMicrophoneInterruption = 0x80
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum AudioSessionPort
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		BuiltInMic,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		HeadsetMic,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		LineIn,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		AirPlay,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		BluetoothA2DP,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		BluetoothLE,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		BuiltInReceiver,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		BuiltInSpeaker,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		HDMI,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Headphones,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		LineOut,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		AVB,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		BluetoothHFP,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		DisplayPort,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		CarAudio,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		FireWire,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		PCI,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Thunderbolt,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		USBAudio,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Virtual
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum AudioSessionModeOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		VoiceProcessingIO,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		RemoteIO
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum LogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Info
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct AudioRouteInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AudioSessionCategory category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AudioSessionCategoryOptions categoryOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AudioSessionMode mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int inputPortCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int outputPortCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AudioSessionPort firstInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AudioSessionPort firstOutput;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FCYRGNMTGOG
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum ApplePencilPreferredTapAction
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Off,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			SwitchBetweenCurrentToolAndEraser,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			SwitchBetweenCurrentToolAndLastUsed,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			ShowColorPalette
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum iOSStatusBarStyle
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			LightContent
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly Action<LogLevel, string> MJWMKXDPDED;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool XJYXTSBLYZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static bool BFQYUZCMQOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static void YTRFRKEAHXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D280", Offset = "0x8A4BE80", VA = "0x188A4D280")]
		public static void HAVGADAOGSK(AudioSessionModeOverride a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90")]
		public static bool VMITYDDYVSF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D250", Offset = "0x8A4BE50", VA = "0x188A4D250")]
		public static AudioRouteInfo BRVPDBEZFUM()
		{
			return default(AudioRouteInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D310", Offset = "0x8A4BF10", VA = "0x188A4D310")]
		[MonoPInvokeCallback(typeof(Action<LogLevel, string>))]
		private static void LHJWIYGGKAK(LogLevel a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D480", Offset = "0x8A4C080", VA = "0x188A4D480")]
		public static bool XLSSZTWWKMQ(Action<double> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800")]
		public static ApplePencilPreferredTapAction HCJTPBOCHSF()
		{
			return default(ApplePencilPreferredTapAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB64510", Offset = "0xB63110", VA = "0x180B64510")]
		public static int HCQSLXMBECL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D440", Offset = "0x8A4C040", VA = "0x188A4D440")]
		public static int TotalAvailableMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x23D7F00", Offset = "0x23D6B00", VA = "0x1823D7F00")]
		public static int TotalPhysicalMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static void ZUYUSVBKZDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static void NGLEIYFSKZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static void KEQGRTPEIRF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static void KHYWVNHGTML(iOSStatusBarStyle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static void TSXCWBJJPOZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A4D3D0", Offset = "0x8A4BFD0", VA = "0x188A4D3D0")]
		public static void MEWZCASTUZX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF874E0", Offset = "0xF860E0", VA = "0x180F874E0")]
		public static float XWPOTHHULVK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static void QNPVTZTJCGD(bool a)
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
