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
	public static class VCVEWSYSIFE
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
		private static readonly Action<LogLevel, string> KRUNCKBUXZN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool YRLMDAULEWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static bool YBRRDQRCYGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void RGGOKDNNGQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70")]
		public static bool PCYJJHXGSCF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x988FE90", Offset = "0x988EC90", VA = "0x18988FE90")]
		[MonoPInvokeCallback(typeof(Action<LogLevel, string>))]
		private static void WCNLEGOBJIK(LogLevel a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x988FF50", Offset = "0x988ED50", VA = "0x18988FF50")]
		public static bool XKEOGGDTDUI(Action<double> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160")]
		public static ApplePencilPreferredTapAction NDMYKFUKLWB()
		{
			return default(ApplePencilPreferredTapAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD36B30", Offset = "0xD35930", VA = "0x180D36B30")]
		public static int TZQUKOOFREH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x988FE50", Offset = "0x988EC50", VA = "0x18988FE50")]
		public static int TotalAvailableMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x172C9A0", Offset = "0x172B7A0", VA = "0x18172C9A0")]
		public static int TotalPhysicalMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void OKMLTLOFWSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void EDMYCCXTSIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void PQWTDOAUOXF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void JRBEHGIMCPN(iOSStatusBarStyle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void BMRYVXMFRNH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x988FDE0", Offset = "0x988EBE0", VA = "0x18988FDE0")]
		public static void EQQLXBTBGBL(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xF02B10", Offset = "0xF01910", VA = "0x180F02B10")]
		public static float UMPIFGOVNCE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void MFFREFPDNIP(bool a)
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
