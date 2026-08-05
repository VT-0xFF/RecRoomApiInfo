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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D1AA60", Offset = "0x1D19860", VA = "0x181D1AA60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DLDFHLHIECL<TMInput, TMOutput, TMNode> : IEnumerator<APKOFFGFFFK<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LILDPOGIDCA<TMInput, TMOutput, TMNode> CCDBBJLPMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private JMOIGKCGAKM<TMInput, TMOutput, TMNode> BIHGDOKAJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool NHPMBJIGDLP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly APKOFFGFFFK<TMNode> GCDIDLPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4F65520", Offset = "0x4F64320", VA = "0x184F65520", Slot = "4")]
		get
		{
			return default(APKOFFGFFFK<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4F653C0", Offset = "0x4F641C0", VA = "0x184F653C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4F65450", Offset = "0x4F64250", VA = "0x184F65450")]
	internal DLDFHLHIECL([In] LILDPOGIDCA<TMInput, TMOutput, TMNode> FOOECOEGAEL, [In] JMOIGKCGAKM<TMInput, TMOutput, TMNode> BMNMPNBDPBP, bool EFDMINIHMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4F65280", Offset = "0x4F64080", VA = "0x184F65280", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4F65340", Offset = "0x4F64140", VA = "0x184F65340", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F65200", Offset = "0x4F64000", VA = "0x184F65200", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JOCHEAPNIOD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26067B0", Offset = "0x26055B0", VA = "0x1826067B0")]
	public static DLDFHLHIECL<TMInput, TMOutput, TMNode> DCPHPAHCOGO<TMInput, TMOutput, TMNode>([In] JPHAIIFFGJI<TMInput, TMOutput, TMNode> HMNPECNEONL, APKOFFGFFFK<TMNode> BLDAGMAKLNM)
	{
		return default(DLDFHLHIECL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct JMOIGKCGAKM<TMInput, TMOutput, TMNode> : IEnumerator<APKOFFGFFFK<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF PCLONHLDADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF IBCMEPALLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly FFOJLNIEOKG<TMInput, TMOutput, TMNode> GHLOOBDFPLM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public APKOFFGFFFK<TMInput> GCDIDLPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3A416F0", Offset = "0x3A404F0", VA = "0x183A416F0", Slot = "4")]
		get
		{
			return default(APKOFFGFFFK<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A415C0", Offset = "0x3A403C0", VA = "0x183A415C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A41670", Offset = "0x3A40470", VA = "0x183A41670")]
	internal JMOIGKCGAKM([In] HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF BELHAGAKNJL, [In] HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF IPFNCCFHNLO, [In] FFOJLNIEOKG<TMInput, TMOutput, TMNode> JFFCHHIAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A413F0", Offset = "0x3A401F0", VA = "0x183A413F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A41550", Offset = "0x3A40350", VA = "0x183A41550", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A41380", Offset = "0x3A40180", VA = "0x183A41380", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KKMCLEOGIHE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2622F50", Offset = "0x2621D50", VA = "0x182622F50")]
	public static JMOIGKCGAKM<TMInput, TMOutput, TMNode> DCPHPAHCOGO<TMInput, TMOutput, TMNode>([In] JPHAIIFFGJI<TMInput, TMOutput, TMNode> HMNPECNEONL, APKOFFGFFFK<TMNode> BLDAGMAKLNM)
	{
		return default(JMOIGKCGAKM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LILDPOGIDCA<TMInput, TMOutput, TMNode> : IEnumerator<APKOFFGFFFK<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF ALHDHJMPGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF IBFPMBLMJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly JGFIFCEHNED<TMInput, TMOutput, TMNode> HMFKFFJPGEI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public APKOFFGFFFK<TMOutput> GCDIDLPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3A416F0", Offset = "0x3A404F0", VA = "0x183A416F0", Slot = "4")]
		get
		{
			return default(APKOFFGFFFK<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A415C0", Offset = "0x3A403C0", VA = "0x183A415C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A41670", Offset = "0x3A40470", VA = "0x183A41670")]
	internal LILDPOGIDCA([In] HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF HIHNELPGHFA, [In] HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF MJNOOFJBIOP, [In] JGFIFCEHNED<TMInput, TMOutput, TMNode> MBIIODBGLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A413F0", Offset = "0x3A401F0", VA = "0x183A413F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A41550", Offset = "0x3A40350", VA = "0x183A41550", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A41380", Offset = "0x3A40180", VA = "0x183A41380", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EBFELMEJDKG
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2488A10", Offset = "0x2487810", VA = "0x182488A10")]
	public static LILDPOGIDCA<TMInput, TMOutput, TMNode> DCPHPAHCOGO<TMInput, TMOutput, TMNode>([In] JPHAIIFFGJI<TMInput, TMOutput, TMNode> HMNPECNEONL, APKOFFGFFFK<TMNode> BLDAGMAKLNM)
	{
		return default(LILDPOGIDCA<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JPHAIIFFGJI<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public JGFIFCEHNED<TMInput, TMOutput, TMNode> ILDECIMHKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public FFOJLNIEOKG<TMInput, TMOutput, TMNode> GBLNIHEAHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public OFBAOPBPGDL<TMInput, TMOutput, TMNode> MOLNLPMGKPP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B9D0", Offset = "0x3A4A7D0", VA = "0x183A4B9D0")]
	internal JPHAIIFFGJI([In] JGFIFCEHNED<TMInput, TMOutput, TMNode> MBIIODBGLDK, [In] FFOJLNIEOKG<TMInput, TMOutput, TMNode> JFFCHHIAPNM, [In] OFBAOPBPGDL<TMInput, TMOutput, TMNode> LAHHJHJPIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B720", Offset = "0x3A4A520", VA = "0x183A4B720")]
	public static JPHAIIFFGJI<TMInput?, TMOutput?, TMNode?> DCPHPAHCOGO()
	{
		return default(JPHAIIFFGJI<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HKDHCKCONCB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x25CFFA0", Offset = "0x25CEDA0", VA = "0x1825CFFA0")]
	public static FPCFPFLOPLA? OKNECDBNGHE<TMInput, TMOutput, TMNode>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x25CF570", Offset = "0x25CE370", VA = "0x1825CF570")]
	public static JPHAIIFFGJI<TMInput?, TMOutput?, TMNode?> HONCKFFEJNK<TMInput, TMOutput, TMNode>(this FPCFPFLOPLA OJFDNDCDDBK)
	{
		return default(JPHAIIFFGJI<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x25CF510", Offset = "0x25CE310", VA = "0x1825CF510")]
	public static void HLIABIFOACE<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x25CEFD0", Offset = "0x25CDDD0", VA = "0x1825CEFD0")]
	public static void ABOEILBOBLH<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> BGOLADFANPA, APKOFFGFFFK<TMInput> LLBADNAHLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x25CFF40", Offset = "0x25CED40", VA = "0x1825CFF40")]
	public static void NMGKJODOBAH<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> BGOLADFANPA, APKOFFGFFFK<TMInput> LLBADNAHLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25CFE70", Offset = "0x25CEC70", VA = "0x1825CFE70")]
	public static bool MJCONOJLMAO<TMInput, TMOutput, TMNode>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> BGOLADFANPA, APKOFFGFFFK<TMInput> LLBADNAHLPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25CF480", Offset = "0x25CE280", VA = "0x1825CF480")]
	public static APKOFFGFFFK<TMNode?> HAGCMICHLGO<TMNode, TMInput, TMOutput>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return default(APKOFFGFFFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25CFC70", Offset = "0x25CEA70", VA = "0x1825CFC70")]
	public static void LIHGDFCONJI<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> BLDAGMAKLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25CF140", Offset = "0x25CDF40", VA = "0x1825CF140")]
	public static APKOFFGFFFK<TMInput?> APHIAGENKPA<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> BLDAGMAKLNM)
	{
		return default(APKOFFGFFFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25CF410", Offset = "0x25CE210", VA = "0x1825CF410")]
	public static APKOFFGFFFK<TMOutput?> GLEAFHDOACE<TMOutput, TMInput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> BLDAGMAKLNM)
	{
		return default(APKOFFGFFFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x25CF1C0", Offset = "0x25CDFC0", VA = "0x1825CF1C0")]
	public static APKOFFGFFFK<TMInput?> CIGDIJLAIKL<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> BLDAGMAKLNM, int HPLKFBKKIBG)
	{
		return default(APKOFFGFFFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25CF2B0", Offset = "0x25CE0B0", VA = "0x1825CF2B0")]
	public static APKOFFGFFFK<TMOutput?> EOBJGKPFOEL<TMOutput, TMInput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> BLDAGMAKLNM, int HPLKFBKKIBG)
	{
		return default(APKOFFGFFFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x25CF8E0", Offset = "0x25CE6E0", VA = "0x1825CF8E0")]
	public static void IEBKCACJFED<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> BLDAGMAKLNM, int ICFNDPBIFON, int HJEOPNHOBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25CFBD0", Offset = "0x25CE9D0", VA = "0x1825CFBD0")]
	public static void KJDDJMCBOFB<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> BLDAGMAKLNM, int ICFNDPBIFON, int HJEOPNHOBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25CFD80", Offset = "0x25CEB80", VA = "0x1825CFD80")]
	public static void MAICLPFCDCC<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> GBHKLJOHIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x25CF330", Offset = "0x25CE130", VA = "0x1825CF330")]
	public static void FMBJLGEOGOO<TMInput, TMOutput, TMNode>(this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> PKHIGJLAHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static ALJMBBINLHG<TMInput?> HPKEOPJFBNF<TMInput, TMOutput, TMNode>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return default(ALJMBBINLHG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x25CF1B0", Offset = "0x25CDFB0", VA = "0x1825CF1B0")]
	public static ALJMBBINLHG<TMOutput?> BKIDNBLJDBM<TMOutput, TMInput, TMNode>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return default(ALJMBBINLHG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x25CF980", Offset = "0x25CE780", VA = "0x1825CF980")]
	public static ALJMBBINLHG<TMNode?> JJCIKAACABO<TMNode, TMInput, TMOutput>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return default(ALJMBBINLHG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25CF240", Offset = "0x25CE040", VA = "0x1825CF240")]
	public static JMOIGKCGAKM<TMInput?, TMOutput?, TMNode?> GGDHMOHIMAK<TMInput, TMOutput, TMNode>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(JMOIGKCGAKM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x25CF240", Offset = "0x25CE040", VA = "0x1825CF240")]
	public static LILDPOGIDCA<TMInput?, TMOutput?, TMNode?> EIMCOBEKHLB<TMInput, TMOutput, TMNode>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(LILDPOGIDCA<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x25CF990", Offset = "0x25CE790", VA = "0x1825CF990")]
	public static DLDFHLHIECL<TMInput?, TMOutput?, TMNode?> KGMCLEGDBIN<TMInput, TMOutput, TMNode>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(DLDFHLHIECL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x25CF030", Offset = "0x25CDE30", VA = "0x1825CF030")]
	public static PGCEIHEBNHC<APKOFFGFFFK<TMInput?>, JMOIGKCGAKM<TMInput?, TMOutput?, TMNode?>> ALAAKBIDMEK<TMInput, TMOutput, TMNode>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(PGCEIHEBNHC<APKOFFGFFFK<TMInput>, JMOIGKCGAKM<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x25CFA40", Offset = "0x25CE840", VA = "0x1825CFA40")]
	public static PGCEIHEBNHC<APKOFFGFFFK<TMNode?>, DLDFHLHIECL<TMInput?, TMOutput?, TMNode?>> KICGPNOLDMC<TMNode, TMInput, TMOutput>([In] this JPHAIIFFGJI<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(PGCEIHEBNHC<APKOFFGFFFK<TMNode>, DLDFHLHIECL<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JGFIFCEHNED<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal ALJMBBINLHG<TMInput> KECEOLMEBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal IFDPCBNFDPA<TMInput, APKOFFGFFFK<TMNode>> EPIOOPAMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal IFDPCBNFDPA<TMInput, HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>> GHLOOBDFPLM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x35FEE40", Offset = "0x35FDC40", VA = "0x1835FEE40")]
	internal JGFIFCEHNED([In] ALJMBBINLHG<TMInput> AFOBCMCDEPI, [In] IFDPCBNFDPA<TMInput, APKOFFGFFFK<TMNode>> LAHHJHJPIFC, [In] IFDPCBNFDPA<TMInput, HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>> JFFCHHIAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x35FEC80", Offset = "0x35FDA80", VA = "0x1835FEC80")]
	internal static JGFIFCEHNED<TMInput, TMOutput, TMNode> DCPHPAHCOGO()
	{
		return default(JGFIFCEHNED<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CKMJACIKGLL
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x240EF40", Offset = "0x240DD40", VA = "0x18240EF40")]
	internal static FLACDHHBAED OKNECDBNGHE<TMInput, TMOutput, TMNode>([In] this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x240E580", Offset = "0x240D380", VA = "0x18240E580")]
	internal static JGFIFCEHNED<TMInput, TMOutput, TMNode> HONCKFFEJNK<TMInput, TMOutput, TMNode>(this FLACDHHBAED OJFDNDCDDBK)
	{
		return default(JGFIFCEHNED<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x240EA90", Offset = "0x240D890", VA = "0x18240EA90")]
	private static MAFMJDLEKNJ JHLKIAAHLMB<TMOutput>([In] this HOFNAAMCEFO<APKOFFGFFFK<TMOutput>> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x240ECC0", Offset = "0x240DAC0", VA = "0x18240ECC0")]
	private static HOFNAAMCEFO<APKOFFGFFFK<TMOutput>> NENNMGKMLFC<TMOutput>(this MAFMJDLEKNJ OJFDNDCDDBK)
	{
		return default(HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x240E3F0", Offset = "0x240D1F0", VA = "0x18240E3F0")]
	internal static void HLIABIFOACE<TMInput, TMOutput, TMNode>(this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x240E350", Offset = "0x240D150", VA = "0x18240E350")]
	internal static APKOFFGFFFK<TMInput> FKNAJONOIJN<TMInput, TMOutput, TMNode>(this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> NJDCNMOJCAA)
	{
		return default(APKOFFGFFFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x240E2C0", Offset = "0x240D0C0", VA = "0x18240E2C0")]
	internal static void ENHCKFGAJIO<TMInput, TMOutput, TMNode>(this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> JDEPDKNELPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x240E2A0", Offset = "0x240D0A0", VA = "0x18240E2A0")]
	public static bool EHIDDDLCNJK<TMInput, TMOutput, TMNode>([In] this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> JDEPDKNELPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x240EC60", Offset = "0x240DA60", VA = "0x18240EC60")]
	public static APKOFFGFFFK<TMNode> LJGLODNCJOM<TMNode, TMInput, TMOutput>([In] this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> JDEPDKNELPP)
	{
		return default(APKOFFGFFFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x240EC80", Offset = "0x240DA80", VA = "0x18240EC80")]
	public static int NCFHOHKCPIJ<TMInput, TMOutput, TMNode>([In] this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> JDEPDKNELPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x240E210", Offset = "0x240D010", VA = "0x18240E210")]
	public static APKOFFGFFFK<TMOutput> BGCADIIJCBN<TMOutput, TMInput, TMNode>([In] this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> JDEPDKNELPP, int HPLKFBKKIBG)
	{
		return default(APKOFFGFFFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x240E260", Offset = "0x240D060", VA = "0x18240E260")]
	internal static void DCHADLADKNE<TMInput, TMOutput, TMNode>(this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> JDEPDKNELPP, APKOFFGFFFK<TMOutput> PKHIGJLAHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x240E260", Offset = "0x240D060", VA = "0x18240E260")]
	internal static void LGLMDKDKFIE<TMInput, TMOutput, TMNode>(this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> JDEPDKNELPP, APKOFFGFFFK<TMOutput> PKHIGJLAHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x240E1B0", Offset = "0x240CFB0", VA = "0x18240E1B0")]
	public static HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF NIJDCCELINA<TMOutput, TMInput, TMNode>([In] this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> JDEPDKNELPP)
	{
		return default(HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x240E1B0", Offset = "0x240CFB0", VA = "0x18240E1B0")]
	public static GPACJCFOOHI<APKOFFGFFFK<TMOutput>, HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF> ABEFBJEAPCJ<TMOutput, TMInput, TMNode>([In] this JGFIFCEHNED<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMInput> JDEPDKNELPP)
	{
		return default(GPACJCFOOHI<APKOFFGFFFK<TMOutput>, HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OFBAOPBPGDL<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal ALJMBBINLHG<TMNode> KECEOLMEBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal IFDPCBNFDPA<TMNode, HOFNAAMCEFO<APKOFFGFFFK<TMInput>>> HMFKFFJPGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal IFDPCBNFDPA<TMNode, HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>> GHLOOBDFPLM;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x35FEE40", Offset = "0x35FDC40", VA = "0x1835FEE40")]
	internal OFBAOPBPGDL([In] ALJMBBINLHG<TMNode> AFOBCMCDEPI, [In] IFDPCBNFDPA<TMNode, HOFNAAMCEFO<APKOFFGFFFK<TMInput>>> MBIIODBGLDK, [In] IFDPCBNFDPA<TMNode, HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>> JFFCHHIAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35FEC80", Offset = "0x35FDA80", VA = "0x1835FEC80")]
	internal static OFBAOPBPGDL<TMInput, TMOutput, TMNode> DCPHPAHCOGO()
	{
		return default(OFBAOPBPGDL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CMOODDNKMDI
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2411F30", Offset = "0x2410D30", VA = "0x182411F30")]
	internal static FMGNDNDDHDG OKNECDBNGHE<TMInput, TMOutput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2411330", Offset = "0x2410130", VA = "0x182411330")]
	internal static OFBAOPBPGDL<TMInput, TMOutput, TMNode> HONCKFFEJNK<TMInput, TMOutput, TMNode>(this FMGNDNDDHDG OJFDNDCDDBK)
	{
		return default(OFBAOPBPGDL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x24118F0", Offset = "0x24106F0", VA = "0x1824118F0")]
	private static DLHFGADPPDE MLHOAJGEPMC<TMInput>([In] this HOFNAAMCEFO<APKOFFGFFFK<TMInput>> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2411AE0", Offset = "0x24108E0", VA = "0x182411AE0")]
	private static HOFNAAMCEFO<APKOFFGFFFK<TMInput>> OAILNBECHOG<TMInput>(this DLHFGADPPDE OJFDNDCDDBK)
	{
		return default(HOFNAAMCEFO<APKOFFGFFFK<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2411D60", Offset = "0x2410B60", VA = "0x182411D60")]
	private static FILLLLDJOLK ODBLAAHBEGP<TMOutput>([In] this HOFNAAMCEFO<APKOFFGFFFK<TMOutput>> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2410B40", Offset = "0x240F940", VA = "0x182410B40")]
	private static HOFNAAMCEFO<APKOFFGFFFK<TMOutput>> AMNANFKOINB<TMOutput>(this FILLLLDJOLK OJFDNDCDDBK)
	{
		return default(HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2411070", Offset = "0x240FE70", VA = "0x182411070")]
	internal static void HLIABIFOACE<TMInput, TMOutput, TMNode>(this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2410F50", Offset = "0x240FD50", VA = "0x182410F50")]
	internal static APKOFFGFFFK<TMNode> FKNAJONOIJN<TMNode, TMInput, TMOutput>(this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, [In] HOFNAAMCEFO<APKOFFGFFFK<TMInput>> MBIIODBGLDK, [In] HOFNAAMCEFO<APKOFFGFFFK<TMOutput>> JFFCHHIAPNM)
	{
		return default(APKOFFGFFFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2410E90", Offset = "0x240FC90", VA = "0x182410E90")]
	internal static void ENHCKFGAJIO<TMInput, TMOutput, TMNode>(this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x240E2A0", Offset = "0x240D0A0", VA = "0x18240E2A0")]
	public static bool EHIDDDLCNJK<TMInput, TMOutput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2411AC0", Offset = "0x24108C0", VA = "0x182411AC0")]
	public static int NGBPPAGDCLA<TMInput, TMOutput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2410DC0", Offset = "0x240FBC0", VA = "0x182410DC0")]
	public static int BHKBCGMAICH<TMInput, TMOutput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x240EC80", Offset = "0x240DA80", VA = "0x18240EC80")]
	public static int NCFHOHKCPIJ<TMInput, TMOutput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2411840", Offset = "0x2410640", VA = "0x182411840")]
	public static APKOFFGFFFK<TMInput> JBPNFELIDCC<TMInput, TMOutput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP, int HPLKFBKKIBG)
	{
		return default(APKOFFGFFFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x240E210", Offset = "0x240D010", VA = "0x18240E210")]
	public static APKOFFGFFFK<TMOutput> BGCADIIJCBN<TMOutput, TMInput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP, int HPLKFBKKIBG)
	{
		return default(APKOFFGFFFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2410E00", Offset = "0x240FC00", VA = "0x182410E00")]
	internal static void DHJAIFGOLHK<TMInput, TMOutput, TMNode>(this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP, APKOFFGFFFK<TMInput> GBHKLJOHIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x240E260", Offset = "0x240D060", VA = "0x18240E260")]
	internal static void DCHADLADKNE<TMInput, TMOutput, TMNode>(this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP, APKOFFGFFFK<TMOutput> PKHIGJLAHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2411020", Offset = "0x240FE20", VA = "0x182411020")]
	internal static void HIJPCMOKJEM<TMInput, TMOutput, TMNode>(this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP, int HPLKFBKKIBG, APKOFFGFFFK<TMInput> GBHKLJOHIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2410E40", Offset = "0x240FC40", VA = "0x182410E40")]
	internal static void EMECIOHAPKN<TMInput, TMOutput, TMNode>(this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP, int HPLKFBKKIBG, APKOFFGFFFK<TMOutput> PKHIGJLAHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2410E00", Offset = "0x240FC00", VA = "0x182410E00")]
	internal static void LIHHAKGAFHI<TMInput, TMOutput, TMNode>(this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP, APKOFFGFFFK<TMInput> GBHKLJOHIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x240E260", Offset = "0x240D060", VA = "0x18240E260")]
	internal static void LGLMDKDKFIE<TMInput, TMOutput, TMNode>(this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP, APKOFFGFFFK<TMOutput> PKHIGJLAHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2411890", Offset = "0x2410690", VA = "0x182411890")]
	public static HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF OGHHODOMCHE<TMInput, TMOutput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x240E1B0", Offset = "0x240CFB0", VA = "0x18240E1B0")]
	public static HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF NIJDCCELINA<TMOutput, TMInput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2411890", Offset = "0x2410690", VA = "0x182411890")]
	public static GPACJCFOOHI<APKOFFGFFFK<TMInput>, HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF> LEPOPEAKPPG<TMInput, TMOutput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(GPACJCFOOHI<APKOFFGFFFK<TMInput>, HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x240E1B0", Offset = "0x240CFB0", VA = "0x18240E1B0")]
	public static GPACJCFOOHI<APKOFFGFFFK<TMOutput>, HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF> ABEFBJEAPCJ<TMOutput, TMInput, TMNode>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> JDEPDKNELPP)
	{
		return default(GPACJCFOOHI<APKOFFGFFFK<TMOutput>, HOFNAAMCEFO<APKOFFGFFFK<TMOutput>>.NPHIONFBODF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2410FE0", Offset = "0x240FDE0", VA = "0x182410FE0")]
	public static PGCEIHEBNHC<APKOFFGFFFK<TMNode>, ALJMBBINLHG<TMNode>.FIBOJKAFIOA> HAAAGABAHDF<TMNode, TMInput, TMOutput>([In] this OFBAOPBPGDL<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return default(PGCEIHEBNHC<APKOFFGFFFK<TMNode>, ALJMBBINLHG<TMNode>.FIBOJKAFIOA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FFOJLNIEOKG<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal ALJMBBINLHG<TMOutput> KECEOLMEBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal IFDPCBNFDPA<TMOutput, APKOFFGFFFK<TMNode>> EPIOOPAMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal IFDPCBNFDPA<TMOutput, HOFNAAMCEFO<APKOFFGFFFK<TMInput>>> HMFKFFJPGEI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x35FEE40", Offset = "0x35FDC40", VA = "0x1835FEE40")]
	internal FFOJLNIEOKG([In] ALJMBBINLHG<TMOutput> AFOBCMCDEPI, [In] IFDPCBNFDPA<TMOutput, APKOFFGFFFK<TMNode>> LAHHJHJPIFC, [In] IFDPCBNFDPA<TMOutput, HOFNAAMCEFO<APKOFFGFFFK<TMInput>>> MBIIODBGLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x35FEC80", Offset = "0x35FDA80", VA = "0x1835FEC80")]
	internal static FFOJLNIEOKG<TMInput, TMOutput, TMNode> DCPHPAHCOGO()
	{
		return default(FFOJLNIEOKG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class POGOOKMAPLK
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2774530", Offset = "0x2773330", VA = "0x182774530")]
	internal static CDMAMAFDEEA OKNECDBNGHE<TMInput, TMOutput, TMNode>([In] this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2773BD0", Offset = "0x27729D0", VA = "0x182773BD0")]
	internal static FFOJLNIEOKG<TMInput, TMOutput, TMNode> HONCKFFEJNK<TMInput, TMOutput, TMNode>(this CDMAMAFDEEA OJFDNDCDDBK)
	{
		return default(FFOJLNIEOKG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x27740E0", Offset = "0x2772EE0", VA = "0x1827740E0")]
	private static GDDBELNLHHO IIHKLPOMOAC<TMInput>([In] this HOFNAAMCEFO<APKOFFGFFFK<TMInput>> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x27742B0", Offset = "0x27730B0", VA = "0x1827742B0")]
	private static HOFNAAMCEFO<APKOFFGFFFK<TMInput>> LEAAOEFCGMJ<TMInput>(this GDDBELNLHHO OJFDNDCDDBK)
	{
		return default(HOFNAAMCEFO<APKOFFGFFFK<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x240E3F0", Offset = "0x240D1F0", VA = "0x18240E3F0")]
	internal static void HLIABIFOACE<TMInput, TMOutput, TMNode>(this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x240E350", Offset = "0x240D150", VA = "0x18240E350")]
	internal static APKOFFGFFFK<TMOutput> FKNAJONOIJN<TMOutput, TMInput, TMNode>(this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMNode> NJDCNMOJCAA)
	{
		return default(APKOFFGFFFK<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x240E2C0", Offset = "0x240D0C0", VA = "0x18240E2C0")]
	internal static void ENHCKFGAJIO<TMInput, TMOutput, TMNode>(this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> JDEPDKNELPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x240E2A0", Offset = "0x240D0A0", VA = "0x18240E2A0")]
	public static bool EHIDDDLCNJK<TMInput, TMOutput, TMNode>([In] this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> JDEPDKNELPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x240EC60", Offset = "0x240DA60", VA = "0x18240EC60")]
	public static APKOFFGFFFK<TMNode> LJGLODNCJOM<TMNode, TMInput, TMOutput>([In] this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> JDEPDKNELPP)
	{
		return default(APKOFFGFFFK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x240EC80", Offset = "0x240DA80", VA = "0x18240EC80")]
	public static int BHKBCGMAICH<TMInput, TMOutput, TMNode>([In] this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> JDEPDKNELPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x240E210", Offset = "0x240D010", VA = "0x18240E210")]
	public static APKOFFGFFFK<TMInput> JBPNFELIDCC<TMInput, TMOutput, TMNode>([In] this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> JDEPDKNELPP, int HPLKFBKKIBG)
	{
		return default(APKOFFGFFFK<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x240E260", Offset = "0x240D060", VA = "0x18240E260")]
	internal static void DHJAIFGOLHK<TMInput, TMOutput, TMNode>(this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> JDEPDKNELPP, APKOFFGFFFK<TMInput> GBHKLJOHIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x240E260", Offset = "0x240D060", VA = "0x18240E260")]
	internal static void LIHHAKGAFHI<TMInput, TMOutput, TMNode>(this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> JDEPDKNELPP, APKOFFGFFFK<TMInput> GBHKLJOHIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x240E1B0", Offset = "0x240CFB0", VA = "0x18240E1B0")]
	public static HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF OGHHODOMCHE<TMInput, TMOutput, TMNode>([In] this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> JDEPDKNELPP)
	{
		return default(HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x240E1B0", Offset = "0x240CFB0", VA = "0x18240E1B0")]
	public static GPACJCFOOHI<APKOFFGFFFK<TMInput>, HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF> LEPOPEAKPPG<TMInput, TMOutput, TMNode>([In] this FFOJLNIEOKG<TMInput, TMOutput, TMNode> OJFDNDCDDBK, APKOFFGFFFK<TMOutput> JDEPDKNELPP)
	{
		return default(GPACJCFOOHI<APKOFFGFFFK<TMInput>, HOFNAAMCEFO<APKOFFGFFFK<TMInput>>.NPHIONFBODF>);
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
