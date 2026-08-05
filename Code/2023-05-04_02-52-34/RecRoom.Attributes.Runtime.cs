using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NJFOKHEFJBI : MNCHKJFLKIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string NDFEBDPMJCB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xCD5E70", Offset = "0xCD5270", VA = "0x180CD5E70")]
	public NJFOKHEFJBI(string NPACPIKOAGD, string NDFEBDPMJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class OIOIFPGJIJH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type FEGMJDGILFC;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xCD5F90", Offset = "0xCD5390", VA = "0x180CD5F90")]
	public OIOIFPGJIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
	public OIOIFPGJIJH(Type EKFPJKPHOAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class CJJENPKIIJN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
	public CJJENPKIIJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class GLFADEJPPJM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string HPEGLNJDJCH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xCD5D30", Offset = "0xCD5130", VA = "0x180CD5D30")]
	public GLFADEJPPJM(string HPEGLNJDJCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DIMAPHHKBON
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Self,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Parent,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Children,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	SelfAndParent,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	SelfAndChildren,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NestedParent
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EPAJBOKMDOH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xCD5C50", Offset = "0xCD5050", VA = "0x180CD5C50")]
	public EPAJBOKMDOH(DIMAPHHKBON OGILDIMGIOH = DIMAPHHKBON.Self, bool CBFAAEFDCMD = false, bool JDPAHDGBFHK = false, bool GBGDJHKILOP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DOHNIIAADJA : EPAJBOKMDOH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xCD5C50", Offset = "0xCD5050", VA = "0x180CD5C50")]
	public DOHNIIAADJA(DIMAPHHKBON OGILDIMGIOH = DIMAPHHKBON.Self, bool CBFAAEFDCMD = false, bool JDPAHDGBFHK = false, bool GBGDJHKILOP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class EKDEOAFIOFN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum DCDEHDJCJFJ
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
	public readonly string JNIGPBNMPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly DCDEHDJCJFJ OGILDIMGIOH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xCD5CF0", Offset = "0xCD50F0", VA = "0x180CD5CF0")]
	public EKDEOAFIOFN(string JNIGPBNMPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xCD5CA0", Offset = "0xCD50A0", VA = "0x180CD5CA0")]
	public EKDEOAFIOFN(string JNIGPBNMPDD, DCDEHDJCJFJ OGILDIMGIOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MNCHKJFLKIP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string NPACPIKOAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool MIFAADJLLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] CEGFFCJKBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool PPIPPNOFPOO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xCD5D60", Offset = "0xCD5160", VA = "0x180CD5D60")]
	public MNCHKJFLKIP(string NPACPIKOAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xCD5B10", Offset = "0xCD4F10", VA = "0x180CD5B10")]
	public MNCHKJFLKIP(string NPACPIKOAGD, object BPEOEDEGNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xCD5BF0", Offset = "0xCD4FF0", VA = "0x180CD5BF0")]
	public MNCHKJFLKIP(string NPACPIKOAGD, params object[] CEGFFCJKBGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BINLJJLPDPI : MNCHKJFLKIP
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xCD5B10", Offset = "0xCD4F10", VA = "0x180CD5B10")]
	public BINLJJLPDPI(string NPACPIKOAGD, object BPEOEDEGNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xCD5BF0", Offset = "0xCD4FF0", VA = "0x180CD5BF0")]
	public BINLJJLPDPI(string NPACPIKOAGD, params object[] CEGFFCJKBGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AMBCFDMAFAL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool KNCKODJCNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string EDGAKDHNHMG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xCD5AC0", Offset = "0xCD4EC0", VA = "0x180CD5AC0")]
	public AMBCFDMAFAL(string DKFFAJGOPOG, bool NHMACDHJHNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LJMKHEMPFPG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
	public LJMKHEMPFPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CHFCICJFDEJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
	public CHFCICJFDEJ()
	{
	}
}
namespace Cpp2IlInjected;

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
