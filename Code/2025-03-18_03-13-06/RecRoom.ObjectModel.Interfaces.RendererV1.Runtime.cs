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
public enum FCKLGKBKHEJ
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
public enum GIHAKHDNNJF
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
public enum PGANNLEBPBC
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
public enum COMIHINGFAG
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
public enum MPMHJLBLEOI
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
public enum EOGPNGFBHLD
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
public static class NBMPLKCEHEF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x776DAC0", Offset = "0x776CCC0", VA = "0x18776DAC0")]
	public static bool LENOKAFKLKH(this EOGPNGFBHLD MGCBFMBNMKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x776DA80", Offset = "0x776CC80", VA = "0x18776DA80")]
	public static bool JDPLFJIBACD(this EOGPNGFBHLD MGCBFMBNMKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x776DA90", Offset = "0x776CC90", VA = "0x18776DA90")]
	public static bool KAAHBPBJINO(this EOGPNGFBHLD MGCBFMBNMKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FAKFOCBMCDN
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
public struct OMLFPKHBOMD : FGEPICOCPFA, IEquatable<OMLFPKHBOMD>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int PGEMEJBADFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int DAIODIGKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BF46E0", Offset = "0x2BF38E0", VA = "0x182BF46E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68B29B0", Offset = "0x68B1BB0", VA = "0x1868B29B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IEIFJCLJNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x776DCF0", Offset = "0x776CEF0", VA = "0x18776DCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x16EEFA0", Offset = "0x16EE1A0", VA = "0x1816EEFA0", Slot = "8")]
	public bool Equals(OMLFPKHBOMD LDKNLBHIGFL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8070", Offset = "0x3BD7270", VA = "0x183BD8070")]
	public static bool GJNOMHNHJKL(OMLFPKHBOMD IHGFIECIOLJ, OMLFPKHBOMD FHOBAJOBBGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x776DC50", Offset = "0x776CE50", VA = "0x18776DC50", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x776DD30", Offset = "0x776CF30", VA = "0x18776DD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OKPBHDAFLPP : FGEPICOCPFA, IEquatable<OKPBHDAFLPP>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int PGEMEJBADFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int DAIODIGKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BF46E0", Offset = "0x2BF38E0", VA = "0x182BF46E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68B29B0", Offset = "0x68B1BB0", VA = "0x1868B29B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IEIFJCLJNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x776DB80", Offset = "0x776CD80", VA = "0x18776DB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x16EEFA0", Offset = "0x16EE1A0", VA = "0x1816EEFA0", Slot = "8")]
	public bool Equals(OKPBHDAFLPP LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x776DAE0", Offset = "0x776CCE0", VA = "0x18776DAE0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x776DBC0", Offset = "0x776CDC0", VA = "0x18776DBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HGPFMFLDJEH : FGEPICOCPFA, IEquatable<HGPFMFLDJEH>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PGEMEJBADFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DAIODIGKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BF46E0", Offset = "0x2BF38E0", VA = "0x182BF46E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68B29B0", Offset = "0x68B1BB0", VA = "0x1868B29B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IEIFJCLJNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x776DA40", Offset = "0x776CC40", VA = "0x18776DA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x16EEFA0", Offset = "0x16EE1A0", VA = "0x1816EEFA0", Slot = "8")]
	public bool Equals(HGPFMFLDJEH LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x776D9A0", Offset = "0x776CBA0", VA = "0x18776D9A0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FDBJDLMKNEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHFANENDHEH(OMLFPKHBOMD BFPPPKIAFBG, GIHAKHDNNJF JPGPAIHLKCE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHFANENDHEH(OKPBHDAFLPP ADJAHFEDDPI, GIHAKHDNNJF JPGPAIHLKCE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLBJNEJEHMA(OKPBHDAFLPP ADJAHFEDDPI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDKLAGKLDHJ(OKPBHDAFLPP ADJAHFEDDPI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KPJKJIBPIMF();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNAJOEJMNHL(GIHAKHDNNJF NNILCBOLNDI);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AJDMHKAAIBJ(OMLFPKHBOMD BFPPPKIAFBG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AJDMHKAAIBJ(OKPBHDAFLPP ADJAHFEDDPI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMHHABOJOHH(OKPBHDAFLPP ADJAHFEDDPI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MFGEDGNIONC(OKPBHDAFLPP ADJAHFEDDPI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GKCCLGPGLKI();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OJLGJONMPED();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EHJANGAOIGE(OMLFPKHBOMD BFPPPKIAFBG, MPMHJLBLEOI NNILCBOLNDI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DOLIKBLJMJN(OKPBHDAFLPP ADJAHFEDDPI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NAKKFLLHCAC(OKPBHDAFLPP ADJAHFEDDPI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FHCIODANJHL();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BPLNBPBDMAK(MPMHJLBLEOI NNILCBOLNDI);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IIFFDPEPJHI(OMLFPKHBOMD BFPPPKIAFBG, Vector3 LADLHKPOKJJ, Vector3 ADIHKOHOOAG, Vector3 IHPACCCNOBB, float ACGFEFKGPLC, float FEPPBOCNOBP, IReadOnlyList<Camera> IMBNIDJELNM, FCKLGKBKHEJ JNIGJFGCALI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IIFFDPEPJHI(HGPFMFLDJEH CBNFLPCLLMK, Vector3 LADLHKPOKJJ, Vector3 ADIHKOHOOAG, Vector3 IHPACCCNOBB, float ACGFEFKGPLC, float FEPPBOCNOBP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IGEBAHMFCMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JKLDHBHJCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMLFPKHBOMD ABBCFMKPBKO(OCMFLIKNIPB LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMLFPKHBOMD ABBCFMKPBKO(OCMFLIKNIPB LJELDKAOCJM, bool KFICEOMAOFP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBLAEKMLOEE(OMLFPKHBOMD BFPPPKIAFBG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJCJNEOEFMF(OMLFPKHBOMD BFPPPKIAFBG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OKPBHDAFLPP JDCNKDOGFOH(OMLFPKHBOMD BFPPPKIAFBG, GFCAFNBKIEB LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OKPBHDAFLPP EIJIOAPGKPK(OMLFPKHBOMD BFPPPKIAFBG, FLIGGIIDKOK LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBEHDJLLJEC(OKPBHDAFLPP ADJAHFEDDPI);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CJNJNOKHKHF(OKPBHDAFLPP ADJAHFEDDPI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HGPFMFLDJEH HINNLDNELEH(GJMABJMFAAN LJELDKAOCJM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NBMHBACALHN(HGPFMFLDJEH CBNFLPCLLMK);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FJNCIFNBJGG(HGPFMFLDJEH CBNFLPCLLMK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task LHPHDJJAMEN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LAALFNOGJED();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task BMPNONCIEPP();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GEIIKOIIOIE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> FKFFBGEDOFF(OMLFPKHBOMD BFPPPKIAFBG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GJMOKEJPCDB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum DLLKHHMJLNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum MJEDIONLHCO
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum IDDACECFBMD
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		RefreshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum LLIFDILLABD
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum ICBLFAACIMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum MENPCMDLKLH
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum GJBDOICJIOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum NMMEFOCDADM
	{
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		JustAvatarMeshLod = 101
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool MFAFKINDHFG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long AIHGMCIBBID;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool ADGOCJONIKL;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool DLPACFPJIAK;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool CEFLGMLPAKI;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float DPIOJEPOOOH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float HNMDGCDIDMF;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int DILCDCPCKHG;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static MENPCMDLKLH BJDFMLEIANF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long HFHDJMHCCCF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float FOGOGHGDDNL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int HOPIIEFCDOB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int LNKECPOBCGG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int FMIKHJHOBJN;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int BECAMCPPOKC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int JFECJAANCME;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int EHKHDEBFKFE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int OFEEMMODDIJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int CDCEFIKCCOC;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool MCGMOGJGLHF;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int EPDIJEDGHOA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int GDFJBOMFPMJ;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int JCPGIGJFJGD;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool LMENGABIALJ;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float DMDIHLMJJJI;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool JDJAKOJPIJB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float CDDGOHHJFCM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static float FPCJFJILLGE;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool LGDGNCOCNAG;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long JPNMFEAFBOI;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int EHMKBJLAGDN;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool ONNKADDIEGC;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static DLLKHHMJLNI JFMEIBOOBHN;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool PJNEIBFEIPI;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool AICJIAFGPLC;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int HJNEFDLNGNK;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int GCHJGLEHMOC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int CCLDGDAEBAK;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int OMMCIALDCNN;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int EOAIMOCDEKL;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int MJLPKEMOGOA;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int NIJLJHKBNBC;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int POCGOELOLOA;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float ADIEFBCLDKA;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float BABKELLIDIL;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float BDHFHEMACCD;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static int ONNLONCKLKA;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int AKPOAMCNDFP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int GHMHBFDOILN;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int KKIGLHJIKOB;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static bool DOOIOJLCKJA;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static IDDACECFBMD LNJKNKKBHKC;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static LLIFDILLABD LEBDKMGPJFM;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static bool ECBLIMKBMNF;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static MJEDIONLHCO GEAEADCGMHB;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static float PKMFMNKDAIJ;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float NOHDOMELHMF;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float GGKIABFGCJM;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float MKHKPKMIDOM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float KHOHMHKPHGJ;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float NJIFPOMJOEN;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float JKHHJJLBEKP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float NOKKBCJOKMO;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static bool COCLGNCKBKM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static GJBDOICJIOA NBLFPAIJOED;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static bool JMANNGJLMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static float AHPDOJIHHNM;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float ICCAPGKKLHC;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float EEAGIAMNJBM;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float PAHLFAAINJP;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float IMPOGCONEBI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static bool MOFNKCEDGLP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static long FLIKNKJFIGK;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static float HLOIKNLEBGF;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float HBPEDJPDCMF;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float LMBPMEBOOOF;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static int MDGFEFGPICP;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static float AIONEMKNIEL;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static bool MJBGCJMKLEJ;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static long MNDCPJLFPNA;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static int JMLOECKLHLB;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int LNMBEGGKECF;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static float FAEJJFGPBEC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float NPGAILGHGJK;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static bool AJPMGEPAAML;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool CPKCPMOAPLA;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static float JCKBLJHEGGI;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long PILIIAFDLGB;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long JHJOHNHLGKC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static int CIINAHJDGHD;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static float4x4 MCHLPKGMBHH;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float3 KALHFGKHMGE;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static bool OFFMNIGHJDM;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static ICBLFAACIMA FHPOJCKBDGP;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static long GLKCKNHCANO;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static int FHNEFLNAJLB;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int MJFMJLPOLNK;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int LNNADMNNHLL;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int LMAHOLMOBPA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static long LBJHKNPBAJF;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static long GNLOBMONHOD;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int BJBANDGCEOJ;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int NFLPLJFEBLC;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int PAIJMLBABCE;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static long MIFAAODDHBI;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long FOOOHAGPDKC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long IBBGKKFMIFL;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long FAMKGEBFLHO;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int MOLEJFBKCFI;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int CPCAOEJKNJK;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int PAJMIOIMGAH;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int AIDLCHEOIHH;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int[] DEHKIJCIKDG;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int AKHDJKKMDDO;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long AGEDJICIFAF;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long HJKCIFMGOMD;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static int GKFEJDHFFKA;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static long ABLAAFELGPL;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static long DCNJKOLLFIG;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long FCBJMFCIOLE;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long HOFHHONDNOJ;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long NJOIEHPPKPH;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long KNMHKJBMNOF;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long EEOIONDIMDA;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long NDCOIJKGIDK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long PGHMNMDDDKI;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static float IBKKJCLFEOO;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long MIJKIBGNHNJ;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static int DHDPMDFCDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long BPBIDLOENEF;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long JGKKJCBJNNC;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static float PEBBIABKOOI;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long BNJEENPJNGJ;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long JCDAAACDAEP;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long NHJANNFCHIF;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long JCECODDNHED;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long FLLANFLDJJM;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long BNOKPDGKBCD;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long GOJIGJIGIJN;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long PCEFIAEAICI;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long IJOMJPDEGDA;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long IBFHFMEMKEP;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long FFMJCHCMAIM;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long GIMNEJIJOPC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static NMMEFOCDADM JKMKLNDOBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7768990", Offset = "0x7767B90", VA = "0x187768990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long PHHOCHLFDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7768930", Offset = "0x7767B30", VA = "0x187768930")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x77698E0", Offset = "0x7768AE0", VA = "0x1877698E0")]
	public static void PPCFKPKIEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77689E0", Offset = "0x7767BE0", VA = "0x1877689E0")]
	public static void DJNBFBBKAIC(NMMEFOCDADM AAENJKJBPND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GKPJJMGMKPK
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct FIINDLPNPPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Vector3 LAHGFMKGHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Quaternion NEDOKMKIJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public float MOHEKKJJHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Quaternion FAOHJEGBMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public float NLPNPEKILCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public float NNDDHALPBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float DFFDBFEOONK;
	}

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static List<FIINDLPNPPK> JEMOENKNLOL;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x776BC70", Offset = "0x776AE70", VA = "0x18776BC70")]
	public static NativeList<FACMCBMMKCI> JGBHHOHDDOK(PMNGINNALJG LEOELMHJFEE)
	{
		return default(NativeList<FACMCBMMKCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x776A8F0", Offset = "0x7769AF0", VA = "0x18776A8F0")]
	private static bool CGCMBGNBLNK(int JMNJKPGAJIF, NativeList<FACMCBMMKCI> CMLOHOMLNDL, List<FIINDLPNPPK> MFDBHAMLAOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x776C210", Offset = "0x776B410", VA = "0x18776C210")]
	private static FACMCBMMKCI JIIOBIIIFLJ(int EFNCIOCDOKE, List<FIINDLPNPPK> MFDBHAMLAOJ)
	{
		return default(FACMCBMMKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x776B780", Offset = "0x776A980", VA = "0x18776B780")]
	private static FACMCBMMKCI IMAFCDOPCKK(int EFNCIOCDOKE, List<FIINDLPNPPK> MFDBHAMLAOJ)
	{
		return default(FACMCBMMKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x776C390", Offset = "0x776B590", VA = "0x18776C390")]
	private static FACMCBMMKCI OAPIIJPMHPF(Vector3 GENKBFNNJCB, Quaternion PKJLMNOFIIE, float LDCGEIMNGOD)
	{
		return default(FACMCBMMKCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x776C470", Offset = "0x776B670", VA = "0x18776C470")]
	public static NativeList<FACMCBMMKCI> OJGNCBOLMKG(PMNGINNALJG LEOELMHJFEE, float EEHHNFJIKFP)
	{
		return default(NativeList<FACMCBMMKCI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CCJCFDFJJMK
{
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public static Vector3 OODNEPGOLFN;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public static Vector3 MEBGIGLOFKN;

	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public static readonly float OOPECGIAEOA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7767630", Offset = "0x7766830", VA = "0x187767630")]
	public static Vector3 ALBIDANMCDE(Vector3 JGKCLOIEOBC, Quaternion PKJLMNOFIIE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7768230", Offset = "0x7767430", VA = "0x187768230")]
	public static Vector3 FGFGPCCDJIP(Quaternion GLMEOLPKLCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7768740", Offset = "0x7767940", VA = "0x187768740")]
	public static Vector3 IOHDBKEKHJK(Quaternion GLMEOLPKLCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x77687E0", Offset = "0x77679E0", VA = "0x1877687E0")]
	public static Quaternion PLELEFGBAJH(Vector3 FOKNLDGGKBN, Vector3 HFFGEMAKAAC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x77678B0", Offset = "0x7766AB0", VA = "0x1877678B0")]
	public static Vector3 DEHKJHLJDKJ(Vector3 DHGIIEHFONM, Vector3 LNIEKDIBNIB, Vector3 HFFGEMAKAAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7767AA0", Offset = "0x7766CA0", VA = "0x187767AA0")]
	public static Vector3 DPCKOAENPPJ(Vector3 JGKCLOIEOBC, Vector3 HFFGEMAKAAC, Quaternion GLMEOLPKLCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7767ED0", Offset = "0x77670D0", VA = "0x187767ED0")]
	public static Quaternion ENDDMBGIFPP(Quaternion PKJLMNOFIIE, Vector3 FOKNLDGGKBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x77685C0", Offset = "0x77677C0", VA = "0x1877685C0")]
	public static bool GPCJPLHNAHL(Vector3 MJCFKGHBNNE, Vector3 ECLMHCBEFPJ, [Out] Vector3 ACHJDMDOAAN, bool EJFFPNBFPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x77682D0", Offset = "0x77674D0", VA = "0x1877682D0")]
	public static Vector3 GBCIBECDAJE(bool KLLBJIHMIGF, [Optional] Quaternion BNBBGOEKOLF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FACMCBMMKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public float3 LAHGFMKGHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public float3x3 NEDOKMKIJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public float MOHEKKJJHAP;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PMNGINNALJG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int AADAGMNJPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JPFOIKEEDAG(int EFNCIOCDOKE);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion EDKPBINGINI(int EFNCIOCDOKE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float AEJLLIICEMI(int EFNCIOCDOKE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FLIGGIIDKOK : LKGDJKBNHHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool AKKMIIIBPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool DCPGKGOMFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float MBEBBDGPLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int CJIGAEKJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool FMFLNPBMGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int AEPHLELMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FACMCBMMKCI> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GFCAFNBKIEB : LKGDJKBNHHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PGANNLEBPBC NPPOAAKEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FLAPDCADLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 FLCOCAKBKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OCMFLIKNIPB
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MOCOMOJHGBP FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	COMIHINGFAG IMKDJLCDLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LKGDJKBNHHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PEIMBAMBPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GLJBJMFGDIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MOCOMOJHGBP FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS IMMGEELMMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float NCAEMGGGKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 CDPBEFKEJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	EOGPNGFBHLD IIJCJMOEPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FAKFOCBMCDN AHBFAACOAIM
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
public interface GJMABJMFAAN
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int AHHEBIIIJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform ANPMDLNOCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HHDIANHAMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMLFPKHBOMD GetBone(int EFNCIOCDOKE);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EFNCIOCDOKE);
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
