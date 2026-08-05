using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x800D580", Offset = "0x800C180", VA = "0x18800D580", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MOIEHJINFNO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JDEKHCNAJHF(string MKMPFLKICKK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BKECKHFGBJI(string MKMPFLKICKK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JOHEHECMLDD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class AAFGAGFILIC : MOIEHJINFNO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> LDCNMHDKEFL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] GHHMGCDEJHD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] OINIMPFLIFE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] JPHOMCKKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x800D4C0", Offset = "0x800C0C0", VA = "0x18800D4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] ALNBAFCEALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x800CF00", Offset = "0x800BB00", VA = "0x18800CF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x800D150", Offset = "0x800BD50", VA = "0x18800D150")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void GDCJIDLIJAN(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x800D3A0", Offset = "0x800BFA0", VA = "0x18800D3A0")]
	internal static string[] LBNIFDEFNNH(string[] GGKGBDGINAF, string[] OKDBPFFGAIB, List<string> BJEKPAIGKIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x800D4D0", Offset = "0x800C0D0", VA = "0x18800D4D0", Slot = "4")]
	private string OENFDCHGLAI(string MKMPFLKICKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x800D250", Offset = "0x800BE50", VA = "0x18800D250")]
	public static string JDEKHCNAJHF(string MKMPFLKICKK, [Optional] string PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x800D300", Offset = "0x800BF00", VA = "0x18800D300", Slot = "5")]
	private bool JKONPBIOGHB(string MKMPFLKICKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x800D0B0", Offset = "0x800BCB0", VA = "0x18800D0B0")]
	public static bool BKECKHFGBJI(string MKMPFLKICKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public AAFGAGFILIC()
	{
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
