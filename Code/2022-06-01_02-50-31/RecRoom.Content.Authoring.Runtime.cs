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
		[Cpp2IlInjected.Address(RVA = "0x4CF6650", Offset = "0x4CF5050", VA = "0x184CF6650")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1602F50", Offset = "0x1601950", VA = "0x181602F50")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6820", Offset = "0x4CF5220", VA = "0x184CF6820")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6980", Offset = "0x4CF5380", VA = "0x184CF6980")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1406210", Offset = "0x1404C10", VA = "0x181406210")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
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
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "4")]
	public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4CF72D0", Offset = "0x4CF5CD0", VA = "0x184CF72D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CF51A0", Offset = "0x4CF3BA0", VA = "0x184CF51A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CF7F80", Offset = "0x4CF6980", VA = "0x184CF7F80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7F90", Offset = "0x4CF6990", VA = "0x184CF7F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BHPKPJMAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7710", Offset = "0x4CF6110", VA = "0x184CF7710")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4CF8120", Offset = "0x4CF6B20", VA = "0x184CF8120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PIDLNCGLCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7730", Offset = "0x4CF6130", VA = "0x184CF7730")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7F70", Offset = "0x4CF6970", VA = "0x184CF7F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GGFGCBNJFOG BMPPEJJFDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7FA0", Offset = "0x4CF69A0", VA = "0x184CF7FA0")]
		get
		{
			return default(GGFGCBNJFOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7720", Offset = "0x4CF6120", VA = "0x184CF7720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private MIPAPIDBODG INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7960", Offset = "0x4CF6360", VA = "0x184CF7960")]
		get
		{
			return default(MIPAPIDBODG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4CF8130", Offset = "0x4CF6B30", VA = "0x184CF8130")]
	public KDACPMEDAML(IList<Mesh> MFLPHHJJJBB, IList<int> CNJDCIDCKMP, IList<int> NEOLKKPOEGP, IList<int[]> EELKNMDIKFK, IList<Matrix4x4> GNAPNJEKGEI, IList<bool> OEMMIJDAIIH, IList<int> BDFGDAIBGFC, Allocator KJLCBPLKDJD, GGFGCBNJFOG MHBNANJLEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4CF7FB0", Offset = "0x4CF69B0", VA = "0x184CF7FB0")]
	public BAPJAPFGHNL MBNNIFNAJBN(int EALADABHKGN, Allocator KJLCBPLKDJD)
	{
		return default(BAPJAPFGHNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4CF7740", Offset = "0x4CF6140", VA = "0x184CF7740", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CF4C40", Offset = "0x4CF3640", VA = "0x184CF4C40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4CF4740", Offset = "0x4CF3140", VA = "0x184CF4740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4CF50F0", Offset = "0x4CF3AF0", VA = "0x184CF50F0")]
	public BAPJAPFGHNL(int JFADJAGPHBB, int FCODDKPLFFH, int JHFBMLEAMNC, int EALADABHKGN, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4CF4D10", Offset = "0x4CF3710", VA = "0x184CF4D10")]
	public BAPJAPFGHNL(int JFADJAGPHBB, int FCODDKPLFFH, int JHFBMLEAMNC, int EALADABHKGN, Allocator KJLCBPLKDJD, bool[] CLDLJKACOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4CF47F0", Offset = "0x4CF31F0", VA = "0x184CF47F0")]
	public void DKDPJOLBBHH(int OAIMLMCPBGK, int EFGENLFBGLF, int HHALJLDHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4CF4C50", Offset = "0x4CF3650", VA = "0x184CF4C50")]
	public int[] KOPPHJHGDFI(int OAIMLMCPBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4CF4750", Offset = "0x4CF3150", VA = "0x184CF4750")]
	private NativeSlice<int> CGHNFMEDCJB(int OAIMLMCPBGK)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4CF48D0", Offset = "0x4CF32D0", VA = "0x184CF48D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4CF49F0", Offset = "0x4CF33F0", VA = "0x184CF49F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4CF6F10", Offset = "0x4CF5910", VA = "0x184CF6F10")]
	public void CHJMMGCCGOF(Mesh EALEDNNEEBC, int[] PHEMCFBCCPF, Matrix4x4 CJFHIOPGPLP, bool OEMMIJDAIIH = false, int BMHNCPHLPLK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4CF6E60", Offset = "0x4CF5860", VA = "0x184CF6E60")]
	public KDACPMEDAML BALBFLJGFCE(Allocator KJLCBPLKDJD, KDACPMEDAML.GGFGCBNJFOG MHBNANJLEBK, [Optional] IList<int> NEOLKKPOEGP, [Optional] IList<int> HCNDDDCOKAI)
	{
		return default(KDACPMEDAML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4CF7090", Offset = "0x4CF5A90", VA = "0x184CF7090")]
	private void NGGCADIDMLA(Mesh EALEDNNEEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4CF7110", Offset = "0x4CF5B10", VA = "0x184CF7110")]
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
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x551E70", VA = "0x180553470")]
		get
		{
			return default(EMLLPHOLJPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2230", Offset = "0x2CD0C30", VA = "0x182CD2230")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFBC50", Offset = "0x4CFA650", VA = "0x184CFBC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CF7340", Offset = "0x4CF5D40", VA = "0x184CF7340")]
		private void KBANGCPPKJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7480", Offset = "0x4CF5E80", VA = "0x184CF7480")]
		private void PBBGMPGBNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4CF75C0", Offset = "0x4CF5FC0", VA = "0x184CF75C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7550", Offset = "0x4CF5F50", VA = "0x184CF7550", Slot = "4")]
		public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x72DA00", Offset = "0x72C400", VA = "0x18072DA00", Slot = "4")]
			get
			{
				return default(ABMNDEJIGID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6A80", Offset = "0x4CF5480", VA = "0x184CF6A80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6B00", Offset = "0x4CF5500", VA = "0x184CF6B00")]
		private void HPELODHDBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6DF0", Offset = "0x4CF57F0", VA = "0x184CF6DF0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6CD0", Offset = "0x4CF56D0", VA = "0x184CF6CD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6990", Offset = "0x4CF5390", VA = "0x184CF6990")]
		private void ADKHBNLMONF(HMKIIOGEJLI BKBMIIINBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6CC0", Offset = "0x4CF56C0", VA = "0x184CF6CC0", Slot = "8")]
		protected override bool NMPFMKAIFJL(bool KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6A90", Offset = "0x4CF5490", VA = "0x184CF6A90", Slot = "9")]
		protected override void GNBCNHFKIJA(bool NLLAPBONECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6E20", Offset = "0x4CF5820", VA = "0x184CF6E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFB340", Offset = "0x4CF9D40", VA = "0x184CFB340")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB060", Offset = "0x4CF9A60", VA = "0x184CFB060")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9FA0", Offset = "0x4CF89A0", VA = "0x184CF9FA0")]
		private void ADKHBNLMONF(HMKIIOGEJLI BKBMIIINBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4CFA330", Offset = "0x4CF8D30", VA = "0x184CFA330")]
		private void HFPDKMKHOFO(IRecRoomQualityConfigProvider DPAHJCPCBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4CFAE00", Offset = "0x4CF9800", VA = "0x184CFAE00")]
		private void MOGKDBKKDMO(OverrideSettings LCPIOEPCPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4CFA070", Offset = "0x4CF8A70", VA = "0x184CFA070")]
		private void CGKHECEOFGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB180", Offset = "0x4CF9B80", VA = "0x184CFB180")]
		private void PNHHNHFOLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4CFA220", Offset = "0x4CF8C20", VA = "0x184CFA220")]
		private void GEGBKELCBOE(ParticleSystem.MinMaxCurve KCAHNHLNIAK, out float JOKBMBLFJHC, out float OINBADDHKBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4CFACF0", Offset = "0x4CF96F0", VA = "0x184CFACF0")]
		private ParticleSystem.MinMaxCurve IKHIHJAPBEP(ParticleSystem.MinMaxCurve KCAHNHLNIAK, float JOKBMBLFJHC, float OINBADDHKBD)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x72DA00", Offset = "0x72C400", VA = "0x18072DA00", Slot = "4")]
			get
			{
				return default(ABMNDEJIGID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x25A51C0", Offset = "0x25A3BC0", VA = "0x1825A51C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x25A59D0", Offset = "0x25A43D0", VA = "0x1825A59D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x25A5040", Offset = "0x25A3A40", VA = "0x1825A5040")]
		private void ADKHBNLMONF(HMKIIOGEJLI BKBMIIINBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x25A54A0", Offset = "0x25A3EA0", VA = "0x1825A54A0")]
		private void OJIPGOIENPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x25A5460", Offset = "0x25A3E60", VA = "0x1825A5460", Slot = "9")]
		protected override void GNBCNHFKIJA(bool NLLAPBONECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2196D30", Offset = "0x2195730", VA = "0x182196D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFB530", Offset = "0x4CF9F30", VA = "0x184CFB530", Slot = "10")]
		protected override bool ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB580", Offset = "0x4CF9F80", VA = "0x184CFB580", Slot = "8")]
		protected override bool NMPFMKAIFJL(bool KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB5A0", Offset = "0x4CF9FA0", VA = "0x184CFB5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFB5E0", Offset = "0x4CF9FE0", VA = "0x184CFB5E0", Slot = "10")]
		protected override bool ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB580", Offset = "0x4CF9F80", VA = "0x184CFB580", Slot = "8")]
		protected override bool NMPFMKAIFJL(bool KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB630", Offset = "0x4CFA030", VA = "0x184CFB630")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFB670", Offset = "0x4CFA070", VA = "0x184CFB670", Slot = "10")]
		protected override bool ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB580", Offset = "0x4CF9F80", VA = "0x184CFB580", Slot = "8")]
		protected override bool NMPFMKAIFJL(bool KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB6C0", Offset = "0x4CFA0C0", VA = "0x184CFB6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFB700", Offset = "0x4CFA100", VA = "0x184CFB700", Slot = "10")]
		protected override LightRenderingMode ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB760", Offset = "0x4CFA160", VA = "0x184CFB760", Slot = "8")]
		protected override bool NMPFMKAIFJL(LightRenderingMode KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB770", Offset = "0x4CFA170", VA = "0x184CFB770")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFB7B0", Offset = "0x4CFA1B0", VA = "0x184CFB7B0", Slot = "10")]
		protected override SceneDecorationDetailLevel ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB800", Offset = "0x4CFA200", VA = "0x184CFB800", Slot = "8")]
		protected override bool NMPFMKAIFJL(SceneDecorationDetailLevel KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB820", Offset = "0x4CFA220", VA = "0x184CFB820")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFB860", Offset = "0x4CFA260", VA = "0x184CFB860", Slot = "10")]
		protected override TransparencyDetailLevel ICOJABAANDK(IRecRoomQualityConfigProvider MIKNOMCIOLJ)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB8B0", Offset = "0x4CFA2B0", VA = "0x184CFB8B0", Slot = "8")]
		protected override bool NMPFMKAIFJL(TransparencyDetailLevel KNHCFJHCIHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB8D0", Offset = "0x4CFA2D0", VA = "0x184CFB8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFBA90", Offset = "0x4CFA490", VA = "0x184CFBA90", Slot = "8")]
		protected override bool NMPFMKAIFJL(BackgroundAnimationDetailLevel BDLNOOHLABL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4CFBA00", Offset = "0x4CFA400", VA = "0x184CFBA00", Slot = "9")]
		protected override void GNBCNHFKIJA(bool CEJHMGDHMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4CFB910", Offset = "0x4CFA310", VA = "0x184CFB910")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4CFBB20", Offset = "0x4CFA520", VA = "0x184CFBB20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4CFBC10", Offset = "0x4CFA610", VA = "0x184CFBC10")]
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
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
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
			[Cpp2IlInjected.Address(RVA = "0x4CFBD50", Offset = "0x4CFA750", VA = "0x184CFBD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4CFBDE0", Offset = "0x4CFA7E0", VA = "0x184CFBDE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4CFC550", Offset = "0x4CFAF50", VA = "0x184CFC550")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4CFC430", Offset = "0x4CFAE30", VA = "0x184CFC430")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4CFC420", Offset = "0x4CFAE20", VA = "0x184CFC420")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4CFC2B0", Offset = "0x4CFACB0", VA = "0x184CFC2B0")]
		private void MEJELOOLPLG(HMKIIOGEJLI BKBMIIINBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4CFC700", Offset = "0x4CFB100", VA = "0x184CFC700", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel CAKGEFKIIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5766A0", VA = "0x180577CA0", Slot = "8")]
		protected override bool NMPFMKAIFJL(TerrainQualityLevel BDLNOOHLABL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "9")]
		protected override void GNBCNHFKIJA(bool NLLAPBONECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4CFC3A0", Offset = "0x4CFADA0", VA = "0x184CFC3A0")]
		private void OHDFJHFPDPK(Settings JAFPHODNIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4CFBE80", Offset = "0x4CFA880", VA = "0x184CFBE80")]
		private void BLOMBCOPKKL(TreePrefabOverride[] CODMLCLICAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4CFC150", Offset = "0x4CFAB50", VA = "0x184CFC150")]
		private void DAAAMJLMNGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4CFC230", Offset = "0x4CFAC30", VA = "0x184CFC230")]
		private Settings KHICCELJIND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4CFC970", Offset = "0x4CFB370", VA = "0x184CFC970")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x554E60", VA = "0x180556460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4CF5E10", Offset = "0x4CF4810", VA = "0x184CF5E10")]
		public void Init(BackgroundObject OHCKICLFOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6060", Offset = "0x4CF4A60", VA = "0x184CF6060")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4CF6180", Offset = "0x4CF4B80", VA = "0x184CF6180")]
		public void SetBlendValue(float GOAGGCMHCAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4CF62E0", Offset = "0x4CF4CE0", VA = "0x184CF62E0")]
		public void SetColor(Color FELGEKLHNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4CF63F0", Offset = "0x4CF4DF0", VA = "0x184CF63F0")]
		public void SetRotation(float FDJKEAEAOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4CF65E0", Offset = "0x4CF4FE0", VA = "0x184CF65E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x55F6D0", Offset = "0x55E0D0", VA = "0x18055F6D0", Slot = "4")]
			get
			{
				return default(ABMNDEJIGID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x2599170", Offset = "0x2597B70", VA = "0x182599170", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2598DE0", Offset = "0x25977E0", VA = "0x182598DE0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x21958D0", Offset = "0x21942D0", VA = "0x1821958D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9CE0", Offset = "0x4CF86E0", VA = "0x184CF9CE0")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4CF99B0", Offset = "0x4CF83B0", VA = "0x184CF99B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
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
