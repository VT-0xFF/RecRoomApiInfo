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
public enum JDCOBKHFBGG
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
public enum AGAICHLALAG
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
public enum KPFEPBPCGON
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
public enum LLKIKIFPCCN
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
public enum JOMANKOGPON
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
public enum JLNOJMKJPNC
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
public static class ONPDECNBODN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F470", Offset = "0x7F8E070", VA = "0x187F8F470")]
	public static bool BBEANEDAOMK(this JLNOJMKJPNC KAHBCHHNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F460", Offset = "0x7F8E060", VA = "0x187F8F460")]
	public static bool AGGPFNHHADG(this JLNOJMKJPNC KAHBCHHNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F490", Offset = "0x7F8E090", VA = "0x187F8F490")]
	public static bool DOKANLKBCML(this JLNOJMKJPNC KAHBCHHNKHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IIDDCNCKDDH
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
public struct EEHGLNGJALI : PNKHKLJALOP, IEquatable<EEHGLNGJALI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int FCJKCAOMEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int DLHOIMFANJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6F80", Offset = "0x2FF5B80", VA = "0x182FF6F80", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4900", Offset = "0x6FA3500", VA = "0x186FA4900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JICHDGIBAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F88EA0", Offset = "0x7F87AA0", VA = "0x187F88EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x12B1980", Offset = "0x12B0580", VA = "0x1812B1980", Slot = "8")]
	public bool Equals(EEHGLNGJALI GMNGNCHKEBK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3B688F0", Offset = "0x3B674F0", VA = "0x183B688F0")]
	public static bool JOHLOKGLNML(EEHGLNGJALI ABBBJFPFEKP, EEHGLNGJALI KLKIJPOLHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F88E10", Offset = "0x7F87A10", VA = "0x187F88E10", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F88EE0", Offset = "0x7F87AE0", VA = "0x187F88EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PLBHNIEEDEN : PNKHKLJALOP, IEquatable<PLBHNIEEDEN>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int FCJKCAOMEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int DLHOIMFANJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6F80", Offset = "0x2FF5B80", VA = "0x182FF6F80", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4900", Offset = "0x6FA3500", VA = "0x186FA4900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JICHDGIBAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F8F550", Offset = "0x7F8E150", VA = "0x187F8F550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x12B1980", Offset = "0x12B0580", VA = "0x1812B1980", Slot = "8")]
	public bool Equals(PLBHNIEEDEN GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F4C0", Offset = "0x7F8E0C0", VA = "0x187F8F4C0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F590", Offset = "0x7F8E190", VA = "0x187F8F590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FDKEBGOKFEA : PNKHKLJALOP, IEquatable<FDKEBGOKFEA>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FCJKCAOMEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DLHOIMFANJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6F80", Offset = "0x2FF5B80", VA = "0x182FF6F80", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4900", Offset = "0x6FA3500", VA = "0x186FA4900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JICHDGIBAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F89000", Offset = "0x7F87C00", VA = "0x187F89000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x12B1980", Offset = "0x12B0580", VA = "0x1812B1980", Slot = "8")]
	public bool Equals(FDKEBGOKFEA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F88F70", Offset = "0x7F87B70", VA = "0x187F88F70", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FOCKMLOJPND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJFNAFLEGBM(EEHGLNGJALI HMGDINOCJAI, AGAICHLALAG FPDMHGECAFI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJFNAFLEGBM(PLBHNIEEDEN DAAJJNMMALF, AGAICHLALAG FPDMHGECAFI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIJGNKEKPEK(PLBHNIEEDEN DAAJJNMMALF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNCJOFHOMNI(PLBHNIEEDEN DAAJJNMMALF);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKICPAJNOIL();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEPDCOKDHJN(AGAICHLALAG OPOPAMPKKGD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CMDCEEPDKIB(EEHGLNGJALI HMGDINOCJAI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CMDCEEPDKIB(PLBHNIEEDEN DAAJJNMMALF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HHLBMGDJALJ(PLBHNIEEDEN DAAJJNMMALF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GGHPLAKACLJ(PLBHNIEEDEN DAAJJNMMALF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OIODOMMNACN();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IONLCJNPICL();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JGCLAIBBMGC(EEHGLNGJALI HMGDINOCJAI, JOMANKOGPON OPOPAMPKKGD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MMHCAICBNGM(PLBHNIEEDEN DAAJJNMMALF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BOCMDMEELHL(PLBHNIEEDEN DAAJJNMMALF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IMDFPKBOKGJ();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PMHDIHENKBI(JOMANKOGPON OPOPAMPKKGD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BGGFPGDIENP(EEHGLNGJALI HMGDINOCJAI, Vector3 OFJNCJJBDIF, Vector3 JKNKAKBDBIK, Vector3 LGGFMHCJENO, float KEBLHPJHFCI, float GLCMHLOEKHJ, IReadOnlyList<Camera> OPNNKODCLCD, JDCOBKHFBGG JGEAKKMMJAI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BGGFPGDIENP(FDKEBGOKFEA ALGOPHJEAMD, Vector3 OFJNCJJBDIF, Vector3 JKNKAKBDBIK, Vector3 LGGFMHCJENO, float KEBLHPJHFCI, float GLCMHLOEKHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MEFOENIIPMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FAEMLNNJBBO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EEHGLNGJALI ELCHGMLJKIA(PLLHHFOOEOI PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EEHGLNGJALI ELCHGMLJKIA(PLLHHFOOEOI PEDMEJIDLNB, bool HBDKFMBKNBM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMPMKFBKBDP(EEHGLNGJALI HMGDINOCJAI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HGJECIIJCBG(EEHGLNGJALI HMGDINOCJAI);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PLBHNIEEDEN BCCNHNEJPAO(EEHGLNGJALI HMGDINOCJAI, FLIFFCNMJBP PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PLBHNIEEDEN DLPCKAECPEI(EEHGLNGJALI HMGDINOCJAI, BKJBENJIBKG PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IOJINMAMACM(PLBHNIEEDEN DAAJJNMMALF);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AAGENEJBIAL(PLBHNIEEDEN DAAJJNMMALF);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FDKEBGOKFEA GJHAEJOBDAK(JMKGEOALEPB PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AKDHODBJMFL(FDKEBGOKFEA ALGOPHJEAMD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KKODIHKGODL(FDKEBGOKFEA ALGOPHJEAMD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task ILGKOHFNCHP();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task HJIKLLFIBAC();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task GEJKCMMBNDD();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LHGKCPEDNCP();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> CDOIFOFFJHG(EEHGLNGJALI HMGDINOCJAI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LGHGOILIFGB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum MOBCGFPHGBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum CIBCCCFBFHA
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum HANEODBPCEI
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
	public enum BOFLKOLNEFP
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
	public enum NCLAIJMCKCJ
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
	public enum MDKHGHJIKOA
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
	public enum FPHEAIJOLJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum MIEHJNEOMLL
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
	public static bool OFKJJLBJNGP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long CIKJCAJBHAI;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool LALCIEJEOKK;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool BJOKFFGHCFN;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool DIBNGPLFCEO;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float APCCNGOKAFL;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float CKBICFJDMLI;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int OJGPPDEHEGG;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static MDKHGHJIKOA LDLNDONCIGG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long CIGEKKAJJIA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float OIGDOEFBKOL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int OANHPOJKBAN;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int AHFNJDFGNOL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int AIDBOAINNPD;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int HBPMBLLIIJD;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int NLFJEIEIMKM;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int HJJOLDPJANE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int MKFIDJAIGIO;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int IAIMAINMKAN;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool OMLJEGIJKLO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int BINMPEGENBN;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int KOKJJMBDECP;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int FCCEFLGDIPH;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool GHOCOCJFHHC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float BDCJBLAEMEM;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool PKBFJICELBP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float INIPEFEOPBI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long CDGEKNFPLDO;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool LNHLPCPBLGN;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long JCIGADHDHON;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int JNCEMEJJHBO;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool NAHOHKKGOLM;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static MOBCGFPHGBL CCFNDAKOHNI;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool HAEOINNCNBJ;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool ILIEKJCBNPB;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int OBAEMMMBEFC;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int DFIIFEIIPDO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int ENHMMJFCECL;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int HGBKLAOEKFD;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int MAHNBCFBOJE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int ENCOGNJMBJM;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int KPAGKOIAOLC;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int AEBODFKNHEK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float FPIPFAECDCC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float HHFLPADEJJG;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float IFOOFHFKOII;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float CNCAHKGAMOE;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int IECHPJIEAFE;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int MAKCBLHLJDN;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int INKEPIFAGDC;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int NONAGOKDOBN;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool PNBKAHBCIAC;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static HANEODBPCEI EDBJLHEFHON;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static BOFLKOLNEFP DFJIOIEDAGF;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool MNHBKOJFLIH;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static CIBCCCFBFHA OCMGHAOGHLN;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float LMHPHDIPBNN;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float EHNMDPAMKFP;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float DEANHNNONEC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float CDGEGBEECDJ;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float OKJKBFAFKJP;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float PBMKKMIEOEF;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float GBKADKBLINH;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float DIJDFDJEBFK;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool JEKKJOBILLF;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static FPHEAIJOLJB MLNJHNNDAPF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool DGMGLCNBBEG;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float IPNKLEPBEHO;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float KGDHCNFMOND;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float CNAPADDGCNH;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float HHDKFBJCCLO;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float MBOMPFPNLIK;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool CDOKMIGEKLD;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long NGIEIEGPAJP;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float NHPDAJANEAP;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float GPBCAPGLEOF;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float GOIBCCNKIGO;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int MKKLIIPCMPO;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float JDKPIAIHDAE;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool FECAPAOAGCL;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long LENHOCCALCJ;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int OHAOIBGIKCN;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int FHDONDHPHHG;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float KPODJBHFAGI;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float DANIAJPNAOH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool NGKLGIIEKJH;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool OIJGDJCDCFF;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float DMDFJHPGOHK;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long DBJJNBOBHEC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long ENNBFLMJMDC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int IKBGILFJDDL;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 CANOIGLGAEG;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 OLBGCHAHAPL;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool FMDGDMJPNNF;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static NCLAIJMCKCJ OIHKEDJOCPJ;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long FNPEEJHPENL;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int EHOFMDBFJJF;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int CCJGPIJGNJE;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int AFGBIFNBGIP;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int CHGFDOLBPPH;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int CPGKOIENDJP;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long BONIBHEPDDI;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int JNBEHBKDCKA;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int JLNGBBICFCG;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int OMIELPJOPBK;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long FAABDJOGLJP;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long EEJJFGJAMPH;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long EPKGADNLLOG;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long GGGNCIPHGBD;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int KLOEFJPFEKG;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int BDFPOHJKHMH;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int NMIOPMICJKO;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int BNPLKNDANFJ;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] OKMKEKKMHBM;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int HILGMLHAHAF;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long GAJMMMNGDNO;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long KOPBOKBHLHF;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int DCGJMIPIFNI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int ANDIELPMGDB;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long DEHHCAALNBC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long MGNBDLEOBLH;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long EPKKOCOCEFO;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long AMIIOOJCFLG;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long NFOLEEBPGCL;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long GKBDOKKKBBG;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long PJJCDELKFKE;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long IJOKEHBCBGL;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long GNNAFLIIJAI;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float BKAHNDIAAGK;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float DAMKNKFODLM;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long PKPMEMLNPEG;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int EJLEMFFDJLB;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long GKFCLCJEBOL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long IGAFLCAOFJP;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float CGHJOBACMBB;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long JCFGBPKLCPO;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long HDJNNBALCGM;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long AEJAECHPNKO;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long GDLLLDBEHGJ;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long MNBJIAKFICP;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long DDNFBGKLDGM;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long LMINCNACMHF;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long CGINNOPDDMF;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long HIJKPJBGKLN;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long KNKBAEPNELM;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long HMIPPLECDCK;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long BBIPPEHFJDM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static MIEHJNEOMLL OJOADCNPJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F8D3D0", Offset = "0x7F8BFD0", VA = "0x187F8D3D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long MIAHCILHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F8D9F0", Offset = "0x7F8C5F0", VA = "0x187F8D9F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D420", Offset = "0x7F8C020", VA = "0x187F8D420")]
	public static void IFEDNBDNAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F8DA50", Offset = "0x7F8C650", VA = "0x187F8DA50")]
	public static void OEJCKKMINKM(MIEHJNEOMLL OJHJIHGCAJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GAJKFADOFAL
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct AJCOHOBKLLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 AIFJIFCFPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Quaternion FFNFOABACEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float IPENPJMNGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Quaternion EPFKKFJECNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float AONAKDGFLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float FMCPFEDAGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public float KNHJIJPAOGK;
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static List<AJCOHOBKLLC> ANLNIFKNFGB;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F89040", Offset = "0x7F87C40", VA = "0x187F89040")]
	public static NativeList<PENOEPANFIA> AIEJIOJFHFE(IIDGFLNLEEE JGFKHBPEKHF)
	{
		return default(NativeList<PENOEPANFIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F8ACC0", Offset = "0x7F898C0", VA = "0x187F8ACC0")]
	private static bool JBFAMFDGBMF(int DEONLBGGLDI, NativeList<PENOEPANFIA> DBJBIPJCIKA, List<AJCOHOBKLLC> IJLCLCILCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F895C0", Offset = "0x7F881C0", VA = "0x187F895C0")]
	private static PENOEPANFIA GBOMBHEABMH(int IFAMDLCCFIB, List<AJCOHOBKLLC> IJLCLCILCDL)
	{
		return default(PENOEPANFIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8BB50", Offset = "0x7F8A750", VA = "0x187F8BB50")]
	private static PENOEPANFIA OCGGJJBLKAO(int IFAMDLCCFIB, List<AJCOHOBKLLC> IJLCLCILCDL)
	{
		return default(PENOEPANFIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8ABE0", Offset = "0x7F897E0", VA = "0x187F8ABE0")]
	private static PENOEPANFIA IKKAKPJFOPO(Vector3 JGJDJFGJGGN, Quaternion LJJPEGCDGFJ, float HPDHPFDMAAO)
	{
		return default(PENOEPANFIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F89740", Offset = "0x7F88340", VA = "0x187F89740")]
	public static NativeList<PENOEPANFIA> HJGAKBOGNOF(IIDGFLNLEEE JGFKHBPEKHF, float ILMGKPBMCOJ)
	{
		return default(NativeList<PENOEPANFIA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IINGOMOEAAL
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 FFLDOJJEAMC;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static Vector3 BIHPHFKPHPE;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly float ELAHDEHACOF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C790", Offset = "0x7F8B390", VA = "0x187F8C790")]
	public static Vector3 CIMLIPCONEI(Vector3 MNBLOJNNIPI, Quaternion LJJPEGCDGFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CD00", Offset = "0x7F8B900", VA = "0x187F8CD00")]
	public static Vector3 HIKJCNMBAKF(Quaternion BFEELDCLMGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C6F0", Offset = "0x7F8B2F0", VA = "0x187F8C6F0")]
	public static Vector3 BHLBDDKNMFL(Quaternion BFEELDCLMGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D280", Offset = "0x7F8BE80", VA = "0x187F8D280")]
	public static Quaternion PCAEPFAJNMF(Vector3 HLIFPOIPBBB, Vector3 AKLPJIPJBIP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C500", Offset = "0x7F8B100", VA = "0x187F8C500")]
	public static Vector3 BBPHNEADHEC(Vector3 LCBBCIAOPMI, Vector3 DOBINIDCOKP, Vector3 AKLPJIPJBIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C0D0", Offset = "0x7F8ACD0", VA = "0x187F8C0D0")]
	public static Vector3 AJKLOJMLCEP(Vector3 MNBLOJNNIPI, Vector3 AKLPJIPJBIP, Quaternion BFEELDCLMGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CDA0", Offset = "0x7F8B9A0", VA = "0x187F8CDA0")]
	public static Quaternion KGHOFBOEFMJ(Quaternion LJJPEGCDGFJ, Vector3 HLIFPOIPBBB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D100", Offset = "0x7F8BD00", VA = "0x187F8D100")]
	public static bool MPDBCEEGHLI(Vector3 PAJKBOLELPJ, Vector3 PCAMMIDDEOK, [Out] Vector3 IIFNKGDIONN, bool KBANLIPHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CA10", Offset = "0x7F8B610", VA = "0x187F8CA10")]
	public static Vector3 CLBPFEMNJDI(bool AHLNKODFJJJ, [Optional] Quaternion MDBHICIEFID)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PENOEPANFIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3 AIFJIFCFPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float3x3 FFNFOABACEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float IPENPJMNGEH;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IIDGFLNLEEE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int IMEJEAEFBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 EFLLFBGELIG(int IFAMDLCCFIB);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion EDOHBCJOLIA(int IFAMDLCCFIB);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float PNEDCIPLLAB(int IFAMDLCCFIB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface BKJBENJIBKG : DIAELBGNDEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool BCLPPAANIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool MOPIONDHEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float HNKFFHFOEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int KMMEFBHACEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool GGMHMHIBFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int NLFOIHCIAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<PENOEPANFIA> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FLIFFCNMJBP : DIAELBGNDEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KPFEPBPCGON IBEBECLIJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool ENNGJDDIGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 CIOJGHJNDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PLLHHFOOEOI
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LNFJEBGBMKD FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	LLKIKIFPCCN GAOLILFBDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface DIAELBGNDEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KODINGJMAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NGDJENMBGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LNFJEBGBMKD FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS BLMHKMBBHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float IKGOEOBCJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 DAAPPGHMJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	JLNOJMKJPNC GBHBPKEPCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IIDDCNCKDDH KOPBCACEOJC
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
public interface JMKGEOALEPB
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int EBGJCHKKOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform FLKMPAHJANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool LODPAPILAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EEHGLNGJALI GetBone(int IFAMDLCCFIB);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int IFAMDLCCFIB);
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
