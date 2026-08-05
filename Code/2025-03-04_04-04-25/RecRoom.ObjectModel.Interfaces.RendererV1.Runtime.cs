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
	[Cpp2IlInjected.Address(RVA = "0x767C300", Offset = "0x767A900", VA = "0x18767C300")]
	public static bool PJMDODBLJPG(this MONBNMPFMMO FEIBMFKLDKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x767C2F0", Offset = "0x767A8F0", VA = "0x18767C2F0")]
	public static bool GABHHOGEHFG(this MONBNMPFMMO FEIBMFKLDKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x767C2C0", Offset = "0x767A8C0", VA = "0x18767C2C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBB1F0", Offset = "0x2BB97F0", VA = "0x182BBB1F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67C36C0", Offset = "0x67C1CC0", VA = "0x1867C36C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7677BD0", Offset = "0x76761D0", VA = "0x187677BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1699F90", Offset = "0x1698590", VA = "0x181699F90", Slot = "8")]
	public bool Equals(DGKNAAFCKEM OKCHLIEAIJP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x33DB220", Offset = "0x33D9820", VA = "0x1833DB220")]
	public static bool BFIJCNNIIMH(DGKNAAFCKEM AMGCKABOOPF, DGKNAAFCKEM PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7677C10", Offset = "0x7676210", VA = "0x187677C10", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7677CB0", Offset = "0x76762B0", VA = "0x187677CB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBB1F0", Offset = "0x2BB97F0", VA = "0x182BBB1F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x67C36C0", Offset = "0x67C1CC0", VA = "0x1867C36C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7677D40", Offset = "0x7676340", VA = "0x187677D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1699F90", Offset = "0x1698590", VA = "0x181699F90", Slot = "8")]
	public bool Equals(EEGJHJCMEBL OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7677D80", Offset = "0x7676380", VA = "0x187677D80", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7677E20", Offset = "0x7676420", VA = "0x187677E20", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EMCKBBMGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB1F0", Offset = "0x2BB97F0", VA = "0x182BBB1F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67C36C0", Offset = "0x67C1CC0", VA = "0x1867C36C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x767C320", Offset = "0x767A920", VA = "0x18767C320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1699F90", Offset = "0x1698590", VA = "0x181699F90", Slot = "8")]
	public bool Equals(MDKOADIDEPC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x767C360", Offset = "0x767A960", VA = "0x18767C360", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x7675940", Offset = "0x7673F40", VA = "0x187675940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x76724E0", Offset = "0x7670AE0", VA = "0x1876724E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static IJMLMDMCOFG PCHJMLLJIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x76755F0", Offset = "0x7673BF0", VA = "0x1876755F0")]
		[CompilerGenerated]
		get
		{
			return default(IJMLMDMCOFG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7674250", Offset = "0x7672850", VA = "0x187674250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool LABAHOBKAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7672650", Offset = "0x7670C50", VA = "0x187672650")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7674190", Offset = "0x7672790", VA = "0x187674190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool BMBJIPPBEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7674F00", Offset = "0x7673500", VA = "0x187674F00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x76740D0", Offset = "0x76726D0", VA = "0x1876740D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float PECLLLFMELN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7674D90", Offset = "0x7673390", VA = "0x187674D90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7676D00", Offset = "0x7675300", VA = "0x187676D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float POECMENBFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7675C20", Offset = "0x7674220", VA = "0x187675C20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7672760", Offset = "0x7670D60", VA = "0x187672760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int AHJDLHIPNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7672270", Offset = "0x7670870", VA = "0x187672270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76747C0", Offset = "0x7672DC0", VA = "0x1876747C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static PCIKHCCALOK NBIBMCFNPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7675C70", Offset = "0x7674270", VA = "0x187675C70")]
		[CompilerGenerated]
		get
		{
			return default(PCIKHCCALOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7674B60", Offset = "0x7673160", VA = "0x187674B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long IMJIFOPJOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7674820", Offset = "0x7672E20", VA = "0x187674820")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7675CC0", Offset = "0x76742C0", VA = "0x187675CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float BJBGIAHPGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7672940", Offset = "0x7670F40", VA = "0x187672940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7676F30", Offset = "0x7675530", VA = "0x187676F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int OMINIPGLEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x76723E0", Offset = "0x76709E0", VA = "0x1876723E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7675820", Offset = "0x7673E20", VA = "0x187675820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int MBLLOMHBFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7675130", Offset = "0x7673730", VA = "0x187675130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7672090", Offset = "0x7670690", VA = "0x187672090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int GCMABKGELDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7674420", Offset = "0x7672A20", VA = "0x187674420")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7674760", Offset = "0x7672D60", VA = "0x187674760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int NKEGHNEGLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7674B10", Offset = "0x7673110", VA = "0x187674B10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7672AB0", Offset = "0x76710B0", VA = "0x187672AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int NHBHCKEKNDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7672040", Offset = "0x7670640", VA = "0x187672040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7676E70", Offset = "0x7675470", VA = "0x187676E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int LDMFFKFGDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7676D60", Offset = "0x7675360", VA = "0x187676D60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7672990", Offset = "0x7670F90", VA = "0x187672990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int BHINHIDAPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7672490", Offset = "0x7670A90", VA = "0x187672490")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7675990", Offset = "0x7673F90", VA = "0x187675990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int BPEELEOFGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76759F0", Offset = "0x7673FF0", VA = "0x1876759F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7674C20", Offset = "0x7673220", VA = "0x187674C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static bool OILFMJOJMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7674580", Offset = "0x7672B80", VA = "0x187674580")]
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
		[Cpp2IlInjected.Address(RVA = "0x7674470", Offset = "0x7672A70", VA = "0x187674470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x76744C0", Offset = "0x7672AC0", VA = "0x1876744C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int NGELJKHPGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7675540", Offset = "0x7673B40", VA = "0x187675540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76742B0", Offset = "0x76728B0", VA = "0x1876742B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int GGONAOJEDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7674370", Offset = "0x7672970", VA = "0x187674370")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7674DE0", Offset = "0x76733E0", VA = "0x187674DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static bool ONBNEGKGFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7672600", Offset = "0x7670C00", VA = "0x187672600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7675D20", Offset = "0x7674320", VA = "0x187675D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float BCKCKPHBDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7674D40", Offset = "0x7673340", VA = "0x187674D40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7675640", Offset = "0x7673C40", VA = "0x187675640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool FLDFKHJDNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7671ED0", Offset = "0x76704D0", VA = "0x187671ED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7676E10", Offset = "0x7675410", VA = "0x187676E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool HAAJLMFCKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7675A40", Offset = "0x7674040", VA = "0x187675A40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7675B60", Offset = "0x7674160", VA = "0x187675B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static DPOMBGNFBEC ONCDLBOOBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7675180", Offset = "0x7673780", VA = "0x187675180")]
		[CompilerGenerated]
		get
		{
			return default(DPOMBGNFBEC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x76757C0", Offset = "0x7673DC0", VA = "0x1876757C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool CEDHKDNGFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7674EA0", Offset = "0x76734A0", VA = "0x187674EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7671F80", Offset = "0x7670580", VA = "0x187671F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int PGNKANDOPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76721B0", Offset = "0x76707B0", VA = "0x1876721B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7674E40", Offset = "0x7673440", VA = "0x187674E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int IOAKBAIAFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x76756A0", Offset = "0x7673CA0", VA = "0x1876756A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7676DB0", Offset = "0x76753B0", VA = "0x187676DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int HLKKCBJDEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x76753C0", Offset = "0x76739C0", VA = "0x1876753C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7675B00", Offset = "0x7674100", VA = "0x187675B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int DBOIEJOEFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7675420", Offset = "0x7673A20", VA = "0x187675420")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x76746A0", Offset = "0x7672CA0", VA = "0x1876746A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int FNKEBHDLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7672A50", Offset = "0x7671050", VA = "0x187672A50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7675D80", Offset = "0x7674380", VA = "0x187675D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int FNDJAPCGIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7676ED0", Offset = "0x76754D0", VA = "0x187676ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7674520", Offset = "0x7672B20", VA = "0x187674520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int NHMKEKLKDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7674070", Offset = "0x7672670", VA = "0x187674070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76743C0", Offset = "0x76729C0", VA = "0x1876743C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static int DMMCLGJNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7674C80", Offset = "0x7673280", VA = "0x187674C80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7675480", Offset = "0x7673A80", VA = "0x187675480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float AKPMGHBILMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76758E0", Offset = "0x7673EE0", VA = "0x1876758E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x76741F0", Offset = "0x76727F0", VA = "0x1876741F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float EAACKOCAAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7672540", Offset = "0x7670B40", VA = "0x187672540")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7671F20", Offset = "0x7670520", VA = "0x187671F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float FEBAIIANLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x76720F0", Offset = "0x76706F0", VA = "0x1876720F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7672150", Offset = "0x7670750", VA = "0x187672150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int HGDNKCIOECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7674F50", Offset = "0x7673550", VA = "0x187674F50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7672430", Offset = "0x7670A30", VA = "0x187672430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int OGOKNAGFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7671FE0", Offset = "0x76705E0", VA = "0x187671FE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7674700", Offset = "0x7672D00", VA = "0x187674700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int CDNANJGOKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7675760", Offset = "0x7673D60", VA = "0x187675760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7675DE0", Offset = "0x76743E0", VA = "0x187675DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int GJGKOFHPHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7675360", Offset = "0x7673960", VA = "0x187675360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7673F90", Offset = "0x7672590", VA = "0x187673F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static bool HCECNFEJHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76726A0", Offset = "0x7670CA0", VA = "0x1876726A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7674AB0", Offset = "0x76730B0", VA = "0x187674AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static DHENOCNHLBG IDGGAJKIJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7674BC0", Offset = "0x76731C0", VA = "0x187674BC0")]
		[CompilerGenerated]
		get
		{
			return default(DHENOCNHLBG);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7674FB0", Offset = "0x76735B0", VA = "0x187674FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static ELNHJLOBGNK OCJNDIOHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7674870", Offset = "0x7672E70", VA = "0x187674870")]
		[CompilerGenerated]
		get
		{
			return default(ELNHJLOBGNK);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7675BC0", Offset = "0x76741C0", VA = "0x187675BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool OIENGBDDGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7671CE0", Offset = "0x76702E0", VA = "0x187671CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x76727C0", Offset = "0x7670DC0", VA = "0x1876727C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static float BJLDHBOMMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7672820", Offset = "0x7670E20", VA = "0x187672820")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7674A50", Offset = "0x7673050", VA = "0x187674A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float APEBOCECGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7672B70", Offset = "0x7671170", VA = "0x187672B70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x76728E0", Offset = "0x7670EE0", VA = "0x1876728E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float JFMIHFBIADE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x76749F0", Offset = "0x7672FF0", VA = "0x1876749F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7674CE0", Offset = "0x76732E0", VA = "0x187674CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float CPHEKKFHLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7675240", Offset = "0x7673840", VA = "0x187675240")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7671D40", Offset = "0x7670340", VA = "0x187671D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float LOFOHDPDPDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7673F30", Offset = "0x7672530", VA = "0x187673F30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7672880", Offset = "0x7670E80", VA = "0x187672880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static float EMLHGBPPLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x76750D0", Offset = "0x76736D0", VA = "0x1876750D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7674930", Offset = "0x7672F30", VA = "0x187674930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static bool EBHNEGBCCMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x76745D0", Offset = "0x7672BD0", VA = "0x1876745D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7672380", Offset = "0x7670980", VA = "0x187672380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float BKJGNLACFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7672320", Offset = "0x7670920", VA = "0x187672320")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7675070", Offset = "0x7673670", VA = "0x187675070")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float HMNIOMLOFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7676CA0", Offset = "0x76752A0", VA = "0x187676CA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x76729F0", Offset = "0x7670FF0", VA = "0x1876729F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static float MIPJMMOKDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7672210", Offset = "0x7670810", VA = "0x187672210")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x76754E0", Offset = "0x7673AE0", VA = "0x1876754E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static int HKLIELJBNBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x76722C0", Offset = "0x76708C0", VA = "0x1876722C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x76725A0", Offset = "0x7670BA0", VA = "0x1876725A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static float HNMBPHPLLGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x76748D0", Offset = "0x7672ED0", VA = "0x1876748D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7671DA0", Offset = "0x76703A0", VA = "0x187671DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7674130", Offset = "0x7672730", VA = "0x187674130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static int EMBKHPCPKGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7675700", Offset = "0x7673D00", VA = "0x187675700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7675300", Offset = "0x7673900", VA = "0x187675300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static float MJNPPHPAODH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7671E00", Offset = "0x7670400", VA = "0x187671E00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7675590", Offset = "0x7673B90", VA = "0x187675590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float LKFIPEANOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7675AA0", Offset = "0x76740A0", VA = "0x187675AA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x76752A0", Offset = "0x76738A0", VA = "0x1876752A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static bool FOODCIFHPED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7674990", Offset = "0x7672F90", VA = "0x187674990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7672B10", Offset = "0x7671110", VA = "0x187672B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static float LDMDLNEOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7673ED0", Offset = "0x76724D0", VA = "0x187673ED0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x76751E0", Offset = "0x76737E0", VA = "0x1876751E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static long KMPGALLBIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7676F90", Offset = "0x7675590", VA = "0x187676F90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static float4x4 HKCHAHMEOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7672BD0", Offset = "0x76711D0", VA = "0x187672BD0")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7673FF0", Offset = "0x76725F0", VA = "0x187673FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static float3 AEEJCJGNOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7671E60", Offset = "0x7670460", VA = "0x187671E60")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7674630", Offset = "0x7672C30", VA = "0x187674630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static bool ECFFMECKKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7674310", Offset = "0x7672910", VA = "0x187674310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7675010", Offset = "0x7673610", VA = "0x187675010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public static PLPABEKFCCB HLIMLKJDGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7672700", Offset = "0x7670D00", VA = "0x187672700")]
		[CompilerGenerated]
		get
		{
			return default(PLPABEKFCCB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7675880", Offset = "0x7673E80", VA = "0x187675880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7672C50", Offset = "0x7671250", VA = "0x187672C50")]
	public static void FCFCMHDGPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7675E40", Offset = "0x7674440", VA = "0x187675E40")]
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
	[Cpp2IlInjected.Address(RVA = "0x76799E0", Offset = "0x7677FE0", VA = "0x1876799E0")]
	public static NativeList<MJHFHLJEIGI> JPCLCOFHGGE(DGCJMFNLGOG MKJPICMBEDC)
	{
		return default(NativeList<MJHFHLJEIGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7679F80", Offset = "0x7678580", VA = "0x187679F80")]
	private static bool MCBPDMDDLKM(int BKHEBBAMMAK, NativeList<MJHFHLJEIGI> BIEIOPPGBOB, List<DFGNJLNGGGH> LEMHIPNDEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7679370", Offset = "0x7677970", VA = "0x187679370")]
	private static MJHFHLJEIGI GHPHGNIKJJL(int MKNOLMMOIDN, List<DFGNJLNGGGH> LEMHIPNDEKF)
	{
		return default(MJHFHLJEIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x76794F0", Offset = "0x7677AF0", VA = "0x1876794F0")]
	private static MJHFHLJEIGI IAHMJJDOLEF(int MKNOLMMOIDN, List<DFGNJLNGGGH> LEMHIPNDEKF)
	{
		return default(MJHFHLJEIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x767AE30", Offset = "0x7679430", VA = "0x18767AE30")]
	private static MJHFHLJEIGI OAKIGDAKPGG(Vector3 MIGPGADKMKK, Quaternion PPMLNGGNBKE, float PMGAIALCDAG)
	{
		return default(MJHFHLJEIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7677EB0", Offset = "0x76764B0", VA = "0x187677EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x767B5C0", Offset = "0x7679BC0", VA = "0x18767B5C0")]
	public static Vector3 EEFLNCPNFPA(Vector3 PNCABPILPAA, Quaternion PPMLNGGNBKE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x767AFA0", Offset = "0x76795A0", VA = "0x18767AFA0")]
	public static Vector3 BENOIFIEDIH(Quaternion MLMNPOCKAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x767B040", Offset = "0x7679640", VA = "0x18767B040")]
	public static Vector3 BHFHGEIMKPH(Quaternion MLMNPOCKAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x767BBB0", Offset = "0x767A1B0", VA = "0x18767BBB0")]
	public static Quaternion JOFAKENPBOK(Vector3 BNCGOADGBEC, Vector3 FGKLFPNFOKI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x767B0E0", Offset = "0x76796E0", VA = "0x18767B0E0")]
	public static Vector3 CAHNMABPIPJ(Vector3 KHBMANHMDBE, Vector3 BCONAOPPBPK, Vector3 FGKLFPNFOKI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x767BDB0", Offset = "0x767A3B0", VA = "0x18767BDB0")]
	public static Vector3 OGALGJFKLOD(Vector3 PNCABPILPAA, Vector3 FGKLFPNFOKI, Quaternion MLMNPOCKAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x767B850", Offset = "0x7679E50", VA = "0x18767B850")]
	public static Quaternion IMOCKCGDNLM(Quaternion PPMLNGGNBKE, Vector3 BNCGOADGBEC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x767BC30", Offset = "0x767A230", VA = "0x18767BC30")]
	public static bool LEBLFDGNMOM(Vector3 LOHJJHJNBDH, Vector3 ACGMFDNLAGP, [Out] Vector3 OBJCIKCFCIL, bool NONGPALEMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x767B2D0", Offset = "0x76798D0", VA = "0x18767B2D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "2")]
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
