using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Foundation.Mathematics;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GLEHMJCABBO
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
public enum BCGPGMMDBCL
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
public enum OFHALCNGFPA
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
public enum JNMEENCBCLH
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
public enum DLNBBOCFFAG
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
public enum IEBHIHOELNJ
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
public static class PCBLPONHHIB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69D32B0", Offset = "0x69D1AB0", VA = "0x1869D32B0")]
	public static bool LKCIBJHOAAE(this IEBHIHOELNJ KPPPDNJJLCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69D3270", Offset = "0x69D1A70", VA = "0x1869D3270")]
	public static bool FBPCBEMGPMF(this IEBHIHOELNJ KPPPDNJJLCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D3280", Offset = "0x69D1A80", VA = "0x1869D3280")]
	public static bool FKKNDLMDACB(this IEBHIHOELNJ KPPPDNJJLCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ONPJCPBADJL
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
public struct MLKBGMAKIDL : DIAIPOOLIIL, IEquatable<MLKBGMAKIDL>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A710", VA = "0x180A7BF10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int GIOOEBIGKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A290", VA = "0x18255BA90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9A30", Offset = "0x5CA8230", VA = "0x185CA9A30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OONANGMADII
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69D3020", Offset = "0x69D1820", VA = "0x1869D3020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8380", Offset = "0x1EB6B80", VA = "0x181EB8380", Slot = "8")]
	public bool Equals(MLKBGMAKIDL OKGBBGMIACH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6896FD0", Offset = "0x68957D0", VA = "0x186896FD0")]
	public static bool HFGDCBGDPAJ(MLKBGMAKIDL MLFGLJKBOIG, MLKBGMAKIDL GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69D3060", Offset = "0x69D1860", VA = "0x1869D3060", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69D3100", Offset = "0x69D1900", VA = "0x1869D3100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DFACHJINGOG : DIAIPOOLIIL, IEquatable<DFACHJINGOG>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A710", VA = "0x180A7BF10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int GIOOEBIGKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A290", VA = "0x18255BA90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9A30", Offset = "0x5CA8230", VA = "0x185CA9A30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OONANGMADII
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69CE940", Offset = "0x69CD140", VA = "0x1869CE940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8380", Offset = "0x1EB6B80", VA = "0x181EB8380", Slot = "8")]
	public bool Equals(DFACHJINGOG OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69CE980", Offset = "0x69CD180", VA = "0x1869CE980", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69CEA20", Offset = "0x69CD220", VA = "0x1869CEA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OEILPCMNMIM : DIAIPOOLIIL, IEquatable<OEILPCMNMIM>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A710", VA = "0x180A7BF10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GIOOEBIGKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A290", VA = "0x18255BA90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9A30", Offset = "0x5CA8230", VA = "0x185CA9A30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OONANGMADII
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69D3190", Offset = "0x69D1990", VA = "0x1869D3190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8380", Offset = "0x1EB6B80", VA = "0x181EB8380", Slot = "8")]
	public bool Equals(OEILPCMNMIM OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69D31D0", Offset = "0x69D19D0", VA = "0x1869D31D0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OICKCGJIHKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCMGEGKOHJK(MLKBGMAKIDL GFFCILHEGII, BCGPGMMDBCL AHGKEHOFKKH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCMGEGKOHJK(DFACHJINGOG ACDOKGKGEAH, BCGPGMMDBCL AHGKEHOFKKH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPGCKMHDMFD(DFACHJINGOG ACDOKGKGEAH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILHANECOLFL(DFACHJINGOG ACDOKGKGEAH);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBLABBPIGGD();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGKNNOPDHFJ(BCGPGMMDBCL NCMHJNKFAGH);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLPOHMCKCFJ(MLKBGMAKIDL GFFCILHEGII);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLPOHMCKCFJ(DFACHJINGOG ACDOKGKGEAH);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBKEAILBEHO(DFACHJINGOG ACDOKGKGEAH);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BHHDEKIONCI(DFACHJINGOG ACDOKGKGEAH);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CLHPAKEIDBL();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BHFPCEHKKHG();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BCNEHPCDJFA(MLKBGMAKIDL GFFCILHEGII, DLNBBOCFFAG NCMHJNKFAGH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KILPDLNJGFC(DFACHJINGOG ACDOKGKGEAH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CJEDBHFFAPJ(DFACHJINGOG ACDOKGKGEAH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IMPCLOLIJGL();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KHHFDKFDOHP(DLNBBOCFFAG NCMHJNKFAGH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BDCKLHLCDEH(MLKBGMAKIDL GFFCILHEGII, Vector3 IMFHJKONPLO, Vector3 CGEGHPCEEPB, Vector3 JJKINFNBIGD, float IPHGJKPJEKH, float IGJBKHLBCJP, IReadOnlyList<Camera> EMKPNBNBDHC, GLEHMJCABBO BOIMHFMOJGM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BDCKLHLCDEH(OEILPCMNMIM DPLLCFMJBCC, Vector3 IMFHJKONPLO, Vector3 CGEGHPCEEPB, Vector3 JJKINFNBIGD, float IPHGJKPJEKH, float IGJBKHLBCJP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BLBNGBCAMCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GMFGDAOOAPF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLKBGMAKIDL EGFOAFHEGIN(KNKFOKKDPJH LINJEFIAFHO);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLKBGMAKIDL EGFOAFHEGIN(KNKFOKKDPJH LINJEFIAFHO, bool MGCNGDDFHDJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAECFGODDGB(MLKBGMAKIDL GFFCILHEGII);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOPFFNNEJJG(MLKBGMAKIDL GFFCILHEGII);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DFACHJINGOG NGBKMPGDDCO(MLKBGMAKIDL GFFCILHEGII, DODMHNDLIJN LINJEFIAFHO);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DFACHJINGOG LDLOEJGPNMP(MLKBGMAKIDL GFFCILHEGII, ICDKJPEMOMI LINJEFIAFHO);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OAEDBGFLANO(DFACHJINGOG ACDOKGKGEAH);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LMDNANABPIF(DFACHJINGOG ACDOKGKGEAH);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OEILPCMNMIM EGPLOBCDDHG(EEHGAPNFENO LINJEFIAFHO);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MMMNAHKOJPJ(OEILPCMNMIM DPLLCFMJBCC);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ALFKJPFPFJO(OEILPCMNMIM DPLLCFMJBCC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task EENDBIJFODK();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task OCDKPEAMHIM();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task BOKOABJIGCK();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BDDPJPKPNHE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> PDLGPHCIIGD(MLKBGMAKIDL GFFCILHEGII);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BECNFBKAHBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum HFGNCGNGMBC
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum JCBPOMFHMED
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum NOCOIGLGFDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum NDPLFMGMHOP
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Disable_NormTanF16MatUi8,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Force_NormTanF16MatUi8,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Force_NormTanSn8UvMatF16
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum PEBFLFEFAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum EDKPHGNINLI
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Quest3,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		MemoryBuild,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int DHKMBJJIKDG;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int KMNBLKLJNBF;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int PDEOFJBKDAC;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int ICKJKLGILKG;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static int[] KEFLFLLFDAO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static int KHJIFPBHAML;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static int DGPBHELHJME;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static int OFOGLCIBGAF;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long MDJHBJBOJLO;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long IGBNKOFHNIB;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long IMIPDNFEELF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long BCEONNOBJMM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long LBOHEDHBPMM;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long KIEDGKFMEMO;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long MLBPEJDBGHC;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long BFMKEJHOBMG;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static long DDFONLCGKDI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static long HPGHCPINPFH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long NHEPNOOPLBF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long OMIMFFIDLKH;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static long ABAPLJOHIIE;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static long OEPMNACJLJL;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float JEHPMIFGOLM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long IBFEHFGKAOK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long LMJJPGJGHFI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool FANPIKHHGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69CC9D0", Offset = "0x69CB1D0", VA = "0x1869CC9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69CC800", Offset = "0x69CB000", VA = "0x1869CC800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static EDKPHGNINLI HBLPEIGAKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x69CCC30", Offset = "0x69CB430", VA = "0x1869CCC30")]
		[CompilerGenerated]
		get
		{
			return default(EDKPHGNINLI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x69CB760", Offset = "0x69C9F60", VA = "0x1869CB760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool NNOLNFMHLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69CC430", Offset = "0x69CAC30", VA = "0x1869CC430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x69CBA00", Offset = "0x69CA200", VA = "0x1869CBA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool KEBIHGDJCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69CBB90", Offset = "0x69CA390", VA = "0x1869CBB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x69CB940", Offset = "0x69CA140", VA = "0x1869CB940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static HFGNCGNGMBC KNGCPOCMIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69CD3F0", Offset = "0x69CBBF0", VA = "0x1869CD3F0")]
		[CompilerGenerated]
		get
		{
			return default(HFGNCGNGMBC);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69CBA60", Offset = "0x69CA260", VA = "0x1869CBA60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool JHPGHPKKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x69CCBE0", Offset = "0x69CB3E0", VA = "0x1869CCBE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x69CD530", Offset = "0x69CBD30", VA = "0x1869CD530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static JCBPOMFHMED AMBDDPLHPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x69CC7B0", Offset = "0x69CAFB0", VA = "0x1869CC7B0")]
		[CompilerGenerated]
		get
		{
			return default(JCBPOMFHMED);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69CBE00", Offset = "0x69CA600", VA = "0x1869CBE00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool DBBJDFINEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69CCEF0", Offset = "0x69CB6F0", VA = "0x1869CCEF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69CCB80", Offset = "0x69CB380", VA = "0x1869CCB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool BKMBPCMCNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69CD4E0", Offset = "0x69CBCE0", VA = "0x1869CD4E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x69CC630", Offset = "0x69CAE30", VA = "0x1869CC630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool IFKHBNGBDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69CC4D0", Offset = "0x69CACD0", VA = "0x1869CC4D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x69CC860", Offset = "0x69CB060", VA = "0x1869CC860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static float CGJKAEIBMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x69CD490", Offset = "0x69CBC90", VA = "0x1869CD490")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69CD650", Offset = "0x69CBE50", VA = "0x1869CD650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int JEFGBKLGNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69CBCF0", Offset = "0x69CA4F0", VA = "0x1869CBCF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x69CC5D0", Offset = "0x69CADD0", VA = "0x1869CC5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int KHDNECLLDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x69CBF10", Offset = "0x69CA710", VA = "0x1869CBF10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x69CC190", Offset = "0x69CA990", VA = "0x1869CC190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int ODJAIEPMIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x69CC140", Offset = "0x69CA940", VA = "0x1869CC140")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x69CC8C0", Offset = "0x69CB0C0", VA = "0x1869CC8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int COEDIDJGNAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x69CCFF0", Offset = "0x69CB7F0", VA = "0x1869CCFF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x69CD2B0", Offset = "0x69CBAB0", VA = "0x1869CD2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int MMELOIABDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69CCB30", Offset = "0x69CB330", VA = "0x1869CCB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69CD200", Offset = "0x69CBA00", VA = "0x1869CD200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int IMHKAPIJOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x69CC920", Offset = "0x69CB120", VA = "0x1869CC920")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69CD100", Offset = "0x69CB900", VA = "0x1869CD100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int FNLDIJFKKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69CC0F0", Offset = "0x69CA8F0", VA = "0x1869CC0F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69CC030", Offset = "0x69CA830", VA = "0x1869CC030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int KOEKLMIHCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69CC480", Offset = "0x69CAC80", VA = "0x1869CC480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69CBC30", Offset = "0x69CA430", VA = "0x1869CBC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int CCCPCBPLGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69CC580", Offset = "0x69CAD80", VA = "0x1869CC580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69CC750", Offset = "0x69CAF50", VA = "0x1869CC750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int KDANGLHBOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69CCE50", Offset = "0x69CB650", VA = "0x1869CCE50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69CB6B0", Offset = "0x69C9EB0", VA = "0x1869CB6B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int LIKCBGIMLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69CBEC0", Offset = "0x69CA6C0", VA = "0x1869CBEC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69CBE60", Offset = "0x69CA660", VA = "0x1869CBE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int NPOONKPIMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x69CB710", Offset = "0x69C9F10", VA = "0x1869CB710")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x69CB9A0", Offset = "0x69CA1A0", VA = "0x1869CB9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int EALENGBBEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69CBBE0", Offset = "0x69CA3E0", VA = "0x1869CBBE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69CB820", Offset = "0x69CA020", VA = "0x1869CB820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static int JBKNLKACCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69CCFA0", Offset = "0x69CB7A0", VA = "0x1869CCFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69CE300", Offset = "0x69CCB00", VA = "0x1869CE300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static int GLPPKMKHNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x69CCCE0", Offset = "0x69CB4E0", VA = "0x1869CCCE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69CCAD0", Offset = "0x69CB2D0", VA = "0x1869CCAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool PHMFGMJOHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69CC360", Offset = "0x69CAB60", VA = "0x1869CC360")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69CD590", Offset = "0x69CBD90", VA = "0x1869CD590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool EOAIBAKMIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69CC250", Offset = "0x69CAA50", VA = "0x1869CC250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69CCDF0", Offset = "0x69CB5F0", VA = "0x1869CCDF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static NOCOIGLGFDA OBGNNFGGOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69CD260", Offset = "0x69CBA60", VA = "0x1869CD260")]
		[CompilerGenerated]
		get
		{
			return default(NOCOIGLGFDA);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69CD0A0", Offset = "0x69CB8A0", VA = "0x1869CD0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static NDPLFMGMHOP HJPFINABPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69CCA20", Offset = "0x69CB220", VA = "0x1869CCA20")]
		[CompilerGenerated]
		get
		{
			return default(NDPLFMGMHOP);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69CC300", Offset = "0x69CAB00", VA = "0x1869CC300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static bool PCNIAKNFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69CD160", Offset = "0x69CB960", VA = "0x1869CD160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69CC690", Offset = "0x69CAE90", VA = "0x1869CC690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float OBPDKHBJMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69CD1B0", Offset = "0x69CB9B0", VA = "0x1869CD1B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69CBB30", Offset = "0x69CA330", VA = "0x1869CBB30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float HAACHOOJHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69CCEA0", Offset = "0x69CB6A0", VA = "0x1869CCEA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69CBC90", Offset = "0x69CA490", VA = "0x1869CBC90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float FKPDNBOKNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69CE2B0", Offset = "0x69CCAB0", VA = "0x1869CE2B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69CC6F0", Offset = "0x69CAEF0", VA = "0x1869CC6F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static float IAFHHKFJOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69CD440", Offset = "0x69CBC40", VA = "0x1869CD440")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x69CCF40", Offset = "0x69CB740", VA = "0x1869CCF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float LDBPPNKBBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69CB8E0", Offset = "0x69CA0E0", VA = "0x1869CB8E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69CC1F0", Offset = "0x69CA9F0", VA = "0x1869CC1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float MMDGLLLCAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69CCD90", Offset = "0x69CB590", VA = "0x1869CCD90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69CE250", Offset = "0x69CCA50", VA = "0x1869CE250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static bool PAONECAFDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x69CC090", Offset = "0x69CA890", VA = "0x1869CC090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x69CBD40", Offset = "0x69CA540", VA = "0x1869CBD40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float PPNNIJNLFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69CD040", Offset = "0x69CB840", VA = "0x1869CD040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69CCD30", Offset = "0x69CB530", VA = "0x1869CCD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int ELMBLBHDMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69CBFD0", Offset = "0x69CA7D0", VA = "0x1869CBFD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69CB7C0", Offset = "0x69C9FC0", VA = "0x1869CB7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int MNCHCKEFDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69CCC80", Offset = "0x69CB480", VA = "0x1869CCC80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69CC520", Offset = "0x69CAD20", VA = "0x1869CC520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool FPKMIFMENNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69CC2A0", Offset = "0x69CAAA0", VA = "0x1869CC2A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int LNGOFOHPHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69CB880", Offset = "0x69CA080", VA = "0x1869CB880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x69CAFB0", Offset = "0x69C97B0", VA = "0x1869CAFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int CAFBNEIOHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69CD390", Offset = "0x69CBB90", VA = "0x1869CD390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static float4x4 JGIANLIPLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69CD310", Offset = "0x69CBB10", VA = "0x1869CD310")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69CC3B0", Offset = "0x69CABB0", VA = "0x1869CC3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static float3 AIBLPCMPBNM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69CBF60", Offset = "0x69CA760", VA = "0x1869CBF60")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x69CBAC0", Offset = "0x69CA2C0", VA = "0x1869CBAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool KABONCHJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x69CD5F0", Offset = "0x69CBDF0", VA = "0x1869CD5F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69CCA70", Offset = "0x69CB270", VA = "0x1869CCA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static PEBFLFEFAKJ IGPBNNKFEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69CC970", Offset = "0x69CB170", VA = "0x1869CC970")]
		[CompilerGenerated]
		get
		{
			return default(PEBFLFEFAKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69CBDA0", Offset = "0x69CA5A0", VA = "0x1869CBDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69CD6B0", Offset = "0x69CBEB0", VA = "0x1869CD6B0")]
	public static void PHNLAMMKICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69CB010", Offset = "0x69C9810", VA = "0x1869CB010")]
	public static void ADHJMHFODNL(EDKPHGNINLI HDCBNAHLGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DMGIIAEMJMG
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct KHPAAHKJFOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector3 PHJFFHJCDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Quaternion OILJGEIJHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float GCPNMPPNPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public Quaternion CJHLHKLLMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float NPOOAPANNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float EIIKLNCJMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float BGENEKBHLKH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static List<KHPAAHKJFOO> EGHOBCKCHNC;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x69CF230", Offset = "0x69CDA30", VA = "0x1869CF230")]
	public static NativeList<BEEODNIICBD> JLCJLNFLKAG(HJDCABNHDIJ OGHLFHGIOLB)
	{
		return default(NativeList<BEEODNIICBD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x69D0C90", Offset = "0x69CF490", VA = "0x1869D0C90")]
	private static bool ONEIPOCLHKC(int HCDMGOGKHKP, NativeList<BEEODNIICBD> ADPMAHMCGNH, List<KHPAAHKJFOO> DPJDJKECOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69CEFC0", Offset = "0x69CD7C0", VA = "0x1869CEFC0")]
	private static BEEODNIICBD FLDHBJIIHCI(int AFLJKADDJPM, List<KHPAAHKJFOO> DPJDJKECOOD)
	{
		return default(BEEODNIICBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x69CEAB0", Offset = "0x69CD2B0", VA = "0x1869CEAB0")]
	private static BEEODNIICBD EPDOHHOKNNL(int AFLJKADDJPM, List<KHPAAHKJFOO> DPJDJKECOOD)
	{
		return default(BEEODNIICBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x69CF150", Offset = "0x69CD950", VA = "0x1869CF150")]
	private static BEEODNIICBD JFMMIHLCINA(Vector3 BCPGICOCGEJ, Quaternion OBKMAHDAHKH, float EOGPEOAFBNO)
	{
		return default(BEEODNIICBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69CF7C0", Offset = "0x69CDFC0", VA = "0x1869CF7C0")]
	public static NativeList<BEEODNIICBD> KLPNFDIDBPI(HJDCABNHDIJ OGHLFHGIOLB, float JIBIPLAADBH)
	{
		return default(NativeList<BEEODNIICBD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HEGPGCJBIAA
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static Vector3 GBOBGPLILAE;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static Vector3 EFMMEDPFAFN;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static readonly float GKFKOFFAFIM;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69D2260", Offset = "0x69D0A60", VA = "0x1869D2260")]
	public static Vector3 BJHHJIOACEL(Vector3 BHNGLOCPLGO, Quaternion OBKMAHDAHKH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x69D27E0", Offset = "0x69D0FE0", VA = "0x1869D27E0")]
	public static Vector3 HMPJBEIGDAK(Quaternion LCDJINCAHMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x69D2880", Offset = "0x69D1080", VA = "0x1869D2880")]
	public static Vector3 KHPJLEKLDHP(Quaternion LCDJINCAHMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x69D2D50", Offset = "0x69D1550", VA = "0x1869D2D50")]
	public static Quaternion MBFDFPHMJJK(Vector3 FCBGHELDCII, Vector3 NFFLDAHKGKD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69D1D00", Offset = "0x69D0500", VA = "0x1869D1D00")]
	public static Vector3 AMALFGLCPJP(Vector3 KHMBPPCCHGJ, Vector3 PDBJHIONEPH, Vector3 NFFLDAHKGKD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x69D2920", Offset = "0x69D1120", VA = "0x1869D2920")]
	public static Vector3 LOHFOIMIAGG(Vector3 BHNGLOCPLGO, Vector3 NFFLDAHKGKD, Quaternion LCDJINCAHMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69D1EF0", Offset = "0x69D06F0", VA = "0x1869D1EF0")]
	public static Quaternion BGEHGABABNH(Quaternion OBKMAHDAHKH, Vector3 FCBGHELDCII)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x69D2DD0", Offset = "0x69D15D0", VA = "0x1869D2DD0")]
	public static bool PCGMIFOAOAH(Vector3 PBBOONBHDAP, Vector3 FPNGLFGNLBG, [Out] Vector3 AKIMOBCHKEL, bool AADLGACDKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x69D24F0", Offset = "0x69D0CF0", VA = "0x1869D24F0")]
	public static Vector3 HEHGKDKKNIP(bool KCMIAILHIFF, [Optional] Quaternion ENEEHHKMEIG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BEEODNIICBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public float3 PHJFFHJCDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public float3x3 OILJGEIJHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public float GCPNMPPNPJC;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HJDCABNHDIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	int PKKAKJDFJNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 IKIFEHDGBLA(int AFLJKADDJPM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion MIEEFLBBHBB(int AFLJKADDJPM);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float NODABNJNJCN(int AFLJKADDJPM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ICDKJPEMOMI : LPFKFCCPALI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool OEICEMKGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool GBFDLNFNCIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	float LKDKEBPPAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	int DLLOJPMECJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool BHAIFHFMEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int BJHENOJKLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<BEEODNIICBD> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DODMHNDLIJN : LPFKFCCPALI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OFHALCNGFPA JGAFFEKCAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool ABEIGIPCBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float3 IJOGEAGFJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KNKFOKKDPJH
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	HLEMAOPCIDE IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	JNMEENCBCLH IGMMMJLCHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LPFKFCCPALI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool MPNFNOKNOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool MLDOFBHFBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	HLEMAOPCIDE IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	UniformTRS KBCPJCDBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float KFJEHKPDOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Vector3 IOBKMFFMDIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	IEBHIHOELNJ KOOLALKIFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	ONPJCPBADJL DNFEJFKJLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EEHGAPNFENO
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int BCNHDFMELFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Transform BPCMOEDHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool NAMBHKKAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLKBGMAKIDL GetBone(int AFLJKADDJPM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int AFLJKADDJPM);
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
