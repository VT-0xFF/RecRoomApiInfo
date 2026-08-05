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
public enum CPLFDFMKILI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[OANPCODOIMB]
public class CPIAPOKGHIJ : JACNBKAICLK, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct INLAIFAFJOE
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string LHKPCNLFEMO = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string NKMAOLPPCMI = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string OHIGHFFKGBJ = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string GKEBLMLCNCG = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string GHFGFFHGKAA = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string JJCHEOJEJFK = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string NHIDHICBHFG = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string LMIKAIMOFDH = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string OHFMLBEIPIP = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string NNKGIEJEIMF = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string LNMMHMLOBEB = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FOLGFJCCOJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CPIAPOKGHIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public FOLGFJCCOJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2510", Offset = "0x5DF0B10", VA = "0x185DF2510")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MPFPHPLCHJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CPIAPOKGHIJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public MPFPHPLCHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DF34F0", Offset = "0x5DF1AF0", VA = "0x185DF34F0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3580", Offset = "0x5DF1B80", VA = "0x185DF3580")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF35B0", Offset = "0x5DF1BB0", VA = "0x185DF35B0")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF37A0", Offset = "0x5DF1DA0", VA = "0x185DF37A0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF37A0", Offset = "0x5DF1DA0", VA = "0x185DF37A0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LHCCPPPMMMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CPIAPOKGHIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LHCCPPPMMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2CF0", Offset = "0x5DF12F0", VA = "0x185DF2CF0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2DC0", Offset = "0x5DF13C0", VA = "0x185DF2DC0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2DC0", Offset = "0x5DF13C0", VA = "0x185DF2DC0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BEDIMLHNPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public BEDIMLHNPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1C8D050", Offset = "0x1C8B650", VA = "0x181C8D050")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LAIBLPNBNJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LAIBLPNBNJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2C50", Offset = "0x5DF1250", VA = "0x185DF2C50")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JPHHBGDPEDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public JPHHBGDPEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2950", Offset = "0x5DF0F50", VA = "0x185DF2950")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FAAKMKOOLFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CPIAPOKGHIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public EMLPMBHPMDM args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF20A0", Offset = "0x5DF06A0", VA = "0x185DF20A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EHMBKEDJDMI : IAsyncStateMachine
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
		public CPIAPOKGHIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1E60", Offset = "0x5DF0460", VA = "0x185DF1E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime MAKBEPPONMK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int EKEEMALJFOC = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime DIIDPAJHOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DateTime LAIMGAIPFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly PMPKABCKPGL OMDJPEJJBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DKAALNKMDPM BMMMDLCBJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FPJKCIJBMIJ DHICPLCJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JCILEDGJJHH MPFJBKHDHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HOKMKHEIMLO GHBIGIEEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly IKOPDLJHMDJ MIKHLBDBOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HKJGGEEKHJM LKDBNNCGMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OGHNMHNJHKD IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly AKBGOPCBAGL HIILCEHAKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GJJOBGHKDFN IMKELNEOMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FHNBEBHHCNN KBIMHCJOMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly AOHNELOBCCJ FHOJCHIHJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly ANKCBOFKADO HDIJJDLANKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly JILCDGENFMO MNHJICLMCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly BPCJALHOJNN FLMGCJHJCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly global::MLCMOEMANBL<KeepsakesConfig.KeepsakesOptions> IDLLFOOCBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> EMKDGBFNKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<Guid> AKKFGNBAMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<long> COMDBOLHHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int CPBABAIFNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<Guid> BGCADCCIDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IDisposable IOEAOBIFFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Task KKABPOKPPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? KAPPJDFGFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO JCLPKJMPDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private global::DIHJKCFGFNO<KeepsakeProgressionEventInstancesDTO> GCKPAFMFDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<HFEKKCKBMPH, KeepsakeCategoryConfigDTO> DCKMNCMOLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO GNJHNPGFJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> GJBOKBCJPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> GFHCHAMDKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> IAIBPBGINBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> MMLOPKFGFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomDTO> ICMHLJLEBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<string> GMBIHFMFMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DateTime EMPBLBMKBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IDisposable CCEOIENIMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool PNJPPDIDBBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MCDBMIAICFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x718150", Offset = "0x716750", VA = "0x180718150", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x718170", Offset = "0x716770", VA = "0x180718170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime HKINGDDFPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DED9B0", Offset = "0x5DEBFB0", VA = "0x185DED9B0", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime NDCALGEHKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE920", Offset = "0x5DECF20", VA = "0x185DEE920", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LNGPFLICGOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9DB0", Offset = "0x5DE83B0", VA = "0x185DE9DB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CAPALLHCJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE6D0", Offset = "0x5DECCD0", VA = "0x185DEE6D0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long MEMCAAHFIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DEDA70", Offset = "0x5DEC070", VA = "0x185DEDA70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? OFJPBMGFKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE93A0", Offset = "0x5DE79A0", VA = "0x185DE93A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool EANIFCJOGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9E00", Offset = "0x5DE8400", VA = "0x185DE9E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool MKPCPLKNAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B18350", Offset = "0x2B16950", VA = "0x182B18350")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBF40", Offset = "0x5DEA540", VA = "0x185DEBF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> KBJKLMCLHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9300", Offset = "0x5DE7900", VA = "0x185DE9300", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB780", Offset = "0x5DE9D80", VA = "0x185DEB780", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MBDNMINHMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF710", Offset = "0x5DEDD10", VA = "0x185DEF710", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF580", Offset = "0x5DEDB80", VA = "0x185DEF580", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PBMOMFLNHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5DEEF70", Offset = "0x5DED570", VA = "0x185DEEF70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DEFBD0", Offset = "0x5DEE1D0", VA = "0x185DEFBD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0DE0", Offset = "0x5DEF3E0", VA = "0x185DF0DE0")]
	[Preserve]
	internal CPIAPOKGHIJ([NotNull][KICKHKJFGOO(null)] PMPKABCKPGL OMDJPEJJBKG, [NotNull][KICKHKJFGOO(null)] KGLMBAOCCFN NEIDDJIKOME, [NotNull][KICKHKJFGOO(null)] DKAALNKMDPM BMMMDLCBJGP, [NotNull][KICKHKJFGOO(null)] FPJKCIJBMIJ DHICPLCJHHL, [NotNull][KICKHKJFGOO(null)] JCILEDGJJHH MPFJBKHDHNA, [NotNull][KICKHKJFGOO(null)] HOKMKHEIMLO GHBIGIEEHOO, [NotNull][KICKHKJFGOO(null)] IKOPDLJHMDJ MIKHLBDBOMG, [NotNull][KICKHKJFGOO(null)] HKJGGEEKHJM LKDBNNCGMAB, [NotNull][KICKHKJFGOO(null)] OGHNMHNJHKD IFOIKAOPFOA, [NotNull][KICKHKJFGOO(null)] CDLBFOEHOCL COGDMLLKCMJ, [NotNull][KICKHKJFGOO(null)] AKBGOPCBAGL HIILCEHAKNA, [NotNull][KICKHKJFGOO(null)] GJJOBGHKDFN IMKELNEOMHP, [NotNull][KICKHKJFGOO(null)] FHNBEBHHCNN KBIMHCJOMJM, [NotNull][KICKHKJFGOO(null)] AOHNELOBCCJ FHOJCHIHJPA, [NotNull][KICKHKJFGOO(null)] ANKCBOFKADO HDIJJDLANKN, [NotNull][KICKHKJFGOO(null)] JILCDGENFMO MNHJICLMCHO, [NotNull][KICKHKJFGOO(null)] BPCJALHOJNN FLMGCJHJCBD, [NotNull][KICKHKJFGOO(null)] global::MLCMOEMANBL<KeepsakesConfig.KeepsakesOptions> IDLLFOOCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0AD0", Offset = "0x5DEF0D0", VA = "0x185DF0AD0", Slot = "13")]
	public bool PJGACNHIMIA(List<string> IHOIFLAKPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC830", Offset = "0x5DEAE30", VA = "0x185DEC830", Slot = "14")]
	public global::DIHJKCFGFNO<Guid> GFIAAPNDJAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DEADC0", Offset = "0x5DE93C0", VA = "0x185DEADC0", Slot = "35")]
	public IGOPHNBFNOE DIDBGLFMNBK(Guid PBAKEPAJNKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDB50", Offset = "0x5DEC150", VA = "0x185DEDB50", Slot = "15")]
	public IGOPHNBFNOE IECFJJOKOJO(Guid PBAKEPAJNKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA270", Offset = "0x5DE8870", VA = "0x185DEA270", Slot = "16")]
	public bool CHCMHAFNEHH(Guid PBAKEPAJNKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFBA0", Offset = "0x5DEE1A0", VA = "0x185DEFBA0", Slot = "17")]
	public bool MIPINIMPFHL(Guid PBAKEPAJNKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DEACA0", Offset = "0x5DE92A0", VA = "0x185DEACA0", Slot = "18")]
	public KeepsakeTheme DGHGLMMAKPC(Guid PBAKEPAJNKL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAAE0", Offset = "0x5DE90E0", VA = "0x185DEAAE0", Slot = "19")]
	public KeepsakeTheme DGHGLMMAKPC(HFEKKCKBMPH HFHILHNJEMJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA3B0", Offset = "0x5DE89B0", VA = "0x185DEA3B0", Slot = "20")]
	public bool CJDBBEDMKHB(Guid PBAKEPAJNKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBFB0", Offset = "0x5DEA5B0", VA = "0x185DEBFB0", Slot = "21")]
	public void EIIIAPIMADK(Guid PBAKEPAJNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DED990", Offset = "0x5DEBF90", VA = "0x185DED990", Slot = "22")]
	public void HILKFPEILAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8AE0", Offset = "0x5DE70E0", VA = "0x185DE8AE0", Slot = "23")]
	public void AIGOEDIGHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA000", Offset = "0x5DE8600", VA = "0x185DEA000", Slot = "24")]
	public int CFHGKGHCOGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC020", Offset = "0x5DEA620", VA = "0x185DEC020", Slot = "25")]
	public global::DIHJKCFGFNO<int> FDMBBBDFKLJ(long FAFDJINDEIN, long CIILPNMBNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF6B0", Offset = "0x5DEDCB0", VA = "0x185DEF6B0", Slot = "27")]
	public bool LJOCBBKPLAH(long FAFDJINDEIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DED540", Offset = "0x5DEBB40", VA = "0x185DED540", Slot = "36")]
	public bool HHBNGIJONHH(long FAFDJINDEIN, out LDABLFPFOFI PHFHFANPAKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF010", Offset = "0x5DED610", VA = "0x185DEF010", Slot = "28")]
	public long KMEENGJFFPH(NMMNBDECMME CKGFHGPLADO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEAA0", Offset = "0x5DED0A0", VA = "0x185DEEAA0", Slot = "29")]
	public IEnumerable<int> JJLNFOKBOKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB820", Offset = "0x5DE9E20", VA = "0x185DEB820", Slot = "30")]
	public bool DPALCMGONDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFC70", Offset = "0x5DEE270", VA = "0x185DEFC70", Slot = "31")]
	public IEnumerable<long> MOKMMEKGGND(HDELEFFDPBL OPBJPAAPHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEED0", Offset = "0x5DED4D0", VA = "0x185DEEED0", Slot = "32")]
	public int KDJPAABNBGE(HDELEFFDPBL OPBJPAAPHMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDF00", Offset = "0x5DEC500", VA = "0x185DEDF00")]
	private void JAEJMHLEEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBD70", Offset = "0x5DEA370", VA = "0x185DEBD70")]
	private int EDGEEMADHPD(KeepsakeRoomListDTO ANELLPAPFLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0760", Offset = "0x5DEED60", VA = "0x185DF0760")]
	private int OAHEAOBIDNM(DateTime NCLPELPJPEP, DateTime FKEIKMJLDHB, TimeSpan JOAPBGJIMML, int AOIFLBKMPLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC570", Offset = "0x5DEAB70", VA = "0x185DEC570")]
	private bool GBINDJEJKJE(long GOENNPEBMGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9830", Offset = "0x5DE7E30", VA = "0x185DE9830")]
	private void BBJPLBFELIF(IEnumerable<KeepsakeInstanceDTO> EMKDGBFNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEECF0", Offset = "0x5DED2F0", VA = "0x185DEECF0")]
	private void JKGODEFCLLJ(IEnumerable<KeepsakeCollectionRecordDTO> IIODFGDHFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF410", Offset = "0x5DEDA10", VA = "0x185DEF410")]
	private void LAPNACFOHFG(IEnumerable<long> OJEKMCNAEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8940", Offset = "0x5DE6F40", VA = "0x185DE8940")]
	private void AGNBHAFHLML(IEnumerable<KeepsakeCategoryConfigDTO> CNILCBCFBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xB0F950", Offset = "0xB0DF50", VA = "0x180B0F950")]
	private void CIODFDABMDJ(KeepsakeGlobalConfigDTO GNJHNPGFJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9A60", Offset = "0x5DE8060", VA = "0x185DE9A60")]
	private bool BGOKDBONOGP(out Guid CHNKEDJIBJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0910", Offset = "0x5DEEF10", VA = "0x185DF0910")]
	private void PIKHBIDCDCN(KeepsakeInstanceDTO IFFIGPJLECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8D40", Offset = "0x5DE7340", VA = "0x185DE8D40")]
	private void ALGJDFODHMH(KeepsakeInstanceDTO IFFIGPJLECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DECAC0", Offset = "0x5DEB0C0", VA = "0x185DECAC0")]
	private void GKLCAKBDBFJ(Guid PBAKEPAJNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA5E0", Offset = "0x5DE8BE0", VA = "0x185DEA5E0")]
	private void CJJLLMPMBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE6B0", Offset = "0x5DECCB0", VA = "0x185DEE6B0")]
	private void JBKCKNPGIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEE50", Offset = "0x5DED450", VA = "0x185DEEE50")]
	private void JLPLBDNOFAD(OGHDDJALHCM CPFIFGNPGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DED930", Offset = "0x5DEBF30", VA = "0x185DED930")]
	private void HIFCAPAJIDA(FPLHFDGEPJM.OIFHIBJHNDL LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DE88E0", Offset = "0x5DE6EE0", VA = "0x185DE88E0")]
	private void ACHDEKLPOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8F40", Offset = "0x5DE7540", VA = "0x185DE8F40")]
	private void ALHLEEFGOFG(float HCOAODGJEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB040", Offset = "0x5DE9640", VA = "0x185DEB040")]
	private void DJCDGDNPGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9E10", Offset = "0x5DE8410", VA = "0x185DE9E10")]
	private bool BOFKHLMJFJA(Guid PBAKEPAJNKL, out string IILAOKKANGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB5B0", Offset = "0x5DE9BB0", VA = "0x185DEB5B0")]
	private bool DJIHGJHBHEH(Guid PBAKEPAJNKL, out KeepsakeCategoryConfigDTO HDPGJJCMHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0830", Offset = "0x5DEEE30", VA = "0x185DF0830")]
	private void ODCBPPMLIAK(string JOBGOEIDIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF470", Offset = "0x5DEDA70", VA = "0x185DEF470")]
	private bool LBFKKHMKAHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF7B0", Offset = "0x5DEDDB0", VA = "0x185DEF7B0")]
	private bool MEAICGCIFMO(Guid PBAKEPAJNKL, out string OOMNIJBIFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5DECBC0", Offset = "0x5DEB1C0", VA = "0x185DECBC0")]
	private void HFEAGJGAABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE9E0", Offset = "0x5DECFE0", VA = "0x185DEE9E0")]
	private void JJANPGAKMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE790", Offset = "0x5DECD90", VA = "0x185DEE790")]
	internal static string JFJKEDOCCPL(OEFMHFIBNNC DLFKBLBNEHN, string FGOCFADLMIH, bool PGAHIAGEFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB910", Offset = "0x5DE9F10", VA = "0x185DEB910", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC4F0", Offset = "0x5DEAAF0", VA = "0x185DEC4F0")]
	private HNKKGJKFCMD FPILAHJCILJ(CHIAPKEENBB BIAPDBFCHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0470", Offset = "0x5DEEA70", VA = "0x185DF0470")]
	private FBDDBGAPPNK NAFEGMGPFPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE370", Offset = "0x5DEC970", VA = "0x185DEE370")]
	private Task JAJLFBIMCPG(EMLPMBHPMDM HNGHLHHNPMK, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8BA0", Offset = "0x5DE71A0", VA = "0x185DE8BA0")]
	[AsyncStateMachine(typeof(FAAKMKOOLFM))]
	private Task AJFMBCHOFDH(EMLPMBHPMDM HNGHLHHNPMK, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF620", Offset = "0x5DEDC20", VA = "0x185DEF620")]
	private Task LIHHMEMPEBC(EMLPMBHPMDM HNGHLHHNPMK, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0610", Offset = "0x5DEEC10", VA = "0x185DF0610")]
	[AsyncStateMachine(typeof(EHMBKEDJDMI))]
	private Task NGBBAPCLEDK(string DIDMFBHHIEC, TimeSpan HBCHJPAOJMJ, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5DECBA0", Offset = "0x5DEB1A0", VA = "0x185DECBA0")]
	[CompilerGenerated]
	private void MDGPGKKHLNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA830", Offset = "0x5DE8E30", VA = "0x185DEA830")]
	[CompilerGenerated]
	private void CMCCGCIODPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9440", Offset = "0x5DE7A40", VA = "0x185DE9440")]
	[CompilerGenerated]
	private void APECMCFOLFK(string OOMNIJBIFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DECBA0", Offset = "0x5DEB1A0", VA = "0x185DECBA0")]
	[CompilerGenerated]
	private void GKPODAFCGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8CF0", Offset = "0x5DE72F0", VA = "0x185DE8CF0")]
	[CompilerGenerated]
	private void AJMMHACDBNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF320", Offset = "0x5DED920", VA = "0x185DEF320")]
	[CompilerGenerated]
	private bool KOEHLABLLJB(KeepsakeInstanceDTO FBHIPILAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBF20", Offset = "0x5DEA520", VA = "0x185DEBF20")]
	[CompilerGenerated]
	private bool EFGBHEBMABC(KeepsakeRoomListDTO FBHIPILAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA880", Offset = "0x5DE8E80", VA = "0x185DEA880")]
	[CompilerGenerated]
	private void COKAGOFHCCF(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> CHMIIAOHKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8880", Offset = "0x5DE6E80", VA = "0x185DE8880")]
	[CompilerGenerated]
	private void ABHPMLPMKPJ(string OOMNIJBIFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA640", Offset = "0x5DE8C40", VA = "0x185DEA640")]
	[CompilerGenerated]
	private Task CKKGHEHLKCA(CancellationToken LPMAEIKOJPA)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::MLCMOEMANBL<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class BFFKLMKDHIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public BFFKLMKDHIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5DE8850", Offset = "0x5DE6E50", VA = "0x185DE8850")]
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
			[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] FAEKPALKIGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5DF2B10", Offset = "0x5DF1110", VA = "0x185DF2B10")]
			public KeepsakeTheme DGHGLMMAKPC(string JEDKMMMPKFD)
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
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5DF29F0", Offset = "0x5DF0FF0", VA = "0x185DF29F0")]
		[PILNOHNDGDF(KBMKLHMPDPB.None)]
		private static void HJAIOHOJGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7FADF0", Offset = "0x7F93F0", VA = "0x1807FADF0")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3210", Offset = "0x5DF1810", VA = "0x185DF3210")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2EC0", Offset = "0x5DF14C0", VA = "0x185DF2EC0")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
