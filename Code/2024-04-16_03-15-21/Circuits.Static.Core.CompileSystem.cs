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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E1BDA0", Offset = "0x1E1AFA0", VA = "0x181E1BDA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct CNDCMIGJPKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> FFKOIEAAINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int IPHPHPNFFLN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
	public CNDCMIGJPKH(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> HAOPDGKHCCB, int BMIAFODFMCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EECMGPGGMMN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class BINNDNIHIAL : LOBEGNAJOKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct NJJHAFNBGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly ADNAHEJLLKN<byte> JAIOKBNJHEP;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2470", Offset = "0x1DD1670", VA = "0x181DD2470")]
		public NJJHAFNBGNL(ADNAHEJLLKN<byte> GNPAJENJDCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BBE0", Offset = "0x1E1ADE0", VA = "0x181E1BBE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class CBJJFDJIFIE : LOBEGNAJOKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct NPNLFOEFBHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> JDFKNBOMJIJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		public NPNLFOEFBHD(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> HLJFPMBOBFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DLHELAKKBMJ
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
	public sealed class OGJIFKEFGPN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class LOBEGNAJOKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OLALCDFPHCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DLHELAKKBMJ MINFKFPAGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly KHCIOCBLCGC<LOBEGNAJOKO> DMFEMOHADNM;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
		public OLALCDFPHCL(DLHELAKKBMJ FAKHFDMMGEO, KHCIOCBLCGC<LOBEGNAJOKO> IDBNNJHIGAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class NKEKPAEFNHC : LOBEGNAJOKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct DPHICNGLDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> NCCALCBNGBN;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		public DPHICNGLDEF(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FKPDBGPJNBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class AECHDOINEIJ : LOBEGNAJOKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct EBJCCBBFFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly EGJBCJMPCEF MLAGJKFDJPC;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		public EBJCCBBFFPJ(EGJBCJMPCEF GCBNGFCGAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1E125D0", Offset = "0x1E117D0", VA = "0x181E125D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal NBLNHKNHEHM<OGJIFKEFGPN, OLALCDFPHCL> FFKKCGCHMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal NBLNHKNHEHM<BINNDNIHIAL, NJJHAFNBGNL> FFJPBBFNAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal NBLNHKNHEHM<CBJJFDJIFIE, NPNLFOEFBHD> HNHLDJCJFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal NBLNHKNHEHM<NKEKPAEFNHC, DPHICNGLDEF> FODKFGHBHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal NBLNHKNHEHM<AECHDOINEIJ, EBJCCBBFFPJ> JFLMOKHIGGF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E12730", Offset = "0x1E11930", VA = "0x181E12730")]
	private EECMGPGGMMN([In] NBLNHKNHEHM<OGJIFKEFGPN, OLALCDFPHCL> NIDKAKIFEFL, [In] NBLNHKNHEHM<BINNDNIHIAL, NJJHAFNBGNL> GJPHCDCHJAP, [In] NBLNHKNHEHM<CBJJFDJIFIE, NPNLFOEFBHD> DCAOHEHIIME, [In] NBLNHKNHEHM<NKEKPAEFNHC, DPHICNGLDEF> FONOPMHFKHL, [In] NBLNHKNHEHM<AECHDOINEIJ, EBJCCBBFFPJ> LOJNPAFKCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E125F0", Offset = "0x1E117F0", VA = "0x181E125F0")]
	public static EECMGPGGMMN DHBNKMCPKNO()
	{
		return default(EECMGPGGMMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AFFDLJIECGF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E120E0", Offset = "0x1E112E0", VA = "0x181E120E0")]
	public static void CJPKHGMGMMP(this EECMGPGGMMN AOFIGDLFNLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum PHNMJAMBIAK
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
public struct LJHOLFHPHEN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class AFMCHGCIMGJ : LPDJAHKMFDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct JJFPMPPFNBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> DLDLOOOLLND;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		public JJFPMPPFNBB(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> HHAPFKMDMFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum INKPCFJGIPB
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
	public sealed class DHNHAMABCCH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class LPDJAHKMFDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct KDBPGGPGNNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly INKPCFJGIPB MINFKFPAGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly KHCIOCBLCGC<LPDJAHKMFDB> DMFEMOHADNM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
		public KDBPGGPGNNB(INKPCFJGIPB FAKHFDMMGEO, KHCIOCBLCGC<LPDJAHKMFDB> IDBNNJHIGAE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal NBLNHKNHEHM<DHNHAMABCCH, KDBPGGPGNNB> FFKKCGCHMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal NBLNHKNHEHM<AFMCHGCIMGJ, JJFPMPPFNBB> CMINFIOGEMN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B340", Offset = "0x1E1A540", VA = "0x181E1B340")]
	private LJHOLFHPHEN([In] NBLNHKNHEHM<DHNHAMABCCH, KDBPGGPGNNB> NIDKAKIFEFL, [In] NBLNHKNHEHM<AFMCHGCIMGJ, JJFPMPPFNBB> HOGOIKEKHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B2B0", Offset = "0x1E1A4B0", VA = "0x181E1B2B0")]
	public static LJHOLFHPHEN DHBNKMCPKNO()
	{
		return default(LJHOLFHPHEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MEDCDCBHLNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B7B0", Offset = "0x1E1A9B0", VA = "0x181E1B7B0")]
	public static void CJPKHGMGMMP(this LJHOLFHPHEN AOFIGDLFNLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MHPIAIHJMLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public HKBGLAIKAIG<int> BIKFPIIEDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public HKBGLAIKAIG<int> GPOLOHPDKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int DHKMECLNHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int FJLOOHCNKFH;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B930", Offset = "0x1E1AB30", VA = "0x181E1B930")]
	private MHPIAIHJMLM([In] HKBGLAIKAIG<int> DMPCGLHIHHN, [In] HKBGLAIKAIG<int> PNIBNHOCHDB, int ACPBFHFFJHI, int EHCOAKFEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B890", Offset = "0x1E1AA90", VA = "0x181E1B890")]
	public static MHPIAIHJMLM DHBNKMCPKNO()
	{
		return default(MHPIAIHJMLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LHICCKADBOH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B260", Offset = "0x1E1A460", VA = "0x181E1B260")]
	public static void CJPKHGMGMMP(this MHPIAIHJMLM AOFIGDLFNLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LLNBEADKHBC
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum KHMEIKLMDGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class MDJICNAJHHI : KMDPIPBFOEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct FOLDPEMAOMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly KHCIOCBLCGC<FCPEOKCBKEE> BKGDMNEEDJB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		public FOLDPEMAOMC(KHCIOCBLCGC<FCPEOKCBKEE> JAKKMKIEDGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class FAHHOGNCDFF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class KMDPIPBFOEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct NOJNPAAGNIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly KHMEIKLMDGD MINFKFPAGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly KHCIOCBLCGC<KMDPIPBFOEJ> DMFEMOHADNM;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
		private NOJNPAAGNIB(KHMEIKLMDGD FAKHFDMMGEO, KHCIOCBLCGC<KMDPIPBFOEJ> IDBNNJHIGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BD90", Offset = "0x1E1AF90", VA = "0x181E1BD90")]
		public static NOJNPAAGNIB DHBNKMCPKNO(KHMEIKLMDGD FAKHFDMMGEO, KHCIOCBLCGC<KMDPIPBFOEJ> IDBNNJHIGAE)
		{
			return default(NOJNPAAGNIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class OPNDIFIHHLG : KMDPIPBFOEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct NIGCICPKAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly KHCIOCBLCGC<FCPEOKCBKEE> BKGDMNEEDJB;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		public NIGCICPKAEM(KHCIOCBLCGC<FCPEOKCBKEE> JAKKMKIEDGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class FCPEOKCBKEE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct NBGFMJBCLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public HKBGLAIKAIG<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> DCJEOBGJHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HKBGLAIKAIG<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> KLKPBLCJEND;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B340", Offset = "0x1E1A540", VA = "0x181E1B340")]
		private NBGFMJBCLPM([In] HKBGLAIKAIG<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> DIDDCGGEMIP, [In] HKBGLAIKAIG<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> MJHPLFLEOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BB60", Offset = "0x1E1AD60", VA = "0x181E1BB60")]
		public static NBGFMJBCLPM DHBNKMCPKNO()
		{
			return default(NBGFMJBCLPM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal NBLNHKNHEHM<FAHHOGNCDFF, NOJNPAAGNIB> FFKKCGCHMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal NBLNHKNHEHM<OPNDIFIHHLG, NIGCICPKAEM> PDCHCPIFABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal NBLNHKNHEHM<MDJICNAJHHI, FOLDPEMAOMC> AFCDBLJHJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal HKBGLAIKAIG<(KHCIOCBLCGC<FAHHOGNCDFF> CallId, KHCIOCBLCGC<FCPEOKCBKEE> IOId)> CPHLKECMGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal NBLNHKNHEHM<FCPEOKCBKEE, NBGFMJBCLPM> OFPBPHBOJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal FNDGEEMAGCJ<FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> AJEDAIJLIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal FNDGEEMAGCJ<FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> EMHIMCINFHL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B520", Offset = "0x1E1A720", VA = "0x181E1B520")]
	private LLNBEADKHBC([In] NBLNHKNHEHM<FAHHOGNCDFF, NOJNPAAGNIB> NIDKAKIFEFL, [In] NBLNHKNHEHM<OPNDIFIHHLG, NIGCICPKAEM> GFGIBKDFHEC, [In] NBLNHKNHEHM<MDJICNAJHHI, FOLDPEMAOMC> LLDLOCGGAFJ, [In] HKBGLAIKAIG<(KHCIOCBLCGC<FAHHOGNCDFF> CallId, KHCIOCBLCGC<FCPEOKCBKEE> IOId)> MBGPFCMBPPA, [In] NBLNHKNHEHM<FCPEOKCBKEE, NBGFMJBCLPM> PKAKJKNAPMM, [In] FNDGEEMAGCJ<FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> ANDGAIFFCJB, [In] FNDGEEMAGCJ<FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> AHHPIAAIBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B380", Offset = "0x1E1A580", VA = "0x181E1B380")]
	public static LLNBEADKHBC DHBNKMCPKNO()
	{
		return default(LLNBEADKHBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class OKMJJIMBPHH
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1E1BED0", Offset = "0x1E1B0D0", VA = "0x181E1BED0")]
	private static void CJPKHGMGMMP(this LLNBEADKHBC.NBGFMJBCLPM AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E1BF20", Offset = "0x1E1B120", VA = "0x181E1BF20")]
	public static void CJPKHGMGMMP(this LLNBEADKHBC AOFIGDLFNLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HDJIIBHPEAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public HKBGLAIKAIG<byte> CHHEFHACEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal LLNBEADKHBC FNNBMAPBGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal PKLCJMAMNHC ILPAFIMMEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> PNACLPDGLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal EECMGPGGMMN IMIHJIBGLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal LJHOLFHPHEN CMPGGBEGFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal FNDGEEMAGCJ<NJIFMIKHJJL, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>?> HEBIMJGHDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal HKBGLAIKAIG<KHCIOCBLCGC<NJIFMIKHJJL>> IIONBJDCOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> NNHNCPGNDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> PIEBKHLFDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> ODFCJDIKMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal ONEODBBOKLA GAGJOFKOPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal OKOHDOCPNBJ FGJMMJABBMO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E186B0", Offset = "0x1E178B0", VA = "0x181E186B0")]
	private HDJIIBHPEAK([In] HKBGLAIKAIG<byte> FFDOMAPLKNG, [In] LLNBEADKHBC NAJPODLHLJJ, [In] PKLCJMAMNHC FFDPJICHFKO, [In] EECMGPGGMMN HBEGMEIPHLA, [In] LJHOLFHPHEN MAEKEEHNFDM, [In] FNDGEEMAGCJ<NJIFMIKHJJL, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>?> CEOKLPCBFJB, [In] HKBGLAIKAIG<KHCIOCBLCGC<NJIFMIKHJJL>> OCMPMLNPLJO, [In] FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DILNOFGDGAD, [In] HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> GNMKLNAMFKL, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> MJKBBFNACCK, [In] ONEODBBOKLA LOJBLDBLPAB, [In] OKOHDOCPNBJ PNDODLGAFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E17BF0", Offset = "0x1E16DF0", VA = "0x181E17BF0")]
	public static HDJIIBHPEAK DHBNKMCPKNO()
	{
		return default(HDJIIBHPEAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IPIBOEDGIAH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct IKHNNOCLFKI : GBDKEGOECAF<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>, FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E18B60", Offset = "0x1E17D60", VA = "0x181E18B60")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E18B30", Offset = "0x1E17D30", VA = "0x181E18B30", Slot = "4")]
		public KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> DFCLPHBGFDE(int MBGANDEDPDN)
		{
			return default(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450")]
		public bool MFKIBNOJMEM(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "5")]
		private bool PGACGHHADEB(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E18B60", Offset = "0x1E17D60", VA = "0x181E18B60", Slot = "6")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> EHHIAAHBEIP(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct JNOBHMBHABN : NHDGKMLOGJA<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>, FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B000", Offset = "0x1E1A200", VA = "0x181E1B000")]
		public HKBGLAIKAIG<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>> NMACCIEBBPH(int KGOAPCDMCLM, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1E1AEF0", Offset = "0x1E1A0F0", VA = "0x181E1AEF0")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E1AF70", Offset = "0x1E1A170", VA = "0x181E1AF70", Slot = "6")]
		public void KNGMAHFNDBP(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> DBIFCPFENHC, KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B000", Offset = "0x1E1A200", VA = "0x181E1B000", Slot = "4")]
		private HKBGLAIKAIG<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>> PFDMEFLBCLA(int KGOAPCDMCLM, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1E1AEF0", Offset = "0x1E1A0F0", VA = "0x181E1AEF0", Slot = "5")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> KOLBJEANDGE(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct EPMJGIANPOA : GBDKEGOECAF<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>, FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1E12800", Offset = "0x1E11A00", VA = "0x181E12800")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E127D0", Offset = "0x1E119D0", VA = "0x181E127D0", Slot = "4")]
		public KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> DFCLPHBGFDE(int MBGANDEDPDN)
		{
			return default(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450")]
		public bool MFKIBNOJMEM(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "5")]
		private bool LCGIICBOPMH(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E12800", Offset = "0x1E11A00", VA = "0x181E12800", Slot = "6")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> KPPPODAHGED(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct AFPPFACADEE : NHDGKMLOGJA<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>, FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1E12210", Offset = "0x1E11410", VA = "0x181E12210")]
		public HKBGLAIKAIG<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>> NMACCIEBBPH(int KGOAPCDMCLM, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1E12190", Offset = "0x1E11390", VA = "0x181E12190")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1E12280", Offset = "0x1E11480", VA = "0x181E12280", Slot = "6")]
		public void KNGMAHFNDBP(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> DBIFCPFENHC, KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1E12210", Offset = "0x1E11410", VA = "0x181E12210", Slot = "4")]
		private HKBGLAIKAIG<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>> KAINLNGODLF(int KGOAPCDMCLM, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1E12190", Offset = "0x1E11390", VA = "0x181E12190", Slot = "5")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> IKJJHFOGBGF(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> MBGANDEDPDN, [In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct NLFPECDCAIK : GBDKEGOECAF<KHCIOCBLCGC<GHLBDMPMDKP>, FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BC80", Offset = "0x1E1AE80", VA = "0x181E1BC80")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(KHCIOCBLCGC<GHLBDMPMDKP> MBGANDEDPDN, [In] FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BC50", Offset = "0x1E1AE50", VA = "0x181E1BC50", Slot = "4")]
		public KHCIOCBLCGC<GHLBDMPMDKP> DFCLPHBGFDE(int MBGANDEDPDN)
		{
			return default(KHCIOCBLCGC<GHLBDMPMDKP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BD20", Offset = "0x1E1AF20", VA = "0x181E1BD20")]
		public bool MFKIBNOJMEM(KHCIOCBLCGC<GHLBDMPMDKP> MBGANDEDPDN, [In] FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BD20", Offset = "0x1E1AF20", VA = "0x181E1BD20", Slot = "5")]
		private bool KPBGOEBICIN(KHCIOCBLCGC<GHLBDMPMDKP> MBGANDEDPDN, [In] FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BD80", Offset = "0x1E1AF80", VA = "0x181E1BD80", Slot = "6")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> NOEFNIFMDGG(KHCIOCBLCGC<GHLBDMPMDKP> MBGANDEDPDN, [In] FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct PGMJJNGJDDN : NHDGKMLOGJA<KHCIOCBLCGC<GHLBDMPMDKP>, FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C810", Offset = "0x1E1BA10", VA = "0x181E1C810")]
		public HKBGLAIKAIG<KHCIOCBLCGC<GHLBDMPMDKP>> NMACCIEBBPH(int KGOAPCDMCLM, [In] FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<KHCIOCBLCGC<GHLBDMPMDKP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C770", Offset = "0x1E1B970", VA = "0x181E1C770")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(KHCIOCBLCGC<GHLBDMPMDKP> MBGANDEDPDN, [In] FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C890", Offset = "0x1E1BA90", VA = "0x181E1C890", Slot = "6")]
		public void KNGMAHFNDBP(KHCIOCBLCGC<GHLBDMPMDKP> MBGANDEDPDN, FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DBIFCPFENHC, KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C810", Offset = "0x1E1BA10", VA = "0x181E1C810", Slot = "4")]
		private HKBGLAIKAIG<KHCIOCBLCGC<GHLBDMPMDKP>> FJGLKCIMHFD(int KGOAPCDMCLM, [In] FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<KHCIOCBLCGC<GHLBDMPMDKP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C880", Offset = "0x1E1BA80", VA = "0x181E1C880", Slot = "5")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> HINGODOMKJD(KHCIOCBLCGC<GHLBDMPMDKP> MBGANDEDPDN, [In] FNDGEEMAGCJ<GHLBDMPMDKP, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>?> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct BJBKDBJEOME : GBDKEGOECAF<int, HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1E12310", Offset = "0x1E11510", VA = "0x181E12310")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x11DD220", Offset = "0x11DC420", VA = "0x1811DD220", Slot = "4")]
		public int DFCLPHBGFDE(int MBGANDEDPDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450")]
		public bool MFKIBNOJMEM(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "5")]
		private bool JFKBCPAEJPF(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E12390", Offset = "0x1E11590", VA = "0x181E12390", Slot = "6")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> ONMMADGBHIH(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct KNPLOANOGOF : NHDGKMLOGJA<int, HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B070", Offset = "0x1E1A270", VA = "0x181E1B070")]
		public HKBGLAIKAIG<int> NMACCIEBBPH(int KGOAPCDMCLM, [In] HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B0E0", Offset = "0x1E1A2E0", VA = "0x181E1B0E0")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B170", Offset = "0x1E1A370", VA = "0x181E1B170", Slot = "6")]
		public void KNGMAHFNDBP(int MBGANDEDPDN, HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> DBIFCPFENHC, KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B070", Offset = "0x1E1A270", VA = "0x181E1B070", Slot = "4")]
		private HKBGLAIKAIG<int> AHLMMLIKPHO(int KGOAPCDMCLM, [In] HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B160", Offset = "0x1E1A360", VA = "0x181E1B160", Slot = "5")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> FPONCAGDJKE(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> VariableId, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<GBCLANPIBGE>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct HFKMNBPEKFH : GBDKEGOECAF<int, HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1E18A10", Offset = "0x1E17C10", VA = "0x181E18A10")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x11DD220", Offset = "0x11DC420", VA = "0x1811DD220", Slot = "4")]
		public int DFCLPHBGFDE(int MBGANDEDPDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450")]
		public bool MFKIBNOJMEM(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "5")]
		private bool GPCENPOBCDJ(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1E18A10", Offset = "0x1E17C10", VA = "0x181E18A10", Slot = "6")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> ANMFNJHGDON(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct LNBPKOFIHAC : NHDGKMLOGJA<int, HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B660", Offset = "0x1E1A860", VA = "0x181E1B660")]
		public HKBGLAIKAIG<int> NMACCIEBBPH(int KGOAPCDMCLM, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B5E0", Offset = "0x1E1A7E0", VA = "0x181E1B5E0")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B6D0", Offset = "0x1E1A8D0", VA = "0x181E1B6D0", Slot = "6")]
		public void KNGMAHFNDBP(int MBGANDEDPDN, HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC, KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B660", Offset = "0x1E1A860", VA = "0x181E1B660", Slot = "4")]
		private HKBGLAIKAIG<int> FAECPBENBHF(int KGOAPCDMCLM, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B5E0", Offset = "0x1E1A7E0", VA = "0x181E1B5E0", Slot = "5")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> HDKINIPNIMP(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct PNAELDAMBMI : GBDKEGOECAF<int, HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CC70", Offset = "0x1E1BE70", VA = "0x181E1CC70")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x11DD220", Offset = "0x11DC420", VA = "0x1811DD220", Slot = "4")]
		public int DFCLPHBGFDE(int MBGANDEDPDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450")]
		public bool MFKIBNOJMEM(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "5")]
		private bool GPCENPOBCDJ(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CC60", Offset = "0x1E1BE60", VA = "0x181E1CC60", Slot = "6")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> ANMFNJHGDON(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct CFKKCNIPAND : NHDGKMLOGJA<int, HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E12420", Offset = "0x1E11620", VA = "0x181E12420")]
		public HKBGLAIKAIG<int> NMACCIEBBPH(int KGOAPCDMCLM, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1E123A0", Offset = "0x1E115A0", VA = "0x181E123A0")]
		public KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1E124A0", Offset = "0x1E116A0", VA = "0x181E124A0", Slot = "6")]
		public void KNGMAHFNDBP(int MBGANDEDPDN, HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC, KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1E12420", Offset = "0x1E11620", VA = "0x181E12420", Slot = "4")]
		private HKBGLAIKAIG<int> FAECPBENBHF(int KGOAPCDMCLM, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(HKBGLAIKAIG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1E12490", Offset = "0x1E11690", VA = "0x181E12490", Slot = "5")]
		private KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> HDKINIPNIMP(int MBGANDEDPDN, [In] HKBGLAIKAIG<(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> Target, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> ByteCodeWriteLocation)> DBIFCPFENHC)
		{
			return default(KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct JFKMGPCHCJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> PGJPCMACGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool AHIACJAHKKB;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF08960", Offset = "0xF07B60", VA = "0x180F08960")]
		public JFKMGPCHCJF(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP, bool LGIMHMDFFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E1AEE0", Offset = "0x1E1A0E0", VA = "0x181E1AEE0")]
		public void EHCLCENNOFJ([Out] KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP, [Out] bool LGIMHMDFFFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct EBAJAFBBCMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly KHCIOCBLCGC<GHLBDMPMDKP> CHGCOCOGJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> PGJPCMACGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool AHIACJAHKKB;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E125C0", Offset = "0x1E117C0", VA = "0x181E125C0")]
		public EBAJAFBBCMH(KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP, bool LGIMHMDFFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1E12590", Offset = "0x1E11790", VA = "0x181E12590")]
		public void EHCLCENNOFJ([Out] KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP, [Out] bool LGIMHMDFFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1E125A0", Offset = "0x1E117A0", VA = "0x181E125A0")]
		public void EHCLCENNOFJ([Out] KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP, [Out] KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH, [Out] bool LGIMHMDFFFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct EJNOMGPBOBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly KHCIOCBLCGC<GHLBDMPMDKP> CHGCOCOGJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> PGJPCMACGDI;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
		public EJNOMGPBOBJ(KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E127C0", Offset = "0x1E119C0", VA = "0x181E127C0")]
		public void EHCLCENNOFJ([Out] KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP, [Out] KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1E192C0", Offset = "0x1E184C0", VA = "0x181E192C0")]
	public static void CJPKHGMGMMP(this HDJIIBHPEAK AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A5D0", Offset = "0x1E197D0", VA = "0x181E1A5D0")]
	public static void LDBJEICPAKH(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<NJIFMIKHJJL> BDBHJLOOAPB, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> MEANEHABKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E199A0", Offset = "0x1E18BA0", VA = "0x181E199A0")]
	public static void EFGKNNKEJGI(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<NJIFMIKHJJL> BDBHJLOOAPB, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> MEANEHABKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1E19DE0", Offset = "0x1E18FE0", VA = "0x181E19DE0")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>? HDMEKNBBDNC([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<NJIFMIKHJJL> BDBHJLOOAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1E19C60", Offset = "0x1E18E60", VA = "0x181E19C60")]
	public static KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> HAFKIOOFILN([In] this HDJIIBHPEAK AOFIGDLFNLH)
	{
		return default(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1E196C0", Offset = "0x1E188C0", VA = "0x181E196C0")]
	private static void COMECINJHIE(this HDJIIBHPEAK AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A060", Offset = "0x1E19260", VA = "0x181E1A060")]
	private static KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>? IFMDEEOHEKD([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1E19060", Offset = "0x1E18260", VA = "0x181E19060")]
	public static void BCNOKIMPHND(this HDJIIBHPEAK AOFIGDLFNLH, [In] HKBGLAIKAIG<CNDCMIGJPKH> KKBDDDGCIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E18CE0", Offset = "0x1E17EE0", VA = "0x181E18CE0")]
	public static EECMGPGGMMN.DLHELAKKBMJ AJEFFMGPMEJ([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP)
	{
		return default(EECMGPGGMMN.DLHELAKKBMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A890", Offset = "0x1E19A90", VA = "0x181E1A890")]
	public static ADNAHEJLLKN<byte> MHFELPMJLAO([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP)
	{
		return default(ADNAHEJLLKN<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E19B10", Offset = "0x1E18D10", VA = "0x181E19B10")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> EOINAGBJOJP([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E1AE20", Offset = "0x1E1A020", VA = "0x181E1AE20")]
	public static EGJBCJMPCEF PPEFECKFEFK([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP)
	{
		return default(EGJBCJMPCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28C6100", Offset = "0x28C5300", VA = "0x1828C6100")]
	private static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> CBAHECLNLAM<TMJoin>(this HDJIIBHPEAK AOFIGDLFNLH, EECMGPGGMMN.DLHELAKKBMJ FAKHFDMMGEO, KHCIOCBLCGC<TMJoin> IDBNNJHIGAE) where TMJoin : EECMGPGGMMN.LOBEGNAJOKO
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A130", Offset = "0x1E19330", VA = "0x181E1A130")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> IMNHFIDKBLH(this HDJIIBHPEAK AOFIGDLFNLH, bool GJKNBCDINIG)
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1E19230", Offset = "0x1E18430", VA = "0x181E19230")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> CEBCIIMHILB(this HDJIIBHPEAK AOFIGDLFNLH, ADNAHEJLLKN<byte> GNPAJENJDCN)
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1E19920", Offset = "0x1E18B20", VA = "0x181E19920")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> DKIHOMNLMGF(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> HLJFPMBOBFI)
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1E19590", Offset = "0x1E18790", VA = "0x181E19590")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> CKNEMOBMHHG(this HDJIIBHPEAK AOFIGDLFNLH, int MIAMIDGGLJF)
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1E19F80", Offset = "0x1E19180", VA = "0x181E19F80")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> ICNIOLFHCKE(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FKPDBGPJNBG)
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28C6410", Offset = "0x28C5610", VA = "0x1828C6410")]
	private static KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH> ELEAKNDBIBO<TMJoin>(this HDJIIBHPEAK AOFIGDLFNLH, LJHOLFHPHEN.INKPCFJGIPB FAKHFDMMGEO, KHCIOCBLCGC<TMJoin> IDBNNJHIGAE) where TMJoin : LJHOLFHPHEN.LPDJAHKMFDB
	{
		return default(KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1E1AB70", Offset = "0x1E19D70", VA = "0x181E1AB70")]
	public static KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH> NJICDHGGADJ(this HDJIIBHPEAK AOFIGDLFNLH)
	{
		return default(KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A660", Offset = "0x1E19860", VA = "0x181E1A660")]
	public static KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH> LDPMBPMKPIN(this HDJIIBHPEAK AOFIGDLFNLH)
	{
		return default(KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1E19F00", Offset = "0x1E19100", VA = "0x181E19F00")]
	public static KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH> HPILCACOJJL(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> HHAPFKMDMFE)
	{
		return default(KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E19BC0", Offset = "0x1E18DC0", VA = "0x181E19BC0")]
	public static KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH> FEMJCLGNBMK(this HDJIIBHPEAK AOFIGDLFNLH)
	{
		return default(KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E198E0", Offset = "0x1E18AE0", VA = "0x181E198E0")]
	public static KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH> DIGJLCDDAMF(this HDJIIBHPEAK AOFIGDLFNLH)
	{
		return default(KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A000", Offset = "0x1E19200", VA = "0x181E1A000")]
	public static LLNBEADKHBC.KHMEIKLMDGD IEEDNNJKJLI([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> EIKMNOPBMON)
	{
		return default(LLNBEADKHBC.KHMEIKLMDGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A940", Offset = "0x1E19B40", VA = "0x181E1A940")]
	public static FKOGJKIBHGK<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>, GEIPCBEKJKL<LLNBEADKHBC.FCPEOKCBKEE>> MOGJGKOHJGO([In] this HDJIIBHPEAK AOFIGDLFNLH)
	{
		return default(FKOGJKIBHGK<KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>, GEIPCBEKJKL<LLNBEADKHBC.FCPEOKCBKEE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1E1ACB0", Offset = "0x1E19EB0", VA = "0x181E1ACB0")]
	public static KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> OJEDBHJEKFK([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> EIKMNOPBMON)
	{
		return default(KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A830", Offset = "0x1E19A30", VA = "0x181E1A830")]
	public static LLNBEADKHBC.NBGFMJBCLPM MBMKIJBLPPM([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> JAKKMKIEDGM)
	{
		return default(LLNBEADKHBC.NBGFMJBCLPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E19C00", Offset = "0x1E18E00", VA = "0x181E19C00")]
	public static LLNBEADKHBC.NBGFMJBCLPM GEHLBDLFAAA(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> JAKKMKIEDGM)
	{
		return default(LLNBEADKHBC.NBGFMJBCLPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28C76A0", Offset = "0x28C68A0", VA = "0x1828C76A0")]
	private static KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> JNEBNIEFKHE<TMJoin>(this HDJIIBHPEAK AOFIGDLFNLH, LLNBEADKHBC.KHMEIKLMDGD FAKHFDMMGEO, KHCIOCBLCGC<TMJoin> IDBNNJHIGAE) where TMJoin : LLNBEADKHBC.KMDPIPBFOEJ
	{
		return default(KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A370", Offset = "0x1E19570", VA = "0x181E1A370")]
	public static (KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>) JEEMHCGHCMK(this HDJIIBHPEAK AOFIGDLFNLH)
	{
		return default((KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1E18E00", Offset = "0x1E18000", VA = "0x181E18E00")]
	public static (KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>) ALPAHBEBMHK(this HDJIIBHPEAK AOFIGDLFNLH)
	{
		return default((KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A0F0", Offset = "0x1E192F0", VA = "0x181E1A0F0")]
	public static KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> IIPCENOGNPM(this HDJIIBHPEAK AOFIGDLFNLH)
	{
		return default(KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A7A0", Offset = "0x1E199A0", VA = "0x181E1A7A0")]
	public static void LJHDJDELKPO(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE> JAKKMKIEDGM, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> JGOMJNNHNHD, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>> LJELDOKBNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28C6A40", Offset = "0x28C5C40", VA = "0x1828C6A40")]
	public static JFKMGPCHCJF GBIDLIHJGKC<TDeps, TStateSys>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH) where TDeps : PDDCBKKGIKA<TStateSys>
	{
		return default(JFKMGPCHCJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28C6280", Offset = "0x28C5480", VA = "0x1828C6280")]
	public static EBAJAFBBCMH DLGCLGBIHHC<TDeps, TStateSys>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GGOIHKGODHF> MBBENIIFGEP, int HINLAFIDFIB) where TDeps : PDDCBKKGIKA<TStateSys>
	{
		return default(EBAJAFBBCMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28C7280", Offset = "0x28C6480", VA = "0x1828C7280")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>? JGCEACJDMCB<TDeps, TStateSys>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GGOIHKGODHF> MBBENIIFGEP, [In] ReadOnlySpan<int> AHDJGBCKPDO, [In] Span<EJNOMGPBOBJ> AJGLABCJPHM) where TDeps : PDDCBKKGIKA<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28C7A00", Offset = "0x28C6C00", VA = "0x1828C7A00")]
	public static KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH> MOBKFAJDFNK<TDeps, TStateSys>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<NJIFMIKHJJL> BDBHJLOOAPB) where TDeps : PDDCBKKGIKA<TStateSys>
	{
		return default(KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1E18C40", Offset = "0x1E17E40", VA = "0x181E18C40")]
	public static PKLCJMAMNHC.FHNKDFKOOII AFGODFLKMJH([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> POAELFIOKHK)
	{
		return default(PKLCJMAMNHC.FHNKDFKOOII);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1E18FC0", Offset = "0x1E181C0", VA = "0x181E18FC0")]
	public static PKLCJMAMNHC.BCIPHJFCHNM APHKOHCBIJD([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> POAELFIOKHK)
	{
		return default(PKLCJMAMNHC.BCIPHJFCHNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E19A70", Offset = "0x1E18C70", VA = "0x181E19A70")]
	public static PKLCJMAMNHC.APIFNDCIHBO EFNDNKIABBK([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> POAELFIOKHK)
	{
		return default(PKLCJMAMNHC.APIFNDCIHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A1B0", Offset = "0x1E193B0", VA = "0x181E1A1B0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> JCJEPJODMNI(this HDJIIBHPEAK AOFIGDLFNLH, int? LHKLODKBIIB, string MPENHPFDCDK)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1E1AC10", Offset = "0x1E19E10", VA = "0x181E1AC10")]
	public static PKLCJMAMNHC.CBILHNFHDAC OENKIOAPFPI([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> POAELFIOKHK)
	{
		return default(PKLCJMAMNHC.CBILHNFHDAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A980", Offset = "0x1E19B80", VA = "0x181E1A980")]
	public static PKLCJMAMNHC.PAKHLNJPKBC MPGIKMMHIAM([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> POAELFIOKHK)
	{
		return default(PKLCJMAMNHC.PAKHLNJPKBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E1ABB0", Offset = "0x1E19DB0", VA = "0x181E1ABB0")]
	public static int? OEGAJGIFHPJ([In] this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> POAELFIOKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28C7D80", Offset = "0x28C6F80", VA = "0x1828C7D80")]
	private static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> NOGGPPOHLEK<TMJoin>(this HDJIIBHPEAK AOFIGDLFNLH, int? LHKLODKBIIB, PKLCJMAMNHC.PAKHLNJPKBC FAKHFDMMGEO, KHCIOCBLCGC<TMJoin> IDBNNJHIGAE) where TMJoin : PKLCJMAMNHC.FLGDDHMBHIN
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1E19610", Offset = "0x1E18810", VA = "0x181E19610")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> CNNPDCLJHMG(this HDJIIBHPEAK AOFIGDLFNLH, int? LHKLODKBIIB, KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> EIKMNOPBMON, int MBGANDEDPDN)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E191D0", Offset = "0x1E183D0", VA = "0x181E191D0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> CANNOEOFAHF(this HDJIIBHPEAK AOFIGDLFNLH, int? LHKLODKBIIB)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A9E0", Offset = "0x1E19BE0", VA = "0x181E1A9E0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> NGDHCBBANMF(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>? HHMNPIECDNO, int? LHKLODKBIIB)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E19E70", Offset = "0x1E19070", VA = "0x181E19E70")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> HKOGMPCAEKB(this HDJIIBHPEAK AOFIGDLFNLH, int? LHKLODKBIIB, int MBGANDEDPDN)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E18BE0", Offset = "0x1E17DE0", VA = "0x181E18BE0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> ACFFKEANCID(this HDJIIBHPEAK AOFIGDLFNLH, int? LHKLODKBIIB)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E19CC0", Offset = "0x1E18EC0", VA = "0x181E19CC0")]
	public static void HBLOIPMGCEH(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FKPDBGPJNBG, KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> EIKMNOPBMON, int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A6A0", Offset = "0x1E198A0", VA = "0x181E1A6A0")]
	public static void LIHEPMAOBNI(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FKPDBGPJNBG, int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E18D40", Offset = "0x1E17F40", VA = "0x181E18D40")]
	public static void AKPIACBBFGC(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FKPDBGPJNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A540", Offset = "0x1E19740", VA = "0x181E1A540")]
	public static void KPPLKGFLPOJ(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> JGFCAMDGBLE, KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> MDNMCJKLBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1E19820", Offset = "0x1E18A20", VA = "0x181E19820")]
	public static void DDGGEHPFMBF(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FKPDBGPJNBG, KHCIOCBLCGC<OODMOBKKOGN<GBAEBNOGABD>> KMPLOIOJDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28C7730", Offset = "0x28C6930", VA = "0x1828C7730")]
	public static void LIDOGMCDCEL<M>(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FKPDBGPJNBG, KHCIOCBLCGC<OODMOBKKOGN<LNPHMOBHGKC<M>>> KMPLOIOJDFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PDDCBKKGIKA<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHCIOCBLCGC<DAPCHLKNEIJ> IPLBFCDOMOJ(TStateSys CBIDDJLFENO);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KHCIOCBLCGC<DAPCHLKNEIJ> NBBPDFBCAMJ(TStateSys CBIDDJLFENO);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KHCIOCBLCGC<LLLIADBGNDG> GDDDKCGKLCC(TStateSys CBIDDJLFENO);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KHCIOCBLCGC<LLLIADBGNDG> MGNFOHIHNJP(TStateSys CBIDDJLFENO);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH> OMDOBKDABKA(TStateSys CBIDDJLFENO, HDJIIBHPEAK KMPCIALJDMD, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> MOKJFCHGCFM(TStateSys CBIDDJLFENO, HDJIIBHPEAK KMPCIALJDMD, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<NJIFMIKHJJL> BDBHJLOOAPB);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OGPDIAGHGPP(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KHCIOCBLCGC<NJIFMIKHJJL> NPMECPCCJCC(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH, int LFCCAAPCEFP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PHNMJAMBIAK CPPPHJLNOLD(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KPKOIGAODGF(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int MKFEAOCGNFN(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ADNAHEJLLKN<byte> MPNLCADLLAC(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(ADNAHEJLLKN<byte>, KHCIOCBLCGC<LLLIADBGNDG>) CKKGJEJMCJB(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GHLBDMPMDKP> HNCOCKJDHMH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int IKCLKOGMHOE(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<NJIFMIKHJJL> BDBHJLOOAPB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KHCIOCBLCGC<GHLBDMPMDKP> LLIKKHOJNOA(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<NJIFMIKHJJL> BDBHJLOOAPB, int HINLAFIDFIB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KHCIOCBLCGC<GHLBDMPMDKP> FKMHOABEFBD(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GGOIHKGODHF> MBBENIIFGEP, int HINLAFIDFIB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int JEEDPMIOLAD(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? DCDNMEANNLL(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int NDDHABPBGJN(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? AHGGLFFHHPB(TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, int MBGANDEDPDN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GPCGIKPPADP
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x28A4970", Offset = "0x28A3B70", VA = "0x1828A4970")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM?> JAIFGIHNCPN<T, TOpInput, TOpOutput>(this HDJIIBHPEAK AOFIGDLFNLH, T DEHAFGPDPHM, T FAFKEFEMLFH, int AGFKMOLALHK, IntPtr GCJELMILOBG)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28A3580", Offset = "0x28A2780", VA = "0x1828A3580")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM?> AHBLLLPPOHP<T, TOpInput, TOpOutput>(this HDJIIBHPEAK AOFIGDLFNLH, T DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH, int AGFKMOLALHK, IntPtr GCJELMILOBG)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x28A5B50", Offset = "0x28A4D50", VA = "0x1828A5B50")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM?> OHAIKCLAAJM<TOpInput, TOpOutput>(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH, int AGFKMOLALHK, IntPtr GCJELMILOBG)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E14810", Offset = "0x1E13A10", VA = "0x181E14810")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FJDOPPJALLM(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, float IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1E176A0", Offset = "0x1E168A0", VA = "0x181E176A0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> ONBOKHJJJCH(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1E16AB0", Offset = "0x1E15CB0", VA = "0x181E16AB0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> LBANAOCFOLG(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1E12880", Offset = "0x1E11A80", VA = "0x181E12880")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> ACBHJCOGMKI(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, int IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1E14490", Offset = "0x1E13690", VA = "0x181E14490")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAHIMGNCHPK(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E14250", Offset = "0x1E13450", VA = "0x181E14250")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DMLHABAIBLM(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E139F0", Offset = "0x1E12BF0", VA = "0x181E139F0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BPMGLLCFNBN(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, int IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E17050", Offset = "0x1E16250", VA = "0x181E17050")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> NIJKCOJNFCH(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E16120", Offset = "0x1E15320", VA = "0x181E16120")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> KAEBJADJOJH(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E15B10", Offset = "0x1E14D10", VA = "0x181E15B10")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IDLFAFEDNPJ(this HDJIIBHPEAK AOFIGDLFNLH, int DEHAFGPDPHM, int FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E14D40", Offset = "0x1E13F40", VA = "0x181E14D40")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> GNGPIGGDHBO(this HDJIIBHPEAK AOFIGDLFNLH, int DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E13D60", Offset = "0x1E12F60", VA = "0x181E13D60")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> CGAIHCIDFIP(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E133C0", Offset = "0x1E125C0", VA = "0x181E133C0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BDMCMDLDKEA(this HDJIIBHPEAK AOFIGDLFNLH, float DEHAFGPDPHM, float FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E13AE0", Offset = "0x1E12CE0", VA = "0x181E13AE0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> CAIOKLKAMOE(this HDJIIBHPEAK AOFIGDLFNLH, float DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1E159D0", Offset = "0x1E14BD0", VA = "0x181E159D0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IAKFNAJGIED(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E17AF0", Offset = "0x1E16CF0", VA = "0x181E17AF0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> PPEKAABEHAK(this HDJIIBHPEAK AOFIGDLFNLH, int DEHAFGPDPHM, int FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E17B70", Offset = "0x1E16D70", VA = "0x181E17B70")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> PPFCDKKHMFL(this HDJIIBHPEAK AOFIGDLFNLH, int DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E15CF0", Offset = "0x1E14EF0", VA = "0x181E15CF0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> JBCGIOAFNDE(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E140B0", Offset = "0x1E132B0", VA = "0x181E140B0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DHBNHHEFPHN(this HDJIIBHPEAK AOFIGDLFNLH, float DEHAFGPDPHM, float FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E15FA0", Offset = "0x1E151A0", VA = "0x181E15FA0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> JMKPDBJAGGN(this HDJIIBHPEAK AOFIGDLFNLH, float DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E14390", Offset = "0x1E13590", VA = "0x181E14390")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> EACNIHCICMD(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E14410", Offset = "0x1E13610", VA = "0x181E14410")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> EMGOKEDOBCE(this HDJIIBHPEAK AOFIGDLFNLH, int DEHAFGPDPHM, int FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E13EA0", Offset = "0x1E130A0", VA = "0x181E13EA0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DBDLJGLEFEH(this HDJIIBHPEAK AOFIGDLFNLH, int DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E16D30", Offset = "0x1E15F30", VA = "0x181E16D30")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> MHOLEEIDLNA(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E13580", Offset = "0x1E12780", VA = "0x181E13580")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BFGGHFADBDE(this HDJIIBHPEAK AOFIGDLFNLH, float DEHAFGPDPHM, float FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E14CC0", Offset = "0x1E13EC0", VA = "0x181E14CC0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> GNDMLCMOOBA(this HDJIIBHPEAK AOFIGDLFNLH, float DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E14910", Offset = "0x1E13B10", VA = "0x181E14910")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FJFLBJBACEE(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E17170", Offset = "0x1E16370", VA = "0x181E17170")]
	public static KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> NLCJIOCCNNH(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP)
	{
		return default(KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E13220", Offset = "0x1E12420", VA = "0x181E13220")]
	public static KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> BBHGDACKKCN(this HDJIIBHPEAK AOFIGDLFNLH, int EKDDCPALANJ)
	{
		return default(KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1E13600", Offset = "0x1E12800", VA = "0x181E13600")]
	public static KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> BGDOICJKHJJ(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> EKDDCPALANJ)
	{
		return default(KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E12970", Offset = "0x1E11B70", VA = "0x181E12970")]
	public static KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> AGAFEIAOMNI(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> NJFHKBGFCFP)
	{
		return default(KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1E164A0", Offset = "0x1E156A0", VA = "0x181E164A0")]
	public static KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> KHDBIDEGMNK(this HDJIIBHPEAK AOFIGDLFNLH, int EKDDCPALANJ)
	{
		return default(KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E14010", Offset = "0x1E13210", VA = "0x181E14010")]
	public static KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>> DGPDCDOLIPP(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> EKDDCPALANJ)
	{
		return default(KHCIOCBLCGC<OODMOBKKOGN<OODMOBKKOGN<DLJPCDCPPIO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1E16520", Offset = "0x1E15720", VA = "0x181E16520")]
	public static (KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>) KIMGFAHDANI(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<DAPCHLKNEIJ> LJNKNBHIGCI, [In] ReadOnlySpan<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> DIDDCGGEMIP, [In] ReadOnlySpan<int?> FDKIKNFHGIB, [In] Span<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> MJCFJGBIDFL)
	{
		return default((KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E12D90", Offset = "0x1E11F90", VA = "0x181E12D90")]
	public static (KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>) BBBPJBADNLF(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<GALILFHDLFP> NJNKNENNNGG, [In] ReadOnlySpan<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> DIDDCGGEMIP, [In] ReadOnlySpan<int?> FDKIKNFHGIB, [In] Span<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> MJCFJGBIDFL)
	{
		return default((KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x28A55E0", Offset = "0x28A47E0", VA = "0x1828A55E0")]
	public static (KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>, KHCIOCBLCGC<OODMOBKKOGN<LLLIADBGNDG>>, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>, KHCIOCBLCGC<OODMOBKKOGN<TMarker>>, KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>) JDPACCFEBCJ<TMarker>(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<LLLIADBGNDG> OLHNFAPGAPA, [In] ReadOnlySpan<byte> MJGHOBDIDHD)
	{
		return default((KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>, KHCIOCBLCGC<OODMOBKKOGN<LLLIADBGNDG>>, KHCIOCBLCGC<OODMOBKKOGN<CPGCGIIDHKL>>, KHCIOCBLCGC<OODMOBKKOGN<TMarker>>, KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1E134C0", Offset = "0x1E126C0", VA = "0x181E134C0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BEBJNHMAKOK(this HDJIIBHPEAK AOFIGDLFNLH, int BOAMPKDFKLM, [Optional] KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>? JFGPAIHHEJK)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E16EE0", Offset = "0x1E160E0", VA = "0x181E16EE0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> MPJNHMLPPEN(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BOAMPKDFKLM, [Optional] KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>? JFGPAIHHEJK)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1E175B0", Offset = "0x1E167B0", VA = "0x181E175B0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> OMHKAGMECMG(this HDJIIBHPEAK AOFIGDLFNLH, [In] ReadOnlySpan<byte> BOAMPKDFKLM, [Optional] KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>? JFGPAIHHEJK)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1E14990", Offset = "0x1E13B90", VA = "0x181E14990")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> GAFJOJKDELB(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BOAMPKDFKLM, int ANCJPCFOHBG, [Optional] KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>? JFGPAIHHEJK)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1E158D0", Offset = "0x1E14AD0", VA = "0x181E158D0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IAFCEAEJHJB(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, float IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1E14BA0", Offset = "0x1E13DA0", VA = "0x181E14BA0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> GHMGLNLDOEH(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E16360", Offset = "0x1E15560", VA = "0x181E16360")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> KCEBPGPKAJF(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1E13F20", Offset = "0x1E13120", VA = "0x181E13F20")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DGFDAJNIKJH(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, int IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1E12B50", Offset = "0x1E11D50", VA = "0x181E12B50")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> AKIBGNDCJMB(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1E13C10", Offset = "0x1E12E10", VA = "0x181E13C10")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> CCCOKENFHGD(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1E162E0", Offset = "0x1E154E0", VA = "0x181E162E0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> KBNHAFOBFHB(this HDJIIBHPEAK AOFIGDLFNLH, int DEHAFGPDPHM, int FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E16FD0", Offset = "0x1E161D0", VA = "0x181E16FD0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> NHHDBHLEKFD(this HDJIIBHPEAK AOFIGDLFNLH, int DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1E16260", Offset = "0x1E15460", VA = "0x181E16260")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> KALBPIDDDHP(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DEHAFGPDPHM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FAFKEFEMLFH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1E169B0", Offset = "0x1E15BB0", VA = "0x181E169B0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> LADCDFCFKFB(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, float IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E16DB0", Offset = "0x1E15FB0", VA = "0x181E16DB0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> MLKPEMJIIEF(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1E177C0", Offset = "0x1E169C0", VA = "0x181E177C0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> PABAMICHEDN(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E15C00", Offset = "0x1E14E00", VA = "0x181E15C00")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> INNPKJIPNNC(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, int IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E12C70", Offset = "0x1E11E70", VA = "0x181E12C70")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> ALFHIFBIAOA(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E15790", Offset = "0x1E14990", VA = "0x181E15790")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> HGDNINKKILJ(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1E179F0", Offset = "0x1E16BF0", VA = "0x181E179F0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> PHNCMLOIDEH(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, float IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1E17350", Offset = "0x1E16550", VA = "0x181E17350")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> OIOPHJPGCMJ(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E16BF0", Offset = "0x1E15DF0", VA = "0x181E16BF0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> LHLJDBFENDI(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E15EB0", Offset = "0x1E150B0", VA = "0x181E15EB0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> JMGFNEPNLDJ(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, int IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E14130", Offset = "0x1E13330", VA = "0x181E14130")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DJHACNPGAEF(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E145B0", Offset = "0x1E137B0", VA = "0x181E145B0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FDDLCNEKCGH(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E137B0", Offset = "0x1E129B0", VA = "0x181E137B0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BJEJHEIKMBB(this HDJIIBHPEAK AOFIGDLFNLH, int EKDDCPALANJ)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E136A0", Offset = "0x1E128A0", VA = "0x181E136A0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BHFCPOGIENJ(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> EKDDCPALANJ)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E13D50", Offset = "0x1E12F50", VA = "0x181E13D50")]
	public static void CFJCEDFMFOA(this HDJIIBHPEAK AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E16020", Offset = "0x1E15220", VA = "0x181E16020")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> JOGDHCMONPH(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, float IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E146F0", Offset = "0x1E138F0", VA = "0x181E146F0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FEGFPJOKFPP(this HDJIIBHPEAK AOFIGDLFNLH, float FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E17470", Offset = "0x1E16670", VA = "0x181E17470")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> OKCDNKPKKCO(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E14AB0", Offset = "0x1E13CB0", VA = "0x181E14AB0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> GFMDNPJFEMO(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, int IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1E15530", Offset = "0x1E14730", VA = "0x181E15530")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> HFCLPENFKCO(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E138B0", Offset = "0x1E12AB0", VA = "0x181E138B0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BOMKIDBPMMB(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1E15160", Offset = "0x1E14360", VA = "0x181E15160")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> HCIAEKGHMHH(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> FHBLBAOOOJK, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> MBMHCOFAJGH)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1E17900", Offset = "0x1E16B00", VA = "0x181E17900")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> PAHNAKJNDLE(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, int IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1E132A0", Offset = "0x1E124A0", VA = "0x181E132A0")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BBMBIEFCCOJ(this HDJIIBHPEAK AOFIGDLFNLH, int FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1E15D70", Offset = "0x1E14F70", VA = "0x181E15D70")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> JIALHGKHGBD(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> FIHKLKHJMDI, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> IGBFJJKBGJO)
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x28A3AF0", Offset = "0x28A2CF0", VA = "0x1828A3AF0")]
	public static void CMCHCBJKDHI<TDeps, TState>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TState GAEMKAANAID, KHCIOCBLCGC<DAPCHLKNEIJ> LJNKNBHIGCI, [In] ReadOnlySpan<KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>> DJLAFEGNIPL, [In] ReadOnlySpan<int?> FDKIKNFHGIB, [In] Span<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> MJCFJGBIDFL, [In] Span<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> IIANCIODEON, [In] ReadOnlySpan<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>?> MAEFCIENMAD) where TDeps : notnull, PDDCBKKGIKA<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x28A5F00", Offset = "0x28A5100", VA = "0x1828A5F00")]
	public static void PIAMGAFGFMC<TDeps, TState>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TState GAEMKAANAID, KHCIOCBLCGC<GALILFHDLFP> CMJCJMMJFOB, [In] ReadOnlySpan<KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>> LCMLIABNGBC, [In] ReadOnlySpan<int?> FDKIKNFHGIB, [In] Span<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> MJCFJGBIDFL, [In] Span<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>> IIANCIODEON, [In] ReadOnlySpan<KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>?> MAEFCIENMAD) where TDeps : notnull, PDDCBKKGIKA<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x28A3E50", Offset = "0x28A3050", VA = "0x1828A3E50")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> COKBGNDHPOM<TDeps, TState>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TState GAEMKAANAID, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> HHMNPIECDNO, [Optional] KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>? JFGPAIHHEJK) where TDeps : notnull, PDDCBKKGIKA<TState> where TState : notnull
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x28A4150", Offset = "0x28A3350", VA = "0x1828A4150")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> DMHEJGJNGNO<TDeps, TState>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TState GAEMKAANAID, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> HHAPFKMDMFE, [Optional] KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>? JFGPAIHHEJK) where TDeps : notnull, PDDCBKKGIKA<TState> where TState : notnull
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x28A62A0", Offset = "0x28A54A0", VA = "0x1828A62A0")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> PMDPKAAGKCK<TDeps, TStateSys>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TStateSys CBIDDJLFENO) where TDeps : notnull, PDDCBKKGIKA<TStateSys> where TStateSys : notnull
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x28A4470", Offset = "0x28A3670", VA = "0x1828A4470")]
	public static KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH> FHGGGEEEPDL<TDeps, TStateSys>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TStateSys CBIDDJLFENO) where TDeps : notnull, PDDCBKKGIKA<TStateSys> where TStateSys : notnull
	{
		return default(KHCIOCBLCGC<LJHOLFHPHEN.DHNHAMABCCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1E15650", Offset = "0x1E14850", VA = "0x181E15650")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> HGCONHJMAGF(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> CLJHNPFGNJD, IntPtr NHPPFNLGPFN, IntPtr HMILLCJCMNE)
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1E14E60", Offset = "0x1E14060", VA = "0x181E14E60")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> HCFKFFNNLOF(this HDJIIBHPEAK AOFIGDLFNLH, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> DJDCOFMIBLD, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> CMIMKJJPONF, IntPtr HADDMCOHNOP, IntPtr CEGFIDJENIB, IntPtr BNMCPAGPJDA, bool NKGLLGANJLI)
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x28A5100", Offset = "0x28A4300", VA = "0x1828A5100")]
	public static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> JDHIHCKAHHO<TDeps, TState>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TState GAEMKAANAID, KHCIOCBLCGC<DAPCHLKNEIJ> PDGGACAHKJB, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> DJDCOFMIBLD, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> CMIMKJJPONF, int? GHHNBMAGLNA, [Optional] IntPtr FIGNCKGEJAD) where TDeps : notnull, PDDCBKKGIKA<TState> where TState : notnull
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x28A52D0", Offset = "0x28A44D0", VA = "0x1828A52D0")]
	private static KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> JDHIHCKAHHO<TDeps, TState>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TState GAEMKAANAID, KHCIOCBLCGC<DAPCHLKNEIJ> PDGGACAHKJB, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> DJDCOFMIBLD, KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN> CMIMKJJPONF, int? GHHNBMAGLNA) where TDeps : notnull, PDDCBKKGIKA<TState> where TState : notnull
	{
		return default(KHCIOCBLCGC<EECMGPGGMMN.OGJIFKEFGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x28A5900", Offset = "0x28A4B00", VA = "0x1828A5900")]
	public static KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> MIHIJDFNCMK<TDeps, TState>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TState GAEMKAANAID, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM> BOAMPKDFKLM, KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>? JFGPAIHHEJK) where TDeps : notnull, PDDCBKKGIKA<TState> where TState : notnull
	{
		return default(KHCIOCBLCGC<PKLCJMAMNHC.DJLMEABLEJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x28A4780", Offset = "0x28A3980", VA = "0x1828A4780")]
	public static void IGJFLAAEDIK<TDeps, TState>(this HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TState GAEMKAANAID, int KODFABLNGFD) where TDeps : notnull, PDDCBKKGIKA<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct JANGJBHFCGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> KNMPBMPEHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> BOLLHBLBDJM;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
	public JANGJBHFCGM(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> JIMBPILEMLA, KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> HINDFEEGBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1E1AED0", Offset = "0x1E1A0D0", VA = "0x181E1AED0")]
	public static JANGJBHFCGM DHBNKMCPKNO(KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>> JIMBPILEMLA)
	{
		return default(JANGJBHFCGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct PKLCJMAMNHC
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class AMEDACFGNKJ : FLGDDHMBHIN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct FHNKDFKOOII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> KCNMDOBNANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int ABDHHHCLNNL;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
		public FHNKDFKOOII(KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> EIKMNOPBMON, int MBGANDEDPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class HEOECIBNECM : FLGDDHMBHIN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct BCIPHJFCHNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int ABDHHHCLNNL;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		public BCIPHJFCHNM(int MBGANDEDPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class CKALAHNCNIP : FLGDDHMBHIN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct APIFNDCIHBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> KCNMDOBNANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int ABDHHHCLNNL;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
		public APIFNDCIHBO(KHCIOCBLCGC<LLNBEADKHBC.FAHHOGNCDFF> EIKMNOPBMON, int MBGANDEDPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum PAKHLNJPKBC
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
	public sealed class DJLMEABLEJM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class FLGDDHMBHIN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NALMPCBGADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? NNGCLLEDABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public JANGJBHFCGM CJDDJINLMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PAKHLNJPKBC MINFKFPAGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public KHCIOCBLCGC<FLGDDHMBHIN> DMFEMOHADNM;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1E1BB40", Offset = "0x1E1AD40", VA = "0x181E1BB40")]
		public NALMPCBGADJ(int? LHKLODKBIIB, [In] JANGJBHFCGM DNKHKOBEAAG, PAKHLNJPKBC FAKHFDMMGEO, KHCIOCBLCGC<FLGDDHMBHIN> IDBNNJHIGAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class GIGPEEMBHLA : FLGDDHMBHIN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct CBILHNFHDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int ABDHHHCLNNL;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0")]
		public CBILHNFHDAC(int MBGANDEDPDN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal JDLICIOAPBG<DJLMEABLEJM, NALMPCBGADJ> FFKKCGCHMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal JDLICIOAPBG<AMEDACFGNKJ, FHNKDFKOOII> GOHNCHMAIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal JDLICIOAPBG<CKALAHNCNIP, APIFNDCIHBO> LIPHEOCFFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal JDLICIOAPBG<GIGPEEMBHLA, CBILHNFHDAC> JIOHBCEHHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal JDLICIOAPBG<HEOECIBNECM, BCIPHJFCHNM> IAECEPPEFFA;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CB30", Offset = "0x1E1BD30", VA = "0x181E1CB30")]
	private PKLCJMAMNHC([In] JDLICIOAPBG<DJLMEABLEJM, NALMPCBGADJ> NIDKAKIFEFL, [In] JDLICIOAPBG<AMEDACFGNKJ, FHNKDFKOOII> KOEECOCGMLG, [In] JDLICIOAPBG<CKALAHNCNIP, APIFNDCIHBO> JNHKBFCHBML, [In] JDLICIOAPBG<GIGPEEMBHLA, CBILHNFHDAC> CFONJPMMCOF, [In] JDLICIOAPBG<HEOECIBNECM, BCIPHJFCHNM> HILAFLLKFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C940", Offset = "0x1E1BB40", VA = "0x181E1C940")]
	public static PKLCJMAMNHC DHBNKMCPKNO()
	{
		return default(PKLCJMAMNHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class OKIBDPPDMHN
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1E1BE20", Offset = "0x1E1B020", VA = "0x181E1BE20")]
	public static void CJPKHGMGMMP(this PKLCJMAMNHC AOFIGDLFNLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class PFBFMHBFEFM
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C570", Offset = "0x1E1B770", VA = "0x181E1C570")]
	public static void OFGPKDDGEPG(HDJIIBHPEAK AOFIGDLFNLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct ONEODBBOKLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, MHPIAIHJMLM> OIBEPKHMEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int JAFCKAMGGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int IGMLCKBJGEG;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C4B0", Offset = "0x1E1B6B0", VA = "0x181E1C4B0")]
	private ONEODBBOKLA([In] FNDGEEMAGCJ<LLNBEADKHBC.FCPEOKCBKEE, MHPIAIHJMLM> HHCGLGEKDLG, int PDMMMCFKKFL, int PACPIKABKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C440", Offset = "0x1E1B640", VA = "0x181E1C440")]
	public static ONEODBBOKLA DHBNKMCPKNO()
	{
		return default(ONEODBBOKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C270", Offset = "0x1E1B470", VA = "0x181E1C270")]
	public void CJPKHGMGMMP([In] HDJIIBHPEAK GHJMNPMPIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2A08840", Offset = "0x2A07A40", VA = "0x182A08840")]
	public static void OFGPKDDGEPG<TDeps, TStateSys>(HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TStateSys CBIDDJLFENO, KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN) where TDeps : notnull, PDDCBKKGIKA<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class MLNBDLDKDEA
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B990", Offset = "0x1E1AB90", VA = "0x181E1B990")]
	public static void OFGPKDDGEPG(HDJIIBHPEAK AOFIGDLFNLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct OKOHDOCPNBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface NGLLMDCJHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BEJBDKHJJNM(HKBGLAIKAIG<byte> FFDOMAPLKNG, int EDJKILCJOIN);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct OPNMMCKOGCC : NGLLMDCJHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C4F0", Offset = "0x1E1B6F0", VA = "0x181E1C4F0", Slot = "4")]
		public void BEJBDKHJJNM(HKBGLAIKAIG<byte> FFDOMAPLKNG, int EDJKILCJOIN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct HMFGAGDICCE : NGLLMDCJHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1E18A90", Offset = "0x1E17C90", VA = "0x181E18A90", Slot = "4")]
		public void BEJBDKHJJNM(HKBGLAIKAIG<byte> FFDOMAPLKNG, int EDJKILCJOIN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct MFOPKKGBMFP : NGLLMDCJHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B810", Offset = "0x1E1AA10", VA = "0x181E1B810", Slot = "4")]
		public void BEJBDKHJJNM(HKBGLAIKAIG<byte> FFDOMAPLKNG, int EDJKILCJOIN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct PFFHHDNIAJK : NGLLMDCJHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C6D0", Offset = "0x1E1B8D0", VA = "0x181E1C6D0", Slot = "4")]
		public void BEJBDKHJJNM(HKBGLAIKAIG<byte> FFDOMAPLKNG, int EDJKILCJOIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class EFPJNECEPGJ<TCallProcessorDeps> where TCallProcessorDeps : struct, NGLLMDCJHAB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps IDCMPNFONAH;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x266B940", Offset = "0x266AB40", VA = "0x18266B940")]
		public static int OFGPKDDGEPG<TDeps, TStateSys>(TDeps OAENIJAKBHE, TStateSys GAEMKAANAID, HDJIIBHPEAK GHJMNPMPIHD, [In] HKBGLAIKAIG<byte> CLAJIFGEOEO, int EONFPFAGAFM) where TDeps : PDDCBKKGIKA<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private HKBGLAIKAIG<CNDCMIGJPKH> LIFNEDHHAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>> AMDEJMOLKHJ;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C230", Offset = "0x1E1B430", VA = "0x181E1C230")]
	private OKOHDOCPNBJ([In] HKBGLAIKAIG<CNDCMIGJPKH> KKBDDDGCIFD, Dictionary<KHCIOCBLCGC<OODMOBKKOGN<DLJPCDCPPIO>>, KHCIOCBLCGC<LLNBEADKHBC.FCPEOKCBKEE>> PDNJCOHAPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C170", Offset = "0x1E1B370", VA = "0x181E1C170")]
	public static OKOHDOCPNBJ DHBNKMCPKNO()
	{
		return default(OKOHDOCPNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C130", Offset = "0x1E1B330", VA = "0x181E1C130")]
	public void CJPKHGMGMMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2A055C0", Offset = "0x2A047C0", VA = "0x182A055C0")]
	public static void OFGPKDDGEPG<TDeps, TStateSys>(HDJIIBHPEAK AOFIGDLFNLH, TDeps OAENIJAKBHE, TStateSys CBIDDJLFENO) where TDeps : PDDCBKKGIKA<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class DBLPEJDBHMF<TDeps, TIndex, TValues> where TDeps : struct, NHDGKMLOGJA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps IDCMPNFONAH;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x50857E0", Offset = "0x50849E0", VA = "0x1850857E0")]
	public static void OFGPKDDGEPG([In] HKBGLAIKAIG<CNDCMIGJPKH> KKBDDDGCIFD, int KGOAPCDMCLM, TValues DBIFCPFENHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NHDGKMLOGJA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKBGLAIKAIG<TIndex> NMACCIEBBPH(int KGOAPCDMCLM, [In] TValues DBIFCPFENHC);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(TIndex MBGANDEDPDN, [In] TValues DBIFCPFENHC);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNGMAHFNDBP(TIndex MBGANDEDPDN, TValues DBIFCPFENHC, KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> EKDDCPALANJ);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface GBDKEGOECAF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex DFCLPHBGFDE(int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFKIBNOJMEM(TIndex MBGANDEDPDN, [In] TValues DBIFCPFENHC);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KHCIOCBLCGC<OODMOBKKOGN<GBCLANPIBGE>> DFOCCLACIBH(TIndex MBGANDEDPDN, [In] TValues DBIFCPFENHC);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FPKIBJANOJA<TDeps, TIndex, TValues> where TDeps : struct, GBDKEGOECAF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps IDCMPNFONAH;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x37CA160", Offset = "0x37C9360", VA = "0x1837CA160")]
	public static HKBGLAIKAIG<TIndex> OFGPKDDGEPG(int KGOAPCDMCLM, [In] TValues DBIFCPFENHC)
	{
		return default(HKBGLAIKAIG<TIndex>);
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
