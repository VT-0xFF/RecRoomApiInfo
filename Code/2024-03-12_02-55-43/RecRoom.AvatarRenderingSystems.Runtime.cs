using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.Avatars;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CMGJJOIKLEE]
public class FNOCMIMFMDO : IGDOBBEMGCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	protected readonly List<Mesh> GHAPAJCOKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly List<byte[]> IAPIHJLMGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly List<Matrix4x4> KOHADDKFDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly List<int> IMKFIEJEDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly List<bool> NMAOMMMIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected Allocator PBBBCKGFEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected HOKNGCNKPJB IFDKBJIKOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected byte KBKNNJNDMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected IList<int> HKCDJIPNGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected IList<int> DAGJMODAGCE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x600F150", Offset = "0x600E350", VA = "0x18600F150", Slot = "4")]
	public void KGAFJBPNBHA(Mesh JLFPINMNNGM, Matrix4x4 GBNMODHKNKM, byte[] OBLJIMMOJPI, bool NLMCPFBOPNA = false, BJHAEGIGCKI.FCJHAGDMNEH MJKPPOAHNBD = (BJHAEGIGCKI.FCJHAGDMNEH)0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x600F5D0", Offset = "0x600E7D0", VA = "0x18600F5D0", Slot = "5")]
	public void OLDGDDOCGGF(Allocator ECEHKFLCCDN, HOKNGCNKPJB FGNKKCECODI, byte NIGIGCLJKIJ, [Optional] IList<int> IEIBIMNGJBL, [Optional] IList<int> EBOMMCPCKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x600F4A0", Offset = "0x600E6A0", VA = "0x18600F4A0")]
	private static void NFDNFCKLPLJ(Mesh JLFPINMNNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x600F610", Offset = "0x600E810", VA = "0x18600F610")]
	public FNOCMIMFMDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[CMGJJOIKLEE]
public struct AINGPFEGKEO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[ReadOnly]
	public FKOBFNMCIIG GIFFEMNNJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public int GOBJIAGOGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public MDGKELIAFLG FEDGIGCFCMG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x600B3F0", Offset = "0x600A5F0", VA = "0x18600B3F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CMGJJOIKLEE]
[NativeContainer]
public struct MDGKELIAFLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct JBFPLIJJMNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Vector3 DAGDHHEHMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Vector3 NNFMJLGEBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Vector4 OHEDMONCPFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct LKJJOOJNHAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public half KNGFLNCKFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public half AMOIODBMEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public half OBAOJLGDFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public half CGKJBPIJBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public byte EKDJJMHBIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public byte AGNILNEGINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte HBLPJIIGKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public byte FAJDCMJINJD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct ELAKICEOKLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public half4 DKDNEEAJCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public half2 CBJIMNFFDNP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BKKODFMINGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public half4 DKDNEEAJCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public half2 CBJIMNFFDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public half2 LKIEJBHAPMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct NKLMBIIAINE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public half4 DKDNEEAJCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public half2 CBJIMNFFDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public half2 LKIEJBHAPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public half2 MHKLFBLPPNG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct CBIBLGOOGON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public half4 DKDNEEAJCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half2 CBJIMNFFDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half2 LKIEJBHAPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half2 MHKLFBLPPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half2 HPHBIAPMAEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ELGLMAHJJCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float KNGFLNCKFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public float AMOIODBMEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public float OBAOJLGDFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float CGKJBPIJBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int EKDJJMHBIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int AGNILNEGINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int HBLPJIIGKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int FAJDCMJINJD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct MDFCANJPLAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Color DKDNEEAJCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Vector2 CBJIMNFFDNP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct BKMHPDMALLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Color DKDNEEAJCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector2 CBJIMNFFDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector2 LKIEJBHAPMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AIHLLLFPEJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Color DKDNEEAJCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Vector2 CBJIMNFFDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Vector2 LKIEJBHAPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Vector2 MHKLFBLPPNG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct NHFHBDFEDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Color DKDNEEAJCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Vector2 CBJIMNFFDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Vector2 LKIEJBHAPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Vector2 MHKLFBLPPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Vector2 HPHBIAPMAEJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool PDKCLKFNEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<JBFPLIJJMNO> HMCPAIACEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<ELAKICEOKLO> CHGIIFFKDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<BKKODFMINGM> PHBBLBGDNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<NKLMBIIAINE> PHDIJBICBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<CBIBLGOOGON> GAOFNHICHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<LKJJOOJNHAI> LIIKGCNILNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<MDFCANJPLAP> EIGOCOPJELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<BKMHPDMALLC> BGLHJEBAKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<AIHLLLFPEJM> KKFPKNFCEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<NHFHBDFEDBM> KBLLFKENHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<ELGLMAHJJCF> JHAJNAMHCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<int> MANOANOLPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<int> BKPKOEEOOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private NativeArray<int> DFLHKBLMPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NativeArray<int> MKFNIAFIIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> MNNFIAJHCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> JPJGJAIDLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<int> JPIHFDFJABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<BoneWeight> DNHELGNCJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> BFBOJFAJKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool OIBKPFHKADN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AFCBEEFJMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6014120", Offset = "0x6013320", VA = "0x186014120")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6014100", Offset = "0x6013300", VA = "0x186014100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JNLIOPBKNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6014110", Offset = "0x6013310", VA = "0x186014110")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6012E50", Offset = "0x6012050", VA = "0x186012E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int MODKPGBIIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6014130", Offset = "0x6013330", VA = "0x186014130")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6014140", Offset = "0x6013340", VA = "0x186014140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MGEECAOLJDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6012DE0", Offset = "0x6011FE0", VA = "0x186012DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6014150", Offset = "0x6013350", VA = "0x186014150")]
	public MDGKELIAFLG(int AHFGPKIHMLK, int EHOPHCDFHGK, int NBBKAJFJDEI, int LODDBKNMMPF, Allocator ECEHKFLCCDN, int HNOJMOAIIMB, CPHPBEHLLED CEMJKNFIEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6012E60", Offset = "0x6012060", VA = "0x186012E60")]
	public void JPIBALLHKDA(int ILNNGHKJMBD, Vector3 NGEKMKMEBJI, Vector3 GCKJNKIBEKP, Vector4 LFCIAEJOMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6013DD0", Offset = "0x6012FD0", VA = "0x186013DD0")]
	public void LNNKPBIDMEO(int ILNNGHKJMBD, BoneWeight NCOADAECPLM, NativeSlice<byte> OBLJIMMOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6012AC0", Offset = "0x6011CC0", VA = "0x186012AC0")]
	public Color IGOPFPCGNBG(int ILNNGHKJMBD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60126C0", Offset = "0x60118C0", VA = "0x1860126C0")]
	public void EBKFGNKPFBJ(int ILNNGHKJMBD, Color IKNBBOHGFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6012080", Offset = "0x6011280", VA = "0x186012080")]
	public void ABPDGHDBJAO(byte GOBPNKJKGKE, int ILNNGHKJMBD, Vector2 OCLBOPLEPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6012EF0", Offset = "0x60120F0", VA = "0x186012EF0")]
	public void KEFFIOMHFOH(int ILNNGHKJMBD, int NJGHPGGDOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6012420", Offset = "0x6011620", VA = "0x186012420")]
	public bool ANECDJGEMIA(int GOBPNKJKGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6012F00", Offset = "0x6012100", VA = "0x186012F00")]
	public void KHPHJILEEOC(int FLCIEDEBPMI, int GNHLLBKBLJF, int NCLKCGHBFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6012480", Offset = "0x6011680", VA = "0x186012480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6012FD0", Offset = "0x60121D0", VA = "0x186012FD0")]
	public Mesh LCOBCDAJDLK([Optional] string JLFMLHFPJHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
[CMGJJOIKLEE]
[NativeContainer]
public struct FKOBFNMCIIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Mesh.MeshDataArray OMBGIHBJBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> DPMEIAIJGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<int> GDFKFKLBCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<BoneWeight> DNHELGNCJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<Matrix4x4> JHILIGLLADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> HOBJLIACPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<byte> GIPEAEPCMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<int> DGALJMJICMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<int> CNJEGDFNOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<sbyte> LJKFANBLFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<byte> MLIHGMHGDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<int> HJHKJODOHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool OIBKPFHKADN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PADLEHABIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x600DE90", Offset = "0x600D090", VA = "0x18600DE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GHCCHBPEPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x600DE80", Offset = "0x600D080", VA = "0x18600DE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int DEHOBNMPFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x600DEC0", Offset = "0x600D0C0", VA = "0x18600DEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int AGKDLKNBHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x600DF90", Offset = "0x600D190", VA = "0x18600DF90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x600DC20", Offset = "0x600CE20", VA = "0x18600DC20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int AFCBEEFJMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x600DEB0", Offset = "0x600D0B0", VA = "0x18600DEB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x600DEA0", Offset = "0x600D0A0", VA = "0x18600DEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IHNNDBPDEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x600DE40", Offset = "0x600D040", VA = "0x18600DE40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x600DE70", Offset = "0x600D070", VA = "0x18600DE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HOKNGCNKPJB EJPCCPNAGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x600DE50", Offset = "0x600D050", VA = "0x18600DE50")]
		get
		{
			return default(HOKNGCNKPJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x600DE60", Offset = "0x600D060", VA = "0x18600DE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte DCJLKPKFKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x600DA20", Offset = "0x600CC20", VA = "0x18600DA20")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x600DA10", Offset = "0x600CC10", VA = "0x18600DA10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EPCLEGAMOHF ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x600DC30", Offset = "0x600CE30", VA = "0x18600DC30")]
		get
		{
			return default(EPCLEGAMOHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x600DFA0", Offset = "0x600D1A0", VA = "0x18600DFA0")]
	public FKOBFNMCIIG(IList<Mesh> ODAGABLOLIH, IList<Matrix4x4> IKMFABDNGEE, byte NIGIGCLJKIJ, IList<byte[]> ICIIFIMLFMI, IList<int> JDHBMNJJAIK, IList<bool> DPHMLGLOGJF, IList<int> IEIBIMNGJBL, IList<int> HGKADGBMLLB, Allocator ECEHKFLCCDN, HOKNGCNKPJB FGNKKCECODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x600DB70", Offset = "0x600CD70", VA = "0x18600DB70")]
	public MDGKELIAFLG FFMACHOKHBG(Allocator ECEHKFLCCDN, CPHPBEHLLED CEMJKNFIEBJ)
	{
		return default(MDGKELIAFLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x600DA30", Offset = "0x600CC30", VA = "0x18600DA30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[CMGJJOIKLEE]
public class LLMGDDMHDBK : FNOCMIMFMDO
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6011EC0", Offset = "0x60110C0", VA = "0x186011EC0")]
	public FKOBFNMCIIG KFLCPDGPPLF()
	{
		return default(FKOBFNMCIIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x600F610", Offset = "0x600E810", VA = "0x18600F610")]
	public LLMGDDMHDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EPCLEGAMOHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Mesh.MeshData MPENAOEGFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public NativeSlice<BoneWeight> DNHELGNCJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeSlice<byte> OPNIBKDDBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int DNMIMGMAALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Matrix4x4 HOCJNMEAJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int LEDBFEHDBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeSlice<byte> OBLJIMMOJPI;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NHMGPAIJFOH : NHMMPKEDMBO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private abstract class LGOCMEJIBPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly MGDKKCABMBA EALMBFEBBBN;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public virtual bool JDCJEGCMOHD
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public virtual bool ODPOAKBHMAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual BJHAEGIGCKI.FCJHAGDMNEH LEDBFEHDBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "6")]
			get
			{
				return default(BJHAEGIGCKI.FCJHAGDMNEH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool KHMCPGMFEFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x12E51B0", Offset = "0x12E43B0", VA = "0x1812E51B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool NOPLJPHCDMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6011EB0", Offset = "0x60110B0", VA = "0x186011EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool PIHOHIABNFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6011E90", Offset = "0x6011090", VA = "0x186011E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
		protected LGOCMEJIBPN(MGDKKCABMBA GLBMFEKPCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract GGFPJCKLNCF BLFEMKLBGNI(int[] NGPIIOGGPCA, List<KAICAHBHKID> FFCEOBPNBGE, List<KAICAHBHKID> EBKIDLJCDMP);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract AJHEBCKEBCG JHJBMBPEGIL(uint BKOOOMNKCNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private class NPHJIMIEIOP : LGOCMEJIBPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FIPDDFGHJJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public EGFEEHILLCB<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public NPHJIMIEIOP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public FIPDDFGHJJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x600D620", Offset = "0x600C820", VA = "0x18600D620")]
			internal void FPMBNKJKPHL(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly AvatarSkinAssetItem.HNAOEIDFNGN AJKFKEDEFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly AssetReference PEHMPFFDJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly BJHAEGIGCKI.FCJHAGDMNEH AMFDOMGECHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly FIGLDHCCOLD? NKIPAIDIPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly Material[] IAMMBOFFMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private SkinnedMeshRenderer[] JBIDPKNDLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private AvatarSkinAssetItem FJDKJCFCAJP;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override BJHAEGIGCKI.FCJHAGDMNEH LEDBFEHDBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7BF5B0", Offset = "0x7BE7B0", VA = "0x1807BF5B0", Slot = "6")]
			get
			{
				return default(BJHAEGIGCKI.FCJHAGDMNEH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6022F10", Offset = "0x6022110", VA = "0x186022F10")]
		public NPHJIMIEIOP(AvatarSkinAssetItem.HNAOEIDFNGN EGNDJPGNHHB, AssetReference KNEFFFNNBMF, Material DJNHLPPHDFE, MGDKKCABMBA EPNACNAFCGC, BJHAEGIGCKI.FCJHAGDMNEH DPNEOGLFHFF = (BJHAEGIGCKI.FCJHAGDMNEH)0, [Optional] FIGLDHCCOLD? KDBHEFNMBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6022E00", Offset = "0x6022000", VA = "0x186022E00")]
		public NPHJIMIEIOP(AvatarSkinAssetItem.HNAOEIDFNGN EGNDJPGNHHB, AssetReference KNEFFFNNBMF, Material DJNHLPPHDFE, BJHAEGIGCKI.FCJHAGDMNEH DPNEOGLFHFF = (BJHAEGIGCKI.FCJHAGDMNEH)0, [Optional] FIGLDHCCOLD? KDBHEFNMBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x60228F0", Offset = "0x6021AF0", VA = "0x1860228F0", Slot = "7")]
		public override GGFPJCKLNCF BLFEMKLBGNI(int[] NGPIIOGGPCA, List<KAICAHBHKID> FFCEOBPNBGE, List<KAICAHBHKID> EBKIDLJCDMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6022AC0", Offset = "0x6021CC0", VA = "0x186022AC0", Slot = "8")]
		public override AJHEBCKEBCG JHJBMBPEGIL(uint BKOOOMNKCNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6022D90", Offset = "0x6021F90", VA = "0x186022D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class MKIKDFOKAME : LGOCMEJIBPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly GALPOFDJMHK JEOOEMGKFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private EGFEEHILLCB<FMONKKGDIDJ> NHOLDLOBCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public FMONKKGDIDJ GDHBGCPCJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private EGFEEHILLCB<Material>[] MKHGJEOBCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public List<Material> OELJPHPDINA;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool JDCJEGCMOHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool ODPOAKBHMAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6015620", Offset = "0x6014820", VA = "0x186015620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1AED0F0", Offset = "0x1AEC2F0", VA = "0x181AED0F0")]
		public MKIKDFOKAME(MGDKKCABMBA GLBMFEKPCGL, GALPOFDJMHK FIKHDLBGCLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6014C80", Offset = "0x6013E80", VA = "0x186014C80", Slot = "7")]
		public override GGFPJCKLNCF BLFEMKLBGNI(int[] NGPIIOGGPCA, List<KAICAHBHKID> FFCEOBPNBGE, List<KAICAHBHKID> EBKIDLJCDMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6015680", Offset = "0x6014880", VA = "0x186015680", Slot = "8")]
		public override AJHEBCKEBCG JHJBMBPEGIL(uint BKOOOMNKCNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6015430", Offset = "0x6014630", VA = "0x186015430")]
		public AJHEBCKEBCG DDIAIHIKMFA(GameObject JLAPGINNIAF, uint BKOOOMNKCNJ, bool EHIMBAKAPIC, bool CKJCELKAKLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x60157B0", Offset = "0x60149B0", VA = "0x1860157B0")]
		public static bool LACGBNNMELP(Renderer[] MEENNDKAKNF, string BLOGKDEBNPM, [Out] Renderer ILNMLOIMIDF, [Out] Renderer NDHLNMMFDLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6015C20", Offset = "0x6014E20", VA = "0x186015C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6015280", Offset = "0x6014480", VA = "0x186015280")]
		private LNLGELINEJL CPCFPCLFKCM(bool CFCECLCGLBA = false)
		{
			return default(LNLGELINEJL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6015B20", Offset = "0x6014D20", VA = "0x186015B20")]
		private EGFEEHILLCB<Material>[] POGOKLJBBHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6E10", Offset = "0x3CB6010", VA = "0x183CB6E10")]
		[CompilerGenerated]
		private void FDAGPIPKNIA(FMONKKGDIDJ JKJJELABMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6014B50", Offset = "0x6013D50", VA = "0x186014B50")]
		[CompilerGenerated]
		private void AHOCIGMGENA(EGFEEHILLCB<Material> IOMIMAHHDKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6015220", Offset = "0x6014420", VA = "0x186015220")]
		[CompilerGenerated]
		private void CCCDBEPHFHB(Material JKJJELABMHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class LALAJKJFOEH : HEMKHKKCMAE<Task<(GameObject, AvatarItemMaterial)>, FMONKKGDIDJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct NNMJPAHMCHH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public Task<GameObject> goTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public Task<AvatarItemMaterial> materialTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private GameObject <go>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private TaskAwaiter<AvatarItemMaterial> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6022380", Offset = "0x6021580", VA = "0x186022380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6022880", Offset = "0x6021A80", VA = "0x186022880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly EGFEEHILLCB<GameObject> JGCGBMNAOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly EGFEEHILLCB<AvatarItemMaterial> ELPPDFABGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private GameObject MIJPOMBPNIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private AvatarItemMaterial APGCGELIKKO;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6011E00", Offset = "0x6011000", VA = "0x186011E00")]
		private LALAJKJFOEH(Task<(GameObject, AvatarItemMaterial)> GMIPPGJENPH, EGFEEHILLCB<GameObject> JECBKIFLNAP, EGFEEHILLCB<AvatarItemMaterial> ILCOMFNIGFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6011890", Offset = "0x6010A90", VA = "0x186011890")]
		public static LALAJKJFOEH JOAJPCKNCOB(GALPOFDJMHK KFGIIAJMBNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6011CD0", Offset = "0x6010ED0", VA = "0x186011CD0")]
		[AsyncStateMachine(typeof(NNMJPAHMCHH))]
		private static Task<(GameObject, AvatarItemMaterial)> KHOCLIIAFFI(Task<GameObject> JPDKOLJKMML, Task<AvatarItemMaterial> HIBGIPNNGPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x60117D0", Offset = "0x60109D0", VA = "0x1860117D0", Slot = "11")]
		protected override FMONKKGDIDJ IOFBHNLGLEK(Task<(GameObject, AvatarItemMaterial)> JIIAHKPEKAE)
		{
			return default(FMONKKGDIDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6011770", Offset = "0x6010970", VA = "0x186011770", Slot = "12")]
		protected override void DGPNIHPKHIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct LNLGELINEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private EGFEEHILLCB<FMONKKGDIDJ> AMJDMMJKDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private EGFEEHILLCB<Material>[] EBKIDLJCDMP;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x90CF80", Offset = "0x90C180", VA = "0x18090CF80")]
		public void MJNBEFJIABO([Out] EGFEEHILLCB<FMONKKGDIDJ> HGKLAMFJANK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6011F90", Offset = "0x6011190", VA = "0x186011F90")]
		public void MBADAFANOHI([Out] EGFEEHILLCB<Material>[] LLHHHEHENGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x90CFA0", Offset = "0x90C1A0", VA = "0x18090CFA0")]
		public LNLGELINEJL(EGFEEHILLCB<FMONKKGDIDJ> GCKJMNAHKNL, EGFEEHILLCB<Material>[] FCJNMBKENDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CMFNHPOGACH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public NHMGPAIJFOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public GACIPGFALDC buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public CMFNHPOGACH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x600CE50", Offset = "0x600C050", VA = "0x18600CE50")]
		internal void DGHPEDDAPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x600CE70", Offset = "0x600C070", VA = "0x18600CE70")]
		internal void ELODGJFFOAJ(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x600CDC0", Offset = "0x600BFC0", VA = "0x18600CDC0")]
		internal void AFAINGHANBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x600CE90", Offset = "0x600C090", VA = "0x18600CE90")]
		internal void INBOKPGNODI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
		internal GGFPJCKLNCF MKPAAMHPLLC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DPEOPHBAGEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public CMFNHPOGACH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public DPEOPHBAGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x600CF20", Offset = "0x600C120", VA = "0x18600CF20")]
		internal LCLGKOLCEML EKBBMNPJPMF(int lod)
		{
			return default(LCLGKOLCEML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GLDFCBPCLDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<GACIPGFALDC> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public GLDFCBPCLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x600F7D0", Offset = "0x600E9D0", VA = "0x18600F7D0")]
		internal void ONAJIDEMDGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KLJMJMIGDGH : IEnumerator<DHJAFLNNJKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private DHJAFLNNJKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public NHMGPAIJFOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<LGOCMEJIBPN> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public List<GACIPGFALDC> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Func<int, LCLGKOLCEML> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public LECMCMHIHPB materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private DHJAFLNNJKE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
		[DebuggerHidden]
		public KLJMJMIGDGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6011510", Offset = "0x6010710", VA = "0x186011510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6011720", Offset = "0x6010920", VA = "0x186011720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ABCFFLLMKJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public NHMGPAIJFOH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public ABCFFLLMKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x600B3A0", Offset = "0x600A5A0", VA = "0x18600B3A0")]
		internal GGFPJCKLNCF KIIDLEHCFJL(LGOCMEJIBPN p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DFICFHABKEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public CEOBMCGIDOD cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public DFICFHABKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x82CB50", Offset = "0x82BD50", VA = "0x18082CB50")]
		internal void JKEDELGPGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E50", Offset = "0x8C4050", VA = "0x1808C4E50")]
		internal void IOEJHAPNKKI(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class GKPAFHABDKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public NHMGPAIJFOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public GKPAFHABDKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class FDDLKDCFPOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public MDGKELIAFLG defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public FKOBFNMCIIG defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public GKPAFHABDKD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public FDDLKDCFPOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x600D050", Offset = "0x600C250", VA = "0x18600D050")]
		internal void LNEBCEKLAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x600CFE0", Offset = "0x600C1E0", VA = "0x18600CFE0")]
		internal void LDEGNCAILFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PLHGCJPPLHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public DJMFNGILBFG legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public ICKPJOOKFMN legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public GKPAFHABDKD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public PLHGCJPPLHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x60230E0", Offset = "0x60222E0", VA = "0x1860230E0")]
		internal void GKIMOOKMHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6023070", Offset = "0x6022270", VA = "0x186023070")]
		internal void DEPIGACOAPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class LOBEANOMOHG : IEnumerator<DHJAFLNNJKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private DHJAFLNNJKE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private DHJAFLNNJKE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
		[DebuggerHidden]
		public LOBEANOMOHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E30", Offset = "0x8C3030", VA = "0x1808C3E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6012030", Offset = "0x6011230", VA = "0x186012030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FFDNDKEIBDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CEOBMCGIDOD cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public GALPOFDJMHK avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public NHMGPAIJFOH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public FFDNDKEIBDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x600D2D0", Offset = "0x600C4D0", VA = "0x18600D2D0")]
		internal GGFPJCKLNCF BNGAEDGCFOB(IGKEFAKFOEN item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x600D5E0", Offset = "0x600C7E0", VA = "0x18600D5E0")]
		internal void DKKCOHBEKLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class PGMCNKBOCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public EGFEEHILLCB<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public PGMCNKBOCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6023020", Offset = "0x6022220", VA = "0x186023020")]
		internal void MAEKDKAPMEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class MHNFKKFJDFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MGDKKCABMBA overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public MHNFKKFJDFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6014AD0", Offset = "0x6013CD0", VA = "0x186014AD0")]
		internal bool AGJKIBJIHEP(KeyValuePair<string, GALPOFDJMHK> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private AvatarConfiguration PEBKGBOMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private Transform PJNODBBNDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private AssetReference PEHMPFFDJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private GameObject BLKFKKLDGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private GameObject IPPOFBKDHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private SkinnedMeshRenderer PHIJHLNMNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private Transform[] DPANALIALDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Matrix4x4[] AABGIDGOOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Material JHPAAJDFGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Material CPDMJJMNHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private Material EGBPFJDOPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Shader FLOHCAKPDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private Shader PAEIDAKHFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Animator OGGEPBEBEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Renderer[] DAGNIDEMOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private BJHAEGIGCKI.FCJHAGDMNEH FBFEOBMFJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private Color GOFGJHEPJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private Color GFIKNGIMKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Color CEPKEIAJDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Color? AMAFFPLMMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Color? PFJGBCGNCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Color? LMJOGBMFLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Color? AHHDGKNJAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private Texture2D LJBLBOIBDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Texture2D OLDICOONENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[CanBeNull]
	private GALPOFDJMHK OOCMAKGNPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Texture BLPMDBJBFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private Color OAGOLJFFADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Dictionary<Renderer, LECMCMHIHPB> IDOFHEFBKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Dictionary<Renderer, LECMCMHIHPB> PGKFOFCBMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Dictionary<string, List<OLFKJJEKOAH>> ELCPBLKDPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Dictionary<string, List<OLFKJJEKOAH>> JFDHHACMLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<KAICAHBHKID> MIDKKNDBJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<KAICAHBHKID> BMMNNIIMBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<KAICAHBHKID> IAGJFDHNHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly List<KAICAHBHKID> KKIIOJGOLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<OLFKJJEKOAH, Material> OENHHFKDKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<OLFKJJEKOAH, Material> FFIEHBDHILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private SkinnedMeshRenderer[] LFJOIKEEGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private SkinnedMeshRenderer[] OMGACOIIECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private SkinnedMeshRenderer[] NKKFBLCOAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private SkinnedMeshRenderer[] ELAEFMKPKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<string, EGFEEHILLCB<Texture2D>> NJGHOCMKMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<string, EGFEEHILLCB<Texture2D>> HNKLKIAONGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private FitMeshHemisphere AEPCIAMAGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool NCDDHPAMFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EBGHKLPIMLA HIDHJHAMKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool AIAMNBFLIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AnchorParamsRestrictions PFJHEINPJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool KFOHKGKBFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Transform PIGNIBCJODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform JCBDHBDAJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool NDHPIIEODEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x201")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool FLAGLJMHHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Vector3 GHJLINMLIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Quaternion DKKPECEICLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector2 IDEKNCEKEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private FitMeshHemisphere EADKBOGNEJL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material AFGLOLCIPDF;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material CHGKJLGDPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<string, GALPOFDJMHK> BKDDHBAIANO;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly int MAHGHMINIIA;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly int OBPELPPLPGP;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly int BAFADKKLGIG;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly int OMLDMIKIGHD;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly int KOJKDEABACC;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly int BOIBONJFIMN;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly int EPLJCKNGOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly DIKKIJJDOON OMJDFIOJOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DIKKIJJDOON JDOCOOBPLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool OPLFCHKICNK;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static Lazy<DLBONLJFPGA> BNNNBNIJHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Lazy<LHHIENEJIEN> KNAHNDEHAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Lazy<MAFBMPELBJK> KMPBGGGIAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private List<Action> AHBOOMPBLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private HJLLMGIJGIL HPNHAGJKEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private SkinnedMeshRenderer[] GMLCEPJMDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int FLMPPBOHIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool KOIJBOHJPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int BEMOOIEEJNL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GJGCJJLFMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6019C20", Offset = "0x6018E20", VA = "0x186019C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6016BF0", Offset = "0x6015DF0", VA = "0x186016BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool CHMEKEEBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xF218C0", Offset = "0xF20AC0", VA = "0x180F218C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Material BBODEEECMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x601D2C0", Offset = "0x601C4C0", VA = "0x18601D2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Material HEDNPGNBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6018420", Offset = "0x6017620", VA = "0x186018420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool NNMDOCFDDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static DLBONLJFPGA NHHLKAOCAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6015DB0", Offset = "0x6014FB0", VA = "0x186015DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private LHHIENEJIEN PAKJMMGCOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60197D0", Offset = "0x60189D0", VA = "0x1860197D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private MAFBMPELBJK JCMEBLADAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x601B710", Offset = "0x601A910", VA = "0x18601B710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DIKKIJJDOON AKKDFLIBGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B10A0", Offset = "0x9B02A0", VA = "0x1809B10A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DIKKIJJDOON GIDIOCIPKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x14BA140", Offset = "0x14B9340", VA = "0x1814BA140", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public SkinnedMeshRenderer[] MIDINMNEOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x16E0580", Offset = "0x16DF780", VA = "0x1816E0580", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Renderer[] MHCNFOBGCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C9370", Offset = "0x7C8570", VA = "0x1807C9370", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GHEHPHDOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6016E50", Offset = "0x6016050", VA = "0x186016E50", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BJHAEGIGCKI.FCJHAGDMNEH CPNMIDAENKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xE945F0", Offset = "0xE937F0", VA = "0x180E945F0", Slot = "18")]
		get
		{
			return default(BJHAEGIGCKI.FCJHAGDMNEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PGDAPKAGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8543F0", Offset = "0x8535F0", VA = "0x1808543F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6018510", Offset = "0x6017710", VA = "0x186018510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool BFGIGMAOIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6019C30", Offset = "0x6018E30", VA = "0x186019C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private static bool CFNFMJIOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6018C60", Offset = "0x6017E60", VA = "0x186018C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6021A60", Offset = "0x6020C60", VA = "0x186021A60")]
	public NHMGPAIJFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60160B0", Offset = "0x60152B0", VA = "0x1860160B0", Slot = "21")]
	public void AKCGAJHNOGB(PDBGDDIPIOJ KEOJDGJBDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6016B70", Offset = "0x6015D70", VA = "0x186016B70", Slot = "22")]
	public void BCMMBBGMEHK(KMKBPHENBJL OCGPAIIIBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6018510", Offset = "0x6017710", VA = "0x186018510", Slot = "4")]
	public void FCMLLONDDDN(int BKOOOMNKCNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x601CF10", Offset = "0x601C110", VA = "0x18601CF10", Slot = "9")]
	public void NJJMMMFJCBI(FAOHELEJAPG FILDBECHGHN, Texture2D AELEGKKIIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6018290", Offset = "0x6017490", VA = "0x186018290", Slot = "10")]
	public void ECFGNIAKKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x601C5B0", Offset = "0x601B7B0", VA = "0x18601C5B0", Slot = "11")]
	public bool MOHKODFOJKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6019820", Offset = "0x6018A20", VA = "0x186019820", Slot = "8")]
	public void HEBMNDDOKBO(IOJGNIHOLND MEBFMHNNIJG, Color? DKDNEEAJCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x601B5C0", Offset = "0x601A7C0", VA = "0x18601B5C0")]
	private void LEDLJEFJAPF(Action LJMALPIEKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6018150", Offset = "0x6017350", VA = "0x186018150", Slot = "5")]
	public void DMDJJBPLBMP(GALPOFDJMHK ABCBEEIDPKD, Texture KLDDIKBDCGK, Color BFHPFJPHMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6016BF0", Offset = "0x6015DF0", VA = "0x186016BF0", Slot = "6")]
	public void LKBPBMNKFFD(bool IDFIAIEINEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x14020E0", Offset = "0x14012E0", VA = "0x1814020E0", Slot = "7")]
	public void PHGLPMIIBMF(HJLLMGIJGIL BFBOJFAJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x601E440", Offset = "0x601D640", VA = "0x18601E440", Slot = "14")]
	public GACIPGFALDC PLHKOFDCNPD(IDKIBNOFEDF LJIBLDOCGEJ, bool GEMLMIOCKMA, int[] BALHCCGGOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x601DE00", Offset = "0x601D000", VA = "0x18601DE00", Slot = "15")]
	public void PHPDGJKCMOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60216A0", Offset = "0x60208A0", VA = "0x1860216A0")]
	private bool PMGMLJENGIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xE945B0", Offset = "0xE937B0", VA = "0x180E945B0", Slot = "19")]
	public void OIPMNMPFFLC(BJHAEGIGCKI.FCJHAGDMNEH FDCGJOIJGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x601C220", Offset = "0x601B420", VA = "0x18601C220")]
	private bool MGKGOEIGKEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x601C730", Offset = "0x601B930", VA = "0x18601C730")]
	private GACIPGFALDC MPIKMNLEJEN(bool GEMLMIOCKMA, List<LGOCMEJIBPN> DACDKGJJLBI, int[] BALHCCGGOLB, Func<int, LCLGKOLCEML> EMFKPJPNMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6017FB0", Offset = "0x60171B0", VA = "0x186017FB0")]
	[IteratorStateMachine(typeof(KLJMJMIGDGH))]
	private IEnumerator<DHJAFLNNJKE> DHJBJIJKMHD(bool GEMLMIOCKMA, List<LGOCMEJIBPN> DACDKGJJLBI, int[] BALHCCGGOLB, Func<int, LCLGKOLCEML> EMFKPJPNMLH, LECMCMHIHPB FCDBKEJOCJE, Material IAADCADIBNN, List<GACIPGFALDC> JOHNOJLCIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x601E180", Offset = "0x601D380", VA = "0x18601E180")]
	private GACIPGFALDC PKEGBILKGAF(List<LGOCMEJIBPN> DACDKGJJLBI, int[] BALHCCGGOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x601FA60", Offset = "0x601EC60", VA = "0x18601FA60")]
	private EKIPFMKCMNP PMBCDFDDLCC(List<LGOCMEJIBPN> DACDKGJJLBI, int BKOOOMNKCNJ, bool GEMLMIOCKMA, LCLGKOLCEML OFPJHGLBOBN, bool CAELCKKHEPM, LECMCMHIHPB FCDBKEJOCJE, Material IAADCADIBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x601A8A0", Offset = "0x6019AA0", VA = "0x18601A8A0")]
	private EKIPFMKCMNP KABLDNFAKLO(JobHandle PIKFKGPMACJ, bool GAAFMCIIIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6017CD0", Offset = "0x6016ED0", VA = "0x186017CD0")]
	private void COKEFHNCHEL(SkinnedMeshRenderer FIOCAEAANLI, Mesh JLFPINMNNGM, List<Material> AHEOOKHMNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	private void BODHEEAGEGM(int BKOOOMNKCNJ, long BGHMLODKOGN, long PGHKFMEFNIG, long FDPKCJGJPFD, long ILIHKGONOIP, long POPGIINFAFI, long IJMNHECGBKI, long AHJCCFJDDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x601D250", Offset = "0x601C450", VA = "0x18601D250")]
	[IteratorStateMachine(typeof(LOBEANOMOHG))]
	private IEnumerator<DHJAFLNNJKE> OCKPKPAOIOP(JobHandle HGKLAMFJANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x601B190", Offset = "0x601A390", VA = "0x18601B190")]
	private static Material LBIIEOKEEAA(Dictionary<OLFKJJEKOAH, Material> NHBENGPEMPE, Material NGCKOKMDNLE, BCBDLBMFPOA KKEJKOFBBMP, NHPPNPOJPFO PHPELMJDJJM, MGDKKCABMBA EPNACNAFCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x601D120", Offset = "0x601C320", VA = "0x18601D120")]
	private static BCBDLBMFPOA NMIEJLBAKKD(LGOCMEJIBPN PFOIKIGJJPB, int LEOJEBCAJAM)
	{
		return default(BCBDLBMFPOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6016590", Offset = "0x6015790", VA = "0x186016590")]
	private void ALIGDJNABNM(int KPKGHLHOAPA, Material FCJNMBKENDK, LGOCMEJIBPN PFOIKIGJJPB, [Out] Texture2D IGKOBBPADBA, [Out] Vector4 OHFNFBAMODM, [Out] Texture2D BBDLGIHBPMF, [Out] Texture2D BIICHDGMODI, [Out] Texture2D ADLNPEAONGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6018E00", Offset = "0x6018000", VA = "0x186018E00")]
	private void GDPBCNGLKHC(int KPKGHLHOAPA, Material FCJNMBKENDK, LGOCMEJIBPN PFOIKIGJJPB, [Out] Color PHMMGFDODMM, [Out] Color IAGEBALGGLE, [Out] Color GMCFGJFACMA, [Out] Color AMELCNDAJGI, [Out] Color IDPDNKPFOJM, [Out] Color IEFCANAINGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x601BFC0", Offset = "0x601B1C0", VA = "0x18601BFC0")]
	private bool MBKIKLMBFEA(Material FCJNMBKENDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6018BE0", Offset = "0x6017DE0", VA = "0x186018BE0")]
	private static Material FLOGENCDIOJ(int KPKGHLHOAPA, MKIKDFOKAME PFOIKIGJJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6016C00", Offset = "0x6015E00", VA = "0x186016C00")]
	private static NHPPNPOJPFO BGDFLKPOJKM(LGOCMEJIBPN PFOIKIGJJPB, int LEOJEBCAJAM)
	{
		return default(NHPPNPOJPFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x601C2E0", Offset = "0x601B4E0", VA = "0x18601C2E0")]
	private static void MMINBFLFPPP(Dictionary<string, List<OLFKJJEKOAH>> OPPKABJJMNI, LGOCMEJIBPN CMEEANGCGHD, Material NGCKOKMDNLE, BCBDLBMFPOA MEBFMHNNIJG, NHPPNPOJPFO FILDBECHGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6019D40", Offset = "0x6018F40", VA = "0x186019D40")]
	private static SkinnedMeshRenderer IBPBKGJADND(Transform ODJMCOPAKBL, Transform BJIKBMFHNEJ, SkinnedMeshRenderer[] MEENNDKAKNF, int BKOOOMNKCNJ, LCLGKOLCEML OFPJHGLBOBN, bool GEMLMIOCKMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6016370", Offset = "0x6015570", VA = "0x186016370")]
	private void ALFAJOAGABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x601D240", Offset = "0x601C440", VA = "0x18601D240")]
	private void NPOPLJKOACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x601A390", Offset = "0x6019590", VA = "0x18601A390")]
	private static void JLEDEIFMIII(Dictionary<OLFKJJEKOAH, Material> NHBENGPEMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6016CF0", Offset = "0x6015EF0", VA = "0x186016CF0")]
	private static void BGMJJPLEFGK(Dictionary<Renderer, LECMCMHIHPB> NBIKOLMNFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6015C70", Offset = "0x6014E70", VA = "0x186015C70")]
	private void AANJMKKOFPA(SkinnedMeshRenderer[] MEENNDKAKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6015EC0", Offset = "0x60150C0", VA = "0x186015EC0")]
	private void AFGJBPILMCN(SkinnedMeshRenderer PJPGBEJEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x601B3E0", Offset = "0x601A5E0", VA = "0x18601B3E0")]
	private void LDHPJGHNHJP(List<KAICAHBHKID> MGHDABPICLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6019300", Offset = "0x6018500", VA = "0x186019300")]
	private void GHNLGFHBEHK(Dictionary<string, EGFEEHILLCB<Texture2D>> OPPKABJJMNI, bool FPMABBLOIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x601B390", Offset = "0x601A590", VA = "0x18601B390")]
	private void LDAPOCAPCMN(Dictionary<string, List<OLFKJJEKOAH>> OPPKABJJMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x601BE60", Offset = "0x601B060", VA = "0x18601BE60")]
	private void MAIAKDOIGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6017B40", Offset = "0x6016D40", VA = "0x186017B40")]
	private void CINPMPFOIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x601D6F0", Offset = "0x601C8F0", VA = "0x18601D6F0")]
	private void OLJCLBIABIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x601B640", Offset = "0x601A840", VA = "0x18601B640")]
	private void LFMAPNAEDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6016A60", Offset = "0x6015C60", VA = "0x186016A60")]
	private void AOLDDOAGFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x601CCA0", Offset = "0x601BEA0", VA = "0x18601CCA0")]
	private void NGMJDCDEGGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x601DD30", Offset = "0x601CF30", VA = "0x18601DD30")]
	private void PAIHIFAMAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x601B2F0", Offset = "0x601A4F0", VA = "0x18601B2F0")]
	private void LCAFBCCGKAB(bool CPHDBFKDCBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x60181C0", Offset = "0x60173C0", VA = "0x1860181C0")]
	private void DPJAMKPMBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6018380", Offset = "0x6017580", VA = "0x186018380")]
	private void EKKNEFPOAEB(bool CPHDBFKDCBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x601AE50", Offset = "0x601A050", VA = "0x18601AE50")]
	private void LACALPPPLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x601AAE0", Offset = "0x6019CE0", VA = "0x18601AAE0")]
	private void KNHACPKHNEI(Material IAADCADIBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x601D5D0", Offset = "0x601C7D0", VA = "0x18601D5D0")]
	private void OKJOIFPEKIG(Material IAADCADIBNN, Color IAGEBALGGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x601D4E0", Offset = "0x601C6E0", VA = "0x18601D4E0")]
	private void OKGDGOJJIIM(Material IAADCADIBNN, Color GMCFGJFACMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x601DC40", Offset = "0x601CE40", VA = "0x18601DC40")]
	private void OMEMELODNOG(Material IAADCADIBNN, Color PHMMGFDODMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x601A960", Offset = "0x6019B60", VA = "0x18601A960")]
	private void KDECMJKLOGH(Material IAADCADIBNN, Texture2D AELEGKKIIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x601CDF0", Offset = "0x601BFF0", VA = "0x18601CDF0")]
	private void NGOGGLDKHNB(Material IAADCADIBNN, Texture ADMLDLCGECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6019480", Offset = "0x6018680", VA = "0x186019480")]
	private void GKBKGCHPFCN(Action<LECMCMHIHPB> ODKHEAADABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x601E000", Offset = "0x601D200", VA = "0x18601E000")]
	private void PIHNCLHFLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x601A000", Offset = "0x6019200", VA = "0x18601A000")]
	private void JDELCDEKNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6018560", Offset = "0x6017760", VA = "0x186018560")]
	private GACIPGFALDC FJMEGFHJBAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x601A4F0", Offset = "0x60196F0", VA = "0x18601A4F0")]
	private void JMOGILAOEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x601B790", Offset = "0x601A990", VA = "0x18601B790")]
	public void LLCABFEDFAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6018310", Offset = "0x6017510", VA = "0x186018310")]
	private void EIEPMEKJFNM(Vector3 PNLEOOLJLEF, Quaternion CJDLFPMECND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x601BB20", Offset = "0x601AD20", VA = "0x18601BB20")]
	private void LLMGPBECIFK(List<LGOCMEJIBPN> LBIBNMFNBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6017640", Offset = "0x6016840", VA = "0x186017640")]
	public void CDJJIBINEDI(EBGHKLPIMLA IBMKJDDEDAA, bool DEGPHAJBPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6016FC0", Offset = "0x60161C0", VA = "0x186016FC0")]
	public void CDJJIBINEDI(EBGHKLPIMLA IBMKJDDEDAA, AnchorParamsRestrictions PEAMHBHEFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8A8B00", Offset = "0x8A7D00", VA = "0x1808A8B00")]
	private static void KCBEKGJIFOJ(FitMeshHemisphere IJLNKOLLJOD, Transform HJPBOFAEMEH, EBGHKLPIMLA IBMKJDDEDAA, AnchorParamsRestrictions NJOMLDNOCMK, [Out] Vector3 FFOFALOECNI, [Out] Quaternion CPDEPCOMBII, [Out] EBGHKLPIMLA MBPIJLBDOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6017DF0", Offset = "0x6016FF0", VA = "0x186017DF0")]
	public void DFIKKHJJOEM(Vector2 HHFLOAEPGDF, Vector3 IBFKGOOJAAG, Vector3 KAJIHCBCIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6019640", Offset = "0x6018840", VA = "0x186019640")]
	private void GMKOHILJJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6015E30", Offset = "0x6015030", VA = "0x186015E30")]
	private void ACKJFHGCFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x601AA50", Offset = "0x6019C50", VA = "0x18601AA50")]
	[CompilerGenerated]
	private void KIDCNJMDPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60217E0", Offset = "0x60209E0", VA = "0x1860217E0")]
	[CompilerGenerated]
	private void PNHALFAOHKP(LECMCMHIHPB HGGMLOEDPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6015FF0", Offset = "0x60151F0", VA = "0x186015FF0")]
	[CompilerGenerated]
	private void AFMHADFNJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60197B0", Offset = "0x60189B0", VA = "0x1860197B0")]
	[CompilerGenerated]
	private void GOKNEIIGFKG(LECMCMHIHPB HGGMLOEDPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6019CB0", Offset = "0x6018EB0", VA = "0x186019CB0")]
	[CompilerGenerated]
	private void HOLFFBHIANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6015D90", Offset = "0x6014F90", VA = "0x186015D90")]
	[CompilerGenerated]
	private void ABGJMBPMJJD(LECMCMHIHPB HGGMLOEDPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x601D450", Offset = "0x601C650", VA = "0x18601D450")]
	[CompilerGenerated]
	private void OGEJGKPCHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6016080", Offset = "0x6015280", VA = "0x186016080")]
	[CompilerGenerated]
	private void AIONKMFOMDG(LECMCMHIHPB HGGMLOEDPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6018B50", Offset = "0x6017D50", VA = "0x186018B50")]
	[CompilerGenerated]
	private void FKAKKHFNBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x601A360", Offset = "0x6019560", VA = "0x18601A360")]
	[CompilerGenerated]
	private void JDJKAJCLBHN(LECMCMHIHPB HGGMLOEDPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6019F70", Offset = "0x6019170", VA = "0x186019F70")]
	[CompilerGenerated]
	private void IFFBJKCPNKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x601D6C0", Offset = "0x601C8C0", VA = "0x18601D6C0")]
	[CompilerGenerated]
	private void OLCBEDAILMM(LECMCMHIHPB HGGMLOEDPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60169D0", Offset = "0x6015BD0", VA = "0x1860169D0")]
	[CompilerGenerated]
	private void ANGFJDIHLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x601B760", Offset = "0x601A960", VA = "0x18601B760")]
	[CompilerGenerated]
	private void LJENBIKBEBL(LECMCMHIHPB HGGMLOEDPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6016AF0", Offset = "0x6015CF0", VA = "0x186016AF0")]
	[CompilerGenerated]
	private void APECNCMMANN(KeyValuePair<string, EGFEEHILLCB<Texture2D>> GBAHFGJIMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x60180C0", Offset = "0x60172C0", VA = "0x1860180C0")]
	[CompilerGenerated]
	private void DIILJOMLGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x601CEE0", Offset = "0x601C0E0", VA = "0x18601CEE0")]
	[CompilerGenerated]
	private void NIOAOIJKKND(LECMCMHIHPB HGGMLOEDPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6015F60", Offset = "0x6015160", VA = "0x186015F60")]
	[CompilerGenerated]
	private void AFJIGBCNAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6018530", Offset = "0x6017730", VA = "0x186018530")]
	[CompilerGenerated]
	private void FJKGFEGPOFF(LECMCMHIHPB HGGMLOEDPHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ILOGNEPBCFJ : ABNNEBAAPJA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct GICDIBHOJKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Vector2 DJJPPGMDCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public Vector2 ILLEGEFJDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Vector2 EFMLEJCLPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Vector2 JNALONJIHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Vector2 GKAAGAINKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Vector2 BJMOOBIMGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Vector2 OAFHBIMLLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Vector2 EEPKLLBKINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector2 AAONJKFBPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector2 CKKDECODBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Vector2 ONPLHLAJDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public Vector2 HBDEONOMJIA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly int LALFLIIMHGF;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly int FEOADFFPGJM;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly int MMJNENJHOPA;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly int JNPEDFAOHFG;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly int BKLPPNFAKBP;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly int MNDCNPEBFHD;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly int GNMBAJDIBJH;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int GBJGFLIJDEN;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int NJFCAMPIAOP;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int NFJLEMFNCHL;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int COBAFLGPAPI;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int BHIMPKJNLCN;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int ILKNGJKLINN;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int EJOPBIKFJIH;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int KFEKIFPCPBB;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int LABMKLKLCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int DPJPKDDEEBA;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int HADOJGGDGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private Transform JKBNDFAMABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private Transform FKLNJFFLGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Transform LPKLEDJJFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private Transform MDDCELPCKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Transform HIOLODGHMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private Transform ACEAMMCECBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Transform NHPDGNOMIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private MMEGNOPOMAL DJPAJGGDKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private MaterialPropertyBlock OGMAIHCKLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private SkinnedMeshRenderer[] GEFDNMIKJJA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private MaterialPropertyBlock BCDFKNCFPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x600FDF0", Offset = "0x600EFF0", VA = "0x18600FDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x600F900", Offset = "0x600EB00", VA = "0x18600F900", Slot = "6")]
	public void AKCGAJHNOGB(MMEGNOPOMAL JLMMNPBANHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x600FEE0", Offset = "0x600F0E0", VA = "0x18600FEE0", Slot = "7")]
	public void LDDAAHJMLGM(IHPPONBIPCH LOOPHDCDDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x600F9C0", Offset = "0x600EBC0", VA = "0x18600F9C0", Slot = "4")]
	public void APOHFEEAPCP(BCCLHPIHKJC AOOCNBMJFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6010640", Offset = "0x600F840", VA = "0x186010640", Slot = "5")]
	public void PIKJLDNNGEM(CPKLONGOPNH LOOPHDCDDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6010070", Offset = "0x600F270", VA = "0x186010070")]
	private void PCACPJHJJNA(CPKLONGOPNH CGPBHFGLBKN, GICDIBHOJKO DFLJAHKMKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x600FF90", Offset = "0x600F190", VA = "0x18600FF90")]
	private void OFEJCPCDFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60114B0", Offset = "0x60106B0", VA = "0x1860114B0")]
	public ILOGNEPBCFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x600FF10", Offset = "0x600F110", VA = "0x18600FF10")]
	[CompilerGenerated]
	private Vector4 NHJHGCNNIKB(Vector2 HBEJPCPOKJI, Vector2 LNFDMKEIMFC)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x600FE70", Offset = "0x600F070", VA = "0x18600FE70")]
	[CompilerGenerated]
	private Vector4 EEJOAKMDBAM(float PJPLHCBKIHG, float JDDLLNDBFOO, float PCJAINIGINJ, float FNFFHFJNDOF)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class LECMCMHIHPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private MaterialPropertyBlock NILFKDKPBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Color? DIDHCHDEGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Color? LHOGKNDCEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color? LMJKMDICGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color? DBKBBFBFBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color NMPBBHCAANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Color APCEKANBKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Color HCPKGPKBHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Texture2D MLFHPBIKAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Texture2D BLDDLJHBJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private Dictionary<OLFKJJEKOAH, int> JOJOHLNLOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private BCBDLBMFPOA[] IMAGGAGKHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NHPPNPOJPFO[] OCLPJACNFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Vector4[] CFBDPLGKKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Vector4[] GOCLHDAFONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] PCNIBAMLKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] FOIHLIAJAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4[] CPGFFHOGJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4[] KOJHDGEAOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private List<Texture2D> PKLLLNCJLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Vector4[] LLJKPEICNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> NJPKOJPGAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float[] LLKICPHEGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Vector4[] ELNPNLDNEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private float[] HNCFGOKOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public float[] BPMAHOADIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private List<Texture2D> NDFHDPAJFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private float[] DFHENHLEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private List<Texture2D> AILOCLPHBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Vector4[] MMCEELHEIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] NMEPGBLAOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Vector4[] KJEHCBFKJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public float[] DAKCGPHOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public Texture2DArray BIMBEDEPHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Texture2DArray GOJLPAPFBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Texture2DArray FABKHNGDLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Texture2DArray DIFINBEBBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private bool NCJIMBFFIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int PFEECOAEHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private Vector2? KEJBMIGBEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private TextureFormat PKENIKBGNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private Vector2? KMBDAAKLODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private TextureFormat DLKMFBKNNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private Vector2? HIMJAECIIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private TextureFormat HPDCDKPLHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Vector2? ILMLJKDBNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private TextureFormat FKLGACGMLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool GMBEAIDAPEH;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int DEPKHFIOEFI;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int LEHGEBMACBM;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int BHPODGKHOAN;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int DHNNDLPNDDC;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int KBCHMHONIIL;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int HPHJNEPIBHC;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int NGCKMNLPBJB;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int HPAJDOFMLDJ;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int JKDEJFEBCKH;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int KJOLJKDGBPP;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int LBPBMANFLGB;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int BIFGGGICLGP;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int DCBCBFMMEFI;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int OHFBHDGHCGP;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int EAMHPFHMJNI;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int CNKMMCGAANE;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int KCILJACAGJA;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int BFOEGPAKKOE;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int LJOPLNAPPDP;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static int CFOGPBBEGOM;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x602A890", Offset = "0x6029A90", VA = "0x18602A890")]
	private LECMCMHIHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x602A7D0", Offset = "0x60299D0", VA = "0x18602A7D0")]
	public LECMCMHIHPB(Color NLIGDOFNAIH, Color DMNJGPNBNMK, Color NPGNDAIKKPJ, Color? FHOMCFJHFOE, Color? DEHFFBBECEC, Color? EJIJFAKFFPB, Texture2D MNAEDIFCDIO, Texture2D EFKMIOOIBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x602A2C0", Offset = "0x60294C0", VA = "0x18602A2C0")]
	internal int PFKEIBBAHGK(Material OKDFFKDJEJN, BCBDLBMFPOA KKEJKOFBBMP, NHPPNPOJPFO PHPELMJDJJM, MGDKKCABMBA EPNACNAFCGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x602A3B0", Offset = "0x60295B0", VA = "0x18602A3B0")]
	private int PFKEIBBAHGK(OLFKJJEKOAH HKNPGHOCJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6028850", Offset = "0x6027A50", VA = "0x186028850")]
	internal int LKPLBAKONCH(Material OKDFFKDJEJN, Color PHMMGFDODMM, Color IAGEBALGGLE, Color GMCFGJFACMA, Color AMELCNDAJGI, Color IDPDNKPFOJM, Texture2D MMBEEFJLIDF, Vector4 EOHJCCOLDFP, Texture2D DOHNGJBKHLG, Vector4 CACHKGHKFKA, float DGKMLPFDDHA, float MIHBLAPJIBJ, Texture2D MJNFICOGNJE, Vector4 ALGCHJMLLFP, float NCFENOLGNAI, Texture2D DGIIFBLECGM, Color IEFCANAINGH, Vector4 NDFKKOBMHGF, BCBDLBMFPOA KKEJKOFBBMP, NHPPNPOJPFO PHPELMJDJJM, MGDKKCABMBA EPNACNAFCGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6028150", Offset = "0x6027350", VA = "0x186028150")]
	private void BODCPCPIGEP(List<Texture2D> PKLLLNCJLKN, [Out] Texture2DArray MGBOHOGMJCK, [Out] Texture2DArray MKDKNOAJDIC, [Out] Texture2DArray PPLOJOJNBHE, [Out] Texture2DArray DENLNNOIIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6029420", Offset = "0x6028620", VA = "0x186029420")]
	public void NINOLFPGLGC(Shader KMKJJCOJPEM, Renderer HGMIPNBELIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6029570", Offset = "0x6028770", VA = "0x186029570")]
	private void PAMNEDJOHDE(Shader KMKJJCOJPEM, Renderer HGMIPNBELIH, int PDOKOEIFALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6028350", Offset = "0x6027550", VA = "0x186028350")]
	private Color FGKBAGAGNOO(Color CCNMDAMHDHI, BCBDLBMFPOA MEBFMHNNIJG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6028650", Offset = "0x6027850", VA = "0x186028650")]
	private Color HBFLMHCLEFE(Color CDOMIBMEBNJ, BCBDLBMFPOA MEBFMHNNIJG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6028550", Offset = "0x6027750", VA = "0x186028550")]
	private bool HAEBDKIGEJI(Texture2D CICBLKPNGEF, NHPPNPOJPFO FILDBECHGHN, [Out] Texture2D NIGNCKKPDDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60287A0", Offset = "0x60279A0", VA = "0x1860287A0")]
	private void IBBNGEOMEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6028310", Offset = "0x6027510", VA = "0x186028310", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private ELPECABHBIN? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public EKDOJINKEPA CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6023EF0", Offset = "0x60230F0", VA = "0x186023EF0")]
			get
			{
				return default(EKDOJINKEPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public ELPECABHBIN MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6023F40", Offset = "0x6023140", VA = "0x186023F40")]
			get
			{
				return default(ELPECABHBIN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7BDF80", Offset = "0x7BD180", VA = "0x1807BDF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7C9450", Offset = "0x7C8650", VA = "0x1807C9450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6023B80", Offset = "0x6022D80", VA = "0x186023B80")]
		public Material[] GKKAIKMLNLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6023C60", Offset = "0x6022E60", VA = "0x186023C60")]
		public static void HEDJEHMOHLC(AvatarItemMaterial NPDGAFADOOD, Material FCJNMBKENDK, int KPKGHLHOAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6023E20", Offset = "0x6023020", VA = "0x186023E20")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[CMGJJOIKLEE]
public struct MNCIHDKDONH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	public ICKPJOOKFMN GIFFEMNNJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[ReadOnly]
	public int GOBJIAGOGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public DJMFNGILBFG FEDGIGCFCMG;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x602B130", Offset = "0x602A330", VA = "0x18602B130", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NativeContainer]
[CMGJJOIKLEE]
public struct DJMFNGILBFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Vector3> CEBPDKICPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<Vector3> PAPPGFPLFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector4> PHKNKHJEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector2> DPGIAHOAMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector2> MHKLFBLPPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> HPHBIAPMAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Vector2> HJIEINKMHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<Color> IHHHBMAIMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<int> MANOANOLPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> BKPKOEEOOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private NativeArray<int> DFLHKBLMPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private NativeArray<int> MKFNIAFIIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<int> MNNFIAJHCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> JPJGJAIDLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<int> JPIHFDFJABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<BoneWeight> DMCONHJPCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private NativeArray<int> BFBOJFAJKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private bool OIBKPFHKADN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int AFCBEEFJMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6024970", Offset = "0x6023B70", VA = "0x186024970")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6024950", Offset = "0x6023B50", VA = "0x186024950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int JNLIOPBKNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6024960", Offset = "0x6023B60", VA = "0x186024960")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6024300", Offset = "0x6023500", VA = "0x186024300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int MODKPGBIIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6024A30", Offset = "0x6023C30", VA = "0x186024A30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6024A40", Offset = "0x6023C40", VA = "0x186024A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6024A50", Offset = "0x6023C50", VA = "0x186024A50")]
	public DJMFNGILBFG(int AHFGPKIHMLK, int EHOPHCDFHGK, int NBBKAJFJDEI, int LODDBKNMMPF, Allocator ECEHKFLCCDN, int HNOJMOAIIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6024310", Offset = "0x6023510", VA = "0x186024310")]
	public void JPIBALLHKDA(int ILNNGHKJMBD, Vector3 NGEKMKMEBJI, Vector3 GCKJNKIBEKP, Vector4 LFCIAEJOMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x60247B0", Offset = "0x60239B0", VA = "0x1860247B0")]
	public void LNNKPBIDMEO(int ILNNGHKJMBD, BoneWeight NCOADAECPLM, NativeSlice<byte> OBLJIMMOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x60242E0", Offset = "0x60234E0", VA = "0x1860242E0")]
	public Color IGOPFPCGNBG(int ILNNGHKJMBD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x60242C0", Offset = "0x60234C0", VA = "0x1860242C0")]
	public void EBKFGNKPFBJ(int ILNNGHKJMBD, Color IKNBBOHGFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6024000", Offset = "0x6023200", VA = "0x186024000")]
	public void ABPDGHDBJAO(byte GOBPNKJKGKE, int ILNNGHKJMBD, Vector2 OCLBOPLEPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6024380", Offset = "0x6023580", VA = "0x186024380")]
	public void KEFFIOMHFOH(int ILNNGHKJMBD, int NJGHPGGDOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6024050", Offset = "0x6023250", VA = "0x186024050")]
	public bool ANECDJGEMIA(int GOBPNKJKGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6024390", Offset = "0x6023590", VA = "0x186024390")]
	public void KHPHJILEEOC(int FLCIEDEBPMI, int GNHLLBKBLJF, int NCLKCGHBFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6024980", Offset = "0x6023B80", VA = "0x186024980")]
	public int[] NJGGINALPHO(int FLCIEDEBPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6024080", Offset = "0x6023280", VA = "0x186024080")]
	private NativeSlice<int> DOPNJGCKAJB(int FLCIEDEBPMI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6024110", Offset = "0x6023310", VA = "0x186024110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6024460", Offset = "0x6023660", VA = "0x186024460")]
	public Mesh LCOBCDAJDLK([Optional] string JLFMLHFPJHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
[CMGJJOIKLEE]
[NativeContainer]
public struct ICKPJOOKFMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Vector3> CEBPDKICPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector3> PAPPGFPLFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector4> PHKNKHJEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector2> DPGIAHOAMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector2> MHKLFBLPPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector2> HPHBIAPMAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> HJIEINKMHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Color> IHHHBMAIMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<int> AJEFNFKNGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<int> CGGEKJFFNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> BHGJMCLCIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> FPAGOCKPEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> GDFKFKLBCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<BoneWeight> DNHELGNCJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private NativeArray<Matrix4x4> JHILIGLLADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private NativeArray<int> HOBJLIACPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private NativeArray<byte> GIPEAEPCMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NativeArray<int> DGALJMJICMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> CNJEGDFNOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<sbyte> LJKFANBLFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<byte> MLIHGMHGDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> HJHKJODOHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private bool OIBKPFHKADN;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int PADLEHABIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1DADE80", Offset = "0x1DAD080", VA = "0x181DADE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int GHCCHBPEPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xE945F0", Offset = "0xE937F0", VA = "0x180E945F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int DEHOBNMPFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x60267C0", Offset = "0x60259C0", VA = "0x1860267C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int AGKDLKNBHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x60267F0", Offset = "0x60259F0", VA = "0x1860267F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6026260", Offset = "0x6025460", VA = "0x186026260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int AFCBEEFJMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x60267B0", Offset = "0x60259B0", VA = "0x1860267B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x60267A0", Offset = "0x60259A0", VA = "0x1860267A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int IHNNDBPDEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6026760", Offset = "0x6025960", VA = "0x186026760")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6026790", Offset = "0x6025990", VA = "0x186026790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public HOKNGCNKPJB EJPCCPNAGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6026770", Offset = "0x6025970", VA = "0x186026770")]
		get
		{
			return default(HOKNGCNKPJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6026780", Offset = "0x6025980", VA = "0x186026780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public byte DCJLKPKFKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6025F50", Offset = "0x6025150", VA = "0x186025F50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6025F40", Offset = "0x6025140", VA = "0x186025F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GLOOMFGKAFI ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6026270", Offset = "0x6025470", VA = "0x186026270")]
		get
		{
			return default(GLOOMFGKAFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6026800", Offset = "0x6025A00", VA = "0x186026800")]
	public ICKPJOOKFMN(IList<Mesh> ODAGABLOLIH, IList<Matrix4x4> IKMFABDNGEE, byte NIGIGCLJKIJ, IList<byte[]> ICIIFIMLFMI, IList<int> JDHBMNJJAIK, IList<bool> DPHMLGLOGJF, IList<int> IEIBIMNGJBL, IList<int> HGKADGBMLLB, Allocator ECEHKFLCCDN, HOKNGCNKPJB FGNKKCECODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6026190", Offset = "0x6025390", VA = "0x186026190")]
	public DJMFNGILBFG FFMACHOKHBG(Allocator ECEHKFLCCDN)
	{
		return default(DJMFNGILBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6025F60", Offset = "0x6025160", VA = "0x186025F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[CMGJJOIKLEE]
public class KHOJIJLEHBL : FNOCMIMFMDO
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6028070", Offset = "0x6027270", VA = "0x186028070")]
	public ICKPJOOKFMN KFLCPDGPPLF()
	{
		return default(ICKPJOOKFMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6028140", Offset = "0x6027340", VA = "0x186028140")]
	public KHOJIJLEHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct GLOOMFGKAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeSlice<Vector3> CEBPDKICPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeSlice<Vector3> PAPPGFPLFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeSlice<Vector4> PHKNKHJEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<Vector2> DPGIAHOAMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector2> MHKLFBLPPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Vector2> HPHBIAPMAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<Vector2> HJIEINKMHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<Color> IHHHBMAIMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<int> KLBLCFLHCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<int> FPAGOCKPEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<BoneWeight> DNHELGNCJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<byte> OPNIBKDDBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int DNMIMGMAALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public Matrix4x4 HOCJNMEAJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int LEDBFEHDBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<byte> OBLJIMMOJPI;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal readonly struct OLFKJJEKOAH : IEquatable<OLFKJJEKOAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	internal readonly Material CDNFDPFEBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	internal readonly BCBDLBMFPOA KINJCPIOMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	internal readonly NHPPNPOJPFO IMIGOEHPEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	internal readonly MGDKKCABMBA GABPFONGLIE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8C4300", Offset = "0x8C3500", VA = "0x1808C4300")]
	public OLFKJJEKOAH(Material FCJNMBKENDK, BCBDLBMFPOA KKEJKOFBBMP, NHPPNPOJPFO PHPELMJDJJM, MGDKKCABMBA EPNACNAFCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x602C100", Offset = "0x602B300", VA = "0x18602C100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8C3EE0", Offset = "0x8C30E0", VA = "0x1808C3EE0", Slot = "4")]
	public bool Equals(OLFKJJEKOAH NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x602BF80", Offset = "0x602B180", VA = "0x18602BF80", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x602C060", Offset = "0x602B260", VA = "0x18602C060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class ICKLHABCMGD : MAFBMPELBJK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private ALPHGGOLLNN CHOCKOFDNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private MOIHAHJEOMG EFMNIGHODGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private IRecRoomQualityConfigProvider BFKIEKAENFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool OIBKPFHKADN;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6025980", Offset = "0x6024B80", VA = "0x186025980")]
	[JKGCDNJCKNE(LIEILBDPEFI.GameOnly)]
	private static void INDOBKPKHOD(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x53891C0", Offset = "0x53883C0", VA = "0x1853891C0")]
	[Preserve]
	public ICKLHABCMGD([BALLJMBCNAE(null)] MOIHAHJEOMG NHDOKJCHFJL, [BALLJMBCNAE(null)] ALPHGGOLLNN LMIELONCMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6025910", Offset = "0x6024B10", VA = "0x186025910")]
	private void GDBHBOEEIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x60258B0", Offset = "0x6024AB0", VA = "0x1860258B0", Slot = "4")]
	public void ECFGNIAKKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6025A80", Offset = "0x6024C80", VA = "0x186025A80", Slot = "5")]
	public EGFEEHILLCB<Texture2D> LEHLGKBEFNN(IGKEFAKFOEN IAFPDNKEIFA, [Optional] HJLLMGIJGIL BFBOJFAJKBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6025770", Offset = "0x6024970", VA = "0x186025770")]
	private uint EBGOABCBLIA(IGKEFAKFOEN IAFPDNKEIFA, HJLLMGIJGIL BFBOJFAJKBG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface IGDOBBEMGCF
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGAFJBPNBHA(Mesh JLFPINMNNGM, Matrix4x4 GBNMODHKNKM, byte[] OBLJIMMOJPI, bool NLMCPFBOPNA = false, BJHAEGIGCKI.FCJHAGDMNEH MJKPPOAHNBD = (BJHAEGIGCKI.FCJHAGDMNEH)0);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLDGDDOCGGF(Allocator ECEHKFLCCDN, HOKNGCNKPJB FGNKKCECODI, byte NIGIGCLJKIJ, [Optional] IList<int> IEIBIMNGJBL, [Optional] IList<int> EBOMMCPCKEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct FMONKKGDIDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly GameObject JLAPGINNIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly AvatarItemMaterial IGDGLMCHBJK;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x90CFA0", Offset = "0x90C1A0", VA = "0x18090CFA0")]
	public FMONKKGDIDJ(GameObject JLAPGINNIAF, AvatarItemMaterial IGDGLMCHBJK)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x602C320", Offset = "0x602B520", VA = "0x18602C320")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct MGLJMONNJAF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public AsyncTaskMethodBuilder<NMHNIKHIAOM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private TaskAwaiter<NMHNIKHIAOM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x602AD80", Offset = "0x6029F80", VA = "0x18602AD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x602B0C0", Offset = "0x602A2C0", VA = "0x18602B0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private Dictionary<FIGLDHCCOLD, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private Dictionary<FIGLDHCCOLD, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private Dictionary<FIGLDHCCOLD, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private Dictionary<FIGLDHCCOLD, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private readonly Dictionary<FIGLDHCCOLD, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private NMHNIKHIAOM _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x6025740", Offset = "0x6024940", VA = "0x186025740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6025140", Offset = "0x6024340", VA = "0x186025140")]
		public NMHNIKHIAOM LJPJDBOFFBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6025010", Offset = "0x6024210", VA = "0x186025010")]
		[AsyncStateMachine(typeof(MGLJMONNJAF))]
		public Task<NMHNIKHIAOM> GICNOHNPNKN(int DHGKJIMMIGG, int ILEFMHCENKM, int OCMALEPLEPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x60253E0", Offset = "0x60245E0", VA = "0x1860253E0")]
		public NoseFaceOption PJCNCHPOPCA(int OLOEDDHNMLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6024E90", Offset = "0x6024090", VA = "0x186024E90")]
		public SelectableFaceOption FOEDHDCALNI(FaceFeatureType PKCDFNEMNCN, FIGLDHCCOLD PLKIDLKFCNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6025190", Offset = "0x6024390", VA = "0x186025190")]
		public int MGGAMEAFMGA(FIGLDHCCOLD PLKIDLKFCNL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6025480", Offset = "0x6024680", VA = "0x186025480")]
		private void POEKMHCDAAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x274FB20", Offset = "0x274ED20", VA = "0x18274FB20")]
		private void ECHMNNNKDIG<T>(IDictionary<FIGLDHCCOLD, T> KIDIHHHGLCE, IReadOnlyList<T> PDPGGGBILHB) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6025210", Offset = "0x6024410", VA = "0x186025210")]
		public FIGLDHCCOLD NLBGDPPPJOJ(FaceFeatureType PKCDFNEMNCN)
		{
			return default(FIGLDHCCOLD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x60252C0", Offset = "0x60244C0", VA = "0x1860252C0")]
		public FIGLDHCCOLD ODKCFKDOGDL(FaceFeatureType PKCDFNEMNCN)
		{
			return default(FIGLDHCCOLD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x60256B0", Offset = "0x60248B0", VA = "0x1860256B0")]
		public FaceStyleSet()
		{
		}
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
