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
	[Cpp2IlInjected.Address(RVA = "0x583F6A0", Offset = "0x583E6A0", VA = "0x18583F6A0")]
	public static bool FHINNGDFICM(this GEHJPLJJIIJ GADEHMOHNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x583F6F0", Offset = "0x583E6F0", VA = "0x18583F6F0")]
	public static bool NOADPNLPFEJ(this GEHJPLJJIIJ GADEHMOHNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x583F6C0", Offset = "0x583E6C0", VA = "0x18583F6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF010", Offset = "0x6DE010", VA = "0x1806DF010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x728D10", Offset = "0x727D10", VA = "0x180728D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KLCNGCDNFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD90", Offset = "0x6FED90", VA = "0x1806FFD90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x877CE0", Offset = "0x876CE0", VA = "0x180877CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GIPNMBGGGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x107F8F0", Offset = "0x107E8F0", VA = "0x18107F8F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x14F30B0", Offset = "0x14F20B0", VA = "0x1814F30B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BBAJPOPMJJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xFDF9C0", Offset = "0xFDE9C0", VA = "0x180FDF9C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xFDF6A0", Offset = "0xFDE6A0", VA = "0x180FDF6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GNBPAPJBADD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x584B5A0", Offset = "0x584A5A0", VA = "0x18584B5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> JICPIAGKFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x584B240", Offset = "0x584A240", VA = "0x18584B240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte KOLEACKMKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x584B750", Offset = "0x584A750", VA = "0x18584B750", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x584B7A0", Offset = "0x584A7A0", VA = "0x18584B7A0")]
	public MJJNIIIDMAJ(List<CAMGNKHECIO> OOBJNEADOFL, List<CAMGNKHECIO> CODGCBJGODL, List<HLKOGFFGFGN> CLNKLEPCPON, Material HNKAKNCAJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x584B3F0", Offset = "0x584A3F0", VA = "0x18584B3F0")]
	private int GNPNCFJLACI(List<CAMGNKHECIO> CLCHDMCMIOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x584B600", Offset = "0x584A600", VA = "0x18584B600")]
	private void OKFFOJOHGIO(int JNLDFJHLKFO, bool HAAPPAEMABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x584B500", Offset = "0x584A500", VA = "0x18584B500")]
	public void ICEEMLKLNFI(Vector3 OOBDECIHNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x584B2C0", Offset = "0x584A2C0", VA = "0x18584B2C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x584B280", Offset = "0x584A280", VA = "0x18584B280")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
		[DebuggerHidden]
		public EGGFDPIMNKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x583FD10", Offset = "0x583ED10", VA = "0x18583FD10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x583F7E0", Offset = "0x583E7E0", VA = "0x18583F7E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x583FE10", Offset = "0x583EE10", VA = "0x18583FE10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x583FE60", Offset = "0x583EE60", VA = "0x18583FE60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x583FEB0", Offset = "0x583EEB0", VA = "0x18583FEB0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x583FCD0", Offset = "0x583ECD0", VA = "0x18583FCD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x583FC30", Offset = "0x583EC30", VA = "0x18583FC30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x583FC30", Offset = "0x583EC30", VA = "0x18583FC30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
		[DebuggerHidden]
		public MDCDILDNBNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5848D60", Offset = "0x5847D60", VA = "0x185848D60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x58489A0", Offset = "0x58479A0", VA = "0x1858489A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5848E40", Offset = "0x5847E40", VA = "0x185848E40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5848E90", Offset = "0x5847E90", VA = "0x185848E90")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5848D20", Offset = "0x5847D20", VA = "0x185848D20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5848C80", Offset = "0x5847C80", VA = "0x185848C80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5848C80", Offset = "0x5847C80", VA = "0x185848C80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JBMNFIBFKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x583FF90", Offset = "0x583EF90", VA = "0x18583FF90", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HLKOGFFGFGN FBFEEHFHDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5841180", Offset = "0x5840180", VA = "0x185841180", Slot = "7")]
		get
		{
			return default(HLKOGFFGFGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> MNFMLCBDCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E6590", Offset = "0x6E5590", VA = "0x1806E6590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x58412C0", Offset = "0x58402C0", VA = "0x1858412C0")]
	private bool MFJHDBLOLLF(ACLPLDEBONK HFGBNCJIMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x583FFD0", Offset = "0x583EFD0", VA = "0x18583FFD0")]
	private static bool BAFAMPDKGCE(ACLPLDEBONK HFGBNCJIMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5841640", Offset = "0x5840640", VA = "0x185841640")]
	public FFNIPMGEGPF(ELAEDNIFCMA FNIHENPLJHK, bool GONMDIENIEH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x58406A0", Offset = "0x583F6A0", VA = "0x1858406A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5840800", Offset = "0x583F800", VA = "0x185840800")]
	public void GBJBCHALJOG(ACLPLDEBONK HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5841510", Offset = "0x5840510", VA = "0x185841510")]
	public void PMMODKPOELK(ACLPLDEBONK HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5840130", Offset = "0x583F130", VA = "0x185840130", Slot = "4")]
	public void DAMGEILKFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5840ED0", Offset = "0x583FED0", VA = "0x185840ED0")]
	public void HMNCABBCMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x58412E0", Offset = "0x58402E0", VA = "0x1858412E0")]
	private void OJGKNBFAEEB(List<ACLPLDEBONK> IPEMAMFLJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5841120", Offset = "0x5840120", VA = "0x185841120")]
	private static Material IKBDPMKEHMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5841470", Offset = "0x5840470", VA = "0x185841470")]
	private void OJGKNBFAEEB(ACLPLDEBONK HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5840060", Offset = "0x583F060", VA = "0x185840060")]
	private void CAJLLMFPEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x58409B0", Offset = "0x583F9B0", VA = "0x1858409B0")]
	public void GEMDBLPHICO(bool ICHNEPEFFLA, bool EOILPBHOOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x583FF00", Offset = "0x583EF00", VA = "0x18583FF00")]
	protected void AAFMMFOGLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5841250", Offset = "0x5840250", VA = "0x185841250")]
	[IteratorStateMachine(typeof(EGGFDPIMNKK))]
	public IEnumerable<Renderer> KLKDFIALDEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x583FFF0", Offset = "0x583EFF0", VA = "0x18583FFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x583F780", Offset = "0x583E780", VA = "0x18583F780")]
		public COGHOKDPDBJ(LBEENDJFEOI DJAAGGDMNFL, JobHandle DGGOEPGELHE, AGKMKBDMBHH NLHFDNHDEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9045B0", Offset = "0x9035B0", VA = "0x1809045B0")]
		public bool FAFBILBNMMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x583F750", Offset = "0x583E750", VA = "0x18583F750", Slot = "4")]
		public LBEENDJFEOI OIEKBFPKDBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x583F700", Offset = "0x583E700", VA = "0x18583F700", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5847160", Offset = "0x5846160", VA = "0x185847160", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x58488A0", Offset = "0x58478A0", VA = "0x1858488A0")]
	public LDEDOJBLOLC(FFNIPMGEGPF IGJDJDNFANI, LACGNLCHJJL FNIHENPLJHK, bool GONMDIENIEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "16")]
	public override bool FDAMMJCFJOF(HLKOGFFGFGN IGJDJDNFANI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x58486B0", Offset = "0x58476B0", VA = "0x1858486B0", Slot = "18")]
	public override int GNPNCFJLACI(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x58484C0", Offset = "0x58474C0", VA = "0x1858484C0", Slot = "19")]
	public override int GCFHCEFELMM(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5847290", Offset = "0x5846290", VA = "0x185847290", Slot = "20")]
	public override void DLEFPBHFNPN(DLGNEFKOMDA LBEEDONFEAE, GACEEINPOIK HLLJMPAPIAH, int FOJFMKBPFED = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x58483F0", Offset = "0x58473F0", VA = "0x1858483F0", Slot = "21")]
	public override HLKOGFFGFGN FJEJMGNKJIP()
	{
		return default(HLKOGFFGFGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5847970", Offset = "0x5846970", VA = "0x185847970", Slot = "23")]
	public override FIMNOEPBBPE EMFKBOELNOL()
	{
		return default(FIMNOEPBBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5847B30", Offset = "0x5846B30", VA = "0x185847B30", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x790DB0", Offset = "0x78FDB0", VA = "0x180790DB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A8550", Offset = "0x8A7550", VA = "0x1808A8550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xE96F30", Offset = "0xE95F30", VA = "0x180E96F30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5846FC0", Offset = "0x5845FC0", VA = "0x185846FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A45540", Offset = "0x2A44540", VA = "0x182A45540", Slot = "8")]
	public bool Equals(KDIMFJBMOJG JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xCFDA50", Offset = "0xCFCA50", VA = "0x180CFDA50")]
	public static bool IIPILNNMHKL(KDIMFJBMOJG BECDKHGLGNB, KDIMFJBMOJG ICPOAGANOLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4D05B90", Offset = "0x4D04B90", VA = "0x184D05B90")]
	public static bool NCOOAABHIPD(KDIMFJBMOJG BECDKHGLGNB, KDIMFJBMOJG ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5846F30", Offset = "0x5845F30", VA = "0x185846F30", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5847000", Offset = "0x5846000", VA = "0x185847000", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x790DB0", Offset = "0x78FDB0", VA = "0x180790DB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A8550", Offset = "0x8A7550", VA = "0x1808A8550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE96F30", Offset = "0xE95F30", VA = "0x180E96F30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x583B660", Offset = "0x583A660", VA = "0x18583B660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A45540", Offset = "0x2A44540", VA = "0x182A45540", Slot = "8")]
	public bool Equals(AECAIJBDOBI JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xCFDA50", Offset = "0xCFCA50", VA = "0x180CFDA50")]
	public static bool IIPILNNMHKL(AECAIJBDOBI BECDKHGLGNB, AECAIJBDOBI ICPOAGANOLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4D05B90", Offset = "0x4D04B90", VA = "0x184D05B90")]
	public static bool NCOOAABHIPD(AECAIJBDOBI BECDKHGLGNB, AECAIJBDOBI ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x583B5D0", Offset = "0x583A5D0", VA = "0x18583B5D0", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x583B6A0", Offset = "0x583A6A0", VA = "0x18583B6A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x790DB0", Offset = "0x78FDB0", VA = "0x180790DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A8550", Offset = "0x8A7550", VA = "0x1808A8550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xE96F30", Offset = "0xE95F30", VA = "0x180E96F30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x584BFA0", Offset = "0x584AFA0", VA = "0x18584BFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A45540", Offset = "0x2A44540", VA = "0x182A45540", Slot = "8")]
	public bool Equals(PKNBFCKKMOO JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCFDA50", Offset = "0xCFCA50", VA = "0x180CFDA50")]
	public static bool IIPILNNMHKL(PKNBFCKKMOO BECDKHGLGNB, PKNBFCKKMOO ICPOAGANOLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4D05B90", Offset = "0x4D04B90", VA = "0x184D05B90")]
	public static bool NCOOAABHIPD(PKNBFCKKMOO BECDKHGLGNB, PKNBFCKKMOO ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x584BF10", Offset = "0x584AF10", VA = "0x18584BF10", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x583B730", Offset = "0x583A730", VA = "0x18583B730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5842FB0", Offset = "0x5841FB0", VA = "0x185842FB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ACLPLDEBONK IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5842EF0", Offset = "0x5841EF0", VA = "0x185842EF0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public JIMPEPDLLIK IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5842F50", Offset = "0x5841F50", VA = "0x185842F50", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool KDAAMMKMNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x799190", Offset = "0x798190", VA = "0x180799190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5844EC0", Offset = "0x5843EC0", VA = "0x185844EC0")]
	public GEOMAKLIGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x58436B0", Offset = "0x58426B0", VA = "0x1858436B0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5844E40", Offset = "0x5843E40", VA = "0x185844E40", Slot = "4")]
	public KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK)
	{
		return default(KDIMFJBMOJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5844BA0", Offset = "0x5843BA0", VA = "0x185844BA0", Slot = "5")]
	public KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK, bool GONMDIENIEH)
	{
		return default(KDIMFJBMOJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5843850", Offset = "0x5842850", VA = "0x185843850", Slot = "6")]
	public void EAPJAGENDPM(KDIMFJBMOJG IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5842650", Offset = "0x5841650", VA = "0x185842650", Slot = "7")]
	public void ACMEOJCFDDJ(KDIMFJBMOJG IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x58431A0", Offset = "0x58421A0", VA = "0x1858431A0", Slot = "8")]
	public AECAIJBDOBI DDLGNJBFPIK(KDIMFJBMOJG IGJDJDNFANI, CIPELKEIKGK FNIHENPLJHK)
	{
		return default(AECAIJBDOBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x58429E0", Offset = "0x58419E0", VA = "0x1858429E0", Slot = "9")]
	public AECAIJBDOBI BCIAOMCEADH(KDIMFJBMOJG IGJDJDNFANI, LACGNLCHJJL FNIHENPLJHK)
	{
		return default(AECAIJBDOBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x58446C0", Offset = "0x58436C0", VA = "0x1858446C0", Slot = "11")]
	public void KKDECPNBHFN(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x58442D0", Offset = "0x58432D0", VA = "0x1858442D0", Slot = "10")]
	public void IHJKMBHCMND(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5844260", Offset = "0x5843260", VA = "0x185844260", Slot = "21")]
	public IEnumerable<Renderer> HAMFMGCCCFL(KDIMFJBMOJG IGJDJDNFANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5844AC0", Offset = "0x5843AC0", VA = "0x185844AC0", Slot = "12")]
	public PKNBFCKKMOO LAMEBPFAOKK(AONMLHHIGFG FNIHENPLJHK)
	{
		return default(PKNBFCKKMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5844E50", Offset = "0x5843E50", VA = "0x185844E50", Slot = "14")]
	public void PNNCHMIGICD(PKNBFCKKMOO IMDJKDNBABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5844550", Offset = "0x5843550", VA = "0x185844550", Slot = "16")]
	public Task JIPOOBOGJJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5843AD0", Offset = "0x5842AD0", VA = "0x185843AD0", Slot = "17")]
	public Task EJANCLILFPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x58430A0", Offset = "0x58420A0", VA = "0x1858430A0", Slot = "18")]
	[AsyncStateMachine(typeof(BKHGIBKKKJM))]
	public Task CMNLLOHPAMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5843010", Offset = "0x5842010", VA = "0x185843010", Slot = "19")]
	public void CINJPNOALHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5844B40", Offset = "0x5843B40", VA = "0x185844B40", Slot = "13")]
	public void LELEBEAACJB(PKNBFCKKMOO IMDJKDNBABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5843C30", Offset = "0x5842C30", VA = "0x185843C30", Slot = "20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5847110", Offset = "0x5846110", VA = "0x185847110")]
		public LBEBBFIEPEJ(LBEENDJFEOI DJAAGGDMNFL, JobHandle DGGOEPGELHE, ODPGIILADDM NLHFDNHDEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9045B0", Offset = "0x9035B0", VA = "0x1809045B0")]
		public bool FAFBILBNMMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x58470E0", Offset = "0x58460E0", VA = "0x1858470E0", Slot = "4")]
		public LBEENDJFEOI OIEKBFPKDBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5847090", Offset = "0x5846090", VA = "0x185847090", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x584ADE0", Offset = "0x5849DE0", VA = "0x18584ADE0", Slot = "17")]
		get
		{
			return default(JNGHICNLFNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private Vector3 CLAKEACNPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5849010", Offset = "0x5848010", VA = "0x185849010")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected override Hash128 IGJKPGCCDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5848EE0", Offset = "0x5847EE0", VA = "0x185848EE0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x584B190", Offset = "0x584A190", VA = "0x18584B190")]
	public MGGICBCAGIH(FFNIPMGEGPF IGJDJDNFANI, CIPELKEIKGK FNIHENPLJHK, bool ANHJFFNJDLG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x584A740", Offset = "0x5849740", VA = "0x18584A740", Slot = "16")]
	public override bool FDAMMJCFJOF(HLKOGFFGFGN IGJDJDNFANI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x584AD30", Offset = "0x5849D30", VA = "0x18584AD30", Slot = "18")]
	public override int GNPNCFJLACI(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x584AC80", Offset = "0x5849C80", VA = "0x18584AC80", Slot = "19")]
	public override int GCFHCEFELMM(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5849AD0", Offset = "0x5848AD0", VA = "0x185849AD0")]
	private int DLKCDKNHHCJ(DLGNEFKOMDA LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5849360", Offset = "0x5848360", VA = "0x185849360", Slot = "20")]
	public override void DLEFPBHFNPN(DLGNEFKOMDA LBEEDONFEAE, GACEEINPOIK HLLJMPAPIAH, int FOJFMKBPFED = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x584ABB0", Offset = "0x5849BB0", VA = "0x18584ABB0", Slot = "21")]
	public override HLKOGFFGFGN FJEJMGNKJIP()
	{
		return default(HLKOGFFGFGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5849D80", Offset = "0x5848D80", VA = "0x185849D80", Slot = "23")]
	public override FIMNOEPBBPE EMFKBOELNOL()
	{
		return default(FIMNOEPBBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5849F40", Offset = "0x5848F40", VA = "0x185849F40", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x5848950", Offset = "0x5847950", VA = "0x185848950")]
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
	[Cpp2IlInjected.Address(RVA = "0x6DF6E0", Offset = "0x6DE6E0", VA = "0x1806DF6E0")]
	public BNLNBAIPMAJ(ADFCLPEMJMA OJJAECDAPMA, NGJFOPLKFPM EHPFOOKIOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x583C510", Offset = "0x583B510", VA = "0x18583C510", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x583C150", Offset = "0x583B150", VA = "0x18583C150")]
	private void BPFHPKNLFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x583D7B0", Offset = "0x583C7B0", VA = "0x18583D7B0", Slot = "4")]
	public void JNBKMFJBJKA(KDIMFJBMOJG IGJDJDNFANI, NIHKMKJOMNK FFHNNFOLDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x583D9B0", Offset = "0x583C9B0", VA = "0x18583D9B0", Slot = "5")]
	public void JNBKMFJBJKA(AECAIJBDOBI HFGBNCJIMEI, NIHKMKJOMNK FFHNNFOLDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x583C970", Offset = "0x583B970", VA = "0x18583C970", Slot = "6")]
	public void GKANEGKDEPI(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x583BF60", Offset = "0x583AF60", VA = "0x18583BF60", Slot = "7")]
	public void ALDGDJOFOKK(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x583C6E0", Offset = "0x583B6E0", VA = "0x18583C6E0", Slot = "8")]
	public void EAAADLEGAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x14B4180", Offset = "0x14B3180", VA = "0x1814B4180", Slot = "9")]
	public void PJPLHEDGHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x583C3A0", Offset = "0x583B3A0", VA = "0x18583C3A0", Slot = "10")]
	public void DDFCNAMIABM(NIHKMKJOMNK FFHNNFOLDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x583DE80", Offset = "0x583CE80", VA = "0x18583DE80", Slot = "11")]
	public void PJFCBMDPNPE(KDIMFJBMOJG IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x583E030", Offset = "0x583D030", VA = "0x18583E030", Slot = "12")]
	public void PJFCBMDPNPE(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x583CE50", Offset = "0x583BE50", VA = "0x18583CE50", Slot = "13")]
	public void HLEPLINHBEF(KDIMFJBMOJG IGJDJDNFANI, DENHGLJDFAP HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x583CAA0", Offset = "0x583BAA0", VA = "0x18583CAA0", Slot = "14")]
	public void HLEPLINHBEF(AECAIJBDOBI HFGBNCJIMEI, DENHGLJDFAP HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x583C080", Offset = "0x583B080", VA = "0x18583C080", Slot = "17")]
	public void ANLBJFFMCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x583DD10", Offset = "0x583CD10", VA = "0x18583DD10", Slot = "15")]
	public void OFDMBBFKECA(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x583C0C0", Offset = "0x583B0C0", VA = "0x18583C0C0", Slot = "16")]
	public void BACEOCBNLKA(AECAIJBDOBI HFGBNCJIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xF98570", Offset = "0xF97570", VA = "0x180F98570", Slot = "18")]
	public void LBCPLNALJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x583DBD0", Offset = "0x583CBD0", VA = "0x18583DBD0", Slot = "19")]
	public void KMMBBOLJCMM(DENHGLJDFAP HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x583C720", Offset = "0x583B720", VA = "0x18583C720")]
	private void FDNPMKOOHII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x583CC90", Offset = "0x583BC90", VA = "0x18583CC90")]
	public void HLEPLINHBEF(AECAIJBDOBI HFGBNCJIMEI, DENHGLJDFAP HAOFNDAEGFJ, bool LLGDFIIONLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x583DDB0", Offset = "0x583CDB0", VA = "0x18583DDB0")]
	private void PDECJDHMGDG(DENHGLJDFAP HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x583D010", Offset = "0x583C010", VA = "0x18583D010", Slot = "20")]
	public void IEPDBJJNEHO(KDIMFJBMOJG IGJDJDNFANI, Vector3 MPOMCABBDMI, Vector3 JIAPDKKGDDN, Vector3 FKNEJIBMHFI, float HAEAEEDLLLF, float AJPOCNACMOB, IReadOnlyList<Camera> GCHCPPAFEAB, PGIFNGPHDIN JHIFAPMIEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x583D390", Offset = "0x583C390", VA = "0x18583D390", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x584C270", Offset = "0x584B270", VA = "0x18584C270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x584C3A0", Offset = "0x584B3A0", VA = "0x18584C3A0")]
	public static void NCKILPFECMP(CCHKAAINLDC AICPIDJDJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x584C0D0", Offset = "0x584B0D0", VA = "0x18584C0D0")]
	public static Material EJDMIBFDJMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5841120", Offset = "0x5840120", VA = "0x185841120")]
	public static Material IKBDPMKEHMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x584C210", Offset = "0x584B210", VA = "0x18584C210")]
	public static Material JNGHGNGGAOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x584C1A0", Offset = "0x584B1A0", VA = "0x18584C1A0")]
	public static int JJCBOPBJLHH(GEHJPLJJIIJ GADEHMOHNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x584C130", Offset = "0x584B130", VA = "0x18584C130")]
	public static int HFGHFIOLEEO(LIFEBPMLBGM EAOMHFMIJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x584C2D0", Offset = "0x584B2D0", VA = "0x18584C2D0")]
	public static void LLBNBHDJCPI(GameObject AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x584BFE0", Offset = "0x584AFE0", VA = "0x18584BFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10110E0", Offset = "0x10100E0", VA = "0x1810110E0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public virtual JNGHICNLFNC GNPABEFCNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x583B510", Offset = "0x583A510", VA = "0x18583B510", Slot = "17")]
		get
		{
			return default(JNGHICNLFNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NNKJMAFODII
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6DF030", Offset = "0x6DE030", VA = "0x1806DF030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA49830", Offset = "0xA48830", VA = "0x180A49830")]
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
		[Cpp2IlInjected.Address(RVA = "0x705AA0", Offset = "0x704AA0", VA = "0x180705AA0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MENFDOBKHKO JFCJHIPKNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6E6590", Offset = "0x6E5590", VA = "0x1806E6590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool CCJCOIMELKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x77FC20", Offset = "0x77EC20", VA = "0x18077FC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	protected ACLPLDEBONK(FFNIPMGEGPF IGJDJDNFANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x583B3B0", Offset = "0x583A3B0", VA = "0x18583B3B0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "16")]
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
	[Cpp2IlInjected.Address(RVA = "0x583B5A0", Offset = "0x583A5A0", VA = "0x18583B5A0", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x583B4E0", Offset = "0x583A4E0", VA = "0x18583B4E0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x584C3F0", Offset = "0x584B3F0", VA = "0x18584C3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
		[DebuggerHidden]
		public BLELFEOJJMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x583BBD0", Offset = "0x583ABD0", VA = "0x18583BBD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x583BD40", Offset = "0x583AD40", VA = "0x18583BD40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x583BCB0", Offset = "0x583ACB0", VA = "0x18583BCB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KDLMMLCPHPD> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x583BCB0", Offset = "0x583ACB0", VA = "0x18583BCB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x58419A0", Offset = "0x58409A0", VA = "0x1858419A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static SkinnedShapeRenderer CIPPKGFGNEI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5842310", Offset = "0x5841310", VA = "0x185842310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x58418E0", Offset = "0x58408E0", VA = "0x1858418E0")]
	public static Mesh BLKDMOGCEHO(BBHGNFFOFHB KMPJOEAFDOL, int LBEEDONFEAE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5842300", Offset = "0x5841300", VA = "0x185842300")]
	public static int NFDONAMLLPB(BBHGNFFOFHB KMPJOEAFDOL, int LBEEDONFEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5842120", Offset = "0x5841120", VA = "0x185842120")]
	public static FKIOOPNENIH LFJNPNIAPOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5842280", Offset = "0x5841280", VA = "0x185842280")]
	[IteratorStateMachine(typeof(BLELFEOJJMO))]
	private static IEnumerable<KDLMMLCPHPD> LMLFFNJPOMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5841DC0", Offset = "0x5840DC0", VA = "0x185841DC0")]
	public static KDLMMLCPHPD LBOMJLHBHHH(BBHGNFFOFHB KMPJOEAFDOL, int LBEEDONFEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x58422E0", Offset = "0x58412E0", VA = "0x1858422E0")]
	public static bool MKOKICHPNII(this BBHGNFFOFHB KMPJOEAFDOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5841730", Offset = "0x5840730", VA = "0x185841730")]
	public static void ANFHOJELKPG(BBHGNFFOFHB KMPJOEAFDOL, float3 BBJPPBPGGNB, out DJHPKIOAIJN AKMHBBIHINH, out float3 OCBJFGHKJJM, out float OGPPFFDAKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5841A10", Offset = "0x5840A10", VA = "0x185841A10")]
	public static void DOGAGBJBLEH(Vector3 BBJPPBPGGNB, BBHGNFFOFHB KMPJOEAFDOL, out Vector3 OCBJFGHKJJM, out float OGPPFFDAKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x58425A0", Offset = "0x58415A0", VA = "0x1858425A0")]
	[DFDEPFOCOOG(GCCGOPEBDFE.ExitingPlayMode, 0)]
	private static void OMFIIBIAFOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5842380", Offset = "0x5841380", VA = "0x185842380")]
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
			[Cpp2IlInjected.Address(RVA = "0x584C6A0", Offset = "0x584B6A0", VA = "0x18584C6A0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public ACLPLDEBONK IHLOOLPGFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x584C5E0", Offset = "0x584B5E0", VA = "0x18584C5E0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public JIMPEPDLLIK IHLOOLPGFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x584C640", Offset = "0x584B640", VA = "0x18584C640", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool KDAAMMKMNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x799190", Offset = "0x798190", VA = "0x180799190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x584D260", Offset = "0x584C260", VA = "0x18584D260")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x584C8A0", Offset = "0x584B8A0", VA = "0x18584C8A0", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x584D090", Offset = "0x584C090", VA = "0x18584D090", Slot = "4")]
		public KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK)
		{
			return default(KDIMFJBMOJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x584D090", Offset = "0x584C090", VA = "0x18584D090", Slot = "5")]
		public KDIMFJBMOJG MPFHBNDPAMC(ELAEDNIFCMA FNIHENPLJHK, bool GONMDIENIEH)
		{
			return default(KDIMFJBMOJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x584C930", Offset = "0x584B930", VA = "0x18584C930", Slot = "6")]
		public void EAPJAGENDPM(KDIMFJBMOJG IGJDJDNFANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x584C420", Offset = "0x584B420", VA = "0x18584C420", Slot = "7")]
		public void ACMEOJCFDDJ(KDIMFJBMOJG IGJDJDNFANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x584C760", Offset = "0x584B760", VA = "0x18584C760", Slot = "8")]
		public AECAIJBDOBI DDLGNJBFPIK(KDIMFJBMOJG IGJDJDNFANI, CIPELKEIKGK FNIHENPLJHK)
		{
			return default(AECAIJBDOBI);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x584C4A0", Offset = "0x584B4A0", VA = "0x18584C4A0", Slot = "9")]
		public AECAIJBDOBI BCIAOMCEADH(KDIMFJBMOJG IGJDJDNFANI, LACGNLCHJJL FNIHENPLJHK)
		{
			return default(AECAIJBDOBI);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x584CF20", Offset = "0x584BF20", VA = "0x18584CF20", Slot = "11")]
		public void KKDECPNBHFN(AECAIJBDOBI HFGBNCJIMEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x584CE60", Offset = "0x584BE60", VA = "0x18584CE60", Slot = "10")]
		public void IHJKMBHCMND(AECAIJBDOBI HFGBNCJIMEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x584CDF0", Offset = "0x584BDF0", VA = "0x18584CDF0", Slot = "21")]
		public IEnumerable<Renderer> HAMFMGCCCFL(KDIMFJBMOJG IGJDJDNFANI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x584CFB0", Offset = "0x584BFB0", VA = "0x18584CFB0", Slot = "12")]
		public PKNBFCKKMOO LAMEBPFAOKK(AONMLHHIGFG FNIHENPLJHK)
		{
			return default(PKNBFCKKMOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x584D1A0", Offset = "0x584C1A0", VA = "0x18584D1A0", Slot = "14")]
		public void PNNCHMIGICD(PKNBFCKKMOO IMDJKDNBABB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x584CEC0", Offset = "0x584BEC0", VA = "0x18584CEC0", Slot = "16")]
		public Task JIPOOBOGJJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x584C990", Offset = "0x584B990", VA = "0x18584C990", Slot = "17")]
		public Task EJANCLILFPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x584C700", Offset = "0x584B700", VA = "0x18584C700", Slot = "18")]
		public Task CMNLLOHPAMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x29FDFD0", Offset = "0x29FCFD0", VA = "0x1829FDFD0", Slot = "19")]
		public void CINJPNOALHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x584D030", Offset = "0x584C030", VA = "0x18584D030", Slot = "13")]
		public void LELEBEAACJB(PKNBFCKKMOO IMDJKDNBABB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x584C9F0", Offset = "0x584B9F0", VA = "0x18584C9F0", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
		[DebuggerHidden]
		public NAOOHCBFBNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x584BE40", Offset = "0x584AE40", VA = "0x18584BE40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x584BB60", Offset = "0x584AB60", VA = "0x18584BB60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x584BEC0", Offset = "0x584AEC0", VA = "0x18584BEC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x584BE00", Offset = "0x584AE00", VA = "0x18584BE00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x584BD60", Offset = "0x584AD60", VA = "0x18584BD60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x584BD60", Offset = "0x584AD60", VA = "0x18584BD60", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5846CC0", Offset = "0x5845CC0", VA = "0x185846CC0")]
	public static JIMPEPDLLIK MCBKIOCFNPP(AONMLHHIGFG FNIHENPLJHK, NGJFOPLKFPM EHPFOOKIOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5846E30", Offset = "0x5845E30", VA = "0x185846E30")]
	private JIMPEPDLLIK(AONMLHHIGFG FNIHENPLJHK, NGJFOPLKFPM EHPFOOKIOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5846770", Offset = "0x5845770", VA = "0x185846770")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5846C50", Offset = "0x5845C50", VA = "0x185846C50")]
	[IteratorStateMachine(typeof(NAOOHCBFBNJ))]
	public IEnumerable<Renderer> KLKDFIALDEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x58459B0", Offset = "0x58449B0", VA = "0x1858459B0", Slot = "4")]
	public void DAMGEILKFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5846490", Offset = "0x5845490", VA = "0x185846490")]
	private void FHPMMOPBOON(Vector3 OOBDECIHNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5846530", Offset = "0x5845530", VA = "0x185846530")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public BMFEMBEKJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x583BD80", Offset = "0x583AD80", VA = "0x18583BD80")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x583BDE0", Offset = "0x583ADE0", VA = "0x18583BDE0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x583BE10", Offset = "0x583AE10", VA = "0x18583BE10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int ALELDOGNNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BD0", Offset = "0x6DFBD0", VA = "0x1806E0BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x783430", Offset = "0x782430", VA = "0x180783430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x583EF30", Offset = "0x583DF30", VA = "0x18583EF30")]
	public void KOLLDLLCBHK(List<HLKOGFFGFGN> EINMNGDELAN, Matrix4x4[] IJBEHHDOLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x583E380", Offset = "0x583D380", VA = "0x18583E380")]
	public static List<CAMGNKHECIO> BMDGCEOIEEG(List<FFNIPMGEGPF> FHFEAHAMIGB, DLGNEFKOMDA LBEEDONFEAE, Bounds BNIHLJDPCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x583EB50", Offset = "0x583DB50", VA = "0x18583EB50")]
	private JobHandle HNPEDKJIIIN(LBEENDJFEOI LBHBHGBKKGM, int LDKDGLKIEBP, int HBPAJCFBAKB, DLGNEFKOMDA LBEEDONFEAE, List<BJIFKDHMEFN> MFGOJDNDOEH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x583E9B0", Offset = "0x583D9B0", VA = "0x18583E9B0")]
	private void DNHCIBCJFLM(List<BJIFKDHMEFN> MFGOJDNDOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x583F290", Offset = "0x583E290", VA = "0x18583F290")]
	private CAMGNKHECIO(List<BJIFKDHMEFN> MFGOJDNDOEH, int LDKDGLKIEBP, int HBPAJCFBAKB, DLGNEFKOMDA LBEEDONFEAE, Bounds BNIHLJDPCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x583EAC0", Offset = "0x583DAC0", VA = "0x18583EAC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int GEBGFKEPJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x584E2D0", Offset = "0x584D2D0", VA = "0x18584E2D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x584D640", Offset = "0x584C640", VA = "0x18584D640")]
		public static List<SkinnedShapeRenderer> Create(GameObject IGJDJDNFANI, List<CAMGNKHECIO> CLCHDMCMIOO, List<HLKOGFFGFGN> CLNKLEPCPON, Material HNKAKNCAJGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x584DAC0", Offset = "0x584CAC0", VA = "0x18584DAC0")]
		public void Init(CAMGNKHECIO DJAAGGDMNFL, List<HLKOGFFGFGN> CLNKLEPCPON, Material HNKAKNCAJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x584E220", Offset = "0x584D220", VA = "0x18584E220")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x584E170", Offset = "0x584D170", VA = "0x18584E170")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x584E130", Offset = "0x584D130", VA = "0x18584E130")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x584D890", Offset = "0x584C890", VA = "0x18584D890")]
		private void IADIDBIMGOD(ScriptableRenderContext MFEOJPNCOBA, Camera[] FIEDHCJIKNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x584DF70", Offset = "0x584CF70", VA = "0x18584DF70")]
		private void KOLLDLLCBHK(CommandBuffer FFABMGICEPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x584EB60", Offset = "0x584DB60", VA = "0x18584EB60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5845380", Offset = "0x5844380", VA = "0x185845380")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5845490", Offset = "0x5844490", VA = "0x185845490")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
