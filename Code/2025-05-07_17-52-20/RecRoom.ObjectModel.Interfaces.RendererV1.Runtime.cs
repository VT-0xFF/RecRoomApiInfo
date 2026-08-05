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
public enum IEMJHKLDHIK
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
public enum KIOOHKBHOLJ
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
public enum IAMAGEBEBON
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
public enum AMAEECJNDGE
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
public enum LIPCMCBNFNH
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
public enum IHNAGNCLKBF
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
public static class FMEGEMKKHPG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6360", Offset = "0x7DE5360", VA = "0x187DE6360")]
	public static bool FLHOLPGOBKA(this IHNAGNCLKBF HNCPHCOBGLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6320", Offset = "0x7DE5320", VA = "0x187DE6320")]
	public static bool AGGNEGHHEDN(this IHNAGNCLKBF HNCPHCOBGLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6330", Offset = "0x7DE5330", VA = "0x187DE6330")]
	public static bool CKLIENPHKEE(this IHNAGNCLKBF HNCPHCOBGLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MNHJGJHOEHN
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
public struct NCCENBGIEMA : PMKOIOKBFCO, IEquatable<NCCENBGIEMA>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0560", Offset = "0x2DDF560", VA = "0x182DE0560", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E779C0", Offset = "0x6E769C0", VA = "0x186E779C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6420", Offset = "0x7DE5420", VA = "0x187DE6420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xEE20C0", Offset = "0xEE10C0", VA = "0x180EE20C0", Slot = "8")]
	public bool Equals(NCCENBGIEMA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x386D0D0", Offset = "0x386C0D0", VA = "0x18386D0D0")]
	public static bool MMJMCICIDNJ(NCCENBGIEMA FDJHCIBLFFB, NCCENBGIEMA CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6380", Offset = "0x7DE5380", VA = "0x187DE6380", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6460", Offset = "0x7DE5460", VA = "0x187DE6460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct CNEDHOBLNKD : PMKOIOKBFCO, IEquatable<CNEDHOBLNKD>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0560", Offset = "0x2DDF560", VA = "0x182DE0560", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E779C0", Offset = "0x6E769C0", VA = "0x186E779C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0C60", Offset = "0x7DDFC60", VA = "0x187DE0C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xEE20C0", Offset = "0xEE10C0", VA = "0x180EE20C0", Slot = "8")]
	public bool Equals(CNEDHOBLNKD MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0BC0", Offset = "0x7DDFBC0", VA = "0x187DE0BC0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0CA0", Offset = "0x7DDFCA0", VA = "0x187DE0CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AENBPOANBNH : PMKOIOKBFCO, IEquatable<AENBPOANBNH>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CEBFMOBHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0560", Offset = "0x2DDF560", VA = "0x182DE0560", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E779C0", Offset = "0x6E769C0", VA = "0x186E779C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0B80", Offset = "0x7DDFB80", VA = "0x187DE0B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xEE20C0", Offset = "0xEE10C0", VA = "0x180EE20C0", Slot = "8")]
	public bool Equals(AENBPOANBNH MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0AE0", Offset = "0x7DDFAE0", VA = "0x187DE0AE0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA3C5A0", Offset = "0xA3B5A0", VA = "0x180A3C5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LGCPEOGBNJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIFCIKAAFBJ(NCCENBGIEMA KNNDNAPJIDP, KIOOHKBHOLJ PNKDOABFNIB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIFCIKAAFBJ(CNEDHOBLNKD HIECCNNOPLP, KIOOHKBHOLJ PNKDOABFNIB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPJOLBDANCE(CNEDHOBLNKD HIECCNNOPLP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEHIGPMIFKB(CNEDHOBLNKD HIECCNNOPLP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HICFMCIHOPG();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMOALEFLFPG(KIOOHKBHOLJ MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ELHEJEFMOHK(NCCENBGIEMA KNNDNAPJIDP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ELHEJEFMOHK(CNEDHOBLNKD HIECCNNOPLP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AOEOCDAGBOE(CNEDHOBLNKD HIECCNNOPLP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JAOIDAIGMCA(CNEDHOBLNKD HIECCNNOPLP);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MONODEMNFCE();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CAJHCNBMPPI();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KGGLMOMDALM(NCCENBGIEMA KNNDNAPJIDP, LIPCMCBNFNH MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CKHMEHHJLJK(CNEDHOBLNKD HIECCNNOPLP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OLIFKEGJAAJ(CNEDHOBLNKD HIECCNNOPLP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MFKGDNHBKAI();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GJBBIKELKDA(LIPCMCBNFNH MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LILAIIIHGCP(NCCENBGIEMA KNNDNAPJIDP, Vector3 CICOCLBFIJN, Vector3 LBHIPCKDOOM, Vector3 PFFFPBJFGBL, float AHGBEHNHMIJ, float CDDCDDIFOPG, IReadOnlyList<Camera> MNHACLNNKJH, IEMJHKLDHIK HBODJJIPFAP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LILAIIIHGCP(AENBPOANBNH GMANNGFCILJ, Vector3 CICOCLBFIJN, Vector3 LBHIPCKDOOM, Vector3 PFFFPBJFGBL, float AHGBEHNHMIJ, float CDDCDDIFOPG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GDHFOHFFOAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NKAMGGLIJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID, bool CDPBIOOBILO);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMDKGKANJNJ(NCCENBGIEMA KNNDNAPJIDP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGEBAJKBNEL(NCCENBGIEMA KNNDNAPJIDP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CNEDHOBLNKD PHGOCJBDJLN(NCCENBGIEMA KNNDNAPJIDP, HNGPMGMDPEH APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CNEDHOBLNKD LICHKICBMDJ(NCCENBGIEMA KNNDNAPJIDP, HFIDGLOEBHF APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MKHJAPCOKEG(CNEDHOBLNKD HIECCNNOPLP);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NBMOKCEOFAB(CNEDHOBLNKD HIECCNNOPLP);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AENBPOANBNH NEBAGIGNLIB(LLFOHOKPBJD APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EINCJLOIGBJ(AENBPOANBNH GMANNGFCILJ);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NKIPNHKJMND(AENBPOANBNH GMANNGFCILJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task IDMBEEIPJJA();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LFIICAHNOAB();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task NLPOMMDGPMD();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AAKMCACJFJD();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> IOMLHMCDOLN(NCCENBGIEMA KNNDNAPJIDP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DJEMCOGPGPN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum ANDIJIKJCAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum NLIBDNJGMPE
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum LJMDLNIAGJO
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		RefreshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum IPLPDMFDEHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum DBNBHGGEKGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum NENBALDHOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum MOIMOJMJGIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum KPHGJMAEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		LowQualityHighSpeed = 102
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool KEDKCDMLPIN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long IMBPPEPNHPK;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool NJEMLPKEGKD;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool OGMFAFDDBFA;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool LNDONLNCNNB;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float OHMNGLDAKKE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float ONLMCIDJFND;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int EMDDKKLBKLA;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static NENBALDHOJJ IGBAEFAPPPM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long NDMNPNDLLOF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float LHBCPNFEJFN;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int AGLPMDBBCNC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int APJEOCMEGNC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int JEOKAHOJHFJ;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int NIDDMJBFIBL;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int BANIGIHEOJA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int BACNBNKCAEG;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int MLKFLDFIPPJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int DIGGFNFJINJ;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool NFHFKBHKBPM;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int MAHMDKGACGK;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int GHHJFOFCEMA;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int JMBMEFFDEEP;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool AKKJHBPANAE;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float NODFHMKOLMH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool LLEMHNNMIOB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float CGJCJIFEMJE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long JIKIICHNADF;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool MCINOLIFMMD;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long GCICLHKONAN;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int FBEDLEFOFAK;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool PIDCACLKNJN;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static ANDIJIKJCAA NPNKJLIDEEG;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool APBBNDCDPJM;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool IOFHDENFFPD;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int CKOEEGOINND;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int BGDDGOHGEEK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int DBCHGOLODCE;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int HJCNHGCFMCF;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int DDOHFNJHNBP;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int DBGEEKDAGGF;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int EBOGJMKGECH;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int JODOEJKGDEE;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float EGEJCHNNANO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float IOODDEMEGAK;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float KGEJMEKKFNP;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float LEAPPNJLILJ;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int AJMDPOMBLKB;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int AKKEFEHGPDJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int FFMFMFJDKIF;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int BKLCLHGJMPP;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool PGGHIADIFCO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static LJMDLNIAGJO JLGBHNPFGNP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static IPLPDMFDEHA JCCBCNHDGHK;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool PNHBNAALMEN;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static NLIBDNJGMPE ALDMJCIJDGN;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float GEDHIBCFKEH;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float MCODPJPJAAM;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float HCDBBCLHKFD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float HNFBHHCCKJI;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float HGGKKFBGKPP;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float FCADPBKOOKC;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float DHDDGIFAFNF;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float CLPAKAJHAKP;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool ONGILOMPPOM;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static MOIMOJMJGIK PDPAKBBENAF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool IGKJLOIDOBE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float OJKAKFOPADI;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float LCLCAIKAMEB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float FIEAHOCLHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float NPIKFCCPMHO;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float IIGJNFGBKMF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool EHJDNBNBPIF;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long FGCJIJHNIKJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float AEPOKDHLOAK;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float PDKNEPJIMJH;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float ONEAINHFKAC;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int AJACBICOHDP;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float ECLBDGDKDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool JEHCABAFABM;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long IGIKNBALDJA;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int GFGEINOJBJG;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int ENNPKJDMNJA;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float HIKKKIKPMOA;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float LHPCHOLMJNL;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool HDNINIEIPDD;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool FKNOBOGJDOC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float FAAOGNLDPJL;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long DDGJFLFJDIA;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long OHNKKPLJGOE;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int ILKLFEJDCDK;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 CODDIFOJLLA;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 BAIBBOPEPKI;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool HPJFKLBIHBA;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static DBNBHGGEKGD FIIJFENMPMD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long KAICHDBJGCB;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int HPCBPDGIFNK;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int IIJEAOODNFF;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int JPILPDNPJDP;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int CLBHPGDJOIC;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int NFKHLLCNGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long GPMDCHLIIKN;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int HICCJMCKLDF;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int JPNPAIBDMEF;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int JCLOCGHNLKO;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long NJBJCKPOLHG;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long GJDHAFHDDAA;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long IOJGKIAOBLA;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long BAKKDIJELDF;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int CMEFJPGNNMP;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int CBDNKBLBIHC;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int FALAOPGBCHA;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int EAGEOEKMAHH;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] PKIAAMLPLLH;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int ALPHCMIJGIK;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long LFPEPILPLAG;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long OJGJDGFEILC;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int MEPDPECCMAB;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int ADKKGLOMHAP;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long JGOIBEODDFH;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long HOGOEBIOJHF;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long LBALKAMNHCH;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long BLGPNJHNGEB;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long KEMCGOMMEIG;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long MBMKPNMHNKM;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long HFNHBMICFNI;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long HAGDDCHKEGO;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long GGHDMGKCLNA;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float LBPJFOJHMEM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float PLHJFIONANI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long CAIMFDLMHHF;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int HDFJNMKICJJ;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long IIPPFCFNBBE;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long OPEPIKMGMPF;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float KLPCNNEDGLD;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long GKFNEPPFFGH;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long OJIMJFMGELA;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long NFHDEDMEJNC;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long HLFIICPGHJI;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long MBBHCHANAJO;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long DMLHMLKOAEA;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long OKIJAENCKDE;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long IEKCDBMGKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long HNJHFODDMNE;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long EAGLIPDJIPP;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long GHOFPBNKBCK;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long CFKCLOHAPEF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static KPHGJMAEJGG GJLJLJGEGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0D90", Offset = "0x7DDFD90", VA = "0x187DE0D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long AGIDPCEKMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0D30", Offset = "0x7DDFD30", VA = "0x187DE0D30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1F40", Offset = "0x7DE0F40", VA = "0x187DE1F40")]
	public static void PFGBNCPOAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0DF0", Offset = "0x7DDFDF0", VA = "0x187DE0DF0")]
	public static void JDBEMNKDFEL(KPHGJMAEJGG PPDBECAENMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EEPEEACBBDO
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct HMBGHNPKCME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 MJJFMHOFJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Quaternion GMKIGHDIIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float KFCBCCPHPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Quaternion BDCGCJAHMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float CACMNIGOIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float AGDLJEFHLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public float EIAFIHFFMDM;
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static List<HMBGHNPKCME> MAFNEMGAFEO;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3720", Offset = "0x7DE2720", VA = "0x187DE3720")]
	public static NativeList<KIKMAHKACEI> FJAFKOHCIKK(BGHHFILJFDL LBGDJDBPBBD)
	{
		return default(NativeList<KIKMAHKACEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3CC0", Offset = "0x7DE2CC0", VA = "0x187DE3CC0")]
	private static bool MIDJJNIDAHN(int DEBKJNNAPAB, NativeList<KIKMAHKACEI> OBOOAPELMPF, List<HMBGHNPKCME> GNKPENKMHAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4B70", Offset = "0x7DE3B70", VA = "0x187DE4B70")]
	private static KIKMAHKACEI NMMGAPCBEHH(int JDCGPDDDLBB, List<HMBGHNPKCME> GNKPENKMHAG)
	{
		return default(KIKMAHKACEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE3230", Offset = "0x7DE2230", VA = "0x187DE3230")]
	private static KIKMAHKACEI EDICKOAMOOI(int JDCGPDDDLBB, List<HMBGHNPKCME> GNKPENKMHAG)
	{
		return default(KIKMAHKACEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4CF0", Offset = "0x7DE3CF0", VA = "0x187DE4CF0")]
	private static KIKMAHKACEI PHECOKEOHIG(Vector3 HNHGJPFCFDL, Quaternion BNLJKPCLJFI, float PIBKBDEFJIN)
	{
		return default(KIKMAHKACEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4DD0", Offset = "0x7DE3DD0", VA = "0x187DE4DD0")]
	public static NativeList<KIKMAHKACEI> PJBALJECDMM(BGHHFILJFDL LBGDJDBPBBD, float DHBMNFOEAIK)
	{
		return default(NativeList<KIKMAHKACEI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class OKJLGGCOEJD
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 EFOBGNBAAIP;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static Vector3 LNNAMPFAIMG;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly float HBDEOAFABEE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE64F0", Offset = "0x7DE54F0", VA = "0x187DE64F0")]
	public static Vector3 BKLJJONHLMD(Vector3 CBOEOPBEHAI, Quaternion BNLJKPCLJFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7690", Offset = "0x7DE6690", VA = "0x187DE7690")]
	public static Vector3 OLDOFFKFEFM(Quaternion OOBEGCNALKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6780", Offset = "0x7DE5780", VA = "0x187DE6780")]
	public static Vector3 CBFAJIEGBGD(Quaternion OOBEGCNALKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6F40", Offset = "0x7DE5F40", VA = "0x187DE6F40")]
	public static Quaternion EJAAPKKPHNK(Vector3 IGEMMIGMOOK, Vector3 HPAMHMBDLLL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7320", Offset = "0x7DE6320", VA = "0x187DE7320")]
	public static Vector3 LBNCOJMKIBF(Vector3 GKKENDHKBCL, Vector3 HJBMANFODFG, Vector3 HPAMHMBDLLL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6B10", Offset = "0x7DE5B10", VA = "0x187DE6B10")]
	public static Vector3 EDNGAPKDHFP(Vector3 CBOEOPBEHAI, Vector3 HPAMHMBDLLL, Quaternion OOBEGCNALKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6FC0", Offset = "0x7DE5FC0", VA = "0x187DE6FC0")]
	public static Quaternion FEAFAKOJIGA(Quaternion BNLJKPCLJFI, Vector3 IGEMMIGMOOK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7510", Offset = "0x7DE6510", VA = "0x187DE7510")]
	public static bool ODPDOMHJDIJ(Vector3 ACHAIAFKMGB, Vector3 OOBIMNJMLNG, [Out] Vector3 OFDPNDMFOFN, bool KIGAMAJONGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6820", Offset = "0x7DE5820", VA = "0x187DE6820")]
	public static Vector3 DIBJKKCJGEA(bool MMPPGJDMPLJ, [Optional] Quaternion KFNHMPEPAMD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KIKMAHKACEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3 MJJFMHOFJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float3x3 GMKIGHDIIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float KFCBCCPHPOG;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BGHHFILJFDL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int HAJCLPENCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 MPIPJGDBDKB(int JDCGPDDDLBB);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion DPKEIPKDLIL(int JDCGPDDDLBB);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float KCIEHOPPJPF(int JDCGPDDDLBB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HFIDGLOEBHF : ONBMMNNCNDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JPDHAHGCJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GAGKMEDIIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float AFHEOEDEDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int LMJOALMNJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DCIOKLKOBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int LLAOOAMCPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<KIKMAHKACEI> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HNGPMGMDPEH : ONBMMNNCNDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IAMAGEBEBON OAOAECOFCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KBLOIDENJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 HLKBEMIEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HIOINALINKM
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CIPJGNAKHIH IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AMAEECJNDGE LMDOBMIEGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ONBMMNNCNDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NDPNAFDPMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool EKKAGJBCIID
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CIPJGNAKHIH IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS OPGPDGACEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float GLOADLJCNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 EHLPPMACBJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	IHNAGNCLKBF LGKJJEDIFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	MNHJGJHOEHN DNDMGAJCGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LLFOHOKPBJD
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int HBAGIMDFAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform IJKFIFBMBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PKOMNKDJGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NCCENBGIEMA GetBone(int JDCGPDDDLBB);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int JDCGPDDDLBB);
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
