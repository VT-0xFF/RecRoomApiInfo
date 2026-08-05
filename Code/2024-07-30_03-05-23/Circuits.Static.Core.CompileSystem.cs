using System;
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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x200CCB0", Offset = "0x200B2B0", VA = "0x18200CCB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct JFFKPPPAMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DDDIFAPFJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int MLKNMOMOHBP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
	public JFFKPPPAMLC(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LNAOIGBMCFE, int GCMGLJCEDLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IJGDLBAAJPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class CFGDMAJPIEH : FPKLLBHOFOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct HIDMMHKIHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly JJIKHNBJAJG<byte> LLOCFONDLNO;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FC35A0", Offset = "0x1FC1BA0", VA = "0x181FC35A0")]
		public HIDMMHKIHDE(JJIKHNBJAJG<byte> LKFNEINGOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x200BC50", Offset = "0x200A250", VA = "0x18200BC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class NMLIEEOBIPI : FPKLLBHOFOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct OHHAELDDHNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> MIHDFFBMJPC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		public OHHAELDDHNG(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> MHJMPOLCNNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum OBCGEIAFMJH
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		BytesImmediate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		X32Immediate
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class PHJDGODBGPM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class FPKLLBHOFOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct EBNHGGKPLIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly OBCGEIAFMJH JLIKLJMCJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly CGBGMGFBCKF<FPKLLBHOFOE> IDKHLFDBHHL;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
		public EBNHGGKPLIK(OBCGEIAFMJH PAJFMBKKKEO, CGBGMGFBCKF<FPKLLBHOFOE> MFNKONDKBPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class MGFPODGNDML : FPKLLBHOFOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct GFOMBAJHDCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> HDIFMHKGIDG;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		public GFOMBAJHDCP(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KODIDLJDOEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class NDKFCFAEOHN : FPKLLBHOFOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct JCLNFJCGFFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly DLDLNHCGMKC HMOGEKLEOFM;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		public JCLNFJCGFFD(DLDLNHCGMKC CNHMPAEAGHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x200C1B0", Offset = "0x200A7B0", VA = "0x18200C1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal EFGBPJHFLDL<PHJDGODBGPM, EBNHGGKPLIK> HJECDGOHGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal EFGBPJHFLDL<CFGDMAJPIEH, HIDMMHKIHDE> DIAFIINPBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal EFGBPJHFLDL<NMLIEEOBIPI, OHHAELDDHNG> HDJMKIANFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal EFGBPJHFLDL<MGFPODGNDML, GFOMBAJHDCP> PNBOOJFHKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal EFGBPJHFLDL<NDKFCFAEOHN, JCLNFJCGFFD> BBELGOCPGOI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x200BF20", Offset = "0x200A520", VA = "0x18200BF20")]
	private IJGDLBAAJPJ([In] EFGBPJHFLDL<PHJDGODBGPM, EBNHGGKPLIK> DCAHIDAPCDN, [In] EFGBPJHFLDL<CFGDMAJPIEH, HIDMMHKIHDE> ALPOIHNDAPA, [In] EFGBPJHFLDL<NMLIEEOBIPI, OHHAELDDHNG> AIENPMIELLC, [In] EFGBPJHFLDL<MGFPODGNDML, GFOMBAJHDCP> KHHNLKBCHJC, [In] EFGBPJHFLDL<NDKFCFAEOHN, JCLNFJCGFFD> LGPIBIEMHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x200BDE0", Offset = "0x200A3E0", VA = "0x18200BDE0")]
	public static IJGDLBAAJPJ ENFOKLPNHAF()
	{
		return default(IJGDLBAAJPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HNADNFKBOKF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x200BCC0", Offset = "0x200A2C0", VA = "0x18200BCC0")]
	public static void IHOPKBJIMEI(this IJGDLBAAJPJ HLIDMKMINHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum HEFHKFLFIML
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NOAHKNCJLAI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class MNLLCOOGLEA : BDNFENOOLEO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct DKCHDALEHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> HDJAENOPHCK;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		public DKCHDALEHMF(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> AFBEHNIEBLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum EIHEODNPAMA
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Branch,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		DeadEndData,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OutNode
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class GJBLKCDEMPJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class BDNFENOOLEO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct DAJIHJEPBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly EIHEODNPAMA JLIKLJMCJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly CGBGMGFBCKF<BDNFENOOLEO> IDKHLFDBHHL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
		public DAJIHJEPBEN(EIHEODNPAMA PAJFMBKKKEO, CGBGMGFBCKF<BDNFENOOLEO> MFNKONDKBPB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal EFGBPJHFLDL<GJBLKCDEMPJ, DAJIHJEPBEN> HJECDGOHGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal EFGBPJHFLDL<MNLLCOOGLEA, DKCHDALEHMF> HLHPMFDHIGF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x200CBF0", Offset = "0x200B1F0", VA = "0x18200CBF0")]
	private NOAHKNCJLAI([In] EFGBPJHFLDL<GJBLKCDEMPJ, DAJIHJEPBEN> DCAHIDAPCDN, [In] EFGBPJHFLDL<MNLLCOOGLEA, DKCHDALEHMF> DNIAKFPHKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x200CB60", Offset = "0x200B160", VA = "0x18200CB60")]
	public static NOAHKNCJLAI ENFOKLPNHAF()
	{
		return default(NOAHKNCJLAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HPMNJDLPIOO
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x200BD70", Offset = "0x200A370", VA = "0x18200BD70")]
	public static void IHOPKBJIMEI(this NOAHKNCJLAI HLIDMKMINHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EEFPCJNDLIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public DKMINHFJCNM<int> LJKGMMIDJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public DKMINHFJCNM<int> KDHJHCDNGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int DPMOIICFEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int GADIOAHBKIJ;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2005E40", Offset = "0x2004440", VA = "0x182005E40")]
	private EEFPCJNDLIK([In] DKMINHFJCNM<int> KOCMEPDECNL, [In] DKMINHFJCNM<int> AHEEGKLLCGM, int BLCOMFCJGFN, int OFDKEOIPGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2005DA0", Offset = "0x20043A0", VA = "0x182005DA0")]
	public static EEFPCJNDLIK ENFOKLPNHAF()
	{
		return default(EEFPCJNDLIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EODCIDADGFL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x200B130", Offset = "0x2009730", VA = "0x18200B130")]
	public static void IHOPKBJIMEI(this EEFPCJNDLIK HLIDMKMINHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GOBCIPBHKBL
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum AADOJCPHCNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class LIHIJOICLLC : ONKKBDKCDLG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct KCEDKHNIEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly CGBGMGFBCKF<NDMHLBDMIDJ> OCBCCEKPFJI;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		public KCEDKHNIEPK(CGBGMGFBCKF<NDMHLBDMIDJ> PMHDNGLAKPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class BEAJJAGKBCE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class ONKKBDKCDLG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct IGDHIKJIJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly AADOJCPHCNN JLIKLJMCJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly CGBGMGFBCKF<ONKKBDKCDLG> IDKHLFDBHHL;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
		private IGDHIKJIJHJ(AADOJCPHCNN PAJFMBKKKEO, CGBGMGFBCKF<ONKKBDKCDLG> MFNKONDKBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x200BDD0", Offset = "0x200A3D0", VA = "0x18200BDD0")]
		public static IGDHIKJIJHJ ENFOKLPNHAF(AADOJCPHCNN PAJFMBKKKEO, CGBGMGFBCKF<ONKKBDKCDLG> MFNKONDKBPB)
		{
			return default(IGDHIKJIJHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class PGBMFOOMPAG : ONKKBDKCDLG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct LCADMLDKALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly CGBGMGFBCKF<NDMHLBDMIDJ> OCBCCEKPFJI;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		public LCADMLDKALA(CGBGMGFBCKF<NDMHLBDMIDJ> PMHDNGLAKPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class NDMHLBDMIDJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct NPINAKBIGBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public DKMINHFJCNM<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> GOEMPGFMAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public DKMINHFJCNM<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> KJPGIDOFIMB;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x200CBF0", Offset = "0x200B1F0", VA = "0x18200CBF0")]
		private NPINAKBIGBK([In] DKMINHFJCNM<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> NKMAJMKBAIK, [In] DKMINHFJCNM<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> BLFHOOKFFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x200CC30", Offset = "0x200B230", VA = "0x18200CC30")]
		public static NPINAKBIGBK ENFOKLPNHAF()
		{
			return default(NPINAKBIGBK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal EFGBPJHFLDL<BEAJJAGKBCE, IGDHIKJIJHJ> HJECDGOHGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal EFGBPJHFLDL<PGBMFOOMPAG, LCADMLDKALA> JPHEDFPAJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal EFGBPJHFLDL<LIHIJOICLLC, KCEDKHNIEPK> EPJEHMGCGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal DKMINHFJCNM<(CGBGMGFBCKF<BEAJJAGKBCE> CallId, CGBGMGFBCKF<NDMHLBDMIDJ> IOId)> IPAMMFKFGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal EFGBPJHFLDL<NDMHLBDMIDJ, NPINAKBIGBK> MODCDHECKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal ODKHIEPFOPO<NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> FHGBJGEBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal ODKHIEPFOPO<NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> KJHNEKGNKLP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x200BB90", Offset = "0x200A190", VA = "0x18200BB90")]
	private GOBCIPBHKBL([In] EFGBPJHFLDL<BEAJJAGKBCE, IGDHIKJIJHJ> DCAHIDAPCDN, [In] EFGBPJHFLDL<PGBMFOOMPAG, LCADMLDKALA> AFOBFIDFHBM, [In] EFGBPJHFLDL<LIHIJOICLLC, KCEDKHNIEPK> AJBDCHEJJDF, [In] DKMINHFJCNM<(CGBGMGFBCKF<BEAJJAGKBCE> CallId, CGBGMGFBCKF<NDMHLBDMIDJ> IOId)> AACAIEIDEIN, [In] EFGBPJHFLDL<NDMHLBDMIDJ, NPINAKBIGBK> PGHJJBIHFJH, [In] ODKHIEPFOPO<NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> GALBHKEPIFN, [In] ODKHIEPFOPO<NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> CEBINABKAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x200B9F0", Offset = "0x2009FF0", VA = "0x18200B9F0")]
	public static GOBCIPBHKBL ENFOKLPNHAF()
	{
		return default(GOBCIPBHKBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FMDJOOHCFBO
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x200B780", Offset = "0x2009D80", VA = "0x18200B780")]
	private static void IHOPKBJIMEI(this GOBCIPBHKBL.NPINAKBIGBK HLIDMKMINHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x200B570", Offset = "0x2009B70", VA = "0x18200B570")]
	public static void IHOPKBJIMEI(this GOBCIPBHKBL HLIDMKMINHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PAENECJPGGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public DKMINHFJCNM<byte> LIELOBMPLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal GOBCIPBHKBL JLDHHOIGMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal LNIKAMGIKOC AHNLFEPMEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> FHKPANOGALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal IJGDLBAAJPJ APOCCHGACLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal NOAHKNCJLAI FHOICJIDBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal ODKHIEPFOPO<FELHHAAOOHO, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>?> PHHHMOJICAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal DKMINHFJCNM<CGBGMGFBCKF<FELHHAAOOHO>> LGGBHOAHFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> FJHNOLIIKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> LHEGGKJDLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> LAEJLNJCIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal EPMCEGHJFLI GLOPLHICFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal EPNHOMAJGDB IGOJBCDGHJI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x200D9E0", Offset = "0x200BFE0", VA = "0x18200D9E0")]
	private PAENECJPGGE([In] DKMINHFJCNM<byte> FIOIIIFAKCN, [In] GOBCIPBHKBL HOLFACHEMOM, [In] LNIKAMGIKOC BGMNGCJLMHI, [In] IJGDLBAAJPJ IGCNKKFAIOF, [In] NOAHKNCJLAI MECMKGOEEJA, [In] ODKHIEPFOPO<FELHHAAOOHO, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>?> HCMBKJGEJDJ, [In] DKMINHFJCNM<CGBGMGFBCKF<FELHHAAOOHO>> HLPJFACEODK, [In] ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> MGGFGIOGNEH, [In] DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> IDOOJPDGHEC, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> PHFELEEKDGE, [In] EPMCEGHJFLI HIFLBAGDJMA, [In] EPNHOMAJGDB DECIHJLJEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x200CF20", Offset = "0x200B520", VA = "0x18200CF20")]
	public static PAENECJPGGE ENFOKLPNHAF()
	{
		return default(PAENECJPGGE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DAOJKPLCGFI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct KDNEPNMOOHA : HBCEOLMEGPB<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>, ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x200C2E0", Offset = "0x200A8E0", VA = "0x18200C2E0")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x200C390", Offset = "0x200A990", VA = "0x18200C390", Slot = "4")]
		public CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> NCBCJMCCEMI(int PDMMEDBMFPP)
		{
			return default(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710")]
		public bool MHIIEADFOLL(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "5")]
		private bool FDEANLJDLEG(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x200C2D0", Offset = "0x200A8D0", VA = "0x18200C2D0", Slot = "6")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> IBABIBFGBBB(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct IJIMEOFADEG : DADBIIJMCDA<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>, ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x200BFB0", Offset = "0x200A5B0", VA = "0x18200BFB0")]
		public DKMINHFJCNM<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>> MPPANKFIKFM(int BINEEPCPHJL, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x200C030", Offset = "0x200A630", VA = "0x18200C030")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x200C0E0", Offset = "0x200A6E0", VA = "0x18200C0E0", Slot = "6")]
		public void OGDNFCCKKGC(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> EJHPODPBOEP, CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x200BFB0", Offset = "0x200A5B0", VA = "0x18200BFB0", Slot = "4")]
		private DKMINHFJCNM<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>> CAKFIFMJINE(int BINEEPCPHJL, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x200C020", Offset = "0x200A620", VA = "0x18200C020", Slot = "5")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> HLMHFOPCPID(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct JLFGOPHCPEG : HBCEOLMEGPB<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>, ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x200C1F0", Offset = "0x200A7F0", VA = "0x18200C1F0")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x200C2A0", Offset = "0x200A8A0", VA = "0x18200C2A0", Slot = "4")]
		public CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> NCBCJMCCEMI(int PDMMEDBMFPP)
		{
			return default(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710")]
		public bool MHIIEADFOLL(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "5")]
		private bool MJDIOBNFABL(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x200C1E0", Offset = "0x200A7E0", VA = "0x18200C1E0", Slot = "6")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> CLLDFMAMIFB(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct OBOOBEPBMID : DADBIIJMCDA<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>, ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x200CD30", Offset = "0x200B330", VA = "0x18200CD30")]
		public DKMINHFJCNM<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>> MPPANKFIKFM(int BINEEPCPHJL, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x200CDB0", Offset = "0x200B3B0", VA = "0x18200CDB0")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x200CE60", Offset = "0x200B460", VA = "0x18200CE60", Slot = "6")]
		public void OGDNFCCKKGC(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> EJHPODPBOEP, CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x200CD30", Offset = "0x200B330", VA = "0x18200CD30", Slot = "4")]
		private DKMINHFJCNM<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>> DCPPHIKEBCJ(int BINEEPCPHJL, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x200CDA0", Offset = "0x200B3A0", VA = "0x18200CDA0", Slot = "5")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DFGNIPAJKOA(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PDMMEDBMFPP, [In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct DONEACDEKKJ : HBCEOLMEGPB<CGBGMGFBCKF<HHDHBHHIDEB>, ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2005CA0", Offset = "0x20042A0", VA = "0x182005CA0")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(CGBGMGFBCKF<HHDHBHHIDEB> PDMMEDBMFPP, [In] ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2005D70", Offset = "0x2004370", VA = "0x182005D70", Slot = "4")]
		public CGBGMGFBCKF<HHDHBHHIDEB> NCBCJMCCEMI(int PDMMEDBMFPP)
		{
			return default(CGBGMGFBCKF<HHDHBHHIDEB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2005C10", Offset = "0x2004210", VA = "0x182005C10")]
		public bool MHIIEADFOLL(CGBGMGFBCKF<HHDHBHHIDEB> PDMMEDBMFPP, [In] ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2005C10", Offset = "0x2004210", VA = "0x182005C10", Slot = "5")]
		private bool BNENPHNBGIN(CGBGMGFBCKF<HHDHBHHIDEB> PDMMEDBMFPP, [In] ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2005C90", Offset = "0x2004290", VA = "0x182005C90", Slot = "6")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> CHENGHPPEEO(CGBGMGFBCKF<HHDHBHHIDEB> PDMMEDBMFPP, [In] ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct DLBJKAOBMNC : DADBIIJMCDA<CGBGMGFBCKF<HHDHBHHIDEB>, ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2005AC0", Offset = "0x20040C0", VA = "0x182005AC0")]
		public DKMINHFJCNM<CGBGMGFBCKF<HHDHBHHIDEB>> MPPANKFIKFM(int BINEEPCPHJL, [In] ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<CGBGMGFBCKF<HHDHBHHIDEB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x20059F0", Offset = "0x2003FF0", VA = "0x1820059F0")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(CGBGMGFBCKF<HHDHBHHIDEB> PDMMEDBMFPP, [In] ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2005B30", Offset = "0x2004130", VA = "0x182005B30", Slot = "6")]
		public void OGDNFCCKKGC(CGBGMGFBCKF<HHDHBHHIDEB> PDMMEDBMFPP, ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> EJHPODPBOEP, CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2005AC0", Offset = "0x20040C0", VA = "0x182005AC0", Slot = "4")]
		private DKMINHFJCNM<CGBGMGFBCKF<HHDHBHHIDEB>> LNHOBJAALFI(int BINEEPCPHJL, [In] ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<CGBGMGFBCKF<HHDHBHHIDEB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x20059E0", Offset = "0x2003FE0", VA = "0x1820059E0", Slot = "5")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DKNHIJBBABF(CGBGMGFBCKF<HHDHBHHIDEB> PDMMEDBMFPP, [In] ODKHIEPFOPO<HHDHBHHIDEB, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>?> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct MHCMBMHJBGD : HBCEOLMEGPB<int, DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x200C960", Offset = "0x200AF60", VA = "0x18200C960")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x13D0EF0", Offset = "0x13CF4F0", VA = "0x1813D0EF0", Slot = "4")]
		public int NCBCJMCCEMI(int PDMMEDBMFPP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710")]
		public bool MHIIEADFOLL(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "5")]
		private bool FNLDODHAJND(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x200C950", Offset = "0x200AF50", VA = "0x18200C950", Slot = "6")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> KLMKMHHLGBK(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct FNKLBMAJAHD : DADBIIJMCDA<int, DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x200B7D0", Offset = "0x2009DD0", VA = "0x18200B7D0")]
		public DKMINHFJCNM<int> MPPANKFIKFM(int BINEEPCPHJL, [In] DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x200B840", Offset = "0x2009E40", VA = "0x18200B840")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x200B8F0", Offset = "0x2009EF0", VA = "0x18200B8F0", Slot = "6")]
		public void OGDNFCCKKGC(int PDMMEDBMFPP, DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> EJHPODPBOEP, CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x200B7D0", Offset = "0x2009DD0", VA = "0x18200B7D0", Slot = "4")]
		private DKMINHFJCNM<int> DDGPICHELLI(int BINEEPCPHJL, [In] DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x200B8E0", Offset = "0x2009EE0", VA = "0x18200B8E0", Slot = "5")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> NBKHPAHMNBB(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> VariableId, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<DAINKMIDKHH>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct CECALKHNHNH : HBCEOLMEGPB<int, DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2002E70", Offset = "0x2001470", VA = "0x182002E70")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x13D0EF0", Offset = "0x13CF4F0", VA = "0x1813D0EF0", Slot = "4")]
		public int NCBCJMCCEMI(int PDMMEDBMFPP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710")]
		public bool MHIIEADFOLL(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "5")]
		private bool PONOIHMNOFF(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2002E60", Offset = "0x2001460", VA = "0x182002E60", Slot = "6")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> HPCPKPKDGPD(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct DKFFIMOJJPN : DADBIIJMCDA<int, DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2005880", Offset = "0x2003E80", VA = "0x182005880")]
		public DKMINHFJCNM<int> MPPANKFIKFM(int BINEEPCPHJL, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x20057D0", Offset = "0x2003DD0", VA = "0x1820057D0")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x20058F0", Offset = "0x2003EF0", VA = "0x1820058F0", Slot = "6")]
		public void OGDNFCCKKGC(int PDMMEDBMFPP, DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP, CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2005880", Offset = "0x2003E80", VA = "0x182005880", Slot = "4")]
		private DKMINHFJCNM<int> LOOGBAIGOAN(int BINEEPCPHJL, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2005870", Offset = "0x2003E70", VA = "0x182005870", Slot = "5")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LOINCNKIPIN(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct PCNMKBAFEOM : HBCEOLMEGPB<int, DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x200DD50", Offset = "0x200C350", VA = "0x18200DD50")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x13D0EF0", Offset = "0x13CF4F0", VA = "0x1813D0EF0", Slot = "4")]
		public int NCBCJMCCEMI(int PDMMEDBMFPP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710")]
		public bool MHIIEADFOLL(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "5")]
		private bool PONOIHMNOFF(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x200DD40", Offset = "0x200C340", VA = "0x18200DD40", Slot = "6")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> HPCPKPKDGPD(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct PLJEJHDKOFB : DADBIIJMCDA<int, DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x200DEA0", Offset = "0x200C4A0", VA = "0x18200DEA0")]
		public DKMINHFJCNM<int> MPPANKFIKFM(int BINEEPCPHJL, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x200DDF0", Offset = "0x200C3F0", VA = "0x18200DDF0")]
		public CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x200DF10", Offset = "0x200C510", VA = "0x18200DF10", Slot = "6")]
		public void OGDNFCCKKGC(int PDMMEDBMFPP, DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP, CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x200DEA0", Offset = "0x200C4A0", VA = "0x18200DEA0", Slot = "4")]
		private DKMINHFJCNM<int> LOOGBAIGOAN(int BINEEPCPHJL, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(DKMINHFJCNM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x200DE90", Offset = "0x200C490", VA = "0x18200DE90", Slot = "5")]
		private CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LOINCNKIPIN(int PDMMEDBMFPP, [In] DKMINHFJCNM<(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> Target, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> ByteCodeWriteLocation)> EJHPODPBOEP)
		{
			return default(CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct JKJFECNOBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> DPBMENJNEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool PMOHEFNCBMP;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x10FFF00", Offset = "0x10FE500", VA = "0x1810FFF00")]
		public JKJFECNOBDI(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH, bool DPIJCCHJBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x200C1D0", Offset = "0x200A7D0", VA = "0x18200C1D0")]
		public void FPPGGEMJOOL([Out] CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH, [Out] bool DPIJCCHJBKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct CKGODCPJIEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CGBGMGFBCKF<HHDHBHHIDEB> KNIKGKHCEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> DPBMENJNEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool PMOHEFNCBMP;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2002F40", Offset = "0x2001540", VA = "0x182002F40")]
		public CKGODCPJIEJ(CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH, bool DPIJCCHJBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2002F10", Offset = "0x2001510", VA = "0x182002F10")]
		public void FPPGGEMJOOL([Out] CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH, [Out] bool DPIJCCHJBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2002F20", Offset = "0x2001520", VA = "0x182002F20")]
		public void FPPGGEMJOOL([Out] CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH, [Out] CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM, [Out] bool DPIJCCHJBKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct IKIAPIEEANM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CGBGMGFBCKF<HHDHBHHIDEB> KNIKGKHCEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> DPBMENJNEFE;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
		public IKIAPIEEANM(CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x200C1A0", Offset = "0x200A7A0", VA = "0x18200C1A0")]
		public void FPPGGEMJOOL([Out] CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH, [Out] CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x20044F0", Offset = "0x2002AF0", VA = "0x1820044F0")]
	public static void IHOPKBJIMEI(this PAENECJPGGE HLIDMKMINHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2003E00", Offset = "0x2002400", VA = "0x182003E00")]
	public static void FMMHHCBMMNM(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> KNJHDMNCCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x20034B0", Offset = "0x2001AB0", VA = "0x1820034B0")]
	public static void CGOFAKAGOCE(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> KNJHDMNCCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2005230", Offset = "0x2003830", VA = "0x182005230")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>? NECPKCKDBOO([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2005460", Offset = "0x2003A60", VA = "0x182005460")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> ODMHFJLDOLA([In] this PAENECJPGGE HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20041B0", Offset = "0x20027B0", VA = "0x1820041B0")]
	private static void HNBCGJJDFOM(this PAENECJPGGE HLIDMKMINHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2004D90", Offset = "0x2003390", VA = "0x182004D90")]
	private static CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>? KMPIHEFDOJC([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x20050C0", Offset = "0x20036C0", VA = "0x1820050C0")]
	public static void NDFDAAOELKE(this PAENECJPGGE HLIDMKMINHN, [In] DKMINHFJCNM<JFFKPPPAMLC> EFCFJIMBPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2003250", Offset = "0x2001850", VA = "0x182003250")]
	public static IJGDLBAAJPJ.OBCGEIAFMJH BLDOKINIKFI([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH)
	{
		return default(IJGDLBAAJPJ.OBCGEIAFMJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x20040C0", Offset = "0x20026C0", VA = "0x1820040C0")]
	public static JJIKHNBJAJG<byte> GPNBPBNDAOB([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH)
	{
		return default(JJIKHNBJAJG<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2003350", Offset = "0x2001950", VA = "0x182003350")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> BMDGKOIOALB([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2004850", Offset = "0x2002E50", VA = "0x182004850")]
	public static DLDLNHCGMKC IOBIIMIOIGE([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x29E2870", Offset = "0x29E0E70", VA = "0x1829E2870")]
	private static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> DDGPNABMCNL<TMJoin>(this PAENECJPGGE HLIDMKMINHN, IJGDLBAAJPJ.OBCGEIAFMJH PAJFMBKKKEO, CGBGMGFBCKF<TMJoin> MFNKONDKBPB) where TMJoin : IJGDLBAAJPJ.FPKLLBHOFOE
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2004940", Offset = "0x2002F40", VA = "0x182004940")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> JBELPCAKGJF(this PAENECJPGGE HLIDMKMINHN, bool PKDNAJDAIFN)
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2003180", Offset = "0x2001780", VA = "0x182003180")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> AOHNEOJIKEN(this PAENECJPGGE HLIDMKMINHN, JJIKHNBJAJG<byte> LKFNEINGOFE)
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2004ED0", Offset = "0x20034D0", VA = "0x182004ED0")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> LFIJBBADHEE(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> MHJMPOLCNNC)
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x20054C0", Offset = "0x2003AC0", VA = "0x1820054C0")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> OEGMJCPDCOA(this PAENECJPGGE HLIDMKMINHN, int APJPIEIELEM)
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2004CD0", Offset = "0x20032D0", VA = "0x182004CD0")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> KAJNGHGEADP(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KODIDLJDOEI)
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x29E40A0", Offset = "0x29E26A0", VA = "0x1829E40A0")]
	private static CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ> OPEEEHPDHEL<TMJoin>(this PAENECJPGGE HLIDMKMINHN, NOAHKNCJLAI.EIHEODNPAMA PAJFMBKKKEO, CGBGMGFBCKF<TMJoin> MFNKONDKBPB) where TMJoin : NOAHKNCJLAI.BDNFENOOLEO
	{
		return default(CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x20052F0", Offset = "0x20038F0", VA = "0x1820052F0")]
	public static CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ> NHHOBKMGOGE(this PAENECJPGGE HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2005540", Offset = "0x2003B40", VA = "0x182005540")]
	public static CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ> OIJGMHGICCP(this PAENECJPGGE HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x20032D0", Offset = "0x20018D0", VA = "0x1820032D0")]
	public static CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ> BLHJKGEIELN(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> AFBEHNIEBLO)
	{
		return default(CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2004320", Offset = "0x2002920", VA = "0x182004320")]
	public static CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ> HNNCHEBKIFC(this PAENECJPGGE HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2003210", Offset = "0x2001810", VA = "0x182003210")]
	public static CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ> BKNLBDDJLEN(this PAENECJPGGE HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2004E50", Offset = "0x2003450", VA = "0x182004E50")]
	public static GOBCIPBHKBL.AADOJCPHCNN LEJJNDKDCOA([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> CIBCOBMOKDK)
	{
		return default(GOBCIPBHKBL.AADOJCPHCNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2004D50", Offset = "0x2003350", VA = "0x182004D50")]
	public static FKJDCMCPGGC<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>, HCKNJKAAMFI<GOBCIPBHKBL.NDMHLBDMIDJ>> KCEJJMCNBEO([In] this PAENECJPGGE HLIDMKMINHN)
	{
		return default(FKJDCMCPGGC<CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>, HCKNJKAAMFI<GOBCIPBHKBL.NDMHLBDMIDJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2003760", Offset = "0x2001D60", VA = "0x182003760")]
	public static CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> EFDKDECPBNP([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> CIBCOBMOKDK)
	{
		return default(CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2003CB0", Offset = "0x20022B0", VA = "0x182003CB0")]
	public static GOBCIPBHKBL.NPINAKBIGBK FHAEPIMAPBG([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PMHDNGLAKPF)
	{
		return default(GOBCIPBHKBL.NPINAKBIGBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2003940", Offset = "0x2001F40", VA = "0x182003940")]
	public static GOBCIPBHKBL.NPINAKBIGBK EKEBBBDHOGI(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PMHDNGLAKPF)
	{
		return default(GOBCIPBHKBL.NPINAKBIGBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x29E2920", Offset = "0x29E0F20", VA = "0x1829E2920")]
	private static CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> DHPOKDBPNBE<TMJoin>(this PAENECJPGGE HLIDMKMINHN, GOBCIPBHKBL.AADOJCPHCNN PAJFMBKKKEO, CGBGMGFBCKF<TMJoin> MFNKONDKBPB) where TMJoin : GOBCIPBHKBL.ONKKBDKCDLG
	{
		return default(CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2003AE0", Offset = "0x20020E0", VA = "0x182003AE0")]
	public static (CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>) FGMJOOOIPPA(this PAENECJPGGE HLIDMKMINHN)
	{
		return default((CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2004B10", Offset = "0x2003110", VA = "0x182004B10")]
	public static (CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>) JNLBAMMFCEA(this PAENECJPGGE HLIDMKMINHN)
	{
		return default((CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2005580", Offset = "0x2003B80", VA = "0x182005580")]
	public static CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> PHCFNNNGELK(this PAENECJPGGE HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x20047C0", Offset = "0x2002DC0", VA = "0x1820047C0")]
	public static void IMBBPMCLDEC(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ> PMHDNGLAKPF, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> MMPCKOHOIKD, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>> FGFGOGOIIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x29E29C0", Offset = "0x29E0FC0", VA = "0x1829E29C0")]
	public static JKJFECNOBDI EIKKPOFOLIK<TDeps, TStateSys>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM) where TDeps : CLFONDNFOMB<TStateSys>
	{
		return default(JKJFECNOBDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29E3D00", Offset = "0x29E2300", VA = "0x1829E3D00")]
	public static CKGODCPJIEJ HJOPNMCPNMM<TDeps, TStateSys>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int AFHHNDIHHIG) where TDeps : CLFONDNFOMB<TStateSys>
	{
		return default(CKGODCPJIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x29E38C0", Offset = "0x29E1EC0", VA = "0x1829E38C0")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>? HJNKMDEPJAF<TDeps, TStateSys>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, [In] ReadOnlySpan<int> ANCKMAMGCDG, [In] Span<IKIAPIEEANM> NCFLDICMIEN) where TDeps : CLFONDNFOMB<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29E22A0", Offset = "0x29E08A0", VA = "0x1829E22A0")]
	public static CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ> CPOPADEDIIP<TDeps, TStateSys>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA) where TDeps : CLFONDNFOMB<TStateSys>
	{
		return default(CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2003670", Offset = "0x2001C70", VA = "0x182003670")]
	public static LNIKAMGIKOC.CJMDEHGGMJL EDIJGAEMBKF([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DAIJJLLIENA)
	{
		return default(LNIKAMGIKOC.CJMDEHGGMJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2003FD0", Offset = "0x20025D0", VA = "0x182003FD0")]
	public static LNIKAMGIKOC.PPKEOGACOBH GLEOHIEPGDE([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DAIJJLLIENA)
	{
		return default(LNIKAMGIKOC.PPKEOGACOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2003580", Offset = "0x2001B80", VA = "0x182003580")]
	public static LNIKAMGIKOC.HPGOJOIMODI CPCPJJOJFFH([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DAIJJLLIENA)
	{
		return default(LNIKAMGIKOC.HPGOJOIMODI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2004360", Offset = "0x2002960", VA = "0x182004360")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> IFNIOLFOPLM(this PAENECJPGGE HLIDMKMINHN, int? AMDLGEHEPLM, string GJEDHMJMNJA)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2003020", Offset = "0x2001620", VA = "0x182003020")]
	public static LNIKAMGIKOC.JJGKFPHDPDN ACHEDKNMOKK([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DAIJJLLIENA)
	{
		return default(LNIKAMGIKOC.JJGKFPHDPDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2003110", Offset = "0x2001710", VA = "0x182003110")]
	public static LNIKAMGIKOC.BABFNMMNMOL AEHJGKALEOM([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DAIJJLLIENA)
	{
		return default(LNIKAMGIKOC.BABFNMMNMOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2003440", Offset = "0x2001A40", VA = "0x182003440")]
	public static int? CFDLNDKPHCN([In] this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DAIJJLLIENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29E3FA0", Offset = "0x29E25A0", VA = "0x1829E3FA0")]
	private static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KEPAPFBDIAP<TMJoin>(this PAENECJPGGE HLIDMKMINHN, int? AMDLGEHEPLM, LNIKAMGIKOC.BABFNMMNMOL PAJFMBKKKEO, CGBGMGFBCKF<TMJoin> MFNKONDKBPB) where TMJoin : LNIKAMGIKOC.FDGJAAJPLKO
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2005010", Offset = "0x2003610", VA = "0x182005010")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> MOHJFAGECNO(this PAENECJPGGE HLIDMKMINHN, int? AMDLGEHEPLM, CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> CIBCOBMOKDK, int PDMMEDBMFPP)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2004F50", Offset = "0x2003550", VA = "0x182004F50")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LHAAAFFJAEN(this PAENECJPGGE HLIDMKMINHN, int? AMDLGEHEPLM)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20049C0", Offset = "0x2002FC0", VA = "0x1820049C0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> JGCGKPDKBHN(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>? PKGNOOHLCPG, int? AMDLGEHEPLM)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2003A50", Offset = "0x2002050", VA = "0x182003A50")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ENMNEEPENDP(this PAENECJPGGE HLIDMKMINHN, int? AMDLGEHEPLM, int PDMMEDBMFPP)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2004FB0", Offset = "0x20035B0", VA = "0x182004FB0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LKEHIEMKHHN(this PAENECJPGGE HLIDMKMINHN, int? AMDLGEHEPLM)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2003E90", Offset = "0x2002490", VA = "0x182003E90")]
	public static void GCOCIKLGGOB(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KODIDLJDOEI, CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> CIBCOBMOKDK, int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2005330", Offset = "0x2003930", VA = "0x182005330")]
	public static void NOBDONBAKLK(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KODIDLJDOEI, int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2002F50", Offset = "0x2001550", VA = "0x182002F50")]
	public static void ABIHAGAGENI(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KODIDLJDOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x20039C0", Offset = "0x2001FC0", VA = "0x1820039C0")]
	public static void EMFDJHDJAAP(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> PABFDMCLKCE, CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> LMLKMOANPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2003D30", Offset = "0x2002330", VA = "0x182003D30")]
	public static void FHDKMGLHBLH(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KODIDLJDOEI, CGBGMGFBCKF<BCJLFHBLKEN<LMIFMOHKCJH>> PMGIDIDGAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29E37F0", Offset = "0x29E1DF0", VA = "0x1829E37F0")]
	public static void GCIOAIDMEMN<M>(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KODIDLJDOEI, CGBGMGFBCKF<BCJLFHBLKEN<IBENENKEOAE<M>>> PMGIDIDGAGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CLFONDNFOMB<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CGBGMGFBCKF<JGEDDHMBOAG> BIFCANEFICN(TStateSys JJIILPFEIBK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGBGMGFBCKF<JGEDDHMBOAG> BFBAFCLCMCB(TStateSys JJIILPFEIBK);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CGBGMGFBCKF<JGEDDHMBOAG> FJFEKCMIFBC(TStateSys JJIILPFEIBK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CGBGMGFBCKF<JGEDDHMBOAG> PKKAEEICBLA(TStateSys JJIILPFEIBK);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ> PGNBJFIIPOM(TStateSys JJIILPFEIBK, PAENECJPGGE JHKHJGNDMPM, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> IHABPDNPOAM(TStateSys JJIILPFEIBK, PAENECJPGGE JHKHJGNDMPM, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BFPKKLJCNNM(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CGBGMGFBCKF<FELHHAAOOHO> NGIKPHAHLKN(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM, int GMIICDFKBBD);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HEFHKFLFIML HCJKHDFEMOG(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NGDIBJIEDHN(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int OOMENIIFMGA(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JJIKHNBJAJG<byte> DANJKIBCGOP(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(JJIKHNBJAJG<byte>, CGBGMGFBCKF<JGEDDHMBOAG>) AOFDLODNAEF(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int PKPMMEIEGJA(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CGBGMGFBCKF<HHDHBHHIDEB> NPPDKAJEDBO(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA, int AFHHNDIHHIG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CGBGMGFBCKF<HHDHBHHIDEB> EFIJEDKOGLF(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int AFHHNDIHHIG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int KFCNEAKGFBN(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? CBNEFIANLMD(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, int PDMMEDBMFPP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int OJGNFOCEFND(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? DCCALJFAGNK(TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, int PDMMEDBMFPP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EJBCBIICDPF
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A39430", Offset = "0x2A37A30", VA = "0x182A39430")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA?> NKHHLPBOFIK<T, TOpInput, TOpOutput>(this PAENECJPGGE HLIDMKMINHN, T OIMGCNDKIAD, T LMBIFCGLAFC, int KDBNFFBPKJF, IntPtr IEIDMMIDFNN)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A39090", Offset = "0x2A37690", VA = "0x182A39090")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA?> MPEEIBIKHCF<T, TOpInput, TOpOutput>(this PAENECJPGGE HLIDMKMINHN, T OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC, int KDBNFFBPKJF, IntPtr IEIDMMIDFNN)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A39F40", Offset = "0x2A38540", VA = "0x182A39F40")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA?> OMOKGAOBLNF<TOpInput, TOpOutput>(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC, int KDBNFFBPKJF, IntPtr IEIDMMIDFNN)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x200AD70", Offset = "0x2009370", VA = "0x18200AD70")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> PEAEGKBFCBI(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2008D60", Offset = "0x2007360", VA = "0x182008D60")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> HAPIFJFDKMJ(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2008830", Offset = "0x2006E30", VA = "0x182008830")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> FPMPIELIJLK(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2008A70", Offset = "0x2007070", VA = "0x182008A70")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> GKDBCMAHMHO(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x20066E0", Offset = "0x2004CE0", VA = "0x1820066E0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> BIOGKEPGLPC(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x200AF70", Offset = "0x2009570", VA = "0x18200AF70")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> PKNFCJNJFBC(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2009070", Offset = "0x2007670", VA = "0x182009070")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> HIBPGBOJKFO(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x200A600", Offset = "0x2008C00", VA = "0x18200A600")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> NABONLDCJPH(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x200A4C0", Offset = "0x2008AC0", VA = "0x18200A4C0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> MPJCPOIJMOI(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2009F00", Offset = "0x2008500", VA = "0x182009F00")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LBEHNNEJIKP(this PAENECJPGGE HLIDMKMINHN, int OIMGCNDKIAD, int LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2008430", Offset = "0x2006A30", VA = "0x182008430")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> FELNNFPAIGM(this PAENECJPGGE HLIDMKMINHN, int OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2005EA0", Offset = "0x20044A0", VA = "0x182005EA0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> AEHNINMEJCN(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2009620", Offset = "0x2007C20", VA = "0x182009620")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> IPPAJIPPDCD(this PAENECJPGGE HLIDMKMINHN, float OIMGCNDKIAD, float LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2007820", Offset = "0x2005E20", VA = "0x182007820")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DCBFNDMFGPK(this PAENECJPGGE HLIDMKMINHN, float OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x20092A0", Offset = "0x20078A0", VA = "0x1820092A0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> IANLCGJBPBO(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x20089F0", Offset = "0x2006FF0", VA = "0x1820089F0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> GIOBMPIAOOI(this PAENECJPGGE HLIDMKMINHN, int OIMGCNDKIAD, int LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x200A220", Offset = "0x2008820", VA = "0x18200A220")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> MBCDBJLJLKA(this PAENECJPGGE HLIDMKMINHN, int OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x200AE70", Offset = "0x2009470", VA = "0x18200AE70")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> PFINABNIODH(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2008970", Offset = "0x2006F70", VA = "0x182008970")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> GHLDCNLIPCE(this PAENECJPGGE HLIDMKMINHN, float OIMGCNDKIAD, float LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2006660", Offset = "0x2004C60", VA = "0x182006660")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> BIIEMIDGGIG(this PAENECJPGGE HLIDMKMINHN, float OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2007950", Offset = "0x2005F50", VA = "0x182007950")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DHNHJLOMMLB(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x20083B0", Offset = "0x20069B0", VA = "0x1820083B0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> FAJOKNKHILK(this PAENECJPGGE HLIDMKMINHN, int OIMGCNDKIAD, int LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2009A20", Offset = "0x2008020", VA = "0x182009A20")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> JLFLHLCMABP(this PAENECJPGGE HLIDMKMINHN, int OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x200A440", Offset = "0x2008A40", VA = "0x18200A440")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> MNCOBFMBIGB(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2009180", Offset = "0x2007780", VA = "0x182009180")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> HJNNHFJGINB(this PAENECJPGGE HLIDMKMINHN, float OIMGCNDKIAD, float LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x20093E0", Offset = "0x20079E0", VA = "0x1820093E0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> IBFCAEMABFA(this PAENECJPGGE HLIDMKMINHN, float OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x200B0B0", Offset = "0x20096B0", VA = "0x18200B0B0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> PMMDPJMCLGA(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2006C90", Offset = "0x2005290", VA = "0x182006C90")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> CEOEOAEBGGG(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2008550", Offset = "0x2006B50", VA = "0x182008550")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> FHKLNGEALEB(this PAENECJPGGE HLIDMKMINHN, int DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2009200", Offset = "0x2007800", VA = "0x182009200")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> HKHGODIPPLI(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x200A840", Offset = "0x2008E40", VA = "0x18200A840")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> NHCILKNKHCC(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> GOFAFFCNMMH)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x20081F0", Offset = "0x20067F0", VA = "0x1820081F0")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> EMLCJCGDJFF(this PAENECJPGGE HLIDMKMINHN, int DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2009580", Offset = "0x2007B80", VA = "0x182009580")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> IPJDPAHKNEN(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2007B10", Offset = "0x2006110", VA = "0x182007B10")]
	public static (CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>) EBOCENNMHNF(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<OAJKANAHJEC> IHPACDMFAAJ, [In] ReadOnlySpan<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> NKMAJMKBAIK, [In] ReadOnlySpan<int?> CNLAKCOKKPN, [In] Span<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> MNPJKLIMNLC)
	{
		return default((CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2006E40", Offset = "0x2005440", VA = "0x182006E40")]
	public static (CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>) CGJAHFFNGFF(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IMGLHGEIFKP> DGEHLOKLPFG, [In] ReadOnlySpan<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> NKMAJMKBAIK, [In] ReadOnlySpan<int?> CNLAKCOKKPN, [In] Span<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> MNPJKLIMNLC)
	{
		return default((CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A38BA0", Offset = "0x2A371A0", VA = "0x182A38BA0")]
	public static (CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<JGEDDHMBOAG>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<TMarker>>, CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>) JGFLNEILNAL<TMarker>(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<JGEDDHMBOAG> GBBEJPHDCLP, [In] ReadOnlySpan<byte> MMDLBEBNCGC)
	{
		return default((CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<BCJLFHBLKEN<JGEDDHMBOAG>>, CGBGMGFBCKF<BCJLFHBLKEN<BEANOHAOBEL>>, CGBGMGFBCKF<BCJLFHBLKEN<TMarker>>, CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2006120", Offset = "0x2004720", VA = "0x182006120")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> AIBHPJPABGF(this PAENECJPGGE HLIDMKMINHN, int HHNPHHDBIPA, [Optional] CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>? AKJLINGBOGD)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x20073A0", Offset = "0x20059A0", VA = "0x1820073A0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> CHIEJKDJJNE(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> HHNPHHDBIPA, [Optional] CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>? AKJLINGBOGD)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2009E10", Offset = "0x2008410", VA = "0x182009E10")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KPKEBFDKKMP(this PAENECJPGGE HLIDMKMINHN, [In] ReadOnlySpan<byte> HHNPHHDBIPA, [Optional] CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>? AKJLINGBOGD)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2009460", Offset = "0x2007A60", VA = "0x182009460")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> IEDOHHEBHDN(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> HHNPHHDBIPA, int LPKLLJKOBNO, [Optional] CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>? AKJLINGBOGD)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2006800", Offset = "0x2004E00", VA = "0x182006800")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> CBENIAAMAGN(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x200AA00", Offset = "0x2009000", VA = "0x18200AA00")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OCLNNFDAHKC(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2005FE0", Offset = "0x20045E0", VA = "0x182005FE0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> AGGJLAPNJFM(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2006320", Offset = "0x2004920", VA = "0x182006320")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> APLAGHCLNFL(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2006410", Offset = "0x2004A10", VA = "0x182006410")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> BDKPMCPOPOH(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x20061E0", Offset = "0x20047E0", VA = "0x1820061E0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> AKOMOGFCHLF(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x200A3C0", Offset = "0x20089C0", VA = "0x18200A3C0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> MHOFOCBPOFL(this PAENECJPGGE HLIDMKMINHN, int OIMGCNDKIAD, int LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2007680", Offset = "0x2005C80", VA = "0x182007680")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> CPBDGFILOOK(this PAENECJPGGE HLIDMKMINHN, int OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x200AEF0", Offset = "0x20094F0", VA = "0x18200AEF0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> PJNIIADPPDA(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OIMGCNDKIAD, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMBIFCGLAFC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2007490", Offset = "0x2005A90", VA = "0x182007490")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> CHJMLDNJPHL(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2009CE0", Offset = "0x20082E0", VA = "0x182009CE0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KPIGDCGJECP(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x20080B0", Offset = "0x20066B0", VA = "0x1820080B0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> EIKJENCIKDD(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x20072B0", Offset = "0x20058B0", VA = "0x1820072B0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> CGPAPDCAGEJ(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x200A2A0", Offset = "0x20088A0", VA = "0x18200A2A0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> MFGGGPMJKAA(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x20085D0", Offset = "0x2006BD0", VA = "0x1820085D0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> FNCIJGJILDF(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2009160", Offset = "0x2007760", VA = "0x182009160")]
	public static CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>> HJFMNHPPLFF(this PAENECJPGGE HLIDMKMINHN)
	{
		return default(CGBGMGFBCKF<BCJLFHBLKEN<BCJLFHBLKEN<GFKIGLAKHAM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2008F70", Offset = "0x2007570", VA = "0x182008F70")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> HHJJMFFAJOP(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2009BC0", Offset = "0x20081C0", VA = "0x182009BC0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KLHAMIAJFLA(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x200AC30", Offset = "0x2009230", VA = "0x18200AC30")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OKHGLDEFNMN(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x200A130", Offset = "0x2008730", VA = "0x18200A130")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LMCIDNBEGNH(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2007700", Offset = "0x2005D00", VA = "0x182007700")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DAABLLHPPDL(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2008270", Offset = "0x2006870", VA = "0x182008270")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ENCAGIJBDFI(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2008C60", Offset = "0x2007260", VA = "0x182008C60")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> GOKJBNPFOPH(this PAENECJPGGE HLIDMKMINHN, int DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x200AB20", Offset = "0x2009120", VA = "0x18200AB20")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OJKBABFNBAM(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DMNGPNKHPKF)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x200A9F0", Offset = "0x2008FF0", VA = "0x18200A9F0")]
	public static void NOAEIFJOKPK(this PAENECJPGGE HLIDMKMINHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2008B60", Offset = "0x2007160", VA = "0x182008B60")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> GOFNMOEEODJ(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, float ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x200A720", Offset = "0x2008D20", VA = "0x18200A720")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> NAEACDPDLPK(this PAENECJPGGE HLIDMKMINHN, float ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x20079D0", Offset = "0x2005FD0", VA = "0x1820079D0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> DLGAGFPFMMH(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2008E80", Offset = "0x2007480", VA = "0x182008E80")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> HGKODKMDLML(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2009AA0", Offset = "0x20080A0", VA = "0x182009AA0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> KFEPHDGGFIK(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2009FF0", Offset = "0x20085F0", VA = "0x182009FF0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LJKDDINEOHG(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2006900", Offset = "0x2004F00", VA = "0x182006900")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> CEMJGFPANAP(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> BCKNKNAMGEI, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> PICHADABEPC)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2007590", Offset = "0x2005B90", VA = "0x182007590")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> COIFKNGAEOI(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, int ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2008710", Offset = "0x2006D10", VA = "0x182008710")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> FNHIBKPJLNA(this PAENECJPGGE HLIDMKMINHN, int ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2007F70", Offset = "0x2006570", VA = "0x182007F70")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> EEKNGPNLIFA(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ELPAIKNHOIP, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> ANCDOEMAKKO)
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2A38600", Offset = "0x2A36C00", VA = "0x182A38600")]
	public static void ENJAFDCFMBI<TDeps, TState>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TState NEIJPCGNELF, CGBGMGFBCKF<OAJKANAHJEC> IHPACDMFAAJ, [In] ReadOnlySpan<CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>> FPCPKJHJHKL, [In] ReadOnlySpan<int?> CNLAKCOKKPN, [In] Span<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> MNPJKLIMNLC, [In] Span<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> DKPKOGHIGAD, [In] ReadOnlySpan<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>?> ADICAGLDLHD) where TDeps : notnull, CLFONDNFOMB<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2A373E0", Offset = "0x2A359E0", VA = "0x182A373E0")]
	public static void AFDKHHICCHE<TDeps, TState>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TState NEIJPCGNELF, CGBGMGFBCKF<IMGLHGEIFKP> ILHEMCJEFIG, [In] ReadOnlySpan<CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>> PJLPCODDHON, [In] ReadOnlySpan<int?> CNLAKCOKKPN, [In] Span<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> MNPJKLIMNLC, [In] Span<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>> DKPKOGHIGAD, [In] ReadOnlySpan<CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>?> ADICAGLDLHD) where TDeps : notnull, CLFONDNFOMB<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2A38EB0", Offset = "0x2A374B0", VA = "0x182A38EB0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> LPKFBEHMNPC<TDeps, TState>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TState NEIJPCGNELF, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> PKGNOOHLCPG, [Optional] CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>? AKJLINGBOGD) where TDeps : notnull, CLFONDNFOMB<TState> where TState : notnull
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2A39AE0", Offset = "0x2A380E0", VA = "0x182A39AE0")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OJFJIEBLKHN<TDeps, TState>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TState NEIJPCGNELF, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> AFBEHNIEBLO, [Optional] CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>? AKJLINGBOGD) where TDeps : notnull, CLFONDNFOMB<TState> where TState : notnull
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2A383D0", Offset = "0x2A369D0", VA = "0x182A383D0")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> DGDHCEPKGKL<TDeps, TStateSys>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TStateSys JJIILPFEIBK) where TDeps : notnull, CLFONDNFOMB<TStateSys> where TStateSys : notnull
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2A38CA0", Offset = "0x2A372A0", VA = "0x182A38CA0")]
	public static CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ> JPPOMGCLIHN<TDeps, TStateSys>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TStateSys JJIILPFEIBK) where TDeps : notnull, CLFONDNFOMB<TStateSys> where TStateSys : notnull
	{
		return default(CGBGMGFBCKF<NOAHKNCJLAI.GJBLKCDEMPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2006530", Offset = "0x2004B30", VA = "0x182006530")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> BIHNLGFJKEF(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> ANNBLLDPMID, IntPtr HCDOJGODMPB, IntPtr OPCPADOLMAP)
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2009720", Offset = "0x2007D20", VA = "0x182009720")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> JHAMCCAHFMJ(this PAENECJPGGE HLIDMKMINHN, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> ANDAFILHAIA, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> CEOAPGJKMAO, IntPtr BJGNJCMCJHO, IntPtr JIONIDKDBOC, IntPtr NKCIPNOGFDI, bool ADDIHJPJNAN)
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2A37980", Offset = "0x2A35F80", VA = "0x182A37980")]
	public static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> CLLLAMIHKMD<TDeps, TState>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TState NEIJPCGNELF, CGBGMGFBCKF<OAJKANAHJEC> BKODOFEPMIO, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> ANDAFILHAIA, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> CEOAPGJKMAO, int? KOGHNDMDMCN, [Optional] IntPtr JCAFBBLJMPB) where TDeps : notnull, CLFONDNFOMB<TState> where TState : notnull
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2A37B90", Offset = "0x2A36190", VA = "0x182A37B90")]
	private static CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> CLLLAMIHKMD<TDeps, TState>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TState NEIJPCGNELF, CGBGMGFBCKF<OAJKANAHJEC> BKODOFEPMIO, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> ANDAFILHAIA, CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM> CEOAPGJKMAO, int? KOGHNDMDMCN) where TDeps : notnull, CLFONDNFOMB<TState> where TState : notnull
	{
		return default(CGBGMGFBCKF<IJGDLBAAJPJ.PHJDGODBGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2A39730", Offset = "0x2A37D30", VA = "0x182A39730")]
	public static CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> OANHJGGMAJE<TDeps, TState>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TState NEIJPCGNELF, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA> HHNPHHDBIPA, CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>? AKJLINGBOGD) where TDeps : notnull, CLFONDNFOMB<TState> where TState : notnull
	{
		return default(CGBGMGFBCKF<LNIKAMGIKOC.JJEPACNOMPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2A3A0B0", Offset = "0x2A386B0", VA = "0x182A3A0B0")]
	public static void PIJBLNODFOJ<TDeps, TState>(this PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TState NEIJPCGNELF, int PLFDEDJLDME) where TDeps : notnull, CLFONDNFOMB<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct FCOFEDFPMFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> DELGJGKOBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> ELKAOJLBDIF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
	public FCOFEDFPMFK(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> EHKAAGOKLFO, CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> JEBODIEKKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x200B560", Offset = "0x2009B60", VA = "0x18200B560")]
	public static FCOFEDFPMFK ENFOKLPNHAF(CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>> EHKAAGOKLFO)
	{
		return default(FCOFEDFPMFK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct LNIKAMGIKOC
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class JJIAHOGHPKB : FDGJAAJPLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct CJMDEHGGMJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> LECJKONLOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int MIMJDCDEIKK;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
		public CJMDEHGGMJL(CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> CIBCOBMOKDK, int PDMMEDBMFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class HNFNADKONBD : FDGJAAJPLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct PPKEOGACOBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int MIMJDCDEIKK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		public PPKEOGACOBH(int PDMMEDBMFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class BFOAFFKLAPA : FDGJAAJPLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct HPGOJOIMODI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> LECJKONLOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int MIMJDCDEIKK;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
		public HPGOJOIMODI(CGBGMGFBCKF<GOBCIPBHKBL.BEAJJAGKBCE> CIBCOBMOKDK, int PDMMEDBMFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum BABFNMMNMOL
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class JJEPACNOMPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class FDGJAAJPLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct MFEABOJHMOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? HIKNGPLNHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public FCOFEDFPMFK HCMPMKCEOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public BABFNMMNMOL JLIKLJMCJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CGBGMGFBCKF<FDGJAAJPLKO> IDKHLFDBHHL;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x200C930", Offset = "0x200AF30", VA = "0x18200C930")]
		public MFEABOJHMOE(int? AMDLGEHEPLM, [In] FCOFEDFPMFK IIEMBIKNAPM, BABFNMMNMOL PAJFMBKKKEO, CGBGMGFBCKF<FDGJAAJPLKO> MFNKONDKBPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class DLLOOMAGEIC : FDGJAAJPLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct JJGKFPHDPDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int MIMJDCDEIKK;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		public JJGKFPHDPDN(int PDMMEDBMFPP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal HOIOBPANFAP<JJEPACNOMPA, MFEABOJHMOE> HJECDGOHGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal HOIOBPANFAP<JJIAHOGHPKB, CJMDEHGGMJL> HBGNDBCFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal HOIOBPANFAP<BFOAFFKLAPA, HPGOJOIMODI> JGHFJMNPHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal HOIOBPANFAP<DLLOOMAGEIC, JJGKFPHDPDN> CEJFMFPBAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal HOIOBPANFAP<HNFNADKONBD, PPKEOGACOBH> NBDPGLJGMAP;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x200C800", Offset = "0x200AE00", VA = "0x18200C800")]
	private LNIKAMGIKOC([In] HOIOBPANFAP<JJEPACNOMPA, MFEABOJHMOE> DCAHIDAPCDN, [In] HOIOBPANFAP<JJIAHOGHPKB, CJMDEHGGMJL> GMJPHLJJJGC, [In] HOIOBPANFAP<BFOAFFKLAPA, HPGOJOIMODI> NOGCHBNGFCH, [In] HOIOBPANFAP<DLLOOMAGEIC, JJGKFPHDPDN> ACGLPEJCOML, [In] HOIOBPANFAP<HNFNADKONBD, PPKEOGACOBH> GKDLOGPDKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x200C610", Offset = "0x200AC10", VA = "0x18200C610")]
	public static LNIKAMGIKOC ENFOKLPNHAF()
	{
		return default(LNIKAMGIKOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NGBLBHIBJPC
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x200CA00", Offset = "0x200B000", VA = "0x18200CA00")]
	public static void IHOPKBJIMEI(this LNIKAMGIKOC HLIDMKMINHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DDAFOIBFOGP
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2005670", Offset = "0x2003C70", VA = "0x182005670")]
	public static void DKNNLLCHPCG(PAENECJPGGE HLIDMKMINHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct EPMCEGHJFLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, EEFPCJNDLIK> KJJEOHBHHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int ODCKNJHBEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int OCCEHNJFPLK;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x200B3E0", Offset = "0x20099E0", VA = "0x18200B3E0")]
	private EPMCEGHJFLI([In] ODKHIEPFOPO<GOBCIPBHKBL.NDMHLBDMIDJ, EEFPCJNDLIK> MMHAFAALPMB, int EPNIMLIHANP, int HAHMKKFHHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x200B180", Offset = "0x2009780", VA = "0x18200B180")]
	public static EPMCEGHJFLI ENFOKLPNHAF()
	{
		return default(EPMCEGHJFLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x200B1F0", Offset = "0x20097F0", VA = "0x18200B1F0")]
	public void IHOPKBJIMEI([In] PAENECJPGGE ACIFLMKOFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C4F0", Offset = "0x2A3AAF0", VA = "0x182A3C4F0")]
	public static void DKNNLLCHPCG<TDeps, TStateSys>(PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TStateSys JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA) where TDeps : notnull, CLFONDNFOMB<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class LAOIIFCBIED
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x200C440", Offset = "0x200AA40", VA = "0x18200C440")]
	public static void DKNNLLCHPCG(PAENECJPGGE HLIDMKMINHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct EPNHOMAJGDB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface PMDPBKGELMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MPPGPMPBJOH(DKMINHFJCNM<byte> FIOIIIFAKCN, int IOJHPHJHJEE);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct POCGJPLHBFN : PMDPBKGELMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x200E010", Offset = "0x200C610", VA = "0x18200E010", Slot = "4")]
		public void MPPGPMPBJOH(DKMINHFJCNM<byte> FIOIIIFAKCN, int IOJHPHJHJEE)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct NMKBAHACOKB : PMDPBKGELMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x200CAB0", Offset = "0x200B0B0", VA = "0x18200CAB0", Slot = "4")]
		public void MPPGPMPBJOH(DKMINHFJCNM<byte> FIOIIIFAKCN, int IOJHPHJHJEE)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct KMFNAMHOCOC : PMDPBKGELMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x200C3C0", Offset = "0x200A9C0", VA = "0x18200C3C0", Slot = "4")]
		public void MPPGPMPBJOH(DKMINHFJCNM<byte> FIOIIIFAKCN, int IOJHPHJHJEE)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct DCPPNLCDKIK : PMDPBKGELMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x20055C0", Offset = "0x2003BC0", VA = "0x1820055C0", Slot = "4")]
		public void MPPGPMPBJOH(DKMINHFJCNM<byte> FIOIIIFAKCN, int IOJHPHJHJEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class FOLFGDLLNNJ<TCallProcessorDeps> where TCallProcessorDeps : struct, PMDPBKGELMM
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps IMCLEPLPDAM;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2A16150", Offset = "0x2A14750", VA = "0x182A16150")]
		public static int DKNNLLCHPCG<TDeps, TStateSys>(TDeps BPGHBBHBELB, TStateSys NEIJPCGNELF, PAENECJPGGE ACIFLMKOFOE, [In] DKMINHFJCNM<byte> JDFBKBKINEB, int DBOAPJCFJOC) where TDeps : CLFONDNFOMB<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private DKMINHFJCNM<JFFKPPPAMLC> LNJDLMNCJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>> HCIBMCEHMCG;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x200B520", Offset = "0x2009B20", VA = "0x18200B520")]
	private EPNHOMAJGDB([In] DKMINHFJCNM<JFFKPPPAMLC> EFCFJIMBPAG, Dictionary<CGBGMGFBCKF<BCJLFHBLKEN<GFKIGLAKHAM>>, CGBGMGFBCKF<GOBCIPBHKBL.NDMHLBDMIDJ>> DNGCIFDIALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x200B420", Offset = "0x2009A20", VA = "0x18200B420")]
	public static EPNHOMAJGDB ENFOKLPNHAF()
	{
		return default(EPNHOMAJGDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x200B4E0", Offset = "0x2009AE0", VA = "0x18200B4E0")]
	public void IHOPKBJIMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E980", Offset = "0x2A3CF80", VA = "0x182A3E980")]
	public static void DKNNLLCHPCG<TDeps, TStateSys>(PAENECJPGGE HLIDMKMINHN, TDeps BPGHBBHBELB, TStateSys JJIILPFEIBK) where TDeps : CLFONDNFOMB<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class MDJELLHPBPM<TDeps, TIndex, TValues> where TDeps : struct, DADBIIJMCDA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps IMCLEPLPDAM;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x44BD760", Offset = "0x44BBD60", VA = "0x1844BD760")]
	public static void DKNNLLCHPCG([In] DKMINHFJCNM<JFFKPPPAMLC> EFCFJIMBPAG, int BINEEPCPHJL, TValues EJHPODPBOEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface DADBIIJMCDA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKMINHFJCNM<TIndex> MPPANKFIKFM(int BINEEPCPHJL, [In] TValues EJHPODPBOEP);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(TIndex PDMMEDBMFPP, [In] TValues EJHPODPBOEP);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OGDNFCCKKGC(TIndex PDMMEDBMFPP, TValues EJHPODPBOEP, CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HBCEOLMEGPB<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex NCBCJMCCEMI(int PDMMEDBMFPP);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHIIEADFOLL(TIndex PDMMEDBMFPP, [In] TValues EJHPODPBOEP);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CGBGMGFBCKF<BCJLFHBLKEN<DAINKMIDKHH>> LACHNHAMPOG(TIndex PDMMEDBMFPP, [In] TValues EJHPODPBOEP);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DGNCKGAGEAI<TDeps, TIndex, TValues> where TDeps : struct, HBCEOLMEGPB<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps IMCLEPLPDAM;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x58C6C00", Offset = "0x58C5200", VA = "0x1858C6C00")]
	public static DKMINHFJCNM<TIndex> DKNNLLCHPCG(int BINEEPCPHJL, [In] TValues EJHPODPBOEP)
	{
		return default(DKMINHFJCNM<TIndex>);
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
