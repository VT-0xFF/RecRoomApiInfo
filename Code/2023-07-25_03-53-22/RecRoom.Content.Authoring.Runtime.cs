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
	[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xBCFA50", Offset = "0xBCEA50", VA = "0x180BCFA50")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum LLEBHKEKJJE
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
	private LLEBHKEKJJE bobAxis;

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
	private float NEBMEOCOBCI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 IBBKPLJOALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8A90", Offset = "0x6EA7A90", VA = "0x186EA8A90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x12B8430", Offset = "0x12B7430", VA = "0x1812B8430")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8C00", Offset = "0x6EA7C00", VA = "0x186EA8C00")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8E00", Offset = "0x6EA7E00", VA = "0x186EA8E00")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, HDEBGJDAOOP
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string BBMJOMCMFLC = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string LLDENOHPMAF = "_MainColor";

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
	private static List<Material> CGDGDPABAJH;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> APBFCOOMEGP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "4")]
	public void PrepareImposter(DEMPFPLJFKJ BPFIFAEKGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EABF50", Offset = "0x6EAAF50", VA = "0x186EABF50")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EAE710", Offset = "0x6EAD710", VA = "0x186EAE710")]
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
	public bool JBMJKICELJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEDC0", Offset = "0x6EADDC0", VA = "0x186EAEDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
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
	private CFCIEPINLIG playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CFCIEPINLIG HIMJHNADNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xACCC40", Offset = "0xACBC40", VA = "0x180ACCC40")]
		get
		{
			return default(CFCIEPINLIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE700", Offset = "0x6EAD700", VA = "0x186EAE700")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
[DefaultMember("Item")]
public struct HHNHCPHEMOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum EDPHHFKKGGJ
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
	public struct LLEPGLGHPPH : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[ReadOnly]
		public HHNHCPHEMOM KDGEHLECGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ReadOnly]
		public int CGADFHDBCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AGHCKMMEDEC OFAOPNKHDKL;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EAC3C0", Offset = "0x6EAB3C0", VA = "0x186EAC3C0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct PPNGGGFJGEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Vector3> JODOCBMAIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<Vector3> EHDNIIKEAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<Vector4> ABNEAPOHDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<Vector2> HOCMBLHNHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<Vector2> KHEDOFPLEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<Vector2> POOLDOACBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeSlice<Vector2> IJNOIJOCEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NativeSlice<Color> OJFMDMMLHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NativeSlice<BoneWeight> MLGNANGNCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeSlice<Matrix4x4> GCPPFGBCHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NativeSlice<int> GKOIADDLHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NativeSlice<int> FIKPOPBKHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeSlice<int> JAOJAMCAKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NativeSlice<int> HEHLCJFOJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NativeSlice<byte> IIBFEEFLDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int MJANOEGPNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Matrix4x4 GOHJAFDMONE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool ENDLCJFPLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int ONIIPABFNNN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const int CGMMGHOPMGN = 1;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int ACLMDGNEOPB = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector3> JODOCBMAIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> GECKAMMBAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<Vector3> EHDNIIKEAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<Vector4> ABNEAPOHDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<Vector2> HOCMBLHNHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<Vector2> KHEDOFPLEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<Vector2> POOLDOACBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<Vector2> IJNOIJOCEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<Color> OJFMDMMLHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<BoneWeight> MLGNANGNCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<int> HEHLCJFOJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<int> NKMLJECIMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> DOBIJEFDPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<Matrix4x4> GCPPFGBCHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> PFIEACPCPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> GKOIADDLHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> MFHPICJPJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeArray<Matrix4x4> MPCNHAIKCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NativeArray<byte> KEBCIEHOGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> GENDNPPFLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeArray<int> BPLOHONIKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> ELNGOFDBGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<sbyte> IHJMGDDEGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<int> ADFFONBOHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<int> MHGPGAEEJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<byte> NLHMLLDCKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const int MGBIDPGIJLG = 0;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private const int AHKKOEOLADD = 1;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private const int JBCHOFMCAKN = 2;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private const int JGEJBNAKDOP = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<int> IIBKFNKBFIL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OOFCNABAFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EA92F0", Offset = "0x6EA82F0", VA = "0x186EA92F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EA97A0", Offset = "0x6EA87A0", VA = "0x186EA97A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NMLADPPDBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9780", Offset = "0x6EA8780", VA = "0x186EA9780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EA92E0", Offset = "0x6EA82E0", VA = "0x186EA92E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AGDCCMHFBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9790", Offset = "0x6EA8790", VA = "0x186EA9790")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EA97B0", Offset = "0x6EA87B0", VA = "0x186EA97B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EDPHHFKKGGJ OOHPEEDNNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9300", Offset = "0x6EA8300", VA = "0x186EA9300")]
		get
		{
			return default(EDPHHFKKGGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9E20", Offset = "0x6EA8E20", VA = "0x186EA9E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private PPNGGGFJGEE CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA97C0", Offset = "0x6EA87C0", VA = "0x186EA97C0")]
		get
		{
			return default(PPNGGGFJGEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9E30", Offset = "0x6EA8E30", VA = "0x186EA9E30")]
	public HHNHCPHEMOM(IList<Mesh> DNFNKHHLIKB, IList<int> OOGIPJBOMKM, IList<int> EGAEDDBCEFH, IList<int[]> KLPNIIMKGNJ, IList<Matrix4x4> CHLJMJDIJGP, IList<bool> LMNGBPJKHIE, IList<int> ICOJMEMNJLJ, Allocator HFHMLIPGBBB, EDPHHFKKGGJ BOLCNAGFOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9310", Offset = "0x6EA8310", VA = "0x186EA9310")]
	public AGHCKMMEDEC DCLFHHDNAMI(int OJCMOPHHGLB, Allocator HFHMLIPGBBB)
	{
		return default(AGHCKMMEDEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9500", Offset = "0x6EA8500", VA = "0x186EA9500", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[NativeContainer]
public struct AGHCKMMEDEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Vector3> JODOCBMAIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<Vector3> EHDNIIKEAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public NativeArray<Vector4> ABNEAPOHDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public NativeArray<Vector2> HOCMBLHNHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public NativeArray<Vector2> KHEDOFPLEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public NativeArray<Vector2> POOLDOACBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public NativeArray<Vector2> IJNOIJOCEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<Color> OJFMDMMLHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<BoneWeight> MLGNANGNCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeArray<Matrix4x4> GCPPFGBCHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public NativeArray<int> GKOIADDLHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> FIKPOPBKHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> JAOJAMCAKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> IIBKFNKBFIL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EJEOOOFNHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7B10", Offset = "0x6EA6B10", VA = "0x186EA7B10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7C80", Offset = "0x6EA6C80", VA = "0x186EA7C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7D80", Offset = "0x6EA6D80", VA = "0x186EA7D80")]
	public AGHCKMMEDEC(int OLBHCKCKPHO, int EOMIABBJJGK, int IHJGPGCHGMB, int OJCMOPHHGLB, Allocator HFHMLIPGBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7E40", Offset = "0x6EA6E40", VA = "0x186EA7E40")]
	public AGHCKMMEDEC(int OLBHCKCKPHO, int EOMIABBJJGK, int IHJGPGCHGMB, int OJCMOPHHGLB, Allocator HFHMLIPGBBB, bool[] MNDAOPGHJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7C90", Offset = "0x6EA6C90", VA = "0x186EA7C90")]
	public void OJKIBJBIGCE(int FKBJPNJMKDH, int FCCAKNLHEPE, int PKGBKHCIKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7BC0", Offset = "0x6EA6BC0", VA = "0x186EA7BC0")]
	public int[] MIHFADFKHEA(int FKBJPNJMKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7B20", Offset = "0x6EA6B20", VA = "0x186EA7B20")]
	private NativeSlice<int> KPNEAENOGOD(int FKBJPNJMKDH)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EA76F0", Offset = "0x6EA66F0", VA = "0x186EA76F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7860", Offset = "0x6EA6860", VA = "0x186EA7860")]
	public Mesh KCAENDBCGEO([Optional] string OGLIIEBGBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HKLGFAKGKCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<Mesh> CCKINHLIIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<int> OHOMFBEBPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private List<bool> LKCBPBIPMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private List<int[]> BNKIIHDJOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<Matrix4x4> DMIHIDOHPNG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EABAA0", Offset = "0x6EAAAA0", VA = "0x186EABAA0")]
	public void GGLKFJEINMF(Mesh CAFDMHFNNHI, int[] CCKLKLJLDLN, Matrix4x4 NBONJDFJCLI, bool LMNGBPJKHIE = false, int CMNODIENJHC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB970", Offset = "0x6EAA970", VA = "0x186EAB970")]
	public HHNHCPHEMOM EJOKIDBHGOL(Allocator HFHMLIPGBBB, HHNHCPHEMOM.EDPHHFKKGGJ BOLCNAGFOCC, [Optional] IList<int> EGAEDDBCEFH, [Optional] IList<int> MDNGKMEPCAF)
	{
		return default(HHNHCPHEMOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB830", Offset = "0x6EAA830", VA = "0x186EAB830")]
	private void DPDKBDADPFJ(Mesh CAFDMHFNNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EABD00", Offset = "0x6EAAD00", VA = "0x186EABD00")]
	public HKLGFAKGKCG()
	{
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, HDEBGJDAOOP
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
		private static readonly int JHMODHEKGCB;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6EABFD0", Offset = "0x6EAAFD0", VA = "0x186EABFD0")]
		private void ADCPOFMNGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6EAC120", Offset = "0x6EAB120", VA = "0x186EAC120")]
		private void MNCKPFFCIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6EAC270", Offset = "0x6EAB270", VA = "0x186EAC270")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6EAC200", Offset = "0x6EAB200", VA = "0x186EAC200", Slot = "4")]
		public void PrepareImposter(DEMPFPLJFKJ BPFIFAEKGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x18727C0", Offset = "0x18717C0", VA = "0x1818727C0")]
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
		private Light CBCPFBPAMNL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Light BHPCDDFEEIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6EAE660", Offset = "0x6EAD660", VA = "0x186EAE660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE4E0", Offset = "0x6EAD4E0", VA = "0x186EAE4E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE610", Offset = "0x6EAD610", VA = "0x186EAE610")]
		public ParticleScriptedLight()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OCJBLHLMOCK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NMIFHPPMHIM GPDFNAMLNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NMIFHPPMHIM> COKOPCFGLKB;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDLNOINAIPG();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum NMIFHPPMHIM
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
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
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
		public delegate void PJLNKDIBDIK(ParticleEventListener HMEDGJPMOLD, Collider BKLMLPFOMCO, IEnumerable<ParticleCollisionEvent> JHAJFJABDDL);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> LDEIGDGBKIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PJLNKDIBDIK DAHCPAMIDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6EAD4F0", Offset = "0x6EAC4F0", VA = "0x186EAD4F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6EAD590", Offset = "0x6EAC590", VA = "0x186EAD590")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EAD150", Offset = "0x6EAC150", VA = "0x186EAD150")]
		private void OnParticleCollision(GameObject BKLMLPFOMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public ParticleEventListener()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OKPHJBLLCMI
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AOLGIMNIFGG<T> : OKPHJBLLCMI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PAMDDIMCCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T BKENCJLPCKN);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class ActivationController : MonoBehaviour, OKPHJBLLCMI
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum FFKCFGGCJJA
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
		[OKAEPIMCOGM("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected virtual FFKCFGGCJJA NBNJPNKDACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "4")]
			get
			{
				return default(FFKCFGGCJJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x10DC4D0", Offset = "0x10DB4D0", VA = "0x1810DC4D0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class ActivationController<T> : ActivationController, AOLGIMNIFGG<T>, OKPHJBLLCMI where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		protected bool? IDJFDNGKCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		protected T JKMOGNFAAKI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PAMDDIMCCML
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x40D2350", Offset = "0x40D1350", VA = "0x1840D2350", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x40D1FF0", Offset = "0x40D0FF0", VA = "0x1840D1FF0", Slot = "7")]
		public virtual void SetActivation(T BKENCJLPCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool GELAFNGABEF(T BKENCJLPCKN);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void NDMIADFPMNH(bool FCDFGHDJJJC);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x40D22D0", Offset = "0x40D12D0", VA = "0x1840D22D0")]
		protected ActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EAIJKGBJCKB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color IFAEOGGHLKI);
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
		private List<Material> KOCALLMMFDG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject FAMICBLAKNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8250", Offset = "0x6EA7250", VA = "0x186EA8250")]
		public void Init(BackgroundObject HPPLDHGJPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8500", Offset = "0x6EA7500", VA = "0x186EA8500")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8620", Offset = "0x6EA7620", VA = "0x186EA8620")]
		public void SetBlendValue(float JNNDNAANOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8770", Offset = "0x6EA7770", VA = "0x186EA8770")]
		public void SetColor(Color IFAEOGGHLKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8880", Offset = "0x6EA7880", VA = "0x186EA8880")]
		public void SetRotation(float NMKLOHCPMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8A10", Offset = "0x6EA7A10", VA = "0x186EA8A10")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CFCIEPINLIG
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
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EAEF10", Offset = "0x6EADF10", VA = "0x186EAEF10")]
		public bool IIBOJDGADEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF050", Offset = "0x6EAE050", VA = "0x186EAF050")]
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
		[OKAEPIMCOGM("UseSpacePartition")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("If true, the StaticBatcher will not generate batches that only contain 1 Renderer. Disabling this can be useful for debugging why certain objects cannot batch. This setting does not affect LOD groups: batches of 1 LOD group are never created.")]
		public bool RemoveBatchesOfOneRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEEF0", Offset = "0x6EADEF0", VA = "0x186EAEEF0")]
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
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE910", Offset = "0x6EAD910", VA = "0x186EAE910", Slot = "10")]
		protected override LightRenderingMode GGFAOCFCIBH(IRecRoomQualityConfigProvider GMNEGCALHOD)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE900", Offset = "0x6EAD900", VA = "0x186EAE900", Slot = "8")]
		protected override bool GELAFNGABEF(LightRenderingMode LFOBFCBEHJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE970", Offset = "0x6EAD970", VA = "0x186EAE970")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEA90", Offset = "0x6EADA90", VA = "0x186EAEA90", Slot = "10")]
		protected override TransparencyDetailLevel GGFAOCFCIBH(IRecRoomQualityConfigProvider GMNEGCALHOD)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEA70", Offset = "0x6EADA70", VA = "0x186EAEA70", Slot = "8")]
		protected override bool GELAFNGABEF(TransparencyDetailLevel LFOBFCBEHJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEAE0", Offset = "0x6EADAE0", VA = "0x186EAEAE0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
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

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE9D0", Offset = "0x6EAD9D0", VA = "0x186EAE9D0", Slot = "10")]
		protected override SceneDecorationDetailLevel GGFAOCFCIBH(IRecRoomQualityConfigProvider GMNEGCALHOD)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE9B0", Offset = "0x6EAD9B0", VA = "0x186EAE9B0", Slot = "8")]
		protected override bool GELAFNGABEF(SceneDecorationDetailLevel LFOBFCBEHJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEA20", Offset = "0x6EADA20", VA = "0x186EAEA20")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private enum EAJGCAOENJN
		{
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private EAJGCAOENJN behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE750", Offset = "0x6EAD750", VA = "0x186EAE750", Slot = "10")]
		protected override bool GGFAOCFCIBH(IRecRoomQualityConfigProvider GMNEGCALHOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE730", Offset = "0x6EAD730", VA = "0x186EAE730", Slot = "8")]
		protected override bool GELAFNGABEF(bool LFOBFCBEHJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE7A0", Offset = "0x6EAD7A0", VA = "0x186EAE7A0")]
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

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
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
		private Terrain FJEAOEOPACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TerrainData IHJCLOGMEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TerrainData LDLEAMIDEHL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Terrain FPGIJBPLAHE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6EAF6D0", Offset = "0x6EAE6D0", VA = "0x186EAF6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF0D0", Offset = "0x6EAE0D0", VA = "0x186EAF0D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF860", Offset = "0x6EAE860", VA = "0x186EAF860")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF780", Offset = "0x6EAE780", VA = "0x186EAF780")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF770", Offset = "0x6EAE770", VA = "0x186EAF770")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF1F0", Offset = "0x6EAE1F0", VA = "0x186EAF1F0")]
		private void IJFGOGDIJDJ(NMIFHPPMHIM IJEOPICCBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF9B0", Offset = "0x6EAE9B0", VA = "0x186EAF9B0", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel HBCEPIILDHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x865E70", Offset = "0x864E70", VA = "0x180865E70", Slot = "8")]
		protected override bool GELAFNGABEF(TerrainQualityLevel BKENCJLPCKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "9")]
		protected override void NDMIADFPMNH(bool FCDFGHDJJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF170", Offset = "0x6EAE170", VA = "0x186EAF170")]
		private void DEFHCEIJNLA(Settings GGPFDHMAKNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF280", Offset = "0x6EAE280", VA = "0x186EAF280")]
		private void KPAAAMKMJMD(TreePrefabOverride[] AANDEMIALKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF5E0", Offset = "0x6EAE5E0", VA = "0x186EAF5E0")]
		private void LFICNMLODPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF560", Offset = "0x6EAE560", VA = "0x186EAF560")]
		private Settings LACEGAOOBOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFB80", Offset = "0x6EAEB80", VA = "0x186EAFB80")]
		public TerrainQualitySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private bool BCIFAACHGOB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override FFKCFGGCJJA NBNJPNKDACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86EB10", VA = "0x18086FB10", Slot = "4")]
			get
			{
				return default(FFKCFGGCJJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8E20", Offset = "0x6EA7E20", VA = "0x186EA8E20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8F40", Offset = "0x6EA7F40", VA = "0x186EA8F40")]
		private void OOKNJEKHGFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9180", Offset = "0x6EA8180", VA = "0x186EA9180")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6EA90A0", Offset = "0x6EA80A0", VA = "0x186EA90A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8E40", Offset = "0x6EA7E40", VA = "0x186EA8E40")]
		private void HOCEOODNLPI(NMIFHPPMHIM IJEOPICCBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8E30", Offset = "0x6EA7E30", VA = "0x186EA8E30", Slot = "8")]
		protected override bool GELAFNGABEF(bool LFOBFCBEHJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8ED0", Offset = "0x6EA7ED0", VA = "0x186EA8ED0", Slot = "9")]
		protected override void NDMIADFPMNH(bool FCDFGHDJJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6EA91B0", Offset = "0x6EA81B0", VA = "0x186EA91B0")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEBC0", Offset = "0x6EADBC0", VA = "0x186EAEBC0", Slot = "8")]
		protected override bool GELAFNGABEF(BackgroundAnimationDetailLevel BKENCJLPCKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEC60", Offset = "0x6EADC60", VA = "0x186EAEC60", Slot = "9")]
		protected override void NDMIADFPMNH(bool MHCBMAAPDGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEB30", Offset = "0x6EADB30", VA = "0x186EAEB30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EAECF0", Offset = "0x6EADCF0", VA = "0x186EAECF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6EAED80", Offset = "0x6EADD80", VA = "0x186EAED80")]
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
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x13A670", Offset = "0x139A70")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private bool NFNNPCJPNCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int LAHBKAMAIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool KBLEKILAKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private bool OJGKPEEHLIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float DNLDHHBEINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float IHHCAAJDLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private float FHAOLCHPKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private float GGOFIKEBFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private float AJMEDNOONEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private float APFDBFGEGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ParticleSystem.MainModule GMJDKDNODHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private ParticleSystem.TrailModule MBIFALCMNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private ParticleSystem.EmissionModule NNHNEGHEHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private ParticleSystem.CollisionModule MGPANMLDEEJ;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE350", Offset = "0x6EAD350", VA = "0x186EAE350")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE270", Offset = "0x6EAD270", VA = "0x186EAE270")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6EAD630", Offset = "0x6EAC630", VA = "0x186EAD630")]
		private void HOCEOODNLPI(NMIFHPPMHIM IJEOPICCBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6EAD7D0", Offset = "0x6EAC7D0", VA = "0x186EAD7D0")]
		private void JPMOBNIGMHC(IRecRoomQualityConfigProvider LCFBHAKNLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6EADED0", Offset = "0x6EACED0", VA = "0x186EADED0")]
		private void MIIFFEALEIF(OverrideSettings PPJJAFMAMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6EADB60", Offset = "0x6EACB60", VA = "0x186EADB60")]
		private void KOHDCKLKEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6EADD10", Offset = "0x6EACD10", VA = "0x186EADD10")]
		private void MEJEAJMAFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6EAD690", Offset = "0x6EAC690", VA = "0x186EAD690")]
		private void JOPIDAKBGEC(ParticleSystem.MinMaxCurve ADJCAOODMOM, out float NDEEDMIJFMP, out float INNGLEGFBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE120", Offset = "0x6EAD120", VA = "0x186EAE120")]
		private ParticleSystem.MinMaxCurve NEKEGODKBBG(ParticleSystem.MinMaxCurve ADJCAOODMOM, float NDEEDMIJFMP, float INNGLEGFBCM)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected override FFKCFGGCJJA NBNJPNKDACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86EB10", VA = "0x18086FB10", Slot = "4")]
			get
			{
				return default(FFKCFGGCJJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T GGFAOCFCIBH(IRecRoomQualityConfigProvider GMNEGCALHOD);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x411B590", Offset = "0x411A590", VA = "0x18411B590")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x411BA80", Offset = "0x411AA80", VA = "0x18411BA80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x411BA10", Offset = "0x411AA10", VA = "0x18411BA10")]
		private void HOCEOODNLPI(NMIFHPPMHIM IJEOPICCBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x411B890", Offset = "0x411A890", VA = "0x18411B890")]
		private void FJIOFMHPNBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x411BA40", Offset = "0x411AA40", VA = "0x18411BA40", Slot = "9")]
		protected override void NDMIADFPMNH(bool FCDFGHDJJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x21837C0", Offset = "0x21827C0", VA = "0x1821837C0")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private enum GPMOOPOMIBM
		{
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private GPMOOPOMIBM behavior;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE870", Offset = "0x6EAD870", VA = "0x186EAE870", Slot = "10")]
		protected override bool GGFAOCFCIBH(IRecRoomQualityConfigProvider GMNEGCALHOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE730", Offset = "0x6EAD730", VA = "0x186EAE730", Slot = "8")]
		protected override bool GELAFNGABEF(bool LFOBFCBEHJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE8C0", Offset = "0x6EAD8C0", VA = "0x186EAE8C0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class EFAHLKDNGAN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA91F0", Offset = "0x6EA81F0", VA = "0x186EA91F0")]
	[FBCFLFBFGIL(LAFFCBAHJKM.None)]
	private static void HEBPGFNGBNI(CNALHHIKJDD DBGHBAHCJKO)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private enum BIJFJBJMKJE
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private BIJFJBJMKJE behavior;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE7E0", Offset = "0x6EAD7E0", VA = "0x186EAE7E0", Slot = "10")]
		protected override bool GGFAOCFCIBH(IRecRoomQualityConfigProvider GMNEGCALHOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE730", Offset = "0x6EAD730", VA = "0x186EAE730", Slot = "8")]
		protected override bool GELAFNGABEF(bool LFOBFCBEHJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE830", Offset = "0x6EAD830", VA = "0x186EAE830")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
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
