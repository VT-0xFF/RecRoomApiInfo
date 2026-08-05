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
public enum PGCIAPKMFPE
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
public static class GDEJEOBJCEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C5ADD0", Offset = "0x5C5A1D0", VA = "0x185C5ADD0")]
	public static bool BOAOGBFJAFD(this PGCIAPKMFPE MAPBHFNAIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C5AE20", Offset = "0x5C5A220", VA = "0x185C5AE20")]
	public static bool KBLMFBJJEEL(this PGCIAPKMFPE MAPBHFNAIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C5ADF0", Offset = "0x5C5A1F0", VA = "0x185C5ADF0")]
	public static bool JPMEHJPOCFD(this PGCIAPKMFPE MAPBHFNAIPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NBKFCIMCJBO
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
public enum NFDNAJBNMKA
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
public enum IECBHBBCNMJ
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
public enum MHLFPCDALLC
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
public class FKOBEPFJKDI : IGJOHABGBAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte EKDNHGHKFAA = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte FPIHAFDPCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] GJJAKKPNCNC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MFBPNMHPKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x66D010", Offset = "0x66C410", VA = "0x18066D010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B6CC0", Offset = "0x6B60C0", VA = "0x1806B6CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ENPOFDHAPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68DD90", Offset = "0x68D190", VA = "0x18068DD90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83FEB0", Offset = "0x83F2B0", VA = "0x18083FEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float IIKEIKNEADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x104B970", Offset = "0x104AD70", VA = "0x18104B970", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x104B960", Offset = "0x104AD60", VA = "0x18104B960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float EOIGEGHMEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10FB0D0", Offset = "0x10FA4D0", VA = "0x1810FB0D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1361CD0", Offset = "0x13610D0", VA = "0x181361CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GJHGAMDGIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A860", Offset = "0x5C59C60", VA = "0x185C5A860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> EAANONOKIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x588D200", Offset = "0x588C600", VA = "0x18588D200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x705AE0", Offset = "0x704EE0", VA = "0x180705AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte LFJMHICOCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A6C0", Offset = "0x5C59AC0", VA = "0x185C5A6C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C5AA10", Offset = "0x5C59E10", VA = "0x185C5AA10")]
	public FKOBEPFJKDI(List<FJNGBEEOAKD> OCLNCAEKEBM, List<FJNGBEEOAKD> OGPLJMEABOA, List<JACNJHHOBDA> NNLCFMEJPEG, Material MLAANGECIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C5A710", Offset = "0x5C59B10", VA = "0x185C5A710")]
	private int IJKBFBAAAPJ(List<FJNGBEEOAKD> LACEFMPFLHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C5A8C0", Offset = "0x5C59CC0", VA = "0x185C5A8C0")]
	private void NCPFDJAMIDG(int KDJMJBLAEKL, bool LBKIMMBOFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C5A620", Offset = "0x5C59A20", VA = "0x185C5A620")]
	public void EMDJOLFCFCD(Vector3 FFBJJILBDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C5A4F0", Offset = "0x5C598F0", VA = "0x185C5A4F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C5A820", Offset = "0x5C59C20", VA = "0x185C5A820")]
	public void KFEMGIJHDHM(Transform ENCPDHOLPGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JNNEDFDIOFA : MEMLBCJBJNC, BGIHOGHELIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class INPCDINLEHH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JNNEDFDIOFA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
		[DebuggerHidden]
		public INPCDINLEHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5C5B990", Offset = "0x5C5AD90", VA = "0x185C5B990", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5C5B460", Offset = "0x5C5A860", VA = "0x185C5B460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5C5BA90", Offset = "0x5C5AE90", VA = "0x185C5BA90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5C5BAE0", Offset = "0x5C5AEE0", VA = "0x185C5BAE0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5C5BB30", Offset = "0x5C5AF30", VA = "0x185C5BB30")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5C5B950", Offset = "0x5C5AD50", VA = "0x185C5B950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5C5B8B0", Offset = "0x5C5ACB0", VA = "0x185C5B8B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5C5B8B0", Offset = "0x5C5ACB0", VA = "0x185C5B8B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CCCJGANCIHF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JNNEDFDIOFA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
		[DebuggerHidden]
		public CCCJGANCIHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5C56940", Offset = "0x5C55D40", VA = "0x185C56940", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5C56580", Offset = "0x5C55980", VA = "0x185C56580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5C56A20", Offset = "0x5C55E20", VA = "0x185C56A20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5C56A70", Offset = "0x5C55E70", VA = "0x185C56A70")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5C56900", Offset = "0x5C55D00", VA = "0x185C56900", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5C56860", Offset = "0x5C55C60", VA = "0x185C56860", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5C56860", Offset = "0x5C55C60", VA = "0x185C56860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly FMDIAAFHALA COHBIEBMIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<CMPCAADINDL> JLENKJLMMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> NNMHIGBOJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer HLIIDGEBOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool PLAIOGECLGE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<OOILBGJIPAL> AGOENCEGBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KAKENDDIPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5C5C710", Offset = "0x5C5BB10", VA = "0x185C5C710", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JACNJHHOBDA FAEMAJKJNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5C5C010", Offset = "0x5C5B410", VA = "0x185C5C010", Slot = "7")]
		get
		{
			return default(JACNJHHOBDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> IACMFGKBGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x674590", Offset = "0x673990", VA = "0x180674590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C5CFC0", Offset = "0x5C5C3C0", VA = "0x185C5CFC0")]
	public JNNEDFDIOFA(FMDIAAFHALA HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C5BE00", Offset = "0x5C5B200", VA = "0x185C5BE00", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C5BE30", Offset = "0x5C5B230", VA = "0x185C5BE30")]
	public void EIPAABBBFMM(CMPCAADINDL DAKPLJOPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C5C650", Offset = "0x5C5BA50", VA = "0x185C5C650")]
	public void GMLJNDAKNDK(CMPCAADINDL DAKPLJOPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C5C0E0", Offset = "0x5C5B4E0", VA = "0x185C5C0E0", Slot = "4")]
	public void FGOLPCEHPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C5BCE0", Offset = "0x5C5B0E0", VA = "0x185C5BCE0")]
	public void ADDBGNGPEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C5C820", Offset = "0x5C5BC20", VA = "0x185C5C820")]
	private void LEKJHOJLLLJ(List<CMPCAADINDL> JLENKJLMMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C5C750", Offset = "0x5C5BB50", VA = "0x185C5C750")]
	private static Material LCIGILPBLBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C5C950", Offset = "0x5C5BD50", VA = "0x185C5C950")]
	private void LEKJHOJLLLJ(CMPCAADINDL DAKPLJOPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C5BF40", Offset = "0x5C5B340", VA = "0x185C5BF40")]
	private void FANBLKPLOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C5CAA0", Offset = "0x5C5BEA0", VA = "0x185C5CAA0")]
	public void PNOONMKBOEC(bool EJPIMLBICPA, bool LLHMEABPDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C5C9A0", Offset = "0x5C5BDA0", VA = "0x185C5C9A0")]
	protected void OMMHPGBJNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C5BD90", Offset = "0x5C5B190", VA = "0x185C5BD90")]
	[IteratorStateMachine(typeof(INPCDINLEHH))]
	public IEnumerable<Renderer> CCFOKJJPGJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C5CA30", Offset = "0x5C5BE30", VA = "0x185C5CA30")]
	[IteratorStateMachine(typeof(CCCJGANCIHF))]
	public IEnumerable<Renderer> OOCAPFOGMKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class DJMEMCPPMOK : CMPCAADINDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly BFMLFHNABHH DFEKADPOLDI;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5C58310", Offset = "0x5C57710", VA = "0x185C58310")]
	public DJMEMCPPMOK(JNNEDFDIOFA JAFNHFEOMPI, BFMLFHNABHH HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5C58DE0", Offset = "0x5C581E0", VA = "0x185C58DE0", Slot = "13")]
	public override int IJKBFBAAAPJ(CFCICPKONAK HJPMNNIECBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5C584C0", Offset = "0x5C578C0", VA = "0x185C584C0", Slot = "14")]
	public override int CBDPKEHMHIH(CFCICPKONAK HJPMNNIECBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5C586B0", Offset = "0x5C57AB0", VA = "0x185C586B0", Slot = "15")]
	public override void HKNKLNBLCHG(CFCICPKONAK HJPMNNIECBA, CJGCOAKKICH GILJFEALDKC, int IDNLGJGNGGH = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JKOABGJPOCN : global::EFNHAFHOKBP<JKOABGJPOCN>, JHCFGCJIHGF, IEquatable<JKOABGJPOCN>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[CreateProperty]
	public int JPEBDLEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x71ED90", Offset = "0x71E190", VA = "0x18071ED90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int JHIGGPANBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB60", Offset = "0x8AAF60", VA = "0x1808ABB60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xEBF6B0", Offset = "0xEBEAB0", VA = "0x180EBF6B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool COOCIDMCJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5C5BC10", Offset = "0x5C5B010", VA = "0x185C5BC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3635DB0", Offset = "0x36351B0", VA = "0x183635DB0", Slot = "8")]
	public bool Equals(JKOABGJPOCN BKBGGIICJOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xDB3370", Offset = "0xDB2770", VA = "0x180DB3370")]
	public static bool HOHCOENENOO(JKOABGJPOCN ANJGLCCJFPO, JKOABGJPOCN ABBMKKCGFBG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x47FE220", Offset = "0x47FD620", VA = "0x1847FE220")]
	public static bool GJGNKFAGFPG(JKOABGJPOCN ANJGLCCJFPO, JKOABGJPOCN ABBMKKCGFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5C5BB80", Offset = "0x5C5AF80", VA = "0x185C5BB80", Slot = "0")]
	public override bool Equals(object HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C5BC50", Offset = "0x5C5B050", VA = "0x185C5BC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MIAOGFDMMBB
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
public interface FMDIAAFHALA
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JACNJHHOBDA CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	MIAOGFDMMBB GIFJHJMGABM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BJNIPCBPEEG : global::EFNHAFHOKBP<BJNIPCBPEEG>, JHCFGCJIHGF, IEquatable<BJNIPCBPEEG>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	[CreateProperty]
	public int JPEBDLEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71ED90", Offset = "0x71E190", VA = "0x18071ED90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int JHIGGPANBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB60", Offset = "0x8AAF60", VA = "0x1808ABB60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xEBF6B0", Offset = "0xEBEAB0", VA = "0x180EBF6B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool COOCIDMCJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5C563E0", Offset = "0x5C557E0", VA = "0x185C563E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3635DB0", Offset = "0x36351B0", VA = "0x183635DB0", Slot = "8")]
	public bool Equals(BJNIPCBPEEG BKBGGIICJOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xDB3370", Offset = "0xDB2770", VA = "0x180DB3370")]
	public static bool HOHCOENENOO(BJNIPCBPEEG ANJGLCCJFPO, BJNIPCBPEEG ABBMKKCGFBG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x47FE220", Offset = "0x47FD620", VA = "0x1847FE220")]
	public static bool GJGNKFAGFPG(BJNIPCBPEEG ANJGLCCJFPO, BJNIPCBPEEG ABBMKKCGFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C56350", Offset = "0x5C55750", VA = "0x185C56350", Slot = "0")]
	public override bool Equals(object HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5C56420", Offset = "0x5C55820", VA = "0x185C56420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LFLEPDCNFOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	JACNJHHOBDA CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float PBJGAHAJDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 KAIEAAJAMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	PGCIAPKMFPE IJAGAJNHKIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	NBKFCIMCJBO CJKFKPCMPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AIPFCBAFMBA : LFLEPDCNFOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	LECAPFCDEJK AJIJBDPNHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool AJGMDJPKNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BFMLFHNABHH : LFLEPDCNFOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LGDIAJKHGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MDAKKHPOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float NJNACMALNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int LJCJFIAAPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NDILPGEMNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int ELBABHCJEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<FIKJKFDFCDL> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CBGDJFIAJGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKHEBJJHFIF(JKOABGJPOCN JAFNHFEOMPI, IECBHBBCNMJ ICDNLDENDBI);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKHEBJJHFIF(BJNIPCBPEEG DAKPLJOPPCA, IECBHBBCNMJ ICDNLDENDBI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJDAPFLKCLL(BJNIPCBPEEG DAKPLJOPPCA);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PILOAPIGBEO(BJNIPCBPEEG DAKPLJOPPCA);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMGPPKPHEHJ();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCNBEICLOOC();

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HKEPEFOFHKI(IECBHBBCNMJ NLAFPPIOFPG);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FJAHKBPKGJG(JKOABGJPOCN JAFNHFEOMPI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FJAHKBPKGJG(BJNIPCBPEEG DAKPLJOPPCA);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJFDDAMBKBN(JKOABGJPOCN JAFNHFEOMPI, MHLFPCDALLC NLAFPPIOFPG);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CJFDDAMBKBN(BJNIPCBPEEG DAKPLJOPPCA, MHLFPCDALLC NLAFPPIOFPG);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FGBAONBJILE(BJNIPCBPEEG DAKPLJOPPCA);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IDPHOHFBEDD(BJNIPCBPEEG DAKPLJOPPCA);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MMCIGOGKHDI();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BEFOLECBDJC();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CGLOCLMJIFA(MHLFPCDALLC NLAFPPIOFPG);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CAODEMEKDJF(JKOABGJPOCN JAFNHFEOMPI, Vector3 KJBCLEIHCPJ, Vector3 HKNCEBNELIB, Vector3 KHEKGHHAEAC, float HJMKCDIJMKB, float APLGIABKEJN, IReadOnlyList<Camera> OPKLKPCDPOB, NFDNAJBNMKA DBIGKAIEGHB);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CAODEMEKDJF(BLCFIOCJDFC LNCPFGOOGMG, Vector3 KJBCLEIHCPJ, Vector3 HKNCEBNELIB, Vector3 KHEKGHHAEAC, float HJMKCDIJMKB, float APLGIABKEJN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JBENEBBLOHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKOABGJPOCN HEOONJLDHMF(FMDIAAFHALA HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIEJDEFOPCF(JKOABGJPOCN JAFNHFEOMPI);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCBBINMGFDG(JKOABGJPOCN JAFNHFEOMPI);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BJNIPCBPEEG BGEEOPCFBEN(JKOABGJPOCN JAFNHFEOMPI, AIPFCBAFMBA HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BJNIPCBPEEG ECIPJEKKBIG(JKOABGJPOCN JAFNHFEOMPI, BFMLFHNABHH HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMBIHBIGJNA(BJNIPCBPEEG DAKPLJOPPCA);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JDHOJJHDCEP(BJNIPCBPEEG DAKPLJOPPCA);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BLCFIOCJDFC OGLNOACFMFJ(HHCEHEDHFLG HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HPCHDCLKGKB(BLCFIOCJDFC LNCPFGOOGMG);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EEJAIJMJHKF(BLCFIOCJDFC LNCPFGOOGMG);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NCEJEJIHIMC DMDEJMHDGHF(JACNJHHOBDA HGBFADCANJP, IEnumerable<BJNIPCBPEEG> JLENKJLMMDN, int HBAJICKHBBK);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> IAIGPPCJKGF(JKOABGJPOCN JAFNHFEOMPI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BLCFIOCJDFC : global::EFNHAFHOKBP<BLCFIOCJDFC>, JHCFGCJIHGF, IEquatable<BLCFIOCJDFC>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int JPEBDLEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x71ED90", Offset = "0x71E190", VA = "0x18071ED90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int JHIGGPANBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB60", Offset = "0x8AAF60", VA = "0x1808ABB60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xEBF6B0", Offset = "0xEBEAB0", VA = "0x180EBF6B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool COOCIDMCJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5C56540", Offset = "0x5C55940", VA = "0x185C56540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3635DB0", Offset = "0x36351B0", VA = "0x183635DB0", Slot = "8")]
	public bool Equals(BLCFIOCJDFC BKBGGIICJOJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xDB3370", Offset = "0xDB2770", VA = "0x180DB3370")]
	public static bool HOHCOENENOO(BLCFIOCJDFC ANJGLCCJFPO, BLCFIOCJDFC ABBMKKCGFBG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x47FE220", Offset = "0x47FD620", VA = "0x1847FE220")]
	public static bool GJGNKFAGFPG(BLCFIOCJDFC ANJGLCCJFPO, BLCFIOCJDFC ABBMKKCGFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5C564B0", Offset = "0x5C558B0", VA = "0x185C564B0", Slot = "0")]
	public override bool Equals(object HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x71EE20", Offset = "0x71E220", VA = "0x18071EE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HHCEHEDHFLG
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int JDKBPCJFMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform FCMNGNGEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool AEGGKPAPDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKOABGJPOCN GetBone(int IJBBBBBOGFF);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int IJBBBBBOGFF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class CMCAEPKJKJL : CMPCAADINDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly AIPFCBAFMBA DAMEOOAEKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int[] IAMCJBMLHKG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override FHODJMIMKCJ LOOBJEPIPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5C57F60", Offset = "0x5C57360", VA = "0x185C57F60", Slot = "12")]
		get
		{
			return default(FHODJMIMKCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 IMCDOFANAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5C57290", Offset = "0x5C56690", VA = "0x185C57290")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5C58310", Offset = "0x5C57710", VA = "0x185C58310")]
	public CMCAEPKJKJL(JNNEDFDIOFA JAFNHFEOMPI, AIPFCBAFMBA HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5C56AC0", Offset = "0x5C55EC0", VA = "0x185C56AC0", Slot = "11")]
	public override bool BLDDCPOPANB(JACNJHHOBDA JAFNHFEOMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5C57EB0", Offset = "0x5C572B0", VA = "0x185C57EB0", Slot = "13")]
	public override int IJKBFBAAAPJ(CFCICPKONAK HJPMNNIECBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5C56F30", Offset = "0x5C56330", VA = "0x185C56F30", Slot = "14")]
	public override int CBDPKEHMHIH(CFCICPKONAK HJPMNNIECBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5C56FE0", Offset = "0x5C563E0", VA = "0x185C56FE0")]
	private int CCLLOFCDNHB(CFCICPKONAK HJPMNNIECBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5C575D0", Offset = "0x5C569D0", VA = "0x185C575D0", Slot = "15")]
	public override void HKNKLNBLCHG(CFCICPKONAK HJPMNNIECBA, CJGCOAKKICH GILJFEALDKC, int IDNLGJGNGGH = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OMPELKMCEFJ
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDHMBFJNKJE(MHLFPCDALLC NLAFPPIOFPG, Renderer LNAALPLKPHP, int FKEHHCJFDMP);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKELNOOEMKO(Renderer LNAALPLKPHP, NFDNAJBNMKA DBIGKAIEGHB, Vector3 KJBCLEIHCPJ, Vector3 HKNCEBNELIB, Vector3 KHEKGHHAEAC, float HJMKCDIJMKB, float APLGIABKEJN, float LJHMMHBJAPA = -1f, [Optional] Color? GIPDGGFIBAH, [Optional] IReadOnlyList<Camera> GFDEMGPDHCO);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHJONKHINGE(Renderer LNAALPLKPHP, int FKEHHCJFDMP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LLCFMEFHHHA();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDJMEGLGDNE(int DKJLJNHLJFN, IECBHBBCNMJ NLAFPPIOFPG, Renderer LNAALPLKPHP, int FKEHHCJFDMP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OGHGOKMIBHF : CBGDJFIAJGI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class DKDMHHEGMJI : global::DBNGMFEMKGH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5C58FD0", Offset = "0x5C583D0", VA = "0x185C58FD0")]
		public DKDMHHEGMJI(string JODEBEIHAPC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly OMPELKMCEFJ PMEMBJADGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly GJBFKNFHINO HOIEBKGGJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MeshRenderer MLKEPCIPCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private DKDMHHEGMJI MBPOCJJBGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool NICGMIALEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MeshRenderer EFOAFPGLNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private DKDMHHEGMJI MBDMDLHNCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool CPKLGINDJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MeshRenderer FBOOPCDELLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private DKDMHHEGMJI EFAJLIAPPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x66D6E0", Offset = "0x66CAE0", VA = "0x18066D6E0")]
	public OGHGOKMIBHF(OMPELKMCEFJ GAGJMDADGNF, GJBFKNFHINO HOIEBKGGJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5C5FF80", Offset = "0x5C5F380", VA = "0x185C5FF80", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5C5FD30", Offset = "0x5C5F130", VA = "0x185C5FD30")]
	private void COBLIFNBKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5C5F910", Offset = "0x5C5ED10", VA = "0x185C5F910", Slot = "4")]
	public void CKHEBJJHFIF(JKOABGJPOCN JAFNHFEOMPI, IECBHBBCNMJ ICDNLDENDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5C5FB10", Offset = "0x5C5EF10", VA = "0x185C5FB10", Slot = "5")]
	public void CKHEBJJHFIF(BJNIPCBPEEG DAKPLJOPPCA, IECBHBBCNMJ ICDNLDENDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5C60DB0", Offset = "0x5C601B0", VA = "0x185C60DB0", Slot = "6")]
	public void PJDAPFLKCLL(BJNIPCBPEEG DAKPLJOPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5C60C90", Offset = "0x5C60090", VA = "0x185C60C90", Slot = "7")]
	public void PILOAPIGBEO(BJNIPCBPEEG DAKPLJOPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5C60150", Offset = "0x5C5F550", VA = "0x185C60150", Slot = "8")]
	public void EMGPPKPHEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x14E10B0", Offset = "0x14E04B0", VA = "0x1814E10B0", Slot = "9")]
	public void OCNBEICLOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5C60730", Offset = "0x5C5FB30", VA = "0x185C60730", Slot = "10")]
	public void HKEPEFOFHKI(IECBHBBCNMJ ICDNLDENDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5C60580", Offset = "0x5C5F980", VA = "0x185C60580", Slot = "11")]
	public void FJAHKBPKGJG(JKOABGJPOCN JAFNHFEOMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5C60230", Offset = "0x5C5F630", VA = "0x185C60230", Slot = "12")]
	public void FJAHKBPKGJG(BJNIPCBPEEG DAKPLJOPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5C5F3A0", Offset = "0x5C5E7A0", VA = "0x185C5F3A0", Slot = "13")]
	public void CJFDDAMBKBN(JKOABGJPOCN JAFNHFEOMPI, MHLFPCDALLC NLAFPPIOFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5C5F720", Offset = "0x5C5EB20", VA = "0x185C5F720", Slot = "14")]
	public void CJFDDAMBKBN(BJNIPCBPEEG DAKPLJOPPCA, MHLFPCDALLC NLAFPPIOFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5C60A00", Offset = "0x5C5FE00", VA = "0x185C60A00", Slot = "17")]
	public void MMCIGOGKHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5C60190", Offset = "0x5C5F590", VA = "0x185C60190", Slot = "15")]
	public void FGBAONBJILE(BJNIPCBPEEG DAKPLJOPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5C608A0", Offset = "0x5C5FCA0", VA = "0x185C608A0", Slot = "16")]
	public void IDPHOHFBEDD(BJNIPCBPEEG DAKPLJOPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x12A19C0", Offset = "0x12A0DC0", VA = "0x1812A19C0", Slot = "18")]
	public void BEFOLECBDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5C5F260", Offset = "0x5C5E660", VA = "0x185C5F260", Slot = "19")]
	public void CGLOCLMJIFA(MHLFPCDALLC NLAFPPIOFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5C60A40", Offset = "0x5C5FE40", VA = "0x185C60A40")]
	private void PALCIEPMJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5C5F560", Offset = "0x5C5E960", VA = "0x185C5F560")]
	public void CJFDDAMBKBN(BJNIPCBPEEG DAKPLJOPPCA, MHLFPCDALLC NLAFPPIOFPG, bool BGJFNFEOKBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5C60930", Offset = "0x5C5FD30", VA = "0x185C60930")]
	private void MDHMBFJNKJE(MHLFPCDALLC NLAFPPIOFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5C5EEE0", Offset = "0x5C5E2E0", VA = "0x185C5EEE0", Slot = "20")]
	public void CAODEMEKDJF(JKOABGJPOCN JAFNHFEOMPI, Vector3 KJBCLEIHCPJ, Vector3 HKNCEBNELIB, Vector3 KHEKGHHAEAC, float HJMKCDIJMKB, float APLGIABKEJN, IReadOnlyList<Camera> OPKLKPCDPOB, NFDNAJBNMKA DBIGKAIEGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5C5EAC0", Offset = "0x5C5DEC0", VA = "0x185C5EAC0", Slot = "21")]
	public void CAODEMEKDJF(BLCFIOCJDFC LNCPFGOOGMG, Vector3 KJBCLEIHCPJ, Vector3 HKNCEBNELIB, Vector3 KHEKGHHAEAC, float HJMKCDIJMKB, float APLGIABKEJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class CMPCAADINDL : NDBABMLBGLI, OOILBGJIPAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly JNNEDFDIOFA HNOOCOABLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	protected Bounds GDDGBOONKAE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds JBGBMFJILID
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x16AF1F0", Offset = "0x16AE5F0", VA = "0x1816AF1F0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual FHODJMIMKCJ LOOBJEPIPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5C58430", Offset = "0x5C57830", VA = "0x185C58430", Slot = "12")]
		get
		{
			return default(FHODJMIMKCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x66DF40", Offset = "0x66D340", VA = "0x18066DF40")]
	protected CMPCAADINDL(JNNEDFDIOFA JAFNHFEOMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5C58360", Offset = "0x5C57760", VA = "0x185C58360", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "11")]
	public virtual bool BLDDCPOPANB(JACNJHHOBDA JAFNHFEOMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int IJKBFBAAAPJ(CFCICPKONAK HJPMNNIECBA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int CBDPKEHMHIH(CFCICPKONAK HJPMNNIECBA);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void HKNKLNBLCHG(CFCICPKONAK HJPMNNIECBA, CJGCOAKKICH GILJFEALDKC, int IDNLGJGNGGH = -1);
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
		[Cpp2IlInjected.Address(RVA = "0x5C61E00", Offset = "0x5C61200", VA = "0x185C61E00")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LECAPFCDEJK
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
public static class POGJHPPIEMA
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class EOCCKPFPNHE : IEnumerable<GFAMGCLFCJJ>, IEnumerable, IEnumerator<GFAMGCLFCJJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private GFAMGCLFCJJ <>2__current;

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
		private GFAMGCLFCJJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
		[DebuggerHidden]
		public EOCCKPFPNHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5C59020", Offset = "0x5C58420", VA = "0x185C59020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5C59190", Offset = "0x5C58590", VA = "0x185C59190", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5C59100", Offset = "0x5C58500", VA = "0x185C59100", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GFAMGCLFCJJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5C59100", Offset = "0x5C58500", VA = "0x185C59100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int CGNBLBAOJAF = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static GFAMGCLFCJJ[][] JBJANHDFCMG;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static FACAGGMEMPB LKGELACFECB;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static ShapeRendererConfig OACINHMFNFB;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader OBNMIMPJFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5C618D0", Offset = "0x5C60CD0", VA = "0x185C618D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer CGFLIFIADDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C60EF0", Offset = "0x5C602F0", VA = "0x185C60EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5C61940", Offset = "0x5C60D40", VA = "0x185C61940")]
	public static Mesh MMCPHLFGNMB(LECAPFCDEJK PLAMOCPLELM, int HJPMNNIECBA = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5C60EE0", Offset = "0x5C602E0", VA = "0x185C60EE0")]
	public static int EIPOMNBHMFL(LECAPFCDEJK PLAMOCPLELM, int HJPMNNIECBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5C60F70", Offset = "0x5C60370", VA = "0x185C60F70")]
	public static FACAGGMEMPB HFNINNMCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5C616C0", Offset = "0x5C60AC0", VA = "0x185C616C0")]
	[IteratorStateMachine(typeof(EOCCKPFPNHE))]
	private static IEnumerable<GFAMGCLFCJJ> MDLCEIAAALG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5C61A00", Offset = "0x5C60E00", VA = "0x185C61A00")]
	public static GFAMGCLFCJJ OIKBCOOAHBA(LECAPFCDEJK PLAMOCPLELM, int HJPMNNIECBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5C616A0", Offset = "0x5C60AA0", VA = "0x185C616A0")]
	public static bool LMLPGNMMICB(this LECAPFCDEJK PLAMOCPLELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5C61720", Offset = "0x5C60B20", VA = "0x185C61720")]
	public static void MFJMCGMODAI(LECAPFCDEJK PLAMOCPLELM, float3 AJBNPKJHHLI, out JPAMDJPMDNF HAKIIMNJNDG, out float3 LFCLMMBFEHO, out float APDMPMIDDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5C612F0", Offset = "0x5C606F0", VA = "0x185C612F0")]
	public static void LEEDLLDLKCI(Vector3 AJBNPKJHHLI, LECAPFCDEJK PLAMOCPLELM, out Vector3 LFCLMMBFEHO, out float APDMPMIDDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5C60F60", Offset = "0x5C60360", VA = "0x185C60F60")]
	[OPBFEDEIAPM(HPHNAPCJKPB.ExitingPlayMode, 0)]
	private static void FKILAEILNJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5C610D0", Offset = "0x5C604D0", VA = "0x185C610D0")]
	[OPBFEDEIAPM(HPHNAPCJKPB.ExitingPlayMode, 0)]
	private static void KFIFMECKJKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JOCEMOIEJBK
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool HBDCMPPDOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material HOBCPNJADCH();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material LCIGILPBLBC();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material PHFHMBMGIKF();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FPGDADHHLDJ(PGCIAPKMFPE MAPBHFNAIPF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AKLAICBODNP(NBKFCIMCJBO JJODBLBACML);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DEAOABMPOEC(GameObject HKFNIHLBEHC);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IHEOGCHHDFL(GameObject HKFNIHLBEHC, bool DEOAFFJFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface GJBFKNFHINO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JNNEDFDIOFA BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CMPCAADINDL BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LKIFKJOBPFC BJGDNLMGIHJ
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
	[AFAPMPFKDID(JCDEPCAPNFC.ShapeRendering)]
	public class ShapeRendererManager : JBENEBBLOHB, IDisposable, GJBFKNFHINO
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly global::HNGCIAJIBBM<JKOABGJPOCN, JNNEDFDIOFA> MCGOOALJLNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly global::HNGCIAJIBBM<BJNIPCBPEEG, CMPCAADINDL> JLENKJLMMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly global::HNGCIAJIBBM<BLCFIOCJDFC, LKIFKJOBPFC> GLPMFDKNILJ;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static JOCEMOIEJBK GNIIEBLJLCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5C62A70", Offset = "0x5C61E70", VA = "0x185C62A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5C62850", Offset = "0x5C61C50", VA = "0x185C62850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public JNNEDFDIOFA BJGDNLMGIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5C62000", Offset = "0x5C61400", VA = "0x185C62000", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public CMPCAADINDL BJGDNLMGIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5C61FA0", Offset = "0x5C613A0", VA = "0x185C61FA0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public LKIFKJOBPFC BJGDNLMGIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5C62060", Offset = "0x5C61460", VA = "0x185C62060", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C62D20", Offset = "0x5C62120", VA = "0x185C62D20")]
		public ShapeRendererManager(JOCEMOIEJBK GAGJMDADGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5C62540", Offset = "0x5C61940", VA = "0x185C62540", Slot = "16")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5C62750", Offset = "0x5C61B50", VA = "0x185C62750", Slot = "4")]
		public JKOABGJPOCN HEOONJLDHMF(FMDIAAFHALA HANEMGLFJMM)
		{
			return default(JKOABGJPOCN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5C61E30", Offset = "0x5C61230", VA = "0x185C61E30", Slot = "5")]
		public void AIEJDEFOPCF(JKOABGJPOCN JAFNHFEOMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5C620C0", Offset = "0x5C614C0", VA = "0x185C620C0", Slot = "6")]
		public void DCBBINMGFDG(JKOABGJPOCN JAFNHFEOMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5C61E90", Offset = "0x5C61290", VA = "0x185C61E90", Slot = "7")]
		public BJNIPCBPEEG BGEEOPCFBEN(JKOABGJPOCN JAFNHFEOMPI, AIPFCBAFMBA HANEMGLFJMM)
		{
			return default(BJNIPCBPEEG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5C625D0", Offset = "0x5C619D0", VA = "0x185C625D0", Slot = "8")]
		public BJNIPCBPEEG ECIPJEKKBIG(JKOABGJPOCN JAFNHFEOMPI, BFMLFHNABHH HANEMGLFJMM)
		{
			return default(BJNIPCBPEEG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5C629E0", Offset = "0x5C61DE0", VA = "0x185C629E0", Slot = "10")]
		public void JDHOJJHDCEP(BJNIPCBPEEG DAKPLJOPPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5C62AD0", Offset = "0x5C61ED0", VA = "0x185C62AD0", Slot = "9")]
		public void NMBIHBIGJNA(BJNIPCBPEEG DAKPLJOPPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5C62920", Offset = "0x5C61D20", VA = "0x185C62920", Slot = "15")]
		public IEnumerable<Renderer> IAIGPPCJKGF(JKOABGJPOCN JAFNHFEOMPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5C62B30", Offset = "0x5C61F30", VA = "0x185C62B30", Slot = "11")]
		public BLCFIOCJDFC OGLNOACFMFJ(HHCEHEDHFLG HANEMGLFJMM)
		{
			return default(BLCFIOCJDFC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5C626E0", Offset = "0x5C61AE0", VA = "0x185C626E0", Slot = "13")]
		public void EEJAIJMJHKF(BLCFIOCJDFC LNCPFGOOGMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5C628C0", Offset = "0x5C61CC0", VA = "0x185C628C0", Slot = "12")]
		public void HPCHDCLKGKB(BLCFIOCJDFC LNCPFGOOGMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5C62140", Offset = "0x5C61540", VA = "0x185C62140", Slot = "14")]
		public NCEJEJIHIMC DMDEJMHDGHF(JACNJHHOBDA CKOEJNAMAGP, IEnumerable<BJNIPCBPEEG> JLENKJLMMDN, int HBAJICKHBBK)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LKIFKJOBPFC : MEMLBCJBJNC
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NAFPEFGINLE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LKIFKJOBPFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
		[DebuggerHidden]
		public NAFPEFGINLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5C5E9F0", Offset = "0x5C5DDF0", VA = "0x185C5E9F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5C5E710", Offset = "0x5C5DB10", VA = "0x185C5E710", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5C5EA70", Offset = "0x5C5DE70", VA = "0x185C5EA70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5C5E9B0", Offset = "0x5C5DDB0", VA = "0x185C5E9B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5C5E910", Offset = "0x5C5DD10", VA = "0x185C5E910", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5C5E910", Offset = "0x5C5DD10", VA = "0x185C5E910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly HHCEHEDHFLG JKOAONOOJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly GJBFKNFHINO HOIEBKGGJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private FKOBEPFJKDI HKEDCAAPKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private List<FJNGBEEOAKD> IOAPJODIGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private List<FJNGBEEOAKD> HKFCGDOABDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject GLMMCBJEGJL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5C5E400", Offset = "0x5C5D800", VA = "0x185C5E400")]
	public static LKIFKJOBPFC GBFKCMBENNN(HHCEHEDHFLG HANEMGLFJMM, GJBFKNFHINO HOIEBKGGJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5C5E610", Offset = "0x5C5DA10", VA = "0x185C5E610")]
	private LKIFKJOBPFC(HHCEHEDHFLG HANEMGLFJMM, GJBFKNFHINO HOIEBKGGJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5C5D300", Offset = "0x5C5C700", VA = "0x185C5D300")]
	public void ANGPDPCFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5C5D7E0", Offset = "0x5C5CBE0", VA = "0x185C5D7E0")]
	[IteratorStateMachine(typeof(NAFPEFGINLE))]
	public IEnumerable<Renderer> CCFOKJJPGJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5C5D850", Offset = "0x5C5CC50", VA = "0x185C5D850", Slot = "4")]
	public void FGOLPCEHPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5C5E570", Offset = "0x5C5D970", VA = "0x185C5E570")]
	private void KOODLCMPBBJ(Vector3 FFBJJILBDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5C5D060", Offset = "0x5C5C460", VA = "0x185C5D060")]
	public void ADDBGNGPEPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FJNGBEEOAKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct JEPMEJDPIOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public CJGCOAKKICH KIAHGIONGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public JACNJHHOBDA BBMMBMENAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int BHNMELHNNDN;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BAPIGHPADGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public FJNGBEEOAKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public CFCICPKONAK lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<JEPMEJDPIOL> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NCEJEJIHIMC combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BAPIGHPADGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5C56170", Offset = "0x5C55570", VA = "0x185C56170")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5C561D0", Offset = "0x5C555D0", VA = "0x185C561D0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5C56200", Offset = "0x5C55600", VA = "0x185C56200")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int[] PHCOGDAGMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private FKCEBMEEINE BCDAIBFDGBO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static Matrix4x4 KJBCPIJMOBB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh NPCIGKNAGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68D130", Offset = "0x68C530", VA = "0x18068D130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FJMFPAFGAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x711410", Offset = "0x710810", VA = "0x180711410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5C591D0", Offset = "0x5C585D0", VA = "0x185C591D0")]
	public void AACOPCLJIAI(List<JACNJHHOBDA> GOJJOMJPKKG, Matrix4x4[] ECDPGAKDGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5C595A0", Offset = "0x5C589A0", VA = "0x185C595A0")]
	public static List<FJNGBEEOAKD> GEGOECOOINK(List<JNNEDFDIOFA> BENNCOJPFIF, CFCICPKONAK HJPMNNIECBA, Bounds JJOGFAELGAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5C59BD0", Offset = "0x5C58FD0", VA = "0x185C59BD0")]
	private JobHandle PHLOMEPMAPO(NCEJEJIHIMC HGMLPENBOHN, int OGOIONMAALD, int DPFMNMLFNHH, CFCICPKONAK HJPMNNIECBA, List<JEPMEJDPIOL> GGEJOFEBKCM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5C59490", Offset = "0x5C58890", VA = "0x185C59490")]
	private void GBLNBEOMCOC(List<JEPMEJDPIOL> GGEJOFEBKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5C5A0E0", Offset = "0x5C594E0", VA = "0x185C5A0E0")]
	private FJNGBEEOAKD(List<JEPMEJDPIOL> GGEJOFEBKCM, int OGOIONMAALD, int DPFMNMLFNHH, CFCICPKONAK HJPMNNIECBA, Bounds JJOGFAELGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5C59400", Offset = "0x5C58800", VA = "0x185C59400", Slot = "4")]
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
		private MaterialPropertyBlock BBGIBOBABPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private FJNGBEEOAKD DKKFAMCHLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<JACNJHHOBDA> NNLCFMEJPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private RenderTexture LLLCNBMJJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private ComputeBuffer NKIOHJBJJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private ComputeShader OFALDOJFJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Matrix4x4[] MNGLCKEIKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int NNJDLGFOJCB;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer BMEJGGMBPOF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x68D140", Offset = "0x68C540", VA = "0x18068D140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int JDKBPCJFMEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5C63F50", Offset = "0x5C63350", VA = "0x185C63F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5C63480", Offset = "0x5C62880", VA = "0x185C63480")]
		public static List<SkinnedShapeRenderer> Create(GameObject JAFNHFEOMPI, List<FJNGBEEOAKD> LACEFMPFLHH, List<JACNJHHOBDA> NNLCFMEJPEG, Material MLAANGECIPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5C63900", Offset = "0x5C62D00", VA = "0x185C63900")]
		public void Init(FJNGBEEOAKD DKKFAMCHLJC, List<JACNJHHOBDA> NNLCFMEJPEG, Material MLAANGECIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5C63EA0", Offset = "0x5C632A0", VA = "0x185C63EA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5C63DF0", Offset = "0x5C631F0", VA = "0x185C63DF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5C63DB0", Offset = "0x5C631B0", VA = "0x185C63DB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5C636D0", Offset = "0x5C62AD0", VA = "0x185C636D0")]
		private void GCPHOJNOLDI(ScriptableRenderContext IDEIPFIOJKJ, Camera[] GHPNOCCOFDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5C632C0", Offset = "0x5C626C0", VA = "0x185C632C0")]
		private void AACOPCLJIAI(CommandBuffer OGKLIBGPBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : EFIPBPLGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5C64080", Offset = "0x5C63480", VA = "0x185C64080", Slot = "4")]
		public sealed override void AMKPAJEBOOH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5C5B180", Offset = "0x5C5A580", VA = "0x185C5B180")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5C5AE30", Offset = "0x5C5A230", VA = "0x185C5AE30")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
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
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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
