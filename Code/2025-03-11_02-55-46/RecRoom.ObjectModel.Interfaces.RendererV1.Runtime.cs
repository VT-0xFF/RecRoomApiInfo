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
public enum GPHMAOOCDBD
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
public enum MOCNBIDPOEK
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
public enum HFCKMPNMIEL
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
public enum GKDDANMGOBF
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
public enum OPHICPAGLCD
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
public enum KJLMKLABEMK
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
public static class IKEKKACJAFF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x77592F0", Offset = "0x77586F0", VA = "0x1877592F0")]
	public static bool DPMCHDCKFNP(this KJLMKLABEMK NPJNOPHGDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7759310", Offset = "0x7758710", VA = "0x187759310")]
	public static bool JCHCLKCKCBH(this KJLMKLABEMK NPJNOPHGDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7759320", Offset = "0x7758720", VA = "0x187759320")]
	public static bool NJEDAHBDPGH(this KJLMKLABEMK NPJNOPHGDLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KOCPEJPPMDN
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
public struct AKCJCIIMEDH : AOLNDNNNENI, IEquatable<AKCJCIIMEDH>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int NGGCGOFGPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int NGJHPPMLGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE380", Offset = "0x2BED780", VA = "0x182BEE380", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF10", Offset = "0x68AC310", VA = "0x1868ACF10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DAHIKGIHLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77560A0", Offset = "0x77554A0", VA = "0x1877560A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x16EE6E0", Offset = "0x16EDAE0", VA = "0x1816EE6E0", Slot = "8")]
	public bool Equals(AKCJCIIMEDH MNALNBMKJLK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x34AE540", Offset = "0x34AD940", VA = "0x1834AE540")]
	public static bool JECEAGOPPKI(AKCJCIIMEDH FJLJDCJDABK, AKCJCIIMEDH DOGHGFGEHNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7756010", Offset = "0x7755410", VA = "0x187756010", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x77560E0", Offset = "0x77554E0", VA = "0x1877560E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NPNDLLJKHLE : AOLNDNNNENI, IEquatable<NPNDLLJKHLE>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int NGGCGOFGPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int NGJHPPMLGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE380", Offset = "0x2BED780", VA = "0x182BEE380", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF10", Offset = "0x68AC310", VA = "0x1868ACF10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DAHIKGIHLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x775F100", Offset = "0x775E500", VA = "0x18775F100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x16EE6E0", Offset = "0x16EDAE0", VA = "0x1816EE6E0", Slot = "8")]
	public bool Equals(NPNDLLJKHLE MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x775F070", Offset = "0x775E470", VA = "0x18775F070", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x775F140", Offset = "0x775E540", VA = "0x18775F140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DODOBBJGFOD : AOLNDNNNENI, IEquatable<DODOBBJGFOD>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NGGCGOFGPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NGJHPPMLGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE380", Offset = "0x2BED780", VA = "0x182BEE380", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF10", Offset = "0x68AC310", VA = "0x1868ACF10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DAHIKGIHLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7756200", Offset = "0x7755600", VA = "0x187756200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x16EE6E0", Offset = "0x16EDAE0", VA = "0x1816EE6E0", Slot = "8")]
	public bool Equals(DODOBBJGFOD MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7756170", Offset = "0x7755570", VA = "0x187756170", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NCIAIDEDLKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOHCHJIMCNC(AKCJCIIMEDH HAIKBOLEOOP, MOCNBIDPOEK BCKCGEMHPKH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOHCHJIMCNC(NPNDLLJKHLE JEMGJFMDIND, MOCNBIDPOEK BCKCGEMHPKH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPPNNGNBGIE(NPNDLLJKHLE JEMGJFMDIND);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APHJCKJIFNO(NPNDLLJKHLE JEMGJFMDIND);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKNIALHLKJB();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGJHBLNOFPK(MOCNBIDPOEK ANONBNLNHHL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJAPAAFFKMF(AKCJCIIMEDH HAIKBOLEOOP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GJAPAAFFKMF(NPNDLLJKHLE JEMGJFMDIND);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AJLIBEPJKCP(NPNDLLJKHLE JEMGJFMDIND);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FKPBGHFPLAE(NPNDLLJKHLE JEMGJFMDIND);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IEJAIBIFINF();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ADLHKJOFDND();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HIPJBGHHGKE(AKCJCIIMEDH HAIKBOLEOOP, OPHICPAGLCD ANONBNLNHHL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HLGMGMJHNIH(NPNDLLJKHLE JEMGJFMDIND);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BNOCODEDENH(NPNDLLJKHLE JEMGJFMDIND);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EHENCFPJEJP();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GGJDHNKMNCP(OPHICPAGLCD ANONBNLNHHL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ODLHNDOMIFJ(AKCJCIIMEDH HAIKBOLEOOP, Vector3 MCJBMGDADNO, Vector3 CEPGAHEEDED, Vector3 AGACFJHPJFM, float KLAFAOEPLMC, float GHGDGFGCMAG, IReadOnlyList<Camera> NFKPNJENAHI, GPHMAOOCDBD IBLPGGJBLLJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ODLHNDOMIFJ(DODOBBJGFOD FEICGOKBKOM, Vector3 MCJBMGDADNO, Vector3 CEPGAHEEDED, Vector3 AGACFJHPJFM, float KLAFAOEPLMC, float GHGDGFGCMAG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FKAMLBHGFOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ICNJALFIDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKCJCIIMEDH KHBIHIAEFBP(BLGBNPJNFFP MJFOKKFMONL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AKCJCIIMEDH KHBIHIAEFBP(BLGBNPJNFFP MJFOKKFMONL, bool EMHMGKKFNOD);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJOMAOFCNKE(AKCJCIIMEDH HAIKBOLEOOP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJKCEDHHAOD(AKCJCIIMEDH HAIKBOLEOOP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NPNDLLJKHLE CNOHJDJGOCE(AKCJCIIMEDH HAIKBOLEOOP, DPDHDNPDHKE MJFOKKFMONL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NPNDLLJKHLE EJACKLDNAML(AKCJCIIMEDH HAIKBOLEOOP, OMEBILIEOAO MJFOKKFMONL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EMCKNEJKDDO(NPNDLLJKHLE JEMGJFMDIND);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HCMDNCOGDAF(NPNDLLJKHLE JEMGJFMDIND);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DODOBBJGFOD NDEEMECMEGC(EDLJHIFFFPK MJFOKKFMONL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HEKDHBNFIJH(DODOBBJGFOD FEICGOKBKOM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HNHICPLIDKJ(DODOBBJGFOD FEICGOKBKOM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task MHCBKAPHMPJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task IJCECJKCGFL();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task INCACHKKJJF();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HIMCACAACKI();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> OJNPHIMBDOP(AKCJCIIMEDH HAIKBOLEOOP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KOJAIIFHDDN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum PJICKOABBKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum HOPLHOKOCAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum IHNMFOPAJDO
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		RefreshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum BHEDOCOKNIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum IMNMEANHEEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum DHGCHLLLNCL
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum DAFHGGGBBKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum DMGJMKHOFMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		LAST = 102
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool HBPPGFPEDBL;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static long JEDJPKEPGLN;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool ACPPIBAKMAF;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static float MILFFNCNHEJ;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static float BBLHJFEPDKO;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static bool OBHCCHKMAJA;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static long CPEGLMDFJLC;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static int DLNJKFIHGFJ;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static bool EJLKAKLEDOM;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static HOPLHOKOCAB NOJCIIHCDEL;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float BEAIGDFGKHD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static float LKBCHPHNCDM;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static bool GBNLIGCHJDD;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static DAFHGGGBBKN DGMPEODHBBI;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static bool EDAIFDMGCGK;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float EAEMHFCEONF;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float DOGAOEIIILA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float NAGEBIGHFEL;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float EGHJLPACGLO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static float NGBEPMHAOLK;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static long LLDEFLOJFAI;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static long FFLCHPHFIOE;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int NGDKGHGONJK;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool DJBAHOIDOHK;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long MFDPHHKAKCP;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static long DBKBLFMMDMB;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static int BMGMKCEIEOI;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static long PDAHGKKHBKG;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int GAPMFLKCPMP;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int KFPKPOCJLDN;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int MEHNNFHAEOM;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int IPCGFCBPNML;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long FDLHCECNHJE;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static long MDOPKPDPAHD;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int NEFDBIBBMDN;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int AKOPENIIFDE;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int DBBHELKLPMH;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long JFNPCLIIAEM;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long FKMHGAPPDAN;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long IKGNKAFOCIB;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long IPDFJLKFILA;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int KICGBIECMOE;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int AKECCDNOPGO;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int HEAKELHCPNP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int AGDDCCNDIIL;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int[] LDOEOMPCFNO;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static int HDPLHHFLBJN;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long GLKODCFMOCP;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static long EFDGNKAKIPK;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int FMFPNPGMJCK;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long HNIJFNNOMND;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long MCMAIDIMEAC;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long HHHFOHMLNGL;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long KBPBDAMELJJ;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long BJHNGPJEENP;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long EABKNDLHNKH;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long LHOGIFEHMDB;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long DMOMPBANLPE;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long FPNHNCOAJCF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float IGFEOOGHKLM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long JOCFNPMBJEO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static int NHMLKEMDBPO;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long GPCHIPNMANK;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long KELCBPMEGCD;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static float ADNBKKNEJEE;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long MOOHEBHDGKN;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long JAIJOAIDAHA;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long EDKDFDEBMAP;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long DGABCPPBABH;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long AAAMOCPBDFK;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long FAIHCGGIJMJ;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long NJINCFCMGFG;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long DHLIAMIGPHB;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long CMBPNMDMCIC;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long JEENMPKLBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long DFGCOMEODCO;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long BMMMNOHNOOL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool EDPBIBFIEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x775C330", Offset = "0x775B730", VA = "0x18775C330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x775C5B0", Offset = "0x775B9B0", VA = "0x18775C5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static DMGJMKHOFMK DHEOCLFLENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x775C420", Offset = "0x775B820", VA = "0x18775C420")]
		[CompilerGenerated]
		get
		{
			return default(DMGJMKHOFMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x775C560", Offset = "0x775B960", VA = "0x18775C560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool BLJGBDEDKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x775AC00", Offset = "0x775A000", VA = "0x18775AC00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x775AB00", Offset = "0x7759F00", VA = "0x18775AB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool CLCODCMDLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x775E5B0", Offset = "0x775D9B0", VA = "0x18775E5B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x775AEE0", Offset = "0x775A2E0", VA = "0x18775AEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float FAMGMJAAENG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x775B840", Offset = "0x775AC40", VA = "0x18775B840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x775E4A0", Offset = "0x775D8A0", VA = "0x18775E4A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float KCEAEHKKIPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x775B150", Offset = "0x775A550", VA = "0x18775B150")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x775C060", Offset = "0x775B460", VA = "0x18775C060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int FKKDIOLPKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x775E3B0", Offset = "0x775D7B0", VA = "0x18775E3B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7759550", Offset = "0x7758950", VA = "0x187759550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static DHGCHLLLNCL FMDCCOOKFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x775E560", Offset = "0x775D960", VA = "0x18775E560")]
		[CompilerGenerated]
		get
		{
			return default(DHGCHLLLNCL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x775C650", Offset = "0x775BA50", VA = "0x18775C650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long AIDLFHPCDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x775ABB0", Offset = "0x7759FB0", VA = "0x18775ABB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x775C0C0", Offset = "0x775B4C0", VA = "0x18775C0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float IDEMKHOFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x775B410", Offset = "0x775A810", VA = "0x18775B410")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x775B930", Offset = "0x775AD30", VA = "0x18775B930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int DDKEJAGINOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x775CB30", Offset = "0x775BF30", VA = "0x18775CB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x775B0A0", Offset = "0x775A4A0", VA = "0x18775B0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int IMNBHGCINHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x775B6D0", Offset = "0x775AAD0", VA = "0x18775B6D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x775C950", Offset = "0x775BD50", VA = "0x18775C950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int BKEJEOCNHJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x775A7A0", Offset = "0x7759BA0", VA = "0x18775A7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x775AE40", Offset = "0x775A240", VA = "0x18775AE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int IFIEMLBLCPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x775BF60", Offset = "0x775B360", VA = "0x18775BF60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x775A7F0", Offset = "0x7759BF0", VA = "0x18775A7F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int BGPJMIPKCCD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x775C470", Offset = "0x775B870", VA = "0x18775C470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x775C600", Offset = "0x775BA00", VA = "0x18775C600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int HMFHGOJGCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x775C180", Offset = "0x775B580", VA = "0x18775C180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x775E450", Offset = "0x775D850", VA = "0x18775E450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int FDBOAMFOKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x775BF10", Offset = "0x775B310", VA = "0x18775BF10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x775BAE0", Offset = "0x775AEE0", VA = "0x18775BAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int AAKPKMAHKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x775B310", Offset = "0x775A710", VA = "0x18775B310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x775BFB0", Offset = "0x775B3B0", VA = "0x18775BFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static bool KHEGHNCHEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x775A750", Offset = "0x7759B50", VA = "0x18775A750")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int NPCAGLPIOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x775CF40", Offset = "0x775C340", VA = "0x18775CF40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x775CEF0", Offset = "0x775C2F0", VA = "0x18775CEF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int KLKMDELCBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x775B5B0", Offset = "0x775A9B0", VA = "0x18775B5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x775AB60", Offset = "0x7759F60", VA = "0x18775AB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int NIKOCGAIFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x775C510", Offset = "0x775B910", VA = "0x18775C510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x775CAE0", Offset = "0x775BEE0", VA = "0x18775CAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static bool FGPLEEGNPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x775C7A0", Offset = "0x775BBA0", VA = "0x18775C7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x775CE90", Offset = "0x775C290", VA = "0x18775CE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float CPNMOAIKBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x775CB80", Offset = "0x775BF80", VA = "0x18775CB80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x775B360", Offset = "0x775A760", VA = "0x18775B360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool DFBAMNHCFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x775C3D0", Offset = "0x775B7D0", VA = "0x18775C3D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x775B780", Offset = "0x775AB80", VA = "0x18775B780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool BKLCPALBGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x775B460", Offset = "0x775A860", VA = "0x18775B460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x775B1A0", Offset = "0x775A5A0", VA = "0x18775B1A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static PJICKOABBKA HINMGLMJHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x775E300", Offset = "0x775D700", VA = "0x18775E300")]
		[CompilerGenerated]
		get
		{
			return default(PJICKOABBKA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x775CC20", Offset = "0x775C020", VA = "0x18775CC20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool FBGHNDJHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7759450", Offset = "0x7758850", VA = "0x187759450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x775BC90", Offset = "0x775B090", VA = "0x18775BC90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int NNLGPDEGFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x775BEC0", Offset = "0x775B2C0", VA = "0x18775BEC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x775BB80", Offset = "0x775AF80", VA = "0x18775BB80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int HLDOJHHMFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x775AFA0", Offset = "0x775A3A0", VA = "0x18775AFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x775B2B0", Offset = "0x775A6B0", VA = "0x18775B2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int HLBIPOBNHII
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x775B260", Offset = "0x775A660", VA = "0x18775B260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x775C120", Offset = "0x775B520", VA = "0x18775C120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int PKKDCPGFKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x775BC40", Offset = "0x775B040", VA = "0x18775BC40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x775CA20", Offset = "0x775BE20", VA = "0x18775CA20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int AFOHPNIANIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x775AFF0", Offset = "0x775A3F0", VA = "0x18775AFF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x775C8F0", Offset = "0x775BCF0", VA = "0x18775C8F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int EALGHDFKOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x775CFE0", Offset = "0x775C3E0", VA = "0x18775CFE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x775BE60", Offset = "0x775B260", VA = "0x18775BE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int AJINJLAJDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x775B4B0", Offset = "0x775A8B0", VA = "0x18775B4B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x775BBE0", Offset = "0x775AFE0", VA = "0x18775BBE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static int FMBLBHBFKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x77593A0", Offset = "0x77587A0", VA = "0x1877593A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x775AD90", Offset = "0x775A190", VA = "0x18775AD90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float NIDCPLLADJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x775E400", Offset = "0x775D800", VA = "0x18775E400")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x775AF40", Offset = "0x775A340", VA = "0x18775AF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float FOOAPIGLMLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x775C220", Offset = "0x775B620", VA = "0x18775C220")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x775ACB0", Offset = "0x775A0B0", VA = "0x18775ACB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float BIKFLPNAEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x775C7F0", Offset = "0x775BBF0", VA = "0x18775C7F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x775E2A0", Offset = "0x775D6A0", VA = "0x18775E2A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int JKNLAHBMLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x775AA60", Offset = "0x7759E60", VA = "0x18775AA60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x775A9B0", Offset = "0x7759DB0", VA = "0x18775A9B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int MMKEAJPMENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x775C840", Offset = "0x775BC40", VA = "0x18775C840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x775B7E0", Offset = "0x775ABE0", VA = "0x18775B7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int ABCHMHIOFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x775C750", Offset = "0x775BB50", VA = "0x18775C750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x775A8A0", Offset = "0x7759CA0", VA = "0x18775A8A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int HGOJNONHABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x775CCD0", Offset = "0x775C0D0", VA = "0x18775CCD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x775CDD0", Offset = "0x775C1D0", VA = "0x18775CDD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static bool EEMGCJALPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x775CBD0", Offset = "0x775BFD0", VA = "0x18775CBD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x775BCF0", Offset = "0x775B0F0", VA = "0x18775BCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static IHNMFOPAJDO CJPIFHGJHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x775BA30", Offset = "0x775AE30", VA = "0x18775BA30")]
		[CompilerGenerated]
		get
		{
			return default(IHNMFOPAJDO);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x775B720", Offset = "0x775AB20", VA = "0x18775B720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static BHEDOCOKNIL POLMOPNJGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7759350", Offset = "0x7758750", VA = "0x187759350")]
		[CompilerGenerated]
		get
		{
			return default(BHEDOCOKNIL);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x775E350", Offset = "0x775D750", VA = "0x18775E350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool PJOEEEIDMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x775AE90", Offset = "0x775A290", VA = "0x18775AE90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x775AC50", Offset = "0x775A050", VA = "0x18775AC50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static float FAKPIBBKCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x775B560", Offset = "0x775A960", VA = "0x18775B560")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x775C6F0", Offset = "0x775BAF0", VA = "0x18775C6F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float CODLOMFNGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x775C4C0", Offset = "0x775B8C0", VA = "0x18775C4C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x775BA80", Offset = "0x775AE80", VA = "0x18775BA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float GEBPBPEFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x775CD20", Offset = "0x775C120", VA = "0x18775CD20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x775B500", Offset = "0x775A900", VA = "0x18775B500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float APLAMPIAADM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x775C380", Offset = "0x775B780", VA = "0x18775C380")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x775B200", Offset = "0x775A600", VA = "0x18775B200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float AHJKIHDAPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x775B890", Offset = "0x775AC90", VA = "0x18775B890")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x775C2D0", Offset = "0x775B6D0", VA = "0x18775C2D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static float DNJONHHALKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x775AA10", Offset = "0x7759E10", VA = "0x18775AA10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x775BE00", Offset = "0x775B200", VA = "0x18775BE00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static bool KBHMIEOIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x775BD50", Offset = "0x775B150", VA = "0x18775BD50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x775CE30", Offset = "0x775C230", VA = "0x18775CE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float KGCIDMFPKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x775CC80", Offset = "0x775C080", VA = "0x18775CC80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x775C890", Offset = "0x775BC90", VA = "0x18775C890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float ANOFGMHAAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x775B3C0", Offset = "0x775A7C0", VA = "0x18775B3C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x775C000", Offset = "0x775B400", VA = "0x18775C000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static float NGJCPFNLAED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x775AAB0", Offset = "0x7759EB0", VA = "0x18775AAB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x775A840", Offset = "0x7759C40", VA = "0x18775A840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static int GMJEKJCGFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x775B8E0", Offset = "0x775ACE0", VA = "0x18775B8E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x775C270", Offset = "0x775B670", VA = "0x18775C270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static float KCKNKNPMICM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x775B990", Offset = "0x775AD90", VA = "0x18775B990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static bool IPEMHNIFLDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x775C1D0", Offset = "0x775B5D0", VA = "0x18775C1D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x775B0F0", Offset = "0x775A4F0", VA = "0x18775B0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static int NKOLPGJPCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x775BB30", Offset = "0x775AF30", VA = "0x18775BB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x77594A0", Offset = "0x77588A0", VA = "0x1877594A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static float GDLPPGGNJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x775C6A0", Offset = "0x775BAA0", VA = "0x18775C6A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x775CD70", Offset = "0x775C170", VA = "0x18775CD70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float DHLCLMEGFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x775CF90", Offset = "0x775C390", VA = "0x18775CF90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x775BDA0", Offset = "0x775B1A0", VA = "0x18775BDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static bool MLDAKCPDLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x775A900", Offset = "0x7759D00", VA = "0x18775A900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x775A950", Offset = "0x7759D50", VA = "0x18775A950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static float KAPLOGMGIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x775ADF0", Offset = "0x775A1F0", VA = "0x18775ADF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x775B040", Offset = "0x775A440", VA = "0x18775B040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static long DIPGJDHPANP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x775CA80", Offset = "0x775BE80", VA = "0x18775CA80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static float4x4 HNMFNKGLKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x775AD10", Offset = "0x775A110", VA = "0x18775AD10")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x775C9A0", Offset = "0x775BDA0", VA = "0x18775C9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static float3 CAIMAOCBPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x775B660", Offset = "0x775AA60", VA = "0x18775B660")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x77593F0", Offset = "0x77587F0", VA = "0x1877593F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static bool ECCNIIGDCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7759500", Offset = "0x7758900", VA = "0x187759500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x775B600", Offset = "0x775AA00", VA = "0x18775B600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public static IMNMEANHEEF FMDLDIAIBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x775B9E0", Offset = "0x775ADE0", VA = "0x18775B9E0")]
		[CompilerGenerated]
		get
		{
			return default(IMNMEANHEEF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x775E500", Offset = "0x775D900", VA = "0x18775E500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x77595A0", Offset = "0x77589A0", VA = "0x1877595A0")]
	public static void AIBPCHIJPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x775D030", Offset = "0x775C430", VA = "0x18775D030")]
	public static void OHHPKHAAPBE(DMGJMKHOFMK NGOLBJEIOLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FGCPKJOEODB
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct HDALPKMGAOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Vector3 LLLAMAJMODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Quaternion ANFMFACGGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public float AAEBALPFOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public Quaternion GJKNGPGMNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public float PBPPBMJLALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float KGAIGOHOIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float MPBLGIFIPNA;
	}

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static List<HDALPKMGAOP> FHJHOFLDBIN;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7757E30", Offset = "0x7757230", VA = "0x187757E30")]
	public static NativeList<PDDAJOGDNBJ> NMAHKKJEENH(DGNOLDGACPB CJCGNOCJOEE)
	{
		return default(NativeList<PDDAJOGDNBJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x77583D0", Offset = "0x77577D0", VA = "0x1877583D0")]
	private static bool PKHFACLELAA(int ILOCIBNKPPB, NativeList<PDDAJOGDNBJ> HOCIBOCHCFJ, List<HDALPKMGAOP> DHPDJFAKLDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7756240", Offset = "0x7755640", VA = "0x187756240")]
	private static PDDAJOGDNBJ ABFGFMGLMIG(int HHHJLAPJJLA, List<HDALPKMGAOP> DHPDJFAKLDE)
	{
		return default(PDDAJOGDNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x77563C0", Offset = "0x77557C0", VA = "0x1877563C0")]
	private static PDDAJOGDNBJ CIJFOAMMCJL(int HHHJLAPJJLA, List<HDALPKMGAOP> DHPDJFAKLDE)
	{
		return default(PDDAJOGDNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x77568B0", Offset = "0x7755CB0", VA = "0x1877568B0")]
	private static PDDAJOGDNBJ IDKIGDPPBDH(Vector3 PCEPJNOLMFA, Quaternion LAOJEKJKNBH, float EJOLINDBPPE)
	{
		return default(PDDAJOGDNBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7756990", Offset = "0x7755D90", VA = "0x187756990")]
	public static NativeList<PDDAJOGDNBJ> JDCKHEDBNDJ(DGNOLDGACPB CJCGNOCJOEE, float KMJIIPIPNEE)
	{
		return default(NativeList<PDDAJOGDNBJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PMJMIHMNDOE
{
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public static Vector3 APOBBJAKGGL;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 PNKDEBKKMIG;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static readonly float HJAIAOFECPB;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x775F940", Offset = "0x775ED40", VA = "0x18775F940")]
	public static Vector3 HMKOJILKPPO(Vector3 BJNBNHNHLEA, Quaternion LAOJEKJKNBH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x775F8A0", Offset = "0x775ECA0", VA = "0x18775F8A0")]
	public static Vector3 GLHGLIGAMMG(Quaternion NBFJKGINHEC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x775F800", Offset = "0x775EC00", VA = "0x18775F800")]
	public static Vector3 FKJIOGMKPKK(Quaternion NBFJKGINHEC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x775F1D0", Offset = "0x775E5D0", VA = "0x18775F1D0")]
	public static Quaternion AKIGGIFEFCH(Vector3 HEBBPJGOPIH, Vector3 BLIFKOEAPLP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7760210", Offset = "0x775F610", VA = "0x187760210")]
	public static Vector3 MCPBPKOLEHG(Vector3 PNGFHNFICDM, Vector3 FOFIFGOGEPG, Vector3 BLIFKOEAPLP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x775F250", Offset = "0x775E650", VA = "0x18775F250")]
	public static Vector3 CCEMDICKBHN(Vector3 BJNBNHNHLEA, Vector3 BLIFKOEAPLP, Quaternion NBFJKGINHEC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x775FBC0", Offset = "0x775EFC0", VA = "0x18775FBC0")]
	public static Quaternion JPCEAFFOOJD(Quaternion LAOJEKJKNBH, Vector3 HEBBPJGOPIH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x775F680", Offset = "0x775EA80", VA = "0x18775F680")]
	public static bool DEINOIKFGLF(Vector3 AMGIMEGKNEO, Vector3 LDBDECNNOII, [Out] Vector3 FHEKDKNIDEI, bool IIKDOKHHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x775FF20", Offset = "0x775F320", VA = "0x18775FF20")]
	public static Vector3 JPKMMICPOBH(bool PFJJKKMLDEF, [Optional] Quaternion KGDFCNLMHCM)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PDDAJOGDNBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public float3 LLLAMAJMODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3x3 ANFMFACGGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float AAEBALPFOGL;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DGNOLDGACPB
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int AJLPJLAMMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 IPFNAAMBIGH(int HHHJLAPJJLA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion KJIBFGPOEJM(int HHHJLAPJJLA);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float DJFGKJDHDMD(int HHHJLAPJJLA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OMEBILIEOAO : EOFEGJKNAFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool PLJCMFPPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool FIPBCFDKLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float CLHDCFNLLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int GLHONEOHMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool IGPBMMLECKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	int IAAIAHDJLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<PDDAJOGDNBJ> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DPDHDNPDHKE : EOFEGJKNAFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	HFCKMPNMIEL CGMBAGGALBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool FFBKPPJOMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 NJMFKPOPIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BLGBNPJNFFP
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	ANJIJJGNKJL KCFIKHGOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GKDDANMGOBF CEGAMGNEMPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EOFEGJKNAFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool BDFIIFNIPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool KHJIDCFMGOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	ANJIJJGNKJL KCFIKHGOCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	UniformTRS KIBAFNEGAIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float MNHDCLFKGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Vector3 HPJGMBFIHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	KJLMKLABEMK FBENEAPJIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	KOCPEJPPMDN CACFGNFDHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EDLJHIFFFPK
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	int HDBCFKDBFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Transform HJFCIFCIMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool IAFJBCAMCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AKCJCIIMEDH GetBone(int HHHJLAPJJLA);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int HHHJLAPJJLA);
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
