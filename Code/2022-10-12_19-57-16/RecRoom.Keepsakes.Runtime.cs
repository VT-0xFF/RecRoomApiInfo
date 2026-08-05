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
public enum OOBHPMKMOGC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ACIJLHACKDJ : DNDJADOGGGH, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct CMKNPCIDDGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public const string HIKMBKBDNAG = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string HOKPIMCFJNO = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string PMIIFBHJIHG = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string GPAAOEMGFII = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string MPOBFIAJGLE = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string CLBGOKHMAIH = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string PNGNHAKMNNH = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string JAEGMGMBAAM = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string PMLAJAMAPMH = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string NPAJJLKNDCI = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string GCCFNDHGHND = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JDHGCMKGHPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public ACIJLHACKDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public string collectionMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public JDHGCMKGHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5A8A4F0", Offset = "0x5A894F0", VA = "0x185A8A4F0")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KBLPKANDHFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ACIJLHACKDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KBLPKANDHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5A8A950", Offset = "0x5A89950", VA = "0x185A8A950")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5A8A9E0", Offset = "0x5A899E0", VA = "0x185A8A9E0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5A8AA10", Offset = "0x5A89A10", VA = "0x185A8AA10")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x470E780", Offset = "0x470D780", VA = "0x18470E780")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x470E780", Offset = "0x470D780", VA = "0x18470E780")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IPMNAPGBNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ACIJLHACKDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public IPMNAPGBNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5A8A320", Offset = "0x5A89320", VA = "0x185A8A320")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5A8A3F0", Offset = "0x5A893F0", VA = "0x185A8A3F0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5A8A3F0", Offset = "0x5A893F0", VA = "0x185A8A3F0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OMEEKINJMMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public OMEEKINJMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x11048B0", Offset = "0x11038B0", VA = "0x1811048B0")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FMMKDCJCJNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public FMMKDCJCJNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5A89BD0", Offset = "0x5A88BD0", VA = "0x185A89BD0")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FFDABAOFELA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public FFDABAOFELA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5A89B30", Offset = "0x5A88B30", VA = "0x185A89B30")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IANJGCINKAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public ACIJLHACKDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CEBPIIBHMDD args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5A89EB0", Offset = "0x5A88EB0", VA = "0x185A89EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HLGKOPBOJGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public ACIJLHACKDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5A89C70", Offset = "0x5A88C70", VA = "0x185A89C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime MGGANNHANCH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int FDKENCIOPCD = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private DateTime GEHBHEPIFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime AIKLNJNFEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly IDAKMPKKEAF CHOJIJPOBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ECCGPMNDJLB ANPNMALMBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BEECGMDFGBP NJMLFAEPEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly AMFKPCNPDPO DCHGEOICMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EMEJKEABALH MEFFMNONBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly CCAGLFFFGIN DDIJIPJFELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KFMPBCNDGGB BNGBGHDDGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly LHBHABEPLIM FMJNCAAMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AMHIHABNGNF ODBKBABJMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KCPJDPEHKFK JGOLKKDMLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OMIFHCBIMDF HJHHDFHCLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly EFLPLFAAAPG JHLEPOOCEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly AFEBCLPHDAH PDGENPHJJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly MPECEJHJEFN BJPLKDLBAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly KGGDBHJFJJG EABKBMHMLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly global::EELMJEJLGAC<KeepsakesConfig.KeepsakesOptions> BAOJAINPKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> DBONALJGMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> CNHLKJMEOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> NOPADGDLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int OHBMGPGLAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> JLGKCNGNCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable MJDACBDDAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task NPIKBMKLBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private long? NFOODIFHPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private KeepsakeProgressionEventInstancesDTO MAPACODHNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private global::AGDEEHNAPKP<KeepsakeProgressionEventInstancesDTO> FCIEABPMDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly Dictionary<FAOJNBNJNKJ, KeepsakeCategoryConfigDTO> EHAHCLPAGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KeepsakeGlobalConfigDTO ELJODHHCKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private HashSet<long> BALOGHMIONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<KeepsakeRoomDTO> HDNCMEDFHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> ECNCGJIHHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> MCAIEOAINJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> CMFAKPIEDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly List<string> FODPDPFFGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private DateTime IIKLEBJMKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly IDisposable NPHFCIGNOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool LOJCJDKMBIF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CAKGOBNDLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x755B40", Offset = "0x754B40", VA = "0x180755B40", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x704170", Offset = "0x703170", VA = "0x180704170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime EBIDLBJGOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5A803B0", Offset = "0x5A7F3B0", VA = "0x185A803B0", Slot = "9")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime OJHHCHAMAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5A80300", Offset = "0x5A7F300", VA = "0x185A80300", Slot = "10")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool EBLEFPIAKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5A85A10", Offset = "0x5A84A10", VA = "0x185A85A10", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IOMGCLPDJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5A84FB0", Offset = "0x5A83FB0", VA = "0x185A84FB0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long PLNIMHIDHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5A839E0", Offset = "0x5A829E0", VA = "0x185A839E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? GLNNMLOCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5A85110", Offset = "0x5A84110", VA = "0x185A85110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool ENPABHJDGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5A83520", Offset = "0x5A82520", VA = "0x185A83520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool FDEKIDFPMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x11467D0", Offset = "0x11457D0", VA = "0x1811467D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5A81E60", Offset = "0x5A80E60", VA = "0x185A81E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> NNJNFDECAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5A85070", Offset = "0x5A84070", VA = "0x185A85070", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5A847B0", Offset = "0x5A837B0", VA = "0x185A847B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HILCPBEGDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5A813E0", Offset = "0x5A803E0", VA = "0x185A813E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5A82840", Offset = "0x5A81840", VA = "0x185A82840", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5A88480", Offset = "0x5A87480", VA = "0x185A88480")]
	[Preserve]
	internal ACIJLHACKDJ([NotNull][NBLPGINBDGI(null)] IDAKMPKKEAF CHOJIJPOBHK, [NotNull][NBLPGINBDGI(null)] OBPOBNBPMGH HIPEPKONADC, [NotNull][NBLPGINBDGI(null)] ECCGPMNDJLB ANPNMALMBDD, [NotNull][NBLPGINBDGI(null)] BEECGMDFGBP NJMLFAEPEBB, [NotNull][NBLPGINBDGI(null)] AMFKPCNPDPO DCHGEOICMAP, [NotNull][NBLPGINBDGI(null)] EMEJKEABALH MEFFMNONBAI, [NotNull][NBLPGINBDGI(null)] CCAGLFFFGIN DDIJIPJFELD, [NotNull][NBLPGINBDGI(null)] KFMPBCNDGGB BNGBGHDDGIH, [NotNull][NBLPGINBDGI(null)] LHBHABEPLIM FMJNCAAMIPB, [NotNull][NBLPGINBDGI(null)] BPOFINAELIA BLFIAMELILK, [NotNull][NBLPGINBDGI(null)] AMHIHABNGNF ODBKBABJMPD, [NotNull][NBLPGINBDGI(null)] KCPJDPEHKFK JGOLKKDMLBH, [NotNull][NBLPGINBDGI(null)] OMIFHCBIMDF HJHHDFHCLKO, [NotNull][NBLPGINBDGI(null)] EFLPLFAAAPG JHLEPOOCEOH, [NotNull][NBLPGINBDGI(null)] AFEBCLPHDAH PDGENPHJJHJ, [NotNull][NBLPGINBDGI(null)] MPECEJHJEFN BJPLKDLBAOI, [NotNull][NBLPGINBDGI(null)] KGGDBHJFJJG EABKBMHMLKG, [NotNull][NBLPGINBDGI(null)] global::EELMJEJLGAC<KeepsakesConfig.KeepsakesOptions> BAOJAINPKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5A87B50", Offset = "0x5A86B50", VA = "0x185A87B50", Slot = "11")]
	public bool OMKGJCNJPMJ(List<string> HOCLJIKIJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5A851B0", Offset = "0x5A841B0", VA = "0x185A851B0", Slot = "12")]
	public global::AGDEEHNAPKP<Guid> IBIKDAHGMGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5A81560", Offset = "0x5A80560", VA = "0x185A81560", Slot = "33")]
	public MLEPGEJLFCO CBNIAFACFAO(Guid CNIAEHONKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5A80700", Offset = "0x5A7F700", VA = "0x185A80700", Slot = "13")]
	public MLEPGEJLFCO BAGHCGMEAPO(Guid CNIAEHONKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5A82BD0", Offset = "0x5A81BD0", VA = "0x185A82BD0", Slot = "14")]
	public bool DJKMLKGKBHG(Guid CNIAEHONKDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5A87E40", Offset = "0x5A86E40", VA = "0x185A87E40", Slot = "15")]
	public bool ONJIDGEJHAK(Guid CNIAEHONKDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5A864B0", Offset = "0x5A854B0", VA = "0x185A864B0", Slot = "16")]
	public KeepsakeTheme KPBAHIOFDMK(Guid CNIAEHONKDI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5A86610", Offset = "0x5A85610", VA = "0x185A86610", Slot = "17")]
	public KeepsakeTheme KPBAHIOFDMK(FAOJNBNJNKJ OBFBLBFDBOH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5A81A60", Offset = "0x5A80A60", VA = "0x185A81A60", Slot = "18")]
	public bool CKAFBPIOKMF(Guid CNIAEHONKDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5A84720", Offset = "0x5A83720", VA = "0x185A84720", Slot = "19")]
	public void HACKHLFFHAH(Guid CNIAEHONKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5A84790", Offset = "0x5A83790", VA = "0x185A84790", Slot = "20")]
	public void HBCOECMAPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5A86EF0", Offset = "0x5A85EF0", VA = "0x185A86EF0", Slot = "21")]
	public void LODEAPJGNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5A86240", Offset = "0x5A85240", VA = "0x185A86240", Slot = "22")]
	public int KNFEBNKHGFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5A84940", Offset = "0x5A83940", VA = "0x185A84940", Slot = "23")]
	public global::AGDEEHNAPKP<int> HEHKAILCMOD(long BDNAKAPNAFM, long GFDICPFBPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5A87AF0", Offset = "0x5A86AF0", VA = "0x185A87AF0", Slot = "25")]
	public bool OLMBMJHIPHG(long BDNAKAPNAFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5A85A60", Offset = "0x5A84A60", VA = "0x185A85A60", Slot = "34")]
	public bool JMIEAMNMAGD(long BDNAKAPNAFM, out FJEFIKDOEDG OFCLNMFCHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5A85700", Offset = "0x5A84700", VA = "0x185A85700", Slot = "26")]
	public long IKLGMNAGDOB(AJNIJFGMOFB ECBDFDLCCAI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5A854B0", Offset = "0x5A844B0", VA = "0x185A854B0", Slot = "27")]
	public IEnumerable<int> IIFADJPKJKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5A82F70", Offset = "0x5A81F70", VA = "0x185A82F70", Slot = "28")]
	public bool DOGPHHOJBHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5A80B50", Offset = "0x5A7FB50", VA = "0x185A80B50", Slot = "29")]
	public IEnumerable<long> BNDJBADOOBO(LDMPLMOKKKA JIGNOPEEJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5A83D80", Offset = "0x5A82D80", VA = "0x185A83D80", Slot = "30")]
	public int GCDDFDGGMJD(LDMPLMOKKKA JIGNOPEEJIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5A87170", Offset = "0x5A86170", VA = "0x185A87170")]
	private void MJEGEMOELEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5A85E50", Offset = "0x5A84E50", VA = "0x185A85E50")]
	private int JPOLHNMIFOC(KeepsakeRoomListDTO CCPCDHJMMHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5A87630", Offset = "0x5A86630", VA = "0x185A87630")]
	private int ODNFEALJFGI(DateTime DNJAKLNHMCB, DateTime HELFPOHEDLC, TimeSpan CKKJPHJAEDL, int KBMOHBHDMNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5A83AC0", Offset = "0x5A82AC0", VA = "0x185A83AC0")]
	private bool FMKOMBFPOFJ(long LMKAEKIGGHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5A828E0", Offset = "0x5A818E0", VA = "0x185A828E0")]
	private void DHEGEKOFLKJ(IEnumerable<KeepsakeInstanceDTO> DBONALJGMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5A83530", Offset = "0x5A82530", VA = "0x185A83530")]
	private void EMBIIAOBGHM(IEnumerable<KeepsakeCollectionRecordDTO> MBBAHKBPLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5A817E0", Offset = "0x5A807E0", VA = "0x185A817E0")]
	private void CDNAOIHIDLI(IEnumerable<long> ILOCNDKJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5A84E10", Offset = "0x5A83E10", VA = "0x185A84E10")]
	private void HGBDGHJAKEF(IEnumerable<KeepsakeCategoryConfigDTO> DBHPHCAJJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x114D2C0", Offset = "0x114C2C0", VA = "0x18114D2C0")]
	private void KGEIHHLDELF(KeepsakeGlobalConfigDTO ELJODHHCKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5A83690", Offset = "0x5A82690", VA = "0x185A83690")]
	private bool FGBKNEJFPEO(out Guid MEAFCMGHAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5A84500", Offset = "0x5A83500", VA = "0x185A84500")]
	private void GLCPCBJMHGE(KeepsakeInstanceDTO FHBMKDODDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5A81860", Offset = "0x5A80860", VA = "0x185A81860")]
	private void CJJCFOMPMJF(KeepsakeInstanceDTO FHBMKDODDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5A81480", Offset = "0x5A80480", VA = "0x185A81480")]
	private void CALIOOBGLDK(Guid CNIAEHONKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5A88230", Offset = "0x5A87230", VA = "0x185A88230")]
	private void PLDBMICEMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5A86000", Offset = "0x5A85000", VA = "0x185A86000")]
	private void KEGJLOEBGGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5A85440", Offset = "0x5A84440", VA = "0x185A85440")]
	private void IDFIAOFFPMP(EFBIDOEEHFO NCOJPJKLCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5A844A0", Offset = "0x5A834A0", VA = "0x185A844A0")]
	private void GJCCDBALJJH(DAFEHHLJBDJ.HNIAFCJOJMG ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5A846C0", Offset = "0x5A836C0", VA = "0x185A846C0")]
	private void GPPIJONHMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5A87E70", Offset = "0x5A86E70", VA = "0x185A87E70")]
	private void PBLEGNEDHBF(float MLAILODNPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5A83E20", Offset = "0x5A82E20", VA = "0x185A83E20")]
	private void GFMFNELLECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5A81350", Offset = "0x5A80350", VA = "0x185A81350")]
	private bool BPCNFGNGGKO(Guid CNIAEHONKDI, out string BJMGAEBKEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5A81C90", Offset = "0x5A80C90", VA = "0x185A81C90")]
	private bool CNJAFJPPACB(Guid CNIAEHONKDI, out KeepsakeCategoryConfigDTO HPGOJPKAIJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5A87040", Offset = "0x5A86040", VA = "0x185A87040")]
	private void MGCAICGEGCN(string ODBHAGOGLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5A84390", Offset = "0x5A83390", VA = "0x185A84390")]
	private bool GGIBAAIBAAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5A86B00", Offset = "0x5A85B00", VA = "0x185A86B00")]
	private bool LILCBHPNNPI(Guid CNIAEHONKDI, out string OJDKKCJFMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5A81ED0", Offset = "0x5A80ED0", VA = "0x185A81ED0")]
	private void DDPCAPGHDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5A82B10", Offset = "0x5A81B10", VA = "0x185A82B10")]
	private void DHKGBHKIIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5A830C0", Offset = "0x5A820C0", VA = "0x185A830C0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5A86020", Offset = "0x5A85020", VA = "0x185A86020")]
	private ODHGHEGHGCB KFBACCLLGMK(ODNOGOADEAI DDKPFEGJFHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5A860A0", Offset = "0x5A850A0", VA = "0x185A860A0")]
	private LIIJBJHCLEL KJHAJHMMLIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5A867C0", Offset = "0x5A857C0", VA = "0x185A867C0")]
	private Task LHGOADLMOID(CEBPIIBHMDD GOLEKIJBOAN, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5A805B0", Offset = "0x5A7F5B0", VA = "0x185A805B0")]
	[AsyncStateMachine(typeof(IANJGCINKAC))]
	private Task AMIHKKENHPO(CEBPIIBHMDD GOLEKIJBOAN, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5A86FB0", Offset = "0x5A85FB0", VA = "0x185A86FB0")]
	private Task MGALLPNALHA(CEBPIIBHMDD GOLEKIJBOAN, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5A80460", Offset = "0x5A7F460", VA = "0x185A80460")]
	[AsyncStateMachine(typeof(HLGKOPBOJGL))]
	private Task AFDLKFHDOMM(string NJAIIGFCHNG, TimeSpan EBLNGPLPCLM, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5A80B30", Offset = "0x5A7FB30", VA = "0x185A80B30")]
	[CompilerGenerated]
	private void PIPBJNAGFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5A875E0", Offset = "0x5A865E0", VA = "0x185A875E0")]
	[CompilerGenerated]
	private void MPEEJBJOOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5A87700", Offset = "0x5A86700", VA = "0x185A87700")]
	[CompilerGenerated]
	private void OGBHAAMKCPO(string OJDKKCJFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5A80B30", Offset = "0x5A7FB30", VA = "0x185A80B30")]
	[CompilerGenerated]
	private void BNBLPLCDDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5A87120", Offset = "0x5A86120", VA = "0x185A87120")]
	[CompilerGenerated]
	private void MGEEGEIBIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5A84850", Offset = "0x5A83850", VA = "0x185A84850")]
	[CompilerGenerated]
	private bool HCPIHILECLN(KeepsakeInstanceDTO ODLLFOGPPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5A81840", Offset = "0x5A80840", VA = "0x185A81840")]
	[CompilerGenerated]
	private bool CHDNDNKGMOC(KeepsakeRoomListDTO ODLLFOGPPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5A82D10", Offset = "0x5A81D10", VA = "0x185A82D10")]
	[CompilerGenerated]
	private void DNEMENCJGBC(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> EDPHBMHGCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5A83060", Offset = "0x5A82060", VA = "0x185A83060")]
	[CompilerGenerated]
	private void DOOMDEFHADI(string OJDKKCJFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5A88290", Offset = "0x5A87290", VA = "0x185A88290")]
	[CompilerGenerated]
	private Task POGLHHHGKAD(CancellationToken NIHIEFFCMFO)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::EELMJEJLGAC<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class JKPAILJGLBM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400006F")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
				public JKPAILJGLBM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x5A8A920", Offset = "0x5A89920", VA = "0x185A8A920")]
				internal bool <GetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] PKCCFENAJGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5A8AD20", Offset = "0x5A89D20", VA = "0x185A8AD20")]
			public KeepsakeTheme KPBAHIOFDMK(string PLJFHOEJFLJ)
			{
				return default(KeepsakeTheme);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5A8AC00", Offset = "0x5A89C00", VA = "0x185A8AC00")]
		[FBDCEBOAGGK(ABMKJHLOOPK.None)]
		private static void HKHPIAEGIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xEE0200", Offset = "0xEDF200", VA = "0x180EE0200")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5A89500", Offset = "0x5A88500", VA = "0x185A89500")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5A89610", Offset = "0x5A88610", VA = "0x185A89610")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
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

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
