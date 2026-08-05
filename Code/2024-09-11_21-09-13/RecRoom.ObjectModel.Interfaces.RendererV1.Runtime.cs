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
public enum JDEOPKDIACG
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
public enum CEKFCLEOOAA
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
public enum DIKIEBBPIBF
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
public enum BADNOLJPPEK
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
public enum IMLALIAHABD
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
public enum MNJGJKEDHBM
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
public static class AEFGCHGHKHE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C702D0", Offset = "0x6C6E8D0", VA = "0x186C702D0")]
	public static bool HMFDKEDGLCH(this MNJGJKEDHBM KDLMAHAJHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C702F0", Offset = "0x6C6E8F0", VA = "0x186C702F0")]
	public static bool OLPMCOAJNNL(this MNJGJKEDHBM KDLMAHAJHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C702A0", Offset = "0x6C6E8A0", VA = "0x186C702A0")]
	public static bool DMDKIGKKIPD(this MNJGJKEDHBM KDLMAHAJHMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KLGCHNJKBIE
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
public struct CEFBENDABAG : EOIFKCNADCO, IEquatable<CEFBENDABAG>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int MFBBLPJBOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2669630", Offset = "0x2667C30", VA = "0x182669630", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F41DD0", Offset = "0x5F403D0", VA = "0x185F41DD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OGCLLAHCFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C715F0", Offset = "0x6C6FBF0", VA = "0x186C715F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1FADE90", Offset = "0x1FAC490", VA = "0x181FADE90", Slot = "8")]
	public bool Equals(CEFBENDABAG PLNBHPCFEOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BF80", Offset = "0x6B2A580", VA = "0x186B2BF80")]
	public static bool KIKJPCCIIDN(CEFBENDABAG MOKDKAEJAPP, CEFBENDABAG MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C71630", Offset = "0x6C6FC30", VA = "0x186C71630", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C716C0", Offset = "0x6C6FCC0", VA = "0x186C716C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PFBKIGNHCNM : EOIFKCNADCO, IEquatable<PFBKIGNHCNM>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int MFBBLPJBOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2669630", Offset = "0x2667C30", VA = "0x182669630", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5F41DD0", Offset = "0x5F403D0", VA = "0x185F41DD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OGCLLAHCFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C78C50", Offset = "0x6C77250", VA = "0x186C78C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FADE90", Offset = "0x1FAC490", VA = "0x181FADE90", Slot = "8")]
	public bool Equals(PFBKIGNHCNM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C78C90", Offset = "0x6C77290", VA = "0x186C78C90", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C78D20", Offset = "0x6C77320", VA = "0x186C78D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OLOMCLKAJLN : EOIFKCNADCO, IEquatable<OLOMCLKAJLN>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MFBBLPJBOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2669630", Offset = "0x2667C30", VA = "0x182669630", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5F41DD0", Offset = "0x5F403D0", VA = "0x185F41DD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OGCLLAHCFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C78B80", Offset = "0x6C77180", VA = "0x186C78B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FADE90", Offset = "0x1FAC490", VA = "0x181FADE90", Slot = "8")]
	public bool Equals(OLOMCLKAJLN PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C78BC0", Offset = "0x6C771C0", VA = "0x186C78BC0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C2E0", VA = "0x18094DCE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CGKOFOPGADE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNCMMGIEJPP(CEFBENDABAG JPBBEMPIGCM, CEKFCLEOOAA IFNKPCOLBOF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNCMMGIEJPP(PFBKIGNHCNM CICGHDIEJHI, CEKFCLEOOAA IFNKPCOLBOF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHLCBEDLPBH(PFBKIGNHCNM CICGHDIEJHI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOBOKDIHOFP(PFBKIGNHCNM CICGHDIEJHI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFGLHENPNAL();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGHHGFFPHCM(CEKFCLEOOAA JLAAKHANEHC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICCOFFKHLNE(CEFBENDABAG JPBBEMPIGCM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ICCOFFKHLNE(PFBKIGNHCNM CICGHDIEJHI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OLMENNELCKA(PFBKIGNHCNM CICGHDIEJHI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void INHHKJGDFBF(PFBKIGNHCNM CICGHDIEJHI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PCHGFNMLAKA();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KBKBDMECOJJ();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IMBBLJNPHHA(CEFBENDABAG JPBBEMPIGCM, IMLALIAHABD JLAAKHANEHC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MJMFHNEJNNC(PFBKIGNHCNM CICGHDIEJHI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GIBEPMAGHPI(PFBKIGNHCNM CICGHDIEJHI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KBBEIOCICIF();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EBNKJFIELNB(IMLALIAHABD JLAAKHANEHC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KGAMJEOAINN(CEFBENDABAG JPBBEMPIGCM, Vector3 LAMFKJDOOGB, Vector3 JJLHPABKFIF, Vector3 HMJIBDEFLEB, float MPBLCNAKEPE, float NHIPNFOIHAM, IReadOnlyList<Camera> GOMIOHNDHBK, JDEOPKDIACG BAINLMIMOJN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KGAMJEOAINN(OLOMCLKAJLN FGDDBCKAJKG, Vector3 LAMFKJDOOGB, Vector3 JJLHPABKFIF, Vector3 HMJIBDEFLEB, float MPBLCNAKEPE, float NHIPNFOIHAM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JHKJKNJJHAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LJAEFBAEMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI, bool KILBIOBNJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOLBMFGOJBP(CEFBENDABAG JPBBEMPIGCM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FLODNCANFJC(CEFBENDABAG JPBBEMPIGCM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PFBKIGNHCNM NLDGECDOCNG(CEFBENDABAG JPBBEMPIGCM, AHOEJDMJOPP JGCMECODHDI);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PFBKIGNHCNM MDGNMILNPAJ(CEFBENDABAG JPBBEMPIGCM, CNNALMNKJOG JGCMECODHDI);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OAJPFGLFGLA(PFBKIGNHCNM CICGHDIEJHI);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONPAEGBAAEO(PFBKIGNHCNM CICGHDIEJHI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OLOMCLKAJLN AODPAKMGMKI(FPCIEBLEOIF JGCMECODHDI);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NIGEHPCNNOH(OLOMCLKAJLN FGDDBCKAJKG);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OCJPAOHBBAG(OLOMCLKAJLN FGDDBCKAJKG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task EKMBMMBEKFL();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task BMJMGCBHIFP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task ECGGHPDMJDP();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NILOHBICFHG();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> EMEKHHAELFC(CEFBENDABAG JPBBEMPIGCM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NLAECODBCON
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum FCBMNKEPNLK
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum MMHPGGMKCJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum FDDCKDBHBDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum JLBGBEMBMKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum FEEFCIPEJKL
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum CDHEIJODNHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Quest3,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		MemoryBuild,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static int BEAFJGPFHDI;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static int FCJJONDMOGG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static int KNNJBOCBJFC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static int HNMIFGPPIKA;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static int[] MPMJJEGKHOF;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static int CMOBCHCOIEC;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static int CBOIBMFCPJE;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static int CLELOOOEGFP;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static int DCJBBJBEMPK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long KOBJMNDDNPL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long CMEMOKHKLOF;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static long HKPNBCNIKFC;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static long PHFGOFLACLD;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static long LHLOFDJFIPL;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long LJIJJHPOMPC;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long LDPEDBMPBKI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static long CPKEOPICIEF;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long NNPGBNEMECK;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static long BEKMKOLNEIC;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static long MFFGHNIJMJJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static long PJAHBICOFMA;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static long ELNNGDMIGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static long KPLPFNBIPPO;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static float NBAKGDPGAEJ;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long PCIHMBDPBNP;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static long ELJADLMFCKO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static long OHBJGAEPLAD;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static long JLGFAJEMNFG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float OJEHHGDJABN;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static long CJMPDOEBFJP;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static long DOGGHOPHPHP;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long JOOJAMGOCHA;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long FMILAONJGGE;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long ABPEGPODFKI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool PNCHGODPGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C76F90", Offset = "0x6C75590", VA = "0x186C76F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C76790", Offset = "0x6C74D90", VA = "0x186C76790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static CDHEIJODNHE OJBEMHCJFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C781D0", Offset = "0x6C767D0", VA = "0x186C781D0")]
		[CompilerGenerated]
		get
		{
			return default(CDHEIJODNHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C74C00", Offset = "0x6C73200", VA = "0x186C74C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool ALAGEIDOHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C75350", Offset = "0x6C73950", VA = "0x186C75350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C77E70", Offset = "0x6C76470", VA = "0x186C77E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool FIJMBKIIKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C78020", Offset = "0x6C76620", VA = "0x186C78020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C77E10", Offset = "0x6C76410", VA = "0x186C77E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static FCBMNKEPNLK OJHBHFBCMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C75050", Offset = "0x6C73650", VA = "0x186C75050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CCLIEDBDDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C74BB0", Offset = "0x6C731B0", VA = "0x186C74BB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C74F50", Offset = "0x6C73550", VA = "0x186C74F50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static MMHPGGMKCJA CAOLDPMLMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C74DF0", Offset = "0x6C733F0", VA = "0x186C74DF0")]
		[CompilerGenerated]
		get
		{
			return default(MMHPGGMKCJA);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C752A0", Offset = "0x6C738A0", VA = "0x186C752A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool KKFNIEGEHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C75540", Offset = "0x6C73B40", VA = "0x186C75540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C783D0", Offset = "0x6C769D0", VA = "0x186C783D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool MCEPIPOBPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C74DA0", Offset = "0x6C733A0", VA = "0x186C74DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C77F20", Offset = "0x6C76520", VA = "0x186C77F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool KNKDNPLKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C76F40", Offset = "0x6C75540", VA = "0x186C76F40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C751F0", Offset = "0x6C737F0", VA = "0x186C751F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static float LKJJBBFLJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6C75250", Offset = "0x6C73850", VA = "0x186C75250")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C74B50", Offset = "0x6C73150", VA = "0x186C74B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int PGKABBJEOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C75450", Offset = "0x6C73A50", VA = "0x186C75450")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C77ED0", Offset = "0x6C764D0", VA = "0x186C77ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int AFCNPMNBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C755E0", Offset = "0x6C73BE0", VA = "0x186C755E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C75FE0", Offset = "0x6C745E0", VA = "0x186C75FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int PJEPHEFHGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C76AB0", Offset = "0x6C750B0", VA = "0x186C76AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C766F0", Offset = "0x6C74CF0", VA = "0x186C766F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int CIIAIJEHHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C77F80", Offset = "0x6C76580", VA = "0x186C77F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C74D50", Offset = "0x6C73350", VA = "0x186C74D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int ONLDLOMKIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C76D70", Offset = "0x6C75370", VA = "0x186C76D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6C76DC0", Offset = "0x6C753C0", VA = "0x186C76DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int MICGILPBFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C77D70", Offset = "0x6C76370", VA = "0x186C77D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C76D20", Offset = "0x6C75320", VA = "0x186C76D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static float BNNGFFFGBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C763D0", Offset = "0x6C749D0", VA = "0x186C763D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C75680", Offset = "0x6C73C80", VA = "0x186C75680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int EKEKKLJPNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C74CB0", Offset = "0x6C732B0", VA = "0x186C74CB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C76B00", Offset = "0x6C75100", VA = "0x186C76B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int DEPAMGDGNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C75400", Offset = "0x6C73A00", VA = "0x186C75400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C75590", Offset = "0x6C73B90", VA = "0x186C75590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int ONIPHDEADPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C74A00", Offset = "0x6C73000", VA = "0x186C74A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C76590", Offset = "0x6C74B90", VA = "0x186C76590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static float PABFMIJFNFO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C76640", Offset = "0x6C74C40", VA = "0x186C76640")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C76320", Offset = "0x6C74920", VA = "0x186C76320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float MEHIGCMNBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C76E10", Offset = "0x6C75410", VA = "0x186C76E10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C78370", Offset = "0x6C76970", VA = "0x186C78370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float HHOPFDIGOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C75140", Offset = "0x6C73740", VA = "0x186C75140")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C76CC0", Offset = "0x6C752C0", VA = "0x186C76CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool LBKIHOPCHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C76280", Offset = "0x6C74880", VA = "0x186C76280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C74AA0", Offset = "0x6C730A0", VA = "0x186C74AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static int BFLDDHJCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C75000", Offset = "0x6C73600", VA = "0x186C75000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6C761E0", Offset = "0x6C747E0", VA = "0x186C761E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static int PGJHHBKHNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C760E0", Offset = "0x6C746E0", VA = "0x186C760E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6C76230", Offset = "0x6C74830", VA = "0x186C76230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static int HJAOLOMENGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C750F0", Offset = "0x6C736F0", VA = "0x186C750F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6C754A0", Offset = "0x6C73AA0", VA = "0x186C754A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int BLFOCPOEFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C74D00", Offset = "0x6C73300", VA = "0x186C74D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C754F0", Offset = "0x6C73AF0", VA = "0x186C754F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static bool HCNKGIJAAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6C764F0", Offset = "0x6C74AF0", VA = "0x186C764F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C76B50", Offset = "0x6C75150", VA = "0x186C76B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static bool OMOJIAJBNIO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C76740", Offset = "0x6C74D40", VA = "0x186C76740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6C749A0", Offset = "0x6C72FA0", VA = "0x186C749A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float HEDEFJBFCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C76380", Offset = "0x6C74980", VA = "0x186C76380")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C78220", Offset = "0x6C76820", VA = "0x186C78220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static FDDCKDBHBDF CJBPKMJLIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C78320", Offset = "0x6C76920", VA = "0x186C78320")]
		[CompilerGenerated]
		get
		{
			return default(FDDCKDBHBDF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C77DC0", Offset = "0x6C763C0", VA = "0x186C77DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static JLBGBEMBMKH POOFBJMKELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C76C70", Offset = "0x6C75270", VA = "0x186C76C70")]
		[CompilerGenerated]
		get
		{
			return default(JLBGBEMBMKH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C78480", Offset = "0x6C76A80", VA = "0x186C78480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool PKFFJOJOPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C76030", Offset = "0x6C74630", VA = "0x186C76030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C76420", Offset = "0x6C74A20", VA = "0x186C76420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float CPLOJDFAFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C76540", Offset = "0x6C74B40", VA = "0x186C76540")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6C78120", Offset = "0x6C76720", VA = "0x186C78120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float MGICGONCKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6C782D0", Offset = "0x6C768D0", VA = "0x186C782D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C76E60", Offset = "0x6C75460", VA = "0x186C76E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float PIKLOFNLBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6C78070", Offset = "0x6C76670", VA = "0x186C78070")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C753A0", Offset = "0x6C739A0", VA = "0x186C753A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float MHLDEMIGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C76190", Offset = "0x6C74790", VA = "0x186C76190")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6C76C10", Offset = "0x6C75210", VA = "0x186C76C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static float AIGNIAHBACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C77FD0", Offset = "0x6C765D0", VA = "0x186C77FD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C76690", Offset = "0x6C74C90", VA = "0x186C76690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static float JAKCJCMKAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6C762D0", Offset = "0x6C748D0", VA = "0x186C762D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6C76990", Offset = "0x6C74F90", VA = "0x186C76990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool CLNBBHHJGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C78430", Offset = "0x6C76A30", VA = "0x186C78430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C780C0", Offset = "0x6C766C0", VA = "0x186C780C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static float LONBLNADLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C750A0", Offset = "0x6C736A0", VA = "0x186C750A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6C74C50", Offset = "0x6C73250", VA = "0x186C74C50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int DJEPGKPJIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6C78280", Offset = "0x6C76880", VA = "0x186C78280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C74EF0", Offset = "0x6C734F0", VA = "0x186C74EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static int KIPICPHEELC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C75630", Offset = "0x6C73C30", VA = "0x186C75630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6C76130", Offset = "0x6C74730", VA = "0x186C76130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool AMNIBAKPIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6C78180", Offset = "0x6C76780", VA = "0x186C78180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static int CDCFIDIBINA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6C74A50", Offset = "0x6C73050", VA = "0x186C74A50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6C768D0", Offset = "0x6C74ED0", VA = "0x186C768D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static int ACGLHOCCDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C765E0", Offset = "0x6C74BE0", VA = "0x186C765E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool KGKHPCNEEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C76830", Offset = "0x6C74E30", VA = "0x186C76830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6C74E40", Offset = "0x6C73440", VA = "0x186C74E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float OHGLLLMABEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6C767E0", Offset = "0x6C74DE0", VA = "0x186C767E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6C769F0", Offset = "0x6C74FF0", VA = "0x186C769F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float CGNBPLMPJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C74FB0", Offset = "0x6C735B0", VA = "0x186C74FB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C76A50", Offset = "0x6C75050", VA = "0x186C76A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float GJIDEPGKJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C76880", Offset = "0x6C74E80", VA = "0x186C76880")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C76BB0", Offset = "0x6C751B0", VA = "0x186C76BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static int JLOEBFEDCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C74B00", Offset = "0x6C73100", VA = "0x186C74B00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C76930", Offset = "0x6C74F30", VA = "0x186C76930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static float4x4 EHJIEJPNPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C76EC0", Offset = "0x6C754C0", VA = "0x186C76EC0")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C75F60", Offset = "0x6C74560", VA = "0x186C75F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float3 KNIGOLGPBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6C76480", Offset = "0x6C74A80", VA = "0x186C76480")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C75190", Offset = "0x6C73790", VA = "0x186C75190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static bool IAEEJNGOEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C784D0", Offset = "0x6C76AD0", VA = "0x186C784D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C76080", Offset = "0x6C74680", VA = "0x186C76080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static FEEFCIPEJKL KBPLCMOEHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C74EA0", Offset = "0x6C734A0", VA = "0x186C74EA0")]
		[CompilerGenerated]
		get
		{
			return default(FEEFCIPEJKL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C752F0", Offset = "0x6C738F0", VA = "0x186C752F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C76FE0", Offset = "0x6C755E0", VA = "0x186C76FE0")]
	public static void NMKBGFBOEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C756E0", Offset = "0x6C73CE0", VA = "0x186C756E0")]
	public static void GHELDAGOGDG(CDHEIJODNHE IDBGMBEOLKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IIKCCEDHIIF
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct EHFDENIEIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Vector3 EHFBMINIGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Quaternion BHOIDFFDPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float FMHJKFJFPFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public Quaternion ENLJPAMDHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public float JBBMEBKOIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float PPDKDPDGNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float JPJKCDMHGDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static List<EHFDENIEIBI> LDDKEHMDKJN;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C72C20", Offset = "0x6C71220", VA = "0x186C72C20")]
	public static NativeList<NNEBOAEPEKN> DNKHFFNKAOH(JPJGPMBJKJG ONLDJBALHME)
	{
		return default(NativeList<NNEBOAEPEKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C737B0", Offset = "0x6C71DB0", VA = "0x186C737B0")]
	private static bool NNDJMADDJGG(int DMIMFDDIIBO, NativeList<NNEBOAEPEKN> POBDLJBBBCI, List<EHFDENIEIBI> OPCJLEAJHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C74780", Offset = "0x6C72D80", VA = "0x186C74780")]
	private static NNEBOAEPEKN OKDKIGNCDBH(int LBBGOBFOJMO, List<EHFDENIEIBI> OPCJLEAJHPA)
	{
		return default(NNEBOAEPEKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C732A0", Offset = "0x6C718A0", VA = "0x186C732A0")]
	private static NNEBOAEPEKN HOLKLIDHDMK(int LBBGOBFOJMO, List<EHFDENIEIBI> OPCJLEAJHPA)
	{
		return default(NNEBOAEPEKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C731C0", Offset = "0x6C717C0", VA = "0x186C731C0")]
	private static NNEBOAEPEKN HIKMMDDBGPB(Vector3 NJELOECLOIL, Quaternion CNFFBLAHCCM, float PPAGJHCGANB)
	{
		return default(NNEBOAEPEKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C71750", Offset = "0x6C6FD50", VA = "0x186C71750")]
	public static NativeList<NNEBOAEPEKN> CJAEMFOHCCP(JPJGPMBJKJG ONLDJBALHME, float NNDGIKKJHBE)
	{
		return default(NativeList<NNEBOAEPEKN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BHKALDAPELK
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static Vector3 LGBMJPINFMD;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static Vector3 LJPOJLEENMK;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public static readonly float DFBLKMFPDGL;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C71010", Offset = "0x6C6F610", VA = "0x186C71010")]
	public static Vector3 KKBJLIOJPFL(Vector3 ANLFMDGEKEK, Quaternion CNFFBLAHCCM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C70AC0", Offset = "0x6C6F0C0", VA = "0x186C70AC0")]
	public static Vector3 CPNIECHNLME(Quaternion JOLHFCINNMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C71480", Offset = "0x6C6FA80", VA = "0x186C71480")]
	public static Vector3 ODCAMINOIEF(Quaternion JOLHFCINNMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C70B60", Offset = "0x6C6F160", VA = "0x186C70B60")]
	public static Quaternion DDLOHHCCCEB(Vector3 JFCINBHKCNC, Vector3 DBBPPLLNKOD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C71290", Offset = "0x6C6F890", VA = "0x186C71290")]
	public static Vector3 KLLGCNCJLJI(Vector3 AGIOLKIGEPF, Vector3 LPCOJFLFHNH, Vector3 DBBPPLLNKOD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C70BE0", Offset = "0x6C6F1E0", VA = "0x186C70BE0")]
	public static Vector3 GJNOMOGAMMJ(Vector3 ANLFMDGEKEK, Vector3 DBBPPLLNKOD, Quaternion JOLHFCINNMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6C70470", Offset = "0x6C6EA70", VA = "0x186C70470")]
	public static Quaternion ADCBIECDFCG(Quaternion CNFFBLAHCCM, Vector3 JFCINBHKCNC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6C70300", Offset = "0x6C6E900", VA = "0x186C70300")]
	public static bool ACKOFFHPLND(Vector3 PPEKHCKMONI, Vector3 MMFEGENFHPP, [Out] Vector3 DNAJPPCEHOF, bool GNJDNKJJLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6C707D0", Offset = "0x6C6EDD0", VA = "0x186C707D0")]
	public static Vector3 APKMKKLFHEB(bool MAMMDHCKMBC, [Optional] Quaternion ICIGHDANKPD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NNEBOAEPEKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float3 EHFBMINIGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public float3x3 BHOIDFFDPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public float FMHJKFJFPFN;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JPJGPMBJKJG
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int HDIPHNLKHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 AHGGHKBIGJK(int LBBGOBFOJMO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion DPFDECMOPNF(int LBBGOBFOJMO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float PAMIOFNFPJH(int LBBGOBFOJMO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CNNALMNKJOG : EEBLMCKNOFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool CCAEELGKCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool BLOCIDEICLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float OMHMGHIFBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int FPFPHJPPDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool JOMBMMLNDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int OJOIPCHIMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<NNEBOAEPEKN> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AHOEJDMJOPP : EEBLMCKNOFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	DIKIEBBPIBF NKBPNAJIOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FDLBGFFCPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float3 DFGAAKLDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OKDJKDPEEAA
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	OLHIMCMANHM MJIIFCFMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	BADNOLJPPEK KEEGOMEIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EEBLMCKNOFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool JAENMEJJKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool AFJFCPBEBPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	OLHIMCMANHM MJIIFCFMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	UniformTRS JPCFPMOFANC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float CABAFGDCJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 PLECNIBHCLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	MNJGJKEDHBM KAEMGNMBKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	KLGCHNJKBIE IPAJGOJJENM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FPCIEBLEOIF
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int EGNCMDPIICN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Transform IOLDPFJDKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool IEOJMCJKHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CEFBENDABAG GetBone(int LBBGOBFOJMO);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int LBBGOBFOJMO);
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
