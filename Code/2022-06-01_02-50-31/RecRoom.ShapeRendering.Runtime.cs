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
public enum FJKMEOPNDGG
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
public static class DABKHJAHEFH
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<FJKMEOPNDGG> OBKAGHBHJAB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC290", Offset = "0x4CCAC90", VA = "0x184CCC290")]
	static DABKHJAHEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC290", Offset = "0x4CCAC90", VA = "0x184CCC290")]
	[FJICHKELHED]
	private static void LPDEJFLNIEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC210", Offset = "0x4CCAC10", VA = "0x184CCC210")]
	public static bool JGJKLFDHHEF(this FJKMEOPNDGG AKGPBMLKIBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IIOAHOMEEGA
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
public enum EFAMMGANPNP
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
public enum CAFBEPNNPMK
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
public enum DEOMEEOBOGG
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
public class AOLOAHJPJJJ : EKJHEBEFBCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private const byte EMKPAOBELCM = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private byte ELNOMFJNIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<SkinnedShapeRenderer>[] FJPBODEMBML;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NBPHIALCGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5779B0", Offset = "0x5763B0", VA = "0x1805779B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x649700", Offset = "0x648100", VA = "0x180649700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EGJLEHJBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5779A0", Offset = "0x5763A0", VA = "0x1805779A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x705910", Offset = "0x704310", VA = "0x180705910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float LOBCJBGCMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x673EC0", Offset = "0x6728C0", VA = "0x180673EC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6743A0", Offset = "0x672DA0", VA = "0x1806743A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OAKBJFBPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x673EB0", Offset = "0x6728B0", VA = "0x180673EB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x674390", Offset = "0x672D90", VA = "0x180674390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GCMFBIEFAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4CCAB50", Offset = "0x4CC9550", VA = "0x184CCAB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> CKEKMAAENOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1109AD0", Offset = "0x11084D0", VA = "0x181109AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject OOHCCBDKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551410", VA = "0x180552A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60BBE0", Offset = "0x60A5E0", VA = "0x18060BBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FPEGECKFKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4CCABF0", Offset = "0x4CC95F0", VA = "0x184CCABF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4CCAE90", Offset = "0x4CC9890", VA = "0x184CCAE90")]
	public AOLOAHJPJJJ(List<IIEGENAOIDF> ILBEFIBFMPC, List<IIEGENAOIDF> KIHFLJLEGFP, List<Transform> DOICBBMCBEJ, Material KFBCCEEBAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4CCA9B0", Offset = "0x4CC93B0", VA = "0x184CCA9B0")]
	private int AMDABMDFAGE(List<IIEGENAOIDF> FIJECPPAIPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4CCAC40", Offset = "0x4CC9640", VA = "0x184CCAC40")]
	private void LBAEFDAPCGE(int AHKICEGIOAE, bool CEJHMGDHMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4CCADA0", Offset = "0x4CC97A0", VA = "0x184CCADA0")]
	public void NMGAIAPGPNE(Vector3 NPFGBLLKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4CCAAC0", Offset = "0x4CC94C0", VA = "0x184CCAAC0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4CCABB0", Offset = "0x4CC95B0", VA = "0x184CCABB0")]
	public void FFCCJMLNAAO(Transform POEBOIMPGGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BIJBIMOACMI : NKMGCNOGOGF, KCDCFEGOCBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EMAGFAMPMPF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BIJBIMOACMI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x759DB0", Offset = "0x7587B0", VA = "0x180759DB0")]
		[DebuggerHidden]
		public EMAGFAMPMPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF140", Offset = "0x4CCDB40", VA = "0x184CCF140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4CCEC90", Offset = "0x4CCD690", VA = "0x184CCEC90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF2C0", Offset = "0x4CCDCC0", VA = "0x184CCF2C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF300", Offset = "0x4CCDD00", VA = "0x184CCF300")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF350", Offset = "0x4CCDD50", VA = "0x184CCF350")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF0F0", Offset = "0x4CCDAF0", VA = "0x184CCF0F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF050", Offset = "0x4CCDA50", VA = "0x184CCF050", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF050", Offset = "0x4CCDA50", VA = "0x184CCF050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DLDOKJGFIDP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BIJBIMOACMI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x759DB0", Offset = "0x7587B0", VA = "0x180759DB0")]
		[DebuggerHidden]
		public DLDOKJGFIDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4CCD8E0", Offset = "0x4CCC2E0", VA = "0x184CCD8E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4CCD540", Offset = "0x4CCBF40", VA = "0x184CCD540", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4CCDA00", Offset = "0x4CCC400", VA = "0x184CCDA00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4CCDA50", Offset = "0x4CCC450", VA = "0x184CCDA50")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4CCD890", Offset = "0x4CCC290", VA = "0x184CCD890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4CCD7F0", Offset = "0x4CCC1F0", VA = "0x184CCD7F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4CCD7F0", Offset = "0x4CCC1F0", VA = "0x184CCD7F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private CPMIIMNAJPP KELAGAECJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<GJMDEMKDHEC> DMGCAAGHDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private List<ClusterMeshRenderer> KLNDPHGPPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BatchedMeshRenderer OIENMDONCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool MJDJGJHFINK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<FKIIHBDDFPH> JMBHAPLDHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MGKKJPDDNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4CCBFF0", Offset = "0x4CCA9F0", VA = "0x184CCBFF0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Transform GJPKOAJMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4CCB6A0", Offset = "0x4CCA0A0", VA = "0x184CCB6A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PINCMBBIOED
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5534A0", Offset = "0x551EA0", VA = "0x1805534A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x577CD0", Offset = "0x5766D0", VA = "0x180577CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC180", Offset = "0x4CCAB80", VA = "0x184CCC180")]
	public BIJBIMOACMI(CPMIIMNAJPP CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB8A0", Offset = "0x4CCA2A0", VA = "0x184CCB8A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB760", Offset = "0x4CCA160", VA = "0x184CCB760")]
	public void CEGAKGBDODP(GJMDEMKDHEC DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB830", Offset = "0x4CCA230", VA = "0x184CCB830")]
	public void DFDJPGANONL(GJMDEMKDHEC DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB150", Offset = "0x4CC9B50", VA = "0x184CCB150", Slot = "4")]
	public void BGDNFCPCDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4CCBF60", Offset = "0x4CCA960", VA = "0x184CCBF60")]
	public void JCPEDGKMAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC030", Offset = "0x4CCAA30", VA = "0x184CCC030")]
	private void PPBPDCOFJAJ(GJMDEMKDHEC DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB940", Offset = "0x4CCA340", VA = "0x184CCB940")]
	public void GOLAPBKKKKA(bool MHGLIDBOIMA, bool HGAMLFPJGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4CCBE20", Offset = "0x4CCA820", VA = "0x184CCBE20")]
	protected void ILGBFMFIGAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB6F0", Offset = "0x4CCA0F0", VA = "0x184CCB6F0")]
	[IteratorStateMachine(typeof(EMAGFAMPMPF))]
	public IEnumerable<Renderer> CCDMONLDPIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4CCB8D0", Offset = "0x4CCA2D0", VA = "0x184CCB8D0")]
	[IteratorStateMachine(typeof(DLDOKJGFIDP))]
	public IEnumerable<Renderer> GCDHANCCNGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class MIDAIHCDOPA : GJMDEMKDHEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private EDAOINBINCJ OCBPKMEBADG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4CD2ED0", Offset = "0x4CD18D0", VA = "0x184CD2ED0")]
	private NativeList<FKHBENHEGHH> LHCLMOOHPOE()
	{
		return default(NativeList<FKHBENHEGHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD0B10", Offset = "0x4CCF510", VA = "0x184CD0B10")]
	public MIDAIHCDOPA(BIJBIMOACMI DDLLFFEEEME, EDAOINBINCJ CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4CD2560", Offset = "0x4CD0F60", VA = "0x184CD2560", Slot = "13")]
	public override int AMDABMDFAGE(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4CD2780", Offset = "0x4CD1180", VA = "0x184CD2780", Slot = "14")]
	public override int EKLCEJOICID(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4CD29A0", Offset = "0x4CD13A0", VA = "0x184CD29A0", Slot = "15")]
	public override void JNNLKDFEIGK(FNAOJINHLPB OPAANEOCAHH, DDNJIGMIAPI FLCPIGBNHNH, int IBEALIMNFFI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MHPDJOBMMJB : global::ICODKHMKNJJ<MHPDJOBMMJB>, JPKBKOFGKDG, IEquatable<MHPDJOBMMJB>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6043F0", Offset = "0x602DF0", VA = "0x1806043F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB80", Offset = "0x6E9580", VA = "0x1806EAB80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AJBHNBBCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x960AE0", Offset = "0x95F4E0", VA = "0x180960AE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA6C290", Offset = "0xA6AC90", VA = "0x180A6C290", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x10FA390", Offset = "0x10F8D90", VA = "0x1810FA390", Slot = "8")]
	public bool Equals(MHPDJOBMMJB KKPJJILPNAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4CD2520", Offset = "0x4CD0F20", VA = "0x184CD2520")]
	public static bool EDEIDOGAGHI(MHPDJOBMMJB ANNMBFABHDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum JCMAEHJHGEJ
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
public interface CPMIIMNAJPP
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform FLELOEMNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JCMAEHJHGEJ IFAAJGGOOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AGPPPDGBKCD : global::ICODKHMKNJJ<AGPPPDGBKCD>, JPKBKOFGKDG, IEquatable<AGPPPDGBKCD>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6043F0", Offset = "0x602DF0", VA = "0x1806043F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB80", Offset = "0x6E9580", VA = "0x1806EAB80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AJBHNBBCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x960AE0", Offset = "0x95F4E0", VA = "0x180960AE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA6C290", Offset = "0xA6AC90", VA = "0x180A6C290", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x10FA390", Offset = "0x10F8D90", VA = "0x1810FA390", Slot = "8")]
	public bool Equals(AGPPPDGBKCD KKPJJILPNAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4CCA970", Offset = "0x4CC9370", VA = "0x184CCA970")]
	public static bool EDEIDOGAGHI(AGPPPDGBKCD ANNMBFABHDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OGHNEKBLGPF
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform FLELOEMNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float CNLPKJCIMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Vector3 HMFCKKPHBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FJKMEOPNDGG ECKGGFFAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IIOAHOMEEGA HDKAEAIBNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HOGCLBMCGKM : OGHNEKBLGPF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	JHCOMBHMCGI DPCLBKHHNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LNLDNFLCKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EDAOINBINCJ : OGHNEKBLGPF
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ALMIJDGGOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GMBBOLLDMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float KAOEHEBEGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int ILFNHECGGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NHCJGEBFJMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<FKHBENHEGHH> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KNOMEIIENEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFEHMDFGKDE(AGPPPDGBKCD DELEJHEPEEE, CAFBEPNNPMK OCIFKCBODJN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFEHMDFGKDE(MHPDJOBMMJB DDLLFFEEEME, CAFBEPNNPMK OCIFKCBODJN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHJCHLKMCOL(MHPDJOBMMJB DDLLFFEEEME);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHJCHLKMCOL(AGPPPDGBKCD DELEJHEPEEE);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFKAHGPHDDI(MHPDJOBMMJB DDLLFFEEEME, DEOMEEOBOGG IEADHAAGEDA);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNOENHOILOJ(MHPDJOBMMJB DDLLFFEEEME, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH, IReadOnlyList<Camera> BKOONPGEBNE, EFAMMGANPNP JBOLLCOGNHI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JNOENHOILOJ(LICGLAEBIPH HHHKPMEFAJC, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LFAEGBKLGBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHPDJOBMMJB GNMINOEGHOO(CPMIIMNAJPP CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMBLFDECMEL(MHPDJOBMMJB DDLLFFEEEME);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANIAEJDLDLN(MHPDJOBMMJB DDLLFFEEEME);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AGPPPDGBKCD FFCEMIHEJCD(MHPDJOBMMJB DDLLFFEEEME, HOGCLBMCGKM CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AGPPPDGBKCD IALMEJPPCAC(MHPDJOBMMJB DDLLFFEEEME, EDAOINBINCJ CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPCJJGOACAJ(AGPPPDGBKCD DELEJHEPEEE);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void COHIGKDGAIL(AGPPPDGBKCD DELEJHEPEEE);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LICGLAEBIPH IMEDPHLJOMF(GMPMCHFDGEN CIBAGEDPOOH);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AKMEBPNNMMK(LICGLAEBIPH HHHKPMEFAJC);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FPOFAMHPHBE(LICGLAEBIPH HHHKPMEFAJC);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FDNGLNHKOBP LIJMKLOAMDC(Transform BEDJIMAHPNA, IEnumerable<AGPPPDGBKCD> DMGCAAGHDAH, int HLJHLJBBGGG);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> JKMGPFCNBDC(MHPDJOBMMJB DDLLFFEEEME);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LICGLAEBIPH : global::ICODKHMKNJJ<LICGLAEBIPH>, JPKBKOFGKDG, IEquatable<LICGLAEBIPH>
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6043F0", Offset = "0x602DF0", VA = "0x1806043F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB80", Offset = "0x6E9580", VA = "0x1806EAB80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int AJBHNBBCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x960AE0", Offset = "0x95F4E0", VA = "0x180960AE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA6C290", Offset = "0xA6AC90", VA = "0x180A6C290", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x10FA390", Offset = "0x10F8D90", VA = "0x1810FA390", Slot = "8")]
	public bool Equals(LICGLAEBIPH KKPJJILPNAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4CD24E0", Offset = "0x4CD0EE0", VA = "0x184CD24E0")]
	public static bool EDEIDOGAGHI(LICGLAEBIPH ANNMBFABHDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GMPMCHFDGEN
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int EHDBDLODPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Transform PMFCPMOOHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JKCACFMMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MHPDJOBMMJB GetBone(int EPEDGGPALGC);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EPEDGGPALGC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class IDCHJNGAOJI : GJMDEMKDHEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public HOGCLBMCGKM LEAKMKLMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int[] BNNFDPEFJAA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public override EOKOJNFCPLK LKGDNMMMDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF700", Offset = "0x4CCE100", VA = "0x184CCF700", Slot = "12")]
		get
		{
			return default(EOKOJNFCPLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 JMMJLMDDIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4CD0930", Offset = "0x4CCF330", VA = "0x184CD0930")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4CD0B10", Offset = "0x4CCF510", VA = "0x184CD0B10")]
	public IDCHJNGAOJI(BIJBIMOACMI DDLLFFEEEME, HOGCLBMCGKM CIBAGEDPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4CD0430", Offset = "0x4CCEE30", VA = "0x184CD0430", Slot = "11")]
	public override bool MNMFGBAEHJA(Transform DDLLFFEEEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4CCF660", Offset = "0x4CCE060", VA = "0x184CCF660", Slot = "13")]
	public override int AMDABMDFAGE(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4CCFCE0", Offset = "0x4CCE6E0", VA = "0x184CCFCE0", Slot = "14")]
	public override int EKLCEJOICID(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4CCFAA0", Offset = "0x4CCE4A0", VA = "0x184CCFAA0")]
	private int ECKBLFCPJIC(FNAOJINHLPB OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4CCFD80", Offset = "0x4CCE780", VA = "0x184CCFD80", Slot = "15")]
	public override void JNNLKDFEIGK(FNAOJINHLPB OPAANEOCAHH, DDNJIGMIAPI FLCPIGBNHNH, int IBEALIMNFFI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JLHOKGKDGBP
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKPPIBHFDAB(DEOMEEOBOGG IEADHAAGEDA, Renderer GAIJLBPLIBE, int GGCCHJJHIGI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMGJLNLOFNE(Renderer GAIJLBPLIBE, EFAMMGANPNP JBOLLCOGNHI, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH, float MLLNICMCMFE = -1f, [Optional] Color? FELGEKLHNJA, [Optional] IReadOnlyList<Camera> DFOOACHGIMB);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGHLFGCIFNO(Renderer GAIJLBPLIBE, int GGCCHJJHIGI);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BHDCIKJCMGP();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFANJIGDOEI(int KPLBIIIGLKO, CAFBEPNNPMK IEADHAAGEDA, Renderer GAIJLBPLIBE, int GGCCHJJHIGI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NAMGNICJGIP : KNOMEIIENEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly JLHOKGKDGBP LDBMMCJDFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CPHDBINAMAC EMJIDAGKLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MeshRenderer JKKCMMGBPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private DMBGPDJFDBI ADHHJHMMNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private MeshRenderer KLDLAECHHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private DMBGPDJFDBI NOELHBGOIOJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x58A610", Offset = "0x589010", VA = "0x18058A610")]
	public NAMGNICJGIP(JLHOKGKDGBP MIKNOMCIOLJ, CPHDBINAMAC EMJIDAGKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4CD37E0", Offset = "0x4CD21E0", VA = "0x184CD37E0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4CD3560", Offset = "0x4CD1F60", VA = "0x184CD3560", Slot = "4")]
	public void DFEHMDFGKDE(AGPPPDGBKCD DELEJHEPEEE, CAFBEPNNPMK OCIFKCBODJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4CD3390", Offset = "0x4CD1D90", VA = "0x184CD3390", Slot = "5")]
	public void DFEHMDFGKDE(MHPDJOBMMJB DDLLFFEEEME, CAFBEPNNPMK OCIFKCBODJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4CD2FA0", Offset = "0x4CD19A0", VA = "0x184CD2FA0", Slot = "6")]
	public void BHJCHLKMCOL(MHPDJOBMMJB DDLLFFEEEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4CD3140", Offset = "0x4CD1B40", VA = "0x184CD3140", Slot = "7")]
	public void BHJCHLKMCOL(AGPPPDGBKCD DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4030", Offset = "0x4CD2A30", VA = "0x184CD4030", Slot = "8")]
	public void MFKAHGPHDDI(MHPDJOBMMJB DDLLFFEEEME, DEOMEEOBOGG IEADHAAGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4CD3D00", Offset = "0x4CD2700", VA = "0x184CD3D00", Slot = "9")]
	public void JNOENHOILOJ(MHPDJOBMMJB DDLLFFEEEME, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH, IReadOnlyList<Camera> BKOONPGEBNE, EFAMMGANPNP JBOLLCOGNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4CD3930", Offset = "0x4CD2330", VA = "0x184CD3930", Slot = "10")]
	public void JNOENHOILOJ(LICGLAEBIPH HHHKPMEFAJC, Vector3 AMDEMIMDPIG, Vector3 OEKBIKEINBC, Vector3 KFBPAPGJGOB, float PNJCIHGCNJB, float AKNCHPABDGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class GJMDEMKDHEC : EAEJMALDCGI, FKIIHBDDFPH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	protected Bounds PBLIKFBCNHB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BIJBIMOACMI OOHCCBDKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Bounds JKDFLENDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D7B0", Offset = "0x1A8C1B0", VA = "0x181A8D7B0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public virtual EOKOJNFCPLK LKGDNMMMDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF560", Offset = "0x4CCDF60", VA = "0x184CCF560", Slot = "12")]
		get
		{
			return default(EOKOJNFCPLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4CCF5F0", Offset = "0x4CCDFF0", VA = "0x184CCF5F0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576590", VA = "0x180577B90", Slot = "11")]
	public virtual bool MNMFGBAEHJA(Transform DDLLFFEEEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int AMDABMDFAGE(FNAOJINHLPB OPAANEOCAHH);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int EKLCEJOICID(FNAOJINHLPB OPAANEOCAHH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void JNNLKDFEIGK(FNAOJINHLPB OPAANEOCAHH, DDNJIGMIAPI FLCPIGBNHNH, int IBEALIMNFFI = -1);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	protected GJMDEMKDHEC()
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
		[Cpp2IlInjected.Address(RVA = "0x4CD54E0", Offset = "0x4CD3EE0", VA = "0x184CD54E0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JHCOMBHMCGI
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
public static class OMMEBDCCCKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FJBGLMMPKIH : IEnumerable<AJPAPAIKBDC>, IEnumerable, IEnumerator<AJPAPAIKBDC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private AJPAPAIKBDC <>2__current;

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
		private AJPAPAIKBDC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x759DB0", Offset = "0x7587B0", VA = "0x180759DB0")]
		[DebuggerHidden]
		public FJBGLMMPKIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF3A0", Offset = "0x4CCDDA0", VA = "0x184CCF3A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF510", Offset = "0x4CCDF10", VA = "0x184CCF510", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF480", Offset = "0x4CCDE80", VA = "0x184CCF480", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AJPAPAIKBDC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4CCF480", Offset = "0x4CCDE80", VA = "0x184CCF480", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const int HPPHHAKFJOF = 3;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static AJPAPAIKBDC[][] HGKKHBLJGJF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static JHDHMLIDPJF JEIFMNMKGLK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static ShapeRendererConfig BLAAIEJNGJP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static ComputeShader IPPFLAJAFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4CD45B0", Offset = "0x4CD2FB0", VA = "0x184CD45B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static SkinnedShapeRenderer ACPJJOBOOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5380", Offset = "0x4CD3D80", VA = "0x184CD5380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD52C0", Offset = "0x4CD3CC0", VA = "0x184CD52C0")]
	public static Mesh JMPOENFOBBA(JHCOMBHMCGI DHECJFKALEN, int OPAANEOCAHH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4A00", Offset = "0x4CD3400", VA = "0x184CD4A00")]
	public static int GDBIMOEPMBD(JHCOMBHMCGI DHECJFKALEN, int OPAANEOCAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4CD5170", Offset = "0x4CD3B70", VA = "0x184CD5170")]
	public static JHDHMLIDPJF IBKEMBLPFFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4CD5400", Offset = "0x4CD3E00", VA = "0x184CD5400")]
	[IteratorStateMachine(typeof(FJBGLMMPKIH))]
	private static IEnumerable<AJPAPAIKBDC> PNIODOKNLIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4A10", Offset = "0x4CD3410", VA = "0x184CD4A10")]
	public static AJPAPAIKBDC HKCPGGKFAPL(JHCOMBHMCGI DHECJFKALEN, int OPAANEOCAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4590", Offset = "0x4CD2F90", VA = "0x184CD4590")]
	public static bool ANIGBKDHPMK(this JHCOMBHMCGI DHECJFKALEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4840", Offset = "0x4CD3240", VA = "0x184CD4840")]
	public static void FMNAKIAAHKI(JHCOMBHMCGI DHECJFKALEN, float3 HONMIFJJGFA, out JDPEKGDEJHA DOOAAOLBFMB, out float3 MHFLGKCEDOH, out float FFFBIDMBCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4D50", Offset = "0x4CD3750", VA = "0x184CD4D50")]
	public static void IAAKJMLMAGL(Vector3 HONMIFJJGFA, JHCOMBHMCGI DHECJFKALEN, out Vector3 MHFLGKCEDOH, out float FFFBIDMBCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4CD53F0", Offset = "0x4CD3DF0", VA = "0x184CD53F0")]
	[FJOEOFBCKFM(DEGJMHBBGDK.ExitingPlayMode, 0)]
	private static void OHBADDGMCHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4CD4620", Offset = "0x4CD3020", VA = "0x184CD4620")]
	[FJOEOFBCKFM(DEGJMHBBGDK.ExitingPlayMode, 0)]
	private static void EKHFELLJCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DLFBBKAMBMM
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool JBFJPCKMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material CGKGFKLPHDG();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MAOJIGDBMKO();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LDMMAHBNAJN();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BKOMAIDDMMI(FJKMEOPNDGG DDKCCIMCMMD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CONLOIEOLJG(IIOAHOMEEGA NHIEILFLBDN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LFGGCJDNFLB(GameObject FBOGCDJOCBP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHBHJCHABPD(GameObject FBOGCDJOCBP, bool JHIILNFNAHE);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public interface CPHDBINAMAC
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BIJBIMOACMI INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GJMDEMKDHEC INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	EEJCNLJPJGP INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class DKIINNHGNKG : LFAEGBKLGBC, IDisposable, CPHDBINAMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::MFPGGCIEKBM<MHPDJOBMMJB, BIJBIMOACMI> MKDIAOIJAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::MFPGGCIEKBM<AGPPPDGBKCD, GJMDEMKDHEC> DMGCAAGHDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly global::MFPGGCIEKBM<LICGLAEBIPH, EEJCNLJPJGP> MHHIHDPGOBB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static DLFBBKAMBMM FCCMLGDFIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4CCC920", Offset = "0x4CCB320", VA = "0x184CCC920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4CCD080", Offset = "0x4CCBA80", VA = "0x184CCD080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BIJBIMOACMI INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4CCC780", Offset = "0x4CCB180", VA = "0x184CCC780", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GJMDEMKDHEC INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4CCC7E0", Offset = "0x4CCB1E0", VA = "0x184CCC7E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public EEJCNLJPJGP INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4CCC720", Offset = "0x4CCB120", VA = "0x184CCC720", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD0D0", Offset = "0x4CCBAD0", VA = "0x184CCD0D0")]
	public DKIINNHGNKG(DLFBBKAMBMM MIKNOMCIOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC550", Offset = "0x4CCAF50", VA = "0x184CCC550", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC840", Offset = "0x4CCB240", VA = "0x184CCC840", Slot = "4")]
	public MHPDJOBMMJB GNMINOEGHOO(CPMIIMNAJPP CIBAGEDPOOH)
	{
		return default(MHPDJOBMMJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC4F0", Offset = "0x4CCAEF0", VA = "0x184CCC4F0", Slot = "5")]
	public void DMBLFDECMEL(MHPDJOBMMJB DDLLFFEEEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC410", Offset = "0x4CCAE10", VA = "0x184CCC410", Slot = "6")]
	public void ANIAEJDLDLN(MHPDJOBMMJB DDLLFFEEEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4CCCB60", Offset = "0x4CCB560", VA = "0x184CCCB60", Slot = "15")]
	public IEnumerable<Renderer> JKMGPFCNBDC(MHPDJOBMMJB DDLLFFEEEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC5C0", Offset = "0x4CCAFC0", VA = "0x184CCC5C0", Slot = "7")]
	public AGPPPDGBKCD FFCEMIHEJCD(MHPDJOBMMJB DDLLFFEEEME, HOGCLBMCGKM CIBAGEDPOOH)
	{
		return default(AGPPPDGBKCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC960", Offset = "0x4CCB360", VA = "0x184CCC960", Slot = "8")]
	public AGPPPDGBKCD IALMEJPPCAC(MHPDJOBMMJB DDLLFFEEEME, EDAOINBINCJ CIBAGEDPOOH)
	{
		return default(AGPPPDGBKCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC480", Offset = "0x4CCAE80", VA = "0x184CCC480", Slot = "10")]
	public void COHIGKDGAIL(AGPPPDGBKCD DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD020", Offset = "0x4CCBA20", VA = "0x184CCD020", Slot = "9")]
	public void MPCJJGOACAJ(AGPPPDGBKCD DELEJHEPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4CCCA50", Offset = "0x4CCB450", VA = "0x184CCCA50", Slot = "11")]
	public LICGLAEBIPH IMEDPHLJOMF(GMPMCHFDGEN CIBAGEDPOOH)
	{
		return default(LICGLAEBIPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC6B0", Offset = "0x4CCB0B0", VA = "0x184CCC6B0", Slot = "13")]
	public void FPOFAMHPHBE(LICGLAEBIPH HHHKPMEFAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC3B0", Offset = "0x4CCADB0", VA = "0x184CCC3B0", Slot = "12")]
	public void AKMEBPNNMMK(LICGLAEBIPH HHHKPMEFAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4CCCC20", Offset = "0x4CCB620", VA = "0x184CCCC20", Slot = "14")]
	public FDNGLNHKOBP LIJMKLOAMDC(Transform BEDJIMAHPNA, IEnumerable<AGPPPDGBKCD> DMGCAAGHDAH, int HLJHLJBBGGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EEJCNLJPJGP : NKMGCNOGOGF
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NPEJEBJLDEE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EEJCNLJPJGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x759DB0", Offset = "0x7587B0", VA = "0x180759DB0")]
		[DebuggerHidden]
		public NPEJEBJLDEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4CD44B0", Offset = "0x4CD2EB0", VA = "0x184CD44B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4CD41D0", Offset = "0x4CD2BD0", VA = "0x184CD41D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4CD4550", Offset = "0x4CD2F50", VA = "0x184CD4550")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4CD4460", Offset = "0x4CD2E60", VA = "0x184CD4460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4CD43C0", Offset = "0x4CD2DC0", VA = "0x184CD43C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4CD43C0", Offset = "0x4CD2DC0", VA = "0x184CD43C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly GMPMCHFDGEN HPJEHLJBLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CPHDBINAMAC EMJIDAGKLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private AOLOAHJPJJJ BBAMLFONCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<IIEGENAOIDF> AGFMLJFPFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<IIEGENAOIDF> HAGOFPLFOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GameObject GLJKNPCJNLH;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4CCE500", Offset = "0x4CCCF00", VA = "0x184CCE500")]
	public static EEJCNLJPJGP IIMAFMCCNHM(GMPMCHFDGEN CIBAGEDPOOH, CPHDBINAMAC EMJIDAGKLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4CCEC00", Offset = "0x4CCD600", VA = "0x184CCEC00")]
	private EEJCNLJPJGP(GMPMCHFDGEN CIBAGEDPOOH, CPHDBINAMAC EMJIDAGKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4CCE7E0", Offset = "0x4CCD1E0", VA = "0x184CCE7E0")]
	public void OHNGCEIGACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4CCE490", Offset = "0x4CCCE90", VA = "0x184CCE490")]
	[IteratorStateMachine(typeof(NPEJEBJLDEE))]
	public IEnumerable<Renderer> CCDMONLDPIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4CCDA90", Offset = "0x4CCC490", VA = "0x184CCDA90", Slot = "4")]
	public void BGDNFCPCDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4CCE7B0", Offset = "0x4CCD1B0", VA = "0x184CCE7B0")]
	private void OBPOHIBCFPD(Vector3 NPFGBLLKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4CCE5E0", Offset = "0x4CCCFE0", VA = "0x184CCE5E0")]
	public void JCPEDGKMAKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IIEGENAOIDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct GOPEGBBABEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DDNJIGMIAPI HADGHNFOKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform NFGJIMDLEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int PGCNIMLLBFK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class IABGLGPJJOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public IIEGENAOIDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public FNAOJINHLPB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<GOPEGBBABEA> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public IABGLGPJJOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KOOGFNNHGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FDNGLNHKOBP combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public IABGLGPJJOP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public KOOGFNNHGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4CD1CB0", Offset = "0x4CD06B0", VA = "0x184CD1CB0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4CD1D20", Offset = "0x4CD0720", VA = "0x184CD1D20")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4CD1D60", Offset = "0x4CD0760", VA = "0x184CD1D60")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int[] OCFIHAOCNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private PMDPHBDMHMF FNIIEOLDFLI;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static Matrix4x4 INCMJBGNKPJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Mesh BMGOPFBLNOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int PAOMDMPGOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x551E70", VA = "0x180553470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x60F9E0", Offset = "0x60E3E0", VA = "0x18060F9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4CD15C0", Offset = "0x4CCFFC0", VA = "0x184CD15C0")]
	public void LMFBMKLEAAK(List<Transform> JMFNFBDPCDF, Matrix4x4[] ICGFIDEBPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4CD0B60", Offset = "0x4CCF560", VA = "0x184CD0B60")]
	public static List<IIEGENAOIDF> AEEGCHIFHAD(List<BIJBIMOACMI> ECAIIOOKKHF, FNAOJINHLPB OPAANEOCAHH, Bounds MJKIPNFICIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4CD10C0", Offset = "0x4CCFAC0", VA = "0x184CD10C0")]
	private JobHandle AJJNFBCCKNN(FDNGLNHKOBP HPCINANDOPG, int OCBAIJNKCNN, int JJDBOJDNNBD, FNAOJINHLPB OPAANEOCAHH, List<GOPEGBBABEA> IILGELOJKMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1440", Offset = "0x4CCFE40", VA = "0x184CD1440")]
	private void DNMNNGMAKGF(List<GOPEGBBABEA> IILGELOJKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1900", Offset = "0x4CD0300", VA = "0x184CD1900")]
	private IIEGENAOIDF(List<GOPEGBBABEA> IILGELOJKMB, int OCBAIJNKCNN, int JJDBOJDNNBD, FNAOJINHLPB OPAANEOCAHH, Bounds MJKIPNFICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1540", Offset = "0x4CCFF40", VA = "0x184CD1540", Slot = "4")]
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
		private MaterialPropertyBlock EJJLNMNJNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private IIEGENAOIDF EALEDNNEEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<Transform> DOICBBMCBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private RenderTexture ALAMIALEAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private ComputeBuffer PGAFHKGBMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private ComputeShader KENKCNAKGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Matrix4x4[] BJAMCLBBMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int OABMFIHADCE;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MeshRenderer JKFFGKFCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x554E60", VA = "0x180556460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int EHDBDLODPMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4CD6080", Offset = "0x4CD4A80", VA = "0x184CD6080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5510", Offset = "0x4CD3F10", VA = "0x184CD5510")]
		public static List<SkinnedShapeRenderer> Create(GameObject DDLLFFEEEME, List<IIEGENAOIDF> FIJECPPAIPA, List<Transform> DOICBBMCBEJ, Material KFBCCEEBAFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5720", Offset = "0x4CD4120", VA = "0x184CD5720")]
		public void Init(IIEGENAOIDF EALEDNNEEBC, List<Transform> DOICBBMCBEJ, Material KFBCCEEBAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5F60", Offset = "0x4CD4960", VA = "0x184CD5F60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5ED0", Offset = "0x4CD48D0", VA = "0x184CD5ED0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5E90", Offset = "0x4CD4890", VA = "0x184CD5E90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5FF0", Offset = "0x4CD49F0", VA = "0x184CD5FF0")]
		private void PMDOOCGJBOG(ScriptableRenderContext PHFLFPJELLC, Camera[] KJJJNJFBCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5B40", Offset = "0x4CD4540", VA = "0x184CD5B40")]
		private void LMFBMKLEAAK(CommandBuffer LIINGCCKOCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4CD2220", Offset = "0x4CD0C20", VA = "0x184CD2220")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1EF0", Offset = "0x4CD08F0", VA = "0x184CD1EF0")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
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
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
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
