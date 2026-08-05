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
	[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x140D8A0", Offset = "0x140CAA0", VA = "0x18140D8A0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum FFFOKIOHEHL
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
	private FFFOKIOHEHL bobAxis;

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
	private float CDIENCEABBF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 FHHKMAILDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x140AFC0", Offset = "0x140A1C0", VA = "0x18140AFC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x140AF80", Offset = "0x140A180", VA = "0x18140AF80")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x140B130", Offset = "0x140A330", VA = "0x18140B130")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x140B330", Offset = "0x140A530", VA = "0x18140B330")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, ILNBECODPNG
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string HMPJCGAPLDK = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string EFIJFNHBLNE = "_MainColor";

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
	private static List<Material> BMKJGPJODKH;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> IGBIHHDKJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "4")]
	public void PrepareImposter(LLGIHILHCNJ OGEINKONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x140E4C0", Offset = "0x140D6C0", VA = "0x18140E4C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1410A50", Offset = "0x140FC50", VA = "0x181410A50")]
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
	public bool HPAHMLDDNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1411100", Offset = "0x1410300", VA = "0x181411100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
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
	private JCNLDFAHLCO playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JCNLDFAHLCO FEPDGCJOEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9FAA30", Offset = "0x9F9C30", VA = "0x1809FAA30")]
		get
		{
			return default(JCNLDFAHLCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1410A40", Offset = "0x140FC40", VA = "0x181410A40")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
[DefaultMember("Item")]
public struct CLNJABELDPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum IJOOCMHMEFB
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
	public struct AFBKGPIHDEG : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[ReadOnly]
		public CLNJABELDPM HINPDCMAGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ReadOnly]
		public int GJJNOMFDNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NECPAEAIMBI MACOINCBNAH;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x14099A0", Offset = "0x1408BA0", VA = "0x1814099A0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct BDJNOGPHIOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Vector3> JMLDFPPLPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<Vector3> PKKBLOJIMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<Vector4> GODCFPAHDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<Vector2> EEFNJEEMEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<Vector2> INCPGIDIEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<Vector2> JPNGIALOCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeSlice<Vector2> EMIELMCDGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NativeSlice<Color> KOLMLPOBEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NativeSlice<BoneWeight> HINJMIGAHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeSlice<Matrix4x4> NAHJJFHJMEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NativeSlice<int> DDMCHCPIBFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NativeSlice<int> JGBJIKKDGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeSlice<int> GNOCFDFIJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NativeSlice<int> CCCNFACANNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NativeSlice<byte> CHEFFLFINJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int AGKIJMCCFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Matrix4x4 MLPEPMPPGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool IHDEBFLOECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int KAPEALLMANE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const int OAFJMOFBOPC = 1;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int ACLFACJBFAL = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector3> JMLDFPPLPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> JNOOMJCMONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<Vector3> PKKBLOJIMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<Vector4> GODCFPAHDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<Vector2> EEFNJEEMEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<Vector2> INCPGIDIEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<Vector2> JPNGIALOCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<Vector2> EMIELMCDGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<Color> KOLMLPOBEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<BoneWeight> HINJMIGAHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<int> CCCNFACANNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<int> JMLJDDHMLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> NGGOBDPKIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<Matrix4x4> NAHJJFHJMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> OJBPNLOKLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> DDMCHCPIBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> IEJPPKLPHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeArray<Matrix4x4> GDCIFFGKBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeArray<byte> GNIFAEJPDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> EPDEKNMHDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeArray<int> FMKFBIPDALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> IEABJMIAGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<sbyte> IFEMNIEIBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<int> LFAOJIGMJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<int> BBMAGEOCPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<byte> FCJMOCHAANE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const int HFBBFDJDNGC = 0;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private const int PBCCNOLJMNA = 1;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private const int BCFKHGADHFH = 2;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private const int IGDLFFNHECK = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<int> HNLOJIOADLH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EDGHIKLAKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x140B810", Offset = "0x140AA10", VA = "0x18140B810")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x140B370", Offset = "0x140A570", VA = "0x18140B370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FNJANAFKDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x140B360", Offset = "0x140A560", VA = "0x18140B360")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x140BE80", Offset = "0x140B080", VA = "0x18140BE80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LKDFEFMFJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x140B800", Offset = "0x140AA00", VA = "0x18140B800")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x140BE90", Offset = "0x140B090", VA = "0x18140BE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IJOOCMHMEFB NDBANJDNMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x140B350", Offset = "0x140A550", VA = "0x18140B350")]
		get
		{
			return default(IJOOCMHMEFB);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x140B7F0", Offset = "0x140A9F0", VA = "0x18140B7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private BDJNOGPHIOE LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x140B820", Offset = "0x140AA20", VA = "0x18140B820")]
		get
		{
			return default(BDJNOGPHIOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x140BEA0", Offset = "0x140B0A0", VA = "0x18140BEA0")]
	public CLNJABELDPM(IList<Mesh> MMBKDKLMFAH, IList<int> HGGCIGOBAJH, IList<int> AECEJOLDJPP, IList<int[]> DGCEKBGMICA, IList<Matrix4x4> IGNHADAPAFH, IList<bool> NMOBIMDGPEG, IList<int> DGAAONPEHKK, Allocator IEOPKOGNAGJ, IJOOCMHMEFB DJBEAMDANPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x140B380", Offset = "0x140A580", VA = "0x18140B380")]
	public NECPAEAIMBI DOFDJADFPNH(int HDPMDDLCIPH, Allocator IEOPKOGNAGJ)
	{
		return default(NECPAEAIMBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x140B570", Offset = "0x140A770", VA = "0x18140B570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[NativeContainer]
public struct NECPAEAIMBI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Vector3> JMLDFPPLPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<Vector3> PKKBLOJIMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public NativeArray<Vector4> GODCFPAHDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public NativeArray<Vector2> EEFNJEEMEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public NativeArray<Vector2> INCPGIDIEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<Vector2> JPNGIALOCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public NativeArray<Vector2> EMIELMCDGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<Color> KOLMLPOBEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<BoneWeight> HINJMIGAHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeArray<Matrix4x4> NAHJJFHJMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public NativeArray<int> DDMCHCPIBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> JGBJIKKDGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> GNOCFDFIJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> HNLOJIOADLH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int CJJKHPJHJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x140EFB0", Offset = "0x140E1B0", VA = "0x18140EFB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x140E9F0", Offset = "0x140DBF0", VA = "0x18140E9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x140EFC0", Offset = "0x140E1C0", VA = "0x18140EFC0")]
	public NECPAEAIMBI(int OOLNGAJGFED, int EOKIMGBCFFB, int ICMCJNEIBKJ, int HDPMDDLCIPH, Allocator IEOPKOGNAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x140F080", Offset = "0x140E280", VA = "0x18140F080")]
	public NECPAEAIMBI(int OOLNGAJGFED, int EOKIMGBCFFB, int ICMCJNEIBKJ, int HDPMDDLCIPH, Allocator IEOPKOGNAGJ, bool[] HNBEPOPDLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x140EB70", Offset = "0x140DD70", VA = "0x18140EB70")]
	public void EMFLNKFFPIE(int DIFDBMPLKLP, int ADLHMCAGLJA, int CGGOJFONIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x140E930", Offset = "0x140DB30", VA = "0x18140E930")]
	public int[] BLBLDIHFPDG(int DIFDBMPLKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x140EC60", Offset = "0x140DE60", VA = "0x18140EC60")]
	private NativeSlice<int> GJMCDNDKJGM(int DIFDBMPLKLP)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x140EA00", Offset = "0x140DC00", VA = "0x18140EA00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x140ED00", Offset = "0x140DF00", VA = "0x18140ED00")]
	public Mesh HIINGDAFOFN([Optional] string GEIPLKGPDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EDMFDJLGDMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<Mesh> HPKONGCAOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<int> HLDCIMGHAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private List<bool> HBBPOGAHBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private List<int[]> APCFLIHHKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<Matrix4x4> BGAEJLACGDA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x140DCA0", Offset = "0x140CEA0", VA = "0x18140DCA0")]
	public void CBJHEAPGKNH(Mesh BOIPJLCFOOL, int[] EEAELCGFLMP, Matrix4x4 IFFPKAILPDG, bool NMOBIMDGPEG = false, int BCAIHDFHABD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x140E050", Offset = "0x140D250", VA = "0x18140E050")]
	public CLNJABELDPM LGCLMGOMLAM(Allocator IEOPKOGNAGJ, CLNJABELDPM.IJOOCMHMEFB DJBEAMDANPL, [Optional] IList<int> AECEJOLDJPP, [Optional] IList<int> DOOLMDDHCAN)
	{
		return default(CLNJABELDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x140DF10", Offset = "0x140D110", VA = "0x18140DF10")]
	private void GOMBLPKONLP(Mesh BOIPJLCFOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x140E180", Offset = "0x140D380", VA = "0x18140E180")]
	public EDMFDJLGDMK()
	{
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, ILNBECODPNG
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
		private static readonly int EOOCOMLDMKJ;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x140E540", Offset = "0x140D740", VA = "0x18140E540")]
		private void EJDPLLDFLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x140E690", Offset = "0x140D890", VA = "0x18140E690")]
		private void JHFFGLPAAPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x140E7E0", Offset = "0x140D9E0", VA = "0x18140E7E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x140E770", Offset = "0x140D970", VA = "0x18140E770", Slot = "4")]
		public void PrepareImposter(LLGIHILHCNJ OGEINKONADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xBAAF60", Offset = "0xBAA160", VA = "0x180BAAF60")]
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
		private Light HHJBALFMPBJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Light ALGBJOKEDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x14109A0", Offset = "0x140FBA0", VA = "0x1814109A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1410820", Offset = "0x140FA20", VA = "0x181410820")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1410950", Offset = "0x140FB50", VA = "0x181410950")]
		public ParticleScriptedLight()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DKFJNNAIKPA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NIOICLCLOMG CAKBBGCLMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NIOICLCLOMG> GDBHJAGNCDG;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFJKKJEEDJE();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum NIOICLCLOMG
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
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
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
		public delegate void CHFCIFNFBJO(ParticleEventListener IINMHMGKFJG, Collider HPOECFLNEOJ, IEnumerable<ParticleCollisionEvent> GBGIAKANKFF);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> NLHKMMIPFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CHFCIFNFBJO PDOEGJMMJDE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x140F830", Offset = "0x140EA30", VA = "0x18140F830")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x140F8D0", Offset = "0x140EAD0", VA = "0x18140F8D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x140F490", Offset = "0x140E690", VA = "0x18140F490")]
		private void OnParticleCollision(GameObject HPOECFLNEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public ParticleEventListener()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CGEAMKBBAKD
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MOIFJLHJPIP<T> : CGEAMKBBAKD
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KKIDDJEEFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T LGMPOFBPBIP);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class ActivationController : MonoBehaviour, CGEAMKBBAKD
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum NNMOCKJEMFD
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
		[FDKNKMFDEBB("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected virtual NNMOCKJEMFD BBGDNNJFIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "4")]
			get
			{
				return default(NNMOCKJEMFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x140A730", Offset = "0x1409930", VA = "0x18140A730")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class ActivationController<T> : ActivationController, MOIFJLHJPIP<T>, CGEAMKBBAKD where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		protected bool? PAFABBBEEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		protected T IBEHLAHLDPI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KKIDDJEEFIE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x46B70A0", Offset = "0x46B62A0", VA = "0x1846B70A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x46B6D40", Offset = "0x46B5F40", VA = "0x1846B6D40", Slot = "7")]
		public virtual void SetActivation(T LGMPOFBPBIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool OEIMHFHOJAP(T LGMPOFBPBIP);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void JGIHHOKNKCB(bool FFOOIFGALHK);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x46B7020", Offset = "0x46B6220", VA = "0x1846B7020")]
		protected ActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface IANCBAGCEGM
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color MBOFNGAOJFM);
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
		private List<Material> LCIGLHMMKAI;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject GLJCFIPEALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x140A740", Offset = "0x1409940", VA = "0x18140A740")]
		public void Init(BackgroundObject AHDDCNOKJEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x140A9F0", Offset = "0x1409BF0", VA = "0x18140A9F0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x140AB10", Offset = "0x1409D10", VA = "0x18140AB10")]
		public void SetBlendValue(float FIBOBIDLDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x140AC60", Offset = "0x1409E60", VA = "0x18140AC60")]
		public void SetColor(Color MBOFNGAOJFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x140AD70", Offset = "0x1409F70", VA = "0x18140AD70")]
		public void SetRotation(float AAECNILGNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x140AF00", Offset = "0x140A100", VA = "0x18140AF00")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum JCNLDFAHLCO
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
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
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
		[Cpp2IlInjected.Address(RVA = "0x1411250", Offset = "0x1410450", VA = "0x181411250")]
		public bool JKNMGKFHPJO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1411390", Offset = "0x1410590", VA = "0x181411390")]
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
		[FDKNKMFDEBB("UseSpacePartition")]
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
		[Cpp2IlInjected.Address(RVA = "0x1411230", Offset = "0x1410430", VA = "0x181411230")]
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
		[Cpp2IlInjected.Address(RVA = "0x1410C40", Offset = "0x140FE40", VA = "0x181410C40", Slot = "10")]
		protected override LightRenderingMode ODLAEDPLEKM(IRecRoomQualityConfigProvider PJCENIGMDDE)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1410CA0", Offset = "0x140FEA0", VA = "0x181410CA0", Slot = "8")]
		protected override bool OEIMHFHOJAP(LightRenderingMode OGCOHCKFFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1410CB0", Offset = "0x140FEB0", VA = "0x181410CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1410DB0", Offset = "0x140FFB0", VA = "0x181410DB0", Slot = "10")]
		protected override TransparencyDetailLevel ODLAEDPLEKM(IRecRoomQualityConfigProvider PJCENIGMDDE)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1410E00", Offset = "0x1410000", VA = "0x181410E00", Slot = "8")]
		protected override bool OEIMHFHOJAP(TransparencyDetailLevel OGCOHCKFFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1410E20", Offset = "0x1410020", VA = "0x181410E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1410CF0", Offset = "0x140FEF0", VA = "0x181410CF0", Slot = "10")]
		protected override SceneDecorationDetailLevel ODLAEDPLEKM(IRecRoomQualityConfigProvider PJCENIGMDDE)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1410D40", Offset = "0x140FF40", VA = "0x181410D40", Slot = "8")]
		protected override bool OEIMHFHOJAP(SceneDecorationDetailLevel OGCOHCKFFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1410D60", Offset = "0x140FF60", VA = "0x181410D60")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private enum DEFEMBHEEED
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private DEFEMBHEEED behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1410A70", Offset = "0x140FC70", VA = "0x181410A70", Slot = "10")]
		protected override bool ODLAEDPLEKM(IRecRoomQualityConfigProvider PJCENIGMDDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1410AC0", Offset = "0x140FCC0", VA = "0x181410AC0", Slot = "8")]
		protected override bool OEIMHFHOJAP(bool OGCOHCKFFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1410AE0", Offset = "0x140FCE0", VA = "0x181410AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
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
		private Terrain LMEPFMJLODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TerrainData HBHDEEKMJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TerrainData KLONNCFEDAD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Terrain ANOJMMEOCGO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1411540", Offset = "0x1410740", VA = "0x181411540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1411410", Offset = "0x1410610", VA = "0x181411410")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1411BA0", Offset = "0x1410DA0", VA = "0x181411BA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1411AC0", Offset = "0x1410CC0", VA = "0x181411AC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1411AB0", Offset = "0x1410CB0", VA = "0x181411AB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x14114B0", Offset = "0x14106B0", VA = "0x1814114B0")]
		private void CBPECAGOKKP(NIOICLCLOMG ICFIEDNENNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1411CF0", Offset = "0x1410EF0", VA = "0x181411CF0", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel HLDAPIHDBDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x845980", Offset = "0x844B80", VA = "0x180845980", Slot = "8")]
		protected override bool OEIMHFHOJAP(TerrainQualityLevel LGMPOFBPBIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "9")]
		protected override void JGIHHOKNKCB(bool FFOOIFGALHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x14115E0", Offset = "0x14107E0", VA = "0x1814115E0")]
		private void DBEJFOHBDAJ(Settings OGEIODPOGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1411660", Offset = "0x1410860", VA = "0x181411660")]
		private void IBMBBBDLNEE(TreePrefabOverride[] ILCKLMFHNBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1411940", Offset = "0x1410B40", VA = "0x181411940")]
		private void JLPCOCGBJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1411A30", Offset = "0x1410C30", VA = "0x181411A30")]
		private Settings OILJJDLKGOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1411EC0", Offset = "0x14110C0", VA = "0x181411EC0")]
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
		private bool HIJEEDFFLPH;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override NNMOCKJEMFD BBGDNNJFIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8F2F00", Offset = "0x8F2100", VA = "0x1808F2F00", Slot = "4")]
			get
			{
				return default(NNMOCKJEMFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x140D8D0", Offset = "0x140CAD0", VA = "0x18140D8D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x140D8E0", Offset = "0x140CAE0", VA = "0x18140D8E0")]
		private void FFDPMEMJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x140DC30", Offset = "0x140CE30", VA = "0x18140DC30")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x140DB50", Offset = "0x140CD50", VA = "0x18140DB50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x140DAB0", Offset = "0x140CCB0", VA = "0x18140DAB0")]
		private void MBDLKJLCOBJ(NIOICLCLOMG ICFIEDNENNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x140DB40", Offset = "0x140CD40", VA = "0x18140DB40", Slot = "8")]
		protected override bool OEIMHFHOJAP(bool OGCOHCKFFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x140DA40", Offset = "0x140CC40", VA = "0x18140DA40", Slot = "9")]
		protected override void JGIHHOKNKCB(bool FFOOIFGALHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x140DC60", Offset = "0x140CE60", VA = "0x18140DC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x1410F90", Offset = "0x1410190", VA = "0x181410F90", Slot = "8")]
		protected override bool OEIMHFHOJAP(BackgroundAnimationDetailLevel LGMPOFBPBIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1410F00", Offset = "0x1410100", VA = "0x181410F00", Slot = "9")]
		protected override void JGIHHOKNKCB(bool KENJFDFJIKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1410E70", Offset = "0x1410070", VA = "0x181410E70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1411030", Offset = "0x1410230", VA = "0x181411030")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x14110C0", Offset = "0x14102C0", VA = "0x1814110C0")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x46900", Offset = "0x45D00")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private bool NGLIJIFAAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int BJFFDPACBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool ALHEOHGDDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool KAOHJEICMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private float KEAIJLALABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float OGIKBIEBCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float HHHCNNOLOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private float CGPNEOBJPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private float MOINNNCBIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private float IAHHHGKMGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private ParticleSystem.MainModule EEHILABBNNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ParticleSystem.TrailModule KJBBGGABLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private ParticleSystem.EmissionModule FLPAJJIEIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private ParticleSystem.CollisionModule HLGNPBJACFD;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1410690", Offset = "0x140F890", VA = "0x181410690")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x14105B0", Offset = "0x140F7B0", VA = "0x1814105B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1410250", Offset = "0x140F450", VA = "0x181410250")]
		private void MBDLKJLCOBJ(NIOICLCLOMG ICFIEDNENNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x140F970", Offset = "0x140EB70", VA = "0x18140F970")]
		private void CDLGKNFFGKI(IRecRoomQualityConfigProvider PEPOGGMJFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1410000", Offset = "0x140F200", VA = "0x181410000")]
		private void LFCBCJBJEDB(OverrideSettings CFAJDOJPDIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x140FE50", Offset = "0x140F050", VA = "0x18140FE50")]
		private void KMCGILOIKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x14103F0", Offset = "0x140F5F0", VA = "0x1814103F0")]
		private void NJMIKHLOJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x14102B0", Offset = "0x140F4B0", VA = "0x1814102B0")]
		private void MNNDCCFJMEC(ParticleSystem.MinMaxCurve JJPIMAEMOBA, out float DCDJECANDLI, out float PFBDBIGDHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x140FD00", Offset = "0x140EF00", VA = "0x18140FD00")]
		private ParticleSystem.MinMaxCurve FEFFEFCMIPO(ParticleSystem.MinMaxCurve JJPIMAEMOBA, float DCDJECANDLI, float PFBDBIGDHGP)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override NNMOCKJEMFD BBGDNNJFIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8F2F00", Offset = "0x8F2100", VA = "0x1808F2F00", Slot = "4")]
			get
			{
				return default(NNMOCKJEMFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T ODLAEDPLEKM(IRecRoomQualityConfigProvider PJCENIGMDDE);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6252D00", Offset = "0x6251F00", VA = "0x186252D00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62531F0", Offset = "0x62523F0", VA = "0x1862531F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62531C0", Offset = "0x62523C0", VA = "0x1862531C0")]
		private void MBDLKJLCOBJ(NIOICLCLOMG ICFIEDNENNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6253100", Offset = "0x6252300", VA = "0x186253100")]
		private void IHICPGGLKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6253180", Offset = "0x6252380", VA = "0x186253180", Slot = "9")]
		protected override void JGIHHOKNKCB(bool FFOOIFGALHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B910", Offset = "0x2A0AB10", VA = "0x182A0B910")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private enum EACNBAIMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private EACNBAIMPIO behavior;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1410BB0", Offset = "0x140FDB0", VA = "0x181410BB0", Slot = "10")]
		protected override bool ODLAEDPLEKM(IRecRoomQualityConfigProvider PJCENIGMDDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1410AC0", Offset = "0x140FCC0", VA = "0x181410AC0", Slot = "8")]
		protected override bool OEIMHFHOJAP(bool OGCOHCKFFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1410C00", Offset = "0x140FE00", VA = "0x181410C00")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class ICDCLKOAIAB
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x140E310", Offset = "0x140D510", VA = "0x18140E310")]
	[MPKPGFJAEKF(OJBJGAAILBP.None)]
	private static void BDIDELBNDKE(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private enum KCNIMIJFMKK
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private KCNIMIJFMKK behavior;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1410B20", Offset = "0x140FD20", VA = "0x181410B20", Slot = "10")]
		protected override bool ODLAEDPLEKM(IRecRoomQualityConfigProvider PJCENIGMDDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1410AC0", Offset = "0x140FCC0", VA = "0x181410AC0", Slot = "8")]
		protected override bool OEIMHFHOJAP(bool OGCOHCKFFLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1410B70", Offset = "0x140FD70", VA = "0x181410B70")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
