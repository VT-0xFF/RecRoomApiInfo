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
public enum KBDADMCHHJA
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
public enum NJFLAEHPIGP
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
public enum IIMLOMPLGMB
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
public enum HMPAGALPMBH
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
public enum FACIIGAFJII
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
public enum LJFEFAMPPFH
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
public static class LMGHHFECHKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6207280", Offset = "0x6206480", VA = "0x186207280")]
	public static bool PEOAGHMEECP(this LJFEFAMPPFH MJGOEAJIMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6207240", Offset = "0x6206440", VA = "0x186207240")]
	public static bool LEPCKJMCBPM(this LJFEFAMPPFH MJGOEAJIMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6207250", Offset = "0x6206450", VA = "0x186207250")]
	public static bool PCHDODJEJJK(this LJFEFAMPPFH MJGOEAJIMBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FPEFJDMPECH
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
public struct GAANJEIKMIE : GBFEIFPHLOE, IEquatable<GAANJEIKMIE>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int ABDHHHCLNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int OGIJDDFLLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2335DF0", Offset = "0x2334FF0", VA = "0x182335DF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5587230", Offset = "0x5586430", VA = "0x185587230", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DJHIIBCIELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6205C50", Offset = "0x6204E50", VA = "0x186205C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D1CA20", Offset = "0x1D1BC20", VA = "0x181D1CA20", Slot = "8")]
	public bool Equals(GAANJEIKMIE MEJMHKPOODP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60F5980", Offset = "0x60F4B80", VA = "0x1860F5980")]
	public static bool LEBDJINPIPG(GAANJEIKMIE LLLCBODKBAN, GAANJEIKMIE HIOEJKGFIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6205BC0", Offset = "0x6204DC0", VA = "0x186205BC0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6205C90", Offset = "0x6204E90", VA = "0x186205C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JDJHKBJECJO : GBFEIFPHLOE, IEquatable<JDJHKBJECJO>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int ABDHHHCLNNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int OGIJDDFLLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2335DF0", Offset = "0x2334FF0", VA = "0x182335DF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5587230", Offset = "0x5586430", VA = "0x185587230", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DJHIIBCIELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6205E80", Offset = "0x6205080", VA = "0x186205E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D1CA20", Offset = "0x1D1BC20", VA = "0x181D1CA20", Slot = "8")]
	public bool Equals(JDJHKBJECJO MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6205DF0", Offset = "0x6204FF0", VA = "0x186205DF0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6205EC0", Offset = "0x62050C0", VA = "0x186205EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GBFNOIADDPJ : GBFEIFPHLOE, IEquatable<GBFNOIADDPJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int ABDHHHCLNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OGIJDDFLLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2335DF0", Offset = "0x2334FF0", VA = "0x182335DF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5587230", Offset = "0x5586430", VA = "0x185587230", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DJHIIBCIELN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6205DB0", Offset = "0x6204FB0", VA = "0x186205DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D1CA20", Offset = "0x1D1BC20", VA = "0x181D1CA20", Slot = "8")]
	public bool Equals(GBFNOIADDPJ MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6205D20", Offset = "0x6204F20", VA = "0x186205D20", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GLAEAADPLNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POBJLGLNAHM(GAANJEIKMIE MFIBAFBMCBA, NJFLAEHPIGP NBINPNLDMFM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POBJLGLNAHM(JDJHKBJECJO NKFGLIJJHIJ, NJFLAEHPIGP NBINPNLDMFM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFONEHDFHBN(JDJHKBJECJO NKFGLIJJHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIFHGLCKHOF(JDJHKBJECJO NKFGLIJJHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDICGEOCKPI();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHPDIGOGFON(NJFLAEHPIGP MJMAEGDPBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CJNCNKGHHPP(GAANJEIKMIE MFIBAFBMCBA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CJNCNKGHHPP(JDJHKBJECJO NKFGLIJJHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void INJLKCCBDPN(JDJHKBJECJO NKFGLIJJHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EIADOKGDACJ(JDJHKBJECJO NKFGLIJJHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HEIDOMIMAIO();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BGLLDPGKOIC();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DNLHIJIFEMF(GAANJEIKMIE MFIBAFBMCBA, FACIIGAFJII MJMAEGDPBNJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FKCNCHOCAEJ(JDJHKBJECJO NKFGLIJJHIJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KBJKDMAGIOA(JDJHKBJECJO NKFGLIJJHIJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void COOMKHHDCJC();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NGDBKOACFOD(FACIIGAFJII MJMAEGDPBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PAGMFFIBIOF(GAANJEIKMIE MFIBAFBMCBA, Vector3 BJMPJFAKGBA, Vector3 IMOIJNKOHNF, Vector3 MILKLCPBCJI, float NABBLMKCMAL, float BKMCFOHNALK, IReadOnlyList<Camera> LEPCAMDDLNN, KBDADMCHHJA HFHFGCMEBKK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PAGMFFIBIOF(GBFNOIADDPJ ONCDCCFIGLK, Vector3 BJMPJFAKGBA, Vector3 IMOIJNKOHNF, Vector3 MILKLCPBCJI, float NABBLMKCMAL, float BKMCFOHNALK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GAFEFIOOPCM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MBLIHEFFPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GAANJEIKMIE AEAKJKBBFOD(FHKDPKLBJJK MJGHOBDIDHD);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GAANJEIKMIE AEAKJKBBFOD(FHKDPKLBJJK MJGHOBDIDHD, bool BKGNKLBLPDG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPMKHNOEMEF(GAANJEIKMIE MFIBAFBMCBA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKKPHGBDMNI(GAANJEIKMIE MFIBAFBMCBA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JDJHKBJECJO CDJDIHGCFIP(GAANJEIKMIE MFIBAFBMCBA, OMOAPGBLBBK MJGHOBDIDHD);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JDJHKBJECJO OCEDHBDOAGM(GAANJEIKMIE MFIBAFBMCBA, HJEAALBNHHM MJGHOBDIDHD);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PAFNHFCAIOD(JDJHKBJECJO NKFGLIJJHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFJDIPCCBIA(JDJHKBJECJO NKFGLIJJHIJ);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GBFNOIADDPJ NGJKBLIDMPK(DDEICIKGNFL MJGHOBDIDHD);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FDMHEBBLCJM(GBFNOIADDPJ ONCDCCFIGLK);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FJCDCKAIIIM(GBFNOIADDPJ ONCDCCFIGLK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DJCJPAGLIEP();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LNAFOBLMCGB();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task PMCKFLJGJKB();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KEFIGMCOOBB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> JNLLMAJHMNF(GAANJEIKMIE MFIBAFBMCBA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NEMOOMPCAHD
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum LHFAMNCAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum MHOMKBGFBHL
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum KLCAJMAIKJH
	{
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum KEGMPLPLKIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		ErrorCalculated,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum GHEPNHGLCMA
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Quest3
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static int OBAJFONKMKP;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static int FLCKFHMENCB;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static int ODCCNCLHPED;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static int JLILCIOGBJJ;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int[] IOJJGGJNOIB;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int KEAPFGDPJBP;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int EKBEGKJFBDD;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int EMJNEJINMIK;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static long ADLNICGFDOO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static long INJMHJAAOIE;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static long JGNPCACBHBN;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static long NFLDCMPIFMM;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long GIPBIFJBOCN;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long HPMODKOJAIE;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long BKHNPIOEBNP;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long PJHAPHMAAHD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long DNIMFMCDIPC;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long IPCBILBPLDC;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long CPLFPIAGAJD;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long DLKFBNLEBCD;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float EDNHKKGGEGI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static long JMDBGIIGBAN;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long NHEMDKHLKLN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static GHEPNHGLCMA IOBFIFFGBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6208D10", Offset = "0x6207F10", VA = "0x186208D10")]
		[CompilerGenerated]
		get
		{
			return default(GHEPNHGLCMA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62078A0", Offset = "0x6206AA0", VA = "0x1862078A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool IOFJBLLFLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6208C60", Offset = "0x6207E60", VA = "0x186208C60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62098E0", Offset = "0x6208AE0", VA = "0x1862098E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static LHFAMNCAKCD ELLIJHCMLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62097A0", Offset = "0x62089A0", VA = "0x1862097A0")]
		[CompilerGenerated]
		get
		{
			return default(LHFAMNCAKCD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6207760", Offset = "0x6206960", VA = "0x186207760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool MPFHNNGLICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6208910", Offset = "0x6207B10", VA = "0x186208910")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6207350", Offset = "0x6206550", VA = "0x186207350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static MHOMKBGFBHL JODOJDNDFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6208680", Offset = "0x6207880", VA = "0x186208680")]
		[CompilerGenerated]
		get
		{
			return default(MHOMKBGFBHL);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6209700", Offset = "0x6208900", VA = "0x186209700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool ILBAGLHMDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6209150", Offset = "0x6208350", VA = "0x186209150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6207650", Offset = "0x6206850", VA = "0x186207650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool DDGNKFILOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62099E0", Offset = "0x6208BE0", VA = "0x1862099E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6208960", Offset = "0x6207B60", VA = "0x186208960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool JAADDEILNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6208770", Offset = "0x6207970", VA = "0x186208770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6209090", Offset = "0x6208290", VA = "0x186209090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static float CHGBGDOEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6209660", Offset = "0x6208860", VA = "0x186209660")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6208D60", Offset = "0x6207F60", VA = "0x186208D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static int OICENDPGMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6209840", Offset = "0x6208A40", VA = "0x186209840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6208B70", Offset = "0x6207D70", VA = "0x186208B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int BHBEIOHLLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62093A0", Offset = "0x62085A0", VA = "0x1862093A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6208B20", Offset = "0x6207D20", VA = "0x186208B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int ALKNGBHDLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6208A60", Offset = "0x6207C60", VA = "0x186208A60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x62086D0", Offset = "0x62078D0", VA = "0x1862086D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int OCIJHMIBMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x62078F0", Offset = "0x6206AF0", VA = "0x1862078F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6207AF0", Offset = "0x6206CF0", VA = "0x186207AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int ELMCAOHMHNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6207C20", Offset = "0x6206E20", VA = "0x186207C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6209300", Offset = "0x6208500", VA = "0x186209300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int FDNGHBOOBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x62096B0", Offset = "0x62088B0", VA = "0x1862096B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6209940", Offset = "0x6208B40", VA = "0x186209940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int PJKNMCPOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6208810", Offset = "0x6207A10", VA = "0x186208810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6209510", Offset = "0x6208710", VA = "0x186209510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int NPNBCCIKNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6209750", Offset = "0x6208950", VA = "0x186209750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6207850", Offset = "0x6206A50", VA = "0x186207850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int MAFBBLAHBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6209040", Offset = "0x6208240", VA = "0x186209040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62077B0", Offset = "0x62069B0", VA = "0x1862077B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int HNNIFJMGLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62089C0", Offset = "0x6207BC0", VA = "0x1862089C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62097F0", Offset = "0x62089F0", VA = "0x1862097F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int LBJBCPCGJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6207940", Offset = "0x6206B40", VA = "0x186207940")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6207550", Offset = "0x6206750", VA = "0x186207550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int AFJOFBOFCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6208EC0", Offset = "0x62080C0", VA = "0x186208EC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62073B0", Offset = "0x62065B0", VA = "0x1862073B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int OBOEMBINFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6209A30", Offset = "0x6208C30", VA = "0x186209A30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6207300", Offset = "0x6206500", VA = "0x186207300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int BCNFAPMPAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6208FF0", Offset = "0x62081F0", VA = "0x186208FF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6207600", Offset = "0x6206800", VA = "0x186207600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int CBKFIAFPIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6208E70", Offset = "0x6208070", VA = "0x186208E70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6207400", Offset = "0x6206600", VA = "0x186207400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool NLMCFHKILGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62092B0", Offset = "0x62084B0", VA = "0x1862092B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62094B0", Offset = "0x62086B0", VA = "0x1862094B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool EIADEIEFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6207710", Offset = "0x6206910", VA = "0x186207710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6207A40", Offset = "0x6206C40", VA = "0x186207A40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static KLCAJMAIKJH HBBOAAEGIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6208720", Offset = "0x6207920", VA = "0x186208720")]
		[CompilerGenerated]
		get
		{
			return default(KLCAJMAIKJH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6207AA0", Offset = "0x6206CA0", VA = "0x186207AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool PPCIIGNNOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6208A10", Offset = "0x6207C10", VA = "0x186208A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6208DC0", Offset = "0x6207FC0", VA = "0x186208DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static float JKFBNOKKAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6207500", Offset = "0x6206700", VA = "0x186207500")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62072A0", Offset = "0x62064A0", VA = "0x1862072A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static float LCKNHANEKAI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6209890", Offset = "0x6208A90", VA = "0x186209890")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6208860", Offset = "0x6207A60", VA = "0x186208860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static float LCGLJKODIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6209350", Offset = "0x6208550", VA = "0x186209350")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6207450", Offset = "0x6206650", VA = "0x186207450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float NAKENKDBJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6208BC0", Offset = "0x6207DC0", VA = "0x186208BC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6207B40", Offset = "0x6206D40", VA = "0x186207B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float ABMOHKLIBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6208E20", Offset = "0x6208020", VA = "0x186208E20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6207990", Offset = "0x6206B90", VA = "0x186207990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float NNNMGDECFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6208C10", Offset = "0x6207E10", VA = "0x186208C10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62093F0", Offset = "0x62085F0", VA = "0x1862093F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool AIDOOFOKKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x62095C0", Offset = "0x62087C0", VA = "0x1862095C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6209560", Offset = "0x6208760", VA = "0x186209560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float MNHPPDPDODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6207800", Offset = "0x6206A00", VA = "0x186207800")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6209450", Offset = "0x6208650", VA = "0x186209450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static int DCBCOEOLIKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62074B0", Offset = "0x62066B0", VA = "0x1862074B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6208CB0", Offset = "0x6207EB0", VA = "0x186208CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static int ABKADDPNLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62088C0", Offset = "0x6207AC0", VA = "0x1862088C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62091A0", Offset = "0x62083A0", VA = "0x1862091A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool BNDAACHBEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6209990", Offset = "0x6208B90", VA = "0x186209990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int DHOOJJFHBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62079F0", Offset = "0x6206BF0", VA = "0x1862079F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62090F0", Offset = "0x62082F0", VA = "0x1862090F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static float4x4 MEGALDPBMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6207BA0", Offset = "0x6206DA0", VA = "0x186207BA0")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6208F10", Offset = "0x6208110", VA = "0x186208F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static float3 OODGLEIOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6208AB0", Offset = "0x6207CB0", VA = "0x186208AB0")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62076B0", Offset = "0x62068B0", VA = "0x1862076B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static bool DFIHBFFCEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6209610", Offset = "0x6208810", VA = "0x186209610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62075A0", Offset = "0x62067A0", VA = "0x1862075A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static KEGMPLPLKIF FNKJHEDLMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x62087C0", Offset = "0x62079C0", VA = "0x1862087C0")]
		[CompilerGenerated]
		get
		{
			return default(KEGMPLPLKIF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6208F90", Offset = "0x6208190", VA = "0x186208F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static bool HKHJKAFGJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6207C70", Offset = "0x6206E70", VA = "0x186207C70")]
	public static void GGFDHFAIJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6209200", Offset = "0x6208400", VA = "0x186209200")]
	public static void LKNGHPNCEEC(GHEPNHGLCMA LFFLLKIOCIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NJGCILGJOJA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct INAJOLNCJKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Vector3 BKEJMFAHMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Quaternion ONICOCGNJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public float NLMAMOOMJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Quaternion ADDPNOKEDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float FPEPPOJJOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public float HLEGMNGHPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public float OOFJPGDCHPL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static List<INAJOLNCJKK> FPICEBIAJLF;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6209F20", Offset = "0x6209120", VA = "0x186209F20")]
	public static NativeList<CBKEPECMHFD> DDHIKDCKCHI(AIOMFMEPKOM JCFIBHGAALP)
	{
		return default(NativeList<CBKEPECMHFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x620C0D0", Offset = "0x620B2D0", VA = "0x18620C0D0")]
	private static bool PMCJMDBDCCJ(int IBNKLDKLAGI, NativeList<CBKEPECMHFD> IFJGEIAONPI, List<INAJOLNCJKK> DHMHIDFJNBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x620BF40", Offset = "0x620B140", VA = "0x18620BF40")]
	private static CBKEPECMHFD MLPHMBAIKJJ(int NMHNBICEFKP, List<INAJOLNCJKK> DHMHIDFJNBK)
	{
		return default(CBKEPECMHFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x620BA30", Offset = "0x620AC30", VA = "0x18620BA30")]
	private static CBKEPECMHFD LABMMFLHMGB(int NMHNBICEFKP, List<INAJOLNCJKK> DHMHIDFJNBK)
	{
		return default(CBKEPECMHFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x620B950", Offset = "0x620AB50", VA = "0x18620B950")]
	private static CBKEPECMHFD IGCMCDHABEM(Vector3 CCDONDNKELE, Quaternion CHNFMIDIJDA, float MBFEDEOEGOE)
	{
		return default(CBKEPECMHFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x620A4A0", Offset = "0x62096A0", VA = "0x18620A4A0")]
	public static NativeList<CBKEPECMHFD> GDBIGOKGHMH(AIOMFMEPKOM JCFIBHGAALP, float CKGJDHPJBDN)
	{
		return default(NativeList<CBKEPECMHFD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KLIDNFNMHLN
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static Vector3 FNJHFMMLCDH;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static Vector3 AFDMGJIHCFP;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly float PGECPALGACI;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6206380", Offset = "0x6205580", VA = "0x186206380")]
	public static Vector3 ECJFOEBIMAK(Vector3 FHHAFMCNAHF, Quaternion CHNFMIDIJDA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6206600", Offset = "0x6205800", VA = "0x186206600")]
	public static Vector3 GPPCGKGLICI(Quaternion ECLCOOPOABI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62070D0", Offset = "0x62062D0", VA = "0x1862070D0")]
	public static Vector3 ODFENGHADDC(Quaternion ECLCOOPOABI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6206E60", Offset = "0x6206060", VA = "0x186206E60")]
	public static Quaternion NEEFNPIMNIN(Vector3 HIMAANDEJKI, Vector3 KBHLNPNINOC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6206EE0", Offset = "0x62060E0", VA = "0x186206EE0")]
	public static Vector3 NOJOGCMJOMP(Vector3 CNHDKINOHPO, Vector3 KAAEHEPGMPH, Vector3 KBHLNPNINOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6205F50", Offset = "0x6205150", VA = "0x186205F50")]
	public static Vector3 DHEDAHMHAGL(Vector3 FHHAFMCNAHF, Vector3 KBHLNPNINOC, Quaternion ECLCOOPOABI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x62066A0", Offset = "0x62058A0", VA = "0x1862066A0")]
	public static Quaternion HFBGFHOMGNN(Quaternion CHNFMIDIJDA, Vector3 HIMAANDEJKI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6206A00", Offset = "0x6205C00", VA = "0x186206A00")]
	public static bool IJBPNPPCELO(Vector3 JCPDAIPMNMP, Vector3 JEEKIHADBKL, [Out] Vector3 MLJMDLGBAJI, bool GLNOGKBNCEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6206B70", Offset = "0x6205D70", VA = "0x186206B70")]
	public static Vector3 KJAMDMEDDPO(bool IPNDDDAMBKA, [Optional] Quaternion JGJGLIHDNLG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CBKEPECMHFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public float3 BKEJMFAHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public float3x3 ONICOCGNJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public float NLMAMOOMJNP;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AIOMFMEPKOM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	int MBCIOCIHCGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 HGELAMCEACN(int NMHNBICEFKP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion GOALFPGCDKC(int NMHNBICEFKP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float MOHBEGJHDBC(int NMHNBICEFKP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HJEAALBNHHM : PNFKJLJAIMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool KPIPGBDFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool IEAIACPKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float DGDKDBFNAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	int FGLLOFPGAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool HBAPFCAPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int PJMKLAFNJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CBKEPECMHFD> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OMOAPGBLBBK : PNFKJLJAIMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	IIMLOMPLGMB JNILLIGJODA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool DFJHOFHIMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface FHKDPKLBJJK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	AFMLJEGJNBJ MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HMPAGALPMBH DCGDEFLLBFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PNFKJLJAIMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool FIAAMNBEAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool IEOLDBFHCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AFMLJEGJNBJ MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float NHJPGMFGAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Vector3 GMHNAFECOMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	LJFEFAMPPFH HEMIGLOJEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	FPEFJDMPECH CAHGAMOACEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DDEICIKGNFL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int JJCMHDJOMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Transform HKEAAEDILOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool DPIFGANCLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GAANJEIKMIE GetBone(int NMHNBICEFKP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int NMHNBICEFKP);
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
