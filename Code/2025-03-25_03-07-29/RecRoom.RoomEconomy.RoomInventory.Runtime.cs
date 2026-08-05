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
		[Cpp2IlInjected.Address(RVA = "0x7F95FF0", Offset = "0x7F953F0", VA = "0x187F95FF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HMIBGMKFIFM : HBMHKKECLHH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HDLBGJABPOO AMCIIPFLKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class JFHOGMDFIAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, AHMFNMOJGNK> IEICAKBOCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, AHMFNMOJGNK> GAEFEKOIPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? LGFBIFAHNFB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long BKLLPDKHGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9933E0", Offset = "0x9927E0", VA = "0x1809933E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AHMFNMOJGNK PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F90850", Offset = "0x7F8FC50", VA = "0x187F90850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F901D0", Offset = "0x7F8F5D0", VA = "0x187F901D0")]
	public void LNCJCCFIMMK(long CCHPCHDJHAI, IEnumerable<DPJHCECGLPF> HFJJHMJOAOJ, IEnumerable<JKDDHMPCMHK> IDMPNEKDPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F900D0", Offset = "0x7F8F4D0", VA = "0x187F900D0")]
	public bool KOKDOEBJIBF(Guid LCKBPFGKBFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F990", Offset = "0x7F8ED90", VA = "0x187F8F990")]
	public bool FBDLIPAFCGJ(Guid LCKBPFGKBFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FC50", Offset = "0x7F8F050", VA = "0x187F8FC50")]
	public bool KAMNFJFPHGC(DPJHCECGLPF EFPCNBPBPFD, [Out] DPJHCECGLPF IEBOKCHOLDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F909F0", Offset = "0x7F8FDF0", VA = "0x187F909F0")]
	public IEnumerable<AHMFNMOJGNK> NFMACDKJNHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F908B0", Offset = "0x7F8FCB0", VA = "0x187F908B0")]
	public IEnumerable<DPJHCECGLPF> NDBKGFLNODN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FA60", Offset = "0x7F8EE60", VA = "0x187F8FA60")]
	public IEnumerable<JKDDHMPCMHK> IALJBAMKGBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F9B0", Offset = "0x7F8EDB0", VA = "0x187F8F9B0")]
	public bool GCDCHECOMBC(Guid LCKBPFGKBFE, [Out] DPJHCECGLPF OELACLMCBCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F90130", Offset = "0x7F8F530", VA = "0x187F90130")]
	public bool LBHLBDPAMFK(string KNJGFINMDOE, [Out] DPJHCECGLPF OELACLMCBCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FBA0", Offset = "0x7F8EFA0", VA = "0x187F8FBA0")]
	public bool KAKDAOEMPDN(Guid LCKBPFGKBFE, [Out] JKDDHMPCMHK FGDBOHANNAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F90C90", Offset = "0x7F90090", VA = "0x187F90C90")]
	public bool OHCJALNKOLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F7E0", Offset = "0x7F8EBE0", VA = "0x187F8F7E0")]
	private bool BHJNALAFNOI(DPJHCECGLPF CENPJDFMJJI, DPJHCECGLPF PKLNGDOJLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F90A40", Offset = "0x7F8FE40", VA = "0x187F90A40")]
	private void NNLNODKGOJN(Guid KDCAMOIGIMA, AHMFNMOJGNK BJAKGJHCCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FE80", Offset = "0x7F8F280", VA = "0x187F8FE80")]
	private bool KIOKOIOOHCO(Guid KDCAMOIGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F8A0", Offset = "0x7F8ECA0", VA = "0x187F8F8A0")]
	private void EEIKOIMCDCO(DPJHCECGLPF DABJINGMPEO, [Optional] DPJHCECGLPF LBODIOHPOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F90D30", Offset = "0x7F90130", VA = "0x187F90D30")]
	private bool PFPLLPMGNGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F860", Offset = "0x7F8EC60", VA = "0x187F8F860")]
	private static bool BKPLNOLCICH(DPJHCECGLPF DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F90F10", Offset = "0x7F90310", VA = "0x187F90F10")]
	public JFHOGMDFIAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HDLBGJABPOO : NAKGNHBLJHI, HNPNNPCNMCC, IDisposable, MABBDEHLNIE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct LJJPBLGPJOO : IEquatable<LJJPBLGPJOO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long BKLLPDKHGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid CPJAPEHHBIJ;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4D46BA0", Offset = "0x4D45FA0", VA = "0x184D46BA0")]
		public LJJPBLGPJOO(long CCHPCHDJHAI, Guid LCKBPFGKBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F93920", Offset = "0x7F92D20", VA = "0x187F93920", Slot = "4")]
		public bool Equals(LJJPBLGPJOO JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F937C0", Offset = "0x7F92BC0", VA = "0x187F937C0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7F93A20", Offset = "0x7F92E20", VA = "0x187F93A20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AMEDNHIFDPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DPJHCECGLPF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public HDLBGJABPOO <>4__this;

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
		public List<FOIPKOPIAFH> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<HHLHBEHEDKE<FOMKCEKELFC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7F82D60", Offset = "0x7F82160", VA = "0x187F82D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F83270", Offset = "0x7F82670", VA = "0x187F83270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct EAIPBHBDPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DPJHCECGLPF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HDLBGJABPOO <>4__this;

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
		private TaskAwaiter<HHLHBEHEDKE<FOMKCEKELFC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7F848B0", Offset = "0x7F83CB0", VA = "0x187F848B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F85100", Offset = "0x7F84500", VA = "0x187F85100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ALMHGCMBHOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private DPJHCECGLPF <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private JHDDEHBOPMH <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<JHDDEHBOPMH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7F824E0", Offset = "0x7F818E0", VA = "0x187F824E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F82CF0", Offset = "0x7F820F0", VA = "0x187F82CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IIDENLLMDHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public FEIKLGLBIHI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E150", Offset = "0x7F8D550", VA = "0x187F8E150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E4D0", Offset = "0x7F8D8D0", VA = "0x187F8E4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GNGHPAPEGOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<CONBNBAPBCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public FEIKLGLBIHI recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<CONBNBAPBCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7F86380", Offset = "0x7F85780", VA = "0x187F86380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F867E0", Offset = "0x7F85BE0", VA = "0x187F867E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct NFELEAACAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<IOCENEHPCPF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IOCENEHPCPF <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F94BC0", Offset = "0x7F93FC0", VA = "0x187F94BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7F95040", Offset = "0x7F94440", VA = "0x187F95040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct OIEGPCOLAEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<IOCENEHPCPF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<AEAAIINGJNL<IOCENEHPCPF, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<JHDDEHBOPMH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7F950F0", Offset = "0x7F944F0", VA = "0x187F950F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F95D00", Offset = "0x7F95100", VA = "0x187F95D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IMHGLIHLHNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<JHDDEHBOPMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7F8EAB0", Offset = "0x7F8DEB0", VA = "0x187F8EAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F8EFD0", Offset = "0x7F8E3D0", VA = "0x187F8EFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LPOJBBMFGNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, FOIPKOPIAFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<HHLHBEHEDKE<List<FOIPKOPIAFH>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7F94190", Offset = "0x7F93590", VA = "0x187F94190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F94B50", Offset = "0x7F93F50", VA = "0x187F94B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PCGDKIMIOHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JKDDHMPCMHK playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JCOBLDAPJHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<CONBNBAPBCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private PCGDKIMIOHC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public FEIKLGLBIHI awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<HNHIHJACJMD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7F8F320", Offset = "0x7F8E720", VA = "0x187F8F320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F8F770", Offset = "0x7F8EB70", VA = "0x187F8F770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct JDIBMJALKGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<LJJPBLGPJOO, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class APCPEGOOKFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public HNHIHJACJMD result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public APCPEGOOKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7F832E0", Offset = "0x7F826E0", VA = "0x187F832E0")]
		internal BCGFNLNNCLC GNBCEDBHPAM(LJJPBLGPJOO id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JJFALDJKPDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<LJJPBLGPJOO, BCGFNLNNCLC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<LJJPBLGPJOO, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private JDIBMJALKGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<BCGFNLNNCLC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F90FF0", Offset = "0x7F903F0", VA = "0x187F90FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F91AA0", Offset = "0x7F90EA0", VA = "0x187F91AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct DOMCHKNGCFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<BCGFNLNNCLC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<LJJPBLGPJOO, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<BCGFNLNNCLC> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<BCGFNLNNCLC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F838E0", Offset = "0x7F82CE0", VA = "0x187F838E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7F84840", Offset = "0x7F83C40", VA = "0x187F84840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct JOOOJPICOOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<FOMKCEKELFC>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<KINDJFIHIDL>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<FOIPKOPIAFH>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<GBLIKIJGJBA> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<DPJHCECGLPF> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<JKDDHMPCMHK> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<IOCENEHPCPF> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<FOMKCEKELFC>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<KINDJFIHIDL>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<FOIPKOPIAFH>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<GBLIKIJGJBA> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F91B10", Offset = "0x7F90F10", VA = "0x187F91B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D50", Offset = "0x7F92150", VA = "0x187F92D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct LOGKGOPDFDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F93AA0", Offset = "0x7F92EA0", VA = "0x187F93AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F94130", Offset = "0x7F93530", VA = "0x187F94130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct IIGENKBJPCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public FEIKLGLBIHI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E540", Offset = "0x7F8D940", VA = "0x187F8E540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F8EA40", Offset = "0x7F8DE40", VA = "0x187F8EA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CGDCDIFGKIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<CONBNBAPBCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public FEIKLGLBIHI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<CONBNBAPBCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F83350", Offset = "0x7F82750", VA = "0x187F83350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F83870", Offset = "0x7F82C70", VA = "0x187F83870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LHJDKKCBGHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public DPJHCECGLPF itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public HDLBGJABPOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<AEAAIINGJNL<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F92DB0", Offset = "0x7F921B0", VA = "0x187F92DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F93760", Offset = "0x7F92B60", VA = "0x187F93760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan DEICDCMDPDP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float JAFLHPIKFIO = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float HPBGOKHIEJN = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int EAIFGAFHNCD = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string LNMKAOLMELG = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string DBJCPKMNDAD = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MMKKBMHBGLC MGBCGABELGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly OCGKEGJBLKE FNOAEPCHJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BMGELHNKDLK FLJEPECPPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LOJECIKAFKG CDDIGBAACFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BCHJLKPLLNL KELGJGNBONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HMIBGMKFIFM KGDNBAABJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HNAFBHEKIKK JHNCNOHACNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MNPJMLDINEN AFLKDAGOLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KHKCCPNIAAP FPPOAHLPNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly JFHOGMDFIAG AAHDPCBGBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly FCNHMGDIMDE JKCBNOIBIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly OIBIDMILAFP IOADMBNKDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource CEDDMPNECFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly DFFMDKECDPM<LJJPBLGPJOO, BCGFNLNNCLC> DAIMPCHEOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DFFMDKECDPM<long, FOIPKOPIAFH> LJIADBCBLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly FIAJIKDECGI EONHJNFGKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable LLOKKPKJAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task OFMJMJGJLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource EIPPIEPHNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long MKALKNEBMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool MIGDMPFDAHI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private ENKIKIBAPOM POBHAPJDNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F87370", Offset = "0x7F86770", VA = "0x187F87370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OLDENIALAEA JJDNINICKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC82700", Offset = "0xC81B00", VA = "0x180C82700", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC82710", Offset = "0xC81B10", VA = "0x180C82710", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OHMOKFGANBG<DPJHCECGLPF> PFKHMHMEDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC2B210", Offset = "0xC2A610", VA = "0x180C2B210", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1069B40", Offset = "0x1068F40", VA = "0x181069B40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OHMOKFGANBG<Guid> LAJAMLFMNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC16AE0", Offset = "0xC15EE0", VA = "0x180C16AE0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xCCE510", Offset = "0xCCD910", VA = "0x180CCE510", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ABNIGPKKHEA<JKDDHMPCMHK, int> JAJOBJDOBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA0FF70", Offset = "0xA0F370", VA = "0x180A0FF70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA14B20", Offset = "0xA13F20", VA = "0x180A14B20", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public OHMOKFGANBG<IOCENEHPCPF> PHOAIGBDCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x999C40", Offset = "0x999040", VA = "0x180999C40", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x999CC0", Offset = "0x9990C0", VA = "0x180999CC0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OHMOKFGANBG<long> ANJHHLLONKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA18180", Offset = "0xA17580", VA = "0x180A18180", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAF6090", Offset = "0xAF5490", VA = "0x180AF6090", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OLDENIALAEA HLLFEMNMCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA17D10", Offset = "0xA17110", VA = "0x180A17D10", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB02680", Offset = "0xB01A80", VA = "0x180B02680", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OLDENIALAEA MCJICAODLII
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA10110", Offset = "0xA0F510", VA = "0x180A10110", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA08D40", Offset = "0xA08140", VA = "0x180A08D40", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F88A80", Offset = "0x7F87E80", VA = "0x187F88A80")]
	[BOBPNFIGGBE.FIPHDKCKMAJ.LALHFPBIBCF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D5D0", Offset = "0x7F8C9D0", VA = "0x187F8D5D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HDLBGJABPOO([GKAMHFFOHNI(null)] MMKKBMHBGLC MGBCGABELGB, [GKAMHFFOHNI(null)] OCGKEGJBLKE FNOAEPCHJHE, [GKAMHFFOHNI(null)] BMGELHNKDLK FLJEPECPPMC, [GKAMHFFOHNI(null)] LOJECIKAFKG CDDIGBAACFF, [GKAMHFFOHNI(null)] AHFKEHIEJLO CDJLLPGBCKE, [GKAMHFFOHNI(null)] BCHJLKPLLNL KELGJGNBONF, [GKAMHFFOHNI(null)] HMIBGMKFIFM KGDNBAABJGB, [GKAMHFFOHNI(null)] AJHIHCOEHDB IPFGNJGMMIH, [GKAMHFFOHNI(null)] EHEFBCICEIA FHMMKFELBLB, [GKAMHFFOHNI(null)] HNAFBHEKIKK JHNCNOHACNN, [GKAMHFFOHNI(null)] MNPJMLDINEN AFLKDAGOLDB, [GKAMHFFOHNI(null)] KHKCCPNIAAP FPPOAHLPNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F87B00", Offset = "0x7F86F00", VA = "0x187F87B00", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F88090", Offset = "0x7F87490", VA = "0x187F88090", Slot = "52")]
	public Task FLFJCIOGIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F88FB0", Offset = "0x7F883B0", VA = "0x187F88FB0", Slot = "20")]
	[AsyncStateMachine(typeof(AMEDNHIFDPH))]
	public Task<AEAAIINGJNL<DPJHCECGLPF, string>> IMILGELAMNM(Guid? LDHNGFEPBJC, long CCHPCHDJHAI, string MPGDCPPMNJN, string DPHOGONECCJ, string CFKIPPLHIHC, RoomInventoryItemProperties JAIBFAIMPCH, byte MKAKNMKKKCL, int CKANMCILFBE, [Optional] List<long> EGNAGDHCNLH, [Optional] List<FOIPKOPIAFH> MEFMHMJKMLE, bool FAKIJHHAIHP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F89990", Offset = "0x7F88D90", VA = "0x187F89990", Slot = "21")]
	[AsyncStateMachine(typeof(EAIPBHBDPMA))]
	public Task<AEAAIINGJNL<DPJHCECGLPF, string>> JFGFCBBPMLK(Guid LCKBPFGKBFE, long CCHPCHDJHAI, [Optional] string MPGDCPPMNJN, [Optional] string DPHOGONECCJ, [Optional] string CFKIPPLHIHC, [Optional] List<long> EGNAGDHCNLH, [Optional] Dictionary<string, RoomInventoryTagClientProperties> MEFMHMJKMLE, [Optional] RoomInventoryItemProperties JAIBFAIMPCH, [Optional] byte? MKAKNMKKKCL, [Optional] int? CKANMCILFBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F8BFA0", Offset = "0x7F8B3A0", VA = "0x187F8BFA0", Slot = "22")]
	[AsyncStateMachine(typeof(ALMHGCMBHOH))]
	public Task<AEAAIINGJNL<bool, string>> OPODNCEOMKI(Guid LCKBPFGKBFE, long CCHPCHDJHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F87130", Offset = "0x7F86530", VA = "0x187F87130", Slot = "23")]
	public IReadOnlyList<DPJHCECGLPF> CGBMLLBHNBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A9A0", Offset = "0x7F89DA0", VA = "0x187F8A9A0", Slot = "24")]
	public IReadOnlyList<DPJHCECGLPF> LLOMFNNCLEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F89B50", Offset = "0x7F88F50", VA = "0x187F89B50", Slot = "25")]
	public bool JNBMENJGENN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F88270", Offset = "0x7F87670", VA = "0x187F88270", Slot = "26")]
	public bool GCDCHECOMBC(Guid LCKBPFGKBFE, [Out] DPJHCECGLPF OELACLMCBCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A680", Offset = "0x7F89A80", VA = "0x187F8A680", Slot = "27")]
	public bool LBHLBDPAMFK(string INOINOOPNPL, [Out] DPJHCECGLPF OELACLMCBCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7F896F0", Offset = "0x7F88AF0", VA = "0x187F896F0", Slot = "28")]
	public IReadOnlyList<JKDDHMPCMHK> JDIDCCFIFCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F89D80", Offset = "0x7F89180", VA = "0x187F89D80", Slot = "29")]
	public bool KAKDAOEMPDN(Guid LCKBPFGKBFE, [Out] JKDDHMPCMHK FGDBOHANNAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F89EB0", Offset = "0x7F892B0", VA = "0x187F89EB0", Slot = "30")]
	public long? KKFFNLEGAFN(Guid LCKBPFGKBFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F87E20", Offset = "0x7F87220", VA = "0x187F87E20", Slot = "51")]
	public void FECPIEFILJF(IEnumerable<KINDJFIHIDL> IDMPNEKDPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8AF00", Offset = "0x7F8A300", VA = "0x187F8AF00", Slot = "31")]
	[AsyncStateMachine(typeof(IIDENLLMDHN))]
	public Task<int> MAOIEKLIJEA(FEIKLGLBIHI CALAFNPECBD, Guid LCKBPFGKBFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8BE50", Offset = "0x7F8B250", VA = "0x187F8BE50", Slot = "32")]
	[AsyncStateMachine(typeof(GNGHPAPEGOD))]
	public Task<CONBNBAPBCN> ONHBEGNHFHN(FEIKLGLBIHI KFDNMJGLLMH, Guid LCKBPFGKBFE, int OMDEPJMGLPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CB30", Offset = "0x7F8BF30", VA = "0x187F8CB30", Slot = "33")]
	public string PPGPJLBPLME(HNHIHJACJMD KGODHHBLJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F87DB0", Offset = "0x7F871B0", VA = "0x187F87DB0", Slot = "34")]
	public bool EMFKPNNNOHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F89C50", Offset = "0x7F89050", VA = "0x187F89C50", Slot = "38")]
	[AsyncStateMachine(typeof(NFELEAACAMI))]
	public Task<AEAAIINGJNL<IOCENEHPCPF, string>> JOGMKHBOMKI(long HBPFNGBAFCK, RoomInventoryTagClientProperties JAIBFAIMPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A880", Offset = "0x7F89C80", VA = "0x187F8A880", Slot = "39")]
	[AsyncStateMachine(typeof(OIEGPCOLAEE))]
	public Task<AEAAIINGJNL<bool, string>> LKLNIHCLEDA(long HBPFNGBAFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B040", Offset = "0x7F8A440", VA = "0x187F8B040", Slot = "42")]
	public List<(long, int)> MMMEELCGDHF(long JPPALOGBMHE, int AMIDCPOLCHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F88AF0", Offset = "0x7F87EF0", VA = "0x187F88AF0", Slot = "43")]
	public bool HICCABJPKAE(long HBPFNGBAFCK, [Out] IOCENEHPCPF AODKHBAKKEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F87D20", Offset = "0x7F87120", VA = "0x187F87D20", Slot = "44")]
	public bool EJNLDAAIPFJ(string HKPJHGKOANM, [Out] IOCENEHPCPF AODKHBAKKEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F885F0", Offset = "0x7F879F0", VA = "0x187F885F0", Slot = "45")]
	public bool GLIODNBKGLJ(long HBPFNGBAFCK, Guid MGBCFEFBNCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F8AE30", Offset = "0x7F8A230", VA = "0x187F8AE30", Slot = "46")]
	public IReadOnlyList<IOCENEHPCPF> LOJIHPDKGNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F870A0", Offset = "0x7F864A0", VA = "0x187F870A0", Slot = "47")]
	public List<IOCENEHPCPF> CBIMMJDCKLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F86850", Offset = "0x7F85C50", VA = "0x187F86850", Slot = "48")]
	public IReadOnlyList<IOCENEHPCPF> ADOBMHFEDBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F86EE0", Offset = "0x7F862E0", VA = "0x187F86EE0", Slot = "41")]
	public bool AOEJMIMHOJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B430", Offset = "0x7F8A830", VA = "0x187F8B430", Slot = "49")]
	public IReadOnlyList<DPJHCECGLPF> NGDMJBDPCMO(long HBPFNGBAFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F884D0", Offset = "0x7F878D0", VA = "0x187F884D0", Slot = "40")]
	[AsyncStateMachine(typeof(IMHGLIHLHNP))]
	public Task<AEAAIINGJNL<bool, string>> GJKCMHACNLK(long CCHPCHDJHAI, bool AGBCADJFPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F86F60", Offset = "0x7F86360", VA = "0x187F86F60", Slot = "54")]
	public bool APNONJAOMDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B860", Offset = "0x7F8AC60", VA = "0x187F8B860", Slot = "50")]
	public bool OGNHKOFNMDL(string HKPJHGKOANM, [Out] IReadOnlyList<DPJHCECGLPF> GMMDMBCPGKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F86C00", Offset = "0x7F86000", VA = "0x187F86C00")]
	[AsyncStateMachine(typeof(LPOJBBMFGNP))]
	private Task<Dictionary<long, FOIPKOPIAFH>> AGCBDCLIOID(Dictionary<long, int> CBBOJKGAIBA, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B710", Offset = "0x7F8AB10", VA = "0x187F8B710")]
	[AsyncStateMachine(typeof(JCOBLDAPJHE))]
	private Task<CONBNBAPBCN> OGJDAHHLNDI(Guid LCKBPFGKBFE, int OMDEPJMGLPG, [Optional] Guid NNEADLBNLLM, [Optional] FEIKLGLBIHI AJDHJONPGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F88130", Offset = "0x7F87530", VA = "0x187F88130")]
	[AsyncStateMachine(typeof(JJFALDJKPDH))]
	private Task<Dictionary<LJJPBLGPJOO, BCGFNLNNCLC>> FPGDDFFDGML(Dictionary<LJJPBLGPJOO, int> KDIMFHGBEHM, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F8BD10", Offset = "0x7F8B110", VA = "0x187F8BD10")]
	[AsyncStateMachine(typeof(DOMCHKNGCFG))]
	private Task<List<BCGFNLNNCLC>> OIBJOPFIFCP(Dictionary<LJJPBLGPJOO, int> KDIMFHGBEHM, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F873C0", Offset = "0x7F867C0", VA = "0x187F873C0")]
	[AsyncStateMachine(typeof(JOOOJPICOOG))]
	private Task DAOGGPKHKKF(long CCHPCHDJHAI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F89170", Offset = "0x7F88570", VA = "0x187F89170")]
	private Task IODOBFGMOKM(CFLKKNKAIAK JOIGLCNPHIH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F86FD0", Offset = "0x7F863D0", VA = "0x187F86FD0")]
	[AsyncStateMachine(typeof(LOGKGOPDFDD))]
	private Task BBOKCKEOCFM(CFLKKNKAIAK JOIGLCNPHIH, CancellationToken BGFGLAFLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F895D0", Offset = "0x7F889D0", VA = "0x187F895D0")]
	private void JAPCLLLBPIC(FOMKCEKELFC MGPIFOHIEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D0B0", Offset = "0x7F8C4B0", VA = "0x187F8D0B0")]
	[KBGKKNFCDLD]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string LEPHFGJAHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F87710", Offset = "0x7F86B10", VA = "0x187F87710")]
	private void DIIFFHGBDHO(Guid LCKBPFGKBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D1F0", Offset = "0x7F8C5F0", VA = "0x187F8D1F0")]
	[KBGKKNFCDLD]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid LCKBPFGKBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F88390", Offset = "0x7F87790", VA = "0x187F88390")]
	[AsyncStateMachine(typeof(IIGENKBJPCA))]
	private Task<int> GEDLLACKJNO(FEIKLGLBIHI CALAFNPECBD, Guid LCKBPFGKBFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CEC0", Offset = "0x7F8C2C0", VA = "0x187F8CEC0")]
	[KBGKKNFCDLD]
	internal void RpcGetPlayerRoomInventoryCount(Guid NPMNDEDHHIJ, Guid LCKBPFGKBFE, IFGEDDNPJKP FPBOMPOFMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CE40", Offset = "0x7F8C240", VA = "0x187F8CE40")]
	[KBGKKNFCDLD]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid NPMNDEDHHIJ, int PPLOBPJCNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F87890", Offset = "0x7F86C90", VA = "0x187F87890")]
	[AsyncStateMachine(typeof(CGDCDIFGKIL))]
	private Task<CONBNBAPBCN> DLJOLEDJIPK(FEIKLGLBIHI CALAFNPECBD, Guid LCKBPFGKBFE, int OMDEPJMGLPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CD70", Offset = "0x7F8C170", VA = "0x187F8CD70")]
	[KBGKKNFCDLD]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid NPMNDEDHHIJ, Guid LCKBPFGKBFE, int OMDEPJMGLPG, IFGEDDNPJKP FPBOMPOFMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F88DF0", Offset = "0x7F881F0", VA = "0x187F88DF0")]
	private void IJNHDJKFLEE(FEIKLGLBIHI KFDNMJGLLMH, Guid NPMNDEDHHIJ, HNHIHJACJMD KGODHHBLJOE, long FACGDOOIHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D4A0", Offset = "0x7F8C8A0", VA = "0x187F8D4A0")]
	[KBGKKNFCDLD]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid NPMNDEDHHIJ, int KGODHHBLJOE, long FACGDOOIHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A1B0", Offset = "0x7F895B0", VA = "0x187F8A1B0")]
	private void KLBIDILBDIC(bool AGBCADJFPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D440", Offset = "0x7F8C840", VA = "0x187F8D440")]
	[KBGKKNFCDLD]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool DMLLPJLHINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F879E0", Offset = "0x7F86DE0", VA = "0x187F879E0")]
	private void DMNDENDAGCL(List<FOIPKOPIAFH> AKHDGELJPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D290", Offset = "0x7F8C690", VA = "0x187F8D290")]
	[KBGKKNFCDLD]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string FLHAKEDPBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A040", Offset = "0x7F89440", VA = "0x187F8A040")]
	private void KKMMKHCKNNI(long HBPFNGBAFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D220", Offset = "0x7F8C620", VA = "0x187F8D220")]
	[KBGKKNFCDLD]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long HBPFNGBAFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F874F0", Offset = "0x7F868F0", VA = "0x187F874F0")]
	private DPJHCECGLPF DGDBPOCKPFE(FOMKCEKELFC MGPIFOHIEDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F8AC50", Offset = "0x7F8A050", VA = "0x187F8AC50")]
	private List<IOCENEHPCPF> LNONGDPKABG(List<FOIPKOPIAFH> AKHDGELJPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A330", Offset = "0x7F89730", VA = "0x187F8A330")]
	private List<IOCENEHPCPF> LBCIBMKDHAM(IEnumerable<FOIPKOPIAFH> AKHDGELJPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C6E0", Offset = "0x7F8BAE0", VA = "0x187F8C6E0", Slot = "36")]
	public RoomInventoryItemProperties PNLCMICFFBJ(string CLKCGDLEKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F86D40", Offset = "0x7F86140", VA = "0x187F86D40")]
	private DPJHCECGLPF AJEHLKABECP(FOMKCEKELFC MGPIFOHIEDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F88BA0", Offset = "0x7F87FA0", VA = "0x187F88BA0", Slot = "35")]
	public FOMKCEKELFC ICGJPEBKAAC(DPJHCECGLPF DBIDOBFBCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F887F0", Offset = "0x7F87BF0", VA = "0x187F887F0")]
	private IOCENEHPCPF HDJHECLIAGI(FOIPKOPIAFH MGPIFOHIEDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A7A0", Offset = "0x7F89BA0", VA = "0x187F8A7A0")]
	private void LFLIOIKFCMP(JKDDHMPCMHK FGDBOHANNAM, int OCIEEJDNOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A810", Offset = "0x7F89C10", VA = "0x187F8A810")]
	private void LJLJGIELHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7F871E0", Offset = "0x7F865E0", VA = "0x187F871E0")]
	private Task CHLGNHJCNPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CD00", Offset = "0x7F8C100", VA = "0x187F8CD00")]
	private void PPNLNGDNDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F898D0", Offset = "0x7F88CD0", VA = "0x187F898D0")]
	private void JEIHAFBIHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F88CE0", Offset = "0x7F880E0", VA = "0x187F88CE0")]
	private void IDGHAHFNNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B320", Offset = "0x7F8A720", VA = "0x187F8B320")]
	[AsyncStateMachine(typeof(LHJDKKCBGHH))]
	private Task MNFEFCPPJHK(DPJHCECGLPF HFIHLIINGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F88B80", Offset = "0x7F87F80", VA = "0x187F88B80")]
	[CompilerGenerated]
	private void HNLJNHKCCMM(Task<TaskStatus> ALKPEINKLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C0D0", Offset = "0x7F8B4D0", VA = "0x187F8C0D0")]
	[CompilerGenerated]
	private Task<HNHIHJACJMD> PJDOAAHKNCJ(PCGDKIMIOHC P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C520", Offset = "0x7F8B920", VA = "0x187F8C520")]
	[CompilerGenerated]
	internal static Dictionary<LJJPBLGPJOO, BCGFNLNNCLC> PLDIBBPDJPD(HNHIHJACJMD KGODHHBLJOE, JDIBMJALKGK P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OIBIDMILAFP : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F950B0", Offset = "0x7F944B0", VA = "0x187F950B0")]
	public OIBIDMILAFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EHEFBCICEIA
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFHOGMDFIAG MNJBLAGKEJH();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OIBIDMILAFP EIDOMBBKOBH();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCNHMGDIMDE OONBFNDDMEL();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JAMEBADFNAE : EHEFBCICEIA
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F0B0", Offset = "0x7F8E4B0", VA = "0x187F8F0B0")]
	[BOBPNFIGGBE.FIPHDKCKMAJ.LALHFPBIBCF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	[RecRoom.NoEngine.Common.Preserve]
	public JAMEBADFNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F120", Offset = "0x7F8E520", VA = "0x187F8F120", Slot = "4")]
	public JFHOGMDFIAG MNJBLAGKEJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F040", Offset = "0x7F8E440", VA = "0x187F8F040", Slot = "5")]
	public OIBIDMILAFP EIDOMBBKOBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F230", Offset = "0x7F8E630", VA = "0x187F8F230", Slot = "6")]
	public FCNHMGDIMDE OONBFNDDMEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FCNHMGDIMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, IOCENEHPCPF> CGCACFDGOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly IOCENEHPCPF[] MMHDAFEPLDE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool HNIKOOBLIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xBD2B40", Offset = "0xBD1F40", VA = "0x180BD2B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xBD2770", Offset = "0xBD1B70", VA = "0x180BD2770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FOBOJACGKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F86260", Offset = "0x7F85660", VA = "0x187F86260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long PMCHFCJKJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9933E0", Offset = "0x9927E0", VA = "0x1809933E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F85A80", Offset = "0x7F84E80", VA = "0x187F85A80")]
	public void LNCJCCFIMMK(long CCHPCHDJHAI, IEnumerable<IOCENEHPCPF> MEBHEOCCLEP, bool OLCMOBPBNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F85240", Offset = "0x7F84640", VA = "0x187F85240")]
	public IReadOnlyList<IOCENEHPCPF> COOCLGOHOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xBD2770", Offset = "0xBD1B70", VA = "0x180BD2770")]
	public void BAPIBAMDBIH(bool AGBCADJFPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F859A0", Offset = "0x7F84DA0", VA = "0x187F859A0")]
	public bool LKEIKDBHIHL(long HBPFNGBAFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F85740", Offset = "0x7F84B40", VA = "0x187F85740")]
	public bool GFJEPPCCLHB(IOCENEHPCPF OFEKPCABJDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F85F40", Offset = "0x7F85340", VA = "0x187F85F40")]
	public bool MFIEDBGJEOD(List<IOCENEHPCPF> CEDMKHOGLDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F85900", Offset = "0x7F84D00", VA = "0x187F85900")]
	public bool GOJFCOGJKKE(long HBPFNGBAFCK, [Out] IOCENEHPCPF JLMMOICKAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F853F0", Offset = "0x7F847F0", VA = "0x187F853F0")]
	public bool DAOBHHMCBNB(string MPGDCPPMNJN, [Out] IOCENEHPCPF JLMMOICKAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F85170", Offset = "0x7F84570", VA = "0x187F85170")]
	public List<IOCENEHPCPF> CHIEHOLGGNM(int KDCAMOIGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F855A0", Offset = "0x7F849A0", VA = "0x187F855A0")]
	public List<IOCENEHPCPF> DBBCNFELLJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6738E40", Offset = "0x6738240", VA = "0x186738E40")]
	public IOCENEHPCPF GBPBOJNMEAO(int KDCAMOIGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F856E0", Offset = "0x7F84AE0", VA = "0x187F856E0")]
	public IReadOnlyList<IOCENEHPCPF> DPLBCBFGKJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F862C0", Offset = "0x7F856C0", VA = "0x187F862C0")]
	public FCNHMGDIMDE()
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
