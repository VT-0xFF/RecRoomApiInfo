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
		[Cpp2IlInjected.Address(RVA = "0x84102F0", Offset = "0x840F2F0", VA = "0x1884102F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AALLDOKMFBM : DIBEHCOMJEH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CHJLFHPBEIP LHJJHBOGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class CNPECAJLKAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, PLCBHFGGLGD> GOBHFAOGMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, PLCBHFGGLGD> LIMNPEFFOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? PHAKEABGPKG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PLCBHFGGLGD OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8404150", Offset = "0x8403150", VA = "0x188404150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8404250", Offset = "0x8403250", VA = "0x188404250")]
	public void BMNCPLHPNKH(long CINEDGEJAIA, IEnumerable<AFLLNPHGMEA> FNEFFELDAMJ, IEnumerable<LLGFAIJGGMG> GNLBCGGIPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8405780", Offset = "0x8404780", VA = "0x188405780")]
	public bool OFJAPOLKLCM(Guid EDFMANFDKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8404F50", Offset = "0x8403F50", VA = "0x188404F50")]
	public bool GNAALOCCJEL(Guid EDFMANFDKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84050C0", Offset = "0x84040C0", VA = "0x1884050C0")]
	public bool ICFJKEHMCMG(AFLLNPHGMEA BNLFNGJABAE, [Out] AFLLNPHGMEA FDCAOKFFMED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8405730", Offset = "0x8404730", VA = "0x188405730")]
	public IEnumerable<PLCBHFGGLGD> NMONELOPCIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8404BB0", Offset = "0x8403BB0", VA = "0x188404BB0")]
	public IEnumerable<AFLLNPHGMEA> CGAFNIOCNGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8404F70", Offset = "0x8403F70", VA = "0x188404F70")]
	public IEnumerable<LLGFAIJGGMG> HLJEABGCNIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84040A0", Offset = "0x84030A0", VA = "0x1884040A0")]
	public bool AAPAJFADHBN(Guid EDFMANFDKLC, [Out] AFLLNPHGMEA BHBGJPKFAGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84048C0", Offset = "0x84038C0", VA = "0x1884048C0")]
	public bool BOKGENOKIOC(string FDMDHLKAKLL, [Out] AFLLNPHGMEA BHBGJPKFAGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84052F0", Offset = "0x84042F0", VA = "0x1884052F0")]
	public bool JHJBAINNLJN(Guid EDFMANFDKLC, [Out] LLGFAIJGGMG JOGAAHCGFLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84041B0", Offset = "0x84031B0", VA = "0x1884041B0")]
	public bool BGEDDINLKFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84053E0", Offset = "0x84043E0", VA = "0x1884053E0")]
	private bool MNEDLCMAKPI(AFLLNPHGMEA DAIGGDIKJOJ, AFLLNPHGMEA HOPGKAFMGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8404D00", Offset = "0x8403D00", VA = "0x188404D00")]
	private void DFFGOANIAEF(Guid OHHMJGCBCKD, PLCBHFGGLGD KHHHMCLFHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8404960", Offset = "0x8403960", VA = "0x188404960")]
	private bool CAJPFCBEGFA(Guid OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8405460", Offset = "0x8404460", VA = "0x188405460")]
	private void MNKKFFBAEKJ(AFLLNPHGMEA GAJHKEIJCON, [Optional] AFLLNPHGMEA AOEHCBDDGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8405550", Offset = "0x8404550", VA = "0x188405550")]
	private bool MOHIFCJEANK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84053A0", Offset = "0x84043A0", VA = "0x1884053A0")]
	private static bool KIJIFOHKHPI(AFLLNPHGMEA HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84057E0", Offset = "0x84047E0", VA = "0x1884057E0")]
	public CNPECAJLKAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CHJLFHPBEIP : KFJKIOCBFLM, CAFIFKCHJAI, IDisposable, CFOOLLLNECM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct JEMODCHIONC : IEquatable<JEMODCHIONC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long BJFFDFGEMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid BFKCMMGFLNM;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5093530", Offset = "0x5092530", VA = "0x185093530")]
		public JEMODCHIONC(long CINEDGEJAIA, Guid EDFMANFDKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x840C260", Offset = "0x840B260", VA = "0x18840C260", Slot = "4")]
		public bool Equals(JEMODCHIONC MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x840C100", Offset = "0x840B100", VA = "0x18840C100", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x840C360", Offset = "0x840B360", VA = "0x18840C360", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PLMGCIBLNNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<AFLLNPHGMEA, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CHJLFHPBEIP <>4__this;

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
		public List<HKDBDNMIAHA> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<OKKDFMAGFDP<NAHKCOBJMOP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x840FAD0", Offset = "0x840EAD0", VA = "0x18840FAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x840FFE0", Offset = "0x840EFE0", VA = "0x18840FFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FPOBCOPLCAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<AFLLNPHGMEA, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public CHJLFHPBEIP <>4__this;

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
		private TaskAwaiter<OKKDFMAGFDP<NAHKCOBJMOP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84079F0", Offset = "0x84069F0", VA = "0x1884079F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8408240", Offset = "0x8407240", VA = "0x188408240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NOFPOJCPKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private AFLLNPHGMEA <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private MDPKOJIHEAN <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<MDPKOJIHEAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x840E5D0", Offset = "0x840D5D0", VA = "0x18840E5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x840EDE0", Offset = "0x840DDE0", VA = "0x18840EDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IGMBLABPKLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AIPAHMNCJKP player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x840B300", Offset = "0x840A300", VA = "0x18840B300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x840B680", Offset = "0x840A680", VA = "0x18840B680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EGPAOMCLGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<NPGEFAPAANA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AIPAHMNCJKP recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<NPGEFAPAANA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8407060", Offset = "0x8406060", VA = "0x188407060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84074C0", Offset = "0x84064C0", VA = "0x1884074C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IEBMMMEIDGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<IKOGMGLMEPJ, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IKOGMGLMEPJ <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x840ADA0", Offset = "0x8409DA0", VA = "0x18840ADA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x840B220", Offset = "0x840A220", VA = "0x18840B220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PKECBAEHPMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<IKOGMGLMEPJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<HHHCCNLMPJL<IKOGMGLMEPJ, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<MDPKOJIHEAN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x840EE50", Offset = "0x840DE50", VA = "0x18840EE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x840FA60", Offset = "0x840EA60", VA = "0x18840FA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GMOFCAEKPJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<MDPKOJIHEAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8409FD0", Offset = "0x8408FD0", VA = "0x188409FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x840A4F0", Offset = "0x84094F0", VA = "0x18840A4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GHPMKJKJPDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, HKDBDNMIAHA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<OKKDFMAGFDP<List<HKDBDNMIAHA>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x84095A0", Offset = "0x84085A0", VA = "0x1884095A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8409F60", Offset = "0x8408F60", VA = "0x188409F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CBNLOKOFNAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LLGFAIJGGMG playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EGPHNOJKKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<NPGEFAPAANA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CBNLOKOFNAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AIPAHMNCJKP awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<MFEBDNMCCIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8407530", Offset = "0x8406530", VA = "0x188407530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8407980", Offset = "0x8406980", VA = "0x188407980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FNHAMFHKCBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<JEMODCHIONC, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IGCPPAKCIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public MFEBDNMCCIM result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IGCPPAKCIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x840B290", Offset = "0x840A290", VA = "0x18840B290")]
		internal PDCJOEIFKPI CCALMDMJFCJ(JEMODCHIONC id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct EEOLDBBBFJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<JEMODCHIONC, PDCJOEIFKPI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<JEMODCHIONC, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private FNHAMFHKCBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<PDCJOEIFKPI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8405FB0", Offset = "0x8404FB0", VA = "0x188405FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8406A80", Offset = "0x8405A80", VA = "0x188406A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LAKKFMOHBEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<PDCJOEIFKPI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<JEMODCHIONC, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<PDCJOEIFKPI> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<PDCJOEIFKPI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x840C3E0", Offset = "0x840B3E0", VA = "0x18840C3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x840D350", Offset = "0x840C350", VA = "0x18840D350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct GBECOFGPIGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<NAHKCOBJMOP>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<AOLCJDKHAPO>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<HKDBDNMIAHA>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<LNHNFGKPJHC> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<AFLLNPHGMEA> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<LLGFAIJGGMG> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<IKOGMGLMEPJ> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<NAHKCOBJMOP>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<AOLCJDKHAPO>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<HKDBDNMIAHA>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<LNHNFGKPJHC> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x84082B0", Offset = "0x84072B0", VA = "0x1884082B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8409500", Offset = "0x8408500", VA = "0x188409500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct DHBOACKOELO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x84058C0", Offset = "0x84048C0", VA = "0x1884058C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8405F50", Offset = "0x8404F50", VA = "0x188405F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct HGJMJECNAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AIPAHMNCJKP player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x840A840", Offset = "0x8409840", VA = "0x18840A840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x840AD30", Offset = "0x8409D30", VA = "0x18840AD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct EGBBJLAAEOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<NPGEFAPAANA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AIPAHMNCJKP player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<NPGEFAPAANA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8406AF0", Offset = "0x8405AF0", VA = "0x188406AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8406FF0", Offset = "0x8405FF0", VA = "0x188406FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct JDANILBELAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AFLLNPHGMEA itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CHJLFHPBEIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<HHHCCNLMPJL<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x840B6F0", Offset = "0x840A6F0", VA = "0x18840B6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x840C0A0", Offset = "0x840B0A0", VA = "0x18840C0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan FOOIGEBBIAI;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float MCHJCOLHBNM = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float NCCLIFLODNF = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int BCKFCGPEGPD = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string OHFMDCLFNGI = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string OKPHAGGENIE = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KIBFFJKINMA LCCDAHNFBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DFCGDGCKGFF KAJJIOJGJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KAMAILPHFOH MJCODFBDLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HLICHGGPCCA EHABNPOGCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MOEBIEAOCEG FKMDHPHEEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly AALLDOKMFBM PKDPBLDBCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LPGGOLFFKPF NNAMEELADIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly OCPBHCNJFHI GKAAJBFFLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EDGGJKNOCEO DHNGNBLIOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly CNPECAJLKAL AFAKIICMFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LGGOAPIOJBB OEJMBNEPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly GDIHHDPFIKL BEAKAGMHMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource GGCGFAEPDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly KKGBNMJCPKC<JEMODCHIONC, PDCJOEIFKPI> JOGPLAIFEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KKGBNMJCPKC<long, HKDBDNMIAHA> HHJDFDLOJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NJMKKGDLGCI GDODDJGGAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable LAEJDBMLGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task IDMPEDCJIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource PFKHCJANBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long IHLNPKKHAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private DFIANIHLECG FJLMGGKGAOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8402590", Offset = "0x8401590", VA = "0x188402590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GCADBNOOJOM AMJMAAKCFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD36B70", Offset = "0xD35B70", VA = "0x180D36B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD36B80", Offset = "0xD35B80", VA = "0x180D36B80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NPNKPOOAOFG<AFLLNPHGMEA> MKMHIMHGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xCC0110", Offset = "0xCBF110", VA = "0x180CC0110", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1148380", Offset = "0x1147380", VA = "0x181148380", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NPNKPOOAOFG<Guid> JNKDLGNNOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xCAABF0", Offset = "0xCA9BF0", VA = "0x180CAABF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD66840", Offset = "0xD65840", VA = "0x180D66840", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KICNHCAEGMA<LLGFAIJGGMG, int> MFGCMGMICKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA869A0", VA = "0x180A879A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA894A0", Offset = "0xA884A0", VA = "0x180A894A0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NPNKPOOAOFG<IKOGMGLMEPJ> OHOOIBGILKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4B0", Offset = "0x9FB4B0", VA = "0x1809FC4B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9FC480", Offset = "0x9FB480", VA = "0x1809FC480", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NPNKPOOAOFG<long> KNHKLEGBJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAB0EA0", Offset = "0xAAFEA0", VA = "0x180AB0EA0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB75B90", Offset = "0xB74B90", VA = "0x180B75B90", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GCADBNOOJOM OBDPKIMGNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA8D7A0", Offset = "0xA8C7A0", VA = "0x180A8D7A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA8C850", Offset = "0xA8B850", VA = "0x180A8C850", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GCADBNOOJOM MOPBMBGGDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA87B50", Offset = "0xA86B50", VA = "0x180A87B50", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA90EE0", Offset = "0xA8FEE0", VA = "0x180A90EE0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8402840", Offset = "0x8401840", VA = "0x188402840")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8403510", Offset = "0x8402510", VA = "0x188403510")]
	[RecRoom.NoEngine.Common.Preserve]
	public CHJLFHPBEIP([DJIFKCCBBND(null)] KIBFFJKINMA LCCDAHNFBOI, [DJIFKCCBBND(null)] DFCGDGCKGFF KAJJIOJGJOA, [DJIFKCCBBND(null)] KAMAILPHFOH MJCODFBDLBE, [DJIFKCCBBND(null)] HLICHGGPCCA EHABNPOGCKL, [DJIFKCCBBND(null)] JJOKNLDHNDC DGGBKPBNENO, [DJIFKCCBBND(null)] MOEBIEAOCEG FKMDHPHEEPI, [DJIFKCCBBND(null)] AALLDOKMFBM PKDPBLDBCEG, [DJIFKCCBBND(null)] EMDJFKOPMFD IMOCFFOOAIO, [DJIFKCCBBND(null)] EDMJMKMNIOJ PCNNEIPLOBG, [DJIFKCCBBND(null)] LPGGOLFFKPF NNAMEELADIK, [DJIFKCCBBND(null)] OCPBHCNJFHI GKAAJBFFLCD, [DJIFKCCBBND(null)] EDGGJKNOCEO DHNGNBLIOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83FE240", Offset = "0x83FD240", VA = "0x1883FE240", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83FDE40", Offset = "0x83FCE40", VA = "0x1883FDE40", Slot = "52")]
	public Task DDEDFLAJHNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8401FC0", Offset = "0x8400FC0", VA = "0x188401FC0", Slot = "20")]
	[AsyncStateMachine(typeof(PLMGCIBLNNI))]
	public Task<HHHCCNLMPJL<AFLLNPHGMEA, string>> MEMDAIDDBGB(Guid? LBDJDJIFMMO, long CINEDGEJAIA, string NFHOBPDKIPM, string HHPFBMBMELN, string PCHIHCHIMHB, RoomInventoryItemProperties FBEFHOGBKOJ, byte HIECCNNOPLP, int NGGKCKILBNF, [Optional] List<long> FNAGIFOGJOE, [Optional] List<HKDBDNMIAHA> HLMEELBCLMF, bool NHLBKAEBPKA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83FD990", Offset = "0x83FC990", VA = "0x1883FD990", Slot = "21")]
	[AsyncStateMachine(typeof(FPOBCOPLCAA))]
	public Task<HHHCCNLMPJL<AFLLNPHGMEA, string>> BJBHJOGMKDI(Guid EDFMANFDKLC, long CINEDGEJAIA, [Optional] string NFHOBPDKIPM, [Optional] string HHPFBMBMELN, [Optional] string PCHIHCHIMHB, [Optional] List<long> FNAGIFOGJOE, [Optional] Dictionary<string, RoomInventoryTagClientProperties> HLMEELBCLMF, [Optional] RoomInventoryItemProperties FBEFHOGBKOJ, [Optional] byte? HIECCNNOPLP, [Optional] int? NGGKCKILBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83FE7B0", Offset = "0x83FD7B0", VA = "0x1883FE7B0", Slot = "22")]
	[AsyncStateMachine(typeof(NOFPOJCPKIJ))]
	public Task<HHHCCNLMPJL<bool, string>> ELAEIOLHINB(Guid EDFMANFDKLC, long CINEDGEJAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83FDD90", Offset = "0x83FCD90", VA = "0x1883FDD90", Slot = "23")]
	public IReadOnlyList<AFLLNPHGMEA> CAJOCGOKCEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84002A0", Offset = "0x83FF2A0", VA = "0x1884002A0", Slot = "24")]
	public IReadOnlyList<AFLLNPHGMEA> JNIIGLONDKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8402350", Offset = "0x8401350", VA = "0x188402350", Slot = "25")]
	public bool NEFOGEJHPIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83FC990", Offset = "0x83FB990", VA = "0x1883FC990", Slot = "26")]
	public bool AAPAJFADHBN(Guid EDFMANFDKLC, [Out] AFLLNPHGMEA BHBGJPKFAGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83FDC70", Offset = "0x83FCC70", VA = "0x1883FDC70", Slot = "27")]
	public bool BOKGENOKIOC(string NHBHGFEMCKC, [Out] AFLLNPHGMEA BHBGJPKFAGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8400740", Offset = "0x83FF740", VA = "0x188400740", Slot = "28")]
	public IReadOnlyList<LLGFAIJGGMG> KCAJDIOPADG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8400170", Offset = "0x83FF170", VA = "0x188400170", Slot = "29")]
	public bool JHJBAINNLJN(Guid EDFMANFDKLC, [Out] LLGFAIJGGMG JOGAAHCGFLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83FF120", Offset = "0x83FE120", VA = "0x1883FF120", Slot = "30")]
	public long? HIDHEBNHMLG(Guid EDFMANFDKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83FFCC0", Offset = "0x83FECC0", VA = "0x1883FFCC0", Slot = "51")]
	public void IOEINPONPNJ(IEnumerable<AOLCJDKHAPO> GNLBCGGIPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8402450", Offset = "0x8401450", VA = "0x188402450", Slot = "31")]
	[AsyncStateMachine(typeof(IGMBLABPKLC))]
	public Task<int> NFNDENMOHAI(AIPAHMNCJKP EKEPPODJHCN, Guid EDFMANFDKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83FFB70", Offset = "0x83FEB70", VA = "0x1883FFB70", Slot = "32")]
	[AsyncStateMachine(typeof(EGPAOMCLGJM))]
	public Task<NPGEFAPAANA> IMJJKHLHIMN(AIPAHMNCJKP HICDMGMONDF, Guid EDFMANFDKLC, int GFNDILIHOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84025E0", Offset = "0x84015E0", VA = "0x1884025E0", Slot = "33")]
	public string NIKHBKBENJL(MFEBDNMCCIM OBOOAPELMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83FD8B0", Offset = "0x83FC8B0", VA = "0x1883FD8B0", Slot = "34")]
	public bool BGACCKNIGEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83FFF30", Offset = "0x83FEF30", VA = "0x1883FFF30", Slot = "38")]
	[AsyncStateMachine(typeof(IEBMMMEIDGP))]
	public Task<HHHCCNLMPJL<IKOGMGLMEPJ, string>> JBGKFJEFMBL(long HJPBKGBOCJN, RoomInventoryTagClientProperties FBEFHOGBKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83FDB50", Offset = "0x83FCB50", VA = "0x1883FDB50", Slot = "39")]
	[AsyncStateMachine(typeof(PKECBAEHPMH))]
	public Task<HHHCCNLMPJL<bool, string>> BKBEAJOFPID(long HJPBKGBOCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83FF760", Offset = "0x83FE760", VA = "0x1883FF760", Slot = "42")]
	public List<(long, int)> IKAEELIJIKM(long AJGBLNMOGKC, int BJHBFGAEEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83FE460", Offset = "0x83FD460", VA = "0x1883FE460", Slot = "43")]
	public bool EAFCKMGLDMC(long HJPBKGBOCJN, [Out] IKOGMGLMEPJ NKGHDOPEJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84027B0", Offset = "0x84017B0", VA = "0x1884027B0", Slot = "44")]
	public bool NJOMGNFHHON(string GJELJGBKILI, [Out] IKOGMGLMEPJ NKGHDOPEJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x83FD010", Offset = "0x83FC010", VA = "0x1883FD010", Slot = "45")]
	public bool AGNOEDCLCFG(long HJPBKGBOCJN, Guid FIKGMCGPCHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83FE8E0", Offset = "0x83FD8E0", VA = "0x1883FE8E0", Slot = "46")]
	public IReadOnlyList<IKOGMGLMEPJ> FBNLCFIHKEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x83FEF50", Offset = "0x83FDF50", VA = "0x1883FEF50", Slot = "47")]
	public List<IKOGMGLMEPJ> GAOENJIALIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x83FD380", Offset = "0x83FC380", VA = "0x1883FD380", Slot = "48")]
	public IReadOnlyList<IKOGMGLMEPJ> AJKBBEKKEAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84006C0", Offset = "0x83FF6C0", VA = "0x1884006C0", Slot = "41")]
	public bool KAAHAKFFCOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8401220", Offset = "0x8400220", VA = "0x188401220", Slot = "49")]
	public IReadOnlyList<AFLLNPHGMEA> KILIDLPHNEO(long HJPBKGBOCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8401CA0", Offset = "0x8400CA0", VA = "0x188401CA0", Slot = "40")]
	[AsyncStateMachine(typeof(GMOFCAEKPJG))]
	public Task<HHHCCNLMPJL<bool, string>> LHLNAEEHHML(long CINEDGEJAIA, bool LMILHBBDLAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8402C30", Offset = "0x8401C30", VA = "0x188402C30", Slot = "54")]
	public bool PNNKNMMAAEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83FF2B0", Offset = "0x83FE2B0", VA = "0x1883FF2B0", Slot = "50")]
	public bool IFAJILCBLIL(string GJELJGBKILI, [Out] IReadOnlyList<AFLLNPHGMEA> OJFNPEMMIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83FDF50", Offset = "0x83FCF50", VA = "0x1883FDF50")]
	[AsyncStateMachine(typeof(GHPMKJKJPDD))]
	private Task<Dictionary<long, HKDBDNMIAHA>> DIEGDMMBFJO(Dictionary<long, int> NNFECOKKCKG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x83FEE00", Offset = "0x83FDE00", VA = "0x1883FEE00")]
	[AsyncStateMachine(typeof(EGPHNOJKKDC))]
	private Task<NPGEFAPAANA> FMMDOCNCBPM(Guid EDFMANFDKLC, int GFNDILIHOFK, [Optional] Guid GMLMFKDFDMA, [Optional] AIPAHMNCJKP LNAIOOFBFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8401E80", Offset = "0x8400E80", VA = "0x188401E80")]
	[AsyncStateMachine(typeof(EEOLDBBBFJL))]
	private Task<Dictionary<JEMODCHIONC, PDCJOEIFKPI>> LPONHHLMJBP(Dictionary<JEMODCHIONC, int> HMANMFMGNKA, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x83FEFE0", Offset = "0x83FDFE0", VA = "0x1883FEFE0")]
	[AsyncStateMachine(typeof(LAKKFMOHBEB))]
	private Task<List<PDCJOEIFKPI>> GCIPJKLJNEI(Dictionary<JEMODCHIONC, int> HMANMFMGNKA, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x83FFA40", Offset = "0x83FEA40", VA = "0x1883FFA40")]
	[AsyncStateMachine(typeof(GBECOFGPIGO))]
	private Task ILBGJDHJJKJ(long CINEDGEJAIA, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8400C30", Offset = "0x83FFC30", VA = "0x188400C30")]
	private Task KGNODACOBFF(JOEFAEBJKIB ODJGLJIHJOP, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8402B60", Offset = "0x8401B60", VA = "0x188402B60")]
	[AsyncStateMachine(typeof(DHBOACKOELO))]
	private Task PMFBJKOHKME(JOEFAEBJKIB ODJGLJIHJOP, CancellationToken DHOLFGMGIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8400930", Offset = "0x83FF930", VA = "0x188400930")]
	private void KDFLKGGGIPO(NAHKCOBJMOP PJMJKCNHNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8402FF0", Offset = "0x8401FF0", VA = "0x188402FF0")]
	[NNJDEPHNONO]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string FFCKGMEAPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x83FD730", Offset = "0x83FC730", VA = "0x1883FD730")]
	private void BCPHAHFBJKL(Guid EDFMANFDKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8403130", Offset = "0x8402130", VA = "0x188403130")]
	[NNJDEPHNONO]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid EDFMANFDKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83FE100", Offset = "0x83FD100", VA = "0x1883FE100")]
	[AsyncStateMachine(typeof(HGJMJECNAKB))]
	private Task<int> DMPEEKJJDMJ(AIPAHMNCJKP EKEPPODJHCN, Guid EDFMANFDKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8402E10", Offset = "0x8401E10", VA = "0x188402E10")]
	[NNJDEPHNONO]
	internal void RpcGetPlayerRoomInventoryCount(Guid DHFBDLBBCGN, Guid EDFMANFDKLC, OHMCHEMAHNO LBGDJDBPBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8402D90", Offset = "0x8401D90", VA = "0x188402D90")]
	[NNJDEPHNONO]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid DHFBDLBBCGN, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8400570", Offset = "0x83FF570", VA = "0x188400570")]
	[AsyncStateMachine(typeof(EGBBJLAAEOI))]
	private Task<NPGEFAPAANA> JOMAOKFHMPC(AIPAHMNCJKP EKEPPODJHCN, Guid EDFMANFDKLC, int GFNDILIHOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8402CC0", Offset = "0x8401CC0", VA = "0x188402CC0")]
	[NNJDEPHNONO]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid DHFBDLBBCGN, Guid EDFMANFDKLC, int GFNDILIHOFK, OHMCHEMAHNO LBGDJDBPBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8401790", Offset = "0x8400790", VA = "0x188401790")]
	private void KPMCFJJHLNC(AIPAHMNCJKP HICDMGMONDF, Guid DHFBDLBBCGN, MFEBDNMCCIM OBOOAPELMPF, long BFFKABGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84033E0", Offset = "0x84023E0", VA = "0x1884033E0")]
	[NNJDEPHNONO]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid DHFBDLBBCGN, int OBOOAPELMPF, long BFFKABGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84029F0", Offset = "0x84019F0", VA = "0x1884029F0")]
	private void PGOEPHCPLHF(bool LMILHBBDLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8403380", Offset = "0x8402380", VA = "0x188403380")]
	[NNJDEPHNONO]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool PPGPGGICELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x83FE690", Offset = "0x83FD690", VA = "0x1883FE690")]
	private void EJLAKIEBFIN(List<HKDBDNMIAHA> IPIBFNJJFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x84031D0", Offset = "0x84021D0", VA = "0x1884031D0")]
	[NNJDEPHNONO]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string CNCNDDABIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x83FD210", Offset = "0x83FC210", VA = "0x1883FD210")]
	private void AHOCCPCOHBP(long HJPBKGBOCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8403160", Offset = "0x8402160", VA = "0x188403160")]
	[NNJDEPHNONO]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long HJPBKGBOCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x83FC770", Offset = "0x83FB770", VA = "0x1883FC770")]
	private AFLLNPHGMEA AACFFEFGGHN(NAHKCOBJMOP PJMJKCNHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8400A50", Offset = "0x83FFA50", VA = "0x188400A50")]
	private List<IKOGMGLMEPJ> KFPHPEGBMOI(List<HKDBDNMIAHA> IPIBFNJJFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8401950", Offset = "0x8400950", VA = "0x188401950")]
	private List<IKOGMGLMEPJ> LFEEGCIOOLF(IEnumerable<HKDBDNMIAHA> IPIBFNJJFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x83FCBC0", Offset = "0x83FBBC0", VA = "0x1883FCBC0", Slot = "36")]
	public RoomInventoryItemProperties AFEDMFPHMNM(string ENOBBNAGNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x83FE4F0", Offset = "0x83FD4F0", VA = "0x1883FE4F0")]
	private AFLLNPHGMEA EFKMNFNNMOI(NAHKCOBJMOP PJMJKCNHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84028B0", Offset = "0x84018B0", VA = "0x1884028B0", Slot = "35")]
	public NAHKCOBJMOP PCDJIEIHDJI(AFLLNPHGMEA KEMGNFAOCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8401500", Offset = "0x8400500", VA = "0x188401500")]
	private IKOGMGLMEPJ KMCLBEHBADP(HKDBDNMIAHA PJMJKCNHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x83FE090", Offset = "0x83FD090", VA = "0x1883FE090")]
	private void DJGIMAANGAC(LLGFAIJGGMG JOGAAHCGFLK, int NELIFEPMEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x83FDEE0", Offset = "0x83FCEE0", VA = "0x1883FDEE0")]
	private void DGDKKOEKNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8401090", Offset = "0x8400090", VA = "0x188401090")]
	private Task KHCFMBEJLCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x83FD920", Offset = "0x83FC920", VA = "0x1883FD920")]
	private void BIAPDLALAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8401DC0", Offset = "0x8400DC0", VA = "0x188401DC0")]
	private void LIECAPJFAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8400060", Offset = "0x83FF060", VA = "0x188400060")]
	private void JDEEKIEABNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x83FCAB0", Offset = "0x83FBAB0", VA = "0x1883FCAB0")]
	[AsyncStateMachine(typeof(JDANILBELAE))]
	private Task ABOIMCDGOKL(AFLLNPHGMEA KJIDFPAIBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8402CA0", Offset = "0x8401CA0", VA = "0x188402CA0")]
	[CompilerGenerated]
	private void PPDLDEHDGOD(Task<TaskStatus> BGKKDAHMDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x83FE9B0", Offset = "0x83FD9B0", VA = "0x1883FE9B0")]
	[CompilerGenerated]
	private Task<MFEBDNMCCIM> FFGIHNGCAJG(CBNLOKOFNAK P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8402180", Offset = "0x8401180", VA = "0x188402180")]
	[CompilerGenerated]
	internal static Dictionary<JEMODCHIONC, PDCJOEIFKPI> NEDNBKHEBML(MFEBDNMCCIM OBOOAPELMPF, FNHAMFHKCBI P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GDIHHDPFIKL : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8409560", Offset = "0x8408560", VA = "0x188409560")]
	public GDIHHDPFIKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EDMJMKMNIOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNPECAJLKAL POJNILJFIMP();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GDIHHDPFIKL KIPEFEGLNCL();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LGGOAPIOJBB BFLGHNPCMJL();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HFKMDFJHPND : EDMJMKMNIOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x840A6C0", Offset = "0x84096C0", VA = "0x18840A6C0")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	[RecRoom.NoEngine.Common.Preserve]
	public HFKMDFJHPND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x840A730", Offset = "0x8409730", VA = "0x18840A730", Slot = "4")]
	public CNPECAJLKAL POJNILJFIMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x840A650", Offset = "0x8409650", VA = "0x18840A650", Slot = "5")]
	public GDIHHDPFIKL KIPEFEGLNCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x840A560", Offset = "0x8409560", VA = "0x18840A560", Slot = "6")]
	public LGGOAPIOJBB BFLGHNPCMJL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LGGOAPIOJBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, IKOGMGLMEPJ> PLDGMLEMENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly IKOGMGLMEPJ[] OKIEDGMIGJK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MPFBAAOCIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xC649F0", Offset = "0xC639F0", VA = "0x180C649F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MIDCEMGBGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x840E4B0", Offset = "0x840D4B0", VA = "0x18840E4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long PFNOGHODAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x840D3C0", Offset = "0x840C3C0", VA = "0x18840D3C0")]
	public void BMNCPLHPNKH(long CINEDGEJAIA, IEnumerable<IKOGMGLMEPJ> MKHFKNEFINC, bool LALFEHAICJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x840E300", Offset = "0x840D300", VA = "0x18840E300")]
	public IReadOnlyList<IKOGMGLMEPJ> OFBKNICCPAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
	public void GOADPLJFOCK(bool LMILHBBDLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x840DAD0", Offset = "0x840CAD0", VA = "0x18840DAD0")]
	public bool EAGLJDNNMCG(long HJPBKGBOCJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x840DD50", Offset = "0x840CD50", VA = "0x18840DD50")]
	public bool EEGGCPLAKJB(IKOGMGLMEPJ KJDIDKCHKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x840DFE0", Offset = "0x840CFE0", VA = "0x18840DFE0")]
	public bool MJGBGJLJLPK(List<IKOGMGLMEPJ> ECONCDOMIIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x840DA30", Offset = "0x840CA30", VA = "0x18840DA30")]
	public bool DPMLFCPFILK(long HJPBKGBOCJN, [Out] IKOGMGLMEPJ ALDJJJCLNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x840D880", Offset = "0x840C880", VA = "0x18840D880")]
	public bool CLNIALJLNJH(string NFHOBPDKIPM, [Out] IKOGMGLMEPJ ALDJJJCLNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x840DF10", Offset = "0x840CF10", VA = "0x18840DF10")]
	public List<IKOGMGLMEPJ> IGLLHOGCEJF(int OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x840DBB0", Offset = "0x840CBB0", VA = "0x18840DBB0")]
	public List<IKOGMGLMEPJ> EAJJCLPAJNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B189D0", Offset = "0x6B179D0", VA = "0x186B189D0")]
	public IKOGMGLMEPJ COBGFEKFPGD(int OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x840DCF0", Offset = "0x840CCF0", VA = "0x18840DCF0")]
	public IReadOnlyList<IKOGMGLMEPJ> ECAMMBKFKCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x840E510", Offset = "0x840D510", VA = "0x18840E510")]
	public LGGOAPIOJBB()
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
