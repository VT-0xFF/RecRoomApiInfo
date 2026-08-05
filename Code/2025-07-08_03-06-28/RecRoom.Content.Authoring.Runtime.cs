using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Platforms;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
	public enum KJMOJLLAPBC
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
	private KJMOJLLAPBC bobAxis;

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
	private float EOBJDNOEEID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 AGPCOFKHHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FE95B0", Offset = "0x7FE83B0", VA = "0x187FE95B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FE97A0", Offset = "0x7FE85A0", VA = "0x187FE97A0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FE97E0", Offset = "0x7FE85E0", VA = "0x187FE97E0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9A20", Offset = "0x7FE8820", VA = "0x187FE9A20")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1514340", Offset = "0x1513140", VA = "0x181514340")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, BDFOMBKFGEB
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string PICIGCMPLOP = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string KFHHCEFJBPK = "_MainColor";

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
	private static List<Material> LEJBHBJBOMG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> FIBJOFNKOEK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public void PrepareImposter(HMEICLGJFBH OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE0A0", Offset = "0x7FECEA0", VA = "0x187FEE0A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FEE500", Offset = "0x7FED300", VA = "0x187FEE500")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE5A0", Offset = "0x7FED3A0", VA = "0x187FEE5A0")]
	public void initialize(Mesh KFPIMMOABHP, Material DOADKBMFLEI, Matrix4x4[] LADNNCDOFGC, Component[] HBMEDEECFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
	public InstancedMeshGroup()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
[NativeContainer]
public struct IIFIJEMCDAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum GKHALBIOKHO
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
	public struct JAFJJELHHKL : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[ReadOnly]
		public IIFIJEMCDAI PHIDGLACEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[ReadOnly]
		public int CDGBEFDIKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public FNAJCPLMPML MELFAFJMGMD;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE710", Offset = "0x7FED510", VA = "0x187FEE710", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct CICMFAFBADK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeSlice<Vector3> KGIAABJAALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NativeSlice<Vector3> LOGPOEEIFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector4> DABMBJJEBOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector2> NBIHODMAPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector2> BLEIEAAPGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> KJBPJBAMCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> PGPLCNPPJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Color> PMAHFIGLOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<BoneWeight> PECGHNGHBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Matrix4x4> PIIJACPDFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<int> HOHBLPIPPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<int> NAMHPFMELJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> LLNKHGKHJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> BOBBFOCNPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<byte> NFJBJHKJHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int JDJIOMGBIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Matrix4x4 GIHIPNEKFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool ONPEIMNCJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int EPAOIMKNIBM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> KGIAABJAALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<int> FMCIIJCKKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector3> LOGPOEEIFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector4> DABMBJJEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> NBIHODMAPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> BLEIEAAPGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Vector2> KJBPJBAMCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector2> PGPLCNPPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<Color> PMAHFIGLOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<BoneWeight> PECGHNGHBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> BOBBFOCNPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> GDBGOMCLLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> PLFOFOJKBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<Matrix4x4> PIIJACPDFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> FLAHALHCHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> HOHBLPIPPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> KMHBNDIJBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<Matrix4x4> GPBIFEAIEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<byte> OHDMFOMDIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> OFFNKEIFKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<int> EGNOOGIPDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> HJJEGOEMBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<sbyte> ILLHJCIKLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> MFMHIPEFDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> FECOGPCJCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<byte> FHEEHIIKJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> PPJIEIMHMMB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EEHPJFMDFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC570", Offset = "0x7FEB370", VA = "0x187FEC570")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC540", Offset = "0x7FEB340", VA = "0x187FEC540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ILCABFAPDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FEBCC0", Offset = "0x7FEAAC0", VA = "0x187FEBCC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC550", Offset = "0x7FEB350", VA = "0x187FEC550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GHPNJIGMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC560", Offset = "0x7FEB360", VA = "0x187FEC560")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FEBCD0", Offset = "0x7FEAAD0", VA = "0x187FEBCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GKHALBIOKHO GHECPCPPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC580", Offset = "0x7FEB380", VA = "0x187FEC580")]
		get
		{
			return default(GKHALBIOKHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC590", Offset = "0x7FEB390", VA = "0x187FEC590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private CICMFAFBADK CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7FEBF60", Offset = "0x7FEAD60", VA = "0x187FEBF60")]
		get
		{
			return default(CICMFAFBADK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC6D0", Offset = "0x7FEB4D0", VA = "0x187FEC6D0")]
	public IIFIJEMCDAI(IList<Mesh> KNNKEBBLJNP, IList<int> LDEJLHPCGOK, IList<int> FFIMIPGOEJB, IList<int[]> LCIFKGICNDO, IList<Matrix4x4> PDPACKOPBOL, IList<bool> FHDMKCNLHAF, IList<int> OIBABHDMFJE, Allocator DFGMDNGNOEN, GKHALBIOKHO NGKCAGOOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC5A0", Offset = "0x7FEB3A0", VA = "0x187FEC5A0")]
	public FNAJCPLMPML OJGFCBPPEEF(int AHPHBFOMJIN, Allocator DFGMDNGNOEN)
	{
		return default(FNAJCPLMPML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBCE0", Offset = "0x7FEAAE0", VA = "0x187FEBCE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
public struct FNAJCPLMPML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<Vector3> KGIAABJAALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeArray<Vector3> LOGPOEEIFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector4> DABMBJJEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector2> NBIHODMAPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector2> BLEIEAAPGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> KJBPJBAMCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> PGPLCNPPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Color> PMAHFIGLOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<BoneWeight> PECGHNGHBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Matrix4x4> PIIJACPDFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> HOHBLPIPPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private NativeArray<int> NAMHPFMELJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private NativeArray<int> LLNKHGKHJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> PPJIEIMHMMB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BIJHOPPEGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7FEB0F0", Offset = "0x7FE9EF0", VA = "0x187FEB0F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7FEAB60", Offset = "0x7FE9960", VA = "0x187FEAB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB1B0", Offset = "0x7FE9FB0", VA = "0x187FEB1B0")]
	public FNAJCPLMPML(int JHMCDMNLPNI, int CMEIMLDBIIB, int BOPLBCKBBFH, int AHPHBFOMJIN, Allocator DFGMDNGNOEN, bool[] CEKMKAEJOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEACE0", Offset = "0x7FE9AE0", VA = "0x187FEACE0")]
	public void FPNJOEGHKIN(int FGHFHPDFCBF, int DOBKAGHAEBK, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB100", Offset = "0x7FE9F00", VA = "0x187FEB100")]
	public int[] ONEKKIJLEHN(int FGHFHPDFCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEADB0", Offset = "0x7FE9BB0", VA = "0x187FEADB0")]
	private NativeSlice<int> HGGPMNPLDLL(int FGHFHPDFCBF)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAB70", Offset = "0x7FE9970", VA = "0x187FEAB70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAE40", Offset = "0x7FE9C40", VA = "0x187FEAE40")]
	public Mesh JDFMHAGBLPC([Optional] string IMNHKJGLBPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GJKOPBKAJCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<Mesh> KIGABCAOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<int> NDNNGKFHFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<bool> AEIMMGHPAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int[]> JJLEJJOBFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Matrix4x4> DBLHLLJADEC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB5A0", Offset = "0x7FEA3A0", VA = "0x187FEB5A0")]
	public void BDONGONABHC(Mesh JLPONKINLEO, int[] AECNDNNKHNH, Matrix4x4 OEJBOPLGCGK, bool FHDMKCNLHAF = false, int LEKJKGJFHHP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBA50", Offset = "0x7FEA850", VA = "0x187FEBA50")]
	public IIFIJEMCDAI CGOIKJJPPIB(Allocator DFGMDNGNOEN, IIFIJEMCDAI.GKHALBIOKHO NGKCAGOOJBA, [Optional] IList<int> FFIMIPGOEJB, [Optional] IList<int> AEJKLDOFPKJ)
	{
		return default(IIFIJEMCDAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB7F0", Offset = "0x7FEA5F0", VA = "0x187FEB7F0")]
	private static void BFFGDGALHPG(Mesh JLPONKINLEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBB00", Offset = "0x7FEA900", VA = "0x187FEBB00")]
	public GJKOPBKAJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RequireComponent(typeof(ParticleSystem))]
[DisallowMultipleComponent]
public class ParticleSystemTextureStreamerTag : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1430", Offset = "0x7FF0230", VA = "0x187FF1430")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1390", Offset = "0x7FF0190", VA = "0x187FF1390")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FF11D0", Offset = "0x7FEFFD0", VA = "0x187FF11D0")]
	private bool DMJBLNCOOCI([Out] BNOHBBMEEKN HEJIJKOGOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
	public ParticleSystemTextureStreamerTag()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	private LJKKCBMICIM playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LJKKCBMICIM GLNKNGFIDHP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
		get
		{
			return default(LJKKCBMICIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7412650", Offset = "0x7411450", VA = "0x187412650")]
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
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1590", Offset = "0x7FF0390", VA = "0x187FF1590")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MAAADLDCIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1C40", Offset = "0x7FF0A40", VA = "0x187FF1C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
	public ShippingContainer()
	{
	}
}
namespace _LogRegistration.RecRoom_Content_Authoring_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF460", Offset = "0x7FEE260", VA = "0x187FEF460", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Content_Authoring_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2E10", Offset = "0x7FF1C10", VA = "0x187FF2E10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OAJCAKIGJOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EMDPMHOMJFK PPFGGABGHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IKLFNFDBNDM<EMDPMHOMJFK> DIJAABIEGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum EMDPMHOMJFK
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Count
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(Light))]
	[ExecuteInEditMode]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Light FHCJKFOCNNG;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Light PGNIAJJPJIM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7FF1140", Offset = "0x7FEFF40", VA = "0x187FF1140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0FD0", Offset = "0x7FEFDD0", VA = "0x187FF0FD0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF10F0", Offset = "0x7FEFEF0", VA = "0x187FF10F0")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, BDFOMBKFGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[LHHMDDGFBKD(NKIOFDIBBLL.SelfAndParent, false, false, false)]
		private KBAIFKCGHKI OEJICCLKFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static readonly int JBJPLILJALD;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE130", Offset = "0x7FECF30", VA = "0x187FEE130")]
		private void CHBNBLJKGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE270", Offset = "0x7FED070", VA = "0x187FEE270")]
		private void LCPALPFLKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE3B0", Offset = "0x7FED1B0", VA = "0x187FEE3B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE340", Offset = "0x7FED140", VA = "0x187FEE340", Slot = "4")]
		public void PrepareImposter(HMEICLGJFBH OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public InstanceColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class MaterialInstance : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Renderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF4F0", Offset = "0x7FEE2F0", VA = "0x187FEF4F0")]
		public void ClearProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF5C0", Offset = "0x7FEE3C0", VA = "0x187FEF5C0")]
		public void SetColor(string GGDFKFACHGG, Color BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF6D0", Offset = "0x7FEE4D0", VA = "0x187FEF6D0")]
		public void SetFloat(string GGDFKFACHGG, float BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFA00", Offset = "0x7FEE800", VA = "0x187FEFA00")]
		public void SetVector(string GGDFKFACHGG, Vector4 BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF8D0", Offset = "0x7FEE6D0", VA = "0x187FEF8D0")]
		public void SetVector(string GGDFKFACHGG, float DHOMBGCEEAK, float EDBCCDDDLPI, float OIBFEOGMFMP, float DIBMLEMJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF7D0", Offset = "0x7FEE5D0", VA = "0x187FEF7D0")]
		public void SetTexture(string GGDFKFACHGG, Texture2D BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public MaterialInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PHPIFALDHFO
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetDesiredMipLevel();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BNOHBBMEEKN
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOOAKCMFCFB(PHPIFALDHFO HFIIHHGNIJN, Texture2D HINEJAGCAOK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLBPBBFKMMG(PHPIFALDHFO HFIIHHGNIJN, Texture2D HINEJAGCAOK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFIPLJMAAPF(ParticleSystem KCJOFFENGCM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLJACHJMMIE(ParticleSystem KCJOFFENGCM);
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public delegate void KFHEFOAEGHH(ParticleEventListener KBACIIPKKOA, Collider LOKLFHKEJPC, IEnumerable<ParticleCollisionEvent> AFPNHMEEGHE);

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static readonly List<ParticleCollisionEvent> DOKOKLPFMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KFHEFOAEGHH OLMDJEMAGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7FEFE80", Offset = "0x7FEEC80", VA = "0x187FEFE80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7FEFF20", Offset = "0x7FEED20", VA = "0x187FEFF20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFB10", Offset = "0x7FEE910", VA = "0x187FEFB10")]
		private void OnParticleCollision(GameObject LOKLFHKEJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[GFLDJILPEIO("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("If true, the StaticBatcher will not generate batches that only contain 1 Renderer. Disabling this can be useful for debugging why certain objects cannot batch. This setting does not affect LOD groups: batches of 1 LOD group are never created.")]
		public bool RemoveBatchesOfOneRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1D60", Offset = "0x7FF0B60", VA = "0x187FF1D60")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1D80", Offset = "0x7FF0B80", VA = "0x187FF1D80")]
		public bool BGIJEKJPIOL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1EB0", Offset = "0x7FF0CB0", VA = "0x187FF1EB0")]
		public StaticBatchMeshData()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool GLKJLDNHPHE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override FHPNKGIAPJN MPAIGEJANHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xCDFFB0", Offset = "0xCDEDB0", VA = "0x180CDFFB0", Slot = "4")]
			get
			{
				return default(FHPNKGIAPJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA700", Offset = "0x7FE9500", VA = "0x187FEA700")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA950", Offset = "0x7FE9750", VA = "0x187FEA950")]
		private void PNMDNOOJMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7FEAAF0", Offset = "0x7FE98F0", VA = "0x187FEAAF0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA830", Offset = "0x7FE9630", VA = "0x187FEA830")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA780", Offset = "0x7FE9580", VA = "0x187FEA780")]
		private void LNDMKEEJGNE(EMDPMHOMJFK ANLKAIKHAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8740", Offset = "0x1FB7540", VA = "0x181FB8740", Slot = "7")]
		protected override bool PDGNFPFOBMH(bool IFKGDGBCKGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA710", Offset = "0x7FE9510", VA = "0x187FEA710", Slot = "8")]
		protected override void JKANICBIDHB(bool JNNHLDCBABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7FEAB20", Offset = "0x7FE9920", VA = "0x187FEAB20")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool HEOBJPJNHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int AAHOFADHAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private bool PMPFFGHLGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private bool HHOIPEIIKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float BJCGJCFDPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float HMMOHGFAPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float OPGANGFCALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float EGEJNMMHNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private float LNMAKKLICKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private float INBHKONEDDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ParticleSystem.MainModule MNEGGMCBIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ParticleSystem.TrailModule DEPNNGIHFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private ParticleSystem.EmissionModule AAIMPKBNBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ParticleSystem.CollisionModule CGEHFIBBPLD;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0E10", Offset = "0x7FEFC10", VA = "0x187FF0E10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0A30", Offset = "0x7FEF830", VA = "0x187FF0A30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0660", Offset = "0x7FEF460", VA = "0x187FF0660")]
		private void LNDMKEEJGNE(EMDPMHOMJFK ANLKAIKHAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0160", Offset = "0x7FEEF60", VA = "0x187FF0160")]
		private void INBBGNAOKAI(IRecRoomQualityConfigProvider FNFCFIGCMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0820", Offset = "0x7FEF620", VA = "0x187FF0820")]
		private void NKPBEDBAFCJ(OverrideSettings NPFPPEHGMGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFFC0", Offset = "0x7FEEDC0", VA = "0x187FEFFC0")]
		private void GAEPEMPOOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0B40", Offset = "0x7FEF940", VA = "0x187FF0B40")]
		private void PCFKAEKHLAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0CE0", Offset = "0x7FEFAE0", VA = "0x187FF0CE0")]
		private void PLLFAOEOCLB(ParticleSystem.MinMaxCurve LEPPEAEFNPC, [Out] float HOMPDBIBPDA, [Out] float BDHJJLPGMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FF06E0", Offset = "0x7FEF4E0", VA = "0x187FF06E0")]
		private ParticleSystem.MinMaxCurve MNKDFNBPAEK(ParticleSystem.MinMaxCurve LEPPEAEFNPC, float HOMPDBIBPDA, float BDHJJLPGMKK)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override FHPNKGIAPJN MPAIGEJANHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCDFFB0", Offset = "0xCDEDB0", VA = "0x180CDFFB0", Slot = "4")]
			get
			{
				return default(FHPNKGIAPJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract T PEJMEFPFEIL(IRecRoomQualityConfigProvider NLNEAKEMABF);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5A0D500", Offset = "0x5A0C300", VA = "0x185A0D500")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5A0DC20", Offset = "0x5A0CA20", VA = "0x185A0DC20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5A0DAE0", Offset = "0x5A0C8E0", VA = "0x185A0DAE0")]
		private void LNDMKEEJGNE(EMDPMHOMJFK ANLKAIKHAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5A0D8C0", Offset = "0x5A0C6C0", VA = "0x185A0D8C0")]
		private void DHMEPLEFNOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5A0DAA0", Offset = "0x5A0C8A0", VA = "0x185A0DAA0", Slot = "8")]
		protected override void JKANICBIDHB(bool JNNHLDCBABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x47F13B0", Offset = "0x47F01B0", VA = "0x1847F13B0")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class BGEKBICEBDO
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8C20", Offset = "0x7FE7A20", VA = "0x187FE8C20")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	internal static void KEKMDAEKNFP(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private enum KICLEKOPPCO
		{
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private KICLEKOPPCO behavior;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF15D0", Offset = "0x7FF03D0", VA = "0x187FF15D0", Slot = "9")]
		protected override bool PEJMEFPFEIL(IRecRoomQualityConfigProvider NLNEAKEMABF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF15B0", Offset = "0x7FF03B0", VA = "0x187FF15B0", Slot = "7")]
		protected override bool PDGNFPFOBMH(bool IFKGDGBCKGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1620", Offset = "0x7FF0420", VA = "0x187FF1620")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private enum JPAGGBGPJBO
		{
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private JPAGGBGPJBO behavior;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1660", Offset = "0x7FF0460", VA = "0x187FF1660", Slot = "9")]
		protected override bool PEJMEFPFEIL(IRecRoomQualityConfigProvider NLNEAKEMABF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7FF15B0", Offset = "0x7FF03B0", VA = "0x187FF15B0", Slot = "7")]
		protected override bool PDGNFPFOBMH(bool IFKGDGBCKGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7FF16B0", Offset = "0x7FF04B0", VA = "0x187FF16B0")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private enum CNILHJJOPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private CNILHJJOPMJ behavior;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7FF16F0", Offset = "0x7FF04F0", VA = "0x187FF16F0", Slot = "9")]
		protected override bool PEJMEFPFEIL(IRecRoomQualityConfigProvider NLNEAKEMABF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7FF15B0", Offset = "0x7FF03B0", VA = "0x187FF15B0", Slot = "7")]
		protected override bool PDGNFPFOBMH(bool IFKGDGBCKGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1740", Offset = "0x7FF0540", VA = "0x187FF1740")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1790", Offset = "0x7FF0590", VA = "0x187FF1790", Slot = "9")]
		protected override LightRenderingMode PEJMEFPFEIL(IRecRoomQualityConfigProvider NLNEAKEMABF)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1780", Offset = "0x7FF0580", VA = "0x187FF1780", Slot = "7")]
		protected override bool PDGNFPFOBMH(LightRenderingMode IFKGDGBCKGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7FF17F0", Offset = "0x7FF05F0", VA = "0x187FF17F0")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1850", Offset = "0x7FF0650", VA = "0x187FF1850", Slot = "9")]
		protected override SceneDecorationDetailLevel PEJMEFPFEIL(IRecRoomQualityConfigProvider NLNEAKEMABF)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1830", Offset = "0x7FF0630", VA = "0x187FF1830", Slot = "7")]
		protected override bool PDGNFPFOBMH(SceneDecorationDetailLevel IFKGDGBCKGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FF18A0", Offset = "0x7FF06A0", VA = "0x187FF18A0")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1900", Offset = "0x7FF0700", VA = "0x187FF1900", Slot = "9")]
		protected override TransparencyDetailLevel PEJMEFPFEIL(IRecRoomQualityConfigProvider NLNEAKEMABF)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF18E0", Offset = "0x7FF06E0", VA = "0x187FF18E0", Slot = "7")]
		protected override bool PDGNFPFOBMH(TransparencyDetailLevel IFKGDGBCKGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1950", Offset = "0x7FF0750", VA = "0x187FF1950")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1B70", Offset = "0x7FF0970", VA = "0x187FF1B70", Slot = "7")]
		protected override bool PDGNFPFOBMH(BackgroundAnimationDetailLevel OJEPHAIBIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1A40", Offset = "0x7FF0840", VA = "0x187FF1A40", Slot = "8")]
		protected override void JKANICBIDHB(bool BAMJEJIELLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1990", Offset = "0x7FF0790", VA = "0x187FF1990")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1AC0", Offset = "0x7FF08C0", VA = "0x187FF1AC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1C00", Offset = "0x7FF0A00", VA = "0x187FF1C00")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static Dictionary<TerrainQualityLevel, Settings> NEJHOLOPEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Terrain LEIPOADCJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private IRecRoomQualityConfigProvider CALHOOKMOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private OAJCAKIGJOD NGIACBNNOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TerrainData DOFMAJDDDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TerrainData KAFDALPDDIJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Terrain FPDOAFCCPLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7FF2140", Offset = "0x7FF0F40", VA = "0x187FF2140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1F40", Offset = "0x7FF0D40", VA = "0x187FF1F40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2830", Offset = "0x7FF1630", VA = "0x187FF2830")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2760", Offset = "0x7FF1560", VA = "0x187FF2760")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2750", Offset = "0x7FF1550", VA = "0x187FF2750")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2250", Offset = "0x7FF1050", VA = "0x187FF2250")]
		private void JNODDKMGJEH(EMDPMHOMJFK ANLKAIKHAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2940", Offset = "0x7FF1740", VA = "0x187FF2940", Slot = "6")]
		public override void SetActivation(TerrainQualityLevel AMMHHFCGPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "7")]
		protected override bool PDGNFPFOBMH(TerrainQualityLevel OJEPHAIBIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "8")]
		protected override void JKANICBIDHB(bool JNNHLDCBABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2540", Offset = "0x7FF1340", VA = "0x187FF2540")]
		private void LPHNLBDBOCN(Settings LIKCCDGEANE, TerrainQualityLevel AMMHHFCGPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF22B0", Offset = "0x7FF10B0", VA = "0x187FF22B0")]
		private void KNBCHLJEOGJ(TreePrefabOverride[] MLHPNLNEMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2070", Offset = "0x7FF0E70", VA = "0x187FF2070")]
		private void CHPOBBBAADH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF21D0", Offset = "0x7FF0FD0", VA = "0x187FF21D0")]
		private Settings GDDJCMGHBCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2C70", Offset = "0x7FF1A70", VA = "0x187FF2C70")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum LJKKCBMICIM
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KBAIFKCGHKI
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color PFKMCINIKNC);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private List<Material> OBPGGJPDFPN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BackgroundObject LOLEKLCDHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7FE8D10", Offset = "0x7FE7B10", VA = "0x187FE8D10")]
		public void Init(BackgroundObject FLFNPLAKMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FE8F60", Offset = "0x7FE7D60", VA = "0x187FE8F60")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9080", Offset = "0x7FE7E80", VA = "0x187FE9080")]
		public void SetBlendValue(float CDPHKMFMKNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FE91F0", Offset = "0x7FE7FF0", VA = "0x187FE91F0")]
		public void SetColor(Color PFKMCINIKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9320", Offset = "0x7FE8120", VA = "0x187FE9320")]
		public void SetRotation(float NOLDGDLLBBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7FE94F0", Offset = "0x7FE82F0", VA = "0x187FE94F0")]
		public BackgroundObject()
		{
		}
	}
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class ActivationController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public enum FHPNKGIAPJN
		{
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		[GFLDJILPEIO("OnSceneOrPrefabSaveBehavior", FHPNKGIAPJN.EnableIfAllowed)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual FHPNKGIAPJN MPAIGEJANHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "4")]
			get
			{
				return default(FHPNKGIAPJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public abstract class ActivationController<T> : ActivationController where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		protected bool? PDANHMEOBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		protected T AFEKJGMJHPB;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DIAGGEIODPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x53DD430", Offset = "0x53DC230", VA = "0x1853DD430", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x53DD0C0", Offset = "0x53DBEC0", VA = "0x1853DD0C0", Slot = "6")]
		public virtual void SetActivation(T OJEPHAIBIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool PDGNFPFOBMH(T OJEPHAIBIBM);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void JKANICBIDHB(bool JNNHLDCBABM);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA75160", Offset = "0xA73F60", VA = "0x180A75160")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.CullableBatching
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[UnityEngine.Scripting.Preserve]
	public class CullableBatchLOD : MonoBehaviour, PLEJMOEMKPB
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public class BatchedRenderer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Renderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public bool visibleInBatch;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public bool Enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x7FE9580", Offset = "0x7FE8380", VA = "0x187FE9580")]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public BatchedRenderer[] revealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public LODGroup[] revealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public BatchedRenderer[] nonRevealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public LODGroup[] nonRevealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		public int subMeshCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		public int startRenderableSubmshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private CNPJGKPMCGN toggleBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private Bounds NHFILKMEGHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private Material KKBOKCGIENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private DFIIHHDEFCP<CullableBatchLOD> HKDEGGMBIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mesh JLPONKINLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool MPCIKIMBANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private bool BFFEEKLAPOB;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9BD0", Offset = "0x7FE89D0", VA = "0x187FE9BD0")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA040", Offset = "0x7FE8E40", VA = "0x187FEA040")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9A30", Offset = "0x7FE8830", VA = "0x187FE9A30")]
		private static float IGFLNNEGDMG(Vector3 LANCFBMCEON)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9B40", Offset = "0x7FE8940", VA = "0x187FE9B40")]
		public void SetContentsVisibility(bool EMBFIMPPNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9A50", Offset = "0x7FE8850", VA = "0x187FE9A50", Slot = "5")]
		public void OnChangedDistanceBand(CNPJGKPMCGN BPJAEOCDPBE, CNPJGKPMCGN NCHCOBIEDPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "6")]
		public void OnChangedVisibility(bool ELBEIBGFCLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9A80", Offset = "0x7FE8880", VA = "0x187FE9A80")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA2D0", Offset = "0x7FE90D0", VA = "0x187FEA2D0")]
		public CullableBatchLOD()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA81E70", Offset = "0xA80C70", VA = "0x180A81E70", Slot = "4")]
		private Transform BNCDJOBOKPA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchLODMaterialData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Vector4[] baseColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Vector4[] specColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Vector4[] emissionColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Vector4[] halfProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Vector4[] secondaryTextureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[FormerlySerializedAs("renderer")]
		public MeshRenderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public CullableBatchLODMaterialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchShaderManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA2F0", Offset = "0x7FE90F0", VA = "0x187FEA2F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public CullableBatchShaderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[RecRoom.NoEngine.Common.Preserve]
	[ExecuteInEditMode]
	public class RunTimeTextureAtlasData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1550", Offset = "0x7FF0350", VA = "0x187FF1550")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1550", Offset = "0x7FF0350", VA = "0x187FF1550")]
		private void AEKAIEDCLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
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
