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
public enum OLHCOHMJOCC
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
public enum BLNKBACJIBE
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
public enum PKDHLEFJHBK
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
public enum EPEJAJNGNFC
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
public enum ODMGODNGJGC
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
public enum JJGANJGEFFL
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
public static class KOEHLAFOOHO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D790", Offset = "0x6D7C390", VA = "0x186D7D790")]
	public static bool GNKNNFPCOIJ(this JJGANJGEFFL NHMCIACLKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D780", Offset = "0x6D7C380", VA = "0x186D7D780")]
	public static bool GMJIONKJKMH(this JJGANJGEFFL NHMCIACLKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D750", Offset = "0x6D7C350", VA = "0x186D7D750")]
	public static bool EPJOLLLMPOB(this JJGANJGEFFL NHMCIACLKHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OICBHJLAMDI
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
public struct HOIMHHIKEDC : HLDDCBEIKDI, IEquatable<HOIMHHIKEDC>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int EJLEFLLIODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2746650", Offset = "0x2745250", VA = "0x182746650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5D80", Offset = "0x5FB4980", VA = "0x185FB5D80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OFMFOLKKKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D3C0", Offset = "0x6D7BFC0", VA = "0x186D7D3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2059FA0", Offset = "0x2058BA0", VA = "0x182059FA0", Slot = "8")]
	public bool Equals(HOIMHHIKEDC FDOEIPBMJJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2E70", Offset = "0x2EC1A70", VA = "0x182EC2E70")]
	public static bool PCHFOHOKDFG(HOIMHHIKEDC ALHLFNOAFIL, HOIMHHIKEDC AFHCIMLJCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D400", Offset = "0x6D7C000", VA = "0x186D7D400", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D490", Offset = "0x6D7C090", VA = "0x186D7D490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KFAONOJCCPI : HLDDCBEIKDI, IEquatable<KFAONOJCCPI>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int EJLEFLLIODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2746650", Offset = "0x2745250", VA = "0x182746650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5D80", Offset = "0x5FB4980", VA = "0x185FB5D80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OFMFOLKKKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D520", Offset = "0x6D7C120", VA = "0x186D7D520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2059FA0", Offset = "0x2058BA0", VA = "0x182059FA0", Slot = "8")]
	public bool Equals(KFAONOJCCPI FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D560", Offset = "0x6D7C160", VA = "0x186D7D560", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D5F0", Offset = "0x6D7C1F0", VA = "0x186D7D5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KKGDPLMDIPI : HLDDCBEIKDI, IEquatable<KKGDPLMDIPI>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EJLEFLLIODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2746650", Offset = "0x2745250", VA = "0x182746650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5D80", Offset = "0x5FB4980", VA = "0x185FB5D80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OFMFOLKKKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D680", Offset = "0x6D7C280", VA = "0x186D7D680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2059FA0", Offset = "0x2058BA0", VA = "0x182059FA0", Slot = "8")]
	public bool Equals(KKGDPLMDIPI FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D6C0", Offset = "0x6D7C2C0", VA = "0x186D7D6C0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IFIADOEPHCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBACCIGFECM(HOIMHHIKEDC AHFIDHNOIFE, BLNKBACJIBE PBAGHGLELNF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBACCIGFECM(KFAONOJCCPI HMAFPCMGLCM, BLNKBACJIBE PBAGHGLELNF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CODGFEEJBKF(KFAONOJCCPI HMAFPCMGLCM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IFGCHDCJNMJ(KFAONOJCCPI HMAFPCMGLCM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLBAMHHNCMI();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMHGCCGJOPG(BLNKBACJIBE FIFJJNIIAPF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BPNFHBFINBM(HOIMHHIKEDC AHFIDHNOIFE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BPNFHBFINBM(KFAONOJCCPI HMAFPCMGLCM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CKCBEBIGPNI(KFAONOJCCPI HMAFPCMGLCM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FBDKJCGAPGG(KFAONOJCCPI HMAFPCMGLCM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BNMHDHJIKHB();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LEIPKAGEKLF();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JJAMIHEBPII(HOIMHHIKEDC AHFIDHNOIFE, ODMGODNGJGC FIFJJNIIAPF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GMAFDBOADCB(KFAONOJCCPI HMAFPCMGLCM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LEBOBAJOILK(KFAONOJCCPI HMAFPCMGLCM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MHENNMHGGFJ();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PCMEABMAFJM(ODMGODNGJGC FIFJJNIIAPF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KJBBHKAPEEE(HOIMHHIKEDC AHFIDHNOIFE, Vector3 MHMCJEFLBCE, Vector3 OGEOFKLJLIO, Vector3 CPMCOPNHLMB, float CNPBDFJFKHO, float MJOLKKCIFEB, IReadOnlyList<Camera> NCAACGFPPLL, OLHCOHMJOCC MBHJGKJJEMC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KJBBHKAPEEE(KKGDPLMDIPI OMNMEBMDOFC, Vector3 MHMCJEFLBCE, Vector3 OGEOFKLJLIO, Vector3 CPMCOPNHLMB, float CNPBDFJFKHO, float MJOLKKCIFEB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LONHKCPEDHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IHNHCBANPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOIMHHIKEDC PEJDGHNGFPI(PLEFNFBHPPD BFLLAIFBMAJ);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOIMHHIKEDC PEJDGHNGFPI(PLEFNFBHPPD BFLLAIFBMAJ, bool LHHJNLODOFI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFMBCFJOHEE(HOIMHHIKEDC AHFIDHNOIFE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEONJHHMIDL(HOIMHHIKEDC AHFIDHNOIFE);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KFAONOJCCPI KIOCLGBNDCM(HOIMHHIKEDC AHFIDHNOIFE, FIFKKIMGIBH BFLLAIFBMAJ);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KFAONOJCCPI CMJAKKJMJAD(HOIMHHIKEDC AHFIDHNOIFE, GHIENMFCFMM BFLLAIFBMAJ);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCFLCIONDCJ(KFAONOJCCPI HMAFPCMGLCM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IMNNCDPBJIK(KFAONOJCCPI HMAFPCMGLCM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KKGDPLMDIPI HCAJGMPCLMO(HOFGPKBKKBF BFLLAIFBMAJ);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MIFJJMKPOCO(KKGDPLMDIPI OMNMEBMDOFC);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MBGPDHOPFFD(KKGDPLMDIPI OMNMEBMDOFC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task MEMOKIGLCBF();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task OFNKOAHJENM();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task PNOIDDCKHGB();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LKPLJAJBNGB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> KDJJJEMHEPD(HOIMHHIKEDC AHFIDHNOIFE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PEOIDDALACF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum NIPAIDDJHGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum EIABHPCOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum MOJNGGGOOII
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum FONMFIBOOGG
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum PFENFNGHEAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum EIOGOLPAELC
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Quest3,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		MemoryBuild,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		PS4VR,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static long CAKFJPDKNPJ;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool GEHMKIPOFPP;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static long DNNCKFDIMAE;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static int CCDOPODGINL;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long FDMBCGIGMHH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static long HDMEBBNMFOD;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static int BMLMJGAOJLN;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static bool LHKILPFEABC;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static long JGCPEKDHJPO;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static int EAJNGIAKEKJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static int BNIDELOPPMH;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static long FKNELAJIBAH;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static long JHPHMIJCBCL;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static int OEPMJJAHNIF;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static int MPCKBJEFBKJ;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int DEOKKGFFHMI;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int BMBMLNJKEPB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static int NDIJDDCEJGP;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static int[] HJCHBKKFDGH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static int FBNBFEBPFCF;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static long MCKHPMNKENC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long FFBJCJNDBHC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static int KDCFCJEBMMD;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long FOMGIGCEMFB;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static long JKAEMKLFPOF;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static long HNOKAJKKNEO;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static long HENLBEJPBOB;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static long LIODLPMJGEO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static long DLACPKIABBE;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long CFIBCOAGJNO;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static long BFPFIBBLPJE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static long FFOKDIJBFIK;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static float GJJFFBDINPD;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static long BEIFDLIEKAI;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static long FPJHLMFLNPO;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long HBDCBMPCFND;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static float KKHAIGEJAOD;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static long IJHHLIKPFBG;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static long OIOPCFBCEBP;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long GCGHMCEMMPK;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long PPOHPBGKIFF;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long BBDIELBCJNN;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long OKDLMPPOBCB;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long FDGINLOALPL;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static long FAJLDGGOJAG;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static long HJOCPMEOBDE;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static long DPFJCEGPEHC;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long DAKIKGKNDBO;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long GPIAOAFNCAO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool OIABBIPKEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D842C0", Offset = "0x6D82EC0", VA = "0x186D842C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D82010", Offset = "0x6D80C10", VA = "0x186D82010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static EIOGOLPAELC GLLCONJPMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D829B0", Offset = "0x6D815B0", VA = "0x186D829B0")]
		[CompilerGenerated]
		get
		{
			return default(EIOGOLPAELC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D822B0", Offset = "0x6D80EB0", VA = "0x186D822B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool PBPFEJOGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D80920", Offset = "0x6D7F520", VA = "0x186D80920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D84620", Offset = "0x6D83220", VA = "0x186D84620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool FJMNMPEHBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D84EB0", Offset = "0x6D83AB0", VA = "0x186D84EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D82420", Offset = "0x6D81020", VA = "0x186D82420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float FHFPEPNCNIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D84110", Offset = "0x6D82D10", VA = "0x186D84110")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D84C10", Offset = "0x6D83810", VA = "0x186D84C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float ELJMIBCKLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6D84E10", Offset = "0x6D83A10", VA = "0x186D84E10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D81840", Offset = "0x6D80440", VA = "0x186D81840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int EPLKJAOFBOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6D82060", Offset = "0x6D80C60", VA = "0x186D82060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D847D0", Offset = "0x6D833D0", VA = "0x186D847D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static PFENFNGHEAO DMFOHIAJKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D843C0", Offset = "0x6D82FC0", VA = "0x186D843C0")]
		[CompilerGenerated]
		get
		{
			return default(PFENFNGHEAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D82F20", Offset = "0x6D81B20", VA = "0x186D82F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long CIILNFHHBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D84DC0", Offset = "0x6D839C0", VA = "0x186D84DC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6D84560", Offset = "0x6D83160", VA = "0x186D84560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float GKNCJOLMHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D84FB0", Offset = "0x6D83BB0", VA = "0x186D84FB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6D84770", Offset = "0x6D83370", VA = "0x186D84770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int KNAMHMJHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D82730", Offset = "0x6D81330", VA = "0x186D82730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6D846D0", Offset = "0x6D832D0", VA = "0x186D846D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int NDGHMOKPEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D82260", Offset = "0x6D80E60", VA = "0x186D82260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D83F60", Offset = "0x6D82B60", VA = "0x186D83F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int GIKBLPMKEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D84E60", Offset = "0x6D83A60", VA = "0x186D84E60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D83FB0", Offset = "0x6D82BB0", VA = "0x186D83FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int KCJGFJIDHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D85120", Offset = "0x6D83D20", VA = "0x186D85120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D81D50", Offset = "0x6D80950", VA = "0x186D81D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int LLLJEFHLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D84160", Offset = "0x6D82D60", VA = "0x186D84160")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D844C0", Offset = "0x6D830C0", VA = "0x186D844C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static bool OHCOKFDKKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D84210", Offset = "0x6D82E10", VA = "0x186D84210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int DPIIGJHGHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D82ED0", Offset = "0x6D81AD0", VA = "0x186D82ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D82300", Offset = "0x6D80F00", VA = "0x186D82300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int COBJOBFEBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6D82C70", Offset = "0x6D81870", VA = "0x186D82C70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6D82350", Offset = "0x6D80F50", VA = "0x186D82350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int IECBJNFLJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6D82E80", Offset = "0x6D81A80", VA = "0x186D82E80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D828A0", Offset = "0x6D814A0", VA = "0x186D828A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static bool EJPBDDFMCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D848C0", Offset = "0x6D834C0", VA = "0x186D848C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D828F0", Offset = "0x6D814F0", VA = "0x186D828F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static float KBBKONBHCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6D84A20", Offset = "0x6D83620", VA = "0x186D84A20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6D825D0", Offset = "0x6D811D0", VA = "0x186D825D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool LPFJPLNAGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6D81740", Offset = "0x6D80340", VA = "0x186D81740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D82A50", Offset = "0x6D81650", VA = "0x186D82A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static bool KPANEHCEAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D82CC0", Offset = "0x6D818C0", VA = "0x186D82CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D80860", Offset = "0x6D7F460", VA = "0x186D80860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static NIPAIDDJHGK DIKOEAAJFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D84720", Offset = "0x6D83320", VA = "0x186D84720")]
		[CompilerGenerated]
		get
		{
			return default(NIPAIDDJHGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D84260", Offset = "0x6D82E60", VA = "0x186D84260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool BDJNHKJDKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D81CA0", Offset = "0x6D808A0", VA = "0x186D81CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D82B00", Offset = "0x6D81700", VA = "0x186D82B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool KKIBDAAEJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D827D0", Offset = "0x6D813D0", VA = "0x186D827D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6D81E00", Offset = "0x6D80A00", VA = "0x186D81E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool ALKODHGAKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D851D0", Offset = "0x6D83DD0", VA = "0x186D851D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6D81A20", Offset = "0x6D80620", VA = "0x186D81A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static int BFEADEOJNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D84870", Offset = "0x6D83470", VA = "0x186D84870")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6D82950", Offset = "0x6D81550", VA = "0x186D82950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int IEDPJFAGLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6D84680", Offset = "0x6D83280", VA = "0x186D84680")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6D84000", Offset = "0x6D82C00", VA = "0x186D84000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int CPEFJEMLHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D82AB0", Offset = "0x6D816B0", VA = "0x186D82AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D82160", Offset = "0x6D80D60", VA = "0x186D82160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int NENHMDGBCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D84310", Offset = "0x6D82F10", VA = "0x186D84310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D84460", Offset = "0x6D83060", VA = "0x186D84460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int EIFKLCOJMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D81790", Offset = "0x6D80390", VA = "0x186D81790")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D85170", Offset = "0x6D83D70", VA = "0x186D85170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int DJAMCODNEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D819D0", Offset = "0x6D805D0", VA = "0x186D819D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D845C0", Offset = "0x6D831C0", VA = "0x186D845C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int ICCKLNCAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D81F70", Offset = "0x6D80B70", VA = "0x186D81F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D85000", Offset = "0x6D83C00", VA = "0x186D85000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int HEOPGGLGBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D84B70", Offset = "0x6D83770", VA = "0x186D84B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6D84360", Offset = "0x6D82F60", VA = "0x186D84360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float FLOJPGNIEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6D84510", Offset = "0x6D83110", VA = "0x186D84510")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6D82C10", Offset = "0x6D81810", VA = "0x186D82C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float FOGKMIPDCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D84BC0", Offset = "0x6D837C0", VA = "0x186D84BC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6D81EB0", Offset = "0x6D80AB0", VA = "0x186D81EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float MILOINOHFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D82480", Offset = "0x6D81080", VA = "0x186D82480")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6D841B0", Offset = "0x6D82DB0", VA = "0x186D841B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static int NDNMIBLFBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D82A00", Offset = "0x6D81600", VA = "0x186D82A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D81B80", Offset = "0x6D80780", VA = "0x186D81B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int JENGPBAEDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D82780", Offset = "0x6D81380", VA = "0x186D82780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D81910", Offset = "0x6D80510", VA = "0x186D81910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int PFJNBODFAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6D82520", Offset = "0x6D81120", VA = "0x186D82520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6D84060", Offset = "0x6D82C60", VA = "0x186D84060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int OHIIOOCKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D81B30", Offset = "0x6D80730", VA = "0x186D81B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D817E0", Offset = "0x6D803E0", VA = "0x186D817E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static bool CFKEBNOOBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D84A70", Offset = "0x6D83670", VA = "0x186D84A70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6D84970", Offset = "0x6D83570", VA = "0x186D84970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static EIABHPCOOCM ECCFKPLLFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6D816F0", Offset = "0x6D802F0", VA = "0x186D816F0")]
		[CompilerGenerated]
		get
		{
			return default(EIABHPCOOCM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D81A80", Offset = "0x6D80680", VA = "0x186D81A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static MOJNGGGOOII MPEOBMDPEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D82630", Offset = "0x6D81230", VA = "0x186D82630")]
		[CompilerGenerated]
		get
		{
			return default(MOJNGGGOOII);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6D82B60", Offset = "0x6D81760", VA = "0x186D82B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool BEGOEBAPHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6D82210", Offset = "0x6D80E10", VA = "0x186D82210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6D84F00", Offset = "0x6D83B00", VA = "0x186D84F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static float OLIECBOFCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D84AC0", Offset = "0x6D836C0", VA = "0x186D84AC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6D81F10", Offset = "0x6D80B10", VA = "0x186D81F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static float DDOGBJCPIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D81E60", Offset = "0x6D80A60", VA = "0x186D81E60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D85060", Offset = "0x6D83C60", VA = "0x186D85060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float BOHIEPEIEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6D82BC0", Offset = "0x6D817C0", VA = "0x186D82BC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D82DD0", Offset = "0x6D819D0", VA = "0x186D82DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float IAOKOOMLIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D81AE0", Offset = "0x6D806E0", VA = "0x186D81AE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D81C40", Offset = "0x6D80840", VA = "0x186D81C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float KEGPAOCHOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D849D0", Offset = "0x6D835D0", VA = "0x186D849D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6D81970", Offset = "0x6D80570", VA = "0x186D81970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float JEMCKCHHNHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D840C0", Offset = "0x6D82CC0", VA = "0x186D840C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D826D0", Offset = "0x6D812D0", VA = "0x186D826D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static bool LNCDBGONIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D81FC0", Offset = "0x6D80BC0", VA = "0x186D81FC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6D81CF0", Offset = "0x6D808F0", VA = "0x186D81CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static float JCNPDOPEMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D84CC0", Offset = "0x6D838C0", VA = "0x186D84CC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D82100", Offset = "0x6D80D00", VA = "0x186D82100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float ALFIKHGHKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D84410", Offset = "0x6D83010", VA = "0x186D84410")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6D84D10", Offset = "0x6D83910", VA = "0x186D84D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float MIJEIGCMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6D84C70", Offset = "0x6D83870", VA = "0x186D84C70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6D81BE0", Offset = "0x6D807E0", VA = "0x186D81BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static int CFCMMEAGCMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6D84D70", Offset = "0x6D83970", VA = "0x186D84D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D82570", Offset = "0x6D81170", VA = "0x186D82570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static float INOEIAKIAON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D821C0", Offset = "0x6D80DC0", VA = "0x186D821C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static bool OFDALKAJLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D84F60", Offset = "0x6D83B60", VA = "0x186D84F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D84B10", Offset = "0x6D83710", VA = "0x186D84B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static int HKKJAKPAPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D82E30", Offset = "0x6D81A30", VA = "0x186D82E30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D84910", Offset = "0x6D83510", VA = "0x186D84910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static float HPOICPIPGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D824D0", Offset = "0x6D810D0", VA = "0x186D824D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D808C0", Offset = "0x6D7F4C0", VA = "0x186D808C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static float KJLKMPBIMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D820B0", Offset = "0x6D80CB0", VA = "0x186D820B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D82D70", Offset = "0x6D81970", VA = "0x186D82D70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float4x4 LNLHBMCIOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D823A0", Offset = "0x6D80FA0", VA = "0x186D823A0")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D82820", Offset = "0x6D81420", VA = "0x186D82820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static float3 EMLFOFPGGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D818A0", Offset = "0x6D804A0", VA = "0x186D818A0")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D81DA0", Offset = "0x6D809A0", VA = "0x186D81DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static bool JKIBPFLGCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D84820", Offset = "0x6D83420", VA = "0x186D84820")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D82D10", Offset = "0x6D81910", VA = "0x186D82D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static FONMFIBOOGG LLFDNAEGDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D82680", Offset = "0x6D81280", VA = "0x186D82680")]
		[CompilerGenerated]
		get
		{
			return default(FONMFIBOOGG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D850C0", Offset = "0x6D83CC0", VA = "0x186D850C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D82F70", Offset = "0x6D81B70", VA = "0x186D82F70")]
	public static void JBHCAGCOAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D80970", Offset = "0x6D7F570", VA = "0x186D80970")]
	public static void ADKFFFLINOL(EIOGOLPAELC JIJJALCDBBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OLFPHGGIKBG
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct KBGGODOCLGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Vector3 FIKECJKJAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Quaternion EDMDHCBPBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public float CGGKMNAGOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Quaternion KEAMHAMBEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public float HLFKIKFLNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public float LPCLGLMPGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public float AABOEPHCEHA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static List<KBGGODOCLGG> ABMLMGGNFLN;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D7DF00", Offset = "0x6D7CB00", VA = "0x186D7DF00")]
	public static NativeList<BKCAPMPDKDN> JEEGPBFOMII(CHOMKALJNDJ ODPJPJLEOIN)
	{
		return default(NativeList<BKCAPMPDKDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E4A0", Offset = "0x6D7D0A0", VA = "0x186D7E4A0")]
	private static bool JOAEACELPLM(int EKJHOCEPHIA, NativeList<BKCAPMPDKDN> CMNKPAFMHMO, List<KBGGODOCLGG> DMJLEDIMDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D7B0", Offset = "0x6D7C3B0", VA = "0x186D7D7B0")]
	private static BKCAPMPDKDN CPGKAHJKANA(int MCPGGPJAKIM, List<KBGGODOCLGG> DMJLEDIMDBF)
	{
		return default(BKCAPMPDKDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D930", Offset = "0x6D7C530", VA = "0x186D7D930")]
	private static BKCAPMPDKDN ICJFDBHEDJN(int MCPGGPJAKIM, List<KBGGODOCLGG> DMJLEDIMDBF)
	{
		return default(BKCAPMPDKDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D7DE20", Offset = "0x6D7CA20", VA = "0x186D7DE20")]
	private static BKCAPMPDKDN IOCLOMDCAEF(Vector3 KDELOFLMOME, Quaternion LBFFEMIAIMM, float JLDCCBFCJGC)
	{
		return default(BKCAPMPDKDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F330", Offset = "0x6D7DF30", VA = "0x186D7F330")]
	public static NativeList<BKCAPMPDKDN> NGMEGHLIBOH(CHOMKALJNDJ ODPJPJLEOIN, float AEGNBMLFGNM)
	{
		return default(NativeList<BKCAPMPDKDN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FEJJCIMBIDO
{
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public static Vector3 NLFDHKGEFHL;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public static Vector3 OAFCDNBLKEM;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public static readonly float PAJHNHBMBJE;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CBC0", Offset = "0x6D7B7C0", VA = "0x186D7CBC0")]
	public static Vector3 GDLAOJGPONF(Vector3 JJMPOKLPFMK, Quaternion LBFFEMIAIMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CFC0", Offset = "0x6D7BBC0", VA = "0x186D7CFC0")]
	public static Vector3 LBEAKCEACOB(Quaternion EAGKGJHHIJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D060", Offset = "0x6D7BC60", VA = "0x186D7D060")]
	public static Vector3 LEODIMDNJAH(Quaternion EAGKGJHHIJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C0C0", Offset = "0x6D7ACC0", VA = "0x186D7C0C0")]
	public static Quaternion AODFKPDLHKK(Vector3 EJOHIEANBFL, Vector3 DJCDKMIHKHG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D100", Offset = "0x6D7BD00", VA = "0x186D7D100")]
	public static Vector3 MKLNAPMCKCM(Vector3 DGAGMEJJLID, Vector3 AJLKCCPIPFK, Vector3 DJCDKMIHKHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C430", Offset = "0x6D7B030", VA = "0x186D7C430")]
	public static Vector3 DGHNNAOCIPK(Vector3 JJMPOKLPFMK, Vector3 DJCDKMIHKHG, Quaternion EAGKGJHHIJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C860", Offset = "0x6D7B460", VA = "0x186D7C860")]
	public static Quaternion FPBCDBNNLNC(Quaternion LBFFEMIAIMM, Vector3 EJOHIEANBFL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CE40", Offset = "0x6D7BA40", VA = "0x186D7CE40")]
	public static bool JOLECNNJNOM(Vector3 OIGPLPFEPEB, Vector3 PEEKHJODCAE, [Out] Vector3 BDBPBPFJEFP, bool HKEAKAPHFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C140", Offset = "0x6D7AD40", VA = "0x186D7C140")]
	public static Vector3 CFEFICLDEMG(bool BGCOCKJOAEK, [Optional] Quaternion DFPHHFKLKPA)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BKCAPMPDKDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public float3 FIKECJKJAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public float3x3 EDMDHCBPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public float CGGKMNAGOAP;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CHOMKALJNDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int JHHPJOKHEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BKIIKGKAMPJ(int MCPGGPJAKIM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion CPHDCDLAPCI(int MCPGGPJAKIM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float EOINBNMCDJK(int MCPGGPJAKIM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GHIENMFCFMM : ALJHPAAKHOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BIJMFHIJOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool JDPMNKFIINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float MMFHCNJPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int CEABBFHIPDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool KPOGMLDNHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int APEENCGEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<BKCAPMPDKDN> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface FIFKKIMGIBH : ALJHPAAKHOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	PKDHLEFJHBK CGAFNLJEBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool AKDHOELJHCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 IMFJPMCCCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PLEFNFBHPPD
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	FJFKEFAPLLG DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	EPEJAJNGNFC GGCJHBMDIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ALJHPAAKHOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool GBJEBMDNCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool DLMLOBFNGMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	FJFKEFAPLLG DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	UniformTRS BFACGCBNNGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float AKPJMBLFDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	Vector3 JIDKPADKMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	JJGANJGEFFL IGMGHIHGAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	OICBHJLAMDI MIIFHEIFOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HOFGPKBKKBF
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int DMHHCMHGOLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform NJELEEAPEHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool OFOLLBCELJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOIMHHIKEDC GetBone(int MCPGGPJAKIM);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MCPGGPJAKIM);
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
