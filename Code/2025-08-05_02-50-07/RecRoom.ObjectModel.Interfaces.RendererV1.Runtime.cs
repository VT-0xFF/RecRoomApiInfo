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
public enum CPHNAPAEHAA
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
public enum MPJPIJDIFLM
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
public enum INMHHAMFOKG
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
public enum GLAENEDOOAG
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
public enum HGDKDFHGHAK
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
public enum HOPHEEHHBNP
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
public static class KPKLJKGFLMG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x847B5C0", Offset = "0x847A9C0", VA = "0x18847B5C0")]
	public static bool MFHJEFKOHIG(this HOPHEEHHBNP MPDMCOLCMID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x847B5B0", Offset = "0x847A9B0", VA = "0x18847B5B0")]
	public static bool CGDKLCNFPJG(this HOPHEEHHBNP MPDMCOLCMID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x847B5E0", Offset = "0x847A9E0", VA = "0x18847B5E0")]
	public static bool PPNIGONOFIL(this HOPHEEHHBNP MPDMCOLCMID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BMPAPPBHELN
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
public struct NGNHPGHDKAF : GFPDGFGKLAD, IEquatable<NGNHPGHDKAF>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int JHGBNCFKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBB0", Offset = "0x2FBAFB0", VA = "0x182FBBBB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBA0", Offset = "0x2FBAFA0", VA = "0x182FBBBA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JDPJAANKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x847B6B0", Offset = "0x847AAB0", VA = "0x18847B6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x13A86F0", Offset = "0x13A7AF0", VA = "0x1813A86F0", Slot = "8")]
	public bool Equals(NGNHPGHDKAF LHDOHAKINKP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8720", Offset = "0x3CF7B20", VA = "0x183CF8720")]
	public static bool ILMCFLMCOJH(NGNHPGHDKAF HCFCOMCPJPA, NGNHPGHDKAF JOCIBENNGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x847B610", Offset = "0x847AA10", VA = "0x18847B610", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x847B6F0", Offset = "0x847AAF0", VA = "0x18847B6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PGGHBPJAHOA : GFPDGFGKLAD, IEquatable<PGGHBPJAHOA>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int JHGBNCFKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBB0", Offset = "0x2FBAFB0", VA = "0x182FBBBB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBA0", Offset = "0x2FBAFA0", VA = "0x182FBBBA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JDPJAANKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x847CB40", Offset = "0x847BF40", VA = "0x18847CB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x13A86F0", Offset = "0x13A7AF0", VA = "0x1813A86F0", Slot = "8")]
	public bool Equals(PGGHBPJAHOA LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x847CAA0", Offset = "0x847BEA0", VA = "0x18847CAA0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x847CB80", Offset = "0x847BF80", VA = "0x18847CB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HGFJKNIGNKF : GFPDGFGKLAD, IEquatable<HGFJKNIGNKF>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JHGBNCFKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBB0", Offset = "0x2FBAFB0", VA = "0x182FBBBB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBA0", Offset = "0x2FBAFA0", VA = "0x182FBBBA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JDPJAANKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8479000", Offset = "0x8478400", VA = "0x188479000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x13A86F0", Offset = "0x13A7AF0", VA = "0x1813A86F0", Slot = "8")]
	public bool Equals(HGFJKNIGNKF LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8478F60", Offset = "0x8478360", VA = "0x188478F60", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IEKGCOIIEHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEFINHPDNKK(NGNHPGHDKAF LDEPDDDHLLO, MPJPIJDIFLM ODCHPDHAEIG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEFINHPDNKK(PGGHBPJAHOA PDPKIFONADM, MPJPIJDIFLM ODCHPDHAEIG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEGHIGKLGDE(PGGHBPJAHOA PDPKIFONADM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBCLKNBMKGD(PGGHBPJAHOA PDPKIFONADM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBEDOPKKEND();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFFHCACLGGG(MPJPIJDIFLM IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBFHCBBAPLH(NGNHPGHDKAF LDEPDDDHLLO);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LBFHCBBAPLH(PGGHBPJAHOA PDPKIFONADM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ODHBLFFAGOP(PGGHBPJAHOA PDPKIFONADM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OLONGAIHCIK(PGGHBPJAHOA PDPKIFONADM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CJLKBFCKBFF();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PGNKJFCHFGJ();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ODJMOENMFIF(NGNHPGHDKAF LDEPDDDHLLO, HGDKDFHGHAK IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OAHLGCBKCIP(PGGHBPJAHOA PDPKIFONADM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PLGJGLBPJAG(PGGHBPJAHOA PDPKIFONADM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HGDKODFIPMM();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void INABJPCEADE(HGDKDFHGHAK IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NPMMPDOMHIB(NGNHPGHDKAF LDEPDDDHLLO, Vector3 HLIBNOGBFGB, Vector3 OHICJDDOEPF, Vector3 AKDIOJJKIOG, float JEFDODKPPEO, float MHACNFDBKLN, IReadOnlyList<Camera> HDIANDGMECO, CPHNAPAEHAA DNGECPKMELJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NPMMPDOMHIB(HGFJKNIGNKF AIMCJDGDGHO, Vector3 HLIBNOGBFGB, Vector3 OHICJDDOEPF, Vector3 AKDIOJJKIOG, float JEFDODKPPEO, float MHACNFDBKLN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KGMOHGCFKDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DFCEPOIJMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGNHPGHDKAF MFEEAGOEAGJ(MIHILIACLNI NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGNHPGHDKAF MFEEAGOEAGJ(MIHILIACLNI NGIAGNLBILI, bool ACGCDEECLFB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLLAILIMPJF(NGNHPGHDKAF LDEPDDDHLLO);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJOADFFNFNB(NGNHPGHDKAF LDEPDDDHLLO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PGGHBPJAHOA AHKCAEKHEFG(NGNHPGHDKAF LDEPDDDHLLO, DDKMMPAGGHJ NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PGGHBPJAHOA IMCPDCMOLND(NGNHPGHDKAF LDEPDDDHLLO, GGBCEOMBCDB NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BONIDJPOPMM(PGGHBPJAHOA PDPKIFONADM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OJMEBJPPOBJ(PGGHBPJAHOA PDPKIFONADM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HGFJKNIGNKF CANGDOCPCPJ(CEGHCFFMHKC NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JLHEMFKGKKF(HGFJKNIGNKF AIMCJDGDGHO);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FENDJELKAHL(HGFJKNIGNKF AIMCJDGDGHO);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task FMHBLFALEIE();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LCLBJCKBBKC();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task HAFBOBCCKOE();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IPCPOFOBJAG();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> ECEOONLJOMH(NGNHPGHDKAF LDEPDDDHLLO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IINGJHHDOOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum NDGOLPMNFPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum HAECHOLFJMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum BHNEEHKHAFL
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
	public enum OICLECADOBH
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
	public enum OHDKFIAFJAD
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
	public enum EMKCJPKALNC
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
	public enum LILCJCMGJBN
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum DBELCPJIHCI
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
		LowQualityHighSpeed = 102
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool GBHOLFPHIOB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long EBEFCLLFNNC;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool MPAPIACBBIJ;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool JELGLJEDGDP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool EJHABOGCIGO;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float KLMPOFFPIAL;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float HCHAFLLMDHL;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int DALMBMHMIFC;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static EMKCJPKALNC AELGJCEBFGG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long LJCMEDDLNPE;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float IBEBEGFCBDG;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int DDOOKGNOKPH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int JKFICJDCLJD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int LEBFBIBLLPE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int DBEOCGAJONM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int DDICJKHGNJJ;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int PDPGCKJMHEE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int FHBGKKJDIGO;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int ECPMACNMNKD;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool CANMBDCHFPC;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int KCLHAPJHALP;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int DJLBODMNKDI;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int HHGMFJOEFMH;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool LIBFCIALOKA;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float PKMEMMKDNOA;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool OODCGLJGCBD;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float GGHCPGCPNIA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long CHLPJBCKCMF;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool LLNJMCMFNFL;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long IOFFJJIFMBD;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int JBKLIKMBJLC;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool LDFDPAJBENB;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static NDGOLPMNFPC GKMFPHIDOBC;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool ODDCOIKAKFP;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool MHAGLDGKBLE;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int JDBKJDKIMAA;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int DDJJOLOJPGE;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int PMBIGGBAJBO;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int FKBEFFNPAGG;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int HDNDBCOCDDA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int HMOBDEEJODI;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int HDCCEHLHGFI;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int FEOBJLMJLBG;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float NOEIFPINMFD;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float ADMEOHFBFKF;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float OGPFFEPBJAO;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float BJDKJLJJKLP;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int JPHIMKGKMEA;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int OLHGGCCLJMB;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int NGEGPOGBNDI;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int LDBFEAMBDAD;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool AEMJGLCMGFC;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static BHNEEHKHAFL MNILNKFGOPG;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static OICLECADOBH AGKDAADJCJH;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool PCJEEJEMDMG;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static HAECHOLFJMP FMPHOHJAGHG;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float DLBEAIFHOJH;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float JEINFFJDICH;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float DCJGBEBAGMA;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float JADMCILHFNF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float NKCNEPLAEPP;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float DPKIGMGNMJL;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float BLNPIEHANOG;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float BEAPAAIKBOL;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool NDKINMNNNAH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static LILCJCMGJBN ALOHLOLCCJF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool MIFFKJOKMLD;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float COIKNFFPHPN;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float HDEAFIEEKHN;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float DMGDHGIPOJI;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float IGEJJODNFCC;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float KHNCOJLOOAK;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool JFGAFNHPIHI;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long PLJLCGHGNMF;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float DPCPJGMKBNL;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float DOOJHDGHAEI;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float OPJAALFEGLJ;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int OFFKMMIIMCK;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float OMAMMGJJJPM;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool HPPNHCJODJK;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long PBDFALDNOKL;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int PDILAAOBGKG;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int BGHIKHDJHIK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float HCIKOLLGALG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float DLNOKBJCKPH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool HAPIOGMMLMC;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool FMJNCHMGLLD;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float ECMLKBJLAON;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long KCNBEOEJKBJ;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long ICCGFDDLIPO;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int NGMGFGBPJIE;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static bool LLIOIDHCKFO;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float CMLCDLPEGNL;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static float HNNOMNEHMHF;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static bool HGDPNEIKAAF;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long DLEAPFOIPCG;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int ILICLDCFPOP;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static float4x4 LEFNHGOIJLP;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static float3 HNHFKPNCDBN;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static bool EJBNEOLJKFE;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static OHDKFIAFJAD JKCNLJLAHNG;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long LAHHOOKCHPF;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int BBALNBILPDL;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int OFIFKIFGILH;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int GHIPCHBNKIB;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int HFFPEOIFOEI;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int ANMMHCEKGMF;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int ANHMMFGNBJB;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int JNFMDAKMMEF;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long LGNCHKCBNFD;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int CLCKBABLLON;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int ALFMKGLHAPI;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int HAMKKEPLOLM;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long OEJOACHLKCM;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long NKKOMDGBGOH;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long LDAGLAFDFOL;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long LLOCGAIGOCG;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int HJHKGLFNBGI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int PLIFHKCBCJF;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static int ICCDKINIHCG;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static int EIEGGDGAFCI;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int FDBEHIAFEOM;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int[] NGGOCGBBBJB;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int[] LCEBAEMCEGO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static int GCGKJEIBAEG;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long FNDLCALHBMI;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long MDLMDKBJMCN;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int FGHOFIOIAKB;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static int MLCOEBLCCPG;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long IJNDKDKNKOC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long NFKGKCGOHJD;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long BLLFJHGNPJO;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long JIAMELCPADO;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long PEGDHKKFMDP;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long GPIIEJOBHEM;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long PPKGMLJNJDO;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long NAHDEKMDDPP;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long FICBDNCHCAO;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float GKOHONDKJPE;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static float POKALDPICNI;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long OOPCCMDCOHK;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static int LLHINKHAEJL;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long DFLLBKFGHKH;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long CMHOCIFHLBK;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static float LPFJFJGEGEG;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long OAOLBGHICMK;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long MJGMLCNMIIL;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long KIBMGHKGFAH;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long OJALJJFIBKC;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long PPIBKIEPMFD;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long NBLIGDJPHMP;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static long GDKIKAOHFJD;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static long HPIHODCIMGP;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static long APGPHKICODA;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static long GOCGBCGPLEG;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static long KAKNBHFMFJG;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static long NOHJEMLGHEC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static DBELCPJIHCI MMIEEJPOAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x847A810", Offset = "0x8479C10", VA = "0x18847A810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long GIEMKCPBHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84796F0", Offset = "0x8478AF0", VA = "0x1884796F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8479040", Offset = "0x8478440", VA = "0x188479040")]
	public static void CJKNLFPPOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8479750", Offset = "0x8478B50", VA = "0x188479750")]
	public static void MCKDFLMDPCE(DBELCPJIHCI JPBLMAOFPOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EHDLGILHEEO
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct JEPHHAELKKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Vector3 BKPAIEKHLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Quaternion GGEGPGBJIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public float LOJLBBEMLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Quaternion NIOILDPMIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public float DDHKFNGMPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public float BHFNEOBOLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public float CBMJGGHCNMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static List<JEPHHAELKKO> POLCCHFMAOJ;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8478950", Offset = "0x8477D50", VA = "0x188478950")]
	public static NativeList<ABIKCOMHDNG> PGGOFOEHGJP(BNGPGNBMHDI LFDKNECEJEF)
	{
		return default(NativeList<ABIKCOMHDNG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8476380", Offset = "0x8475780", VA = "0x188476380")]
	private static bool HANGHNCMODB(int LBMGGFIIAAK, NativeList<ABIKCOMHDNG> HJBCDFKDKBA, List<JEPHHAELKKO> IGHFJGAAJJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84787D0", Offset = "0x8477BD0", VA = "0x1884787D0")]
	private static ABIKCOMHDNG OBAELPNBPKK(int PFKMHLGKANI, List<JEPHHAELKKO> IGHFJGAAJJJ)
	{
		return default(ABIKCOMHDNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8475E90", Offset = "0x8475290", VA = "0x188475E90")]
	private static ABIKCOMHDNG DFPEILPKOCA(int PFKMHLGKANI, List<JEPHHAELKKO> IGHFJGAAJJJ)
	{
		return default(ABIKCOMHDNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8477230", Offset = "0x8476630", VA = "0x188477230")]
	private static ABIKCOMHDNG JNHJFHIBOCA(Vector3 DPIFCOHCFGC, Quaternion AOLCBAKAICF, float FLMDAOGEKMO)
	{
		return default(ABIKCOMHDNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8477310", Offset = "0x8476710", VA = "0x188477310")]
	public static NativeList<ABIKCOMHDNG> LEMOEAFCNDD(BNGPGNBMHDI LFDKNECEJEF, float LMPEIAFEMIK)
	{
		return default(NativeList<ABIKCOMHDNG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NKDDGELLHPB
{
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static Vector3 MHNIJAMGCNA;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static Vector3 DBAEICFFOEG;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly float CFHDEDLFNBF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x847BB90", Offset = "0x847AF90", VA = "0x18847BB90")]
	public static Vector3 GPKLLBGFMJO(Vector3 MDDFLLOOHHF, Quaternion AOLCBAKAICF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x847C180", Offset = "0x847B580", VA = "0x18847C180")]
	public static Vector3 IOFFJMKOENI(Quaternion EMLGDFFEJED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x847B780", Offset = "0x847AB80", VA = "0x18847B780")]
	public static Vector3 AHHLKKBEDFM(Quaternion EMLGDFFEJED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x847B820", Offset = "0x847AC20", VA = "0x18847B820")]
	public static Quaternion CGDGALEKHHP(Vector3 NLDMHMFAEEN, Vector3 KIAHAFCJEPK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x847C7D0", Offset = "0x847BBD0", VA = "0x18847C7D0")]
	public static Vector3 PNCLHGOHLKM(Vector3 KOJHHMDDDBC, Vector3 AKCIPOMLOMP, Vector3 KIAHAFCJEPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x847C220", Offset = "0x847B620", VA = "0x18847C220")]
	public static Vector3 KKPGAPOGMIG(Vector3 MDDFLLOOHHF, Vector3 KIAHAFCJEPK, Quaternion EMLGDFFEJED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x847BE20", Offset = "0x847B220", VA = "0x18847BE20")]
	public static Quaternion HNCAFKGJKOF(Quaternion AOLCBAKAICF, Vector3 NLDMHMFAEEN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x847C650", Offset = "0x847BA50", VA = "0x18847C650")]
	public static bool NBDAEHLBOAD(Vector3 GNAJDOMOPFK, Vector3 EDDMJKOKAOA, [Out] Vector3 NJGCOCEOHFP, bool JLPCPJNHOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x847B8A0", Offset = "0x847ACA0", VA = "0x18847B8A0")]
	public static Vector3 DAOLPDGDLNN(bool GCIELKLJDFM, [Optional] Quaternion ABCPPNECKJO)
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
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public float heightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public BMPAPPBHELN topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public BMPAPPBHELN slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct TerrainWaterProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public bool WaterEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public float WaterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public Color WaterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public Color DeepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public float EmissiveStrength;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public GLJNFGKKOAM baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public bool normalizeLayerHeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public PBFAHNBOMEH playArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public float playAreaOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public TerrainWaterProperties globalWaterProperties;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x847CC10", Offset = "0x847C010", VA = "0x18847CC10")]
		public TerrainGenerationInfo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct TerrainInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public float GroundHeight;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FEHAOOEIAFB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	TerrainData EBOELBFPLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject HOJFKHNGPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 LBDGHAAOJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	TerrainGenerationInfo ACKIPALMEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	TerrainInfo DLGFNEGHBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<bool> OJHMOEPABCH(uint DEMHLMIPBKA, bool GDGMKNPHFMD = true, bool FHELBENKMEI = true, bool EGLOICIAFGH = true, [Optional] TerrainGenerationInfo LFDKNECEJEF, LIJDKGLMFLG EPEEONHABJP = LIJDKGLMFLG.Default, [Optional] float3? KMEOAOMKDCH, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ONLDIMNIKII(bool FNEOANGHAFI);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMIGGMKKHNH(Action<Material> DBGKPIKFMDK);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ABIKCOMHDNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public float3 BKPAIEKHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public float3x3 GGEGPGBJIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public float LOJLBBEMLJN;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BNGPGNBMHDI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int NAKDCOGPEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NDLNKFKIFCC(int PFKMHLGKANI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion PJAGBCADLFH(int PFKMHLGKANI);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float KMDGNMMFJCA(int PFKMHLGKANI);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GGBCEOMBCDB : KAFHCNKFIJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool AFJMPBCMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool GFMCGDGBAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float JLFFJAAFCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int JOLDDADFICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool HNCCECMKHON
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int IDMNAMECOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<ABIKCOMHDNG> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DDKMMPAGGHJ : KAFHCNKFIJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	INMHHAMFOKG OAEMCKKJKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JMCJHIKCPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float3 AKGJJMKBJPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MIHILIACLNI
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	GIJLHKFOFFB MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	GLAENEDOOAG NJEDNIOLCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface KAFHCNKFIJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ONJGLIEOOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool EGDNHCMNBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	GIJLHKFOFFB MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	UniformTRS MGBOOPBPIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float MEODOKMAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	Vector3 NJLDOKPPBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	HOPHEEHHBNP LJOMBHFFMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	BMPAPPBHELN NJOJNJGDCED
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CEGHCFFMHKC
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int NNDHDJIEFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Transform OJENGLIPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool KGPJOJHAPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGNHPGHDKAF GetBone(int PFKMHLGKANI);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int PFKMHLGKANI);
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
