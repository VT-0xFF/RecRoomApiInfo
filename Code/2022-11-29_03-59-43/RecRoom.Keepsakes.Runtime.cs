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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public JKICMGFEPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5CA7600", Offset = "0x5CA6200", VA = "0x185CA7600")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public GFHKMLANKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5CA70F0", Offset = "0x5CA5CF0", VA = "0x185CA70F0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA7180", Offset = "0x5CA5D80", VA = "0x185CA7180")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA71B0", Offset = "0x5CA5DB0", VA = "0x185CA71B0")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA73A0", Offset = "0x5CA5FA0", VA = "0x185CA73A0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA73A0", Offset = "0x5CA5FA0", VA = "0x185CA73A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public CKPFKINKPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5CA6E80", Offset = "0x5CA5A80", VA = "0x185CA6E80")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CA6F50", Offset = "0x5CA5B50", VA = "0x185CA6F50")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5CA6F50", Offset = "0x5CA5B50", VA = "0x185CA6F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public KLMEFDBCJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1143010", Offset = "0x1141C10", VA = "0x181143010")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public DDDNHEHOHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA7050", Offset = "0x5CA5C50", VA = "0x185CA7050")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public KIEHOODOOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8070", Offset = "0x5CA6C70", VA = "0x185CA8070")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CA6A10", Offset = "0x5CA5610", VA = "0x185CA6A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CA73C0", Offset = "0x5CA5FC0", VA = "0x185CA73C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675C30", VA = "0x180677030", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x812720", Offset = "0x811320", VA = "0x180812720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime PLGDJOMMIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF110", Offset = "0x5CADD10", VA = "0x185CAF110", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime LDINLBLOION
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8370", Offset = "0x5CA6F70", VA = "0x185CA8370", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KBACMMIBLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CAFE10", Offset = "0x5CAEA10", VA = "0x185CAFE10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HGIOCEKJBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA88D0", Offset = "0x5CA74D0", VA = "0x185CA88D0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long AAKLEPGCAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF1D0", Offset = "0x5CADDD0", VA = "0x185CAF1D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? ELMMMGEKIOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8AB0", Offset = "0x5CA76B0", VA = "0x185CA8AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool HJHLABNLDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA2D0", Offset = "0x5CA8ED0", VA = "0x185CAA2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool BPHEJMEAPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10ADCE0", Offset = "0x10AC8E0", VA = "0x1810ADCE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA2E0", Offset = "0x5CA8EE0", VA = "0x185CAA2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> JKPLKAILKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8830", Offset = "0x5CA7430", VA = "0x185CA8830", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CB04E0", Offset = "0x5CAF0E0", VA = "0x185CB04E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LJMOJKECJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8A10", Offset = "0x5CA7610", VA = "0x185CA8A10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE5C0", Offset = "0x5CAD1C0", VA = "0x185CAE5C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LMIBDAHACIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD9E0", Offset = "0x5CAC5E0", VA = "0x185CAD9E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CABFE0", Offset = "0x5CAABE0", VA = "0x185CABFE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CB08D0", Offset = "0x5CAF4D0", VA = "0x185CB08D0")]
	[Preserve]
	internal ODMOMCDKKHG([NotNull][MAEEAOEDELI(null)] MLCGJDDDGDE PMGBENPJFLL, [NotNull][MAEEAOEDELI(null)] MICIFMKOOPE DBOHCDEHNOJ, [NotNull][MAEEAOEDELI(null)] HPIGGOHLABK NDLGKHJNNLB, [NotNull][MAEEAOEDELI(null)] FONHOINMDOA JAJJICAEOHD, [NotNull][MAEEAOEDELI(null)] CCNDMEAJLEO OHJFINJMPKL, [NotNull][MAEEAOEDELI(null)] GEACCIIFOMJ NHBDFDDDAKD, [NotNull][MAEEAOEDELI(null)] GIFNICJMCAD IBGCMADMDKM, [NotNull][MAEEAOEDELI(null)] EPICHIOPPLH GFKDEPHPIIE, [NotNull][MAEEAOEDELI(null)] PKJMFNAKBLI IJNIKOCLGEN, [NotNull][MAEEAOEDELI(null)] FJGCGJBADIF FDKMGIGNAED, [NotNull][MAEEAOEDELI(null)] HGLEBIGPNFK PFBNKBGKGAN, [NotNull][MAEEAOEDELI(null)] ANAIFCBBMIO MLKCPJNBADB, [NotNull][MAEEAOEDELI(null)] IPJJONCKPCA MDGMMAHFLKP, [NotNull][MAEEAOEDELI(null)] BLOELNKBIMG FHBPGDENDLJ, [NotNull][MAEEAOEDELI(null)] JPOAKDKBEIA IEFILNOGIBF, [NotNull][MAEEAOEDELI(null)] ODGGDPDGHIB MHIJNFDOFCE, [NotNull][MAEEAOEDELI(null)] NJEJEKPFPFL JNCMLGMJLJL, [NotNull][MAEEAOEDELI(null)] global::LNGIJBODKAL<KeepsakesConfig.KeepsakesOptions> PCNKMHOFIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9B40", Offset = "0x5CA8740", VA = "0x185CA9B40", Slot = "13")]
	public bool CMCNJBAEDIJ(List<string> FEAEBCBJLIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF870", Offset = "0x5CAE470", VA = "0x185CAF870", Slot = "14")]
	public global::CGDFFALNLAC<Guid> ODKHBDBHKJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CA98C0", Offset = "0x5CA84C0", VA = "0x185CA98C0", Slot = "35")]
	public FKDPJJAEIFK CLNGNEOBFJL(Guid INIMMFPCLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8430", Offset = "0x5CA7030", VA = "0x185CA8430", Slot = "15")]
	public FKDPJJAEIFK AKJJKMALONH(Guid INIMMFPCLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE480", Offset = "0x5CAD080", VA = "0x185CAE480", Slot = "16")]
	public bool MHFEEJJGPFE(Guid INIMMFPCLGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CACD90", Offset = "0x5CAB990", VA = "0x185CACD90", Slot = "17")]
	public bool JKEOPJKBONP(Guid INIMMFPCLGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CA97A0", Offset = "0x5CA83A0", VA = "0x185CA97A0", Slot = "18")]
	public KeepsakeTheme CIAJOKCBGMI(Guid INIMMFPCLGP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA95E0", Offset = "0x5CA81E0", VA = "0x185CA95E0", Slot = "19")]
	public KeepsakeTheme CIAJOKCBGMI(PLFIICNMFDK LGIPFLABABG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAFE60", Offset = "0x5CAEA60", VA = "0x185CAFE60", Slot = "20")]
	public bool OONBGNENLCH(Guid INIMMFPCLGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD8F0", Offset = "0x5CAC4F0", VA = "0x185CAD8F0", Slot = "21")]
	public void KKDGGEJPNNK(Guid INIMMFPCLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8D00", Offset = "0x5CA7900", VA = "0x185CA8D00", Slot = "22")]
	public void BPMINIIGKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CADCD0", Offset = "0x5CAC8D0", VA = "0x185CADCD0", Slot = "23")]
	public void LDKNBMGIMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA3B0", Offset = "0x5CA8FB0", VA = "0x185CAA3B0", Slot = "24")]
	public int DLPAGJEHDJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC700", Offset = "0x5CAB300", VA = "0x185CAC700", Slot = "25")]
	public global::CGDFFALNLAC<int> IPIDDBGFKMO(long HMOGFNMOLJM, long BJMLBGLDMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9580", Offset = "0x5CA8180", VA = "0x185CA9580", Slot = "27")]
	public bool CHCFGGHDMFK(long HMOGFNMOLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CB0090", Offset = "0x5CAEC90", VA = "0x185CB0090", Slot = "36")]
	public bool OOPLKBNPKJC(long HMOGFNMOLJM, out EOHKBJODGHN OMGANHIIOCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CAFB00", Offset = "0x5CAE700", VA = "0x185CAFB00", Slot = "28")]
	public long OMPMBMBOBLC(ADDAOAJPEJN NJOHNAAKDHO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CADA80", Offset = "0x5CAC680", VA = "0x185CADA80", Slot = "29")]
	public IEnumerable<int> LBMDKKHKECN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CABBB0", Offset = "0x5CAA7B0", VA = "0x185CABBB0", Slot = "30")]
	public bool GINAKLGHLIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8D80", Offset = "0x5CA7980", VA = "0x185CA8D80", Slot = "31")]
	public IEnumerable<long> CDPBLOMMFAF(GGABOPCCGCE IJANLMCPOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB720", Offset = "0x5CAA320", VA = "0x185CAB720", Slot = "32")]
	public int GCEGFBJGPNJ(GGABOPCCGCE IJANLMCPOGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE660", Offset = "0x5CAD260", VA = "0x185CAE660")]
	private void MLDDFOLBBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8B50", Offset = "0x5CA7750", VA = "0x185CA8B50")]
	private int BOHCGGDMFCO(KeepsakeRoomListDTO FEHJLPJPDMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE1F0", Offset = "0x5CACDF0", VA = "0x185CAE1F0")]
	private int LPOAKKBALLF(DateTime BMNIGDNBLFF, DateTime AIKJHCAHCPA, TimeSpan POBNNFBKNMA, int COHCKCPOKDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CADF30", Offset = "0x5CACB30", VA = "0x185CADF30")]
	private bool LPKAMPABMLF(long HGPAPBKCLPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC080", Offset = "0x5CAAC80", VA = "0x185CAC080")]
	private void IHAAMLPKOKD(IEnumerable<KeepsakeInstanceDTO> DKGHMMBOFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA170", Offset = "0x5CA8D70", VA = "0x185CAA170")]
	private void DEMGBLDJHCP(IEnumerable<KeepsakeCollectionRecordDTO> FJFIOECANBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8D20", Offset = "0x5CA7920", VA = "0x185CA8D20")]
	private void CAKHHEIPHLB(IEnumerable<long> EFMGHGIMHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CADD90", Offset = "0x5CAC990", VA = "0x185CADD90")]
	private void LHIPPIBAJJN(IEnumerable<KeepsakeCategoryConfigDTO> PLHBKKLFOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x13A0660", Offset = "0x139F260", VA = "0x1813A0660")]
	private void GKLGBPKEGMA(KeepsakeGlobalConfigDTO PPBIOJDCBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CB0580", Offset = "0x5CAF180", VA = "0x185CB0580")]
	private bool PNMHOKKGONM(out Guid AMJPBNIJJFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CACBD0", Offset = "0x5CAB7D0", VA = "0x185CACBD0")]
	private void JDDNDNMKHIL(KeepsakeInstanceDTO OCIFOLOJAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB9B0", Offset = "0x5CAA5B0", VA = "0x185CAB9B0")]
	private void GEFNFLHHPDC(KeepsakeInstanceDTO OCIFOLOJAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CABF00", Offset = "0x5CAAB00", VA = "0x185CABF00")]
	private void HGFEGPIDEBP(Guid INIMMFPCLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CB0480", Offset = "0x5CAF080", VA = "0x185CB0480")]
	private void OPONMJOKDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA150", Offset = "0x5CA8D50", VA = "0x185CAA150")]
	private void DCAOMNDIPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8990", Offset = "0x5CA7590", VA = "0x185CA8990")]
	private void BKJJDHKCNGL(GBLFGEDHNKK IELAMMJPGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA350", Offset = "0x5CA8F50", VA = "0x185CAA350")]
	private void DKGHFHKPIGB(MIOLNDLPDAD.EEEGOIBINFM KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CAEAF0", Offset = "0x5CAD6F0", VA = "0x185CAEAF0")]
	private void NFBNEPOKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC2B0", Offset = "0x5CAAEB0", VA = "0x185CAC2B0")]
	private void INCFCLPAEKK(float LGBEGLHHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAAC10", Offset = "0x5CA9810", VA = "0x185CAAC10")]
	private void EPMPNHNBFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB7C0", Offset = "0x5CAA3C0", VA = "0x185CAB7C0")]
	private bool GDMKFMBLBOK(Guid INIMMFPCLGP, out string JFPBFKMHBPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAEF40", Offset = "0x5CADB40", VA = "0x185CAEF40")]
	private bool NGLDGMDBJNO(Guid INIMMFPCLGP, out KeepsakeCategoryConfigDTO LJAGCAFHCCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF790", Offset = "0x5CAE390", VA = "0x185CAF790")]
	private void OBNJFGOMPHB(string PGOGDHDNIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA040", Offset = "0x5CA8C40", VA = "0x185CAA040")]
	private bool DBINFOGLDFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB2D0", Offset = "0x5CA9ED0", VA = "0x185CAB2D0")]
	private bool FCJBALNAHAP(Guid INIMMFPCLGP, out string OMKDGOMBDIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CACE80", Offset = "0x5CABA80", VA = "0x185CACE80")]
	private void KAOGLBCIPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CACDC0", Offset = "0x5CAB9C0", VA = "0x185CACDC0")]
	private void JOFNCHFLCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CAAA80", Offset = "0x5CA9680", VA = "0x185CAAA80")]
	internal static string EJEAFGIAIIF(MJBDHCOGAAH OEBKHLCEBJP, string MPAOCFKDMNF, bool KMKMIBNOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA620", Offset = "0x5CA9220", VA = "0x185CAA620", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD960", Offset = "0x5CAC560", VA = "0x185CAD960")]
	private EDADMNIFEBK KMHLKNMCPPM(HHODDDLIHOO GNBHGCMNEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF2B0", Offset = "0x5CADEB0", VA = "0x185CAF2B0")]
	private HDIPLEEAOIL NMDOFKBBGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF450", Offset = "0x5CAE050", VA = "0x185CAF450")]
	private Task NMHDHMGOEHL(FAFEPBBAFLL MAGEMABOILP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB180", Offset = "0x5CA9D80", VA = "0x185CAB180")]
	[AsyncStateMachine(typeof(AHAEDDMEENI))]
	private Task FBNJDJJJPAJ(FAFEPBBAFLL MAGEMABOILP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC670", Offset = "0x5CAB270", VA = "0x185CAC670")]
	private Task IOEAKMMDNKG(FAFEPBBAFLL MAGEMABOILP, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE2E0", Offset = "0x5CACEE0", VA = "0x185CAE2E0")]
	[AsyncStateMachine(typeof(IMECAHPLHDA))]
	private Task MGDJMCJNHLM(string HDKJDEIGPPL, TimeSpan CFJOBMBABIN, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE2C0", Offset = "0x5CACEC0", VA = "0x185CAE2C0")]
	[CompilerGenerated]
	private void MFLNOIPDGPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE430", Offset = "0x5CAD030", VA = "0x185CAE430")]
	[CompilerGenerated]
	private void MGINJIIPJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAEB50", Offset = "0x5CAD750", VA = "0x185CAEB50")]
	[CompilerGenerated]
	private void NGCNMGOCACD(string OMKDGOMBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE2C0", Offset = "0x5CACEC0", VA = "0x185CAE2C0")]
	[CompilerGenerated]
	private void PMJCPCNJNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CA87E0", Offset = "0x5CA73E0", VA = "0x185CA87E0")]
	[CompilerGenerated]
	private void AKPMHLJKLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD800", Offset = "0x5CAC400", VA = "0x185CAD800")]
	[CompilerGenerated]
	private bool KEFGAIGNEBM(KeepsakeInstanceDTO IODEOJKDCNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CAEAD0", Offset = "0x5CAD6D0", VA = "0x185CAEAD0")]
	[CompilerGenerated]
	private bool MOECLEHAAEO(KeepsakeRoomListDTO IODEOJKDCNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CABCA0", Offset = "0x5CAA8A0", VA = "0x185CABCA0")]
	[CompilerGenerated]
	private void HFKKMLNAKNH(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> DMHMAFOOFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB6C0", Offset = "0x5CAA2C0", VA = "0x185CAB6C0")]
	[CompilerGenerated]
	private void FPFBEJBBEBL(string OMKDGOMBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9E50", Offset = "0x5CA8A50", VA = "0x185CA9E50")]
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
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
				public PBIKCPAPEKA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5CB1950", Offset = "0x5CB0550", VA = "0x185CB1950")]
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
			[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] NJJGPFJNOOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5CA8230", Offset = "0x5CA6E30", VA = "0x185CA8230")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8110", Offset = "0x5CA6D10", VA = "0x185CA8110")]
		[IIBELCEICEH(INPGEEFAPCN.None)]
		private static void FNPDOJFFBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xF00AE0", Offset = "0xEFF6E0", VA = "0x180F00AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7A40", Offset = "0x5CA6640", VA = "0x185CA7A40")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7B50", Offset = "0x5CA6750", VA = "0x185CA7B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
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
