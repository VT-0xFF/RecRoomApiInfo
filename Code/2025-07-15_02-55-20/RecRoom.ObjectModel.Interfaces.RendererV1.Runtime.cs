using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation.Mathematics;
using RecRoom.RendererV1.Terrain;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PGIDKEHBCFN
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
public enum HEODKAOIMMP
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
public enum GKNAEPKFNMA
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
public enum EMCDMLHOHNO
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
public enum KEFCOOGBPIF
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
public enum HEEBNBDCPDH
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
public static class OMMHMLJKNCL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x82C8920", Offset = "0x82C7520", VA = "0x1882C8920")]
	public static bool ODPFDGCOGIL(this HEEBNBDCPDH GNNJAKNCLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x82C88E0", Offset = "0x82C74E0", VA = "0x1882C88E0")]
	public static bool CILKPIABFCB(this HEEBNBDCPDH GNNJAKNCLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82C88F0", Offset = "0x82C74F0", VA = "0x1882C88F0")]
	public static bool EJFOAAMELKA(this HEEBNBDCPDH GNNJAKNCLCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BNIMJFMEDEA
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
public struct ILKDGFHCBCG : PDCJNGLGLLH, IEquatable<ILKDGFHCBCG>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int CLIFKJOPCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int IJGCLEGIDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3119BD0", Offset = "0x31187D0", VA = "0x183119BD0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E6AD40", Offset = "0x6E69940", VA = "0x186E6AD40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BGMCAGMEELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82C7450", Offset = "0x82C6050", VA = "0x1882C7450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1357FA0", Offset = "0x1356BA0", VA = "0x181357FA0", Slot = "8")]
	public bool Equals(ILKDGFHCBCG IIOGPDPGOLB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A8F0", Offset = "0x3D294F0", VA = "0x183D2A8F0")]
	public static bool CDGFDPOPEPC(ILKDGFHCBCG JPILOOHOBDJ, ILKDGFHCBCG MAKDDCFIOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82C7490", Offset = "0x82C6090", VA = "0x1882C7490", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82C7530", Offset = "0x82C6130", VA = "0x1882C7530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IFPPNNMCBNN : PDCJNGLGLLH, IEquatable<IFPPNNMCBNN>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CLIFKJOPCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int IJGCLEGIDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3119BD0", Offset = "0x31187D0", VA = "0x183119BD0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E6AD40", Offset = "0x6E69940", VA = "0x186E6AD40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BGMCAGMEELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82C72E0", Offset = "0x82C5EE0", VA = "0x1882C72E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1357FA0", Offset = "0x1356BA0", VA = "0x181357FA0", Slot = "8")]
	public bool Equals(IFPPNNMCBNN IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82C7320", Offset = "0x82C5F20", VA = "0x1882C7320", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82C73C0", Offset = "0x82C5FC0", VA = "0x1882C73C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ACNEEOBLODC : PDCJNGLGLLH, IEquatable<ACNEEOBLODC>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CLIFKJOPCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IJGCLEGIDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3119BD0", Offset = "0x31187D0", VA = "0x183119BD0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6AD40", Offset = "0x6E69940", VA = "0x186E6AD40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BGMCAGMEELL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82C4130", Offset = "0x82C2D30", VA = "0x1882C4130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1357FA0", Offset = "0x1356BA0", VA = "0x181357FA0", Slot = "8")]
	public bool Equals(ACNEEOBLODC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82C4170", Offset = "0x82C2D70", VA = "0x1882C4170", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ANFGPDFLLEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHHBEMJKJDP(ILKDGFHCBCG OLIIIAEGOLD, HEODKAOIMMP AFOHEDFHHBI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHHBEMJKJDP(IFPPNNMCBNN MIEJLCKINFM, HEODKAOIMMP AFOHEDFHHBI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOPDBMDPLPN(IFPPNNMCBNN MIEJLCKINFM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADLNNGHKOKC(IFPPNNMCBNN MIEJLCKINFM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGGHFIPCAPK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOEDBEBHALB(HEODKAOIMMP MDCDODCGNEK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHMAHDIHKDM(ILKDGFHCBCG OLIIIAEGOLD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HHMAHDIHKDM(IFPPNNMCBNN MIEJLCKINFM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PKGENKHHLBH(IFPPNNMCBNN MIEJLCKINFM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NHBGBDKPJCC(IFPPNNMCBNN MIEJLCKINFM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EJFBLFNNMKO();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JGDKIBECFMI();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NENAFNPCGOP(ILKDGFHCBCG OLIIIAEGOLD, KEFCOOGBPIF MDCDODCGNEK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KBEDNJEIEBB(IFPPNNMCBNN MIEJLCKINFM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BPKMMFFCMHJ(IFPPNNMCBNN MIEJLCKINFM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GOGKNFBMBNE();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JIHBPEBFBDG(KEFCOOGBPIF MDCDODCGNEK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NBDDCEMKDLC(ILKDGFHCBCG OLIIIAEGOLD, Vector3 EHGGEFBPAKP, Vector3 OOGFCPJNKHC, Vector3 LJBDBKJKCPJ, float MNGDAKKKENJ, float EOBEEFICDAI, IReadOnlyList<Camera> FEBDNCKKAFK, PGIDKEHBCFN HPKPAJMIMBN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NBDDCEMKDLC(ACNEEOBLODC JMLBNACNELK, Vector3 EHGGEFBPAKP, Vector3 OOGFCPJNKHC, Vector3 LJBDBKJKCPJ, float MNGDAKKKENJ, float EOBEEFICDAI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CDDCNNEAHAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MKGPMLFADPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILKDGFHCBCG IMPJDKAHLOH(CEIOAGBLDNK CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ILKDGFHCBCG IMPJDKAHLOH(CEIOAGBLDNK CBCNBAPLLJM, bool HGOHFGHFMED);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBLHPCMMBLL(ILKDGFHCBCG OLIIIAEGOLD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCHJFIJKDAI(ILKDGFHCBCG OLIIIAEGOLD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IFPPNNMCBNN MGAGOGOANIC(ILKDGFHCBCG OLIIIAEGOLD, IEBKPDHAODJ CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IFPPNNMCBNN LPAAANKKBDH(ILKDGFHCBCG OLIIIAEGOLD, FGNJANJHMFN CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AOAPGNIDBKG(IFPPNNMCBNN MIEJLCKINFM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBADAFPIKID(IFPPNNMCBNN MIEJLCKINFM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ACNEEOBLODC DIPMKNAEDAC(GCKIODIAKBG CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BPBOHHLMHAB(ACNEEOBLODC JMLBNACNELK);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NPDCOHKLKLN(ACNEEOBLODC JMLBNACNELK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task HIKDFPLPGBN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task KLJCIGNFFHE();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FPAPPGGLEMO();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GJFFFCBEHBB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> BCNCHGFCNJI(ILKDGFHCBCG OLIIIAEGOLD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PCGJEFDNNCC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum GDGPCOJEDJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum EGAGBCEGEDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum PMPPGJMKJOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		BatchColour,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		RefreshShapesBatchColour,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		RefreshBatchedMeshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum ODENFCBGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum JBPKAAMEJJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum LGNMLAGOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum FDEEPJDBLCK
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum JKKEPFBPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		LowQualityHighSpeed = 102
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool NIBKPJGLICF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long JNCCNOPFOAF;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool OPACHKNABJL;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool GKMDPAHMMLP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool IBNEBDIPEKD;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float PGCCNFJNNJE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float ICBPNEIGEMI;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int JEJCCBDLHDF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static LGNMLAGOIKF EOCKMBOGKGJ;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long JACDMPGCCEB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float BOGKAELLIJN;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int CDCKPOACLIE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int JKGIGBIFLAP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int EPELFCBHPKA;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int ICBIOBOGNAD;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int ANFGCMACDBP;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int AFANCFGJLCH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int OBBBHKEGOIJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int EMKCAPBNACB;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool CGGKNDLGHJA;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int CHCCFGLOKEE;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int EHMIFDCFLJF;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int IINFPNFOJID;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool DMNLBCAIBIG;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float INMIJMDLGAD;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool NBPHEFMILJE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float AKJDBBLHNFE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long FFPPFANJCIF;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool CKAANJCFELO;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long HJKFAHKKOJJ;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int NKBIAKHCKPK;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool JCCGJDGDHLL;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static GDGPCOJEDJM OAKAAMLOMJD;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool HDBMCCIFFLP;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool IGFHANJFIDA;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int GGNFNDGMHJH;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int ILIFBFFOJJC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int FPIJLMCIONH;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int HKKKOKBNNKM;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int NMNDAACMIDA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int AFJMPAANOGF;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int LCPLJCKCAEF;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int OMMIOMAFKKK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float EEDPAKLOPAD;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float EBMDDNLFBJL;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float EGJIJPHEINF;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float HGOAFKOEBEA;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int PKALFEBFKGH;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int INEHMKHMDEE;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int LCMGJJKLDFA;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int GLNALPHGCNE;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool PMAMMCIJGED;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static PMPPGJMKJOA LFACEOPMGKI;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static ODENFCBGNPO NFDHCOKPHJM;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool KFKHPDOJLEL;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static EGAGBCEGEDM ADOMCMPBAAN;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float BDDBFIEHEPO;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float DMAECMPOCDD;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float JCJIFHEMCOM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float NDNCFHLPNDF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float DMDGBJDPFKF;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float PNMBFNJJBPG;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float JADACHHCMIE;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float ONDBGDCOEKL;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool BCDJGNMANBP;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static FDEEPJDBLCK AAGFBDFNOFG;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool BLCKKIPJMMM;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float IKCHKNNEKJK;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float HNNNCEABMGH;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float OEPDILBJNAH;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float ALGPOJHCJLM;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float NMHNOLAOCAA;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool APEMONNEFLC;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long FJCBMIJLELO;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float GNMCPOKLGAC;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float CIEENHEEHMP;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float OFNCEPHAKNM;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int DFNOLBKIMBP;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float BLPGEHKIMOD;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool HIAGOJFENJN;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long PKDBLLHDKFJ;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int PBJHLHCKKFE;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int DINEBFONJII;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float KDMLBGGPKGE;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float ABNKHGMBKJN;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool LMLKHGGIDLH;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool NNHCPJLINGI;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float AMPNBJANDNB;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long HALEKNDGOJL;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long JIMNJHLLKIE;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int DHJCGMIOLEF;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static bool FMAFHIOOMLG;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float BJCJBBEPEEJ;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static float EGACEDJOFGB;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static bool PEEHDJKBLKP;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long LCKJOMGBOMH;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int MPHJHPFCILD;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static float4x4 FBHKJIKDIPI;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static float3 OLHCAEOOCJM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static bool GHLDGGLNKDO;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static JBPKAAMEJJK IFIAPHFKPNL;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long OFPFDGFPIPJ;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int GHMAAFBOAGP;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int NJGODEMJEBF;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int CONLHFJLJHE;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int HBAFDIOLPEC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int JDNHIGOHFPL;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int BMPLEICHACF;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int MILPDLFKKEK;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long HPNGMCLECKL;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int MCBCDMICOHG;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int JOCCIDFGMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int CHPJKIHCPIM;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long MDFJGDPJLDL;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long BCIOAPFJDLK;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long AAKAJKKEFAF;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long KPCGAGFKDPK;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int CEDMOIJLGDC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int FIEGBJINEPE;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static int OOEDNELCFMK;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static int MHNGIOPILJI;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int GKAAMFPGAJH;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int[] AEFFEMJOOLP;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int[] HNAPBLFIALH;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static int MMOABEPCLDB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long OFMCJMEIPAP;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long BKEJNMJDKBF;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int ADGELHMOCLF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static int DKGDICLEALE;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long GCLFAIBJFKF;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long HILKPOHMBNI;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long CCONFOEECLF;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long IKEPCMOFOAL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long ADBKAMDEMNO;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long KMCBDJIMHDD;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long MCFHANOIDNN;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long CBIKHGLFAAJ;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long OOAHDNDCAEG;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float PAOBFIMNPPN;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static float JHOMJJNBOCG;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long CPGCBKPMNPI;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static int GBFJNFEJENO;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long FCNEMBNBGHO;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long ABNGHDMFNIL;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static float JNFMIANLMBH;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long JIBBACIDKDG;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long KCMFBADEGGN;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long MNJIEPJELAH;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long CFLKIOELMGB;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long MCJMBFJMMIF;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long LECKHCBPJPM;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static long COPOPFOOPBC;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static long FKEJHAOAPBO;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static long PLACBNBIBOK;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static long EDDDNOLPHDN;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static long AJPELAEHKGB;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static long EJDGLFEBPCI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static JKKEPFBPPLC KHBOOJMAMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82C8940", Offset = "0x82C7540", VA = "0x1882C8940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long APFIMPEPMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82CA110", Offset = "0x82C8D10", VA = "0x1882CA110")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x82C9A60", Offset = "0x82C8660", VA = "0x1882C9A60")]
	public static void NJFNEJOBGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x82C89A0", Offset = "0x82C75A0", VA = "0x1882C89A0")]
	public static void LLCCNDKPFMF(JKKEPFBPPLC DAJHAIOLEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HEBIJBJAKOM
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct HJOMFBKAOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Vector3 BCBKGNPANPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Quaternion EFKBKJCNDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public float INHNPLLHFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Quaternion IKMAOFPHGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public float PANIDPOGAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public float ICMEGANENND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public float NJNMIANOEMK;
	}

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static List<HJOMFBKAOFN> NBNDBGKGAEJ;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82C5240", Offset = "0x82C3E40", VA = "0x1882C5240")]
	public static NativeList<FKNJJMFFJFL> HHADPJMAIEJ(KOACOFFPOFJ ACLFBNHJPDH)
	{
		return default(NativeList<FKNJJMFFJFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82C4390", Offset = "0x82C2F90", VA = "0x1882C4390")]
	private static bool GKAFOJAPGOL(int FLNKCEHIHDH, NativeList<FKNJJMFFJFL> ABEFNIJCBBN, List<HJOMFBKAOFN> MCLGOFPIMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82C4210", Offset = "0x82C2E10", VA = "0x1882C4210")]
	private static FKNJJMFFJFL DKOPMHPGMAM(int DFLLFMHMLAD, List<HJOMFBKAOFN> MCLGOFPIMFI)
	{
		return default(FKNJJMFFJFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82C6D60", Offset = "0x82C5960", VA = "0x1882C6D60")]
	private static FKNJJMFFJFL NEIKPJBIIKJ(int DFLLFMHMLAD, List<HJOMFBKAOFN> MCLGOFPIMFI)
	{
		return default(FKNJJMFFJFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82C57C0", Offset = "0x82C43C0", VA = "0x1882C57C0")]
	private static FKNJJMFFJFL LNFIDIFLFKM(Vector3 ALEIFNEHIBI, Quaternion HAGOIDNFICA, float BNDEJLLMNLK)
	{
		return default(FKNJJMFFJFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82C58A0", Offset = "0x82C44A0", VA = "0x1882C58A0")]
	public static NativeList<FKNJJMFFJFL> NBMPOILAJIK(KOACOFFPOFJ ACLFBNHJPDH, float DPMABOLPPPF)
	{
		return default(NativeList<FKNJJMFFJFL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class MCFCFONJPPE
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public static Vector3 DGMPDPGJAND;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static Vector3 NDFOADMPFJP;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static readonly float DGLGCBPMCJG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82C8350", Offset = "0x82C6F50", VA = "0x1882C8350")]
	public static Vector3 NHAFAIJNODB(Vector3 HKIBLDIPHCL, Quaternion HAGOIDNFICA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82C8760", Offset = "0x82C7360", VA = "0x1882C8760")]
	public static Vector3 PKIIOADHFDN(Quaternion DINDLKHALMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82C82B0", Offset = "0x82C6EB0", VA = "0x1882C82B0")]
	public static Vector3 LDHACFFBJCD(Quaternion DINDLKHALMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82C8230", Offset = "0x82C6E30", VA = "0x1882C8230")]
	public static Quaternion JLCKKBBPMOJ(Vector3 DBIJDHDPOAF, Vector3 JMBLGBJKENI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82C7D50", Offset = "0x82C6950", VA = "0x1882C7D50")]
	public static Vector3 JDJBMILFPBI(Vector3 FHDNKJHONKO, Vector3 JKAAAMHMEHG, Vector3 JMBLGBJKENI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82C7920", Offset = "0x82C6520", VA = "0x1882C7920")]
	public static Vector3 HAOEOKJFOON(Vector3 HKIBLDIPHCL, Vector3 JMBLGBJKENI, Quaternion DINDLKHALMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82C75C0", Offset = "0x82C61C0", VA = "0x1882C75C0")]
	public static Quaternion ALMGBDAAGNO(Quaternion HAGOIDNFICA, Vector3 DBIJDHDPOAF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82C85E0", Offset = "0x82C71E0", VA = "0x1882C85E0")]
	public static bool PIIDKEGLMDH(Vector3 PNPLPGNCIPG, Vector3 JIDKKNPMKOJ, [Out] Vector3 OBHOGLNHLFB, bool BIBFHOHHBDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82C7F40", Offset = "0x82C6B40", VA = "0x1882C7F40")]
	public static Vector3 JEFEOIKBHIE(bool IHHCJJDIFAJ, [Optional] Quaternion EILJPGEPLEB)
	{
		return default(Vector3);
	}
}
namespace RecRoom.RendererV1.Terrain
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct TerrainMaterialLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public float heightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public BNIMJFMEDEA topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public BNIMJFMEDEA slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public KCNHKGPCNMH baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public ICMOIJBHMPP playArea;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82CAEB0", Offset = "0x82C9AB0", VA = "0x1882CAEB0")]
		public TerrainGenerationInfo()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PODDMBHDAHI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	TerrainData GKGKIKCFLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject OEOPLHOMLDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<bool> IBCNECAHPPC(uint DLFHFKNPPFE, bool NJPIIMEJBNI = true, bool JBKKFCMHMKI = true, bool KJEONNGHJGN = true, [Optional] float3? BNHLHKCFAFK, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> IBCNECAHPPC(GJCBKPICDAM AOOBPNFOAEI, TerrainGenerationInfo ACLFBNHJPDH, bool JBKKFCMHMKI, bool KJEONNGHJGN, uint DLFHFKNPPFE, [Optional] float3? BNHLHKCFAFK, [Optional] CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCEOKDJFDMA(bool CBIKKBFNDHE);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NAJLGIGOHJM(Action<Material> HEDNAENGJDK);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct FKNJJMFFJFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public float3 BCBKGNPANPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public float3x3 EFKBKJCNDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public float INHNPLLHFOK;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KOACOFFPOFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int IDBMPGPCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JMDBPLFPMAI(int DFLLFMHMLAD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion EFKBJCHFLLA(int DFLLFMHMLAD);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float ICFANJNHMEE(int DFLLFMHMLAD);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FGNJANJHMFN : IDFFCAJFBJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool DHEBGNPKEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool JKMDJDJCGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float JPEGBLFKKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int IAAPJBOFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PFJLFFLPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int DOJIAPEBMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FKNJJMFFJFL> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IEBKPDHAODJ : IDFFCAJFBJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	GKNAEPKFNMA HCELMBEODLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool AIAIFDLKLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float3 CNAFFGNNJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CEIOAGBLDNK
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	MFFDCMMCMLL AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	EMCDMLHOHNO FNEFDBHFLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface IDFFCAJFBJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MPHJOIAJLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JJBFPDPLFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	MFFDCMMCMLL AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	UniformTRS KKCODHINOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float LOIJJKBLKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Vector3 OMCNAKDLEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HEEBNBDCPDH FDKBIMBJDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	BNIMJFMEDEA KFBNKNKFKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface GCKIODIAKBG
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int FOPHNEDFIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	Transform DBBGIEELAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OFKBCIPHGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ILKDGFHCBCG GetBone(int DFLLFMHMLAD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int DFLLFMHMLAD);
}
namespace Cpp2IlInjected
{
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
}
