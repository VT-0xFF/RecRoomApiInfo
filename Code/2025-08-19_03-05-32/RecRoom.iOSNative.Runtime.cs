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
	public static class ACFGXBCXYFW
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
		private static readonly Action<LogLevel, string> LPEKNXKOKFT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool OMCHCSXAHPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static bool GZDVKWFEGFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void AJLSNPJVPSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
		public static bool VIFSIAOYXZV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85DA590", Offset = "0x85D9390", VA = "0x1885DA590")]
		[MonoPInvokeCallback(typeof(Action<LogLevel, string>))]
		private static void CYRQERJEGMQ(LogLevel a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85DA700", Offset = "0x85D9500", VA = "0x1885DA700")]
		public static bool VQSMDMCLIRA(Action<double> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0")]
		public static ApplePencilPreferredTapAction CXJEUHAERXR()
		{
			return default(ApplePencilPreferredTapAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB0DD60", Offset = "0xB0CB60", VA = "0x180B0DD60")]
		public static int HXJRLEIMJNX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85DA6C0", Offset = "0x85D94C0", VA = "0x1885DA6C0")]
		public static int TotalAvailableMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x20D5B00", Offset = "0x20D4900", VA = "0x1820D5B00")]
		public static int TotalPhysicalMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void KUPPOQFLMQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void HGXMSUAKJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void VFIVRKGHZPP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void EGJWFWNHORD(iOSStatusBarStyle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void GZPKKRUJRDZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85DA650", Offset = "0x85D9450", VA = "0x1885DA650")]
		public static void EQLMTMYPADR(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xF302F0", Offset = "0xF2F0F0", VA = "0x180F302F0")]
		public static float JGTFRLBVOLI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void BTMIQRHAIGF(bool a)
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
