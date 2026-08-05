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
	public enum JNEPEMJHLCD
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
	private JNEPEMJHLCD bobAxis;

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
	private float KMACECDEHLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 FJLMPNAFMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4E24B10", Offset = "0x4E23510", VA = "0x184E24B10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1BA0950", Offset = "0x1B9F350", VA = "0x181BA0950")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E24CE0", Offset = "0x4E236E0", VA = "0x184E24CE0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E24E40", Offset = "0x4E23840", VA = "0x184E24E40")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x19706B0", Offset = "0x196F0B0", VA = "0x1819706B0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, HCHJIPDHNAK
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string MBBNICFLDDD = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string BIGDHAAJDHN = "_MainColor";

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
	private static List<Material> PJDMLIDKHLN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> NDDCFBIAILC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "4")]
	public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E25790", Offset = "0x4E24190", VA = "0x184E25790")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct KDACPMEDAML : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum GGFGCBNJFOG
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
	public struct BFKNPGLKPMH : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public KDACPMEDAML FCPIEBMJOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int KLGDMJMMDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public BAPJAPFGHNL HKNOHPDOOPJ;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E23660", Offset = "0x4E22060", VA = "0x184E23660", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MIPAPIDBODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> HJEKIKCIMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> AEJIBMMHGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> KIKIJAKBNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> AMGININHGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> FEJCLFLBMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> ICKDEAFAKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> LBBCHFOBAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> AJPBABPBBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> OJBFFGBMKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> AHOOANGJKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> IDABMDPDAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> NJFDHJJPKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> BENFLMEKGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> ACIJNILMHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> KAIBHGIIFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int HPEJHKKOGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 ODNOCDEOKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool IDHMABMPPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int JHJNIFGNCHO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int CDHCAICPOAJ = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int INBPHNFGAJI = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> HJEKIKCIMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> JIBCDGAFADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> AEJIBMMHGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> KIKIJAKBNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> AMGININHGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> FEJCLFLBMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> ICKDEAFAKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> LBBCHFOBAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> AJPBABPBBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> OJBFFGBMKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> ACIJNILMHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> FLLEDAIPEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> PGGEBODIGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> AHOOANGJKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> FFBNGFPLJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> IDABMDPDAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> HFHNIKOPPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> AAEBKFAEJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> PPCKLDKLKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> PBPCPMHFHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> KKNHLFLAHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> EGGMGJPLFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> KBNIJDGHKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> BJJJGLFADKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> CBLNOPHAICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> JKALIIJBPNK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int ANKFAEECKDE = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int IDEPBEOCBOI = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int IGBPDINPMFC = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int DPANCMGFDGG = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> JKHMBHLKAOL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CNAKNKNGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E26440", Offset = "0x4E24E40", VA = "0x184E26440")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E26450", Offset = "0x4E24E50", VA = "0x184E26450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BHPKPJMAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E25BD0", Offset = "0x4E245D0", VA = "0x184E25BD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4E265E0", Offset = "0x4E24FE0", VA = "0x184E265E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PIDLNCGLCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4E25BF0", Offset = "0x4E245F0", VA = "0x184E25BF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4E26430", Offset = "0x4E24E30", VA = "0x184E26430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GGFGCBNJFOG BMPPEJJFDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4E26460", Offset = "0x4E24E60", VA = "0x184E26460")]
		get
		{
			return default(GGFGCBNJFOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4E25BE0", Offset = "0x4E245E0", VA = "0x184E25BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private MIPAPIDBODG INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E25E20", Offset = "0x4E24820", VA = "0x184E25E20")]
		get
		{
			return default(MIPAPIDBODG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4E265F0", Offset = "0x4E24FF0", VA = "0x184E265F0")]
	public KDACPMEDAML(IList<Mesh> MFLPHHJJJBB, IList<int> CNJDCIDCKMP, IList<int> NEOLKKPOEGP, IList<int[]> EELKNMDIKFK, IList<Matrix4x4> GNAPNJEKGEI, IList<bool> OEMMIJDAIIH, IList<int> BDFGDAIBGFC, Allocator KJLCBPLKDJD, GGFGCBNJFOG MHBNANJLEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E26470", Offset = "0x4E24E70", VA = "0x184E26470")]
	public BAPJAPFGHNL MBNNIFNAJBN(int EALADABHKGN, Allocator KJLCBPLKDJD)
	{
		return default(BAPJAPFGHNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E25C00", Offset = "0x4E24600", VA = "0x184E25C00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct BAPJAPFGHNL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> HJEKIKCIMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> AEJIBMMHGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> KIKIJAKBNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> AMGININHGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> FEJCLFLBMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> ICKDEAFAKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> LBBCHFOBAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> AJPBABPBBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> OJBFFGBMKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> AHOOANGJKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> IDABMDPDAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> NJFDHJJPKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> BENFLMEKGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> JKHMBHLKAOL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GGCCHJJHIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4E23100", Offset = "0x4E21B00", VA = "0x184E23100")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E22C00", Offset = "0x4E21600", VA = "0x184E22C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4E235B0", Offset = "0x4E21FB0", VA = "0x184E235B0")]
	public BAPJAPFGHNL(int JFADJAGPHBB, int FCODDKPLFFH, int JHFBMLEAMNC, int EALADABHKGN, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E231D0", Offset = "0x4E21BD0", VA = "0x184E231D0")]
	public BAPJAPFGHNL(int JFADJAGPHBB, int FCODDKPLFFH, int JHFBMLEAMNC, int EALADABHKGN, Allocator KJLCBPLKDJD, bool[] CLDLJKACOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E22CB0", Offset = "0x4E216B0", VA = "0x184E22CB0")]
	public void DKDPJOLBBHH(int OAIMLMCPBGK, int EFGENLFBGLF, int HHALJLDHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4E23110", Offset = "0x4E21B10", VA = "0x184E23110")]
	public int[] KOPPHJHGDFI(int OAIMLMCPBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E22C10", Offset = "0x4E21610", VA = "0x184E22C10")]
	private NativeSlice<int> CGHNFMEDCJB(int OAIMLMCPBGK)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4E22D90", Offset = "0x4E21790", VA = "0x184E22D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4E22EB0", Offset = "0x4E218B0", VA = "0x184E22EB0")]
	public Mesh GAJHNMDOICD([Optional] string OCCGPHPMAGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EFOINFOFMFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> KLBPCCIIHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> ADHNPLKKJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> GFJNGFCIGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> IAMCHLDOPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> HOHGNOAPAGP;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4E253D0", Offset = "0x4E23DD0", VA = "0x184E253D0")]
	public void CHJMMGCCGOF(Mesh EALEDNNEEBC, int[] PHEMCFBCCPF, Matrix4x4 CJFHIOPGPLP, bool OEMMIJDAIIH = false, int BMHNCPHLPLK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4E25320", Offset = "0x4E23D20", VA = "0x184E25320")]
	public KDACPMEDAML BALBFLJGFCE(Allocator KJLCBPLKDJD, KDACPMEDAML.GGFGCBNJFOG MHBNANJLEBK, [Optional] IList<int> NEOLKKPOEGP, [Optional] IList<int> HCNDDDCOKAI)
	{
		return default(KDACPMEDAML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4E25550", Offset = "0x4E23F50", VA = "0x184E25550")]
	private void NGGCADIDMLA(Mesh EALEDNNEEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E255D0", Offset = "0x4E23FD0", VA = "0x184E255D0")]
	public EFOINFOFMFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	private EMLLPHOLJPM playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EMLLPHOLJPM PNMBHFKPFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x564470", Offset = "0x562E70", VA = "0x180564470")]
		get
		{
			return default(EMLLPHOLJPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x31DBE30", Offset = "0x31DA830", VA = "0x1831DBE30")]
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
	public bool OPEHDPLOIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A110", Offset = "0x4E28B10", VA = "0x184E2A110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ACFHPIMMHNE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HMKIIOGEJLI FJGKKFFOCAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HMKIIOGEJLI> FICBIGCPGJN;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMMBJGEIJLJ();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum HMKIIOGEJLI
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
	public class InstanceColor : MonoBehaviour, HCHJIPDHNAK
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
		private static readonly int FHONNGAAGID;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4E25800", Offset = "0x4E24200", VA = "0x184E25800")]
		private void KBANGCPPKJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4E25940", Offset = "0x4E24340", VA = "0x184E25940")]
		private void PBBGMPGBNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4E25A80", Offset = "0x4E24480", VA = "0x184E25A80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4E25A10", Offset = "0x4E24410", VA = "0x184E25A10", Slot = "4")]
		public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		public InstanceColor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum EMLLPHOLJPM
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
		private bool AONGCHMJENP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override ABMNDEJIGID GCJOOLFOKLO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF80", Offset = "0x7BE980", VA = "0x1807BFF80", Slot = "4")]
			get
			{
				return default(ABMNDEJIGID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4E24F40", Offset = "0x4E23940", VA = "0x184E24F40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4E24FC0", Offset = "0x4E239C0", VA = "0x184E24FC0")]
		private void HPELODHDBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4E252B0", Offset = "0x4E23CB0", VA = "0x184E252B0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4E25190", Offset = "0x4E23B90", VA = "0x184E25190")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4E24E50", Offset = "0x4E23850", VA = "0x184E24E50")]
		private void ADKHBNLMONF(HMKIIOGEJLI BKBMIIINBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4E25180", Offset = "0x4E23B80", VA = "0x184E25180", Slot = "8")]
		protected override bool NMPFMKAIFJL(bool KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4E24F50", Offset = "0x4E23950", VA = "0x184E24F50", Slot = "9")]
		protected override void GNBCNHFKIJA(bool NLLAPBONECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4E252E0", Offset = "0x4E23CE0", VA = "0x184E252E0")]
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
		[LJOCGMMGCIH(JAJEGMAJLMP.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool DFAJILIPIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int DLKICEIEPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool PFNIAHNOHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private bool LAOAENHPCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private float AOAJHFNHPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private float NPDCCFMJDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private float EOBMJDDGJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private float LDAFFBMOBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private float KKJCJBHBPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private float KNKAGLHODCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private ParticleSystem.MainModule GLDINJIIODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ParticleSystem.TrailModule HOPFGJKMMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ParticleSystem.EmissionModule FNAGJHPAMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ParticleSystem.CollisionModule EKBEEDKIHJP;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4E29800", Offset = "0x4E28200", VA = "0x184E29800")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E29520", Offset = "0x4E27F20", VA = "0x184E29520")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4E28460", Offset = "0x4E26E60", VA = "0x184E28460")]
		private void ADKHBNLMONF(HMKIIOGEJLI BKBMIIINBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E287F0", Offset = "0x4E271F0", VA = "0x184E287F0")]
		private void HFPDKMKHOFO(IRecRoomQualityConfigProvider DPAHJCPCBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4E292C0", Offset = "0x4E27CC0", VA = "0x184E292C0")]
		private void MOGKDBKKDMO(OverrideSettings LCPIOEPCPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4E28530", Offset = "0x4E26F30", VA = "0x184E28530")]
		private void CGKHECEOFGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4E29640", Offset = "0x4E28040", VA = "0x184E29640")]
		private void PNHHNHFOLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4E286E0", Offset = "0x4E270E0", VA = "0x184E286E0")]
		private void GEGBKELCBOE(ParticleSystem.MinMaxCurve KCAHNHLNIAK, out float JOKBMBLFJHC, out float OINBADDHKBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4E291B0", Offset = "0x4E27BB0", VA = "0x184E291B0")]
		private ParticleSystem.MinMaxCurve IKHIHJAPBEP(ParticleSystem.MinMaxCurve KCAHNHLNIAK, float JOKBMBLFJHC, float OINBADDHKBD)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override ABMNDEJIGID GCJOOLFOKLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7BFF80", Offset = "0x7BE980", VA = "0x1807BFF80", Slot = "4")]
			get
			{
				return default(ABMNDEJIGID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A86120", Offset = "0x2A84B20", VA = "0x182A86120")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A86930", Offset = "0x2A85330", VA = "0x182A86930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2A85FA0", Offset = "0x2A849A0", VA = "0x182A85FA0")]
		private void ADKHBNLMONF(HMKIIOGEJLI BKBMIIINBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2A86400", Offset = "0x2A84E00", VA = "0x182A86400")]
		private void OJIPGOIENPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2A863C0", Offset = "0x2A84DC0", VA = "0x182A863C0", Slot = "9")]
		protected override void GNBCNHFKIJA(bool NLLAPBONECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2752500", Offset = "0x2750F00", VA = "0x182752500")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum KBGNGDEKLGN
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private KBGNGDEKLGN behavior;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4E299F0", Offset = "0x4E283F0", VA = "0x184E299F0", Slot = "10")]
		protected override bool ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4E29A40", Offset = "0x4E28440", VA = "0x184E29A40", Slot = "8")]
		protected override bool NMPFMKAIFJL(bool KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4E29A60", Offset = "0x4E28460", VA = "0x184E29A60")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private enum DPKKAPNNEEI
		{
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private DPKKAPNNEEI behavior;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4E29AA0", Offset = "0x4E284A0", VA = "0x184E29AA0", Slot = "10")]
		protected override bool ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E29A40", Offset = "0x4E28440", VA = "0x184E29A40", Slot = "8")]
		protected override bool NMPFMKAIFJL(bool KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4E29AF0", Offset = "0x4E284F0", VA = "0x184E29AF0")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private enum NOOBNKPNBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private NOOBNKPNBDJ behavior;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4E29B30", Offset = "0x4E28530", VA = "0x184E29B30", Slot = "10")]
		protected override bool ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E29A40", Offset = "0x4E28440", VA = "0x184E29A40", Slot = "8")]
		protected override bool NMPFMKAIFJL(bool KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4E29B80", Offset = "0x4E28580", VA = "0x184E29B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E29BC0", Offset = "0x4E285C0", VA = "0x184E29BC0", Slot = "10")]
		protected override LightRenderingMode ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4E29C20", Offset = "0x4E28620", VA = "0x184E29C20", Slot = "8")]
		protected override bool NMPFMKAIFJL(LightRenderingMode KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4E29C30", Offset = "0x4E28630", VA = "0x184E29C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E29C70", Offset = "0x4E28670", VA = "0x184E29C70", Slot = "10")]
		protected override SceneDecorationDetailLevel ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4E29CC0", Offset = "0x4E286C0", VA = "0x184E29CC0", Slot = "8")]
		protected override bool NMPFMKAIFJL(SceneDecorationDetailLevel KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4E29CE0", Offset = "0x4E286E0", VA = "0x184E29CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E29D20", Offset = "0x4E28720", VA = "0x184E29D20", Slot = "10")]
		protected override TransparencyDetailLevel ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4E29D70", Offset = "0x4E28770", VA = "0x184E29D70", Slot = "8")]
		protected override bool NMPFMKAIFJL(TransparencyDetailLevel KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4E29D90", Offset = "0x4E28790", VA = "0x184E29D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E29F50", Offset = "0x4E28950", VA = "0x184E29F50", Slot = "8")]
		protected override bool NMPFMKAIFJL(BackgroundAnimationDetailLevel BDLNOOHLABL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E29EC0", Offset = "0x4E288C0", VA = "0x184E29EC0", Slot = "9")]
		protected override void GNBCNHFKIJA(bool CEJHMGDHMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E29DD0", Offset = "0x4E287D0", VA = "0x184E29DD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E29FE0", Offset = "0x4E289E0", VA = "0x184E29FE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A0D0", Offset = "0x4E28AD0", VA = "0x184E2A0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
		private Terrain FMCLJHLELDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TerrainData EJDPNNKMMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TerrainData FIEJDHDFBPE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Terrain PCPNMBDMDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4E2A210", Offset = "0x4E28C10", VA = "0x184E2A210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A2A0", Offset = "0x4E28CA0", VA = "0x184E2A2A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4E2AA10", Offset = "0x4E29410", VA = "0x184E2AA10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A8F0", Offset = "0x4E292F0", VA = "0x184E2A8F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A8E0", Offset = "0x4E292E0", VA = "0x184E2A8E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A770", Offset = "0x4E29170", VA = "0x184E2A770")]
		private void MEJELOOLPLG(HMKIIOGEJLI BKBMIIINBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4E2ABC0", Offset = "0x4E295C0", VA = "0x184E2ABC0", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel CAKGEFKIIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x588CA0", Offset = "0x5876A0", VA = "0x180588CA0", Slot = "8")]
		protected override bool NMPFMKAIFJL(TerrainQualityLevel BDLNOOHLABL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "9")]
		protected override void GNBCNHFKIJA(bool NLLAPBONECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A860", Offset = "0x4E29260", VA = "0x184E2A860")]
		private void OHDFJHFPDPK(Settings JAFPHODNIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A340", Offset = "0x4E28D40", VA = "0x184E2A340")]
		private void BLOMBCOPKKL(TreePrefabOverride[] CODMLCLICAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A610", Offset = "0x4E29010", VA = "0x184E2A610")]
		private void DAAAMJLMNGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A6F0", Offset = "0x4E290F0", VA = "0x184E2A6F0")]
		private Settings KHICCELJIND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4E2AE30", Offset = "0x4E29830", VA = "0x184E2AE30")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FDEBGHMGELO
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color FELGEKLHNJA);
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
		private List<Material> FGHEMIEMKPB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BackgroundObject FNMINJBNIAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x567460", Offset = "0x565E60", VA = "0x180567460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4E242D0", Offset = "0x4E22CD0", VA = "0x184E242D0")]
		public void Init(BackgroundObject OHCKICLFOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4E24520", Offset = "0x4E22F20", VA = "0x184E24520")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4E24640", Offset = "0x4E23040", VA = "0x184E24640")]
		public void SetBlendValue(float GOAGGCMHCAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4E247A0", Offset = "0x4E231A0", VA = "0x184E247A0")]
		public void SetColor(Color FELGEKLHNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4E248B0", Offset = "0x4E232B0", VA = "0x184E248B0")]
		public void SetRotation(float FDJKEAEAOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4E24AA0", Offset = "0x4E234A0", VA = "0x184E24AA0")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BEIIFOPMHMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface AOKKMIHGJLG<T> : BEIIFOPMHMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool HIEBMIOJIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T BDLNOOHLABL);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class ActivationController : MonoBehaviour, BEIIFOPMHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum ABMNDEJIGID
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
		[MJOLKJKNDFJ("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected virtual ABMNDEJIGID GCJOOLFOKLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5706D0", Offset = "0x56F0D0", VA = "0x1805706D0", Slot = "4")]
			get
			{
				return default(ABMNDEJIGID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class ActivationController<T> : ActivationController, global::AOKKMIHGJLG<T>, BEIIFOPMHMJ where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		protected bool? ODPLOBGHLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		protected T FIICEHICOBG;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HIEBMIOJIAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2A76DA0", Offset = "0x2A757A0", VA = "0x182A76DA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2A76A10", Offset = "0x2A75410", VA = "0x182A76A10", Slot = "7")]
		public virtual void SetActivation(T BDLNOOHLABL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool NMPFMKAIFJL(T BDLNOOHLABL);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void GNBCNHFKIJA(bool NLLAPBONECJ);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2751070", Offset = "0x274FA70", VA = "0x182751070")]
		protected ActivationController()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4E281A0", Offset = "0x4E26BA0", VA = "0x184E281A0")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4E27E70", Offset = "0x4E26870", VA = "0x184E27E70")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
