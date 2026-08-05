using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Platforms;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum PCOADBNOGMP
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
	private PCOADBNOGMP bobAxis;

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
	private float EAGOCIKNODH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 CCHEMNNOEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x774EB00", Offset = "0x774DF00", VA = "0x18774EB00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x774EAC0", Offset = "0x774DEC0", VA = "0x18774EAC0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x774ECE0", Offset = "0x774E0E0", VA = "0x18774ECE0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x774EF10", Offset = "0x774E310", VA = "0x18774EF10")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x11FEF00", Offset = "0x11FE300", VA = "0x1811FEF00")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, LHMPAHMHMOI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string IIIEMHDGLCF = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string DKCGJPBHNJM = "_MainColor";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[Tooltip("List of Renderers to increase color alpha")]
	[SerializeField]
	private List<Renderer> imposterRenderers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Range(0f, 1f)]
	private float imposterAlpha;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static List<Material> FIBILGHNAEJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> BFNAOLCMGKG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	public void PrepareImposter(PEMKIPDCGBE NFHKMOGHIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7753940", Offset = "0x7752D40", VA = "0x187753940")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ExecuteInEditMode]
[UnityEngine.Scripting.Preserve]
public class InstancedMeshGroup : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[FormerlySerializedAs("me")]
	public Mesh mesh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[FormerlySerializedAs("ma")]
	public Material material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[FormerlySerializedAs("trs")]
	public Matrix4x4[] MatricesTRS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Component[] componentsToHide;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7753DA0", Offset = "0x77531A0", VA = "0x187753DA0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7753E40", Offset = "0x7753240", VA = "0x187753E40")]
	public void initialize(Mesh GOGOGMHAIIP, Material OAFHNKHFHLI, Matrix4x4[] PBEFFIKLIMN, Component[] CEGNCHJMJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
	public InstancedMeshGroup()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
[NativeContainer]
public struct GGOMCBNDEOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum GPKKNKNMHOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		CollapseSubMeshes,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		CollapseToUniqueMaterials,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		MergeAll
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct GLGPDCDHKGG : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[ReadOnly]
		public GGOMCBNDEOH HCMOMCFCBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[ReadOnly]
		public int DIKEKINGDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public NBEFMOHOLIG NDAODKPHKFC;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7752B10", Offset = "0x7751F10", VA = "0x187752B10", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct LALOFABGKFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeSlice<Vector3> CPJGKODLBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NativeSlice<Vector3> MAMCGDFCNNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector4> LHKODGKOJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector2> GKHHECOGPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector2> JHMJFOGKPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> IFPOONMEPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> EKCAHOKLMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Color> GMBJEHONJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<BoneWeight> COJMFNFEADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Matrix4x4> IMLEKONOKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<int> CMPGDMFHOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<int> LJLNLDBOGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> DFFCOFHPOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> BHGKAANICFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<byte> DJJEEFGGNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int CABGDJNIOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Matrix4x4 MNBOGMCEECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool OLINMMLHLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int JINHJKOHAPB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> CPJGKODLBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<int> GLPGEHAFAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector3> MAMCGDFCNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector4> LHKODGKOJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> GKHHECOGPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> JHMJFOGKPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Vector2> IFPOONMEPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector2> EKCAHOKLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<Color> GMBJEHONJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<BoneWeight> COJMFNFEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> BHGKAANICFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> ODADMDEBGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> KHHFJNLHGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<Matrix4x4> IMLEKONOKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> LCLODDGIFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> CMPGDMFHOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> LDEIEHOKHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<Matrix4x4> MLIBKIBJBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<byte> GPAFIPBKGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> GDMPGKOBCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<int> OJHKOFBINMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> HOHONNDIEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<sbyte> JFGGMOAAOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> IJGBEPGGOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> EMNIAMPADOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<byte> BALJPGAKNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> CCBEBJGPMON;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GDJAJFFMKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7750930", Offset = "0x774FD30", VA = "0x187750930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77511B0", Offset = "0x77505B0", VA = "0x1877511B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BACPJGLNGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77507E0", Offset = "0x774FBE0", VA = "0x1877507E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7750920", Offset = "0x774FD20", VA = "0x187750920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ANGJLMICBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77511C0", Offset = "0x77505C0", VA = "0x1877511C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77511D0", Offset = "0x77505D0", VA = "0x1877511D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GPKKNKNMHOI DJPONGIFIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7750BC0", Offset = "0x774FFC0", VA = "0x187750BC0")]
		get
		{
			return default(GPKKNKNMHOI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77511E0", Offset = "0x77505E0", VA = "0x1877511E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LALOFABGKFN PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7750BD0", Offset = "0x774FFD0", VA = "0x187750BD0")]
		get
		{
			return default(LALOFABGKFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77511F0", Offset = "0x77505F0", VA = "0x1877511F0")]
	public GGOMCBNDEOH(IList<Mesh> OIDGKEJEOFD, IList<int> BILIDBMPJKB, IList<int> AJJFFBOJGHK, IList<int[]> HDPJCHIHNAA, IList<Matrix4x4> AIKLKKHNHNL, IList<bool> BACJLOEEGNA, IList<int> PDHCPBKPKGO, Allocator LENIJMBFHJK, GPKKNKNMHOI NKAEGFFOLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x77507F0", Offset = "0x774FBF0", VA = "0x1877507F0")]
	public NBEFMOHOLIG AIPKGAKLOKF(int MLKHAOOPJCC, Allocator LENIJMBFHJK)
	{
		return default(NBEFMOHOLIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7750940", Offset = "0x774FD40", VA = "0x187750940", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
public struct NBEFMOHOLIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<Vector3> CPJGKODLBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeArray<Vector3> MAMCGDFCNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector4> LHKODGKOJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector2> GKHHECOGPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector2> JHMJFOGKPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> IFPOONMEPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> EKCAHOKLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Color> GMBJEHONJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<BoneWeight> COJMFNFEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Matrix4x4> IMLEKONOKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> CMPGDMFHOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private NativeArray<int> LJLNLDBOGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private NativeArray<int> DFFCOFHPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> CCBEBJGPMON;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CCABOFCOKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7754B60", Offset = "0x7753F60", VA = "0x187754B60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x77546A0", Offset = "0x7753AA0", VA = "0x1877546A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7754C20", Offset = "0x7754020", VA = "0x187754C20")]
	public NBEFMOHOLIG(int CLMLOOPKKFK, int OBMELHCGDFF, int OLCOGNMFEID, int MLKHAOOPJCC, Allocator LENIJMBFHJK, bool[] GPPHJCPHDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77545D0", Offset = "0x77539D0", VA = "0x1877545D0")]
	public void ALAMKCGEEOK(int GNEIJJMEKIN, int NPELPNMIGOA, int GHDAIPOHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7754B70", Offset = "0x7753F70", VA = "0x187754B70")]
	public int[] OHCGKEDJDLE(int GNEIJJMEKIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7754820", Offset = "0x7753C20", VA = "0x187754820")]
	private NativeSlice<int> ECGMJFCGMLF(int GNEIJJMEKIN)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77546B0", Offset = "0x7753AB0", VA = "0x1877546B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77548B0", Offset = "0x7753CB0", VA = "0x1877548B0")]
	public Mesh GKOEDMEMMFC([Optional] string POBGIKONEEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ENMNABNLDGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<Mesh> PNNHNHLJGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<int> GHMGACHBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<bool> BOLFJEJKMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int[]> KEPPDHLHONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Matrix4x4> EPPLPMCODIJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7750100", Offset = "0x774F500", VA = "0x187750100")]
	public void GKIFFLFABEH(Mesh CNCBOAAEMAB, int[] CBAFADMGFHH, Matrix4x4 MHENGEAEJHL, bool BACJLOEEGNA = false, int IMMNIBIAAHO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7750050", Offset = "0x774F450", VA = "0x187750050")]
	public GGOMCBNDEOH CCLKJNICOOA(Allocator LENIJMBFHJK, GGOMCBNDEOH.GPKKNKNMHOI NKAEGFFOLJG, [Optional] IList<int> AJJFFBOJGHK, [Optional] IList<int> OMCFEBBMLDE)
	{
		return default(GGOMCBNDEOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77503C0", Offset = "0x774F7C0", VA = "0x1877503C0")]
	private static void JJNPCMFKMMG(Mesh CNCBOAAEMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7750620", Offset = "0x774FA20", VA = "0x187750620")]
	public ENMNABNLDGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RequireComponent(typeof(ParticleSystem))]
[DisallowMultipleComponent]
public class ParticleSystemTextureStreamerTag : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x77566C0", Offset = "0x7755AC0", VA = "0x1877566C0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
	public ParticleSystemTextureStreamerTag()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	private NCOIGLKDCJA playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NCOIGLKDCJA NDAFAGPBHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0")]
		get
		{
			return default(NCOIGLKDCJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C3F0", Offset = "0x6C2B7F0", VA = "0x186C2C3F0")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Obsolete("Use the ScreenshotGeneratorWindow instead")]
[RequireComponent(typeof(Camera))]
public class ScreenshotGenerator : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x77569E0", Offset = "0x7755DE0", VA = "0x1877569E0")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NGIECPOLHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7757090", Offset = "0x7756490", VA = "0x187757090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
	public ShippingContainer()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Content_Authoring_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7758200", Offset = "0x7757600", VA = "0x187758200", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GJBJLMJBGLF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DBOIPMKICLD NAKMJFCFDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OHMOKFGANBG<DBOIPMKICLD> MHLEMJLOOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum DBOIPMKICLD
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Count
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(Light))]
	[ExecuteInEditMode]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private Light AIINCJOHPJC;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Light KBKHPPAKJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7756630", Offset = "0x7755A30", VA = "0x187756630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77564C0", Offset = "0x77558C0", VA = "0x1877564C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77565E0", Offset = "0x77559E0", VA = "0x1877565E0")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, LHMPAHMHMOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[HideInInspector]
		[SerializeField]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly int GLEEFGIKLOL;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7753AA0", Offset = "0x7752EA0", VA = "0x187753AA0")]
		private void HJILODOODPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77539D0", Offset = "0x7752DD0", VA = "0x1877539D0")]
		private void AANMEDBGNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7753C40", Offset = "0x7753040", VA = "0x187753C40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7753BD0", Offset = "0x7752FD0", VA = "0x187753BD0", Slot = "4")]
		public void PrepareImposter(PEMKIPDCGBE NFHKMOGHIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public InstanceColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class MaterialInstance : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Renderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7753FB0", Offset = "0x77533B0", VA = "0x187753FB0")]
		public void ClearProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7754080", Offset = "0x7753480", VA = "0x187754080")]
		public void SetColor(string MPGDCPPMNJN, Color FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7754190", Offset = "0x7753590", VA = "0x187754190")]
		public void SetFloat(string MPGDCPPMNJN, float FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77544C0", Offset = "0x77538C0", VA = "0x1877544C0")]
		public void SetVector(string MPGDCPPMNJN, Vector4 FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7754390", Offset = "0x7753790", VA = "0x187754390")]
		public void SetVector(string MPGDCPPMNJN, float JFJPEDLJOKC, float MJINJIJLGDP, float PCPOJEKHENA, float FIMFKJDMEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7754290", Offset = "0x7753690", VA = "0x187754290")]
		public void SetTexture(string MPGDCPPMNJN, Texture2D FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public MaterialInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DPLCGBCDCGB
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetDesiredMipLevel();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ABDMMKPHNAD
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKIPFBBHLIE(DPLCGBCDCGB JKOHEIKBEKI, Texture2D HLPGJNCKNML);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJDMPANOFFH(DPLCGBCDCGB JKOHEIKBEKI, Texture2D HLPGJNCKNML);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNKFNPGCLLO(ParticleSystem CEJCKKCMMBE);
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public delegate void IIMOADJFPKE(ParticleEventListener JDJFEKKOFGG, Collider JAPIEEBOJEA, IEnumerable<ParticleCollisionEvent> GFMHMHCONAP);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> OBNAEGGAELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event IIMOADJFPKE ACPOAELAAOA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7755370", Offset = "0x7754770", VA = "0x187755370")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7755410", Offset = "0x7754810", VA = "0x187755410")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7755010", Offset = "0x7754410", VA = "0x187755010")]
		private void OnParticleCollision(GameObject JAPIEEBOJEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[GOMCBKCIINJ("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("If true, the StaticBatcher will not generate batches that only contain 1 Renderer. Disabling this can be useful for debugging why certain objects cannot batch. This setting does not affect LOD groups: batches of 1 LOD group are never created.")]
		public bool RemoveBatchesOfOneRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77571A0", Offset = "0x77565A0", VA = "0x1877571A0")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77571C0", Offset = "0x77565C0", VA = "0x1877571C0")]
		public bool POGAJBJPHNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x77572E0", Offset = "0x77566E0", VA = "0x1877572E0")]
		public StaticBatchMeshData()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool PDIDINEJIBO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override DADIEJJCMAI OGKAONDOJNH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xB1EC30", Offset = "0xB1E030", VA = "0x180B1EC30", Slot = "4")]
			get
			{
				return default(DADIEJJCMAI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x774FBF0", Offset = "0x774EFF0", VA = "0x18774FBF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x774FC00", Offset = "0x774F000", VA = "0x18774FC00")]
		private void LJLAMKLIJDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x774FFE0", Offset = "0x774F3E0", VA = "0x18774FFE0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x774FE10", Offset = "0x774F210", VA = "0x18774FE10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x774FF30", Offset = "0x774F330", VA = "0x18774FF30")]
		private void PHOHKFFPGCC(DBOIPMKICLD GFOMFMOGDGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1C2EB90", Offset = "0x1C2DF90", VA = "0x181C2EB90", Slot = "7")]
		protected override bool PAPIBBHPAOA(bool GKLMFADODAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x774FDA0", Offset = "0x774F1A0", VA = "0x18774FDA0", Slot = "8")]
		protected override void MJLILPAMEJD(bool KCFAOKHKJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7750010", Offset = "0x774F410", VA = "0x187750010")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool BPNFJPKDMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int BBFLEBFMPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool LIKGLAEKMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool FOEOJNONMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float OHDFOFAFMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float LOEFMHFFLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float FFHLFJEGBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float FLLLJLIJCMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float KMDPEFIKOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float CNDGFIINCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.MainModule EBNPGAFHCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ParticleSystem.TrailModule HJMAJNGPKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ParticleSystem.EmissionModule KFACGKEDAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ParticleSystem.CollisionModule IKKAKDICAJC;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7756300", Offset = "0x7755700", VA = "0x187756300")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7756170", Offset = "0x7755570", VA = "0x187756170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7756280", Offset = "0x7755680", VA = "0x187756280")]
		private void PHOHKFFPGCC(DBOIPMKICLD GFOMFMOGDGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7755990", Offset = "0x7754D90", VA = "0x187755990")]
		private void HPNNIHDGPBM(IRecRoomQualityConfigProvider EOPBDJJHJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x77555E0", Offset = "0x77549E0", VA = "0x1877555E0")]
		private void FCBGDFHEDIE(OverrideSettings ALBLHKMBBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7755FD0", Offset = "0x77553D0", VA = "0x187755FD0")]
		private void KPOGNNLJMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x77557F0", Offset = "0x7754BF0", VA = "0x1877557F0")]
		private void GDHOAPIEFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x77554B0", Offset = "0x77548B0", VA = "0x1877554B0")]
		private void CMKLFMHHOKH(ParticleSystem.MinMaxCurve OLDOLCAMILN, [Out] float PIJNBNPNLIL, [Out] float NFBKIHMLGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7755E90", Offset = "0x7755290", VA = "0x187755E90")]
		private ParticleSystem.MinMaxCurve IPFDBCDBLPB(ParticleSystem.MinMaxCurve OLDOLCAMILN, float PIJNBNPNLIL, float NFBKIHMLGLM)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override DADIEJJCMAI OGKAONDOJNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xB1EC30", Offset = "0xB1E030", VA = "0x180B1EC30", Slot = "4")]
			get
			{
				return default(DADIEJJCMAI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract T FLFAFIDIOCP(IRecRoomQualityConfigProvider DKPELJENLEG);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5343210", Offset = "0x5342610", VA = "0x185343210")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5343940", Offset = "0x5342D40", VA = "0x185343940")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5343B80", Offset = "0x5342F80", VA = "0x185343B80")]
		private void PHOHKFFPGCC(DBOIPMKICLD GFOMFMOGDGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5343740", Offset = "0x5342B40", VA = "0x185343740")]
		private void HMOGMFDDFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x53437E0", Offset = "0x5342BE0", VA = "0x1853437E0", Slot = "8")]
		protected override void MJLILPAMEJD(bool KCFAOKHKJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x41E6340", Offset = "0x41E5740", VA = "0x1841E6340")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class ACCEAEAKIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x774E120", Offset = "0x774D520", VA = "0x18774E120")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void KDIILJNJDKF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private enum BIJCDGMKAMM
		{
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private BIJCDGMKAMM behavior;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7756A00", Offset = "0x7755E00", VA = "0x187756A00", Slot = "9")]
		protected override bool FLFAFIDIOCP(IRecRoomQualityConfigProvider DKPELJENLEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7756A50", Offset = "0x7755E50", VA = "0x187756A50", Slot = "7")]
		protected override bool PAPIBBHPAOA(bool GKLMFADODAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7756A70", Offset = "0x7755E70", VA = "0x187756A70")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private enum JDBPFHOBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private JDBPFHOBCAO behavior;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7756AB0", Offset = "0x7755EB0", VA = "0x187756AB0", Slot = "9")]
		protected override bool FLFAFIDIOCP(IRecRoomQualityConfigProvider DKPELJENLEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7756A50", Offset = "0x7755E50", VA = "0x187756A50", Slot = "7")]
		protected override bool PAPIBBHPAOA(bool GKLMFADODAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7756B00", Offset = "0x7755F00", VA = "0x187756B00")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private enum NMIMPLOAAEF
		{
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private NMIMPLOAAEF behavior;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7756B40", Offset = "0x7755F40", VA = "0x187756B40", Slot = "9")]
		protected override bool FLFAFIDIOCP(IRecRoomQualityConfigProvider DKPELJENLEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7756A50", Offset = "0x7755E50", VA = "0x187756A50", Slot = "7")]
		protected override bool PAPIBBHPAOA(bool GKLMFADODAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7756B90", Offset = "0x7755F90", VA = "0x187756B90")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7756BD0", Offset = "0x7755FD0", VA = "0x187756BD0", Slot = "9")]
		protected override LightRenderingMode FLFAFIDIOCP(IRecRoomQualityConfigProvider DKPELJENLEG)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7756C30", Offset = "0x7756030", VA = "0x187756C30", Slot = "7")]
		protected override bool PAPIBBHPAOA(LightRenderingMode GKLMFADODAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7756C40", Offset = "0x7756040", VA = "0x187756C40")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7756C80", Offset = "0x7756080", VA = "0x187756C80", Slot = "9")]
		protected override SceneDecorationDetailLevel FLFAFIDIOCP(IRecRoomQualityConfigProvider DKPELJENLEG)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7756CD0", Offset = "0x77560D0", VA = "0x187756CD0", Slot = "7")]
		protected override bool PAPIBBHPAOA(SceneDecorationDetailLevel GKLMFADODAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7756CF0", Offset = "0x77560F0", VA = "0x187756CF0")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7756D30", Offset = "0x7756130", VA = "0x187756D30", Slot = "9")]
		protected override TransparencyDetailLevel FLFAFIDIOCP(IRecRoomQualityConfigProvider DKPELJENLEG)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7756D80", Offset = "0x7756180", VA = "0x187756D80", Slot = "7")]
		protected override bool PAPIBBHPAOA(TransparencyDetailLevel GKLMFADODAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7756DA0", Offset = "0x77561A0", VA = "0x187756DA0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7756FC0", Offset = "0x77563C0", VA = "0x187756FC0", Slot = "7")]
		protected override bool PAPIBBHPAOA(BackgroundAnimationDetailLevel CEJJLNGBNKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7756E90", Offset = "0x7756290", VA = "0x187756E90", Slot = "8")]
		protected override void MJLILPAMEJD(bool GIPGMKNGIBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7756DE0", Offset = "0x77561E0", VA = "0x187756DE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7756F10", Offset = "0x7756310", VA = "0x187756F10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7757050", Offset = "0x7756450", VA = "0x187757050")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static Dictionary<TerrainQualityLevel, Settings> CGKBBPLILLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Terrain HEDNHCOBODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private IRecRoomQualityConfigProvider JKGGABHJCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private GJBJLMJBGLF NMGFNOGPKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TerrainData JHJNDHIIDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TerrainData CMEDJLHLHGA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Terrain MDIPJDEDNHA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7757AE0", Offset = "0x7756EE0", VA = "0x187757AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7757370", Offset = "0x7756770", VA = "0x187757370")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7757C50", Offset = "0x7757050", VA = "0x187757C50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7757B80", Offset = "0x7756F80", VA = "0x187757B80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7757B70", Offset = "0x7756F70", VA = "0x187757B70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7757A80", Offset = "0x7756E80", VA = "0x187757A80")]
		private void EFGCLJDLIGO(DBOIPMKICLD GFOMFMOGDGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7757D60", Offset = "0x7757160", VA = "0x187757D60", Slot = "6")]
		public override void SetActivation(TerrainQualityLevel MNJCOCKPLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "7")]
		protected override bool PAPIBBHPAOA(TerrainQualityLevel CEJJLNGBNKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "8")]
		protected override void MJLILPAMEJD(bool KCFAOKHKJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7757570", Offset = "0x7756970", VA = "0x187757570")]
		private void CIEFJINLIDA(Settings JJJMCAHFNCD, TerrainQualityLevel MNJCOCKPLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x77577F0", Offset = "0x7756BF0", VA = "0x1877577F0")]
		private void ECHEEAIJDJP(TreePrefabOverride[] CEKNINAGLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x77574A0", Offset = "0x77568A0", VA = "0x1877574A0")]
		private void BLDMJLAGDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7757770", Offset = "0x7756B70", VA = "0x187757770")]
		private Settings DEAGKEPHDPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7758080", Offset = "0x7757480", VA = "0x187758080")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum NCOIGLKDCJA
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NCCFGDOEHFO
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color CKANMCILFBE);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private List<Material> CEGIHIOBJEI;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BackgroundObject KLHDBGKBALD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x774E220", Offset = "0x774D620", VA = "0x18774E220")]
		public void Init(BackgroundObject FAHGNPJKBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x774E470", Offset = "0x774D870", VA = "0x18774E470")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x774E590", Offset = "0x774D990", VA = "0x18774E590")]
		public void SetBlendValue(float LGGCPIJPOHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x774E700", Offset = "0x774DB00", VA = "0x18774E700")]
		public void SetColor(Color CKANMCILFBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x774E830", Offset = "0x774DC30", VA = "0x18774E830")]
		public void SetRotation(float BENMKDDDBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x774EA00", Offset = "0x774DE00", VA = "0x18774EA00")]
		public BackgroundObject()
		{
		}
	}
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class ActivationController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public enum DADIEJJCMAI
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		[GOMCBKCIINJ("OnSceneOrPrefabSaveBehavior", DADIEJJCMAI.EnableIfAllowed)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual DADIEJJCMAI OGKAONDOJNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "4")]
			get
			{
				return default(DADIEJJCMAI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class ActivationController<T> : ActivationController where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		protected bool? BHLNDCFGHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		protected T IGPGJCMNGGC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OLAAPBHMOAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x4D497F0", Offset = "0x4D48BF0", VA = "0x184D497F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4D49490", Offset = "0x4D48890", VA = "0x184D49490", Slot = "6")]
		public virtual void SetActivation(T CEJJLNGBNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool PAPIBBHPAOA(T CEJJLNGBNKN);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void MJLILPAMEJD(bool KCFAOKHKJOE);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2C0", Offset = "0x9AD6C0", VA = "0x1809AE2C0")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.CullableBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[UnityEngine.Scripting.Preserve]
	public class CullableBatchLOD : MonoBehaviour, LALFMDHBCFM
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public class BatchedRenderer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Renderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public bool visibleInBatch;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public bool Enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0x774EA90", Offset = "0x774DE90", VA = "0x18774EA90")]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public BatchedRenderer[] revealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public LODGroup[] revealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public BatchedRenderer[] nonRevealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public LODGroup[] nonRevealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		public int subMeshCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		public int startRenderableSubmshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		private GPKPAEJIOJM toggleBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Bounds AGLIMJBHAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Material KIEAKCEGOFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private BOCNGNOCJKI<CullableBatchLOD> KEPDMOAMLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private Mesh CNCBOAAEMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool PMCJJKIGPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private bool HIPMLKNDPMK;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x774F0C0", Offset = "0x774E4C0", VA = "0x18774F0C0")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x774F530", Offset = "0x774E930", VA = "0x18774F530")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x774EF20", Offset = "0x774E320", VA = "0x18774EF20")]
		private static float NBJDHCBDBEP(Vector3 BEIIOAKKNGJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x774F030", Offset = "0x774E430", VA = "0x18774F030")]
		public void SetContentsVisibility(bool AGOMBGDGLIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x774EF40", Offset = "0x774E340", VA = "0x18774EF40", Slot = "5")]
		public void OnChangedDistanceBand(GPKPAEJIOJM CIOPJANLAMG, GPKPAEJIOJM CKDFMHIEDPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "6")]
		public void OnChangedVisibility(bool BCMJICCFPOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x774EF70", Offset = "0x774E370", VA = "0x18774EF70")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x774F7C0", Offset = "0x774EBC0", VA = "0x18774F7C0")]
		public CullableBatchLOD()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9BAEB0", Offset = "0x9BA2B0", VA = "0x1809BAEB0", Slot = "4")]
		private Transform EGIFFAPEPGL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchLODMaterialData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Vector4[] baseColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Vector4[] specColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Vector4[] emissionColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Vector4[] halfProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Vector4[] secondaryTextureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[FormerlySerializedAs("renderer")]
		public MeshRenderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public CullableBatchLODMaterialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchShaderManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x774F7E0", Offset = "0x774EBE0", VA = "0x18774F7E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public CullableBatchShaderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[RecRoom.NoEngine.Common.Preserve]
	[ExecuteInEditMode]
	public class RunTimeTextureAtlasData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x77569A0", Offset = "0x7755DA0", VA = "0x1877569A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x77569A0", Offset = "0x7755DA0", VA = "0x1877569A0")]
		private void LPAMDLMONAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public RunTimeTextureAtlasData()
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
