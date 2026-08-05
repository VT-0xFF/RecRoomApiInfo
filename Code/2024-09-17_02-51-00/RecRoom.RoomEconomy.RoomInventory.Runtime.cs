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
		[Cpp2IlInjected.Address(RVA = "0x72ECFD0", Offset = "0x72EB9D0", VA = "0x1872ECFD0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
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
		[Cpp2IlInjected.Address(RVA = "0x8999C0", Offset = "0x8983C0", VA = "0x1808999C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LKAFIMGLNLE BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72DF3C0", Offset = "0x72DDDC0", VA = "0x1872DF3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72DF8A0", Offset = "0x72DE2A0", VA = "0x1872DF8A0")]
	public void INOEHFICEHA(long FNKMOIJJLLC, IEnumerable<KKFIONHAJIH> GPCPPKHCEBD, IEnumerable<EFCECCIBPKB> NIENBLPJDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72DF840", Offset = "0x72DE240", VA = "0x1872DF840")]
	public bool INDDGGEAPOB(Guid LILBGFPIHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72E0390", Offset = "0x72DED90", VA = "0x1872E0390")]
	public bool MBEEDABKNGP(Guid LILBGFPIHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72E0160", Offset = "0x72DEB60", VA = "0x1872E0160")]
	public bool KEIPDHKOALO(KKFIONHAJIH CEGBHJCDDNE, [Out] KKFIONHAJIH KGCKEOAONMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72DF4C0", Offset = "0x72DDEC0", VA = "0x1872DF4C0")]
	public IEnumerable<LKAFIMGLNLE> EGBGMHABJAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72DF700", Offset = "0x72DE100", VA = "0x1872DF700")]
	public IEnumerable<KKFIONHAJIH> HIKIGAOENAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72DF5C0", Offset = "0x72DDFC0", VA = "0x1872DF5C0")]
	public IEnumerable<EFCECCIBPKB> HFCKJHEGDCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72DF290", Offset = "0x72DDC90", VA = "0x1872DF290")]
	public bool AMHHBDMMFDP(Guid LILBGFPIHAH, [Out] KKFIONHAJIH ILKELCDIMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x72DF420", Offset = "0x72DDE20", VA = "0x1872DF420")]
	public bool DFJKMAKNLEI(string MCBPAIFCBEJ, [Out] KKFIONHAJIH ILKELCDIMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72DF510", Offset = "0x72DDF10", VA = "0x1872DF510")]
	public bool EJFNCOJFINO(Guid LILBGFPIHAH, [Out] EFCECCIBPKB HJOINFBEGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72DF1F0", Offset = "0x72DDBF0", VA = "0x1872DF1F0")]
	public bool AGLHJOMFMNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72DF340", Offset = "0x72DDD40", VA = "0x1872DF340")]
	private bool BCHDBCOCLLA(KKFIONHAJIH MMECFHEAHOI, KKFIONHAJIH EFPBPDDONKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72E05D0", Offset = "0x72DEFD0", VA = "0x1872E05D0")]
	private void OOECKEMCLOH(Guid HGFDMIDEFHN, LKAFIMGLNLE COLFNOMMKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72DFF20", Offset = "0x72DE920", VA = "0x1872DFF20")]
	private bool KCHNDPEANEN(Guid HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72DF100", Offset = "0x72DDB00", VA = "0x1872DF100")]
	private void AGIDKNHICMD(KKFIONHAJIH ADDPDEPHCPO, [Optional] KKFIONHAJIH KPBHJNBJCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72E03B0", Offset = "0x72DEDB0", VA = "0x1872E03B0")]
	private bool MKLBOCFCHJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72E0590", Offset = "0x72DEF90", VA = "0x1872E0590")]
	private static bool ODPLHJKBDLN(KKFIONHAJIH IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72E0810", Offset = "0x72DF210", VA = "0x1872E0810")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E3310", Offset = "0x72E1D10", VA = "0x1872E3310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x72E3730", Offset = "0x72E2130", VA = "0x1872E3730", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DD610", Offset = "0x72DC010", VA = "0x1872DD610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72DDE30", Offset = "0x72DC830", VA = "0x1872DDE30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E0BD0", Offset = "0x72DF5D0", VA = "0x1872E0BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72E13C0", Offset = "0x72DFDC0", VA = "0x1872E13C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E41A0", Offset = "0x72E2BA0", VA = "0x1872E41A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72E4520", Offset = "0x72E2F20", VA = "0x1872E4520", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72EC8B0", Offset = "0x72EB2B0", VA = "0x1872EC8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72ECD10", Offset = "0x72EB710", VA = "0x1872ECD10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DBAE0", Offset = "0x72DA4E0", VA = "0x1872DBAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x72DBF60", Offset = "0x72DA960", VA = "0x1872DBF60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DC9C0", Offset = "0x72DB3C0", VA = "0x1872DC9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x72DD5A0", Offset = "0x72DBFA0", VA = "0x1872DD5A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E2D80", Offset = "0x72E1780", VA = "0x1872E2D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x72E32A0", Offset = "0x72E1CA0", VA = "0x1872E32A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E37A0", Offset = "0x72E21A0", VA = "0x1872E37A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x72E4130", Offset = "0x72E2B30", VA = "0x1872E4130", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DB5B0", Offset = "0x72D9FB0", VA = "0x1872DB5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x72DBA00", Offset = "0x72DA400", VA = "0x1872DBA00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FPLGMNAKPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72DBA70", Offset = "0x72DA470", VA = "0x1872DBA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DA5B0", Offset = "0x72D8FB0", VA = "0x1872DA5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72DAFD0", Offset = "0x72D99D0", VA = "0x1872DAFD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72EB9F0", Offset = "0x72EA3F0", VA = "0x1872EB9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72EC840", Offset = "0x72EB240", VA = "0x1872EC840", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DDEA0", Offset = "0x72DC8A0", VA = "0x1872DDEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x72DF0A0", Offset = "0x72DDAA0", VA = "0x1872DF0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E1430", Offset = "0x72DFE30", VA = "0x1872E1430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x72E1AB0", Offset = "0x72E04B0", VA = "0x1872E1AB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DB040", Offset = "0x72D9A40", VA = "0x1872DB040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x72DB540", Offset = "0x72D9F40", VA = "0x1872DB540", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DA020", Offset = "0x72D8A20", VA = "0x1872DA020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x72DA540", Offset = "0x72D8F40", VA = "0x1872DA540", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72DBFD0", Offset = "0x72DA9D0", VA = "0x1872DBFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x72DC960", Offset = "0x72DB360", VA = "0x1872DC960", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E4E70", Offset = "0x72E3870", VA = "0x1872E4E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GHNLMGKLHKE HMEIIGLAMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA93220", Offset = "0xA91C20", VA = "0x180A93220", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD26410", Offset = "0xD24E10", VA = "0x180D26410", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KHECJJJIFBB<KKFIONHAJIH> KCHFPBMNBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96AD90", Offset = "0x969790", VA = "0x18096AD90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB9C4C0", Offset = "0xB9AEC0", VA = "0x180B9C4C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KHECJJJIFBB<Guid> PDDGOGMIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9E1440", Offset = "0x9DFE40", VA = "0x1809E1440", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBA4230", Offset = "0xBA2C30", VA = "0x180BA4230", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LLEJOEJOMJB<EFCECCIBPKB, int> AJHNHPBOFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x976500", Offset = "0x974F00", VA = "0x180976500", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A9640", Offset = "0x9A8040", VA = "0x1809A9640", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KHECJJJIFBB<LOBMDFINEHO> ECOCCEMGNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x897E50", Offset = "0x896850", VA = "0x180897E50", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x897E60", Offset = "0x896860", VA = "0x180897E60", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KHECJJJIFBB<long> BJPPMFELPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB0F290", Offset = "0xB0DC90", VA = "0x180B0F290", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xC491E0", Offset = "0xC47BE0", VA = "0x180C491E0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GHNLMGKLHKE CBCOCPILJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAE22C0", Offset = "0xAE0CC0", VA = "0x180AE22C0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDEECB0", Offset = "0xDED6B0", VA = "0x180DEECB0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GHNLMGKLHKE LGOPGAOCLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E2C20", Offset = "0x8E1620", VA = "0x1808E2C20", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xDEEC90", Offset = "0xDED690", VA = "0x180DEEC90", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72E4590", Offset = "0x72E2F90", VA = "0x1872E4590")]
	[DJINMBCHLNM.PJKIGKAPDIK.PCJJKFLDJEL]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72EAE70", Offset = "0x72E9870", VA = "0x1872EAE70")]
	[RecRoom.NoEngine.Common.Preserve]
	public NBELGHIIKJI([OLJNBPOCBCJ(null)] JKJPMODAMIK NHGFAJLPBFB, [OLJNBPOCBCJ(null)] NKGGADPENME GEONLCHHBCJ, [OLJNBPOCBCJ(null)] LFLHEMBPLIN GPMNKKCFBKN, [OLJNBPOCBCJ(null)] EJMHILFALFD EADMNLDABPK, [OLJNBPOCBCJ(null)] LFGBFBPJNCH JAFFEKBAIOJ, [OLJNBPOCBCJ(null)] CJEGNMKBHPN JMHNCEGLNMN, [OLJNBPOCBCJ(null)] KCAAKKHNOIM LAOMBFINDHK, [OLJNBPOCBCJ(null)] ABCENOCDHAO IEGEAMBPEMD, [OLJNBPOCBCJ(null)] CBEBAADDCDD JJAJCICOHEI, [OLJNBPOCBCJ(null)] CDCHCDMFJJO KKMFJEOBINB, [OLJNBPOCBCJ(null)] GDCKAILFDNA OAHAJEFMEJN, [OLJNBPOCBCJ(null)] NIBILAFKEMK HMHBIGEEOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72E6380", Offset = "0x72E4D80", VA = "0x1872E6380", Slot = "50")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72E62E0", Offset = "0x72E4CE0", VA = "0x1872E62E0", Slot = "49")]
	public Task DJFMEJLPMDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72E95A0", Offset = "0x72E7FA0", VA = "0x1872E95A0", Slot = "20")]
	[AsyncStateMachine(typeof(MKIKKFGDJEJ))]
	public Task<BCLNLKLFCPB<KKFIONHAJIH, string>> MNFKNFGNBLL(long FNKMOIJJLLC, string KJPHMNNIMDP, string PADNFDKMCHE, string CPGBJNDENLC, RoomInventoryItemProperties DAODDBNNDHB, byte CICGHDIEJHI, int FEHNKBJAMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72E72F0", Offset = "0x72E5CF0", VA = "0x1872E72F0", Slot = "21")]
	[AsyncStateMachine(typeof(HCLDBCPLPGO))]
	public Task<BCLNLKLFCPB<KKFIONHAJIH, string>> GMJGOLINIAI(Guid LILBGFPIHAH, [Optional] string KJPHMNNIMDP, [Optional] string PADNFDKMCHE, [Optional] string CPGBJNDENLC, [Optional] List<long> DGPOFJIMGOM, [Optional] Dictionary<string, RoomInventoryTagClientProperties> JICKLDBPDAH, [Optional] RoomInventoryItemProperties DAODDBNNDHB, [Optional] byte? CICGHDIEJHI, [Optional] int? FEHNKBJAMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x72EA4F0", Offset = "0x72E8EF0", VA = "0x1872EA4F0", Slot = "22")]
	[AsyncStateMachine(typeof(JAINBFFBKLP))]
	public Task<BCLNLKLFCPB<bool, string>> PNDABDPEMFB(Guid LILBGFPIHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72E4EC0", Offset = "0x72E38C0", VA = "0x1872E4EC0", Slot = "23")]
	public IReadOnlyList<KKFIONHAJIH> BPAPCLAKKHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x72E66D0", Offset = "0x72E50D0", VA = "0x1872E66D0", Slot = "24")]
	public IReadOnlyList<KKFIONHAJIH> FDFBFHMGOFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72E7BE0", Offset = "0x72E65E0", VA = "0x1872E7BE0", Slot = "25")]
	public bool IEOJPJNKBDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x72E4A70", Offset = "0x72E3470", VA = "0x1872E4A70", Slot = "26")]
	public bool AMHHBDMMFDP(Guid LILBGFPIHAH, [Out] KKFIONHAJIH ILKELCDIMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x72E5DA0", Offset = "0x72E47A0", VA = "0x1872E5DA0", Slot = "27")]
	public bool DFJKMAKNLEI(string DBLNDHEAJLI, [Out] KKFIONHAJIH ILKELCDIMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x72E5720", Offset = "0x72E4120", VA = "0x1872E5720", Slot = "28")]
	public IReadOnlyList<EFCECCIBPKB> CNLOKGBKEBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72E65A0", Offset = "0x72E4FA0", VA = "0x1872E65A0", Slot = "29")]
	public bool EJFNCOJFINO(Guid LILBGFPIHAH, [Out] EFCECCIBPKB HJOINFBEGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72E4B90", Offset = "0x72E3590", VA = "0x1872E4B90", Slot = "30")]
	public long? BJPAHHGIANP(Guid LILBGFPIHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72E6070", Offset = "0x72E4A70", VA = "0x1872E6070", Slot = "48")]
	public void DHLMKAIMHGO(IEnumerable<IDEJICKEDMO> NIENBLPJDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72E8280", Offset = "0x72E6C80", VA = "0x1872E8280", Slot = "31")]
	[AsyncStateMachine(typeof(NBBKDINDBKH))]
	public Task<int> IOHFCOLLMLI(PDPPFLAPOCL JDDNDMPDAKN, Guid LILBGFPIHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72E4D20", Offset = "0x72E3720", VA = "0x1872E4D20", Slot = "32")]
	[AsyncStateMachine(typeof(NPEOAGOEAHL))]
	public Task<CELELCPBKCC> BKDFEEHFMIB(PDPPFLAPOCL AMMLJLJEMLJ, Guid LILBGFPIHAH, int OGKJJPEBIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72E8FB0", Offset = "0x72E79B0", VA = "0x1872E8FB0", Slot = "33")]
	public string MCNNLJMFAJC(JDOFPIHCNPL POBDLJBBBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72E4F70", Offset = "0x72E3970", VA = "0x1872E4F70", Slot = "34")]
	public bool CIGPNPHDHFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72E98A0", Offset = "0x72E82A0", VA = "0x1872E98A0", Slot = "36")]
	[AsyncStateMachine(typeof(GGDILDBOMNK))]
	public Task<BCLNLKLFCPB<LOBMDFINEHO, string>> NAIIHKCPGMB(long JHPLIGJBFOF, RoomInventoryTagClientProperties DAODDBNNDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72E4600", Offset = "0x72E3000", VA = "0x1872E4600", Slot = "37")]
	[AsyncStateMachine(typeof(HCGKBNHDOOI))]
	public Task<BCLNLKLFCPB<bool, string>> ABIHEIKALCF(long JHPLIGJBFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72E5900", Offset = "0x72E4300", VA = "0x1872E5900", Slot = "40")]
	public List<(long, int)> CNMJAAPBIIJ(long LNOABIANIDA, int BMHCLJGJBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72E7710", Offset = "0x72E6110", VA = "0x1872E7710", Slot = "41")]
	public bool HIMDPIDKJBD(long JHPLIGJBFOF, [Out] LOBMDFINEHO FAGGHLLJBDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72E5390", Offset = "0x72E3D90", VA = "0x1872E5390", Slot = "42")]
	public bool CJPFOHDLIGA(long JHPLIGJBFOF, Guid IFHCGJEIDJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72E8DD0", Offset = "0x72E77D0", VA = "0x1872E8DD0", Slot = "43")]
	public IReadOnlyList<LOBMDFINEHO> LKNBHBADKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72E5EC0", Offset = "0x72E48C0", VA = "0x1872E5EC0", Slot = "44")]
	public List<LOBMDFINEHO> DGDEAPDCBNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72E4FE0", Offset = "0x72E39E0", VA = "0x1872E4FE0", Slot = "45")]
	public IReadOnlyList<LOBMDFINEHO> CIMGFHDIECE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72E8780", Offset = "0x72E7180", VA = "0x1872E8780", Slot = "39")]
	public bool KGFFDPOGKPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72E7CF0", Offset = "0x72E66F0", VA = "0x1872E7CF0", Slot = "46")]
	public IReadOnlyList<KKFIONHAJIH> IHKBLECMPNP(long JHPLIGJBFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72E6E20", Offset = "0x72E5820", VA = "0x1872E6E20", Slot = "38")]
	[AsyncStateMachine(typeof(LFKFKCLGAGM))]
	public Task<BCLNLKLFCPB<bool, string>> FPBHGBEAKBG(long FNKMOIJJLLC, bool JIGAADHGKBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72E8430", Offset = "0x72E6E30", VA = "0x1872E8430", Slot = "51")]
	public bool KCNKELKNKKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72E6980", Offset = "0x72E5380", VA = "0x1872E6980", Slot = "47")]
	public bool FGNKMMDNLOO(string CMGGAFNDIOI, [Out] IReadOnlyList<KKFIONHAJIH> ONBOBDMANPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72E9AE0", Offset = "0x72E84E0", VA = "0x1872E9AE0")]
	[AsyncStateMachine(typeof(MMJKPICGAHH))]
	private Task<Dictionary<long, EFIDOFIHPIO>> NOJONPJKMAE(Dictionary<long, int> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72E8800", Offset = "0x72E7200", VA = "0x1872E8800")]
	[AsyncStateMachine(typeof(DEANJODANAC))]
	private Task<CELELCPBKCC> KHCHDCBDIHF(Guid LILBGFPIHAH, int OGKJJPEBIOK, [Optional] Guid GFKPDFEHKEC, [Optional] PDPPFLAPOCL EIEIPOMAGKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72E77A0", Offset = "0x72E61A0", VA = "0x1872E77A0")]
	[AsyncStateMachine(typeof(BOKFDCNNCCM))]
	private Task<Dictionary<Guid, EBOBONEGPPF>> HKGOBCPPEBD(Dictionary<Guid, int> EODNLOCFKPF, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72E7FD0", Offset = "0x72E69D0", VA = "0x1872E7FD0")]
	[AsyncStateMachine(typeof(NHDLAPHHABE))]
	private Task<List<EBOBONEGPPF>> IJGNENGLGIN(Dictionary<Guid, int> EODNLOCFKPF, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x72E6F40", Offset = "0x72E5940", VA = "0x1872E6F40")]
	[AsyncStateMachine(typeof(IJFKNLDOEPE))]
	private Task GFOGOILFGJI(long FNKMOIJJLLC, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72E8950", Offset = "0x72E7350", VA = "0x1872E8950")]
	private Task KLELPKFLDFJ(ANLFOIKADDC AAAOIGBEBAB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72E5650", Offset = "0x72E4050", VA = "0x1872E5650")]
	[AsyncStateMachine(typeof(KDAPMLBPILE))]
	private Task CMBFKKCPKNF(ANLFOIKADDC AAAOIGBEBAB, CancellationToken LNCHLOFJINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72E84A0", Offset = "0x72E6EA0", VA = "0x1872E84A0")]
	private void KDFFOFMAALE(CHJHHHALIJJ LPCLPANOJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72EA950", Offset = "0x72E9350", VA = "0x1872EA950")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string KHIDLJMKMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x72E78E0", Offset = "0x72E62E0", VA = "0x1872E78E0")]
	private void HLEJHDDLHOI(Guid LILBGFPIHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72EAA90", Offset = "0x72E9490", VA = "0x1872EAA90")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid LILBGFPIHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72EA1F0", Offset = "0x72E8BF0", VA = "0x1872EA1F0")]
	[AsyncStateMachine(typeof(DDFJMJPHJLK))]
	private Task<int> OGHOGMFDIDM(PDPPFLAPOCL JDDNDMPDAKN, Guid LILBGFPIHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72EA760", Offset = "0x72E9160", VA = "0x1872EA760")]
	[MEEBNJDNHKC]
	internal void RpcGetPlayerRoomInventoryCount(Guid FAOKHBLGHEO, Guid LILBGFPIHAH, HLGLPAHDPHI ONLDJBALHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72EA6E0", Offset = "0x72E90E0", VA = "0x1872EA6E0")]
	[MEEBNJDNHKC]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid FAOKHBLGHEO, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72EA3A0", Offset = "0x72E8DA0", VA = "0x1872EA3A0")]
	[AsyncStateMachine(typeof(AKEOMJLEJCD))]
	private Task<CELELCPBKCC> PJLDPHFGFOI(PDPPFLAPOCL JDDNDMPDAKN, Guid LILBGFPIHAH, int OGKJJPEBIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72EA610", Offset = "0x72E9010", VA = "0x1872EA610")]
	[MEEBNJDNHKC]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid FAOKHBLGHEO, Guid LILBGFPIHAH, int OGKJJPEBIOK, HLGLPAHDPHI ONLDJBALHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72E85C0", Offset = "0x72E6FC0", VA = "0x1872E85C0")]
	private void KFLIPKAICKB(PDPPFLAPOCL AMMLJLJEMLJ, Guid FAOKHBLGHEO, JDOFPIHCNPL POBDLJBBBCI, long LNMJACLABDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72EAD40", Offset = "0x72E9740", VA = "0x1872EAD40")]
	[MEEBNJDNHKC]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid FAOKHBLGHEO, int POBDLJBBBCI, long LNMJACLABDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72E9720", Offset = "0x72E8120", VA = "0x1872E9720")]
	private void MPPGGHACGGM(bool JIGAADHGKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72EACE0", Offset = "0x72E96E0", VA = "0x1872EACE0")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool KFKHKDMIGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72E5F50", Offset = "0x72E4950", VA = "0x1872E5F50")]
	private void DHEGFLIDBJM(List<EFIDOFIHPIO> HMBGNNFLHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72EAB30", Offset = "0x72E9530", VA = "0x1872EAB30")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string BCMCHBMGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x72E8110", Offset = "0x72E6B10", VA = "0x1872E8110")]
	private void IJPBKKIMLCB(long JHPLIGJBFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x72EAAC0", Offset = "0x72E94C0", VA = "0x1872EAAC0")]
	[MEEBNJDNHKC]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long JHPLIGJBFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x72E7070", Offset = "0x72E5A70", VA = "0x1872E7070")]
	private KKFIONHAJIH GJAHOGNEPLH(CHJHHHALIJJ LPCLPANOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x72E7110", Offset = "0x72E5B10", VA = "0x1872E7110")]
	private List<LOBMDFINEHO> GKKPMOIFALE(List<EFIDOFIHPIO> HMBGNNFLHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72E4720", Offset = "0x72E3120", VA = "0x1872E4720")]
	private List<LOBMDFINEHO> AKOOHJDBJMM(IEnumerable<EFIDOFIHPIO> HMBGNNFLHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72E9C20", Offset = "0x72E8620", VA = "0x1872E9C20")]
	private KKFIONHAJIH OEFKJPADAHF(CHJHHHALIJJ LPCLPANOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72E74A0", Offset = "0x72E5EA0", VA = "0x1872E74A0")]
	private LOBMDFINEHO HBPOHLDJIKO(EFIDOFIHPIO LPCLPANOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72EA330", Offset = "0x72E8D30", VA = "0x1872EA330")]
	private void PJCHFHAALNL(EFCECCIBPKB HJOINFBEGAN, int LADBNOJOPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72EA180", Offset = "0x72E8B80", VA = "0x1872EA180")]
	private void OFAAPEHGFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x72E7A60", Offset = "0x72E6460", VA = "0x1872E7A60")]
	private Task HMPDHKNLENL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72E83C0", Offset = "0x72E6DC0", VA = "0x1872E83C0")]
	private void JHEOOOKEGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72E5590", Offset = "0x72E3F90", VA = "0x1872E5590")]
	private void CLEGLLBPLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x72E99D0", Offset = "0x72E83D0", VA = "0x1872E99D0")]
	private void NCDKHMOFLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72E8EA0", Offset = "0x72E78A0", VA = "0x1872E8EA0")]
	[AsyncStateMachine(typeof(GPGAEJIDFBD))]
	private Task LLBJGDMPOHH(KKFIONHAJIH DGDKLIAKJBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x72E8DB0", Offset = "0x72E77B0", VA = "0x1872E8DB0")]
	[CompilerGenerated]
	private void LHJMMBLKHCN(Task<TaskStatus> KECDGIGMBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72E9180", Offset = "0x72E7B80", VA = "0x1872E9180")]
	[CompilerGenerated]
	private Task<JDOFPIHCNPL> MKJOPCCECGG(CGAHDNNENFF P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72E5BE0", Offset = "0x72E45E0", VA = "0x1872E5BE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x72E2D40", Offset = "0x72E1740", VA = "0x1872E2D40")]
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
	[Cpp2IlInjected.Address(RVA = "0x72E08F0", Offset = "0x72DF2F0", VA = "0x1872E08F0")]
	[DJINMBCHLNM.PJKIGKAPDIK.PCJJKFLDJEL]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IOOHFOADCGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x72E0A50", Offset = "0x72DF450", VA = "0x1872E0A50", Slot = "4")]
	public IMNFCGDHMMF HALMBNDHJBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x72E0B60", Offset = "0x72DF560", VA = "0x1872E0B60", Slot = "5")]
	public LDCDGMPOHLK KNOLNPNIMIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x72E0960", Offset = "0x72DF360", VA = "0x1872E0960", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x923890", Offset = "0x922290", VA = "0x180923890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x923B70", Offset = "0x922570", VA = "0x180923B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BBLBCNNIBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72E1C10", Offset = "0x72E0610", VA = "0x1872E1C10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long FDFLOJKJHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8999C0", Offset = "0x8983C0", VA = "0x1808999C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x72E21C0", Offset = "0x72E0BC0", VA = "0x1872E21C0")]
	public void INOEHFICEHA(long FNKMOIJJLLC, IEnumerable<LOBMDFINEHO> PKHLPDFNIKO, bool GJEEEBDAPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x72E26D0", Offset = "0x72E10D0", VA = "0x1872E26D0")]
	public IReadOnlyList<LOBMDFINEHO> NBCIAFGAGIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x923B70", Offset = "0x922570", VA = "0x180923B70")]
	public void NDLANPKEDBN(bool JIGAADHGKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x72E2880", Offset = "0x72E1280", VA = "0x1872E2880")]
	public bool NDLMCAEOBMK(long JHPLIGJBFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x72E2000", Offset = "0x72E0A00", VA = "0x1872E2000")]
	public bool IAPOAIPBNJA(LOBMDFINEHO EBFHMPKMAGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x72E2960", Offset = "0x72E1360", VA = "0x1872E2960")]
	public bool NFGKDJOKOCN(List<LOBMDFINEHO> EPLMPPOCBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x72E1DB0", Offset = "0x72E07B0", VA = "0x1872E1DB0")]
	public bool FEENCFFHCGD(long JHPLIGJBFOF, [Out] LOBMDFINEHO BAKDDABGCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x72E1E50", Offset = "0x72E0850", VA = "0x1872E1E50")]
	public bool HLJLFNFJNCI(string KJPHMNNIMDP, [Out] LOBMDFINEHO BAKDDABGCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x72E1B40", Offset = "0x72E0540", VA = "0x1872E1B40")]
	public List<LOBMDFINEHO> EAPPDEKOIPK(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x72E1C70", Offset = "0x72E0670", VA = "0x1872E1C70")]
	public List<LOBMDFINEHO> EKJAAIKPCBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x72E1B10", Offset = "0x72E0510", VA = "0x1872E1B10")]
	public LOBMDFINEHO CMLGCOIMGKG(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x72E2670", Offset = "0x72E1070", VA = "0x1872E2670")]
	public IReadOnlyList<LOBMDFINEHO> LFCHEBBNFAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x72E2C80", Offset = "0x72E1680", VA = "0x1872E2C80")]
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
