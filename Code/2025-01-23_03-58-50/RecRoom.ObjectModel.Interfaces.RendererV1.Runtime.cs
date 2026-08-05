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
public enum MNEJHDFMLNI
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
public enum LDFEEADCCGN
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
public enum LMLJLLLHEEP
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
public enum NFLFIOOFEKC
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
public enum EMCNJLJEEBA
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
public enum CEBKHCOPPLM
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
public static class KLBBOLHIAII
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x709CE90", Offset = "0x709B690", VA = "0x18709CE90")]
	public static bool FDEJMKKIEJB(this CEBKHCOPPLM EIFINMPPANI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x709CEB0", Offset = "0x709B6B0", VA = "0x18709CEB0")]
	public static bool FKFDAMJMJLM(this CEBKHCOPPLM EIFINMPPANI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x709CEC0", Offset = "0x709B6C0", VA = "0x18709CEC0")]
	public static bool KBLGHDCIGGE(this CEBKHCOPPLM EIFINMPPANI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PJFDOHDFBLL
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
public struct HIOFIBKKFLJ : KCFKJNPGMEA, IEquatable<HIOFIBKKFLJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int MBLPHBBBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int KCBFDBADCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x293C5C0", Offset = "0x293ADC0", VA = "0x18293C5C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6292880", Offset = "0x6291080", VA = "0x186292880", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LNCHMIOPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x709BAA0", Offset = "0x709A2A0", VA = "0x18709BAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x13CF730", Offset = "0x13CDF30", VA = "0x1813CF730", Slot = "8")]
	public bool Equals(HIOFIBKKFLJ LIHCAHPMPHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2E6ADE0", Offset = "0x2E695E0", VA = "0x182E6ADE0")]
	public static bool PCBECHOJFKF(HIOFIBKKFLJ DAOGAHJCGEC, HIOFIBKKFLJ NBDADAEEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x709BA10", Offset = "0x709A210", VA = "0x18709BA10", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x709BAE0", Offset = "0x709A2E0", VA = "0x18709BAE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NKAAMDNONPL : KCFKJNPGMEA, IEquatable<NKAAMDNONPL>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MBLPHBBBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int KCBFDBADCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x293C5C0", Offset = "0x293ADC0", VA = "0x18293C5C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6292880", Offset = "0x6291080", VA = "0x186292880", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LNCHMIOPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70A2A50", Offset = "0x70A1250", VA = "0x1870A2A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x13CF730", Offset = "0x13CDF30", VA = "0x1813CF730", Slot = "8")]
	public bool Equals(NKAAMDNONPL LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70A29C0", Offset = "0x70A11C0", VA = "0x1870A29C0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70A2A90", Offset = "0x70A1290", VA = "0x1870A2A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AJANDPBEIBP : KCFKJNPGMEA, IEquatable<AJANDPBEIBP>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MBLPHBBBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KCBFDBADCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x293C5C0", Offset = "0x293ADC0", VA = "0x18293C5C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6292880", Offset = "0x6291080", VA = "0x186292880", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LNCHMIOPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x70988E0", Offset = "0x70970E0", VA = "0x1870988E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x13CF730", Offset = "0x13CDF30", VA = "0x1813CF730", Slot = "8")]
	public bool Equals(AJANDPBEIBP LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7098850", Offset = "0x7097050", VA = "0x187098850", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NNAOBFCCCAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLCOOKBHMMC(HIOFIBKKFLJ KAMAKIBPPKG, LDFEEADCCGN CPOJFOEHPBN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLCOOKBHMMC(NKAAMDNONPL LJMPACNDPEI, LDFEEADCCGN CPOJFOEHPBN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PHGJPKGLNFE(NKAAMDNONPL LJMPACNDPEI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDPECOCIGNH(NKAAMDNONPL LJMPACNDPEI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ELENLMPDFJK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNANPDJOPPG(LDFEEADCCGN OCLAPBNMMGE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGAGOJDMLFF(HIOFIBKKFLJ KAMAKIBPPKG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NGAGOJDMLFF(NKAAMDNONPL LJMPACNDPEI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GHGILGBGANH(NKAAMDNONPL LJMPACNDPEI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LCKLMAOBMAC(NKAAMDNONPL LJMPACNDPEI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PKHADHFDNMM();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DKNJEOMFBNO();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EIGGOEKLMMM(HIOFIBKKFLJ KAMAKIBPPKG, EMCNJLJEEBA OCLAPBNMMGE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HOFPIDIJIMC(NKAAMDNONPL LJMPACNDPEI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OEICJGJJJME(NKAAMDNONPL LJMPACNDPEI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ACEHAPNAGMA();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FIDCJBFMJLI(EMCNJLJEEBA OCLAPBNMMGE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AKMDBPBHEOL(HIOFIBKKFLJ KAMAKIBPPKG, Vector3 JCBHLPMDGBJ, Vector3 MLGGMMPPJIL, Vector3 LBNCMGKMHFD, float DHEDMNFIDCI, float DCMIHBLEHGI, IReadOnlyList<Camera> IFHNAFFKHAB, MNEJHDFMLNI HBIAINGLMPA);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AKMDBPBHEOL(AJANDPBEIBP PDOFMOBALAE, Vector3 JCBHLPMDGBJ, Vector3 MLGGMMPPJIL, Vector3 LBNCMGKMHFD, float DHEDMNFIDCI, float DCMIHBLEHGI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IPOCMNFOENG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JFANPBKFJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HIOFIBKKFLJ PDLEEPPMGIF(PEOKLHNBNLK EBNFOODJNOB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HIOFIBKKFLJ PDLEEPPMGIF(PEOKLHNBNLK EBNFOODJNOB, bool DIDMJOBAPCP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFFFHLDDDFJ(HIOFIBKKFLJ KAMAKIBPPKG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPGBGCECJBB(HIOFIBKKFLJ KAMAKIBPPKG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NKAAMDNONPL GBDEFKMEBOB(HIOFIBKKFLJ KAMAKIBPPKG, FNFGIGIJDCM EBNFOODJNOB);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NKAAMDNONPL ACMFPFBAHHL(HIOFIBKKFLJ KAMAKIBPPKG, NLIBAEJGLLA EBNFOODJNOB);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NFICIAPCMGL(NKAAMDNONPL LJMPACNDPEI);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLGNKFMMMDG(NKAAMDNONPL LJMPACNDPEI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AJANDPBEIBP PGBDIOBJNLC(ECDJJGJNIOF EBNFOODJNOB);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KIOMGKADFON(AJANDPBEIBP PDOFMOBALAE);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GNOPNGKHCBM(AJANDPBEIBP PDOFMOBALAE);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DNDBHNKDDPD();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task GAIDMNGFOFA();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task KOMGPEFEHNL();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KAPHDFKDFEO();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> IDKLKMOLLLJ(HIOFIBKKFLJ KAMAKIBPPKG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LEJHJGJEEFN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum DMPCPCGNCJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum BHFGNODBPFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum HNCCAHDOEEL
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum EBNGKGIPBCD
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum LAMIPKMGPHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum FFGEJBKNKBH
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum OGIEIIJEMJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Quest3,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		MemoryBuild,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		PS4VR,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool IJPLNJBFEGN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static long MAPBMPELOMB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static bool KHPFAJFOEDA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long GKNCNMONDMN;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static int LPEKKJCFPLA;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static BHFGNODBPFG NHLOOFBCJPO;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float HGOJKCKNLEH;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float OLEDAAFHEPD;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static long MDHMFJLCBLP;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long NEHCDAPNBJK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static int GLCMPBGEBME;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static bool DDBHIIAKIHE;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static long KOFLJEEPOBA;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static int EKGLMDLJIGE;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static int BLNHAALLECM;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static long MFHBNJBHEBF;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static long KBEGCDGHMPC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static int GJLLJJJLAFP;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static int BKHAAHFIHLE;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static int GEIIDDDGJIC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static long LLNEMCGIPFL;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static long BPPMAGKFNPK;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static long OKBKJLLHIGO;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static long DDMDGDILHOO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static int EOFKGMCALPI;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static int KFKOIJPLJGN;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int ICDMEEGMMCG;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int HKHFELIPHIN;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int[] OGJLCEEKKOF;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int LAOFEBPFEOA;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static long DDGPEMFLKJK;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long BCKADPBICMB;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int CBHELHIOEMN;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static long NOCJIIBBIGH;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static long KEGBHGOCDFF;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long PDPIEFFHKDL;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long HMLEJILNDGM;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long OHNKPHOHDIJ;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long JEDNOICIHBB;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long ENBCOMAPADJ;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static long ECKECLOJGEH;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static long ILGCJLCDPPG;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static float POMGCECBAHP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long KLNPMKAJFHN;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int BLBHFDNOGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long JEFEKEKPMMH;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long GINEAJJDOBF;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static float NFMHBBNEPOM;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static long PFELPAAGDJI;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long MKJBLPAGMBJ;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long HEACCOPJBMK;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long BDFGDMKGIHM;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long CNAINBAPAPK;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long LAHMJHPNDII;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long HOCIABCGPDO;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long AOAPFKNBMDH;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long CEPGEMGLLJG;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long KJHICNNNJMH;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static long JHFAGELJDJN;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long FAHCBNPOKFN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool NHOGFGJFOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x709CFB0", Offset = "0x709B7B0", VA = "0x18709CFB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x709D0C0", Offset = "0x709B8C0", VA = "0x18709D0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static OGIEIIJEMJA LIEGGIAFIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x709D3B0", Offset = "0x709BBB0", VA = "0x18709D3B0")]
		[CompilerGenerated]
		get
		{
			return default(OGIEIIJEMJA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x709E410", Offset = "0x709CC10", VA = "0x18709E410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool OCOGOGPMADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x709DDA0", Offset = "0x709C5A0", VA = "0x18709DDA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x709CEF0", Offset = "0x709B6F0", VA = "0x18709CEF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool AKGJMDKLCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x709F3D0", Offset = "0x709DBD0", VA = "0x18709F3D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x70A0A70", Offset = "0x709F270", VA = "0x1870A0A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float AFMFFKPAJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x709DD50", Offset = "0x709C550", VA = "0x18709DD50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x709E5E0", Offset = "0x709CDE0", VA = "0x18709E5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float FDCIKCEPAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x709E690", Offset = "0x709CE90", VA = "0x18709E690")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x709F2B0", Offset = "0x709DAB0", VA = "0x18709F2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int PEEJLHHJJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x709DC40", Offset = "0x709C440", VA = "0x18709DC40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x709E230", Offset = "0x709CA30", VA = "0x18709E230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static FFGEJBKNKBH LPNKFICNNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x709E590", Offset = "0x709CD90", VA = "0x18709E590")]
		[CompilerGenerated]
		get
		{
			return default(FFGEJBKNKBH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x709F370", Offset = "0x709DB70", VA = "0x18709F370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long CFBDFHMDKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x709D510", Offset = "0x709BD10", VA = "0x18709D510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x709EB50", Offset = "0x709D350", VA = "0x18709EB50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float KMPHODJMOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x709EF00", Offset = "0x709D700", VA = "0x18709EF00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x709F620", Offset = "0x709DE20", VA = "0x18709F620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int GFACHGNHKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x709DA10", Offset = "0x709C210", VA = "0x18709DA10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x709D180", Offset = "0x709B980", VA = "0x18709D180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int KKIEHMMMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x709D4C0", Offset = "0x709BCC0", VA = "0x18709D4C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x709D350", Offset = "0x709BB50", VA = "0x18709D350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int BDOCOGMKBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x70A0D60", Offset = "0x709F560", VA = "0x1870A0D60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x709ED80", Offset = "0x709D580", VA = "0x18709ED80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int EADAHEEFCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x709EA40", Offset = "0x709D240", VA = "0x18709EA40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x709F190", Offset = "0x709D990", VA = "0x18709F190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int GILJGJPBDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x709D240", Offset = "0x709BA40", VA = "0x18709D240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x709D400", Offset = "0x709BC00", VA = "0x18709D400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int IBOGPNDCHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70A1EB0", Offset = "0x70A06B0", VA = "0x1870A1EB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x709E350", Offset = "0x709CB50", VA = "0x18709E350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int AAPOLJCEHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x709D7E0", Offset = "0x709BFE0", VA = "0x18709D7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x709EA90", Offset = "0x709D290", VA = "0x18709EA90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool CCPJOABHBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x709DBF0", Offset = "0x709C3F0", VA = "0x18709DBF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int ADCNLPNJJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x709E640", Offset = "0x709CE40", VA = "0x18709E640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x709F1F0", Offset = "0x709D9F0", VA = "0x18709F1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int ONMMMAMEIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x709D790", Offset = "0x709BF90", VA = "0x18709D790")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70A0FE0", Offset = "0x709F7E0", VA = "0x1870A0FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int AJEENCCCFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x709EC10", Offset = "0x709D410", VA = "0x18709EC10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x709E1D0", Offset = "0x709C9D0", VA = "0x18709E1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool MIDEEDHIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x709D680", Offset = "0x709BE80", VA = "0x18709D680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x70A0CA0", Offset = "0x709F4A0", VA = "0x1870A0CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float PALLGANIFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x70A0ED0", Offset = "0x709F6D0", VA = "0x1870A0ED0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x709E3B0", Offset = "0x709CBB0", VA = "0x18709E3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static bool DKEELDHDKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x70A0B90", Offset = "0x709F390", VA = "0x1870A0B90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x70A0A10", Offset = "0x709F210", VA = "0x1870A0A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool CBOMIOJNBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x709D290", Offset = "0x709BA90", VA = "0x18709D290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x709DE50", Offset = "0x709C650", VA = "0x18709DE50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static DMPCPCGNCJA ENICAOONFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x709E740", Offset = "0x709CF40", VA = "0x18709E740")]
		[CompilerGenerated]
		get
		{
			return default(DMPCPCGNCJA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x70A0DB0", Offset = "0x709F5B0", VA = "0x1870A0DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool JBKAJPOJFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x709E530", Offset = "0x709CD30", VA = "0x18709E530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x709F010", Offset = "0x709D810", VA = "0x18709F010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool LOOCEKKEGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x709F250", Offset = "0x709DA50", VA = "0x18709F250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x70A1E50", Offset = "0x70A0650", VA = "0x1870A1E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static bool CHGBCDCHFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x709E980", Offset = "0x709D180", VA = "0x18709E980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x70A1CC0", Offset = "0x70A04C0", VA = "0x1870A1CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int FJAEEOIPJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x709D9B0", Offset = "0x709C1B0", VA = "0x18709D9B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x70A0D00", Offset = "0x709F500", VA = "0x1870A0D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int PMIPPLHICGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x709F4A0", Offset = "0x709DCA0", VA = "0x18709F4A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x70A0950", Offset = "0x709F150", VA = "0x1870A0950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int DICNHBMHDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x709E050", Offset = "0x709C850", VA = "0x18709E050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x709DDF0", Offset = "0x709C5F0", VA = "0x18709DDF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int MOBPNDGNLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x709D8F0", Offset = "0x709C0F0", VA = "0x18709D8F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x709EBB0", Offset = "0x709D3B0", VA = "0x18709EBB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int IPDGCNABAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x709E920", Offset = "0x709D120", VA = "0x18709E920")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x709F500", Offset = "0x709DD00", VA = "0x18709F500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int CAEFMMJAENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x70A1DF0", Offset = "0x70A05F0", VA = "0x1870A1DF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x709D000", Offset = "0x709B800", VA = "0x18709D000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static int JLDNDKIIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x709E0B0", Offset = "0x709C8B0", VA = "0x18709E0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x709E470", Offset = "0x709CC70", VA = "0x18709E470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static int NGBCNAJFFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x70A09B0", Offset = "0x709F1B0", VA = "0x1870A09B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x709E6E0", Offset = "0x709CEE0", VA = "0x18709E6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float KIHOGFJOEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x709F310", Offset = "0x709DB10", VA = "0x18709F310")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x709D060", Offset = "0x709B860", VA = "0x18709D060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float LMAENKKJIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x709D730", Offset = "0x709BF30", VA = "0x18709D730")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x709E860", Offset = "0x709D060", VA = "0x18709E860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static float MFJIBDCFDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x709F560", Offset = "0x709DD60", VA = "0x18709F560")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x709E7A0", Offset = "0x709CFA0", VA = "0x18709E7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int BHJKJNFMNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x70A0E10", Offset = "0x709F610", VA = "0x1870A0E10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x709EE40", Offset = "0x709D640", VA = "0x18709EE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int JPHEBJHKNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x709DFF0", Offset = "0x709C7F0", VA = "0x18709DFF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x709D830", Offset = "0x709C030", VA = "0x18709D830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int LOCNFFFMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x709CF50", Offset = "0x709B750", VA = "0x18709CF50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x70A1100", Offset = "0x709F900", VA = "0x1870A1100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int KKHICMGEEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x709E8C0", Offset = "0x709D0C0", VA = "0x18709E8C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x70A0F20", Offset = "0x709F720", VA = "0x1870A0F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static bool CMJMMGDLMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x709D950", Offset = "0x709C150", VA = "0x18709D950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x709DCF0", Offset = "0x709C4F0", VA = "0x18709DCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static HNCCAHDOEEL JMOMGEBMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x709DA60", Offset = "0x709C260", VA = "0x18709DA60")]
		[CompilerGenerated]
		get
		{
			return default(HNCCAHDOEEL);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x709DC90", Offset = "0x709C490", VA = "0x18709DC90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static EBNGKGIPBCD LMELBHFINCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x70A08F0", Offset = "0x709F0F0", VA = "0x1870A08F0")]
		[CompilerGenerated]
		get
		{
			return default(EBNGKGIPBCD);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x709EC60", Offset = "0x709D460", VA = "0x18709EC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static bool DNJHLFKGBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x709E9E0", Offset = "0x709D1E0", VA = "0x18709E9E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x709E2F0", Offset = "0x709CAF0", VA = "0x18709E2F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float FLEAMEKMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x70A1040", Offset = "0x709F840", VA = "0x1870A1040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x709ECC0", Offset = "0x709D4C0", VA = "0x18709ECC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float PHMEHLPHGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x709D2F0", Offset = "0x709BAF0", VA = "0x18709D2F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x709ED20", Offset = "0x709D520", VA = "0x18709ED20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float JOHGMKNGNFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x70A0AD0", Offset = "0x709F2D0", VA = "0x1870A0AD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x70A1D20", Offset = "0x70A0520", VA = "0x1870A1D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float FMHHEBFOLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x70A0B30", Offset = "0x709F330", VA = "0x1870A0B30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x70A0C40", Offset = "0x709F440", VA = "0x1870A0C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static float KFGJFLIEODF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x70A0BE0", Offset = "0x709F3E0", VA = "0x1870A0BE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x709DB20", Offset = "0x709C320", VA = "0x18709DB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static float CCAOJOGAJME
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x709F130", Offset = "0x709D930", VA = "0x18709F130")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x709E290", Offset = "0x709CA90", VA = "0x18709E290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static bool LKLJGBKPIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x70A0F80", Offset = "0x709F780", VA = "0x1870A0F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x709EF50", Offset = "0x709D750", VA = "0x18709EF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float IBGLLKJLCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x70A0E70", Offset = "0x709F670", VA = "0x1870A0E70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x709F680", Offset = "0x709DE80", VA = "0x18709F680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static float JDHPJHLOGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x709D890", Offset = "0x709C090", VA = "0x18709D890")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x709D5C0", Offset = "0x709BDC0", VA = "0x18709D5C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static float DHOPKKMHDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x709E4D0", Offset = "0x709CCD0", VA = "0x18709E4D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x709E110", Offset = "0x709C910", VA = "0x18709E110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static int BJIEAPGFFBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x709F070", Offset = "0x709D870", VA = "0x18709F070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x709F0D0", Offset = "0x709D8D0", VA = "0x18709F0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static float AOCGOHGCGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x709D1E0", Offset = "0x709B9E0", VA = "0x18709D1E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static bool OKDLCCFKAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x709E800", Offset = "0x709D000", VA = "0x18709E800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x709DF90", Offset = "0x709C790", VA = "0x18709DF90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static int FBEPCIDIKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x709EEA0", Offset = "0x709D6A0", VA = "0x18709EEA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x70A10A0", Offset = "0x709F8A0", VA = "0x1870A10A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float AAHIJDKPGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x709D6D0", Offset = "0x709BED0", VA = "0x18709D6D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x709D620", Offset = "0x709BE20", VA = "0x18709D620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static float MPHPGAPHMBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x709EDE0", Offset = "0x709D5E0", VA = "0x18709EDE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x709DAC0", Offset = "0x709C2C0", VA = "0x18709DAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static bool JEMPMPDPCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x709E170", Offset = "0x709C970", VA = "0x18709E170")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x709DEB0", Offset = "0x709C6B0", VA = "0x18709DEB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static float NODGJIFPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x709D560", Offset = "0x709BD60", VA = "0x18709D560")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x709EFB0", Offset = "0x709D7B0", VA = "0x18709EFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static float4x4 NKJGCOPHOEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x709F420", Offset = "0x709DC20", VA = "0x18709F420")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x709DF10", Offset = "0x709C710", VA = "0x18709DF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static float3 NFAKKPMBAKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x709DB80", Offset = "0x709C380", VA = "0x18709DB80")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x70A1D80", Offset = "0x70A0580", VA = "0x1870A1D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static bool JOGALPHGCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x709EAF0", Offset = "0x709D2F0", VA = "0x18709EAF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x709D120", Offset = "0x709B920", VA = "0x18709D120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public static LAMIPKMGPHK GHPKENDEBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x709D460", Offset = "0x709BC60", VA = "0x18709D460")]
		[CompilerGenerated]
		get
		{
			return default(LAMIPKMGPHK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x709F5C0", Offset = "0x709DDC0", VA = "0x18709F5C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x709F6E0", Offset = "0x709DEE0", VA = "0x18709F6E0")]
	public static void MMPDEAMNKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x70A1160", Offset = "0x709F960", VA = "0x1870A1160")]
	public static void PEOKFKACOAN(OGIEIIJEMJA MOOOHBNLLDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class DBCIJFKMAKM
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private struct PALAONAPDFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public Vector3 CMIONGHAGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public Quaternion HMMDLPIJNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public float FBKOADJLGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Quaternion BKPNBPIDLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public float GPGIFOMEOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public float GABLFLOBGKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float DNOJECKBBDG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static List<PALAONAPDFB> KBGAIAADKII;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7098920", Offset = "0x7097120", VA = "0x187098920")]
	public static NativeList<JIKFLLDMDJN> AGBBOFHDCIG(HEPANMFIAGC FONMOIDIMHF)
	{
		return default(NativeList<JIKFLLDMDJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7099610", Offset = "0x7097E10", VA = "0x187099610")]
	private static bool PCMPIJKGHLA(int KKPBEBNOEKN, NativeList<JIKFLLDMDJN> HANDIANDCDI, List<PALAONAPDFB> BJFKGCNINJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7098EC0", Offset = "0x70976C0", VA = "0x187098EC0")]
	private static JIKFLLDMDJN FDAMBEDFIGC(int JAIJLDENOAK, List<PALAONAPDFB> BJFKGCNINJP)
	{
		return default(JIKFLLDMDJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7099040", Offset = "0x7097840", VA = "0x187099040")]
	private static JIKFLLDMDJN JIHLEJHHLAI(int JAIJLDENOAK, List<PALAONAPDFB> BJFKGCNINJP)
	{
		return default(JIKFLLDMDJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7099530", Offset = "0x7097D30", VA = "0x187099530")]
	private static JIKFLLDMDJN OMHAEMNMEPL(Vector3 BJACFEPLELN, Quaternion FCCAJAMDPOO, float EKHPIDKNFIF)
	{
		return default(JIKFLLDMDJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x709A4C0", Offset = "0x7098CC0", VA = "0x18709A4C0")]
	public static NativeList<JIKFLLDMDJN> POLPHIAOHDK(HEPANMFIAGC FONMOIDIMHF, float AGIDHGDBJPG)
	{
		return default(NativeList<JIKFLLDMDJN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HPHMGGJLCGJ
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public static Vector3 ICBNDOIBIAK;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public static Vector3 KNLOACFGGCN;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public static readonly float IGMJGJJEKAC;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x709C420", Offset = "0x709AC20", VA = "0x18709C420")]
	public static Vector3 JADDPGNJCJN(Vector3 BBLAHDIIDAM, Quaternion FCCAJAMDPOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x709BF50", Offset = "0x709A750", VA = "0x18709BF50")]
	public static Vector3 IAFOCKHHHGP(Quaternion OJEGGOKKPLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x709CD10", Offset = "0x709B510", VA = "0x18709CD10")]
	public static Vector3 NLNLGJDDFOC(Quaternion OJEGGOKKPLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x709BED0", Offset = "0x709A6D0", VA = "0x18709BED0")]
	public static Quaternion DGJIIAPDHFB(Vector3 NGBCGJCGHJG, Vector3 LHHMNOGMEMF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x709CB20", Offset = "0x709B320", VA = "0x18709CB20")]
	public static Vector3 NHHGIOBLBOB(Vector3 LMFMLGPKMEM, Vector3 FFHPENGKKIK, Vector3 LHHMNOGMEMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x709BFF0", Offset = "0x709A7F0", VA = "0x18709BFF0")]
	public static Vector3 ILNOBEGIOJK(Vector3 BBLAHDIIDAM, Vector3 LHHMNOGMEMF, Quaternion OJEGGOKKPLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x709BB70", Offset = "0x709A370", VA = "0x18709BB70")]
	public static Quaternion BFOBPBLNKKM(Quaternion FCCAJAMDPOO, Vector3 NGBCGJCGHJG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x709C6B0", Offset = "0x709AEB0", VA = "0x18709C6B0")]
	public static bool JFMOLIJENLE(Vector3 EDJOLFMHBBE, Vector3 JBJDMCDEHJJ, [Out] Vector3 FKLEHDCHMOI, bool KIDNCAGGDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x709C830", Offset = "0x709B030", VA = "0x18709C830")]
	public static Vector3 KGHJGJIIDCF(bool CIFIGAEKIFF, [Optional] Quaternion KOIAJLBCILA)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JIKFLLDMDJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public float3 CMIONGHAGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public float3x3 HMMDLPIJNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public float FBKOADJLGDC;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HEPANMFIAGC
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int FKJMGEKDHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DOMCPIAFOKH(int JAIJLDENOAK);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion GBGJMOGCPCA(int JAIJLDENOAK);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float HEBDBJNOJBA(int JAIJLDENOAK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NLIBAEJGLLA : LHBMJJFFGPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool JOFHHNPMFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool JBNHJIPHILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float NEAEOFGNNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int IDNLPJCNKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool MODNBNPAKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	int NLJPDNGHIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JIKFLLDMDJN> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FNFGIGIJDCM : LHBMJJFFGPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	LMLJLLLHEEP JOFNHCCGGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool AMBCAMEPBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 KOIONMJJJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PEOKLHNBNLK
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	IGANFMNEEBA KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	NFLFIOOFEKC GKJLFFIHBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LHBMJJFFGPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool FNEHAEHCFND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool AJEDMAOPKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IGANFMNEEBA KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	UniformTRS HHJBLBGHLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float FMMGFCJAKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Vector3 CJGLICHMOGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	CEBKHCOPPLM GGKODAFCHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	PJFDOHDFBLL OOBOANNMEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ECDJJGJNIOF
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int CAKEELPNJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform CGKOIOMOPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool BIBJODPOJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HIOFIBKKFLJ GetBone(int JAIJLDENOAK);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int JAIJLDENOAK);
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
