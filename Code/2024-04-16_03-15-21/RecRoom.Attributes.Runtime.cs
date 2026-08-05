using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HFONEOLONAL : EHAGBMAJKDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string AOAMJONMOPL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FE69B0", Offset = "0x5FE5BB0", VA = "0x185FE69B0")]
	public HFONEOLONAL(string GOMGIJFGMEM, string AOAMJONMOPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class MABJJECOJBG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string GCJOACNDCED;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BD0", Offset = "0x7C2DD0", VA = "0x1807C3BD0")]
	public MABJJECOJBG(string GCJOACNDCED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DGCAKKBAIEP
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PCEENEOFAOO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6820", Offset = "0x5FE5A20", VA = "0x185FE6820")]
	public PCEENEOFAOO(DGCAKKBAIEP MJMAEGDPBNJ = DGCAKKBAIEP.Self, bool IHIEFNNPEFH = false, bool KHKMHCIABIB = false, bool KIFKCGAIJAG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OAOGLDILMOC : PCEENEOFAOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type PJKBBLHEMNI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6AD0", Offset = "0x5FE5CD0", VA = "0x185FE6AD0")]
	public OAOGLDILMOC(Type FBPOANNCBOI, DGCAKKBAIEP MJMAEGDPBNJ = DGCAKKBAIEP.Self, bool IHIEFNNPEFH = false, bool KHKMHCIABIB = false, bool KIFKCGAIJAG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CPBKDNLKGAP : PCEENEOFAOO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6820", Offset = "0x5FE5A20", VA = "0x185FE6820")]
	public CPBKDNLKGAP(DGCAKKBAIEP MJMAEGDPBNJ = DGCAKKBAIEP.Self, bool IHIEFNNPEFH = false, bool KHKMHCIABIB = false, bool KIFKCGAIJAG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class DEDMDCDGMCK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum CDENLFNDNNM
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
	public readonly string HHOFNBFBJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly CDENLFNDNNM MJMAEGDPBNJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6870", Offset = "0x5FE5A70", VA = "0x185FE6870")]
	public DEDMDCDGMCK(string HHOFNBFBJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x55B8DD0", Offset = "0x55B7FD0", VA = "0x1855B8DD0")]
	public DEDMDCDGMCK(string HHOFNBFBJPK, CDENLFNDNNM MJMAEGDPBNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EHAGBMAJKDP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string GOMGIJFGMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool DNNGIPKIKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] PJEDKADFGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool INELNOHHGHN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FE68B0", Offset = "0x5FE5AB0", VA = "0x185FE68B0")]
	public EHAGBMAJKDP(string GOMGIJFGMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6740", Offset = "0x5FE5940", VA = "0x185FE6740")]
	public EHAGBMAJKDP(string GOMGIJFGMEM, object GOAOIFHIPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE66E0", Offset = "0x5FE58E0", VA = "0x185FE66E0")]
	public EHAGBMAJKDP(string GOMGIJFGMEM, params object[] PJEDKADFGPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CICNBMIIFFH : EHAGBMAJKDP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6740", Offset = "0x5FE5940", VA = "0x185FE6740")]
	public CICNBMIIFFH(string GOMGIJFGMEM, object GOAOIFHIPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE66E0", Offset = "0x5FE58E0", VA = "0x185FE66E0")]
	public CICNBMIIFFH(string GOMGIJFGMEM, params object[] PJEDKADFGPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CEAPCOOJFJA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool OOMECAAEHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string KMJJKMNGKFD;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE6690", Offset = "0x5FE5890", VA = "0x185FE6690")]
	public CEAPCOOJFJA(string DCBLHEFDBKN, bool DEDIMANFKMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GLEFBAFKCAE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F40", Offset = "0x7C3140", VA = "0x1807C3F40")]
	public GLEFBAFKCAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ABENGEDDIKJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F40", Offset = "0x7C3140", VA = "0x1807C3F40")]
	public ABENGEDDIKJ()
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
