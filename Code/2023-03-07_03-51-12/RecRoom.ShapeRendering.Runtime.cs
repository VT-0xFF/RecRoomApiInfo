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
public enum HBLJPDOBGPF
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
public static class PIOKIDBFBDI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6256470", Offset = "0x6255870", VA = "0x186256470")]
	public static bool EJPMCBEIAPC(this HBLJPDOBGPF ADAHOCKEEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6256490", Offset = "0x6255890", VA = "0x186256490")]
	public static bool GGMOLKGMPNE(this HBLJPDOBGPF ADAHOCKEEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62564A0", Offset = "0x62558A0", VA = "0x1862564A0")]
	public static bool JDDIIPJLGML(this HBLJPDOBGPF ADAHOCKEEDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AEEHPBNLKOH
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
public enum GFPOEGOHIHM
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
public enum DCLGFICIGHE
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
public enum GNACOFDONPN
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
public class LAFLMKIMLAJ : KMBDBMOGHID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte MCILGGAPGBJ = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte MAOOOPGCCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] LBMLMLKACMM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BHHKICPLJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x764360", Offset = "0x763760", VA = "0x180764360", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D2840", Offset = "0x8D1C40", VA = "0x1808D2840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NGJEJAKLJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D4020", Offset = "0x8D3420", VA = "0x1808D4020", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F1F30", Offset = "0x9F1330", VA = "0x1809F1F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JPEBGDILBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA63CC0", Offset = "0xA630C0", VA = "0x180A63CC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA641C0", Offset = "0xA635C0", VA = "0x180A641C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BCCEGGHBCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA4BE50", Offset = "0xA4B250", VA = "0x180A4BE50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA4BE80", Offset = "0xA4B280", VA = "0x180A4BE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> ILGJFBOOPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6251B00", Offset = "0x6250F00", VA = "0x186251B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> LBFDPCOMLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1798A30", Offset = "0x1797E30", VA = "0x181798A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject COIMCDBNODG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte NMABHFCAEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6251BA0", Offset = "0x6250FA0", VA = "0x186251BA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6251BF0", Offset = "0x6250FF0", VA = "0x186251BF0")]
	public LAFLMKIMLAJ(List<GCGEOOFOJBF> PEBHHCOGPNM, List<GCGEOOFOJBF> HFEPHCIKCHP, List<OMCAPBCJMAM> EBJBKHDPEGG, Material GFMNLHKBBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62516D0", Offset = "0x6250AD0", VA = "0x1862516D0")]
	private int AHILECFHGIA(List<GCGEOOFOJBF> IMKLLELGOPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6251910", Offset = "0x6250D10", VA = "0x186251910")]
	private void EJFCBMOEHAM(int NJMNGACJKGK, bool KLHFMFBLIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6251A60", Offset = "0x6250E60", VA = "0x186251A60")]
	public void GHBLEEMLICE(Vector3 GDGCBACLBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62517E0", Offset = "0x6250BE0", VA = "0x1862517E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6251B60", Offset = "0x6250F60", VA = "0x186251B60")]
	public void IENALMEHDCP(Transform NJPAFDLKLNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GMDNOMLAIFO : OFLMGJEKLAH, NDPGGMHAAOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IOKHMHLFFPK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GMDNOMLAIFO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public IOKHMHLFFPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x624F830", Offset = "0x624EC30", VA = "0x18624F830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x624F300", Offset = "0x624E700", VA = "0x18624F300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x624F930", Offset = "0x624ED30", VA = "0x18624F930")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x624F980", Offset = "0x624ED80", VA = "0x18624F980")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x624F9D0", Offset = "0x624EDD0", VA = "0x18624F9D0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x624F7F0", Offset = "0x624EBF0", VA = "0x18624F7F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x624F750", Offset = "0x624EB50", VA = "0x18624F750", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x624F750", Offset = "0x624EB50", VA = "0x18624F750", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GPDHNHGGAFK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GMDNOMLAIFO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public GPDHNHGGAFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x624EFD0", Offset = "0x624E3D0", VA = "0x18624EFD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x624EC10", Offset = "0x624E010", VA = "0x18624EC10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x624F0B0", Offset = "0x624E4B0", VA = "0x18624F0B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x624F100", Offset = "0x624E500", VA = "0x18624F100")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x624EF90", Offset = "0x624E390", VA = "0x18624EF90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x624EEF0", Offset = "0x624E2F0", VA = "0x18624EEF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x624EEF0", Offset = "0x624E2F0", VA = "0x18624EEF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly LAJGFPGAMFJ AAFCEFPPCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<JMAIFMFDKFC> EBMEJIHBDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> DIAIALPPOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer AEJKFONKHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool DNBEJACJGLP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<BDKNJDNNBGH> LFDANKPBDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EFAIIHAGCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x624E5C0", Offset = "0x624D9C0", VA = "0x18624E5C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OMCAPBCJMAM FLJPLCKMDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x624D890", Offset = "0x624CC90", VA = "0x18624D890", Slot = "7")]
		get
		{
			return default(OMCAPBCJMAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> NLBJFMDDAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7776A0", Offset = "0x776AA0", VA = "0x1807776A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x624EB70", Offset = "0x624DF70", VA = "0x18624EB70")]
	public GMDNOMLAIFO(LAJGFPGAMFJ MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x624DF90", Offset = "0x624D390", VA = "0x18624DF90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x624D960", Offset = "0x624CD60", VA = "0x18624D960")]
	public void BKCAAEBNAMB(JMAIFMFDKFC FPDEEIGGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x624DFC0", Offset = "0x624D3C0", VA = "0x18624DFC0")]
	public void GAMANBAONBG(JMAIFMFDKFC FPDEEIGGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x624E600", Offset = "0x624DA00", VA = "0x18624E600", Slot = "4")]
	public void PNFFFEPLIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x624E250", Offset = "0x624D650", VA = "0x18624E250")]
	public void LOGJNOLNCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x624E3D0", Offset = "0x624D7D0", VA = "0x18624E3D0")]
	private void MNPIEKMANOB(List<JMAIFMFDKFC> EBMEJIHBDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x624E300", Offset = "0x624D700", VA = "0x18624E300")]
	private static Material MIPDPMGMOIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x624E500", Offset = "0x624D900", VA = "0x18624E500")]
	private void MNPIEKMANOB(JMAIFMFDKFC FPDEEIGGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x624E080", Offset = "0x624D480", VA = "0x18624E080")]
	private void HLMCIJCPLBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x624DA70", Offset = "0x624CE70", VA = "0x18624DA70")]
	public void DKEMCOIEPIE(bool FDFKGGDIKPD, bool JNKEJNAPIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x624E150", Offset = "0x624D550", VA = "0x18624E150")]
	protected void IDLAALKABOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x624E550", Offset = "0x624D950", VA = "0x18624E550")]
	[IteratorStateMachine(typeof(IOKHMHLFFPK))]
	public IEnumerable<Renderer> OKJOOGLGIPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x624E1E0", Offset = "0x624D5E0", VA = "0x18624E1E0")]
	[IteratorStateMachine(typeof(GPDHNHGGAFK))]
	public IEnumerable<Renderer> LKHKHHIINDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class KMGPMGNNPEP : JMAIFMFDKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly MHIKMJGDLCN NOLGIDOJOKC;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6251680", Offset = "0x6250A80", VA = "0x186251680")]
	public KMGPMGNNPEP(GMDNOMLAIFO ALLJDBGIIHH, MHIKMJGDLCN MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6250B70", Offset = "0x624FF70", VA = "0x186250B70", Slot = "13")]
	public override int AHILECFHGIA(JDLMKNMMNON MLDNJMBGAAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6250D60", Offset = "0x6250160", VA = "0x186250D60", Slot = "14")]
	public override int CDMMHBMHKMG(JDLMKNMMNON MLDNJMBGAAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6250F50", Offset = "0x6250350", VA = "0x186250F50", Slot = "15")]
	public override void HBGLKJMDMNJ(JDLMKNMMNON MLDNJMBGAAN, MLIONDBIKMP CFKHNCJEKIA, int KDDBPICKOME = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OJNPAIPIBBJ : global::JNPHCKODDEF<OJNPAIPIBBJ>, IKDLAGIDJHG, IEquatable<OJNPAIPIBBJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int JNPBIMHEMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int OABDMKOGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x829550", Offset = "0x828950", VA = "0x180829550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x829560", Offset = "0x828960", VA = "0x180829560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NFDBEOJPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6254B50", Offset = "0x6253F50", VA = "0x186254B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2B0", Offset = "0x7B96B0", VA = "0x1807BA2B0", Slot = "8")]
	public bool Equals(OJNPAIPIBBJ FJLHJLAMLMA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1652BE0", Offset = "0x1651FE0", VA = "0x181652BE0")]
	public static bool OACFLELFBPC(OJNPAIPIBBJ KEPOHMNFLGL, OJNPAIPIBBJ CFEKEMJOJGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1652C00", Offset = "0x1652000", VA = "0x181652C00")]
	public static bool OFLJMIEJHAG(OJNPAIPIBBJ KEPOHMNFLGL, OJNPAIPIBBJ CFEKEMJOJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6254AC0", Offset = "0x6253EC0", VA = "0x186254AC0", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6254B90", Offset = "0x6253F90", VA = "0x186254B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FEGMBNLEAMN
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
public interface LAJGFPGAMFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OMCAPBCJMAM KJAFIIABLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FEGMBNLEAMN IJGCLIBNFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OHDFFCFHPNJ : global::JNPHCKODDEF<OHDFFCFHPNJ>, IKDLAGIDJHG, IEquatable<OHDFFCFHPNJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int JNPBIMHEMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int OABDMKOGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x829550", Offset = "0x828950", VA = "0x180829550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x829560", Offset = "0x828960", VA = "0x180829560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NFDBEOJPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62549F0", Offset = "0x6253DF0", VA = "0x1862549F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2B0", Offset = "0x7B96B0", VA = "0x1807BA2B0", Slot = "8")]
	public bool Equals(OHDFFCFHPNJ FJLHJLAMLMA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1652BE0", Offset = "0x1651FE0", VA = "0x181652BE0")]
	public static bool OACFLELFBPC(OHDFFCFHPNJ KEPOHMNFLGL, OHDFFCFHPNJ CFEKEMJOJGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1652C00", Offset = "0x1652000", VA = "0x181652C00")]
	public static bool OFLJMIEJHAG(OHDFFCFHPNJ KEPOHMNFLGL, OHDFFCFHPNJ CFEKEMJOJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6254960", Offset = "0x6253D60", VA = "0x186254960", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6254A30", Offset = "0x6253E30", VA = "0x186254A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BDDDOKKMLEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	OMCAPBCJMAM KJAFIIABLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float KKIAADFAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 NKANJDJIAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	HBLJPDOBGPF GBBAJOBPDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	AEEHPBNLKOH JPCHIHJGFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LBHELIJFHEF : BDDDOKKMLEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NKHOCAJHOBH LELODMMEBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NOJMHPEMGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MHIKMJGDLCN : BDDDOKKMLEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PGOGCHLEIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EDAJGKHNLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float PGLMBPIBCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int OLBJMLHANPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PDJLMINKKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int ENIKHPHDNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<OOGIOGAHEPL> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DIGNCNGJDDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBOGJCPHJAA(OJNPAIPIBBJ ALLJDBGIIHH, DCLGFICIGHE DBOMLKOOKNG);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBOGJCPHJAA(OHDFFCFHPNJ FPDEEIGGJMJ, DCLGFICIGHE DBOMLKOOKNG);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHAJGPCODPC(OHDFFCFHPNJ FPDEEIGGJMJ);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIKLMBNGGNF(OHDFFCFHPNJ FPDEEIGGJMJ);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCHIKJKKDOP();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LICOOFFNEJK();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NNJCLNPHJCI(DCLGFICIGHE BKGBGEHNCAE);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KLEBEKPGNPP(OJNPAIPIBBJ ALLJDBGIIHH);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KLEBEKPGNPP(OHDFFCFHPNJ FPDEEIGGJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HMPLPDLOJIC(OJNPAIPIBBJ ALLJDBGIIHH, GNACOFDONPN BKGBGEHNCAE);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HMPLPDLOJIC(OHDFFCFHPNJ FPDEEIGGJMJ, GNACOFDONPN BKGBGEHNCAE);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BLNCGOEHDPC(OHDFFCFHPNJ FPDEEIGGJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MPJKBLNEBDC(OHDFFCFHPNJ FPDEEIGGJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HHCFJALMCPL();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CDMMJGKIBKK();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KDPNJEEPDHI(GNACOFDONPN BKGBGEHNCAE);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KFFGBPBBPBL(OJNPAIPIBBJ ALLJDBGIIHH, Vector3 AMMAKEOBBJJ, Vector3 PJAFEAKKLBH, Vector3 MCCPINMAICM, float GOFHEIDILLI, float NCIGLBPLFBJ, IReadOnlyList<Camera> BHOBBJIBNDJ, GFPOEGOHIHM IDLJGEENLJN);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KFFGBPBBPBL(KIBDIDOPLBB ONEGOLCGOLF, Vector3 AMMAKEOBBJJ, Vector3 PJAFEAKKLBH, Vector3 MCCPINMAICM, float GOFHEIDILLI, float NCIGLBPLFBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IKIMDJHEAOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJNPAIPIBBJ HDADAPAODEK(LAJGFPGAMFJ MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLJACCOMPJF(OJNPAIPIBBJ ALLJDBGIIHH);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEMDGLJLLGA(OJNPAIPIBBJ ALLJDBGIIHH);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OHDFFCFHPNJ JDNFDLICCLM(OJNPAIPIBBJ ALLJDBGIIHH, LBHELIJFHEF MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OHDFFCFHPNJ PDLGGFFGJOK(OJNPAIPIBBJ ALLJDBGIIHH, MHIKMJGDLCN MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFNFKCFLNGL(OHDFFCFHPNJ FPDEEIGGJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AANJHGLCKJB(OHDFFCFHPNJ FPDEEIGGJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KIBDIDOPLBB GNDGHFDJLMK(NOGGGEDJPNO MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void APJMALMIJFG(KIBDIDOPLBB ONEGOLCGOLF);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HKIPMBHOEBO(KIBDIDOPLBB ONEGOLCGOLF);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HONFDINMKCH CPFIDKAIPGE(OMCAPBCJMAM ANNJLIFPNBO, IEnumerable<OHDFFCFHPNJ> EBMEJIHBDHE, int GIALMNBBFDG);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> MDBCIPGANCI(OJNPAIPIBBJ ALLJDBGIIHH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KIBDIDOPLBB : global::JNPHCKODDEF<KIBDIDOPLBB>, IKDLAGIDJHG, IEquatable<KIBDIDOPLBB>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int JNPBIMHEMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int OABDMKOGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x829550", Offset = "0x828950", VA = "0x180829550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x829560", Offset = "0x828960", VA = "0x180829560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NFDBEOJPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6250B30", Offset = "0x624FF30", VA = "0x186250B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2B0", Offset = "0x7B96B0", VA = "0x1807BA2B0", Slot = "8")]
	public bool Equals(KIBDIDOPLBB FJLHJLAMLMA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1652BE0", Offset = "0x1651FE0", VA = "0x181652BE0")]
	public static bool OACFLELFBPC(KIBDIDOPLBB KEPOHMNFLGL, KIBDIDOPLBB CFEKEMJOJGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1652C00", Offset = "0x1652000", VA = "0x181652C00")]
	public static bool OFLJMIEJHAG(KIBDIDOPLBB KEPOHMNFLGL, KIBDIDOPLBB CFEKEMJOJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6250AA0", Offset = "0x624FEA0", VA = "0x186250AA0", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NOGGGEDJPNO
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int DHAHAAMPBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform OJCKKELFNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool GEOJBLFEHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OJNPAIPIBBJ GetBone(int GAJNAGMOBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int GAJNAGMOBEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class PBGJFJJFJNE : JMAIFMFDKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly LBHELIJFHEF KMLBNPHBCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] HHALPMBPKJN;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override PIGAFIJALMO POPCCFNJFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6255C50", Offset = "0x6255050", VA = "0x186255C50", Slot = "12")]
		get
		{
			return default(PIGAFIJALMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 PPGIJEEGEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6255030", Offset = "0x6254430", VA = "0x186255030")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6251680", Offset = "0x6250A80", VA = "0x186251680")]
	public PBGJFJJFJNE(GMDNOMLAIFO ALLJDBGIIHH, LBHELIJFHEF MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6256000", Offset = "0x6255400", VA = "0x186256000", Slot = "11")]
	public override bool MKELFOBMKAO(OMCAPBCJMAM ALLJDBGIIHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6254C20", Offset = "0x6254020", VA = "0x186254C20", Slot = "13")]
	public override int AHILECFHGIA(JDLMKNMMNON MLDNJMBGAAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6254CD0", Offset = "0x62540D0", VA = "0x186254CD0", Slot = "14")]
	public override int CDMMHBMHKMG(JDLMKNMMNON MLDNJMBGAAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6254D80", Offset = "0x6254180", VA = "0x186254D80")]
	private int FKCFIPAIOCJ(JDLMKNMMNON MLDNJMBGAAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6255370", Offset = "0x6254770", VA = "0x186255370", Slot = "15")]
	public override void HBGLKJMDMNJ(JDLMKNMMNON MLDNJMBGAAN, MLIONDBIKMP CFKHNCJEKIA, int KDDBPICKOME = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GBBGPJFOPOC
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBNOKBGCKAD(GNACOFDONPN BKGBGEHNCAE, Renderer IDILMIMGPKP, int LFMDEJHOPJD);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMMKOFMIOCA(Renderer IDILMIMGPKP, GFPOEGOHIHM IDLJGEENLJN, Vector3 AMMAKEOBBJJ, Vector3 PJAFEAKKLBH, Vector3 MCCPINMAICM, float GOFHEIDILLI, float NCIGLBPLFBJ, float DHFFEDKADCC = -1f, [Optional] Color? EELAMBEFNPK, [Optional] IReadOnlyList<Camera> MMJEPJHMBBD);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHJNOEELADA(Renderer IDILMIMGPKP, int LFMDEJHOPJD);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KCJJIBBAGJC();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJLGPOLIGDA(int DCALMGEJEFJ, DCLGFICIGHE BKGBGEHNCAE, Renderer IDILMIMGPKP, int LFMDEJHOPJD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MGFLAJJKPDB : DIGNCNGJDDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class GHILBCIONKD : global::GNPCCEEGHEK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x624D840", Offset = "0x624CC40", VA = "0x18624D840")]
		public GHILBCIONKD(string LBEPPIIBMPA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly GBBGPJFOPOC MCNODGDCIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly MFHHOHDOMFP FHKHCFLLAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer BBNHALFOGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private GHILBCIONKD FOCACLKIKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool IFJDKMGPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer AKGPGJKHJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private GHILBCIONKD PEDMNENKFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool AHCAOPBBIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer EDEGPHMODGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private GHILBCIONKD GGEKICALOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x77E010", Offset = "0x77D410", VA = "0x18077E010")]
	public MGFLAJJKPDB(GBBGPJFOPOC ODNOMIKLGCC, MFHHOHDOMFP FHKHCFLLAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62523A0", Offset = "0x62517A0", VA = "0x1862523A0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6252BF0", Offset = "0x6251FF0", VA = "0x186252BF0")]
	private void IOBDDPNKMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6254040", Offset = "0x6253440", VA = "0x186254040", Slot = "4")]
	public void OBOGJCPHJAA(OJNPAIPIBBJ ALLJDBGIIHH, DCLGFICIGHE DBOMLKOOKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6253E20", Offset = "0x6253220", VA = "0x186253E20", Slot = "5")]
	public void OBOGJCPHJAA(OHDFFCFHPNJ FPDEEIGGJMJ, DCLGFICIGHE DBOMLKOOKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6252190", Offset = "0x6251590", VA = "0x186252190", Slot = "6")]
	public void AHAJGPCODPC(OHDFFCFHPNJ FPDEEIGGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6254240", Offset = "0x6253640", VA = "0x186254240", Slot = "7")]
	public void OIKLMBNGGNF(OHDFFCFHPNJ FPDEEIGGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62522C0", Offset = "0x62516C0", VA = "0x1862522C0", Slot = "8")]
	public void BCHIKJKKDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x209C6D0", Offset = "0x209BAD0", VA = "0x18209C6D0", Slot = "9")]
	public void LICOOFFNEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6253CB0", Offset = "0x62530B0", VA = "0x186253CB0", Slot = "10")]
	public void NNJCLNPHJCI(DCLGFICIGHE DBOMLKOOKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6253A70", Offset = "0x6252E70", VA = "0x186253A70", Slot = "11")]
	public void KLEBEKPGNPP(OJNPAIPIBBJ ALLJDBGIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6253720", Offset = "0x6252B20", VA = "0x186253720", Slot = "12")]
	public void KLEBEKPGNPP(OHDFFCFHPNJ FPDEEIGGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6252840", Offset = "0x6251C40", VA = "0x186252840", Slot = "13")]
	public void HMPLPDLOJIC(OJNPAIPIBBJ ALLJDBGIIHH, GNACOFDONPN BKGBGEHNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6252A00", Offset = "0x6251E00", VA = "0x186252A00", Slot = "14")]
	public void HMPLPDLOJIC(OHDFFCFHPNJ FPDEEIGGJMJ, GNACOFDONPN BKGBGEHNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6252640", Offset = "0x6251A40", VA = "0x186252640", Slot = "17")]
	public void HHCFJALMCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6252300", Offset = "0x6251700", VA = "0x186252300", Slot = "15")]
	public void BLNCGOEHDPC(OHDFFCFHPNJ FPDEEIGGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6253C20", Offset = "0x6253020", VA = "0x186253C20", Slot = "16")]
	public void MPJKBLNEBDC(OHDFFCFHPNJ FPDEEIGGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1600", Offset = "0x1CD0A00", VA = "0x181CD1600", Slot = "18")]
	public void CDMMJGKIBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6252E40", Offset = "0x6252240", VA = "0x186252E40", Slot = "19")]
	public void KDPNJEEPDHI(GNACOFDONPN BKGBGEHNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6254360", Offset = "0x6253760", VA = "0x186254360")]
	private void PKDIDEODMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6252680", Offset = "0x6251A80", VA = "0x186252680")]
	public void HMPLPDLOJIC(OHDFFCFHPNJ FPDEEIGGJMJ, GNACOFDONPN BKGBGEHNCAE, bool KKMPBIDHLEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6252570", Offset = "0x6251970", VA = "0x186252570")]
	private void EBNOKBGCKAD(GNACOFDONPN BKGBGEHNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x62533A0", Offset = "0x62527A0", VA = "0x1862533A0", Slot = "20")]
	public void KFFGBPBBPBL(OJNPAIPIBBJ ALLJDBGIIHH, Vector3 AMMAKEOBBJJ, Vector3 PJAFEAKKLBH, Vector3 MCCPINMAICM, float GOFHEIDILLI, float NCIGLBPLFBJ, IReadOnlyList<Camera> BHOBBJIBNDJ, GFPOEGOHIHM IDLJGEENLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6252F80", Offset = "0x6252380", VA = "0x186252F80", Slot = "21")]
	public void KFFGBPBBPBL(KIBDIDOPLBB ONEGOLCGOLF, Vector3 AMMAKEOBBJJ, Vector3 PJAFEAKKLBH, Vector3 MCCPINMAICM, float GOFHEIDILLI, float NCIGLBPLFBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class JMAIFMFDKFC : MNJIGIEFHFP, BDKNJDNNBGH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly GMDNOMLAIFO COIMCDBNODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds ABJAMBPELPA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds DELDAKIGGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1A248F0", Offset = "0x1A23CF0", VA = "0x181A248F0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual PIGAFIJALMO POPCCFNJFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x624FAF0", Offset = "0x624EEF0", VA = "0x18624FAF0", Slot = "12")]
		get
		{
			return default(PIGAFIJALMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	protected JMAIFMFDKFC(GMDNOMLAIFO ALLJDBGIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x624FA20", Offset = "0x624EE20", VA = "0x18624FA20", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "11")]
	public virtual bool MKELFOBMKAO(OMCAPBCJMAM ALLJDBGIIHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int AHILECFHGIA(JDLMKNMMNON MLDNJMBGAAN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int CDMMHBMHKMG(JDLMKNMMNON MLDNJMBGAAN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void HBGLKJMDMNJ(JDLMKNMMNON MLDNJMBGAAN, MLIONDBIKMP CFKHNCJEKIA, int KDDBPICKOME = -1);
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
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
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
		[Cpp2IlInjected.Address(RVA = "0x62564D0", Offset = "0x62558D0", VA = "0x1862564D0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NKHOCAJHOBH
{
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class JPPGILCLEMB
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HFFHJNNPGGN : IEnumerable<BCJDHOKGPNE>, IEnumerable, IEnumerator<BCJDHOKGPNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private BCJDHOKGPNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private BCJDHOKGPNE System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public HFFHJNNPGGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x624F150", Offset = "0x624E550", VA = "0x18624F150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x624F2C0", Offset = "0x624E6C0", VA = "0x18624F2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x624F230", Offset = "0x624E630", VA = "0x18624F230", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BCJDHOKGPNE> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x624F230", Offset = "0x624E630", VA = "0x18624F230", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const int IOGOMLCAPCL = 3;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static BCJDHOKGPNE[][] EHBCCFGHNOG;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static EDGANOMFELB AHOGCOLABDM;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static ShapeRendererConfig LJAKADNMBMC;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader DPJAFBFCKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x624FDB0", Offset = "0x624F1B0", VA = "0x18624FDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer LANBIDGDKON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6250750", Offset = "0x624FB50", VA = "0x186250750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6250920", Offset = "0x624FD20", VA = "0x186250920")]
	public static Mesh OAFIABINPHB(NKHOCAJHOBH IMNFGMOPIEI, int MLDNJMBGAAN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x62503E0", Offset = "0x624F7E0", VA = "0x1862503E0")]
	public static int MDPCAMLOGEO(NKHOCAJHOBH IMNFGMOPIEI, int MLDNJMBGAAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x62507C0", Offset = "0x624FBC0", VA = "0x1862507C0")]
	public static EDGANOMFELB NINBDGCJFNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x624FFD0", Offset = "0x624F3D0", VA = "0x18624FFD0")]
	[IteratorStateMachine(typeof(HFFHJNNPGGN))]
	private static IEnumerable<BCJDHOKGPNE> HOAJFCLDOPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62503F0", Offset = "0x624F7F0", VA = "0x1862503F0")]
	public static BCJDHOKGPNE MOFDKOBNBNL(NKHOCAJHOBH IMNFGMOPIEI, int MLDNJMBGAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x62509E0", Offset = "0x624FDE0", VA = "0x1862509E0")]
	public static bool OMBONENNFEA(this NKHOCAJHOBH IMNFGMOPIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x624FE20", Offset = "0x624F220", VA = "0x18624FE20")]
	public static void EBOBDMAHJAF(NKHOCAJHOBH IMNFGMOPIEI, float3 GGIAMAIKDCO, out CHCAKJKOADE LLMLMIANAOP, out float3 AAEELBLPHNM, out float KHLMJMIBLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6250030", Offset = "0x624F430", VA = "0x186250030")]
	public static void MBGDEILJDOO(Vector3 GGIAMAIKDCO, NKHOCAJHOBH IMNFGMOPIEI, out Vector3 AAEELBLPHNM, out float KHLMJMIBLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x624FDA0", Offset = "0x624F1A0", VA = "0x18624FDA0")]
	[MDHPGGNLEAB(GDPBHGFFFDB.ExitingPlayMode, 0)]
	private static void DLKLEEAPPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x624FB80", Offset = "0x624EF80", VA = "0x18624FB80")]
	[MDHPGGNLEAB(GDPBHGFFFDB.ExitingPlayMode, 0)]
	private static void CHMDLGMDGJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MHLMHAKHKPP
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool DKNEOADBOMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material LKNHPCNKNPO();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MIPDPMGMOIL();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material CDGFIDOJBAL();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PCCCJGBIMFF(HBLJPDOBGPF ADAHOCKEEDH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ECKPBAJLBND(AEEHPBNLKOH KFNLPFFBINE);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CFILAEKFLIF(GameObject JGHFLANLLNE);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FMHIAMDOMAK(GameObject JGHFLANLLNE, bool ECJAFEBFJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface MFHHOHDOMFP
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GMDNOMLAIFO CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JMAIFMFDKFC CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BCDBDFKOPLE CLGONNHLFJK
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
	[NAPHGBOEKGO(GPIMBHHJLKL.ShapeRendering)]
	public class ShapeRendererManager : IKIMDJHEAOA, IDisposable, MFHHOHDOMFP
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly global::MJIHJJBKGCN<OJNPAIPIBBJ, GMDNOMLAIFO> CJKABDECIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly global::MJIHJJBKGCN<OHDFFCFHPNJ, JMAIFMFDKFC> EBMEJIHBDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly global::MJIHJJBKGCN<KIBDIDOPLBB, BCDBDFKOPLE> HBHJDJFLCNJ;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static MHLMHAKHKPP NGNPEKHGGCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x6256710", Offset = "0x6255B10", VA = "0x186256710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x62570A0", Offset = "0x62564A0", VA = "0x1862570A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public GMDNOMLAIFO CLGONNHLFJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x62565F0", Offset = "0x62559F0", VA = "0x1862565F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public JMAIFMFDKFC CLGONNHLFJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x62566B0", Offset = "0x6255AB0", VA = "0x1862566B0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public BCDBDFKOPLE CLGONNHLFJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6256650", Offset = "0x6255A50", VA = "0x186256650", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x62573F0", Offset = "0x62567F0", VA = "0x1862573F0")]
		public ShapeRendererManager(MHLMHAKHKPP ODNOMIKLGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6256B70", Offset = "0x6255F70", VA = "0x186256B70", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6256DA0", Offset = "0x62561A0", VA = "0x186256DA0", Slot = "4")]
		public OJNPAIPIBBJ HDADAPAODEK(LAJGFPGAMFJ MPEBBGJJODN)
		{
			return default(OJNPAIPIBBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6257110", Offset = "0x6256510", VA = "0x186257110", Slot = "5")]
		public void JLJACCOMPJF(OJNPAIPIBBJ ALLJDBGIIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6256EA0", Offset = "0x62562A0", VA = "0x186256EA0", Slot = "6")]
		public void HEMDGLJLLGA(OJNPAIPIBBJ ALLJDBGIIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6256F90", Offset = "0x6256390", VA = "0x186256F90", Slot = "7")]
		public OHDFFCFHPNJ JDNFDLICCLM(OJNPAIPIBBJ ALLJDBGIIHH, LBHELIJFHEF MPEBBGJJODN)
		{
			return default(OHDFFCFHPNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6257290", Offset = "0x6256690", VA = "0x186257290", Slot = "8")]
		public OHDFFCFHPNJ PDLGGFFGJOK(OJNPAIPIBBJ ALLJDBGIIHH, MHIKMJGDLCN MPEBBGJJODN)
		{
			return default(OHDFFCFHPNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6256500", Offset = "0x6255900", VA = "0x186256500", Slot = "10")]
		public void AANJHGLCKJB(OHDFFCFHPNJ FPDEEIGGJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6257230", Offset = "0x6256630", VA = "0x186257230", Slot = "9")]
		public void MFNFKCFLNGL(OHDFFCFHPNJ FPDEEIGGJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6257170", Offset = "0x6256570", VA = "0x186257170", Slot = "15")]
		public IEnumerable<Renderer> MDBCIPGANCI(OJNPAIPIBBJ ALLJDBGIIHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6256C00", Offset = "0x6256000", VA = "0x186256C00", Slot = "11")]
		public KIBDIDOPLBB GNDGHFDJLMK(NOGGGEDJPNO MPEBBGJJODN)
		{
			return default(KIBDIDOPLBB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6256F20", Offset = "0x6256320", VA = "0x186256F20", Slot = "13")]
		public void HKIPMBHOEBO(KIBDIDOPLBB ONEGOLCGOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6256590", Offset = "0x6255990", VA = "0x186256590", Slot = "12")]
		public void APJMALMIJFG(KIBDIDOPLBB ONEGOLCGOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6256770", Offset = "0x6255B70", VA = "0x186256770", Slot = "14")]
		public HONFDINMKCH CPFIDKAIPGE(OMCAPBCJMAM IDOMKJJFLEK, IEnumerable<OHDFFCFHPNJ> EBMEJIHBDHE, int GIALMNBBFDG)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BCDBDFKOPLE : OFLMGJEKLAH
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OBPPOAJPEKO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public BCDBDFKOPLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public OBPPOAJPEKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6254890", Offset = "0x6253C90", VA = "0x186254890", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x62545B0", Offset = "0x62539B0", VA = "0x1862545B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6254910", Offset = "0x6253D10", VA = "0x186254910")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6254850", Offset = "0x6253C50", VA = "0x186254850", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62547B0", Offset = "0x6253BB0", VA = "0x1862547B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x62547B0", Offset = "0x6253BB0", VA = "0x1862547B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly NOGGGEDJPNO LNJKFCMMAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly MFHHOHDOMFP FHKHCFLLAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private LAFLMKIMLAJ PEDECDPBCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<GCGEOOFOJBF> MBBLHDPDJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private List<GCGEOOFOJBF> NAIAKPDEJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private GameObject CBNAJHPGOGB;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x624B3F0", Offset = "0x624A7F0", VA = "0x18624B3F0")]
	public static BCDBDFKOPLE KELHEDKDLAO(NOGGGEDJPNO MPEBBGJJODN, MFHHOHDOMFP FHKHCFLLAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x624C420", Offset = "0x624B820", VA = "0x18624C420")]
	private BCDBDFKOPLE(NOGGGEDJPNO MPEBBGJJODN, MFHHOHDOMFP FHKHCFLLAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x624AF10", Offset = "0x624A310", VA = "0x18624AF10")]
	public void IDPLHJEPBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x624B800", Offset = "0x624AC00", VA = "0x18624B800")]
	[IteratorStateMachine(typeof(OBPPOAJPEKO))]
	public IEnumerable<Renderer> OKJOOGLGIPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x624B870", Offset = "0x624AC70", VA = "0x18624B870", Slot = "4")]
	public void PNFFFEPLIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x624AE70", Offset = "0x624A270", VA = "0x18624AE70")]
	private void FKCAPMAKFJF(Vector3 GDGCBACLBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x624B560", Offset = "0x624A960", VA = "0x18624B560")]
	public void LOGJNOLNCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GCGEOOFOJBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct IIBPKMHFBEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public MLIONDBIKMP KOAGOHFIFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public OMCAPBCJMAM HCIBKDENMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int ENFMFGIKGLL;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class LFHNKIMPPEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public GCGEOOFOJBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JDLMKNMMNON lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<IIBPKMHFBEE> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public HONFDINMKCH combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LFHNKIMPPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6251FB0", Offset = "0x62513B0", VA = "0x186251FB0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6252010", Offset = "0x6251410", VA = "0x186252010")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6252040", Offset = "0x6251440", VA = "0x186252040")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int[] MAABNFMBELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private PPAELHKJABF BNACDJGDDGA;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static Matrix4x4 KDNKOLOOMGL;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh AFMLJDPEFDC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int AIGEFJMLLAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x705BB0", Offset = "0x704FB0", VA = "0x180705BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x624CAA0", Offset = "0x624BEA0", VA = "0x18624CAA0")]
	public void JMCGKPNKKKJ(List<OMCAPBCJMAM> BHPCEJIOADE, Matrix4x4[] NAIBBOKIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x624CCD0", Offset = "0x624C0D0", VA = "0x18624CCD0")]
	public static List<GCGEOOFOJBF> PELCFOCODBC(List<GMDNOMLAIFO> NLGDKJBOGGP, JDLMKNMMNON MLDNJMBGAAN, Bounds BKEOBLCBLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x624C520", Offset = "0x624B920", VA = "0x18624C520")]
	private JobHandle BAFJBJPLCOJ(HONFDINMKCH PGIOIOKPDMC, int DEGDAMGPFGB, int NHKOCEAPKOJ, JDLMKNMMNON MLDNJMBGAAN, List<IIBPKMHFBEE> HKHNFFCKDED)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x624C990", Offset = "0x624BD90", VA = "0x18624C990")]
	private void EBNNGICABOI(List<IIBPKMHFBEE> HKHNFFCKDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x624D430", Offset = "0x624C830", VA = "0x18624D430")]
	private GCGEOOFOJBF(List<IIBPKMHFBEE> HKHNFFCKDED, int DEGDAMGPFGB, int NHKOCEAPKOJ, JDLMKNMMNON MLDNJMBGAAN, Bounds BKEOBLCBLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x624C900", Offset = "0x624BD00", VA = "0x18624C900", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private MaterialPropertyBlock HIFKAGCKBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private GCGEOOFOJBF HLAOHHBPGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private List<OMCAPBCJMAM> EBJBKHDPEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private RenderTexture DBHGCEHNCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private ComputeBuffer PKPEPADMEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private ComputeShader CMEECNHPGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Matrix4x4[] LIFLKONIMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private int NKFINDOPDAJ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer FNEKMPDDPGN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x77DF40", Offset = "0x77D340", VA = "0x18077DF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int DHAHAAMPBHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6258620", Offset = "0x6257A20", VA = "0x186258620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6257BC0", Offset = "0x6256FC0", VA = "0x186257BC0")]
		public static List<SkinnedShapeRenderer> Create(GameObject ALLJDBGIIHH, List<GCGEOOFOJBF> IMKLLELGOPK, List<OMCAPBCJMAM> EBJBKHDPEGG, Material GFMNLHKBBDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6257E10", Offset = "0x6257210", VA = "0x186257E10")]
		public void Init(GCGEOOFOJBF HLAOHHBPGAO, List<OMCAPBCJMAM> EBJBKHDPEGG, Material GFMNLHKBBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6258570", Offset = "0x6257970", VA = "0x186258570")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x62584C0", Offset = "0x62578C0", VA = "0x1862584C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6258480", Offset = "0x6257880", VA = "0x186258480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6257990", Offset = "0x6256D90", VA = "0x186257990")]
		private void BIJLCMLMFMK(ScriptableRenderContext OEGBAMNPENI, Camera[] EMLAAJGLAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x62582C0", Offset = "0x62576C0", VA = "0x1862582C0")]
		private void JMCGKPNKKKJ(CommandBuffer HFEPJLMHPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : AOMBDDGFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6258750", Offset = "0x6257B50", VA = "0x186258750", Slot = "4")]
		public sealed override void IPAAHMOMIKO()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x624AB90", Offset = "0x6249F90", VA = "0x18624AB90")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x624A840", Offset = "0x6249C40", VA = "0x18624A840")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
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

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
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
