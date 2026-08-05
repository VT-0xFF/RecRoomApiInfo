using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.ClusterLODs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IAKPGHMJHAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RRO_MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	RRO_COLORS_COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	RRO_MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	GENERATED_MIN_VALUE = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	GENERATED_COLORS_BITS_PER_CHANNEL = 8,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	GENERATED_COLORS_COUNT = 16777216,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	GENERATED_MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	LEGACY_GENERATED_COLORS_COUNT = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	GENERATED_TO_GPU_OFFSET = -939,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BLMHNFNHLHK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCD20", Offset = "0x5BDC120", VA = "0x185BDCD20")]
	public static bool OIJOBCGGACN(this IAKPGHMJHAJ KLOOAGEEOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCD10", Offset = "0x5BDC110", VA = "0x185BDCD10")]
	public static bool KCDEDIPBFAB(this IAKPGHMJHAJ KLOOAGEEOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCCE0", Offset = "0x5BDC0E0", VA = "0x185BDCCE0")]
	public static bool JKJGBAPACOI(this IAKPGHMJHAJ KLOOAGEEOBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DPGOAOHOKGO
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IBPLIPEDNEB
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CCIJEMEMFDD
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DebugLocate,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	FrozenHover
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum DAHJELBGFBF
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NJAEGFGDOCD : FMKPGDCPHBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte LIDHBJEPGEL = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte MLMCGOGKKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] MFFAKGCJGLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PCABMEIIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x735750", Offset = "0x734B50", VA = "0x180735750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CC0", Offset = "0x7D70C0", VA = "0x1807D7CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GEHGMGBLPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x735740", Offset = "0x734B40", VA = "0x180735740", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x869550", Offset = "0x868950", VA = "0x180869550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float PDBNHMDMNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEDF680", Offset = "0xEDEA80", VA = "0x180EDF680", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCBBDD0", Offset = "0xCBB1D0", VA = "0x180CBBDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float IMDFICDNBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD7E980", Offset = "0xD7DD80", VA = "0x180D7E980", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCBBE00", Offset = "0xCBB200", VA = "0x180CBBE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GMFGKBBJDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3D10", Offset = "0x5BE3110", VA = "0x185BE3D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> KNPEMGEHHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3DB0", Offset = "0x5BE31B0", VA = "0x185BE3DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0D30", VA = "0x1807B1930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte GEMCPCOINGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5BE39E0", Offset = "0x5BE2DE0", VA = "0x185BE39E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5BE3F40", Offset = "0x5BE3340", VA = "0x185BE3F40")]
	public NJAEGFGDOCD(List<AGDKNLPJALF> HLNBNLOAJBM, List<AGDKNLPJALF> JPNDCIKFLHN, List<MCFKMCFIHNF> FADBJBIPAJF, Material NIFEJPCAIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5BE3C00", Offset = "0x5BE3000", VA = "0x185BE3C00")]
	private int JIBHMIACFCL(List<AGDKNLPJALF> JADOIBMLKFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5BE3DF0", Offset = "0x5BE31F0", VA = "0x185BE3DF0")]
	private void PLGNGGEPGPL(int NJDAOKFFHIG, bool KHJHBNPBBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5BE3A30", Offset = "0x5BE2E30", VA = "0x185BE3A30")]
	public void BCAOFCJJGKL(Vector3 OPJJJNDLBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5BE3AD0", Offset = "0x5BE2ED0", VA = "0x185BE3AD0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5BE3D70", Offset = "0x5BE3170", VA = "0x185BE3D70")]
	public void NFCDMEFNKOD(Transform LAMGIHJKEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ABDPNLBMMFB : AGGMBKONOLH, MBPOIPFOPLD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EBEGNOLLPOC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ABDPNLBMMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
		[DebuggerHidden]
		public EBEGNOLLPOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEC90", Offset = "0x5BDE090", VA = "0x185BDEC90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE760", Offset = "0x5BDDB60", VA = "0x185BDE760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5BDED90", Offset = "0x5BDE190", VA = "0x185BDED90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEDE0", Offset = "0x5BDE1E0", VA = "0x185BDEDE0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEE30", Offset = "0x5BDE230", VA = "0x185BDEE30")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEC50", Offset = "0x5BDE050", VA = "0x185BDEC50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEBB0", Offset = "0x5BDDFB0", VA = "0x185BDEBB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEBB0", Offset = "0x5BDDFB0", VA = "0x185BDEBB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GNENJBMJGOG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ABDPNLBMMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
		[DebuggerHidden]
		public GNENJBMJGOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5BE15A0", Offset = "0x5BE09A0", VA = "0x185BE15A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BE11E0", Offset = "0x5BE05E0", VA = "0x185BE11E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1680", Offset = "0x5BE0A80", VA = "0x185BE1680")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE16D0", Offset = "0x5BE0AD0", VA = "0x185BE16D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1560", Offset = "0x5BE0960", VA = "0x185BE1560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5BE14C0", Offset = "0x5BE08C0", VA = "0x185BE14C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5BE14C0", Offset = "0x5BE08C0", VA = "0x185BE14C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CNANLHPDAPN BEDKKKJBGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<PCCEPDBJLIP> JEBHCCFODNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> MCDKIKHILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer KCPLKHDKJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool LBBFAHKDGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool INCBJMIGJME;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<DMLNGPJLIAD> OKMDLDCIICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FOMLFFIMELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5BDB380", Offset = "0x5BDA780", VA = "0x185BDB380", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MCFKMCFIHNF HOELEHEDINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BDB2B0", Offset = "0x5BDA6B0", VA = "0x185BDB2B0", Slot = "7")]
		get
		{
			return default(MCFKMCFIHNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> BLLOAKKEIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x735A20", Offset = "0x734E20", VA = "0x180735A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB290", Offset = "0x5BDA690", VA = "0x185BDB290")]
	private bool JPFLIBEMBJA(PCCEPDBJLIP BDEOKFDPKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5BDAE70", Offset = "0x5BDA270", VA = "0x185BDAE70")]
	private static bool GGGLDJOJDEM(PCCEPDBJLIP BDEOKFDPKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB3C0", Offset = "0x5BDA7C0", VA = "0x185BDB3C0")]
	public ABDPNLBMMFB(CNANLHPDAPN HIDEHJGLNHO, bool EPOMBBFBHFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5BDA5E0", Offset = "0x5BD99E0", VA = "0x185BDA5E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5BD9C80", Offset = "0x5BD9080", VA = "0x185BD9C80")]
	public void AGMLDLCGDGN(PCCEPDBJLIP BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5BDA7D0", Offset = "0x5BD9BD0", VA = "0x185BDA7D0")]
	public void FJEBMLODAAK(PCCEPDBJLIP BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5BDA900", Offset = "0x5BD9D00", VA = "0x185BDA900", Slot = "4")]
	public void GGFKJBEONBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5BDAE90", Offset = "0x5BDA290", VA = "0x185BDAE90")]
	public void HGAJENLLFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BD9ED0", Offset = "0x5BD92D0", VA = "0x185BD9ED0")]
	private void BNNAJJFBMCE(List<PCCEPDBJLIP> JEBHCCFODNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BDA060", Offset = "0x5BD9460", VA = "0x185BDA060")]
	private static Material CEFDCAPGPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BD9E30", Offset = "0x5BD9230", VA = "0x185BD9E30")]
	private void BNNAJJFBMCE(PCCEPDBJLIP BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB0E0", Offset = "0x5BDA4E0", VA = "0x185BDB0E0")]
	private void HHEANFMLACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BDA0C0", Offset = "0x5BD94C0", VA = "0x185BDA0C0")]
	public void DBNKPAODBAE(bool NNLNIAPLJCC, bool NJMHBMIAFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BDA740", Offset = "0x5BD9B40", VA = "0x185BDA740")]
	protected void ENEBHIHDNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB220", Offset = "0x5BDA620", VA = "0x185BDB220")]
	[IteratorStateMachine(typeof(EBEGNOLLPOC))]
	public IEnumerable<Renderer> JDDLFHBEJOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB1B0", Offset = "0x5BDA5B0", VA = "0x185BDB1B0")]
	[IteratorStateMachine(typeof(GNENJBMJGOG))]
	public IEnumerable<Renderer> IGAHPFEPJMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class DHCCBIDOKJC : PCCEPDBJLIP
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct IAGEPBPGEAA : HMEMAGOJFNE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private NPEGMPBOOAE JPGFKCEECPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JobHandle DNPFDFHMBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private DADBNIGCJEC JPPFLCOAGAD;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE17A0", Offset = "0x5BE0BA0", VA = "0x185BE17A0")]
		public IAGEPBPGEAA(NPEGMPBOOAE JPGFKCEECPG, JobHandle DNPFDFHMBNH, DADBNIGCJEC JPPFLCOAGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xD7F230", Offset = "0xD7E630", VA = "0x180D7F230")]
		public bool JKIEOPECNID()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1770", Offset = "0x5BE0B70", VA = "0x185BE1770", Slot = "4")]
		public NPEGMPBOOAE JHOFICMAMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1720", Offset = "0x5BE0B20", VA = "0x185BE1720", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly EEPOLCFNAIN KHBFFDBEOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private float GEDFLJCGFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Hash128 BNMLFCCFNHO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 NPBEDCPFOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5BDD720", Offset = "0x5BDCB20", VA = "0x185BDD720", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5BDE6B0", Offset = "0x5BDDAB0", VA = "0x185BDE6B0")]
	public DHCCBIDOKJC(ABDPNLBMMFB EAGPPNPHOBG, EEPOLCFNAIN HIDEHJGLNHO, bool EPOMBBFBHFA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "16")]
	public override bool ODCMDEKLBJI(MCFKMCFIHNF EAGPPNPHOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5BDE110", Offset = "0x5BDD510", VA = "0x185BDE110", Slot = "18")]
	public override int JIBHMIACFCL(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5BDE300", Offset = "0x5BDD700", VA = "0x185BDE300", Slot = "19")]
	public override int KOEDABKINBN(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCF70", Offset = "0x5BDC370", VA = "0x185BDCF70", Slot = "20")]
	public override void ANEAMEJCBJP(NIIJMGJLALG IFODHNBBPCL, BMEGHCJFONA BAGHMHPLLPP, int ODAGKBPNIOJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD650", Offset = "0x5BDCA50", VA = "0x185BDD650", Slot = "21")]
	public override MCFKMCFIHNF GEBNBHFHKBB()
	{
		return default(MCFKMCFIHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5BDE4F0", Offset = "0x5BDD8F0", VA = "0x185BDE4F0", Slot = "23")]
	public override FBCMFMGBKIK NDLCJHHANCG()
	{
		return default(FBCMFMGBKIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD850", Offset = "0x5BDCC50", VA = "0x185BDD850", Slot = "24")]
	public override HMEMAGOJFNE IBNPFPCJGNC(NIIJMGJLALG IFODHNBBPCL, JobHandle DNPFDFHMBNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct AEMMGGABEOL : global::CMECDGBHMLE<AEMMGGABEOL>, AHPPOODHHGC, IEquatable<AEMMGGABEOL>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int CMHFEELAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xBF6690", Offset = "0xBF5A90", VA = "0x180BF6690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[CreateProperty]
	public int PELKNHEANOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x899ED0", Offset = "0x8992D0", VA = "0x180899ED0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xBF66A0", Offset = "0xBF5AA0", VA = "0x180BF66A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5BDB4B0", Offset = "0x5BDA8B0", VA = "0x185BDB4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2E444F0", Offset = "0x2E438F0", VA = "0x182E444F0", Slot = "8")]
	public bool Equals(AEMMGGABEOL MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29FC330", Offset = "0x29FB730", VA = "0x1829FC330")]
	public static bool BOBJELOEACN(AEMMGGABEOL HFOFADIOHHP, AEMMGGABEOL GFCGIJPPCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4FE72C0", Offset = "0x4FE66C0", VA = "0x184FE72C0")]
	public static bool GPCPOEGFAHL(AEMMGGABEOL HFOFADIOHHP, AEMMGGABEOL GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB4F0", Offset = "0x5BDA8F0", VA = "0x185BDB4F0", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB580", Offset = "0x5BDA980", VA = "0x185BDB580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum NEKJDNFNBCD
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CNANLHPDAPN
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	MCFKMCFIHNF LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NEKJDNFNBCD EGPHECOMHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CCFPCJFIGFD : global::CMECDGBHMLE<CCFPCJFIGFD>, AHPPOODHHGC, IEquatable<CCFPCJFIGFD>
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int CMHFEELAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xBF6690", Offset = "0xBF5A90", VA = "0x180BF6690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	[CreateProperty]
	public int PELKNHEANOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x899ED0", Offset = "0x8992D0", VA = "0x180899ED0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xBF66A0", Offset = "0xBF5AA0", VA = "0x180BF66A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCD40", Offset = "0x5BDC140", VA = "0x185BDCD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E444F0", Offset = "0x2E438F0", VA = "0x182E444F0", Slot = "8")]
	public bool Equals(CCFPCJFIGFD MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29FC330", Offset = "0x29FB730", VA = "0x1829FC330")]
	public static bool BOBJELOEACN(CCFPCJFIGFD HFOFADIOHHP, CCFPCJFIGFD GFCGIJPPCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4FE72C0", Offset = "0x4FE66C0", VA = "0x184FE72C0")]
	public static bool GPCPOEGFAHL(CCFPCJFIGFD HFOFADIOHHP, CCFPCJFIGFD GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCD80", Offset = "0x5BDC180", VA = "0x185BDCD80", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCE10", Offset = "0x5BDC210", VA = "0x185BDCE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CNGBGCGDJNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GIGKGGIPPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EBFIGDCKFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MCFKMCFIHNF LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float MAMOGEPAJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 MIFIDFFJBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	IAKPGHMJHAJ BPBDOPIEINL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	DPGOAOHOKGO FLHGGBCHNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EDMBEKLJGEF : CNGBGCGDJNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LIOGEJPAGPB FMLGHHOMBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OMOEFAGEDML
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EEPOLCFNAIN : CNGBGCGDJNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool FMFOIEKMAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JEPAPCNOKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float LPGBPGFNJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int BDOJPPKNAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool GOKKCDMNODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int IMGJPNBDDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<OLIMHNMMHOP> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KPFEKJBLOJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDFJBMIAHLH(AEMMGGABEOL EAGPPNPHOBG, CCIJEMEMFDD JIDALOJGNEM);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDFJBMIAHLH(CCFPCJFIGFD BDEOKFDPKJH, CCIJEMEMFDD JIDALOJGNEM);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLIJKBDKGLH(CCFPCJFIGFD BDEOKFDPKJH);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPNHHMKDJOJ(CCFPCJFIGFD BDEOKFDPKJH);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ICNIEOBKDFL();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAGKCNJOJBE();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EECFLBNMFAD(CCIJEMEMFDD OGILDIMGIOH);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ADCKGOEFJNK(AEMMGGABEOL EAGPPNPHOBG);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ADCKGOEFJNK(CCFPCJFIGFD BDEOKFDPKJH);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JPFNKEMMGIA(AEMMGGABEOL EAGPPNPHOBG, DAHJELBGFBF OGILDIMGIOH);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JPFNKEMMGIA(CCFPCJFIGFD BDEOKFDPKJH, DAHJELBGFBF OGILDIMGIOH);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DENJCPBNOOA(CCFPCJFIGFD BDEOKFDPKJH);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OEAKLCDIAOM(CCFPCJFIGFD BDEOKFDPKJH);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MCMIFIHAAIF();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BBCCDFGMBCK();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IEAGJDFCFBH(DAHJELBGFBF OGILDIMGIOH);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HPNNAKALNPD(AEMMGGABEOL EAGPPNPHOBG, Vector3 EPOBGKIHBIB, Vector3 MBMICMLDMNM, Vector3 JGGCNAJLNID, float FBCCBNMFLFG, float KDBKDHJLLMJ, IReadOnlyList<Camera> FCHJECAPLGB, IBPLIPEDNEB PDOKPNENFJB);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HPNNAKALNPD(OBCECCCFMEH JIMBDDGJENJ, Vector3 EPOBGKIHBIB, Vector3 MBMICMLDMNM, Vector3 JGGCNAJLNID, float FBCCBNMFLFG, float KDBKDHJLLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public interface NALPKMPMJLA
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	ABDPNLBMMFB JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	PCCEPDBJLIP JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PLMONDBEGHN JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NHKEDADOGID : NALPKMPMJLA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool ACODFOOKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO, bool OAIEDKHCGOA);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBJJOJPLFBI(AEMMGGABEOL EAGPPNPHOBG);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MAFJOMEFHJN(AEMMGGABEOL EAGPPNPHOBG);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CCFPCJFIGFD BIGGBNMKOBJ(AEMMGGABEOL EAGPPNPHOBG, EDMBEKLJGEF HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CCFPCJFIGFD AFCDJHGMDCG(AEMMGGABEOL EAGPPNPHOBG, EEPOLCFNAIN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GFJDEGHAJNF(CCFPCJFIGFD BDEOKFDPKJH);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HKABDDJIEIH(CCFPCJFIGFD BDEOKFDPKJH);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OBCECCCFMEH NIIIHBDBAGE(KKFDMDJFKHN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KJDMIGBDABO(OBCECCCFMEH JIMBDDGJENJ);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AABPPAPIHBE(OBCECCCFMEH JIMBDDGJENJ);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task FNGJNOPEJOE();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task OBNBPGHOPKJ();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task GDJFKMELIDN();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NBNMNPCKFPH();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NPEGMPBOOAE KMLFBOAIAJO(MCFKMCFIHNF EOIBKAPDBPD, IEnumerable<CCFPCJFIGFD> JEBHCCFODNJ, int GKKCIKGEPLN);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerable<Renderer> CKEKHEIBHOC(AEMMGGABEOL EAGPPNPHOBG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OBCECCCFMEH : global::CMECDGBHMLE<OBCECCCFMEH>, AHPPOODHHGC, IEquatable<OBCECCCFMEH>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int CMHFEELAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xBF6690", Offset = "0xBF5A90", VA = "0x180BF6690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PELKNHEANOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x899ED0", Offset = "0x8992D0", VA = "0x180899ED0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xBF66A0", Offset = "0xBF5AA0", VA = "0x180BF66A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4300", Offset = "0x5BE3700", VA = "0x185BE4300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2E444F0", Offset = "0x2E438F0", VA = "0x182E444F0", Slot = "8")]
	public bool Equals(OBCECCCFMEH MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x29FC330", Offset = "0x29FB730", VA = "0x1829FC330")]
	public static bool BOBJELOEACN(OBCECCCFMEH HFOFADIOHHP, OBCECCCFMEH GFCGIJPPCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4FE72C0", Offset = "0x4FE66C0", VA = "0x184FE72C0")]
	public static bool GPCPOEGFAHL(OBCECCCFMEH HFOFADIOHHP, OBCECCCFMEH GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4340", Offset = "0x5BE3740", VA = "0x185BE4340", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KKFDMDJFKHN
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int BEIPCNECDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Transform IONGDCNPGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool CCOLPJOHAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AEMMGGABEOL GetBone(int KECKNCCIAGG);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int KECKNCCIAGG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class PPIAKPMHICO : NHKEDADOGID, NALPKMPMJLA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct MCKLKJEKCFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public PPIAKPMHICO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5BE31B0", Offset = "0x5BE25B0", VA = "0x185BE31B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly global::CLENJHDFPIE<AEMMGGABEOL, ABDPNLBMMFB> LJBLHPIOCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly global::CLENJHDFPIE<CCFPCJFIGFD, PCCEPDBJLIP> JEBHCCFODNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly global::CLENJHDFPIE<OBCECCCFMEH, PLMONDBEGHN> HFLGNPHMLPL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public ABDPNLBMMFB JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5BE8E00", Offset = "0x5BE8200", VA = "0x185BE8E00", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PCCEPDBJLIP JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5BE8DA0", Offset = "0x5BE81A0", VA = "0x185BE8DA0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PLMONDBEGHN JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5BE8D40", Offset = "0x5BE8140", VA = "0x185BE8D40", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool ACODFOOKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x754690", Offset = "0x753A90", VA = "0x180754690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA800", Offset = "0x5BE9C00", VA = "0x185BEA800")]
	public PPIAKPMHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8E60", Offset = "0x5BE8260", VA = "0x185BE8E60", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5BE87B0", Offset = "0x5BE7BB0", VA = "0x185BE87B0", Slot = "4")]
	public AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO)
	{
		return default(AEMMGGABEOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8510", Offset = "0x5BE7910", VA = "0x185BE8510", Slot = "5")]
	public AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO, bool EPOMBBFBHFA)
	{
		return default(AEMMGGABEOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5BE98F0", Offset = "0x5BE8CF0", VA = "0x185BE98F0", Slot = "6")]
	public void JBJJOJPLFBI(AEMMGGABEOL EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA200", Offset = "0x5BE9600", VA = "0x185BEA200", Slot = "7")]
	public void MAFJOMEFHJN(AEMMGGABEOL EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5BE87C0", Offset = "0x5BE7BC0", VA = "0x185BE87C0", Slot = "8")]
	public CCFPCJFIGFD BIGGBNMKOBJ(AEMMGGABEOL EAGPPNPHOBG, EDMBEKLJGEF HIDEHJGLNHO)
	{
		return default(CCFPCJFIGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8000", Offset = "0x5BE7400", VA = "0x185BE8000", Slot = "9")]
	public CCFPCJFIGFD AFCDJHGMDCG(AEMMGGABEOL EAGPPNPHOBG, EEPOLCFNAIN HIDEHJGLNHO)
	{
		return default(CCFPCJFIGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5BE94F0", Offset = "0x5BE88F0", VA = "0x185BE94F0", Slot = "11")]
	public void HKABDDJIEIH(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9270", Offset = "0x5BE8670", VA = "0x185BE9270", Slot = "10")]
	public void GFJDEGHAJNF(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5BE8CD0", Offset = "0x5BE80D0", VA = "0x185BE8CD0", Slot = "21")]
	public IEnumerable<Renderer> CKEKHEIBHOC(AEMMGGABEOL EAGPPNPHOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA620", Offset = "0x5BE9A20", VA = "0x185BEA620", Slot = "12")]
	public OBCECCCFMEH NIIIHBDBAGE(KKFDMDJFKHN HIDEHJGLNHO)
	{
		return default(OBCECCCFMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7F90", Offset = "0x5BE7390", VA = "0x185BE7F90", Slot = "14")]
	public void AABPPAPIHBE(OBCECCCFMEH JIMBDDGJENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9000", Offset = "0x5BE8400", VA = "0x185BE9000", Slot = "16")]
	public Task FNGJNOPEJOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA6A0", Offset = "0x5BE9AA0", VA = "0x185BEA6A0", Slot = "17")]
	public Task OBNBPGHOPKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9170", Offset = "0x5BE8570", VA = "0x185BE9170", Slot = "18")]
	[AsyncStateMachine(typeof(MCKLKJEKCFI))]
	public Task GDJFKMELIDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5BEA590", Offset = "0x5BE9990", VA = "0x185BEA590", Slot = "19")]
	public void NBNMNPCKFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9B70", Offset = "0x5BE8F70", VA = "0x185BE9B70", Slot = "13")]
	public void KJDMIGBDABO(OBCECCCFMEH JIMBDDGJENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5BE9BD0", Offset = "0x5BE8FD0", VA = "0x185BE9BD0", Slot = "20")]
	public NPEGMPBOOAE KMLFBOAIAJO(MCFKMCFIHNF OIDCDAJDFJD, IEnumerable<CCFPCJFIGFD> JEBHCCFODNJ, int GKKCIKGEPLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class FLBFKMGCKDE : PCCEPDBJLIP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct CDJDNPDNAOK : HMEMAGOJFNE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private NPEGMPBOOAE JPGFKCEECPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private JobHandle DNPFDFHMBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private IPDGCBOPAAO JPPFLCOAGAD;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCF20", Offset = "0x5BDC320", VA = "0x185BDCF20")]
		public CDJDNPDNAOK(NPEGMPBOOAE JPGFKCEECPG, JobHandle DNPFDFHMBNH, IPDGCBOPAAO JPPFLCOAGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xD7F230", Offset = "0xD7E630", VA = "0x180D7F230")]
		public bool JKIEOPECNID()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCEF0", Offset = "0x5BDC2F0", VA = "0x185BDCEF0", Slot = "4")]
		public NPEGMPBOOAE JHOFICMAMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCEA0", Offset = "0x5BDC2A0", VA = "0x185BDCEA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly EDMBEKLJGEF CNDFKFGJPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int[] DPCBOOMNINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float GEDFLJCGFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Hash128 BNMLFCCFNHO;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override BKKPIEMNJEM GNHBBJOLKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5BDF7F0", Offset = "0x5BDEBF0", VA = "0x185BDF7F0", Slot = "17")]
		get
		{
			return default(BKKPIEMNJEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private Vector3 JJEDHMEABEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5BE03A0", Offset = "0x5BDF7A0", VA = "0x185BE03A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected override Hash128 NPBEDCPFOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5BDF6C0", Offset = "0x5BDEAC0", VA = "0x185BDF6C0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1130", Offset = "0x5BE0530", VA = "0x185BE1130")]
	public FLBFKMGCKDE(ABDPNLBMMFB EAGPPNPHOBG, EDMBEKLJGEF HIDEHJGLNHO, bool LBJPACCGDBG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5BE0CC0", Offset = "0x5BE00C0", VA = "0x185BE0CC0", Slot = "16")]
	public override bool ODCMDEKLBJI(MCFKMCFIHNF EAGPPNPHOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5BE06F0", Offset = "0x5BDFAF0", VA = "0x185BE06F0", Slot = "18")]
	public override int JIBHMIACFCL(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5BE07A0", Offset = "0x5BDFBA0", VA = "0x185BE07A0", Slot = "19")]
	public override int KOEDABKINBN(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5BE0850", Offset = "0x5BDFC50", VA = "0x185BE0850")]
	private int MPAHCCHAHBP(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5BDEE80", Offset = "0x5BDE280", VA = "0x185BDEE80", Slot = "20")]
	public override void ANEAMEJCBJP(NIIJMGJLALG IFODHNBBPCL, BMEGHCJFONA BAGHMHPLLPP, int ODAGKBPNIOJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5BDF5F0", Offset = "0x5BDE9F0", VA = "0x185BDF5F0", Slot = "21")]
	public override MCFKMCFIHNF GEBNBHFHKBB()
	{
		return default(MCFKMCFIHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5BE0B00", Offset = "0x5BDFF00", VA = "0x185BE0B00", Slot = "23")]
	public override FBCMFMGBKIK NDLCJHHANCG()
	{
		return default(FBCMFMGBKIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5BDFBA0", Offset = "0x5BDEFA0", VA = "0x185BDFBA0", Slot = "24")]
	public override HMEMAGOJFNE IBNPFPCJGNC(NIIJMGJLALG IFODHNBBPCL, JobHandle DNPFDFHMBNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DBACKLLCEAI
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFDPFNMEKEK(DAHJELBGFBF OGILDIMGIOH, Renderer AIGKKLHNCDJ, int CDDJOLEBDFK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENPHGGEHKCB(Renderer AIGKKLHNCDJ, IBPLIPEDNEB PDOKPNENFJB, Vector3 EPOBGKIHBIB, Vector3 MBMICMLDMNM, Vector3 JGGCNAJLNID, float FBCCBNMFLFG, float KDBKDHJLLMJ, float BAIODDPBJNN = -1f, [Optional] Color? HAFGGBNGKBN, [Optional] IReadOnlyList<Camera> NDDHPAEIDIA);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFICCMMGMFI(Renderer AIGKKLHNCDJ, int CDDJOLEBDFK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LHNBHFNDOHE();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DEIJHFDEADA(int IHEDDHBOAHP, CCIJEMEMFDD OGILDIMGIOH, Renderer AIGKKLHNCDJ, int CDDJOLEBDFK);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OEKKLDHEPJP : KPFEKJBLOJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class KIEPLEIOMGL : global::LHLLIHNFOPK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5BE2B30", Offset = "0x5BE1F30", VA = "0x185BE2B30")]
		public KIEPLEIOMGL(string AMNLGEBHFHK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly DBACKLLCEAI BDNEAPBMBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly NALPKMPMJLA AJELMCOIOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MeshRenderer AGDIPLJKHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private KIEPLEIOMGL DEFKPHCPDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool DJBDMDCCFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MeshRenderer HOGADLLIOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private KIEPLEIOMGL PBMAHDJFEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool LLPPGMDPLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private MeshRenderer GEDIGJJDGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private KIEPLEIOMGL FLPPMAOCNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7DE200", Offset = "0x7DD600", VA = "0x1807DE200")]
	public OEKKLDHEPJP(DBACKLLCEAI NKKICFOCEEN, NALPKMPMJLA AJELMCOIOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4970", Offset = "0x5BE3D70", VA = "0x185BE4970", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5C60", Offset = "0x5BE5060", VA = "0x185BE5C60")]
	private void LLMIPHGDBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5FC0", Offset = "0x5BE53C0", VA = "0x185BE5FC0", Slot = "4")]
	public void NDFJBMIAHLH(AEMMGGABEOL EAGPPNPHOBG, CCIJEMEMFDD JIDALOJGNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5BE61C0", Offset = "0x5BE55C0", VA = "0x185BE61C0", Slot = "5")]
	public void NDFJBMIAHLH(CCFPCJFIGFD BDEOKFDPKJH, CCIJEMEMFDD JIDALOJGNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5BE63E0", Offset = "0x5BE57E0", VA = "0x185BE63E0", Slot = "6")]
	public void NLIJKBDKGLH(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4CB0", Offset = "0x5BE40B0", VA = "0x185BE4CB0", Slot = "7")]
	public void EPNHHMKDJOJ(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5570", Offset = "0x5BE4970", VA = "0x185BE5570", Slot = "8")]
	public void ICNIEOBKDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x157E370", Offset = "0x157D770", VA = "0x18157E370", Slot = "9")]
	public void AAGKCNJOJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4B40", Offset = "0x5BE3F40", VA = "0x185BE4B40", Slot = "10")]
	public void EECFLBNMFAD(CCIJEMEMFDD JIDALOJGNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4720", Offset = "0x5BE3B20", VA = "0x185BE4720", Slot = "11")]
	public void ADCKGOEFJNK(AEMMGGABEOL EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5BE43D0", Offset = "0x5BE37D0", VA = "0x185BE43D0", Slot = "12")]
	public void ADCKGOEFJNK(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5BE56F0", Offset = "0x5BE4AF0", VA = "0x185BE56F0", Slot = "13")]
	public void JPFNKEMMGIA(AEMMGGABEOL EAGPPNPHOBG, DAHJELBGFBF OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5BE58B0", Offset = "0x5BE4CB0", VA = "0x185BE58B0", Slot = "14")]
	public void JPFNKEMMGIA(CCFPCJFIGFD BDEOKFDPKJH, DAHJELBGFBF OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5EB0", Offset = "0x5BE52B0", VA = "0x185BE5EB0", Slot = "17")]
	public void MCMIFIHAAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5BE48D0", Offset = "0x5BE3CD0", VA = "0x185BE48D0", Slot = "15")]
	public void DENJCPBNOOA(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6510", Offset = "0x5BE5910", VA = "0x185BE6510", Slot = "16")]
	public void OEAKLCDIAOM(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xF73700", Offset = "0xF72B00", VA = "0x180F73700", Slot = "18")]
	public void BBCCDFGMBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5BE55B0", Offset = "0x5BE49B0", VA = "0x185BE55B0", Slot = "19")]
	public void IEAGJDFCFBH(DAHJELBGFBF OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5BE65A0", Offset = "0x5BE59A0", VA = "0x185BE65A0")]
	private void OPILGNBDLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5AA0", Offset = "0x5BE4EA0", VA = "0x185BE5AA0")]
	public void JPFNKEMMGIA(CCFPCJFIGFD BDEOKFDPKJH, DAHJELBGFBF OGILDIMGIOH, bool MEHJIICHAME = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5BE5EF0", Offset = "0x5BE52F0", VA = "0x185BE5EF0")]
	private void MFDPFNMEKEK(DAHJELBGFBF OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5BE51F0", Offset = "0x5BE45F0", VA = "0x185BE51F0", Slot = "20")]
	public void HPNNAKALNPD(AEMMGGABEOL EAGPPNPHOBG, Vector3 EPOBGKIHBIB, Vector3 MBMICMLDMNM, Vector3 JGGCNAJLNID, float FBCCBNMFLFG, float KDBKDHJLLMJ, IReadOnlyList<Camera> FCHJECAPLGB, IBPLIPEDNEB PDOKPNENFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5BE4DD0", Offset = "0x5BE41D0", VA = "0x185BE4DD0", Slot = "21")]
	public void HPNNAKALNPD(OBCECCCFMEH JIMBDDGJENJ, Vector3 EPOBGKIHBIB, Vector3 MBMICMLDMNM, Vector3 JGGCNAJLNID, float FBCCBNMFLFG, float KDBKDHJLLMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface APENNLFOGHB
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool JDLCMFKOIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material DGAHHMBDECL();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material CEFDCAPGPEM();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material EEBHNBCJGFA();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FEPBDIEICKN(IAKPGHMJHAJ KLOOAGEEOBN);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int PEHBILIBAKL(DPGOAOHOKGO LJJPBFANPHI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFDPBGAJJCA(GameObject NBNOMDAKOCG);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ICMLKDANPEA(GameObject NBNOMDAKOCG, bool CEJLKLDIMOG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JLOAPNIAODD
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static APENNLFOGHB NLKDOMNEDBE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool JDLCMFKOIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5BE2720", Offset = "0x5BE1B20", VA = "0x185BE2720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2A70", Offset = "0x5BE1E70", VA = "0x185BE2A70")]
	public static void OCLKIDKBNPA(APENNLFOGHB DABFPPMDLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2850", Offset = "0x5BE1C50", VA = "0x185BE2850")]
	public static Material DGAHHMBDECL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5BDA060", Offset = "0x5BD9460", VA = "0x185BDA060")]
	public static Material CEFDCAPGPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5BE28B0", Offset = "0x5BE1CB0", VA = "0x185BE28B0")]
	public static Material EEBHNBCJGFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2910", Offset = "0x5BE1D10", VA = "0x185BE2910")]
	public static int FEPBDIEICKN(IAKPGHMJHAJ KLOOAGEEOBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2AC0", Offset = "0x5BE1EC0", VA = "0x185BE2AC0")]
	public static int PEHBILIBAKL(DPGOAOHOKGO LJJPBFANPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2780", Offset = "0x5BE1B80", VA = "0x185BE2780")]
	public static void DFDPBGAJJCA(GameObject NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2980", Offset = "0x5BE1D80", VA = "0x185BE2980")]
	public static void ICMLKDANPEA(GameObject NBNOMDAKOCG, bool CEJLKLDIMOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class PCCEPDBJLIP : JCGKODJEJOH, DMLNGPJLIAD, CNMLLBBAIHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly ABDPNLBMMFB CMJKBCMDGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected Bounds DHJJLNPAKCB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Bounds AJBBFIKONDC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x12CF0C0", Offset = "0x12CE4C0", VA = "0x1812CF0C0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public virtual BKKPIEMNJEM GNHBBJOLKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6950", Offset = "0x5BE5D50", VA = "0x185BE6950", Slot = "17")]
		get
		{
			return default(BKKPIEMNJEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool INCBJMIGJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9A6950", Offset = "0x9A5D50", VA = "0x1809A6950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xCCB670", Offset = "0xCCAA70", VA = "0x180CCB670")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	protected abstract Hash128 NPBEDCPFOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int JFLOJCGHLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x73B4E0", Offset = "0x73A8E0", VA = "0x18073B4E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MPGELKOBGMM MPBLGMIJKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x735A20", Offset = "0x734E20", VA = "0x180735A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool NFEOEBKMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xC2E040", Offset = "0xC2D440", VA = "0x180C2E040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	protected PCCEPDBJLIP(ABDPNLBMMFB EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5BE67F0", Offset = "0x5BE5BF0", VA = "0x185BE67F0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "16")]
	public virtual bool ODCMDEKLBJI(MCFKMCFIHNF EAGPPNPHOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int JIBHMIACFCL(NIIJMGJLALG IFODHNBBPCL);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int KOEDABKINBN(NIIJMGJLALG IFODHNBBPCL);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void ANEAMEJCBJP(NIIJMGJLALG IFODHNBBPCL, BMEGHCJFONA BAGHMHPLLPP, int ODAGKBPNIOJ = -1);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract MCFKMCFIHNF GEBNBHFHKBB();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6920", Offset = "0x5BE5D20", VA = "0x185BE6920", Slot = "11")]
	public Hash128 EMELOGNNMBA(int IFODHNBBPCL)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract FBCMFMGBKIK NDLCJHHANCG();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract HMEMAGOJFNE IBNPFPCJGNC(NIIJMGJLALG IFODHNBBPCL, JobHandle DNPFDFHMBNH);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5BE69E0", Offset = "0x5BE5DE0", VA = "0x185BE69E0", Slot = "10")]
	public HMEMAGOJFNE KMLFBOAIAJO(int IFODHNBBPCL)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5BEACC0", Offset = "0x5BEA0C0", VA = "0x185BEACC0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum LIOGEJPAGPB
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class IFCHPNOJIPA
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MKIIEDBCPEE : IEnumerable<IIKDDAJEPIJ>, IEnumerable, IEnumerator<IIKDDAJEPIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private IIKDDAJEPIJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private IIKDDAJEPIJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
		[DebuggerHidden]
		public MKIIEDBCPEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3650", Offset = "0x5BE2A50", VA = "0x185BE3650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE37C0", Offset = "0x5BE2BC0", VA = "0x185BE37C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3730", Offset = "0x5BE2B30", VA = "0x185BE3730", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IIKDDAJEPIJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3730", Offset = "0x5BE2B30", VA = "0x185BE3730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public const int MMOCHEDBEEG = 3;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static IIKDDAJEPIJ[][] HBCCAOBNFKO;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static JMCGBINBECF COLDBOPAEGI;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static ShapeRendererConfig IDAPCDEPFOB;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static ComputeShader KCMFGEBCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1800", Offset = "0x5BE0C00", VA = "0x185BE1800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static SkinnedShapeRenderer BNKBMDOKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1A90", Offset = "0x5BE0E90", VA = "0x185BE1A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5BE20A0", Offset = "0x5BE14A0", VA = "0x185BE20A0")]
	public static Mesh KMOIBGKMPDM(LIOGEJPAGPB BCCBOCHBBFM, int IFODHNBBPCL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1ED0", Offset = "0x5BE12D0", VA = "0x185BE1ED0")]
	public static int GEMMKFJDGLI(LIOGEJPAGPB BCCBOCHBBFM, int IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2160", Offset = "0x5BE1560", VA = "0x185BE2160")]
	public static JMCGBINBECF NAPBIAFBODB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5BE22C0", Offset = "0x5BE16C0", VA = "0x185BE22C0")]
	[IteratorStateMachine(typeof(MKIIEDBCPEE))]
	private static IEnumerable<IIKDDAJEPIJ> PJPCBGLBNCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2320", Offset = "0x5BE1720", VA = "0x185BE2320")]
	public static IIKDDAJEPIJ PMAMBNKJLDF(LIOGEJPAGPB BCCBOCHBBFM, int IFODHNBBPCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1EB0", Offset = "0x5BE12B0", VA = "0x185BE1EB0")]
	public static bool ECGHDMGJKOB(this LIOGEJPAGPB BCCBOCHBBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1EF0", Offset = "0x5BE12F0", VA = "0x185BE1EF0")]
	public static void ILHAAAOKKHI(LIOGEJPAGPB BCCBOCHBBFM, float3 CFLLPKDFEIE, out JLJPFKBGHOI NDJMPHNGKHG, out float3 CMFEPJGICDI, out float JIIFGFOCCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1B00", Offset = "0x5BE0F00", VA = "0x185BE1B00")]
	public static void DLDIHCLDPLP(Vector3 CFLLPKDFEIE, LIOGEJPAGPB BCCBOCHBBFM, out Vector3 CMFEPJGICDI, out float JIIFGFOCCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1EE0", Offset = "0x5BE12E0", VA = "0x185BE1EE0")]
	[PAECCEJEKMD(KFMLDOLCGMJ.ExitingPlayMode, 0)]
	private static void GNLIBADCAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1870", Offset = "0x5BE0C70", VA = "0x185BE1870")]
	[PAECCEJEKMD(KFMLDOLCGMJ.ExitingPlayMode, 0)]
	private static void BHDAILOANOO()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DefaultMember("Item")]
	[JEGJCCBDMOE(OLCAJGBKOGB.ShapeRendering)]
	public class ShapeRendererManager : NHKEDADOGID, NALPKMPMJLA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly global::CLENJHDFPIE<AEMMGGABEOL, ABDPNLBMMFB> LJBLHPIOCMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly global::CLENJHDFPIE<CCFPCJFIGFD, PCCEPDBJLIP> JEBHCCFODNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly global::CLENJHDFPIE<OBCECCCFMEH, PLMONDBEGHN> HFLGNPHMLPL;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public ABDPNLBMMFB JNKMHBEEDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5BEB220", Offset = "0x5BEA620", VA = "0x185BEB220", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public PCCEPDBJLIP JNKMHBEEDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x5BEB1C0", Offset = "0x5BEA5C0", VA = "0x185BEB1C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public PLMONDBEGHN JNKMHBEEDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5BEB160", Offset = "0x5BEA560", VA = "0x185BEB160", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool ACODFOOKDPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x754690", Offset = "0x753A90", VA = "0x180754690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5BEBB30", Offset = "0x5BEAF30", VA = "0x185BEBB30")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB280", Offset = "0x5BEA680", VA = "0x185BEB280", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5BEAEA0", Offset = "0x5BEA2A0", VA = "0x185BEAEA0", Slot = "4")]
		public AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO)
		{
			return default(AEMMGGABEOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5BEAEA0", Offset = "0x5BEA2A0", VA = "0x185BEAEA0", Slot = "5")]
		public AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO, bool EPOMBBFBHFA)
		{
			return default(AEMMGGABEOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB4C0", Offset = "0x5BEA8C0", VA = "0x185BEB4C0", Slot = "6")]
		public void JBJJOJPLFBI(AEMMGGABEOL EAGPPNPHOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB980", Offset = "0x5BEAD80", VA = "0x185BEB980", Slot = "7")]
		public void MAFJOMEFHJN(AEMMGGABEOL EAGPPNPHOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5BEAFB0", Offset = "0x5BEA3B0", VA = "0x185BEAFB0", Slot = "8")]
		public CCFPCJFIGFD BIGGBNMKOBJ(AEMMGGABEOL EAGPPNPHOBG, EDMBEKLJGEF HIDEHJGLNHO)
		{
			return default(CCFPCJFIGFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5BEAD60", Offset = "0x5BEA160", VA = "0x185BEAD60", Slot = "9")]
		public CCFPCJFIGFD AFCDJHGMDCG(AEMMGGABEOL EAGPPNPHOBG, EEPOLCFNAIN HIDEHJGLNHO)
		{
			return default(CCFPCJFIGFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB430", Offset = "0x5BEA830", VA = "0x185BEB430", Slot = "11")]
		public void HKABDDJIEIH(CCFPCJFIGFD BDEOKFDPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB3D0", Offset = "0x5BEA7D0", VA = "0x185BEB3D0", Slot = "10")]
		public void GFJDEGHAJNF(CCFPCJFIGFD BDEOKFDPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB0F0", Offset = "0x5BEA4F0", VA = "0x185BEB0F0", Slot = "21")]
		public IEnumerable<Renderer> CKEKHEIBHOC(AEMMGGABEOL EAGPPNPHOBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5BEBA00", Offset = "0x5BEAE00", VA = "0x185BEBA00", Slot = "12")]
		public OBCECCCFMEH NIIIHBDBAGE(KKFDMDJFKHN HIDEHJGLNHO)
		{
			return default(OBCECCCFMEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5BEACF0", Offset = "0x5BEA0F0", VA = "0x185BEACF0", Slot = "14")]
		public void AABPPAPIHBE(OBCECCCFMEH JIMBDDGJENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB310", Offset = "0x5BEA710", VA = "0x185BEB310", Slot = "16")]
		public Task FNGJNOPEJOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5BEBA80", Offset = "0x5BEAE80", VA = "0x185BEBA80", Slot = "17")]
		public Task OBNBPGHOPKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB370", Offset = "0x5BEA770", VA = "0x185BEB370", Slot = "18")]
		public Task GDJFKMELIDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA43590", Offset = "0xA42990", VA = "0x180A43590", Slot = "19")]
		public void NBNMNPCKFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB520", Offset = "0x5BEA920", VA = "0x185BEB520", Slot = "13")]
		public void KJDMIGBDABO(OBCECCCFMEH JIMBDDGJENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB580", Offset = "0x5BEA980", VA = "0x185BEB580", Slot = "20")]
		public NPEGMPBOOAE KMLFBOAIAJO(MCFKMCFIHNF OIDCDAJDFJD, IEnumerable<CCFPCJFIGFD> JEBHCCFODNJ, int GKKCIKGEPLN)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PLMONDBEGHN : AGGMBKONOLH
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class APJIPFOCHBE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public PLMONDBEGHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
		[DebuggerHidden]
		public APJIPFOCHBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCC10", Offset = "0x5BDC010", VA = "0x185BDCC10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5BDC930", Offset = "0x5BDBD30", VA = "0x185BDC930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCC90", Offset = "0x5BDC090", VA = "0x185BDCC90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCBD0", Offset = "0x5BDBFD0", VA = "0x185BDCBD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCB30", Offset = "0x5BDBF30", VA = "0x185BDCB30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCB30", Offset = "0x5BDBF30", VA = "0x185BDCB30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly KKFDMDJFKHN OJPDDFBMLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly NALPKMPMJLA AJELMCOIOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NJAEGFGDOCD NKCDHKGKNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<AGDKNLPJALF> BBEGGGKFCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<AGDKNLPJALF> NGJGCHFEOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private GameObject PNPEJPLNDGM;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7C80", Offset = "0x5BE7080", VA = "0x185BE7C80")]
	public static PLMONDBEGHN KKNFODGJAPJ(KKFDMDJFKHN HIDEHJGLNHO, NALPKMPMJLA AJELMCOIOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7E90", Offset = "0x5BE7290", VA = "0x185BE7E90")]
	private PLMONDBEGHN(KKFDMDJFKHN HIDEHJGLNHO, NALPKMPMJLA AJELMCOIOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6A10", Offset = "0x5BE5E10", VA = "0x185BE6A10")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7C10", Offset = "0x5BE7010", VA = "0x185BE7C10")]
	[IteratorStateMachine(typeof(APJIPFOCHBE))]
	public IEnumerable<Renderer> JDDLFHBEJOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6EF0", Offset = "0x5BE62F0", VA = "0x185BE6EF0", Slot = "4")]
	public void GGFKJBEONBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5BE7DF0", Offset = "0x5BE71F0", VA = "0x185BE7DF0")]
	private void MIGLOFLBKHG(Vector3 OPJJJNDLBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5BE79D0", Offset = "0x5BE6DD0", VA = "0x185BE79D0")]
	public void HGAJENLLFEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AGDKNLPJALF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct OMFFPNHFIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public BMEGHCJFONA KCGMKFBHEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public MCFKMCFIHNF MANMHPNIEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int GEOEFLJLEBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NCKALCANICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AGDKNLPJALF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public NIIJMGJLALG lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public List<OMFFPNHFIAG> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public NPEGMPBOOAE combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NCKALCANICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3800", Offset = "0x5BE2C00", VA = "0x185BE3800")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3860", Offset = "0x5BE2C60", VA = "0x185BE3860")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE3890", Offset = "0x5BE2C90", VA = "0x185BE3890")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int[] MINPKKLEPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private EBAHHPDFIDA NGGDEGCOFIJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static Matrix4x4 DCFLMCONKLM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Mesh ENLEMOCKIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x734AE0", Offset = "0x733EE0", VA = "0x180734AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int HOEEEKMKBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x788950", Offset = "0x787D50", VA = "0x180788950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xBB01E0", Offset = "0xBAF5E0", VA = "0x180BB01E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC1C0", Offset = "0x5BDB5C0", VA = "0x185BDC1C0")]
	public void PIJIHENDHFL(List<MCFKMCFIHNF> KNMGHCJOCDB, Matrix4x4[] HJLHAFBPGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBA80", Offset = "0x5BDAE80", VA = "0x185BDBA80")]
	public static List<AGDKNLPJALF> IDIKGABNBEI(List<ABDPNLBMMFB> CIBDOJDBLMB, NIIJMGJLALG IFODHNBBPCL, Bounds ABPIDODICDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB610", Offset = "0x5BDAA10", VA = "0x185BDB610")]
	private JobHandle BNGJLFIBMOF(NPEGMPBOOAE KABOAHHLEEB, int LJACKKIGIBO, int FPCPBCCDOKI, NIIJMGJLALG IFODHNBBPCL, List<OMFFPNHFIAG> JCIHCFILIJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC0B0", Offset = "0x5BDB4B0", VA = "0x185BDC0B0")]
	private void KPGIDNPDMMF(List<OMFFPNHFIAG> JCIHCFILIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC520", Offset = "0x5BDB920", VA = "0x185BDC520")]
	private AGDKNLPJALF(List<OMFFPNHFIAG> JCIHCFILIJL, int LJACKKIGIBO, int FPCPBCCDOKI, NIIJMGJLALG IFODHNBBPCL, Bounds ABPIDODICDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5BDB9F0", Offset = "0x5BDADF0", VA = "0x185BDB9F0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private MaterialPropertyBlock KGAHKPNJNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private AGDKNLPJALF JPGFKCEECPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private List<MCFKMCFIHNF> FADBJBIPAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private RenderTexture KKMHENPKDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ComputeBuffer LNCDKMDCJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private ComputeShader FEFLNDAEJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Matrix4x4[] ELKPFJJFGNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int ANKJLGOBKGP;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public MeshRenderer KCNEKGOOEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x734AF0", Offset = "0x733EF0", VA = "0x180734AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int BEIPCNECDEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5BECBA0", Offset = "0x5BEBFA0", VA = "0x185BECBA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5BEBF10", Offset = "0x5BEB310", VA = "0x185BEBF10")]
		public static List<SkinnedShapeRenderer> Create(GameObject EAGPPNPHOBG, List<AGDKNLPJALF> JADOIBMLKFP, List<MCFKMCFIHNF> FADBJBIPAJF, Material NIFEJPCAIBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC390", Offset = "0x5BEB790", VA = "0x185BEC390")]
		public void Init(AGDKNLPJALF JPGFKCEECPG, List<MCFKMCFIHNF> FADBJBIPAJF, Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC930", Offset = "0x5BEBD30", VA = "0x185BEC930")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC880", Offset = "0x5BEBC80", VA = "0x185BEC880")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC840", Offset = "0x5BEBC40", VA = "0x185BEC840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC160", Offset = "0x5BEB560", VA = "0x185BEC160")]
		private void HMCPDFDAOJA(ScriptableRenderContext PKDAKJPDDGD, Camera[] FELGKJEKHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5BEC9E0", Offset = "0x5BEBDE0", VA = "0x185BEC9E0")]
		private void PIJIHENDHFL(CommandBuffer GDKGLNAPHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	internal class _RRAssemblyIndex : AAHOHGIJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5BED430", Offset = "0x5BEC830", VA = "0x185BED430", Slot = "4")]
		public sealed override void KLMOEJEAKPE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2ED0", Offset = "0x5BE22D0", VA = "0x185BE2ED0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5BE2B80", Offset = "0x5BE1F80", VA = "0x185BE2B80")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
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
