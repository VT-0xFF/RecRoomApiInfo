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
public enum BKBCNJMNLMC
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
public enum LCELNNMJEBA
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
public enum MADKHAHICNA
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
public enum BCPFADGNNNB
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
public enum IHDDPGHJDNB
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
public enum OCHPJGPHIOB
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
public static class CKMKGGFOLOO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x79849B0", Offset = "0x7983DB0", VA = "0x1879849B0")]
	public static bool AMKHEKIMLCD(this OCHPJGPHIOB FDJCPKKEGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79849D0", Offset = "0x7983DD0", VA = "0x1879849D0")]
	public static bool MKIKBFIHIPF(this OCHPJGPHIOB FDJCPKKEGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x79849E0", Offset = "0x7983DE0", VA = "0x1879849E0")]
	public static bool OJIGBBBBHFL(this OCHPJGPHIOB FDJCPKKEGGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FECNNNMEDDD
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
public struct EHIJPMKNJBK : GLCINBGBILH, IEquatable<EHIJPMKNJBK>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int BNBIOAJGDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int KIPMDJJPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A510", Offset = "0x2C89910", VA = "0x182C8A510", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A94680", Offset = "0x6A93A80", VA = "0x186A94680", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MLDGJAOBMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7984AB0", Offset = "0x7983EB0", VA = "0x187984AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x176F820", Offset = "0x176EC20", VA = "0x18176F820", Slot = "8")]
	public bool Equals(EHIJPMKNJBK JAPIEEBOJEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3402060", Offset = "0x3401460", VA = "0x183402060")]
	public static bool IGEKHAEJGKN(EHIJPMKNJBK NJNDFFALKHH, EHIJPMKNJBK NLOOBJLDIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7984A10", Offset = "0x7983E10", VA = "0x187984A10", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7984AF0", Offset = "0x7983EF0", VA = "0x187984AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BLIJJMIHMBP : GLCINBGBILH, IEquatable<BLIJJMIHMBP>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BNBIOAJGDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int KIPMDJJPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A510", Offset = "0x2C89910", VA = "0x182C8A510", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6A94680", Offset = "0x6A93A80", VA = "0x186A94680", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MLDGJAOBMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x79848E0", Offset = "0x7983CE0", VA = "0x1879848E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x176F820", Offset = "0x176EC20", VA = "0x18176F820", Slot = "8")]
	public bool Equals(BLIJJMIHMBP JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7984840", Offset = "0x7983C40", VA = "0x187984840", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7984920", Offset = "0x7983D20", VA = "0x187984920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JNCMLKGNEOC : GLCINBGBILH, IEquatable<JNCMLKGNEOC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BNBIOAJGDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KIPMDJJPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A510", Offset = "0x2C89910", VA = "0x182C8A510", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A94680", Offset = "0x6A93A80", VA = "0x186A94680", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MLDGJAOBMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7985F20", Offset = "0x7985320", VA = "0x187985F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x176F820", Offset = "0x176EC20", VA = "0x18176F820", Slot = "8")]
	public bool Equals(JNCMLKGNEOC JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7985E80", Offset = "0x7985280", VA = "0x187985E80", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GGLOKDKCJOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COFLOJGLJHE(EHIJPMKNJBK FDNIDHBNFHE, LCELNNMJEBA JHMECDIEDJJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COFLOJGLJHE(BLIJJMIHMBP MKAKNMKKKCL, LCELNNMJEBA JHMECDIEDJJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGKGGFDJCKK(BLIJJMIHMBP MKAKNMKKKCL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KAJFMFOCFPP(BLIJJMIHMBP MKAKNMKKKCL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCCPMLPJLKO();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NHCJBOLBKGP(LCELNNMJEBA MAIGGPEPIHD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMBFKHNEMFD(EHIJPMKNJBK FDNIDHBNFHE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMBFKHNEMFD(BLIJJMIHMBP MKAKNMKKKCL);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NNFNKCCOAFC(BLIJJMIHMBP MKAKNMKKKCL);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OFDFAKOOFLH(BLIJJMIHMBP MKAKNMKKKCL);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNMEELGFOJP();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DHPIFKJJIKF();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LNIELFBEDJK(EHIJPMKNJBK FDNIDHBNFHE, IHDDPGHJDNB MAIGGPEPIHD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BHDAHOKPEDG(BLIJJMIHMBP MKAKNMKKKCL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CEIGLMOABEP(BLIJJMIHMBP MKAKNMKKKCL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DGFBKADOKLJ();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CINEEABIPEB(IHDDPGHJDNB MAIGGPEPIHD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KJOAHLPFFOI(EHIJPMKNJBK FDNIDHBNFHE, Vector3 MOLOGMFNACJ, Vector3 EEGHGGIIJAI, Vector3 GEILLOANDMH, float FJHGOOKMPPK, float MFOMDDFNLGE, IReadOnlyList<Camera> EOPJLFAKFEK, BKBCNJMNLMC HDNIPLAAELF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KJOAHLPFFOI(JNCMLKGNEOC BEIAGFDIEDG, Vector3 MOLOGMFNACJ, Vector3 EEGHGGIIJAI, Vector3 GEILLOANDMH, float FJHGOOKMPPK, float MFOMDDFNLGE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BMEMPFINILP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PBHPHGEEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHIJPMKNJBK IAMOLCIBHHH(AGEEDABPPLL AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHIJPMKNJBK IAMOLCIBHHH(AGEEDABPPLL AMHCLKHIFKH, bool BKHBIPKMJJC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOMLMFDJDPP(EHIJPMKNJBK FDNIDHBNFHE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFOKJNJBJGN(EHIJPMKNJBK FDNIDHBNFHE);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BLIJJMIHMBP BGGPFLAPKCM(EHIJPMKNJBK FDNIDHBNFHE, ILFCNFCNGEH AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BLIJJMIHMBP NFCGMHDIAKD(EHIJPMKNJBK FDNIDHBNFHE, EBHGEGCEOOD AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCALPPONJEG(BLIJJMIHMBP MKAKNMKKKCL);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALCOGEDADJM(BLIJJMIHMBP MKAKNMKKKCL);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JNCMLKGNEOC BCJMOFNBAHH(NIPGDLEDPEO AMHCLKHIFKH);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GKEEOKNICLL(JNCMLKGNEOC BEIAGFDIEDG);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HHAJHLGCKIJ(JNCMLKGNEOC BEIAGFDIEDG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task HEACHELJCHF();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task PFENOOGPMJA();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task KMAJKKHHDOH();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GLHAPCNGDDN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> KCDAGCABODE(EHIJPMKNJBK FDNIDHBNFHE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OBHKKKOHCDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum LDKEEEJHKMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum LDMAJFGDNGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum AAMFEKAGNAI
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		RefreshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum CNLIBPJKHEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum EAGEPLKOJKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum KEMBAGIADJA
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum IBJCOKFHKHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum CNDNCALJONL
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		JustAvatarMeshLod = 101
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool BPHBINLGBHA;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long LFMFGMDDJKK;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool CEAOIOFDBGJ;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool BFNGFMDDKJE;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool KJFIJGPCPOG;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float BBKLPKMINDG;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float KMCDDJIAPCH;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int AOGNDDFMBDL;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static KEMBAGIADJA NGKIBCHKPIO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long KOFKOBOBKED;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float BLEEGPBGFAN;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int LOJMOLAPFNI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int HMFOEOECJDA;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int HJOFJHAMGFB;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int IBHIKOEGANO;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int DKOCPDJCKFF;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int OMDKBPCJCOK;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int IEKKNCCAFGK;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int CFHCGFJJDOF;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool KLOCNFGHLBO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int KIJEEEPGHOF;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int GJBEKJNMKKB;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int EFMIPOCBAHD;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool CADKHBJLAIK;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float KOIELDNMDNH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool ICJIKGEMELI;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float JLPJCHGLLJJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static float DLJLMHJBEIJ;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool KGDIFLHDANL;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long EELMGBPELJC;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int ALEPINPFLMJ;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool HCFEGGICHLM;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static LDKEEEJHKMB PBHOIHLGOOK;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool MCCHMEKEENJ;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool GGJEGNBIAAB;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int HIHFGOIFBBC;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int EELIBBNJBPP;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int JHPDPNFCHNA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int KFDIEHFDOFG;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int OHEBOJPPPMI;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int INOFOGDMHHI;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int DKLBCMMHPEG;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int GFMKGPFDIKA;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float NCCOFODJPIM;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float KPCPDMHFIJL;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float DPMEFBELCGE;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static int PIAAFPNIBPI;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int ACEDKGHENIB;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int CCIALMGMCAH;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int ACHGBPOHECC;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static bool CNENONLOEPF;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static AAMFEKAGNAI LJDOKBGJCHM;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static CNLIBPJKHEN OCBDHHKEJFK;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static bool HMAGKDDNFJH;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static LDMAJFGDNGL DKKLNFFPOLH;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static float NLKLJCCGOLK;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float OBIOJLALGDB;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float EKGNBGDILHM;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float APBBIMEDHHL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float OCKFIDBAGFI;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float IMJDGHEPBLO;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float AOONELNBBMM;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float IHLGKFEFOGP;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static bool KNBHPFOGKKO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static IBJCOKFHKHF IODHEBBCAFK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static bool GKBLBMPGIJL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static float AIFECKNANAJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float JOIPBDKGCDI;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float AAPLBHHOHHO;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float PDHNCANMOOL;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float EINBEMABNGH;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static bool ELIEIEHHCDP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static long KBAJOMLDODI;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static float HONJHIMOFKC;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float DMOGMKLFENH;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float LHIIAMGPEKN;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static int HDLBGHCCBJF;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static float ELLDPKGIPEH;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static bool OPAILFKIMGG;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static long HHIJDLIGIOA;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static int EJHENEHIJCL;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int GLONPMNBIAG;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static float PLJFCBINBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float HCHEGBBBDBM;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static bool KEENPFMAGBG;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool DNFKDBAOHDA;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static float NAHMCPOBHLF;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long FMDEIMFAIMG;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long MKBBMHJPONM;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static int GKEECMHMHJD;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static float4x4 HANGCDJOLEA;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float3 FOCKDPIHCEK;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static bool LMMOPNAGFEF;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static EAGEPLKOJKP AHMAHPIAGAC;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static long HCIICGBMCNP;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static int HAEJMNHBFDD;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int OJIMICJFKJC;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int GBDLLGHLNOI;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int LHEBDAKPPON;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static long NBCPCGPPFIA;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static long DDBICLEKPJE;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int CBIFEMJEMOM;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int FOCLNFEGIDK;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int AJPGCBCPEHG;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static long JHKDJOLBCIA;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long BKMHFFFLEMG;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long JHGEGMOFKCC;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long NCCMLNPKKBP;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int EBGDCBPHBCG;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int OKKFIOCLHMO;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int BDBDOHLHOAA;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int HFADJONFJAE;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int[] HHNBKBDPCEE;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int AIPBNPBDEBG;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long LHHLMEJJOOE;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long NDINMPDNAJO;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static int DCILAIHOPEA;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int PBJCJFEJDGF;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static long BFOGMPPDGEE;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long KJDGCIGJPHL;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long HBMNDBHLJGC;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long EJEFJIJEAFF;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long EMAGMGEMAGB;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long KLDGFHPJIGO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long LJDBCGGBFAB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long COIKOKMKBFH;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long NPFNIOBCAMP;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static float APHLDHOOMFO;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static long NMMLPNLJJEF;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static int HBLPFCFJILJ;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long OHLNLPMBFAB;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long AJOHOFLKHJN;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static float PFNOFJADLCJ;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long LAFKNADHDHG;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long DAGKJJNNEED;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long JBDKECBKAGK;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long NMMDDEEEBAK;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long LIGCFAMMIGH;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long JCBMFOHCCAH;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long KHNJMLJNDAD;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long AFFPEOJHIHO;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long HKDOOGACEMB;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long OPDHKKIEPPF;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long LEICOBIFFLG;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long BBFNOIFECPI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static CNDNCALJONL HKMAEGEAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7985F60", Offset = "0x7985360", VA = "0x187985F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long LDNAGKMDHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7986570", Offset = "0x7985970", VA = "0x187986570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7985FB0", Offset = "0x79853B0", VA = "0x187985FB0")]
	public static void LHGGMDMNHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x79865D0", Offset = "0x79859D0", VA = "0x1879865D0")]
	public static void NBNOGMDCDLG(CNDNCALJONL GCFJEOAIBAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class PELJGPNBBOB
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct ELCJAAJMMPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Vector3 CPGAKMJDLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public Quaternion DBFFJKGJHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public float NHGCPPGEOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Quaternion IBOICCEMMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public float BAPLKDNDEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float PEJINGBGIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public float PFJOAEMLIFE;
	}

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static List<ELCJAAJMMPE> CPIAJGMNNKF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7987EF0", Offset = "0x79872F0", VA = "0x187987EF0")]
	public static NativeList<HDHHCFJCJDP> CEADGENKFMF(MPAIKKNNIGN FPBOMPOFMAK)
	{
		return default(NativeList<HDHHCFJCJDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7989B90", Offset = "0x7988F90", VA = "0x187989B90")]
	private static bool MPKOOCNOAHC(int EAOFLAGMNJO, NativeList<HDHHCFJCJDP> KGODHHBLJOE, List<ELCJAAJMMPE> NNBDIDMOBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7988490", Offset = "0x7987890", VA = "0x187988490")]
	private static HDHHCFJCJDP DNPCKKNHCHF(int MGJOIMHBHJO, List<ELCJAAJMMPE> NNBDIDMOBNM)
	{
		return default(HDHHCFJCJDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x798AA20", Offset = "0x7989E20", VA = "0x18798AA20")]
	private static HDHHCFJCJDP NMFMHDOAFBE(int MGJOIMHBHJO, List<ELCJAAJMMPE> NNBDIDMOBNM)
	{
		return default(HDHHCFJCJDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7989AB0", Offset = "0x7988EB0", VA = "0x187989AB0")]
	private static HDHHCFJCJDP KGEMJCDKCCO(Vector3 FPPHNHEFIKD, Quaternion GJCDHPPPAHJ, float MCIPFGHOGIP)
	{
		return default(HDHHCFJCJDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7988610", Offset = "0x7987A10", VA = "0x187988610")]
	public static NativeList<HDHHCFJCJDP> FDHFHNPNPFG(MPAIKKNNIGN FPBOMPOFMAK, float DHGDGMFHOGL)
	{
		return default(NativeList<HDHHCFJCJDP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IFGAPPGBMNK
{
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public static Vector3 HHHNCMGMLOH;

	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public static Vector3 EHFAAFLEFML;

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public static readonly float LIKJFHPOJKJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7984D80", Offset = "0x7984180", VA = "0x187984D80")]
	public static Vector3 FOEJDDJJJDE(Vector3 LDHBDDLFKME, Quaternion GJCDHPPPAHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x79850A0", Offset = "0x79844A0", VA = "0x1879850A0")]
	public static Vector3 GPKBIKKNGAP(Quaternion BENMKDDDBDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7985000", Offset = "0x7984400", VA = "0x187985000")]
	public static Vector3 GNPBLDKFFHE(Quaternion BENMKDDDBDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7984D00", Offset = "0x7984100", VA = "0x187984D00")]
	public static Quaternion FKBOEPOCBLP(Vector3 DLBKBBJEBDD, Vector3 HAKFDJFOEPG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7985140", Offset = "0x7984540", VA = "0x187985140")]
	public static Vector3 JBHECNJJFGC(Vector3 MLCJNMBHLKP, Vector3 IBGKHAEFHOA, Vector3 HAKFDJFOEPG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7985620", Offset = "0x7984A20", VA = "0x187985620")]
	public static Vector3 LLHBDJIHLIM(Vector3 LDHBDDLFKME, Vector3 HAKFDJFOEPG, Quaternion BENMKDDDBDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7985A50", Offset = "0x7984E50", VA = "0x187985A50")]
	public static Quaternion OJJBOOBKEKL(Quaternion GJCDHPPPAHJ, Vector3 DLBKBBJEBDD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7984B80", Offset = "0x7983F80", VA = "0x187984B80")]
	public static bool CHDIDPMNADB(Vector3 MIHLGENMDAB, Vector3 ICFMLILMNIO, [Out] Vector3 ANPPJJPEOGE, bool GDHJJDNOPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7985330", Offset = "0x7984730", VA = "0x187985330")]
	public static Vector3 LKKDFOCHLKM(bool LIIBEIBOMNA, [Optional] Quaternion PMAGJANGEHJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HDHHCFJCJDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public float3 CPGAKMJDLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public float3x3 DBFFJKGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public float NHGCPPGEOLG;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MPAIKKNNIGN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int HIJPCHJBGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 LKFLIBJJIFD(int MGJOIMHBHJO);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion OKGBBABFCKA(int MGJOIMHBHJO);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float MLEHACGIKNA(int MGJOIMHBHJO);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EBHGEGCEOOD : JGBANNPBHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MDIAOHMEJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool FHCNLEOHCDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float NLLEBINNLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int MFBGJBMKHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool ACBBAMDHNCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int EDBPAHEHPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<HDHHCFJCJDP> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ILFCNFCNGEH : JGBANNPBHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MADKHAHICNA LPGDLIDPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool JMEGBOFNJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 CBKHPAAGKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AGEEDABPPLL
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AKBPOJOBHNP GFBMHFBKABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	BCPFADGNNNB OKJMMBHENKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JGBANNPBHOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CFMOGMFPPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OBOCKGJDDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AKBPOJOBHNP GFBMHFBKABC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS KGCHFOHNEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float OGGMHHPDKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 HAPNJPNOAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	OCHPJGPHIOB LNAOHCEGPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FECNNNMEDDD FAHBJLLFCJB
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
public interface NIPGDLEDPEO
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int HCCKHEPHAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform CKBNDGALHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool CPPKCGIELIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHIJPMKNJBK GetBone(int MGJOIMHBHJO);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MGJOIMHBHJO);
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
