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
	public enum AGINBMOHEHH
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
	private AGINBMOHEHH bobAxis;

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
	private float GDGDFMFDJOG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 FDJJNBGBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB880", Offset = "0x4EEAA80", VA = "0x184EEB880")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xB73750", Offset = "0xB72950", VA = "0x180B73750")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBA50", Offset = "0x4EEAC50", VA = "0x184EEBA50")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBBB0", Offset = "0x4EEADB0", VA = "0x184EEBBB0")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x92C7A0", Offset = "0x92B9A0", VA = "0x18092C7A0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, MKCBCLJGHMP
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string IOEJHDHNJAK = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string AGDFDGFGADM = "_MainColor";

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
	private static List<Material> FBAHIAHJGDM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> NNMGNFABAGI;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "4")]
	public void PrepareImposter(HPHDLMCLBBA KBKLLMLPIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4EED550", Offset = "0x4EEC750", VA = "0x184EED550")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct NGGMJACCNOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum DJFEGONCDMC
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
	public struct OMKLCEJIENM : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public NGGMJACCNOC HNADPKHAIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int CDNLMJMCCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public EGIMGDICNIO DPGFNCDJKCJ;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4EEFC30", Offset = "0x4EEEE30", VA = "0x184EEFC30", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct GOKKKLBCFMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> IMGLNFLCFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> KEJEAPHCAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> EDJFGJAAEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> LDHHNLLAMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> CCDEDAPIHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> DBLCNMENOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> FAANMDIOGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> FPFJFNCBPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> LCCLJKIAHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> MJHIJFAKNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> LGCLONPBDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> CFNNLHHOPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> ECMEHADBGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> OFDFCMDBIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> MKDNAFLBEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int HJONHKIGFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 BPMNNNMIJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool BJLDODLENND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int FJAJJIEHNMC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int NGGBHBCEENM = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int GMKKLMHDAHN = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> IMGLNFLCFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> BOHMPNGBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> KEJEAPHCAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> EDJFGJAAEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> LDHHNLLAMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> CCDEDAPIHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> DBLCNMENOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> FAANMDIOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> FPFJFNCBPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> LCCLJKIAHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> OFDFCMDBIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> JMENJKJACJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> ECHDMBOCBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> MJHIJFAKNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> OGJEGBHOAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> LGCLONPBDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> HIKCIIHOBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> FBFCEHJNPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> IIKDNLKBJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> AJKMJENIHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> GANFNPKGNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> ICCEHNIONCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> LIIPLGDNDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> LNADHGIMMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> MKPBGCLCCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> KJGPLMIMKGE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int HMANLBHMMBB = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int NJDCBOJIDHM = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int OGLHJGEFMGF = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int KPFDCCFMCCP = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> OGHAFELJJLO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HOABAKIGPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4EEE3A0", Offset = "0x4EED5A0", VA = "0x184EEE3A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4EEDD60", Offset = "0x4EECF60", VA = "0x184EEDD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JJNFMHBNDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4EEDD50", Offset = "0x4EECF50", VA = "0x184EEDD50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4EED9A0", Offset = "0x4EECBA0", VA = "0x184EED9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BHIBCNDIJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4EEE380", Offset = "0x4EED580", VA = "0x184EEE380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4EEE390", Offset = "0x4EED590", VA = "0x184EEE390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DJFEGONCDMC BCAHNPHOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4EEDD40", Offset = "0x4EECF40", VA = "0x184EEDD40")]
		get
		{
			return default(DJFEGONCDMC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4EED990", Offset = "0x4EECB90", VA = "0x184EED990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private GOKKKLBCFMC DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4EEDD70", Offset = "0x4EECF70", VA = "0x184EEDD70")]
		get
		{
			return default(GOKKKLBCFMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4EEE3B0", Offset = "0x4EED5B0", VA = "0x184EEE3B0")]
	public NGGMJACCNOC(IList<Mesh> PKGNHLFGHNE, IList<int> CJDIBENEGEA, IList<int> JJOBPBPEOJL, IList<int[]> ENFBAGHNAOH, IList<Matrix4x4> JEFAMPNEAPN, IList<bool> EAPLCNHPJHN, IList<int> MHLGIMJINLL, Allocator KLHFPJKGFHD, DJFEGONCDMC HJCBPCLNHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4EEDBD0", Offset = "0x4EECDD0", VA = "0x184EEDBD0")]
	public EGIMGDICNIO HCMEJKFOLBC(int LLHLBAFBFJN, Allocator KLHFPJKGFHD)
	{
		return default(EGIMGDICNIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4EED9B0", Offset = "0x4EECBB0", VA = "0x184EED9B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct EGIMGDICNIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> IMGLNFLCFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> KEJEAPHCAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> EDJFGJAAEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> LDHHNLLAMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> CCDEDAPIHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> DBLCNMENOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> FAANMDIOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> FPFJFNCBPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> LCCLJKIAHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> MJHIJFAKNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> LGCLONPBDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> CFNNLHHOPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> ECMEHADBGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> OGHAFELJJLO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CENAIJIDHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4EEC150", Offset = "0x4EEB350", VA = "0x184EEC150")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4EEC650", Offset = "0x4EEB850", VA = "0x184EEC650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4EECA40", Offset = "0x4EEBC40", VA = "0x184EECA40")]
	public EGIMGDICNIO(int GBCCBPLPFKL, int GPEBDPHCCBM, int CMBOEBHDPGE, int LLHLBAFBFJN, Allocator KLHFPJKGFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC660", Offset = "0x4EEB860", VA = "0x184EEC660")]
	public EGIMGDICNIO(int GBCCBPLPFKL, int GPEBDPHCCBM, int CMBOEBHDPGE, int LLHLBAFBFJN, Allocator KLHFPJKGFHD, bool[] NKGDNAOCCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC280", Offset = "0x4EEB480", VA = "0x184EEC280")]
	public void GMINCFKLDCC(int BOAFCJJCCGM, int CEEEAFDKEEP, int NOPNDNKKPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC090", Offset = "0x4EEB290", VA = "0x184EEC090")]
	public int[] BHLPHMJPCPL(int BOAFCJJCCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC360", Offset = "0x4EEB560", VA = "0x184EEC360")]
	private NativeSlice<int> GNADKKNNHLM(int BOAFCJJCCGM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC160", Offset = "0x4EEB360", VA = "0x184EEC160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC400", Offset = "0x4EEB600", VA = "0x184EEC400")]
	public Mesh IIEBDACPLKO([Optional] string LJINCIFOPMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HPJNOMHLJJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> DLJIGJHJHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> LFCPPMHHOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> IGHCNJBAGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> POCFKMJIIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> DBFOIMLEBCE;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4EED210", Offset = "0x4EEC410", VA = "0x184EED210")]
	public void PLKCEIGIBPA(Mesh KEEALIHEENC, int[] AIDBCLNPDIN, Matrix4x4 EFINEMCHAGA, bool EAPLCNHPJHN = false, int FAGPKNGNHNP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4EED160", Offset = "0x4EEC360", VA = "0x184EED160")]
	public NGGMJACCNOC KOPPFONAFFK(Allocator KLHFPJKGFHD, NGGMJACCNOC.DJFEGONCDMC HJCBPCLNHCO, [Optional] IList<int> JJOBPBPEOJL, [Optional] IList<int> BBGLPGMNBHE)
	{
		return default(NGGMJACCNOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4EED0E0", Offset = "0x4EEC2E0", VA = "0x184EED0E0")]
	private void EJFHPFCPAOK(Mesh KEEALIHEENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4EED390", Offset = "0x4EEC590", VA = "0x184EED390")]
	public HPJNOMHLJJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	private NMMLCIFMEBK playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NMMLCIFMEBK AHLLHKKHPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAC0", Offset = "0x5ABCC0", VA = "0x1805ACAC0")]
		get
		{
			return default(NMMLCIFMEBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2431A90", Offset = "0x2430C90", VA = "0x182431A90")]
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
	public bool OLINNIMFLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2550", Offset = "0x4EF1750", VA = "0x184EF2550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AMNGDOLLDOM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AHJPHODNOBA PCODDGDOEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<AHJPHODNOBA> GGEIFPCBBCN;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PAFHHMFKKLA();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum AHJPHODNOBA
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
	public class InstanceColor : MonoBehaviour, MKCBCLJGHMP
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
		private static readonly int MCOOJGCJMBF;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4EED5C0", Offset = "0x4EEC7C0", VA = "0x184EED5C0")]
		private void ABPEGJHOJML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4EED700", Offset = "0x4EEC900", VA = "0x184EED700")]
		private void FJPAAIBKJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4EED840", Offset = "0x4EECA40", VA = "0x184EED840")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4EED7D0", Offset = "0x4EEC9D0", VA = "0x184EED7D0", Slot = "4")]
		public void PrepareImposter(HPHDLMCLBBA KBKLLMLPIOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public InstanceColor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NMMLCIFMEBK
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
		private bool CGKNNOBOBAK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override GEAGFNDBMFB HJKONNDPMGC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x697620", Offset = "0x696820", VA = "0x180697620", Slot = "4")]
			get
			{
				return default(GEAGFNDBMFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4EEBBC0", Offset = "0x4EEADC0", VA = "0x184EEBBC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4EEBE60", Offset = "0x4EEB060", VA = "0x184EEBE60")]
		private void PEHIJKMHCBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4EEC020", Offset = "0x4EEB220", VA = "0x184EEC020")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4EEBD40", Offset = "0x4EEAF40", VA = "0x184EEBD40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4EEBBE0", Offset = "0x4EEADE0", VA = "0x184EEBBE0")]
		private void DEFDFMMDMGP(AHJPHODNOBA CEBPGDGHKIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4EEBBD0", Offset = "0x4EEADD0", VA = "0x184EEBBD0", Slot = "8")]
		protected override bool CLBMOBKLEGE(bool KFDNLBIHKKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4EEBCD0", Offset = "0x4EEAED0", VA = "0x184EEBCD0", Slot = "9")]
		protected override void OPIDGDNFMIO(bool PMKDAEGAIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4EEC050", Offset = "0x4EEB250", VA = "0x184EEC050")]
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
		[MCJNGMPEMLD(EAEFHBMFHFN.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool BHBCICFFKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int FHCCCFLPPNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool IGFPNMBIFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool BOEDKOKHNEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private float BGDJCDACDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private float OHGJNBLBPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float NKBCEIAKOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private float BOBBHNAONJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float IDMEOKHKOLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private float EIMPJPKJBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private ParticleSystem.MainModule LFGLDJICGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ParticleSystem.TrailModule PJCJDCCEODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ParticleSystem.EmissionModule OMNGLOLKCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ParticleSystem.CollisionModule GMIDEKHAIBE;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1C40", Offset = "0x4EF0E40", VA = "0x184EF1C40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1B20", Offset = "0x4EF0D20", VA = "0x184EF1B20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0C10", Offset = "0x4EEFE10", VA = "0x184EF0C10")]
		private void DEFDFMMDMGP(AHJPHODNOBA CEBPGDGHKIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0F00", Offset = "0x4EF0100", VA = "0x184EF0F00")]
		private void KGOHNCEDKKF(IRecRoomQualityConfigProvider JCGHEHOIPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4EF18C0", Offset = "0x4EF0AC0", VA = "0x184EF18C0")]
		private void NMFNGOACDKH(OverrideSettings IFDCCBLKGJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0A60", Offset = "0x4EEFC60", VA = "0x184EF0A60")]
		private void CMOLIAGKNOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4EF08A0", Offset = "0x4EEFAA0", VA = "0x184EF08A0")]
		private void AOJMPMBCADJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0CE0", Offset = "0x4EEFEE0", VA = "0x184EF0CE0")]
		private void HPOHCECNDEA(ParticleSystem.MinMaxCurve PGLFDEBFOOJ, out float HIGLPDIFHND, out float GJPLKCNFKDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4EF0DF0", Offset = "0x4EEFFF0", VA = "0x184EF0DF0")]
		private ParticleSystem.MinMaxCurve IABPOOHAHAP(ParticleSystem.MinMaxCurve PGLFDEBFOOJ, float HIGLPDIFHND, float GJPLKCNFKDG)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override GEAGFNDBMFB HJKONNDPMGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x697620", Offset = "0x696820", VA = "0x180697620", Slot = "4")]
			get
			{
				return default(GEAGFNDBMFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T PDHMHPFNLIH(IRecRoomQualityConfigProvider NEBFCOMFDEJ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x23C0FB0", Offset = "0x23C01B0", VA = "0x1823C0FB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x23C17F0", Offset = "0x23C09F0", VA = "0x1823C17F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x23C1250", Offset = "0x23C0450", VA = "0x1823C1250")]
		private void DEFDFMMDMGP(AHJPHODNOBA CEBPGDGHKIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x23C1460", Offset = "0x23C0660", VA = "0x1823C1460")]
		private void KDBBIAMJJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x23C1550", Offset = "0x23C0750", VA = "0x1823C1550", Slot = "9")]
		protected override void OPIDGDNFMIO(bool PMKDAEGAIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x17C78F0", Offset = "0x17C6AF0", VA = "0x1817C78F0")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum EICBOLCJHBC
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private EICBOLCJHBC behavior;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1E50", Offset = "0x4EF1050", VA = "0x184EF1E50", Slot = "10")]
		protected override bool PDHMHPFNLIH(IRecRoomQualityConfigProvider NEBFCOMFDEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1E30", Offset = "0x4EF1030", VA = "0x184EF1E30", Slot = "8")]
		protected override bool CLBMOBKLEGE(bool KFDNLBIHKKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1EA0", Offset = "0x4EF10A0", VA = "0x184EF1EA0")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private enum LMMHGHNIGEM
		{
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private LMMHGHNIGEM behavior;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1EE0", Offset = "0x4EF10E0", VA = "0x184EF1EE0", Slot = "10")]
		protected override bool PDHMHPFNLIH(IRecRoomQualityConfigProvider NEBFCOMFDEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1E30", Offset = "0x4EF1030", VA = "0x184EF1E30", Slot = "8")]
		protected override bool CLBMOBKLEGE(bool KFDNLBIHKKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1F30", Offset = "0x4EF1130", VA = "0x184EF1F30")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private enum CHMLALKIHEC
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private CHMLALKIHEC behavior;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1F70", Offset = "0x4EF1170", VA = "0x184EF1F70", Slot = "10")]
		protected override bool PDHMHPFNLIH(IRecRoomQualityConfigProvider NEBFCOMFDEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1E30", Offset = "0x4EF1030", VA = "0x184EF1E30", Slot = "8")]
		protected override bool CLBMOBKLEGE(bool KFDNLBIHKKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF1FC0", Offset = "0x4EF11C0", VA = "0x184EF1FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EF2010", Offset = "0x4EF1210", VA = "0x184EF2010", Slot = "10")]
		protected override LightRenderingMode PDHMHPFNLIH(IRecRoomQualityConfigProvider NEBFCOMFDEJ)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2000", Offset = "0x4EF1200", VA = "0x184EF2000", Slot = "8")]
		protected override bool CLBMOBKLEGE(LightRenderingMode KFDNLBIHKKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2070", Offset = "0x4EF1270", VA = "0x184EF2070")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EF20D0", Offset = "0x4EF12D0", VA = "0x184EF20D0", Slot = "10")]
		protected override SceneDecorationDetailLevel PDHMHPFNLIH(IRecRoomQualityConfigProvider NEBFCOMFDEJ)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4EF20B0", Offset = "0x4EF12B0", VA = "0x184EF20B0", Slot = "8")]
		protected override bool CLBMOBKLEGE(SceneDecorationDetailLevel KFDNLBIHKKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2120", Offset = "0x4EF1320", VA = "0x184EF2120")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EF2180", Offset = "0x4EF1380", VA = "0x184EF2180", Slot = "10")]
		protected override TransparencyDetailLevel PDHMHPFNLIH(IRecRoomQualityConfigProvider NEBFCOMFDEJ)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2160", Offset = "0x4EF1360", VA = "0x184EF2160", Slot = "8")]
		protected override bool CLBMOBKLEGE(TransparencyDetailLevel KFDNLBIHKKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4EF21D0", Offset = "0x4EF13D0", VA = "0x184EF21D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EF2300", Offset = "0x4EF1500", VA = "0x184EF2300", Slot = "8")]
		protected override bool CLBMOBKLEGE(BackgroundAnimationDetailLevel EGALCHBLGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2390", Offset = "0x4EF1590", VA = "0x184EF2390", Slot = "9")]
		protected override void OPIDGDNFMIO(bool NEIHOEKNJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2210", Offset = "0x4EF1410", VA = "0x184EF2210")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2420", Offset = "0x4EF1620", VA = "0x184EF2420")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2510", Offset = "0x4EF1710", VA = "0x184EF2510")]
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
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
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
		private Terrain LNGOGNEMDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TerrainData KGIBLPPAFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TerrainData MIHECJBFCFE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Terrain KGJCAJIGEIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4EF26F0", Offset = "0x4EF18F0", VA = "0x184EF26F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2650", Offset = "0x4EF1850", VA = "0x184EF2650")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2D60", Offset = "0x4EF1F60", VA = "0x184EF2D60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2C40", Offset = "0x4EF1E40", VA = "0x184EF2C40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2C30", Offset = "0x4EF1E30", VA = "0x184EF2C30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2F10", Offset = "0x4EF2110", VA = "0x184EF2F10")]
		private void PJDLOJIHLOH(AHJPHODNOBA CEBPGDGHKIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4EF3000", Offset = "0x4EF2200", VA = "0x184EF3000", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel DMHJDNJNAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5749D0", Offset = "0x573BD0", VA = "0x1805749D0", Slot = "8")]
		protected override bool CLBMOBKLEGE(TerrainQualityLevel EGALCHBLGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "9")]
		protected override void OPIDGDNFMIO(bool PMKDAEGAIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2780", Offset = "0x4EF1980", VA = "0x184EF2780")]
		private void GABAGICJPNE(Settings JGJCMDCBDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4EF28E0", Offset = "0x4EF1AE0", VA = "0x184EF28E0")]
		private void IKIKFCLLLIK(TreePrefabOverride[] EMLLNNNCNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2800", Offset = "0x4EF1A00", VA = "0x184EF2800")]
		private void IEBGPKMIHEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4EF2BB0", Offset = "0x4EF1DB0", VA = "0x184EF2BB0")]
		private Settings LFMMFHBCAHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4EF3270", Offset = "0x4EF2470", VA = "0x184EF3270")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FLEPHNLEGEC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color EBAIGGBEODO);
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
		private List<Material> CEBDHMJLACJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BackgroundObject IKFKKIIPFKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574B80", VA = "0x180575980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB040", Offset = "0x4EEA240", VA = "0x184EEB040")]
		public void Init(BackgroundObject LKMDFAIEDCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB290", Offset = "0x4EEA490", VA = "0x184EEB290")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB3B0", Offset = "0x4EEA5B0", VA = "0x184EEB3B0")]
		public void SetBlendValue(float CMGCCMJBGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB510", Offset = "0x4EEA710", VA = "0x184EEB510")]
		public void SetColor(Color EBAIGGBEODO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB620", Offset = "0x4EEA820", VA = "0x184EEB620")]
		public void SetRotation(float CONNMLKIDNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB810", Offset = "0x4EEAA10", VA = "0x184EEB810")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LLMMHHIHGFG
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FEBNCGAJKCH<T> : LLMMHHIHGFG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool OFAMCPFCDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T EGALCHBLGAN);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class ActivationController : MonoBehaviour, LLMMHHIHGFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum GEAGFNDBMFB
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
		[HGGKKBNJMGF("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected virtual GEAGFNDBMFB HJKONNDPMGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x579850", Offset = "0x578A50", VA = "0x180579850", Slot = "4")]
			get
			{
				return default(GEAGFNDBMFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class ActivationController<T> : ActivationController, global::FEBNCGAJKCH<T>, LLMMHHIHGFG where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		protected bool? JCCFEHMOMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		protected T DJPLKBJAJKO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OFAMCPFCDMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x23B8970", Offset = "0x23B7B70", VA = "0x1823B8970", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x23B85E0", Offset = "0x23B77E0", VA = "0x1823B85E0", Slot = "7")]
		public virtual void SetActivation(T EGALCHBLGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool CLBMOBKLEGE(T EGALCHBLGAN);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void OPIDGDNFMIO(bool PMKDAEGAIDI);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x17C3340", Offset = "0x17C2540", VA = "0x1817C3340")]
		protected ActivationController()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FNGEDJFFIEL
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static byte[] JKCEPOEAODE;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static int HMIFPHDBAAL;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static int JLNLCKONFPG;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static BigInteger EBGIPPCOABB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FNGEDJFFIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4EECAF0", Offset = "0x4EEBCF0", VA = "0x184EECAF0")]
	private static string CHCKGNJAKBF(byte[] CJCOEBBKILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4EECBF0", Offset = "0x4EEBDF0", VA = "0x184EECBF0")]
	public static string PEFJMDOFNMG(byte[] PKBLLNJJAGK, bool HCHELKBPHNG)
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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
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
