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
public enum NMKBMCNJDOD
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
public enum JCPBLDHJLEF
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
public enum LKLBAIDKPCN
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
public enum CBOJNGCBBKE
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
public enum EOGPNMLBPJG
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
public enum IIENBPKDKHB
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
public static class LGBIPPNIILF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x76113B0", Offset = "0x760FFB0", VA = "0x1876113B0")]
	public static bool AEBCHEFFFBB(this IIENBPKDKHB PCPKKEMBCIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x76113D0", Offset = "0x760FFD0", VA = "0x1876113D0")]
	public static bool DNNICHICEFO(this IIENBPKDKHB PCPKKEMBCIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x76113E0", Offset = "0x760FFE0", VA = "0x1876113E0")]
	public static bool DPPBFKBEFFD(this IIENBPKDKHB PCPKKEMBCIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DLFEHIBNHLA
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
public struct IIPDOOIGMOL : BJACBJHGLEM, IEquatable<IIPDOOIGMOL>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int AHDPANGFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int IOKKPHFOFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ED10", Offset = "0x2B4D910", VA = "0x182B4ED10", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67DD1D0", Offset = "0x67DBDD0", VA = "0x1867DD1D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KBPDDCJKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76112E0", Offset = "0x760FEE0", VA = "0x1876112E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1680790", Offset = "0x167F390", VA = "0x181680790", Slot = "8")]
	public bool Equals(IIPDOOIGMOL PELBNOCGOOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x338C480", Offset = "0x338B080", VA = "0x18338C480")]
	public static bool LBLECGDECIN(IIPDOOIGMOL CEDOOEEEDCO, IIPDOOIGMOL LJEHMGANCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7611240", Offset = "0x760FE40", VA = "0x187611240", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7611320", Offset = "0x760FF20", VA = "0x187611320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OJNLEJKNADA : BJACBJHGLEM, IEquatable<OJNLEJKNADA>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int AHDPANGFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int IOKKPHFOFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ED10", Offset = "0x2B4D910", VA = "0x182B4ED10", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x67DD1D0", Offset = "0x67DBDD0", VA = "0x1867DD1D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KBPDDCJKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7611590", Offset = "0x7610190", VA = "0x187611590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1680790", Offset = "0x167F390", VA = "0x181680790", Slot = "8")]
	public bool Equals(OJNLEJKNADA PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x76114F0", Offset = "0x76100F0", VA = "0x1876114F0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x76115D0", Offset = "0x76101D0", VA = "0x1876115D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NKNDDOIODOM : BJACBJHGLEM, IEquatable<NKNDDOIODOM>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int AHDPANGFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IOKKPHFOFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B4ED10", Offset = "0x2B4D910", VA = "0x182B4ED10", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67DD1D0", Offset = "0x67DBDD0", VA = "0x1867DD1D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KBPDDCJKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x76114B0", Offset = "0x76100B0", VA = "0x1876114B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1680790", Offset = "0x167F390", VA = "0x181680790", Slot = "8")]
	public bool Equals(NKNDDOIODOM PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7611410", Offset = "0x7610010", VA = "0x187611410", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NPIAAOHMPJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIHCMGOANFI(IIPDOOIGMOL EBMDCHEPJIM, JCPBLDHJLEF PELCJAFICFI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIHCMGOANFI(OJNLEJKNADA PKCKJCGKEIP, JCPBLDHJLEF PELCJAFICFI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOJBJFMLFKB(OJNLEJKNADA PKCKJCGKEIP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CFJBDCAAMCD(OJNLEJKNADA PKCKJCGKEIP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIBIOCIAELN();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGHMNJKCDMF(JCPBLDHJLEF ADFFEBFOCBD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILIABCJLFGO(IIPDOOIGMOL EBMDCHEPJIM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ILIABCJLFGO(OJNLEJKNADA PKCKJCGKEIP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DOOCMOOAIFE(OJNLEJKNADA PKCKJCGKEIP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GPOOKEAKBIH(OJNLEJKNADA PKCKJCGKEIP);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCJAGAAEPON();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AEGDDNLHOFJ();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CKKHIODBLLG(IIPDOOIGMOL EBMDCHEPJIM, EOGPNMLBPJG ADFFEBFOCBD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void INFNCLGCEOP(OJNLEJKNADA PKCKJCGKEIP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JPLKMMMCNEA(OJNLEJKNADA PKCKJCGKEIP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PIDHCLHFGCP();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NJDCMFDCCNI(EOGPNMLBPJG ADFFEBFOCBD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AKCKGDFABGK(IIPDOOIGMOL EBMDCHEPJIM, Vector3 PIDIPIIBMGP, Vector3 DKHBAPGMEPM, Vector3 EGNDGLCMLCM, float GLACLAGAINO, float CKENNCOODHE, IReadOnlyList<Camera> GMJEEJJBFLG, NMKBMCNJDOD HKPDLOOMFFD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AKCKGDFABGK(NKNDDOIODOM NNGMIJFEMLD, Vector3 PIDIPIIBMGP, Vector3 DKHBAPGMEPM, Vector3 EGNDGLCMLCM, float GLACLAGAINO, float CKENNCOODHE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LAHFEONIIDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LLOKLODACHH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IIPDOOIGMOL BDEPEPJPJNG(ECMOINEGHPA LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIPDOOIGMOL BDEPEPJPJNG(ECMOINEGHPA LLDJIJICLJF, bool JNNHAJBOKAM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFICAOANFLG(IIPDOOIGMOL EBMDCHEPJIM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENKDEBBIPPD(IIPDOOIGMOL EBMDCHEPJIM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OJNLEJKNADA IPJLEMEFKLK(IIPDOOIGMOL EBMDCHEPJIM, PPIKABHIOAG LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OJNLEJKNADA KCKNPFDDFLG(IIPDOOIGMOL EBMDCHEPJIM, PBHNFJGKOIJ LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDDLBNGINKJ(OJNLEJKNADA PKCKJCGKEIP);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CPDIHHFAFFI(OJNLEJKNADA PKCKJCGKEIP);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NKNDDOIODOM EEOFKABPEGK(JODDCIOIFLC LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OKJAOCPOPFI(NKNDDOIODOM NNGMIJFEMLD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BOMOBKKHDCG(NKNDDOIODOM NNGMIJFEMLD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task PIGACLDFCGG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task PGHAOOIGDJC();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EINJCNPGHCI();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HAHNFFCMDCI();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> CBDHJDLNFKE(IIPDOOIGMOL EBMDCHEPJIM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BBFCAKDMKLB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum NCJFABMJMML
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum LJHJOLKJFPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum GLEFMJFJONE
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		RefreshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum IBCFFJMPGFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum HANNBKNACLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum LMLKDLHJBBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum HFDNFLLMJMM
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum FOBHPHAOACN
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		LAST = 101
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool CGBKHMJMBLC;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static long DHDPIGMLGKD;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float EFGDLFEGMPM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static bool GFAGCGPCLEI;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static long MDEADCBDBNE;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static int JJFHKMOJCJN;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool ALCHIKGJJGG;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static LJHJOLKJFPP NNFEHHBDPOB;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float BOBLLGGILJD;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float HHFCLIIKLIE;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static bool KFBNEMBJLJO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static HFDNFLLMJMM PKHMHCLOJJD;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static bool ENAKMPEAKKO;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static float JNDGNIJEPEJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float FGECJNHBMHC;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float OKMLADDAPBK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float NAJIEOICIIA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float FKJKLDOAJHD;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static long JJGBDDDBBOM;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static long DBLGADIHBIP;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static int GPEAFIFJOLH;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static bool GJINLDMCMHI;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long ILNOAFGICEK;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long DBPEDGKDCOA;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static int CGCAGFJKFHC;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static long KNONMDJDOEF;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static int CDNNJJKMMPK;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int LPBDGDPBEFE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int CPGLFIAGMJP;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static long PIHIINCBDFJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static long PNHELLHEPAA;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int NICMBJNHDEK;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int DGJGBKLAAKI;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int IGGMDNGDHLC;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static long JFFJGPHEDGL;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static long NNCHIOAIAIN;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long POAPHAOPJOA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long HBDMOJKGCKJ;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int PMHAOCGCBEM;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int LGIBLDNNBOB;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int AJLMAMOIPJB;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int GGFPAGICCBA;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int[] JMDAHDKKMKP;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int NNFCGPOECBP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long IFKCDJEOMJL;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long CBMGKBGNLJP;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static int OAIKCIJFIAH;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long GELMCKMGNKN;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static long ECLIJODBCDG;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static long OGPJGCDFBPF;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long PFKJNFBCBMK;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long EAOCNMBBKCJ;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long PNMJJMKIDOJ;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long IFGJMPGBOGD;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long KKLFLEPLEJP;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long HBAJKBABLDO;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static float JAMKAICMNCI;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long GJADICOMLOC;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int COBMAJLNIKH;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static long BEMAAAPPBNK;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long GKGJIPACGEM;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static float CJMIBGDCHBM;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long GEALHDOHANJ;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long JHNGDHDHEIO;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long OEEBGIHNMON;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long NNMJMFGJFNM;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long GIGDGNELDHE;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long DGFPIPIICLB;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long DHPPJAPLLHM;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long MEFBCHIPNCM;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long MOKEBPLBICN;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long KEDPLMHKGGM;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long JKDPMLPBGEG;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long PFLBPFJFALJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool AMNJOEHGNGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x760EED0", Offset = "0x760DAD0", VA = "0x18760EED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x760A920", Offset = "0x7609520", VA = "0x18760A920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static FOBHPHAOACN MJEEGFJBOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x760F070", Offset = "0x760DC70", VA = "0x18760F070")]
		[CompilerGenerated]
		get
		{
			return default(FOBHPHAOACN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x760CD60", Offset = "0x760B960", VA = "0x18760CD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool HKHCPIEMLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x760E150", Offset = "0x760CD50", VA = "0x18760E150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x760F1E0", Offset = "0x760DDE0", VA = "0x18760F1E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool LHNLDDLGHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x760E300", Offset = "0x760CF00", VA = "0x18760E300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x760B570", Offset = "0x760A170", VA = "0x18760B570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float CIJPPMDFEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x760DFB0", Offset = "0x760CBB0", VA = "0x18760DFB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x760CA30", Offset = "0x760B630", VA = "0x18760CA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float GKKNHLLNELI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x760B420", Offset = "0x760A020", VA = "0x18760B420")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x760A6D0", Offset = "0x76092D0", VA = "0x18760A6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int KBDPIPLEKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x760E990", Offset = "0x760D590", VA = "0x18760E990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x760ED80", Offset = "0x760D980", VA = "0x18760ED80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static LMLKDLHJBBH NALCFDCBCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x760A970", Offset = "0x7609570", VA = "0x18760A970")]
		[CompilerGenerated]
		get
		{
			return default(LMLKDLHJBBH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x760C980", Offset = "0x760B580", VA = "0x18760C980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long KCMDDLALFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x760E4A0", Offset = "0x760D0A0", VA = "0x18760E4A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x760EAE0", Offset = "0x760D6E0", VA = "0x18760EAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float MANIOFBAJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x760EA90", Offset = "0x760D690", VA = "0x18760EA90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x760E250", Offset = "0x760CE50", VA = "0x18760E250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int PPKGCDKBALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x760A5E0", Offset = "0x76091E0", VA = "0x18760A5E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x760B0E0", Offset = "0x7609CE0", VA = "0x18760B0E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int BHHLABPJDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x760E100", Offset = "0x760CD00", VA = "0x18760E100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x760E4F0", Offset = "0x760D0F0", VA = "0x18760E4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int JFMLPHBFOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x760F190", Offset = "0x760DD90", VA = "0x18760F190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x760A790", Offset = "0x7609390", VA = "0x18760A790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int LKDPLPJEGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x760B180", Offset = "0x7609D80", VA = "0x18760B180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x760EF80", Offset = "0x760DB80", VA = "0x18760EF80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int GABBGGCJPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x760EA40", Offset = "0x760D640", VA = "0x18760EA40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x760CC60", Offset = "0x760B860", VA = "0x18760CC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int LPMPHOENOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x760AA60", Offset = "0x7609660", VA = "0x18760AA60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x760E000", Offset = "0x760CC00", VA = "0x18760E000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int HKJIHJDMABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x760A630", Offset = "0x7609230", VA = "0x18760A630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x760B130", Offset = "0x7609D30", VA = "0x18760B130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool HNKDKEOMECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x760AB10", Offset = "0x7609710", VA = "0x18760AB10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int KDHBPFPHNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x760DE30", Offset = "0x760CA30", VA = "0x18760DE30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x760A7E0", Offset = "0x76093E0", VA = "0x18760A7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int CHDIPFMCKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x760ADD0", Offset = "0x76099D0", VA = "0x18760ADD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x760CE10", Offset = "0x760BA10", VA = "0x18760CE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int NOENGGDGMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x760F300", Offset = "0x760DF00", VA = "0x18760F300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x760B4C0", Offset = "0x760A0C0", VA = "0x18760B4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool GICDEMBLPDI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x760AA10", Offset = "0x7609610", VA = "0x18760AA10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x760F350", Offset = "0x760DF50", VA = "0x18760F350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float KIEGOBDHLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x760B090", Offset = "0x7609C90", VA = "0x18760B090")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x760AD20", Offset = "0x7609920", VA = "0x18760AD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static bool FADJOFGMKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x760CBB0", Offset = "0x760B7B0", VA = "0x18760CBB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x760A730", Offset = "0x7609330", VA = "0x18760A730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool KMDBJOJMGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x760ED30", Offset = "0x760D930", VA = "0x18760ED30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x760E810", Offset = "0x760D410", VA = "0x18760E810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static NCJFABMJMML HLGIICFKKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x760AD80", Offset = "0x7609980", VA = "0x18760AD80")]
		[CompilerGenerated]
		get
		{
			return default(NCJFABMJMML);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x760EF20", Offset = "0x760DB20", VA = "0x18760EF20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool ACCFPAGKLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x760F3B0", Offset = "0x760DFB0", VA = "0x18760F3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x760F240", Offset = "0x760DE40", VA = "0x18760F240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool DCLCLGGENFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x760EFD0", Offset = "0x760DBD0", VA = "0x18760EFD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x760CB50", Offset = "0x760B750", VA = "0x18760CB50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int EINPCOBPJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x760F020", Offset = "0x760DC20", VA = "0x18760F020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x760F400", Offset = "0x760E000", VA = "0x18760F400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int IONAHLDDALB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x760A830", Offset = "0x7609430", VA = "0x18760A830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x760B320", Offset = "0x7609F20", VA = "0x18760B320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int LBKJKFGFHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x760AE70", Offset = "0x7609A70", VA = "0x18760AE70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x760C920", Offset = "0x760B520", VA = "0x18760C920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int AJNEKCDLBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x760AE20", Offset = "0x7609A20", VA = "0x18760AE20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x760DEF0", Offset = "0x760CAF0", VA = "0x18760DEF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int ABPOPAMEKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x760B630", Offset = "0x760A230", VA = "0x18760B630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x760AF70", Offset = "0x7609B70", VA = "0x18760AF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int OFFFDBIFMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x760AC70", Offset = "0x7609870", VA = "0x18760AC70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x760E700", Offset = "0x760D300", VA = "0x18760E700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int LEKEGGOCCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x760AEC0", Offset = "0x7609AC0", VA = "0x18760AEC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x760AF10", Offset = "0x7609B10", VA = "0x18760AF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static int GHHEPGCGIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x760E050", Offset = "0x760CC50", VA = "0x18760E050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x760E9E0", Offset = "0x760D5E0", VA = "0x18760E9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float CHNPIJKMGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x760E350", Offset = "0x760CF50", VA = "0x18760E350")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x760E5E0", Offset = "0x760D1E0", VA = "0x18760E5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float IHFBBEKDIBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x760EDD0", Offset = "0x760D9D0", VA = "0x18760EDD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x760AB60", Offset = "0x7609760", VA = "0x18760AB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float IFLGPCFMGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x760B680", Offset = "0x760A280", VA = "0x18760B680")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x760F2A0", Offset = "0x760DEA0", VA = "0x18760F2A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int OAAHCAGNDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x760E7C0", Offset = "0x760D3C0", VA = "0x18760E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x760ECD0", Offset = "0x760D8D0", VA = "0x18760ECD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int IPFLKMFOCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x760A9C0", Offset = "0x76095C0", VA = "0x18760A9C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x760AAB0", Offset = "0x76096B0", VA = "0x18760AAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int MJBMMNPDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x760E2B0", Offset = "0x760CEB0", VA = "0x18760E2B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x760E930", Offset = "0x760D530", VA = "0x18760E930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int BHKOANKDEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x760F0C0", Offset = "0x760DCC0", VA = "0x18760F0C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x760ABC0", Offset = "0x76097C0", VA = "0x18760ABC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static bool CAKCBGNLBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x760A680", Offset = "0x7609280", VA = "0x18760A680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x760E760", Offset = "0x760D360", VA = "0x18760E760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static GLEFMJFJONE CFPPAKKJCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x760DD90", Offset = "0x760C990", VA = "0x18760DD90")]
		[CompilerGenerated]
		get
		{
			return default(GLEFMJFJONE);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x760CAF0", Offset = "0x760B6F0", VA = "0x18760CAF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static IBCFFJMPGFO INLMBPJBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x760EC00", Offset = "0x760D800", VA = "0x18760EC00")]
		[CompilerGenerated]
		get
		{
			return default(IBCFFJMPGFO);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x760E870", Offset = "0x760D470", VA = "0x18760E870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool EMABDNLKLDE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x760C870", Offset = "0x760B470", VA = "0x18760C870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x760B510", Offset = "0x760A110", VA = "0x18760B510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static float BFAIOLPHAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x760CCB0", Offset = "0x760B8B0", VA = "0x18760CCB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x760C8C0", Offset = "0x760B4C0", VA = "0x18760C8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float JJLFFNNLNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x760E450", Offset = "0x760D050", VA = "0x18760E450")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x760C9D0", Offset = "0x760B5D0", VA = "0x18760C9D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float OIFMINGGHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x760B2D0", Offset = "0x7609ED0", VA = "0x18760B2D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x760EE70", Offset = "0x760DA70", VA = "0x18760EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float EDMJHIPCFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x760B3D0", Offset = "0x7609FD0", VA = "0x18760B3D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x760E0A0", Offset = "0x760CCA0", VA = "0x18760E0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float CPAOAOLBBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x760A590", Offset = "0x7609190", VA = "0x18760A590")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x760EBA0", Offset = "0x760D7A0", VA = "0x18760EBA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static float IDNJLMGCECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x760B280", Offset = "0x7609E80", VA = "0x18760B280")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x760E3F0", Offset = "0x760CFF0", VA = "0x18760E3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static bool CNKIJILFPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x760E540", Offset = "0x760D140", VA = "0x18760E540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x760E8D0", Offset = "0x760D4D0", VA = "0x18760E8D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float PDPPMIEPEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x760AC20", Offset = "0x7609820", VA = "0x18760AC20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x760EB40", Offset = "0x760D740", VA = "0x18760EB40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float HLNEMDOFBON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x760E3A0", Offset = "0x760CFA0", VA = "0x18760E3A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x760E1F0", Offset = "0x760CDF0", VA = "0x18760E1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static float HLACMJILOEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x760E1A0", Offset = "0x760CDA0", VA = "0x18760E1A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x760CDB0", Offset = "0x760B9B0", VA = "0x18760CDB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static int CAIGLGDFGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x760A8D0", Offset = "0x76094D0", VA = "0x18760A8D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x760E6A0", Offset = "0x760D2A0", VA = "0x18760E6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static float HNGPJDEJEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x760DDE0", Offset = "0x760C9E0", VA = "0x18760DDE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static bool HBBDLACLLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x760B470", Offset = "0x760A070", VA = "0x18760B470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x760E640", Offset = "0x760D240", VA = "0x18760E640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static int FLJHPIKBBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x760A880", Offset = "0x7609480", VA = "0x18760A880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x760ACC0", Offset = "0x76098C0", VA = "0x18760ACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static float JDPGEFAGKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x760B380", Offset = "0x7609F80", VA = "0x18760B380")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x760CD00", Offset = "0x760B900", VA = "0x18760CD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float CEDDMJIIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x760EE20", Offset = "0x760DA20", VA = "0x18760EE20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x760B5D0", Offset = "0x760A1D0", VA = "0x18760B5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static bool FBDPNLFJDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x760B230", Offset = "0x7609E30", VA = "0x18760B230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x760CC00", Offset = "0x760B800", VA = "0x18760CC00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static float BENENGNOLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x760F460", Offset = "0x760E060", VA = "0x18760F460")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x760AFD0", Offset = "0x7609BD0", VA = "0x18760AFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static long EEACIBBBNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x760DF50", Offset = "0x760CB50", VA = "0x18760DF50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static float4x4 MGFGGHBKPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x760EC50", Offset = "0x760D850", VA = "0x18760EC50")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x760F110", Offset = "0x760DD10", VA = "0x18760F110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static float3 JDEFPIHIEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x760DE80", Offset = "0x760CA80", VA = "0x18760DE80")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x760B1D0", Offset = "0x7609DD0", VA = "0x18760B1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static bool GNICJAAHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x760E590", Offset = "0x760D190", VA = "0x18760E590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x760B030", Offset = "0x7609C30", VA = "0x18760B030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public static HANNBKNACLD HIIPCMMMHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x760F4B0", Offset = "0x760E0B0", VA = "0x18760F4B0")]
		[CompilerGenerated]
		get
		{
			return default(HANNBKNACLD);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x760CA90", Offset = "0x760B690", VA = "0x18760CA90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x760B6D0", Offset = "0x760A2D0", VA = "0x18760B6D0")]
	public static void HHIMFBNLBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x760CE60", Offset = "0x760BA60", VA = "0x18760CE60")]
	public static void JGJELIONPNA(FOBHPHAOACN PCEMEEICKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class PGNANBJOGIG
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct DGPOHLOGKNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public Vector3 JCCKFLFINHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Quaternion BLLDMMJBALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public float FCKKJPHCMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public Quaternion PKAAJODOGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public float KECFCJGMLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public float BKHEJIDBANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public float JAFOJMINBND;
	}

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static List<DGPOHLOGKNA> LCPLHKGOBFE;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7611DB0", Offset = "0x76109B0", VA = "0x187611DB0")]
	public static NativeList<DPNIHIHALMF> GMKMBDMDJEE(EHHMHNLIKNI FCIAFOBBBBA)
	{
		return default(NativeList<DPNIHIHALMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x76137F0", Offset = "0x76123F0", VA = "0x1876137F0")]
	private static bool PMCOBIDECLK(int GFMJIHODIPC, NativeList<DPNIHIHALMF> HBANOBDOKBJ, List<DGPOHLOGKNA> ACHGEEOGFPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7611740", Offset = "0x7610340", VA = "0x187611740")]
	private static DPNIHIHALMF BBKPLLHALMI(int MGPCONLELFP, List<DGPOHLOGKNA> ACHGEEOGFPI)
	{
		return default(DPNIHIHALMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x76118C0", Offset = "0x76104C0", VA = "0x1876118C0")]
	private static DPNIHIHALMF FFAIKJPPKGD(int MGPCONLELFP, List<DGPOHLOGKNA> ACHGEEOGFPI)
	{
		return default(DPNIHIHALMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7611660", Offset = "0x7610260", VA = "0x187611660")]
	private static DPNIHIHALMF AOHNGMBECKJ(Vector3 CHHMDBOKADH, Quaternion PHEHLBBHLCL, float GHONGHPPDGL)
	{
		return default(DPNIHIHALMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7612350", Offset = "0x7610F50", VA = "0x187612350")]
	public static NativeList<DPNIHIHALMF> NGIPDOCAJNE(EHHMHNLIKNI FCIAFOBBBBA, float KFNEAMPEIHO)
	{
		return default(NativeList<DPNIHIHALMF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IBDBLPPBKHC
{
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public static Vector3 GNJFPMHGBGO;

	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public static Vector3 AIDMCOMNBNE;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public static readonly float KCOOHBFOLOK;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7610BC0", Offset = "0x760F7C0", VA = "0x187610BC0")]
	public static Vector3 GJNPJHLPLMJ(Vector3 FPKHABOHHDG, Quaternion PHEHLBBHLCL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x76110D0", Offset = "0x760FCD0", VA = "0x1876110D0")]
	public static Vector3 OKALOBHEDKP(Quaternion APLHHNGOEFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7611030", Offset = "0x760FC30", VA = "0x187611030")]
	public static Vector3 NHMFMENABFL(Quaternion APLHHNGOEFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x760FF40", Offset = "0x760EB40", VA = "0x18760FF40")]
	public static Quaternion ANODKCOPJDA(Vector3 JJPEELBONAL, Vector3 HKFKAONALCJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7610E40", Offset = "0x760FA40", VA = "0x187610E40")]
	public static Vector3 HIPHKGAGFFA(Vector3 GBCLFBEHJCM, Vector3 KBKGNKMKNFD, Vector3 HKFKAONALCJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7610790", Offset = "0x760F390", VA = "0x187610790")]
	public static Vector3 FLCPBGHJBMD(Vector3 FPKHABOHHDG, Vector3 HKFKAONALCJ, Quaternion APLHHNGOEFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x76102B0", Offset = "0x760EEB0", VA = "0x1876102B0")]
	public static Quaternion CJECOKALJAM(Quaternion PHEHLBBHLCL, Vector3 JJPEELBONAL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7610610", Offset = "0x760F210", VA = "0x187610610")]
	public static bool EAKGKCMDFAD(Vector3 CKJBKNBANNN, Vector3 DLDAJLPCFLJ, [Out] Vector3 HKGBGNDLOKM, bool MCMCJDFLAOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x760FFC0", Offset = "0x760EBC0", VA = "0x18760FFC0")]
	public static Vector3 BJBBKOJBENF(bool LLJFHLGJIPH, [Optional] Quaternion DEDDKCHGNHO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DPNIHIHALMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public float3 JCCKFLFINHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public float3x3 BLLDMMJBALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public float FCKKJPHCMOL;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EHHMHNLIKNI
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int FPKDIECOOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 CBFFLDADLPJ(int MGPCONLELFP);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion MNGJGDGLKPC(int MGPCONLELFP);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float GMBGJMMACGK(int MGPCONLELFP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PBHNFJGKOIJ : NJEBMGBJJEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool NKLLHLLIKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool LHMINMKFJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float OMMLCNLCCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int FLLPAMHNEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool IIOKHBDDCGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	int PNOJIKMKEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<DPNIHIHALMF> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PPIKABHIOAG : NJEBMGBJJEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	LKLBAIDKPCN AFJHNFGAFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool CLEGDGHCDDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 MMJFHBPLDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ECMOINEGHPA
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	MLDOPOKHGBO DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	CBOJNGCBBKE AIKBGEJFEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NJEBMGBJJEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool KLGBGKEHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool FEINIILGNHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	MLDOPOKHGBO DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	UniformTRS LJMJBGBKNEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float EIOLOEMLAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Vector3 JENHFKBCJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IIENBPKDKHB LJPDOJGEPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	DLFEHIBNHLA CEPFAOKENFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JODDCIOIFLC
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int CGGHNFGKBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform GNEAJEDDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool EANIKLIDDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIPDOOIGMOL GetBone(int MGPCONLELFP);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MGPCONLELFP);
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
