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
public enum HKJGGLJBOND
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
public enum NIBPFMHDCCB
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
public enum NANCINDJPCK
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
public enum MIOMDMDHLED
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
public enum GPFFCLEGEBK
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
public enum HHGCLPMBJBD
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
public static class CAGMGNMMDKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A45110", Offset = "0x7A44510", VA = "0x187A45110")]
	public static bool FLOIGIMJJLA(this HHGCLPMBJBD MEABJLCPOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7A450D0", Offset = "0x7A444D0", VA = "0x187A450D0")]
	public static bool CFFFCCKKCMD(this HHGCLPMBJBD MEABJLCPOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7A450E0", Offset = "0x7A444E0", VA = "0x187A450E0")]
	public static bool DCGLLIBHBBJ(this HHGCLPMBJBD MEABJLCPOGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PDDOBMNCGIK
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
public struct OIICOGMNAJO : PFGKJOCFDIP, IEquatable<OIICOGMNAJO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int EGOLIAJEBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2CB98E0", Offset = "0x2CB8CE0", VA = "0x182CB98E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C890", Offset = "0x6B3BC90", VA = "0x186B3C890", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PNPLPCMDCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7A486C0", Offset = "0x7A47AC0", VA = "0x187A486C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1796AF0", Offset = "0x1795EF0", VA = "0x181796AF0", Slot = "8")]
	public bool Equals(OIICOGMNAJO KNCKFHOKGJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x344F690", Offset = "0x344EA90", VA = "0x18344F690")]
	public static bool PEOCKCCHEIN(OIICOGMNAJO PCMHLCLONGN, OIICOGMNAJO IAJJOLNCJOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A48630", Offset = "0x7A47A30", VA = "0x187A48630", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7A48700", Offset = "0x7A47B00", VA = "0x187A48700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LCIMFKFFNPO : PFGKJOCFDIP, IEquatable<LCIMFKFFNPO>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int EGOLIAJEBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2CB98E0", Offset = "0x2CB8CE0", VA = "0x182CB98E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C890", Offset = "0x6B3BC90", VA = "0x186B3C890", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PNPLPCMDCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A48490", Offset = "0x7A47890", VA = "0x187A48490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1796AF0", Offset = "0x1795EF0", VA = "0x181796AF0", Slot = "8")]
	public bool Equals(LCIMFKFFNPO KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A48400", Offset = "0x7A47800", VA = "0x187A48400", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A484D0", Offset = "0x7A478D0", VA = "0x187A484D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LHCPDKENODA : PFGKJOCFDIP, IEquatable<LHCPDKENODA>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EGOLIAJEBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2CB98E0", Offset = "0x2CB8CE0", VA = "0x182CB98E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C890", Offset = "0x6B3BC90", VA = "0x186B3C890", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PNPLPCMDCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7A485F0", Offset = "0x7A479F0", VA = "0x187A485F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1796AF0", Offset = "0x1795EF0", VA = "0x181796AF0", Slot = "8")]
	public bool Equals(LHCPDKENODA KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A48560", Offset = "0x7A47960", VA = "0x187A48560", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NGAIKMOOEAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOIPHILJOMC(OIICOGMNAJO BKHMOJGGBFN, NIBPFMHDCCB DOPPEDALNIC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOIPHILJOMC(LCIMFKFFNPO KFBPKKLDJOM, NIBPFMHDCCB DOPPEDALNIC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGHNIMAGIAA(LCIMFKFFNPO KFBPKKLDJOM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KBEEMENKACM(LCIMFKFFNPO KFBPKKLDJOM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPDPCNJIEHJ();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNCHCKBHMNF(NIBPFMHDCCB HAFNBBNOLPO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HCJFCKKOLGD(OIICOGMNAJO BKHMOJGGBFN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HCJFCKKOLGD(LCIMFKFFNPO KFBPKKLDJOM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AKDEIDFIMFK(LCIMFKFFNPO KFBPKKLDJOM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PIIFPNHMFMD(LCIMFKFFNPO KFBPKKLDJOM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KEADOEOBNDK();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DJENGIOOMJO();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FIPHMFGBKPJ(OIICOGMNAJO BKHMOJGGBFN, GPFFCLEGEBK HAFNBBNOLPO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FHFNJIFJAMN(LCIMFKFFNPO KFBPKKLDJOM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GKKCDAGJKNE(LCIMFKFFNPO KFBPKKLDJOM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NNAOLBPIFFF();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HNNJHOLJEOG(GPFFCLEGEBK HAFNBBNOLPO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BBPFKMIFFEE(OIICOGMNAJO BKHMOJGGBFN, Vector3 HBNIPOIBKCA, Vector3 EGLCALKIHPA, Vector3 MMCDLCPIFGA, float GELFBGAEFJG, float GHACIECNEBE, IReadOnlyList<Camera> OMEAFEJKMKE, HKJGGLJBOND DPGMLKFBPHP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BBPFKMIFFEE(LHCPDKENODA BKNPBBIMBII, Vector3 HBNIPOIBKCA, Vector3 EGLCALKIHPA, Vector3 MMCDLCPIFGA, float GELFBGAEFJG, float GHACIECNEBE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BCDHLHGCIBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PJPDFLJAPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC, bool MOBNFCMLLKG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLDLMMCILAA(OIICOGMNAJO BKHMOJGGBFN);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEJMBKEPGGA(OIICOGMNAJO BKHMOJGGBFN);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LCIMFKFFNPO GMDPAAENKIG(OIICOGMNAJO BKHMOJGGBFN, JKEFCPMGAAL HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LCIMFKFFNPO PIAEENMNGEA(OIICOGMNAJO BKHMOJGGBFN, CAJIMFNGHMB HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AIFKHDKINLG(LCIMFKFFNPO KFBPKKLDJOM);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GLMDKGPPDMK(LCIMFKFFNPO KFBPKKLDJOM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LHCPDKENODA IEONHDNNILK(GHAIBLPNJLP HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AKKIODPGMAF(LHCPDKENODA BKNPBBIMBII);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DKIGEBNPFKE(LHCPDKENODA BKNPBBIMBII);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task BKMBIOKHNFG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LCICLGADGAP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task LEHGKIFIMMH();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JNLLFPJCFEF();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> LLLGJLOHBHF(OIICOGMNAJO BKHMOJGGBFN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FEBPFOIDMEP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum PBIIHOEEKKM
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum IGPEAJMGMMM
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum CIOCBNKPEMP
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
	public enum NIEFFIBPHMJ
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
	public enum NOGOGOADAIF
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
	public enum JGGEECOMIEG
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
	public enum MPMIDDJFPKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum NPDLDICCBFA
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
	public static bool JDJJHAODHNB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long CADFAHPPKIH;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool IPGMBLANBGE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool MFJFEJJFGAO;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool ENMKKKKJLAD;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float BLBOLNLGALI;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float EIEFBPFOJEN;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int IDGNMHAGADP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static JGGEECOMIEG HKLFCKDBMPF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long CCHAEKCMAGB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float ADDHNEKGIPI;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int EDFLGBMIIHH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int IPMLGANFJHN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int FKIGKEBJCCL;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int CIMBGABBDEF;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int GBLADIOHIPF;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int ALCPKKOCKCO;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int HOAPILBLHLC;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int DCAPAHHIICM;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool MKBODGFJKNN;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int ANAIGLCJHOM;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int GFFCACABLDJ;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int MHFAMFBFJAJ;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool NBCMGBBINLL;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float EPDPCOCADMB;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool PEGIBKKDIHJ;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float HEPMAOCLMAP;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long GCMAENIGOLD;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool NLBKFFCPABE;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long IBPBFNJFBDO;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int BDKLPAEDALI;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool FBEIABHIEJE;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static PBIIHOEEKKM CJEBOPLLBOG;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool JMNGMIICMOF;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool OFDHPKIKMML;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int GCLHKKKLNMP;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int FMFCJNMAECE;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int EGJHJNFBJHB;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int BAGCIGAECNH;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int MEAKNKOCPMM;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int PDJBEPMGHFA;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int ALKBBFLPKLL;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int JCDAEMJBMEA;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float NOIMANGOHHA;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float HEHCCIMKDOD;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float BDDKLIEDIMK;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float GICMBPPALPN;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int NKPKILCNBOI;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int BDGHDNOMDGO;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int JLENNCGLHOF;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int CBFJIJNJMEP;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool MODDKIANGAN;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static CIOCBNKPEMP BNJBKIELDEP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static NIEFFIBPHMJ ANHILAAIOAI;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool MHMGMEAKHOE;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static IGPEAJMGMMM IKEAAGGHPOD;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float JAHODNCCIEO;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float NMAPFLCHACC;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float AGEPCJHBLNM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float KGLKGMAGLCJ;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float JCDMEEKONLM;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float OELLIBAFBKG;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float GFOFAJKACKL;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float HPGIKIJMIBN;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool GKOFOAFFEJI;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static MPMIDDJFPKA OGDGEAJAHMB;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool FHLDACPDDKP;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float OCPPOCMFKEM;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float EGIBAGMAMFJ;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float BNPJLHEKPMC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float IFCMADIKKLA;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float PEGGOKPJKOP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool FNMBNGHPHGM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long ININJGKKHAE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float DEEMFCPJNGH;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float HENEBLOIMBG;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float HIDKECJAAKD;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int EGFKDNFAEMM;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float BIOGMMGNGGN;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool APDLGNHHEOO;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long JOCFOEAGDLD;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int FIHJBEPOJFL;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int LOMLHNIMOEN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float BEKLOGOPNKA;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float FLJHFFLGMEC;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool LLJFCFBGDCN;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool BPPFFLABBEB;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float DHLPGBPMGIF;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long BILGDHBIMJJ;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long BHKNDPNHPOC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int LLCJMNIFBBD;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static float4x4 MIDPCEOLKFP;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float3 ENLHACJLHAH;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static bool CABFPJDANOB;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static NOGOGOADAIF DOCFNCGMIGN;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long JIPPJLDMCOP;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int NLOMFODBMKC;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static int GNAGBLMDJIP;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static int BHAIEJCNFKF;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int LHKDFFFMNEF;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int JGDPAMJMIMB;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long CLBEJDBGAJJ;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int GCGAJCDKHLK;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int HENFGLAOEJD;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int AOLGLMPNHKB;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long MJMJFFJOKPL;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long POHIFMIALBM;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long DBECLFAFONG;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long PGDLFCJJEAL;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static int ECHMNIKHOKH;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int LKADMGILHIE;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int FCCNMHEBEFM;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int IFCGKJBKNMA;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static int[] FKMLMPKEICF;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static int PKOEENJJFBA;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long OAGHNBGKGBG;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long OLIMEOABECJ;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int CKCBAIIAIDM;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int ILGBAPLIPFM;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static long ILPFFCOEDGE;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static long DLOAFFMGIPH;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static long DJDIKJLIHNC;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static long FOJNCGHAMGI;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static long BMEPHAPCOMN;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static long LGOIMFENOBG;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long MDFIEAEIFFL;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long HPMHPPENBBM;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static long EOAOMKMANHJ;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static float IKPIGIBOAIE;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static float KNAKFPJHLHC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long GCEDPFJAJAA;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static int ANEOANGNEEH;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long EHCFCFCCPDD;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long JLHNKJAHLMC;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static float NDMLAKCJFCN;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long KPKMBBGLPMC;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long HADPKCCNHNN;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long ODJNAIJJNHA;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static long FECBNBMIPCI;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static long BIJIHJLKBLI;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long KKLMAADDJOD;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static long HMEKLJBDGOA;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long LOGBNEECHLH;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long MELHLGBOBFA;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static long JHAAEOOLLKJ;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long HHAOJJHNKAF;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long DPCLKLNNKJN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static NPDLDICCBFA JFKGCKMHGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A45190", Offset = "0x7A44590", VA = "0x187A45190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long CNOKEJHMCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A45130", Offset = "0x7A44530", VA = "0x187A45130")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7A460A0", Offset = "0x7A454A0", VA = "0x187A460A0")]
	public static void JLOFCAFOBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A451E0", Offset = "0x7A445E0", VA = "0x187A451E0")]
	public static void JKAMLHAOOMM(NPDLDICCBFA KLCAONGFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OOMKKJINKPC
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct BGENBCLHHEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Vector3 KLIFIKMFFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Quaternion APIEPNJDKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public float DNCJLMMFDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public Quaternion BOKDCKAODFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public float JIAOKFCLPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public float IGFFBICOMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float OBOPAFPCFLD;
	}

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static List<BGENBCLHHEL> GMIFMLFLODM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A48EE0", Offset = "0x7A482E0", VA = "0x187A48EE0")]
	public static NativeList<NPAMCAHKLLB> FIAKLNJHPNB(MGEJOGHOFMB KEEIIFLKIND)
	{
		return default(NativeList<NPAMCAHKLLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A49480", Offset = "0x7A48880", VA = "0x187A49480")]
	private static bool MECFCHDDFIA(int JKHIIFLAPEC, NativeList<NPAMCAHKLLB> HBALBIOOGIJ, List<BGENBCLHHEL> OEDFEBEPMFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7A48C80", Offset = "0x7A48080", VA = "0x187A48C80")]
	private static NPAMCAHKLLB CFENDAGKPKN(int NMAOAJDPHDG, List<BGENBCLHHEL> OEDFEBEPMFH)
	{
		return default(NPAMCAHKLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A48790", Offset = "0x7A47B90", VA = "0x187A48790")]
	private static NPAMCAHKLLB BFLDCPGMONF(int NMAOAJDPHDG, List<BGENBCLHHEL> OEDFEBEPMFH)
	{
		return default(NPAMCAHKLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A48E00", Offset = "0x7A48200", VA = "0x187A48E00")]
	private static NPAMCAHKLLB ELJGBOAEMPJ(Vector3 HDCIJLICBPE, Quaternion CLAPLHOFOCL, float JAINCGFCEKN)
	{
		return default(NPAMCAHKLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4A310", Offset = "0x7A49710", VA = "0x187A4A310")]
	public static NativeList<NPAMCAHKLLB> PECDCDNGCHA(MGEJOGHOFMB KEEIIFLKIND, float DJBLLBGHJKF)
	{
		return default(NativeList<NPAMCAHKLLB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ICCAHDKGKEB
{
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public static Vector3 ILDGBICFPMF;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static Vector3 EMAGEAKCHHH;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public static readonly float OOGDCOGNPPG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A475D0", Offset = "0x7A469D0", VA = "0x187A475D0")]
	public static Vector3 FEOBEOJMDBE(Vector3 KJJHEGGBBKF, Quaternion CLAPLHOFOCL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A47100", Offset = "0x7A46500", VA = "0x187A47100")]
	public static Vector3 BMGEHMKEFPE(Quaternion AJFJKBHPFHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A47850", Offset = "0x7A46C50", VA = "0x187A47850")]
	public static Vector3 IBIJCMHOBMH(Quaternion AJFJKBHPFHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A48130", Offset = "0x7A47530", VA = "0x187A48130")]
	public static Quaternion NDICAGILEBN(Vector3 GOMJGIJPEPD, Vector3 BELINKGJHGO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7A47BE0", Offset = "0x7A46FE0", VA = "0x187A47BE0")]
	public static Vector3 LKLDNKHHKNC(Vector3 HFPHFHGAAEM, Vector3 IBFIDCBIGMJ, Vector3 BELINKGJHGO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7A471A0", Offset = "0x7A465A0", VA = "0x187A471A0")]
	public static Vector3 CAJHBIKALGI(Vector3 KJJHEGGBBKF, Vector3 BELINKGJHGO, Quaternion AJFJKBHPFHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A47DD0", Offset = "0x7A471D0", VA = "0x187A47DD0")]
	public static Quaternion LLINDPGKHJD(Quaternion CLAPLHOFOCL, Vector3 GOMJGIJPEPD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A481B0", Offset = "0x7A475B0", VA = "0x187A481B0")]
	public static bool NIKPKGBKAIK(Vector3 MBCMOADEJDL, Vector3 CNCDKDOOMIB, [Out] Vector3 HNPFPDNMBIN, bool ACHBAHLFEKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7A478F0", Offset = "0x7A46CF0", VA = "0x187A478F0")]
	public static Vector3 KJPLEFJLKPL(bool ICLCPEDFMCD, [Optional] Quaternion CABAHBFBLDP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NPAMCAHKLLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public float3 KLIFIKMFFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float3x3 APIEPNJDKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public float DNCJLMMFDBP;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MGEJOGHOFMB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	int MDGENNPIBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FAEHEKEDMEI(int NMAOAJDPHDG);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion CDFPEKNOFOE(int NMAOAJDPHDG);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float KEAMNFFPBEJ(int NMAOAJDPHDG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CAJIMFNGHMB : HNHLMEHDPNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NJFNLKGAPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool CIPMINOOIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float MMIPFNDLNKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int ANDHONEAKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MNIKIPNBOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int MPCKDJKFNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<NPAMCAHKLLB> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JKEFCPMGAAL : HNHLMEHDPNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NANCINDJPCK NBDCOHDLODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HPKGHNAEBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float3 IGDJHJNCEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AAMGODPHIMC
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	FGCPOOOBBED IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MIOMDMDHLED DAAEMKJBPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HNHLMEHDPNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MDHENJMFLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool DJBPAGMNFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FGCPOOOBBED IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	UniformTRS OLOEIHKNHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float FKEGODKMFLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 HBHMJGEBOCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	HHGCLPMBJBD JHKALKPKMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	PDDOBMNCGIK LHLHEOIGPCJ
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
public interface GHAIBLPNJLP
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int OPDLFIDJKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform BEIMHJMMBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool FPOIPCJLODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OIICOGMNAJO GetBone(int NMAOAJDPHDG);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int NMAOAJDPHDG);
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
