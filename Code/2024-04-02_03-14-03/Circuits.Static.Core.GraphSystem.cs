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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E08370", Offset = "0x1E06F70", VA = "0x181E08370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GABAJJIIPIP<TMInput, TMOutput, TMNode> : IEnumerator<FEAGCKDELFK<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CBHAJFEMIDJ<TMInput, TMOutput, TMNode> DJKMMANIMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private COFFDHKDJOH<TMInput, TMOutput, TMNode> MOLEGLCNCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool ADKFLKLHINH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly FEAGCKDELFK<TMNode> DDCJPGOIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x37473B0", Offset = "0x3745FB0", VA = "0x1837473B0", Slot = "4")]
		get
		{
			return default(FEAGCKDELFK<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3747250", Offset = "0x3745E50", VA = "0x183747250", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37472E0", Offset = "0x3745EE0", VA = "0x1837472E0")]
	internal GABAJJIIPIP([In] CBHAJFEMIDJ<TMInput, TMOutput, TMNode> PLDMFNNDELG, [In] COFFDHKDJOH<TMInput, TMOutput, TMNode> COEGEPFMDMC, bool JBMFJDFCJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3747110", Offset = "0x3745D10", VA = "0x183747110", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37471D0", Offset = "0x3745DD0", VA = "0x1837471D0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3747090", Offset = "0x3745C90", VA = "0x183747090", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DGFOKNBAFFK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2669A60", Offset = "0x2668660", VA = "0x182669A60")]
	public static GABAJJIIPIP<TMInput, TMOutput, TMNode> CIGBOGDFGOD<TMInput, TMOutput, TMNode>([In] FJIMEGOFNCF<TMInput, TMOutput, TMNode> NKOEGJGNNAP, FEAGCKDELFK<TMNode> KHDECEICOFI)
	{
		return default(GABAJJIIPIP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct COFFDHKDJOH<TMInput, TMOutput, TMNode> : IEnumerator<FEAGCKDELFK<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC GHHOMOOHNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC POOMAJHAIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOBCDBMFECI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FEAGCKDELFK<TMInput> DDCJPGOIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4AE1010", Offset = "0x4ADFC10", VA = "0x184AE1010", Slot = "4")]
		get
		{
			return default(FEAGCKDELFK<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4AE0EE0", Offset = "0x4ADFAE0", VA = "0x184AE0EE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0F90", Offset = "0x4ADFB90", VA = "0x184AE0F90")]
	internal COFFDHKDJOH([In] BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC NCLPBEEBBPI, [In] BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC HEKIMMIHKMD, [In] PAGCFNKOKDN<TMInput, TMOutput, TMNode> CKNJLJOOOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0D10", Offset = "0x4ADF910", VA = "0x184AE0D10", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0E70", Offset = "0x4ADFA70", VA = "0x184AE0E70", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0CA0", Offset = "0x4ADF8A0", VA = "0x184AE0CA0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NDGPOHDCLKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x290B0F0", Offset = "0x2909CF0", VA = "0x18290B0F0")]
	public static COFFDHKDJOH<TMInput, TMOutput, TMNode> CIGBOGDFGOD<TMInput, TMOutput, TMNode>([In] FJIMEGOFNCF<TMInput, TMOutput, TMNode> NKOEGJGNNAP, FEAGCKDELFK<TMNode> KHDECEICOFI)
	{
		return default(COFFDHKDJOH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CBHAJFEMIDJ<TMInput, TMOutput, TMNode> : IEnumerator<FEAGCKDELFK<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC DCCIKCCLJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC LNMCDEDKHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FAAANDOAMAL<TMInput, TMOutput, TMNode> NNNIPOEKPBG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FEAGCKDELFK<TMOutput> DDCJPGOIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4AE1010", Offset = "0x4ADFC10", VA = "0x184AE1010", Slot = "4")]
		get
		{
			return default(FEAGCKDELFK<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4AE0EE0", Offset = "0x4ADFAE0", VA = "0x184AE0EE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0F90", Offset = "0x4ADFB90", VA = "0x184AE0F90")]
	internal CBHAJFEMIDJ([In] BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC BCIDPPFEEDO, [In] BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC KAMJHCDEOII, [In] FAAANDOAMAL<TMInput, TMOutput, TMNode> JGPGHBKGPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0D10", Offset = "0x4ADF910", VA = "0x184AE0D10", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0E70", Offset = "0x4ADFA70", VA = "0x184AE0E70", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0CA0", Offset = "0x4ADF8A0", VA = "0x184AE0CA0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JLPJNMEJAOD
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x283CEF0", Offset = "0x283BAF0", VA = "0x18283CEF0")]
	public static CBHAJFEMIDJ<TMInput, TMOutput, TMNode> CIGBOGDFGOD<TMInput, TMOutput, TMNode>([In] FJIMEGOFNCF<TMInput, TMOutput, TMNode> NKOEGJGNNAP, FEAGCKDELFK<TMNode> KHDECEICOFI)
	{
		return default(CBHAJFEMIDJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FJIMEGOFNCF<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FAAANDOAMAL<TMInput, TMOutput, TMNode> FEBAFDEMNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public PAGCFNKOKDN<TMInput, TMOutput, TMNode> FAHACGJJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public MCKLMEKGBAN<TMInput, TMOutput, TMNode> GHEPCHGMBDF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x368BDC0", Offset = "0x368A9C0", VA = "0x18368BDC0")]
	internal FJIMEGOFNCF([In] FAAANDOAMAL<TMInput, TMOutput, TMNode> JGPGHBKGPHA, [In] PAGCFNKOKDN<TMInput, TMOutput, TMNode> CKNJLJOOOGI, [In] MCKLMEKGBAN<TMInput, TMOutput, TMNode> LBIFHGIOCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x368BB10", Offset = "0x368A710", VA = "0x18368BB10")]
	public static FJIMEGOFNCF<TMInput?, TMOutput?, TMNode?> CIGBOGDFGOD()
	{
		return default(FJIMEGOFNCF<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HGPBIBGMGDL
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27F4F50", Offset = "0x27F3B50", VA = "0x1827F4F50")]
	public static GDNDALCGJKI? GAPNIKJAJOO<TMInput, TMOutput, TMNode>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27F4AE0", Offset = "0x27F36E0", VA = "0x1827F4AE0")]
	public static FJIMEGOFNCF<TMInput?, TMOutput?, TMNode?> DPCADENMEMJ<TMInput, TMOutput, TMNode>(this GDNDALCGJKI NOLNJDLEMAA)
	{
		return default(FJIMEGOFNCF<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x27F4890", Offset = "0x27F3490", VA = "0x1827F4890")]
	public static void AIMIAMDLHAG<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x27F5030", Offset = "0x27F3C30", VA = "0x1827F5030")]
	public static void GGMJGDAHIJB<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> PHOFIIAJDOI, FEAGCKDELFK<TMInput> JMADPKIJOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x27F5400", Offset = "0x27F4000", VA = "0x1827F5400")]
	public static void JDFLCFDFFJB<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> PHOFIIAJDOI, FEAGCKDELFK<TMInput> JMADPKIJOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x27F51A0", Offset = "0x27F3DA0", VA = "0x1827F51A0")]
	public static bool IKKJHKNBCLO<TMInput, TMOutput, TMNode>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> PHOFIIAJDOI, FEAGCKDELFK<TMInput> JMADPKIJOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27F5110", Offset = "0x27F3D10", VA = "0x1827F5110")]
	public static FEAGCKDELFK<TMNode?> HGNFDGBLGGB<TMNode, TMInput, TMOutput>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return default(FEAGCKDELFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x27F55F0", Offset = "0x27F41F0", VA = "0x1827F55F0")]
	public static void KLCCKGPNNKH<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> KHDECEICOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27F5700", Offset = "0x27F4300", VA = "0x1827F5700")]
	public static FEAGCKDELFK<TMInput?> LPMJCMPGPGI<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> KHDECEICOFI)
	{
		return default(FEAGCKDELFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27F4A70", Offset = "0x27F3670", VA = "0x1827F4A70")]
	public static FEAGCKDELFK<TMOutput?> DIJDBPDDPCA<TMOutput, TMInput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> KHDECEICOFI)
	{
		return default(FEAGCKDELFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27F5270", Offset = "0x27F3E70", VA = "0x1827F5270")]
	public static FEAGCKDELFK<TMInput?> ILCNNLHEFDD<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> KHDECEICOFI, int PMIDLPOCCEE)
	{
		return default(FEAGCKDELFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27F5090", Offset = "0x27F3C90", VA = "0x1827F5090")]
	public static FEAGCKDELFK<TMOutput?> HDMGOOCBMOM<TMOutput, TMInput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> KHDECEICOFI, int PMIDLPOCCEE)
	{
		return default(FEAGCKDELFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x27F49D0", Offset = "0x27F35D0", VA = "0x1827F49D0")]
	public static void DHPLMPBJCBA<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> KHDECEICOFI, int LCHOCFEDMIC, int GELKLKCFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27F5780", Offset = "0x27F4380", VA = "0x1827F5780")]
	public static void PDLBLIOFKDD<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> KHDECEICOFI, int LCHOCFEDMIC, int GELKLKCFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x27F4E60", Offset = "0x27F3A60", VA = "0x1827F4E60")]
	public static void FOGBANNAIMF<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> LCPPMLAJMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27F48F0", Offset = "0x27F34F0", VA = "0x1827F48F0")]
	public static void BMFLDJKJFGO<TMInput, TMOutput, TMNode>(this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JBAOPGNMBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static BMLDGKJOECD<TMInput?> CIFLJLGDBPD<TMInput, TMOutput, TMNode>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return default(BMLDGKJOECD<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x27F5770", Offset = "0x27F4370", VA = "0x1827F5770")]
	public static BMLDGKJOECD<TMOutput?> OGEPIILEOGA<TMOutput, TMInput, TMNode>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return default(BMLDGKJOECD<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x27F4E50", Offset = "0x27F3A50", VA = "0x1827F4E50")]
	public static BMLDGKJOECD<TMNode?> EILJMNPEIIM<TMNode, TMInput, TMOutput>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return default(BMLDGKJOECD<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27F4770", Offset = "0x27F3370", VA = "0x1827F4770")]
	public static COFFDHKDJOH<TMInput?, TMOutput?, TMNode?> ADHKIMAEJCK<TMInput, TMOutput, TMNode>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(COFFDHKDJOH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x27F4770", Offset = "0x27F3370", VA = "0x1827F4770")]
	public static CBHAJFEMIDJ<TMInput?, TMOutput?, TMNode?> KDPPKBCCOJL<TMInput, TMOutput, TMNode>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(CBHAJFEMIDJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x27F47E0", Offset = "0x27F33E0", VA = "0x1827F47E0")]
	public static GABAJJIIPIP<TMInput?, TMOutput?, TMNode?> AENLJEOIEJE<TMInput, TMOutput, TMNode>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(GABAJJIIPIP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x27F52F0", Offset = "0x27F3EF0", VA = "0x1827F52F0")]
	public static GFOEAPACOCG<FEAGCKDELFK<TMInput?>, COFFDHKDJOH<TMInput?, TMOutput?, TMNode?>> ILNEIONNMIJ<TMInput, TMOutput, TMNode>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(GFOEAPACOCG<FEAGCKDELFK<TMInput>, COFFDHKDJOH<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27F5460", Offset = "0x27F4060", VA = "0x1827F5460")]
	public static GFOEAPACOCG<FEAGCKDELFK<TMNode?>, GABAJJIIPIP<TMInput?, TMOutput?, TMNode?>> JNEJMOKHGLE<TMNode, TMInput, TMOutput>([In] this FJIMEGOFNCF<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(GFOEAPACOCG<FEAGCKDELFK<TMNode>, GABAJJIIPIP<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct FAAANDOAMAL<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal BMLDGKJOECD<TMInput> KAHMBIECDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal GKANMKFBELI<TMInput, FEAGCKDELFK<TMNode>> LPLGECKFPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal GKANMKFBELI<TMInput, BKKACOADMGL<FEAGCKDELFK<TMOutput>>> NOBCDBMFECI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3678290", Offset = "0x3676E90", VA = "0x183678290")]
	internal FAAANDOAMAL([In] BMLDGKJOECD<TMInput> ILNBNOOMFJE, [In] GKANMKFBELI<TMInput, FEAGCKDELFK<TMNode>> LBIFHGIOCCH, [In] GKANMKFBELI<TMInput, BKKACOADMGL<FEAGCKDELFK<TMOutput>>> CKNJLJOOOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x36780D0", Offset = "0x3676CD0", VA = "0x1836780D0")]
	internal static FAAANDOAMAL<TMInput, TMOutput, TMNode> CIGBOGDFGOD()
	{
		return default(FAAANDOAMAL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class AHOEJJFEEAC
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CCD0", Offset = "0x2D9B8D0", VA = "0x182D9CCD0")]
	internal static BCBJDCAIEEF GAPNIKJAJOO<TMInput, TMOutput, TMNode>([In] this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C7C0", Offset = "0x2D9B3C0", VA = "0x182D9C7C0")]
	internal static FAAANDOAMAL<TMInput, TMOutput, TMNode> DPCADENMEMJ<TMInput, TMOutput, TMNode>(this BCBJDCAIEEF NOLNJDLEMAA)
	{
		return default(FAAANDOAMAL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D2E0", Offset = "0x2D9BEE0", VA = "0x182D9D2E0")]
	private static IGHFECKNIID MMAIAFPFKGP<TMOutput>([In] this BKKACOADMGL<FEAGCKDELFK<TMOutput>> NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D060", Offset = "0x2D9BC60", VA = "0x182D9D060")]
	private static BKKACOADMGL<FEAGCKDELFK<TMOutput>> HBAGINOJCGJ<TMOutput>(this IGHFECKNIID NOLNJDLEMAA)
	{
		return default(BKKACOADMGL<FEAGCKDELFK<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2939060", Offset = "0x2937C60", VA = "0x182939060")]
	internal static void AIMIAMDLHAG<TMInput, TMOutput, TMNode>(this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2939280", Offset = "0x2937E80", VA = "0x182939280")]
	internal static FEAGCKDELFK<TMInput> DJPOJPAABMH<TMInput, TMOutput, TMNode>(this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> FJKJNIMGBPD)
	{
		return default(FEAGCKDELFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29391F0", Offset = "0x2937DF0", VA = "0x1829391F0")]
	internal static void CAHHFGLKLDH<TMInput, TMOutput, TMNode>(this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> JPCJHDLLDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2597BC0", Offset = "0x25967C0", VA = "0x182597BC0")]
	public static bool IIPEAMCMPFA<TMInput, TMOutput, TMNode>([In] this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> JPCJHDLLDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x22F59F0", Offset = "0x22F45F0", VA = "0x1822F59F0")]
	public static int CGIMAFACPON<TMInput, TMOutput, TMNode>([In] this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2939C50", Offset = "0x2938850", VA = "0x182939C50")]
	public static FEAGCKDELFK<TMNode> JOHLEBOKFDG<TMNode, TMInput, TMOutput>([In] this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> JPCJHDLLDBJ)
	{
		return default(FEAGCKDELFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2939EF0", Offset = "0x2938AF0", VA = "0x182939EF0")]
	public static int KEHGPBDLBIN<TMInput, TMOutput, TMNode>([In] this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> JPCJHDLLDBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2939C00", Offset = "0x2938800", VA = "0x182939C00")]
	public static FEAGCKDELFK<TMOutput> OICKKHHMKJG<TMOutput, TMInput, TMNode>([In] this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> JPCJHDLLDBJ, int PMIDLPOCCEE)
	{
		return default(FEAGCKDELFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2939830", Offset = "0x2938430", VA = "0x182939830")]
	internal static void GFIODPCENMN<TMInput, TMOutput, TMNode>(this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> JPCJHDLLDBJ, FEAGCKDELFK<TMOutput> JBAOPGNMBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2939830", Offset = "0x2938430", VA = "0x182939830")]
	internal static void NLMOBLKMBKB<TMInput, TMOutput, TMNode>(this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> JPCJHDLLDBJ, FEAGCKDELFK<TMOutput> JBAOPGNMBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2854930", Offset = "0x2853530", VA = "0x182854930")]
	public static BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC JANOFMLMPMO<TMOutput, TMInput, TMNode>([In] this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> JPCJHDLLDBJ)
	{
		return default(BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2854930", Offset = "0x2853530", VA = "0x182854930")]
	public static ACBEDEPHPNH<FEAGCKDELFK<TMOutput>, BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC> CCGILOLJIDO<TMOutput, TMInput, TMNode>([In] this FAAANDOAMAL<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMInput> JPCJHDLLDBJ)
	{
		return default(ACBEDEPHPNH<FEAGCKDELFK<TMOutput>, BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct MCKLMEKGBAN<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal BMLDGKJOECD<TMNode> KAHMBIECDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal GKANMKFBELI<TMNode, BKKACOADMGL<FEAGCKDELFK<TMInput>>> NNNIPOEKPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal GKANMKFBELI<TMNode, BKKACOADMGL<FEAGCKDELFK<TMOutput>>> NOBCDBMFECI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3678290", Offset = "0x3676E90", VA = "0x183678290")]
	internal MCKLMEKGBAN([In] BMLDGKJOECD<TMNode> ILNBNOOMFJE, [In] GKANMKFBELI<TMNode, BKKACOADMGL<FEAGCKDELFK<TMInput>>> JGPGHBKGPHA, [In] GKANMKFBELI<TMNode, BKKACOADMGL<FEAGCKDELFK<TMOutput>>> CKNJLJOOOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36780D0", Offset = "0x3676CD0", VA = "0x1836780D0")]
	internal static MCKLMEKGBAN<TMInput, TMOutput, TMNode> CIGBOGDFGOD()
	{
		return default(MCKLMEKGBAN<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PGAKMDFEDIB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x294C650", Offset = "0x294B250", VA = "0x18294C650")]
	internal static CGMEPGAKGFL GAPNIKJAJOO<TMInput, TMOutput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x294C100", Offset = "0x294AD00", VA = "0x18294C100")]
	internal static MCKLMEKGBAN<TMInput, TMOutput, TMNode> DPCADENMEMJ<TMInput, TMOutput, TMNode>(this CGMEPGAKGFL NOLNJDLEMAA)
	{
		return default(MCKLMEKGBAN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x294CF60", Offset = "0x294BB60", VA = "0x18294CF60")]
	private static JLCMGIKMNGN JFJBLJGGDHD<TMInput>([In] this BKKACOADMGL<FEAGCKDELFK<TMInput>> NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x294BD30", Offset = "0x294A930", VA = "0x18294BD30")]
	private static BKKACOADMGL<FEAGCKDELFK<TMInput>> BKBBKJDLPFB<TMInput>(this JLCMGIKMNGN NOLNJDLEMAA)
	{
		return default(BKKACOADMGL<FEAGCKDELFK<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x294CCE0", Offset = "0x294B8E0", VA = "0x18294CCE0")]
	private static MJJFKAEJOCE ICGKNLDCOOB<TMOutput>([In] this BKKACOADMGL<FEAGCKDELFK<TMOutput>> NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x294CA10", Offset = "0x294B610", VA = "0x18294CA10")]
	private static BKKACOADMGL<FEAGCKDELFK<TMOutput>> GFKKIIFEMNM<TMOutput>(this MJJFKAEJOCE NOLNJDLEMAA)
	{
		return default(BKKACOADMGL<FEAGCKDELFK<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x294BA70", Offset = "0x294A670", VA = "0x18294BA70")]
	internal static void AIMIAMDLHAG<TMInput, TMOutput, TMNode>(this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x294C070", Offset = "0x294AC70", VA = "0x18294C070")]
	internal static FEAGCKDELFK<TMNode> DJPOJPAABMH<TMNode, TMInput, TMOutput>(this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, [In] BKKACOADMGL<FEAGCKDELFK<TMInput>> JGPGHBKGPHA, [In] BKKACOADMGL<FEAGCKDELFK<TMOutput>> CKNJLJOOOGI)
	{
		return default(FEAGCKDELFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x294BFB0", Offset = "0x294ABB0", VA = "0x18294BFB0")]
	internal static void CAHHFGLKLDH<TMInput, TMOutput, TMNode>(this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2597BC0", Offset = "0x25967C0", VA = "0x182597BC0")]
	public static bool IIPEAMCMPFA<TMInput, TMOutput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x22F59F0", Offset = "0x22F45F0", VA = "0x1822F59F0")]
	public static int CGIMAFACPON<TMInput, TMOutput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x294D180", Offset = "0x294BD80", VA = "0x18294D180")]
	public static int MLAADHJLLMJ<TMInput, TMOutput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2939EF0", Offset = "0x2938AF0", VA = "0x182939EF0")]
	public static int KEHGPBDLBIN<TMInput, TMOutput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x294CF10", Offset = "0x294BB10", VA = "0x18294CF10")]
	public static FEAGCKDELFK<TMInput> ILMOMHKKJGE<TMInput, TMOutput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ, int PMIDLPOCCEE)
	{
		return default(FEAGCKDELFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2939C00", Offset = "0x2938800", VA = "0x182939C00")]
	public static FEAGCKDELFK<TMOutput> OICKKHHMKJG<TMOutput, TMInput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ, int PMIDLPOCCEE)
	{
		return default(FEAGCKDELFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x294C610", Offset = "0x294B210", VA = "0x18294C610")]
	internal static void KHHFELAPLAI<TMInput, TMOutput, TMNode>(this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ, FEAGCKDELFK<TMInput> LCPPMLAJMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2939830", Offset = "0x2938430", VA = "0x182939830")]
	internal static void GFIODPCENMN<TMInput, TMOutput, TMNode>(this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ, FEAGCKDELFK<TMOutput> JBAOPGNMBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x294D130", Offset = "0x294BD30", VA = "0x18294D130")]
	internal static void KDJKOPMELPL<TMInput, TMOutput, TMNode>(this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ, int PMIDLPOCCEE, FEAGCKDELFK<TMInput> LCPPMLAJMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x294CC90", Offset = "0x294B890", VA = "0x18294CC90")]
	internal static void HHJADHHPBAF<TMInput, TMOutput, TMNode>(this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ, int PMIDLPOCCEE, FEAGCKDELFK<TMOutput> JBAOPGNMBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x294C610", Offset = "0x294B210", VA = "0x18294C610")]
	internal static void EAPLBIDNMIN<TMInput, TMOutput, TMNode>(this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ, FEAGCKDELFK<TMInput> LCPPMLAJMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2939830", Offset = "0x2938430", VA = "0x182939830")]
	internal static void NLMOBLKMBKB<TMInput, TMOutput, TMNode>(this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ, FEAGCKDELFK<TMOutput> JBAOPGNMBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x294CEB0", Offset = "0x294BAB0", VA = "0x18294CEB0")]
	public static BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC PBPKEGLMOJK<TMInput, TMOutput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2854930", Offset = "0x2853530", VA = "0x182854930")]
	public static BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC JANOFMLMPMO<TMOutput, TMInput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x294CEB0", Offset = "0x294BAB0", VA = "0x18294CEB0")]
	public static ACBEDEPHPNH<FEAGCKDELFK<TMInput>, BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC> IFDFEKGALND<TMInput, TMOutput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(ACBEDEPHPNH<FEAGCKDELFK<TMInput>, BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2854930", Offset = "0x2853530", VA = "0x182854930")]
	public static ACBEDEPHPNH<FEAGCKDELFK<TMOutput>, BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC> CCGILOLJIDO<TMOutput, TMInput, TMNode>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> JPCJHDLLDBJ)
	{
		return default(ACBEDEPHPNH<FEAGCKDELFK<TMOutput>, BKKACOADMGL<FEAGCKDELFK<TMOutput>>.DKBMHDCPCBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x27C53D0", Offset = "0x27C3FD0", VA = "0x1827C53D0")]
	public static GFOEAPACOCG<FEAGCKDELFK<TMNode>, BMLDGKJOECD<TMNode>.HLFILADJEAJ> DCLMLFJBIHL<TMNode, TMInput, TMOutput>([In] this MCKLMEKGBAN<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return default(GFOEAPACOCG<FEAGCKDELFK<TMNode>, BMLDGKJOECD<TMNode>.HLFILADJEAJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PAGCFNKOKDN<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal BMLDGKJOECD<TMOutput> KAHMBIECDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal GKANMKFBELI<TMOutput, FEAGCKDELFK<TMNode>> LPLGECKFPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal GKANMKFBELI<TMOutput, BKKACOADMGL<FEAGCKDELFK<TMInput>>> NNNIPOEKPBG;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3678290", Offset = "0x3676E90", VA = "0x183678290")]
	internal PAGCFNKOKDN([In] BMLDGKJOECD<TMOutput> ILNBNOOMFJE, [In] GKANMKFBELI<TMOutput, FEAGCKDELFK<TMNode>> LBIFHGIOCCH, [In] GKANMKFBELI<TMOutput, BKKACOADMGL<FEAGCKDELFK<TMInput>>> JGPGHBKGPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x36780D0", Offset = "0x3676CD0", VA = "0x1836780D0")]
	internal static PAGCFNKOKDN<TMInput, TMOutput, TMNode> CIGBOGDFGOD()
	{
		return default(PAGCFNKOKDN<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OIGMMJDKECE
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2939870", Offset = "0x2938470", VA = "0x182939870")]
	internal static BOMOPABEHNK GAPNIKJAJOO<TMInput, TMOutput, TMNode>([In] this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2939320", Offset = "0x2937F20", VA = "0x182939320")]
	internal static PAGCFNKOKDN<TMInput, TMOutput, TMNode> DPCADENMEMJ<TMInput, TMOutput, TMNode>(this BOMOPABEHNK NOLNJDLEMAA)
	{
		return default(PAGCFNKOKDN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2938E90", Offset = "0x2937A90", VA = "0x182938E90")]
	private static FENIGMDPGFB AFPDJKGPDAD<TMInput>([In] this BKKACOADMGL<FEAGCKDELFK<TMInput>> NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2939C70", Offset = "0x2938870", VA = "0x182939C70")]
	private static BKKACOADMGL<FEAGCKDELFK<TMInput>> KKLJBBKLJHP<TMInput>(this FENIGMDPGFB NOLNJDLEMAA)
	{
		return default(BKKACOADMGL<FEAGCKDELFK<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2939060", Offset = "0x2937C60", VA = "0x182939060")]
	internal static void AIMIAMDLHAG<TMInput, TMOutput, TMNode>(this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2939280", Offset = "0x2937E80", VA = "0x182939280")]
	internal static FEAGCKDELFK<TMOutput> DJPOJPAABMH<TMOutput, TMInput, TMNode>(this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMNode> FJKJNIMGBPD)
	{
		return default(FEAGCKDELFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x29391F0", Offset = "0x2937DF0", VA = "0x1829391F0")]
	internal static void CAHHFGLKLDH<TMInput, TMOutput, TMNode>(this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JPCJHDLLDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2597BC0", Offset = "0x25967C0", VA = "0x182597BC0")]
	public static bool IIPEAMCMPFA<TMInput, TMOutput, TMNode>([In] this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JPCJHDLLDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x22F59F0", Offset = "0x22F45F0", VA = "0x1822F59F0")]
	public static int CGIMAFACPON<TMInput, TMOutput, TMNode>([In] this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2939C50", Offset = "0x2938850", VA = "0x182939C50")]
	public static FEAGCKDELFK<TMNode> JOHLEBOKFDG<TMNode, TMInput, TMOutput>([In] this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JPCJHDLLDBJ)
	{
		return default(FEAGCKDELFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2939EF0", Offset = "0x2938AF0", VA = "0x182939EF0")]
	public static int MLAADHJLLMJ<TMInput, TMOutput, TMNode>([In] this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JPCJHDLLDBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2939C00", Offset = "0x2938800", VA = "0x182939C00")]
	public static FEAGCKDELFK<TMInput> ILMOMHKKJGE<TMInput, TMOutput, TMNode>([In] this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JPCJHDLLDBJ, int PMIDLPOCCEE)
	{
		return default(FEAGCKDELFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2939830", Offset = "0x2938430", VA = "0x182939830")]
	internal static void KHHFELAPLAI<TMInput, TMOutput, TMNode>(this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JPCJHDLLDBJ, FEAGCKDELFK<TMInput> LCPPMLAJMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2939830", Offset = "0x2938430", VA = "0x182939830")]
	internal static void EAPLBIDNMIN<TMInput, TMOutput, TMNode>(this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JPCJHDLLDBJ, FEAGCKDELFK<TMInput> LCPPMLAJMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2854930", Offset = "0x2853530", VA = "0x182854930")]
	public static BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC PBPKEGLMOJK<TMInput, TMOutput, TMNode>([In] this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JPCJHDLLDBJ)
	{
		return default(BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2854930", Offset = "0x2853530", VA = "0x182854930")]
	public static ACBEDEPHPNH<FEAGCKDELFK<TMInput>, BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC> IFDFEKGALND<TMInput, TMOutput, TMNode>([In] this PAGCFNKOKDN<TMInput, TMOutput, TMNode> NOLNJDLEMAA, FEAGCKDELFK<TMOutput> JPCJHDLLDBJ)
	{
		return default(ACBEDEPHPNH<FEAGCKDELFK<TMInput>, BKKACOADMGL<FEAGCKDELFK<TMInput>>.DKBMHDCPCBC>);
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
