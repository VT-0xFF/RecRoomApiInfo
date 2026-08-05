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
		[Cpp2IlInjected.Address(RVA = "0x89CF020", Offset = "0x89CE020", VA = "0x1889CF020", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GIHPKJFLMNF : OODGCKEAHFM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DDAJBNLFKKD EHEJOBFNAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class EGACFBKLMFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, IDCIPIFNELM> KMAAGLFOFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, IDCIPIFNELM> EFGIDLDJHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? KEAKHGKIEFE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA673D0", VA = "0x180A683D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IDCIPIFNELM LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89C8ED0", Offset = "0x89C7ED0", VA = "0x1889C8ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x89C84E0", Offset = "0x89C74E0", VA = "0x1889C84E0")]
	public void BFIGLCFHFAO(long DJJNJEHBMJK, IEnumerable<GIDLAGOMAOA> JDLMIECBFBP, IEnumerable<GAPEDJJHMDL> JGMGEFBIENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x89C8400", Offset = "0x89C7400", VA = "0x1889C8400")]
	public bool ABKIOACNKHJ(Guid PMKCJLJOEAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x89C9800", Offset = "0x89C8800", VA = "0x1889C9800")]
	public bool LKIPLGLLFFP(Guid PMKCJLJOEAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x89C8B50", Offset = "0x89C7B50", VA = "0x1889C8B50")]
	public bool DEKFNKFDOBH(GIDLAGOMAOA DCJKANBLCOH, [Out] GIDLAGOMAOA CJDBGJKNAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x89C9860", Offset = "0x89C8860", VA = "0x1889C9860")]
	public IEnumerable<IDCIPIFNELM> NELDHEHEKDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x89C8D80", Offset = "0x89C7D80", VA = "0x1889C8D80")]
	public IEnumerable<GIDLAGOMAOA> DFINJNGJEGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x89C8FE0", Offset = "0x89C7FE0", VA = "0x1889C8FE0")]
	public IEnumerable<GAPEDJJHMDL> FMFBJAFDCBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x89C98B0", Offset = "0x89C88B0", VA = "0x1889C98B0")]
	public bool OFHOPAHIBCM(Guid PMKCJLJOEAA, [Out] GIDLAGOMAOA KAJMBNDCKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x89C9420", Offset = "0x89C8420", VA = "0x1889C9420")]
	public bool LDCFLIJBEFL(string BKBGJCHBCFJ, [Out] GIDLAGOMAOA KAJMBNDCKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x89C8F30", Offset = "0x89C7F30", VA = "0x1889C8F30")]
	public bool ELFDLEKHAIB(Guid PMKCJLJOEAA, [Out] GAPEDJJHMDL HIJLNCPNMLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x89C9130", Offset = "0x89C8130", VA = "0x1889C9130")]
	public bool GHLHKENLGIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x89C8460", Offset = "0x89C7460", VA = "0x1889C8460")]
	private bool BEDKCIKNMKP(GIDLAGOMAOA MNBECLGJOEJ, GIDLAGOMAOA LEJOFEIMONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x89C94C0", Offset = "0x89C84C0", VA = "0x1889C94C0")]
	private void LFBHMMOFFFJ(Guid HLGKMAPOEBE, IDCIPIFNELM KKBKLFPPOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x89C91D0", Offset = "0x89C81D0", VA = "0x1889C91D0")]
	private bool KFKLFEMGEAD(Guid HLGKMAPOEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x89C9710", Offset = "0x89C8710", VA = "0x1889C9710")]
	private void LGNCBHHEFBG(GIDLAGOMAOA GJCIJIJGCKD, [Optional] GIDLAGOMAOA IAGCDMALGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x89C9960", Offset = "0x89C8960", VA = "0x1889C9960")]
	private bool PEMJOMNFFJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x89C9820", Offset = "0x89C8820", VA = "0x1889C9820")]
	private static bool MJEBIAFNDMP(GIDLAGOMAOA ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x89C9B40", Offset = "0x89C8B40", VA = "0x1889C9B40")]
	public EGACFBKLMFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DDAJBNLFKKD : IBHGACJGBBI, LEKELPMOABO, IDisposable, HOCNAJGAJIL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct BNPALCMCFPM : IEquatable<BNPALCMCFPM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long ANKPNEKDDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid OPEOEPOBABP;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5443E40", Offset = "0x5442E40", VA = "0x185443E40")]
		public BNPALCMCFPM(long DJJNJEHBMJK, Guid PMKCJLJOEAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x89BBE70", Offset = "0x89BAE70", VA = "0x1889BBE70", Slot = "4")]
		public bool Equals(BNPALCMCFPM EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x89BBF70", Offset = "0x89BAF70", VA = "0x1889BBF70", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x89BC0D0", Offset = "0x89BB0D0", VA = "0x1889BC0D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HAPMDKLEONA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<GIDLAGOMAOA, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DDAJBNLFKKD <>4__this;

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
		public List<JDFGKPEHOFB> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<FFOENOGPGNH<ICHKNBGHKHE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89CBA90", Offset = "0x89CAA90", VA = "0x1889CBA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89CBFA0", Offset = "0x89CAFA0", VA = "0x1889CBFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DAMBGBDFIIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<GIDLAGOMAOA, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DDAJBNLFKKD <>4__this;

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
		private TaskAwaiter<FFOENOGPGNH<ICHKNBGHKHE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89BE530", Offset = "0x89BD530", VA = "0x1889BE530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89BED80", Offset = "0x89BDD80", VA = "0x1889BED80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CLHEFGFGICF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private GIDLAGOMAOA <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private JFNAKFCGDAO <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<JFNAKFCGDAO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x89BDCB0", Offset = "0x89BCCB0", VA = "0x1889BDCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x89BE4C0", Offset = "0x89BD4C0", VA = "0x1889BE4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OCNOKNOHPKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public IALDHONKEJC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x89CE9B0", Offset = "0x89CD9B0", VA = "0x1889CE9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89CED30", Offset = "0x89CDD30", VA = "0x1889CED30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CJLNMFPJAIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<BHMOJPFPGLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public IALDHONKEJC recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<BHMOJPFPGLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x89BCDD0", Offset = "0x89BBDD0", VA = "0x1889BCDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x89BD230", Offset = "0x89BC230", VA = "0x1889BD230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DNLMIFIBGHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<BIMABKLOIIJ, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private BIMABKLOIIJ <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x89C6D00", Offset = "0x89C5D00", VA = "0x1889C6D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89C7180", Offset = "0x89C6180", VA = "0x1889C7180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CHLECHKFHNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<BIMABKLOIIJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<DAFIFKKNPFP<BIMABKLOIIJ, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<JFNAKFCGDAO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89BC150", Offset = "0x89BB150", VA = "0x1889BC150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89BCD60", Offset = "0x89BBD60", VA = "0x1889BCD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KLOGEKEMOJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<JFNAKFCGDAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89CCB90", Offset = "0x89CBB90", VA = "0x1889CCB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x89CD0B0", Offset = "0x89CC0B0", VA = "0x1889CD0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BHFBELJPJEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, JDFGKPEHOFB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<FFOENOGPGNH<List<JDFGKPEHOFB>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x89BB3D0", Offset = "0x89BA3D0", VA = "0x1889BB3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x89BBE00", Offset = "0x89BAE00", VA = "0x1889BBE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KCOMHBLDJNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public GAPEDJJHMDL playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ELNMCFFMBJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<BHMOJPFPGLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private KCOMHBLDJNK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IALDHONKEJC awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<CFKLLHHINAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x89C9C20", Offset = "0x89C8C20", VA = "0x1889C9C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x89CA070", Offset = "0x89C9070", VA = "0x1889CA070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KPJJCBBGCLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<BNPALCMCFPM, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class ACHKKINGADL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CFKLLHHINAN result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ACHKKINGADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x89BB360", Offset = "0x89BA360", VA = "0x1889BB360")]
		internal CNEGDLOLNAA AJDPHOCCBCB(BNPALCMCFPM id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct KIEOFCKNCJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<BNPALCMCFPM, CNEGDLOLNAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<BNPALCMCFPM, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private KPJJCBBGCLN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<CNEGDLOLNAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x89CC050", Offset = "0x89CB050", VA = "0x1889CC050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x89CCB20", Offset = "0x89CBB20", VA = "0x1889CCB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FMEOFCGDLHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<CNEGDLOLNAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<BNPALCMCFPM, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<CNEGDLOLNAA> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<CNEGDLOLNAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x89CA0E0", Offset = "0x89C90E0", VA = "0x1889CA0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89CB050", Offset = "0x89CA050", VA = "0x1889CB050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KPOMMJIABMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<ICHKNBGHKHE>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<OCOMMAHLAAD>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<JDFGKPEHOFB>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<KNGJOHJMJHO> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<GIDLAGOMAOA> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<GAPEDJJHMDL> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<BIMABKLOIIJ> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<ICHKNBGHKHE>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<OCOMMAHLAAD>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<JDFGKPEHOFB>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<KNGJOHJMJHO> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x89CD120", Offset = "0x89CC120", VA = "0x1889CD120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x89CE3E0", Offset = "0x89CD3E0", VA = "0x1889CE3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GBHEHLBLGIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x89CB0C0", Offset = "0x89CA0C0", VA = "0x1889CB0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x89CB750", Offset = "0x89CA750", VA = "0x1889CB750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct DFJEHMLKKGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public IALDHONKEJC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x89C67A0", Offset = "0x89C57A0", VA = "0x1889C67A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x89C6C90", Offset = "0x89C5C90", VA = "0x1889C6C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MPIBMPFGFIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<BHMOJPFPGLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IALDHONKEJC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<BHMOJPFPGLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x89CE440", Offset = "0x89CD440", VA = "0x1889CE440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x89CE940", Offset = "0x89CD940", VA = "0x1889CE940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct CJNPHPDGDNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public GIDLAGOMAOA itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public DDAJBNLFKKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<DAFIFKKNPFP<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x89BD2A0", Offset = "0x89BC2A0", VA = "0x1889BD2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x89BDC50", Offset = "0x89BCC50", VA = "0x1889BDC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan ACHJHEAPGML;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float EIELMNJHFNO = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float HDGDKODCBBH = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int MPHCENEGMMD = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string IBPDLAABDEA = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string JDAHNMDJDJP = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly POALNOBEJDK IAOPHLLHHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly LHDMMGAGJKF OCGLJHGAFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KEFAGJGJDKF NIGDHJCCAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KPPGAAACGAM JCOAFMOPGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JGOBEBEEPIE KOHFHJFDJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GIHPKJFLMNF KAJGGMOPNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MCIAFEMJFEE FEOBKHBKLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MGDAEHKIFBG MOHPLDKKIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AGHCEHMADPK NHMBDDKMJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly EGACFBKLMFK MMKLOMAGBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EDBDOJDFIKH LCJBIEDFBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly KHMGGLFHLNC LIODHLIEMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource OJHIADEBHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly BPIIIHBJLNH<BNPALCMCFPM, CNEGDLOLNAA> GKKFJFHFDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BPIIIHBJLNH<long, JDFGKPEHOFB> FMCLLMCCMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CGHAKILDGOB JHKEEFLLCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable IGIDAJLHJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task EMKHKBGEGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource PHDIADAIOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long JHCGLANPECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool MCHGOAKENIE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private PIFHPGJAAJP CONGFNFMFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x89C2180", Offset = "0x89C1180", VA = "0x1889C2180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LELKCPPPMEI CKBDLDLLNGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE6C9A0", Offset = "0xE6B9A0", VA = "0x180E6C9A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE6C9B0", Offset = "0xE6B9B0", VA = "0x180E6C9B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FHLIAIDPCMK<GIDLAGOMAOA> DOAOIIHBMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB12080", Offset = "0xB11080", VA = "0x180B12080", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB3D510", Offset = "0xB3C510", VA = "0x180B3D510", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FHLIAIDPCMK<Guid> HPDFJDIEAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB12240", Offset = "0xB11240", VA = "0x180B12240", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB12040", Offset = "0xB11040", VA = "0x180B12040", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MDNONHHFIOF<GAPEDJJHMDL, int> NKFFOBNMIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xADA040", Offset = "0xAD9040", VA = "0x180ADA040", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xADD6B0", Offset = "0xADC6B0", VA = "0x180ADD6B0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FHLIAIDPCMK<BIMABKLOIIJ> MIGNJIKDALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA62870", Offset = "0xA61870", VA = "0x180A62870", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA62850", Offset = "0xA61850", VA = "0x180A62850", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FHLIAIDPCMK<long> HOCHFLHOAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xADDD30", Offset = "0xADCD30", VA = "0x180ADDD30", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xADD080", Offset = "0xADC080", VA = "0x180ADD080", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LELKCPPPMEI DPMOLFLFPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xADDD20", Offset = "0xADCD20", VA = "0x180ADDD20", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xADD0A0", Offset = "0xADC0A0", VA = "0x180ADD0A0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LELKCPPPMEI HOLJAFDKNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAD8620", Offset = "0xAD7620", VA = "0x180AD8620", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAD87D0", Offset = "0xAD77D0", VA = "0x180AD87D0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x89BFF40", Offset = "0x89BEF40", VA = "0x1889BFF40")]
	[GOMLKAICHII.JENKOCGKLOO.LCLJJMFJJCN]
	internal static void EKOODCFGNGC(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x89C5C10", Offset = "0x89C4C10", VA = "0x1889C5C10")]
	[RecRoom.NoEngine.Common.Preserve]
	public DDAJBNLFKKD([KELEGLJPNHI(null)] POALNOBEJDK IAOPHLLHHJP, [KELEGLJPNHI(null)] LHDMMGAGJKF OCGLJHGAFHE, [KELEGLJPNHI(null)] KEFAGJGJDKF NIGDHJCCAFG, [KELEGLJPNHI(null)] KPPGAAACGAM JCOAFMOPGKM, [KELEGLJPNHI(null)] DDAPLCBMGDI JCLJEPFEBAL, [KELEGLJPNHI(null)] JGOBEBEEPIE KOHFHJFDJAE, [KELEGLJPNHI(null)] GIHPKJFLMNF KAJGGMOPNJP, [KELEGLJPNHI(null)] CKLJENKILGE BCMABIEFDCA, [KELEGLJPNHI(null)] BFJLNFGACDP KJFLMKGPLCF, [KELEGLJPNHI(null)] MCIAFEMJFEE FEOBKHBKLPO, [KELEGLJPNHI(null)] MGDAEHKIFBG MOHPLDKKIMB, [KELEGLJPNHI(null)] AGHCEHMADPK NHMBDDKMJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x89BFD00", Offset = "0x89BED00", VA = "0x1889BFD00", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x89C49B0", Offset = "0x89C39B0", VA = "0x1889C49B0", Slot = "52")]
	public Task ODJMNMCIFMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x89C51F0", Offset = "0x89C41F0", VA = "0x1889C51F0", Slot = "20")]
	[AsyncStateMachine(typeof(HAPMDKLEONA))]
	public Task<DAFIFKKNPFP<GIDLAGOMAOA, string>> PNMKEAOEGLH(Guid? FFGLKCFBAJA, long DJJNJEHBMJK, string HJLBILHBIIC, string GAPCMICLLJD, string IMHEEBEEIJH, RoomInventoryItemProperties KAEILAKIAKE, byte CBGBGGEBCJG, int AHIICABHHJO, [Optional] List<long> JOOOHKEHDKL, [Optional] List<JDFGKPEHOFB> KNKOMEIPJCO, bool BNOMIEFKLPG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x89C1DA0", Offset = "0x89C0DA0", VA = "0x1889C1DA0", Slot = "21")]
	[AsyncStateMachine(typeof(DAMBGBDFIIB))]
	public Task<DAFIFKKNPFP<GIDLAGOMAOA, string>> IPECFDAFPPG(Guid PMKCJLJOEAA, long DJJNJEHBMJK, [Optional] string HJLBILHBIIC, [Optional] string GAPCMICLLJD, [Optional] string IMHEEBEEIJH, [Optional] List<long> JOOOHKEHDKL, [Optional] Dictionary<string, RoomInventoryTagClientProperties> KNKOMEIPJCO, [Optional] RoomInventoryItemProperties KAEILAKIAKE, [Optional] byte? CBGBGGEBCJG, [Optional] int? AHIICABHHJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x89C0D60", Offset = "0x89BFD60", VA = "0x1889C0D60", Slot = "22")]
	[AsyncStateMachine(typeof(CLHEFGFGICF))]
	public Task<DAFIFKKNPFP<bool, string>> GJMMPNILPNN(Guid PMKCJLJOEAA, long DJJNJEHBMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x89BF570", Offset = "0x89BE570", VA = "0x1889BF570", Slot = "23")]
	public IReadOnlyList<GIDLAGOMAOA> CBKDADPCNIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x89C46E0", Offset = "0x89C36E0", VA = "0x1889C46E0", Slot = "24")]
	public IReadOnlyList<GIDLAGOMAOA> ODGFGNNNHNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x89C2390", Offset = "0x89C1390", VA = "0x1889C2390", Slot = "25")]
	public bool KJGODHINKOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x89C4A50", Offset = "0x89C3A50", VA = "0x1889C4A50", Slot = "26")]
	public bool OFHOPAHIBCM(Guid PMKCJLJOEAA, [Out] GIDLAGOMAOA KAJMBNDCKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x89C2F20", Offset = "0x89C1F20", VA = "0x1889C2F20", Slot = "27")]
	public bool LDCFLIJBEFL(string PLPKFDOFBAA, [Out] GIDLAGOMAOA KAJMBNDCKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x89C0900", Offset = "0x89BF900", VA = "0x1889C0900", Slot = "28")]
	public IReadOnlyList<GAPEDJJHMDL> GHIPOIEKIGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x89C00D0", Offset = "0x89BF0D0", VA = "0x1889C00D0", Slot = "29")]
	public bool ELFDLEKHAIB(Guid PMKCJLJOEAA, [Out] GAPEDJJHMDL HIJLNCPNMLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x89BF210", Offset = "0x89BE210", VA = "0x1889BF210", Slot = "30")]
	public long? AOHBBBJCJPI(Guid PMKCJLJOEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x89C2AB0", Offset = "0x89C1AB0", VA = "0x1889C2AB0", Slot = "51")]
	public void KPEACONLDAL(IEnumerable<OCOMMAHLAAD> JGMGEFBIENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x89C3A80", Offset = "0x89C2A80", VA = "0x1889C3A80", Slot = "31")]
	[AsyncStateMachine(typeof(OCNOKNOHPKF))]
	public Task<int> MFPJOBHDGOD(IALDHONKEJC MFOAOKBDIIM, Guid PMKCJLJOEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x89C5030", Offset = "0x89C4030", VA = "0x1889C5030", Slot = "32")]
	[AsyncStateMachine(typeof(CJLNMFPJAIB))]
	public Task<BHMOJPFPGLF> OOIEPDJNCDE(IALDHONKEJC NFJLNGFCOGD, Guid PMKCJLJOEAA, int KGCCFJCBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x89C1A70", Offset = "0x89C0A70", VA = "0x1889C1A70", Slot = "33")]
	public string ILGEGGCDOPG(CFKLLHHINAN BGOCMPMGKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x89C3170", Offset = "0x89C2170", VA = "0x1889C3170", Slot = "34")]
	public bool LGMGKPNGCCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x89BF620", Offset = "0x89BE620", VA = "0x1889BF620", Slot = "38")]
	[AsyncStateMachine(typeof(DNLMIFIBGHH))]
	public Task<DAFIFKKNPFP<BIMABKLOIIJ, string>> CJCPNEEPEEG(long PPBCCKPGGJD, RoomInventoryTagClientProperties KAEILAKIAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x89C07E0", Offset = "0x89BF7E0", VA = "0x1889C07E0", Slot = "39")]
	[AsyncStateMachine(typeof(CHLECHKFHNP))]
	public Task<DAFIFKKNPFP<bool, string>> GGBOJPODNEG(long PPBCCKPGGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x89BEF30", Offset = "0x89BDF30", VA = "0x1889BEF30", Slot = "42")]
	public List<(long, int)> AENEKIOGHCO(long KJOLKKHJIBM, int AKAOCPNGEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x89C0E90", Offset = "0x89BFE90", VA = "0x1889C0E90", Slot = "43")]
	public bool HKCOJHKMGNK(long PPBCCKPGGJD, [Out] BIMABKLOIIJ OANHEJOGAAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x89C1C40", Offset = "0x89C0C40", VA = "0x1889C1C40", Slot = "44")]
	public bool INHIMLOHPNL(string JAICJDINFJF, [Out] BIMABKLOIIJ OANHEJOGAAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89C2D20", Offset = "0x89C1D20", VA = "0x1889C2D20", Slot = "45")]
	public bool LCKOIFEPDAB(long PPBCCKPGGJD, Guid JDMEHGGKIMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x89C1CD0", Offset = "0x89C0CD0", VA = "0x1889C1CD0", Slot = "46")]
	public IReadOnlyList<BIMABKLOIIJ> IPDIGPGBIGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x89BF750", Offset = "0x89BE750", VA = "0x1889BF750", Slot = "47")]
	public List<BIMABKLOIIJ> DCLDKIICPCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x89BF7E0", Offset = "0x89BE7E0", VA = "0x1889BF7E0", Slot = "48")]
	public IReadOnlyList<BIMABKLOIIJ> DEEGFOJFKBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x89C4270", Offset = "0x89C3270", VA = "0x1889C4270", Slot = "41")]
	public bool NNLNPFOIHBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89C4B70", Offset = "0x89C3B70", VA = "0x1889C4B70", Slot = "49")]
	public IReadOnlyList<GIDLAGOMAOA> OFJAEBNEJOF(long PPBCCKPGGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x89C1950", Offset = "0x89C0950", VA = "0x1889C1950", Slot = "40")]
	[AsyncStateMachine(typeof(KLOGEKEMOJC))]
	public Task<DAFIFKKNPFP<bool, string>> IKLIMHGLNHF(long DJJNJEHBMJK, bool PHEOOAJAJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x89C0630", Offset = "0x89BF630", VA = "0x1889C0630", Slot = "54")]
	public bool GFJFLJHIHPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x89C3320", Offset = "0x89C2320", VA = "0x1889C3320", Slot = "50")]
	public bool LPPOKCMDBEB(string JAICJDINFJF, [Out] IReadOnlyList<GIDLAGOMAOA> FDDCKADJHOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x89BEDF0", Offset = "0x89BDDF0", VA = "0x1889BEDF0")]
	[AsyncStateMachine(typeof(BHFBELJPJEI))]
	private Task<Dictionary<long, JDFGKPEHOFB>> ADPIKHBLIBC(Dictionary<long, int> EJNMOKIGKGF, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x89C21D0", Offset = "0x89C11D0", VA = "0x1889C21D0")]
	[AsyncStateMachine(typeof(ELNMCFFMBJD))]
	private Task<BHMOJPFPGLF> KBMBEJGABBA(Guid PMKCJLJOEAA, int KGCCFJCBKGO, [Optional] Guid POBPKJBHDPL, [Optional] IALDHONKEJC DHDIOJHMDEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x89C37D0", Offset = "0x89C27D0", VA = "0x1889C37D0")]
	[AsyncStateMachine(typeof(KIEOFCKNCJH))]
	private Task<Dictionary<BNPALCMCFPM, CNEGDLOLNAA>> MENMNMCAHBH(Dictionary<BNPALCMCFPM, int> CFGAKNLCOIP, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x89C31E0", Offset = "0x89C21E0", VA = "0x1889C31E0")]
	[AsyncStateMachine(typeof(FMEOFCGDLHC))]
	private Task<List<CNEGDLOLNAA>> LOJIPMFJJAN(Dictionary<BNPALCMCFPM, int> CFGAKNLCOIP, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x89C3040", Offset = "0x89C2040", VA = "0x1889C3040")]
	[AsyncStateMachine(typeof(KPOMMJIABMO))]
	private Task LFAIKBCIENC(long DJJNJEHBMJK, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x89C2650", Offset = "0x89C1650", VA = "0x1889C2650")]
	private Task KOGJJCFJMIL(OCFEIKJADOO DELLHDJPKBE, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x89C0C90", Offset = "0x89BFC90", VA = "0x1889C0C90")]
	[AsyncStateMachine(typeof(GBHEHLBLGIK))]
	private Task GIJLPOCPOBE(OCFEIKJADOO DELLHDJPKBE, CancellationToken CIMHKOOFHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x89C3BC0", Offset = "0x89C2BC0", VA = "0x1889C3BC0")]
	private void MHDFFMLFAOK(ICHKNBGHKHE OFNBMHFAAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x89C56F0", Offset = "0x89C46F0", VA = "0x1889C56F0")]
	[DMLIGKAMJGD]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string CMMKJHCCHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x89C17D0", Offset = "0x89C07D0", VA = "0x1889C17D0")]
	private void IJEOAOCLCCG(Guid PMKCJLJOEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x89C5830", Offset = "0x89C4830", VA = "0x1889C5830")]
	[DMLIGKAMJGD]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid PMKCJLJOEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x89C06A0", Offset = "0x89BF6A0", VA = "0x1889C06A0")]
	[AsyncStateMachine(typeof(DFJEHMLKKGF))]
	private Task<int> GFOBMBJIEFN(IALDHONKEJC MFOAOKBDIIM, Guid PMKCJLJOEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x89C5500", Offset = "0x89C4500", VA = "0x1889C5500")]
	[DMLIGKAMJGD]
	internal void RpcGetPlayerRoomInventoryCount(Guid NGMLHKBJDHL, Guid PMKCJLJOEAA, CFLNMMPBLFL OGECODCBMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x89C5480", Offset = "0x89C4480", VA = "0x1889C5480")]
	[DMLIGKAMJGD]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid NGMLHKBJDHL, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x89C42F0", Offset = "0x89C32F0", VA = "0x1889C42F0")]
	[AsyncStateMachine(typeof(MPIBMPFGFIJ))]
	private Task<BHMOJPFPGLF> NPEOAANCEOM(IALDHONKEJC MFOAOKBDIIM, Guid PMKCJLJOEAA, int KGCCFJCBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x89C53B0", Offset = "0x89C43B0", VA = "0x1889C53B0")]
	[DMLIGKAMJGD]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid NGMLHKBJDHL, Guid PMKCJLJOEAA, int KGCCFJCBKGO, CFLNMMPBLFL OGECODCBMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x89C2490", Offset = "0x89C1490", VA = "0x1889C2490")]
	private void KLIDJCCCIHF(IALDHONKEJC NFJLNGFCOGD, Guid NGMLHKBJDHL, CFKLLHHINAN BGOCMPMGKKI, long OKIGNKMPCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x89C5AE0", Offset = "0x89C4AE0", VA = "0x1889C5AE0")]
	[DMLIGKAMJGD]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid NGMLHKBJDHL, int BGOCMPMGKKI, long OKIGNKMPCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x89C3910", Offset = "0x89C2910", VA = "0x1889C3910")]
	private void MFPFNHEHLIO(bool PHEOOAJAJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x89C5A80", Offset = "0x89C4A80", VA = "0x1889C5A80")]
	[DMLIGKAMJGD]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool GLHCAIKFIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x89BFFB0", Offset = "0x89BEFB0", VA = "0x1889BFFB0")]
	private void ELCHELCOJHO(List<JDFGKPEHOFB> LEJNFHGMFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x89C58D0", Offset = "0x89C48D0", VA = "0x1889C58D0")]
	[DMLIGKAMJGD]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string LOJFNFKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x89BFB90", Offset = "0x89BEB90", VA = "0x1889BFB90")]
	private void DFGEAGCIJBM(long PPBCCKPGGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x89C5860", Offset = "0x89C4860", VA = "0x1889C5860")]
	[DMLIGKAMJGD]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long PPBCCKPGGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x89C1F60", Offset = "0x89C0F60", VA = "0x1889C1F60")]
	private GIDLAGOMAOA JHCDOENNFGF(ICHKNBGHKHE OFNBMHFAAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x89C4E50", Offset = "0x89C3E50", VA = "0x1889C4E50")]
	private List<BIMABKLOIIJ> OFLFAKHOGKP(List<JDFGKPEHOFB> LEJNFHGMFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x89C0270", Offset = "0x89BF270", VA = "0x1889C0270")]
	private List<BIMABKLOIIJ> GFBJKGAHHEJ(IEnumerable<JDFGKPEHOFB> LEJNFHGMFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x89C12C0", Offset = "0x89C02C0", VA = "0x1889C12C0", Slot = "36")]
	public RoomInventoryItemProperties ICPGGLFKKNG(string MOODHFCOIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x89C0AF0", Offset = "0x89BFAF0", VA = "0x1889C0AF0")]
	private GIDLAGOMAOA GHPADKOOLOG(ICHKNBGHKHE OFNBMHFAAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x89C3CE0", Offset = "0x89C2CE0", VA = "0x1889C3CE0", Slot = "35")]
	public ICHKNBGHKHE MMGKMJKJOOF(GIDLAGOMAOA CLPNCMEJAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x89C0F20", Offset = "0x89BFF20", VA = "0x1889C0F20")]
	private BIMABKLOIIJ HMINJOLKDED(JDFGKPEHOFB OFNBMHFAAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x89C0200", Offset = "0x89BF200", VA = "0x1889C0200")]
	private void FCMBADFDBDA(GAPEDJJHMDL HIJLNCPNMLP, int EMPEMNAPOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x89C2320", Offset = "0x89C1320", VA = "0x1889C2320")]
	private void KCJGGDPAJHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x89C4550", Offset = "0x89C3550", VA = "0x1889C4550")]
	private Task OCOKIKMAOOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x89C5180", Offset = "0x89C4180", VA = "0x1889C5180")]
	private void PFFLGCJCEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x89C1710", Offset = "0x89C0710", VA = "0x1889C1710")]
	private void IINIJMEOJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x89C11B0", Offset = "0x89C01B0", VA = "0x1889C11B0")]
	private void HPPCDHBHABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x89C4440", Offset = "0x89C3440", VA = "0x1889C4440")]
	[AsyncStateMachine(typeof(CJNPHPDGDNG))]
	private Task OBGPCGPHHMF(GIDLAGOMAOA HNILENBPMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x89BFF20", Offset = "0x89BEF20", VA = "0x1889BFF20")]
	[CompilerGenerated]
	private void EFPEHNDGFNM(Task<TaskStatus> CAIMNCAIJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x89C3E20", Offset = "0x89C2E20", VA = "0x1889C3E20")]
	[CompilerGenerated]
	private Task<CFKLLHHINAN> NHOGLPNINCH(KCOMHBLDJNK P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x89BF3A0", Offset = "0x89BE3A0", VA = "0x1889BF3A0")]
	[CompilerGenerated]
	internal static Dictionary<BNPALCMCFPM, CNEGDLOLNAA> BPEAPGBDKPN(CFKLLHHINAN BGOCMPMGKKI, KPJJCBBGCLN P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KHMGGLFHLNC : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x89CC010", Offset = "0x89CB010", VA = "0x1889CC010")]
	public KHMGGLFHLNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BFJLNFGACDP
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGACFBKLMFK GPHJFNEIAJK();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KHMGGLFHLNC ANFNFKALMGD();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDBDOJDFIKH PBBJALELBCK();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GBJMKJMIOJB : BFJLNFGACDP
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x89CB820", Offset = "0x89CA820", VA = "0x1889CB820")]
	[GOMLKAICHII.JENKOCGKLOO.LCLJJMFJJCN]
	internal static void EKOODCFGNGC(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	[RecRoom.NoEngine.Common.Preserve]
	public GBJMKJMIOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x89CB890", Offset = "0x89CA890", VA = "0x1889CB890", Slot = "4")]
	public EGACFBKLMFK GPHJFNEIAJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x89CB7B0", Offset = "0x89CA7B0", VA = "0x1889CB7B0", Slot = "5")]
	public KHMGGLFHLNC ANFNFKALMGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x89CB9A0", Offset = "0x89CA9A0", VA = "0x1889CB9A0", Slot = "6")]
	public EDBDOJDFIKH PBBJALELBCK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EDBDOJDFIKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, BIMABKLOIIJ> KHGEJDBCGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly BIMABKLOIIJ[] JDDKBDAICOF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DOLCGKHAHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB3C210", Offset = "0xB3B210", VA = "0x180B3C210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OMBCNNJBFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x89C8130", Offset = "0x89C7130", VA = "0x1889C8130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long BCJEIBEFOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA673D0", VA = "0x180A683D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x89C71F0", Offset = "0x89C61F0", VA = "0x1889C71F0")]
	public void BFIGLCFHFAO(long DJJNJEHBMJK, IEnumerable<BIMABKLOIIJ> LHCAACJBMFJ, bool HIAONIEHDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x89C7B80", Offset = "0x89C6B80", VA = "0x1889C7B80")]
	public IReadOnlyList<BIMABKLOIIJ> DNCMCGIPFHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xB3C210", Offset = "0xB3B210", VA = "0x180B3C210")]
	public void EDBGNBOALBL(bool PHEOOAJAJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x89C8190", Offset = "0x89C7190", VA = "0x1889C8190")]
	public bool PLIEBNFHKHE(long PPBCCKPGGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x89C7DD0", Offset = "0x89C6DD0", VA = "0x1889C7DD0")]
	public bool EIKEKNAMPHN(BIMABKLOIIJ DKLBHDNKDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x89C76B0", Offset = "0x89C66B0", VA = "0x1889C76B0")]
	public bool CDDPAJHIGME(List<BIMABKLOIIJ> ACLFKLBIPOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x89C7D30", Offset = "0x89C6D30", VA = "0x1889C7D30")]
	public bool EFIACBNGOIO(long PPBCCKPGGJD, [Out] BIMABKLOIIJ MIMAHBNFICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x89C79D0", Offset = "0x89C69D0", VA = "0x1889C79D0")]
	public bool DGNJGMLJHLD(string HJLBILHBIIC, [Out] BIMABKLOIIJ MIMAHBNFICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x89C8270", Offset = "0x89C7270", VA = "0x1889C8270")]
	public List<BIMABKLOIIJ> PPLIOCPCADO(int HLGKMAPOEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x89C7F90", Offset = "0x89C6F90", VA = "0x1889C7F90")]
	public List<BIMABKLOIIJ> IALJICNPMGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9AB0", Offset = "0x6FA8AB0", VA = "0x186FA9AB0")]
	public BIMABKLOIIJ HFECPCCIFMN(int HLGKMAPOEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x89C80D0", Offset = "0x89C70D0", VA = "0x1889C80D0")]
	public IReadOnlyList<BIMABKLOIIJ> NOKHGENNLCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x89C8340", Offset = "0x89C7340", VA = "0x1889C8340")]
	public EDBDOJDFIKH()
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
