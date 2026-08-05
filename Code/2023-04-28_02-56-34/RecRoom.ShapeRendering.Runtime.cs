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
	[Cpp2IlInjected.Address(RVA = "0x5B6F5F0", Offset = "0x5B6DFF0", VA = "0x185B6F5F0")]
	public static bool OIJOBCGGACN(this IAKPGHMJHAJ KLOOAGEEOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B6F5E0", Offset = "0x5B6DFE0", VA = "0x185B6F5E0")]
	public static bool KCDEDIPBFAB(this IAKPGHMJHAJ KLOOAGEEOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5B6F5B0", Offset = "0x5B6DFB0", VA = "0x185B6F5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x731750", Offset = "0x730150", VA = "0x180731750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x75A800", Offset = "0x759200", VA = "0x18075A800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GEHGMGBLPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x731740", Offset = "0x730140", VA = "0x180731740", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x893820", Offset = "0x892220", VA = "0x180893820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float PDBNHMDMNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10B4100", Offset = "0x10B2B00", VA = "0x1810B4100", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x10B4110", Offset = "0x10B2B10", VA = "0x1810B4110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float IMDFICDNBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEC9CD0", Offset = "0xEC86D0", VA = "0x180EC9CD0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xECA070", Offset = "0xEC8A70", VA = "0x180ECA070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GMFGKBBJDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B765E0", Offset = "0x5B74FE0", VA = "0x185B765E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> KNPEMGEHHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B76680", Offset = "0x5B75080", VA = "0x185B76680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte GEMCPCOINGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5B762B0", Offset = "0x5B74CB0", VA = "0x185B762B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5B76810", Offset = "0x5B75210", VA = "0x185B76810")]
	public NJAEGFGDOCD(List<AGDKNLPJALF> HLNBNLOAJBM, List<AGDKNLPJALF> JPNDCIKFLHN, List<MCFKMCFIHNF> FADBJBIPAJF, Material NIFEJPCAIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B764D0", Offset = "0x5B74ED0", VA = "0x185B764D0")]
	private int JIBHMIACFCL(List<AGDKNLPJALF> JADOIBMLKFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B766C0", Offset = "0x5B750C0", VA = "0x185B766C0")]
	private void PLGNGGEPGPL(int NJDAOKFFHIG, bool KHJHBNPBBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B76300", Offset = "0x5B74D00", VA = "0x185B76300")]
	public void BCAOFCJJGKL(Vector3 OPJJJNDLBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B763A0", Offset = "0x5B74DA0", VA = "0x185B763A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B76640", Offset = "0x5B75040", VA = "0x185B76640")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
		[DebuggerHidden]
		public EBEGNOLLPOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B71560", Offset = "0x5B6FF60", VA = "0x185B71560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5B71030", Offset = "0x5B6FA30", VA = "0x185B71030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B71660", Offset = "0x5B70060", VA = "0x185B71660")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B716B0", Offset = "0x5B700B0", VA = "0x185B716B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B71700", Offset = "0x5B70100", VA = "0x185B71700")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B71520", Offset = "0x5B6FF20", VA = "0x185B71520", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5B71480", Offset = "0x5B6FE80", VA = "0x185B71480", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B71480", Offset = "0x5B6FE80", VA = "0x185B71480", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
		[DebuggerHidden]
		public GNENJBMJGOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B73E70", Offset = "0x5B72870", VA = "0x185B73E70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B73AB0", Offset = "0x5B724B0", VA = "0x185B73AB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5B73F50", Offset = "0x5B72950", VA = "0x185B73F50")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5B73FA0", Offset = "0x5B729A0", VA = "0x185B73FA0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B73E30", Offset = "0x5B72830", VA = "0x185B73E30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5B73D90", Offset = "0x5B72790", VA = "0x185B73D90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5B73D90", Offset = "0x5B72790", VA = "0x185B73D90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FOMLFFIMELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B6DC50", Offset = "0x5B6C650", VA = "0x185B6DC50", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MCFKMCFIHNF HOELEHEDINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B6DB80", Offset = "0x5B6C580", VA = "0x185B6DB80", Slot = "7")]
		get
		{
			return default(MCFKMCFIHNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> BLLOAKKEIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x731A20", Offset = "0x730420", VA = "0x180731A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B6DB60", Offset = "0x5B6C560", VA = "0x185B6DB60")]
	private bool JPFLIBEMBJA(PCCEPDBJLIP BDEOKFDPKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B6D740", Offset = "0x5B6C140", VA = "0x185B6D740")]
	private static bool GGGLDJOJDEM(PCCEPDBJLIP BDEOKFDPKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B6DC90", Offset = "0x5B6C690", VA = "0x185B6DC90")]
	public ABDPNLBMMFB(CNANLHPDAPN HIDEHJGLNHO, bool EPOMBBFBHFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B6CEB0", Offset = "0x5B6B8B0", VA = "0x185B6CEB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B6C550", Offset = "0x5B6AF50", VA = "0x185B6C550")]
	public void AGMLDLCGDGN(PCCEPDBJLIP BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5B6D0A0", Offset = "0x5B6BAA0", VA = "0x185B6D0A0")]
	public void FJEBMLODAAK(PCCEPDBJLIP BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5B6D1D0", Offset = "0x5B6BBD0", VA = "0x185B6D1D0", Slot = "4")]
	public void GGFKJBEONBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B6D760", Offset = "0x5B6C160", VA = "0x185B6D760")]
	public void HGAJENLLFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B6C7A0", Offset = "0x5B6B1A0", VA = "0x185B6C7A0")]
	private void BNNAJJFBMCE(List<PCCEPDBJLIP> JEBHCCFODNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B6C930", Offset = "0x5B6B330", VA = "0x185B6C930")]
	private static Material CEFDCAPGPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B6C700", Offset = "0x5B6B100", VA = "0x185B6C700")]
	private void BNNAJJFBMCE(PCCEPDBJLIP BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B6D9B0", Offset = "0x5B6C3B0", VA = "0x185B6D9B0")]
	private void HHEANFMLACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B6C990", Offset = "0x5B6B390", VA = "0x185B6C990")]
	public void DBNKPAODBAE(bool NNLNIAPLJCC, bool NJMHBMIAFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B6D010", Offset = "0x5B6BA10", VA = "0x185B6D010")]
	protected void ENEBHIHDNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B6DAF0", Offset = "0x5B6C4F0", VA = "0x185B6DAF0")]
	[IteratorStateMachine(typeof(EBEGNOLLPOC))]
	public IEnumerable<Renderer> JDDLFHBEJOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B6DA80", Offset = "0x5B6C480", VA = "0x185B6DA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B74070", Offset = "0x5B72A70", VA = "0x185B74070")]
		public IAGEPBPGEAA(NPEGMPBOOAE JPGFKCEECPG, JobHandle DNPFDFHMBNH, DADBNIGCJEC JPPFLCOAGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x920250", Offset = "0x91EC50", VA = "0x180920250")]
		public bool JKIEOPECNID()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5B74040", Offset = "0x5B72A40", VA = "0x185B74040", Slot = "4")]
		public NPEGMPBOOAE JHOFICMAMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5B73FF0", Offset = "0x5B729F0", VA = "0x185B73FF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B6FFF0", Offset = "0x5B6E9F0", VA = "0x185B6FFF0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5B70F80", Offset = "0x5B6F980", VA = "0x185B70F80")]
	public DHCCBIDOKJC(ABDPNLBMMFB EAGPPNPHOBG, EEPOLCFNAIN HIDEHJGLNHO, bool EPOMBBFBHFA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "16")]
	public override bool ODCMDEKLBJI(MCFKMCFIHNF EAGPPNPHOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5B709E0", Offset = "0x5B6F3E0", VA = "0x185B709E0", Slot = "18")]
	public override int JIBHMIACFCL(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5B70BD0", Offset = "0x5B6F5D0", VA = "0x185B70BD0", Slot = "19")]
	public override int KOEDABKINBN(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5B6F840", Offset = "0x5B6E240", VA = "0x185B6F840", Slot = "20")]
	public override void ANEAMEJCBJP(NIIJMGJLALG IFODHNBBPCL, BMEGHCJFONA BAGHMHPLLPP, int ODAGKBPNIOJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5B6FF20", Offset = "0x5B6E920", VA = "0x185B6FF20", Slot = "21")]
	public override MCFKMCFIHNF GEBNBHFHKBB()
	{
		return default(MCFKMCFIHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5B70DC0", Offset = "0x5B6F7C0", VA = "0x185B70DC0", Slot = "23")]
	public override FBCMFMGBKIK NDLCJHHANCG()
	{
		return default(FBCMFMGBKIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5B70120", Offset = "0x5B6EB20", VA = "0x185B70120", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A30", Offset = "0x7C1430", VA = "0x1807C2A30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C40C0", Offset = "0x8C2AC0", VA = "0x1808C40C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xE340B0", Offset = "0xE32AB0", VA = "0x180E340B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5B6DD80", Offset = "0x5B6C780", VA = "0x185B6DD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3094FD0", Offset = "0x30939D0", VA = "0x183094FD0", Slot = "8")]
	public bool Equals(AEMMGGABEOL MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xCCC090", Offset = "0xCCAA90", VA = "0x180CCC090")]
	public static bool BOBJELOEACN(AEMMGGABEOL HFOFADIOHHP, AEMMGGABEOL GFCGIJPPCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5021F10", Offset = "0x5020910", VA = "0x185021F10")]
	public static bool GPCPOEGFAHL(AEMMGGABEOL HFOFADIOHHP, AEMMGGABEOL GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5B6DDC0", Offset = "0x5B6C7C0", VA = "0x185B6DDC0", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5B6DE50", Offset = "0x5B6C850", VA = "0x185B6DE50", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A30", Offset = "0x7C1430", VA = "0x1807C2A30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C40C0", Offset = "0x8C2AC0", VA = "0x1808C40C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE340B0", Offset = "0xE32AB0", VA = "0x180E340B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F610", Offset = "0x5B6E010", VA = "0x185B6F610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3094FD0", Offset = "0x30939D0", VA = "0x183094FD0", Slot = "8")]
	public bool Equals(CCFPCJFIGFD MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xCCC090", Offset = "0xCCAA90", VA = "0x180CCC090")]
	public static bool BOBJELOEACN(CCFPCJFIGFD HFOFADIOHHP, CCFPCJFIGFD GFCGIJPPCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5021F10", Offset = "0x5020910", VA = "0x185021F10")]
	public static bool GPCPOEGFAHL(CCFPCJFIGFD HFOFADIOHHP, CCFPCJFIGFD GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5B6F650", Offset = "0x5B6E050", VA = "0x185B6F650", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5B6F6E0", Offset = "0x5B6E0E0", VA = "0x185B6F6E0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A30", Offset = "0x7C1430", VA = "0x1807C2A30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PELKNHEANOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C40C0", Offset = "0x8C2AC0", VA = "0x1808C40C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xE340B0", Offset = "0xE32AB0", VA = "0x180E340B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FAKGJGPBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5B76BD0", Offset = "0x5B755D0", VA = "0x185B76BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3094FD0", Offset = "0x30939D0", VA = "0x183094FD0", Slot = "8")]
	public bool Equals(OBCECCCFMEH MPHACEGLFIL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCCC090", Offset = "0xCCAA90", VA = "0x180CCC090")]
	public static bool BOBJELOEACN(OBCECCCFMEH HFOFADIOHHP, OBCECCCFMEH GFCGIJPPCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5021F10", Offset = "0x5020910", VA = "0x185021F10")]
	public static bool GPCPOEGFAHL(OBCECCCFMEH HFOFADIOHHP, OBCECCCFMEH GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5B76C10", Offset = "0x5B75610", VA = "0x185B76C10", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B75A80", Offset = "0x5B74480", VA = "0x185B75A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B7B6D0", Offset = "0x5B7A0D0", VA = "0x185B7B6D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PCCEPDBJLIP JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5B7B670", Offset = "0x5B7A070", VA = "0x185B7B670", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PLMONDBEGHN JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5B7B610", Offset = "0x5B7A010", VA = "0x185B7B610", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool ACODFOOKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE50", Offset = "0x7C9850", VA = "0x1807CAE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D0D0", Offset = "0x5B7BAD0", VA = "0x185B7D0D0")]
	public PPIAKPMHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5B7B730", Offset = "0x5B7A130", VA = "0x185B7B730", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B7B080", Offset = "0x5B79A80", VA = "0x185B7B080", Slot = "4")]
	public AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO)
	{
		return default(AEMMGGABEOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B7ADE0", Offset = "0x5B797E0", VA = "0x185B7ADE0", Slot = "5")]
	public AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO, bool EPOMBBFBHFA)
	{
		return default(AEMMGGABEOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B7C1C0", Offset = "0x5B7ABC0", VA = "0x185B7C1C0", Slot = "6")]
	public void JBJJOJPLFBI(AEMMGGABEOL EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CAD0", Offset = "0x5B7B4D0", VA = "0x185B7CAD0", Slot = "7")]
	public void MAFJOMEFHJN(AEMMGGABEOL EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B7B090", Offset = "0x5B79A90", VA = "0x185B7B090", Slot = "8")]
	public CCFPCJFIGFD BIGGBNMKOBJ(AEMMGGABEOL EAGPPNPHOBG, EDMBEKLJGEF HIDEHJGLNHO)
	{
		return default(CCFPCJFIGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B7A8D0", Offset = "0x5B792D0", VA = "0x185B7A8D0", Slot = "9")]
	public CCFPCJFIGFD AFCDJHGMDCG(AEMMGGABEOL EAGPPNPHOBG, EEPOLCFNAIN HIDEHJGLNHO)
	{
		return default(CCFPCJFIGFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5B7BDC0", Offset = "0x5B7A7C0", VA = "0x185B7BDC0", Slot = "11")]
	public void HKABDDJIEIH(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B7BB40", Offset = "0x5B7A540", VA = "0x185B7BB40", Slot = "10")]
	public void GFJDEGHAJNF(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5B7B5A0", Offset = "0x5B79FA0", VA = "0x185B7B5A0", Slot = "21")]
	public IEnumerable<Renderer> CKEKHEIBHOC(AEMMGGABEOL EAGPPNPHOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CEF0", Offset = "0x5B7B8F0", VA = "0x185B7CEF0", Slot = "12")]
	public OBCECCCFMEH NIIIHBDBAGE(KKFDMDJFKHN HIDEHJGLNHO)
	{
		return default(OBCECCCFMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5B7A860", Offset = "0x5B79260", VA = "0x185B7A860", Slot = "14")]
	public void AABPPAPIHBE(OBCECCCFMEH JIMBDDGJENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5B7B8D0", Offset = "0x5B7A2D0", VA = "0x185B7B8D0", Slot = "16")]
	public Task FNGJNOPEJOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CF70", Offset = "0x5B7B970", VA = "0x185B7CF70", Slot = "17")]
	public Task OBNBPGHOPKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5B7BA40", Offset = "0x5B7A440", VA = "0x185B7BA40", Slot = "18")]
	[AsyncStateMachine(typeof(MCKLKJEKCFI))]
	public Task GDJFKMELIDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CE60", Offset = "0x5B7B860", VA = "0x185B7CE60", Slot = "19")]
	public void NBNMNPCKFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B7C440", Offset = "0x5B7AE40", VA = "0x185B7C440", Slot = "13")]
	public void KJDMIGBDABO(OBCECCCFMEH JIMBDDGJENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5B7C4A0", Offset = "0x5B7AEA0", VA = "0x185B7C4A0", Slot = "20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B6F7F0", Offset = "0x5B6E1F0", VA = "0x185B6F7F0")]
		public CDJDNPDNAOK(NPEGMPBOOAE JPGFKCEECPG, JobHandle DNPFDFHMBNH, IPDGCBOPAAO JPPFLCOAGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x920250", Offset = "0x91EC50", VA = "0x180920250")]
		public bool JKIEOPECNID()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F7C0", Offset = "0x5B6E1C0", VA = "0x185B6F7C0", Slot = "4")]
		public NPEGMPBOOAE JHOFICMAMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F770", Offset = "0x5B6E170", VA = "0x185B6F770", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B720C0", Offset = "0x5B70AC0", VA = "0x185B720C0", Slot = "17")]
		get
		{
			return default(BKKPIEMNJEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private Vector3 JJEDHMEABEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5B72C70", Offset = "0x5B71670", VA = "0x185B72C70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected override Hash128 NPBEDCPFOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5B71F90", Offset = "0x5B70990", VA = "0x185B71F90", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5B73A00", Offset = "0x5B72400", VA = "0x185B73A00")]
	public FLBFKMGCKDE(ABDPNLBMMFB EAGPPNPHOBG, EDMBEKLJGEF HIDEHJGLNHO, bool LBJPACCGDBG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B73590", Offset = "0x5B71F90", VA = "0x185B73590", Slot = "16")]
	public override bool ODCMDEKLBJI(MCFKMCFIHNF EAGPPNPHOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B72FC0", Offset = "0x5B719C0", VA = "0x185B72FC0", Slot = "18")]
	public override int JIBHMIACFCL(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B73070", Offset = "0x5B71A70", VA = "0x185B73070", Slot = "19")]
	public override int KOEDABKINBN(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5B73120", Offset = "0x5B71B20", VA = "0x185B73120")]
	private int MPAHCCHAHBP(NIIJMGJLALG IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B71750", Offset = "0x5B70150", VA = "0x185B71750", Slot = "20")]
	public override void ANEAMEJCBJP(NIIJMGJLALG IFODHNBBPCL, BMEGHCJFONA BAGHMHPLLPP, int ODAGKBPNIOJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5B71EC0", Offset = "0x5B708C0", VA = "0x185B71EC0", Slot = "21")]
	public override MCFKMCFIHNF GEBNBHFHKBB()
	{
		return default(MCFKMCFIHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5B733D0", Offset = "0x5B71DD0", VA = "0x185B733D0", Slot = "23")]
	public override FBCMFMGBKIK NDLCJHHANCG()
	{
		return default(FBCMFMGBKIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5B72470", Offset = "0x5B70E70", VA = "0x185B72470", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B75400", Offset = "0x5B73E00", VA = "0x185B75400")]
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
	[Cpp2IlInjected.Address(RVA = "0x7B6A40", Offset = "0x7B5440", VA = "0x1807B6A40")]
	public OEKKLDHEPJP(DBACKLLCEAI NKKICFOCEEN, NALPKMPMJLA AJELMCOIOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5B77240", Offset = "0x5B75C40", VA = "0x185B77240", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B78530", Offset = "0x5B76F30", VA = "0x185B78530")]
	private void LLMIPHGDBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5B78890", Offset = "0x5B77290", VA = "0x185B78890", Slot = "4")]
	public void NDFJBMIAHLH(AEMMGGABEOL EAGPPNPHOBG, CCIJEMEMFDD JIDALOJGNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5B78A90", Offset = "0x5B77490", VA = "0x185B78A90", Slot = "5")]
	public void NDFJBMIAHLH(CCFPCJFIGFD BDEOKFDPKJH, CCIJEMEMFDD JIDALOJGNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5B78CB0", Offset = "0x5B776B0", VA = "0x185B78CB0", Slot = "6")]
	public void NLIJKBDKGLH(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5B77580", Offset = "0x5B75F80", VA = "0x185B77580", Slot = "7")]
	public void EPNHHMKDJOJ(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B77E40", Offset = "0x5B76840", VA = "0x185B77E40", Slot = "8")]
	public void ICNIEOBKDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1635DF0", Offset = "0x16347F0", VA = "0x181635DF0", Slot = "9")]
	public void AAGKCNJOJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5B77410", Offset = "0x5B75E10", VA = "0x185B77410", Slot = "10")]
	public void EECFLBNMFAD(CCIJEMEMFDD JIDALOJGNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B76FF0", Offset = "0x5B759F0", VA = "0x185B76FF0", Slot = "11")]
	public void ADCKGOEFJNK(AEMMGGABEOL EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5B76CA0", Offset = "0x5B756A0", VA = "0x185B76CA0", Slot = "12")]
	public void ADCKGOEFJNK(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B77FC0", Offset = "0x5B769C0", VA = "0x185B77FC0", Slot = "13")]
	public void JPFNKEMMGIA(AEMMGGABEOL EAGPPNPHOBG, DAHJELBGFBF OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5B78180", Offset = "0x5B76B80", VA = "0x185B78180", Slot = "14")]
	public void JPFNKEMMGIA(CCFPCJFIGFD BDEOKFDPKJH, DAHJELBGFBF OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B78780", Offset = "0x5B77180", VA = "0x185B78780", Slot = "17")]
	public void MCMIFIHAAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B771A0", Offset = "0x5B75BA0", VA = "0x185B771A0", Slot = "15")]
	public void DENJCPBNOOA(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B78DE0", Offset = "0x5B777E0", VA = "0x185B78DE0", Slot = "16")]
	public void OEAKLCDIAOM(CCFPCJFIGFD BDEOKFDPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1125AE0", Offset = "0x11244E0", VA = "0x181125AE0", Slot = "18")]
	public void BBCCDFGMBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5B77E80", Offset = "0x5B76880", VA = "0x185B77E80", Slot = "19")]
	public void IEAGJDFCFBH(DAHJELBGFBF OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5B78E70", Offset = "0x5B77870", VA = "0x185B78E70")]
	private void OPILGNBDLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5B78370", Offset = "0x5B76D70", VA = "0x185B78370")]
	public void JPFNKEMMGIA(CCFPCJFIGFD BDEOKFDPKJH, DAHJELBGFBF OGILDIMGIOH, bool MEHJIICHAME = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5B787C0", Offset = "0x5B771C0", VA = "0x185B787C0")]
	private void MFDPFNMEKEK(DAHJELBGFBF OGILDIMGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5B77AC0", Offset = "0x5B764C0", VA = "0x185B77AC0", Slot = "20")]
	public void HPNNAKALNPD(AEMMGGABEOL EAGPPNPHOBG, Vector3 EPOBGKIHBIB, Vector3 MBMICMLDMNM, Vector3 JGGCNAJLNID, float FBCCBNMFLFG, float KDBKDHJLLMJ, IReadOnlyList<Camera> FCHJECAPLGB, IBPLIPEDNEB PDOKPNENFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5B776A0", Offset = "0x5B760A0", VA = "0x185B776A0", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B74FF0", Offset = "0x5B739F0", VA = "0x185B74FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5B75340", Offset = "0x5B73D40", VA = "0x185B75340")]
	public static void OCLKIDKBNPA(APENNLFOGHB DABFPPMDLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5B75120", Offset = "0x5B73B20", VA = "0x185B75120")]
	public static Material DGAHHMBDECL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5B6C930", Offset = "0x5B6B330", VA = "0x185B6C930")]
	public static Material CEFDCAPGPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B75180", Offset = "0x5B73B80", VA = "0x185B75180")]
	public static Material EEBHNBCJGFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5B751E0", Offset = "0x5B73BE0", VA = "0x185B751E0")]
	public static int FEPBDIEICKN(IAKPGHMJHAJ KLOOAGEEOBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5B75390", Offset = "0x5B73D90", VA = "0x185B75390")]
	public static int PEHBILIBAKL(DPGOAOHOKGO LJJPBFANPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5B75050", Offset = "0x5B73A50", VA = "0x185B75050")]
	public static void DFDPBGAJJCA(GameObject NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5B75250", Offset = "0x5B73C50", VA = "0x185B75250")]
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
		[Cpp2IlInjected.Address(RVA = "0x11EC040", Offset = "0x11EAA40", VA = "0x1811EC040", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public virtual BKKPIEMNJEM GNHBBJOLKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5B79220", Offset = "0x5B77C20", VA = "0x185B79220", Slot = "17")]
		get
		{
			return default(BKKPIEMNJEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool INCBJMIGJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB90", Offset = "0xA4C590", VA = "0x180A4DB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC10", Offset = "0xA4C610", VA = "0x180A4DC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7374E0", Offset = "0x735EE0", VA = "0x1807374E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MPGELKOBGMM MPBLGMIJKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x731A20", Offset = "0x730420", VA = "0x180731A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool NFEOEBKMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7B1760", Offset = "0x7B0160", VA = "0x1807B1760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	protected PCCEPDBJLIP(ABDPNLBMMFB EAGPPNPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5B790C0", Offset = "0x5B77AC0", VA = "0x185B790C0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "16")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B791F0", Offset = "0x5B77BF0", VA = "0x185B791F0", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B792B0", Offset = "0x5B77CB0", VA = "0x185B792B0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B7D590", Offset = "0x5B7BF90", VA = "0x185B7D590")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
		[DebuggerHidden]
		public MKIIEDBCPEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5B75F20", Offset = "0x5B74920", VA = "0x185B75F20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5B76090", Offset = "0x5B74A90", VA = "0x185B76090", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5B76000", Offset = "0x5B74A00", VA = "0x185B76000", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IIKDDAJEPIJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5B76000", Offset = "0x5B74A00", VA = "0x185B76000", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B740D0", Offset = "0x5B72AD0", VA = "0x185B740D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static SkinnedShapeRenderer BNKBMDOKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5B74360", Offset = "0x5B72D60", VA = "0x185B74360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5B74970", Offset = "0x5B73370", VA = "0x185B74970")]
	public static Mesh KMOIBGKMPDM(LIOGEJPAGPB BCCBOCHBBFM, int IFODHNBBPCL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5B747A0", Offset = "0x5B731A0", VA = "0x185B747A0")]
	public static int GEMMKFJDGLI(LIOGEJPAGPB BCCBOCHBBFM, int IFODHNBBPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5B74A30", Offset = "0x5B73430", VA = "0x185B74A30")]
	public static JMCGBINBECF NAPBIAFBODB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5B74B90", Offset = "0x5B73590", VA = "0x185B74B90")]
	[IteratorStateMachine(typeof(MKIIEDBCPEE))]
	private static IEnumerable<IIKDDAJEPIJ> PJPCBGLBNCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5B74BF0", Offset = "0x5B735F0", VA = "0x185B74BF0")]
	public static IIKDDAJEPIJ PMAMBNKJLDF(LIOGEJPAGPB BCCBOCHBBFM, int IFODHNBBPCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5B74780", Offset = "0x5B73180", VA = "0x185B74780")]
	public static bool ECGHDMGJKOB(this LIOGEJPAGPB BCCBOCHBBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5B747C0", Offset = "0x5B731C0", VA = "0x185B747C0")]
	public static void ILHAAAOKKHI(LIOGEJPAGPB BCCBOCHBBFM, float3 CFLLPKDFEIE, out JLJPFKBGHOI NDJMPHNGKHG, out float3 CMFEPJGICDI, out float JIIFGFOCCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5B743D0", Offset = "0x5B72DD0", VA = "0x185B743D0")]
	public static void DLDIHCLDPLP(Vector3 CFLLPKDFEIE, LIOGEJPAGPB BCCBOCHBBFM, out Vector3 CMFEPJGICDI, out float JIIFGFOCCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5B747B0", Offset = "0x5B731B0", VA = "0x185B747B0")]
	[PAECCEJEKMD(KFMLDOLCGMJ.ExitingPlayMode, 0)]
	private static void GNLIBADCAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5B74140", Offset = "0x5B72B40", VA = "0x185B74140")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B7DAF0", Offset = "0x5B7C4F0", VA = "0x185B7DAF0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public PCCEPDBJLIP JNKMHBEEDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x5B7DA90", Offset = "0x5B7C490", VA = "0x185B7DA90", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public PLMONDBEGHN JNKMHBEEDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5B7DA30", Offset = "0x5B7C430", VA = "0x185B7DA30", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool ACODFOOKDPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x7CAE50", Offset = "0x7C9850", VA = "0x1807CAE50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E400", Offset = "0x5B7CE00", VA = "0x185B7E400")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5B7DB50", Offset = "0x5B7C550", VA = "0x185B7DB50", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D770", Offset = "0x5B7C170", VA = "0x185B7D770", Slot = "4")]
		public AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO)
		{
			return default(AEMMGGABEOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D770", Offset = "0x5B7C170", VA = "0x185B7D770", Slot = "5")]
		public AEMMGGABEOL BCJOCMAKBBA(CNANLHPDAPN HIDEHJGLNHO, bool EPOMBBFBHFA)
		{
			return default(AEMMGGABEOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5B7DD90", Offset = "0x5B7C790", VA = "0x185B7DD90", Slot = "6")]
		public void JBJJOJPLFBI(AEMMGGABEOL EAGPPNPHOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E250", Offset = "0x5B7CC50", VA = "0x185B7E250", Slot = "7")]
		public void MAFJOMEFHJN(AEMMGGABEOL EAGPPNPHOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D880", Offset = "0x5B7C280", VA = "0x185B7D880", Slot = "8")]
		public CCFPCJFIGFD BIGGBNMKOBJ(AEMMGGABEOL EAGPPNPHOBG, EDMBEKLJGEF HIDEHJGLNHO)
		{
			return default(CCFPCJFIGFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D630", Offset = "0x5B7C030", VA = "0x185B7D630", Slot = "9")]
		public CCFPCJFIGFD AFCDJHGMDCG(AEMMGGABEOL EAGPPNPHOBG, EEPOLCFNAIN HIDEHJGLNHO)
		{
			return default(CCFPCJFIGFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5B7DD00", Offset = "0x5B7C700", VA = "0x185B7DD00", Slot = "11")]
		public void HKABDDJIEIH(CCFPCJFIGFD BDEOKFDPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5B7DCA0", Offset = "0x5B7C6A0", VA = "0x185B7DCA0", Slot = "10")]
		public void GFJDEGHAJNF(CCFPCJFIGFD BDEOKFDPKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D9C0", Offset = "0x5B7C3C0", VA = "0x185B7D9C0", Slot = "21")]
		public IEnumerable<Renderer> CKEKHEIBHOC(AEMMGGABEOL EAGPPNPHOBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E2D0", Offset = "0x5B7CCD0", VA = "0x185B7E2D0", Slot = "12")]
		public OBCECCCFMEH NIIIHBDBAGE(KKFDMDJFKHN HIDEHJGLNHO)
		{
			return default(OBCECCCFMEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D5C0", Offset = "0x5B7BFC0", VA = "0x185B7D5C0", Slot = "14")]
		public void AABPPAPIHBE(OBCECCCFMEH JIMBDDGJENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5B7DBE0", Offset = "0x5B7C5E0", VA = "0x185B7DBE0", Slot = "16")]
		public Task FNGJNOPEJOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E350", Offset = "0x5B7CD50", VA = "0x185B7E350", Slot = "17")]
		public Task OBNBPGHOPKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5B7DC40", Offset = "0x5B7C640", VA = "0x185B7DC40", Slot = "18")]
		public Task GDJFKMELIDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x28788F0", Offset = "0x28772F0", VA = "0x1828788F0", Slot = "19")]
		public void NBNMNPCKFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5B7DDF0", Offset = "0x5B7C7F0", VA = "0x185B7DDF0", Slot = "13")]
		public void KJDMIGBDABO(OBCECCCFMEH JIMBDDGJENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5B7DE50", Offset = "0x5B7C850", VA = "0x185B7DE50", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
		[DebuggerHidden]
		public APJIPFOCHBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F4E0", Offset = "0x5B6DEE0", VA = "0x185B6F4E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F200", Offset = "0x5B6DC00", VA = "0x185B6F200", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F560", Offset = "0x5B6DF60", VA = "0x185B6F560")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F4A0", Offset = "0x5B6DEA0", VA = "0x185B6F4A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F400", Offset = "0x5B6DE00", VA = "0x185B6F400", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5B6F400", Offset = "0x5B6DE00", VA = "0x185B6F400", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5B7A550", Offset = "0x5B78F50", VA = "0x185B7A550")]
	public static PLMONDBEGHN KKNFODGJAPJ(KKFDMDJFKHN HIDEHJGLNHO, NALPKMPMJLA AJELMCOIOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5B7A760", Offset = "0x5B79160", VA = "0x185B7A760")]
	private PLMONDBEGHN(KKFDMDJFKHN HIDEHJGLNHO, NALPKMPMJLA AJELMCOIOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5B792E0", Offset = "0x5B77CE0", VA = "0x185B792E0")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5B7A4E0", Offset = "0x5B78EE0", VA = "0x185B7A4E0")]
	[IteratorStateMachine(typeof(APJIPFOCHBE))]
	public IEnumerable<Renderer> JDDLFHBEJOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5B797C0", Offset = "0x5B781C0", VA = "0x185B797C0", Slot = "4")]
	public void GGFKJBEONBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5B7A6C0", Offset = "0x5B790C0", VA = "0x185B7A6C0")]
	private void MIGLOFLBKHG(Vector3 OPJJJNDLBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5B7A2A0", Offset = "0x5B78CA0", VA = "0x185B7A2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NCKALCANICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5B760D0", Offset = "0x5B74AD0", VA = "0x185B760D0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5B76130", Offset = "0x5B74B30", VA = "0x185B76130")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5B76160", Offset = "0x5B74B60", VA = "0x185B76160")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int HOEEEKMKBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F70", Offset = "0x7B3970", VA = "0x1807B4F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5B6EA90", Offset = "0x5B6D490", VA = "0x185B6EA90")]
	public void PIJIHENDHFL(List<MCFKMCFIHNF> KNMGHCJOCDB, Matrix4x4[] HJLHAFBPGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5B6E350", Offset = "0x5B6CD50", VA = "0x185B6E350")]
	public static List<AGDKNLPJALF> IDIKGABNBEI(List<ABDPNLBMMFB> CIBDOJDBLMB, NIIJMGJLALG IFODHNBBPCL, Bounds ABPIDODICDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5B6DEE0", Offset = "0x5B6C8E0", VA = "0x185B6DEE0")]
	private JobHandle BNGJLFIBMOF(NPEGMPBOOAE KABOAHHLEEB, int LJACKKIGIBO, int FPCPBCCDOKI, NIIJMGJLALG IFODHNBBPCL, List<OMFFPNHFIAG> JCIHCFILIJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5B6E980", Offset = "0x5B6D380", VA = "0x185B6E980")]
	private void KPGIDNPDMMF(List<OMFFPNHFIAG> JCIHCFILIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5B6EDF0", Offset = "0x5B6D7F0", VA = "0x185B6EDF0")]
	private AGDKNLPJALF(List<OMFFPNHFIAG> JCIHCFILIJL, int LJACKKIGIBO, int FPCPBCCDOKI, NIIJMGJLALG IFODHNBBPCL, Bounds ABPIDODICDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5B6E2C0", Offset = "0x5B6CCC0", VA = "0x185B6E2C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int BEIPCNECDEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5B7F470", Offset = "0x5B7DE70", VA = "0x185B7F470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E7E0", Offset = "0x5B7D1E0", VA = "0x185B7E7E0")]
		public static List<SkinnedShapeRenderer> Create(GameObject EAGPPNPHOBG, List<AGDKNLPJALF> JADOIBMLKFP, List<MCFKMCFIHNF> FADBJBIPAJF, Material NIFEJPCAIBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EC60", Offset = "0x5B7D660", VA = "0x185B7EC60")]
		public void Init(AGDKNLPJALF JPGFKCEECPG, List<MCFKMCFIHNF> FADBJBIPAJF, Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F200", Offset = "0x5B7DC00", VA = "0x185B7F200")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F150", Offset = "0x5B7DB50", VA = "0x185B7F150")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F110", Offset = "0x5B7DB10", VA = "0x185B7F110")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EA30", Offset = "0x5B7D430", VA = "0x185B7EA30")]
		private void HMCPDFDAOJA(ScriptableRenderContext PKDAKJPDDGD, Camera[] FELGKJEKHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F2B0", Offset = "0x5B7DCB0", VA = "0x185B7F2B0")]
		private void PIJIHENDHFL(CommandBuffer GDKGLNAPHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5B7FD00", Offset = "0x5B7E700", VA = "0x185B7FD00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5B757A0", Offset = "0x5B741A0", VA = "0x185B757A0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5B75450", Offset = "0x5B73E50", VA = "0x185B75450")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
