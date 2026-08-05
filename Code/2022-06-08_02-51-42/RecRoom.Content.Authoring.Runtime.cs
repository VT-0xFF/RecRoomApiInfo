using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Core.Platforms;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum GIAIBECEAHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private GIAIBECEAHF bobAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private float scaleBobAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private float scaleBobSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private bool inWorldSpace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float JJCNHLKHKNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 LANPHBKBNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4C14020", Offset = "0x4C13020", VA = "0x184C14020")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x792870", Offset = "0x791870", VA = "0x180792870")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4C141F0", Offset = "0x4C131F0", VA = "0x184C141F0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4C14350", Offset = "0x4C13350", VA = "0x184C14350")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65CE40", Offset = "0x65BE40", VA = "0x18065CE40")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, PEAJKFNPBEF
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string KGNPBGAOIAD = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string CEKFOKPAIHB = "_MainColor";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[Tooltip("List of Renderers to increase color alpha")]
	private List<Renderer> imposterRenderers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Range(0f, 1f)]
	private float imposterAlpha;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static List<Material> IFDJFGFODCM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> DPAJFBNOGJC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "4")]
	public void PrepareImposter(BAGDEAMBINE OLMBEJDJKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C15330", Offset = "0x4C14330", VA = "0x184C15330")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct BHJDOLHKFMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum BNAHDOMOJNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		CollapseSubMeshes,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		CollapseToUniqueMaterials,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		MergeAll
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OLJMCKLOIKC : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public BHJDOLHKFMA ACIHDBMMFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int IMDEHHPLFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CMMNEFMGLJM NDHOPEHNMBC;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4C16130", Offset = "0x4C15130", VA = "0x184C16130", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct KBLEHGAJLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> CJKCMACFGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> AEPOFLKAFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> FBKIDAKIOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> DMKJPPMAHAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> DOPHPMEFJLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> CKEMDHGENPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> PBIFPEDLGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> MPDGCPNJPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> GIJODLHDJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> JLLHFFIOBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> MAAIIMAIHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> FLEHPHHHJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> JFPHBIJPFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> FGPPPCLDOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> PDDOAANFFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int CBPAEMHFLPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 BKOPHNOMEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool BJJACEOCMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int HNFMFIOLGIK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int LBAHGNKCPAF = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int FELICCHDMBB = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> CJKCMACFGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> DHOOHBNALLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> AEPOFLKAFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> FBKIDAKIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> DMKJPPMAHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> DOPHPMEFJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> CKEMDHGENPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> PBIFPEDLGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> MPDGCPNJPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> GIJODLHDJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> FGPPPCLDOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> INKGKEIODJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> HGMOCLNPCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> JLLHFFIOBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> NKOONEJFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> MAAIIMAIHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> GGNMIOCIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> GANDLOJPMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> LCMHDDNNNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> PAFPGLCODJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> AOIHHLKFOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> DJHGAFGINNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> BIHDKONKOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> MPNHJJHKCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> OMIKBMEDNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> EJNLPBPDMFI;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int LLIGINPDBCF = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int PDBPDFIOHDE = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int OLJENKHCNHG = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int HKJJMNNHCFO = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> MJNOGLJAIGB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CFBPGLGBPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4C116B0", Offset = "0x4C106B0", VA = "0x184C116B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4C11940", Offset = "0x4C10940", VA = "0x184C11940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LMHNJENJGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4C118F0", Offset = "0x4C108F0", VA = "0x184C118F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4C118E0", Offset = "0x4C108E0", VA = "0x184C118E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NHOIAHCNILE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4C11920", Offset = "0x4C10920", VA = "0x184C11920")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4C11900", Offset = "0x4C10900", VA = "0x184C11900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BNAHDOMOJNL GBKCFBBGMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4C11930", Offset = "0x4C10930", VA = "0x184C11930")]
		get
		{
			return default(BNAHDOMOJNL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4C11910", Offset = "0x4C10910", VA = "0x184C11910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private KBLEHGAJLPF PDOIHJPOGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4C11950", Offset = "0x4C10950", VA = "0x184C11950")]
		get
		{
			return default(KBLEHGAJLPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C11F60", Offset = "0x4C10F60", VA = "0x184C11F60")]
	public BHJDOLHKFMA(IList<Mesh> IBFHAFODDBN, IList<int> FMMBNEKBFAA, IList<int> CDDDLKLFLLO, IList<int[]> CEHBBLDBBCN, IList<Matrix4x4> OPKFHKPNENH, IList<bool> GOICNNMKGKB, IList<int> CHGEACNCKDH, Allocator NAFOEFCFEGC, BNAHDOMOJNL KLPOGPACEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C11540", Offset = "0x4C10540", VA = "0x184C11540")]
	public CMMNEFMGLJM CAPMOAONJEJ(int KJMKCLDHMHO, Allocator NAFOEFCFEGC)
	{
		return default(CMMNEFMGLJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4C116C0", Offset = "0x4C106C0", VA = "0x184C116C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct CMMNEFMGLJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> CJKCMACFGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> AEPOFLKAFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> FBKIDAKIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> DMKJPPMAHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> DOPHPMEFJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> CKEMDHGENPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> PBIFPEDLGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> MPDGCPNJPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> GIJODLHDJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> JLLHFFIOBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> MAAIIMAIHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> FLEHPHHHJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> JFPHBIJPFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> MJNOGLJAIGB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JCNNLPOLIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4C14780", Offset = "0x4C13780", VA = "0x184C14780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4C14360", Offset = "0x4C13360", VA = "0x184C14360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4C14930", Offset = "0x4C13930", VA = "0x184C14930")]
	public CMMNEFMGLJM(int JGEHICFDJJJ, int OKDBHJFLMPD, int LADIDCPMBEI, int KJMKCLDHMHO, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4C149E0", Offset = "0x4C139E0", VA = "0x184C149E0")]
	public CMMNEFMGLJM(int JGEHICFDJJJ, int OKDBHJFLMPD, int LADIDCPMBEI, int KJMKCLDHMHO, Allocator NAFOEFCFEGC, bool[] AOOIKGMMNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4C14790", Offset = "0x4C13790", VA = "0x184C14790")]
	public void IKMALMOOFFI(int GCOKGMIJMDA, int JNMGKKFIPGA, int GFKNIIIDANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4C14870", Offset = "0x4C13870", VA = "0x184C14870")]
	public int[] KMBELDKFMNL(int GCOKGMIJMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4C14370", Offset = "0x4C13370", VA = "0x184C14370")]
	private NativeSlice<int> BMFPFJBBBIL(int GCOKGMIJMDA)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4C14660", Offset = "0x4C13660", VA = "0x184C14660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4C14410", Offset = "0x4C13410", VA = "0x184C14410")]
	public Mesh COHMMDJFHHC([Optional] string DADDPEBIBJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MHKCDONPLAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> IFCLPFLINEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> EGHLBHJNAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> AGDGBBJACOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> ELKKLAEGPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> ENFPEPCJGMM;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4C15E90", Offset = "0x4C14E90", VA = "0x184C15E90")]
	public void OOKENNJAKFD(Mesh ACEMLDCDLCF, int[] JHBDMAHMCIK, Matrix4x4 CCNNEBKCGJL, bool GOICNNMKGKB = false, int PELBDPHBAJC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4C15D60", Offset = "0x4C14D60", VA = "0x184C15D60")]
	public BHJDOLHKFMA DFAIEKFOPCI(Allocator NAFOEFCFEGC, BHJDOLHKFMA.BNAHDOMOJNL KLPOGPACEAH, [Optional] IList<int> CDDDLKLFLLO, [Optional] IList<int> NJBEGEHAMEJ)
	{
		return default(BHJDOLHKFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4C15E10", Offset = "0x4C14E10", VA = "0x184C15E10")]
	private void NODPDNEGFJH(Mesh ACEMLDCDLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4C16010", Offset = "0x4C15010", VA = "0x184C16010")]
	public MHKCDONPLAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	private GAOFGCKNOIG playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GAOFGCKNOIG EEBEOOMOIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5BBD70", Offset = "0x5BAD70", VA = "0x1805BBD70")]
		get
		{
			return default(GAOFGCKNOIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2072560", Offset = "0x2071560", VA = "0x182072560")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IFAGBGKJCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4C18A50", Offset = "0x4C17A50", VA = "0x184C18A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CMLNHHLKADJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DJCEMIGFBIG FDAGIOLHGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<DJCEMIGFBIG> HFANPDCNKMP;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFCBPAIEJEG();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum DJCEMIGFBIG
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Count
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, PEAJKFNPBEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int BMLHLIGCFFO;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4C15470", Offset = "0x4C14470", VA = "0x184C15470")]
		private void NGIONOJNKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4C153A0", Offset = "0x4C143A0", VA = "0x184C153A0")]
		private void BBLKJFODAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4C15620", Offset = "0x4C14620", VA = "0x184C15620")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4C155B0", Offset = "0x4C145B0", VA = "0x184C155B0", Slot = "4")]
		public void PrepareImposter(BAGDEAMBINE OLMBEJDJKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public InstanceColor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GAOFGCKNOIG
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	HEAD_AND_BODY
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private bool EMDBJGPOKDD;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override HMMCLDDIAGA JKLPNHMOMGP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5924C0", Offset = "0x5914C0", VA = "0x1805924C0", Slot = "4")]
			get
			{
				return default(HMMCLDDIAGA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4C14DC0", Offset = "0x4C13DC0", VA = "0x184C14DC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4C14E40", Offset = "0x4C13E40", VA = "0x184C14E40")]
		private void GOFBIPHMBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4C15220", Offset = "0x4C14220", VA = "0x184C15220")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4C15100", Offset = "0x4C14100", VA = "0x184C15100")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4C15000", Offset = "0x4C14000", VA = "0x184C15000")]
		private void LNEGGKABFBH(DJCEMIGFBIG KLFBDNHGBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4C150F0", Offset = "0x4C140F0", VA = "0x184C150F0", Slot = "8")]
		protected override bool MMHCDGJIFGA(bool DNPJEBLIDPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4C14DD0", Offset = "0x4C13DD0", VA = "0x184C14DD0", Slot = "9")]
		protected override void BDAHGMAMFCN(bool NLDPPCDDMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4C15250", Offset = "0x4C14250", VA = "0x184C15250")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[PAOKLKEFIEK(ELHMLMEGENM.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool IHGFNDFDKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int FPELDDLKDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool BBOEOAGJGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool JILMJDPKJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private float FCFHKCHFBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private float LDKGDLDCPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float GCKACLHIEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private float POIBLHBNNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float MCDEGEBDEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private float PNLOJHNMOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private ParticleSystem.MainModule GHAMLGNLFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ParticleSystem.TrailModule JLNPNDFIGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ParticleSystem.EmissionModule MNGFMCCBIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ParticleSystem.CollisionModule GOPKPPBAGGJ;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4C18140", Offset = "0x4C17140", VA = "0x184C18140")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4C17DC0", Offset = "0x4C16DC0", VA = "0x184C17DC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4C17B30", Offset = "0x4C16B30", VA = "0x184C17B30")]
		private void LNEGGKABFBH(DJCEMIGFBIG KLFBDNHGBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4C17170", Offset = "0x4C16170", VA = "0x184C17170")]
		private void KAIDACCNMAD(IRecRoomQualityConfigProvider NICFEKBJPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4C17EE0", Offset = "0x4C16EE0", VA = "0x184C17EE0")]
		private void POAEPLIFDPD(OverrideSettings OFLFIEOGBEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4C16EB0", Offset = "0x4C15EB0", VA = "0x184C16EB0")]
		private void EJHDELIDHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4C17C00", Offset = "0x4C16C00", VA = "0x184C17C00")]
		private void OMJBANBGOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4C17060", Offset = "0x4C16060", VA = "0x184C17060")]
		private void IDNCMJNKNAA(ParticleSystem.MinMaxCurve KMBAKLCNKMK, out float HOMEKKGPDMH, out float KIKLHKEBBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4C16DA0", Offset = "0x4C15DA0", VA = "0x184C16DA0")]
		private ParticleSystem.MinMaxCurve CNMHDOBALNL(ParticleSystem.MinMaxCurve KMBAKLCNKMK, float HOMEKKGPDMH, float KIKLHKEBBDG)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override HMMCLDDIAGA JKLPNHMOMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5924C0", Offset = "0x5914C0", VA = "0x1805924C0", Slot = "4")]
			get
			{
				return default(HMMCLDDIAGA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T ICPBIPOIINM(IRecRoomQualityConfigProvider BKNKBCIBHGO);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x24713D0", Offset = "0x24703D0", VA = "0x1824713D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2471C10", Offset = "0x2470C10", VA = "0x182471C10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2471980", Offset = "0x2470980", VA = "0x182471980")]
		private void LNEGGKABFBH(DJCEMIGFBIG KLFBDNHGBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2471890", Offset = "0x2470890", VA = "0x182471890")]
		private void IFBJFEJCJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2471670", Offset = "0x2470670", VA = "0x182471670", Slot = "9")]
		protected override void BDAHGMAMFCN(bool NLDPPCDDMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x14122F0", Offset = "0x14112F0", VA = "0x1814122F0")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum FPEIBEAADNF
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private FPEIBEAADNF behavior;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4C18330", Offset = "0x4C17330", VA = "0x184C18330", Slot = "10")]
		protected override bool ICPBIPOIINM(IRecRoomQualityConfigProvider BKNKBCIBHGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4C18380", Offset = "0x4C17380", VA = "0x184C18380", Slot = "8")]
		protected override bool MMHCDGJIFGA(bool DNPJEBLIDPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4C183A0", Offset = "0x4C173A0", VA = "0x184C183A0")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private enum HDOMJDEPAMF
		{
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private HDOMJDEPAMF behavior;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4C183E0", Offset = "0x4C173E0", VA = "0x184C183E0", Slot = "10")]
		protected override bool ICPBIPOIINM(IRecRoomQualityConfigProvider BKNKBCIBHGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4C18380", Offset = "0x4C17380", VA = "0x184C18380", Slot = "8")]
		protected override bool MMHCDGJIFGA(bool DNPJEBLIDPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4C18430", Offset = "0x4C17430", VA = "0x184C18430")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private enum HLDBJCNIEEO
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private HLDBJCNIEEO behavior;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4C18470", Offset = "0x4C17470", VA = "0x184C18470", Slot = "10")]
		protected override bool ICPBIPOIINM(IRecRoomQualityConfigProvider BKNKBCIBHGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4C18380", Offset = "0x4C17380", VA = "0x184C18380", Slot = "8")]
		protected override bool MMHCDGJIFGA(bool DNPJEBLIDPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4C184C0", Offset = "0x4C174C0", VA = "0x184C184C0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4C18500", Offset = "0x4C17500", VA = "0x184C18500", Slot = "10")]
		protected override LightRenderingMode ICPBIPOIINM(IRecRoomQualityConfigProvider BKNKBCIBHGO)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4C18560", Offset = "0x4C17560", VA = "0x184C18560", Slot = "8")]
		protected override bool MMHCDGJIFGA(LightRenderingMode DNPJEBLIDPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4C18570", Offset = "0x4C17570", VA = "0x184C18570")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4C185B0", Offset = "0x4C175B0", VA = "0x184C185B0", Slot = "10")]
		protected override SceneDecorationDetailLevel ICPBIPOIINM(IRecRoomQualityConfigProvider BKNKBCIBHGO)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4C18600", Offset = "0x4C17600", VA = "0x184C18600", Slot = "8")]
		protected override bool MMHCDGJIFGA(SceneDecorationDetailLevel DNPJEBLIDPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4C18620", Offset = "0x4C17620", VA = "0x184C18620")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4C18660", Offset = "0x4C17660", VA = "0x184C18660", Slot = "10")]
		protected override TransparencyDetailLevel ICPBIPOIINM(IRecRoomQualityConfigProvider BKNKBCIBHGO)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4C186B0", Offset = "0x4C176B0", VA = "0x184C186B0", Slot = "8")]
		protected override bool MMHCDGJIFGA(TransparencyDetailLevel DNPJEBLIDPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4C186D0", Offset = "0x4C176D0", VA = "0x184C186D0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4C18890", Offset = "0x4C17890", VA = "0x184C18890", Slot = "8")]
		protected override bool MMHCDGJIFGA(BackgroundAnimationDetailLevel MBBADMOLOBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4C18800", Offset = "0x4C17800", VA = "0x184C18800", Slot = "9")]
		protected override void BDAHGMAMFCN(bool NFOGJPFOBPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4C18710", Offset = "0x4C17710", VA = "0x184C18710")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4C18920", Offset = "0x4C17920", VA = "0x184C18920")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4C18A10", Offset = "0x4C17A10", VA = "0x184C18A10")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Terrain FPJNMGLGIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TerrainData NJAMHOLINAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TerrainData CHKIFDHHJJO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Terrain ODNJIADOAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4C18CE0", Offset = "0x4C17CE0", VA = "0x184C18CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4C18C40", Offset = "0x4C17C40", VA = "0x184C18C40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4C192D0", Offset = "0x4C182D0", VA = "0x184C192D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4C191B0", Offset = "0x4C181B0", VA = "0x184C191B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4C191A0", Offset = "0x4C181A0", VA = "0x184C191A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4C18B50", Offset = "0x4C17B50", VA = "0x184C18B50")]
		private void AAMDDLLHACN(DJCEMIGFBIG KLFBDNHGBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4C19500", Offset = "0x4C18500", VA = "0x184C19500", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel EFKGLDCOJFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x555B00", Offset = "0x554B00", VA = "0x180555B00", Slot = "8")]
		protected override bool MMHCDGJIFGA(TerrainQualityLevel MBBADMOLOBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "9")]
		protected override void BDAHGMAMFCN(bool NLDPPCDDMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4C19480", Offset = "0x4C18480", VA = "0x184C19480")]
		private void PIKLEMHPKKG(Settings ICAJNPOENGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4C18D70", Offset = "0x4C17D70", VA = "0x184C18D70")]
		private void DKNFEPCBHBO(TreePrefabOverride[] OLHGNPEELKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4C190C0", Offset = "0x4C180C0", VA = "0x184C190C0")]
		private void LGECPPCPHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4C19040", Offset = "0x4C18040", VA = "0x184C19040")]
		private Settings JPHLNPLHLLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4C19770", Offset = "0x4C18770", VA = "0x184C19770")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface LEBPLIAEOEB
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color NJHACKAPJOO);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private List<Material> HFMKBDIDDJA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BackgroundObject LAKAEGDBNCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x595030", Offset = "0x594030", VA = "0x180595030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4C137E0", Offset = "0x4C127E0", VA = "0x184C137E0")]
		public void Init(BackgroundObject GDCMHMHOFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4C13A30", Offset = "0x4C12A30", VA = "0x184C13A30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4C13B50", Offset = "0x4C12B50", VA = "0x184C13B50")]
		public void SetBlendValue(float OAHCIPHNFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4C13CB0", Offset = "0x4C12CB0", VA = "0x184C13CB0")]
		public void SetColor(Color NJHACKAPJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4C13DC0", Offset = "0x4C12DC0", VA = "0x184C13DC0")]
		public void SetRotation(float CANPHCMJLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4C13FB0", Offset = "0x4C12FB0", VA = "0x184C13FB0")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LKHPIDEJLLM
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JEFNBLNIALC<T> : LKHPIDEJLLM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool IKDMBAKNEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T MBBADMOLOBD);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class ActivationController : MonoBehaviour, LKHPIDEJLLM
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum HMMCLDDIAGA
		{
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		[GFEJMLFCKHB("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected virtual HMMCLDDIAGA JKLPNHMOMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5B0020", Offset = "0x5AF020", VA = "0x1805B0020", Slot = "4")]
			get
			{
				return default(HMMCLDDIAGA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class ActivationController<T> : ActivationController, global::JEFNBLNIALC<T>, LKHPIDEJLLM where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		protected bool? ELACNMDMNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		protected T FELBINHMIMO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IKDMBAKNEDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2468190", Offset = "0x2467190", VA = "0x182468190", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2467E00", Offset = "0x2466E00", VA = "0x182467E00", Slot = "7")]
		public virtual void SetActivation(T MBBADMOLOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool MMHCDGJIFGA(T MBBADMOLOBD);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void BDAHGMAMFCN(bool NLDPPCDDMFM);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x140A120", Offset = "0x1409120", VA = "0x18140A120")]
		protected ActivationController()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LCEEBCMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static byte[] FOBLDOOIPBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static int MKBJJHBJLOC;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static int IFDBKDIOMPI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static BigInteger GDKMPNMIOJK;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4C15770", Offset = "0x4C14770", VA = "0x184C15770")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4C15870", Offset = "0x4C14870", VA = "0x184C15870")]
	public static string CAJPNALAKAJ(byte[] JNPIAJHKCKB, bool GKIDOBEBBAE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
