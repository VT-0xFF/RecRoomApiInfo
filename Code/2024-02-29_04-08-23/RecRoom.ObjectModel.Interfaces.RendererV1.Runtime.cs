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
public enum HAGIEIPOKBM
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
public enum LPOKNNAKEAE
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
public enum KDDOAEOCBMD
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
public enum OKMACCHCGLB
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
public enum OAILCNKFKII
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
public enum OAEIMDOBIAE
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
public static class GNAGIBEAINM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60B78F0", Offset = "0x60B66F0", VA = "0x1860B78F0")]
	public static bool EPHJKOMBEBJ(this OAEIMDOBIAE EPMAFGOIKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60B78E0", Offset = "0x60B66E0", VA = "0x1860B78E0")]
	public static bool BENLDNKMPPF(this OAEIMDOBIAE EPMAFGOIKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60B7910", Offset = "0x60B6710", VA = "0x1860B7910")]
	public static bool KBDBIJMHFMH(this OAEIMDOBIAE EPMAFGOIKLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FCKJPJLMAPE
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
public struct JGBEIAHMINN : CDBBGDPCLAA, IEquatable<JGBEIAHMINN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int CCEAOHGDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int KKDGMDBLCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2200D30", Offset = "0x21FFB30", VA = "0x182200D30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x544ED00", Offset = "0x544DB00", VA = "0x18544ED00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MEKBGLMALDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60B8CF0", Offset = "0x60B7AF0", VA = "0x1860B8CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1C9ED40", Offset = "0x1C9DB40", VA = "0x181C9ED40", Slot = "8")]
	public bool Equals(JGBEIAHMINN FPEEGIOMOFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA020", Offset = "0x5FF8E20", VA = "0x185FFA020")]
	public static bool PONNJIKFNKJ(JGBEIAHMINN GCMDJKOKHCO, JGBEIAHMINN LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60B8C60", Offset = "0x60B7A60", VA = "0x1860B8C60", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60B8D30", Offset = "0x60B7B30", VA = "0x1860B8D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OCCGANNGJED : CDBBGDPCLAA, IEquatable<OCCGANNGJED>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CCEAOHGDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int KKDGMDBLCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2200D30", Offset = "0x21FFB30", VA = "0x182200D30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x544ED00", Offset = "0x544DB00", VA = "0x18544ED00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MEKBGLMALDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60BEAF0", Offset = "0x60BD8F0", VA = "0x1860BEAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1C9ED40", Offset = "0x1C9DB40", VA = "0x181C9ED40", Slot = "8")]
	public bool Equals(OCCGANNGJED FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60BEA60", Offset = "0x60BD860", VA = "0x1860BEA60", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60BEB30", Offset = "0x60BD930", VA = "0x1860BEB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NDCEFGIIAAC : CDBBGDPCLAA, IEquatable<NDCEFGIIAAC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CCEAOHGDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KKDGMDBLCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2200D30", Offset = "0x21FFB30", VA = "0x182200D30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x544ED00", Offset = "0x544DB00", VA = "0x18544ED00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MEKBGLMALDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60BEA20", Offset = "0x60BD820", VA = "0x1860BEA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1C9ED40", Offset = "0x1C9DB40", VA = "0x181C9ED40", Slot = "8")]
	public bool Equals(NDCEFGIIAAC FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60BE990", Offset = "0x60BD790", VA = "0x1860BE990", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LKINHOILCBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLONGMHEOAM(JGBEIAHMINN ADCDJFADKCK, LPOKNNAKEAE KKDBAKJEPPA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLONGMHEOAM(OCCGANNGJED NEOAOHJOLBD, LPOKNNAKEAE KKDBAKJEPPA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKCPKNJGKLG(OCCGANNGJED NEOAOHJOLBD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPLPDMAILMH(OCCGANNGJED NEOAOHJOLBD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBKGEEPANDP();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHBPAAIAIEM(LPOKNNAKEAE HFFNCGFKMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEIBJJJJBLA(JGBEIAHMINN ADCDJFADKCK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OEIBJJJJBLA(OCCGANNGJED NEOAOHJOLBD);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJCEOADJPIC(OCCGANNGJED NEOAOHJOLBD);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ICNOCEDLEPP(OCCGANNGJED NEOAOHJOLBD);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KPCFENJKNMH();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FIAEEGAMEJO();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DAPNPELKKJF(JGBEIAHMINN ADCDJFADKCK, OAILCNKFKII HFFNCGFKMBJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LGFKDLHMOAA(OCCGANNGJED NEOAOHJOLBD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LEKCIDMHHNJ(OCCGANNGJED NEOAOHJOLBD);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FFFOIDFCMNI();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FPAHHHMKIEL(OAILCNKFKII HFFNCGFKMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KJEMMAMIEAD(JGBEIAHMINN ADCDJFADKCK, Vector3 KBIKDPFLKEO, Vector3 AHPPPOPHFAI, Vector3 ALIFHKFOEGF, float LAMECCBLPGJ, float LOCNLIOAOFL, IReadOnlyList<Camera> JOBFIJGPCDF, HAGIEIPOKBM FFBBOKJELDN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KJEMMAMIEAD(NDCEFGIIAAC DPDDHAILJPH, Vector3 KBIKDPFLKEO, Vector3 AHPPPOPHFAI, Vector3 ALIFHKFOEGF, float LAMECCBLPGJ, float LOCNLIOAOFL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CBBHLNFCBGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PKFCBPGOBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JGBEIAHMINN FPNDGGIIFFN(OKNHCPJBMCP OMHIFBJFAGA);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JGBEIAHMINN FPNDGGIIFFN(OKNHCPJBMCP OMHIFBJFAGA, bool DKKBJIONKAM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHPCMFIJDND(JGBEIAHMINN ADCDJFADKCK);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFGCBNFCNFI(JGBEIAHMINN ADCDJFADKCK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OCCGANNGJED NMIIFIFOEJE(JGBEIAHMINN ADCDJFADKCK, DGFHFEOFIHG OMHIFBJFAGA);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OCCGANNGJED KBOGLEIMDKM(JGBEIAHMINN ADCDJFADKCK, BLIDLKONCKO OMHIFBJFAGA);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEKOKFLBCOG(OCCGANNGJED NEOAOHJOLBD);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PDHPCMBENCA(OCCGANNGJED NEOAOHJOLBD);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NDCEFGIIAAC PCPHBHDFCJP(ABHGPEPJHAG OMHIFBJFAGA);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BLPIBNECHBC(NDCEFGIIAAC DPDDHAILJPH);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IIMOJIAPOEA(NDCEFGIIAAC DPDDHAILJPH);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task HMMMBOEFEAP();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DDEENKPIPJO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task DPDJOHHPFCJ();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PFEGDNCENHN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> BOIGLDAFAKN(JGBEIAHMINN ADCDJFADKCK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MINJDOHALFF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum CBOODPIMBEC
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
	public enum DGNOGPHEMEC
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum AHLHBPCECMI
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
	public enum CPNFLFNBCAE
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
	private static bool DMGKIBKLOAD;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int OLFGFBNCHAC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int JGFPCJBPOID;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int KLGJKPOKJCM;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int ILDKHNDNCGF;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int LIANDPJCOJJ;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int PNAKNDKNMJB;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int HDOFGHOFBON;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static int BDLNMEOFLKL;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static long JGCOCLAGBID;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static long EAOMAOBFCJH;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static long HIHEMHHINFP;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static long EGMCHNNMCFE;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static long PGNAJCHPMBJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static long MAKCGLEPJHK;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static long EPCHLMJAKBH;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static long DBCEBMGBNJN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static CPNFLFNBCAE ELLILNGFIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60BCA20", Offset = "0x60BB820", VA = "0x1860BCA20")]
		[CompilerGenerated]
		get
		{
			return default(CPNFLFNBCAE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60BCC20", Offset = "0x60BBA20", VA = "0x1860BCC20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static CBOODPIMBEC OJPKELACLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60BCDE0", Offset = "0x60BBBE0", VA = "0x1860BCDE0")]
		[CompilerGenerated]
		get
		{
			return default(CBOODPIMBEC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60BE510", Offset = "0x60BD310", VA = "0x1860BE510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool MDCAKHKJDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60BDD80", Offset = "0x60BCB80", VA = "0x1860BDD80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60BCE30", Offset = "0x60BBC30", VA = "0x1860BCE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DGNOGPHEMEC OKGKGPGKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60BDC70", Offset = "0x60BCA70", VA = "0x1860BDC70")]
		[CompilerGenerated]
		get
		{
			return default(DGNOGPHEMEC);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60BCBC0", Offset = "0x60BB9C0", VA = "0x1860BCBC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool ILIOHOANNNL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x60BDF40", Offset = "0x60BCD40", VA = "0x1860BDF40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60BC960", Offset = "0x60BB760", VA = "0x1860BC960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool KCGDCAACCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x60BCB70", Offset = "0x60BB970", VA = "0x1860BCB70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60BC2B0", Offset = "0x60BB0B0", VA = "0x1860BC2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static float BIMKEEDBEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60BC210", Offset = "0x60BB010", VA = "0x1860BC210")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60BDDD0", Offset = "0x60BCBD0", VA = "0x1860BDDD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static int AHLPKIMJPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60BC800", Offset = "0x60BB600", VA = "0x1860BC800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static int GODAGCKNHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60BC170", Offset = "0x60BAF70", VA = "0x1860BC170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60BE460", Offset = "0x60BD260", VA = "0x1860BE460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static int GFDNMEELFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60BCB20", Offset = "0x60BB920", VA = "0x1860BCB20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60BDE30", Offset = "0x60BCC30", VA = "0x1860BDE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int CELPBOOCAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60BD970", Offset = "0x60BC770", VA = "0x1860BD970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x60BCD80", Offset = "0x60BBB80", VA = "0x1860BCD80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int PNPJHMDHMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60BE0F0", Offset = "0x60BCEF0", VA = "0x1860BE0F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60BE140", Offset = "0x60BCF40", VA = "0x1860BE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int MCFPNDGDHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x60BC700", Offset = "0x60BB500", VA = "0x1860BC700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60BCD20", Offset = "0x60BBB20", VA = "0x1860BCD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int KKKFKNACLOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x60BC910", Offset = "0x60BB710", VA = "0x1860BC910")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x60BE400", Offset = "0x60BD200", VA = "0x1860BE400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int OPIAKFIKGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x60BC1C0", Offset = "0x60BAFC0", VA = "0x1860BC1C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x60BCE90", Offset = "0x60BBC90", VA = "0x1860BCE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int AMKGICENIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x60BCF50", Offset = "0x60BBD50", VA = "0x1860BCF50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x60BDB60", Offset = "0x60BC960", VA = "0x1860BDB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int LCNEKNDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60BDC20", Offset = "0x60BCA20", VA = "0x1860BDC20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60BCEF0", Offset = "0x60BBCF0", VA = "0x1860BCEF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int KJCDMGIICDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x60BDE90", Offset = "0x60BCC90", VA = "0x1860BDE90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x60BCFF0", Offset = "0x60BBDF0", VA = "0x1860BCFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static bool IOHKHHIHLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60BE4C0", Offset = "0x60BD2C0", VA = "0x1860BE4C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60BC860", Offset = "0x60BB660", VA = "0x1860BC860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static bool PNIBKOBEEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x60BCCD0", Offset = "0x60BBAD0", VA = "0x1860BCCD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60BDD20", Offset = "0x60BCB20", VA = "0x1860BDD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static AHLHBPCECMI AKBHOIIGIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x60BC260", Offset = "0x60BB060", VA = "0x1860BC260")]
		[CompilerGenerated]
		get
		{
			return default(AHLHBPCECMI);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60BD050", Offset = "0x60BBE50", VA = "0x1860BD050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool AMCKMOJALLI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60BE310", Offset = "0x60BD110", VA = "0x1860BE310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60BC7A0", Offset = "0x60BB5A0", VA = "0x1860BC7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float GBKHIPGPBNE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x60BC8C0", Offset = "0x60BB6C0", VA = "0x1860BC8C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60BC6A0", Offset = "0x60BB4A0", VA = "0x1860BC6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float KHAFEFLBNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x60BCFA0", Offset = "0x60BBDA0", VA = "0x1860BCFA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60BE1F0", Offset = "0x60BCFF0", VA = "0x1860BE1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static float HNELEGEAFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60BE040", Offset = "0x60BCE40", VA = "0x1860BE040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x60BC9C0", Offset = "0x60BB7C0", VA = "0x1860BC9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static float JICBFMPLJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x60BCC80", Offset = "0x60BBA80", VA = "0x1860BCC80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x60BE2B0", Offset = "0x60BD0B0", VA = "0x1860BE2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static float EFFCONOKOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x60BE3B0", Offset = "0x60BD1B0", VA = "0x1860BE3B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x60BC0B0", Offset = "0x60BAEB0", VA = "0x1860BC0B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool AMANKFCNIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x60BC750", Offset = "0x60BB550", VA = "0x1860BC750")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x60BDB00", Offset = "0x60BC900", VA = "0x1860BDB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static float BOBHKOEMLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x60BDF90", Offset = "0x60BCD90", VA = "0x1860BDF90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60BDAA0", Offset = "0x60BC8A0", VA = "0x1860BDAA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int PNCFLHKBNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x60BE360", Offset = "0x60BD160", VA = "0x1860BE360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60BE250", Offset = "0x60BD050", VA = "0x1860BE250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int CIGEJNKKBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x60BCA70", Offset = "0x60BB870", VA = "0x1860BCA70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60BC640", Offset = "0x60BB440", VA = "0x1860BC640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int AJIFGLOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60BC060", Offset = "0x60BAE60", VA = "0x1860BC060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60BDEE0", Offset = "0x60BCCE0", VA = "0x1860BDEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool BBKEFFJKNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60BDFE0", Offset = "0x60BCDE0", VA = "0x1860BDFE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60BCAC0", Offset = "0x60BB8C0", VA = "0x1860BCAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static Transform MMHJBPIONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60BDCC0", Offset = "0x60BCAC0", VA = "0x1860BDCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x60BD9C0", Offset = "0x60BC7C0", VA = "0x1860BD9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool CPKBKJDOFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60BDA40", Offset = "0x60BC840", VA = "0x1860BDA40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60BC110", Offset = "0x60BAF10", VA = "0x1860BC110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool KLHEEGOILEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x60BE090", Offset = "0x60BCE90", VA = "0x1860BE090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x60BC000", Offset = "0x60BAE00", VA = "0x1860BC000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static bool CLJBPAHEANA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60BE1A0", Offset = "0x60BCFA0", VA = "0x1860BE1A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60BDBC0", Offset = "0x60BC9C0", VA = "0x1860BDBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60BD0B0", Offset = "0x60BBEB0", VA = "0x1860BD0B0")]
	public static void IAGBJOPKICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60BC310", Offset = "0x60BB110", VA = "0x1860BC310")]
	public static void BOGJKPPFIEC(CPNFLFNBCAE GGFLDJKHBNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JGJFINFLFBD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MEOBOOPJICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Vector3 CDFOMBDMAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Quaternion DMOAIFFPMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public float PCPCKJPOKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Quaternion NPGDBGFDNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float EAHKIIGGHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public float APNDLPFIHEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float HOHABOEIKOJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static List<MEOBOOPJICC> DJDFCHNMNGD;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60BA010", Offset = "0x60B8E10", VA = "0x1860BA010")]
	public static NativeList<JIIOCPIGNAG> KJFIFJPNNKE(NMOJAJBFICK LINKNNNEGKJ)
	{
		return default(NativeList<JIIOCPIGNAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60B9030", Offset = "0x60B7E30", VA = "0x1860B9030")]
	private static bool CPEFGMPFBCO(int PGCIMAABPAK, NativeList<JIIOCPIGNAG> BGCCPJGDEGH, List<MEOBOOPJICC> ACFNIIMFABG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x60B8DC0", Offset = "0x60B7BC0", VA = "0x1860B8DC0")]
	private static JIIOCPIGNAG BIJJMDAKJDN(int PKGDCCCLANB, List<MEOBOOPJICC> ACFNIIMFABG)
	{
		return default(JIIOCPIGNAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x60BA590", Offset = "0x60B9390", VA = "0x1860BA590")]
	private static JIIOCPIGNAG NABMIEGNPOI(int PKGDCCCLANB, List<MEOBOOPJICC> ACFNIIMFABG)
	{
		return default(JIIOCPIGNAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60B8F50", Offset = "0x60B7D50", VA = "0x1860B8F50")]
	private static JIIOCPIGNAG CBDDCHCAODN(Vector3 OBIONJJHEHM, Quaternion MMKDNLHLGPC, float LLPCJKICLFP)
	{
		return default(JIIOCPIGNAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60BAAA0", Offset = "0x60B98A0", VA = "0x1860BAAA0")]
	public static NativeList<JIIOCPIGNAG> NMGFODIBFOM(NMOJAJBFICK LINKNNNEGKJ, float DAIMGHHAIOL)
	{
		return default(NativeList<JIIOCPIGNAG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ILIJAMDCMOL
{
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static Vector3 DAJLODIADKN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static Vector3 MAPHKCGPNEB;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static readonly float MPEBKNNDOMJ;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x60B79C0", Offset = "0x60B67C0", VA = "0x1860B79C0")]
	public static Vector3 FFLDDCEGNJK(Vector3 PADDHHKNIPG, Quaternion MMKDNLHLGPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x60B8770", Offset = "0x60B7570", VA = "0x1860B8770")]
	public static Vector3 PGJCJOLNMBC(Quaternion GJMDICOFEBG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60B7C50", Offset = "0x60B6A50", VA = "0x1860B7C50")]
	public static Vector3 JPGPILBOKMI(Quaternion GJMDICOFEBG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x60B7940", Offset = "0x60B6740", VA = "0x1860B7940")]
	public static Quaternion ALAGNOPHPOM(Vector3 LLMNHBKBLPP, Vector3 NPJIMHPPOGG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x60B8580", Offset = "0x60B7380", VA = "0x1860B8580")]
	public static Vector3 PFMLFPKPKIK(Vector3 JPDIDENFEME, Vector3 EPBENAHBBKD, Vector3 NPJIMHPPOGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x60B7E60", Offset = "0x60B6C60", VA = "0x1860B7E60")]
	public static Vector3 MMPKMAFOGJA(Vector3 PADDHHKNIPG, Vector3 NPJIMHPPOGG, Quaternion GJMDICOFEBG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x60B8810", Offset = "0x60B7610", VA = "0x1860B8810")]
	public static Quaternion PJIMKFOOJFI(Quaternion MMKDNLHLGPC, Vector3 LLMNHBKBLPP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CF0", Offset = "0x60B6AF0", VA = "0x1860B7CF0")]
	public static bool JPMCMKEGGAA(Vector3 DNAKCBCJDOG, Vector3 ILBDHEJIKFL, [Out] Vector3 EHJGJPELCNI, bool PJFMEFHFDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60B8290", Offset = "0x60B7090", VA = "0x1860B8290")]
	public static Vector3 PDCMFECIHKP(bool DPHBLGPJBDK, [Optional] Quaternion KDLDCCBGGLI)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JIIOCPIGNAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float3 CDFOMBDMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public float3x3 DMOAIFFPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float PCPCKJPOKGL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NMOJAJBFICK
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int IPELHJFNNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 PKALKMEJOHF(int PKGDCCCLANB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion OIGHMHEHPDH(int PKGDCCCLANB);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float AEDCMCIKFAH(int PKGDCCCLANB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BLIDLKONCKO : CKPBKCPIEPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool EAIJECACJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool CBCLOONOJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float KPKABJJHFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	int BBIKEONAFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool BDIOCKPHLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	int AAEJEJOICNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JIIOCPIGNAG> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DGFHFEOFIHG : CKPBKCPIEPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KDDOAEOCBMD PJBJKGPHCDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool IPNPALCDEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OKNHCPJBMCP
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AMFINDHLENJ EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OKMACCHCGLB OGIBNOOCBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CKPBKCPIEPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool IHNOFNICJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool HHLNJNPBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AMFINDHLENJ EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	float EDDAPKMEHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 GDFMPAGOPED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OAEIMDOBIAE FNBOMONNKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	FCKJPJLMAPE OABOJLLBAIL
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
public interface ABHGPEPJHAG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	int NAHPPPMGCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Transform PPDGJDFALCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool HABDNNOBLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JGBEIAHMINN GetBone(int PKGDCCCLANB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int PKGDCCCLANB);
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
