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
public enum CGEEBNGBAJK
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
public enum DLJJHNHDHEJ
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
public enum GEGIHACLJMG
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
public enum IPDAEDMFIEJ
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
public enum HLGENAAGICH
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
public class DLCFCPNFNDK : GKPEFKIFFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private const byte MNCBLDJFNBI = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private byte IOIAILACMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly List<SkinnedShapeRenderer>[] ACHCNPNAMHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KHPHAEMHJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5356C0", Offset = "0x5346C0", VA = "0x1805356C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x606EC0", Offset = "0x605EC0", VA = "0x180606EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LHEFANDLPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5356B0", Offset = "0x5346B0", VA = "0x1805356B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A0830", Offset = "0x69F830", VA = "0x1806A0830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float MBMKJOPAMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x631680", Offset = "0x630680", VA = "0x180631680", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x631B60", Offset = "0x630B60", VA = "0x180631B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BALJGLGEAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x631670", Offset = "0x630670", VA = "0x180631670", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x631B50", Offset = "0x630B50", VA = "0x180631B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> BAEIOMKLCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x495C850", Offset = "0x495B850", VA = "0x18495C850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject AALDJPJFFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5109E0", Offset = "0x50F9E0", VA = "0x1805109E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C9390", Offset = "0x5C8390", VA = "0x1805C9390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte NJIGMGIBNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x495C800", Offset = "0x495B800", VA = "0x18495C800", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x495CBF0", Offset = "0x495BBF0", VA = "0x18495CBF0")]
	public DLCFCPNFNDK(List<LBCMEAMJONK> KEAFHFFCHJJ, List<LBCMEAMJONK> OGCDALJMMAB, List<Transform> LCJBKPLLOIF, Material DOMIJDHKEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x495C940", Offset = "0x495B940", VA = "0x18495C940")]
	private int FBALPPEHPKM(List<LBCMEAMJONK> PDIEKPDEDKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x495CA90", Offset = "0x495BA90", VA = "0x18495CA90")]
	private void MGKMONFLCEI(int FHGJJIJHCCA, bool JEHHIBPFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x495C710", Offset = "0x495B710", VA = "0x18495C710")]
	public void AINDDNGMOPC(Vector3 KJBJMCEFLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x495C8B0", Offset = "0x495B8B0", VA = "0x18495C8B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x495CA50", Offset = "0x495BA50", VA = "0x18495CA50")]
	public void KOCLHDDDOEF(Transform NKEGLFNCOFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GJLHFNELHIL : CHBOCMCNFFF, HHBAGMIJCJM, KFPJFOOMOOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DLKHIHPKDPK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GJLHFNELHIL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CD0", Offset = "0x6F3CD0", VA = "0x1806F4CD0")]
		[DebuggerHidden]
		public DLKHIHPKDPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x495D360", Offset = "0x495C360", VA = "0x18495D360", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x495CEB0", Offset = "0x495BEB0", VA = "0x18495CEB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x495D4E0", Offset = "0x495C4E0", VA = "0x18495D4E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x495D520", Offset = "0x495C520", VA = "0x18495D520")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x495D570", Offset = "0x495C570", VA = "0x18495D570")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x495D310", Offset = "0x495C310", VA = "0x18495D310", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x495D270", Offset = "0x495C270", VA = "0x18495D270", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x495D270", Offset = "0x495C270", VA = "0x18495D270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private CKKJOJGNJMP PKAIGPLIEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private List<EJIFFFPKPOD> LPKGBDIGCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<ClusterMeshRenderer> NBPCLNBPNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private BatchedMeshRenderer BEPLAODBIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool OMHODFCOIJJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<GENINMMIIEN> CKJMCJNPLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int FBANDNJNFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x495F860", Offset = "0x495E860", VA = "0x18495F860", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform GLJECEFDLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x495F8A0", Offset = "0x495E8A0", VA = "0x18495F8A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal override GJLHFNELHIL KBPGNMPGIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D5CB0", Offset = "0x5D4CB0", VA = "0x1805D5CB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x495F9C0", Offset = "0x495E9C0", VA = "0x18495F9C0")]
	public GJLHFNELHIL(CKKJOJGNJMP LKMEKEIFEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x495F1E0", Offset = "0x495E1E0", VA = "0x18495F1E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x495F8F0", Offset = "0x495E8F0", VA = "0x18495F8F0")]
	public void ONGBLFOLDCH(EJIFFFPKPOD NNLKJIOIDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x495F7F0", Offset = "0x495E7F0", VA = "0x18495F7F0")]
	public void KOAAEEDJIKB(EJIFFFPKPOD NNLKJIOIDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x495EB80", Offset = "0x495DB80", VA = "0x18495EB80", Slot = "5")]
	public void CGOHFNMFBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x495F210", Offset = "0x495E210", VA = "0x18495F210")]
	public void EBPLJKLJNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x495F090", Offset = "0x495E090", VA = "0x18495F090")]
	private void DAACDHIMEKO(EJIFFFPKPOD NNLKJIOIDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x495F2A0", Offset = "0x495E2A0", VA = "0x18495F2A0")]
	public void EDJMACFINDD(bool OMFBKOCJFBL, bool PPFNJHDJPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x495EA70", Offset = "0x495DA70", VA = "0x18495EA70")]
	protected void APMDFHLILLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x495F780", Offset = "0x495E780", VA = "0x18495F780")]
	[IteratorStateMachine(typeof(DLKHIHPKDPK))]
	public IEnumerable<Renderer> IECBMHANFAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class HHPDOOBNJLM : EJIFFFPKPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private HMOHBAFPHMA MOLPFFDLEFN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4961480", Offset = "0x4960480", VA = "0x184961480")]
	private NativeList<BEODMMHCLIP> IDKJMFPFGKE()
	{
		return default(NativeList<BEODMMHCLIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4961550", Offset = "0x4960550", VA = "0x184961550")]
	public HHPDOOBNJLM(GJLHFNELHIL COCNNHFBEEP, HMOHBAFPHMA LKMEKEIFEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4961260", Offset = "0x4960260", VA = "0x184961260", Slot = "14")]
	public override int FBALPPEHPKM(NPKGMAFKBIH DANEEPACMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4961040", Offset = "0x4960040", VA = "0x184961040", Slot = "15")]
	public override int COMHDJNOGCD(NPKGMAFKBIH DANEEPACMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4960B10", Offset = "0x495FB10", VA = "0x184960B10", Slot = "16")]
	public override void AHGHKCKKHNH(NPKGMAFKBIH DANEEPACMAP, NIODFNAFOGH KPGGCKBEAFM, int APONGIMHPDN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class CHBOCMCNFFF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	internal virtual GJLHFNELHIL KBPGNMPGIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x51D640", Offset = "0x51C640", VA = "0x18051D640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	protected CHBOCMCNFFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GEAPCELMKCF
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
public interface CKKJOJGNJMP
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform JFFAJJPPHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GEAPCELMKCF FIANDMINIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class GCGGPGAOMMM
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal virtual EJIFFFPKPOD DBOAFLBNABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x51D640", Offset = "0x51C640", VA = "0x18051D640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	protected GCGGPGAOMMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NEJGALPBJHA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform JFFAJJPPHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float LAIMNIOAKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Vector3 DAJEGAKMDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	CGEEBNGBAJK DEEFNEJFFDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DLJJHNHDHEJ MLKCMFLDMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LHDEBDKJMEE : NEJGALPBJHA
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HNHHKHDLHIK PEIPNFGKIID
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LAJEBICJCAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HMOHBAFPHMA : NEJGALPBJHA
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OGOEOGAJMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OEDOIOLEHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float HGAFGOOEAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int KLJMCAIAKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ACACFCOHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<BEODMMHCLIP> IDKJMFPFGKE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JJFABNABGJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEPOJBIOMAJ(GCGGPGAOMMM NNLKJIOIDAJ, IPDAEDMFIEJ IMENGJGHGIH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEPOJBIOMAJ(CHBOCMCNFFF COCNNHFBEEP, IPDAEDMFIEJ IMENGJGHGIH);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALKLPOLGANO(CHBOCMCNFFF COCNNHFBEEP);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOPHAKDGBDF(CHBOCMCNFFF COCNNHFBEEP, HLGENAAGICH CIMKNKPILIM);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKPBODNENEE(CHBOCMCNFFF COCNNHFBEEP, Vector3 FCGOAOGBPJM, Vector3 HKNGDCJPJEM, Vector3 NBMHPLJEFHJ, float KJEHJPGLFKG, float HBJGGBJLEFE, IReadOnlyList<Camera> FGPDOHIAGCB, GEGIHACLJMG KNNMGOOLFOC);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKPBODNENEE(IOLLGJNKDLH KKOAAGCNBFL, object FINLNGHNKCH, object KAFJABAPDMP, float EPFEMKKCGBG, Color? JMDAPNBHGMF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PPBLEJAMEEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CHBOCMCNFFF BIHFPFOLGBK(CKKJOJGNJMP LKMEKEIFEMN);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IALODKDOBKE(CHBOCMCNFFF COCNNHFBEEP);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANCOEFHIIKH(CHBOCMCNFFF COCNNHFBEEP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GCGGPGAOMMM BKJPMCHIDFB(CHBOCMCNFFF COCNNHFBEEP, LHDEBDKJMEE LKMEKEIFEMN);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GCGGPGAOMMM KIPMAEMECIP(CHBOCMCNFFF COCNNHFBEEP, HMOHBAFPHMA LKMEKEIFEMN);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKBKDDCDGEE(GCGGPGAOMMM NNLKJIOIDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODFEAAMDECE(GCGGPGAOMMM NNLKJIOIDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IOLLGJNKDLH BAKKCEJGLEN(FPGGEELAEJI LKMEKEIFEMN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PIAHHPGDNLM(IOLLGJNKDLH KKOAAGCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BCLGIDHHOKG(IOLLGJNKDLH KKOAAGCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BAONMGEIEPA HHCCCGJKGMN(Transform EPINJPFOMCA, IEnumerable<GCGGPGAOMMM> LPKGBDIGCBJ, int JFEPFHJOLNC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> EKMJCEEOFMG(CHBOCMCNFFF COCNNHFBEEP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class IOLLGJNKDLH
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	internal virtual GONNAJLHCMD EPMEEHHEHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x51D640", Offset = "0x51C640", VA = "0x18051D640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	protected IOLLGJNKDLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FPGGEELAEJI
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	int FNCLLLKPFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	Transform OOIKHAICOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool NKCDHCBONAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CHBOCMCNFFF GetBone(int EKOJJIKDOAL);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int EKOJJIKDOAL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class IIDJCBAFANN : EJIFFFPKPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public LHDEBDKJMEE LMDJNFBKMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int[] GGPHGCLEKKH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public override LFPHMBOOPCI NECDPGPHHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x49623D0", Offset = "0x49613D0", VA = "0x1849623D0", Slot = "13")]
		get
		{
			return default(LFPHMBOOPCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private Vector3 JNLFDHMKPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4962150", Offset = "0x4961150", VA = "0x184962150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4961550", Offset = "0x4960550", VA = "0x184961550")]
	public IIDJCBAFANN(GJLHFNELHIL COCNNHFBEEP, LHDEBDKJMEE LKMEKEIFEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "11")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x49615A0", Offset = "0x49605A0", VA = "0x1849615A0", Slot = "12")]
	public override bool AAADPGIJAGN(Transform COCNNHFBEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4962770", Offset = "0x4961770", VA = "0x184962770", Slot = "14")]
	public override int FBALPPEHPKM(NPKGMAFKBIH DANEEPACMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4962330", Offset = "0x4961330", VA = "0x184962330", Slot = "15")]
	public override int COMHDJNOGCD(NPKGMAFKBIH DANEEPACMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4962810", Offset = "0x4961810", VA = "0x184962810")]
	private int ODEINLNHAAO(NPKGMAFKBIH DANEEPACMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4961AA0", Offset = "0x4960AA0", VA = "0x184961AA0", Slot = "16")]
	public override void AHGHKCKKHNH(NPKGMAFKBIH DANEEPACMAP, NIODFNAFOGH KPGGCKBEAFM, int APONGIMHPDN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KFJAEKGKEBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCJLJMFKMGN(HLGENAAGICH CIMKNKPILIM, Renderer KCOFGOMKLGJ, int MGDHAJAMOEM);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBKNMPJEKCB(Renderer KCOFGOMKLGJ, GEGIHACLJMG KNNMGOOLFOC, Vector3 FCGOAOGBPJM, Vector3 HKNGDCJPJEM, Vector3 NBMHPLJEFHJ, float KJEHJPGLFKG, float HBJGGBJLEFE, float EPFEMKKCGBG = -1f, [Optional] Color? JMDAPNBHGMF, [Optional] IReadOnlyList<Camera> PLLILEOFOAE);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBKNMPJEKCB(Renderer KCOFGOMKLGJ, object FINLNGHNKCH, object KAFJABAPDMP, bool GJPKOOGPEIM, float EPFEMKKCGBG, Color? JMDAPNBHGMF, bool DEHNNLJHAAH = false);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHMGMKJNFPB(Renderer KCOFGOMKLGJ, int MGDHAJAMOEM);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MAFCGIBCDAB();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EADOEJLOBLJ(int DNDGKDEGJNF, IPDAEDMFIEJ CIMKNKPILIM, Renderer KCOFGOMKLGJ, int MGDHAJAMOEM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GHNGCCMMAFK : JJFABNABGJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private KFJAEKGKEBJ GIDOOCNGHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private MeshRenderer PALOBNDMKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private FLPBGHICOFE KNNAFMHIJDO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A2810", Offset = "0x6A1810", VA = "0x1806A2810")]
	public GHNGCCMMAFK(KFJAEKGKEBJ LLOGPLNJBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x495E590", Offset = "0x495D590", VA = "0x18495E590", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x495E800", Offset = "0x495D800", VA = "0x18495E800", Slot = "4")]
	public void MEPOJBIOMAJ(GCGGPGAOMMM NNLKJIOIDAJ, IPDAEDMFIEJ IMENGJGHGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x495E630", Offset = "0x495D630", VA = "0x18495E630", Slot = "5")]
	public void MEPOJBIOMAJ(CHBOCMCNFFF COCNNHFBEEP, IPDAEDMFIEJ IMENGJGHGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x495DC50", Offset = "0x495CC50", VA = "0x18495DC50", Slot = "6")]
	public void ALKLPOLGANO(CHBOCMCNFFF COCNNHFBEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x495DDE0", Offset = "0x495CDE0", VA = "0x18495DDE0", Slot = "7")]
	public void BOPHAKDGBDF(CHBOCMCNFFF COCNNHFBEEP, HLGENAAGICH CIMKNKPILIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x495DF80", Offset = "0x495CF80", VA = "0x18495DF80", Slot = "8")]
	public void CKPBODNENEE(CHBOCMCNFFF COCNNHFBEEP, Vector3 FCGOAOGBPJM, Vector3 HKNGDCJPJEM, Vector3 NBMHPLJEFHJ, float KJEHJPGLFKG, float HBJGGBJLEFE, IReadOnlyList<Camera> FGPDOHIAGCB, GEGIHACLJMG KNNMGOOLFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x495E2B0", Offset = "0x495D2B0", VA = "0x18495E2B0", Slot = "9")]
	public void CKPBODNENEE(IOLLGJNKDLH KKOAAGCNBFL, object FINLNGHNKCH, object KAFJABAPDMP, float EPFEMKKCGBG, Color? JMDAPNBHGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class EJIFFFPKPOD : GCGGPGAOMMM, AKGCLELBDKN, GENINMMIIEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected Bounds LKFCPFBHGHF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public GJLHFNELHIL AALDJPJFFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x534E90", Offset = "0x533E90", VA = "0x180534E90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	internal override EJIFFFPKPOD DBOAFLBNABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D5CB0", Offset = "0x5D4CB0", VA = "0x1805D5CB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Bounds CFKCMIHPDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x14CD640", Offset = "0x14CC640", VA = "0x1814CD640", Slot = "5")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual LFPHMBOOPCI NECDPGPHHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x495D5C0", Offset = "0x495C5C0", VA = "0x18495D5C0", Slot = "13")]
		get
		{
			return default(LFPHMBOOPCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5358A0", Offset = "0x5348A0", VA = "0x1805358A0", Slot = "12")]
	public virtual bool AAADPGIJAGN(Transform COCNNHFBEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int FBALPPEHPKM(NPKGMAFKBIH DANEEPACMAP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract int COMHDJNOGCD(NPKGMAFKBIH DANEEPACMAP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract void AHGHKCKKHNH(NPKGMAFKBIH DANEEPACMAP, NIODFNAFOGH KPGGCKBEAFM, int APONGIMHPDN = -1);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	protected EJIFFFPKPOD()
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
		[Cpp2IlInjected.Address(RVA = "0x4964B20", Offset = "0x4963B20", VA = "0x184964B20")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum HNHHKHDLHIK
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
public static class KKLFAECIDKA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DENJJBOLNFH : IEnumerable<BGKAJKBAENG>, IEnumerable, IEnumerator<BGKAJKBAENG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private BGKAJKBAENG <>2__current;

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
		private BGKAJKBAENG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CD0", Offset = "0x6F3CD0", VA = "0x1806F4CD0")]
		[DebuggerHidden]
		public DENJJBOLNFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x495BF60", Offset = "0x495AF60", VA = "0x18495BF60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x495C0D0", Offset = "0x495B0D0", VA = "0x18495C0D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x495C040", Offset = "0x495B040", VA = "0x18495C040", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BGKAJKBAENG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x495C040", Offset = "0x495B040", VA = "0x18495C040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const int GFDFPLIKFOD = 3;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static BGKAJKBAENG[][] OEBMNLNDDLB;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static NLKGBEIDOBN JHLKANHKIEB;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public static ShapeRendererConfig DHKKPLOABOD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static ComputeShader KMPHBPKDKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4963770", Offset = "0x4962770", VA = "0x184963770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static SkinnedShapeRenderer HPNFFLDMLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x49634C0", Offset = "0x49624C0", VA = "0x1849634C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4963840", Offset = "0x4962840", VA = "0x184963840")]
	public static Mesh NPPNKFGHHLA(HNHHKHDLHIK ALFEEDKAIOC, int DANEEPACMAP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4963760", Offset = "0x4962760", VA = "0x184963760")]
	public static int IINIKJHNMAO(HNHHKHDLHIK ALFEEDKAIOC, int DANEEPACMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4963030", Offset = "0x4962030", VA = "0x184963030")]
	public static NLKGBEIDOBN DDBNIILCDGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x49637E0", Offset = "0x49627E0", VA = "0x1849637E0")]
	[IteratorStateMachine(typeof(DENJJBOLNFH))]
	private static IEnumerable<BGKAJKBAENG> NIMAPFKIKFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4963180", Offset = "0x4962180", VA = "0x184963180")]
	public static BGKAJKBAENG ECFBKDPCPHL(HNHHKHDLHIK ALFEEDKAIOC, int DANEEPACMAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4963900", Offset = "0x4962900", VA = "0x184963900")]
	public static bool ONDOEHEGIGO(this HNHHKHDLHIK ALFEEDKAIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4962E70", Offset = "0x4961E70", VA = "0x184962E70")]
	public static void BPEKGIONDFD(HNHHKHDLHIK ALFEEDKAIOC, float3 JEOFEMLOCML, out KMDNOBAFOEM CFIICPEDHND, out float3 NCCFEEMNAIC, out float JOPPCIHBKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4962A50", Offset = "0x4961A50", VA = "0x184962A50")]
	public static void BCFOKMBKOCH(Vector3 JEOFEMLOCML, HNHHKHDLHIK ALFEEDKAIOC, out Vector3 NCCFEEMNAIC, out float JOPPCIHBKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4963530", Offset = "0x4962530", VA = "0x184963530")]
	[IDFKLDKOEJK(NEKAKBMJKEC.ExitingPlayMode, 0)]
	private static void HDNAFIEMMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4963540", Offset = "0x4962540", VA = "0x184963540")]
	[IDFKLDKOEJK(NEKAKBMJKEC.ExitingPlayMode, 0)]
	private static void IFNEKGDFHNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JAHIGPMHOLC
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool MIBOAEJGMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material ODIMCIPJENN();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material CBDLJANGLAE();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material IFOCPCECAPP();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MOJEDOMFILB(CGEEBNGBAJK LLBFHCNDAFF);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LHKLMHCHOIB(DLJJHNHDHEJ HCBEKAOLLGC);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBAJNJEEJND(GameObject CKMKLMKNMPC);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LOAMLLIBKPO(GameObject CKMKLMKNMPC, bool IHMAGKKICGC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CLOPGIMNMLN : PPBLEJAMEEE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static JAHIGPMHOLC GEBOLFGNBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x495B690", Offset = "0x495A690", VA = "0x18495B690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x495BCB0", Offset = "0x495ACB0", VA = "0x18495BCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x495BD90", Offset = "0x495AD90", VA = "0x18495BD90")]
	public CLOPGIMNMLN(JAHIGPMHOLC LLOGPLNJBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x495B470", Offset = "0x495A470", VA = "0x18495B470", Slot = "4")]
	public CHBOCMCNFFF BIHFPFOLGBK(CKKJOJGNJMP LKMEKEIFEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x495BB80", Offset = "0x495AB80", VA = "0x18495BB80", Slot = "5")]
	public void IALODKDOBKE(CHBOCMCNFFF COCNNHFBEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x495B330", Offset = "0x495A330", VA = "0x18495B330", Slot = "6")]
	public void ANCOEFHIIKH(CHBOCMCNFFF COCNNHFBEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x495B5F0", Offset = "0x495A5F0", VA = "0x18495B5F0", Slot = "15")]
	public IEnumerable<Renderer> EKMJCEEOFMG(CHBOCMCNFFF COCNNHFBEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x495B520", Offset = "0x495A520", VA = "0x18495B520", Slot = "7")]
	public GCGGPGAOMMM BKJPMCHIDFB(CHBOCMCNFFF COCNNHFBEEP, LHDEBDKJMEE LKMEKEIFEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x495BBE0", Offset = "0x495ABE0", VA = "0x18495BBE0", Slot = "8")]
	public GCGGPGAOMMM KIPMAEMECIP(CHBOCMCNFFF COCNNHFBEEP, HMOHBAFPHMA LKMEKEIFEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x495BAD0", Offset = "0x495AAD0", VA = "0x18495BAD0", Slot = "9")]
	public void HKBKDDCDGEE(GCGGPGAOMMM NNLKJIOIDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x495BD00", Offset = "0x495AD00", VA = "0x18495BD00", Slot = "10")]
	public void ODFEAAMDECE(GCGGPGAOMMM NNLKJIOIDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x495B370", Offset = "0x495A370", VA = "0x18495B370", Slot = "11")]
	public IOLLGJNKDLH BAKKCEJGLEN(FPGGEELAEJI LKMEKEIFEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x495BD50", Offset = "0x495AD50", VA = "0x18495BD50", Slot = "12")]
	public void PIAHHPGDNLM(IOLLGJNKDLH KKOAAGCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x495B430", Offset = "0x495A430", VA = "0x18495B430", Slot = "13")]
	public void BCLGIDHHOKG(IOLLGJNKDLH KKOAAGCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x495B6D0", Offset = "0x495A6D0", VA = "0x18495B6D0", Slot = "14")]
	public BAONMGEIEPA HHCCCGJKGMN(Transform EPINJPFOMCA, IEnumerable<GCGGPGAOMMM> LPKGBDIGCBJ, int JFEPFHJOLNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GONNAJLHCMD : IOLLGJNKDLH, HHBAGMIJCJM
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FHBOPKCJBIC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GONNAJLHCMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F4CD0", Offset = "0x6F3CD0", VA = "0x1806F4CD0")]
		[DebuggerHidden]
		public FHBOPKCJBIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x495D930", Offset = "0x495C930", VA = "0x18495D930", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x495D650", Offset = "0x495C650", VA = "0x18495D650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x495D9D0", Offset = "0x495C9D0", VA = "0x18495D9D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x495D8E0", Offset = "0x495C8E0", VA = "0x18495D8E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x495D840", Offset = "0x495C840", VA = "0x18495D840", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x495D840", Offset = "0x495C840", VA = "0x18495D840", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private FPGGEELAEJI BKJGCMFEFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private DLCFCPNFNDK NPKOBPHOLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private List<LBCMEAMJONK> PMJBELANHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private List<LBCMEAMJONK> OOPPIEKAIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private GameObject FMHCHKMMGND;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	internal override GONNAJLHCMD EPMEEHHEHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D5CB0", Offset = "0x5D4CB0", VA = "0x1805D5CB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4960930", Offset = "0x495F930", VA = "0x184960930")]
	public static GONNAJLHCMD HKJKOFJDCPJ(FPGGEELAEJI LKMEKEIFEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4960A90", Offset = "0x495FA90", VA = "0x184960A90")]
	private GONNAJLHCMD(FPGGEELAEJI LKMEKEIFEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4960510", Offset = "0x495F510", VA = "0x184960510")]
	public void ELGBEGHMCDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x49609F0", Offset = "0x495F9F0", VA = "0x1849609F0")]
	[IteratorStateMachine(typeof(FHBOPKCJBIC))]
	public IEnumerable<Renderer> IECBMHANFAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x495FA50", Offset = "0x495EA50", VA = "0x18495FA50", Slot = "5")]
	public void CGOHFNMFBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4960A60", Offset = "0x495FA60", VA = "0x184960A60")]
	private void IJEGLCGNFJO(Vector3 KJBJMCEFLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4960340", Offset = "0x495F340", VA = "0x184960340")]
	public void EBPLJKLJNDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LBCMEAMJONK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private struct LFLOFIMHIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public NIODFNAFOGH HEJKGHHAGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Transform MIBDIMKHCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int FLMPPABKDEC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PDDFCPIJFOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public LBCMEAMJONK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public NPKGMAFKBIH lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public List<LFLOFIMHIHK> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public PDDFCPIJFOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class GAAADLOOEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public BAONMGEIEPA combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public PDDFCPIJFOJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public GAAADLOOEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x495DA10", Offset = "0x495CA10", VA = "0x18495DA10")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x495DA80", Offset = "0x495CA80", VA = "0x18495DA80")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x495DAC0", Offset = "0x495CAC0", VA = "0x18495DAC0")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int[] HHNFGEDMCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NEEHHAFFBOI OJKCKHMIKGB;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static Matrix4x4 EPLDAODBOLG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Mesh PHDDLJOOHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x534E90", Offset = "0x533E90", VA = "0x180534E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int DNMDFAPAIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x511440", Offset = "0x510440", VA = "0x180511440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1A0", Offset = "0x5CC1A0", VA = "0x1805CD1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4964330", Offset = "0x4963330", VA = "0x184964330")]
	public void MFANMDBDDLH(List<Transform> BHBJANLNMMM, Matrix4x4[] IJOMNMJJCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x49639A0", Offset = "0x49629A0", VA = "0x1849639A0")]
	public static List<LBCMEAMJONK> DMLCAMHGJAD(List<KFPJFOOMOOG> IPBMEECLFEL, NPKGMAFKBIH DANEEPACMAP, Bounds KHOBCBHKHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4963FB0", Offset = "0x4962FB0", VA = "0x184963FB0")]
	private JobHandle LLFKDAPOEIK(BAONMGEIEPA FNPCPEPNCBM, int NMELNJAALKB, int DKMOCDOBMHP, NPKGMAFKBIH DANEEPACMAP, List<LFLOFIMHIHK> DBNMBANIIKB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4964530", Offset = "0x4963530", VA = "0x184964530")]
	private void OLGGMAPBCKI(List<LFLOFIMHIHK> DBNMBANIIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4964770", Offset = "0x4963770", VA = "0x184964770")]
	private LBCMEAMJONK(List<LFLOFIMHIHK> DBNMBANIIKB, int NMELNJAALKB, int DKMOCDOBMHP, NPKGMAFKBIH DANEEPACMAP, Bounds KHOBCBHKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4963F30", Offset = "0x4962F30", VA = "0x184963F30", Slot = "4")]
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
		private MaterialPropertyBlock KIOPIHOKOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private LBCMEAMJONK OOBCOIKNJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private List<Transform> LCJBKPLLOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private RenderTexture NNDIANFGOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private ComputeBuffer DOCAJHNMMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private ComputeShader NOCHLGGBMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Matrix4x4[] EJLGEIOJKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int PJNLKMGOEHK;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MeshRenderer MBCKEMCNJJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x514430", Offset = "0x513430", VA = "0x180514430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int FNCLLLKPFNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x49656C0", Offset = "0x49646C0", VA = "0x1849656C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4964B50", Offset = "0x4963B50", VA = "0x184964B50")]
		public static List<SkinnedShapeRenderer> Create(GameObject COCNNHFBEEP, List<LBCMEAMJONK> PDIEKPDEDKN, List<Transform> LCJBKPLLOIF, Material DOMIJDHKEBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4964D60", Offset = "0x4963D60", VA = "0x184964D60")]
		public void Init(LBCMEAMJONK OOBCOIKNJHA, List<Transform> LCJBKPLLOIF, Material DOMIJDHKEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x49655A0", Offset = "0x49645A0", VA = "0x1849655A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4965510", Offset = "0x4964510", VA = "0x184965510")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x49654D0", Offset = "0x49644D0", VA = "0x1849654D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4965630", Offset = "0x4964630", VA = "0x184965630")]
		private void PNDDEMALEGI(ScriptableRenderContext JJNBJBEMAKH, Camera[] DGCJMGHGPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4965180", Offset = "0x4964180", VA = "0x184965180")]
		private void MFANMDBDDLH(CommandBuffer AOBIEEALMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x50DA60", Offset = "0x50CA60", VA = "0x18050DA60")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DLAOCNHHHPI
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static byte[] HDGCOIJLNAH;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static int OFJBPIBPJGA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static int DJDAKEIMIDA;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static BigInteger JAEJMLKAHIB;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public DLAOCNHHHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x495C450", Offset = "0x495B450", VA = "0x18495C450")]
	private static string MKDMGNIMLKE(byte[] FFKAJGPOGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x495C120", Offset = "0x495B120", VA = "0x18495C120")]
	public static string KDCKFNHEIFO(byte[] CPFFKFOFBAE, bool FPKNOKKBPNA)
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
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
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
