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
public enum IAEGPOMMOKC
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
public enum MPMOFPPLHCF
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
public enum BPEIFANGIJA
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
public enum NIIEHKEHOHC
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
public enum LCGNEMGJNFI
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
public enum ADADNEEPCEF
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
public static class POBDNMHCIPF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A858F0", Offset = "0x7A842F0", VA = "0x187A858F0")]
	public static bool DEBFGFCHDBA(this ADADNEEPCEF DCLAICIICJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7A85940", Offset = "0x7A84340", VA = "0x187A85940")]
	public static bool OLPOLDLDEIF(this ADADNEEPCEF DCLAICIICJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7A85910", Offset = "0x7A84310", VA = "0x187A85910")]
	public static bool EBMOBNBIHHE(this ADADNEEPCEF DCLAICIICJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KJDEIJDKCCB
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
public struct JBGLFFCNIBO : KPKOEBEHBFB, IEquatable<JBGLFFCNIBO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int FDJPACNIFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC650", Offset = "0x2CDB050", VA = "0x182CDC650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C4D0", Offset = "0x6B6AED0", VA = "0x186B6C4D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BFBBKCKIDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7A82580", Offset = "0x7A80F80", VA = "0x187A82580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x17C7BC0", Offset = "0x17C65C0", VA = "0x1817C7BC0", Slot = "8")]
	public bool Equals(JBGLFFCNIBO OLKLGHOAKNE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x371CE80", Offset = "0x371B880", VA = "0x18371CE80")]
	public static bool HFGMMLFJJJB(JBGLFFCNIBO KEEADJCBJCP, JBGLFFCNIBO LKKBJAKGIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A825C0", Offset = "0x7A80FC0", VA = "0x187A825C0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7A82650", Offset = "0x7A81050", VA = "0x187A82650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LIINPMBBOMO : KPKOEBEHBFB, IEquatable<LIINPMBBOMO>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int FDJPACNIFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC650", Offset = "0x2CDB050", VA = "0x182CDC650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C4D0", Offset = "0x6B6AED0", VA = "0x186B6C4D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BFBBKCKIDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A826E0", Offset = "0x7A810E0", VA = "0x187A826E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x17C7BC0", Offset = "0x17C65C0", VA = "0x1817C7BC0", Slot = "8")]
	public bool Equals(LIINPMBBOMO OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A82720", Offset = "0x7A81120", VA = "0x187A82720", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A827B0", Offset = "0x7A811B0", VA = "0x187A827B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EEOAKPIHAKE : KPKOEBEHBFB, IEquatable<EEOAKPIHAKE>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FDJPACNIFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC650", Offset = "0x2CDB050", VA = "0x182CDC650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C4D0", Offset = "0x6B6AED0", VA = "0x186B6C4D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BFBBKCKIDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7A824B0", Offset = "0x7A80EB0", VA = "0x187A824B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x17C7BC0", Offset = "0x17C65C0", VA = "0x1817C7BC0", Slot = "8")]
	public bool Equals(EEOAKPIHAKE OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A824F0", Offset = "0x7A80EF0", VA = "0x187A824F0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HBJPHKMFDDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKJIGIDGDCL(JBGLFFCNIBO MHHKOMDGDID, MPMOFPPLHCF FGIHDPOHIFO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKJIGIDGDCL(LIINPMBBOMO GMLPEGDALHF, MPMOFPPLHCF FGIHDPOHIFO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGMPBMEMCOB(LIINPMBBOMO GMLPEGDALHF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMNHANOIDFN(LIINPMBBOMO GMLPEGDALHF);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MEJBHHDOFAA();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMCIJBBOOKO(MPMOFPPLHCF OHCGINPDMEI);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KBADHJNEAKP(JBGLFFCNIBO MHHKOMDGDID);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KBADHJNEAKP(LIINPMBBOMO GMLPEGDALHF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LMLMOIALAIG(LIINPMBBOMO GMLPEGDALHF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JHPEILPFKMM(LIINPMBBOMO GMLPEGDALHF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BKHFIDHIFPE();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JEIODOKKFDO();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KPHOEBHJOPD(JBGLFFCNIBO MHHKOMDGDID, LCGNEMGJNFI OHCGINPDMEI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CPGNMGALCGD(LIINPMBBOMO GMLPEGDALHF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PBCJBLEEBJB(LIINPMBBOMO GMLPEGDALHF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HKPEBJKCLLK();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JELPAJDKIAL(LCGNEMGJNFI OHCGINPDMEI);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BGKEMAEGHOH(JBGLFFCNIBO MHHKOMDGDID, Vector3 ABFAPGIDLBA, Vector3 GPFFOPCNLDB, Vector3 PFFAGBPBCDM, float LCJCFGNBNHB, float CIBCDKJPIEF, IReadOnlyList<Camera> PDLOMEFOCDM, IAEGPOMMOKC GBNJCPHDBMP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BGKEMAEGHOH(EEOAKPIHAKE KFPDJNOIECE, Vector3 ABFAPGIDLBA, Vector3 GPFFOPCNLDB, Vector3 PFFAGBPBCDM, float LCJCFGNBNHB, float CIBCDKJPIEF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AMDEOGDAEEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BPLPCAPNGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JBGLFFCNIBO JACMAAFFMME(CMKEMJONGPA DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBGLFFCNIBO JACMAAFFMME(CMKEMJONGPA DFPGGEDGGGN, bool JLJHGKMJDEP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KOIOGDKMADA(JBGLFFCNIBO MHHKOMDGDID);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNMKMCANBKC(JBGLFFCNIBO MHHKOMDGDID);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LIINPMBBOMO NDBLDGLEHAH(JBGLFFCNIBO MHHKOMDGDID, HFEEEJKKJME DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LIINPMBBOMO KOLNIOBFCAB(JBGLFFCNIBO MHHKOMDGDID, KOBGOEHEJAM DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFGFFCPNBOM(LIINPMBBOMO GMLPEGDALHF);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ELAMMLBBDKO(LIINPMBBOMO GMLPEGDALHF);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EEOAKPIHAKE ACJOPGMPCNO(IEKLAJFHIFL DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NMDBCKLMHCF(EEOAKPIHAKE KFPDJNOIECE);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNHPBAOADFO(EEOAKPIHAKE KFPDJNOIECE);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task OIJHANHOGPN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DMDIGDMJNNL();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task KALKJBEFJHN();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AFGIFECOPKE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> KKEBEDOFEPP(JBGLFFCNIBO MHHKOMDGDID);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BJGJLLMOJBK
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum EIFCJHMGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum AEJOCODJCPP
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum GPDGPKFDMNP
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
	public enum MOHEFJOBKMP
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
	public enum CGDNDAKFJMF
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
	public enum LGFKEOIDADG
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
	public enum OFJJNLALPNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum KOJANJNGMAO
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
		JustAvatarMeshLod = 101
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool KAHDNLOBIFB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long DOAJLEBICPB;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool AEMODAIPHOK;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool BNDJFALCBNG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool GPFEBOMGNLN;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float FNFFDEAAAFC;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float CFHJIJKOFIN;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int BIIKNOOGHEO;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static LGFKEOIDADG AFDONCFFCCB;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long PKMGBLCOHCH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float ABOJLOGEDCC;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int MBLEILAABHI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int BMJECLBLHGN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int HPOCODFGPJO;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int IIHDAAIGHKC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int NEBPACGOCGG;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int FPNAADMNPFM;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int HBHMOFLJFDD;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int LIGDLIDBJJC;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool MLHLNFCGOAJ;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int CLKECHMEGJC;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int KIDFCDPAMKI;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int EDMCHACALLM;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool DLGHPOJIHHB;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float EGDIHGNPAAI;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool GFIFPBIGCEJ;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float JDOGFAALFAE;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long GHKLJNOHNKP;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool IGKBBKNMEEG;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long GBGNPPDAPIK;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int HKAEDOLHDCB;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool MCFEADMPIMF;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static EIFCJHMGCIN CBDMCLBEOKM;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool PJPIEFDCMCI;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool APLINNECLPI;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int OCGPAOCAOMH;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int CKKCOMPFEJK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int AMIKFFKLINJ;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int NIKHKKHCGGI;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int FCKENGBFCNJ;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int CBHEIBKGFHA;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int GIDGBCNFHDJ;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int EGIKAJAFLLJ;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float MFEIJNEBCDI;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float INODNCPBBLE;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float MEGFMPNNDMI;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float PGPJHMMECPM;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int NPCJFOMCKFL;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int GEJFLLHHKLO;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int GLBAIPOMPPN;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int EJGOBHKGPLM;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool NLDEKGOOAHB;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static GPDGPKFDMNP KFCIDFHBMHI;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static MOHEFJOBKMP HILKGNEJMCN;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool MLBMNFENIJG;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static AEJOCODJCPP HJECMFMOODN;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float OIDFLAFHCML;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float LDJBGPPELCE;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float EIOIBHGJEKP;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float BDMNDIPDIPF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float HACJDFBCDPH;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float OLBDCKKEKGH;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float LKOCAMMNJGM;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float CMHHKGNNGFM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool CLLLCJCAHIF;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static OFJJNLALPNP HMJALHBMIHH;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool KHOKFLHIHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float FMPEIAPCOJC;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float IAENIMLDMCC;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float NACMPNCGMKK;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float CJDMPJKFDBJ;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float FEPMCJFCOGF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool PFNIIOEEHCH;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long KGHIGGKOFCC;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float IDLAHLAPKHJ;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float KIIGGHICGFN;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float HHBLLKMJBOE;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int DHKHKFBOMME;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float KGIHHOANGMA;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool LMCLFIMMKLC;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long DJCFCDJMNOO;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int FANACGAABMH;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int LKKOPHMPMEF;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float ANNICJBDBHE;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float HHKLJOHPPPK;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool PHLNKFGAKKK;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool FPKJABANFPP;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float OPHLPMBIJLL;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long FMCDMCNOIHI;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long MMDMMIGCPJM;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int EBHJLPKDFCC;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 DBCGACMJBLI;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 PPAFIPCLOLG;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool OJDNHNEFDJF;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static CGDNDAKFJMF KEBDOLAIMEA;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long PNKMGKIIPLJ;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int BBFNDDFKIAE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int PGKPPDKNOHK;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int PLGJAAKAGON;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int FKKAOHDLKJA;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int NNJBOIAJOLK;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long MIJFODINKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int HGOECGHLBJJ;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int JIIBFCFCEEB;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int DPCEBGOMOPD;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long BACCANAPEMM;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long DCAHLDJPBIM;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long CBFKPKDHFAN;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long MCJKPFBFDOE;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int NCLCOLLPBON;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int NPJNGGGOBDE;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int NPKAKCHGLMN;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int PJPMLIGCLLJ;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] HDAJMGOIBEC;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int MAFEDIAOFNE;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long PLBADPBMCHP;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long KBLPJIDLPPC;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int BFBCGBKNIDI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int FNJPIBOMNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long PJMKJFPMHLN;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long JMDLHHLKAMB;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long AFIPBNHCDFM;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long FDGPHOFDCOB;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long AAKGFMMFOID;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long CCMJHBCDABO;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long DMLLIIOEOEF;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long IFGIMMLNOJH;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long MPIOEIBEJBH;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float FJLJJGMHFAD;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float AOHLOAHMMCG;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long IGIIGFEHCAD;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int NLOALNJAFHI;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long GNDIGIJAELA;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long EHIEIPKCMJD;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float LIJBCJPGAJC;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long LHMFIODIHJL;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long ONBMHGBFNLC;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long GEAFANODFKN;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long IEKEMLANJJK;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long AOHCBAMACKC;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long CDAECBCCEGB;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long AABJFIAIMGM;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long NHCLAPFOMBI;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long ACBLMMGALNF;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long EMGOPMMLLPE;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long ENFEEMKEKOD;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long KPHHEODLLDA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static KOJANJNGMAO HOAEBBGJBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A80B10", Offset = "0x7A7F510", VA = "0x187A80B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long EIPGOIHJJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A80AB0", Offset = "0x7A7F4B0", VA = "0x187A80AB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7A804E0", Offset = "0x7A7EEE0", VA = "0x187A804E0")]
	public static void GICIIJLMMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A80B60", Offset = "0x7A7F560", VA = "0x187A80B60")]
	public static void NFPDBLCJKAF(KOJANJNGMAO OJIJFCABJMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OLCHOCLALKD
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct GKMOPIHGGJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Vector3 NHAANPHMDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Quaternion JHFELMOKPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public float OLOBPPGFKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public Quaternion JODCCMFFIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public float LACMLOAGKPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float KKBFPGGPGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float NDLGGKOMGCC;
	}

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static List<GKMOPIHGGJM> HHNELOJKNLP;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A83CA0", Offset = "0x7A826A0", VA = "0x187A83CA0")]
	public static NativeList<CEGHMCHEJIL> LOMELELMIOH(KMCFMGGIDLM NKHEGOPIGCH)
	{
		return default(NativeList<CEGHMCHEJIL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A82920", Offset = "0x7A81320", VA = "0x187A82920")]
	private static bool GBHBGNNIBCF(int LGMJDKKAMNE, NativeList<CEGHMCHEJIL> FFBEKAFHIDB, List<GKMOPIHGGJM> AFMAHHBBIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7A856E0", Offset = "0x7A840E0", VA = "0x187A856E0")]
	private static CEGHMCHEJIL PCOJKDPFAIC(int AIBKCJCMBBN, List<GKMOPIHGGJM> AFMAHHBBIPL)
	{
		return default(CEGHMCHEJIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A837B0", Offset = "0x7A821B0", VA = "0x187A837B0")]
	private static CEGHMCHEJIL GFJKIOEANNP(int AIBKCJCMBBN, List<GKMOPIHGGJM> AFMAHHBBIPL)
	{
		return default(CEGHMCHEJIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A82840", Offset = "0x7A81240", VA = "0x187A82840")]
	private static CEGHMCHEJIL APOBAFDOHKL(Vector3 OBJAOKLALFD, Quaternion ADLPINICHDN, float OAIHKLDEKFL)
	{
		return default(CEGHMCHEJIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A84240", Offset = "0x7A82C40", VA = "0x187A84240")]
	public static NativeList<CEGHMCHEJIL> PANMBEFBLGK(KMCFMGGIDLM NKHEGOPIGCH, float MONDOOGEEEA)
	{
		return default(NativeList<CEGHMCHEJIL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ABMFIGNJFHD
{
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public static Vector3 EAAENGNDMBB;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 GFALBABMJGL;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static readonly float LNGLNHEKNLL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F8A0", Offset = "0x7A7E2A0", VA = "0x187A7F8A0")]
	public static Vector3 DFBOJEGMEBF(Vector3 ILOGNCCCHJF, Quaternion ADLPINICHDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F1E0", Offset = "0x7A7DBE0", VA = "0x187A7F1E0")]
	public static Vector3 AABLFNHOAKG(Quaternion KONJHPLFEME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A7FCA0", Offset = "0x7A7E6A0", VA = "0x187A7FCA0")]
	public static Vector3 EMNNPFFGIOC(Quaternion KONJHPLFEME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A7FD40", Offset = "0x7A7E740", VA = "0x187A7FD40")]
	public static Quaternion FEMKHKJFFLM(Vector3 BJECPMGLFMN, Vector3 MDIKGGEOGCO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F6B0", Offset = "0x7A7E0B0", VA = "0x187A7F6B0")]
	public static Vector3 DFBDOJEPBML(Vector3 NDIBCHJBLFL, Vector3 FCLGOEHLHKC, Vector3 MDIKGGEOGCO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F280", Offset = "0x7A7DC80", VA = "0x187A7F280")]
	public static Vector3 ABEMGPCOGIG(Vector3 ILOGNCCCHJF, Vector3 MDIKGGEOGCO, Quaternion KONJHPLFEME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A800B0", Offset = "0x7A7EAB0", VA = "0x187A800B0")]
	public static Quaternion NLOOLAPANFM(Quaternion ADLPINICHDN, Vector3 BJECPMGLFMN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A7FB20", Offset = "0x7A7E520", VA = "0x187A7FB20")]
	public static bool EGGGJMDPONC(Vector3 EAHPPPPPPHL, Vector3 PGNEJIBAPEA, [Out] Vector3 FGINBKCNIHH, bool PNNOMKONPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7A7FDC0", Offset = "0x7A7E7C0", VA = "0x187A7FDC0")]
	public static Vector3 HPFKNPJIHGO(bool FBIGEMOCMJB, [Optional] Quaternion CLJKOCPJPOE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CEGHMCHEJIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public float3 NHAANPHMDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3x3 JHFELMOKPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float OLOBPPGFKCK;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KMCFMGGIDLM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int LJEEPKKHAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 KIAOEEIGGKK(int AIBKCJCMBBN);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion HLADAPMOJPG(int AIBKCJCMBBN);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float ABJDAFCCBDE(int AIBKCJCMBBN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KOBGOEHEJAM : INKAKBMLPEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HPEMNCOOJKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PODNLPPIGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float MIEAJCFMJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int OHGHIHMCMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JDJHABCKPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int CCGIPAEILIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CEGHMCHEJIL> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HFEEEJKKJME : INKAKBMLPEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BPEIFANGIJA IINCIAONFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DNAFPIBDLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 MFOOEHLOKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CMKEMJONGPA
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	FJCDPKDIACD GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NIIEHKEHOHC EENGMHNFCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface INKAKBMLPEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EIDHKNJDLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool FJFKACMNCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FJCDPKDIACD GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS IOFJCLBHEML
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float LADMGFNEMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 NFMCJKEAIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	ADADNEEPCEF ICNGAJNFJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	KJDEIJDKCCB FPCKKLJAEBO
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
public interface IEKLAJFHIFL
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int HOMPKHODPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform JLICBIOPOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HLJLJIIEAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBGLFFCNIBO GetBone(int AIBKCJCMBBN);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int AIBKCJCMBBN);
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
