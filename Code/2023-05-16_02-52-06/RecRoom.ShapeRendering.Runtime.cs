using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
public enum IIGBEHGCPNH
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
public static class LEAPDMLPAGE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C80F60", Offset = "0x5C7FD60", VA = "0x185C80F60")]
	public static bool GPGGFDDNNMI(this IIGBEHGCPNH BKPAODAIKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C80F80", Offset = "0x5C7FD80", VA = "0x185C80F80")]
	public static bool IAONLFAOAHO(this IIGBEHGCPNH BKPAODAIKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C80F90", Offset = "0x5C7FD90", VA = "0x185C80F90")]
	public static bool LEAGKOGOHOK(this IIGBEHGCPNH BKPAODAIKAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CDBIPHNIDEL
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
public enum NKKAOEPGDLO
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
public enum NFGOLKNMBLF
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
public enum BHFBDBAEJOH
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
public class BGENMDJDLDE : BEPBLMNNOKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private const byte DPAPOEGJPBG = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private byte KBCCDEOCMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<SkinnedShapeRenderer>[] EIPJKFFPFOJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OMCBIJKDAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x740010", Offset = "0x73EE10", VA = "0x180740010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x78AEA0", Offset = "0x789CA0", VA = "0x18078AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EGPGJBMEIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x761F20", Offset = "0x760D20", VA = "0x180761F20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8DADD0", Offset = "0x8D9BD0", VA = "0x1808DADD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float FFKGAKPIIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x113CED0", Offset = "0x113BCD0", VA = "0x18113CED0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x151D920", Offset = "0x151C720", VA = "0x18151D920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JBLAAHGECMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1107620", Offset = "0x1106420", VA = "0x181107620", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x11077D0", Offset = "0x11065D0", VA = "0x1811077D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GOFOMGHADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C71D50", Offset = "0x5C70B50", VA = "0x185C71D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> BOHLPFDMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C71DB0", Offset = "0x5C70BB0", VA = "0x185C71DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject GLGKEOALGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte CDOLJCKIPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C71DF0", Offset = "0x5C70BF0", VA = "0x185C71DF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C71FD0", Offset = "0x5C70DD0", VA = "0x185C71FD0")]
	public BGENMDJDLDE(List<EPINIDFCICA> DPKAELJCPKJ, List<EPINIDFCICA> LBPJOLEJEME, List<CGKNHINOJKA> DEPKPJPMGDM, Material ECFGNJLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C71B10", Offset = "0x5C70910", VA = "0x185C71B10")]
	private int DDPIPBFFANF(List<EPINIDFCICA> HNMFNENMBGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C71E40", Offset = "0x5C70C40", VA = "0x185C71E40")]
	private void LGIJCAABJEN(int POEAKJLCPCO, bool JNINJIMCJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C71A70", Offset = "0x5C70870", VA = "0x185C71A70")]
	public void BAHNGMEHHBA(Vector3 ONIGCKNCKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C71C20", Offset = "0x5C70A20", VA = "0x185C71C20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C71F90", Offset = "0x5C70D90", VA = "0x185C71F90")]
	public void MMJLAJJHNDJ(Transform FIGOIOCGIPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JEINPDENMNH : NEPOJPIIHBK, PIHLELNNOBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ECDFHBLKDAB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public JEINPDENMNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public ECDFHBLKDAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5C741F0", Offset = "0x5C72FF0", VA = "0x185C741F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5C73CC0", Offset = "0x5C72AC0", VA = "0x185C73CC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5C742F0", Offset = "0x5C730F0", VA = "0x185C742F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5C74340", Offset = "0x5C73140", VA = "0x185C74340")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5C74390", Offset = "0x5C73190", VA = "0x185C74390")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5C741B0", Offset = "0x5C72FB0", VA = "0x185C741B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C74110", Offset = "0x5C72F10", VA = "0x185C74110", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5C74110", Offset = "0x5C72F10", VA = "0x185C74110", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EFCGNLMDPJJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public JEINPDENMNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public EFCGNLMDPJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5C747A0", Offset = "0x5C735A0", VA = "0x185C747A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5C743E0", Offset = "0x5C731E0", VA = "0x185C743E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5C74880", Offset = "0x5C73680", VA = "0x185C74880")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5C748D0", Offset = "0x5C736D0", VA = "0x185C748D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5C74760", Offset = "0x5C73560", VA = "0x185C74760", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5C746C0", Offset = "0x5C734C0", VA = "0x185C746C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5C746C0", Offset = "0x5C734C0", VA = "0x185C746C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly GHKIFKLCPOG OABPHFCAHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly List<FEDNGAGAIMM> HPIBAEBMICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<ClusterMeshRenderer> OGDEMIMPONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BatchedMeshRenderer NFJLFJHFCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool IBIDPOOHLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool NBABBFNMBKM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<PJCNHMOEBLB> DIIAPMBADJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MBGMOKMGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5C7DCA0", Offset = "0x5C7CAA0", VA = "0x185C7DCA0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CGKNHINOJKA GIFIHEANMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5C7DCE0", Offset = "0x5C7CAE0", VA = "0x185C7DCE0", Slot = "7")]
		get
		{
			return default(CGKNHINOJKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> GMBAOLANNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x748BC0", Offset = "0x7479C0", VA = "0x180748BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C7DDB0", Offset = "0x5C7CBB0", VA = "0x185C7DDB0")]
	private bool MIFNGCMAALE(FEDNGAGAIMM MPLDPOHNALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C7CA70", Offset = "0x5C7B870", VA = "0x185C7CA70")]
	private static bool CBCDNOPAIMM(FEDNGAGAIMM MPLDPOHNALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C7DF80", Offset = "0x5C7CD80", VA = "0x185C7DF80")]
	public JEINPDENMNH(GHKIFKLCPOG MMJOHADFCHO, bool NBNNIEGOGCA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C7CD20", Offset = "0x5C7BB20", VA = "0x185C7CD20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C7DDD0", Offset = "0x5C7CBD0", VA = "0x185C7DDD0")]
	public void OEECIDDHIAM(FEDNGAGAIMM MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C7CB80", Offset = "0x5C7B980", VA = "0x185C7CB80")]
	public void CJGLMEKHGBL(FEDNGAGAIMM MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C7D730", Offset = "0x5C7C530", VA = "0x185C7D730", Slot = "4")]
	public void KANAHMFJHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C7CE80", Offset = "0x5C7BC80", VA = "0x185C7CE80")]
	public void FPKIEKJDLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C7C840", Offset = "0x5C7B640", VA = "0x185C7C840")]
	private void AINHDFAOHKG(List<FEDNGAGAIMM> HPIBAEBMICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C7CA90", Offset = "0x5C7B890", VA = "0x185C7CA90")]
	private static Material CDDFCIJDOHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C7C9D0", Offset = "0x5C7B7D0", VA = "0x185C7C9D0")]
	private void AINHDFAOHKG(FEDNGAGAIMM MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C7D660", Offset = "0x5C7C460", VA = "0x185C7D660")]
	private void HOAFPNDCJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C7D0D0", Offset = "0x5C7BED0", VA = "0x185C7D0D0")]
	public void HLBGDKNGABB(bool DMANOLANLMH, bool ENDEKKBFFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C7CAF0", Offset = "0x5C7B8F0", VA = "0x185C7CAF0")]
	protected void CFIADDOFDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C7D5F0", Offset = "0x5C7C3F0", VA = "0x185C7D5F0")]
	[IteratorStateMachine(typeof(ECDFHBLKDAB))]
	public IEnumerable<Renderer> HNMFGCGCIBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C7CCB0", Offset = "0x5C7BAB0", VA = "0x185C7CCB0")]
	[IteratorStateMachine(typeof(EFCGNLMDPJJ))]
	public IEnumerable<Renderer> CLOLGCEJCMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class GCHGBPGIABH : FEDNGAGAIMM
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct PLJNDJMOCFH : DBJGBDLBBIM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private ELJAEBELGHC MGJAECMCOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JobHandle BACBCMPFGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IPLPLCOKHNI DLMGELGPDMB;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5C82A50", Offset = "0x5C81850", VA = "0x185C82A50")]
		public PLJNDJMOCFH(ELJAEBELGHC MGJAECMCOFA, JobHandle BACBCMPFGHN, IPLPLCOKHNI DLMGELGPDMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x967680", Offset = "0x966480", VA = "0x180967680")]
		public bool MNPJEDKKEAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5C82A20", Offset = "0x5C81820", VA = "0x185C82A20", Slot = "4")]
		public ELJAEBELGHC IFBNIOMHDFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5C829D0", Offset = "0x5C817D0", VA = "0x185C829D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly BDPELCGMEEI FHKFGFLJCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private float GIEIFMCJLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Hash128 KFGMAEACDJG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 HDMDJMBMPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5C7B490", Offset = "0x5C7A290", VA = "0x185C7B490", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5C7C630", Offset = "0x5C7B430", VA = "0x185C7C630")]
	public GCHGBPGIABH(JEINPDENMNH LFLMFMLCFKL, BDPELCGMEEI MMJOHADFCHO, bool NBNNIEGOGCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "16")]
	public override bool OGOLCJIFHKF(CGKNHINOJKA LFLMFMLCFKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C7B2A0", Offset = "0x5C7A0A0", VA = "0x185C7B2A0", Slot = "18")]
	public override int DDPIPBFFANF(FBDEGFCGHEA LFNOJPBABGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5C7AEF0", Offset = "0x5C79CF0", VA = "0x185C7AEF0", Slot = "19")]
	public override int AGKPEIBHJDD(FBDEGFCGHEA LFNOJPBABGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5C7BF50", Offset = "0x5C7AD50", VA = "0x185C7BF50", Slot = "20")]
	public override void KNHELFBADFB(FBDEGFCGHEA LFNOJPBABGG, CKAKFNCIKOJ ODGCJDCFKAM, int CJHIIHBIGBC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5C7B5C0", Offset = "0x5C7A3C0", VA = "0x185C7B5C0", Slot = "21")]
	public override CGKNHINOJKA HJHMDDGMDEN()
	{
		return default(CGKNHINOJKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5C7B0E0", Offset = "0x5C79EE0", VA = "0x185C7B0E0", Slot = "23")]
	public override PPOBKPNDAGC CCENEFFEJAA()
	{
		return default(PPOBKPNDAGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5C7B690", Offset = "0x5C7A490", VA = "0x185C7B690", Slot = "24")]
	public override DBJGBDLBBIM IMKMFBMAGNA(FBDEGFCGHEA LFNOJPBABGG, JobHandle BACBCMPFGHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IOFBIIGNAIE : global::BIINDPJIKMP<IOFBIIGNAIE>, JMOHLFDBGCE, IEquatable<IOFBIIGNAIE>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[CreateProperty]
	public int CEEBBJGGBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x80A490", Offset = "0x809290", VA = "0x18080A490", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[CreateProperty]
	public int KAKKJFDONBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x90B640", Offset = "0x90A440", VA = "0x18090B640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xF02C00", Offset = "0xF01A00", VA = "0x180F02C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool EMDPCLDELLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5C7C6E0", Offset = "0x5C7B4E0", VA = "0x185C7C6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x412E980", Offset = "0x412D780", VA = "0x18412E980", Slot = "8")]
	public bool Equals(IOFBIIGNAIE IDBPJJAKCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xD72FF0", Offset = "0xD71DF0", VA = "0x180D72FF0")]
	public static bool EJGLOGBEPOL(IOFBIIGNAIE GCKGDDMIIDO, IOFBIIGNAIE EJKHFJILHAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x50C34A0", Offset = "0x50C22A0", VA = "0x1850C34A0")]
	public static bool IKFCAHNLBFO(IOFBIIGNAIE GCKGDDMIIDO, IOFBIIGNAIE EJKHFJILHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C7C720", Offset = "0x5C7B520", VA = "0x185C7C720", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C7C7B0", Offset = "0x5C7B5B0", VA = "0x185C7C7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum CDGPCPDNLEB
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GHKIFKLCPOG
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	CGKNHINOJKA BENGFKCGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CDGPCPDNLEB CKLAPMMBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NBKBOKJEMMD : global::BIINDPJIKMP<NBKBOKJEMMD>, JMOHLFDBGCE, IEquatable<NBKBOKJEMMD>
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	[CreateProperty]
	public int CEEBBJGGBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x80A490", Offset = "0x809290", VA = "0x18080A490", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	[CreateProperty]
	public int KAKKJFDONBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x90B640", Offset = "0x90A440", VA = "0x18090B640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF02C00", Offset = "0xF01A00", VA = "0x180F02C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EMDPCLDELLN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5C82340", Offset = "0x5C81140", VA = "0x185C82340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x412E980", Offset = "0x412D780", VA = "0x18412E980", Slot = "8")]
	public bool Equals(NBKBOKJEMMD IDBPJJAKCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xD72FF0", Offset = "0xD71DF0", VA = "0x180D72FF0")]
	public static bool EJGLOGBEPOL(NBKBOKJEMMD GCKGDDMIIDO, NBKBOKJEMMD EJKHFJILHAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x50C34A0", Offset = "0x50C22A0", VA = "0x1850C34A0")]
	public static bool IKFCAHNLBFO(NBKBOKJEMMD GCKGDDMIIDO, NBKBOKJEMMD EJKHFJILHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5C82380", Offset = "0x5C81180", VA = "0x185C82380", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5C82410", Offset = "0x5C81210", VA = "0x185C82410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AHCDBIFHDAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MCEEJPOLCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OAMGDPDJODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CGKNHINOJKA BENGFKCGCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float JFCGHIFMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	Vector3 OJOMAPMLKOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	IIGBEHGCPNH BFGKLDICFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	CDBIPHNIDEL EEKMNGOBPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MOPLOMLGPLJ : AHCDBIFHDAB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KGPFCACJPNE GOHDKFDJOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CECELJEOKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BDPELCGMEEI : AHCDBIFHDAB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool NBKPMOFBJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool BJMCCCPCDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float NKGOJFCEIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int AMNJDKPAHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool AEDKCMKEPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	int NHAAIPMJABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<DBIDIFELALE> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EOEFFAIFFNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPCPKEKDJCN(IOFBIIGNAIE LFLMFMLCFKL, NFGOLKNMBLF BJJHMHPLIBG);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPCPKEKDJCN(NBKBOKJEMMD MPLDPOHNALP, NFGOLKNMBLF BJJHMHPLIBG);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGDKHBFLDPG(NBKBOKJEMMD MPLDPOHNALP);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPDAKCLHHGK(NBKBOKJEMMD MPLDPOHNALP);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHBMLIPMJOO();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCIJICKGJPN();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NJHBMPILOIN(NFGOLKNMBLF LEDIIMFEFLP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IOPCJAKNIFF(IOFBIIGNAIE LFLMFMLCFKL);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IOPCJAKNIFF(NBKBOKJEMMD MPLDPOHNALP);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LFHINCGMIBG(IOFBIIGNAIE LFLMFMLCFKL, BHFBDBAEJOH LEDIIMFEFLP);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LFHINCGMIBG(NBKBOKJEMMD MPLDPOHNALP, BHFBDBAEJOH LEDIIMFEFLP);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FAHLPFANEGM(NBKBOKJEMMD MPLDPOHNALP);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JMHBNHGEELP(NBKBOKJEMMD MPLDPOHNALP);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PFABKAFGBPC();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BKEEAFAJDJC();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OLEEEJLKFEI(BHFBDBAEJOH LEDIIMFEFLP);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KGPMHJEIEMH(IOFBIIGNAIE LFLMFMLCFKL, Vector3 AKDOOFNLGFD, Vector3 FCLMLADLPEM, Vector3 BPCDEGKEPND, float PGPJGBICIHO, float HAMEDJLPMDM, IReadOnlyList<Camera> NNHBIBINMCN, NKKAOEPGDLO FLFMDCPMLEN);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KGPMHJEIEMH(LMIFOMEINKA AJGGCANOMAJ, Vector3 AKDOOFNLGFD, Vector3 FCLMLADLPEM, Vector3 BPCDEGKEPND, float PGPJGBICIHO, float HAMEDJLPMDM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public interface DIFMJNJGJPO
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	JEINPDENMNH BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	FEDNGAGAIMM BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ECBPJMBCKCP BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HLLPHPCGGMK : DIFMJNJGJPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool AEJAHGCEBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOFBIIGNAIE IBMIOPOKHPE(GHKIFKLCPOG MMJOHADFCHO);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IOFBIIGNAIE IBMIOPOKHPE(GHKIFKLCPOG MMJOHADFCHO, bool MCKNIPPABHG);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGECKBFGKAE(IOFBIIGNAIE LFLMFMLCFKL);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IOHDAMMPKCO(IOFBIIGNAIE LFLMFMLCFKL);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NBKBOKJEMMD MKJOHCLOIMM(IOFBIIGNAIE LFLMFMLCFKL, MOPLOMLGPLJ MMJOHADFCHO);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NBKBOKJEMMD ALHNGIKJMDI(IOFBIIGNAIE LFLMFMLCFKL, BDPELCGMEEI MMJOHADFCHO);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OMFMLENKODF(NBKBOKJEMMD MPLDPOHNALP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LJBENGFBFPF(NBKBOKJEMMD MPLDPOHNALP);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LMIFOMEINKA PNIDOCFPJLN(BBPKLCLHFGC MMJOHADFCHO);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ENBGPGNBPMN(LMIFOMEINKA AJGGCANOMAJ);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCFIMOMMKID(LMIFOMEINKA AJGGCANOMAJ);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task MPHNMNOLMJH();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task PEFIJCKCIPC();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task OOBEDEIFGFF();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BKCPMNIDKOC();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	ELJAEBELGHC BIDPEMGPIKL(CGKNHINOJKA LOCMJJNJNPO, IEnumerable<NBKBOKJEMMD> HPIBAEBMICI, int CGEAIEJNEBJ);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerable<Renderer> MGMPKMDMKEN(IOFBIIGNAIE LFLMFMLCFKL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LMIFOMEINKA : global::BIINDPJIKMP<LMIFOMEINKA>, JMOHLFDBGCE, IEquatable<LMIFOMEINKA>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int CEEBBJGGBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x80A490", Offset = "0x809290", VA = "0x18080A490", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KAKKJFDONBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x90B640", Offset = "0x90A440", VA = "0x18090B640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xF02C00", Offset = "0xF01A00", VA = "0x180F02C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool EMDPCLDELLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5C80FC0", Offset = "0x5C7FDC0", VA = "0x185C80FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x412E980", Offset = "0x412D780", VA = "0x18412E980", Slot = "8")]
	public bool Equals(LMIFOMEINKA IDBPJJAKCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xD72FF0", Offset = "0xD71DF0", VA = "0x180D72FF0")]
	public static bool EJGLOGBEPOL(LMIFOMEINKA GCKGDDMIIDO, LMIFOMEINKA EJKHFJILHAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x50C34A0", Offset = "0x50C22A0", VA = "0x1850C34A0")]
	public static bool IKFCAHNLBFO(LMIFOMEINKA GCKGDDMIIDO, LMIFOMEINKA EJKHFJILHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5C81000", Offset = "0x5C7FE00", VA = "0x185C81000", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BBPKLCLHFGC
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	int OGAHCGNGPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Transform ENIHDKAONFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool IKMFMLMLBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IOFBIIGNAIE GetBone(int KBDIELFGIHI);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int KBDIELFGIHI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class EHNDCAKDGNP : HLLPHPCGGMK, DIFMJNJGJPO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct KPOHIIIIKOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public EHNDCAKDGNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5C7E6A0", Offset = "0x5C7D4A0", VA = "0x185C7E6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly global::PMBPJEJLGAL<IOFBIIGNAIE, JEINPDENMNH> NJABBHKPOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly global::PMBPJEJLGAL<NBKBOKJEMMD, FEDNGAGAIMM> HPIBAEBMICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly global::PMBPJEJLGAL<LMIFOMEINKA, ECBPJMBCKCP> ODLIHEKHAAM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JEINPDENMNH BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C756F0", Offset = "0x5C744F0", VA = "0x185C756F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FEDNGAGAIMM BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5C75750", Offset = "0x5C74550", VA = "0x185C75750", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ECBPJMBCKCP BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5C757B0", Offset = "0x5C745B0", VA = "0x185C757B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool AEJAHGCEBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x812860", Offset = "0x811660", VA = "0x180812860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5C77190", Offset = "0x5C75F90", VA = "0x185C77190")]
	public EHNDCAKDGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5C754F0", Offset = "0x5C742F0", VA = "0x185C754F0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5C75810", Offset = "0x5C74610", VA = "0x185C75810", Slot = "4")]
	public IOFBIIGNAIE IBMIOPOKHPE(GHKIFKLCPOG MMJOHADFCHO)
	{
		return default(IOFBIIGNAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5C75820", Offset = "0x5C74620", VA = "0x185C75820", Slot = "5")]
	public IOFBIIGNAIE IBMIOPOKHPE(GHKIFKLCPOG MMJOHADFCHO, bool NBNNIEGOGCA)
	{
		return default(IOFBIIGNAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5C75E50", Offset = "0x5C74C50", VA = "0x185C75E50", Slot = "6")]
	public void LGECKBFGKAE(IOFBIIGNAIE LFLMFMLCFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5C75AC0", Offset = "0x5C748C0", VA = "0x185C75AC0", Slot = "7")]
	public void IOHDAMMPKCO(IOFBIIGNAIE LFLMFMLCFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5C76540", Offset = "0x5C75340", VA = "0x185C76540", Slot = "8")]
	public NBKBOKJEMMD MKJOHCLOIMM(IOFBIIGNAIE LFLMFMLCFKL, MOPLOMLGPLJ MMJOHADFCHO)
	{
		return default(NBKBOKJEMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5C74920", Offset = "0x5C73720", VA = "0x185C74920", Slot = "9")]
	public NBKBOKJEMMD ALHNGIKJMDI(IOFBIIGNAIE LFLMFMLCFKL, BDPELCGMEEI MMJOHADFCHO)
	{
		return default(NBKBOKJEMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5C760D0", Offset = "0x5C74ED0", VA = "0x185C760D0", Slot = "11")]
	public void LJBENGFBFPF(NBKBOKJEMMD MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5C76C30", Offset = "0x5C75A30", VA = "0x185C76C30", Slot = "10")]
	public void OMFMLENKODF(NBKBOKJEMMD MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5C764D0", Offset = "0x5C752D0", VA = "0x185C764D0", Slot = "21")]
	public IEnumerable<Renderer> MGMPKMDMKEN(IOFBIIGNAIE LFLMFMLCFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5C77110", Offset = "0x5C75F10", VA = "0x185C77110", Slot = "12")]
	public LMIFOMEINKA PNIDOCFPJLN(BBPKLCLHFGC MMJOHADFCHO)
	{
		return default(LMIFOMEINKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5C76BC0", Offset = "0x5C759C0", VA = "0x185C76BC0", Slot = "14")]
	public void NCFIMOMMKID(LMIFOMEINKA AJGGCANOMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5C76A50", Offset = "0x5C75850", VA = "0x185C76A50", Slot = "16")]
	public Task MPHNMNOLMJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5C76FB0", Offset = "0x5C75DB0", VA = "0x185C76FB0", Slot = "17")]
	public Task PEFIJCKCIPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5C76EB0", Offset = "0x5C75CB0", VA = "0x185C76EB0", Slot = "18")]
	[AsyncStateMachine(typeof(KPOHIIIIKOC))]
	public Task OOBEDEIFGFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5C75460", Offset = "0x5C74260", VA = "0x185C75460", Slot = "19")]
	public void BKCPMNIDKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5C75690", Offset = "0x5C74490", VA = "0x185C75690", Slot = "13")]
	public void ENBGPGNBPMN(LMIFOMEINKA AJGGCANOMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5C74E30", Offset = "0x5C73C30", VA = "0x185C74E30", Slot = "20")]
	public ELJAEBELGHC BIDPEMGPIKL(CGKNHINOJKA BICKPKDCFNO, IEnumerable<NBKBOKJEMMD> HPIBAEBMICI, int CGEAIEJNEBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class FBINNHLLCMB : FEDNGAGAIMM
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct NNGDNPHDGDD : DBJGBDLBBIM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private ELJAEBELGHC MGJAECMCOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private JobHandle BACBCMPFGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private EOLFHKOMFPB DLMGELGPDMB;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C82930", Offset = "0x5C81730", VA = "0x185C82930")]
		public NNGDNPHDGDD(ELJAEBELGHC MGJAECMCOFA, JobHandle BACBCMPFGHN, EOLFHKOMFPB DLMGELGPDMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x967680", Offset = "0x966480", VA = "0x180967680")]
		public bool MNPJEDKKEAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5C82900", Offset = "0x5C81700", VA = "0x185C82900", Slot = "4")]
		public ELJAEBELGHC IFBNIOMHDFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C828B0", Offset = "0x5C816B0", VA = "0x185C828B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly MOPLOMLGPLJ BPHPMBBMNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int[] CPJNADMEBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float GIEIFMCJLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Hash128 KFGMAEACDJG;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override DCIDKOJNBDI FMKMMIICMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5C78E90", Offset = "0x5C77C90", VA = "0x185C78E90", Slot = "17")]
		get
		{
			return default(DCIDKOJNBDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private Vector3 BCHFBHJDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C79A40", Offset = "0x5C78840", VA = "0x185C79A40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected override Hash128 HDMDJMBMPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5C78C90", Offset = "0x5C77A90", VA = "0x185C78C90", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5C7AC20", Offset = "0x5C79A20", VA = "0x185C7AC20")]
	public FBINNHLLCMB(JEINPDENMNH LFLMFMLCFKL, MOPLOMLGPLJ MMJOHADFCHO, bool HEFDCMAIAEG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5C7A500", Offset = "0x5C79300", VA = "0x185C7A500", Slot = "16")]
	public override bool OGOLCJIFHKF(CGKNHINOJKA LFLMFMLCFKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5C78BE0", Offset = "0x5C779E0", VA = "0x185C78BE0", Slot = "18")]
	public override int DDPIPBFFANF(FBDEGFCGHEA LFNOJPBABGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5C78970", Offset = "0x5C77770", VA = "0x185C78970", Slot = "19")]
	public override int AGKPEIBHJDD(FBDEGFCGHEA LFNOJPBABGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5C7A970", Offset = "0x5C79770", VA = "0x185C7A970")]
	private int OJAMAHCHNOM(FBDEGFCGHEA LFNOJPBABGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5C79D90", Offset = "0x5C78B90", VA = "0x185C79D90", Slot = "20")]
	public override void KNHELFBADFB(FBDEGFCGHEA LFNOJPBABGG, CKAKFNCIKOJ ODGCJDCFKAM, int CJHIIHBIGBC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5C78DC0", Offset = "0x5C77BC0", VA = "0x185C78DC0", Slot = "21")]
	public override CGKNHINOJKA HJHMDDGMDEN()
	{
		return default(CGKNHINOJKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5C78A20", Offset = "0x5C77820", VA = "0x185C78A20", Slot = "23")]
	public override PPOBKPNDAGC CCENEFFEJAA()
	{
		return default(PPOBKPNDAGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5C79240", Offset = "0x5C78040", VA = "0x185C79240", Slot = "24")]
	public override DBJGBDLBBIM IMKMFBMAGNA(FBDEGFCGHEA LFNOJPBABGG, JobHandle BACBCMPFGHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GAHDMDNMEFN
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHBHOKCBLLO(BHFBDBAEJOH LEDIIMFEFLP, Renderer KHMNCIMCHCP, int BIAOBPCHGKF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNCNKGEPONN(Renderer KHMNCIMCHCP, NKKAOEPGDLO FLFMDCPMLEN, Vector3 AKDOOFNLGFD, Vector3 FCLMLADLPEM, Vector3 BPCDEGKEPND, float PGPJGBICIHO, float HAMEDJLPMDM, float DJFMJAPALJA = -1f, [Optional] Color? MHCJBLNNNKG, [Optional] IReadOnlyList<Camera> AEEPHKENEPF);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EAEFALHIOLH(Renderer KHMNCIMCHCP, int BIAOBPCHGKF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OCFNHDBNGCI();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBLFBOONEEL(int EBABMOHAHFD, NFGOLKNMBLF LEDIIMFEFLP, Renderer KHMNCIMCHCP, int BIAOBPCHGKF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LBLLCGAHMIL : EOEFFAIFFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class PEIGFHFELNH : global::GGLAMCNDPPC<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5C82980", Offset = "0x5C81780", VA = "0x185C82980")]
		public PEIGFHFELNH(string ICIEGOLHGJN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly GAHDMDNMEFN ADLGIELLDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly DIFMJNJGJPO OKHDOAMGOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MeshRenderer CDOINJFKPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private PEIGFHFELNH KCLPPPPCMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool EDMINFAOOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MeshRenderer MCIECNFJKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private PEIGFHFELNH NHDBMFALIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool OOIDPNAOEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private MeshRenderer BJMPEGMDANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private PEIGFHFELNH JMCKBPEILNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7406E0", Offset = "0x73F4E0", VA = "0x1807406E0")]
	public LBLLCGAHMIL(GAHDMDNMEFN DFIJPIGBCHL, DIFMJNJGJPO OKHDOAMGOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5C7EB40", Offset = "0x5C7D940", VA = "0x185C7EB40", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5C806B0", Offset = "0x5C7F4B0", VA = "0x185C806B0")]
	private void MMODJPKEDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5C801C0", Offset = "0x5C7EFC0", VA = "0x185C801C0", Slot = "4")]
	public void LPCPKEKDJCN(IOFBIIGNAIE LFLMFMLCFKL, NFGOLKNMBLF BJJHMHPLIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5C803C0", Offset = "0x5C7F1C0", VA = "0x185C803C0", Slot = "5")]
	public void LPCPKEKDJCN(NBKBOKJEMMD MPLDPOHNALP, NFGOLKNMBLF BJJHMHPLIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5C7ED10", Offset = "0x5C7DB10", VA = "0x185C7ED10", Slot = "6")]
	public void EGDKHBFLDPG(NBKBOKJEMMD MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5C80E40", Offset = "0x5C7FC40", VA = "0x185C80E40", Slot = "7")]
	public void PPDAKCLHHGK(NBKBOKJEMMD MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5C7FC10", Offset = "0x5C7EA10", VA = "0x185C7FC10", Slot = "8")]
	public void KHBMLIPMJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x14C2CB0", Offset = "0x14C1AB0", VA = "0x1814C2CB0", Slot = "9")]
	public void CCIJICKGJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5C80900", Offset = "0x5C7F700", VA = "0x185C80900", Slot = "10")]
	public void NJHBMPILOIN(NFGOLKNMBLF BJJHMHPLIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5C7F230", Offset = "0x5C7E030", VA = "0x185C7F230", Slot = "11")]
	public void IOPCJAKNIFF(IOFBIIGNAIE LFLMFMLCFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5C7EEE0", Offset = "0x5C7DCE0", VA = "0x185C7EEE0", Slot = "12")]
	public void IOPCJAKNIFF(NBKBOKJEMMD MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5C7FC50", Offset = "0x5C7EA50", VA = "0x185C7FC50", Slot = "13")]
	public void LFHINCGMIBG(IOFBIIGNAIE LFLMFMLCFKL, BHFBDBAEJOH LEDIIMFEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5C7FE10", Offset = "0x5C7EC10", VA = "0x185C7FE10", Slot = "14")]
	public void LFHINCGMIBG(NBKBOKJEMMD MPLDPOHNALP, BHFBDBAEJOH LEDIIMFEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5C80E00", Offset = "0x5C7FC00", VA = "0x185C80E00", Slot = "17")]
	public void PFABKAFGBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5C7EE40", Offset = "0x5C7DC40", VA = "0x185C7EE40", Slot = "15")]
	public void FAHLPFANEGM(NBKBOKJEMMD MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5C7F3E0", Offset = "0x5C7E1E0", VA = "0x185C7F3E0", Slot = "16")]
	public void JMHBNHGEELP(NBKBOKJEMMD MPLDPOHNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x11C9100", Offset = "0x11C7F00", VA = "0x1811C9100", Slot = "18")]
	public void BKEEAFAJDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5C80CC0", Offset = "0x5C7FAC0", VA = "0x185C80CC0", Slot = "19")]
	public void OLEEEJLKFEI(BHFBDBAEJOH LEDIIMFEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5C80A70", Offset = "0x5C7F870", VA = "0x185C80A70")]
	private void OENMCGPOCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5C80000", Offset = "0x5C7EE00", VA = "0x185C80000")]
	public void LFHINCGMIBG(NBKBOKJEMMD MPLDPOHNALP, BHFBDBAEJOH LEDIIMFEFLP, bool HLNEOAPLINO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5C805E0", Offset = "0x5C7F3E0", VA = "0x185C805E0")]
	private void MHBHOKCBLLO(BHFBDBAEJOH LEDIIMFEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5C7F470", Offset = "0x5C7E270", VA = "0x185C7F470", Slot = "20")]
	public void KGPMHJEIEMH(IOFBIIGNAIE LFLMFMLCFKL, Vector3 AKDOOFNLGFD, Vector3 FCLMLADLPEM, Vector3 BPCDEGKEPND, float PGPJGBICIHO, float HAMEDJLPMDM, IReadOnlyList<Camera> NNHBIBINMCN, NKKAOEPGDLO FLFMDCPMLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5C7F7F0", Offset = "0x5C7E5F0", VA = "0x185C7F7F0", Slot = "21")]
	public void KGPMHJEIEMH(LMIFOMEINKA AJGGCANOMAJ, Vector3 AKDOOFNLGFD, Vector3 FCLMLADLPEM, Vector3 BPCDEGKEPND, float PGPJGBICIHO, float HAMEDJLPMDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BOFHDAGGJCO
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool IBPNJGBHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material JKHJPKDINDL();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material CDDFCIJDOHL();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material IHABOOLLDCH();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DCCEOANGPNO(IIGBEHGCPNH BKPAODAIKAJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CKMEBHHPIKO(CDBIPHNIDEL IEIIFLIEDPI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KIEGBALJGBB(GameObject OJGAEOFIMPK);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LBFNKEPOHHO(GameObject OJGAEOFIMPK, bool JKIBEAKKDEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NCJPHKHNIDH
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static BOFHDAGGJCO FFDAOJPJGNO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool IBPNJGBHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5C82690", Offset = "0x5C81490", VA = "0x185C82690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5C824A0", Offset = "0x5C812A0", VA = "0x185C824A0")]
	public static void APEBENNBOPE(BOFHDAGGJCO LGMPLICCLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5C82630", Offset = "0x5C81430", VA = "0x185C82630")]
	public static Material JKHJPKDINDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5C7CA90", Offset = "0x5C7B890", VA = "0x185C7CA90")]
	public static Material CDDFCIJDOHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5C825D0", Offset = "0x5C813D0", VA = "0x185C825D0")]
	public static Material IHABOOLLDCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5C82560", Offset = "0x5C81360", VA = "0x185C82560")]
	public static int DCCEOANGPNO(IIGBEHGCPNH BKPAODAIKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5C824F0", Offset = "0x5C812F0", VA = "0x185C824F0")]
	public static int CKMEBHHPIKO(CDBIPHNIDEL IEIIFLIEDPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5C826F0", Offset = "0x5C814F0", VA = "0x185C826F0")]
	public static void KIEGBALJGBB(GameObject OJGAEOFIMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5C827C0", Offset = "0x5C815C0", VA = "0x185C827C0")]
	public static void LBFNKEPOHHO(GameObject OJGAEOFIMPK, bool JKIBEAKKDEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class FEDNGAGAIMM : PPEDNMAOPJC, PJCNHMOEBLB, KENOOOMDIJH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly JEINPDENMNH GLGKEOALGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected Bounds FMDCBIHNDNN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Bounds MPMONFEKJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x116B780", Offset = "0x116A580", VA = "0x18116B780", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public virtual DCIDKOJNBDI FMKMMIICMID
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5C7AE30", Offset = "0x5C79C30", VA = "0x185C7AE30", Slot = "17")]
		get
		{
			return default(DCIDKOJNBDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NBABBFNMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x740030", Offset = "0x73EE30", VA = "0x180740030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA94EC0", Offset = "0xA93CC0", VA = "0x180A94EC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	protected abstract Hash128 HDMDJMBMPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int LNPLPEGMEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x767C30", Offset = "0x766A30", VA = "0x180767C30", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public HMLCKPKBDCB KFAGHJINLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x748BC0", Offset = "0x7479C0", VA = "0x180748BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool NHLEOOPHGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7F9300", Offset = "0x7F8100", VA = "0x1807F9300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	protected FEDNGAGAIMM(JEINPDENMNH LFLMFMLCFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5C7AD00", Offset = "0x5C79B00", VA = "0x185C7AD00", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "16")]
	public virtual bool OGOLCJIFHKF(CGKNHINOJKA LFLMFMLCFKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int DDPIPBFFANF(FBDEGFCGHEA LFNOJPBABGG);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int AGKPEIBHJDD(FBDEGFCGHEA LFNOJPBABGG);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void KNHELFBADFB(FBDEGFCGHEA LFNOJPBABGG, CKAKFNCIKOJ ODGCJDCFKAM, int CJHIIHBIGBC = -1);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract CGKNHINOJKA HJHMDDGMDEN();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5C7AEC0", Offset = "0x5C79CC0", VA = "0x185C7AEC0", Slot = "11")]
	public Hash128 OICHJKMCEAM(int LFNOJPBABGG)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract PPOBKPNDAGC CCENEFFEJAA();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract DBJGBDLBBIM IMKMFBMAGNA(FBDEGFCGHEA LFNOJPBABGG, JobHandle BACBCMPFGHN);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5C7ACD0", Offset = "0x5C79AD0", VA = "0x185C7ACD0", Slot = "10")]
	public DBJGBDLBBIM BIDPEMGPIKL(int LFNOJPBABGG)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5C82AB0", Offset = "0x5C818B0", VA = "0x185C82AB0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KGPFCACJPNE
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	RR_Box,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	RR_Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	RR_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	RR_Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	RR_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	RR_HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	RR_Cone,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	RR_Pipe,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	RR_Donut,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	RR_HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	RR_Diamond,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	ADVANCED_Mound,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	LEGACY_Box,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ADVANCED_Cube,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ADVANCED_Sphere,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	ADVANCED_Cylinder,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	ADVANCED_Cone,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	ADVANCED_Pyramid,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	ADVANCED_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	ADVANCED_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	ADVANCED_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	ADVANCED_QuarterPipe,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	ADVANCED_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	ADVANCED_Dodecahedron,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	ADVANCED_Trihedron,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ADVANCED_Octahedron,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_QuarterCylinder,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_Pentagon,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_QuarterSphere,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	ADVANCED_Wedge,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_Hexagon,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_Octagon,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_Triangle,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MABJNJBDEOI
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MMNPFGIDHKA : IEnumerable<BJHAHKBKDGM>, IEnumerable, IEnumerator<BJHAHKBKDGM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private BJHAHKBKDGM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private BJHAHKBKDGM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public MMNPFGIDHKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5C82190", Offset = "0x5C80F90", VA = "0x185C82190", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5C82300", Offset = "0x5C81100", VA = "0x185C82300", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5C82270", Offset = "0x5C81070", VA = "0x185C82270", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BJHAHKBKDGM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5C82270", Offset = "0x5C81070", VA = "0x185C82270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public const int LFGCDCILAOK = 3;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static BJHAHKBKDGM[][] KOFMLEPOBEK;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static CMGOPOHAHAJ FHDGOLFLOFD;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static ShapeRendererConfig KIMPAJLAAAE;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static ComputeShader LJFOEJHNHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5C810A0", Offset = "0x5C7FEA0", VA = "0x185C810A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static SkinnedShapeRenderer DANMDGNGLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5C81140", Offset = "0x5C7FF40", VA = "0x185C81140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5C81E50", Offset = "0x5C80C50", VA = "0x185C81E50")]
	public static Mesh PKIDOCPKKHO(KGPFCACJPNE LJNGIFKOPIM, int LFNOJPBABGG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5C81090", Offset = "0x5C7FE90", VA = "0x185C81090")]
	public static int CHOEMHBBJGI(KGPFCACJPNE LJNGIFKOPIM, int LFNOJPBABGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5C81990", Offset = "0x5C80790", VA = "0x185C81990")]
	public static CMGOPOHAHAJ NNPKHPNCBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5C811B0", Offset = "0x5C7FFB0", VA = "0x185C811B0")]
	[IteratorStateMachine(typeof(MMNPFGIDHKA))]
	private static IEnumerable<BJHAHKBKDGM> JDNOLOEFMHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5C81AF0", Offset = "0x5C808F0", VA = "0x185C81AF0")]
	public static BJHAHKBKDGM OINMILHOENC(KGPFCACJPNE LJNGIFKOPIM, int LFNOJPBABGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5C81120", Offset = "0x5C7FF20", VA = "0x185C81120")]
	public static bool FFLIJILOIKB(this KGPFCACJPNE LJNGIFKOPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5C817E0", Offset = "0x5C805E0", VA = "0x185C817E0")]
	public static void NAPAPHFJHPL(KGPFCACJPNE LJNGIFKOPIM, float3 HKNKKGOPKJD, out BHGEANNBBMG MGPEPPCPBCB, out float3 HCLHEMJEOFN, out float GKCDPFNMEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5C81210", Offset = "0x5C80010", VA = "0x185C81210")]
	public static void LNPDAHKPIMF(Vector3 HKNKKGOPKJD, KGPFCACJPNE LJNGIFKOPIM, out Vector3 HCLHEMJEOFN, out float GKCDPFNMEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5C81110", Offset = "0x5C7FF10", VA = "0x185C81110")]
	[GLIGIBNDNJI(BCKENDBGOOK.ExitingPlayMode, 0)]
	private static void EPDANAFJIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5C815C0", Offset = "0x5C803C0", VA = "0x185C815C0")]
	[GLIGIBNDNJI(BCKENDBGOOK.ExitingPlayMode, 0)]
	private static void MKDBIECCMLN()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[DefaultMember("Item")]
	[DKGMECGHCPI(OJBFOICGDOF.ShapeRendering)]
	public class ShapeRendererManager : HLLPHPCGGMK, DIFMJNJGJPO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly global::PMBPJEJLGAL<IOFBIIGNAIE, JEINPDENMNH> NJABBHKPOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly global::PMBPJEJLGAL<NBKBOKJEMMD, FEDNGAGAIMM> HPIBAEBMICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly global::PMBPJEJLGAL<LMIFOMEINKA, ECBPJMBCKCP> ODLIHEKHAAM;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public JEINPDENMNH BJLJPPKNJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5C83170", Offset = "0x5C81F70", VA = "0x185C83170", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public FEDNGAGAIMM BJLJPPKNJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x5C831D0", Offset = "0x5C81FD0", VA = "0x185C831D0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public ECBPJMBCKCP BJLJPPKNJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5C83110", Offset = "0x5C81F10", VA = "0x185C83110", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool AEJAHGCEBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x812860", Offset = "0x811660", VA = "0x180812860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5C83920", Offset = "0x5C82720", VA = "0x185C83920")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5C83020", Offset = "0x5C81E20", VA = "0x185C83020", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5C83230", Offset = "0x5C82030", VA = "0x185C83230", Slot = "4")]
		public IOFBIIGNAIE IBMIOPOKHPE(GHKIFKLCPOG MMJOHADFCHO)
		{
			return default(IOFBIIGNAIE);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5C83230", Offset = "0x5C82030", VA = "0x185C83230", Slot = "5")]
		public IOFBIIGNAIE IBMIOPOKHPE(GHKIFKLCPOG MMJOHADFCHO, bool NBNNIEGOGCA)
		{
			return default(IOFBIIGNAIE);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5C833C0", Offset = "0x5C821C0", VA = "0x185C833C0", Slot = "6")]
		public void LGECKBFGKAE(IOFBIIGNAIE LFLMFMLCFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5C83340", Offset = "0x5C82140", VA = "0x185C83340", Slot = "7")]
		public void IOHDAMMPKCO(IOFBIIGNAIE LFLMFMLCFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5C83520", Offset = "0x5C82320", VA = "0x185C83520", Slot = "8")]
		public NBKBOKJEMMD MKJOHCLOIMM(IOFBIIGNAIE LFLMFMLCFKL, MOPLOMLGPLJ MMJOHADFCHO)
		{
			return default(NBKBOKJEMMD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5C82AE0", Offset = "0x5C818E0", VA = "0x185C82AE0", Slot = "9")]
		public NBKBOKJEMMD ALHNGIKJMDI(IOFBIIGNAIE LFLMFMLCFKL, BDPELCGMEEI MMJOHADFCHO)
		{
			return default(NBKBOKJEMMD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5C83420", Offset = "0x5C82220", VA = "0x185C83420", Slot = "11")]
		public void LJBENGFBFPF(NBKBOKJEMMD MPLDPOHNALP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5C83730", Offset = "0x5C82530", VA = "0x185C83730", Slot = "10")]
		public void OMFMLENKODF(NBKBOKJEMMD MPLDPOHNALP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5C834B0", Offset = "0x5C822B0", VA = "0x185C834B0", Slot = "21")]
		public IEnumerable<Renderer> MGMPKMDMKEN(IOFBIIGNAIE LFLMFMLCFKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5C83850", Offset = "0x5C82650", VA = "0x185C83850", Slot = "12")]
		public LMIFOMEINKA PNIDOCFPJLN(BBPKLCLHFGC MMJOHADFCHO)
		{
			return default(LMIFOMEINKA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5C836C0", Offset = "0x5C824C0", VA = "0x185C836C0", Slot = "14")]
		public void NCFIMOMMKID(LMIFOMEINKA AJGGCANOMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5C83660", Offset = "0x5C82460", VA = "0x185C83660", Slot = "16")]
		public Task MPHNMNOLMJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5C837F0", Offset = "0x5C825F0", VA = "0x185C837F0", Slot = "17")]
		public Task PEFIJCKCIPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5C83790", Offset = "0x5C82590", VA = "0x185C83790", Slot = "18")]
		public Task OOBEDEIFGFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2C99A10", Offset = "0x2C98810", VA = "0x182C99A10", Slot = "19")]
		public void BKCPMNIDKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5C830B0", Offset = "0x5C81EB0", VA = "0x185C830B0", Slot = "13")]
		public void ENBGPGNBPMN(LMIFOMEINKA AJGGCANOMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5C82C20", Offset = "0x5C81A20", VA = "0x185C82C20", Slot = "20")]
		public ELJAEBELGHC BIDPEMGPIKL(CGKNHINOJKA BICKPKDCFNO, IEnumerable<NBKBOKJEMMD> HPIBAEBMICI, int CGEAIEJNEBJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ECBPJMBCKCP : NEPOJPIIHBK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DNGNBOPCJHM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public ECBPJMBCKCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public DNGNBOPCJHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5C72670", Offset = "0x5C71470", VA = "0x185C72670", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5C72390", Offset = "0x5C71190", VA = "0x185C72390", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5C726F0", Offset = "0x5C714F0", VA = "0x185C726F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5C72630", Offset = "0x5C71430", VA = "0x185C72630", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5C72590", Offset = "0x5C71390", VA = "0x185C72590", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5C72590", Offset = "0x5C71390", VA = "0x185C72590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly BBPKLCLHFGC CGGNJOFDIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly DIFMJNJGJPO OKHDOAMGOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private BGENMDJDLDE OCOEKKIIDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<EPINIDFCICA> JEEOJLPFLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<EPINIDFCICA> AEJPKMAJNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private GameObject IKPIPMCOGKC;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5C72740", Offset = "0x5C71540", VA = "0x185C72740")]
	public static ECBPJMBCKCP AMBAJODNJDI(BBPKLCLHFGC MMJOHADFCHO, DIFMJNJGJPO OKHDOAMGOIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5C73BC0", Offset = "0x5C729C0", VA = "0x185C73BC0")]
	private ECBPJMBCKCP(BBPKLCLHFGC MMJOHADFCHO, DIFMJNJGJPO OKHDOAMGOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5C736E0", Offset = "0x5C724E0", VA = "0x185C736E0")]
	public void NFGECJODELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5C72B90", Offset = "0x5C71990", VA = "0x185C72B90")]
	[IteratorStateMachine(typeof(DNGNBOPCJHM))]
	public IEnumerable<Renderer> HNMFGCGCIBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5C72C00", Offset = "0x5C71A00", VA = "0x185C72C00", Slot = "4")]
	public void KANAHMFJHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5C728B0", Offset = "0x5C716B0", VA = "0x185C728B0")]
	private void FBHEMBPEFOP(Vector3 ONIGCKNCKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5C72950", Offset = "0x5C71750", VA = "0x185C72950")]
	public void FPKIEKJDLAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EPINIDFCICA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct OGINLDIEMPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public CKAKFNCIKOJ ICPPLHNNGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CGKNHINOJKA EBGOKNHKNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int BENIOPAJILN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MENIGNNGFED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EPINIDFCICA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public FBDEGFCGHEA lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public List<OGINLDIEMPG> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public ELJAEBELGHC combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public MENIGNNGFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5C81FB0", Offset = "0x5C80DB0", VA = "0x185C81FB0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5C82010", Offset = "0x5C80E10", VA = "0x185C82010")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5C82040", Offset = "0x5C80E40", VA = "0x185C82040")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int[] IJMCDPPIPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private LBJCOJNPJAC GMBPELHGKDJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static Matrix4x4 EPIMANENHKH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Mesh FAFECHJMIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int MMHEDDDNGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x741BD0", Offset = "0x7409D0", VA = "0x180741BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB10", Offset = "0x7FB910", VA = "0x1807FCB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5C77650", Offset = "0x5C76450", VA = "0x185C77650")]
	public void AIDPAGKFDDP(List<CGKNHINOJKA> LAEFLBJEHFN, Matrix4x4[] MOFALKFKGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5C77C60", Offset = "0x5C76A60", VA = "0x185C77C60")]
	public static List<EPINIDFCICA> CJALKNOJAHB(List<JEINPDENMNH> LOGOOEHKGCL, FBDEGFCGHEA LFNOJPBABGG, Bounds HGOGEJKCLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5C77880", Offset = "0x5C76680", VA = "0x185C77880")]
	private JobHandle CHHMHJNHMAD(ELJAEBELGHC NINGLHKDBKJ, int BEGBEJJKBHB, int JPAJBEGCJAI, FBDEGFCGHEA LFNOJPBABGG, List<OGINLDIEMPG> HENECDDDILL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5C78320", Offset = "0x5C77120", VA = "0x185C78320")]
	private void IEGFNBLDCJP(List<OGINLDIEMPG> HENECDDDILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5C78560", Offset = "0x5C77360", VA = "0x185C78560")]
	private EPINIDFCICA(List<OGINLDIEMPG> HENECDDDILL, int BEGBEJJKBHB, int JPAJBEGCJAI, FBDEGFCGHEA LFNOJPBABGG, Bounds HGOGEJKCLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5C78290", Offset = "0x5C77090", VA = "0x185C78290", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private MaterialPropertyBlock BMGFABAAMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private EPINIDFCICA MGJAECMCOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private List<CGKNHINOJKA> DEPKPJPMGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private RenderTexture LBAMIPMAHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ComputeBuffer IHILAKOMACH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private ComputeShader OFKHAFLALOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Matrix4x4[] OPJNPPOAFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private int ACKCOBLECFB;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public MeshRenderer EEGKNPHBEAF
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int OGAHCGNGPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5C84990", Offset = "0x5C83790", VA = "0x185C84990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5C83EC0", Offset = "0x5C82CC0", VA = "0x185C83EC0")]
		public static List<SkinnedShapeRenderer> Create(GameObject LFLMFMLCFKL, List<EPINIDFCICA> HNMFNENMBGC, List<CGKNHINOJKA> DEPKPJPMGDM, Material ECFGNJLOODA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5C84110", Offset = "0x5C82F10", VA = "0x185C84110")]
		public void Init(EPINIDFCICA MGJAECMCOFA, List<CGKNHINOJKA> DEPKPJPMGDM, Material ECFGNJLOODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5C848E0", Offset = "0x5C836E0", VA = "0x185C848E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5C84830", Offset = "0x5C83630", VA = "0x185C84830")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5C847F0", Offset = "0x5C835F0", VA = "0x185C847F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5C845C0", Offset = "0x5C833C0", VA = "0x185C845C0")]
		private void LGHGKBJNDNC(ScriptableRenderContext IJBJKIBEJLN, Camera[] KBHIPFFBOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5C83D00", Offset = "0x5C82B00", VA = "0x185C83D00")]
		private void AIDPAGKFDDP(CommandBuffer MNOOIBLGGMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ShapeRendering.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	internal class _RRAssemblyIndex : JHKNIKIBBPD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5C85220", Offset = "0x5C84020", VA = "0x185C85220", Slot = "4")]
		public sealed override void FODOGCDFONM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5C7E3C0", Offset = "0x5C7D1C0", VA = "0x185C7E3C0")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5C7E070", Offset = "0x5C7CE70", VA = "0x185C7E070")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
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
