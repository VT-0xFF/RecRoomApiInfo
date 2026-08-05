using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DMJKEDBMDNB : HLLDDOOCNDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string CFCMBEKHENJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F862B0", Offset = "0x7F852B0", VA = "0x187F862B0")]
	public DMJKEDBMDNB(string PBEGCDPJPKC, string CFCMBEKHENJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public class LMDAHBKKPCF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public LMDAHBKKPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class CCHBOOKFCOE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string DOLNIOHHOEP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F86090", Offset = "0x7F85090", VA = "0x187F86090")]
	public CCHBOOKFCOE(string DOLNIOHHOEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KDIHEPCABNF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Self,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Parent,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Children,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	SelfAndParent,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	SelfAndChildren,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NestedParent
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class COPMMNAHICH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F86210", Offset = "0x7F85210", VA = "0x187F86210")]
	public COPMMNAHICH(KDIHEPCABNF BJLNCBFOGNL = KDIHEPCABNF.Self, bool MCEOBPMIJND = false, bool MKGMCCJLLBJ = false, bool IMLAMNGBCFJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AHKKMDBCFOK : COPMMNAHICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type CJDICHPHDJG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F86020", Offset = "0x7F85020", VA = "0x187F86020")]
	public AHKKMDBCFOK(Type CILOOLAJHMG, KDIHEPCABNF BJLNCBFOGNL = KDIHEPCABNF.Self, bool MCEOBPMIJND = false, bool MKGMCCJLLBJ = false, bool IMLAMNGBCFJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ELFKDNHKCIP : COPMMNAHICH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F86210", Offset = "0x7F85210", VA = "0x187F86210")]
	public ELFKDNHKCIP(KDIHEPCABNF BJLNCBFOGNL = KDIHEPCABNF.Self, bool MCEOBPMIJND = false, bool MKGMCCJLLBJ = false, bool IMLAMNGBCFJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class JEMFMODOCAK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum HOLBCKDHIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Error
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string NCBKJJBPLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly HOLBCKDHIJJ BJLNCBFOGNL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F864D0", Offset = "0x7F854D0", VA = "0x187F864D0")]
	public JEMFMODOCAK(string NCBKJJBPLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x733D750", Offset = "0x733C750", VA = "0x18733D750")]
	public JEMFMODOCAK(string NCBKJJBPLBE, HOLBCKDHIJJ BJLNCBFOGNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HLLDDOOCNDF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string PBEGCDPJPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool FBLNBHHDJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] JPMEIBKPMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool BAJGDOOAPNA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F863D0", Offset = "0x7F853D0", VA = "0x187F863D0")]
	public HLLDDOOCNDF(string PBEGCDPJPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F86130", Offset = "0x7F85130", VA = "0x187F86130")]
	public HLLDDOOCNDF(string PBEGCDPJPKC, object JFDJNDJPLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F860D0", Offset = "0x7F850D0", VA = "0x187F860D0")]
	public HLLDDOOCNDF(string PBEGCDPJPKC, params object[] JPMEIBKPMID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CHGBBEMLBMP : HLLDDOOCNDF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F86130", Offset = "0x7F85130", VA = "0x187F86130")]
	public CHGBBEMLBMP(string PBEGCDPJPKC, object JFDJNDJPLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F860D0", Offset = "0x7F850D0", VA = "0x187F860D0")]
	public CHGBBEMLBMP(string PBEGCDPJPKC, params object[] JPMEIBKPMID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DEOPCHDHBJP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool KAMHDOCCPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string LBNPPGCGCNK;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F86260", Offset = "0x7F85260", VA = "0x187F86260")]
	public DEOPCHDHBJP(string GBPJCBNFDOE, bool JDCFFOLPIOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PCJOPKOHKDO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2317390", Offset = "0x2316390", VA = "0x182317390")]
	public PCJOPKOHKDO()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2317390", Offset = "0x2316390", VA = "0x182317390")]
		public ReadOnlyFieldAttribute()
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
