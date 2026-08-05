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
public enum EPEOJONAFBI
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
public enum EHMIJFGJLBH
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
public enum ALLMNIBKHFE
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
public enum AKINJEDNFNM
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
public enum IEHEPMCODHJ
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
public enum BEIEMLGIDNI
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
public static class CIMFMIPBPKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x854EA00", Offset = "0x854D800", VA = "0x18854EA00")]
	public static bool KIOJGHBBJFO(this BEIEMLGIDNI HELEFKLFCJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x854E9F0", Offset = "0x854D7F0", VA = "0x18854E9F0")]
	public static bool FLEKIAPBBOE(this BEIEMLGIDNI HELEFKLFCJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x854E9C0", Offset = "0x854D7C0", VA = "0x18854E9C0")]
	public static bool EJMLNDFHHPA(this BEIEMLGIDNI HELEFKLFCJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PFNNFGPAHBA
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
public struct AIOBPENNHGA : JNOBALCJGHO, IEquatable<AIOBPENNHGA>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int NELPMDCEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x300A170", Offset = "0x3008F70", VA = "0x18300A170", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x300A160", Offset = "0x3008F60", VA = "0x18300A160", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HCIMLNOEIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x854B850", Offset = "0x854A650", VA = "0x18854B850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x13E9210", Offset = "0x13E8010", VA = "0x1813E9210", Slot = "8")]
	public bool Equals(AIOBPENNHGA FGAEAFBDBPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF76E0", Offset = "0x3CF64E0", VA = "0x183CF76E0")]
	public static bool IKIADGFKNFC(AIOBPENNHGA GENJGFGGINA, AIOBPENNHGA KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x854B7C0", Offset = "0x854A5C0", VA = "0x18854B7C0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x854B890", Offset = "0x854A690", VA = "0x18854B890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KCPCCONBFEI : JNOBALCJGHO, IEquatable<KCPCCONBFEI>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int NELPMDCEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x300A170", Offset = "0x3008F70", VA = "0x18300A170", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x300A160", Offset = "0x3008F60", VA = "0x18300A160", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HCIMLNOEIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x854FE80", Offset = "0x854EC80", VA = "0x18854FE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x13E9210", Offset = "0x13E8010", VA = "0x1813E9210", Slot = "8")]
	public bool Equals(KCPCCONBFEI FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x854FDF0", Offset = "0x854EBF0", VA = "0x18854FDF0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x854FEC0", Offset = "0x854ECC0", VA = "0x18854FEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JOCJDJNIODG : JNOBALCJGHO, IEquatable<JOCJDJNIODG>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NELPMDCEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x300A170", Offset = "0x3008F70", VA = "0x18300A170", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x300A160", Offset = "0x3008F60", VA = "0x18300A160", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HCIMLNOEIII
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x854FDB0", Offset = "0x854EBB0", VA = "0x18854FDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x13E9210", Offset = "0x13E8010", VA = "0x1813E9210", Slot = "8")]
	public bool Equals(JOCJDJNIODG FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x854FD20", Offset = "0x854EB20", VA = "0x18854FD20", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CNCKGAMCPLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJLMNHKBGKI(AIOBPENNHGA MMENCBNBOBJ, EHMIJFGJLBH FNIKNONFPHG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJLMNHKBGKI(KCPCCONBFEI ADPIMLAGACM, EHMIJFGJLBH FNIKNONFPHG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKNCIJEBKDP(KCPCCONBFEI ADPIMLAGACM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEEJFMDOKPC(KCPCCONBFEI ADPIMLAGACM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBMOLOOALMB();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEIAGMPBGFB(EHMIJFGJLBH ADGMECOLKNH);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EKGPCJOGAFH(AIOBPENNHGA MMENCBNBOBJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EKGPCJOGAFH(KCPCCONBFEI ADPIMLAGACM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JOLJGCNGIEF(KCPCCONBFEI ADPIMLAGACM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IBGIOGNBFJG(KCPCCONBFEI ADPIMLAGACM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MNKBDCNGHIO();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IPKIFCMFDOO();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MANNKGLPGHM(AIOBPENNHGA MMENCBNBOBJ, IEHEPMCODHJ ADGMECOLKNH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GDNDIBDOOPF(KCPCCONBFEI ADPIMLAGACM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IEAKBPDAGJB(KCPCCONBFEI ADPIMLAGACM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FFGIAIJAHHP();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EAIDDCAECNI(IEHEPMCODHJ ADGMECOLKNH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KMBDHGPMMIP(AIOBPENNHGA MMENCBNBOBJ, Vector3 BFLEHPDKJDC, Vector3 MIANHKJJJDC, Vector3 FLFKHAKCAHC, float NHKAFPMDINO, float LEPKEOKNGCF, IReadOnlyList<Camera> DKPDKPBPAPM, EPEOJONAFBI JNPOLDJJOIO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KMBDHGPMMIP(JOCJDJNIODG JGIOJIOGBJM, Vector3 BFLEHPDKJDC, Vector3 MIANHKJJJDC, Vector3 FLFKHAKCAHC, float NHKAFPMDINO, float LEPKEOKNGCF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DBDEJHBHIBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DEFMFMGHCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIOBPENNHGA OAFJDPCFEBF(IAJEINKKMII KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIOBPENNHGA OAFJDPCFEBF(IAJEINKKMII KANAIIDGHCH, bool KAJPJOKDAJG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NICKHCPLNGJ(AIOBPENNHGA MMENCBNBOBJ);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AJNDLCBPPOK(AIOBPENNHGA MMENCBNBOBJ);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KCPCCONBFEI GNINEJNLKDG(AIOBPENNHGA MMENCBNBOBJ, EFOEIEPCHCP KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KCPCCONBFEI HHHJOLIMKJM(AIOBPENNHGA MMENCBNBOBJ, BJPNHFEILJG KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MPLGBLJFEKL(KCPCCONBFEI ADPIMLAGACM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JEFFOACGFOK(KCPCCONBFEI ADPIMLAGACM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JOCJDJNIODG DODPHCCHLBO(ELHKINMILFE KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CDIKDFAHGGA(JOCJDJNIODG JGIOJIOGBJM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GJNIAJCDKMO(JOCJDJNIODG JGIOJIOGBJM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task LNOIOICHMDG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task GCNPHGDCJOI();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EJAFGFLEAAH();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PPDDGKAGKBB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> MNKLHPACOBJ(AIOBPENNHGA MMENCBNBOBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MPBMLNGJCCN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum LMFNKBMPDIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum BFNGOCKCLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum DOPBJPGHGAA
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
	public enum ACMFMCLPEGI
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
	public enum MGPOOPAAMJB
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
	public enum OJJFDCOKAPE
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
		CheckPassive,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum JMBBOKLDEBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum BNHBGBOLGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		LowQualityHighSpeed = 102,
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		SpreadsheetSettings = 103
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool IMIILCMPLBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long FJHDEOGMJGD;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool BKECJIEFFOI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool FPHBNKLPEEM;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool MPJHKBOFACC;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float EHMGKDPKEJH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float DEJKPAOAHNM;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int NAKIFOHPFCM;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static OJJFDCOKAPE LGFOGPKPEED;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long OAKDCOAPGGP;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float EMJNBLIEILF;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int PDNGPJGEODG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int PCENCKCFHGH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int OHDIBMIHLDK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int CPFHEJMKOPN;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int KJFMFOMOJLL;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int ADLBFJCPMOC;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int NBNBFKNMEPF;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int AAOKGIGDOCJ;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool LDJPLADEPGO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int KHFFLFIBBGO;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int CAJKLMPIJAI;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int FPLEEJLLFPH;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool JJFBONMJLCB;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float JLLJMACGFFK;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool GNCANBJPDEB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float DLMGCGKPMAJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long KAGHEFILMPC;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool BDCJHCLNOCI;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long FOBOJEOEDAN;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int EBPDAIIMIIN;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool IOIGCEHOCFP;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static LMFNKBMPDIK BAIDBGEKNMN;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool INAKGEFHCNE;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool EOELIEOENJP;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int LNKOFEAMKME;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int GHPIEAHMBDK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int LKIHLPADOOL;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int JFBHIMJCIBK;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int HANPEBDNHOE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int NPOHGGKFKJL;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int LPKACNEBELO;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int IMJAFCBLOCK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float BBBFBBFFHAK;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float ICINNEFEKAG;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float NHCGLPLPMCB;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float JHPLJBMFOIN;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int DKPDIKEJIAJ;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int COBGDOKHCDE;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int MEKMDBNCNGO;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int ODCKKAMBDAG;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool JOBJIGHJHHC;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static DOPBJPGHGAA ENKAAALCIBI;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static ACMFMCLPEGI FOMFHJAPBHJ;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool ANKKIEDGJIK;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static BFNGOCKCLDJ IJMJKNEMACF;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float HMKOEFPBDNO;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float NMPMPMAPKGG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float BPFJPCHFLLD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float IMFGDMBOOHJ;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float JLPFMBKHKHI;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float PLNMMCCFMBK;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float FJHBHENNBOE;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float BAICKMPAFDD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool JMJHKDKGHPF;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static JMBBOKLDEBG ILKKEDLGILL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool HNCNPALNFJC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float HCPKGOLJBIE;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float DMENONJKIOO;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float CIMPMGHJHCM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float CNOJHCCHDHD;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float POOFCICIEDF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool OKFBMPFFCCC;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long GAAMMNFNNEK;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float KPEJMFEDKAG;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float ACAABAEIJIF;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float OLEEMJEDBKN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int LBAFMPCKOCP;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float ONKBCHHOOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool HGFONAGHFEK;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long OPPHPCHHJPB;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int PHFAJNHAELF;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int GMGJFMOLDML;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float POICFKGLDED;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float DHJDGMHMAIH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool BALEONOFHOL;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool GOPPKDBKPNC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float KLJKIKAALCN;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long GKAAGNLFMGI;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long OLBOGAKMMHC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int LAHPBIMHFDE;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static bool FNCCDCNDIFL;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float JHOFAEBFDDI;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static float PHDAEAHGKOK;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static bool AKBNDPBCKKC;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long NBKDGEAKHEL;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int JEFBOEOGKDK;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static float4x4 NEJPLMONPKK;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static float3 KDELPJLDKEM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static bool MIFLJDEBMAG;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static MGPOOPAAMJB HCFPAIABHAL;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long KANIDMJKCNH;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int FIDJGLKGFEL;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int JDCJKJJEGPN;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int HKDKBLDLGJJ;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int LJCNENINEHN;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int GHCDPCJPPNF;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int IMLHCKNLOCH;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int MNAGONEKEMA;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long LIBIJPMLHEA;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int JAMIJBEIKNH;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int PLLCFNIONIF;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int FCDABCMOBDP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long FGLFOBOLKIL;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long KBOEHCNIODK;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long HMOJAFFEJPA;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long CJEOENDKHME;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int DECEMNOLEAI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int BPBFLEGNIOF;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static int DBBEKDALBAJ;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static int ADBLKINKMGN;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int LKIEOOOKOFC;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int[] ANEPHJGFKEC;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int[] DLIOKKBJNGH;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static int GBKLAGPOICN;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long NOEHEFLDLFG;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long CNJMPGFGALE;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int KPHCJOBCNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static int JGBMJEIFPDM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long MODCCCPIKBG;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long IDCEICAMMCE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long JJNAJJNJAOP;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long BIJEKELDOMN;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long HPLNHEBHJOF;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long EDGAGKBLHNL;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long DHKMLEKEENN;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long MINMAALLEFE;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long JHFNPHPCGOD;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float EPNACMBFHHN;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static float GPGLGJNLKLM;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long LLGPKJJIEBG;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static int GJKAGPHKEAB;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long CEPMOCHMAEO;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long ENHPPNKLDBJ;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static float IEHKIJLBBGI;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long EDKNCBHHBPI;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long PPLJALEIBCJ;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long EBJFDIIJDFC;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long NPIFPHODLAM;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long IEFDADODMLI;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long LKDIICLHMFG;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static long CBJJJMBJPJC;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static long OKOAMKDOCKP;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static long BDJIKFNBMBC;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static long OGOBIFGPCEG;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static long BELDCJOPPLG;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static long HMKBALKHDOJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static BNHBGBOLGAJ OEDODCOCNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x854FFB0", Offset = "0x854EDB0", VA = "0x18854FFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long AKENKEEJPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x854FF50", Offset = "0x854ED50", VA = "0x18854FF50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8550000", Offset = "0x854EE00", VA = "0x188550000")]
	public static void NEJLPEEMONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85505D0", Offset = "0x854F3D0", VA = "0x1885505D0")]
	public static void NPOLFLAJKPL(BNHBGBOLGAJ ECGODIPEMNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class APMHBJMPCED
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct NDDNBOPHMOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Vector3 FEDKKAIHHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Quaternion NFKDICNPCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public float OMNLGPDGNFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Quaternion HBJMCCIDFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public float OOAOJPKCNOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public float DPKBGOKLFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public float EMMLHBHDBPB;
	}

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static List<NDDNBOPHMOI> LFCHFGNACCG;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x854B920", Offset = "0x854A720", VA = "0x18854B920")]
	public static NativeList<BPLOOPPGBOJ> CBPPOGPMBJO(FKOGGCMOAEH NLCAIENELJM)
	{
		return default(NativeList<BPLOOPPGBOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x854D350", Offset = "0x854C150", VA = "0x18854D350")]
	private static bool GACMCPFOODH(int IEHMHPMCGJK, NativeList<BPLOOPPGBOJ> MOBFLOHJOKJ, List<NDDNBOPHMOI> EDNBKBFLIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x854E1E0", Offset = "0x854CFE0", VA = "0x18854E1E0")]
	private static BPLOOPPGBOJ KBJNEKOHMEL(int ENMBFMACLBN, List<NDDNBOPHMOI> EDNBKBFLIDL)
	{
		return default(BPLOOPPGBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x854E360", Offset = "0x854D160", VA = "0x18854E360")]
	private static BPLOOPPGBOJ MDMMACOPMHP(int ENMBFMACLBN, List<NDDNBOPHMOI> EDNBKBFLIDL)
	{
		return default(BPLOOPPGBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x854E850", Offset = "0x854D650", VA = "0x18854E850")]
	private static BPLOOPPGBOJ ONBGAGIMHKA(Vector3 EEIHHMMODIJ, Quaternion MIKLOIFFBNA, float GDMMFIOGDOL)
	{
		return default(BPLOOPPGBOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x854BEB0", Offset = "0x854ACB0", VA = "0x18854BEB0")]
	public static NativeList<BPLOOPPGBOJ> CLMDICHIDBF(FKOGGCMOAEH NLCAIENELJM, float HMCLNEMGELD)
	{
		return default(NativeList<BPLOOPPGBOJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JNDMKPFFGCG
{
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static Vector3 PPPCJNKNIKK;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static Vector3 LCLHGNPJFDH;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly float OEBINGBHIKD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x854F5A0", Offset = "0x854E3A0", VA = "0x18854F5A0")]
	public static Vector3 KGAKGADGHAG(Vector3 EOAHLCHJMLB, Quaternion MIKLOIFFBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x854F300", Offset = "0x854E100", VA = "0x18854F300")]
	public static Vector3 FMJLNPNBDPA(Quaternion GKEKGHNHKDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x854F260", Offset = "0x854E060", VA = "0x18854F260")]
	public static Vector3 CHMHJPLKLNM(Quaternion GKEKGHNHKDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x854F3A0", Offset = "0x854E1A0", VA = "0x18854F3A0")]
	public static Quaternion GPLDKKABDJC(Vector3 GHKIAFFJCCO, Vector3 INIBGDOOLID)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x854F070", Offset = "0x854DE70", VA = "0x18854F070")]
	public static Vector3 CEGKKOOMNOE(Vector3 DPCCMGDOOAC, Vector3 OLKAJICOBEP, Vector3 INIBGDOOLID)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x854F820", Offset = "0x854E620", VA = "0x18854F820")]
	public static Vector3 MFLBIBDKOLE(Vector3 EOAHLCHJMLB, Vector3 INIBGDOOLID, Quaternion GKEKGHNHKDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x854EA20", Offset = "0x854D820", VA = "0x18854EA20")]
	public static Quaternion BJGNCBJOOJO(Quaternion MIKLOIFFBNA, Vector3 GHKIAFFJCCO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x854F420", Offset = "0x854E220", VA = "0x18854F420")]
	public static bool IEEBIGJHNOA(Vector3 EJKHBKEEOMA, Vector3 JKGICJAFEBB, [Out] Vector3 PKLKGOJFOJC, bool AKPDKHPLCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x854ED80", Offset = "0x854DB80", VA = "0x18854ED80")]
	public static Vector3 BPAOINDKKCG(bool HDMJNLNGAFI, [Optional] Quaternion KGHIJIPBGGC)
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
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float heightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public PFNNFGPAHBA topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public PFNNFGPAHBA slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct TerrainWaterProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public bool WaterEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public float WaterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public Color WaterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Color DeepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public float EmissiveStrength;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public OKJBFJAHLKK baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public bool normalizeLayerHeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public ACLPPFGLGKG playArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public float playAreaOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public TerrainWaterProperties globalWaterProperties;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8552110", Offset = "0x8550F10", VA = "0x188552110")]
		public TerrainGenerationInfo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct TerrainInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public float GroundHeight;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ANGIPIJNOFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	TerrainData AGMCNHBFBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject PIOIFEDIEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 DFNFMLOMPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float3 GOBGFDJEFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float3 HJBKNMGGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	TerrainGenerationInfo NOJOAKLIHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	TerrainInfo NMBICACIJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> GDJOHCIMFGO(uint OBHMPCHHOEA, bool DDAJBGDIJGA = true, bool NMMIDNEDGMM = true, bool HCNJAHHGIBH = true, [Optional] TerrainGenerationInfo NLCAIENELJM, EHDFGPGLBEF COPNBOBBCNO = EHDFGPGLBEF.Default, [Optional] float3? CKCBMCPBDFA, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MFDBANBONAB(bool BOFILMMADCE);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DLKAGANGIKC(Action<Material> GACEKADOLIE);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BPLOOPPGBOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public float3 FEDKKAIHHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public float3x3 NFKDICNPCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public float OMNLGPDGNFC;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FKOGGCMOAEH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int DHHCGIIAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NOCDEKHCDBD(int ENMBFMACLBN);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion BIACCLOOCPB(int ENMBFMACLBN);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float LMOCCLDMNMH(int ENMBFMACLBN);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BJPNHFEILJG : MONDPKCLBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MMAFJLPBMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ELNOMNBHNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float NHMOGDAJDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int LHMNAJNKKII
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ODKBFDHHBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int FAMCMJKNHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<BPLOOPPGBOJ> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EFOEIEPCHCP : MONDPKCLBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ALLMNIBKHFE MAGKOPHJOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool AHHEHKEPPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float3 PFIKAFHIICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface IAJEINKKMII
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FHLDPOMNGOB DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AKINJEDNFNM ANPDCELFGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MONDPKCLBPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CGJEENDEDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DIIEPBJKDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	FHLDPOMNGOB DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	UniformTRS DCOLBIMJBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float COJIMGECPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 FFCDFGOHDFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	BEIEMLGIDNI LCPFEJLGACM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	PFNNFGPAHBA KCLNKHFNJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ELHKINMILFE
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int JHHBKBIMNLO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Transform DNMBIBNLFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool PGKENCDGPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIOBPENNHGA GetBone(int ENMBFMACLBN);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int ENMBFMACLBN);
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
