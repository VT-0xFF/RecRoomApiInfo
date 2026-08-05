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
public enum AOGAPOHFFKE
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
public enum MBMBIKLIHBO
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
public enum IJLMADBEADJ
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
public enum NKFNEIOPDJI
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
public enum LMGPPFPNJGM
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
public enum NPNHMPJJEOO
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
public static class MPIJMJBHMLA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE7A0", Offset = "0x6FBD7A0", VA = "0x186FBE7A0")]
	public static bool MAMLPMNDNOD(this NPNHMPJJEOO OCABHBLBJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE790", Offset = "0x6FBD790", VA = "0x186FBE790")]
	public static bool FDBFANNPDDK(this NPNHMPJJEOO OCABHBLBJNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE7C0", Offset = "0x6FBD7C0", VA = "0x186FBE7C0")]
	public static bool NNMJDAJBLAM(this NPNHMPJJEOO OCABHBLBJNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OLBGPBMGBBB
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
public struct IDPGIPNIFJI : JGFOKCMIJII, IEquatable<IDPGIPNIFJI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int HOLNAIGPNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD342A0", Offset = "0xD332A0", VA = "0x180D342A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int ECKOFMKJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28BDA20", Offset = "0x28BCA20", VA = "0x1828BDA20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x625B930", Offset = "0x625A930", VA = "0x18625B930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MNCIMEONHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD330", Offset = "0x6FBC330", VA = "0x186FBD330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x21F30A0", Offset = "0x21F20A0", VA = "0x1821F30A0", Slot = "8")]
	public bool Equals(IDPGIPNIFJI DFABCHNPEEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E63350", Offset = "0x6E62350", VA = "0x186E63350")]
	public static bool MCPOKKIFBCL(IDPGIPNIFJI LGLGFADDDNK, IDPGIPNIFJI GMGEKOBCPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD370", Offset = "0x6FBC370", VA = "0x186FBD370", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD400", Offset = "0x6FBC400", VA = "0x186FBD400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NCNPLBDGKJG : JGFOKCMIJII, IEquatable<NCNPLBDGKJG>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int HOLNAIGPNGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD342A0", Offset = "0xD332A0", VA = "0x180D342A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int ECKOFMKJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28BDA20", Offset = "0x28BCA20", VA = "0x1828BDA20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x625B930", Offset = "0x625A930", VA = "0x18625B930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MNCIMEONHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE7F0", Offset = "0x6FBD7F0", VA = "0x186FBE7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21F30A0", Offset = "0x21F20A0", VA = "0x1821F30A0", Slot = "8")]
	public bool Equals(NCNPLBDGKJG DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE830", Offset = "0x6FBD830", VA = "0x186FBE830", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE8C0", Offset = "0x6FBD8C0", VA = "0x186FBE8C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EGGNMLGOPHJ : JGFOKCMIJII, IEquatable<EGGNMLGOPHJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int HOLNAIGPNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD342A0", Offset = "0xD332A0", VA = "0x180D342A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ECKOFMKJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28BDA20", Offset = "0x28BCA20", VA = "0x1828BDA20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x625B930", Offset = "0x625A930", VA = "0x18625B930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MNCIMEONHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD260", Offset = "0x6FBC260", VA = "0x186FBD260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x21F30A0", Offset = "0x21F20A0", VA = "0x1821F30A0", Slot = "8")]
	public bool Equals(EGGNMLGOPHJ DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD2A0", Offset = "0x6FBC2A0", VA = "0x186FBD2A0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IMEMCGEGJLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIKILPPLGIF(IDPGIPNIFJI BAOAKGNNKEP, MBMBIKLIHBO FAPOANHDBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIKILPPLGIF(NCNPLBDGKJG IBBFKPKLPBJ, MBMBIKLIHBO FAPOANHDBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIDENNLAFLO(NCNPLBDGKJG IBBFKPKLPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMPJHHCLEFC(NCNPLBDGKJG IBBFKPKLPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DEHIOAKAFBH();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ENELADCLPND(MBMBIKLIHBO PFCMGBLCCPJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OPJNIDANPOK(IDPGIPNIFJI BAOAKGNNKEP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPJNIDANPOK(NCNPLBDGKJG IBBFKPKLPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JBCPECJHPCH(NCNPLBDGKJG IBBFKPKLPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IHFOCEIGAJP(NCNPLBDGKJG IBBFKPKLPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PCHJMEHFPNI();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JDEOPHLICFP();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ENDPPKOLNCA(IDPGIPNIFJI BAOAKGNNKEP, LMGPPFPNJGM PFCMGBLCCPJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IEPMHFJOFNL(NCNPLBDGKJG IBBFKPKLPBJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FIOAKNPHNNA(NCNPLBDGKJG IBBFKPKLPBJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AJJGDFEJGLO();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void APDJLAOCIBL(LMGPPFPNJGM PFCMGBLCCPJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IEJAJIBAPLE(IDPGIPNIFJI BAOAKGNNKEP, Vector3 CMMHLMPKNCN, Vector3 KJJGINJLONJ, Vector3 FNKGEKINHAK, float NPEEEIMEKAF, float NLANHOMAIDE, IReadOnlyList<Camera> ALHGLBCCNDN, AOGAPOHFFKE BDCHGADKEKN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IEJAJIBAPLE(EGGNMLGOPHJ JFODLDCLNGN, Vector3 CMMHLMPKNCN, Vector3 KJJGINJLONJ, Vector3 FNKGEKINHAK, float NPEEEIMEKAF, float NLANHOMAIDE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ILPHBGBDKHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EAABAEMLFEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDPGIPNIFJI OHJIAAEBMAI(NDBPAKEIKHH CONAFKKIHKL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDPGIPNIFJI OHJIAAEBMAI(NDBPAKEIKHH CONAFKKIHKL, bool NIEBAAHILOH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFNPCFFDHAD(IDPGIPNIFJI BAOAKGNNKEP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBCPOALKBIA(IDPGIPNIFJI BAOAKGNNKEP);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NCNPLBDGKJG AMNCIMKFGBN(IDPGIPNIFJI BAOAKGNNKEP, BNIKHDAFNNC CONAFKKIHKL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NCNPLBDGKJG OPLCHGGNOAA(IDPGIPNIFJI BAOAKGNNKEP, JEMPNBCGPMN CONAFKKIHKL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGFAHPHCDJG(NCNPLBDGKJG IBBFKPKLPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FIIPFPIDOJK(NCNPLBDGKJG IBBFKPKLPBJ);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EGGNMLGOPHJ KKIANMJFENC(DNHEJINNFOF CONAFKKIHKL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BKOBGMPBDNN(EGGNMLGOPHJ JFODLDCLNGN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NNEOOMBNBHJ(EGGNMLGOPHJ JFODLDCLNGN);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task JCCBHEKBMKG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task FNKBCGKKKMO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task ANKBFPDNNFA();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HMMGIGDPIIE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> FMPNMOGLLDK(IDPGIPNIFJI BAOAKGNNKEP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PGDNNEPNODJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum JNPHPHMIDFB
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		PercentOfMax,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		PercentByDistance,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		ScreenPixels
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum MIDEFNAEOJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum LAAGIBLCPLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum KHCGEFDPFOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum NCKDELLLPDP
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum HILBFLFFIDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Quest3,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		MemoryBuild,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static int LNAGGJBNLJN;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static int KBBGHOJKNEK;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static int FBKHJMADAHG;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static int NOFHFOPNLBC;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static int[] JMMHDAHNICE;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static int OIDEHEIKKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static int FFAPBAFJBDM;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static int OHGDJIIBDLN;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static int CKOGGNALDOB;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static long DHEGFMOKFEI;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static long NCJFAEIOFLL;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static long NJBLHCGPDGC;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static long ACFAGJKJKAP;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static long EKGABLGHKOL;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static long BKIFLEHMHEP;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static long DONHOAGMCDO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static long DGOPHICPJPG;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long JKDAKOACFLM;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static long DJGHFMFKEPJ;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static long GEGLJAKDFMJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static long BLMDLCOHNLO;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static long GDLPNLCABNF;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static long NMOKPDCEHGD;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static float AILDPHGCIBB;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long OPCHEAJKFGO;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static long JDNKCEHPMPG;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static long CAACNLKPIBO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static long PCFEAGGMNAJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float EKBONAHENOH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static long EHFIEHNKKPH;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static long CPHDLJNHHOM;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static long CBEDLIIFIFO;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long HCIDFCFMDOO;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long KPCDEEDFOBO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool JIENBOJLJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFAE0", Offset = "0x6FBEAE0", VA = "0x186FBFAE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEAA0", Offset = "0x6FBDAA0", VA = "0x186FBEAA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static HILBFLFFIDN JBBHKKOIAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FC06E0", Offset = "0x6FBF6E0", VA = "0x186FC06E0")]
		[CompilerGenerated]
		get
		{
			return default(HILBFLFFIDN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0940", Offset = "0x6FBF940", VA = "0x186FC0940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool BAJCGEDFLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE950", Offset = "0x6FBD950", VA = "0x186FBE950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFB90", Offset = "0x6FBEB90", VA = "0x186FBFB90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool AMHONCPEDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FC22F0", Offset = "0x6FC12F0", VA = "0x186FC22F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0580", Offset = "0x6FBF580", VA = "0x186FC0580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static JNPHPHMIDFB KIDDPDEPHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC21A0", Offset = "0x6FC11A0", VA = "0x186FC21A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool DFANIIIOMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBED90", Offset = "0x6FBDD90", VA = "0x186FBED90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0120", Offset = "0x6FBF120", VA = "0x186FC0120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static MIDEFNAEOJF FFKOMDAEGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFD40", Offset = "0x6FBED40", VA = "0x186FBFD40")]
		[CompilerGenerated]
		get
		{
			return default(MIDEFNAEOJF);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0990", Offset = "0x6FBF990", VA = "0x186FC0990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool GIFKEPIEOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEB40", Offset = "0x6FBDB40", VA = "0x186FBEB40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0790", Offset = "0x6FBF790", VA = "0x186FC0790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool LLEOFCKANPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1A70", Offset = "0x6FC0A70", VA = "0x186FC1A70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEE30", Offset = "0x6FBDE30", VA = "0x186FBEE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool FEEMHLHJPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFA90", Offset = "0x6FBEA90", VA = "0x186FBFA90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2340", Offset = "0x6FC1340", VA = "0x186FC2340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static float MGAELEKNMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1A20", Offset = "0x6FC0A20", VA = "0x186FC1A20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2090", Offset = "0x6FC1090", VA = "0x186FC2090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int ABFPCAHDBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFF10", Offset = "0x6FBEF10", VA = "0x186FBFF10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0380", Offset = "0x6FBF380", VA = "0x186FC0380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int GPMEDILFIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1F90", Offset = "0x6FC0F90", VA = "0x186FC1F90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEAF0", Offset = "0x6FBDAF0", VA = "0x186FBEAF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int GAAKPGCMAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0180", Offset = "0x6FBF180", VA = "0x186FC0180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC08F0", Offset = "0x6FBF8F0", VA = "0x186FC08F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int NLCOBBILEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0840", Offset = "0x6FBF840", VA = "0x186FC0840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF900", Offset = "0x6FBE900", VA = "0x186FBF900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static int NNJPFAEKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0290", Offset = "0x6FBF290", VA = "0x186FC0290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFCF0", Offset = "0x6FBECF0", VA = "0x186FBFCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int LHPHBFCHHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2400", Offset = "0x6FC1400", VA = "0x186FC2400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF9A0", Offset = "0x6FBE9A0", VA = "0x186FBF9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static float MKFJIKPBOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1EA0", Offset = "0x6FC0EA0", VA = "0x186FC1EA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6FC24A0", Offset = "0x6FC14A0", VA = "0x186FC24A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int KMGMELHHEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1860", Offset = "0x6FC0860", VA = "0x186FC1860")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FC09E0", Offset = "0x6FBF9E0", VA = "0x186FC09E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static int NFHCCALMLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFCA0", Offset = "0x6FBECA0", VA = "0x186FBFCA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6FC21F0", Offset = "0x6FC11F0", VA = "0x186FC21F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static int ALFNGAPGPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFC50", Offset = "0x6FBEC50", VA = "0x186FBFC50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEC90", Offset = "0x6FBDC90", VA = "0x186FBEC90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static float AOMCHINBLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFF60", Offset = "0x6FBEF60", VA = "0x186FBFF60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC03D0", Offset = "0x6FBF3D0", VA = "0x186FC03D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static float DJGFKPHELFB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1970", Offset = "0x6FC0970", VA = "0x186FC1970")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEE90", Offset = "0x6FBDE90", VA = "0x186FBEE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static float IDBBEHBMKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6FC02E0", Offset = "0x6FBF2E0", VA = "0x186FC02E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1D60", Offset = "0x6FC0D60", VA = "0x186FC1D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool ECGIPODHLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1CC0", Offset = "0x6FC0CC0", VA = "0x186FC1CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6FC01D0", Offset = "0x6FBF1D0", VA = "0x186FC01D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static int MHAONPIGILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1AC0", Offset = "0x6FC0AC0", VA = "0x186FC1AC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFFB0", Offset = "0x6FBEFB0", VA = "0x186FBFFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static int NJJBKBMAFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEC40", Offset = "0x6FBDC40", VA = "0x186FBEC40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF8B0", Offset = "0x6FBE8B0", VA = "0x186FBF8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static int PAIMIPBCPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0070", Offset = "0x6FBF070", VA = "0x186FC0070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1B10", Offset = "0x6FC0B10", VA = "0x186FC1B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int OONOOGPDOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2040", Offset = "0x6FC1040", VA = "0x186FC2040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEA50", Offset = "0x6FBDA50", VA = "0x186FBEA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static bool EOEPEFAKAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBECE0", Offset = "0x6FBDCE0", VA = "0x186FBECE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEFA0", Offset = "0x6FBDFA0", VA = "0x186FBEFA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static bool EKLNMEKCLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2150", Offset = "0x6FC1150", VA = "0x186FC2150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEF40", Offset = "0x6FBDF40", VA = "0x186FBEF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static float EAABKCKJOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0530", Offset = "0x6FBF530", VA = "0x186FC0530")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEBE0", Offset = "0x6FBDBE0", VA = "0x186FBEBE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static LAAGIBLCPLC NLEOFAKPOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1F40", Offset = "0x6FC0F40", VA = "0x186FC1F40")]
		[CompilerGenerated]
		get
		{
			return default(LAAGIBLCPLC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFA40", Offset = "0x6FBEA40", VA = "0x186FBFA40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static KHCGEFDPFOG PKJFBHOJOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF9F0", Offset = "0x6FBE9F0", VA = "0x186FBF9F0")]
		[CompilerGenerated]
		get
		{
			return default(KHCGEFDPFOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1D10", Offset = "0x6FC0D10", VA = "0x186FC1D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static bool GKCCICIOEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEDE0", Offset = "0x6FBDDE0", VA = "0x186FBEDE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFDE0", Offset = "0x6FBEDE0", VA = "0x186FBFDE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float KHHHFAGEBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1BB0", Offset = "0x6FC0BB0", VA = "0x186FC1BB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0430", Offset = "0x6FBF430", VA = "0x186FC0430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float PHPMIPPIGFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0330", Offset = "0x6FBF330", VA = "0x186FC0330")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC23A0", Offset = "0x6FC13A0", VA = "0x186FC23A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float KNBCBJDJOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC07F0", Offset = "0x6FBF7F0", VA = "0x186FC07F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFB30", Offset = "0x6FBEB30", VA = "0x186FBFB30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static float NLNKCLJCFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF950", Offset = "0x6FBE950", VA = "0x186FBF950")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1910", Offset = "0x6FC0910", VA = "0x186FC1910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static float AKIJPBENEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2450", Offset = "0x6FC1450", VA = "0x186FC2450")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6FBED30", Offset = "0x6FBDD30", VA = "0x186FBED30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static float GKGJHIKLKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0490", Offset = "0x6FBF490", VA = "0x186FC0490")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1C60", Offset = "0x6FC0C60", VA = "0x186FC1C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool PHPMNNPGKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEB90", Offset = "0x6FBDB90", VA = "0x186FBEB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6FC18B0", Offset = "0x6FC08B0", VA = "0x186FC18B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static float HAIFFGECGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1B60", Offset = "0x6FC0B60", VA = "0x186FC1B60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0890", Offset = "0x6FBF890", VA = "0x186FC0890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static int GBMDIIBAKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEA00", Offset = "0x6FBDA00", VA = "0x186FBEA00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0230", Offset = "0x6FBF230", VA = "0x186FC0230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static int BEBPDMNNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1EF0", Offset = "0x6FC0EF0", VA = "0x186FC1EF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0730", Offset = "0x6FBF730", VA = "0x186FC0730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool MHPOCJKEIBK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2240", Offset = "0x6FC1240", VA = "0x186FC2240")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static int LDKFLKADNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFD90", Offset = "0x6FBED90", VA = "0x186FBFD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC19C0", Offset = "0x6FC09C0", VA = "0x186FC19C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static int AIMBABIMILF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFBF0", Offset = "0x6FBEBF0", VA = "0x186FBFBF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool CMCCJCKFOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FC04E0", Offset = "0x6FBF4E0", VA = "0x186FC04E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1C00", Offset = "0x6FC0C00", VA = "0x186FC1C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float AFPJNFCDCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FC17C0", Offset = "0x6FC07C0", VA = "0x186FC17C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0630", Offset = "0x6FBF630", VA = "0x186FC0630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float KAPNJCIAIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1810", Offset = "0x6FC0810", VA = "0x186FC1810")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1E40", Offset = "0x6FC0E40", VA = "0x186FC1E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float GJOHJDGJNCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0690", Offset = "0x6FBF690", VA = "0x186FC0690")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FC20F0", Offset = "0x6FC10F0", VA = "0x186FC20F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static int CJDFAIONJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEEF0", Offset = "0x6FBDEF0", VA = "0x186FBEEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE9A0", Offset = "0x6FBD9A0", VA = "0x186FBE9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static float4x4 DCOPEMDPOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFE90", Offset = "0x6FBEE90", VA = "0x186FBFE90")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1DC0", Offset = "0x6FC0DC0", VA = "0x186FC1DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float3 DKCOOAPLDII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0000", Offset = "0x6FBF000", VA = "0x186FC0000")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2290", Offset = "0x6FC1290", VA = "0x186FC2290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static bool BIFCOPHIJON
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC05E0", Offset = "0x6FBF5E0", VA = "0x186FC05E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FC00C0", Offset = "0x6FBF0C0", VA = "0x186FC00C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static NCKDELLLPDP NMAJJCFMDGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFE40", Offset = "0x6FBEE40", VA = "0x186FBFE40")]
		[CompilerGenerated]
		get
		{
			return default(NCKDELLLPDP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1FE0", Offset = "0x6FC0FE0", VA = "0x186FC1FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0A30", Offset = "0x6FBFA30", VA = "0x186FC0A30")]
	public static void JGENDNMCDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF000", Offset = "0x6FBE000", VA = "0x186FBF000")]
	public static void DBMBNPEJEPL(HILBFLFFIDN CDIKEKJLNCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EFAONBNAAJP
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct POIGBCOLHLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Vector3 BFENJPJIDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Quaternion ILMJFGHLIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float FFDPGNIGBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public Quaternion HINMDBCMLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public float NPODMAFDEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float BGCDHGJHDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float POAIGDBECCM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static List<POIGBCOLHLG> LGMMKMDFOFG;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA1C0", Offset = "0x6FB91C0", VA = "0x186FBA1C0")]
	public static NativeList<JIGGBHLJOJK> CKAOFPGJFAP(CENOEKKBPMN GDCFNEAPALI)
	{
		return default(NativeList<JIGGBHLJOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA750", Offset = "0x6FB9750", VA = "0x186FBA750")]
	private static bool KHFAGEIGILJ(int MEJGJHNGKCJ, NativeList<JIGGBHLJOJK> POCKBMKNJHC, List<POIGBCOLHLG> EHBFCNMJGLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCA80", Offset = "0x6FBBA80", VA = "0x186FBCA80")]
	private static JIGGBHLJOJK NKNNMPKLGNG(int GGBBONMHPBA, List<POIGBCOLHLG> EHBFCNMJGLO)
	{
		return default(JIGGBHLJOJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCCE0", Offset = "0x6FBBCE0", VA = "0x186FBCCE0")]
	private static JIGGBHLJOJK PPICFNJKKEI(int GGBBONMHPBA, List<POIGBCOLHLG> EHBFCNMJGLO)
	{
		return default(JIGGBHLJOJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCC00", Offset = "0x6FBBC00", VA = "0x186FBCC00")]
	private static JIGGBHLJOJK NKNOLLBKEJL(Vector3 JADOFHDDGIG, Quaternion APDKCFMECLC, float PEGACPFCNHH)
	{
		return default(JIGGBHLJOJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB5E0", Offset = "0x6FBA5E0", VA = "0x186FBB5E0")]
	public static NativeList<JIGGBHLJOJK> MMFBLBMJMLE(CENOEKKBPMN GDCFNEAPALI, float EDFLCMJKFGF)
	{
		return default(NativeList<JIGGBHLJOJK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KNOKMLJCPKG
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static Vector3 DFBCCBABLMA;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static Vector3 MDHLHDPLKDL;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public static readonly float DDOELFHJHKN;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDE90", Offset = "0x6FBCE90", VA = "0x186FBDE90")]
	public static Vector3 JHLIEFFKGPA(Vector3 ENBFOBEBDME, Quaternion APDKCFMECLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD490", Offset = "0x6FBC490", VA = "0x186FBD490")]
	public static Vector3 ACKEOCNJELD(Quaternion JKJHCABJJIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD530", Offset = "0x6FBC530", VA = "0x186FBD530")]
	public static Vector3 FJHCEDELPBJ(Quaternion JKJHCABJJIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD5D0", Offset = "0x6FBC5D0", VA = "0x186FBD5D0")]
	public static Quaternion GBLLCJIPPPF(Vector3 IKMGCHAHKMB, Vector3 LCMGGHKGECO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDCA0", Offset = "0x6FBCCA0", VA = "0x186FBDCA0")]
	public static Vector3 IKGMFKAHBIG(Vector3 CBMHNFNGOCH, Vector3 PJLKDELAHAF, Vector3 LCMGGHKGECO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE110", Offset = "0x6FBD110", VA = "0x186FBE110")]
	public static Vector3 MMBEKBCCMOJ(Vector3 ENBFOBEBDME, Vector3 LCMGGHKGECO, Quaternion JKJHCABJJIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD940", Offset = "0x6FBC940", VA = "0x186FBD940")]
	public static Quaternion GGDFAIMKFFL(Quaternion APDKCFMECLC, Vector3 IKMGCHAHKMB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE540", Offset = "0x6FBD540", VA = "0x186FBE540")]
	public static bool PKIAFPPHCAD(Vector3 NCOAMNIMLBL, Vector3 OGAPIMHMHHG, [Out] Vector3 JMKLKMFGJMB, bool AGFACDNCBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD650", Offset = "0x6FBC650", VA = "0x186FBD650")]
	public static Vector3 GFCALCJEPAL(bool LIMDHFDJMHF, [Optional] Quaternion APECGCFJNGO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JIGGBHLJOJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float3 BFENJPJIDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public float3x3 ILMJFGHLIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public float FFDPGNIGBDB;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CENOEKKBPMN
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int HJCAHALKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BCFBLPIKAGK(int GGBBONMHPBA);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion OKNKHLDCJKM(int GGBBONMHPBA);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float DOEGOFDLNBE(int GGBBONMHPBA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface JEMPNBCGPMN : PAPMJFGIOOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool BPBCPOGGDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool OKOBGLOFCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	float OGNBOAJPDAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int FDLGOLLNOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool BENNLGNDAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int CNMPLKDLJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<JIGGBHLJOJK> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BNIKHDAFNNC : PAPMJFGIOOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IJLMADBEADJ KHMCKHLFLIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool KAGNAMOAFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float3 PIOKBGDOGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface NDBPAKEIKHH
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	LBKJBKIAMOO JAFJFBMIFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	NKFNEIOPDJI CCDMCJGAIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PAPMJFGIOOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool IILFCIEOECB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool EGIKGBNILFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	LBKJBKIAMOO JAFJFBMIFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	UniformTRS BCMGHJKLCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float HINBNGILIKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 AJFNDBDIEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	NPNHMPJJEOO IIKNNNIPLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	OLBGPBMGBBB DIECPPJDDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DNHEJINNFOF
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int DJEKDOKKGLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Transform NIJADCPEDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool AEACGJHBEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDPGIPNIFJI GetBone(int GGBBONMHPBA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int GGBBONMHPBA);
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
