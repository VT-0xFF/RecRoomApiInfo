using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EHIFKDGEPJO : HCKNCDEPKNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PFILAIACPBC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x52165F0", Offset = "0x52155F0", VA = "0x1852165F0")]
	public EHIFKDGEPJO(string MOHOONFIACB, string PFILAIACPBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class LHBJOLBEKNP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Type HKKEBFHHCPP;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x388DBB0", Offset = "0x388CBB0", VA = "0x18388DBB0")]
	public LHBJOLBEKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7D0", Offset = "0x6CC7D0", VA = "0x1806CD7D0")]
	public LHBJOLBEKNP(Type JNACCHJICCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class HDJEDJHFNFC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x58C480", Offset = "0x58B480", VA = "0x18058C480")]
	public HDJEDJHFNFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class BCOLIMKPPOL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string DCKGMDBKFGH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D19020", Offset = "0x3D18020", VA = "0x183D19020")]
	public BCOLIMKPPOL(string DCKGMDBKFGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KJNDCKKOGLL
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
public class KDJOALBJPIO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5216710", Offset = "0x5215710", VA = "0x185216710")]
	public KDJOALBJPIO(KJNDCKKOGLL GOKHKCCNGMD = KJNDCKKOGLL.Self, bool AEHNHGKILME = false, bool HBDHEJINDMB = false, bool NDBIKNOBDKK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FKLMCFLCGED : KDJOALBJPIO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5216710", Offset = "0x5215710", VA = "0x185216710")]
	public FKLMCFLCGED(KJNDCKKOGLL GOKHKCCNGMD = KJNDCKKOGLL.Self, bool AEHNHGKILME = false, bool HBDHEJINDMB = false, bool NDBIKNOBDKK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class BPBPLMCOHBO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MBKFIBPLMAK
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
	public readonly string HEPMGPKNIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly MBKFIBPLMAK GOKHKCCNGMD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5216560", Offset = "0x5215560", VA = "0x185216560")]
	public BPBPLMCOHBO(string HEPMGPKNIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x52165A0", Offset = "0x52155A0", VA = "0x1852165A0")]
	public BPBPLMCOHBO(string HEPMGPKNIMK, MBKFIBPLMAK GOKHKCCNGMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HCKNCDEPKNE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string MOHOONFIACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool GFGMELDMKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] OGFBCDFBOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool JFAGHBBAELE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x52168A0", Offset = "0x52158A0", VA = "0x1852168A0")]
	public HCKNCDEPKNE(string MOHOONFIACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x52167C0", Offset = "0x52157C0", VA = "0x1852167C0")]
	public HCKNCDEPKNE(string MOHOONFIACB, object CDGOGCKHJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5216760", Offset = "0x5215760", VA = "0x185216760")]
	public HCKNCDEPKNE(string MOHOONFIACB, params object[] OGFBCDFBOBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JEPOJJJLEII : HCKNCDEPKNE
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x52167C0", Offset = "0x52157C0", VA = "0x1852167C0")]
	public JEPOJJJLEII(string MOHOONFIACB, object CDGOGCKHJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5216760", Offset = "0x5215760", VA = "0x185216760")]
	public JEPOJJJLEII(string MOHOONFIACB, params object[] OGFBCDFBOBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OKNMILANPKC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F03E0", Offset = "0x6EF3E0", VA = "0x1806F03E0")]
	public OKNMILANPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JGBLNAGDHNC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F03E0", Offset = "0x6EF3E0", VA = "0x1806F03E0")]
	public JGBLNAGDHNC()
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
