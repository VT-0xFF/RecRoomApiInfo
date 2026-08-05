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
public enum HLGCPAFPBOK
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
public enum MKFOLIFJABD
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
public enum KKCFIPIKEPK
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
public enum JMAHILJOHIJ
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
public enum LFIEDIGFABH
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
public enum BPMNKHLKDDH
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
public static class KOPEGEAGHJA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x638C620", Offset = "0x638B620", VA = "0x18638C620")]
	public static bool AABCLJNAOEO(this BPMNKHLKDDH MPFOJLHCAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x638C670", Offset = "0x638B670", VA = "0x18638C670")]
	public static bool ILHAHGKOFLH(this BPMNKHLKDDH MPFOJLHCAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x638C640", Offset = "0x638B640", VA = "0x18638C640")]
	public static bool GGIJDEDNKHM(this BPMNKHLKDDH MPFOJLHCAPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DEJBNHJMHIH
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
public struct BBMDIEDIPLD : FFECINGEIPC, IEquatable<BBMDIEDIPLD>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int CBOGBOOIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int LDLNMMLFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x237F180", Offset = "0x237E180", VA = "0x18237F180", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x56EA740", Offset = "0x56E9740", VA = "0x1856EA740", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JAKHALGPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63862B0", Offset = "0x63852B0", VA = "0x1863862B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D50DB0", Offset = "0x1D4FDB0", VA = "0x181D50DB0", Slot = "8")]
	public bool Equals(BBMDIEDIPLD JNHFAFOIKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6273A40", Offset = "0x6272A40", VA = "0x186273A40")]
	public static bool OECHKCIMKIG(BBMDIEDIPLD AAOIMEIMECG, BBMDIEDIPLD ABLGCHAEIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6386210", Offset = "0x6385210", VA = "0x186386210", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63862F0", Offset = "0x63852F0", VA = "0x1863862F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OBHDANMLCNN : FFECINGEIPC, IEquatable<OBHDANMLCNN>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CBOGBOOIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int LDLNMMLFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x237F180", Offset = "0x237E180", VA = "0x18237F180", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x56EA740", Offset = "0x56E9740", VA = "0x1856EA740", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JAKHALGPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x638C720", Offset = "0x638B720", VA = "0x18638C720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D50DB0", Offset = "0x1D4FDB0", VA = "0x181D50DB0", Slot = "8")]
	public bool Equals(OBHDANMLCNN JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x638C680", Offset = "0x638B680", VA = "0x18638C680", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x638C760", Offset = "0x638B760", VA = "0x18638C760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KLOOMNNBPPI : FFECINGEIPC, IEquatable<KLOOMNNBPPI>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CBOGBOOIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LDLNMMLFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x237F180", Offset = "0x237E180", VA = "0x18237F180", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56EA740", Offset = "0x56E9740", VA = "0x1856EA740", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JAKHALGPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x638C5E0", Offset = "0x638B5E0", VA = "0x18638C5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D50DB0", Offset = "0x1D4FDB0", VA = "0x181D50DB0", Slot = "8")]
	public bool Equals(KLOOMNNBPPI JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x638C540", Offset = "0x638B540", VA = "0x18638C540", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ANGEEELJMNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNDHHCNOAFB(BBMDIEDIPLD OPFDMIOAEHD, MKFOLIFJABD AHFIKOMACCN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNDHHCNOAFB(OBHDANMLCNN FMEBIBHEFLO, MKFOLIFJABD AHFIKOMACCN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMOHJCNEGAK(OBHDANMLCNN FMEBIBHEFLO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNKIBIEFKEJ(OBHDANMLCNN FMEBIBHEFLO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KEJDAILGOKP();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MLHIBMEACAO(MKFOLIFJABD KBCNAJKPHNL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHOLLONILKL(BBMDIEDIPLD OPFDMIOAEHD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHOLLONILKL(OBHDANMLCNN FMEBIBHEFLO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NGFKGCCPPPA(OBHDANMLCNN FMEBIBHEFLO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LOCJFPMMJNN(OBHDANMLCNN FMEBIBHEFLO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MFOGHNFEBFE();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EPHIGGDPFGJ();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HHPLABLBIMF(BBMDIEDIPLD OPFDMIOAEHD, LFIEDIGFABH KBCNAJKPHNL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MJIGHINAGOI(OBHDANMLCNN FMEBIBHEFLO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HGNILNPAHMH(OBHDANMLCNN FMEBIBHEFLO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FHGGBJKNJMF();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BJFDLGIGDEH(LFIEDIGFABH KBCNAJKPHNL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GGFLHHIMLIP(BBMDIEDIPLD OPFDMIOAEHD, Vector3 POGOJHKOOBM, Vector3 DHEKHCOPJMB, Vector3 DLOALMOBEME, float ELMLJKPHJLH, float KIFEGGGDKGJ, IReadOnlyList<Camera> DCECCGBFLPA, HLGCPAFPBOK LAHPAFHFPDK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GGFLHHIMLIP(KLOOMNNBPPI PBFFOLELKFI, Vector3 POGOJHKOOBM, Vector3 DHEKHCOPJMB, Vector3 DLOALMOBEME, float ELMLJKPHJLH, float KIFEGGGDKGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HFHDKKLEEBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NMCFAGKLEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BBMDIEDIPLD JIKNNDNAGCM(IPNPOPBOEBA GPKMLHOONCL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BBMDIEDIPLD JIKNNDNAGCM(IPNPOPBOEBA GPKMLHOONCL, bool DLIINIJABCI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFBMFEPCPBA(BBMDIEDIPLD OPFDMIOAEHD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EAJHPLDBJCL(BBMDIEDIPLD OPFDMIOAEHD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OBHDANMLCNN JCHNADOPNMA(BBMDIEDIPLD OPFDMIOAEHD, PFDIJHJAKJD GPKMLHOONCL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OBHDANMLCNN OKJHMKLHBMF(BBMDIEDIPLD OPFDMIOAEHD, OJKNMAHEHCD GPKMLHOONCL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KKDFKJCPFKE(OBHDANMLCNN FMEBIBHEFLO);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ADGNHLEICOF(OBHDANMLCNN FMEBIBHEFLO);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KLOOMNNBPPI KNAALMEBGHI(IPNGPABGGMN GPKMLHOONCL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BKICMLAJCMG(KLOOMNNBPPI PBFFOLELKFI);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GJACAPDHPBA(KLOOMNNBPPI PBFFOLELKFI);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task BDCADIDNKBB();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task MNFAHLCKBPM();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task LLOAMIDFHLI();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NJDAGGLAMJG();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> JJEGPMBPOAF(BBMDIEDIPLD OPFDMIOAEHD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DFLMAAFEIJP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum AOLLEGINANN
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
	public enum AGMKDJKCKIK
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum JNLLICLPBDM
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
	public enum CKKBNAGJDNL
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
	public enum KPENAGDIPPA
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
	public static int CGJDALNGFAE;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static int KDAFMFALDLP;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static int GPAGGFGFLGD;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static int PBENMMBBLON;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int[] DGENAPPDMDI;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int APJIKPPDOBJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int IGBHHLJPANN;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int IECNADGNGHJ;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static long LLFALOMFOPF;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static long GMMPDDBHAHO;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static long MEDOAHDDALJ;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static long LHDDABLPHMF;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long HNIGNEDMIGD;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long JOOBDJJEKHL;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long OIADJPEJFKD;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long OIHJDLOICND;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long LNICMKLMKDM;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long IIIDGLCFPGB;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long OGPEEIGANBD;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long CNENMNDELPN;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float NNECOKFJFGI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static long POBPPFJFJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long EMFCFMPFKJF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static KPENAGDIPPA IHLHOHJIILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63876F0", Offset = "0x63866F0", VA = "0x1863876F0")]
		[CompilerGenerated]
		get
		{
			return default(KPENAGDIPPA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6386470", Offset = "0x6385470", VA = "0x186386470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool HBOPJADBNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6388540", Offset = "0x6387540", VA = "0x186388540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6388870", Offset = "0x6387870", VA = "0x186388870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static AOLLEGINANN IDDDFHMOHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63864D0", Offset = "0x63854D0", VA = "0x1863864D0")]
		[CompilerGenerated]
		get
		{
			return default(AOLLEGINANN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63886B0", Offset = "0x63876B0", VA = "0x1863886B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool ELPBENOAJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6387190", Offset = "0x6386190", VA = "0x186387190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6387920", Offset = "0x6386920", VA = "0x186387920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static AGMKDJKCKIK OKADMNKOPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6388030", Offset = "0x6387030", VA = "0x186388030")]
		[CompilerGenerated]
		get
		{
			return default(AGMKDJKCKIK);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6387980", Offset = "0x6386980", VA = "0x186387980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool LLKFJKPNNIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6386420", Offset = "0x6385420", VA = "0x186386420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6388080", Offset = "0x6387080", VA = "0x186388080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool FHNINMHBJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6387C80", Offset = "0x6386C80", VA = "0x186387C80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6387460", Offset = "0x6386460", VA = "0x186387460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool KJPJMJNODKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6387F90", Offset = "0x6386F90", VA = "0x186387F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x63885F0", Offset = "0x63875F0", VA = "0x1863885F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static float KBIBEJMGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6387DF0", Offset = "0x6386DF0", VA = "0x186387DF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6388B90", Offset = "0x6387B90", VA = "0x186388B90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static int KKPKLEBGDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6388CF0", Offset = "0x6387CF0", VA = "0x186388CF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6387290", Offset = "0x6386290", VA = "0x186387290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int NOLDFONIOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6387080", Offset = "0x6386080", VA = "0x186387080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6387130", Offset = "0x6386130", VA = "0x186387130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int IJCPFLIOHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6388710", Offset = "0x6387710", VA = "0x186388710")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6388A20", Offset = "0x6387A20", VA = "0x186388A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int HPELLGEFPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6387E90", Offset = "0x6386E90", VA = "0x186387E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6387350", Offset = "0x6386350", VA = "0x186387350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int BCOEKAIDHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6388B40", Offset = "0x6387B40", VA = "0x186388B40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6387630", Offset = "0x6386630", VA = "0x186387630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int INFDFLALMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6388970", Offset = "0x6387970", VA = "0x186388970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x63872F0", Offset = "0x63862F0", VA = "0x1863872F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int DJFCBLNDMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63863D0", Offset = "0x63853D0", VA = "0x1863863D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6387CD0", Offset = "0x6386CD0", VA = "0x186387CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int GMNEPGFCOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6388760", Offset = "0x6387760", VA = "0x186388760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6387BC0", Offset = "0x6386BC0", VA = "0x186387BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int IFLGJGMCCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6388920", Offset = "0x6387920", VA = "0x186388920")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6387520", Offset = "0x6386520", VA = "0x186387520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int AGMBDDKOKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6387E40", Offset = "0x6386E40", VA = "0x186387E40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63883D0", Offset = "0x63873D0", VA = "0x1863883D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int NJEAPKIMFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x63877F0", Offset = "0x63867F0", VA = "0x1863877F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6387690", Offset = "0x6386690", VA = "0x186387690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int FKPBDLFIJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63881B0", Offset = "0x63871B0", VA = "0x1863881B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6388AE0", Offset = "0x6387AE0", VA = "0x186388AE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int GJBGEPKDOFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6388310", Offset = "0x6387310", VA = "0x186388310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6387F30", Offset = "0x6386F30", VA = "0x186387F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int LBDNJIMKEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6388430", Offset = "0x6387430", VA = "0x186388430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6387790", Offset = "0x6386790", VA = "0x186387790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int PKBOBABNIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6388D40", Offset = "0x6387D40", VA = "0x186388D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6388250", Offset = "0x6387250", VA = "0x186388250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool LHCCINFEGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63875E0", Offset = "0x63865E0", VA = "0x1863875E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63884E0", Offset = "0x63874E0", VA = "0x1863884E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool KENBKAMCHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6388BF0", Offset = "0x6387BF0", VA = "0x186388BF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6387B60", Offset = "0x6386B60", VA = "0x186387B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static JNLLICLPBDM KFAGHKEDLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63888D0", Offset = "0x63878D0", VA = "0x1863888D0")]
		[CompilerGenerated]
		get
		{
			return default(JNLLICLPBDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6386FA0", Offset = "0x6385FA0", VA = "0x186386FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool OLIALMGHNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6387EE0", Offset = "0x6386EE0", VA = "0x186387EE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63873B0", Offset = "0x63863B0", VA = "0x1863873B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static float OIGMPDBHEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6386380", Offset = "0x6385380", VA = "0x186386380")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6388C90", Offset = "0x6387C90", VA = "0x186388C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static float EJBJEJNFPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6387FE0", Offset = "0x6386FE0", VA = "0x186387FE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6387A40", Offset = "0x6386A40", VA = "0x186387A40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static float GLBKBNJCLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6387410", Offset = "0x6386410", VA = "0x186387410")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6387D30", Offset = "0x6386D30", VA = "0x186387D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float OKMBLKLEJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6388200", Offset = "0x6387200", VA = "0x186388200")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6388590", Offset = "0x6387590", VA = "0x186388590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float KNFIGADCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6388C40", Offset = "0x6387C40", VA = "0x186388C40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6387D90", Offset = "0x6386D90", VA = "0x186387D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float PJEDBJMBJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6387740", Offset = "0x6386740", VA = "0x186387740")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6387C20", Offset = "0x6386C20", VA = "0x186387C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool FKGGAEBIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6387840", Offset = "0x6386840", VA = "0x186387840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x63874C0", Offset = "0x63864C0", VA = "0x1863874C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float HCNKPDMOFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6388A80", Offset = "0x6387A80", VA = "0x186388A80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6388480", Offset = "0x6387480", VA = "0x186388480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static int JNBGGBADMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63880E0", Offset = "0x63870E0", VA = "0x1863880E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63879E0", Offset = "0x63869E0", VA = "0x1863879E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static int CCIGBJAOPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x63887B0", Offset = "0x63877B0", VA = "0x1863887B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6388650", Offset = "0x6387650", VA = "0x186388650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool MCILNCGOLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x63882B0", Offset = "0x63872B0", VA = "0x1863882B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int NFEMBIKFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63889C0", Offset = "0x63879C0", VA = "0x1863889C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6388810", Offset = "0x6387810", VA = "0x186388810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static float4x4 FHIPBPPFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x63878A0", Offset = "0x63868A0", VA = "0x1863878A0")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6387000", Offset = "0x6386000", VA = "0x186387000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static float3 NGEOGGOEDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6388360", Offset = "0x6387360", VA = "0x186388360")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6388140", Offset = "0x6387140", VA = "0x186388140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static bool CMFFEJCKKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6387B00", Offset = "0x6386B00", VA = "0x186387B00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63870D0", Offset = "0x63860D0", VA = "0x1863870D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static CKKBNAGJDNL IGFNECLHLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6387580", Offset = "0x6386580", VA = "0x186387580")]
		[CompilerGenerated]
		get
		{
			return default(CKKBNAGJDNL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6387AA0", Offset = "0x6386AA0", VA = "0x186387AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static bool DIHFMPOMJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6386520", Offset = "0x6385520", VA = "0x186386520")]
	public static void AOHAKILHFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x63871E0", Offset = "0x63861E0", VA = "0x1863871E0")]
	public static void BOPMAGAEOGI(KPENAGDIPPA KLNGEFCCPMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GNAIPGKPENG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct CFCEHGCBLCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Vector3 IGEPLDPOGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Quaternion FOPINBOOFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public float PHDJGAMIKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Quaternion NDLOIACPCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float CFDJKHGDJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public float FNPEGMKHAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public float AODLJMDDMJD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static List<CFCEHGCBLCF> NOJGLGDHELF;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x638BDA0", Offset = "0x638ADA0", VA = "0x18638BDA0")]
	public static NativeList<CCLJNANFHKL> NGEGGGCGEND(KBNBIJKOBIF LHAGOFJLFBG)
	{
		return default(NativeList<CCLJNANFHKL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6389300", Offset = "0x6388300", VA = "0x186389300")]
	private static bool GNBBKOGEKCN(int AFFJDCKHCJD, NativeList<CCLJNANFHKL> NIKEINPNLMA, List<CFCEHGCBLCF> BFMIAAGKDCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x638C320", Offset = "0x638B320", VA = "0x18638C320")]
	private static CCLJNANFHKL PCKAOGKONHF(int MNONMOOEFIJ, List<CFCEHGCBLCF> BFMIAAGKDCA)
	{
		return default(CCLJNANFHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x638A2E0", Offset = "0x63892E0", VA = "0x18638A2E0")]
	private static CCLJNANFHKL HLHOIMJGGCA(int MNONMOOEFIJ, List<CFCEHGCBLCF> BFMIAAGKDCA)
	{
		return default(CCLJNANFHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x638BCC0", Offset = "0x638ACC0", VA = "0x18638BCC0")]
	private static CCLJNANFHKL JBFOAPGHFPA(Vector3 PDJLKPJAKEO, Quaternion DGBIMPLNOFD, float LIIEEBDEIFN)
	{
		return default(CCLJNANFHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x638A7F0", Offset = "0x63897F0", VA = "0x18638A7F0")]
	public static NativeList<CCLJNANFHKL> IABDEMMGINK(KBNBIJKOBIF LHAGOFJLFBG, float LOMNEFPEIBD)
	{
		return default(NativeList<CCLJNANFHKL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ALBAPCHPLHK
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static Vector3 CADPDBEDOOK;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static Vector3 NJAFGHGHKKI;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly float FLLBILKJKMH;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6384EF0", Offset = "0x6383EF0", VA = "0x186384EF0")]
	public static Vector3 BDBDEJAOAKO(Vector3 NDLOBOCDNJK, Quaternion DGBIMPLNOFD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6385840", Offset = "0x6384840", VA = "0x186385840")]
	public static Vector3 FPNGAIDGFPH(Quaternion CKCOAEGKOKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6385370", Offset = "0x6384370", VA = "0x186385370")]
	public static Vector3 CCGGKKBLHEH(Quaternion CKCOAEGKOKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6385A50", Offset = "0x6384A50", VA = "0x186385A50")]
	public static Quaternion INIHBDPINGG(Vector3 PFFNCAKFCDH, Vector3 KMBEHGBELJC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6385180", Offset = "0x6384180", VA = "0x186385180")]
	public static Vector3 BPMFOEDICHC(Vector3 AOBBNPJCINA, Vector3 MOOOEPPEIPC, Vector3 KMBEHGBELJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6385410", Offset = "0x6384410", VA = "0x186385410")]
	public static Vector3 CLCJICLLIAO(Vector3 NDLOBOCDNJK, Vector3 KMBEHGBELJC, Quaternion CKCOAEGKOKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6385AD0", Offset = "0x6384AD0", VA = "0x186385AD0")]
	public static Quaternion OMCGLGICAAB(Quaternion DGBIMPLNOFD, Vector3 PFFNCAKFCDH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x63858E0", Offset = "0x63848E0", VA = "0x1863858E0")]
	public static bool GOGBAPELIML(Vector3 CHBLENCIGBD, Vector3 NKNNFCHCLPC, [Out] Vector3 JIANBIILENJ, bool DEGLDEDELGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6385E40", Offset = "0x6384E40", VA = "0x186385E40")]
	public static Vector3 PMJJNHDGEBF(bool DLHPMDJBJLI, [Optional] Quaternion NOAFCBIDKLE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CCLJNANFHKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public float3 IGEPLDPOGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public float3x3 FOPINBOOFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public float PHDJGAMIKIE;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KBNBIJKOBIF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	int LNGOGJCKGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 GIOBHDGLBLN(int MNONMOOEFIJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion CDLIDLMFBGM(int MNONMOOEFIJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float FLGENDIOMAI(int MNONMOOEFIJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OJKNMAHEHCD : KEEOOPJEBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool IKDJKAHEBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool HLHLLGCGOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float IJGOLHFOKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	int FINOIDGFHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool FDELKLJPCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int OONMFAHLNEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CCLJNANFHKL> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PFDIJHJAKJD : KEEOOPJEBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KKCFIPIKEPK OIDHDJDILNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool JIIGBKANJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IPNPOPBOEBA
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	PPOBKJNJKIH EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	JMAHILJOHIJ FOLOOEELIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KEEOOPJEBHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool BDGKBCCNNFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LMCLIDBOLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	PPOBKJNJKIH EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float BMDLHMKDBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Vector3 GAEPBAOBIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	BPMNKHLKDDH EJMOHCIOJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	DEJBNHJMHIH AGFKDHGOKEM
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
public interface IPNGPABGGMN
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int DKBIOJMNDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Transform KMMMJMPJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool BLFAIBPOAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BBMDIEDIPLD GetBone(int MNONMOOEFIJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MNONMOOEFIJ);
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
