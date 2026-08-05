using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Platforms;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x17A0EB0", Offset = "0x179FCB0", VA = "0x1817A0EB0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum EMJODOBBIFO
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
	private EMJODOBBIFO bobAxis;

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
	private float KJBIADJAGMI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 BDECGOGCLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17A0B20", Offset = "0x179F920", VA = "0x1817A0B20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x17A0AE0", Offset = "0x179F8E0", VA = "0x1817A0AE0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x17A0C90", Offset = "0x179FA90", VA = "0x1817A0C90")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x17A0E90", Offset = "0x179FC90", VA = "0x1817A0E90")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, DFGOJPONONJ
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string GBMNFJOBPPM = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string EIABIMCLIPN = "_MainColor";

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
	private static List<Material> NEDEDGKGDAG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> BAIDMBOLJJG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "4")]
	public void PrepareImposter(HKIMPMDKHJK FBDHILNJDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x17A3F10", Offset = "0x17A2D10", VA = "0x1817A3F10")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RequireComponent(typeof(Camera))]
public class ScreenshotGenerator : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x17A7700", Offset = "0x17A6500", VA = "0x1817A7700")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OFNOPPHOJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x17A7DB0", Offset = "0x17A6BB0", VA = "0x1817A7DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[SerializeField]
	private JFHEMGGBBAB playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JFHEMGGBBAB COKHMHKOIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F1970", Offset = "0x7F0770", VA = "0x1807F1970")]
		get
		{
			return default(JFHEMGGBBAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x17A76F0", Offset = "0x17A64F0", VA = "0x1817A76F0")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
[DefaultMember("Item")]
public struct HMDEIPNNLHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum JMFGOHFALFM
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		CollapseSubMeshes,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		CollapseToUniqueMaterials,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		MergeAll
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NPAAAKFDLBK : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[ReadOnly]
		public HMDEIPNNLHK ODAJECCDMOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ReadOnly]
		public int CEABBJCOLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public KMEIHFJLIBD FGIIKFDKKJP;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x17A4EF0", Offset = "0x17A3CF0", VA = "0x1817A4EF0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct MGKGMPPOHIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Vector3> ONDALEELELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<Vector3> PMNKMOLLPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<Vector4> JFHGBCAECEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<Vector2> CIMEJHDBNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<Vector2> BCAJAJOPFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<Vector2> FIDLGIIGNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeSlice<Vector2> HAFBGNJMKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NativeSlice<Color> NODEDNDIIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NativeSlice<BoneWeight> DNMFKPMOGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeSlice<Matrix4x4> DOJPDFDEBIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NativeSlice<int> NHOONCNABPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NativeSlice<int> JHLDDIBOGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeSlice<int> KLBAANFAGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NativeSlice<int> EHOFDFFICNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NativeSlice<byte> CFDOFFBLKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int BHMKEEIEDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Matrix4x4 IBEAMJPFMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool FDJPKMGCBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int FKOMIFKGEDL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const int LGLOLIPGEDE = 1;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int EMOPODDINKM = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector3> ONDALEELELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> OPPGJAGJKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<Vector3> PMNKMOLLPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<Vector4> JFHGBCAECEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<Vector2> CIMEJHDBNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<Vector2> BCAJAJOPFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<Vector2> FIDLGIIGNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<Vector2> HAFBGNJMKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<Color> NODEDNDIIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<BoneWeight> DNMFKPMOGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<int> EHOFDFFICNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<int> IBEDPDGIKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> NFLNDLODILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<Matrix4x4> DOJPDFDEBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> DAOLIJABPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> NHOONCNABPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> FHPPEAGBDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeArray<Matrix4x4> IIKBNGJJMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeArray<byte> MGPKBNEMKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> GEJPIBEJBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeArray<int> PJNKGALCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> JBKJDHIDNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<sbyte> IMIGIKKIGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<int> HFCMKJOKKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<int> DHLKMAGDBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<byte> CFLLDALEKKO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const int CFCGKGECIHD = 0;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private const int EMLPIGIAGHB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private const int JLGGFCIFIDM = 2;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private const int PIBOIDNMLLF = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<int> HNMKBEBJLKI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int INGAMDPJNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x17A1940", Offset = "0x17A0740", VA = "0x1817A1940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x17A1950", Offset = "0x17A0750", VA = "0x1817A1950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FHIHCAOKPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x17A1BF0", Offset = "0x17A09F0", VA = "0x1817A1BF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x17A1920", Offset = "0x17A0720", VA = "0x1817A1920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EBALPHMIJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x17A1930", Offset = "0x17A0730", VA = "0x1817A1930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x17A2440", Offset = "0x17A1240", VA = "0x1817A2440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JMFGOHFALFM MBBKAJACIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x17A2450", Offset = "0x17A1250", VA = "0x1817A2450")]
		get
		{
			return default(JMFGOHFALFM);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x17A1BE0", Offset = "0x17A09E0", VA = "0x1817A1BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private MGKGMPPOHIP MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x17A1DF0", Offset = "0x17A0BF0", VA = "0x1817A1DF0")]
		get
		{
			return default(MGKGMPPOHIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x17A2460", Offset = "0x17A1260", VA = "0x1817A2460")]
	public HMDEIPNNLHK(IList<Mesh> FBPNKAAHLPF, IList<int> HBNGNLCJMGO, IList<int> BPNNJBKAFAM, IList<int[]> ILPCPIKCALC, IList<Matrix4x4> GBLGACDHCMD, IList<bool> LNLNCOKDGNF, IList<int> CADDEANFCNG, Allocator FIPHDKMNFDJ, JMFGOHFALFM PJGDNEOEBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x17A1C00", Offset = "0x17A0A00", VA = "0x1817A1C00")]
	public KMEIHFJLIBD IMMJFBGKEBG(int PHNGIAGJKFN, Allocator FIPHDKMNFDJ)
	{
		return default(KMEIHFJLIBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x17A1960", Offset = "0x17A0760", VA = "0x1817A1960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[NativeContainer]
public struct KMEIHFJLIBD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Vector3> ONDALEELELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<Vector3> PMNKMOLLPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public NativeArray<Vector4> JFHGBCAECEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public NativeArray<Vector2> CIMEJHDBNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public NativeArray<Vector2> BCAJAJOPFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<Vector2> FIDLGIIGNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public NativeArray<Vector2> HAFBGNJMKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<Color> NODEDNDIIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<BoneWeight> DNMFKPMOGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeArray<Matrix4x4> DOJPDFDEBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public NativeArray<int> NHOONCNABPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> JHLDDIBOGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> KLBAANFAGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> HNMKBEBJLKI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NGGPINDLEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x17A4A10", Offset = "0x17A3810", VA = "0x1817A4A10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x17A4390", Offset = "0x17A3190", VA = "0x1817A4390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x17A4E30", Offset = "0x17A3C30", VA = "0x1817A4E30")]
	public KMEIHFJLIBD(int EEEOBOKLHCH, int GCENJELDKFP, int BBPDNCIOAEI, int PHNGIAGJKFN, Allocator FIPHDKMNFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x17A4A20", Offset = "0x17A3820", VA = "0x1817A4A20")]
	public KMEIHFJLIBD(int EEEOBOKLHCH, int GCENJELDKFP, int BBPDNCIOAEI, int PHNGIAGJKFN, Allocator FIPHDKMNFDJ, bool[] CCBNFJPBPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x17A4670", Offset = "0x17A3470", VA = "0x1817A4670")]
	public void LHJDMJMPNKI(int BAHKDJALDAH, int FHMAJLHBFAD, int CNKKOGIEKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x17A45B0", Offset = "0x17A33B0", VA = "0x1817A45B0")]
	public int[] GOMIMIMCGHP(int BAHKDJALDAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x17A43A0", Offset = "0x17A31A0", VA = "0x1817A43A0")]
	private NativeSlice<int> CMEDHGIEHDA(int BAHKDJALDAH)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x17A4440", Offset = "0x17A3240", VA = "0x1817A4440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x17A4760", Offset = "0x17A3560", VA = "0x1817A4760")]
	public Mesh LINLHANFIPL([Optional] string GOEGMDGMEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FGCAGLMCHDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<Mesh> HGBEKLEPJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<int> FNPHDCJKLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private List<bool> AFGHNGECHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private List<int[]> KEHEDBBMLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<Matrix4x4> AFGDMFHKIBJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x17A13F0", Offset = "0x17A01F0", VA = "0x1817A13F0")]
	public void KIHIAMGNAOE(Mesh GFNFNFOOGBL, int[] EICEAOKINIL, Matrix4x4 IBHMEIPBCAO, bool LNLNCOKDGNF = false, int KGJNGNPFHJL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x17A1660", Offset = "0x17A0460", VA = "0x1817A1660")]
	public HMDEIPNNLHK LMAGPIDHMHN(Allocator FIPHDKMNFDJ, HMDEIPNNLHK.JMFGOHFALFM PJGDNEOEBKF, [Optional] IList<int> BPNNJBKAFAM, [Optional] IList<int> GDGDJCMIAMD)
	{
		return default(HMDEIPNNLHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x17A12B0", Offset = "0x17A00B0", VA = "0x1817A12B0")]
	private void AECHLEGEPJC(Mesh GFNFNFOOGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x17A1790", Offset = "0x17A0590", VA = "0x1817A1790")]
	public FGCAGLMCHDJ()
	{
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, DFGOJPONONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ABMBABJKPFE;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x17A4070", Offset = "0x17A2E70", VA = "0x1817A4070")]
		private void MKHIFNHBHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x17A3F90", Offset = "0x17A2D90", VA = "0x1817A3F90")]
		private void FMGMDPODCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x17A4230", Offset = "0x17A3030", VA = "0x1817A4230")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x17A41C0", Offset = "0x17A2FC0", VA = "0x1817A41C0", Slot = "4")]
		public void PrepareImposter(HKIMPMDKHJK FBDHILNJDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC97EE0", Offset = "0xC96CE0", VA = "0x180C97EE0")]
		public InstanceColor()
		{
		}
	}
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Light PDDJFPNHBBG;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Light COPCGFFLOEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x17A7650", Offset = "0x17A6450", VA = "0x1817A7650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x17A74D0", Offset = "0x17A62D0", VA = "0x1817A74D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x17A7600", Offset = "0x17A6400", VA = "0x1817A7600")]
		public ParticleScriptedLight()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GCPPFMONABM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ECALBOGMMIL EGDBFFEGCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ECALBOGMMIL> ENIEACKNDIA;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCMGBBEBNOK();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum ECALBOGMMIL
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Count
}
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[AddComponentMenu("")]
	public class AGProBuilderStub : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public AGProBuilderStub()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void HMMKIDNAONA(ParticleEventListener EFKILBHFNJO, Collider FGBEDAPNDEP, IEnumerable<ParticleCollisionEvent> MDFGMEPGLEJ);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> CGJOGCEDPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[CAILPCABGNE(PNNHMCGEKHG.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HMMKIDNAONA AMPBEAFAMDA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x17A6320", Offset = "0x17A5120", VA = "0x1817A6320")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x17A63C0", Offset = "0x17A51C0", VA = "0x1817A63C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x17A5F80", Offset = "0x17A4D80", VA = "0x1817A5F80")]
		private void OnParticleCollision(GameObject FGBEDAPNDEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public ParticleEventListener()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MMAKJAEPODI
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JPJJKIEJANB<T> : MMAKJAEPODI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PLLCNIBPHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T MLELOJJAIHE);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class ActivationController : MonoBehaviour, MMAKJAEPODI
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum ALPOKAMBFOO
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[EFOKCIAHEIC("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected virtual ALPOKAMBFOO IOBCNHPBCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "4")]
			get
			{
				return default(ALPOKAMBFOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x17A0290", Offset = "0x179F090", VA = "0x1817A0290")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class ActivationController<T> : ActivationController, JPJJKIEJANB<T>, MMAKJAEPODI where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		protected bool? CFBPOCPEKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		protected T AGPFDKMLPOG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PLLCNIBPHIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x43CE680", Offset = "0x43CD480", VA = "0x1843CE680", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x43CE360", Offset = "0x43CD160", VA = "0x1843CE360", Slot = "7")]
		public virtual void SetActivation(T MLELOJJAIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool EBNMCNNLMKD(T MLELOJJAIHE);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void EAFOBMGIKNP(bool NEPPLEGDAOP);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x43CE600", Offset = "0x43CD400", VA = "0x1843CE600")]
		protected ActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OKGHLAMNLLO
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color OPEMNAAFCJM);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<Material> GPJFCMCIKEA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject HFAFCBDJEOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x17A02A0", Offset = "0x179F0A0", VA = "0x1817A02A0")]
		public void Init(BackgroundObject NDMDIDJLLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x17A0540", Offset = "0x179F340", VA = "0x1817A0540")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x17A0660", Offset = "0x179F460", VA = "0x1817A0660")]
		public void SetBlendValue(float HBEPOMAOPJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x17A07C0", Offset = "0x179F5C0", VA = "0x1817A07C0")]
		public void SetColor(Color OPEMNAAFCJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x17A08D0", Offset = "0x179F6D0", VA = "0x1817A08D0")]
		public void SetRotation(float EMNOFGLPALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x17A0A60", Offset = "0x179F860", VA = "0x1817A0A60")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum JFHEMGGBBAB
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	HEAD_AND_BODY
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x17A7F00", Offset = "0x17A6D00", VA = "0x1817A7F00")]
		public bool HJAGLEFLDME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x17A8040", Offset = "0x17A6E40", VA = "0x1817A8040")]
		public StaticBatchMeshData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[EFOKCIAHEIC("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x17A7EE0", Offset = "0x17A6CE0", VA = "0x1817A7EE0")]
		public StaticBatchManager()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x17A78F0", Offset = "0x17A66F0", VA = "0x1817A78F0", Slot = "10")]
		protected override LightRenderingMode DODAEFBALHC(IRecRoomQualityConfigProvider IOMELMCKHGA)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x17A7950", Offset = "0x17A6750", VA = "0x1817A7950", Slot = "8")]
		protected override bool EBNMCNNLMKD(LightRenderingMode KNOMPABIFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x17A7960", Offset = "0x17A6760", VA = "0x1817A7960")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x17A7A60", Offset = "0x17A6860", VA = "0x1817A7A60", Slot = "10")]
		protected override TransparencyDetailLevel DODAEFBALHC(IRecRoomQualityConfigProvider IOMELMCKHGA)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x17A7AB0", Offset = "0x17A68B0", VA = "0x1817A7AB0", Slot = "8")]
		protected override bool EBNMCNNLMKD(TransparencyDetailLevel KNOMPABIFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x17A7AD0", Offset = "0x17A68D0", VA = "0x1817A7AD0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x17A79A0", Offset = "0x17A67A0", VA = "0x1817A79A0", Slot = "10")]
		protected override SceneDecorationDetailLevel DODAEFBALHC(IRecRoomQualityConfigProvider IOMELMCKHGA)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x17A79F0", Offset = "0x17A67F0", VA = "0x1817A79F0", Slot = "8")]
		protected override bool EBNMCNNLMKD(SceneDecorationDetailLevel KNOMPABIFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x17A7A10", Offset = "0x17A6810", VA = "0x1817A7A10")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private enum JEMECDHOOGD
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private JEMECDHOOGD behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x17A7720", Offset = "0x17A6520", VA = "0x1817A7720", Slot = "10")]
		protected override bool DODAEFBALHC(IRecRoomQualityConfigProvider IOMELMCKHGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x17A7770", Offset = "0x17A6570", VA = "0x1817A7770", Slot = "8")]
		protected override bool EBNMCNNLMKD(bool KNOMPABIFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x17A7790", Offset = "0x17A6590", VA = "0x1817A7790")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private Terrain LJCFILOCKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TerrainData BECPGKMFNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TerrainData CPOAIOFDKLH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Terrain EGBFEANEMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x17A8620", Offset = "0x17A7420", VA = "0x1817A8620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x17A80C0", Offset = "0x17A6EC0", VA = "0x1817A80C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x17A87B0", Offset = "0x17A75B0", VA = "0x1817A87B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x17A86D0", Offset = "0x17A74D0", VA = "0x1817A86D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x17A86C0", Offset = "0x17A74C0", VA = "0x1817A86C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x17A8900", Offset = "0x17A7700", VA = "0x1817A8900")]
		private void PAOJLFFJJBA(ECALBOGMMIL EFDDPLAIJPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x17A8990", Offset = "0x17A7790", VA = "0x1817A8990", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel GBMJCOKFECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83C860", Offset = "0x83B660", VA = "0x18083C860", Slot = "8")]
		protected override bool EBNMCNNLMKD(TerrainQualityLevel MLELOJJAIHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "9")]
		protected override void EAFOBMGIKNP(bool NEPPLEGDAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x17A85A0", Offset = "0x17A73A0", VA = "0x1817A85A0")]
		private void JMANHHOLEPD(Settings OAHFBIINMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x17A8250", Offset = "0x17A7050", VA = "0x1817A8250")]
		private void CHLIKPCHCHO(TreePrefabOverride[] KHKMODGICCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x17A8160", Offset = "0x17A6F60", VA = "0x1817A8160")]
		private void CBDLKBDFAHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x17A8520", Offset = "0x17A7320", VA = "0x1817A8520")]
		private Settings ELEKPMDCKOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x17A8B50", Offset = "0x17A7950", VA = "0x1817A8B50")]
		public TerrainQualitySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private bool EEJCKCJBPDF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override ALPOKAMBFOO IOBCNHPBCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x936390", Offset = "0x935190", VA = "0x180936390", Slot = "4")]
			get
			{
				return default(ALPOKAMBFOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x17A0EE0", Offset = "0x179FCE0", VA = "0x1817A0EE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x17A0F80", Offset = "0x179FD80", VA = "0x1817A0F80")]
		private void DOGIILKGBNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x17A1240", Offset = "0x17A0040", VA = "0x1817A1240")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x17A1160", Offset = "0x179FF60", VA = "0x1817A1160")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x17A0EF0", Offset = "0x179FCF0", VA = "0x1817A0EF0")]
		private void DGJEJBJMAJC(ECALBOGMMIL EFDDPLAIJPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x17A1150", Offset = "0x179FF50", VA = "0x1817A1150", Slot = "8")]
		protected override bool EBNMCNNLMKD(bool KNOMPABIFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x17A10E0", Offset = "0x179FEE0", VA = "0x1817A10E0", Slot = "9")]
		protected override void EAFOBMGIKNP(bool NEPPLEGDAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x17A1270", Offset = "0x17A0070", VA = "0x1817A1270")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x17A7C40", Offset = "0x17A6A40", VA = "0x1817A7C40", Slot = "8")]
		protected override bool EBNMCNNLMKD(BackgroundAnimationDetailLevel MLELOJJAIHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x17A7BB0", Offset = "0x17A69B0", VA = "0x1817A7BB0", Slot = "9")]
		protected override void EAFOBMGIKNP(bool EOJJCIJDILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x17A7B20", Offset = "0x17A6920", VA = "0x1817A7B20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x17A7CE0", Offset = "0x17A6AE0", VA = "0x1817A7CE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x17A7D70", Offset = "0x17A6B70", VA = "0x1817A7D70")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x48990", Offset = "0x47D90")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		[CAILPCABGNE(PNNHMCGEKHG.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private bool PGGLKEBMDDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int IJBFNMDKABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool LMHFGAFJPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool CNOLJCNBJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private float BGDIBCLOPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float MIAGOECINMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float HLAEPAFNDFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private float HOBIMHGONGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private float JKDDAJGNOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private float EBJCIPNMOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private ParticleSystem.MainModule KJPNKFLIAEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ParticleSystem.TrailModule JJKOCKCMCBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private ParticleSystem.EmissionModule CNDDDOKDMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private ParticleSystem.CollisionModule DFIDDDFBBDN;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x17A7340", Offset = "0x17A6140", VA = "0x1817A7340")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x17A7260", Offset = "0x17A6060", VA = "0x1817A7260")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x17A69B0", Offset = "0x17A57B0", VA = "0x1817A69B0")]
		private void DGJEJBJMAJC(ECALBOGMMIL EFDDPLAIJPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x17A6A10", Offset = "0x17A5810", VA = "0x1817A6A10")]
		private void KAHPKBIIEDH(IRecRoomQualityConfigProvider FKIINBMBGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x17A65A0", Offset = "0x17A53A0", VA = "0x1817A65A0")]
		private void AICEGKAPJGD(OverrideSettings BHIPNHFHDAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x17A6800", Offset = "0x17A5600", VA = "0x1817A6800")]
		private void BIFDHMCCCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x17A6F50", Offset = "0x17A5D50", VA = "0x1817A6F50")]
		private void LJPLFKJPOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x17A6460", Offset = "0x17A5260", VA = "0x1817A6460")]
		private void ABOKJKJGKAE(ParticleSystem.MinMaxCurve LEOCEIPHEPJ, out float PGAFLOIBDBK, out float KHJFJGKFOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x17A7110", Offset = "0x17A5F10", VA = "0x1817A7110")]
		private ParticleSystem.MinMaxCurve MABCNCAOJGF(ParticleSystem.MinMaxCurve LEOCEIPHEPJ, float PGAFLOIBDBK, float KHJFJGKFOHB)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override ALPOKAMBFOO IOBCNHPBCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x936390", Offset = "0x935190", VA = "0x180936390", Slot = "4")]
			get
			{
				return default(ALPOKAMBFOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T DODAEFBALHC(IRecRoomQualityConfigProvider IOMELMCKHGA);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6382F30", Offset = "0x6381D30", VA = "0x186382F30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6383420", Offset = "0x6382220", VA = "0x186383420")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6383230", Offset = "0x6382030", VA = "0x186383230")]
		private void DGJEJBJMAJC(ECALBOGMMIL EFDDPLAIJPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x63833A0", Offset = "0x63821A0", VA = "0x1863833A0")]
		private void NLDDLHOECMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6383260", Offset = "0x6382060", VA = "0x186383260", Slot = "9")]
		protected override void EAFOBMGIKNP(bool NEPPLEGDAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2A2C5A0", Offset = "0x2A2B3A0", VA = "0x182A2C5A0")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private enum FKGJMBOCLMC
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private FKGJMBOCLMC behavior;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x17A7860", Offset = "0x17A6660", VA = "0x1817A7860", Slot = "10")]
		protected override bool DODAEFBALHC(IRecRoomQualityConfigProvider IOMELMCKHGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x17A7770", Offset = "0x17A6570", VA = "0x1817A7770", Slot = "8")]
		protected override bool EBNMCNNLMKD(bool KNOMPABIFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x17A78B0", Offset = "0x17A66B0", VA = "0x1817A78B0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class PPMMDEDEDJL
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x17A5E90", Offset = "0x17A4C90", VA = "0x1817A5E90")]
	[GIEEOCCBBIJ(PFHGMCKNAFN.None)]
	private static void BALEBCFJGHH(OBEPLHILJNL PIOBINFNKKO)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private enum JIOGKIFPEFG
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private JIOGKIFPEFG behavior;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x17A77D0", Offset = "0x17A65D0", VA = "0x1817A77D0", Slot = "10")]
		protected override bool DODAEFBALHC(IRecRoomQualityConfigProvider IOMELMCKHGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x17A7770", Offset = "0x17A6570", VA = "0x1817A7770", Slot = "8")]
		protected override bool EBNMCNNLMKD(bool KNOMPABIFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x17A7820", Offset = "0x17A6620", VA = "0x1817A7820")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
