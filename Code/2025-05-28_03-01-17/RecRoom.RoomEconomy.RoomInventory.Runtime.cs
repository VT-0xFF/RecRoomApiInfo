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
		[Cpp2IlInjected.Address(RVA = "0x85A2D40", Offset = "0x85A1B40", VA = "0x1885A2D40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NEABIMKJAAE : IPGBBICMCKM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CBMJMIJCBCO KGNLPBCILLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class MNIKHEIHALG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, AABGKCINGEI> FFLBJEPINCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, AABGKCINGEI> IHHIOJCHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? APJKKFAGMHF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long FBNGFADIKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECF0", Offset = "0xA0DAF0", VA = "0x180A0ECF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AABGKCINGEI ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85A1630", Offset = "0x85A0430", VA = "0x1885A1630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85A0950", Offset = "0x859F750", VA = "0x1885A0950")]
	public void CMDAKLIPNLC(long CEACGIDOODJ, IEnumerable<CJJLLLNGFKM> KDAFNBKFFDO, IEnumerable<NKADEBCKGAC> LDOPKKGHONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x85A1370", Offset = "0x85A0170", VA = "0x1885A1370")]
	public bool ENBODJJFGGA(Guid PPGGGPECKLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x85A13D0", Offset = "0x85A01D0", VA = "0x1885A13D0")]
	public bool FKCGDELNEED(Guid PPGGGPECKLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85A1690", Offset = "0x85A0490", VA = "0x1885A1690")]
	public bool HNAFJCDNGAP(CJJLLLNGFKM NALFDHCDNAJ, [Out] CJJLLLNGFKM BIOCEMOEIJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85A15E0", Offset = "0x85A03E0", VA = "0x1885A15E0")]
	public IEnumerable<AABGKCINGEI> GLHKNEJBHLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85A13F0", Offset = "0x85A01F0", VA = "0x1885A13F0")]
	public IEnumerable<CJJLLLNGFKM> FKNGFEAJDIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85A18C0", Offset = "0x85A06C0", VA = "0x1885A18C0")]
	public IEnumerable<NKADEBCKGAC> LFEIIPNLAEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85A12C0", Offset = "0x85A00C0", VA = "0x1885A12C0")]
	public bool EAEPLGHIDHL(Guid PPGGGPECKLI, [Out] CJJLLLNGFKM DPCLFPFFHIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x85A1220", Offset = "0x85A0020", VA = "0x1885A1220")]
	public bool DMFKIMOAPOO(string PJIBPHLHEFJ, [Out] CJJLLLNGFKM DPCLFPFFHIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85A1F00", Offset = "0x85A0D00", VA = "0x1885A1F00")]
	public bool PKNOCNPALIP(Guid PPGGGPECKLI, [Out] NKADEBCKGAC GBCBLMPEJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85A1540", Offset = "0x85A0340", VA = "0x1885A1540")]
	public bool GCIFHEJHCDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85A1CA0", Offset = "0x85A0AA0", VA = "0x1885A1CA0")]
	private bool NMPGOKPLLMI(CJJLLLNGFKM OHCLPCBAJPD, CJJLLLNGFKM JPPNJDBELKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85A0FD0", Offset = "0x859FDD0", VA = "0x1885A0FD0")]
	private void DKNHFDMHNDB(Guid GLAOLHCPLLG, AABGKCINGEI OKEGDFKMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85A1A10", Offset = "0x85A0810", VA = "0x1885A1A10")]
	private bool NDKECAFFBKF(Guid GLAOLHCPLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85A0860", Offset = "0x859F660", VA = "0x1885A0860")]
	private void BLFAMGBHFKB(CJJLLLNGFKM EKJLDINBPOL, [Optional] CJJLLLNGFKM GKIKCNODCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85A1D20", Offset = "0x85A0B20", VA = "0x1885A1D20")]
	private bool OMNOAODOHKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85A1C60", Offset = "0x85A0A60", VA = "0x1885A1C60")]
	private static bool NEGOADPNOMF(CJJLLLNGFKM HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85A1FB0", Offset = "0x85A0DB0", VA = "0x1885A1FB0")]
	public MNIKHEIHALG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CBMJMIJCBCO : KKOCNIAPAFM, MLBFKJKNKNH, IDisposable, MCNHCPEHJEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct LFCLNIIEKIP : IEquatable<LFCLNIIEKIP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long FBNGFADIKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid ABAFIKBLBBK;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x513F6A0", Offset = "0x513E4A0", VA = "0x18513F6A0")]
		public LFCLNIIEKIP(long CEACGIDOODJ, Guid PPGGGPECKLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85A0580", Offset = "0x859F380", VA = "0x1885A0580", Slot = "4")]
		public bool Equals(LFCLNIIEKIP HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85A0680", Offset = "0x859F480", VA = "0x1885A0680", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85A07E0", Offset = "0x859F5E0", VA = "0x1885A07E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DENGAGBELOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<CJJLLLNGFKM, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CBMJMIJCBCO <>4__this;

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
		public List<EHEPKBOFNKL> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<HADGKGMEIJF<MAHLFJHHAOK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x859B280", Offset = "0x859A080", VA = "0x18859B280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x859B790", Offset = "0x859A590", VA = "0x18859B790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KCGALCEBHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<CJJLLLNGFKM, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public CBMJMIJCBCO <>4__this;

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
		private TaskAwaiter<HADGKGMEIJF<MAHLFJHHAOK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x859EAB0", Offset = "0x859D8B0", VA = "0x18859EAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x859F300", Offset = "0x859E100", VA = "0x18859F300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BFDKBEOAAFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CJJLLLNGFKM <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private ONAJOACHAJH <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<ONAJOACHAJH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8591F20", Offset = "0x8590D20", VA = "0x188591F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8592730", Offset = "0x8591530", VA = "0x188592730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IIPGFOILBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AHNIMKBJLEJ player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x859E6C0", Offset = "0x859D4C0", VA = "0x18859E6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x859EA40", Offset = "0x859D840", VA = "0x18859EA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GMPCFOAOJHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<MPDOEGHIBFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AHNIMKBJLEJ recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<MPDOEGHIBFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x859D530", Offset = "0x859C330", VA = "0x18859D530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x859D990", Offset = "0x859C790", VA = "0x18859D990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct AKCLOLCLMFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<HMNCEMLKPAE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private HMNCEMLKPAE <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x858F210", Offset = "0x858E010", VA = "0x18858F210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x858F690", Offset = "0x858E490", VA = "0x18858F690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HNCMFLHNDGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<HMNCEMLKPAE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<JKEBLLKKBOM<HMNCEMLKPAE, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<ONAJOACHAJH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x859DA00", Offset = "0x859C800", VA = "0x18859DA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x859E610", Offset = "0x859D410", VA = "0x18859E610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BBGGMKEDKJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<ONAJOACHAJH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85909B0", Offset = "0x858F7B0", VA = "0x1885909B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8590ED0", Offset = "0x858FCD0", VA = "0x188590ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OBHFBFHILMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, EHEPKBOFNKL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<HADGKGMEIJF<List<EHEPKBOFNKL>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x85A2090", Offset = "0x85A0E90", VA = "0x1885A2090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85A2A50", Offset = "0x85A1850", VA = "0x1885A2A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GONPFJJOPPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NKADEBCKGAC playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CFHENBPBNGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<MPDOEGHIBFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private GONPFJJOPPD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AHNIMKBJLEJ awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<LHABPDEBEFJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x859A0D0", Offset = "0x8598ED0", VA = "0x18859A0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x859A520", Offset = "0x8599320", VA = "0x18859A520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct BNBCOANJCME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<LFCLNIIEKIP, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class ADAGMODNJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LHABPDEBEFJ result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ADAGMODNJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x858F1A0", Offset = "0x858DFA0", VA = "0x18858F1A0")]
		internal AKPINJIPEKK JAPNPKGDFEC(LFCLNIIEKIP id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct GEAKOECKACP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<LFCLNIIEKIP, AKPINJIPEKK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<LFCLNIIEKIP, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private BNBCOANJCME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<AKPINJIPEKK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x859C480", Offset = "0x859B280", VA = "0x18859C480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x859CF50", Offset = "0x859BD50", VA = "0x18859CF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct BBLNFKKMIKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<AKPINJIPEKK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<LFCLNIIEKIP, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<AKPINJIPEKK> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<AKPINJIPEKK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8590F40", Offset = "0x858FD40", VA = "0x188590F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8591EB0", Offset = "0x8590CB0", VA = "0x188591EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct AKHMMFMBLGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<MAHLFJHHAOK>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<GLNKJILIANA>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<EHEPKBOFNKL>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<LJHIFNOOPIO> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<CJJLLLNGFKM> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<NKADEBCKGAC> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<HMNCEMLKPAE> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<MAHLFJHHAOK>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<GLNKJILIANA>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<EHEPKBOFNKL>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<LJHIFNOOPIO> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x858F700", Offset = "0x858E500", VA = "0x18858F700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8590950", Offset = "0x858F750", VA = "0x188590950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct FHELIELFEBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x859BD90", Offset = "0x859AB90", VA = "0x18859BD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x859C420", Offset = "0x859B220", VA = "0x18859C420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct GHDEIABPDJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AHNIMKBJLEJ player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x859CFC0", Offset = "0x859BDC0", VA = "0x18859CFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x859D4C0", Offset = "0x859C2C0", VA = "0x18859D4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct EIKPHLILFEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<MPDOEGHIBFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AHNIMKBJLEJ player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<MPDOEGHIBFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x859B800", Offset = "0x859A600", VA = "0x18859B800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x859BD20", Offset = "0x859AB20", VA = "0x18859BD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct DCFGLHMKDKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CJJLLLNGFKM itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CBMJMIJCBCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<JKEBLLKKBOM<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x859A870", Offset = "0x8599670", VA = "0x18859A870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x859B220", Offset = "0x859A020", VA = "0x18859B220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan HKHDELGHMDH;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float JNCIMOHPJOD = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float MPFKMOEBGJD = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int PNAGPKONHNB = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string FAJLFGBAGME = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string BNCHKLOKBDJ = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly INFDDCICJNJ KIDGNGGKKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly EJNBEGODCBL JDHKGCGIABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DKJNCOOLOJH NGKNMDCAAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly ONFJPPIHNJO HCEJNPOEFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AHHEJMOLFFP IGKNFEPILID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly NEABIMKJAAE DGMELIHEKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MEHFIDNJION MOANACPPHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FKDMMCBELEM EOJCCLBIIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly IKDBDMPLEPB LIMNPEHOIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MNIKHEIHALG OALJEFABMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LBOBFMJNMFF FENFABDJHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IGDCPMIPIIC JOGFAAPJNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource AFBAFKKKPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly PLJMKFFPMLI<LFCLNIIEKIP, AKPINJIPEKK> GAHMBKLMHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly PLJMKFFPMLI<long, EHEPKBOFNKL> HONAKEAMBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LNMADGNMNID IMFANINLKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable FIHGJIGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task IJMLIBHJDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource BLEFEJPFADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long MONFDBKJJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private BEDAPPGPKDN EDMNNKNAJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85975B0", Offset = "0x85963B0", VA = "0x1885975B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LLEAAEBCCKF KMHLIGPBLMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD6F900", Offset = "0xD6E700", VA = "0x180D6F900", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD6F910", Offset = "0xD6E710", VA = "0x180D6F910", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IMAAKJGDPMH<CJJLLLNGFKM> JGDAJIILBBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xCFC260", Offset = "0xCFB060", VA = "0x180CFC260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11CB5E0", Offset = "0x11CA3E0", VA = "0x1811CB5E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IMAAKJGDPMH<Guid> JMGPKOOEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xCE6EA0", Offset = "0xCE5CA0", VA = "0x180CE6EA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xDA0210", Offset = "0xD9F010", VA = "0x180DA0210", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DPJKFCBILHL<NKADEBCKGAC, int> PLBLLINCFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xABCDE0", Offset = "0xABBBE0", VA = "0x180ABCDE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xABCDC0", Offset = "0xABBBC0", VA = "0x180ABCDC0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IMAAKJGDPMH<HMNCEMLKPAE> IALNOCHDAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA0BBF0", Offset = "0xA0A9F0", VA = "0x180A0BBF0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA0BBD0", Offset = "0xA0A9D0", VA = "0x180A0BBD0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IMAAKJGDPMH<long> FDHOMNHKBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAE22D0", Offset = "0xAE10D0", VA = "0x180AE22D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xBCF790", Offset = "0xBCE590", VA = "0x180BCF790", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LLEAAEBCCKF JOAHNBCKFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xADDA20", Offset = "0xADC820", VA = "0x180ADDA20", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xADC740", Offset = "0xADB540", VA = "0x180ADC740", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LLEAAEBCCKF AHICIOHGDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAC1A00", Offset = "0xAC0800", VA = "0x180AC1A00", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B80", Offset = "0xABF980", VA = "0x180AC0B80", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8593000", Offset = "0x8591E00", VA = "0x188593000")]
	[ENKLKENGHAE.GHBFDECCGMJ.HGNDHHKALNH]
	internal static void BAEPNPABNEB(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8599540", Offset = "0x8598340", VA = "0x188599540")]
	[RecRoom.NoEngine.Common.Preserve]
	public CBMJMIJCBCO([LCNEJNNIOGA(null)] INFDDCICJNJ KIDGNGGKKGE, [LCNEJNNIOGA(null)] EJNBEGODCBL JDHKGCGIABD, [LCNEJNNIOGA(null)] DKJNCOOLOJH NGKNMDCAAKC, [LCNEJNNIOGA(null)] ONFJPPIHNJO HCEJNPOEFBG, [LCNEJNNIOGA(null)] DMPDKJKKDKL JAAILIKGFON, [LCNEJNNIOGA(null)] AHHEJMOLFFP IGKNFEPILID, [LCNEJNNIOGA(null)] NEABIMKJAAE DGMELIHEKAD, [LCNEJNNIOGA(null)] BLCMGFNDLHA LDDEDLMKPMN, [LCNEJNNIOGA(null)] PEDGCKJDJFO PMBGDNLNMPP, [LCNEJNNIOGA(null)] MEHFIDNJION MOANACPPHLN, [LCNEJNNIOGA(null)] FKDMMCBELEM EOJCCLBIIAM, [LCNEJNNIOGA(null)] IKDBDMPLEPB LIMNPEHOIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8594840", Offset = "0x8593640", VA = "0x188594840", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85932F0", Offset = "0x85920F0", VA = "0x1885932F0", Slot = "52")]
	public Task CIIHCCCOHLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85982B0", Offset = "0x85970B0", VA = "0x1885982B0", Slot = "20")]
	[AsyncStateMachine(typeof(DENGAGBELOH))]
	public Task<JKEBLLKKBOM<CJJLLLNGFKM, string>> OFLKOGIBONK(Guid? AGGEDCBPBDE, long CEACGIDOODJ, string IHGFMOMOADA, string CDDMBEEGKND, string DBCDJMCMAJM, RoomInventoryItemProperties ADPBPEDNFCM, byte HMDNNMIJNJJ, int DEJLIDMJHPI, [Optional] List<long> LPODAADEFKK, [Optional] List<EHEPKBOFNKL> NKOOIEHKAOG, bool KCOAHFLFPNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8593590", Offset = "0x8592390", VA = "0x188593590", Slot = "21")]
	[AsyncStateMachine(typeof(KCGALCEBHDF))]
	public Task<JKEBLLKKBOM<CJJLLLNGFKM, string>> CLBPOPLDFBG(Guid PPGGGPECKLI, long CEACGIDOODJ, [Optional] string IHGFMOMOADA, [Optional] string CDDMBEEGKND, [Optional] string DBCDJMCMAJM, [Optional] List<long> LPODAADEFKK, [Optional] Dictionary<string, RoomInventoryTagClientProperties> NKOOIEHKAOG, [Optional] RoomInventoryItemProperties ADPBPEDNFCM, [Optional] byte? HMDNNMIJNJJ, [Optional] int? DEJLIDMJHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x85931C0", Offset = "0x8591FC0", VA = "0x1885931C0", Slot = "22")]
	[AsyncStateMachine(typeof(BFDKBEOAAFC))]
	public Task<JKEBLLKKBOM<bool, string>> BCEMBOKMDJH(Guid PPGGGPECKLI, long CEACGIDOODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8596950", Offset = "0x8595750", VA = "0x188596950", Slot = "23")]
	public IReadOnlyList<CJJLLLNGFKM> JCHAIJFOHPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8594030", Offset = "0x8592E30", VA = "0x188594030", Slot = "24")]
	public IReadOnlyList<CJJLLLNGFKM> DJJJKGHOLHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8596DA0", Offset = "0x8595BA0", VA = "0x188596DA0", Slot = "25")]
	public bool LCCNCLLJLJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8594A60", Offset = "0x8593860", VA = "0x188594A60", Slot = "26")]
	public bool EAEPLGHIDHL(Guid PPGGGPECKLI, [Out] CJJLLLNGFKM DPCLFPFFHIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x85945F0", Offset = "0x85933F0", VA = "0x1885945F0", Slot = "27")]
	public bool DMFKIMOAPOO(string GDFFGOMDOJI, [Out] CJJLLLNGFKM DPCLFPFFHIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8598960", Offset = "0x8597760", VA = "0x188598960", Slot = "28")]
	public IReadOnlyList<NKADEBCKGAC> PLNHACIHMDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8598830", Offset = "0x8597630", VA = "0x188598830", Slot = "29")]
	public bool PKNOCNPALIP(Guid PPGGGPECKLI, [Out] NKADEBCKGAC GBCBLMPEJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8594FC0", Offset = "0x8593DC0", VA = "0x188594FC0", Slot = "30")]
	public long? EJFLLPMJIKP(Guid PPGGGPECKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x85961C0", Offset = "0x8594FC0", VA = "0x1885961C0", Slot = "51")]
	public void HKKFGCNBLDN(IEnumerable<GLNKJILIANA> LDOPKKGHONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8596A00", Offset = "0x8595800", VA = "0x188596A00", Slot = "31")]
	[AsyncStateMachine(typeof(IIPGFOILBAJ))]
	public Task<int> JFCCNPCOJBL(AHNIMKBJLEJ ENPELEHFGFF, Guid PPGGGPECKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8597F50", Offset = "0x8596D50", VA = "0x188597F50", Slot = "32")]
	[AsyncStateMachine(typeof(GMPCFOAOJHL))]
	public Task<MPDOEGHIBFA> NKBFHHOGIPL(AHNIMKBJLEJ JKLBOHMJEDF, Guid PPGGGPECKLI, int CGKKBLKIKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8597C60", Offset = "0x8596A60", VA = "0x188597C60", Slot = "33")]
	public string NHIMLLEIKBN(LHABPDEBEFJ BPINCJLADGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85960C0", Offset = "0x8594EC0", VA = "0x1885960C0", Slot = "34")]
	public bool GPCOFMKGLJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8596B40", Offset = "0x8595940", VA = "0x188596B40", Slot = "38")]
	[AsyncStateMachine(typeof(AKCLOLCLMFN))]
	public Task<JKEBLLKKBOM<HMNCEMLKPAE, string>> JLFMIIPMLBI(long NFFIHLEPONH, RoomInventoryTagClientProperties ADPBPEDNFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8592C00", Offset = "0x8591A00", VA = "0x188592C00", Slot = "39")]
	[AsyncStateMachine(typeof(HNCMFLHNDGC))]
	public Task<JKEBLLKKBOM<bool, string>> AILNIOJPBNG(long NFFIHLEPONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85927A0", Offset = "0x85915A0", VA = "0x1885927A0", Slot = "42")]
	public List<(long, int)> AGKJMMJPLNP(long GIBAHGHGMOP, int OEJMGPHJBIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8597AC0", Offset = "0x85968C0", VA = "0x188597AC0", Slot = "43")]
	public bool NFBCMLEHOGN(long NFFIHLEPONH, [Out] HMNCEMLKPAE NFNCFFGLNDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8595E60", Offset = "0x8594C60", VA = "0x188595E60", Slot = "44")]
	public bool GNGHENMCGJA(string EONPHNIJJBM, [Out] HMNCEMLKPAE NFNCFFGLNDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8593390", Offset = "0x8592190", VA = "0x188593390", Slot = "45")]
	public bool CJMFCGBOGOP(long NFFIHLEPONH, Guid IKEAOGJBFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8595370", Offset = "0x8594170", VA = "0x188595370", Slot = "46")]
	public IReadOnlyList<HMNCEMLKPAE> GHMDDGLLHDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8596130", Offset = "0x8594F30", VA = "0x188596130", Slot = "47")]
	public List<HMNCEMLKPAE> GPJOPNALAKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8597080", Offset = "0x8595E80", VA = "0x188597080", Slot = "48")]
	public IReadOnlyList<HMNCEMLKPAE> MCLPCEFMFBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8598670", Offset = "0x8597470", VA = "0x188598670", Slot = "41")]
	public bool PGMIIIPAKFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8592D20", Offset = "0x8591B20", VA = "0x188592D20", Slot = "49")]
	public IReadOnlyList<CJJLLLNGFKM> AONIMAOHDDK(long NFFIHLEPONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8595440", Offset = "0x8594240", VA = "0x188595440", Slot = "40")]
	[AsyncStateMachine(typeof(BBGGMKEDKJD))]
	public Task<JKEBLLKKBOM<bool, string>> GILDLIEHGMO(long CEACGIDOODJ, bool PEFDDLGIKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8594F50", Offset = "0x8593D50", VA = "0x188594F50", Slot = "54")]
	public bool EHCDFDLIFEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8597600", Offset = "0x8596400", VA = "0x188597600", Slot = "50")]
	public bool NDPPKLEACDB(string EONPHNIJJBM, [Out] IReadOnlyList<CJJLLLNGFKM> FINNBGEFMMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x85986F0", Offset = "0x85974F0", VA = "0x1885986F0")]
	[AsyncStateMachine(typeof(OBHFBFHILMF))]
	private Task<Dictionary<long, EHEPKBOFNKL>> PJMAJPOOJDO(Dictionary<long, int> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8593070", Offset = "0x8591E70", VA = "0x188593070")]
	[AsyncStateMachine(typeof(CFHENBPBNGC))]
	private Task<MPDOEGHIBFA> BAPEBBIOHJF(Guid PPGGGPECKLI, int CGKKBLKIKKA, [Optional] Guid ENBKMFCNOFH, [Optional] AHNIMKBJLEJ BGONLDOFFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8594B80", Offset = "0x8593980", VA = "0x188594B80")]
	[AsyncStateMachine(typeof(GEAKOECKACP))]
	private Task<Dictionary<LFCLNIIEKIP, AKPINJIPEKK>> EFEIPBKDCDH(Dictionary<LFCLNIIEKIP, int> DFIIBHBNIFC, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8596430", Offset = "0x8595230", VA = "0x188596430")]
	[AsyncStateMachine(typeof(BBLNFKKMIKM))]
	private Task<List<AKPINJIPEKK>> IFKIKNAFIEF(Dictionary<LFCLNIIEKIP, int> DFIIBHBNIFC, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8594710", Offset = "0x8593510", VA = "0x188594710")]
	[AsyncStateMachine(typeof(AKHMMFMBLGK))]
	private Task DMKDNBDBCNO(long CEACGIDOODJ, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8595A00", Offset = "0x8594800", VA = "0x188595A00")]
	private Task GMHBDKAOBAC(PCKGILPFDIA AOGFOJGFMAN, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x85952A0", Offset = "0x85940A0", VA = "0x1885952A0")]
	[AsyncStateMachine(typeof(FHELIELFEBF))]
	private Task FFDNKBEMKEO(PCKGILPFDIA AOGFOJGFMAN, CancellationToken GCPHEPCJGLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8598B50", Offset = "0x8597950", VA = "0x188598B50")]
	private void PMGGNOFNNGE(MAHLFJHHAOK PDLCIFEIIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8599020", Offset = "0x8597E20", VA = "0x188599020")]
	[AONLGKBOHJA]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string KJOMEEHJCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8592A80", Offset = "0x8591880", VA = "0x188592A80")]
	private void AIINCLGJCEK(Guid PPGGGPECKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8599160", Offset = "0x8597F60", VA = "0x188599160")]
	[AONLGKBOHJA]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid PPGGGPECKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8598470", Offset = "0x8597270", VA = "0x188598470")]
	[AsyncStateMachine(typeof(GHDEIABPDJA))]
	private Task<int> PAPHLEIDKDG(AHNIMKBJLEJ ENPELEHFGFF, Guid PPGGGPECKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8598E30", Offset = "0x8597C30", VA = "0x188598E30")]
	[AONLGKBOHJA]
	internal void RpcGetPlayerRoomInventoryCount(Guid LGNCELEMLNH, Guid PPGGGPECKLI, BGIPHKOMDPN DOKMLDLFBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8598DB0", Offset = "0x8597BB0", VA = "0x188598DB0")]
	[AONLGKBOHJA]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid LGNCELEMLNH, int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8595150", Offset = "0x8593F50", VA = "0x188595150")]
	[AsyncStateMachine(typeof(EIKPHLILFEA))]
	private Task<MPDOEGHIBFA> FABDBHLOLHC(AHNIMKBJLEJ ENPELEHFGFF, Guid PPGGGPECKLI, int CGKKBLKIKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8598CE0", Offset = "0x8597AE0", VA = "0x188598CE0")]
	[AONLGKBOHJA]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid LGNCELEMLNH, Guid PPGGGPECKLI, int CGKKBLKIKKA, BGIPHKOMDPN DOKMLDLFBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8596790", Offset = "0x8595590", VA = "0x188596790")]
	private void INDIJJKEEOA(AHNIMKBJLEJ JKLBOHMJEDF, Guid LGNCELEMLNH, LHABPDEBEFJ BPINCJLADGC, long HOJEBKHGBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8599410", Offset = "0x8598210", VA = "0x188599410")]
	[AONLGKBOHJA]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid LGNCELEMLNH, int BPINCJLADGC, long HOJEBKHGBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8594470", Offset = "0x8593270", VA = "0x188594470")]
	private void DKPKGMFJDCC(bool PEFDDLGIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85993B0", Offset = "0x85981B0", VA = "0x1885993B0")]
	[AONLGKBOHJA]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool IMMCDFIAGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8597E30", Offset = "0x8596C30", VA = "0x188597E30")]
	private void NIPFFHOKHFF(List<EHEPKBOFNKL> BGFBHHKCAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8599200", Offset = "0x8598000", VA = "0x188599200")]
	[AONLGKBOHJA]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string HLBLKHPAEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8594300", Offset = "0x8593100", VA = "0x188594300")]
	private void DKFKOONGMHG(long NFFIHLEPONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8599190", Offset = "0x8597F90", VA = "0x188599190")]
	[AONLGKBOHJA]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long NFFIHLEPONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8596570", Offset = "0x8595370", VA = "0x188596570")]
	private CJJLLLNGFKM IFLHPLALAMB(MAHLFJHHAOK PDLCIFEIIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8596EA0", Offset = "0x8595CA0", VA = "0x188596EA0")]
	private List<HMNCEMLKPAE> LHKILNCGGCK(List<EHEPKBOFNKL> BGFBHHKCAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8593CE0", Offset = "0x8592AE0", VA = "0x188593CE0")]
	private List<HMNCEMLKPAE> DGGEANMJDNN(IEnumerable<EHEPKBOFNKL> BGFBHHKCAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8595560", Offset = "0x8594360", VA = "0x188595560", Slot = "36")]
	public RoomInventoryItemProperties GKKKJAJCIHJ(string OFIALCCLDGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8598110", Offset = "0x8596F10", VA = "0x188598110")]
	private CJJLLLNGFKM NKLNJHLHNFG(MAHLFJHHAOK PDLCIFEIIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8593750", Offset = "0x8592550", VA = "0x188593750", Slot = "35")]
	public MAHLFJHHAOK CLEDAEHIAJA(CJJLLLNGFKM APPALJINPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8594CC0", Offset = "0x8593AC0", VA = "0x188594CC0")]
	private HMNCEMLKPAE EGKLMKJAOKF(EHEPKBOFNKL PDLCIFEIIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8595990", Offset = "0x8594790", VA = "0x188595990")]
	private void GLLCDAMEOKD(NKADEBCKGAC GBCBLMPEJAA, int FIDBOFNPBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8598C70", Offset = "0x8597A70", VA = "0x188598C70")]
	private void PMGPCLAMIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8597430", Offset = "0x8596230", VA = "0x188597430")]
	private Task MNMIIGMKGNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x85980A0", Offset = "0x8596EA0", VA = "0x1885980A0")]
	private void NKIFGNKLIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85985B0", Offset = "0x85973B0", VA = "0x1885985B0")]
	private void PDJDBGMEJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8597B50", Offset = "0x8596950", VA = "0x188597B50")]
	private void NHFKEIJJOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8596C70", Offset = "0x8595A70", VA = "0x188596C70")]
	[AsyncStateMachine(typeof(DCFGLHMKDKL))]
	private Task JPABJNOIKKL(CJJLLLNGFKM NJLBKNEHNLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8596D80", Offset = "0x8595B80", VA = "0x188596D80")]
	[CompilerGenerated]
	private void LAAHPDLGLKB(Task<TaskStatus> JDEJDGHOHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8593890", Offset = "0x8592690", VA = "0x188593890")]
	[CompilerGenerated]
	private Task<LHABPDEBEFJ> COLLJPLCHPO(GONPFJJOPPD P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8595EF0", Offset = "0x8594CF0", VA = "0x188595EF0")]
	[CompilerGenerated]
	internal static Dictionary<LFCLNIIEKIP, AKPINJIPEKK> GNOKJNPINPF(LHABPDEBEFJ BPINCJLADGC, BNBCOANJCME P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IGDCPMIPIIC : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x859E680", Offset = "0x859D480", VA = "0x18859E680")]
	public IGDCPMIPIIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PEDGCKJDJFO
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNIKHEIHALG EDPEGNANKEA();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IGDCPMIPIIC LCKMDICBKCG();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LBOBFMJNMFF AMCEHKKPECM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DABFACALPLA : PEDGCKJDJFO
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x859A680", Offset = "0x8599480", VA = "0x18859A680")]
	[ENKLKENGHAE.GHBFDECCGMJ.HGNDHHKALNH]
	internal static void BAEPNPABNEB(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DABFACALPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x859A6F0", Offset = "0x85994F0", VA = "0x18859A6F0", Slot = "4")]
	public MNIKHEIHALG EDPEGNANKEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x859A800", Offset = "0x8599600", VA = "0x18859A800", Slot = "5")]
	public IGDCPMIPIIC LCKMDICBKCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x859A590", Offset = "0x8599390", VA = "0x18859A590", Slot = "6")]
	public LBOBFMJNMFF AMCEHKKPECM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LBOBFMJNMFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, HMNCEMLKPAE> PILINJFINDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly HMNCEMLKPAE[] PHFILBEBCBJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool ICPDNMLJFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IMOOALHCBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x85A0460", Offset = "0x859F260", VA = "0x1885A0460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long ALPNEELMEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECF0", Offset = "0xA0DAF0", VA = "0x180A0ECF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x859F370", Offset = "0x859E170", VA = "0x18859F370")]
	public void CMDAKLIPNLC(long CEACGIDOODJ, IEnumerable<HMNCEMLKPAE> FIAMKOAPKNO, bool NMCGIBABCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x85A02B0", Offset = "0x859F0B0", VA = "0x1885A02B0")]
	public IReadOnlyList<HMNCEMLKPAE> MPKGNKFGLIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
	public void PMDNOFJPBHC(bool PEFDDLGIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x859FF80", Offset = "0x859ED80", VA = "0x18859FF80")]
	public bool LKPLHLIODCA(long NFFIHLEPONH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x859F970", Offset = "0x859E770", VA = "0x18859F970")]
	public bool DNNAHEPGGBG(HMNCEMLKPAE PBAHDKDFABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x859FC00", Offset = "0x859EA00", VA = "0x18859FC00")]
	public bool JENHFMNIGMH(List<HMNCEMLKPAE> CJINPCPMEOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x85A0210", Offset = "0x859F010", VA = "0x1885A0210")]
	public bool MIKCPBFFKLJ(long NFFIHLEPONH, [Out] HMNCEMLKPAE EHKJLJIDDFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x85A0060", Offset = "0x859EE60", VA = "0x1885A0060")]
	public bool LPJDFLLHNBP(string IHGFMOMOADA, [Out] HMNCEMLKPAE EHKJLJIDDFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x859FB30", Offset = "0x859E930", VA = "0x18859FB30")]
	public List<HMNCEMLKPAE> EMIKGOCEKJH(int GLAOLHCPLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x859F830", Offset = "0x859E630", VA = "0x18859F830")]
	public List<HMNCEMLKPAE> DBAGPPHJMLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C41660", Offset = "0x6C40460", VA = "0x186C41660")]
	public HMNCEMLKPAE LIEFIPIKNDE(int GLAOLHCPLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x859FF20", Offset = "0x859ED20", VA = "0x18859FF20")]
	public IReadOnlyList<HMNCEMLKPAE> KOEAOCFOHJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x85A04C0", Offset = "0x859F2C0", VA = "0x1885A04C0")]
	public LBOBFMJNMFF()
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
