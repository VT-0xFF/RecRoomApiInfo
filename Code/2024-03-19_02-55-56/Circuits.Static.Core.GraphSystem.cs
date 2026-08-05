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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DE6F80", Offset = "0x1DE5F80", VA = "0x181DE6F80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BFMCEEFEIGP<TMInput, TMOutput, TMNode> : IEnumerator<ADHLEPAMMHK<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HPNBCGFELFD<TMInput, TMOutput, TMNode> IKMLJKBNLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private LMICFGJMHJH<TMInput, TMOutput, TMNode> MPMBENGIBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool DPADCOIGMMC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly ADHLEPAMMHK<TMNode> FKHNLELEDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x47AC8D0", Offset = "0x47AB8D0", VA = "0x1847AC8D0", Slot = "4")]
		get
		{
			return default(ADHLEPAMMHK<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x47AC770", Offset = "0x47AB770", VA = "0x1847AC770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x47AC800", Offset = "0x47AB800", VA = "0x1847AC800")]
	internal BFMCEEFEIGP([In] HPNBCGFELFD<TMInput, TMOutput, TMNode> JKFFMLHKMJA, [In] LMICFGJMHJH<TMInput, TMOutput, TMNode> ECIBEFIDKNE, bool IJIJCGADCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x47AC630", Offset = "0x47AB630", VA = "0x1847AC630", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x47AC6F0", Offset = "0x47AB6F0", VA = "0x1847AC6F0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x47AC5B0", Offset = "0x47AB5B0", VA = "0x1847AC5B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OLJKKPIPDAA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x291D4B0", Offset = "0x291C4B0", VA = "0x18291D4B0")]
	public static BFMCEEFEIGP<TMInput, TMOutput, TMNode> NAJBLLJFKKI<TMInput, TMOutput, TMNode>([In] HINPENBIFAD<TMInput, TMOutput, TMNode> BCCOIGLMEJE, ADHLEPAMMHK<TMNode> GIGGNCPPKPC)
	{
		return default(BFMCEEFEIGP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LMICFGJMHJH<TMInput, TMOutput, TMNode> : IEnumerator<ADHLEPAMMHK<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB DMFJPJNIGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB DIFBJCJCINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly MJJGOOFPFOM<TMInput, TMOutput, TMNode> LFHNIDKMPBL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ADHLEPAMMHK<TMInput> FKHNLELEDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3806B50", Offset = "0x3805B50", VA = "0x183806B50", Slot = "4")]
		get
		{
			return default(ADHLEPAMMHK<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3806A20", Offset = "0x3805A20", VA = "0x183806A20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3806AD0", Offset = "0x3805AD0", VA = "0x183806AD0")]
	internal LMICFGJMHJH([In] KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB CLPCMIMOHAI, [In] KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB DEEBGBLBOMO, [In] MJJGOOFPFOM<TMInput, TMOutput, TMNode> APEGEIBEGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3806850", Offset = "0x3805850", VA = "0x183806850", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x38069B0", Offset = "0x38059B0", VA = "0x1838069B0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x38067E0", Offset = "0x38057E0", VA = "0x1838067E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BFKOOEFEKOC
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x25833B0", Offset = "0x25823B0", VA = "0x1825833B0")]
	public static LMICFGJMHJH<TMInput, TMOutput, TMNode> NAJBLLJFKKI<TMInput, TMOutput, TMNode>([In] HINPENBIFAD<TMInput, TMOutput, TMNode> BCCOIGLMEJE, ADHLEPAMMHK<TMNode> GIGGNCPPKPC)
	{
		return default(LMICFGJMHJH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HPNBCGFELFD<TMInput, TMOutput, TMNode> : IEnumerator<ADHLEPAMMHK<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB BGAMMOJEHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB OJGOHCDIDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly ABOPMNPEBPC<TMInput, TMOutput, TMNode> LPBNIDPOIMP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ADHLEPAMMHK<TMOutput> FKHNLELEDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3806B50", Offset = "0x3805B50", VA = "0x183806B50", Slot = "4")]
		get
		{
			return default(ADHLEPAMMHK<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3806A20", Offset = "0x3805A20", VA = "0x183806A20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3806AD0", Offset = "0x3805AD0", VA = "0x183806AD0")]
	internal HPNBCGFELFD([In] KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB HFIENDGEPBI, [In] KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB DEAJEPPDMGG, [In] ABOPMNPEBPC<TMInput, TMOutput, TMNode> LKOHEIMNPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3806850", Offset = "0x3805850", VA = "0x183806850", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x38069B0", Offset = "0x38059B0", VA = "0x1838069B0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x38067E0", Offset = "0x38057E0", VA = "0x1838067E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OHBEOFNEAJA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2914420", Offset = "0x2913420", VA = "0x182914420")]
	public static HPNBCGFELFD<TMInput, TMOutput, TMNode> NAJBLLJFKKI<TMInput, TMOutput, TMNode>([In] HINPENBIFAD<TMInput, TMOutput, TMNode> BCCOIGLMEJE, ADHLEPAMMHK<TMNode> GIGGNCPPKPC)
	{
		return default(HPNBCGFELFD<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HINPENBIFAD<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public ABOPMNPEBPC<TMInput, TMOutput, TMNode> KLIKLEAGNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public MJJGOOFPFOM<TMInput, TMOutput, TMNode> DGFAKBDHFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public GDALJJDCHBP<TMInput, TMOutput, TMNode> PGKFGAFACFD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37D8800", Offset = "0x37D7800", VA = "0x1837D8800")]
	internal HINPENBIFAD([In] ABOPMNPEBPC<TMInput, TMOutput, TMNode> LKOHEIMNPAA, [In] MJJGOOFPFOM<TMInput, TMOutput, TMNode> APEGEIBEGIF, [In] GDALJJDCHBP<TMInput, TMOutput, TMNode> GIEJLAIGHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37D8550", Offset = "0x37D7550", VA = "0x1837D8550")]
	public static HINPENBIFAD<TMInput?, TMOutput?, TMNode?> NAJBLLJFKKI()
	{
		return default(HINPENBIFAD<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IKCANCLDEJN
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27E3380", Offset = "0x27E2380", VA = "0x1827E3380")]
	public static OKIIEAFFLJG? PAKOMNGHIKD<TMInput, TMOutput, TMNode>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27E2EE0", Offset = "0x27E1EE0", VA = "0x1827E2EE0")]
	public static HINPENBIFAD<TMInput?, TMOutput?, TMNode?> MPIEPNPHGIA<TMInput, TMOutput, TMNode>(this OKIIEAFFLJG AOFEPADBPDL)
	{
		return default(HINPENBIFAD<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x27E2600", Offset = "0x27E1600", VA = "0x1827E2600")]
	public static void CCMBCIBACJB<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x27E2AC0", Offset = "0x27E1AC0", VA = "0x1827E2AC0")]
	public static void JDMLOGHMONG<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> PNJKINCPMGN, ADHLEPAMMHK<TMInput> OHABIOIIJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x27E2970", Offset = "0x27E1970", VA = "0x1827E2970")]
	public static void GDDEIKHBPIK<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> PNJKINCPMGN, ADHLEPAMMHK<TMInput> OHABIOIIJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x27E3570", Offset = "0x27E2570", VA = "0x1827E3570")]
	public static bool PMGMILJPOFO<TMInput, TMOutput, TMNode>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> PNJKINCPMGN, ADHLEPAMMHK<TMInput> OHABIOIIJCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27E3250", Offset = "0x27E2250", VA = "0x1827E3250")]
	public static ADHLEPAMMHK<TMNode?> OEIPJHPJFAM<TMNode, TMInput, TMOutput>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return default(ADHLEPAMMHK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x27E2DD0", Offset = "0x27E1DD0", VA = "0x1827E2DD0")]
	public static void MJGPBKPPOCL<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> GIGGNCPPKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27E2800", Offset = "0x27E1800", VA = "0x1827E2800")]
	public static ADHLEPAMMHK<TMInput?> DMGBJONMLIM<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> GIGGNCPPKPC)
	{
		return default(ADHLEPAMMHK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27E3460", Offset = "0x27E2460", VA = "0x1827E3460")]
	public static ADHLEPAMMHK<TMOutput?> PDBLILMEAIN<TMOutput, TMInput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> GIGGNCPPKPC)
	{
		return default(ADHLEPAMMHK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27E2870", Offset = "0x27E1870", VA = "0x1827E2870")]
	public static ADHLEPAMMHK<TMInput?> EENACGOBBLG<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> GIGGNCPPKPC, int GCDIELAOHNA)
	{
		return default(ADHLEPAMMHK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27E28F0", Offset = "0x27E18F0", VA = "0x1827E28F0")]
	public static ADHLEPAMMHK<TMOutput?> FPBLJJMPNHB<TMOutput, TMInput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> GIGGNCPPKPC, int GCDIELAOHNA)
	{
		return default(ADHLEPAMMHK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x27E32E0", Offset = "0x27E22E0", VA = "0x1827E32E0")]
	public static void OJBGNBEFGHA<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> GIGGNCPPKPC, int IDDGIINEBJJ, int LMKGBGINGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27E34D0", Offset = "0x27E24D0", VA = "0x1827E34D0")]
	public static void PKIONJDKMAO<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> GIGGNCPPKPC, int IDDGIINEBJJ, int LMKGBGINGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x27E2BD0", Offset = "0x27E1BD0", VA = "0x1827E2BD0")]
	public static void KBMBAODOIEA<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> AOGEFPCFIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27E29D0", Offset = "0x27E19D0", VA = "0x1827E29D0")]
	public static void GECLLEDALOD<TMInput, TMOutput, TMNode>(this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> EEMDIPHNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static AEANHFGOKOH<TMInput?> IPOEFKDFLPF<TMInput, TMOutput, TMNode>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return default(AEANHFGOKOH<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x27E27F0", Offset = "0x27E17F0", VA = "0x1827E27F0")]
	public static AEANHFGOKOH<TMOutput?> DBLNJJLEMEH<TMOutput, TMInput, TMNode>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return default(AEANHFGOKOH<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x27E2AB0", Offset = "0x27E1AB0", VA = "0x1827E2AB0")]
	public static AEANHFGOKOH<TMNode?> GFMBFEPHJLB<TMNode, TMInput, TMOutput>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return default(AEANHFGOKOH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27E2590", Offset = "0x27E1590", VA = "0x1827E2590")]
	public static LMICFGJMHJH<TMInput?, TMOutput?, TMNode?> BPCGLMKIPFF<TMInput, TMOutput, TMNode>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(LMICFGJMHJH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x27E2590", Offset = "0x27E1590", VA = "0x1827E2590")]
	public static HPNBCGFELFD<TMInput?, TMOutput?, TMNode?> AOLIBALAPHB<TMInput, TMOutput, TMNode>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(HPNBCGFELFD<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x27E2B20", Offset = "0x27E1B20", VA = "0x1827E2B20")]
	public static BFMCEEFEIGP<TMInput?, TMOutput?, TMNode?> KBDCBJJLNOC<TMInput, TMOutput, TMNode>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(BFMCEEFEIGP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x27E2CC0", Offset = "0x27E1CC0", VA = "0x1827E2CC0")]
	public static ELJDHNAOCGK<ADHLEPAMMHK<TMInput?>, LMICFGJMHJH<TMInput?, TMOutput?, TMNode?>> KICAFCDGJIJ<TMInput, TMOutput, TMNode>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(ELJDHNAOCGK<ADHLEPAMMHK<TMInput>, LMICFGJMHJH<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27E2660", Offset = "0x27E1660", VA = "0x1827E2660")]
	public static ELJDHNAOCGK<ADHLEPAMMHK<TMNode?>, BFMCEEFEIGP<TMInput?, TMOutput?, TMNode?>> CNIJIDGJJKA<TMNode, TMInput, TMOutput>([In] this HINPENBIFAD<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(ELJDHNAOCGK<ADHLEPAMMHK<TMNode>, BFMCEEFEIGP<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ABOPMNPEBPC<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal AEANHFGOKOH<TMInput> NPOOBIKKGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal JABBAFJPLEG<TMInput, ADHLEPAMMHK<TMNode>> ILHHNJBOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal JABBAFJPLEG<TMInput, KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>> LFHNIDKMPBL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3719470", Offset = "0x3718470", VA = "0x183719470")]
	internal ABOPMNPEBPC([In] AEANHFGOKOH<TMInput> FGEJGNCCEMD, [In] JABBAFJPLEG<TMInput, ADHLEPAMMHK<TMNode>> GIEJLAIGHGP, [In] JABBAFJPLEG<TMInput, KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>> APEGEIBEGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37192B0", Offset = "0x37182B0", VA = "0x1837192B0")]
	internal static ABOPMNPEBPC<TMInput, TMOutput, TMNode> NAJBLLJFKKI()
	{
		return default(ABOPMNPEBPC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LFABBHDKHON
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x283B420", Offset = "0x283A420", VA = "0x18283B420")]
	internal static KPGNDAEGKHB PAKOMNGHIKD<TMInput, TMOutput, TMNode>([In] this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x283AF10", Offset = "0x2839F10", VA = "0x18283AF10")]
	internal static ABOPMNPEBPC<TMInput, TMOutput, TMNode> MPIEPNPHGIA<TMInput, TMOutput, TMNode>(this KPGNDAEGKHB AOFEPADBPDL)
	{
		return default(ABOPMNPEBPC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x283AAC0", Offset = "0x2839AC0", VA = "0x18283AAC0")]
	private static MBEBMDGHHNG GBIBFGFPINA<TMOutput>([In] this KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>> AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x283AC90", Offset = "0x2839C90", VA = "0x18283AC90")]
	private static KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>> ICMJFOCEHOG<TMOutput>(this MBEBMDGHHNG AOFEPADBPDL)
	{
		return default(KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x27FF710", Offset = "0x27FE710", VA = "0x1827FF710")]
	internal static void CCMBCIBACJB<TMInput, TMOutput, TMNode>(this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27FFBA0", Offset = "0x27FEBA0", VA = "0x1827FFBA0")]
	internal static ADHLEPAMMHK<TMInput> JADBDKFNNII<TMInput, TMOutput, TMNode>(this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> PENNBKHEEFF)
	{
		return default(ADHLEPAMMHK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2800700", Offset = "0x27FF700", VA = "0x182800700")]
	internal static void PJJDMGCOONE<TMInput, TMOutput, TMNode>(this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> IJKMNFNHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2585C10", Offset = "0x2584C10", VA = "0x182585C10")]
	public static bool MIDMNCADJEG<TMInput, TMOutput, TMNode>([In] this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> IJKMNFNHLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2583700", Offset = "0x2582700", VA = "0x182583700")]
	public static int PJCPCPBBBBN<TMInput, TMOutput, TMNode>([In] this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27FF6F0", Offset = "0x27FE6F0", VA = "0x1827FF6F0")]
	public static ADHLEPAMMHK<TMNode> BDGIDJGBFDN<TMNode, TMInput, TMOutput>([In] this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> IJKMNFNHLGO)
	{
		return default(ADHLEPAMMHK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27FFB60", Offset = "0x27FEB60", VA = "0x1827FFB60")]
	public static int HANOJPEAEMN<TMInput, TMOutput, TMNode>([In] this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> IJKMNFNHLGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x27FFC40", Offset = "0x27FEC40", VA = "0x1827FFC40")]
	public static ADHLEPAMMHK<TMOutput> NKLJBGJLMGP<TMOutput, TMInput, TMNode>([In] this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> IJKMNFNHLGO, int GCDIELAOHNA)
	{
		return default(ADHLEPAMMHK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27FFB20", Offset = "0x27FEB20", VA = "0x1827FFB20")]
	internal static void OJBINNCLGHN<TMInput, TMOutput, TMNode>(this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> IJKMNFNHLGO, ADHLEPAMMHK<TMOutput> EEMDIPHNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27FFB20", Offset = "0x27FEB20", VA = "0x1827FFB20")]
	internal static void LKNOCPPILLD<TMInput, TMOutput, TMNode>(this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> IJKMNFNHLGO, ADHLEPAMMHK<TMOutput> EEMDIPHNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2669C40", Offset = "0x2668C40", VA = "0x182669C40")]
	public static KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB FKKMCAAOPLE<TMOutput, TMInput, TMNode>([In] this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> IJKMNFNHLGO)
	{
		return default(KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2669C40", Offset = "0x2668C40", VA = "0x182669C40")]
	public static OBEHHIDNBFN<ADHLEPAMMHK<TMOutput>, KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB> GDODJDENJMH<TMOutput, TMInput, TMNode>([In] this ABOPMNPEBPC<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMInput> IJKMNFNHLGO)
	{
		return default(OBEHHIDNBFN<ADHLEPAMMHK<TMOutput>, KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GDALJJDCHBP<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal AEANHFGOKOH<TMNode> NPOOBIKKGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal JABBAFJPLEG<TMNode, KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>> LPBNIDPOIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal JABBAFJPLEG<TMNode, KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>> LFHNIDKMPBL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3719470", Offset = "0x3718470", VA = "0x183719470")]
	internal GDALJJDCHBP([In] AEANHFGOKOH<TMNode> FGEJGNCCEMD, [In] JABBAFJPLEG<TMNode, KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>> LKOHEIMNPAA, [In] JABBAFJPLEG<TMNode, KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>> APEGEIBEGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37192B0", Offset = "0x37182B0", VA = "0x1837192B0")]
	internal static GDALJJDCHBP<TMInput, TMOutput, TMNode> NAJBLLJFKKI()
	{
		return default(GDALJJDCHBP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PHCPMJKFPMO
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x292F6C0", Offset = "0x292E6C0", VA = "0x18292F6C0")]
	internal static BGNECAJOJFD PAKOMNGHIKD<TMInput, TMOutput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x292EF30", Offset = "0x292DF30", VA = "0x18292EF30")]
	internal static GDALJJDCHBP<TMInput, TMOutput, TMNode> MPIEPNPHGIA<TMInput, TMOutput, TMNode>(this BGNECAJOJFD AOFEPADBPDL)
	{
		return default(GDALJJDCHBP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x292E9D0", Offset = "0x292D9D0", VA = "0x18292E9D0")]
	private static JKGAPJAJADO DDAEEMGBBKB<TMInput>([In] this KNEGFGHLPEP<ADHLEPAMMHK<TMInput>> AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x292E3F0", Offset = "0x292D3F0", VA = "0x18292E3F0")]
	private static KNEGFGHLPEP<ADHLEPAMMHK<TMInput>> AHBNMFMCDIF<TMInput>(this JKGAPJAJADO AOFEPADBPDL)
	{
		return default(KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x292EBA0", Offset = "0x292DBA0", VA = "0x18292EBA0")]
	private static DGLEJDDNFLC DGPFKINKDMD<TMOutput>([In] this KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>> AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x292F440", Offset = "0x292E440", VA = "0x18292F440")]
	private static KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>> NHLAMJIEHDM<TMOutput>(this DGLEJDDNFLC AOFEPADBPDL)
	{
		return default(KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x292E6C0", Offset = "0x292D6C0", VA = "0x18292E6C0")]
	internal static void CCMBCIBACJB<TMInput, TMOutput, TMNode>(this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x292EE50", Offset = "0x292DE50", VA = "0x18292EE50")]
	internal static ADHLEPAMMHK<TMNode> JADBDKFNNII<TMNode, TMInput, TMOutput>(this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, [In] KNEGFGHLPEP<ADHLEPAMMHK<TMInput>> LKOHEIMNPAA, [In] KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>> APEGEIBEGIF)
	{
		return default(ADHLEPAMMHK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x292FA80", Offset = "0x292EA80", VA = "0x18292FA80")]
	internal static void PJJDMGCOONE<TMInput, TMOutput, TMNode>(this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2585C10", Offset = "0x2584C10", VA = "0x182585C10")]
	public static bool MIDMNCADJEG<TMInput, TMOutput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2583700", Offset = "0x2582700", VA = "0x182583700")]
	public static int PJCPCPBBBBN<TMInput, TMOutput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x292EE10", Offset = "0x292DE10", VA = "0x18292EE10")]
	public static int ICJCMHNCKJE<TMInput, TMOutput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27FFB60", Offset = "0x27FEB60", VA = "0x1827FFB60")]
	public static int HANOJPEAEMN<TMInput, TMOutput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x292EEE0", Offset = "0x292DEE0", VA = "0x18292EEE0")]
	public static ADHLEPAMMHK<TMInput> LGDKGEDLBFM<TMInput, TMOutput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO, int GCDIELAOHNA)
	{
		return default(ADHLEPAMMHK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x27FFC40", Offset = "0x27FEC40", VA = "0x1827FFC40")]
	public static ADHLEPAMMHK<TMOutput> NKLJBGJLMGP<TMOutput, TMInput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO, int GCDIELAOHNA)
	{
		return default(ADHLEPAMMHK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x292EDD0", Offset = "0x292DDD0", VA = "0x18292EDD0")]
	internal static void IAMNBHIPMEB<TMInput, TMOutput, TMNode>(this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO, ADHLEPAMMHK<TMInput> AOGEFPCFIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27FFB20", Offset = "0x27FEB20", VA = "0x1827FFB20")]
	internal static void OJBINNCLGHN<TMInput, TMOutput, TMNode>(this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO, ADHLEPAMMHK<TMOutput> EEMDIPHNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x292E670", Offset = "0x292D670", VA = "0x18292E670")]
	internal static void CAGBCDAOLAH<TMInput, TMOutput, TMNode>(this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO, int GCDIELAOHNA, ADHLEPAMMHK<TMInput> AOGEFPCFIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x292E980", Offset = "0x292D980", VA = "0x18292E980")]
	internal static void CFNPKPHEADK<TMInput, TMOutput, TMNode>(this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO, int GCDIELAOHNA, ADHLEPAMMHK<TMOutput> EEMDIPHNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x292EDD0", Offset = "0x292DDD0", VA = "0x18292EDD0")]
	internal static void KCHGJMHFBIO<TMInput, TMOutput, TMNode>(this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO, ADHLEPAMMHK<TMInput> AOGEFPCFIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27FFB20", Offset = "0x27FEB20", VA = "0x1827FFB20")]
	internal static void LKNOCPPILLD<TMInput, TMOutput, TMNode>(this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO, ADHLEPAMMHK<TMOutput> EEMDIPHNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x292ED70", Offset = "0x292DD70", VA = "0x18292ED70")]
	public static KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB FANHCNEPICC<TMInput, TMOutput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2669C40", Offset = "0x2668C40", VA = "0x182669C40")]
	public static KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB FKKMCAAOPLE<TMOutput, TMInput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x292ED70", Offset = "0x292DD70", VA = "0x18292ED70")]
	public static OBEHHIDNBFN<ADHLEPAMMHK<TMInput>, KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB> JLJDFFFLALI<TMInput, TMOutput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(OBEHHIDNBFN<ADHLEPAMMHK<TMInput>, KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2669C40", Offset = "0x2668C40", VA = "0x182669C40")]
	public static OBEHHIDNBFN<ADHLEPAMMHK<TMOutput>, KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB> GDODJDENJMH<TMOutput, TMInput, TMNode>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> IJKMNFNHLGO)
	{
		return default(OBEHHIDNBFN<ADHLEPAMMHK<TMOutput>, KNEGFGHLPEP<ADHLEPAMMHK<TMOutput>>.DHCNFPLCOIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x260A5B0", Offset = "0x26095B0", VA = "0x18260A5B0")]
	public static ELJDHNAOCGK<ADHLEPAMMHK<TMNode>, AEANHFGOKOH<TMNode>.IOKOLHBFGPP> OOGGFECHLNF<TMNode, TMInput, TMOutput>([In] this GDALJJDCHBP<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return default(ELJDHNAOCGK<ADHLEPAMMHK<TMNode>, AEANHFGOKOH<TMNode>.IOKOLHBFGPP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MJJGOOFPFOM<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal AEANHFGOKOH<TMOutput> NPOOBIKKGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal JABBAFJPLEG<TMOutput, ADHLEPAMMHK<TMNode>> ILHHNJBOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal JABBAFJPLEG<TMOutput, KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>> LPBNIDPOIMP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3719470", Offset = "0x3718470", VA = "0x183719470")]
	internal MJJGOOFPFOM([In] AEANHFGOKOH<TMOutput> FGEJGNCCEMD, [In] JABBAFJPLEG<TMOutput, ADHLEPAMMHK<TMNode>> GIEJLAIGHGP, [In] JABBAFJPLEG<TMOutput, KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>> LKOHEIMNPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37192B0", Offset = "0x37182B0", VA = "0x1837192B0")]
	internal static MJJGOOFPFOM<TMInput, TMOutput, TMNode> NAJBLLJFKKI()
	{
		return default(MJJGOOFPFOM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JCCPBHNFIIC
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2800370", Offset = "0x27FF370", VA = "0x182800370")]
	internal static GFOLICLPNKK PAKOMNGHIKD<TMInput, TMOutput, TMNode>([In] this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x27FFE60", Offset = "0x27FEE60", VA = "0x1827FFE60")]
	internal static MJJGOOFPFOM<TMInput, TMOutput, TMNode> MPIEPNPHGIA<TMInput, TMOutput, TMNode>(this GFOLICLPNKK AOFEPADBPDL)
	{
		return default(MJJGOOFPFOM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x27FFC90", Offset = "0x27FEC90", VA = "0x1827FFC90")]
	private static LNDPPOBHJLE MIPFLLGCPDI<TMInput>([In] this KNEGFGHLPEP<ADHLEPAMMHK<TMInput>> AOFEPADBPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x27FF8A0", Offset = "0x27FE8A0", VA = "0x1827FF8A0")]
	private static KNEGFGHLPEP<ADHLEPAMMHK<TMInput>> GCBLFOGIMIC<TMInput>(this LNDPPOBHJLE AOFEPADBPDL)
	{
		return default(KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x27FF710", Offset = "0x27FE710", VA = "0x1827FF710")]
	internal static void CCMBCIBACJB<TMInput, TMOutput, TMNode>(this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x27FFBA0", Offset = "0x27FEBA0", VA = "0x1827FFBA0")]
	internal static ADHLEPAMMHK<TMOutput> JADBDKFNNII<TMOutput, TMInput, TMNode>(this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMNode> PENNBKHEEFF)
	{
		return default(ADHLEPAMMHK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2800700", Offset = "0x27FF700", VA = "0x182800700")]
	internal static void PJJDMGCOONE<TMInput, TMOutput, TMNode>(this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> IJKMNFNHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2585C10", Offset = "0x2584C10", VA = "0x182585C10")]
	public static bool MIDMNCADJEG<TMInput, TMOutput, TMNode>([In] this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> IJKMNFNHLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2583700", Offset = "0x2582700", VA = "0x182583700")]
	public static int PJCPCPBBBBN<TMInput, TMOutput, TMNode>([In] this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x27FF6F0", Offset = "0x27FE6F0", VA = "0x1827FF6F0")]
	public static ADHLEPAMMHK<TMNode> BDGIDJGBFDN<TMNode, TMInput, TMOutput>([In] this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> IJKMNFNHLGO)
	{
		return default(ADHLEPAMMHK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x27FFB60", Offset = "0x27FEB60", VA = "0x1827FFB60")]
	public static int ICJCMHNCKJE<TMInput, TMOutput, TMNode>([In] this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> IJKMNFNHLGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x27FFC40", Offset = "0x27FEC40", VA = "0x1827FFC40")]
	public static ADHLEPAMMHK<TMInput> LGDKGEDLBFM<TMInput, TMOutput, TMNode>([In] this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> IJKMNFNHLGO, int GCDIELAOHNA)
	{
		return default(ADHLEPAMMHK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x27FFB20", Offset = "0x27FEB20", VA = "0x1827FFB20")]
	internal static void IAMNBHIPMEB<TMInput, TMOutput, TMNode>(this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> IJKMNFNHLGO, ADHLEPAMMHK<TMInput> AOGEFPCFIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x27FFB20", Offset = "0x27FEB20", VA = "0x1827FFB20")]
	internal static void KCHGJMHFBIO<TMInput, TMOutput, TMNode>(this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> IJKMNFNHLGO, ADHLEPAMMHK<TMInput> AOGEFPCFIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2669C40", Offset = "0x2668C40", VA = "0x182669C40")]
	public static KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB FANHCNEPICC<TMInput, TMOutput, TMNode>([In] this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> IJKMNFNHLGO)
	{
		return default(KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2669C40", Offset = "0x2668C40", VA = "0x182669C40")]
	public static OBEHHIDNBFN<ADHLEPAMMHK<TMInput>, KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB> JLJDFFFLALI<TMInput, TMOutput, TMNode>([In] this MJJGOOFPFOM<TMInput, TMOutput, TMNode> AOFEPADBPDL, ADHLEPAMMHK<TMOutput> IJKMNFNHLGO)
	{
		return default(OBEHHIDNBFN<ADHLEPAMMHK<TMInput>, KNEGFGHLPEP<ADHLEPAMMHK<TMInput>>.DHCNFPLCOIB>);
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
