using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC250", Offset = "0x6ACAC50", VA = "0x186ACC250", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GGANBPMLLAE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CNBHNCAJCLH(string PFOPPCFDLPJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMOJPKBEPFP(string PFOPPCFDLPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LBLMJPPFDOG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class OHPBAPOPNFF : GGANBPMLLAE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> JMIPOHAMFKC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] MFNCKMNLJEL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] NLJMBPECJLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] ICCAABEPHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC0A0", Offset = "0x6ACAAA0", VA = "0x186ACC0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] KJAPOBFBKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC0B0", Offset = "0x6ACAAB0", VA = "0x186ACC0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBC90", Offset = "0x6ACA690", VA = "0x186ACBC90")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void CNFNMOPOGFM(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBE30", Offset = "0x6ACA830", VA = "0x186ACBE30")]
	internal static string[] FMMGBJFCKHI(string[] DHGGGHPBHIK, string[] KDOPHHAICHE, List<string> PGPJEOFNFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBFF0", Offset = "0x6ACA9F0", VA = "0x186ACBFF0", Slot = "4")]
	private string OCHPAFDOGII(string PFOPPCFDLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBBE0", Offset = "0x6ACA5E0", VA = "0x186ACBBE0")]
	public static string CNBHNCAJCLH(string PFOPPCFDLPJ, [Optional] string FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBF50", Offset = "0x6ACA950", VA = "0x186ACBF50", Slot = "5")]
	private bool KJPOMPKGBBC(string PFOPPCFDLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBD90", Offset = "0x6ACA790", VA = "0x186ACBD90")]
	public static bool DMOJPKBEPFP(string PFOPPCFDLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public OHPBAPOPNFF()
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
