using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation.Mathematics;
using RecRoom.RendererV1.Terrain;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IGODHLECOAD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum POFMKFJLMNC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	DebugLocate,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	FrozenHover,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ManipulateCollision
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CODBDPNCDGJ
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KGLLFOFKIGH
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PDPGAAFEJAL
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum IDOKBCEFAKB
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	RRO_MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RRO_COLORS_COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	RRO_MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	GENERATED_MIN_VALUE = 1000,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	GENERATED_COLORS_BITS_PER_CHANNEL = 8,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	GENERATED_COLORS_COUNT = 16777216,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	GENERATED_MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	LEGACY_GENERATED_COLORS_COUNT = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	GENERATED_TO_GPU_OFFSET = -939,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AGJLBJPFPPM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x86C8F00", Offset = "0x86C7500", VA = "0x1886C8F00")]
	public static bool PMFMALLKNPD(this IDOKBCEFAKB HPKPCHHDKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x86C8EC0", Offset = "0x86C74C0", VA = "0x1886C8EC0")]
	public static bool GDKCPFBPDNA(this IDOKBCEFAKB HPKPCHHDKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x86C8ED0", Offset = "0x86C74D0", VA = "0x1886C8ED0")]
	public static bool JBEFHLLHPMO(this IDOKBCEFAKB HPKPCHHDKMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FBDPDFJNLFK
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HELGAKOMGEN : EDMHOEDPFHJ, IEquatable<HELGAKOMGEN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int AMOFDJHKCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x30A0350", Offset = "0x309E950", VA = "0x1830A0350", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x30A0340", Offset = "0x309E940", VA = "0x1830A0340", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GLJIKBGGLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86CFD40", Offset = "0x86CE340", VA = "0x1886CFD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1434A70", Offset = "0x1433070", VA = "0x181434A70", Slot = "8")]
	public bool Equals(HELGAKOMGEN AAGCKLPFJME)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2E30", Offset = "0x3EB1430", VA = "0x183EB2E30")]
	public static bool MGLHCKHANFO(HELGAKOMGEN JGPEJMANNEB, HELGAKOMGEN PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86CFCB0", Offset = "0x86CE2B0", VA = "0x1886CFCB0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x86CFD80", Offset = "0x86CE380", VA = "0x1886CFD80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LEFLGOLACFG : EDMHOEDPFHJ, IEquatable<LEFLGOLACFG>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int AMOFDJHKCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x30A0350", Offset = "0x309E950", VA = "0x1830A0350", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x30A0340", Offset = "0x309E940", VA = "0x1830A0340", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GLJIKBGGLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86CFEA0", Offset = "0x86CE4A0", VA = "0x1886CFEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1434A70", Offset = "0x1433070", VA = "0x181434A70", Slot = "8")]
	public bool Equals(LEFLGOLACFG AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86CFE10", Offset = "0x86CE410", VA = "0x1886CFE10", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86CFEE0", Offset = "0x86CE4E0", VA = "0x1886CFEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DLEPDHPKPHM : EDMHOEDPFHJ, IEquatable<DLEPDHPKPHM>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int AMOFDJHKCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x30A0350", Offset = "0x309E950", VA = "0x1830A0350", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x30A0340", Offset = "0x309E940", VA = "0x1830A0340", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GLJIKBGGLIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86CD610", Offset = "0x86CBC10", VA = "0x1886CD610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1434A70", Offset = "0x1433070", VA = "0x181434A70", Slot = "8")]
	public bool Equals(DLEPDHPKPHM AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86CD580", Offset = "0x86CBB80", VA = "0x1886CD580", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DIBJFLJJFNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMHLOPFJDIG(HELGAKOMGEN BOCNDANOLJJ, POFMKFJLMNC BNPFBJAOLKG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMHLOPFJDIG(LEFLGOLACFG KOJIMAFGDLP, POFMKFJLMNC BNPFBJAOLKG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CABFGMGHAHF(LEFLGOLACFG KOJIMAFGDLP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMKOMNMJPOM(LEFLGOLACFG KOJIMAFGDLP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPGAPMGFKLO();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCDBBDICNLJ(POFMKFJLMNC GPEIAHGICNA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KHEAFGKBLOH(HELGAKOMGEN BOCNDANOLJJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KHEAFGKBLOH(LEFLGOLACFG KOJIMAFGDLP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NLEPDEGMLIH(LEFLGOLACFG KOJIMAFGDLP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AMJEEICAALN(LEFLGOLACFG KOJIMAFGDLP);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OBBOFIDNJGM();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HHJOGOEEOCD();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GENGMPMKLMN(HELGAKOMGEN BOCNDANOLJJ, PDPGAAFEJAL GPEIAHGICNA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EPHLNECAEHH(LEFLGOLACFG KOJIMAFGDLP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MADNCPGMHAB(LEFLGOLACFG KOJIMAFGDLP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CGMEDPKPFGN();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CCOBNNELFCL(PDPGAAFEJAL GPEIAHGICNA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PBMGMADPIJI(HELGAKOMGEN BOCNDANOLJJ, Vector3 DJIGLACMLII, Vector3 IMPMKOLFKIF, Vector3 EADEMGGPEAH, float DBMMEDJIKBH, float OCDMHDILEMB, IReadOnlyList<Camera> CINBDGIIENA, IGODHLECOAD JLKFCEIEICE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PBMGMADPIJI(DLEPDHPKPHM MHEKKPNBJKH, Vector3 DJIGLACMLII, Vector3 IMPMKOLFKIF, Vector3 EADEMGGPEAH, float DBMMEDJIKBH, float OCDMHDILEMB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EKBBEBOGNCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool AMKGHBKHKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HELGAKOMGEN HKHBIEMOHAC(BGGCMEGDEOC CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HELGAKOMGEN HKHBIEMOHAC(BGGCMEGDEOC CDDIADBJAOB, bool BGLHJKPDMFC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNHMMBJGHCD(HELGAKOMGEN BOCNDANOLJJ);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KEPNHKCKLPD(HELGAKOMGEN BOCNDANOLJJ);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LEFLGOLACFG ABIAJMNMDCK(HELGAKOMGEN BOCNDANOLJJ, AEDDAMMOMOG CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LEFLGOLACFG HLDNAMJAAJB(HELGAKOMGEN BOCNDANOLJJ, GHJEGHHKFLP CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HABPOHHHMFI(LEFLGOLACFG KOJIMAFGDLP);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HPANLJEGOLH(LEFLGOLACFG KOJIMAFGDLP);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DLEPDHPKPHM POIPAFHJKKG(APMAMGEENID CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PHNCPKILALK(DLEPDHPKPHM MHEKKPNBJKH);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JDBGLAIHBID(DLEPDHPKPHM MHEKKPNBJKH);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task BBBKEKHLLIL();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LJPLFHBOPFE();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task AHJMCEPKHFO();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AIBJECCLJHE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> LHJLFLINPBD(HELGAKOMGEN BOCNDANOLJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FDBAAHMDGDF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum KNIADFPOMDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum PMPIMCLOPNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum OADBPPIHIIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		BatchColour,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		RefreshShapesBatchColour,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		RefreshBatchedMeshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum DLMGBGHDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum ELNDJCPLOEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum HKLNIOFLIHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		CheckPassive,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum GFDEJKKPPAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum HFHCIPJKPNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		LowQualityHighSpeed = 102,
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		SpreadsheetSettings = 103
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool LBBLDGGKHAP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long MCEJBLNLNLA;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool PJKAJBBCIOE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool ADINFAFBFML;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool CNIDMBECFCF;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float IJGKJPBLCIF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float IEKBMGHPBBN;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int JPONEGFLHKF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static HKLNIOFLIHC JCJOHDKFEBE;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long BOPFCJHHPGC;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float AHCGJDPGIFL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int GOIDGLLKMKI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int EDKDJFJACEM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int EBAINPEOJJP;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int LKFLAIHALLC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int BHHLGPDEAEE;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int EAAKIIBMEMH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int NEEBDACGCCM;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int OLKKEBJCGEC;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool OAKLPMFANJO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int MKHCCPIDHBF;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int KGPKHFJLHEF;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int POCONMDLADD;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool JLKPOMHBIJP;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float PHHJCACBBIH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool HENHGJCIMLN;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float EFKFFPGJPEF;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long CAKOLHIFPDK;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool EOECJKMMMPB;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long EDPBLEGGBMB;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int EJGNKEFOLHE;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool BCOFPCNAJGP;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static KNIADFPOMDG GMEBBALPGAI;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool NIFENJKPFPD;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool DPELHEBNGNN;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int POJLCHEPACE;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int OENPJLLPNAJ;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int KHMJPPJOBAI;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int PLONGAPFAIF;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int IOOBMFCFOMI;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int IJBCLCBPJGO;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int AMCEDFNPPNF;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int ABOHIHKHLOP;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float FOGPHINMMOO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float BPJICGKCKIK;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float EDNHLDCJOPI;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float MIMJOCJOLKA;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int ONFNLFIEMLC;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int JFPKOCAAPNB;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int OPMBHHBNBCN;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int BNDHJKNJFCM;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool KHDELCHIAID;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static OADBPPIHIIO LBPCIOGAMFO;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static DLMGBGHDIBJ ILADMHAHDAD;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool ADPHELPGHKM;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static PMPIMCLOPNI MLMFFNPGPBM;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float GMGBMDBAPJP;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float LBGONAEOANK;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float GNGIHGHLAPK;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float JBGCCDANAOA;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float LHNBNLEFELJ;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float MAHGCOLNPEA;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float MIBBBEAHDJA;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float AHAMGGBBLHL;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool HOEJABBFMBN;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static GFDEJKKPPAO JBJGNHMCDEL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool CKMJCGLCMDP;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float DCOCKBIHGJH;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float AEDIDONOBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float KPNFPEFNBMD;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float BHAPGPNLBAI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float FELAOABLGNL;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool FGNBFNOBKGA;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long OOFDBBKDKGC;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float GMIBGLHKAIN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float PIJBCGGIGKJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float EBKMMKJIAIG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int IPFDCOKKKFI;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float ABFPILPEBCP;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool GCHDOJAMOLE;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long JGMCABONCIO;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int GAEDDNCOGFB;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int FHPDHOEDGCF;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float MLGMKHFOIFN;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float CFLLKIELNHD;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool FOIPALBLCGF;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool MJBJPEMEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float BMAIKILKODF;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long BGGLLNBCBOE;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long AAABCPJAFAC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int CNIFEEMBOOH;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static bool FJJJEAHCEDK;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float JMFBBOHPKAE;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static float FIIMHBGADOC;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static bool JHPMKABHELE;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long BNMCINDNPBD;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int FADHLICNCPF;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static float4x4 EBMBMKAGFPN;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static float3 CPHBPNGCAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static bool GIIAJNLKGJC;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static ELNDJCPLOEF AFFMKNGOOPF;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long BHEMIKKLEFB;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int HOBHNEPPDFI;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int JIPCBENGLPA;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int HGGKDIDPJOF;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int ALFPJNABFDA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int JNDIBEPLBOH;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int NEJCKNNJAFA;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int OFABPCFIKKI;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long HOPCMLAMOCL;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int FGEBGOEEHPG;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int CHAIBAONDEL;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int MPLPKECKDPN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long OGHGDDJFJMC;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long HGCGKIFKNMG;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long NHEECDOLLAI;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long BNACJDPDOPM;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int GJGHACKMCJO;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int JAAPGIAFLOE;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static int HLLBHPMNAMI;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static int LHPENLLEMBK;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int ADKKJFLDHFI;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int[] HAPPLHIAOFJ;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int[] CIIPCCMKNJN;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static int JPKILBCJIBL;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long CAINEFDHHJA;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long GAGKHHNEFOH;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int JJDDPHHKFPL;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static int DAOLFHABHLM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long HBBFBNGNBFI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long NDKOEAICKFO;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long ENKKKHCBGEI;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long NHFMJDEBPCP;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long MENOMKIJBAN;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long OOMGDEFODIM;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long LDANLKNBBEN;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long DJLABMEOFCD;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long NIFMHHFCPBK;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float HCKJMFBJCII;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static float OAJNJCGPLPP;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long LNCAOKFMPGB;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static int DFLBJHJJCIE;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long AFELIPHABHB;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long AHJOHAMBFHA;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static float JOPFBNEBFDE;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long BDPMLIGANKD;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long NLNEKMIADPG;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long EGMNNEHMKFA;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long PNNOPNNKNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long IIOHFHFGHBH;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long KAEPPNLKONM;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static long DEPJNCEFIJJ;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static long FCIGODJEDMH;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static long EFHOALBEGLD;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static long JMEKPBADPLF;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static long IPNDMLIFDFF;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static long HKDMBDKFMJA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static HFHCIPJKPNF JJGNELNILFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86CEEB0", Offset = "0x86CD4B0", VA = "0x1886CEEB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long MCEAGNEDBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86CEF10", Offset = "0x86CD510", VA = "0x1886CEF10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86CD650", Offset = "0x86CBC50", VA = "0x1886CD650")]
	public static void BFPLBGHDPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86CDD00", Offset = "0x86CC300", VA = "0x1886CDD00")]
	public static void CNMNELNJIOO(HFHCIPJKPNF PKIMILACKIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BMHAFGHHLHP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct MLBPPHNCPCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Vector3 PGBNPPMBLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Quaternion BGKDKGECOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public float MNAJFFMBOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Quaternion ALNGKBCAKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public float DNFEMNKMEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public float PLOADJOGDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public float OGDOBPACEKN;
	}

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static List<MLBPPHNCPCA> JPMNHGHAADL;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86C9410", Offset = "0x86C7A10", VA = "0x1886C9410")]
	public static NativeList<KMFOEBEFONO> DEFKPPJFEJC(BBLLJDDJMAF PCLIBIJEFPO)
	{
		return default(NativeList<KMFOEBEFONO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86C9A80", Offset = "0x86C8080", VA = "0x1886C9A80")]
	private static bool GFOAONEECIK(int ENCGNPAFEED, NativeList<KMFOEBEFONO> FAKHJBCPGHO, List<MLBPPHNCPCA> MHEDPFPLJMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x86CBDF0", Offset = "0x86CA3F0", VA = "0x1886CBDF0")]
	private static KMFOEBEFONO ODJGLFAPMOB(int IFMKBBDLCHB, List<MLBPPHNCPCA> MHEDPFPLJMF)
	{
		return default(KMFOEBEFONO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x86C8F20", Offset = "0x86C7520", VA = "0x1886C8F20")]
	private static KMFOEBEFONO AFDLNAHCJFE(int IFMKBBDLCHB, List<MLBPPHNCPCA> MHEDPFPLJMF)
	{
		return default(KMFOEBEFONO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x86C99A0", Offset = "0x86C7FA0", VA = "0x1886C99A0")]
	private static KMFOEBEFONO ENJIHOLOEAP(Vector3 ALFMKPLFANJ, Quaternion LBDLDEPDKMC, float JPNOJNLEGJO)
	{
		return default(KMFOEBEFONO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86CA930", Offset = "0x86C8F30", VA = "0x1886CA930")]
	public static NativeList<KMFOEBEFONO> NKMPPHHMLDO(BBLLJDDJMAF PCLIBIJEFPO, float ALPMFKBMFLC)
	{
		return default(NativeList<KMFOEBEFONO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CCFNBBCODDL
{
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static Vector3 GLKDBLCKOCA;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static Vector3 AIOMACHHJBK;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly float ENGGEOECEKF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x86CCDC0", Offset = "0x86CB3C0", VA = "0x1886CCDC0")]
	public static Vector3 OCAODACDGCG(Vector3 OOPALAJFGBM, Quaternion LBDLDEPDKMC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x86CCCA0", Offset = "0x86CB2A0", VA = "0x1886CCCA0")]
	public static Vector3 LKMBMODDPGL(Quaternion LDAEEKEKDJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x86CC7D0", Offset = "0x86CADD0", VA = "0x1886CC7D0")]
	public static Vector3 HDDLOKFDEDI(Quaternion LDAEEKEKDJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x86CCD40", Offset = "0x86CB340", VA = "0x1886CCD40")]
	public static Quaternion NNMLBHAHBAH(Vector3 JPDMHOCEDGB, Vector3 EPCDDFCHPMD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x86CD050", Offset = "0x86CB650", VA = "0x1886CD050")]
	public static Vector3 OIGIACHGFBM(Vector3 COFEEDBDKNK, Vector3 MEBBLPPOOCM, Vector3 EPCDDFCHPMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x86CC870", Offset = "0x86CAE70", VA = "0x1886CC870")]
	public static Vector3 LKFMNGDAAJI(Vector3 OOPALAJFGBM, Vector3 EPCDDFCHPMD, Quaternion LDAEEKEKDJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x86CC2F0", Offset = "0x86CA8F0", VA = "0x1886CC2F0")]
	public static Quaternion BEBHKGKDMAG(Quaternion LBDLDEPDKMC, Vector3 JPDMHOCEDGB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86CC650", Offset = "0x86CAC50", VA = "0x1886CC650")]
	public static bool BOOJHAHDPMA(Vector3 KICLENALJAB, Vector3 FNHBAAINFBO, [Out] Vector3 BDLBKPEDGPL, bool MPONPMEOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x86CC000", Offset = "0x86CA600", VA = "0x1886CC000")]
	public static Vector3 AFEADCLGLNI(bool GIAHBLHOMEC, [Optional] Quaternion MLAKIFPODON)
	{
		return default(Vector3);
	}
}
namespace RecRoom.RendererV1.Terrain
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct TerrainMaterialLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float heightCutoff;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public float effectiveHeightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public FBDPDFJNLFK topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public FBDPDFJNLFK slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct TerrainWaterProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public bool waterEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public float waterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public float waterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Color waterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Color deepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public float emissiveStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public float alpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public PPLBBBHFMKJ waterMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public BMBIMNFFOOL overrides;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public NGKDAGAOOPI baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public bool normalizeLayerHeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public COCHOMAPEKN playArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public float playAreaOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public TerrainWaterProperties globalWaterProperties;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x86CFFF0", Offset = "0x86CE5F0", VA = "0x1886CFFF0")]
		public TerrainGenerationInfo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct TerrainInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public float GroundHeight;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EMMBCENNPIK
{
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Height,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Strata,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LNBEKEOHALH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public Vector2Int KCJLCGFEBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public float[] LGMBOCEBOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public EMMBCENNPIK GPEIAHGICNA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x86CFF70", Offset = "0x86CE570", VA = "0x1886CFF70")]
	public LNBEKEOHALH(Vector2Int KCJLCGFEBMJ, EMMBCENNPIK GPEIAHGICNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CMLOELNHBKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public float ALPMFKBMFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public float HGLCAJHEGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public TerrainMaterialLayer[] MDLDHAPEGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public int EIDADIIDFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public LNBEKEOHALH[] FEGIAMACCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public float JMHPLLGMFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public int GIMNCCLKFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public int DDMLPOHMJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public float AFPMKGHACPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public int KPIEOCMJOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public float ILNBFMJIAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public int HCCLMFLCEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public int ENDKEIIJHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public float DJPMBPKPGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public int BDLEKAIEGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public int PNIBHNGMDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public int KBNGPCANFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public LNBEKEOHALH[] HCIJGPPIOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public float MFCFCJLIDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public int OKJLIFKJABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public int MGONFEGCGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public int HBADKEHNCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public float GNIGJEPPLPD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x86CD320", Offset = "0x86CB920", VA = "0x1886CD320")]
	public CMLOELNHBKK(Vector2Int BEAODBEHEGD, Vector2Int CMPNOLAJMOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JMLDEEGDKPA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	TerrainData AODOHDFDEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject GJMCKGCNODH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 CKAFGBJIACE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float3 OPAMODJCFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float3 FMCDOEPDDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	TerrainGenerationInfo ABCLHHEOBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	TerrainInfo LABNGFDGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> DNPPPNJLOMB(uint LEIFMFPCLJB, bool LMGCOEPFJPA = true, bool EHDOKIDHDPE = true, bool FBJGLEBMCKJ = true, [Optional] TerrainGenerationInfo PCLIBIJEFPO, NEIPJCMGJJC JMFHBNHOOMB = NEIPJCMGJJC.Default, [Optional] float3? DBCLAOLCJND, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GELLEPHLJAH(bool MPFCOJJPGFL);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KGKLMPPOJFE(Action<Material> JFHDLAFFHOM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KMFOEBEFONO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public float3 PGBNPPMBLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public float3x3 BGKDKGECOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public float MNAJFFMBOKL;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface BBLLJDDJMAF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int CFKNNEFAKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DMJCDHHNMOM(int IFMKBBDLCHB);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion CEHMIGOHPAM(int IFMKBBDLCHB);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float HNIAGNEJJAC(int IFMKBBDLCHB);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GHJEGHHKFLP : EHINNOKAEPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NIAIKODDALN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BNELHJIHEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float JFBOACLEGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int IDDNLFFCBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ABDJDENNPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int GILIKINABOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<KMFOEBEFONO> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AEDDAMMOMOG : EHINNOKAEPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CODBDPNCDGJ OMLBHFIFGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JIDHOOOFBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float3 LBOBHJEFGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BGGCMEGDEOC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	ACLDACCHLEI JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	KGLLFOFKIGH HKNCFLALFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EHINNOKAEPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MJDHKDNGEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool AANOAEOOKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	ACLDACCHLEI JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	UniformTRS ELINLBPBANO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float OAIKINPPNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 EOCKFJJEBCK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	IDOKBCEFAKB HDIEKCMFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	FBDPDFJNLFK BLKBNMOFNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface APMAMGEENID
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int MANNALJLDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Transform GOIKDBEKCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CGOGONAKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HELGAKOMGEN GetBone(int IFMKBBDLCHB);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int IFMKBBDLCHB);
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
