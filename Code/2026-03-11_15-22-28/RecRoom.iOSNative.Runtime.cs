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
	public static class NZWPDDOHHUU
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
		private static readonly Action<LogLevel, string> DALSCXTCSVD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool JDKEQEMKFNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static bool LKNKEITCGXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void DMPZFARMCZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0")]
		public static bool MHTNOBEJNRF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84E8460", Offset = "0x84E7460", VA = "0x1884E8460")]
		[MonoPInvokeCallback(typeof(Action<LogLevel, string>))]
		private static void SPVEKVNBDFK(LogLevel a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84E83C0", Offset = "0x84E73C0", VA = "0x1884E83C0")]
		public static bool EQEFDQFEDJM(Action<double> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90")]
		public static ApplePencilPreferredTapAction KTCNELHNSWP()
		{
			return default(ApplePencilPreferredTapAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB1C770", Offset = "0xB1B770", VA = "0x180B1C770")]
		public static int SPHXZBCPHZP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84E8520", Offset = "0x84E7520", VA = "0x1884E8520")]
		public static int TotalAvailableMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x14FEE60", Offset = "0x14FDE60", VA = "0x1814FEE60")]
		public static int TotalPhysicalMemoryMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void ZEWDRIYJPYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void MBZXKUVNHAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void SKTHIEOTURP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void XACWZPBJOBT(iOSStatusBarStyle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void ZVEKQNOIJGT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84E83F0", Offset = "0x84E73F0", VA = "0x1884E83F0")]
		public static void IWKBBWUVHWX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCA9500", Offset = "0xCA8500", VA = "0x180CA9500")]
		public static float LIGSXMKACAO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void LJKMXYISTTH(bool a)
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
