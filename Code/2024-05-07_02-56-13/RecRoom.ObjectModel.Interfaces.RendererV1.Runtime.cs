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
public enum LGKBPELMOGA
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
public enum AAFKKJIDNGJ
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
public enum JDMFMBAEHAC
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
public enum ONEFMLCNCNN
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
public enum PLMNGBPDPGF
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
public enum PKCCLILNAJO
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
public static class GINGNALFMHI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62C1D10", Offset = "0x62C0F10", VA = "0x1862C1D10")]
	public static bool NPNKLEBBIAL(this PKCCLILNAJO INNOPDFFMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62C1CD0", Offset = "0x62C0ED0", VA = "0x1862C1CD0")]
	public static bool JAFGANEAGCP(this PKCCLILNAJO INNOPDFFMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62C1CE0", Offset = "0x62C0EE0", VA = "0x1862C1CE0")]
	public static bool NDBMLGIENCA(this PKCCLILNAJO INNOPDFFMFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CCCIGOAJIIL
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
public struct HAIIJFOILFO : CJGADGIIKPL, IEquatable<HAIIJFOILFO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int JPDBMMOIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int CIPMFJNCALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x238FDE0", Offset = "0x238EFE0", VA = "0x18238FDE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x561FD50", Offset = "0x561EF50", VA = "0x18561FD50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KMIBCIBKNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62C1E90", Offset = "0x62C1090", VA = "0x1862C1E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D54800", Offset = "0x1D53A00", VA = "0x181D54800", Slot = "8")]
	public bool Equals(HAIIJFOILFO NOBJAPGNDAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61B07A0", Offset = "0x61AF9A0", VA = "0x1861B07A0")]
	public static bool KEIKIALHENC(HAIIJFOILFO JPEEHDCLFEK, HAIIJFOILFO HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62C1ED0", Offset = "0x62C10D0", VA = "0x1862C1ED0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62C1F60", Offset = "0x62C1160", VA = "0x1862C1F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GKODJHFIOBB : CJGADGIIKPL, IEquatable<GKODJHFIOBB>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int JPDBMMOIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int CIPMFJNCALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x238FDE0", Offset = "0x238EFE0", VA = "0x18238FDE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x561FD50", Offset = "0x561EF50", VA = "0x18561FD50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KMIBCIBKNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62C1D30", Offset = "0x62C0F30", VA = "0x1862C1D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D54800", Offset = "0x1D53A00", VA = "0x181D54800", Slot = "8")]
	public bool Equals(GKODJHFIOBB NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62C1D70", Offset = "0x62C0F70", VA = "0x1862C1D70", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62C1E00", Offset = "0x62C1000", VA = "0x1862C1E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BKINCDHMIFM : CJGADGIIKPL, IEquatable<BKINCDHMIFM>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JPDBMMOIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CIPMFJNCALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x238FDE0", Offset = "0x238EFE0", VA = "0x18238FDE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x561FD50", Offset = "0x561EF50", VA = "0x18561FD50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KMIBCIBKNDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62C1C00", Offset = "0x62C0E00", VA = "0x1862C1C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D54800", Offset = "0x1D53A00", VA = "0x181D54800", Slot = "8")]
	public bool Equals(BKINCDHMIFM NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x62C1C40", Offset = "0x62C0E40", VA = "0x1862C1C40", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LEHHIHDEOOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMEGBFABJML(HAIIJFOILFO MIAAKEAGJGI, AAFKKJIDNGJ OBOFIGAGAMN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMEGBFABJML(GKODJHFIOBB BHDANKLFIDC, AAFKKJIDNGJ OBOFIGAGAMN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJNADEMBLML(GKODJHFIOBB BHDANKLFIDC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NEOFMBBJDEE(GKODJHFIOBB BHDANKLFIDC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCJPFOFELMD();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKPGFBNKJAC(AAFKKJIDNGJ FLPJMDMACMC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PCIBBPIKJOJ(HAIIJFOILFO MIAAKEAGJGI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PCIBBPIKJOJ(GKODJHFIOBB BHDANKLFIDC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BLCPKAJBMGP(GKODJHFIOBB BHDANKLFIDC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IMEPBFLEGEB(GKODJHFIOBB BHDANKLFIDC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FHKCDOJKNPE();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PNFIIDKPNDM();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LJCBJOEPIHK(HAIIJFOILFO MIAAKEAGJGI, PLMNGBPDPGF FLPJMDMACMC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IFNMNEGGFIB(GKODJHFIOBB BHDANKLFIDC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BBJPDLEGOLL(GKODJHFIOBB BHDANKLFIDC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NHFJOGNAMFN();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PPDBMKPPABA(PLMNGBPDPGF FLPJMDMACMC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LMIHJGNJLGJ(HAIIJFOILFO MIAAKEAGJGI, Vector3 NHOMPKFFNJL, Vector3 DOEFEOOCMEG, Vector3 GDKNHIKFPEC, float DFFLEPBGGHC, float NHMPINLDJDA, IReadOnlyList<Camera> HNCGFMGDMJO, LGKBPELMOGA KCOPBFCBGCM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LMIHJGNJLGJ(BKINCDHMIFM KLJPFCNPNEE, Vector3 NHOMPKFFNJL, Vector3 DOEFEOOCMEG, Vector3 GDKNHIKFPEC, float DFFLEPBGGHC, float NHMPINLDJDA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CNIMFFKCDKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EJGALBPBJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAIIJFOILFO AAOOEAFKMCM(MKMEMEMHMHI FODGEDCJIDC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAIIJFOILFO AAOOEAFKMCM(MKMEMEMHMHI FODGEDCJIDC, bool OAFPAAEGGFC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KONMGELIEHC(HAIIJFOILFO MIAAKEAGJGI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALDMCLKOCNB(HAIIJFOILFO MIAAKEAGJGI);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKODJHFIOBB CIPGNLAPPOH(HAIIJFOILFO MIAAKEAGJGI, GBIELNIHDPD FODGEDCJIDC);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GKODJHFIOBB IMKLFONANAG(HAIIJFOILFO MIAAKEAGJGI, IODJMNJFGBI FODGEDCJIDC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBIIBHMKHGK(GKODJHFIOBB BHDANKLFIDC);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LDDPDLHHNOP(GKODJHFIOBB BHDANKLFIDC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BKINCDHMIFM OIJAIJGEHIG(ABLFPBOBIAA FODGEDCJIDC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GKACMOIOGHL(BKINCDHMIFM KLJPFCNPNEE);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BPJLBFOPLBA(BKINCDHMIFM KLJPFCNPNEE);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task EGFNCGAJFMH();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task BPAAPNODFFL();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task DEFFKLLGOBD();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OEDEJMKGDAB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> HOCOILGFAJN(HAIIJFOILFO MIAAKEAGJGI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IOLNBMACAGE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum LGDAEPGPLLN
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
	public enum NJDKIHLBDDH
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum LBBJOAFBHGL
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
	public enum HONNHJOIKHO
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
	public enum JLKIEKHBBFF
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
	public static int NJKJDGAAJJE;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static int MPEJDPMGLIH;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static int DELJKKHJIFN;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static int HCIHNBMELMA;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int[] JGDLIAAOLKB;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int EBJGGBNIFGL;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int FLEPPLDKADH;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int LMFDJNILLJK;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static long BCJBHDHIOIM;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static long LDENBGMMJAE;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static long ODGBOCCOBIB;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static long DICIEBLLCFD;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long LBPDGKLHHOP;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long APABOJEPINC;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long MKFJOFHKIHI;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long CCNOLLCGKKB;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long MBOPHKGGLFP;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long KLFFPDKJOCG;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long GHFHHFHFJDC;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long FLPEGJFJBHJ;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float FFGEGGGPMAK;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static long HBEDFPAFLFG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long CHCNEPLKENN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static JLKIEKHBBFF HNHEFGJPKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62C31A0", Offset = "0x62C23A0", VA = "0x1862C31A0")]
		[CompilerGenerated]
		get
		{
			return default(JLKIEKHBBFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62C30F0", Offset = "0x62C22F0", VA = "0x1862C30F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool MEMEKCALEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62C26E0", Offset = "0x62C18E0", VA = "0x1862C26E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62C45E0", Offset = "0x62C37E0", VA = "0x1862C45E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static LGDAEPGPLLN BKOAPNIOKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62C3390", Offset = "0x62C2590", VA = "0x1862C3390")]
		[CompilerGenerated]
		get
		{
			return default(LGDAEPGPLLN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x62C3520", Offset = "0x62C2720", VA = "0x1862C3520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool BBKKLHACKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x62C32A0", Offset = "0x62C24A0", VA = "0x1862C32A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x62C2680", Offset = "0x62C1880", VA = "0x1862C2680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static NJDKIHLBDDH DBHDODJNLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x62C4690", Offset = "0x62C3890", VA = "0x1862C4690")]
		[CompilerGenerated]
		get
		{
			return default(NJDKIHLBDDH);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x62C2D30", Offset = "0x62C1F30", VA = "0x1862C2D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool OFCKBOPLCJC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62C4730", Offset = "0x62C3930", VA = "0x1862C4730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x62C41D0", Offset = "0x62C33D0", VA = "0x1862C41D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool GPGOAABPGND
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62C3610", Offset = "0x62C2810", VA = "0x1862C3610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x62C42D0", Offset = "0x62C34D0", VA = "0x1862C42D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool JOMBCACLOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62C4590", Offset = "0x62C3790", VA = "0x1862C4590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x62C2ED0", Offset = "0x62C20D0", VA = "0x1862C2ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static float HAAEPHFAAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62C46E0", Offset = "0x62C38E0", VA = "0x1862C46E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62C2F30", Offset = "0x62C2130", VA = "0x1862C2F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static int MDAJDCDCLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x62C2210", Offset = "0x62C1410", VA = "0x1862C2210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x62C2E30", Offset = "0x62C2030", VA = "0x1862C2E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int DBPCJIHCDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62C3250", Offset = "0x62C2450", VA = "0x1862C3250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x62C33E0", Offset = "0x62C25E0", VA = "0x1862C33E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int DPFFDNJIFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x62C25E0", Offset = "0x62C17E0", VA = "0x1862C25E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x62C2E80", Offset = "0x62C2080", VA = "0x1862C2E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int PIPACLIKNED
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x62C4780", Offset = "0x62C3980", VA = "0x1862C4780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x62C20B0", Offset = "0x62C12B0", VA = "0x1862C20B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int FDFPDPGKIKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62C2B30", Offset = "0x62C1D30", VA = "0x1862C2B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62C2980", Offset = "0x62C1B80", VA = "0x1862C2980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int GOLKOIJIGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x62C27E0", Offset = "0x62C19E0", VA = "0x1862C27E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x62C2630", Offset = "0x62C1830", VA = "0x1862C2630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int MFICFOOKOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62C2930", Offset = "0x62C1B30", VA = "0x1862C2930")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62C2540", Offset = "0x62C1740", VA = "0x1862C2540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int CFAMNDDIOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62C2730", Offset = "0x62C1930", VA = "0x1862C2730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x62C3660", Offset = "0x62C2860", VA = "0x1862C3660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int KFLCJHHMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62C2590", Offset = "0x62C1790", VA = "0x1862C2590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62C2830", Offset = "0x62C1A30", VA = "0x1862C2830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int JEKLANHIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62C2880", Offset = "0x62C1A80", VA = "0x1862C2880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62C3570", Offset = "0x62C2770", VA = "0x1862C3570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int KFMOIBONBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62C4280", Offset = "0x62C3480", VA = "0x1862C4280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62C2060", Offset = "0x62C1260", VA = "0x1862C2060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int PODDHFAIEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62C43D0", Offset = "0x62C35D0", VA = "0x1862C43D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62C2CE0", Offset = "0x62C1EE0", VA = "0x1862C2CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int IFGAEJPDABH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62C4330", Offset = "0x62C3530", VA = "0x1862C4330")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x62C2DE0", Offset = "0x62C1FE0", VA = "0x1862C2DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int FMGLIEHLILG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x62C2FF0", Offset = "0x62C21F0", VA = "0x1862C2FF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x62C32F0", Offset = "0x62C24F0", VA = "0x1862C32F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int BJHDMDIMAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62C40C0", Offset = "0x62C32C0", VA = "0x1862C40C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62C4380", Offset = "0x62C3580", VA = "0x1862C4380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool LHIJDEGJDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62C4640", Offset = "0x62C3840", VA = "0x1862C4640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62C2D80", Offset = "0x62C1F80", VA = "0x1862C2D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool IHNIFEBLOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62C2C90", Offset = "0x62C1E90", VA = "0x1862C2C90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62C4110", Offset = "0x62C3310", VA = "0x1862C4110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static LBBJOAFBHGL DEELNMCEMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62C2450", Offset = "0x62C1650", VA = "0x1862C2450")]
		[CompilerGenerated]
		get
		{
			return default(LBBJOAFBHGL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62C2C40", Offset = "0x62C1E40", VA = "0x1862C2C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool AEJHIEPNHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62C24A0", Offset = "0x62C16A0", VA = "0x1862C24A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62C2B80", Offset = "0x62C1D80", VA = "0x1862C2B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static float NDBDEAFNKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62C35C0", Offset = "0x62C27C0", VA = "0x1862C35C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62C4480", Offset = "0x62C3680", VA = "0x1862C4480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static float OGIABKBJPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x62C2400", Offset = "0x62C1600", VA = "0x1862C2400")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62C3140", Offset = "0x62C2340", VA = "0x1862C3140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static float OJELCPKCINK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62C3480", Offset = "0x62C2680", VA = "0x1862C3480")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62C2780", Offset = "0x62C1980", VA = "0x1862C2780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float JJHPPHIAHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62C4230", Offset = "0x62C3430", VA = "0x1862C4230")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62C4420", Offset = "0x62C3620", VA = "0x1862C4420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float BBKCKIPGFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62C3340", Offset = "0x62C2540", VA = "0x1862C3340")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62C2150", Offset = "0x62C1350", VA = "0x1862C2150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float BGBDCCAFCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62C22E0", Offset = "0x62C14E0", VA = "0x1862C22E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62C4170", Offset = "0x62C3370", VA = "0x1862C4170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool FGLMGEFFMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x62C2A90", Offset = "0x62C1C90", VA = "0x1862C2A90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62C3090", Offset = "0x62C2290", VA = "0x1862C3090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float ICBFCHLKICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62C3040", Offset = "0x62C2240", VA = "0x1862C3040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62C31F0", Offset = "0x62C23F0", VA = "0x1862C31F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static int BJPDACOJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62C3430", Offset = "0x62C2630", VA = "0x1862C3430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62C28D0", Offset = "0x62C1AD0", VA = "0x1862C28D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static int LHBDOPIKCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62C24F0", Offset = "0x62C16F0", VA = "0x1862C24F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62C2A30", Offset = "0x62C1C30", VA = "0x1862C2A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool DGEJEOPJEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62C2AE0", Offset = "0x62C1CE0", VA = "0x1862C2AE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int GDEANHFDGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62C2330", Offset = "0x62C1530", VA = "0x1862C2330")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62C29D0", Offset = "0x62C1BD0", VA = "0x1862C29D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static float4x4 IKELHFPDEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x62C2260", Offset = "0x62C1460", VA = "0x1862C2260")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62C2380", Offset = "0x62C1580", VA = "0x1862C2380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static float3 BDBGGAEBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62C1FF0", Offset = "0x62C11F0", VA = "0x1862C1FF0")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62C2F90", Offset = "0x62C2190", VA = "0x1862C2F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static bool OHDEJLIMFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x62C2100", Offset = "0x62C1300", VA = "0x1862C2100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62C2BE0", Offset = "0x62C1DE0", VA = "0x1862C2BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static HONNHJOIKHO JHCAFJGEJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x62C34D0", Offset = "0x62C26D0", VA = "0x1862C34D0")]
		[CompilerGenerated]
		get
		{
			return default(HONNHJOIKHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62C21B0", Offset = "0x62C13B0", VA = "0x1862C21B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static bool DDKBGKFGODM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x62C36B0", Offset = "0x62C28B0", VA = "0x1862C36B0")]
	public static void MIOOJNEAIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x62C44E0", Offset = "0x62C36E0", VA = "0x1862C44E0")]
	public static void OFGKJIJAJGP(JLKIEKHBBFF JAGDEMDCBNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KBENOOBMCJC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct PLGGLJLDCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Vector3 MFDMLPFPBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Quaternion HMKNDOIICKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public float LBLCLEHBLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Quaternion JPIAMFPOAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float JAKJKIIKGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public float PHKBHFLHEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public float HEDMODJKDPM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static List<PLGGLJLDCOA> ACCBHOFMMJK;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x62C5D20", Offset = "0x62C4F20", VA = "0x1862C5D20")]
	public static NativeList<LBGPNLGBJGE> FOIJAAILKFH(DBLIPMBGBBD FNIBPAONDEO)
	{
		return default(NativeList<LBGPNLGBJGE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62C4D50", Offset = "0x62C3F50", VA = "0x1862C4D50")]
	private static bool BCDPIFCHJMD(int GJIHJJPNBNJ, NativeList<LBGPNLGBJGE> HCIDHCBMOPD, List<PLGGLJLDCOA> PCLFDNONBON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62C7C60", Offset = "0x62C6E60", VA = "0x1862C7C60")]
	private static LBGPNLGBJGE NMAGPDMCOBI(int HPIPPKAMAJK, List<PLGGLJLDCOA> PCLFDNONBON)
	{
		return default(LBGPNLGBJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x62C7750", Offset = "0x62C6950", VA = "0x1862C7750")]
	private static LBGPNLGBJGE JDBOLDPGALN(int HPIPPKAMAJK, List<PLGGLJLDCOA> PCLFDNONBON)
	{
		return default(LBGPNLGBJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62C4C70", Offset = "0x62C3E70", VA = "0x1862C4C70")]
	private static LBGPNLGBJGE BBKCNKIKMPB(Vector3 CNJLCEDOCCB, Quaternion AFBNOBHGJDB, float LJCANJNBLMD)
	{
		return default(LBGPNLGBJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62C62A0", Offset = "0x62C54A0", VA = "0x1862C62A0")]
	public static NativeList<LBGPNLGBJGE> HCCKIODMDIE(DBLIPMBGBBD FNIBPAONDEO, float JDPJPMINPEI)
	{
		return default(NativeList<LBGPNLGBJGE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MDCDEGOOAJO
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static Vector3 JCDMDELLBFC;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static Vector3 CGMFPMPGDBJ;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly float NKFOGFDGGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62C7E80", Offset = "0x62C7080", VA = "0x1862C7E80")]
	public static Vector3 EEADEDPGFCI(Vector3 KOJHFIEFGHE, Quaternion AFBNOBHGJDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x62C8C20", Offset = "0x62C7E20", VA = "0x1862C8C20")]
	public static Vector3 LLGDBNHKHFK(Quaternion HBCECKEGCGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62C8B80", Offset = "0x62C7D80", VA = "0x1862C8B80")]
	public static Vector3 KMFMJABOEIA(Quaternion HBCECKEGCGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62C8CC0", Offset = "0x62C7EC0", VA = "0x1862C8CC0")]
	public static Quaternion MAMHHCPGEND(Vector3 ILKFGPOHBIP, Vector3 IAAOFHLOLIL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62C8D40", Offset = "0x62C7F40", VA = "0x1862C8D40")]
	public static Vector3 OMDJFIBMFOH(Vector3 MCLOFBDEDDB, Vector3 HGJLPGDMNPL, Vector3 IAAOFHLOLIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x62C8100", Offset = "0x62C7300", VA = "0x1862C8100")]
	public static Vector3 EPFFFMJGJMA(Vector3 KOJHFIEFGHE, Vector3 IAAOFHLOLIL, Quaternion HBCECKEGCGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x62C8530", Offset = "0x62C7730", VA = "0x1862C8530")]
	public static Quaternion INGAAIALOOG(Quaternion AFBNOBHGJDB, Vector3 ILKFGPOHBIP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x62C8F30", Offset = "0x62C8130", VA = "0x1862C8F30")]
	public static bool PDLJMLKCBOH(Vector3 ELMLKANNLJL, Vector3 JDLKLDFEMFI, [Out] Vector3 JNJKKJAIGBM, bool AIBFOCJGKCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x62C8890", Offset = "0x62C7A90", VA = "0x1862C8890")]
	public static Vector3 KFIJDANNPJH(bool IHCOJLBCHCD, [Optional] Quaternion CPCCABMKJEG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LBGPNLGBJGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public float3 MFDMLPFPBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public float3x3 HMKNDOIICKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public float LBLCLEHBLPB;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DBLIPMBGBBD
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	int DFOEDPGAMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 KNGMGFJDACB(int HPIPPKAMAJK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion PGMFOEMNMGJ(int HPIPPKAMAJK);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float MDOJOKPJCAG(int HPIPPKAMAJK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IODJMNJFGBI : AHGNKLONFLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool EKJFKBHHLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool BKGCDEAIOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float BLKECANGDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	int GNLGHHPMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool OCMIENECDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int HGPIDIGNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<LBGPNLGBJGE> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GBIELNIHDPD : AHGNKLONFLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JDMFMBAEHAC HJHIHIAFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool DGKOJHOEECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MKMEMEMHMHI
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	NMHECPHFLPD BHIBJBFFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	ONEFMLCNCNN HLELDMCJCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface AHGNKLONFLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool NKLJCNIHNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool KGNFHBNIKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	NMHECPHFLPD BHIBJBFFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float GFKKLLNGKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Vector3 OGNPHEFGJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	PKCCLILNAJO IPBLAEKHGCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	CCCIGOAJIIL EMCHPKBGDHH
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
public interface ABLFPBOBIAA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int NBNCAHNKGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Transform BOECOJGMOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool DKBNIKOCHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAIIJFOILFO GetBone(int HPIPPKAMAJK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int HPIPPKAMAJK);
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
