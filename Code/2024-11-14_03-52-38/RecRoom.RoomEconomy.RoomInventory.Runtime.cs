using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_RoomInventory_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7412760", Offset = "0x7411B60", VA = "0x187412760", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GILNGOIINNA : OMKEKBEKFAP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DNHGPJCFOOH OENEDHIGJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class NGPEIMIAGJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, GHCFFMFKGJK> CLENOLHAPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, GHCFFMFKGJK> IJBJOEFPFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? HENOFLPFPDJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long KANBOFIDLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F30", Offset = "0x8A1330", VA = "0x1808A1F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GHCFFMFKGJK LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x740FED0", Offset = "0x740F2D0", VA = "0x18740FED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x740F820", Offset = "0x740EC20", VA = "0x18740F820")]
	public void MCBEFILMHNL(long HLKBDGNJMKK, IEnumerable<KJEJCAMJCGA> JBPOKIIANAK, IEnumerable<LAPMIJONIBK> AELJHFIFAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x740E930", Offset = "0x740DD30", VA = "0x18740E930")]
	public bool BGGIDGOPHMG(Guid CDIPHMLEOFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x740E990", Offset = "0x740DD90", VA = "0x18740E990")]
	public bool BIJNEFLCHFA(Guid CDIPHMLEOFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x740EEA0", Offset = "0x740E2A0", VA = "0x18740EEA0")]
	public bool FODMACEJAHL(KJEJCAMJCGA FFIDINJEEGP, [Out] KJEJCAMJCGA NPBCLKLBLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x740FE80", Offset = "0x740F280", VA = "0x18740FE80")]
	public IEnumerable<GHCFFMFKGJK> NNCDHDLJDDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x740ECB0", Offset = "0x740E0B0", VA = "0x18740ECB0")]
	public IEnumerable<KJEJCAMJCGA> EFCMBFGDOGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x740F630", Offset = "0x740EA30", VA = "0x18740F630")]
	public IEnumerable<LAPMIJONIBK> KADCGALEDFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x740F500", Offset = "0x740E900", VA = "0x18740F500")]
	public bool IFBDAHGOPOF(Guid CDIPHMLEOFL, [Out] KJEJCAMJCGA CKILLEPMGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x740EE00", Offset = "0x740E200", VA = "0x18740EE00")]
	public bool ENLIMIPLKJO(string GLDGCPFJDFO, [Out] KJEJCAMJCGA CKILLEPMGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x740EC00", Offset = "0x740E000", VA = "0x18740EC00")]
	public bool DMCIGPMABFC(Guid CDIPHMLEOFL, [Out] LAPMIJONIBK MMDGKPMFIIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x740F780", Offset = "0x740EB80", VA = "0x18740F780")]
	public bool LFEGEFPOGCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x740F5B0", Offset = "0x740E9B0", VA = "0x18740F5B0")]
	private bool JANDJACGHJI(KJEJCAMJCGA DCGCMNFFOJI, KJEJCAMJCGA OODGNCKBIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x740E9B0", Offset = "0x740DDB0", VA = "0x18740E9B0")]
	private void DEIPOBMNIJN(Guid OBFJPFHENMC, GHCFFMFKGJK MAGCCINPMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x740F0D0", Offset = "0x740E4D0", VA = "0x18740F0D0")]
	private bool GGOHEKFBPII(Guid OBFJPFHENMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x740FF30", Offset = "0x740F330", VA = "0x18740FF30")]
	private void OOFOMDJMAPM(KJEJCAMJCGA JOGDKBMMMID, [Optional] KJEJCAMJCGA CDHDJECPDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x740F320", Offset = "0x740E720", VA = "0x18740F320")]
	private bool HKNODNCGGDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x740E8F0", Offset = "0x740DCF0", VA = "0x18740E8F0")]
	private static bool AFGIGNJJFJH(KJEJCAMJCGA DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7410020", Offset = "0x740F420", VA = "0x187410020")]
	public NGPEIMIAGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DNHGPJCFOOH : NMOINMHJHEM, BIOPNKKBCBM, IDisposable, BFBJJPLHAMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct HGOPCKEMEIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<KJEJCAMJCGA, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public byte shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<IGEHGGACLCG<GKHKLMKFHMN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x740D420", Offset = "0x740C820", VA = "0x18740D420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x740D840", Offset = "0x740CC40", VA = "0x18740D840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AGLHGIPIBPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<KJEJCAMJCGA, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<string, RoomInventoryTagClientProperties> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public List<long> tagIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte? shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private TaskAwaiter<IGEHGGACLCG<GKHKLMKFHMN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x73FFB60", Offset = "0x73FEF60", VA = "0x1873FFB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7400380", Offset = "0x73FF780", VA = "0x187400380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct EKBPBNELBHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private KJEJCAMJCGA <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private LLJDCDJIOJL <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<LLJDCDJIOJL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x740AF50", Offset = "0x740A350", VA = "0x18740AF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x740B740", Offset = "0x740AB40", VA = "0x18740B740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OIMCFMIGGHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public EDHEFFCJEMG player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7411A10", Offset = "0x7410E10", VA = "0x187411A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7411D90", Offset = "0x7411190", VA = "0x187411D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OAJAALAADPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder<HDKKPBCDNHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public EDHEFFCJEMG recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter<HDKKPBCDNHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7410100", Offset = "0x740F500", VA = "0x187410100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7410560", Offset = "0x740F960", VA = "0x187410560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IIGLEBAJBPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<LDAHDCDDOFO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private LDAHDCDDOFO <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x740D8B0", Offset = "0x740CCB0", VA = "0x18740D8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x740DD30", Offset = "0x740D130", VA = "0x18740DD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct BIMFKJDGEPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private List<LDAHDCDDOFO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter<BMFECDODLAB<LDAHDCDDOFO, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<LLJDCDJIOJL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74003F0", Offset = "0x73FF7F0", VA = "0x1874003F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7401000", Offset = "0x7400400", VA = "0x187401000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct AEIOJHGDLLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<LLJDCDJIOJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x73FF5D0", Offset = "0x73FE9D0", VA = "0x1873FF5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x73FFAF0", Offset = "0x73FEEF0", VA = "0x1873FFAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ELDFFJPHEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder<Dictionary<long, KGLJLOINBGL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<IGEHGGACLCG<List<KGLJLOINBGL>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x740B7B0", Offset = "0x740ABB0", VA = "0x18740B7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x740C170", Offset = "0x740B570", VA = "0x18740C170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DNOEAKJNGLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public LAPMIJONIBK playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OCABFMJPHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<HDKKPBCDNHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private DNOEAKJNGLO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public EDHEFFCJEMG awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<JLBOAGBCCHM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74105D0", Offset = "0x740F9D0", VA = "0x1874105D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7410A20", Offset = "0x740FE20", VA = "0x187410A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KBNFMPOANEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Dictionary<Guid, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IMBLBDKELJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JLBOAGBCCHM result;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public IMBLBDKELJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x740DDA0", Offset = "0x740D1A0", VA = "0x18740DDA0")]
		internal JGBKONKMBBD CKJODELAPOA(Guid id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct MMKAHHLJJBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<Dictionary<Guid, JGBKONKMBBD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KBNFMPOANEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<List<JGBKONKMBBD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x740DE10", Offset = "0x740D210", VA = "0x18740DE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x740E880", Offset = "0x740DC80", VA = "0x18740E880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct EGKKDFPILAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<List<JGBKONKMBBD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private List<JGBKONKMBBD> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<JGBKONKMBBD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x740A040", Offset = "0x7409440", VA = "0x18740A040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x740AEE0", Offset = "0x740A2E0", VA = "0x18740AEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct EEOONIJPHPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Task<List<GKHKLMKFHMN>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Task<List<GCNFFCCFGMM>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Task<List<KGLJLOINBGL>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Task<CMCJJOEHMEM> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private IEnumerable<KJEJCAMJCGA> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private IEnumerable<LAPMIJONIBK> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private List<LDAHDCDDOFO> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter<List<GKHKLMKFHMN>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<List<GCNFFCCFGMM>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<List<KGLJLOINBGL>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<CMCJJOEHMEM> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7408D90", Offset = "0x7408190", VA = "0x187408D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7409FE0", Offset = "0x74093E0", VA = "0x187409FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct OMBIFEIHMDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7411E00", Offset = "0x7411200", VA = "0x187411E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7412490", Offset = "0x7411890", VA = "0x187412490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct OGBKNNBPMEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public EDHEFFCJEMG player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7410A90", Offset = "0x740FE90", VA = "0x187410A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7410F90", Offset = "0x7410390", VA = "0x187410F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct DNLMCNCDMGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder<HDKKPBCDNHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public EDHEFFCJEMG player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<HDKKPBCDNHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7408820", Offset = "0x7407C20", VA = "0x187408820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7408D20", Offset = "0x7408120", VA = "0x187408D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct OHNENGOOCFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public KJEJCAMJCGA itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public DNHGPJCFOOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<BMFECDODLAB<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7411000", Offset = "0x7410400", VA = "0x187411000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x74119B0", Offset = "0x7410DB0", VA = "0x1874119B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan IPINBJJOOGM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float CBMGOEFCDLJ = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float DDIFIJNAKNC = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int BPKLDEEDHPB = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string HOCOHKJKJIF = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string COJDOAHJJCD = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BGFCAIICKOG HIFMFLPODLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly HFCBGLMCENB IMBDLAMJECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BEKOMFBBJCM FILFDDLLPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LJMNIDLMNPF AIMLBFLAPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CDGHNLHMECN PFPGPFBOMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GILNGOIINNA NGOPDBMHCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KOFDFCJMCJL JDHBFLHENJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly JGOFOKNNKLF OJHCMOBFKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KHJDNEDCJOF CAHDIIHLNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly NGPEIMIAGJP NJLHANCMBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly FPOFMGIPIAJ HKLNAOMEPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CGPACMMHOOI FPIKLNECKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource FIFPKJBFENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly HOLFNKAJKOO<Guid, JGBKONKMBBD> IEIPAKDGNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly HOLFNKAJKOO<long, KGLJLOINBGL> AOCOJENNFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly MBBKNNEPKDN FMDBANFNBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable GHIOHJOCJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task PNLLIIDLGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource DMMDGHAACEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long FFBDDOHEIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool AAFPLDAFGFB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private LOFBJIOIIIO EPHBFJFDCGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7404E70", Offset = "0x7404270", VA = "0x187404E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BDDIJCFMLKF AFAKNAOIIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x96D0F0", Offset = "0x96C4F0", VA = "0x18096D0F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE0BFB0", Offset = "0xE0B3B0", VA = "0x180E0BFB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EJELNBCCPAC<KJEJCAMJCGA> FEOEEMDHCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96D100", Offset = "0x96C500", VA = "0x18096D100", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC73820", Offset = "0xC72C20", VA = "0x180C73820", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EJELNBCCPAC<Guid> DDKINFMBGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x96D0E0", Offset = "0x96C4E0", VA = "0x18096D0E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x914070", Offset = "0x913470", VA = "0x180914070", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PIDJNMEAPLG<LAPMIJONIBK, int> EBKNHFDAIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x96CEC0", Offset = "0x96C2C0", VA = "0x18096CEC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA770A0", Offset = "0xA764A0", VA = "0x180A770A0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EJELNBCCPAC<LDAHDCDDOFO> DPNKOMAONKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89A3F0", Offset = "0x8997F0", VA = "0x18089A3F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x89A370", Offset = "0x899770", VA = "0x18089A370", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EJELNBCCPAC<long> ODJFHJDHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x96D090", Offset = "0x96C490", VA = "0x18096D090", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD03B00", Offset = "0xD02F00", VA = "0x180D03B00", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BDDIJCFMLKF LOMIIFDDDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x96D080", Offset = "0x96C480", VA = "0x18096D080", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xEBA360", Offset = "0xEB9760", VA = "0x180EBA360", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BDDIJCFMLKF LJNNFLFOAMG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E6580", Offset = "0x8E5980", VA = "0x1808E6580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x912AA0", Offset = "0x911EA0", VA = "0x180912AA0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7402C00", Offset = "0x7402000", VA = "0x187402C00")]
	[GOEIKLHOLGG.IBEFHGHGJKH.OGEIPBLEMDG]
	internal static void DJNFEGBLBOB(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7407CA0", Offset = "0x74070A0", VA = "0x187407CA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DNHGPJCFOOH([NDMEANGLJKD(null)] BGFCAIICKOG HIFMFLPODLJ, [NDMEANGLJKD(null)] HFCBGLMCENB IMBDLAMJECA, [NDMEANGLJKD(null)] BEKOMFBBJCM FILFDDLLPCI, [NDMEANGLJKD(null)] LJMNIDLMNPF AIMLBFLAPAN, [NDMEANGLJKD(null)] NOCIHHILPOB NJDKELKJIBP, [NDMEANGLJKD(null)] CDGHNLHMECN PFPGPFBOMNB, [NDMEANGLJKD(null)] GILNGOIINNA NGOPDBMHCBM, [NDMEANGLJKD(null)] AALPGBGGJBI ONKAKNKLNME, [NDMEANGLJKD(null)] GACEINNJENN ANJNFAIPFBE, [NDMEANGLJKD(null)] KOFDFCJMCJL JDHBFLHENJD, [NDMEANGLJKD(null)] JGOFOKNNKLF OJHCMOBFKFB, [NDMEANGLJKD(null)] KHJDNEDCJOF CAHDIIHLNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7402F50", Offset = "0x7402350", VA = "0x187402F50", Slot = "50")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74059B0", Offset = "0x7404DB0", VA = "0x1874059B0", Slot = "49")]
	public Task MNLMDPDNMPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7404EC0", Offset = "0x74042C0", VA = "0x187404EC0", Slot = "20")]
	[AsyncStateMachine(typeof(HGOPCKEMEIN))]
	public Task<BMFECDODLAB<KJEJCAMJCGA, string>> KBIBBCIONMC(long HLKBDGNJMKK, string ACDGEPBIBHJ, string ICNGJIJIACL, string ELKICCMMGCC, RoomInventoryItemProperties NNGMGDHBCPD, byte NNEEMNCGDEG, int FKCCOIADMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74053F0", Offset = "0x74047F0", VA = "0x1874053F0", Slot = "21")]
	[AsyncStateMachine(typeof(AGLHGIPIBPI))]
	public Task<BMFECDODLAB<KJEJCAMJCGA, string>> LMDBLHHCCGK(Guid CDIPHMLEOFL, [Optional] string ACDGEPBIBHJ, [Optional] string ICNGJIJIACL, [Optional] string ELKICCMMGCC, [Optional] List<long> DLINCCJIHMJ, [Optional] Dictionary<string, RoomInventoryTagClientProperties> OHIMEAAEJFE, [Optional] RoomInventoryItemProperties NNGMGDHBCPD, [Optional] byte? NNEEMNCGDEG, [Optional] int? FKCCOIADMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7405040", Offset = "0x7404440", VA = "0x187405040", Slot = "22")]
	[AsyncStateMachine(typeof(EKBPBNELBHK))]
	public Task<BMFECDODLAB<bool, string>> KEJALEJFMHA(Guid CDIPHMLEOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7407250", Offset = "0x7406650", VA = "0x187407250", Slot = "23")]
	public IReadOnlyList<KJEJCAMJCGA> PHHAECDDAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7404960", Offset = "0x7403D60", VA = "0x187404960", Slot = "24")]
	public IReadOnlyList<KJEJCAMJCGA> JHBBLBNIIBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7403450", Offset = "0x7402850", VA = "0x187403450", Slot = "25")]
	public bool ENCDPCOJDNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7404490", Offset = "0x7403890", VA = "0x187404490", Slot = "26")]
	public bool IFBDAHGOPOF(Guid CDIPHMLEOFL, [Out] KJEJCAMJCGA CKILLEPMGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7403550", Offset = "0x7402950", VA = "0x187403550", Slot = "27")]
	public bool ENLIMIPLKJO(string MIJAHKEIOMF, [Out] KJEJCAMJCGA CKILLEPMGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7402230", Offset = "0x7401630", VA = "0x187402230", Slot = "28")]
	public IReadOnlyList<LAPMIJONIBK> BOBMCCCJNPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7402DB0", Offset = "0x74021B0", VA = "0x187402DB0", Slot = "29")]
	public bool DMCIGPMABFC(Guid CDIPHMLEOFL, [Out] LAPMIJONIBK MMDGKPMFIIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74045B0", Offset = "0x74039B0", VA = "0x1874045B0", Slot = "30")]
	public long? IHPMJPMEAMP(Guid CDIPHMLEOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7405740", Offset = "0x7404B40", VA = "0x187405740", Slot = "48")]
	public void MHBJHBBFPBD(IEnumerable<GCNFFCCFGMM> AELJHFIFAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7402C70", Offset = "0x7402070", VA = "0x187402C70", Slot = "31")]
	[AsyncStateMachine(typeof(OIMCFMIGGHA))]
	public Task<int> DLAMGHNEBKJ(EDHEFFCJEMG FFANAAGKHEI, Guid CDIPHMLEOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7407300", Offset = "0x7406700", VA = "0x187407300", Slot = "32")]
	[AsyncStateMachine(typeof(OAJAALAADPO))]
	public Task<HDKKPBCDNHD> PJAOPDLLCJD(EDHEFFCJEMG JMPGNKDKNEJ, Guid CDIPHMLEOFL, int LBJJAOIKGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7403BD0", Offset = "0x7402FD0", VA = "0x187403BD0", Slot = "33")]
	public string FPCKDOJKKDD(JLBOAGBCCHM HCMJFDLGOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7405160", Offset = "0x7404560", VA = "0x187405160", Slot = "34")]
	public bool LCCMKCPIAOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7403320", Offset = "0x7402720", VA = "0x187403320", Slot = "36")]
	[AsyncStateMachine(typeof(IIGLEBAJBPL))]
	public Task<BMFECDODLAB<LDAHDCDDOFO, string>> EKMEBCENIJB(long NABLNBJFNLF, RoomInventoryTagClientProperties NNGMGDHBCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7406C70", Offset = "0x7406070", VA = "0x187406C70", Slot = "37")]
	[AsyncStateMachine(typeof(BIMFKJDGEPF))]
	public Task<BMFECDODLAB<bool, string>> PANKDIJKIOC(long NABLNBJFNLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404E50", VA = "0x187405A50", Slot = "40")]
	public List<(long, int)> NMPIFIMAPLG(long IDBIKABBIBP, int AJEGHCECNOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74056B0", Offset = "0x7404AB0", VA = "0x1874056B0", Slot = "41")]
	public bool MHAOPLAIPID(long NABLNBJFNLF, [Out] LDAHDCDDOFO KCIGIDIPDHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7401390", Offset = "0x7400790", VA = "0x187401390", Slot = "42")]
	public bool AEGNGMPKECC(long NABLNBJFNLF, Guid LEIKLJINCMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7402B30", Offset = "0x7401F30", VA = "0x187402B30", Slot = "43")]
	public IReadOnlyList<LDAHDCDDOFO> DEKACGACGLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x74051D0", Offset = "0x74045D0", VA = "0x1874051D0", Slot = "44")]
	public List<LDAHDCDDOFO> LDLMMCBJLCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x74068C0", Offset = "0x7405CC0", VA = "0x1874068C0", Slot = "45")]
	public IReadOnlyList<LDAHDCDDOFO> OMGFKCIIJHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x74021B0", Offset = "0x74015B0", VA = "0x1874021B0", Slot = "39")]
	public bool BJGDMFFLEEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7403670", Offset = "0x7402A70", VA = "0x187403670", Slot = "46")]
	public IReadOnlyList<KJEJCAMJCGA> FDIGIHNEOJI(long NABLNBJFNLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7402420", Offset = "0x7401820", VA = "0x187402420", Slot = "38")]
	[AsyncStateMachine(typeof(AEIOJHGDLLH))]
	public Task<BMFECDODLAB<bool, string>> CAHHBOGBMNM(long HLKBDGNJMKK, bool PAPBJEBHJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74032B0", Offset = "0x74026B0", VA = "0x1874032B0", Slot = "51")]
	public bool EDMPMCJLMEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7406D90", Offset = "0x7406190", VA = "0x187406D90", Slot = "47")]
	public bool PBIEHCFDDGD(string BIPICLEKKAN, [Out] IReadOnlyList<KJEJCAMJCGA> DEMHHBDJMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7404190", Offset = "0x7403590", VA = "0x187404190")]
	[AsyncStateMachine(typeof(ELDFFJPHEMO))]
	private Task<Dictionary<long, KGLJLOINBGL>> HPAMHDAALFN(Dictionary<long, int> IACNPJNKCPM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7404740", Offset = "0x7403B40", VA = "0x187404740")]
	[AsyncStateMachine(typeof(OCABFMJPHIO))]
	private Task<HDKKPBCDNHD> ILLBJHOKCPH(Guid CDIPHMLEOFL, int LBJJAOIKGCM, [Optional] Guid JJCODDIANPE, [Optional] EDHEFFCJEMG OPCPFLKDIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7404050", Offset = "0x7403450", VA = "0x187404050")]
	[AsyncStateMachine(typeof(MMKAHHLJJBC))]
	private Task<Dictionary<Guid, JGBKONKMBBD>> HKLIDFFPGJI(Dictionary<Guid, int> CONIDOGGAKF, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7402540", Offset = "0x7401940", VA = "0x187402540")]
	[AsyncStateMachine(typeof(EGKKDFPILAN))]
	private Task<List<JGBKONKMBBD>> CDNNOLBBOEN(Dictionary<Guid, int> CONIDOGGAKF, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7404D40", Offset = "0x7404140", VA = "0x187404D40")]
	[AsyncStateMachine(typeof(EEOONIJPHPP))]
	private Task JIENGLLAFGL(long HLKBDGNJMKK, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7401760", Offset = "0x7400B60", VA = "0x187401760")]
	private Task AJDJEDEGOGN(GPHLDHMLGGJ KCHFAPGLICB, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7404890", Offset = "0x7403C90", VA = "0x187404890")]
	[AsyncStateMachine(typeof(OMBIFEIHMDK))]
	private Task JBGKFENCFDD(GPHLDHMLGGJ KCHFAPGLICB, CancellationToken BKIOLHNFANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74052D0", Offset = "0x74046D0", VA = "0x1874052D0")]
	private void LMCJALPKBHE(GKHKLMKFHMN CEBKJDELDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7407780", Offset = "0x7406B80", VA = "0x187407780")]
	[BGNHMBMBOCL]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string AAOPGMJHEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7403EE0", Offset = "0x74032E0", VA = "0x187403EE0")]
	private void GLDGPLNINFK(Guid CDIPHMLEOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x74078C0", Offset = "0x7406CC0", VA = "0x1874078C0")]
	[BGNHMBMBOCL]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid CDIPHMLEOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7403170", Offset = "0x7402570", VA = "0x187403170")]
	[AsyncStateMachine(typeof(OGBKNNBPMEB))]
	private Task<int> EAKENOEJFND(EDHEFFCJEMG FFANAAGKHEI, Guid CDIPHMLEOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x74075A0", Offset = "0x74069A0", VA = "0x1874075A0")]
	[BGNHMBMBOCL]
	internal void RpcGetPlayerRoomInventoryCount(Guid LBOKKGIBGKL, Guid CDIPHMLEOFL, HNGGJDJMLJB EALDCBFDHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7407520", Offset = "0x7406920", VA = "0x187407520")]
	[BGNHMBMBOCL]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid LBOKKGIBGKL, int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7405D30", Offset = "0x7405130", VA = "0x187405D30")]
	[AsyncStateMachine(typeof(DNLMCNCDMGN))]
	private Task<HDKKPBCDNHD> NPLBLEFLGMH(EDHEFFCJEMG FFANAAGKHEI, Guid CDIPHMLEOFL, int LBJJAOIKGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7407450", Offset = "0x7406850", VA = "0x187407450")]
	[BGNHMBMBOCL]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid LBOKKGIBGKL, Guid CDIPHMLEOFL, int LBJJAOIKGCM, HNGGJDJMLJB EALDCBFDHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74042D0", Offset = "0x74036D0", VA = "0x1874042D0")]
	private void HPCOCCADBKA(EDHEFFCJEMG JMPGNKDKNEJ, Guid LBOKKGIBGKL, JLBOAGBCCHM HCMJFDLGOJF, long FBLCDNKDKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7407B70", Offset = "0x7406F70", VA = "0x187407B70")]
	[BGNHMBMBOCL]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid LBOKKGIBGKL, int HCMJFDLGOJF, long FBLCDNKDKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7402040", Offset = "0x7401440", VA = "0x187402040")]
	private void BFJECFGGCGP(bool PAPBJEBHJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7407B10", Offset = "0x7406F10", VA = "0x187407B10")]
	[BGNHMBMBOCL]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool KAIHOJAICNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7403DC0", Offset = "0x74031C0", VA = "0x187403DC0")]
	private void GCHIDHIIAMP(List<KGLJLOINBGL> IABOCIIHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7407960", Offset = "0x7406D60", VA = "0x187407960")]
	[BGNHMBMBOCL]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string DNCAOCONPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74063F0", Offset = "0x74057F0", VA = "0x1874063F0")]
	private void OCHIPJNKDCB(long NABLNBJFNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74078F0", Offset = "0x7406CF0", VA = "0x1874078F0")]
	[BGNHMBMBOCL]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long NABLNBJFNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7402680", Offset = "0x7401A80", VA = "0x187402680")]
	private KJEJCAMJCGA CEBMLDOEJDB(GKHKLMKFHMN CEBKJDELDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7406560", Offset = "0x7405960", VA = "0x187406560")]
	private List<LDAHDCDDOFO> ODOJJMILNPM(List<KGLJLOINBGL> IABOCIIHION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74027E0", Offset = "0x7401BE0", VA = "0x1874027E0")]
	private List<LDAHDCDDOFO> CMOLMLFLILL(IEnumerable<KGLJLOINBGL> IABOCIIHION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7405E80", Offset = "0x7405280", VA = "0x187405E80")]
	private KJEJCAMJCGA OCEBEPKCKMM(GKHKLMKFHMN CEBKJDELDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7403940", Offset = "0x7402D40", VA = "0x187403940")]
	private LDAHDCDDOFO FMNDIFFLHLI(KGLJLOINBGL CEBKJDELDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7405260", Offset = "0x7404660", VA = "0x187405260")]
	private void LKDCIAMBBAD(LAPMIJONIBK MMDGKPMFIIA, int JMLFFCMOIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7401BC0", Offset = "0x7400FC0", VA = "0x187401BC0")]
	private void ANBJAPMNLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7406740", Offset = "0x7405B40", VA = "0x187406740")]
	private Task OFGHKJEAGML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7402EE0", Offset = "0x74022E0", VA = "0x187402EE0")]
	private void DNOKGDHAPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7402720", Offset = "0x7401B20", VA = "0x187402720")]
	private void CEKOHOLNGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7404C30", Offset = "0x7404030", VA = "0x187404C30")]
	private void JHJLKKJJFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x74055A0", Offset = "0x74049A0", VA = "0x1874055A0")]
	[AsyncStateMachine(typeof(OHNENGOOCFJ))]
	private Task MDPNGCDCDGL(KJEJCAMJCGA HMCOJFMLIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7403DA0", Offset = "0x74031A0", VA = "0x187403DA0")]
	[CompilerGenerated]
	private void GBLDKAEMCII(Task<TaskStatus> FFKGFPJNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7401C30", Offset = "0x7401030", VA = "0x187401C30")]
	[CompilerGenerated]
	private Task<JLBOAGBCCHM> APLKLDNDDLN(DNOEAKJNGLO P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7401590", Offset = "0x7400990", VA = "0x187401590")]
	[CompilerGenerated]
	internal static Dictionary<Guid, JGBKONKMBBD> AFKEMJEKOBN(JLBOAGBCCHM HCMJFDLGOJF, KBNFMPOANEN P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CGPACMMHOOI : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7401350", Offset = "0x7400750", VA = "0x187401350")]
	public CGPACMMHOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GACEINNJENN
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGPEIMIAGJP MCGKJNBGPGH();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGPACMMHOOI EGEAIDHNMOG();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FPOFMGIPIAJ GGOCFPKDABF();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CBICNPIFEIM : GACEINNJENN
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7401070", Offset = "0x7400470", VA = "0x187401070")]
	[GOEIKLHOLGG.IBEFHGHGJKH.OGEIPBLEMDG]
	internal static void DJNFEGBLBOB(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	[RecRoom.NoEngine.Common.Preserve]
	public CBICNPIFEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7401240", Offset = "0x7400640", VA = "0x187401240", Slot = "4")]
	public NGPEIMIAGJP MCGKJNBGPGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x74010E0", Offset = "0x74004E0", VA = "0x1874010E0", Slot = "5")]
	public CGPACMMHOOI EGEAIDHNMOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7401150", Offset = "0x7400550", VA = "0x187401150", Slot = "6")]
	public FPOFMGIPIAJ GGOCFPKDABF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FPOFMGIPIAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly Dictionary<long, LDAHDCDDOFO> MKPLDBGKGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly LDAHDCDDOFO[] LNPELNDKLDN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DPGFIINCMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x931420", Offset = "0x930820", VA = "0x180931420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x992330", Offset = "0x991730", VA = "0x180992330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int HOMDNDPLNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x740D2A0", Offset = "0x740C6A0", VA = "0x18740D2A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long IIBOMGMPCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F30", Offset = "0x8A1330", VA = "0x1808A1F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x740CDE0", Offset = "0x740C1E0", VA = "0x18740CDE0")]
	public void MCBEFILMHNL(long HLKBDGNJMKK, IEnumerable<LDAHDCDDOFO> BGGIPDHEELK, bool FNDCNNFKLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x740CC30", Offset = "0x740C030", VA = "0x18740CC30")]
	public IReadOnlyList<LDAHDCDDOFO> JDNAGBDAJEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x992330", Offset = "0x991730", VA = "0x180992330")]
	public void CKCMFDOFPCF(bool PAPBJEBHJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x740C550", Offset = "0x740B950", VA = "0x18740C550")]
	public bool CHPGCJLDLOL(long NABLNBJFNLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x740C1E0", Offset = "0x740B5E0", VA = "0x18740C1E0")]
	public bool CFHJKEDMJEA(LDAHDCDDOFO HJKHJDLEGEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x740C840", Offset = "0x740BC40", VA = "0x18740C840")]
	public bool FCNOAJDHJKL(List<LDAHDCDDOFO> FEEPAIHPLFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x740C660", Offset = "0x740BA60", VA = "0x18740C660")]
	public bool DBEALEHJBCM(long NABLNBJFNLF, [Out] LDAHDCDDOFO CHOCLJFEHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x740C3A0", Offset = "0x740B7A0", VA = "0x18740C3A0")]
	public bool CHOCHPEHAIM(string ACDGEPBIBHJ, [Out] LDAHDCDDOFO CHOCLJFEHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x740CB60", Offset = "0x740BF60", VA = "0x18740CB60")]
	public List<LDAHDCDDOFO> IMMJHFEEGLB(int OBFJPFHENMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x740C700", Offset = "0x740BB00", VA = "0x18740C700")]
	public List<LDAHDCDDOFO> EKOKMHMFNOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x740C630", Offset = "0x740BA30", VA = "0x18740C630")]
	public LDAHDCDDOFO DABJNDKEKBJ(int OBFJPFHENMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x740D300", Offset = "0x740C700", VA = "0x18740D300")]
	public IReadOnlyList<LDAHDCDDOFO> OIIOCIICLJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x740D360", Offset = "0x740C760", VA = "0x18740D360")]
	public FPOFMGIPIAJ()
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
