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
public enum JKMBBDPLCIH
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
public enum FFCHMNNCDPE
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
public enum OMANHOCOLNE
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
public enum BBEOEDALAPE
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
public enum MDOKODFBGBL
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
public enum MONBNMPFMMO
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
public static class HCCDDOPPLPK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75DDD00", Offset = "0x75DD100", VA = "0x1875DDD00")]
	public static bool PJMDODBLJPG(this MONBNMPFMMO FEIBMFKLDKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x75DDCF0", Offset = "0x75DD0F0", VA = "0x1875DDCF0")]
	public static bool GABHHOGEHFG(this MONBNMPFMMO FEIBMFKLDKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75DDCC0", Offset = "0x75DD0C0", VA = "0x1875DDCC0")]
	public static bool DAPCBGIDEIF(this MONBNMPFMMO FEIBMFKLDKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CEHJAJCAOIA
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
public struct DGKNAAFCKEM : KBLKBJHICLE, IEquatable<DGKNAAFCKEM>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int MPMCCDHNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int EMCKBBMGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B85210", Offset = "0x2B84610", VA = "0x182B85210", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x675E500", Offset = "0x675D900", VA = "0x18675E500", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75D95D0", Offset = "0x75D89D0", VA = "0x1875D95D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1681370", Offset = "0x1680770", VA = "0x181681370", Slot = "8")]
	public bool Equals(DGKNAAFCKEM OKCHLIEAIJP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3396B00", Offset = "0x3395F00", VA = "0x183396B00")]
	public static bool BFIJCNNIIMH(DGKNAAFCKEM AMGCKABOOPF, DGKNAAFCKEM PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x75D9610", Offset = "0x75D8A10", VA = "0x1875D9610", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75D96B0", Offset = "0x75D8AB0", VA = "0x1875D96B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EEGJHJCMEBL : KBLKBJHICLE, IEquatable<EEGJHJCMEBL>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MPMCCDHNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int EMCKBBMGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B85210", Offset = "0x2B84610", VA = "0x182B85210", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x675E500", Offset = "0x675D900", VA = "0x18675E500", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75D9740", Offset = "0x75D8B40", VA = "0x1875D9740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1681370", Offset = "0x1680770", VA = "0x181681370", Slot = "8")]
	public bool Equals(EEGJHJCMEBL OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x75D9780", Offset = "0x75D8B80", VA = "0x1875D9780", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75D9820", Offset = "0x75D8C20", VA = "0x1875D9820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MDKOADIDEPC : KBLKBJHICLE, IEquatable<MDKOADIDEPC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MPMCCDHNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EMCKBBMGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B85210", Offset = "0x2B84610", VA = "0x182B85210", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x675E500", Offset = "0x675D900", VA = "0x18675E500", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75DDD20", Offset = "0x75DD120", VA = "0x1875DDD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1681370", Offset = "0x1680770", VA = "0x181681370", Slot = "8")]
	public bool Equals(MDKOADIDEPC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75DDD60", Offset = "0x75DD160", VA = "0x1875DDD60", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LNJLGFCNCEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGFBAPGPBML(DGKNAAFCKEM JGHOOBNHEJB, FFCHMNNCDPE BANIDBBGDNO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGFBAPGPBML(EEGJHJCMEBL LFCFKCMCBCB, FFCHMNNCDPE BANIDBBGDNO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDOKGNLMCFH(EEGJHJCMEBL LFCFKCMCBCB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDHOPDHDIKK(EEGJHJCMEBL LFCFKCMCBCB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void INMGJNLANCM();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMDJAAPNKBM(FFCHMNNCDPE BMIPLDLMPCD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMAIBOOHJBD(DGKNAAFCKEM JGHOOBNHEJB);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LMAIBOOHJBD(EEGJHJCMEBL LFCFKCMCBCB);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CDECFIAEKHN(EEGJHJCMEBL LFCFKCMCBCB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FJPCKAONCBJ(EEGJHJCMEBL LFCFKCMCBCB);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FIJKHFOPMMN();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OPBGNHAIBEA();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OGNANCMJPAP(DGKNAAFCKEM JGHOOBNHEJB, MDOKODFBGBL BMIPLDLMPCD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AAJGNBPGGLE(EEGJHJCMEBL LFCFKCMCBCB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FOHCAFGBAOM(EEGJHJCMEBL LFCFKCMCBCB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IGFDEMDADNK();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MKNLHEEPNAI(MDOKODFBGBL BMIPLDLMPCD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OPCOFKAIJBF(DGKNAAFCKEM JGHOOBNHEJB, Vector3 NCMGFAIKAJI, Vector3 IMLCMDAJDCN, Vector3 GIBOOHLHGPF, float NMNOINHHBAP, float KNKFMCLLNFN, IReadOnlyList<Camera> MFLLGDBFINI, JKMBBDPLCIH OEIGHBFCMEO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OPCOFKAIJBF(MDKOADIDEPC OEJFCMJKFFJ, Vector3 NCMGFAIKAJI, Vector3 IMLCMDAJDCN, Vector3 GIBOOHLHGPF, float NMNOINHHBAP, float KNKFMCLLNFN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JIMDDOODGGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool HLNLNNLFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DGKNAAFCKEM LECFEEGHGFO(LIJGIKFJLHJ GIDGOODJFLJ, bool LALMIAEMIJA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEFEIDCAEMJ(DGKNAAFCKEM JGHOOBNHEJB);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BECJIHFLKFF(DGKNAAFCKEM JGHOOBNHEJB);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EEGJHJCMEBL IDGPMNHFJPC(DGKNAAFCKEM JGHOOBNHEJB, GGPLGOGDNFL GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EEGJHJCMEBL MHIODBIACKH(DGKNAAFCKEM JGHOOBNHEJB, MIIIGIALJDC GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DPFAHEDNFKP(EEGJHJCMEBL LFCFKCMCBCB);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NHEDDCGKKDL(EEGJHJCMEBL LFCFKCMCBCB);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MDKOADIDEPC MFNIMEIGABP(IBEKEEPBPDF GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BCCEFFDAOBD(MDKOADIDEPC OEJFCMJKFFJ);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BNIFBBPPMNC(MDKOADIDEPC OEJFCMJKFFJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task ECNFKAOMLMJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task FKBAAGJCFKA();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task BIJDBGPKDAO();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ECMDOCJBIDJ();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> PEEAEAFPGBE(DGKNAAFCKEM JGHOOBNHEJB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BHONJIJNCEC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum DPOMBGNFBEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum KJGDLGBNGEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum DHENOCNHLBG
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
	public enum ELNHJLOBGNK
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
	public enum PLPABEKFCCB
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
	public enum PCIKHCCALOK
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
	public enum ANHBABFLDDK
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum IJMLMDMCOFG
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
	public static bool NDBHFOEJMDB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static long HEJAOMCPOGC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static float FNLHGKJKDKP;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool MKFPKCGHKLI;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long KENCIEONBKN;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int JAKCDDPCJCH;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool DDIEIIPCJCB;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static KJGDLGBNGEC PLDFAOKBBKH;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float JOGFCPPADHO;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float HBIMLCLPOPF;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static bool EKJJFGMBFMD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static ANHBABFLDDK LGFKPKBEBDC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static bool OLCADALPFCC;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static float AEDLMFALMBF;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float DIBAENMBIEL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float NLCNOKFCALJ;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float LDOMIPCFPIN;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float APJMAGBNIFN;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static long NLJPFBGLBOB;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static long GPAEEBKGLMF;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static int MEEFKAAGNGM;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static bool MCKPIKCDJCG;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long EMFNONPLEMB;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long DIKMJPCABCN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static int NCINPHFMNFD;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static long ICJOKOFHOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static int OEGLDCJEMAN;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int CONPEKADEAA;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int GFCJICEGLBB;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static long JMDCOKBOAKD;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static long APHAOEDNJKF;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int IDMNFGDNIGF;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int ACCNCDCIKAF;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int JFFNGMIFJKD;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static long FAHILJMCOAK;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static long MGJPKEDMFLA;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long LFGHOKOIOBH;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long CFMAGLDGPKM;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int FFODGBNCMNG;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int HANFPCBGDCN;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int MJHDOJAHBED;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int OJFPDEPHKEO;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int[] HDBGNCLNNDF;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int JGEMADFGMPA;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long MIBCFGJEMBO;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long NJPKLFGIOAB;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static int LMDEHOEKOAP;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long IAJHJIJMHBK;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static long OFIFFCNGDJA;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static long PCENKGPHNPL;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long ECLIMELMEHP;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long AMFLCKKMANM;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long HPCLIMKGLLJ;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long FGFPFBICEFP;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long DEDEEDCPAID;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long OHLHHLEJHDG;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static float JDPMMBKNEJI;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long PLNONDAIBMH;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int FOGLLHPJKLP;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static long EJFCPIIFGNJ;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long BDFGKNEHLFK;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static float EGKHAFCGBHC;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long GFFNKIDFHJP;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long HFLPFDMJEFO;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long IFLFMCALCBF;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long EFMMNIKCMAE;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long KLPDALJDOLA;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long NDADFNAPBFJ;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long CGBENBCJNJI;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long FDPLHOFAPIK;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long MPABAKGLKNO;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long NLGDJKAEMNO;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long DCFMGKFKJML;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long NGCMIOAIEKK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool KAKLGJECFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75D7340", Offset = "0x75D6740", VA = "0x1875D7340")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75D3EE0", Offset = "0x75D32E0", VA = "0x1875D3EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static IJMLMDMCOFG PCHJMLLJIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x75D6FF0", Offset = "0x75D63F0", VA = "0x1875D6FF0")]
		[CompilerGenerated]
		get
		{
			return default(IJMLMDMCOFG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75D5C50", Offset = "0x75D5050", VA = "0x1875D5C50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool LABAHOBKAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75D4050", Offset = "0x75D3450", VA = "0x1875D4050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75D5B90", Offset = "0x75D4F90", VA = "0x1875D5B90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool BMBJIPPBEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x75D6900", Offset = "0x75D5D00", VA = "0x1875D6900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75D5AD0", Offset = "0x75D4ED0", VA = "0x1875D5AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float PECLLLFMELN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75D6790", Offset = "0x75D5B90", VA = "0x1875D6790")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75D8700", Offset = "0x75D7B00", VA = "0x1875D8700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float POECMENBFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x75D7620", Offset = "0x75D6A20", VA = "0x1875D7620")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75D4160", Offset = "0x75D3560", VA = "0x1875D4160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int AHJDLHIPNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x75D3C70", Offset = "0x75D3070", VA = "0x1875D3C70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x75D61C0", Offset = "0x75D55C0", VA = "0x1875D61C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static PCIKHCCALOK NBIBMCFNPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x75D7670", Offset = "0x75D6A70", VA = "0x1875D7670")]
		[CompilerGenerated]
		get
		{
			return default(PCIKHCCALOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75D6560", Offset = "0x75D5960", VA = "0x1875D6560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long IMJIFOPJOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x75D6220", Offset = "0x75D5620", VA = "0x1875D6220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x75D76C0", Offset = "0x75D6AC0", VA = "0x1875D76C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float BJBGIAHPGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x75D4340", Offset = "0x75D3740", VA = "0x1875D4340")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x75D8930", Offset = "0x75D7D30", VA = "0x1875D8930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int OMINIPGLEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x75D3DE0", Offset = "0x75D31E0", VA = "0x1875D3DE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x75D7220", Offset = "0x75D6620", VA = "0x1875D7220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int MBLLOMHBFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x75D6B30", Offset = "0x75D5F30", VA = "0x1875D6B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x75D3A90", Offset = "0x75D2E90", VA = "0x1875D3A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int GCMABKGELDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E20", Offset = "0x75D5220", VA = "0x1875D5E20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x75D6160", Offset = "0x75D5560", VA = "0x1875D6160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int NKEGHNEGLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x75D6510", Offset = "0x75D5910", VA = "0x1875D6510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75D44B0", Offset = "0x75D38B0", VA = "0x1875D44B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int NHBHCKEKNDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x75D3A40", Offset = "0x75D2E40", VA = "0x1875D3A40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x75D8870", Offset = "0x75D7C70", VA = "0x1875D8870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int LDMFFKFGDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x75D8760", Offset = "0x75D7B60", VA = "0x1875D8760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x75D4390", Offset = "0x75D3790", VA = "0x1875D4390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int BHINHIDAPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x75D3E90", Offset = "0x75D3290", VA = "0x1875D3E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x75D7390", Offset = "0x75D6790", VA = "0x1875D7390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int BPEELEOFGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75D73F0", Offset = "0x75D67F0", VA = "0x1875D73F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x75D6620", Offset = "0x75D5A20", VA = "0x1875D6620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static bool OILFMJOJMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x75D5F80", Offset = "0x75D5380", VA = "0x1875D5F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int MINHIIHHICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E70", Offset = "0x75D5270", VA = "0x1875D5E70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x75D5EC0", Offset = "0x75D52C0", VA = "0x1875D5EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int NGELJKHPGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x75D6F40", Offset = "0x75D6340", VA = "0x1875D6F40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75D5CB0", Offset = "0x75D50B0", VA = "0x1875D5CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int GGONAOJEDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x75D5D70", Offset = "0x75D5170", VA = "0x1875D5D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x75D67E0", Offset = "0x75D5BE0", VA = "0x1875D67E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static bool ONBNEGKGFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x75D4000", Offset = "0x75D3400", VA = "0x1875D4000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x75D7720", Offset = "0x75D6B20", VA = "0x1875D7720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float BCKCKPHBDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75D6740", Offset = "0x75D5B40", VA = "0x1875D6740")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x75D7040", Offset = "0x75D6440", VA = "0x1875D7040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool FLDFKHJDNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x75D38D0", Offset = "0x75D2CD0", VA = "0x1875D38D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x75D8810", Offset = "0x75D7C10", VA = "0x1875D8810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool HAAJLMFCKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x75D7440", Offset = "0x75D6840", VA = "0x1875D7440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x75D7560", Offset = "0x75D6960", VA = "0x1875D7560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static DPOMBGNFBEC ONCDLBOOBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x75D6B80", Offset = "0x75D5F80", VA = "0x1875D6B80")]
		[CompilerGenerated]
		get
		{
			return default(DPOMBGNFBEC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x75D71C0", Offset = "0x75D65C0", VA = "0x1875D71C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool CEDHKDNGFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x75D68A0", Offset = "0x75D5CA0", VA = "0x1875D68A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x75D3980", Offset = "0x75D2D80", VA = "0x1875D3980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int PGNKANDOPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x75D3BB0", Offset = "0x75D2FB0", VA = "0x1875D3BB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75D6840", Offset = "0x75D5C40", VA = "0x1875D6840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int IOAKBAIAFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x75D70A0", Offset = "0x75D64A0", VA = "0x1875D70A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x75D87B0", Offset = "0x75D7BB0", VA = "0x1875D87B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int HLKKCBJDEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x75D6DC0", Offset = "0x75D61C0", VA = "0x1875D6DC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x75D7500", Offset = "0x75D6900", VA = "0x1875D7500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int DBOIEJOEFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x75D6E20", Offset = "0x75D6220", VA = "0x1875D6E20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x75D60A0", Offset = "0x75D54A0", VA = "0x1875D60A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int FNKEBHDLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x75D4450", Offset = "0x75D3850", VA = "0x1875D4450")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x75D7780", Offset = "0x75D6B80", VA = "0x1875D7780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int FNDJAPCGIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x75D88D0", Offset = "0x75D7CD0", VA = "0x1875D88D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x75D5F20", Offset = "0x75D5320", VA = "0x1875D5F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int NHMKEKLKDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x75D5A70", Offset = "0x75D4E70", VA = "0x1875D5A70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x75D5DC0", Offset = "0x75D51C0", VA = "0x1875D5DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static int DMMCLGJNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x75D6680", Offset = "0x75D5A80", VA = "0x1875D6680")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x75D6E80", Offset = "0x75D6280", VA = "0x1875D6E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float AKPMGHBILMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75D72E0", Offset = "0x75D66E0", VA = "0x1875D72E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75D5BF0", Offset = "0x75D4FF0", VA = "0x1875D5BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float EAACKOCAAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x75D3F40", Offset = "0x75D3340", VA = "0x1875D3F40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x75D3920", Offset = "0x75D2D20", VA = "0x1875D3920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float FEBAIIANLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x75D3AF0", Offset = "0x75D2EF0", VA = "0x1875D3AF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x75D3B50", Offset = "0x75D2F50", VA = "0x1875D3B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int HGDNKCIOECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75D6950", Offset = "0x75D5D50", VA = "0x1875D6950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x75D3E30", Offset = "0x75D3230", VA = "0x1875D3E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int OGOKNAGFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x75D39E0", Offset = "0x75D2DE0", VA = "0x1875D39E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x75D6100", Offset = "0x75D5500", VA = "0x1875D6100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int CDNANJGOKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x75D7160", Offset = "0x75D6560", VA = "0x1875D7160")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x75D77E0", Offset = "0x75D6BE0", VA = "0x1875D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int GJGKOFHPHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x75D6D60", Offset = "0x75D6160", VA = "0x1875D6D60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x75D5990", Offset = "0x75D4D90", VA = "0x1875D5990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static bool HCECNFEJHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75D40A0", Offset = "0x75D34A0", VA = "0x1875D40A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x75D64B0", Offset = "0x75D58B0", VA = "0x1875D64B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static DHENOCNHLBG IDGGAJKIJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x75D65C0", Offset = "0x75D59C0", VA = "0x1875D65C0")]
		[CompilerGenerated]
		get
		{
			return default(DHENOCNHLBG);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x75D69B0", Offset = "0x75D5DB0", VA = "0x1875D69B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static ELNHJLOBGNK OCJNDIOHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x75D6270", Offset = "0x75D5670", VA = "0x1875D6270")]
		[CompilerGenerated]
		get
		{
			return default(ELNHJLOBGNK);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x75D75C0", Offset = "0x75D69C0", VA = "0x1875D75C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool OIENGBDDGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x75D36E0", Offset = "0x75D2AE0", VA = "0x1875D36E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75D41C0", Offset = "0x75D35C0", VA = "0x1875D41C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static float BJLDHBOMMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x75D4220", Offset = "0x75D3620", VA = "0x1875D4220")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x75D6450", Offset = "0x75D5850", VA = "0x1875D6450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float APEBOCECGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x75D4570", Offset = "0x75D3970", VA = "0x1875D4570")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x75D42E0", Offset = "0x75D36E0", VA = "0x1875D42E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float JFMIHFBIADE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x75D63F0", Offset = "0x75D57F0", VA = "0x1875D63F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x75D66E0", Offset = "0x75D5AE0", VA = "0x1875D66E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float CPHEKKFHLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x75D6C40", Offset = "0x75D6040", VA = "0x1875D6C40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x75D3740", Offset = "0x75D2B40", VA = "0x1875D3740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float LOFOHDPDPDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x75D5930", Offset = "0x75D4D30", VA = "0x1875D5930")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x75D4280", Offset = "0x75D3680", VA = "0x1875D4280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static float EMLHGBPPLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x75D6AD0", Offset = "0x75D5ED0", VA = "0x1875D6AD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x75D6330", Offset = "0x75D5730", VA = "0x1875D6330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static bool EBHNEGBCCMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x75D5FD0", Offset = "0x75D53D0", VA = "0x1875D5FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x75D3D80", Offset = "0x75D3180", VA = "0x1875D3D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float BKJGNLACFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75D3D20", Offset = "0x75D3120", VA = "0x1875D3D20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x75D6A70", Offset = "0x75D5E70", VA = "0x1875D6A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float HMNIOMLOFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x75D86A0", Offset = "0x75D7AA0", VA = "0x1875D86A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x75D43F0", Offset = "0x75D37F0", VA = "0x1875D43F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static float MIPJMMOKDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x75D3C10", Offset = "0x75D3010", VA = "0x1875D3C10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x75D6EE0", Offset = "0x75D62E0", VA = "0x1875D6EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static int HKLIELJBNBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x75D3CC0", Offset = "0x75D30C0", VA = "0x1875D3CC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x75D3FA0", Offset = "0x75D33A0", VA = "0x1875D3FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static float HNMBPHPLLGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x75D62D0", Offset = "0x75D56D0", VA = "0x1875D62D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static bool OFKKGIICFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x75D37A0", Offset = "0x75D2BA0", VA = "0x1875D37A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x75D5B30", Offset = "0x75D4F30", VA = "0x1875D5B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static int EMBKHPCPKGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x75D7100", Offset = "0x75D6500", VA = "0x1875D7100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x75D6D00", Offset = "0x75D6100", VA = "0x1875D6D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static float MJNPPHPAODH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75D3800", Offset = "0x75D2C00", VA = "0x1875D3800")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75D6F90", Offset = "0x75D6390", VA = "0x1875D6F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float LKFIPEANOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x75D74A0", Offset = "0x75D68A0", VA = "0x1875D74A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x75D6CA0", Offset = "0x75D60A0", VA = "0x1875D6CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static bool FOODCIFHPED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x75D6390", Offset = "0x75D5790", VA = "0x1875D6390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x75D4510", Offset = "0x75D3910", VA = "0x1875D4510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static float LDMDLNEOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x75D58D0", Offset = "0x75D4CD0", VA = "0x1875D58D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x75D6BE0", Offset = "0x75D5FE0", VA = "0x1875D6BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static long KMPGALLBIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x75D8990", Offset = "0x75D7D90", VA = "0x1875D8990")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static float4x4 HKCHAHMEOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x75D45D0", Offset = "0x75D39D0", VA = "0x1875D45D0")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x75D59F0", Offset = "0x75D4DF0", VA = "0x1875D59F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static float3 AEEJCJGNOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x75D3860", Offset = "0x75D2C60", VA = "0x1875D3860")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x75D6030", Offset = "0x75D5430", VA = "0x1875D6030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static bool ECFFMECKKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x75D5D10", Offset = "0x75D5110", VA = "0x1875D5D10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x75D6A10", Offset = "0x75D5E10", VA = "0x1875D6A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public static PLPABEKFCCB HLIMLKJDGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x75D4100", Offset = "0x75D3500", VA = "0x1875D4100")]
		[CompilerGenerated]
		get
		{
			return default(PLPABEKFCCB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x75D7280", Offset = "0x75D6680", VA = "0x1875D7280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x75D4650", Offset = "0x75D3A50", VA = "0x1875D4650")]
	public static void FCFCMHDGPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x75D7840", Offset = "0x75D6C40", VA = "0x1875D7840")]
	public static void PADHFMHDDNH(IJMLMDMCOFG GLPCHDPHGDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FCDDCJAHFEP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct DFGNJLNGGGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public Vector3 NAMOIOBECGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Quaternion KGCMOGJCFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public float GKIFEDCHHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public Quaternion LDAGHGGMGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public float BJAJOILJGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public float CPKNEBPFLGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public float NOJHBJOBNCA;
	}

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static List<DFGNJLNGGGH> FIBHOLIOJGG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x75DB3E0", Offset = "0x75DA7E0", VA = "0x1875DB3E0")]
	public static NativeList<MJHFHLJEIGI> JPCLCOFHGGE(DGCJMFNLGOG MKJPICMBEDC)
	{
		return default(NativeList<MJHFHLJEIGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x75DB980", Offset = "0x75DAD80", VA = "0x1875DB980")]
	private static bool MCBPDMDDLKM(int BKHEBBAMMAK, NativeList<MJHFHLJEIGI> BIEIOPPGBOB, List<DFGNJLNGGGH> LEMHIPNDEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75DAD70", Offset = "0x75DA170", VA = "0x1875DAD70")]
	private static MJHFHLJEIGI GHPHGNIKJJL(int MKNOLMMOIDN, List<DFGNJLNGGGH> LEMHIPNDEKF)
	{
		return default(MJHFHLJEIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x75DAEF0", Offset = "0x75DA2F0", VA = "0x1875DAEF0")]
	private static MJHFHLJEIGI IAHMJJDOLEF(int MKNOLMMOIDN, List<DFGNJLNGGGH> LEMHIPNDEKF)
	{
		return default(MJHFHLJEIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x75DC830", Offset = "0x75DBC30", VA = "0x1875DC830")]
	private static MJHFHLJEIGI OAKIGDAKPGG(Vector3 MIGPGADKMKK, Quaternion PPMLNGGNBKE, float PMGAIALCDAG)
	{
		return default(MJHFHLJEIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x75D98B0", Offset = "0x75D8CB0", VA = "0x1875D98B0")]
	public static NativeList<MJHFHLJEIGI> EKLGJGDIADM(DGCJMFNLGOG MKJPICMBEDC, float LNCKOKFDLOI)
	{
		return default(NativeList<MJHFHLJEIGI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GOIIIFANHEC
{
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public static Vector3 KOIDAIGJNOD;

	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public static Vector3 COKLOCAMJLI;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public static readonly float ADNFEHCGFAH;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x75DCFC0", Offset = "0x75DC3C0", VA = "0x1875DCFC0")]
	public static Vector3 EEFLNCPNFPA(Vector3 PNCABPILPAA, Quaternion PPMLNGGNBKE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x75DC9A0", Offset = "0x75DBDA0", VA = "0x1875DC9A0")]
	public static Vector3 BENOIFIEDIH(Quaternion MLMNPOCKAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x75DCA40", Offset = "0x75DBE40", VA = "0x1875DCA40")]
	public static Vector3 BHFHGEIMKPH(Quaternion MLMNPOCKAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x75DD5B0", Offset = "0x75DC9B0", VA = "0x1875DD5B0")]
	public static Quaternion JOFAKENPBOK(Vector3 BNCGOADGBEC, Vector3 FGKLFPNFOKI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x75DCAE0", Offset = "0x75DBEE0", VA = "0x1875DCAE0")]
	public static Vector3 CAHNMABPIPJ(Vector3 KHBMANHMDBE, Vector3 BCONAOPPBPK, Vector3 FGKLFPNFOKI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x75DD7B0", Offset = "0x75DCBB0", VA = "0x1875DD7B0")]
	public static Vector3 OGALGJFKLOD(Vector3 PNCABPILPAA, Vector3 FGKLFPNFOKI, Quaternion MLMNPOCKAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x75DD250", Offset = "0x75DC650", VA = "0x1875DD250")]
	public static Quaternion IMOCKCGDNLM(Quaternion PPMLNGGNBKE, Vector3 BNCGOADGBEC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75DD630", Offset = "0x75DCA30", VA = "0x1875DD630")]
	public static bool LEBLFDGNMOM(Vector3 LOHJJHJNBDH, Vector3 ACGMFDNLAGP, [Out] Vector3 OBJCIKCFCIL, bool NONGPALEMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x75DCCD0", Offset = "0x75DC0D0", VA = "0x1875DCCD0")]
	public static Vector3 ECBINDMDJOB(bool GLMJFKFEKIG, [Optional] Quaternion BPEMBGMDEBD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MJHFHLJEIGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public float3 NAMOIOBECGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public float3x3 KGCMOGJCFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public float GKIFEDCHHOE;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DGCJMFNLGOG
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int KMLMJEEIBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 EGGEPAMJNMK(int MKNOLMMOIDN);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion KPPCNMJKMKI(int MKNOLMMOIDN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float LPMDBMBIBDP(int MKNOLMMOIDN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface MIIIGIALJDC : MBADBELKHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool BOAGBKMLGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool EJGEJEKCLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float PPAPPOJMPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int HOOGEGKJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool KFEKJCLAOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	int BONNAGJGKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<MJHFHLJEIGI> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GGPLGOGDNFL : MBADBELKHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	OMANHOCOLNE FJHDNLPGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool HFKONJBLIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 AGNHKCCLAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LIJGIKFJLHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	LCHJICBNMPB KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	BBEOEDALAPE IFPHMOGCGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MBADBELKHDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool IEPPMNEGJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool LOPMCHPOEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	LCHJICBNMPB KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	UniformTRS FIHNNJPCBML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float INBIAHCDOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Vector3 HDHBKBDNLLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	MONBNMPFMMO OGILABJPOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	CEHJAJCAOIA BELBKPNNIJF
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
public interface IBEKEEPBPDF
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int EMEJHMBPJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform FFAMAEDAECD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool FIHAFEEGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DGKNAAFCKEM GetBone(int MKNOLMMOIDN);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MKNOLMMOIDN);
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
