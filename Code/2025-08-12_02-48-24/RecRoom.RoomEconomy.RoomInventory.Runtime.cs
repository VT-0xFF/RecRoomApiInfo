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
		[Cpp2IlInjected.Address(RVA = "0x8CD05D0", Offset = "0x8CCEBD0", VA = "0x188CD05D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PDIAGHMHILL : KNGDHPIKOPB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EGEIJGOADLL CFOBJBJGKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class PEDBHBAHJND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, FOECOMJIFAC> BEECHHGDDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, FOECOMJIFAC> NNGJJNLGCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? INKPEFCHCLD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA94FD0", Offset = "0xA935D0", VA = "0x180A94FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FOECOMJIFAC BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD150", Offset = "0x8CCB750", VA = "0x188CCD150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8CCD620", Offset = "0x8CCBC20", VA = "0x188CCD620")]
	public void IBEJBIDOMAJ(long PANGCFBNCCJ, IEnumerable<OFFODHDKHHK> IAAEHLOPGFA, IEnumerable<IIELHEKFMDK> FDJIKGJBPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8CCDC80", Offset = "0x8CCC280", VA = "0x188CCDC80")]
	public bool KFKDEKKLDGM(Guid GMHMECEEJFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8CCD130", Offset = "0x8CCB730", VA = "0x188CCD130")]
	public bool HCDNAOEAAEJ(Guid GMHMECEEJFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8CCD300", Offset = "0x8CCB900", VA = "0x188CCD300")]
	public bool HOGKMCOIIKJ(OFFODHDKHHK KJBFJLHHIGE, [Out] OFFODHDKHHK OAGLIADJJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8CCCAF0", Offset = "0x8CCB0F0", VA = "0x188CCCAF0")]
	public IEnumerable<FOECOMJIFAC> DOIDGAAHBJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8CCD1B0", Offset = "0x8CCB7B0", VA = "0x188CCD1B0")]
	public IEnumerable<OFFODHDKHHK> HFNHFOPNCKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8CCDCE0", Offset = "0x8CCC2E0", VA = "0x188CCDCE0")]
	public IEnumerable<IIELHEKFMDK> ONADAFAILCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8CCCFE0", Offset = "0x8CCB5E0", VA = "0x188CCCFE0")]
	public bool ENBNDCOGBGM(Guid GMHMECEEJFO, [Out] OFFODHDKHHK HAHKJCFFGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8CCD090", Offset = "0x8CCB690", VA = "0x188CCD090")]
	public bool FOLHADEDCIF(string NMIMAMKJLLE, [Out] OFFODHDKHHK HAHKJCFFGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC9A0", Offset = "0x8CCAFA0", VA = "0x188CCC9A0")]
	public bool CNNPPCNICBJ(Guid GMHMECEEJFO, [Out] IIELHEKFMDK PHFCKNAFAMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8CCCA50", Offset = "0x8CCB050", VA = "0x188CCCA50")]
	public bool DMHMLCKNDOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC920", Offset = "0x8CCAF20", VA = "0x188CCC920")]
	private bool BAGCNBMKHAL(OFFODHDKHHK BDPHCAGFJCP, OFFODHDKHHK GDHICCHEJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8CCCB40", Offset = "0x8CCB140", VA = "0x188CCCB40")]
	private void EJLCFKJNOIJ(Guid LEPAEEGOBDO, FOECOMJIFAC PLIJIOOEOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8CCCD90", Offset = "0x8CCB390", VA = "0x188CCCD90")]
	private bool EMDLIOLDIDC(Guid LEPAEEGOBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8CCD530", Offset = "0x8CCBB30", VA = "0x188CCD530")]
	private void HPBIIOJANKK(OFFODHDKHHK JCACAJNDIFN, [Optional] OFFODHDKHHK HKEHBIJAOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8CCDE30", Offset = "0x8CCC430", VA = "0x188CCDE30")]
	private bool POIJJLPGJNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC8E0", Offset = "0x8CCAEE0", VA = "0x188CCC8E0")]
	private static bool ALOCHHFPLGE(OFFODHDKHHK KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8CCE010", Offset = "0x8CCC610", VA = "0x188CCE010")]
	public PEDBHBAHJND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EGEIJGOADLL : KDBGJAHEMAN, BPDOKAIBAEB, IDisposable, CFFOJIANONK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct IJHEPAKKPOB : IEquatable<IJHEPAKKPOB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long CLONBIJNLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid NCDLKMDCKIF;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5682450", Offset = "0x5680A50", VA = "0x185682450")]
		public IJHEPAKKPOB(long PANGCFBNCCJ, Guid GMHMECEEJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9FA0", Offset = "0x8CC85A0", VA = "0x188CC9FA0", Slot = "4")]
		public bool Equals(IJHEPAKKPOB IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9E40", Offset = "0x8CC8440", VA = "0x188CC9E40", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA0A0", Offset = "0x8CC86A0", VA = "0x188CCA0A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LHDEBHKPOIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<OFFODHDKHHK, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EGEIJGOADLL <>4__this;

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
		public List<MLDNDEOEJCJ> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<JPPKKBJBENK<NPPHCBECOKK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA120", Offset = "0x8CC8720", VA = "0x188CCA120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA620", Offset = "0x8CC8C20", VA = "0x188CCA620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct EKJICFFGLLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<OFFODHDKHHK, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EGEIJGOADLL <>4__this;

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
		private TaskAwaiter<JPPKKBJBENK<NPPHCBECOKK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC64E0", Offset = "0x8CC4AE0", VA = "0x188CC64E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6D30", Offset = "0x8CC5330", VA = "0x188CC6D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BFCHBFCOMOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private OFFODHDKHHK <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private HEFFBECLBFK <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<HEFFBECLBFK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8CBCAB0", Offset = "0x8CBB0B0", VA = "0x188CBCAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD2B0", Offset = "0x8CBB8B0", VA = "0x188CBD2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HDANEPOMCKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NGPBJJLAELK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8FD0", Offset = "0x8CC75D0", VA = "0x188CC8FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9350", Offset = "0x8CC7950", VA = "0x188CC9350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DMIJGBIHGJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<MAEGKEODCOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NGPBJJLAELK recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<MAEGKEODCOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8CBE690", Offset = "0x8CBCC90", VA = "0x188CBE690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CBEAF0", Offset = "0x8CBD0F0", VA = "0x188CBEAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HPKPBLEJNEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<DLINHEBPGIO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private DLINHEBPGIO <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9950", Offset = "0x8CC7F50", VA = "0x188CC9950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8CC9DD0", Offset = "0x8CC83D0", VA = "0x188CC9DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct BOKEJHLPAAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<DLINHEBPGIO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<PKAAAAMEMEI<DLINHEBPGIO, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<HEFFBECLBFK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CBD320", Offset = "0x8CBB920", VA = "0x188CBD320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDF30", Offset = "0x8CBC530", VA = "0x188CBDF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HNONNPGHFEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<HEFFBECLBFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8CC93C0", Offset = "0x8CC79C0", VA = "0x188CC93C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8CC98E0", Offset = "0x8CC7EE0", VA = "0x188CC98E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PPJDEGCMEDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, MLDNDEOEJCJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<JPPKKBJBENK<List<MLDNDEOEJCJ>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF920", Offset = "0x8CCDF20", VA = "0x188CCF920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8CD02E0", Offset = "0x8CCE8E0", VA = "0x188CD02E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MMHNPJENKBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public IIELHEKFMDK playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LJGICHJHDPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<MAEGKEODCOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private MMHNPJENKBP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NGPBJJLAELK awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<CDNAMBEPHLK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA690", Offset = "0x8CC8C90", VA = "0x188CCA690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAAE0", Offset = "0x8CC90E0", VA = "0x188CCAAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KKJGLNBLNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<IJHEPAKKPOB, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EFLHCGOKMIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CDNAMBEPHLK result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EFLHCGOKMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8CBEB60", Offset = "0x8CBD160", VA = "0x188CBEB60")]
		internal BGCFJHLFDMK DEIDIMNNEBG(IJHEPAKKPOB id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LLBENLLGMNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<IJHEPAKKPOB, BGCFJHLFDMK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<IJHEPAKKPOB, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private KKJGLNBLNOF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<BGCFJHLFDMK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB50", Offset = "0x8CC9150", VA = "0x188CCAB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB620", Offset = "0x8CC9C20", VA = "0x188CCB620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct GEPHPGNHLNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<BGCFJHLFDMK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<IJHEPAKKPOB, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<BGCFJHLFDMK> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<BGCFJHLFDMK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC75F0", Offset = "0x8CC5BF0", VA = "0x188CC75F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8550", Offset = "0x8CC6B50", VA = "0x188CC8550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PIKJODGKAOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<NPPHCBECOKK>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<POJIMGKOIHD>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<MLDNDEOEJCJ>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<KOAEMLBLAAL> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<OFFODHDKHHK> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<IIELHEKFMDK> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<DLINHEBPGIO> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<NPPHCBECOKK>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<POJIMGKOIHD>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<MLDNDEOEJCJ>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<KOAEMLBLAAL> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CCE0F0", Offset = "0x8CCC6F0", VA = "0x188CCE0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF350", Offset = "0x8CCD950", VA = "0x188CCF350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct DJGEJGGKCBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDFA0", Offset = "0x8CBC5A0", VA = "0x188CBDFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8CBE630", Offset = "0x8CBCC30", VA = "0x188CBE630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct FLNHBMLKBEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NGPBJJLAELK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6DA0", Offset = "0x8CC53A0", VA = "0x188CC6DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC72A0", Offset = "0x8CC58A0", VA = "0x188CC72A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PJJGHHKCHEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<MAEGKEODCOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public NGPBJJLAELK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<MAEGKEODCOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF3B0", Offset = "0x8CCD9B0", VA = "0x188CCF3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF8B0", Offset = "0x8CCDEB0", VA = "0x188CCF8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct GGCMLMPGOBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OFFODHDKHHK itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public EGEIJGOADLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<PKAAAAMEMEI<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC85C0", Offset = "0x8CC6BC0", VA = "0x188CC85C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8F70", Offset = "0x8CC7570", VA = "0x188CC8F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan NJIFPMDGKHN;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float KJOKLCCLKOG = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float MLEIMONCBPP = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int AHEAJJDGMGK = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string BHGPBBKJFGH = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string HCADNGONGMB = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CLGDAEGFDFG HIEDBCPJOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NCKNBLKODIO GGJLJDBJDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JCPCIKAIGAK EBOFMEFMFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly JKBCGLENMDN CNMCCCKOPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LLHIAIMDFNE JAMGLFFELKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PDIAGHMHILL OJBHHCHOBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BDAGHMMFHLO ANHHCBNKCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly IPLADBHABLH GCCNMIBKHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly PPFLMJMMFMJ LFNFIBOPBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly PEDBHBAHJND NGJMMJLDHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OCKHGNHHEGN CMFPIDIFGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly PDOBAIIPANF DDAMNMKBBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource KIDMBMOMGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FCAMHELPOLP<IJHEPAKKPOB, BGCFJHLFDMK> GFIPEAJPIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FCAMHELPOLP<long, MLDNDEOEJCJ> JOMEKADHLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NLFGHGDLKKN GNEFMHLEDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable NNBOKKNDJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task ABBOAMILDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource LIFNNNFOJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long IAIEIDDJOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool OPDBEINFGEH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private GKPILLDFPFO JMAJHFFOBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC22D0", Offset = "0x8CC08D0", VA = "0x188CC22D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HBPNKKOKOOA MCMPJCPPDBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xEBE400", Offset = "0xEBCA00", VA = "0x180EBE400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEBE410", Offset = "0xEBCA10", VA = "0x180EBE410", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GJIKMKGBNOL<OFFODHDKHHK> DPGFCNCAOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB65DF0", Offset = "0xB643F0", VA = "0x180B65DF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB91F00", Offset = "0xB90500", VA = "0x180B91F00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GJIKMKGBNOL<Guid> AFJJEDFBCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB66200", Offset = "0xB64800", VA = "0x180B66200", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB65DB0", Offset = "0xB643B0", VA = "0x180B65DB0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NCECCJAFPPJ<IIELHEKFMDK, int> EHEBAMJDKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB24A30", Offset = "0xB23030", VA = "0x180B24A30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB27D40", Offset = "0xB26340", VA = "0x180B27D40", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GJIKMKGBNOL<DLINHEBPGIO> ODBIGLDCGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9F130", Offset = "0xA9D730", VA = "0x180A9F130", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA9F160", Offset = "0xA9D760", VA = "0x180A9F160", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GJIKMKGBNOL<long> HHKOJFLKAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB28700", Offset = "0xB26D00", VA = "0x180B28700", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB27D10", Offset = "0xB26310", VA = "0x180B27D10", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HBPNKKOKOOA DPLLFGLCOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB286F0", Offset = "0xB26CF0", VA = "0x180B286F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB27A80", Offset = "0xB26080", VA = "0x180B27A80", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HBPNKKOKOOA IHNELOMIPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB229F0", Offset = "0xB20FF0", VA = "0x180B229F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB22ED0", Offset = "0xB214D0", VA = "0x180B22ED0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8CBEBD0", Offset = "0x8CBD1D0", VA = "0x188CBEBD0")]
	[LAFCEDCMNGK.LDGLOLCMPLF.AALIAIEKGHF]
	internal static void AAICCAKCFCJ(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC5960", Offset = "0x8CC3F60", VA = "0x188CC5960")]
	[RecRoom.NoEngine.Common.Preserve]
	public EGEIJGOADLL([OEKMEJFDAAI(null)] CLGDAEGFDFG HIEDBCPJOOF, [OEKMEJFDAAI(null)] NCKNBLKODIO GGJLJDBJDEM, [OEKMEJFDAAI(null)] JCPCIKAIGAK EBOFMEFMFAN, [OEKMEJFDAAI(null)] JKBCGLENMDN CNMCCCKOPKA, [OEKMEJFDAAI(null)] KMNENFMKNHB OPOFAOLMBIH, [OEKMEJFDAAI(null)] LLHIAIMDFNE JAMGLFFELKA, [OEKMEJFDAAI(null)] PDIAGHMHILL OJBHHCHOBHF, [OEKMEJFDAAI(null)] DFDHDICEODK HHKNIPLAADF, [OEKMEJFDAAI(null)] JADMHCENEIO BKGOJGJEDKA, [OEKMEJFDAAI(null)] BDAGHMMFHLO ANHHCBNKCPG, [OEKMEJFDAAI(null)] IPLADBHABLH GCCNMIBKHDK, [OEKMEJFDAAI(null)] PPFLMJMMFMJ LFNFIBOPBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0180", Offset = "0x8CBE780", VA = "0x188CC0180", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8CC4D60", Offset = "0x8CC3360", VA = "0x188CC4D60", Slot = "52")]
	public Task PKFHLPFALBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8CC4E00", Offset = "0x8CC3400", VA = "0x188CC4E00", Slot = "20")]
	[AsyncStateMachine(typeof(LHDEBHKPOIE))]
	public Task<PKAAAAMEMEI<OFFODHDKHHK, string>> PKIANPFGCDG(Guid? GFKCOHLNPGF, long PANGCFBNCCJ, string DJFMCHMDHGK, string OINDFPIKPLL, string IFCAGKLINAN, RoomInventoryItemProperties MKBODFCJGPA, byte NDLHPLKACFL, int ONDGBPEOGJF, [Optional] List<long> KOJHLIGHDBJ, [Optional] List<MLDNDEOEJCJ> KJHJEJJKHMC, bool LKBFHKBPJDF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8CC07E0", Offset = "0x8CBEDE0", VA = "0x188CC07E0", Slot = "21")]
	[AsyncStateMachine(typeof(EKJICFFGLLG))]
	public Task<PKAAAAMEMEI<OFFODHDKHHK, string>> FEKNJJGFPHF(Guid GMHMECEEJFO, long PANGCFBNCCJ, [Optional] string DJFMCHMDHGK, [Optional] string OINDFPIKPLL, [Optional] string IFCAGKLINAN, [Optional] List<long> KOJHLIGHDBJ, [Optional] Dictionary<string, RoomInventoryTagClientProperties> KJHJEJJKHMC, [Optional] RoomInventoryItemProperties MKBODFCJGPA, [Optional] byte? NDLHPLKACFL, [Optional] int? ONDGBPEOGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8CC20D0", Offset = "0x8CC06D0", VA = "0x188CC20D0", Slot = "22")]
	[AsyncStateMachine(typeof(BFCHBFCOMOK))]
	public Task<PKAAAAMEMEI<bool, string>> KGBEKILJNDN(Guid GMHMECEEJFO, long PANGCFBNCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8CC2F90", Offset = "0x8CC1590", VA = "0x188CC2F90", Slot = "23")]
	public IReadOnlyList<OFFODHDKHHK> LKDAFKNKNCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8CBEDB0", Offset = "0x8CBD3B0", VA = "0x188CBEDB0", Slot = "24")]
	public IReadOnlyList<OFFODHDKHHK> AEONAGGPPEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8CC4640", Offset = "0x8CC2C40", VA = "0x188CC4640", Slot = "25")]
	public bool OMEIKAHACFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8CC04E0", Offset = "0x8CBEAE0", VA = "0x188CC04E0", Slot = "26")]
	public bool ENBNDCOGBGM(Guid GMHMECEEJFO, [Out] OFFODHDKHHK HAHKJCFFGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0A30", Offset = "0x8CBF030", VA = "0x188CC0A30", Slot = "27")]
	public bool FOLHADEDCIF(string LNFDFPOOONM, [Out] OFFODHDKHHK HAHKJCFFGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8CC30B0", Offset = "0x8CC16B0", VA = "0x188CC30B0", Slot = "28")]
	public IReadOnlyList<IIELHEKFMDK> MDJOACCOGII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8CBFE50", Offset = "0x8CBE450", VA = "0x188CBFE50", Slot = "29")]
	public bool CNNPPCNICBJ(Guid GMHMECEEJFO, [Out] IIELHEKFMDK PHFCKNAFAMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC1F40", Offset = "0x8CC0540", VA = "0x188CC1F40", Slot = "30")]
	public long? JMCOFCFHBBO(Guid GMHMECEEJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC4740", Offset = "0x8CC2D40", VA = "0x188CC4740", Slot = "51")]
	public void PDPGKPANGFG(IEnumerable<POJIMGKOIHD> FDJIKGJBPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC03A0", Offset = "0x8CBE9A0", VA = "0x188CC03A0", Slot = "31")]
	[AsyncStateMachine(typeof(HDANEPOMCKI))]
	public Task<int> EACHNEOAMFG(NGPBJJLAELK LIOICDJHFAF, Guid GMHMECEEJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC4C10", Offset = "0x8CC3210", VA = "0x188CC4C10", Slot = "32")]
	[AsyncStateMachine(typeof(DMIJGBIHGJL))]
	public Task<MAEGKEODCOF> PJIELMCJLDB(NGPBJJLAELK FGGLNKHJCHE, Guid GMHMECEEJFO, int DKCPHNPHHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC32A0", Offset = "0x8CC18A0", VA = "0x188CC32A0", Slot = "33")]
	public string MIICBONGANL(CDNAMBEPHLK CENCPMGPALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8CC3610", Offset = "0x8CC1C10", VA = "0x188CC3610", Slot = "34")]
	public bool MKMEIPIDLLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF110", Offset = "0x8CBD710", VA = "0x188CBF110", Slot = "38")]
	[AsyncStateMachine(typeof(HPKPBLEJNEO))]
	public Task<PKAAAAMEMEI<DLINHEBPGIO, string>> AICPFJAMMDN(long CGJNLNOKCBF, RoomInventoryTagClientProperties MKBODFCJGPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0D40", Offset = "0x8CBF340", VA = "0x188CC0D40", Slot = "39")]
	[AsyncStateMachine(typeof(BOKEJHLPAAK))]
	public Task<PKAAAAMEMEI<bool, string>> GLMAEGBFLGB(long CGJNLNOKCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8CC4360", Offset = "0x8CC2960", VA = "0x188CC4360", Slot = "42")]
	public List<(long, int)> OLOAMLEILNI(long FEIPMPBOADP, int OFHFCJFLIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF080", Offset = "0x8CBD680", VA = "0x188CBF080", Slot = "43")]
	public bool AHODJDCMPNP(long CGJNLNOKCBF, [Out] DLINHEBPGIO DHEJCFEACIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8CC09A0", Offset = "0x8CBEFA0", VA = "0x188CC09A0", Slot = "44")]
	public bool FGMLDOKCPHK(string NAJJEOEKLGJ, [Out] DLINHEBPGIO DHEJCFEACIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF800", Offset = "0x8CBDE00", VA = "0x188CBF800", Slot = "45")]
	public bool CLPJMDLNCJD(long CGJNLNOKCBF, Guid CFBDDOIAOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8CC2200", Offset = "0x8CC0800", VA = "0x188CC2200", Slot = "46")]
	public IReadOnlyList<DLINHEBPGIO> KIMLNHFAMHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF350", Offset = "0x8CBD950", VA = "0x188CBF350", Slot = "47")]
	public List<DLINHEBPGIO> BEBPHBFAMPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF450", Offset = "0x8CBDA50", VA = "0x188CBF450", Slot = "48")]
	public IReadOnlyList<DLINHEBPGIO> CLFAPGAAILC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC3470", Offset = "0x8CC1A70", VA = "0x188CC3470", Slot = "41")]
	public bool MJANBBLFMBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC1B40", Offset = "0x8CC0140", VA = "0x188CC1B40", Slot = "49")]
	public IReadOnlyList<OFFODHDKHHK> JELFMIODNME(long CGJNLNOKCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC34F0", Offset = "0x8CC1AF0", VA = "0x188CC34F0", Slot = "40")]
	[AsyncStateMachine(typeof(HNONNPGHFEF))]
	public Task<PKAAAAMEMEI<bool, string>> MKDBCJGGOAL(long PANGCFBNCCJ, bool ECDIKDBOIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC3040", Offset = "0x8CC1640", VA = "0x188CC3040", Slot = "54")]
	public bool MBEAADLLJML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC2430", Offset = "0x8CC0A30", VA = "0x188CC2430", Slot = "50")]
	public bool KOEHPBNGLKD(string NAJJEOEKLGJ, [Out] IReadOnlyList<OFFODHDKHHK> BBCNNPFMCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC1540", Offset = "0x8CBFB40", VA = "0x188CC1540")]
	[AsyncStateMachine(typeof(PPJDEGCMEDB))]
	private Task<Dictionary<long, MLDNDEOEJCJ>> HLCILJHJNOB(Dictionary<long, int> FAJNOCIIJMC, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8CC4FC0", Offset = "0x8CC35C0", VA = "0x188CC4FC0")]
	[AsyncStateMachine(typeof(LJGICHJHDPJ))]
	private Task<MAEGKEODCOF> PLFNJLADNGE(Guid GMHMECEEJFO, int DKCPHNPHHEP, [Optional] Guid OPPOCJEFFDC, [Optional] NGPBJJLAELK JLAFICMGPBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0040", Offset = "0x8CBE640", VA = "0x188CC0040")]
	[AsyncStateMachine(typeof(LLBENLLGMNH))]
	private Task<Dictionary<IJHEPAKKPOB, BGCFJHLFDMK>> DKEEALHJEHN(Dictionary<IJHEPAKKPOB, int> IFBNAAOMDFE, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8CC3C30", Offset = "0x8CC2230", VA = "0x188CC3C30")]
	[AsyncStateMachine(typeof(GEPHPGNHLNK))]
	private Task<List<BGCFJHLFDMK>> NHFMCJPKNEC(Dictionary<IJHEPAKKPOB, int> IFBNAAOMDFE, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8CC1E10", Offset = "0x8CC0410", VA = "0x188CC1E10")]
	[AsyncStateMachine(typeof(PIKJODGKAOI))]
	private Task JENPNGFMJDP(long PANGCFBNCCJ, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8CC37D0", Offset = "0x8CC1DD0", VA = "0x188CC37D0")]
	private Task MPOMOBLEBBH(IJFCDEBIONC KGIPMLMDBBA, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0C70", Offset = "0x8CBF270", VA = "0x188CC0C70")]
	[AsyncStateMachine(typeof(DJGEJGGKCBF))]
	private Task GIGFBPMMLLJ(IJFCDEBIONC KGIPMLMDBBA, CancellationToken IACNBGJHPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8CC4AF0", Offset = "0x8CC30F0", VA = "0x188CC4AF0")]
	private void PIOPJKLFAII(NPPHCBECOKK PLNJBGDGHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8CC5440", Offset = "0x8CC3A40", VA = "0x188CC5440")]
	[DNODEMNIJIG]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string BOCDMLBEFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8CC19D0", Offset = "0x8CBFFD0", VA = "0x188CC19D0")]
	private void JCPHDPOHDGJ(Guid GMHMECEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8CC5580", Offset = "0x8CC3B80", VA = "0x188CC5580")]
	[DNODEMNIJIG]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid GMHMECEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC1680", Offset = "0x8CBFC80", VA = "0x188CC1680")]
	[AsyncStateMachine(typeof(FLNHBMLKBEN))]
	private Task<int> HMFEGECKMCG(NGPBJJLAELK LIOICDJHFAF, Guid GMHMECEEJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC5260", Offset = "0x8CC3860", VA = "0x188CC5260")]
	[DNODEMNIJIG]
	internal void RpcGetPlayerRoomInventoryCount(Guid HEHCIJKCGOH, Guid GMHMECEEJFO, HGNFDBOJKMF AFDLHEFMFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC51E0", Offset = "0x8CC37E0", VA = "0x188CC51E0")]
	[DNODEMNIJIG]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid HEHCIJKCGOH, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC3680", Offset = "0x8CC1C80", VA = "0x188CC3680")]
	[AsyncStateMachine(typeof(PJJGHHKCHEK))]
	private Task<MAEGKEODCOF> MLJEAJLOJJI(NGPBJJLAELK LIOICDJHFAF, Guid GMHMECEEJFO, int DKCPHNPHHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC5110", Offset = "0x8CC3710", VA = "0x188CC5110")]
	[DNODEMNIJIG]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid HEHCIJKCGOH, Guid GMHMECEEJFO, int DKCPHNPHHEP, HGNFDBOJKMF AFDLHEFMFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC2C40", Offset = "0x8CC1240", VA = "0x188CC2C40")]
	private void LDFJHIPLLNO(NGPBJJLAELK FGGLNKHJCHE, Guid HEHCIJKCGOH, CDNAMBEPHLK CENCPMGPALN, long KLDPOFPONAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8CC5830", Offset = "0x8CC3E30", VA = "0x188CC5830")]
	[DNODEMNIJIG]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid HEHCIJKCGOH, int CENCPMGPALN, long KLDPOFPONAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8CBEC40", Offset = "0x8CBD240", VA = "0x188CBEC40")]
	private void ADAAOAHKJCP(bool ECDIKDBOIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8CC57D0", Offset = "0x8CC3DD0", VA = "0x188CC57D0")]
	[DNODEMNIJIG]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool EPNEPCDKBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0B50", Offset = "0x8CBF150", VA = "0x188CC0B50")]
	private void GDBIFJGOAOF(List<MLDNDEOEJCJ> GJAGFCAOIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8CC5620", Offset = "0x8CC3C20", VA = "0x188CC5620")]
	[DNODEMNIJIG]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string MMCHBGOCNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0670", Offset = "0x8CBEC70", VA = "0x188CC0670")]
	private void EOBKOMHAJKH(long CGJNLNOKCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8CC55B0", Offset = "0x8CC3BB0", VA = "0x188CC55B0")]
	[DNODEMNIJIG]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long CGJNLNOKCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8CC3F60", Offset = "0x8CC2560", VA = "0x188CC3F60")]
	private OFFODHDKHHK OLBPHNGKCGG(NPPHCBECOKK PLNJBGDGHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8CC4180", Offset = "0x8CC2780", VA = "0x188CC4180")]
	private List<DLINHEBPGIO> OLNBCPGINIO(List<MLDNDEOEJCJ> GJAGFCAOIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8CC28F0", Offset = "0x8CC0EF0", VA = "0x188CC28F0")]
	private List<DLINHEBPGIO> KPMIFHEFANE(IEnumerable<MLDNDEOEJCJ> GJAGFCAOIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0E60", Offset = "0x8CBF460", VA = "0x188CC0E60", Slot = "36")]
	public RoomInventoryItemProperties GPBIDKBEJLG(string DEJLIDLLCFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC1830", Offset = "0x8CBFE30", VA = "0x188CC1830")]
	private OFFODHDKHHK IHCMOOMCFKG(NPPHCBECOKK PLNJBGDGHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC49B0", Offset = "0x8CC2FB0", VA = "0x188CC49B0", Slot = "35")]
	public NPPHCBECOKK PEGBGNHJNBI(OFFODHDKHHK DOELBLBCMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC12B0", Offset = "0x8CBF8B0", VA = "0x188CC12B0")]
	private DLINHEBPGIO HEMHEJAGOCA(MLDNDEOEJCJ PLNJBGDGHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF3E0", Offset = "0x8CBD9E0", VA = "0x188CBF3E0")]
	private void BFENFHENFLG(IIELHEKFMDK PHFCKNAFAMJ, int IOGOHEDOCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC17C0", Offset = "0x8CBFDC0", VA = "0x188CC17C0")]
	private void ICJOPPOJOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8CC2E00", Offset = "0x8CC1400", VA = "0x188CC2E00")]
	private Task LFMEGLAHGPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8CC0600", Offset = "0x8CBEC00", VA = "0x188CC0600")]
	private void ENGPLEMNNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8CBFF80", Offset = "0x8CBE580", VA = "0x188CBFF80")]
	private void CPNHICEFMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8CBF240", Offset = "0x8CBD840", VA = "0x188CBF240")]
	private void BBLEKMBNCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8CC2320", Offset = "0x8CC0920", VA = "0x188CC2320")]
	[AsyncStateMachine(typeof(GGCMLMPGOBM))]
	private Task KMABJPMACIO(OFFODHDKHHK BMECAMEALCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8CC3F40", Offset = "0x8CC2540", VA = "0x188CC3F40")]
	[CompilerGenerated]
	private void NPEGJCLOJAK(Task<TaskStatus> PIKAFIDPPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8CBFA00", Offset = "0x8CBE000", VA = "0x188CBFA00")]
	[CompilerGenerated]
	private Task<CDNAMBEPHLK> CMDNNGJLHNO(MMHNPJENKBP P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8CC3D70", Offset = "0x8CC2370", VA = "0x188CC3D70")]
	[CompilerGenerated]
	internal static Dictionary<IJHEPAKKPOB, BGCFJHLFDMK> NPDMMECBCDD(CDNAMBEPHLK CENCPMGPALN, KKJGLNBLNOF P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PDOBAIIPANF : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC8A0", Offset = "0x8CCAEA0", VA = "0x188CCC8A0")]
	public PDOBAIIPANF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JADMHCENEIO
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEDBHBAHJND GKAIBCKBJLE();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PDOBAIIPANF PODBCHDMGAA();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OCKHGNHHEGN JAHKIEAPNPK();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GBJDPOAGLMJ : JADMHCENEIO
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8CC7310", Offset = "0x8CC5910", VA = "0x188CC7310")]
	[LAFCEDCMNGK.LDGLOLCMPLF.AALIAIEKGHF]
	internal static void AAICCAKCFCJ(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GBJDPOAGLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8CC7380", Offset = "0x8CC5980", VA = "0x188CC7380", Slot = "4")]
	public PEDBHBAHJND GKAIBCKBJLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8CC7580", Offset = "0x8CC5B80", VA = "0x188CC7580", Slot = "5")]
	public PDOBAIIPANF PODBCHDMGAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8CC7490", Offset = "0x8CC5A90", VA = "0x188CC7490", Slot = "6")]
	public OCKHGNHHEGN JAHKIEAPNPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OCKHGNHHEGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, DLINHEBPGIO> MFBHCGCGBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly DLINHEBPGIO[] HABHBKEEIBP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FAAJDOOEMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FHHBCJIMOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB800", Offset = "0x8CC9E00", VA = "0x188CCB800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long ODGBIHHDHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA94FD0", Offset = "0xA935D0", VA = "0x180A94FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8CCBD30", Offset = "0x8CCA330", VA = "0x188CCBD30")]
	public void IBEJBIDOMAJ(long PANGCFBNCCJ, IEnumerable<DLINHEBPGIO> MFBOBLCOBIC, bool AJHAPNPDOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8CCBB80", Offset = "0x8CCA180", VA = "0x188CCBB80")]
	public IReadOnlyList<DLINHEBPGIO> GEMAKALINHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
	public void FILDIEHNBLH(bool ECDIKDBOIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC560", Offset = "0x8CCAB60", VA = "0x188CCC560")]
	public bool LJBENGJHDOF(long CGJNLNOKCBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC1F0", Offset = "0x8CCA7F0", VA = "0x188CCC1F0")]
	public bool KFFKIBBCIBI(DLINHEBPGIO HJKJJGKFBLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8CCB860", Offset = "0x8CC9E60", VA = "0x188CCB860")]
	public bool EIIOIEBPCFJ(List<DLINHEBPGIO> FHLOPNNCOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8CCB760", Offset = "0x8CC9D60", VA = "0x188CCB760")]
	public bool BJPHBKLAILG(long CGJNLNOKCBF, [Out] DLINHEBPGIO BBLDJOHEJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC3B0", Offset = "0x8CCA9B0", VA = "0x188CCC3B0")]
	public bool KFNJAEOKEFK(string DJFMCHMDHGK, [Out] DLINHEBPGIO BBLDJOHEJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8CCB690", Offset = "0x8CC9C90", VA = "0x188CCB690")]
	public List<DLINHEBPGIO> AKKOALDNGKP(int LEPAEEGOBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC6A0", Offset = "0x8CCACA0", VA = "0x188CCC6A0")]
	public List<DLINHEBPGIO> NONEGPIJKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7271930", Offset = "0x726FF30", VA = "0x187271930")]
	public DLINHEBPGIO KJHJOGKIMPE(int LEPAEEGOBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC640", Offset = "0x8CCAC40", VA = "0x188CCC640")]
	public IReadOnlyList<DLINHEBPGIO> NKHDDAMBJHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8CCC7E0", Offset = "0x8CCADE0", VA = "0x188CCC7E0")]
	public OCKHGNHHEGN()
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
