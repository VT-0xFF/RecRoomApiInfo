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
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NDLHIBCMIJO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[BBAJOPPGPEF]
public class EFANGPMJAKE : FCGACCEKOHD, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct AALCAEEKMPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string CBACNMHFCDC = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string OJGDBCHAOEB = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string INHDHDIFJOM = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string IHDEFFDCLKF = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string HAIPMGLKNKO = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string BKDBOILBBAI = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string IIBCPNADNGN = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string KPMLGNOEHDM = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string OEGEMHMOOLL = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string MOKFFDALDDJ = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string LNFDBDILMLO = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BAGHOFELIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public EFANGPMJAKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public BAGHOFELIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B270", Offset = "0x1F0A070", VA = "0x181F0B270")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GCJFNCCNDFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public EFANGPMJAKE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public GCJFNCCNDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1F15470", Offset = "0x1F14270", VA = "0x181F15470")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F15500", Offset = "0x1F14300", VA = "0x181F15500")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1F15530", Offset = "0x1F14330", VA = "0x181F15530")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1F15720", Offset = "0x1F14520", VA = "0x181F15720")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1F15720", Offset = "0x1F14520", VA = "0x181F15720")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ECNNNGCKHIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public EFANGPMJAKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ECNNNGCKHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B750", Offset = "0x1F0A550", VA = "0x181F0B750")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B820", Offset = "0x1F0A620", VA = "0x181F0B820")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B820", Offset = "0x1F0A620", VA = "0x181F0B820")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FDEEBEMFGAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public FDEEBEMFGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1F15450", Offset = "0x1F14250", VA = "0x181F15450")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CHAGEKFNLPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public CHAGEKFNLPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B6B0", Offset = "0x1F0A4B0", VA = "0x181F0B6B0")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FDBLOGFLOIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public FDBLOGFLOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F153B0", Offset = "0x1F141B0", VA = "0x181F153B0")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct EFHBHNMHMBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EFANGPMJAKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KJMABKGNIFB args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1F14F10", Offset = "0x1F13D10", VA = "0x181F14F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LKJGHCJHOND : IAsyncStateMachine
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
		public EFANGPMJAKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1F15930", Offset = "0x1F14730", VA = "0x181F15930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime FFBNMMIOEMP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int LJPAKIODCOA = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime PIMDAEDOBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DateTime LLPDMOFOLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LCIJCOKLADC GNKECCMBOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LBIJDBHHDDF APCNGJKFDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MIKJGDAPAMN DFNHIIFGHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HCAPPIOIODA KMAAKNPIHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly APIEENMJMEH AJMKJCJECLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LAEOIMNFGIL MJJOOGNLJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DDLMNMICDPG KEBPPIHJPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NFIAIFMOCGG DFBJNNBCNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CMPDPDNODHB BCJMFDAFKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly BGOEKBNDIAF LPJCMBOFMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MCIHNBOGDOG PHCAKCGIPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MDHEJBAHIAD CAILDAAGBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EJMALGBJAGG GKCGNLDEAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CEGBPCGELMJ DNJNINLCKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly OOHNMPDBDKI JDLBMNNCBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly global::KEIJADMHEGN<KeepsakesConfig.KeepsakesOptions> LACOAEKOGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> ALDGICOOJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<Guid> CJCMIOPHGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<long> KFPGENLONKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int JIAOCNFNAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<Guid> CJFOEPMIKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IDisposable NHEEGJAEBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Task AGOJBGKLLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? JNMHMNODOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO OKHCBEDAPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private global::KOILDJEEFJD<KeepsakeProgressionEventInstancesDTO> GDKELNHCBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<NOIAGDOOPFM, KeepsakeCategoryConfigDTO> AMPLIBMBDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO MBDPKLCGNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> EAEKLEAFEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> INGJELBPKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> LMICLJIOCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> AEDGCCHHDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomDTO> DDPMFBJLMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<string> HFOEPCEEOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DateTime ONKBBELIDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IDisposable CCLEANCDGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool DNMKCECKBPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CBAJBAOKDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98D710", Offset = "0x98C510", VA = "0x18098D710", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98D4F0", Offset = "0x98C2F0", VA = "0x18098D4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime MMLAGPACABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F0CAC0", Offset = "0x1F0B8C0", VA = "0x181F0CAC0", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime OFHIPMDDELE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F12D50", Offset = "0x1F11B50", VA = "0x181F12D50", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool EFEMBIIIJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1F0E710", Offset = "0x1F0D510", VA = "0x181F0E710", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EBICAIMACGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1F12C90", Offset = "0x1F11A90", VA = "0x181F12C90", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long FNCCLHIMFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1F0BF90", Offset = "0x1F0AD90", VA = "0x181F0BF90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? HNLPOCMIEDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1F0CA20", Offset = "0x1F0B820", VA = "0x181F0CA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool PLOIMFMGAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1F12E10", Offset = "0x1F11C10", VA = "0x181F12E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool PMHNDMGEOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1F124B0", Offset = "0x1F112B0", VA = "0x181F124B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1F12C20", Offset = "0x1F11A20", VA = "0x181F12C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> EBJJKOCGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1F13640", Offset = "0x1F12440", VA = "0x181F13640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1F121C0", Offset = "0x1F10FC0", VA = "0x181F121C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OOGJDFDJFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1F12F60", Offset = "0x1F11D60", VA = "0x181F12F60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F10F00", Offset = "0x1F0FD00", VA = "0x181F10F00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GLODKHLJBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F0D390", Offset = "0x1F0C190", VA = "0x181F0D390", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F0EDC0", Offset = "0x1F0DBC0", VA = "0x181F0EDC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E90", Offset = "0x1F12C90", VA = "0x181F13E90")]
	[Preserve]
	internal EFANGPMJAKE([NotNull][NOAEAKEJBMN(null)] LCIJCOKLADC GNKECCMBOMF, [NotNull][NOAEAKEJBMN(null)] JJDDHJAJBAE IJKJNGKHKCH, [NotNull][NOAEAKEJBMN(null)] LBIJDBHHDDF APCNGJKFDPN, [NotNull][NOAEAKEJBMN(null)] MIKJGDAPAMN DFNHIIFGHHE, [NotNull][NOAEAKEJBMN(null)] HCAPPIOIODA KMAAKNPIHAI, [NotNull][NOAEAKEJBMN(null)] APIEENMJMEH AJMKJCJECLB, [NotNull][NOAEAKEJBMN(null)] LAEOIMNFGIL MJJOOGNLJPL, [NotNull][NOAEAKEJBMN(null)] DDLMNMICDPG KEBPPIHJPDB, [NotNull][NOAEAKEJBMN(null)] NFIAIFMOCGG DFBJNNBCNBL, [NotNull][NOAEAKEJBMN(null)] PKECJNDPGMP KAMMECOHBLB, [NotNull][NOAEAKEJBMN(null)] CMPDPDNODHB BCJMFDAFKJG, [NotNull][NOAEAKEJBMN(null)] BGOEKBNDIAF LPJCMBOFMDJ, [NotNull][NOAEAKEJBMN(null)] MCIHNBOGDOG PHCAKCGIPAJ, [NotNull][NOAEAKEJBMN(null)] MDHEJBAHIAD CAILDAAGBJC, [NotNull][NOAEAKEJBMN(null)] EJMALGBJAGG GKCGNLDEAAP, [NotNull][NOAEAKEJBMN(null)] CEGBPCGELMJ DNJNINLCKDL, [NotNull][NOAEAKEJBMN(null)] OOHNMPDBDKI JDLBMNNCBHK, [NotNull][NOAEAKEJBMN(null)] global::KEIJADMHEGN<KeepsakesConfig.KeepsakesOptions> LACOAEKOGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F0F530", Offset = "0x1F0E330", VA = "0x181F0F530", Slot = "13")]
	public bool FJMACBEEAOH(List<string> JCDFADMOGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C440", Offset = "0x1F0B240", VA = "0x181F0C440", Slot = "14")]
	public global::KOILDJEEFJD<Guid> BONPMGGONOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C1C0", Offset = "0x1F0AFC0", VA = "0x181F0C1C0", Slot = "33")]
	public FFFHIGBANBM BJCGPALOHCO(Guid CDLNPIEGLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F124C0", Offset = "0x1F112C0", VA = "0x181F124C0", Slot = "15")]
	public FFFHIGBANBM KMGGHCOCCGO(Guid CDLNPIEGLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F12E20", Offset = "0x1F11C20", VA = "0x181F12E20", Slot = "16")]
	public bool NONCBAEODED(Guid CDLNPIEGLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F135F0", Offset = "0x1F123F0", VA = "0x181F135F0", Slot = "17")]
	public bool PFCGEFMAINF(Guid CDLNPIEGLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1F11090", Offset = "0x1F0FE90", VA = "0x181F11090")]
	public KeepsakeTheme IPDIEFHANHA(Guid CDLNPIEGLFE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F111B0", Offset = "0x1F0FFB0", VA = "0x181F111B0")]
	public KeepsakeTheme IPDIEFHANHA(NOIAGDOOPFM GIJPJCIFCID)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1F0FFC0", Offset = "0x1F0EDC0", VA = "0x181F0FFC0", Slot = "18")]
	public bool HEMEAIKBCDH(Guid CDLNPIEGLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C870", Offset = "0x1F0B670", VA = "0x181F0C870", Slot = "19")]
	public void CDLDOAIIIHJ(Guid CDLNPIEGLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1F13620", Offset = "0x1F12420", VA = "0x181F13620", Slot = "20")]
	public void PIHHJBPNAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1F0BED0", Offset = "0x1F0ACD0", VA = "0x181F0BED0", Slot = "21")]
	public void AGCHHCCFMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1F0EB50", Offset = "0x1F0D950", VA = "0x181F0EB50", Slot = "22")]
	public int FAHDGDMIKEP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F11370", Offset = "0x1F10170", VA = "0x181F11370", Slot = "23")]
	public global::KOILDJEEFJD<int> IPDJKLBEFCP(long BPKNEIPNBMF, long ELCFBMCFAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F0CB80", Offset = "0x1F0B980", VA = "0x181F0CB80", Slot = "25")]
	public bool COHLMAGNMDG(long BPKNEIPNBMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F0E760", Offset = "0x1F0D560", VA = "0x181F0E760", Slot = "34")]
	public bool EPHAENMBGDG(long BPKNEIPNBMF, out BLOKMEBGNMG JLBPDMFHENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F101F0", Offset = "0x1F0EFF0", VA = "0x181F101F0", Slot = "26")]
	public long HLBCLCIFHJC(CBHBGGIIIGF LKFOJGFCHHG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1F0E2A0", Offset = "0x1F0D0A0", VA = "0x181F0E2A0", Slot = "27")]
	public IEnumerable<int> EEEMIIJKJAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1F10FA0", Offset = "0x1F0FDA0", VA = "0x181F10FA0", Slot = "28")]
	public bool IOEDICKNBFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1F10660", Offset = "0x1F0F460", VA = "0x181F10660", Slot = "29")]
	public IEnumerable<long> IACDFKFHIEB(JHHMECDNKFD PIFEJBBIPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1F10E60", Offset = "0x1F0FC60", VA = "0x181F10E60", Slot = "30")]
	public int IJFFJCOOLDF(JHHMECDNKFD PIFEJBBIPHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1F136E0", Offset = "0x1F124E0", VA = "0x181F136E0")]
	private void PMKEHCNHPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1F12870", Offset = "0x1F11670", VA = "0x181F12870")]
	private int LIMNLPFONEM(KeepsakeRoomListDTO GENIHAEMOBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1F0F1F0", Offset = "0x1F0DFF0", VA = "0x181F0F1F0")]
	private int FHPCAENAJLP(DateTime PJDLHOKAIBI, DateTime ECJFEAEIOPN, TimeSpan OCCBBICEEDJ, int OKKFNMELLBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1F0DF50", Offset = "0x1F0CD50", VA = "0x181F0DF50")]
	private bool EAGLBHMACMI(long ICJHJIMOCAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1F0FD90", Offset = "0x1F0EB90", VA = "0x181F0FD90")]
	private void GIOKJPJPDIJ(IEnumerable<KeepsakeInstanceDTO> ALDGICOOJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1F10500", Offset = "0x1F0F300", VA = "0x181F10500")]
	private void IABLJHFKFHG(IEnumerable<KeepsakeCollectionRecordDTO> BAPMBPPPOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1F0E4F0", Offset = "0x1F0D2F0", VA = "0x181F0E4F0")]
	private void EFIODAMHIIC(IEnumerable<long> HLLAAFAGCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1F12A20", Offset = "0x1F11820", VA = "0x181F12A20")]
	private void LMGKMPIBHKK(IEnumerable<KeepsakeCategoryConfigDTO> PPGJPLDFFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xD03380", Offset = "0xD02180", VA = "0x180D03380")]
	private void BAOGPGBLMOF(KeepsakeGlobalConfigDTO MBDPKLCGNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1F0BB80", Offset = "0x1F0A980", VA = "0x181F0BB80")]
	private bool ACDNMDPGPKJ(out Guid BAHDICDJACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1F0F840", Offset = "0x1F0E640", VA = "0x181F0F840")]
	private void FPOMDBMGDBL(KeepsakeInstanceDTO FEJKDHGEKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F0FA00", Offset = "0x1F0E800", VA = "0x181F0FA00")]
	private void GCOGKNJBJMI(KeepsakeInstanceDTO FEJKDHGEKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1F0F050", Offset = "0x1F0DE50", VA = "0x181F0F050")]
	private void FDIAMLBIENE(Guid CDLNPIEGLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F12BC0", Offset = "0x1F119C0", VA = "0x181F12BC0")]
	private void MCAFIOOFFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1F135D0", Offset = "0x1F123D0", VA = "0x181F135D0")]
	private void PFCEPCJIJHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1F0E690", Offset = "0x1F0D490", VA = "0x181F0E690")]
	private void EONNCPKNBOF(CFGNBMOPGCI EFMNCBPFINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1F12450", Offset = "0x1F11250", VA = "0x181F12450")]
	private void KHNMDBLAEMK(EMFIKMKPMHF.BODDKHHNPIO LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1F133F0", Offset = "0x1F121F0", VA = "0x181F133F0")]
	private void OIKOBHBCHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F0CFD0", Offset = "0x1F0BDD0", VA = "0x181F0CFD0")]
	private void DBJDHDKNEBC(float HHEPCJIKPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F0D430", Offset = "0x1F0C230", VA = "0x181F0D430")]
	private void DLKOLNCHDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1F0F2C0", Offset = "0x1F0E0C0", VA = "0x181F0F2C0")]
	private bool FIHBOPBMPKI(Guid CDLNPIEGLFE, out string KDGLKFHCBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1F0EE80", Offset = "0x1F0DC80", VA = "0x181F0EE80")]
	private bool FCNBDGMBAID(Guid CDLNPIEGLFE, out KeepsakeCategoryConfigDTO OEJCEHNMMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1F0E5B0", Offset = "0x1F0D3B0", VA = "0x181F0E5B0")]
	private void EOBAMBNOKBA(string DJNOGODKGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1F134C0", Offset = "0x1F122C0", VA = "0x181F134C0")]
	private bool PBIKDFDPHJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F13000", Offset = "0x1F11E00", VA = "0x181F13000")]
	private bool OGHBOFOGPGG(Guid CDLNPIEGLFE, out string KDIFPAMDOPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1F11840", Offset = "0x1F10640", VA = "0x181F11840")]
	private void JDNBMOFBEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1F0F130", Offset = "0x1F0DF30", VA = "0x181F0F130")]
	private void FFLABKLDNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1F0FC00", Offset = "0x1F0EA00", VA = "0x181F0FC00")]
	internal static string GDLFFMNNNMD(NEICKDKNMPB KENNMNHBCCG, string MBBOFLAFMHC, bool CKBALBMILJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1F0DAF0", Offset = "0x1F0C8F0", VA = "0x181F0DAF0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1F0F4B0", Offset = "0x1F0E2B0", VA = "0x181F0F4B0")]
	private HOOMBOMNECD FINMACCLLIF(GACFBGOLEKO KICINPMGMFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C6D0", Offset = "0x1F0B4D0", VA = "0x181F0C6D0")]
	private JKLHCFNEBMM CCMIIODKKAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1F13B50", Offset = "0x1F12950", VA = "0x181F13B50")]
	private Task PMPEBMLLHKD(KJMABKGNIFB NHMGHNFFDAC, CancellationToken ONKANLKLEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F0D9A0", Offset = "0x1F0C7A0", VA = "0x181F0D9A0")]
	[AsyncStateMachine(typeof(EFHBHNMHMBN))]
	private Task DNJGJGEEPIJ(KJMABKGNIFB NHMGHNFFDAC, CancellationToken ONKANLKLEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1F0E210", Offset = "0x1F0D010", VA = "0x181F0E210")]
	private Task EAMIKKDDNKC(KJMABKGNIFB NHMGHNFFDAC, CancellationToken ONKANLKLEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C070", Offset = "0x1F0AE70", VA = "0x181F0C070")]
	[AsyncStateMachine(typeof(LKJGHCJHOND))]
	private Task BGBJDFIHIFD(string IACFBMPPCKF, TimeSpan EBDKANCHNFH, CancellationToken ONKANLKLEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1F0EE60", Offset = "0x1F0DC60", VA = "0x181F0EE60")]
	[CompilerGenerated]
	private void OHGPGGNCCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1F13450", Offset = "0x1F12250", VA = "0x181F13450")]
	[CompilerGenerated]
	private void OJHJHBFLMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1F0CBE0", Offset = "0x1F0B9E0", VA = "0x181F0CBE0")]
	[CompilerGenerated]
	private void DABLPGAAPEO(string KDIFPAMDOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1F0EE60", Offset = "0x1F0DC60", VA = "0x181F0EE60")]
	[CompilerGenerated]
	private void FCJDNLIPCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C8E0", Offset = "0x1F0B6E0", VA = "0x181F0C8E0")]
	[CompilerGenerated]
	private void CEBNFNEKHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C930", Offset = "0x1F0B730", VA = "0x181F0C930")]
	[CompilerGenerated]
	private bool CFMHNIJCMAF(KeepsakeInstanceDTO IDDALCIIJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1F134A0", Offset = "0x1F122A0", VA = "0x181F134A0")]
	[CompilerGenerated]
	private bool OMJEICBHMME(KeepsakeRoomListDTO IDDALCIIJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B920", Offset = "0x1F0A720", VA = "0x181F0B920")]
	[CompilerGenerated]
	private void AAOJGPMEHGM(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> DDMCDBNKELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1F0E550", Offset = "0x1F0D350", VA = "0x181F0E550")]
	[CompilerGenerated]
	private void ELKNGNDAKDF(string KDIFPAMDOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F12260", Offset = "0x1F11060", VA = "0x181F12260")]
	[CompilerGenerated]
	private Task KHMOKEBAHID(CancellationToken CAFCJMCOHMH)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float LoopingSfxVolume;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::KEIJADMHEGN<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			[CompilerGenerated]
			private sealed class JNEJJCCDCNK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
				public JNEJJCCDCNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x1F15740", Offset = "0x1F14540", VA = "0x181F15740")]
				internal bool <GetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8AFA10", Offset = "0x8AE810", VA = "0x1808AFA10")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] NHAHEGLLMFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x1F157F0", Offset = "0x1F145F0", VA = "0x181F157F0")]
			public KeepsakeTheme IPDIEFHANHA(string JKAEJBKNGBF)
			{
				return default(KeepsakeTheme);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1F15770", Offset = "0x1F14570", VA = "0x181F15770")]
		[HPAMKJCLFIM(BFFNGLOENLB.None)]
		private static void HPAANPOMCFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x71DC30", Offset = "0x71CA30", VA = "0x18071DC30")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1F15EC0", Offset = "0x1F14CC0", VA = "0x181F15EC0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1F15B70", Offset = "0x1F14970", VA = "0x181F15B70")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
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
