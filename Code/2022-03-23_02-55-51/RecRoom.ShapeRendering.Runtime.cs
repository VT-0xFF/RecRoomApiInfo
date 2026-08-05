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
public enum IIDPCFMGODB
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
public enum KBJLNNLIBLJ
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
public enum AFEFDDADKFP
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
public enum MKHKOPMPICK
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
	NearbyContextual,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	HoverXRay
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum ELJFFFGFAEH
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	CornerMove
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NJAGJFMNNBB : LBLMPPELDBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private const byte IKAPIJEBGAM = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private byte MEKCPPGPHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly List<SkinnedShapeRenderer>[] LMPFKPOOLBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FELEPFJBCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x521CD0", Offset = "0x5204D0", VA = "0x180521CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A10", Offset = "0x5A1210", VA = "0x1805A2A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BALCLOAPOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x521CC0", Offset = "0x5204C0", VA = "0x180521CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67BE70", Offset = "0x67A670", VA = "0x18067BE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float MNMCOHMPJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xE34B10", Offset = "0xE33310", VA = "0x180E34B10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x10E3E10", Offset = "0x10E2610", VA = "0x1810E3E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JKGMAMIEGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE60440", Offset = "0xE5EC40", VA = "0x180E60440", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE60450", Offset = "0xE5EC50", VA = "0x180E60450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> DAEHFHJNGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4A1EE20", Offset = "0x4A1D620", VA = "0x184A1EE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GameObject CNMJPCHFBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x549A30", Offset = "0x548230", VA = "0x180549A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x659540", Offset = "0x657D40", VA = "0x180659540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public byte GJNGOELKCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4A1EFE0", Offset = "0x4A1D7E0", VA = "0x184A1EFE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A1F030", Offset = "0x4A1D830", VA = "0x184A1F030")]
	public NJAGJFMNNBB(List<DLCOOKLBLCK> IFCJBPJENJC, List<DLCOOKLBLCK> FBHHEDAMPGA, List<Transform> IBGLFGNOFMG, Material PNEKGAFLGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A1EB90", Offset = "0x4A1D390", VA = "0x184A1EB90")]
	private int CPBGOLCBNKA(List<DLCOOKLBLCK> EBGONCJIDCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A1EE80", Offset = "0x4A1D680", VA = "0x184A1EE80")]
	private void KDAIHGHIFDK(int NAJDNNLGHIB, bool JEKLNIGLCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A1ECA0", Offset = "0x4A1D4A0", VA = "0x184A1ECA0")]
	public void DMIOAJMDNMH(Vector3 NIAPOPKMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A1ED90", Offset = "0x4A1D590", VA = "0x184A1ED90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4A1EB50", Offset = "0x4A1D350", VA = "0x184A1EB50")]
	public void ADEFLELKGAH(Transform MOLCMNJAKME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AIMJGPNKBHJ : KMFFBHPIMBP, NGGPPEICKMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class EHPCPFHOCKH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AIMJGPNKBHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6323E0", Offset = "0x630BE0", VA = "0x1806323E0")]
		[DebuggerHidden]
		public EHPCPFHOCKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4A18770", Offset = "0x4A16F70", VA = "0x184A18770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4A182C0", Offset = "0x4A16AC0", VA = "0x184A182C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4A188F0", Offset = "0x4A170F0", VA = "0x184A188F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4A18930", Offset = "0x4A17130", VA = "0x184A18930")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4A18980", Offset = "0x4A17180", VA = "0x184A18980")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4A18720", Offset = "0x4A16F20", VA = "0x184A18720", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4A18680", Offset = "0x4A16E80", VA = "0x184A18680", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4A18680", Offset = "0x4A16E80", VA = "0x184A18680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EIEPDNNKKJO BDNHGHMBOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private List<ICLPLDLAEFJ> OFIGAINGDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<ClusterMeshRenderer> IGOJKGBDFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private BatchedMeshRenderer ELHDPHGLGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool BLDPLHJHABL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IEnumerable<CNHNDMINLMM> OMOKBBMPJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int BOMOFKJOPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4A14F60", Offset = "0x4A13760", VA = "0x184A14F60", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform MPBOIOODNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4A157D0", Offset = "0x4A13FD0", VA = "0x184A157D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A15F20", Offset = "0x4A14720", VA = "0x184A15F20")]
	public AIMJGPNKBHJ(EIEPDNNKKJO KBMGAHFAOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A14FA0", Offset = "0x4A137A0", VA = "0x184A14FA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A14FD0", Offset = "0x4A137D0", VA = "0x184A14FD0")]
	public void EFDMEADFFJF(ICLPLDLAEFJ GGHOKHCAJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A15760", Offset = "0x4A13F60", VA = "0x184A15760")]
	public void HICPDAONBIK(ICLPLDLAEFJ GGHOKHCAJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4A159D0", Offset = "0x4A141D0", VA = "0x184A159D0", Slot = "4")]
	public void OLHJMMJAECB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A150A0", Offset = "0x4A138A0", VA = "0x184A150A0")]
	public void GNNANHCHACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A15130", Offset = "0x4A13930", VA = "0x184A15130")]
	private void GPIBDKMGFPA(ICLPLDLAEFJ GGHOKHCAJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A15280", Offset = "0x4A13A80", VA = "0x184A15280")]
	public void HAKKMFOGINJ(bool BKBNGLBCDFC, bool LDGHDHPLBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A15890", Offset = "0x4A14090", VA = "0x184A15890")]
	protected void KNPJPNFKIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A15820", Offset = "0x4A14020", VA = "0x184A15820")]
	[IteratorStateMachine(typeof(EHPCPFHOCKH))]
	public IEnumerable<Renderer> KFFIFBJCEDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class JMCOPGFIMGA : ICLPLDLAEFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private HHAOCKFGECB AMPNDHGFCAK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4A19EA0", Offset = "0x4A186A0", VA = "0x184A19EA0")]
	private NativeList<AAEMMAKGKBF> ANLLLLJKDCL()
	{
		return default(NativeList<AAEMMAKGKBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4A1A8E0", Offset = "0x4A190E0", VA = "0x184A1A8E0")]
	public JMCOPGFIMGA(AIMJGPNKBHJ MHMECKKACOC, HHAOCKFGECB KBMGAHFAOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A19F70", Offset = "0x4A18770", VA = "0x184A19F70", Slot = "13")]
	public override int CPBGOLCBNKA(HPGKNDLHNMK KILPIDLBIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4A1A190", Offset = "0x4A18990", VA = "0x184A1A190", Slot = "14")]
	public override int ODCKIIKFFAL(HPGKNDLHNMK KILPIDLBIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4A1A3B0", Offset = "0x4A18BB0", VA = "0x184A1A3B0", Slot = "15")]
	public override void OJJJENDKKHO(HPGKNDLHNMK KILPIDLBIPL, CDHGHEMGMAO NAIJKIKKMLG, int OKBJMFFONAF = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HEMHHMNOFGB : global::PHHIIDHHBDI<HEMHHMNOFGB>, ACBJOINGLIO, IEquatable<HEMHHMNOFGB>
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int ICFFKCCKJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C6330", Offset = "0x7C4B30", VA = "0x1807C6330", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85ECB0", Offset = "0x85D4B0", VA = "0x18085ECB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FPBDGOECKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C6310", Offset = "0x7C4B10", VA = "0x1807C6310", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x838560", Offset = "0x836D60", VA = "0x180838560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3CCEB60", Offset = "0x3CCD360", VA = "0x183CCEB60", Slot = "8")]
	public bool Equals(HEMHHMNOFGB DKNLIFHKLLN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A19960", Offset = "0x4A18160", VA = "0x184A19960")]
	public static bool DLLJLNHALPP(HEMHHMNOFGB OGBIEODJMBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GKGOIMKPMEN
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EIEPDNNKKJO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform DKNJNEAIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GKGOIMKPMEN CGENBCCHNJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DJBMKDKHFKJ : global::PHHIIDHHBDI<DJBMKDKHFKJ>, ACBJOINGLIO, IEquatable<DJBMKDKHFKJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int ICFFKCCKJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C6330", Offset = "0x7C4B30", VA = "0x1807C6330", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85ECB0", Offset = "0x85D4B0", VA = "0x18085ECB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FPBDGOECKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6310", Offset = "0x7C4B10", VA = "0x1807C6310", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x838560", Offset = "0x836D60", VA = "0x180838560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CCEB60", Offset = "0x3CCD360", VA = "0x183CCEB60", Slot = "8")]
	public bool Equals(DJBMKDKHFKJ DKNLIFHKLLN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A17100", Offset = "0x4A15900", VA = "0x184A17100")]
	public static bool DLLJLNHALPP(DJBMKDKHFKJ OGBIEODJMBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface COPFINPFFGB
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform DKNJNEAIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float NHJGLFHJFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Vector3 BCBOICGAFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IIDPCFMGODB EBKDJDPMCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KBJLNNLIBLJ EOEEKJADLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FKICLEBLMOA : COPFINPFFGB
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	EHEHGKAMHDC KIOEFLAKGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JIBDDEPJKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HHAOCKFGECB : COPFINPFFGB
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MJNLGENAAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PHHOAOHJPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float HKMKBPBMHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int JDPJDGOGIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool AMMEPBGBMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NativeList<AAEMMAKGKBF> ANLLLLJKDCL();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FODNJHLMIGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DJODIIPGFDG(DJBMKDKHFKJ GGHOKHCAJLE, MKHKOPMPICK IFDAPEKGAKK);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJODIIPGFDG(HEMHHMNOFGB MHMECKKACOC, MKHKOPMPICK IFDAPEKGAKK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFMOKNNLBEF(HEMHHMNOFGB MHMECKKACOC);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFMOKNNLBEF(DJBMKDKHFKJ GGHOKHCAJLE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLINAPIKEAO(HEMHHMNOFGB MHMECKKACOC, ELJFFFGFAEH MIDEMNGPEAG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OIDMFHBHPAA(HEMHHMNOFGB MHMECKKACOC, Vector3 BLPNFMNPFFI, Vector3 GOLFAPHOGCH, Vector3 NCKJJGJHAHB, float ONLJOHHMFIH, float CMOKGJLNHLF, IReadOnlyList<Camera> GEFLEMDFAHC, AFEFDDADKFP KHPIFOIJFNH);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OIDMFHBHPAA(FFIHLJDHOEL NFOBALPPONE, Vector3 BLPNFMNPFFI, Vector3 GOLFAPHOGCH, Vector3 NCKJJGJHAHB, float ONLJOHHMFIH, float CMOKGJLNHLF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NBMPFIKGBPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HEMHHMNOFGB ILNPCCDBJJB(EIEPDNNKKJO KBMGAHFAOOA);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHONPCBGAGC(HEMHHMNOFGB MHMECKKACOC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCHFMFDBJJL(HEMHHMNOFGB MHMECKKACOC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DJBMKDKHFKJ GKNMDAIMBOB(HEMHHMNOFGB MHMECKKACOC, FKICLEBLMOA KBMGAHFAOOA);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DJBMKDKHFKJ BDPNHEDGLPD(HEMHHMNOFGB MHMECKKACOC, HHAOCKFGECB KBMGAHFAOOA);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NHBCDGIMAEF(DJBMKDKHFKJ GGHOKHCAJLE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PPIAOAPBPEM(DJBMKDKHFKJ GGHOKHCAJLE);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FFIHLJDHOEL AHHDIGHPIGF(JOPBHKEJEOL KBMGAHFAOOA);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JOHOEGJDPNA(FFIHLJDHOEL NFOBALPPONE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KKEGOAFMJMG(FFIHLJDHOEL NFOBALPPONE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HJLLFEBGKOE OOGPNCNEOAL(Transform MPOODOGAEPK, IEnumerable<DJBMKDKHFKJ> OFIGAINGDDH, int FDAKEAHAILH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> AAGHMDLLJGK(HEMHHMNOFGB MHMECKKACOC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FFIHLJDHOEL : global::PHHIIDHHBDI<FFIHLJDHOEL>, ACBJOINGLIO, IEquatable<FFIHLJDHOEL>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int ICFFKCCKJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6330", Offset = "0x7C4B30", VA = "0x1807C6330", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85ECB0", Offset = "0x85D4B0", VA = "0x18085ECB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int FPBDGOECKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C6310", Offset = "0x7C4B10", VA = "0x1807C6310", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x838560", Offset = "0x836D60", VA = "0x180838560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3CCEB60", Offset = "0x3CCD360", VA = "0x183CCEB60", Slot = "8")]
	public bool Equals(FFIHLJDHOEL DKNLIFHKLLN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4A189D0", Offset = "0x4A171D0", VA = "0x184A189D0")]
	public static bool DLLJLNHALPP(FFIHLJDHOEL OGBIEODJMBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JOPBHKEJEOL
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	int OCMJBLNHDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Transform FNAFDNLBPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool CLMIKCFPGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HEMHHMNOFGB GetBone(int JNIBPEEBOEO);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int JNIBPEEBOEO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class KMMMJONHIMB : ICLPLDLAEFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public FKICLEBLMOA LMIEEGOILEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int[] ALOPHPDIFMJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public override ACBKJDJEAOB CNNPDNPIFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4A1A9D0", Offset = "0x4A191D0", VA = "0x184A1A9D0", Slot = "12")]
		get
		{
			return default(ACBKJDJEAOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Vector3 NMCNEAEHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4A1B270", Offset = "0x4A19A70", VA = "0x184A1B270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4A1A8E0", Offset = "0x4A190E0", VA = "0x184A1A8E0")]
	public KMMMJONHIMB(AIMJGPNKBHJ MHMECKKACOC, FKICLEBLMOA KBMGAHFAOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4A1AD70", Offset = "0x4A19570", VA = "0x184A1AD70", Slot = "11")]
	public override bool LLHKLMBFPGE(Transform MHMECKKACOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4A1A930", Offset = "0x4A19130", VA = "0x184A1A930", Slot = "13")]
	public override int CPBGOLCBNKA(HPGKNDLHNMK KILPIDLBIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A1B450", Offset = "0x4A19C50", VA = "0x184A1B450", Slot = "14")]
	public override int ODCKIIKFFAL(HPGKNDLHNMK KILPIDLBIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4A1BBA0", Offset = "0x4A1A3A0", VA = "0x184A1BBA0")]
	private int POLCLGLLFBL(HPGKNDLHNMK KILPIDLBIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4A1B4F0", Offset = "0x4A19CF0", VA = "0x184A1B4F0", Slot = "15")]
	public override void OJJJENDKKHO(HPGKNDLHNMK KILPIDLBIPL, CDHGHEMGMAO NAIJKIKKMLG, int OKBJMFFONAF = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface COBNDNLGDIB
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHNNFHIANHO(ELJFFFGFAEH MIDEMNGPEAG, Renderer BIHHLBNMDIF, int AIOEMDKEMPD);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLIMHEDAIOL(Renderer BIHHLBNMDIF, AFEFDDADKFP KHPIFOIJFNH, Vector3 BLPNFMNPFFI, Vector3 GOLFAPHOGCH, Vector3 NCKJJGJHAHB, float ONLJOHHMFIH, float CMOKGJLNHLF, float BNCNLGHCFDE = -1f, [Optional] Color? OJJCFGCADHD, [Optional] IReadOnlyList<Camera> AEMJCHKJCCF);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAOLCFIGFHN(Renderer BIHHLBNMDIF, int AIOEMDKEMPD);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OCEMKHLMHKG();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLIIMBLFEKJ(int KBMFAANHKKL, MKHKOPMPICK MIDEMNGPEAG, Renderer BIHHLBNMDIF, int AIOEMDKEMPD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KPLLHNHAHOE : FODNJHLMIGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly COBNDNLGDIB JHGFPJIJKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly PFBIEHCLEAI IHJCACPANCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private MeshRenderer EOAEGMJLHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private BMJIBEBENGD FEALHKNBDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private MeshRenderer NMNEGBLHLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private BMJIBEBENGD DKBEKGGCFBF;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x534990", Offset = "0x533190", VA = "0x180534990")]
	public KPLLHNHAHOE(COBNDNLGDIB OKOKFNDHCLJ, PFBIEHCLEAI IHJCACPANCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4A1C9E0", Offset = "0x4A1B1E0", VA = "0x184A1C9E0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4A1C760", Offset = "0x4A1AF60", VA = "0x184A1C760", Slot = "4")]
	public void DJODIIPGFDG(DJBMKDKHFKJ GGHOKHCAJLE, MKHKOPMPICK IFDAPEKGAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4A1C590", Offset = "0x4A1AD90", VA = "0x184A1C590", Slot = "5")]
	public void DJODIIPGFDG(HEMHHMNOFGB MHMECKKACOC, MKHKOPMPICK IFDAPEKGAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4A1C3F0", Offset = "0x4A1ABF0", VA = "0x184A1C3F0", Slot = "6")]
	public void DFMOKNNLBEF(HEMHHMNOFGB MHMECKKACOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4A1C1A0", Offset = "0x4A1A9A0", VA = "0x184A1C1A0", Slot = "7")]
	public void DFMOKNNLBEF(DJBMKDKHFKJ GGHOKHCAJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4A1CB30", Offset = "0x4A1B330", VA = "0x184A1CB30", Slot = "8")]
	public void JLINAPIKEAO(HEMHHMNOFGB MHMECKKACOC, ELJFFFGFAEH MIDEMNGPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4A1D0A0", Offset = "0x4A1B8A0", VA = "0x184A1D0A0", Slot = "9")]
	public void OIDMFHBHPAA(HEMHHMNOFGB MHMECKKACOC, Vector3 BLPNFMNPFFI, Vector3 GOLFAPHOGCH, Vector3 NCKJJGJHAHB, float ONLJOHHMFIH, float CMOKGJLNHLF, IReadOnlyList<Camera> GEFLEMDFAHC, AFEFDDADKFP KHPIFOIJFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4A1CCD0", Offset = "0x4A1B4D0", VA = "0x184A1CCD0", Slot = "10")]
	public void OIDMFHBHPAA(FFIHLJDHOEL NFOBALPPONE, Vector3 BLPNFMNPFFI, Vector3 GOLFAPHOGCH, Vector3 NCKJJGJHAHB, float ONLJOHHMFIH, float CMOKGJLNHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class ICLPLDLAEFJ : DFNLBKEBKBB, CNHNDMINLMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	protected Bounds BJLAEALFHLC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AIMJGPNKBHJ CNMJPCHFBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x521490", Offset = "0x51FC90", VA = "0x180521490")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Bounds LHILMIAMCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xFFD380", Offset = "0xFFBB80", VA = "0x180FFD380", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public virtual ACBKJDJEAOB CNNPDNPIFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4A19DA0", Offset = "0x4A185A0", VA = "0x184A19DA0", Slot = "12")]
		get
		{
			return default(ACBKJDJEAOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4A19E30", Offset = "0x4A18630", VA = "0x184A19E30", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x521EC0", Offset = "0x5206C0", VA = "0x180521EC0", Slot = "11")]
	public virtual bool LLHKLMBFPGE(Transform MHMECKKACOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int CPBGOLCBNKA(HPGKNDLHNMK KILPIDLBIPL);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int ODCKIIKFFAL(HPGKNDLHNMK KILPIDLBIPL);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void OJJJENDKKHO(HPGKNDLHNMK KILPIDLBIPL, CDHGHEMGMAO NAIJKIKKMLG, int OKBJMFFONAF = -1);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	protected ICLPLDLAEFJ()
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
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4A1F2F0", Offset = "0x4A1DAF0", VA = "0x184A1F2F0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum EHEHGKAMHDC
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FKMNMAJGOCL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HNJCKPPEECI : IEnumerable<LMMIPAGBAAO>, IEnumerable, IEnumerator<LMMIPAGBAAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private LMMIPAGBAAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private LMMIPAGBAAO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6323E0", Offset = "0x630BE0", VA = "0x1806323E0")]
		[DebuggerHidden]
		public HNJCKPPEECI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4A199A0", Offset = "0x4A181A0", VA = "0x184A199A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4A19B10", Offset = "0x4A18310", VA = "0x184A19B10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4A19A80", Offset = "0x4A18280", VA = "0x184A19A80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LMMIPAGBAAO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4A19A80", Offset = "0x4A18280", VA = "0x184A19A80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int KKKPEKNKEDA = 3;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static LMMIPAGBAAO[][] BGAEMGFFFPG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static EBCNKMGHJPC CIMDJKDEILK;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static ShapeRendererConfig GADOJPOGFIK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static ComputeShader GONHKOOEPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4A196C0", Offset = "0x4A17EC0", VA = "0x184A196C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static SkinnedShapeRenderer CJNAHOOHMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4A18C00", Offset = "0x4A17400", VA = "0x184A18C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4A192B0", Offset = "0x4A17AB0", VA = "0x184A192B0")]
	public static Mesh IBAOABPJIPA(EHEHGKAMHDC GICPPMBEECC, int KILPIDLBIPL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4A19370", Offset = "0x4A17B70", VA = "0x184A19370")]
	public static int IIHPALGBJCB(EHEHGKAMHDC GICPPMBEECC, int KILPIDLBIPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4A19790", Offset = "0x4A17F90", VA = "0x184A19790")]
	public static EBCNKMGHJPC PKBFGBNDPEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4A19730", Offset = "0x4A17F30", VA = "0x184A19730")]
	[IteratorStateMachine(typeof(HNJCKPPEECI))]
	private static IEnumerable<LMMIPAGBAAO> MEELEAKLCNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4A19380", Offset = "0x4A17B80", VA = "0x184A19380")]
	public static LMMIPAGBAAO JFGKGOOGAOF(EHEHGKAMHDC GICPPMBEECC, int KILPIDLBIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4A18A20", Offset = "0x4A17220", VA = "0x184A18A20")]
	public static bool ALDJDCBHELN(this EHEHGKAMHDC GICPPMBEECC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4A18A40", Offset = "0x4A17240", VA = "0x184A18A40")]
	public static void COHIKEDKBJK(EHEHGKAMHDC GICPPMBEECC, float3 OCIBBEOLNIM, out OHIBPKIPJCD NFILBFOCFNA, out float3 EFEKABAIBGB, out float GCACDEBHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4A18C70", Offset = "0x4A17470", VA = "0x184A18C70")]
	public static void FFPPOEGEJNF(Vector3 OCIBBEOLNIM, EHEHGKAMHDC GICPPMBEECC, out Vector3 EFEKABAIBGB, out float GCACDEBHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4A18A10", Offset = "0x4A17210", VA = "0x184A18A10")]
	[DIOLCMJEKCJ(DMCKANKCBMH.ExitingPlayMode, 0)]
	private static void AEKMHOMBELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4A19090", Offset = "0x4A17890", VA = "0x184A19090")]
	[DIOLCMJEKCJ(DMCKANKCBMH.ExitingPlayMode, 0)]
	private static void GJBADCECDAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BDNIEHBENGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool JOOOAMEPHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material CBBIFCDCPDH();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material EGCCPEPBOEB();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material NBNCAAJPANP();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FHJAIPLPMGF(IIDPCFMGODB GMMFMHPNOBL);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EAGHLBOOINN(KBJLNNLIBLJ PHFKCGOIIPM);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EAKMOFHDGNP(GameObject HDKLJDMDCGI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CGBLKECJEMI(GameObject HDKLJDMDCGI, bool NHHDKNFLHGC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public interface PFBIEHCLEAI
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	AIMJGPNKBHJ EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ICLPLDLAEFJ EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	DAFNGKNMFML EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class MCFKOIMAJOC : NBMPFIKGBPC, IDisposable, PFBIEHCLEAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly global::HKDIGCDDGGD<HEMHHMNOFGB, AIMJGPNKBHJ> JNIDNJEJMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly global::HKDIGCDDGGD<DJBMKDKHFKJ, ICLPLDLAEFJ> OFIGAINGDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly global::HKDIGCDDGGD<FFIHLJDHOEL, DAFNGKNMFML> DGJLMCPFABA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static BDNIEHBENGJ AOFFBKAJMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4A1E160", Offset = "0x4A1C960", VA = "0x184A1E160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4A1DE40", Offset = "0x4A1C640", VA = "0x184A1DE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AIMJGPNKBHJ EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4A1E040", Offset = "0x4A1C840", VA = "0x184A1E040", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public ICLPLDLAEFJ EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A1E0A0", Offset = "0x4A1C8A0", VA = "0x184A1E0A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DAFNGKNMFML EDFJNANCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A1E100", Offset = "0x4A1C900", VA = "0x184A1E100", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A1E6E0", Offset = "0x4A1CEE0", VA = "0x184A1E6E0")]
	public MCFKOIMAJOC(BDNIEHBENGJ OKOKFNDHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DC80", Offset = "0x4A1C480", VA = "0x184A1DC80", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DE90", Offset = "0x4A1C690", VA = "0x184A1DE90", Slot = "4")]
	public HEMHHMNOFGB ILNPCCDBJJB(EIEPDNNKKJO KBMGAHFAOOA)
	{
		return default(HEMHHMNOFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DCF0", Offset = "0x4A1C4F0", VA = "0x184A1DCF0", Slot = "5")]
	public void GHONPCBGAGC(HEMHHMNOFGB MHMECKKACOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A1E1A0", Offset = "0x4A1C9A0", VA = "0x184A1E1A0", Slot = "6")]
	public void NCHFMFDBJJL(HEMHHMNOFGB MHMECKKACOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4A1D9C0", Offset = "0x4A1C1C0", VA = "0x184A1D9C0", Slot = "15")]
	public IEnumerable<Renderer> AAGHMDLLJGK(HEMHHMNOFGB MHMECKKACOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DD50", Offset = "0x4A1C550", VA = "0x184A1DD50", Slot = "7")]
	public DJBMKDKHFKJ GKNMDAIMBOB(HEMHHMNOFGB MHMECKKACOC, FKICLEBLMOA KBMGAHFAOOA)
	{
		return default(DJBMKDKHFKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DB90", Offset = "0x4A1C390", VA = "0x184A1DB90", Slot = "8")]
	public DJBMKDKHFKJ BDPNHEDGLPD(HEMHHMNOFGB MHMECKKACOC, HHAOCKFGECB KBMGAHFAOOA)
	{
		return default(DJBMKDKHFKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4A1E670", Offset = "0x4A1CE70", VA = "0x184A1E670", Slot = "10")]
	public void PPIAOAPBPEM(DJBMKDKHFKJ GGHOKHCAJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4A1E210", Offset = "0x4A1CA10", VA = "0x184A1E210", Slot = "9")]
	public void NHBCDGIMAEF(DJBMKDKHFKJ GGHOKHCAJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DA80", Offset = "0x4A1C280", VA = "0x184A1DA80", Slot = "11")]
	public FFIHLJDHOEL AHHDIGHPIGF(JOPBHKEJEOL KBMGAHFAOOA)
	{
		return default(FFIHLJDHOEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DFD0", Offset = "0x4A1C7D0", VA = "0x184A1DFD0", Slot = "13")]
	public void KKEGOAFMJMG(FFIHLJDHOEL NFOBALPPONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DF70", Offset = "0x4A1C770", VA = "0x184A1DF70", Slot = "12")]
	public void JOHOEGJDPNA(FFIHLJDHOEL NFOBALPPONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4A1E270", Offset = "0x4A1CA70", VA = "0x184A1E270", Slot = "14")]
	public HJLLFEBGKOE OOGPNCNEOAL(Transform MPOODOGAEPK, IEnumerable<DJBMKDKHFKJ> OFIGAINGDDH, int FDAKEAHAILH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DAFNGKNMFML : KMFFBHPIMBP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KPGFIEDIKOG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public DAFNGKNMFML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6323E0", Offset = "0x630BE0", VA = "0x1806323E0")]
		[DebuggerHidden]
		public KPGFIEDIKOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4A1C0C0", Offset = "0x4A1A8C0", VA = "0x184A1C0C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4A1BDE0", Offset = "0x4A1A5E0", VA = "0x184A1BDE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4A1C160", Offset = "0x4A1A960", VA = "0x184A1C160")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4A1C070", Offset = "0x4A1A870", VA = "0x184A1C070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4A1BFD0", Offset = "0x4A1A7D0", VA = "0x184A1BFD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4A1BFD0", Offset = "0x4A1A7D0", VA = "0x184A1BFD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly JOPBHKEJEOL DCEBONBPCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly PFBIEHCLEAI IHJCACPANCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NJAGJFMNNBB KJKNPOGCPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private List<DLCOOKLBLCK> IABAHPBPNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private List<DLCOOKLBLCK> FKBBNLLHGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private GameObject DBAPBIEIKDO;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4A163D0", Offset = "0x4A14BD0", VA = "0x184A163D0")]
	public static DAFNGKNMFML EHAAIDNDAEJ(JOPBHKEJEOL KBMGAHFAOOA, PFBIEHCLEAI IHJCACPANCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A17070", Offset = "0x4A15870", VA = "0x184A17070")]
	private DAFNGKNMFML(JOPBHKEJEOL KBMGAHFAOOA, PFBIEHCLEAI IHJCACPANCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A15FB0", Offset = "0x4A147B0", VA = "0x184A15FB0")]
	public void BMLOFNJHHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A16680", Offset = "0x4A14E80", VA = "0x184A16680")]
	[IteratorStateMachine(typeof(KPGFIEDIKOG))]
	public IEnumerable<Renderer> KFFIFBJCEDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A16720", Offset = "0x4A14F20", VA = "0x184A16720", Slot = "4")]
	public void OLHJMMJAECB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A166F0", Offset = "0x4A14EF0", VA = "0x184A166F0")]
	private void LBGGOMGKNOI(Vector3 NIAPOPKMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4A164B0", Offset = "0x4A14CB0", VA = "0x184A164B0")]
	public void GNNANHCHACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DLCOOKLBLCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct FFDLHBGHJJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CDHGHEMGMAO OKNCLILGNEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Transform JDAKHCEGHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int MEIOINJEMBG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ICHKKFLABMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public DLCOOKLBLCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public HPGKNDLHNMK lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<FFDLHBGHJJD> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public ICHKKFLABMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HPJJOKGMAGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public HJLLFEBGKOE combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ICHKKFLABMF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public HPJJOKGMAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4A19B60", Offset = "0x4A18360", VA = "0x184A19B60")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4A19BD0", Offset = "0x4A183D0", VA = "0x184A19BD0")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4A19C10", Offset = "0x4A18410", VA = "0x184A19C10")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int[] IHGLNJINNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private IIFCCJCNIHM AJFFMNEJKMF;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static Matrix4x4 KCAOHHIBAAJ;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Mesh CCNGPKIGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x521490", Offset = "0x51FC90", VA = "0x180521490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ELEFGNJPADP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5AD670", Offset = "0x5ABE70", VA = "0x1805AD670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6735D0", Offset = "0x671DD0", VA = "0x1806735D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4A174C0", Offset = "0x4A15CC0", VA = "0x184A174C0")]
	public void BNJJHNHIBDE(List<Transform> DACPLNLOPLK, Matrix4x4[] LBHAHFEFFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4A17840", Offset = "0x4A16040", VA = "0x184A17840")]
	public static List<DLCOOKLBLCK> OGMFEGPOBPM(List<NGGPPEICKMF> NLGCMLBOINI, HPGKNDLHNMK KILPIDLBIPL, Bounds OLPLEHOCCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4A17140", Offset = "0x4A15940", VA = "0x184A17140")]
	private JobHandle BJFLHCPBHKB(HJLLFEBGKOE KABPIEHLBJK, int OGFEPKAFLKO, int GPELDCLJDEI, HPGKNDLHNMK KILPIDLBIPL, List<FFDLHBGHJJD> DOOKBHADGJC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4A17740", Offset = "0x4A15F40", VA = "0x184A17740")]
	private void JNDMDJAKDCP(List<FFDLHBGHJJD> DOOKBHADGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4A17F10", Offset = "0x4A16710", VA = "0x184A17F10")]
	private DLCOOKLBLCK(List<FFDLHBGHJJD> DOOKBHADGJC, int OGFEPKAFLKO, int GPELDCLJDEI, HPGKNDLHNMK KILPIDLBIPL, Bounds OLPLEHOCCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4A176C0", Offset = "0x4A15EC0", VA = "0x184A176C0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private MaterialPropertyBlock BGDEKBJJJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private DLCOOKLBLCK NMNGNBOGDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<Transform> IBGLFGNOFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private RenderTexture LDJKPIIFMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private ComputeBuffer FJKOOBNKAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private ComputeShader GGHHCHPDGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private Matrix4x4[] ONIIJMEMMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int HANNCCLEJHM;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public MeshRenderer NDGFHJIOEIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x5214A0", Offset = "0x51FCA0", VA = "0x1805214A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int OCMJBLNHDDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x4A1FE90", Offset = "0x4A1E690", VA = "0x184A1FE90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4A1F670", Offset = "0x4A1DE70", VA = "0x184A1F670")]
		public static List<SkinnedShapeRenderer> Create(GameObject MHMECKKACOC, List<DLCOOKLBLCK> EBGONCJIDCJ, List<Transform> IBGLFGNOFMG, Material PNEKGAFLGJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4A1F880", Offset = "0x4A1E080", VA = "0x184A1F880")]
		public void Init(DLCOOKLBLCK NMNGNBOGDJB, List<Transform> IBGLFGNOFMG, Material PNEKGAFLGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4A1FD70", Offset = "0x4A1E570", VA = "0x184A1FD70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4A1FCE0", Offset = "0x4A1E4E0", VA = "0x184A1FCE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4A1FCA0", Offset = "0x4A1E4A0", VA = "0x184A1FCA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4A1FE00", Offset = "0x4A1E600", VA = "0x184A1FE00")]
		private void PMFNAABCMNK(ScriptableRenderContext DAABJFEBLJF, Camera[] MGOMBOCAFKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4A1F320", Offset = "0x4A1DB20", VA = "0x184A1F320")]
		private void BNJJHNHIBDE(CommandBuffer KCIHKHEDBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xD192F0", Offset = "0xD17AF0", VA = "0x180D192F0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LPHGEELGLMB
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static byte[] GPJANLJHPME;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static int PPCKGPBBLCP;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int JEFPLDJMJDE;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static BigInteger ABCMBKBOAFJ;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LPHGEELGLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A1D3D0", Offset = "0x4A1BBD0", VA = "0x184A1D3D0")]
	private static string EOENAFMMDNF(byte[] DOMNMKJGGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4A1D4D0", Offset = "0x4A1BCD0", VA = "0x184A1D4D0")]
	public static string OPCCKPNHHLB(byte[] MIIBCOAJABM, bool NJCHAECDCAB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
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
