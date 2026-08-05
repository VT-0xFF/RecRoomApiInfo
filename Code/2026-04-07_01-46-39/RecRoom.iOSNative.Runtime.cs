using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Platforms.IOS
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum LogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Info
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class EEBVGIWUTBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum ApplePencilPreferredTapAction
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			Off,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			SwitchBetweenCurrentToolAndEraser,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			SwitchBetweenCurrentToolAndLastUsed,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			ShowColorPalette
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum iOSStatusBarStyle
		{
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			LightContent
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Action<LogLevel, string> UTCHOFITWLO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool UWVBIEWUYXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static bool EYJPJNOTEHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void VLDEBKGHLQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0")]
		public static bool IWCKHYUYCVK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9A06C80", Offset = "0x9A05C80", VA = "0x189A06C80")]
		[MonoPInvokeCallback(typeof(Action<LogLevel, string>))]
		private static void ZNLBIVIAJGP(LogLevel a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A06C10", Offset = "0x9A05C10", VA = "0x189A06C10")]
		public static bool RNIHGMGCTLJ(Action<double> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210")]
		public static ApplePencilPreferredTapAction NWEWNANBITQ()
		{
			return default(ApplePencilPreferredTapAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD453D0", Offset = "0xD443D0", VA = "0x180D453D0")]
		public static int YJWDUQVRMAI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A06C40", Offset = "0x9A05C40", VA = "0x189A06C40")]
		public static int TotalAvailableMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x17382A0", Offset = "0x17372A0", VA = "0x1817382A0")]
		public static int TotalPhysicalMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void TSXWLBQAMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void JMZCPQEWFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void JJLECMWXVJE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void BTLESXUFEQG(iOSStatusBarStyle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void ECRNZGSAMOI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A06BA0", Offset = "0x9A05BA0", VA = "0x189A06BA0")]
		public static void MLMJFGUOYKK(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xF13AD0", Offset = "0xF12AD0", VA = "0x180F13AD0")]
		public static float GIXKZDYWWUX()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void PVSGANTBHLW(bool a)
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
