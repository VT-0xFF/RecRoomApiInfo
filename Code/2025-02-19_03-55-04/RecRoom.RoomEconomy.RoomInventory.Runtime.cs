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
		[Cpp2IlInjected.Address(RVA = "0x7C06830", Offset = "0x7C05430", VA = "0x187C06830", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GEDMDAPIAKG : KAOONLJDOHB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PFOBHIJJADH EFOENCGNPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class FEKBMKGEAFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, GKEHBAIFIDK> DBHFFKANFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, GKEHBAIFIDK> AIAEAPANHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? HLPDLLJHLLK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long JMAKOHJDMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x95CF10", Offset = "0x95BB10", VA = "0x18095CF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GKEHBAIFIDK MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8B20", Offset = "0x7BF7720", VA = "0x187BF8B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8190", Offset = "0x7BF6D90", VA = "0x187BF8190")]
	public void JIMIMLHDOMO(long EPGJLNEAJPA, IEnumerable<NBGALKEFGFE> KFNEDJALJKK, IEnumerable<EFEKIJMGOMH> OGJFLHBJGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7DA0", Offset = "0x7BF69A0", VA = "0x187BF7DA0")]
	public bool HLJAGAGHKFD(Guid HPJKPAIMGLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7870", Offset = "0x7BF6470", VA = "0x187BF7870")]
	public bool BLAPNJAELFA(Guid HPJKPAIMGLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8800", Offset = "0x7BF7400", VA = "0x187BF8800")]
	public bool NBGIFDFFPKP(NBGALKEFGFE ACBCODIJOCH, [Out] NBGALKEFGFE MJPAGFOBAFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8140", Offset = "0x7BF6D40", VA = "0x187BF8140")]
	public IEnumerable<GKEHBAIFIDK> IHCMKOBOFFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7730", Offset = "0x7BF6330", VA = "0x187BF7730")]
	public IEnumerable<NBGALKEFGFE> BHDKFGBIJFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7890", Offset = "0x7BF6490", VA = "0x187BF7890")]
	public IEnumerable<EFEKIJMGOMH> CGFFIJEMENK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7EB0", Offset = "0x7BF6AB0", VA = "0x187BF7EB0")]
	public bool IBOEDFKFAGB(Guid HPJKPAIMGLO, [Out] NBGALKEFGFE KFAGJDDMJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7CC0", Offset = "0x7BF68C0", VA = "0x187BF7CC0")]
	public bool GJNJOBBGBFG(string DIKBKGHPKAD, [Out] NBGALKEFGFE KFAGJDDMJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7E00", Offset = "0x7BF6A00", VA = "0x187BF7E00")]
	public bool HMOHBKBECOO(Guid HPJKPAIMGLO, [Out] EFEKIJMGOMH INFMPPDOHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7C20", Offset = "0x7BF6820", VA = "0x187BF7C20")]
	public bool FBJPPDLOAPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8B80", Offset = "0x7BF7780", VA = "0x187BF8B80")]
	private bool OGKPOCLENDN(NBGALKEFGFE PLAOPLEFGKN, NBGALKEFGFE DFKOELBJCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BF79D0", Offset = "0x7BF65D0", VA = "0x187BF79D0")]
	private void CMLFDINAIOA(Guid BIEEMEKMINN, GKEHBAIFIDK FCMEPFELCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BF74E0", Offset = "0x7BF60E0", VA = "0x187BF74E0")]
	private bool AEPJJJLFJLN(Guid BIEEMEKMINN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8A30", Offset = "0x7BF7630", VA = "0x187BF8A30")]
	private void NBIDFDNNNJK(NBGALKEFGFE KAHPFDCDGFH, [Optional] NBGALKEFGFE BHBOJKEMFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7F60", Offset = "0x7BF6B60", VA = "0x187BF7F60")]
	private bool ICCPFOKMLNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7D60", Offset = "0x7BF6960", VA = "0x187BF7D60")]
	private static bool HGCOPCAKOFG(NBGALKEFGFE HLGDOFMLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8C00", Offset = "0x7BF7800", VA = "0x187BF8C00")]
	public FEKBMKGEAFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PFOBHIJJADH : HFENCGPHCDP, BHPGDBFDDBI, IDisposable, LBAFFJBBCBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct DAJAHHKBOCG : IEquatable<DAJAHHKBOCG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long JMAKOHJDMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid FDKJPAJGHDE;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4B0CE80", Offset = "0x4B0BA80", VA = "0x184B0CE80")]
		public DAJAHHKBOCG(long EPGJLNEAJPA, Guid HPJKPAIMGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4F70", Offset = "0x7BF3B70", VA = "0x187BF4F70", Slot = "4")]
		public bool Equals(DAJAHHKBOCG PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5070", Offset = "0x7BF3C70", VA = "0x187BF5070", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF51D0", Offset = "0x7BF3DD0", VA = "0x187BF51D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DAKIFGNNPDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<NBGALKEFGFE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PFOBHIJJADH <>4__this;

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
		public List<NDMDKMDKJIB> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<MJBJHPLHIEA<IPBKBDLPABC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5250", Offset = "0x7BF3E50", VA = "0x187BF5250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5760", Offset = "0x7BF4360", VA = "0x187BF5760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GJFEDJEBPPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<NBGALKEFGFE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PFOBHIJJADH <>4__this;

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
		private TaskAwaiter<MJBJHPLHIEA<IPBKBDLPABC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8CE0", Offset = "0x7BF78E0", VA = "0x187BF8CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9530", Offset = "0x7BF8130", VA = "0x187BF9530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IJBJKDJJKPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private NBGALKEFGFE <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private HLIBKFCHMNE <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<HLIBKFCHMNE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAE00", Offset = "0x7BF9A00", VA = "0x187BFAE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB610", Offset = "0x7BFA210", VA = "0x187BFB610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct ICCEMCBAPMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public GDNMNFALBCN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA000", Offset = "0x7BF8C00", VA = "0x187BFA000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA380", Offset = "0x7BF8F80", VA = "0x187BFA380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KODIFCAAMIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<EDOCCPJFFDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public GDNMNFALBCN recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<EDOCCPJFFDH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD100", Offset = "0x7BFBD00", VA = "0x187BFD100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD560", Offset = "0x7BFC160", VA = "0x187BFD560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct EPIHEIPEKKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<KPAJILEPPBL, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private KPAJILEPPBL <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6FF0", Offset = "0x7BF5BF0", VA = "0x187BF6FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7470", Offset = "0x7BF6070", VA = "0x187BF7470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JIJPPIOBILM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<KPAJILEPPBL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<PNJEPLMEKHI<KPAJILEPPBL, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<HLIBKFCHMNE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB960", Offset = "0x7BFA560", VA = "0x187BFB960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC570", Offset = "0x7BFB170", VA = "0x187BFC570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EBHMACEGAAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<HLIBKFCHMNE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7BF57D0", Offset = "0x7BF43D0", VA = "0x187BF57D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5CF0", Offset = "0x7BF48F0", VA = "0x187BF5CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MGMKNMKLKAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, NDMDKMDKJIB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<MJBJHPLHIEA<List<NDMDKMDKJIB>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE230", Offset = "0x7BFCE30", VA = "0x187BFE230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEBF0", Offset = "0x7BFD7F0", VA = "0x187BFEBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FEODBNNNEIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public EFEKIJMGOMH playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HJGOJJFAMFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<EDOCCPJFFDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private FEODBNNNEIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GDNMNFALBCN awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<JCMFKEKAMGF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9B40", Offset = "0x7BF8740", VA = "0x187BF9B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9F90", Offset = "0x7BF8B90", VA = "0x187BF9F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct DBIOBMEKAIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<DAJAHHKBOCG, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class MKEBEBGCEKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JCMFKEKAMGF result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MKEBEBGCEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEC60", Offset = "0x7BFD860", VA = "0x187BFEC60")]
		internal KBCGMJNCAJE OKMOGFPBILN(DAJAHHKBOCG id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct KCLIJHMDOLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<DAJAHHKBOCG, KBCGMJNCAJE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<DAJAHHKBOCG, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private DBIOBMEKAIJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<KBCGMJNCAJE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC5E0", Offset = "0x7BFB1E0", VA = "0x187BFC5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD090", Offset = "0x7BFBC90", VA = "0x187BFD090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct AGLIHJEIACK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<KBCGMJNCAJE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<DAJAHHKBOCG, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<KBCGMJNCAJE> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<KBCGMJNCAJE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2D90", Offset = "0x7BF1990", VA = "0x187BF2D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3CF0", Offset = "0x7BF28F0", VA = "0x187BF3CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct ECKJMOCPIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<IPBKBDLPABC>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<KGFPJGAIPOP>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<NDMDKMDKJIB>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<ICFPOIIDHAD> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<NBGALKEFGFE> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<EFEKIJMGOMH> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<KPAJILEPPBL> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<IPBKBDLPABC>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<KGFPJGAIPOP>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<NDMDKMDKJIB>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<ICFPOIIDHAD> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5D60", Offset = "0x7BF4960", VA = "0x187BF5D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6F90", Offset = "0x7BF5B90", VA = "0x187BF6F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct LFJLFBIMCLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD5D0", Offset = "0x7BFC1D0", VA = "0x187BFD5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDC60", Offset = "0x7BFC860", VA = "0x187BFDC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct HCMBJFLNHPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public GDNMNFALBCN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7BF95A0", Offset = "0x7BF81A0", VA = "0x187BF95A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9A90", Offset = "0x7BF8690", VA = "0x187BF9A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct LNANJNNPJPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<EDOCCPJFFDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public GDNMNFALBCN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<EDOCCPJFFDH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDCC0", Offset = "0x7BFC8C0", VA = "0x187BFDCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE1C0", Offset = "0x7BFCDC0", VA = "0x187BFE1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct ICJKDKBFNAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public NBGALKEFGFE itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public PFOBHIJJADH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<PNJEPLMEKHI<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA3F0", Offset = "0x7BF8FF0", VA = "0x187BFA3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BFADA0", Offset = "0x7BF99A0", VA = "0x187BFADA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan NBHLJAJGMPD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float MLBEOBJFAJF = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float LLOHDLEHBCA = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int OFFADOAMJMK = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string BPCPHHHCOPH = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string ABAMNIIMMNL = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DECMKADEKIC PFFDNDIHIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly COACFOKIGDG PNMPHCKOBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HAJPKNMJNFM GANDGACFBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly BKMCEGIJGNN DNEAAIAOFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CBBNEHIAGAP GJMGGPBEKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GEDMDAPIAKG BIMBNNABDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CMLMNIGHOGD JMOHGPBLMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KHGEFNHGKAI MFKHBBOGMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly MLDBHEKOOIG AEIKBKFKCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FEKBMKGEAFP EHBPEKMLABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BIEKIMIEHJL FHAJPDGCNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HHHOMBPNEKH GCKGGDEJDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource BGGEJFANJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly BFAKJDJFCLI<DAJAHHKBOCG, KBCGMJNCAJE> MAMAOFBHAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BFAKJDJFCLI<long, NDMDKMDKJIB> DIHNCCLAEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly DMJKLBEHNNO LBLAONGJEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable NHJGMOHDNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task MGKFGPCILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource DCOGMKHPBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long GEIGIIDAKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool EIHBPFOIIHI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private OHLBNJMAGIK DJEEMGGBLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C014A0", Offset = "0x7C000A0", VA = "0x187C014A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NCEKLMPIJLO KDPFKIJMHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xBCAC00", Offset = "0xBC9800", VA = "0x180BCAC00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xBCAC10", Offset = "0xBC9810", VA = "0x180BCAC10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ONIGKBMFFEH<NBGALKEFGFE> GAMBMAHCBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB8FB00", Offset = "0xB8E700", VA = "0x180B8FB00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xF779E0", Offset = "0xF765E0", VA = "0x180F779E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ONIGKBMFFEH<Guid> EEEDHFHMMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB7B030", Offset = "0xB79C30", VA = "0x180B7B030", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBFDA30", Offset = "0xBFC630", VA = "0x180BFDA30", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NFIBJPEHBKM<EFEKIJMGOMH, int> FDCEEKJDEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA44580", Offset = "0xA43180", VA = "0x180A44580", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA441D0", Offset = "0xA42DD0", VA = "0x180A441D0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ONIGKBMFFEH<KPAJILEPPBL> BNCCKJFNBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x95A5D0", Offset = "0x9591D0", VA = "0x18095A5D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x95A5B0", Offset = "0x9591B0", VA = "0x18095A5B0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ONIGKBMFFEH<long> EBGAFBAECKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA48EF0", Offset = "0xA47AF0", VA = "0x180A48EF0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA48D50", Offset = "0xA47950", VA = "0x180A48D50", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NCEKLMPIJLO AGBIFBGEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA621E0", Offset = "0xA60DE0", VA = "0x180A621E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA60750", Offset = "0xA5F350", VA = "0x180A60750", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NCEKLMPIJLO DOINCJCCLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA42760", Offset = "0xA41360", VA = "0x180A42760", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA60770", Offset = "0xA5F370", VA = "0x180A60770", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C04FD0", Offset = "0x7C03BD0", VA = "0x187C04FD0")]
	[DMDJPIBKEJJ.OPKFCOALFMB.IBOCCFBJPBC]
	internal static void OPGDNJLIDJN(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C05A30", Offset = "0x7C04630", VA = "0x187C05A30")]
	[RecRoom.NoEngine.Common.Preserve]
	public PFOBHIJJADH([GJMNBPKNJPO(null)] DECMKADEKIC PFFDNDIHIEO, [GJMNBPKNJPO(null)] COACFOKIGDG PNMPHCKOBLD, [GJMNBPKNJPO(null)] HAJPKNMJNFM GANDGACFBKL, [GJMNBPKNJPO(null)] BKMCEGIJGNN DNEAAIAOFGF, [GJMNBPKNJPO(null)] PHPOLMHKACA HAOEIIPDNFP, [GJMNBPKNJPO(null)] CBBNEHIAGAP GJMGGPBEKHH, [GJMNBPKNJPO(null)] GEDMDAPIAKG BIMBNNABDKG, [GJMNBPKNJPO(null)] FJKILKHDGJP DHJAOBBIJMF, [GJMNBPKNJPO(null)] HJAIGBLACAP LBLNBAOFLJM, [GJMNBPKNJPO(null)] CMLMNIGHOGD JMOHGPBLMLJ, [GJMNBPKNJPO(null)] KHGEFNHGKAI MFKHBBOGMHN, [GJMNBPKNJPO(null)] MLDBHEKOOIG AEIKBKFKCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C00BD0", Offset = "0x7BFF7D0", VA = "0x187C00BD0", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C04420", Offset = "0x7C03020", VA = "0x187C04420", Slot = "52")]
	public Task NAOBNAINPMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C034B0", Offset = "0x7C020B0", VA = "0x187C034B0", Slot = "20")]
	[AsyncStateMachine(typeof(DAKIFGNNPDP))]
	public Task<PNJEPLMEKHI<NBGALKEFGFE, string>> JKFJIBOLLMI(Guid? IHBDKPOCJHF, long EPGJLNEAJPA, string BGKKCEGMOKH, string ICDFHDIHFJG, string KLODGKCHKHL, RoomInventoryItemProperties HBMPGPFHEDM, byte PKCKJCGKEIP, int PFOKHHCFPNE, [Optional] List<long> ECAOGABNGNM, [Optional] List<NDMDKMDKJIB> FKHKPBIFPNN, bool PHFIBKJLMHL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C03A20", Offset = "0x7C02620", VA = "0x187C03A20", Slot = "21")]
	[AsyncStateMachine(typeof(GJFEDJEBPPJ))]
	public Task<PNJEPLMEKHI<NBGALKEFGFE, string>> KCPJAKPBKFN(Guid HPJKPAIMGLO, long EPGJLNEAJPA, [Optional] string BGKKCEGMOKH, [Optional] string ICDFHDIHFJG, [Optional] string KLODGKCHKHL, [Optional] List<long> ECAOGABNGNM, [Optional] Dictionary<string, RoomInventoryTagClientProperties> FKHKPBIFPNN, [Optional] RoomInventoryItemProperties HBMPGPFHEDM, [Optional] byte? PKCKJCGKEIP, [Optional] int? PFOKHHCFPNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFB10", Offset = "0x7BFE710", VA = "0x187BFFB10", Slot = "22")]
	[AsyncStateMachine(typeof(IJBJKDJJKPO))]
	public Task<PNJEPLMEKHI<bool, string>> BJKGGCNNPGJ(Guid HPJKPAIMGLO, long EPGJLNEAJPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C000B0", Offset = "0x7BFECB0", VA = "0x187C000B0", Slot = "23")]
	public IReadOnlyList<NBGALKEFGFE> CJGNJPKEICI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C029B0", Offset = "0x7C015B0", VA = "0x187C029B0", Slot = "24")]
	public IReadOnlyList<NBGALKEFGFE> ICEOJCOIIAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFCB0", Offset = "0x7BFE8B0", VA = "0x187BFFCB0", Slot = "25")]
	public bool BLHEHMPFDDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C02890", Offset = "0x7C01490", VA = "0x187C02890", Slot = "26")]
	public bool IBOEDFKFAGB(Guid HPJKPAIMGLO, [Out] NBGALKEFGFE KFAGJDDMJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C02140", Offset = "0x7C00D40", VA = "0x187C02140", Slot = "27")]
	public bool GJNJOBBGBFG(string GJGGHMFOIEN, [Out] NBGALKEFGFE KFAGJDDMJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C02440", Offset = "0x7C01040", VA = "0x187C02440", Slot = "28")]
	public IReadOnlyList<EFEKIJMGOMH> HFEDHFCOGIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C02760", Offset = "0x7C01360", VA = "0x187C02760", Slot = "29")]
	public bool HMOHBKBECOO(Guid HPJKPAIMGLO, [Out] EFEKIJMGOMH INFMPPDOHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C05040", Offset = "0x7C03C40", VA = "0x187C05040", Slot = "30")]
	public long? PKHCBCLAJBL(Guid HPJKPAIMGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF6B0", Offset = "0x7BFE2B0", VA = "0x187BFF6B0", Slot = "51")]
	public void ALAMAJDCDED(IEnumerable<KGFPJGAIPOP> OGJFLHBJGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C014F0", Offset = "0x7C000F0", VA = "0x187C014F0", Slot = "31")]
	[AsyncStateMachine(typeof(ICCEMCBAPMK))]
	public Task<int> FJCDAPOFKIM(GDNMNFALBCN ECDFLCCNIEO, Guid HPJKPAIMGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C04180", Offset = "0x7C02D80", VA = "0x187C04180", Slot = "32")]
	[AsyncStateMachine(typeof(KODIFCAAMIA))]
	public Task<EDOCCPJFFDH> MJJDFIMMOFH(GDNMNFALBCN BHMDPBLGEAB, Guid HPJKPAIMGLO, int JLCDBIJGLGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C044C0", Offset = "0x7C030C0", VA = "0x187C044C0", Slot = "33")]
	public string NIFGFHLDIBM(JCMFKEKAMGF HBANOBDOKBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFC40", Offset = "0x7BFE840", VA = "0x187BFFC40", Slot = "34")]
	public bool BKJMGJFCCPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C03380", Offset = "0x7C01F80", VA = "0x187C03380", Slot = "38")]
	[AsyncStateMachine(typeof(EPIHEIPEKKK))]
	public Task<PNJEPLMEKHI<KPAJILEPPBL, string>> JGMJNJOKJEH(long DJBLKKOGMIB, RoomInventoryTagClientProperties HBMPGPFHEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C01BA0", Offset = "0x7C007A0", VA = "0x187C01BA0", Slot = "39")]
	[AsyncStateMachine(typeof(JIJPPIOBILM))]
	public Task<PNJEPLMEKHI<bool, string>> GEEBNHEFBKF(long DJBLKKOGMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C00290", Offset = "0x7BFEE90", VA = "0x187C00290", Slot = "42")]
	public List<(long, int)> CMLOKOCPLHA(long JFDILMDGDFH, int KKLFFFEKPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C00790", Offset = "0x7BFF390", VA = "0x187C00790", Slot = "43")]
	public bool CODJKKBLNJK(long DJBLKKOGMIB, [Out] KPAJILEPPBL GHOIDDPCNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C00820", Offset = "0x7BFF420", VA = "0x187C00820", Slot = "44")]
	public bool DBENJOPOCML(string GCONCGDMNLH, [Out] KPAJILEPPBL GHOIDDPCNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C03E40", Offset = "0x7C02A40", VA = "0x187C03E40", Slot = "45")]
	public bool MAMJNNEFNPA(long DJBLKKOGMIB, Guid PAFDNMIFBOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C03D00", Offset = "0x7C02900", VA = "0x187C03D00", Slot = "46")]
	public IReadOnlyList<KPAJILEPPBL> KFALOLNHMDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C02E20", Offset = "0x7C01A20", VA = "0x187C02E20", Slot = "47")]
	public List<KPAJILEPPBL> IEHPKPIBAMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C02FD0", Offset = "0x7C01BD0", VA = "0x187C02FD0", Slot = "48")]
	public IReadOnlyList<KPAJILEPPBL> JFKIAPCAJFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C03670", Offset = "0x7C02270", VA = "0x187C03670", Slot = "41")]
	public bool JLINGOCGECA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BFECD0", Offset = "0x7BFD8D0", VA = "0x187BFECD0", Slot = "49")]
	public IReadOnlyList<NBGALKEFGFE> ACGDPMANDOI(long DJBLKKOGMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C02EB0", Offset = "0x7C01AB0", VA = "0x187C02EB0", Slot = "40")]
	[AsyncStateMachine(typeof(EBHMACEGAAA))]
	public Task<PNJEPLMEKHI<bool, string>> JELDKNEHJEI(long EPGJLNEAJPA, bool MNCEFEPALIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF920", Offset = "0x7BFE520", VA = "0x187BFF920", Slot = "54")]
	public bool BAPFFDIMFGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C016F0", Offset = "0x7C002F0", VA = "0x187C016F0", Slot = "50")]
	public bool FNAAIIGJKOA(string GCONCGDMNLH, [Out] IReadOnlyList<NBGALKEFGFE> HNANCILEINC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF400", Offset = "0x7BFE000", VA = "0x187BFF400")]
	[AsyncStateMachine(typeof(MGMKNMKLKAE))]
	private Task<Dictionary<long, NDMDKMDKJIB>> AHIPPAIKBCN(Dictionary<long, int> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C042D0", Offset = "0x7C02ED0", VA = "0x187C042D0")]
	[AsyncStateMachine(typeof(HJGOJJFAMFD))]
	private Task<EDOCCPJFFDH> MPMDBIEBCOC(Guid HPJKPAIMGLO, int JLCDBIJGLGB, [Optional] Guid OCBGLEJDAOE, [Optional] GDNMNFALBCN BIAEFCFJBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C02620", Offset = "0x7C01220", VA = "0x187C02620")]
	[AsyncStateMachine(typeof(KCLIJHMDOLB))]
	private Task<Dictionary<DAJAHHKBOCG, KBCGMJNCAJE>> HHIFGEAPIGO(Dictionary<DAJAHHKBOCG, int> BJAKLFJFIAL, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C009C0", Offset = "0x7BFF5C0", VA = "0x187C009C0")]
	[AsyncStateMachine(typeof(AGLIHJEIACK))]
	private Task<List<KBCGMJNCAJE>> DIMEOCHNHMG(Dictionary<DAJAHHKBOCG, int> BJAKLFJFIAL, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C00160", Offset = "0x7BFED60", VA = "0x187C00160")]
	[AsyncStateMachine(typeof(ECKJMOCPIKF))]
	private Task CMEELBFBPBD(long EPGJLNEAJPA, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C04800", Offset = "0x7C03400", VA = "0x187C04800")]
	private Task NMNLBDNLABP(DFAGOCGJMME IGPONJDPFGI, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C00B00", Offset = "0x7BFF700", VA = "0x187C00B00")]
	[AsyncStateMachine(typeof(LFJLFBIMCLE))]
	private Task DKPBNGCKMMK(DFAGOCGJMME IGPONJDPFGI, CancellationToken OFMCKICCEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C01380", Offset = "0x7BFFF80", VA = "0x187C01380")]
	private void FAEMHJJGGPA(IPBKBDLPABC EAKHAPPPMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C05510", Offset = "0x7C04110", VA = "0x187C05510")]
	[AJPIJFNMHAB]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string MAEIFLOLEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF990", Offset = "0x7BFE590", VA = "0x187BFF990")]
	private void BGOMGHAAOCF(Guid HPJKPAIMGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C05650", Offset = "0x7C04250", VA = "0x187C05650")]
	[AJPIJFNMHAB]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid HPJKPAIMGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C00DF0", Offset = "0x7BFF9F0", VA = "0x187C00DF0")]
	[AsyncStateMachine(typeof(HCMBJFLNHPI))]
	private Task<int> ECCCPDOBHKF(GDNMNFALBCN ECDFLCCNIEO, Guid HPJKPAIMGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C05320", Offset = "0x7C03F20", VA = "0x187C05320")]
	[AJPIJFNMHAB]
	internal void RpcGetPlayerRoomInventoryCount(Guid HBKGJHPGIDP, Guid HPJKPAIMGLO, DEDCJILHDPB FCIAFOBBBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C052A0", Offset = "0x7C03EA0", VA = "0x187C052A0")]
	[AJPIJFNMHAB]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid HBKGJHPGIDP, int EBDKDADIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C04E10", Offset = "0x7C03A10", VA = "0x187C04E10")]
	[AsyncStateMachine(typeof(LNANJNNPJPL))]
	private Task<EDOCCPJFFDH> OOPEPCOGDIG(GDNMNFALBCN ECDFLCCNIEO, Guid HPJKPAIMGLO, int JLCDBIJGLGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C051D0", Offset = "0x7C03DD0", VA = "0x187C051D0")]
	[AJPIJFNMHAB]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid HBKGJHPGIDP, Guid HPJKPAIMGLO, int JLCDBIJGLGB, DEDCJILHDPB FCIAFOBBBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C02C60", Offset = "0x7C01860", VA = "0x187C02C60")]
	private void ICNDJPIGKLO(GDNMNFALBCN BHMDPBLGEAB, Guid HBKGJHPGIDP, JCMFKEKAMGF HBANOBDOKBJ, long FJBDJGHNODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C05900", Offset = "0x7C04500", VA = "0x187C05900")]
	[AJPIJFNMHAB]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid HBKGJHPGIDP, int HBANOBDOKBJ, long FJBDJGHNODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF540", Offset = "0x7BFE140", VA = "0x187BFF540")]
	private void AIEEFONHIIN(bool MNCEFEPALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C058A0", Offset = "0x7C044A0", VA = "0x187C058A0")]
	[AJPIJFNMHAB]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool BMHEBOBBNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C03BE0", Offset = "0x7C027E0", VA = "0x187C03BE0")]
	private void KEDBILNBADL(List<NDMDKMDKJIB> ENODDAMOPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C056F0", Offset = "0x7C042F0", VA = "0x187C056F0")]
	[AJPIJFNMHAB]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string JCEIJFAPAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C04690", Offset = "0x7C03290", VA = "0x187C04690")]
	private void NMDLMCNCDOA(long DJBLKKOGMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C05680", Offset = "0x7C04280", VA = "0x187C05680")]
	[AJPIJFNMHAB]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long DJBLKKOGMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C00570", Offset = "0x7BFF170", VA = "0x187C00570")]
	private NBGALKEFGFE CNEPKEMKLOE(IPBKBDLPABC EAKHAPPPMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C02260", Offset = "0x7C00E60", VA = "0x187C02260")]
	private List<KPAJILEPPBL> HEDNOKJGEKF(List<NDMDKMDKJIB> ENODDAMOPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C01DF0", Offset = "0x7C009F0", VA = "0x187C01DF0")]
	private List<KPAJILEPPBL> GHPCCACNCPC(IEnumerable<NDMDKMDKJIB> ENODDAMOPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEFB0", Offset = "0x7BFDBB0", VA = "0x187BFEFB0", Slot = "36")]
	public RoomInventoryItemProperties AHAEBKBFGCN(string DJHLIFPJNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C036F0", Offset = "0x7C022F0", VA = "0x187C036F0")]
	private NBGALKEFGFE JLKIGHPINGP(IPBKBDLPABC EAKHAPPPMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C04040", Offset = "0x7C02C40", VA = "0x187C04040", Slot = "35")]
	public IPBKBDLPABC MHIOFPDFJBK(NBGALKEFGFE GHAEIIBBFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFE20", Offset = "0x7BFEA20", VA = "0x187BFFE20")]
	private KPAJILEPPBL CBBGCHKDLAH(NDMDKMDKJIB EAKHAPPPMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7C03DD0", Offset = "0x7C029D0", VA = "0x187C03DD0")]
	private void KMLCPEJPHDO(EFEKIJMGOMH INFMPPDOHJK, int ALHHAFLDHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFDB0", Offset = "0x7BFE9B0", VA = "0x187BFFDB0")]
	private void BNMIMPNCLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C03890", Offset = "0x7C02490", VA = "0x187C03890")]
	private Task JPJOMMOPDKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C04F60", Offset = "0x7C03B60", VA = "0x187C04F60")]
	private void OPBMIJMAALM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C01630", Offset = "0x7C00230", VA = "0x187C01630")]
	private void FKDNKPBFDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C01CE0", Offset = "0x7C008E0", VA = "0x187C01CE0")]
	private void GHGNEDAJPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C008B0", Offset = "0x7BFF4B0", VA = "0x187C008B0")]
	[AsyncStateMachine(typeof(ICJKDKBFNAB))]
	private Task DEICFCAFJOB(NBGALKEFGFE NAHGEEBNFJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C01CC0", Offset = "0x7C008C0", VA = "0x187C01CC0")]
	[CompilerGenerated]
	private void GHBNFCIDCFG(Task<TaskStatus> LFJIOJDNNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C00F30", Offset = "0x7BFFB30", VA = "0x187C00F30")]
	[CompilerGenerated]
	private Task<JCMFKEKAMGF> EOHBDLODNKE(FEODBNNNEIG P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C04C50", Offset = "0x7C03850", VA = "0x187C04C50")]
	[CompilerGenerated]
	internal static Dictionary<DAJAHHKBOCG, KBCGMJNCAJE> OMPDIMHGBEL(JCMFKEKAMGF HBANOBDOKBJ, DBIOBMEKAIJ P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HHHOMBPNEKH : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF9B00", Offset = "0x7BF8700", VA = "0x187BF9B00")]
	public HHHOMBPNEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HJAIGBLACAP
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FEKBMKGEAFP CHGKPBFJEKO();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HHHOMBPNEKH KAMDDJAPPAK();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BIEKIMIEHJL DGOHCABCBDP();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IMEFEIPAIIA : HJAIGBLACAP
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB8F0", Offset = "0x7BFA4F0", VA = "0x187BFB8F0")]
	[DMDJPIBKEJJ.OPKFCOALFMB.IBOCCFBJPBC]
	internal static void OPGDNJLIDJN(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	[RecRoom.NoEngine.Common.Preserve]
	public IMEFEIPAIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB680", Offset = "0x7BFA280", VA = "0x187BFB680", Slot = "4")]
	public FEKBMKGEAFP CHGKPBFJEKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB880", Offset = "0x7BFA480", VA = "0x187BFB880", Slot = "5")]
	public HHHOMBPNEKH KAMDDJAPPAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB790", Offset = "0x7BFA390", VA = "0x187BFB790", Slot = "6")]
	public BIEKIMIEHJL DGOHCABCBDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BIEKIMIEHJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, KPAJILEPPBL> AOCHDLCPKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly KPAJILEPPBL[] OGPKDFCIANE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FFHPGPEPHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB435D0", Offset = "0xB421D0", VA = "0x180B435D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB43A50", Offset = "0xB42650", VA = "0x180B43A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KPAKHLPBJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4CE0", Offset = "0x7BF38E0", VA = "0x187BF4CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long BLOOOFNLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x95CF10", Offset = "0x95BB10", VA = "0x18095CF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4530", Offset = "0x7BF3130", VA = "0x187BF4530")]
	public void JIMIMLHDOMO(long EPGJLNEAJPA, IEnumerable<KPAJILEPPBL> AJOBKLGCIIG, bool OGCGOLHOGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4B30", Offset = "0x7BF3730", VA = "0x187BF4B30")]
	public IReadOnlyList<KPAJILEPPBL> MDHPLJDGEEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xB43A50", Offset = "0xB42650", VA = "0x180B43A50")]
	public void FODAEOADLKG(bool MNCEFEPALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF40E0", Offset = "0x7BF2CE0", VA = "0x187BF40E0")]
	public bool DGCAOHNNGLK(long DJBLKKOGMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4370", Offset = "0x7BF2F70", VA = "0x187BF4370")]
	public bool JBFGHNBCMNG(KPAJILEPPBL KHGHJKGJEFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3D60", Offset = "0x7BF2960", VA = "0x187BF3D60")]
	public bool ABLIKGLJIEP(List<KPAJILEPPBL> NBAMACILCLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4D40", Offset = "0x7BF3940", VA = "0x187BF4D40")]
	public bool NOMKHIADNKK(long DJBLKKOGMIB, [Out] KPAJILEPPBL PPIKKIDENAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BF41C0", Offset = "0x7BF2DC0", VA = "0x187BF41C0")]
	public bool EDOILCGDHDJ(string BGKKCEGMOKH, [Out] KPAJILEPPBL PPIKKIDENAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4DE0", Offset = "0x7BF39E0", VA = "0x187BF4DE0")]
	public List<KPAJILEPPBL> OAJBEDCODAP(int BIEEMEKMINN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BF49F0", Offset = "0x7BF35F0", VA = "0x187BF49F0")]
	public List<KPAJILEPPBL> KPBEJPNDHAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x76C0470", Offset = "0x76BF070", VA = "0x1876C0470")]
	public KPAJILEPPBL EIMBKFALKFB(int BIEEMEKMINN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4080", Offset = "0x7BF2C80", VA = "0x187BF4080")]
	public IReadOnlyList<KPAJILEPPBL> AFNHBIHGDNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4EB0", Offset = "0x7BF3AB0", VA = "0x187BF4EB0")]
	public BIEKIMIEHJL()
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
