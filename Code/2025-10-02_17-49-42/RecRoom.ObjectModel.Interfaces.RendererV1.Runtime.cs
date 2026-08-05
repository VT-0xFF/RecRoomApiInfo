using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation.Mathematics;
using RecRoom.RendererV1.Terrain;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ELJEIINLLPG
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
public enum KBICEEBHCID
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
public enum FNINIENCAIO
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
public enum MELJJFJMJGA
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
public enum IKEGDKKKDKI
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
public enum FIHNPCHPOKM
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
public static class LLBAMLAHPMF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x86C65A0", Offset = "0x86C4FA0", VA = "0x1886C65A0")]
	public static bool KJKJFLIGPLN(this FIHNPCHPOKM GKNNJOIGPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x86C65C0", Offset = "0x86C4FC0", VA = "0x1886C65C0")]
	public static bool OBCAICFACGN(this FIHNPCHPOKM GKNNJOIGPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x86C6570", Offset = "0x86C4F70", VA = "0x1886C6570")]
	public static bool KGKCHGBBCBB(this FIHNPCHPOKM GKNNJOIGPFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MFJKGLKLLDL
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
public struct CFEOEFPPCFO : BJILBADDCFN, IEquatable<CFEOEFPPCFO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A3C90", VA = "0x1830A5290", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x30A52A0", Offset = "0x30A3CA0", VA = "0x1830A52A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OEBGFPNJFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86C2F80", Offset = "0x86C1980", VA = "0x1886C2F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x143A040", Offset = "0x1438A40", VA = "0x18143A040", Slot = "8")]
	public bool Equals(CFEOEFPPCFO GOCNHGEHNFD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F67EF0", Offset = "0x3F668F0", VA = "0x183F67EF0")]
	public static bool NOPNAEDOCOI(CFEOEFPPCFO EICJFDNFOCB, CFEOEFPPCFO MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86C2EF0", Offset = "0x86C18F0", VA = "0x1886C2EF0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x86C2FC0", Offset = "0x86C19C0", VA = "0x1886C2FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct CJHDFOMFPMP : BJILBADDCFN, IEquatable<CJHDFOMFPMP>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A3C90", VA = "0x1830A5290", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x30A52A0", Offset = "0x30A3CA0", VA = "0x1830A52A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OEBGFPNJFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86C30E0", Offset = "0x86C1AE0", VA = "0x1886C30E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x143A040", Offset = "0x1438A40", VA = "0x18143A040", Slot = "8")]
	public bool Equals(CJHDFOMFPMP GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86C3050", Offset = "0x86C1A50", VA = "0x1886C3050", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86C3120", Offset = "0x86C1B20", VA = "0x1886C3120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct APGNDEGCDDB : BJILBADDCFN, IEquatable<APGNDEGCDDB>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A3C90", VA = "0x1830A5290", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x30A52A0", Offset = "0x30A3CA0", VA = "0x1830A52A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OEBGFPNJFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86C2EB0", Offset = "0x86C18B0", VA = "0x1886C2EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x143A040", Offset = "0x1438A40", VA = "0x18143A040", Slot = "8")]
	public bool Equals(APGNDEGCDDB GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86C2E20", Offset = "0x86C1820", VA = "0x1886C2E20", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ONEMHINNGHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMGFLNNAMCN(CFEOEFPPCFO FAIGKPPBFHA, KBICEEBHCID NNFDIFDOFPE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMGFLNNAMCN(CJHDFOMFPMP ENDDNPPKCPO, KBICEEBHCID NNFDIFDOFPE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJAEIDOPADB(CJHDFOMFPMP ENDDNPPKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIEEOPPOCBO(CJHDFOMFPMP ENDDNPPKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BALDCMFLBMA();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNJPCIHFNKB(KBICEEBHCID DGNODDPLLPC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MAEJMJMEIND(CFEOEFPPCFO FAIGKPPBFHA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MAEJMJMEIND(CJHDFOMFPMP ENDDNPPKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IEGHLFNFLED(CJHDFOMFPMP ENDDNPPKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DBPFPHGHGAF(CJHDFOMFPMP ENDDNPPKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HCLCGLGOAGH();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MBLMHOGMAKG();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BKIDOPCBAMN(CFEOEFPPCFO FAIGKPPBFHA, IKEGDKKKDKI DGNODDPLLPC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BBDLBOCHEMM(CJHDFOMFPMP ENDDNPPKCPO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KFJPCMENGOA(CJHDFOMFPMP ENDDNPPKCPO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BIKLPKEHGKD();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JKINODOBCKK(IKEGDKKKDKI DGNODDPLLPC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AACIELIEBNA(CFEOEFPPCFO FAIGKPPBFHA, Vector3 CMMPHLCGHGJ, Vector3 CPMDBFEDMBI, Vector3 ACCEIAEFMLC, float EPGMBNKMDHC, float LEJEMPEJOJG, IReadOnlyList<Camera> GMMFFGBHFFI, ELJEIINLLPG EPGEKJPNEHG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AACIELIEBNA(APGNDEGCDDB HNLKOBGPMLG, Vector3 CMMPHLCGHGJ, Vector3 CPMDBFEDMBI, Vector3 ACCEIAEFMLC, float EPGMBNKMDHC, float LEJEMPEJOJG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JOGKHOGLCCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LFMJKHOAEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFEOEFPPCFO EMEBMMFNIBC(DDAHMJKENKG BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFEOEFPPCFO EMEBMMFNIBC(DDAHMJKENKG BLPDDGCLNPE, bool NGLFDBKGFPM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AINJNCHCMLC(CFEOEFPPCFO FAIGKPPBFHA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PCIDKBNDJDA(CFEOEFPPCFO FAIGKPPBFHA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CJHDFOMFPMP BMIPOKOFEKC(CFEOEFPPCFO FAIGKPPBFHA, GIJGHJAGFLM BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CJHDFOMFPMP OEMEAONJDGE(CFEOEFPPCFO FAIGKPPBFHA, LJNNCBOFJHI BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBJIADNIOMJ(CJHDFOMFPMP ENDDNPPKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OBLGNLPLHNH(CJHDFOMFPMP ENDDNPPKCPO);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	APGNDEGCDDB AKNHHBNCKCI(KLMHLMDLEBF BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KNFFJNPKIPF(APGNDEGCDDB HNLKOBGPMLG);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HIDAABKAKPB(APGNDEGCDDB HNLKOBGPMLG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DEEHCAMBIMN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task AONLINMMHDE();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task LGADFEHDDIO();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GCLEPGMNIHB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> LOBBMGBPELP(CFEOEFPPCFO FAIGKPPBFHA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NCGJEENFMEF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum AGMJBDGPLOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Distance,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		DistanceAttributes,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		DistanceAttributesArea
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum CNDNJEMFIKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		AllNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		NaughtyAndNice,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		AllNice
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum IOCFDFFLGHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		ShowNoLods,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		ActualError,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		LodColour,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		VertexFormatColour,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		ContainerColour,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		MaterialColour,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		MeshColour,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		BatchColour,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		TriangleColour,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		RefreshShapesBatchColour,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		RefreshBatchedMeshColour
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum LPKJONFCEMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Disable_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Disable_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Disable_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Disable_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Disable_PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Force_FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Force_NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Force_NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Force_NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Force_NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Force_PosFixedPoint16NormTanOct8MatUi
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum OGIHJIDMGPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		StartOfLevelPlay,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		LoadingStarted,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		LoadingShapesFinished,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		ShapeMeshesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		RunningGame
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum MIGBKJAIJPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		TriCount,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		FixedError,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		FixedBudget,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		CheckAtRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		CheckPassive,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		CheckOften,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		SimulatedLimit
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum DGAAAKNFAMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		Sqrt
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum OIFJOAMMOIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		GameConfigSetting = 0,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Off = 1,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		FullDetail = 2,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Imperceptible = 3,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		PC_High = 4,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		PC_Mid = 5,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		PC_Low = 6,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		MajorStress = 7,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		OutOfMemory = 8,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Mobile_High = 9,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Mobile_Mid = 10,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		Mobile_Low = 11,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		PS4 = 12,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		PS5 = 13,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		XboxOne = 14,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		XboxSeries = 15,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Switch1 = 16,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		Quest2 = 17,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		Quest3 = 18,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		MemoryBuild = 19,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		PS4VR = 20,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		FourRoomsDemo = 100,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		JustAvatarMeshLod = 101,
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		LowQualityHighSpeed = 102,
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		SpreadsheetSettings = 103
	}

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static bool FOHEEGPJOPP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static long PDCJPKHBIMO;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static bool BMCKMIDGJLE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static bool GCMHANFELME;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public static bool GDLOLIMAFMI;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static float COHBLEJPIGF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static float MNKAKLDKKCI;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public static int DMPNCPIMPJB;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public static MIGBKJAIJPN LBNMCFFCHDA;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public static long HOKLPDIEFEM;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static float JJHPABNIMNL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static int DBMEIBBFLGP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static int DKNHGNGJBNN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static int IEGPCDJKDIN;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static int HODKKJKOLPN;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static int EADBDNNDINF;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static int KONGCCBAABO;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static int DBKHOCIEEGL;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static int KHAPJNHMHKE;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static bool AHOFDHCDHAN;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static int HCBFAMMFIKF;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static int OMHJFFILNMJ;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static int BFNKKIFEJED;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static bool LDLFGEPBPFK;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static float BCICBKFLOPJ;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static bool OPFBIACOKNP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static float BGMGHFFHIGO;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static long FFLPFNKLPMN;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static bool FEMLHGHIJCO;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static long FKBMCJKIKFA;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static int NIPJDAMBHME;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static bool ILKPIBIFAKF;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static AGMJBDGPLOF ONCDDIHPGLM;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static bool DDKMGNLGJDF;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static bool KEBIJJCADOL;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static int BPAFNMGBION;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static int ELEIHPDIOPO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static int ICNDPFDDLKK;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static int PEMFMJLKDGM;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static int BNLLLJNAMFH;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public static int KPPLIBMEPLK;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static int GGEMGAEOFMC;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static int FGACDGBMKIL;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static float PAENIOOAGJC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static float HJCEDJGEJJB;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static float FLLKPEBHKJE;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static float LJEEFIKFJEF;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static int AECJEMAEFON;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static int ILHKPBLAJNL;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static int CLKBABHBPLH;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static int NBJMGPMPKHG;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public static bool KNAOIOLGGHB;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static IOCFDFFLGHA EBALCGJEMOO;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static LPKJONFCEMA HLOCOCNBEAB;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static bool DBOFINMKLJB;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static CNDNJEMFIKN EHLNAFFFBMG;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static float CAMGIABAJOP;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static float OMFFCDKMKNG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static float GKLMIMEBCGD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static float OEBOJJDKIDD;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static float ACOAFCICPGO;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static float HNCGHHDBDBP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static float KPJAMFOHOME;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static float IGLBPJPJIAJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static bool HIFHFLIFONA;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static DGAAAKNFAMB CKEIMCCCBDH;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static bool FHIEBIPHEAG;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static float KPLBEAEPBOF;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static float FKIHNHMJEBD;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static float HCGFICBPOFF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static float FBJEMNELBFG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static float MOMOJLKFEHD;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static bool EDHEHFHBGMI;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static long DHEENJOJIKO;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static float OKFCJAKLBLG;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static float EHICMKLMPAK;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static float KLBPMKAHNOH;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static int BELJFJFMEJM;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static float CPAFAELGMHI;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static bool CKKDDJKCGGL;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static long KDFGEGFENDN;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static int FBKOKKCKBON;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static int NIEDAHGLHHE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static float AMIMEPBHJHI;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public static float IMLOGAGOJEI;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static bool IECENEMHLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static bool CBFNMHHANCN;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static float DKNFJPEBPDH;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static long CGJHPEPJMKI;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static long HKGDFLKJNCC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public static int IJOFOJJHMJC;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public static bool OJBIOBOGFAI;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static float EDNCMOMPINA;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static float AKCHLKLJCNM;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static bool BAPBBEAKJLI;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static long KJMCCLKCADD;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public static int BPKEMLFBMHF;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static float4x4 MCOHBDGEECI;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static float3 MIPIOBGIHLD;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static bool EBCIIMHGJMI;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static OGIHJIDMGPB MNIFCBBJLHG;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static long LLOEIMHHAIG;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int NLFHELFEJDO;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public static int JHMKJIFCOCP;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public static int POLPGMDDPEG;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static int POGDFIOKJIA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static int FHLHKOIPLJH;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static int LJHKDJCHCNP;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public static int JNFGFFKMDJN;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static long GNOJABGBBNL;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static int CIGKMKCMKFD;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static int GJEBICBCOGN;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static int LDMGHLKAGGM;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static long FDIHEJLCMLI;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static long FADAIJCGKCB;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static long NEOINNGAKDM;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static long CIDKBLJNECB;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static int NOGHNCBBIBL;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static int DAFEBGJDBDL;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static int FLNECKHJHKF;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static int MGHIPHFFHJK;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public static int JKHHNAAHAOO;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static int[] HCLNCMEJFLI;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static int[] GEHCCAOMCCP;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static int IPNPKKHJBGN;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static long GAKMJMCNHGO;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static long DCFHCDEJEMG;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static int HEFNLKGCHJL;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static int JOKCBIOCCHG;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static long NFFMCJBAOAB;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static long IMEFEKPAION;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static long FMAKAHGFEBB;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static long OKMGKHECNNP;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static long NOCPEBMJOCD;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public static long FKPLBJNCBHF;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static long BBLCJKJEFGB;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static long FFBJELAKOAH;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static long IHOFGDCOIFM;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static float BABNOJEHGKO;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static float JGHJBBABJHL;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public static long APLJHEIDPNM;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public static int NLEFDFJAKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static long KDCOHGFLPNK;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static long IAPEBHJMDPA;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static float PDDCPGKLJEP;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public static long CNIBLDELGEB;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static long CHOPEMNHENL;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static long LICKCGGPBHL;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static long DPOLFGPAOOH;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static long EIEKKFLPJAM;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static long BGCHDCEKJBI;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static long AMOEBEEFAFN;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static long EDEGBJKOFAJ;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static long NAJAEGCLBIE;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static long NEKGENCAKIL;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static long HDACKJGGOPO;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static long MAAGCFJOEAI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private static OIFJOAMMOIE INPHFPHFCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86C7E90", Offset = "0x86C6890", VA = "0x1886C7E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long GGHPOHPPIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86C7780", Offset = "0x86C6180", VA = "0x1886C7780")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86C77E0", Offset = "0x86C61E0", VA = "0x1886C77E0")]
	public static void LCIOJEJEEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86C65D0", Offset = "0x86C4FD0", VA = "0x1886C65D0")]
	public static void IOKJHOENMJF(OIFJOAMMOIE FLLOPDBMKKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EIMPKFONALK
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private struct AMJHMBGLOAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Vector3 NGNFCFGNCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Quaternion OHBEIHCPLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public float HNJLIBKLAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Quaternion GCDDBDHFOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public float IDNNAEBEGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public float JGMGCIIJKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public float OGPNGBAPEOO;
	}

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static List<AMJHMBGLOAA> GEOPOMKCNCM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86C41C0", Offset = "0x86C2BC0", VA = "0x1886C41C0")]
	public static NativeList<CMNLAHEDKFC> BOOBNDNJFBI(MDKBNFJPNEA IMPJJOAFALF)
	{
		return default(NativeList<CMNLAHEDKFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86C3310", Offset = "0x86C1D10", VA = "0x1886C3310")]
	private static bool AKNEFFAKKGI(int JEDFFCJGKHB, NativeList<CMNLAHEDKFC> GGIKEMCHAAA, List<AMJHMBGLOAA> IMKHADPJGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x86C4C40", Offset = "0x86C3640", VA = "0x1886C4C40")]
	private static CMNLAHEDKFC JBGAKBBNIEG(int HBDKIKFKCEE, List<AMJHMBGLOAA> IMKHADPJGME)
	{
		return default(CMNLAHEDKFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x86C4750", Offset = "0x86C3150", VA = "0x1886C4750")]
	private static CMNLAHEDKFC EIFJDMHDNCI(int HBDKIKFKCEE, List<AMJHMBGLOAA> IMKHADPJGME)
	{
		return default(CMNLAHEDKFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x86C3230", Offset = "0x86C1C30", VA = "0x1886C3230")]
	private static CMNLAHEDKFC ABKEKPJLDBL(Vector3 FNPMGHGMCGE, Quaternion FLGMEAGNLEE, float JBOIDCJHBGG)
	{
		return default(CMNLAHEDKFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86C4DC0", Offset = "0x86C37C0", VA = "0x1886C4DC0")]
	public static NativeList<CMNLAHEDKFC> LLINKPNMPKM(MDKBNFJPNEA IMPJJOAFALF, float GFJJLLEGDBK)
	{
		return default(NativeList<CMNLAHEDKFC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PGAPEDKCEIB
{
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static Vector3 CLILHKDFPPN;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static Vector3 AGFLABPHGMF;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly float BHKKIEEFKGJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x86C8CD0", Offset = "0x86C76D0", VA = "0x1886C8CD0")]
	public static Vector3 GMDDGJGKCOO(Vector3 HHBMFMKJNCM, Quaternion FLGMEAGNLEE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x86C8C30", Offset = "0x86C7630", VA = "0x1886C8C30")]
	public static Vector3 FOIJFBKEPGP(Quaternion AMHDLJKDJBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x86C8FE0", Offset = "0x86C79E0", VA = "0x1886C8FE0")]
	public static Vector3 JGLHBIHBBED(Quaternion AMHDLJKDJBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x86C8F60", Offset = "0x86C7960", VA = "0x1886C8F60")]
	public static Quaternion IDGKMEJKGAN(Vector3 HLNPPHJBENM, Vector3 BJGHDDIMDNJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x86C97A0", Offset = "0x86C81A0", VA = "0x1886C97A0")]
	public static Vector3 OCOEODBHEKK(Vector3 ALFNFKLLEKK, Vector3 COGNLCFIOKA, Vector3 BJGHDDIMDNJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x86C9080", Offset = "0x86C7A80", VA = "0x1886C9080")]
	public static Vector3 JLFPJOLPAFM(Vector3 HHBMFMKJNCM, Vector3 BJGHDDIMDNJ, Quaternion AMHDLJKDJBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x86C9B10", Offset = "0x86C8510", VA = "0x1886C9B10")]
	public static Quaternion PJNONNHPFNA(Quaternion FLGMEAGNLEE, Vector3 HLNPPHJBENM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86C9990", Offset = "0x86C8390", VA = "0x1886C9990")]
	public static bool OHJKPKOEDEL(Vector3 DGAFPACBAEF, Vector3 EHIJNNCACGJ, [Out] Vector3 ILIMBEEKFNL, bool JNBEMLAJEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x86C94B0", Offset = "0x86C7EB0", VA = "0x1886C94B0")]
	public static Vector3 KHBBNJBBMHD(bool IBBEILJACNG, [Optional] Quaternion DNGMNKLJEMM)
	{
		return default(Vector3);
	}
}
namespace RecRoom.RendererV1.Terrain
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct TerrainMaterialLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float heightCutoff;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public float effectiveHeightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public MFJKGLKLLDL topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public MFJKGLKLLDL slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct TerrainWaterProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public bool waterEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public float waterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public float waterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Color waterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Color deepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public float emissiveStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public float alpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public KONGKEIIMBB waterMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public FNFAKLPEIOE overrides;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public OINMLFJGGEA baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public bool normalizeLayerHeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public JHNOEBLNBMP playArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public float playAreaOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public TerrainWaterProperties globalWaterProperties;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x86C9F50", Offset = "0x86C8950", VA = "0x1886C9F50")]
		public TerrainGenerationInfo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct TerrainInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public float GroundHeight;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum ODGIGBGHJLK
{
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Height,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Strata,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CKHFBFEBGHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public Vector2Int BCAJFCGHDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public float[] FDOLNIMJMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public ODGIGBGHJLK DGNODDPLLPC;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x86C31B0", Offset = "0x86C1BB0", VA = "0x1886C31B0")]
	public CKHFBFEBGHN(Vector2Int BCAJFCGHDKI, ODGIGBGHJLK DGNODDPLLPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FJOBOBDDPBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public float GFJJLLEGDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public float LPPENPFCLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public TerrainMaterialLayer[] EMBIGJADEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public int JGMADECOGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public CKHFBFEBGHN[] LPEDDMEJHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public float LIEBHNHBCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public int LGKLBIPFODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public int FGBBNPHFBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public float IKNOMMJCGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public int AKKNBBDGFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public float KHLJGEEIAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public int MAOOAJEJGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public int KLEJDMGCEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public float FDMJHAANKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public int OCBLNKFDLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public int MPHIMBNNHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public int PDJOHOIDKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public CKHFBFEBGHN[] DINBNBPIPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public float PIOJDCMNPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public int IEEDFCNHBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public int CEOPEHJPFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public int AAJBIOMMLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public float LDNBPDBLMIA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x86C6310", Offset = "0x86C4D10", VA = "0x1886C6310")]
	public FJOBOBDDPBO(Vector2Int FNBPMGINIMO, Vector2Int GCGOKIPCBMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AKFAFLPEOIB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	TerrainData ELOPBLKIMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject KALMDCABGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 LDEDNBFECOD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float3 PDGOIBFJCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float3 JKPPDLEMJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	TerrainGenerationInfo NHCCKNKAMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	TerrainInfo AENGBOKGAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> PNGIGJJIMNK(uint CFHELDJOJPD, bool CHPEKDAHKIL = true, bool EIDKKEDDHJA = true, bool BAGLDPMGOCA = true, [Optional] TerrainGenerationInfo IMPJJOAFALF, NLKDCAIFCCC CCLNMJBLMEJ = NLKDCAIFCCC.Default, [Optional] float3? NEKOPKFDDAD, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PIIFCIMJIKL(bool EPBMBCAEOFA);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BHDOHIOPOKF(Action<Material> CFFEJAMPCHM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct CMNLAHEDKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public float3 NGNFCFGNCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public float3x3 OHBEIHCPLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public float HNJLIBKLAMH;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MDKBNFJPNEA
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MHJOBAICFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 CGIDJHGFGPD(int HBDKIKFKCEE);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion FLILAKHJAFA(int HBDKIKFKCEE);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float GOGGIFFOCCO(int HBDKIKFKCEE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LJNNCBOFJHI : PPILPOLDBAI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool AJIAIJCINPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LBLBPFNEEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float AHFJMDBKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	int LLFIDMJMMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JCJIBOHEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int HJDMGPJHJHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CMNLAHEDKFC> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GIJGHJAGFLM : PPILPOLDBAI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FNINIENCAIO MPMCKFMCKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EJJHKJLFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float3 LFNJKADNJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DDAHMJKENKG
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	ALEFPCAPAGF AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MELJJFJMJGA EJJFPPGMBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "2")]
	void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PPILPOLDBAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GAHDCPCODAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PDNJFACNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	ALEFPCAPAGF AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	UniformTRS PDGECEEIBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float PCMMDIDGJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 FAIDHIOFDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	FIHNPCHPOKM BNJKHEDGMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	MFJKGLKLLDL BNJBNAOLOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KLMHLMDLEBF
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int KELLCJOFAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Transform EJMEGBMCAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DBNKFICEDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFEOEFPPCFO GetBone(int HBDKIKFKCEE);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int HBDKIKFKCEE);
}
namespace Cpp2IlInjected
{
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
}
