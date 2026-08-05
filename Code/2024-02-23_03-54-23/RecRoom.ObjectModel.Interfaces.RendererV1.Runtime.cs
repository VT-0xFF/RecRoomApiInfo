using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ABEDONJACEG
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
public enum PNAKLNMDHCF
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
	FrozenHover
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MHAOGNKGHGG
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NCGBBBLEHNH
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum ILPKNPDEMCA
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OIEDBBAJKGM
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RRO_MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RRO_COLORS_COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RRO_MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	GENERATED_MIN_VALUE = 1000,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	GENERATED_COLORS_BITS_PER_CHANNEL = 8,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	GENERATED_COLORS_COUNT = 16777216,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	GENERATED_MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	LEGACY_GENERATED_COLORS_COUNT = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	GENERATED_TO_GPU_OFFSET = -939,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IOAHEEBPKPD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x608D090", Offset = "0x608BA90", VA = "0x18608D090")]
	public static bool PEBMGEIAEEN(this OIEDBBAJKGM MDEAOBPDKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x608D0B0", Offset = "0x608BAB0", VA = "0x18608D0B0")]
	public static bool PJEPNFJIAAE(this OIEDBBAJKGM MDEAOBPDKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x608D060", Offset = "0x608BA60", VA = "0x18608D060")]
	public static bool FNCENFENHBL(this OIEDBBAJKGM MDEAOBPDKIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OADCHAEGGGG
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MJJHKNIAGMD : MJIGHPBFKCE, IEquatable<MJJHKNIAGMD>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int MEJJBNBBHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int BDIBPBOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21E5FF0", Offset = "0x21E49F0", VA = "0x1821E5FF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x54213D0", Offset = "0x541FDD0", VA = "0x1854213D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LIEFAHOJBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x608D150", Offset = "0x608BB50", VA = "0x18608D150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1C88620", Offset = "0x1C87020", VA = "0x181C88620", Slot = "8")]
	public bool Equals(MJJHKNIAGMD AAMIMDAKFMC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9940", Offset = "0x5FC8340", VA = "0x185FC9940")]
	public static bool DKCGANGKMBM(MJJHKNIAGMD MAGGDEMNFDG, MJJHKNIAGMD LFCFPOEDJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x608D0C0", Offset = "0x608BAC0", VA = "0x18608D0C0", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x608D190", Offset = "0x608BB90", VA = "0x18608D190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct AAPAGFAMDMO : MJIGHPBFKCE, IEquatable<AAPAGFAMDMO>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MEJJBNBBHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int BDIBPBOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x21E5FF0", Offset = "0x21E49F0", VA = "0x1821E5FF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x54213D0", Offset = "0x541FDD0", VA = "0x1854213D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LIEFAHOJBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60872F0", Offset = "0x6085CF0", VA = "0x1860872F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1C88620", Offset = "0x1C87020", VA = "0x181C88620", Slot = "8")]
	public bool Equals(AAPAGFAMDMO AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6087260", Offset = "0x6085C60", VA = "0x186087260", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6087330", Offset = "0x6085D30", VA = "0x186087330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DFLBFJDIEGC : MJIGHPBFKCE, IEquatable<DFLBFJDIEGC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MEJJBNBBHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BDIBPBOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x21E5FF0", Offset = "0x21E49F0", VA = "0x1821E5FF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x54213D0", Offset = "0x541FDD0", VA = "0x1854213D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LIEFAHOJBOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6087450", Offset = "0x6085E50", VA = "0x186087450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1C88620", Offset = "0x1C87020", VA = "0x181C88620", Slot = "8")]
	public bool Equals(DFLBFJDIEGC AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60873C0", Offset = "0x6085DC0", VA = "0x1860873C0", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HJEGPGCNDCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANIADKOEIFN(MJJHKNIAGMD LMAHFBOHCNI, PNAKLNMDHCF KJDBNOPJOLM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANIADKOEIFN(AAPAGFAMDMO FAHALEOOBNP, PNAKLNMDHCF KJDBNOPJOLM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COKFJHGBCAE(AAPAGFAMDMO FAHALEOOBNP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HGOOKBAGDGH(AAPAGFAMDMO FAHALEOOBNP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKLCKMNIEIB();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KOFCALFCLEJ(PNAKLNMDHCF ADAMDPHPFAA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INALBBLHGDA(MJJHKNIAGMD LMAHFBOHCNI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INALBBLHGDA(AAPAGFAMDMO FAHALEOOBNP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JNPFNMJPMNL(AAPAGFAMDMO FAHALEOOBNP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FACJKJKDDLH(AAPAGFAMDMO FAHALEOOBNP);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AJEKKPIAHKG();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MOOEEFLNNME();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void POOLIDOEBME(MJJHKNIAGMD LMAHFBOHCNI, ILPKNPDEMCA ADAMDPHPFAA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JOOAKFMPGGC(AAPAGFAMDMO FAHALEOOBNP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EPFBBNPJODK(AAPAGFAMDMO FAHALEOOBNP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FIKIAINNHIE();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PNPCJJJPOID(ILPKNPDEMCA ADAMDPHPFAA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HEBKBKKJKEC(MJJHKNIAGMD LMAHFBOHCNI, Vector3 LEFJGFFPNEO, Vector3 AIGGGLNIMMK, Vector3 HDOPDIDFKFD, float INPGPIIOGLL, float MMHOHBOHBCH, IReadOnlyList<Camera> MGMFANBAKFD, ABEDONJACEG IGLLDDGIOAI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HEBKBKKJKEC(DFLBFJDIEGC CLGPPMFFGNM, Vector3 LEFJGFFPNEO, Vector3 AIGGGLNIMMK, Vector3 HDOPDIDFKFD, float INPGPIIOGLL, float MMHOHBOHBCH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KMICGLLKJAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GFKKCKBIFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJJHKNIAGMD CKKCKGBBGAL(AAOAKJBIBDD MFNOAEFOKBK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MJJHKNIAGMD CKKCKGBBGAL(AAOAKJBIBDD MFNOAEFOKBK, bool OALJDNJBHKE);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOEHHKLIKDI(MJJHKNIAGMD LMAHFBOHCNI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OBNHKAHBGDD(MJJHKNIAGMD LMAHFBOHCNI);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AAPAGFAMDMO BNJPGEHINNG(MJJHKNIAGMD LMAHFBOHCNI, NCCCFANDMKG MFNOAEFOKBK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AAPAGFAMDMO GPLDIAMAHEK(MJJHKNIAGMD LMAHFBOHCNI, FKOJPFJKNGK MFNOAEFOKBK);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EIEBNHKOLNC(AAPAGFAMDMO FAHALEOOBNP);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BMILOILJONJ(AAPAGFAMDMO FAHALEOOBNP);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DFLBFJDIEGC CPMPIFLDCIH(FGHBOIBBOIN MFNOAEFOKBK);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ILGNKGJDHJJ(DFLBFJDIEGC CLGPPMFFGNM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ECANFEPBADD(DFLBFJDIEGC CLGPPMFFGNM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task HAKMCEGLDIA();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task BKAFEFHCEJD();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task BPJMCMIEPNC();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HMHLIOMMEEB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> GHLPDGEBBFP(MJJHKNIAGMD LMAHFBOHCNI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EABKIFECCAB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum MLIGDHNNPDO
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum BKFILJOBGGK
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum FBMIMEODIOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum DDLBAHGNPCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		Slight,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		AveragePC,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		OldMobile,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		OutOfMemory
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static bool OBBHNPIJGLI;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int PNIKKCJHINA;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int ELDEHAAJAHB;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int APEPFBCHIOA;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int LEDDCHNLIBA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int BKCAEDBLHJI;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int ACAMJJJOFAE;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int KJDLJOJEDCN;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static int OOGAPMCKPFE;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static long IOHODHAIEIL;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static long DFBFIFGILNM;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static long BLNMNFBJFHO;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static long DNEEHIHDLLI;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static long MEFNIOOFBEI;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static long CELMKPMGAMN;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static long HBKDKDMMEBE;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static long NMOIHEBHJKI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static DDLBAHGNPCC KKEEBKGNLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60886D0", Offset = "0x60870D0", VA = "0x1860886D0")]
		[CompilerGenerated]
		get
		{
			return default(DDLBAHGNPCC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6088840", Offset = "0x6087240", VA = "0x186088840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static MLIGDHNNPDO DFAHHNGMOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6088FC0", Offset = "0x60879C0", VA = "0x186088FC0")]
		[CompilerGenerated]
		get
		{
			return default(MLIGDHNNPDO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6088780", Offset = "0x6087180", VA = "0x186088780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool IDDLINCHKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6089170", Offset = "0x6087B70", VA = "0x186089170")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6087840", Offset = "0x6086240", VA = "0x186087840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static BKFILJOBGGK BBPOHGMGLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60883E0", Offset = "0x6086DE0", VA = "0x1860883E0")]
		[CompilerGenerated]
		get
		{
			return default(BKFILJOBGGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60876A0", Offset = "0x60860A0", VA = "0x1860876A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool GBNBKHCFDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6089800", Offset = "0x6088200", VA = "0x186089800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60887E0", Offset = "0x60871E0", VA = "0x1860887E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool OEJGMJCADON
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x60899B0", Offset = "0x60883B0", VA = "0x1860899B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6088D40", Offset = "0x6087740", VA = "0x186088D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static float GABCMOHOJON
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60884D0", Offset = "0x6086ED0", VA = "0x1860884D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6088F10", Offset = "0x6087910", VA = "0x186088F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static int KPEDEPFKPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6088320", Offset = "0x6086D20", VA = "0x186088320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static int JDKOFFAFFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6089120", Offset = "0x6087B20", VA = "0x186089120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60889C0", Offset = "0x60873C0", VA = "0x1860889C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static int KNEELAMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60874F0", Offset = "0x6085EF0", VA = "0x1860874F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60898A0", Offset = "0x60882A0", VA = "0x1860898A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int KFNLEENFOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6089850", Offset = "0x6088250", VA = "0x186089850")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6089900", Offset = "0x6088300", VA = "0x186089900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int JJCLHNLNHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60882D0", Offset = "0x6086CD0", VA = "0x1860882D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6088720", Offset = "0x6087120", VA = "0x186088720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int IMIIGGFMMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6089210", Offset = "0x6087C10", VA = "0x186089210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6088B80", Offset = "0x6087580", VA = "0x186088B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int HCHEEBFNPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6088520", Offset = "0x6086F20", VA = "0x186088520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6088DF0", Offset = "0x60877F0", VA = "0x186088DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int FOLJNJACEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6088AE0", Offset = "0x60874E0", VA = "0x186088AE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6088BE0", Offset = "0x60875E0", VA = "0x186088BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int OJNANJOJFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6088F70", Offset = "0x6087970", VA = "0x186088F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6087700", Offset = "0x6086100", VA = "0x186087700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int JOPGNJNKMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60897B0", Offset = "0x60881B0", VA = "0x1860897B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6088EB0", Offset = "0x60878B0", VA = "0x186088EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int MPAIFDMAAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6088280", Offset = "0x6086C80", VA = "0x186088280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x60895F0", Offset = "0x6087FF0", VA = "0x1860895F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static bool BACJNAMIPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6089960", Offset = "0x6088360", VA = "0x186089960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60890C0", Offset = "0x6087AC0", VA = "0x1860890C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static bool MJGKCNGJKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6088B30", Offset = "0x6087530", VA = "0x186088B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6089260", Offset = "0x6087C60", VA = "0x186089260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static FBMIMEODIOG NMHDOEAPMND
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x60885D0", Offset = "0x6086FD0", VA = "0x1860885D0")]
		[CompilerGenerated]
		get
		{
			return default(FBMIMEODIOG);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6089650", Offset = "0x6088050", VA = "0x186089650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool GIAHFAFANPC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6089070", Offset = "0x6087A70", VA = "0x186089070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6088570", Offset = "0x6086F70", VA = "0x186088570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float KIABJDFBGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6089760", Offset = "0x6088160", VA = "0x186089760")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6088960", Offset = "0x6087360", VA = "0x186088960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float CPGPHIHEFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6087650", Offset = "0x6086050", VA = "0x186087650")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6088670", Offset = "0x6087070", VA = "0x186088670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static float BCDINIGCDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6087540", Offset = "0x6085F40", VA = "0x186087540")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6088E50", Offset = "0x6087850", VA = "0x186088E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static float FFFIFLGEMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6088480", Offset = "0x6086E80", VA = "0x186088480")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6089010", Offset = "0x6087A10", VA = "0x186089010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static float DEPKIIJDEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6088C40", Offset = "0x6087640", VA = "0x186088C40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x60875F0", Offset = "0x6085FF0", VA = "0x1860875F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool LIHGPAKAFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x60891C0", Offset = "0x6087BC0", VA = "0x1860891C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x60888A0", Offset = "0x60872A0", VA = "0x1860888A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static float FFIAKLBIEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6088620", Offset = "0x6087020", VA = "0x186088620")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6088380", Offset = "0x6086D80", VA = "0x186088380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int JLDHHDEHFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6088430", Offset = "0x6086E30", VA = "0x186088430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6087490", Offset = "0x6085E90", VA = "0x186087490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int HNLHPLFFABP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6088C90", Offset = "0x6087690", VA = "0x186088C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60881C0", Offset = "0x6086BC0", VA = "0x1860881C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int JFGKFHLJNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6088DA0", Offset = "0x60877A0", VA = "0x186088DA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6088220", Offset = "0x6086C20", VA = "0x186088220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool GPEOODKHNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6088CE0", Offset = "0x60876E0", VA = "0x186088CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6088A80", Offset = "0x6087480", VA = "0x186088A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static Transform NFKMCFEIOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6088A20", Offset = "0x6087420", VA = "0x186088A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6087760", Offset = "0x6086160", VA = "0x186087760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool MKOHLGPOOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60877E0", Offset = "0x60861E0", VA = "0x1860877E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6089700", Offset = "0x6088100", VA = "0x186089700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool GJOMHELKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6088900", Offset = "0x6087300", VA = "0x186088900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6087590", Offset = "0x6085F90", VA = "0x186087590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static bool HMHKKFBHMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60896B0", Offset = "0x60880B0", VA = "0x1860896B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6088160", Offset = "0x6086B60", VA = "0x186088160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60878A0", Offset = "0x60862A0", VA = "0x1860878A0")]
	public static void CBLIICIFNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60892C0", Offset = "0x6087CC0", VA = "0x1860892C0")]
	public static void LFBDKLOAGOB(DDLBAHGNPCC EIJLOKJNMFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IIJEAPGKPNI
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct AINKNFFNKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Vector3 FFAIKMBLIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Quaternion CAPHJLBJELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public float MJKHDKLACPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Quaternion FPNMPMHHKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float LPAGCIBMMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public float MAHIGMKFKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float DBHGANKFDLE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static List<AINKNFFNKHP> LJENKODJAJL;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x608C540", Offset = "0x608AF40", VA = "0x18608C540")]
	public static NativeList<BJPEKJEJMDP> PHCKFLFEHOD(PDDBOKBJMPP CBJFHHJLIDF)
	{
		return default(NativeList<BJPEKJEJMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6089E20", Offset = "0x6088820", VA = "0x186089E20")]
	private static bool BFNIFBDOIIO(int CCNHOKJIGCD, NativeList<BJPEKJEJMDP> MNKBHKEBOPJ, List<AINKNFFNKHP> PNDHBMNLPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x608AEE0", Offset = "0x60898E0", VA = "0x18608AEE0")]
	private static BJPEKJEJMDP EIGAEKFPPHG(int MCGKIOCGDEM, List<AINKNFFNKHP> PNDHBMNLPBD)
	{
		return default(BJPEKJEJMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x608CAC0", Offset = "0x608B4C0", VA = "0x18608CAC0")]
	private static BJPEKJEJMDP PIJJGGEHKII(int MCGKIOCGDEM, List<AINKNFFNKHP> PNDHBMNLPBD)
	{
		return default(BJPEKJEJMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x608AE00", Offset = "0x6089800", VA = "0x18608AE00")]
	private static BJPEKJEJMDP EIDCJNKFMJI(Vector3 AAMPHNBHBHG, Quaternion NFELANJKNHP, float NLAEHEEAFBH)
	{
		return default(BJPEKJEJMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x608B070", Offset = "0x6089A70", VA = "0x18608B070")]
	public static NativeList<BJPEKJEJMDP> IFLEEJKPBPF(PDDBOKBJMPP CBJFHHJLIDF, float EMOAHBFLGLK)
	{
		return default(NativeList<BJPEKJEJMDP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NMFLDKGLHJJ
{
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static Vector3 FHPIONPINCB;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static Vector3 DJHJOPOBDPD;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static readonly float IFKHEKFIHGH;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x608D590", Offset = "0x608BF90", VA = "0x18608D590")]
	public static Vector3 AHEENBONKNO(Vector3 APJECLFLDIH, Quaternion NFELANJKNHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x608D8A0", Offset = "0x608C2A0", VA = "0x18608D8A0")]
	public static Vector3 EDNGHADBBLI(Quaternion PGPLGEJKHLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x608E0D0", Offset = "0x608CAD0", VA = "0x18608E0D0")]
	public static Vector3 MEKJFAKIEOE(Quaternion PGPLGEJKHLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x608D820", Offset = "0x608C220", VA = "0x18608D820")]
	public static Quaternion BCAFCFOJGIM(Vector3 HLJLNEHEKPN, Vector3 GKJEHHDBDOI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x608DEE0", Offset = "0x608C8E0", VA = "0x18608DEE0")]
	public static Vector3 JOANIHCCAKP(Vector3 LBGOOPAPHAN, Vector3 NODBOEJBGKE, Vector3 GKJEHHDBDOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x608D940", Offset = "0x608C340", VA = "0x18608D940")]
	public static Vector3 GBDOJOMLCPB(Vector3 APJECLFLDIH, Vector3 GKJEHHDBDOI, Quaternion PGPLGEJKHLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x608D220", Offset = "0x608BC20", VA = "0x18608D220")]
	public static Quaternion AAGMAGBDKAI(Quaternion NFELANJKNHP, Vector3 HLJLNEHEKPN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x608DD70", Offset = "0x608C770", VA = "0x18608DD70")]
	public static bool ICHFMKGKFHA(Vector3 FNHFFCAOHNP, Vector3 PPMEOJIKGBH, [Out] Vector3 IACENKFIOLG, bool GPFJPHGLDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x608E170", Offset = "0x608CB70", VA = "0x18608E170")]
	public static Vector3 NHNDCBKLFIN(bool PLKNBFNMEPI, [Optional] Quaternion IGGKHENEPMO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BJPEKJEJMDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float3 FFAIKMBLIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public float3x3 CAPHJLBJELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float MJKHDKLACPE;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PDDBOKBJMPP
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int CPDPHHBAODP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NNPKGLDCIBP(int MCGKIOCGDEM);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion FHNCNPJAANM(int MCGKIOCGDEM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float MBGNCJDAGON(int MCGKIOCGDEM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FKOJPFJKNGK : FAJNHGLIEJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool OHFMGPNFCED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool NLDHNKPBBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float APFOANFCPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int PKKJHOACGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool AMPIEILFCED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int FDALOFMCCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<BJPEKJEJMDP> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NCCCFANDMKG : FAJNHGLIEJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MHAOGNKGHGG LNCENEGLLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool KLAMCGGHIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AAOAKJBIBDD
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KELDHIPLCLM KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NCGBBBLEHNH MMOGMNEOHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface FAJNHGLIEJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool JJIPHIGBCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool JLGPJACOEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KELDHIPLCLM KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	float DJAIJJDJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 PDGEDGJIFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OIEDBBAJKGM LADIBGELDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	OADCHAEGGGG CFHJFNCCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FGHBOIBBOIN
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	int IGNDAHLEFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Transform BADDMANAJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OPNJFDNNIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MJJHKNIAGMD GetBone(int MCGKIOCGDEM);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MCGKIOCGDEM);
}
namespace Cpp2IlInjected;

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
