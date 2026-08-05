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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public FOLGFJCCOJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0E40", Offset = "0x5CDF840", VA = "0x185CE0E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public MPFPHPLCHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1E20", Offset = "0x5CE0820", VA = "0x185CE1E20")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1EB0", Offset = "0x5CE08B0", VA = "0x185CE1EB0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1EE0", Offset = "0x5CE08E0", VA = "0x185CE1EE0")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE20D0", Offset = "0x5CE0AD0", VA = "0x185CE20D0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE20D0", Offset = "0x5CE0AD0", VA = "0x185CE20D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public LHCCPPPMMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1620", Offset = "0x5CE0020", VA = "0x185CE1620")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CE16F0", Offset = "0x5CE00F0", VA = "0x185CE16F0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5CE16F0", Offset = "0x5CE00F0", VA = "0x185CE16F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public BEDIMLHNPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x107A8D0", Offset = "0x10792D0", VA = "0x18107A8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public LAIBLPNBNJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1580", Offset = "0x5CDFF80", VA = "0x185CE1580")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public JPHHBGDPEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1280", Offset = "0x5CDFC80", VA = "0x185CE1280")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CE09D0", Offset = "0x5CDF3D0", VA = "0x185CE09D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CE0790", Offset = "0x5CDF190", VA = "0x185CE0790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675A30", VA = "0x180677030", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x812720", Offset = "0x811120", VA = "0x180812720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime HKINGDDFPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC2E0", Offset = "0x5CDACE0", VA = "0x185CDC2E0", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime NDCALGEHKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD250", Offset = "0x5CDBC50", VA = "0x185CDD250", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LNGPFLICGOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CD86E0", Offset = "0x5CD70E0", VA = "0x185CD86E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CAPALLHCJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD000", Offset = "0x5CDBA00", VA = "0x185CDD000", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long MEMCAAHFIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CDC3A0", Offset = "0x5CDADA0", VA = "0x185CDC3A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? OFJPBMGFKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7CD0", Offset = "0x5CD66D0", VA = "0x185CD7CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool EANIFCJOGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CD8730", Offset = "0x5CD7130", VA = "0x185CD8730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool MKPCPLKNAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1D08960", Offset = "0x1D07360", VA = "0x181D08960")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA870", Offset = "0x5CD9270", VA = "0x185CDA870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> KBJKLMCLHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5CD7C30", Offset = "0x5CD6630", VA = "0x185CD7C30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CDA0B0", Offset = "0x5CD8AB0", VA = "0x185CDA0B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MBDNMINHMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE040", Offset = "0x5CDCA40", VA = "0x185CDE040", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CDDEB0", Offset = "0x5CDC8B0", VA = "0x185CDDEB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PBMOMFLNHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5CDD8A0", Offset = "0x5CDC2A0", VA = "0x185CDD8A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CDE500", Offset = "0x5CDCF00", VA = "0x185CDE500", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF710", Offset = "0x5CDE110", VA = "0x185CDF710")]
	[Preserve]
	internal CPIAPOKGHIJ([NotNull][KICKHKJFGOO(null)] PMPKABCKPGL OMDJPEJJBKG, [NotNull][KICKHKJFGOO(null)] KGLMBAOCCFN NEIDDJIKOME, [NotNull][KICKHKJFGOO(null)] DKAALNKMDPM BMMMDLCBJGP, [NotNull][KICKHKJFGOO(null)] FPJKCIJBMIJ DHICPLCJHHL, [NotNull][KICKHKJFGOO(null)] JCILEDGJJHH MPFJBKHDHNA, [NotNull][KICKHKJFGOO(null)] HOKMKHEIMLO GHBIGIEEHOO, [NotNull][KICKHKJFGOO(null)] IKOPDLJHMDJ MIKHLBDBOMG, [NotNull][KICKHKJFGOO(null)] HKJGGEEKHJM LKDBNNCGMAB, [NotNull][KICKHKJFGOO(null)] OGHNMHNJHKD IFOIKAOPFOA, [NotNull][KICKHKJFGOO(null)] CDLBFOEHOCL COGDMLLKCMJ, [NotNull][KICKHKJFGOO(null)] AKBGOPCBAGL HIILCEHAKNA, [NotNull][KICKHKJFGOO(null)] GJJOBGHKDFN IMKELNEOMHP, [NotNull][KICKHKJFGOO(null)] FHNBEBHHCNN KBIMHCJOMJM, [NotNull][KICKHKJFGOO(null)] AOHNELOBCCJ FHOJCHIHJPA, [NotNull][KICKHKJFGOO(null)] ANKCBOFKADO HDIJJDLANKN, [NotNull][KICKHKJFGOO(null)] JILCDGENFMO MNHJICLMCHO, [NotNull][KICKHKJFGOO(null)] BPCJALHOJNN FLMGCJHJCBD, [NotNull][KICKHKJFGOO(null)] global::MLCMOEMANBL<KeepsakesConfig.KeepsakesOptions> IDLLFOOCBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF400", Offset = "0x5CDDE00", VA = "0x185CDF400", Slot = "13")]
	public bool PJGACNHIMIA(List<string> IHOIFLAKPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB160", Offset = "0x5CD9B60", VA = "0x185CDB160", Slot = "14")]
	public global::DIHJKCFGFNO<Guid> GFIAAPNDJAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CD96F0", Offset = "0x5CD80F0", VA = "0x185CD96F0", Slot = "35")]
	public IGOPHNBFNOE DIDBGLFMNBK(Guid PBAKEPAJNKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC480", Offset = "0x5CDAE80", VA = "0x185CDC480", Slot = "15")]
	public IGOPHNBFNOE IECFJJOKOJO(Guid PBAKEPAJNKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8BA0", Offset = "0x5CD75A0", VA = "0x185CD8BA0", Slot = "16")]
	public bool CHCMHAFNEHH(Guid PBAKEPAJNKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE4D0", Offset = "0x5CDCED0", VA = "0x185CDE4D0", Slot = "17")]
	public bool MIPINIMPFHL(Guid PBAKEPAJNKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CD95D0", Offset = "0x5CD7FD0", VA = "0x185CD95D0", Slot = "18")]
	public KeepsakeTheme DGHGLMMAKPC(Guid PBAKEPAJNKL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9410", Offset = "0x5CD7E10", VA = "0x185CD9410", Slot = "19")]
	public KeepsakeTheme DGHGLMMAKPC(HFEKKCKBMPH HFHILHNJEMJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8CE0", Offset = "0x5CD76E0", VA = "0x185CD8CE0", Slot = "20")]
	public bool CJDBBEDMKHB(Guid PBAKEPAJNKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA8E0", Offset = "0x5CD92E0", VA = "0x185CDA8E0", Slot = "21")]
	public void EIIIAPIMADK(Guid PBAKEPAJNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC2C0", Offset = "0x5CDACC0", VA = "0x185CDC2C0", Slot = "22")]
	public void HILKFPEILAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7410", Offset = "0x5CD5E10", VA = "0x185CD7410", Slot = "23")]
	public void AIGOEDIGHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8930", Offset = "0x5CD7330", VA = "0x185CD8930", Slot = "24")]
	public int CFHGKGHCOGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA950", Offset = "0x5CD9350", VA = "0x185CDA950", Slot = "25")]
	public global::DIHJKCFGFNO<int> FDMBBBDFKLJ(long FAFDJINDEIN, long CIILPNMBNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDFE0", Offset = "0x5CDC9E0", VA = "0x185CDDFE0", Slot = "27")]
	public bool LJOCBBKPLAH(long FAFDJINDEIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CDBE70", Offset = "0x5CDA870", VA = "0x185CDBE70", Slot = "36")]
	public bool HHBNGIJONHH(long FAFDJINDEIN, out LDABLFPFOFI PHFHFANPAKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD940", Offset = "0x5CDC340", VA = "0x185CDD940", Slot = "28")]
	public long KMEENGJFFPH(NMMNBDECMME CKGFHGPLADO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD3D0", Offset = "0x5CDBDD0", VA = "0x185CDD3D0", Slot = "29")]
	public IEnumerable<int> JJLNFOKBOKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA150", Offset = "0x5CD8B50", VA = "0x185CDA150", Slot = "30")]
	public bool DPALCMGONDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE5A0", Offset = "0x5CDCFA0", VA = "0x185CDE5A0", Slot = "31")]
	public IEnumerable<long> MOKMMEKGGND(HDELEFFDPBL OPBJPAAPHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD800", Offset = "0x5CDC200", VA = "0x185CDD800", Slot = "32")]
	public int KDJPAABNBGE(HDELEFFDPBL OPBJPAAPHMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC830", Offset = "0x5CDB230", VA = "0x185CDC830")]
	private void JAEJMHLEEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA6A0", Offset = "0x5CD90A0", VA = "0x185CDA6A0")]
	private int EDGEEMADHPD(KeepsakeRoomListDTO ANELLPAPFLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF090", Offset = "0x5CDDA90", VA = "0x185CDF090")]
	private int OAHEAOBIDNM(DateTime NCLPELPJPEP, DateTime FKEIKMJLDHB, TimeSpan JOAPBGJIMML, int AOIFLBKMPLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAEA0", Offset = "0x5CD98A0", VA = "0x185CDAEA0")]
	private bool GBINDJEJKJE(long GOENNPEBMGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8160", Offset = "0x5CD6B60", VA = "0x185CD8160")]
	private void BBJPLBFELIF(IEnumerable<KeepsakeInstanceDTO> EMKDGBFNKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD620", Offset = "0x5CDC020", VA = "0x185CDD620")]
	private void JKGODEFCLLJ(IEnumerable<KeepsakeCollectionRecordDTO> IIODFGDHFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDD40", Offset = "0x5CDC740", VA = "0x185CDDD40")]
	private void LAPNACFOHFG(IEnumerable<long> OJEKMCNAEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7270", Offset = "0x5CD5C70", VA = "0x185CD7270")]
	private void AGNBHAFHLML(IEnumerable<KeepsakeCategoryConfigDTO> CNILCBCFBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x177AC10", Offset = "0x1779610", VA = "0x18177AC10")]
	private void CIODFDABMDJ(KeepsakeGlobalConfigDTO GNJHNPGFJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8390", Offset = "0x5CD6D90", VA = "0x185CD8390")]
	private bool BGOKDBONOGP(out Guid CHNKEDJIBJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF240", Offset = "0x5CDDC40", VA = "0x185CDF240")]
	private void PIKHBIDCDCN(KeepsakeInstanceDTO IFFIGPJLECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7670", Offset = "0x5CD6070", VA = "0x185CD7670")]
	private void ALGJDFODHMH(KeepsakeInstanceDTO IFFIGPJLECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB3F0", Offset = "0x5CD9DF0", VA = "0x185CDB3F0")]
	private void GKLCAKBDBFJ(Guid PBAKEPAJNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8F10", Offset = "0x5CD7910", VA = "0x185CD8F10")]
	private void CJJLLMPMBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCFE0", Offset = "0x5CDB9E0", VA = "0x185CDCFE0")]
	private void JBKCKNPGIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD780", Offset = "0x5CDC180", VA = "0x185CDD780")]
	private void JLPLBDNOFAD(OGHDDJALHCM CPFIFGNPGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CDC260", Offset = "0x5CDAC60", VA = "0x185CDC260")]
	private void HIFCAPAJIDA(FPLHFDGEPJM.OIFHIBJHNDL LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7210", Offset = "0x5CD5C10", VA = "0x185CD7210")]
	private void ACHDEKLPOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7870", Offset = "0x5CD6270", VA = "0x185CD7870")]
	private void ALHLEEFGOFG(float HCOAODGJEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9970", Offset = "0x5CD8370", VA = "0x185CD9970")]
	private void DJCDGDNPGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8740", Offset = "0x5CD7140", VA = "0x185CD8740")]
	private bool BOFKHLMJFJA(Guid PBAKEPAJNKL, out string IILAOKKANGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9EE0", Offset = "0x5CD88E0", VA = "0x185CD9EE0")]
	private bool DJIHGJHBHEH(Guid PBAKEPAJNKL, out KeepsakeCategoryConfigDTO HDPGJJCMHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDF160", Offset = "0x5CDDB60", VA = "0x185CDF160")]
	private void ODCBPPMLIAK(string JOBGOEIDIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDDA0", Offset = "0x5CDC7A0", VA = "0x185CDDDA0")]
	private bool LBFKKHMKAHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE0E0", Offset = "0x5CDCAE0", VA = "0x185CDE0E0")]
	private bool MEAICGCIFMO(Guid PBAKEPAJNKL, out string OOMNIJBIFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB4F0", Offset = "0x5CD9EF0", VA = "0x185CDB4F0")]
	private void HFEAGJGAABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD310", Offset = "0x5CDBD10", VA = "0x185CDD310")]
	private void JJANPGAKMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD0C0", Offset = "0x5CDBAC0", VA = "0x185CDD0C0")]
	internal static string JFJKEDOCCPL(OEFMHFIBNNC DLFKBLBNEHN, string FGOCFADLMIH, bool PGAHIAGEFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA240", Offset = "0x5CD8C40", VA = "0x185CDA240", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAE20", Offset = "0x5CD9820", VA = "0x185CDAE20")]
	private HNKKGJKFCMD FPILAHJCILJ(CHIAPKEENBB BIAPDBFCHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEDA0", Offset = "0x5CDD7A0", VA = "0x185CDEDA0")]
	private FBDDBGAPPNK NAFEGMGPFPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCCA0", Offset = "0x5CDB6A0", VA = "0x185CDCCA0")]
	private Task JAJLFBIMCPG(EMLPMBHPMDM HNGHLHHNPMK, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CD74D0", Offset = "0x5CD5ED0", VA = "0x185CD74D0")]
	[AsyncStateMachine(typeof(FAAKMKOOLFM))]
	private Task AJFMBCHOFDH(EMLPMBHPMDM HNGHLHHNPMK, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDF50", Offset = "0x5CDC950", VA = "0x185CDDF50")]
	private Task LIHHMEMPEBC(EMLPMBHPMDM HNGHLHHNPMK, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEF40", Offset = "0x5CDD940", VA = "0x185CDEF40")]
	[AsyncStateMachine(typeof(EHMBKEDJDMI))]
	private Task NGBBAPCLEDK(string DIDMFBHHIEC, TimeSpan HBCHJPAOJMJ, CancellationToken JLIEBAENBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB4D0", Offset = "0x5CD9ED0", VA = "0x185CDB4D0")]
	[CompilerGenerated]
	private void MDGPGKKHLNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD9160", Offset = "0x5CD7B60", VA = "0x185CD9160")]
	[CompilerGenerated]
	private void CMCCGCIODPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7D70", Offset = "0x5CD6770", VA = "0x185CD7D70")]
	[CompilerGenerated]
	private void APECMCFOLFK(string OOMNIJBIFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDB4D0", Offset = "0x5CD9ED0", VA = "0x185CDB4D0")]
	[CompilerGenerated]
	private void GKPODAFCGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7620", Offset = "0x5CD6020", VA = "0x185CD7620")]
	[CompilerGenerated]
	private void AJMMHACDBNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CDDC50", Offset = "0x5CDC650", VA = "0x185CDDC50")]
	[CompilerGenerated]
	private bool KOEHLABLLJB(KeepsakeInstanceDTO FBHIPILAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA850", Offset = "0x5CD9250", VA = "0x185CDA850")]
	[CompilerGenerated]
	private bool EFGBHEBMABC(KeepsakeRoomListDTO FBHIPILAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CD91B0", Offset = "0x5CD7BB0", VA = "0x185CD91B0")]
	[CompilerGenerated]
	private void COKAGOFHCCF(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> CHMIIAOHKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5CD71B0", Offset = "0x5CD5BB0", VA = "0x185CD71B0")]
	[CompilerGenerated]
	private void ABHPMLPMKPJ(string OOMNIJBIFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CD8F70", Offset = "0x5CD7970", VA = "0x185CD8F70")]
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
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
				public BFFKLMKDHIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5CD7180", Offset = "0x5CD5B80", VA = "0x185CD7180")]
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
			[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] FAEKPALKIGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1440", Offset = "0x5CDFE40", VA = "0x185CE1440")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1320", Offset = "0x5CDFD20", VA = "0x185CE1320")]
		[PILNOHNDGDF(KBMKLHMPDPB.None)]
		private static void HJAIOHOJGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xEC6A60", Offset = "0xEC5460", VA = "0x180EC6A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1B40", Offset = "0x5CE0540", VA = "0x185CE1B40")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE17F0", Offset = "0x5CE01F0", VA = "0x185CE17F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
