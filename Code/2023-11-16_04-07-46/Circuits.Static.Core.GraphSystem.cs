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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CBD2B0", Offset = "0x1CBC2B0", VA = "0x181CBD2B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CCONPJAAFKN<TMInput, TMOutput, TMNode> : IEnumerator<GPIHCBBBGNP<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LPLDKNNIJDL<TMInput, TMOutput, TMNode> FOHENMICHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private DFNLHMGCNBB<TMInput, TMOutput, TMNode> NECMGCDHPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool CNPBAJIPOIG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly GPIHCBBBGNP<TMNode> PADEIDMLAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x47F1C40", Offset = "0x47F0C40", VA = "0x1847F1C40", Slot = "4")]
		get
		{
			return default(GPIHCBBBGNP<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x47F1AE0", Offset = "0x47F0AE0", VA = "0x1847F1AE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x47F1B70", Offset = "0x47F0B70", VA = "0x1847F1B70")]
	internal CCONPJAAFKN([In] LPLDKNNIJDL<TMInput, TMOutput, TMNode> MIKDPFIPOFO, [In] DFNLHMGCNBB<TMInput, TMOutput, TMNode> NKJGFCLCGBH, bool GOPEDOEDMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x47F19A0", Offset = "0x47F09A0", VA = "0x1847F19A0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x47F1A60", Offset = "0x47F0A60", VA = "0x1847F1A60", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x47F1920", Offset = "0x47F0920", VA = "0x1847F1920", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KGGCOHEBDDC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x253B8B0", Offset = "0x253A8B0", VA = "0x18253B8B0")]
	public static CCONPJAAFKN<TMInput, TMOutput, TMNode> ANBAJJBGINK<TMInput, TMOutput, TMNode>([In] EMMJFGFOBCO<TMInput, TMOutput, TMNode> FEPHABNICHE, GPIHCBBBGNP<TMNode> BCDEFAJKINM)
	{
		return default(CCONPJAAFKN<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DFNLHMGCNBB<TMInput, TMOutput, TMNode> : IEnumerator<GPIHCBBBGNP<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO PPEKFFLFDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO KAHBOBDKFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly OMGNHHMAMFE<TMInput, TMOutput, TMNode> CDIPLDNDHAF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GPIHCBBBGNP<TMInput> PADEIDMLAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F630", Offset = "0x3A9E630", VA = "0x183A9F630", Slot = "4")]
		get
		{
			return default(GPIHCBBBGNP<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F500", Offset = "0x3A9E500", VA = "0x183A9F500", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F5B0", Offset = "0x3A9E5B0", VA = "0x183A9F5B0")]
	internal DFNLHMGCNBB([In] MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO GIDFJOAAAAB, [In] MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO IAAEBLIBCPI, [In] OMGNHHMAMFE<TMInput, TMOutput, TMNode> KFAJDOKPMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F330", Offset = "0x3A9E330", VA = "0x183A9F330", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F490", Offset = "0x3A9E490", VA = "0x183A9F490", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F2C0", Offset = "0x3A9E2C0", VA = "0x183A9F2C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FGGIELPIAFO
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x24DA950", Offset = "0x24D9950", VA = "0x1824DA950")]
	public static DFNLHMGCNBB<TMInput, TMOutput, TMNode> ANBAJJBGINK<TMInput, TMOutput, TMNode>([In] EMMJFGFOBCO<TMInput, TMOutput, TMNode> FEPHABNICHE, GPIHCBBBGNP<TMNode> BCDEFAJKINM)
	{
		return default(DFNLHMGCNBB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LPLDKNNIJDL<TMInput, TMOutput, TMNode> : IEnumerator<GPIHCBBBGNP<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO KBCKLKDJJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO MIFMPBFJNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly NKEPIHIKNCJ<TMInput, TMOutput, TMNode> OFBKGGGGMHH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GPIHCBBBGNP<TMOutput> PADEIDMLAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F630", Offset = "0x3A9E630", VA = "0x183A9F630", Slot = "4")]
		get
		{
			return default(GPIHCBBBGNP<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F500", Offset = "0x3A9E500", VA = "0x183A9F500", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F5B0", Offset = "0x3A9E5B0", VA = "0x183A9F5B0")]
	internal LPLDKNNIJDL([In] MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO NNDECEMHFNB, [In] MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO PGBJPBDJPAG, [In] NKEPIHIKNCJ<TMInput, TMOutput, TMNode> KPPJAHNPGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F330", Offset = "0x3A9E330", VA = "0x183A9F330", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F490", Offset = "0x3A9E490", VA = "0x183A9F490", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F2C0", Offset = "0x3A9E2C0", VA = "0x183A9F2C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NONCFCMBOHE
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x26069D0", Offset = "0x26059D0", VA = "0x1826069D0")]
	public static LPLDKNNIJDL<TMInput, TMOutput, TMNode> ANBAJJBGINK<TMInput, TMOutput, TMNode>([In] EMMJFGFOBCO<TMInput, TMOutput, TMNode> FEPHABNICHE, GPIHCBBBGNP<TMNode> BCDEFAJKINM)
	{
		return default(LPLDKNNIJDL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EMMJFGFOBCO<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NKEPIHIKNCJ<TMInput, TMOutput, TMNode> GAIONANJAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public OMGNHHMAMFE<TMInput, TMOutput, TMNode> KJDEMPCMCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public FCHAKHGOKEP<TMInput, TMOutput, TMNode> BGANIBIFNKH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x311E750", Offset = "0x311D750", VA = "0x18311E750")]
	internal EMMJFGFOBCO([In] NKEPIHIKNCJ<TMInput, TMOutput, TMNode> KPPJAHNPGPD, [In] OMGNHHMAMFE<TMInput, TMOutput, TMNode> KFAJDOKPMLO, [In] FCHAKHGOKEP<TMInput, TMOutput, TMNode> PLHPAGBAMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x311E4A0", Offset = "0x311D4A0", VA = "0x18311E4A0")]
	public static EMMJFGFOBCO<TMInput?, TMOutput?, TMNode?> ANBAJJBGINK()
	{
		return default(EMMJFGFOBCO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NHEBDKCLPIB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x25FE950", Offset = "0x25FD950", VA = "0x1825FE950")]
	public static ALNNBMOFJPB? KJONJHMMAMK<TMInput, TMOutput, TMNode>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x25FDF20", Offset = "0x25FCF20", VA = "0x1825FDF20")]
	public static EMMJFGFOBCO<TMInput?, TMOutput?, TMNode?> AJBPOCIDFHA<TMInput, TMOutput, TMNode>(this ALNNBMOFJPB IEOMMHOPOKN)
	{
		return default(EMMJFGFOBCO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x25FE5A0", Offset = "0x25FD5A0", VA = "0x1825FE5A0")]
	public static void EPEJEEPODAB<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x25FEF00", Offset = "0x25FDF00", VA = "0x1825FEF00")]
	public static void OPBKPGMMHHI<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> ICODHANCGFO, GPIHCBBBGNP<TMInput> KOEODMAGCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x25FE680", Offset = "0x25FD680", VA = "0x1825FE680")]
	public static void GMANLBMEHAN<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> ICODHANCGFO, GPIHCBBBGNP<TMInput> KOEODMAGCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25FE870", Offset = "0x25FD870", VA = "0x1825FE870")]
	public static bool JNJHPLOFLDB<TMInput, TMOutput, TMNode>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> ICODHANCGFO, GPIHCBBBGNP<TMInput> KOEODMAGCFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25FEE70", Offset = "0x25FDE70", VA = "0x1825FEE70")]
	public static GPIHCBBBGNP<TMNode?> OCMGFBDFCAO<TMNode, TMInput, TMOutput>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
		return default(GPIHCBBBGNP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25FE760", Offset = "0x25FD760", VA = "0x1825FE760")]
	public static void JBBNEAOFDHJ<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> BCDEFAJKINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25FE290", Offset = "0x25FD290", VA = "0x1825FE290")]
	public static GPIHCBBBGNP<TMInput?> AOIMNBEPJPL<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> BCDEFAJKINM)
	{
		return default(GPIHCBBBGNP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25FEA30", Offset = "0x25FDA30", VA = "0x1825FEA30")]
	public static GPIHCBBBGNP<TMOutput?> KLPELFMPJOM<TMOutput, TMInput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> BCDEFAJKINM)
	{
		return default(GPIHCBBBGNP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x25FE6E0", Offset = "0x25FD6E0", VA = "0x1825FE6E0")]
	public static GPIHCBBBGNP<TMInput?> HKBDNPKNPJO<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> BCDEFAJKINM, int NFJIPMHILEL)
	{
		return default(GPIHCBBBGNP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25FE600", Offset = "0x25FD600", VA = "0x1825FE600")]
	public static GPIHCBBBGNP<TMOutput?> FBHLOECHOOJ<TMOutput, TMInput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> BCDEFAJKINM, int NFJIPMHILEL)
	{
		return default(GPIHCBBBGNP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x25FECE0", Offset = "0x25FDCE0", VA = "0x1825FECE0")]
	public static void NDPPAHHDJHE<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> BCDEFAJKINM, int LCJDGEFCPDI, int PLKFJIGCDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25FEC40", Offset = "0x25FDC40", VA = "0x1825FEC40")]
	public static void MEDEPDIIAAK<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> BCDEFAJKINM, int LCJDGEFCPDI, int PLKFJIGCDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25FED80", Offset = "0x25FDD80", VA = "0x1825FED80")]
	public static void OALDDKKAJFG<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> ELCGDFMGLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x25FE4C0", Offset = "0x25FD4C0", VA = "0x1825FE4C0")]
	public static void EAIHGHNBBDA<TMInput, TMOutput, TMNode>(this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> INCGKANBCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static GGDNMFIHDIB<TMInput?> EEDKGKMHHJI<TMInput, TMOutput, TMNode>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
		return default(GGDNMFIHDIB<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x25FEAA0", Offset = "0x25FDAA0", VA = "0x1825FEAA0")]
	public static GGDNMFIHDIB<TMOutput?> LKFHLECPNII<TMOutput, TMInput, TMNode>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
		return default(GGDNMFIHDIB<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x25FE940", Offset = "0x25FD940", VA = "0x1825FE940")]
	public static GGDNMFIHDIB<TMNode?> KCOACANKHLJ<TMNode, TMInput, TMOutput>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
		return default(GGDNMFIHDIB<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25FDEB0", Offset = "0x25FCEB0", VA = "0x1825FDEB0")]
	public static DFNLHMGCNBB<TMInput?, TMOutput?, TMNode?> AAFGLIOMBFA<TMInput, TMOutput, TMNode>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(DFNLHMGCNBB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x25FDEB0", Offset = "0x25FCEB0", VA = "0x1825FDEB0")]
	public static LPLDKNNIJDL<TMInput?, TMOutput?, TMNode?> KLADDNJFHEG<TMInput, TMOutput, TMNode>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(LPLDKNNIJDL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x25FE410", Offset = "0x25FD410", VA = "0x1825FE410")]
	public static CCONPJAAFKN<TMInput?, TMOutput?, TMNode?> CNCJNIJHDAA<TMInput, TMOutput, TMNode>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(CCONPJAAFKN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x25FE300", Offset = "0x25FD300", VA = "0x1825FE300")]
	public static PALIJBADNKP<GPIHCBBBGNP<TMInput?>, DFNLHMGCNBB<TMInput?, TMOutput?, TMNode?>> BDLLJBLNMGH<TMInput, TMOutput, TMNode>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(PALIJBADNKP<GPIHCBBBGNP<TMInput>, DFNLHMGCNBB<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x25FEAB0", Offset = "0x25FDAB0", VA = "0x1825FEAB0")]
	public static PALIJBADNKP<GPIHCBBBGNP<TMNode?>, CCONPJAAFKN<TMInput?, TMOutput?, TMNode?>> LODDEOOMFIA<TMNode, TMInput, TMOutput>([In] this EMMJFGFOBCO<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(PALIJBADNKP<GPIHCBBBGNP<TMNode>, CCONPJAAFKN<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NKEPIHIKNCJ<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal GGDNMFIHDIB<TMInput> NJAIEHODKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal IABIBBKADGN<TMInput, GPIHCBBBGNP<TMNode>> AMNDFBBKDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal IABIBBKADGN<TMInput, MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>> CDIPLDNDHAF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3446D40", Offset = "0x3445D40", VA = "0x183446D40")]
	internal NKEPIHIKNCJ([In] GGDNMFIHDIB<TMInput> GLFJEGIEBJE, [In] IABIBBKADGN<TMInput, GPIHCBBBGNP<TMNode>> PLHPAGBAMOM, [In] IABIBBKADGN<TMInput, MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>> KFAJDOKPMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3446B80", Offset = "0x3445B80", VA = "0x183446B80")]
	internal static NKEPIHIKNCJ<TMInput, TMOutput, TMNode> ANBAJJBGINK()
	{
		return default(NKEPIHIKNCJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LHKEOLMKOBD
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x255CE20", Offset = "0x255BE20", VA = "0x18255CE20")]
	internal static JNBDGBNLDKM KJONJHMMAMK<TMInput, TMOutput, TMNode>([In] this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x255C910", Offset = "0x255B910", VA = "0x18255C910")]
	internal static NKEPIHIKNCJ<TMInput, TMOutput, TMNode> AJBPOCIDFHA<TMInput, TMOutput, TMNode>(this JNBDGBNLDKM IEOMMHOPOKN)
	{
		return default(NKEPIHIKNCJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x255D1B0", Offset = "0x255C1B0", VA = "0x18255D1B0")]
	private static JKOAHFNAPEP KLEMEPOBCHM<TMOutput>([In] this MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>> IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x255D380", Offset = "0x255C380", VA = "0x18255D380")]
	private static MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>> POJJEJFIDAJ<TMOutput>(this JKOAHFNAPEP IEOMMHOPOKN)
	{
		return default(MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x24EE660", Offset = "0x24ED660", VA = "0x1824EE660")]
	internal static void EPEJEEPODAB<TMInput, TMOutput, TMNode>(this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x24EE8D0", Offset = "0x24ED8D0", VA = "0x1824EE8D0")]
	internal static GPIHCBBBGNP<TMInput> IAPKMBHFOLE<TMInput, TMOutput, TMNode>(this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> OCIGNENFCHG)
	{
		return default(GPIHCBBBGNP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x24EE7F0", Offset = "0x24ED7F0", VA = "0x1824EE7F0")]
	internal static void FBELCMGCHEP<TMInput, TMOutput, TMNode>(this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> LPCEACMGEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x23BF910", Offset = "0x23BE910", VA = "0x1823BF910")]
	public static bool AKEJHEAMADO<TMInput, TMOutput, TMNode>([In] this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> LPCEACMGEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24EE600", Offset = "0x24ED600", VA = "0x1824EE600")]
	public static GPIHCBBBGNP<TMNode> DAOFHKCAKDP<TMNode, TMInput, TMOutput>([In] this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> LPCEACMGEAL)
	{
		return default(GPIHCBBBGNP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24EE5C0", Offset = "0x24ED5C0", VA = "0x1824EE5C0")]
	public static int JILEIJPIMJN<TMInput, TMOutput, TMNode>([In] this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> LPCEACMGEAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x24EE880", Offset = "0x24ED880", VA = "0x1824EE880")]
	public static GPIHCBBBGNP<TMOutput> GAAPKIAAOKP<TMOutput, TMInput, TMNode>([In] this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> LPCEACMGEAL, int NFJIPMHILEL)
	{
		return default(GPIHCBBBGNP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24EE620", Offset = "0x24ED620", VA = "0x1824EE620")]
	internal static void HHIBNADINFE<TMInput, TMOutput, TMNode>(this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> LPCEACMGEAL, GPIHCBBBGNP<TMOutput> INCGKANBCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x24EE620", Offset = "0x24ED620", VA = "0x1824EE620")]
	internal static void JCMODBJLEBC<TMInput, TMOutput, TMNode>(this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> LPCEACMGEAL, GPIHCBBBGNP<TMOutput> INCGKANBCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x24EE560", Offset = "0x24ED560", VA = "0x1824EE560")]
	public static MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO IIJHJDOAOHC<TMOutput, TMInput, TMNode>([In] this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> LPCEACMGEAL)
	{
		return default(MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x24EE560", Offset = "0x24ED560", VA = "0x1824EE560")]
	public static JHIDMAJCGFP<GPIHCBBBGNP<TMOutput>, MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO> AEBKMGFOMDL<TMOutput, TMInput, TMNode>([In] this NKEPIHIKNCJ<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMInput> LPCEACMGEAL)
	{
		return default(JHIDMAJCGFP<GPIHCBBBGNP<TMOutput>, MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FCHAKHGOKEP<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal GGDNMFIHDIB<TMNode> NJAIEHODKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal IABIBBKADGN<TMNode, MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>> OFBKGGGGMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal IABIBBKADGN<TMNode, MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>> CDIPLDNDHAF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3446D40", Offset = "0x3445D40", VA = "0x183446D40")]
	internal FCHAKHGOKEP([In] GGDNMFIHDIB<TMNode> GLFJEGIEBJE, [In] IABIBBKADGN<TMNode, MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>> KPPJAHNPGPD, [In] IABIBBKADGN<TMNode, MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>> KFAJDOKPMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3446B80", Offset = "0x3445B80", VA = "0x183446B80")]
	internal static FCHAKHGOKEP<TMInput, TMOutput, TMNode> ANBAJJBGINK()
	{
		return default(FCHAKHGOKEP<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KPOLNMPPBLB
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x255A890", Offset = "0x2559890", VA = "0x18255A890")]
	internal static LJMEGOBFPJN KJONJHMMAMK<TMInput, TMOutput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2559C20", Offset = "0x2558C20", VA = "0x182559C20")]
	internal static FCHAKHGOKEP<TMInput, TMOutput, TMNode> AJBPOCIDFHA<TMInput, TMOutput, TMNode>(this LJMEGOBFPJN IEOMMHOPOKN)
	{
		return default(FCHAKHGOKEP<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2559A50", Offset = "0x2558A50", VA = "0x182559A50")]
	private static HMIPLBAGOMO ACOGIKEPKAE<TMInput>([In] this MPBDHMMGIGI<GPIHCBBBGNP<TMInput>> IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x255AF20", Offset = "0x2559F20", VA = "0x18255AF20")]
	private static MPBDHMMGIGI<GPIHCBBBGNP<TMInput>> NACAPFLADMB<TMInput>(this HMIPLBAGOMO IEOMMHOPOKN)
	{
		return default(MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x255A190", Offset = "0x2559190", VA = "0x18255A190")]
	private static EKJKGPDFALK BNAEAGHHPFH<TMOutput>([In] this MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>> IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x255AC50", Offset = "0x2559C50", VA = "0x18255AC50")]
	private static MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>> MCIPGLCHDAA<TMOutput>(this EKJKGPDFALK IEOMMHOPOKN)
	{
		return default(MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x255A3E0", Offset = "0x25593E0", VA = "0x18255A3E0")]
	internal static void EPEJEEPODAB<TMInput, TMOutput, TMNode>(this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x255A800", Offset = "0x2559800", VA = "0x18255A800")]
	internal static GPIHCBBBGNP<TMNode> IAPKMBHFOLE<TMNode, TMInput, TMOutput>(this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, [In] MPBDHMMGIGI<GPIHCBBBGNP<TMInput>> KPPJAHNPGPD, [In] MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>> KFAJDOKPMLO)
	{
		return default(GPIHCBBBGNP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x255A6A0", Offset = "0x25596A0", VA = "0x18255A6A0")]
	internal static void FBELCMGCHEP<TMInput, TMOutput, TMNode>(this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x23BF910", Offset = "0x23BE910", VA = "0x1823BF910")]
	public static bool AKEJHEAMADO<TMInput, TMOutput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x255A360", Offset = "0x2559360", VA = "0x18255A360")]
	public static int CGJPLBAAEHN<TMInput, TMOutput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24EE5C0", Offset = "0x24ED5C0", VA = "0x1824EE5C0")]
	public static int JILEIJPIMJN<TMInput, TMOutput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x255A7B0", Offset = "0x25597B0", VA = "0x18255A7B0")]
	public static GPIHCBBBGNP<TMInput> HLAPFMANMBC<TMInput, TMOutput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL, int NFJIPMHILEL)
	{
		return default(GPIHCBBBGNP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24EE880", Offset = "0x24ED880", VA = "0x1824EE880")]
	public static GPIHCBBBGNP<TMOutput> GAAPKIAAOKP<TMOutput, TMInput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL, int NFJIPMHILEL)
	{
		return default(GPIHCBBBGNP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x255A3A0", Offset = "0x25593A0", VA = "0x18255A3A0")]
	internal static void EHDGCBJCKCE<TMInput, TMOutput, TMNode>(this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL, GPIHCBBBGNP<TMInput> ELCGDFMGLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x24EE620", Offset = "0x24ED620", VA = "0x1824EE620")]
	internal static void HHIBNADINFE<TMInput, TMOutput, TMNode>(this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL, GPIHCBBBGNP<TMOutput> INCGKANBCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x255AED0", Offset = "0x2559ED0", VA = "0x18255AED0")]
	internal static void MDDPPDPBICH<TMInput, TMOutput, TMNode>(this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL, int NFJIPMHILEL, GPIHCBBBGNP<TMInput> ELCGDFMGLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x255A760", Offset = "0x2559760", VA = "0x18255A760")]
	internal static void HCEEJLNGAJN<TMInput, TMOutput, TMNode>(this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL, int NFJIPMHILEL, GPIHCBBBGNP<TMOutput> INCGKANBCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x255A3A0", Offset = "0x25593A0", VA = "0x18255A3A0")]
	internal static void IGGPKDGCIOB<TMInput, TMOutput, TMNode>(this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL, GPIHCBBBGNP<TMInput> ELCGDFMGLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24EE620", Offset = "0x24ED620", VA = "0x1824EE620")]
	internal static void JCMODBJLEBC<TMInput, TMOutput, TMNode>(this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL, GPIHCBBBGNP<TMOutput> INCGKANBCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x255A130", Offset = "0x2559130", VA = "0x18255A130")]
	public static MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO IOGFKKNDBAA<TMInput, TMOutput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24EE560", Offset = "0x24ED560", VA = "0x1824EE560")]
	public static MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO IIJHJDOAOHC<TMOutput, TMInput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x255A130", Offset = "0x2559130", VA = "0x18255A130")]
	public static JHIDMAJCGFP<GPIHCBBBGNP<TMInput>, MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO> BGFIJGEONLI<TMInput, TMOutput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(JHIDMAJCGFP<GPIHCBBBGNP<TMInput>, MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24EE560", Offset = "0x24ED560", VA = "0x1824EE560")]
	public static JHIDMAJCGFP<GPIHCBBBGNP<TMOutput>, MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO> AEBKMGFOMDL<TMOutput, TMInput, TMNode>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> LPCEACMGEAL)
	{
		return default(JHIDMAJCGFP<GPIHCBBBGNP<TMOutput>, MPBDHMMGIGI<GPIHCBBBGNP<TMOutput>>.JGFIGLIPHFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x24E54C0", Offset = "0x24E44C0", VA = "0x1824E54C0")]
	public static PALIJBADNKP<GPIHCBBBGNP<TMNode>, GGDNMFIHDIB<TMNode>.COIFAPKKAFP> NGGLKHMBAGA<TMNode, TMInput, TMOutput>([In] this FCHAKHGOKEP<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
		return default(PALIJBADNKP<GPIHCBBBGNP<TMNode>, GGDNMFIHDIB<TMNode>.COIFAPKKAFP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OMGNHHMAMFE<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal GGDNMFIHDIB<TMOutput> NJAIEHODKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal IABIBBKADGN<TMOutput, GPIHCBBBGNP<TMNode>> AMNDFBBKDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal IABIBBKADGN<TMOutput, MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>> OFBKGGGGMHH;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3446D40", Offset = "0x3445D40", VA = "0x183446D40")]
	internal OMGNHHMAMFE([In] GGDNMFIHDIB<TMOutput> GLFJEGIEBJE, [In] IABIBBKADGN<TMOutput, GPIHCBBBGNP<TMNode>> PLHPAGBAMOM, [In] IABIBBKADGN<TMOutput, MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>> KPPJAHNPGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3446B80", Offset = "0x3445B80", VA = "0x183446B80")]
	internal static OMGNHHMAMFE<TMInput, TMOutput, TMNode> ANBAJJBGINK()
	{
		return default(OMGNHHMAMFE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GJBBMKBGJHA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x24EE970", Offset = "0x24ED970", VA = "0x1824EE970")]
	internal static KLBGJADNCFD KJONJHMMAMK<TMInput, TMOutput, TMNode>([In] this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24EE050", Offset = "0x24ED050", VA = "0x1824EE050")]
	internal static OMGNHHMAMFE<TMInput, TMOutput, TMNode> AJBPOCIDFHA<TMInput, TMOutput, TMNode>(this KLBGJADNCFD IEOMMHOPOKN)
	{
		return default(OMGNHHMAMFE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x24EEF80", Offset = "0x24EDF80", VA = "0x1824EEF80")]
	private static JAJMALFHLJK PPECFLBPAGC<TMInput>([In] this MPBDHMMGIGI<GPIHCBBBGNP<TMInput>> IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x24EED00", Offset = "0x24EDD00", VA = "0x1824EED00")]
	private static MPBDHMMGIGI<GPIHCBBBGNP<TMInput>> LOHCNLMECGM<TMInput>(this JAJMALFHLJK IEOMMHOPOKN)
	{
		return default(MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x24EE660", Offset = "0x24ED660", VA = "0x1824EE660")]
	internal static void EPEJEEPODAB<TMInput, TMOutput, TMNode>(this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x24EE8D0", Offset = "0x24ED8D0", VA = "0x1824EE8D0")]
	internal static GPIHCBBBGNP<TMOutput> IAPKMBHFOLE<TMOutput, TMInput, TMNode>(this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMNode> OCIGNENFCHG)
	{
		return default(GPIHCBBBGNP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x24EE7F0", Offset = "0x24ED7F0", VA = "0x1824EE7F0")]
	internal static void FBELCMGCHEP<TMInput, TMOutput, TMNode>(this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> LPCEACMGEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x23BF910", Offset = "0x23BE910", VA = "0x1823BF910")]
	public static bool AKEJHEAMADO<TMInput, TMOutput, TMNode>([In] this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> LPCEACMGEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x24EE600", Offset = "0x24ED600", VA = "0x1824EE600")]
	public static GPIHCBBBGNP<TMNode> DAOFHKCAKDP<TMNode, TMInput, TMOutput>([In] this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> LPCEACMGEAL)
	{
		return default(GPIHCBBBGNP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x24EE5C0", Offset = "0x24ED5C0", VA = "0x1824EE5C0")]
	public static int CGJPLBAAEHN<TMInput, TMOutput, TMNode>([In] this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> LPCEACMGEAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x24EE880", Offset = "0x24ED880", VA = "0x1824EE880")]
	public static GPIHCBBBGNP<TMInput> HLAPFMANMBC<TMInput, TMOutput, TMNode>([In] this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> LPCEACMGEAL, int NFJIPMHILEL)
	{
		return default(GPIHCBBBGNP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x24EE620", Offset = "0x24ED620", VA = "0x1824EE620")]
	internal static void EHDGCBJCKCE<TMInput, TMOutput, TMNode>(this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> LPCEACMGEAL, GPIHCBBBGNP<TMInput> ELCGDFMGLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x24EE620", Offset = "0x24ED620", VA = "0x1824EE620")]
	internal static void IGGPKDGCIOB<TMInput, TMOutput, TMNode>(this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> LPCEACMGEAL, GPIHCBBBGNP<TMInput> ELCGDFMGLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x24EE560", Offset = "0x24ED560", VA = "0x1824EE560")]
	public static MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO IOGFKKNDBAA<TMInput, TMOutput, TMNode>([In] this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> LPCEACMGEAL)
	{
		return default(MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x24EE560", Offset = "0x24ED560", VA = "0x1824EE560")]
	public static JHIDMAJCGFP<GPIHCBBBGNP<TMInput>, MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO> BGFIJGEONLI<TMInput, TMOutput, TMNode>([In] this OMGNHHMAMFE<TMInput, TMOutput, TMNode> IEOMMHOPOKN, GPIHCBBBGNP<TMOutput> LPCEACMGEAL)
	{
		return default(JHIDMAJCGFP<GPIHCBBBGNP<TMInput>, MPBDHMMGIGI<GPIHCBBBGNP<TMInput>>.JGFIGLIPHFO>);
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
