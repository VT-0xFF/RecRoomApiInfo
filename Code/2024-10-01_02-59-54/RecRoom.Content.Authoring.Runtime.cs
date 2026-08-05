using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Platforms;
using RecRoom.DataLayer.Attributes;
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
	public enum IJFGHAMHADO
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
	private IJFGHAMHADO bobAxis;

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
	private float LIJBNLLNIMP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 CFLJNOPKBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D26F90", Offset = "0x6D26390", VA = "0x186D26F90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D26F50", Offset = "0x6D26350", VA = "0x186D26F50")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D27170", Offset = "0x6D26570", VA = "0x186D27170")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D273A0", Offset = "0x6D267A0", VA = "0x186D273A0")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xDE8180", Offset = "0xDE7580", VA = "0x180DE8180")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, ONAHBJJEAIF
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string JKOIMGOGJGE = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string NGDNEAOMCID = "_MainColor";

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
	private static List<Material> MFGNOINBOJE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> KGEKPKOIDNN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
	public void PrepareImposter(PAMFHMIBEOE AFAEKDPMCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D29810", Offset = "0x6D28C10", VA = "0x186D29810")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D29C60", Offset = "0x6D29060", VA = "0x186D29C60")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D29D00", Offset = "0x6D29100", VA = "0x186D29D00")]
	public void initialize(Mesh MJFPPNGBODG, Material JKPGAHNGMKB, Matrix4x4[] HECKBBKGOML, Component[] BGGHEFKBFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
	public InstancedMeshGroup()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
[NativeContainer]
public struct OFMOKHBCHKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum BGHBALEADIF
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
	public struct NGAFCOHIECA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[ReadOnly]
		public OFMOKHBCHKI OHDNOKJBFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[ReadOnly]
		public int JAFGJMJABKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public FILMDFCMCEL HFKFLKJDIHJ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A490", Offset = "0x6D29890", VA = "0x186D2A490", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct JAHHFFACPIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeSlice<Vector3> ICMPCFAJIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NativeSlice<Vector3> GNELJAACCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector4> PFPBCCHMFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector2> JJBOHCPEBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector2> GCLCLNGOBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> ALOJCGKAKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> MKLDDFODGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Color> NBKFOKGKGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<BoneWeight> HFOOCANKBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Matrix4x4> GODGIILIFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<int> PAKBAAILEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<int> EKEABOHDABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> EHHBJGOACCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> IMDNHPCLDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<byte> ANOIAFKLAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int HPFNGBMFFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Matrix4x4 HOECJKKEKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool PDPMOPJPFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int MLDAHMCENAO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> ICMPCFAJIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<int> NEJKHGMFIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector3> GNELJAACCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector4> PFPBCCHMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> JJBOHCPEBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> GCLCLNGOBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Vector2> ALOJCGKAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector2> MKLDDFODGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<Color> NBKFOKGKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<BoneWeight> HFOOCANKBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> IMDNHPCLDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> FHEELOMBFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> FJFKGJFGACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<Matrix4x4> GODGIILIFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> GOEODGLPEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> PAKBAAILEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> CMACMEBHCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<Matrix4x4> JCLKJLCJBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<byte> EDLHBDFKGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> PGCAOGNMPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<int> FPCCPBEFLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> DADJPCBDBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<sbyte> ALLLEIPCCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> DAJMINDIEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> NBHDMAGILGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<byte> CBOHPCADHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> KFGKLJIGEPP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HDHLCJHOPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B200", Offset = "0x6D2A600", VA = "0x186D2B200")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B210", Offset = "0x6D2A610", VA = "0x186D2B210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OEDNIFABHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B350", Offset = "0x6D2A750", VA = "0x186D2B350")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B1F0", Offset = "0x6D2A5F0", VA = "0x186D2B1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GCLABMMKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B600", Offset = "0x6D2AA00", VA = "0x186D2B600")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B5F0", Offset = "0x6D2A9F0", VA = "0x186D2B5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BGHBALEADIF FFIFJCMJKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B5E0", Offset = "0x6D2A9E0", VA = "0x186D2B5E0")]
		get
		{
			return default(BGHBALEADIF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B1E0", Offset = "0x6D2A5E0", VA = "0x186D2B1E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JAHHFFACPIB CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B610", Offset = "0x6D2AA10", VA = "0x186D2B610")]
		get
		{
			return default(JAHHFFACPIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BBF0", Offset = "0x6D2AFF0", VA = "0x186D2BBF0")]
	public OFMOKHBCHKI(IList<Mesh> FIOEKKGBMLO, IList<int> IFLLEGIGEGK, IList<int> CMNKJKDKNCP, IList<int[]> ONFAOAIDHEK, IList<Matrix4x4> KIFBOHBJGKO, IList<bool> BBGLLLCKEBL, IList<int> CMCLFIEFBCL, Allocator MGFIHPDNFPH, BGHBALEADIF LJHFGKCNDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B220", Offset = "0x6D2A620", VA = "0x186D2B220")]
	public FILMDFCMCEL CDPPDEPCJDK(int NLCHLLGFHIH, Allocator MGFIHPDNFPH)
	{
		return default(FILMDFCMCEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B360", Offset = "0x6D2A760", VA = "0x186D2B360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
public struct FILMDFCMCEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<Vector3> ICMPCFAJIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeArray<Vector3> GNELJAACCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector4> PFPBCCHMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector2> JJBOHCPEBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector2> GCLCLNGOBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> ALOJCGKAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> MKLDDFODGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Color> NBKFOKGKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<BoneWeight> HFOOCANKBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Matrix4x4> GODGIILIFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> PAKBAAILEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private NativeArray<int> EKEABOHDABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private NativeArray<int> EHHBJGOACCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> KFGKLJIGEPP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int ABKCCJEPNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D28BB0", Offset = "0x6D27FB0", VA = "0x186D28BB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D28600", Offset = "0x6D27A00", VA = "0x186D28600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D28BC0", Offset = "0x6D27FC0", VA = "0x186D28BC0")]
	public FILMDFCMCEL(int EFBGMAKMMFP, int IBJMCGKFFLP, int KHCLKDAKNBO, int NLCHLLGFHIH, Allocator MGFIHPDNFPH, bool[] JAOPAKCJLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D28AE0", Offset = "0x6D27EE0", VA = "0x186D28AE0")]
	public void IEEEPGBNLEC(int MIMLBNAMKDF, int GMCJIJBLJPF, int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D28A30", Offset = "0x6D27E30", VA = "0x186D28A30")]
	public int[] EAGALANFPAF(int MIMLBNAMKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D28570", Offset = "0x6D27970", VA = "0x186D28570")]
	private NativeSlice<int> BHDKPNMEPAA(int MIMLBNAMKDF)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D288C0", Offset = "0x6D27CC0", VA = "0x186D288C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D28610", Offset = "0x6D27A10", VA = "0x186D28610")]
	public Mesh CAIJLJDCELG([Optional] string DCOHAAJFDDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FNOMBHEJKIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<Mesh> EINIOGJJGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<int> NLOCBHFKIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<bool> PHDMEFGLMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int[]> DHJDKFNELMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Matrix4x4> NCCEMIOCFAB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D292B0", Offset = "0x6D286B0", VA = "0x186D292B0")]
	public void NFAIFEDKEOB(Mesh JIPKNCLPFGJ, int[] ALNDLBDLINE, Matrix4x4 CLELPODBLMJ, bool BBGLLLCKEBL = false, int NOILLGHJOBB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D28FB0", Offset = "0x6D283B0", VA = "0x186D28FB0")]
	public OFMOKHBCHKI AKPJFCHDKEA(Allocator MGFIHPDNFPH, OFMOKHBCHKI.BGHBALEADIF LJHFGKCNDIL, [Optional] IList<int> CMNKJKDKNCP, [Optional] IList<int> CJNGCKLANIP)
	{
		return default(OFMOKHBCHKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D29060", Offset = "0x6D28460", VA = "0x186D29060")]
	private static void MCFNHBDCPAA(Mesh JIPKNCLPFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D29570", Offset = "0x6D28970", VA = "0x186D29570")]
	public FNOMBHEJKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RequireComponent(typeof(ParticleSystem))]
[DisallowMultipleComponent]
public class ParticleSystemTextureStreamerTag : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EB90", Offset = "0x6D2DF90", VA = "0x186D2EB90")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
	public ParticleSystemTextureStreamerTag()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
	private EIODKICMOOK playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EIODKICMOOK IBEDLHMKJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510")]
		get
		{
			return default(EIODKICMOOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6329E10", Offset = "0x6329210", VA = "0x186329E10")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D2EEB0", Offset = "0x6D2E2B0", VA = "0x186D2EEB0")]
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
	public bool EGODMOMNBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F560", Offset = "0x6D2E960", VA = "0x186D2F560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
	public ShippingContainer()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Content_Authoring_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D30460", Offset = "0x6D2F860", VA = "0x186D30460", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OPBJHHCCJDF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LJFMMOBCKBA EDNHKFOJJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JEIAMONHOFF<LJFMMOBCKBA> AHJKJPOCFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum LJFMMOBCKBA
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
		private Light KLDNAADKKAB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Light FFANHBKFFJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D2EB00", Offset = "0x6D2DF00", VA = "0x186D2EB00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E990", Offset = "0x6D2DD90", VA = "0x186D2E990")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EAB0", Offset = "0x6D2DEB0", VA = "0x186D2EAB0")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, ONAHBJJEAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly int EGGFJJNNBDP;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D29970", Offset = "0x6D28D70", VA = "0x186D29970")]
		private void OCDPFKHMGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6D298A0", Offset = "0x6D28CA0", VA = "0x186D298A0")]
		private void GIPEKFNOKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6D29B10", Offset = "0x6D28F10", VA = "0x186D29B10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D29AA0", Offset = "0x6D28EA0", VA = "0x186D29AA0", Slot = "4")]
		public void PrepareImposter(PAMFHMIBEOE AFAEKDPMCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D29E70", Offset = "0x6D29270", VA = "0x186D29E70")]
		public void ClearProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D29F40", Offset = "0x6D29340", VA = "0x186D29F40")]
		public void SetColor(string ADANIHOIEKJ, Color LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A050", Offset = "0x6D29450", VA = "0x186D2A050")]
		public void SetFloat(string ADANIHOIEKJ, float LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A380", Offset = "0x6D29780", VA = "0x186D2A380")]
		public void SetVector(string ADANIHOIEKJ, Vector4 LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A250", Offset = "0x6D29650", VA = "0x186D2A250")]
		public void SetVector(string ADANIHOIEKJ, float CFANGCOBGCF, float HHLCHNICLGA, float CLBJBMGHOBK, float AFOFNIJDOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A150", Offset = "0x6D29550", VA = "0x186D2A150")]
		public void SetTexture(string ADANIHOIEKJ, Texture2D LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public MaterialInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GPNEMOHLDOH
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetDesiredMipLevel();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DAGEFJGHOII
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOGBIIAFJPF(GPNEMOHLDOH ABHBOGCHEOH, Texture2D KDKJOONKNHD);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICELJEBKCFP(GPNEMOHLDOH ABHBOGCHEOH, Texture2D KDKJOONKNHD);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHLEAOJFLDA(ParticleSystem BPEKDHBHFLI);
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public delegate void EFAIHKDAAFJ(ParticleEventListener CKGGOPMBENM, Collider OCKBFCIKBEN, IEnumerable<ParticleCollisionEvent> PHGIHHIPGKJ);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> BMOLOEIEGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EFAIHKDAAFJ CFCLCEJCGOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6D2D840", Offset = "0x6D2CC40", VA = "0x186D2D840")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6D2D8E0", Offset = "0x6D2CCE0", VA = "0x186D2D8E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D4E0", Offset = "0x6D2C8E0", VA = "0x186D2D4E0")]
		private void OnParticleCollision(GameObject OCKBFCIKBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
		[DAFFMLLPHJC("UseSpacePartition")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D2F670", Offset = "0x6D2EA70", VA = "0x186D2F670")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D2F690", Offset = "0x6D2EA90", VA = "0x186D2F690")]
		public bool HIHGLKKHDHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F7B0", Offset = "0x6D2EBB0", VA = "0x186D2F7B0")]
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
		private bool IMFMDNLMFJN;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override IEPJDBIGJBH KAMJBAHOKIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x912E20", Offset = "0x912220", VA = "0x180912E20", Slot = "4")]
			get
			{
				return default(IEPJDBIGJBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6D28110", Offset = "0x6D27510", VA = "0x186D28110")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D28190", Offset = "0x6D27590", VA = "0x186D28190")]
		private void DDDJEEOODAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D28500", Offset = "0x6D27900", VA = "0x186D28500")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D283E0", Offset = "0x6D277E0", VA = "0x186D283E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D28330", Offset = "0x6D27730", VA = "0x186D28330")]
		private void GMCLFDIHJKL(LJFMMOBCKBA PFDAOBPDJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x18090E0", Offset = "0x18084E0", VA = "0x1818090E0", Slot = "7")]
		protected override bool PFLFEDBNPOG(bool PCFDHAMPJPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D28120", Offset = "0x6D27520", VA = "0x186D28120", Slot = "8")]
		protected override void CGHPMPNGMCL(bool LPAGIGPJJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D28530", Offset = "0x6D27930", VA = "0x186D28530")]
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
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool NNFDMKHCCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int GILJLHCECKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool IGGHNLPBGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private bool ELMJJIINLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float JLCBIBCPIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float HGKDDMGBHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float ONGIHNGPGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float KFECFCCMALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float LHODALLOFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float CDCHDBACEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.MainModule HEAFCPOMLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ParticleSystem.TrailModule AAAEJAEDGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ParticleSystem.EmissionModule KGBIGOFLDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ParticleSystem.CollisionModule JKAJNMAEEMK;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E7D0", Offset = "0x6D2DBD0", VA = "0x186D2E7D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E6C0", Offset = "0x6D2DAC0", VA = "0x186D2E6C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E020", Offset = "0x6D2D420", VA = "0x186D2E020")]
		private void GMCLFDIHJKL(LJFMMOBCKBA PFDAOBPDJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D980", Offset = "0x6D2CD80", VA = "0x186D2D980")]
		private void CNBOJFLLBFC(IRecRoomQualityConfigProvider IBOPOOBMBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E1D0", Offset = "0x6D2D5D0", VA = "0x186D2E1D0")]
		private void IDALFGHBBIL(OverrideSettings GAKPOGKFDME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6D2DE80", Offset = "0x6D2D280", VA = "0x186D2DE80")]
		private void GKDOKAAHPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E3E0", Offset = "0x6D2D7E0", VA = "0x186D2E3E0")]
		private void IGDJKMMEKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E0A0", Offset = "0x6D2D4A0", VA = "0x186D2E0A0")]
		private void HHGMPIJKBBH(ParticleSystem.MinMaxCurve ONPOPNDPDKI, [Out] float AFMEEOHJNNA, [Out] float DKEJJDDCLIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E580", Offset = "0x6D2D980", VA = "0x186D2E580")]
		private ParticleSystem.MinMaxCurve KHFFKKDIDPN(ParticleSystem.MinMaxCurve ONPOPNDPDKI, float AFMEEOHJNNA, float DKEJJDDCLIM)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override IEPJDBIGJBH KAMJBAHOKIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x912E20", Offset = "0x912220", VA = "0x180912E20", Slot = "4")]
			get
			{
				return default(IEPJDBIGJBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract T LNJHAFPKMPA(IRecRoomQualityConfigProvider HAPLABELDEB);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9F00", Offset = "0x4BB9300", VA = "0x184BB9F00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA660", Offset = "0x4BB9A60", VA = "0x184BBA660")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA510", Offset = "0x4BB9910", VA = "0x184BBA510")]
		private void GMCLFDIHJKL(LJFMMOBCKBA PFDAOBPDJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA330", Offset = "0x4BB9730", VA = "0x184BBA330")]
		private void GHDEOODEBAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA2F0", Offset = "0x4BB96F0", VA = "0x184BBA2F0", Slot = "8")]
		protected override void CGHPMPNGMCL(bool LPAGIGPJJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3B09620", Offset = "0x3B08A20", VA = "0x183B09620")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class AANBPLGOBKI
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D265B0", Offset = "0x6D259B0", VA = "0x186D265B0")]
	[FHFMOACGLML.PCGBCKINAAE]
	internal static void EJGLCCJGHFF(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private enum MBGANNEMOEC
		{
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private MBGANNEMOEC behavior;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EED0", Offset = "0x6D2E2D0", VA = "0x186D2EED0", Slot = "9")]
		protected override bool LNJHAFPKMPA(IRecRoomQualityConfigProvider HAPLABELDEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EF20", Offset = "0x6D2E320", VA = "0x186D2EF20", Slot = "7")]
		protected override bool PFLFEDBNPOG(bool PCFDHAMPJPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EF40", Offset = "0x6D2E340", VA = "0x186D2EF40")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private enum ELJIJAPGGAL
		{
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private ELJIJAPGGAL behavior;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EF80", Offset = "0x6D2E380", VA = "0x186D2EF80", Slot = "9")]
		protected override bool LNJHAFPKMPA(IRecRoomQualityConfigProvider HAPLABELDEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EF20", Offset = "0x6D2E320", VA = "0x186D2EF20", Slot = "7")]
		protected override bool PFLFEDBNPOG(bool PCFDHAMPJPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EFD0", Offset = "0x6D2E3D0", VA = "0x186D2EFD0")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private enum BEBDMHCBBAK
		{
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private BEBDMHCBBAK behavior;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F010", Offset = "0x6D2E410", VA = "0x186D2F010", Slot = "9")]
		protected override bool LNJHAFPKMPA(IRecRoomQualityConfigProvider HAPLABELDEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EF20", Offset = "0x6D2E320", VA = "0x186D2EF20", Slot = "7")]
		protected override bool PFLFEDBNPOG(bool PCFDHAMPJPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F060", Offset = "0x6D2E460", VA = "0x186D2F060")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D2F0A0", Offset = "0x6D2E4A0", VA = "0x186D2F0A0", Slot = "9")]
		protected override LightRenderingMode LNJHAFPKMPA(IRecRoomQualityConfigProvider HAPLABELDEB)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F100", Offset = "0x6D2E500", VA = "0x186D2F100", Slot = "7")]
		protected override bool PFLFEDBNPOG(LightRenderingMode PCFDHAMPJPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F110", Offset = "0x6D2E510", VA = "0x186D2F110")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D2F150", Offset = "0x6D2E550", VA = "0x186D2F150", Slot = "9")]
		protected override SceneDecorationDetailLevel LNJHAFPKMPA(IRecRoomQualityConfigProvider HAPLABELDEB)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F1A0", Offset = "0x6D2E5A0", VA = "0x186D2F1A0", Slot = "7")]
		protected override bool PFLFEDBNPOG(SceneDecorationDetailLevel PCFDHAMPJPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F1C0", Offset = "0x6D2E5C0", VA = "0x186D2F1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D2F200", Offset = "0x6D2E600", VA = "0x186D2F200", Slot = "9")]
		protected override TransparencyDetailLevel LNJHAFPKMPA(IRecRoomQualityConfigProvider HAPLABELDEB)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F250", Offset = "0x6D2E650", VA = "0x186D2F250", Slot = "7")]
		protected override bool PFLFEDBNPOG(TransparencyDetailLevel PCFDHAMPJPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F270", Offset = "0x6D2E670", VA = "0x186D2F270")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D2F490", Offset = "0x6D2E890", VA = "0x186D2F490", Slot = "7")]
		protected override bool PFLFEDBNPOG(BackgroundAnimationDetailLevel GFHHGCNKOMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F360", Offset = "0x6D2E760", VA = "0x186D2F360", Slot = "8")]
		protected override void CGHPMPNGMCL(bool MEFHKNCMBDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F2B0", Offset = "0x6D2E6B0", VA = "0x186D2F2B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F3E0", Offset = "0x6D2E7E0", VA = "0x186D2F3E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F520", Offset = "0x6D2E920", VA = "0x186D2F520")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Terrain LNPPLNKGAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TerrainData EGBDBHDNMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TerrainData MPACPJLICJD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Terrain AGMPGNGPFAN
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6D2FBE0", Offset = "0x6D2EFE0", VA = "0x186D2FBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F840", Offset = "0x6D2EC40", VA = "0x186D2F840")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2FF90", Offset = "0x6D2F390", VA = "0x186D2FF90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2FE80", Offset = "0x6D2F280", VA = "0x186D2FE80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2FE70", Offset = "0x6D2F270", VA = "0x186D2FE70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D2FD40", Offset = "0x6D2F140", VA = "0x186D2FD40")]
		private void ICNJJEDDDNG(LJFMMOBCKBA PFDAOBPDJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D30110", Offset = "0x6D2F510", VA = "0x186D30110", Slot = "6")]
		public override void SetActivation(TerrainQualityLevel FDOMKNFHNJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "7")]
		protected override bool PFLFEDBNPOG(TerrainQualityLevel GFHHGCNKOMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "8")]
		protected override void CGHPMPNGMCL(bool LPAGIGPJJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D2FDF0", Offset = "0x6D2F1F0", VA = "0x186D2FDF0")]
		private void NAJGMBFDFMP(Settings LDMELPIIKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D2F8D0", Offset = "0x6D2ECD0", VA = "0x186D2F8D0")]
		private void BPGMDOCLDEC(TreePrefabOverride[] GKABPJFHGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D2FC70", Offset = "0x6D2F070", VA = "0x186D2FC70")]
		private void GDBAHFDGCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6D2FB60", Offset = "0x6D2EF60", VA = "0x186D2FB60")]
		private Settings CGKKMFPAIMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6D302E0", Offset = "0x6D2F6E0", VA = "0x186D302E0")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum EIODKICMOOK
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MJNELMDEOHA
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color DFKHKPKCOFI);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private List<Material> ECOFEMFIBDK;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BackgroundObject PDGPPIBOLKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6D266B0", Offset = "0x6D25AB0", VA = "0x186D266B0")]
		public void Init(BackgroundObject PJJHJGOPMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D26900", Offset = "0x6D25D00", VA = "0x186D26900")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6D26A20", Offset = "0x6D25E20", VA = "0x186D26A20")]
		public void SetBlendValue(float HECJFGCHNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D26B90", Offset = "0x6D25F90", VA = "0x186D26B90")]
		public void SetColor(Color DFKHKPKCOFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D26CC0", Offset = "0x6D260C0", VA = "0x186D26CC0")]
		public void SetRotation(float EFFHGIJAIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6D26E90", Offset = "0x6D26290", VA = "0x186D26E90")]
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
		public enum IEPJDBIGJBH
		{
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		[DAFFMLLPHJC("OnSceneOrPrefabSaveBehavior", IEPJDBIGJBH.EnableIfAllowed)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual IEPJDBIGJBH KAMJBAHOKIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "4")]
			get
			{
				return default(IEPJDBIGJBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class ActivationController<T> : ActivationController where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		protected bool? AAGFKINBIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		protected T KLHPHKEMHDP;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GIDDDGMJFFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x432E7A0", Offset = "0x432DBA0", VA = "0x18432E7A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x432E510", Offset = "0x432D910", VA = "0x18432E510", Slot = "6")]
		public virtual void SetActivation(T GFHHGCNKOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool PFLFEDBNPOG(T GFHHGCNKOMD);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void CGHPMPNGMCL(bool LPAGIGPJJCK);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C7430", Offset = "0x8C6830", VA = "0x1808C7430")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.CullableBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[UnityEngine.Scripting.Preserve]
	public class CullableBatchLOD : MonoBehaviour, MGJHENFBMOI
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public class BatchedRenderer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Renderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public bool visibleInBatch;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public bool Enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x6D26F20", Offset = "0x6D26320", VA = "0x186D26F20")]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public BatchedRenderer[] revealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public LODGroup[] revealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public BatchedRenderer[] nonRevealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public LODGroup[] nonRevealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		public int subMeshCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		public int startRenderableSubmshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		private GGHKEJOODBA toggleBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private Bounds DGIPNPAPPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private Material LBOPCEJDNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private HCEPAGFHOMC<CullableBatchLOD> DBIFLCNMMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Mesh JIPKNCLPFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool KCPEDKCNCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool FKIGOMCOBKF;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D27550", Offset = "0x6D26950", VA = "0x186D27550")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6D27A50", Offset = "0x6D26E50", VA = "0x186D27A50")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D273B0", Offset = "0x6D267B0", VA = "0x186D273B0")]
		private static float NJDPCKBAKFF(Vector3 MGPKNBCIADF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D274C0", Offset = "0x6D268C0", VA = "0x186D274C0")]
		public void SetContentsVisibility(bool PCEKABFDEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D273D0", Offset = "0x6D267D0", VA = "0x186D273D0", Slot = "5")]
		public void OnChangedDistanceBand(GGHKEJOODBA JDADDGIEFHK, GGHKEJOODBA DHLGCOJLBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
		public void OnChangedVisibility(bool LNDNKAMNDAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6D27400", Offset = "0x6D26800", VA = "0x186D27400")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6D27CE0", Offset = "0x6D270E0", VA = "0x186D27CE0")]
		public CullableBatchLOD()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D90", Offset = "0x8D3190", VA = "0x1808D3D90", Slot = "4")]
		private Transform CMOCPCCMIBN()
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
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Vector4[] baseColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Vector4[] specColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Vector4[] emissionColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Vector4[] halfProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Vector4[] secondaryTextureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[FormerlySerializedAs("renderer")]
		public MeshRenderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public CullableBatchLODMaterialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchShaderManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D27D00", Offset = "0x6D27100", VA = "0x186D27D00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EE70", Offset = "0x6D2E270", VA = "0x186D2EE70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D2EE70", Offset = "0x6D2E270", VA = "0x186D2EE70")]
		private void AAGFMJIGHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
