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
public enum GOOHNEPAEJB
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
public enum ALFFGGLLEIB
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
public enum KNLOGLCKKOM
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
public enum FHJHPAHGGJC
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
public enum NNIPIIDFJHC
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
public enum JHALCGHGKFM
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
public static class EPDLJPMHEHL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69BB410", Offset = "0x69B9E10", VA = "0x1869BB410")]
	public static bool FNJFBNDMCGH(this JHALCGHGKFM BIAAICJFDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69BB400", Offset = "0x69B9E00", VA = "0x1869BB400")]
	public static bool EDBICJHJHMP(this JHALCGHGKFM BIAAICJFDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69BB3D0", Offset = "0x69B9DD0", VA = "0x1869BB3D0")]
	public static bool BCJNDEFEMFI(this JHALCGHGKFM BIAAICJFDKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IEFJNCNDPKA
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
public struct IEDAAAILGEE : JAPLOFGMOOP, IEquatable<IEDAAAILGEE>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int JCLKIAMNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int MOFBDCNAPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x253EE00", Offset = "0x253D800", VA = "0x18253EE00", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CABAD0", Offset = "0x5CAA4D0", VA = "0x185CABAD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JPOGMMCJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69BB510", Offset = "0x69B9F10", VA = "0x1869BB510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1E99FE0", Offset = "0x1E989E0", VA = "0x181E99FE0", Slot = "8")]
	public bool Equals(IEDAAAILGEE HENLEJBGFIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x688A300", Offset = "0x6888D00", VA = "0x18688A300")]
	public static bool BNNGOGJDCPO(IEDAAAILGEE GDMICPKKGFK, IEDAAAILGEE JCAJPPHEFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69BB550", Offset = "0x69B9F50", VA = "0x1869BB550", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69BB5F0", Offset = "0x69B9FF0", VA = "0x1869BB5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LBNOCAEIKJO : JAPLOFGMOOP, IEquatable<LBNOCAEIKJO>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int JCLKIAMNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int MOFBDCNAPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x253EE00", Offset = "0x253D800", VA = "0x18253EE00", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CABAD0", Offset = "0x5CAA4D0", VA = "0x185CABAD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JPOGMMCJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69BB680", Offset = "0x69BA080", VA = "0x1869BB680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E99FE0", Offset = "0x1E989E0", VA = "0x181E99FE0", Slot = "8")]
	public bool Equals(LBNOCAEIKJO HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69BB6C0", Offset = "0x69BA0C0", VA = "0x1869BB6C0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69BB760", Offset = "0x69BA160", VA = "0x1869BB760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HGLPPCOOLEO : JAPLOFGMOOP, IEquatable<HGLPPCOOLEO>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JCLKIAMNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MOFBDCNAPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x253EE00", Offset = "0x253D800", VA = "0x18253EE00", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CABAD0", Offset = "0x5CAA4D0", VA = "0x185CABAD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JPOGMMCJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69BB430", Offset = "0x69B9E30", VA = "0x1869BB430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1E99FE0", Offset = "0x1E989E0", VA = "0x181E99FE0", Slot = "8")]
	public bool Equals(HGLPPCOOLEO HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69BB470", Offset = "0x69B9E70", VA = "0x1869BB470", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ILECDBAGIBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBAMGBBEEKH(IEDAAAILGEE GPKGNPPAAHE, ALFFGGLLEIB COJIOHPGJMM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBAMGBBEEKH(LBNOCAEIKJO EIPPPMBMJMN, ALFFGGLLEIB COJIOHPGJMM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMAKJCKIGHA(LBNOCAEIKJO EIPPPMBMJMN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALEIAMKIBIM(LBNOCAEIKJO EIPPPMBMJMN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOGNPCJFFIG();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPIECNJHDAC(ALFFGGLLEIB ADDOHDGDFOD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHAPGBLHGAA(IEDAAAILGEE GPKGNPPAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHAPGBLHGAA(LBNOCAEIKJO EIPPPMBMJMN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGLNJKFHDGM(LBNOCAEIKJO EIPPPMBMJMN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBOALDKGAAD(LBNOCAEIKJO EIPPPMBMJMN);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OHNDLNPGJOF();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OKPAAKNNNMP();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LMBELODALNM(IEDAAAILGEE GPKGNPPAAHE, NNIPIIDFJHC ADDOHDGDFOD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LPAJBOLNPIE(LBNOCAEIKJO EIPPPMBMJMN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NLMCMHPOAJB(LBNOCAEIKJO EIPPPMBMJMN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JDDOFDIFHOM();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JIFCDGIPEPJ(NNIPIIDFJHC ADDOHDGDFOD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JGBCMAAECMP(IEDAAAILGEE GPKGNPPAAHE, Vector3 KICJDADDPJC, Vector3 EALHFJEAOJA, Vector3 CGLJJKHDLHG, float OBBKEIOCCKM, float FHDBOBCMAII, IReadOnlyList<Camera> IHFKGLPHBBB, GOOHNEPAEJB GJGNKJLHHII);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JGBCMAAECMP(HGLPPCOOLEO HEHMCNIIIAA, Vector3 KICJDADDPJC, Vector3 EALHFJEAOJA, Vector3 CGLJJKHDLHG, float OBBKEIOCCKM, float FHDBOBCMAII);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface POPMLBEHLKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool OPAEJAAMJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEDAAAILGEE AEDCMNHGHCB(LJJHFAKHLIO EEOBDBMOHPL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEDAAAILGEE AEDCMNHGHCB(LJJHFAKHLIO EEOBDBMOHPL, bool LBIALBMMMBA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEMKJOAOCBG(IEDAAAILGEE GPKGNPPAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNAPNNPMAGM(IEDAAAILGEE GPKGNPPAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LBNOCAEIKJO ABNAGNOAMKP(IEDAAAILGEE GPKGNPPAAHE, IHEKPJICHCM EEOBDBMOHPL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LBNOCAEIKJO MIDNNKLKGNK(IEDAAAILGEE GPKGNPPAAHE, GLHGLJKLJJB EEOBDBMOHPL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KDIGNILLLDK(LBNOCAEIKJO EIPPPMBMJMN);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GJCNMGJJLFD(LBNOCAEIKJO EIPPPMBMJMN);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HGLPPCOOLEO BGKALPKJOGG(HAJPNOBJCDO EEOBDBMOHPL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ECMPOJEBGCE(HGLPPCOOLEO HEHMCNIIIAA);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FFHBPBDBMFN(HGLPPCOOLEO HEHMCNIIIAA);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task PJGFEMMNKBM();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task FLKEBDEABIO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task KLLKOGIDBKO();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LIHIOIMJLEJ();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> GJNJPAINFHD(IEDAAAILGEE GPKGNPPAAHE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LCLCNAJNNAN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum FNHDCCOFKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum CAPKDFHHKLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum GGDDGLNIPEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum KAKDGHPPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Disable_NormTanF16MatUi8,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Force_NormTanF16MatUi8,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Force_NormTanSn8UvMatF16
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum CIDGLJCEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum LCNIBLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Quest3,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		MemoryBuild,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int AFEFIIGFEGD;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int CGGNDKNDDDP;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int JJFHGDKKNIJ;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int CLGOAAHMBDI;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static int[] BPHFOMDMKPE;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static int EDBOEIGJMGB;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static int EJJPEECDJLB;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static int NHJGFLNIPFB;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long JLEHLOCJPMK;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long LEFFMCINGEA;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long HFAONEHBMPL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long OMDJNPKAOFH;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long BOCEPIFHJKB;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long GEJAHMGLIDJ;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long AFGDJMEMLBH;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long BPNLPPGLCND;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static long IIIGENCHBEJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static long JIBDGMCKPJH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long GOFHGJFEOIK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long EJOHHCCKCBK;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static long BEBGFNIKILH;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static long GMBKMGPPOGG;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float KBMBFDEDMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long LLGBJPBKNME;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long IFPNFBKBALO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool AFGDKPPAAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69BCA00", Offset = "0x69BB400", VA = "0x1869BCA00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69BD8B0", Offset = "0x69BC2B0", VA = "0x1869BD8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static LCNIBLLCKCD EAHLBFKBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x69BC840", Offset = "0x69BB240", VA = "0x1869BC840")]
		[CompilerGenerated]
		get
		{
			return default(LCNIBLLCKCD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x69BE990", Offset = "0x69BD390", VA = "0x1869BE990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool NGFKPDJFMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69BE8F0", Offset = "0x69BD2F0", VA = "0x1869BE8F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x69BE3A0", Offset = "0x69BCDA0", VA = "0x1869BE3A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool OBICKJMJBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69BE060", Offset = "0x69BCA60", VA = "0x1869BE060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x69BD200", Offset = "0x69BBC00", VA = "0x1869BD200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static FNHDCCOFKIJ KEEPNBOHKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69BCED0", Offset = "0x69BB8D0", VA = "0x1869BCED0")]
		[CompilerGenerated]
		get
		{
			return default(FNHDCCOFKIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69BCE20", Offset = "0x69BB820", VA = "0x1869BCE20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CMMIFBKNNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x69BE010", Offset = "0x69BCA10", VA = "0x1869BE010")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x69BC9A0", Offset = "0x69BB3A0", VA = "0x1869BC9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static CAPKDFHHKLG BICDJBEOLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x69BC950", Offset = "0x69BB350", VA = "0x1869BC950")]
		[CompilerGenerated]
		get
		{
			return default(CAPKDFHHKLG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69BC520", Offset = "0x69BAF20", VA = "0x1869BC520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool HKIGLKFPIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69BCAB0", Offset = "0x69BB4B0", VA = "0x1869BCAB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69BE1C0", Offset = "0x69BCBC0", VA = "0x1869BE1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool DNLMKCECOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69BE9F0", Offset = "0x69BD3F0", VA = "0x1869BE9F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x69BD500", Offset = "0x69BBF00", VA = "0x1869BD500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool BLOJIGIGLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69BE5C0", Offset = "0x69BCFC0", VA = "0x1869BE5C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x69BE720", Offset = "0x69BD120", VA = "0x1869BE720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static float DDPIMPLENFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x69BC790", Offset = "0x69BB190", VA = "0x1869BC790")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69BCDC0", Offset = "0x69BB7C0", VA = "0x1869BCDC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int CMGPKGJIHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69BD6F0", Offset = "0x69BC0F0", VA = "0x1869BD6F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x69BC890", Offset = "0x69BB290", VA = "0x1869BC890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int PNKCAACAMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x69BEAA0", Offset = "0x69BD4A0", VA = "0x1869BEAA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x69BD050", Offset = "0x69BBA50", VA = "0x1869BD050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int OBLHBFIMMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x69BE2F0", Offset = "0x69BCCF0", VA = "0x1869BE2F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x69BC8F0", Offset = "0x69BB2F0", VA = "0x1869BC8F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int AILLHIHHEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x69BC580", Offset = "0x69BAF80", VA = "0x1869BC580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x69BE890", Offset = "0x69BD290", VA = "0x1869BE890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int FMAACNABOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69BD160", Offset = "0x69BBB60", VA = "0x1869BD160")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69BC7E0", Offset = "0x69BB1E0", VA = "0x1869BC7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int HNMGODEPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x69BC740", Offset = "0x69BB140", VA = "0x1869BC740")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69BCBF0", Offset = "0x69BB5F0", VA = "0x1869BCBF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int EBJEKJLKJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69BD560", Offset = "0x69BBF60", VA = "0x1869BD560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69BE660", Offset = "0x69BD060", VA = "0x1869BE660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int KFOIFDPEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69BE0B0", Offset = "0x69BCAB0", VA = "0x1869BE0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69BD380", Offset = "0x69BBD80", VA = "0x1869BD380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int PCLPPFAOMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69BD7A0", Offset = "0x69BC1A0", VA = "0x1869BD7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69BE780", Offset = "0x69BD180", VA = "0x1869BE780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int EJJNCFLENOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69BCCB0", Offset = "0x69BB6B0", VA = "0x1869BCCB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69BC5D0", Offset = "0x69BAFD0", VA = "0x1869BC5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int CHEPOFMBBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69BE520", Offset = "0x69BCF20", VA = "0x1869BE520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69BD850", Offset = "0x69BC250", VA = "0x1869BD850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int CNJIDIMFKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x69BCB00", Offset = "0x69BB500", VA = "0x1869BCB00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x69BD740", Offset = "0x69BC140", VA = "0x1869BD740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int JKCLJLHABKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69BE7E0", Offset = "0x69BD1E0", VA = "0x1869BE7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69BE160", Offset = "0x69BCB60", VA = "0x1869BE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static int DHINBPIAEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69BE940", Offset = "0x69BD340", VA = "0x1869BE940")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69BD2C0", Offset = "0x69BBCC0", VA = "0x1869BD2C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static int AIJPLACLIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x69BCE80", Offset = "0x69BB880", VA = "0x1869BCE80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69BCA50", Offset = "0x69BB450", VA = "0x1869BCA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool MHKEGAKJOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69BC630", Offset = "0x69BB030", VA = "0x1869BC630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69BB7F0", Offset = "0x69BA1F0", VA = "0x1869BB7F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool LKDJGHFCLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69BE570", Offset = "0x69BCF70", VA = "0x1869BE570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69BD5B0", Offset = "0x69BBFB0", VA = "0x1869BD5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static GGDDGLNIPEP MKLPMFELIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69BCB50", Offset = "0x69BB550", VA = "0x1869BCB50")]
		[CompilerGenerated]
		get
		{
			return default(GGDDGLNIPEP);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69BB8C0", Offset = "0x69BA2C0", VA = "0x1869BB8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static KAKDGHPPMDM MNKBAGIENIO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69BD000", Offset = "0x69BBA00", VA = "0x1869BD000")]
		[CompilerGenerated]
		get
		{
			return default(KAKDGHPPMDM);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69BD3E0", Offset = "0x69BBDE0", VA = "0x1869BD3E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static bool FACCMMBMGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69BD1B0", Offset = "0x69BBBB0", VA = "0x1869BD1B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69BCD60", Offset = "0x69BB760", VA = "0x1869BCD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float KPMFLLLMJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69BCBA0", Offset = "0x69BB5A0", VA = "0x1869BCBA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69BE220", Offset = "0x69BCC20", VA = "0x1869BE220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float KAIKBPKLJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69BD0B0", Offset = "0x69BBAB0", VA = "0x1869BD0B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69BD910", Offset = "0x69BC310", VA = "0x1869BD910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float OJOFIHNFDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69BEB50", Offset = "0x69BD550", VA = "0x1869BEB50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69BD100", Offset = "0x69BBB00", VA = "0x1869BD100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static float MKFCIOIFOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69BE610", Offset = "0x69BD010", VA = "0x1869BE610")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x69BE4C0", Offset = "0x69BCEC0", VA = "0x1869BE4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float BBLFOCLJFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69BE100", Offset = "0x69BCB00", VA = "0x1869BE100")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69BE460", Offset = "0x69BCE60", VA = "0x1869BE460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float OBEJOCDICEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69BD7F0", Offset = "0x69BC1F0", VA = "0x1869BD7F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69BE340", Offset = "0x69BCD40", VA = "0x1869BE340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static bool BDMHGAMIIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x69BE6C0", Offset = "0x69BD0C0", VA = "0x1869BE6C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x69BD260", Offset = "0x69BBC60", VA = "0x1869BD260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float PLMPHKFPBPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69BD320", Offset = "0x69BBD20", VA = "0x1869BD320")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69BB920", Offset = "0x69BA320", VA = "0x1869BB920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int COMBBGIODHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69BEAF0", Offset = "0x69BD4F0", VA = "0x1869BEAF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69BD4A0", Offset = "0x69BBEA0", VA = "0x1869BD4A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int CIMLEPCFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69BCD00", Offset = "0x69BB700", VA = "0x1869BCD00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69BEA40", Offset = "0x69BD440", VA = "0x1869BEA40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool PFCLGNAKDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69BE400", Offset = "0x69BCE00", VA = "0x1869BE400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int MBMJGDELJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69BC680", Offset = "0x69BB080", VA = "0x1869BC680")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x69BCC50", Offset = "0x69BB650", VA = "0x1869BCC50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int GOJCFALMELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69BD440", Offset = "0x69BBE40", VA = "0x1869BD440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static float4x4 JEFIJPOGJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69BCF80", Offset = "0x69BB980", VA = "0x1869BCF80")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69BD610", Offset = "0x69BC010", VA = "0x1869BD610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static float3 CJJNIMIPIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69BB850", Offset = "0x69BA250", VA = "0x1869BB850")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x69BE280", Offset = "0x69BCC80", VA = "0x1869BE280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool GGEJKINHAIE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x69BC6E0", Offset = "0x69BB0E0", VA = "0x1869BC6E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69BCF20", Offset = "0x69BB920", VA = "0x1869BCF20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static CIDGLJCEEFK DFIMDBLLHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69BD690", Offset = "0x69BC090", VA = "0x1869BD690")]
		[CompilerGenerated]
		get
		{
			return default(CIDGLJCEEFK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69BE830", Offset = "0x69BD230", VA = "0x1869BE830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69BB980", Offset = "0x69BA380", VA = "0x1869BB980")]
	public static void AHOOBMOIKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69BD970", Offset = "0x69BC370", VA = "0x1869BD970")]
	public static void JIOEKJECLCC(LCNIBLLCKCD PAOOABJHAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LGMENMAHBDB
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct PIAJDHACEJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector3 IOJOFKPMLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Quaternion JIIABDGOIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float DDFFBPCPAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public Quaternion BLEMHGHGMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float BIDEAKGDFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float MGBMPOCLEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float NBKADLHBLIL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static List<PIAJDHACEJN> DLBKOMMMNJA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x69BF770", Offset = "0x69BE170", VA = "0x1869BF770")]
	public static NativeList<PEHEHHOPNDC> IHKDOLEEKLF(GMJFLFPDDCH OLNDJGIOKLA)
	{
		return default(NativeList<PEHEHHOPNDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x69BFD00", Offset = "0x69BE700", VA = "0x1869BFD00")]
	private static bool LCAAJMBPAPE(int KLFNJJLKNGE, NativeList<PEHEHHOPNDC> EBPHIJANMPN, List<PIAJDHACEJN> OGLPFLDJCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69C0CE0", Offset = "0x69BF6E0", VA = "0x1869C0CE0")]
	private static PEHEHHOPNDC LKPIEJALIJL(int OPBNGFFAEBH, List<PIAJDHACEJN> OGLPFLDJCNE)
	{
		return default(PEHEHHOPNDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x69BF180", Offset = "0x69BDB80", VA = "0x1869BF180")]
	private static PEHEHHOPNDC BKGMIJPJCDE(int OPBNGFFAEBH, List<PIAJDHACEJN> OGLPFLDJCNE)
	{
		return default(PEHEHHOPNDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x69BF690", Offset = "0x69BE090", VA = "0x1869BF690")]
	private static PEHEHHOPNDC DONAHNMOLDB(Vector3 FKMPANFIJIC, Quaternion CMAJCEDKDLM, float EHEGOIJKGEH)
	{
		return default(PEHEHHOPNDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69C0E70", Offset = "0x69BF870", VA = "0x1869C0E70")]
	public static NativeList<PEHEHHOPNDC> PKOLNIKFNKP(GMJFLFPDDCH OLNDJGIOKLA, float NDOLINLGKFJ)
	{
		return default(NativeList<PEHEHHOPNDC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BOHBJNKJDKI
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static Vector3 AMGAPMDKDIB;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static Vector3 OEMMJIILPPO;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static readonly float BCKMPJJPMLF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69BABD0", Offset = "0x69B95D0", VA = "0x1869BABD0")]
	public static Vector3 KHFMCJMEJDK(Vector3 JKBBIMFFNMA, Quaternion CMAJCEDKDLM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x69BB1D0", Offset = "0x69B9BD0", VA = "0x1869BB1D0")]
	public static Vector3 MDGNGFJAGCN(Quaternion NGGFFKDNCFB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x69BA4E0", Offset = "0x69B8EE0", VA = "0x1869BA4E0")]
	public static Vector3 CAJFKGDHEHF(Quaternion NGGFFKDNCFB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x69BB270", Offset = "0x69B9C70", VA = "0x1869BB270")]
	public static Quaternion OMCHHHMJJCL(Vector3 NMAFDGGPBKA, Vector3 GKJCNLBHEIK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69BA580", Offset = "0x69B8F80", VA = "0x1869BA580")]
	public static Vector3 CEAILJMIHBN(Vector3 HIPFMLBNNKM, Vector3 MNAFILBBILA, Vector3 GKJCNLBHEIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x69BA0B0", Offset = "0x69B8AB0", VA = "0x1869BA0B0")]
	public static Vector3 AJAIKEMHOHO(Vector3 JKBBIMFFNMA, Vector3 GKJCNLBHEIK, Quaternion NGGFFKDNCFB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69BAE60", Offset = "0x69B9860", VA = "0x1869BAE60")]
	public static Quaternion LJLNBEBCLKB(Quaternion CMAJCEDKDLM, Vector3 NMAFDGGPBKA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x69BA770", Offset = "0x69B9170", VA = "0x1869BA770")]
	public static bool HFPHIHOHFAK(Vector3 JKBIDDPFGCD, Vector3 HHEPOIDEPGJ, [Out] Vector3 GMLKGNBBAOM, bool FNDNOMNEGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x69BA8E0", Offset = "0x69B92E0", VA = "0x1869BA8E0")]
	public static Vector3 JOPMEDOEIFL(bool NBBHFCNMCEJ, [Optional] Quaternion AOLGNDIBKKC)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PEHEHHOPNDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public float3 IOJOFKPMLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public float3x3 JIIABDGOIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public float DDFFBPCPAPO;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GMJFLFPDDCH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	int MBHMELDPCIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 PEOKACLEMAC(int OPBNGFFAEBH);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion BPFPKPODKPE(int OPBNGFFAEBH);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float PJNEMDBONME(int OPBNGFFAEBH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GLHGLJKLJJB : MIIPEMBLAJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool LCCNMAKCMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool IGFFJMNDPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	float JJIJMKGNIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	int CLJGGJPJFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool BJJMAKBIIHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int JGOBKGOHAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<PEHEHHOPNDC> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IHEKPJICHCM : MIIPEMBLAJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KNLOGLCKKOM MPDKHEHLPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool DMECLBLDMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float3 BEEAPNLHGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface LJJHFAKHLIO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	DJBABNHKILH JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FHJHPAHGGJC FJLENGKBMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MIIPEMBLAJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool NFCEJBNGLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CIPLNOHALPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	DJBABNHKILH JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	UniformTRS CEOBBKKILLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float MDBGILJIHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Vector3 HEJEHEAHMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	JHALCGHGKFM NPNDCLLPDPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	IEFJNCNDPKA GJFHFHMJALO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HAJPNOBJCDO
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int MHOOCFJDMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Transform MBIMEHNCJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool CANPCPEFDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEDAAAILGEE GetBone(int OPBNGFFAEBH);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int OPBNGFFAEBH);
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
