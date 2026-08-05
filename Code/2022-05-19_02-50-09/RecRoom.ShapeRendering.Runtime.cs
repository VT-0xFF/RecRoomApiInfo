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
public enum BBIFJLAGBGL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	RED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ORANGE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	YELLOW = 2,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	LIGHT_GREEN = 3,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	BLUE = 4,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	LIGHT_BLUE = 5,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TEAL = 6,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	GREEN = 7,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PURPLE = 8,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	LIGHT_PINK = 9,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	PINK = 10,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	BROWN = 11,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	TAN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	WHITE = 13,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	GREY = 14,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	DARK_GREY = 15,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	DARK_BROWN = 16,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	LIGHT_BROWN = 17,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	LIGHT_GREY = 18,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	BLACK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	DARK_RED = 20,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DARK_ORANGE = 21,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	DARK_YELLOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DARK_GREEN = 23,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DARK_TEAL = 24,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DARK_BLUE = 25,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DARK_PURPLE = 26,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DARK_PINK = 27,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	LIGHT_RED = 28,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LIGHT_ORANGE = 29,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LIGHT_YELLOW = 30,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	CYAN = 31,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	LIGHT_PURPLE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	UNUSED_SEE_COMMENT = 33,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	NEW_COLOR_1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	NEW_COLOR_2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	NEW_COLOR_3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	NEW_COLOR_4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	NEW_COLOR_5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NEW_COLOR_6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEW_COLOR_7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NEW_COLOR_8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NEW_COLOR_9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NEW_COLOR_10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NEW_COLOR_11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NEW_COLOR_12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	NEW_COLOR_13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NEW_COLOR_14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEW_COLOR_15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	NEW_COLOR_16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEW_COLOR_17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NEW_COLOR_18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEW_COLOR_19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	NEW_COLOR_20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEW_COLOR_21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NEW_COLOR_22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NEW_COLOR_23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NEW_COLOR_24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NEW_COLOR_25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NEW_COLOR_26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NEW_COLOR_27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	MAX_VALUE = 60,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FKECGEOEKJN
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<BBIFJLAGBGL> NKLCHAAOMHH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x168CBE0", Offset = "0x168B7E0", VA = "0x18168CBE0")]
	static FKECGEOEKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x168CBE0", Offset = "0x168B7E0", VA = "0x18168CBE0")]
	[JKICLGGKJCO]
	private static void NFHIBICHHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x168CB60", Offset = "0x168B760", VA = "0x18168CB60")]
	public static bool DOIIJFLOCFH(this BBIFJLAGBGL HPNMMPMJDDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PLLMBBEPJMN
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PLACEHOLDER_16 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BOEPDCKBDOL
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HDPIICMMBDE
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	CornerMoveWarning,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KPNDNPMIOIG
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CDGKFFCKIGK : PKGONOFHIPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte ANCAAHCDGFL = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte CFDNNKKMECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] BIJBPIFONLL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EDDOMPIMHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5779B0", Offset = "0x5765B0", VA = "0x1805779B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62A0D0", Offset = "0x628CD0", VA = "0x18062A0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NGGBNAODNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5779A0", Offset = "0x5765A0", VA = "0x1805779A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE90", Offset = "0x6FDA90", VA = "0x1806FEE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float FMJDFMKNNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6548D0", Offset = "0x6534D0", VA = "0x1806548D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x654DB0", Offset = "0x6539B0", VA = "0x180654DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float PAKHHHHHNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6548C0", Offset = "0x6534C0", VA = "0x1806548C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x654DA0", Offset = "0x6539A0", VA = "0x180654DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> NPNNDOCBDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x168AE10", Offset = "0x1689A10", VA = "0x18168AE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> IGFNLPNDJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x140E180", Offset = "0x140CD80", VA = "0x18140E180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject IEPGIADAFOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551610", VA = "0x180552A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6131E0", Offset = "0x611DE0", VA = "0x1806131E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte EDAHGFAHJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x168AC90", Offset = "0x1689890", VA = "0x18168AC90", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x168AE70", Offset = "0x1689A70", VA = "0x18168AE70")]
	public CDGKFFCKIGK(List<AFGBMPGBHKL> MBFFAFKLLAJ, List<AFGBMPGBHKL> IJIJLKDECBJ, List<Transform> ONHBGGGKAOO, Material HCENJNBOKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x168A990", Offset = "0x1689590", VA = "0x18168A990")]
	private int DKMJBMGDMAL(List<AFGBMPGBHKL> MKHLIPDKOPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x168AB30", Offset = "0x1689730", VA = "0x18168AB30")]
	private void FCOPKNGMLDL(int HFHJBDOGNGP, bool MDJKNJEHJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x168AD20", Offset = "0x1689920", VA = "0x18168AD20")]
	public void OBNLFGGEEEN(Vector3 AGBNAMPHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x168AAA0", Offset = "0x16896A0", VA = "0x18168AAA0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x168ACE0", Offset = "0x16898E0", VA = "0x18168ACE0")]
	public void OBLFJOEMIJP(Transform KBHIAHENGEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IFGOMPHDBKJ : NPPHKNCDDGG, NFNCNIBBGCP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OKDBINCCDLA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IFGOMPHDBKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x734200", Offset = "0x732E00", VA = "0x180734200")]
		[DebuggerHidden]
		public OKDBINCCDLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1692E00", Offset = "0x1691A00", VA = "0x181692E00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1692950", Offset = "0x1691550", VA = "0x181692950", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1692F80", Offset = "0x1691B80", VA = "0x181692F80")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1692FC0", Offset = "0x1691BC0", VA = "0x181692FC0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1693010", Offset = "0x1691C10", VA = "0x181693010")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1692DB0", Offset = "0x16919B0", VA = "0x181692DB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1692D10", Offset = "0x1691910", VA = "0x181692D10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1692D10", Offset = "0x1691910", VA = "0x181692D10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FNGJFKJGJHI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IFGOMPHDBKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x734200", Offset = "0x732E00", VA = "0x180734200")]
		[DebuggerHidden]
		public FNGJFKJGJHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x168D0A0", Offset = "0x168BCA0", VA = "0x18168D0A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x168CD00", Offset = "0x168B900", VA = "0x18168CD00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x168D1C0", Offset = "0x168BDC0", VA = "0x18168D1C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x168D210", Offset = "0x168BE10", VA = "0x18168D210")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x168D050", Offset = "0x168BC50", VA = "0x18168D050", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x168CFB0", Offset = "0x168BBB0", VA = "0x18168CFB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x168CFB0", Offset = "0x168BBB0", VA = "0x18168CFB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private EKOGGBKMEIJ NPHMFBEFPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<GDHFNAJGCBK> AAADEILCPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> KJNPPPKNEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer FIKJAFHHHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool CBHOAJHIKOA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<EJAPNHGCPCJ> EFLNIFKFHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OPNJCIJPIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x168D780", Offset = "0x168C380", VA = "0x18168D780", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform LJDKEEGOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x168D730", Offset = "0x168C330", VA = "0x18168D730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> OKCLALJBEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5534A0", Offset = "0x5520A0", VA = "0x1805534A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x577CD0", Offset = "0x5768D0", VA = "0x180577CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x168E580", Offset = "0x168D180", VA = "0x18168E580")]
	public IFGOMPHDBKJ(EKOGGBKMEIJ MCCGGLNMBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x168D690", Offset = "0x168C290", VA = "0x18168D690", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x168D5C0", Offset = "0x168C1C0", VA = "0x18168D5C0")]
	public void DLPDCPCMKFM(GDHFNAJGCBK LNOBHDGELLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x168D550", Offset = "0x168C150", VA = "0x18168D550")]
	public void AFEKNPNIBII(GDHFNAJGCBK LNOBHDGELLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x168D910", Offset = "0x168C510", VA = "0x18168D910", Slot = "4")]
	public void HGKEJIMHOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x168E010", Offset = "0x168CC10", VA = "0x18168E010")]
	public void NOJNEJFMGMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x168D7C0", Offset = "0x168C3C0", VA = "0x18168D7C0")]
	private void GMFKNOMBCBF(GDHFNAJGCBK LNOBHDGELLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x168E0A0", Offset = "0x168CCA0", VA = "0x18168E0A0")]
	public void OCLOMMEFMCO(bool IBONNEMNONG, bool GEOBIIDFBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x168DED0", Offset = "0x168CAD0", VA = "0x18168DED0")]
	protected void MMEDNMBICGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x168DE60", Offset = "0x168CA60", VA = "0x18168DE60")]
	[IteratorStateMachine(typeof(OKDBINCCDLA))]
	public IEnumerable<Renderer> LECMPHKPIKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x168D6C0", Offset = "0x168C2C0", VA = "0x18168D6C0")]
	[IteratorStateMachine(typeof(FNGJFKJGJHI))]
	public IEnumerable<Renderer> ELOBFMJGINC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class IKNFJJNNAHH : GDHFNAJGCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private FHJFMCDJIDN PJDEKKDNJEB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x168EF80", Offset = "0x168DB80", VA = "0x18168EF80")]
	private NativeList<NCLEBKHNGIH> OMBJDNHEBHF()
	{
		return default(NativeList<NCLEBKHNGIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x168F050", Offset = "0x168DC50", VA = "0x18168F050")]
	public IKNFJJNNAHH(IFGOMPHDBKJ LGLMPHDPDPB, FHJFMCDJIDN MCCGGLNMBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x168EB40", Offset = "0x168D740", VA = "0x18168EB40", Slot = "13")]
	public override int DKMJBMGDMAL(NEILPEOKPHE NCLMJKKJONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x168ED60", Offset = "0x168D960", VA = "0x18168ED60", Slot = "14")]
	public override int FLCLIOJOPFF(NEILPEOKPHE NCLMJKKJONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x168E610", Offset = "0x168D210", VA = "0x18168E610", Slot = "15")]
	public override void BKFOOEOKGML(NEILPEOKPHE NCLMJKKJONF, AODGPNCLJGB FEKGOBDFACC, int IGGMNLHEJGA = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OMJJPNDMDCF : global::CKFAKJPPNKG<OMJJPNDMDCF>, FEFCJIHAFNE, IEquatable<OMJJPNDMDCF>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int BPILIAKMPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60B9D0", Offset = "0x60A5D0", VA = "0x18060B9D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6E4120", Offset = "0x6E2D20", VA = "0x1806E4120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GJFFFBBIJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9976D0", Offset = "0x9962D0", VA = "0x1809976D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9ECA60", Offset = "0x9EB660", VA = "0x1809ECA60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x13FEA60", Offset = "0x13FD660", VA = "0x1813FEA60", Slot = "8")]
	public bool Equals(OMJJPNDMDCF DEIAHGDLBHH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1693060", Offset = "0x1691C60", VA = "0x181693060")]
	public static bool OCKJOEDLAML(OMJJPNDMDCF LFGAIKKMBAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MNLLPIJHOIO
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EKOGGBKMEIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform HCFLEIBFDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MNLLPIJHOIO HKOHEPAIDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GNHOFALOIBM : global::CKFAKJPPNKG<GNHOFALOIBM>, FEFCJIHAFNE, IEquatable<GNHOFALOIBM>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int BPILIAKMPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60B9D0", Offset = "0x60A5D0", VA = "0x18060B9D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4120", Offset = "0x6E2D20", VA = "0x1806E4120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int GJFFFBBIJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9976D0", Offset = "0x9962D0", VA = "0x1809976D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9ECA60", Offset = "0x9EB660", VA = "0x1809ECA60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x13FEA60", Offset = "0x13FD660", VA = "0x1813FEA60", Slot = "8")]
	public bool Equals(GNHOFALOIBM DEIAHGDLBHH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x168D350", Offset = "0x168BF50", VA = "0x18168D350")]
	public static bool OCKJOEDLAML(GNHOFALOIBM LFGAIKKMBAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OBNBCGGNFJB
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform HCFLEIBFDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float KHJAIAFGGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 MPCCIJPELMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	BBIFJLAGBGL GOJDBFLGHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PLLMBBEPJMN MKDGOAIOPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AKLEICNGNNG : OBNBCGGNFJB
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	BFPMAMPBDBJ ACIINGHPJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DEBBFMOECMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FHJFMCDJIDN : OBNBCGGNFJB
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BJEJAFMPJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BDFBOHEDJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float GPDGIDKAOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int LNOAAALMCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GKAOIOHFBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<NCLEBKHNGIH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LPPDLPCILFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCMKDDOJAIH(GNHOFALOIBM LNOBHDGELLD, HDPIICMMBDE CGFGDDNCGNI);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCMKDDOJAIH(OMJJPNDMDCF LGLMPHDPDPB, HDPIICMMBDE CGFGDDNCGNI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLGFAKADJFH(OMJJPNDMDCF LGLMPHDPDPB);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLGFAKADJFH(GNHOFALOIBM LNOBHDGELLD);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBGLFFKICIO(OMJJPNDMDCF LGLMPHDPDPB, KPNDNPMIOIG IONHFMDGLFB);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JEGHOAENMKI(OMJJPNDMDCF LGLMPHDPDPB, Vector3 CGMEPGLJPKC, Vector3 MIOFCLJHLOH, Vector3 CCCHNENMIGF, float NKCJBHHLOND, float OPBOPDBOOHK, IReadOnlyList<Camera> NHFDEGAKNLF, BOEPDCKBDOL LOOOEOFBDEA);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JEGHOAENMKI(NKBHOAHOMKJ KHKIJCKKHFJ, Vector3 CGMEPGLJPKC, Vector3 MIOFCLJHLOH, Vector3 CCCHNENMIGF, float NKCJBHHLOND, float OPBOPDBOOHK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NPMFGJCPPAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMJJPNDMDCF MNNEEILGJEB(EKOGGBKMEIJ MCCGGLNMBDL);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKBCKJEECFJ(OMJJPNDMDCF LGLMPHDPDPB);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACEJMBECCFF(OMJJPNDMDCF LGLMPHDPDPB);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GNHOFALOIBM PEJFFNAPIAP(OMJJPNDMDCF LGLMPHDPDPB, AKLEICNGNNG MCCGGLNMBDL);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GNHOFALOIBM NLOKNMFMKGM(OMJJPNDMDCF LGLMPHDPDPB, FHJFMCDJIDN MCCGGLNMBDL);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JEAICBDCNDN(GNHOFALOIBM LNOBHDGELLD);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BDBINFMIDBB(GNHOFALOIBM LNOBHDGELLD);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NKBHOAHOMKJ ICGILJBJLIP(DCPAKBCPLIJ MCCGGLNMBDL);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EJICLLDOKAF(NKBHOAHOMKJ KHKIJCKKHFJ);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FJGMKJDCPPH(NKBHOAHOMKJ KHKIJCKKHFJ);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MKONELHAHOE PEHAFMFCJOP(Transform JIJNCECNMGI, IEnumerable<GNHOFALOIBM> AAADEILCPOL, int LNAPALFJDEF);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> AFILMLJHDEB(OMJJPNDMDCF LGLMPHDPDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NKBHOAHOMKJ : global::CKFAKJPPNKG<NKBHOAHOMKJ>, FEFCJIHAFNE, IEquatable<NKBHOAHOMKJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BPILIAKMPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60B9D0", Offset = "0x60A5D0", VA = "0x18060B9D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E4120", Offset = "0x6E2D20", VA = "0x1806E4120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int GJFFFBBIJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9976D0", Offset = "0x9962D0", VA = "0x1809976D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9ECA60", Offset = "0x9EB660", VA = "0x1809ECA60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x13FEA60", Offset = "0x13FD660", VA = "0x1813FEA60", Slot = "8")]
	public bool Equals(NKBHOAHOMKJ DEIAHGDLBHH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1692910", Offset = "0x1691510", VA = "0x181692910")]
	public static bool OCKJOEDLAML(NKBHOAHOMKJ LFGAIKKMBAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DCPAKBCPLIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int FIKEJMILHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform LCOEDKPKAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JHCCAOJIFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMJJPNDMDCF GetBone(int CGOFEAKINMF);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int CGOFEAKINMF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class KOEGMEFAHPC : GDHFNAJGCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public AKLEICNGNNG FFFCLPDJOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] AKALNNMHDAD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override BICMMAMDAKJ IPLINPNLACL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1690C00", Offset = "0x168F800", VA = "0x181690C00", Slot = "12")]
		get
		{
			return default(BICMMAMDAKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 BKGNMAMLBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1690980", Offset = "0x168F580", VA = "0x181690980")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x168F050", Offset = "0x168DC50", VA = "0x18168F050")]
	public KOEGMEFAHPC(IFGOMPHDBKJ LGLMPHDPDPB, AKLEICNGNNG MCCGGLNMBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1691280", Offset = "0x168FE80", VA = "0x181691280", Slot = "11")]
	public override bool MFEIFPJKIDD(Transform LGLMPHDPDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1690B60", Offset = "0x168F760", VA = "0x181690B60", Slot = "13")]
	public override int DKMJBMGDMAL(NEILPEOKPHE NCLMJKKJONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1690FA0", Offset = "0x168FBA0", VA = "0x181690FA0", Slot = "14")]
	public override int FLCLIOJOPFF(NEILPEOKPHE NCLMJKKJONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1691040", Offset = "0x168FC40", VA = "0x181691040")]
	private int LCFCPAPPPHF(NEILPEOKPHE NCLMJKKJONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x16902D0", Offset = "0x168EED0", VA = "0x1816902D0", Slot = "15")]
	public override void BKFOOEOKGML(NEILPEOKPHE NCLMJKKJONF, AODGPNCLJGB FEKGOBDFACC, int IGGMNLHEJGA = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CCEMFJHBACD
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAPJLEPHCFO(KPNDNPMIOIG IONHFMDGLFB, Renderer HAPAFMGKPLJ, int PLECLJEKIHN);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EAKMIKHNMDM(Renderer HAPAFMGKPLJ, BOEPDCKBDOL LOOOEOFBDEA, Vector3 CGMEPGLJPKC, Vector3 MIOFCLJHLOH, Vector3 CCCHNENMIGF, float NKCJBHHLOND, float OPBOPDBOOHK, float DDBLCMAKLMB = -1f, [Optional] Color? PNDHCEJAEEO, [Optional] IReadOnlyList<Camera> CJBHFJOPFFI);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJACPNJJGCL(Renderer HAPAFMGKPLJ, int PLECLJEKIHN);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BEDLKMFLCPI();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PAPBCONGBON(int NMBEOJDDEJA, HDPIICMMBDE IONHFMDGLFB, Renderer HAPAFMGKPLJ, int PLECLJEKIHN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JOFPEBPHOAP : LPPDLPCILFN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CCEMFJHBACD FJLOHMFAJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CLADEKFLCDN PPKHCLOCCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer EOILCGNNCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private DDOFFEELECD GKDNAJOICFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer PMMAEHNECHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private DDOFFEELECD BNGBDAFKNME;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x58A610", Offset = "0x589210", VA = "0x18058A610")]
	public JOFPEBPHOAP(CCEMFJHBACD GLEMJMFCIMO, CLADEKFLCDN PPKHCLOCCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x168F8E0", Offset = "0x168E4E0", VA = "0x18168F8E0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x168F490", Offset = "0x168E090", VA = "0x18168F490", Slot = "4")]
	public void DCMKDDOJAIH(GNHOFALOIBM LNOBHDGELLD, HDPIICMMBDE CGFGDDNCGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x168F710", Offset = "0x168E310", VA = "0x18168F710", Slot = "5")]
	public void DCMKDDOJAIH(OMJJPNDMDCF LGLMPHDPDPB, HDPIICMMBDE CGFGDDNCGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x168F0A0", Offset = "0x168DCA0", VA = "0x18168F0A0", Slot = "6")]
	public void BLGFAKADJFH(OMJJPNDMDCF LGLMPHDPDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x168F240", Offset = "0x168DE40", VA = "0x18168F240", Slot = "7")]
	public void BLGFAKADJFH(GNHOFALOIBM LNOBHDGELLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x168FA30", Offset = "0x168E630", VA = "0x18168FA30", Slot = "8")]
	public void JBGLFFKICIO(OMJJPNDMDCF LGLMPHDPDPB, KPNDNPMIOIG IONHFMDGLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x168FFA0", Offset = "0x168EBA0", VA = "0x18168FFA0", Slot = "9")]
	public void JEGHOAENMKI(OMJJPNDMDCF LGLMPHDPDPB, Vector3 CGMEPGLJPKC, Vector3 MIOFCLJHLOH, Vector3 CCCHNENMIGF, float NKCJBHHLOND, float OPBOPDBOOHK, IReadOnlyList<Camera> NHFDEGAKNLF, BOEPDCKBDOL LOOOEOFBDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x168FBD0", Offset = "0x168E7D0", VA = "0x18168FBD0", Slot = "10")]
	public void JEGHOAENMKI(NKBHOAHOMKJ KHKIJCKKHFJ, Vector3 CGMEPGLJPKC, Vector3 MIOFCLJHLOH, Vector3 CCCHNENMIGF, float NKCJBHHLOND, float OPBOPDBOOHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class GDHFNAJGCBK : HEAFGEIIGPC, EJAPNHGCPCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds AAOBLNCDGNA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IFGOMPHDBKJ IEPGIADAFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds MCJMCBFMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x124EC20", Offset = "0x124D820", VA = "0x18124EC20", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual BICMMAMDAKJ IPLINPNLACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x168D2C0", Offset = "0x168BEC0", VA = "0x18168D2C0", Slot = "12")]
		get
		{
			return default(BICMMAMDAKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x168D250", Offset = "0x168BE50", VA = "0x18168D250", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576790", VA = "0x180577B90", Slot = "11")]
	public virtual bool MFEIFPJKIDD(Transform LGLMPHDPDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int DKMJBMGDMAL(NEILPEOKPHE NCLMJKKJONF);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int FLCLIOJOPFF(NEILPEOKPHE NCLMJKKJONF);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void BKFOOEOKGML(NEILPEOKPHE NCLMJKKJONF, AODGPNCLJGB FEKGOBDFACC, int IGGMNLHEJGA = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	protected GDHFNAJGCBK()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1693FF0", Offset = "0x1692BF0", VA = "0x181693FF0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BFPMAMPBDBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class PICGFKFPPFP
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HHMOPPCLCFD : IEnumerable<NJKEGCENKAP>, IEnumerable, IEnumerator<NJKEGCENKAP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private NJKEGCENKAP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private NJKEGCENKAP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x734200", Offset = "0x732E00", VA = "0x180734200")]
		[DebuggerHidden]
		public HHMOPPCLCFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x168D390", Offset = "0x168BF90", VA = "0x18168D390", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x168D500", Offset = "0x168C100", VA = "0x18168D500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x168D470", Offset = "0x168C070", VA = "0x18168D470", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NJKEGCENKAP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x168D470", Offset = "0x168C070", VA = "0x18168D470", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int BDLIDKKMNMF = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static NJKEGCENKAP[][] LPEMNHJALFB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static CCMCBCPLJLP AFHBLKAHPKJ;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig BLHPENFGEEK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader BJMFNPPCBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1693E90", Offset = "0x1692A90", VA = "0x181693E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer ILLHEDMNJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1693F00", Offset = "0x1692B00", VA = "0x181693F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1693D30", Offset = "0x1692930", VA = "0x181693D30")]
	public static Mesh FNCDGHFCEKD(BFPMAMPBDBJ AOKCFOFGPCB, int NCLMJKKJONF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1693DF0", Offset = "0x16929F0", VA = "0x181693DF0")]
	public static int FODKLMJKCPA(BFPMAMPBDBJ AOKCFOFGPCB, int NCLMJKKJONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1693800", Offset = "0x1692400", VA = "0x181693800")]
	public static CCMCBCPLJLP DMGDCIAJEHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1693E00", Offset = "0x1692A00", VA = "0x181693E00")]
	[IteratorStateMachine(typeof(HHMOPPCLCFD))]
	private static IEnumerable<NJKEGCENKAP> GGMIPFEPOCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x16930A0", Offset = "0x1691CA0", VA = "0x1816930A0")]
	public static NJKEGCENKAP BNPCDEAKDPD(BFPMAMPBDBJ AOKCFOFGPCB, int NCLMJKKJONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1693E60", Offset = "0x1692A60", VA = "0x181693E60")]
	public static bool IIOEMBPPGCP(this BFPMAMPBDBJ AOKCFOFGPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1693950", Offset = "0x1692550", VA = "0x181693950")]
	public static void EAHFMBAPKOA(BFPMAMPBDBJ AOKCFOFGPCB, float3 JCHNILHGMEH, out KGIMLBNEDDK OLFKGHDBEFP, out float3 DFHNBAJICOF, out float HJJKLHJEIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x16933E0", Offset = "0x1691FE0", VA = "0x1816933E0")]
	public static void DKOEKGMANGC(Vector3 JCHNILHGMEH, BFPMAMPBDBJ AOKCFOFGPCB, out Vector3 DFHNBAJICOF, out float HJJKLHJEIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1693E80", Offset = "0x1692A80", VA = "0x181693E80")]
	[BIEDHDEFKGL(LOMHOCOLDLE.ExitingPlayMode, 0)]
	private static void IKDGABFOHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1693B10", Offset = "0x1692710", VA = "0x181693B10")]
	[BIEDHDEFKGL(LOMHOCOLDLE.ExitingPlayMode, 0)]
	private static void FGDELPKLIJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AKEEKOGHEHN
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool AICBGLMLDCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material PNHJPMIAMCK();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material APEJIIPCOOL();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material JIAACODJIEE();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PNECELMFOAD(BBIFJLAGBGL JJDFIIJBHOI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IEDOADLIJMJ(PLLMBBEPJMN ECPKLKGCHLC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BHKAKKOEDLD(GameObject KLDDDNGBABC);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHBLCLDAIKP(GameObject KLDDDNGBABC, bool CMNLDEGPMAE);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface CLADEKFLCDN
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IFGOMPHDBKJ KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GDHFNAJGCBK KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	COFLPNFNJHL KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class NAGCIAJJAMO : NPMFGJCPPAO, IDisposable, CLADEKFLCDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::OAPCOEIEDOF<OMJJPNDMDCF, IFGOMPHDBKJ> NIBNBDHEKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::OAPCOEIEDOF<GNHOFALOIBM, GDHFNAJGCBK> AAADEILCPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::OAPCOEIEDOF<NKBHOAHOMKJ, COFLPNFNJHL> OBDKNIOOFGI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static AKEEKOGHEHN CDAAKNEOGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1691BD0", Offset = "0x16907D0", VA = "0x181691BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1691C70", Offset = "0x1690870", VA = "0x181691C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IFGOMPHDBKJ KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1691EF0", Offset = "0x1690AF0", VA = "0x181691EF0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GDHFNAJGCBK KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1691F50", Offset = "0x1690B50", VA = "0x181691F50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public COFLPNFNJHL KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1691E90", Offset = "0x1690A90", VA = "0x181691E90", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x16924A0", Offset = "0x16910A0", VA = "0x1816924A0")]
	public NAGCIAJJAMO(AKEEKOGHEHN GLEMJMFCIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1691980", Offset = "0x1690580", VA = "0x181691980", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1691CC0", Offset = "0x16908C0", VA = "0x181691CC0", Slot = "4")]
	public OMJJPNDMDCF MNNEEILGJEB(EKOGGBKMEIJ MCCGGLNMBDL)
	{
		return default(OMJJPNDMDCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1691920", Offset = "0x1690520", VA = "0x181691920", Slot = "5")]
	public void CKBCKJEECFJ(OMJJPNDMDCF LGLMPHDPDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1691780", Offset = "0x1690380", VA = "0x181691780", Slot = "6")]
	public void ACEJMBECCFF(OMJJPNDMDCF LGLMPHDPDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x16917F0", Offset = "0x16903F0", VA = "0x1816917F0", Slot = "15")]
	public IEnumerable<Renderer> AFILMLJHDEB(OMJJPNDMDCF LGLMPHDPDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x16923B0", Offset = "0x1690FB0", VA = "0x1816923B0", Slot = "7")]
	public GNHOFALOIBM PEJFFNAPIAP(OMJJPNDMDCF LGLMPHDPDPB, AKLEICNGNNG MCCGGLNMBDL)
	{
		return default(GNHOFALOIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1691DA0", Offset = "0x16909A0", VA = "0x181691DA0", Slot = "8")]
	public GNHOFALOIBM NLOKNMFMKGM(OMJJPNDMDCF LGLMPHDPDPB, FHJFMCDJIDN MCCGGLNMBDL)
	{
		return default(GNHOFALOIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x16918B0", Offset = "0x16904B0", VA = "0x1816918B0", Slot = "10")]
	public void BDBINFMIDBB(GNHOFALOIBM LNOBHDGELLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1691C10", Offset = "0x1690810", VA = "0x181691C10", Slot = "9")]
	public void JEAICBDCNDN(GNHOFALOIBM LNOBHDGELLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1691AC0", Offset = "0x16906C0", VA = "0x181691AC0", Slot = "11")]
	public NKBHOAHOMKJ ICGILJBJLIP(DCPAKBCPLIJ MCCGGLNMBDL)
	{
		return default(NKBHOAHOMKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1691A50", Offset = "0x1690650", VA = "0x181691A50", Slot = "13")]
	public void FJGMKJDCPPH(NKBHOAHOMKJ KHKIJCKKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x16919F0", Offset = "0x16905F0", VA = "0x1816919F0", Slot = "12")]
	public void EJICLLDOKAF(NKBHOAHOMKJ KHKIJCKKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1691FB0", Offset = "0x1690BB0", VA = "0x181691FB0", Slot = "14")]
	public MKONELHAHOE PEHAFMFCJOP(Transform JIJNCECNMGI, IEnumerable<GNHOFALOIBM> AAADEILCPOL, int LNAPALFJDEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class COFLPNFNJHL : NPPHKNCDDGG
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class ABBKBOPCDLC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public COFLPNFNJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x734200", Offset = "0x732E00", VA = "0x180734200")]
		[DebuggerHidden]
		public ABBKBOPCDLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1689760", Offset = "0x1688360", VA = "0x181689760", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1689480", Offset = "0x1688080", VA = "0x181689480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1689800", Offset = "0x1688400", VA = "0x181689800")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1689710", Offset = "0x1688310", VA = "0x181689710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1689670", Offset = "0x1688270", VA = "0x181689670", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1689670", Offset = "0x1688270", VA = "0x181689670", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly DCPAKBCPLIJ ONLCPLFHHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CLADEKFLCDN PPKHCLOCCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private CDGKFFCKIGK DNADABFBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<AFGBMPGBHKL> IKNKPDDAGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<AFGBMPGBHKL> ECHPLHJBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject KJFGNMHECAA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x168B550", Offset = "0x168A150", VA = "0x18168B550")]
	public static COFLPNFNJHL CJNKFCJLADJ(DCPAKBCPLIJ MCCGGLNMBDL, CLADEKFLCDN PPKHCLOCCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x168C2A0", Offset = "0x168AEA0", VA = "0x18168C2A0")]
	private COFLPNFNJHL(DCPAKBCPLIJ MCCGGLNMBDL, CLADEKFLCDN PPKHCLOCCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x168B130", Offset = "0x1689D30", VA = "0x18168B130")]
	public void CCNPHFEIOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x168C060", Offset = "0x168AC60", VA = "0x18168C060")]
	[IteratorStateMachine(typeof(ABBKBOPCDLC))]
	public IEnumerable<Renderer> LECMPHKPIKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x168B630", Offset = "0x168A230", VA = "0x18168B630", Slot = "4")]
	public void HGKEJIMHOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x168C030", Offset = "0x168AC30", VA = "0x18168C030")]
	private void HKAOGFLBBIJ(Vector3 AGBNAMPHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x168C0D0", Offset = "0x168ACD0", VA = "0x18168C0D0")]
	public void NOJNEJFMGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AFGBMPGBHKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct ICEHGGHGAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AODGPNCLJGB NOGLLKPMNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform FJHBFPPHNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int PDHJFHLLHKG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class OFEBIHAPDPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AFGBMPGBHKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public NEILPEOKPHE lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<ICEHGGHGAJD> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public OFEBIHAPDPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class EICKHOGAPPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public MKONELHAHOE combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public OFEBIHAPDPG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public EICKHOGAPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x168C920", Offset = "0x168B520", VA = "0x18168C920")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x168C990", Offset = "0x168B590", VA = "0x18168C990")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x168C9D0", Offset = "0x168B5D0", VA = "0x18168C9D0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] AOEIJCMOCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NBOJBFHEKAC BDGNLMPJNFB;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 PCOLKGNEJCM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh HDFCNDCNIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int JMDCGNEMBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x552070", VA = "0x180553470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5C9950", Offset = "0x5C8550", VA = "0x1805C9950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x16898C0", Offset = "0x16884C0", VA = "0x1816898C0")]
	public void GGMBEDPLFCI(List<Transform> DMDDGBDLIHE, Matrix4x4[] MNGNMNHAAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1689AC0", Offset = "0x16886C0", VA = "0x181689AC0")]
	public static List<AFGBMPGBHKL> JFONNKANKPC(List<IFGOMPHDBKJ> FCCHCFHAMAM, NEILPEOKPHE NCLMJKKJONF, Bounds NFBIDFHJAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x168A120", Offset = "0x1688D20", VA = "0x18168A120")]
	private JobHandle KGPHJILNHAF(MKONELHAHOE PJMLIACOEDA, int MDFBMBBLEDD, int PPBFNCJGLCI, NEILPEOKPHE NCLMJKKJONF, List<ICEHGGHGAJD> FIAGDBHHBJA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x168A020", Offset = "0x1688C20", VA = "0x18168A020")]
	private void JMHOAAKLAOC(List<ICEHGGHGAJD> FIAGDBHHBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x168A5E0", Offset = "0x16891E0", VA = "0x18168A5E0")]
	private AFGBMPGBHKL(List<ICEHGGHGAJD> FIAGDBHHBJA, int MDFBMBBLEDD, int PPBFNCJGLCI, NEILPEOKPHE NCLMJKKJONF, Bounds NFBIDFHJAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1689840", Offset = "0x1688440", VA = "0x181689840", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private MaterialPropertyBlock LMLAILBBMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private AFGBMPGBHKL NBBCOGHADLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> ONHBGGGKAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture NPALAIOIIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer BEDLJEBKJIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader MONLCDGPFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] KMBOECILBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int GKCBHEDAINP;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer ODFDFHKLLJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x555060", VA = "0x180556460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int FIKEJMILHOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1694B90", Offset = "0x1693790", VA = "0x181694B90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1694020", Offset = "0x1692C20", VA = "0x181694020")]
		public static List<SkinnedShapeRenderer> Create(GameObject LGLMPHDPDPB, List<AFGBMPGBHKL> MKHLIPDKOPG, List<Transform> ONHBGGGKAOO, Material HCENJNBOKGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1694580", Offset = "0x1693180", VA = "0x181694580")]
		public void Init(AFGBMPGBHKL NBBCOGHADLE, List<Transform> ONHBGGGKAOO, Material HCENJNBOKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1694B00", Offset = "0x1693700", VA = "0x181694B00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1694A70", Offset = "0x1693670", VA = "0x181694A70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1694A30", Offset = "0x1693630", VA = "0x181694A30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x16949A0", Offset = "0x16935A0", VA = "0x1816949A0")]
		private void NFKHAIBOAMH(ScriptableRenderContext EEBJJBKMCLF, Camera[] EEAKHCIKAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1694230", Offset = "0x1692E30", VA = "0x181694230")]
		private void GGMBEDPLFCI(CommandBuffer JPJMOBNHBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x168C330", Offset = "0x168AF30", VA = "0x18168C330")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x168C430", Offset = "0x168B030", VA = "0x18168C430")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
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
