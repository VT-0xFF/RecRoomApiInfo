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
public enum GFCMMAOCIGI
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
public enum OHFCNPENGBB
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
public enum KHEAFOBJNAC
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
public enum AKHIENPNMHJ
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
public enum AGNEHGOBOAO
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
public enum ILGMMPAEBOD
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
public static class JGPHOJHDMAE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3290", Offset = "0x6CA1C90", VA = "0x186CA3290")]
	public static bool KLPNDBMGHDD(this ILGMMPAEBOD NAKAEDDMOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6CA32E0", Offset = "0x6CA1CE0", VA = "0x186CA32E0")]
	public static bool PPOCDJDPHBO(this ILGMMPAEBOD NAKAEDDMOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6CA32B0", Offset = "0x6CA1CB0", VA = "0x186CA32B0")]
	public static bool KONMIELGOGP(this ILGMMPAEBOD NAKAEDDMOMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FHMDBDPAHKN
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
public struct POMPLEGKFCO : JEDKKJGHJPP, IEquatable<POMPLEGKFCO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int PCGHHNFLFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26E9F30", Offset = "0x26E8930", VA = "0x1826E9F30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F64670", Offset = "0x5F63070", VA = "0x185F64670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DDBKACNOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6CA47E0", Offset = "0x6CA31E0", VA = "0x186CA47E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2037530", Offset = "0x2035F30", VA = "0x182037530", Slot = "8")]
	public bool Equals(POMPLEGKFCO CGCLEIBHLHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B578F0", Offset = "0x6B562F0", VA = "0x186B578F0")]
	public static bool DCLBGLCHDNG(POMPLEGKFCO KPNKONMDFPM, POMPLEGKFCO NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4750", Offset = "0x6CA3150", VA = "0x186CA4750", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4820", Offset = "0x6CA3220", VA = "0x186CA4820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JHJMOICONME : JEDKKJGHJPP, IEquatable<JHJMOICONME>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int PCGHHNFLFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x26E9F30", Offset = "0x26E8930", VA = "0x1826E9F30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5F64670", Offset = "0x5F63070", VA = "0x185F64670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DDBKACNOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3380", Offset = "0x6CA1D80", VA = "0x186CA3380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2037530", Offset = "0x2035F30", VA = "0x182037530", Slot = "8")]
	public bool Equals(JHJMOICONME CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CA32F0", Offset = "0x6CA1CF0", VA = "0x186CA32F0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CA33C0", Offset = "0x6CA1DC0", VA = "0x186CA33C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CNNHDBNJNBD : JEDKKJGHJPP, IEquatable<CNNHDBNJNBD>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PCGHHNFLFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x26E9F30", Offset = "0x26E8930", VA = "0x1826E9F30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5F64670", Offset = "0x5F63070", VA = "0x185F64670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DDBKACNOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA01B0", Offset = "0x6C9EBB0", VA = "0x186CA01B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2037530", Offset = "0x2035F30", VA = "0x182037530", Slot = "8")]
	public bool Equals(CNNHDBNJNBD CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0120", Offset = "0x6C9EB20", VA = "0x186CA0120", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KOEBEDLCMKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLIOGABGHGA(POMPLEGKFCO BAFHJDFHJHD, OHFCNPENGBB NNKPOGBBDGK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLIOGABGHGA(JHJMOICONME NLBIOBEAIBN, OHFCNPENGBB NNKPOGBBDGK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBJLBPNMKBF(JHJMOICONME NLBIOBEAIBN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOMIJEDALMD(JHJMOICONME NLBIOBEAIBN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDDODELOONL();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOFODNKJLHF(OHFCNPENGBB AOGCIMANLIJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JDFNHDKIBAC(POMPLEGKFCO BAFHJDFHJHD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JDFNHDKIBAC(JHJMOICONME NLBIOBEAIBN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BHNDGMJFJOD(JHJMOICONME NLBIOBEAIBN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MINBBJLEGDC(JHJMOICONME NLBIOBEAIBN);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FCLLJAEBHKJ();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JLHGJJPBNOD();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EPPJIOCIOIB(POMPLEGKFCO BAFHJDFHJHD, AGNEHGOBOAO AOGCIMANLIJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FOGKECAHPMG(JHJMOICONME NLBIOBEAIBN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NJBDPCOCNAI(JHJMOICONME NLBIOBEAIBN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DFFHKEBMJOD();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EDBPGCIGGEN(AGNEHGOBOAO AOGCIMANLIJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ACLHFEEGAPA(POMPLEGKFCO BAFHJDFHJHD, Vector3 NCNNFDJBEEG, Vector3 JMKKCMMDLHN, Vector3 CGAJKJIDDPM, float IGLOBBLFBLJ, float NOOBIJPGEGH, IReadOnlyList<Camera> FFCIDODLBLL, GFCMMAOCIGI IOGDAIKBAOH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ACLHFEEGAPA(CNNHDBNJNBD OLJDDPHJDKD, Vector3 NCNNFDJBEEG, Vector3 JMKKCMMDLHN, Vector3 CGAJKJIDDPM, float IGLOBBLFBLJ, float NOOBIJPGEGH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GAFDHANDCAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DHEFFKBHKFN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POMPLEGKFCO AGGALJMIAJL(MBPFKDDNMLH LNCKNHNHHDF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POMPLEGKFCO AGGALJMIAJL(MBPFKDDNMLH LNCKNHNHHDF, bool KEMCDMIBGKJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOFKDPGNCEF(POMPLEGKFCO BAFHJDFHJHD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDDCCBDGOKN(POMPLEGKFCO BAFHJDFHJHD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JHJMOICONME FLMIIBLAEEF(POMPLEGKFCO BAFHJDFHJHD, GDFFHEGJACA LNCKNHNHHDF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JHJMOICONME JHKINFPMGDP(POMPLEGKFCO BAFHJDFHJHD, PIFHFJIMKBG LNCKNHNHHDF);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FFKGOFOAMGP(JHJMOICONME NLBIOBEAIBN);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FMPEJEMNINO(JHJMOICONME NLBIOBEAIBN);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CNNHDBNJNBD MANCHLCINKO(JPGEPNHCBAE LNCKNHNHHDF);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FJCGMAEEIGA(CNNHDBNJNBD OLJDDPHJDKD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OJKJCCNBPKD(CNNHDBNJNBD OLJDDPHJDKD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task ELOAIGLEPFI();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task NABMKIKMIPL();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task DJNMFMAHJDL();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IIHIIHOBGFF();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> HGEPIAMGEAE(POMPLEGKFCO BAFHJDFHJHD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AJIIPBEPPPI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum EGBNLOGDFPP
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
	public enum JGBLEICKNMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum FNCFKJIHJDB
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
	public enum MEGLDIGDCDF
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
	public enum NCAPCNFPGEO
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
	public enum HCFBEJOAPKM
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
	public static int FKDKMDKBKKM;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static int MEOPJEOMGBH;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static int DBLDMMIAFIM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static int DGCDHJLLGLB;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static int[] HELJGJDDONN;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static int KIBGGANPNGM;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static int PPLEEEIKDDO;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static int AJGFMEPIEOO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static int CLEHEDAKOJC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long BMCHJEBGPFO;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long IGJLCNAEJJO;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static long GCNFDLILKFG;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static long MBJFLEKNAMG;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static long LJOMFLNKFFE;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long FAKHEICJOCK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long CHLKBGCJEND;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static long NEOGGCAFAFP;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long HDOGOHGMFDF;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static long OOPNLMBLBNP;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static long NINENKILBKL;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static long ICGOKAIAINJ;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static long CHGPAFDOMDN;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static long HDHLDCKHGGJ;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static float OLFJEMEJIBP;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long GNJMEABPAIE;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static long MIGPODGGPJF;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static long PJOBLEPBDAE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static long AELDDFNAFDK;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float EPIOBHBJKAF;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static long MBFDOLBOKKD;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static long KEMEEONEGAP;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long NAOFGDBOMNE;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long EPAOAKIJHON;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long BFJFNHKCAAB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool OOCMFFGJEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D410", Offset = "0x6C9BE10", VA = "0x186C9D410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C970", Offset = "0x6C9B370", VA = "0x186C9C970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static HCFBEJOAPKM HEHAECFBFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F850", Offset = "0x6C9E250", VA = "0x186C9F850")]
		[CompilerGenerated]
		get
		{
			return default(HCFBEJOAPKM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D800", Offset = "0x6C9C200", VA = "0x186C9D800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool BOBEPJNOCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E3E0", Offset = "0x6C9CDE0", VA = "0x186C9E3E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D850", Offset = "0x6C9C250", VA = "0x186C9D850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool KLOLKFGJPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D370", Offset = "0x6C9BD70", VA = "0x186C9D370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E6D0", Offset = "0x6C9D0D0", VA = "0x186C9E6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static EGBNLOGDFPP JFGIKGLAEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E0F0", Offset = "0x6C9CAF0", VA = "0x186C9E0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool OILIJLKJMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9BF60", Offset = "0x6C9A960", VA = "0x186C9BF60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FA00", Offset = "0x6C9E400", VA = "0x186C9FA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static JGBLEICKNMD FEONJOEOODG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F800", Offset = "0x6C9E200", VA = "0x186C9F800")]
		[CompilerGenerated]
		get
		{
			return default(JGBLEICKNMD);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E190", Offset = "0x6C9CB90", VA = "0x186C9E190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool CDCCGHLLBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E8C0", Offset = "0x6C9D2C0", VA = "0x186C9E8C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E330", Offset = "0x6C9CD30", VA = "0x186C9E330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool KJDCHELAEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D960", Offset = "0x6C9C360", VA = "0x186C9D960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C740", Offset = "0x6C9B140", VA = "0x186C9C740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool COLLNDAHKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D500", Offset = "0x6C9BF00", VA = "0x186C9D500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FA60", Offset = "0x6C9E460", VA = "0x186C9FA60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static float NAMPELJMBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E040", Offset = "0x6C9CA40", VA = "0x186C9E040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C910", Offset = "0x6C9B310", VA = "0x186C9C910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int JBPMMDFFFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E230", Offset = "0x6C9CC30", VA = "0x186C9E230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C1B0", Offset = "0x6C9ABB0", VA = "0x186C9C1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int EIIPKLJHFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C4E0", Offset = "0x6C9AEE0", VA = "0x186C9C4E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C5E0", Offset = "0x6C9AFE0", VA = "0x186C9C5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int JCDIJONLOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E480", Offset = "0x6C9CE80", VA = "0x186C9E480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C630", Offset = "0x6C9B030", VA = "0x186C9C630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int ODAAINHLPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DC10", Offset = "0x6C9C610", VA = "0x186C9DC10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E1E0", Offset = "0x6C9CBE0", VA = "0x186C9E1E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int OOOGCBPEBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F8F0", Offset = "0x6C9E2F0", VA = "0x186C9F8F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E970", Offset = "0x6C9D370", VA = "0x186C9E970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int KLBEENGIGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DAC0", Offset = "0x6C9C4C0", VA = "0x186C9DAC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C490", Offset = "0x6C9AE90", VA = "0x186C9C490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static float NGDPNJILOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E630", Offset = "0x6C9D030", VA = "0x186C9E630")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C260", Offset = "0x6C9AC60", VA = "0x186C9C260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int DMAPFHBLEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DCC0", Offset = "0x6C9C6C0", VA = "0x186C9DCC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D3C0", Offset = "0x6C9BDC0", VA = "0x186C9D3C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int NCHCCFKDEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D460", Offset = "0x6C9BE60", VA = "0x186C9D460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E7D0", Offset = "0x6C9D1D0", VA = "0x186C9E7D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int EKDNKNOFOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F8A0", Offset = "0x6C9E2A0", VA = "0x186C9F8A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E280", Offset = "0x6C9CC80", VA = "0x186C9E280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static float BJPLCLGBNML
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9EA20", Offset = "0x6C9D420", VA = "0x186C9EA20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DA60", Offset = "0x6C9C460", VA = "0x186C9DA60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float MIKKNDDAJII
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DBC0", Offset = "0x6C9C5C0", VA = "0x186C9DBC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C390", Offset = "0x6C9AD90", VA = "0x186C9C390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float CBJJEJIKIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E730", Offset = "0x6C9D130", VA = "0x186C9E730")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D8B0", Offset = "0x6C9C2B0", VA = "0x186C9D8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool AFKBNFNCKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C440", Offset = "0x6C9AE40", VA = "0x186C9C440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C9CA10", Offset = "0x6C9B410", VA = "0x186C9CA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static int MIEHEAJEOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E680", Offset = "0x6C9D080", VA = "0x186C9E680")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6C9BF10", Offset = "0x6C9A910", VA = "0x186C9BF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static int JJJFNKCMJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D5F0", Offset = "0x6C9BFF0", VA = "0x186C9D5F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C9C0", Offset = "0x6C9B3C0", VA = "0x186C9C9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static int DIFEKIHMAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C3F0", Offset = "0x6C9ADF0", VA = "0x186C9C3F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C340", Offset = "0x6C9AD40", VA = "0x186C9C340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int CKKCHFANFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E5E0", Offset = "0x6C9CFE0", VA = "0x186C9E5E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D550", Offset = "0x6C9BF50", VA = "0x186C9D550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static bool KKHLPGGMLOB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C000", Offset = "0x6C9AA00", VA = "0x186C9C000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DC60", Offset = "0x6C9C660", VA = "0x186C9DC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static bool OPDCGFMLMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DF40", Offset = "0x6C9C940", VA = "0x186C9DF40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C800", Offset = "0x6C9B200", VA = "0x186C9C800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float JBCPGPEOJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E870", Offset = "0x6C9D270", VA = "0x186C9E870")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F9A0", Offset = "0x6C9E3A0", VA = "0x186C9F9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static FNCFKJIHJDB BMGDPJCHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D9B0", Offset = "0x6C9C3B0", VA = "0x186C9D9B0")]
		[CompilerGenerated]
		get
		{
			return default(FNCFKJIHJDB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D910", Offset = "0x6C9C310", VA = "0x186C9D910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static MEGLDIGDCDF DGNNHOBMLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D640", Offset = "0x6C9C040", VA = "0x186C9D640")]
		[CompilerGenerated]
		get
		{
			return default(MEGLDIGDCDF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E780", Offset = "0x6C9D180", VA = "0x186C9E780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool BGNDOKPMCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E390", Offset = "0x6C9CD90", VA = "0x186C9E390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E2D0", Offset = "0x6C9CCD0", VA = "0x186C9E2D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float FPADCBJNIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DD10", Offset = "0x6C9C710", VA = "0x186C9DD10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E9C0", Offset = "0x6C9D3C0", VA = "0x186C9E9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float OLBPCABKLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D4B0", Offset = "0x6C9BEB0", VA = "0x186C9D4B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E520", Offset = "0x6C9CF20", VA = "0x186C9E520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float CCCDJLOEIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D5A0", Offset = "0x6C9BFA0", VA = "0x186C9D5A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C680", Offset = "0x6C9B080", VA = "0x186C9C680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float DEEGOLEPFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DE70", Offset = "0x6C9C870", VA = "0x186C9DE70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DD60", Offset = "0x6C9C760", VA = "0x186C9DD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static float PMENLHMHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DF90", Offset = "0x6C9C990", VA = "0x186C9DF90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C6E0", Offset = "0x6C9B0E0", VA = "0x186C9C6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static float KBGDPEADNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DDC0", Offset = "0x6C9C7C0", VA = "0x186C9DDC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DB60", Offset = "0x6C9C560", VA = "0x186C9DB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool FBLMMMMDLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C590", Offset = "0x6C9AF90", VA = "0x186C9C590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F940", Offset = "0x6C9E340", VA = "0x186C9F940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static float ILHNDAPMENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E820", Offset = "0x6C9D220", VA = "0x186C9E820")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DE10", Offset = "0x6C9C810", VA = "0x186C9DE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int DPKJBMMKCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E4D0", Offset = "0x6C9CED0", VA = "0x186C9E4D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D690", Offset = "0x6C9C090", VA = "0x186C9D690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static int JPKFEJKEENG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C160", Offset = "0x6C9AB60", VA = "0x186C9C160")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C7A0", Offset = "0x6C9B1A0", VA = "0x186C9C7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool PNGJFCKJOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E140", Offset = "0x6C9CB40", VA = "0x186C9E140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static int MLGHLIFOONI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C860", Offset = "0x6C9B260", VA = "0x186C9C860")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E090", Offset = "0x6C9CA90", VA = "0x186C9E090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static int NHEENKPHNID
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C050", Offset = "0x6C9AA50", VA = "0x186C9C050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool PJLPHLIJJLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D6F0", Offset = "0x6C9C0F0", VA = "0x186C9D6F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E580", Offset = "0x6C9CF80", VA = "0x186C9E580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float CBOELHOEONC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E430", Offset = "0x6C9CE30", VA = "0x186C9E430")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C200", Offset = "0x6C9AC00", VA = "0x186C9C200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float CKDCPPHHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C9CA70", Offset = "0x6C9B470", VA = "0x186C9CA70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E910", Offset = "0x6C9D310", VA = "0x186C9E910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float CMNOHHPKPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C110", Offset = "0x6C9AB10", VA = "0x186C9C110")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DFE0", Offset = "0x6C9C9E0", VA = "0x186C9DFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static int KLAFGOPKJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D7B0", Offset = "0x6C9C1B0", VA = "0x186C9D7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C530", Offset = "0x6C9AF30", VA = "0x186C9C530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static float4x4 GOPADJELDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DEC0", Offset = "0x6C9C8C0", VA = "0x186C9DEC0")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C2C0", Offset = "0x6C9ACC0", VA = "0x186C9C2C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float3 HOPJCEOJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D740", Offset = "0x6C9C140", VA = "0x186C9D740")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DA00", Offset = "0x6C9C400", VA = "0x186C9DA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static bool MOOKABDLCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C9BFB0", Offset = "0x6C9A9B0", VA = "0x186C9BFB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C8B0", Offset = "0x6C9B2B0", VA = "0x186C9C8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static NCAPCNFPGEO BNJEIKIKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DB10", Offset = "0x6C9C510", VA = "0x186C9DB10")]
		[CompilerGenerated]
		get
		{
			return default(NCAPCNFPGEO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C0B0", Offset = "0x6C9AAB0", VA = "0x186C9C0B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EA70", Offset = "0x6C9D470", VA = "0x186C9EA70")]
	public static void PEBNIBGNKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CAC0", Offset = "0x6C9B4C0", VA = "0x186C9CAC0")]
	public static void EPCHELFEMLA(HCFBEJOAPKM HJBBFBGPLLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HEJNJDFOIMN
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct BJOPMKKLDOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Vector3 EDBNILFNKMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Quaternion EEFKFMHIEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float PNLDMHIFGKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public Quaternion LFBHMIPALFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public float IDIACLGMNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float PDAAPCEAKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float KNOLKIOMADK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static List<BJOPMKKLDOC> HJIJBMLPDME;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA01F0", Offset = "0x6C9EBF0", VA = "0x186CA01F0")]
	public static NativeList<GIIFOCGKODC> DGEDCCDLIPH(LJEMIAKCBLA FCCHPKGBOPA)
	{
		return default(NativeList<GIIFOCGKODC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2370", Offset = "0x6CA0D70", VA = "0x186CA2370")]
	private static bool PAJBDJNLPGH(int ELMEOKPKOPN, NativeList<GIIFOCGKODC> NLAECIHBKHE, List<BJOPMKKLDOC> NLDHJDINPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2110", Offset = "0x6CA0B10", VA = "0x186CA2110")]
	private static GIIFOCGKODC MLOOINNJPGD(int PMJJDLNJJBC, List<BJOPMKKLDOC> NLDHJDINPDB)
	{
		return default(GIIFOCGKODC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1C20", Offset = "0x6CA0620", VA = "0x186CA1C20")]
	private static GIIFOCGKODC MLLHEILGNBL(int PMJJDLNJJBC, List<BJOPMKKLDOC> NLDHJDINPDB)
	{
		return default(GIIFOCGKODC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2290", Offset = "0x6CA0C90", VA = "0x186CA2290")]
	private static GIIFOCGKODC OKNOMDOOPLE(Vector3 BJFHPDFPFFI, Quaternion GNJAOBEFJHH, float KGJKNMNONHN)
	{
		return default(GIIFOCGKODC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0780", Offset = "0x6C9F180", VA = "0x186CA0780")]
	public static NativeList<GIIFOCGKODC> IJJJLCBGHMB(LJEMIAKCBLA FCCHPKGBOPA, float MFEDBKHBMMP)
	{
		return default(NativeList<GIIFOCGKODC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KHNFGOHMOJG
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static Vector3 LGCKPPINDND;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static Vector3 IOMJOMNMAIN;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public static readonly float NKMEDIGAOFA;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3E50", Offset = "0x6CA2850", VA = "0x186CA3E50")]
	public static Vector3 EPJCKFLFDKB(Vector3 GAMJBEJGFOO, Quaternion GNJAOBEFJHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA40D0", Offset = "0x6CA2AD0", VA = "0x186CA40D0")]
	public static Vector3 HCKGOOMLAGK(Quaternion PCIAHIPKDFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4170", Offset = "0x6CA2B70", VA = "0x186CA4170")]
	public static Vector3 LOMBGACGLJO(Quaternion PCIAHIPKDFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3DD0", Offset = "0x6CA27D0", VA = "0x186CA3DD0")]
	public static Quaternion EMJBKCLEHPN(Vector3 FJODMBFILLK, Vector3 MLNCIIKLLEK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3450", Offset = "0x6CA1E50", VA = "0x186CA3450")]
	public static Vector3 ANHLJDMNEGA(Vector3 MOIDJOIAGLP, Vector3 PMJCNJOGMGC, Vector3 MLNCIIKLLEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3640", Offset = "0x6CA2040", VA = "0x186CA3640")]
	public static Vector3 DCLIAOGKMMF(Vector3 GAMJBEJGFOO, Vector3 MLNCIIKLLEK, Quaternion PCIAHIPKDFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3A70", Offset = "0x6CA2470", VA = "0x186CA3A70")]
	public static Quaternion EFLGBFBEPAP(Quaternion GNJAOBEFJHH, Vector3 FJODMBFILLK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4500", Offset = "0x6CA2F00", VA = "0x186CA4500")]
	public static bool PABNEICJLKD(Vector3 JKMOKEHHGCO, Vector3 EEBJLDJIGBN, [Out] Vector3 HLAFCKKNDEJ, bool DGMIJMHINFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4210", Offset = "0x6CA2C10", VA = "0x186CA4210")]
	public static Vector3 MKFEMNPLGJG(bool MFJBPJAGCLA, [Optional] Quaternion PEEDPLHMOKD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GIIFOCGKODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float3 EDBNILFNKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public float3x3 EEFKFMHIEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public float PNLDMHIFGKF;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LJEMIAKCBLA
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int ONCNEAAIIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NPPMHMEIMFF(int PMJJDLNJJBC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion MPJKFNKMHOG(int PMJJDLNJJBC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float KDCAHINOBCH(int PMJJDLNJJBC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PIFHFJIMKBG : OACECHPOMPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool IGJGEIIGGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool BDCECJDBNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float NKAFHJADCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int HIMAJBOANED
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool EIHJLJNHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int JOGOLLKGCBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<GIIFOCGKODC> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GDFFHEGJACA : OACECHPOMPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	KHEAFOBJNAC ALBLPHNHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool AMJOFGLCGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float3 KGPEAAFDOIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface MBPFKDDNMLH
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	FGHMMAJOCCM LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	AKHIENPNMHJ CNDECNLNCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OACECHPOMPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool GDHLDDAMOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool AGJIIPOPPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	FGHMMAJOCCM LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	UniformTRS GIDBAMMDPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float BDFLNHNKFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 POLEEJMBAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	ILGMMPAEBOD MCCNFLMNEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	FHMDBDPAHKN JLBBNMBMMAC
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
public interface JPGEPNHCBAE
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int CABAHIILHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Transform CJNEOPGLBMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool LONJLEKGGGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POMPLEGKFCO GetBone(int PMJJDLNJJBC);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int PMJJDLNJJBC);
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
