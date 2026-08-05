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
public enum BBANALJMLEL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[OBLFKCJHKCO]
public class BOHACEAKBDF : AJNPBFLLOAG, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct FBFGBFGDOEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string HGCHLNPLMON = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string BNJMNNAHHNB = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string GLDMCLKLEHC = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string HPONDGONCEO = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string JIJBGOCANFF = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string BFCKGNNBAND = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string JIOPGIFCHIP = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string DPBLEKPKDKC = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string FHFGHNFFFLI = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string NGDGOFBKOBG = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string GMJIMKDPDHJ = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class PIDECNHLHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public BOHACEAKBDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string collectionMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public PIDECNHLHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5B95580", Offset = "0x5B93F80", VA = "0x185B95580")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ENBFKEPIFKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public BOHACEAKBDF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ENBFKEPIFKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5B94030", Offset = "0x5B92A30", VA = "0x185B94030")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5B940C0", Offset = "0x5B92AC0", VA = "0x185B940C0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5B940F0", Offset = "0x5B92AF0", VA = "0x185B940F0")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5B942E0", Offset = "0x5B92CE0", VA = "0x185B942E0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5B942E0", Offset = "0x5B92CE0", VA = "0x185B942E0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OKODMOFLOIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BOHACEAKBDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public OKODMOFLOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5B953B0", Offset = "0x5B93DB0", VA = "0x185B953B0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5B95480", Offset = "0x5B93E80", VA = "0x185B95480")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5B95480", Offset = "0x5B93E80", VA = "0x185B95480")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PJNBEMECJJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public PJNBEMECJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x871B70", Offset = "0x870570", VA = "0x180871B70")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NMFCNPLEONH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public NMFCNPLEONH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5B95310", Offset = "0x5B93D10", VA = "0x185B95310")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LOFNKOEIFGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public LOFNKOEIFGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5B95270", Offset = "0x5B93C70", VA = "0x185B95270")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct KNLMGAHNMNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public BOHACEAKBDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CKILIMBDBDL args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5B94570", Offset = "0x5B92F70", VA = "0x185B94570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x795F10", Offset = "0x794910", VA = "0x180795F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HPGOMEKIBBH : IAsyncStateMachine
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
		public BOHACEAKBDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5B94300", Offset = "0x5B92D00", VA = "0x185B94300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x795F10", Offset = "0x794910", VA = "0x180795F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime AKBMKDFDDJI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int FMMFMDMCHPF = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime AOCJJNFFEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DateTime JPKEFFPCIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly DAEKJBALILI BKDDCKMGMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OMEAFNBMLLG BJDKAILPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly LJGFIMGHDKL EKANGFGFDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FGCGGIMBFOD EAECAHMNHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly JJDGEOGECBL HIOFANIPMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DOEGGINEFGD JMKFDOBGKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IHMLJIFLEEI GDJAGFOHIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FFGAPMCDFCA MCPBOIHDMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FKHLMFGIDDH MGBLBAGAJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NJEDDKBAFAA ALPHNGGIFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly JMDPKCPBJBE AOCGMHAICCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BIJKFLCEOFE JEKCJKLLHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NPMJNKFHEJP BGHHMJEFEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly EDLEFEDELLK MNKJIFJCNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly AEDFEFNOPPJ EAPJBGKLPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly global::ANPDAHLNPOE<KeepsakesConfig.KeepsakesOptions> EGFLOGJCPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> EOHOAGJMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<Guid> HCLJBAKOHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<long> KGNHCMMBHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int CIOFJHGOCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<Guid> JDJLFCPAEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IDisposable BBBMCELNONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Task MLEAMFGPOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? EBBFFAKPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO LIKCHAFIMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private global::LFIHKJLGIGB<KeepsakeProgressionEventInstancesDTO> GFHLBCIOCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<IMJJPBJDHEF, KeepsakeCategoryConfigDTO> BKPFBGPKOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO IMIMCCEJJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> MEMLGIGGHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> JAPMOLLEPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> DCDOLKAMCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> OIDKDKGDHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomDTO> OKANAEAAJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<string> HDHFDIONLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DateTime IODPDKKGFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IDisposable GLNDOCGCIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool ILIHDAAJIGF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GNDJOGNDKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69FE40", Offset = "0x69E840", VA = "0x18069FE40", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69FF10", Offset = "0x69E910", VA = "0x18069FF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime NDJHAIHBNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5B90DC0", Offset = "0x5B8F7C0", VA = "0x185B90DC0", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime OJOHFCBIBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5B8DA10", Offset = "0x5B8C410", VA = "0x185B8DA10", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NBAEHKMKKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8FBB0", Offset = "0x5B8E5B0", VA = "0x185B8FBB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JHGAOBPKFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8B5C0", Offset = "0x5B89FC0", VA = "0x185B8B5C0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long LICPFDFPBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B92A80", Offset = "0x5B91480", VA = "0x185B92A80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? HJMPDKOJDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B8FC00", Offset = "0x5B8E600", VA = "0x185B8FC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool JCDPGKMFPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5B8B680", Offset = "0x5B8A080", VA = "0x185B8B680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool FEPFJHGPOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x134F1D0", Offset = "0x134DBD0", VA = "0x18134F1D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5B8D7B0", Offset = "0x5B8C1B0", VA = "0x185B8D7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> HJCKOOCGPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5B92DB0", Offset = "0x5B917B0", VA = "0x185B92DB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5B8FA50", Offset = "0x5B8E450", VA = "0x185B8FA50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KJGMLOANCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5B8FB10", Offset = "0x5B8E510", VA = "0x185B8FB10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5B92E50", Offset = "0x5B91850", VA = "0x185B92E50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DHPDAKMBJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5B916F0", Offset = "0x5B900F0", VA = "0x185B916F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F9B0", Offset = "0x5B8E3B0", VA = "0x185B8F9B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B92FB0", Offset = "0x5B919B0", VA = "0x185B92FB0")]
	[Preserve]
	internal BOHACEAKBDF([NotNull][BJBHEPNDCKM(null)] DAEKJBALILI BKDDCKMGMDL, [NotNull][BJBHEPNDCKM(null)] NOCICKIJGMA IDGGCLBOBML, [NotNull][BJBHEPNDCKM(null)] OMEAFNBMLLG BJDKAILPJNG, [NotNull][BJBHEPNDCKM(null)] LJGFIMGHDKL EKANGFGFDLI, [NotNull][BJBHEPNDCKM(null)] FGCGGIMBFOD EAECAHMNHAH, [NotNull][BJBHEPNDCKM(null)] JJDGEOGECBL HIOFANIPMDG, [NotNull][BJBHEPNDCKM(null)] DOEGGINEFGD JMKFDOBGKPK, [NotNull][BJBHEPNDCKM(null)] IHMLJIFLEEI GDJAGFOHIMP, [NotNull][BJBHEPNDCKM(null)] FFGAPMCDFCA MCPBOIHDMMJ, [NotNull][BJBHEPNDCKM(null)] FIJOPFCCOIE KBMJKKOEELP, [NotNull][BJBHEPNDCKM(null)] FKHLMFGIDDH MGBLBAGAJDN, [NotNull][BJBHEPNDCKM(null)] NJEDDKBAFAA ALPHNGGIFJE, [NotNull][BJBHEPNDCKM(null)] JMDPKCPBJBE AOCGMHAICCP, [NotNull][BJBHEPNDCKM(null)] BIJKFLCEOFE JEKCJKLLHGO, [NotNull][BJBHEPNDCKM(null)] NPMJNKFHEJP BGHHMJEFEOG, [NotNull][BJBHEPNDCKM(null)] EDLEFEDELLK MNKJIFJCNIC, [NotNull][BJBHEPNDCKM(null)] AEDFEFNOPPJ EAPJBGKLPMP, [NotNull][BJBHEPNDCKM(null)] global::ANPDAHLNPOE<KeepsakesConfig.KeepsakesOptions> EGFLOGJCPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FCA0", Offset = "0x5B8E6A0", VA = "0x185B8FCA0", Slot = "13")]
	public bool KEDOICMCMOD(List<string> JMLDEIMPHDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B91EA0", Offset = "0x5B908A0", VA = "0x185B91EA0", Slot = "14")]
	public global::LFIHKJLGIGB<Guid> OIAGMGNNPFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B92130", Offset = "0x5B90B30", VA = "0x185B92130", Slot = "35")]
	public JFOAFMPHLMG OJFCDALPKPD(Guid MOFMFKKIPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B8D310", Offset = "0x5B8BD10", VA = "0x185B8D310", Slot = "15")]
	public JFOAFMPHLMG FFGLFOALIDB(Guid MOFMFKKIPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5B91520", Offset = "0x5B8FF20", VA = "0x185B91520", Slot = "16")]
	public bool MMJLADCHEBC(Guid MOFMFKKIPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5B916C0", Offset = "0x5B900C0", VA = "0x185B916C0", Slot = "17")]
	public bool NHLKLCOBFGH(Guid MOFMFKKIPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F0F0", Offset = "0x5B8DAF0", VA = "0x185B8F0F0", Slot = "18")]
	public KeepsakeTheme IHGGMCOCACF(Guid MOFMFKKIPEO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5B8EF30", Offset = "0x5B8D930", VA = "0x185B8EF30", Slot = "19")]
	public KeepsakeTheme IHGGMCOCACF(IMJJPBJDHEF HBHIPJFJNPM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B780", Offset = "0x5B8A180", VA = "0x185B8B780", Slot = "20")]
	public bool DJHIBANJACA(Guid MOFMFKKIPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B8D740", Offset = "0x5B8C140", VA = "0x185B8D740", Slot = "21")]
	public void FOMPLIICCHM(Guid MOFMFKKIPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B8EF10", Offset = "0x5B8D910", VA = "0x185B8EF10", Slot = "22")]
	public void IFNKMEBCOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B91930", Offset = "0x5B90330", VA = "0x185B91930", Slot = "23")]
	public void NPMJHPBDNBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B8CF40", Offset = "0x5B8B940", VA = "0x185B8CF40", Slot = "24")]
	public int FAMPLEEBAAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F4E0", Offset = "0x5B8DEE0", VA = "0x185B8F4E0", Slot = "25")]
	public global::LFIHKJLGIGB<int> JDPHACKLNPG(long NHLFHKNMPKF, long HLAHJLOGDFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E4B0", Offset = "0x5B8CEB0", VA = "0x185B8E4B0", Slot = "27")]
	public bool HOMCNOKOGGI(long NHLFHKNMPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B010", Offset = "0x5B89A10", VA = "0x185B8B010", Slot = "36")]
	public bool BFMKNMPGDBO(long NHLFHKNMPKF, out ONFHGGJJFEH IAMLCHFHBEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B90AB0", Offset = "0x5B8F4B0", VA = "0x185B90AB0", Slot = "28")]
	public long LPIHLIECPNA(IIPKOGHPJIG ONIAMNKEBKC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B8DE10", Offset = "0x5B8C810", VA = "0x185B8DE10", Slot = "29")]
	public IEnumerable<int> HENAMHPDAMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B92B60", Offset = "0x5B91560", VA = "0x185B92B60", Slot = "30")]
	public bool OPBCKOGGFPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E710", Offset = "0x5B8D110", VA = "0x185B8E710", Slot = "31")]
	public IEnumerable<long> IEBPFNJPAKE(JMLDBLCIKMF DNHMFNFCBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B8D970", Offset = "0x5B8C370", VA = "0x185B8D970", Slot = "32")]
	public int GNALEGBAEJE(JMLDBLCIKMF DNHMFNFCBDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B92610", Offset = "0x5B91010", VA = "0x185B92610")]
	private void ONKDHBICOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B8BE10", Offset = "0x5B8A810", VA = "0x185B8BE10")]
	private int EFKDCHONLBM(KeepsakeRoomListDTO GAEDHNPIOHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B690", Offset = "0x5B8A090", VA = "0x185B8B690")]
	private int DCLILOPOKGG(DateTime KPFJPNMJJED, DateTime KOGGDCADMKA, TimeSpan FADNLCKFEOA, int NJFOIDEJOLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B919F0", Offset = "0x5B903F0", VA = "0x185B919F0")]
	private bool OCIGGKJANGF(long MOBKDLIAEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B90F00", Offset = "0x5B8F900", VA = "0x185B90F00")]
	private void MFCFAODPBJC(IEnumerable<KeepsakeInstanceDTO> EOHOAGJMMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5B8D1B0", Offset = "0x5B8BBB0", VA = "0x185B8D1B0")]
	private void FEKAJJJIHFC(IEnumerable<KeepsakeCollectionRecordDTO> MGBHHPGPBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5B91660", Offset = "0x5B90060", VA = "0x185B91660")]
	private void NBOJNLGNHEK(IEnumerable<long> BDFAFNEPOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5B91790", Offset = "0x5B90190", VA = "0x185B91790")]
	private void NOADCIOKHFH(IEnumerable<KeepsakeCategoryConfigDTO> DCBBCBKGCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xD1CAA0", Offset = "0xD1B4A0", VA = "0x180D1CAA0")]
	private void CJNFBBCCBNH(KeepsakeGlobalConfigDTO IMIMCCEJJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5B906D0", Offset = "0x5B8F0D0", VA = "0x185B906D0")]
	private bool LNFDDAKEGDG(out Guid ILGHPGCMDBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B400", Offset = "0x5B89E00", VA = "0x185B8B400")]
	private void CHFBBNKGOBK(KeepsakeInstanceDTO MMKCACIJIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F2E0", Offset = "0x5B8DCE0", VA = "0x185B8F2E0")]
	private void IPOCJJPMJDC(KeepsakeInstanceDTO MMKCACIJIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5B8ADC0", Offset = "0x5B897C0", VA = "0x185B8ADC0")]
	private void AHLCFDNDBOF(Guid MOFMFKKIPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E6B0", Offset = "0x5B8D0B0", VA = "0x185B8E6B0")]
	private void IDDKDKLPKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F260", Offset = "0x5B8DC60", VA = "0x185B8F260")]
	private void IJPAKALJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5B90E80", Offset = "0x5B8F880", VA = "0x185B90E80")]
	private void MCJLMJGIEAG(HOOAEGAAEHH KBFKMHEHHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F280", Offset = "0x5B8DC80", VA = "0x185B8F280")]
	private void INIHGNAGFHC(KGCDMPKECGE.GCHNLHOLABA PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5B90520", Offset = "0x5B8EF20", VA = "0x185B90520")]
	private void LJPGLGPFJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FF90", Offset = "0x5B8E990", VA = "0x185B8FF90")]
	private void KLHEGNBHMEH(float EDOGBHEKMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5B8C940", Offset = "0x5B8B340", VA = "0x185B8C940")]
	private void EKOHJJACEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5B8CEB0", Offset = "0x5B8B8B0", VA = "0x185B8CEB0")]
	private bool ENNBHFJJLCL(Guid MOFMFKKIPEO, out string PEAPBFMDCLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5B90350", Offset = "0x5B8ED50", VA = "0x185B90350")]
	private bool LDIMLJPFNMF(Guid MOFMFKKIPEO, out KeepsakeCategoryConfigDTO GBOHABAHOJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AC90", Offset = "0x5B89690", VA = "0x185B8AC90")]
	private void ABOBDLHAKED(string JCLDODBDLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5B92C50", Offset = "0x5B91650", VA = "0x185B92C50")]
	private bool PGHDGHIBBKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5B91130", Offset = "0x5B8FB30", VA = "0x185B91130")]
	private bool MJPIKNBCLDO(Guid MOFMFKKIPEO, out string HENMPJPHDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5B8BFC0", Offset = "0x5B8A9C0", VA = "0x185B8BFC0")]
	private void EHLGCBCBHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5B92EF0", Offset = "0x5B918F0", VA = "0x185B92EF0")]
	private void PPPNHGNLBKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B9B0", Offset = "0x5B8A3B0", VA = "0x185B8B9B0", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AF90", Offset = "0x5B89990", VA = "0x185B8AF90")]
	private BLDPFOBDPCB BAEPKCCAOPE(CNFJAKLHDLB LFOIPNBBBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E510", Offset = "0x5B8CF10", VA = "0x185B8E510")]
	private NKEPEONOMPN ICNPKDIDNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5B8DAD0", Offset = "0x5B8C4D0", VA = "0x185B8DAD0")]
	private Task HDGPPOFIFPO(CKILIMBDBDL GBGLLILEMPG, CancellationToken OGOJJPCADFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5B8D820", Offset = "0x5B8C220", VA = "0x185B8D820")]
	[AsyncStateMachine(typeof(KNLMGAHNMNO))]
	private Task GEJDFMECLMB(CKILIMBDBDL GBGLLILEMPG, CancellationToken OGOJJPCADFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5B90A20", Offset = "0x5B8F420", VA = "0x185B90A20")]
	private Task LNJMAEHMFFB(CKILIMBDBDL GBGLLILEMPG, CancellationToken OGOJJPCADFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5B90580", Offset = "0x5B8EF80", VA = "0x185B90580")]
	[AsyncStateMachine(typeof(HPGOMEKIBBH))]
	private Task LKGEHNNNNJP(string PJJGOJBLNDL, TimeSpan NHHBPMMACFL, CancellationToken OGOJJPCADFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FAF0", Offset = "0x5B8E4F0", VA = "0x185B8FAF0")]
	[CompilerGenerated]
	private void JLNNBNHPDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B92D60", Offset = "0x5B91760", VA = "0x185B92D60")]
	[CompilerGenerated]
	private void PKEGDNAIFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E0C0", Offset = "0x5B8CAC0", VA = "0x185B8E0C0")]
	[CompilerGenerated]
	private void HMKNEFGCPLD(string HENMPJPHDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FAF0", Offset = "0x5B8E4F0", VA = "0x185B8FAF0")]
	[CompilerGenerated]
	private void OAFJOJAGEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AD70", Offset = "0x5B89770", VA = "0x185B8AD70")]
	[CompilerGenerated]
	private void AEEAEGPPLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AEA0", Offset = "0x5B898A0", VA = "0x185B8AEA0")]
	[CompilerGenerated]
	private bool AHMFDLBCHEH(KeepsakeInstanceDTO GKGDNAPOGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B760", Offset = "0x5B8A160", VA = "0x185B8B760")]
	[CompilerGenerated]
	private bool DHGLIFPNCBH(KeepsakeRoomListDTO GKGDNAPOGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5B923B0", Offset = "0x5B90DB0", VA = "0x185B923B0")]
	[CompilerGenerated]
	private void OLMBMGNECNI(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> DAJFJHGACIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E060", Offset = "0x5B8CA60", VA = "0x185B8E060")]
	[CompilerGenerated]
	private void HJIIJIBJILL(string HENMPJPHDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5B91CB0", Offset = "0x5B906B0", VA = "0x185B91CB0")]
	[CompilerGenerated]
	private Task ODBCLFHLLNI(CancellationToken CDAJDIEHIGO)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::ANPDAHLNPOE<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class IEGPEFCKIBC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
				public IEGPEFCKIBC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x5B94540", Offset = "0x5B92F40", VA = "0x185B94540")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B6EE0", Offset = "0x6B58E0", VA = "0x1806B6EE0")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] OBBPGBELBKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5B94B00", Offset = "0x5B93500", VA = "0x185B94B00")]
			public KeepsakeTheme IHGGMCOCACF(string MGNKGENHAIK)
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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5B949E0", Offset = "0x5B933E0", VA = "0x185B949E0")]
		[PBIPNKEGBNL(MIDPNFMDJEE.None)]
		private static void EPAJNPLDGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x752960", Offset = "0x751360", VA = "0x180752960")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5B94C40", Offset = "0x5B93640", VA = "0x185B94C40")]
	private static string GKOJACPJHAL(byte[] KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5B94D50", Offset = "0x5B93750", VA = "0x185B94D50")]
	public static string MEDIDALCMKC(byte[] GHEBPHBJKNK, bool FPEGHFMMINI)
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
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
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
