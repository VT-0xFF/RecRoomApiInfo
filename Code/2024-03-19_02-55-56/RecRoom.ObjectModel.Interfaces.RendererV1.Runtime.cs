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
public enum DBOJNKGMLIK
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
public enum LHNKIGKONBG
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
public enum EFONDBBKCJM
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
public enum DEBGHCLLCCM
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
public enum FANDOAMEPOG
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
public enum JGMDHPBNOFM
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
public static class DCIEBPAHGEI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62505F0", Offset = "0x624F5F0", VA = "0x1862505F0")]
	public static bool GLMHHFOFAAI(this JGMDHPBNOFM CPEPDMLCKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6250610", Offset = "0x624F610", VA = "0x186250610")]
	public static bool PKPBFCNFMKE(this JGMDHPBNOFM CPEPDMLCKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62505C0", Offset = "0x624F5C0", VA = "0x1862505C0")]
	public static bool AEGACICCFPC(this JGMDHPBNOFM CPEPDMLCKGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KPJPNECGJII
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
public struct PGHBHKIGPIJ : PGCDLPDMIKN, IEquatable<PGHBHKIGPIJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int EDPEAEGJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x90D4B0", Offset = "0x90C4B0", VA = "0x18090D4B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int IINHLNHHHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2276720", Offset = "0x2275720", VA = "0x182276720", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x55D8B50", Offset = "0x55D7B50", VA = "0x1855D8B50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CJEPHDFADJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6257670", Offset = "0x6256670", VA = "0x186257670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1CEAA60", Offset = "0x1CE9A60", VA = "0x181CEAA60", Slot = "8")]
	public bool Equals(PGHBHKIGPIJ PJNBIAFGNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6191610", Offset = "0x6190610", VA = "0x186191610")]
	public static bool HNKADOHNPFO(PGHBHKIGPIJ ABLMDKMDGNE, PGHBHKIGPIJ AMHEHNHOGFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62576B0", Offset = "0x62566B0", VA = "0x1862576B0", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6257740", Offset = "0x6256740", VA = "0x186257740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GKDGKAIMIMI : PGCDLPDMIKN, IEquatable<GKDGKAIMIMI>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int EDPEAEGJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x90D4B0", Offset = "0x90C4B0", VA = "0x18090D4B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int IINHLNHHHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2276720", Offset = "0x2275720", VA = "0x182276720", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x55D8B50", Offset = "0x55D7B50", VA = "0x1855D8B50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CJEPHDFADJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6253860", Offset = "0x6252860", VA = "0x186253860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1CEAA60", Offset = "0x1CE9A60", VA = "0x181CEAA60", Slot = "8")]
	public bool Equals(GKDGKAIMIMI PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62538A0", Offset = "0x62528A0", VA = "0x1862538A0", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6253930", Offset = "0x6252930", VA = "0x186253930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PPHDHOCDDPD : PGCDLPDMIKN, IEquatable<PPHDHOCDDPD>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int EDPEAEGJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x90D4B0", Offset = "0x90C4B0", VA = "0x18090D4B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IINHLNHHHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2276720", Offset = "0x2275720", VA = "0x182276720", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55D8B50", Offset = "0x55D7B50", VA = "0x1855D8B50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CJEPHDFADJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62577D0", Offset = "0x62567D0", VA = "0x1862577D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1CEAA60", Offset = "0x1CE9A60", VA = "0x181CEAA60", Slot = "8")]
	public bool Equals(PPHDHOCDDPD PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6257810", Offset = "0x6256810", VA = "0x186257810", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OMEKJMIANDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKLLCHKOCHA(PGHBHKIGPIJ HLMIIECLDOF, LHNKIGKONBG GDBAAAMILCG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKLLCHKOCHA(GKDGKAIMIMI KICFKOGHBOM, LHNKIGKONBG GDBAAAMILCG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCDECEOGMHA(GKDGKAIMIMI KICFKOGHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DBEEJFELLKB(GKDGKAIMIMI KICFKOGHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MMOLOJKHKFP();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DEOMBLMCEFD(LHNKIGKONBG IKHOLAJCJOG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HGLKMOKAEKC(PGHBHKIGPIJ HLMIIECLDOF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HGLKMOKAEKC(GKDGKAIMIMI KICFKOGHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AGKLFBAIAGC(GKDGKAIMIMI KICFKOGHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NDJIGAELKFC(GKDGKAIMIMI KICFKOGHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IMOGGILPLMH();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JOPMNNHOMED();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HPHDHGMDGEE(PGHBHKIGPIJ HLMIIECLDOF, FANDOAMEPOG IKHOLAJCJOG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IBDAJANNDHM(GKDGKAIMIMI KICFKOGHBOM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FCAEAIDHBMP(GKDGKAIMIMI KICFKOGHBOM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GCNAFALDEEL();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CKKAKPHNKAC(FANDOAMEPOG IKHOLAJCJOG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MINCEMFLMED(PGHBHKIGPIJ HLMIIECLDOF, Vector3 DIKHCCGABOA, Vector3 HGJHNNAEHCP, Vector3 IOEEJMKNKGA, float KJADOBDKAGO, float KKKHAAHEDDH, IReadOnlyList<Camera> EPEBIOMGPKG, DBOJNKGMLIK CAKLCKKNHCH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MINCEMFLMED(PPHDHOCDDPD DLJILLNMJGL, Vector3 DIKHCCGABOA, Vector3 HGJHNNAEHCP, Vector3 IOEEJMKNKGA, float KJADOBDKAGO, float KKKHAAHEDDH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LCAHINPIKOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PJHAFGJFLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PGHBHKIGPIJ OBNLACBKJII(MDEJIHEHJPH ELANMAGHLLI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PGHBHKIGPIJ OBNLACBKJII(MDEJIHEHJPH ELANMAGHLLI, bool MMCINPDAHIL);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPOPAJFGLAA(PGHBHKIGPIJ HLMIIECLDOF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMGEMPNEJFM(PGHBHKIGPIJ HLMIIECLDOF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKDGKAIMIMI NDEPADDJIGI(PGHBHKIGPIJ HLMIIECLDOF, AKFGNDLABLC ELANMAGHLLI);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GKDGKAIMIMI BOANPGAJDFK(PGHBHKIGPIJ HLMIIECLDOF, JKNACDEEDGK ELANMAGHLLI);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PJPALFCFJJD(GKDGKAIMIMI KICFKOGHBOM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EHBLIGDKJOD(GKDGKAIMIMI KICFKOGHBOM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PPHDHOCDDPD PJBNGFMEEKL(KKHDLHECCEG ELANMAGHLLI);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJDIFEGBIHD(PPHDHOCDDPD DLJILLNMJGL);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GMHGLAEAEAI(PPHDHOCDDPD DLJILLNMJGL);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task OPPIDNGGIOL();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task CAMIPPPELDJ();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task BJOCIGJGPBM();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PJJBABEAPLF();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> HMPIHFDKDIJ(PGHBHKIGPIJ HLMIIECLDOF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NAHKHIFECGP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum PCJIADFFMML
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
	public enum JIPAOGPBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum HCCMNPGKJJO
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
	public enum LKKIEGBECKN
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
	private static bool GKMDIMDEFMC;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int NFHDHMKBNML;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int PIOHNFPPDNF;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int DPDNFGKMLCM;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int OIDCGGLJELE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int PBHMLEODMLB;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int JCALPDDBMAP;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int KJCCMFLFFJG;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static int EDGMNCIFIAO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static long BKMDNGCBELK;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static long ECPDNODBLNB;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static long HLLAECLIFAC;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static long GPOOEDLEBIL;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static long PLNHBHNJFFC;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static long KPMLFJEMBLA;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static long DBFEMMFPJEH;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static long NLJJNFMKBKA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static LKKIEGBECKN ICMMHICKMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6255350", Offset = "0x6254350", VA = "0x186255350")]
		[CompilerGenerated]
		get
		{
			return default(LKKIEGBECKN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6256900", Offset = "0x6255900", VA = "0x186256900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static PCJIADFFMML HCICMLNGLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62569C0", Offset = "0x62559C0", VA = "0x1862569C0")]
		[CompilerGenerated]
		get
		{
			return default(PCJIADFFMML);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6255690", Offset = "0x6254690", VA = "0x186255690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool CAHBHPJDDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6256390", Offset = "0x6255390", VA = "0x186256390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x62568A0", Offset = "0x62558A0", VA = "0x1862568A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static JIPAOGPBGDB MLOEHPEIELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6256A70", Offset = "0x6255A70", VA = "0x186256A70")]
		[CompilerGenerated]
		get
		{
			return default(JIPAOGPBGDB);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x62550C0", Offset = "0x62540C0", VA = "0x1862550C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool NFDPKBCFHEE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x62551E0", Offset = "0x62541E0", VA = "0x1862551E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x62571F0", Offset = "0x62561F0", VA = "0x1862571F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool MIDIHFMDLLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6254CE0", Offset = "0x6253CE0", VA = "0x186254CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6255850", Offset = "0x6254850", VA = "0x186255850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static float CGCFCIDMCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6256600", Offset = "0x6255600", VA = "0x186256600")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x62567F0", Offset = "0x62557F0", VA = "0x1862567F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static int LNGDMAPNFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6256C70", Offset = "0x6255C70", VA = "0x186256C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static int AICLGJCHADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6256280", Offset = "0x6255280", VA = "0x186256280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62564F0", Offset = "0x62554F0", VA = "0x1862564F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static int KGOOIKLHIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62566A0", Offset = "0x62556A0", VA = "0x1862566A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6254EA0", Offset = "0x6253EA0", VA = "0x186254EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int HBMNAAAOGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x62554A0", Offset = "0x62544A0", VA = "0x1862554A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6256B70", Offset = "0x6255B70", VA = "0x186256B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int JCNKKNANLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x62566F0", Offset = "0x62556F0", VA = "0x1862566F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6254F00", Offset = "0x6253F00", VA = "0x186254F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int OGBEFIOCFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x62571A0", Offset = "0x62561A0", VA = "0x1862571A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6255000", Offset = "0x6254000", VA = "0x186255000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int IGIFIPCAJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x62567A0", Offset = "0x62557A0", VA = "0x1862567A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6257140", Offset = "0x6256140", VA = "0x186257140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int NIGGIIBGDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6256650", Offset = "0x6255650", VA = "0x186256650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x62563E0", Offset = "0x62553E0", VA = "0x1862563E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int MHPFPKCCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6256440", Offset = "0x6255440", VA = "0x186256440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6255230", Offset = "0x6254230", VA = "0x186255230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int BHLGMNANOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6254F60", Offset = "0x6253F60", VA = "0x186254F60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6256550", Offset = "0x6255550", VA = "0x186256550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int NKBKCNIOIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6256850", Offset = "0x6255850", VA = "0x186256850")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6255120", Offset = "0x6254120", VA = "0x186255120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static bool MDGJPHIFCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6254D90", Offset = "0x6253D90", VA = "0x186254D90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6255180", Offset = "0x6254180", VA = "0x186255180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static bool POMAIOBHLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6255640", Offset = "0x6254640", VA = "0x186255640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62556F0", Offset = "0x62546F0", VA = "0x1862556F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static HCCMNPGKJJO MBGLNPDJAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6256AC0", Offset = "0x6255AC0", VA = "0x186256AC0")]
		[CompilerGenerated]
		get
		{
			return default(HCCMNPGKJJO);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6256B10", Offset = "0x6255B10", VA = "0x186256B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool MMABCALBFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62565B0", Offset = "0x62555B0", VA = "0x1862565B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6256A10", Offset = "0x6255A10", VA = "0x186256A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float NMBKIHKJGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6255800", Offset = "0x6254800", VA = "0x186255800")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6255060", Offset = "0x6254060", VA = "0x186255060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float ALFKHKFEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6255590", Offset = "0x6254590", VA = "0x186255590")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62557A0", Offset = "0x62547A0", VA = "0x1862557A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static float DEHJOONHJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62554F0", Offset = "0x62544F0", VA = "0x1862554F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6254E40", Offset = "0x6253E40", VA = "0x186254E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static float LLNEEKDJLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6256C20", Offset = "0x6255C20", VA = "0x186256C20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6256960", Offset = "0x6255960", VA = "0x186256960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static float CLAFLKPALPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6255750", Offset = "0x6254750", VA = "0x186255750")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62555E0", Offset = "0x62545E0", VA = "0x1862555E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool OPCBPFHJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62553F0", Offset = "0x62543F0", VA = "0x1862553F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6256330", Offset = "0x6255330", VA = "0x186256330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static float MJLLPGOEOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62553A0", Offset = "0x62543A0", VA = "0x1862553A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62558B0", Offset = "0x62548B0", VA = "0x1862558B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int EBHLJLNFKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6256230", Offset = "0x6255230", VA = "0x186256230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6256D50", Offset = "0x6255D50", VA = "0x186256D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int LOMHJPEMDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6255540", Offset = "0x6254540", VA = "0x186255540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62570E0", Offset = "0x62560E0", VA = "0x1862570E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int KGJNMDPGODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6254FB0", Offset = "0x6253FB0", VA = "0x186254FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62552F0", Offset = "0x62542F0", VA = "0x1862552F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool LOLICIJKCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6256490", Offset = "0x6255490", VA = "0x186256490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6255910", Offset = "0x6254910", VA = "0x186255910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static Transform GEOEAHIACIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6255440", Offset = "0x6254440", VA = "0x186255440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6256CD0", Offset = "0x6255CD0", VA = "0x186256CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool KPGKEAKEPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6255290", Offset = "0x6254290", VA = "0x186255290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6256740", Offset = "0x6255740", VA = "0x186256740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool MFMEMLOKMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6254DE0", Offset = "0x6253DE0", VA = "0x186254DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62562D0", Offset = "0x62552D0", VA = "0x1862562D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static bool NMCFJEFAJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6256BD0", Offset = "0x6255BD0", VA = "0x186256BD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6254D30", Offset = "0x6253D30", VA = "0x186254D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6255970", Offset = "0x6254970", VA = "0x186255970")]
	public static void FOGHGAENDFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6256DB0", Offset = "0x6255DB0", VA = "0x186256DB0")]
	public static void OEJJMBLAGNM(LKKIEGBECKN GMNJAJIDHOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GFNNPIJDAMK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct NFKCLGHBEGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Vector3 CIKPOOKMMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Quaternion KGONPCAJEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public float MNGNNIENKEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Quaternion MACBEMCLKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float AEBMAMDJMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public float DBAJGHHNJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float PMACHKMKHFN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static List<NFKCLGHBEGM> KJJPEBHONCB;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6251B10", Offset = "0x6250B10", VA = "0x186251B10")]
	public static NativeList<JNHEEHKCAPD> FMJMGHECOHD(KBHHKFNMBIH LCONILKDJAG)
	{
		return default(NativeList<JNHEEHKCAPD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6250B30", Offset = "0x624FB30", VA = "0x186250B30")]
	private static bool FLKLENDGKAK(int BFOKHFCOJAP, NativeList<JNHEEHKCAPD> HEOGODCLBDD, List<NFKCLGHBEGM> BDMIPBFNHJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6252090", Offset = "0x6251090", VA = "0x186252090")]
	private static JNHEEHKCAPD GDFBGPJJIBH(int HCGAIOKHKMI, List<NFKCLGHBEGM> BDMIPBFNHJB)
	{
		return default(JNHEEHKCAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6250620", Offset = "0x624F620", VA = "0x186250620")]
	private static JNHEEHKCAPD EHGGFOBKJEH(int HCGAIOKHKMI, List<NFKCLGHBEGM> BDMIPBFNHJB)
	{
		return default(JNHEEHKCAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6252220", Offset = "0x6251220", VA = "0x186252220")]
	private static JNHEEHKCAPD JEMFKAGLKKA(Vector3 HOOKHPGOOGE, Quaternion HKHEOOJKFBI, float ELLOHCJLFKF)
	{
		return default(JNHEEHKCAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6252300", Offset = "0x6251300", VA = "0x186252300")]
	public static NativeList<JNHEEHKCAPD> KMLCBHCFFNA(KBHHKFNMBIH LCONILKDJAG, float PJHKOKGEHEG)
	{
		return default(NativeList<JNHEEHKCAPD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IICDDJDLMIN
{
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static Vector3 NLNFENGIPMA;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static Vector3 JPMFGANGKCI;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static readonly float AGEBMMNNJII;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x62546E0", Offset = "0x62536E0", VA = "0x1862546E0")]
	public static Vector3 FCLEGOCMBDB(Vector3 JANANCDMKGG, Quaternion HKHEOOJKFBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x62549F0", Offset = "0x62539F0", VA = "0x1862549F0")]
	public static Vector3 NLMBBMJAAGF(Quaternion GOAHENPPMCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6254210", Offset = "0x6253210", VA = "0x186254210")]
	public static Vector3 BPBCPEDDECN(Quaternion GOAHENPPMCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6254970", Offset = "0x6253970", VA = "0x186254970")]
	public static Quaternion JGCFJBDMNGO(Vector3 PKIECLPJPAP, Vector3 JEPJKJIDLAI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6253CB0", Offset = "0x6252CB0", VA = "0x186253CB0")]
	public static Vector3 AEDDDEJCEJK(Vector3 JGNEOLCDKGI, Vector3 LNGKLNEMPNP, Vector3 JEPJKJIDLAI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x62542B0", Offset = "0x62532B0", VA = "0x1862542B0")]
	public static Vector3 EGICJAHJFFM(Vector3 JANANCDMKGG, Vector3 JEPJKJIDLAI, Quaternion GOAHENPPMCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6253EA0", Offset = "0x6252EA0", VA = "0x186253EA0")]
	public static Quaternion AKBPFEDEGKD(Quaternion HKHEOOJKFBI, Vector3 PKIECLPJPAP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6254A90", Offset = "0x6253A90", VA = "0x186254A90")]
	public static bool PFJEGMHILEP(Vector3 GLACAIAHMJO, Vector3 BGCHMBNNAMK, [Out] Vector3 EOJHOKHGBAN, bool APANIPMOBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x62539C0", Offset = "0x62529C0", VA = "0x1862539C0")]
	public static Vector3 AECLEGJHDGL(bool HGGELCLOHKM, [Optional] Quaternion IFPGPPHMOJL)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JNHEEHKCAPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float3 CIKPOOKMMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public float3x3 KGONPCAJEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float MNGNNIENKEN;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KBHHKFNMBIH
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int OMGBBAGCKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JIEJOFKGOPG(int HCGAIOKHKMI);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion JHIJFIBBPLE(int HCGAIOKHKMI);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float BMEDDCBBLAC(int HCGAIOKHKMI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JKNACDEEDGK : LLDNHFLAEEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool EGAPJCJDJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool DNFFBPMNPHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float KCGBMIJJPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int LJHPCKMOGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool OEAMMDEMPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int JNBICMMJFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JNHEEHKCAPD> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface AKFGNDLABLC : LLDNHFLAEEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EFONDBBKCJM ANICFACCKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool JPCCHHJLAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface MDEJIHEHJPH
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	HOKKFALNJFB HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DEBGHCLLCCM OKIHGNGBILF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LLDNHFLAEEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool IDFPNGGGDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool AIBDALKICIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	HOKKFALNJFB HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	float PNNPMJEJCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CHKKKJAFDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	JGMDHPBNOFM LNPHBNELNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KPJPNECGJII INLHNDGDNMD
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
public interface KKHDLHECCEG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	int PMCLIFEMPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Transform CNNEEACGGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LOLABKHFBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PGHBHKIGPIJ GetBone(int HCGAIOKHKMI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int HCGAIOKHKMI);
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
