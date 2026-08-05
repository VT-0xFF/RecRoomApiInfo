using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2AA27B0", Offset = "0x2AA1BB0", VA = "0x182AA27B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GLLLGEFDLPP<TMNode> : IEnumerator<JGDCCHDHIKG<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JGDCCHDHIKG<TMNode> IHIONJGONKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NHGMKBGLCBA<TMNode, JGDCCHDHIKG<TMNode>> PKMLIAPPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private JGDCCHDHIKG<TMNode> CLJLFFFEJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool LMGFIBMDBOF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JGDCCHDHIKG<TMNode> FEIHGLOFMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120", Slot = "4")]
		get
		{
			return default(JGDCCHDHIKG<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4F64F90", Offset = "0x4F64390", VA = "0x184F64F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4F65000", Offset = "0x4F64400", VA = "0x184F65000")]
	internal GLLLGEFDLPP(JGDCCHDHIKG<TMNode> FEMDGHMCLCC, [In] NHGMKBGLCBA<TMNode, JGDCCHDHIKG<TMNode>> BNMOMPBEPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4F64D50", Offset = "0x4F64150", VA = "0x184F64D50", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4F64F80", Offset = "0x4F64380", VA = "0x184F64F80", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HKCGLPCKICH<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly JGDCCHDHIKG<TMNode> AICPHNEGCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal NIGAJHMGNCH<TMNode> PGKDBEJCCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal NHGMKBGLCBA<TMNode, JGDCCHDHIKG<TMNode>> PKMLIAPPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal NHGMKBGLCBA<TMNode, JAEBKFJJIPK<JGDCCHDHIKG<TMNode>>> ELFGCAOENAN;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BA70", Offset = "0x2A9AE70", VA = "0x182A9BA70")]
	internal HKCGLPCKICH([In] NIGAJHMGNCH<TMNode> OMJPKHFINGB, [In] NHGMKBGLCBA<TMNode, JGDCCHDHIKG<TMNode>> BNMOMPBEPGM, [In] NHGMKBGLCBA<TMNode, JAEBKFJJIPK<JGDCCHDHIKG<TMNode>>> OPJOODAPIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FDFBB0", Offset = "0x4FDEFB0", VA = "0x184FDFBB0")]
	public static HKCGLPCKICH<TMNode> EJOLKNBPCJB()
	{
		return default(HKCGLPCKICH<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PDJAJMPPJIM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3EC5A50", Offset = "0x3EC4E50", VA = "0x183EC5A50")]
	public static MMBGPJKPKBI COFPFOKABJF<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC5DE0", Offset = "0x3EC51E0", VA = "0x183EC5DE0")]
	internal static OCOCKOJNJLP DPNFJOOEOJN<TMNode>([In] this JAEBKFJJIPK<JGDCCHDHIKG<TMNode>> DMFKPMONDPO) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3EC5740", Offset = "0x3EC4B40", VA = "0x183EC5740")]
	internal static JAEBKFJJIPK<JGDCCHDHIKG<TMNode>> AFHJLPDOGIE<TMNode>(this OCOCKOJNJLP DMFKPMONDPO) where TMNode : notnull
	{
		return default(JAEBKFJJIPK<JGDCCHDHIKG<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6760", Offset = "0x3EC5B60", VA = "0x183EC6760")]
	public static void ONLDIMNIKII<TMNode>(this HKCGLPCKICH<TMNode> DMFKPMONDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6390", Offset = "0x3EC5790", VA = "0x183EC6390")]
	public static bool KNLAECGHIJO<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> CLNGGGMIBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3EC68F0", Offset = "0x3EC5CF0", VA = "0x183EC68F0")]
	public static int PHOAOKLJOAM<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3EC5FB0", Offset = "0x3EC53B0", VA = "0x183EC5FB0")]
	public static JGDCCHDHIKG<TMNode?> EAFILCGDFAK<TMNode>(this HKCGLPCKICH<TMNode> DMFKPMONDPO)
	{
		return default(JGDCCHDHIKG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3EC62C0", Offset = "0x3EC56C0", VA = "0x183EC62C0")]
	public static JGDCCHDHIKG<TMNode?> IEJFKOHDLNB<TMNode>(this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> JIECBJMGMAC)
	{
		return default(JGDCCHDHIKG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3EC63A0", Offset = "0x3EC57A0", VA = "0x183EC63A0")]
	public static void LLLHPAIEGMF<TMNode>(this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3EC66D0", Offset = "0x3EC5AD0", VA = "0x183EC66D0")]
	public static bool NHNICGNNADL<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> CLNGGGMIBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B39E10", Offset = "0x3B39210", VA = "0x183B39E10")]
	public static JGDCCHDHIKG<TMNode?> IPKGCGIDGPI<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> CLNGGGMIBPI)
	{
		return default(JGDCCHDHIKG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6600", Offset = "0x3EC5A00", VA = "0x183EC6600")]
	public static JGDCCHDHIKG<TMNode?>? LOBCDNDGGFD<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> CLNGGGMIBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6190", Offset = "0x3EC5590", VA = "0x183EC6190")]
	public static void HAENONPNKJM<TMNode>(this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> CLNGGGMIBPI, JGDCCHDHIKG<TMNode> OHOHBLJAAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC60A0", Offset = "0x3EC54A0", VA = "0x183EC60A0")]
	public static APEGMNKPMEO<JGDCCHDHIKG<TMNode?>, JAEBKFJJIPK<JGDCCHDHIKG<TMNode?>>.OOCOCDEIPFL> EFJNIMPIMII<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> CLNGGGMIBPI)
	{
		return default(APEGMNKPMEO<JGDCCHDHIKG<TMNode>, JAEBKFJJIPK<JGDCCHDHIKG<TMNode>>.OOCOCDEIPFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static NIGAJHMGNCH<TMNode?> PEIGINGKCLB<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO)
	{
		return default(NIGAJHMGNCH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B39E30", Offset = "0x3B39230", VA = "0x183B39E30")]
	public static NIGAJHMGNCH<TMNode?>.IMOIFKFKLLG OJAPBOKMMBI<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO)
	{
		return default(NIGAJHMGNCH<TMNode>.IMOIFKFKLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3B3CA90", Offset = "0x3B3BE90", VA = "0x183B3CA90")]
	public static AFHHLMECHFE<JGDCCHDHIKG<TMNode?>, NIGAJHMGNCH<TMNode?>.IMOIFKFKLLG> MDPEOELNDBG<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO)
	{
		return default(AFHHLMECHFE<JGDCCHDHIKG<TMNode>, NIGAJHMGNCH<TMNode>.IMOIFKFKLLG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC59B0", Offset = "0x3EC4DB0", VA = "0x183EC59B0")]
	public static bool AGMLFOKIDMG<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> BLJBPFHLMML, JGDCCHDHIKG<TMNode> OPLHDHHEBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6100", Offset = "0x3EC5500", VA = "0x183EC6100")]
	public static AFHHLMECHFE<JGDCCHDHIKG<TMNode?>, GLLLGEFDLPP<TMNode?>> FDPNBLAFHKP<TMNode>([In] this HKCGLPCKICH<TMNode> DMFKPMONDPO, JGDCCHDHIKG<TMNode> BLJBPFHLMML)
	{
		return default(AFHHLMECHFE<JGDCCHDHIKG<TMNode>, GLLLGEFDLPP<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GJAEODEPFAM
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6510", Offset = "0x3CB5910", VA = "0x183CB6510")]
	public static HKCGLPCKICH<TMNode> DGFNGGGAAON<TMNode>(this MMBGPJKPKBI DMFKPMONDPO) where TMNode : notnull
	{
		return default(HKCGLPCKICH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA25C0", Offset = "0x2AA19C0", VA = "0x182AA25C0")]
	public static void LLLHPAIEGMF(this MMBGPJKPKBI DMFKPMONDPO, int CLNGGGMIBPI)
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
