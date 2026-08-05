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
public enum HDJCFKFBNHA
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
public enum PDIICNIPGKM
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
public enum DEPAGOGAGPE
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
public enum PKFKFDHPGGD
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
public enum NHNCDPLDBOL
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
public enum ADLIHGEBFFL
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
public static class LJCIGDEGGKH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C79550", Offset = "0x7C78950", VA = "0x187C79550")]
	public static bool LIECHENFKBP(this ADLIHGEBFFL PALICIKBOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C79540", Offset = "0x7C78940", VA = "0x187C79540")]
	public static bool BDDHDLHDCBO(this ADLIHGEBFFL PALICIKBOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C79570", Offset = "0x7C78970", VA = "0x187C79570")]
	public static bool MNPIAKEKCCH(this ADLIHGEBFFL PALICIKBOFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MCPAODJHNLK
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
public struct POFBMACAHHC : KPKDAMONEJC, IEquatable<POFBMACAHHC>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int PINFDPDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x122C2A0", Offset = "0x122B6A0", VA = "0x18122C2A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int LGHILPCJELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AC0", Offset = "0x2D40EC0", VA = "0x182D41AC0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D25A80", Offset = "0x6D24E80", VA = "0x186D25A80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CMMDKLGDPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C7BB40", Offset = "0x7C7AF40", VA = "0x187C7BB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x18550E0", Offset = "0x18544E0", VA = "0x1818550E0", Slot = "8")]
	public bool Equals(POFBMACAHHC DMMBOHMLHLF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x38C4AF0", Offset = "0x38C3EF0", VA = "0x1838C4AF0")]
	public static bool HGJBAFCOLON(POFBMACAHHC EHIMHGHKFCP, POFBMACAHHC MDCPFJBHOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BAA0", Offset = "0x7C7AEA0", VA = "0x187C7BAA0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BB80", Offset = "0x7C7AF80", VA = "0x187C7BB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LAKJFHCHGBH : KPKDAMONEJC, IEquatable<LAKJFHCHGBH>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int PINFDPDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x122C2A0", Offset = "0x122B6A0", VA = "0x18122C2A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int LGHILPCJELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AC0", Offset = "0x2D40EC0", VA = "0x182D41AC0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D25A80", Offset = "0x6D24E80", VA = "0x186D25A80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CMMDKLGDPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C79470", Offset = "0x7C78870", VA = "0x187C79470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x18550E0", Offset = "0x18544E0", VA = "0x1818550E0", Slot = "8")]
	public bool Equals(LAKJFHCHGBH DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C793D0", Offset = "0x7C787D0", VA = "0x187C793D0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C794B0", Offset = "0x7C788B0", VA = "0x187C794B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HCOFDHBJAHK : KPKDAMONEJC, IEquatable<HCOFDHBJAHK>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PINFDPDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x122C2A0", Offset = "0x122B6A0", VA = "0x18122C2A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LGHILPCJELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2D41AC0", Offset = "0x2D40EC0", VA = "0x182D41AC0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D25A80", Offset = "0x6D24E80", VA = "0x186D25A80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CMMDKLGDPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C74F60", Offset = "0x7C74360", VA = "0x187C74F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x18550E0", Offset = "0x18544E0", VA = "0x1818550E0", Slot = "8")]
	public bool Equals(HCOFDHBJAHK DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C74EC0", Offset = "0x7C742C0", VA = "0x187C74EC0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GJBDMCKPJAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIFNBMMMHMM(POFBMACAHHC DGFFJNKGDJD, PDIICNIPGKM JPIKKNDHDGO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIFNBMMMHMM(LAKJFHCHGBH BLJJLAFHKPA, PDIICNIPGKM JPIKKNDHDGO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INMNMLBJOPG(LAKJFHCHGBH BLJJLAFHKPA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFEKFIHJHJM(LAKJFHCHGBH BLJJLAFHKPA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IEBLNADDLEP();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMBPOBGADKI(PDIICNIPGKM KHNCICOHHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KBGJOLNLFJH(POFBMACAHHC DGFFJNKGDJD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KBGJOLNLFJH(LAKJFHCHGBH BLJJLAFHKPA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HGLHMKLEJDL(LAKJFHCHGBH BLJJLAFHKPA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PNGJNHENPBB(LAKJFHCHGBH BLJJLAFHKPA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BLMDMJNELFP();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DDNMGHNPNKH();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AAIDBFIDPFD(POFBMACAHHC DGFFJNKGDJD, NHNCDPLDBOL KHNCICOHHHJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AGMFLPGAAKI(LAKJFHCHGBH BLJJLAFHKPA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OOENJILALEN(LAKJFHCHGBH BLJJLAFHKPA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CHPOHPIKEIF();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DMHMJAEDLPA(NHNCDPLDBOL KHNCICOHHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OKGGLNALBDN(POFBMACAHHC DGFFJNKGDJD, Vector3 BNKLIINIGDH, Vector3 DLKJOJJJOLL, Vector3 AGIAACILBAN, float HNACJMNBBOB, float CCPJBOOAHPF, IReadOnlyList<Camera> DLEMFNDACKP, HDJCFKFBNHA GFDPMGHKLOK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OKGGLNALBDN(HCOFDHBJAHK JDOFAAAEHLA, Vector3 BNKLIINIGDH, Vector3 DLKJOJJJOLL, Vector3 AGIAACILBAN, float HNACJMNBBOB, float CCPJBOOAHPF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CHLPKMIEKPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CNLCFHJDNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POFBMACAHHC EAKFEALHLCP(GEHONHPBHEG AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POFBMACAHHC EAKFEALHLCP(GEHONHPBHEG AOFGGGKINCN, bool BMJJMAHHPOI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKBAEDLOKPK(POFBMACAHHC DGFFJNKGDJD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOLLLILCFLG(POFBMACAHHC DGFFJNKGDJD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LAKJFHCHGBH ONLFBDAGEMP(POFBMACAHHC DGFFJNKGDJD, OEONGFIBELC AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LAKJFHCHGBH PHOMDLAPEGK(POFBMACAHHC DGFFJNKGDJD, GOBGNEEINFF AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CFOKCOHJIAE(LAKJFHCHGBH BLJJLAFHKPA);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EKNAPFFICDP(LAKJFHCHGBH BLJJLAFHKPA);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HCOFDHBJAHK OEHJCFNPKFP(DCDGHFNBEHP AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HANOEBNGBNE(HCOFDHBJAHK JDOFAAAEHLA);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MCJFIODJCLP(HCOFDHBJAHK JDOFAAAEHLA);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DAGPBEIAPAB();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task PPAODIIJFKP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FFJBMJMPEEI();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BJBNEGPGIPO();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> FHPCENCEKCE(POFBMACAHHC DGFFJNKGDJD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PHKAAPBHJFB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum IJAKHIANDGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum IEPNAAFKFHC
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum IEEALAGDIJN
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
	public enum PNPLNLNGJHO
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
	public enum HOMAOKLNEPE
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
	public enum KEBIFHJPOJP
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
	public enum ECIHGHIDGJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum LBNBDHKLEIP
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
	public static bool OPDFDIEALDD;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long MDJFLEOJIAL;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool OAPPNGOCFEP;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool CONOPEAJCFM;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool LKGKIGGBFAI;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float JAFNOBKHGLF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float NFFIGGKDBFF;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int ACCCKKFOHCO;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static KEBIFHJPOJP HKHGJJAFAOE;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long ODEGNIKOOFE;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float ADOJFAECOOO;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int JKAOHLDFKJH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int AJMGNFJHGGE;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int APOFGLLAHLC;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int CBLKDFPGGBA;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int JMMLMGJEHMB;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int NFPLEOMEFGN;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int OMPAPBCNMJI;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int KHDKKNJIICJ;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool FOPLIEIIEPP;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int PCPFENCGJGD;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int ADOOHLFKAOF;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int JJCADKCMJKE;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool GKOJGKOIMPF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float NFGJFINJEMM;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool OLHHDKJHLAP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float DEGDACOMMIL;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long EFIOCIGNHGC;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool HCNCDOHECCN;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long LBEJLNODCAM;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int AEGMMCCCEKH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool GNEIJCLOLBL;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static IJAKHIANDGM NPNHHCHOPMO;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool INLBDIJILNI;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool DDHLCEIHGAK;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int EIJGGMOPICD;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int EEMKJFGNCEI;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int DKDFDKBNMKI;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int NIJBKHOMNEJ;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int OFICBAOCIFA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int HKCHIPLJOFE;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int HKIGKOCINPF;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int OJOJAOFGELD;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float HHBHBMAFCPH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float HFPIPOBLONO;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float PFAKIEMNJOM;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float NNNPIKOIBNI;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int MEPGKNFALCP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int LFDLEELOBNN;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int GLHCCCEFKMN;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int DMNFJCIFNLH;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool CKPJNLMGJDM;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static IEEALAGDIJN ODNOLONCGOH;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static PNPLNLNGJHO KGMHIACFCAJ;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool JOHMAGJACNP;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static IEPNAAFKFHC GPJAMCKPPNC;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float GNNIDLDFMOL;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float PHJPJMDODLO;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float IMNJNJEBFNN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float PGHFCHPMFDF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float BKGFNPDMBIH;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float OCDECEAKJAB;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float FMDLDPOFFAM;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float EIJJHFKAPFA;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool INAKCAHEMCP;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static ECIHGHIDGJP EBABMJDABME;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool OMOFNGGHDCJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float OLEEMMGMMGN;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float AKEKAKFCCON;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float JLBMBJGGEGC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float OBLLNLPAKCO;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float IFLOAMCHLEI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool IOIJDOBKLAD;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long GJNLCMJJAEE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float AJLAMNIKDIB;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float IFAIDBICPKI;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float HHLICJPCFMN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int DMMBFMFJGLM;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float INJPFBDAIPG;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool AKAHJALKBAK;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long MJLLHCFLLIJ;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int ODGOCKPJGOO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int GJEBKHOHPAC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float AGELHDKLABH;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float KLAOPAKBIJG;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool NCIFBJKOAPG;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool IGDPNHJKCHL;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float MHIHOMEBLHJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long ADCIECJLBFP;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long ONHGEDGKKIO;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int FANPKDILLGP;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 OEPIGBBNLPM;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 AKJDNKPCHHK;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool ADLKJKHGMNK;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static HOMAOKLNEPE PJHMCBFGGFP;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long AEKBPHOELLL;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int JIEMMMPAIIN;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int DGMCMGDLILP;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int LMCKGLGAHPC;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int DOINEFDJGHH;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int LBCKAOJKPJG;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long POEDJMBHIDE;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int BANDGCPJMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int ANBKGIDHKJM;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int KPDODPCHALN;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long COBNCBPPJMP;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long OCCLLJFCBLE;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long KKIHDNMKCDN;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long GADKBCINHGA;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int AMAGKDHJAKI;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int EMEAOLGAFAC;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int JNLLEABGNEG;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int FFBCEFOAKCA;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] OIADBGJLMIC;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int NHLDNHMHCIB;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long JNPJIKJLHDH;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long BPKHFEAIBPA;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int CPKFPCLLIPL;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int EGLJKGLNONM;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long DDCCFLOFCMC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long EPDENJIJLCE;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long POENBBFBBGC;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long DHNIAODIPLN;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long PIIMLDLGBHB;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long MIGHJJJGJBM;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long DCKPAMOABCF;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long IBMCLMOFPIJ;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long EKBCHBCHALK;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float GHIDMLIMDBN;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float AANJFBDKKPC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long HFGNCILDCEK;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int FLCFJLBIKDN;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long NBECHMPAHDH;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long JLAMINHECKP;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float FALMOKECKDN;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long DONIAFGFALE;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long PGOPICPMEHB;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long LECKBMDNENC;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long COHBCJMNFAN;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long GFOKFGIELNP;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long KHIKMMDBLLJ;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long LPIILHELMOL;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long JFKCNPMIILJ;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long HAKMDILHKPO;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long ONJMIOOLNPA;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long IFOHFPNDMHO;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long NNJIBGOFLGP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static LBNBDHKLEIP DEMKIKMNIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C79C50", Offset = "0x7C79050", VA = "0x187C79C50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long MFENIMHNAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C7AE00", Offset = "0x7C7A200", VA = "0x187C7AE00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C795A0", Offset = "0x7C789A0", VA = "0x187C795A0")]
	public static void HIHOPJLGDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C79CB0", Offset = "0x7C790B0", VA = "0x187C79CB0")]
	public static void LJMPOCOHJGG(LBNBDHKLEIP BBCIILOJDKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HDNCHEMFEDF
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct PHEEFFFBCKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 KHAINEMBOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Quaternion CNCCLHDGKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public float HBPCAGLAIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Quaternion KNCCHCPNNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float HEKPHLLHALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float BJFBCGCJOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public float OIKCNHGNDNE;
	}

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static List<PHEEFFFBCKI> KJNPMMGAJGM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C764C0", Offset = "0x7C758C0", VA = "0x187C764C0")]
	public static NativeList<KOLCMGJNCCI> LCKKPBIKBGE(OMOHOGJENME LANCKGLJCDD)
	{
		return default(NativeList<KOLCMGJNCCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C75610", Offset = "0x7C74A10", VA = "0x187C75610")]
	private static bool KHBOAEAMJJH(int DPBBAIABGAH, NativeList<KOLCMGJNCCI> APLCGCDLEGH, List<PHEEFFFBCKI> FELGEJPEPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C74FA0", Offset = "0x7C743A0", VA = "0x187C74FA0")]
	private static KOLCMGJNCCI DFPCKAOKKLD(int MLHFFBNEEHM, List<PHEEFFFBCKI> FELGEJPEPGN)
	{
		return default(KOLCMGJNCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C75120", Offset = "0x7C74520", VA = "0x187C75120")]
	private static KOLCMGJNCCI IPBIANDILGP(int MLHFFBNEEHM, List<PHEEFFFBCKI> FELGEJPEPGN)
	{
		return default(KOLCMGJNCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C76A70", Offset = "0x7C75E70", VA = "0x187C76A70")]
	private static KOLCMGJNCCI LNMGELNKEPP(Vector3 EIODCDKJBOE, Quaternion PNMIEECLPJC, float PPFBOIIFNHM)
	{
		return default(KOLCMGJNCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C76B50", Offset = "0x7C75F50", VA = "0x187C76B50")]
	public static NativeList<KOLCMGJNCCI> PMGJPKOHAMG(OMOHOGJENME LANCKGLJCDD, float ADHEJCBIEEA)
	{
		return default(NativeList<KOLCMGJNCCI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JLJKGNELJAN
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 IFHKCFLAFDE;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static Vector3 HKLDLCHKPPO;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly float MNPNICCBIMD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C79060", Offset = "0x7C78460", VA = "0x187C79060")]
	public static Vector3 OKEFKKOOAAL(Vector3 MNHJFLLNPJA, Quaternion PNMIEECLPJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C78C30", Offset = "0x7C78030", VA = "0x187C78C30")]
	public static Vector3 JIPNFGLOFAM(Quaternion PNEDBEMJDJJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C78FC0", Offset = "0x7C783C0", VA = "0x187C78FC0")]
	public static Vector3 LFEBIAEFJCF(Quaternion PNEDBEMJDJJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C78780", Offset = "0x7C77B80", VA = "0x187C78780")]
	public static Quaternion GLCFGDDICBL(Vector3 DJMLEJBBDGG, Vector3 KBGACFDBMJG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C78410", Offset = "0x7C77810", VA = "0x187C78410")]
	public static Vector3 GFIILBGPJNN(Vector3 GLPCGEHJBOE, Vector3 DHJBIBCNGON, Vector3 KBGACFDBMJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C78800", Offset = "0x7C77C00", VA = "0x187C78800")]
	public static Vector3 HOJOCEGJLFI(Vector3 MNHJFLLNPJA, Vector3 KBGACFDBMJG, Quaternion PNEDBEMJDJJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C780B0", Offset = "0x7C774B0", VA = "0x187C780B0")]
	public static Quaternion EEGOKFNFIOE(Quaternion PNMIEECLPJC, Vector3 DJMLEJBBDGG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C78600", Offset = "0x7C77A00", VA = "0x187C78600")]
	public static bool GJGPCPKIKGI(Vector3 PHDIDEIKFHK, Vector3 MPBMLCABGDC, [Out] Vector3 KIEOKDMFIGP, bool HALJDEKGHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C78CD0", Offset = "0x7C780D0", VA = "0x187C78CD0")]
	public static Vector3 LBMAJIDMLNJ(bool JFGPCMMNFGE, [Optional] Quaternion IALDDNCFLNO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KOLCMGJNCCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3 KHAINEMBOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float3x3 CNCCLHDGKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float HBPCAGLAIKJ;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface OMOHOGJENME
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int NDCFNEPGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 GMBOEEKPKGA(int MLHFFBNEEHM);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion AMOPPDJKJDE(int MLHFFBNEEHM);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float PMCDBJDBBKL(int MLHFFBNEEHM);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GOBGNEEINFF : HKIAOKEMAMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GDAAMBEPHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KHDNGDAAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float IDLDMKGGKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int BHOGBPPACME
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool HJHODHKAPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int CEICEBMGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<KOLCMGJNCCI> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OEONGFIBELC : HKIAOKEMAMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DEPAGOGAGPE CIBMKDGKGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FGKIPPAJDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 OCNIPBHKPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GEHONHPBHEG
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	PLBPIALOLIB ACIFLJLGGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	PKFKFDHPGGD DNLDOFIGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HKIAOKEMAMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NEAIJDEAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PGOJHILPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PLBPIALOLIB ACIFLJLGGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS GFEDOCNLPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float KPHDBNLAJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 KMCBJFDCGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	ADLIHGEBFFL FGKOKJLHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	MCPAODJHNLK MKJGDIINOFA
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
public interface DCDGHFNBEHP
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int AMKFENNOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform CFBMBIPMBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool ILENNPDPHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	POFBMACAHHC GetBone(int MLHFFBNEEHM);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MLHFFBNEEHM);
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
