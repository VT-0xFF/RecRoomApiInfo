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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x748BA90", Offset = "0x748AE90", VA = "0x18748BA90", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JMHJFCFNGJF : LMNEDKJKJGM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CDEMPFMINOJ NBHNLHNMGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class MDNHKNMBNGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, GCNBIAOLPHP> OJLLLCEEJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, GCNBIAOLPHP> JKCFNIIKNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? KECCMIGJJIL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long LMAPJLOLJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C70", Offset = "0x8B2070", VA = "0x1808B2C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GCNBIAOLPHP MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7488F40", Offset = "0x7488340", VA = "0x187488F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7487E50", Offset = "0x7487250", VA = "0x187487E50")]
	public void FKPLOCFMGHI(long FJBFONPAOAD, IEnumerable<CEDJELAJNBK> PDKMIGMFBNL, IEnumerable<MLGJCOEGELJ> HEOHHFPHKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7488C10", Offset = "0x7488010", VA = "0x187488C10")]
	public bool MFPGACGLPCA(Guid DIDFLDPPBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74879D0", Offset = "0x7486DD0", VA = "0x1874879D0")]
	public bool BJFEGIDGDBE(Guid DIDFLDPPBOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74889E0", Offset = "0x7487DE0", VA = "0x1874889E0")]
	public bool LNJBADCPOIK(CEDJELAJNBK HHAKJMHKIOI, [Out] CEDJELAJNBK EPGLOFDMBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74887B0", Offset = "0x7487BB0", VA = "0x1874887B0")]
	public IEnumerable<GCNBIAOLPHP> HDKCIPFDPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7488800", Offset = "0x7487C00", VA = "0x187488800")]
	public IEnumerable<CEDJELAJNBK> HNELINCDKNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7487890", Offset = "0x7486C90", VA = "0x187487890")]
	public IEnumerable<MLGJCOEGELJ> AOMOJAMJENC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7488CB0", Offset = "0x74880B0", VA = "0x187488CB0")]
	public bool NAHICPIBNJC(Guid DIDFLDPPBOO, [Out] CEDJELAJNBK GFCOEDIFBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7487DB0", Offset = "0x74871B0", VA = "0x187487DB0")]
	public bool FJMACKAAIGC(string DOBNGBLBBMA, [Out] CEDJELAJNBK GFCOEDIFBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7488700", Offset = "0x7487B00", VA = "0x187488700")]
	public bool GNHKFMEDAMM(Guid DIDFLDPPBOO, [Out] MLGJCOEGELJ HLABDPAPJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7488940", Offset = "0x7487D40", VA = "0x187488940")]
	public bool IIJNPNDGCKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74879F0", Offset = "0x7486DF0", VA = "0x1874879F0")]
	private bool DGFDGKALIMM(CEDJELAJNBK JFKJABAPEAB, CEDJELAJNBK CNIECMCKMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74884B0", Offset = "0x74878B0", VA = "0x1874884B0")]
	private void GGHEOKHHNPJ(Guid HAJICDLBEKC, GCNBIAOLPHP DLCPBDMDBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7487B60", Offset = "0x7486F60", VA = "0x187487B60")]
	private bool EPKKFEOPBDC(Guid HAJICDLBEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7487A70", Offset = "0x7486E70", VA = "0x187487A70")]
	private void DIJJACLNNGM(CEDJELAJNBK KIKINLKBMIM, [Optional] CEDJELAJNBK ECODPECAMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7488D60", Offset = "0x7488160", VA = "0x187488D60")]
	private bool NGLKGGKDMCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7488C70", Offset = "0x7488070", VA = "0x187488C70")]
	private static bool MKBPLJEACCJ(CEDJELAJNBK HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7488FA0", Offset = "0x74883A0", VA = "0x187488FA0")]
	public MDNHKNMBNGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CDEMPFMINOJ : OCFCLMGPDKC, BLKCNFAPLAO, IDisposable, LMEGLDECLAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PMGFMOCJANB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<CEDJELAJNBK, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public CDEMPFMINOJ <>4__this;

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
		private TaskAwaiter<GKFMEIJABLL<HDFHNDLNIJN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x748B3B0", Offset = "0x748A7B0", VA = "0x18748B3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x748B7D0", Offset = "0x748ABD0", VA = "0x18748B7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OIGIKIOGPHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<CEDJELAJNBK, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CDEMPFMINOJ <>4__this;

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
		private TaskAwaiter<GKFMEIJABLL<HDFHNDLNIJN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x748A2C0", Offset = "0x74896C0", VA = "0x18748A2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x748AAE0", Offset = "0x7489EE0", VA = "0x18748AAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OOJPEBLOGDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CEDJELAJNBK <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private KDAPCKACLPG <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<KDAPCKACLPG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x748AB50", Offset = "0x7489F50", VA = "0x18748AB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x748B340", Offset = "0x748A740", VA = "0x18748B340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GGBENOJIEPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public JDJLHJHOJPN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7484530", Offset = "0x7483930", VA = "0x187484530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x74848B0", Offset = "0x7483CB0", VA = "0x1874848B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FHGBLEMNMMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder<KAGOAHBGBNE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JDJLHJHOJPN recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter<KAGOAHBGBNE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74833E0", Offset = "0x74827E0", VA = "0x1874833E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7483840", Offset = "0x7482C40", VA = "0x187483840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HOLGJLAIPCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<ADJGBMNPMCM, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private ADJGBMNPMCM <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7484DE0", Offset = "0x74841E0", VA = "0x187484DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7485260", Offset = "0x7484660", VA = "0x187485260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FNPEBDBJGFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private List<ADJGBMNPMCM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter<LMFFMMPMNDB<ADJGBMNPMCM, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<KDAPCKACLPG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74838B0", Offset = "0x7482CB0", VA = "0x1874838B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x74844C0", Offset = "0x74838C0", VA = "0x1874844C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IPFODMLAODP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<KDAPCKACLPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74852D0", Offset = "0x74846D0", VA = "0x1874852D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x74857F0", Offset = "0x7484BF0", VA = "0x1874857F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FFAGNCKHHME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder<Dictionary<long, MBNEEIOCPHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<GKFMEIJABLL<List<MBNEEIOCPHC>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x74829B0", Offset = "0x7481DB0", VA = "0x1874829B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7483370", Offset = "0x7482770", VA = "0x187483370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PAIPONPNLIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MLGJCOEGELJ playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HJBLBMNMHLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<KAGOAHBGBNE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private PAIPONPNLIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JDJLHJHOJPN awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<MEMHEIJFJKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7484920", Offset = "0x7483D20", VA = "0x187484920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7484D70", Offset = "0x7484170", VA = "0x187484D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IAOEEACELEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Dictionary<Guid, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JFGPOMFLOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public MEMHEIJFJKL result;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JFGPOMFLOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7485860", Offset = "0x7484C60", VA = "0x187485860")]
		internal ALMNMKJLGLC OINCDOIFBBN(Guid id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct CALEMIFENEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<Dictionary<Guid, ALMNMKJLGLC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private IAOEEACELEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<List<ALMNMKJLGLC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7479E40", Offset = "0x7479240", VA = "0x187479E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x747A890", Offset = "0x7479C90", VA = "0x18747A890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct AHMADGDBACH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<List<ALMNMKJLGLC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private List<ALMNMKJLGLC> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<ALMNMKJLGLC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7478F40", Offset = "0x7478340", VA = "0x187478F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7479DD0", Offset = "0x74791D0", VA = "0x187479DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KOGPHDIOIJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Task<List<HDFHNDLNIJN>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Task<List<GIMOEJECHGD>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Task<List<MBNEEIOCPHC>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Task<OGGDAAHHBNG> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private IEnumerable<CEDJELAJNBK> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private IEnumerable<MLGJCOEGELJ> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private List<ADJGBMNPMCM> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter<List<HDFHNDLNIJN>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<List<GIMOEJECHGD>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<List<MBNEEIOCPHC>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<OGGDAAHHBNG> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x74865C0", Offset = "0x74859C0", VA = "0x1874865C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x74877F0", Offset = "0x7486BF0", VA = "0x1874877F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct COPOKJLGFKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7481D50", Offset = "0x7481150", VA = "0x187481D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x74823E0", Offset = "0x74817E0", VA = "0x1874823E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct EFKNKNEOEGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public JDJLHJHOJPN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7482440", Offset = "0x7481840", VA = "0x187482440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7482940", Offset = "0x7481D40", VA = "0x187482940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct AGGNKMCNEGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder<KAGOAHBGBNE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public JDJLHJHOJPN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<KAGOAHBGBNE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x74789D0", Offset = "0x7477DD0", VA = "0x1874789D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7478ED0", Offset = "0x74782D0", VA = "0x187478ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct KGKJHIPPDGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CEDJELAJNBK itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CDEMPFMINOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<LMFFMMPMNDB<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7485BB0", Offset = "0x7484FB0", VA = "0x187485BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7486560", Offset = "0x7485960", VA = "0x187486560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan HIPIAGIJKJK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float IMLJEFPFNDA = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float HAGJGNOIBKI = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int GMOGLEBGPIN = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string MBOAKBBPAIJ = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string DIBCFGPNDBE = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LIMCBJLKHEC DNNKGAFOBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JBFCMMOCJAE DGJDNLDCGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BHDDDJJOANM KPMFCOHFKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly CDOIIJHIKJB PHBCAIBOONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LHCEGCIHNFJ LHFIAJCMKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JMHJFCFNGJF BCAJJGKGKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly GCDLIECIJNL LKEOMLAGJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NCKDMCHBJNK MJFNAAKPHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly PIAOMMOEIOD NEGEGILOMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MDNHKNMBNGD HDJCNHCPEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OAHMCFFIFKN JOADAMEMHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly LOLCEMJKHBJ BNBCPEDJHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource AAJDHLNKBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly LOLBLDCLAKK<Guid, ALMNMKJLGLC> LIPHJOCNCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LOLBLDCLAKK<long, MBNEEIOCPHC> INJONFMHIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly FIBPNBALLDA IGCIBFJOHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable DAGBHHPHAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task BLGPJNBJFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource EELFJIPOIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long GMENLEFMADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool INBIMOFIBDA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private OCHLGIKPKCK PGDECBOFFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7480290", Offset = "0x747F690", VA = "0x187480290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LDNMACGBDLI ODNEANPALFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x922080", Offset = "0x921480", VA = "0x180922080", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xDB37B0", Offset = "0xDB2BB0", VA = "0x180DB37B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PJFDJKKNHLD<CEDJELAJNBK> KGIFGPFADFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9073F0", Offset = "0x9067F0", VA = "0x1809073F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC09CA0", Offset = "0xC090A0", VA = "0x180C09CA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PJFDJKKNHLD<Guid> MPIACBHFHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x907440", Offset = "0x906840", VA = "0x180907440", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x924D60", Offset = "0x924160", VA = "0x180924D60", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HBLLMAEIFAH<MLGJCOEGELJ, int> NHPANGKHODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x921E70", Offset = "0x921270", VA = "0x180921E70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA0F390", Offset = "0xA0E790", VA = "0x180A0F390", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PJFDJKKNHLD<ADJGBMNPMCM> BJJCFDILOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B2350", Offset = "0x8B1750", VA = "0x1808B2350", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B2300", Offset = "0x8B1700", VA = "0x1808B2300", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PJFDJKKNHLD<long> JPKJGPGPNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x922030", Offset = "0x921430", VA = "0x180922030", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCAF5B0", Offset = "0xCAE9B0", VA = "0x180CAF5B0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LDNMACGBDLI HCJBIJOKCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x922020", Offset = "0x921420", VA = "0x180922020", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE67240", Offset = "0xE66640", VA = "0x180E67240", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LDNMACGBDLI HKKDLOCPCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F49E0", Offset = "0x8F3DE0", VA = "0x1808F49E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE67220", Offset = "0xE66620", VA = "0x180E67220", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x747DCA0", Offset = "0x747D0A0", VA = "0x18747DCA0")]
	[OAJAKDHKADM.AEINFAPCLKL.DIAOGFPHJAA]
	internal static void JEDBBFPEMOC(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74811D0", Offset = "0x74805D0", VA = "0x1874811D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CDEMPFMINOJ([CCLHMIDBCEM(null)] LIMCBJLKHEC DNNKGAFOBEB, [CCLHMIDBCEM(null)] JBFCMMOCJAE DGJDNLDCGMJ, [CCLHMIDBCEM(null)] BHDDDJJOANM KPMFCOHFKIH, [CCLHMIDBCEM(null)] CDOIIJHIKJB PHBCAIBOONK, [CCLHMIDBCEM(null)] AACPFFJDDDA FBIKKAJLDAK, [CCLHMIDBCEM(null)] LHCEGCIHNFJ LHFIAJCMKMI, [CCLHMIDBCEM(null)] JMHJFCFNGJF BCAJJGKGKBB, [CCLHMIDBCEM(null)] IEIPOIIILBP MCKEFIPBLFK, [CCLHMIDBCEM(null)] ANIECKIKPHF AEKHBCHGIKC, [CCLHMIDBCEM(null)] GCDLIECIJNL LKEOMLAGJMG, [CCLHMIDBCEM(null)] NCKDMCHBJNK MJFNAAKPHEF, [CCLHMIDBCEM(null)] PIAOMMOEIOD NEGEGILOMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x747C420", Offset = "0x747B820", VA = "0x18747C420", Slot = "50")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x747EDF0", Offset = "0x747E1F0", VA = "0x18747EDF0", Slot = "49")]
	public Task LMHOCONOBGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x747CD60", Offset = "0x747C160", VA = "0x18747CD60", Slot = "20")]
	[AsyncStateMachine(typeof(PMGFMOCJANB))]
	public Task<LMFFMMPMNDB<CEDJELAJNBK, string>> GHHNFHBPJMK(long FJBFONPAOAD, string DDDHPCNFCEK, string BCAMDINMAHA, string DBALDCNBIMF, RoomInventoryItemProperties FFGFGLBHEDJ, byte GPIPGIMFHKC, int KLMDPLMNJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x747C960", Offset = "0x747BD60", VA = "0x18747C960", Slot = "21")]
	[AsyncStateMachine(typeof(OIGIKIOGPHI))]
	public Task<LMFFMMPMNDB<CEDJELAJNBK, string>> FHLJOELLEEK(Guid DIDFLDPPBOO, [Optional] string DDDHPCNFCEK, [Optional] string BCAMDINMAHA, [Optional] string DBALDCNBIMF, [Optional] List<long> MDKPKEONCAP, [Optional] Dictionary<string, RoomInventoryTagClientProperties> MHEKLOFFGPG, [Optional] RoomInventoryItemProperties FFGFGLBHEDJ, [Optional] byte? GPIPGIMFHKC, [Optional] int? KLMDPLMNJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x747BE50", Offset = "0x747B250", VA = "0x18747BE50", Slot = "22")]
	[AsyncStateMachine(typeof(OOJPEBLOGDK))]
	public Task<LMFFMMPMNDB<bool, string>> DHMGDFMLBEM(Guid DIDFLDPPBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x747DD10", Offset = "0x747D110", VA = "0x18747DD10", Slot = "23")]
	public IReadOnlyList<CEDJELAJNBK> JILBPHBODMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x747B740", Offset = "0x747AB40", VA = "0x18747B740", Slot = "24")]
	public IReadOnlyList<CEDJELAJNBK> CNLDNCAFAED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x747E940", Offset = "0x747DD40", VA = "0x18747E940", Slot = "25")]
	public bool KGODIPOLHFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x747F410", Offset = "0x747E810", VA = "0x18747F410", Slot = "26")]
	public bool NAHICPIBNJC(Guid DIDFLDPPBOO, [Out] CEDJELAJNBK GFCOEDIFBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x747CB10", Offset = "0x747BF10", VA = "0x18747CB10", Slot = "27")]
	public bool FJMACKAAIGC(string ILFDBPMGJOJ, [Out] CEDJELAJNBK GFCOEDIFBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x747C640", Offset = "0x747BA40", VA = "0x18747C640", Slot = "28")]
	public IReadOnlyList<MLGJCOEGELJ> EICCDNJPECO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x747CEE0", Offset = "0x747C2E0", VA = "0x18747CEE0", Slot = "29")]
	public bool GNHKFMEDAMM(Guid DIDFLDPPBOO, [Out] MLGJCOEGELJ HLABDPAPJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x747C290", Offset = "0x747B690", VA = "0x18747C290", Slot = "30")]
	public long? DNDHPHINFBN(Guid DIDFLDPPBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x747ABB0", Offset = "0x7479FB0", VA = "0x18747ABB0", Slot = "48")]
	public void AODPIGFLEML(IEnumerable<GIMOEJECHGD> HEOHHFPHKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x747FA40", Offset = "0x747EE40", VA = "0x18747FA40", Slot = "31")]
	[AsyncStateMachine(typeof(GGBENOJIEPF))]
	public Task<int> NOBPNIGOKPA(JDJLHJHOJPN PEIJBHPINLD, Guid DIDFLDPPBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x747B3D0", Offset = "0x747A7D0", VA = "0x18747B3D0", Slot = "32")]
	[AsyncStateMachine(typeof(FHGBLEMNMMB))]
	public Task<KAGOAHBGBNE> BMNCNFLJPFD(JDJLHJHOJPN AGGKHFBLHMA, Guid DIDFLDPPBOO, int HBPMKNLKLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x747EC20", Offset = "0x747E020", VA = "0x18747EC20", Slot = "33")]
	public string LCKCLDAOFCF(MEMHEIJFJKL IPNDOKDOGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x747F680", Offset = "0x747EA80", VA = "0x18747F680", Slot = "34")]
	public bool NCGPALEBJNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x747CC30", Offset = "0x747C030", VA = "0x18747CC30", Slot = "36")]
	[AsyncStateMachine(typeof(HOLGJLAIPCK))]
	public Task<LMFFMMPMNDB<ADJGBMNPMCM, string>> GGHDIGHJFCF(long HJOKGEPKING, RoomInventoryTagClientProperties FFGFGLBHEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x747F2F0", Offset = "0x747E6F0", VA = "0x18747F2F0", Slot = "37")]
	[AsyncStateMachine(typeof(FNPEBDBJGFE))]
	public Task<LMFFMMPMNDB<bool, string>> NAFFKPJLIPO(long HJOKGEPKING)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x747E550", Offset = "0x747D950", VA = "0x18747E550", Slot = "40")]
	public List<(long, int)> KCKPEKBLDNC(long OLEIOCJJEND, int JDPPACELCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x747D990", Offset = "0x747CD90", VA = "0x18747D990", Slot = "41")]
	public bool IDIPMPNLLGD(long HJOKGEPKING, [Out] ADJGBMNPMCM LGFAFNBIMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x747D0A0", Offset = "0x747C4A0", VA = "0x18747D0A0", Slot = "42")]
	public bool HFNOHFPPODH(long HJOKGEPKING, Guid HDOGBJGGILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x74808B0", Offset = "0x747FCB0", VA = "0x1874808B0", Slot = "43")]
	public IReadOnlyList<ADJGBMNPMCM> POEJCFCOKAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x747D010", Offset = "0x747C410", VA = "0x18747D010", Slot = "44")]
	public List<ADJGBMNPMCM> HDDPLAPNBFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x747FB80", Offset = "0x747EF80", VA = "0x18747FB80", Slot = "45")]
	public IReadOnlyList<ADJGBMNPMCM> NPDIGCJJHJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x74800C0", Offset = "0x747F4C0", VA = "0x1874800C0", Slot = "39")]
	public bool OFEAKGOHDEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7480450", Offset = "0x747F850", VA = "0x187480450", Slot = "46")]
	public IReadOnlyList<CEDJELAJNBK> PGAOBALEELM(long HJOKGEPKING)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x747DDC0", Offset = "0x747D1C0", VA = "0x18747DDC0", Slot = "38")]
	[AsyncStateMachine(typeof(IPFODMLAODP))]
	public Task<LMFFMMPMNDB<bool, string>> JKNEEHDFJLL(long FJBFONPAOAD, bool DIPABKMBDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7480720", Offset = "0x747FB20", VA = "0x187480720", Slot = "51")]
	public bool PMBJNNEKAMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x747DEE0", Offset = "0x747D2E0", VA = "0x18747DEE0", Slot = "47")]
	public bool JMHCPNGFNEF(string OACDNPBHDON, [Out] IReadOnlyList<CEDJELAJNBK> GPLPFLBAIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x747EE90", Offset = "0x747E290", VA = "0x18747EE90")]
	[AsyncStateMachine(typeof(FFAGNCKHHME))]
	private Task<Dictionary<long, MBNEEIOCPHC>> LMKMFAJGHGA(Dictionary<long, int> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x747F530", Offset = "0x747E930", VA = "0x18747F530")]
	[AsyncStateMachine(typeof(HJBLBMNMHLA))]
	private Task<KAGOAHBGBNE> NCFKMECIGEF(Guid DIDFLDPPBOO, int HBPMKNLKLPD, [Optional] Guid PKFEAKECCIH, [Optional] JDJLHJHOJPN LNHEJLCOKJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x747C820", Offset = "0x747BC20", VA = "0x18747C820")]
	[AsyncStateMachine(typeof(CALEMIFENEJ))]
	private Task<Dictionary<Guid, ALMNMKJLGLC>> FDFILHJMLBP(Dictionary<Guid, int> IJNJIIKILPF, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x747B220", Offset = "0x747A620", VA = "0x18747B220")]
	[AsyncStateMachine(typeof(AHMADGDBACH))]
	private Task<List<ALMNMKJLGLC>> BBMMKEBCJIC(Dictionary<Guid, int> IJNJIIKILPF, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x747C160", Offset = "0x747B560", VA = "0x18747C160")]
	[AsyncStateMachine(typeof(KOGPHDIOIJF))]
	private Task DLOFCCOLDDE(long FJBFONPAOAD, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x747B9F0", Offset = "0x747ADF0", VA = "0x18747B9F0")]
	private Task DCNGPNHNDCO(LMMLJLDDCAM CJLBFJEOAOD, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x747C090", Offset = "0x747B490", VA = "0x18747C090")]
	[AsyncStateMachine(typeof(COPOKJLGFKB))]
	private Task DLEEAOJHOAF(LMMLJLDDCAM CJLBFJEOAOD, CancellationToken GFIAMKNOHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x747BF70", Offset = "0x747B370", VA = "0x18747BF70")]
	private void DIIGGFDPLOO(HDFHNDLNIJN CJHDDFPEFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7480CB0", Offset = "0x74800B0", VA = "0x187480CB0")]
	[POEDOHOIOKH]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string IIFPPHIIBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x747F180", Offset = "0x747E580", VA = "0x18747F180")]
	private void MOENHPKCMNO(Guid DIDFLDPPBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7480DF0", Offset = "0x74801F0", VA = "0x187480DF0")]
	[POEDOHOIOKH]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid DIDFLDPPBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x747B600", Offset = "0x747AA00", VA = "0x18747B600")]
	[AsyncStateMachine(typeof(EFKNKNEOEGO))]
	private Task<int> CMIDOCGMNAP(JDJLHJHOJPN PEIJBHPINLD, Guid DIDFLDPPBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7480AD0", Offset = "0x747FED0", VA = "0x187480AD0")]
	[POEDOHOIOKH]
	internal void RpcGetPlayerRoomInventoryCount(Guid NEMMHGGPCGF, Guid DIDFLDPPBOO, CBNOCKCJJNP KLONIJLMOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7480A50", Offset = "0x747FE50", VA = "0x187480A50")]
	[POEDOHOIOKH]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid NEMMHGGPCGF, int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7480140", Offset = "0x747F540", VA = "0x187480140")]
	[AsyncStateMachine(typeof(AGGNKMCNEGE))]
	private Task<KAGOAHBGBNE> OPDMEKMENNM(JDJLHJHOJPN PEIJBHPINLD, Guid DIDFLDPPBOO, int HBPMKNLKLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7480980", Offset = "0x747FD80", VA = "0x187480980")]
	[POEDOHOIOKH]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid NEMMHGGPCGF, Guid DIDFLDPPBOO, int HBPMKNLKLPD, CBNOCKCJJNP KLONIJLMOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x747E390", Offset = "0x747D790", VA = "0x18747E390")]
	private void JNCDJDGOHBI(JDJLHJHOJPN AGGKHFBLHMA, Guid NEMMHGGPCGF, MEMHEIJFJKL IPNDOKDOGDG, long DMHHBEOMGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74810A0", Offset = "0x74804A0", VA = "0x1874810A0")]
	[POEDOHOIOKH]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid NEMMHGGPCGF, int IPNDOKDOGDG, long DMHHBEOMGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x747D820", Offset = "0x747CC20", VA = "0x18747D820")]
	private void ICPIGOEHPNF(bool DIPABKMBDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7481040", Offset = "0x7480440", VA = "0x187481040")]
	[POEDOHOIOKH]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool FBOLEJJOBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7480790", Offset = "0x747FB90", VA = "0x187480790")]
	private void PNHGLEGDNLM(List<MBNEEIOCPHC> IHLJCLPOLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7480E90", Offset = "0x7480290", VA = "0x187480E90")]
	[POEDOHOIOKH]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string BHCGHGILBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74802E0", Offset = "0x747F6E0", VA = "0x1874802E0")]
	private void PDCFLFAKNNJ(long HJOKGEPKING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7480E20", Offset = "0x7480220", VA = "0x187480E20")]
	[POEDOHOIOKH]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long HJOKGEPKING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x747EFD0", Offset = "0x747E3D0", VA = "0x18747EFD0")]
	private CEDJELAJNBK MDNKLEIEFAG(HDFHNDLNIJN CJHDDFPEFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x747EA40", Offset = "0x747DE40", VA = "0x18747EA40")]
	private List<ADJGBMNPMCM> KJECOLGECNF(List<MBNEEIOCPHC> IHLJCLPOLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x747F6F0", Offset = "0x747EAF0", VA = "0x18747F6F0")]
	private List<ADJGBMNPMCM> NHGFPOINDAJ(IEnumerable<MBNEEIOCPHC> IHLJCLPOLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x747D2A0", Offset = "0x747C6A0", VA = "0x18747D2A0")]
	private CEDJELAJNBK ICDJCOBCGIF(HDFHNDLNIJN CJHDDFPEFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x747A900", Offset = "0x7479D00", VA = "0x18747A900")]
	private ADJGBMNPMCM AAMCMIIKADG(MBNEEIOCPHC CJHDDFPEFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x747B520", Offset = "0x747A920", VA = "0x18747B520")]
	private void CDMDBDOJBJJ(MLGJCOEGELJ HLABDPAPJJM, int JKADJCLOGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x747B360", Offset = "0x747A760", VA = "0x18747B360")]
	private void BMLJPMOAKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x747FF30", Offset = "0x747F330", VA = "0x18747FF30")]
	private Task OEGIHBAIHAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x747B590", Offset = "0x747A990", VA = "0x18747B590")]
	private void CGPGPMEPPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x747DBE0", Offset = "0x747CFE0", VA = "0x18747DBE0")]
	private void IMMONENPPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x747F070", Offset = "0x747E470", VA = "0x18747F070")]
	private void MFIMMICGGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x747E830", Offset = "0x747DC30", VA = "0x18747E830")]
	[AsyncStateMachine(typeof(KGKJHIPPDGA))]
	private Task KCMBKBFJCCO(CEDJELAJNBK JGCHCOPNEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x747AB90", Offset = "0x7479F90", VA = "0x18747AB90")]
	[CompilerGenerated]
	private void AAPADIDHNEL(Task<TaskStatus> IALOMLEGCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x747AE20", Offset = "0x747A220", VA = "0x18747AE20")]
	[CompilerGenerated]
	private Task<MEMHEIJFJKL> APECDAHFIJE(PAIPONPNLIB P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x747DA20", Offset = "0x747CE20", VA = "0x18747DA20")]
	[CompilerGenerated]
	internal static Dictionary<Guid, ALMNMKJLGLC> IHKDIAAEJKK(MEMHEIJFJKL IPNDOKDOGDG, IAOEEACELEN P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LOLCEMJKHBJ : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7487850", Offset = "0x7486C50", VA = "0x187487850")]
	public LOLCEMJKHBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface ANIECKIKPHF
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDNHKNMBNGD FPKPPIPALPO();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LOLCEMJKHBJ OIAFFOJMPGM();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OAHMCFFIFKN CIONLGHLDAP();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KFMOEOFGMCI : ANIECKIKPHF
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7485AD0", Offset = "0x7484ED0", VA = "0x187485AD0")]
	[OAJAKDHKADM.AEINFAPCLKL.DIAOGFPHJAA]
	internal static void JEDBBFPEMOC(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KFMOEOFGMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x74859C0", Offset = "0x7484DC0", VA = "0x1874859C0", Slot = "4")]
	public MDNHKNMBNGD FPKPPIPALPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7485B40", Offset = "0x7484F40", VA = "0x187485B40", Slot = "5")]
	public LOLCEMJKHBJ OIAFFOJMPGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x74858D0", Offset = "0x7484CD0", VA = "0x1874858D0", Slot = "6")]
	public OAHMCFFIFKN CIONLGHLDAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OAHMCFFIFKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly Dictionary<long, ADJGBMNPMCM> GANGLIJHHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly ADJGBMNPMCM[] IOJABGAHOLH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool CJCOLCMBDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x946390", Offset = "0x945790", VA = "0x180946390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9463A0", Offset = "0x9457A0", VA = "0x1809463A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ELBLKCKHEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x74895F0", Offset = "0x74889F0", VA = "0x1874895F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long MFHENDLAJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C70", Offset = "0x8B2070", VA = "0x1808B2C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x74898E0", Offset = "0x7488CE0", VA = "0x1874898E0")]
	public void FKPLOCFMGHI(long FJBFONPAOAD, IEnumerable<ADJGBMNPMCM> HNGFBCNFFAA, bool KEOLJLLDDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7489730", Offset = "0x7488B30", VA = "0x187489730")]
	public IReadOnlyList<ADJGBMNPMCM> FBOAAHLDKIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x9463A0", Offset = "0x9457A0", VA = "0x1809463A0")]
	public void GBEHOKLFOMC(bool DIPABKMBDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7489650", Offset = "0x7488A50", VA = "0x187489650")]
	public bool EOLIJBAHFBB(long HJOKGEPKING)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7489150", Offset = "0x7488550", VA = "0x187489150")]
	public bool CCDHCLHCAFH(ADJGBMNPMCM DOLLIMHJHHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7489EE0", Offset = "0x74892E0", VA = "0x187489EE0")]
	public bool OILHNBLAGGF(List<ADJGBMNPMCM> BOBIKJBFJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7489340", Offset = "0x7488740", VA = "0x187489340")]
	public bool CPFMDOKPIMI(long HJOKGEPKING, [Out] ADJGBMNPMCM ICMMNOKPMGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x74893E0", Offset = "0x74887E0", VA = "0x1874893E0")]
	public bool DDACJEBENGC(string DDDHPCNFCEK, [Out] ADJGBMNPMCM ICMMNOKPMGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7489080", Offset = "0x7488480", VA = "0x187489080")]
	public List<ADJGBMNPMCM> BFODGBMDKNP(int HAJICDLBEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7489DA0", Offset = "0x74891A0", VA = "0x187489DA0")]
	public List<ADJGBMNPMCM> GPFNBLFGDKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7489310", Offset = "0x7488710", VA = "0x187489310")]
	public ADJGBMNPMCM CLOBIKFNAJA(int HAJICDLBEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7489590", Offset = "0x7488990", VA = "0x187489590")]
	public IReadOnlyList<ADJGBMNPMCM> DICKAFJCBPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x748A200", Offset = "0x7489600", VA = "0x18748A200")]
	public OAHMCFFIFKN()
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
