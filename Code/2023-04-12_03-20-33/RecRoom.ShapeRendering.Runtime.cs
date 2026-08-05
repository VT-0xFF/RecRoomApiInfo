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
public enum GEHJPLJJIIJ
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
public static class CJDPADDINLC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5946AD0", Offset = "0x5945ED0", VA = "0x185946AD0")]
	public static bool FHINNGDFICM(this GEHJPLJJIIJ GADEHMOHNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5946B20", Offset = "0x5945F20", VA = "0x185946B20")]
	public static bool NOADPNLPFEJ(this GEHJPLJJIIJ GADEHMOHNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5946AF0", Offset = "0x5945EF0", VA = "0x185946AF0")]
	public static bool HGPFHMGPGAI(this GEHJPLJJIIJ GADEHMOHNFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LIFEBPMLBGM
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
public enum PGIFNGPHDIN
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
public enum NIHKMKJOMNK
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
public enum DENHGLJDFAP
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
public class MJJNIIIDMAJ : OLGMJOKIAJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte HJMELJEIJKP = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte KIFEIPCOGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] JNGMOCAPEOI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ACNBCNJOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E0010", Offset = "0x6DF410", VA = "0x1806E0010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x729D10", Offset = "0x729110", VA = "0x180729D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KLCNGCDNFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x700D90", Offset = "0x700190", VA = "0x180700D90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x878CE0", Offset = "0x8780E0", VA = "0x180878CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GIPNMBGGGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10231D0", Offset = "0x10225D0", VA = "0x1810231D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x117D7B0", Offset = "0x117CBB0", VA = "0x18117D7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BBAJPOPMJJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF60EF0", Offset = "0xF602F0", VA = "0x180F60EF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF60BD0", Offset = "0xF5FFD0", VA = "0x180F60BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GNBPAPJBADD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x59529D0", Offset = "0x5951DD0", VA = "0x1859529D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> JICPIAGKFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5952670", Offset = "0x5951A70", VA = "0x185952670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777F00", VA = "0x180778B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte KOLEACKMKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5952B80", Offset = "0x5951F80", VA = "0x185952B80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5952BD0", Offset = "0x5951FD0", VA = "0x185952BD0")]
	public MJJNIIIDMAJ(List<CAMGNKHECIO> OOBJNEADOFL, List<CAMGNKHECIO> CODGCBJGODL, List<HLKOGFFGFGN> CLNKLEPCPON, Material HNKAKNCAJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5952820", Offset = "0x5951C20", VA = "0x185952820")]
	private int GNPNCFJLACI(List<CAMGNKHECIO> CLCHDMCMIOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5952A30", Offset = "0x5951E30", VA = "0x185952A30")]
	private void OKFFOJOHGIO(int JNLDFJHLKFO, bool HAAPPAEMABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5952930", Offset = "0x5951D30", VA = "0x185952930")]
	public void ICEEMLKLNFI(Vector3 OOBDECIHNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x59526F0", Offset = "0x5951AF0", VA = "0x1859526F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x59526B0", Offset = "0x5951AB0", VA = "0x1859526B0")]
	public void DBEJCBIIKNI(Transform CLNJJLNFKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FFNIPMGEGPF : POMJANPEGHD, HBLPNEIJBOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EGGFDPIMNKK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public FFNIPMGEGPF <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
		[DebuggerHidden]
		public EGGFDPIMNKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5947140", Offset = "0x5946540", VA = "0x185947140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5946C10", Offset = "0x5946010", VA = "0x185946C10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5947240", Offset = "0x5946640", VA = "0x185947240")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5947290", Offset = "0x5946690", VA = "0x185947290")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x59472E0", Offset = "0x59466E0", VA = "0x1859472E0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5947100", Offset = "0x5946500", VA = "0x185947100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5947060", Offset = "0x5946460", VA = "0x185947060", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5947060", Offset = "0x5946460", VA = "0x185947060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MDCDILDNBNB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public FFNIPMGEGPF <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
		[DebuggerHidden]
		public MDCDILDNBNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5950190", Offset = "0x594F590", VA = "0x185950190", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x594FDD0", Offset = "0x594F1D0", VA = "0x18594FDD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5950270", Offset = "0x594F670", VA = "0x185950270")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x59502C0", Offset = "0x594F6C0", VA = "0x1859502C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5950150", Offset = "0x594F550", VA = "0x185950150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x59500B0", Offset = "0x594F4B0", VA = "0x1859500B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x59500B0", Offset = "0x594F4B0", VA = "0x1859500B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly ELAEDNIFCMA NNKDJBCBKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<ACLPLDEBONK> IPEMAMFLJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> IMNDGKGFKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer EDJHGBGKAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool PHCNDOLCNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool NNKJMAFODII;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<IJAJBOLFHGD> LLHPJLNDBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JBMNFIBFKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x59473C0", Offset = "0x59467C0", VA = "0x1859473C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HLKOGFFGFGN FBFEEHFHDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x59485B0", Offset = "0x59479B0", VA = "0x1859485B0", Slot = "7")]
		get
		{
			return default(HLKOGFFGFGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> MNFMLCBDCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E7590", Offset = "0x6E6990", VA = "0x1806E7590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x59486F0", Offset = "0x5947AF0", VA = "0x1859486F0")]
	private bool MFJHDBLOLLF(ACLPLDEBONK HFGBNCJIMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5947400", Offset = "0x5946800", VA = "0x185947400")]
	private static bool BAFAMPDKGCE(ACLPLDEBONK HFGBNCJIMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5948A70", Offset = "0x5947E70", VA = "0x185948A70")]
	public FFNIPMGEGPF(ELAEDNIFCMA FNIHENPLJHK, bool GONMDIENIEH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5947AD0", Offset = "0x5946ED0", VA = "0x185947AD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5947C30", Offset = "0x5947030", VA = "0x185947C30")]
	public void GBJBCHALJOG(ACLPLDEBONK HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5948940", Offset = "0x5947D40", VA = "0x185948940")]
	public void PMMODKPOELK(ACLPLDEBONK HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5947560", Offset = "0x5946960", VA = "0x185947560", Slot = "4")]
	public void DAMGEILKFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5948300", Offset = "0x5947700", VA = "0x185948300")]
	public void HMNCABBCMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5948710", Offset = "0x5947B10", VA = "0x185948710")]
	private void OJGKNBFAEEB(List<ACLPLDEBONK> IPEMAMFLJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5948550", Offset = "0x5947950", VA = "0x185948550")]
	private static Material IKBDPMKEHMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x59488A0", Offset = "0x5947CA0", VA = "0x1859488A0")]
	private void OJGKNBFAEEB(ACLPLDEBONK HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5947490", Offset = "0x5946890", VA = "0x185947490")]
	private void CAJLLMFPEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5947DE0", Offset = "0x59471E0", VA = "0x185947DE0")]
	public void GEMDBLPHICO(bool ICHNEPEFFLA, bool EOILPBHOOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5947330", Offset = "0x5946730", VA = "0x185947330")]
	protected void AAFMMFOGLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5948680", Offset = "0x5947A80", VA = "0x185948680")]
	[IteratorStateMachine(typeof(EGGFDPIMNKK))]
	public IEnumerable<Renderer> KLKDFIALDEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5947420", Offset = "0x5946820", VA = "0x185947420")]
	[IteratorStateMachine(typeof(MDCDILDNBNB))]
	public IEnumerable<Renderer> BLNMGCCKJGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class LDEDOJBLOLC : ACLPLDEBONK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct COGHOKDPDBJ : MOKKGLPHAPO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LBEENDJFEOI DJAAGGDMNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JobHandle DGGOEPGELHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private AGKMKBDMBHH NLHFDNHDEJF;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5946BB0", Offset = "0x5945FB0", VA = "0x185946BB0")]
		public COGHOKDPDBJ(LBEENDJFEOI DJAAGGDMNFL, JobHandle DGGOEPGELHE, AGKMKBDMBHH NLHFDNHDEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9055B0", Offset = "0x9049B0", VA = "0x1809055B0")]
		public bool FAFBILBNMMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5946B80", Offset = "0x5945F80", VA = "0x185946B80", Slot = "4")]
		public LBEENDJFEOI OIEKBFPKDBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5946B30", Offset = "0x5945F30", VA = "0x185946B30", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly LACGNLCHJJL JNHMBGEGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private float DEPCMMBCIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Hash128 LONJPLPHKDN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 IGJKPGCCDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x594E590", Offset = "0x594D990", VA = "0x18594E590", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x594FCD0", Offset = "0x594F0D0", VA = "0x18594FCD0")]
	public LDEDOJBLOLC(FFNIPMGEGPF IGJDJDNFANI, LACGNLCHJJL FNIHENPLJHK, bool GONMDIENIEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "16")]
	public override bool FDAMMJCFJOF(HLKOGFFGFGN IGJDJDNFANI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x594FAE0", Offset = "0x594EEE0", VA = "0x18594FAE0", Slot = "18")]
	public override int GNPNCFJLACI(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x594F8F0", Offset = "0x594ECF0", VA = "0x18594F8F0", Slot = "19")]
	public override int GCFHCEFELMM(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x594E6C0", Offset = "0x594DAC0", VA = "0x18594E6C0", Slot = "20")]
	public override void DLEFPBHFNPN(DLGNEFKOMDA LBEEDONFEAE, GACEEINPOIK HLLJMPAPIAH, int FOJFMKBPFED = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x594F820", Offset = "0x594EC20", VA = "0x18594F820", Slot = "21")]
	public override HLKOGFFGFGN FJEJMGNKJIP()
	{
		return default(HLKOGFFGFGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x594EDA0", Offset = "0x594E1A0", VA = "0x18594EDA0", Slot = "23")]
	public override FIMNOEPBBPE EMFKBOELNOL()
	{
		return default(FIMNOEPBBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x594EF60", Offset = "0x594E360", VA = "0x18594EF60", Slot = "24")]
	public override MOKKGLPHAPO FAFDFHLDFOO(DLGNEFKOMDA LBEEDONFEAE, JobHandle DGGOEPGELHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KDIMFJBMOJG : global::AOOPJGHLJBJ<KDIMFJBMOJG>, LGHBPHHHPFG, IEquatable<KDIMFJBMOJG>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int NOAKOLDJPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x791DB0", Offset = "0x7911B0", VA = "0x180791DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[CreateProperty]
	public int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8A9550", Offset = "0x8A8950", VA = "0x1808A9550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xE9C130", Offset = "0xE9B530", VA = "0x180E9C130", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x594E3F0", Offset = "0x594D7F0", VA = "0x18594E3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B10BD0", Offset = "0x2B0FFD0", VA = "0x182B10BD0", Slot = "8")]
	public bool Equals(KDIMFJBMOJG JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xCFEA50", Offset = "0xCFDE50", VA = "0x180CFEA50")]
	public static bool IIPILNNMHKL(KDIMFJBMOJG BECDKHGLGNB, KDIMFJBMOJG ICPOAGANOLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4D68750", Offset = "0x4D67B50", VA = "0x184D68750")]
	public static bool NCOOAABHIPD(KDIMFJBMOJG BECDKHGLGNB, KDIMFJBMOJG ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x594E360", Offset = "0x594D760", VA = "0x18594E360", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x594E430", Offset = "0x594D830", VA = "0x18594E430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum ANHOFNAEHNC
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
public interface ELAEDNIFCMA
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HLKOGFFGFGN AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	ANHOFNAEHNC LIHLNFLAEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AECAIJBDOBI : global::AOOPJGHLJBJ<AECAIJBDOBI>, LGHBPHHHPFG, IEquatable<AECAIJBDOBI>
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int NOAKOLDJPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x791DB0", Offset = "0x7911B0", VA = "0x180791DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	[CreateProperty]
	public int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9550", Offset = "0x8A8950", VA = "0x1808A9550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE9C130", Offset = "0xE9B530", VA = "0x180E9C130", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5942A90", Offset = "0x5941E90", VA = "0x185942A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B10BD0", Offset = "0x2B0FFD0", VA = "0x182B10BD0", Slot = "8")]
	public bool Equals(AECAIJBDOBI JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xCFEA50", Offset = "0xCFDE50", VA = "0x180CFEA50")]
	public static bool IIPILNNMHKL(AECAIJBDOBI BECDKHGLGNB, AECAIJBDOBI ICPOAGANOLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4D68750", Offset = "0x4D67B50", VA = "0x184D68750")]
	public static bool NCOOAABHIPD(AECAIJBDOBI BECDKHGLGNB, AECAIJBDOBI ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5942A00", Offset = "0x5941E00", VA = "0x185942A00", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5942AD0", Offset = "0x5941ED0", VA = "0x185942AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JBLFKPOOGNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KOHMKKALIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PIGAKPHKJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	HLKOGFFGFGN AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float IBKIALGEIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 KFCMKLAGJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	GEHJPLJJIIJ ODGJHNFGINO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	LIFEBPMLBGM CMEJPJHLMCK
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
public interface CIPELKEIKGK : JBLFKPOOGNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BBHGNFFOFHB NJIGIGDGMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LPKHKDOAELD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LACGNLCHJJL : JBLFKPOOGNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool CAPBFEBAFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NAKIIHGAIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float JKFJHIMLDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int MILIAONHMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool AJKKLOKNBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int MKGILPLIBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<KAEOLMOIADP> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HANGKKLNFME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNBKMFJBJKA(KDIMFJBMOJG IGJDJDNFANI, NIHKMKJOMNK FFHNNFOLDDG);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNBKMFJBJKA(AECAIJBDOBI HFGBNCJIMEI, NIHKMKJOMNK FFHNNFOLDDG);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKANEGKDEPI(AECAIJBDOBI HFGBNCJIMEI);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALDGDJOFOKK(AECAIJBDOBI HFGBNCJIMEI);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAAADLEGAKJ();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PJPLHEDGHFN();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DDFCNAMIABM(NIHKMKJOMNK HAOFNDAEGFJ);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PJFCBMDPNPE(KDIMFJBMOJG IGJDJDNFANI);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PJFCBMDPNPE(AECAIJBDOBI HFGBNCJIMEI);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HLEPLINHBEF(KDIMFJBMOJG IGJDJDNFANI, DENHGLJDFAP HAOFNDAEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HLEPLINHBEF(AECAIJBDOBI HFGBNCJIMEI, DENHGLJDFAP HAOFNDAEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OFDMBBFKECA(AECAIJBDOBI HFGBNCJIMEI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BACEOCBNLKA(AECAIJBDOBI HFGBNCJIMEI);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ANLBJFFMCKN();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LBCPLNALJCK();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KMMBBOLJCMM(DENHGLJDFAP HAOFNDAEGFJ);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IEPDBJJNEHO(KDIMFJBMOJG IGJDJDNFANI, Vector3 MPOMCABBDMI, Vector3 JIAPDKKGDDN, Vector3 FKNEJIBMHFI, float HAEAEEDLLLF, float AJPOCNACMOB, IReadOnlyList<Camera> GCHCPPAFEAB, PGIFNGPHDIN JHIFAPMIEAC);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IEPDBJJNEHO(PKNBFCKKMOO IMDJKDNBABB, Vector3 MPOMCABBDMI, Vector3 JIAPDKKGDDN, Vector3 FKNEJIBMHFI, float HAEAEEDLLLF, float AJPOCNACMOB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public interface NGJFOPLKFPM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FFNIPMGEGPF IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ACLPLDEBONK IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JIMPEPDLLIK IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JFLJOMMOEBE : NGJFOPLKFPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool KDAAMMKMNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK, bool NLINOMHOADL);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EAPJAGENDPM(KDIMFJBMOJG IGJDJDNFANI);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ACMEOJCFDDJ(KDIMFJBMOJG IGJDJDNFANI);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AECAIJBDOBI DDLGNJBFPIK(KDIMFJBMOJG IGJDJDNFANI, CIPELKEIKGK FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AECAIJBDOBI BCIAOMCEADH(KDIMFJBMOJG IGJDJDNFANI, LACGNLCHJJL FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IHJKMBHCMND(AECAIJBDOBI HFGBNCJIMEI);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KKDECPNBHFN(AECAIJBDOBI HFGBNCJIMEI);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PKNBFCKKMOO LAMEBPFAOKK(AONMLHHIGFG FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LELEBEAACJB(PKNBFCKKMOO IMDJKDNBABB);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PNNCHMIGICD(PKNBFCKKMOO IMDJKDNBABB);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task JIPOOBOGJJD();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task EJANCLILFPM();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task CMNLLOHPAMK();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CINJPNOALHF();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LBEENDJFEOI GAIFKCAIMAD(HLKOGFFGFGN PEJCHLIKJEE, IEnumerable<AECAIJBDOBI> IPEMAMFLJJH, int KCKCIDCKGID);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerable<Renderer> HAMFMGCCCFL(KDIMFJBMOJG IGJDJDNFANI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PKNBFCKKMOO : global::AOOPJGHLJBJ<PKNBFCKKMOO>, LGHBPHHHPFG, IEquatable<PKNBFCKKMOO>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int NOAKOLDJPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x791DB0", Offset = "0x7911B0", VA = "0x180791DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A9550", Offset = "0x8A8950", VA = "0x1808A9550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xE9C130", Offset = "0xE9B530", VA = "0x180E9C130", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x59533D0", Offset = "0x59527D0", VA = "0x1859533D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B10BD0", Offset = "0x2B0FFD0", VA = "0x182B10BD0", Slot = "8")]
	public bool Equals(PKNBFCKKMOO JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCFEA50", Offset = "0xCFDE50", VA = "0x180CFEA50")]
	public static bool IIPILNNMHKL(PKNBFCKKMOO BECDKHGLGNB, PKNBFCKKMOO ICPOAGANOLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D68750", Offset = "0x4D67B50", VA = "0x184D68750")]
	public static bool NCOOAABHIPD(PKNBFCKKMOO BECDKHGLGNB, PKNBFCKKMOO ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5953340", Offset = "0x5952740", VA = "0x185953340", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AONMLHHIGFG
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int GEBGFKEPJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Transform MOCOMJFEIME
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool ACOEOBDNDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KDIMFJBMOJG GetBone(int JBKJDKJIOFA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int JBKJDKJIOFA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class GEOMAKLIGIH : JFLJOMMOEBE, NGJFOPLKFPM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct BKHGIBKKKJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public GEOMAKLIGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5942B60", Offset = "0x5941F60", VA = "0x185942B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly global::FEPGPOIDFMK<KDIMFJBMOJG, FFNIPMGEGPF> DLNKIPKCMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly global::FEPGPOIDFMK<AECAIJBDOBI, ACLPLDEBONK> IPEMAMFLJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly global::FEPGPOIDFMK<PKNBFCKKMOO, JIMPEPDLLIK> FFPONPOEJDC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FFNIPMGEGPF IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x594A3E0", Offset = "0x59497E0", VA = "0x18594A3E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ACLPLDEBONK IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x594A320", Offset = "0x5949720", VA = "0x18594A320", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public JIMPEPDLLIK IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x594A380", Offset = "0x5949780", VA = "0x18594A380", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool KDAAMMKMNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x79A190", Offset = "0x799590", VA = "0x18079A190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x594C2F0", Offset = "0x594B6F0", VA = "0x18594C2F0")]
	public GEOMAKLIGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x594AAE0", Offset = "0x5949EE0", VA = "0x18594AAE0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x594C270", Offset = "0x594B670", VA = "0x18594C270", Slot = "4")]
	public KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK)
	{
		return default(KDIMFJBMOJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x594BFD0", Offset = "0x594B3D0", VA = "0x18594BFD0", Slot = "5")]
	public KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK, bool GONMDIENIEH)
	{
		return default(KDIMFJBMOJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x594AC80", Offset = "0x594A080", VA = "0x18594AC80", Slot = "6")]
	public void EAPJAGENDPM(KDIMFJBMOJG IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5949A80", Offset = "0x5948E80", VA = "0x185949A80", Slot = "7")]
	public void ACMEOJCFDDJ(KDIMFJBMOJG IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x594A5D0", Offset = "0x59499D0", VA = "0x18594A5D0", Slot = "8")]
	public AECAIJBDOBI DDLGNJBFPIK(KDIMFJBMOJG IGJDJDNFANI, CIPELKEIKGK FNIHENPLJHK)
	{
		return default(AECAIJBDOBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5949E10", Offset = "0x5949210", VA = "0x185949E10", Slot = "9")]
	public AECAIJBDOBI BCIAOMCEADH(KDIMFJBMOJG IGJDJDNFANI, LACGNLCHJJL FNIHENPLJHK)
	{
		return default(AECAIJBDOBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x594BAF0", Offset = "0x594AEF0", VA = "0x18594BAF0", Slot = "11")]
	public void KKDECPNBHFN(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x594B700", Offset = "0x594AB00", VA = "0x18594B700", Slot = "10")]
	public void IHJKMBHCMND(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x594B690", Offset = "0x594AA90", VA = "0x18594B690", Slot = "21")]
	public IEnumerable<Renderer> HAMFMGCCCFL(KDIMFJBMOJG IGJDJDNFANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x594BEF0", Offset = "0x594B2F0", VA = "0x18594BEF0", Slot = "12")]
	public PKNBFCKKMOO LAMEBPFAOKK(AONMLHHIGFG FNIHENPLJHK)
	{
		return default(PKNBFCKKMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x594C280", Offset = "0x594B680", VA = "0x18594C280", Slot = "14")]
	public void PNNCHMIGICD(PKNBFCKKMOO IMDJKDNBABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x594B980", Offset = "0x594AD80", VA = "0x18594B980", Slot = "16")]
	public Task JIPOOBOGJJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x594AF00", Offset = "0x594A300", VA = "0x18594AF00", Slot = "17")]
	public Task EJANCLILFPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x594A4D0", Offset = "0x59498D0", VA = "0x18594A4D0", Slot = "18")]
	[AsyncStateMachine(typeof(BKHGIBKKKJM))]
	public Task CMNLLOHPAMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x594A440", Offset = "0x5949840", VA = "0x18594A440", Slot = "19")]
	public void CINJPNOALHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x594BF70", Offset = "0x594B370", VA = "0x18594BF70", Slot = "13")]
	public void LELEBEAACJB(PKNBFCKKMOO IMDJKDNBABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x594B060", Offset = "0x594A460", VA = "0x18594B060", Slot = "20")]
	public LBEENDJFEOI GAIFKCAIMAD(HLKOGFFGFGN OFGIGKJMOGJ, IEnumerable<AECAIJBDOBI> IPEMAMFLJJH, int KCKCIDCKGID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class MGGICBCAGIH : ACLPLDEBONK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct LBEBBFIEPEJ : MOKKGLPHAPO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private LBEENDJFEOI DJAAGGDMNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private JobHandle DGGOEPGELHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private ODPGIILADDM NLHFDNHDEJF;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x594E540", Offset = "0x594D940", VA = "0x18594E540")]
		public LBEBBFIEPEJ(LBEENDJFEOI DJAAGGDMNFL, JobHandle DGGOEPGELHE, ODPGIILADDM NLHFDNHDEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9055B0", Offset = "0x9049B0", VA = "0x1809055B0")]
		public bool FAFBILBNMMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x594E510", Offset = "0x594D910", VA = "0x18594E510", Slot = "4")]
		public LBEENDJFEOI OIEKBFPKDBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x594E4C0", Offset = "0x594D8C0", VA = "0x18594E4C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly CIPELKEIKGK NALKPJHJPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int[] PKCOHCFPOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float DEPCMMBCIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Hash128 LONJPLPHKDN;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override JNGHICNLFNC GNPABEFCNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5952210", Offset = "0x5951610", VA = "0x185952210", Slot = "17")]
		get
		{
			return default(JNGHICNLFNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private Vector3 CLAKEACNPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5950440", Offset = "0x594F840", VA = "0x185950440")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected override Hash128 IGJKPGCCDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5950310", Offset = "0x594F710", VA = "0x185950310", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x59525C0", Offset = "0x59519C0", VA = "0x1859525C0")]
	public MGGICBCAGIH(FFNIPMGEGPF IGJDJDNFANI, CIPELKEIKGK FNIHENPLJHK, bool ANHJFFNJDLG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5951B70", Offset = "0x5950F70", VA = "0x185951B70", Slot = "16")]
	public override bool FDAMMJCFJOF(HLKOGFFGFGN IGJDJDNFANI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5952160", Offset = "0x5951560", VA = "0x185952160", Slot = "18")]
	public override int GNPNCFJLACI(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x59520B0", Offset = "0x59514B0", VA = "0x1859520B0", Slot = "19")]
	public override int GCFHCEFELMM(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5950F00", Offset = "0x5950300", VA = "0x185950F00")]
	private int DLKCDKNHHCJ(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5950790", Offset = "0x594FB90", VA = "0x185950790", Slot = "20")]
	public override void DLEFPBHFNPN(DLGNEFKOMDA LBEEDONFEAE, GACEEINPOIK HLLJMPAPIAH, int FOJFMKBPFED = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5951FE0", Offset = "0x59513E0", VA = "0x185951FE0", Slot = "21")]
	public override HLKOGFFGFGN FJEJMGNKJIP()
	{
		return default(HLKOGFFGFGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x59511B0", Offset = "0x59505B0", VA = "0x1859511B0", Slot = "23")]
	public override FIMNOEPBBPE EMFKBOELNOL()
	{
		return default(FIMNOEPBBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5951370", Offset = "0x5950770", VA = "0x185951370", Slot = "24")]
	public override MOKKGLPHAPO FAFDFHLDFOO(DLGNEFKOMDA LBEEDONFEAE, JobHandle DGGOEPGELHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ADFCLPEMJMA
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDECJDHMGDG(DENHGLJDFAP HAOFNDAEGFJ, Renderer CMNBAAPLLDK, int JKAIBHDJLEP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JODHOIILENC(Renderer CMNBAAPLLDK, PGIFNGPHDIN JHIFAPMIEAC, Vector3 MPOMCABBDMI, Vector3 JIAPDKKGDDN, Vector3 FKNEJIBMHFI, float HAEAEEDLLLF, float AJPOCNACMOB, float EBBHGKKICGB = -1f, [Optional] Color? LDFNLMPJEDN, [Optional] IReadOnlyList<Camera> AOAAONABAIP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DELOLDDBBPG(Renderer CMNBAAPLLDK, int JKAIBHDJLEP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CBOKANHFNHH();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBIGBMDBBJH(int LBHBGGMGNJH, NIHKMKJOMNK HAOFNDAEGFJ, Renderer CMNBAAPLLDK, int JKAIBHDJLEP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BNLNBAIPMAJ : HANGKKLNFME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class LGOGHCICCPI : global::JMLFLJGFGMO<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x594FD80", Offset = "0x594F180", VA = "0x18594FD80")]
		public LGOGHCICCPI(string GOENAEMJAON)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly ADFCLPEMJMA JJCNBNBOMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly NGJFOPLKFPM EHPFOOKIOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MeshRenderer FCIEGKOMMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private LGOGHCICCPI JDBGIJBAOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool CDMHGAEGDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MeshRenderer MHOKPJJHHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private LGOGHCICCPI PCJELJLPODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool FCHAIFPDOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private MeshRenderer KEHPKIGDEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private LGOGHCICCPI FDOPCJHKBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6E06E0", Offset = "0x6DFAE0", VA = "0x1806E06E0")]
	public BNLNBAIPMAJ(ADFCLPEMJMA OJJAECDAPMA, NGJFOPLKFPM EHPFOOKIOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5943940", Offset = "0x5942D40", VA = "0x185943940", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5943580", Offset = "0x5942980", VA = "0x185943580")]
	private void BPFHPKNLFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5944BE0", Offset = "0x5943FE0", VA = "0x185944BE0", Slot = "4")]
	public void JNBKMFJBJKA(KDIMFJBMOJG IGJDJDNFANI, NIHKMKJOMNK FFHNNFOLDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5944DE0", Offset = "0x59441E0", VA = "0x185944DE0", Slot = "5")]
	public void JNBKMFJBJKA(AECAIJBDOBI HFGBNCJIMEI, NIHKMKJOMNK FFHNNFOLDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5943DA0", Offset = "0x59431A0", VA = "0x185943DA0", Slot = "6")]
	public void GKANEGKDEPI(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5943390", Offset = "0x5942790", VA = "0x185943390", Slot = "7")]
	public void ALDGDJOFOKK(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5943B10", Offset = "0x5942F10", VA = "0x185943B10", Slot = "8")]
	public void EAAADLEGAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x14D62D0", Offset = "0x14D56D0", VA = "0x1814D62D0", Slot = "9")]
	public void PJPLHEDGHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x59437D0", Offset = "0x5942BD0", VA = "0x1859437D0", Slot = "10")]
	public void DDFCNAMIABM(NIHKMKJOMNK FFHNNFOLDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x59452B0", Offset = "0x59446B0", VA = "0x1859452B0", Slot = "11")]
	public void PJFCBMDPNPE(KDIMFJBMOJG IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5945460", Offset = "0x5944860", VA = "0x185945460", Slot = "12")]
	public void PJFCBMDPNPE(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5944280", Offset = "0x5943680", VA = "0x185944280", Slot = "13")]
	public void HLEPLINHBEF(KDIMFJBMOJG IGJDJDNFANI, DENHGLJDFAP HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5943ED0", Offset = "0x59432D0", VA = "0x185943ED0", Slot = "14")]
	public void HLEPLINHBEF(AECAIJBDOBI HFGBNCJIMEI, DENHGLJDFAP HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x59434B0", Offset = "0x59428B0", VA = "0x1859434B0", Slot = "17")]
	public void ANLBJFFMCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5945140", Offset = "0x5944540", VA = "0x185945140", Slot = "15")]
	public void OFDMBBFKECA(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x59434F0", Offset = "0x59428F0", VA = "0x1859434F0", Slot = "16")]
	public void BACEOCBNLKA(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xFA8570", Offset = "0xFA7970", VA = "0x180FA8570", Slot = "18")]
	public void LBCPLNALJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5945000", Offset = "0x5944400", VA = "0x185945000", Slot = "19")]
	public void KMMBBOLJCMM(DENHGLJDFAP HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5943B50", Offset = "0x5942F50", VA = "0x185943B50")]
	private void FDNPMKOOHII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x59440C0", Offset = "0x59434C0", VA = "0x1859440C0")]
	public void HLEPLINHBEF(AECAIJBDOBI HFGBNCJIMEI, DENHGLJDFAP HAOFNDAEGFJ, bool LLGDFIIONLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x59451E0", Offset = "0x59445E0", VA = "0x1859451E0")]
	private void PDECJDHMGDG(DENHGLJDFAP HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5944440", Offset = "0x5943840", VA = "0x185944440", Slot = "20")]
	public void IEPDBJJNEHO(KDIMFJBMOJG IGJDJDNFANI, Vector3 MPOMCABBDMI, Vector3 JIAPDKKGDDN, Vector3 FKNEJIBMHFI, float HAEAEEDLLLF, float AJPOCNACMOB, IReadOnlyList<Camera> GCHCPPAFEAB, PGIFNGPHDIN JHIFAPMIEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x59447C0", Offset = "0x5943BC0", VA = "0x1859447C0", Slot = "21")]
	public void IEPDBJJNEHO(PKNBFCKKMOO IMDJKDNBABB, Vector3 MPOMCABBDMI, Vector3 JIAPDKKGDDN, Vector3 FKNEJIBMHFI, float HAEAEEDLLLF, float AJPOCNACMOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CCHKAAINLDC
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool JMJMFGCEOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material EJDMIBFDJMF();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material IKBDPMKEHMM();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material JNGHGNGGAOH();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JJCBOPBJLHH(GEHJPLJJIIJ GADEHMOHNFM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HFGHFIOLEEO(LIFEBPMLBGM EAOMHFMIJAP);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLBNBHDJCPI(GameObject AELIHOPICED);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDIHFGJGIMN(GameObject AELIHOPICED, bool KGCHFPOPKKP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PNHLDOMDKCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static CCHKAAINLDC DNGPHMONFKM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool JMJMFGCEOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x59536A0", Offset = "0x5952AA0", VA = "0x1859536A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x59537D0", Offset = "0x5952BD0", VA = "0x1859537D0")]
	public static void NCKILPFECMP(CCHKAAINLDC AICPIDJDJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5953500", Offset = "0x5952900", VA = "0x185953500")]
	public static Material EJDMIBFDJMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5948550", Offset = "0x5947950", VA = "0x185948550")]
	public static Material IKBDPMKEHMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5953640", Offset = "0x5952A40", VA = "0x185953640")]
	public static Material JNGHGNGGAOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x59535D0", Offset = "0x59529D0", VA = "0x1859535D0")]
	public static int JJCBOPBJLHH(GEHJPLJJIIJ GADEHMOHNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5953560", Offset = "0x5952960", VA = "0x185953560")]
	public static int HFGHFIOLEEO(LIFEBPMLBGM EAOMHFMIJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5953700", Offset = "0x5952B00", VA = "0x185953700")]
	public static void LLBNBHDJCPI(GameObject AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5953410", Offset = "0x5952810", VA = "0x185953410")]
	public static void DDIHFGJGIMN(GameObject AELIHOPICED, bool KGCHFPOPKKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class ACLPLDEBONK : EMOILPCBOLJ, IJAJBOLFHGD, HILPCGDKEDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly FFNIPMGEGPF IMFMPPONFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected Bounds BFKDFHCCFOI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Bounds ACKNLHMLPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x126FA20", Offset = "0x126EE20", VA = "0x18126FA20", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public virtual JNGHICNLFNC GNPABEFCNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5942940", Offset = "0x5941D40", VA = "0x185942940", Slot = "17")]
		get
		{
			return default(JNGHICNLFNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NNKJMAFODII
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6E0030", Offset = "0x6DF430", VA = "0x1806E0030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA4A830", Offset = "0xA49C30", VA = "0x180A4A830")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	protected abstract Hash128 IGJKPGCCDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int HOGEMLJIFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x706AA0", Offset = "0x705EA0", VA = "0x180706AA0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MENFDOBKHKO JFCJHIPKNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6E7590", Offset = "0x6E6990", VA = "0x1806E7590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool CCJCOIMELKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x780C20", Offset = "0x780020", VA = "0x180780C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
	protected ACLPLDEBONK(FFNIPMGEGPF IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x59427E0", Offset = "0x5941BE0", VA = "0x1859427E0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "16")]
	public virtual bool FDAMMJCFJOF(HLKOGFFGFGN IGJDJDNFANI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int GNPNCFJLACI(DLGNEFKOMDA LBEEDONFEAE);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int GCFHCEFELMM(DLGNEFKOMDA LBEEDONFEAE);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void DLEFPBHFNPN(DLGNEFKOMDA LBEEDONFEAE, GACEEINPOIK HLLJMPAPIAH, int FOJFMKBPFED = -1);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract HLKOGFFGFGN FJEJMGNKJIP();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x59429D0", Offset = "0x5941DD0", VA = "0x1859429D0", Slot = "11")]
	public Hash128 ONHOMDOEBIP(int LBEEDONFEAE)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract FIMNOEPBBPE EMFKBOELNOL();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract MOKKGLPHAPO FAFDFHLDFOO(DLGNEFKOMDA LBEEDONFEAE, JobHandle DGGOEPGELHE);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5942910", Offset = "0x5941D10", VA = "0x185942910", Slot = "10")]
	public MOKKGLPHAPO GAIFKCAIMAD(int LBEEDONFEAE)
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
		[Cpp2IlInjected.Address(RVA = "0x5953820", Offset = "0x5952C20", VA = "0x185953820")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum BBHGNFFOFHB
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
public static class GBHJMLMAPAM
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class BLELFEOJJMO : IEnumerable<KDLMMLCPHPD>, IEnumerable, IEnumerator<KDLMMLCPHPD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private KDLMMLCPHPD <>2__current;

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
		private KDLMMLCPHPD System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
		[DebuggerHidden]
		public BLELFEOJJMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5943000", Offset = "0x5942400", VA = "0x185943000", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5943170", Offset = "0x5942570", VA = "0x185943170", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x59430E0", Offset = "0x59424E0", VA = "0x1859430E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KDLMMLCPHPD> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x59430E0", Offset = "0x59424E0", VA = "0x1859430E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public const int FFPKBIGIDMJ = 3;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static KDLMMLCPHPD[][] GGDEJMBOCEK;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static FKIOOPNENIH BIPLKNPIBMM;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static ShapeRendererConfig HIHLEJGCABL;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static ComputeShader DPFCEPABHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5948DD0", Offset = "0x59481D0", VA = "0x185948DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static SkinnedShapeRenderer CIPPKGFGNEI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5949740", Offset = "0x5948B40", VA = "0x185949740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5948D10", Offset = "0x5948110", VA = "0x185948D10")]
	public static Mesh BLKDMOGCEHO(BBHGNFFOFHB KMPJOEAFDOL, int LBEEDONFEAE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5949730", Offset = "0x5948B30", VA = "0x185949730")]
	public static int NFDONAMLLPB(BBHGNFFOFHB KMPJOEAFDOL, int LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5949550", Offset = "0x5948950", VA = "0x185949550")]
	public static FKIOOPNENIH LFJNPNIAPOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x59496B0", Offset = "0x5948AB0", VA = "0x1859496B0")]
	[IteratorStateMachine(typeof(BLELFEOJJMO))]
	private static IEnumerable<KDLMMLCPHPD> LMLFFNJPOMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x59491F0", Offset = "0x59485F0", VA = "0x1859491F0")]
	public static KDLMMLCPHPD LBOMJLHBHHH(BBHGNFFOFHB KMPJOEAFDOL, int LBEEDONFEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5949710", Offset = "0x5948B10", VA = "0x185949710")]
	public static bool MKOKICHPNII(this BBHGNFFOFHB KMPJOEAFDOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5948B60", Offset = "0x5947F60", VA = "0x185948B60")]
	public static void ANFHOJELKPG(BBHGNFFOFHB KMPJOEAFDOL, float3 BBJPPBPGGNB, out DJHPKIOAIJN AKMHBBIHINH, out float3 OCBJFGHKJJM, out float OGPPFFDAKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5948E40", Offset = "0x5948240", VA = "0x185948E40")]
	public static void DOGAGBJBLEH(Vector3 BBJPPBPGGNB, BBHGNFFOFHB KMPJOEAFDOL, out Vector3 OCBJFGHKJJM, out float OGPPFFDAKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x59499D0", Offset = "0x5948DD0", VA = "0x1859499D0")]
	[DFDEPFOCOOG(GCCGOPEBDFE.ExitingPlayMode, 0)]
	private static void OMFIIBIAFOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x59497B0", Offset = "0x5948BB0", VA = "0x1859497B0")]
	[DFDEPFOCOOG(GCCGOPEBDFE.ExitingPlayMode, 0)]
	private static void OAJBHGANAMD()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DefaultMember("Item")]
	[OHGELDJCNJM(GGAOONGBEBH.ShapeRendering)]
	public class ShapeRendererManager : JFLJOMMOEBE, NGJFOPLKFPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly global::FEPGPOIDFMK<KDIMFJBMOJG, FFNIPMGEGPF> DLNKIPKCMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly global::FEPGPOIDFMK<AECAIJBDOBI, ACLPLDEBONK> IPEMAMFLJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly global::FEPGPOIDFMK<PKNBFCKKMOO, JIMPEPDLLIK> FFPONPOEJDC;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public FFNIPMGEGPF IHLOOLPGFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5953AD0", Offset = "0x5952ED0", VA = "0x185953AD0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public ACLPLDEBONK IHLOOLPGFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x5953A10", Offset = "0x5952E10", VA = "0x185953A10", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public JIMPEPDLLIK IHLOOLPGFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5953A70", Offset = "0x5952E70", VA = "0x185953A70", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool KDAAMMKMNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x79A190", Offset = "0x799590", VA = "0x18079A190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5954690", Offset = "0x5953A90", VA = "0x185954690")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5953CD0", Offset = "0x59530D0", VA = "0x185953CD0", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x59544C0", Offset = "0x59538C0", VA = "0x1859544C0", Slot = "4")]
		public KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK)
		{
			return default(KDIMFJBMOJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x59544C0", Offset = "0x59538C0", VA = "0x1859544C0", Slot = "5")]
		public KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK, bool GONMDIENIEH)
		{
			return default(KDIMFJBMOJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5953D60", Offset = "0x5953160", VA = "0x185953D60", Slot = "6")]
		public void EAPJAGENDPM(KDIMFJBMOJG IGJDJDNFANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5953850", Offset = "0x5952C50", VA = "0x185953850", Slot = "7")]
		public void ACMEOJCFDDJ(KDIMFJBMOJG IGJDJDNFANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5953B90", Offset = "0x5952F90", VA = "0x185953B90", Slot = "8")]
		public AECAIJBDOBI DDLGNJBFPIK(KDIMFJBMOJG IGJDJDNFANI, CIPELKEIKGK FNIHENPLJHK)
		{
			return default(AECAIJBDOBI);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x59538D0", Offset = "0x5952CD0", VA = "0x1859538D0", Slot = "9")]
		public AECAIJBDOBI BCIAOMCEADH(KDIMFJBMOJG IGJDJDNFANI, LACGNLCHJJL FNIHENPLJHK)
		{
			return default(AECAIJBDOBI);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5954350", Offset = "0x5953750", VA = "0x185954350", Slot = "11")]
		public void KKDECPNBHFN(AECAIJBDOBI HFGBNCJIMEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5954290", Offset = "0x5953690", VA = "0x185954290", Slot = "10")]
		public void IHJKMBHCMND(AECAIJBDOBI HFGBNCJIMEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5954220", Offset = "0x5953620", VA = "0x185954220", Slot = "21")]
		public IEnumerable<Renderer> HAMFMGCCCFL(KDIMFJBMOJG IGJDJDNFANI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x59543E0", Offset = "0x59537E0", VA = "0x1859543E0", Slot = "12")]
		public PKNBFCKKMOO LAMEBPFAOKK(AONMLHHIGFG FNIHENPLJHK)
		{
			return default(PKNBFCKKMOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x59545D0", Offset = "0x59539D0", VA = "0x1859545D0", Slot = "14")]
		public void PNNCHMIGICD(PKNBFCKKMOO IMDJKDNBABB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x59542F0", Offset = "0x59536F0", VA = "0x1859542F0", Slot = "16")]
		public Task JIPOOBOGJJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5953DC0", Offset = "0x59531C0", VA = "0x185953DC0", Slot = "17")]
		public Task EJANCLILFPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5953B30", Offset = "0x5952F30", VA = "0x185953B30", Slot = "18")]
		public Task CMNLLOHPAMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x300E730", Offset = "0x300DB30", VA = "0x18300E730", Slot = "19")]
		public void CINJPNOALHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5954460", Offset = "0x5953860", VA = "0x185954460", Slot = "13")]
		public void LELEBEAACJB(PKNBFCKKMOO IMDJKDNBABB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5953E20", Offset = "0x5953220", VA = "0x185953E20", Slot = "20")]
		public LBEENDJFEOI GAIFKCAIMAD(HLKOGFFGFGN OFGIGKJMOGJ, IEnumerable<AECAIJBDOBI> IPEMAMFLJJH, int KCKCIDCKGID)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JIMPEPDLLIK : POMJANPEGHD
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class NAOOHCBFBNJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JIMPEPDLLIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
		[DebuggerHidden]
		public NAOOHCBFBNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5953270", Offset = "0x5952670", VA = "0x185953270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5952F90", Offset = "0x5952390", VA = "0x185952F90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x59532F0", Offset = "0x59526F0", VA = "0x1859532F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5953230", Offset = "0x5952630", VA = "0x185953230", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5953190", Offset = "0x5952590", VA = "0x185953190", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5953190", Offset = "0x5952590", VA = "0x185953190", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly AONMLHHIGFG LLENJGJGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly NGJFOPLKFPM EHPFOOKIOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private MJJNIIIDMAJ DKEIPINHOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<CAMGNKHECIO> IAAKPKFMFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<CAMGNKHECIO> HPIDOPACDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private GameObject LKHGANKFHKC;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x594E0F0", Offset = "0x594D4F0", VA = "0x18594E0F0")]
	public static JIMPEPDLLIK MCBKIOCFNPP(AONMLHHIGFG FNIHENPLJHK, NGJFOPLKFPM EHPFOOKIOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x594E260", Offset = "0x594D660", VA = "0x18594E260")]
	private JIMPEPDLLIK(AONMLHHIGFG FNIHENPLJHK, NGJFOPLKFPM EHPFOOKIOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x594DBA0", Offset = "0x594CFA0", VA = "0x18594DBA0")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x594E080", Offset = "0x594D480", VA = "0x18594E080")]
	[IteratorStateMachine(typeof(NAOOHCBFBNJ))]
	public IEnumerable<Renderer> KLKDFIALDEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x594CDE0", Offset = "0x594C1E0", VA = "0x18594CDE0", Slot = "4")]
	public void DAMGEILKFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x594D8C0", Offset = "0x594CCC0", VA = "0x18594D8C0")]
	private void FHPMMOPBOON(Vector3 OOBDECIHNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x594D960", Offset = "0x594CD60", VA = "0x18594D960")]
	public void HMNCABBCMFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CAMGNKHECIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct BJIFKDHMEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public GACEEINPOIK AIDOOFHPFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public HLKOGFFGFGN BPMBKKGNKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int HBEJMIAMFDF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BMFEMBEKJJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CAMGNKHECIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public DLGNEFKOMDA lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public List<BJIFKDHMEFN> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public LBEENDJFEOI combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BMFEMBEKJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x59431B0", Offset = "0x59425B0", VA = "0x1859431B0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5943210", Offset = "0x5942610", VA = "0x185943210")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5943240", Offset = "0x5942640", VA = "0x185943240")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int[] NFEMMEENOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private KIKDJHEGGOO CJMAAJOFJEM;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static Matrix4x4 INKBGGNEMFJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Mesh PJGCALFHALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x700130", Offset = "0x6FF530", VA = "0x180700130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int ALELDOGNNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6E1BD0", Offset = "0x6E0FD0", VA = "0x1806E1BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x784430", Offset = "0x783830", VA = "0x180784430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5946360", Offset = "0x5945760", VA = "0x185946360")]
	public void KOLLDLLCBHK(List<HLKOGFFGFGN> EINMNGDELAN, Matrix4x4[] IJBEHHDOLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x59457B0", Offset = "0x5944BB0", VA = "0x1859457B0")]
	public static List<CAMGNKHECIO> BMDGCEOIEEG(List<FFNIPMGEGPF> FHFEAHAMIGB, DLGNEFKOMDA LBEEDONFEAE, Bounds BNIHLJDPCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5945F80", Offset = "0x5945380", VA = "0x185945F80")]
	private JobHandle HNPEDKJIIIN(LBEENDJFEOI LBHBHGBKKGM, int LDKDGLKIEBP, int HBPAJCFBAKB, DLGNEFKOMDA LBEEDONFEAE, List<BJIFKDHMEFN> MFGOJDNDOEH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5945DE0", Offset = "0x59451E0", VA = "0x185945DE0")]
	private void DNHCIBCJFLM(List<BJIFKDHMEFN> MFGOJDNDOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x59466C0", Offset = "0x5945AC0", VA = "0x1859466C0")]
	private CAMGNKHECIO(List<BJIFKDHMEFN> MFGOJDNDOEH, int LDKDGLKIEBP, int HBPAJCFBAKB, DLGNEFKOMDA LBEEDONFEAE, Bounds BNIHLJDPCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5945EF0", Offset = "0x59452F0", VA = "0x185945EF0", Slot = "4")]
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
		private MaterialPropertyBlock DBKDLBEJNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CAMGNKHECIO DJAAGGDMNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private List<HLKOGFFGFGN> CLNKLEPCPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private RenderTexture JKDNCGFJJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ComputeBuffer MFIMCHFKCLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private ComputeShader KGOGNDGCOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Matrix4x4[] ENBNKKECHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int ELEKMIBNJML;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public MeshRenderer ICPFCHPHDBA
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x700140", Offset = "0x6FF540", VA = "0x180700140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int GEBGFKEPJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5955700", Offset = "0x5954B00", VA = "0x185955700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5954A70", Offset = "0x5953E70", VA = "0x185954A70")]
		public static List<SkinnedShapeRenderer> Create(GameObject IGJDJDNFANI, List<CAMGNKHECIO> CLCHDMCMIOO, List<HLKOGFFGFGN> CLNKLEPCPON, Material HNKAKNCAJGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5954EF0", Offset = "0x59542F0", VA = "0x185954EF0")]
		public void Init(CAMGNKHECIO DJAAGGDMNFL, List<HLKOGFFGFGN> CLNKLEPCPON, Material HNKAKNCAJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5955650", Offset = "0x5954A50", VA = "0x185955650")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x59555A0", Offset = "0x59549A0", VA = "0x1859555A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5955560", Offset = "0x5954960", VA = "0x185955560")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5954CC0", Offset = "0x59540C0", VA = "0x185954CC0")]
		private void IADIDBIMGOD(ScriptableRenderContext MFEOJPNCOBA, Camera[] FIEDHCJIKNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x59553A0", Offset = "0x59547A0", VA = "0x1859553A0")]
		private void KOLLDLLCBHK(CommandBuffer FFABMGICEPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	internal class _RRAssemblyIndex : PLIGCBHMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5955F90", Offset = "0x5955390", VA = "0x185955F90", Slot = "4")]
		public sealed override void DOIEPELEGLE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x594C7B0", Offset = "0x594BBB0", VA = "0x18594C7B0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x594C8C0", Offset = "0x594BCC0", VA = "0x18594C8C0")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
