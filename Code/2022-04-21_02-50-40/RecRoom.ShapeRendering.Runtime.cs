using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.ClusterLODs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BCPKPPDADHE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NPJGCAHCBEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<BCPKPPDADHE> OIJMIFJAFAE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4B07DD0", Offset = "0x4B06DD0", VA = "0x184B07DD0")]
	static NPJGCAHCBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B07DD0", Offset = "0x4B06DD0", VA = "0x184B07DD0")]
	[CBGMIIIDGNH]
	private static void AMFLIFGPNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B07EF0", Offset = "0x4B06EF0", VA = "0x184B07EF0")]
	public static bool MLIBOAKGGCJ(this BCPKPPDADHE GPGEIHIKNKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FNCMIIALAFI
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PLACEHOLDER_16 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GNIMJMACGJJ
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CBEFGCAJOJA
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum MPMCAALOGPL
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CDHIEJCABDH : MGPAGHMPPGI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private const byte KIKBJOMOJIC = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private byte PBJJFEHBFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly List<SkinnedShapeRenderer>[] ADPKPFFDKLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BIDLHFGHKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x523CD0", Offset = "0x522CD0", VA = "0x180523CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5A4A10", Offset = "0x5A3A10", VA = "0x1805A4A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int APFHKEPJOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x523CC0", Offset = "0x522CC0", VA = "0x180523CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AA590", Offset = "0x6A9590", VA = "0x1806AA590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float IKJFLLLBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDD57C0", Offset = "0xDD47C0", VA = "0x180DD57C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE56630", Offset = "0xE55630", VA = "0x180E56630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float AHGHCFKEGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xECD7E0", Offset = "0xECC7E0", VA = "0x180ECD7E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEDB380", Offset = "0xEDA380", VA = "0x180EDB380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> EGNIPOFBLLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4AFEC10", Offset = "0x4AFDC10", VA = "0x184AFEC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> MCKMLBIMBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3DA87B0", Offset = "0x3DA77B0", VA = "0x183DA87B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CHMPCBBJOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x54BA30", Offset = "0x54AA30", VA = "0x18054BA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6673A0", Offset = "0x6663A0", VA = "0x1806673A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte INIMKHGLPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4AFEBC0", Offset = "0x4AFDBC0", VA = "0x184AFEBC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4AFEC70", Offset = "0x4AFDC70", VA = "0x184AFEC70")]
	public CDHIEJCABDH(List<CIMBMPBDILE> ALANPLPDNNG, List<CIMBMPBDILE> MMILGGODGCG, List<Transform> IOJPAAPHIMN, Material IDPBEBDINLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4AFEAB0", Offset = "0x4AFDAB0", VA = "0x184AFEAB0")]
	private int JKGFLHIPKEO(List<CIMBMPBDILE> LIBFGKMEOLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4AFE790", Offset = "0x4AFD790", VA = "0x184AFE790")]
	private void CLNDBHBKEGO(int HBANAGJNFKI, bool JNIAMPBNAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4AFE9C0", Offset = "0x4AFD9C0", VA = "0x184AFE9C0")]
	public void FGGBKAPGAGK(Vector3 ACJPOCADKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4AFE930", Offset = "0x4AFD930", VA = "0x184AFE930", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4AFE8F0", Offset = "0x4AFD8F0", VA = "0x184AFE8F0")]
	public void DELGFBJGFEC(Transform FGGJPDOANLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CIPDLBIMOGI : GMNAJKEMGAA, HEHCLGMDAEO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DEBGBDINIKB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CIPDLBIMOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6343E0", Offset = "0x6333E0", VA = "0x1806343E0")]
		[DebuggerHidden]
		public DEBGBDINIKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4B027C0", Offset = "0x4B017C0", VA = "0x184B027C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4B02310", Offset = "0x4B01310", VA = "0x184B02310", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4B02940", Offset = "0x4B01940", VA = "0x184B02940")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4B02980", Offset = "0x4B01980", VA = "0x184B02980")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4B029D0", Offset = "0x4B019D0", VA = "0x184B029D0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4B02770", Offset = "0x4B01770", VA = "0x184B02770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4B026D0", Offset = "0x4B016D0", VA = "0x184B026D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4B026D0", Offset = "0x4B016D0", VA = "0x184B026D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EJLEDFMEGDG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CIPDLBIMOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6343E0", Offset = "0x6333E0", VA = "0x1806343E0")]
		[DebuggerHidden]
		public EJLEDFMEGDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4B02DC0", Offset = "0x4B01DC0", VA = "0x184B02DC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4B02A20", Offset = "0x4B01A20", VA = "0x184B02A20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4B02EE0", Offset = "0x4B01EE0", VA = "0x184B02EE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4B02F30", Offset = "0x4B01F30", VA = "0x184B02F30")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4B02D70", Offset = "0x4B01D70", VA = "0x184B02D70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4B02CD0", Offset = "0x4B01CD0", VA = "0x184B02CD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4B02CD0", Offset = "0x4B01CD0", VA = "0x184B02CD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private MBPHDHENHFL GMOAEEEPEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<KINHAHBEILB> HMGILKIGCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<ClusterMeshRenderer> CEDEFJGJIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private BatchedMeshRenderer DGPFLEACIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool EGBLHKNCCNM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<AFEEDLOKIJP> FBECHDLNFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AIELIFJBHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4B01000", Offset = "0x4B00000", VA = "0x184B01000", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform NFDJDNFDLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4B00F20", Offset = "0x4AFFF20", VA = "0x184B00F20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> JOBLEPCCKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x524010", Offset = "0x523010", VA = "0x180524010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x524020", Offset = "0x523020", VA = "0x180524020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B010B0", Offset = "0x4B000B0", VA = "0x184B010B0")]
	public CIPDLBIMOGI(MBPHDHENHFL KBGHOMNKDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B00720", Offset = "0x4AFF720", VA = "0x184B00720", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B00900", Offset = "0x4AFF900", VA = "0x184B00900")]
	public void IPMJFBAMOHP(KINHAHBEILB JINEPIAJIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4B009D0", Offset = "0x4AFF9D0", VA = "0x184B009D0")]
	public void JBOIIODGKNN(KINHAHBEILB JINEPIAJIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B00080", Offset = "0x4AFF080", VA = "0x184B00080", Slot = "4")]
	public void AAPMDEIFIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4B00F70", Offset = "0x4AFFF70", VA = "0x184B00F70")]
	public void OKEBEOJEDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B005D0", Offset = "0x4AFF5D0", VA = "0x184B005D0")]
	private void BMPNCBJMOHG(KINHAHBEILB JINEPIAJIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4B00A40", Offset = "0x4AFFA40", VA = "0x184B00A40")]
	public void LEHEBGBMJOM(bool KOKGAAOCJOL, bool IJABJAIDENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B007C0", Offset = "0x4AFF7C0", VA = "0x184B007C0")]
	protected void IOHPCGGOAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4B01040", Offset = "0x4B00040", VA = "0x184B01040")]
	[IteratorStateMachine(typeof(DEBGBDINIKB))]
	public IEnumerable<Renderer> PJANIHJAFPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4B00750", Offset = "0x4AFF750", VA = "0x184B00750")]
	[IteratorStateMachine(typeof(EJLEDFMEGDG))]
	public IEnumerable<Renderer> IKAAHIPNHNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class MBIELPECDHF : KINHAHBEILB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private CPBGOJDCNDN DHFIPHHIMBI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4B06B00", Offset = "0x4B05B00", VA = "0x184B06B00")]
	private NativeList<KJDGMPOMLCE> LJDLJEFGLFJ()
	{
		return default(NativeList<KJDGMPOMLCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4B06140", Offset = "0x4B05140", VA = "0x184B06140")]
	public MBIELPECDHF(CIPDLBIMOGI CJCHFFFELDO, CPBGOJDCNDN KBGHOMNKDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4B068E0", Offset = "0x4B058E0", VA = "0x184B068E0", Slot = "13")]
	public override int JKGFLHIPKEO(ABJFDOIBOPB ECNEJMHHLNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4B06190", Offset = "0x4B05190", VA = "0x184B06190", Slot = "14")]
	public override int EGNCHNEFJLM(ABJFDOIBOPB ECNEJMHHLNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4B063B0", Offset = "0x4B053B0", VA = "0x184B063B0", Slot = "15")]
	public override void IHCLNPOJDGC(ABJFDOIBOPB ECNEJMHHLNH, MLCLCJCONDF EMCBGKDPJIB, int JGDJMBAHABE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CJLKBMBKFKE : global::BNOBFPKKPMN<CJLKBMBKFKE>, PILHAHHJKAO, IEquatable<CJLKBMBKFKE>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LNGEFDKGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4F0", Offset = "0x7CE4F0", VA = "0x1807CF4F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87F4C0", Offset = "0x87E4C0", VA = "0x18087F4C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AKHAAILOLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4D0", Offset = "0x7CE4D0", VA = "0x1807CF4D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x858D70", Offset = "0x857D70", VA = "0x180858D70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D799F0", Offset = "0x3D789F0", VA = "0x183D799F0", Slot = "8")]
	public bool Equals(CJLKBMBKFKE JFBDCEDLHDN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4B01140", Offset = "0x4B00140", VA = "0x184B01140")]
	public static bool KABKJMOBADN(CJLKBMBKFKE BIHDAONKAFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FGOCOPLFIIG
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MBPHDHENHFL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform FHANEPIEABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FGOCOPLFIIG BCIADEFMPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PMGGPHNGKIB : global::BNOBFPKKPMN<PMGGPHNGKIB>, PILHAHHJKAO, IEquatable<PMGGPHNGKIB>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LNGEFDKGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4F0", Offset = "0x7CE4F0", VA = "0x1807CF4F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x87F4C0", Offset = "0x87E4C0", VA = "0x18087F4C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AKHAAILOLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4D0", Offset = "0x7CE4D0", VA = "0x1807CF4D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x858D70", Offset = "0x857D70", VA = "0x180858D70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3D799F0", Offset = "0x3D789F0", VA = "0x183D799F0", Slot = "8")]
	public bool Equals(PMGGPHNGKIB JFBDCEDLHDN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4B08370", Offset = "0x4B07370", VA = "0x184B08370")]
	public static bool KABKJMOBADN(PMGGPHNGKIB BIHDAONKAFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BHJBOFBKCCP
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform FHANEPIEABN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float PBMINGJOAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 LGJBAADKAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	BCPKPPDADHE KBJFGDKNFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FNCMIIALAFI OILNCCLIEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OAPCOJDKIPM : BHJBOFBKCCP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	BEFFGOEBMCB BCLOFLBGBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ICNLJAEPDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CPBGOJDCNDN : BHJBOFBKCCP
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool HAAFGDCCEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JOPFGEICAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float GHNMJMDAIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int NGPOOHMFFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool JODDGPGOACF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<KJDGMPOMLCE> LJDLJEFGLFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OFIGAGGLJAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEBJEJCJDHH(PMGGPHNGKIB JINEPIAJIFH, CBEFGCAJOJA PACPHIGFBEB);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEBJEJCJDHH(CJLKBMBKFKE CJCHFFFELDO, CBEFGCAJOJA PACPHIGFBEB);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EAOPALOMJAN(CJLKBMBKFKE CJCHFFFELDO);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EAOPALOMJAN(PMGGPHNGKIB JINEPIAJIFH);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNBNCODHOPB(CJLKBMBKFKE CJCHFFFELDO, MPMCAALOGPL LDJDMLKKJPF);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KDKNALPGPGK(CJLKBMBKFKE CJCHFFFELDO, Vector3 JGOJOEBBNJB, Vector3 MIPBNMNLAAP, Vector3 MBALMFJBMPD, float CEBHINNCJKD, float NIHNJHFGAAG, IReadOnlyList<Camera> NNKAJIPEHJK, GNIMJMACGJJ MOEBLOJNKOE);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KDKNALPGPGK(KJOBLBHJPGF IHFDICLCAPJ, Vector3 JGOJOEBBNJB, Vector3 MIPBNMNLAAP, Vector3 MBALMFJBMPD, float CEBHINNCJKD, float NIHNJHFGAAG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HHNDCKEJHJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJLKBMBKFKE ALHIOKBJAJO(MBPHDHENHFL KBGHOMNKDCA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIONMJOIOGG(CJLKBMBKFKE CJCHFFFELDO);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFOMFHKBAGJ(CJLKBMBKFKE CJCHFFFELDO);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PMGGPHNGKIB BDDIOLNCDCH(CJLKBMBKFKE CJCHFFFELDO, OAPCOJDKIPM KBGHOMNKDCA);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PMGGPHNGKIB JBELIOKBJHM(CJLKBMBKFKE CJCHFFFELDO, CPBGOJDCNDN KBGHOMNKDCA);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFPBPGLAIEI(PMGGPHNGKIB JINEPIAJIFH);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KDLGPECGIMP(PMGGPHNGKIB JINEPIAJIFH);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KJOBLBHJPGF KBJGODENAFA(FOCADHOCGHD KBGHOMNKDCA);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGJBKECDHPN(KJOBLBHJPGF IHFDICLCAPJ);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DKIHCHLCLJO(KJOBLBHJPGF IHFDICLCAPJ);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AKGANDGEINC MLEBEOHNBBL(Transform MADCANFDKFN, IEnumerable<PMGGPHNGKIB> HMGILKIGCNG, int ALCKCMOLDBN);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> AADPKPGLBCO(CJLKBMBKFKE CJCHFFFELDO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KJOBLBHJPGF : global::BNOBFPKKPMN<KJOBLBHJPGF>, PILHAHHJKAO, IEquatable<KJOBLBHJPGF>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LNGEFDKGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4F0", Offset = "0x7CE4F0", VA = "0x1807CF4F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x87F4C0", Offset = "0x87E4C0", VA = "0x18087F4C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int AKHAAILOLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4D0", Offset = "0x7CE4D0", VA = "0x1807CF4D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x858D70", Offset = "0x857D70", VA = "0x180858D70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3D799F0", Offset = "0x3D789F0", VA = "0x183D799F0", Slot = "8")]
	public bool Equals(KJOBLBHJPGF JFBDCEDLHDN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4B03A20", Offset = "0x4B02A20", VA = "0x184B03A20")]
	public static bool KABKJMOBADN(KJOBLBHJPGF BIHDAONKAFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FOCADHOCGHD
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int POKJHLNFCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform PMMIKOGEHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JFBAHMOBMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CJLKBMBKFKE GetBone(int MAHADFCAMEE);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MAHADFCAMEE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class LMGMBCEHCDA : KINHAHBEILB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public OAPCOJDKIPM HIILJEDFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int[] LEGCKFLGBKI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override MKOCPODDIAM GHIOGNDGCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4B05DA0", Offset = "0x4B04DA0", VA = "0x184B05DA0", Slot = "12")]
		get
		{
			return default(MKOCPODDIAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 KOJKGEABOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4B05190", Offset = "0x4B04190", VA = "0x184B05190")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4B06140", Offset = "0x4B05140", VA = "0x184B06140")]
	public LMGMBCEHCDA(CIPDLBIMOGI CJCHFFFELDO, OAPCOJDKIPM KBGHOMNKDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4B04C90", Offset = "0x4B03C90", VA = "0x184B04C90", Slot = "11")]
	public override bool AKPPHLGLGKO(Transform CJCHFFFELDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B05D00", Offset = "0x4B04D00", VA = "0x184B05D00", Slot = "13")]
	public override int JKGFLHIPKEO(ABJFDOIBOPB ECNEJMHHLNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4B05370", Offset = "0x4B04370", VA = "0x184B05370", Slot = "14")]
	public override int EGNCHNEFJLM(ABJFDOIBOPB ECNEJMHHLNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4B05410", Offset = "0x4B04410", VA = "0x184B05410")]
	private int IAFGOBPLFEN(ABJFDOIBOPB ECNEJMHHLNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4B05650", Offset = "0x4B04650", VA = "0x184B05650", Slot = "15")]
	public override void IHCLNPOJDGC(ABJFDOIBOPB ECNEJMHHLNH, MLCLCJCONDF EMCBGKDPJIB, int JGDJMBAHABE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MMIJOBCMGFO
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PILEKOGHFNN(MPMCAALOGPL LDJDMLKKJPF, Renderer LMNFGHMKKHL, int CICNPFDBONJ);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIIPIBOOKBB(Renderer LMNFGHMKKHL, GNIMJMACGJJ MOEBLOJNKOE, Vector3 JGOJOEBBNJB, Vector3 MIPBNMNLAAP, Vector3 MBALMFJBMPD, float CEBHINNCJKD, float NIHNJHFGAAG, float DDNBEEHMIFH = -1f, [Optional] Color? JLCBKIFFJIL, [Optional] IReadOnlyList<Camera> MHJDPGAJBKP);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMGKJKOBGFD(Renderer LMNFGHMKKHL, int CICNPFDBONJ);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HHDMNLCMHML();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GPLGJPJHPPG(int GGMAAHLADNN, CBEFGCAJOJA LDJDMLKKJPF, Renderer LMNFGHMKKHL, int CICNPFDBONJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KNGHLGGAHJF : OFIGAGGLJAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly MMIJOBCMGFO LBLICCBDCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly OELLDHNBIAK HDDPLKHLGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private MeshRenderer FIKLEANGFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private EAMCDMJJDOM FGOBFPDHKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private MeshRenderer PJLKICBACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private EAMCDMJJDOM HIHBMGNODGE;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x536990", Offset = "0x535990", VA = "0x180536990")]
	public KNGHLGGAHJF(MMIJOBCMGFO OEJIFGACGPF, OELLDHNBIAK HDDPLKHLGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4B03A60", Offset = "0x4B02A60", VA = "0x184B03A60", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4B04170", Offset = "0x4B03170", VA = "0x184B04170", Slot = "4")]
	public void EEBJEJCJDHH(PMGGPHNGKIB JINEPIAJIFH, CBEFGCAJOJA PACPHIGFBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4B03FA0", Offset = "0x4B02FA0", VA = "0x184B03FA0", Slot = "5")]
	public void EEBJEJCJDHH(CJLKBMBKFKE CJCHFFFELDO, CBEFGCAJOJA PACPHIGFBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4B03E00", Offset = "0x4B02E00", VA = "0x184B03E00", Slot = "6")]
	public void EAOPALOMJAN(CJLKBMBKFKE CJCHFFFELDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4B03BB0", Offset = "0x4B02BB0", VA = "0x184B03BB0", Slot = "7")]
	public void EAOPALOMJAN(PMGGPHNGKIB JINEPIAJIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4B04AF0", Offset = "0x4B03AF0", VA = "0x184B04AF0", Slot = "8")]
	public void KNBNCODHOPB(CJLKBMBKFKE CJCHFFFELDO, MPMCAALOGPL LDJDMLKKJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4B047C0", Offset = "0x4B037C0", VA = "0x184B047C0", Slot = "9")]
	public void KDKNALPGPGK(CJLKBMBKFKE CJCHFFFELDO, Vector3 JGOJOEBBNJB, Vector3 MIPBNMNLAAP, Vector3 MBALMFJBMPD, float CEBHINNCJKD, float NIHNJHFGAAG, IReadOnlyList<Camera> NNKAJIPEHJK, GNIMJMACGJJ MOEBLOJNKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4B043F0", Offset = "0x4B033F0", VA = "0x184B043F0", Slot = "10")]
	public void KDKNALPGPGK(KJOBLBHJPGF IHFDICLCAPJ, Vector3 JGOJOEBBNJB, Vector3 MIPBNMNLAAP, Vector3 MBALMFJBMPD, float CEBHINNCJKD, float NIHNJHFGAAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class KINHAHBEILB : IAPDBFKLOFK, AFEEDLOKIJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	protected Bounds CKFALKAIJFA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public CIPDLBIMOGI CHMPCBBJOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x523490", Offset = "0x522490", VA = "0x180523490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds DNHAALABPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x196BF20", Offset = "0x196AF20", VA = "0x18196BF20", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual MKOCPODDIAM GHIOGNDGCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4B03990", Offset = "0x4B02990", VA = "0x184B03990", Slot = "12")]
		get
		{
			return default(MKOCPODDIAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4B03920", Offset = "0x4B02920", VA = "0x184B03920", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x523EC0", Offset = "0x522EC0", VA = "0x180523EC0", Slot = "11")]
	public virtual bool AKPPHLGLGKO(Transform CJCHFFFELDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int JKGFLHIPKEO(ABJFDOIBOPB ECNEJMHHLNH);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int EGNCHNEFJLM(ABJFDOIBOPB ECNEJMHHLNH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void IHCLNPOJDGC(ABJFDOIBOPB ECNEJMHHLNH, MLCLCJCONDF EMCBGKDPJIB, int JGDJMBAHABE = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	protected KINHAHBEILB()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4B083B0", Offset = "0x4B073B0", VA = "0x184B083B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BEFFGOEBMCB
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class BLCOOOCNNKK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OAADGNOBEED : IEnumerable<CEJABKMLCCE>, IEnumerable, IEnumerator<CEJABKMLCCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private CEJABKMLCCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private CEJABKMLCCE System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6343E0", Offset = "0x6333E0", VA = "0x1806343E0")]
		[DebuggerHidden]
		public OAADGNOBEED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4B07F70", Offset = "0x4B06F70", VA = "0x184B07F70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4B080E0", Offset = "0x4B070E0", VA = "0x184B080E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B08050", Offset = "0x4B07050", VA = "0x184B08050", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CEJABKMLCCE> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B08050", Offset = "0x4B07050", VA = "0x184B08050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const int DADGMKMBONL = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static CEJABKMLCCE[][] KADLPNOLBGH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static LFIBACAJBLO CBPCMNHBOMO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static ShapeRendererConfig FBJGDNOAHAB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader BAOAFGGMKFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4AFDCF0", Offset = "0x4AFCCF0", VA = "0x184AFDCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer FNPGPPODCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4AFDC80", Offset = "0x4AFCC80", VA = "0x184AFDC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4AFDA00", Offset = "0x4AFCA00", VA = "0x184AFDA00")]
	public static Mesh BKJPDOLDKNK(BEFFGOEBMCB IIMPDHDIDEE, int ECNEJMHHLNH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4AFE180", Offset = "0x4AFD180", VA = "0x184AFE180")]
	public static int MDJDDJNDFLG(BEFFGOEBMCB IIMPDHDIDEE, int ECNEJMHHLNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4AFDAC0", Offset = "0x4AFCAC0", VA = "0x184AFDAC0")]
	public static LFIBACAJBLO FDPCIHEFKCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4AFDC20", Offset = "0x4AFCC20", VA = "0x184AFDC20")]
	[IteratorStateMachine(typeof(OAADGNOBEED))]
	private static IEnumerable<CEJABKMLCCE> KFKJFMHEHLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4AFE3D0", Offset = "0x4AFD3D0", VA = "0x184AFE3D0")]
	public static CEJABKMLCCE ONAGNLCAAMG(BEFFGOEBMCB IIMPDHDIDEE, int ECNEJMHHLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4AFE190", Offset = "0x4AFD190", VA = "0x184AFE190")]
	public static bool NLIDCCPNNBK(this BEFFGOEBMCB IIMPDHDIDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4AFD840", Offset = "0x4AFC840", VA = "0x184AFD840")]
	public static void BJDGOGFDLIA(BEFFGOEBMCB IIMPDHDIDEE, float3 FALHEMIFLMO, out BDPECLOLNEO KNLFIPINOEP, out float3 LAKELIAFKHJ, out float CMADFBKKHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4AFDD60", Offset = "0x4AFCD60", VA = "0x184AFDD60")]
	public static void LPIHOBCNKGO(Vector3 FALHEMIFLMO, BEFFGOEBMCB IIMPDHDIDEE, out Vector3 LAKELIAFKHJ, out float CMADFBKKHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4AFDC10", Offset = "0x4AFCC10", VA = "0x184AFDC10")]
	[HNDGNKOOMOO(MBIOIPKMLMP.ExitingPlayMode, 0)]
	private static void JNHADDKPLFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4AFE1B0", Offset = "0x4AFD1B0", VA = "0x184AFE1B0")]
	[HNDGNKOOMOO(MBIOIPKMLMP.ExitingPlayMode, 0)]
	private static void ODMEBOHOONC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MACPCAOEPCD
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool GLPOHJIPMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material HHIDIBCHIAC();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material PANHPNLPGBG();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material BPKMDIPIBJK();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KJDOMKMHCON(BCPKPPDADHE HNJOLADOKII);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MMKDCOFNGOB(FNCMIIALAFI AHIOFGHFOLH);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PDHODKKAKGP(GameObject HAFCDCMNBJO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHOKKKPBCJF(GameObject HAFCDCMNBJO, bool JFOBJJEOHEK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface OELLDHNBIAK
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CIPDLBIMOGI KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KINHAHBEILB KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NLLEKOBPIMK KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class DCMADGJGJIK : HHNDCKEJHJD, IDisposable, OELLDHNBIAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly global::LAAMOJECPFF<CJLKBMBKFKE, CIPDLBIMOGI> JAJDBBMIALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::LAAMOJECPFF<PMGGPHNGKIB, KINHAHBEILB> HMGILKIGCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::LAAMOJECPFF<KJOBLBHJPGF, NLLEKOBPIMK> HDAOIHEPEBM;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static MACPCAOEPCD INDOPJHPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4B01E60", Offset = "0x4B00E60", VA = "0x184B01E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4B01A10", Offset = "0x4B00A10", VA = "0x184B01A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CIPDLBIMOGI KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4B015C0", Offset = "0x4B005C0", VA = "0x184B015C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KINHAHBEILB KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4B01680", Offset = "0x4B00680", VA = "0x184B01680", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NLLEKOBPIMK KBPJCMENGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4B01620", Offset = "0x4B00620", VA = "0x184B01620", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4B01EA0", Offset = "0x4B00EA0", VA = "0x184B01EA0")]
	public DCMADGJGJIK(MACPCAOEPCD OEJIFGACGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4B014E0", Offset = "0x4B004E0", VA = "0x184B014E0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4B01240", Offset = "0x4B00240", VA = "0x184B01240", Slot = "4")]
	public CJLKBMBKFKE ALHIOKBJAJO(MBPHDHENHFL KBGHOMNKDCA)
	{
		return default(CJLKBMBKFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4B01830", Offset = "0x4B00830", VA = "0x184B01830", Slot = "5")]
	public void JIONMJOIOGG(CJLKBMBKFKE CJCHFFFELDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4B01550", Offset = "0x4B00550", VA = "0x184B01550", Slot = "6")]
	public void FFOMFHKBAGJ(CJLKBMBKFKE CJCHFFFELDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B01180", Offset = "0x4B00180", VA = "0x184B01180", Slot = "15")]
	public IEnumerable<Renderer> AADPKPGLBCO(CJLKBMBKFKE CJCHFFFELDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B01320", Offset = "0x4B00320", VA = "0x184B01320", Slot = "7")]
	public PMGGPHNGKIB BDDIOLNCDCH(CJLKBMBKFKE CJCHFFFELDO, OAPCOJDKIPM KBGHOMNKDCA)
	{
		return default(PMGGPHNGKIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B01740", Offset = "0x4B00740", VA = "0x184B01740", Slot = "8")]
	public PMGGPHNGKIB JBELIOKBJHM(CJLKBMBKFKE CJCHFFFELDO, CPBGOJDCNDN KBGHOMNKDCA)
	{
		return default(PMGGPHNGKIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4B019A0", Offset = "0x4B009A0", VA = "0x184B019A0", Slot = "10")]
	public void KDLGPECGIMP(PMGGPHNGKIB JINEPIAJIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4B016E0", Offset = "0x4B006E0", VA = "0x184B016E0", Slot = "9")]
	public void HFPBPGLAIEI(PMGGPHNGKIB JINEPIAJIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B01890", Offset = "0x4B00890", VA = "0x184B01890", Slot = "11")]
	public KJOBLBHJPGF KBJGODENAFA(FOCADHOCGHD KBGHOMNKDCA)
	{
		return default(KJOBLBHJPGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B01470", Offset = "0x4B00470", VA = "0x184B01470", Slot = "13")]
	public void DKIHCHLCLJO(KJOBLBHJPGF IHFDICLCAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B01410", Offset = "0x4B00410", VA = "0x184B01410", Slot = "12")]
	public void DGJBKECDHPN(KJOBLBHJPGF IHFDICLCAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4B01A60", Offset = "0x4B00A60", VA = "0x184B01A60", Slot = "14")]
	public AKGANDGEINC MLEBEOHNBBL(Transform MADCANFDKFN, IEnumerable<PMGGPHNGKIB> HMGILKIGCNG, int ALCKCMOLDBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NLLEKOBPIMK : GMNAJKEMGAA
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class KBMPDFJMJIP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public NLLEKOBPIMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6343E0", Offset = "0x6333E0", VA = "0x1806343E0")]
		[DebuggerHidden]
		public KBMPDFJMJIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4B03840", Offset = "0x4B02840", VA = "0x184B03840", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4B03560", Offset = "0x4B02560", VA = "0x184B03560", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4B038E0", Offset = "0x4B028E0", VA = "0x184B038E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4B037F0", Offset = "0x4B027F0", VA = "0x184B037F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4B03750", Offset = "0x4B02750", VA = "0x184B03750", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4B03750", Offset = "0x4B02750", VA = "0x184B03750", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly FOCADHOCGHD EKIKALFFFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly OELLDHNBIAK HDDPLKHLGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private CDHIEJCABDH FPBOKNLIJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private List<CIMBMPBDILE> KCKIBIDHFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<CIMBMPBDILE> ECOJHPEOOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private GameObject OAJIFOLAICH;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B07BF0", Offset = "0x4B06BF0", VA = "0x184B07BF0")]
	public static NLLEKOBPIMK PBFIKOKKJAN(FOCADHOCGHD KBGHOMNKDCA, OELLDHNBIAK HDDPLKHLGNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B07D40", Offset = "0x4B06D40", VA = "0x184B07D40")]
	private NLLEKOBPIMK(FOCADHOCGHD KBGHOMNKDCA, OELLDHNBIAK HDDPLKHLGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4B07600", Offset = "0x4B06600", VA = "0x184B07600")]
	public void NIICFFGCHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B07CD0", Offset = "0x4B06CD0", VA = "0x184B07CD0")]
	[IteratorStateMachine(typeof(KBMPDFJMJIP))]
	public IEnumerable<Renderer> PJANIHJAFPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B06BD0", Offset = "0x4B05BD0", VA = "0x184B06BD0", Slot = "4")]
	public void AAPMDEIFIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B075D0", Offset = "0x4B065D0", VA = "0x184B075D0")]
	private void LCKJNHNADDH(Vector3 ACJPOCADKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B07A20", Offset = "0x4B06A20", VA = "0x184B07A20")]
	public void OKEBEOJEDHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CIMBMPBDILE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct EMGMAMMJBAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public MLCLCJCONDF FBGAKPBMLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Transform EHCHPEKNPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int LOODAKHIPMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JOOCOFINIPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public CIMBMPBDILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public ABJFDOIBOPB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<EMGMAMMJBAB> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public JOOCOFINIPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OIINCJHCICA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AKGANDGEINC combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public JOOCOFINIPG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public OIINCJHCICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4B08130", Offset = "0x4B07130", VA = "0x184B08130")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4B081A0", Offset = "0x4B071A0", VA = "0x184B081A0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4B081E0", Offset = "0x4B071E0", VA = "0x184B081E0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int[] JPJOHKOCFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private CBLLNIJBKJL FEOEDIMAGHP;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static Matrix4x4 NAEJDDFAMPO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh ONMNNIFCJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x523490", Offset = "0x522490", VA = "0x180523490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int ELHKLKFDKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5AF670", Offset = "0x5AE670", VA = "0x1805AF670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CF0", Offset = "0x6A0CF0", VA = "0x1806A1CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4AFF990", Offset = "0x4AFE990", VA = "0x184AFF990")]
	public void HHODJBKEPPD(List<Transform> NDABNOHPGKM, Matrix4x4[] HHAHPGMHEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4AFEF30", Offset = "0x4AFDF30", VA = "0x184AFEF30")]
	public static List<CIMBMPBDILE> ANENLEADNCN(List<CIPDLBIMOGI> FHOADBKNFGI, ABJFDOIBOPB ECNEJMHHLNH, Bounds IDFDMFFIPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4AFF610", Offset = "0x4AFE610", VA = "0x184AFF610")]
	private JobHandle EBEENPCIMMM(AKGANDGEINC MICBFGOGPLJ, int EOHOKFKLJKC, int DECEEKGFAOC, ABJFDOIBOPB ECNEJMHHLNH, List<EMGMAMMJBAB> DKIPOPHLKOP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4AFF490", Offset = "0x4AFE490", VA = "0x184AFF490")]
	private void BFCANAMBABF(List<EMGMAMMJBAB> DKIPOPHLKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4AFFCD0", Offset = "0x4AFECD0", VA = "0x184AFFCD0")]
	private CIMBMPBDILE(List<EMGMAMMJBAB> DKIPOPHLKOP, int EOHOKFKLJKC, int DECEEKGFAOC, ABJFDOIBOPB ECNEJMHHLNH, Bounds IDFDMFFIPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4AFF590", Offset = "0x4AFE590", VA = "0x184AFF590", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private MaterialPropertyBlock NDJLHELALLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private CIMBMPBDILE FILEFGGGGMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private List<Transform> IOJPAAPHIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private RenderTexture JMFIGELMLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private ComputeBuffer PEMBAEKGFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeShader PJDJKHNGCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private Matrix4x4[] DMPBEBFPHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int NIECBKHPCPP;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer JPFFGBHGDAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5234A0", Offset = "0x5224A0", VA = "0x1805234A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int POKJHLNFCAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4B08F50", Offset = "0x4B07F50", VA = "0x184B08F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4B08470", Offset = "0x4B07470", VA = "0x184B08470")]
		public static List<SkinnedShapeRenderer> Create(GameObject CJCHFFFELDO, List<CIMBMPBDILE> LIBFGKMEOLF, List<Transform> IOJPAAPHIMN, Material IDPBEBDINLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4B089D0", Offset = "0x4B079D0", VA = "0x184B089D0")]
		public void Init(CIMBMPBDILE FILEFGGGGMO, List<Transform> IOJPAAPHIMN, Material IDPBEBDINLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4B08EC0", Offset = "0x4B07EC0", VA = "0x184B08EC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4B08E30", Offset = "0x4B07E30", VA = "0x184B08E30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4B08DF0", Offset = "0x4B07DF0", VA = "0x184B08DF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4B083E0", Offset = "0x4B073E0", VA = "0x184B083E0")]
		private void CHHFHBBNBJG(ScriptableRenderContext JBPOCMHHIBO, Camera[] OPCFGALBANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4B08680", Offset = "0x4B07680", VA = "0x184B08680")]
		private void HHODJBKEPPD(CommandBuffer OKIPAMGEEJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD6F9B0", Offset = "0xD6E9B0", VA = "0x180D6F9B0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class EMILBIDIJON
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static byte[] MHCBODEMNDA;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int DAIOMNBGJFA;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int DDGCDEKJNBF;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static BigInteger CONMBDBFJHL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	public EMILBIDIJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4B032A0", Offset = "0x4B022A0", VA = "0x184B032A0")]
	private static string PDOGHHMIGDK(byte[] EJCAMPCKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4B02F70", Offset = "0x4B01F70", VA = "0x184B02F70")]
	public static string KPIGCAGDHMH(byte[] BGILCKNBLBG, bool LCPNKOKDLIC)
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

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
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
