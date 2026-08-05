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
public enum DILILHCOOLF
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
public enum CIMLIBKMPND
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
public enum DOKODMHNDOA
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
public enum JBBPLPCKICC
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
public enum CFCGOEKOEDO
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
public enum KOGANNKCGHD
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
public static class DAMLFKDIIFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x833F4A0", Offset = "0x833E4A0", VA = "0x18833F4A0")]
	public static bool FGONGDIBMIH(this KOGANNKCGHD IIFJAEBIGOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x833F4F0", Offset = "0x833E4F0", VA = "0x18833F4F0")]
	public static bool LFIFDBLPFIM(this KOGANNKCGHD IIFJAEBIGOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x833F4C0", Offset = "0x833E4C0", VA = "0x18833F4C0")]
	public static bool LFCPPLKBOKJ(this KOGANNKCGHD IIFJAEBIGOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DOKJMPJMCCI
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
public struct FGANHAMJGGJ : BDFEHDIGKLJ, IEquatable<FGANHAMJGGJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int MKOCHPIICKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x314D220", Offset = "0x314C220", VA = "0x18314D220", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EC13E0", Offset = "0x6EC03E0", VA = "0x186EC13E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KJIKLILMPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x833F500", Offset = "0x833E500", VA = "0x18833F500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1365660", Offset = "0x1364660", VA = "0x181365660", Slot = "8")]
	public bool Equals(FGANHAMJGGJ EDJHHGMLKFA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3CDEFA0", Offset = "0x3CDDFA0", VA = "0x183CDEFA0")]
	public static bool PHGIAKEDBEK(FGANHAMJGGJ JDINPJIAKOC, FGANHAMJGGJ LDPKBPICKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x833F540", Offset = "0x833E540", VA = "0x18833F540", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x833F5E0", Offset = "0x833E5E0", VA = "0x18833F5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FLJADJJDFKC : BDFEHDIGKLJ, IEquatable<FLJADJJDFKC>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MKOCHPIICKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x314D220", Offset = "0x314C220", VA = "0x18314D220", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EC13E0", Offset = "0x6EC03E0", VA = "0x186EC13E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KJIKLILMPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8340990", Offset = "0x833F990", VA = "0x188340990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1365660", Offset = "0x1364660", VA = "0x181365660", Slot = "8")]
	public bool Equals(FLJADJJDFKC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x83409D0", Offset = "0x833F9D0", VA = "0x1883409D0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8340A70", Offset = "0x833FA70", VA = "0x188340A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JBLJMFHLDMM : BDFEHDIGKLJ, IEquatable<JBLJMFHLDMM>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MKOCHPIICKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x314D220", Offset = "0x314C220", VA = "0x18314D220", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EC13E0", Offset = "0x6EC03E0", VA = "0x186EC13E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KJIKLILMPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8343070", Offset = "0x8342070", VA = "0x188343070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1365660", Offset = "0x1364660", VA = "0x181365660", Slot = "8")]
	public bool Equals(JBLJMFHLDMM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83430B0", Offset = "0x83420B0", VA = "0x1883430B0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DJNEMOFCFJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBGEAGOKANK(FGANHAMJGGJ NKBKNNLLHKF, CIMLIBKMPND PJBEBIJGJFC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBGEAGOKANK(FLJADJJDFKC CBGBGGEBCJG, CIMLIBKMPND PJBEBIJGJFC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APFOLGNFJHJ(FLJADJJDFKC CBGBGGEBCJG);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGOKHKAFIIF(FLJADJJDFKC CBGBGGEBCJG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAOLJFBMJPE();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNINPGAEGLA(CIMLIBKMPND BJLNCBFOGNL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PFMEENPNENO(FGANHAMJGGJ NKBKNNLLHKF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFMEENPNENO(FLJADJJDFKC CBGBGGEBCJG);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MEBHFBAPGAO(FLJADJJDFKC CBGBGGEBCJG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GMGCLBILGNO(FLJADJJDFKC CBGBGGEBCJG);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GCLHJHLMBDH();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ODPAMCGAIOC();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LEOCGGKANDH(FGANHAMJGGJ NKBKNNLLHKF, CFCGOEKOEDO BJLNCBFOGNL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LAHAKCLNCIH(FLJADJJDFKC CBGBGGEBCJG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JLGNIPAHPHK(FLJADJJDFKC CBGBGGEBCJG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NCGENOBDOPM();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JFDBKLKGCFH(CFCGOEKOEDO BJLNCBFOGNL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EFLKFOGGGGH(FGANHAMJGGJ NKBKNNLLHKF, Vector3 MFCBHBHLABO, Vector3 FBHNPOJCBAF, Vector3 MDKIIKCDCCE, float OCGMAJHHGJO, float CEKCDJIGPMC, IReadOnlyList<Camera> FKCNKFPCFHA, DILILHCOOLF MHMKGPBCAJP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EFLKFOGGGGH(JBLJMFHLDMM BADMKFACBPD, Vector3 MFCBHBHLABO, Vector3 FBHNPOJCBAF, Vector3 MDKIIKCDCCE, float OCGMAJHHGJO, float CEKCDJIGPMC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CANHEHLEDKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NHGIKFEKHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGANHAMJGGJ LACBKHNLHAC(ILAFMLGLELN INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FGANHAMJGGJ LACBKHNLHAC(ILAFMLGLELN INCJDDLACNP, bool CFANKFANCME);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAPHBIBBNHA(FGANHAMJGGJ NKBKNNLLHKF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FALGAKNNOMK(FGANHAMJGGJ NKBKNNLLHKF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FLJADJJDFKC GCBAHJDKALN(FGANHAMJGGJ NKBKNNLLHKF, PGILHJFJMGB INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FLJADJJDFKC HOFABFACEGL(FGANHAMJGGJ NKBKNNLLHKF, PGOGCEBABLM INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BDJDGKLHNPJ(FLJADJJDFKC CBGBGGEBCJG);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INKHHGCJJNE(FLJADJJDFKC CBGBGGEBCJG);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JBLJMFHLDMM CMKGBIAPKKC(MHCAKCKGDAG INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GOCBACGLPDO(JBLJMFHLDMM BADMKFACBPD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HGGCJDOHCFH(JBLJMFHLDMM BADMKFACBPD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task CBEJLEFKGJL();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task MCGPBJMACFF();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task IPAGGLBOOON();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HHJDCPBAPFB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> ELGMOKNDIKI(FGANHAMJGGJ NKBKNNLLHKF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JBGIPBLKJIN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum FGAPENLJJIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum DDCFIGNKHCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum HGLNPPGOFLA
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
	public enum BMMNMAKBCID
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
	public enum IGJJMJLPIBB
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
	public enum GOMEHNKNABB
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
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum AOBABPGPDOI
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum GCNMGJJOMKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		LowQualityHighSpeed = 102
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool FOILNLMFNJM;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long LODLKPKFLHJ;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool PKCIIIDIPJH;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool FJDMPKAMAKF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool EBBOFOGIPLM;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float HLCDPOHCEKO;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float GIAGPDENLFL;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int CAJGGGFBGPP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static GOMEHNKNABB GHMPDODJFDI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long NCDNIOEMEGD;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float BAMEHEEIGFO;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int HFGKPCOANIN;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int JPCALPNPPLG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int PEBPKKJGNHN;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int HBMDEJLAGGP;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int PFJBEGCEBCP;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int PFEDMGPJMLJ;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int HIEAMJMHIOD;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int HJEEPMALOPI;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool IBHHKEONILH;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int BHHKIMPJMCE;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int GOCLJJLILBH;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int HODNPOJAGGK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool HIIDOPMEEBA;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float GIKMAFACHOC;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool IFCKEECBKEO;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float DBBKCBEGCFM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long AHIAOOHLLGB;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool IHCEFEKIDLL;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long FOFHOCKCOEF;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int LBODBENAJMH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool JNPNDGOPPIK;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static FGAPENLJJIN KHLIKKGGNDP;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool IIHGOKEEAFD;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool NIFJBEKIFKP;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int PFNGKOJLOFF;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int OJNLKLNIAOF;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int OKLDDKEGNCP;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int BNAPEDJBHGD;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int JPMOEIDOAHM;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int KBDDEPKALAM;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int HANAEFLFLMH;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int HBGCGHKEPJF;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float GLPHPJCJGLI;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float BIFKMLNEBBO;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float FPIMFCDHMMB;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float GHHKNMIMLMC;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int LMEEMFPFOEF;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int EPNPBBHJGOM;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int GFDNAKNODLF;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int JOLAJOILMLK;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool JOCHGCJKMPJ;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static HGLNPPGOFLA GPJBGMJLIAD;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static BMMNMAKBCID EDPGCLNFHLG;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool MFFCBBEMIOI;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static DDCFIGNKHCL OLLEPJOMEHI;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float JMMLEIGNHOJ;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float ELEODLLOCLF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float ICPFLEHFPDG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float AIJDJMCDLAD;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float AJAPEEGMIGH;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float JLLCOICFICO;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float CAEFICDDGFB;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float GKKHDKBIJOA;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool NOLFGOPHJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static AOBABPGPDOI FMLDELKKDLJ;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool PEJGBEBBGKA;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float EOFPNJMNKFN;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float GOIFDBEOAJG;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float NEJBODEPDLF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float BBCALNLFBOA;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float FECINECAJEM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool AAOLMIDBDEB;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long NKFCNBDJHNF;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float CACOMIOGMBJ;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float AIDOLPHAIEK;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float KDIJFIMGGBH;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int FDDGCAPNCPB;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float GJDCGOHBNAI;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool GGGCJDNPEPF;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long GOOCJHKLJMK;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int MFPBAKGDOKO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int GDIEPPKIDIC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float OONJAGOHNFF;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float KEIJCALLEOH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool DIDOHEPBFNK;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool AIPAPMKKEIK;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float JGOHLLMJMND;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long ENFDNKCFJFF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long OHLABANFNNI;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int HDODACDOFNA;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static bool INMGPDIOAHG;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float NOBNJGDLJMG;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static float GOGLCBILPLH;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static bool NAICNFGBAHP;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long NAKKJAMNHMD;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int OHMEABBGLEL;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static float4x4 CJHLBKOLIEP;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static float3 HCEHIDBINOA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static bool HFMDNBILCOH;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static IGJJMJLPIBB GECNEGFJJKI;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long EHNFDENOBAN;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int ELPNFGKCFAO;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int BNMLBEICCKP;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int GOJMPEJPHEC;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int ENCADOBDCAH;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int IGBHEMGPKKL;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int ENMIPJFCOEC;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int MPPLDFKHIBH;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long EIOOKNBHIPM;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int IJPNKHANLDJ;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int CPOHHHDALEB;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int GAIGJCMMKHP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long LHDCGFHIJIH;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long ALDGFGDMIGC;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long EBKLOJEIIIC;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long FPFHFGDJMDL;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int FODBCPLOGMA;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int GDHDGBPLCLM;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static int KOGJFBAGJCM;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static int IILIJBBFPEL;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int KGPANDLNEEB;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int[] MCPGMIHEMJM;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int[] CICJIDJIDCN;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static int CMAEHCMKLFB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long COPDONLAOHB;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long JPOMFOMKDBH;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int JAIECENBELL;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static int EKILDDBENMC;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long IEJNFBDLCCC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long JPMAEELHJEI;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long FHPGJAEGMED;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long LFBAOPMJAII;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long MGOAJLDJMBD;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long MCKOOBCFMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long GIAMCNKBFNB;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long AEPNEAHFPJA;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long KKGIEEPLILB;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float LHAMBJAMEAI;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static float KMGPEKJEKBB;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long HKIMPECFNOJ;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static int BBBNIJGABKH;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long OIFPGKGEMEP;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long NEDINMHFIEG;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static float MGLGEBIBGHF;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long HJAAMIOMFAE;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long DOMNCLPLGJE;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long NMMLCDIDDHF;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long MJMGGPGOAKF;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long FBABLNPINFN;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long CLPHHNBNDGP;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static long FPDNOJLGAGM;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static long BEODFGKACEP;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static long LFCIGANOCNA;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static long NJDMKBPNDKJ;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static long LELKIABAIGH;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static long BEHCMNHOBEO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static GCNMGJJOMKG AAOKFDPNJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8340B00", Offset = "0x833FB00", VA = "0x188340B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long FFELPDLNONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8341210", Offset = "0x8340210", VA = "0x188341210")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8340B60", Offset = "0x833FB60", VA = "0x188340B60")]
	public static void FMNGODFGMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8341270", Offset = "0x8340270", VA = "0x188341270")]
	public static void NJEOMOGEEPJ(GCNMGJJOMKG FPJEEJBAGKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class COKLNBEICKC
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct GBMFCHCHALL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Vector3 JILMILDHLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Quaternion FOJJHGMABOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public float OPLEFDPFCJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Quaternion FMLLFCMOBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public float GEKDIGJKPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public float AKLKAHPECJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public float KIJIODDIMPC;
	}

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static List<GBMFCHCHALL> KMAOIKJHLLN;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x833CB20", Offset = "0x833BB20", VA = "0x18833CB20")]
	public static NativeList<KOLICHJFOBE> GAKOHLGALLK(DLCDHJHIFNO OGECODCBMEN)
	{
		return default(NativeList<KOLICHJFOBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x833D0A0", Offset = "0x833C0A0", VA = "0x18833D0A0")]
	private static bool HMFFCOBIDPP(int GGLNBEGGDDO, NativeList<KOLICHJFOBE> BGOCMPMGKKI, List<GBMFCHCHALL> DHEEPLGNBMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x833C3D0", Offset = "0x833B3D0", VA = "0x18833C3D0")]
	private static KOLICHJFOBE AFINLCIALNI(int LFBGKHDOJNO, List<GBMFCHCHALL> DHEEPLGNBMC)
	{
		return default(KOLICHJFOBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x833C630", Offset = "0x833B630", VA = "0x18833C630")]
	private static KOLICHJFOBE EGCCPGEFDHO(int LFBGKHDOJNO, List<GBMFCHCHALL> DHEEPLGNBMC)
	{
		return default(KOLICHJFOBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x833C550", Offset = "0x833B550", VA = "0x18833C550")]
	private static KOLICHJFOBE DDDEFBHFNOD(Vector3 GGHGIDAMNEE, Quaternion FKHDNOPJIJO, float MGJGIJAADIJ)
	{
		return default(KOLICHJFOBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x833DF50", Offset = "0x833CF50", VA = "0x18833DF50")]
	public static NativeList<KOLICHJFOBE> INHKCEKKJOL(DLCDHJHIFNO OGECODCBMEN, float EDJJOMPOGKH)
	{
		return default(NativeList<KOLICHJFOBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FJOFPHKKNAA
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public static Vector3 DKBGNBNLPDJ;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static Vector3 HMGGJHKNDMG;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static readonly float PDAAJOFDOJN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8340390", Offset = "0x833F390", VA = "0x188340390")]
	public static Vector3 NNFDHMBBKFG(Vector3 IHKIBPHMOEF, Quaternion FKHDNOPJIJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x833F670", Offset = "0x833E670", VA = "0x18833F670")]
	public static Vector3 ADLHAFPECJA(Quaternion KDHLIJMPIFF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8340810", Offset = "0x833F810", VA = "0x188340810")]
	public static Vector3 PBGJBMHPNDM(Quaternion KDHLIJMPIFF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8340310", Offset = "0x833F310", VA = "0x188340310")]
	public static Quaternion MJDKIFPCMIN(Vector3 NBFEGPDMMPI, Vector3 PNJPAIKKPPF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8340620", Offset = "0x833F620", VA = "0x188340620")]
	public static Vector3 OBHCGBFNCIF(Vector3 KLEJGJGDMID, Vector3 PIFNIIKNCNK, Vector3 PNJPAIKKPPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x833FEE0", Offset = "0x833EEE0", VA = "0x18833FEE0")]
	public static Vector3 KJJIOEADPBC(Vector3 IHKIBPHMOEF, Vector3 PNJPAIKKPPF, Quaternion KDHLIJMPIFF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x833FA00", Offset = "0x833EA00", VA = "0x18833FA00")]
	public static Quaternion FPDHNBKIECM(Quaternion FKHDNOPJIJO, Vector3 NBFEGPDMMPI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x833FD60", Offset = "0x833ED60", VA = "0x18833FD60")]
	public static bool IIEBGPHLIHL(Vector3 KCAEEBGGKKE, Vector3 NKODPOEDFOD, [Out] Vector3 DBOJEEOCMGD, bool PJLGIJEOECP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x833F710", Offset = "0x833E710", VA = "0x18833F710")]
	public static Vector3 AJDAMMFBAOM(bool AACBFFKIADO, [Optional] Quaternion DOMNEGMEEFC)
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
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public float heightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public DOKJMPJMCCI topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public DOKJMPJMCCI slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public HCAHFNLAHJG baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public KIJGMKDAKDJ playArea;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8343150", Offset = "0x8342150", VA = "0x188343150")]
		public TerrainGenerationInfo()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HOPFPKGPFHD
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	TerrainData BNPIEDJDLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject OJEDIBDBEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<bool> OONCBGNJMOJ(uint FABCICCGGJJ, bool FDOCFPFBGDD = true, bool FNBKMNNOKFO = true, bool INLCEBHGCFC = true, [Optional] float3? MFNLMHEKNLL, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> OONCBGNJMOJ(OJBMGIOFJEJ EJFOEJMICOM, TerrainGenerationInfo OGECODCBMEN, bool FNBKMNNOKFO, bool INLCEBHGCFC, uint FABCICCGGJJ, [Optional] float3? MFNLMHEKNLL, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBLOHGCCHFB(bool MJAAFMMDCJJ);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PCLPIAPHGPD(Action<Material> OMKBGIBJLIC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct KOLICHJFOBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public float3 JILMILDHLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public float3x3 FOJJHGMABOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public float OPLEFDPFCJG;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DLCDHJHIFNO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int KHBPCAMHKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 OJPCHPDDCAF(int LFBGKHDOJNO);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion AEMHDOLFCOB(int LFBGKHDOJNO);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float LOPOCPOAEFI(int LFBGKHDOJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PGOGCEBABLM : JMBBCJIGALM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EEMCFACAADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GHDHADLKKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float LOMHABMPDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int IGFAPKMCCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EGMNBLKHIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int IMGBMHIEIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<KOLICHJFOBE> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PGILHJFJMGB : JMBBCJIGALM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DOKODMHNDOA BJGONHHMLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KAELNHDLOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float3 MCBGKODEIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ILAFMLGLELN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	MHHODEBGAFD DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JBBPLPCKICC PELIOPKGAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface JMBBCJIGALM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OBHJHGHKLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EGNKGIONBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	MHHODEBGAFD DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	UniformTRS JMEPPMACPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float DNKGEMIKELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Vector3 FLDINEFDOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KOGANNKCGHD IPKABAFOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DOKJMPJMCCI CKGAINGGHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MHCAKCKGDAG
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int PMODDNHKKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Transform CKAFFCAFGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OLEHFGKLCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FGANHAMJGGJ GetBone(int LFBGKHDOJNO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int LFBGKHDOJNO);
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
