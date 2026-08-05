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
		[Cpp2IlInjected.Address(RVA = "0x74BCD80", Offset = "0x74BB780", VA = "0x1874BCD80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NNJEDJGIHIM : PKGKOCCKPPE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AEOKNCHEHNJ HAHEBGDKOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class GPEGEJHIAGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, ALAAEDJKIAP> CAMFPBAFKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, ALAAEDJKIAP> KLBCPKABCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? DJEDOMEKHAP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long FFMKJNBFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B0210", Offset = "0x8AEC10", VA = "0x1808B0210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ALAAEDJKIAP CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74B7080", Offset = "0x74B5A80", VA = "0x1874B7080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74B65D0", Offset = "0x74B4FD0", VA = "0x1874B65D0")]
	public void BMGKNHOJOBG(long NPGHGEFGHLA, IEnumerable<CLCLPFDEAGM> FONOLLCNMLF, IEnumerable<GMDJKHCNPJC> GNHGMGFHAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74B6EE0", Offset = "0x74B58E0", VA = "0x1874B6EE0")]
	public bool ECELHAJNPPP(Guid PMAKHKBNMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74B7710", Offset = "0x74B6110", VA = "0x1874B7710")]
	public bool PJOABDGMIKH(Guid PMAKHKBNMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74B70E0", Offset = "0x74B5AE0", VA = "0x1874B70E0")]
	public bool HALFKFGJMLC(CLCLPFDEAGM EKLDIFFNGEC, [Out] CLCLPFDEAGM MOMFKHOFPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74B64E0", Offset = "0x74B4EE0", VA = "0x1874B64E0")]
	public IEnumerable<ALAAEDJKIAP> BBDCKOKHHGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74B6F40", Offset = "0x74B5940", VA = "0x1874B6F40")]
	public IEnumerable<CLCLPFDEAGM> FDOKNDHKIBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74B6CF0", Offset = "0x74B56F0", VA = "0x1874B6CF0")]
	public IEnumerable<GMDJKHCNPJC> CCLOHGEDBJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x74B7730", Offset = "0x74B6130", VA = "0x1874B7730")]
	public bool POFLPMBLCAM(Guid PMAKHKBNMPF, [Out] CLCLPFDEAGM BCCAHIDJMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x74B6530", Offset = "0x74B4F30", VA = "0x1874B6530")]
	public bool BLHPLCPDGJO(string IKPBPNBJKJD, [Out] CLCLPFDEAGM BCCAHIDJMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x74B6E30", Offset = "0x74B5830", VA = "0x1874B6E30")]
	public bool DLOLOOCOCGN(Guid PMAKHKBNMPF, [Out] GMDJKHCNPJC ILKKPHIDFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74B6C50", Offset = "0x74B5650", VA = "0x1874B6C50")]
	public bool BOPIANOFEEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74B7560", Offset = "0x74B5F60", VA = "0x1874B7560")]
	private bool OKMEJBFCOCM(CLCLPFDEAGM IBFLAGMGMLI, CLCLPFDEAGM ADDBJKLLJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74B60B0", Offset = "0x74B4AB0", VA = "0x1874B60B0")]
	private void AGGBHPIICCJ(Guid GCBONJOGHCD, ALAAEDJKIAP NNLPHHGKOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74B7310", Offset = "0x74B5D10", VA = "0x1874B7310")]
	private bool LBDCNEMGDDC(Guid GCBONJOGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x74B7620", Offset = "0x74B6020", VA = "0x1874B7620")]
	private void PHADKOIAAMB(CLCLPFDEAGM PNMNGIKCLJJ, [Optional] CLCLPFDEAGM NHBCGEAPJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x74B6300", Offset = "0x74B4D00", VA = "0x1874B6300")]
	private bool AONADFDBPGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x74B75E0", Offset = "0x74B5FE0", VA = "0x1874B75E0")]
	private static bool PDAAADFFLHO(CLCLPFDEAGM GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x74B77E0", Offset = "0x74B61E0", VA = "0x1874B77E0")]
	public GPEGEJHIAGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AEOKNCHEHNJ : NPOLBNNBEFA, MHJCOHCOMMG, IDisposable, PLNLGIDKEKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct GNHLALPFPDH : IEquatable<GNHLALPFPDH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long FFMKJNBFCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid KHIIDNCNHDN;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4649790", Offset = "0x4648190", VA = "0x184649790")]
		public GNHLALPFPDH(long NPGHGEFGHLA, Guid PMAKHKBNMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x74B5F30", Offset = "0x74B4930", VA = "0x1874B5F30", Slot = "4")]
		public bool Equals(GNHLALPFPDH GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x74B5DD0", Offset = "0x74B47D0", VA = "0x1874B5DD0", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x74B6030", Offset = "0x74B4A30", VA = "0x1874B6030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PPBKFPPPNHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<CLCLPFDEAGM, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<GOBJOEKKLAP<ODBKAFGNKIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x74BC670", Offset = "0x74BB070", VA = "0x1874BC670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x74BCA90", Offset = "0x74BB490", VA = "0x1874BCA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FKCDAEAHEOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<CLCLPFDEAGM, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Dictionary<string, RoomInventoryTagClientProperties> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public RoomInventoryItemProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public List<long> tagIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte? shape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<GOBJOEKKLAP<ODBKAFGNKIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x74B5050", Offset = "0x74B3A50", VA = "0x1874B5050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x74B58A0", Offset = "0x74B42A0", VA = "0x1874B58A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MEIOKMMLLAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CLCLPFDEAGM <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private GOOALFLCKJC <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter<GOOALFLCKJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x74B9E60", Offset = "0x74B8860", VA = "0x1874B9E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x74BA670", Offset = "0x74B9070", VA = "0x1874BA670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PKELEIEEHBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public OGOAPNICIIH player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x74BC280", Offset = "0x74BAC80", VA = "0x1874BC280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x74BC600", Offset = "0x74BB000", VA = "0x1874BC600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OEJGLHKOCIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncTaskMethodBuilder<GMCCDJPEHHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public OGOAPNICIIH recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<GMCCDJPEHHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74BB130", Offset = "0x74B9B30", VA = "0x1874BB130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x74BB590", Offset = "0x74B9F90", VA = "0x1874BB590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DHINEPPFBEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<LLBHLMIBOFO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private LLBHLMIBOFO <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x74B45D0", Offset = "0x74B2FD0", VA = "0x1874B45D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x74B4A50", Offset = "0x74B3450", VA = "0x1874B4A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct OGLOLMCOAKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private List<LLBHLMIBOFO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<OKPKCEBGDLD<LLBHLMIBOFO, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<GOOALFLCKJC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x74BB600", Offset = "0x74BA000", VA = "0x1874BB600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x74BC210", Offset = "0x74BAC10", VA = "0x1874BC210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KMKHFDOMOCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<GOOALFLCKJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74B85D0", Offset = "0x74B6FD0", VA = "0x1874B85D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x74B8AF0", Offset = "0x74B74F0", VA = "0x1874B8AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct INKMCCNIDLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<Dictionary<long, CODGABJMHDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<GOBJOEKKLAP<List<CODGABJMHDI>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x74B78C0", Offset = "0x74B62C0", VA = "0x1874B78C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x74B8280", Offset = "0x74B6C80", VA = "0x1874B8280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IGAIJBDLEAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public GMDJKHCNPJC playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GKDKHGPFJLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<GMCCDJPEHHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IGAIJBDLEAH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OGOAPNICIIH awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter<PFLPKDJBOBJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x74B5910", Offset = "0x74B4310", VA = "0x1874B5910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x74B5D60", Offset = "0x74B4760", VA = "0x1874B5D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct MMDODBJCIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Dictionary<GNHLALPFPDH, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LJAILMOAKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PFLPKDJBOBJ result;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LJAILMOAKHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x74B8B60", Offset = "0x74B7560", VA = "0x1874B8B60")]
		internal DPFEHPMNAJD DPIGFGHIBJP(GNHLALPFPDH id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct ACPJFPGMMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Dictionary<GNHLALPFPDH, DPFEHPMNAJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<GNHLALPFPDH, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private MMDODBJCIEB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<List<DPFEHPMNAJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x74A9790", Offset = "0x74A8190", VA = "0x1874A9790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x74AA240", Offset = "0x74A8C40", VA = "0x1874AA240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct BHPJMJABFBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<List<DPFEHPMNAJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Dictionary<GNHLALPFPDH, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private List<DPFEHPMNAJD> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<List<DPFEHPMNAJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x74B29A0", Offset = "0x74B13A0", VA = "0x1874B29A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x74B3900", Offset = "0x74B2300", VA = "0x1874B3900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LLJMNMAPCCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Task<List<ODBKAFGNKIN>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Task<List<MDDBCCHCHHA>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Task<List<CODGABJMHDI>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Task<IICJGAGPKMH> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IEnumerable<CLCLPFDEAGM> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private IEnumerable<GMDJKHCNPJC> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private List<LLBHLMIBOFO> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<List<ODBKAFGNKIN>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<List<MDDBCCHCHHA>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<List<CODGABJMHDI>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<IICJGAGPKMH> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x74B8BD0", Offset = "0x74B75D0", VA = "0x1874B8BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x74B9E00", Offset = "0x74B8800", VA = "0x1874B9E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct BNNMNJDKACC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x74B3EE0", Offset = "0x74B28E0", VA = "0x1874B3EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74B4570", Offset = "0x74B2F70", VA = "0x1874B4570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct BJGCGMLNPEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public OGOAPNICIIH player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x74B3970", Offset = "0x74B2370", VA = "0x1874B3970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x74B3E70", Offset = "0x74B2870", VA = "0x1874B3E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FIGBNOAMNPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder<GMCCDJPEHHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public OGOAPNICIIH player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private TaskAwaiter<GMCCDJPEHHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x74B4AC0", Offset = "0x74B34C0", VA = "0x1874B4AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74B4FE0", Offset = "0x74B39E0", VA = "0x1874B4FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct ODDDIPFHFDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CLCLPFDEAGM itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AEOKNCHEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<OKPKCEBGDLD<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x74BA720", Offset = "0x74B9120", VA = "0x1874BA720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x74BB0D0", Offset = "0x74B9AD0", VA = "0x1874BB0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan HCLMCNCPBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float CIHJCEPNHHD = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float GONNCPKGNFM = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int AAPBLJAJDCE = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string KAJEIELBJOC = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string BHBILGJCMJN = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AOONCKNJFOK MAEPIFLNJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PLOONIEODGP NEEDHGIHMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NBPFGKEFAFB IHCGNLNJDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OALDAIIAOFB CGMKLAALGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CJCAEHNADAH JIPHNMKEKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly NNJEDJGIHIM PHMDGDCONHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NBJKPJCPFJP HLMIPNCJNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly AIJBCEBOHAM GFFPMGKCKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly CPFOEKFFEAJ NBGOLGMDODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GPEGEJHIAGG DKNEJMEHAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BBLHMBFGELE PDICEJJJPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly MMIEEDDMDJP AKAJNDHCENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource ILOHINPBILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly NNGPDFFEHAK<GNHLALPFPDH, DPFEHPMNAJD> OIAPOPNGKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NNGPDFFEHAK<long, CODGABJMHDI> MGCDBGOPOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OGJEMNBOAMG PCGALBKIAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable EJNPJLEIAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task HILOGLCJAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource CIIDBOIJBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long FGDDCDJCDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private IAOBALHKALH POBIKCLKGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74ADEF0", Offset = "0x74AC8F0", VA = "0x1874ADEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public APNHDGDPKOI LLBNDKDJINA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x97E8D0", Offset = "0x97D2D0", VA = "0x18097E8D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE289E0", Offset = "0xE273E0", VA = "0x180E289E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ABIBNEMCANM<CLCLPFDEAGM> BHGHDBFHKED
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x97E8E0", Offset = "0x97D2E0", VA = "0x18097E8E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC97F70", Offset = "0xC96970", VA = "0x180C97F70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ABIBNEMCANM<Guid> DBAFOAKCNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x97E8C0", Offset = "0x97D2C0", VA = "0x18097E8C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x925CE0", Offset = "0x9246E0", VA = "0x180925CE0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KECBCJGCBNA<GMDJKHCNPJC, int> PHADNKODJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x97E6A0", Offset = "0x97D0A0", VA = "0x18097E6A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA876A0", Offset = "0xA860A0", VA = "0x180A876A0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ABIBNEMCANM<LLBHLMIBOFO> KAFPMJOEGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B6970", Offset = "0x8B5370", VA = "0x1808B6970", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B6980", Offset = "0x8B5380", VA = "0x1808B6980", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ABIBNEMCANM<long> PNFPAAPOKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x97E870", Offset = "0x97D270", VA = "0x18097E870", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD21910", Offset = "0xD20310", VA = "0x180D21910", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public APNHDGDPKOI LJOPPLAMGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x97E860", Offset = "0x97D260", VA = "0x18097E860", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xECBB60", Offset = "0xECA560", VA = "0x180ECBB60", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public APNHDGDPKOI DCCAKBOOKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F79A0", Offset = "0x8F63A0", VA = "0x1808F79A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x924980", Offset = "0x923380", VA = "0x180924980", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74AC330", Offset = "0x74AAD30", VA = "0x1874AC330")]
	[EPFHFFCDLIN.PIOGMKDDBAI.EFFOPIDOPOD]
	internal static void GHMBFHCIJHC(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74B0C10", Offset = "0x74AF610", VA = "0x1874B0C10")]
	[RecRoom.NoEngine.Common.Preserve]
	public AEOKNCHEHNJ([CCLEDEMDDDH(null)] AOONCKNJFOK MAEPIFLNJKJ, [CCLEDEMDDDH(null)] PLOONIEODGP NEEDHGIHMOL, [CCLEDEMDDDH(null)] NBPFGKEFAFB IHCGNLNJDGK, [CCLEDEMDDDH(null)] OALDAIIAOFB CGMKLAALGJK, [CCLEDEMDDDH(null)] OIJGODLJCJF GFHJCFNDBGP, [CCLEDEMDDDH(null)] CJCAEHNADAH JIPHNMKEKCK, [CCLEDEMDDDH(null)] NNJEDJGIHIM PHMDGDCONHJ, [CCLEDEMDDDH(null)] ECEEBMJJPLJ KLKJIFAHCIE, [CCLEDEMDDDH(null)] NIBEFMKNFGL ACHHGDHFFOH, [CCLEDEMDDDH(null)] NBJKPJCPFJP HLMIPNCJNLM, [CCLEDEMDDDH(null)] AIJBCEBOHAM GFFPMGKCKKP, [CCLEDEMDDDH(null)] CPFOEKFFEAJ NBGOLGMDODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74AB910", Offset = "0x74AA310", VA = "0x1874AB910", Slot = "50")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74AD4B0", Offset = "0x74ABEB0", VA = "0x1874AD4B0", Slot = "49")]
	public Task HJCEENEOKGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74AEE40", Offset = "0x74AD840", VA = "0x1874AEE40", Slot = "20")]
	[AsyncStateMachine(typeof(PPBKFPPPNHH))]
	public Task<OKPKCEBGDLD<CLCLPFDEAGM, string>> MLPNBEGHBOA(long NPGHGEFGHLA, string JHJFHDOAMLG, string IGIOLLIFOOJ, string FHFCJEAFMJC, RoomInventoryItemProperties FPNIMNHKJCC, byte LDNKIGHNFBK, int GNADFIPFMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74AF250", Offset = "0x74ADC50", VA = "0x1874AF250", Slot = "21")]
	[AsyncStateMachine(typeof(FKCDAEAHEOA))]
	public Task<OKPKCEBGDLD<CLCLPFDEAGM, string>> NIJLODKKNNL(Guid PMAKHKBNMPF, long NPGHGEFGHLA, [Optional] string JHJFHDOAMLG, [Optional] string IGIOLLIFOOJ, [Optional] string FHFCJEAFMJC, [Optional] List<long> GFKDLJNACOK, [Optional] Dictionary<string, RoomInventoryTagClientProperties> POLPFHKJJKK, [Optional] RoomInventoryItemProperties FPNIMNHKJCC, [Optional] byte? LDNKIGHNFBK, [Optional] int? GNADFIPFMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x74AFB10", Offset = "0x74AE510", VA = "0x1874AFB10", Slot = "22")]
	[AsyncStateMachine(typeof(MEIOKMMLLAK))]
	public Task<OKPKCEBGDLD<bool, string>> PEJGCLBOFMN(Guid PMAKHKBNMPF, long NPGHGEFGHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74AB0B0", Offset = "0x74A9AB0", VA = "0x1874AB0B0", Slot = "23")]
	public IReadOnlyList<CLCLPFDEAGM> DGOMAAKHBIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74AC750", Offset = "0x74AB150", VA = "0x1874AC750", Slot = "24")]
	public IReadOnlyList<CLCLPFDEAGM> GLFEOKHIEMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x74ADBA0", Offset = "0x74AC5A0", VA = "0x1874ADBA0", Slot = "25")]
	public bool JAAOKFDIPMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x74B0290", Offset = "0x74AEC90", VA = "0x1874B0290", Slot = "26")]
	public bool POFLPMBLCAM(Guid PMAKHKBNMPF, [Out] CLCLPFDEAGM BCCAHIDJMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x74AA760", Offset = "0x74A9160", VA = "0x1874AA760", Slot = "27")]
	public bool BLHPLCPDGJO(string NIDCCGBOEGC, [Out] CLCLPFDEAGM BCCAHIDJMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x74AD550", Offset = "0x74ABF50", VA = "0x1874AD550", Slot = "28")]
	public IReadOnlyList<GMDJKHCNPJC> HLKBNHHNKCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74AB7E0", Offset = "0x74AA1E0", VA = "0x1874AB7E0", Slot = "29")]
	public bool DLOLOOCOCGN(Guid PMAKHKBNMPF, [Out] GMDJKHCNPJC ILKKPHIDFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74AF560", Offset = "0x74ADF60", VA = "0x1874AF560", Slot = "30")]
	public long? NMIPBGCJDFG(Guid PMAKHKBNMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x74ACE60", Offset = "0x74AB860", VA = "0x1874ACE60", Slot = "48")]
	public void GONJCNJHAOP(IEnumerable<MDDBCCHCHHA> GNHGMGFHAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74AAB20", Offset = "0x74A9520", VA = "0x1874AAB20", Slot = "31")]
	[AsyncStateMachine(typeof(PKELEIEEHBK))]
	public Task<int> CHKCIICIFPO(OGOAPNICIIH JOCAMECBDHO, Guid PMAKHKBNMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74AF410", Offset = "0x74ADE10", VA = "0x1874AF410", Slot = "32")]
	[AsyncStateMachine(typeof(OEJGLHKOCIO))]
	public Task<GMCCDJPEHHC> NJOAELKGFCB(OGOAPNICIIH HBBHAMANGHO, Guid PMAKHKBNMPF, int DIKJGKCBPOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74AB610", Offset = "0x74AA010", VA = "0x1874AB610", Slot = "33")]
	public string DJEOIAABMBE(PFLPKDJBOBJ KIBAOEBFCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74AD440", Offset = "0x74ABE40", VA = "0x1874AD440", Slot = "34")]
	public bool HHAPIEAPHGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74AC060", Offset = "0x74AAA60", VA = "0x1874AC060", Slot = "36")]
	[AsyncStateMachine(typeof(DHINEPPFBEH))]
	public Task<OKPKCEBGDLD<LLBHLMIBOFO, string>> FNMKBKLGLBI(long CEAHHHNLLKK, RoomInventoryTagClientProperties FPNIMNHKJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x74AECA0", Offset = "0x74AD6A0", VA = "0x1874AECA0", Slot = "37")]
	[AsyncStateMachine(typeof(OGLOLMCOAKG))]
	public Task<OKPKCEBGDLD<bool, string>> LJCJDFNHPPK(long CEAHHHNLLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74AF830", Offset = "0x74AE230", VA = "0x1874AF830", Slot = "40")]
	public List<(long, int)> PDHOOGKAHKG(long PLHPLPCKDMJ, int MNDKCNIELBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74AC2A0", Offset = "0x74AACA0", VA = "0x1874AC2A0", Slot = "41")]
	public bool GCPFPGCOBNO(long CEAHHHNLLKK, [Out] LLBHLMIBOFO HCCDNMKNECD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x74AD240", Offset = "0x74ABC40", VA = "0x1874AD240", Slot = "42")]
	public bool HFLAPDPEJIH(long CEAHHHNLLKK, Guid LEHKHLMKDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x74ADCA0", Offset = "0x74AC6A0", VA = "0x1874ADCA0", Slot = "43")]
	public IReadOnlyList<LLBHLMIBOFO> JIMDHAAKENB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x74AE3C0", Offset = "0x74ACDC0", VA = "0x1874AE3C0", Slot = "44")]
	public List<LLBHLMIBOFO> KHGFGEADHGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x74AC3A0", Offset = "0x74AADA0", VA = "0x1874AC3A0", Slot = "45")]
	public IReadOnlyList<LLBHLMIBOFO> GIGMFNACJGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x74AEDC0", Offset = "0x74AD7C0", VA = "0x1874AEDC0", Slot = "39")]
	public bool MENABCFIBBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74AFFB0", Offset = "0x74AE9B0", VA = "0x1874AFFB0", Slot = "46")]
	public IReadOnlyList<CLCLPFDEAGM> PNGGAANOHBB(long CEAHHHNLLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x74AA500", Offset = "0x74A8F00", VA = "0x1874AA500", Slot = "38")]
	[AsyncStateMachine(typeof(KMKHFDOMOCB))]
	public Task<OKPKCEBGDLD<bool, string>> ANPDCNPFIFI(long NPGHGEFGHLA, bool MFFONNLHOIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74ABBD0", Offset = "0x74AA5D0", VA = "0x1874ABBD0", Slot = "51")]
	public bool EGGNMLMOPED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x74AB160", Offset = "0x74A9B60", VA = "0x1874AB160", Slot = "47")]
	public bool DIOLLJGJNED(string DDNKPNONBLK, [Out] IReadOnlyList<CLCLPFDEAGM> LPNIJCMMNCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x74AA2B0", Offset = "0x74A8CB0", VA = "0x1874AA2B0")]
	[AsyncStateMachine(typeof(INKMCCNIDLE))]
	private Task<Dictionary<long, CODGABJMHDI>> AHILPCLFJLC(Dictionary<long, int> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x74AF100", Offset = "0x74ADB00", VA = "0x1874AF100")]
	[AsyncStateMachine(typeof(GKDKHGPFJLP))]
	private Task<GMCCDJPEHHC> NGHOFILLHNB(Guid PMAKHKBNMPF, int DIKJGKCBPOL, [Optional] Guid MPINBOAIBJM, [Optional] OGOAPNICIIH GFGPFEEDDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x74AF6F0", Offset = "0x74AE0F0", VA = "0x1874AF6F0")]
	[AsyncStateMachine(typeof(ACPJFPGMMGC))]
	private Task<Dictionary<GNHLALPFPDH, DPFEHPMNAJD>> OOKAGIPEHGJ(Dictionary<GNHLALPFPDH, int> JECKEBBHEON, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74AFE70", Offset = "0x74AE870", VA = "0x1874AFE70")]
	[AsyncStateMachine(typeof(BHPJMJABFBO))]
	private Task<List<DPFEHPMNAJD>> PMGNHEABGGJ(Dictionary<GNHLALPFPDH, int> JECKEBBHEON, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x74ADF40", Offset = "0x74AC940", VA = "0x1874ADF40")]
	[AsyncStateMachine(typeof(LLJMNMAPCCC))]
	private Task KCKAKPDLPCK(long NPGHGEFGHLA, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74ACA00", Offset = "0x74AB400", VA = "0x1874ACA00")]
	private Task GLIACGDBDNM(LKMBJDMKDPJ LPLPEHNKFMM, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x74AA690", Offset = "0x74A9090", VA = "0x1874AA690")]
	[AsyncStateMachine(typeof(BNNMNJDKACC))]
	private Task BJJNOKILBND(LKMBJDMKDPJ LPLPEHNKFMM, CancellationToken MDAHKKOMGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74ABC40", Offset = "0x74AA640", VA = "0x1874ABC40")]
	private void EJMPFOOGAJF(ODBKAFGNKIN DPEJPGLPAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74B06F0", Offset = "0x74AF0F0", VA = "0x1874B06F0")]
	[KJDFAECKLJG]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string PHKLHLIIBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x74ABEE0", Offset = "0x74AA8E0", VA = "0x1874ABEE0")]
	private void FNILKPOOFMI(Guid PMAKHKBNMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x74B0830", Offset = "0x74AF230", VA = "0x1874B0830")]
	[KJDFAECKLJG]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid PMAKHKBNMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x74AEFC0", Offset = "0x74AD9C0", VA = "0x1874AEFC0")]
	[AsyncStateMachine(typeof(BJGCGMLNPEI))]
	private Task<int> NCLAJKPLOMN(OGOAPNICIIH JOCAMECBDHO, Guid PMAKHKBNMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x74B0500", Offset = "0x74AEF00", VA = "0x1874B0500")]
	[KJDFAECKLJG]
	internal void RpcGetPlayerRoomInventoryCount(Guid GGNKLHDGNDO, Guid PMAKHKBNMPF, EPBMCJPHALC NMAECNIBAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x74B0480", Offset = "0x74AEE80", VA = "0x1874B0480")]
	[KJDFAECKLJG]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid GGNKLHDGNDO, int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x74AD0D0", Offset = "0x74ABAD0", VA = "0x1874AD0D0")]
	[AsyncStateMachine(typeof(FIGBNOAMNPL))]
	private Task<GMCCDJPEHHC> HAMPOCCAAFL(OGOAPNICIIH JOCAMECBDHO, Guid PMAKHKBNMPF, int DIKJGKCBPOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74B03B0", Offset = "0x74AEDB0", VA = "0x1874B03B0")]
	[KJDFAECKLJG]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid GGNKLHDGNDO, Guid PMAKHKBNMPF, int DIKJGKCBPOL, EPBMCJPHALC NMAECNIBAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74AFCB0", Offset = "0x74AE6B0", VA = "0x1874AFCB0")]
	private void PKJKJEJDDEI(OGOAPNICIIH HBBHAMANGHO, Guid GGNKLHDGNDO, PFLPKDJBOBJ KIBAOEBFCJF, long MPNPFMOIAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74B0AE0", Offset = "0x74AF4E0", VA = "0x1874B0AE0")]
	[KJDFAECKLJG]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid GGNKLHDGNDO, int KIBAOEBFCJF, long MPNPFMOIAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74ABD60", Offset = "0x74AA760", VA = "0x1874ABD60")]
	private void ENPABCOEFML(bool MFFONNLHOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74B0A80", Offset = "0x74AF480", VA = "0x1874B0A80")]
	[KJDFAECKLJG]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool EOIEPDJLHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74AE610", Offset = "0x74AD010", VA = "0x1874AE610")]
	private void LACCACLMFNJ(List<CODGABJMHDI> CMKDHHLLGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74B08D0", Offset = "0x74AF2D0", VA = "0x1874B08D0")]
	[KJDFAECKLJG]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string AACIKINFPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74ADA30", Offset = "0x74AC430", VA = "0x1874ADA30")]
	private void IMJGBGPBNCB(long CEAHHHNLLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74B0860", Offset = "0x74AF260", VA = "0x1874B0860")]
	[KJDFAECKLJG]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long CEAHHHNLLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x74ABB30", Offset = "0x74AA530", VA = "0x1874ABB30")]
	private CLCLPFDEAGM EAINJEEFMMJ(ODBKAFGNKIN DPEJPGLPAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74AA940", Offset = "0x74A9340", VA = "0x1874AA940")]
	private List<LLBHLMIBOFO> CBHGADOJIGJ(List<CODGABJMHDI> CMKDHHLLGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74AE070", Offset = "0x74ACA70", VA = "0x1874AE070")]
	private List<LLBHLMIBOFO> KFHIOIKFJLN(IEnumerable<CODGABJMHDI> CMKDHHLLGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74AE730", Offset = "0x74AD130", VA = "0x1874AE730")]
	private CLCLPFDEAGM LCMDMHBGIIG(ODBKAFGNKIN DPEJPGLPAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x74AD7A0", Offset = "0x74AC1A0", VA = "0x1874AD7A0")]
	private LLBHLMIBOFO IGHFOEIAILN(CODGABJMHDI DPEJPGLPAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74AFC40", Offset = "0x74AE640", VA = "0x1874AFC40")]
	private void PHABDPAMFMA(GMDJKHCNPJC ILKKPHIDFNP, int KOAPHMFILAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74AA620", Offset = "0x74A9020", VA = "0x1874AA620")]
	private void BHJEKOLAEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74ADD70", Offset = "0x74AC770", VA = "0x1874ADD70")]
	private Task JKHAAGCDJOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x74AD730", Offset = "0x74AC130", VA = "0x1874AD730")]
	private void ICIFGFICEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x74AA880", Offset = "0x74A9280", VA = "0x1874AA880")]
	private void BOMDCDBPKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74AC190", Offset = "0x74AAB90", VA = "0x1874AC190")]
	private void GAMKJBDDHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x74AA3F0", Offset = "0x74A8DF0", VA = "0x1874AA3F0")]
	[AsyncStateMachine(typeof(ODDDIPFHFDJ))]
	private Task AMBLJLHBGHL(CLCLPFDEAGM HBOPGECKFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74AD220", Offset = "0x74ABC20", VA = "0x1874AD220")]
	[CompilerGenerated]
	private void HEHJGNNGMNK(Task<TaskStatus> LPAAFOGOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x74AAC60", Offset = "0x74A9660", VA = "0x1874AAC60")]
	[CompilerGenerated]
	private Task<PFLPKDJBOBJ> CMJHNFHHGLP(IGAIJBDLEAH P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74AE450", Offset = "0x74ACE50", VA = "0x1874AE450")]
	[CompilerGenerated]
	internal static Dictionary<GNHLALPFPDH, DPFEHPMNAJD> KODHAEPGPJF(PFLPKDJBOBJ KIBAOEBFCJF, MMDODBJCIEB P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MMIEEDDMDJP : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x74BA6E0", Offset = "0x74B90E0", VA = "0x1874BA6E0")]
	public MMIEEDDMDJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NIBEFMKNFGL
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPEGEJHIAGG LGNAIFFJABO();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MMIEEDDMDJP ECLNEFIGIMA();

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BBLHMBFGELE OFLLHLOALJL();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KBIPEKKAIPD : NIBEFMKNFGL
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x74B8360", Offset = "0x74B6D60", VA = "0x1874B8360")]
	[EPFHFFCDLIN.PIOGMKDDBAI.EFFOPIDOPOD]
	internal static void GHMBFHCIJHC(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	[RecRoom.NoEngine.Common.Preserve]
	public KBIPEKKAIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x74B83D0", Offset = "0x74B6DD0", VA = "0x1874B83D0", Slot = "4")]
	public GPEGEJHIAGG LGNAIFFJABO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x74B82F0", Offset = "0x74B6CF0", VA = "0x1874B82F0", Slot = "5")]
	public MMIEEDDMDJP ECLNEFIGIMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x74B84E0", Offset = "0x74B6EE0", VA = "0x1874B84E0", Slot = "6")]
	public BBLHMBFGELE OFLLHLOALJL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BBLHMBFGELE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly Dictionary<long, LLBHLMIBOFO> LBJJMDDKAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly LLBHLMIBOFO[] NNALLFGPMOC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool CEANPJPNCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x930140", Offset = "0x92EB40", VA = "0x180930140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9A2C60", Offset = "0x9A1660", VA = "0x1809A2C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ILAKCCPHOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74B23E0", Offset = "0x74B0DE0", VA = "0x1874B23E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long IMKKDGMIMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B0210", Offset = "0x8AEC10", VA = "0x1808B0210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x74B1790", Offset = "0x74B0190", VA = "0x1874B1790")]
	public void BMGKNHOJOBG(long NPGHGEFGHLA, IEnumerable<LLBHLMIBOFO> JDCDPICBDPE, bool FOFMOAFDIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x74B1FA0", Offset = "0x74B09A0", VA = "0x1874B1FA0")]
	public IReadOnlyList<LLBHLMIBOFO> FDPLOFDBALA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x9A2C60", Offset = "0x9A1660", VA = "0x1809A2C60")]
	public void GIAEGFGPAEI(bool MFFONNLHOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x74B2760", Offset = "0x74B1160", VA = "0x1874B2760")]
	public bool PFONJIIHONG(long CEAHHHNLLKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x74B2150", Offset = "0x74B0B50", VA = "0x1874B2150")]
	public bool FFAFFNPAHPA(LLBHLMIBOFO KPLBLJEJJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x74B2440", Offset = "0x74B0E40", VA = "0x1874B2440")]
	public bool ODKMEMNKNBE(List<LLBHLMIBOFO> KEEICAOABGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x74B2840", Offset = "0x74B1240", VA = "0x1874B2840")]
	public bool PPKGIHNDNDO(long CEAHHHNLLKK, [Out] LLBHLMIBOFO KLBPNCLBHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x74B1DF0", Offset = "0x74B07F0", VA = "0x1874B1DF0")]
	public bool EBLGCJPPDCH(string JHJFHDOAMLG, [Out] LLBHLMIBOFO KLBPNCLBHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x74B2310", Offset = "0x74B0D10", VA = "0x1874B2310")]
	public List<LLBHLMIBOFO> LNOEALBAJJJ(int GCBONJOGHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x74B1CB0", Offset = "0x74B06B0", VA = "0x1874B1CB0")]
	public List<LLBHLMIBOFO> DJJCODECFAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x706C520", Offset = "0x706AF20", VA = "0x18706C520")]
	public LLBHLMIBOFO GHLIECIDLDE(int GCBONJOGHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x74B1C50", Offset = "0x74B0650", VA = "0x1874B1C50")]
	public IReadOnlyList<LLBHLMIBOFO> DFEGDNFGCKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x74B28E0", Offset = "0x74B12E0", VA = "0x1874B28E0")]
	public BBLHMBFGELE()
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
