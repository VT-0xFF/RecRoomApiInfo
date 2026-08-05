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
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_RoomInventory_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D75A30", Offset = "0x7D74C30", VA = "0x187D75A30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BLHMBNJBFMJ : JPCPEAHADNM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EBDLPEMGGDK EJCMOCHOICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class PHFNNMCCPJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, FINJMMHHPHP> IEFGEIFKHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, FINJMMHHPHP> EGCKKKDBDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? GIIAEJOJJHK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long CBKFHOJDEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x964ED0", Offset = "0x9640D0", VA = "0x180964ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FINJMMHHPHP EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D74D60", Offset = "0x7D73F60", VA = "0x187D74D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D744C0", Offset = "0x7D736C0", VA = "0x187D744C0")]
	public void EAEBMKLJJFN(long KCAAOMDKNIH, IEnumerable<BBFGEKOOPBI> NKDGLAEPFNO, IEnumerable<ACOOMBENIJF> FECEEACPOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D75600", Offset = "0x7D74800", VA = "0x187D75600")]
	public bool NCJEDDAGNEH(Guid LJEMMPEPGIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D75660", Offset = "0x7D74860", VA = "0x187D75660")]
	public bool OGPGHNCGHLC(Guid LJEMMPEPGIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D74B30", Offset = "0x7D73D30", VA = "0x187D74B30")]
	public bool FDMFNAABGMH(BBFGEKOOPBI CJPIEABOCBL, [Out] BBFGEKOOPBI EIEDPAKJOJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D75680", Offset = "0x7D74880", VA = "0x187D75680")]
	public IEnumerable<FINJMMHHPHP> OLLJMOLMBHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D752E0", Offset = "0x7D744E0", VA = "0x187D752E0")]
	public IEnumerable<BBFGEKOOPBI> LINGCDNIDOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D75420", Offset = "0x7D74620", VA = "0x187D75420")]
	public IEnumerable<ACOOMBENIJF> MIMNNIBNCIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D74410", Offset = "0x7D73610", VA = "0x187D74410")]
	public bool DKCMGMGNLMP(Guid LJEMMPEPGIK, [Out] BBFGEKOOPBI CKBMBJBFACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D75560", Offset = "0x7D74760", VA = "0x187D75560")]
	public bool MOAGGGJFNFJ(string IGGBAKCMAAB, [Out] BBFGEKOOPBI CKBMBJBFACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D73FB0", Offset = "0x7D731B0", VA = "0x187D73FB0")]
	public bool BENFNFAHECP(Guid LJEMMPEPGIK, [Out] ACOOMBENIJF MLCJGBMGEPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D740E0", Offset = "0x7D732E0", VA = "0x187D740E0")]
	public bool BKFLCGFENAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D74060", Offset = "0x7D73260", VA = "0x187D74060")]
	private bool BIHAPMPADFH(BBFGEKOOPBI JIPFKIHJIDL, BBFGEKOOPBI FCENMCHKABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D74180", Offset = "0x7D73380", VA = "0x187D74180")]
	private void CGONNHHNEJE(Guid KOOLKCPAFBB, FINJMMHHPHP PEEDKBGFKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D74EB0", Offset = "0x7D740B0", VA = "0x187D74EB0")]
	private bool HBHLNFILNKI(Guid KOOLKCPAFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D74DC0", Offset = "0x7D73FC0", VA = "0x187D74DC0")]
	private void GJJCPIJKKDE(BBFGEKOOPBI JLAHGCALKKP, [Optional] BBFGEKOOPBI JKNKPMNPLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D75100", Offset = "0x7D74300", VA = "0x187D75100")]
	private bool IGGABNEODFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D743D0", Offset = "0x7D735D0", VA = "0x187D743D0")]
	private static bool CLAKMMPLLGE(BBFGEKOOPBI LOKFKJLCEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D756D0", Offset = "0x7D748D0", VA = "0x187D756D0")]
	public PHFNNMCCPJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EBDLPEMGGDK : NBGBGGLANMD, DJFFIBKFIAC, IDisposable, KLEKMEOGHLP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct EEHFJKKFMAD : IEquatable<EEHFJKKFMAD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long CBKFHOJDEKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid BCFADMDMDDD;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4B14C30", Offset = "0x4B13E30", VA = "0x184B14C30")]
		public EEHFJKKFMAD(long KCAAOMDKNIH, Guid LJEMMPEPGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C3C0", Offset = "0x7D6B5C0", VA = "0x187D6C3C0", Slot = "4")]
		public bool Equals(EEHFJKKFMAD LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C4C0", Offset = "0x7D6B6C0", VA = "0x187D6C4C0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C620", Offset = "0x7D6B820", VA = "0x187D6C620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JIAJDINAHDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<BBFGEKOOPBI, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Guid? originId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public List<long> tagIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public List<HJOMCHBGBAG> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<DCJKBLPCMAD<BNHFGEMKEKK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7D6FC20", Offset = "0x7D6EE20", VA = "0x187D6FC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7D70130", Offset = "0x7D6F330", VA = "0x187D70130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LPHJBPLGBNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<BBFGEKOOPBI, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Dictionary<string, RoomInventoryTagClientProperties> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public List<long> tagIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public byte? shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<DCJKBLPCMAD<BNHFGEMKEKK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D723A0", Offset = "0x7D715A0", VA = "0x187D723A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D72BF0", Offset = "0x7D71DF0", VA = "0x187D72BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MPGAPNBCHIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private BBFGEKOOPBI <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private NLLCECEDBKB <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<NLLCECEDBKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D731D0", Offset = "0x7D723D0", VA = "0x187D731D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7D739E0", Offset = "0x7D72BE0", VA = "0x187D739E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct EMJACLBDNBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public GJGNFGDHFCI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C6A0", Offset = "0x7D6B8A0", VA = "0x187D6C6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7D6CA20", Offset = "0x7D6BC20", VA = "0x187D6CA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KONFOMIIILC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<CDHEKADOEPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public GJGNFGDHFCI recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<CDHEKADOEPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7D71ED0", Offset = "0x7D710D0", VA = "0x187D71ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7D72330", Offset = "0x7D71530", VA = "0x187D72330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FFPEKNAELFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<IEJLCFFMNBN, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IEJLCFFMNBN <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7D6CD70", Offset = "0x7D6BF70", VA = "0x187D6CD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D1F0", Offset = "0x7D6C3F0", VA = "0x187D6D1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CNJMJCLPEHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<IEJLCFFMNBN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<CPEANPEHCAG<IEJLCFFMNBN, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<NLLCECEDBKB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7D63450", Offset = "0x7D62650", VA = "0x187D63450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7D64060", Offset = "0x7D63260", VA = "0x187D64060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CDDGLCJKMIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<NLLCECEDBKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7D61FD0", Offset = "0x7D611D0", VA = "0x187D61FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7D624F0", Offset = "0x7D616F0", VA = "0x187D624F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CIJBPHEBMAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, HJOMCHBGBAG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<DCJKBLPCMAD<List<HJOMCHBGBAG>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7D62A20", Offset = "0x7D61C20", VA = "0x187D62A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D633E0", Offset = "0x7D625E0", VA = "0x187D633E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KGONNLMCFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ACOOMBENIJF playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CDJONHCNCEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<CDHEKADOEPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private KGONNLMCFAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GJGNFGDHFCI awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<LGBOBAHPBDN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7D62560", Offset = "0x7D61760", VA = "0x187D62560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7D629B0", Offset = "0x7D61BB0", VA = "0x187D629B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FFIHGGHNPCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<EEHFJKKFMAD, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class INLAMEKGDPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LGBOBAHPBDN result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public INLAMEKGDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E920", Offset = "0x7D6DB20", VA = "0x187D6E920")]
		internal ADEIPCBKNIG MNAKKJNALAP(EEHFJKKFMAD id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JKDJIHLOMDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<EEHFJKKFMAD, ADEIPCBKNIG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<EEHFJKKFMAD, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private FFIHGGHNPCM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<ADEIPCBKNIG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7D713B0", Offset = "0x7D705B0", VA = "0x187D713B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7D71E60", Offset = "0x7D71060", VA = "0x187D71E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FGFHNENPPPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<ADEIPCBKNIG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<EEHFJKKFMAD, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<ADEIPCBKNIG> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<ADEIPCBKNIG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D260", Offset = "0x7D6C460", VA = "0x187D6D260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E1C0", Offset = "0x7D6D3C0", VA = "0x187D6E1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct JCKAILKPHAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<BNHFGEMKEKK>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<NJLEKCADGPD>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<HJOMCHBGBAG>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<JGBMKGIEBMH> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<BBFGEKOOPBI> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<ACOOMBENIJF> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<IEJLCFFMNBN> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<BNHFGEMKEKK>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<NJLEKCADGPD>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<HJOMCHBGBAG>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<JGBMKGIEBMH> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E990", Offset = "0x7D6DB90", VA = "0x187D6E990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D6FBC0", Offset = "0x7D6EDC0", VA = "0x187D6FBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HGAPPJEAOHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E230", Offset = "0x7D6D430", VA = "0x187D6E230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E8C0", Offset = "0x7D6DAC0", VA = "0x187D6E8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct OGOJHIDGKNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public GJGNFGDHFCI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7D73A50", Offset = "0x7D72C50", VA = "0x187D73A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D73F40", Offset = "0x7D73140", VA = "0x187D73F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MLPNGDAPMDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<CDHEKADOEPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public GJGNFGDHFCI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<CDHEKADOEPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D72C60", Offset = "0x7D71E60", VA = "0x187D72C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D73160", Offset = "0x7D72360", VA = "0x187D73160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct DBCPJNFELBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BBFGEKOOPBI itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public EBDLPEMGGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<CPEANPEHCAG<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D640D0", Offset = "0x7D632D0", VA = "0x187D640D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D64A80", Offset = "0x7D63C80", VA = "0x187D64A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan PMNIBAEKHIN;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float AMLAEMANHBN = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float OAPNHALOMOK = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int DIMPAOPBMNP = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string DHLKAOAHDNI = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string IBIFEJMCBCF = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GPHFIMCKLAM CKILOPBDOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CNANDCFFPII CJAPICFIEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CBANICJGKMB FLIDHFGOIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HGMGKEGCNHK LBHHCEDLJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly PKLBFIOCMNH JPEFMFKFLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BLHMBNJBFMJ CCJJOKJILJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FHHIANONFNH MDKMPMLAPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MIDGLOFLPMA OLPKELPHNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KDCKECJKIIM HNAPEDABKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly PHFNNMCCPJG DFMMPFDPIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JJPAJAPEJPF EOABLLPKKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly ANBOAANHHCE NNBOABMDGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource PENNDCLPPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly EHADJJALAAA<EEHFJKKFMAD, ADEIPCBKNIG> GJGHKBMOEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly EHADJJALAAA<long, HJOMCHBGBAG> AMMFNDFDABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CEHEJJIJOPP EICBJNGPDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable EJHKEGHPACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task CCIHCKFABOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource DFCNHFGDEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long JOGJMLLMEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool JPJEOEDAIGH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private IDAGPNDMNBG PDNEGDCPCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7D65200", Offset = "0x7D64400", VA = "0x187D65200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MIOEGIOIKAG HABPCABNAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC32830", Offset = "0xC31A30", VA = "0x180C32830", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC32840", Offset = "0xC31A40", VA = "0x180C32840", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CHAOMIGHCFG<BBFGEKOOPBI> FBHHMMKFPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBDB190", Offset = "0xBDA390", VA = "0x180BDB190", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xFF3050", Offset = "0xFF2250", VA = "0x180FF3050", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CHAOMIGHCFG<Guid> GDCGADHODBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xBC6550", Offset = "0xBC5750", VA = "0x180BC6550", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC63500", Offset = "0xC62700", VA = "0x180C63500", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NENPGIPFKEI<ACOOMBENIJF, int> CJODOBJCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA96D70", Offset = "0xA95F70", VA = "0x180A96D70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA96860", Offset = "0xA95A60", VA = "0x180A96860", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CHAOMIGHCFG<IEJLCFFMNBN> OGMMKBMHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x969710", Offset = "0x968910", VA = "0x180969710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x969790", Offset = "0x968990", VA = "0x180969790", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CHAOMIGHCFG<long> CHENKPPFHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAA7240", Offset = "0xAA6440", VA = "0x180AA7240", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAA6D30", Offset = "0xAA5F30", VA = "0x180AA6D30", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MIOEGIOIKAG BBBBPPMGLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAB49E0", Offset = "0xAB3BE0", VA = "0x180AB49E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAB2F60", Offset = "0xAB2160", VA = "0x180AB2F60", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MIOEGIOIKAG IBJCGFAOPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAA90", Offset = "0x9D9C90", VA = "0x1809DAA90", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAB38A0", Offset = "0xAB2AA0", VA = "0x180AB38A0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D69660", Offset = "0x7D68860", VA = "0x187D69660")]
	[LDKBBAENJDF.GEEMEPAJEEA.KFNNKBLDKPF]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B840", Offset = "0x7D6AA40", VA = "0x187D6B840")]
	[RecRoom.NoEngine.Common.Preserve]
	public EBDLPEMGGDK([KMMHIEIDBEA(null)] GPHFIMCKLAM CKILOPBDOCI, [KMMHIEIDBEA(null)] CNANDCFFPII CJAPICFIEND, [KMMHIEIDBEA(null)] CBANICJGKMB FLIDHFGOIJN, [KMMHIEIDBEA(null)] HGMGKEGCNHK LBHHCEDLJJH, [KMMHIEIDBEA(null)] LKJLIEKKDMF NCPDCFOBKPB, [KMMHIEIDBEA(null)] PKLBFIOCMNH JPEFMFKFLJI, [KMMHIEIDBEA(null)] BLHMBNJBFMJ CCJJOKJILJL, [KMMHIEIDBEA(null)] OCEHBNKGHFP KGJAANFHCHL, [KMMHIEIDBEA(null)] DEBNCMDODNP FOCJGMKEIGJ, [KMMHIEIDBEA(null)] FHHIANONFNH MDKMPMLAPBK, [KMMHIEIDBEA(null)] MIDGLOFLPMA OLPKELPHNPK, [KMMHIEIDBEA(null)] KDCKECJKIIM HNAPEDABKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D661A0", Offset = "0x7D653A0", VA = "0x187D661A0", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A310", Offset = "0x7D69510", VA = "0x187D6A310", Slot = "52")]
	public Task NMAPHHMIBKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D679D0", Offset = "0x7D66BD0", VA = "0x187D679D0", Slot = "20")]
	[AsyncStateMachine(typeof(JIAJDINAHDN))]
	public Task<CPEANPEHCAG<BBFGEKOOPBI, string>> GECMAAPPBAE(Guid? ALKMFINCAJJ, long KCAAOMDKNIH, string MBDFMCIDAOB, string BIGHOOCGPMA, string FIBIFGBPBHH, RoomInventoryItemProperties PBKGIMHJLME, byte ADJAHFEDDPI, int JLNFDAODDKP, [Optional] List<long> GNJHEJFPOPM, [Optional] List<HJOMCHBGBAG> EDPLGIMBPBH, bool ENEHGEPAJMD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D66CF0", Offset = "0x7D65EF0", VA = "0x187D66CF0", Slot = "21")]
	[AsyncStateMachine(typeof(LPHJBPLGBNN))]
	public Task<CPEANPEHCAG<BBFGEKOOPBI, string>> EJNGGEBFHPJ(Guid LJEMMPEPGIK, long KCAAOMDKNIH, [Optional] string MBDFMCIDAOB, [Optional] string BIGHOOCGPMA, [Optional] string FIBIFGBPBHH, [Optional] List<long> GNJHEJFPOPM, [Optional] Dictionary<string, RoomInventoryTagClientProperties> EDPLGIMBPBH, [Optional] RoomInventoryItemProperties PBKGIMHJLME, [Optional] byte? ADJAHFEDDPI, [Optional] int? JLNFDAODDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D64AE0", Offset = "0x7D63CE0", VA = "0x187D64AE0", Slot = "22")]
	[AsyncStateMachine(typeof(MPGAPNBCHIF))]
	public Task<CPEANPEHCAG<bool, string>> ABNHJPDFAJD(Guid LJEMMPEPGIK, long KCAAOMDKNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D65DA0", Offset = "0x7D64FA0", VA = "0x187D65DA0", Slot = "23")]
	public IReadOnlyList<BBFGEKOOPBI> CHJAGDNLOPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D653C0", Offset = "0x7D645C0", VA = "0x187D653C0", Slot = "24")]
	public IReadOnlyList<BBFGEKOOPBI> BCAKJDFDCHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D663C0", Offset = "0x7D655C0", VA = "0x187D663C0", Slot = "25")]
	public bool EBBDJDNOIIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D66080", Offset = "0x7D65280", VA = "0x187D66080", Slot = "26")]
	public bool DKCMGMGNLMP(Guid LJEMMPEPGIK, [Out] BBFGEKOOPBI CKBMBJBFACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A0C0", Offset = "0x7D692C0", VA = "0x187D6A0C0", Slot = "27")]
	public bool MOAGGGJFNFJ(string OIFCABDMPDF, [Out] BBFGEKOOPBI CKBMBJBFACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D65BC0", Offset = "0x7D64DC0", VA = "0x187D65BC0", Slot = "28")]
	public IReadOnlyList<ACOOMBENIJF> CHCPOIHEIJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D65670", Offset = "0x7D64870", VA = "0x187D65670", Slot = "29")]
	public bool BENFNFAHECP(Guid LJEMMPEPGIK, [Out] ACOOMBENIJF MLCJGBMGEPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D68D70", Offset = "0x7D67F70", VA = "0x187D68D70", Slot = "30")]
	public long? JIHODGKIAIA(Guid LJEMMPEPGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D66EB0", Offset = "0x7D660B0", VA = "0x187D66EB0", Slot = "51")]
	public void FBCHBAFEHLC(IEnumerable<NJLEKCADGPD> FECEEACPOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D68080", Offset = "0x7D67280", VA = "0x187D68080", Slot = "31")]
	[AsyncStateMachine(typeof(EMJACLBDNBG))]
	public Task<int> HLGBDFGGILI(GJGNFGDHFCI NCAFEKBCKBL, Guid LJEMMPEPGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D69980", Offset = "0x7D68B80", VA = "0x187D69980", Slot = "32")]
	[AsyncStateMachine(typeof(KONFOMIIILC))]
	public Task<CDHEKADOEPC> MJFEAFNDCHF(GJGNFGDHFCI JMCMEIGDDHN, Guid LJEMMPEPGIK, int NFLFPJLJGMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D692A0", Offset = "0x7D684A0", VA = "0x187D692A0", Slot = "33")]
	public string KMOFMGLNLCH(LGBOBAHPBDN CMLOHOMLNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D69750", Offset = "0x7D68950", VA = "0x187D69750", Slot = "34")]
	public bool MEGGPNJNPEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D6ADD0", Offset = "0x7D69FD0", VA = "0x187D6ADD0", Slot = "38")]
	[AsyncStateMachine(typeof(FFPEKNAELFD))]
	public Task<CPEANPEHCAG<IEJLCFFMNBN, string>> PJBLGJNEKIJ(long GKGGKDFNMMA, RoomInventoryTagClientProperties PBKGIMHJLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7D673F0", Offset = "0x7D665F0", VA = "0x187D673F0", Slot = "39")]
	[AsyncStateMachine(typeof(CNJMJCLPEHL))]
	public Task<CPEANPEHCAG<bool, string>> FEPMPCLAJIE(long GKGGKDFNMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D658E0", Offset = "0x7D64AE0", VA = "0x187D658E0", Slot = "42")]
	public List<(long, int)> BOGMJDJKLDK(long CDOAKEBHIBK, int NOOLMFAKPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D68420", Offset = "0x7D67620", VA = "0x187D68420", Slot = "43")]
	public bool IHGGLKMCHLM(long GKGGKDFNMMA, [Out] IEJLCFFMNBN GDNEOPLADHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D66AF0", Offset = "0x7D65CF0", VA = "0x187D66AF0", Slot = "44")]
	public bool EFPKHKPCAAG(string BNPEPCNIPEM, [Out] IEJLCFFMNBN GDNEOPLADHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D671F0", Offset = "0x7D663F0", VA = "0x187D671F0", Slot = "45")]
	public bool FDHKIGCHPEA(long GKGGKDFNMMA, Guid HJFHEKOMAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D67900", Offset = "0x7D66B00", VA = "0x187D67900", Slot = "46")]
	public IReadOnlyList<IEJLCFFMNBN> GCAMAJJCDFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D67510", Offset = "0x7D66710", VA = "0x187D67510", Slot = "47")]
	public List<IEJLCFFMNBN> FHBFKBAOKOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D67B90", Offset = "0x7D66D90", VA = "0x187D67B90", Slot = "48")]
	public IReadOnlyList<IEJLCFFMNBN> GENHAHAAKOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D696D0", Offset = "0x7D688D0", VA = "0x187D696D0", Slot = "41")]
	public bool LOCICIEOPML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D68A90", Offset = "0x7D67C90", VA = "0x187D68A90", Slot = "49")]
	public IReadOnlyList<BBFGEKOOPBI> IPNLBADCBMD(long GKGGKDFNMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D657A0", Offset = "0x7D649A0", VA = "0x187D657A0", Slot = "40")]
	[AsyncStateMachine(typeof(CDDGLCJKMIP))]
	public Task<CPEANPEHCAG<bool, string>> BJBKHPDAOCP(long KCAAOMDKNIH, bool NNHCCKJIMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D69470", Offset = "0x7D68670", VA = "0x187D69470", Slot = "54")]
	public bool LBCMGILKCHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D64D50", Offset = "0x7D63F50", VA = "0x187D64D50", Slot = "50")]
	public bool AEBKBJJMMHC(string BNPEPCNIPEM, [Out] IReadOnlyList<BBFGEKOOPBI> POPCGIPFJOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D64C10", Offset = "0x7D63E10", VA = "0x187D64C10")]
	[AsyncStateMachine(typeof(CIJBPHEBMAO))]
	private Task<Dictionary<long, HJOMCHBGBAG>> ADOHFCMPOBE(Dictionary<long, int> AKOIIABFCJD, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A3B0", Offset = "0x7D695B0", VA = "0x187D6A3B0")]
	[AsyncStateMachine(typeof(CDJONHCNCEM))]
	private Task<CDHEKADOEPC> OGILKLPHAGB(Guid LJEMMPEPGIK, int NFLFPJLJGMO, [Optional] Guid NMPHDPHOEOO, [Optional] GJGNFGDHFCI GMLNNPIKHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D6AB80", Offset = "0x7D69D80", VA = "0x187D6AB80")]
	[AsyncStateMachine(typeof(JKDJIHLOMDP))]
	private Task<Dictionary<EEHFJKKFMAD, ADEIPCBKNIG>> PIKCNKEACJM(Dictionary<EEHFJKKFMAD, int> JCAJPBNFGJK, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D67F40", Offset = "0x7D67140", VA = "0x187D67F40")]
	[AsyncStateMachine(typeof(FGFHNENPPPH))]
	private Task<List<ADEIPCBKNIG>> HADKHMHMPIO(Dictionary<EEHFJKKFMAD, int> JCAJPBNFGJK, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A1E0", Offset = "0x7D693E0", VA = "0x187D6A1E0")]
	[AsyncStateMachine(typeof(JCKAILKPHAD))]
	private Task NGCOLBFHDNF(long KCAAOMDKNIH, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7D664C0", Offset = "0x7D656C0", VA = "0x187D664C0")]
	private Task ECNHMICKPHD(JCDLFPMDPEJ MEDGLPBHGFL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D67120", Offset = "0x7D66320", VA = "0x187D67120")]
	[AsyncStateMachine(typeof(HGAPPJEAOHA))]
	private Task FDBIAFMGPGL(JCDLFPMDPEJ MEDGLPBHGFL, CancellationToken BCMEGDDNKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D65F60", Offset = "0x7D65160", VA = "0x187D65F60")]
	private void DIIDLGIEEGB(BNHFGEMKEKK KJKILMDPFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B320", Offset = "0x7D6A520", VA = "0x187D6B320")]
	[FFNFKFIEFNL]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string ADEDCIBOFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D694E0", Offset = "0x7D686E0", VA = "0x187D694E0")]
	private void LLJEDOLJCIJ(Guid LJEMMPEPGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B460", Offset = "0x7D6A660", VA = "0x187D6B460")]
	[FFNFKFIEFNL]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid LJEMMPEPGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D682E0", Offset = "0x7D674E0", VA = "0x187D682E0")]
	[AsyncStateMachine(typeof(OGOJHIDGKNK))]
	private Task<int> IFCFLBMHNII(GJGNFGDHFCI NCAFEKBCKBL, Guid LJEMMPEPGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B130", Offset = "0x7D6A330", VA = "0x187D6B130")]
	[FFNFKFIEFNL]
	internal void RpcGetPlayerRoomInventoryCount(Guid LDHEJEOPGBF, Guid LJEMMPEPGIK, PAIBCENKFDF LEOELMHJFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B0B0", Offset = "0x7D6A2B0", VA = "0x187D6B0B0")]
	[FFNFKFIEFNL]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid LDHEJEOPGBF, int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D69090", Offset = "0x7D68290", VA = "0x187D69090")]
	[AsyncStateMachine(typeof(MLPNGDAPMDE))]
	private Task<CDHEKADOEPC> KHKLALDEKCA(GJGNFGDHFCI NCAFEKBCKBL, Guid LJEMMPEPGIK, int NFLFPJLJGMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D6AFE0", Offset = "0x7D6A1E0", VA = "0x187D6AFE0")]
	[FFNFKFIEFNL]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid LDHEJEOPGBF, Guid LJEMMPEPGIK, int NFLFPJLJGMO, PAIBCENKFDF LEOELMHJFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A500", Offset = "0x7D69700", VA = "0x187D6A500")]
	private void OOJKFJMHEKP(GJGNFGDHFCI JMCMEIGDDHN, Guid LDHEJEOPGBF, LGBOBAHPBDN CMLOHOMLNDL, long FOOBLEALIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B710", Offset = "0x7D6A910", VA = "0x187D6B710")]
	[FFNFKFIEFNL]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid LDHEJEOPGBF, int CMLOHOMLNDL, long FOOBLEALIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D66B80", Offset = "0x7D65D80", VA = "0x187D66B80")]
	private void EHBHFFPFBJH(bool NNHCCKJIMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B6B0", Offset = "0x7D6A8B0", VA = "0x187D6B6B0")]
	[FFNFKFIEFNL]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool JDBEKLNKCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D681C0", Offset = "0x7D673C0", VA = "0x187D681C0")]
	private void HMHEFLAKJOO(List<HJOMCHBGBAG> BNHEEMFDKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B500", Offset = "0x7D6A700", VA = "0x187D6B500")]
	[FFNFKFIEFNL]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string BKNAPPHPCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D65250", Offset = "0x7D64450", VA = "0x187D65250")]
	private void ANKDFAACBGL(long GKGGKDFNMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B490", Offset = "0x7D6A690", VA = "0x187D6B490")]
	[FFNFKFIEFNL]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long GKGGKDFNMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D676E0", Offset = "0x7D668E0", VA = "0x187D676E0")]
	private BBFGEKOOPBI FOJNPIMBGLH(BNHFGEMKEKK KJKILMDPFOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D66910", Offset = "0x7D65B10", VA = "0x187D66910")]
	private List<IEJLCFFMNBN> EDGABDAILAA(List<HJOMCHBGBAG> BNHEEMFDKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D684B0", Offset = "0x7D676B0", VA = "0x187D684B0")]
	private List<IEJLCFFMNBN> INEKAALOBPP(IEnumerable<HJOMCHBGBAG> BNHEEMFDKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A730", Offset = "0x7D69930", VA = "0x187D6A730", Slot = "36")]
	public RoomInventoryItemProperties PGLPKDEEIBC(string NDNKCMAHNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D69F20", Offset = "0x7D69120", VA = "0x187D69F20")]
	private BBFGEKOOPBI MLNPIPCEIHP(BNHFGEMKEKK KJKILMDPFOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D675A0", Offset = "0x7D667A0", VA = "0x187D675A0", Slot = "35")]
	public BNHFGEMKEKK FJLKHFDPIJG(BBFGEKOOPBI GHEEIEBFMDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D68800", Offset = "0x7D67A00", VA = "0x187D68800")]
	private IEJLCFFMNBN IPJFGINECDO(HJOMCHBGBAG KJKILMDPFOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7D6AF00", Offset = "0x7D6A100", VA = "0x187D6AF00")]
	private void PKDOOFPBIMG(ACOOMBENIJF MLCJGBMGEPO, int ELJJNGOIJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7D6AF70", Offset = "0x7D6A170", VA = "0x187D6AF70")]
	private void PLNKAPFOCBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7D68F00", Offset = "0x7D68100", VA = "0x187D68F00")]
	private Task JLFAMAJNDID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A6C0", Offset = "0x7D698C0", VA = "0x187D6A6C0")]
	private void PBKBJCFPGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D691E0", Offset = "0x7D683E0", VA = "0x187D691E0")]
	private void KHMJBPDMAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D6ACC0", Offset = "0x7D69EC0", VA = "0x187D6ACC0")]
	private void PIPOKCKNLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7D65E50", Offset = "0x7D65050", VA = "0x187D65E50")]
	[AsyncStateMachine(typeof(DBCPJNFELBF))]
	private Task CKDPCBGICMJ(BBFGEKOOPBI IACHGGGEMAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D658C0", Offset = "0x7D64AC0", VA = "0x187D658C0")]
	[CompilerGenerated]
	private void BLKOMKIGBFG(Task<TaskStatus> JJCLBODJJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D69AD0", Offset = "0x7D68CD0", VA = "0x187D69AD0")]
	[CompilerGenerated]
	private Task<LGBOBAHPBDN> MLCJCJHMOBO(KGONNLMCFAN P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D697C0", Offset = "0x7D689C0", VA = "0x187D697C0")]
	[CompilerGenerated]
	internal static Dictionary<EEHFJKKFMAD, ADEIPCBKNIG> MJCDEHHEBLC(LGBOBAHPBDN CMLOHOMLNDL, FFIHGGHNPCM P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ANBOAANHHCE : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D61F90", Offset = "0x7D61190", VA = "0x187D61F90")]
	public ANBOAANHHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DEBNCMDODNP
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PHFNNMCCPJG MKPJHAAIODI();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ANBOAANHHCE NDLLMBJGKFC();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JJPAJAPEJPF HLOPDGBPIPL();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FFEPJEFDKDA : DEBNCMDODNP
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D6CB80", Offset = "0x7D6BD80", VA = "0x187D6CB80")]
	[LDKBBAENJDF.GEEMEPAJEEA.KFNNKBLDKPF]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FFEPJEFDKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D6CBF0", Offset = "0x7D6BDF0", VA = "0x187D6CBF0", Slot = "4")]
	public PHFNNMCCPJG MKPJHAAIODI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D6CD00", Offset = "0x7D6BF00", VA = "0x187D6CD00", Slot = "5")]
	public ANBOAANHHCE NDLLMBJGKFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D6CA90", Offset = "0x7D6BC90", VA = "0x187D6CA90", Slot = "6")]
	public JJPAJAPEJPF HLOPDGBPIPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JJPAJAPEJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, IEJLCFFMNBN> ANFJLIFADHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly IEJLCFFMNBN[] NPGCMCFGPEG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IHBNEKNJECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB96CC0", Offset = "0xB95EC0", VA = "0x180B96CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB96CD0", Offset = "0xB95ED0", VA = "0x180B96CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MIFOOGILMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7D70C70", Offset = "0x7D6FE70", VA = "0x187D70C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long DHDFMHJLOCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x964ED0", Offset = "0x9640D0", VA = "0x180964ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D707B0", Offset = "0x7D6F9B0", VA = "0x187D707B0")]
	public void EAEBMKLJJFN(long KCAAOMDKNIH, IEnumerable<IEJLCFFMNBN> ANPAKJGAMFF, bool OKNHEAIMBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D71140", Offset = "0x7D70340", VA = "0x187D71140")]
	public IReadOnlyList<IEJLCFFMNBN> NPBLKPACINK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xB96CD0", Offset = "0xB95ED0", VA = "0x180B96CD0")]
	public void GAIHGEPFLAF(bool NNHCCKJIMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D70FC0", Offset = "0x7D701C0", VA = "0x187D70FC0")]
	public bool LMOAFHCMKCK(long GKGGKDFNMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D70E00", Offset = "0x7D70000", VA = "0x187D70E00")]
	public bool JCOJDMBPFDP(IEJLCFFMNBN FCLOPGNDNPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D702E0", Offset = "0x7D6F4E0", VA = "0x187D702E0")]
	public bool CMIPFGKLINM(List<IEJLCFFMNBN> IGMJIFPHHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D710A0", Offset = "0x7D702A0", VA = "0x187D710A0")]
	public bool NEIFCEBLMEE(long GKGGKDFNMMA, [Out] IEJLCFFMNBN DIOGKKBMGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D70600", Offset = "0x7D6F800", VA = "0x187D70600")]
	public bool DGDGFCFLDFI(string MBDFMCIDAOB, [Out] IEJLCFFMNBN DIOGKKBMGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D70D30", Offset = "0x7D6FF30", VA = "0x187D70D30")]
	public List<IEJLCFFMNBN> GHCHMBEIIJH(int KOOLKCPAFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D701A0", Offset = "0x7D6F3A0", VA = "0x187D701A0")]
	public List<IEJLCFFMNBN> CACMGHMLKAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6559810", Offset = "0x6558A10", VA = "0x186559810")]
	public IEJLCFFMNBN HMMPJKOCHGN(int KOOLKCPAFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D70CD0", Offset = "0x7D6FED0", VA = "0x187D70CD0")]
	public IReadOnlyList<IEJLCFFMNBN> FMJLBCJBILG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D712F0", Offset = "0x7D704F0", VA = "0x187D712F0")]
	public JJPAJAPEJPF()
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
