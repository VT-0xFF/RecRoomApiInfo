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
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LIIOGCDDKAE
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
public static class PBLHDPEFCJF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5731100", Offset = "0x572FD00", VA = "0x185731100")]
	public static bool NAKFJFCOLMO(this LIIOGCDDKAE POIEFCEPMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5731120", Offset = "0x572FD20", VA = "0x185731120")]
	public static bool PEGJFNHBGJB(this LIIOGCDDKAE POIEFCEPMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x57310D0", Offset = "0x572FCD0", VA = "0x1857310D0")]
	public static bool DNCBGJDGCCF(this LIIOGCDDKAE POIEFCEPMGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JIGICGEOCBJ
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
public enum JDNGKGNOMOG
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
public enum GIKNMFHPAIG
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
	ScopeRoot,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	PivotHover
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum DMOIBLHBGCL
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DOKPBKOADJK : NHGABLPLPCK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const byte LAJPMLOLFPF = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private byte GHADDDIGBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<SkinnedShapeRenderer>[] NKINJELMEAI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MENMOFFBKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCD0", Offset = "0x5EB8D0", VA = "0x1805ECCD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66DA10", Offset = "0x66C610", VA = "0x18066DA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JNMCBFHFPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC0", Offset = "0x5EB8C0", VA = "0x1805ECCC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7471B0", Offset = "0x745DB0", VA = "0x1807471B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float LCKHHEHFDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1026E00", Offset = "0x1025A00", VA = "0x181026E00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1027100", Offset = "0x1025D00", VA = "0x181027100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JAECNNCHAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1009510", Offset = "0x1008110", VA = "0x181009510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1026E20", Offset = "0x1025A20", VA = "0x181026E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> OIKCCJIJCMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5728400", Offset = "0x5727000", VA = "0x185728400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> LDEIJDEKEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x44DD3F0", Offset = "0x44DBFF0", VA = "0x1844DD3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject JOENHKCCFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x724880", Offset = "0x723480", VA = "0x180724880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte IEFKAGFCBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x57283B0", Offset = "0x5726FB0", VA = "0x1857283B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x57284A0", Offset = "0x57270A0", VA = "0x1857284A0")]
	public DOKPBKOADJK(List<NFMCBJOPHLN> GNFCINKCPBF, List<NFMCBJOPHLN> KOCEMEDNCKF, List<CLEFBGOBOPM> AJONJLJFPPO, Material CLAPLIKDDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5727F20", Offset = "0x5726B20", VA = "0x185727F20")]
	private int BCJKBDFBBAI(List<NFMCBJOPHLN> LFKKHHJEJCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5728250", Offset = "0x5726E50", VA = "0x185728250")]
	private void GHMNDNPJPOB(int NKNAJFJGAOG, bool MPECIKDKPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5728030", Offset = "0x5726C30", VA = "0x185728030")]
	public void DNNFGDBINOF(Vector3 FGDCKGKNMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5728120", Offset = "0x5726D20", VA = "0x185728120", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5728460", Offset = "0x5727060", VA = "0x185728460")]
	public void LOLBDNNLGAB(Transform PBCCOMOBJNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BDGLLOLJIGP : MKKBPNFBIAG, JJKLABKGHEP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IGGEMBNLCAH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BDGLLOLJIGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3E0", Offset = "0x6FBFE0", VA = "0x1806FD3E0")]
		[DebuggerHidden]
		public IGGEMBNLCAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x572BD80", Offset = "0x572A980", VA = "0x18572BD80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x572B8D0", Offset = "0x572A4D0", VA = "0x18572B8D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x572BF00", Offset = "0x572AB00", VA = "0x18572BF00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x572BF40", Offset = "0x572AB40", VA = "0x18572BF40")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x572BF90", Offset = "0x572AB90", VA = "0x18572BF90")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x572BD30", Offset = "0x572A930", VA = "0x18572BD30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x572BC90", Offset = "0x572A890", VA = "0x18572BC90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x572BC90", Offset = "0x572A890", VA = "0x18572BC90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KEMFDJCGCDF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public BDGLLOLJIGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3E0", Offset = "0x6FBFE0", VA = "0x1806FD3E0")]
		[DebuggerHidden]
		public KEMFDJCGCDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x572D730", Offset = "0x572C330", VA = "0x18572D730", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x572D390", Offset = "0x572BF90", VA = "0x18572D390", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x572D850", Offset = "0x572C450", VA = "0x18572D850")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x572D8A0", Offset = "0x572C4A0", VA = "0x18572D8A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x572D6E0", Offset = "0x572C2E0", VA = "0x18572D6E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x572D640", Offset = "0x572C240", VA = "0x18572D640", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x572D640", Offset = "0x572C240", VA = "0x18572D640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OHPABHHJPBL BEFHOIMNGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<NGHEBBIDILN> OACBGOOFHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<ClusterMeshRenderer> FMLINFPMALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private BatchedMeshRenderer KBIFCGOACEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool PJKCLCLGHGM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<OLDLEEMDEGF> NOKPPHLIFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PJIMABGCKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5727E50", Offset = "0x5726A50", VA = "0x185727E50", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CLEFBGOBOPM LJLJODNIBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x57278F0", Offset = "0x57264F0", VA = "0x1857278F0", Slot = "7")]
		get
		{
			return default(CLEFBGOBOPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PBBCLMLCCAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED010", Offset = "0x5EBC10", VA = "0x1805ED010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED020", Offset = "0x5EBC20", VA = "0x1805ED020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5727E90", Offset = "0x5726A90", VA = "0x185727E90")]
	public BDGLLOLJIGP(OHPABHHJPBL OAGMKJFIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5727780", Offset = "0x5726380", VA = "0x185727780", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5727CD0", Offset = "0x57268D0", VA = "0x185727CD0")]
	public void LFMPFEAFMAL(NGHEBBIDILN OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5727BB0", Offset = "0x57267B0", VA = "0x185727BB0")]
	public void JNIHJKFEBJI(NGHEBBIDILN OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5727270", Offset = "0x5725E70", VA = "0x185727270", Slot = "4")]
	public void CINHNPNOCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5727C20", Offset = "0x5726820", VA = "0x185727C20")]
	public void KLCBFOGAMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5727A80", Offset = "0x5726680", VA = "0x185727A80")]
	private void JJBIAMPLELN(List<NGHEBBIDILN> OACBGOOFHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x57279C0", Offset = "0x57265C0", VA = "0x1857279C0")]
	private static Material IKAGIHODIMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5727A30", Offset = "0x5726630", VA = "0x185727A30")]
	private void JJBIAMPLELN(NGHEBBIDILN OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x57277B0", Offset = "0x57263B0", VA = "0x1857277B0")]
	private void EAHEIBHLPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5726CF0", Offset = "0x57258F0", VA = "0x185726CF0")]
	public void BIKBPAOPGDO(bool GNIDAOCBNCC, bool MKANOGDBFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5727DC0", Offset = "0x57269C0", VA = "0x185727DC0")]
	protected void NKIMADOEFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5726C80", Offset = "0x5725880", VA = "0x185726C80")]
	[IteratorStateMachine(typeof(IGGEMBNLCAH))]
	public IEnumerable<Renderer> BEACGHNNDJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5727880", Offset = "0x5726480", VA = "0x185727880")]
	[IteratorStateMachine(typeof(KEMFDJCGCDF))]
	public IEnumerable<Renderer> EIHHIECODLJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class MBOFMEBEOAB : NGHEBBIDILN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly JIOPMELHODL BGBILNJBEGJ;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x572E440", Offset = "0x572D040", VA = "0x18572E440")]
	public MBOFMEBEOAB(BDGLLOLJIGP IFKKFCHLHMM, JIOPMELHODL OAGMKJFIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x572D9B0", Offset = "0x572C5B0", VA = "0x18572D9B0", Slot = "13")]
	public override int BCJKBDFBBAI(KACMKOBLJNJ PEMDPBOGJEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x572E260", Offset = "0x572CE60", VA = "0x18572E260", Slot = "14")]
	public override int KCFHBJKEKOJ(KACMKOBLJNJ PEMDPBOGJEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x572DB90", Offset = "0x572C790", VA = "0x18572DB90", Slot = "15")]
	public override void DEKAJJECCFP(KACMKOBLJNJ PEMDPBOGJEA, OMMMHMLCNLM EPJIANIGJCO, int LGEJCLOBPJJ = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PFHLHFGGNPE : global::POBAFBEGBJN<PFHLHFGGNPE>, FBMJPDGBHLO, IEquatable<PFHLHFGGNPE>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PAOIHHHPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EKKPBKBJINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4E0", Offset = "0x8AA0E0", VA = "0x1808AB4E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2D0", Offset = "0x8FDED0", VA = "0x1808FF2D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x57311C0", Offset = "0x572FDC0", VA = "0x1857311C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x44ABEB0", Offset = "0x44AAAB0", VA = "0x1844ABEB0", Slot = "8")]
	public bool Equals(PFHLHFGGNPE NPKIIGGBCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD725F0", Offset = "0xD711F0", VA = "0x180D725F0")]
	public static bool NHPMPBNMAAP(PFHLHFGGNPE FNKIIBFNLFB, PFHLHFGGNPE EDLPJGEPJPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x337B590", Offset = "0x337A190", VA = "0x18337B590")]
	public static bool CLDCOCNHPOO(PFHLHFGGNPE FNKIIBFNLFB, PFHLHFGGNPE EDLPJGEPJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5731130", Offset = "0x572FD30", VA = "0x185731130", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ELLBLNMMJMB
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OHPABHHJPBL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CLEFBGOBOPM LNBAHGNJKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	ELLBLNMMJMB PONMDDOKKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LIBJEELBJGH : global::POBAFBEGBJN<LIBJEELBJGH>, FBMJPDGBHLO, IEquatable<LIBJEELBJGH>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int PAOIHHHPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EKKPBKBJINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4E0", Offset = "0x8AA0E0", VA = "0x1808AB4E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2D0", Offset = "0x8FDED0", VA = "0x1808FF2D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x572D970", Offset = "0x572C570", VA = "0x18572D970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x44ABEB0", Offset = "0x44AAAB0", VA = "0x1844ABEB0", Slot = "8")]
	public bool Equals(LIBJEELBJGH NPKIIGGBCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xD725F0", Offset = "0xD711F0", VA = "0x180D725F0")]
	public static bool NHPMPBNMAAP(LIBJEELBJGH FNKIIBFNLFB, LIBJEELBJGH EDLPJGEPJPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x337B590", Offset = "0x337A190", VA = "0x18337B590")]
	public static bool CLDCOCNHPOO(LIBJEELBJGH FNKIIBFNLFB, LIBJEELBJGH EDLPJGEPJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x572D8E0", Offset = "0x572C4E0", VA = "0x18572D8E0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HGIFEAPGGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	CLEFBGOBOPM LNBAHGNJKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float NLLNIOMAFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 JMMOFJPDIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	LIIOGCDDKAE CLNOGKPPBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JIGICGEOCBJ CCAKJLEDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CPGEGPCDBGJ : HGIFEAPGGIA
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	KCHFAGONAJO JJLNJEGKBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MNIFMLFCJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JIOPMELHODL : HGIFEAPGGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool AJGNDNFAMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PNCOOFJDHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float GCBEPLMMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int GFIBHCBNHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PCEMOKCEOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int EFJPOBIHLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<DGHLOFNDGBL> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ONOLPANMIPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBCCLPLMPMB(PFHLHFGGNPE IFKKFCHLHMM, GIKNMFHPAIG MGBMKLHMEEH);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBCCLPLMPMB(LIBJEELBJGH OHEGNDJDGOI, GIKNMFHPAIG MGBMKLHMEEH);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBODJKINKMN(LIBJEELBJGH OHEGNDJDGOI);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCMHNJOHHDJ(LIBJEELBJGH OHEGNDJDGOI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HLPFFNFPBLG();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFIFNFJBHPH();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NCLGOMNKNFK(GIKNMFHPAIG LIJLAEFJGCI);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GIFNIHOEOAN(PFHLHFGGNPE IFKKFCHLHMM);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GIFNIHOEOAN(LIBJEELBJGH OHEGNDJDGOI);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PFNIPMMFDJG(PFHLHFGGNPE IFKKFCHLHMM, DMOIBLHBGCL LIJLAEFJGCI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PFNIPMMFDJG(LIBJEELBJGH OHEGNDJDGOI, DMOIBLHBGCL LIJLAEFJGCI);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JMIPINDKBME(LIBJEELBJGH OHEGNDJDGOI);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EBKIJIHHBNK(LIBJEELBJGH OHEGNDJDGOI);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NCAEIDMOPGP();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DFINOHHAPCL();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PBEOAOGMIAM(DMOIBLHBGCL LIJLAEFJGCI);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MLNOFLGLDAG(PFHLHFGGNPE IFKKFCHLHMM, Vector3 LKBLICPNGJB, Vector3 OKHCHKHKEDL, Vector3 NFDLFODGJEM, float IGGNFOOPNAJ, float PKNFOFCFGHA, IReadOnlyList<Camera> CFFGMDMJHMN, JDNGKGNOMOG IAPBIMBBIKC);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MLNOFLGLDAG(FBEMGFEAAMN MDGJMKFLIIF, Vector3 LKBLICPNGJB, Vector3 OKHCHKHKEDL, Vector3 NFDLFODGJEM, float IGGNFOOPNAJ, float PKNFOFCFGHA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CCDCDCKBHOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PFHLHFGGNPE AIPGCFMGAOB(OHPABHHJPBL OAGMKJFIKKL);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFNNBJKBEDP(PFHLHFGGNPE IFKKFCHLHMM);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNPCPKFPJDA(PFHLHFGGNPE IFKKFCHLHMM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LIBJEELBJGH ILPNHPELKIC(PFHLHFGGNPE IFKKFCHLHMM, CPGEGPCDBGJ OAGMKJFIKKL);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LIBJEELBJGH APJDDJAEBBE(PFHLHFGGNPE IFKKFCHLHMM, JIOPMELHODL OAGMKJFIKKL);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACPENJEIKJM(LIBJEELBJGH OHEGNDJDGOI);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AMMKIGMJLGN(LIBJEELBJGH OHEGNDJDGOI);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FBEMGFEAAMN IKMCHNOLHFC(MNPPADCIIBD OAGMKJFIKKL);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGAFIEONCJH(FBEMGFEAAMN MDGJMKFLIIF);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MKANFDIFKNJ(FBEMGFEAAMN MDGJMKFLIIF);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BNNFCKHAFIM EBJEAPDLMDM(CLEFBGOBOPM PAFFPLOLNJJ, IEnumerable<LIBJEELBJGH> OACBGOOFHNG, int APGONGJDFCK);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> JOIAPGABIJA(PFHLHFGGNPE IFKKFCHLHMM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FBEMGFEAAMN : global::POBAFBEGBJN<FBEMGFEAAMN>, FBMJPDGBHLO, IEquatable<FBEMGFEAAMN>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int PAOIHHHPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int EKKPBKBJINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4E0", Offset = "0x8AA0E0", VA = "0x1808AB4E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2D0", Offset = "0x8FDED0", VA = "0x1808FF2D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5728AA0", Offset = "0x57276A0", VA = "0x185728AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x44ABEB0", Offset = "0x44AAAB0", VA = "0x1844ABEB0", Slot = "8")]
	public bool Equals(FBEMGFEAAMN NPKIIGGBCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xD725F0", Offset = "0xD711F0", VA = "0x180D725F0")]
	public static bool NHPMPBNMAAP(FBEMGFEAAMN FNKIIBFNLFB, FBEMGFEAAMN EDLPJGEPJPK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x337B590", Offset = "0x337A190", VA = "0x18337B590")]
	public static bool CLDCOCNHPOO(FBEMGFEAAMN FNKIIBFNLFB, FBEMGFEAAMN EDLPJGEPJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5728A10", Offset = "0x5727610", VA = "0x185728A10", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MNPPADCIIBD
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int HLKLBBMAGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform IEIKPJEDDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool AFKBKIIMAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFHLHFGGNPE GetBone(int GEPFPFIDHEA);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int GEPFPFIDHEA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class MEHALALDEPC : NGHEBBIDILN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly CPGEGPCDBGJ OFEBHPMIFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int[] OEDPPJBEINL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override FPIFJIGGBEI EBMEJHHKHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x572E530", Offset = "0x572D130", VA = "0x18572E530", Slot = "12")]
		get
		{
			return default(FPIFJIGGBEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 EKJLLIKHDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x572F470", Offset = "0x572E070", VA = "0x18572F470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x572E440", Offset = "0x572D040", VA = "0x18572E440")]
	public MEHALALDEPC(BDGLLOLJIGP IFKKFCHLHMM, CPGEGPCDBGJ OAGMKJFIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x572F890", Offset = "0x572E490", VA = "0x18572F890", Slot = "11")]
	public override bool KONHCMMKGPM(CLEFBGOBOPM IFKKFCHLHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x572E490", Offset = "0x572D090", VA = "0x18572E490", Slot = "13")]
	public override int BCJKBDFBBAI(KACMKOBLJNJ PEMDPBOGJEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x572F7F0", Offset = "0x572E3F0", VA = "0x18572F7F0", Slot = "14")]
	public override int KCFHBJKEKOJ(KACMKOBLJNJ PEMDPBOGJEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x572E930", Offset = "0x572D530", VA = "0x18572E930")]
	private int CBMDCPIPPHA(KACMKOBLJNJ PEMDPBOGJEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x572EBB0", Offset = "0x572D7B0", VA = "0x18572EBB0", Slot = "15")]
	public override void DEKAJJECCFP(KACMKOBLJNJ PEMDPBOGJEA, OMMMHMLCNLM EPJIANIGJCO, int LGEJCLOBPJJ = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JGNDIEIGBMK
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNGBNFHNHKK(DMOIBLHBGCL LIJLAEFJGCI, Renderer CPMIPPDLJEK, int MFBGBBIFLLJ);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMOMNNPPOLI(Renderer CPMIPPDLJEK, JDNGKGNOMOG IAPBIMBBIKC, Vector3 LKBLICPNGJB, Vector3 OKHCHKHKEDL, Vector3 NFDLFODGJEM, float IGGNFOOPNAJ, float PKNFOFCFGHA, float HFAHLKDDFNN = -1f, [Optional] Color? OKGJEMGBDBL, [Optional] IReadOnlyList<Camera> DMPBHDLNBCN);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFODCPHBJIF(Renderer CPMIPPDLJEK, int MFBGBBIFLLJ);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JBFMHPFADGG();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HANBBCLOKMD(int JLMMBDBIMIN, GIKNMFHPAIG LIJLAEFJGCI, Renderer CPMIPPDLJEK, int MFBGBBIFLLJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PFLDJIDDFHC : ONOLPANMIPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class MGKHIKMEJBD : global::NJOKMGHBJBJ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x572FD70", Offset = "0x572E970", VA = "0x18572FD70")]
		public MGKHIKMEJBD(string FHNLBBBEDLN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly JGNDIEIGBMK ICDHJLIJHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly KBOHAOOIBCB AGCCELMJIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private MeshRenderer PFHPNCFMCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private MGKHIKMEJBD FLGGHIGMJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool GLHBJIFBCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private MeshRenderer JOKBLOKFDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private MGKHIKMEJBD IMBABEBBEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool COGHBDFCJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private MeshRenderer CGNOPGDBKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MGKHIKMEJBD BDIIFBGBKOP;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5FF990", Offset = "0x5FE590", VA = "0x1805FF990")]
	public PFLDJIDDFHC(JGNDIEIGBMK BFIEABDMJAJ, KBOHAOOIBCB AGCCELMJIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x57314B0", Offset = "0x57300B0", VA = "0x1857314B0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5731FB0", Offset = "0x5730BB0", VA = "0x185731FB0")]
	private void LCJCNLLLLPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5731D40", Offset = "0x5730940", VA = "0x185731D40", Slot = "4")]
	public void IBCCLPLMPMB(PFHLHFGGNPE IFKKFCHLHMM, GIKNMFHPAIG MGBMKLHMEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5731B70", Offset = "0x5730770", VA = "0x185731B70", Slot = "5")]
	public void IBCCLPLMPMB(LIBJEELBJGH OHEGNDJDGOI, GIKNMFHPAIG MGBMKLHMEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x57313B0", Offset = "0x572FFB0", VA = "0x1857313B0", Slot = "6")]
	public void CBODJKINKMN(LIBJEELBJGH OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x57329D0", Offset = "0x57315D0", VA = "0x1857329D0", Slot = "7")]
	public void NCMHNJOHHDJ(LIBJEELBJGH OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5731B30", Offset = "0x5730730", VA = "0x185731B30", Slot = "8")]
	public void HLPFFNFPBLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x12321C0", Offset = "0x1230DC0", VA = "0x1812321C0", Slot = "9")]
	public void IFIFNFJBHPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x57328A0", Offset = "0x57314A0", VA = "0x1857328A0", Slot = "10")]
	public void NCLGOMNKNFK(GIKNMFHPAIG MGBMKLHMEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5731710", Offset = "0x5730310", VA = "0x185731710", Slot = "11")]
	public void GIFNIHOEOAN(PFHLHFGGNPE IFKKFCHLHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x57318B0", Offset = "0x57304B0", VA = "0x1857318B0", Slot = "12")]
	public void GIFNIHOEOAN(LIBJEELBJGH OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5732FB0", Offset = "0x5731BB0", VA = "0x185732FB0", Slot = "13")]
	public void PFNIPMMFDJG(PFHLHFGGNPE IFKKFCHLHMM, DMOIBLHBGCL LIJLAEFJGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5732E10", Offset = "0x5731A10", VA = "0x185732E10", Slot = "14")]
	public void PFNIPMMFDJG(LIBJEELBJGH OHEGNDJDGOI, DMOIBLHBGCL LIJLAEFJGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5732860", Offset = "0x5731460", VA = "0x185732860", Slot = "17")]
	public void NCAEIDMOPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5731F10", Offset = "0x5730B10", VA = "0x185731F10", Slot = "15")]
	public void JMIPINDKBME(LIBJEELBJGH OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5731680", Offset = "0x5730280", VA = "0x185731680", Slot = "16")]
	public void EBKIJIHHBNK(LIBJEELBJGH OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xF291D0", Offset = "0xF27DD0", VA = "0x180F291D0", Slot = "18")]
	public void DFINOHHAPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5732B80", Offset = "0x5731780", VA = "0x185732B80", Slot = "19")]
	public void PBEOAOGMIAM(DMOIBLHBGCL LIJLAEFJGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5731200", Offset = "0x572FE00", VA = "0x185731200")]
	private void AGOJKBNKAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5732C70", Offset = "0x5731870", VA = "0x185732C70")]
	public void PFNIPMMFDJG(LIBJEELBJGH OHEGNDJDGOI, DMOIBLHBGCL LIJLAEFJGCI, bool PHJACPONPDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5732AC0", Offset = "0x57316C0", VA = "0x185732AC0")]
	private void NNGBNFHNHKK(DMOIBLHBGCL LIJLAEFJGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5732160", Offset = "0x5730D60", VA = "0x185732160", Slot = "20")]
	public void MLNOFLGLDAG(PFHLHFGGNPE IFKKFCHLHMM, Vector3 LKBLICPNGJB, Vector3 OKHCHKHKEDL, Vector3 NFDLFODGJEM, float IGGNFOOPNAJ, float PKNFOFCFGHA, IReadOnlyList<Camera> CFFGMDMJHMN, JDNGKGNOMOG IAPBIMBBIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5732490", Offset = "0x5731090", VA = "0x185732490", Slot = "21")]
	public void MLNOFLGLDAG(FBEMGFEAAMN MDGJMKFLIIF, Vector3 LKBLICPNGJB, Vector3 OKHCHKHKEDL, Vector3 NFDLFODGJEM, float IGGNFOOPNAJ, float PKNFOFCFGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class NGHEBBIDILN : DHNPMPADHKD, OLDLEEMDEGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly BDGLLOLJIGP JOENHKCCFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected Bounds MJPOIBHPBMJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds MEPGCKGDJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x19DBEA0", Offset = "0x19DAAA0", VA = "0x1819DBEA0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual FPIFJIGGBEI EBMEJHHKHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5730FD0", Offset = "0x572FBD0", VA = "0x185730FD0", Slot = "12")]
		get
		{
			return default(FPIFJIGGBEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x721660", Offset = "0x720260", VA = "0x180721660")]
	protected NGHEBBIDILN(BDGLLOLJIGP IFKKFCHLHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5731060", Offset = "0x572FC60", VA = "0x185731060", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "11")]
	public virtual bool KONHCMMKGPM(CLEFBGOBOPM IFKKFCHLHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int BCJKBDFBBAI(KACMKOBLJNJ PEMDPBOGJEA);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int KCFHBJKEKOJ(KACMKOBLJNJ PEMDPBOGJEA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void DEKAJJECCFP(KACMKOBLJNJ PEMDPBOGJEA, OMMMHMLCNLM EPJIANIGJCO, int LGEJCLOBPJJ = -1);
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
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5733150", Offset = "0x5731D50", VA = "0x185733150")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KCHFAGONAJO
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class HBKCNGHODFE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JOBHIKAOLOI : IEnumerable<AKJIGGDNDIP>, IEnumerable, IEnumerator<AKJIGGDNDIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private AKJIGGDNDIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private AKJIGGDNDIP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3E0", Offset = "0x6FBFE0", VA = "0x1806FD3E0")]
		[DebuggerHidden]
		public JOBHIKAOLOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x572D1D0", Offset = "0x572BDD0", VA = "0x18572D1D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x572D340", Offset = "0x572BF40", VA = "0x18572D340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x572D2B0", Offset = "0x572BEB0", VA = "0x18572D2B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AKJIGGDNDIP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x572D2B0", Offset = "0x572BEB0", VA = "0x18572D2B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const int HOLHKJICHJI = 3;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static AKJIGGDNDIP[][] LFFMAGGAFPJ;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static BMMLGEMMGOM JHOIDFPFFFM;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static ShapeRendererConfig AIAECJCINBI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader KLAKNDMCKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5729D80", Offset = "0x5728980", VA = "0x185729D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer DIGIMEKBIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5729410", Offset = "0x5728010", VA = "0x185729410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5729650", Offset = "0x5728250", VA = "0x185729650")]
	public static Mesh HGFINEMLFGA(KCHFAGONAJO DEFBLFLFOGF, int PEMDPBOGJEA = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5729480", Offset = "0x5728080", VA = "0x185729480")]
	public static int ENOJLGDAACI(KCHFAGONAJO DEFBLFLFOGF, int PEMDPBOGJEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5729E50", Offset = "0x5728A50", VA = "0x185729E50")]
	public static BMMLGEMMGOM NANGJGPFHNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5729DF0", Offset = "0x57289F0", VA = "0x185729DF0")]
	[IteratorStateMachine(typeof(JOBHIKAOLOI))]
	private static IEnumerable<AKJIGGDNDIP> MPGNBFIGEOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x57290D0", Offset = "0x5727CD0", VA = "0x1857290D0")]
	public static AKJIGGDNDIP AIJNGHKCFGO(KCHFAGONAJO DEFBLFLFOGF, int PEMDPBOGJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5729710", Offset = "0x5728310", VA = "0x185729710")]
	public static bool HPALIOACLNK(this KCHFAGONAJO DEFBLFLFOGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5729490", Offset = "0x5728090", VA = "0x185729490")]
	public static void FPPPMPGAHCD(KCHFAGONAJO DEFBLFLFOGF, float3 EFLNMPCJLFM, out KBODILPEDIM GDDFPACBGIP, out float3 KDBELICJFLD, out float FPHFDLJKOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5729740", Offset = "0x5728340", VA = "0x185729740")]
	public static void INEOBAONOOA(Vector3 EFLNMPCJLFM, KCHFAGONAJO DEFBLFLFOGF, out Vector3 KDBELICJFLD, out float FPHFDLJKOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5729730", Offset = "0x5728330", VA = "0x185729730")]
	[HMEMFDNPCPH(LFKBPELDMLK.ExitingPlayMode, 0)]
	private static void IMBCANEHKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5729B60", Offset = "0x5728760", VA = "0x185729B60")]
	[HMEMFDNPCPH(LFKBPELDMLK.ExitingPlayMode, 0)]
	private static void JDLGHACCIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EOEKMMFLKAG
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool NKLDDFPGDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material FBFNMPPAKIA();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material IKAGIHODIMG();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material FPCHIDHNOJM();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IMDEPPFPLJL(LIIOGCDDKAE POIEFCEPMGD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OKOLMBPGPBA(JIGICGEOCBJ DOJDAHGKNOD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNICLJKIINJ(GameObject EBMPLNBFAKM);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EPEDGJIMIEK(GameObject EBMPLNBFAKM, bool GDAHFGCDAKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface KBOHAOOIBCB
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BDGLLOLJIGP GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	NGHEBBIDILN GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	HMINGIHFMHJ GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class JMCBMDKLCPB : CCDCDCKBHOC, IDisposable, KBOHAOOIBCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly global::BBIJONEMJFB<PFHLHFGGNPE, BDGLLOLJIGP> PMDAGGHHMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly global::BBIJONEMJFB<LIBJEELBJGH, NGHEBBIDILN> OACBGOOFHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly global::BBIJONEMJFB<FBEMGFEAAMN, HMINGIHFMHJ> EMNNNGPJFCG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static EOEKMMFLKAG CNEHONKEBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x572C280", Offset = "0x572AE80", VA = "0x18572C280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x572C8A0", Offset = "0x572B4A0", VA = "0x18572C8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BDGLLOLJIGP GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x572C700", Offset = "0x572B300", VA = "0x18572C700", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NGHEBBIDILN GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x572C7C0", Offset = "0x572B3C0", VA = "0x18572C7C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public HMINGIHFMHJ GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x572C760", Offset = "0x572B360", VA = "0x18572C760", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x572CD60", Offset = "0x572B960", VA = "0x18572CD60")]
	public JMCBMDKLCPB(EOEKMMFLKAG BFIEABDMJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x572C2C0", Offset = "0x572AEC0", VA = "0x18572C2C0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x572C040", Offset = "0x572AC40", VA = "0x18572C040", Slot = "4")]
	public PFHLHFGGNPE AIPGCFMGAOB(OHPABHHJPBL OAGMKJFIKKL)
	{
		return default(PFHLHFGGNPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x572CD00", Offset = "0x572B900", VA = "0x18572CD00", Slot = "5")]
	public void NFNNBJKBEDP(PFHLHFGGNPE IFKKFCHLHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x572C820", Offset = "0x572B420", VA = "0x18572C820", Slot = "6")]
	public void FNPCPKFPJDA(PFHLHFGGNPE IFKKFCHLHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x572CB70", Offset = "0x572B770", VA = "0x18572CB70", Slot = "15")]
	public IEnumerable<Renderer> JOIAPGABIJA(PFHLHFGGNPE IFKKFCHLHMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x572CA80", Offset = "0x572B680", VA = "0x18572CA80", Slot = "7")]
	public LIBJEELBJGH ILPNHPELKIC(PFHLHFGGNPE IFKKFCHLHMM, CPGEGPCDBGJ OAGMKJFIKKL)
	{
		return default(LIBJEELBJGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x572C190", Offset = "0x572AD90", VA = "0x18572C190", Slot = "8")]
	public LIBJEELBJGH APJDDJAEBBE(PFHLHFGGNPE IFKKFCHLHMM, JIOPMELHODL OAGMKJFIKKL)
	{
		return default(LIBJEELBJGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x572C120", Offset = "0x572AD20", VA = "0x18572C120", Slot = "10")]
	public void AMMKIGMJLGN(LIBJEELBJGH OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x572BFE0", Offset = "0x572ABE0", VA = "0x18572BFE0", Slot = "9")]
	public void ACPENJEIKJM(LIBJEELBJGH OHEGNDJDGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x572C8F0", Offset = "0x572B4F0", VA = "0x18572C8F0", Slot = "11")]
	public FBEMGFEAAMN IKMCHNOLHFC(MNPPADCIIBD OAGMKJFIKKL)
	{
		return default(FBEMGFEAAMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x572CC90", Offset = "0x572B890", VA = "0x18572CC90", Slot = "13")]
	public void MKANFDIFKNJ(FBEMGFEAAMN MDGJMKFLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x572CC30", Offset = "0x572B830", VA = "0x18572CC30", Slot = "12")]
	public void KGAFIEONCJH(FBEMGFEAAMN MDGJMKFLIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x572C330", Offset = "0x572AF30", VA = "0x18572C330", Slot = "14")]
	public BNNFCKHAFIM EBJEAPDLMDM(CLEFBGOBOPM PAFFPLOLNJJ, IEnumerable<LIBJEELBJGH> OACBGOOFHNG, int APGONGJDFCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HMINGIHFMHJ : MKKBPNFBIAG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HBOGNMKEJCE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public HMINGIHFMHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3E0", Offset = "0x6FBFE0", VA = "0x1806FD3E0")]
		[DebuggerHidden]
		public HBOGNMKEJCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x572A300", Offset = "0x5728F00", VA = "0x18572A300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x572A020", Offset = "0x5728C20", VA = "0x18572A020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x572A3A0", Offset = "0x5728FA0", VA = "0x18572A3A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x572A2B0", Offset = "0x5728EB0", VA = "0x18572A2B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x572A210", Offset = "0x5728E10", VA = "0x18572A210", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x572A210", Offset = "0x5728E10", VA = "0x18572A210", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly MNPPADCIIBD IEDPMAGJOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly KBOHAOOIBCB AGCCELMJIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private DOKPBKOADJK GANDHOMFGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private List<NFMCBJOPHLN> EIODAKOCNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private List<NFMCBJOPHLN> DFDMACBABHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private GameObject NDJOBIEPLIM;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x572B670", Offset = "0x572A270", VA = "0x18572B670")]
	public static HMINGIHFMHJ PALNCKDOEKO(MNPPADCIIBD OAGMKJFIKKL, KBOHAOOIBCB AGCCELMJIHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x572B7D0", Offset = "0x572A3D0", VA = "0x18572B7D0")]
	private HMINGIHFMHJ(MNPPADCIIBD OAGMKJFIKKL, KBOHAOOIBCB AGCCELMJIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x572A450", Offset = "0x5729050", VA = "0x18572A450")]
	public void BMILBDCJANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x572A3E0", Offset = "0x5728FE0", VA = "0x18572A3E0")]
	[IteratorStateMachine(typeof(HBOGNMKEJCE))]
	public IEnumerable<Renderer> BEACGHNNDJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x572A9A0", Offset = "0x57295A0", VA = "0x18572A9A0", Slot = "4")]
	public void CINHNPNOCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x572B410", Offset = "0x572A010", VA = "0x18572B410")]
	private void ENCEBNONKIB(Vector3 FGDCKGKNMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x572B440", Offset = "0x572A040", VA = "0x18572B440")]
	public void KLCBFOGAMFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NFMCBJOPHLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct OHEGFLAMAMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public OMMMHMLCNLM JIOOBEKKBMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CLEFBGOBOPM DNKNIEKJKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int LIMDAJIGGCN;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class HGDIANMBJDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public NFMCBJOPHLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public KACMKOBLJNJ lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public List<OHEGFLAMAMI> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public HGDIANMBJDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EJMPBCKNMIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public BNNFCKHAFIM combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public HGDIANMBJDE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public EJMPBCKNMIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x57287D0", Offset = "0x57273D0", VA = "0x1857287D0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5728840", Offset = "0x5727440", VA = "0x185728840")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5728880", Offset = "0x5727480", VA = "0x185728880")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private int[] FMAJJJKJNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private GEDCDBJODCK FHKMIKMJGGL;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static Matrix4x4 AMLKLEDJFNA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh OAAANAPFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC490", Offset = "0x5EB090", VA = "0x1805EC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int NJFBFLFDIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x678670", Offset = "0x677270", VA = "0x180678670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x73E910", Offset = "0x73D510", VA = "0x18073E910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x57303D0", Offset = "0x572EFD0", VA = "0x1857303D0")]
	public void GGIHBBMHAOE(List<CLEFBGOBOPM> JCPCOPLIDOJ, Matrix4x4[] NFCMLMLOAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x572FDC0", Offset = "0x572E9C0", VA = "0x18572FDC0")]
	public static List<NFMCBJOPHLN> DPFIJBHMAAN(List<BDGLLOLJIGP> AEGGNMJJENI, KACMKOBLJNJ PEMDPBOGJEA, Bounds FLJOMBKKJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5730600", Offset = "0x572F200", VA = "0x185730600")]
	private JobHandle HIGPABACDFA(BNNFCKHAFIM LCFLAHPICLH, int LJFCHHIGIIJ, int NJPKIMOEFFL, KACMKOBLJNJ PEMDPBOGJEA, List<OHEGFLAMAMI> GJIMPLIMGLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x57309E0", Offset = "0x572F5E0", VA = "0x1857309E0")]
	private void ICNCFMJOOKI(List<OHEGFLAMAMI> GJIMPLIMGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5730C20", Offset = "0x572F820", VA = "0x185730C20")]
	private NFMCBJOPHLN(List<OHEGFLAMAMI> GJIMPLIMGLL, int LJFCHHIGIIJ, int NJPKIMOEFFL, KACMKOBLJNJ PEMDPBOGJEA, Bounds FLJOMBKKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5730350", Offset = "0x572EF50", VA = "0x185730350", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private MaterialPropertyBlock KDJNGDGGICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private NFMCBJOPHLN NIFBJJIIANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private List<CLEFBGOBOPM> AJONJLJFPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private RenderTexture POILLFIDJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private ComputeBuffer DGOFIPHNCFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private ComputeShader EEMBCNMPHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private Matrix4x4[] BPJHLEBFIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int CPBBKEDEFMO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer GHKAHMJCHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int HLKLBBMAGGA
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5733CD0", Offset = "0x57328D0", VA = "0x185733CD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5733180", Offset = "0x5731D80", VA = "0x185733180")]
		public static List<SkinnedShapeRenderer> Create(GameObject IFKKFCHLHMM, List<NFMCBJOPHLN> LFKKHHJEJCM, List<CLEFBGOBOPM> AJONJLJFPPO, Material CLAPLIKDDHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5733540", Offset = "0x5732140", VA = "0x185733540")]
		public void Init(NFMCBJOPHLN NIFBJJIIANL, List<CLEFBGOBOPM> AJONJLJFPPO, Material CLAPLIKDDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5733A30", Offset = "0x5732630", VA = "0x185733A30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x57339A0", Offset = "0x57325A0", VA = "0x1857339A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5733960", Offset = "0x5732560", VA = "0x185733960")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5733AC0", Offset = "0x57326C0", VA = "0x185733AC0")]
		private void PDKNNOIAOCG(ScriptableRenderContext NAEOEJMOBMH, Camera[] OLKFNFKFJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5733390", Offset = "0x5731F90", VA = "0x185733390")]
		private void GGIHBBMHAOE(CommandBuffer HKFLAKBCJAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5728E10", Offset = "0x5727A10", VA = "0x185728E10")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5728AE0", Offset = "0x57276E0", VA = "0x185728AE0")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
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
