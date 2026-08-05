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
public enum PDFIDPLOKGF
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
public enum ELCBLENENFJ
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
public enum GPADGHOFJCI
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
public enum MGNEEMIMPIH
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
public enum FGMEPCABJKL
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
public enum OCHABKGPDJF
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
public static class ACPGHBDLBDF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x815F7F0", Offset = "0x815DFF0", VA = "0x18815F7F0")]
	public static bool GCJEHEPMMCO(this OCHABKGPDJF BEELNHKBHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x815F840", Offset = "0x815E040", VA = "0x18815F840")]
	public static bool LMIEOFFLDJF(this OCHABKGPDJF BEELNHKBHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x815F810", Offset = "0x815E010", VA = "0x18815F810")]
	public static bool KAJFIJBHHEK(this OCHABKGPDJF BEELNHKBHFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MGEEHPEJAKN
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
public struct EHLBOOAPMJF : OACALCJJELJ, IEquatable<EHLBOOAPMJF>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2F364C0", Offset = "0x2F34CC0", VA = "0x182F364C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71B2930", Offset = "0x71B1130", VA = "0x1871B2930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KBFIABEIPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8160E10", Offset = "0x815F610", VA = "0x188160E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x129E8D0", Offset = "0x129D0D0", VA = "0x18129E8D0", Slot = "8")]
	public bool Equals(EHLBOOAPMJF KEKEFPAJGHD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3844970", Offset = "0x3843170", VA = "0x183844970")]
	public static bool NALNDDPCEFD(EHLBOOAPMJF HBMOFOICGEH, EHLBOOAPMJF LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8160D80", Offset = "0x815F580", VA = "0x188160D80", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8160E50", Offset = "0x815F650", VA = "0x188160E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct AOHNGCKJMMB : OACALCJJELJ, IEquatable<AOHNGCKJMMB>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2F364C0", Offset = "0x2F34CC0", VA = "0x182F364C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71B2930", Offset = "0x71B1130", VA = "0x1871B2930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KBFIABEIPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x815F8E0", Offset = "0x815E0E0", VA = "0x18815F8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x129E8D0", Offset = "0x129D0D0", VA = "0x18129E8D0", Slot = "8")]
	public bool Equals(AOHNGCKJMMB KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x815F850", Offset = "0x815E050", VA = "0x18815F850", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x815F920", Offset = "0x815E120", VA = "0x18815F920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CNNCIMMAOJA : OACALCJJELJ, IEquatable<CNNCIMMAOJA>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2F364C0", Offset = "0x2F34CC0", VA = "0x182F364C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71B2930", Offset = "0x71B1130", VA = "0x1871B2930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KBFIABEIPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x815FA40", Offset = "0x815E240", VA = "0x18815FA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x129E8D0", Offset = "0x129D0D0", VA = "0x18129E8D0", Slot = "8")]
	public bool Equals(CNNCIMMAOJA KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x815F9B0", Offset = "0x815E1B0", VA = "0x18815F9B0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DBFFJCHPNOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNNODKDJLLL(EHLBOOAPMJF MJAMEBJFAIN, ELCBLENENFJ FIPGMBEGOHI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNNODKDJLLL(AOHNGCKJMMB GOMGOEKJPBC, ELCBLENENFJ FIPGMBEGOHI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APEDOFPOOGK(AOHNGCKJMMB GOMGOEKJPBC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKOBFABEMND(AOHNGCKJMMB GOMGOEKJPBC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKDPJBIDJLP();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKJCHIKDPMO(ELCBLENENFJ CEPGAJKBPDM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GKONBFKHEBI(EHLBOOAPMJF MJAMEBJFAIN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GKONBFKHEBI(AOHNGCKJMMB GOMGOEKJPBC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMNIJHDDDAH(AOHNGCKJMMB GOMGOEKJPBC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EIBDCOMIMAH(AOHNGCKJMMB GOMGOEKJPBC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OGOPIMCNGIG();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JDABHGFMBKN();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PAFICAGOCNO(EHLBOOAPMJF MJAMEBJFAIN, FGMEPCABJKL CEPGAJKBPDM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GILKGHAGIAK(AOHNGCKJMMB GOMGOEKJPBC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GGLADHFIFIL(AOHNGCKJMMB GOMGOEKJPBC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DANJLJCHJCG();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LAHEMNNJONB(FGMEPCABJKL CEPGAJKBPDM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CGKFJNFAINM(EHLBOOAPMJF MJAMEBJFAIN, Vector3 NNPFJJPAOHJ, Vector3 IPEEKJCFIOM, Vector3 AHDCMEODNNL, float HEMPAMFAGFP, float EOMACJAECML, IReadOnlyList<Camera> NHOKMEBJLBF, PDFIDPLOKGF BGHBIEECDGN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CGKFJNFAINM(CNNCIMMAOJA PDAHJDNAJHM, Vector3 NNPFJJPAOHJ, Vector3 IPEEKJCFIOM, Vector3 AHDCMEODNNL, float HEMPAMFAGFP, float EOMACJAECML);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EKIIKOCIIMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MDPPPPINKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHLBOOAPMJF FKECCMDDHAC(NKCLKODHAAP IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHLBOOAPMJF FKECCMDDHAC(NKCLKODHAAP IMINNNCPCJF, bool EBNCFOFHCJF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NEMKHHHCICC(EHLBOOAPMJF MJAMEBJFAIN);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFMLNNIPKLK(EHLBOOAPMJF MJAMEBJFAIN);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AOHNGCKJMMB HOEHGAMBHGF(EHLBOOAPMJF MJAMEBJFAIN, FAKJEMFPGGP IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AOHNGCKJMMB DEDHPIODCPL(EHLBOOAPMJF MJAMEBJFAIN, COKLCAOIGDG IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EEKCNEHHLMI(AOHNGCKJMMB GOMGOEKJPBC);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ECDJEANJOAG(AOHNGCKJMMB GOMGOEKJPBC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CNNCIMMAOJA MOCDHECPFCD(MFOJNOCHEOF IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CILNCJJEEBB(CNNCIMMAOJA PDAHJDNAJHM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MNAENNMCHJO(CNNCIMMAOJA PDAHJDNAJHM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task NNAODHBMMPJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DGLMNBMPBPJ();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task MECLBKMBHFG();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BMGODHFIJFM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> JACNCIEANDG(EHLBOOAPMJF MJAMEBJFAIN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GMHCDHCFFAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum EAJKEJDGOIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum NNDKGPLGPMG
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum LJNBLLFJOFO
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
	public enum DONAKINCCID
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
	public enum FDGIIKJMADL
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
	public enum JMGHKLFBJGB
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
	public enum AGANFFFJNLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum KCMIGNNBHFO
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
	public static bool EMFIHFCHOKG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long CIGLODHCNHM;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool GNCKNPODBEN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool DMNGMEMDPDH;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool FEONLLBOLKC;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float OLHLBAPJKEM;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float AMBAOPFJICJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int BAEDCNGCJHE;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static JMGHKLFBJGB MJMOMJBACDA;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long MCGHFHHHNID;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float KJDEMJLMMHD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int OIHBHEHGIHG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int EHNFCDNALLL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int NCPGPMKOEDO;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int DIHNAEFPHNC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int DPFOGNHBGIK;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int IBFEJOCHBNE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int BKLCDCJIKHL;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int ONOHBAGJCFO;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool PLPJBFMHAOL;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int PKOGAKGOMED;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int KAIBMFAKGJM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int CHDMOKEAJIK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool MFMLADANACG;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float PKAONJMIMJP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool PBDJBMHLOPB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float IJNILIFAIPL;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long EPIFENMDLNB;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool KMIHBLIEELO;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long GKKGPINOPHG;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int DHDMPFCNGPO;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool IKJMEMLPENK;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static EAJKEJDGOIP NCDHOLJMJID;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool KJECCOGGOAF;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool EMGEKECABOF;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int EJAGNJHEEGA;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int POEHDNLPKCG;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int KMPFBKEOOGM;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int NLKNFJPDLLJ;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int DCLDIAOGNJF;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int CAMLIMPAMAP;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int NPKDKMAJIAC;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int MGPCCJENCIP;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float ICDAEPAMAIC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float NPJLHGCOLJH;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float HMHMNNNHOJI;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float EJCNJOIHILP;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int LPKDOFDNFJJ;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int HGFEOOAPABJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int FCMKFDNAAEI;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int ONHIBNNAHHJ;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool JDAPAFCLIGP;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static LJNBLLFJOFO IHOONAGDJGP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static DONAKINCCID FIPJKLBJMNG;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool NLMLACNKELP;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static NNDKGPLGPMG EEKOCBGKNCK;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float KHGOAMBACEB;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float OJIGFNDLJKP;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float GBEPGDFAPCG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float DOCPNENCECE;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float FIKIBEBPPJK;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float EJAAGBAOHEB;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float PCENJMJKGON;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float FGKGHOPKHKO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool GOFPBPHCPAJ;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static AGANFFFJNLN HIIFKAFLGMF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool ANPPMNKNGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float GCBOGDABMBF;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float KFFJBPHGBHD;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float CDADIKMIEBC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float JALGMODFPCE;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float KJPODLJDMDJ;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool LMMHACDDHMM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long DACKELDIJIO;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float OODBBMPAIKA;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float OADJOHNELCC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float HIHLHEANDNK;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int OAANNAOJMJN;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float AKHHKEDMGAF;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool CHENEEPAJCF;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long DEBMNLJCNJP;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int FNEFFOEJEOO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int JODBGPGANJN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float LOMAIFCHGAP;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float HEAMEHMNBDB;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool BGFIJLAHKFE;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool PDJIMDJMHNP;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float ECFDFHNKFFD;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long LNONOEMEOFH;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long OIPLMMKLECK;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int IKMOLDOOMOM;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 PBOBAJAEBGC;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 PJPEBGLHEKM;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool LLEPBACGAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static FDGIIKJMADL BIEOFBEFOKA;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long FHPCNAFBDKB;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int BNPDEBGDCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int ANMDJIMCBEE;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int PKFBPEPBCBC;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int DOMKBHJHKCB;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int ALBDNDOAIPM;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long HLGONDNOJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int KHBDPEGECCA;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int IMJBBGCONDM;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int GALKKKFDKIP;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long GJCDEMELKCB;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long DBKJKPHJFLN;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long ICEPEPKEKOC;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long PDKEKDADNEP;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int GOLFLIHJLMC;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int AHKBIHHPMEC;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int DKOMBGKIAII;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int MFJMLCPLJON;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] DLBIPFAHIIL;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int FJLEMPHPNKJ;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long NCBNDEOCEND;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long BHALPJDFHAL;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int LJAIOLBFBLG;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int HPBJFFPFIMP;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long LFAJGHJBCND;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long NDPMCDIAMFA;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long BCDLLJAJHCO;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long NIMEGMMMLMB;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long NLHIHOHKMFD;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long PHHEAKPOEOL;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long CAPJDKEFFKP;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long PBIPFGHPCFI;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long PCKFHLLBFMB;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float CPJCMCMNOHK;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float BLNKABGABKO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long DLNOMKDFLCP;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int LGOEJDBDLGI;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long FIJJPEFGMOI;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long MLOJCGEAJOC;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float IEJBGCJMHGL;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long JJDINMJEEOE;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long MDABJCKLMFE;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long EHJOCCMONAP;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long MMDEFEHDIOK;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long GHOMOBLGCFG;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long BBFKFKNAEAI;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long PFLNLNAOEOK;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long KOGDKHGJNOA;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long BEKBEFCMBJD;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long CFAIEAGKDPJ;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long OJKGEGCNBNE;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long KLFCKPOIKDG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static KCMIGNNBHFO NHGOLENCFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8160EE0", Offset = "0x815F6E0", VA = "0x188160EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long NIMBLNCOMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8161EB0", Offset = "0x81606B0", VA = "0x188161EB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8161F10", Offset = "0x8160710", VA = "0x188161F10")]
	public static void PNJBJDPHGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8160F30", Offset = "0x815F730", VA = "0x188160F30")]
	public static void FICNGCHOMIL(KCMIGNNBHFO OEMEBEIEPPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JLJPIKAILHE
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct OBMFNPDJIOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 EOALAOOGNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Quaternion FAABMGBBECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float DDOAMKNOBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Quaternion FDDNNIDEEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float NFNECIPMLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float JKBNMIOCAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public float BGBMBGOKFDO;
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static List<OBMFNPDJIOH> HDJJBELHLJN;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x81659F0", Offset = "0x81641F0", VA = "0x1881659F0")]
	public static NativeList<KKEDALOMPGI> NEHFMDLLMOG(PPOCPEKNDDK NGABBABGLLA)
	{
		return default(NativeList<KKEDALOMPGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8164B60", Offset = "0x8163360", VA = "0x188164B60")]
	private static bool NCDOBMOBBKO(int CCPDHPNHILC, NativeList<KKEDALOMPGI> KJCFPPKBAOB, List<OBMFNPDJIOH> NJPCHEIHPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8162F70", Offset = "0x8161770", VA = "0x188162F70")]
	private static KKEDALOMPGI BHPBCDCKHLK(int BIJFLLMPINH, List<OBMFNPDJIOH> NJPCHEIHPHA)
	{
		return default(KKEDALOMPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8164590", Offset = "0x8162D90", VA = "0x188164590")]
	private static KKEDALOMPGI IBEABBEMJPI(int BIJFLLMPINH, List<OBMFNPDJIOH> NJPCHEIHPHA)
	{
		return default(KKEDALOMPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8164A80", Offset = "0x8163280", VA = "0x188164A80")]
	private static KKEDALOMPGI LKBMGNLBAMG(Vector3 HFIBPPGFFAG, Quaternion KHAMCCGPNHN, float ANIHENNGJAL)
	{
		return default(KKEDALOMPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81630F0", Offset = "0x81618F0", VA = "0x1881630F0")]
	public static NativeList<KKEDALOMPGI> DCPOEOBCKLF(PPOCPEKNDDK NGABBABGLLA, float PHGAIBNCDOJ)
	{
		return default(NativeList<KKEDALOMPGI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class DCEMEINNFII
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 FGEJDDEKNIE;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static Vector3 FFMGFDIFEFF;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly float EHNJHCPLBEJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81606A0", Offset = "0x815EEA0", VA = "0x1881606A0")]
	public static Vector3 ODGLPNHLEDC(Vector3 KGMBDJFNCJN, Quaternion KHAMCCGPNHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8160600", Offset = "0x815EE00", VA = "0x188160600")]
	public static Vector3 NJCOIMCBPAF(Quaternion FENAGHBAFHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8160920", Offset = "0x815F120", VA = "0x188160920")]
	public static Vector3 OFKIKLDJNOA(Quaternion FENAGHBAFHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x815FA80", Offset = "0x815E280", VA = "0x18815FA80")]
	public static Quaternion AGEOKFGCJJF(Vector3 LONBCENHPHO, Vector3 IILAMILCBNH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x815FF30", Offset = "0x815E730", VA = "0x18815FF30")]
	public static Vector3 JAIHCAPIFNJ(Vector3 AFCKAOFHALL, Vector3 OKDOJNPEPLG, Vector3 IILAMILCBNH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x815FB00", Offset = "0x815E300", VA = "0x18815FB00")]
	public static Vector3 GHPGJINLBPE(Vector3 KGMBDJFNCJN, Vector3 IILAMILCBNH, Quaternion FENAGHBAFHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8160120", Offset = "0x815E920", VA = "0x188160120")]
	public static Quaternion LFPBCAOLEMB(Quaternion KHAMCCGPNHN, Vector3 LONBCENHPHO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8160480", Offset = "0x815EC80", VA = "0x188160480")]
	public static bool MGADJHPBKEI(Vector3 HOFGHGPKLNO, Vector3 BMHCDGOAMHJ, [Out] Vector3 GENEBLLECDJ, bool HPDOHLKNILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x81609C0", Offset = "0x815F1C0", VA = "0x1881609C0")]
	public static Vector3 OKLGGLICFDI(bool JJKHHDOJABL, [Optional] Quaternion KBCNLKGDPKM)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KKEDALOMPGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3 EOALAOOGNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float3x3 FAABMGBBECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float DDOAMKNOBPD;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PPOCPEKNDDK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int NBONHAOJJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 HCCPHELEGJK(int BIJFLLMPINH);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion GLHOAPBJABN(int BIJFLLMPINH);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float AOJONEDIOJO(int BIJFLLMPINH);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface COKLCAOIGDG : OMPPFNFJGFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GEOJDLJFJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BJJEMCEGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float CHMGLBHDCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int KAKMPJPCNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool AJFFMACCMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int AFALELDPBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<KKEDALOMPGI> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FAKJEMFPGGP : OMPPFNFJGFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GPADGHOFJCI ADOIFIGOBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OIJLDMKPBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 EPJNLHHIMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NKCLKODHAAP
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HOAIPFDEDJB GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MGNEEMIMPIH FEDFIMMIGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OMPPFNFJGFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BIGENMIIGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool FHJAIALMILE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HOAIPFDEDJB GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS GGKAKMDKMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float DEKMHJAIAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 EGLNFLGEBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	OCHABKGPDJF FKADCMHGHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	MGEEHPEJAKN FCKFPJOHDKI
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
public interface MFOJNOCHEOF
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int PIMEDPOKNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform AGBLHIGKLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool CNAGGHNDLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHLBOOAPMJF GetBone(int BIJFLLMPINH);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int BIJFLLMPINH);
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
