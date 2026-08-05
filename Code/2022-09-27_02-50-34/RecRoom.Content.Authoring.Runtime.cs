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
	public enum ABAHDIPKHJG
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
	private ABAHDIPKHJG bobAxis;

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
	private float PAOJHEJFKFI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 FAAGIDPKJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x269BF40", Offset = "0x269B140", VA = "0x18269BF40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x269BF00", Offset = "0x269B100", VA = "0x18269BF00")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x269C110", Offset = "0x269B310", VA = "0x18269C110")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x269C270", Offset = "0x269B470", VA = "0x18269C270")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x269C280", Offset = "0x269B480", VA = "0x18269C280")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, MGAAOCJJEEL
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string BIPOBOINDBN = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string JNBFMGKJBPN = "_MainColor";

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
	private static List<Material> IMKHNEMAGPI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> AHLCIOAMIKK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "4")]
	public void PrepareImposter(NGGBPNJPEGF JBADGMEDNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x269CC80", Offset = "0x269BE80", VA = "0x18269CC80")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct BGLFACCIBFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum BEJOEOAHHCA
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
	public struct LOIOEPLMIPJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public BGLFACCIBFM MIJOMJPBHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int KOLPJKMNFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LAOGJAACEAI CKJEBHFINAG;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x269DB20", Offset = "0x269CD20", VA = "0x18269DB20", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct DGOMACHBOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> ILOCKCMNHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> IOPPGLPNGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> HPGJDIODGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> OCJIJLGDPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> CJCMHGNFKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> ENKOKMLGHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> LMCNGJBLBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> MDDOCKHOGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> HKHONCONCAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> BNDJEDJJPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> AHLCDMAGFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> PEKBLHIDDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> LPOOJHFAOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> EIBDJBGCAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> PAADOKHGDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int HJPBKMIEJHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 MANHCKBONFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool NNGOGFBBJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int KCAKLDHFCLC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int LCPJDFKPNLA = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int NGDLJCFHGLE = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> ILOCKCMNHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> HAJNDMNCDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> IOPPGLPNGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> HPGJDIODGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> OCJIJLGDPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> CJCMHGNFKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> ENKOKMLGHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> LMCNGJBLBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> MDDOCKHOGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> HKHONCONCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> EIBDJBGCAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> AENFFKNLBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> GHBOFOIALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> BNDJEDJJPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> LAJJNJPAFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> AHLCDMAGFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> CIGMHPHPJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> JMINMBEBMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> GCCNEMNMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> LNLJOOHAJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> NFAGPACOLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> FMDGMFKHAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> OHNBBOPGFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> ILIFGFMOPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> HPFGDHPKFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> KMFOHOAKGDE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int KKNDBMOKKIE = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int INHDEGADMBG = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int CCBDBODJGCC = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int JFONHHFMCBP = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> OELOBPIPBPF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DEPPOOFBOFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2699E10", Offset = "0x2699010", VA = "0x182699E10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2699670", Offset = "0x2698870", VA = "0x182699670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BPBGFMKEGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2699680", Offset = "0x2698880", VA = "0x182699680")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2699E20", Offset = "0x2699020", VA = "0x182699E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EGOMLAJOAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2699420", Offset = "0x2698620", VA = "0x182699420")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2699650", Offset = "0x2698850", VA = "0x182699650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BEJOEOAHHCA FPNMJFNDNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2699E30", Offset = "0x2699030", VA = "0x182699E30")]
		get
		{
			return default(BEJOEOAHHCA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2699660", Offset = "0x2698860", VA = "0x182699660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private DGOMACHBOAB LCCNHANCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2699800", Offset = "0x2698A00", VA = "0x182699800")]
		get
		{
			return default(DGOMACHBOAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2699E40", Offset = "0x2699040", VA = "0x182699E40")]
	public BGLFACCIBFM(IList<Mesh> CCBKJIFBICO, IList<int> AHFOCNPDEMM, IList<int> DOJMLLGJMOG, IList<int[]> DBIKLBGKEMH, IList<Matrix4x4> IPNGEBJHPJO, IList<bool> HMPIBOEKHHF, IList<int> HFGKEMFONKL, Allocator MKFODJKMOCC, BEJOEOAHHCA KNPANNNEPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2699690", Offset = "0x2698890", VA = "0x182699690")]
	public LAOGJAACEAI LLKPOEEAJMG(int LCOLGGJADDK, Allocator MKFODJKMOCC)
	{
		return default(LAOGJAACEAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2699430", Offset = "0x2698630", VA = "0x182699430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct LAOGJAACEAI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> ILOCKCMNHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> IOPPGLPNGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> HPGJDIODGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> OCJIJLGDPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> CJCMHGNFKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> ENKOKMLGHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> LMCNGJBLBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> MDDOCKHOGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> HKHONCONCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> BNDJEDJJPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> AHLCDMAGFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> PEKBLHIDDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> LPOOJHFAOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> OELOBPIPBPF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PBEKOLCCLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x269D5A0", Offset = "0x269C7A0", VA = "0x18269D5A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x269D0C0", Offset = "0x269C2C0", VA = "0x18269D0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x269D690", Offset = "0x269C890", VA = "0x18269D690")]
	public LAOGJAACEAI(int BFODLAHGKLF, int BFNLKEBLEAB, int CCMKFCMIOKG, int LCOLGGJADDK, Allocator MKFODJKMOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x269D740", Offset = "0x269C940", VA = "0x18269D740")]
	public LAOGJAACEAI(int BFODLAHGKLF, int BFNLKEBLEAB, int CCMKFCMIOKG, int LCOLGGJADDK, Allocator MKFODJKMOCC, bool[] HLDCNAKKMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x269D5B0", Offset = "0x269C7B0", VA = "0x18269D5B0")]
	public void IJEBJDKIGLI(int EKBELKBICHO, int FDGAPOLJFKN, int IPOIAMFIOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x269D440", Offset = "0x269C640", VA = "0x18269D440")]
	public int[] EHMCLAPCCHH(int EKBELKBICHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x269D500", Offset = "0x269C700", VA = "0x18269D500")]
	private NativeSlice<int> FMLKGHGMMFH(int EKBELKBICHO)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x269D320", Offset = "0x269C520", VA = "0x18269D320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x269D0D0", Offset = "0x269C2D0", VA = "0x18269D0D0")]
	public Mesh BOANFEKIGDD([Optional] string EKDNOHGKBLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BELBPBLLEII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> MJFMMJMJNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> LEDFOOOLAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> BJEHEOBBMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> GJKDICIJOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> CMMBMJMFBNP;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x26990D0", Offset = "0x26982D0", VA = "0x1826990D0")]
	public void JGADOOBCNLH(Mesh EICLBLAAFOL, int[] LDHGDHBGFBD, Matrix4x4 GPKLNFMNGBN, bool HMPIBOEKHHF = false, int ACDPBONKKGG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2699250", Offset = "0x2698450", VA = "0x182699250")]
	public BGLFACCIBFM LJLMIHCCNNH(Allocator MKFODJKMOCC, BGLFACCIBFM.BEJOEOAHHCA KNPANNNEPBJ, [Optional] IList<int> DOJMLLGJMOG, [Optional] IList<int> MFGDJIHCEIP)
	{
		return default(BGLFACCIBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2699050", Offset = "0x2698250", VA = "0x182699050")]
	private void APJIBEOHCCL(Mesh EICLBLAAFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2699300", Offset = "0x2698500", VA = "0x182699300")]
	public BELBPBLLEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	private KMGCFGFMMKN playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KMGCFGFMMKN AEDOJHNGDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD60", Offset = "0x6FEF60", VA = "0x1806FFD60")]
		get
		{
			return default(KMGCFGFMMKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26A0330", Offset = "0x269F530", VA = "0x1826A0330")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RequireComponent(typeof(Camera))]
public class ScreenshotGenerator : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26A0340", Offset = "0x269F540", VA = "0x1826A0340")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PNKLFMAFIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x26A09A0", Offset = "0x269FBA0", VA = "0x1826A09A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ELFBPLENMJK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MBJBJLKCMIF KEDEGIOGGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MBJBJLKCMIF> NMKOIOINIIN;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJEPHGAKOHB();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum MBJBJLKCMIF
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Count
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
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
		private Light DICLPCLHIEJ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Light CJGIABEBLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x26A02A0", Offset = "0x269F4A0", VA = "0x1826A02A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x26A0100", Offset = "0x269F300", VA = "0x1826A0100")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x26A0250", Offset = "0x269F450", VA = "0x1826A0250")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, MGAAOCJJEEL
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
		private static readonly int EGBFONCMNNM;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x269CCF0", Offset = "0x269BEF0", VA = "0x18269CCF0")]
		private void ECEJEECBNOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x269CE30", Offset = "0x269C030", VA = "0x18269CE30")]
		private void FOCKFKKKFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x269CF70", Offset = "0x269C170", VA = "0x18269CF70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x269CF00", Offset = "0x269C100", VA = "0x18269CF00", Slot = "4")]
		public void PrepareImposter(NGGBPNJPEGF JBADGMEDNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public InstanceColor()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void MGANEABKJBD(ParticleEventListener ENJAKHBHFFJ, Collider GHOINNFPLDF, IEnumerable<ParticleCollisionEvent> CLMIGNPOKEO);

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static readonly List<ParticleCollisionEvent> COGBBNCMCLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		[NODNICKNPLO(NOMJLFGGPAB.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MGANEABKJBD NIKPEKIFFIC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x269EBC0", Offset = "0x269DDC0", VA = "0x18269EBC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x269EC60", Offset = "0x269DE60", VA = "0x18269EC60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x269E880", Offset = "0x269DA80", VA = "0x18269E880")]
		private void OnParticleCollision(GameObject GHOINNFPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[NAFDLBNKCNI("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x26A0AA0", Offset = "0x269FCA0", VA = "0x1826A0AA0")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x26A0AC0", Offset = "0x269FCC0", VA = "0x1826A0AC0")]
		public bool DGEELNJKLAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x26A0BD0", Offset = "0x269FDD0", VA = "0x1826A0BD0")]
		public StaticBatchMeshData()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool NKMNBMKHDLO;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override PGIHIICCJFA BAABFLGCKHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x717290", Offset = "0x716490", VA = "0x180717290", Slot = "4")]
			get
			{
				return default(PGIHIICCJFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x269C2B0", Offset = "0x269B4B0", VA = "0x18269C2B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x269C470", Offset = "0x269B670", VA = "0x18269C470")]
		private void PDMPAICDOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x269C580", Offset = "0x269B780", VA = "0x18269C580")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x269C3C0", Offset = "0x269B5C0", VA = "0x18269C3C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x269C2C0", Offset = "0x269B4C0", VA = "0x18269C2C0")]
		private void EACIJOCFOKI(MBJBJLKCMIF LNDMKLKOMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x269C340", Offset = "0x269B540", VA = "0x18269C340", Slot = "8")]
		protected override bool FCMDKMLBMAA(bool LACIJGNICGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x269C350", Offset = "0x269B550", VA = "0x18269C350", Slot = "9")]
		protected override void JCEDOPOOANK(bool JIBFHJIDGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x269C5B0", Offset = "0x269B7B0", VA = "0x18269C5B0")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		[NODNICKNPLO(NOMJLFGGPAB.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool FNIHNPGPCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int DFPMICPHHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool FIOEACDEHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool HFHHMPPLOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private float LEDKNOKECDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float LKFLBFJJAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float ENJLHBBJIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float LBOJBKIDOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float KBJDKOAFMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float FHFIABAEOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private ParticleSystem.MainModule AJCOKONCFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private ParticleSystem.TrailModule GHFGFINOEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.EmissionModule BEMCBCIFHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ParticleSystem.CollisionModule GGLFMBPCHIA;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x269FFC0", Offset = "0x269F1C0", VA = "0x18269FFC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x269FF10", Offset = "0x269F110", VA = "0x18269FF10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x269EFC0", Offset = "0x269E1C0", VA = "0x18269EFC0")]
		private void EACIJOCFOKI(MBJBJLKCMIF LNDMKLKOMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x269F130", Offset = "0x269E330", VA = "0x18269F130")]
		private void JCDLFJCEBJP(IRecRoomQualityConfigProvider PAFAFHKFCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x269FCB0", Offset = "0x269EEB0", VA = "0x18269FCB0")]
		private void NHACEMEBKFA(OverrideSettings KICIBNOOJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x269EE10", Offset = "0x269E010", VA = "0x18269EE10")]
		private void DFGNPAFKEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x269FAF0", Offset = "0x269ECF0", VA = "0x18269FAF0")]
		private void JDDCAALGIAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x269F020", Offset = "0x269E220", VA = "0x18269F020")]
		private void ENPCPHBMODN(ParticleSystem.MinMaxCurve HHDLHKICPAM, out float JFOMFJOGEHA, out float JNOHPIIKLLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x269ED00", Offset = "0x269DF00", VA = "0x18269ED00")]
		private ParticleSystem.MinMaxCurve AGHBOIIMHFG(ParticleSystem.MinMaxCurve HHDLHKICPAM, float JFOMFJOGEHA, float JNOHPIIKLLC)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override PGIHIICCJFA BAABFLGCKHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x717290", Offset = "0x716490", VA = "0x180717290", Slot = "4")]
			get
			{
				return default(PGIHIICCJFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T GBFCHODKKDB(IRecRoomQualityConfigProvider OCHCILKJJII);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3A21730", Offset = "0x3A20930", VA = "0x183A21730")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3A21C60", Offset = "0x3A20E60", VA = "0x183A21C60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3A218F0", Offset = "0x3A20AF0", VA = "0x183A218F0")]
		private void EACIJOCFOKI(MBJBJLKCMIF LNDMKLKOMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3A219E0", Offset = "0x3A20BE0", VA = "0x183A219E0")]
		private void KOGOKAPICGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3A21920", Offset = "0x3A20B20", VA = "0x183A21920", Slot = "9")]
		protected override void JCEDOPOOANK(bool JIBFHJIDGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1208F50", Offset = "0x1208150", VA = "0x181208F50")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class NMOLGFAKPIA
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x269E790", Offset = "0x269D990", VA = "0x18269E790")]
	[EEPNDFMGFKJ(CPDKPFACMJL.None)]
	private static void HLFDIDCONPP()
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum NFEBMFGBAMB
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private NFEBMFGBAMB behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x26A0380", Offset = "0x269F580", VA = "0x1826A0380", Slot = "10")]
		protected override bool GBFCHODKKDB(IRecRoomQualityConfigProvider OCHCILKJJII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x26A0360", Offset = "0x269F560", VA = "0x1826A0360", Slot = "8")]
		protected override bool FCMDKMLBMAA(bool LACIJGNICGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x26A03D0", Offset = "0x269F5D0", VA = "0x1826A03D0")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private enum NHJPOONFNAJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private NHJPOONFNAJ behavior;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x26A0410", Offset = "0x269F610", VA = "0x1826A0410", Slot = "10")]
		protected override bool GBFCHODKKDB(IRecRoomQualityConfigProvider OCHCILKJJII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x26A0360", Offset = "0x269F560", VA = "0x1826A0360", Slot = "8")]
		protected override bool FCMDKMLBMAA(bool LACIJGNICGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x26A0460", Offset = "0x269F660", VA = "0x1826A0460")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private enum EHMPAODEBLH
		{
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private EHMPAODEBLH behavior;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x26A04A0", Offset = "0x269F6A0", VA = "0x1826A04A0", Slot = "10")]
		protected override bool GBFCHODKKDB(IRecRoomQualityConfigProvider OCHCILKJJII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x26A0360", Offset = "0x269F560", VA = "0x1826A0360", Slot = "8")]
		protected override bool FCMDKMLBMAA(bool LACIJGNICGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x26A04F0", Offset = "0x269F6F0", VA = "0x1826A04F0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x26A0540", Offset = "0x269F740", VA = "0x1826A0540", Slot = "10")]
		protected override LightRenderingMode GBFCHODKKDB(IRecRoomQualityConfigProvider OCHCILKJJII)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x26A0530", Offset = "0x269F730", VA = "0x1826A0530", Slot = "8")]
		protected override bool FCMDKMLBMAA(LightRenderingMode LACIJGNICGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x26A05A0", Offset = "0x269F7A0", VA = "0x1826A05A0")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x26A0600", Offset = "0x269F800", VA = "0x1826A0600", Slot = "10")]
		protected override SceneDecorationDetailLevel GBFCHODKKDB(IRecRoomQualityConfigProvider OCHCILKJJII)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x26A05E0", Offset = "0x269F7E0", VA = "0x1826A05E0", Slot = "8")]
		protected override bool FCMDKMLBMAA(SceneDecorationDetailLevel LACIJGNICGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x26A0650", Offset = "0x269F850", VA = "0x1826A0650")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x26A06B0", Offset = "0x269F8B0", VA = "0x1826A06B0", Slot = "10")]
		protected override TransparencyDetailLevel GBFCHODKKDB(IRecRoomQualityConfigProvider OCHCILKJJII)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x26A0690", Offset = "0x269F890", VA = "0x1826A0690", Slot = "8")]
		protected override bool FCMDKMLBMAA(TransparencyDetailLevel LACIJGNICGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x26A0700", Offset = "0x269F900", VA = "0x1826A0700")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x26A07C0", Offset = "0x269F9C0", VA = "0x1826A07C0", Slot = "8")]
		protected override bool FCMDKMLBMAA(BackgroundAnimationDetailLevel DNODFLEGJOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x26A0850", Offset = "0x269FA50", VA = "0x1826A0850", Slot = "9")]
		protected override void JCEDOPOOANK(bool EAMGOFONHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x26A0740", Offset = "0x269F940", VA = "0x1826A0740")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x26A08E0", Offset = "0x269FAE0", VA = "0x1826A08E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x26A0960", Offset = "0x269FB60", VA = "0x1826A0960")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Terrain DIIJMJKFFCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TerrainData ECBMDPKDGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TerrainData JPHHNPPBCDM;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Terrain CNKMDONEJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x26A0C40", Offset = "0x269FE40", VA = "0x1826A0C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x26A0CD0", Offset = "0x269FED0", VA = "0x1826A0CD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x26A1090", Offset = "0x26A0290", VA = "0x1826A1090")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x26A0FE0", Offset = "0x26A01E0", VA = "0x1826A0FE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x26A0FD0", Offset = "0x26A01D0", VA = "0x1826A0FD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x26A0D70", Offset = "0x269FF70", VA = "0x1826A0D70")]
		private void FAODDGIIEAP(MBJBJLKCMIF LNDMKLKOMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x26A1460", Offset = "0x26A0660", VA = "0x1826A1460", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel AKJFFBEIACK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070", Slot = "8")]
		protected override bool FCMDKMLBMAA(TerrainQualityLevel DNODFLEGJOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "9")]
		protected override void JCEDOPOOANK(bool JIBFHJIDGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x26A0DF0", Offset = "0x269FFF0", VA = "0x1826A0DF0")]
		private void IJNKGJPPLKP(Settings GPFOOINJGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x26A1190", Offset = "0x26A0390", VA = "0x1826A1190")]
		private void PGPOGJDHNPL(TreePrefabOverride[] EEADCJEJFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x26A0EF0", Offset = "0x26A00F0", VA = "0x1826A0EF0")]
		private void NKMIJFMCDCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x26A0E70", Offset = "0x26A0070", VA = "0x1826A0E70")]
		private Settings MDMDBLJEEHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x26A16D0", Offset = "0x26A08D0", VA = "0x1826A16D0")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum KMGCFGFMMKN
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface OHHKOMPLODO
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color JGDHNJNCLMJ);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<Material> IEHMJKOEBJH;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject EPGKLMKNPAB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x623BB0", Offset = "0x622DB0", VA = "0x180623BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x269B6C0", Offset = "0x269A8C0", VA = "0x18269B6C0")]
		public void Init(BackgroundObject DBHBBNPKELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x269B910", Offset = "0x269AB10", VA = "0x18269B910")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x269BA30", Offset = "0x269AC30", VA = "0x18269BA30")]
		public void SetBlendValue(float JDMNLJOMBIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x269BB90", Offset = "0x269AD90", VA = "0x18269BB90")]
		public void SetColor(Color JGDHNJNCLMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x269BCA0", Offset = "0x269AEA0", VA = "0x18269BCA0")]
		public void SetRotation(float PAOOIKIKMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x269BE90", Offset = "0x269B090", VA = "0x18269BE90")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GIPHABCMDGN
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LOBBCNDMFCD<T> : GIPHABCMDGN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool LCNMCAHOCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T DNODFLEGJOM);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public abstract class ActivationController : MonoBehaviour, GIPHABCMDGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public enum PGIHIICCJFA
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		[NAFDLBNKCNI("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual PGIHIICCJFA BAABFLGCKHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5F6110", Offset = "0x5F5310", VA = "0x1805F6110", Slot = "4")]
			get
			{
				return default(PGIHIICCJFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class ActivationController<T> : ActivationController, global::LOBBCNDMFCD<T>, GIPHABCMDGN where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		protected bool? GMLGCIEGGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		protected T LBIFFGMOMBB;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LCNMCAHOCGI
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3A18820", Offset = "0x3A17A20", VA = "0x183A18820", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3A18490", Offset = "0x3A17690", VA = "0x183A18490", Slot = "7")]
		public virtual void SetActivation(T DNODFLEGJOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool FCMDKMLBMAA(T DNODFLEGJOM);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void JCEDOPOOANK(bool JIBFHJIDGGA);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x394C480", Offset = "0x394B680", VA = "0x18394C480")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[AddComponentMenu("")]
	public class AGProBuilderStub : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5F5460", Offset = "0x5F4660", VA = "0x1805F5460")]
		public AGProBuilderStub()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x269C920", Offset = "0x269BB20", VA = "0x18269C920")]
	private static string JBPNMHMEPIE(byte[] KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x269C5F0", Offset = "0x269B7F0", VA = "0x18269C5F0")]
	public static string HDPEGNHHKLG(byte[] FAOJAOEJLMO, bool CGIGAMOFOGM)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
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
