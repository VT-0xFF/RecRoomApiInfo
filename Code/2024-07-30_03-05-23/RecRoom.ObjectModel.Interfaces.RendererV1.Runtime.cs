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
public enum NKECLOJAIJH
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
public enum IAHLCGIKAIA
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
public enum KBIAPBKPMCM
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
public enum LLMIKBGFNGF
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
public enum PLKHJBLGPPN
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
public enum LKAPLOLHAAI
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
public static class ECJDPIFFOKH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA700", Offset = "0x6AF8D00", VA = "0x186AFA700")]
	public static bool JIPPHMPJPMB(this LKAPLOLHAAI NBBKLPGFGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA6F0", Offset = "0x6AF8CF0", VA = "0x186AFA6F0")]
	public static bool JIAIKHECBBB(this LKAPLOLHAAI NBBKLPGFGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA720", Offset = "0x6AF8D20", VA = "0x186AFA720")]
	public static bool KOPKDPDABJL(this LKAPLOLHAAI NBBKLPGFGFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum EEFKMEOHOJA
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
public struct KNLOLEOJCHI : DOGEODOABCA, IEquatable<KNLOLEOJCHI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int HDIHKFJHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x259FD50", Offset = "0x259E350", VA = "0x18259FD50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2910", Offset = "0x5DD0F10", VA = "0x185DD2910", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IPGIKMPLLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B015B0", Offset = "0x6AFFBB0", VA = "0x186B015B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0D30", Offset = "0x1EEF330", VA = "0x181EF0D30", Slot = "8")]
	public bool Equals(KNLOLEOJCHI BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69C5410", Offset = "0x69C3A10", VA = "0x1869C5410")]
	public static bool NKEIKPOPFDO(KNLOLEOJCHI KHKPJFABMKM, KNLOLEOJCHI CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B015F0", Offset = "0x6AFFBF0", VA = "0x186B015F0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B01690", Offset = "0x6AFFC90", VA = "0x186B01690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IBHAMOLJEBE : DOGEODOABCA, IEquatable<IBHAMOLJEBE>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int HDIHKFJHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x259FD50", Offset = "0x259E350", VA = "0x18259FD50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2910", Offset = "0x5DD0F10", VA = "0x185DD2910", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IPGIKMPLLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B01440", Offset = "0x6AFFA40", VA = "0x186B01440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0D30", Offset = "0x1EEF330", VA = "0x181EF0D30", Slot = "8")]
	public bool Equals(IBHAMOLJEBE BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B01480", Offset = "0x6AFFA80", VA = "0x186B01480", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B01520", Offset = "0x6AFFB20", VA = "0x186B01520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FBIOJGOPNMA : DOGEODOABCA, IEquatable<FBIOJGOPNMA>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HDIHKFJHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x259FD50", Offset = "0x259E350", VA = "0x18259FD50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2910", Offset = "0x5DD0F10", VA = "0x185DD2910", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IPGIKMPLLND
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B01360", Offset = "0x6AFF960", VA = "0x186B01360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0D30", Offset = "0x1EEF330", VA = "0x181EF0D30", Slot = "8")]
	public bool Equals(FBIOJGOPNMA BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B013A0", Offset = "0x6AFF9A0", VA = "0x186B013A0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HCJAEIACLKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIFDDOKBOEB(KNLOLEOJCHI OPJBDKMKMOF, IAHLCGIKAIA KLJCIEFJLHJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIFDDOKBOEB(IBHAMOLJEBE ALHKJMBLFMK, IAHLCGIKAIA KLJCIEFJLHJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMNBIKKCMFI(IBHAMOLJEBE ALHKJMBLFMK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCDGLMMENHB(IBHAMOLJEBE ALHKJMBLFMK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KCFCHEGPCOI();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CHHDMILIHPA(IAHLCGIKAIA GOAECDHCJMK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLEFCLEKAIF(KNLOLEOJCHI OPJBDKMKMOF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MLEFCLEKAIF(IBHAMOLJEBE ALHKJMBLFMK);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OCHDOANNLJL(IBHAMOLJEBE ALHKJMBLFMK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DFBJKHIGILD(IBHAMOLJEBE ALHKJMBLFMK);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NGJIBDLDDLJ();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DDIKHOHJHNN();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DMNMILHOHLD(KNLOLEOJCHI OPJBDKMKMOF, PLKHJBLGPPN GOAECDHCJMK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void COLCHGAADHO(IBHAMOLJEBE ALHKJMBLFMK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DJCNENEIPNM(IBHAMOLJEBE ALHKJMBLFMK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NECFHJJCCJC();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CILMJDMLHPN(PLKHJBLGPPN GOAECDHCJMK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NNEFBHOPHFM(KNLOLEOJCHI OPJBDKMKMOF, Vector3 DFKPGAPPDLE, Vector3 GBBJPJGHFJG, Vector3 JIOCCNNHCIN, float ICJACLOBGDH, float BNMDCPKMKOB, IReadOnlyList<Camera> HADPDJKOLDC, NKECLOJAIJH CKOHCOOHOGL);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NNEFBHOPHFM(FBIOJGOPNMA FNMFEDNONDJ, Vector3 DFKPGAPPDLE, Vector3 GBBJPJGHFJG, Vector3 JIOCCNNHCIN, float ICJACLOBGDH, float BNMDCPKMKOB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ABMGIHGABKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool INEHBGLMMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNLOLEOJCHI CHCNLPLPKFI(NBCFOMAMNIJ MMDLBEBNCGC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KNLOLEOJCHI CHCNLPLPKFI(NBCFOMAMNIJ MMDLBEBNCGC, bool DJPOJIABNGM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FINNPDBADIG(KNLOLEOJCHI OPJBDKMKMOF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIKHBDGNGEJ(KNLOLEOJCHI OPJBDKMKMOF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IBHAMOLJEBE HMFBNACJIEC(KNLOLEOJCHI OPJBDKMKMOF, GNPIAAGDACE MMDLBEBNCGC);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IBHAMOLJEBE CEBKMEAPKNP(KNLOLEOJCHI OPJBDKMKMOF, JBDKBGHIKJK MMDLBEBNCGC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KGEJFDPKPAC(IBHAMOLJEBE ALHKJMBLFMK);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CBGHOGADMEI(IBHAMOLJEBE ALHKJMBLFMK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FBIOJGOPNMA MDEAEJELEND(KLFJCCFEKBH MMDLBEBNCGC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DNHABAIBNDP(FBIOJGOPNMA FNMFEDNONDJ);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NNMBHKKPODP(FBIOJGOPNMA FNMFEDNONDJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task GMMCKNIJNJD();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task MOECCPAFMME();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task HKLPHGFDOEN();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PGLLIJJODNB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> EGCBAOEFPJF(KNLOLEOJCHI OPJBDKMKMOF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FABPFOCDMII
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum JAGPGBMFJGL
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
	public enum BKPLGEGKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum OLHCAICCAOJ
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
	public enum HFKJGLFNEGG
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
	public enum OJKFLCIGACE
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
	public enum AIIPHKPPDOF
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
	public static int HAIMGDHFIHM;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int CCDOMILGHAN;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int BACJGAJGECJ;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int LEBBCFECCKC;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static int[] FKKKGNMONAE;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static int MICKILKHNJO;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static int FGJJDHBEOJO;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static int DEECMOGNCIO;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long NPLGJHBNHEE;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long CBALPOKBGNJ;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long MCELMBJLIKP;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long ICHDEDNHMNC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long HPMCJPLKMJF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long OCLFGFAOLFA;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long GGNDHBDHBOA;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long EHPENHCGHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static long MGIMANOENJJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static long MOGPCJEBLIG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long HAKDCHMAOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long CGNFKHBGKLA;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static long NLJPCEEJCDA;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static long EOCEMFLBEFD;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float MLMHHHMNJIH;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long JLFIKHPMEMG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long LMJNAHNJABI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool CCKEAIDOKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B00C70", Offset = "0x6AFF270", VA = "0x186B00C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF350", Offset = "0x6AFD950", VA = "0x186AFF350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static AIIPHKPPDOF NPHKIDAPDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFA00", Offset = "0x6AFE000", VA = "0x186AFFA00")]
		[CompilerGenerated]
		get
		{
			return default(AIIPHKPPDOF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF9A0", Offset = "0x6AFDFA0", VA = "0x186AFF9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool NIEOFOLLEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFD20", Offset = "0x6AFE320", VA = "0x186AFFD20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B001D0", Offset = "0x6AFE7D0", VA = "0x186B001D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool FGEELFOGLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEA80", Offset = "0x6AFD080", VA = "0x186AFEA80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFD70", Offset = "0x6AFE370", VA = "0x186AFFD70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static JAGPGBMFJGL FANFJPFDJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF950", Offset = "0x6AFDF50", VA = "0x186AFF950")]
		[CompilerGenerated]
		get
		{
			return default(JAGPGBMFJGL);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B00CC0", Offset = "0x6AFF2C0", VA = "0x186B00CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool EFLELIENGED
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEEA0", Offset = "0x6AFD4A0", VA = "0x186AFEEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF840", Offset = "0x6AFDE40", VA = "0x186AFF840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static BKPLGEGKNNC GDNNDLHHOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDCC0", Offset = "0x6AFC2C0", VA = "0x186AFDCC0")]
		[CompilerGenerated]
		get
		{
			return default(BKPLGEGKNNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF410", Offset = "0x6AFDA10", VA = "0x186AFF410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool GDMGACHJPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF7F0", Offset = "0x6AFDDF0", VA = "0x186AFF7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFCC0", Offset = "0x6AFE2C0", VA = "0x186AFFCC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool MDIEHBAOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEC20", Offset = "0x6AFD220", VA = "0x186AFEC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6B004C0", Offset = "0x6AFEAC0", VA = "0x186B004C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool KMKNHDJFONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF630", Offset = "0x6AFDC30", VA = "0x186AFF630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF2F0", Offset = "0x6AFD8F0", VA = "0x186AFF2F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static float BJOEPNGMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF4C0", Offset = "0x6AFDAC0", VA = "0x186AFF4C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDBC0", Offset = "0x6AFC1C0", VA = "0x186AFDBC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int NIGILLPFMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6AFECD0", Offset = "0x6AFD2D0", VA = "0x186AFECD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF730", Offset = "0x6AFDD30", VA = "0x186AFF730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int BODNJBJHHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDC20", Offset = "0x6AFC220", VA = "0x186AFDC20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6B00290", Offset = "0x6AFE890", VA = "0x186B00290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int NGPBONBKCID
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEF50", Offset = "0x6AFD550", VA = "0x186AFEF50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF230", Offset = "0x6AFD830", VA = "0x186AFF230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int EIDHAPOFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEB20", Offset = "0x6AFD120", VA = "0x186AFEB20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6B002F0", Offset = "0x6AFE8F0", VA = "0x186B002F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int NDDIDBNJDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFEA0", Offset = "0x6AFE4A0", VA = "0x186AFFEA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B000B0", Offset = "0x6AFE6B0", VA = "0x186B000B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int LCDDKELEKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF160", Offset = "0x6AFD760", VA = "0x186AFF160")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFA50", Offset = "0x6AFE050", VA = "0x186AFFA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int EKNHIOAKAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6B00BC0", Offset = "0x6AFF1C0", VA = "0x186B00BC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE8B0", Offset = "0x6AFCEB0", VA = "0x186AFE8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int BEMPJODDAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF0B0", Offset = "0x6AFD6B0", VA = "0x186AFF0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF6D0", Offset = "0x6AFDCD0", VA = "0x186AFF6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int GPBIEAHDEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE910", Offset = "0x6AFCF10", VA = "0x186AFE910")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFB60", Offset = "0x6AFE160", VA = "0x186AFFB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int LNIFFPEIFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFC20", Offset = "0x6AFE220", VA = "0x186AFFC20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE9C0", Offset = "0x6AFCFC0", VA = "0x186AFE9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int KFFBEAPINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF470", Offset = "0x6AFDA70", VA = "0x186AFF470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDB00", Offset = "0x6AFC100", VA = "0x186AFDB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int AMHFEEMBFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B00000", Offset = "0x6AFE600", VA = "0x186B00000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B00110", Offset = "0x6AFE710", VA = "0x186B00110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int BMKBHCHKLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEE50", Offset = "0x6AFD450", VA = "0x186AFEE50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6AFED20", Offset = "0x6AFD320", VA = "0x186AFED20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static int JGPBOFLIJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEBD0", Offset = "0x6AFD1D0", VA = "0x186AFEBD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFAB0", Offset = "0x6AFE0B0", VA = "0x186AFFAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static int BBBECDJNANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFDD0", Offset = "0x6AFE3D0", VA = "0x186AFFDD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEA20", Offset = "0x6AFD020", VA = "0x186AFEA20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool NDMBEPFGGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFC70", Offset = "0x6AFE270", VA = "0x186AFFC70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF5D0", Offset = "0x6AFDBD0", VA = "0x186AFF5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool FMAGNDOIBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF680", Offset = "0x6AFDC80", VA = "0x186AFF680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEC70", Offset = "0x6AFD270", VA = "0x186AFEC70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static OLHCAICCAOJ CMHJGOENPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6B003B0", Offset = "0x6AFE9B0", VA = "0x186B003B0")]
		[CompilerGenerated]
		get
		{
			return default(OLHCAICCAOJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF290", Offset = "0x6AFD890", VA = "0x186AFF290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static HFKJGLFNEGG BDHKIJDMFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF8A0", Offset = "0x6AFDEA0", VA = "0x186AFF8A0")]
		[CompilerGenerated]
		get
		{
			return default(HFKJGLFNEGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6B00D20", Offset = "0x6AFF320", VA = "0x186B00D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static bool HKDOGADCIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFB10", Offset = "0x6AFE110", VA = "0x186AFFB10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF000", Offset = "0x6AFD600", VA = "0x186AFF000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float PNPAIFGHADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEAD0", Offset = "0x6AFD0D0", VA = "0x186AFEAD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF8F0", Offset = "0x6AFDEF0", VA = "0x186AFF8F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float BCJHPEOIFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFFB0", Offset = "0x6AFE5B0", VA = "0x186AFFFB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF510", Offset = "0x6AFDB10", VA = "0x186AFF510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float MAAPAILFBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF060", Offset = "0x6AFD660", VA = "0x186AFF060")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF570", Offset = "0x6AFDB70", VA = "0x186AFF570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static float PBELIMLDLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDC70", Offset = "0x6AFC270", VA = "0x186AFDC70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFEF0", Offset = "0x6AFE4F0", VA = "0x186AFFEF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float LBGALCICICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6AFE960", Offset = "0x6AFCF60", VA = "0x186AFE960")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD9D0", Offset = "0x6AFBFD0", VA = "0x186AFD9D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float KOOMFJBIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF100", Offset = "0x6AFD700", VA = "0x186AFF100")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFBC0", Offset = "0x6AFE1C0", VA = "0x186AFFBC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static bool JCPELCNGNCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6B00C10", Offset = "0x6AFF210", VA = "0x186B00C10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDB60", Offset = "0x6AFC160", VA = "0x186AFDB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float NLMEFDLIBFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEEF0", Offset = "0x6AFD4F0", VA = "0x186AFEEF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6AFED80", Offset = "0x6AFD380", VA = "0x186AFED80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int DCAFDAHDGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6B00460", Offset = "0x6AFEA60", VA = "0x186B00460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF3B0", Offset = "0x6AFD9B0", VA = "0x186AFF3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int FCKPKJINOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDA30", Offset = "0x6AFC030", VA = "0x186AFDA30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF790", Offset = "0x6AFDD90", VA = "0x186AFF790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool DKBLFJMFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6B00050", Offset = "0x6AFE650", VA = "0x186B00050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int JGIDHNCJHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6B00400", Offset = "0x6AFEA00", VA = "0x186B00400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6B00230", Offset = "0x6AFE830", VA = "0x186B00230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int LAPLCAJNPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFF50", Offset = "0x6AFE550", VA = "0x186AFFF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static float4x4 KEHCAHGDDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6AFFE20", Offset = "0x6AFE420", VA = "0x186AFFE20")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF1B0", Offset = "0x6AFD7B0", VA = "0x186AFF1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static float3 GOFPGEIKJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFDA90", Offset = "0x6AFC090", VA = "0x186AFDA90")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEDE0", Offset = "0x6AFD3E0", VA = "0x186AFEDE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool LCBJPKJBIID
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEB70", Offset = "0x6AFD170", VA = "0x186AFEB70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6B00350", Offset = "0x6AFE950", VA = "0x186B00350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static OJKFLCIGACE LIADNBICIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6B00170", Offset = "0x6AFE770", VA = "0x186B00170")]
		[CompilerGenerated]
		get
		{
			return default(OJKFLCIGACE);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AFEFA0", Offset = "0x6AFD5A0", VA = "0x186AFEFA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AFDD10", Offset = "0x6AFC310", VA = "0x186AFDD10")]
	public static void BCMJIKKJHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B00520", Offset = "0x6AFEB20", VA = "0x186B00520")]
	public static void ONJECKOKPLI(AIIPHKPPDOF IIJEGKAAGGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EHEEJNIGHAA
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct HGNBMCPEJGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector3 GJMAELHLBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Quaternion FODPGOBPIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float PHILPKFOFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public Quaternion AGPCHEOOLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float HNCJHDBGEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float KHHCIABFBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float IHGPCEHBLLE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static List<HGNBMCPEJGC> IDKAMBJKOFJ;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC230", Offset = "0x6AFA830", VA = "0x186AFC230")]
	public static NativeList<CPDENJNCAAG> JCDCHJFAMEA(NMIKCMNNCCC GBGLBCFHOAO)
	{
		return default(NativeList<CPDENJNCAAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC7D0", Offset = "0x6AFADD0", VA = "0x186AFC7D0")]
	private static bool KLGANBDALGK(int BILDLIKNGJF, NativeList<CPDENJNCAAG> IAFCFGOKEAK, List<HGNBMCPEJGC> AIIHNAJANNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD7B0", Offset = "0x6AFBDB0", VA = "0x186AFD7B0")]
	private static CPDENJNCAAG MHIAHMBCMLC(int EAHBLIIOOON, List<HGNBMCPEJGC> AIIHNAJANNH)
	{
		return default(CPDENJNCAAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA750", Offset = "0x6AF8D50", VA = "0x186AFA750")]
	private static CPDENJNCAAG AIBNDNBOODG(int EAHBLIIOOON, List<HGNBMCPEJGC> AIIHNAJANNH)
	{
		return default(CPDENJNCAAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC150", Offset = "0x6AFA750", VA = "0x186AFC150")]
	private static CPDENJNCAAG HJMGLPJLKCN(Vector3 KIPJBGAHLFJ, Quaternion HPAIEAFGHDJ, float PKDKCKJPOHP)
	{
		return default(CPDENJNCAAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAC60", Offset = "0x6AF9260", VA = "0x186AFAC60")]
	public static NativeList<CPDENJNCAAG> GCMAACPGDLP(NMIKCMNNCCC GBGLBCFHOAO, float CPBMPMMIDIM)
	{
		return default(NativeList<CPDENJNCAAG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NBCMADIDJEK
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static Vector3 KKJLNIEAHHK;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static Vector3 MGCMFFAKBFC;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static readonly float AHJDBEPMLPN;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B01A90", Offset = "0x6B00090", VA = "0x186B01A90")]
	public static Vector3 ABLICLBNKAD(Vector3 CIDAOOPKIMI, Quaternion HPAIEAFGHDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B01D20", Offset = "0x6B00320", VA = "0x186B01D20")]
	public static Vector3 ELMAMMMOILP(Quaternion GLKHDAMNPBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B02490", Offset = "0x6B00A90", VA = "0x186B02490")]
	public static Vector3 HNCBAPMAKMN(Quaternion GLKHDAMNPBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B01A10", Offset = "0x6B00010", VA = "0x186B01A10")]
	public static Quaternion AAOLNKKAMPA(Vector3 GKDEFPHJFPJ, Vector3 MHHLIPGJMOK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B01DC0", Offset = "0x6B003C0", VA = "0x186B01DC0")]
	public static Vector3 GEGGKBBODLJ(Vector3 INMKMIKCGEM, Vector3 IMNHHOGMFHD, Vector3 MHHLIPGJMOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B02530", Offset = "0x6B00B30", VA = "0x186B02530")]
	public static Vector3 JBEHEEEKCDE(Vector3 CIDAOOPKIMI, Vector3 MHHLIPGJMOK, Quaternion GLKHDAMNPBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B02120", Offset = "0x6B00720", VA = "0x186B02120")]
	public static Quaternion HEEHMKEFHEM(Quaternion HPAIEAFGHDJ, Vector3 GKDEFPHJFPJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B01FB0", Offset = "0x6B005B0", VA = "0x186B01FB0")]
	public static bool GJABBLFCBOB(Vector3 ACEHJEDFCCL, Vector3 KPOEIBFEMNH, [Out] Vector3 PDEEPPMIHOL, bool PBNBMGMBBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B01720", Offset = "0x6AFFD20", VA = "0x186B01720")]
	public static Vector3 AAJJDHLKEGP(bool NMPCKMEJDKL, [Optional] Quaternion DANLPLEGIPB)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CPDENJNCAAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public float3 GJMAELHLBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public float3x3 FODPGOBPIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public float PHILPKFOFCH;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NMIKCMNNCCC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	int HCKJFCGIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FHFOJNNCGON(int EAHBLIIOOON);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion AJMDBOKBNJM(int EAHBLIIOOON);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float LCOBKLLFAJM(int EAHBLIIOOON);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface JBDKBGHIKJK : MDMIHABDMHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool AMEKIELMJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool DIOGLFLBFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	float MLCPFEDFFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	int OAIGJFKAOFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool JCDMOJKKCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int NIPKBEDENII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CPDENJNCAAG> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GNPIAAGDACE : MDMIHABDMHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KBIAPBKPMCM FJENGFOLMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IMGIGLEPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float3 FNPIDOJBAAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface NBCFOMAMNIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	ANOGDKLDLNH BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	LLMIKBGFNGF BCGNIDKHINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MDMIHABDMHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool AOPGHBNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool LEABEBJOCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ANOGDKLDLNH BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	UniformTRS BCNEAMKHOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float JPFBFIPPKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Vector3 OFOLEKMDDAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	LKAPLOLHAAI CMOPBFECPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	EEFKMEOHOJA FOHFCLEKJBG
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
public interface KLFJCCFEKBH
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int CIONIJKFHBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Transform CBNLAHIBIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool OKLFNGPFONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KNLOLEOJCHI GetBone(int EAHBLIIOOON);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EAHBLIIOOON);
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
