using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using RecNet;
using RecRoom.Keepsakes;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ELKFJNHGDMF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CPGFJJNKNGK : AHNDIAFDGDL, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct ENOAHBGMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string PJCKPEFKKPC = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string HDJJDFPPDCM = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string KLCNPCGFLGL = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string ANAIADDPBPN = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string HBDEMCLNFNJ = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string GIHMBCNJCKM = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string DHFMDKJGLKH = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string OPNKNJABDPH = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string CPHOGGOIJFN = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string PBLJEGDNCBG = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string MDDKAHMJDCM = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class LPHLICBKGKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CPGFJJNKNGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string collectionMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public LPHLICBKGKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5C55490", Offset = "0x5C54890", VA = "0x185C55490")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PODPGNINCPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CPGFJJNKNGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public PODPGNINCPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5C55D30", Offset = "0x5C55130", VA = "0x185C55D30")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5C55DC0", Offset = "0x5C551C0", VA = "0x185C55DC0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5C55DF0", Offset = "0x5C551F0", VA = "0x185C55DF0")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5C55FE0", Offset = "0x5C553E0", VA = "0x185C55FE0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5C55FE0", Offset = "0x5C553E0", VA = "0x185C55FE0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class AIONBANNOEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CPGFJJNKNGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public AIONBANNOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B2E0", Offset = "0x5C4A6E0", VA = "0x185C4B2E0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B3B0", Offset = "0x5C4A7B0", VA = "0x185C4B3B0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B3B0", Offset = "0x5C4A7B0", VA = "0x185C4B3B0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JECKNPJLCNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public JECKNPJLCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x11882B0", Offset = "0x11876B0", VA = "0x1811882B0")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GPNDLEFNPEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public GPNDLEFNPEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5C54880", Offset = "0x5C53C80", VA = "0x185C54880")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JLDHEICLGLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public JLDHEICLGLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5C54F50", Offset = "0x5C54350", VA = "0x185C54F50")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NBFDEOMPKGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CPGFJJNKNGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public HHPEKJGCIPO args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5C558C0", Offset = "0x5C54CC0", VA = "0x185C558C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KMKPAINKKGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CPGFJJNKNGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5C54FF0", Offset = "0x5C543F0", VA = "0x185C54FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime PNKELPDFEHH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int KDLMDBBFLMM = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime MDEIPPCMIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DateTime DBJFCCHHLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KGGFIFMGOHC NEFFGLOFANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MJMAFMCEMBF JAODDFODMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly EDABJDHJNNI EMFPCNCJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EALFGGNOILB PMOPOCDJJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IIHLOMNOCIN EOPOLGFEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HAJDJKBCKCJ FLNAANIMHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GPKLPECHMBG MBLDBPCGGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KJAOGEMHFFI MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly ACKGBIFNFDG KKBCNOPGELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AKLPNPKMPOJ EDNAPBCJBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MLIMNONHBLM FOJOOJMCGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MCGDBKIBHBK LOJABIENNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CCEBIBCAGMH EIPNKGLFKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly ODFBMHLKKAI KKACNFNCHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly HBPOPKLDDIA NNKJDCLFJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly global::HDLLHGMMAGJ<KeepsakesConfig.KeepsakesOptions> EGGIDBBMBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> HNDPBHFHCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<Guid> AEHGLCCDAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<long> INMKCODNKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int BLDPGKBNOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<Guid> IAFFAEOHCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IDisposable CPKMFKOBFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Task KNOODEHHLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? HAAIDENFOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO DCHLIPOLACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private global::BHPNOFOGFAO<KeepsakeProgressionEventInstancesDTO> ICAEANOPGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<KOOALFKNJOH, KeepsakeCategoryConfigDTO> NFAKKJBCJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO MPKGOOJLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> BNDGGLIJNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> PJELFJCLKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> NKCALGGIPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> ILGJBFONEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomDTO> NMIMGEPCBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<string> PLNHGOBDJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DateTime KIHFABDBEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IDisposable NIEHHPKNJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CHOEFDEGHKN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CLPNLJBAPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66D030", Offset = "0x66C430", VA = "0x18066D030", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x808720", Offset = "0x807B20", VA = "0x180808720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime CGELEKKMGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C50C10", Offset = "0x5C50010", VA = "0x185C50C10", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime GGFNCLCNMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C51240", Offset = "0x5C50640", VA = "0x185C51240", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LEFLKDDGNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C51A70", Offset = "0x5C50E70", VA = "0x185C51A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MLEINDMLLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C4BF10", Offset = "0x5C4B310", VA = "0x185C4BF10", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long HIIMJAEKFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C4BCC0", Offset = "0x5C4B0C0", VA = "0x185C4BCC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? LHABADJPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C50CD0", Offset = "0x5C500D0", VA = "0x185C50CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool NIHOGHOGJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C4EE00", Offset = "0x5C4E200", VA = "0x185C4EE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool CCIOHLCCEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x15C88C0", Offset = "0x15C7CC0", VA = "0x1815C88C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5C50F20", Offset = "0x5C50320", VA = "0x185C50F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> HIBOHEGBOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5C519D0", Offset = "0x5C50DD0", VA = "0x185C519D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C4ED60", Offset = "0x5C4E160", VA = "0x185C4ED60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GLPJOHKMBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E8A0", Offset = "0x5C4DCA0", VA = "0x185C4E8A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5C511A0", Offset = "0x5C505A0", VA = "0x185C511A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JALNMOOJMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E3B0", Offset = "0x5C4D7B0", VA = "0x185C4E3B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C52E40", Offset = "0x5C52240", VA = "0x185C52E40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C537D0", Offset = "0x5C52BD0", VA = "0x185C537D0")]
	[Preserve]
	internal CPGFJJNKNGK([NotNull][FFFBKAEBNFI(null)] KGGFIFMGOHC NEFFGLOFANH, [NotNull][FFFBKAEBNFI(null)] MLMCNDJAIIN HNPJGKOMCIO, [NotNull][FFFBKAEBNFI(null)] MJMAFMCEMBF JAODDFODMJG, [NotNull][FFFBKAEBNFI(null)] EDABJDHJNNI EMFPCNCJOPP, [NotNull][FFFBKAEBNFI(null)] EALFGGNOILB PMOPOCDJJKG, [NotNull][FFFBKAEBNFI(null)] IIHLOMNOCIN EOPOLGFEGAI, [NotNull][FFFBKAEBNFI(null)] HAJDJKBCKCJ FLNAANIMHDP, [NotNull][FFFBKAEBNFI(null)] GPKLPECHMBG MBLDBPCGGKE, [NotNull][FFFBKAEBNFI(null)] KJAOGEMHFFI MBEKPBENMJL, [NotNull][FFFBKAEBNFI(null)] OHCIPNFGMIL NIDALHHFOGJ, [NotNull][FFFBKAEBNFI(null)] ACKGBIFNFDG KKBCNOPGELN, [NotNull][FFFBKAEBNFI(null)] AKLPNPKMPOJ EDNAPBCJBMI, [NotNull][FFFBKAEBNFI(null)] MLIMNONHBLM FOJOOJMCGFH, [NotNull][FFFBKAEBNFI(null)] MCGDBKIBHBK LOJABIENNHI, [NotNull][FFFBKAEBNFI(null)] CCEBIBCAGMH EIPNKGLFKFP, [NotNull][FFFBKAEBNFI(null)] ODFBMHLKKAI KKACNFNCHOF, [NotNull][FFFBKAEBNFI(null)] HBPOPKLDDIA NNKJDCLFJIH, [NotNull][FFFBKAEBNFI(null)] global::HDLLHGMMAGJ<KeepsakesConfig.KeepsakesOptions> EGGIDBBMBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C4DE90", Offset = "0x5C4D290", VA = "0x185C4DE90", Slot = "13")]
	public bool EEAOFAGAHJM(List<string> HAEPBIGKAOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C533F0", Offset = "0x5C527F0", VA = "0x185C533F0", Slot = "14")]
	public global::BHPNOFOGFAO<Guid> PFGNKBFDEEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C4B4B0", Offset = "0x5C4A8B0", VA = "0x185C4B4B0", Slot = "35")]
	public EEBBFEJKFOP AGNPMHFOBEJ(Guid DKOLAHEMHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C513E0", Offset = "0x5C507E0", VA = "0x185C513E0", Slot = "15")]
	public EEBBFEJKFOP LNNDKONIAEI(Guid DKOLAHEMHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C4B730", Offset = "0x5C4AB30", VA = "0x185C4B730", Slot = "16")]
	public bool ALCBHAFBBGN(Guid DKOLAHEMHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C9E0", Offset = "0x5C4BDE0", VA = "0x185C4C9E0", Slot = "17")]
	public bool CHCMCKANKFM(Guid DKOLAHEMHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C4F0E0", Offset = "0x5C4E4E0", VA = "0x185C4F0E0", Slot = "18")]
	public KeepsakeTheme GLIMFPCEDNL(Guid DKOLAHEMHJG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C4EF20", Offset = "0x5C4E320", VA = "0x185C4EF20", Slot = "19")]
	public KeepsakeTheme GLIMFPCEDNL(KOOALFKNJOH ABCIMDBIKOD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C4E180", Offset = "0x5C4D580", VA = "0x185C4E180", Slot = "20")]
	public bool EHANPPKMHEE(Guid DKOLAHEMHJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C52700", Offset = "0x5C51B00", VA = "0x185C52700", Slot = "21")]
	public void NNJEFELCLEH(Guid DKOLAHEMHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C4BEF0", Offset = "0x5C4B2F0", VA = "0x185C4BEF0", Slot = "22")]
	public void BGOLHPHMKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C4E9A0", Offset = "0x5C4DDA0", VA = "0x185C4E9A0", Slot = "23")]
	public void FKAMFEBACBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C51AC0", Offset = "0x5C50EC0", VA = "0x185C51AC0", Slot = "24")]
	public int MNDPKBJEMDM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C4F250", Offset = "0x5C4E650", VA = "0x185C4F250", Slot = "25")]
	public global::BHPNOFOGFAO<int> GLKFOEGKKDB(long CNEPCDGFLLD, long EDNCECBBAAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C4D830", Offset = "0x5C4CC30", VA = "0x185C4D830", Slot = "27")]
	public bool DKKGBEAABOI(long CNEPCDGFLLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C4E4B0", Offset = "0x5C4D8B0", VA = "0x185C4E4B0", Slot = "36")]
	public bool FFLGDLCADPK(long CNEPCDGFLLD, out FMHDABJEDLH EKBOFEHCOBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C4F720", Offset = "0x5C4EB20", VA = "0x185C4F720", Slot = "28")]
	public long GMHFINLDHBI(CIAIDPKOGPG JKGKBDANPCL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C560", Offset = "0x5C4B960", VA = "0x185C4C560", Slot = "29")]
	public IEnumerable<int> BODCCHLHMDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C503F0", Offset = "0x5C4F7F0", VA = "0x185C503F0", Slot = "30")]
	public bool ICKDGIDMOPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C4CB20", Offset = "0x5C4BF20", VA = "0x185C4CB20", Slot = "31")]
	public IEnumerable<long> DEMCICJKPEF(OPPDBLOCGEN NJMKIBGHHDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C50350", Offset = "0x5C4F750", VA = "0x185C50350", Slot = "32")]
	public int HMKFNNPGKCN(OPPDBLOCGEN NJMKIBGHHDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C504E0", Offset = "0x5C4F8E0", VA = "0x185C504E0")]
	private void IHHJGJPFLPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C50FD0", Offset = "0x5C503D0", VA = "0x185C50FD0")]
	private int LDKBLJIGBIA(KeepsakeRoomListDTO POAADPDLNPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C50D70", Offset = "0x5C50170", VA = "0x185C50D70")]
	private int JGFKHANCFJP(DateTime OOONOKGCLBJ, DateTime OGCNELPOEFD, TimeSpan OPOLICPGENG, int ANGIMLKMILF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C50950", Offset = "0x5C4FD50", VA = "0x185C50950")]
	private bool IMGGACGLLMF(long DDNIHAAIOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C7B0", Offset = "0x5C4BBB0", VA = "0x185C4C7B0")]
	private void CAKFFLGMFLI(IEnumerable<KeepsakeInstanceDTO> HNDPBHFHCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C4EA60", Offset = "0x5C4DE60", VA = "0x185C4EA60")]
	private void FPPONPHLIIO(IEnumerable<KeepsakeCollectionRecordDTO> JFJDOIOLGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5C4BC60", Offset = "0x5C4B060", VA = "0x185C4BC60")]
	private void ALKMGAFFCON(IEnumerable<long> GEAJNMMACHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C4EBC0", Offset = "0x5C4DFC0", VA = "0x185C4EBC0")]
	private void GDJBILOJPFP(IEnumerable<KeepsakeCategoryConfigDTO> IDCHCBCNNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1319F50", Offset = "0x1319350", VA = "0x181319F50")]
	private void JNKHOGLGEEN(KeepsakeGlobalConfigDTO MPKGOOJLIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5C50000", Offset = "0x5C4F400", VA = "0x185C50000")]
	private bool HDLCMGMLPMC(out Guid GHNMBEMHFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5C51810", Offset = "0x5C50C10", VA = "0x185C51810")]
	private void MCPFOFCJPHI(KeepsakeInstanceDTO BHJNOGIDINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C020", Offset = "0x5C4B420", VA = "0x185C4C020")]
	private void BLJDFAMCPOD(KeepsakeInstanceDTO BHJNOGIDINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5C51300", Offset = "0x5C50700", VA = "0x185C51300")]
	private void LNEIBOMAKOP(Guid DKOLAHEMHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5C4FA30", Offset = "0x5C4EE30", VA = "0x185C4FA30")]
	private void GOIIAMCILGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5C50F90", Offset = "0x5C50390", VA = "0x185C50F90")]
	private void KHJGKOOJHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5C4CA10", Offset = "0x5C4BE10", VA = "0x185C4CA10")]
	private void CLMAMFKPOOI(FDEFPHIAOMP NCEBCFEJMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C4E940", Offset = "0x5C4DD40", VA = "0x185C4E940")]
	private void FJLNOBCFGHB(IKNDCDHFNCD.ODFBNDFNNPN HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5C53770", Offset = "0x5C52B70", VA = "0x185C53770")]
	private void PPIPBPGKCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5C53030", Offset = "0x5C52430", VA = "0x185C53030")]
	private void OOABLLOIINM(float LGGCDNCAPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5C4FA90", Offset = "0x5C4EE90", VA = "0x185C4FA90")]
	private void HAEJIJEPJPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5C4D5D0", Offset = "0x5C4C9D0", VA = "0x185C4D5D0")]
	private bool DHEBGOGBKID(Guid DKOLAHEMHJG, out string BCDJNFGJHEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5C4D660", Offset = "0x5C4CA60", VA = "0x185C4D660")]
	private bool DKFDGLGIHNG(Guid DKOLAHEMHJG, out KeepsakeCategoryConfigDTO IBGEACNFOHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5C50E40", Offset = "0x5C50240", VA = "0x185C50E40")]
	private void KBAGCLODPPO(string JHACFCAPKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5C4EE10", Offset = "0x5C4E210", VA = "0x185C4EE10")]
	private bool GKGOIIGFNAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5C52770", Offset = "0x5C51B70", VA = "0x185C52770")]
	private bool NNPJAEGHKGE(Guid DKOLAHEMHJG, out string DNNOOMDNIBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5C51D30", Offset = "0x5C51130", VA = "0x185C51D30")]
	private void NBGCCBJGDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5C4D320", Offset = "0x5C4C720", VA = "0x185C4D320")]
	private void DEOIFHMLKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C4DA30", Offset = "0x5C4CE30", VA = "0x185C4DA30", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5C52DC0", Offset = "0x5C521C0", VA = "0x185C52DC0")]
	private MBCHBOFNLBC ODBJBFDLCON(NEDBMOFEKBM FHGPINKEFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5C4D890", Offset = "0x5C4CC90", VA = "0x185C4D890")]
	private GOCNKMNKIHO DOEEAHOCCLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5C4C220", Offset = "0x5C4B620", VA = "0x185C4C220")]
	private Task BNLBMFIJMIJ(HHPEKJGCIPO LBFFDNKPEBE, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5C52EE0", Offset = "0x5C522E0", VA = "0x185C52EE0")]
	[AsyncStateMachine(typeof(NBFDEOMPKGJ))]
	private Task OLAOJFNEDCA(HHPEKJGCIPO LBFFDNKPEBE, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5C4CA90", Offset = "0x5C4BE90", VA = "0x185C4CA90")]
	private Task CMMAGPJCHHJ(HHPEKJGCIPO LBFFDNKPEBE, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5C4BDA0", Offset = "0x5C4B1A0", VA = "0x185C4BDA0")]
	[AsyncStateMachine(typeof(KMKPAINKKGH))]
	private Task AOEAGKLJHMF(string HKDHNKHPGDP, TimeSpan OPKBDLNJBJP, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5C50FB0", Offset = "0x5C503B0", VA = "0x185C50FB0")]
	[CompilerGenerated]
	private void LDPFOHEHNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5C526B0", Offset = "0x5C51AB0", VA = "0x185C526B0")]
	[CompilerGenerated]
	private void NLDJOAOGFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5C4B870", Offset = "0x5C4AC70", VA = "0x185C4B870")]
	[CompilerGenerated]
	private void ALGHDHJKJPB(string DNNOOMDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C50FB0", Offset = "0x5C503B0", VA = "0x185C50FB0")]
	[CompilerGenerated]
	private void KNNNEICFCMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C4BFD0", Offset = "0x5C4B3D0", VA = "0x185C4BFD0")]
	[CompilerGenerated]
	private void BKIIBAJPKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C53680", Offset = "0x5C52A80", VA = "0x185C53680")]
	[CompilerGenerated]
	private bool PGFMFBKJEKF(KeepsakeInstanceDTO HHAEMEGNPGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5C51180", Offset = "0x5C50580", VA = "0x185C51180")]
	[CompilerGenerated]
	private bool LFCAHCKKENJ(KeepsakeRoomListDTO HHAEMEGNPGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5C52B60", Offset = "0x5C51F60", VA = "0x185C52B60")]
	[CompilerGenerated]
	private void NPIEBFCCFHD(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> BBAGKFDGIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5C4E450", Offset = "0x5C4D850", VA = "0x185C4E450")]
	[CompilerGenerated]
	private void FENEPCGHGIL(string DNNOOMDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5C4D3E0", Offset = "0x5C4C7E0", VA = "0x185C4D3E0")]
	[CompilerGenerated]
	private Task DFDHKCFBDKA(CancellationToken NMPMAGFIEDF)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::HDLLHGMMAGJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class EPBOEOLIEAL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
				public EPBOEOLIEAL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x5C54850", Offset = "0x5C53C50", VA = "0x185C54850")]
				internal bool <GetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x66DF40", Offset = "0x66D340", VA = "0x18066DF40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] NFJAGELBPFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5C55350", Offset = "0x5C54750", VA = "0x185C55350")]
			public KeepsakeTheme GLIMFPCEDNL(string JNELACNJPDL)
			{
				return default(KeepsakeTheme);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5C55230", Offset = "0x5C54630", VA = "0x185C55230")]
		[AMOLIILEGPJ(OPIFOMJNBJD.None)]
		private static void HMILCOJDCME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xF02880", Offset = "0xF01C80", VA = "0x180F02880")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5C54C70", Offset = "0x5C54070", VA = "0x185C54C70")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5C54920", Offset = "0x5C53D20", VA = "0x185C54920")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
