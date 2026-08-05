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
	public enum EHKLKHJNIIH
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
	private EHKLKHJNIIH bobAxis;

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
	private float DKJOPAKHDPE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 FFDEKHPAMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1CE08E0", Offset = "0x1CDF8E0", VA = "0x181CE08E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1CE08A0", Offset = "0x1CDF8A0", VA = "0x181CE08A0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0AB0", Offset = "0x1CDFAB0", VA = "0x181CE0AB0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0C10", Offset = "0x1CDFC10", VA = "0x181CE0C10")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0C20", Offset = "0x1CDFC20", VA = "0x181CE0C20")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, MNEPFKKHCIM
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string AOLBAEPBNPP = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string NELLFEAMKBL = "_MainColor";

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
	private static List<Material> JOMPOPFGNAF;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> PBCFKKFNHDA;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "4")]
	public void PrepareImposter(NDJKOALONAI FHLPJMHKMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1CE27F0", Offset = "0x1CE17F0", VA = "0x181CE27F0")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct MDGEOEDICKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum JMBJIMMBLPJ
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
	public struct FFEJPJCEFNC : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public MDGEOEDICKE COLIBBCGCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int GDGAONKBLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public KGCFJGJLDFK IEEMFIDGLPK;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1CE1120", Offset = "0x1CE0120", VA = "0x181CE1120", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct EAMJJJNHMCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> IBHDOJOBHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> MEEJMFMKDDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> ECEGHMLEKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> APKKLAJHKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> FAEOPKMOBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> FKMJCHEMBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> ONDDLEEJOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> NFIBCBILPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> GIGBCBOCDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> BGEPPOOOIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> AOGBLJKNLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> PJDHEIBJAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> LPNCNCDJOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> KJMJKIMCBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> CNBEMLKHLEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int MNIKJLJIFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 IIOCFDPDMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool LDOKLFNLEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int MEFPFBPKMHH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int IAEEFPOEAHA = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int KHKOKCHGKEA = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> IBHDOJOBHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> DDCABAIGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> MEEJMFMKDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> ECEGHMLEKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> APKKLAJHKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> FAEOPKMOBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> FKMJCHEMBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> ONDDLEEJOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> NFIBCBILPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> GIGBCBOCDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> KJMJKIMCBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> DAPBPFMKEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> GIMCCAJKMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> BGEPPOOOIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> JIJALBKAJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> AOGBLJKNLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> GKEOMIKKCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> MGCMEOJPAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> JIKFDPEONOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> KNECIFLNAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> OFOGHHEBCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> CEAOOMKGAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> LPMIHDNKHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> MPLONDGMBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> AOKNHGKIAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> JCOHKFLPILF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int EDALNKKIHLP = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int LPPMBMPNDGK = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int CLGNEFFIPBA = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int OHONMCGOPBN = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> LGADBBPDEMM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PPHHLMEEPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3A90", Offset = "0x1CE2A90", VA = "0x181CE3A90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3690", Offset = "0x1CE2690", VA = "0x181CE3690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DEPMBCEHEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3820", Offset = "0x1CE2820", VA = "0x181CE3820")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3A70", Offset = "0x1CE2A70", VA = "0x181CE3A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NPOKBEGLINA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3A60", Offset = "0x1CE2A60", VA = "0x181CE3A60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3A50", Offset = "0x1CE2A50", VA = "0x181CE3A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JMBJIMMBLPJ EFNAIBGMCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1CE36A0", Offset = "0x1CE26A0", VA = "0x181CE36A0")]
		get
		{
			return default(JMBJIMMBLPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3A80", Offset = "0x1CE2A80", VA = "0x181CE3A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private EAMJJJNHMCC NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3AA0", Offset = "0x1CE2AA0", VA = "0x181CE3AA0")]
		get
		{
			return default(EAMJJJNHMCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1CE40B0", Offset = "0x1CE30B0", VA = "0x181CE40B0")]
	public MDGEOEDICKE(IList<Mesh> OAJKDCKDHDB, IList<int> DHEKJEDJMGD, IList<int> NENAGAGCCNH, IList<int[]> GOAEHCAGCFP, IList<Matrix4x4> MBKJOIPMPOG, IList<bool> LLMNJJHGKNO, IList<int> EKGMMFBJHAE, Allocator IJPEBFBKMDH, JMBJIMMBLPJ GPFHNIJKDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1CE36B0", Offset = "0x1CE26B0", VA = "0x181CE36B0")]
	public KGCFJGJLDFK DKIHJDGCHCA(int ICGEMDBEHDG, Allocator IJPEBFBKMDH)
	{
		return default(KGCFJGJLDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3830", Offset = "0x1CE2830", VA = "0x181CE3830", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct KGCFJGJLDFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> IBHDOJOBHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> MEEJMFMKDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> ECEGHMLEKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> APKKLAJHKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> FAEOPKMOBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> FKMJCHEMBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> ONDDLEEJOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> NFIBCBILPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> GIGBCBOCDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> BGEPPOOOIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> AOGBLJKNLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> PJDHEIBJAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> LPNCNCDJOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> LGADBBPDEMM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int LJCBLOJLFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2EE0", Offset = "0x1CE1EE0", VA = "0x181CE2EE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2C30", Offset = "0x1CE1C30", VA = "0x181CE2C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3200", Offset = "0x1CE2200", VA = "0x181CE3200")]
	public KGCFJGJLDFK(int AILBPIHFOHM, int DOGHJOEHDON, int FHPIEHIPOHN, int ICGEMDBEHDG, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE32B0", Offset = "0x1CE22B0", VA = "0x181CE32B0")]
	public KGCFJGJLDFK(int AILBPIHFOHM, int DOGHJOEHDON, int FHPIEHIPOHN, int ICGEMDBEHDG, Allocator IJPEBFBKMDH, bool[] NMLEIGEGJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2CE0", Offset = "0x1CE1CE0", VA = "0x181CE2CE0")]
	public void DHLJHBFJCDP(int MGIHPEGOHLK, int KJBKACPPODJ, int GGLJPLLKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2EF0", Offset = "0x1CE1EF0", VA = "0x181CE2EF0")]
	public int[] JMGEJNFCAPK(int MGIHPEGOHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2C40", Offset = "0x1CE1C40", VA = "0x181CE2C40")]
	private NativeSlice<int> DCELCJPKLPD(int MGIHPEGOHLK)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2DC0", Offset = "0x1CE1DC0", VA = "0x181CE2DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2FB0", Offset = "0x1CE1FB0", VA = "0x181CE2FB0")]
	public Mesh PKJNDLCCABK([Optional] string GOFHDOFAICK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HJGMPGMAFLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> ALDHCGLGNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> APCECPNBKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> GJGBAMBKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> MFHBMAOPIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> GOPOFDGKEGO;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1CE24B0", Offset = "0x1CE14B0", VA = "0x181CE24B0")]
	public void LEICIIEHNCI(Mesh FCHIEFHJLOJ, int[] IMFJKHOIPME, Matrix4x4 IEGJPDNALNC, bool LLMNJJHGKNO = false, int GOFBMAAGELO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2400", Offset = "0x1CE1400", VA = "0x181CE2400")]
	public MDGEOEDICKE IAMINAGLEFG(Allocator IJPEBFBKMDH, MDGEOEDICKE.JMBJIMMBLPJ GPFHNIJKDMB, [Optional] IList<int> NENAGAGCCNH, [Optional] IList<int> AAJOFFJIIOG)
	{
		return default(MDGEOEDICKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2380", Offset = "0x1CE1380", VA = "0x181CE2380")]
	private void DIHPCLAEAME(Mesh FCHIEFHJLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2630", Offset = "0x1CE1630", VA = "0x181CE2630")]
	public HJGMPGMAFLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	private AKFCABHLLHB playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AKFCABHLLHB DKGCCOOGPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5AA180", Offset = "0x5A9180", VA = "0x1805AA180")]
		get
		{
			return default(AKFCABHLLHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA46CB0", Offset = "0xA45CB0", VA = "0x180A46CB0")]
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
	public bool MPFEFAHBBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1CE75E0", Offset = "0x1CE65E0", VA = "0x181CE75E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JIHICECHMNE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NLJMGILFDLO OJBEOOOCILP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NLJMGILFDLO> INMLNEINHBE;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKODJBLEOFB();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum NLJMGILFDLO
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
	public class InstanceColor : MonoBehaviour, MNEPFKKHCIM
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
		private static readonly int NKNDBANKOHE;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2860", Offset = "0x1CE1860", VA = "0x181CE2860")]
		private void EBJMBJHKECE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1CE29A0", Offset = "0x1CE19A0", VA = "0x181CE29A0")]
		private void NOAEPGOBGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2AE0", Offset = "0x1CE1AE0", VA = "0x181CE2AE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2A70", Offset = "0x1CE1A70", VA = "0x181CE2A70", Slot = "4")]
		public void PrepareImposter(NDJKOALONAI FHLPJMHKMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
		public InstanceColor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum AKFCABHLLHB
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
		private bool KJJADBJNGBJ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override LOOMLMKCHJA BEJKMONLBID
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5557C0", Offset = "0x5547C0", VA = "0x1805557C0", Slot = "4")]
			get
			{
				return default(LOOMLMKCHJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0C50", Offset = "0x1CDFC50", VA = "0x181CE0C50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0C70", Offset = "0x1CDFC70", VA = "0x181CE0C70")]
		private void EIOEKOEGBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1CE10B0", Offset = "0x1CE00B0", VA = "0x181CE10B0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0F90", Offset = "0x1CDFF90", VA = "0x181CE0F90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0E30", Offset = "0x1CDFE30", VA = "0x181CE0E30")]
		private void KNDAGPAIDNM(NLJMGILFDLO BLCNPNIJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0C60", Offset = "0x1CDFC60", VA = "0x181CE0C60", Slot = "8")]
		protected override bool DNMCNNOBPOH(bool BGAPJDPKFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0F20", Offset = "0x1CDFF20", VA = "0x181CE0F20", Slot = "9")]
		protected override void OBONNFDLKFG(bool CEMHHCDECIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1CE10E0", Offset = "0x1CE00E0", VA = "0x181CE10E0")]
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
		[DPGOFBBDGFL(BHKPCKHAKLF.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool CKPEFEHMNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int GNOACPCIBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool PEJOELDDLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool PMMGBGJEJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private float DHIMHMNNJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private float IFFBPMONNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float CIKFHKBBFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private float NOEAEEILAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float KBMMPEBOKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private float EHNJOPCMNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private ParticleSystem.MainModule EDDNHMFOJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ParticleSystem.TrailModule JIDMNBCMEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ParticleSystem.EmissionModule DDBLAJDGHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ParticleSystem.CollisionModule FMDFLDNPHCI;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6CD0", Offset = "0x1CE5CD0", VA = "0x181CE6CD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6BB0", Offset = "0x1CE5BB0", VA = "0x181CE6BB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6120", Offset = "0x1CE5120", VA = "0x181CE6120")]
		private void KNDAGPAIDNM(NLJMGILFDLO BLCNPNIJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1CE61F0", Offset = "0x1CE51F0", VA = "0x181CE61F0")]
		private void OCFBGLBENAA(IRecRoomQualityConfigProvider MKKBKPHEKHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5EC0", Offset = "0x1CE4EC0", VA = "0x181CE5EC0")]
		private void JNIDMIOPFGF(OverrideSettings AFCAJHPGMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5D10", Offset = "0x1CE4D10", VA = "0x181CE5D10")]
		private void HDMKPBKKKDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5A40", Offset = "0x1CE4A40", VA = "0x181CE5A40")]
		private void CLLHGKHJHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5C00", Offset = "0x1CE4C00", VA = "0x181CE5C00")]
		private void FKKBBEICHGJ(ParticleSystem.MinMaxCurve BEEHGLLCNFK, out float CHFKGODCPAP, out float OGOMMGKMDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5930", Offset = "0x1CE4930", VA = "0x181CE5930")]
		private ParticleSystem.MinMaxCurve CIJAJAOKONP(ParticleSystem.MinMaxCurve BEEHGLLCNFK, float CHFKGODCPAP, float OGOMMGKMDDF)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override LOOMLMKCHJA BEJKMONLBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5557C0", Offset = "0x5547C0", VA = "0x1805557C0", Slot = "4")]
			get
			{
				return default(LOOMLMKCHJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T KGBMJFLMAOB(IRecRoomQualityConfigProvider OLFMMEHJAEN);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x35E90A0", Offset = "0x35E80A0", VA = "0x1835E90A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x35E98E0", Offset = "0x35E88E0", VA = "0x1835E98E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x35E9610", Offset = "0x35E8610", VA = "0x1835E9610")]
		private void KNDAGPAIDNM(NLJMGILFDLO BLCNPNIJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x35E9430", Offset = "0x35E8430", VA = "0x1835E9430")]
		private void HLIMPIDALOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x35E9640", Offset = "0x35E8640", VA = "0x1835E9640", Slot = "9")]
		protected override void OBONNFDLKFG(bool CEMHHCDECIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x140D9D0", Offset = "0x140C9D0", VA = "0x18140D9D0")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum JCOMJFOOEMG
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private JCOMJFOOEMG behavior;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6EE0", Offset = "0x1CE5EE0", VA = "0x181CE6EE0", Slot = "10")]
		protected override bool KGBMJFLMAOB(IRecRoomQualityConfigProvider OLFMMEHJAEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6EC0", Offset = "0x1CE5EC0", VA = "0x181CE6EC0", Slot = "8")]
		protected override bool DNMCNNOBPOH(bool BGAPJDPKFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6F30", Offset = "0x1CE5F30", VA = "0x181CE6F30")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private enum JDNDIMGMPJM
		{
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private JDNDIMGMPJM behavior;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6F70", Offset = "0x1CE5F70", VA = "0x181CE6F70", Slot = "10")]
		protected override bool KGBMJFLMAOB(IRecRoomQualityConfigProvider OLFMMEHJAEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6EC0", Offset = "0x1CE5EC0", VA = "0x181CE6EC0", Slot = "8")]
		protected override bool DNMCNNOBPOH(bool BGAPJDPKFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6FC0", Offset = "0x1CE5FC0", VA = "0x181CE6FC0")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private enum BCNNJGAEIAN
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private BCNNJGAEIAN behavior;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7000", Offset = "0x1CE6000", VA = "0x181CE7000", Slot = "10")]
		protected override bool KGBMJFLMAOB(IRecRoomQualityConfigProvider OLFMMEHJAEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6EC0", Offset = "0x1CE5EC0", VA = "0x181CE6EC0", Slot = "8")]
		protected override bool DNMCNNOBPOH(bool BGAPJDPKFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7050", Offset = "0x1CE6050", VA = "0x181CE7050")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CE70A0", Offset = "0x1CE60A0", VA = "0x181CE70A0", Slot = "10")]
		protected override LightRenderingMode KGBMJFLMAOB(IRecRoomQualityConfigProvider OLFMMEHJAEN)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7090", Offset = "0x1CE6090", VA = "0x181CE7090", Slot = "8")]
		protected override bool DNMCNNOBPOH(LightRenderingMode BGAPJDPKFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7100", Offset = "0x1CE6100", VA = "0x181CE7100")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CE7160", Offset = "0x1CE6160", VA = "0x181CE7160", Slot = "10")]
		protected override SceneDecorationDetailLevel KGBMJFLMAOB(IRecRoomQualityConfigProvider OLFMMEHJAEN)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7140", Offset = "0x1CE6140", VA = "0x181CE7140", Slot = "8")]
		protected override bool DNMCNNOBPOH(SceneDecorationDetailLevel BGAPJDPKFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1CE71B0", Offset = "0x1CE61B0", VA = "0x181CE71B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CE7210", Offset = "0x1CE6210", VA = "0x181CE7210", Slot = "10")]
		protected override TransparencyDetailLevel KGBMJFLMAOB(IRecRoomQualityConfigProvider OLFMMEHJAEN)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1CE71F0", Offset = "0x1CE61F0", VA = "0x181CE71F0", Slot = "8")]
		protected override bool DNMCNNOBPOH(TransparencyDetailLevel BGAPJDPKFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7260", Offset = "0x1CE6260", VA = "0x181CE7260")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CE7390", Offset = "0x1CE6390", VA = "0x181CE7390", Slot = "8")]
		protected override bool DNMCNNOBPOH(BackgroundAnimationDetailLevel BILMDFLPKJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7420", Offset = "0x1CE6420", VA = "0x181CE7420", Slot = "9")]
		protected override void OBONNFDLKFG(bool JPIKEMPPNEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1CE72A0", Offset = "0x1CE62A0", VA = "0x181CE72A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1CE74B0", Offset = "0x1CE64B0", VA = "0x181CE74B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1CE75A0", Offset = "0x1CE65A0", VA = "0x181CE75A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
		private Terrain DACAFNDGNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TerrainData HGJDOHMNGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TerrainData KGLABOPLCCB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Terrain CEOBDABODBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7D20", Offset = "0x1CE6D20", VA = "0x181CE7D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE77D0", Offset = "0x1CE67D0", VA = "0x181CE77D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7EE0", Offset = "0x1CE6EE0", VA = "0x181CE7EE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7DC0", Offset = "0x1CE6DC0", VA = "0x181CE7DC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7DB0", Offset = "0x1CE6DB0", VA = "0x181CE7DB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1CE76E0", Offset = "0x1CE66E0", VA = "0x181CE76E0")]
		private void ABJAHLGPKON(NLJMGILFDLO BLCNPNIJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1CE8090", Offset = "0x1CE7090", VA = "0x181CE8090", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel FHOMCHIEMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x557FC0", Offset = "0x556FC0", VA = "0x180557FC0", Slot = "8")]
		protected override bool DNMCNNOBPOH(TerrainQualityLevel BILMDFLPKJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "9")]
		protected override void OBONNFDLKFG(bool CEMHHCDECIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7CA0", Offset = "0x1CE6CA0", VA = "0x181CE7CA0")]
		private void OCMHHGMPJJP(Settings HLONBKIMGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1CE79D0", Offset = "0x1CE69D0", VA = "0x181CE79D0")]
		private void MBDADPCCMFN(TreePrefabOverride[] HMGDFMJDFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1CE78F0", Offset = "0x1CE68F0", VA = "0x181CE78F0")]
		private void EHNHFDKFFLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7870", Offset = "0x1CE6870", VA = "0x181CE7870")]
		private Settings CEJEFHOMLKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1CE8300", Offset = "0x1CE7300", VA = "0x181CE8300")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MGPDMNGKKOB
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color FGMFNEFEEBG);
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
		private List<Material> BJFOENNOPJD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BackgroundObject AKKLIEGKICJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5AB360", Offset = "0x5AA360", VA = "0x1805AB360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0060", Offset = "0x1CDF060", VA = "0x181CE0060")]
		public void Init(BackgroundObject EKKOANIDOHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE02B0", Offset = "0x1CDF2B0", VA = "0x181CE02B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE03D0", Offset = "0x1CDF3D0", VA = "0x181CE03D0")]
		public void SetBlendValue(float MOLGICKIMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0530", Offset = "0x1CDF530", VA = "0x181CE0530")]
		public void SetColor(Color FGMFNEFEEBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0640", Offset = "0x1CDF640", VA = "0x181CE0640")]
		public void SetRotation(float GAGPEDAKPHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1CE0830", Offset = "0x1CDF830", VA = "0x181CE0830")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FMLGIHCKGKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BMIAKIAAJEC<T> : FMLGIHCKGKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool AIMLKKBLJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T BILMDFLPKJK);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class ActivationController : MonoBehaviour, FMLGIHCKGKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum LOOMLMKCHJA
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
		[HNOGFPKLJPH("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected virtual LOOMLMKCHJA BEJKMONLBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x551480", Offset = "0x550480", VA = "0x180551480", Slot = "4")]
			get
			{
				return default(LOOMLMKCHJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class ActivationController<T> : ActivationController, global::BMIAKIAAJEC<T>, FMLGIHCKGKM where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		protected bool? EHFLPCLHIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		protected T KGPKCPKFGBJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool AIMLKKBLJDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x35E00D0", Offset = "0x35DF0D0", VA = "0x1835E00D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x35DFD40", Offset = "0x35DED40", VA = "0x1835DFD40", Slot = "7")]
		public virtual void SetActivation(T BILMDFLPKJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool DNMCNNOBPOH(T BILMDFLPKJK);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void OBONNFDLKFG(bool CEMHHCDECIJ);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6300", Offset = "0x2CD5300", VA = "0x182CD6300")]
		protected ActivationController()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1D90", Offset = "0x1CE0D90", VA = "0x181CE1D90")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1E90", Offset = "0x1CE0E90", VA = "0x181CE1E90")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
