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
public enum NOFLHOLCDNK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ECKDNOOPLME]
public class FPHOLHLHHAC : BHJPPOEHGOO, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct KKAKNPHHKEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string KJCKBOFLJEK = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string NOABLKJDOIO = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string BKLLJPNHPGC = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string HHCPBOPAEJO = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string CPPGJIJCGFA = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string MFEPKMEPKDN = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string KEAJNNNOKMK = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string MAFCCMJOBOH = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string JJNLCHNFJBN = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string DADCFBDKKHD = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string GJOBHLLFBKN = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OFFEOCCNKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FPHOLHLHHAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public OFFEOCCNKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA350", Offset = "0x5CD9750", VA = "0x185CDA350")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PMGOINPGLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public FPHOLHLHHAC <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PMGOINPGLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA790", Offset = "0x5CD9B90", VA = "0x185CDA790")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA820", Offset = "0x5CD9C20", VA = "0x185CDA820")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA850", Offset = "0x5CD9C50", VA = "0x185CDA850")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5CDAA40", Offset = "0x5CD9E40", VA = "0x185CDAA40")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5CDAA40", Offset = "0x5CD9E40", VA = "0x185CDAA40")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class AEGHFNJPJHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public FPHOLHLHHAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public AEGHFNJPJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFAF0", Offset = "0x5CCEEF0", VA = "0x185CCFAF0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFBC0", Offset = "0x5CCEFC0", VA = "0x185CCFBC0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFBC0", Offset = "0x5CCEFC0", VA = "0x185CCFBC0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class ODEDPDCGCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ODEDPDCGCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x115F080", Offset = "0x115E480", VA = "0x18115F080")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NHFOACBCLFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NHFOACBCLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9A40", Offset = "0x5CD8E40", VA = "0x185CD9A40")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JMABDEGPBGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public JMABDEGPBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9710", Offset = "0x5CD8B10", VA = "0x185CD9710")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GDHMANMAABN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FPHOLHLHHAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OHNBOJIMJND args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5CD92A0", Offset = "0x5CD86A0", VA = "0x185CD92A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OADHLFHEBON : IAsyncStateMachine
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
		public FPHOLHLHHAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA110", Offset = "0x5CD9510", VA = "0x185CDA110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime AEGMBFAAOAA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int PEBPJHKCLGC = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime MCMKPGLMKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DateTime DLDHEOFFNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly INICFBPFBEI NLFJELDCPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IGIAKJHJMJO PBCENKKHKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly OHAGKEEDBFD NHPHMJCNPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MPMGMKFFKCK FHENIGILMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KNOCCPHNCIA IPNLLMLMMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BPJNBFNJBMJ BEFBAPABJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KEBJMCDEHGP PNMKAGOAOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BGDABKNLGMA CHLPJFPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly JPNLLAEGIAP GAJFCELPINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HLMJLFFIPMJ HBJAGOLFNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly CDBCLMIJMKE NOBLLMNJIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EBBEMHCNIGG MFAMIIMOBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly FHAIGKPBMEJ MKCPKIFLPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CDJAIEBBMMP NHCOCKHKBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly MHANHPGIMOL JHAOAIOJGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly global::BBGFHLGLABJ<KeepsakesConfig.KeepsakesOptions> GBMKHELIDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> LMGOJAMBMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<Guid> OCADFHDIKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<long> GBLKCIENIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int LNPCMFFGIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<Guid> EANOMFICBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IDisposable HBNAKPNFLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Task EJEPJGPGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? JJDPHELKCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO OMKLECBOJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private global::JENPMPFICOP<KeepsakeProgressionEventInstancesDTO> CBNBANALCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<BGLKKBDEIJP, KeepsakeCategoryConfigDTO> GBEACBGBIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO HOBLFHGMDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> ABGEMDIGKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> HFKPLDDNLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> BLNEBEIFLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> LAJCNPGHMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomDTO> IJCNNKPKLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<string> FMEBFPONMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DateTime LMOCCBLHMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IDisposable CEMEEALKPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool MDOBGHNNLPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CHMLHGCAGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x677430", VA = "0x180678030", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x813720", Offset = "0x812B20", VA = "0x180813720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime MCBCMNGDJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7020", Offset = "0x5CD6420", VA = "0x185CD7020", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime JGCECGGOJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1130", Offset = "0x5CD0530", VA = "0x185CD1130", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NHCJKDELDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5610", Offset = "0x5CD4A10", VA = "0x185CD5610", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JAJHABAFEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD3100", Offset = "0x5CD2500", VA = "0x185CD3100", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long AABMDDJFELH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CD3760", Offset = "0x5CD2B60", VA = "0x185CD3760")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? AOKMOEFPKEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFE60", Offset = "0x5CCF260", VA = "0x185CCFE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool LICADDICLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5770", Offset = "0x5CD4B70", VA = "0x185CD5770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool HDGBHCGPJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x11A90C0", Offset = "0x11A84C0", VA = "0x1811A90C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6D40", Offset = "0x5CD6140", VA = "0x185CD6D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> HKHGENJAPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1470", Offset = "0x5CD0870", VA = "0x185CD1470", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CD56D0", Offset = "0x5CD4AD0", VA = "0x185CD56D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DKLAECIDKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5F00", Offset = "0x5CD5300", VA = "0x185CD5F00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5AF0", Offset = "0x5CD4EF0", VA = "0x185CD5AF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LFBCFJPAOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5CD60C0", Offset = "0x5CD54C0", VA = "0x185CD60C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0C50", Offset = "0x5CD0050", VA = "0x185CD0C50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8220", Offset = "0x5CD7620", VA = "0x185CD8220")]
	[Preserve]
	internal FPHOLHLHHAC([NotNull][IMNCNOGBAJI(null)] INICFBPFBEI NLFJELDCPLN, [NotNull][IMNCNOGBAJI(null)] MBJIHHKOHCP DICFBJFPBBP, [NotNull][IMNCNOGBAJI(null)] IGIAKJHJMJO PBCENKKHKAL, [NotNull][IMNCNOGBAJI(null)] OHAGKEEDBFD NHPHMJCNPLO, [NotNull][IMNCNOGBAJI(null)] MPMGMKFFKCK FHENIGILMJE, [NotNull][IMNCNOGBAJI(null)] KNOCCPHNCIA IPNLLMLMMNI, [NotNull][IMNCNOGBAJI(null)] BPJNBFNJBMJ BEFBAPABJND, [NotNull][IMNCNOGBAJI(null)] KEBJMCDEHGP PNMKAGOAOAP, [NotNull][IMNCNOGBAJI(null)] BGDABKNLGMA CHLPJFPJJFO, [NotNull][IMNCNOGBAJI(null)] CHPOGAMKFEN OIDGKAEOONP, [NotNull][IMNCNOGBAJI(null)] JPNLLAEGIAP GAJFCELPINE, [NotNull][IMNCNOGBAJI(null)] HLMJLFFIPMJ HBJAGOLFNPA, [NotNull][IMNCNOGBAJI(null)] CDBCLMIJMKE NOBLLMNJIEH, [NotNull][IMNCNOGBAJI(null)] EBBEMHCNIGG MFAMIIMOBMG, [NotNull][IMNCNOGBAJI(null)] FHAIGKPBMEJ MKCPKIFLPNM, [NotNull][IMNCNOGBAJI(null)] CDJAIEBBMMP NHCOCKHKBLA, [NotNull][IMNCNOGBAJI(null)] MHANHPGIMOL JHAOAIOJGFC, [NotNull][IMNCNOGBAJI(null)] global::BBGFHLGLABJ<KeepsakesConfig.KeepsakesOptions> GBMKHELIDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3840", Offset = "0x5CD2C40", VA = "0x185CD3840", Slot = "13")]
	public bool HAAMFHBBMAJ(List<string> HHFGIBANNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CD72E0", Offset = "0x5CD66E0", VA = "0x185CD72E0", Slot = "14")]
	public global::JENPMPFICOP<Guid> PAPPGJFGIMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CD11F0", Offset = "0x5CD05F0", VA = "0x185CD11F0", Slot = "35")]
	public JLFOFKFALKJ CPKDDEJPEFN(Guid IJBGAIEPLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0560", Offset = "0x5CCF960", VA = "0x185CD0560", Slot = "15")]
	public JLFOFKFALKJ BDDGLHMBODE(Guid IJBGAIEPLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4E00", Offset = "0x5CD4200", VA = "0x185CD4E00", Slot = "16")]
	public bool JLHANKDNPFM(Guid IJBGAIEPLJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2BE0", Offset = "0x5CD1FE0", VA = "0x185CD2BE0", Slot = "17")]
	public bool ECNIDJJLDPI(Guid IJBGAIEPLJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5100", Offset = "0x5CD4500", VA = "0x185CD5100", Slot = "18")]
	public KeepsakeTheme JMCCAIJDIOH(Guid IJBGAIEPLJL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4F40", Offset = "0x5CD4340", VA = "0x185CD4F40", Slot = "19")]
	public KeepsakeTheme JMCCAIJDIOH(BGLKKBDEIJP GBJOKBKOIBI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7F70", Offset = "0x5CD7370", VA = "0x185CD7F70", Slot = "20")]
	public bool PLHIIFCKMMC(Guid IJBGAIEPLJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5660", Offset = "0x5CD4A60", VA = "0x185CD5660", Slot = "21")]
	public void KALAKBOHIHA(Guid IJBGAIEPLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2C10", Offset = "0x5CD2010", VA = "0x185CD2C10", Slot = "22")]
	public void EGNNKNMMMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5FA0", Offset = "0x5CD53A0", VA = "0x185CD5FA0", Slot = "23")]
	public void MDNJEMAGFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6DB0", Offset = "0x5CD61B0", VA = "0x185CD6DB0", Slot = "24")]
	public int OEMNLPOOBHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7AA0", Offset = "0x5CD6EA0", VA = "0x185CD7AA0", Slot = "25")]
	public global::JENPMPFICOP<int> PILJIBMBAJB(long DDEPFHBCOHC, long JMGEHLBNLPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6060", Offset = "0x5CD5460", VA = "0x185CD6060", Slot = "27")]
	public bool MIDLJNMEHNN(long DDEPFHBCOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3BB0", Offset = "0x5CD2FB0", VA = "0x185CD3BB0", Slot = "36")]
	public bool HGAJDBEPAOP(long DDEPFHBCOHC, out ONKKOLBALKJ EECPBNLFLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7790", Offset = "0x5CD6B90", VA = "0x185CD7790", Slot = "28")]
	public long PDBDALMEMCC(HLKKCACLCLK KMCMNJDGFAH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0EE0", Offset = "0x5CD02E0", VA = "0x185CD0EE0", Slot = "29")]
	public IEnumerable<int> CBGPJOMANBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3FA0", Offset = "0x5CD33A0", VA = "0x185CD3FA0", Slot = "30")]
	public bool ICLPJHJACHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4090", Offset = "0x5CD3490", VA = "0x185CD4090", Slot = "31")]
	public IEnumerable<long> IPCNINJNJPA(JFPJLHPMIND PMNKKHAKMMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3250", Offset = "0x5CD2650", VA = "0x185CD3250", Slot = "32")]
	public int FJHKGAPHEDF(JFPJLHPMIND PMNKKHAKMMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CD32F0", Offset = "0x5CD26F0", VA = "0x185CD32F0")]
	private void GLHNJEEEBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CD67D0", Offset = "0x5CD5BD0", VA = "0x185CD67D0")]
	private int NJLALFJAHPG(KeepsakeRoomListDTO ADAEPOLCNLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5E30", Offset = "0x5CD5230", VA = "0x185CD5E30")]
	private int MBBHEHFLJDC(DateTime MBDGEMHEKPE, DateTime KGFIANCMFJE, TimeSpan PAJOHPFIOLN, int OLBCAPEJHOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD02A0", Offset = "0x5CCF6A0", VA = "0x185CD02A0")]
	private bool BBLKPKDDEMC(long BJMIJMPPFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD57A0", Offset = "0x5CD4BA0", VA = "0x185CD57A0")]
	private void KKCNOBMNCBP(IEnumerable<KeepsakeInstanceDTO> LMGOJAMBMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2D80", Offset = "0x5CD2180", VA = "0x185CD2D80")]
	private void ELMHNMLJPOM(IEnumerable<KeepsakeCollectionRecordDTO> ELJLLDEGILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1510", Offset = "0x5CD0910", VA = "0x185CD1510")]
	private void DDFKBMKKMBG(IEnumerable<long> CLAPCJPIIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2EE0", Offset = "0x5CD22E0", VA = "0x185CD2EE0")]
	private void EMIMGPHECIJ(IEnumerable<KeepsakeCategoryConfigDTO> KPDAFMMAONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x13BC740", Offset = "0x13BBB40", VA = "0x1813BC740")]
	private void KCGBELPKKOK(KeepsakeGlobalConfigDTO HOBLFHGMDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFF50", Offset = "0x5CCF350", VA = "0x185CCFF50")]
	private bool APPJBNFJJCC(out Guid LBIALOGLDPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5C70", Offset = "0x5CD5070", VA = "0x185CD5C70")]
	private void LKGEADGLOIH(KeepsakeInstanceDTO BLLFBKCLNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5CD70E0", Offset = "0x5CD64E0", VA = "0x185CD70E0")]
	private void PACAOAJOGIL(KeepsakeInstanceDTO BLLFBKCLNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6C60", Offset = "0x5CD6060", VA = "0x185CD6C60")]
	private void OCKKONBBMKA(Guid IJBGAIEPLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6980", Offset = "0x5CD5D80", VA = "0x185CD6980")]
	private void NKFEKGCKANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CD69E0", Offset = "0x5CD5DE0", VA = "0x185CD69E0")]
	private void NNCMFPEEGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CD81A0", Offset = "0x5CD75A0", VA = "0x185CD81A0")]
	private void PPALJILAACI(CKOHOJDPEFN EFBPCCGHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3080", Offset = "0x5CD2480", VA = "0x185CD3080")]
	private void EOCFKDJEDKA(CCAIFHCOCIN.ONDCCLCMMHJ JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CD59D0", Offset = "0x5CD4DD0", VA = "0x185CD59D0")]
	private void KKJLLAJAOIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2080", Offset = "0x5CD1480", VA = "0x185CD2080")]
	private void DMHGABJDAFN(float BGBJLAOCNAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD4890", Offset = "0x5CD3C90", VA = "0x185CD4890")]
	private void JDAGBHLFMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0CF0", Offset = "0x5CD00F0", VA = "0x185CD0CF0")]
	private bool CADDDEIANBC(Guid IJBGAIEPLJL, out string NMDKLCHALGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7570", Offset = "0x5CD6970", VA = "0x185CD7570")]
	private bool PBIMCPPJMDF(Guid IJBGAIEPLJL, out KeepsakeCategoryConfigDTO ALKAPHEGPHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5B90", Offset = "0x5CD4F90", VA = "0x185CD5B90")]
	private void KNMHOOIBAAG(string IFAPCIFEAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD66C0", Offset = "0x5CD5AC0", VA = "0x185CD66C0")]
	private bool NICAFCFBJIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6160", Offset = "0x5CD5560", VA = "0x185CD6160")]
	private bool MPMBKIFDBOD(Guid IJBGAIEPLJL, out string CIMKHIELLCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1700", Offset = "0x5CD0B00", VA = "0x185CD1700")]
	private void DGKKPCGBLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5A30", Offset = "0x5CD4E30", VA = "0x185CD5A30")]
	private void KMCHGLDGEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1570", Offset = "0x5CD0970", VA = "0x185CD1570")]
	internal static string DDNFPLKCHPH(NPEEBPMENDJ JNCEBJFKJMD, string BOMBCIDOMFE, bool EHMANPHGDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2440", Offset = "0x5CD1840", VA = "0x185CD2440", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6550", Offset = "0x5CD5950", VA = "0x185CD6550")]
	private CJAGNKGLNKE NBFKGDCAEEA(GLJCDOAILMB HLDMJLFBLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFCC0", Offset = "0x5CCF0C0", VA = "0x185CCFCC0")]
	private JOPIPFFKHBD ABEICCFGLHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CD28A0", Offset = "0x5CD1CA0", VA = "0x185CD28A0")]
	private Task EAIHBNJCHCL(OHNBOJIMJND MMLIFJCNOMF, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0B00", Offset = "0x5CCFF00", VA = "0x185CD0B00")]
	[AsyncStateMachine(typeof(GDHMANMAABN))]
	private Task BODDKIPHADF(OHNBOJIMJND MMLIFJCNOMF, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CD31C0", Offset = "0x5CD25C0", VA = "0x185CD31C0")]
	private Task FJCNEINHDGN(OHNBOJIMJND MMLIFJCNOMF, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2C30", Offset = "0x5CD2030", VA = "0x185CD2C30")]
	[AsyncStateMachine(typeof(OADHLFHEBON))]
	private Task EIHGNEHHDPP(string KAKCNEMJMJL, TimeSpan BHHLOMELELO, CancellationToken BJOMIPBBJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5780", Offset = "0x5CD4B80", VA = "0x185CD5780")]
	[CompilerGenerated]
	private void KGJPJBAEOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFF00", Offset = "0x5CCF300", VA = "0x185CCFF00")]
	[CompilerGenerated]
	private void APMIECBJDEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5220", Offset = "0x5CD4620", VA = "0x185CD5220")]
	[CompilerGenerated]
	private void JOJGBJFEMNI(string CIMKHIELLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5780", Offset = "0x5CD4B80", VA = "0x185CD5780")]
	[CompilerGenerated]
	private void PCBIHGKJNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7740", Offset = "0x5CD6B40", VA = "0x185CD7740")]
	[CompilerGenerated]
	private void PCDCHPDENBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CD65D0", Offset = "0x5CD59D0", VA = "0x185CD65D0")]
	[CompilerGenerated]
	private bool NFGKPMJFBBO(KeepsakeInstanceDTO BCJCIOLMPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CD30E0", Offset = "0x5CD24E0", VA = "0x185CD30E0")]
	[CompilerGenerated]
	private bool FCIMGPGBHEP(KeepsakeRoomListDTO BCJCIOLMPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CD6A00", Offset = "0x5CD5E00", VA = "0x185CD6A00")]
	[CompilerGenerated]
	private void OADBEPEGJNB(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> ALBBEDMABCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3B50", Offset = "0x5CD2F50", VA = "0x185CD3B50")]
	[CompilerGenerated]
	private void HFANDMCHCPF(string CIMKHIELLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0910", Offset = "0x5CCFD10", VA = "0x185CD0910")]
	[CompilerGenerated]
	private Task BFIFAOLAKMP(CancellationToken OOIBAKKHFJA)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::BBGFHLGLABJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class LKLNBDNIHLE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
				public LKLNBDNIHLE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5CD9A10", Offset = "0x5CD8E10", VA = "0x185CD9A10")]
				internal bool <GetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] KCHFJACJHGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5CD98D0", Offset = "0x5CD8CD0", VA = "0x185CD98D0")]
			public KeepsakeTheme JMCCAIJDIOH(string AOPGIALEOKP)
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
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5CD97B0", Offset = "0x5CD8BB0", VA = "0x185CD97B0")]
		[PCIIMDKJBPO(GGLAACLIDJL.None)]
		private static void DLEDFLHHMLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xEE1590", Offset = "0xEE0990", VA = "0x180EE1590")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9AE0", Offset = "0x5CD8EE0", VA = "0x185CD9AE0")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9BF0", Offset = "0x5CD8FF0", VA = "0x185CD9BF0")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
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

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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
