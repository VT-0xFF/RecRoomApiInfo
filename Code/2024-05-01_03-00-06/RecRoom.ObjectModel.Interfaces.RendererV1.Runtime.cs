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
public enum DEMBGNFEHCA
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
public enum JLKPHNPIODB
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
public enum CGOBAPKKICB
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
public enum BNJKEBHKBLK
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
public enum HHFPIAGHHCN
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
public enum ENPFFMMLNID
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
public static class KENPACNALGA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62F0440", Offset = "0x62EF240", VA = "0x1862F0440")]
	public static bool MILCMAJFGBG(this ENPFFMMLNID JCJPBBMLHNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62F0460", Offset = "0x62EF260", VA = "0x1862F0460")]
	public static bool MOEEEBMIPKB(this ENPFFMMLNID JCJPBBMLHNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62F0410", Offset = "0x62EF210", VA = "0x1862F0410")]
	public static bool CBJCFMGOJKJ(this ENPFFMMLNID JCJPBBMLHNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BDMIKMCNHMH
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
public struct PIJJBODIEPM : ICMAJFMJFMA, IEquatable<PIJJBODIEPM>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int PCBIBNEPCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int GGDKNGHMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2373060", Offset = "0x2371E60", VA = "0x182373060", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x56467A0", Offset = "0x56455A0", VA = "0x1856467A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GOBGLGCFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62F0510", Offset = "0x62EF310", VA = "0x1862F0510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D3EA10", Offset = "0x1D3D810", VA = "0x181D3EA10", Slot = "8")]
	public bool Equals(PIJJBODIEPM GGINNHLAMLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61D8580", Offset = "0x61D7380", VA = "0x1861D8580")]
	public static bool CAAJBKCJNPA(PIJJBODIEPM CGAHKNIFIAB, PIJJBODIEPM CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62F0470", Offset = "0x62EF270", VA = "0x1862F0470", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62F0550", Offset = "0x62EF350", VA = "0x1862F0550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FOJMEGKECIG : ICMAJFMJFMA, IEquatable<FOJMEGKECIG>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int PCBIBNEPCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int GGDKNGHMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2373060", Offset = "0x2371E60", VA = "0x182373060", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x56467A0", Offset = "0x56455A0", VA = "0x1856467A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GOBGLGCFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62F0340", Offset = "0x62EF140", VA = "0x1862F0340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D3EA10", Offset = "0x1D3D810", VA = "0x181D3EA10", Slot = "8")]
	public bool Equals(FOJMEGKECIG GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62F02A0", Offset = "0x62EF0A0", VA = "0x1862F02A0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62F0380", Offset = "0x62EF180", VA = "0x1862F0380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PPDMDNMFJHC : ICMAJFMJFMA, IEquatable<PPDMDNMFJHC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PCBIBNEPCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GGDKNGHMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2373060", Offset = "0x2371E60", VA = "0x182373060", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56467A0", Offset = "0x56455A0", VA = "0x1856467A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GOBGLGCFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62F0680", Offset = "0x62EF480", VA = "0x1862F0680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D3EA10", Offset = "0x1D3D810", VA = "0x181D3EA10", Slot = "8")]
	public bool Equals(PPDMDNMFJHC GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x62F05E0", Offset = "0x62EF3E0", VA = "0x1862F05E0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KAAMBAOAABK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIFOMHEPIFN(PIJJBODIEPM GDOPFEEANMP, JLKPHNPIODB DIIKGALEMAO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIFOMHEPIFN(FOJMEGKECIG IFADPKPOCOM, JLKPHNPIODB DIIKGALEMAO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHOIFAGNJBI(FOJMEGKECIG IFADPKPOCOM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KCIFBIILIFH(FOJMEGKECIG IFADPKPOCOM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBKEAPAPDFO();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FBMALMIMPDD(JLKPHNPIODB DDEINLAGLLL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPCBHNJKHNK(PIJJBODIEPM GDOPFEEANMP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JPCBHNJKHNK(FOJMEGKECIG IFADPKPOCOM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IECIHPAMBEP(FOJMEGKECIG IFADPKPOCOM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CHDOEKKMLEG(FOJMEGKECIG IFADPKPOCOM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KCFGDOBMKFA();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JOFGHDBIGJP();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MOELKNFKMEH(PIJJBODIEPM GDOPFEEANMP, HHFPIAGHHCN DDEINLAGLLL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PGEKJHKDAOB(FOJMEGKECIG IFADPKPOCOM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PKGDFIDNHEN(FOJMEGKECIG IFADPKPOCOM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GIKHCODJDAH();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GMAKEANMICA(HHFPIAGHHCN DDEINLAGLLL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MOLEDJNOEDC(PIJJBODIEPM GDOPFEEANMP, Vector3 JGFDHFKPMKG, Vector3 GANJCIEECFF, Vector3 GOHNINHEANA, float LLGEMKPINOP, float INJCCPKOANI, IReadOnlyList<Camera> DALHGNDACFI, DEMBGNFEHCA GBEDEEJEEAF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MOLEDJNOEDC(PPDMDNMFJHC KOFCOIPPHMC, Vector3 JGFDHFKPMKG, Vector3 GANJCIEECFF, Vector3 GOHNINHEANA, float LLGEMKPINOP, float INJCCPKOANI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CEHKEOIGCIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool OIAGDMNOMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PIJJBODIEPM PLOGOJEOGNP(JCAIAPEEIPK LHODDAGAJKC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIJJBODIEPM PLOGOJEOGNP(JCAIAPEEIPK LHODDAGAJKC, bool HFIILHCKDGC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONLHIDBFDFJ(PIJJBODIEPM GDOPFEEANMP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMLBBDGJJAO(PIJJBODIEPM GDOPFEEANMP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FOJMEGKECIG DFEABNEIOJK(PIJJBODIEPM GDOPFEEANMP, HOOJNCANMPK LHODDAGAJKC);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FOJMEGKECIG GNCNOLBLLAF(PIJJBODIEPM GDOPFEEANMP, IKKKJEMDNIJ LHODDAGAJKC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KAHHHHAEAFN(FOJMEGKECIG IFADPKPOCOM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EMNIPKNLCNG(FOJMEGKECIG IFADPKPOCOM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PPDMDNMFJHC AEOMPBOEGJI(PJJCPFKNPDP LHODDAGAJKC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KMCBDGDCAPJ(PPDMDNMFJHC KOFCOIPPHMC);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JAAFBIENJHJ(PPDMDNMFJHC KOFCOIPPHMC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task OEFDGIJNKGN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task OKENNABPHAA();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task KDIGGIPLEBN();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GHPGJPHJFGM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> IFFHKEJJNJF(PIJJBODIEPM GDOPFEEANMP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EGHACKPEHAD
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum LMINPKPEKDL
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
	public enum MEFPDNOLPCN
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum JLLJOAMEPFG
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
	public enum GGNAODIKPGM
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
	public enum GGMKOCCLDAO
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
	public static int CMBDBPCDMHB;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static int JDDLNEMHMIO;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static int GOABJHDIFIL;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static int MCILBMEDHAO;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int[] NEPOGOELJHC;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int EODJCOKCNMC;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int CLCBIALEAAI;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int BELODALBDPL;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static long JHKLGILACCI;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static long ENHHKHFHICN;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static long DEEJMLBFIIP;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static long NJPBHJAMHPK;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long BMBOADKOJCK;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long CFIMPBDIHEK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long JEEGBAAGGLB;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long NGOOEAPLEEL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long OLDMPKKEMBF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long JKPAOIFHLNC;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long PNCLGHFGNHB;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long FNPGJOEJLBP;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float LAIJAINIGOH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static long ABNLIJMBJCK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long LOGBAGEMIOL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static GGMKOCCLDAO NHBPJNMLFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62EDFC0", Offset = "0x62ECDC0", VA = "0x1862EDFC0")]
		[CompilerGenerated]
		get
		{
			return default(GGMKOCCLDAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62ED620", Offset = "0x62EC420", VA = "0x1862ED620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool AIEPBNPMDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62EDAF0", Offset = "0x62EC8F0", VA = "0x1862EDAF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62EF320", Offset = "0x62EE120", VA = "0x1862EF320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static LMINPKPEKDL MNNHFIHKBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62EF520", Offset = "0x62EE320", VA = "0x1862EF520")]
		[CompilerGenerated]
		get
		{
			return default(LMINPKPEKDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x62EF570", Offset = "0x62EE370", VA = "0x1862EF570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool OLEGCOCBJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x62EEEB0", Offset = "0x62EDCB0", VA = "0x1862EEEB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x62EF120", Offset = "0x62EDF20", VA = "0x1862EF120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static MEFPDNOLPCN CMGMJJGAMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x62EDB90", Offset = "0x62EC990", VA = "0x1862EDB90")]
		[CompilerGenerated]
		get
		{
			return default(MEFPDNOLPCN);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x62EF380", Offset = "0x62EE180", VA = "0x1862EF380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool KLMNDMNNJDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62EF050", Offset = "0x62EDE50", VA = "0x1862EF050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x62EE150", Offset = "0x62ECF50", VA = "0x1862EE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool ELLNBBADOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62EFC00", Offset = "0x62EEA00", VA = "0x1862EFC00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x62EF960", Offset = "0x62EE760", VA = "0x1862EF960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool BJHLFOKHNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62EEDC0", Offset = "0x62EDBC0", VA = "0x1862EEDC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x62ED9D0", Offset = "0x62EC7D0", VA = "0x1862ED9D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static float HEDPOMOMDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62EE010", Offset = "0x62ECE10", VA = "0x1862EE010")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62EEF50", Offset = "0x62EDD50", VA = "0x1862EEF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static int AABPIKLFCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x62EDEC0", Offset = "0x62ECCC0", VA = "0x1862EDEC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x62EF2D0", Offset = "0x62EE0D0", VA = "0x1862EF2D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int KMJHNLEDLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62EEE60", Offset = "0x62EDC60", VA = "0x1862EEE60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x62EF910", Offset = "0x62EE710", VA = "0x1862EF910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int DBLIDDHGIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x62EE300", Offset = "0x62ED100", VA = "0x1862EE300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x62EEF00", Offset = "0x62EDD00", VA = "0x1862EEF00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int LBNOLHDOOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x62EFB10", Offset = "0x62EE910", VA = "0x1862EFB10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x62EF780", Offset = "0x62EE580", VA = "0x1862EF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int EFDFJEFHFNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62EEFB0", Offset = "0x62EDDB0", VA = "0x1862EEFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62EF9C0", Offset = "0x62EE7C0", VA = "0x1862EF9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int LGJFGFGAFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x62ED980", Offset = "0x62EC780", VA = "0x1862ED980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x62EF230", Offset = "0x62EE030", VA = "0x1862EF230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int LFFHPNPHFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62EF820", Offset = "0x62EE620", VA = "0x1862EF820")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62EF6E0", Offset = "0x62EE4E0", VA = "0x1862EF6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int OMCJPAPMDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62EDDC0", Offset = "0x62ECBC0", VA = "0x1862EDDC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x62EDF10", Offset = "0x62ECD10", VA = "0x1862EDF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int BGCOBKJEOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62EFB60", Offset = "0x62EE960", VA = "0x1862EFB60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62EFD60", Offset = "0x62EEB60", VA = "0x1862EFD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int PMGPAONCECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62EE100", Offset = "0x62ECF00", VA = "0x1862EE100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62EF730", Offset = "0x62EE530", VA = "0x1862EF730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int EBMAIPCJLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62EF620", Offset = "0x62EE420", VA = "0x1862EF620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62EE250", Offset = "0x62ED050", VA = "0x1862EE250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int OAMGBLJBGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62EDB40", Offset = "0x62EC940", VA = "0x1862EDB40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62EE060", Offset = "0x62ECE60", VA = "0x1862EE060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int DMMLNGNCNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62EF470", Offset = "0x62EE270", VA = "0x1862EF470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x62EF870", Offset = "0x62EE670", VA = "0x1862EF870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int PDLFBJKLADA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x62EE1B0", Offset = "0x62ECFB0", VA = "0x1862EE1B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x62EF000", Offset = "0x62EDE00", VA = "0x1862EF000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int JNHINCKIHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62EFCB0", Offset = "0x62EEAB0", VA = "0x1862EFCB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62EF3D0", Offset = "0x62EE1D0", VA = "0x1862EF3D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool KILGLHOAJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62ED830", Offset = "0x62EC630", VA = "0x1862ED830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62ED6D0", Offset = "0x62EC4D0", VA = "0x1862ED6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool LNKOOMKNGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62ED7E0", Offset = "0x62EC5E0", VA = "0x1862ED7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62ED670", Offset = "0x62EC470", VA = "0x1862ED670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static JLLJOAMEPFG DNMJEBDGLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62ED790", Offset = "0x62EC590", VA = "0x1862ED790")]
		[CompilerGenerated]
		get
		{
			return default(JLLJOAMEPFG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62EDCF0", Offset = "0x62ECAF0", VA = "0x1862EDCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool OGDKEGDKGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62EDE10", Offset = "0x62ECC10", VA = "0x1862EDE10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62EDE60", Offset = "0x62ECC60", VA = "0x1862EDE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static float BKKHBPPEFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62EF1E0", Offset = "0x62EDFE0", VA = "0x1862EF1E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62EDF60", Offset = "0x62ECD60", VA = "0x1862EDF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static float OEDJIDLDOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x62EEE10", Offset = "0x62EDC10", VA = "0x1862EEE10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62EFA10", Offset = "0x62EE810", VA = "0x1862EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static float IDGKMHBDLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62EE200", Offset = "0x62ED000", VA = "0x1862EE200")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62EE350", Offset = "0x62ED150", VA = "0x1862EE350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float KGCEFLJAFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62EF280", Offset = "0x62EE080", VA = "0x1862EF280")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62EF180", Offset = "0x62EDF80", VA = "0x1862EF180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float PPMHOAAOJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62EDCA0", Offset = "0x62ECAA0", VA = "0x1862EDCA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62EDBE0", Offset = "0x62EC9E0", VA = "0x1862EDBE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float PMJMLKHPAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62EF8C0", Offset = "0x62EE6C0", VA = "0x1862EF8C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62EFC50", Offset = "0x62EEA50", VA = "0x1862EFC50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool APIEIDCPOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x62EFAC0", Offset = "0x62EE8C0", VA = "0x1862EFAC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62EF5C0", Offset = "0x62EE3C0", VA = "0x1862EF5C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float KDAHFGIOENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62EFDB0", Offset = "0x62EEBB0", VA = "0x1862EFDB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62EE2A0", Offset = "0x62ED0A0", VA = "0x1862EE2A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static int HOOFJLHNNMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62EF420", Offset = "0x62EE220", VA = "0x1862EF420")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62EDC40", Offset = "0x62ECA40", VA = "0x1862EDC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static int JOPAKFIJEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62EFBB0", Offset = "0x62EE9B0", VA = "0x1862EFBB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62EDA30", Offset = "0x62EC830", VA = "0x1862EDA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool MANCKDGPHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62EFA70", Offset = "0x62EE870", VA = "0x1862EFA70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int EGIHKGENCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62EF7D0", Offset = "0x62EE5D0", VA = "0x1862EF7D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62EFD00", Offset = "0x62EEB00", VA = "0x1862EFD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static float4x4 CLDAAMCNHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x62EDD40", Offset = "0x62ECB40", VA = "0x1862EDD40")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62EF0A0", Offset = "0x62EDEA0", VA = "0x1862EF0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static float3 MDODMANFLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62EF670", Offset = "0x62EE470", VA = "0x1862EF670")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62ED730", Offset = "0x62EC530", VA = "0x1862ED730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static bool GDFBPJOBALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x62ED880", Offset = "0x62EC680", VA = "0x1862ED880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62EDA90", Offset = "0x62EC890", VA = "0x1862EDA90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static GGNAODIKPGM HAFAEJFEIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x62EE0B0", Offset = "0x62ECEB0", VA = "0x1862EE0B0")]
		[CompilerGenerated]
		get
		{
			return default(GGNAODIKPGM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62EF4C0", Offset = "0x62EE2C0", VA = "0x1862EF4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static bool ABJPFOEKPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x62EE3B0", Offset = "0x62ED1B0", VA = "0x1862EE3B0")]
	public static void IGJLADGDGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x62ED8D0", Offset = "0x62EC6D0", VA = "0x1862ED8D0")]
	public static void COFFKBNOMOA(GGMKOCCLDAO NNNCFNKPLDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DAMBDOIKJDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KKJEHGHAHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Vector3 LDNPGPEOBDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Quaternion FCDMNAEMCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public float IMFIACJELNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Quaternion OADDPCPJAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float CPALGLCCNBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public float BAOIBNOPKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public float GFHCOPNIDOK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static List<KKJEHGHAHNC> JCPPJGBLEIE;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x62EAAF0", Offset = "0x62E98F0", VA = "0x1862EAAF0")]
	public static NativeList<PLANDAMNNMP> GIBGMBJGLMD(MGHPLEABHOJ KPBCFHJKPGG)
	{
		return default(NativeList<PLANDAMNNMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62EB1F0", Offset = "0x62E9FF0", VA = "0x1862EB1F0")]
	private static bool LCEGIGJMIFM(int GJPDNBKOLHF, NativeList<PLANDAMNNMP> FJMMLPMLLGC, List<KKJEHGHAHNC> FHNNJDCHHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62EB060", Offset = "0x62E9E60", VA = "0x1862EB060")]
	private static PLANDAMNNMP IJNEIEKLOCJ(int OMMBGLAGAJH, List<KKJEHGHAHNC> FHNNJDCHHBI)
	{
		return default(PLANDAMNNMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x62E9130", Offset = "0x62E7F30", VA = "0x1862E9130")]
	private static PLANDAMNNMP BJOIMBMKPLL(int OMMBGLAGAJH, List<KKJEHGHAHNC> FHNNJDCHHBI)
	{
		return default(PLANDAMNNMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62EC1C0", Offset = "0x62EAFC0", VA = "0x1862EC1C0")]
	private static PLANDAMNNMP LJIHFGICIPO(Vector3 KNKOADKCJLL, Quaternion PJAOGCBLNOI, float KOHJDCIMHLK)
	{
		return default(PLANDAMNNMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62E9640", Offset = "0x62E8440", VA = "0x1862E9640")]
	public static NativeList<PLANDAMNNMP> DMNIFGLHICC(MGHPLEABHOJ KPBCFHJKPGG, float EMHJBDFDIEC)
	{
		return default(NativeList<PLANDAMNNMP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class DOAJDHKMKAK
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static Vector3 PLHDFECHAEI;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static Vector3 ONGFMOMFBAI;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly float PKAJBBLECHP;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62ECCE0", Offset = "0x62EBAE0", VA = "0x1862ECCE0")]
	public static Vector3 GBNEDFBAOGH(Vector3 JDHAINHIKFK, Quaternion PJAOGCBLNOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x62EC330", Offset = "0x62EB130", VA = "0x1862EC330")]
	public static Vector3 BAHLGLIEINN(Quaternion IHHAEIJMAPE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62ED2C0", Offset = "0x62EC0C0", VA = "0x1862ED2C0")]
	public static Vector3 JCMKKHMHJPE(Quaternion IHHAEIJMAPE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62ED360", Offset = "0x62EC160", VA = "0x1862ED360")]
	public static Quaternion JLDPGEPPHKL(Vector3 BCGALFAPEPA, Vector3 ELKFIDDLEIG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62EC3D0", Offset = "0x62EB1D0", VA = "0x1862EC3D0")]
	public static Vector3 BBECLICMCLO(Vector3 HGPMNCNBMJE, Vector3 ABJPNFHMLKF, Vector3 ELKFIDDLEIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x62EC5C0", Offset = "0x62EB3C0", VA = "0x1862EC5C0")]
	public static Vector3 DKANFLJLKOC(Vector3 JDHAINHIKFK, Vector3 ELKFIDDLEIG, Quaternion IHHAEIJMAPE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x62ECF60", Offset = "0x62EBD60", VA = "0x1862ECF60")]
	public static Quaternion IOBPPHGGPGE(Quaternion PJAOGCBLNOI, Vector3 BCGALFAPEPA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x62ED3E0", Offset = "0x62EC1E0", VA = "0x1862ED3E0")]
	public static bool POOIOCAJNIP(Vector3 DHGGIBPNCPF, Vector3 OJOCLDLBDFC, [Out] Vector3 CKPPHJKDBDN, bool GHNFCIFAAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x62EC9F0", Offset = "0x62EB7F0", VA = "0x1862EC9F0")]
	public static Vector3 EDPLEOBEKFK(bool KPLINEBELKB, [Optional] Quaternion LCECPKMIMPP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PLANDAMNNMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public float3 LDNPGPEOBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public float3x3 FCDMNAEMCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public float IMFIACJELNE;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MGHPLEABHOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	int CMBFFNDJBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 MDPDKPPOHCC(int OMMBGLAGAJH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion HDNDONIBKGM(int OMMBGLAGAJH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float CIHOKFBMIJG(int OMMBGLAGAJH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IKKKJEMDNIJ : NLGDDGDMIBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool CPEOHOBBNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool KBJFHHJFAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float LCLFAAKJAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	int PDDIAICIHHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool MEAECPMKIDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int IFOEFDNPPON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<PLANDAMNNMP> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HOOJNCANMPK : NLGDDGDMIBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	CGOBAPKKICB LKEIAILCOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool EOMPOMCNGFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface JCAIAPEEIPK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	MPLDGLCJEIP IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	BNJKEBHKBLK AHLDPPIGEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface NLGDDGDMIBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IEDPNLDBCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool JEHFOGKNLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MPLDGLCJEIP IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float PJDALPELFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Vector3 JKDMJBBPFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ENPFFMMLNID KBGAKNFNANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	BDMIKMCNHMH BBADKHJHPJG
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
public interface PJJCPFKNPDP
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int NLEJEKEBOCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Transform AEPFKKHFMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool CKGFDECNHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIJJBODIEPM GetBone(int OMMBGLAGAJH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int OMMBGLAGAJH);
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
