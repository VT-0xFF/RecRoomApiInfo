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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7201AA0", Offset = "0x72000A0", VA = "0x187201AA0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KCAAKKHNOIM : LBOBGMJHEBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NBELGHIIKJI LGLACGDJGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class IMNFCGDHMMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, LKAFIMGLNLE> DNNINLMOCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, LKAFIMGLNLE> KHHKBGIAGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? CBMMHHACBCL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long OMKGAKAMIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8879C0", Offset = "0x885FC0", VA = "0x1808879C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LKAFIMGLNLE BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71F3E90", Offset = "0x71F2490", VA = "0x1871F3E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71F4370", Offset = "0x71F2970", VA = "0x1871F4370")]
	public void INOEHFICEHA(long FNKMOIJJLLC, IEnumerable<KKFIONHAJIH> GPCPPKHCEBD, IEnumerable<EFCECCIBPKB> NIENBLPJDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x71F4310", Offset = "0x71F2910", VA = "0x1871F4310")]
	public bool INDDGGEAPOB(Guid LILBGFPIHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x71F4E60", Offset = "0x71F3460", VA = "0x1871F4E60")]
	public bool MBEEDABKNGP(Guid LILBGFPIHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x71F4C30", Offset = "0x71F3230", VA = "0x1871F4C30")]
	public bool KEIPDHKOALO(KKFIONHAJIH CEGBHJCDDNE, [Out] KKFIONHAJIH KGCKEOAONMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x71F3F90", Offset = "0x71F2590", VA = "0x1871F3F90")]
	public IEnumerable<LKAFIMGLNLE> EGBGMHABJAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71F41D0", Offset = "0x71F27D0", VA = "0x1871F41D0")]
	public IEnumerable<KKFIONHAJIH> HIKIGAOENAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71F4090", Offset = "0x71F2690", VA = "0x1871F4090")]
	public IEnumerable<EFCECCIBPKB> HFCKJHEGDCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x71F3D60", Offset = "0x71F2360", VA = "0x1871F3D60")]
	public bool AMHHBDMMFDP(Guid LILBGFPIHAH, [Out] KKFIONHAJIH ILKELCDIMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x71F3EF0", Offset = "0x71F24F0", VA = "0x1871F3EF0")]
	public bool DFJKMAKNLEI(string MCBPAIFCBEJ, [Out] KKFIONHAJIH ILKELCDIMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x71F3FE0", Offset = "0x71F25E0", VA = "0x1871F3FE0")]
	public bool EJFNCOJFINO(Guid LILBGFPIHAH, [Out] EFCECCIBPKB HJOINFBEGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x71F3CC0", Offset = "0x71F22C0", VA = "0x1871F3CC0")]
	public bool AGLHJOMFMNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x71F3E10", Offset = "0x71F2410", VA = "0x1871F3E10")]
	private bool BCHDBCOCLLA(KKFIONHAJIH MMECFHEAHOI, KKFIONHAJIH EFPBPDDONKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71F50A0", Offset = "0x71F36A0", VA = "0x1871F50A0")]
	private void OOECKEMCLOH(Guid HGFDMIDEFHN, LKAFIMGLNLE COLFNOMMKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x71F49F0", Offset = "0x71F2FF0", VA = "0x1871F49F0")]
	private bool KCHNDPEANEN(Guid HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71F3BD0", Offset = "0x71F21D0", VA = "0x1871F3BD0")]
	private void AGIDKNHICMD(KKFIONHAJIH ADDPDEPHCPO, [Optional] KKFIONHAJIH KPBHJNBJCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x71F4E80", Offset = "0x71F3480", VA = "0x1871F4E80")]
	private bool MKLBOCFCHJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x71F5060", Offset = "0x71F3660", VA = "0x1871F5060")]
	private static bool ODPLHJKBDLN(KKFIONHAJIH IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x71F52E0", Offset = "0x71F38E0", VA = "0x1871F52E0")]
	public IMNFCGDHMMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NBELGHIIKJI : CMNAKFDJHBK, FOBOFHJKJON, IDisposable, DHIFILCIGLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MKIKKFGDJEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<KKFIONHAJIH, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NBELGHIIKJI <>4__this;

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
		private TaskAwaiter<KEPLMFJKOOC<CHJHHHALIJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x71F7DE0", Offset = "0x71F63E0", VA = "0x1871F7DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x71F8200", Offset = "0x71F6800", VA = "0x1871F8200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HCLDBCPLPGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<KKFIONHAJIH, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NBELGHIIKJI <>4__this;

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
		private TaskAwaiter<KEPLMFJKOOC<CHJHHHALIJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x71F20E0", Offset = "0x71F06E0", VA = "0x1871F20E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x71F2900", Offset = "0x71F0F00", VA = "0x1871F2900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JAINBFFBKLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private KKFIONHAJIH <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private DHPAFPJDDLL <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<DHPAFPJDDLL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x71F56A0", Offset = "0x71F3CA0", VA = "0x1871F56A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x71F5E90", Offset = "0x71F4490", VA = "0x1871F5E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NBBKDINDBKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PDPPFLAPOCL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x71F8C70", Offset = "0x71F7270", VA = "0x1871F8C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x71F8FF0", Offset = "0x71F75F0", VA = "0x1871F8FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NPEOAGOEAHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder<CELELCPBKCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public PDPPFLAPOCL recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter<CELELCPBKCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7201380", Offset = "0x71FF980", VA = "0x187201380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72017E0", Offset = "0x71FFDE0", VA = "0x1872017E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GGDILDBOMNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<LOBMDFINEHO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private LOBMDFINEHO <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71F05B0", Offset = "0x71EEBB0", VA = "0x1871F05B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x71F0A30", Offset = "0x71EF030", VA = "0x1871F0A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HCGKBNHDOOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private List<LOBMDFINEHO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter<BCLNLKLFCPB<LOBMDFINEHO, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<DHPAFPJDDLL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x71F1490", Offset = "0x71EFA90", VA = "0x1871F1490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x71F2070", Offset = "0x71F0670", VA = "0x1871F2070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LFKFKCLGAGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<DHPAFPJDDLL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x71F7850", Offset = "0x71F5E50", VA = "0x1871F7850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x71F7D70", Offset = "0x71F6370", VA = "0x1871F7D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MMJKPICGAHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder<Dictionary<long, EFIDOFIHPIO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<KEPLMFJKOOC<List<EFIDOFIHPIO>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x71F8270", Offset = "0x71F6870", VA = "0x1871F8270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x71F8C00", Offset = "0x71F7200", VA = "0x1871F8C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CGAHDNNENFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public EFCECCIBPKB playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DEANJODANAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<CELELCPBKCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private CGAHDNNENFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public PDPPFLAPOCL awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<JDOFPIHCNPL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x71F0080", Offset = "0x71EE680", VA = "0x1871F0080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x71F04D0", Offset = "0x71EEAD0", VA = "0x1871F04D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IGJHCFCDPFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Dictionary<Guid, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FPLGMNAKPHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JDOFPIHCNPL result;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public FPLGMNAKPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x71F0540", Offset = "0x71EEB40", VA = "0x1871F0540")]
		internal EBOBONEGPPF BALBMBOIPGM(Guid id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BOKFDCNNCCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<Dictionary<Guid, EBOBONEGPPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private IGJHCFCDPFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<List<EBOBONEGPPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x71EF080", Offset = "0x71ED680", VA = "0x1871EF080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x71EFAA0", Offset = "0x71EE0A0", VA = "0x1871EFAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NHDLAPHHABE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<List<EBOBONEGPPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Dictionary<Guid, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private List<EBOBONEGPPF> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<EBOBONEGPPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72004C0", Offset = "0x71FEAC0", VA = "0x1872004C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7201310", Offset = "0x71FF910", VA = "0x187201310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct IJFKNLDOEPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Task<List<CHJHHHALIJJ>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Task<List<IDEJICKEDMO>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Task<List<EFIDOFIHPIO>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Task<LBCIGKCNAMK> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private IEnumerable<KKFIONHAJIH> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private IEnumerable<EFCECCIBPKB> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private List<LOBMDFINEHO> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter<List<CHJHHHALIJJ>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<List<IDEJICKEDMO>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<List<EFIDOFIHPIO>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<LBCIGKCNAMK> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x71F2970", Offset = "0x71F0F70", VA = "0x1871F2970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x71F3B70", Offset = "0x71F2170", VA = "0x1871F3B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KDAPMLBPILE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x71F5F00", Offset = "0x71F4500", VA = "0x1871F5F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x71F6580", Offset = "0x71F4B80", VA = "0x1871F6580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct DDFJMJPHJLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public PDPPFLAPOCL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x71EFB10", Offset = "0x71EE110", VA = "0x1871EFB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x71F0010", Offset = "0x71EE610", VA = "0x1871F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct AKEOMJLEJCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder<CELELCPBKCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public PDPPFLAPOCL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<CELELCPBKCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x71EEAF0", Offset = "0x71ED0F0", VA = "0x1871EEAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x71EF010", Offset = "0x71ED610", VA = "0x1871EF010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct GPGAEJIDFBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public KKFIONHAJIH itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public NBELGHIIKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<BCLNLKLFCPB<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x71F0AA0", Offset = "0x71EF0A0", VA = "0x1871F0AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x71F1430", Offset = "0x71EFA30", VA = "0x1871F1430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan KJAGCDALNNL;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float HBIDGBHLIJK = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float LCIPHPANFAG = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int LKJAGJKBOGM = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string JHOEMKOLGFA = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string OBMFKCLJIPF = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JKJPMODAMIK NHGFAJLPBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NKGGADPENME GEONLCHHBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LFLHEMBPLIN GPMNKKCFBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly EJMHILFALFD EADMNLDABPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CJEGNMKBHPN JMHNCEGLNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KCAAKKHNOIM LAOMBFINDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CDCHCDMFJJO KKMFJEOBINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly GDCKAILFDNA OAHAJEFMEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NIBILAFKEMK HMHBIGEEOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly IMNFCGDHMMF FANBIDCPNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly KNKLHFEDLIF BKHNDKADGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly LDCDGMPOHLK GKBMEOJHEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource LCOKIHHFLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly DOOIMCCIPBA<Guid, EBOBONEGPPF> LENGIHMIOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DOOIMCCIPBA<long, EFIDOFIHPIO> INAOCNJEABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HNJEJMNGEBK LEKMFBHDDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable DFJOAFKKCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task MNOJELJIOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource KBGFMKKLOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long ECIFONKHELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private OGDLJMIHDLN NBABLNMIKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71F9940", Offset = "0x71F7F40", VA = "0x1871F9940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GHNLMGKLHKE HMEIIGLAMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4530", Offset = "0x8D2B30", VA = "0x1808D4530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC6E2F0", Offset = "0xC6C8F0", VA = "0x180C6E2F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KHECJJJIFBB<KKFIONHAJIH> KCHFPBMNBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CB0", Offset = "0x8D52B0", VA = "0x1808D6CB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAE8760", Offset = "0xAE6D60", VA = "0x180AE8760", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KHECJJJIFBB<Guid> PDDGOGMIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x93DC90", Offset = "0x93C290", VA = "0x18093DC90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAF04F0", Offset = "0xAEEAF0", VA = "0x180AF04F0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LLEJOEJOMJB<EFCECCIBPKB, int> AJHNHPBOFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8D6560", Offset = "0x8D4B60", VA = "0x1808D6560", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x905480", Offset = "0x903A80", VA = "0x180905480", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KHECJJJIFBB<LOBMDFINEHO> ECOCCEMGNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x885E50", Offset = "0x884450", VA = "0x180885E50", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x885E60", Offset = "0x884460", VA = "0x180885E60", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KHECJJJIFBB<long> BJPPMFELPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA403C0", Offset = "0xA3E9C0", VA = "0x180A403C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB7A240", Offset = "0xB78840", VA = "0x180B7A240", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GHNLMGKLHKE CBCOCPILJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA135F0", Offset = "0xA11BF0", VA = "0x180A135F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD1CE90", Offset = "0xD1B490", VA = "0x180D1CE90", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GHNLMGKLHKE LGOPGAOCLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D0B80", Offset = "0x8CF180", VA = "0x1808D0B80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xD1CE70", Offset = "0xD1B470", VA = "0x180D1CE70", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x71F9060", Offset = "0x71F7660", VA = "0x1871F9060")]
	[DJINMBCHLNM.PJKIGKAPDIK.PCJJKFLDJEL]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x71FF940", Offset = "0x71FDF40", VA = "0x1871FF940")]
	[RecRoom.NoEngine.Common.Preserve]
	public NBELGHIIKJI([OLJNBPOCBCJ(null)] JKJPMODAMIK NHGFAJLPBFB, [OLJNBPOCBCJ(null)] NKGGADPENME GEONLCHHBCJ, [OLJNBPOCBCJ(null)] LFLHEMBPLIN GPMNKKCFBKN, [OLJNBPOCBCJ(null)] EJMHILFALFD EADMNLDABPK, [OLJNBPOCBCJ(null)] LFGBFBPJNCH JAFFEKBAIOJ, [OLJNBPOCBCJ(null)] CJEGNMKBHPN JMHNCEGLNMN, [OLJNBPOCBCJ(null)] KCAAKKHNOIM LAOMBFINDHK, [OLJNBPOCBCJ(null)] ABCENOCDHAO IEGEAMBPEMD, [OLJNBPOCBCJ(null)] CBEBAADDCDD JJAJCICOHEI, [OLJNBPOCBCJ(null)] CDCHCDMFJJO KKMFJEOBINB, [OLJNBPOCBCJ(null)] GDCKAILFDNA OAHAJEFMEJN, [OLJNBPOCBCJ(null)] NIBILAFKEMK HMHBIGEEOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x71FAE50", Offset = "0x71F9450", VA = "0x1871FAE50", Slot = "50")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x71FADB0", Offset = "0x71F93B0", VA = "0x1871FADB0", Slot = "49")]
	public Task DJFMEJLPMDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x71FE070", Offset = "0x71FC670", VA = "0x1871FE070", Slot = "20")]
	[AsyncStateMachine(typeof(MKIKKFGDJEJ))]
	public Task<BCLNLKLFCPB<KKFIONHAJIH, string>> MNFKNFGNBLL(long FNKMOIJJLLC, string KJPHMNNIMDP, string PADNFDKMCHE, string CPGBJNDENLC, RoomInventoryItemProperties DAODDBNNDHB, byte CICGHDIEJHI, int FEHNKBJAMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71FBDC0", Offset = "0x71FA3C0", VA = "0x1871FBDC0", Slot = "21")]
	[AsyncStateMachine(typeof(HCLDBCPLPGO))]
	public Task<BCLNLKLFCPB<KKFIONHAJIH, string>> GMJGOLINIAI(Guid LILBGFPIHAH, [Optional] string KJPHMNNIMDP, [Optional] string PADNFDKMCHE, [Optional] string CPGBJNDENLC, [Optional] List<long> DGPOFJIMGOM, [Optional] Dictionary<string, RoomInventoryTagClientProperties> JICKLDBPDAH, [Optional] RoomInventoryItemProperties DAODDBNNDHB, [Optional] byte? CICGHDIEJHI, [Optional] int? FEHNKBJAMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x71FEFC0", Offset = "0x71FD5C0", VA = "0x1871FEFC0", Slot = "22")]
	[AsyncStateMachine(typeof(JAINBFFBKLP))]
	public Task<BCLNLKLFCPB<bool, string>> PNDABDPEMFB(Guid LILBGFPIHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x71F9990", Offset = "0x71F7F90", VA = "0x1871F9990", Slot = "23")]
	public IReadOnlyList<KKFIONHAJIH> BPAPCLAKKHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x71FB1A0", Offset = "0x71F97A0", VA = "0x1871FB1A0", Slot = "24")]
	public IReadOnlyList<KKFIONHAJIH> FDFBFHMGOFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x71FC6B0", Offset = "0x71FACB0", VA = "0x1871FC6B0", Slot = "25")]
	public bool IEOJPJNKBDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x71F9540", Offset = "0x71F7B40", VA = "0x1871F9540", Slot = "26")]
	public bool AMHHBDMMFDP(Guid LILBGFPIHAH, [Out] KKFIONHAJIH ILKELCDIMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x71FA870", Offset = "0x71F8E70", VA = "0x1871FA870", Slot = "27")]
	public bool DFJKMAKNLEI(string DBLNDHEAJLI, [Out] KKFIONHAJIH ILKELCDIMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x71FA1F0", Offset = "0x71F87F0", VA = "0x1871FA1F0", Slot = "28")]
	public IReadOnlyList<EFCECCIBPKB> CNLOKGBKEBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x71FB070", Offset = "0x71F9670", VA = "0x1871FB070", Slot = "29")]
	public bool EJFNCOJFINO(Guid LILBGFPIHAH, [Out] EFCECCIBPKB HJOINFBEGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x71F9660", Offset = "0x71F7C60", VA = "0x1871F9660", Slot = "30")]
	public long? BJPAHHGIANP(Guid LILBGFPIHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x71FAB40", Offset = "0x71F9140", VA = "0x1871FAB40", Slot = "48")]
	public void DHLMKAIMHGO(IEnumerable<IDEJICKEDMO> NIENBLPJDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x71FCD50", Offset = "0x71FB350", VA = "0x1871FCD50", Slot = "31")]
	[AsyncStateMachine(typeof(NBBKDINDBKH))]
	public Task<int> IOHFCOLLMLI(PDPPFLAPOCL JDDNDMPDAKN, Guid LILBGFPIHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x71F97F0", Offset = "0x71F7DF0", VA = "0x1871F97F0", Slot = "32")]
	[AsyncStateMachine(typeof(NPEOAGOEAHL))]
	public Task<CELELCPBKCC> BKDFEEHFMIB(PDPPFLAPOCL AMMLJLJEMLJ, Guid LILBGFPIHAH, int OGKJJPEBIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x71FDA80", Offset = "0x71FC080", VA = "0x1871FDA80", Slot = "33")]
	public string MCNNLJMFAJC(JDOFPIHCNPL POBDLJBBBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x71F9A40", Offset = "0x71F8040", VA = "0x1871F9A40", Slot = "34")]
	public bool CIGPNPHDHFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71FE370", Offset = "0x71FC970", VA = "0x1871FE370", Slot = "36")]
	[AsyncStateMachine(typeof(GGDILDBOMNK))]
	public Task<BCLNLKLFCPB<LOBMDFINEHO, string>> NAIIHKCPGMB(long JHPLIGJBFOF, RoomInventoryTagClientProperties DAODDBNNDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71F90D0", Offset = "0x71F76D0", VA = "0x1871F90D0", Slot = "37")]
	[AsyncStateMachine(typeof(HCGKBNHDOOI))]
	public Task<BCLNLKLFCPB<bool, string>> ABIHEIKALCF(long JHPLIGJBFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x71FA3D0", Offset = "0x71F89D0", VA = "0x1871FA3D0", Slot = "40")]
	public List<(long, int)> CNMJAAPBIIJ(long LNOABIANIDA, int BMHCLJGJBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71FC1E0", Offset = "0x71FA7E0", VA = "0x1871FC1E0", Slot = "41")]
	public bool HIMDPIDKJBD(long JHPLIGJBFOF, [Out] LOBMDFINEHO FAGGHLLJBDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x71F9E60", Offset = "0x71F8460", VA = "0x1871F9E60", Slot = "42")]
	public bool CJPFOHDLIGA(long JHPLIGJBFOF, Guid IFHCGJEIDJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x71FD8A0", Offset = "0x71FBEA0", VA = "0x1871FD8A0", Slot = "43")]
	public IReadOnlyList<LOBMDFINEHO> LKNBHBADKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71FA990", Offset = "0x71F8F90", VA = "0x1871FA990", Slot = "44")]
	public List<LOBMDFINEHO> DGDEAPDCBNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x71F9AB0", Offset = "0x71F80B0", VA = "0x1871F9AB0", Slot = "45")]
	public IReadOnlyList<LOBMDFINEHO> CIMGFHDIECE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x71FD250", Offset = "0x71FB850", VA = "0x1871FD250", Slot = "39")]
	public bool KGFFDPOGKPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x71FC7C0", Offset = "0x71FADC0", VA = "0x1871FC7C0", Slot = "46")]
	public IReadOnlyList<KKFIONHAJIH> IHKBLECMPNP(long JHPLIGJBFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x71FB8F0", Offset = "0x71F9EF0", VA = "0x1871FB8F0", Slot = "38")]
	[AsyncStateMachine(typeof(LFKFKCLGAGM))]
	public Task<BCLNLKLFCPB<bool, string>> FPBHGBEAKBG(long FNKMOIJJLLC, bool JIGAADHGKBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x71FCF00", Offset = "0x71FB500", VA = "0x1871FCF00", Slot = "51")]
	public bool KCNKELKNKKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x71FB450", Offset = "0x71F9A50", VA = "0x1871FB450", Slot = "47")]
	public bool FGNKMMDNLOO(string CMGGAFNDIOI, [Out] IReadOnlyList<KKFIONHAJIH> ONBOBDMANPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x71FE5B0", Offset = "0x71FCBB0", VA = "0x1871FE5B0")]
	[AsyncStateMachine(typeof(MMJKPICGAHH))]
	private Task<Dictionary<long, EFIDOFIHPIO>> NOJONPJKMAE(Dictionary<long, int> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x71FD2D0", Offset = "0x71FB8D0", VA = "0x1871FD2D0")]
	[AsyncStateMachine(typeof(DEANJODANAC))]
	private Task<CELELCPBKCC> KHCHDCBDIHF(Guid LILBGFPIHAH, int OGKJJPEBIOK, [Optional] Guid GFKPDFEHKEC, [Optional] PDPPFLAPOCL EIEIPOMAGKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x71FC270", Offset = "0x71FA870", VA = "0x1871FC270")]
	[AsyncStateMachine(typeof(BOKFDCNNCCM))]
	private Task<Dictionary<Guid, EBOBONEGPPF>> HKGOBCPPEBD(Dictionary<Guid, int> EODNLOCFKPF, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x71FCAA0", Offset = "0x71FB0A0", VA = "0x1871FCAA0")]
	[AsyncStateMachine(typeof(NHDLAPHHABE))]
	private Task<List<EBOBONEGPPF>> IJGNENGLGIN(Dictionary<Guid, int> EODNLOCFKPF, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x71FBA10", Offset = "0x71FA010", VA = "0x1871FBA10")]
	[AsyncStateMachine(typeof(IJFKNLDOEPE))]
	private Task GFOGOILFGJI(long FNKMOIJJLLC, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x71FD420", Offset = "0x71FBA20", VA = "0x1871FD420")]
	private Task KLELPKFLDFJ(ANLFOIKADDC AAAOIGBEBAB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x71FA120", Offset = "0x71F8720", VA = "0x1871FA120")]
	[AsyncStateMachine(typeof(KDAPMLBPILE))]
	private Task CMBFKKCPKNF(ANLFOIKADDC AAAOIGBEBAB, CancellationToken LNCHLOFJINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x71FCF70", Offset = "0x71FB570", VA = "0x1871FCF70")]
	private void KDFFOFMAALE(CHJHHHALIJJ LPCLPANOJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x71FF420", Offset = "0x71FDA20", VA = "0x1871FF420")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string KHIDLJMKMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x71FC3B0", Offset = "0x71FA9B0", VA = "0x1871FC3B0")]
	private void HLEJHDDLHOI(Guid LILBGFPIHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x71FF560", Offset = "0x71FDB60", VA = "0x1871FF560")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid LILBGFPIHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x71FECC0", Offset = "0x71FD2C0", VA = "0x1871FECC0")]
	[AsyncStateMachine(typeof(DDFJMJPHJLK))]
	private Task<int> OGHOGMFDIDM(PDPPFLAPOCL JDDNDMPDAKN, Guid LILBGFPIHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x71FF230", Offset = "0x71FD830", VA = "0x1871FF230")]
	[MEEBNJDNHKC]
	internal void RpcGetPlayerRoomInventoryCount(Guid FAOKHBLGHEO, Guid LILBGFPIHAH, HLGLPAHDPHI ONLDJBALHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x71FF1B0", Offset = "0x71FD7B0", VA = "0x1871FF1B0")]
	[MEEBNJDNHKC]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid FAOKHBLGHEO, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x71FEE70", Offset = "0x71FD470", VA = "0x1871FEE70")]
	[AsyncStateMachine(typeof(AKEOMJLEJCD))]
	private Task<CELELCPBKCC> PJLDPHFGFOI(PDPPFLAPOCL JDDNDMPDAKN, Guid LILBGFPIHAH, int OGKJJPEBIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x71FF0E0", Offset = "0x71FD6E0", VA = "0x1871FF0E0")]
	[MEEBNJDNHKC]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid FAOKHBLGHEO, Guid LILBGFPIHAH, int OGKJJPEBIOK, HLGLPAHDPHI ONLDJBALHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x71FD090", Offset = "0x71FB690", VA = "0x1871FD090")]
	private void KFLIPKAICKB(PDPPFLAPOCL AMMLJLJEMLJ, Guid FAOKHBLGHEO, JDOFPIHCNPL POBDLJBBBCI, long LNMJACLABDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x71FF810", Offset = "0x71FDE10", VA = "0x1871FF810")]
	[MEEBNJDNHKC]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid FAOKHBLGHEO, int POBDLJBBBCI, long LNMJACLABDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x71FE1F0", Offset = "0x71FC7F0", VA = "0x1871FE1F0")]
	private void MPPGGHACGGM(bool JIGAADHGKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x71FF7B0", Offset = "0x71FDDB0", VA = "0x1871FF7B0")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool KFKHKDMIGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x71FAA20", Offset = "0x71F9020", VA = "0x1871FAA20")]
	private void DHEGFLIDBJM(List<EFIDOFIHPIO> HMBGNNFLHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x71FF600", Offset = "0x71FDC00", VA = "0x1871FF600")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string BCMCHBMGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x71FCBE0", Offset = "0x71FB1E0", VA = "0x1871FCBE0")]
	private void IJPBKKIMLCB(long JHPLIGJBFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x71FF590", Offset = "0x71FDB90", VA = "0x1871FF590")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long JHPLIGJBFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x71FBB40", Offset = "0x71FA140", VA = "0x1871FBB40")]
	private KKFIONHAJIH GJAHOGNEPLH(CHJHHHALIJJ LPCLPANOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x71FBBE0", Offset = "0x71FA1E0", VA = "0x1871FBBE0")]
	private List<LOBMDFINEHO> GKKPMOIFALE(List<EFIDOFIHPIO> HMBGNNFLHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x71F91F0", Offset = "0x71F77F0", VA = "0x1871F91F0")]
	private List<LOBMDFINEHO> AKOOHJDBJMM(IEnumerable<EFIDOFIHPIO> HMBGNNFLHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71FE6F0", Offset = "0x71FCCF0", VA = "0x1871FE6F0")]
	private KKFIONHAJIH OEFKJPADAHF(CHJHHHALIJJ LPCLPANOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71FBF70", Offset = "0x71FA570", VA = "0x1871FBF70")]
	private LOBMDFINEHO HBPOHLDJIKO(EFIDOFIHPIO LPCLPANOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x71FEE00", Offset = "0x71FD400", VA = "0x1871FEE00")]
	private void PJCHFHAALNL(EFCECCIBPKB HJOINFBEGAN, int LADBNOJOPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71FEC50", Offset = "0x71FD250", VA = "0x1871FEC50")]
	private void OFAAPEHGFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x71FC530", Offset = "0x71FAB30", VA = "0x1871FC530")]
	private Task HMPDHKNLENL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x71FCE90", Offset = "0x71FB490", VA = "0x1871FCE90")]
	private void JHEOOOKEGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x71FA060", Offset = "0x71F8660", VA = "0x1871FA060")]
	private void CLEGLLBPLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71FE4A0", Offset = "0x71FCAA0", VA = "0x1871FE4A0")]
	private void NCDKHMOFLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x71FD970", Offset = "0x71FBF70", VA = "0x1871FD970")]
	[AsyncStateMachine(typeof(GPGAEJIDFBD))]
	private Task LLBJGDMPOHH(KKFIONHAJIH DGDKLIAKJBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x71FD880", Offset = "0x71FBE80", VA = "0x1871FD880")]
	[CompilerGenerated]
	private void LHJMMBLKHCN(Task<TaskStatus> KECDGIGMBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x71FDC50", Offset = "0x71FC250", VA = "0x1871FDC50")]
	[CompilerGenerated]
	private Task<JDOFPIHCNPL> MKJOPCCECGG(CGAHDNNENFF P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x71FA6B0", Offset = "0x71F8CB0", VA = "0x1871FA6B0")]
	[CompilerGenerated]
	internal static Dictionary<Guid, EBOBONEGPPF> DCAOJCBDBEI(JDOFPIHCNPL POBDLJBBBCI, IGJHCFCDPFK P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LDCDGMPOHLK : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x71F7810", Offset = "0x71F5E10", VA = "0x1871F7810")]
	public LDCDGMPOHLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CBEBAADDCDD
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMNFCGDHMMF HALMBNDHJBL();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LDCDGMPOHLK KNOLNPNIMIP();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KNKLHFEDLIF ACJAKEDGPAG();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IOOHFOADCGF : CBEBAADDCDD
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x71F53C0", Offset = "0x71F39C0", VA = "0x1871F53C0")]
	[DJINMBCHLNM.PJKIGKAPDIK.PCJJKFLDJEL]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IOOHFOADCGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x71F5520", Offset = "0x71F3B20", VA = "0x1871F5520", Slot = "4")]
	public IMNFCGDHMMF HALMBNDHJBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x71F5630", Offset = "0x71F3C30", VA = "0x1871F5630", Slot = "5")]
	public LDCDGMPOHLK KNOLNPNIMIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x71F5430", Offset = "0x71F3A30", VA = "0x1871F5430", Slot = "6")]
	public KNKLHFEDLIF ACJAKEDGPAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KNKLHFEDLIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly Dictionary<long, LOBMDFINEHO> CGBGFBFMDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly LOBMDFINEHO[] LGAKMHCOJEO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool EPCLBLNNBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA00000", Offset = "0x9FE600", VA = "0x180A00000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xB69440", Offset = "0xB67A40", VA = "0x180B69440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BBLBCNNIBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x71F66E0", Offset = "0x71F4CE0", VA = "0x1871F66E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long FDFLOJKJHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8879C0", Offset = "0x885FC0", VA = "0x1808879C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x71F6C90", Offset = "0x71F5290", VA = "0x1871F6C90")]
	public void INOEHFICEHA(long FNKMOIJJLLC, IEnumerable<LOBMDFINEHO> PKHLPDFNIKO, bool GJEEEBDAPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x71F71A0", Offset = "0x71F57A0", VA = "0x1871F71A0")]
	public IReadOnlyList<LOBMDFINEHO> NBCIAFGAGIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xB69440", Offset = "0xB67A40", VA = "0x180B69440")]
	public void NDLANPKEDBN(bool JIGAADHGKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x71F7350", Offset = "0x71F5950", VA = "0x1871F7350")]
	public bool NDLMCAEOBMK(long JHPLIGJBFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x71F6AD0", Offset = "0x71F50D0", VA = "0x1871F6AD0")]
	public bool IAPOAIPBNJA(LOBMDFINEHO EBFHMPKMAGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x71F7430", Offset = "0x71F5A30", VA = "0x1871F7430")]
	public bool NFGKDJOKOCN(List<LOBMDFINEHO> EPLMPPOCBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x71F6880", Offset = "0x71F4E80", VA = "0x1871F6880")]
	public bool FEENCFFHCGD(long JHPLIGJBFOF, [Out] LOBMDFINEHO BAKDDABGCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x71F6920", Offset = "0x71F4F20", VA = "0x1871F6920")]
	public bool HLJLFNFJNCI(string KJPHMNNIMDP, [Out] LOBMDFINEHO BAKDDABGCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x71F6610", Offset = "0x71F4C10", VA = "0x1871F6610")]
	public List<LOBMDFINEHO> EAPPDEKOIPK(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x71F6740", Offset = "0x71F4D40", VA = "0x1871F6740")]
	public List<LOBMDFINEHO> EKJAAIKPCBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x71F65E0", Offset = "0x71F4BE0", VA = "0x1871F65E0")]
	public LOBMDFINEHO CMLGCOIMGKG(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x71F7140", Offset = "0x71F5740", VA = "0x1871F7140")]
	public IReadOnlyList<LOBMDFINEHO> LFCHEBBNFAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x71F7750", Offset = "0x71F5D50", VA = "0x1871F7750")]
	public KNKLHFEDLIF()
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
