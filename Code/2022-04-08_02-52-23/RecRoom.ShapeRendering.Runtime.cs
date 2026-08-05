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
public enum LLPLFPMLEPN
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
public static class MBNICNKPFCB
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<LLPLFPMLEPN> OEJJFDCIFFD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4B0BA20", Offset = "0x4B0A820", VA = "0x184B0BA20")]
	static MBNICNKPFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B0BA20", Offset = "0x4B0A820", VA = "0x184B0BA20")]
	[JDALMPCAJMK]
	private static void LNBLCEPPLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B0B9A0", Offset = "0x4B0A7A0", VA = "0x184B0B9A0")]
	public static bool AGIBELIONEO(this LLPLFPMLEPN GKFEPHCDPGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AJNGLFPFONC
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
public enum FGBBFDCDGCA
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
public enum DEHPDAEKECC
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
	Configure,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum MAIJGMKDCEI
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EICEIAJFILL : LGGCOLEEDMG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private const byte ILOOAHBGKHA = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private byte MGBDADAODNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly List<SkinnedShapeRenderer>[] PLDGDNBHLDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HGLJFCEJLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x522CD0", Offset = "0x521AD0", VA = "0x180522CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62C6A0", Offset = "0x62B4A0", VA = "0x18062C6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BOEAPIAMHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x522CC0", Offset = "0x521AC0", VA = "0x180522CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E3AA0", Offset = "0x7E28A0", VA = "0x1807E3AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JMBIPCAAGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x656F30", Offset = "0x655D30", VA = "0x180656F30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x657410", Offset = "0x656210", VA = "0x180657410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float NNDBAPEDLAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x656F20", Offset = "0x655D20", VA = "0x180656F20", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x657400", Offset = "0x656200", VA = "0x180657400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> NPOPGEAOKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B07410", Offset = "0x4B06210", VA = "0x184B07410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject IBMKHGGBBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x54AA30", Offset = "0x549830", VA = "0x18054AA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBE0", Offset = "0x5CC9E0", VA = "0x1805CDBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte ODMAHPBEHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4B073C0", Offset = "0x4B061C0", VA = "0x184B073C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4B07470", Offset = "0x4B06270", VA = "0x184B07470")]
	public EICEIAJFILL(List<LOCIFGDOBLD> NKAPDDJPJJE, List<LOCIFGDOBLD> NAHFNODCODN, List<Transform> PMDOAFFIACG, Material KEMKMNEHCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B06F90", Offset = "0x4B05D90", VA = "0x184B06F90")]
	private int AHKDFANCECL(List<LOCIFGDOBLD> JJEPPCDAPBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B07220", Offset = "0x4B06020", VA = "0x184B07220")]
	private void GMLPBEJMHOE(int BIJMPHNBHNM, bool ELMAEIJFBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4B070A0", Offset = "0x4B05EA0", VA = "0x184B070A0")]
	public void ANPALCEKKMN(Vector3 OBDGAOEAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B07190", Offset = "0x4B05F90", VA = "0x184B07190", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B07380", Offset = "0x4B06180", VA = "0x184B07380")]
	public void HCMOEKBPADF(Transform JMHCEBOAMOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PEMENMFEJCG : PJGNJGJGMNK, KGNDGFLJJEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JBLEDMPKPLK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PEMENMFEJCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x706B10", Offset = "0x705910", VA = "0x180706B10")]
		[DebuggerHidden]
		public JBLEDMPKPLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4B082E0", Offset = "0x4B070E0", VA = "0x184B082E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4B07E30", Offset = "0x4B06C30", VA = "0x184B07E30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4B08460", Offset = "0x4B07260", VA = "0x184B08460")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4B084A0", Offset = "0x4B072A0", VA = "0x184B084A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4B084F0", Offset = "0x4B072F0", VA = "0x184B084F0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4B08290", Offset = "0x4B07090", VA = "0x184B08290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4B081F0", Offset = "0x4B06FF0", VA = "0x184B081F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4B081F0", Offset = "0x4B06FF0", VA = "0x184B081F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NHCHIPPOJBL KKFEGFOLPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<FFOOFEJIDCI> OBDCCHFIJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<ClusterMeshRenderer> OEONJMLJEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private BatchedMeshRenderer KBMLAABFFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool ANGBECOJPPI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<FJCHKHMHAGE> CDBPEIEIKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int PDFMAHEEPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4B0E6E0", Offset = "0x4B0D4E0", VA = "0x184B0E6E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform JPJIIJPJHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4B0E8F0", Offset = "0x4B0D6F0", VA = "0x184B0E8F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4B0EA80", Offset = "0x4B0D880", VA = "0x184B0EA80")]
	public PEMENMFEJCG(NHCHIPPOJBL MEGDGFMIPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E160", Offset = "0x4B0CF60", VA = "0x184B0E160", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E940", Offset = "0x4B0D740", VA = "0x184B0E940")]
	public void NGPIMMKGFMI(FFOOFEJIDCI MCMPELABOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B0EA10", Offset = "0x4B0D810", VA = "0x184B0EA10")]
	public void OGCMIFMLPGF(FFOOFEJIDCI MCMPELABOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E190", Offset = "0x4B0CF90", VA = "0x184B0E190", Slot = "4")]
	public void EBELMHOHHDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E860", Offset = "0x4B0D660", VA = "0x184B0E860")]
	public void IFLCLMJCIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4B0DAC0", Offset = "0x4B0C8C0", VA = "0x184B0DAC0")]
	private void AGAJPCJMILF(FFOOFEJIDCI MCMPELABOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B0DC80", Offset = "0x4B0CA80", VA = "0x184B0DC80")]
	public void CENODDFGNBJ(bool DJGMMGELCMO, bool CNFBPGLBBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E720", Offset = "0x4B0D520", VA = "0x184B0E720")]
	protected void IBFPGECMJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B0DC10", Offset = "0x4B0CA10", VA = "0x184B0DC10")]
	[IteratorStateMachine(typeof(JBLEDMPKPLK))]
	public IEnumerable<Renderer> BCEFDABFIKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class OBKFAEBAJCN : FFOOFEJIDCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NONBCAKGIGB IPFGODOBEOE;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B0BF80", Offset = "0x4B0AD80", VA = "0x184B0BF80")]
	private NativeList<LOMHNLOGADG> JDLICHJHOPM()
	{
		return default(NativeList<LOMHNLOGADG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C580", Offset = "0x4B0B380", VA = "0x184B0C580")]
	public OBKFAEBAJCN(PEMENMFEJCG MIJPOFHLMNP, NONBCAKGIGB MEGDGFMIPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B0BB40", Offset = "0x4B0A940", VA = "0x184B0BB40", Slot = "13")]
	public override int AHKDFANCECL(BIILLACIGHK DABPDAEJKAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B0BD60", Offset = "0x4B0AB60", VA = "0x184B0BD60", Slot = "14")]
	public override int HEFFFMKFFCE(BIILLACIGHK DABPDAEJKAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C050", Offset = "0x4B0AE50", VA = "0x184B0C050", Slot = "15")]
	public override void NIHAPHBHPHD(BIILLACIGHK DABPDAEJKAL, DOAMMKGGBFH EEIKMLKALFB, int DJMHAMCLDEI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LBKABCILIEC : global::JIMEJMBIFAO<LBKABCILIEC>, PEGENHNABPB, IEquatable<LBKABCILIEC>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int LNKLOMNFFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5C63C0", Offset = "0x5C51C0", VA = "0x1805C63C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xB0E550", Offset = "0xB0D350", VA = "0x180B0E550", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CAOIDEMHPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B30", Offset = "0x9C1930", VA = "0x1809C2B30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAD1B00", Offset = "0xAD0900", VA = "0x180AD1B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x13F3060", Offset = "0x13F1E60", VA = "0x1813F3060", Slot = "8")]
	public bool Equals(LBKABCILIEC KBAPGFOKKBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4B09490", Offset = "0x4B08290", VA = "0x184B09490")]
	public static bool JHPJNBIMGND(LBKABCILIEC FGLMPLBOFPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum LIPKMMADDDD
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NHCHIPPOJBL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform BFKBNJHFHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	LIPKMMADDDD OGDAEPDNHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct ECFCDOIOCEL : global::JIMEJMBIFAO<ECFCDOIOCEL>, PEGENHNABPB, IEquatable<ECFCDOIOCEL>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LNKLOMNFFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5C63C0", Offset = "0x5C51C0", VA = "0x1805C63C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB0E550", Offset = "0xB0D350", VA = "0x180B0E550", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CAOIDEMHPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B30", Offset = "0x9C1930", VA = "0x1809C2B30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAD1B00", Offset = "0xAD0900", VA = "0x180AD1B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x13F3060", Offset = "0x13F1E60", VA = "0x1813F3060", Slot = "8")]
	public bool Equals(ECFCDOIOCEL KBAPGFOKKBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4B06F50", Offset = "0x4B05D50", VA = "0x184B06F50")]
	public static bool JHPJNBIMGND(ECFCDOIOCEL FGLMPLBOFPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OHMPBPPHONF
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform BFKBNJHFHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float OJBOCIPMNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Vector3 OAMGDMEHGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LLPLFPMLEPN DDJKKAFONLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AJNGLFPFONC EFKLOBOCBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BFLLNLNCGBK : OHMPBPPHONF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	BLJJLIPBHEK JDHMODIGIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HIGKCPEKGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NONBCAKGIGB : OHMPBPPHONF
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MOMEKKHMEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool ALGPIFFJKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float AFNBPGAFMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int APABOOIFBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool DELGBINBKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<LOMHNLOGADG> JDLICHJHOPM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LADBENGKPHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEGKBCAOKLI(ECFCDOIOCEL MCMPELABOFD, DEHPDAEKECC JFBIEFFFGLB);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEGKBCAOKLI(LBKABCILIEC MIJPOFHLMNP, DEHPDAEKECC JFBIEFFFGLB);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELCDLEGEBBD(LBKABCILIEC MIJPOFHLMNP);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELCDLEGEBBD(ECFCDOIOCEL MCMPELABOFD);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFKPGMKLFGG(LBKABCILIEC MIJPOFHLMNP, MAIJGMKDCEI FEGCMBEFABH);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FAIMIGDKLNB(LBKABCILIEC MIJPOFHLMNP, Vector3 JKEEFAIJCLO, Vector3 IBKKDBCMGOI, Vector3 AJKFBLGJOKF, float INEMMOLBNII, float BFLDMGPLNBJ, IReadOnlyList<Camera> BGBEAGEPDGF, FGBBFDCDGCA LICHBPEMIFE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FAIMIGDKLNB(PBHGHMEAFME OEPAHMEEOPP, Vector3 JKEEFAIJCLO, Vector3 IBKKDBCMGOI, Vector3 AJKFBLGJOKF, float INEMMOLBNII, float BFLDMGPLNBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CECOMGCMBBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LBKABCILIEC HAJACBINMDF(NHCHIPPOJBL MEGDGFMIPIG);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPNEIPIJBPP(LBKABCILIEC MIJPOFHLMNP);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFNIPGLHKMG(LBKABCILIEC MIJPOFHLMNP);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ECFCDOIOCEL PHIPKBMNGPD(LBKABCILIEC MIJPOFHLMNP, BFLLNLNCGBK MEGDGFMIPIG);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ECFCDOIOCEL OGNFJFNFCDE(LBKABCILIEC MIJPOFHLMNP, NONBCAKGIGB MEGDGFMIPIG);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGMMPOPOLCA(ECFCDOIOCEL MCMPELABOFD);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGDFBDDKJBE(ECFCDOIOCEL MCMPELABOFD);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PBHGHMEAFME KKIEIBGLEKH(PHPEOHOCMGL MEGDGFMIPIG);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BKONJPEPOJN(PBHGHMEAFME OEPAHMEEOPP);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AKNOMGBKJBL(PBHGHMEAFME OEPAHMEEOPP);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AAGPMNPENHB DJMPGDDIBGA(Transform CKLEJIBDAPE, IEnumerable<ECFCDOIOCEL> OBDCCHFIJLN, int MDANMDNMHCH);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> HOAIIEBHBKB(LBKABCILIEC MIJPOFHLMNP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct PBHGHMEAFME : global::JIMEJMBIFAO<PBHGHMEAFME>, PEGENHNABPB, IEquatable<PBHGHMEAFME>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int LNKLOMNFFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5C63C0", Offset = "0x5C51C0", VA = "0x1805C63C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB0E550", Offset = "0xB0D350", VA = "0x180B0E550", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int CAOIDEMHPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B30", Offset = "0x9C1930", VA = "0x1809C2B30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAD1B00", Offset = "0xAD0900", VA = "0x180AD1B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x13F3060", Offset = "0x13F1E60", VA = "0x1813F3060", Slot = "8")]
	public bool Equals(PBHGHMEAFME KBAPGFOKKBB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4B0DA80", Offset = "0x4B0C880", VA = "0x184B0DA80")]
	public static bool JHPJNBIMGND(PBHGHMEAFME FGLMPLBOFPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PHPEOHOCMGL
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int FDDIPIMKHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform FMANAANGHED
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool JNNEMNIAEED
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBKABCILIEC GetBone(int IKBIEFMMEEH);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int IKBIEFMMEEH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class OJCGBBGGHPK : FFOOFEJIDCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public BFLLNLNCGBK FFCLFADFDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int[] FBGBEMAKNBJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public override MPCNKBFIJDJ NFMBNLLIAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4B0C670", Offset = "0x4B0B470", VA = "0x184B0C670", Slot = "12")]
		get
		{
			return default(MPCNKBFIJDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Vector3 MJPEBGMIJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4B0D1F0", Offset = "0x4B0BFF0", VA = "0x184B0D1F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C580", Offset = "0x4B0B380", VA = "0x184B0C580")]
	public OJCGBBGGHPK(PEMENMFEJCG MIJPOFHLMNP, BFLLNLNCGBK MEGDGFMIPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CCF0", Offset = "0x4B0BAF0", VA = "0x184B0CCF0", Slot = "11")]
	public override bool JHDJHNNHPPJ(Transform MIJPOFHLMNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C5D0", Offset = "0x4B0B3D0", VA = "0x184B0C5D0", Slot = "13")]
	public override int AHKDFANCECL(BIILLACIGHK DABPDAEJKAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CA10", Offset = "0x4B0B810", VA = "0x184B0CA10", Slot = "14")]
	public override int HEFFFMKFFCE(BIILLACIGHK DABPDAEJKAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CAB0", Offset = "0x4B0B8B0", VA = "0x184B0CAB0")]
	private int HHHHDKEMBIO(BIILLACIGHK DABPDAEJKAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B0D3D0", Offset = "0x4B0C1D0", VA = "0x184B0D3D0", Slot = "15")]
	public override void NIHAPHBHPHD(BIILLACIGHK DABPDAEJKAL, DOAMMKGGBFH EEIKMLKALFB, int DJMHAMCLDEI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GCGAKPICOHF
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNNJHLLJBCB(MAIJGMKDCEI FEGCMBEFABH, Renderer CJECPOEMDCO, int FCJHCCIOOCB);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABOLBOCLKMC(Renderer CJECPOEMDCO, FGBBFDCDGCA LICHBPEMIFE, Vector3 JKEEFAIJCLO, Vector3 IBKKDBCMGOI, Vector3 AJKFBLGJOKF, float INEMMOLBNII, float BFLDMGPLNBJ, float LIMDBOCFHBG = -1f, [Optional] Color? ADNAFGIMCJO, [Optional] IReadOnlyList<Camera> FEKFIHKDFNK);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODOIFFHJPIF(Renderer CJECPOEMDCO, int FCJHCCIOOCB);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KLIDFPDIFNC();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBHNOGKBEIA(int CHECIHJALPD, DEHPDAEKECC FEGCMBEFABH, Renderer CJECPOEMDCO, int FCJHCCIOOCB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PNFIDFFJHCL : LADBENGKPHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly GCGAKPICOHF BLEJGKHPNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly EKMENPBDLAM KANMBIAAOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private MeshRenderer HMPONLGCFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private HFIMKKPBMNG ELJANMALHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private MeshRenderer BIONOKCGAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private HFIMKKPBMNG CGNLJKDAMAK;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x535990", Offset = "0x534790", VA = "0x180535990")]
	public PNFIDFFJHCL(GCGAKPICOHF IEICNLHGBGO, EKMENPBDLAM KANMBIAAOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4B0ECB0", Offset = "0x4B0DAB0", VA = "0x184B0ECB0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4B0F8F0", Offset = "0x4B0E6F0", VA = "0x184B0F8F0", Slot = "4")]
	public void GEGKBCAOKLI(ECFCDOIOCEL MCMPELABOFD, DEHPDAEKECC JFBIEFFFGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4B0FB70", Offset = "0x4B0E970", VA = "0x184B0FB70", Slot = "5")]
	public void GEGKBCAOKLI(LBKABCILIEC MIJPOFHLMNP, DEHPDAEKECC JFBIEFFFGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B0EE00", Offset = "0x4B0DC00", VA = "0x184B0EE00", Slot = "6")]
	public void ELCDLEGEBBD(LBKABCILIEC MIJPOFHLMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4B0EFA0", Offset = "0x4B0DDA0", VA = "0x184B0EFA0", Slot = "7")]
	public void ELCDLEGEBBD(ECFCDOIOCEL MCMPELABOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4B0EB10", Offset = "0x4B0D910", VA = "0x184B0EB10", Slot = "8")]
	public void BFKPGMKLFGG(LBKABCILIEC MIJPOFHLMNP, MAIJGMKDCEI FEGCMBEFABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4B0F5C0", Offset = "0x4B0E3C0", VA = "0x184B0F5C0", Slot = "9")]
	public void FAIMIGDKLNB(LBKABCILIEC MIJPOFHLMNP, Vector3 JKEEFAIJCLO, Vector3 IBKKDBCMGOI, Vector3 AJKFBLGJOKF, float INEMMOLBNII, float BFLDMGPLNBJ, IReadOnlyList<Camera> BGBEAGEPDGF, FGBBFDCDGCA LICHBPEMIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4B0F1F0", Offset = "0x4B0DFF0", VA = "0x184B0F1F0", Slot = "10")]
	public void FAIMIGDKLNB(PBHGHMEAFME OEPAHMEEOPP, Vector3 JKEEFAIJCLO, Vector3 IBKKDBCMGOI, Vector3 AJKFBLGJOKF, float INEMMOLBNII, float BFLDMGPLNBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class FFOOFEJIDCI : PFLLNHBIMOA, FJCHKHMHAGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected Bounds DNOCMCBKLBE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public PEMENMFEJCG IBMKHGGBBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Bounds GDPIFJJGKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x22B1780", Offset = "0x22B0580", VA = "0x1822B1780", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public virtual MPCNKBFIJDJ NFMBNLLIAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4B07730", Offset = "0x4B06530", VA = "0x184B07730", Slot = "12")]
		get
		{
			return default(MPCNKBFIJDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4B077C0", Offset = "0x4B065C0", VA = "0x184B077C0", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x522EC0", Offset = "0x521CC0", VA = "0x180522EC0", Slot = "11")]
	public virtual bool JHDJHNNHPPJ(Transform MIJPOFHLMNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int AHKDFANCECL(BIILLACIGHK DABPDAEJKAL);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int HEFFFMKFFCE(BIILLACIGHK DABPDAEJKAL);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void NIHAPHBHPHD(BIILLACIGHK DABPDAEJKAL, DOAMMKGGBFH EEIKMLKALFB, int DJMHAMCLDEI = -1);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	protected FFOOFEJIDCI()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4B10330", Offset = "0x4B0F130", VA = "0x184B10330")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum BLJJLIPBHEK
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class JMIJFMJEGBD
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LPMHFONLMJE : IEnumerable<EDOAHNEHODH>, IEnumerable, IEnumerator<EDOAHNEHODH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private EDOAHNEHODH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private EDOAHNEHODH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x706B10", Offset = "0x705910", VA = "0x180706B10")]
		[DebuggerHidden]
		public LPMHFONLMJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4B0B7E0", Offset = "0x4B0A5E0", VA = "0x184B0B7E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4B0B950", Offset = "0x4B0A750", VA = "0x184B0B950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4B0B8C0", Offset = "0x4B0A6C0", VA = "0x184B0B8C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EDOAHNEHODH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4B0B8C0", Offset = "0x4B0A6C0", VA = "0x184B0B8C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int DLMNFIAIELK = 3;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static EDOAHNEHODH[][] PNDBKPBOGHN;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static IBKNKJKGDAL DPOKOPBODFB;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public static ShapeRendererConfig CLIGAIBILDL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static ComputeShader NGOCNJNJOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4B08540", Offset = "0x4B07340", VA = "0x184B08540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static SkinnedShapeRenderer EGFDDEFNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4B089C0", Offset = "0x4B077C0", VA = "0x184B089C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4B085B0", Offset = "0x4B073B0", VA = "0x184B085B0")]
	public static Mesh CPENANACCLO(BLJJLIPBHEK HOCOBKDEOHF, int DABPDAEJKAL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4B08DC0", Offset = "0x4B07BC0", VA = "0x184B08DC0")]
	public static int HIKBAHBIHPC(BLJJLIPBHEK HOCOBKDEOHF, int DABPDAEJKAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4B08A30", Offset = "0x4B07830", VA = "0x184B08A30")]
	public static IBKNKJKGDAL FPNPNLMACOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4B08F90", Offset = "0x4B07D90", VA = "0x184B08F90")]
	[IteratorStateMachine(typeof(LPMHFONLMJE))]
	private static IEnumerable<EDOAHNEHODH> LJBHONDCBAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4B08680", Offset = "0x4B07480", VA = "0x184B08680")]
	public static EDOAHNEHODH EOKBMOFGKMO(BLJJLIPBHEK HOCOBKDEOHF, int DABPDAEJKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4B08B80", Offset = "0x4B07980", VA = "0x184B08B80")]
	public static bool GJOBPCKGKFM(this BLJJLIPBHEK HOCOBKDEOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4B08DD0", Offset = "0x4B07BD0", VA = "0x184B08DD0")]
	public static void KLDCEALIAPM(BLJJLIPBHEK HOCOBKDEOHF, float3 KCPDMFJNANM, out GDNCBCODPIB EBMAOAOIPLA, out float3 HDEHICGLBDK, out float GELOAMHKGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4B08FF0", Offset = "0x4B07DF0", VA = "0x184B08FF0")]
	public static void OBDNIIADGBJ(Vector3 KCPDMFJNANM, BLJJLIPBHEK HOCOBKDEOHF, out Vector3 HDEHICGLBDK, out float GELOAMHKGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4B08670", Offset = "0x4B07470", VA = "0x184B08670")]
	[LNPBCMJNPOF(KMPCCFGDDMG.ExitingPlayMode, 0)]
	private static void EDLGECONNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4B08BA0", Offset = "0x4B079A0", VA = "0x184B08BA0")]
	[LNPBCMJNPOF(KMPCCFGDDMG.ExitingPlayMode, 0)]
	private static void GODCAPCHAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FDBHKGICCDK
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool GJCIOINGAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material BIEKBCNCJEM();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material DKKMFJMANHL();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material FPMHKINIIFK();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KKCBJCBGKLK(LLPLFPMLEPN APLGDHKGCEA);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EJDMFDJJBME(AJNGLFPFONC MFLCIMDFPFP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DPLKNNMLEGN(GameObject AHLFMJPCIDI);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HOBBFAHEJBK(GameObject AHLFMJPCIDI, bool CCBFINOKEPE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public interface EKMENPBDLAM
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	PEMENMFEJCG IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FFOOFEJIDCI IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	APHFBBJONNI IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class LFHGOPKNBGA : CECOMGCMBBC, IDisposable, EKMENPBDLAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly global::DGPOFCEOILL<LBKABCILIEC, PEMENMFEJCG> EEIFJIPNNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly global::DGPOFCEOILL<ECFCDOIOCEL, FFOOFEJIDCI> OBDCCHFIJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly global::DGPOFCEOILL<PBHGHMEAFME, APHFBBJONNI> DOBMALCJCMO;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static FDBHKGICCDK EANGFDCJLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4B09C30", Offset = "0x4B08A30", VA = "0x184B09C30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B0A0B0", Offset = "0x4B08EB0", VA = "0x184B0A0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PEMENMFEJCG IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B09EA0", Offset = "0x4B08CA0", VA = "0x184B09EA0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FFOOFEJIDCI IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4B09F00", Offset = "0x4B08D00", VA = "0x184B09F00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public APHFBBJONNI IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4B09F60", Offset = "0x4B08D60", VA = "0x184B09F60", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B0A1F0", Offset = "0x4B08FF0", VA = "0x184B0A1F0")]
	public LFHGOPKNBGA(FDBHKGICCDK IEICNLHGBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4B099A0", Offset = "0x4B087A0", VA = "0x184B099A0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4B09B50", Offset = "0x4B08950", VA = "0x184B09B50", Slot = "4")]
	public LBKABCILIEC HAJACBINMDF(NHCHIPPOJBL MEGDGFMIPIG)
	{
		return default(LBKABCILIEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4B09AF0", Offset = "0x4B088F0", VA = "0x184B09AF0", Slot = "5")]
	public void FPNEIPIJBPP(LBKABCILIEC MIJPOFHLMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4B09A80", Offset = "0x4B08880", VA = "0x184B09A80", Slot = "6")]
	public void FFNIPGLHKMG(LBKABCILIEC MIJPOFHLMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4B09C70", Offset = "0x4B08A70", VA = "0x184B09C70", Slot = "15")]
	public IEnumerable<Renderer> HOAIIEBHBKB(LBKABCILIEC MIJPOFHLMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4B0A100", Offset = "0x4B08F00", VA = "0x184B0A100", Slot = "7")]
	public ECFCDOIOCEL PHIPKBMNGPD(LBKABCILIEC MIJPOFHLMNP, BFLLNLNCGBK MEGDGFMIPIG)
	{
		return default(ECFCDOIOCEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4B09FC0", Offset = "0x4B08DC0", VA = "0x184B09FC0", Slot = "8")]
	public ECFCDOIOCEL OGNFJFNFCDE(LBKABCILIEC MIJPOFHLMNP, NONBCAKGIGB MEGDGFMIPIG)
	{
		return default(ECFCDOIOCEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4B09A10", Offset = "0x4B08810", VA = "0x184B09A10", Slot = "10")]
	public void EGDFBDDKJBE(ECFCDOIOCEL MCMPELABOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4B09E40", Offset = "0x4B08C40", VA = "0x184B09E40", Slot = "9")]
	public void LGMMPOPOLCA(ECFCDOIOCEL MCMPELABOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4B09D30", Offset = "0x4B08B30", VA = "0x184B09D30", Slot = "11")]
	public PBHGHMEAFME KKIEIBGLEKH(PHPEOHOCMGL MEGDGFMIPIG)
	{
		return default(PBHGHMEAFME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4B094D0", Offset = "0x4B082D0", VA = "0x184B094D0", Slot = "13")]
	public void AKNOMGBKJBL(PBHGHMEAFME OEPAHMEEOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4B09540", Offset = "0x4B08340", VA = "0x184B09540", Slot = "12")]
	public void BKONJPEPOJN(PBHGHMEAFME OEPAHMEEOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4B095A0", Offset = "0x4B083A0", VA = "0x184B095A0", Slot = "14")]
	public AAGPMNPENHB DJMPGDDIBGA(Transform CKLEJIBDAPE, IEnumerable<ECFCDOIOCEL> OBDCCHFIJLN, int MDANMDNMHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class APHFBBJONNI : PJGNJGJGMNK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HDGOCCPMNGK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public APHFBBJONNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x706B10", Offset = "0x705910", VA = "0x180706B10")]
		[DebuggerHidden]
		public HDGOCCPMNGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4B07D50", Offset = "0x4B06B50", VA = "0x184B07D50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4B07A70", Offset = "0x4B06870", VA = "0x184B07A70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4B07DF0", Offset = "0x4B06BF0", VA = "0x184B07DF0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B07D00", Offset = "0x4B06B00", VA = "0x184B07D00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4B07C60", Offset = "0x4B06A60", VA = "0x184B07C60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B07C60", Offset = "0x4B06A60", VA = "0x184B07C60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly PHPEOHOCMGL EGFCOIIIOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly EKMENPBDLAM KANMBIAAOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private EICEIAJFILL BNBLKMPBCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private List<LOCIFGDOBLD> HBCAMHABCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private List<LOCIFGDOBLD> HEMJMMKFMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private GameObject CMCMAMLBOAJ;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B05E00", Offset = "0x4B04C00", VA = "0x184B05E00")]
	public static APHFBBJONNI ALFBFIBCLKI(PHPEOHOCMGL MEGDGFMIPIG, EKMENPBDLAM KANMBIAAOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B06EC0", Offset = "0x4B05CC0", VA = "0x184B06EC0")]
	private APHFBBJONNI(PHPEOHOCMGL MEGDGFMIPIG, EKMENPBDLAM KANMBIAAOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B06AA0", Offset = "0x4B058A0", VA = "0x184B06AA0")]
	public void PKIKJPNJAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4B05EE0", Offset = "0x4B04CE0", VA = "0x184B05EE0")]
	[IteratorStateMachine(typeof(HDGOCCPMNGK))]
	public IEnumerable<Renderer> BCEFDABFIKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4B05F80", Offset = "0x4B04D80", VA = "0x184B05F80", Slot = "4")]
	public void EBELMHOHHDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B05F50", Offset = "0x4B04D50", VA = "0x184B05F50")]
	private void BKNDCIMAIAI(Vector3 OBDGAOEAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B068D0", Offset = "0x4B056D0", VA = "0x184B068D0")]
	public void IFLCLMJCIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LOCIFGDOBLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct OIHPMMOINBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public DOAMMKGGBFH MEPHMNFGBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Transform AAEBOOFJNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int KLMAKFFLEMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class PIOGLBCPEMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public LOCIFGDOBLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public BIILLACIGHK lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public List<OIHPMMOINBO> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public PIOGLBCPEMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class GJLPFAKADMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AAGPMNPENHB combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public PIOGLBCPEMF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public GJLPFAKADMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4B07830", Offset = "0x4B06630", VA = "0x184B07830")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4B078A0", Offset = "0x4B066A0", VA = "0x184B078A0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4B078E0", Offset = "0x4B066E0", VA = "0x184B078E0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int[] EAANPNJMANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private BNFLPJDHPPI IJDOCGDFGHF;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static Matrix4x4 LOLBCAKLNLI;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Mesh NLLDCFANJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int PNHEBJPEKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x595210", Offset = "0x594010", VA = "0x180595210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5A3710", Offset = "0x5A2510", VA = "0x1805A3710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B0AD70", Offset = "0x4B09B70", VA = "0x184B0AD70")]
	public void FMEJPEDHKNO(List<Transform> MBEANDMJIBL, Matrix4x4[] KLGEHCDDJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B0A7E0", Offset = "0x4B095E0", VA = "0x184B0A7E0")]
	public static List<LOCIFGDOBLD> FBNMOHOMNBD(List<KGNDGFLJJEB> PCBEFKHAOPK, BIILLACIGHK DABPDAEJKAL, Bounds CDNDMGOKKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4B0AF70", Offset = "0x4B09D70", VA = "0x184B0AF70")]
	private JobHandle HKOIJMHCIKN(AAGPMNPENHB BLJFLFKGNBF, int LPPNAFLEFPJ, int NPJBIEMGNFK, BIILLACIGHK DABPDAEJKAL, List<OIHPMMOINBO> DNDCIOLJJGB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B0A660", Offset = "0x4B09460", VA = "0x184B0A660")]
	private void DDKMBDOIKII(List<OIHPMMOINBO> DNDCIOLJJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B0B430", Offset = "0x4B0A230", VA = "0x184B0B430")]
	private LOCIFGDOBLD(List<OIHPMMOINBO> DNDCIOLJJGB, int LPPNAFLEFPJ, int NPJBIEMGNFK, BIILLACIGHK DABPDAEJKAL, Bounds CDNDMGOKKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B0A760", Offset = "0x4B09560", VA = "0x184B0A760", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private MaterialPropertyBlock ABNOKIGMPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private LOCIFGDOBLD EAAEDGJDCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private List<Transform> PMDOAFFIACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private RenderTexture OBJLCMFOMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private ComputeBuffer NMGNAFLNKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private ComputeShader GACJLFKAHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private Matrix4x4[] CPEIHAICADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private int KFPCOOLKBJB;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public MeshRenderer GGLDOECECOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5224A0", Offset = "0x5212A0", VA = "0x1805224A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int FDDIPIMKHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4B10ED0", Offset = "0x4B0FCD0", VA = "0x184B10ED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4B10360", Offset = "0x4B0F160", VA = "0x184B10360")]
		public static List<SkinnedShapeRenderer> Create(GameObject MIJPOFHLMNP, List<LOCIFGDOBLD> JJEPPCDAPBE, List<Transform> PMDOAFFIACG, Material KEMKMNEHCPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4B10950", Offset = "0x4B0F750", VA = "0x184B10950")]
		public void Init(LOCIFGDOBLD EAAEDGJDCOJ, List<Transform> PMDOAFFIACG, Material KEMKMNEHCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B10E40", Offset = "0x4B0FC40", VA = "0x184B10E40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4B10DB0", Offset = "0x4B0FBB0", VA = "0x184B10DB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4B10D70", Offset = "0x4B0FB70", VA = "0x184B10D70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4B108C0", Offset = "0x4B0F6C0", VA = "0x184B108C0")]
		private void FOOBGMDKGLH(ScriptableRenderContext MILHAHGHJGA, Camera[] NGILMADCMOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4B10570", Offset = "0x4B0F370", VA = "0x184B10570")]
		private void FMEJPEDHKNO(CommandBuffer LIBKKBKNLLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBD0", Offset = "0x5CC9D0", VA = "0x1805CDBD0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PNNMOCCLFDL
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static byte[] MBBLNMFMFMG;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int MGBCGAMEIAA;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int GGINOEAOLGL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static BigInteger FIINFAJLNBA;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public PNNMOCCLFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B0FD40", Offset = "0x4B0EB40", VA = "0x184B0FD40")]
	private static string NFPHDFCNCGP(byte[] BAHCPBFJIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B0FE40", Offset = "0x4B0EC40", VA = "0x184B0FE40")]
	public static string NLBDLCJIPCH(byte[] IEDOMBJDKEO, bool HAFBALPHMDI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
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
