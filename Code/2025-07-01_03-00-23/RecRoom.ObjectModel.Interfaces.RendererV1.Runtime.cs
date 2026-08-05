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
public enum LHFILGGMHAL
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
public enum CPCDDMBJLPC
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
public enum ACIKMAHKONI
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
public enum ABILOJFBKNO
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
public enum MNGEOBFFJGB
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
public enum NGNKOEFODLB
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
public static class FIAGCPNDBJL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x816DFA0", Offset = "0x816C5A0", VA = "0x18816DFA0")]
	public static bool BBGLCHJKBIL(this NGNKOEFODLB PKHIBHGLMED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x816DFF0", Offset = "0x816C5F0", VA = "0x18816DFF0")]
	public static bool MLKOBLNEOPG(this NGNKOEFODLB PKHIBHGLMED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x816DFC0", Offset = "0x816C5C0", VA = "0x18816DFC0")]
	public static bool MHEGKLCGCFH(this NGNKOEFODLB PKHIBHGLMED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FFLLKLIPNGD
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
public struct OMKHNGNFNIM : PEDJJCFICCD, IEquatable<OMKHNGNFNIM>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int BPENJJIEFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x306D380", Offset = "0x306B980", VA = "0x18306D380", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7175C10", Offset = "0x7174210", VA = "0x187175C10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LAPKEHOOABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8170650", Offset = "0x816EC50", VA = "0x188170650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x12E3250", Offset = "0x12E1850", VA = "0x1812E3250", Slot = "8")]
	public bool Equals(OMKHNGNFNIM HOPHFOOKMCC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F1C0", Offset = "0x3B1D7C0", VA = "0x183B1F1C0")]
	public static bool JKIBMILPCGE(OMKHNGNFNIM DLGEPLKGJOC, OMKHNGNFNIM OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8170690", Offset = "0x816EC90", VA = "0x188170690", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8170720", Offset = "0x816ED20", VA = "0x188170720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FINIDNMFGON : PEDJJCFICCD, IEquatable<FINIDNMFGON>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BPENJJIEFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x306D380", Offset = "0x306B980", VA = "0x18306D380", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7175C10", Offset = "0x7174210", VA = "0x187175C10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LAPKEHOOABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x816E000", Offset = "0x816C600", VA = "0x18816E000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x12E3250", Offset = "0x12E1850", VA = "0x1812E3250", Slot = "8")]
	public bool Equals(FINIDNMFGON HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x816E040", Offset = "0x816C640", VA = "0x18816E040", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x816E0D0", Offset = "0x816C6D0", VA = "0x18816E0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DNIGNMGAIOJ : PEDJJCFICCD, IEquatable<DNIGNMGAIOJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BPENJJIEFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x306D380", Offset = "0x306B980", VA = "0x18306D380", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7175C10", Offset = "0x7174210", VA = "0x187175C10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LAPKEHOOABF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x816DED0", Offset = "0x816C4D0", VA = "0x18816DED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x12E3250", Offset = "0x12E1850", VA = "0x1812E3250", Slot = "8")]
	public bool Equals(DNIGNMGAIOJ HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x816DF10", Offset = "0x816C510", VA = "0x18816DF10", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GIELKEINIAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGGNDFLPOII(OMKHNGNFNIM CMAFOEIBEKN, CPCDDMBJLPC INCEDNPHADK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGGNDFLPOII(FINIDNMFGON LPCNJBGEJJI, CPCDDMBJLPC INCEDNPHADK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEPEBNDIMDD(FINIDNMFGON LPCNJBGEJJI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGEKPCJOKDC(FINIDNMFGON LPCNJBGEJJI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCALJCOFIPO();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNCJBCDGDJJ(CPCDDMBJLPC JLPANLJHHFI);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OBJFDFLHPIE(OMKHNGNFNIM CMAFOEIBEKN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OBJFDFLHPIE(FINIDNMFGON LPCNJBGEJJI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NBAGEGILJND(FINIDNMFGON LPCNJBGEJJI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FFLHHNMGJCK(FINIDNMFGON LPCNJBGEJJI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JJOEPNNAEIN();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BIFGKHHAFKF();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GOJGFBMGHEJ(OMKHNGNFNIM CMAFOEIBEKN, MNGEOBFFJGB JLPANLJHHFI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MMPEEPDHHJF(FINIDNMFGON LPCNJBGEJJI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EJBGCJCCMMF(FINIDNMFGON LPCNJBGEJJI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LBHJEIOJIBE();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LFHOEBGEHEG(MNGEOBFFJGB JLPANLJHHFI);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CDCMBKBGGDJ(OMKHNGNFNIM CMAFOEIBEKN, Vector3 OIDJJFFMDDF, Vector3 BCBAKMNONHC, Vector3 AFDKHLLGKCL, float ICDJLLAPFOK, float GJMLJNFKPJO, IReadOnlyList<Camera> PIBGGMOOKAC, LHFILGGMHAL BIHFHFIFIHD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CDCMBKBGGDJ(DNIGNMGAIOJ CAGADNOIPEK, Vector3 OIDJJFFMDDF, Vector3 BCBAKMNONHC, Vector3 AFDKHLLGKCL, float ICDJLLAPFOK, float GJMLJNFKPJO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FCDPDINJFJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IHOPMGCPIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMKHNGNFNIM HNLJMALFHDJ(BJELADJEHBH ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMKHNGNFNIM HNLJMALFHDJ(BJELADJEHBH ACJFHCNBBBO, bool HIFNIMFLCPE);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJIHJIFKELI(OMKHNGNFNIM CMAFOEIBEKN);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMPEKCFEAIE(OMKHNGNFNIM CMAFOEIBEKN);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FINIDNMFGON BMIKBDNKEKF(OMKHNGNFNIM CMAFOEIBEKN, HLGMNJHBLBJ ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FINIDNMFGON MDNMIGAGAJF(OMKHNGNFNIM CMAFOEIBEKN, MGNNCINACHN ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INNCJCIOLBH(FINIDNMFGON LPCNJBGEJJI);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFNOINOOGBK(FINIDNMFGON LPCNJBGEJJI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DNIGNMGAIOJ MHFGAGNKELN(PJCCMEMFCMA ACJFHCNBBBO);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HDBHNJJIACH(DNIGNMGAIOJ CAGADNOIPEK);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PFKJMCFNFPJ(DNIGNMGAIOJ CAGADNOIPEK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task KCOFEHFFNLI();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task GJKFAKHHKBD();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task GOLICPLOKFC();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EMHPKFOLEME();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> DIJNBKAOGFA(OMKHNGNFNIM CMAFOEIBEKN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JEDJMLACHKM
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum MKPPFBPKGHI
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum AFLIFCMNKAN
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum IDNNPKALMPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		BatchColour,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		RefreshShapesBatchColour,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		RefreshBatchedMeshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum OBCKCGJKPAN
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum KPBKADPODLK
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum LJFNOJJAAJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum AINEPAOALIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum IIDABHBFLAI
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		LowQualityHighSpeed = 102
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool MAFEIOABMFH;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long JOOIABIOGBC;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool LCBGCIAHNNF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool BGDADPAFGMM;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool OMLGKIAEDOC;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float NEAKJFHFMBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float OHEIAFKPGBG;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int DHKCEBGIHNI;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static LJFNOJJAAJK CCJNCHOKBGO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long ADKGGJAINKE;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float NAICDFILOLI;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int ICHCKGCMPLM;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int AMPNKIOLOKD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int KFKCIKEFBHM;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int AGMMKBBMBED;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int PHHGHHFBJFC;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int DGENPEMLOLL;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int CPBODPHGONB;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int FHOIACHIFOK;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool LPJHALBKFOO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int HFKEKMNELFD;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int IFMHNCAOKPG;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int DLAPFLGEPNF;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool LOJFEAKMNOH;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float EIGFLKEHKLG;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool LEHCNNCBPJC;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float LEOCLCCELCO;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long IGIAMGKGDOI;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool PHJDHPLDMOB;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long FEDDHLAKICK;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int GOKEHMANKND;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool IKIHALNDAIC;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static MKPPFBPKGHI KCONBMMFABI;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool COEMJEKKAMN;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool APLABOOLGCH;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int IPGLKLLJCHP;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int AOIMPIBKGPF;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int FHILJJGAELE;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int DIEKOKNMLLL;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int LODPNGPNIPA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int CMELJIONJLD;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int LAOGELHKLAA;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int CLIOFOKAIDI;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float LLAEPFCPADF;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float CNJJJANDMJN;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float HMIMAGFINKF;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float GGPAFDJDKOB;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int EMNIMPALHEO;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int KMDHCNJNBGP;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int PPMKHGMIKBG;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int EHKOAFGAPPO;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool AEPCCGAENDP;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static IDNNPKALMPH JMMKIBANGCK;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static OBCKCGJKPAN LOJMJCPOGKB;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool HBNMBFKNOAP;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static AFLIFCMNKAN GFCNGFDIHAD;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float IEAFHMKEDBF;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float JDJJPCCJMNL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float ENNGLEHAKKG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float ALOOKILKKNL;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float DDMODLGAKDP;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float JFDOKEPBOCG;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float IFIAGCAAHKE;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float KIOHIOGPFHD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool ELKHOMAKPAD;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static AINEPAOALIE AMGMBMHMHBC;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool AJMNFDFMGBM;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float IDPEMGOGABA;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float BBMBIJELFKE;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float OPJCFPAGIGM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float OJLCDAKCAGL;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float ADMKMMKPJFP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool JNAIIDNAIIO;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long NADGFIBGDCD;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float NOCEIAKKPMN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float DPMDDPCLFEE;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float JBHBCBIPMMP;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int KHJLLJFEFMK;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float HNAGOOMMJIE;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool IOFDLBJHJKD;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long HJKLNOCPHEA;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int LCMKKCNFALN;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int OEAHLCGODJB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float KPLJNBEKBFE;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float NFAFOALOIJE;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool EENDDEJBEBB;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool KCBHPNEHBKL;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float HGMOHOMHBKL;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long LDFKEAEDCEP;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long ALCFMPNBDDI;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int FMIGAKPFDMB;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 NBCBCKNLAMK;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 CDBBBEEEHHK;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool EIMMCDDKLFH;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static KPBKADPODLK LFMOKEOGNLI;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long OIPHJKEJJHA;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int EBDIIBHNKCE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int ENCOEJAPHMI;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int NEIIPBNAODA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int OLFPMLLBOFE;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int CIKBDNAGEDI;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int MFLCGNBJPKH;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int OEONOILNOOE;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static long PGJGCGHBOOL;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int PAIMCDDDIPG;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int LIKDNGGPMKG;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int BEOAJPKLFHM;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long DPLAGEDNLAF;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long CKCLOOEPFMO;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long BPGCNGCNEHO;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static long EANOAJMDOAK;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int OOAACCJJIKA;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int OCHBFNDPLON;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int KLEBMDHDFBF;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int NOBCELMGPAF;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static int FJJAKIDJAMO;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static int[] KOEHBGHBGIH;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int[] OKCAJMNINPI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int NALHIDCDIKA;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long NABBCKBCDDH;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long HIOPJOEJNGI;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int PJHBLGCINMC;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int MKHBHOLHGIM;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long HKEAEEMNOPK;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long IMMKCHMFNPD;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long ELNDEHNAOBE;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long PPCGMOHDKLD;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long CDJEBAJHMMF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static long MHEOMPOALBK;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long IGDCOLHLGAM;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long GDIBCGPFCJL;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long NAFLEDMOFFE;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static float LIADAKPEDAL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static float LFODHIOJAGO;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long JNEPHHNALJK;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static int NGJJHKAHJOD;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long NEBHKEANFMO;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long KKAHLJBGPOL;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float FNINJDECAAP;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long NGBDCLBGLEI;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long GIFKECLEKAI;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long LDDEPINEKJB;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long EBJLJECBHMF;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long DOAHNEALFFO;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long NJJBOOKFKKI;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long OCJDBEHGNOC;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long MDEKEELJJAC;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long FIMFGDOEHJP;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long JFODLLPJNMI;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long FMFDBFOAJIK;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long CBAEAFMPPFE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static IIDABHBFLAI JKFCCFLPIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x816E1C0", Offset = "0x816C7C0", VA = "0x18816E1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long FAOHAKNCMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x816E160", Offset = "0x816C760", VA = "0x18816E160")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x816F2E0", Offset = "0x816D8E0", VA = "0x18816F2E0")]
	public static void LHIKIKPIDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x816E220", Offset = "0x816C820", VA = "0x18816E220")]
	public static void HDFCHIHLDBO(IIDABHBFLAI EODPNFHCOEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class PBIJNKFGEBM
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct APCGPCHBELN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public Vector3 DGHMAMNELGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Quaternion GBHJDFCFFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float OLEEDNHGCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public Quaternion BKCMMCJEFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float KHJLMEGOMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float EBIAAPPENMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float CDCJAEKDPLJ;
	}

	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private static List<APCGPCHBELN> KICIFAKPKOA;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8173110", Offset = "0x8171710", VA = "0x188173110")]
	public static NativeList<FEALKEEJBEM> GHEGBJLLOBI(CGAFCLPGFCC FGCEFPKBOEH)
	{
		return default(NativeList<FEALKEEJBEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8173B90", Offset = "0x8172190", VA = "0x188173B90")]
	private static bool KACLBCFMGGB(int LGMBEINIKOB, NativeList<FEALKEEJBEM> HPCDHGHHCOO, List<APCGPCHBELN> HCLIMLODNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8172F90", Offset = "0x8171590", VA = "0x188172F90")]
	private static FEALKEEJBEM CAONMDLLLMK(int JAENDMHBLHP, List<APCGPCHBELN> HCLIMLODNJL)
	{
		return default(FEALKEEJBEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81736A0", Offset = "0x8171CA0", VA = "0x1881736A0")]
	private static FEALKEEJBEM IIPCPPKICBL(int JAENDMHBLHP, List<APCGPCHBELN> HCLIMLODNJL)
	{
		return default(FEALKEEJBEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8174A40", Offset = "0x8173040", VA = "0x188174A40")]
	private static FEALKEEJBEM LJKNDLLOKKH(Vector3 JPAIMFCOEEF, Quaternion LFABKDOANNB, float OFCEKCJNBGJ)
	{
		return default(FEALKEEJBEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8171AD0", Offset = "0x81700D0", VA = "0x188171AD0")]
	public static NativeList<FEALKEEJBEM> BJIOMAGEHBI(CGAFCLPGFCC FGCEFPKBOEH, float INEDJNOFGHJ)
	{
		return default(NativeList<FEALKEEJBEM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class OOLIKGAFOLK
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static Vector3 FLMBADOBCJA;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public static Vector3 MEBLJMLIEKO;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly float JBBKDGIHAOM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81708D0", Offset = "0x816EED0", VA = "0x1881708D0")]
	public static Vector3 ILPOJGEFIBC(Vector3 INAGHMJFLFL, Quaternion LFABKDOANNB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8170B60", Offset = "0x816F160", VA = "0x188170B60")]
	public static Vector3 IMDKMEGKEFI(Quaternion CFFPEJBOBIA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8170830", Offset = "0x816EE30", VA = "0x188170830")]
	public static Vector3 HNJAHPLALAN(Quaternion CFFPEJBOBIA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81707B0", Offset = "0x816EDB0", VA = "0x1881707B0")]
	public static Quaternion ACNOPIBHIAP(Vector3 GJGHBLDDKFD, Vector3 IFDADDNBHKB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8170EF0", Offset = "0x816F4F0", VA = "0x188170EF0")]
	public static Vector3 NHGOFOLNGLC(Vector3 NEJEOJLEEEP, Vector3 AFONPKPMBPL, Vector3 IFDADDNBHKB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x81710E0", Offset = "0x816F6E0", VA = "0x1881710E0")]
	public static Vector3 NINJIHFFMCC(Vector3 INAGHMJFLFL, Vector3 IFDADDNBHKB, Quaternion CFFPEJBOBIA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8171690", Offset = "0x816FC90", VA = "0x188171690")]
	public static Quaternion OKBKCLPHFAE(Quaternion LFABKDOANNB, Vector3 GJGHBLDDKFD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8171510", Offset = "0x816FB10", VA = "0x188171510")]
	public static bool ODHBMOKHHEG(Vector3 ODFEGLMBOBD, Vector3 LDBJMILKBEP, [Out] Vector3 FABHMFNHHAA, bool BIFGEMJOOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8170C00", Offset = "0x816F200", VA = "0x188170C00")]
	public static Vector3 KNEJBOHFMMC(bool ECACNNCAHJB, [Optional] Quaternion MICPFEFDCGE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FEALKEEJBEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float3 DGHMAMNELGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public float3x3 GBHJDFCFFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float OLEEDNHGCLA;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CGAFCLPGFCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int JDJNGFLKLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 IACOJFBJPKJ(int JAENDMHBLHP);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion PMCOOJCDFAF(int JAENDMHBLHP);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float JMOOFIKCBFJ(int JAENDMHBLHP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface MGNNCINACHN : EEMKIJGFKJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IOLHOBJHBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GPBMBDPKACB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float IELNLCHONJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int JIAHFAHKPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool EMGMDDLMAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int HIHNMLDEPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FEALKEEJBEM> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HLGMNJHBLBJ : EEMKIJGFKJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ACIKMAHKONI LEGCMAEMLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FFCDDOFMKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 PEIMCNIPOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BJELADJEHBH
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MBBBIPMPPEE BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	ABILOJFBKNO FOPIFNDFHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EEMKIJGFKJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CGJAJBOPFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ICDMLNNAPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MBBBIPMPPEE BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS JIPNALKMBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float DNMLDIOIFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 LBOKOIGMABN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	NGNKOEFODLB FPDJIBFFNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FFLLKLIPNGD HMPPKAJNMHN
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
public interface PJCCMEMFCMA
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int LGPLNAMDGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform DMGCLLPAFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool GDCNIHADCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMKHNGNFNIM GetBone(int JAENDMHBLHP);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int JAENDMHBLHP);
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
