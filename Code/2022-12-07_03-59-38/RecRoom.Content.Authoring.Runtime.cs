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
	public enum EDPAOAAPDIL
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
	private EDPAOAAPDIL bobAxis;

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
	private float ACNHMPBELAG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 DMONPNCCNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D5E0", Offset = "0x5F6C1E0", VA = "0x185F6D5E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE830", Offset = "0x1DDD430", VA = "0x181DDE830")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D740", Offset = "0x5F6C340", VA = "0x185F6D740")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D940", Offset = "0x5F6C540", VA = "0x185F6D940")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x17BEBA0", Offset = "0x17BD7A0", VA = "0x1817BEBA0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, GMJDICEKHMG
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string OPKEPDHKGHH = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string JMDEEFEKFBN = "_MainColor";

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
	private static List<Material> BNEDNBEDMPC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> CJBGJCMNPKM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
	public void PrepareImposter(FEPKHCOAHIE FPLMCNNAFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5F712C0", Offset = "0x5F6FEC0", VA = "0x185F712C0")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct CCAFDKAIOEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum CPABIELANDF
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
	public struct CICLOJCGMLN : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public CCAFDKAIOEI LIHKJEBOOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int BLCBMBLIJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JAMDKOJAMAB EBJBCBMNMBN;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F6FD90", Offset = "0x5F6E990", VA = "0x185F6FD90", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct KJJLFFJFDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> DCEFKJMILEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> CNLGPBFGLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> NLEHHAGNJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> PHOHKMCDBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> JKPLNEPMCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> LJPPJJMGHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> FFFOHBOPEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> KHAJCMJCHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> LJHBFPNCCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> HLHKJJBACJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> LBAHHNCNLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> MNMGFBHECCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> JDLKANGOMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> EBPDCNJOAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> HNMINHJHOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int LNKCMAHBPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 CDJDBKJAEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool IBMEKHDCDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int AMLEEPBIDKL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int CICFIPGIFBI = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int DPNAPJOPKMB = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> DCEFKJMILEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> NDKKHJBKCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> CNLGPBFGLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> NLEHHAGNJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> PHOHKMCDBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> JKPLNEPMCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> LJPPJJMGHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> FFFOHBOPEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> KHAJCMJCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> LJHBFPNCCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> EBPDCNJOAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> EOGOOOOCBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> KEELDIODIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> HLHKJJBACJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> NGLMFMPNKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> LBAHHNCNLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> AFNPNADGHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> ODDGGJAOJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> CMEFIEKMECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> DDLLPPBKPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> CKACBBPHNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> CPNJKAHHGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> KMJJEKCHOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> EOIIKICIIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> ABNCLCFCFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> OLCMHCGIPEI;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int EKGMDGLCGLL = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int OGIPEAEPBGB = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int IBLOFDMPGJK = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int FBFAEKDOGJN = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> PLDJGFOOLJM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ABEBIBDKMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6DD70", Offset = "0x5F6C970", VA = "0x185F6DD70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E370", Offset = "0x5F6CF70", VA = "0x185F6E370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KBEJBDNNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D960", Offset = "0x5F6C560", VA = "0x185F6D960")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E380", Offset = "0x5F6CF80", VA = "0x185F6E380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PLKKKMEFJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D970", Offset = "0x5F6C570", VA = "0x185F6D970")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D950", Offset = "0x5F6C550", VA = "0x185F6D950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CPABIELANDF HMAHDPFICBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E390", Offset = "0x5F6CF90", VA = "0x185F6E390")]
		get
		{
			return default(CPABIELANDF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F6DD80", Offset = "0x5F6C980", VA = "0x185F6DD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private KJJLFFJFDCO KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5F6DD90", Offset = "0x5F6C990", VA = "0x185F6DD90")]
		get
		{
			return default(KJJLFFJFDCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F6E3A0", Offset = "0x5F6CFA0", VA = "0x185F6E3A0")]
	public CCAFDKAIOEI(IList<Mesh> IGFFMDIJIFC, IList<int> AKJJOGPEILH, IList<int> LHPGHFJGAJH, IList<int[]> GEFGKJDNCHB, IList<Matrix4x4> IHGALIDJHCG, IList<bool> NNDNOKBBICM, IList<int> ABOJHILFPJD, Allocator JMMNDPMBMFC, CPABIELANDF OMMMBDLDFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F6D980", Offset = "0x5F6C580", VA = "0x185F6D980")]
	public JAMDKOJAMAB DPKKPEHCIJJ(int DCBEEAJINMA, Allocator JMMNDPMBMFC)
	{
		return default(JAMDKOJAMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F6DAF0", Offset = "0x5F6C6F0", VA = "0x185F6DAF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct JAMDKOJAMAB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> DCEFKJMILEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> CNLGPBFGLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> NLEHHAGNJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> PHOHKMCDBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> JKPLNEPMCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> LJPPJJMGHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> FFFOHBOPEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> KHAJCMJCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> LJHBFPNCCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> HLHKJJBACJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> LBAHHNCNLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> MNMGFBHECCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> JDLKANGOMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> PLDJGFOOLJM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KPDALCJPGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5F71DC0", Offset = "0x5F709C0", VA = "0x185F71DC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5F718D0", Offset = "0x5F704D0", VA = "0x185F718D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F721E0", Offset = "0x5F70DE0", VA = "0x185F721E0")]
	public JAMDKOJAMAB(int BOKLDHJECFI, int CJAHBCICCFJ, int FANAJPGKFAE, int DCBEEAJINMA, Allocator JMMNDPMBMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F71DD0", Offset = "0x5F709D0", VA = "0x185F71DD0")]
	public JAMDKOJAMAB(int BOKLDHJECFI, int CJAHBCICCFJ, int FANAJPGKFAE, int DCBEEAJINMA, Allocator JMMNDPMBMFC, bool[] KMABMIFDLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F717E0", Offset = "0x5F703E0", VA = "0x185F717E0")]
	public void DKDNGPIHAID(int PHALBBJCBDJ, int IHKOJLKELAD, int LNLAAEPHJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5F71D00", Offset = "0x5F70900", VA = "0x185F71D00")]
	public int[] OFMEEEDJLIL(int PHALBBJCBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F71740", Offset = "0x5F70340", VA = "0x185F71740")]
	private NativeSlice<int> DCJGLFKLBNB(int PHALBBJCBDJ)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F718E0", Offset = "0x5F704E0", VA = "0x185F718E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F71A50", Offset = "0x5F70650", VA = "0x185F71A50")]
	public Mesh OBKEGDPDDBJ([Optional] string ECBIOEOLFLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JCLFDLEIIMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> CFPGNGEBKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> JHKHDCDCFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> IFJHKLBABLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> HHELNIAGIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> NNONELJNGAK;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F723D0", Offset = "0x5F70FD0", VA = "0x185F723D0")]
	public void LDGMGBGLNAK(Mesh DNIOKNPDAGH, int[] EIAOOGCCFIC, Matrix4x4 MGILBDCOPPJ, bool NNDNOKBBICM = false, int DDMACGJAABK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F72320", Offset = "0x5F70F20", VA = "0x185F72320")]
	public CCAFDKAIOEI EGAGKAAOIMB(Allocator JMMNDPMBMFC, CCAFDKAIOEI.CPABIELANDF OMMMBDLDFHK, [Optional] IList<int> LHPGHFJGAJH, [Optional] IList<int> IOMMBFJFNGE)
	{
		return default(CCAFDKAIOEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F722A0", Offset = "0x5F70EA0", VA = "0x185F722A0")]
	private void AFLHJFIJGKC(Mesh DNIOKNPDAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F72580", Offset = "0x5F71180", VA = "0x185F72580")]
	public JCLFDLEIIMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
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
	private AOIMCGNKLIM playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AOIMCGNKLIM JOCMABIMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080")]
		get
		{
			return default(AOIMCGNKLIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E73F80", Offset = "0x4E72B80", VA = "0x184E73F80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5F74470", Offset = "0x5F73070", VA = "0x185F74470")]
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
	public bool GGDFKJEJMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F74B00", Offset = "0x5F73700", VA = "0x185F74B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GPDEMAPDFAB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EDBPHPEMFHC DHGBFKFACJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<EDBPHPEMFHC> JOJHEHJEMPL;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void APMEMNJPHJC();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum EDBPHPEMFHC
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
	Pico,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
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
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Light PIDPNMNMPBD;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Light BAFDBPAINMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5F743D0", Offset = "0x5F72FD0", VA = "0x185F743D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F74250", Offset = "0x5F72E50", VA = "0x185F74250")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5F74380", Offset = "0x5F72F80", VA = "0x185F74380")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, GMJDICEKHMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly int PLFBEJALMEN;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F71420", Offset = "0x5F70020", VA = "0x185F71420")]
		private void GKLIJKNKJIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5F71340", Offset = "0x5F6FF40", VA = "0x185F71340")]
		private void FNHLOKDPAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5F715E0", Offset = "0x5F701E0", VA = "0x185F715E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5F71570", Offset = "0x5F70170", VA = "0x185F71570", Slot = "4")]
		public void PrepareImposter(FEPKHCOAHIE FPLMCNNAFEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
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
		public delegate void CDPGIEDHJBE(ParticleEventListener HHAFPAAIFJI, Collider GHLMPEGFGCH, IEnumerable<ParticleCollisionEvent> EOHBAMALGOH);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> LCLGJFKPCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[MBKFNACBIPJ(GHABDIHKABP.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CDPGIEDHJBE PIONIGKJBIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5F730E0", Offset = "0x5F71CE0", VA = "0x185F730E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5F73180", Offset = "0x5F71D80", VA = "0x185F73180")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5F72D40", Offset = "0x5F71940", VA = "0x185F72D40")]
		private void OnParticleCollision(GameObject GHLMPEGFGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
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
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[NLDBJNONJIP("UseSpacePartition")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5F74C30", Offset = "0x5F73830", VA = "0x185F74C30")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F74C50", Offset = "0x5F73850", VA = "0x185F74C50")]
		public bool OHNBHNGPLIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F74D90", Offset = "0x5F73990", VA = "0x185F74D90")]
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
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool EKCFAFIPKKE;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override FBGPOPLDIEF BGCCEAFEGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7868A0", VA = "0x180787CA0", Slot = "4")]
			get
			{
				return default(FBGPOPLDIEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5F70D30", Offset = "0x5F6F930", VA = "0x185F70D30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5F70D50", Offset = "0x5F6F950", VA = "0x185F70D50")]
		private void HLJLELPFAOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5F71090", Offset = "0x5F6FC90", VA = "0x185F71090")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F70FB0", Offset = "0x5F6FBB0", VA = "0x185F70FB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5F70EB0", Offset = "0x5F6FAB0", VA = "0x185F70EB0")]
		private void IFKIDOEPBGH(EDBPHPEMFHC FFJHKLDOHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5F70D40", Offset = "0x5F6F940", VA = "0x185F70D40", Slot = "8")]
		protected override bool CADOPBKLFIJ(bool HHPKGDGPAGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5F70F40", Offset = "0x5F6FB40", VA = "0x185F70F40", Slot = "9")]
		protected override void OCFOCGCFFEA(bool LIMBMFKEFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5F710C0", Offset = "0x5F6FCC0", VA = "0x185F710C0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x78800", Offset = "0x77C00")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		[MBKFNACBIPJ(GHABDIHKABP.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool LDOJBMPMDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int JPODIBEHIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool FODEDKIMPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool DAEIJPIDFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float KPHMPALJNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float KGNCEPBBJOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float OCDDJCEEJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float AHFBPAFEBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float OPJGBKEGIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float FIPFAHANHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private ParticleSystem.MainModule LKFEHKGPGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.TrailModule DHOAMPJLBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ParticleSystem.EmissionModule HMHEPNEHFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ParticleSystem.CollisionModule GLGOLFJDKGD;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5F740C0", Offset = "0x5F72CC0", VA = "0x185F740C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5F73FE0", Offset = "0x5F72BE0", VA = "0x185F73FE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5F73590", Offset = "0x5F72190", VA = "0x185F73590")]
		private void IFKIDOEPBGH(EDBPHPEMFHC FFJHKLDOHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5F73AD0", Offset = "0x5F726D0", VA = "0x185F73AD0")]
		private void NNOLOHGNEJE(IRecRoomQualityConfigProvider CPNGCJKFMPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5F73730", Offset = "0x5F72330", VA = "0x185F73730")]
		private void MCCFHNJPNPF(OverrideSettings KPMMGEFKDGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5F733E0", Offset = "0x5F71FE0", VA = "0x185F733E0")]
		private void DJEABLNJNBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5F73220", Offset = "0x5F71E20", VA = "0x185F73220")]
		private void DBKKDFNDDKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5F73990", Offset = "0x5F72590", VA = "0x185F73990")]
		private void NMJNPOLPEPI(ParticleSystem.MinMaxCurve EBBFNLKCMJD, out float JJPLKIDABKH, out float GEFBCJKIGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5F735F0", Offset = "0x5F721F0", VA = "0x185F735F0")]
		private ParticleSystem.MinMaxCurve JGOLNFPEIBB(ParticleSystem.MinMaxCurve EBBFNLKCMJD, float JJPLKIDABKH, float GEFBCJKIGBB)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override FBGPOPLDIEF BGCCEAFEGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7868A0", VA = "0x180787CA0", Slot = "4")]
			get
			{
				return default(FBGPOPLDIEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T BJHCELIABAG(IRecRoomQualityConfigProvider EKJGNLNBFOL);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4CE11F0", Offset = "0x4CDFDF0", VA = "0x184CE11F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1560", Offset = "0x4CE0160", VA = "0x184CE1560")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4CE14F0", Offset = "0x4CE00F0", VA = "0x184CE14F0")]
		private void IFKIDOEPBGH(EDBPHPEMFHC FFJHKLDOHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4CE10F0", Offset = "0x4CDFCF0", VA = "0x184CE10F0")]
		private void APNIAFPNIAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1520", Offset = "0x4CE0120", VA = "0x184CE1520", Slot = "9")]
		protected override void OCFOCGCFFEA(bool LIMBMFKEFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2706060", Offset = "0x2704C60", VA = "0x182706060")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class GNDFELMCOCF
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5F71100", Offset = "0x5F6FD00", VA = "0x185F71100")]
	[JGJJPBKAAKL(HKPPGBCDEPD.None)]
	private static void CCOFINLLKDB()
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum FGAGLOLCFJE
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private FGAGLOLCFJE behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5F74490", Offset = "0x5F73090", VA = "0x185F74490", Slot = "10")]
		protected override bool BJHCELIABAG(IRecRoomQualityConfigProvider EKJGNLNBFOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5F744E0", Offset = "0x5F730E0", VA = "0x185F744E0", Slot = "8")]
		protected override bool CADOPBKLFIJ(bool HHPKGDGPAGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5F74500", Offset = "0x5F73100", VA = "0x185F74500")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private enum DKBLDDEDIHI
		{
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private DKBLDDEDIHI behavior;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5F74540", Offset = "0x5F73140", VA = "0x185F74540", Slot = "10")]
		protected override bool BJHCELIABAG(IRecRoomQualityConfigProvider EKJGNLNBFOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5F744E0", Offset = "0x5F730E0", VA = "0x185F744E0", Slot = "8")]
		protected override bool CADOPBKLFIJ(bool HHPKGDGPAGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5F74590", Offset = "0x5F73190", VA = "0x185F74590")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private enum FHAKBIFLBIP
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private FHAKBIFLBIP behavior;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5F745D0", Offset = "0x5F731D0", VA = "0x185F745D0", Slot = "10")]
		protected override bool BJHCELIABAG(IRecRoomQualityConfigProvider EKJGNLNBFOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F744E0", Offset = "0x5F730E0", VA = "0x185F744E0", Slot = "8")]
		protected override bool CADOPBKLFIJ(bool HHPKGDGPAGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F74620", Offset = "0x5F73220", VA = "0x185F74620")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5F74660", Offset = "0x5F73260", VA = "0x185F74660", Slot = "10")]
		protected override LightRenderingMode BJHCELIABAG(IRecRoomQualityConfigProvider EKJGNLNBFOL)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5F746C0", Offset = "0x5F732C0", VA = "0x185F746C0", Slot = "8")]
		protected override bool CADOPBKLFIJ(LightRenderingMode HHPKGDGPAGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5F746D0", Offset = "0x5F732D0", VA = "0x185F746D0")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5F74710", Offset = "0x5F73310", VA = "0x185F74710", Slot = "10")]
		protected override SceneDecorationDetailLevel BJHCELIABAG(IRecRoomQualityConfigProvider EKJGNLNBFOL)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5F74760", Offset = "0x5F73360", VA = "0x185F74760", Slot = "8")]
		protected override bool CADOPBKLFIJ(SceneDecorationDetailLevel HHPKGDGPAGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5F74780", Offset = "0x5F73380", VA = "0x185F74780")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5F747C0", Offset = "0x5F733C0", VA = "0x185F747C0", Slot = "10")]
		protected override TransparencyDetailLevel BJHCELIABAG(IRecRoomQualityConfigProvider EKJGNLNBFOL)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5F74810", Offset = "0x5F73410", VA = "0x185F74810", Slot = "8")]
		protected override bool CADOPBKLFIJ(TransparencyDetailLevel HHPKGDGPAGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5F74830", Offset = "0x5F73430", VA = "0x185F74830")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5F74900", Offset = "0x5F73500", VA = "0x185F74900", Slot = "8")]
		protected override bool CADOPBKLFIJ(BackgroundAnimationDetailLevel CDBGAIGGBBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5F749A0", Offset = "0x5F735A0", VA = "0x185F749A0", Slot = "9")]
		protected override void OCFOCGCFFEA(bool EMKILHIJCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5F74870", Offset = "0x5F73470", VA = "0x185F74870")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5F74A30", Offset = "0x5F73630", VA = "0x185F74A30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5F74AC0", Offset = "0x5F736C0", VA = "0x185F74AC0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Terrain LPMPMNBFHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TerrainData GGBMMONJLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TerrainData KAHBGIFCFEC;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Terrain GCCPGHDGAEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5F75280", Offset = "0x5F73E80", VA = "0x185F75280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5F74E10", Offset = "0x5F73A10", VA = "0x185F74E10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5F754A0", Offset = "0x5F740A0", VA = "0x185F754A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5F753C0", Offset = "0x5F73FC0", VA = "0x185F753C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5F753B0", Offset = "0x5F73FB0", VA = "0x185F753B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5F75320", Offset = "0x5F73F20", VA = "0x185F75320")]
		private void NBAEEPEPAPL(EDBPHPEMFHC FFJHKLDOHKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5F756E0", Offset = "0x5F742E0", VA = "0x185F756E0", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel PMGAJFDJNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850", Slot = "8")]
		protected override bool CADOPBKLFIJ(TerrainQualityLevel CDBGAIGGBBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "9")]
		protected override void OCFOCGCFFEA(bool LIMBMFKEFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5F74F30", Offset = "0x5F73B30", VA = "0x185F74F30")]
		private void JPNBADODCFE(Settings JIEHCBPGIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5F74FB0", Offset = "0x5F73BB0", VA = "0x185F74FB0")]
		private void KOCLNHCHKDP(TreePrefabOverride[] AFGBGDBHLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5F755F0", Offset = "0x5F741F0", VA = "0x185F755F0")]
		private void PMEAOJGMMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5F74EB0", Offset = "0x5F73AB0", VA = "0x185F74EB0")]
		private Settings DKEBDBDEEDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5F758A0", Offset = "0x5F744A0", VA = "0x185F758A0")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum AOIMCGNKLIM
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FCDDLLKAPLE
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color NCBJACAKLIH);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private List<Material> ANOBEFMEBPM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject LECHBNBCLCP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x69FA00", Offset = "0x69E600", VA = "0x18069FA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5F6CDE0", Offset = "0x5F6B9E0", VA = "0x185F6CDE0")]
		public void Init(BackgroundObject HLABNIGHLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D080", Offset = "0x5F6BC80", VA = "0x185F6D080")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D1A0", Offset = "0x5F6BDA0", VA = "0x185F6D1A0")]
		public void SetBlendValue(float BHNBFIEHMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D300", Offset = "0x5F6BF00", VA = "0x185F6D300")]
		public void SetColor(Color NCBJACAKLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D410", Offset = "0x5F6C010", VA = "0x185F6D410")]
		public void SetRotation(float IDIJNBAPGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5F6D560", Offset = "0x5F6C160", VA = "0x185F6D560")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface HGOAEIKINNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JGKFPAJAMPD<T> : HGOAEIKINNB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool ECFONJIHNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T CDBGAIGGBBI);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public abstract class ActivationController : MonoBehaviour, HGOAEIKINNB
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public enum FBGPOPLDIEF
		{
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		[NLDBJNONJIP("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual FBGPOPLDIEF BGCCEAFEGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6AD8D0", Offset = "0x6AC4D0", VA = "0x1806AD8D0", Slot = "4")]
			get
			{
				return default(FBGPOPLDIEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class ActivationController<T> : ActivationController, global::JGKFPAJAMPD<T>, HGOAEIKINNB where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		protected bool? DIKEFHBPGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		protected T ICDGEICFDPM;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ECFONJIHNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3D64D50", Offset = "0x3D63950", VA = "0x183D64D50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3D64A50", Offset = "0x3D63650", VA = "0x183D64A50", Slot = "7")]
		public virtual void SetActivation(T CDBGAIGGBBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool CADOPBKLFIJ(T CDBGAIGGBBI);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void OCFOCGCFFEA(bool LIMBMFKEFDB);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2D751D0", Offset = "0x2D73DD0", VA = "0x182D751D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public AGProBuilderStub()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5F72710", Offset = "0x5F71310", VA = "0x185F72710")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5F72820", Offset = "0x5F71420", VA = "0x185F72820")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
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
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
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
