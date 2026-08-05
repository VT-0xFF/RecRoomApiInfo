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
[HAGPAHMIPMA]
public class BBJDKMBOJEA : BGOMNFDPFDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	protected readonly List<Mesh> NHOAEIIFNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly List<byte[]> FACIBLCOEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly List<Matrix4x4> ODOIOLCJNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly List<int> IMKLOLPLJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly List<bool> BJPFEKONOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected Allocator OCMPKIBMEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected JDMGGIIDOEO ENAAEJLLJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected byte POJCDBJIFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected IList<int> BJBOHHFKBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected IList<int> COCEOFJBCHB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D450", Offset = "0x5F9C250", VA = "0x185F9D450", Slot = "4")]
	public void KCKNHKPHCBG(Mesh HCHDFAPIGCD, Matrix4x4 ABOHGNCLMJC, byte[] DHJMGJPIHFK, bool ICOIKOGKHEN = false, LEBGJKDCBPN.MDJOAGODMFF MOFICGFDFKG = (LEBGJKDCBPN.MDJOAGODMFF)0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D7A0", Offset = "0x5F9C5A0", VA = "0x185F9D7A0", Slot = "5")]
	public void NEHMHGDBMID(Allocator ALDDPOOJFGI, JDMGGIIDOEO CAPNAGJDMFN, byte IGGJBIHFPDA, [Optional] IList<int> BJMFNMNJKME, [Optional] IList<int> CMDDCEEOLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D320", Offset = "0x5F9C120", VA = "0x185F9D320")]
	private static void HHHNKADLBED(Mesh HCHDFAPIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D7E0", Offset = "0x5F9C5E0", VA = "0x185F9D7E0")]
	public BBJDKMBOJEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[HAGPAHMIPMA]
public struct JBELHCABIJP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[ReadOnly]
	public HJDAAOOMIJI BIHLPAECIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public int GFKOLPEHCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public DLMOEAPCOMN FLOBOPPFJGG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFE20", Offset = "0x5FAEC20", VA = "0x185FAFE20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[NativeContainer]
[HAGPAHMIPMA]
public struct DLMOEAPCOMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct FJFLLFKOMGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Vector3 BFJCCEJKPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Vector3 BKELBBDDNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Vector4 KFMPINIBKCM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct NADIJMMENOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public half OIBOADBBDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public half ACCEEKEICHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public half OGBPGONMPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public half JGLIOFDLONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public byte KLAJFNFGOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public byte MIKJLABJHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte CLFIMPAPEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public byte JCKJGBIKBND;
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct FKKKIFDHDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public half4 DNOKCMICDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public half2 NOAMHLBBAIE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BNBBPDPAMMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public half4 DNOKCMICDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public half2 NOAMHLBBAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public half2 NMBFKNEPFOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct MOAOGDMMILH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public half4 DNOKCMICDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public half2 NOAMHLBBAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public half2 NMBFKNEPFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public half2 GDHODDFANMM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct KPCHGIMIEKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public half4 DNOKCMICDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half2 NOAMHLBBAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half2 NMBFKNEPFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half2 GDHODDFANMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half2 PGHHPKMDPLI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct NLINBAGGCHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float OIBOADBBDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public float ACCEEKEICHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public float OGBPGONMPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float JGLIOFDLONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int KLAJFNFGOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int MIKJLABJHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int CLFIMPAPEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int JCKJGBIKBND;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct AALAOHBEICL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Color DNOKCMICDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Vector2 NOAMHLBBAIE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct HGIABEOBHKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Color DNOKCMICDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector2 NOAMHLBBAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector2 NMBFKNEPFOI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LIHLDNHGNDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Color DNOKCMICDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Vector2 NOAMHLBBAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Vector2 NMBFKNEPFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Vector2 GDHODDFANMM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct INJCGODHGCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Color DNOKCMICDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Vector2 NOAMHLBBAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Vector2 NMBFKNEPFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Vector2 GDHODDFANMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Vector2 PGHHPKMDPLI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HJMOBHPFAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<FJFLLFKOMGP> KPBGKIOOKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<FKKKIFDHDOL> HDDGJCFCEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<BNBBPDPAMMJ> NPPNFHGMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<MOAOGDMMILH> NKKPBIEIGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<KPCHGIMIEKP> MJOCKOKBDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<NADIJMMENOB> MLCJLPMGEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<AALAOHBEICL> GGBAMFCLDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<HGIABEOBHKD> PCJDOMJJFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<LIHLDNHGNDK> GBIFFHDIAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<INJCGODHGCO> LPCAKOAKDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<NLINBAGGCHG> BCICBEPAFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<int> HBPIONJOGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<int> CHALCKGFGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private NativeArray<int> IBGGMGJAGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NativeArray<int> AEKBEIFPBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> AEHALLLPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> LJLKAINOJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<int> CDIKECLMJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<BoneWeight> MADBBFFMIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> JCKJBGDNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool CFDGKBDLFFK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JMGMFBAGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5F9E9B0", Offset = "0x5F9D7B0", VA = "0x185F9E9B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F9E9A0", Offset = "0x5F9D7A0", VA = "0x185F9E9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PJIHJABKLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F9E750", Offset = "0x5F9D550", VA = "0x185F9E750")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EF30", Offset = "0x5F9DD30", VA = "0x185F9EF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JKMCFCBLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EDC0", Offset = "0x5F9DBC0", VA = "0x185F9EDC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EA90", Offset = "0x5F9D890", VA = "0x185F9EA90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IFIAGKIFAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EDD0", Offset = "0x5F9DBD0", VA = "0x185F9EDD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0140", Offset = "0x5F9EF40", VA = "0x185FA0140")]
	public DLMOEAPCOMN(int LAGECHBNBCA, int PIKGOJMIHLC, int EBIENGAMOBF, int HJLFJCOEKCD, Allocator ALDDPOOJFGI, int PAPJEHOABGF, KPIMMFMODFE OBECAMNAIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EEA0", Offset = "0x5F9DCA0", VA = "0x185F9EEA0")]
	public void OAMKHCBECKJ(int OHINPGIGDNE, Vector3 FJKGEGOOFKM, Vector3 GJCLFAIOADJ, Vector4 BHBDNAGLKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E080", Offset = "0x5F9CE80", VA = "0x185F9E080")]
	public void CAAJNJMAGPH(int OHINPGIGDNE, BoneWeight MKHBEKMCNCD, NativeSlice<byte> DHJMGJPIHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EAA0", Offset = "0x5F9D8A0", VA = "0x185F9EAA0")]
	public Color INBOKMLPNDL(int OHINPGIGDNE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FD40", Offset = "0x5F9EB40", VA = "0x185F9FD40")]
	public void PFNOBBPLMFF(int OHINPGIGDNE, Color MEJOABMJHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E3B0", Offset = "0x5F9D1B0", VA = "0x185F9E3B0")]
	public void DCECFMBBMNM(byte ONFJNFOLIFK, int OHINPGIGDNE, Vector2 IHBCCKCCNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E070", Offset = "0x5F9CE70", VA = "0x185F9E070")]
	public void BMFENKEMLPJ(int OHINPGIGDNE, int KHMFILDCBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EE40", Offset = "0x5F9DC40", VA = "0x185F9EE40")]
	public bool NIKHAOJLLBK(int ONFJNFOLIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E9C0", Offset = "0x5F9D7C0", VA = "0x185F9E9C0")]
	public void ICCBMOIKLPI(int MBAAGMDFGNI, int LBJEFCOBKGF, int AKCMMEDPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E760", Offset = "0x5F9D560", VA = "0x185F9E760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EF40", Offset = "0x5F9DD40", VA = "0x185F9EF40")]
	public Mesh OKPPMAMFBAB([Optional] string IHJPDIMDCBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[HAGPAHMIPMA]
[DefaultMember("Item")]
[NativeContainer]
public struct HJDAAOOMIJI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Mesh.MeshDataArray JFNKIAOPIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> PIPPCPKCOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<int> EEPDBLHAAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<BoneWeight> MADBBFFMIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<Matrix4x4> MKGNJEGGLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> IDKFIIDAEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<byte> NJDILAHADAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<int> AINCOGPCMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<int> LHAEKHEFHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<sbyte> GDGJBMDFMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<byte> ADMLNJABEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<int> IADHNMKNMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool CFDGKBDLFFK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MDDBBPCCKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE7A0", Offset = "0x5FAD5A0", VA = "0x185FAE7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HJFFLPFPOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FAEC50", Offset = "0x5FADA50", VA = "0x185FAEC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int LOKBMIOMDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FAEB80", Offset = "0x5FAD980", VA = "0x185FAEB80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KINIINKAPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE7B0", Offset = "0x5FAD5B0", VA = "0x185FAE7B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FAEB30", Offset = "0x5FAD930", VA = "0x185FAEB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JMGMFBAGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE910", Offset = "0x5FAD710", VA = "0x185FAE910")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE900", Offset = "0x5FAD700", VA = "0x185FAE900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MHMFNGHNMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FAEB50", Offset = "0x5FAD950", VA = "0x185FAEB50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FAEC60", Offset = "0x5FADA60", VA = "0x185FAEC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JDMGGIIDOEO COMHKODOJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE790", Offset = "0x5FAD590", VA = "0x185FAE790")]
		get
		{
			return default(JDMGGIIDOEO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5FAEB60", Offset = "0x5FAD960", VA = "0x185FAEB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte CNIAOCNDADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FAEB40", Offset = "0x5FAD940", VA = "0x185FAEB40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FAEB70", Offset = "0x5FAD970", VA = "0x185FAEB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PDMJOGAOKEI GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE920", Offset = "0x5FAD720", VA = "0x185FAE920")]
		get
		{
			return default(PDMJOGAOKEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEC70", Offset = "0x5FADA70", VA = "0x185FAEC70")]
	public HJDAAOOMIJI(IList<Mesh> MMCCNAGPOCD, IList<Matrix4x4> GOPHJIJKKKI, byte IGGJBIHFPDA, IList<byte[]> JGEEHAPOLFA, IList<int> JKINBAPCNGF, IList<bool> IIEOLPEIJBO, IList<int> BJMFNMNJKME, IList<int> HGIMMJDLDBO, Allocator ALDDPOOJFGI, JDMGGIIDOEO CAPNAGJDMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE6E0", Offset = "0x5FAD4E0", VA = "0x185FAE6E0")]
	public DLMOEAPCOMN ADPDILONPCB(Allocator ALDDPOOJFGI, KPIMMFMODFE OBECAMNAIKC)
	{
		return default(DLMOEAPCOMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE7C0", Offset = "0x5FAD5C0", VA = "0x185FAE7C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[HAGPAHMIPMA]
public class GLEGKEPNHBB : BBJDKMBOJEA
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE610", Offset = "0x5FAD410", VA = "0x185FAE610")]
	public HJDAAOOMIJI FBIBDIMPNIN()
	{
		return default(HJDAAOOMIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D7E0", Offset = "0x5F9C5E0", VA = "0x185F9D7E0")]
	public GLEGKEPNHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PDMJOGAOKEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Mesh.MeshData JKIOHICGIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public NativeSlice<BoneWeight> MADBBFFMIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeSlice<byte> HEIHLDEMCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int FFGMEGKLKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Matrix4x4 EDPJPDDCLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int EKEGEKNAOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeSlice<byte> DHJMGJPIHFK;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FDDEHFBFJDN : LFGCKKFEBFK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private abstract class GEPPHPFEKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly LBHJAFLPLDJ CEHBIHCICPG;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public virtual bool CHMAIEKJLCO
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public virtual bool BDHHDPBOKLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual LEBGJKDCBPN.MDJOAGODMFF EKEGEKNAOFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "6")]
			get
			{
				return default(LEBGJKDCBPN.MDJOAGODMFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ENLKMBGJBDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x12B7710", Offset = "0x12B6510", VA = "0x1812B7710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool MFOMMJJJEBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE600", Offset = "0x5FAD400", VA = "0x185FAE600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool LBLLDKFAJKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE5E0", Offset = "0x5FAD3E0", VA = "0x185FAE5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
		protected GEPPHPFEKMD(LBHJAFLPLDJ NHEBLJEEICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract NGBPOFNIFPL NCDNAOGKMNP(int[] FGGPPBBDFOK, List<KLGFKCBCBJL> LKEMFLKBFBO, List<KLGFKCBCBJL> NMBMLLHJGGF);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract AONOPLBCPON OHPJCEAFGPM(uint FBJIHPHAKKE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private class KELPAKIIHBG : GEPPHPFEKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly AvatarSkinAssetItem.OBEEGHGLOFN PLKELJCIFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly AssetReference HDLIAMPMKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly LEBGJKDCBPN.MDJOAGODMFF KLMJGDCICEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly IHGNPHBMLMN? AFNFLIFOHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly Material[] PIHAPDNEHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private SkinnedMeshRenderer[] FKLBCBDEICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private AvatarSkinAssetItem BGGBJKFNFIH;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override LEBGJKDCBPN.MDJOAGODMFF EKEGEKNAOFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7C24B0", Offset = "0x7C12B0", VA = "0x1807C24B0", Slot = "6")]
			get
			{
				return default(LEBGJKDCBPN.MDJOAGODMFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2330", Offset = "0x5FB1130", VA = "0x185FB2330")]
		public KELPAKIIHBG(AvatarSkinAssetItem.OBEEGHGLOFN FNPKFLMBHCH, AssetReference PMHDEFLOFPI, Material APNGIGKKJNI, LBHJAFLPLDJ KDDCBMDFKKC, LEBGJKDCBPN.MDJOAGODMFF OIIPBIANGPL = (LEBGJKDCBPN.MDJOAGODMFF)0, [Optional] IHGNPHBMLMN? ELCGGNFHKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2440", Offset = "0x5FB1240", VA = "0x185FB2440")]
		public KELPAKIIHBG(AvatarSkinAssetItem.OBEEGHGLOFN FNPKFLMBHCH, AssetReference PMHDEFLOFPI, Material APNGIGKKJNI, LEBGJKDCBPN.MDJOAGODMFF OIIPBIANGPL = (LEBGJKDCBPN.MDJOAGODMFF)0, [Optional] IHGNPHBMLMN? ELCGGNFHKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1E60", Offset = "0x5FB0C60", VA = "0x185FB1E60", Slot = "7")]
		public override NGBPOFNIFPL NCDNAOGKMNP(int[] FGGPPBBDFOK, List<KLGFKCBCBJL> LKEMFLKBFBO, List<KLGFKCBCBJL> NMBMLLHJGGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1FF0", Offset = "0x5FB0DF0", VA = "0x185FB1FF0", Slot = "8")]
		public override AONOPLBCPON OHPJCEAFGPM(uint FBJIHPHAKKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5FB22C0", Offset = "0x5FB10C0", VA = "0x185FB22C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1C40", Offset = "0x5FB0A40", VA = "0x185FB1C40")]
		[CompilerGenerated]
		private void MJLABPLBMEJ(GameObject ELGNBNFKLLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class FHIOFAPLIFK : GEPPHPFEKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly IGDAFFBMNAJ IALOONBEGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private NNOEEBAFNLF<EIIOLAOFDHB> AGENDFGKNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public EIIOLAOFDHB NALNFBIKFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private NNOEEBAFNLF<Material>[] PLBIGNLDBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public List<Material> ACMKGHEPKDH;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool CHMAIEKJLCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool BDHHDPBOKLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5FAD7E0", Offset = "0x5FAC5E0", VA = "0x185FAD7E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0140", Offset = "0x1ABEF40", VA = "0x181AC0140")]
		public FHIOFAPLIFK(LBHJAFLPLDJ NHEBLJEEICO, IGDAFFBMNAJ DKGBEKJNGDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5FADBB0", Offset = "0x5FAC9B0", VA = "0x185FADBB0", Slot = "7")]
		public override NGBPOFNIFPL NCDNAOGKMNP(int[] FGGPPBBDFOK, List<KLGFKCBCBJL> LKEMFLKBFBO, List<KLGFKCBCBJL> NMBMLLHJGGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE400", Offset = "0x5FAD200", VA = "0x185FAE400", Slot = "8")]
		public override AONOPLBCPON OHPJCEAFGPM(uint FBJIHPHAKKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD5F0", Offset = "0x5FAC3F0", VA = "0x185FAD5F0")]
		public AONOPLBCPON JFJNKMHOJCA(GameObject PGLCCMENMND, uint FBJIHPHAKKE, bool EFHBHAFCCFK, bool GOIJILFDKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD840", Offset = "0x5FAC640", VA = "0x185FAD840")]
		public static bool MLELDHBHFPB(Renderer[] KAIJBKEBPDP, string JFPOPEPAJLG, [Out] Renderer CEHPINLNGCJ, [Out] Renderer DKHEAPOJHGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE590", Offset = "0x5FAD390", VA = "0x185FAE590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE250", Offset = "0x5FAD050", VA = "0x185FAE250")]
		private AJDDMLEBPHO NNBCNLKPCFI(bool OFGJFEJHIBH = false)
		{
			return default(AJDDMLEBPHO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE150", Offset = "0x5FACF50", VA = "0x185FAE150")]
		private NNOEEBAFNLF<Material>[] NGMBFIDBEFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D520", Offset = "0x3C4C320", VA = "0x183C4D520")]
		[CompilerGenerated]
		private void MEMLGPHJPJN(EIIOLAOFDHB ELGNBNFKLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD4C0", Offset = "0x5FAC2C0", VA = "0x185FAD4C0")]
		[CompilerGenerated]
		private void DGCENGHEOOF(NNOEEBAFNLF<Material> GJPNDEMKHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE530", Offset = "0x5FAD330", VA = "0x185FAE530")]
		[CompilerGenerated]
		private void PDNLKFBOMPC(Material ELGNBNFKLLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class NGOFFNPCDAM : GCNDGCKLHJC<Task<(GameObject, AvatarItemMaterial)>, EIIOLAOFDHB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct CAJAEJECMEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public Task<GameObject> goTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public Task<AvatarItemMaterial> materialTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private GameObject <go>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter<AvatarItemMaterial> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x5F9D9A0", Offset = "0x5F9C7A0", VA = "0x185F9D9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x5F9DEA0", Offset = "0x5F9CCA0", VA = "0x185F9DEA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly NNOEEBAFNLF<GameObject> MPDOKMAOGFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly NNOEEBAFNLF<AvatarItemMaterial> HELANLEKPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private GameObject PAAMLBHNJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private AvatarItemMaterial LIPDJKNNHGF;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2D90", Offset = "0x5FB1B90", VA = "0x185FB2D90")]
		private NGOFFNPCDAM(Task<(GameObject, AvatarItemMaterial)> NPDMMHKHJDL, NNOEEBAFNLF<GameObject> BKDLPIOCEIB, NNOEEBAFNLF<AvatarItemMaterial> CHOMCGLJCOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2700", Offset = "0x5FB1500", VA = "0x185FB2700")]
		public static NGOFFNPCDAM DDJGPPAAHNA(IGDAFFBMNAJ LCENAGBCEFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2C00", Offset = "0x5FB1A00", VA = "0x185FB2C00")]
		[AsyncStateMachine(typeof(CAJAEJECMEA))]
		private static Task<(GameObject, AvatarItemMaterial)> GILKIJIPDAM(Task<GameObject> FMFDFNDCGGH, Task<AvatarItemMaterial> OJJPHMAIKCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2B40", Offset = "0x5FB1940", VA = "0x185FB2B40", Slot = "11")]
		protected override EIIOLAOFDHB ELJPINKFIIG(Task<(GameObject, AvatarItemMaterial)> MBMIBOKKDMO)
		{
			return default(EIIOLAOFDHB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2D30", Offset = "0x5FB1B30", VA = "0x185FB2D30", Slot = "12")]
		protected override void NNBGAKBJGII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct AJDDMLEBPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private NNOEEBAFNLF<EIIOLAOFDHB> ILGDHLEPNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private NNOEEBAFNLF<Material>[] NMBMLLHJGGF;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8F2E80", Offset = "0x8F1C80", VA = "0x1808F2E80")]
		public void KNDKMPHGMPD([Out] NNOEEBAFNLF<EIIOLAOFDHB> PDCBMAPDAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5F9CF30", Offset = "0x5F9BD30", VA = "0x185F9CF30")]
		public void KICJANKLMAL([Out] NNOEEBAFNLF<Material>[] CMHKEDIBOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8F0EC0", Offset = "0x8EFCC0", VA = "0x1808F0EC0")]
		public AJDDMLEBPHO(NNOEEBAFNLF<EIIOLAOFDHB> BAPMFOBAAEE, NNOEEBAFNLF<Material>[] NLKDDMHEDOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JMPHFBJFPNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public FDDEHFBFJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public PICEPJILIEK buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public JMPHFBJFPNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1B00", Offset = "0x5FB0900", VA = "0x185FB1B00")]
		internal void NHAMDABBADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1AE0", Offset = "0x5FB08E0", VA = "0x185FB1AE0")]
		internal void EJINMLEPDIA(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1BB0", Offset = "0x5FB09B0", VA = "0x185FB1BB0")]
		internal void PLPMPMAEIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1B20", Offset = "0x5FB0920", VA = "0x185FB1B20")]
		internal void NINNPONMFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		internal NGBPOFNIFPL NCIJOOEOBNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DEBPDDEFKCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public JMPHFBJFPNK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public DEBPDDEFKCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DF60", Offset = "0x5F9CD60", VA = "0x185F9DF60")]
		internal AOFPNBPNBOO JBKFGIIFKLD(int lod)
		{
			return default(AOFPNBPNBOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MFNHIKIAFJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public List<PICEPJILIEK> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public MFNHIKIAFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2550", Offset = "0x5FB1350", VA = "0x185FB2550")]
		internal void ICGCJJGOLDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ECIOFLBIAPG : IEnumerator<CPLKNCELBEK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private CPLKNCELBEK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FDDEHFBFJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public List<GEPPHPFEKMD> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<PICEPJILIEK> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Func<int, AOFPNBPNBOO> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public OIFIECGGDHF materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private CPLKNCELBEK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
		[DebuggerHidden]
		public ECIOFLBIAPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5FA0AC0", Offset = "0x5F9F8C0", VA = "0x185FA0AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5FA0CD0", Offset = "0x5F9FAD0", VA = "0x185FA0CD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DLIELJDLKLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public FDDEHFBFJDN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public DLIELJDLKLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F9E020", Offset = "0x5F9CE20", VA = "0x185F9E020")]
		internal NGBPOFNIFPL MNFCLIFFHCB(GEPPHPFEKMD p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KNLMIOINKMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public POPJJCECEOD cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public KNLMIOINKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A1800", Offset = "0x8A0600", VA = "0x1808A1800")]
		internal void DOKCPFKOLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8A1820", Offset = "0x8A0620", VA = "0x1808A1820")]
		internal void JFCPEPNCPPI(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KCLAPBJAONH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public FDDEHFBFJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public KCLAPBJAONH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JMMDBJBBMDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public DLMOEAPCOMN defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public HJDAAOOMIJI defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public KCLAPBJAONH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public JMMDBJBBMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5FB17F0", Offset = "0x5FB05F0", VA = "0x185FB17F0")]
		internal void AEMPJLEKDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1A70", Offset = "0x5FB0870", VA = "0x185FB1A70")]
		internal void CBILFAEIHBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class PBKNHOABLHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public KEDCMCCKCGM legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public DGOHOOKEJOI legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public KCLAPBJAONH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public PBKNHOABLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4AA0", Offset = "0x5FB38A0", VA = "0x185FB4AA0")]
		internal void LJCILAEMDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4A30", Offset = "0x5FB3830", VA = "0x185FB4A30")]
		internal void AEPEAGNDLLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class DAEPMILKIIK : IEnumerator<CPLKNCELBEK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private CPLKNCELBEK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private CPLKNCELBEK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
		[DebuggerHidden]
		public DAEPMILKIIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A55D0", Offset = "0x8A43D0", VA = "0x1808A55D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DF10", Offset = "0x5F9CD10", VA = "0x185F9DF10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class AOIAIGGLLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public POPJJCECEOD cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public IGDAFFBMNAJ avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FDDEHFBFJDN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public AOIAIGGLLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5F9CFD0", Offset = "0x5F9BDD0", VA = "0x185F9CFD0")]
		internal NGBPOFNIFPL ECOFFCGDEKH(FNCIPLMHGGI item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D2E0", Offset = "0x5F9C0E0", VA = "0x185F9D2E0")]
		internal void KJFJGMIIOPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class PJKMMDLCMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public NNOEEBAFNLF<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public PJKMMDLCMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4D20", Offset = "0x5FB3B20", VA = "0x185FB4D20")]
		internal void JPOPMKMHHHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MOELCAAOLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public LBHJAFLPLDJ overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public MOELCAAOLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2680", Offset = "0x5FB1480", VA = "0x185FB2680")]
		internal bool JFCDNGAPOOB(KeyValuePair<string, IGDAFFBMNAJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private AvatarConfiguration PFMAMADPNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private Transform EBKMKIOAHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private AssetReference HDLIAMPMKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private GameObject GPKHFONHGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private GameObject KIEPKHCCPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private SkinnedMeshRenderer MKOCDACCHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private Transform[] CCCBLMMIIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Matrix4x4[] LPJOJKPPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Material IBDFDCDPNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Material NEKCKNPDLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private Material CMAGFAGEPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Shader KAOHGOOPCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private Shader PBDGCOJINIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Animator AGCCKNLDODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Renderer[] PCOEFCEGCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private LEBGJKDCBPN.MDJOAGODMFF JJHCKACALHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private Color NDMKFNDGJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private Color KJPJIHILKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Color PGIDEHHCLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Color? GDHOLAKEPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Color? EAGPPPIBLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Color? NKGHMIHKFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Color? NFMEBLNMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private Texture2D JMOLKPLDALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Texture2D KEOFCIPPHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[CanBeNull]
	private IGDAFFBMNAJ JDJGFPLIDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Texture NLFDFHHKCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private Color HNJCAOEGIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Dictionary<Renderer, OIFIECGGDHF> APFLHPGPDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Dictionary<Renderer, OIFIECGGDHF> JGFKGLPBHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Dictionary<string, List<CHEGPCAKJBB>> NPIPMOOJJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Dictionary<string, List<CHEGPCAKJBB>> HGAOLGEJPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<KLGFKCBCBJL> CMJNOBCBAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<KLGFKCBCBJL> IOGMPKKKLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<KLGFKCBCBJL> IFGOGIOHAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly List<KLGFKCBCBJL> LMNIPBEPFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<CHEGPCAKJBB, Material> MAPCFFHMIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<CHEGPCAKJBB, Material> AJGGHKNAADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private SkinnedMeshRenderer[] NAIDEDEDBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private SkinnedMeshRenderer[] ONKDDHPKJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private SkinnedMeshRenderer[] GHJEEFIAANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private SkinnedMeshRenderer[] HBDCAOLBKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<string, NNOEEBAFNLF<Texture2D>> MEIPLFPAJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<string, NNOEEBAFNLF<Texture2D>> HAEGFHJJCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private FitMeshHemisphere HIGIJACNBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool KMEOIBAIJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private GGOPBMFCMPG JGBDBLOLHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool ADIHKGPCMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AnchorParamsRestrictions JOGNEIMAJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool IIKIEACFPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Transform IMLLNHAFFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform CJGGFNDBMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool FIIJGJDDGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x201")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool JDAEFFGINPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Vector3 ALLHOGDCABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Quaternion GOLLGEONBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector2 KCIPKFJKAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private FitMeshHemisphere DOOHFBHPHOJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material PFHDCAMJKJJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material ODAIKAFAAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<string, IGDAFFBMNAJ> NOJMFHEDAHP;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly int MKHPGAKOPHA;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly int MJOEFBLCCMF;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly int FJKGJKCCKLM;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly int DLFAMDIOOOM;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly int OJBMDFPLIHJ;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly int FDMKKPMKNJG;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly int JOBKCFCFLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CGNODMPJOCB FNDEMJGDDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CGNODMPJOCB NFEPBEKNFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool LHDMGAHONDN;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static Lazy<NCBPOKBECKK> MGJFNKMBFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Lazy<HIALFNKGBFD> NELMJBOGDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Lazy<HGLCHBFMHNO> MCGKJFKHKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private List<Action> MNBLEIDIFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private IEJPOIEPOPD HLOIIBIGAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private SkinnedMeshRenderer[] LKGNECBBGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int HCALDIIODKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool ELEPGKIMHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int HOAMBGAANJP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool BJDJCEFONMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4C00", Offset = "0x5FA3A00", VA = "0x185FA4C00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3C30", Offset = "0x5FA2A30", VA = "0x185FA3C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool PCDJKCBNHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xF0DF90", Offset = "0xF0CD90", VA = "0x180F0DF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Material MBIHJGGAMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6110", Offset = "0x5FA4F10", VA = "0x185FA6110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Material OIJHPDCHICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5A40", Offset = "0x5FA4840", VA = "0x185FA5A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool PFDCGOFFMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static NCBPOKBECKK PMHJNOIDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3CE0", Offset = "0x5FA2AE0", VA = "0x185FA3CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private HIALFNKGBFD PBMPDPOHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5BF0", Offset = "0x5FA49F0", VA = "0x185FA5BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private HGLCHBFMHNO MPFJKDFHLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4C90", Offset = "0x5FA3A90", VA = "0x185FA4C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CGNODMPJOCB ODKFENHGPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x972A40", Offset = "0x971840", VA = "0x180972A40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CGNODMPJOCB GFGCCOKNBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x148C740", Offset = "0x148B540", VA = "0x18148C740", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public SkinnedMeshRenderer[] ONDKIKPJHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x16AF9D0", Offset = "0x16AE7D0", VA = "0x1816AF9D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Renderer[] ABLHAGCKMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BFBA0", Offset = "0x7BE9A0", VA = "0x1807BFBA0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool HMJIBBMJJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5FA91D0", Offset = "0x5FA7FD0", VA = "0x185FA91D0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LEBGJKDCBPN.MDJOAGODMFF PBJCOHDIBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xE64F30", Offset = "0xE63D30", VA = "0x180E64F30", Slot = "18")]
		get
		{
			return default(LEBGJKDCBPN.MDJOAGODMFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int MHAFFHEAENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x830BE0", Offset = "0x82F9E0", VA = "0x180830BE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3D60", Offset = "0x5FA2B60", VA = "0x185FA3D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool DLCAICLHJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3950", Offset = "0x5FA2750", VA = "0x185FA3950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private static bool BKFMPJAKNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB3C0", Offset = "0x5FAA1C0", VA = "0x185FAB3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FACBA0", Offset = "0x5FAB9A0", VA = "0x185FACBA0")]
	public FDDEHFBFJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8960", Offset = "0x5FA7760", VA = "0x185FA8960", Slot = "21")]
	public void KCJBJGBIMAI(HOGCNDGKBLL BLJPOKNEKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC220", Offset = "0x5FAB020", VA = "0x185FAC220", Slot = "22")]
	public void PBMDDEKLOGF(JNONOCKNNJB CHNIOFPAFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3D60", Offset = "0x5FA2B60", VA = "0x185FA3D60", Slot = "4")]
	public void DCEOAIMDOPN(int FBJIHPHAKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC2A0", Offset = "0x5FAB0A0", VA = "0x185FAC2A0", Slot = "9")]
	public void PBMNFIODKCK(CEFPAMDHKDL OIMJJCCHOJO, Texture2D MJKCCMHJFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA55C0", Offset = "0x5FA43C0", VA = "0x185FA55C0", Slot = "10")]
	public void GCJMCOBHGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4850", Offset = "0x5FA3650", VA = "0x185FA4850", Slot = "11")]
	public bool EOMABMHGEDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5640", Offset = "0x5FA4440", VA = "0x185FA5640", Slot = "8")]
	public void GEICDLEDGJE(AFKMFICKBFF BIHMCFPJJBL, Color? DNOKCMICDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4C10", Offset = "0x5FA3A10", VA = "0x185FA4C10")]
	private void FCIBEKGKFEN(Action PGHAOCICNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4040", Offset = "0x5FA2E40", VA = "0x185FA4040", Slot = "5")]
	public void DIJFAGMBHMI(IGDAFFBMNAJ OPNMDKNKMAG, Texture GOOJPJEOJMH, Color IBCKEKJELDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3C30", Offset = "0x5FA2A30", VA = "0x185FA3C30", Slot = "6")]
	public void CDIKLAHNKLF(bool GGCMACPIGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x13D5970", Offset = "0x13D4770", VA = "0x1813D5970", Slot = "7")]
	public void JEIOPIDFACK(IEJPOIEPOPD JCKJBGDNIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6370", Offset = "0x5FA5170", VA = "0x185FA6370", Slot = "14")]
	public PICEPJILIEK IOEHFNGNCBJ(LDKPIIFEPKA ILMGMFACOBG, bool LPNJBDBOPPM, int[] NMPKKNDGNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5FA86D0", Offset = "0x5FA74D0", VA = "0x185FA86D0", Slot = "15")]
	public void JPCBNIODHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB8A0", Offset = "0x5FAA6A0", VA = "0x185FAB8A0")]
	private bool NDJDEBOJMBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xE64B80", Offset = "0xE63980", VA = "0x180E64B80", Slot = "19")]
	public void AAOFHAILEBL(LEBGJKDCBPN.MDJOAGODMFF NLBNOHNGPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8D80", Offset = "0x5FA7B80", VA = "0x185FA8D80")]
	private bool KGPPJBEIAEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1210", Offset = "0x5FA0010", VA = "0x185FA1210")]
	private PICEPJILIEK ANKPJHHAHEF(bool LPNJBDBOPPM, List<GEPPHPFEKMD> LNJDGIBCOPL, int[] NMPKKNDGNMO, Func<int, AOFPNBPNBOO> BFOCEFAOEDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1100", Offset = "0x5F9FF00", VA = "0x185FA1100")]
	[IteratorStateMachine(typeof(ECIOFLBIAPG))]
	private IEnumerator<CPLKNCELBEK> ANEGLKKCBFO(bool LPNJBDBOPPM, List<GEPPHPFEKMD> LNJDGIBCOPL, int[] NMPKKNDGNMO, Func<int, AOFPNBPNBOO> BFOCEFAOEDB, OIFIECGGDHF JALJCFDKBOC, Material OKBHOKFMMKC, List<PICEPJILIEK> ODFMCKBLCOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3D80", Offset = "0x5FA2B80", VA = "0x185FA3D80")]
	private PICEPJILIEK DECGJIMPKDP(List<GEPPHPFEKMD> LNJDGIBCOPL, int[] NMPKKNDGNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1C50", Offset = "0x5FA0A50", VA = "0x185FA1C50")]
	private DIALOMEDIJI BEFKJCDJLMC(List<GEPPHPFEKMD> LNJDGIBCOPL, int FBJIHPHAKKE, bool LPNJBDBOPPM, AOFPNBPNBOO JPKFLBLKANP, bool EHCNBMAKFPO, OIFIECGGDHF JALJCFDKBOC, Material OKBHOKFMMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9C00", Offset = "0x5FA8A00", VA = "0x185FA9C00")]
	private DIALOMEDIJI LKGCFEJOIPI(JobHandle JHJBMAMJCGN, bool PACHDNJCHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5D30", Offset = "0x5FA4B30", VA = "0x185FA5D30")]
	private void HDIICIOOHKD(SkinnedMeshRenderer AJOBBOHFCAF, Mesh HCHDFAPIGCD, List<Material> EKEAIBNIOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	private void PAMNLBOCOJK(int FBJIHPHAKKE, long GOACIFFCDAA, long GNEMPALPCEB, long MGEMOLOCEIO, long PDPJAAEKKGO, long LKBCLHEHAFF, long NNOENAJPLKB, long IKDGCBHNIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4320", Offset = "0x5FA3120", VA = "0x185FA4320")]
	[IteratorStateMachine(typeof(DAEPMILKIIK))]
	private IEnumerator<CPLKNCELBEK> DPHHMLIJAHB(JobHandle PDCBMAPDAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8C20", Offset = "0x5FA7A20", VA = "0x185FA8C20")]
	private static Material KFOIBHHOAJL(Dictionary<CHEGPCAKJBB, Material> KODALFGPGEF, Material AHMBECJECEO, EHKHJGHFGEI HFEELHHEJFK, JICPFABIFLC EMNFNNIEJLP, LBHJAFLPLDJ KDDCBMDFKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4EA0", Offset = "0x5FA3CA0", VA = "0x185FA4EA0")]
	private static EHKHJGHFGEI FLJEBIPOFIC(GEPPHPFEKMD LDKPDDBIAPE, int OHPMAAKJAOM)
	{
		return default(EHKHJGHFGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1780", Offset = "0x5FA0580", VA = "0x185FA1780")]
	private void APEPLJILCBL(int JKHHINIAGFM, Material NLKDDMHEDOF, GEPPHPFEKMD LDKPDDBIAPE, [Out] Texture2D PPCLNLFMEIM, [Out] Vector4 GDAEIJMNHBD, [Out] Texture2D KDPIPBCKMKP, [Out] Texture2D NEAJJMFFFHG, [Out] Texture2D LHBGJJHNDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FABC90", Offset = "0x5FAAA90", VA = "0x185FABC90")]
	private void OEFGJDBOLBG(int JKHHINIAGFM, Material NLKDDMHEDOF, GEPPHPFEKMD LDKPDDBIAPE, [Out] Color FIDJPCHABMM, [Out] Color LPBFFHCNKCP, [Out] Color GKDGDPEHGGF, [Out] Color PHOPJOGFPPA, [Out] Color GPPAKEABEDF, [Out] Color KCEAJODPMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9DB0", Offset = "0x5FA8BB0", VA = "0x185FA9DB0")]
	private bool LONKLPGNPPF(Material NLKDDMHEDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA47D0", Offset = "0x5FA35D0", VA = "0x185FA47D0")]
	private static Material EOIPBDOJNDG(int JKHHINIAGFM, FHIOFAPLIFK LDKPDDBIAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5FA0", Offset = "0x5FA4DA0", VA = "0x185FA5FA0")]
	private static JICPFABIFLC HLNHBHAJHOO(GEPPHPFEKMD LDKPDDBIAPE, int OHPMAAKJAOM)
	{
		return default(JICPFABIFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAB10", Offset = "0x5FA9910", VA = "0x185FAAB10")]
	private static void MJBELLOMFPL(Dictionary<string, List<CHEGPCAKJBB>> HBGDBABKNLB, GEPPHPFEKMD KGOGHCCCNOB, Material AHMBECJECEO, EHKHJGHFGEI BIHMCFPJJBL, JICPFABIFLC OIMJJCCHOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA49D0", Offset = "0x5FA37D0", VA = "0x185FA49D0")]
	private static SkinnedMeshRenderer EPFIFOJMJPH(Transform NICDPBHLFEN, Transform JMHKBLIHIDJ, SkinnedMeshRenderer[] KAIJBKEBPDP, int FBJIHPHAKKE, AOFPNBPNBOO JPKFLBLKANP, bool LPNJBDBOPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8E40", Offset = "0x5FA7C40", VA = "0x185FA8E40")]
	private void KKNFKAHACKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC4B0", Offset = "0x5FAB2B0", VA = "0x185FAC4B0")]
	private void PDBFIBADEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA9B0", Offset = "0x5FA97B0", VA = "0x185FAA9B0")]
	private static void MDOKJFHJOCG(Dictionary<CHEGPCAKJBB, Material> KODALFGPGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5FA96A0", Offset = "0x5FA84A0", VA = "0x185FA96A0")]
	private static void LBPBOILLMBA(Dictionary<Renderer, OIFIECGGDHF> ABDNJPLLGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7990", Offset = "0x5FA6790", VA = "0x185FA7990")]
	private void JBANGJMEIEK(SkinnedMeshRenderer[] KAIJBKEBPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC4C0", Offset = "0x5FAB2C0", VA = "0x185FAC4C0")]
	private void PEDPFHAIDBJ(SkinnedMeshRenderer GLCGPMOEHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FA53E0", Offset = "0x5FA41E0", VA = "0x185FA53E0")]
	private void FNNDCMAAJPE(List<KLGFKCBCBJL> OLAFEDCCBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4430", Offset = "0x5FA3230", VA = "0x185FA4430")]
	private void EDPPKEAPOII(Dictionary<string, NNOEEBAFNLF<Texture2D>> HBGDBABKNLB, bool JANMAOCNJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5FA60C0", Offset = "0x5FA4EC0", VA = "0x185FA60C0")]
	private void HOMKKOBLFLA(Dictionary<string, List<CHEGPCAKJBB>> HBGDBABKNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4670", Offset = "0x5FA3470", VA = "0x185FA4670")]
	private void EJLEPIMFGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0EA0", Offset = "0x5F9FCA0", VA = "0x185FA0EA0")]
	private void AGOKKHDBGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAE70", Offset = "0x5FA9C70", VA = "0x185FAAE70")]
	private void MPJHFOHBNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FABA10", Offset = "0x5FAA810", VA = "0x185FABA10")]
	private void NMJHKLNJPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FAADE0", Offset = "0x5FA9BE0", VA = "0x185FAADE0")]
	private void MPEGLIONMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5E50", Offset = "0x5FA4C50", VA = "0x185FA5E50")]
	private void HGJHEDPICNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FA62A0", Offset = "0x5FA50A0", VA = "0x185FA62A0")]
	private void IHDBOOKMEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3C40", Offset = "0x5FA2A40", VA = "0x185FA3C40")]
	private void CHJHJCAMJNL(bool DPODDIDDEPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1030", Offset = "0x5F9FE30", VA = "0x185FA1030")]
	private void AMCMGKEJBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4390", Offset = "0x5FA3190", VA = "0x185FA4390")]
	private void EBHFCJCJMEN(bool DPODDIDDEPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB560", Offset = "0x5FAA360", VA = "0x185FAB560")]
	private void NBKKOCKBFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9800", Offset = "0x5FA8600", VA = "0x185FA9800")]
	private void LCJBDHDGFAE(Material OKBHOKFMMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4230", Offset = "0x5FA3030", VA = "0x185FA4230")]
	private void DMAEJIEEONK(Material OKBHOKFMMKC, Color LPBFFHCNKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4140", Offset = "0x5FA2F40", VA = "0x185FA4140")]
	private void DLCIMFJDAMK(Material OKBHOKFMMKC, Color GKDGDPEHGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5C40", Offset = "0x5FA4A40", VA = "0x185FA5C40")]
	private void HACCGJFAMJJ(Material OKBHOKFMMKC, Color FIDJPCHABMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9CC0", Offset = "0x5FA8AC0", VA = "0x185FA9CC0")]
	private void LLEOLCNHNPL(Material OKBHOKFMMKC, Texture2D MJKCCMHJFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5FABBA0", Offset = "0x5FAA9A0", VA = "0x185FABBA0")]
	private void ODJNLFFECKG(Material OKBHOKFMMKC, Texture MAHMOOEEDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4CE0", Offset = "0x5FA3AE0", VA = "0x185FA4CE0")]
	private void FHIKJIEAHDP(Action<OIFIECGGDHF> BPJHFDANNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0D20", Offset = "0x5F9FB20", VA = "0x185FA0D20")]
	private void ABEEDMHNIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9340", Offset = "0x5FA8140", VA = "0x185FA9340")]
	private void LAIMKGBCIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA3C0", Offset = "0x5FA91C0", VA = "0x185FAA3C0")]
	private PICEPJILIEK MCMNBEGNGHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA010", Offset = "0x5FA8E10", VA = "0x185FAA010")]
	private void MAOGEOIDGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5050", Offset = "0x5FA3E50", VA = "0x185FA5050")]
	public void FNACBAGBFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3A00", Offset = "0x5FA2800", VA = "0x185FA3A00")]
	private void CBEHBGLIECP(Vector3 AEKKFHEKCOP, Quaternion INCJBNNECEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC610", Offset = "0x5FAB410", VA = "0x185FAC610")]
	private void PODGMNKONDB(List<GEPPHPFEKMD> DCKIDOJLGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7AD0", Offset = "0x5FA68D0", VA = "0x185FA7AD0")]
	public void JGNBGPNEPOH(GGOPBMFCMPG EGDIBMMCJBJ, bool MHLNENFGHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7FD0", Offset = "0x5FA6DD0", VA = "0x185FA7FD0")]
	public void JGNBGPNEPOH(GGOPBMFCMPG EGDIBMMCJBJ, AnchorParamsRestrictions PLPMJPKAHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x889E10", Offset = "0x888C10", VA = "0x180889E10")]
	private static void KIMLGGHPPNE(FitMeshHemisphere EAPPMPLGPDF, Transform OOOMDOLHMJH, GGOPBMFCMPG EGDIBMMCJBJ, AnchorParamsRestrictions JCOKJFMDAFB, [Out] Vector3 ABJLHEFAGHP, [Out] Quaternion NGMKKHFPKEG, [Out] GGOPBMFCMPG IBGJIIJGCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3A70", Offset = "0x5FA2870", VA = "0x185FA3A70")]
	public void CCFHKAAGEBL(Vector2 AFEPHOJCAPA, Vector3 EAAOJBPFJMN, Vector3 EHDBEAMPABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9060", Offset = "0x5FA7E60", VA = "0x185FA9060")]
	private void KMALEADMBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC580", Offset = "0x5FAB380", VA = "0x185FAC580")]
	private void PNKJCMFNJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC190", Offset = "0x5FAAF90", VA = "0x185FAC190")]
	[CompilerGenerated]
	private void OHBPCFNEAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6090", Offset = "0x5FA4E90", VA = "0x185FA6090")]
	[CompilerGenerated]
	private void HMAONIBIEHI(OIFIECGGDHF JEAMEICIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4FC0", Offset = "0x5FA3DC0", VA = "0x185FA4FC0")]
	[CompilerGenerated]
	private void FMFPHJOHKFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7AB0", Offset = "0x5FA68B0", VA = "0x185FA7AB0")]
	[CompilerGenerated]
	private void JGLACLLMKDI(OIFIECGGDHF JEAMEICIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9B70", Offset = "0x5FA8970", VA = "0x185FA9B70")]
	[CompilerGenerated]
	private void LIKPAILLDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC560", Offset = "0x5FAB360", VA = "0x185FAC560")]
	[CompilerGenerated]
	private void PFOBPGMLFHA(OIFIECGGDHF JEAMEICIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FABAE0", Offset = "0x5FAA8E0", VA = "0x185FABAE0")]
	[CompilerGenerated]
	private void NNAOPCKLEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4640", Offset = "0x5FA3440", VA = "0x185FA4640")]
	[CompilerGenerated]
	private void EHBMKEKKAOO(OIFIECGGDHF JEAMEICIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FA45B0", Offset = "0x5FA33B0", VA = "0x185FA45B0")]
	[CompilerGenerated]
	private void EEKBLPBIIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3920", Offset = "0x5FA2720", VA = "0x185FA3920")]
	[CompilerGenerated]
	private void BELNCBNIMPK(OIFIECGGDHF JEAMEICIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5B60", Offset = "0x5FA4960", VA = "0x185FA5B60")]
	[CompilerGenerated]
	private void GLNCDMJKOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FA39D0", Offset = "0x5FA27D0", VA = "0x185FA39D0")]
	[CompilerGenerated]
	private void CANMCKGDGIO(OIFIECGGDHF JEAMEICIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5FA88D0", Offset = "0x5FA76D0", VA = "0x185FA88D0")]
	[CompilerGenerated]
	private void KBMDINCJFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB9E0", Offset = "0x5FAA7E0", VA = "0x185FAB9E0")]
	[CompilerGenerated]
	private void NJOONMPBMIG(OIFIECGGDHF JEAMEICIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8650", Offset = "0x5FA7450", VA = "0x185FA8650")]
	[CompilerGenerated]
	private void JJFIAHNLAPA(KeyValuePair<string, NNOEEBAFNLF<Texture2D>> OICJCLJABGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA40B0", Offset = "0x5FA2EB0", VA = "0x185FA40B0")]
	[CompilerGenerated]
	private void DJFEEAKHDID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5FABB70", Offset = "0x5FAA970", VA = "0x185FABB70")]
	[CompilerGenerated]
	private void OBDNGLLJNNI(OIFIECGGDHF JEAMEICIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1BC0", Offset = "0x5FA09C0", VA = "0x185FA1BC0")]
	[CompilerGenerated]
	private void BCEGHMKDCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5B30", Offset = "0x5FA4930", VA = "0x185FA5B30")]
	[CompilerGenerated]
	private void GLCFMAKFMLG(OIFIECGGDHF JEAMEICIAPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OGNENPEFHEP : GILJNEKLJLL
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct IADMHPILBKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Vector2 CMKCHGPBPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public Vector2 AOJAJPFPKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Vector2 KONNIJLAKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public Vector2 HGBFNNLMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Vector2 FBKIMAMPFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Vector2 AJFOKCIEFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Vector2 JJAECLLMLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Vector2 CCDALLGMFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Vector2 DCKEHFCFBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Vector2 FHANGEOOKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector2 EENBGKFONPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector2 MJPJEJJIBHO;
	}

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly int CIBCMEHPCOC;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly int JBKCHMPCKKM;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly int KKLJOFNKLNL;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly int BKCMCDOFCBF;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly int MIKGGBKKFGF;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly int POBJOHCFLPF;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly int KFLLEMGBNFI;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly int ABGHCDGMFNG;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly int LEELDHLEIHB;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int DAIEAEHCODL;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int DLJLOAJBIKO;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int FANMEFHFPKE;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int NEJIMHCEENF;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int LDLNJFDHEOG;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int LFFCCKDLGMP;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int GFBMJLPCJEP;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int JAJIMJCFLNC;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int PNNMKEAOAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Transform LOHODNKBLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Transform FECBPNPNDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private Transform BFMNLOKJBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private Transform CDKCIPGBNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Transform AOEPALJBCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private Transform DOJPEOCLGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Transform NCHCBCCFPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private LIJEABBNGPD KPMAOFHLHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private MaterialPropertyBlock MNDIHLBKGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private SkinnedMeshRenderer[] NJKLOMDPCIL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private MaterialPropertyBlock LMCPIPHIPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3AC0", Offset = "0x5FB28C0", VA = "0x185FB3AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3B40", Offset = "0x5FB2940", VA = "0x185FB3B40", Slot = "6")]
	public void KCJBJGBIMAI(LIJEABBNGPD EJDIMMKPPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3C70", Offset = "0x5FB2A70", VA = "0x185FB3C70", Slot = "7")]
	public void LKNPFBBLJFE(ANGAGDGCHHO JJOPHPBKPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3CA0", Offset = "0x5FB2AA0", VA = "0x185FB3CA0", Slot = "4")]
	public void MPAJMMJILHH(DCLFKHDKLIB AIFBDNDFJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2E20", Offset = "0x5FB1C20", VA = "0x185FB2E20", Slot = "5")]
	public void AFLMKIJKFIB(NFEPJJPFAOJ JJOPHPBKPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB40D0", Offset = "0x5FB2ED0", VA = "0x185FB40D0")]
	private void NGAFDCKHGOK(NFEPJJPFAOJ LPPEPNPBEDN, IADMHPILBKA AGICHOJAKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB39E0", Offset = "0x5FB27E0", VA = "0x185FB39E0")]
	private void IAOONADLJFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB49D0", Offset = "0x5FB37D0", VA = "0x185FB49D0")]
	public OGNENPEFHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3960", Offset = "0x5FB2760", VA = "0x185FB3960")]
	[CompilerGenerated]
	private Vector4 ALGEPHDNMDN(Vector2 AJFNKFFNDBD, Vector2 BJOKGACKCGO)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3C00", Offset = "0x5FB2A00", VA = "0x185FB3C00")]
	[CompilerGenerated]
	private Vector4 KPFIKNJBKGG(float PJLFCBOFNOM, float JBEKDLBOIEB, float FJDAFLEMDMG, float IFBECJDEKBN)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class OIFIECGGDHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private MaterialPropertyBlock MFAJENOEGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Color? NOABCDDMAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public Color? DNPDJOMJDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Color? PNMOELFIBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Color? NOMCFDFIPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color FCLLFKOIIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color FNJEDELGKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color PFGEPIBJKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Texture2D MMEEJPEPCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Texture2D IOICKKOJMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private Dictionary<CHEGPCAKJBB, int> MEIJPPJOLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EHKHJGHFGEI[] LHBKNCODOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private JICPFABIFLC[] GKOLMCKLLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Vector4[] HIIHNBHPNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public Vector4[] JOCAPOHMHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Vector4[] ABCNDHMKHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Vector4[] PJHALIAPLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] DLAHDHDLMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] OCILOKCJHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private List<Texture2D> JFIJDKHLJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Vector4[] LOABLANJJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private List<Texture2D> GKJCFEPHDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private float[] LOKGLNILCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Vector4[] AJCIJJFAOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float[] ENCLGKCGGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public float[] HLHFOEFJKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private List<Texture2D> GDAKAADMJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private float[] LLHAEFILJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private List<Texture2D> KAGLBFLKLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private Vector4[] OLAADCPOMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private float[] NOFGDJEBENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Vector4[] MHBGHIPEFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public float[] COJHOFCHHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Texture2DArray DEEJHLMIMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public Texture2DArray ELJCLMEAAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public Texture2DArray LADDHGCCECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Texture2DArray CAAAFKCADDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private bool GMFNJKKGEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int MAAKPNLHIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private Vector2? IPCLMABIPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private TextureFormat KLFNOJJIDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private Vector2? LENHHCGKGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private TextureFormat JDNDFMKOFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private Vector2? LBNFBBFMOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private TextureFormat EAHDBOPKEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private Vector2? CMIJJICEKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private TextureFormat JIEFIEOONDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private bool JGKIPPNJKKP;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int GMFJMMEAGGM;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int HHKKGCDJBMD;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int NPAEFBIGANK;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int ECPBDDJNHFH;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int NFMHOPMGKHK;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int HEJIKJFPBEI;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int GDEAFIIAGGF;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int NOBNIHKGAJE;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int IFGOFIILLDB;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int FLMMJINAALJ;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int MLEPIBDNBGL;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int LJPHHIFNLGL;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int JNGEEFNOMHA;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int GGJFEFFOLPM;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int OMFLLDEDIGM;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int MLOJMGCCOON;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int LCEJFFJAIJE;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int HNFOAEKEFDN;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int GHNCIPINICJ;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int NCLNKMDPCDI;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD780", Offset = "0x5FBC580", VA = "0x185FBD780")]
	private OIFIECGGDHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDC70", Offset = "0x5FBCA70", VA = "0x185FBDC70")]
	public OIFIECGGDHF(Color KEFGMIMFAJH, Color LONOOBEBCKM, Color OMPJAALIEGJ, Color? JIGHHILDPGF, Color? AKAEPLBCPKG, Color? DDODDKOMFKE, Texture2D PGMNHEGDFAE, Texture2D DBGEBOGLGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC400", Offset = "0x5FBB200", VA = "0x185FBC400")]
	internal int JDNGCEKAOID(Material PEGDODOCCGL, EHKHJGHFGEI HFEELHHEJFK, JICPFABIFLC EMNFNNIEJLP, LBHJAFLPLDJ KDDCBMDFKKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC4F0", Offset = "0x5FBB2F0", VA = "0x185FBC4F0")]
	private int JDNGCEKAOID(CHEGPCAKJBB ONOECNHBCDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC820", Offset = "0x5FBB620", VA = "0x185FBC820")]
	internal int MPGAMHMEIIM(Material PEGDODOCCGL, Color FIDJPCHABMM, Color LPBFFHCNKCP, Color GKDGDPEHGGF, Color PHOPJOGFPPA, Color GPPAKEABEDF, Texture2D IPEEPCBNFCI, Vector4 OFLHMLCLIHO, Texture2D HHIDEEJFDLP, Vector4 KNKFPGKCDEE, float NAJGALIGBNF, float NMLAOHPCHNE, Texture2D EDFFKMEBICG, Vector4 PHEDDECEKCE, float GNJLHCNPMHD, Texture2D LJIKDCHPGEK, Color KCEAJODPMBG, Vector4 NFKGNDKJDDL, EHKHJGHFGEI HFEELHHEJFK, JICPFABIFLC EMNFNNIEJLP, LBHJAFLPLDJ KDDCBMDFKKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBE50", Offset = "0x5FBAC50", VA = "0x185FBBE50")]
	private void BPMANHPNPNA(List<Texture2D> JFIJDKHLJFB, [Out] Texture2DArray OPIDLMJCHIC, [Out] Texture2DArray BPLJEHJGIPN, [Out] Texture2DArray DNEODBOPGHJ, [Out] Texture2DArray MKNBNDDNPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC580", Offset = "0x5FBB380", VA = "0x185FBC580")]
	public void JLBFEHLHKBE(Shader IAMKDDPFFLL, Renderer FNMHNENOEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB100", Offset = "0x5FB9F00", VA = "0x185FBB100")]
	private void BHKPJMEKNJO(Shader IAMKDDPFFLL, Renderer FNMHNENOEME, int GCCCPOJIFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC050", Offset = "0x5FBAE50", VA = "0x185FBC050")]
	private Color FGNFLOOAHEO(Color EPMOCGBNOJM, EHKHJGHFGEI BIHMCFPJJBL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC6D0", Offset = "0x5FBB4D0", VA = "0x185FBC6D0")]
	private Color LCMJOONBGGB(Color NPHOGOEMJCD, EHKHJGHFGEI BIHMCFPJJBL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC250", Offset = "0x5FBB050", VA = "0x185FBC250")]
	private bool GKKDIGENFKB(Texture2D MDMOHAGMCCI, JICPFABIFLC OIMJJCCHOJO, [Out] Texture2D HNKIKGFDPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC350", Offset = "0x5FBB150", VA = "0x185FBC350")]
	private void HIJECLFDDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC010", Offset = "0x5FBAE10", VA = "0x185FBC010", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private ECAADHJGDBJ? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public GMFGMGAOABD CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5FB5900", Offset = "0x5FB4700", VA = "0x185FB5900")]
			get
			{
				return default(GMFGMGAOABD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public ECAADHJGDBJ MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x5FB5950", Offset = "0x5FB4750", VA = "0x185FB5950")]
			get
			{
				return default(ECAADHJGDBJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7BB8A0", Offset = "0x7BA6A0", VA = "0x1807BB8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7BFB90", Offset = "0x7BE990", VA = "0x1807BFB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5750", Offset = "0x5FB4550", VA = "0x185FB5750")]
		public Material[] NLEPHDOIAFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5590", Offset = "0x5FB4390", VA = "0x185FB5590")]
		public static void GAKKFEHPFPG(AvatarItemMaterial NFDLHOMNCGH, Material NLKDDMHEDOF, int JKHHINIAGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5830", Offset = "0x5FB4630", VA = "0x185FB5830")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[HAGPAHMIPMA]
public struct FGBCNALJPKJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	public DGOHOOKEJOI BIHLPAECIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	public int GFKOLPEHCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public KEDCMCCKCGM FLOBOPPFJGG;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8290", Offset = "0x5FB7090", VA = "0x185FB8290", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[HAGPAHMIPMA]
[NativeContainer]
public struct KEDCMCCKCGM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public NativeArray<Vector3> KHEKBMGHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public NativeArray<Vector3> IMGHEOEJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Vector4> JIFECIOHLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<Vector2> LAFFDHEBNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector2> GDHODDFANMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector2> PGHHPKMDPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector2> JCPMGJOKDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Color> OPELOEONPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<int> HBPIONJOGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<int> CHALCKGFGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private NativeArray<int> IBGGMGJAGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private NativeArray<int> AEKBEIFPBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<int> AEHALLLPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<int> LJLKAINOJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<int> CDIKECLMJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<BoneWeight> LEMBKLLACIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private NativeArray<int> JCKJBGDNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private bool CFDGKBDLFFK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int JMGMFBAGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9E40", Offset = "0x5FB8C40", VA = "0x185FB9E40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9D80", Offset = "0x5FB8B80", VA = "0x185FB9D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int PJIHJABKLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9BC0", Offset = "0x5FB89C0", VA = "0x185FB9BC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA000", Offset = "0x5FB8E00", VA = "0x185FBA000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JKMCFCBLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9F50", Offset = "0x5FB8D50", VA = "0x185FB9F50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9F20", Offset = "0x5FB8D20", VA = "0x185FB9F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA410", Offset = "0x5FB9210", VA = "0x185FBA410")]
	public KEDCMCCKCGM(int LAGECHBNBCA, int PIKGOJMIHLC, int EBIENGAMOBF, int HJLFJCOEKCD, Allocator ALDDPOOJFGI, int PAPJEHOABGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9F90", Offset = "0x5FB8D90", VA = "0x185FB9F90")]
	public void OAMKHCBECKJ(int OHINPGIGDNE, Vector3 FJKGEGOOFKM, Vector3 GJCLFAIOADJ, Vector4 BHBDNAGLKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5FB99D0", Offset = "0x5FB87D0", VA = "0x185FB99D0")]
	public void CAAJNJMAGPH(int OHINPGIGDNE, BoneWeight MKHBEKMCNCD, NativeSlice<byte> DHJMGJPIHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9F30", Offset = "0x5FB8D30", VA = "0x185FB9F30")]
	public Color INBOKMLPNDL(int OHINPGIGDNE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA3F0", Offset = "0x5FB91F0", VA = "0x185FBA3F0")]
	public void PFNOBBPLMFF(int OHINPGIGDNE, Color MEJOABMJHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9B70", Offset = "0x5FB8970", VA = "0x185FB9B70")]
	public void DCECFMBBMNM(byte ONFJNFOLIFK, int OHINPGIGDNE, Vector2 IHBCCKCCNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5FB99C0", Offset = "0x5FB87C0", VA = "0x185FB99C0")]
	public void BMFENKEMLPJ(int OHINPGIGDNE, int KHMFILDCBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9F60", Offset = "0x5FB8D60", VA = "0x185FB9F60")]
	public bool NIKHAOJLLBK(int ONFJNFOLIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9E50", Offset = "0x5FB8C50", VA = "0x185FB9E50")]
	public void ICCBMOIKLPI(int MBAAGMDFGNI, int LBJEFCOBKGF, int AKCMMEDPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9D90", Offset = "0x5FB8B90", VA = "0x185FB9D90")]
	public int[] HEBAOGIBMKA(int MBAAGMDFGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA360", Offset = "0x5FB9160", VA = "0x185FBA360")]
	private NativeSlice<int> PBPKIJPPKGD(int MBAAGMDFGNI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9BD0", Offset = "0x5FB89D0", VA = "0x185FB9BD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA010", Offset = "0x5FB8E10", VA = "0x185FBA010")]
	public Mesh OKPPMAMFBAB([Optional] string IHJPDIMDCBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
[HAGPAHMIPMA]
[NativeContainer]
public struct DGOHOOKEJOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector3> KHEKBMGHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector3> IMGHEOEJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Vector4> JIFECIOHLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector2> LAFFDHEBNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector2> GDHODDFANMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector2> PGHHPKMDPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector2> JCPMGJOKDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Color> OPELOEONPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> FBMBJOHPPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> BHMAKGFFCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<int> AFMCEOBMMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<int> OPNMPMBAHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> EEPDBLHAAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<BoneWeight> MADBBFFMIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private NativeArray<Matrix4x4> MKGNJEGGLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<int> IDKFIIDAEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private NativeArray<byte> NJDILAHADAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private NativeArray<int> AINCOGPCMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private NativeArray<int> LHAEKHEFHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<sbyte> GDGJBMDFMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<byte> ADMLNJABEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> IADHNMKNMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private bool CFDGKBDLFFK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int MDDBBPCCKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0020", Offset = "0x1D9EE20", VA = "0x181DA0020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int HJFFLPFPOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xE64F30", Offset = "0xE63D30", VA = "0x180E64F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int LOKBMIOMDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5FB69E0", Offset = "0x5FB57E0", VA = "0x185FB69E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int KINIINKAPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6240", Offset = "0x5FB5040", VA = "0x185FB6240")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6990", Offset = "0x5FB5790", VA = "0x185FB6990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JMGMFBAGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6490", Offset = "0x5FB5290", VA = "0x185FB6490")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6480", Offset = "0x5FB5280", VA = "0x185FB6480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MHMFNGHNMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5FB69B0", Offset = "0x5FB57B0", VA = "0x185FB69B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6A10", Offset = "0x5FB5810", VA = "0x185FB6A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public JDMGGIIDOEO COMHKODOJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6230", Offset = "0x5FB5030", VA = "0x185FB6230")]
		get
		{
			return default(JDMGGIIDOEO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5FB69C0", Offset = "0x5FB57C0", VA = "0x185FB69C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public byte CNIAOCNDADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5FB69A0", Offset = "0x5FB57A0", VA = "0x185FB69A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB69D0", Offset = "0x5FB57D0", VA = "0x185FB69D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IDBNHHLEJCC GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB64A0", Offset = "0x5FB52A0", VA = "0x185FB64A0")]
		get
		{
			return default(IDBNHHLEJCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6A20", Offset = "0x5FB5820", VA = "0x185FB6A20")]
	public DGOHOOKEJOI(IList<Mesh> MMCCNAGPOCD, IList<Matrix4x4> GOPHJIJKKKI, byte IGGJBIHFPDA, IList<byte[]> JGEEHAPOLFA, IList<int> JKINBAPCNGF, IList<bool> IIEOLPEIJBO, IList<int> BJMFNMNJKME, IList<int> HGIMMJDLDBO, Allocator ALDDPOOJFGI, JDMGGIIDOEO CAPNAGJDMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6160", Offset = "0x5FB4F60", VA = "0x185FB6160")]
	public KEDCMCCKCGM ADPDILONPCB(Allocator ALDDPOOJFGI)
	{
		return default(KEDCMCCKCGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6250", Offset = "0x5FB5050", VA = "0x185FB6250", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HAGPAHMIPMA]
public class NILFLDLMNIJ : BBJDKMBOJEA
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB020", Offset = "0x5FB9E20", VA = "0x185FBB020")]
	public DGOHOOKEJOI FBIBDIMPNIN()
	{
		return default(DGOHOOKEJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB0F0", Offset = "0x5FB9EF0", VA = "0x185FBB0F0")]
	public NILFLDLMNIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct IDBNHHLEJCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeSlice<Vector3> KHEKBMGHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeSlice<Vector3> IMGHEOEJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeSlice<Vector4> JIFECIOHLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeSlice<Vector2> LAFFDHEBNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeSlice<Vector2> GDHODDFANMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<Vector2> PGHHPKMDPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector2> JCPMGJOKDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Color> OPELOEONPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<int> KFFGFKJNCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<int> OPNMPMBAHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<BoneWeight> MADBBFFMIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<byte> HEIHLDEMCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public int FFGMEGKLKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public Matrix4x4 EDPJPDDCLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int EKEGEKNAOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<byte> DHJMGJPIHFK;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal readonly struct CHEGPCAKJBB : IEquatable<CHEGPCAKJBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	internal readonly Material IGFAMDADIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	internal readonly EHKHJGHFGEI IIPGNHFPCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	internal readonly JICPFABIFLC BPCKLMHDFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	internal readonly LBHJAFLPLDJ DEGJGBIKIIN;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8A0F90", Offset = "0x89FD90", VA = "0x1808A0F90")]
	public CHEGPCAKJBB(Material NLKDDMHEDOF, EHKHJGHFGEI HFEELHHEJFK, JICPFABIFLC EMNFNNIEJLP, LBHJAFLPLDJ KDDCBMDFKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5B90", Offset = "0x5FB4990", VA = "0x185FB5B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8A0CF0", Offset = "0x89FAF0", VA = "0x1808A0CF0", Slot = "4")]
	public bool Equals(CHEGPCAKJBB EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5A10", Offset = "0x5FB4810", VA = "0x185FB5A10", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5AF0", Offset = "0x5FB48F0", VA = "0x185FB5AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LNMEDIJKBCN : HGLCHBFMHNO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private FHLIGNLBNHI MECEPHJOMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private LPKACPIFACJ BJLGCICNDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private IRecRoomQualityConfigProvider PNMCFGJJCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private bool CFDGKBDLFFK;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAF20", Offset = "0x5FB9D20", VA = "0x185FBAF20")]
	[HBAMLEIOGOF(BHCECOANHAK.GameOnly)]
	private static void MFEIOALDEKM(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5320BC0", Offset = "0x531F9C0", VA = "0x185320BC0")]
	[Preserve]
	public LNMEDIJKBCN([BMAJFBAIDDE(null)] LPKACPIFACJ NCPDBDJOBPN, [BMAJFBAIDDE(null)] FHLIGNLBNHI HDFEKLBJAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAEB0", Offset = "0x5FB9CB0", VA = "0x185FBAEB0")]
	private void JADPHCMHGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAE50", Offset = "0x5FB9C50", VA = "0x185FBAE50", Slot = "4")]
	public void GCJMCOBHGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA990", Offset = "0x5FB9790", VA = "0x185FBA990", Slot = "5")]
	public NNOEEBAFNLF<Texture2D> EPKIAMMCONG(FNCIPLMHGGI LPHFGIIDDAJ, [Optional] IEJPOIEPOPD JCKJBGDNIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA850", Offset = "0x5FB9650", VA = "0x185FBA850")]
	private uint BCFDKGOMOOL(FNCIPLMHGGI LPHFGIIDDAJ, IEJPOIEPOPD JCKJBGDNIAO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface BGOMNFDPFDB
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCKNHKPHCBG(Mesh HCHDFAPIGCD, Matrix4x4 ABOHGNCLMJC, byte[] DHJMGJPIHFK, bool ICOIKOGKHEN = false, LEBGJKDCBPN.MDJOAGODMFF MOFICGFDFKG = (LEBGJKDCBPN.MDJOAGODMFF)0);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEHMHGDBMID(Allocator ALDDPOOJFGI, JDMGGIIDOEO CAPNAGJDMFN, byte IGGJBIHFPDA, [Optional] IList<int> BJMFNMNJKME, [Optional] IList<int> CMDDCEEOLLD);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct EIIOLAOFDHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public readonly GameObject PGLCCMENMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly AvatarItemMaterial JCHPAJBHKGC;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8F0EC0", Offset = "0x8EFCC0", VA = "0x1808F0EC0")]
	public EIIOLAOFDHB(GameObject PGLCCMENMND, AvatarItemMaterial JCHPAJBHKGC)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5FBDD30", Offset = "0x5FBCB30", VA = "0x185FBDD30")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct DFEKOIKIMAJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public AsyncTaskMethodBuilder<CLPHDBNCOPI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			private TaskAwaiter<CLPHDBNCOPI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x5FB5DB0", Offset = "0x5FB4BB0", VA = "0x185FB5DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x5FB60F0", Offset = "0x5FB4EF0", VA = "0x185FB60F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private Dictionary<IHGNPHBMLMN, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private Dictionary<IHGNPHBMLMN, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private Dictionary<IHGNPHBMLMN, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private Dictionary<IHGNPHBMLMN, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private readonly Dictionary<IHGNPHBMLMN, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private CLPHDBNCOPI _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x5FB9990", Offset = "0x5FB8790", VA = "0x185FB9990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9790", Offset = "0x5FB8590", VA = "0x185FB9790")]
		public CLPHDBNCOPI OAFMBPOKPCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5FB92B0", Offset = "0x5FB80B0", VA = "0x185FB92B0")]
		[AsyncStateMachine(typeof(DFEKOIKIMAJ))]
		public Task<CLPHDBNCOPI> HPDPOPIPHND(int DCOILGGDJJA, int KPIDANOACAE, int BDHEHEJCNFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB90E0", Offset = "0x5FB7EE0", VA = "0x185FB90E0")]
		public NoseFaceOption ADMJGGLLLJL(int HLFKCAGGNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB93E0", Offset = "0x5FB81E0", VA = "0x185FB93E0")]
		public SelectableFaceOption IBMJBBIPBOM(FaceFeatureType MHFPPIGHMFA, IHGNPHBMLMN NIKJDCPDKMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9230", Offset = "0x5FB8030", VA = "0x185FB9230")]
		public int HNAIFCANDJN(IHGNPHBMLMN NIKJDCPDKMO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9560", Offset = "0x5FB8360", VA = "0x185FB9560")]
		private void LOKHABHBFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2738050", Offset = "0x2736E50", VA = "0x182738050")]
		private void JOJMKOKMGGI<T>(IDictionary<IHGNPHBMLMN, T> GLAIHHBGMMC, IReadOnlyList<T> KAOBIPHEFCI) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9180", Offset = "0x5FB7F80", VA = "0x185FB9180")]
		public IHGNPHBMLMN EMKACNJDOMM(FaceFeatureType MHFPPIGHMFA)
		{
			return default(IHGNPHBMLMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5FB97E0", Offset = "0x5FB85E0", VA = "0x185FB97E0")]
		public IHGNPHBMLMN OFGPGNHHFHH(FaceFeatureType MHFPPIGHMFA)
		{
			return default(IHGNPHBMLMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9900", Offset = "0x5FB8700", VA = "0x185FB9900")]
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
