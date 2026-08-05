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
public enum PFDECMCNJAL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RRO_MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	RRO_COLORS_COUNT = 61,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	RRO_MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	GENERATED_MIN_VALUE = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	GENERATED_COLORS_BITS_PER_CHANNEL = 8,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	GENERATED_COLORS_COUNT = 16777216,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	GENERATED_MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	LEGACY_GENERATED_COLORS_COUNT = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	GENERATED_TO_GPU_OFFSET = -939,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	MAX_VALUE = 16778215,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JFIKKGDJBGF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71F63E0", Offset = "0x71F57E0", VA = "0x1871F63E0")]
	public static bool IJPAMIBDPMB(this PFDECMCNJAL NFGBCJAEKAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71F6400", Offset = "0x71F5800", VA = "0x1871F6400")]
	public static bool NFHHFOHLBMM(this PFDECMCNJAL NFGBCJAEKAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x71F63B0", Offset = "0x71F57B0", VA = "0x1871F63B0")]
	public static bool FCNNCNCHMFB(this PFDECMCNJAL NFGBCJAEKAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NAFBJEJAOEH : LDJIGAKAEPB, IEquatable<NAFBJEJAOEH>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[CreateProperty]
	public int FKHPMLNOHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CreateProperty]
	public int BLBNLGCJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2954C40", Offset = "0x2954040", VA = "0x182954C40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NNGOFJDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71F7300", Offset = "0x71F6700", VA = "0x1871F7300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28ECC10", Offset = "0x28EC010", VA = "0x1828ECC10", Slot = "8")]
	public bool Equals(NAFBJEJAOEH ICELKIGIKKP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x488AB00", Offset = "0x4889F00", VA = "0x18488AB00")]
	public static bool AHGPMPLECPJ(NAFBJEJAOEH NPBBJPKPNCJ, NAFBJEJAOEH KBAEKPMBMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71F7260", Offset = "0x71F6660", VA = "0x1871F7260", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x71F7340", Offset = "0x71F6740", VA = "0x1871F7340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OMFCOLBDGKP
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IDCFBDIAJKK : LDJIGAKAEPB, IEquatable<IDCFBDIAJKK>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int FKHPMLNOHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[CreateProperty]
	public int BLBNLGCJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2954C40", Offset = "0x2954040", VA = "0x182954C40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NNGOFJDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71F34F0", Offset = "0x71F28F0", VA = "0x1871F34F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x28ECC10", Offset = "0x28EC010", VA = "0x1828ECC10", Slot = "8")]
	public bool Equals(IDCFBDIAJKK ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71F3450", Offset = "0x71F2850", VA = "0x1871F3450", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x71F3530", Offset = "0x71F2930", VA = "0x1871F3530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum INPKLHICICA
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KKFFAKHFGOF
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DebugLocate,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	FrozenHover
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IHJJJPNMOBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBLIKOEBNON(NAFBJEJAOEH AOCBEEBNJPK, KKFFAKHFGOF EFDJMBALOBC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBLIKOEBNON(IDCFBDIAJKK FJDLLHJPBKD, KKFFAKHFGOF EFDJMBALOBC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBJEFBKMGDH(IDCFBDIAJKK FJDLLHJPBKD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDBFLODFBOA(IDCFBDIAJKK FJDLLHJPBKD);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PDBAEMPOEKI();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCGFNDFMGJP(KKFFAKHFGOF GANFKPHKNKH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HPINAEFHDGP(NAFBJEJAOEH AOCBEEBNJPK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HPINAEFHDGP(IDCFBDIAJKK FJDLLHJPBKD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NMCHEBADBFL(NAFBJEJAOEH AOCBEEBNJPK, FBALIINALIE GANFKPHKNKH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NMCHEBADBFL(IDCFBDIAJKK FJDLLHJPBKD, FBALIINALIE GANFKPHKNKH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CGDFLBIPFMB(IDCFBDIAJKK FJDLLHJPBKD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FIAMNMJLMGG(IDCFBDIAJKK FJDLLHJPBKD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NHAAIAECMFM();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PAKBGKGHMKA(FBALIINALIE GANFKPHKNKH);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EKDONPNPMMB(NAFBJEJAOEH AOCBEEBNJPK, Vector3 MPMBPPMCIGE, Vector3 OKBNNGCFHNI, Vector3 BOOIMLFPIID, float NAJPGLKBHID, float LFKNAGILCHF, IReadOnlyList<Camera> HIFANLCNCIE, INPKLHICICA GAMNLNNCHBK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EKDONPNPMMB(HDJNPHNJDGA JFCFLCJPILB, Vector3 MPMBPPMCIGE, Vector3 OKBNNGCFHNI, Vector3 BOOIMLFPIID, float NAJPGLKBHID, float LFKNAGILCHF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HDJNPHNJDGA : LDJIGAKAEPB, IEquatable<HDJNPHNJDGA>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FKHPMLNOHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BLBNLGCJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2954C40", Offset = "0x2954040", VA = "0x182954C40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NNGOFJDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71F3410", Offset = "0x71F2810", VA = "0x1871F3410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28ECC10", Offset = "0x28EC010", VA = "0x1828ECC10", Slot = "8")]
	public bool Equals(HDJNPHNJDGA ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x71F3370", Offset = "0x71F2770", VA = "0x1871F3370", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MADGLDNBLBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GKIKJNNIEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAFBJEJAOEH HBCJCIOHIGJ(JMPOKKHIFAB CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NAFBJEJAOEH HBCJCIOHIGJ(JMPOKKHIFAB CLCAIFLMLCJ, bool KHAEAECEHII);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLDPIMKEIMC(NAFBJEJAOEH AOCBEEBNJPK);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBNKCMIGEOO(NAFBJEJAOEH AOCBEEBNJPK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IDCFBDIAJKK NBHJDDAENMN(NAFBJEJAOEH AOCBEEBNJPK, KOIJLKOCPOH CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDCFBDIAJKK HCDINJIBKPA(NAFBJEJAOEH AOCBEEBNJPK, NALENNKFPII CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HMNAFNHONMJ(IDCFBDIAJKK FJDLLHJPBKD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CJJJHDDHPON(IDCFBDIAJKK FJDLLHJPBKD);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HDJNPHNJDGA HLLFCLHLGKF(EMLGFNKPOKK CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JHBEPHKKJOI(HDJNPHNJDGA JFCFLCJPILB);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ECPMPIANBIB(HDJNPHNJDGA JFCFLCJPILB);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task PFKEMJLGBDF();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task GAGDJJLBILC();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FAFCHLLLCBP();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JPJEDEALLHP();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<Renderer> IKONLBFIOAC(NAFBJEJAOEH AOCBEEBNJPK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum FBALIINALIE
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MNPJOJNOFJM
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static Vector3 IMDCJNEOCGA;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static Vector3 CONKADLGLLF;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly float CKIPJHPJCED;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x71F6920", Offset = "0x71F5D20", VA = "0x1871F6920")]
	public static Vector3 EELCMGEENOA(Vector3 HLPMIBPACOH, Quaternion LMJFLEPCKIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71F7060", Offset = "0x71F6460", VA = "0x1871F7060")]
	public static Vector3 JKNKEBCMGCF(Quaternion OCEJJKMFIJB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71F7110", Offset = "0x71F6510", VA = "0x1871F7110")]
	public static Vector3 MHOIHJIEFLL(Quaternion OCEJJKMFIJB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x71F6DC0", Offset = "0x71F61C0", VA = "0x1871F6DC0")]
	public static Quaternion HANACDPHBEE(Vector3 GCNKNLGIDOA, Vector3 PKGGKJEKINO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71F6410", Offset = "0x71F5810", VA = "0x1871F6410")]
	public static Vector3 AIOEHEKOKLN(Vector3 FEHIOPPFIPC, Vector3 HNIJCEMJNLP, Vector3 PKGGKJEKINO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x71F6E60", Offset = "0x71F6260", VA = "0x1871F6E60")]
	public static Vector3 IEIJAOHKLJK(Vector3 HLPMIBPACOH, Vector3 PKGGKJEKINO, Quaternion OCEJJKMFIJB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x71F6B80", Offset = "0x71F5F80", VA = "0x1871F6B80")]
	public static Quaternion FDOLPMGAIMP(Quaternion LMJFLEPCKIJ, Vector3 GCNKNLGIDOA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71F67A0", Offset = "0x71F5BA0", VA = "0x1871F67A0")]
	public static bool CHBEHFMEENM(Vector3 MACBHOCIKJJ, Vector3 OIHNFIOCFAF, out Vector3 OBMLBPFLDPI, bool OFHFJKNFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x71F65C0", Offset = "0x71F59C0", VA = "0x1871F65C0")]
	public static Vector3 APCJIGALMLJ(bool AHOLHBJNDGB, [Optional] Quaternion BFDPIKJJKKD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BCJDKCCJIIB
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JCIKJCKHDON
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct BOCBIOKLMOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Vector3 GHELJMFBFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Quaternion IABPMALGHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float LAODMHIDGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Quaternion NAMPFHFIPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float KDPKNGEKNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public float GBFADPGJNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public float MGLOMJFKDGK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static List<BOCBIOKLMOI> KCHDFFHNFNM;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x71F43E0", Offset = "0x71F37E0", VA = "0x1871F43E0")]
	public static NativeList<BIFLPHMIMKD> BHNGEEEFACD(CHLLFGKKDDP AEBIGIBLJOL)
	{
		return default(NativeList<BIFLPHMIMKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x71F35C0", Offset = "0x71F29C0", VA = "0x1871F35C0")]
	private static bool ABENPMGOCIF(int APEMPONKPBB, NativeList<BIFLPHMIMKD> MOOEDNDCGLB, List<BOCBIOKLMOI> MBOAMKIIHKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x71F4910", Offset = "0x71F3D10", VA = "0x1871F4910")]
	private static BIFLPHMIMKD DAKHEGGGODN(int MKCEFHAFAJD, List<BOCBIOKLMOI> MBOAMKIIHKG)
	{
		return default(BIFLPHMIMKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x71F5EF0", Offset = "0x71F52F0", VA = "0x1871F5EF0")]
	private static BIFLPHMIMKD GLBJIEJBOJJ(int MKCEFHAFAJD, List<BOCBIOKLMOI> MBOAMKIIHKG)
	{
		return default(BIFLPHMIMKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x71F5DF0", Offset = "0x71F51F0", VA = "0x1871F5DF0")]
	private static BIFLPHMIMKD ENDIBFEPFJC(Vector3 PMKGPHOGHCN, Quaternion LMJFLEPCKIJ, float BJDNODMMNIO)
	{
		return default(BIFLPHMIMKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x71F4B00", Offset = "0x71F3F00", VA = "0x1871F4B00")]
	public static NativeList<BIFLPHMIMKD> DMGAEPJBEHN(CHLLFGKKDDP AEBIGIBLJOL, float CGNFMEFAMFE)
	{
		return default(NativeList<BIFLPHMIMKD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum BKFNABBICCI
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KOIJLKOCPOH : FMHEEFAHFEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BCJDKCCJIIB KMDBBLELFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool ECOJGEDOOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JMPOKKHIFAB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JANGGNCGNFH BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	BKFNABBICCI PFDOBOEJGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NALENNKFPII : FMHEEFAHFEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool OJIKOKDOHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool CNAELMLCLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float MHMCHPBCLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int KLHOINJDLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool CFDGEDGLCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int CBONOOCNNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<BIFLPHMIMKD> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EMLGFNKPOKK
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int AOKCGJHEJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform PMKGAODFCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool POOCMOMFJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NAFBJEJAOEH GetBone(int MKCEFHAFAJD);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int MKCEFHAFAJD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FMHEEFAHFEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DKLNLGLAOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PNBLIHEDBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JANGGNCGNFH BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float OPAMPEPCCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Vector3 LJNBFGKGGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PFDECMCNJAL JKOHLBMOPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	OMFCOLBDGKP OJFGHIPDGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BIFLPHMIMKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 GHELJMFBFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float3x3 IABPMALGHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float LAODMHIDGDK;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CHLLFGKKDDP
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int JHIHPBCGPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 PPAENJCJNLI(int MKCEFHAFAJD);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Quaternion JANKHKINBCC(int MKCEFHAFAJD);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float CPDNIKEONOJ(int MKCEFHAFAJD);
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
