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
public enum ODNLJJDPIGA
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
public enum OIBFOBLKIEF
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
public enum HBHCPBBAHPJ
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
public enum MFHFLMFFIDC
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
public enum EFBDBKLCEKO
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
public enum JNMGAPGEGHB
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
public static class MEBEMOGNBCL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8FC0", Offset = "0x6EE83C0", VA = "0x186EE8FC0")]
	public static bool KFDKPDOAFHG(this JNMGAPGEGHB PGJEJNDNNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8F80", Offset = "0x6EE8380", VA = "0x186EE8F80")]
	public static bool AEGLONGPOME(this JNMGAPGEGHB PGJEJNDNNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8F90", Offset = "0x6EE8390", VA = "0x186EE8F90")]
	public static bool KCNJONNKNCB(this JNMGAPGEGHB PGJEJNDNNOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HHBCGPJFJDH
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
public struct BAKMCDKPJKD : NLGMFENKCMI, IEquatable<BAKMCDKPJKD>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int KMIIBMECGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int GPEGCFLKPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27EB090", Offset = "0x27EA490", VA = "0x1827EB090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6183F60", Offset = "0x6183360", VA = "0x186183F60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CPKPPJFCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3750", Offset = "0x6EE2B50", VA = "0x186EE3750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x211E700", Offset = "0x211DB00", VA = "0x18211E700", Slot = "8")]
	public bool Equals(BAKMCDKPJKD KNLMODPGFOA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BF20", Offset = "0x6D8B320", VA = "0x186D8BF20")]
	public static bool CJIGOGHINMG(BAKMCDKPJKD NIPIGODEADI, BAKMCDKPJKD BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE36B0", Offset = "0x6EE2AB0", VA = "0x186EE36B0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3790", Offset = "0x6EE2B90", VA = "0x186EE3790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JDAFJJMIEGP : NLGMFENKCMI, IEquatable<JDAFJJMIEGP>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int KMIIBMECGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int GPEGCFLKPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x27EB090", Offset = "0x27EA490", VA = "0x1827EB090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6183F60", Offset = "0x6183360", VA = "0x186183F60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CPKPPJFCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8EB0", Offset = "0x6EE82B0", VA = "0x186EE8EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x211E700", Offset = "0x211DB00", VA = "0x18211E700", Slot = "8")]
	public bool Equals(JDAFJJMIEGP KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8E10", Offset = "0x6EE8210", VA = "0x186EE8E10", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8EF0", Offset = "0x6EE82F0", VA = "0x186EE8EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GGECCBMNKGC : NLGMFENKCMI, IEquatable<GGECCBMNKGC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KMIIBMECGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GPEGCFLKPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x27EB090", Offset = "0x27EA490", VA = "0x1827EB090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6183F60", Offset = "0x6183360", VA = "0x186183F60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CPKPPJFCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4BC0", Offset = "0x6EE3FC0", VA = "0x186EE4BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x211E700", Offset = "0x211DB00", VA = "0x18211E700", Slot = "8")]
	public bool Equals(GGECCBMNKGC KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4B20", Offset = "0x6EE3F20", VA = "0x186EE4B20", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DGKCKMLIMME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMKOEBLNMPM(BAKMCDKPJKD KCFGMPGPMFA, OIBFOBLKIEF HOJKJKJCBGO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMKOEBLNMPM(JDAFJJMIEGP GPIPGIMFHKC, OIBFOBLKIEF HOJKJKJCBGO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLGJBACJHBE(JDAFJJMIEGP GPIPGIMFHKC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PGEAPPOEJBK(JDAFJJMIEGP GPIPGIMFHKC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNIGLEOEEFI();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HPDLODEANBE(OIBFOBLKIEF DPOLEDLIAMP);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JILHBEAPPGK(BAKMCDKPJKD KCFGMPGPMFA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JILHBEAPPGK(JDAFJJMIEGP GPIPGIMFHKC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MAHIIMINDJD(JDAFJJMIEGP GPIPGIMFHKC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JJODKKLPPPB(JDAFJJMIEGP GPIPGIMFHKC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PPHAPJLBIHM();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BDJEDDIGPKB();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GFAGJBGEBMB(BAKMCDKPJKD KCFGMPGPMFA, EFBDBKLCEKO DPOLEDLIAMP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CJEEDLKAJOL(JDAFJJMIEGP GPIPGIMFHKC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JOIJGECHHHB(JDAFJJMIEGP GPIPGIMFHKC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OAFJLDAOCPP();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DLKFOECMPEL(EFBDBKLCEKO DPOLEDLIAMP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OCFEGBNOOLF(BAKMCDKPJKD KCFGMPGPMFA, Vector3 LGPJEDOHPNL, Vector3 KALMBLMDCEP, Vector3 ELNALGCGNBD, float BGODKDIDOMB, float ODCFPAJGONM, IReadOnlyList<Camera> JCOAEMJIAFM, ODNLJJDPIGA LNLNIIGEJOD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OCFEGBNOOLF(GGECCBMNKGC CALBJNLCMDF, Vector3 LGPJEDOHPNL, Vector3 KALMBLMDCEP, Vector3 ELNALGCGNBD, float BGODKDIDOMB, float ODCFPAJGONM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FAKHKPGPLLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JIMDLOFEJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAKMCDKPJKD CBKCCHOKNLO(OCMLOENOBHK AIKOCCMKKAE);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BAKMCDKPJKD CBKCCHOKNLO(OCMLOENOBHK AIKOCCMKKAE, bool PDIHDLENNIF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFDPBBCBNCB(BAKMCDKPJKD KCFGMPGPMFA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOBCPKFBOCF(BAKMCDKPJKD KCFGMPGPMFA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JDAFJJMIEGP CLIIMFEJEAC(BAKMCDKPJKD KCFGMPGPMFA, AMFBHDLIEIN AIKOCCMKKAE);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JDAFJJMIEGP OKBIINMDCKA(BAKMCDKPJKD KCFGMPGPMFA, HDMNJKJGCNO AIKOCCMKKAE);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PHNJDGLCCLO(JDAFJJMIEGP GPIPGIMFHKC);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MCEDICMHJHN(JDAFJJMIEGP GPIPGIMFHKC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GGECCBMNKGC MDFGKCALLAB(LJADMDAHMAM AIKOCCMKKAE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GAKALOJAABE(GGECCBMNKGC CALBJNLCMDF);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HOPDPACNDDO(GGECCBMNKGC CALBJNLCMDF);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task EOFGFDKEDJA();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task KDLLGLFECJG();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task IOEECEGJBEN();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DGBCBOBOHAA();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> PMNKCFMGMFL(BAKMCDKPJKD KCFGMPGPMFA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HCMHKBDBCKO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum NJCNFCKMLNO
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
	public enum BCHJPDNOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum APMJCPKELHD
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
	public enum EPCIMJLKEEM
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
	public enum IFMOMGEIKMN
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
	public enum ECIEFLPFFED
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
	public static int HGDACCCBBBD;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static int FALNALDKGMG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static int HDJGPEHPBOK;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static int JJOJELMMFPD;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static int[] HPBNPKHPMMD;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static int MKPGKIMOADF;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static int ADIGMGHBOBF;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static int DNMDIIKAPMB;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static int BENOGIBBMGE;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long LGGHPDJKIPK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long PEOIMGDCHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static long DDJMLNKHMEJ;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static long HFLGFGOMNOL;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static long FPNNKCENOMF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long FEJEDEIPHKK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long KJDJJKILLGA;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static long NMECKKGHDLE;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long CDMOMMKCGPL;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static long CLPILDIKMKH;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static long LHOMDFKJBBC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static long HNIGLCDCILL;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static long IIIEHBAPLDD;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static long LECAGBFKLPD;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static float DOOBLJBKAII;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long JFLJGEJAOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static long CIIMKCCIIPO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static long EGAHEKPBOEN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static long GCDJKKCIGIB;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float KPIALBDJBOP;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static long JIINEIAHHNB;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static long LIMKDPKJIKK;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long KBMMIKBBCAJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long KFDMCFIFODF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long AKHIEEHEECF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool OEEACKNFIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6EA0", Offset = "0x6EE62A0", VA = "0x186EE6EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5A00", Offset = "0x6EE4E00", VA = "0x186EE5A00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static ECIEFLPFFED LFPLGKIGDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7D60", Offset = "0x6EE7160", VA = "0x186EE7D60")]
		[CompilerGenerated]
		get
		{
			return default(ECIEFLPFFED);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6EE86B0", Offset = "0x6EE7AB0", VA = "0x186EE86B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool LOKLNNMHBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6F50", Offset = "0x6EE6350", VA = "0x186EE6F50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8140", Offset = "0x6EE7540", VA = "0x186EE8140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool MFNDGEPNNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5D40", Offset = "0x6EE5140", VA = "0x186EE5D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6EF0", Offset = "0x6EE62F0", VA = "0x186EE6EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static NJCNFCKMLNO GMEOGGMGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE84B0", Offset = "0x6EE78B0", VA = "0x186EE84B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool DAKEFCHDMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7BB0", Offset = "0x6EE6FB0", VA = "0x186EE7BB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8200", Offset = "0x6EE7600", VA = "0x186EE8200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static BCHJPDNOHKN DHJNNIEEHML
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7E00", Offset = "0x6EE7200", VA = "0x186EE7E00")]
		[CompilerGenerated]
		get
		{
			return default(BCHJPDNOHKN);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7EA0", Offset = "0x6EE72A0", VA = "0x186EE7EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool DEOPDDIKDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EE85A0", Offset = "0x6EE79A0", VA = "0x186EE85A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7FF0", Offset = "0x6EE73F0", VA = "0x186EE7FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool FBMPGHFPKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5810", Offset = "0x6EE4C10", VA = "0x186EE5810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4CB0", Offset = "0x6EE40B0", VA = "0x186EE4CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool HIBKPPPLHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6EE56C0", Offset = "0x6EE4AC0", VA = "0x186EE56C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7AF0", Offset = "0x6EE6EF0", VA = "0x186EE7AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static float IBFNCBEHPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5CF0", Offset = "0x6EE50F0", VA = "0x186EE5CF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6EE81A0", Offset = "0x6EE75A0", VA = "0x186EE81A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int DPKEBNGFIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6D40", Offset = "0x6EE6140", VA = "0x186EE6D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6E50", Offset = "0x6EE6250", VA = "0x186EE6E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int ABIFBDHFBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8400", Offset = "0x6EE7800", VA = "0x186EE8400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7900", Offset = "0x6EE6D00", VA = "0x186EE7900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int BNFGJBPOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5B00", Offset = "0x6EE4F00", VA = "0x186EE5B00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7040", Offset = "0x6EE6440", VA = "0x186EE7040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int LKBMABBNMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7270", Offset = "0x6EE6670", VA = "0x186EE7270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5710", Offset = "0x6EE4B10", VA = "0x186EE5710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int MJEHJIHDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4C60", Offset = "0x6EE4060", VA = "0x186EE4C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4D60", Offset = "0x6EE4160", VA = "0x186EE4D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int BNNMJJBLAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6EE57C0", Offset = "0x6EE4BC0", VA = "0x186EE57C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6FA0", Offset = "0x6EE63A0", VA = "0x186EE6FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static float CMFBIMGCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8550", Offset = "0x6EE7950", VA = "0x186EE8550")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4C00", Offset = "0x6EE4000", VA = "0x186EE4C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int OOFAJHPIJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6EE79B0", Offset = "0x6EE6DB0", VA = "0x186EE79B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6EE76C0", Offset = "0x6EE6AC0", VA = "0x186EE76C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int MMDKFBHNMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8260", Offset = "0x6EE7660", VA = "0x186EE8260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7670", Offset = "0x6EE6A70", VA = "0x186EE7670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int EOHHFGJDCMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7C60", Offset = "0x6EE7060", VA = "0x186EE7C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7620", Offset = "0x6EE6A20", VA = "0x186EE7620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static float HBOELLHOLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7850", Offset = "0x6EE6C50", VA = "0x186EE7850")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7950", Offset = "0x6EE6D50", VA = "0x186EE7950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float BGFOCDDLOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5DF0", Offset = "0x6EE51F0", VA = "0x186EE5DF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5C40", Offset = "0x6EE5040", VA = "0x186EE5C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float HJNLHMAKDIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7090", Offset = "0x6EE6490", VA = "0x186EE7090")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EE77F0", Offset = "0x6EE6BF0", VA = "0x186EE77F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool PFDGKMAJIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5A50", Offset = "0x6EE4E50", VA = "0x186EE5A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8350", Offset = "0x6EE7750", VA = "0x186EE8350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static int LMEGDBNIECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6EE80F0", Offset = "0x6EE74F0", VA = "0x186EE80F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7570", Offset = "0x6EE6970", VA = "0x186EE7570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static int GMMFFHJJANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6EE58C0", Offset = "0x6EE4CC0", VA = "0x186EE58C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7FA0", Offset = "0x6EE73A0", VA = "0x186EE7FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static int AAECKKNOOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6EE80A0", Offset = "0x6EE74A0", VA = "0x186EE80A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7310", Offset = "0x6EE6710", VA = "0x186EE7310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int JEAGOLGNKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8050", Offset = "0x6EE7450", VA = "0x186EE8050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7470", Offset = "0x6EE6870", VA = "0x186EE7470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static bool ANBHFFPPBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7220", Offset = "0x6EE6620", VA = "0x186EE7220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7D00", Offset = "0x6EE7100", VA = "0x186EE7D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static bool DMAIJMALLND
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6FF0", Offset = "0x6EE63F0", VA = "0x186EE6FF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5860", Offset = "0x6EE4C60", VA = "0x186EE5860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float GHLCOMKGEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5960", Offset = "0x6EE4D60", VA = "0x186EE5960")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6C80", Offset = "0x6EE6080", VA = "0x186EE6C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static APMJCPKELHD GNNHACAMMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8500", Offset = "0x6EE7900", VA = "0x186EE8500")]
		[CompilerGenerated]
		get
		{
			return default(APMJCPKELHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5E40", Offset = "0x6EE5240", VA = "0x186EE5E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static EPCIMJLKEEM MEEFODMBLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6EE74C0", Offset = "0x6EE68C0", VA = "0x186EE74C0")]
		[CompilerGenerated]
		get
		{
			return default(EPCIMJLKEEM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7AA0", Offset = "0x6EE6EA0", VA = "0x186EE7AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool NCHKACNOLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5CA0", Offset = "0x6EE50A0", VA = "0x186EE5CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5760", Offset = "0x6EE4B60", VA = "0x186EE5760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float HCOEJEOGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6EE72C0", Offset = "0x6EE66C0", VA = "0x186EE72C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5AA0", Offset = "0x6EE4EA0", VA = "0x186EE5AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float ELAJMGAKIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE73C0", Offset = "0x6EE67C0", VA = "0x186EE73C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8650", Offset = "0x6EE7A50", VA = "0x186EE8650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float OGECHFAFGED
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7DB0", Offset = "0x6EE71B0", VA = "0x186EE7DB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8700", Offset = "0x6EE7B00", VA = "0x186EE8700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float OGDFCGBNGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7EF0", Offset = "0x6EE72F0", VA = "0x186EE7EF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7360", Offset = "0x6EE6760", VA = "0x186EE7360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static float JHOMIDHDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7CB0", Offset = "0x6EE70B0", VA = "0x186EE7CB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7C00", Offset = "0x6EE7000", VA = "0x186EE7C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static float AOEHHIOANDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6EE83B0", Offset = "0x6EE77B0", VA = "0x186EE83B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6EE85F0", Offset = "0x6EE79F0", VA = "0x186EE85F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool LNMPIPLGGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4D10", Offset = "0x6EE4110", VA = "0x186EE4D10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5D90", Offset = "0x6EE5190", VA = "0x186EE5D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static float JBGIABGOMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6EE82B0", Offset = "0x6EE76B0", VA = "0x186EE82B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6C20", Offset = "0x6EE6020", VA = "0x186EE6C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int MPNGPAFEECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8300", Offset = "0x6EE7700", VA = "0x186EE8300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6DF0", Offset = "0x6EE61F0", VA = "0x186EE6DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static int OGEPAPDPPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE70E0", Offset = "0x6EE64E0", VA = "0x186EE70E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7410", Offset = "0x6EE6810", VA = "0x186EE7410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool BMLPNODPJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7A50", Offset = "0x6EE6E50", VA = "0x186EE7A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static int JNAAGMEKDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE71D0", Offset = "0x6EE65D0", VA = "0x186EE71D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7F40", Offset = "0x6EE7340", VA = "0x186EE7F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static int AHNIOHMMCKK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7B50", Offset = "0x6EE6F50", VA = "0x186EE7B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool OMGFHIPADHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5910", Offset = "0x6EE4D10", VA = "0x186EE5910")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4DB0", Offset = "0x6EE41B0", VA = "0x186EE4DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float LFACHPAADKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE59B0", Offset = "0x6EE4DB0", VA = "0x186EE59B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6D90", Offset = "0x6EE6190", VA = "0x186EE6D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float NKGJMJKPJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8760", Offset = "0x6EE7B60", VA = "0x186EE8760")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7510", Offset = "0x6EE6910", VA = "0x186EE7510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float GBPEBDCPCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7E50", Offset = "0x6EE7250", VA = "0x186EE7E50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6CE0", Offset = "0x6EE60E0", VA = "0x186EE6CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static int LLOIPBMGFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7130", Offset = "0x6EE6530", VA = "0x186EE7130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE78A0", Offset = "0x6EE6CA0", VA = "0x186EE78A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static float4x4 KELMAOHDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7710", Offset = "0x6EE6B10", VA = "0x186EE7710")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5B50", Offset = "0x6EE4F50", VA = "0x186EE5B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float3 GFJFBMCFLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5BD0", Offset = "0x6EE4FD0", VA = "0x186EE5BD0")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7790", Offset = "0x6EE6B90", VA = "0x186EE7790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static bool FNCFCEFIBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7180", Offset = "0x6EE6580", VA = "0x186EE7180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8450", Offset = "0x6EE7850", VA = "0x186EE8450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static IFMOMGEIKMN LMGDLKCABKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7A00", Offset = "0x6EE6E00", VA = "0x186EE7A00")]
		[CompilerGenerated]
		get
		{
			return default(IFMOMGEIKMN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE75C0", Offset = "0x6EE69C0", VA = "0x186EE75C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5E90", Offset = "0x6EE5290", VA = "0x186EE5E90")]
	public static void EMNJCNLOKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4E10", Offset = "0x6EE4210", VA = "0x186EE4E10")]
	public static void ANCMBNODNHE(ECIEFLPFFED ILODPPPLFJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NIJDMIBOAIC
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct EECCOODIBED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Vector3 DPFKDMMBOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Quaternion HOGDMCNOLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float NPDODIJAKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public Quaternion FOOCCAEONAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public float FEMAHJNMJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float GCKDOGGLBPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float KBGGFCDMAGM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static List<EECCOODIBED> PBNPCGHIDOF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6EEAA60", Offset = "0x6EE9E60", VA = "0x186EEAA60")]
	public static NativeList<JCEELACLMMK> KEEJCLNFCCB(CAAKIDFMCNL KLONIJLMOHB)
	{
		return default(NativeList<JCEELACLMMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB000", Offset = "0x6EEA400", VA = "0x186EEB000")]
	private static bool OEDFGAHEAFC(int PGOOPNPHNCA, NativeList<JCEELACLMMK> IPNDOKDOGDG, List<EECCOODIBED> EKEGLNNIFMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6EEBE90", Offset = "0x6EEB290", VA = "0x186EEBE90")]
	private static JCEELACLMMK OJFCBDGNMBN(int JJOEPDKNLJF, List<EECCOODIBED> EKEGLNNIFMJ)
	{
		return default(JCEELACLMMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8FE0", Offset = "0x6EE83E0", VA = "0x186EE8FE0")]
	private static JCEELACLMMK AIKHFIGDGGB(int JJOEPDKNLJF, List<EECCOODIBED> EKEGLNNIFMJ)
	{
		return default(JCEELACLMMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6EE94D0", Offset = "0x6EE88D0", VA = "0x186EE94D0")]
	private static JCEELACLMMK FLCDJIACBHD(Vector3 GOGKCFACHGD, Quaternion JKEFKNOEELB, float CBOFEOAGGML)
	{
		return default(JCEELACLMMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6EE95B0", Offset = "0x6EE89B0", VA = "0x186EE95B0")]
	public static NativeList<JCEELACLMMK> IMLBBADLEIJ(CAAKIDFMCNL KLONIJLMOHB, float GBDKNCFAJKC)
	{
		return default(NativeList<JCEELACLMMK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ELDHIEPAJNM
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static Vector3 IOBACBKIFLI;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static Vector3 HLCMFDGAGDK;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public static readonly float BDLKFPHFBOE;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3E10", Offset = "0x6EE3210", VA = "0x186EE3E10")]
	public static Vector3 IAKOCHACBKN(Vector3 PDPBLBGKPKJ, Quaternion JKEFKNOEELB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4090", Offset = "0x6EE3490", VA = "0x186EE4090")]
	public static Vector3 LGKABNHBAMJ(Quaternion MDJOMEFJFHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3B80", Offset = "0x6EE2F80", VA = "0x186EE3B80")]
	public static Vector3 BOLJJDHEDOP(Quaternion MDJOMEFJFHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6EE45A0", Offset = "0x6EE39A0", VA = "0x186EE45A0")]
	public static Quaternion OJCCLJIJKCL(Vector3 PAAGAJJEHGO, Vector3 KENGOPLODLD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3C20", Offset = "0x6EE3020", VA = "0x186EE3C20")]
	public static Vector3 FGLLFJIJMBO(Vector3 AILEMENHKFB, Vector3 CHKHBFGMIHF, Vector3 KENGOPLODLD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4620", Offset = "0x6EE3A20", VA = "0x186EE4620")]
	public static Vector3 PJPBENIFBPC(Vector3 PDPBLBGKPKJ, Vector3 KENGOPLODLD, Quaternion MDJOMEFJFHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3820", Offset = "0x6EE2C20", VA = "0x186EE3820")]
	public static Quaternion BJONDPMGCFD(Quaternion JKEFKNOEELB, Vector3 PAAGAJJEHGO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4130", Offset = "0x6EE3530", VA = "0x186EE4130")]
	public static bool NOELJPIELJP(Vector3 DDIJFFGIMOL, Vector3 GEHPPAAEILM, [Out] Vector3 NEOICEEMOHM, bool NDAIEBNOODF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6EE42B0", Offset = "0x6EE36B0", VA = "0x186EE42B0")]
	public static Vector3 NPMGAHCMDDC(bool JOKKFLOFOPO, [Optional] Quaternion CFBNKBKIBKJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JCEELACLMMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float3 DPFKDMMBOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public float3x3 HOGDMCNOLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public float NPDODIJAKEH;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CAAKIDFMCNL
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int BLAEDBBFCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 IKFFMNKDIPE(int JJOEPDKNLJF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion NABGFMKKHMJ(int JJOEPDKNLJF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float FIAOEHCEOID(int JJOEPDKNLJF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HDMNJKJGCNO : GAKOPJIBMEE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool MKBNJECKDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FEDECNFLALF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float ELOCBDGGFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int JFDHLANAFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DMGFFDIBHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int IFLMKGNJBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JCEELACLMMK> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AMFBHDLIEIN : GAKOPJIBMEE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	HBHCPBBAHPJ HANLMNGKFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool LDGLPNBMENH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float3 PMAILMGJJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OCMLOENOBHK
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	JGEJFGFHNHJ BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	MFHFLMFFIDC GKKHBLNNHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GAKOPJIBMEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool OPNANFFPIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool IMPNJNMPKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	JGEJFGFHNHJ BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	UniformTRS IEJCEOGEBLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float DKAEELFIOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 JMPDJDHFDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	JNMGAPGEGHB FKCHBLIGKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	HHBCGPJFJDH ONGINCLPCJD
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
public interface LJADMDAHMAM
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int FPDPCCLLPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Transform EHAMJIECHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool PJDPHEOJCAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BAKMCDKPJKD GetBone(int JJOEPDKNLJF);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int JJOEPDKNLJF);
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
