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
public enum CIDHMNMLPOB
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
public enum JHEIHPJJONE
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
public enum BGAPCNLHHPL
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
public enum KPNBLOEFJLM
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
public enum NAOAHHFOEAM
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
public enum HOLOGFIEFDN
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
public static class AKHOFKKBIMD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x73761F0", Offset = "0x73753F0", VA = "0x1873761F0")]
	public static bool HAHEMJKJNHN(this HOLOGFIEFDN BODFLPCGHLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7376210", Offset = "0x7375410", VA = "0x187376210")]
	public static bool LKNODFBGFBB(this HOLOGFIEFDN BODFLPCGHLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7376220", Offset = "0x7375420", VA = "0x187376220")]
	public static bool OIMHACLFLEM(this HOLOGFIEFDN BODFLPCGHLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DIABBMOAIAG
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
public struct IMHPOJOIOJD : LODJCBKGHME, IEquatable<IMHPOJOIOJD>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int DCLMEHAOAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B3F0", Offset = "0x2B3A5F0", VA = "0x182B3B3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x655CDD0", Offset = "0x655BFD0", VA = "0x18655CDD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CLGLGAODANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7379410", Offset = "0x7378610", VA = "0x187379410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1659BE0", Offset = "0x1658DE0", VA = "0x181659BE0", Slot = "8")]
	public bool Equals(IMHPOJOIOJD JAINJPLCLDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x32F7E70", Offset = "0x32F7070", VA = "0x1832F7E70")]
	public static bool CCHBIHOFELC(IMHPOJOIOJD KKLLOEEDINO, IMHPOJOIOJD NHCGDJCFKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7379450", Offset = "0x7378650", VA = "0x187379450", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x73794E0", Offset = "0x73786E0", VA = "0x1873794E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PBANANEDPKJ : LODJCBKGHME, IEquatable<PBANANEDPKJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int DCLMEHAOAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B3F0", Offset = "0x2B3A5F0", VA = "0x182B3B3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x655CDD0", Offset = "0x655BFD0", VA = "0x18655CDD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CLGLGAODANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x73807C0", Offset = "0x737F9C0", VA = "0x1873807C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1659BE0", Offset = "0x1658DE0", VA = "0x181659BE0", Slot = "8")]
	public bool Equals(PBANANEDPKJ JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7380800", Offset = "0x737FA00", VA = "0x187380800", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7380890", Offset = "0x737FA90", VA = "0x187380890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BCIEDBLKKKE : LODJCBKGHME, IEquatable<BCIEDBLKKKE>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DCLMEHAOAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B3F0", Offset = "0x2B3A5F0", VA = "0x182B3B3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x655CDD0", Offset = "0x655BFD0", VA = "0x18655CDD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CLGLGAODANF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7376250", Offset = "0x7375450", VA = "0x187376250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1659BE0", Offset = "0x1658DE0", VA = "0x181659BE0", Slot = "8")]
	public bool Equals(BCIEDBLKKKE JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7376290", Offset = "0x7375490", VA = "0x187376290", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AOFAIHBKPNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCLABFHHHCN(IMHPOJOIOJD DONMCNODAED, JHEIHPJJONE EIHFAHFNELO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCLABFHHHCN(PBANANEDPKJ OIEMAHGGLND, JHEIHPJJONE EIHFAHFNELO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOPEAMLHKNI(PBANANEDPKJ OIEMAHGGLND);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LCLFMIGIOFE(PBANANEDPKJ OIEMAHGGLND);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNGHAFIOJAI();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HNNODGFIPGI(JHEIHPJJONE MDOOANEGCAH);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBLINJALCDE(IMHPOJOIOJD DONMCNODAED);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CBLINJALCDE(PBANANEDPKJ OIEMAHGGLND);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MLDEBGIOJAL(PBANANEDPKJ OIEMAHGGLND);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PEEJDHFICOP(PBANANEDPKJ OIEMAHGGLND);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LLLOPOFNOKF();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HLOIDLCMLKC();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BBICIGKPBLI(IMHPOJOIOJD DONMCNODAED, NAOAHHFOEAM MDOOANEGCAH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NOEPJLKCJGE(PBANANEDPKJ OIEMAHGGLND);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BBAFNLACGGD(PBANANEDPKJ OIEMAHGGLND);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KPMDMMKJHHM();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PDECCLNGIPE(NAOAHHFOEAM MDOOANEGCAH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BIMDKAAKBLO(IMHPOJOIOJD DONMCNODAED, Vector3 AOGFPLLALGP, Vector3 AGICILCMAEG, Vector3 LIPEJHCDLPH, float PMMKCKEHAPL, float IEECDIDGDFI, IReadOnlyList<Camera> AEEMIEDKFGL, CIDHMNMLPOB JFGHHALANHN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BIMDKAAKBLO(BCIEDBLKKKE AFJALLPMKEA, Vector3 AOGFPLLALGP, Vector3 AGICILCMAEG, Vector3 LIPEJHCDLPH, float PMMKCKEHAPL, float IEECDIDGDFI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ELNPEFEPDJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DEILIEJMOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMHPOJOIOJD IDILFGPPLEF(HDHNHBENNJN LFDKFEEPNFP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMHPOJOIOJD IDILFGPPLEF(HDHNHBENNJN LFDKFEEPNFP, bool PBEDLABPMCH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNJADDCDFDF(IMHPOJOIOJD DONMCNODAED);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDDMFANMNBI(IMHPOJOIOJD DONMCNODAED);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PBANANEDPKJ CNMOGFDLGMH(IMHPOJOIOJD DONMCNODAED, CHNJCLCIIHF LFDKFEEPNFP);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PBANANEDPKJ AFFFFFJNNKP(IMHPOJOIOJD DONMCNODAED, OPFNBBFLGAH LFDKFEEPNFP);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CMHNFCLKEIP(PBANANEDPKJ OIEMAHGGLND);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PPOJNAFMKCE(PBANANEDPKJ OIEMAHGGLND);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BCIEDBLKKKE CHIKONACMIC(ADAAAHJJBMK LFDKFEEPNFP);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GNDAPGAGGMO(BCIEDBLKKKE AFJALLPMKEA);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JNFMLDHODLO(BCIEDBLKKKE AFJALLPMKEA);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task EMBODPCNIOE();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task KDLBMACPGNE();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task NPMFPDGABNB();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HDCBNDMCGGE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> PIDJDPIJDNG(IMHPOJOIOJD DONMCNODAED);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OMOLDBLBGOD
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum MGMLKHPDEEP
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum FGNCFAHJMHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum MMGAEEBKCKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		RefreshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum JCEBNKPJGJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum LMNBLNPIBJL
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum FAEOMAAHAFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum HPODFCINGCP
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum ILEOJCJMEGD
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		LAST = 101
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool PCPAGCOLMFH;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static long FAELHHMFJEE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float FDMPEBEGLGM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static bool LDMLMDOGIEG;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static long DHJGKFDGIPA;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static int CCLLEOLILOO;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool BGLBLLHGPLD;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static FGNCFAHJMHI GOOBBBEPFEM;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float GJACPBIHFLN;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float LAOGOFPOKOG;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static HPODFCINGCP MOKCAKJMOAJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool KHBFEEDJDIC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static float IDPIMAALFDH;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static float LHLHHELAEOP;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float ENEELIMFCPN;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float JOFIMLMNOAB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float AHHLGDOENLG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long DJLGAHAIPDO;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static long HHMGCBMOICJ;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static int FEALJJKNMDJ;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static bool EPMECGECIAF;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static long COOMOFJJNNL;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static int GBADBLJDPHE;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static int OKBJGKDFBLA;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static int HLIBMKPEPHP;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static long NIDCFPIAHLL;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long GANIPKABOAO;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int OMOLPHJKEHK;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int HGHMBPIANDB;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int JOIJPLIODFJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static long FBNMAEEPDNK;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static long HLHFECPBDFN;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long PDHCDCEDDOA;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static long DGKLLBMGJGG;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int GDEDMHCOAPF;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int PDJEBFNBGMD;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int FBGIBDDJHLD;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int LLKKGJGOMFI;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int[] NMELOAHOPAH;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int HIPPMKKPBPF;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long EDJFCCGDHHL;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static long AHOKPPFGDFH;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int DLFPFFOAPOM;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static long MCPFNDMCDBL;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long KPOEIFPAFDH;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long HJOMNGNDBAF;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long GDMHDNKKCDF;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long IAHOFNBOEFN;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static long LGINEMDEKEL;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static long NNFMFMCLJIB;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long KHOGLCJEDCA;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long FPGOINGIODC;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static float EJLOJNNGKMG;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long GJOBFLGGDAJ;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int KGLOPBIFJKJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long ABKOMCJOHPP;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long JPHNPKPILFL;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static float LGEGGLALOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long LKFFONMMHME;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static long ONHCCNHEDHN;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long HDKPGCLGANH;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long CINJAPDOOAN;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long LENBEFOPFOE;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long CEKEGEICDAN;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long KCHAPIHHHMI;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long FFKJKGBEAIE;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long KEFCBCAPJND;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long KGPAMEAOJCK;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long MACHJFHANPM;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long BCIFFIBLMPH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool HHCMEMHIOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x737D290", Offset = "0x737C490", VA = "0x18737D290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x737CA10", Offset = "0x737BC10", VA = "0x18737CA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static ILEOJCJMEGD NEDAECCINBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x737D340", Offset = "0x737C540", VA = "0x18737D340")]
		[CompilerGenerated]
		get
		{
			return default(ILEOJCJMEGD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x737EF70", Offset = "0x737E170", VA = "0x18737EF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool NCABPEADIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x737F7F0", Offset = "0x737E9F0", VA = "0x18737F7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x737C950", Offset = "0x737BB50", VA = "0x18737C950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool AIHIPMCBEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x737AB10", Offset = "0x7379D10", VA = "0x18737AB10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x737D230", Offset = "0x737C430", VA = "0x18737D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float DFMOIDLEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x737F080", Offset = "0x737E280", VA = "0x18737F080")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x737F250", Offset = "0x737E450", VA = "0x18737F250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float AKBABKNFJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x737B060", Offset = "0x737A260", VA = "0x18737B060")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x737D740", Offset = "0x737C940", VA = "0x18737D740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int DAHLELOCFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x737D450", Offset = "0x737C650", VA = "0x18737D450")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x737F4E0", Offset = "0x737E6E0", VA = "0x18737F4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static FAEOMAAHAFO CFKLANAMOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x737B230", Offset = "0x737A430", VA = "0x18737B230")]
		[CompilerGenerated]
		get
		{
			return default(FAEOMAAHAFO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x737B440", Offset = "0x737A640", VA = "0x18737B440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long LCILHAELDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x737F2B0", Offset = "0x737E4B0", VA = "0x18737F2B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x737F670", Offset = "0x737E870", VA = "0x18737F670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float NFBHLNGIEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x737CD70", Offset = "0x737BF70", VA = "0x18737CD70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x737B320", Offset = "0x737A520", VA = "0x18737B320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int CFDEPACIHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x737B280", Offset = "0x737A480", VA = "0x18737B280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x737F960", Offset = "0x737EB60", VA = "0x18737F960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int AKNLBBCNCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x737A8F0", Offset = "0x7379AF0", VA = "0x18737A8F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x737A9A0", Offset = "0x7379BA0", VA = "0x18737A9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int MHJIBIHNGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x737EEC0", Offset = "0x737E0C0", VA = "0x18737EEC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x737CF90", Offset = "0x737C190", VA = "0x18737CF90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int OOPDPPMBMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x737C640", Offset = "0x737B840", VA = "0x18737C640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x737D7A0", Offset = "0x737C9A0", VA = "0x18737D7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int FHBNMOIDGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x737F9C0", Offset = "0x737EBC0", VA = "0x18737F9C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x737B4A0", Offset = "0x737A6A0", VA = "0x18737B4A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int PLIDIJLKBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x737AA00", Offset = "0x7379C00", VA = "0x18737AA00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x737D9D0", Offset = "0x737CBD0", VA = "0x18737D9D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int KBKHLBMCHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x737EE70", Offset = "0x737E070", VA = "0x18737EE70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x737AD00", Offset = "0x7379F00", VA = "0x18737AD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool LAAJJAJBOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x737D800", Offset = "0x737CA00", VA = "0x18737D800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int NCENFICAKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x737D690", Offset = "0x737C890", VA = "0x18737D690")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x737DA90", Offset = "0x737CC90", VA = "0x18737DA90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int BODAHEHBMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x737FB90", Offset = "0x737ED90", VA = "0x18737FB90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x737DA30", Offset = "0x737CC30", VA = "0x18737DA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int JFEGOJHLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x737B2D0", Offset = "0x737A4D0", VA = "0x18737B2D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x737F130", Offset = "0x737E330", VA = "0x18737F130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool CGIBGDNPPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x737F030", Offset = "0x737E230", VA = "0x18737F030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x737C5E0", Offset = "0x737B7E0", VA = "0x18737C5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float DJENBIONKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x737FBE0", Offset = "0x737EDE0", VA = "0x18737FBE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x737AF40", Offset = "0x737A140", VA = "0x18737AF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static bool CGFGNIFAFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x737CF40", Offset = "0x737C140", VA = "0x18737CF40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x737C750", Offset = "0x737B950", VA = "0x18737C750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool PJNIAGHIDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x737CB30", Offset = "0x737BD30", VA = "0x18737CB30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x737AAB0", Offset = "0x7379CB0", VA = "0x18737AAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static MGMLKHPDEEP NMOJKCEEFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x737D3F0", Offset = "0x737C5F0", VA = "0x18737D3F0")]
		[CompilerGenerated]
		get
		{
			return default(MGMLKHPDEEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x737FB30", Offset = "0x737ED30", VA = "0x18737FB30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool KINFEAOMJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x737CCB0", Offset = "0x737BEB0", VA = "0x18737CCB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x737FA10", Offset = "0x737EC10", VA = "0x18737FA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool ACOBOMDGJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x737DAF0", Offset = "0x737CCF0", VA = "0x18737DAF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x737AE20", Offset = "0x737A020", VA = "0x18737AE20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int LMGFMACEEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x737C520", Offset = "0x737B720", VA = "0x18737C520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x737CEE0", Offset = "0x737C0E0", VA = "0x18737CEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int KHMFIOLPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x737D560", Offset = "0x737C760", VA = "0x18737D560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x737F1F0", Offset = "0x737E3F0", VA = "0x18737F1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int AIGAAPMNOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x737D0B0", Offset = "0x737C2B0", VA = "0x18737D0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x737AE80", Offset = "0x737A080", VA = "0x18737AE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int FHICCDODNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x737F900", Offset = "0x737EB00", VA = "0x18737F900")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x737AA50", Offset = "0x7379C50", VA = "0x18737AA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int JNIGCPJPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x737F840", Offset = "0x737EA40", VA = "0x18737F840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x737D8B0", Offset = "0x737CAB0", VA = "0x18737D8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int DHBKIICOBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x737C9B0", Offset = "0x737BBB0", VA = "0x18737C9B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x737ADC0", Offset = "0x7379FC0", VA = "0x18737ADC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int HIKLBKBAHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x737F610", Offset = "0x737E810", VA = "0x18737F610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x737D970", Offset = "0x737CB70", VA = "0x18737D970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static int DAKHGEAIJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x737D500", Offset = "0x737C700", VA = "0x18737D500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x737EF10", Offset = "0x737E110", VA = "0x18737EF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float IBGKKINHNCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x737AEE0", Offset = "0x737A0E0", VA = "0x18737AEE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x737B380", Offset = "0x737A580", VA = "0x18737B380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float OKMNMEKCBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x737CAD0", Offset = "0x737BCD0", VA = "0x18737CAD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x737EFD0", Offset = "0x737E1D0", VA = "0x18737EFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float JHFKKGPDHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x737D910", Offset = "0x737CB10", VA = "0x18737D910")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x737F6D0", Offset = "0x737E8D0", VA = "0x18737F6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int JCMHAPPFBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x737D170", Offset = "0x737C370", VA = "0x18737D170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x737F730", Offset = "0x737E930", VA = "0x18737F730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int ONCEBMNBNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x737D6E0", Offset = "0x737C8E0", VA = "0x18737D6E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x737C690", Offset = "0x737B890", VA = "0x18737C690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int JDGKIFCKOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x737C6F0", Offset = "0x737B8F0", VA = "0x18737C6F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x737CC50", Offset = "0x737BE50", VA = "0x18737CC50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int AGHMBMLOFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x737C870", Offset = "0x737BA70", VA = "0x18737C870")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x737EE10", Offset = "0x737E010", VA = "0x18737EE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static bool LMPGLNPHJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x737AB60", Offset = "0x7379D60", VA = "0x18737AB60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x737C4C0", Offset = "0x737B6C0", VA = "0x18737C4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static MMGAEEBKCKG NFGOJHKOLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x737F0D0", Offset = "0x737E2D0", VA = "0x18737F0D0")]
		[CompilerGenerated]
		get
		{
			return default(MMGAEEBKCKG);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x737C7B0", Offset = "0x737B9B0", VA = "0x18737C7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static JCEBNKPJGJD MELGFLEOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x737CE80", Offset = "0x737C080", VA = "0x18737CE80")]
		[CompilerGenerated]
		get
		{
			return default(JCEBNKPJGJD);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x737F480", Offset = "0x737E680", VA = "0x18737F480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool JDEKBILMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x737CFF0", Offset = "0x737C1F0", VA = "0x18737CFF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x737B1D0", Offset = "0x737A3D0", VA = "0x18737B1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static float COFHCBIILEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x737FAD0", Offset = "0x737ECD0", VA = "0x18737FAD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x737B170", Offset = "0x737A370", VA = "0x18737B170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float DDBHEHCADHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x737D110", Offset = "0x737C310", VA = "0x18737D110")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x737D850", Offset = "0x737CA50", VA = "0x18737D850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float JMPKHIGJKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x737B3E0", Offset = "0x737A5E0", VA = "0x18737B3E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x737F8A0", Offset = "0x737EAA0", VA = "0x18737F8A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float OBNIPDGDDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x737D390", Offset = "0x737C590", VA = "0x18737D390")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x737FA70", Offset = "0x737EC70", VA = "0x18737FA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float JKGBOEOBCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x737CD10", Offset = "0x737BF10", VA = "0x18737CD10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x737CDC0", Offset = "0x737BFC0", VA = "0x18737CDC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static float JIBLBIOBEON
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x737F190", Offset = "0x737E390", VA = "0x18737F190")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x737CB90", Offset = "0x737BD90", VA = "0x18737CB90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static bool PADLDJHMMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x737ABC0", Offset = "0x7379DC0", VA = "0x18737ABC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x737D1D0", Offset = "0x737C3D0", VA = "0x18737D1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float PFGBPICBNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x737AD60", Offset = "0x7379F60", VA = "0x18737AD60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x737D2E0", Offset = "0x737C4E0", VA = "0x18737D2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float JJDMOFLBDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x737A940", Offset = "0x7379B40", VA = "0x18737A940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x737CBF0", Offset = "0x737BDF0", VA = "0x18737CBF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static float BDFENAEHHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x737D4A0", Offset = "0x737C6A0", VA = "0x18737D4A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x737ACA0", Offset = "0x7379EA0", VA = "0x18737ACA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static int MAOKOBFHJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x737F300", Offset = "0x737E500", VA = "0x18737F300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x737F3C0", Offset = "0x737E5C0", VA = "0x18737F3C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static float OIMJONMDLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x737B0B0", Offset = "0x737A2B0", VA = "0x18737B0B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static bool CHGGJNGDEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x737D050", Offset = "0x737C250", VA = "0x18737D050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x737F540", Offset = "0x737E740", VA = "0x18737F540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static int ODNFNIOBLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x737AFA0", Offset = "0x737A1A0", VA = "0x18737AFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x737CE20", Offset = "0x737C020", VA = "0x18737CE20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static float GOAGBNOKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x737F420", Offset = "0x737E620", VA = "0x18737F420")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x737CA70", Offset = "0x737BC70", VA = "0x18737CA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float FCCMCNHIDAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x737F360", Offset = "0x737E560", VA = "0x18737F360")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x737A890", Offset = "0x7379A90", VA = "0x18737A890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static bool GECEKEIHBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x737C810", Offset = "0x737BA10", VA = "0x18737C810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x737F790", Offset = "0x737E990", VA = "0x18737F790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static float JGJAMLKNHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x737B000", Offset = "0x737A200", VA = "0x18737B000")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x737DB50", Offset = "0x737CD50", VA = "0x18737DB50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static float4x4 MEFHAEAJBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x737AC20", Offset = "0x7379E20", VA = "0x18737AC20")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x737C8D0", Offset = "0x737BAD0", VA = "0x18737C8D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static float3 OINAAPAGALN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x737D620", Offset = "0x737C820", VA = "0x18737D620")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x737F5A0", Offset = "0x737E7A0", VA = "0x18737F5A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static bool FNEAHEMKILK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x737C580", Offset = "0x737B780", VA = "0x18737C580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x737B500", Offset = "0x737A700", VA = "0x18737B500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static LMNBLNPIBJL MJMGELLAIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x737B110", Offset = "0x737A310", VA = "0x18737B110")]
		[CompilerGenerated]
		get
		{
			return default(LMNBLNPIBJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x737D5C0", Offset = "0x737C7C0", VA = "0x18737D5C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x737DBB0", Offset = "0x737CDB0", VA = "0x18737DBB0")]
	public static void LGCNBOIHHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x737B560", Offset = "0x737A760", VA = "0x18737B560")]
	public static void ECIJMIAGHMF(ILEOJCJMEGD AOMMHJOGMKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FFHOCAMALNE
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct JIJKAFPBEOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Vector3 FJKLEJNIMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Quaternion KONNNOOBJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public float LCLNBBEBIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public Quaternion GFPIPBFEIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public float NOICAIDCCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public float HCEBKOIHILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public float IBDHNAIDHAL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static List<JIJKAFPBEOK> KMBLAJCICMH;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x73764A0", Offset = "0x73756A0", VA = "0x1873764A0")]
	public static NativeList<CHNNPJCIGPE> DJBADMFPGPN(CEJNEKCLMGD AFIJJNIIMIC)
	{
		return default(NativeList<CHNNPJCIGPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7376F30", Offset = "0x7376130", VA = "0x187376F30")]
	private static bool HODFONGDOJK(int KPGFBDAMCDA, NativeList<CHNNPJCIGPE> NJFLHCEDIDN, List<JIJKAFPBEOK> EDBAMDEJCNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7376320", Offset = "0x7375520", VA = "0x187376320")]
	private static CHNNPJCIGPE BDBOIKPPAPC(int ODMGJHMGBIJ, List<JIJKAFPBEOK> EDBAMDEJCNN)
	{
		return default(CHNNPJCIGPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7376A40", Offset = "0x7375C40", VA = "0x187376A40")]
	private static CHNNPJCIGPE HICILKENNIH(int ODMGJHMGBIJ, List<JIJKAFPBEOK> EDBAMDEJCNN)
	{
		return default(CHNNPJCIGPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7377DE0", Offset = "0x7376FE0", VA = "0x187377DE0")]
	private static CHNNPJCIGPE IIOOJHHFPAM(Vector3 DLAJPPBHBJG, Quaternion EBCDHKCKBJF, float COBBNHPDFBH)
	{
		return default(CHNNPJCIGPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7377EC0", Offset = "0x73770C0", VA = "0x187377EC0")]
	public static NativeList<CHNNPJCIGPE> LKGMPPFHCDN(CEJNEKCLMGD AFIJJNIIMIC, float BFMBHJGHBHF)
	{
		return default(NativeList<CHNNPJCIGPE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LOPOFDEJHIG
{
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public static Vector3 AOCCAFEBFDH;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public static Vector3 LMJBEFBPJPJ;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public static readonly float LOPLJCHHDIJ;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7379570", Offset = "0x7378770", VA = "0x187379570")]
	public static Vector3 BFIHFNCGIJM(Vector3 ICEKNNNBDDP, Quaternion EBCDHKCKBJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7379D80", Offset = "0x7378F80", VA = "0x187379D80")]
	public static Vector3 JBFMAHANCDG(Quaternion EGIHDGHICMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7379CE0", Offset = "0x7378EE0", VA = "0x187379CE0")]
	public static Vector3 GADIJJMFOAG(Quaternion EGIHDGHICMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x737A730", Offset = "0x7379930", VA = "0x18737A730")]
	public static Quaternion ONAKJPIPAJE(Vector3 BDIPLNMOFCC, Vector3 LAOLFCMCDHJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x737A110", Offset = "0x7379310", VA = "0x18737A110")]
	public static Vector3 MDLFANFGADP(Vector3 IHOPBLEMGHL, Vector3 NBGHLCNEENA, Vector3 LAOLFCMCDHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x737A300", Offset = "0x7379500", VA = "0x18737A300")]
	public static Vector3 OEBKABBDLMC(Vector3 ICEKNNNBDDP, Vector3 LAOLFCMCDHJ, Quaternion EGIHDGHICMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7379800", Offset = "0x7378A00", VA = "0x187379800")]
	public static Quaternion CHIHLPGLJFC(Quaternion EBCDHKCKBJF, Vector3 BDIPLNMOFCC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7379B60", Offset = "0x7378D60", VA = "0x187379B60")]
	public static bool EHBOFCBPBAJ(Vector3 NADOGPLOFIA, Vector3 MMBODFCNKKC, [Out] Vector3 HBNFPIEAGBH, bool BHGFNDALEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7379E20", Offset = "0x7379020", VA = "0x187379E20")]
	public static Vector3 LEBKLOMCMCE(bool MIFCDJBLEEM, [Optional] Quaternion JHBOCPNEKMG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CHNNPJCIGPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public float3 FJKLEJNIMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public float3x3 KONNNOOBJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public float LCLNBBEBIBB;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CEJNEKCLMGD
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	int BMLCPCDBDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 GPEGFDEOPBM(int ODMGJHMGBIJ);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion FKOHIEFJEJL(int ODMGJHMGBIJ);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float PIJDBJIFDEL(int ODMGJHMGBIJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OPFNBBFLGAH : FDIGCKFAKMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool IFBNJBLNAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool EOAJJMHPLKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float JECNBNFELJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	int CIBDACEALGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool APNNOIKDMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int BPHDAHGENNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CHNNPJCIGPE> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CHNJCLCIIHF : FDIGCKFAKMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	BGAPCNLHHPL LDFDLFIBENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool LBIGOPPPGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float3 AKNGNLDICHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HDHNHBENNJN
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	HLDKLCEAPAJ JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	KPNBLOEFJLM PILNDFLHAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FDIGCKFAKMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool EEAJIDDKMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool JPGHINMJOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	HLDKLCEAPAJ JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	UniformTRS CBLGGEKCDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float FCGKFCHPEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Vector3 LHMIOHCJKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	HOLOGFIEFDN IMNNFMCBHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	DIABBMOAIAG LMABKKODKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ADAAAHJJBMK
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int IGIOGIMMHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Transform IJIMMPMDIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool AGJICBBEJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMHPOJOIOJD GetBone(int ODMGJHMGBIJ);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int ODMGJHMGBIJ);
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
