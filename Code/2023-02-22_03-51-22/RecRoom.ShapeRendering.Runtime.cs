using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.ClusterLODs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FFPHIEMGAFF
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
public static class BHICPIHFJOI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6109F60", Offset = "0x6109160", VA = "0x186109F60")]
	public static bool FDKENDCANNM(this FFPHIEMGAFF BKPOIPFKFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6109F80", Offset = "0x6109180", VA = "0x186109F80")]
	public static bool FNELADHHFKI(this FFPHIEMGAFF BKPOIPFKFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6109F90", Offset = "0x6109190", VA = "0x186109F90")]
	public static bool HIOGBLKFOOD(this FFPHIEMGAFF BKPOIPFKFKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JFDLEDMKPLI
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	WORN_WOOD = 29,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HEHJDCBGOHB
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KLPDLCDIGKD
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	PivotHover,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DebugLocate,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	FrozenHover
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BACJNPDBEOB
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MNFOCJBANCB : LDLBEPGAECI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte LEBHBEJPAFD = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte HBDGEPGELIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] BFDPDBBDOIB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ACDOJIEAAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C7010", Offset = "0x6C6210", VA = "0x1806C7010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x710CC0", Offset = "0x70FEC0", VA = "0x180710CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LKEIBNMGCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E7D90", Offset = "0x6E6F90", VA = "0x1806E7D90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85FD20", Offset = "0x85EF20", VA = "0x18085FD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float KGKJLLKDAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x12F24F0", Offset = "0x12F16F0", VA = "0x1812F24F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x13753A0", Offset = "0x13745A0", VA = "0x1813753A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float PFFPCKHAFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12F24E0", Offset = "0x12F16E0", VA = "0x1812F24E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1679D90", Offset = "0x1678F90", VA = "0x181679D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> CPGAGALMNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x610FDF0", Offset = "0x610EFF0", VA = "0x18610FDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> IDNJJKMBGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDCD0", Offset = "0x5CBCED0", VA = "0x185CBDCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte IHOLHLLNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x610FDA0", Offset = "0x610EFA0", VA = "0x18610FDA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61102C0", Offset = "0x610F4C0", VA = "0x1861102C0")]
	public MNFOCJBANCB(List<MJOFHEKFILD> NJALBHMGONI, List<MJOFHEKFILD> JLKAFLGIDBB, List<CEIHGOGAJAB> OLJDKFBHLOC, Material OMOMAJDOPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x610FE50", Offset = "0x610F050", VA = "0x18610FE50")]
	private int DGDPBGFKBEC(List<MJOFHEKFILD> HLCDPKEAHAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6110130", Offset = "0x610F330", VA = "0x186110130")]
	private void MLBNJCHJPME(int MFCCMFEENNG, bool BEIBHGPBPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6110090", Offset = "0x610F290", VA = "0x186110090")]
	public void GNCOEIPEKIA(Vector3 KEAOLNIPIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x610FF60", Offset = "0x610F160", VA = "0x18610FF60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6110280", Offset = "0x610F480", VA = "0x186110280")]
	public void PPMAOHEDAPJ(Transform JBBPPAELOMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JCLDAIFDHJA : ALHJIDNONPB, BPHBDEFEINB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GDJIBNKOEKO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JCLDAIFDHJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
		[DebuggerHidden]
		public GDJIBNKOEKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x610C330", Offset = "0x610B530", VA = "0x18610C330", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x610BE00", Offset = "0x610B000", VA = "0x18610BE00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x610C430", Offset = "0x610B630", VA = "0x18610C430")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x610C480", Offset = "0x610B680", VA = "0x18610C480")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x610C4D0", Offset = "0x610B6D0", VA = "0x18610C4D0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x610C2F0", Offset = "0x610B4F0", VA = "0x18610C2F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x610C250", Offset = "0x610B450", VA = "0x18610C250", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x610C250", Offset = "0x610B450", VA = "0x18610C250", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DAPFIBDIFLE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public JCLDAIFDHJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
		[DebuggerHidden]
		public DAPFIBDIFLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x610A9E0", Offset = "0x6109BE0", VA = "0x18610A9E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x610A620", Offset = "0x6109820", VA = "0x18610A620", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x610AAC0", Offset = "0x6109CC0", VA = "0x18610AAC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x610AB10", Offset = "0x6109D10", VA = "0x18610AB10")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x610A9A0", Offset = "0x6109BA0", VA = "0x18610A9A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x610A900", Offset = "0x6109B00", VA = "0x18610A900", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x610A900", Offset = "0x6109B00", VA = "0x18610A900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CAAEMMJFMON JIGGNMEFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<KDMJDPBIKEE> IDBELADJMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> DAHBCNNDELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer IFOLDHFDAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool PNAJKAKMBDH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<LDKGGMHGEOG> MHOOOFLEOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PEDGHKKGKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x610D2A0", Offset = "0x610C4A0", VA = "0x18610D2A0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CEIHGOGAJAB FMALCPFHLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x610C830", Offset = "0x610BA30", VA = "0x18610C830", Slot = "7")]
		get
		{
			return default(CEIHGOGAJAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> OOPJJGMLHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6CE590", Offset = "0x6CD790", VA = "0x1806CE590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x610D800", Offset = "0x610CA00", VA = "0x18610D800")]
	public JCLDAIFDHJA(CAAEMMJFMON ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x610CE70", Offset = "0x610C070", VA = "0x18610CE70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x610C660", Offset = "0x610B860", VA = "0x18610C660")]
	public void AOHLLDNPMGN(KDMJDPBIKEE MNJCHLDPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x610C770", Offset = "0x610B970", VA = "0x18610C770")]
	public void BCBAFCFKBLF(KDMJDPBIKEE MNJCHLDPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x610C900", Offset = "0x610BB00", VA = "0x18610C900", Slot = "4")]
	public void CAHEOPGPOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x610D180", Offset = "0x610C380", VA = "0x18610D180")]
	public void KJAIMLDDOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x610D000", Offset = "0x610C200", VA = "0x18610D000")]
	private void IMLKHCKCDHK(List<KDMJDPBIKEE> IDBELADJMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x610C520", Offset = "0x610B720", VA = "0x18610C520")]
	private static Material AEMLIBLIAIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x610D130", Offset = "0x610C330", VA = "0x18610D130")]
	private void IMLKHCKCDHK(KDMJDPBIKEE MNJCHLDPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x610CEA0", Offset = "0x610C0A0", VA = "0x18610CEA0")]
	private void ELIBADAJFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x610D2E0", Offset = "0x610C4E0", VA = "0x18610D2E0")]
	public void PBOAPDOOGNG(bool CJFCKMFPCBN, bool INBFBPONOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x610CF70", Offset = "0x610C170", VA = "0x18610CF70")]
	protected void GMLMOFDKEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x610D230", Offset = "0x610C430", VA = "0x18610D230")]
	[IteratorStateMachine(typeof(GDJIBNKOEKO))]
	public IEnumerable<Renderer> NAAFOPFACCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x610C5F0", Offset = "0x610B7F0", VA = "0x18610C5F0")]
	[IteratorStateMachine(typeof(DAPFIBDIFLE))]
	public IEnumerable<Renderer> AJMKGALAMEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class ELJHBIDICKL : KDMJDPBIKEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CKIBAPLBMKC ADGAEJJKEHH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6109F10", Offset = "0x6109110", VA = "0x186109F10")]
	public ELJHBIDICKL(JCLDAIFDHJA LBGMPPHBAAC, CKIBAPLBMKC ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x610BAB0", Offset = "0x610ACB0", VA = "0x18610BAB0", Slot = "13")]
	public override int DGDPBGFKBEC(DFHGDAFHKOH MLFDOFFDKGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x610B8C0", Offset = "0x610AAC0", VA = "0x18610B8C0", Slot = "14")]
	public override int CPJGKDIMCEB(DFHGDAFHKOH MLFDOFFDKGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x610B190", Offset = "0x610A390", VA = "0x18610B190", Slot = "15")]
	public override void CPJAILLECIC(DFHGDAFHKOH MLFDOFFDKGG, NJJOGHOKENA ACBJMIABIEE, int EBPBKJGOJOB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LPLINAKPAHH : global::BDDOIGLJFOK<LPLINAKPAHH>, IGCGKLPONMN, IEquatable<LPLINAKPAHH>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int ICGLEEKOOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x778D90", Offset = "0x777F90", VA = "0x180778D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int DMLEMNEAJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x890590", Offset = "0x88F790", VA = "0x180890590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xEABC90", Offset = "0xEAAE90", VA = "0x180EABC90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x610DA90", Offset = "0x610CC90", VA = "0x18610DA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x282B110", Offset = "0x282A310", VA = "0x18282B110", Slot = "8")]
	public bool Equals(LPLINAKPAHH IHIJPIJNLJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xCE5680", Offset = "0xCE4880", VA = "0x180CE5680")]
	public static bool GJOJIEKGOHO(LPLINAKPAHH FAMKPEGNHFC, LPLINAKPAHH GPHMIGDKMEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3D10", Offset = "0x4BA2F10", VA = "0x184BA3D10")]
	public static bool ALCENKEOHOJ(LPLINAKPAHH FAMKPEGNHFC, LPLINAKPAHH GPHMIGDKMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x610DA00", Offset = "0x610CC00", VA = "0x18610DA00", Slot = "0")]
	public override bool Equals(object ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x610DAD0", Offset = "0x610CCD0", VA = "0x18610DAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KBJHFMDKNNG
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CAAEMMJFMON
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CEIHGOGAJAB LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KBJHFMDKNNG MIBKDJPGFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FJKCPBNOJEN : global::BDDOIGLJFOK<FJKCPBNOJEN>, IGCGKLPONMN, IEquatable<FJKCPBNOJEN>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int ICGLEEKOOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x778D90", Offset = "0x777F90", VA = "0x180778D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int DMLEMNEAJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x890590", Offset = "0x88F790", VA = "0x180890590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xEABC90", Offset = "0xEAAE90", VA = "0x180EABC90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x610BD30", Offset = "0x610AF30", VA = "0x18610BD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x282B110", Offset = "0x282A310", VA = "0x18282B110", Slot = "8")]
	public bool Equals(FJKCPBNOJEN IHIJPIJNLJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xCE5680", Offset = "0xCE4880", VA = "0x180CE5680")]
	public static bool GJOJIEKGOHO(FJKCPBNOJEN FAMKPEGNHFC, FJKCPBNOJEN GPHMIGDKMEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3D10", Offset = "0x4BA2F10", VA = "0x184BA3D10")]
	public static bool ALCENKEOHOJ(FJKCPBNOJEN FAMKPEGNHFC, FJKCPBNOJEN GPHMIGDKMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x610BCA0", Offset = "0x610AEA0", VA = "0x18610BCA0", Slot = "0")]
	public override bool Equals(object ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x610BD70", Offset = "0x610AF70", VA = "0x18610BD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MOEMGAEPIFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	CEIHGOGAJAB LNPNGFHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float JAINKNCNOBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 JMMKIILOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	FFPHIEMGAFF BCGPMHJCGBD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JFDLEDMKPLI FBCBJAIOFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NGNDKDFALJK : MOEMGAEPIFP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NKPHOHCBLCG BEPMODEHBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NMEPFPBOMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CKIBAPLBMKC : MOEMGAEPIFP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BOCPMGHKMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GEAKMEMEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float JHJJJEHFMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int DHHHMEHBEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool ABADMBEFPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int OLKNBMGCGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<AONLBIAFHDB> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KPAMCGHFNBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPMABEJDFEN(LPLINAKPAHH LBGMPPHBAAC, KLPDLCDIGKD FKALJJLAGGK);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPMABEJDFEN(FJKCPBNOJEN MNJCHLDPJOF, KLPDLCDIGKD FKALJJLAGGK);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONELNJAADLJ(FJKCPBNOJEN MNJCHLDPJOF);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLFMMHHCHCC(FJKCPBNOJEN MNJCHLDPJOF);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MONCCDFOKCG();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAGMLIIKJND();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FONGPLPAKCK(KLPDLCDIGKD DDJDPMGLPAE);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODHCIAJLKKD(LPLINAKPAHH LBGMPPHBAAC);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ODHCIAJLKKD(FJKCPBNOJEN MNJCHLDPJOF);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PLNOCFNGBNA(LPLINAKPAHH LBGMPPHBAAC, BACJNPDBEOB DDJDPMGLPAE);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PLNOCFNGBNA(FJKCPBNOJEN MNJCHLDPJOF, BACJNPDBEOB DDJDPMGLPAE);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BDECIHEEDCB(FJKCPBNOJEN MNJCHLDPJOF);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PIKOBDPFINH(FJKCPBNOJEN MNJCHLDPJOF);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ONBPENPAAJO();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CKBNMKMDKGF();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KEIMIJPINOD(BACJNPDBEOB DDJDPMGLPAE);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DMLIKEDCKDA(LPLINAKPAHH LBGMPPHBAAC, Vector3 FAIMAIJHPOP, Vector3 MAOOHEDHJFH, Vector3 CBILFMIEMBA, float OGPBBBPGKPH, float HIGCIMNKLCO, IReadOnlyList<Camera> FCFBOLKHALH, HEHJDCBGOHB MAAGGLOEPIL);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DMLIKEDCKDA(BJGIPCBONCO NFHNDHDBNCK, Vector3 FAIMAIJHPOP, Vector3 MAOOHEDHJFH, Vector3 CBILFMIEMBA, float OGPBBBPGKPH, float HIGCIMNKLCO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BFHNEKCIHMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LPLINAKPAHH JNAPKJHLMPJ(CAAEMMJFMON ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECPCLLOPABA(LPLINAKPAHH LBGMPPHBAAC);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFLEBMEBODA(LPLINAKPAHH LBGMPPHBAAC);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJKCPBNOJEN GDILPKHOKNC(LPLINAKPAHH LBGMPPHBAAC, NGNDKDFALJK ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FJKCPBNOJEN FHDJPNKCIGK(LPLINAKPAHH LBGMPPHBAAC, CKIBAPLBMKC ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CHDGMECFDOE(FJKCPBNOJEN MNJCHLDPJOF);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FNHMNKLGOJD(FJKCPBNOJEN MNJCHLDPJOF);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BJGIPCBONCO MMNELINBPMK(PKHEKDIBMDF ONIBEFDCPGD);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void COEHBNKLJGE(BJGIPCBONCO NFHNDHDBNCK);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BFAICCHAIHL(BJGIPCBONCO NFHNDHDBNCK);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IKPIJFLHOMC CBNOMLAOGOM(CEIHGOGAJAB NCHIMHCGEAB, IEnumerable<FJKCPBNOJEN> IDBELADJMGE, int MLCGNHBPCEC);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> AOGHFNGCIOE(LPLINAKPAHH LBGMPPHBAAC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BJGIPCBONCO : global::BDDOIGLJFOK<BJGIPCBONCO>, IGCGKLPONMN, IEquatable<BJGIPCBONCO>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int ICGLEEKOOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x778D90", Offset = "0x777F90", VA = "0x180778D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int DMLEMNEAJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x890590", Offset = "0x88F790", VA = "0x180890590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xEABC90", Offset = "0xEAAE90", VA = "0x180EABC90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HGGGGBFNODB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x610A050", Offset = "0x6109250", VA = "0x18610A050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x282B110", Offset = "0x282A310", VA = "0x18282B110", Slot = "8")]
	public bool Equals(BJGIPCBONCO IHIJPIJNLJM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xCE5680", Offset = "0xCE4880", VA = "0x180CE5680")]
	public static bool GJOJIEKGOHO(BJGIPCBONCO FAMKPEGNHFC, BJGIPCBONCO GPHMIGDKMEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3D10", Offset = "0x4BA2F10", VA = "0x184BA3D10")]
	public static bool ALCENKEOHOJ(BJGIPCBONCO FAMKPEGNHFC, BJGIPCBONCO GPHMIGDKMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6109FC0", Offset = "0x61091C0", VA = "0x186109FC0", Slot = "0")]
	public override bool Equals(object ADHHHFDPAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PKHEKDIBMDF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int HHOFGLCPMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform OMNDJFDMDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FLBMEAIHFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LPLINAKPAHH GetBone(int NBFLFIOCJKI);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int NBFLFIOCJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class BFCJGHLPEME : KDMJDPBIKEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly NGNDKDFALJK AHMFAEOKPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] JJLHMCNLPGM;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override MAEFCOOCBLB BKPGDEPAJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x61093B0", Offset = "0x61085B0", VA = "0x1861093B0", Slot = "12")]
		get
		{
			return default(MAEFCOOCBLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 FNNEDMLPGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6109BD0", Offset = "0x6108DD0", VA = "0x186109BD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6109F10", Offset = "0x6109110", VA = "0x186109F10")]
	public BFCJGHLPEME(JCLDAIFDHJA LBGMPPHBAAC, NGNDKDFALJK ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6109760", Offset = "0x6108960", VA = "0x186109760", Slot = "11")]
	public override bool KCOHCDHLELL(CEIHGOGAJAB LBGMPPHBAAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6109050", Offset = "0x6108250", VA = "0x186109050", Slot = "13")]
	public override int DGDPBGFKBEC(DFHGDAFHKOH MLFDOFFDKGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6108FA0", Offset = "0x61081A0", VA = "0x186108FA0", Slot = "14")]
	public override int CPJGKDIMCEB(DFHGDAFHKOH MLFDOFFDKGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6109100", Offset = "0x6108300", VA = "0x186109100")]
	private int GFCMOPHFMHA(DFHGDAFHKOH MLFDOFFDKGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x61086C0", Offset = "0x61078C0", VA = "0x1861086C0", Slot = "15")]
	public override void CPJAILLECIC(DFHGDAFHKOH MLFDOFFDKGG, NJJOGHOKENA ACBJMIABIEE, int EBPBKJGOJOB = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KEGAJAENGLJ
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPOBBFDBMEG(BACJNPDBEOB DDJDPMGLPAE, Renderer ACOGBHGPDBE, int KGMNPAJJPLE);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDACLALEICP(Renderer ACOGBHGPDBE, HEHJDCBGOHB MAAGGLOEPIL, Vector3 FAIMAIJHPOP, Vector3 MAOOHEDHJFH, Vector3 CBILFMIEMBA, float OGPBBBPGKPH, float HIGCIMNKLCO, float JEDMHMHCADK = -1f, [Optional] Color? GEDOLEMBLCF, [Optional] IReadOnlyList<Camera> FOJJEDDDFPF);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MENNLAFCDGE(Renderer ACOGBHGPDBE, int KGMNPAJJPLE);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OPJIIDGPFKB();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPGLIHBNIPF(int HIKKIKNPBLD, KLPDLCDIGKD DDJDPMGLPAE, Renderer ACOGBHGPDBE, int KGMNPAJJPLE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class POCMIHDALOM : KPAMCGHFNBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class AHIDIDNNHAI : global::NLHMKGMNBFM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6108670", Offset = "0x6107870", VA = "0x186108670")]
		public AHIDIDNNHAI(string IGHJIHNAPBA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly KEGAJAENGLJ CKFJOJABCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly MMHLAKAADCF EDDHCMFMKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer GIFGFGEKCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private AHIDIDNNHAI DDFHIGLLGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool BCPLEBOIBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer DBGDJAIKOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private AHIDIDNNHAI HFALKHFJLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool APLIOKLGDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer APNNAPPDCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private AHIDIDNNHAI FAFLGOGNHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C76E0", Offset = "0x6C68E0", VA = "0x1806C76E0")]
	public POCMIHDALOM(KEGAJAENGLJ KEFIAFBPOMA, MMHLAKAADCF EDDHCMFMKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6112C90", Offset = "0x6111E90", VA = "0x186112C90", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6111EE0", Offset = "0x61110E0", VA = "0x186111EE0")]
	private void ABJDDPFOMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6114100", Offset = "0x6113300", VA = "0x186114100", Slot = "4")]
	public void PPMABEJDFEN(LPLINAKPAHH LBGMPPHBAAC, KLPDLCDIGKD FKALJJLAGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6113EE0", Offset = "0x61130E0", VA = "0x186113EE0", Slot = "5")]
	public void PPMABEJDFEN(FJKCPBNOJEN MNJCHLDPJOF, KLPDLCDIGKD FKALJJLAGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61137B0", Offset = "0x61129B0", VA = "0x1861137B0", Slot = "6")]
	public void ONELNJAADLJ(FJKCPBNOJEN MNJCHLDPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6113110", Offset = "0x6112310", VA = "0x186113110", Slot = "7")]
	public void KLFMMHHCHCC(FJKCPBNOJEN MNJCHLDPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6113230", Offset = "0x6112430", VA = "0x186113230", Slot = "8")]
	public void MONCCDFOKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x16AA5A0", Offset = "0x16A97A0", VA = "0x1816AA5A0", Slot = "9")]
	public void KAGMLIIKJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6112E60", Offset = "0x6112060", VA = "0x186112E60", Slot = "10")]
	public void FONGPLPAKCK(KLPDLCDIGKD FKALJJLAGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x61135C0", Offset = "0x61127C0", VA = "0x1861135C0", Slot = "11")]
	public void ODHCIAJLKKD(LPLINAKPAHH LBGMPPHBAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6113270", Offset = "0x6112470", VA = "0x186113270", Slot = "12")]
	public void ODHCIAJLKKD(FJKCPBNOJEN MNJCHLDPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6113970", Offset = "0x6112B70", VA = "0x186113970", Slot = "13")]
	public void PLNOCFNGBNA(LPLINAKPAHH LBGMPPHBAAC, BACJNPDBEOB DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6113B30", Offset = "0x6112D30", VA = "0x186113B30", Slot = "14")]
	public void PLNOCFNGBNA(FJKCPBNOJEN MNJCHLDPJOF, BACJNPDBEOB DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6113770", Offset = "0x6112970", VA = "0x186113770", Slot = "17")]
	public void ONBPENPAAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6112130", Offset = "0x6111330", VA = "0x186112130", Slot = "15")]
	public void BDECIHEEDCB(FJKCPBNOJEN MNJCHLDPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61138E0", Offset = "0x6112AE0", VA = "0x1861138E0", Slot = "16")]
	public void PIKOBDPFINH(FJKCPBNOJEN MNJCHLDPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1103520", Offset = "0x1102720", VA = "0x181103520", Slot = "18")]
	public void CKBNMKMDKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6112FD0", Offset = "0x61121D0", VA = "0x186112FD0", Slot = "19")]
	public void KEIMIJPINOD(BACJNPDBEOB DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61122A0", Offset = "0x61114A0", VA = "0x1861122A0")]
	private void CCCCKAKNENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6113D20", Offset = "0x6112F20", VA = "0x186113D20")]
	public void PLNOCFNGBNA(FJKCPBNOJEN MNJCHLDPJOF, BACJNPDBEOB DDJDPMGLPAE, bool OBBGFLCNLGE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x61121D0", Offset = "0x61113D0", VA = "0x1861121D0")]
	private void BPOBBFDBMEG(BACJNPDBEOB DDJDPMGLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6112910", Offset = "0x6111B10", VA = "0x186112910", Slot = "20")]
	public void DMLIKEDCKDA(LPLINAKPAHH LBGMPPHBAAC, Vector3 FAIMAIJHPOP, Vector3 MAOOHEDHJFH, Vector3 CBILFMIEMBA, float OGPBBBPGKPH, float HIGCIMNKLCO, IReadOnlyList<Camera> FCFBOLKHALH, HEHJDCBGOHB MAAGGLOEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x61124F0", Offset = "0x61116F0", VA = "0x1861124F0", Slot = "21")]
	public void DMLIKEDCKDA(BJGIPCBONCO NFHNDHDBNCK, Vector3 FAIMAIJHPOP, Vector3 MAOOHEDHJFH, Vector3 CBILFMIEMBA, float OGPBBBPGKPH, float HIGCIMNKLCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KDMJDPBIKEE : HCMNPJPHOLG, LDKGGMHGEOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly JCLDAIFDHJA MDHMHFAIMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds EIPPIEJEGOD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds NDOKJMIJGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xFBF1B0", Offset = "0xFBE3B0", VA = "0x180FBF1B0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual MAEFCOOCBLB BKPGDEPAJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x610D970", Offset = "0x610CB70", VA = "0x18610D970", Slot = "12")]
		get
		{
			return default(MAEFCOOCBLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F40", Offset = "0x6C7140", VA = "0x1806C7F40")]
	protected KDMJDPBIKEE(JCLDAIFDHJA LBGMPPHBAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x610D8A0", Offset = "0x610CAA0", VA = "0x18610D8A0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "11")]
	public virtual bool KCOHCDHLELL(CEIHGOGAJAB LBGMPPHBAAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int DGDPBGFKBEC(DFHGDAFHKOH MLFDOFFDKGG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int CPJGKDIMCEB(DFHGDAFHKOH MLFDOFFDKGG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void CPJAILLECIC(DFHGDAFHKOH MLFDOFFDKGG, NJJOGHOKENA ACBJMIABIEE, int EBPBKJGOJOB = -1);
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6114300", Offset = "0x6113500", VA = "0x186114300")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NKPHOHCBLCG
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class MLENLEMGGAH
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NLAIKBDMKJJ : IEnumerable<ADECFLPGGBM>, IEnumerable, IEnumerator<ADECFLPGGBM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private ADECFLPGGBM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private ADECFLPGGBM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
		[DebuggerHidden]
		public NLAIKBDMKJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6110680", Offset = "0x610F880", VA = "0x186110680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x61107F0", Offset = "0x610F9F0", VA = "0x1861107F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6110760", Offset = "0x610F960", VA = "0x186110760", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ADECFLPGGBM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6110760", Offset = "0x610F960", VA = "0x186110760", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int EHACHOMODIJ = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static ADECFLPGGBM[][] HGJMNNMPEPI;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static OJHHEOPONIF GFADOGHOCCD;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig HINLOILOHDI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader LGGMBLINEKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x610F6C0", Offset = "0x610E8C0", VA = "0x18610F6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer KLJPMPDDJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x610F0C0", Offset = "0x610E2C0", VA = "0x18610F0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x610F890", Offset = "0x610EA90", VA = "0x18610F890")]
	public static Mesh PNEJHFPAEFG(NKPHOHCBLCG AILPPENJINK, int MLFDOFFDKGG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x610F340", Offset = "0x610E540", VA = "0x18610F340")]
	public static int FLJEHDAFHEJ(NKPHOHCBLCG AILPPENJINK, int MLFDOFFDKGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x610F730", Offset = "0x610E930", VA = "0x18610F730")]
	public static OJHHEOPONIF PIDHNEIAEHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x610F2E0", Offset = "0x610E4E0", VA = "0x18610F2E0")]
	[IteratorStateMachine(typeof(NLAIKBDMKJJ))]
	private static IEnumerable<ADECFLPGGBM> DODEKMAJDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x610F360", Offset = "0x610E560", VA = "0x18610F360")]
	public static ADECFLPGGBM MHFGHAOHDDC(NKPHOHCBLCG AILPPENJINK, int MLFDOFFDKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x610EE80", Offset = "0x610E080", VA = "0x18610EE80")]
	public static bool ALGNPALFLHO(this NKPHOHCBLCG AILPPENJINK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x610F130", Offset = "0x610E330", VA = "0x18610F130")]
	public static void DEFDPHIFOCB(NKPHOHCBLCG AILPPENJINK, float3 DNNAFGIPDDD, out EADFKOMGNHC ILLCKCDBLKO, out float3 IJINGPIGLFO, out float AEBNJADNHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x610F950", Offset = "0x610EB50", VA = "0x18610F950")]
	public static void PPAHNAKAFHI(Vector3 DNNAFGIPDDD, NKPHOHCBLCG AILPPENJINK, out Vector3 IJINGPIGLFO, out float AEBNJADNHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x610F350", Offset = "0x610E550", VA = "0x18610F350")]
	[ODBBCFLHGDG(BHNMFCNEJDF.ExitingPlayMode, 0)]
	private static void MAFICKIJKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x610EEA0", Offset = "0x610E0A0", VA = "0x18610EEA0")]
	[ODBBCFLHGDG(BHNMFCNEJDF.ExitingPlayMode, 0)]
	private static void BGEDMJLBJLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NDIBENAPAEL
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool MBLFHHHLGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material IOEAOBLOCKE();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material AEMLIBLIAIB();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DFDPGGMHIBF();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OEONMOJJHEA(FFPHIEMGAFF BKPOIPFKFKH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IDMKNAGAADD(JFDLEDMKPLI KKMNPEOKIAJ);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HNGEICHILDH(GameObject ADHHHFDPAPI);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MKHNHOJOKNF(GameObject ADHHHFDPAPI, bool HPNDBJDDCEH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface MMHLAKAADCF
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JCLDAIFDHJA OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KDMJDPBIKEE OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PJNMBFPGILE OMKECOOHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[DefaultMember("Item")]
	[MBALNPKLAGP(FOFKCKDBIPD.ShapeRendering)]
	public class ShapeRendererManager : BFHNEKCIHMC, IDisposable, MMHLAKAADCF
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::DMAGMEFKJPD<LPLINAKPAHH, JCLDAIFDHJA> NHCNGFJEBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::DMAGMEFKJPD<FJKCPBNOJEN, KDMJDPBIKEE> IDBELADJMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::DMAGMEFKJPD<BJGIPCBONCO, PJNMBFPGILE> BBNLPBDPCLB;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static NDIBENAPAEL POPEPFOGGDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x6114E40", Offset = "0x6114040", VA = "0x186114E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6114FC0", Offset = "0x61141C0", VA = "0x186114FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public JCLDAIFDHJA OMKECOOHJIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6114F00", Offset = "0x6114100", VA = "0x186114F00", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public KDMJDPBIKEE OMKECOOHJIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6114F60", Offset = "0x6114160", VA = "0x186114F60", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public PJNMBFPGILE OMKECOOHJIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6114EA0", Offset = "0x61140A0", VA = "0x186114EA0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6115220", Offset = "0x6114420", VA = "0x186115220")]
		public ShapeRendererManager(NDIBENAPAEL KEFIAFBPOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6114920", Offset = "0x6113B20", VA = "0x186114920", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6114D40", Offset = "0x6113F40", VA = "0x186114D40", Slot = "4")]
		public LPLINAKPAHH JNAPKJHLMPJ(CAAEMMJFMON ONIBEFDCPGD)
		{
			return default(LPLINAKPAHH);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x61149B0", Offset = "0x6113BB0", VA = "0x1861149B0", Slot = "5")]
		public void ECPCLLOPABA(LPLINAKPAHH LBGMPPHBAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6114CC0", Offset = "0x6113EC0", VA = "0x186114CC0", Slot = "6")]
		public void HFLEBMEBODA(LPLINAKPAHH LBGMPPHBAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6114BB0", Offset = "0x6113DB0", VA = "0x186114BB0", Slot = "7")]
		public FJKCPBNOJEN GDILPKHOKNC(LPLINAKPAHH LBGMPPHBAAC, NGNDKDFALJK ONIBEFDCPGD)
		{
			return default(FJKCPBNOJEN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6114A10", Offset = "0x6113C10", VA = "0x186114A10", Slot = "8")]
		public FJKCPBNOJEN FHDJPNKCIGK(LPLINAKPAHH LBGMPPHBAAC, CKIBAPLBMKC ONIBEFDCPGD)
		{
			return default(FJKCPBNOJEN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6114B20", Offset = "0x6113D20", VA = "0x186114B20", Slot = "10")]
		public void FNHMNKLGOJD(FJKCPBNOJEN MNJCHLDPJOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6114860", Offset = "0x6113A60", VA = "0x186114860", Slot = "9")]
		public void CHDGMECFDOE(FJKCPBNOJEN MNJCHLDPJOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6114330", Offset = "0x6113530", VA = "0x186114330", Slot = "15")]
		public IEnumerable<Renderer> AOGHFNGCIOE(LPLINAKPAHH LBGMPPHBAAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6115030", Offset = "0x6114230", VA = "0x186115030", Slot = "11")]
		public BJGIPCBONCO MMNELINBPMK(PKHEKDIBMDF ONIBEFDCPGD)
		{
			return default(BJGIPCBONCO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61143F0", Offset = "0x61135F0", VA = "0x1861143F0", Slot = "13")]
		public void BFAICCHAIHL(BJGIPCBONCO NFHNDHDBNCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x61148C0", Offset = "0x6113AC0", VA = "0x1861148C0", Slot = "12")]
		public void COEHBNKLJGE(BJGIPCBONCO NFHNDHDBNCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6114460", Offset = "0x6113660", VA = "0x186114460", Slot = "14")]
		public IKPIJFLHOMC CBNOMLAOGOM(CEIHGOGAJAB NACJECHPLOP, IEnumerable<FJKCPBNOJEN> IDBELADJMGE, int MLCGNHBPCEC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PJNMBFPGILE : ALHJIDNONPB
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class CAGBHDMBMAE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public PJNMBFPGILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
		[DebuggerHidden]
		public CAGBHDMBMAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x610A370", Offset = "0x6109570", VA = "0x18610A370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x610A090", Offset = "0x6109290", VA = "0x18610A090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x610A3F0", Offset = "0x61095F0", VA = "0x18610A3F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x610A330", Offset = "0x6109530", VA = "0x18610A330", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x610A290", Offset = "0x6109490", VA = "0x18610A290", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x610A290", Offset = "0x6109490", VA = "0x18610A290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly PKHEKDIBMDF DACFKEKCNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly MMHLAKAADCF EDDHCMFMKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private MNFOCJBANCB NALNNELGENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<MJOFHEKFILD> FEMLCFHEPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<MJOFHEKFILD> OJEAFBPOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject EBGKJDCNACL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6111480", Offset = "0x6110680", VA = "0x186111480")]
	public static PJNMBFPGILE GEMCLCADFCL(PKHEKDIBMDF ONIBEFDCPGD, MMHLAKAADCF EDDHCMFMKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6111DE0", Offset = "0x6110FE0", VA = "0x186111DE0")]
	private PJNMBFPGILE(PKHEKDIBMDF ONIBEFDCPGD, MMHLAKAADCF EDDHCMFMKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6111890", Offset = "0x6110A90", VA = "0x186111890")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6111D70", Offset = "0x6110F70", VA = "0x186111D70")]
	[IteratorStateMachine(typeof(CAGBHDMBMAE))]
	public IEnumerable<Renderer> NAAFOPFACCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6110830", Offset = "0x610FA30", VA = "0x186110830", Slot = "4")]
	public void CAHEOPGPOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x61113E0", Offset = "0x61105E0", VA = "0x1861113E0")]
	private void EKCKEDGPFLK(Vector3 KEAOLNIPIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x61115F0", Offset = "0x61107F0", VA = "0x1861115F0")]
	public void KJAIMLDDOOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MJOFHEKFILD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct BOLGAOLKFMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public NJJOGHOKENA AKCHMCMCABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public CEIHGOGAJAB ALFBDGOBHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int KBKIBBFAFHP;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CJGENOEBCOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public MJOFHEKFILD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public DFHGDAFHKOH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<BOLGAOLKFMB> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public IKPIJFLHOMC combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public CJGENOEBCOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x610A440", Offset = "0x6109640", VA = "0x18610A440")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x610A4A0", Offset = "0x61096A0", VA = "0x18610A4A0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x610A4D0", Offset = "0x61096D0", VA = "0x18610A4D0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] EFLJPLFACJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private OADAJOPEHKJ KDOHIHGANKD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 FKIBAFDCLNF;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh BFCKHLMCFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FKMAENANAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A610", VA = "0x18076B410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x610E600", Offset = "0x610D800", VA = "0x18610E600")]
	public void HODFAJGKBAM(List<CEIHGOGAJAB> BKPNMBMMGKC, Matrix4x4[] AHLNHPFJLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x610DB60", Offset = "0x610CD60", VA = "0x18610DB60")]
	public static List<MJOFHEKFILD> BFPHDDBHNEE(List<JCLDAIFDHJA> JEMBDHKLHHL, DFHGDAFHKOH MLFDOFFDKGG, Bounds LIJLBDEDOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x610E190", Offset = "0x610D390", VA = "0x18610E190")]
	private JobHandle DCMNEHFLIMP(IKPIJFLHOMC HKECKBNGPLC, int DJJINHDMOAB, int COOCAACDKON, DFHGDAFHKOH MLFDOFFDKGG, List<BOLGAOLKFMB> MLOBDDAAOFA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x610E830", Offset = "0x610DA30", VA = "0x18610E830")]
	private void PENPBLNELGC(List<BOLGAOLKFMB> MLOBDDAAOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x610EA70", Offset = "0x610DC70", VA = "0x18610EA70")]
	private MJOFHEKFILD(List<BOLGAOLKFMB> MLOBDDAAOFA, int DJJINHDMOAB, int COOCAACDKON, DFHGDAFHKOH MLFDOFFDKGG, Bounds LIJLBDEDOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x610E570", Offset = "0x610D770", VA = "0x18610E570", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private MaterialPropertyBlock CKPKHKHAGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private MJOFHEKFILD NCKHOMLJJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<CEIHGOGAJAB> OLJDKFBHLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture FAALNHOCPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer KAPNHGHJHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader CGBBOIHGMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] DJOEOIFEAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int KCBNOGIFMPG;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer KGMNKPIIBBG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6E7140", Offset = "0x6E6340", VA = "0x1806E7140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int HHOFGLCPMLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6116450", Offset = "0x6115650", VA = "0x186116450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x61159F0", Offset = "0x6114BF0", VA = "0x1861159F0")]
		public static List<SkinnedShapeRenderer> Create(GameObject LBGMPPHBAAC, List<MJOFHEKFILD> HLCDPKEAHAC, List<CEIHGOGAJAB> OLJDKFBHLOC, Material OMOMAJDOPDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6115E00", Offset = "0x6115000", VA = "0x186115E00")]
		public void Init(MJOFHEKFILD NCKHOMLJJGL, List<CEIHGOGAJAB> OLJDKFBHLOC, Material OMOMAJDOPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x61163A0", Offset = "0x61155A0", VA = "0x1861163A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x61162F0", Offset = "0x61154F0", VA = "0x1861162F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x61162B0", Offset = "0x61154B0", VA = "0x1861162B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x61157C0", Offset = "0x61149C0", VA = "0x1861157C0")]
		private void BGNCOJACLHG(ScriptableRenderContext MAFDHEKFLMG, Camera[] BMPPKFLPLNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6115C40", Offset = "0x6114E40", VA = "0x186115C40")]
		private void HODFAJGKBAM(CommandBuffer IGLIAFKMJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : IIPLPEOFAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6116580", Offset = "0x6115780", VA = "0x186116580", Slot = "4")]
		public sealed override void FKBDNONAKOB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x610AB60", Offset = "0x6109D60", VA = "0x18610AB60")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x610AC70", Offset = "0x6109E70", VA = "0x18610AC70")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
	}
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
