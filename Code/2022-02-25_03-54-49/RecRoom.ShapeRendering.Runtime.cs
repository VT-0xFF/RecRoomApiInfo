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
public enum PDGBCPKMCJH
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
	DARK_TAN = 33,
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
public enum JAKIGOFOMGA
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CARDBOARD = 0,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	NEON = 1,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	BRICK = 2,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CARPET = 3,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DIRT = 4,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	GRASS = 5,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	METAL_REFLECTIVE = 6,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CONCRETE = 7,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	LINOLEUM = 8,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	PLASTER = 9,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	WOOD_LOGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	WOOD_BOARDS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	WOOD_GRAIN = 12,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	WOOD_FLOOR = 13,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	SAND = 14,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GLOSSY_PLASTIC = 15,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CLOTH = 16,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	RUBBER_FLOOR = 17,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	METAL_FLOOR_TREAD = 18,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PAINTED_BRICK = 19,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CRASHPAD = 20,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	PAINTED_WOOD = 21,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	GRIP_TAPE = 22,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	GALVANIZED_METAL = 23,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	PARTICLE_BOARD = 24,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CHECKERED_FLOOR = 25,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SPARKLY_VINYL = 26,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	GRAVEL = 27,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	ROCK = 28,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	PLACEHOLDER_16 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PLACEHOLDER_17 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PLACEHOLDER_18 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	MIN_VALUE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MAX_VALUE = 31,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GFFEGKODJJD
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Ghost = 0,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	GhostSkinned = 50,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	ShadowsOnly = 100,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	ShadowsOnlySkinned = 150,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Hide = 200
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IGNEAHGOOOO
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Hover,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Tutorial,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Teleport,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Menu,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CircuitNode,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	ExtrusionHover,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Configure,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NearbyContextual
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum IOINAFBCKKJ
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FOGFAKBLPAH : JFNKJPLFECL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private const byte HJIMGNBJLEO = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private byte MKJBGIIOGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly List<SkinnedShapeRenderer>[] DACNKHKKCGD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LDJMBKJALJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x50D460", Offset = "0x50BA60", VA = "0x18050D460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x56D4C0", Offset = "0x56BAC0", VA = "0x18056D4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CKBMCIMBNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x57F1B0", Offset = "0x57D7B0", VA = "0x18057F1B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x70A2C0", Offset = "0x7088C0", VA = "0x18070A2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float ECCIBPGDOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5AA100", Offset = "0x5A8700", VA = "0x1805AA100", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5A8190", Offset = "0x5A6790", VA = "0x1805A8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float NCGEDCMNLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B7380", Offset = "0x6B5980", VA = "0x1806B7380", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA31190", Offset = "0xA2F790", VA = "0x180A31190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> JLFJHBMOOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x30D3580", Offset = "0x30D1B80", VA = "0x1830D3580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject JEAEKLPDKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x50DAE0", Offset = "0x50C0E0", VA = "0x18050DAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte CHBMPKJGADG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x30D3530", Offset = "0x30D1B30", VA = "0x1830D3530", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x30D36F0", Offset = "0x30D1CF0", VA = "0x1830D36F0")]
	public FOGFAKBLPAH(List<IBJKMPGKDHK> LPKIAPLLEBN, List<IBJKMPGKDHK> KCEBGGGHGCC, List<Transform> FLJLGKPMAJK, Material HJLAFDEKKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x30D35E0", Offset = "0x30D1BE0", VA = "0x1830D35E0")]
	private int NJPJADPKPIJ(List<IBJKMPGKDHK> KMKBPAMHILJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x30D3210", Offset = "0x30D1810", VA = "0x1830D3210")]
	private void BMBNLAFCLPJ(int KDENFKNKHBJ, bool AJAEDFOMILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x30D3370", Offset = "0x30D1970", VA = "0x1830D3370")]
	public void DNDFDLKKLLK(Vector3 NDLIIACHOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x30D3460", Offset = "0x30D1A60", VA = "0x1830D3460", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x30D34F0", Offset = "0x30D1AF0", VA = "0x1830D34F0")]
	public void GLKKDMPLLCM(Transform FCHBCLOJBPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BDJPJPHHFGE : FHLEDGCFLMO, OEIIAFIJODH, MAEOODFJFNA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KEPCGDOFLFE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public BDJPJPHHFGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63CDC0", Offset = "0x63B3C0", VA = "0x18063CDC0")]
		[DebuggerHidden]
		public KEPCGDOFLFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x30D6EF0", Offset = "0x30D54F0", VA = "0x1830D6EF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x30D6A40", Offset = "0x30D5040", VA = "0x1830D6A40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x30D7070", Offset = "0x30D5670", VA = "0x1830D7070")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x30D70B0", Offset = "0x30D56B0", VA = "0x1830D70B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x30D7100", Offset = "0x30D5700", VA = "0x1830D7100")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x30D6EA0", Offset = "0x30D54A0", VA = "0x1830D6EA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x30D6E00", Offset = "0x30D5400", VA = "0x1830D6E00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x30D6E00", Offset = "0x30D5400", VA = "0x1830D6E00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private HAFMKCFBOAJ NINBHHIHHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private List<FCMDDHAABON> CFEHLIBCLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<ClusterMeshRenderer> DOHHNLLPBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private BatchedMeshRenderer FBPHLKBKEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool NGBFGAHEJID;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<DPOPELIIBAP> IDHCHGIAFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EALCKDGEIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x30D0450", Offset = "0x30CEA50", VA = "0x1830D0450", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform JFCMMNJPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x30D00E0", Offset = "0x30CE6E0", VA = "0x1830D00E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal override BDJPJPHHFGE DBIDDBBEOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x531600", Offset = "0x52FC00", VA = "0x180531600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x30D0B50", Offset = "0x30CF150", VA = "0x1830D0B50")]
	public BDJPJPHHFGE(HAFMKCFBOAJ PDGOOLFMMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x30D0130", Offset = "0x30CE730", VA = "0x1830D0130", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x30D09A0", Offset = "0x30CEFA0", VA = "0x1830D09A0")]
	public void OAKCALBAGFG(FCMDDHAABON NLPILOFOODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x30D0AE0", Offset = "0x30CF0E0", VA = "0x1830D0AE0")]
	public void PFBLIKHMAGM(FCMDDHAABON NLPILOFOODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x30D0490", Offset = "0x30CEA90", VA = "0x1830D0490", Slot = "5")]
	public void KAOGIJEFIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x30D0270", Offset = "0x30CE870", VA = "0x1830D0270")]
	public void HLFBHDKMFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x30D0300", Offset = "0x30CE900", VA = "0x1830D0300")]
	private void IBIEDPLLONH(FCMDDHAABON NLPILOFOODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x30CFC00", Offset = "0x30CE200", VA = "0x1830CFC00")]
	public void AAPIJGHOLCI(bool LMJABANFFKO, bool AFHHDHDJJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30D0160", Offset = "0x30CE760", VA = "0x1830D0160")]
	protected void EPHHLOPDCOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x30D0A70", Offset = "0x30CF070", VA = "0x1830D0A70")]
	[IteratorStateMachine(typeof(KEPCGDOFLFE))]
	public IEnumerable<Renderer> OGJLALMAEAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class IKCENPIGMBG : FCMDDHAABON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private PGALNEOHLBE BCNMHHAFEPH;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x30D5FB0", Offset = "0x30D45B0", VA = "0x1830D5FB0")]
	private NativeList<EKEHNMPKGIC> EPAHCIOKICE()
	{
		return default(NativeList<EKEHNMPKGIC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30D69F0", Offset = "0x30D4FF0", VA = "0x1830D69F0")]
	public IKCENPIGMBG(BDJPJPHHFGE MKDDPCAJMGN, PGALNEOHLBE PDGOOLFMMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30D67D0", Offset = "0x30D4DD0", VA = "0x1830D67D0", Slot = "14")]
	public override int NJPJADPKPIJ(OMKDNPMGFDI AFHBDAOJPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x30D65B0", Offset = "0x30D4BB0", VA = "0x1830D65B0", Slot = "15")]
	public override int NJMGIPCLIEK(OMKDNPMGFDI AFHBDAOJPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x30D6080", Offset = "0x30D4680", VA = "0x1830D6080", Slot = "16")]
	public override void MBGEPHLGFAL(OMKDNPMGFDI AFHBDAOJPEH, AEBIJCECNOB JOKKOOPDHJP, int BKOANJHDJGE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class FHLEDGCFLMO
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	internal virtual BDJPJPHHFGE DBIDDBBEOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x51D0D0", Offset = "0x51B6D0", VA = "0x18051D0D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	protected FHLEDGCFLMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NNDGMFPEDHF
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HAFMKCFBOAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform CBNBDHEIKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NNDGMFPEDHF EBMPKPNHJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class BBHGADPOGBG
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal virtual FCMDDHAABON FBBPOBPHKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x51D0D0", Offset = "0x51B6D0", VA = "0x18051D0D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	protected BBHGADPOGBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LIICMLJEEFF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform CBNBDHEIKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float LDHHGNFIKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Vector3 CNAJKCNHMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PDGBCPKMCJH JNBBNOPCOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	JAKIGOFOMGA LPNDBPLBHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GKGMIKJIFDH : LIICMLJEEFF
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	BEENIBAKMHA PANDINBFPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OMNJCMHOKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PGALNEOHLBE : LIICMLJEEFF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EJPGIBHCFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool DBGMGCIALPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float IMMPCGFLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int HEKLEELJBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool HCLLNHKPOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<EKEHNMPKGIC> EPAHCIOKICE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JFAPMMNAHPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCHGLGNLHKG(BBHGADPOGBG NLPILOFOODK, IGNEAHGOOOO PMALOCLJGHA);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCHGLGNLHKG(FHLEDGCFLMO MKDDPCAJMGN, IGNEAHGOOOO PMALOCLJGHA);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCELOMNGHMN(FHLEDGCFLMO MKDDPCAJMGN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICFMDNCLICF(FHLEDGCFLMO MKDDPCAJMGN, IOINAFBCKKJ JOBKDGGGOHC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJGCMGFDNJH(FHLEDGCFLMO MKDDPCAJMGN, Vector3 LMCBFGHDCEI, Vector3 PLGMMPFFJFI, Vector3 FFGKBGEMNMP, float NJJPACNBNCC, float AEHAGFHKHIB, IReadOnlyList<Camera> GFFFKMEIHDI, GFFEGKODJJD OFBOGAFOMJF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EJGCMGFDNJH(ILKNGCNPDEP OMBABEJEJNI, object KIPAKCNGHCM, object GLHNEIOCALP, float BLBFOBKKDKM, Color? NMHFJDHFAAL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IIFIFAKPFEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FHLEDGCFLMO ICFOKFNALKO(HAFMKCFBOAJ PDGOOLFMMCC);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEOBDDMHOME(FHLEDGCFLMO MKDDPCAJMGN);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCCOHJJBLKN(FHLEDGCFLMO MKDDPCAJMGN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BBHGADPOGBG GKPGMEJPFNN(FHLEDGCFLMO MKDDPCAJMGN, GKGMIKJIFDH PDGOOLFMMCC);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BBHGADPOGBG ONAFMDCCMPD(FHLEDGCFLMO MKDDPCAJMGN, PGALNEOHLBE PDGOOLFMMCC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNIFANAPBAH(BBHGADPOGBG NLPILOFOODK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNAKEMJEAIM(BBHGADPOGBG NLPILOFOODK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ILKNGCNPDEP LLIGDHLLPJF(BNFDJOGAPCF PDGOOLFMMCC);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PGAKNNLEFCH(ILKNGCNPDEP OMBABEJEJNI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EOOBCJNJAFP(ILKNGCNPDEP OMBABEJEJNI);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EIDDMAEKOAL FHEEOKAIPKG(Transform HFPAFPDOEGF, IEnumerable<BBHGADPOGBG> CFEHLIBCLPI, int KAHLNNKAGIH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> EAEGKECHDCF(FHLEDGCFLMO MKDDPCAJMGN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class ILKNGCNPDEP
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal virtual HBMELOMDCNK NCOCONKLOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x51D0D0", Offset = "0x51B6D0", VA = "0x18051D0D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	protected ILKNGCNPDEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BNFDJOGAPCF
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int PMNDIGIFGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Transform IJHDMFNHDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BLGBAJNEJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHLEDGCFLMO GetBone(int NODABMLAJHK);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int NODABMLAJHK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class OCIFDBCJNPI : FCMDDHAABON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public GKGMIKJIFDH CKAOAEMOHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int[] AGKJLHFJFLK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public override EIALAHJEFGD POIDJGFNODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x30D84C0", Offset = "0x30D6AC0", VA = "0x1830D84C0", Slot = "13")]
		get
		{
			return default(EIALAHJEFGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Vector3 HEIPFJFAJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x30D8F10", Offset = "0x30D7510", VA = "0x1830D8F10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x30D69F0", Offset = "0x30D4FF0", VA = "0x1830D69F0")]
	public OCIFDBCJNPI(BDJPJPHHFGE MKDDPCAJMGN, GKGMIKJIFDH PDGOOLFMMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x30D7FC0", Offset = "0x30D65C0", VA = "0x1830D7FC0", Slot = "12")]
	public override bool GECNAGGEDCC(Transform MKDDPCAJMGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x30D9190", Offset = "0x30D7790", VA = "0x1830D9190", Slot = "14")]
	public override int NJPJADPKPIJ(OMKDNPMGFDI AFHBDAOJPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x30D90F0", Offset = "0x30D76F0", VA = "0x1830D90F0", Slot = "15")]
	public override int NJMGIPCLIEK(OMKDNPMGFDI AFHBDAOJPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x30D7D80", Offset = "0x30D6380", VA = "0x1830D7D80")]
	private int DEGNKHFNOIK(OMKDNPMGFDI AFHBDAOJPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x30D8860", Offset = "0x30D6E60", VA = "0x1830D8860", Slot = "16")]
	public override void MBGEPHLGFAL(OMKDNPMGFDI AFHBDAOJPEH, AEBIJCECNOB JOKKOOPDHJP, int BKOANJHDJGE = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FGPELOHEOCL
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOEEKCFFKIE(IOINAFBCKKJ JOBKDGGGOHC, Renderer KDHLAHIEGGK, int MGKADHFCHPN);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFBCDFKPOFN(Renderer KDHLAHIEGGK, GFFEGKODJJD OFBOGAFOMJF, Vector3 LMCBFGHDCEI, Vector3 PLGMMPFFJFI, Vector3 FFGKBGEMNMP, float NJJPACNBNCC, float AEHAGFHKHIB, float BLBFOBKKDKM = -1f, [Optional] Color? NMHFJDHFAAL, [Optional] IReadOnlyList<Camera> PNHFFKMAABP);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFBCDFKPOFN(Renderer KDHLAHIEGGK, object KIPAKCNGHCM, object GLHNEIOCALP, bool KBIMAIFJHGG, float BLBFOBKKDKM, Color? NMHFJDHFAAL, bool DJFDHINPHED = false);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IECHBMEPEKJ(Renderer KDHLAHIEGGK, int MGKADHFCHPN);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CJNJAEMPKBK();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKJNEGCEICE(int LAOLCJLIACA, IGNEAHGOOOO JOBKDGGGOHC, Renderer KDHLAHIEGGK, int MGKADHFCHPN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BKCGHDDHGJJ : JFAPMMNAHPK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private FGPELOHEOCL EBNCEDOMGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private MeshRenderer HMOMKAKNKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private OOCAHBNEDJJ LIPOAOKAEJD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57F220", Offset = "0x57D820", VA = "0x18057F220")]
	public BKCGHDDHGJJ(FGPELOHEOCL CIBLIDEKMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x30D0BE0", Offset = "0x30CF1E0", VA = "0x1830D0BE0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x30D1290", Offset = "0x30CF890", VA = "0x1830D1290", Slot = "4")]
	public void GCHGLGNLHKG(BBHGADPOGBG NLPILOFOODK, IGNEAHGOOOO PMALOCLJGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x30D1500", Offset = "0x30CFB00", VA = "0x1830D1500", Slot = "5")]
	public void GCHGLGNLHKG(FHLEDGCFLMO MKDDPCAJMGN, IGNEAHGOOOO PMALOCLJGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x30D16D0", Offset = "0x30CFCD0", VA = "0x1830D16D0", Slot = "6")]
	public void HCELOMNGHMN(FHLEDGCFLMO MKDDPCAJMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x30D1860", Offset = "0x30CFE60", VA = "0x1830D1860", Slot = "7")]
	public void ICFMDNCLICF(FHLEDGCFLMO MKDDPCAJMGN, IOINAFBCKKJ JOBKDGGGOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x30D0C80", Offset = "0x30CF280", VA = "0x1830D0C80", Slot = "8")]
	public void EJGCMGFDNJH(FHLEDGCFLMO MKDDPCAJMGN, Vector3 LMCBFGHDCEI, Vector3 PLGMMPFFJFI, Vector3 FFGKBGEMNMP, float NJJPACNBNCC, float AEHAGFHKHIB, IReadOnlyList<Camera> GFFFKMEIHDI, GFFEGKODJJD OFBOGAFOMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x30D0FB0", Offset = "0x30CF5B0", VA = "0x1830D0FB0", Slot = "9")]
	public void EJGCMGFDNJH(ILKNGCNPDEP OMBABEJEJNI, object KIPAKCNGHCM, object GLHNEIOCALP, float BLBFOBKKDKM, Color? NMHFJDHFAAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class FCMDDHAABON : BBHGADPOGBG, NLNGEBEIFGN, DPOPELIIBAP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected Bounds JLJJHPFALGE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public BDJPJPHHFGE JEAEKLPDKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B0", Offset = "0x56AAB0", VA = "0x18056C4B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal override FCMDDHAABON FBBPOBPHKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x531600", Offset = "0x52FC00", VA = "0x180531600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Bounds PAEEADNDFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7B7960", Offset = "0x7B5F60", VA = "0x1807B7960", Slot = "5")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual EIALAHJEFGD POIDJGFNODP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x30D2230", Offset = "0x30D0830", VA = "0x1830D2230", Slot = "13")]
		get
		{
			return default(EIALAHJEFGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x511400", Offset = "0x50FA00", VA = "0x180511400", Slot = "12")]
	public virtual bool GECNAGGEDCC(Transform MKDDPCAJMGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int NJPJADPKPIJ(OMKDNPMGFDI AFHBDAOJPEH);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract int NJMGIPCLIEK(OMKDNPMGFDI AFHBDAOJPEH);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract void MBGEPHLGFAL(OMKDNPMGFDI AFHBDAOJPEH, AEBIJCECNOB JOKKOOPDHJP, int BKOANJHDJGE = -1);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	protected FCMDDHAABON()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x30D93F0", Offset = "0x30D79F0", VA = "0x1830D93F0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum BEENIBAKMHA
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FFBJBKEBGNA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PICEILDHOKJ : IEnumerable<OOPCGEBFGMH>, IEnumerable, IEnumerator<OOPCGEBFGMH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private OOPCGEBFGMH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private OOPCGEBFGMH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x63CDC0", Offset = "0x63B3C0", VA = "0x18063CDC0")]
		[DebuggerHidden]
		public PICEILDHOKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x30D9230", Offset = "0x30D7830", VA = "0x1830D9230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x30D93A0", Offset = "0x30D79A0", VA = "0x1830D93A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x30D9310", Offset = "0x30D7910", VA = "0x1830D9310", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OOPCGEBFGMH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x30D9310", Offset = "0x30D7910", VA = "0x1830D9310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const int BDPPNPEEJHI = 3;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static OOPCGEBFGMH[][] EELBDLBBIDO;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static OJNCGOAPFON EJCBMLFFPNB;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public static ShapeRendererConfig OKLAILKDBMB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static ComputeShader MBDBFIHHFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x30D22C0", Offset = "0x30D08C0", VA = "0x1830D22C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static SkinnedShapeRenderer NBDOJFKMHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x30D2760", Offset = "0x30D0D60", VA = "0x1830D2760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x30D30D0", Offset = "0x30D16D0", VA = "0x1830D30D0")]
	public static Mesh OPIBGGCFFLP(BEENIBAKMHA GFHAIMAJGGB, int AFHBDAOJPEH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x30D30C0", Offset = "0x30D16C0", VA = "0x1830D30C0")]
	public static int OIDEBBLHLDF(BEENIBAKMHA GFHAIMAJGGB, int AFHBDAOJPEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x30D27D0", Offset = "0x30D0DD0", VA = "0x1830D27D0")]
	public static OJNCGOAPFON HBAAKBKLPEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x30D3060", Offset = "0x30D1660", VA = "0x1830D3060")]
	[IteratorStateMachine(typeof(PICEILDHOKJ))]
	private static IEnumerable<OOPCGEBFGMH> ODBBCAAEEME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x30D2B40", Offset = "0x30D1140", VA = "0x1830D2B40")]
	public static OOPCGEBFGMH KAPEGJDAEOE(BEENIBAKMHA GFHAIMAJGGB, int AFHBDAOJPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x30D2E80", Offset = "0x30D1480", VA = "0x1830D2E80")]
	public static bool KBGPFOJONIH(this BEENIBAKMHA GFHAIMAJGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x30D2EA0", Offset = "0x30D14A0", VA = "0x1830D2EA0")]
	public static void MALOPKOBFJC(BEENIBAKMHA GFHAIMAJGGB, float3 OMLLKMGNIJP, out JCCGBBMCPEI LCGGJIOBBEE, out float3 JKOFJEKANLI, out float GKJAMAIFCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x30D2330", Offset = "0x30D0930", VA = "0x1830D2330")]
	public static void ANFPLOGKFCI(Vector3 OMLLKMGNIJP, BEENIBAKMHA GFHAIMAJGGB, out Vector3 JKOFJEKANLI, out float GKJAMAIFCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x30D2750", Offset = "0x30D0D50", VA = "0x1830D2750")]
	[NNMDMIMABNG(GBGLFHCKFBK.ExitingPlayMode, 0)]
	private static void EAFAJKBDGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x30D2920", Offset = "0x30D0F20", VA = "0x1830D2920")]
	[NNMDMIMABNG(GBGLFHCKFBK.ExitingPlayMode, 0)]
	private static void ILAEFCIJDDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface APIOHFBLGNK
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool IEOKBPOHELO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material PAADPKFBPID();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material GLLGBHIHKID();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material FNBPGFJGLKG();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int INOFBKLHNJC(PDGBCPKMCJH JDHEKFOIDMD);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MJOMHNMEIHN(JAKIGOFOMGA KLCHBELPJFK);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MAOGDFNBILH(GameObject KFIBIDDJFNE);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHPEBBFLPNP(GameObject KFIBIDDJFNE, bool LLGJNKNFBLB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LNMNJMONLLI : IIFIFAKPFEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static APIOHFBLGNK JCLIEJMELJL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x30D71B0", Offset = "0x30D57B0", VA = "0x1830D71B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x30D7A10", Offset = "0x30D6010", VA = "0x1830D7A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x30D7BB0", Offset = "0x30D61B0", VA = "0x1830D7BB0")]
	public LNMNJMONLLI(APIOHFBLGNK CIBLIDEKMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x30D77A0", Offset = "0x30D5DA0", VA = "0x1830D77A0", Slot = "4")]
	public FHLEDGCFLMO ICFOKFNALKO(HAFMKCFBOAJ PDGOOLFMMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x30D7150", Offset = "0x30D5750", VA = "0x1830D7150", Slot = "5")]
	public void AEOBDDMHOME(FHLEDGCFLMO MKDDPCAJMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30D7A60", Offset = "0x30D6060", VA = "0x1830D7A60", Slot = "6")]
	public void NCCOHJJBLKN(FHLEDGCFLMO MKDDPCAJMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x30D71F0", Offset = "0x30D57F0", VA = "0x1830D71F0", Slot = "15")]
	public IEnumerable<Renderer> EAEGKECHDCF(FHLEDGCFLMO MKDDPCAJMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x30D76D0", Offset = "0x30D5CD0", VA = "0x1830D76D0", Slot = "7")]
	public BBHGADPOGBG GKPGMEJPFNN(FHLEDGCFLMO MKDDPCAJMGN, GKGMIKJIFDH PDGOOLFMMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30D7AA0", Offset = "0x30D60A0", VA = "0x1830D7AA0", Slot = "8")]
	public BBHGADPOGBG ONAFMDCCMPD(FHLEDGCFLMO MKDDPCAJMGN, PGALNEOHLBE PDGOOLFMMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x30D78A0", Offset = "0x30D5EA0", VA = "0x1830D78A0", Slot = "9")]
	public void KNIFANAPBAH(BBHGADPOGBG NLPILOFOODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x30D7850", Offset = "0x30D5E50", VA = "0x1830D7850", Slot = "10")]
	public void KNAKEMJEAIM(BBHGADPOGBG NLPILOFOODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x30D7950", Offset = "0x30D5F50", VA = "0x1830D7950", Slot = "11")]
	public ILKNGCNPDEP LLIGDHLLPJF(BNFDJOGAPCF PDGOOLFMMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x30D7B70", Offset = "0x30D6170", VA = "0x1830D7B70", Slot = "12")]
	public void PGAKNNLEFCH(ILKNGCNPDEP OMBABEJEJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x30D7290", Offset = "0x30D5890", VA = "0x1830D7290", Slot = "13")]
	public void EOOBCJNJAFP(ILKNGCNPDEP OMBABEJEJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x30D72D0", Offset = "0x30D58D0", VA = "0x1830D72D0", Slot = "14")]
	public EIDDMAEKOAL FHEEOKAIPKG(Transform HFPAFPDOEGF, IEnumerable<BBHGADPOGBG> CFEHLIBCLPI, int KAHLNNKAGIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HBMELOMDCNK : ILKNGCNPDEP, OEIIAFIJODH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GKCBKMJLGIG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HBMELOMDCNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x63CDC0", Offset = "0x63B3C0", VA = "0x18063CDC0")]
		[DebuggerHidden]
		public GKCBKMJLGIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x30D3C90", Offset = "0x30D2290", VA = "0x1830D3C90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x30D39B0", Offset = "0x30D1FB0", VA = "0x1830D39B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x30D3D30", Offset = "0x30D2330", VA = "0x1830D3D30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x30D3C40", Offset = "0x30D2240", VA = "0x1830D3C40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x30D3BA0", Offset = "0x30D21A0", VA = "0x1830D3BA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x30D3BA0", Offset = "0x30D21A0", VA = "0x1830D3BA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private BNFDJOGAPCF DDHDDMDCGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private FOGFAKBLPAH KODAGLLGMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private List<IBJKMPGKDHK> KIOBIGIDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private List<IBJKMPGKDHK> CMJPMCMMLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private GameObject FAOEDOELCFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	internal override HBMELOMDCNK NCOCONKLOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x531600", Offset = "0x52FC00", VA = "0x180531600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x30D3D70", Offset = "0x30D2370", VA = "0x1830D3D70")]
	public static HBMELOMDCNK GBIMAFCBPIM(BNFDJOGAPCF PDGOOLFMMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x30D4DB0", Offset = "0x30D33B0", VA = "0x1830D4DB0")]
	private HBMELOMDCNK(BNFDJOGAPCF PDGOOLFMMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x30D3E30", Offset = "0x30D2430", VA = "0x1830D3E30")]
	public void HGJFGLHEDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x30D4D40", Offset = "0x30D3340", VA = "0x1830D4D40")]
	[IteratorStateMachine(typeof(GKCBKMJLGIG))]
	public IEnumerable<Renderer> OGJLALMAEAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x30D4420", Offset = "0x30D2A20", VA = "0x1830D4420", Slot = "5")]
	public void KAOGIJEFIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x30D4D10", Offset = "0x30D3310", VA = "0x1830D4D10")]
	private void OFAEBCBGNIK(Vector3 NDLIIACHOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x30D4250", Offset = "0x30D2850", VA = "0x1830D4250")]
	public void HLFBHDKMFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IBJKMPGKDHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct LCJCDEMOENF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AEBIJCECNOB PJDEMMEJCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Transform FABMCMHHHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int BJCHLBBEPMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BDFEKLOHANO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public IBJKMPGKDHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public OMKDNPMGFDI lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public List<LCJCDEMOENF> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public BDFEKLOHANO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EHBNHIHHMKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public EIDDMAEKOAL combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public BDFEKLOHANO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public EHBNHIHHMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x30D1A00", Offset = "0x30D0000", VA = "0x1830D1A00")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x30D1A70", Offset = "0x30D0070", VA = "0x1830D1A70")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x30D1AB0", Offset = "0x30D00B0", VA = "0x1830D1AB0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int[] DIBBNEGDDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private OECKKBCACPH AMIIOKKPOCD;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static Matrix4x4 GCAMFNEJHBM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Mesh AMKKFHNOPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B0", Offset = "0x56AAB0", VA = "0x18056C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int INANKGBIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x56D520", Offset = "0x56BB20", VA = "0x18056D520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x56D480", Offset = "0x56BA80", VA = "0x18056D480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x30D4E30", Offset = "0x30D3430", VA = "0x1830D4E30")]
	public void ALOCPBODGEH(List<Transform> LOLGDIMLFOD, Matrix4x4[] NMDMBHEEKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x30D51B0", Offset = "0x30D37B0", VA = "0x1830D51B0")]
	public static List<IBJKMPGKDHK> NIBKLGLBMIL(List<MAEOODFJFNA> IGFDMKJELPF, OMKDNPMGFDI AFHBDAOJPEH, Bounds JKLMPHADJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x30D5740", Offset = "0x30D3D40", VA = "0x1830D5740")]
	private JobHandle OGHAPFGABDG(EIDDMAEKOAL FGEOCEOFHNH, int PHMPHLEJDPC, int EDOEPBPGJNJ, OMKDNPMGFDI AFHBDAOJPEH, List<LCJCDEMOENF> DKKBELJPMBG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x30D5030", Offset = "0x30D3630", VA = "0x1830D5030")]
	private void BLGKIIAHBAM(List<LCJCDEMOENF> DKKBELJPMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x30D5C00", Offset = "0x30D4200", VA = "0x1830D5C00")]
	private IBJKMPGKDHK(List<LCJCDEMOENF> DKKBELJPMBG, int PHMPHLEJDPC, int EDOEPBPGJNJ, OMKDNPMGFDI AFHBDAOJPEH, Bounds JKLMPHADJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x30D5130", Offset = "0x30D3730", VA = "0x1830D5130", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private MaterialPropertyBlock JMPIAFFOGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private IBJKMPGKDHK NLKJHCLIEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private List<Transform> FLJLGKPMAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private RenderTexture NNJDOMOGBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private ComputeBuffer GKPHLGIDMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private ComputeShader CJOOKCDGFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Matrix4x4[] DPLPLOMPFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int KCHLPHDFCDF;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MeshRenderer LKCCPAODNHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x56B740", Offset = "0x569D40", VA = "0x18056B740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int PMNDIGIFGGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x30D9F90", Offset = "0x30D8590", VA = "0x1830D9F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x30D9800", Offset = "0x30D7E00", VA = "0x1830D9800")]
		public static List<SkinnedShapeRenderer> Create(GameObject MKDDPCAJMGN, List<IBJKMPGKDHK> KMKBPAMHILJ, List<Transform> FLJLGKPMAJK, Material HJLAFDEKKEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x30D9A10", Offset = "0x30D8010", VA = "0x1830D9A10")]
		public void Init(IBJKMPGKDHK NLKJHCLIEAL, List<Transform> FLJLGKPMAJK, Material HJLAFDEKKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x30D9F00", Offset = "0x30D8500", VA = "0x1830D9F00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x30D9E70", Offset = "0x30D8470", VA = "0x1830D9E70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x30D9E30", Offset = "0x30D8430", VA = "0x1830D9E30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x30D9770", Offset = "0x30D7D70", VA = "0x1830D9770")]
		private void ANNIGJFHCOG(ScriptableRenderContext NBOHPDEHCDB, Camera[] NPDMDLMMFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x30D9420", Offset = "0x30D7A20", VA = "0x1830D9420")]
		private void ALOCPBODGEH(CommandBuffer PHMCBJNJABG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x50D600", Offset = "0x50BC00", VA = "0x18050D600")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ELLJCHCKLPK
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static byte[] HCFMLFPGGCP;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static int NJDNHGIINNA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static int NHIKDHEJBAF;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static BigInteger NKHCHBBJBBN;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ELLJCHCKLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x30D1C40", Offset = "0x30D0240", VA = "0x1830D1C40")]
	private static string FLCHPOEFEII(byte[] BFBDMMHDNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x30D1D40", Offset = "0x30D0340", VA = "0x1830D1D40")]
	public static string GHPGBPLJMGG(byte[] FBEAOBEALBD, bool NJHPJLGMMPP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
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
