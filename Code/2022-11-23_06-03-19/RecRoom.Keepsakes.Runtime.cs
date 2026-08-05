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
public enum HAIAHPOBAPG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[FHALNKLDOKP]
public class ODMOMCDKKHG : FCFHGHFGMNM, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct LAPPOPANONP
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string ACKHLEFIPIO = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string BNJBHCAKCJA = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string JFKMDHKPDNM = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string ONFDAFPLINK = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string NKBMKAIBPDA = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string HMPNJADOKBO = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string LNHNIKIHJFF = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string OJIODCOOAME = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string JKLBMGMDGMA = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string EEIBPLGNAAN = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string DKIBDFDCBBM = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JKICMGFEPMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public ODMOMCDKKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public JKICMGFEPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5B1EBD0", Offset = "0x5B1D9D0", VA = "0x185B1EBD0")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GFHKMLANKIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public ODMOMCDKKHG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GFHKMLANKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E6C0", Offset = "0x5B1D4C0", VA = "0x185B1E6C0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E750", Offset = "0x5B1D550", VA = "0x185B1E750")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E780", Offset = "0x5B1D580", VA = "0x185B1E780")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E970", Offset = "0x5B1D770", VA = "0x185B1E970")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E970", Offset = "0x5B1D770", VA = "0x185B1E970")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CKPFKINKPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public ODMOMCDKKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public CKPFKINKPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E450", Offset = "0x5B1D250", VA = "0x185B1E450")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E520", Offset = "0x5B1D320", VA = "0x185B1E520")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E520", Offset = "0x5B1D320", VA = "0x185B1E520")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KLMEFDBCJFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public KLMEFDBCJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x146E8E0", Offset = "0x146D6E0", VA = "0x18146E8E0")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DDDNHEHOHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public DDDNHEHOHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E620", Offset = "0x5B1D420", VA = "0x185B1E620")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KIEHOODOOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public KIEHOODOOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1F640", Offset = "0x5B1E440", VA = "0x185B1F640")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AHAEDDMEENI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public ODMOMCDKKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FAFEPBBAFLL args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5B1DFE0", Offset = "0x5B1CDE0", VA = "0x185B1DFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IMECAHPLHDA : IAsyncStateMachine
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
		public ODMOMCDKKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E990", Offset = "0x5B1D790", VA = "0x185B1E990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime BDJMBONIELE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int CDKIGCGLGLF = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime CLHNGLKEPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DateTime CHAPFNFLFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MLCGJDDDGDE PMGBENPJFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HPIGGOHLABK NDLGKHJNNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FONHOINMDOA JAJJICAEOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CCNDMEAJLEO OHJFINJMPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GEACCIIFOMJ NHBDFDDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GIFNICJMCAD IBGCMADMDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EPICHIOPPLH GFKDEPHPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PKJMFNAKBLI IJNIKOCLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HGLEBIGPNFK PFBNKBGKGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly ANAIFCBBMIO MLKCPJNBADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly IPJJONCKPCA MDGMMAHFLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BLOELNKBIMG FHBPGDENDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly JPOAKDKBEIA IEFILNOGIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly ODGGDPDGHIB MHIJNFDOFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly NJEJEKPFPFL JNCMLGMJLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly global::LNGIJBODKAL<KeepsakesConfig.KeepsakesOptions> PCNKMHOFIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> DKGHMMBOFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<Guid> NCANCGPMMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<long> GJFDMNAGNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int IAPPANOMKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<Guid> BCHFJLNKCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IDisposable NDNFHLJOHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Task BLLODKLIAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? FBOKDOKAEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO ICPIBLBIMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private global::CGDFFALNLAC<KeepsakeProgressionEventInstancesDTO> KDCCBMNENMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<PLFIICNMFDK, KeepsakeCategoryConfigDTO> AOKHJJDHLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO PPBIOJDCBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> GDDJJGKKDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> HBCJCDEIFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> DKDHHMHFKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> MGMDDILHPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomDTO> JAOOBDEDFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<string> CHKDHHIEDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DateTime DCNDBMJIGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IDisposable IPGHLADBOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool NJNCNPDOKKA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GMAIPICNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE20", Offset = "0x6ECC20", VA = "0x1806EDE20", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x895130", Offset = "0x893F30", VA = "0x180895130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime PLGDJOMMIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5B266E0", Offset = "0x5B254E0", VA = "0x185B266E0", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime LDINLBLOION
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5B1F940", Offset = "0x5B1E740", VA = "0x185B1F940", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KBACMMIBLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5B273E0", Offset = "0x5B261E0", VA = "0x185B273E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HGIOCEKJBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B1FEA0", Offset = "0x5B1ECA0", VA = "0x185B1FEA0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long AAKLEPGCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B267A0", Offset = "0x5B255A0", VA = "0x185B267A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? ELMMMGEKIOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B20080", Offset = "0x5B1EE80", VA = "0x185B20080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool HJHLABNLDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5B218A0", Offset = "0x5B206A0", VA = "0x185B218A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool BPHEJMEAPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1634740", Offset = "0x1633540", VA = "0x181634740")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5B218B0", Offset = "0x5B206B0", VA = "0x185B218B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> JKPLKAILKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5B1FE00", Offset = "0x5B1EC00", VA = "0x185B1FE00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5B27AB0", Offset = "0x5B268B0", VA = "0x185B27AB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LJMOJKECJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5B1FFE0", Offset = "0x5B1EDE0", VA = "0x185B1FFE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5B25B90", Offset = "0x5B24990", VA = "0x185B25B90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LMIBDAHACIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5B24FB0", Offset = "0x5B23DB0", VA = "0x185B24FB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5B235B0", Offset = "0x5B223B0", VA = "0x185B235B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B27EA0", Offset = "0x5B26CA0", VA = "0x185B27EA0")]
	[Preserve]
	internal ODMOMCDKKHG([NotNull][MAEEAOEDELI(null)] MLCGJDDDGDE PMGBENPJFLL, [NotNull][MAEEAOEDELI(null)] MICIFMKOOPE DBOHCDEHNOJ, [NotNull][MAEEAOEDELI(null)] HPIGGOHLABK NDLGKHJNNLB, [NotNull][MAEEAOEDELI(null)] FONHOINMDOA JAJJICAEOHD, [NotNull][MAEEAOEDELI(null)] CCNDMEAJLEO OHJFINJMPKL, [NotNull][MAEEAOEDELI(null)] GEACCIIFOMJ NHBDFDDDAKD, [NotNull][MAEEAOEDELI(null)] GIFNICJMCAD IBGCMADMDKM, [NotNull][MAEEAOEDELI(null)] EPICHIOPPLH GFKDEPHPIIE, [NotNull][MAEEAOEDELI(null)] PKJMFNAKBLI IJNIKOCLGEN, [NotNull][MAEEAOEDELI(null)] FJGCGJBADIF FDKMGIGNAED, [NotNull][MAEEAOEDELI(null)] HGLEBIGPNFK PFBNKBGKGAN, [NotNull][MAEEAOEDELI(null)] ANAIFCBBMIO MLKCPJNBADB, [NotNull][MAEEAOEDELI(null)] IPJJONCKPCA MDGMMAHFLKP, [NotNull][MAEEAOEDELI(null)] BLOELNKBIMG FHBPGDENDLJ, [NotNull][MAEEAOEDELI(null)] JPOAKDKBEIA IEFILNOGIBF, [NotNull][MAEEAOEDELI(null)] ODGGDPDGHIB MHIJNFDOFCE, [NotNull][MAEEAOEDELI(null)] NJEJEKPFPFL JNCMLGMJLJL, [NotNull][MAEEAOEDELI(null)] global::LNGIJBODKAL<KeepsakesConfig.KeepsakesOptions> PCNKMHOFIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B21110", Offset = "0x5B1FF10", VA = "0x185B21110", Slot = "13")]
	public bool CMCNJBAEDIJ(List<string> FEAEBCBJLIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B26E40", Offset = "0x5B25C40", VA = "0x185B26E40", Slot = "14")]
	public global::CGDFFALNLAC<Guid> ODKHBDBHKJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B20E90", Offset = "0x5B1FC90", VA = "0x185B20E90", Slot = "35")]
	public FKDPJJAEIFK CLNGNEOBFJL(Guid INIMMFPCLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B1FA00", Offset = "0x5B1E800", VA = "0x185B1FA00", Slot = "15")]
	public FKDPJJAEIFK AKJJKMALONH(Guid INIMMFPCLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5B25A50", Offset = "0x5B24850", VA = "0x185B25A50", Slot = "16")]
	public bool MHFEEJJGPFE(Guid INIMMFPCLGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5B24360", Offset = "0x5B23160", VA = "0x185B24360", Slot = "17")]
	public bool JKEOPJKBONP(Guid INIMMFPCLGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5B20D70", Offset = "0x5B1FB70", VA = "0x185B20D70", Slot = "18")]
	public KeepsakeTheme CIAJOKCBGMI(Guid INIMMFPCLGP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5B20BB0", Offset = "0x5B1F9B0", VA = "0x185B20BB0", Slot = "19")]
	public KeepsakeTheme CIAJOKCBGMI(PLFIICNMFDK LGIPFLABABG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5B27430", Offset = "0x5B26230", VA = "0x185B27430", Slot = "20")]
	public bool OONBGNENLCH(Guid INIMMFPCLGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B24EC0", Offset = "0x5B23CC0", VA = "0x185B24EC0", Slot = "21")]
	public void KKDGGEJPNNK(Guid INIMMFPCLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B202D0", Offset = "0x5B1F0D0", VA = "0x185B202D0", Slot = "22")]
	public void BPMINIIGKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B252A0", Offset = "0x5B240A0", VA = "0x185B252A0", Slot = "23")]
	public void LDKNBMGIMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B21980", Offset = "0x5B20780", VA = "0x185B21980", Slot = "24")]
	public int DLPAGJEHDJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B23CD0", Offset = "0x5B22AD0", VA = "0x185B23CD0", Slot = "25")]
	public global::CGDFFALNLAC<int> IPIDDBGFKMO(long HMOGFNMOLJM, long BJMLBGLDMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5B20B50", Offset = "0x5B1F950", VA = "0x185B20B50", Slot = "27")]
	public bool CHCFGGHDMFK(long HMOGFNMOLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5B27660", Offset = "0x5B26460", VA = "0x185B27660", Slot = "36")]
	public bool OOPLKBNPKJC(long HMOGFNMOLJM, out EOHKBJODGHN OMGANHIIOCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B270D0", Offset = "0x5B25ED0", VA = "0x185B270D0", Slot = "28")]
	public long OMPMBMBOBLC(ADDAOAJPEJN NJOHNAAKDHO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B25050", Offset = "0x5B23E50", VA = "0x185B25050", Slot = "29")]
	public IEnumerable<int> LBMDKKHKECN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B23180", Offset = "0x5B21F80", VA = "0x185B23180", Slot = "30")]
	public bool GINAKLGHLIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B20350", Offset = "0x5B1F150", VA = "0x185B20350", Slot = "31")]
	public IEnumerable<long> CDPBLOMMFAF(GGABOPCCGCE IJANLMCPOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B22CF0", Offset = "0x5B21AF0", VA = "0x185B22CF0", Slot = "32")]
	public int GCEGFBJGPNJ(GGABOPCCGCE IJANLMCPOGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B25C30", Offset = "0x5B24A30", VA = "0x185B25C30")]
	private void MLDDFOLBBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B20120", Offset = "0x5B1EF20", VA = "0x185B20120")]
	private int BOHCGGDMFCO(KeepsakeRoomListDTO FEHJLPJPDMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B257C0", Offset = "0x5B245C0", VA = "0x185B257C0")]
	private int LPOAKKBALLF(DateTime BMNIGDNBLFF, DateTime AIKJHCAHCPA, TimeSpan POBNNFBKNMA, int COHCKCPOKDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B25500", Offset = "0x5B24300", VA = "0x185B25500")]
	private bool LPKAMPABMLF(long HGPAPBKCLPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B23650", Offset = "0x5B22450", VA = "0x185B23650")]
	private void IHAAMLPKOKD(IEnumerable<KeepsakeInstanceDTO> DKGHMMBOFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5B21740", Offset = "0x5B20540", VA = "0x185B21740")]
	private void DEMGBLDJHCP(IEnumerable<KeepsakeCollectionRecordDTO> FJFIOECANBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5B202F0", Offset = "0x5B1F0F0", VA = "0x185B202F0")]
	private void CAKHHEIPHLB(IEnumerable<long> EFMGHGIMHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5B25360", Offset = "0x5B24160", VA = "0x185B25360")]
	private void LHIPPIBAJJN(IEnumerable<KeepsakeCategoryConfigDTO> PLHBKKLFOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8ABDA0", Offset = "0x8AABA0", VA = "0x1808ABDA0")]
	private void GKLGBPKEGMA(KeepsakeGlobalConfigDTO PPBIOJDCBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5B27B50", Offset = "0x5B26950", VA = "0x185B27B50")]
	private bool PNMHOKKGONM(out Guid AMJPBNIJJFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5B241A0", Offset = "0x5B22FA0", VA = "0x185B241A0")]
	private void JDDNDNMKHIL(KeepsakeInstanceDTO OCIFOLOJAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5B22F80", Offset = "0x5B21D80", VA = "0x185B22F80")]
	private void GEFNFLHHPDC(KeepsakeInstanceDTO OCIFOLOJAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5B234D0", Offset = "0x5B222D0", VA = "0x185B234D0")]
	private void HGFEGPIDEBP(Guid INIMMFPCLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5B27A50", Offset = "0x5B26850", VA = "0x185B27A50")]
	private void OPONMJOKDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5B21720", Offset = "0x5B20520", VA = "0x185B21720")]
	private void DCAOMNDIPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5B1FF60", Offset = "0x5B1ED60", VA = "0x185B1FF60")]
	private void BKJJDHKCNGL(GBLFGEDHNKK IELAMMJPGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5B21920", Offset = "0x5B20720", VA = "0x185B21920")]
	private void DKGHFHKPIGB(MIOLNDLPDAD.EEEGOIBINFM KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5B260C0", Offset = "0x5B24EC0", VA = "0x185B260C0")]
	private void NFBNEPOKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5B23880", Offset = "0x5B22680", VA = "0x185B23880")]
	private void INCFCLPAEKK(float LGBEGLHHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5B221E0", Offset = "0x5B20FE0", VA = "0x185B221E0")]
	private void EPMPNHNBFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5B22D90", Offset = "0x5B21B90", VA = "0x185B22D90")]
	private bool GDMKFMBLBOK(Guid INIMMFPCLGP, out string JFPBFKMHBPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5B26510", Offset = "0x5B25310", VA = "0x185B26510")]
	private bool NGLDGMDBJNO(Guid INIMMFPCLGP, out KeepsakeCategoryConfigDTO LJAGCAFHCCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5B26D60", Offset = "0x5B25B60", VA = "0x185B26D60")]
	private void OBNJFGOMPHB(string PGOGDHDNIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5B21610", Offset = "0x5B20410", VA = "0x185B21610")]
	private bool DBINFOGLDFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5B228A0", Offset = "0x5B216A0", VA = "0x185B228A0")]
	private bool FCJBALNAHAP(Guid INIMMFPCLGP, out string OMKDGOMBDIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5B24450", Offset = "0x5B23250", VA = "0x185B24450")]
	private void KAOGLBCIPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5B24390", Offset = "0x5B23190", VA = "0x185B24390")]
	private void JOFNCHFLCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5B22050", Offset = "0x5B20E50", VA = "0x185B22050")]
	internal static string EJEAFGIAIIF(MJBDHCOGAAH OEBKHLCEBJP, string MPAOCFKDMNF, bool KMKMIBNOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5B21BF0", Offset = "0x5B209F0", VA = "0x185B21BF0", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5B24F30", Offset = "0x5B23D30", VA = "0x185B24F30")]
	private EDADMNIFEBK KMHLKNMCPPM(HHODDDLIHOO GNBHGCMNEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5B26880", Offset = "0x5B25680", VA = "0x185B26880")]
	private HDIPLEEAOIL NMDOFKBBGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5B26A20", Offset = "0x5B25820", VA = "0x185B26A20")]
	private Task NMHDHMGOEHL(FAFEPBBAFLL MAGEMABOILP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5B22750", Offset = "0x5B21550", VA = "0x185B22750")]
	[AsyncStateMachine(typeof(AHAEDDMEENI))]
	private Task FBNJDJJJPAJ(FAFEPBBAFLL MAGEMABOILP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5B23C40", Offset = "0x5B22A40", VA = "0x185B23C40")]
	private Task IOEAKMMDNKG(FAFEPBBAFLL MAGEMABOILP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5B258B0", Offset = "0x5B246B0", VA = "0x185B258B0")]
	[AsyncStateMachine(typeof(IMECAHPLHDA))]
	private Task MGDJMCJNHLM(string HDKJDEIGPPL, TimeSpan CFJOBMBABIN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B25890", Offset = "0x5B24690", VA = "0x185B25890")]
	[CompilerGenerated]
	private void MFLNOIPDGPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5B25A00", Offset = "0x5B24800", VA = "0x185B25A00")]
	[CompilerGenerated]
	private void MGINJIIPJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5B26120", Offset = "0x5B24F20", VA = "0x185B26120")]
	[CompilerGenerated]
	private void NGCNMGOCACD(string OMKDGOMBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5B25890", Offset = "0x5B24690", VA = "0x185B25890")]
	[CompilerGenerated]
	private void PMJCPCNJNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5B1FDB0", Offset = "0x5B1EBB0", VA = "0x185B1FDB0")]
	[CompilerGenerated]
	private void AKPMHLJKLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5B24DD0", Offset = "0x5B23BD0", VA = "0x185B24DD0")]
	[CompilerGenerated]
	private bool KEFGAIGNEBM(KeepsakeInstanceDTO IODEOJKDCNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5B260A0", Offset = "0x5B24EA0", VA = "0x185B260A0")]
	[CompilerGenerated]
	private bool MOECLEHAAEO(KeepsakeRoomListDTO IODEOJKDCNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5B23270", Offset = "0x5B22070", VA = "0x185B23270")]
	[CompilerGenerated]
	private void HFKKMLNAKNH(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> DMHMAFOOFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5B22C90", Offset = "0x5B21A90", VA = "0x185B22C90")]
	[CompilerGenerated]
	private void FPFBEJBBEBL(string OMKDGOMBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5B21420", Offset = "0x5B20220", VA = "0x185B21420")]
	[CompilerGenerated]
	private Task CPDJKOINJKH(CancellationToken AIOMDHBAEHA)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::LNGIJBODKAL<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class PBIKCPAPEKA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
				public PBIKCPAPEKA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5B28F20", Offset = "0x5B27D20", VA = "0x185B28F20")]
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
			[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] NJJGPFJNOOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5B1F800", Offset = "0x5B1E600", VA = "0x185B1F800")]
			public KeepsakeTheme CIAJOKCBGMI(string LDCAHEEPDBD)
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5B1F6E0", Offset = "0x5B1E4E0", VA = "0x185B1F6E0")]
		[IIBELCEICEH(INPGEEFAPCN.None)]
		private static void FNPDOJFFBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AD0", Offset = "0x6D58D0", VA = "0x1806D6AD0")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5B1F010", Offset = "0x5B1DE10", VA = "0x185B1F010")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5B1F120", Offset = "0x5B1DF20", VA = "0x185B1F120")]
	public static string HPJOPLJIOMI(byte[] EHAMCGPFFID, bool BLMJHFAPIFG)
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
