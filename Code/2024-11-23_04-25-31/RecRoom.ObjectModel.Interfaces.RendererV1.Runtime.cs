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
public enum MPLMMDENOEO
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
public enum FFJCINHIICI
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
public enum BHMPMJEBGAJ
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
public enum LJFFPKIAAIL
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
public enum EBLHPNHPCDN
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
public enum JKHIHEHMHKN
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
public static class PDFEOBICEMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F29670", Offset = "0x6F28070", VA = "0x186F29670")]
	public static bool AKGIOLEINFF(this JKHIHEHMHKN AKDANOPEPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F29690", Offset = "0x6F28090", VA = "0x186F29690")]
	public static bool GNOEJFBOBEA(this JKHIHEHMHKN AKDANOPEPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F296A0", Offset = "0x6F280A0", VA = "0x186F296A0")]
	public static bool IPMPNKGOFMK(this JKHIHEHMHKN AKDANOPEPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum AJGLBKGCGHL
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
public struct FCPANGHFKNK : PMIBHODOOIG, IEquatable<FCPANGHFKNK>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int BPKEJBPHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC9FF70", Offset = "0xC9E970", VA = "0x180C9FF70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int PCBHJHCPNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x286D5C0", Offset = "0x286BFC0", VA = "0x18286D5C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x617B8C0", Offset = "0x617A2C0", VA = "0x18617B8C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MCOKBKCIBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FD20", Offset = "0x6F1E720", VA = "0x186F1FD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2184870", Offset = "0x2183270", VA = "0x182184870", Slot = "8")]
	public bool Equals(FCPANGHFKNK GDOGPMPJPOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x307A280", Offset = "0x3078C80", VA = "0x18307A280")]
	public static bool EKIKFCPHGPG(FCPANGHFKNK PEMPEACEHBG, FCPANGHFKNK FDDPOELCNDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FD60", Offset = "0x6F1E760", VA = "0x186F1FD60", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FDF0", Offset = "0x6F1E7F0", VA = "0x186F1FDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IHNAJDHMCNF : PMIBHODOOIG, IEquatable<IHNAJDHMCNF>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BPKEJBPHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC9FF70", Offset = "0xC9E970", VA = "0x180C9FF70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int PCBHJHCPNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x286D5C0", Offset = "0x286BFC0", VA = "0x18286D5C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x617B8C0", Offset = "0x617A2C0", VA = "0x18617B8C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MCOKBKCIBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F24320", Offset = "0x6F22D20", VA = "0x186F24320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2184870", Offset = "0x2183270", VA = "0x182184870", Slot = "8")]
	public bool Equals(IHNAJDHMCNF GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F24360", Offset = "0x6F22D60", VA = "0x186F24360", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F243F0", Offset = "0x6F22DF0", VA = "0x186F243F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IGEHCIPOMMD : PMIBHODOOIG, IEquatable<IGEHCIPOMMD>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BPKEJBPHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC9FF70", Offset = "0xC9E970", VA = "0x180C9FF70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PCBHJHCPNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x286D5C0", Offset = "0x286BFC0", VA = "0x18286D5C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x617B8C0", Offset = "0x617A2C0", VA = "0x18617B8C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MCOKBKCIBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F24250", Offset = "0x6F22C50", VA = "0x186F24250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2184870", Offset = "0x2183270", VA = "0x182184870", Slot = "8")]
	public bool Equals(IGEHCIPOMMD GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F24290", Offset = "0x6F22C90", VA = "0x186F24290", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EKJOIMJKNJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADLMNADEKMB(FCPANGHFKNK ELFANOAFHKM, FFJCINHIICI DBMKAIFBMAO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADLMNADEKMB(IHNAJDHMCNF LDNKIGHNFBK, FFJCINHIICI DBMKAIFBMAO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMDCBJBGKLD(IHNAJDHMCNF LDNKIGHNFBK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPJGFPLEDGL(IHNAJDHMCNF LDNKIGHNFBK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFAHPEKEMNA();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKIAGOCIFFF(FFJCINHIICI BKKHBFLPOHJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BMKNMJICELE(FCPANGHFKNK ELFANOAFHKM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BMKNMJICELE(IHNAJDHMCNF LDNKIGHNFBK);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GFDNFPMMFOH(IHNAJDHMCNF LDNKIGHNFBK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBEDHDHDANK(IHNAJDHMCNF LDNKIGHNFBK);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void COGABANCGBK();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AADBPGMINLC();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KMEPCBABPHG(FCPANGHFKNK ELFANOAFHKM, EBLHPNHPCDN BKKHBFLPOHJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DBLEAIOPFOH(IHNAJDHMCNF LDNKIGHNFBK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BPPNPNIECHK(IHNAJDHMCNF LDNKIGHNFBK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HEIDJFHJGEJ();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CADLKJIHCLP(EBLHPNHPCDN BKKHBFLPOHJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FPGKPBNIHEL(FCPANGHFKNK ELFANOAFHKM, Vector3 HJAFMJBMJIG, Vector3 CLCBGLBFGEB, Vector3 ILPIBIEHDPL, float EFCBFDCHJEH, float JFMFBLKAOPH, IReadOnlyList<Camera> NOIBENIIIFK, MPLMMDENOEO AIGEHILOBEC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FPGKPBNIHEL(IGEHCIPOMMD GOJMPHJGKHN, Vector3 HJAFMJBMJIG, Vector3 CLCBGLBFGEB, Vector3 ILPIBIEHDPL, float EFCBFDCHJEH, float JFMFBLKAOPH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ECLOEEPLPLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool DIPBJEJNNBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FCPANGHFKNK MCFEMGCBKHD(KAKPHEFMJLI GGEMPJLCHFC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCPANGHFKNK MCFEMGCBKHD(KAKPHEFMJLI GGEMPJLCHFC, bool CCDEMFEAKPB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICCFKDGBMBF(FCPANGHFKNK ELFANOAFHKM);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IELMDOLOJPK(FCPANGHFKNK ELFANOAFHKM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IHNAJDHMCNF FFOKHBLFOBO(FCPANGHFKNK ELFANOAFHKM, ENGPPEFOKOD GGEMPJLCHFC);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IHNAJDHMCNF GILFMPHNGJJ(FCPANGHFKNK ELFANOAFHKM, BBDCBAJEODB GGEMPJLCHFC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MNAAOFKGLGD(IHNAJDHMCNF LDNKIGHNFBK);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EGMFHGKHFOK(IHNAJDHMCNF LDNKIGHNFBK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IGEHCIPOMMD CBPDAMKKMME(KOBNNPMDHML GGEMPJLCHFC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KCCAJLBNCKC(IGEHCIPOMMD GOJMPHJGKHN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HIMJLJJEEFG(IGEHCIPOMMD GOJMPHJGKHN);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task FBLOPJJNICD();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task LALGNCLKLII();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EDAJEHODNGN();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OMNMHGMONMN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> ALDKGIGJIJJ(FCPANGHFKNK ELFANOAFHKM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JDJDEKJLEDM
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum BMDFNDLNAAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum OFNBPCKOPJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		TriangleColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum NNBGJPGPAIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum BINGEEMHJDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum GDAOBLELNKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum CHGPDAOHMBD
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		GameConfigSetting,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		FullDetail,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Imperceptible,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		PC_High,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		PC_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		PC_Low,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		MajorStress,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		OutOfMemory,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		Mobile_High,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Mobile_Mid,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Mobile_Low,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		PS4,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Switch1,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Quest2,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Quest3,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		MemoryBuild,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		PS4VR,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long LNBPBFAHDHM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static bool BAHOPGELMGE;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static long HENHFGILBNO;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static int NLFFMMMHCGI;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static long JCPDGAILDBN;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static long MEJPMMBMANB;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static int FMMKCNMLJBG;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static bool BAHNEJKNLMF;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long JMLKLBEMONG;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static int LPMAFBEDJLE;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static int EOJHLKPCLNB;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static long GDIOONODANO;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static long IODGBNLAFED;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static int FMOMIJLAFIC;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static int LGLDPCODLNO;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static int MEKPJDHJOBC;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int BNOHKBFLIJF;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int FNPNFPKAOCK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static int[] ADPBDMIEANG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static int DODIEEMKCNK;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static long FLLMJELPNIF;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static long HEJDEGMFFBC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static int MBADBLAKIMO;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long CAGOCFENDFG;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long CCHCNCDLHEA;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static long DBJGGKHEEAC;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static long AJDHKIHDHLH;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static long MIHOEHFLDEF;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static long KFJINPBAPIG;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static long IPMGFHDPGCK;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long KGIKJFKCKLL;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static long MIAOHBKOFFD;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static float CIPKMMMALBE;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static long AHEIBJFJOGE;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static long FHHFICOPJOH;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static long AAIFBBKIIDB;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static float DIPGHFABHCJ;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static long CLPPCPDJPEI;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static long MPMDLDLAGNB;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static long CAELEBCFDCD;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static long POHKIJMGFNG;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static long EKIOHLIBMJD;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static long KDCOCFLCNGJ;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static long IFHMAPKHPHI;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long AJIAEKGNNOB;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static long IOMBFNFGJLP;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static long FPKLPCODCCA;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static long KIDHMKFKAOF;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long ANNOECOCCJG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool LADFFIKOAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F25DA0", Offset = "0x6F247A0", VA = "0x186F25DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6F27200", Offset = "0x6F25C00", VA = "0x186F27200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static CHGPDAOHMBD CIGLDFAOILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F25F60", Offset = "0x6F24960", VA = "0x186F25F60")]
		[CompilerGenerated]
		get
		{
			return default(CHGPDAOHMBD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F266C0", Offset = "0x6F250C0", VA = "0x186F266C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool BAPFIBHIFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F28C40", Offset = "0x6F27640", VA = "0x186F28C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F26E40", Offset = "0x6F25840", VA = "0x186F26E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static bool BAHJDMMMODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6F25E40", Offset = "0x6F24840", VA = "0x186F25E40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6F259C0", Offset = "0x6F243C0", VA = "0x186F259C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static float EIPBNGFGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6F28730", Offset = "0x6F27130", VA = "0x186F28730")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F27310", Offset = "0x6F25D10", VA = "0x186F27310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static float BKPKNBONGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F25970", Offset = "0x6F24370", VA = "0x186F25970")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F28DE0", Offset = "0x6F277E0", VA = "0x186F28DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static int KHDABBOFDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F25DF0", Offset = "0x6F247F0", VA = "0x186F25DF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F26EF0", Offset = "0x6F258F0", VA = "0x186F26EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static GDAOBLELNKA KFDOOMKKOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6F26320", Offset = "0x6F24D20", VA = "0x186F26320")]
		[CompilerGenerated]
		get
		{
			return default(GDAOBLELNKA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F268C0", Offset = "0x6F252C0", VA = "0x186F268C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long GEAADIPHLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F26AB0", Offset = "0x6F254B0", VA = "0x186F26AB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6F25910", Offset = "0x6F24310", VA = "0x186F25910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static float GMOHAJHNKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F26120", Offset = "0x6F24B20", VA = "0x186F26120")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6F273D0", Offset = "0x6F25DD0", VA = "0x186F273D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static int ONGMOCDOEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6F270F0", Offset = "0x6F25AF0", VA = "0x186F270F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6F258C0", Offset = "0x6F242C0", VA = "0x186F258C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static int JOOFBMFNNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F288D0", Offset = "0x6F272D0", VA = "0x186F288D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F28780", Offset = "0x6F27180", VA = "0x186F28780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static int ONKEAFALEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6F28B40", Offset = "0x6F27540", VA = "0x186F28B40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6F275F0", Offset = "0x6F25FF0", VA = "0x186F275F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static int CMFFKGFNJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6F257C0", Offset = "0x6F241C0", VA = "0x186F257C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F25BF0", Offset = "0x6F245F0", VA = "0x186F25BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static int KFGAIDNILJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6F27550", Offset = "0x6F25F50", VA = "0x186F27550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6F26910", Offset = "0x6F25310", VA = "0x186F26910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static bool HOAENEDEKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6F275A0", Offset = "0x6F25FA0", VA = "0x186F275A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static int OKDCINKMAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F28500", Offset = "0x6F26F00", VA = "0x186F28500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F25610", Offset = "0x6F24010", VA = "0x186F25610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static int FPHNDFHNHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F244D0", Offset = "0x6F22ED0", VA = "0x186F244D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6F26530", Offset = "0x6F24F30", VA = "0x186F26530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static int JBCJIHBNEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6F28B90", Offset = "0x6F27590", VA = "0x186F28B90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F26FF0", Offset = "0x6F259F0", VA = "0x186F26FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static bool JFMEDFOOAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F26580", Offset = "0x6F24F80", VA = "0x186F26580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F28820", Offset = "0x6F27220", VA = "0x186F28820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static float BJEHGAAKLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F28880", Offset = "0x6F27280", VA = "0x186F28880")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F26000", Offset = "0x6F24A00", VA = "0x186F26000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool GDBDLANGLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F255C0", Offset = "0x6F23FC0", VA = "0x186F255C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F27250", Offset = "0x6F25C50", VA = "0x186F27250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static bool LINBODCIPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F26620", Offset = "0x6F25020", VA = "0x186F26620")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F26710", Offset = "0x6F25110", VA = "0x186F26710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static BMDFNDLNAAN BHENOIEIDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F25C40", Offset = "0x6F24640", VA = "0x186F25C40")]
		[CompilerGenerated]
		get
		{
			return default(BMDFNDLNAAN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F28CE0", Offset = "0x6F276E0", VA = "0x186F28CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static bool OGLKGAPFMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F25FB0", Offset = "0x6F249B0", VA = "0x186F25FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F28670", Offset = "0x6F27070", VA = "0x186F28670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static bool CGNHNPPMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F28A40", Offset = "0x6F27440", VA = "0x186F28A40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F25660", Offset = "0x6F24060", VA = "0x186F25660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static bool KLPBHNAEIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F28D40", Offset = "0x6F27740", VA = "0x186F28D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F27490", Offset = "0x6F25E90", VA = "0x186F27490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static int PHFEEMFBIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F26A10", Offset = "0x6F25410", VA = "0x186F26A10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F26CE0", Offset = "0x6F256E0", VA = "0x186F26CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static int CNKKNEGADGO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F26B00", Offset = "0x6F25500", VA = "0x186F26B00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F286D0", Offset = "0x6F270D0", VA = "0x186F286D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static int MEOJLNFEMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F26F40", Offset = "0x6F25940", VA = "0x186F26F40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F26C80", Offset = "0x6F25680", VA = "0x186F26C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static int MFJJGHJFMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F287D0", Offset = "0x6F271D0", VA = "0x186F287D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F26210", Offset = "0x6F24C10", VA = "0x186F26210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static int HNNDNFHLIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F27640", Offset = "0x6F26040", VA = "0x186F27640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F260C0", Offset = "0x6F24AC0", VA = "0x186F260C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static int OAMCLMMGECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F284B0", Offset = "0x6F26EB0", VA = "0x186F284B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F26960", Offset = "0x6F25360", VA = "0x186F26960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static int NKDHMEGIGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F28AF0", Offset = "0x6F274F0", VA = "0x186F28AF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F27140", Offset = "0x6F25B40", VA = "0x186F27140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static int EOCJOBJBHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F25810", Offset = "0x6F24210", VA = "0x186F25810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F27430", Offset = "0x6F25E30", VA = "0x186F27430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static float FECNNJHAKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F28D90", Offset = "0x6F27790", VA = "0x186F28D90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F25760", Offset = "0x6F24160", VA = "0x186F25760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static float FIAAJLFIJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F26170", Offset = "0x6F24B70", VA = "0x186F26170")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F27040", Offset = "0x6F25A40", VA = "0x186F27040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static float EMACJADBLMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F25AD0", Offset = "0x6F244D0", VA = "0x186F25AD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F271A0", Offset = "0x6F25BA0", VA = "0x186F271A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static int GCBOBEGDEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F276E0", Offset = "0x6F260E0", VA = "0x186F276E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F262C0", Offset = "0x6F24CC0", VA = "0x186F262C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static int JGMMBHCDMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F26270", Offset = "0x6F24C70", VA = "0x186F26270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F28980", Offset = "0x6F27380", VA = "0x186F28980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static int ALLBNINDIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F28C90", Offset = "0x6F27690", VA = "0x186F28C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F272B0", Offset = "0x6F25CB0", VA = "0x186F272B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static int CFDJHGAODBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F270A0", Offset = "0x6F25AA0", VA = "0x186F270A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F24520", Offset = "0x6F22F20", VA = "0x186F24520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static bool HIKJKIDHLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F264E0", Offset = "0x6F24EE0", VA = "0x186F264E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F26060", Offset = "0x6F24A60", VA = "0x186F26060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static OFNBPCKOPJM PEFKPPPEDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F267C0", Offset = "0x6F251C0", VA = "0x186F267C0")]
		[CompilerGenerated]
		get
		{
			return default(OFNBPCKOPJM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F26860", Offset = "0x6F25260", VA = "0x186F26860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static NNBGJPGPAIE JONEFDBGCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6F269C0", Offset = "0x6F253C0", VA = "0x186F269C0")]
		[CompilerGenerated]
		get
		{
			return default(NNBGJPGPAIE);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F26C20", Offset = "0x6F25620", VA = "0x186F26C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool OENJCLFHNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F25D50", Offset = "0x6F24750", VA = "0x186F25D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F25A70", Offset = "0x6F24470", VA = "0x186F25A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static float ADKOPCCBOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6F256C0", Offset = "0x6F240C0", VA = "0x186F256C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6F27370", Offset = "0x6F25D70", VA = "0x186F27370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static float PNNOJGJPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F26EA0", Offset = "0x6F258A0", VA = "0x186F26EA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F289E0", Offset = "0x6F273E0", VA = "0x186F289E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static float BOJDNFKIIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F25570", Offset = "0x6F23F70", VA = "0x186F25570")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F26370", Offset = "0x6F24D70", VA = "0x186F26370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static float OHAFIDPBPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F25A20", Offset = "0x6F24420", VA = "0x186F25A20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F28BE0", Offset = "0x6F275E0", VA = "0x186F28BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static float NKPJGILACHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F26A60", Offset = "0x6F25460", VA = "0x186F26A60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F25860", Offset = "0x6F24260", VA = "0x186F25860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static float HAJONFJAGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F25710", Offset = "0x6F24110", VA = "0x186F25710")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F25C90", Offset = "0x6F24690", VA = "0x186F25C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static bool OJPCNAAKDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F265D0", Offset = "0x6F24FD0", VA = "0x186F265D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F26F90", Offset = "0x6F25990", VA = "0x186F26F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static float KLOINFDLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F26810", Offset = "0x6F25210", VA = "0x186F26810")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F26480", Offset = "0x6F24E80", VA = "0x186F26480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static float PIDHOJPOFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F25F10", Offset = "0x6F24910", VA = "0x186F25F10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F28550", Offset = "0x6F26F50", VA = "0x186F28550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static float APMKKEIEGON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F26770", Offset = "0x6F25170", VA = "0x186F26770")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F28610", Offset = "0x6F27010", VA = "0x186F28610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static int ENCKNCLEFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F26D40", Offset = "0x6F25740", VA = "0x186F26D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F26B50", Offset = "0x6F25550", VA = "0x186F26B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static float ILOHIGHOHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F26670", Offset = "0x6F25070", VA = "0x186F26670")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static bool HFJEBEPBNFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F261C0", Offset = "0x6F24BC0", VA = "0x186F261C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F26D90", Offset = "0x6F25790", VA = "0x186F26D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static int DFCANOAIFIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F26430", Offset = "0x6F24E30", VA = "0x186F26430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F285B0", Offset = "0x6F26FB0", VA = "0x186F285B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static float KFOOHFAOLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F27690", Offset = "0x6F26090", VA = "0x186F27690")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F25CF0", Offset = "0x6F246F0", VA = "0x186F25CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static float AFFPKGGNMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F24480", Offset = "0x6F22E80", VA = "0x186F24480")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F28920", Offset = "0x6F27320", VA = "0x186F28920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static float4x4 HCEDGNDBMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F25B20", Offset = "0x6F24520", VA = "0x186F25B20")]
		[CompilerGenerated]
		get
		{
			return default(float4x4);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F25E90", Offset = "0x6F24890", VA = "0x186F25E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public static float3 LHPJKPCHKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F26BB0", Offset = "0x6F255B0", VA = "0x186F26BB0")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F274F0", Offset = "0x6F25EF0", VA = "0x186F274F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public static bool FMIHIEDKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F25BA0", Offset = "0x6F245A0", VA = "0x186F25BA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F263D0", Offset = "0x6F24DD0", VA = "0x186F263D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public static BINGEEMHJDK ONIJCOAIJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F26DF0", Offset = "0x6F257F0", VA = "0x186F26DF0")]
		[CompilerGenerated]
		get
		{
			return default(BINGEEMHJDK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F28A90", Offset = "0x6F27490", VA = "0x186F28A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F24580", Offset = "0x6F22F80", VA = "0x186F24580")]
	public static void AIFAFKAOAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F27730", Offset = "0x6F26130", VA = "0x186F27730")]
	public static void MOFLIHHEFAA(CHGPDAOHMBD OBJCMDEBCML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FOPNBLAKDNM
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct HOKCEAMBEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Vector3 CNDDIEKMION;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Quaternion EAGIADDGNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public float BMOOOPPEKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Quaternion IIPJCDBHLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public float DNEIEDNKKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public float FBEJEEGDMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public float EPHHNKDGICA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static List<HOKCEAMBEPP> FJCHKKFEIDI;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F221C0", Offset = "0x6F20BC0", VA = "0x186F221C0")]
	public static NativeList<GAJGCAGDBEH> BKPEJNBBOAP(CLCMJJDMDMJ NMAECNIBAJC)
	{
		return default(NativeList<GAJGCAGDBEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FE80", Offset = "0x6F1E880", VA = "0x186F1FE80")]
	private static bool AHOILDGJHAE(int FNLONGIJDLD, NativeList<GAJGCAGDBEH> KIBAOEBFCJF, List<HOKCEAMBEPP> HCBHOHCHHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F22D40", Offset = "0x6F21740", VA = "0x186F22D40")]
	private static GAJGCAGDBEH OPJCGNPLBPF(int DLAFBLPELJG, List<HOKCEAMBEPP> HCBHOHCHHMC)
	{
		return default(GAJGCAGDBEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F22850", Offset = "0x6F21250", VA = "0x186F22850")]
	private static GAJGCAGDBEH MMHDAPNJHEA(int DLAFBLPELJG, List<HOKCEAMBEPP> HCBHOHCHHMC)
	{
		return default(GAJGCAGDBEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F22770", Offset = "0x6F21170", VA = "0x186F22770")]
	private static GAJGCAGDBEH MFIJGCBGKID(Vector3 BODEELBOMLJ, Quaternion LLGOJPDGOGO, float JNPCONGOFCD)
	{
		return default(GAJGCAGDBEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F20D10", Offset = "0x6F1F710", VA = "0x186F20D10")]
	public static NativeList<GAJGCAGDBEH> BHCMHMNNFFE(CLCMJJDMDMJ NMAECNIBAJC, float AKDENJIMFDH)
	{
		return default(NativeList<GAJGCAGDBEH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HEKNIGBBOAE
{
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static Vector3 EMFCKGJMHIN;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public static Vector3 MCDBKMCOABA;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public static readonly float BFNLGDJABMJ;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F23F00", Offset = "0x6F22900", VA = "0x186F23F00")]
	public static Vector3 PJPIKJCCPOJ(Vector3 JMDOFPABNKA, Quaternion LLGOJPDGOGO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F23890", Offset = "0x6F22290", VA = "0x186F23890")]
	public static Vector3 MHLODEEEDGB(Quaternion MHLCHCEFDAI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F22F50", Offset = "0x6F21950", VA = "0x186F22F50")]
	public static Vector3 BBEOPDPHFHM(Quaternion MHLCHCEFDAI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F23930", Offset = "0x6F22330", VA = "0x186F23930")]
	public static Quaternion NFJPFFGKLIL(Vector3 GPCBHKJPHLL, Vector3 LIGJJEDBJEP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F239B0", Offset = "0x6F223B0", VA = "0x186F239B0")]
	public static Vector3 OLLEBHNFAHF(Vector3 NDDLBBDLBNE, Vector3 NODEOPILPKJ, Vector3 LIGJJEDBJEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F23460", Offset = "0x6F21E60", VA = "0x186F23460")]
	public static Vector3 JEOJCMCOPGC(Vector3 JMDOFPABNKA, Vector3 LIGJJEDBJEP, Quaternion MHLCHCEFDAI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F23BA0", Offset = "0x6F225A0", VA = "0x186F23BA0")]
	public static Quaternion PIOCFCLGCGP(Quaternion LLGOJPDGOGO, Vector3 GPCBHKJPHLL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F22FF0", Offset = "0x6F219F0", VA = "0x186F22FF0")]
	public static bool BPFJEKONNAO(Vector3 PONMBIDHPAE, Vector3 LEECPEDGONI, [Out] Vector3 GNJMDOCGFJD, bool KJFFKGOEBDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F23170", Offset = "0x6F21B70", VA = "0x186F23170")]
	public static Vector3 CFIJFNOLCHA(bool MHJIEIPAIIL, [Optional] Quaternion PDOKCDCDJGE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GAJGCAGDBEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public float3 CNDDIEKMION;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public float3x3 EAGIADDGNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public float BMOOOPPEKEE;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CLCMJJDMDMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int EGLEBMMCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 OLMPMJPIDEG(int DLAFBLPELJG);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion HHCAOJJDPDA(int DLAFBLPELJG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float HBOPEIFBIBA(int DLAFBLPELJG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BBDCBAJEODB : KKDPGMEOOMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool AHBHEPAGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool LJKFLGJPHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float CDGCEGNEJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	int HJBLKNOMPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool GBKAPLNBKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	int JPEMPBPCNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<GAJGCAGDBEH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface ENGPPEFOKOD : KKDPGMEOOMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	BHMPMJEBGAJ IIGHEKDCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool DKEEAEPKABD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 IKMOPIBCCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KAKPHEFMJLI
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	EFEILIAEILL DNOKGDKBFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	LJFFPKIAAIL PJNCJKPNBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KKDPGMEOOMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool EBPONCAGDDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool OAAKNPNHMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	EFEILIAEILL DNOKGDKBFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	UniformTRS DDNMFHDLGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float AKMJCHJMAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	Vector3 GKIGOBBGJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	JKHIHEHMHKN CLCHCNOEPPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	AJGLBKGCGHL IPLBOOANCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KOBNNPMDHML
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int MMFEFHIPJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform OEHEFNIBPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool NLJJEOKGCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCPANGHFKNK GetBone(int DLAFBLPELJG);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int DLAFBLPELJG);
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
