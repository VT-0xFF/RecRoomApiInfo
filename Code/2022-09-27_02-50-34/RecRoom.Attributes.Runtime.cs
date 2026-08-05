using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AIALCDLFLCH : NAFDLBNKCNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string APLKOCMDNJG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x59BE070", Offset = "0x59BD270", VA = "0x1859BE070")]
	public AIALCDLFLCH(string BPGOPFFPIHJ, string APLKOCMDNJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class DDHLINBIHCH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type LHJMCBFEEJD;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x198FB00", Offset = "0x198ED00", VA = "0x18198FB00")]
	public DDHLINBIHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x85BEA0", Offset = "0x85B0A0", VA = "0x18085BEA0")]
	public DDHLINBIHCH(Type FCHLHHKNBCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class DLCKKAHJLEG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FD270", Offset = "0x6FC470", VA = "0x1806FD270")]
	public DLCKKAHJLEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class FAIKFLLGIEO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string DKBPCDOGANM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A8E550", Offset = "0x1A8D750", VA = "0x181A8E550")]
	public FAIKFLLGIEO(string DKBPCDOGANM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum NOMJLFGGPAB
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
public class NODNICKNPLO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x59BE220", Offset = "0x59BD420", VA = "0x1859BE220")]
	public NODNICKNPLO(NOMJLFGGPAB BGMCKNGNOJI = NOMJLFGGPAB.Self, bool NCKDALPIPAL = false, bool CPOGGJIGNBM = false, bool MFDDANDCOGD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FFLPCGIKIGC : NODNICKNPLO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x59BE220", Offset = "0x59BD420", VA = "0x1859BE220")]
	public FFLPCGIKIGC(NOMJLFGGPAB BGMCKNGNOJI = NOMJLFGGPAB.Self, bool NCKDALPIPAL = false, bool CPOGGJIGNBM = false, bool MFDDANDCOGD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class CLJLHLJDGDB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum LEFJOCOAJKH
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
	public readonly string HLJPALHCGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly LEFJOCOAJKH BGMCKNGNOJI;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x59BE190", Offset = "0x59BD390", VA = "0x1859BE190")]
	public CLJLHLJDGDB(string HLJPALHCGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x59BE1D0", Offset = "0x59BD3D0", VA = "0x1859BE1D0")]
	public CLJLHLJDGDB(string HLJPALHCGHK, LEFJOCOAJKH BGMCKNGNOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NAFDLBNKCNI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string BPGOPFFPIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool AMPDABNJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] GMBPOEMAEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool JADFHDGODOD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x59BE3B0", Offset = "0x59BD5B0", VA = "0x1859BE3B0")]
	public NAFDLBNKCNI(string BPGOPFFPIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x59BE270", Offset = "0x59BD470", VA = "0x1859BE270")]
	public NAFDLBNKCNI(string BPGOPFFPIHJ, object POEJMMDPANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x59BE350", Offset = "0x59BD550", VA = "0x1859BE350")]
	public NAFDLBNKCNI(string BPGOPFFPIHJ, params object[] GMBPOEMAEMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MOKIKIHNKFK : NAFDLBNKCNI
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x59BE270", Offset = "0x59BD470", VA = "0x1859BE270")]
	public MOKIKIHNKFK(string BPGOPFFPIHJ, object POEJMMDPANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x59BE350", Offset = "0x59BD550", VA = "0x1859BE350")]
	public MOKIKIHNKFK(string BPGOPFFPIHJ, params object[] GMBPOEMAEMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EAPCPFJFIFB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	public EAPCPFJFIFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BKECFMALJKH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	public BKECFMALJKH()
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
