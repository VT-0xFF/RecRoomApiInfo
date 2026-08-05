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
	public enum KDDCCKKGPMA
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
	private KDDCCKKGPMA bobAxis;

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
	private float MDLFCGACGLK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 OOIJLIJPGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x50D3A70", Offset = "0x50D2A70", VA = "0x1850D3A70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1057B60", Offset = "0x1056B60", VA = "0x181057B60")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x50D3C40", Offset = "0x50D2C40", VA = "0x1850D3C40")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x50D3DA0", Offset = "0x50D2DA0", VA = "0x1850D3DA0")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE212C0", Offset = "0xE202C0", VA = "0x180E212C0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, PGMOJHKBDPM
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string PODKJGBAFIP = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string EMEHBDOBFLO = "_MainColor";

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
	private static List<Material> IMPPAPFJDAI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> NIJGGFCOPLF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "4")]
	public void PrepareImposter(AJBBKPFHEPC HEBHFHEMFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50D58A0", Offset = "0x50D48A0", VA = "0x1850D58A0")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct PNBKCKBEDKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum CHBHAAKAIOJ
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
	public struct NHIEHEHGLJB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public PNBKCKBEDKO JEDJNEHKHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int IMDLFBMCNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public EFHICGPBDEP EPDJPPBNIAD;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x50D5CE0", Offset = "0x50D4CE0", VA = "0x1850D5CE0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct DENDOBLMOOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> GFBGHIOCBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> LPALEJOOLBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> DEGKIKBALOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> FIPEIABBIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> CBHIOBJDBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> FOABIDMHKJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> KPEHCADPMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> FGMPINCEFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> CMOMDJCELEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> KHEJDBMKLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> GGGFDHOOKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> OCBLKKIIADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> ABENOJCIDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> CMBGFMOANBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> JLIGODKKLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int KCLGPJJECFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 HOLCABJCLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool EIKEIMIOJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int NICMBAPANEM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int NNPCEDNJLNB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int HCMCJNOMGAD = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> GFBGHIOCBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> KONAFKOKAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> LPALEJOOLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> DEGKIKBALOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> FIPEIABBIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> CBHIOBJDBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> FOABIDMHKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> KPEHCADPMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> FGMPINCEFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> CMOMDJCELEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> CMBGFMOANBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> HFABLKNKHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> ANGNGNCBAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> KHEJDBMKLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> EKKELOEJJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> GGGFDHOOKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> DHJLCLCEHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> KLOADNLHMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> KNDIMHOPGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> MPNIHPCGLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> MGDOOJFPKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> KDPDKCDPPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> CPJAJFMKACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> HANJPDNMNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> DCOKBKMANNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> JAMFKCMOCHK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int HOJJOKKICKF = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int PELNOMOOHBB = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int CGPIGELHBBB = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int AHNAPFNBLJF = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> INEDIEMNNNG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KEPIFMGBLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x50D6970", Offset = "0x50D5970", VA = "0x1850D6970")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x50D6960", Offset = "0x50D5960", VA = "0x1850D6960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BHMPBLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x50D6950", Offset = "0x50D5950", VA = "0x1850D6950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x50D6BB0", Offset = "0x50D5BB0", VA = "0x1850D6BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JNPMJMLGNLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x50D6980", Offset = "0x50D5980", VA = "0x1850D6980")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x50D7350", Offset = "0x50D6350", VA = "0x1850D7350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CHBHAAKAIOJ CJEMDJCDJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x50D71D0", Offset = "0x50D61D0", VA = "0x1850D71D0")]
		get
		{
			return default(CHBHAAKAIOJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x50D7360", Offset = "0x50D6360", VA = "0x1850D7360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private DENDOBLMOOG PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x50D6BC0", Offset = "0x50D5BC0", VA = "0x1850D6BC0")]
		get
		{
			return default(DENDOBLMOOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x50D7370", Offset = "0x50D6370", VA = "0x1850D7370")]
	public PNBKCKBEDKO(IList<Mesh> NIIJKNGMCCG, IList<int> JFPDIDCCFDL, IList<int> OGKJCJCBKPO, IList<int[]> FNHJKOELAEE, IList<Matrix4x4> ICFHAEMCLCC, IList<bool> NBPGDPJNHKN, IList<int> OOALHEEFDEA, Allocator NFKJHPBOKBG, CHBHAAKAIOJ EGJPNEEJLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50D71E0", Offset = "0x50D61E0", VA = "0x1850D71E0")]
	public EFHICGPBDEP LKCODOLBKHL(int DLENCDPLEKI, Allocator NFKJHPBOKBG)
	{
		return default(EFHICGPBDEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x50D6990", Offset = "0x50D5990", VA = "0x1850D6990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct EFHICGPBDEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> GFBGHIOCBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> LPALEJOOLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> DEGKIKBALOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> FIPEIABBIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> CBHIOBJDBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> FOABIDMHKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> KPEHCADPMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> FGMPINCEFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> CMOMDJCELEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> KHEJDBMKLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> GGGFDHOOKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> OCBLKKIIADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> ABENOJCIDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> INEDIEMNNNG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MHODJIDHDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x50D4770", Offset = "0x50D3770", VA = "0x1850D4770")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x50D4780", Offset = "0x50D3780", VA = "0x1850D4780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x50D4850", Offset = "0x50D3850", VA = "0x1850D4850")]
	public EFHICGPBDEP(int GCHNNEKIHEO, int LKCABBIILCG, int LOKOHPONHKM, int DLENCDPLEKI, Allocator NFKJHPBOKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x50D4900", Offset = "0x50D3900", VA = "0x1850D4900")]
	public EFHICGPBDEP(int GCHNNEKIHEO, int LKCABBIILCG, int LOKOHPONHKM, int DLENCDPLEKI, Allocator NFKJHPBOKBG, bool[] PKLFNEHFNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x50D45F0", Offset = "0x50D35F0", VA = "0x1850D45F0")]
	public void GALDBPHKMMK(int MDHPCLNCAIJ, int GPILAGKEABD, int ALCOEEKHPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50D4790", Offset = "0x50D3790", VA = "0x1850D4790")]
	public int[] OBPCANFDPPA(int MDHPCLNCAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50D46D0", Offset = "0x50D36D0", VA = "0x1850D46D0")]
	private NativeSlice<int> KGMHBCNCPIH(int MDHPCLNCAIJ)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x50D44D0", Offset = "0x50D34D0", VA = "0x1850D44D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x50D4280", Offset = "0x50D3280", VA = "0x1850D4280")]
	public Mesh CDBOCECMLGP([Optional] string MPFJDBKNDMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HPHCMLGKBAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> HMAIBIFFKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> EJJOLHCEMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> NBKKFCGBGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> AEFABDEEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> KIHMFAIPMDK;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x50D4E10", Offset = "0x50D3E10", VA = "0x1850D4E10")]
	public void OPNBHLBKNKO(Mesh HEEINMMNNBJ, int[] CPFKKILFLDB, Matrix4x4 DHILIMIMCIN, bool NBPGDPJNHKN = false, int MAMBFHKAPCO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x50D4D60", Offset = "0x50D3D60", VA = "0x1850D4D60")]
	public PNBKCKBEDKO KGJJCFCNJCL(Allocator NFKJHPBOKBG, PNBKCKBEDKO.CHBHAAKAIOJ EGJPNEEJLDL, [Optional] IList<int> OGKJCJCBKPO, [Optional] IList<int> PEOAINFLDMH)
	{
		return default(PNBKCKBEDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x50D4CE0", Offset = "0x50D3CE0", VA = "0x1850D4CE0")]
	private void IGOAFHKDFCG(Mesh HEEINMMNNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x50D4F90", Offset = "0x50D3F90", VA = "0x1850D4F90")]
	public HPHCMLGKBAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
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
	private JNLOPEFMJLH playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JNLOPEFMJLH PICBKELPIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x619670", Offset = "0x618670", VA = "0x180619670")]
		get
		{
			return default(JNLOPEFMJLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26226A0", Offset = "0x26216A0", VA = "0x1826226A0")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
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
	public bool KDJGMKMONOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x50DAF50", Offset = "0x50D9F50", VA = "0x1850DAF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LHECNAIIINJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FAAGGPJNPNH BNKLIALAFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FAAGGPJNPNH> OOJHBCJMEKH;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPLEEAJIBGE();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum FAAGGPJNPNH
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
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Light DGGIMDMLEJB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Light ANNHKFHLPGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x50DA7A0", Offset = "0x50D97A0", VA = "0x1850DA7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x50DA600", Offset = "0x50D9600", VA = "0x1850DA600")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x50DA750", Offset = "0x50D9750", VA = "0x1850DA750")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, PGMOJHKBDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[HideInInspector]
		[SerializeField]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int AKMMIPJFMAH;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x50D5910", Offset = "0x50D4910", VA = "0x1850D5910")]
		private void FOLEDCEJOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x50D5A50", Offset = "0x50D4A50", VA = "0x1850D5A50")]
		private void IOOLFDCDLND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x50D5B90", Offset = "0x50D4B90", VA = "0x1850D5B90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x50D5B20", Offset = "0x50D4B20", VA = "0x1850D5B20", Slot = "4")]
		public void PrepareImposter(AJBBKPFHEPC HEBHFHEMFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public InstanceColor()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void NLOAEGIMOPE(ParticleEventListener HCNIDJFEACA, Collider GOAJJPLEOBJ, IEnumerable<ParticleCollisionEvent> MONEIAFHFEG);

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly List<ParticleCollisionEvent> DMENOENANDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[EJHKBJPGPJF(KPKOFHBALGN.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NLOAEGIMOPE GABJCGAHLJH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x50D8F30", Offset = "0x50D7F30", VA = "0x1850D8F30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x50D8FD0", Offset = "0x50D7FD0", VA = "0x1850D8FD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50D8BF0", Offset = "0x50D7BF0", VA = "0x1850D8BF0")]
		private void OnParticleCollision(GameObject GOAJJPLEOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[IMJIOIJNDBJ("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50DB050", Offset = "0x50DA050", VA = "0x1850DB050")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x50DB070", Offset = "0x50DA070", VA = "0x1850DB070")]
		public bool DOHLAFINODK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x50DB180", Offset = "0x50DA180", VA = "0x1850DB180")]
		public StaticBatchMeshData()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private bool KALJKCEPCLM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override NLBHCLIEFKA LLONOLFCLMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x672030", Offset = "0x671030", VA = "0x180672030", Slot = "4")]
			get
			{
				return default(NLBHCLIEFKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x50D3DB0", Offset = "0x50D2DB0", VA = "0x1850D3DB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x50D3F30", Offset = "0x50D2F30", VA = "0x1850D3F30")]
		private void MEKAAMJCNBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x50D4210", Offset = "0x50D3210", VA = "0x1850D4210")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x50D40F0", Offset = "0x50D30F0", VA = "0x1850D40F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x50D3DD0", Offset = "0x50D2DD0", VA = "0x1850D3DD0")]
		private void IDIDGMAMMCI(FAAGGPJNPNH JMKMDPMBLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x50D3DC0", Offset = "0x50D2DC0", VA = "0x1850D3DC0", Slot = "8")]
		protected override bool EHONOPGAPLC(bool EDJBECANDFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x50D3EC0", Offset = "0x50D2EC0", VA = "0x1850D3EC0", Slot = "9")]
		protected override void LPPHNLICIAD(bool FHAHJKBKNBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x50D4240", Offset = "0x50D3240", VA = "0x1850D4240")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		[EJHKBJPGPJF(KPKOFHBALGN.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool DNHJEGJIIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int KGPAJOLBOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool DDMHOOPAHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool PFFGLPPLFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private float ANDCDNJNHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private float DICNPMKCFCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private float FOHJKAJIDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private float GPJDHNMLJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private float MJLDBOKBEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float JFKONHMDJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private ParticleSystem.MainModule CICMIGPINAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private ParticleSystem.TrailModule GIMDNDOLFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private ParticleSystem.EmissionModule MDGNAIPLMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private ParticleSystem.CollisionModule KOAPLPLGCIF;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x50DA410", Offset = "0x50D9410", VA = "0x1850DA410")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x50DA090", Offset = "0x50D9090", VA = "0x1850DA090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x50D9B40", Offset = "0x50D8B40", VA = "0x1850D9B40")]
		private void IDIDGMAMMCI(FAAGGPJNPNH JMKMDPMBLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x50D9070", Offset = "0x50D8070", VA = "0x1850D9070")]
		private void GKAGEFNMKPL(IRecRoomQualityConfigProvider CELCHFILIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x50DA1B0", Offset = "0x50D91B0", VA = "0x1850DA1B0")]
		private void PMHNLNDCKJP(OverrideSettings GIIAJAACKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x50D9D20", Offset = "0x50D8D20", VA = "0x1850D9D20")]
		private void LHLDBFDKMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x50D9ED0", Offset = "0x50D8ED0", VA = "0x1850D9ED0")]
		private void MHMFJLBIDGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x50D9A30", Offset = "0x50D8A30", VA = "0x1850D9A30")]
		private void HOEIIIIGCLO(ParticleSystem.MinMaxCurve GANPFHFNKFA, out float OOEPIKOPFCF, out float JIKKIPFBMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x50D9C10", Offset = "0x50D8C10", VA = "0x1850D9C10")]
		private ParticleSystem.MinMaxCurve JKFALNMGHKG(ParticleSystem.MinMaxCurve GANPFHFNKFA, float OOEPIKOPFCF, float JIKKIPFBMIJ)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override NLBHCLIEFKA LLONOLFCLMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x672030", Offset = "0x671030", VA = "0x180672030", Slot = "4")]
			get
			{
				return default(NLBHCLIEFKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T GACOOCEFBLE(IRecRoomQualityConfigProvider INIOKOEDBOK);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1E1DF40", Offset = "0x1E1CF40", VA = "0x181E1DF40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E1E780", Offset = "0x1E1D780", VA = "0x181E1E780")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E1E4B0", Offset = "0x1E1D4B0", VA = "0x181E1E4B0")]
		private void IDIDGMAMMCI(FAAGGPJNPNH JMKMDPMBLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E1E1E0", Offset = "0x1E1D1E0", VA = "0x181E1E1E0")]
		private void CGHDKNMNDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1E1E4E0", Offset = "0x1E1D4E0", VA = "0x181E1E4E0", Slot = "9")]
		protected override void LPPHNLICIAD(bool FHAHJKBKNBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1D1FFA0", Offset = "0x1D1EFA0", VA = "0x181D1FFA0")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class IMAHMNINCOE
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x50D50B0", Offset = "0x50D40B0", VA = "0x1850D50B0")]
	[LPDKEEGEILI]
	private static void HILKDBELOLE()
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private enum LNLOMFGPJEC
		{
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private LNLOMFGPJEC behavior;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x50DA850", Offset = "0x50D9850", VA = "0x1850DA850", Slot = "10")]
		protected override bool GACOOCEFBLE(IRecRoomQualityConfigProvider INIOKOEDBOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x50DA830", Offset = "0x50D9830", VA = "0x1850DA830", Slot = "8")]
		protected override bool EHONOPGAPLC(bool EDJBECANDFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x50DA8A0", Offset = "0x50D98A0", VA = "0x1850DA8A0")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private enum PGGLBFKAJEC
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private PGGLBFKAJEC behavior;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x50DA8E0", Offset = "0x50D98E0", VA = "0x1850DA8E0", Slot = "10")]
		protected override bool GACOOCEFBLE(IRecRoomQualityConfigProvider INIOKOEDBOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x50DA830", Offset = "0x50D9830", VA = "0x1850DA830", Slot = "8")]
		protected override bool EHONOPGAPLC(bool EDJBECANDFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x50DA930", Offset = "0x50D9930", VA = "0x1850DA930")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private enum DPBDAEEGOKD
		{
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private DPBDAEEGOKD behavior;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x50DA970", Offset = "0x50D9970", VA = "0x1850DA970", Slot = "10")]
		protected override bool GACOOCEFBLE(IRecRoomQualityConfigProvider INIOKOEDBOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x50DA830", Offset = "0x50D9830", VA = "0x1850DA830", Slot = "8")]
		protected override bool EHONOPGAPLC(bool EDJBECANDFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x50DA9C0", Offset = "0x50D99C0", VA = "0x1850DA9C0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x50DAA10", Offset = "0x50D9A10", VA = "0x1850DAA10", Slot = "10")]
		protected override LightRenderingMode GACOOCEFBLE(IRecRoomQualityConfigProvider INIOKOEDBOK)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x50DAA00", Offset = "0x50D9A00", VA = "0x1850DAA00", Slot = "8")]
		protected override bool EHONOPGAPLC(LightRenderingMode EDJBECANDFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x50DAA70", Offset = "0x50D9A70", VA = "0x1850DAA70")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x50DAAD0", Offset = "0x50D9AD0", VA = "0x1850DAAD0", Slot = "10")]
		protected override SceneDecorationDetailLevel GACOOCEFBLE(IRecRoomQualityConfigProvider INIOKOEDBOK)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x50DAAB0", Offset = "0x50D9AB0", VA = "0x1850DAAB0", Slot = "8")]
		protected override bool EHONOPGAPLC(SceneDecorationDetailLevel EDJBECANDFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x50DAB20", Offset = "0x50D9B20", VA = "0x1850DAB20")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x50DAB80", Offset = "0x50D9B80", VA = "0x1850DAB80", Slot = "10")]
		protected override TransparencyDetailLevel GACOOCEFBLE(IRecRoomQualityConfigProvider INIOKOEDBOK)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x50DAB60", Offset = "0x50D9B60", VA = "0x1850DAB60", Slot = "8")]
		protected override bool EHONOPGAPLC(TransparencyDetailLevel EDJBECANDFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x50DABD0", Offset = "0x50D9BD0", VA = "0x1850DABD0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x50DAD00", Offset = "0x50D9D00", VA = "0x1850DAD00", Slot = "8")]
		protected override bool EHONOPGAPLC(BackgroundAnimationDetailLevel IOIIAKLHJLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x50DAD90", Offset = "0x50D9D90", VA = "0x1850DAD90", Slot = "9")]
		protected override void LPPHNLICIAD(bool MIJGBGDJCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x50DAC10", Offset = "0x50D9C10", VA = "0x1850DAC10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x50DAE20", Offset = "0x50D9E20", VA = "0x1850DAE20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x50DAF10", Offset = "0x50D9F10", VA = "0x1850DAF10")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
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
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Terrain BPMIMKHHAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TerrainData IEBPOEFHCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TerrainData GDFJGHIEDDH;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Terrain LJLLLAIPOGG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x50DB730", Offset = "0x50DA730", VA = "0x1850DB730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x50DB5A0", Offset = "0x50DA5A0", VA = "0x1850DB5A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x50DB9F0", Offset = "0x50DA9F0", VA = "0x1850DB9F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x50DB8D0", Offset = "0x50DA8D0", VA = "0x1850DB8D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x50DB8C0", Offset = "0x50DA8C0", VA = "0x1850DB8C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x50DB640", Offset = "0x50DA640", VA = "0x1850DB640")]
		private void CIHHMEPCKNG(FAAGGPJNPNH JMKMDPMBLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x50DBBA0", Offset = "0x50DABA0", VA = "0x1850DBBA0", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel NMMAKOCGAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x58DFE0", Offset = "0x58CFE0", VA = "0x18058DFE0", Slot = "8")]
		protected override bool EHONOPGAPLC(TerrainQualityLevel IOIIAKLHJLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "9")]
		protected override void LPPHNLICIAD(bool FHAHJKBKNBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x50DB7C0", Offset = "0x50DA7C0", VA = "0x1850DB7C0")]
		private void DLDIBIEIMDH(Settings BCIOFOPLLEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x50DB2D0", Offset = "0x50DA2D0", VA = "0x1850DB2D0")]
		private void AOAAECOAAKO(TreePrefabOverride[] LLGOGLKFLIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x50DB1F0", Offset = "0x50DA1F0", VA = "0x1850DB1F0")]
		private void AFAKNEAPOMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x50DB840", Offset = "0x50DA840", VA = "0x1850DB840")]
		private Settings IEELMHNGDGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x50DBE10", Offset = "0x50DAE10", VA = "0x1850DBE10")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum JNLOPEFMJLH
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PIAKOECAEGP
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color OPIICEOPPKJ);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private List<Material> LGHIGKCOBIJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject BOEELLCEGOL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x58D4A0", Offset = "0x58C4A0", VA = "0x18058D4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x50D3230", Offset = "0x50D2230", VA = "0x1850D3230")]
		public void Init(BackgroundObject PCLKDEOJIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x50D3480", Offset = "0x50D2480", VA = "0x1850D3480")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x50D35A0", Offset = "0x50D25A0", VA = "0x1850D35A0")]
		public void SetBlendValue(float PGNKHNFFAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x50D3700", Offset = "0x50D2700", VA = "0x1850D3700")]
		public void SetColor(Color OPIICEOPPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x50D3810", Offset = "0x50D2810", VA = "0x1850D3810")]
		public void SetRotation(float OHIFHLJPHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x50D3A00", Offset = "0x50D2A00", VA = "0x1850D3A00")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface FKBLAIKICNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface CAOPPPCPGDJ<T> : FKBLAIKICNB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool KOEBPBKDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T IOIIAKLHJLO);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public abstract class ActivationController : MonoBehaviour, FKBLAIKICNB
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public enum NLBHCLIEFKA
		{
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[SerializeField]
		[IMJIOIJNDBJ("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual NLBHCLIEFKA LLONOLFCLMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5BAE80", Offset = "0x5B9E80", VA = "0x1805BAE80", Slot = "4")]
			get
			{
				return default(NLBHCLIEFKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public abstract class ActivationController<T> : ActivationController, global::CAOPPPCPGDJ<T>, FKBLAIKICNB where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		protected bool? JKOAKHOGGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		protected T AMHDJHGLIPN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KOEBPBKDDCN
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1E0E180", Offset = "0x1E0D180", VA = "0x181E0E180", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DDF0", Offset = "0x1E0CDF0", VA = "0x181E0DDF0", Slot = "7")]
		public virtual void SetActivation(T IOIIAKLHJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool EHONOPGAPLC(T IOIIAKLHJLO);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void LPPHNLICIAD(bool FHAHJKBKNBI);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B5B0", Offset = "0x1D1A5B0", VA = "0x181D1B5B0")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[AddComponentMenu("")]
	public class AGProBuilderStub : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public AGProBuilderStub()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class IPBFNGMPFEA
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static byte[] FDFKLIHCMDI;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static int IKEJBHOADAH;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static int BADMEAGLBCG;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static BigInteger LKFKJFPDNAJ;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public IPBFNGMPFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x50D5210", Offset = "0x50D4210", VA = "0x1850D5210")]
	private static string OJNKOKJGCOH(byte[] BMEGDOGJIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50D5310", Offset = "0x50D4310", VA = "0x1850D5310")]
	public static string PLNHDMOHEMF(byte[] LNCIHJHIBKD, bool PDPJHLLFJEO)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
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
