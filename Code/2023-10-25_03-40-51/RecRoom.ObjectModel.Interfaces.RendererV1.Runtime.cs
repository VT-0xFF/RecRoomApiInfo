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
public enum IGAGMDOOOBB
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
public enum JNCHCNKNJAN
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
public enum PFKOOHIBGNI
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
public enum MLANAFEMCEP
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
public enum CDANABIPLFJ
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
public enum EOPEADBJLDL
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
public static class LLCEJBODNNM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D51F30", Offset = "0x5D50D30", VA = "0x185D51F30")]
	public static bool IFAIFKAPLLF(this EOPEADBJLDL MABPPJCMDHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D51F50", Offset = "0x5D50D50", VA = "0x185D51F50")]
	public static bool NBBOMGABLJB(this EOPEADBJLDL MABPPJCMDHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D51F60", Offset = "0x5D50D60", VA = "0x185D51F60")]
	public static bool NPOOKNFPHHN(this EOPEADBJLDL MABPPJCMDHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum GPGAJMFGKJB
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
public struct GJPPFFLIBGI : ACFFPCDNNOH, IEquatable<GJPPFFLIBGI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int FCFMLMDMJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D5350", Offset = "0x7D4150", VA = "0x1807D5350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int MNNENJOIOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x200C8C0", Offset = "0x200B6C0", VA = "0x18200C8C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5184420", Offset = "0x5183220", VA = "0x185184420", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ELICBKNLKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D4EAA0", Offset = "0x5D4D8A0", VA = "0x185D4EAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1B88DD0", Offset = "0x1B87BD0", VA = "0x181B88DD0", Slot = "8")]
	public bool Equals(GJPPFFLIBGI LKMMHIOOCMN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EB70", Offset = "0x5D4D970", VA = "0x185D4EB70")]
	public static bool IJDMLBHKDLI(GJPPFFLIBGI APOJANFJHJO, GJPPFFLIBGI DFBIFCHBAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EAE0", Offset = "0x5D4D8E0", VA = "0x185D4EAE0", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EB90", Offset = "0x5D4D990", VA = "0x185D4EB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LOGMEHDJOMH : ACFFPCDNNOH, IEquatable<LOGMEHDJOMH>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int FCFMLMDMJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D5350", Offset = "0x7D4150", VA = "0x1807D5350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int MNNENJOIOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x200C8C0", Offset = "0x200B6C0", VA = "0x18200C8C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5184420", Offset = "0x5183220", VA = "0x185184420", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ELICBKNLKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D532B0", Offset = "0x5D520B0", VA = "0x185D532B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1B88DD0", Offset = "0x1B87BD0", VA = "0x181B88DD0", Slot = "8")]
	public bool Equals(LOGMEHDJOMH LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D532F0", Offset = "0x5D520F0", VA = "0x185D532F0", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D53380", Offset = "0x5D52180", VA = "0x185D53380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KMIAFLOPJDP : ACFFPCDNNOH, IEquatable<KMIAFLOPJDP>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FCFMLMDMJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D5350", Offset = "0x7D4150", VA = "0x1807D5350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MNNENJOIOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x200C8C0", Offset = "0x200B6C0", VA = "0x18200C8C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5184420", Offset = "0x5183220", VA = "0x185184420", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool ELICBKNLKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D51E60", Offset = "0x5D50C60", VA = "0x185D51E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1B88DD0", Offset = "0x1B87BD0", VA = "0x181B88DD0", Slot = "8")]
	public bool Equals(KMIAFLOPJDP LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51EA0", Offset = "0x5D50CA0", VA = "0x185D51EA0", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LLIBFCDNDOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHOFNLHFFAK(GJPPFFLIBGI PHNFANHCONA, JNCHCNKNJAN OBGIGCODDBD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHOFNLHFFAK(LOGMEHDJOMH BAIBFCHAMFJ, JNCHCNKNJAN OBGIGCODDBD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPLGFGIIIOJ(LOGMEHDJOMH BAIBFCHAMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCNLFMGKLJP(LOGMEHDJOMH BAIBFCHAMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBMIHFDMCDC();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FBKIMFMINFP(JNCHCNKNJAN FLHOFPAHPKL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLOAGLOBPPN(GJPPFFLIBGI PHNFANHCONA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LLOAGLOBPPN(LOGMEHDJOMH BAIBFCHAMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CEFMBFDLAAH(LOGMEHDJOMH BAIBFCHAMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GHKMGDFJOGI(LOGMEHDJOMH BAIBFCHAMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PCAHEJHDKDM();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LDPEHENDNIO();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HOMNCCBMPHF(GJPPFFLIBGI PHNFANHCONA, CDANABIPLFJ FLHOFPAHPKL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CKJCDBNBODL(LOGMEHDJOMH BAIBFCHAMFJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CKDIOHMNLMF(LOGMEHDJOMH BAIBFCHAMFJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CJIHPNEHJMI();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FOMFEMPEFGP(CDANABIPLFJ FLHOFPAHPKL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DBLDLDFHENL(GJPPFFLIBGI PHNFANHCONA, Vector3 JENPALBNMCB, Vector3 ECPBGBNICDF, Vector3 DOBEFOAJFMD, float IFMJHMGPFEH, float EGMADKKMIKG, IReadOnlyList<Camera> HFAIDAOCFGL, IGAGMDOOOBB BOHHBHEOKEI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DBLDLDFHENL(KMIAFLOPJDP ABBCGJJENNP, Vector3 JENPALBNMCB, Vector3 ECPBGBNICDF, Vector3 DOBEFOAJFMD, float IFMJHMGPFEH, float EGMADKKMIKG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NGICEBGBAAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CEMNPOEOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GJPPFFLIBGI HIOMIPFKIPB(HJHCIKNBMII LMCJHCIOIIP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GJPPFFLIBGI HIOMIPFKIPB(HJHCIKNBMII LMCJHCIOIIP, bool IKCDEBKBMGK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEDEODIAAAJ(GJPPFFLIBGI PHNFANHCONA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPNKHEODFFC(GJPPFFLIBGI PHNFANHCONA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LOGMEHDJOMH OCONEKLKEEP(GJPPFFLIBGI PHNFANHCONA, JNFBFFIAGFF LMCJHCIOIIP);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LOGMEHDJOMH IGHECHOCHHK(GJPPFFLIBGI PHNFANHCONA, ADNCIEGMLJJ LMCJHCIOIIP);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OBKDDFJJOAK(LOGMEHDJOMH BAIBFCHAMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IKOIJPAFODI(LOGMEHDJOMH BAIBFCHAMFJ);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KMIAFLOPJDP PJPENEHBMPP(GJCLDMDNCJJ LMCJHCIOIIP);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ICFEHOGNBNC(KMIAFLOPJDP ABBCGJJENNP);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NJCAGPNKGNK(KMIAFLOPJDP ABBCGJJENNP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task CAJKELCKMLE();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task IOIGAINIIJO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task JOLDECJKIOI();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KFIBELEGKAM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> NDINEKFNNJO(GJPPFFLIBGI PHNFANHCONA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IFJBHKACBFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct OGPBHANAAJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Vector3 OJIMPAELBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Quaternion NDJDDGGIJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float OJIMPIFGNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Quaternion KGIEBMDNDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public float DCGHEDLGLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public float MCINIIMLJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public float KEKAPABFPNI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static List<OGPBHANAAJI> DNKHFDIENAG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D51850", Offset = "0x5D50650", VA = "0x185D51850")]
	public static NativeList<PCPIDJFGIAP> NLMODBMKGIP(HJEKDKPCOAO NIKGGMJCPGD)
	{
		return default(NativeList<PCPIDJFGIAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D50870", Offset = "0x5D4F670", VA = "0x185D50870")]
	private static bool MBLNBDDPGMA(int NAKKFLBPDCC, NativeList<PCPIDJFGIAP> CGIMAKAECOA, List<OGPBHANAAJI> DEJNCBLIGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D506E0", Offset = "0x5D4F4E0", VA = "0x185D506E0")]
	private static PCPIDJFGIAP HHIKOEKEFND(int BMDADOLNDDL, List<OGPBHANAAJI> DEJNCBLIGJI)
	{
		return default(PCPIDJFGIAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EC20", Offset = "0x5D4DA20", VA = "0x185D4EC20")]
	private static PCPIDJFGIAP BGLAKGIKLBA(int BMDADOLNDDL, List<OGPBHANAAJI> DEJNCBLIGJI)
	{
		return default(PCPIDJFGIAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D50600", Offset = "0x5D4F400", VA = "0x185D50600")]
	private static PCPIDJFGIAP FJKFHFCIEEB(Vector3 GMNHMHBGHKM, Quaternion IGIKFKIIFKN, float HMBCCKMGEBH)
	{
		return default(PCPIDJFGIAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F130", Offset = "0x5D4DF30", VA = "0x185D4F130")]
	public static NativeList<PCPIDJFGIAP> EBALJDHFAJI(HJEKDKPCOAO NIKGGMJCPGD, float JDBDHANCLHP)
	{
		return default(NativeList<PCPIDJFGIAP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LMJGDHOLBHC
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static Vector3 IMLICPEPAAL;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static Vector3 NMDFEHMGFKK;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static readonly float AEDNLLALICJ;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D52DD0", Offset = "0x5D51BD0", VA = "0x185D52DD0")]
	public static Vector3 OMLCADNPLPK(Vector3 CKBHPBNLBBN, Quaternion IGIKFKIIFKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D51F90", Offset = "0x5D50D90", VA = "0x185D51F90")]
	public static Vector3 BBLANKAKIPB(Quaternion ALADLBOMNEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5D52590", Offset = "0x5D51390", VA = "0x185D52590")]
	public static Vector3 EJMBKFFCMHM(Quaternion ALADLBOMNEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D52630", Offset = "0x5D51430", VA = "0x185D52630")]
	public static Quaternion GAGKFEMPGIJ(Vector3 EFMDODKKOAD, Vector3 ABLMGKFECDN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D523A0", Offset = "0x5D511A0", VA = "0x185D523A0")]
	public static Vector3 ECBBIIHPICB(Vector3 ECHPHMINGAD, Vector3 MNIEKIANDAG, Vector3 ABLMGKFECDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D529A0", Offset = "0x5D517A0", VA = "0x185D529A0")]
	public static Vector3 KJBNLFBHNHA(Vector3 CKBHPBNLBBN, Vector3 ABLMGKFECDN, Quaternion ALADLBOMNEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5D52030", Offset = "0x5D50E30", VA = "0x185D52030")]
	public static Quaternion DDOKDNJGGPK(Quaternion IGIKFKIIFKN, Vector3 EFMDODKKOAD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D53060", Offset = "0x5D51E60", VA = "0x185D53060")]
	public static bool PAPJGINGFPD(Vector3 PEAPOKDJEHE, Vector3 NPLIILCLBPP, [Out] Vector3 JOCFGNDKJAN, bool INLPPDDGGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D526B0", Offset = "0x5D514B0", VA = "0x185D526B0")]
	public static Vector3 HDMAAEBBGLM(bool BNGPABIHGJM, [Optional] Quaternion POMKJCKAAPF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PCPIDJFGIAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 OJIMPAELBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3x3 NDJDDGGIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float OJIMPIFGNGM;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HJEKDKPCOAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int PFEAOFMGFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 IALMMAHJMLJ(int BMDADOLNDDL);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion BAFKEMLBKHE(int BMDADOLNDDL);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float ELGMGCNDFCP(int BMDADOLNDDL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ADNCIEGMLJJ : KAFLENOFCPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LEHHJGMOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NGOFEMJDPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float KADONEPPGFG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int PKINCCBDDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NMGGFJDMKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int ADGENJKELLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<PCPIDJFGIAP> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JNFBFFIAGFF : KAFLENOFCPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PFKOOHIBGNI IEMKDBEPMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool GMMJGOEMKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HJHCIKNBMII
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ELBMECNNJAN PLFGJEMELKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	MLANAFEMCEP GAFNIFJPLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KAFLENOFCPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MPJICAEOKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool HGNMHIFINFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	ELBMECNNJAN PLFGJEMELKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float LGGMNNCGFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Vector3 LDGDICMBOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	EOPEADBJLDL EJNNKCKGJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	GPGAJMFGKJB FEPMKKEICCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GJCLDMDNCJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int HNHHIELBFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Transform AKIACHDCKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ELLMGIKOEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GJPPFFLIBGI GetBone(int BMDADOLNDDL);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int BMDADOLNDDL);
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
