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
public enum ACIEAJENAGK
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
public enum JEPJJIBBHEG
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
public enum AMMHJAALNKH
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
public enum KGPJBFJONFL
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
public enum JJCNGLHDEFE
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
public enum MFEJNOLPLDN
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
public static class IBEDJLHIEHD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A32B30", Offset = "0x6A31130", VA = "0x186A32B30")]
	public static bool CLGMKJDAKEO(this MFEJNOLPLDN HAPMLKMMFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A32B50", Offset = "0x6A31150", VA = "0x186A32B50")]
	public static bool NFMIPGOMKCL(this MFEJNOLPLDN HAPMLKMMFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A32B00", Offset = "0x6A31100", VA = "0x186A32B00")]
	public static bool AJGJCOFEBIK(this MFEJNOLPLDN HAPMLKMMFPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BDKEFENGGMG
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
public struct NDBOEPEGOEB : BNGFLHDNNIJ, IEquatable<NDBOEPEGOEB>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int FPNFNABMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA882D0", Offset = "0xA868D0", VA = "0x180A882D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA882B0", Offset = "0xA868B0", VA = "0x180A882B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int HJHABCPEMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25421D0", Offset = "0x25407D0", VA = "0x1825421D0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B720", Offset = "0x5D29D20", VA = "0x185D2B720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DJDJJCHPPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A365C0", Offset = "0x6A34BC0", VA = "0x186A365C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1EAE0D0", Offset = "0x1EAC6D0", VA = "0x181EAE0D0", Slot = "8")]
	public bool Equals(NDBOEPEGOEB LJAAPFIIPOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68FEE40", Offset = "0x68FD440", VA = "0x1868FEE40")]
	public static bool GJBEBFKCOKB(NDBOEPEGOEB FAGKOOGCGBH, NDBOEPEGOEB HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A36600", Offset = "0x6A34C00", VA = "0x186A36600", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA882D0", Offset = "0xA868D0", VA = "0x180A882D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A36690", Offset = "0x6A34C90", VA = "0x186A36690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FPDMCLNMJHD : BNGFLHDNNIJ, IEquatable<FPDMCLNMJHD>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int FPNFNABMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA882D0", Offset = "0xA868D0", VA = "0x180A882D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA882B0", Offset = "0xA868B0", VA = "0x180A882B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int HJHABCPEMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x25421D0", Offset = "0x25407D0", VA = "0x1825421D0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B720", Offset = "0x5D29D20", VA = "0x185D2B720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DJDJJCHPPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6A329A0", Offset = "0x6A30FA0", VA = "0x186A329A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1EAE0D0", Offset = "0x1EAC6D0", VA = "0x181EAE0D0", Slot = "8")]
	public bool Equals(FPDMCLNMJHD LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A329E0", Offset = "0x6A30FE0", VA = "0x186A329E0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA882D0", Offset = "0xA868D0", VA = "0x180A882D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A32A70", Offset = "0x6A31070", VA = "0x186A32A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JBGDGPDLAMB : BNGFLHDNNIJ, IEquatable<JBGDGPDLAMB>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FPNFNABMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA882D0", Offset = "0xA868D0", VA = "0x180A882D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA882B0", Offset = "0xA868B0", VA = "0x180A882B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HJHABCPEMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x25421D0", Offset = "0x25407D0", VA = "0x1825421D0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B720", Offset = "0x5D29D20", VA = "0x185D2B720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DJDJJCHPPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A32B60", Offset = "0x6A31160", VA = "0x186A32B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1EAE0D0", Offset = "0x1EAC6D0", VA = "0x181EAE0D0", Slot = "8")]
	public bool Equals(JBGDGPDLAMB LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A32BA0", Offset = "0x6A311A0", VA = "0x186A32BA0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA882D0", Offset = "0xA868D0", VA = "0x180A882D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JACMAOMLFJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGAABNKABJO(NDBOEPEGOEB FMGEJNFFGHE, JEPJJIBBHEG DHLLILNPCMI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGAABNKABJO(FPDMCLNMJHD ALHFHMDBPCO, JEPJJIBBHEG DHLLILNPCMI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNFPDDIEJBP(FPDMCLNMJHD ALHFHMDBPCO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FFFILABLANL(FPDMCLNMJHD ALHFHMDBPCO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCMHNOLKCMM();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGHGJIFHLDL(JEPJJIBBHEG PBLNJHEPKAE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JJFNNJKHPHB(NDBOEPEGOEB FMGEJNFFGHE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JJFNNJKHPHB(FPDMCLNMJHD ALHFHMDBPCO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NNMHCKOMILI(FPDMCLNMJHD ALHFHMDBPCO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KPKGGDNHNMJ(FPDMCLNMJHD ALHFHMDBPCO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DMBAHCJBDGN();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HGGNFPIABAD();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GEBMGJPOGGM(NDBOEPEGOEB FMGEJNFFGHE, JJCNGLHDEFE PBLNJHEPKAE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KIJFLCJMAKE(FPDMCLNMJHD ALHFHMDBPCO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LINBAJPNHJH(FPDMCLNMJHD ALHFHMDBPCO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CLGOFKAPNAF();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NIMDBOACKDM(JJCNGLHDEFE PBLNJHEPKAE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GKGJKIKNFBE(NDBOEPEGOEB FMGEJNFFGHE, Vector3 IECFMKDOBKO, Vector3 DBIKBDKKIOA, Vector3 PPCIOFACCND, float GBECOGBPLEB, float JDKLIOJMLLI, IReadOnlyList<Camera> FJKEGEKFECM, ACIEAJENAGK HPHJNBDKOPI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GKGJKIKNFBE(JBGDGPDLAMB KFGKOIFCNEG, Vector3 IECFMKDOBKO, Vector3 DBIKBDKKIOA, Vector3 PPCIOFACCND, float GBECOGBPLEB, float JDKLIOJMLLI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LBJKKAKJIAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BAFKCIPENON
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDBOEPEGOEB OPGIJAIKEGK(MKAOLEKNIFJ FHNKDHIILBL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NDBOEPEGOEB OPGIJAIKEGK(MKAOLEKNIFJ FHNKDHIILBL, bool HKNGEAHJEDI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDIGAAFKIAP(NDBOEPEGOEB FMGEJNFFGHE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPCICLNOMAN(NDBOEPEGOEB FMGEJNFFGHE);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FPDMCLNMJHD MFICNAFJHIM(NDBOEPEGOEB FMGEJNFFGHE, AJNLFLEOCJI FHNKDHIILBL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FPDMCLNMJHD MBHMAMEHLMC(NDBOEPEGOEB FMGEJNFFGHE, EMAFIBLKHLE FHNKDHIILBL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GCEEIFBPJDB(FPDMCLNMJHD ALHFHMDBPCO);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLPBPCFOHDB(FPDMCLNMJHD ALHFHMDBPCO);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JBGDGPDLAMB HMOBIGLPBII(NJHBOPFIOFI FHNKDHIILBL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KGBIOICIGML(JBGDGPDLAMB KFGKOIFCNEG);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HDIOMPPAKEN(JBGDGPDLAMB KFGKOIFCNEG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task NGDEPBLOENH();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DAHEICECLKE();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task NDADOCJPIPO();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CHKLJCBJMKM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> AEBBIAHJMIN(NDBOEPEGOEB FMGEJNFFGHE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MBJMEEJFJOD
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum DNFMFKKKPAC
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
	public enum KHLEPCALIHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum BGHODPHMPEM
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
	public enum PENODHNNLNO
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
	public enum MFCBPHLDCGF
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
	public enum INLFLMAGBNI
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
	public static int FBHHHNMDHGE;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int PPJEKOOINDJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int DBMBPKAJHGL;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int DGGODKMKDCF;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static int[] EKMFFCBFKDD;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static int NMKPAPDOFAI;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static int HPNJPEPDAKG;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static int DMHKAFNGAKK;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static long FNNCOEDMHND;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long FJAMPENMEHM;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static long AKEOHBINOMO;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static long HMOKOOOJJMM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static long CMDPNHKPCIL;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static long KIEHGBEKHGL;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static long KOMMKEPCODB;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static long LJLFLCEGEAI;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static long LDFNNPEIMCM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static long GAJKBLJGKIO;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long DKLNGGNCPKF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long HMICPFMECJH;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static long CMLJAMAGAOP;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static long LIHFBMJCHHF;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float JLNJNFHMFKI;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long BIFEHODOJKF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long PDAAOEPFLLL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool KEMLPCLPJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A33FC0", Offset = "0x6A325C0", VA = "0x186A33FC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A33DA0", Offset = "0x6A323A0", VA = "0x186A33DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static INLFLMAGBNI AJJFKNOHINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A32F10", Offset = "0x6A31510", VA = "0x186A32F10")]
		[CompilerGenerated]
		get
		{
			return default(INLFLMAGBNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A331F0", Offset = "0x6A317F0", VA = "0x186A331F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool KEECMCCLDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A33F70", Offset = "0x6A32570", VA = "0x186A33F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A32D90", Offset = "0x6A31390", VA = "0x186A32D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool CMLBNCBJKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A335E0", Offset = "0x6A31BE0", VA = "0x186A335E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A338C0", Offset = "0x6A31EC0", VA = "0x186A338C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static DNFMFKKKPAC KEMOLDEJJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A35CA0", Offset = "0x6A342A0", VA = "0x186A35CA0")]
		[CompilerGenerated]
		get
		{
			return default(DNFMFKKKPAC);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A35B80", Offset = "0x6A34180", VA = "0x186A35B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool KDKLLOEINJA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A35A70", Offset = "0x6A34070", VA = "0x186A35A70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6A32CE0", Offset = "0x6A312E0", VA = "0x186A32CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static KHLEPCALIHD OKDFANMGABD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6A35F30", Offset = "0x6A34530", VA = "0x186A35F30")]
		[CompilerGenerated]
		get
		{
			return default(KHLEPCALIHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6A33C90", Offset = "0x6A32290", VA = "0x186A33C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool EDELNOGCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A35E30", Offset = "0x6A34430", VA = "0x186A35E30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A35C40", Offset = "0x6A34240", VA = "0x186A35C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool NDOGMCAHLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A35DE0", Offset = "0x6A343E0", VA = "0x186A35DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6A33E60", Offset = "0x6A32460", VA = "0x186A33E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool MAKPJNEJFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6A32F60", Offset = "0x6A31560", VA = "0x186A32F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6A35510", Offset = "0x6A33B10", VA = "0x186A35510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static float ONMJHKDCLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6A339C0", Offset = "0x6A31FC0", VA = "0x186A339C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A33190", Offset = "0x6A31790", VA = "0x186A33190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int JLGOBBICLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6A32C90", Offset = "0x6A31290", VA = "0x186A32C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A35BE0", Offset = "0x6A341E0", VA = "0x186A35BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int KJAEELHMEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6A35D90", Offset = "0x6A34390", VA = "0x186A35D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A33010", Offset = "0x6A31610", VA = "0x186A33010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int HIJAEGHHCKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6A33920", Offset = "0x6A31F20", VA = "0x186A33920")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6A35680", Offset = "0x6A33C80", VA = "0x186A35680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int EIJGIECMKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6A33250", Offset = "0x6A31850", VA = "0x186A33250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6A33070", Offset = "0x6A31670", VA = "0x186A33070")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int MNHPIEKKJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6A32D40", Offset = "0x6A31340", VA = "0x186A32D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6A34110", Offset = "0x6A32710", VA = "0x186A34110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int ABFAOIGOELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A33D50", Offset = "0x6A32350", VA = "0x186A33D50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A35F80", Offset = "0x6A34580", VA = "0x186A35F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int ONBICKLNOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6A33970", Offset = "0x6A31F70", VA = "0x186A33970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6A358A0", Offset = "0x6A33EA0", VA = "0x186A358A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int AFNLNNHPEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A33EC0", Offset = "0x6A324C0", VA = "0x186A33EC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A33410", Offset = "0x6A31A10", VA = "0x186A33410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int JDNIPONBONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A34170", Offset = "0x6A32770", VA = "0x186A34170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A359C0", Offset = "0x6A33FC0", VA = "0x186A359C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int KEGJPMOFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A336F0", Offset = "0x6A31CF0", VA = "0x186A336F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A357E0", Offset = "0x6A33DE0", VA = "0x186A357E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static int JPDFPAFOLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A34010", Offset = "0x6A32610", VA = "0x186A34010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A32E50", Offset = "0x6A31450", VA = "0x186A32E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static int HJFNPKPDFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A35570", Offset = "0x6A33B70", VA = "0x186A35570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A33CF0", Offset = "0x6A322F0", VA = "0x186A33CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static int NCPJKNAGPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A35D40", Offset = "0x6A34340", VA = "0x186A35D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A33F10", Offset = "0x6A32510", VA = "0x186A33F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static int MCMKKFPBDIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A33350", Offset = "0x6A31950", VA = "0x186A33350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6A33530", Offset = "0x6A31B30", VA = "0x186A33530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static int MAHKBKPLCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6A332A0", Offset = "0x6A318A0", VA = "0x186A332A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A35620", Offset = "0x6A33C20", VA = "0x186A35620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool MADEPMGHCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6A35E80", Offset = "0x6A34480", VA = "0x186A35E80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6A35B20", Offset = "0x6A34120", VA = "0x186A35B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static bool HPJPMFBNNCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6A33B90", Offset = "0x6A32190", VA = "0x186A33B90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A334D0", Offset = "0x6A31AD0", VA = "0x186A334D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static BGHODPHMPEM GCHPLPALFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A35CF0", Offset = "0x6A342F0", VA = "0x186A35CF0")]
		[CompilerGenerated]
		get
		{
			return default(BGHODPHMPEM);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A33630", Offset = "0x6A31C30", VA = "0x186A33630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static PENODHNNLNO DLIIILMGOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A33810", Offset = "0x6A31E10", VA = "0x186A33810")]
		[CompilerGenerated]
		get
		{
			return default(PENODHNNLNO);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A332F0", Offset = "0x6A318F0", VA = "0x186A332F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static bool LCDLPELKJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6A341C0", Offset = "0x6A327C0", VA = "0x186A341C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6A32C30", Offset = "0x6A31230", VA = "0x186A32C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float NDKHGBGGNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A340C0", Offset = "0x6A326C0", VA = "0x186A340C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A32EB0", Offset = "0x6A314B0", VA = "0x186A32EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static float HLDAAFMMLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A33590", Offset = "0x6A31B90", VA = "0x186A33590")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6A33E00", Offset = "0x6A32400", VA = "0x186A33E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static float GPENMICGNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A35A20", Offset = "0x6A34020", VA = "0x186A35A20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A35960", Offset = "0x6A33F60", VA = "0x186A35960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static float ODEMJPEJIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A33C40", Offset = "0x6A32240", VA = "0x186A33C40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6A33860", Offset = "0x6A31E60", VA = "0x186A33860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float NIFNKDOIBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A348B0", Offset = "0x6A32EB0", VA = "0x186A348B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A33130", Offset = "0x6A31730", VA = "0x186A33130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float DKBAGNDEMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A330D0", Offset = "0x6A316D0", VA = "0x186A330D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A35840", Offset = "0x6A33E40", VA = "0x186A35840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static bool PJIHJGMHNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6A33B30", Offset = "0x6A32130", VA = "0x186A33B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6A33AD0", Offset = "0x6A320D0", VA = "0x186A33AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float LOAJPDBINBL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A33BE0", Offset = "0x6A321E0", VA = "0x186A33BE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6A355C0", Offset = "0x6A33BC0", VA = "0x186A355C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int AGPFLCNPKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A337B0", Offset = "0x6A31DB0", VA = "0x186A337B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A32FB0", Offset = "0x6A315B0", VA = "0x186A32FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int GDMAELOPOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A35900", Offset = "0x6A33F00", VA = "0x186A35900")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A33A10", Offset = "0x6A32010", VA = "0x186A33A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool GPBODBPCIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A35AC0", Offset = "0x6A340C0", VA = "0x186A35AC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static int AJCLPJCHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A354B0", Offset = "0x6A33AB0", VA = "0x186A354B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A32DF0", Offset = "0x6A313F0", VA = "0x186A32DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int MKDIIEMHECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6A33690", Offset = "0x6A31C90", VA = "0x186A33690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static float4x4 IPAIMINHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A35760", Offset = "0x6A33D60", VA = "0x186A35760")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A356E0", Offset = "0x6A33CE0", VA = "0x186A356E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static float3 AODLNFPGPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A33740", Offset = "0x6A31D40", VA = "0x186A33740")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A333A0", Offset = "0x6A319A0", VA = "0x186A333A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static bool GFKADGMNEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6A34060", Offset = "0x6A32660", VA = "0x186A34060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A35ED0", Offset = "0x6A344D0", VA = "0x186A35ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static MFCBPHLDCGF HLBKEMGJNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A33470", Offset = "0x6A31A70", VA = "0x186A33470")]
		[CompilerGenerated]
		get
		{
			return default(MFCBPHLDCGF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A33A70", Offset = "0x6A32070", VA = "0x186A33A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A34910", Offset = "0x6A32F10", VA = "0x186A34910")]
	public static void KIHGOGGAAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A34210", Offset = "0x6A32810", VA = "0x186A34210")]
	public static void KEGIMBCOMJB(INLFLMAGBNI HOOOBPMGGLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BNNPEELHDMG
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct OHMDKGGKBJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector3 KBHBDHIEKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Quaternion JAFLFHHIBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float BDPPGOAIGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public Quaternion NCKBPKKNKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float JGLDDFOHKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float EIHOOKBECGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float BNEACNMEFJB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static List<OHMDKGGKBJL> MHOJCEDEKOA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F4C0", Offset = "0x6A2DAC0", VA = "0x186A2F4C0")]
	public static NativeList<FEGDHMAPLDK> JBECMFAFFFL(CGOJHJCAILM DBJFNIAKFEB)
	{
		return default(NativeList<FEGDHMAPLDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E4E0", Offset = "0x6A2CAE0", VA = "0x186A2E4E0")]
	private static bool HMGAIPNHPMF(int JFDIHIMJIHB, NativeList<FEGDHMAPLDK> HJBJAPKPPFA, List<OHMDKGGKBJL> NEIPNMNDENL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FF70", Offset = "0x6A2E570", VA = "0x186A2FF70")]
	private static FEGDHMAPLDK MEICOEKHKNO(int JPMDPHGDIIG, List<OHMDKGGKBJL> NEIPNMNDENL)
	{
		return default(FEGDHMAPLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FA60", Offset = "0x6A2E060", VA = "0x186A2FA60")]
	private static FEGDHMAPLDK LHLHOMNOANH(int JPMDPHGDIIG, List<OHMDKGGKBJL> NEIPNMNDENL)
	{
		return default(FEGDHMAPLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E400", Offset = "0x6A2CA00", VA = "0x186A2E400")]
	private static FEGDHMAPLDK CPJEOLIPDCJ(Vector3 OGNOLJCMDMP, Quaternion NACDGIDELJO, float AMCMIGCLHDD)
	{
		return default(FEGDHMAPLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A30100", Offset = "0x6A2E700", VA = "0x186A30100")]
	public static NativeList<FEGDHMAPLDK> PBMPECONLNO(CGOJHJCAILM DBJFNIAKFEB, float EMCJJGCGPKB)
	{
		return default(NativeList<FEGDHMAPLDK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DEHOMMBCMEB
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static Vector3 FBFGFNCGCAF;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static Vector3 MKBENPCLKNA;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static readonly float CJAJJOENAEB;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A317A0", Offset = "0x6A2FDA0", VA = "0x186A317A0")]
	public static Vector3 EPBDKAKDPOH(Vector3 GEOMLNOEGMM, Quaternion NACDGIDELJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A31DA0", Offset = "0x6A303A0", VA = "0x186A31DA0")]
	public static Vector3 IHPPEHFMNBC(Quaternion ADNGPFKNGFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A31680", Offset = "0x6A2FC80", VA = "0x186A31680")]
	public static Vector3 BOOKJKMPKME(Quaternion ADNGPFKNGFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A31720", Offset = "0x6A2FD20", VA = "0x186A31720")]
	public static Quaternion DBHPPDNLNMD(Vector3 KDJEBHMIDDA, Vector3 FFJHDFACBIE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A326D0", Offset = "0x6A30CD0", VA = "0x186A326D0")]
	public static Vector3 PEHAAAFPMOB(Vector3 APEIEKILDBK, Vector3 BJCKBHBEAMI, Vector3 FFJHDFACBIE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A322A0", Offset = "0x6A308A0", VA = "0x186A322A0")]
	public static Vector3 PDDIGPFPCID(Vector3 GEOMLNOEGMM, Vector3 FFJHDFACBIE, Quaternion ADNGPFKNGFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A31A30", Offset = "0x6A30030", VA = "0x186A31A30")]
	public static Quaternion FDGAEJGJFHB(Quaternion NACDGIDELJO, Vector3 KDJEBHMIDDA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A31E40", Offset = "0x6A30440", VA = "0x186A31E40")]
	public static bool IMGEAHEKNAC(Vector3 JFEJMOLGCOH, Vector3 BEPFKNONOIF, [Out] Vector3 EKBJDPFKMAM, bool FNPANNCEKKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A31FB0", Offset = "0x6A305B0", VA = "0x186A31FB0")]
	public static Vector3 KCEIJAGDLFK(bool KAAMEGFFNCI, [Optional] Quaternion BEAPFEEHEOO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FEGDHMAPLDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public float3 KBHBDHIEKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public float3x3 JAFLFHHIBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public float BDPPGOAIGDB;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CGOJHJCAILM
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	int MCBCIGGGDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BDDBODCAECA(int JPMDPHGDIIG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion JDEKGBLGEJK(int JPMDPHGDIIG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float PIAEDBEPNDF(int JPMDPHGDIIG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EMAFIBLKHLE : EPPLDLAOJMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool JJBOIDMDDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool PAAGJLALDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	float FACHABILLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	int BONPIAHDGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool DHGPGIBEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int NHLIGPNMKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FEGDHMAPLDK> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AJNLFLEOCJI : EPPLDLAOJMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	AMMHJAALNKH NHNJLFEEHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool LJDODEJDKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float3 IJHEGCBLNID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface MKAOLEKNIFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	FOJCBDPOEBL ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	KGPJBFJONFL CPCIMOJMBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EPPLDLAOJMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool EPCDEEGGHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool GCGLGFENCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	FOJCBDPOEBL ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	UniformTRS MHMFOFKKGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float JGNKNIABCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Vector3 FPCJOADJMPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	MFEJNOLPLDN CGBIMEKNFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	BDKEFENGGMG AMOBMJDKFIP
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
public interface NJHBOPFIOFI
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int DNMOFDNMOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Transform KENEOLELAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool JLPKCDDKBMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NDBOEPEGOEB GetBone(int JPMDPHGDIIG);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int JPMDPHGDIIG);
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
