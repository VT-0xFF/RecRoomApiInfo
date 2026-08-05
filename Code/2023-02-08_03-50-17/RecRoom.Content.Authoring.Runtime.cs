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
	public enum MHKEGKHJBNL
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
	private MHKEGKHJBNL bobAxis;

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
	private float FBPNKHCMBGL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 NGIANFGFPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1F81C10", Offset = "0x1F80A10", VA = "0x181F81C10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F81BD0", Offset = "0x1F809D0", VA = "0x181F81BD0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1F81D70", Offset = "0x1F80B70", VA = "0x181F81D70")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1F81F70", Offset = "0x1F80D70", VA = "0x181F81F70")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F82560", Offset = "0x1F81360", VA = "0x181F82560")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, LICEEGCPGOC
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string NJJCPKDOBBF = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string BKHPCBBLGJO = "_MainColor";

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
	private static List<Material> MMMLCJFNLME;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> FDLIEBNMPFB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
	public void PrepareImposter(ECPBMNOKBMB LNCKHCKJOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1F83580", Offset = "0x1F82380", VA = "0x181F83580")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct OKHDLHHGOMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PHAKKCAJGAL
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
	public struct KHFMGPPMAFJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public OKHDLHHGOMK HAFOMCGPAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int BEIMKDONDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public IKBMEDCJNAF GIAFNEEONOD;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1F83A00", Offset = "0x1F82800", VA = "0x181F83A00", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct JGNNPGBABBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> OJEKFKKILJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> HMNGPIIPDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> HJBFDDCOGMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> GCMIAMPGBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> LHEDABPPMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> LAHLKJJEMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> HGLOPPGFJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> LJPAMILJFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> LPPOOJNCOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> IOKGEEOAEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> HMNPIABOFEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> PCDOHDAAEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> JMIEFMFHBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> KKFJPFPMJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> CBMKMBCEPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int IKKPOGHGMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 KEDLMIACDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool BLJPGNIIPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int FHKLIJPJKJE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int AAAJAHACPNB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int PJAEKIFFJLM = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> OJEKFKKILJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> GGHALHBJONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> HMNGPIIPDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> HJBFDDCOGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> GCMIAMPGBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> LHEDABPPMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> LAHLKJJEMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> HGLOPPGFJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> LJPAMILJFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> LPPOOJNCOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> KKFJPFPMJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> PPDHKIGLAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> NGOMFKFOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> IOKGEEOAEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> PIAPEIDBPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> HMNPIABOFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> FCGJKOKABGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> LKKCNFAPLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> PBLDHBPFHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> BOFFMPMMICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> MBFCGHDINEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> HKKPBDOPNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> AMMFIAHLGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> HMEKJDCNOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> OAOHHKOPLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> NODLHLJMIDO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int ONICJKKPGKJ = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int DJGBDDCCKGA = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int AMFFIHOOLGE = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int LFCNKINEACH = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> OGEIEEOLDEN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NDOKODDEOMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1F852A0", Offset = "0x1F840A0", VA = "0x181F852A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1F85280", Offset = "0x1F84080", VA = "0x181F85280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JIBMGFEJFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1F85260", Offset = "0x1F84060", VA = "0x181F85260")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1F85420", Offset = "0x1F84220", VA = "0x181F85420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HKOMKIIJMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1F85290", Offset = "0x1F84090", VA = "0x181F85290")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1F85430", Offset = "0x1F84230", VA = "0x181F85430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PHAKKCAJGAL PGNOKPBNFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1F85270", Offset = "0x1F84070", VA = "0x181F85270")]
		get
		{
			return default(PHAKKCAJGAL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1F85250", Offset = "0x1F84050", VA = "0x181F85250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JGNNPGBABBO BADELHLICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1F85440", Offset = "0x1F84240", VA = "0x181F85440")]
		get
		{
			return default(JGNNPGBABBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F85A20", Offset = "0x1F84820", VA = "0x181F85A20")]
	public OKHDLHHGOMK(IList<Mesh> AKICLKKNMIJ, IList<int> LEKIGMLGNBP, IList<int> LNCLFDNKEKB, IList<int[]> JECIKBDKBFD, IList<Matrix4x4> HOAPDKLDJID, IList<bool> CCJEJMGAEOH, IList<int> IPFAOJHDPBM, Allocator CMCENMLGNBG, PHAKKCAJGAL MIGIKHMHCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F852B0", Offset = "0x1F840B0", VA = "0x181F852B0")]
	public IKBMEDCJNAF IMKIKPCLBBJ(int MKMHBMBHFBI, Allocator CMCENMLGNBG)
	{
		return default(IKBMEDCJNAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F84FD0", Offset = "0x1F83DD0", VA = "0x181F84FD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct IKBMEDCJNAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> OJEKFKKILJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> HMNGPIIPDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> HJBFDDCOGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> GCMIAMPGBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> LHEDABPPMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> LAHLKJJEMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> HGLOPPGFJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> LJPAMILJFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> LPPOOJNCOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> IOKGEEOAEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> HMNPIABOFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> PCDOHDAAEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> JMIEFMFHBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> OGEIEEOLDEN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GHALHOGJCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1F82BA0", Offset = "0x1F819A0", VA = "0x181F82BA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F82B90", Offset = "0x1F81990", VA = "0x181F82B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F83400", Offset = "0x1F82200", VA = "0x181F83400")]
	public IKBMEDCJNAF(int EOGFNNPIKDM, int GDIGHKIGPNE, int GHJLCCJFDAP, int MKMHBMBHFBI, Allocator CMCENMLGNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1F82FF0", Offset = "0x1F81DF0", VA = "0x181F82FF0")]
	public IKBMEDCJNAF(int EOGFNNPIKDM, int GDIGHKIGPNE, int GHJLCCJFDAP, int MKMHBMBHFBI, Allocator CMCENMLGNBG, bool[] OBGHOBNGLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1F82C50", Offset = "0x1F81A50", VA = "0x181F82C50")]
	public void KLKMPFIKFCM(int HLBKJFHGMII, int OMMIHDFOJDN, int EOKNLPLGCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1F82AD0", Offset = "0x1F818D0", VA = "0x181F82AD0")]
	public int[] GODCILEADIA(int HLBKJFHGMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1F82BB0", Offset = "0x1F819B0", VA = "0x181F82BB0")]
	private NativeSlice<int> JOPHLKJNJKD(int HLBKJFHGMII)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1F82960", Offset = "0x1F81760", VA = "0x181F82960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F82D40", Offset = "0x1F81B40", VA = "0x181F82D40")]
	public Mesh OOPDHHDLGBA([Optional] string AEOKAPLPNCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CGGMELIHEMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> MPPKJINFLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> EKEKICKJBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> CBDCJDOOEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> DNDHAJHNIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> BFDOMJHDKIF;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F82170", Offset = "0x1F80F70", VA = "0x181F82170")]
	public void PNHJIHDNEML(Mesh KMIFLOHLDEH, int[] HHGNGIAJKLK, Matrix4x4 IBJAMIJMAJE, bool CCJEJMGAEOH = false, int GBCOFFIBABA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F820C0", Offset = "0x1F80EC0", VA = "0x181F820C0")]
	public OKHDLHHGOMK PHEMGNMKAHH(Allocator CMCENMLGNBG, OKHDLHHGOMK.PHAKKCAJGAL MIGIKHMHCDP, [Optional] IList<int> LNCLFDNKEKB, [Optional] IList<int> MEFKDKKOAAG)
	{
		return default(OKHDLHHGOMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F81F80", Offset = "0x1F80D80", VA = "0x181F81F80")]
	private void KHPMEECEHOA(Mesh KMIFLOHLDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1F823D0", Offset = "0x1F811D0", VA = "0x181F823D0")]
	public CGGMELIHEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
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
	private OKPEHKBKIOP playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OKPEHKBKIOP NBIFCFLIKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30")]
		get
		{
			return default(OKPEHKBKIOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1414B70", Offset = "0x1413970", VA = "0x181414B70")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F88B40", Offset = "0x1F87940", VA = "0x181F88B40")]
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
	public bool HHMCAGADGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1F891D0", Offset = "0x1F87FD0", VA = "0x181F891D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BAABAOOMKEN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JMEHAJPFGKB GDEEMCMLLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JMEHAJPFGKB> LEGELCBBICD;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LNJPGBECPJO();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum JMEHAJPFGKB
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
		private Light FCHHEPFFEKO;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Light IANBMGLAPIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1F88AA0", Offset = "0x1F878A0", VA = "0x181F88AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1F88920", Offset = "0x1F87720", VA = "0x181F88920")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F88A50", Offset = "0x1F87850", VA = "0x181F88A50")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, LICEEGCPGOC
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
		private static readonly int PLCADNKMBAG;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F83600", Offset = "0x1F82400", VA = "0x181F83600")]
		private void FINONKGCDGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1F83750", Offset = "0x1F82550", VA = "0x181F83750")]
		private void MCLDLCKDOGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1F838A0", Offset = "0x1F826A0", VA = "0x181F838A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1F83830", Offset = "0x1F82630", VA = "0x181F83830", Slot = "4")]
		public void PrepareImposter(ECPBMNOKBMB LNCKHCKJOFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
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
		public delegate void MNGCOIPLGGD(ParticleEventListener AFBJGPDIIEO, Collider BNIMMCIKNIE, IEnumerable<ParticleCollisionEvent> KBJJFIGMOPG);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> GBILENGMNBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MNGCOIPLGGD JDMONHJALOM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1F877B0", Offset = "0x1F865B0", VA = "0x181F877B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1F87850", Offset = "0x1F86650", VA = "0x181F87850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1F87410", Offset = "0x1F86210", VA = "0x181F87410")]
		private void OnParticleCollision(GameObject BNIMMCIKNIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
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
		[EKKHEPIAELP("UseSpacePartition")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F89300", Offset = "0x1F88100", VA = "0x181F89300")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F89320", Offset = "0x1F88120", VA = "0x181F89320")]
		public bool MNODHEKPNEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1F89460", Offset = "0x1F88260", VA = "0x181F89460")]
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
		private bool AFCJEAMJAFJ;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override MLOINMFEPBP ELMPFFLKCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6C7640", Offset = "0x6C6440", VA = "0x1806C7640", Slot = "4")]
			get
			{
				return default(MLOINMFEPBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1F82590", Offset = "0x1F81390", VA = "0x181F82590")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1F82640", Offset = "0x1F81440", VA = "0x181F82640")]
		private void MFKDBOOHNNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1F828F0", Offset = "0x1F816F0", VA = "0x181F828F0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1F827A0", Offset = "0x1F815A0", VA = "0x181F827A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1F825A0", Offset = "0x1F813A0", VA = "0x181F825A0")]
		private void GAGBOEJNNGF(JMEHAJPFGKB IAEFEJPHCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1F82630", Offset = "0x1F81430", VA = "0x181F82630", Slot = "8")]
		protected override bool JKCLGANPPFM(bool OEINCIECCCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1F82880", Offset = "0x1F81680", VA = "0x181F82880", Slot = "9")]
		protected override void PDLEOHMIBBL(bool PHFFJEPAFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1F82920", Offset = "0x1F81720", VA = "0x181F82920")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0xF1EE0", Offset = "0xF12E0")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool DOEIOBINGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int MDCPPIBEMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool GJIIDLDIFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool LLDMFALNIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float BAIEGJBIIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float BKFIMNAIECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float BHELCHAPDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float AKBLHJDDNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float CKKJIHGDIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float LPCNJKIKEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private ParticleSystem.MainModule PIAJGOJMJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.TrailModule OMBEBIGJDMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ParticleSystem.EmissionModule PJLGDIJPCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ParticleSystem.CollisionModule ADNHLNDGKCA;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1F88790", Offset = "0x1F87590", VA = "0x181F88790")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1F87FE0", Offset = "0x1F86DE0", VA = "0x181F87FE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1F87BE0", Offset = "0x1F869E0", VA = "0x181F87BE0")]
		private void GAGBOEJNNGF(JMEHAJPFGKB IAEFEJPHCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1F88280", Offset = "0x1F87080", VA = "0x181F88280")]
		private void PGLLEELLMLC(IRecRoomQualityConfigProvider MOEFJFNCLJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1F87D80", Offset = "0x1F86B80", VA = "0x181F87D80")]
		private void KNBMILCKOJJ(OverrideSettings PLLOJGFFAIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F87A30", Offset = "0x1F86830", VA = "0x181F87A30")]
		private void GAFCKBMNLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1F880C0", Offset = "0x1F86EC0", VA = "0x181F880C0")]
		private void PAFGIINFKHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1F87C40", Offset = "0x1F86A40", VA = "0x181F87C40")]
		private void GAMMMPIHCFL(ParticleSystem.MinMaxCurve BOOCCLEEMCN, out float CKDBBIOMKEL, out float GNJFPBDAOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1F878F0", Offset = "0x1F866F0", VA = "0x181F878F0")]
		private ParticleSystem.MinMaxCurve CPPHJGMKBPK(ParticleSystem.MinMaxCurve BOOCCLEEMCN, float CKDBBIOMKEL, float GNJFPBDAOHB)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override MLOINMFEPBP ELMPFFLKCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6C7640", Offset = "0x6C6440", VA = "0x1806C7640", Slot = "4")]
			get
			{
				return default(MLOINMFEPBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T NKOFLMBNELG(IRecRoomQualityConfigProvider HKOMEKNDPHN);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4CEB8D0", Offset = "0x4CEA6D0", VA = "0x184CEB8D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4CEBD80", Offset = "0x4CEAB80", VA = "0x184CEBD80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4CEBBD0", Offset = "0x4CEA9D0", VA = "0x184CEBBD0")]
		private void GAGBOEJNNGF(JMEHAJPFGKB IAEFEJPHCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4CEBC80", Offset = "0x4CEAA80", VA = "0x184CEBC80")]
		private void JDPPHJMCJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4CEC020", Offset = "0x4CEAE20", VA = "0x184CEC020", Slot = "9")]
		protected override void PDLEOHMIBBL(bool PHFFJEPAFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB400", Offset = "0x2BFA200", VA = "0x182BFB400")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class AFGJEODADKP
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F812D0", Offset = "0x1F800D0", VA = "0x181F812D0")]
	[HPAMKJCLFIM(BFFNGLOENLB.None)]
	private static void HPAANPOMCFN()
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum OLAMBMFLPKM
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private OLAMBMFLPKM behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1F88B80", Offset = "0x1F87980", VA = "0x181F88B80", Slot = "10")]
		protected override bool NKOFLMBNELG(IRecRoomQualityConfigProvider HKOMEKNDPHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F88B60", Offset = "0x1F87960", VA = "0x181F88B60", Slot = "8")]
		protected override bool JKCLGANPPFM(bool OEINCIECCCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1F88BD0", Offset = "0x1F879D0", VA = "0x181F88BD0")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private enum GJLPGLFHPKG
		{
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private GJLPGLFHPKG behavior;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1F88C10", Offset = "0x1F87A10", VA = "0x181F88C10", Slot = "10")]
		protected override bool NKOFLMBNELG(IRecRoomQualityConfigProvider HKOMEKNDPHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1F88B60", Offset = "0x1F87960", VA = "0x181F88B60", Slot = "8")]
		protected override bool JKCLGANPPFM(bool OEINCIECCCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1F88C60", Offset = "0x1F87A60", VA = "0x181F88C60")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private enum MDKILIAEJFO
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private MDKILIAEJFO behavior;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F88CA0", Offset = "0x1F87AA0", VA = "0x181F88CA0", Slot = "10")]
		protected override bool NKOFLMBNELG(IRecRoomQualityConfigProvider HKOMEKNDPHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1F88B60", Offset = "0x1F87960", VA = "0x181F88B60", Slot = "8")]
		protected override bool JKCLGANPPFM(bool OEINCIECCCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1F88CF0", Offset = "0x1F87AF0", VA = "0x181F88CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F88D40", Offset = "0x1F87B40", VA = "0x181F88D40", Slot = "10")]
		protected override LightRenderingMode NKOFLMBNELG(IRecRoomQualityConfigProvider HKOMEKNDPHN)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1F88D30", Offset = "0x1F87B30", VA = "0x181F88D30", Slot = "8")]
		protected override bool JKCLGANPPFM(LightRenderingMode OEINCIECCCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1F88DA0", Offset = "0x1F87BA0", VA = "0x181F88DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F88E00", Offset = "0x1F87C00", VA = "0x181F88E00", Slot = "10")]
		protected override SceneDecorationDetailLevel NKOFLMBNELG(IRecRoomQualityConfigProvider HKOMEKNDPHN)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1F88DE0", Offset = "0x1F87BE0", VA = "0x181F88DE0", Slot = "8")]
		protected override bool JKCLGANPPFM(SceneDecorationDetailLevel OEINCIECCCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1F88E50", Offset = "0x1F87C50", VA = "0x181F88E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F88EB0", Offset = "0x1F87CB0", VA = "0x181F88EB0", Slot = "10")]
		protected override TransparencyDetailLevel NKOFLMBNELG(IRecRoomQualityConfigProvider HKOMEKNDPHN)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1F88E90", Offset = "0x1F87C90", VA = "0x181F88E90", Slot = "8")]
		protected override bool JKCLGANPPFM(TransparencyDetailLevel OEINCIECCCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1F88F00", Offset = "0x1F87D00", VA = "0x181F88F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F88FD0", Offset = "0x1F87DD0", VA = "0x181F88FD0", Slot = "8")]
		protected override bool JKCLGANPPFM(BackgroundAnimationDetailLevel MDNKLBBANDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F89100", Offset = "0x1F87F00", VA = "0x181F89100", Slot = "9")]
		protected override void PDLEOHMIBBL(bool MLLDIDGDNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F88F40", Offset = "0x1F87D40", VA = "0x181F88F40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F89070", Offset = "0x1F87E70", VA = "0x181F89070")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1F89190", Offset = "0x1F87F90", VA = "0x181F89190")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
		private Terrain IGAENODNNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TerrainData LFKNNFGENFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TerrainData MBEODCDDJOH;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Terrain DFNBDKKNGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1F898D0", Offset = "0x1F886D0", VA = "0x181F898D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1F894E0", Offset = "0x1F882E0", VA = "0x181F894E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1F89C60", Offset = "0x1F88A60", VA = "0x181F89C60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1F89B80", Offset = "0x1F88980", VA = "0x181F89B80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1F89B70", Offset = "0x1F88970", VA = "0x181F89B70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1F89AE0", Offset = "0x1F888E0", VA = "0x181F89AE0")]
		private void LDGPOOEEOGC(JMEHAJPFGKB IAEFEJPHCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1F89DB0", Offset = "0x1F88BB0", VA = "0x181F89DB0", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel MHPALPLNLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C8080", Offset = "0x6C6E80", VA = "0x1806C8080", Slot = "8")]
		protected override bool JKCLGANPPFM(TerrainQualityLevel MDNKLBBANDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "9")]
		protected override void PDLEOHMIBBL(bool PHFFJEPAFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1F89970", Offset = "0x1F88770", VA = "0x181F89970")]
		private void HPNHMGCAOAH(Settings KJNDNJIGLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1F89580", Offset = "0x1F88380", VA = "0x181F89580")]
		private void BMCNGPEKEPK(TreePrefabOverride[] MDIGFPPNFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1F899F0", Offset = "0x1F887F0", VA = "0x181F899F0")]
		private void JENDJKDHKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1F89850", Offset = "0x1F88650", VA = "0x181F89850")]
		private Settings BPINIFAMKPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1F89F70", Offset = "0x1F88D70", VA = "0x181F89F70")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum OKPEHKBKIOP
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface AGDDELKMGGC
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color IPFDGHGEEEN);
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
		private List<Material> CHHDOBBOBOF;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject BFKJEBODJMH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1F813D0", Offset = "0x1F801D0", VA = "0x181F813D0")]
		public void Init(BackgroundObject MDFMPPCALJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1F81670", Offset = "0x1F80470", VA = "0x181F81670")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1F81790", Offset = "0x1F80590", VA = "0x181F81790")]
		public void SetBlendValue(float ANGCIBJOABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1F818F0", Offset = "0x1F806F0", VA = "0x181F818F0")]
		public void SetColor(Color IPFDGHGEEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1F81A00", Offset = "0x1F80800", VA = "0x181F81A00")]
		public void SetRotation(float BHCPPAMLLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1F81B50", Offset = "0x1F80950", VA = "0x181F81B50")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface AENIIDCLOIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JFLNLAAKPIN<T> : AENIIDCLOIA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EJFPNDFLACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T MDNKLBBANDE);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public abstract class ActivationController : MonoBehaviour, AENIIDCLOIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public enum MLOINMFEPBP
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
		[EKKHEPIAELP("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual MLOINMFEPBP ELMPFFLKCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6CE7A0", Offset = "0x6CD5A0", VA = "0x1806CE7A0", Slot = "4")]
			get
			{
				return default(MLOINMFEPBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class ActivationController<T> : ActivationController, global::JFLNLAAKPIN<T>, AENIIDCLOIA where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		protected bool? IPKKBJLOCIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		protected T JADGPMJDFDO;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EJFPNDFLACO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x4734E30", Offset = "0x4733C30", VA = "0x184734E30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4734B30", Offset = "0x4733930", VA = "0x184734B30", Slot = "7")]
		public virtual void SetActivation(T MDNKLBBANDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool JKCLGANPPFM(T MDNKLBBANDE);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void PDLEOHMIBBL(bool PHFFJEPAFAI);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x37F3880", Offset = "0x37F2680", VA = "0x1837F3880")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public AGProBuilderStub()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F84CF0", Offset = "0x1F83AF0", VA = "0x181F84CF0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F849A0", Offset = "0x1F837A0", VA = "0x181F849A0")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
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
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
