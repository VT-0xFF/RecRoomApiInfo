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
		[Cpp2IlInjected.Address(RVA = "0x8468A90", Offset = "0x8467C90", VA = "0x188468A90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ONAPEBLPOAD : FDIGKCBGIBF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ELFPFOOMHBC KKIIAMJPHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class NKOMGCBKBHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, MMNJFNCIGGG> HOOMMBPHOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, MMNJFNCIGGG> IDPNDJBEONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? OGLOFJGBJMP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long NICOLNMBAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA0D670", Offset = "0xA0C870", VA = "0x180A0D670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MMNJFNCIGGG HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84663F0", Offset = "0x84655F0", VA = "0x1884663F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8465730", Offset = "0x8464930", VA = "0x188465730")]
	public void CPBGDOHCGFA(long LADMAADOIBG, IEnumerable<EIOOAIMJNAB> LGKLOLOBLKP, IEnumerable<EJGNEINAMOA> KFEBFHCIFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8466750", Offset = "0x8465950", VA = "0x188466750")]
	public bool MGPCOIBMENB(Guid MBINFGFHAKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8466AD0", Offset = "0x8465CD0", VA = "0x188466AD0")]
	public bool PKCJOLGDFLO(Guid MBINFGFHAKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8465500", Offset = "0x8464700", VA = "0x188465500")]
	public bool APBIKDGEKMH(EIOOAIMJNAB APMGEDIFDKM, [Out] EIOOAIMJNAB CPHCCCGFEHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84662B0", Offset = "0x84654B0", VA = "0x1884662B0")]
	public IEnumerable<MMNJFNCIGGG> JACGEEDPIMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84667B0", Offset = "0x84659B0", VA = "0x1884667B0")]
	public IEnumerable<EIOOAIMJNAB> NDMMFPAJFPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84653C0", Offset = "0x84645C0", VA = "0x1884653C0")]
	public IEnumerable<EJGNEINAMOA> ANILDPPFKEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84666A0", Offset = "0x84658A0", VA = "0x1884666A0")]
	public bool KPBCEBPDMLK(Guid MBINFGFHAKD, [Out] EIOOAIMJNAB BEJICGCJAJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8466000", Offset = "0x8465200", VA = "0x188466000")]
	public bool FMELJOGKIHN(string BDNEGHGBIAB, [Out] EIOOAIMJNAB BEJICGCJAJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84660A0", Offset = "0x84652A0", VA = "0x1884660A0")]
	public bool FOBJMDOLJFN(Guid MBINFGFHAKD, [Out] EJGNEINAMOA KHMIGDFADNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8466190", Offset = "0x8465390", VA = "0x188466190")]
	public bool GIJIBNBKLIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8466230", Offset = "0x8465430", VA = "0x188466230")]
	private bool IFEGFBAIBEL(EIOOAIMJNAB KMHJHNJDCNC, EIOOAIMJNAB MOJCFEGIIKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8466450", Offset = "0x8465650", VA = "0x188466450")]
	private void KKFPCACHFNL(Guid CMDFFDAPDIB, MMNJFNCIGGG FCHOOLAFIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8465DB0", Offset = "0x8464FB0", VA = "0x188465DB0")]
	private bool FIEBKPMDFLC(Guid CMDFFDAPDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8466300", Offset = "0x8465500", VA = "0x188466300")]
	private void KBGNLMCGPDE(EIOOAIMJNAB OJNGGHNMMIO, [Optional] EIOOAIMJNAB EONDPNMJBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84668F0", Offset = "0x8465AF0", VA = "0x1884668F0")]
	private bool OCGEINJBFGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8466150", Offset = "0x8465350", VA = "0x188466150")]
	private static bool FPJBPAHCODN(EIOOAIMJNAB LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8466AF0", Offset = "0x8465CF0", VA = "0x188466AF0")]
	public NKOMGCBKBHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ELFPFOOMHBC : HBPIDBGMIOJ, ELPLLLCHPFJ, IDisposable, OOECHMNDMCD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct KGHMBJDNMMN : IEquatable<KGHMBJDNMMN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long NICOLNMBAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid NHKKHFFNMLO;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x51CF270", Offset = "0x51CE470", VA = "0x1851CF270")]
		public KGHMBJDNMMN(long LADMAADOIBG, Guid MBINFGFHAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8463810", Offset = "0x8462A10", VA = "0x188463810", Slot = "4")]
		public bool Equals(KGHMBJDNMMN CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84636B0", Offset = "0x84628B0", VA = "0x1884636B0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8463910", Offset = "0x8462B10", VA = "0x188463910", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PBGMHOPMNPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<EIOOAIMJNAB, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public ELFPFOOMHBC <>4__this;

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
		public List<BPKDKDHKGBE> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<JHKDLPCNKII<ANJHCHGJELJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84682B0", Offset = "0x84674B0", VA = "0x1884682B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84687C0", Offset = "0x84679C0", VA = "0x1884687C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BHINJLNCFKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<EIOOAIMJNAB, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ELFPFOOMHBC <>4__this;

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
		private TaskAwaiter<JHKDLPCNKII<ANJHCHGJELJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8455340", Offset = "0x8454540", VA = "0x188455340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8455B90", Offset = "0x8454D90", VA = "0x188455B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MLJGBMFICMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private EIOOAIMJNAB <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private LBOHJNIEPDK <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<LBOHJNIEPDK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8464540", Offset = "0x8463740", VA = "0x188464540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8464D50", Offset = "0x8463F50", VA = "0x188464D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct JOCGACGJLKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BNFABCHNBCL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84632C0", Offset = "0x84624C0", VA = "0x1884632C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8463640", Offset = "0x8462840", VA = "0x188463640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NLGKJAFGLCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<JDIENCNKJJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BNFABCHNBCL recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<JDIENCNKJJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8466BD0", Offset = "0x8465DD0", VA = "0x188466BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8467030", Offset = "0x8466230", VA = "0x188467030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct APDIOOAJBJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<LBBBFBJIEAL, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private LBBBFBJIEAL <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8454E50", Offset = "0x8454050", VA = "0x188454E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84552D0", Offset = "0x84544D0", VA = "0x1884552D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JILJNFNIMPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<LBBBFBJIEAL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<DJNAMIFBMIO<LBBBFBJIEAL, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<LBOHJNIEPDK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8462640", Offset = "0x8461840", VA = "0x188462640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8463250", Offset = "0x8462450", VA = "0x188463250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JFJIKKEPPFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<LBOHJNIEPDK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84620B0", Offset = "0x84612B0", VA = "0x1884620B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84625D0", Offset = "0x84617D0", VA = "0x1884625D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DKOGLJIMKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, BPKDKDHKGBE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<JHKDLPCNKII<List<BPKDKDHKGBE>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x84575E0", Offset = "0x84567E0", VA = "0x1884575E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8458010", Offset = "0x8457210", VA = "0x188458010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct EHDKLIDCBDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public EJGNEINAMOA playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LCJGKIDCJOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<JDIENCNKJJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private EHDKLIDCBDC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BNFABCHNBCL awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<DLALDHKLAHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8463990", Offset = "0x8462B90", VA = "0x188463990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8463DE0", Offset = "0x8462FE0", VA = "0x188463DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct LHGFPCCBBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<KGHMBJDNMMN, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NDEFABPIOPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DLALDHKLAHH result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NDEFABPIOPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8465350", Offset = "0x8464550", VA = "0x188465350")]
		internal JJMDIKMKEKP AKPIBCOMDHG(KGHMBJDNMMN id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FDLDCKMGBMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<KGHMBJDNMMN, JJMDIKMKEKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<KGHMBJDNMMN, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private LHGFPCCBBOB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<JJMDIKMKEKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8460240", Offset = "0x845F440", VA = "0x188460240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8460CF0", Offset = "0x845FEF0", VA = "0x188460CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct CJDCFJLFDEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<JJMDIKMKEKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<KGHMBJDNMMN, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<JJMDIKMKEKP> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<JJMDIKMKEKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8455C00", Offset = "0x8454E00", VA = "0x188455C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8456B60", Offset = "0x8455D60", VA = "0x188456B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FEJBEEDHPEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<ANJHCHGJELJ>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<OOCKLHFLEDM>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<BPKDKDHKGBE>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<HDDHOCNHKCM> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<EIOOAIMJNAB> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<EJGNEINAMOA> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<LBBBFBJIEAL> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<ANJHCHGJELJ>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<OOCKLHFLEDM>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<BPKDKDHKGBE>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<HDDHOCNHKCM> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8460D60", Offset = "0x845FF60", VA = "0x188460D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8462010", Offset = "0x8461210", VA = "0x188462010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct LGABNKHKAOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8463E50", Offset = "0x8463050", VA = "0x188463E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x84644E0", Offset = "0x84636E0", VA = "0x1884644E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct EONNPPMHEJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BNFABCHNBCL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x845FCD0", Offset = "0x845EED0", VA = "0x18845FCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84601D0", Offset = "0x845F3D0", VA = "0x1884601D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct NCDDGJIEMMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<JDIENCNKJJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public BNFABCHNBCL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<JDIENCNKJJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8464DC0", Offset = "0x8463FC0", VA = "0x188464DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84652E0", Offset = "0x84644E0", VA = "0x1884652E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct DINNFAOMFHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public EIOOAIMJNAB itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public ELFPFOOMHBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<DJNAMIFBMIO<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8456BD0", Offset = "0x8455DD0", VA = "0x188456BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8457580", Offset = "0x8456780", VA = "0x188457580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan MIMBLPLMLCI;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float KGPMAFMFKLL = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float PIGFAJEELLM = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int LNDLKCCDNOD = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string BINBMCJIBKA = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string FCOLCBGONFG = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LHFEKJOLMKD JMCJPHAKKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FLPFNGKMBNB HMJKBFOCNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HOEFNFANDFP FBBJADIMNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KDODPOMDMLE GHHLEPBHEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NJLJCACGDMN GBBPKAPFBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ONAPEBLPOAD DIGMANIFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ABCAKKCKJPM BFEDBNCCFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly BPGMNAJBJBP KPJNKAKPMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly CDCCKKMKCIE OIIMMODDBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly NKOMGCBKBHH OPDEFCNIDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OCNOOKDJBMO DJIGDJHMFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly FMNIDMNLFBL ANNOEIOCGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource CEOCECGPAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CKMDLKMDMIA<KGHMBJDNMMN, JJMDIKMKEKP> JLDCHGGLNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CKMDLKMDMIA<long, BPKDKDHKGBE> HAMIHOMKKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BPOKLEGHBBP LPKJCMKKNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable AANCPLALJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task FACGBBPLOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource MJPAHIEDKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long MLILFLEHGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private KGGENHHCLLF JIHBCCKGMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x845A710", Offset = "0x8459910", VA = "0x18845A710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EPHHEFDKGKL JDGKKNNAGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA90A00", Offset = "0xA8FC00", VA = "0x180A90A00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA90A10", Offset = "0xA8FC10", VA = "0x180A90A10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KFOHPPMEALH<EIOOAIMJNAB> KNFEHBFDCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA909C0", Offset = "0xA8FBC0", VA = "0x180A909C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8FBD0", VA = "0x180A909D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KFOHPPMEALH<Guid> GGPOJBNDNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA90A30", Offset = "0xA8FC30", VA = "0x180A90A30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA909A0", Offset = "0xA8FBA0", VA = "0x180A909A0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LDFPLGIGGEB<EJGNEINAMOA, int> PHAIOAADAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA899D0", Offset = "0xA88BD0", VA = "0x180A899D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA84D50", Offset = "0xA83F50", VA = "0x180A84D50", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KFOHPPMEALH<LBBBFBJIEAL> EBEMKJFNCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA071D0", Offset = "0xA063D0", VA = "0x180A071D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA07200", Offset = "0xA06400", VA = "0x180A07200", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KFOHPPMEALH<long> JLDNAINLOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA89CD0", Offset = "0xA88ED0", VA = "0x180A89CD0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA85DA0", Offset = "0xA84FA0", VA = "0x180A85DA0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EPHHEFDKGKL LFNBBGAOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB1C0E0", Offset = "0xB1B2E0", VA = "0x180B1C0E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB1AC50", Offset = "0xB19E50", VA = "0x180B1AC50", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EPHHEFDKGKL POMEMAGLDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB17C70", Offset = "0xB16E70", VA = "0x180B17C70", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB0C560", Offset = "0xB0B760", VA = "0x180B0C560", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84595B0", Offset = "0x84587B0", VA = "0x1884595B0")]
	[MGCKGAIBEHC.MJEHAAIJGKF.HELJMGKJDLB]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x845F150", Offset = "0x845E350", VA = "0x18845F150")]
	[RecRoom.NoEngine.Common.Preserve]
	public ELFPFOOMHBC([NGLIAOPBMFM(null)] LHFEKJOLMKD JMCJPHAKKAK, [NGLIAOPBMFM(null)] FLPFNGKMBNB HMJKBFOCNFO, [NGLIAOPBMFM(null)] HOEFNFANDFP FBBJADIMNPL, [NGLIAOPBMFM(null)] KDODPOMDMLE GHHLEPBHEGH, [NGLIAOPBMFM(null)] FAMJNCFEMOB NNPMIHDHFPD, [NGLIAOPBMFM(null)] NJLJCACGDMN GBBPKAPFBDN, [NGLIAOPBMFM(null)] ONAPEBLPOAD DIGMANIFCMF, [NGLIAOPBMFM(null)] COLNEIINCGP IDIPLDILBKH, [NGLIAOPBMFM(null)] PAPDLOIGFFH HEONFEAKEFK, [NGLIAOPBMFM(null)] ABCAKKCKJPM BFEDBNCCFGA, [NGLIAOPBMFM(null)] BPGMNAJBJBP KPJNKAKPMPM, [NGLIAOPBMFM(null)] CDCCKKMKCIE OIIMMODDBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8459390", Offset = "0x8458590", VA = "0x188459390", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x845B3D0", Offset = "0x845A5D0", VA = "0x18845B3D0", Slot = "52")]
	public Task IJCDLNMDOMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8458E70", Offset = "0x8458070", VA = "0x188458E70", Slot = "20")]
	[AsyncStateMachine(typeof(PBGMHOPMNPM))]
	public Task<DJNAMIFBMIO<EIOOAIMJNAB, string>> BOCHEJKMOJN(Guid? PLGGGIJOHAJ, long LADMAADOIBG, string GBOCGPJOEEK, string AOOEEPGFGKK, string OFLIHBONFIK, RoomInventoryItemProperties GFKOIMIAEOH, byte GEPHAPCMEAA, int NEMIFEKMDAI, [Optional] List<long> GPIINABBHNG, [Optional] List<BPKDKDHKGBE> LPDHGMJEOAL, bool KMGMAGJBOOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x845CD40", Offset = "0x845BF40", VA = "0x18845CD40", Slot = "21")]
	[AsyncStateMachine(typeof(BHINJLNCFKN))]
	public Task<DJNAMIFBMIO<EIOOAIMJNAB, string>> MPNHGAOICNK(Guid MBINFGFHAKD, long LADMAADOIBG, [Optional] string GBOCGPJOEEK, [Optional] string AOOEEPGFGKK, [Optional] string OFLIHBONFIK, [Optional] List<long> GPIINABBHNG, [Optional] Dictionary<string, RoomInventoryTagClientProperties> LPDHGMJEOAL, [Optional] RoomInventoryItemProperties GFKOIMIAEOH, [Optional] byte? GEPHAPCMEAA, [Optional] int? NEMIFEKMDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x845CC10", Offset = "0x845BE10", VA = "0x18845CC10", Slot = "22")]
	[AsyncStateMachine(typeof(MLJGBMFICMG))]
	public Task<DJNAMIFBMIO<bool, string>> MNGCIKEGMED(Guid MBINFGFHAKD, long LADMAADOIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x845A5F0", Offset = "0x84597F0", VA = "0x18845A5F0", Slot = "23")]
	public IReadOnlyList<EIOOAIMJNAB> GHAAIGDHPBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8459980", Offset = "0x8458B80", VA = "0x188459980", Slot = "24")]
	public IReadOnlyList<EIOOAIMJNAB> ELOLAJNJIBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x845B680", Offset = "0x845A880", VA = "0x18845B680", Slot = "25")]
	public bool JDDDBNOBLDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x845BE50", Offset = "0x845B050", VA = "0x18845BE50", Slot = "26")]
	public bool KPBCEBPDMLK(Guid MBINFGFHAKD, [Out] EIOOAIMJNAB BEJICGCJAJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x845A250", Offset = "0x8459450", VA = "0x18845A250", Slot = "27")]
	public bool FMELJOGKIHN(string OFNKGHOBEIL, [Out] EIOOAIMJNAB BEJICGCJAJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x845B8A0", Offset = "0x845AAA0", VA = "0x18845B8A0", Slot = "28")]
	public IReadOnlyList<EJGNEINAMOA> JONDNPKKJIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x845A4C0", Offset = "0x84596C0", VA = "0x18845A4C0", Slot = "29")]
	public bool FOBJMDOLJFN(Guid MBINFGFHAKD, [Out] EJGNEINAMOA KHMIGDFADNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x845DB50", Offset = "0x845CD50", VA = "0x18845DB50", Slot = "30")]
	public long? PAHDAGLDBAL(Guid MBINFGFHAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x845C290", Offset = "0x845B490", VA = "0x18845C290", Slot = "51")]
	public void LKKIODBJKJO(IEnumerable<OOCKLHFLEDM> KFEBFHCIFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x845BF70", Offset = "0x845B170", VA = "0x18845BF70", Slot = "31")]
	[AsyncStateMachine(typeof(JOCGACGJLKD))]
	public Task<int> KPJGBDNABLI(BNFABCHNBCL NLIBDKKPKLB, Guid MBINFGFHAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x845A370", Offset = "0x8459570", VA = "0x18845A370", Slot = "32")]
	[AsyncStateMachine(typeof(NLGKJAFGLCL))]
	public Task<JDIENCNKJJE> FMMFINOHINO(BNFABCHNBCL GJFJKCMGAHM, Guid MBINFGFHAKD, int MIKCOPHLPJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x845C500", Offset = "0x845B700", VA = "0x18845C500", Slot = "33")]
	public string LLNMALOOMJJ(DLALDHKLAHH ACALKMLJJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x845BC50", Offset = "0x845AE50", VA = "0x18845BC50", Slot = "34")]
	public bool KFMOCNFLJHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x845DCE0", Offset = "0x845CEE0", VA = "0x18845DCE0", Slot = "38")]
	[AsyncStateMachine(typeof(APDIOOAJBJE))]
	public Task<DJNAMIFBMIO<LBBBFBJIEAL, string>> PDKBOLHMLHM(long CHPACKMLBKF, RoomInventoryTagClientProperties GFKOIMIAEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x845C9B0", Offset = "0x845BBB0", VA = "0x18845C9B0", Slot = "39")]
	[AsyncStateMachine(typeof(JILJNFNIMPO))]
	public Task<DJNAMIFBMIO<bool, string>> MCILMPICPMM(long CHPACKMLBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8459E30", Offset = "0x8459030", VA = "0x188459E30", Slot = "42")]
	public List<(long, int)> FCELPMEKOFK(long IFEAOAFMDCN, int KPOGCCODFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x845BA80", Offset = "0x845AC80", VA = "0x18845BA80", Slot = "43")]
	public bool KFKLJBENBFO(long CHPACKMLBKF, [Out] LBBBFBJIEAL JNMGPOGANPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8459030", Offset = "0x8458230", VA = "0x188459030", Slot = "44")]
	public bool BPMBHCJIOMJ(string CBGINMMNNCD, [Out] LBBBFBJIEAL JNMGPOGANPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8459C30", Offset = "0x8458E30", VA = "0x188459C30", Slot = "45")]
	public bool ENDFDHKDFJG(long CHPACKMLBKF, Guid DCJABKEMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8458960", Offset = "0x8457B60", VA = "0x188458960", Slot = "46")]
	public IReadOnlyList<LBBBFBJIEAL> BHPDAHGAFPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8458DE0", Offset = "0x8457FE0", VA = "0x188458DE0", Slot = "47")]
	public List<LBBBFBJIEAL> BNLDEJMHLIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8458A30", Offset = "0x8457C30", VA = "0x188458A30", Slot = "48")]
	public IReadOnlyList<LBBBFBJIEAL> BNEACMCMGDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x845D1D0", Offset = "0x845C3D0", VA = "0x18845D1D0", Slot = "41")]
	public bool OAAGALNKLNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x845C6D0", Offset = "0x845B8D0", VA = "0x18845C6D0", Slot = "49")]
	public IReadOnlyList<EIOOAIMJNAB> MCCHFAACPEO(long CHPACKMLBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x845BCC0", Offset = "0x845AEC0", VA = "0x18845BCC0", Slot = "40")]
	[AsyncStateMachine(typeof(JFJIKKEPPFP))]
	public Task<DJNAMIFBMIO<bool, string>> KNFNGOKFCAM(long LADMAADOIBG, bool JBPEFFIDDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x845A6A0", Offset = "0x84598A0", VA = "0x18845A6A0", Slot = "54")]
	public bool GJHGOPBMILI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x845DE10", Offset = "0x845D010", VA = "0x18845DE10", Slot = "50")]
	public bool PDOPEEGFEAH(string CBGINMMNNCD, [Out] IReadOnlyList<EIOOAIMJNAB> FGOIFEDLNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8459620", Offset = "0x8458820", VA = "0x188459620")]
	[AsyncStateMachine(typeof(DKOGLJIMKPE))]
	private Task<Dictionary<long, BPKDKDHKGBE>> EGMKOHNKIDN(Dictionary<long, int> FLJIMAANFGD, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x845D080", Offset = "0x845C280", VA = "0x18845D080")]
	[AsyncStateMachine(typeof(LCJGKIDCJOC))]
	private Task<JDIENCNKJJE> NHJIMMPEBPM(Guid MBINFGFHAKD, int MIKCOPHLPJK, [Optional] Guid EOLGLPCMHFA, [Optional] BNFABCHNBCL AMENMKKGIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x845BB10", Offset = "0x845AD10", VA = "0x18845BB10")]
	[AsyncStateMachine(typeof(FDLDCKMGBMJ))]
	private Task<Dictionary<KGHMBJDNMMN, JJMDIKMKEKP>> KFKMFDHFGAK(Dictionary<KGHMBJDNMMN, int> FFDCKDDOICO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x845D250", Offset = "0x845C450", VA = "0x18845D250")]
	[AsyncStateMachine(typeof(CJDCFJLFDEF))]
	private Task<List<JJMDIKMKEKP>> OBKBELFGNHL(Dictionary<KGHMBJDNMMN, int> FFDCKDDOICO, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x845D4A0", Offset = "0x845C6A0", VA = "0x18845D4A0")]
	[AsyncStateMachine(typeof(FEJBEEDHPEO))]
	private Task OJNEMEDBICD(long LADMAADOIBG, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x845D5D0", Offset = "0x845C7D0", VA = "0x18845D5D0")]
	private Task OKOFCDGDDEN(IMGOPGMMMDH CCEPNMMABPI, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x845E820", Offset = "0x845DA20", VA = "0x18845E820")]
	[AsyncStateMachine(typeof(LGABNKHKAOL))]
	private Task PMIMFMAOCIC(IMGOPGMMMDH CCEPNMMABPI, CancellationToken MILDDEIHGFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x845DA30", Offset = "0x845CC30", VA = "0x18845DA30")]
	private void ONMIEMKPJCG(ANJHCHGJELJ CIDHLIAPJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x845EC30", Offset = "0x845DE30", VA = "0x18845EC30")]
	[KCNCHMBHOPM]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string KHJCNAFFDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x845CF00", Offset = "0x845C100", VA = "0x18845CF00")]
	private void NABDFBHLEBH(Guid MBINFGFHAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x845ED70", Offset = "0x845DF70", VA = "0x18845ED70")]
	[KCNCHMBHOPM]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid MBINFGFHAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x845CAD0", Offset = "0x845BCD0", VA = "0x18845CAD0")]
	[AsyncStateMachine(typeof(EONNPPMHEJK))]
	private Task<int> MHKJCJBADMK(BNFABCHNBCL NLIBDKKPKLB, Guid MBINFGFHAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x845EA40", Offset = "0x845DC40", VA = "0x18845EA40")]
	[KCNCHMBHOPM]
	internal void RpcGetPlayerRoomInventoryCount(Guid GHIHMOONOIF, Guid MBINFGFHAKD, NIHFGKDLNDI ALLIBLOLGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x845E9C0", Offset = "0x845DBC0", VA = "0x18845E9C0")]
	[KCNCHMBHOPM]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid GHIHMOONOIF, int OCEHNHGKKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x845E2C0", Offset = "0x845D4C0", VA = "0x18845E2C0")]
	[AsyncStateMachine(typeof(NCDDGJIEMMO))]
	private Task<JDIENCNKJJE> PFIAKLDDJBO(BNFABCHNBCL NLIBDKKPKLB, Guid MBINFGFHAKD, int MIKCOPHLPJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x845E8F0", Offset = "0x845DAF0", VA = "0x18845E8F0")]
	[KCNCHMBHOPM]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid GHIHMOONOIF, Guid MBINFGFHAKD, int MIKCOPHLPJK, NIHFGKDLNDI ALLIBLOLGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84591D0", Offset = "0x84583D0", VA = "0x1884591D0")]
	private void DKPCCODFCNO(BNFABCHNBCL GJFJKCMGAHM, Guid GHIHMOONOIF, DLALDHKLAHH ACALKMLJJOL, long NJIMFNGHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x845F020", Offset = "0x845E220", VA = "0x18845F020")]
	[KCNCHMBHOPM]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid GHIHMOONOIF, int ACALKMLJJOL, long NJIMFNGHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x845E410", Offset = "0x845D610", VA = "0x18845E410")]
	private void PKJJKPNFCLP(bool JBPEFFIDDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x845EFC0", Offset = "0x845E1C0", VA = "0x18845EFC0")]
	[KCNCHMBHOPM]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool DBMDHKJICEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x845B780", Offset = "0x845A980", VA = "0x18845B780")]
	private void JNFLJPGJPHH(List<BPKDKDHKGBE> CCJCCBIAGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x845EE10", Offset = "0x845E010", VA = "0x18845EE10")]
	[KCNCHMBHOPM]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string HBIDNAEBGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x845C120", Offset = "0x845B320", VA = "0x18845C120")]
	private void LDCNOGFAOLF(long CHPACKMLBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x845EDA0", Offset = "0x845DFA0", VA = "0x18845EDA0")]
	[KCNCHMBHOPM]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long CHPACKMLBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8459760", Offset = "0x8458960", VA = "0x188459760")]
	private EIOOAIMJNAB EIHNGGDCEGK(ANJHCHGJELJ CIDHLIAPJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x845AE30", Offset = "0x845A030", VA = "0x18845AE30")]
	private List<LBBBFBJIEAL> IAHFNKEKBIB(List<BPKDKDHKGBE> CCJCCBIAGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x845B010", Offset = "0x845A210", VA = "0x18845B010")]
	private List<LBBBFBJIEAL> IFFPFGBDAIN(IEnumerable<BPKDKDHKGBE> CCJCCBIAGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x845A9E0", Offset = "0x8459BE0", VA = "0x18845A9E0", Slot = "36")]
	public RoomInventoryItemProperties HOMMHOBCIKG(string AAEEIPAIGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x845B470", Offset = "0x845A670", VA = "0x18845B470")]
	private EIOOAIMJNAB IKLPCNOBGFH(ANJHCHGJELJ CIDHLIAPJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x845A110", Offset = "0x8459310", VA = "0x18845A110", Slot = "35")]
	public ANJHCHGJELJ FGJAPDMNIBO(EIOOAIMJNAB AJIAPLKPDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x845E590", Offset = "0x845D790", VA = "0x18845E590")]
	private LBBBFBJIEAL PLMOBIPJPKF(BPKDKDHKGBE CIDHLIAPJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x845BDE0", Offset = "0x845AFE0", VA = "0x18845BDE0")]
	private void KNOFFBMLEKF(EJGNEINAMOA KHMIGDFADNL, int APNPEOFNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x845C0B0", Offset = "0x845B2B0", VA = "0x18845C0B0")]
	private void LAJDLBEODCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8458360", Offset = "0x8457560", VA = "0x188458360")]
	private Task AGDOGNNENDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x845B610", Offset = "0x845A810", VA = "0x18845B610")]
	private void INECCPEMEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x845A920", Offset = "0x8459B20", VA = "0x18845A920")]
	private void HHHJAAIIKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x845D390", Offset = "0x845C590", VA = "0x18845D390")]
	private void OGBKJKPBPHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84590C0", Offset = "0x84582C0", VA = "0x1884590C0")]
	[AsyncStateMachine(typeof(DINNFAOMFHF))]
	private Task BPNGNLACKMF(EIOOAIMJNAB ADHAJEAEIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84584F0", Offset = "0x84576F0", VA = "0x1884584F0")]
	[CompilerGenerated]
	private void AMMLDPNIJJA(Task<TaskStatus> MKOPIIJMBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8458510", Offset = "0x8457710", VA = "0x188458510")]
	[CompilerGenerated]
	private Task<DLALDHKLAHH> BDNNLBMJJJN(EHDKLIDCBDC P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x845A760", Offset = "0x8459960", VA = "0x18845A760")]
	[CompilerGenerated]
	internal static Dictionary<KGHMBJDNMMN, JJMDIKMKEKP> HCANGLPAMMH(DLALDHKLAHH ACALKMLJJOL, LHGFPCCBBOB P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FMNIDMNLFBL : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8462070", Offset = "0x8461270", VA = "0x188462070")]
	public FMNIDMNLFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PAPDLOIGFFH
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKOMGCBKBHH FJLLPBBFFIF();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FMNIDMNLFBL AHGGAAMBENN();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OCNOOKDJBMO GCDJAODMKNH();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EKCPGJFNJFB : PAPDLOIGFFH
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x84580F0", Offset = "0x84572F0", VA = "0x1884580F0")]
	[MGCKGAIBEHC.MJEHAAIJGKF.HELJMGKJDLB]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	[RecRoom.NoEngine.Common.Preserve]
	public EKCPGJFNJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8458160", Offset = "0x8457360", VA = "0x188458160", Slot = "4")]
	public NKOMGCBKBHH FJLLPBBFFIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8458080", Offset = "0x8457280", VA = "0x188458080", Slot = "5")]
	public FMNIDMNLFBL AHGGAAMBENN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8458270", Offset = "0x8457470", VA = "0x188458270", Slot = "6")]
	public OCNOOKDJBMO GCDJAODMKNH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OCNOOKDJBMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, LBBBFBJIEAL> HOPDDMHNLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly LBBBFBJIEAL[] ICAFHGKEIDM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DJCDFNCFEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA75190", Offset = "0xA74390", VA = "0x180A75190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA75210", Offset = "0xA74410", VA = "0x180A75210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IKDGGFIBIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8467A90", Offset = "0x8466C90", VA = "0x188467A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long KNKDBIFMBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA0D670", Offset = "0xA0C870", VA = "0x180A0D670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8467250", Offset = "0x8466450", VA = "0x188467250")]
	public void CPBGDOHCGFA(long LADMAADOIBG, IEnumerable<LBBBFBJIEAL> OECAECFBJIG, bool PKHLLBPOJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8467AF0", Offset = "0x8466CF0", VA = "0x188467AF0")]
	public IReadOnlyList<LBBBFBJIEAL> GJFJMCNFLND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xA75210", Offset = "0xA74410", VA = "0x180A75210")]
	public void OAIOFCCAMPG(bool JBPEFFIDDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8467CA0", Offset = "0x8466EA0", VA = "0x188467CA0")]
	public bool GOEHJOHMANM(long CHPACKMLBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8468030", Offset = "0x8467230", VA = "0x188468030")]
	public bool MPABEEGNIFA(LBBBFBJIEAL FKPBFHINAFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8467710", Offset = "0x8466910", VA = "0x188467710")]
	public bool DBJDKFFFMHM(List<LBBBFBJIEAL> IPFFFMHPGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8467F90", Offset = "0x8467190", VA = "0x188467F90")]
	public bool MJKIHLOBNMP(long CHPACKMLBKF, [Out] LBBBFBJIEAL BGOPKLLOOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x84670A0", Offset = "0x84662A0", VA = "0x1884670A0")]
	public bool AFHFHFLAJLO(string GBOCGPJOEEK, [Out] LBBBFBJIEAL BGOPKLLOOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8467D80", Offset = "0x8466F80", VA = "0x188467D80")]
	public List<LBBBFBJIEAL> JKNBFCKKONG(int CMDFFDAPDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8467E50", Offset = "0x8467050", VA = "0x188467E50")]
	public List<LBBBFBJIEAL> KEDKNJFAOMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6C90", Offset = "0x6AE5E90", VA = "0x186AE6C90")]
	public LBBBFBJIEAL JLBDHBNLIKK(int CMDFFDAPDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8467A30", Offset = "0x8466C30", VA = "0x188467A30")]
	public IReadOnlyList<LBBBFBJIEAL> DJDBFNDHNKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84681F0", Offset = "0x84673F0", VA = "0x1884681F0")]
	public OCNOOKDJBMO()
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
