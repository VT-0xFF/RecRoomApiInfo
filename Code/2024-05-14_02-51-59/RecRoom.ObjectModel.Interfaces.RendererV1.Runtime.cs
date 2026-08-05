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
public enum PHNCGJOIBFL
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
public enum EFHPIJLIOIK
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
public enum OBNHFCOBEID
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
public enum KNPBIJLHHPJ
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
public enum MNMFDBFBFJA
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
public enum GLILLNDJLFB
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
public static class OEJFHIIIAJM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64198D0", Offset = "0x64182D0", VA = "0x1864198D0")]
	public static bool HMMFGEHMDLP(this GLILLNDJLFB OMMABLAKJOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6419920", Offset = "0x6418320", VA = "0x186419920")]
	public static bool PJMPMAGMNIH(this GLILLNDJLFB OMMABLAKJOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64198F0", Offset = "0x64182F0", VA = "0x1864198F0")]
	public static bool KDHLKCMMJDB(this GLILLNDJLFB OMMABLAKJOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HNHHCMALDIM
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
public struct LIEAFFMBAHO : FJKKAFGOBOJ, IEquatable<LIEAFFMBAHO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int JIFJFCOEJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int HEDMKAPCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23C7760", Offset = "0x23C6160", VA = "0x1823C7760", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x575D410", Offset = "0x575BE10", VA = "0x18575D410", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PCOPBBJPOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6419730", Offset = "0x6418130", VA = "0x186419730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D84540", Offset = "0x1D82F40", VA = "0x181D84540", Slot = "8")]
	public bool Equals(LIEAFFMBAHO HKMMPHJFKEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x62FDDF0", Offset = "0x62FC7F0", VA = "0x1862FDDF0")]
	public static bool EGKBPOJOPJH(LIEAFFMBAHO LMANHAAPNDE, LIEAFFMBAHO AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64196A0", Offset = "0x64180A0", VA = "0x1864196A0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6419770", Offset = "0x6418170", VA = "0x186419770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EBLCGBPHAAH : FJKKAFGOBOJ, IEquatable<EBLCGBPHAAH>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int JIFJFCOEJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int HEDMKAPCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x23C7760", Offset = "0x23C6160", VA = "0x1823C7760", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x575D410", Offset = "0x575BE10", VA = "0x18575D410", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PCOPBBJPOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6412E80", Offset = "0x6411880", VA = "0x186412E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D84540", Offset = "0x1D82F40", VA = "0x181D84540", Slot = "8")]
	public bool Equals(EBLCGBPHAAH HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6412DF0", Offset = "0x64117F0", VA = "0x186412DF0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6412EC0", Offset = "0x64118C0", VA = "0x186412EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NBCBMMHFGOH : FJKKAFGOBOJ, IEquatable<NBCBMMHFGOH>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JIFJFCOEJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HEDMKAPCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x23C7760", Offset = "0x23C6160", VA = "0x1823C7760", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x575D410", Offset = "0x575BE10", VA = "0x18575D410", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PCOPBBJPOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6419890", Offset = "0x6418290", VA = "0x186419890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D84540", Offset = "0x1D82F40", VA = "0x181D84540", Slot = "8")]
	public bool Equals(NBCBMMHFGOH HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6419800", Offset = "0x6418200", VA = "0x186419800", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KDMFOCPNFEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGJIHEFLPOM(LIEAFFMBAHO AKBOHBAKCNP, EFHPIJLIOIK EJPJPMIOAKL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGJIHEFLPOM(EBLCGBPHAAH HCLPPDPEFHM, EFHPIJLIOIK EJPJPMIOAKL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMNKKBKNLAA(EBLCGBPHAAH HCLPPDPEFHM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GDOMEJNBEFG(EBLCGBPHAAH HCLPPDPEFHM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHAJNBBJAHK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJCCFLCFOIC(EFHPIJLIOIK CGEOAHHPHHK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PFHCMDPDCIG(LIEAFFMBAHO AKBOHBAKCNP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFHCMDPDCIG(EBLCGBPHAAH HCLPPDPEFHM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OJBGLOHPGBM(EBLCGBPHAAH HCLPPDPEFHM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FMFAAGGKLNB(EBLCGBPHAAH HCLPPDPEFHM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FDGAGIGPECE();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JOHIJAPMDKK();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BAKNJPOBCEK(LIEAFFMBAHO AKBOHBAKCNP, MNMFDBFBFJA CGEOAHHPHHK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DFIBJHKCGDC(EBLCGBPHAAH HCLPPDPEFHM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OPKOBOPKMIO(EBLCGBPHAAH HCLPPDPEFHM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MOEGFAKHEFA();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NJKALBHCMNE(MNMFDBFBFJA CGEOAHHPHHK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PLFNKMCNKGB(LIEAFFMBAHO AKBOHBAKCNP, Vector3 GFLJFAFBICF, Vector3 ACEBJFFIIMA, Vector3 LIJLMMLBION, float HLHEICOKHFF, float LBHMOHAKOFO, IReadOnlyList<Camera> IACCCAAAOOK, PHNCGJOIBFL FHPGJMKLOAG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PLFNKMCNKGB(NBCBMMHFGOH MIAJGOBEJHP, Vector3 GFLJFAFBICF, Vector3 ACEBJFFIIMA, Vector3 LIJLMMLBION, float HLHEICOKHFF, float LBHMOHAKOFO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BMHCNCJHKII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MGFHILMOIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIEAFFMBAHO MNBAHFLIFGN(JDMFLHLNKFE ABDLEBPKDKC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LIEAFFMBAHO MNBAHFLIFGN(JDMFLHLNKFE ABDLEBPKDKC, bool LGJOKNINJPK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFADKLMDIFP(LIEAFFMBAHO AKBOHBAKCNP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAHAEPOBECE(LIEAFFMBAHO AKBOHBAKCNP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EBLCGBPHAAH AOCIOPHFHHA(LIEAFFMBAHO AKBOHBAKCNP, GIJMMFBEEEK ABDLEBPKDKC);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EBLCGBPHAAH MNPKJCNJEDN(LIEAFFMBAHO AKBOHBAKCNP, HHPPJMNAKOA ABDLEBPKDKC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IKNKFMEHKMO(EBLCGBPHAAH HCLPPDPEFHM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MGLMIDIHBIC(EBLCGBPHAAH HCLPPDPEFHM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NBCBMMHFGOH LCKGCGJDBKH(FPNMIKFEFNF ABDLEBPKDKC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MLFJEIOJBMA(NBCBMMHFGOH MIAJGOBEJHP);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NEHLMKBDPAE(NBCBMMHFGOH MIAJGOBEJHP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task NNKHPJGJKLB();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task HFGFHJGHDEJ();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FDLPMNGLDPI();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PGAIAIMOGLA();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> FEGMDAIEHCE(LIEAFFMBAHO AKBOHBAKCNP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HGDEHBOGPNC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum IFJKFJOOJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum OFCKBCILGJG
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum JIGEAMMCNBI
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum KODFOMLOPLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		ErrorCalculated,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum FMACLHFDFDO
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Quest3
	}

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static int DBGPNLGMKPP;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static int FGMOEIILILD;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static int MDACFFAKMDA;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int MEHOMPICPNN;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int[] MOHLEGAAPID;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int FMJABDBPENJ;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int IJEFIBGPNLF;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static int IMABIGPJPIL;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static long FCCINGFNCMB;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static long GKMDDFKONGO;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static long BCJCGEKGPKH;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long GJLOPAOJNLH;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long PEHPKDDKJJC;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long ILMCGIIJEFI;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long BOBMCICBFOG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long KEEICABNODI;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long JCECHBKDDNH;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long DGPKHFACGKM;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long LPFFMJIBCMJ;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static long FABEFLLMJBI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static float GDLHEFEMHMB;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long EPEMJJMIGKH;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long JJOBILMMEDF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool IMOHIJHLFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6414040", Offset = "0x6412A40", VA = "0x186414040")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6412F50", Offset = "0x6411950", VA = "0x186412F50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static FMACLHFDFDO LDCPLPBDIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x64153C0", Offset = "0x6413DC0", VA = "0x1864153C0")]
		[CompilerGenerated]
		get
		{
			return default(FMACLHFDFDO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6415360", Offset = "0x6413D60", VA = "0x186415360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool DGFOGGBGJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x64156E0", Offset = "0x64140E0", VA = "0x1864156E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6415730", Offset = "0x6414130", VA = "0x186415730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static IFJKFJOOJHJ PNLLBHPDEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x64149B0", Offset = "0x64133B0", VA = "0x1864149B0")]
		[CompilerGenerated]
		get
		{
			return default(IFJKFJOOJHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x64140F0", Offset = "0x6412AF0", VA = "0x1864140F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool HGOMIGMOPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x64151A0", Offset = "0x6413BA0", VA = "0x1864151A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6415680", Offset = "0x6414080", VA = "0x186415680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static OFCKBCILGJG FIHEIOKLPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x64154D0", Offset = "0x6413ED0", VA = "0x1864154D0")]
		[CompilerGenerated]
		get
		{
			return default(OFCKBCILGJG);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64152B0", Offset = "0x6413CB0", VA = "0x1864152B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool PPIPADHBKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6414D30", Offset = "0x6413730", VA = "0x186414D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6415E50", Offset = "0x6414850", VA = "0x186415E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool IAJPFIJDMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6413050", Offset = "0x6411A50", VA = "0x186413050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6414E20", Offset = "0x6413820", VA = "0x186414E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool HJONFBOJICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6415A50", Offset = "0x6414450", VA = "0x186415A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6415090", Offset = "0x6413A90", VA = "0x186415090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float OMBMHKBDMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6414D80", Offset = "0x6413780", VA = "0x186414D80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x64132F0", Offset = "0x6411CF0", VA = "0x1864132F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int GMKHEDMOFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6415B70", Offset = "0x6414570", VA = "0x186415B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x64151F0", Offset = "0x6413BF0", VA = "0x1864151F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int DFFJPOBOGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6414A00", Offset = "0x6413400", VA = "0x186414A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6414150", Offset = "0x6412B50", VA = "0x186414150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int JECCFEHJMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x64155D0", Offset = "0x6413FD0", VA = "0x1864155D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6413ED0", Offset = "0x64128D0", VA = "0x186413ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int IBIEHDOOJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6415B20", Offset = "0x6414520", VA = "0x186415B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x64147C0", Offset = "0x64131C0", VA = "0x1864147C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int CGHMGBCPAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6415C70", Offset = "0x6414670", VA = "0x186415C70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6414B00", Offset = "0x6413500", VA = "0x186414B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int HJIMCDADNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6414DD0", Offset = "0x64137D0", VA = "0x186414DD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6415940", Offset = "0x6414340", VA = "0x186415940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int MIFGJLCCNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64150F0", Offset = "0x6413AF0", VA = "0x1864150F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6415520", Offset = "0x6413F20", VA = "0x186415520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int MEKEGOHCOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6415310", Offset = "0x6413D10", VA = "0x186415310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6413E70", Offset = "0x6412870", VA = "0x186413E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int AKBOHMIPABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6413240", Offset = "0x6411C40", VA = "0x186413240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6414760", Offset = "0x6413160", VA = "0x186414760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int KPNMMOEIOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x64159A0", Offset = "0x64143A0", VA = "0x1864159A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x64141B0", Offset = "0x6412BB0", VA = "0x1864141B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int CHPECAGACGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6415C20", Offset = "0x6414620", VA = "0x186415C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6415030", Offset = "0x6413A30", VA = "0x186415030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int JBACPBOIGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6415EB0", Offset = "0x64148B0", VA = "0x186415EB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x64130A0", Offset = "0x6411AA0", VA = "0x1864130A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int HHJJNIBALJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x64157E0", Offset = "0x64141E0", VA = "0x1864157E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6414B60", Offset = "0x6413560", VA = "0x186414B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int IDLNNJONNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6415790", Offset = "0x6414190", VA = "0x186415790")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6414C70", Offset = "0x6413670", VA = "0x186414C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static int HCIJJIDJPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6414A50", Offset = "0x6413450", VA = "0x186414A50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6414820", Offset = "0x6413220", VA = "0x186414820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool KGGEKFLEOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6415580", Offset = "0x6413F80", VA = "0x186415580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x64148F0", Offset = "0x64132F0", VA = "0x1864148F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool CECJJGDDILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6412FB0", Offset = "0x64119B0", VA = "0x186412FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6415250", Offset = "0x6413C50", VA = "0x186415250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static JIGEAMMCNBI OOBDDFEKMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6413F30", Offset = "0x6412930", VA = "0x186413F30")]
		[CompilerGenerated]
		get
		{
			return default(JIGEAMMCNBI);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6414F20", Offset = "0x6413920", VA = "0x186414F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static bool GLAGGFLOADO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6414E80", Offset = "0x6413880", VA = "0x186414E80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6413E10", Offset = "0x6412810", VA = "0x186413E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static float AKILGHHJCPB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6414FE0", Offset = "0x64139E0", VA = "0x186414FE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64159F0", Offset = "0x64143F0", VA = "0x1864159F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static float DKGFIIPABKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x64158F0", Offset = "0x64142F0", VA = "0x1864158F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6415DF0", Offset = "0x64147F0", VA = "0x186415DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float MEDPNPDCJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6414ED0", Offset = "0x64138D0", VA = "0x186414ED0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6415470", Offset = "0x6413E70", VA = "0x186415470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float CCEGECOIADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6413000", Offset = "0x6411A00", VA = "0x186413000")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6413180", Offset = "0x6411B80", VA = "0x186413180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float MILFDIMNGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6414BC0", Offset = "0x64135C0", VA = "0x186414BC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6415CC0", Offset = "0x64146C0", VA = "0x186415CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static float KFNFIMGPBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6413FE0", Offset = "0x64129E0", VA = "0x186413FE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6415D20", Offset = "0x6414720", VA = "0x186415D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool CBDPHMDCPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6414AA0", Offset = "0x64134A0", VA = "0x186414AA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6413290", Offset = "0x6411C90", VA = "0x186413290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float NABFJFIPFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6415890", Offset = "0x6414290", VA = "0x186415890")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6415140", Offset = "0x6413B40", VA = "0x186415140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static int GPDJODKHNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6415410", Offset = "0x6413E10", VA = "0x186415410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64131E0", Offset = "0x6411BE0", VA = "0x1864131E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static int OLIDJCGJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6414C10", Offset = "0x6413610", VA = "0x186414C10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6415620", Offset = "0x6414020", VA = "0x186415620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool BHKCJGADHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6413F80", Offset = "0x6412980", VA = "0x186413F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int AKFFNLPLOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6414F80", Offset = "0x6413980", VA = "0x186414F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6414CD0", Offset = "0x64136D0", VA = "0x186414CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static float4x4 BKNDHFAFAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6413100", Offset = "0x6411B00", VA = "0x186413100")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6415AA0", Offset = "0x64144A0", VA = "0x186415AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static float3 PFEFGKKHGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6414880", Offset = "0x6413280", VA = "0x186414880")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6415D80", Offset = "0x6414780", VA = "0x186415D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static bool MMHOBLMNFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6414950", Offset = "0x6413350", VA = "0x186414950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6415BC0", Offset = "0x64145C0", VA = "0x186415BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static KODFOMLOPLI GPDOEMKDNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6415830", Offset = "0x6414230", VA = "0x186415830")]
		[CompilerGenerated]
		get
		{
			return default(KODFOMLOPLI);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6414090", Offset = "0x6412A90", VA = "0x186414090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6413350", Offset = "0x6411D50", VA = "0x186413350")]
	public static void CIJGEEHMACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6414210", Offset = "0x6412C10", VA = "0x186414210")]
	public static void FLJPCGCFHLP(FMACLHFDFDO GAAKFBHNHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KBOOJMDLCHH
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct GCJIHNEJCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Vector3 LDHIOGOHNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Quaternion BPHIJKBMKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public float BOEKNCOKMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Quaternion JIDGMKAEJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public float JJFNLDLLBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public float OGAKEANHDIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public float IEKHKFKFMMB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static List<GCJIHNEJCDJ> MNEJALBDKPK;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6417B00", Offset = "0x6416500", VA = "0x186417B00")]
	public static NativeList<CBFDAHLKPCD> OHLJAJALALE(NKEAPKEDOCP BAEGICLJJGI)
	{
		return default(NativeList<CBFDAHLKPCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6416480", Offset = "0x6414E80", VA = "0x186416480")]
	private static bool APJHFKLCACA(int AJODNFJNJPO, NativeList<CBFDAHLKPCD> LKBGEIGOHEF, List<GCJIHNEJCDJ> LLCJGKFFGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6417970", Offset = "0x6416370", VA = "0x186417970")]
	private static CBFDAHLKPCD FMCIHGKKGPC(int OGNEKOOOPHL, List<GCJIHNEJCDJ> LLCJGKFFGHN)
	{
		return default(CBFDAHLKPCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6417460", Offset = "0x6415E60", VA = "0x186417460")]
	private static CBFDAHLKPCD FINNANBDJCI(int OGNEKOOOPHL, List<GCJIHNEJCDJ> LLCJGKFFGHN)
	{
		return default(CBFDAHLKPCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6419530", Offset = "0x6417F30", VA = "0x186419530")]
	private static CBFDAHLKPCD PKLOAEJEDNK(Vector3 BNPKKMNBEBA, Quaternion CMIACCILPCG, float JMJINJAJLIO)
	{
		return default(CBFDAHLKPCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6418070", Offset = "0x6416A70", VA = "0x186418070")]
	public static NativeList<CBFDAHLKPCD> PGGEIIDCACN(NKEAPKEDOCP BAEGICLJJGI, float CKFCKOLPDIG)
	{
		return default(NativeList<CBFDAHLKPCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BIANCDGBIIE
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static Vector3 BMOIBDOHAAD;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static Vector3 IAEONEBOEEN;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static readonly float ACNCNFHMOAP;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6411CE0", Offset = "0x64106E0", VA = "0x186411CE0")]
	public static Vector3 CANCJIDJKPA(Vector3 FEJANOFHOGF, Quaternion CMIACCILPCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6411AD0", Offset = "0x64104D0", VA = "0x186411AD0")]
	public static Vector3 ALJHONEHCJE(Quaternion DMBBOEJIOJM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6412790", Offset = "0x6411190", VA = "0x186412790")]
	public static Vector3 NFIIOOKICOF(Quaternion DMBBOEJIOJM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x64123A0", Offset = "0x6410DA0", VA = "0x1864123A0")]
	public static Quaternion FMLJOOMDOGA(Vector3 COKBJHHCBCI, Vector3 AMMBIDJOPFP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6412830", Offset = "0x6411230", VA = "0x186412830")]
	public static Vector3 NHOCPDEDFPL(Vector3 BCKKIKMGKLA, Vector3 GAMGOHDEIDF, Vector3 AMMBIDJOPFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6411F70", Offset = "0x6410970", VA = "0x186411F70")]
	public static Vector3 DDDNGFHAJJP(Vector3 FEJANOFHOGF, Vector3 AMMBIDJOPFP, Quaternion DMBBOEJIOJM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6412420", Offset = "0x6410E20", VA = "0x186412420")]
	public static Quaternion KDJGDPLCDAE(Quaternion CMIACCILPCG, Vector3 COKBJHHCBCI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6411B70", Offset = "0x6410570", VA = "0x186411B70")]
	public static bool ANOEFOCEOMO(Vector3 PJJBHDDLOFN, Vector3 MFFLCHANEMA, [Out] Vector3 FDDEPLNPPCK, bool DNHAMJCGJEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6412A20", Offset = "0x6411420", VA = "0x186412A20")]
	public static Vector3 OPKCOHKFKBE(bool EDPJPJMMGEM, [Optional] Quaternion HGJBDLHNMKO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CBFDAHLKPCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public float3 LDHIOGOHNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public float3x3 BPHIJKBMKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public float BOEKNCOKMNE;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NKEAPKEDOCP
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	int AHPFFGOLBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BNCPMDAMMFJ(int OGNEKOOOPHL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion LJHJIDAIODK(int OGNEKOOOPHL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float HPMONBMGLIF(int OGNEKOOOPHL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HHPPJMNAKOA : CEGKEBIJKKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool FPCHIKPHFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool LLMKLLEHOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float PMNBLKELMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	int DBLCOKLBHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool OFHANOIIDDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int MECONDKCGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CBFDAHLKPCD> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GIJMMFBEEEK : CEGKEBIJKKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OBNHFCOBEID LMGJJDHDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool LCEAIGCMMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface JDMFLHLNKFE
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	BGDAMFGELKE LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KNPBIJLHHPJ EEOBAKLLIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CEGKEBIJKKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool PELJNIMEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool PJMOBHILCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BGDAMFGELKE LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	float LOJLEIOPNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Vector3 OCGCEGOJCBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	GLILLNDJLFB KIFABPBOINC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	HNHHCMALDIM OHKGFFPNHAM
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
public interface FPNMIKFEFNF
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int AFAPKNLPPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Transform LIDCIDGJCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool KJIAKJBEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LIEAFFMBAHO GetBone(int OGNEKOOOPHL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int OGNEKOOOPHL);
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
