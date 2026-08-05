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
		[Cpp2IlInjected.Address(RVA = "0x8956690", Offset = "0x8955290", VA = "0x188956690", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KJCOJBAKLHM : KJJDDKJPFHA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OKGEHAKIINA GNOANOGJLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public class HOGDJDDAMGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Dictionary<Guid, GNPMFEGHFID> IHGEBFAMHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<string, GNPMFEGHFID> GPDJCCAMDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool? BJLKEBMAKGJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long LJEFHIMJIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA5B660", Offset = "0xA5A260", VA = "0x180A5B660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GNPMFEGHFID KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8949540", Offset = "0x8948140", VA = "0x188949540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8949970", Offset = "0x8948570", VA = "0x188949970")]
	public void PKJBHLHOEAP(long MJILNJAJHOI, IEnumerable<OLMGLKDOPPH> OMKGMPBBILF, IEnumerable<JNFENIPJPAA> ADDHOACHFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8948D70", Offset = "0x8947970", VA = "0x188948D70")]
	public bool BPJPIOFDHNP(Guid DCJGAKOBLDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8948E70", Offset = "0x8947A70", VA = "0x188948E70")]
	public bool ENKPLOICKCM(Guid DCJGAKOBLDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8949740", Offset = "0x8948340", VA = "0x188949740")]
	public bool PCOIKOEBPMO(OLMGLKDOPPH FHKENJEEGDN, [Out] OLMGLKDOPPH DCCOFFLBJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8949640", Offset = "0x8948240", VA = "0x188949640")]
	public IEnumerable<GNPMFEGHFID> NFOOIPDANOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8949370", Offset = "0x8947F70", VA = "0x188949370")]
	public IEnumerable<OLMGLKDOPPH> JKGIPEMMDAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8948C20", Offset = "0x8947820", VA = "0x188948C20")]
	public IEnumerable<JNFENIPJPAA> BMDMBJFCOHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x89488A0", Offset = "0x89474A0", VA = "0x1889488A0")]
	public bool AGHBPNOMDNE(Guid DCJGAKOBLDI, [Out] OLMGLKDOPPH ILCCGAGKJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8948DD0", Offset = "0x89479D0", VA = "0x188948DD0")]
	public bool CCOIGDMILOM(string AOELBOGOHHL, [Out] OLMGLKDOPPH ILCCGAGKJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8949690", Offset = "0x8948290", VA = "0x188949690")]
	public bool OLMJBEJCKMP(Guid DCJGAKOBLDI, [Out] JNFENIPJPAA NLGEGHONOIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x89495A0", Offset = "0x89481A0", VA = "0x1889495A0")]
	public bool KFNKNJFGLBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x89494C0", Offset = "0x89480C0", VA = "0x1889494C0")]
	private bool JPFCLLNFCON(OLMGLKDOPPH CBMDPCIEEMO, OLMGLKDOPPH GFFLPNHOMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8948E90", Offset = "0x8947A90", VA = "0x188948E90")]
	private void GCEFLBEPIOE(Guid LCCBBMBENOH, GNPMFEGHFID FDLBHMHAJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x89490E0", Offset = "0x8947CE0", VA = "0x1889490E0")]
	private bool GOPDJGGPDDF(Guid LCCBBMBENOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8948950", Offset = "0x8947550", VA = "0x188948950")]
	private void AGLAPKLDLPB(OLMGLKDOPPH OGPFMJCLIIP, [Optional] OLMGLKDOPPH PCBMAIABHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8948A40", Offset = "0x8947640", VA = "0x188948A40")]
	private bool ALJOPDEGEHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8949330", Offset = "0x8947F30", VA = "0x188949330")]
	private static bool JEPIBNGHLAP(OLMGLKDOPPH BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8949FE0", Offset = "0x8948BE0", VA = "0x188949FE0")]
	public HOGDJDDAMGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OKGEHAKIINA : ODFMBKELPND, JNBBEJADKIF, IDisposable, LPNKHPBOEKG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct MJEAPLMCEHB : IEquatable<MJEAPLMCEHB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public long LJEFHIMJIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid DHGLJJEANPM;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5449690", Offset = "0x5448290", VA = "0x185449690")]
		public MJEAPLMCEHB(long MJILNJAJHOI, Guid DCJGAKOBLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x894C850", Offset = "0x894B450", VA = "0x18894C850", Slot = "4")]
		public bool Equals(MJEAPLMCEHB IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x894C6F0", Offset = "0x894B2F0", VA = "0x18894C6F0", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x894C950", Offset = "0x894B550", VA = "0x18894C950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BFHOGAAIHDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<OLMGLKDOPPH, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public OKGEHAKIINA <>4__this;

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
		public List<FCMKODHNMGC> newTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<FPFJIDNHIOL<MKMCMCGHMFA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8943B10", Offset = "0x8942710", VA = "0x188943B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8944020", Offset = "0x8942C20", VA = "0x188944020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LHLFOCKHBCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<OLMGLKDOPPH, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public OKGEHAKIINA <>4__this;

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
		private TaskAwaiter<FPFJIDNHIOL<MKMCMCGHMFA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x894BE30", Offset = "0x894AA30", VA = "0x18894BE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x894C680", Offset = "0x894B280", VA = "0x18894C680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JNIFHNHPALB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private OLMGLKDOPPH <itemToDelete>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private LHNADKNCFMA <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<LHNADKNCFMA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x894B2D0", Offset = "0x8949ED0", VA = "0x18894B2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x894BAE0", Offset = "0x894A6E0", VA = "0x18894BAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HKCKECJCMGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public PLCCGHEKGIM player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x89484B0", Offset = "0x89470B0", VA = "0x1889484B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8948830", Offset = "0x8947430", VA = "0x188948830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FIMMEFHCCKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<DMNDFJOEFMG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public PLCCGHEKGIM recipient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<DMNDFJOEFMG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8945AC0", Offset = "0x89446C0", VA = "0x188945AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8945F20", Offset = "0x8944B20", VA = "0x188945F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct CFLJNEIKDHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<HOLCEPMNIPA, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public RoomInventoryTagClientProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private HOLCEPMNIPA <newTag>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8944090", Offset = "0x8942C90", VA = "0x188944090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8944510", Offset = "0x8943110", VA = "0x188944510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct AOMNGBNABFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long tagId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<HOLCEPMNIPA>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<IADHIMOENNN<HOLCEPMNIPA, string>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<LHNADKNCFMA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8942E90", Offset = "0x8941A90", VA = "0x188942E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8943AA0", Offset = "0x89426A0", VA = "0x188943AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NBDAINAMGKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool isEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<LHNADKNCFMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x894CF40", Offset = "0x894BB40", VA = "0x18894CF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x894D460", Offset = "0x894C060", VA = "0x18894D460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GJIJMOCHAAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Dictionary<long, FCMKODHNMGC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Dictionary<long, int> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<FPFJIDNHIOL<List<FCMKODHNMGC>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8947320", Offset = "0x8945F20", VA = "0x188947320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8947D50", Offset = "0x8946950", VA = "0x188947D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NHFKPFKKBIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JNFENIPJPAA playerRoomInventoryItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int quantity;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ACLAFBOONLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<DMNDFJOEFMG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private NHFKPFKKBIM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PLCCGHEKGIM awardingPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Guid remoteOperationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<DGOCBGKBGHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x89429D0", Offset = "0x89415D0", VA = "0x1889429D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8942E20", Offset = "0x8941A20", VA = "0x188942E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct BHOJIEAKONM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Dictionary<MJEAPLMCEHB, int> idsAndQuantities;
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FPIABHNDGMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DGOCBGKBGHO result;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FPIABHNDGMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8945F90", Offset = "0x8944B90", VA = "0x188945F90")]
		internal IALOLJKMMOC PHLIADFACFC(MJEAPLMCEHB id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PLLCPJCKGBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Dictionary<MJEAPLMCEHB, IALOLJKMMOC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<MJEAPLMCEHB, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private BHOJIEAKONM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<List<IALOLJKMMOC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x89558D0", Offset = "0x89544D0", VA = "0x1889558D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x89563A0", Offset = "0x8954FA0", VA = "0x1889563A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct DMOMBFJOGJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<List<IALOLJKMMOC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Dictionary<MJEAPLMCEHB, int> idsAndQuantities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<IALOLJKMMOC> <results>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<List<IALOLJKMMOC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8944580", Offset = "0x8943180", VA = "0x188944580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89454F0", Offset = "0x89440F0", VA = "0x1889454F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FPIBIFMMGJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task<List<MKMCMCGHMFA>> <roomInventoryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Task<List<OMBKJEIDKBE>> <playerRoomInventoryTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<List<FCMKODHNMGC>> <roomInventoryTagsTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<NJMKJJMJMPG> <roomConfigsTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerable<OLMGLKDOPPH> <roomInventoryItems>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerable<JNFENIPJPAA> <playerRoomInventoryItems>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<HOLCEPMNIPA> <roomInventoryTags>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<List<MKMCMCGHMFA>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<List<OMBKJEIDKBE>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<FCMKODHNMGC>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<NJMKJJMJMPG> <>u__5;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8946000", Offset = "0x8944C00", VA = "0x188946000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x89472C0", Offset = "0x8945EC0", VA = "0x1889472C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HCODPACAOMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8947DC0", Offset = "0x89469C0", VA = "0x188947DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8948450", Offset = "0x8947050", VA = "0x188948450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct EILLBAKJEEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public PLCCGHEKGIM player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8945560", Offset = "0x8944160", VA = "0x188945560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8945A50", Offset = "0x8944650", VA = "0x188945A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MLHPEFKJOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<DMNDFJOEFMG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public PLCCGHEKGIM player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<DMNDFJOEFMG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x894C9D0", Offset = "0x894B5D0", VA = "0x18894C9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x894CED0", Offset = "0x894BAD0", VA = "0x18894CED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct OMOMPFPPEFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OLMGLKDOPPH itemToDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public OKGEHAKIINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<long, bool>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<IADHIMOENNN<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8954EC0", Offset = "0x8953AC0", VA = "0x188954EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8955870", Offset = "0x8954470", VA = "0x188955870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly TimeSpan FBBJIHFGJCL;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float IGCOIKCEIEA = 10f;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const float NDOJKCDJFLD = 3f;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const int IOCMBMDHPIE = 3;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal const string LHHOOEFBOJA = "econ_room_inventory_gate";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal const string NABMMNKLIDM = "experiences_room_inventory_tags_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AJLFHEJMOHI NKDDCNGCLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly HNCNHNOBOID PCEJLFAOJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MMHDHIBPAEB FGMMMJPHJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly DKCBALPBFPJ KCJJOBEKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HNMFEIOHHML MIHACEDCKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KJCOJBAKLHM EFOBBDPFICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PEHHKHACOAC MBMIIEAOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly BDNPFMGHGFL FNNNGCOPCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EONKNFHOAOJ HGGBKAENIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HOGDJDDAMGN IDBBALJPGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IILIPOLGAJC JJMFFIJPJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NIKJLPIIDNF EPEJDMJCBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationTokenSource IBCLCNFBHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly NAEGAFKDEDG<MJEAPLMCEHB, IALOLJKMMOC> PNIFMDLMDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NAEGAFKDEDG<long, FCMKODHNMGC> BDDJKNOJNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HBIOCJJJMKB LPANHLPGFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IDisposable KAMMPJEEFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Task LAGJPIIFMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CancellationTokenSource INIEMHHNIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private long FCCANEKBLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool BNHFKKOIPKI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private CHCMEDNOJAJ AAFHGAGLEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8951CE0", Offset = "0x89508E0", VA = "0x188951CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LKKDMOCNJPN HKDIKEKOFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE62030", Offset = "0xE60C30", VA = "0x180E62030", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE62040", Offset = "0xE60C40", VA = "0x180E62040", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GFJLLHFJBHN<OLMGLKDOPPH> AGGIDHBFPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB0C830", Offset = "0xB0B430", VA = "0x180B0C830", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB31C90", Offset = "0xB30890", VA = "0x180B31C90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GFJLLHFJBHN<Guid> ENOOJPKMGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA20", Offset = "0xB0B620", VA = "0x180B0CA20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB0C620", Offset = "0xB0B220", VA = "0x180B0C620", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KLPJLNGNINA<JNFENIPJPAA, int> NOMDCKHMDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAD4CE0", Offset = "0xAD38E0", VA = "0x180AD4CE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAD8320", Offset = "0xAD6F20", VA = "0x180AD8320", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GFJLLHFJBHN<HOLCEPMNIPA> IMECEPGIKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA65C50", Offset = "0xA64850", VA = "0x180A65C50", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA65C10", Offset = "0xA64810", VA = "0x180A65C10", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GFJLLHFJBHN<long> GJDPFNPPGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAD89D0", Offset = "0xAD75D0", VA = "0x180AD89D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAD7CA0", Offset = "0xAD68A0", VA = "0x180AD7CA0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LKKDMOCNJPN OPELFHEFHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAD89C0", Offset = "0xAD75C0", VA = "0x180AD89C0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAD8350", Offset = "0xAD6F50", VA = "0x180AD8350", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LKKDMOCNJPN ENDHIIFJJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAD34F0", Offset = "0xAD20F0", VA = "0x180AD34F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAD3210", Offset = "0xAD1E10", VA = "0x180AD3210", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x89519D0", Offset = "0x89505D0", VA = "0x1889519D0")]
	[HHMPGEJNNFC.LMFNECDEKKH.PMAKKEDIOOO]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8954330", Offset = "0x8952F30", VA = "0x188954330")]
	[RecRoom.NoEngine.Common.Preserve]
	public OKGEHAKIINA([HAKCNCGPHPD(null)] AJLFHEJMOHI NKDDCNGCLNL, [HAKCNCGPHPD(null)] HNCNHNOBOID PCEJLFAOJBP, [HAKCNCGPHPD(null)] MMHDHIBPAEB FGMMMJPHJDF, [HAKCNCGPHPD(null)] DKCBALPBFPJ KCJJOBEKAGG, [HAKCNCGPHPD(null)] CGIGLIONEGJ GIPGNPNHAHB, [HAKCNCGPHPD(null)] HNMFEIOHHML MIHACEDCKKO, [HAKCNCGPHPD(null)] KJCOJBAKLHM EFOBBDPFICA, [HAKCNCGPHPD(null)] OPHEJEMNBEK IKKDFNNDANH, [HAKCNCGPHPD(null)] IABOMHCDMGN JFHMAOJHJCH, [HAKCNCGPHPD(null)] PEHHKHACOAC MBMIIEAOJOA, [HAKCNCGPHPD(null)] BDNPFMGHGFL FNNNGCOPCIC, [HAKCNCGPHPD(null)] EONKNFHOAOJ HGGBKAENIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x894EC60", Offset = "0x894D860", VA = "0x18894EC60", Slot = "53")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x894F8F0", Offset = "0x894E4F0", VA = "0x18894F8F0", Slot = "52")]
	public Task FMEIELMKIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8951AB0", Offset = "0x89506B0", VA = "0x188951AB0", Slot = "20")]
	[AsyncStateMachine(typeof(BFHOGAAIHDC))]
	public Task<IADHIMOENNN<OLMGLKDOPPH, string>> LDOPGGGFDNK(Guid? EKMNPJDLCJD, long MJILNJAJHOI, string BKILENEPEEB, string JKEAHMPNEHK, string HIGFGBDCIBL, RoomInventoryItemProperties FDEACFJBFDB, byte MIEJLCKINFM, int MGBNCENPLKH, [Optional] List<long> NNBEIANLBFH, [Optional] List<FCMKODHNMGC> HPLJJKAIIDL, bool DIEONCAMKNG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x894F730", Offset = "0x894E330", VA = "0x18894F730", Slot = "21")]
	[AsyncStateMachine(typeof(LHLFOCKHBCN))]
	public Task<IADHIMOENNN<OLMGLKDOPPH, string>> ENAFEICODFI(Guid DCJGAKOBLDI, long MJILNJAJHOI, [Optional] string BKILENEPEEB, [Optional] string JKEAHMPNEHK, [Optional] string HIGFGBDCIBL, [Optional] List<long> NNBEIANLBFH, [Optional] Dictionary<string, RoomInventoryTagClientProperties> HPLJJKAIIDL, [Optional] RoomInventoryItemProperties FDEACFJBFDB, [Optional] byte? MIEJLCKINFM, [Optional] int? MGBNCENPLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x894DBD0", Offset = "0x894C7D0", VA = "0x18894DBD0", Slot = "22")]
	[AsyncStateMachine(typeof(JNIFHNHPALB))]
	public Task<IADHIMOENNN<bool, string>> AOIJHPEANAE(Guid DCJGAKOBLDI, long MJILNJAJHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x89536A0", Offset = "0x89522A0", VA = "0x1889536A0", Slot = "23")]
	public IReadOnlyList<OLMGLKDOPPH> PABBJLDCHML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x89500D0", Offset = "0x894ECD0", VA = "0x1889500D0", Slot = "24")]
	public IReadOnlyList<OLMGLKDOPPH> HIDDONIFECM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x894DD00", Offset = "0x894C900", VA = "0x18894DD00", Slot = "25")]
	public bool BBAKMCPDLPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x894D680", Offset = "0x894C280", VA = "0x18894D680", Slot = "26")]
	public bool AGHBPNOMDNE(Guid DCJGAKOBLDI, [Out] OLMGLKDOPPH ILCCGAGKJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x894E3A0", Offset = "0x894CFA0", VA = "0x18894E3A0", Slot = "27")]
	public bool CCOIGDMILOM(string HCJFMMJGNCC, [Out] OLMGLKDOPPH ILCCGAGKJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x894D7A0", Offset = "0x894C3A0", VA = "0x18894D7A0", Slot = "28")]
	public IReadOnlyList<JNFENIPJPAA> AHLNJGLAMKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8953570", Offset = "0x8952170", VA = "0x188953570", Slot = "29")]
	public bool OLMJBEJCKMP(Guid DCJGAKOBLDI, [Out] JNFENIPJPAA NLGEGHONOIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x89533E0", Offset = "0x8951FE0", VA = "0x1889533E0", Slot = "30")]
	public long? NPCPAAMAHCA(Guid DCJGAKOBLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x894E600", Offset = "0x894D200", VA = "0x18894E600", Slot = "51")]
	public void CNDEPEIFPOI(IEnumerable<OMBKJEIDKBE> ADDHOACHFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x894EB00", Offset = "0x894D700", VA = "0x18894EB00", Slot = "31")]
	[AsyncStateMachine(typeof(HKCKECJCMGE))]
	public Task<int> DNGHKCAKHMP(PLCCGHEKGIM FANAFCDPEEP, Guid DCJGAKOBLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x89515B0", Offset = "0x89501B0", VA = "0x1889515B0", Slot = "32")]
	[AsyncStateMachine(typeof(FIMMEFHCCKC))]
	public Task<DMNDFJOEFMG> KBNKKPNJPAB(PLCCGHEKGIM NNMFFMMOEKL, Guid DCJGAKOBLDI, int KHGDCKMEAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8952DB0", Offset = "0x89519B0", VA = "0x188952DB0", Slot = "33")]
	public string NGDDEODIBDD(DGOCBGKBGHO ABEFNIJCBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x894FC00", Offset = "0x894E800", VA = "0x18894FC00", Slot = "34")]
	public bool GLJNKECLOED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8952C10", Offset = "0x8951810", VA = "0x188952C10", Slot = "38")]
	[AsyncStateMachine(typeof(CFLJNEIKDHP))]
	public Task<IADHIMOENNN<HOLCEPMNIPA, string>> NCICFIALJAP(long CAPFGBOGLBC, RoomInventoryTagClientProperties FDEACFJBFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x894DAB0", Offset = "0x894C6B0", VA = "0x18894DAB0", Slot = "39")]
	[AsyncStateMachine(typeof(AOMNGBNABFC))]
	public Task<IADHIMOENNN<bool, string>> AOAMJFJIFNK(long CAPFGBOGLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x894FDF0", Offset = "0x894E9F0", VA = "0x18894FDF0", Slot = "42")]
	public List<(long, int)> HCGHMOHPKDG(long PJOBJMACPEM, int NBKHKEBLEJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x894DE00", Offset = "0x894CA00", VA = "0x18894DE00", Slot = "43")]
	public bool BCOPBCCICNF(long CAPFGBOGLBC, [Out] HOLCEPMNIPA GCEDLKILLFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8952B80", Offset = "0x8951780", VA = "0x188952B80", Slot = "44")]
	public bool NBBBFHBHKJO(string MFJFANOKCNC, [Out] HOLCEPMNIPA GCEDLKILLFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8950DF0", Offset = "0x894F9F0", VA = "0x188950DF0", Slot = "45")]
	public bool IOHKLOHAGOP(long CAPFGBOGLBC, Guid BDJBGHLAPPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8951D30", Offset = "0x8950930", VA = "0x188951D30", Slot = "46")]
	public IReadOnlyList<HOLCEPMNIPA> LMKNFIABGCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x894EFC0", Offset = "0x894DBC0", VA = "0x18894EFC0", Slot = "47")]
	public List<HOLCEPMNIPA> EIOEPJHHEIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x89508F0", Offset = "0x894F4F0", VA = "0x1889508F0", Slot = "48")]
	public IReadOnlyList<HOLCEPMNIPA> IMJFICEEANG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x894DE90", Offset = "0x894CA90", VA = "0x18894DE90", Slot = "41")]
	public bool BDBEOFDCMMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8951E00", Offset = "0x8950A00", VA = "0x188951E00", Slot = "49")]
	public IReadOnlyList<OLMGLKDOPPH> LPMJNGBAPIO(long CAPFGBOGLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x89507D0", Offset = "0x894F3D0", VA = "0x1889507D0", Slot = "40")]
	[AsyncStateMachine(typeof(NBDAINAMGKM))]
	public Task<IADHIMOENNN<bool, string>> IMCNFFDEDFP(long MJILNJAJHOI, bool LIJLDHJAPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8951C70", Offset = "0x8950870", VA = "0x188951C70", Slot = "54")]
	public bool LEEGJKDGGGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8951100", Offset = "0x894FD00", VA = "0x188951100", Slot = "50")]
	public bool JJENNCFKHJM(string MFJFANOKCNC, [Out] IReadOnlyList<OLMGLKDOPPH> EOCGELLODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8950690", Offset = "0x894F290", VA = "0x188950690")]
	[AsyncStateMachine(typeof(GJIJMOCHAAP))]
	private Task<Dictionary<long, FCMKODHNMGC>> IBHGCBBAIEM(Dictionary<long, int> BJKHAGFNLGH, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x894E9B0", Offset = "0x894D5B0", VA = "0x18894E9B0")]
	[AsyncStateMachine(typeof(ACLAFBOONLB))]
	private Task<DMNDFJOEFMG> DFIHDNGHGHG(Guid DCJGAKOBLDI, int KHGDCKMEAJM, [Optional] Guid ELDEEHNPGDG, [Optional] PLCCGHEKGIM BNDPBPEIFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x894E4C0", Offset = "0x894D0C0", VA = "0x18894E4C0")]
	[AsyncStateMachine(typeof(PLLCPJCKGBP))]
	private Task<Dictionary<MJEAPLMCEHB, IALOLJKMMOC>> CGEJBJBECFN(Dictionary<MJEAPLMCEHB, int> JHHNIDHMPKI, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x894FA50", Offset = "0x894E650", VA = "0x18894FA50")]
	[AsyncStateMachine(typeof(DMOMBFJOGJB))]
	private Task<List<IALOLJKMMOC>> GALOMCFPGLJ(Dictionary<MJEAPLMCEHB, int> JHHNIDHMPKI, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x894DF10", Offset = "0x894CB10", VA = "0x18894DF10")]
	[AsyncStateMachine(typeof(FPIBIFMMGJB))]
	private Task BHKBDAGKFMP(long MJILNJAJHOI, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8952F80", Offset = "0x8951B80", VA = "0x188952F80")]
	private Task NLBBCMPGNBN(KMDFPIFPLDI AHEPAEIEJIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x89503A0", Offset = "0x894EFA0", VA = "0x1889503A0")]
	[AsyncStateMachine(typeof(HCODPACAOMJ))]
	private Task HIGCJDHLBHO(KMDFPIFPLDI AHEPAEIEJIO, CancellationToken NCLFLKBAEJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8952610", Offset = "0x8951210", VA = "0x188952610")]
	private void MPJCDMDPBON(MKMCMCGHMFA IGHCOOABBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8953E10", Offset = "0x8952A10", VA = "0x188953E10")]
	[LGDDHCFHIFD]
	private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string PIBIPHOHILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x894FC70", Offset = "0x894E870", VA = "0x18894FC70")]
	private void GMJILGBBCFM(Guid DCJGAKOBLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8953F50", Offset = "0x8952B50", VA = "0x188953F50")]
	[LGDDHCFHIFD]
	private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid DCJGAKOBLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x894EE80", Offset = "0x894DA80", VA = "0x18894EE80")]
	[AsyncStateMachine(typeof(EILLBAKJEEG))]
	private Task<int> EGMKAKILBHJ(PLCCGHEKGIM FANAFCDPEEP, Guid DCJGAKOBLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8953C20", Offset = "0x8952820", VA = "0x188953C20")]
	[LGDDHCFHIFD]
	internal void RpcGetPlayerRoomInventoryCount(Guid JKLGJDFLIGN, Guid DCJGAKOBLDI, OJPNDDCHNHP ACLFBNHJPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8953BA0", Offset = "0x89527A0", VA = "0x188953BA0")]
	[LGDDHCFHIFD]
	internal void RpcGetPlayerRoomInventoryCountResponse(Guid JKLGJDFLIGN, int NKGPOLKDIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8950CA0", Offset = "0x894F8A0", VA = "0x188950CA0")]
	[AsyncStateMachine(typeof(MLHPEFKJOGM))]
	private Task<DMNDFJOEFMG> IOEKOKMABGA(PLCCGHEKGIM FANAFCDPEEP, Guid DCJGAKOBLDI, int KHGDCKMEAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8953AD0", Offset = "0x89526D0", VA = "0x188953AD0")]
	[LGDDHCFHIFD]
	internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid JKLGJDFLIGN, Guid DCJGAKOBLDI, int KHGDCKMEAJM, OJPNDDCHNHP ACLFBNHJPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8951700", Offset = "0x8950300", VA = "0x188951700")]
	private void KFDLEKCLOAN(PLCCGHEKGIM NNMFFMMOEKL, Guid JKLGJDFLIGN, DGOCBGKBGHO ABEFNIJCBBN, long BNBNILBLOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8954200", Offset = "0x8952E00", VA = "0x188954200")]
	[LGDDHCFHIFD]
	internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid JKLGJDFLIGN, int ABEFNIJCBBN, long BNBNILBLOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x894D510", Offset = "0x894C110", VA = "0x18894D510")]
	private void AEFPADKBJHG(bool LIJLDHJAPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x89541A0", Offset = "0x8952DA0", VA = "0x1889541A0")]
	[LGDDHCFHIFD]
	private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool MPELHOCNFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x894D990", Offset = "0x894C590", VA = "0x18894D990")]
	private void AILDEOFIHIB(List<FCMKODHNMGC> MFNBABMIOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8953FF0", Offset = "0x8952BF0", VA = "0x188953FF0")]
	[LGDDHCFHIFD]
	private void RpcOnNotifiedOfRoomInventoryTagUpdates(string CKIKJKPEEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x89520E0", Offset = "0x8950CE0", VA = "0x1889520E0")]
	private void MODPHNGAACJ(long CAPFGBOGLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8953F80", Offset = "0x8952B80", VA = "0x188953F80")]
	[LGDDHCFHIFD]
	private void RpcOnNotifiedOfRoomInventoryTagDeleted(long CAPFGBOGLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8950470", Offset = "0x894F070", VA = "0x188950470")]
	private OLMGLKDOPPH HMNKAMIIEJH(MKMCMCGHMFA IGHCOOABBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x89538F0", Offset = "0x89524F0", VA = "0x1889538F0")]
	private List<HOLCEPMNIPA> PIHGGNKKLFL(List<FCMKODHNMGC> MFNBABMIOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8952250", Offset = "0x8950E50", VA = "0x188952250")]
	private List<HOLCEPMNIPA> MOIOMCMFGJC(IEnumerable<FCMKODHNMGC> MFNBABMIOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8952730", Offset = "0x8951330", VA = "0x188952730", Slot = "36")]
	public RoomInventoryItemProperties NAAPOKGPKKI(string AGDPLDINHMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8953750", Offset = "0x8952350", VA = "0x188953750")]
	private OLMGLKDOPPH PADFIOJFDEH(MKMCMCGHMFA IGHCOOABBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x894E870", Offset = "0x894D470", VA = "0x18894E870", Slot = "35")]
	public MKMCMCGHMFA DDAABNMDEJJ(OLMGLKDOPPH FMLNMLMCLMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x894F050", Offset = "0x894DC50", VA = "0x18894F050")]
	private HOLCEPMNIPA EKGPCIKLDHL(FCMKODHNMGC IGHCOOABBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8952D40", Offset = "0x8951940", VA = "0x188952D40")]
	private void NFGEJHMBFOA(JNFENIPJPAA NLGEGHONOIJ, int ACAFMNDCBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x894FB90", Offset = "0x894E790", VA = "0x18894FB90")]
	private void GFCKPPDMLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x894E040", Offset = "0x894CC40", VA = "0x18894E040")]
	private Task BKCCFHMOEHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8951A40", Offset = "0x8950640", VA = "0x188951A40")]
	private void KMKCAKAGPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x894F990", Offset = "0x894E590", VA = "0x18894F990")]
	private void FOGDFDGIBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x89518C0", Offset = "0x89504C0", VA = "0x1889518C0")]
	private void KFPKNFCJLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8950FF0", Offset = "0x894FBF0", VA = "0x188950FF0")]
	[AsyncStateMachine(typeof(OMOMPFPPEFJ))]
	private Task JHDMCFPGOJB(OLMGLKDOPPH DNCBHKJJDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x894EC40", Offset = "0x894D840", VA = "0x18894EC40")]
	[CompilerGenerated]
	private void DPKFKOKKDFN(Task<TaskStatus> MHGNKNMAFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x894F2E0", Offset = "0x894DEE0", VA = "0x18894F2E0")]
	[CompilerGenerated]
	private Task<DGOCBGKBGHO> ELOCDGOMDLP(NHFKPFKKBIM P_0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x894E1D0", Offset = "0x894CDD0", VA = "0x18894E1D0")]
	[CompilerGenerated]
	internal static Dictionary<MJEAPLMCEHB, IALOLJKMMOC> BLCOEPAJDGJ(DGOCBGKBGHO ABEFNIJCBBN, BHOJIEAKONM P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NIKJLPIIDNF : Dictionary<string, RoomInventoryItemProperties>
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x894D4D0", Offset = "0x894C0D0", VA = "0x18894D4D0")]
	public NIKJLPIIDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IABOMHCDMGN
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOGDJDDAMGN LBILJPEAKME();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NIKJLPIIDNF LCCEOJFFMJF();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IILIPOLGAJC GMFNNFONMAH();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LFHOAACGHAK : IABOMHCDMGN
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x894BC40", Offset = "0x894A840", VA = "0x18894BC40")]
	[HHMPGEJNNFC.LMFNECDEKKH.PMAKKEDIOOO]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	[RecRoom.NoEngine.Common.Preserve]
	public LFHOAACGHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x894BCB0", Offset = "0x894A8B0", VA = "0x18894BCB0", Slot = "4")]
	public HOGDJDDAMGN LBILJPEAKME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x894BDC0", Offset = "0x894A9C0", VA = "0x18894BDC0", Slot = "5")]
	public NIKJLPIIDNF LCCEOJFFMJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x894BB50", Offset = "0x894A750", VA = "0x18894BB50", Slot = "6")]
	public IILIPOLGAJC GMFNNFONMAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IILIPOLGAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<long, HOLCEPMNIPA> HLNECADABGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly HOLCEPMNIPA[] AFDNFLKGEEP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NDCNNAMJKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB27800", Offset = "0xB26400", VA = "0x180B27800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB27790", Offset = "0xB26390", VA = "0x180B27790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KLBJKJOCHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x894A660", Offset = "0x8949260", VA = "0x18894A660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private long EMGLNODJBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5B660", Offset = "0xA5A260", VA = "0x180A5B660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x894A9E0", Offset = "0x89495E0", VA = "0x18894A9E0")]
	public void PKJBHLHOEAP(long MJILNJAJHOI, IEnumerable<HOLCEPMNIPA> OBELFLFLBMI, bool BFJAGFFPOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x894B060", Offset = "0x8949C60", VA = "0x18894B060")]
	public IReadOnlyList<HOLCEPMNIPA> PLJLMABFGOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xB27790", Offset = "0xB26390", VA = "0x180B27790")]
	public void MECNPDNBHEF(bool LIJLDHJAPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x894A160", Offset = "0x8948D60", VA = "0x18894A160")]
	public bool EKAGBAAAGOI(long CAPFGBOGLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x894AEA0", Offset = "0x8949AA0", VA = "0x18894AEA0")]
	public bool PLCAIAJNOBJ(HOLCEPMNIPA ICKDMPGDJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x894A6C0", Offset = "0x89492C0", VA = "0x18894A6C0")]
	public bool OODMAKPGHNN(List<HOLCEPMNIPA> AHDEKDMCLKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x894A0C0", Offset = "0x8948CC0", VA = "0x18894A0C0")]
	public bool DFKEEHADFFM(long CAPFGBOGLBC, [Out] HOLCEPMNIPA GMFCELNCIOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x894A2A0", Offset = "0x8948EA0", VA = "0x18894A2A0")]
	public bool GBEEMBIPGAJ(string BKILENEPEEB, [Out] HOLCEPMNIPA GMFCELNCIOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x894A590", Offset = "0x8949190", VA = "0x18894A590")]
	public List<HOLCEPMNIPA> JOIOBJDAMCI(int LCCBBMBENOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x894A450", Offset = "0x8949050", VA = "0x18894A450")]
	public List<HOLCEPMNIPA> HEMKAIDBFDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B8D0", Offset = "0x6F3A4D0", VA = "0x186F3B8D0")]
	public HOLCEPMNIPA HGNLGNNCJDK(int LCCBBMBENOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x894A240", Offset = "0x8948E40", VA = "0x18894A240")]
	public IReadOnlyList<HOLCEPMNIPA> ELBKOBEFMCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x894B210", Offset = "0x8949E10", VA = "0x18894B210")]
	public IILIPOLGAJC()
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
