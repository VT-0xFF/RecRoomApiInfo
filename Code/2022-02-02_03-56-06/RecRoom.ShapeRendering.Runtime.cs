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
public enum ONGODEEPDHA
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
public enum OMHELFKHDOH
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
public enum NDNBLFNIDCM
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
public enum PJCNELICFJK
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
public enum AGPICEFMMIG
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
public class LIIHENPGPIO : ABNEAMNCIKF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private const byte BHCJACEDLAP = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private byte PBJNKCCKPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly List<SkinnedShapeRenderer>[] MAFMOMONHBC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AAKCKADHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4E3CD0", Offset = "0x4E2CD0", VA = "0x1804E3CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x589E10", Offset = "0x588E10", VA = "0x180589E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MEIFNFDJFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4E3CC0", Offset = "0x4E2CC0", VA = "0x1804E3CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF80", Offset = "0x5E9F80", VA = "0x1805EAF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JOAAEHHCOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xF3E560", Offset = "0xF3D560", VA = "0x180F3E560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x121E050", Offset = "0x121D050", VA = "0x18121E050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float ABBKCCBLKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE0EE80", Offset = "0xE0DE80", VA = "0x180E0EE80", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE0EE90", Offset = "0xE0DE90", VA = "0x180E0EE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> CEHJIHDKKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x45FDBB0", Offset = "0x45FCBB0", VA = "0x1845FDBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject FEOJFLNDPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x50BA30", Offset = "0x50AA30", VA = "0x18050BA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C85E0", Offset = "0x5C75E0", VA = "0x1805C85E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte IMMHAKBLMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x45FDB60", Offset = "0x45FCB60", VA = "0x1845FDB60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x45FDC10", Offset = "0x45FCC10", VA = "0x1845FDC10")]
	public LIIHENPGPIO(List<NEILJAKOGDA> EFHHNPJOPAE, List<NEILJAKOGDA> OILOHOAOGPM, List<Transform> LOHAIJLICPP, Material FLPGPBOBBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x45FDA50", Offset = "0x45FCA50", VA = "0x1845FDA50")]
	private int GBLGGAHCMIJ(List<NEILJAKOGDA> BCGFKONGLOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x45FD8F0", Offset = "0x45FC8F0", VA = "0x1845FD8F0")]
	private void FJIFPCFPHPP(int DJMKDCJNIHK, bool CAFPPADBBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x45FD730", Offset = "0x45FC730", VA = "0x1845FD730")]
	public void BONHNEMKEJM(Vector3 FOBCCPEDNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x45FD820", Offset = "0x45FC820", VA = "0x1845FD820", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x45FD8B0", Offset = "0x45FC8B0", VA = "0x1845FD8B0")]
	public void ELKHAICLLEJ(Transform CKMNFIDCEID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LDBMBMNMLOA : LLKOPFDHMDA, JPNAPLMGKPJ, LCBKBEDDLMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NCGMKINDDOB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LDBMBMNMLOA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xBF0DD0", Offset = "0xBEFDD0", VA = "0x180BF0DD0")]
		[DebuggerHidden]
		public NCGMKINDDOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x45FFA70", Offset = "0x45FEA70", VA = "0x1845FFA70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x45FF5C0", Offset = "0x45FE5C0", VA = "0x1845FF5C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x45FFBF0", Offset = "0x45FEBF0", VA = "0x1845FFBF0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x45FFC30", Offset = "0x45FEC30", VA = "0x1845FFC30")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x45FFC80", Offset = "0x45FEC80", VA = "0x1845FFC80")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x45FFA20", Offset = "0x45FEA20", VA = "0x1845FFA20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x45FF980", Offset = "0x45FE980", VA = "0x1845FF980", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x45FF980", Offset = "0x45FE980", VA = "0x1845FF980", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private DCPENBONBGH HFHMBJBFMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private List<ELNBILJEKHP> GEBDPEPDDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<ClusterMeshRenderer> HNMBCHOLMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private BatchedMeshRenderer OHDBGHIJLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool HBBHPBPIOJM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<JPDLHFDHKHA> CAMAINABHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int IOMPCKPMKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x45FCE40", Offset = "0x45FBE40", VA = "0x1845FCE40", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform HHPGGPMJFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x45FD110", Offset = "0x45FC110", VA = "0x1845FD110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal override LDBMBMNMLOA DOMGJLMGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x578B30", Offset = "0x577B30", VA = "0x180578B30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x45FD6A0", Offset = "0x45FC6A0", VA = "0x1845FD6A0")]
	public LDBMBMNMLOA(DCPENBONBGH MGHJEBPADDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x45FC7F0", Offset = "0x45FB7F0", VA = "0x1845FC7F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x45FCE80", Offset = "0x45FBE80", VA = "0x1845FCE80")]
	public void IDCEJGBHLFK(ELNBILJEKHP LKIPFNEJIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x45FD640", Offset = "0x45FC640", VA = "0x1845FD640")]
	public void PMCHHOBKDIO(ELNBILJEKHP LKIPFNEJIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x45FC820", Offset = "0x45FB820", VA = "0x1845FC820", Slot = "5")]
	public void FOOFKOMMJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x45FC760", Offset = "0x45FB760", VA = "0x1845FC760")]
	public void ANEHKFACJGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x45FCF50", Offset = "0x45FBF50", VA = "0x1845FCF50")]
	private void IKOLHKNOBCF(ELNBILJEKHP LKIPFNEJIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x45FD160", Offset = "0x45FC160", VA = "0x1845FD160")]
	public void OKIDOPDKPGJ(bool APPKBHKKMJH, bool HAJFGJAEBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x45FCD30", Offset = "0x45FBD30", VA = "0x1845FCD30")]
	protected void GPKMBHOFLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x45FD0A0", Offset = "0x45FC0A0", VA = "0x1845FD0A0")]
	[IteratorStateMachine(typeof(NCGMKINDDOB))]
	public IEnumerable<Renderer> JMJFNMEBBCE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class GMEAHBGGALM : ELNBILJEKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private DFOHGLDABOL GJLLOKJFBJE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x45FAC70", Offset = "0x45F9C70", VA = "0x1845FAC70")]
	private NativeList<ADNGGPHHPDC> AIAFGODKCOE()
	{
		return default(NativeList<ADNGGPHHPDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x45FB490", Offset = "0x45FA490", VA = "0x1845FB490")]
	public GMEAHBGGALM(LDBMBMNMLOA HKCIGEFNNOB, DFOHGLDABOL MGHJEBPADDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x45FAD40", Offset = "0x45F9D40", VA = "0x1845FAD40", Slot = "14")]
	public override int GBLGGAHCMIJ(BPICDCNJEKC DMIKFDNHDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x45FAA50", Offset = "0x45F9A50", VA = "0x1845FAA50", Slot = "15")]
	public override int ABMHCEABGPG(BPICDCNJEKC DMIKFDNHDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x45FAF60", Offset = "0x45F9F60", VA = "0x1845FAF60", Slot = "16")]
	public override void IBNBJAJDANB(BPICDCNJEKC DMIKFDNHDCC, BEEPDOCNEHB PGFNFBDGMHO, int EIOLMJCOIAI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class LLKOPFDHMDA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	internal virtual LDBMBMNMLOA DOMGJLMGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x510E80", Offset = "0x50FE80", VA = "0x180510E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	protected LLKOPFDHMDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum IJIPPFLICAG
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
public interface DCPENBONBGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform HFMGFINKPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IJIPPFLICAG NFLOJCKPGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class OLOOJKMCMDK
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal virtual ELNBILJEKHP KDIIODMIKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x510E80", Offset = "0x50FE80", VA = "0x180510E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	protected OLOOJKMCMDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AEEGLDJFPEF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform HFMGFINKPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float GGONMLGENAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Vector3 BBKMJBAMGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	ONGODEEPDHA GIMHBAKFDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OMHELFKHDOH GGIKMAOJJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IENLBFIPEIG : AEEGLDJFPEF
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	ENCHPAILGIJ BMJCELNEEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PBKIIDMLCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DFOHGLDABOL : AEEGLDJFPEF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LGMJBFCIBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool IFFMMCCOHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float JCNJOMICDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int GPBLHGMKFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MPKJGFCPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<ADNGGPHHPDC> AIAFGODKCOE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BLEBHKABENK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GABPGKDIBBL(OLOOJKMCMDK LKIPFNEJIEK, PJCNELICFJK PMNAMDCKPLP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GABPGKDIBBL(LLKOPFDHMDA HKCIGEFNNOB, PJCNELICFJK PMNAMDCKPLP);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MHGCAMNAMLA(LLKOPFDHMDA HKCIGEFNNOB);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMKKPHFKKKP(LLKOPFDHMDA HKCIGEFNNOB, AGPICEFMMIG ELMEHHJGGCC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLANNGHAMGG(LLKOPFDHMDA HKCIGEFNNOB, Vector3 GBONLBBAHNJ, Vector3 GMJNKAAEFNK, Vector3 KHJDLDACNHH, float NFOBDEBCANF, float BPPDAOICLKI, IReadOnlyList<Camera> CPLHGEDENHC, NDNBLFNIDCM LLEMLPOOCEI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLANNGHAMGG(DJOGIGFGFPK HPAFLCIPOFB, object JBOFMHOIANL, object LNKLCPMKFJB, float PIIKIMOJGBN, Color? NIEKFCKPODI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EGBDPHMKBOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLKOPFDHMDA LJOEEFACMDO(DCPENBONBGH MGHJEBPADDE);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPGPOIOKKK(LLKOPFDHMDA HKCIGEFNNOB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IMIEMNPAPHP(LLKOPFDHMDA HKCIGEFNNOB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OLOOJKMCMDK NLMPNGEBFFD(LLKOPFDHMDA HKCIGEFNNOB, IENLBFIPEIG MGHJEBPADDE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OLOOJKMCMDK ADBCMALLDFJ(LLKOPFDHMDA HKCIGEFNNOB, DFOHGLDABOL MGHJEBPADDE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EKJJLIPKBAL(OLOOJKMCMDK LKIPFNEJIEK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NIMCCMBBNIA(OLOOJKMCMDK LKIPFNEJIEK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DJOGIGFGFPK EAMGAGLLAPF(DKGJNNFLGOA MGHJEBPADDE);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JABNHKODJOP(DJOGIGFGFPK HPAFLCIPOFB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LNJJGFDMOAL(DJOGIGFGFPK HPAFLCIPOFB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EDMDJOLCDFN LJBJAFFGEOO(Transform BNONFMMJAIJ, IEnumerable<OLOOJKMCMDK> GEBDPEPDDOB, int OJIBHAKAOEN);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> GFKDJLFFJMH(LLKOPFDHMDA HKCIGEFNNOB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class DJOGIGFGFPK
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal virtual HCFJPCCMGKJ OEIFPFKGGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x510E80", Offset = "0x50FE80", VA = "0x180510E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	protected DJOGIGFGFPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DKGJNNFLGOA
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int BAMEOHNGILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Transform HPHKAIEBECD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EABNAHDEMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLKOPFDHMDA GetBone(int FLELPDMIDPI);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int FLELPDMIDPI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class NABIJHHMKCI : ELNBILJEKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public IENLBFIPEIG HEBJKPFFCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int[] AOALFFCACBD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public override JHCPHBENKBF ONHHHNJFNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x45FE990", Offset = "0x45FD990", VA = "0x1845FE990", Slot = "13")]
		get
		{
			return default(JHCPHBENKBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Vector3 PGMHECBMPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x45FF3E0", Offset = "0x45FE3E0", VA = "0x1845FF3E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x45FB490", Offset = "0x45FA490", VA = "0x1845FB490")]
	public NABIJHHMKCI(LDBMBMNMLOA HKCIGEFNNOB, IENLBFIPEIG MGHJEBPADDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x45FE3F0", Offset = "0x45FD3F0", VA = "0x1845FE3F0", Slot = "12")]
	public override bool FKKIEFHMCBJ(Transform HKCIGEFNNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x45FE8F0", Offset = "0x45FD8F0", VA = "0x1845FE8F0", Slot = "14")]
	public override int GBLGGAHCMIJ(BPICDCNJEKC DMIKFDNHDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x45FE110", Offset = "0x45FD110", VA = "0x1845FE110", Slot = "15")]
	public override int ABMHCEABGPG(BPICDCNJEKC DMIKFDNHDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x45FE1B0", Offset = "0x45FD1B0", VA = "0x1845FE1B0")]
	private int ANJFPDKLKBN(BPICDCNJEKC DMIKFDNHDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x45FED30", Offset = "0x45FDD30", VA = "0x1845FED30", Slot = "16")]
	public override void IBNBJAJDANB(BPICDCNJEKC DMIKFDNHDCC, BEEPDOCNEHB PGFNFBDGMHO, int EIOLMJCOIAI = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GDOJPLHLNKD
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAHPPNBGGLK(AGPICEFMMIG ELMEHHJGGCC, Renderer FGBGCNEKCDN, int KKODNJCLHBC);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DONCKDHNNPA(Renderer FGBGCNEKCDN, NDNBLFNIDCM LLEMLPOOCEI, Vector3 GBONLBBAHNJ, Vector3 GMJNKAAEFNK, Vector3 KHJDLDACNHH, float NFOBDEBCANF, float BPPDAOICLKI, float PIIKIMOJGBN = -1f, [Optional] Color? NIEKFCKPODI, [Optional] IReadOnlyList<Camera> INGGINNJKDG);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DONCKDHNNPA(Renderer FGBGCNEKCDN, object JBOFMHOIANL, object LNKLCPMKFJB, bool DNEHCNCIIMI, float PIIKIMOJGBN, Color? NIEKFCKPODI, bool JEGPHCMIIAP = false);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFGKHFOCBIO(Renderer FGBGCNEKCDN, int KKODNJCLHBC);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OEMICKKAJOJ();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOHIPEIGDGP(int BCCPBEMLJMJ, PJCNELICFJK ELMEHHJGGCC, Renderer FGBGCNEKCDN, int KKODNJCLHBC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AJNLDFMICAC : BLEBHKABENK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GDOJPLHLNKD PFEHGFJMIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private MeshRenderer MDDDMINMICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private KJOFHBKBGFL HOFHEKHJLDO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5C53C0", Offset = "0x5C43C0", VA = "0x1805C53C0")]
	public AJNLDFMICAC(GDOJPLHLNKD EJPMPKMGOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x45F7CA0", Offset = "0x45F6CA0", VA = "0x1845F7CA0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x45F7D40", Offset = "0x45F6D40", VA = "0x1845F7D40", Slot = "4")]
	public void GABPGKDIBBL(OLOOJKMCMDK LKIPFNEJIEK, PJCNELICFJK PMNAMDCKPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x45F7FB0", Offset = "0x45F6FB0", VA = "0x1845F7FB0", Slot = "5")]
	public void GABPGKDIBBL(LLKOPFDHMDA HKCIGEFNNOB, PJCNELICFJK PMNAMDCKPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x45F8320", Offset = "0x45F7320", VA = "0x1845F8320", Slot = "6")]
	public void MHGCAMNAMLA(LLKOPFDHMDA HKCIGEFNNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x45F8180", Offset = "0x45F7180", VA = "0x1845F8180", Slot = "7")]
	public void HMKKPHFKKKP(LLKOPFDHMDA HKCIGEFNNOB, AGPICEFMMIG ELMEHHJGGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x45F7690", Offset = "0x45F6690", VA = "0x1845F7690", Slot = "8")]
	public void DLANNGHAMGG(LLKOPFDHMDA HKCIGEFNNOB, Vector3 GBONLBBAHNJ, Vector3 GMJNKAAEFNK, Vector3 KHJDLDACNHH, float NFOBDEBCANF, float BPPDAOICLKI, IReadOnlyList<Camera> CPLHGEDENHC, NDNBLFNIDCM LLEMLPOOCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x45F79C0", Offset = "0x45F69C0", VA = "0x1845F79C0", Slot = "9")]
	public void DLANNGHAMGG(DJOGIGFGFPK HPAFLCIPOFB, object JBOFMHOIANL, object LNKLCPMKFJB, float PIIKIMOJGBN, Color? NIEKFCKPODI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class ELNBILJEKHP : OLOOJKMCMDK, BGPDOMEBKNI, JPDLHFDHKHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected Bounds GHCDFECBOOI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public LDBMBMNMLOA FEOJFLNDPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4E3490", Offset = "0x4E2490", VA = "0x1804E3490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal override ELNBILJEKHP KDIIODMIKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x578B30", Offset = "0x577B30", VA = "0x180578B30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Bounds AOGADJAEBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xDE34F0", Offset = "0xDE24F0", VA = "0x180DE34F0", Slot = "5")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual JHCPHBENKBF ONHHHNJFNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x45FA9C0", Offset = "0x45F99C0", VA = "0x1845FA9C0", Slot = "13")]
		get
		{
			return default(JHCPHBENKBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E3EC0", Offset = "0x4E2EC0", VA = "0x1804E3EC0", Slot = "12")]
	public virtual bool FKKIEFHMCBJ(Transform HKCIGEFNNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int GBLGGAHCMIJ(BPICDCNJEKC DMIKFDNHDCC);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract int ABMHCEABGPG(BPICDCNJEKC DMIKFDNHDCC);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract void IBNBJAJDANB(BPICDCNJEKC DMIKFDNHDCC, BEEPDOCNEHB PGFNFBDGMHO, int EIOLMJCOIAI = -1);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	protected ELNBILJEKHP()
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
		[Cpp2IlInjected.Address(RVA = "0x4600E50", Offset = "0x45FFE50", VA = "0x184600E50")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum ENCHPAILGIJ
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
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CJINDPHMEEF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KJBDHMMBGFM : IEnumerable<JGOIEBFMDAD>, IEnumerable, IEnumerator<JGOIEBFMDAD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private JGOIEBFMDAD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private JGOIEBFMDAD System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBF0DD0", Offset = "0xBEFDD0", VA = "0x180BF0DD0")]
		[DebuggerHidden]
		public KJBDHMMBGFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x45FC5A0", Offset = "0x45FB5A0", VA = "0x1845FC5A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x45FC710", Offset = "0x45FB710", VA = "0x1845FC710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x45FC680", Offset = "0x45FB680", VA = "0x1845FC680", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JGOIEBFMDAD> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x45FC680", Offset = "0x45FB680", VA = "0x1845FC680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const int CNFNPAHAPGL = 3;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static JGOIEBFMDAD[][] OIJKNPPNBPL;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static MCKCJCMDMFE CCBGKEFGHMJ;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public static ShapeRendererConfig IHFEOKMGHJB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static ComputeShader BCFNAKJCKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x45F90F0", Offset = "0x45F80F0", VA = "0x1845F90F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static SkinnedShapeRenderer OLMKONOGJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x45F8C00", Offset = "0x45F7C00", VA = "0x1845F8C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x45F9170", Offset = "0x45F8170", VA = "0x1845F9170")]
	public static Mesh MOPMNLFMHHA(ENCHPAILGIJ MLBBIGECFDM, int DMIKFDNHDCC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x45F9160", Offset = "0x45F8160", VA = "0x1845F9160")]
	public static int LNCBHNCHPIM(ENCHPAILGIJ MLBBIGECFDM, int DMIKFDNHDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x45F9230", Offset = "0x45F8230", VA = "0x1845F9230")]
	public static MCKCJCMDMFE PGOJAFBLHFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x45F9090", Offset = "0x45F8090", VA = "0x1845F9090")]
	[IteratorStateMachine(typeof(KJBDHMMBGFM))]
	private static IEnumerable<JGOIEBFMDAD> KCMCFPJKGOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x45F86A0", Offset = "0x45F76A0", VA = "0x1845F86A0")]
	public static JGOIEBFMDAD FABMFIHMLGE(ENCHPAILGIJ MLBBIGECFDM, int DMIKFDNHDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x45F8680", Offset = "0x45F7680", VA = "0x1845F8680")]
	public static bool EJDOBFKEOMF(this ENCHPAILGIJ MLBBIGECFDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x45F84C0", Offset = "0x45F74C0", VA = "0x1845F84C0")]
	public static void DJDMCKCICMP(ENCHPAILGIJ MLBBIGECFDM, float3 ELEDAPLMKGP, out GJICMGMICIB EJAMPDMFONM, out float3 IMJOPKEFHEL, out float MFGNJFOKFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x45F8C70", Offset = "0x45F7C70", VA = "0x1845F8C70")]
	public static void JDBGEAHIPPE(Vector3 ELEDAPLMKGP, ENCHPAILGIJ MLBBIGECFDM, out Vector3 IMJOPKEFHEL, out float MFGNJFOKFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x45F84B0", Offset = "0x45F74B0", VA = "0x1845F84B0")]
	[NECNNIDGOFF(IELBKHEMIMD.ExitingPlayMode, 0)]
	private static void BMAMPBAGEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x45F89E0", Offset = "0x45F79E0", VA = "0x1845F89E0")]
	[NECNNIDGOFF(IELBKHEMIMD.ExitingPlayMode, 0)]
	private static void IJEFFPLNFGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HGNLPMLCCLI
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool IEABMOJJPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material JPEICNIJDFJ();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material NINCAJBHFEG();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material NDEGAOBKFAC();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GACLFMLIAEA(ONGODEEPDHA FDKJCJDAFMK);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DAHBLDJODLI(OMHELFKHDOH HLAPEJJPNAM);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KMAGOOOHKIF(GameObject HPPOIDNICFG);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GBPOGBDBBDD(GameObject HPPOIDNICFG, bool GJDGNKBEMHH);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EJGFOFHIBPG : EGBDPHMKBOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static HGNLPMLCCLI MPKBPANHCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x45FA690", Offset = "0x45F9690", VA = "0x1845FA690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x45FA0D0", Offset = "0x45F90D0", VA = "0x1845FA0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x45FA7F0", Offset = "0x45F97F0", VA = "0x1845FA7F0")]
	public EJGFOFHIBPG(HGNLPMLCCLI EJPMPKMGOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x45FA5A0", Offset = "0x45F95A0", VA = "0x1845FA5A0", Slot = "4")]
	public LLKOPFDHMDA LJOEEFACMDO(DCPENBONBGH MGHJEBPADDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x45F9E80", Offset = "0x45F8E80", VA = "0x1845F9E80", Slot = "5")]
	public void CPPGPOIOKKK(LLKOPFDHMDA HKCIGEFNNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x45FA120", Offset = "0x45F9120", VA = "0x1845FA120", Slot = "6")]
	public void IMIEMNPAPHP(LLKOPFDHMDA HKCIGEFNNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x45FA030", Offset = "0x45F9030", VA = "0x1845FA030", Slot = "15")]
	public IEnumerable<Renderer> GFKDJLFFJMH(LLKOPFDHMDA HKCIGEFNNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x45FA720", Offset = "0x45F9720", VA = "0x1845FA720", Slot = "7")]
	public OLOOJKMCMDK NLMPNGEBFFD(LLKOPFDHMDA HKCIGEFNNOB, IENLBFIPEIG MGHJEBPADDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x45F9DB0", Offset = "0x45F8DB0", VA = "0x1845F9DB0", Slot = "8")]
	public OLOOJKMCMDK ADBCMALLDFJ(LLKOPFDHMDA HKCIGEFNNOB, DFOHGLDABOL MGHJEBPADDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x45F9FA0", Offset = "0x45F8FA0", VA = "0x1845F9FA0", Slot = "9")]
	public void EKJJLIPKBAL(OLOOJKMCMDK LKIPFNEJIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x45FA6D0", Offset = "0x45F96D0", VA = "0x1845FA6D0", Slot = "10")]
	public void NIMCCMBBNIA(OLOOJKMCMDK LKIPFNEJIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x45F9EE0", Offset = "0x45F8EE0", VA = "0x1845F9EE0", Slot = "11")]
	public DJOGIGFGFPK EAMGAGLLAPF(DKGJNNFLGOA MGHJEBPADDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x45FA160", Offset = "0x45F9160", VA = "0x1845FA160", Slot = "12")]
	public void JABNHKODJOP(DJOGIGFGFPK HPAFLCIPOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x45FA650", Offset = "0x45F9650", VA = "0x1845FA650", Slot = "13")]
	public void LNJJGFDMOAL(DJOGIGFGFPK HPAFLCIPOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x45FA1A0", Offset = "0x45F91A0", VA = "0x1845FA1A0", Slot = "14")]
	public EDMDJOLCDFN LJBJAFFGEOO(Transform BNONFMMJAIJ, IEnumerable<OLOOJKMCMDK> GEBDPEPDDOB, int OJIBHAKAOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HCFJPCCMGKJ : DJOGIGFGFPK, JPNAPLMGKPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CKJEAPJPMAB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public HCFJPCCMGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xBF0DD0", Offset = "0xBEFDD0", VA = "0x180BF0DD0")]
		[DebuggerHidden]
		public CKJEAPJPMAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x45F96E0", Offset = "0x45F86E0", VA = "0x1845F96E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x45F9400", Offset = "0x45F8400", VA = "0x1845F9400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x45F9780", Offset = "0x45F8780", VA = "0x1845F9780")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x45F9690", Offset = "0x45F8690", VA = "0x1845F9690", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x45F95F0", Offset = "0x45F85F0", VA = "0x1845F95F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x45F95F0", Offset = "0x45F85F0", VA = "0x1845F95F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private DKGJNNFLGOA PNNMOJCONMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private LIIHENPGPIO BEIAJFHBIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private List<NEILJAKOGDA> OBIDCOBBBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private List<NEILJAKOGDA> DOIBLNCPGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private GameObject OLNFFKCBLMG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	internal override HCFJPCCMGKJ OEIFPFKGGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x578B30", Offset = "0x577B30", VA = "0x180578B30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x45FB6B0", Offset = "0x45FA6B0", VA = "0x1845FB6B0")]
	public static HCFJPCCMGKJ ECFIFAPAONC(DKGJNNFLGOA MGHJEBPADDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x45FC520", Offset = "0x45FB520", VA = "0x1845FC520")]
	private HCFJPCCMGKJ(DKGJNNFLGOA MGHJEBPADDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x45FC060", Offset = "0x45FB060", VA = "0x1845FC060")]
	public void JAHIHIBCNCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x45FC480", Offset = "0x45FB480", VA = "0x1845FC480")]
	[IteratorStateMachine(typeof(CKJEAPJPMAB))]
	public IEnumerable<Renderer> JMJFNMEBBCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x45FB770", Offset = "0x45FA770", VA = "0x1845FB770", Slot = "5")]
	public void FOOFKOMMJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x45FC4F0", Offset = "0x45FB4F0", VA = "0x1845FC4F0")]
	private void NFNJEFPOOEP(Vector3 FOBCCPEDNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x45FB4E0", Offset = "0x45FA4E0", VA = "0x1845FB4E0")]
	public void ANEHKFACJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NEILJAKOGDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct IJNACHNKLCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public BEEPDOCNEHB MPIFBFJFLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Transform EKIPFIBLDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int BLKOLFMNDPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BCOKHMODNGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public NEILJAKOGDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public BPICDCNJEKC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public List<IJNACHNKLCJ> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public BCOKHMODNGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MKONNAGEEEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public EDMDJOLCDFN combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public BCOKHMODNGN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public MKONNAGEEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x45FDED0", Offset = "0x45FCED0", VA = "0x1845FDED0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x45FDF40", Offset = "0x45FCF40", VA = "0x1845FDF40")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x45FDF80", Offset = "0x45FCF80", VA = "0x1845FDF80")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private int[] EGCEDFAOCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private LMBBPJENBPG CNLBCHLPBGA;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static Matrix4x4 EFMHPJFCDOA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Mesh IMJHGMLANBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4E3490", Offset = "0x4E2490", VA = "0x1804E3490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int FMOFOOPGPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x56ABE0", Offset = "0x569BE0", VA = "0x18056ABE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E26E0", Offset = "0x5E16E0", VA = "0x1805E26E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x45FFD50", Offset = "0x45FED50", VA = "0x1845FFD50")]
	public void GPLAPAFNNLB(List<Transform> DOCCLDHDOMK, Matrix4x4[] FJBGIIIAGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x46003D0", Offset = "0x45FF3D0", VA = "0x1846003D0")]
	public static List<NEILJAKOGDA> OHLBCBNLJLB(List<LCBKBEDDLMK> FLJENCDBFDK, BPICDCNJEKC DMIKFDNHDCC, Bounds DFKEBPEGDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x45FFF50", Offset = "0x45FEF50", VA = "0x1845FFF50")]
	private JobHandle HOIIEINBNHC(EDMDJOLCDFN JNPJFNCACMJ, int MNDLKPKMNCL, int KKKOBONIANN, BPICDCNJEKC DMIKFDNHDCC, List<IJNACHNKLCJ> GKLJGFGGAHK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46002D0", Offset = "0x45FF2D0", VA = "0x1846002D0")]
	private void MOODDIIHEJC(List<IJNACHNKLCJ> GKLJGFGGAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4600AA0", Offset = "0x45FFAA0", VA = "0x184600AA0")]
	private NEILJAKOGDA(List<IJNACHNKLCJ> GKLJGFGGAHK, int MNDLKPKMNCL, int KKKOBONIANN, BPICDCNJEKC DMIKFDNHDCC, Bounds DFKEBPEGDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x45FFCD0", Offset = "0x45FECD0", VA = "0x1845FFCD0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private MaterialPropertyBlock IBDGMKEAFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private NEILJAKOGDA DLNIEOMAIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<Transform> LOHAIJLICPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private RenderTexture MADLGFEEFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private ComputeBuffer PPOGGMELOEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private ComputeShader MDFFKIHKGDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private Matrix4x4[] JKLOHILMAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int MHAMMPIEFPH;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MeshRenderer HCIODNPNLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4E34A0", Offset = "0x4E24A0", VA = "0x1804E34A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int BAMEOHNGILK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x46019F0", Offset = "0x46009F0", VA = "0x1846019F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4600E80", Offset = "0x45FFE80", VA = "0x184600E80")]
		public static List<SkinnedShapeRenderer> Create(GameObject HKCIGEFNNOB, List<NEILJAKOGDA> BCGFKONGLOI, List<Transform> LOHAIJLICPP, Material FLPGPBOBBBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x46013E0", Offset = "0x46003E0", VA = "0x1846013E0")]
		public void Init(NEILJAKOGDA DLNIEOMAIFB, List<Transform> LOHAIJLICPP, Material FLPGPBOBBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4601960", Offset = "0x4600960", VA = "0x184601960")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x46018D0", Offset = "0x46008D0", VA = "0x1846018D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4601890", Offset = "0x4600890", VA = "0x184601890")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4601800", Offset = "0x4600800", VA = "0x184601800")]
		private void OLLCMELNLEI(ScriptableRenderContext EEECBNNPKOA, Camera[] IPABFDBHCMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4601090", Offset = "0x4600090", VA = "0x184601090")]
		private void GPLAPAFNNLB(CommandBuffer OPIELJLDCFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xC75CE0", Offset = "0xC74CE0", VA = "0x180C75CE0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DFIKEAFJCGD
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static byte[] FPMGPNDCJGI;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static int HLAPLPHEDOF;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static int DIHDAAMIHIE;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static BigInteger CBFIPIFMBJA;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public DFIKEAFJCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x45F97C0", Offset = "0x45F87C0", VA = "0x1845F97C0")]
	private static string FCGBJJFHIPJ(byte[] DJHKGFLFIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x45F98C0", Offset = "0x45F88C0", VA = "0x1845F98C0")]
	public static string JDIAMALCPMN(byte[] ONAFAFJGCAI, bool NMLDFLAABOD)
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

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
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
