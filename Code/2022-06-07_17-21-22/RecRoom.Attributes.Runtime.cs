using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NOFFKABLBJL : GFEJMLFCKHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GKFDBAKNMFB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xC733C0", Offset = "0xC71BC0", VA = "0x180C733C0")]
	public NOFFKABLBJL(string NMMHCHIKHLN, string GKFDBAKNMFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class DMAFMHKEJAL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type GNIAILCIIJG;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xC730D0", Offset = "0xC718D0", VA = "0x180C730D0")]
	public DMAFMHKEJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3F0", Offset = "0x6AABF0", VA = "0x1806AC3F0")]
	public DMAFMHKEJAL(Type KMOAKHELKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class DPIFODIBJDD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x561480", Offset = "0x55FC80", VA = "0x180561480")]
	public DPIFODIBJDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class EDACBPDJJPG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string AFJNPPDELLL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC73100", Offset = "0xC71900", VA = "0x180C73100")]
	public EDACBPDJJPG(string AFJNPPDELLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum ELHMLMEGENM
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
public class PAOKLKEFIEK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xC73370", Offset = "0xC71B70", VA = "0x180C73370")]
	public PAOKLKEFIEK(ELHMLMEGENM DMBEFJIHONB = ELHMLMEGENM.Self, bool DPPFPGAJJHO = false, bool ONJLLCPAICC = false, bool HEGDKEJFKIP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MPAANNPJLMO : PAOKLKEFIEK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xC73370", Offset = "0xC71B70", VA = "0x180C73370")]
	public MPAANNPJLMO(ELHMLMEGENM DMBEFJIHONB = ELHMLMEGENM.Self, bool DPPFPGAJJHO = false, bool ONJLLCPAICC = false, bool HEGDKEJFKIP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class DBJFOALCNID : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum DHGAIJAEKEL
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
	public readonly string ECPIHGCHCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly DHGAIJAEKEL DMBEFJIHONB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xC73090", Offset = "0xC71890", VA = "0x180C73090")]
	public DBJFOALCNID(string ECPIHGCHCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xC73040", Offset = "0xC71840", VA = "0x180C73040")]
	public DBJFOALCNID(string ECPIHGCHCFJ, DHGAIJAEKEL DMBEFJIHONB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GFEJMLFCKHB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string NMMHCHIKHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool DOMLNKHPPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] PONNCGPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool HEEECKKHAPF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xC73130", Offset = "0xC71930", VA = "0x180C73130")]
	public GFEJMLFCKHB(string NMMHCHIKHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xC73230", Offset = "0xC71A30", VA = "0x180C73230")]
	public GFEJMLFCKHB(string NMMHCHIKHLN, object OOOOBBIKCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xC73310", Offset = "0xC71B10", VA = "0x180C73310")]
	public GFEJMLFCKHB(string NMMHCHIKHLN, params object[] PONNCGPHDDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LAGOFCNOAOA : GFEJMLFCKHB
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xC73230", Offset = "0xC71A30", VA = "0x180C73230")]
	public LAGOFCNOAOA(string NMMHCHIKHLN, object OOOOBBIKCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xC73310", Offset = "0xC71B10", VA = "0x180C73310")]
	public LAGOFCNOAOA(string NMMHCHIKHLN, params object[] PONNCGPHDDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EKDDLPGALMJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6CF000", Offset = "0x6CD800", VA = "0x1806CF000")]
	public EKDDLPGALMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EIHJBFIJLEO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6CF000", Offset = "0x6CD800", VA = "0x1806CF000")]
	public EIHJBFIJLEO()
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
