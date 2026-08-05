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
public enum LLEFMMLFJCB
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
public static class DCGPJJABIGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static HashSet<LLEFMMLFJCB> KCHHJGFHCIJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x56BB520", Offset = "0x56BA520", VA = "0x1856BB520")]
	static DCGPJJABIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x56BB520", Offset = "0x56BA520", VA = "0x1856BB520")]
	[NFCOBPDHPIL]
	private static void AICHPOAHICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x56BB640", Offset = "0x56BA640", VA = "0x1856BB640")]
	public static bool KFKEAGPMPAI(this LLEFMMLFJCB FOLDJHLDNIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IIMLDMJEFLJ
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
	WORN_WOOD = 29,
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
public enum HONBLILNBOH
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
public enum HHINIDCODHG
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
	ScopeRoot,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	HoverXRay,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	ContainerHover,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	PivotHover
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BPJNBOAKIPC
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Circuit,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	CornerMove,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Pivot
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HCOJBNEKMAH : HOGPMLNLBMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const byte KNBCCFBPLGP = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private byte MPHIHAIPBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<SkinnedShapeRenderer>[] PIECBAPBJPK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IGNEEDDMIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CD0", Offset = "0x5E4CD0", VA = "0x1805E5CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x666A10", Offset = "0x665A10", VA = "0x180666A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KIOEGHFEDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CC0", Offset = "0x5E4CC0", VA = "0x1805E5CC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7401B0", Offset = "0x73F1B0", VA = "0x1807401B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float FCKKNIFJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1180100", Offset = "0x117F100", VA = "0x181180100", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1180460", Offset = "0x117F460", VA = "0x181180460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DFMIDEHNNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1033220", Offset = "0x1032220", VA = "0x181033220", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1115560", Offset = "0x1114560", VA = "0x181115560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> INDHADFAPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x56BD0C0", Offset = "0x56BC0C0", VA = "0x1856BD0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> OOOHGEPEIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4600830", Offset = "0x45FF830", VA = "0x184600830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject DFNBLBAHNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte LOAMDIKAFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x56BD070", Offset = "0x56BC070", VA = "0x1856BD070", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x56BD360", Offset = "0x56BC360", VA = "0x1856BD360")]
	public HCOJBNEKMAH(List<PMDPIIMPCGN> JEIMOIDKDDG, List<PMDPIIMPCGN> AIFBHCIIFBB, List<OHJKLNPKNGO> MDPLNEAHAAC, Material BGOGBNDAHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x56BD250", Offset = "0x56BC250", VA = "0x1856BD250")]
	private int MAPIDDEEPCF(List<PMDPIIMPCGN> DBDGCOOHOEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x56BCDE0", Offset = "0x56BBDE0", VA = "0x1856BCDE0")]
	private void CNMFPNLKLCG(int LCGGNBEMKMB, bool OAGBGICODEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x56BD120", Offset = "0x56BC120", VA = "0x1856BD120")]
	public void KMLPHDMCBAF(Vector3 EGADPMHMFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x56BCF40", Offset = "0x56BBF40", VA = "0x1856BCF40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x56BD210", Offset = "0x56BC210", VA = "0x1856BD210")]
	public void LCBEOGMNGBF(Transform BEBOAALBOHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BFGIGHCADFM : OKFOBCOAGKB, KHPGOAHIECO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JBIKLGJPEHH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public BFGIGHCADFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
		[DebuggerHidden]
		public JBIKLGJPEHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x56C0EC0", Offset = "0x56BFEC0", VA = "0x1856C0EC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x56C0A10", Offset = "0x56BFA10", VA = "0x1856C0A10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x56C1040", Offset = "0x56C0040", VA = "0x1856C1040")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x56C1080", Offset = "0x56C0080", VA = "0x1856C1080")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x56C10D0", Offset = "0x56C00D0", VA = "0x1856C10D0")]
		private void <>m__Finally3()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x56C0E70", Offset = "0x56BFE70", VA = "0x1856C0E70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x56C0DD0", Offset = "0x56BFDD0", VA = "0x1856C0DD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x56C0DD0", Offset = "0x56BFDD0", VA = "0x1856C0DD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DINCHNOJCLN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public BFGIGHCADFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
		[DebuggerHidden]
		public DINCHNOJCLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x56BBA60", Offset = "0x56BAA60", VA = "0x1856BBA60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x56BB6C0", Offset = "0x56BA6C0", VA = "0x1856BB6C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x56BBB80", Offset = "0x56BAB80", VA = "0x1856BBB80")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x56BBBD0", Offset = "0x56BABD0", VA = "0x1856BBBD0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x56BBA10", Offset = "0x56BAA10", VA = "0x1856BBA10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x56BB970", Offset = "0x56BA970", VA = "0x1856BB970", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x56BB970", Offset = "0x56BA970", VA = "0x1856BB970", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly PJDAPMMBGBM AMGNHICOFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly List<GANDNOJIEJF> HIBGMLGMMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private List<ClusterMeshRenderer> DLDHPNDMFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private BatchedMeshRenderer JFCOLEEHMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool JJEGLFABLBM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<MGEOPACMCHB> PLDKJDHMMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EGEMBGBNIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x56BA270", Offset = "0x56B9270", VA = "0x1856BA270", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OHJKLNPKNGO CEBPFJKKNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x56BA940", Offset = "0x56B9940", VA = "0x1856BA940", Slot = "7")]
		get
		{
			return default(OHJKLNPKNGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> JHEMBHNGJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6010", Offset = "0x5E5010", VA = "0x1805E6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6020", Offset = "0x5E5020", VA = "0x1805E6020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x56BB490", Offset = "0x56BA490", VA = "0x1856BB490")]
	public BFGIGHCADFM(PJDAPMMBGBM JEJGBICCBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x56BA3F0", Offset = "0x56B93F0", VA = "0x1856BA3F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x56BB330", Offset = "0x56BA330", VA = "0x1856BB330")]
	public void PPCBFHPPBHE(GANDNOJIEJF KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x56BA2B0", Offset = "0x56B92B0", VA = "0x1856BA2B0")]
	public void DKCILJPFPEA(GANDNOJIEJF KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x56BA420", Offset = "0x56B9420", VA = "0x1856BA420", Slot = "4")]
	public void IHCNDKLNNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x56BB000", Offset = "0x56BA000", VA = "0x1856BB000")]
	public void LNGAPHKLFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x56BB200", Offset = "0x56BA200", VA = "0x1856BB200")]
	private void OHDJPNJFOHK(List<GANDNOJIEJF> HIBGMLGMMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x56BB0B0", Offset = "0x56BA0B0", VA = "0x1856BB0B0")]
	private static Material MBFHCAONJIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x56BB1B0", Offset = "0x56BA1B0", VA = "0x1856BB1B0")]
	private void OHDJPNJFOHK(GANDNOJIEJF KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x56BA320", Offset = "0x56B9320", VA = "0x1856BA320")]
	private void DMMBNCIEJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x56BAA10", Offset = "0x56B9A10", VA = "0x1856BAA10")]
	public void LFACPOJFBOK(bool DAGOJPGBMLE, bool AEJLHIPFPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56BB120", Offset = "0x56BA120", VA = "0x1856BB120")]
	protected void OABBBGHJOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x56BAF90", Offset = "0x56B9F90", VA = "0x1856BAF90")]
	[IteratorStateMachine(typeof(JBIKLGJPEHH))]
	public IEnumerable<Renderer> LHJENIODBIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x56BB420", Offset = "0x56BA420", VA = "0x1856BB420")]
	[IteratorStateMachine(typeof(DINCHNOJCLN))]
	public IEnumerable<Renderer> PPIEIOLKMLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class GNFIJHJOLFI : GANDNOJIEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly BGLGILFDBGJ IIALJCHDFMP;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x56BCD90", Offset = "0x56BBD90", VA = "0x1856BCD90")]
	public GNFIJHJOLFI(BFGIGHCADFM JJKPMHEEPII, BGLGILFDBGJ JEJGBICCBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x56BCBB0", Offset = "0x56BBBB0", VA = "0x1856BCBB0", Slot = "13")]
	public override int MAPIDDEEPCF(OKPEIMECIFD LFLCDEHCKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x56BC9D0", Offset = "0x56BB9D0", VA = "0x1856BC9D0", Slot = "14")]
	public override int KOHCEOPCOMD(OKPEIMECIFD LFLCDEHCKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x56BC300", Offset = "0x56BB300", VA = "0x1856BC300", Slot = "15")]
	public override void GAKEEANDEPH(OKPEIMECIFD LFLCDEHCKMP, MIHHEFJFMAI NKCMADMIDOF, int DCPOPAAKCDN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MEFBGEPNGJL : global::CKDCIHLAPNJ<MEFBGEPNGJL>, GHELMGKGIIN, IEquatable<MEFBGEPNGJL>
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KBBNJEDOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x91EAC0", Offset = "0x91DAC0", VA = "0x18091EAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ICOAIKCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8A44E0", Offset = "0x8A34E0", VA = "0x1808A44E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8F82D0", Offset = "0x8F72D0", VA = "0x1808F82D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NFKGIEPPODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x56C39C0", Offset = "0x56C29C0", VA = "0x1856C39C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x45E4760", Offset = "0x45E3760", VA = "0x1845E4760", Slot = "8")]
	public bool Equals(MEFBGEPNGJL IJDAJAEAAKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD6B5F0", Offset = "0xD6A5F0", VA = "0x180D6B5F0")]
	public static bool ABFAIBNGIFN(MEFBGEPNGJL KKHMNCLOHHK, MEFBGEPNGJL GMPKOOIGMDG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x333DA40", Offset = "0x333CA40", VA = "0x18333DA40")]
	public static bool BHAIMGMLJDO(MEFBGEPNGJL KKHMNCLOHHK, MEFBGEPNGJL GMPKOOIGMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x56C3A00", Offset = "0x56C2A00", VA = "0x1856C3A00", Slot = "0")]
	public override bool Equals(object MDAEAKFNGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FJANIAGBDEE
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Static,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Selected,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	SkinnedBone
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PJDAPMMBGBM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OHJKLNPKNGO FKKKBEMGBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FJANIAGBDEE EGIKMEJLMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NOAFJMJDOFI : global::CKDCIHLAPNJ<NOAFJMJDOFI>, GHELMGKGIIN, IEquatable<NOAFJMJDOFI>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int KBBNJEDOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x91EAC0", Offset = "0x91DAC0", VA = "0x18091EAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int ICOAIKCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8A44E0", Offset = "0x8A34E0", VA = "0x1808A44E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8F82D0", Offset = "0x8F72D0", VA = "0x1808F82D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NFKGIEPPODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x56C3B60", Offset = "0x56C2B60", VA = "0x1856C3B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x45E4760", Offset = "0x45E3760", VA = "0x1845E4760", Slot = "8")]
	public bool Equals(NOAFJMJDOFI IJDAJAEAAKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xD6B5F0", Offset = "0xD6A5F0", VA = "0x180D6B5F0")]
	public static bool ABFAIBNGIFN(NOAFJMJDOFI KKHMNCLOHHK, NOAFJMJDOFI GMPKOOIGMDG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x333DA40", Offset = "0x333CA40", VA = "0x18333DA40")]
	public static bool BHAIMGMLJDO(NOAFJMJDOFI KKHMNCLOHHK, NOAFJMJDOFI GMPKOOIGMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x56C3BA0", Offset = "0x56C2BA0", VA = "0x1856C3BA0", Slot = "0")]
	public override bool Equals(object MDAEAKFNGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FIPHIHDJACL
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	OHJKLNPKNGO FKKKBEMGBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float FIHOIAKBALD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Vector3 NLNOJHFGJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	LLEFMMLFJCB LNFMIEJFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IIMLDMJEFLJ LADOGNBMJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HFONKDLLEBD : FIPHIHDJACL
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JBDPINCBEOM PGNPLGMGDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LIMCHDHHGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BGLGILFDBGJ : FIPHIHDJACL
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool GMEPEJFHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CKLAKBHFHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float HPMINIJBHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int BKJNDLPBNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool DFMNACHPENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int CLDEMLDCEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<EIJPBBOPKEB> GetNativeCurvePoints();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JCEIMFBPPLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEOMMBIEKGG(MEFBGEPNGJL JJKPMHEEPII, HHINIDCODHG CPMACHEHNLM);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEOMMBIEKGG(NOAFJMJDOFI KMKOADFJINI, HHINIDCODHG CPMACHEHNLM);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KEIHLKCFJFF(NOAFJMJDOFI KMKOADFJINI);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMBEEHDCLGI(NOAFJMJDOFI KMKOADFJINI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIHKJMDBDEC();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IDIEIPFPNNK();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AAAJKDODBMB(HHINIDCODHG GLKKDGLKBMK);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CJAMAEFKKHB(MEFBGEPNGJL JJKPMHEEPII);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CJAMAEFKKHB(NOAFJMJDOFI KMKOADFJINI);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AJEGCLGLDGM(MEFBGEPNGJL JJKPMHEEPII, BPJNBOAKIPC GLKKDGLKBMK);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AJEGCLGLDGM(NOAFJMJDOFI KMKOADFJINI, BPJNBOAKIPC GLKKDGLKBMK);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EDMHFDKOCDD(NOAFJMJDOFI KMKOADFJINI);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MBPGMEOPMPI(NOAFJMJDOFI KMKOADFJINI);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NKPDHBGDJOM();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KMAAAOPAFAJ();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IFJOENDHEJN(BPJNBOAKIPC GLKKDGLKBMK);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EFIFHAGCJJK(MEFBGEPNGJL JJKPMHEEPII, Vector3 PLNAAOIHDEH, Vector3 IJPIMPOCGGH, Vector3 BACMPOFHOOI, float IHLDGPEONNI, float HAHDDJMGMPC, IReadOnlyList<Camera> AOMKDABMFLO, HONBLILNBOH BHNFKEEMCGL);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EFIFHAGCJJK(NJJFMMLJAHI MGDLGOEMDFN, Vector3 PLNAAOIHDEH, Vector3 IJPIMPOCGGH, Vector3 BACMPOFHOOI, float IHLDGPEONNI, float HAHDDJMGMPC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GDJOKFELAEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MEFBGEPNGJL IBCANKFCMPB(PJDAPMMBGBM JEJGBICCBLN);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNDPKLIBEIJ(MEFBGEPNGJL JJKPMHEEPII);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOCMOLLOFLP(MEFBGEPNGJL JJKPMHEEPII);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NOAFJMJDOFI FPFCOCJFLID(MEFBGEPNGJL JJKPMHEEPII, HFONKDLLEBD JEJGBICCBLN);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NOAFJMJDOFI LHLMIHNGAND(MEFBGEPNGJL JJKPMHEEPII, BGLGILFDBGJ JEJGBICCBLN);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPCBPNFBBEP(NOAFJMJDOFI KMKOADFJINI);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INCCBDJDLMC(NOAFJMJDOFI KMKOADFJINI);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NJJFMMLJAHI IIBPLJJKFHI(KDFOGAKKNFF JEJGBICCBLN);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HMEOPCNANEE(NJJFMMLJAHI MGDLGOEMDFN);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NLLHAPBNKEJ(NJJFMMLJAHI MGDLGOEMDFN);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FIKOKBLMAKH OMPFPBDECHN(OHJKLNPKNGO FLOKABIHFCN, IEnumerable<NOAFJMJDOFI> HIBGMLGMMMB, int CHDKEAALMJN);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEnumerable<Renderer> OIEONGOHKCI(MEFBGEPNGJL JJKPMHEEPII);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NJJFMMLJAHI : global::CKDCIHLAPNJ<NJJFMMLJAHI>, GHELMGKGIIN, IEquatable<NJJFMMLJAHI>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int KBBNJEDOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x91EAC0", Offset = "0x91DAC0", VA = "0x18091EAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int ICOAIKCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A44E0", Offset = "0x8A34E0", VA = "0x1808A44E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8F82D0", Offset = "0x8F72D0", VA = "0x1808F82D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NFKGIEPPODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x56C3A90", Offset = "0x56C2A90", VA = "0x1856C3A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x45E4760", Offset = "0x45E3760", VA = "0x1845E4760", Slot = "8")]
	public bool Equals(NJJFMMLJAHI IJDAJAEAAKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xD6B5F0", Offset = "0xD6A5F0", VA = "0x180D6B5F0")]
	public static bool ABFAIBNGIFN(NJJFMMLJAHI KKHMNCLOHHK, NJJFMMLJAHI GMPKOOIGMDG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x333DA40", Offset = "0x333CA40", VA = "0x18333DA40")]
	public static bool BHAIMGMLJDO(NJJFMMLJAHI KKHMNCLOHHK, NJJFMMLJAHI GMPKOOIGMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x56C3AD0", Offset = "0x56C2AD0", VA = "0x1856C3AD0", Slot = "0")]
	public override bool Equals(object MDAEAKFNGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KDFOGAKKNFF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int AHDJDFKJJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Transform PKBFGAMJEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool BFGCHONOECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEFBGEPNGJL GetBone(int IKIHONFJPGM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IsPartOfFirstPersonSkin(int IKIHONFJPGM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class JIFPINJMODL : GANDNOJIEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly HFONKDLLEBD HPCLLNPNFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int[] IDEDGEFOCPI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override MIDEBJGHMKH GHIBPHDLOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x56C1C60", Offset = "0x56C0C60", VA = "0x1856C1C60", Slot = "12")]
		get
		{
			return default(MIDEBJGHMKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 GOIFKHMEEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x56C26F0", Offset = "0x56C16F0", VA = "0x1856C26F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x56BCD90", Offset = "0x56BBD90", VA = "0x1856BCD90")]
	public JIFPINJMODL(BFGIGHCADFM JJKPMHEEPII, HFONKDLLEBD JEJGBICCBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x56C2060", Offset = "0x56C1060", VA = "0x1856C2060", Slot = "11")]
	public override bool IJEHENHHBHD(OHJKLNPKNGO JJKPMHEEPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x56C2650", Offset = "0x56C1650", VA = "0x1856C2650", Slot = "13")]
	public override int MAPIDDEEPCF(OKPEIMECIFD LFLCDEHCKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x56C25B0", Offset = "0x56C15B0", VA = "0x1856C25B0", Slot = "14")]
	public override int KOHCEOPCOMD(OKPEIMECIFD LFLCDEHCKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x56C1120", Offset = "0x56C0120", VA = "0x1856C1120")]
	private int EFMOKBKILJK(OKPEIMECIFD LFLCDEHCKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x56C13A0", Offset = "0x56C03A0", VA = "0x1856C13A0", Slot = "15")]
	public override void GAKEEANDEPH(OKPEIMECIFD LFLCDEHCKMP, MIHHEFJFMAI NKCMADMIDOF, int DCPOPAAKCDN = -1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JOCAFJLNDMO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMACOACBAND(BPJNBOAKIPC GLKKDGLKBMK, Renderer IGBNOJAADBJ, int EFAGJHPIANB);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFFKHHBEHBK(Renderer IGBNOJAADBJ, HONBLILNBOH BHNFKEEMCGL, Vector3 PLNAAOIHDEH, Vector3 IJPIMPOCGGH, Vector3 BACMPOFHOOI, float IHLDGPEONNI, float HAHDDJMGMPC, float NNIMEMBNPIH = -1f, [Optional] Color? IJIJEAAHDCH, [Optional] IReadOnlyList<Camera> KAJAGLFNMDP);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPKNEGAJJCE(Renderer IGBNOJAADBJ, int EFAGJHPIANB);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ACANNEFANNI();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJCAHIDHIFJ(int JOIJHHFCJCB, HHINIDCODHG GLKKDGLKBMK, Renderer IGBNOJAADBJ, int EFAGJHPIANB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HLNHEBHFHDD : JCEIMFBPPLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class AFIKLPKDLIE : global::PFPNLNFJAIJ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x56BA060", Offset = "0x56B9060", VA = "0x1856BA060")]
		public AFIKLPKDLIE(string MBHNCPMPIFB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly JOCAFJLNDMO KLCCFCEGKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly IIEDLAKPKON FMBNFNFBMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private MeshRenderer DBDAMDEOIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private AFIKLPKDLIE PJOFBGLLDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool ILFHBDJPHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private MeshRenderer OGLKNACGBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AFIKLPKDLIE EFHPDJJENPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool LGIGPFMBFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private MeshRenderer NJOIIOAFOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AFIKLPKDLIE OEADODFFDLE;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F8990", Offset = "0x5F7990", VA = "0x1805F8990")]
	public HLNHEBHFHDD(JOCAFJLNDMO BJAFKPCHEGF, IIEDLAKPKON FMBNFNFBMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x56BF2B0", Offset = "0x56BE2B0", VA = "0x1856BF2B0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x56BFFC0", Offset = "0x56BEFC0", VA = "0x1856BFFC0")]
	private void IBOKGFBDGKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x56BFDF0", Offset = "0x56BEDF0", VA = "0x1856BFDF0", Slot = "4")]
	public void FEOMMBIEKGG(MEFBGEPNGJL JJKPMHEEPII, HHINIDCODHG CPMACHEHNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x56BFC20", Offset = "0x56BEC20", VA = "0x1856BFC20", Slot = "5")]
	public void FEOMMBIEKGG(NOAFJMJDOFI KMKOADFJINI, HHINIDCODHG CPMACHEHNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x56C0450", Offset = "0x56BF450", VA = "0x1856C0450", Slot = "6")]
	public void KEIHLKCFJFF(NOAFJMJDOFI KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x56C06E0", Offset = "0x56BF6E0", VA = "0x1856C06E0", Slot = "7")]
	public void NMBEEHDCLGI(NOAFJMJDOFI KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x56C0260", Offset = "0x56BF260", VA = "0x1856C0260", Slot = "8")]
	public void IIHKJMDBDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x10BA080", Offset = "0x10B9080", VA = "0x1810BA080", Slot = "9")]
	public void IDIEIPFPNNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x56BE880", Offset = "0x56BD880", VA = "0x1856BE880", Slot = "10")]
	public void AAAJKDODBMB(HHINIDCODHG CPMACHEHNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x56BF110", Offset = "0x56BE110", VA = "0x1856BF110", Slot = "11")]
	public void CJAMAEFKKHB(MEFBGEPNGJL JJKPMHEEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x56BEE90", Offset = "0x56BDE90", VA = "0x1856BEE90", Slot = "12")]
	public void CJAMAEFKKHB(NOAFJMJDOFI KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x56BECF0", Offset = "0x56BDCF0", VA = "0x1856BECF0", Slot = "13")]
	public void AJEGCLGLDGM(MEFBGEPNGJL JJKPMHEEPII, BPJNBOAKIPC GLKKDGLKBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x56BE9B0", Offset = "0x56BD9B0", VA = "0x1856BE9B0", Slot = "14")]
	public void AJEGCLGLDGM(NOAFJMJDOFI KMKOADFJINI, BPJNBOAKIPC GLKKDGLKBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x56C06A0", Offset = "0x56BF6A0", VA = "0x1856C06A0", Slot = "17")]
	public void NKPDHBGDJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x56BF480", Offset = "0x56BE480", VA = "0x1856BF480", Slot = "15")]
	public void EDMHFDKOCDD(NOAFJMJDOFI KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x56C0610", Offset = "0x56BF610", VA = "0x1856C0610", Slot = "16")]
	public void MBPGMEOPMPI(NOAFJMJDOFI KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xEE5B10", Offset = "0xEE4B10", VA = "0x180EE5B10", Slot = "18")]
	public void KMAAAOPAFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x56C0170", Offset = "0x56BF170", VA = "0x1856C0170", Slot = "19")]
	public void IFJOENDHEJN(BPJNBOAKIPC GLKKDGLKBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x56C02A0", Offset = "0x56BF2A0", VA = "0x1856C02A0")]
	private void JBNOGJFJOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x56BEB50", Offset = "0x56BDB50", VA = "0x1856BEB50")]
	public void AJEGCLGLDGM(NOAFJMJDOFI KMKOADFJINI, BPJNBOAKIPC GLKKDGLKBMK, bool JADMDBBCFCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x56C0550", Offset = "0x56BF550", VA = "0x1856C0550")]
	private void KMACOACBAND(BPJNBOAKIPC GLKKDGLKBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x56BF8F0", Offset = "0x56BE8F0", VA = "0x1856BF8F0", Slot = "20")]
	public void EFIFHAGCJJK(MEFBGEPNGJL JJKPMHEEPII, Vector3 PLNAAOIHDEH, Vector3 IJPIMPOCGGH, Vector3 BACMPOFHOOI, float IHLDGPEONNI, float HAHDDJMGMPC, IReadOnlyList<Camera> AOMKDABMFLO, HONBLILNBOH BHNFKEEMCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x56BF520", Offset = "0x56BE520", VA = "0x1856BF520", Slot = "21")]
	public void EFIFHAGCJJK(NJJFMMLJAHI MGDLGOEMDFN, Vector3 PLNAAOIHDEH, Vector3 IJPIMPOCGGH, Vector3 BACMPOFHOOI, float IHLDGPEONNI, float HAHDDJMGMPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class GANDNOJIEJF : KPKDAGINBKI, MGEOPACMCHB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly BFGIGHCADFM DFNBLBAHNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	protected Bounds HMGNMODOGOO;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Bounds KONAEMACMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1A74060", Offset = "0x1A73060", VA = "0x181A74060", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public virtual MIDEBJGHMKH GHIBPHDLOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x56BC270", Offset = "0x56BB270", VA = "0x1856BC270", Slot = "12")]
		get
		{
			return default(MIDEBJGHMKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x71A660", Offset = "0x719660", VA = "0x18071A660")]
	protected GANDNOJIEJF(BFGIGHCADFM JJKPMHEEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x56BC200", Offset = "0x56BB200", VA = "0x1856BC200", Slot = "10")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "11")]
	public virtual bool IJEHENHHBHD(OHJKLNPKNGO JJKPMHEEPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract int MAPIDDEEPCF(OKPEIMECIFD LFLCDEHCKMP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract int KOHCEOPCOMD(OKPEIMECIFD LFLCDEHCKMP);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract void GAKEEANDEPH(OKPEIMECIFD LFLCDEHCKMP, MIHHEFJFMAI NKCMADMIDOF, int DCPOPAAKCDN = -1);
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
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x56C6330", Offset = "0x56C5330", VA = "0x1856C6330")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum JBDPINCBEOM
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Cylinder,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Wedge,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Pyramid,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HalfSphere,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Cone,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Pipe,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Donut,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HalfPipe,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Diamond,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Mound,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	LegacyBox,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class LBALDBFNIOB
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class BCOFKIKDPID : IEnumerable<DNOBPEALJFJ>, IEnumerable, IEnumerator<DNOBPEALJFJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private DNOBPEALJFJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private DNOBPEALJFJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
		[DebuggerHidden]
		public BCOFKIKDPID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x56BA0B0", Offset = "0x56B90B0", VA = "0x1856BA0B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x56BA220", Offset = "0x56B9220", VA = "0x1856BA220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x56BA190", Offset = "0x56B9190", VA = "0x1856BA190", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DNOBPEALJFJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x56BA190", Offset = "0x56B9190", VA = "0x1856BA190", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const int KAEHCDHJNHC = 3;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static DNOBPEALJFJ[][] OBGODFFIBLI;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static PNFACPAKALD HJJAFMPNBBP;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static ShapeRendererConfig GDONPDPINFP;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static ComputeShader DJPLHJJEFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x56C3270", Offset = "0x56C2270", VA = "0x1856C3270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static SkinnedShapeRenderer ANFFILEILIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x56C3710", Offset = "0x56C2710", VA = "0x1856C3710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x56C3190", Offset = "0x56C2190", VA = "0x1856C3190")]
	public static Mesh ICGGANINNHD(JBDPINCBEOM DFGNFAEGFOM, int LFLCDEHCKMP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x56C3700", Offset = "0x56C2700", VA = "0x1856C3700")]
	public static int OINJCJEEPMK(JBDPINCBEOM DFGNFAEGFOM, int LFLCDEHCKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x56C2AD0", Offset = "0x56C1AD0", VA = "0x1856C2AD0")]
	public static PNFACPAKALD CGNGIKGDJAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x56C2A70", Offset = "0x56C1A70", VA = "0x1856C2A70")]
	[IteratorStateMachine(typeof(BCOFKIKDPID))]
	private static IEnumerable<DNOBPEALJFJ> BACIKIPNIHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x56C2C30", Offset = "0x56C1C30", VA = "0x1856C2C30")]
	public static DNOBPEALJFJ GDAAEFFFDNC(JBDPINCBEOM DFGNFAEGFOM, int LFLCDEHCKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x56C3250", Offset = "0x56C2250", VA = "0x1856C3250")]
	public static bool LNPNEFALKFP(this JBDPINCBEOM DFGNFAEGFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x56C3780", Offset = "0x56C2780", VA = "0x1856C3780")]
	public static void PIMFMGGMOIO(JBDPINCBEOM DFGNFAEGFOM, float3 MDEEIJILPOH, out CJHIMPOAPIP LEPLIOALMFC, out float3 MDBIFCLGFFK, out float PJLAPPALNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x56C32E0", Offset = "0x56C22E0", VA = "0x1856C32E0")]
	public static void MMBIGMDCBPE(Vector3 MDEEIJILPOH, JBDPINCBEOM DFGNFAEGFOM, out Vector3 MDBIFCLGFFK, out float PJLAPPALNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x56C2C20", Offset = "0x56C1C20", VA = "0x1856C2C20")]
	[NGEHENKPAPD(LHOOELNKCGI.ExitingPlayMode, 0)]
	private static void CJOHGNIDPHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x56C2F70", Offset = "0x56C1F70", VA = "0x1856C2F70")]
	[NGEHENKPAPD(LHOOELNKCGI.ExitingPlayMode, 0)]
	private static void GHFKLBIFHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OKNPKHKLLPD
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool AIBPJOFMOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material PPADIICFMAO();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MBFHCAONJIB();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material KLAMMANNLJL();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PMLFELHOHIN(LLEFMMLFJCB CFFBDBDFNDJ);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ADAJFKPMJDI(IIMLDMJEFLJ NHPKGKJAKIN);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BACHEBMONBO(GameObject MDAEAKFNGDG);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDJGBGIBGPP(GameObject MDAEAKFNGDG, bool MGKHAPPIMFB);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public interface IIEDLAKPKON
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BFGIGHCADFM AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GANDNOJIEJF AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OOPJILKFJGC AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class HKHOMEMLBMC : GDJOKFELAEK, IDisposable, IIEDLAKPKON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly global::HIFNABHKLBE<MEFBGEPNGJL, BFGIGHCADFM> DBDJIADNMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly global::HIFNABHKLBE<NOAFJMJDOFI, GANDNOJIEJF> HIBGMLGMMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly global::HIFNABHKLBE<NJJFMMLJAHI, OOPJILKFJGC> PCLKLFPFCNJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static OKNPKHKLLPD LHBBHJOLLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x56BE3D0", Offset = "0x56BD3D0", VA = "0x1856BE3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x56BD700", Offset = "0x56BC700", VA = "0x1856BD700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BFGIGHCADFM AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x56BDBE0", Offset = "0x56BCBE0", VA = "0x1856BDBE0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public GANDNOJIEJF AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x56BDCA0", Offset = "0x56BCCA0", VA = "0x1856BDCA0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public OOPJILKFJGC AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x56BDC40", Offset = "0x56BCC40", VA = "0x1856BDC40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x56BE410", Offset = "0x56BD410", VA = "0x1856BE410")]
	public HKHOMEMLBMC(OKNPKHKLLPD BJAFKPCHEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x56BD690", Offset = "0x56BC690", VA = "0x1856BD690", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x56BD900", Offset = "0x56BC900", VA = "0x1856BD900", Slot = "4")]
	public MEFBGEPNGJL IBCANKFCMPB(PJDAPMMBGBM JEJGBICCBLN)
	{
		return default(MEFBGEPNGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x56BD750", Offset = "0x56BC750", VA = "0x1856BD750", Slot = "5")]
	public void FNDPKLIBEIJ(MEFBGEPNGJL JJKPMHEEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x56BDEC0", Offset = "0x56BCEC0", VA = "0x1856BDEC0", Slot = "6")]
	public void NOCMOLLOFLP(MEFBGEPNGJL JJKPMHEEPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x56BDF40", Offset = "0x56BCF40", VA = "0x1856BDF40", Slot = "15")]
	public IEnumerable<Renderer> OIEONGOHKCI(MEFBGEPNGJL JJKPMHEEPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x56BD7B0", Offset = "0x56BC7B0", VA = "0x1856BD7B0", Slot = "7")]
	public NOAFJMJDOFI FPFCOCJFLID(MEFBGEPNGJL JJKPMHEEPII, HFONKDLLEBD JEJGBICCBLN)
	{
		return default(NOAFJMJDOFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x56BDD00", Offset = "0x56BCD00", VA = "0x1856BDD00", Slot = "8")]
	public NOAFJMJDOFI LHLMIHNGAND(MEFBGEPNGJL JJKPMHEEPII, BGLGILFDBGJ JEJGBICCBLN)
	{
		return default(NOAFJMJDOFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x56BDB70", Offset = "0x56BCB70", VA = "0x1856BDB70", Slot = "10")]
	public void INCCBDJDLMC(NOAFJMJDOFI KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x56BDDF0", Offset = "0x56BCDF0", VA = "0x1856BDDF0", Slot = "9")]
	public void LPCBPNFBBEP(NOAFJMJDOFI KMKOADFJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x56BD9E0", Offset = "0x56BC9E0", VA = "0x1856BD9E0", Slot = "11")]
	public NJJFMMLJAHI IIBPLJJKFHI(KDFOGAKKNFF JEJGBICCBLN)
	{
		return default(NJJFMMLJAHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x56BDE50", Offset = "0x56BCE50", VA = "0x1856BDE50", Slot = "13")]
	public void NLLHAPBNKEJ(NJJFMMLJAHI MGDLGOEMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x56BD8A0", Offset = "0x56BC8A0", VA = "0x1856BD8A0", Slot = "12")]
	public void HMEOPCNANEE(NJJFMMLJAHI MGDLGOEMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x56BE000", Offset = "0x56BD000", VA = "0x1856BE000", Slot = "14")]
	public FIKOKBLMAKH OMPFPBDECHN(OHJKLNPKNGO FLOKABIHFCN, IEnumerable<NOAFJMJDOFI> HIBGMLGMMMB, int CHDKEAALMJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OOPJILKFJGC : OKFOBCOAGKB
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ABDMPICLKCG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public OOPJILKFJGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
		[DebuggerHidden]
		public ABDMPICLKCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x56B9F80", Offset = "0x56B8F80", VA = "0x1856B9F80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x56B9CA0", Offset = "0x56B8CA0", VA = "0x1856B9CA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x56BA020", Offset = "0x56B9020", VA = "0x1856BA020")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x56B9F30", Offset = "0x56B8F30", VA = "0x1856B9F30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x56B9E90", Offset = "0x56B8E90", VA = "0x1856B9E90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x56B9E90", Offset = "0x56B8E90", VA = "0x1856B9E90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly KDFOGAKKNFF DFFODNLGNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly IIEDLAKPKON FMBNFNFBMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private HCOJBNEKMAH AMHPHKJADIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private List<PMDPIIMPCGN> ADINHOMDPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private List<PMDPIIMPCGN> EJPGBEHJOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private GameObject BENNKINEIAK;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x56C4C90", Offset = "0x56C3C90", VA = "0x1856C4C90")]
	public static OOPJILKFJGC LLKNKJEJINL(KDFOGAKKNFF JEJGBICCBLN, IIEDLAKPKON FMBNFNFBMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x56C5020", Offset = "0x56C4020", VA = "0x1856C5020")]
	private OOPJILKFJGC(KDFOGAKKNFF JEJGBICCBLN, IIEDLAKPKON FMBNFNFBMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x56C3C60", Offset = "0x56C2C60", VA = "0x1856C3C60")]
	public void BPKDLHEEJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x56C4C20", Offset = "0x56C3C20", VA = "0x1856C4C20")]
	[IteratorStateMachine(typeof(ABDMPICLKCG))]
	public IEnumerable<Renderer> LHJENIODBIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x56C41B0", Offset = "0x56C31B0", VA = "0x1856C41B0", Slot = "4")]
	public void IHCNDKLNNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x56C3C30", Offset = "0x56C2C30", VA = "0x1856C3C30")]
	private void BEMILJJPNGF(Vector3 EGADPMHMFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x56C4DF0", Offset = "0x56C3DF0", VA = "0x1856C4DF0")]
	public void LNGAPHKLFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PMDPIIMPCGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct CEJICAMIAEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public MIHHEFJFMAI HOFGFAKIJMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public OHJKLNPKNGO JNALFOOGLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int JJDKDDOIJAO;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KBEEENCNGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public PMDPIIMPCGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public OKPEIMECIFD lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<CEJICAMIAEC> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KBEEENCNGOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IIOJDHEKFPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public FIKOKBLMAKH combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public KBEEENCNGOC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IIOJDHEKFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x56C07D0", Offset = "0x56BF7D0", VA = "0x1856C07D0")]
		internal JobHandle <.ctor>b__0()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x56C0840", Offset = "0x56BF840", VA = "0x1856C0840")]
		internal void <.ctor>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x56C0880", Offset = "0x56BF880", VA = "0x1856C0880")]
		internal void <.ctor>b__2()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int[] PGJGDMKNGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private MLLEDBOKCCB EOPBNLHCKKL;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static Matrix4x4 OGOPBNDPBFE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Mesh CPHENKIENNN
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int GJDBFLAKPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x670670", VA = "0x180671670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x737910", Offset = "0x736910", VA = "0x180737910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x56C5C10", Offset = "0x56C4C10", VA = "0x1856C5C10")]
	public void PIBGENLJHND(List<OHJKLNPKNGO> BIGLAIIDENM, Matrix4x4[] GNHKJBDEMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x56C51A0", Offset = "0x56C41A0", VA = "0x1856C51A0")]
	public static List<PMDPIIMPCGN> FBMLCAAKPML(List<BFGIGHCADFM> KGMNJIAABOA, OKPEIMECIFD LFLCDEHCKMP, Bounds CPMOCNNLOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x56C5830", Offset = "0x56C4830", VA = "0x1856C5830")]
	private JobHandle LHKANLFAOBE(FIKOKBLMAKH OINGNGMANEP, int MMEEMHJNCBK, int BHNFLNKDPAP, OKPEIMECIFD LFLCDEHCKMP, List<CEJICAMIAEC> OHHNPGONMML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x56C5730", Offset = "0x56C4730", VA = "0x1856C5730")]
	private void LEHNOILNEOA(List<CEJICAMIAEC> OHHNPGONMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x56C5F80", Offset = "0x56C4F80", VA = "0x1856C5F80")]
	private PMDPIIMPCGN(List<CEJICAMIAEC> OHHNPGONMML, int MMEEMHJNCBK, int BHNFLNKDPAP, OKPEIMECIFD LFLCDEHCKMP, Bounds CPMOCNNLOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x56C5120", Offset = "0x56C4120", VA = "0x1856C5120", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private MaterialPropertyBlock FNGPLAGOFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private PMDPIIMPCGN OONJFFKJHPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private List<OHJKLNPKNGO> MDPLNEAHAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private RenderTexture HJEMHKCDCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private ComputeBuffer KEMPKCPGNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private ComputeShader GHAKEODJDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Matrix4x4[] LKKGGHGDMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int IHBKOJJCFEN;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public MeshRenderer IJFDNGLEHMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x5E54A0", Offset = "0x5E44A0", VA = "0x1805E54A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int AHDJDFKJJOB
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x56C6EB0", Offset = "0x56C5EB0", VA = "0x1856C6EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x56C6360", Offset = "0x56C5360", VA = "0x1856C6360")]
		public static List<SkinnedShapeRenderer> Create(GameObject JJKPMHEEPII, List<PMDPIIMPCGN> DBDGCOOHOEK, List<OHJKLNPKNGO> MDPLNEAHAAC, Material BGOGBNDAHJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x56C6780", Offset = "0x56C5780", VA = "0x1856C6780")]
		public void Init(PMDPIIMPCGN OONJFFKJHPD, List<OHJKLNPKNGO> MDPLNEAHAAC, Material BGOGBNDAHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x56C6C70", Offset = "0x56C5C70", VA = "0x1856C6C70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x56C6BE0", Offset = "0x56C5BE0", VA = "0x1856C6BE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x56C6BA0", Offset = "0x56C5BA0", VA = "0x1856C6BA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x56C6570", Offset = "0x56C5570", VA = "0x1856C6570")]
		private void FOGKGJHGCAC(ScriptableRenderContext GENOAILOCON, Camera[] GLJPIEMEDJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x56C6D00", Offset = "0x56C5D00", VA = "0x1856C6D00")]
		private void PIBGENLJHND(CommandBuffer DLBBDABADPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x56BBC10", Offset = "0x56BAC10", VA = "0x1856BBC10")]
	private static string HACCFPOCPGB(byte[] GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x56BBD10", Offset = "0x56BAD10", VA = "0x1856BBD10")]
	public static string NOKDDKHJKOE(byte[] FCLFFFPNPCK, bool DHIAJMPKALJ)
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

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
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
