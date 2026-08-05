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
[BLFHHLMIMBP]
public class CKFECJKAHGI : OEJLECFHNPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	protected readonly List<Mesh> LMKBKHDPKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly List<byte[]> MNPABHPDPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly List<Matrix4x4> OICPDAEBPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly List<int> FKGBGCPCEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly List<bool> EGJHKIKPDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected Allocator HOJKGHJPENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected GIAKACMCMLB OEELCCENPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected byte AOOGAEOLAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected IList<int> ECDMBFBMMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected IList<int> FKNKBECGFJP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6057270", Offset = "0x6056270", VA = "0x186057270", Slot = "4")]
	public void DGHBOGHGMNM(Mesh KNFCOBLCFKE, Matrix4x4 CPLFOPMNOBC, byte[] NHMOGBDHCHJ, bool JPEMBOFMBEB = false, LDAEMHAJKEP.BEGKLKBPJCD AKGJHDHKMML = (LDAEMHAJKEP.BEGKLKBPJCD)0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60575C0", Offset = "0x60565C0", VA = "0x1860575C0", Slot = "5")]
	public void PBAGLGDJGFJ(Allocator NHBLMPKODCH, GIAKACMCMLB PAAAFLBAHIE, byte MMDHGACNOLD, [Optional] IList<int> NPKLBKBDHKA, [Optional] IList<int> PPPIOJNOOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6057140", Offset = "0x6056140", VA = "0x186057140")]
	private static void BCKINBDFABP(Mesh KNFCOBLCFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6057600", Offset = "0x6056600", VA = "0x186057600")]
	public CKFECJKAHGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[BLFHHLMIMBP]
public struct MAPJOFMOBJA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[ReadOnly]
	public EJJMBEGJGAP HMGPIJKOPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public int BDKAJNGMCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public JNGNHNOMPLE CPFGLKKELPF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x605E4D0", Offset = "0x605D4D0", VA = "0x18605E4D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[BLFHHLMIMBP]
[NativeContainer]
public struct JNGNHNOMPLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct JFPGKPGLDMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Vector3 JAGIPALDFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Vector3 JEPJKJIDLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Vector4 EOJHOKHGBAN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct POJKMEHJBML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public half PIBBNFBKCEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public half CNIGCNMKPAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public half MEGNLOIGOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public half OHDFKBMHOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public byte LHBMOAJKKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public byte OEKGNFPPCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte KHHPBDGILKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public byte JBGLODAOEKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct FJJMILFCGLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public half4 DDCPEHLFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public half2 EDEIBIMCODJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct MKNBELPLIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public half4 DDCPEHLFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public half2 EDEIBIMCODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public half2 GPAJPKMKLAH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct MONEPGDEGCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public half4 DDCPEHLFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public half2 EDEIBIMCODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public half2 GPAJPKMKLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public half2 ODPHHOIKINE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct IKBDJPCOHDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public half4 DDCPEHLFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half2 EDEIBIMCODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half2 GPAJPKMKLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half2 ODPHHOIKINE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half2 FDDILEMFDFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct KLOODFEMFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float PIBBNFBKCEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public float CNIGCNMKPAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public float MEGNLOIGOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float OHDFKBMHOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int LHBMOAJKKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int OEKGNFPPCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int KHHPBDGILKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int JBGLODAOEKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct KPAJPIAANHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Color DDCPEHLFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Vector2 EDEIBIMCODJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct DCGNJEAGLEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Color DDCPEHLFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector2 EDEIBIMCODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector2 GPAJPKMKLAH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct EJHFAMKDOMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Color DDCPEHLFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Vector2 EDEIBIMCODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Vector2 GPAJPKMKLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Vector2 ODPHHOIKINE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CPHMOODKIAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Color DDCPEHLFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Vector2 EDEIBIMCODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Vector2 GPAJPKMKLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Vector2 ODPHHOIKINE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Vector2 FDDILEMFDFJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool OCJGGKIFCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<JFPGKPGLDMB> JFJHHFFJIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<FJJMILFCGLN> IAKFNAGOKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<MKNBELPLIFJ> PAAGOJNJIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<MONEPGDEGCE> KDAIPCEOBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<IKBDJPCOHDD> DLMIOFOEJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<POJKMEHJBML> NBCNGEMPGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<KPAJPIAANHJ> CMKIKHAIIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<DCGNJEAGLEG> MGKNLKCJBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<EJHFAMKDOMO> IDOANFKOEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<CPHMOODKIAO> AEHLOABOMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<KLOODFEMFKF> LCEOPCBBLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<int> LFAFJPBDLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<int> GIHENJLIEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private NativeArray<int> CNOFIMLFPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NativeArray<int> CCANJFAJGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> GPIADHJKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> COMCJHHCOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<int> FMHHPPDNCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<BoneWeight> LPNOMAONENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> JJOLHONNFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool PMFPBMMAHDG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NKPCJDHMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x605D630", Offset = "0x605C630", VA = "0x18605D630")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x605C320", Offset = "0x605B320", VA = "0x18605C320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KIFPNGCIDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x605D620", Offset = "0x605C620", VA = "0x18605D620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x605C730", Offset = "0x605B730", VA = "0x18605C730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KHHIBKKCDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x605C810", Offset = "0x605B810", VA = "0x18605C810")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x605B9F0", Offset = "0x605A9F0", VA = "0x18605B9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NDDJIOEHLFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x605D640", Offset = "0x605C640", VA = "0x18605D640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x605DAB0", Offset = "0x605CAB0", VA = "0x18605DAB0")]
	public JNGNHNOMPLE(int NGKNIJKDHEO, int OAABMLFCLHB, int NDBCPNBKGPO, int LIDBCCNNJCK, Allocator NHBLMPKODCH, int JNDJMNMKIIP, PFKGIMEMGPG FFOHIGNANOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x605BA00", Offset = "0x605AA00", VA = "0x18605BA00")]
	public void AGCHLFDNKDH(int GCDIELAOHNA, Vector3 IFEDOEKJDOP, Vector3 IAFMBOFHOEJ, Vector4 MPLEEKHPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x605BDB0", Offset = "0x605ADB0", VA = "0x18605BDB0")]
	public void BNPPOFPGHHO(int GCDIELAOHNA, BoneWeight IPOFHNDFKCF, NativeSlice<byte> NHMOGBDHCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x605BA90", Offset = "0x605AA90", VA = "0x18605BA90")]
	public Color BFPFEDKMIIO(int GCDIELAOHNA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x605C330", Offset = "0x605B330", VA = "0x18605C330")]
	public void GCOLALCGMCG(int GCDIELAOHNA, Color BKPEEMPJCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x605D6B0", Offset = "0x605C6B0", VA = "0x18605D6B0")]
	public void NBDJPJBCBDO(byte PAHJIKELMJJ, int GCDIELAOHNA, Vector2 GMPHJCEODDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x605B9E0", Offset = "0x605A9E0", VA = "0x18605B9E0")]
	public void ABEDDIBGLFP(int GCDIELAOHNA, int DBOGDPANCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x605DA50", Offset = "0x605CA50", VA = "0x18605DA50")]
	public bool PNOPCLGNOFE(int PAHJIKELMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x605C740", Offset = "0x605B740", VA = "0x18605C740")]
	public void HAEOGHEEJNN(int OAEDGOJDPGB, int CNHEAECNOFO, int NAHHNFGPNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x605C0E0", Offset = "0x605B0E0", VA = "0x18605C0E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x605C820", Offset = "0x605B820", VA = "0x18605C820")]
	public Mesh KLDPDIGDKAP([Optional] string KGEPDAHENOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
[BLFHHLMIMBP]
[NativeContainer]
public struct EJJMBEGJGAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Mesh.MeshDataArray DLKJEADFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> KBHBHPNINCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<int> HMFCGFBFJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<BoneWeight> LPNOMAONENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<Matrix4x4> NHOOACPOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> MIEAPLJANDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<byte> PAAAKEOLCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<int> OFLCPCKNKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<int> FBJCOJBAEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<sbyte> PAFPKOJABNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<byte> OLFLILLJLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<int> KPAPEMHIJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool PMFPBMMAHDG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NJKCNOEIDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6059F80", Offset = "0x6058F80", VA = "0x186059F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DFGIOKDIPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6059A20", Offset = "0x6058A20", VA = "0x186059A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int IGHIKJCLPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6059C60", Offset = "0x6058C60", VA = "0x186059C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EGMDNOMMFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6059F70", Offset = "0x6058F70", VA = "0x186059F70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6059D30", Offset = "0x6058D30", VA = "0x186059D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NKPCJDHMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6059F60", Offset = "0x6058F60", VA = "0x186059F60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6059C40", Offset = "0x6058C40", VA = "0x186059C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LJLAKKLJBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6059D40", Offset = "0x6058D40", VA = "0x186059D40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6059B80", Offset = "0x6058B80", VA = "0x186059B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GIAKACMCMLB FKPDLELNEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6059F90", Offset = "0x6058F90", VA = "0x186059F90")]
		get
		{
			return default(GIAKACMCMLB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6059C50", Offset = "0x6058C50", VA = "0x186059C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte IIFPFIDNHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6059A10", Offset = "0x6058A10", VA = "0x186059A10")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6059A30", Offset = "0x6058A30", VA = "0x186059A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LKAIBHLBODK EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6059D50", Offset = "0x6058D50", VA = "0x186059D50")]
		get
		{
			return default(LKAIBHLBODK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6059FA0", Offset = "0x6058FA0", VA = "0x186059FA0")]
	public EJJMBEGJGAP(IList<Mesh> HPJFAICFJLL, IList<Matrix4x4> LMOJLMIMBMD, byte MMDHGACNOLD, IList<byte[]> ELGOKFLNNIH, IList<int> OBDGCHJHEIL, IList<bool> JLFNIDAGANH, IList<int> NPKLBKBDHKA, IList<int> PGLOBDBLBFP, Allocator NHBLMPKODCH, GIAKACMCMLB PAAAFLBAHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6059B90", Offset = "0x6058B90", VA = "0x186059B90")]
	public JNGNHNOMPLE ELOFFOAILDB(Allocator NHBLMPKODCH, PFKGIMEMGPG FFOHIGNANOJ)
	{
		return default(JNGNHNOMPLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6059A40", Offset = "0x6058A40", VA = "0x186059A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BLFHHLMIMBP]
public class DLDFAGCPFNE : CKFECJKAHGI
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6057810", Offset = "0x6056810", VA = "0x186057810")]
	public EJJMBEGJGAP NEBGAONENGC()
	{
		return default(EJJMBEGJGAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6057600", Offset = "0x6056600", VA = "0x186057600")]
	public DLDFAGCPFNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LKAIBHLBODK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Mesh.MeshData BDKCAKCALCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public NativeSlice<BoneWeight> LPNOMAONENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeSlice<byte> LIKMEFPCPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int BLEGOJLGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Matrix4x4 OBGIJBCHKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int FBHLMBGGKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeSlice<byte> NHMOGBDHCHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CAGBLKLHPCD : IDFLJADJJAG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private abstract class OMGJJLIBAOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly HBNDMEPLGIE OOICMJIEFIL;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public virtual bool IPMNFADCELB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public virtual bool LEEHECLDHND
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual LDAEMHAJKEP.BEGKLKBPJCD FBHLMBGGKAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "6")]
			get
			{
				return default(LDAEMHAJKEP.BEGKLKBPJCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool AGICCNMKHAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x12F2EA0", Offset = "0x12F1EA0", VA = "0x1812F2EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool BIDDGHPDIPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6060C40", Offset = "0x605FC40", VA = "0x186060C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool PGFKAHGOKAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6060C50", Offset = "0x605FC50", VA = "0x186060C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		protected OMGJJLIBAOM(HBNDMEPLGIE COAEABCLMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract NCJNDIGDIHF KMKCOLDNGMH(int[] NMDGGMKECJM, List<IDHALJOCJBC> DHEMKGNLCBP, List<IDHALJOCJBC> GOCKFPDDKNA);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract MBNECEJAKKL GJBILCCOCMK(uint KGJOIPMBPNF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private class JCMDNAAPDNL : OMGJJLIBAOM
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class EHGGJHCACKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public DEHADEPDEGA<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public JCMDNAAPDNL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public EHGGJHCACKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6059620", Offset = "0x6058620", VA = "0x186059620")]
			internal void GCGHBKALEHP(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly AvatarSkinAssetItem.EBDIPKCNILG BIDMDHDCNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly AssetReference OIHPGFHBDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly LDAEMHAJKEP.BEGKLKBPJCD BOBMHAGKBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly NOGNCKDKHOJ? LFPILBMJNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly Material[] FAAGCEKKJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private SkinnedMeshRenderer[] DBHPLNKHNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private AvatarSkinAssetItem PKJBJPCHMAG;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override LDAEMHAJKEP.BEGKLKBPJCD FBHLMBGGKAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7BD950", Offset = "0x7BC950", VA = "0x1807BD950", Slot = "6")]
			get
			{
				return default(LDAEMHAJKEP.BEGKLKBPJCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x605B8D0", Offset = "0x605A8D0", VA = "0x18605B8D0")]
		public JCMDNAAPDNL(AvatarSkinAssetItem.EBDIPKCNILG FPMMMDMGNOJ, AssetReference CBKNFKHLDBE, Material POMGPMPIPGN, HBNDMEPLGIE MDMDOLNBEOH, LDAEMHAJKEP.BEGKLKBPJCD IGALHOAPAOO = (LDAEMHAJKEP.BEGKLKBPJCD)0, [Optional] NOGNCKDKHOJ? HDKFPONIGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x605B7C0", Offset = "0x605A7C0", VA = "0x18605B7C0")]
		public JCMDNAAPDNL(AvatarSkinAssetItem.EBDIPKCNILG FPMMMDMGNOJ, AssetReference CBKNFKHLDBE, Material POMGPMPIPGN, LDAEMHAJKEP.BEGKLKBPJCD IGALHOAPAOO = (LDAEMHAJKEP.BEGKLKBPJCD)0, [Optional] NOGNCKDKHOJ? HDKFPONIGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x605B580", Offset = "0x605A580", VA = "0x18605B580", Slot = "7")]
		public override NCJNDIGDIHF KMKCOLDNGMH(int[] NMDGGMKECJM, List<IDHALJOCJBC> DHEMKGNLCBP, List<IDHALJOCJBC> GOCKFPDDKNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x605B2B0", Offset = "0x605A2B0", VA = "0x18605B2B0", Slot = "8")]
		public override MBNECEJAKKL GJBILCCOCMK(uint KGJOIPMBPNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x605B750", Offset = "0x605A750", VA = "0x18605B750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class BGAHNIAPCIG : OMGJJLIBAOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly OBIOOBFHLLE AMLLPHILHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private DEHADEPDEGA<CANBPMKPEIA> LICDABNGFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CANBPMKPEIA KECKMHIAHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private DEHADEPDEGA<Material>[] LJAIMPPNNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public List<Material> BEHGDBCBFEN;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool IPMNFADCELB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool LEEHECLDHND
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6049CE0", Offset = "0x6048CE0", VA = "0x186049CE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1B0E2C0", Offset = "0x1B0D2C0", VA = "0x181B0E2C0")]
		public BGAHNIAPCIG(HBNDMEPLGIE COAEABCLMAE, OBIOOBFHLLE GBFEOEBEFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6049FA0", Offset = "0x6048FA0", VA = "0x186049FA0", Slot = "7")]
		public override NCJNDIGDIHF KMKCOLDNGMH(int[] NMDGGMKECJM, List<IDHALJOCJBC> DHEMKGNLCBP, List<IDHALJOCJBC> GOCKFPDDKNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6049E70", Offset = "0x6048E70", VA = "0x186049E70", Slot = "8")]
		public override MBNECEJAKKL GJBILCCOCMK(uint KGJOIPMBPNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6049AF0", Offset = "0x6048AF0", VA = "0x186049AF0")]
		public MBNECEJAKKL BPNPLKFHHOE(GameObject EHPIIEKIOHO, uint KGJOIPMBPNF, bool ALKJHCJAECP, bool HKEIMEKMAHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x60495D0", Offset = "0x60485D0", VA = "0x1860495D0")]
		public static bool BLAGAGOLIBK(Renderer[] MGCGLOHHNEC, string APLLNDDBIDE, [Out] Renderer KOJODBMMJNA, [Out] Renderer CFMGBDGFPAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x604A6A0", Offset = "0x60496A0", VA = "0x18604A6A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6049940", Offset = "0x6048940", VA = "0x186049940")]
		private KIBNPCDEEMA BMOLJEOKDKP(bool AGMFDJGBODM = false)
		{
			return default(KIBNPCDEEMA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x604A5A0", Offset = "0x60495A0", VA = "0x18604A5A0")]
		private DEHADEPDEGA<Material>[] PHGBPMKNMBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D11400", Offset = "0x3D10400", VA = "0x183D11400")]
		[CompilerGenerated]
		private void GFOOCBPAELI(CANBPMKPEIA HEOGODCLBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6049D40", Offset = "0x6048D40", VA = "0x186049D40")]
		[CompilerGenerated]
		private void FNKBMAAOAML(DEHADEPDEGA<Material> MBKFOJPJCCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x604A540", Offset = "0x6049540", VA = "0x18604A540")]
		[CompilerGenerated]
		private void NHNGLJJJKFA(Material HEOGODCLBDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class MNCOBLFDAIC : ICPMMDPLJFP<Task<(GameObject, AvatarItemMaterial)>, CANBPMKPEIA>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct MJLHGFPDIIM : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x605FEA0", Offset = "0x605EEA0", VA = "0x18605FEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x60603A0", Offset = "0x605F3A0", VA = "0x1860603A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly DEHADEPDEGA<GameObject> OOCKANMNOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly DEHADEPDEGA<AvatarItemMaterial> IOHIJIBMINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private GameObject CHMPHPLBDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private AvatarItemMaterial AOEFKHIGBOG;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6060AA0", Offset = "0x605FAA0", VA = "0x186060AA0")]
		private MNCOBLFDAIC(Task<(GameObject, AvatarItemMaterial)> JCGMNOGFGHB, DEHADEPDEGA<GameObject> AJNFBANJMKI, DEHADEPDEGA<AvatarItemMaterial> KDKJBJIOLNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6060410", Offset = "0x605F410", VA = "0x186060410")]
		public static MNCOBLFDAIC AHMJAPINNPH(OBIOOBFHLLE IBBDBHMGAPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6060970", Offset = "0x605F970", VA = "0x186060970")]
		[AsyncStateMachine(typeof(MJLHGFPDIIM))]
		private static Task<(GameObject, AvatarItemMaterial)> MILFEKHKHOC(Task<GameObject> CIGPFHDDFGD, Task<AvatarItemMaterial> LFOHFBKJMKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x60608B0", Offset = "0x605F8B0", VA = "0x1860608B0", Slot = "11")]
		protected override CANBPMKPEIA HNHGCKLPGOL(Task<(GameObject, AvatarItemMaterial)> NPJKPLIOPNN)
		{
			return default(CANBPMKPEIA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6060850", Offset = "0x605F850", VA = "0x186060850", Slot = "12")]
		protected override void BCPMFLCKAME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct KIBNPCDEEMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private DEHADEPDEGA<CANBPMKPEIA> GJBOOGAKECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private DEHADEPDEGA<Material>[] GOCKFPDDKNA;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x909BF0", Offset = "0x908BF0", VA = "0x180909BF0")]
		public void JFLGBDCKGKN([Out] DEHADEPDEGA<CANBPMKPEIA> CBPMLJGALEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x605E430", Offset = "0x605D430", VA = "0x18605E430")]
		public void ALGFALHFAII([Out] DEHADEPDEGA<Material>[] KOEECNAPAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x909C10", Offset = "0x908C10", VA = "0x180909C10")]
		public KIBNPCDEEMA(DEHADEPDEGA<CANBPMKPEIA> ANIOLAACJDO, DEHADEPDEGA<Material>[] BKIIKPMMAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GDMCOJGKPJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public CAGBLKLHPCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public CKENCMBGPDL buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GDMCOJGKPJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x605B290", Offset = "0x605A290", VA = "0x18605B290")]
		internal void KPEDKMNKFMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x605B270", Offset = "0x605A270", VA = "0x18605B270")]
		internal void KOBHJKODCDC(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x605B150", Offset = "0x605A150", VA = "0x18605B150")]
		internal void BMKEHGOPLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x605B1E0", Offset = "0x605A1E0", VA = "0x18605B1E0")]
		internal void GCMGNKODJFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		internal NCJNDIGDIHF CKMILJGGHOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OHMHBFAKMNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public GDMCOJGKPJD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public OHMHBFAKMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6060B80", Offset = "0x605FB80", VA = "0x186060B80")]
		internal KIAENJEKJIN BMLANLIHNMC(int lod)
		{
			return default(KIAENJEKJIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class EGJEEBBEJGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<CKENCMBGPDL> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public EGJEEBBEJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x60594F0", Offset = "0x60584F0", VA = "0x1860594F0")]
		internal void CKOFNGLGPKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AIDIEOKCGGO : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public CAGBLKLHPCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<OMGJJLIBAOM> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public List<CKENCMBGPDL> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Func<int, KIAENJEKJIN> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public OJBHIDCBIEJ materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public AIDIEOKCGGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60492F0", Offset = "0x60482F0", VA = "0x1860492F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6049500", Offset = "0x6048500", VA = "0x186049500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CLPENOGCBJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CAGBLKLHPCD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CLPENOGCBJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60577C0", Offset = "0x60567C0", VA = "0x1860577C0")]
		internal NCJNDIGDIHF LOADHKFKKGD(OMGJJLIBAOM p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IHKHBHBHABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public LDNIGKFDNHI cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public IHKHBHBHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x828820", Offset = "0x827820", VA = "0x180828820")]
		internal void KOBJNMOPKCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4870", Offset = "0x8C3870", VA = "0x1808C4870")]
		internal void FIIKPJLBMAB(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PIJCEEJLHPC
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
		public CAGBLKLHPCD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PIJCEEJLHPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OOOKJGPDPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public JNGNHNOMPLE defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public EJJMBEGJGAP defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public PIJCEEJLHPC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public OOOKJGPDPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6060C70", Offset = "0x605FC70", VA = "0x186060C70")]
		internal void DFDNEOGDEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6060EF0", Offset = "0x605FEF0", VA = "0x186060EF0")]
		internal void DOCKCHIMFJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class CILDAKAIBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public PNDIDAPHJAD legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public OPHFKKEIGMO legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public PIJCEEJLHPC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CILDAKAIBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6056E50", Offset = "0x6055E50", VA = "0x186056E50")]
		internal void GOOLENJMKDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x60570D0", Offset = "0x60560D0", VA = "0x1860570D0")]
		internal void ODPJOKNGPOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BJDIEHGGBHN : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private LLCDBDMNGNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public BJDIEHGGBHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C3C70", Offset = "0x8C2C70", VA = "0x1808C3C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x604A6F0", Offset = "0x60496F0", VA = "0x18604A6F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class PFLJLPAHLHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public LDNIGKFDNHI cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public OBIOOBFHLLE avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public CAGBLKLHPCD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PFLJLPAHLHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6060FA0", Offset = "0x605FFA0", VA = "0x186060FA0")]
		internal NCJNDIGDIHF PAHMKJELLGK(PHHOGKCECLL item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6060F60", Offset = "0x605FF60", VA = "0x186060F60")]
		internal void BDBADOLJEGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NKGJIHDEKGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public DEHADEPDEGA<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NKGJIHDEKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6060B30", Offset = "0x605FB30", VA = "0x186060B30")]
		internal void OIPAPKPOOJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AIEJIAHANLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public HBNDMEPLGIE overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public AIEJIAHANLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6049550", Offset = "0x6048550", VA = "0x186049550")]
		internal bool IPFLPLEKMPE(KeyValuePair<string, OBIOOBFHLLE> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private AvatarConfiguration LFBPMPAKPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private Transform GAMJGLLGCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private AssetReference OIHPGFHBDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private GameObject IMJNPAFAFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private GameObject NCCEBAEMNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private SkinnedMeshRenderer BKDDHBDGOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private Transform[] NJHLHLPEAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Matrix4x4[] JDJFGNBIIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Material AHDJFFBOGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Material GLKEKNIKKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private Material LEGBIAPLCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Shader FPKPMMABGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private Shader IDCBOHKGJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Animator DCMICLOONAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Renderer[] LFGPMMJJFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private LDAEMHAJKEP.BEGKLKBPJCD CKMLGCIMFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private Color PFENLAPBKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private Color AGBGKNGFJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Color MOFHFCMKFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Color? CIJBGPBKMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Color? HGBKOPAPAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Color? DPCEAFKHLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Color? EGDJNBICKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private Texture2D DHPNNMDGLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Texture2D BAIMAFMEIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[CanBeNull]
	private OBIOOBFHLLE OCMDDBFEDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Texture FIPEMBGNOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private Color MDKMPLOBFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Dictionary<Renderer, OJBHIDCBIEJ> CFAKNDFLLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Dictionary<Renderer, OJBHIDCBIEJ> KHNOCBJAGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Dictionary<string, List<CMJAOHLMCNP>> DFDILOMHDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Dictionary<string, List<CMJAOHLMCNP>> EAMNJFEGGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<IDHALJOCJBC> DEMKGAFFBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<IDHALJOCJBC> HAIAFAJFNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<IDHALJOCJBC> MFBINJEMOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly List<IDHALJOCJBC> JMHLDFKIEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<CMJAOHLMCNP, Material> MPLNMAAIPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<CMJAOHLMCNP, Material> NHFLBNNACJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private SkinnedMeshRenderer[] FFOCJNOJEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private SkinnedMeshRenderer[] GBJNNHICEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private SkinnedMeshRenderer[] LLIIAJGFOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private SkinnedMeshRenderer[] FEFIPGMAINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<string, DEHADEPDEGA<Texture2D>> HCHKAHDHNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<string, DEHADEPDEGA<Texture2D>> AAGPOCLAOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private FitMeshHemisphere AJDLELELFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool EHHMFKKPOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private BJFNAGPGHOA PGKNODFAAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool LDGKCMEKBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AnchorParamsRestrictions DLFHILIDIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool EAHLGDIOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Transform KOAPMOIMEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform JLDPGOIKMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool LDEEIHIJCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x201")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool BKNIPEFBNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Vector3 KOEPIEEGJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Quaternion PLPPHBBFGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector2 NJBHNOLFEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private FitMeshHemisphere JBOPBDNAFMI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material NNBKBGELNKE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material IMHOKGIPHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<string, OBIOOBFHLLE> IJHDOIDACOL;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly int LHJBCBCLPEB;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly int EDAJOMMDHMA;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly int PDNCEJJJKKK;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly int APBEFEDHAJD;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly int NJCGJGECAIK;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly int HKDNFMKBICO;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly int FOHCJEBPEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly LHMMLLGDOFK PPJFCECANAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly LHMMLLGDOFK LCLIJANBJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool CNPOODOAOHK;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static Lazy<MAFPGJFOFOP> LDDPMHJBFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Lazy<HCOABGFHJGP> BIGECBIFPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Lazy<PAIABHMLGAM> LFNMPHLNCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private List<Action> FGMIPGHMEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private NEKMEADJBGB CEDKDGCLAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private SkinnedMeshRenderer[] FOLLAILOJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int MJGGPOFJBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool PKNHAJGNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int DCNAJBLJGFH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JFHBKEPEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6054510", Offset = "0x6053510", VA = "0x186054510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x604A990", Offset = "0x6049990", VA = "0x18604A990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool COOFDNDJEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xF25E10", Offset = "0xF24E10", VA = "0x180F25E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Material KHKEICHJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6050190", Offset = "0x604F190", VA = "0x186050190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Material IGKGMAPNIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x604F800", Offset = "0x604E800", VA = "0x18604F800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool FACOICONABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static MAFPGJFOFOP ACDIGKEICHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60545B0", Offset = "0x60535B0", VA = "0x1860545B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private HCOABGFHJGP KKFNKLHLFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60531B0", Offset = "0x60521B0", VA = "0x1860531B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private PAIABHMLGAM HNINLJIIICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6050830", Offset = "0x604F830", VA = "0x186050830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LHMMLLGDOFK JCDKHHJOBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA20", Offset = "0x9ADA20", VA = "0x1809AEA20", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LHMMLLGDOFK FJEBPBHGGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x14C3450", Offset = "0x14C2450", VA = "0x1814C3450", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public SkinnedMeshRenderer[] NIOHOCPEECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x16E95C0", Offset = "0x16E85C0", VA = "0x1816E95C0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Renderer[] POHKGHCALPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C0010", Offset = "0x7BF010", VA = "0x1807C0010", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool BJOFLEOMMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6053040", Offset = "0x6052040", VA = "0x186053040", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LDAEMHAJKEP.BEGKLKBPJCD OCKAJDOPBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xEA52B0", Offset = "0xEA42B0", VA = "0x180EA52B0", Slot = "18")]
		get
		{
			return default(LDAEMHAJKEP.BEGKLKBPJCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int KOHMLMKLMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x852CF0", Offset = "0x851CF0", VA = "0x180852CF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6053D50", Offset = "0x6052D50", VA = "0x186053D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool LGFIKMNBGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6053710", Offset = "0x6052710", VA = "0x186053710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private static bool LNMHNKBPNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x604FCA0", Offset = "0x604ECA0", VA = "0x18604FCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6056530", Offset = "0x6055530", VA = "0x186056530")]
	public CAGBLKLHPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x604E770", Offset = "0x604D770", VA = "0x18604E770", Slot = "21")]
	public void DPGLELIALOP(COFGPMKBMIP AOEDGBAGLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6055240", Offset = "0x6054240", VA = "0x186055240", Slot = "22")]
	public void OBALCGANPOD(FPFCGIGJENB CFHKBJPLJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6053D50", Offset = "0x6052D50", VA = "0x186053D50", Slot = "4")]
	public void LCFCADJEBAB(int KGJOIPMBPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6050320", Offset = "0x604F320", VA = "0x186050320", Slot = "9")]
	public void GBDMCFBMGKB(JOOLEMJADHL MAOEONNNPJK, Texture2D INGLEABGJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6051EA0", Offset = "0x6050EA0", VA = "0x186051EA0", Slot = "10")]
	public void GFEMDNCLFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6054C70", Offset = "0x6053C70", VA = "0x186054C70", Slot = "11")]
	public bool NNIKOBFDFKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6055400", Offset = "0x6054400", VA = "0x186055400", Slot = "8")]
	public void OKGOEJLLFLK(BBNLEFGPNOI PNANPEFMMFH, Color? DDCPEHLFHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x604A740", Offset = "0x6049740", VA = "0x18604A740")]
	private void ACGJGPJFNDG(Action CBLAJHOAADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6052420", Offset = "0x6051420", VA = "0x186052420", Slot = "5")]
	public void GKHMJBLDMID(OBIOOBFHLLE KBKEIAENKDD, Texture MBNHABFENGK, Color KNNDDLLLLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x604A990", Offset = "0x6049990", VA = "0x18604A990", Slot = "6")]
	public void ODLDDLCNHJI(bool LANGKIOFKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1409390", Offset = "0x1408390", VA = "0x181409390", Slot = "7")]
	public void NHCDPNGFAAA(NEKMEADJBGB JJOLHONNFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6050880", Offset = "0x604F880", VA = "0x186050880", Slot = "14")]
	public CKENCMBGPDL GELDDNJJONC(BEPOICKGKJP JNEFFPPBKMD, bool BNDKOKBGFGC, int[] EDAHLMDBBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x604E0C0", Offset = "0x604D0C0", VA = "0x18604E0C0", Slot = "15")]
	public void DAKOGHLMLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60552C0", Offset = "0x60542C0", VA = "0x1860552C0")]
	private bool OGHOLCOBOLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xEA4BF0", Offset = "0xEA3BF0", VA = "0x180EA4BF0", Slot = "19")]
	public void JMBIJABKJOL(LDAEMHAJKEP.BEGKLKBPJCD CDEGGAMLKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6052360", Offset = "0x6051360", VA = "0x186052360")]
	private bool GJDKMNGBNPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x604EAD0", Offset = "0x604DAD0", VA = "0x18604EAD0")]
	private CKENCMBGPDL EDHBFEHOCLD(bool BNDKOKBGFGC, List<OMGJJLIBAOM> FDFANGGDLPI, int[] EDAHLMDBBNO, Func<int, KIAENJEKJIN> EDGNNGJBJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60549D0", Offset = "0x60539D0", VA = "0x1860549D0")]
	[IteratorStateMachine(typeof(AIDIEOKCGGO))]
	private IEnumerator<LLCDBDMNGNA> NHEANLOCKNO(bool BNDKOKBGFGC, List<OMGJJLIBAOM> FDFANGGDLPI, int[] EDAHLMDBBNO, Func<int, KIAENJEKJIN> EDGNNGJBJFH, OJBHIDCBIEJ ABFEBOGJOEC, Material KOANOANMPFH, List<CKENCMBGPDL> MNOCHMBCCNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x60559A0", Offset = "0x60549A0", VA = "0x1860559A0")]
	private CKENCMBGPDL PAOOHJCMDBA(List<OMGJJLIBAOM> FDFANGGDLPI, int[] EDAHLMDBBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x604C480", Offset = "0x604B480", VA = "0x18604C480")]
	private NEPNIBLDPPD CMBDFPIFBEB(List<OMGJJLIBAOM> FDFANGGDLPI, int KGJOIPMBPNF, bool BNDKOKBGFGC, KIAENJEKJIN ADMMNLEBHNB, bool IFOIAODFGML, OJBHIDCBIEJ ABFEBOGJOEC, Material KOANOANMPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6055830", Offset = "0x6054830", VA = "0x186055830")]
	private NEPNIBLDPPD OOBGNNHMMHN(JobHandle GOPEFPBBBMM, bool GPBGGNJGNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6052A20", Offset = "0x6051A20", VA = "0x186052A20")]
	private void HCMCKHEGHIA(SkinnedMeshRenderer EDEAONBBJCH, Mesh KNFCOBLCFKE, List<Material> HOELAJGGLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	private void CFJGGOJALBA(int KGJOIPMBPNF, long EONMLLAGBOD, long JPINDCIOFEO, long EHGPCFLDEAD, long CBFELAAFONP, long GMJDAAPONHO, long HKEFJAKKBKD, long LOMIOKAPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60544A0", Offset = "0x60534A0", VA = "0x1860544A0")]
	[IteratorStateMachine(typeof(BJDIEHGGBHN))]
	private IEnumerator<LLCDBDMNGNA> MLBOICFMNCM(JobHandle CBPMLJGALEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x604B5A0", Offset = "0x604A5A0", VA = "0x18604B5A0")]
	private static Material CGCMPKBNEMN(Dictionary<CMJAOHLMCNP, Material> CLCDBFMMCEF, Material IGKFPAFGLPB, IEINHBNEHMJ LGNNHFGDAKL, CJFDPJNLGLA IDEABGHAHGG, HBNDMEPLGIE MDMDOLNBEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6052CB0", Offset = "0x6051CB0", VA = "0x186052CB0")]
	private static IEINHBNEHMJ IGMKHJBEBPM(OMGJJLIBAOM IHGDBGMBGJJ, int AHGIEGAEPEC)
	{
		return default(IEINHBNEHMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6051F20", Offset = "0x6050F20", VA = "0x186051F20")]
	private void GHOAECKBJGB(int JNBHLFHNMEB, Material BKIIKPMMAIB, OMGJJLIBAOM IHGDBGMBGJJ, [Out] Texture2D EDJHAGAGLLG, [Out] Vector4 EPCKJJNPJBL, [Out] Texture2D PDNILJMEGCL, [Out] Texture2D HDIGKHLDOCM, [Out] Texture2D DANKNJHILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x604F1D0", Offset = "0x604E1D0", VA = "0x18604F1D0")]
	private void EKBNDELBFOJ(int JNBHLFHNMEB, Material BKIIKPMMAIB, OMGJJLIBAOM IHGDBGMBGJJ, [Out] Color FONBBIKPAJL, [Out] Color HPEJPCMHICO, [Out] Color DKHJJBPGHDH, [Out] Color PIAGPENFDKH, [Out] Color GHNFOLFKACG, [Out] Color KIIDADAOAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x604E2C0", Offset = "0x604D2C0", VA = "0x18604E2C0")]
	private bool DBLBCBCLMBM(Material BKIIKPMMAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x604B1E0", Offset = "0x604A1E0", VA = "0x18604B1E0")]
	private static Material BONFEHICEPP(int JNBHLFHNMEB, BGAHNIAPCIG IHGDBGMBGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x604FE40", Offset = "0x604EE40", VA = "0x18604FE40")]
	private static CJFDPJNLGLA FJMAPMLGJGA(OMGJJLIBAOM IHGDBGMBGJJ, int AHGIEGAEPEC)
	{
		return default(CJFDPJNLGLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6054F40", Offset = "0x6053F40", VA = "0x186054F40")]
	private static void OAKIHCOMPLK(Dictionary<string, List<CMJAOHLMCNP>> JJNGNJIDCFF, OMGJJLIBAOM HMPAMGCJCEL, Material IGKFPAFGLPB, IEINHBNEHMJ PNANPEFMMFH, CJFDPJNLGLA MAOEONNNPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6050600", Offset = "0x604F600", VA = "0x186050600")]
	private static SkinnedMeshRenderer GCBHKKPGGNC(Transform EPMPOCLOEKE, Transform CIDNJEAJKKE, SkinnedMeshRenderer[] MGCGLOHHNEC, int KGJOIPMBPNF, KIAENJEKJIN ADMMNLEBHNB, bool BNDKOKBGFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x604E550", Offset = "0x604D550", VA = "0x18604E550")]
	private void DPAEAHADMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6054BD0", Offset = "0x6053BD0", VA = "0x186054BD0")]
	private void NLFPKBKLKCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x604F070", Offset = "0x604E070", VA = "0x18604F070")]
	private static void EGMFKDPDJFP(Dictionary<CMJAOHLMCNP, Material> CLCDBFMMCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x604B050", Offset = "0x604A050", VA = "0x18604B050")]
	private static void BGOPCEILJFL(Dictionary<Renderer, OJBHIDCBIEJ> LIODFHGPCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60539E0", Offset = "0x60529E0", VA = "0x1860539E0")]
	private void KNHONJHNAHO(SkinnedMeshRenderer[] MGCGLOHHNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60525F0", Offset = "0x60515F0", VA = "0x1860525F0")]
	private void GPKMJBBHNML(SkinnedMeshRenderer FMBGMBIMNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6054630", Offset = "0x6053630", VA = "0x186054630")]
	private void NFEHKODEOFK(List<IDHALJOCJBC> DOJADDOICOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6053200", Offset = "0x6052200", VA = "0x186053200")]
	private void JDFEEFFFPEN(Dictionary<string, DEHADEPDEGA<Texture2D>> JJNGNJIDCFF, bool EIGEHGAJPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x604A7C0", Offset = "0x60497C0", VA = "0x18604A7C0")]
	private void ALHJBCGCMNC(Dictionary<string, List<CMJAOHLMCNP>> JJNGNJIDCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6052490", Offset = "0x6051490", VA = "0x186052490")]
	private void GKIIDAKHPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x604FF30", Offset = "0x604EF30", VA = "0x18604FF30")]
	private void FNOJGIMAKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6053E60", Offset = "0x6052E60", VA = "0x186053E60")]
	private void LIIJBBNNMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6050530", Offset = "0x604F530", VA = "0x186050530")]
	private void GBJMEAKHEAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6053790", Offset = "0x6052790", VA = "0x186053790")]
	private void KIGFHMOJDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6053820", Offset = "0x6052820", VA = "0x186053820")]
	private void KLOCHDGJEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60500C0", Offset = "0x604F0C0", VA = "0x1860500C0")]
	private void FODPDLOHKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x604EA30", Offset = "0x604DA30", VA = "0x18604EA30")]
	private void EBMHLIBCNEI(bool COBDDOFKMAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6053C80", Offset = "0x6052C80", VA = "0x186053C80")]
	private void LBNOIDMLDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x604F760", Offset = "0x604E760", VA = "0x18604F760")]
	private void FALCMNBMHEJ(bool COBDDOFKMAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x604B260", Offset = "0x604A260", VA = "0x18604B260")]
	private void CFFGFGBBGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x604A9A0", Offset = "0x60499A0", VA = "0x18604A9A0")]
	private void BGCPLGAKPGI(Material KOANOANMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6052B40", Offset = "0x6051B40", VA = "0x186052B40")]
	private void HIAAAPNGKGP(Material KOANOANMPFH, Color HPEJPCMHICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6053D70", Offset = "0x6052D70", VA = "0x186053D70")]
	private void LGLALJMKNBA(Material KOANOANMPFH, Color DKHJJBPGHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6054AE0", Offset = "0x6053AE0", VA = "0x186054AE0")]
	private void NKKKHNFDIJN(Material KOANOANMPFH, Color FONBBIKPAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6053B90", Offset = "0x6052B90", VA = "0x186053B90")]
	private void LBHNPICLIAB(Material KOANOANMPFH, Texture2D INGLEABGJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60543B0", Offset = "0x60533B0", VA = "0x1860543B0")]
	private void LPHIPBBOKCK(Material KOANOANMPFH, Texture JPGDJEAAEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6054810", Offset = "0x6053810", VA = "0x186054810")]
	private void NGIHCMJMMBE(Action<OJBHIDCBIEJ> MFJKHBFGDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x604A810", Offset = "0x6049810", VA = "0x18604A810")]
	private void ANCFEAEKAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6052690", Offset = "0x6051690", VA = "0x186052690")]
	private void GPNJDHIBBGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6055C60", Offset = "0x6054C60", VA = "0x186055C60")]
	private CKENCMBGPDL PGBEFNJCOFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x604F8F0", Offset = "0x604E8F0", VA = "0x18604F8F0")]
	private void FGHNPGODHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6053380", Offset = "0x6052380", VA = "0x186053380")]
	public void JEBOMHEMDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6053970", Offset = "0x6052970", VA = "0x186053970")]
	private void KNAEJOPIGBM(Vector3 CIKPOOKMMOE, Quaternion KGONPCAJEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x604AD10", Offset = "0x6049D10", VA = "0x18604AD10")]
	private void BGNIODLHPCG(List<OMGJJLIBAOM> PDMDODLINIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x604BE10", Offset = "0x604AE10", VA = "0x18604BE10")]
	public void CKFFEONLMFC(BJFNAGPGHOA BCNNFCGENOL, bool MOKKGHLIBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x604B790", Offset = "0x604A790", VA = "0x18604B790")]
	public void CKFFEONLMFC(BJFNAGPGHOA BCNNFCGENOL, AnchorParamsRestrictions MHELBBABANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8AF160", Offset = "0x8AE160", VA = "0x1808AF160")]
	private static void MBGNMNIBMIL(FitMeshHemisphere BMIICLLCEKM, Transform JHMOJEICOJF, BJFNAGPGHOA BCNNFCGENOL, AnchorParamsRestrictions FLHBPAHEJDJ, [Out] Vector3 IFFNKCNEEAK, [Out] Quaternion KLEJIABFHMI, [Out] BJFNAGPGHOA FGICOAOILBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6052DF0", Offset = "0x6051DF0", VA = "0x186052DF0")]
	public void IIPFIIHFCPP(Vector2 PJPEILOBKBB, Vector3 JDMBGEOMIMD, Vector3 OEPNEJHGPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x604C310", Offset = "0x604B310", VA = "0x18604C310")]
	private void CLHAKNPBCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6053B00", Offset = "0x6052B00", VA = "0x186053B00")]
	private void KOILLIEOGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6054520", Offset = "0x6053520", VA = "0x186054520")]
	[CompilerGenerated]
	private void MNIDJPLJKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6055210", Offset = "0x6054210", VA = "0x186055210")]
	[CompilerGenerated]
	private void OBAJFJIIDHE(OJBHIDCBIEJ FEFELFKNDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6054DF0", Offset = "0x6053DF0", VA = "0x186054DF0")]
	[CompilerGenerated]
	private void NODBOBPMKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6055980", Offset = "0x6054980", VA = "0x186055980")]
	[CompilerGenerated]
	private void PAEHICGOEDK(OJBHIDCBIEJ FEFELFKNDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60558F0", Offset = "0x60548F0", VA = "0x1860558F0")]
	[CompilerGenerated]
	private void OOLNNODLMGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6052DD0", Offset = "0x6051DD0", VA = "0x186052DD0")]
	[CompilerGenerated]
	private void IILGDPFDBDK(OJBHIDCBIEJ FEFELFKNDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6054BE0", Offset = "0x6053BE0", VA = "0x186054BE0")]
	[CompilerGenerated]
	private void NLILFFLIDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x604B1B0", Offset = "0x604A1B0", VA = "0x18604B1B0")]
	[CompilerGenerated]
	private void BIJAGHAPIJK(OJBHIDCBIEJ FEFELFKNDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6052FB0", Offset = "0x6051FB0", VA = "0x186052FB0")]
	[CompilerGenerated]
	private void IJMMLPGIOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6055800", Offset = "0x6054800", VA = "0x186055800")]
	[CompilerGenerated]
	private void OLPMFNLCDIM(OJBHIDCBIEJ FEFELFKNDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x604F6D0", Offset = "0x604E6D0", VA = "0x18604F6D0")]
	[CompilerGenerated]
	private void ELKGNOHGKAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6054E80", Offset = "0x6053E80", VA = "0x186054E80")]
	[CompilerGenerated]
	private void NOLANPOCLAP(OJBHIDCBIEJ FEFELFKNDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x604B700", Offset = "0x604A700", VA = "0x18604B700")]
	[CompilerGenerated]
	private void CGFMELHFFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x604F040", Offset = "0x604E040", VA = "0x18604F040")]
	[CompilerGenerated]
	private void EELPBFFNMHM(OJBHIDCBIEJ FEFELFKNDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6052C30", Offset = "0x6051C30", VA = "0x186052C30")]
	[CompilerGenerated]
	private void IAIEAECOGFC(KeyValuePair<string, DEHADEPDEGA<Texture2D>> OOKMNHBKLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6054EB0", Offset = "0x6053EB0", VA = "0x186054EB0")]
	[CompilerGenerated]
	private void NPNBDDFDBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x604E520", Offset = "0x604D520", VA = "0x18604E520")]
	[CompilerGenerated]
	private void DDBJCNCLPBP(OJBHIDCBIEJ FEFELFKNDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6056250", Offset = "0x6055250", VA = "0x186056250")]
	[CompilerGenerated]
	private void PNJPNLKDKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60529F0", Offset = "0x60519F0", VA = "0x1860529F0")]
	[CompilerGenerated]
	private void GPOBKFAPGCN(OJBHIDCBIEJ FEFELFKNDDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class EBJBENHNOON : KKPBJLIGLDA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct JAJNOKFKOPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Vector2 FIONMPEPGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public Vector2 CPILIJNCDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Vector2 HLCPIOKOMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Vector2 JOOLDHIIMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Vector2 FCEABEJCAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Vector2 JDEOFIIEGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Vector2 KHPJPOOGMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Vector2 NICGADDBCCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector2 IICABIKOOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector2 HLCHEDNFPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Vector2 PBDEPCPIKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public Vector2 ENOBKLAIJPG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly int JGBAGICOPKH;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly int PCKKKDLBDIN;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly int KFICBFJAAOD;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly int CCJFAJKNKND;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly int EFEKHPFMPOG;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly int BOFHLBOKHAI;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly int PONGDGPLHCP;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int EHJPLBCOGPP;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int JKNKHOMDGFE;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int OEEKPHCCIEM;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int GOMBEDFHOKP;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int GPICHOHIKCA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int LJJJHKEADNE;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int NNMKJGLPMPL;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int OOHJDPONEHJ;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int BLEPGGKHLAA;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int GDMAPGKOPFE;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int BLPIIMGICJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private Transform KILEAMLFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private Transform KDACICHEOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Transform GNAFNNDGCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private Transform MOCBDNIBHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Transform KGPANLLCEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private Transform LGFEPPMKEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Transform MBDPAJLAAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private PIKANHFODBJ HNGHBEMDLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private MaterialPropertyBlock MNBLHPDFACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private SkinnedMeshRenderer[] BIHANMFKDFH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private MaterialPropertyBlock EHMCBABHANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6058CB0", Offset = "0x6057CB0", VA = "0x186058CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60585B0", Offset = "0x60575B0", VA = "0x1860585B0", Slot = "6")]
	public void DPGLELIALOP(PIKANHFODBJ NLNJNAOHNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6058580", Offset = "0x6057580", VA = "0x186058580", Slot = "7")]
	public void DANGCCOFJDE(MKOMCBJDJIO BGHPMOMJNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6058D30", Offset = "0x6057D30", VA = "0x186058D30", Slot = "4")]
	public void LBHILABCCNL(FNDGGPJMFOH ADGJFDDFMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60579C0", Offset = "0x60569C0", VA = "0x1860579C0", Slot = "5")]
	public void BAGBNIGJAME(POPLICIOBHL BGHPMOMJNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6058670", Offset = "0x6057670", VA = "0x186058670")]
	private void FKGIOEDIOKI(POPLICIOBHL FHLNFLBKDLG, JAJNOKFKOPI ADKHFNMKHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x60578E0", Offset = "0x60568E0", VA = "0x1860578E0")]
	private void AKHOKKJPLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6059490", Offset = "0x6058490", VA = "0x186059490")]
	public EBJBENHNOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6058500", Offset = "0x6057500", VA = "0x186058500")]
	[CompilerGenerated]
	private Vector4 BPMNLIAPNMM(Vector2 PKDBIHBDKOO, Vector2 LIDGFFGHMOF)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6058C40", Offset = "0x6057C40", VA = "0x186058C40")]
	[CompilerGenerated]
	private Vector4 GLHCMDHDKEH(float KBGPODBODFD, float OGFDKJDCKLJ, float FLKJIPPDDPM, float ECPMBFJJFOP)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OJBHIDCBIEJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private MaterialPropertyBlock GMNCPCFGKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Color? AIGHIJPFDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Color? CCAOELCFKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color? MPHPPBNHEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color? KFCBCIDOKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color NCFGCEEOMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Color KAMJHKBIFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Color MBGHCFHICMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Texture2D PENELPBLCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Texture2D GMEDPIIGHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private Dictionary<CMJAOHLMCNP, int> KNKGHCILLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private IEINHBNEHMJ[] IACMPOLDCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private CJFDPJNLGLA[] HFILIPGJFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Vector4[] EOPGBPPBDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Vector4[] JKLHDENKMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] NPNDANCMJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] KODLAJMMNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4[] BMPEFFGDJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4[] GKGJCHPLEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private List<Texture2D> LBKGMKKCNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Vector4[] CDEHDJNFGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> OHIIFNJLDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float[] BDEAAGMNPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Vector4[] JGKJODFNMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private float[] ONGNINGDMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public float[] EMGHECOJANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private List<Texture2D> NEBIBNMHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private float[] EOHONIMLMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private List<Texture2D> MEOIIAOPJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Vector4[] CNBJKAOEPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] HOMJENOIEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Vector4[] FLECBBHFBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public float[] EEKCCFJEEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public Texture2DArray DNBMNNFMCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Texture2DArray FNBJCCEJMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Texture2DArray OGDHJHLHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Texture2DArray HFBCJEHBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private bool IOGOGFCNHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int OLFGBILFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private Vector2? EMABIJPMNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private TextureFormat PFEJGMJLIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private Vector2? AKBADHJHGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private TextureFormat OJHGGEDGDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private Vector2? GLMOGJOAHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private TextureFormat IJBPOAGGNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Vector2? JDLJPKNHMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private TextureFormat NHBMECBCNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool HBKBODDFLFH;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int MDNBHOJLJOB;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int FMKFDNIJFCO;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int PCFFPBFNFFP;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int BIOCKINLOBL;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int ODIANOAHAOA;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int PEMNCJCMIMK;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int OGBEFEOBDGJ;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int CALMFBDFODE;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int ACOGCAMPGGP;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int MCAPNELJLGP;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int MHLNCHIHJMK;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int GOBCPAPHBNF;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int BCIBHOKDICN;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int JCCDNOMNFIA;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int FNKJCEODNBL;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int DAFGGGAIDKH;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int LENDFONKHGA;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int JNDMJGIFKDF;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int JKBBPJJBEMH;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static int DPCOOKKGGML;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6066DC0", Offset = "0x6065DC0", VA = "0x186066DC0")]
	private OJBHIDCBIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6066D00", Offset = "0x6065D00", VA = "0x186066D00")]
	public OJBHIDCBIEJ(Color MIMMMOLILDF, Color NLLFCCKGEMG, Color PPANNPOAKIK, Color? HJOIOJAODCF, Color? EPKMNHLMCEG, Color? JLEAKJBOGEI, Texture2D DOLNOBINKIA, Texture2D EEMOBCAKMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60664F0", Offset = "0x60654F0", VA = "0x1860664F0")]
	internal int FOGCJKEHBKP(Material PIMAFKAOGDB, IEINHBNEHMJ LGNNHFGDAKL, CJFDPJNLGLA IDEABGHAHGG, HBNDMEPLGIE MDMDOLNBEOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x60665E0", Offset = "0x60655E0", VA = "0x1860665E0")]
	private int FOGCJKEHBKP(CMJAOHLMCNP IPAJBJLLPIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6065920", Offset = "0x6064920", VA = "0x186065920")]
	internal int FKDHBFBACNE(Material PIMAFKAOGDB, Color FONBBIKPAJL, Color HPEJPCMHICO, Color DKHJJBPGHDH, Color PIAGPENFDKH, Color GHNFOLFKACG, Texture2D NGBKGPJEHNF, Vector4 BGNOFHJGCMF, Texture2D NPDHJJPFNBK, Vector4 FCFEEGBNABL, float AIAKDALLMBL, float LAHFEPNPIEH, Texture2D FHMLMDCJFLH, Vector4 CNBDNCDACBJ, float NLHHAMIHEJG, Texture2D CBNELEKKGJK, Color KIIDADAOAOG, Vector4 MOFBIBMFMMO, IEINHBNEHMJ LGNNHFGDAKL, CJFDPJNLGLA IDEABGHAHGG, HBNDMEPLGIE MDMDOLNBEOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6065760", Offset = "0x6064760", VA = "0x186065760")]
	private void EHFCDNEFHPO(List<Texture2D> LBKGMKKCNJC, [Out] Texture2DArray EFFHNODDAPN, [Out] Texture2DArray OEBHAENEFFN, [Out] Texture2DArray BEBEPKPDMLH, [Out] Texture2DArray DLKDMKBNIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6064680", Offset = "0x6063680", VA = "0x186064680")]
	public void CKFPHPGIEIA(Shader PPFLJPCBLPM, Renderer JFDOOADJAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x60647D0", Offset = "0x60637D0", VA = "0x1860647D0")]
	private void CNJJFGDLCLE(Shader PPFLJPCBLPM, Renderer JFDOOADJAOI, int FEKOPPGBLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6065560", Offset = "0x6064560", VA = "0x186065560")]
	private Color EEJGINGLJIM(Color HCMFDEFEGLD, IEINHBNEHMJ PNANPEFMMFH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6066770", Offset = "0x6065770", VA = "0x186066770")]
	private Color HDNFKPEBOCL(Color DEPFFDMCJII, IEINHBNEHMJ PNANPEFMMFH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6066670", Offset = "0x6065670", VA = "0x186066670")]
	private bool GLMPNPIAPFA(Texture2D LEDHPFBIFOK, CJFDPJNLGLA MAOEONNNPJK, [Out] Texture2D LKBKHODGMIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60668C0", Offset = "0x60658C0", VA = "0x1860668C0")]
	private void IPOKKMKDMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6065520", Offset = "0x6064520", VA = "0x186065520", Slot = "4")]
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
		private AGBHMEHPHAE? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public DFCKPJMGFPE CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6061E40", Offset = "0x6060E40", VA = "0x186061E40")]
			get
			{
				return default(DFCKPJMGFPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public AGBHMEHPHAE MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6061E90", Offset = "0x6060E90", VA = "0x186061E90")]
			get
			{
				return default(AGBHMEHPHAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7C3250", Offset = "0x7C2250", VA = "0x1807C3250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7C01B0", Offset = "0x7BF1B0", VA = "0x1807C01B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6061C90", Offset = "0x6060C90", VA = "0x186061C90")]
		public Material[] NEEPIMNBIIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6061AD0", Offset = "0x6060AD0", VA = "0x186061AD0")]
		public static void AOOOHFEENOJ(AvatarItemMaterial MDBCLFIBJFI, Material BKIIKPMMAIB, int JNBHLFHNMEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6061D70", Offset = "0x6060D70", VA = "0x186061D70")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BLFHHLMIMBP]
public struct LFJLLHDFFNK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	public OPHFKKEIGMO HMGPIJKOPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[ReadOnly]
	public int BDKAJNGMCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public PNDIDAPHJAD CPFGLKKELPF;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6063750", Offset = "0x6062750", VA = "0x186063750", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NativeContainer]
[BLFHHLMIMBP]
public struct PNDIDAPHJAD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Vector3> LJKEAEJMMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<Vector3> BLGGIMHPMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector4> CAFFOCBNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector2> NINCEPKHAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector2> ODPHHOIKINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> FDDILEMFDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Vector2> DBNBLCOADNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<Color> EOEJJJNGEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<int> LFAFJPBDLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> GIHENJLIEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private NativeArray<int> CNOFIMLFPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private NativeArray<int> CCANJFAJGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<int> GPIADHJKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> COMCJHHCOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<int> FMHHPPDNCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<BoneWeight> CJKNDPAPKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private NativeArray<int> JJOLHONNFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private bool PMFPBMMAHDG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int NKPCJDHMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6069DA0", Offset = "0x6068DA0", VA = "0x186069DA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6069890", Offset = "0x6068890", VA = "0x186069890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int KIFPNGCIDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6069D90", Offset = "0x6068D90", VA = "0x186069D90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x60698C0", Offset = "0x60688C0", VA = "0x1860698C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int KHHIBKKCDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6069A30", Offset = "0x6068A30", VA = "0x186069A30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x60693F0", Offset = "0x60683F0", VA = "0x1860693F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6069E30", Offset = "0x6068E30", VA = "0x186069E30")]
	public PNDIDAPHJAD(int NGKNIJKDHEO, int OAABMLFCLHB, int NDBCPNBKGPO, int LIDBCCNNJCK, Allocator NHBLMPKODCH, int JNDJMNMKIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6069400", Offset = "0x6068400", VA = "0x186069400")]
	public void AGCHLFDNKDH(int GCDIELAOHNA, Vector3 IFEDOEKJDOP, Vector3 IAFMBOFHOEJ, Vector4 MPLEEKHPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6069540", Offset = "0x6068540", VA = "0x186069540")]
	public void BNPPOFPGHHO(int GCDIELAOHNA, BoneWeight IPOFHNDFKCF, NativeSlice<byte> NHMOGBDHCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6069470", Offset = "0x6068470", VA = "0x186069470")]
	public Color BFPFEDKMIIO(int GCDIELAOHNA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x60698A0", Offset = "0x60688A0", VA = "0x1860698A0")]
	public void GCOLALCGMCG(int GCDIELAOHNA, Color BKPEEMPJCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6069DB0", Offset = "0x6068DB0", VA = "0x186069DB0")]
	public void NBDJPJBCBDO(byte PAHJIKELMJJ, int GCDIELAOHNA, Vector2 GMPHJCEODDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x60693E0", Offset = "0x60683E0", VA = "0x1860693E0")]
	public void ABEDDIBGLFP(int GCDIELAOHNA, int DBOGDPANCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6069E00", Offset = "0x6068E00", VA = "0x186069E00")]
	public bool PNOPCLGNOFE(int PAHJIKELMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x60698D0", Offset = "0x60688D0", VA = "0x1860698D0")]
	public void HAEOGHEEJNN(int OAEDGOJDPGB, int CNHEAECNOFO, int NAHHNFGPNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6069490", Offset = "0x6068490", VA = "0x186069490")]
	public int[] BGEKLLCCHNO(int OAEDGOJDPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x60699A0", Offset = "0x60689A0", VA = "0x1860699A0")]
	private NativeSlice<int> HKMGHMIDECG(int OAEDGOJDPGB)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x60696E0", Offset = "0x60686E0", VA = "0x1860696E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6069A40", Offset = "0x6068A40", VA = "0x186069A40")]
	public Mesh KLDPDIGDKAP([Optional] string KGEPDAHENOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
[BLFHHLMIMBP]
[NativeContainer]
public struct OPHFKKEIGMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Vector3> LJKEAEJMMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector3> BLGGIMHPMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector4> CAFFOCBNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector2> NINCEPKHAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector2> ODPHHOIKINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector2> FDDILEMFDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> DBNBLCOADNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Color> EOEJJJNGEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<int> CKFMPKDGGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<int> ADCPNAFLLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> KLLAFBKPEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> MOILNOIEMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> HMFCGFBFJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<BoneWeight> LPNOMAONENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private NativeArray<Matrix4x4> NHOOACPOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private NativeArray<int> MIEAPLJANDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private NativeArray<byte> PAAAKEOLCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NativeArray<int> OFLCPCKNKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> FBJCOJBAEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<sbyte> PAFPKOJABNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<byte> OLFLILLJLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> KPAPEMHIJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private bool PMFPBMMAHDG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int NJKCNOEIDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DFGIOKDIPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xEA52B0", Offset = "0xEA42B0", VA = "0x180EA52B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int IGHIKJCLPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6067600", Offset = "0x6066600", VA = "0x186067600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int EGMDNOMMFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6067B50", Offset = "0x6066B50", VA = "0x186067B50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6067630", Offset = "0x6066630", VA = "0x186067630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int NKPCJDHMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6067B40", Offset = "0x6066B40", VA = "0x186067B40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x60675E0", Offset = "0x60665E0", VA = "0x1860675E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int LJLAKKLJBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6067640", Offset = "0x6066640", VA = "0x186067640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6067500", Offset = "0x6066500", VA = "0x186067500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public GIAKACMCMLB FKPDLELNEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6067B60", Offset = "0x6066B60", VA = "0x186067B60")]
		get
		{
			return default(GIAKACMCMLB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x60675F0", Offset = "0x60665F0", VA = "0x1860675F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public byte IIFPFIDNHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x60672B0", Offset = "0x60662B0", VA = "0x1860672B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x60672C0", Offset = "0x60662C0", VA = "0x1860672C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public OEDIHJEPCGB EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6067650", Offset = "0x6066650", VA = "0x186067650")]
		get
		{
			return default(OEDIHJEPCGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6067B70", Offset = "0x6066B70", VA = "0x186067B70")]
	public OPHFKKEIGMO(IList<Mesh> HPJFAICFJLL, IList<Matrix4x4> LMOJLMIMBMD, byte MMDHGACNOLD, IList<byte[]> ELGOKFLNNIH, IList<int> OBDGCHJHEIL, IList<bool> JLFNIDAGANH, IList<int> NPKLBKBDHKA, IList<int> PGLOBDBLBFP, Allocator NHBLMPKODCH, GIAKACMCMLB PAAAFLBAHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6067510", Offset = "0x6066510", VA = "0x186067510")]
	public PNDIDAPHJAD ELOFFOAILDB(Allocator NHBLMPKODCH)
	{
		return default(PNDIDAPHJAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x60672D0", Offset = "0x60662D0", VA = "0x1860672D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BLFHHLMIMBP]
public class NPJFFGCCCPL : CKFECJKAHGI
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x60645A0", Offset = "0x60635A0", VA = "0x1860645A0")]
	public OPHFKKEIGMO NEBGAONENGC()
	{
		return default(OPHFKKEIGMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6064670", Offset = "0x6063670", VA = "0x186064670")]
	public NPJFFGCCCPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct OEDIHJEPCGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeSlice<Vector3> LJKEAEJMMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeSlice<Vector3> BLGGIMHPMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeSlice<Vector4> CAFFOCBNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<Vector2> NINCEPKHAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector2> ODPHHOIKINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Vector2> FDDILEMFDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<Vector2> DBNBLCOADNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<Color> EOEJJJNGEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<int> DIDIPJMBAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<int> MOILNOIEMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<BoneWeight> LPNOMAONENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<byte> LIKMEFPCPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int BLEGOJLGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public Matrix4x4 OBGIJBCHKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int FBHLMBGGKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<byte> NHMOGBDHCHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal readonly struct CMJAOHLMCNP : IEquatable<CMJAOHLMCNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	internal readonly Material LEOHDFJHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	internal readonly IEINHBNEHMJ JPLLHMNMHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	internal readonly CJFDPJNLGLA LDMBHFJEEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	internal readonly HBNDMEPLGIE CKODPFCHIHB;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8C3C30", Offset = "0x8C2C30", VA = "0x1808C3C30")]
	public CMJAOHLMCNP(Material BKIIKPMMAIB, IEINHBNEHMJ LGNNHFGDAKL, CJFDPJNLGLA IDEABGHAHGG, HBNDMEPLGIE MDMDOLNBEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x60620D0", Offset = "0x60610D0", VA = "0x1860620D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8C3990", Offset = "0x8C2990", VA = "0x1808C3990", Slot = "4")]
	public bool Equals(CMJAOHLMCNP PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6061F50", Offset = "0x6060F50", VA = "0x186061F50", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6062030", Offset = "0x6061030", VA = "0x186062030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class HMCMGMPMLJP : PAIABHMLGAM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private LABMLPLFFCF BDAHLCBJFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private FEFECJKDIFA FDMGFMIKDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private IRecRoomQualityConfigProvider BLMEAANNOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool PMFPBMMAHDG;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6063160", Offset = "0x6062160", VA = "0x186063160")]
	[KEBGMDILACL(JMIJNHPDBML.GameOnly)]
	private static void LMNGPPGMDIK(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x53C4AA0", Offset = "0x53C3AA0", VA = "0x1853C4AA0")]
	[Preserve]
	public HMCMGMPMLJP([CJCLEPGLAOP(null)] FEFECJKDIFA HOPIMGADJFP, [CJCLEPGLAOP(null)] LABMLPLFFCF BHOLOIOPMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x60630F0", Offset = "0x60620F0", VA = "0x1860630F0")]
	private void KGCIANAIAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6063090", Offset = "0x6062090", VA = "0x186063090", Slot = "4")]
	public void GFEMDNCLFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6062BD0", Offset = "0x6061BD0", VA = "0x186062BD0", Slot = "5")]
	public DEHADEPDEGA<Texture2D> CPMBDJMDHAA(PHHOGKCECLL NFGMNILPEKA, [Optional] NEKMEADJBGB JJOLHONNFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6063260", Offset = "0x6062260", VA = "0x186063260")]
	private uint MCLFGANNKII(PHHOGKCECLL NFGMNILPEKA, NEKMEADJBGB JJOLHONNFIA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface OEJLECFHNPO
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGHBOGHGMNM(Mesh KNFCOBLCFKE, Matrix4x4 CPLFOPMNOBC, byte[] NHMOGBDHCHJ, bool JPEMBOFMBEB = false, LDAEMHAJKEP.BEGKLKBPJCD AKGJHDHKMML = (LDAEMHAJKEP.BEGKLKBPJCD)0);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBAGLGDJGFJ(Allocator NHBLMPKODCH, GIAKACMCMLB PAAAFLBAHIE, byte MMDHGACNOLD, [Optional] IList<int> NPKLBKBDHKA, [Optional] IList<int> PPPIOJNOOIN);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct CANBPMKPEIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly GameObject EHPIIEKIOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly AvatarItemMaterial LAHFMGHHLMB;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x909C10", Offset = "0x908C10", VA = "0x180909C10")]
	public CANBPMKPEIA(GameObject EHPIIEKIOHO, AvatarItemMaterial LAHFMGHHLMB)
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
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x606A270", Offset = "0x6069270", VA = "0x18606A270")]
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
		private struct IGDKDJIHCJM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public AsyncTaskMethodBuilder<EBEJOMINEDA> <>t__builder;

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
			private TaskAwaiter<EBEJOMINEDA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x60633A0", Offset = "0x60623A0", VA = "0x1860633A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x60636E0", Offset = "0x60626E0", VA = "0x1860636E0", Slot = "5")]
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
		private Dictionary<NOGNCKDKHOJ, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private Dictionary<NOGNCKDKHOJ, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private Dictionary<NOGNCKDKHOJ, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private Dictionary<NOGNCKDKHOJ, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private readonly Dictionary<NOGNCKDKHOJ, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private EBEJOMINEDA _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x6062BA0", Offset = "0x6061BA0", VA = "0x186062BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6062370", Offset = "0x6061370", VA = "0x186062370")]
		public EBEJOMINEDA BALNKOIMCPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x60627B0", Offset = "0x60617B0", VA = "0x1860627B0")]
		[AsyncStateMachine(typeof(IGDKDJIHCJM))]
		public Task<EBEJOMINEDA> MAPGGPMLICA(int JCJHKFDKMPM, int DINFGLNADAM, int DKAFPBFGBIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6062590", Offset = "0x6061590", VA = "0x186062590")]
		public NoseFaceOption FLJEIGHJBBE(int FHEGFHBIJHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6062630", Offset = "0x6061630", VA = "0x186062630")]
		public SelectableFaceOption HOJEHDLFNFC(FaceFeatureType PIIMKKAEBGD, NOGNCKDKHOJ CBNJEBIODHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x60622F0", Offset = "0x60612F0", VA = "0x1860622F0")]
		public int AOMDGAEHGOJ(NOGNCKDKHOJ CBNJEBIODHP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x60628E0", Offset = "0x60618E0", VA = "0x1860628E0")]
		private void NCHFPEJPJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2791560", Offset = "0x2790560", VA = "0x182791560")]
		private void BADKOJLKOOL<T>(IDictionary<NOGNCKDKHOJ, T> MBMBPCDJPPA, IReadOnlyList<T> HBKCNKNEAPD) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x60623C0", Offset = "0x60613C0", VA = "0x1860623C0")]
		public NOGNCKDKHOJ CHPJIIHEEJM(FaceFeatureType PIIMKKAEBGD)
		{
			return default(NOGNCKDKHOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6062470", Offset = "0x6061470", VA = "0x186062470")]
		public NOGNCKDKHOJ FJCEEECNDHD(FaceFeatureType PIIMKKAEBGD)
		{
			return default(NOGNCKDKHOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6062B10", Offset = "0x6061B10", VA = "0x186062B10")]
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
