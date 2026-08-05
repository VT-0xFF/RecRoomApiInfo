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
public enum MHAGPGDOMKI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[IJCJGIKOGEN]
public class HLJPELBJKJH : GCBHCCHINFB, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct BJMEKGIBBEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string HAIHHGAFPPF = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string HEDJIKFKJCD = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string FOBJJGIHMNE = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string AODNLACEANI = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string JCOPFCCGLEP = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string LKLJLHCBFEP = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string JOGKJCFDKNJ = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string OAPLNNFIPMD = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string BHJHIBDOEIA = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string JFOBONJIDIP = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string EOCHPANOOBC = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class HOMLNOFHCHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HLJPELBJKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public HOMLNOFHCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1FF6B70", Offset = "0x1FF5970", VA = "0x181FF6B70")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class FHKKNHOBECI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public HLJPELBJKJH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public FHKKNHOBECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1FECE10", Offset = "0x1FEBC10", VA = "0x181FECE10")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1FECEA0", Offset = "0x1FEBCA0", VA = "0x181FECEA0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1FECED0", Offset = "0x1FEBCD0", VA = "0x181FECED0")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1FED0C0", Offset = "0x1FEBEC0", VA = "0x181FED0C0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1FED0C0", Offset = "0x1FEBEC0", VA = "0x181FED0C0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JKKNOOODANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HLJPELBJKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public JKKNOOODANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1FF6FB0", Offset = "0x1FF5DB0", VA = "0x181FF6FB0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1FF7080", Offset = "0x1FF5E80", VA = "0x181FF7080")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1FF7080", Offset = "0x1FF5E80", VA = "0x181FF7080")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AHIMMINGMBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public AHIMMINGMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1FECDF0", Offset = "0x1FEBBF0", VA = "0x181FECDF0")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MGLPMMIAMAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public MGLPMMIAMAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FF7A10", Offset = "0x1FF6810", VA = "0x181FF7A10")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MENHKHGHECF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public MENHKHGHECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF7970", Offset = "0x1FF6770", VA = "0x181FF7970")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HBAJNEHCACD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HLJPELBJKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public MMIGNNJDMKB args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1FED0E0", Offset = "0x1FEBEE0", VA = "0x181FED0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MHJEAPCEDGF : IAsyncStateMachine
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
		public HLJPELBJKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1FF7AB0", Offset = "0x1FF68B0", VA = "0x181FF7AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime FINNBNGLIDJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int NJJBFCJEEDH = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime AOKFMJACDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DateTime OKJEFLDNLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly PLICGBLNDBF IPGAALKCLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NNOOEHACKEM PEHPPDHILHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly HNCILPJLLMC FPFDPHNFDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NIIHHPJFPBC HEIBBHCMNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IOJNPFFHDDA POBEANPIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CHCONOLCGMP NEBFCGGKNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IFDFMCFIIAL AADAEPLNONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BMHJNIJKGAA GNPHKIFHPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FCJICGFHJPI ODMLDBMOLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JCJKFCJAKJJ JHNEEGJAEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly BMOKPGGKBJH NBDCDLMJPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CLAHIEFEKPB BAHAOHEJIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly FNNCFBJDOIB BFCFNGALMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly GFEBIGHKINL ABBPIJBGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly LAFFFFNKAJK LEEKMBCGDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly global::PAAMOCEGACM<KeepsakesConfig.KeepsakesOptions> MNDBAHHKLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> FGLJMINCGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<Guid> NOJPGHLPGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<long> CBMPLLAIJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int BCGPPNFBJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<Guid> NAAHFCFMGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IDisposable HGAAJIDIAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Task HKFJJEMACFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? IAPFMKJNPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO BGCCOHAEFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private global::MMBCCHGMCHN<KeepsakeProgressionEventInstancesDTO> CAECPCGBPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<NBDKHFKDKMC, KeepsakeCategoryConfigDTO> CIJHJJEGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO FHGHBMLKNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> DKFJCNLKEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> BBNNPMKCKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> JNJOOGJDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> BIPAGGGCIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomDTO> NHMANDCPFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<string> CBEFPLCABEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DateTime MEFONOEKKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IDisposable ICGMGCFGHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CMOHCFEDMMA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IFEJHLFGOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83CCD0", Offset = "0x83BAD0", VA = "0x18083CCD0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime BLJDFHLJPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3AB0", Offset = "0x1FF28B0", VA = "0x181FF3AB0", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime EODLJDMHMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FF1690", Offset = "0x1FF0490", VA = "0x181FF1690", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JMGHANJIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1FF21F0", Offset = "0x1FF0FF0", VA = "0x181FF21F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GLIJIFKJDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1FF1C90", Offset = "0x1FF0A90", VA = "0x181FF1C90", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long KFPPAIEBNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE0C0", Offset = "0x1FECEC0", VA = "0x181FEE0C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? LINCALLNMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEAC0", Offset = "0x1FED8C0", VA = "0x181FEEAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool KGLBGDALAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0E70", Offset = "0x1FEFC70", VA = "0x181FF0E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool BCFABEJAMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0E10", Offset = "0x1FEFC10", VA = "0x181FF0E10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1FED7D0", Offset = "0x1FEC5D0", VA = "0x181FED7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> JKCPLAIFLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE1A0", Offset = "0x1FECFA0", VA = "0x181FEE1A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0D70", Offset = "0x1FEFB70", VA = "0x181FF0D70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IKGAKOFBOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3CC0", Offset = "0x1FF2AC0", VA = "0x181FF3CC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1FED580", Offset = "0x1FEC380", VA = "0x181FED580", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GDLBHOPLALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1FF15F0", Offset = "0x1FF03F0", VA = "0x181FF15F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4ED0", Offset = "0x1FF3CD0", VA = "0x181FF4ED0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FF5AF0", Offset = "0x1FF48F0", VA = "0x181FF5AF0")]
	[Preserve]
	internal HLJPELBJKJH([NotNull][ELDNEOCBGIN(null)] PLICGBLNDBF IPGAALKCLME, [NotNull][ELDNEOCBGIN(null)] NNBKNCJBDJM JGINLCKHCEC, [NotNull][ELDNEOCBGIN(null)] NNOOEHACKEM PEHPPDHILHF, [NotNull][ELDNEOCBGIN(null)] HNCILPJLLMC FPFDPHNFDOB, [NotNull][ELDNEOCBGIN(null)] NIIHHPJFPBC HEIBBHCMNGN, [NotNull][ELDNEOCBGIN(null)] IOJNPFFHDDA POBEANPIGDE, [NotNull][ELDNEOCBGIN(null)] CHCONOLCGMP NEBFCGGKNED, [NotNull][ELDNEOCBGIN(null)] IFDFMCFIIAL AADAEPLNONC, [NotNull][ELDNEOCBGIN(null)] BMHJNIJKGAA GNPHKIFHPOM, [NotNull][ELDNEOCBGIN(null)] ILBGDCKAGCO KHOLADDNODB, [NotNull][ELDNEOCBGIN(null)] FCJICGFHJPI ODMLDBMOLMH, [NotNull][ELDNEOCBGIN(null)] JCJKFCJAKJJ JHNEEGJAEHG, [NotNull][ELDNEOCBGIN(null)] BMOKPGGKBJH NBDCDLMJPKG, [NotNull][ELDNEOCBGIN(null)] CLAHIEFEKPB BAHAOHEJIIM, [NotNull][ELDNEOCBGIN(null)] FNNCFBJDOIB BFCFNGALMPC, [NotNull][ELDNEOCBGIN(null)] GFEBIGHKINL ABBPIJBGMOG, [NotNull][ELDNEOCBGIN(null)] LAFFFFNKAJK LEEKMBCGDGH, [NotNull][ELDNEOCBGIN(null)] global::PAAMOCEGACM<KeepsakesConfig.KeepsakesOptions> MNDBAHHKLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFE70", Offset = "0x1FEEC70", VA = "0x181FEFE70", Slot = "13")]
	public bool DICPJJNFFIE(List<string> DGBMLENDANF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1EF0", Offset = "0x1FF0CF0", VA = "0x181FF1EF0", Slot = "14")]
	public global::MMBCCHGMCHN<Guid> KOGGEBLCEPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FF5360", Offset = "0x1FF4160", VA = "0x181FF5360", Slot = "33")]
	public CCBLCAIHLNA PHLHJHGKOKB(Guid FBCFPPOECDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FF49B0", Offset = "0x1FF37B0", VA = "0x181FF49B0", Slot = "15")]
	public CCBLCAIHLNA OIMEMBEOEIA(Guid FBCFPPOECDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0FE0", Offset = "0x1FEFDE0", VA = "0x181FF0FE0", Slot = "16")]
	public bool HHMBIKHOAFE(Guid FBCFPPOECDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FF36D0", Offset = "0x1FF24D0", VA = "0x181FF36D0", Slot = "17")]
	public bool MJHGHABPOCI(Guid FBCFPPOECDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FEED90", Offset = "0x1FEDB90", VA = "0x181FEED90")]
	public KeepsakeTheme CLMDGBJLFLE(Guid FBCFPPOECDJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEEB0", Offset = "0x1FEDCB0", VA = "0x181FEEEB0")]
	public KeepsakeTheme CLMDGBJLFLE(NBDKHFKDKMC LNDGLKIBPGD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF07D0", Offset = "0x1FEF5D0", VA = "0x181FF07D0", Slot = "18")]
	public bool EPJBNGKDGDD(Guid FBCFPPOECDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2180", Offset = "0x1FF0F80", VA = "0x181FF2180", Slot = "19")]
	public void KPHPOEHEPAA(Guid FBCFPPOECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF07B0", Offset = "0x1FEF5B0", VA = "0x181FF07B0", Slot = "20")]
	public void EOINGEPDIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3900", Offset = "0x1FF2700", VA = "0x181FF3900", Slot = "21")]
	public void MJKEFEBILGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2600", Offset = "0x1FF1400", VA = "0x181FF2600", Slot = "22")]
	public int LDDEOBNKPDE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1120", Offset = "0x1FEFF20", VA = "0x181FF1120", Slot = "23")]
	public global::MMBCCHGMCHN<int> HMJFGEOEKCC(long KPBGCMCAECK, long CLJBDGPMMEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4F70", Offset = "0x1FF3D70", VA = "0x181FF4F70", Slot = "25")]
	public bool PDCFIIFPKEK(long KPBGCMCAECK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDA30", Offset = "0x1FEC830", VA = "0x181FEDA30", Slot = "34")]
	public bool BCKAEFLINIF(long KPBGCMCAECK, out PDINJCGOPMC KLBPAOEGNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1FF5050", Offset = "0x1FF3E50", VA = "0x181FF5050", Slot = "26")]
	public long PFMAENBCHIA(HDFNENAAOGE OKIDLJDKFHB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FF55E0", Offset = "0x1FF43E0", VA = "0x181FF55E0", Slot = "27")]
	public IEnumerable<int> PMJKBIPBCNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1A00", Offset = "0x1FF0800", VA = "0x181FF1A00", Slot = "28")]
	public bool JKKPJJAOCFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE240", Offset = "0x1FED040", VA = "0x181FEE240", Slot = "29")]
	public IEnumerable<long> CDFCPKLFEOF(GFDOHKJJBPD AGIOLPDLDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3630", Offset = "0x1FF2430", VA = "0x181FF3630", Slot = "30")]
	public int LOMDKDAGLNE(GFDOHKJJBPD AGIOLPDLDGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4150", Offset = "0x1FF2F50", VA = "0x181FF4150")]
	private void OFFAOEBDKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FED620", Offset = "0x1FEC420", VA = "0x181FED620")]
	private int AGJODJCPDJK(KeepsakeRoomListDTO OJICMMDPCHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3BF0", Offset = "0x1FF29F0", VA = "0x181FF3BF0")]
	private int NLAANJNFJIP(DateTime JOCMKKHAFCP, DateTime BDHMKBEJOJA, TimeSpan DEDNEMJOKFI, int NAKMDDBMHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF5830", Offset = "0x1FF4630", VA = "0x181FF5830")]
	private bool PPCOIFGCLNA(long HEAEJPOMKKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEB60", Offset = "0x1FED960", VA = "0x181FEEB60")]
	private void CJMPDOBOOPI(IEnumerable<KeepsakeInstanceDTO> FGLJMINCGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0E80", Offset = "0x1FEFC80", VA = "0x181FF0E80")]
	private void HGINNJFDIIB(IEnumerable<KeepsakeCollectionRecordDTO> JCOAIOGCFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3B90", Offset = "0x1FF2990", VA = "0x181FF3B90")]
	private void NHLEMKHGPOC(IEnumerable<long> EPPBJEKFALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0A00", Offset = "0x1FEF800", VA = "0x181FF0A00")]
	private void FEFIPAEOHGM(IEnumerable<KeepsakeCategoryConfigDTO> JFOHECKOLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x969FB0", Offset = "0x968DB0", VA = "0x180969FB0")]
	private void GMHMMNCPEAI(KeepsakeGlobalConfigDTO FHGHBMLKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF130", Offset = "0x1FEDF30", VA = "0x181FEF130")]
	private bool DALEFGIPNPP(out Guid BAADEMODHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF6E0", Offset = "0x1FEE4E0", VA = "0x181FEF6E0")]
	private void DEIEFECHBIP(KeepsakeInstanceDTO NBDKCAOMBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3700", Offset = "0x1FF2500", VA = "0x181FF3700")]
	private void MJIDAPAADFE(KeepsakeInstanceDTO NBDKCAOMBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4DF0", Offset = "0x1FF3BF0", VA = "0x181FF4DF0")]
	private void PBCOFPKAFAD(Guid FBCFPPOECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF8A0", Offset = "0x1FEE6A0", VA = "0x181FEF8A0")]
	private void DFKAKDDMLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0D50", Offset = "0x1FEFB50", VA = "0x181FF0D50")]
	private void FNPHMHCNDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4FD0", Offset = "0x1FF3DD0", VA = "0x181FF4FD0")]
	private void PFCMMABCNEI(GDHGOFCBJHF PBPFPGHNJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF070", Offset = "0x1FEDE70", VA = "0x181FEF070")]
	private void CNDOILOBIGH(KMBGBDJMBEI.NJAGMDIOCCG GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0BA0", Offset = "0x1FEF9A0", VA = "0x181FF0BA0")]
	private void FNDBMEKHKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2240", Offset = "0x1FF1040", VA = "0x181FF2240")]
	private void LBCKGMMNHCH(float EDNHOACGHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF900", Offset = "0x1FEE700", VA = "0x181FEF900")]
	private void DGAJOMPGCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FED840", Offset = "0x1FEC640", VA = "0x181FED840")]
	private bool APDJJAOPBNF(Guid FBCFPPOECDJ, out string HNCKCNPGEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF05E0", Offset = "0x1FEF3E0", VA = "0x181FF05E0")]
	private bool ENDCANKGKKL(Guid FBCFPPOECDJ, out KeepsakeCategoryConfigDTO OFDLJGEKAHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3550", Offset = "0x1FF2350", VA = "0x181FF3550")]
	private void LNAPPLLPMKK(string PAAKJCMCMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDE20", Offset = "0x1FECC20", VA = "0x181FEDE20")]
	private bool BKGLMPMOAPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3D60", Offset = "0x1FF2B60", VA = "0x181FF3D60")]
	private bool OEAICEHKKIJ(Guid FBCFPPOECDJ, out string HMOPFJALLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2BB0", Offset = "0x1FF19B0", VA = "0x181FF2BB0")]
	private void LICNNMDNMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1750", Offset = "0x1FF0550", VA = "0x181FF1750")]
	private void JIHLNJKMOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDF30", Offset = "0x1FECD30", VA = "0x181FEDF30")]
	internal static string BOGINLJGDJH(HNEBMMMEKEL EDPEPEKHABM, string JMPKIIJFBGH, bool MCNFKILMENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0180", Offset = "0x1FEEF80", VA = "0x181FF0180", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEA40", Offset = "0x1FED840", VA = "0x181FEEA40")]
	private NIHJKBCEGCJ CDJOHBMEBCE(DMHOAMAMDGI PPBGOFKIMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1AF0", Offset = "0x1FF08F0", VA = "0x181FF1AF0")]
	private HADDBKOIJFF JOBKNHPFCGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2870", Offset = "0x1FF1670", VA = "0x181FF2870")]
	private Task LDKEMEIHMBP(MMIGNNJDMKB IJPNBHGIPKF, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0C00", Offset = "0x1FEFA00", VA = "0x181FF0C00")]
	[AsyncStateMachine(typeof(HBAJNEHCACD))]
	private Task FNFHIGPMAEK(MMIGNNJDMKB IJPNBHGIPKF, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4D60", Offset = "0x1FF3B60", VA = "0x181FF4D60")]
	private Task OLMLPJKBMHC(MMIGNNJDMKB IJPNBHGIPKF, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1D50", Offset = "0x1FF0B50", VA = "0x181FF1D50")]
	[AsyncStateMachine(typeof(MHJEAPCEDGF))]
	private Task KJEAJGCKLKC(string LMLMHJKGDCH, TimeSpan ACJPLKFAGPG, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3B70", Offset = "0x1FF2970", VA = "0x181FF3B70")]
	[CompilerGenerated]
	private void MPNKNBJCBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1EA0", Offset = "0x1FF0CA0", VA = "0x181FF1EA0")]
	[CompilerGenerated]
	private void KKDKJDLAEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF45C0", Offset = "0x1FF33C0", VA = "0x181FF45C0")]
	[CompilerGenerated]
	private void OHCGKFOAIBI(string HMOPFJALLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3B70", Offset = "0x1FF2970", VA = "0x181FF3B70")]
	[CompilerGenerated]
	private void PPIEOLJNIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0E20", Offset = "0x1FEFC20", VA = "0x181FF0E20")]
	[CompilerGenerated]
	private void GNIALJECKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FF39C0", Offset = "0x1FF27C0", VA = "0x181FF39C0")]
	[CompilerGenerated]
	private bool MLAJAANCDLG(KeepsakeInstanceDTO JMDPDGBMGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3530", Offset = "0x1FF2330", VA = "0x181FF3530")]
	[CompilerGenerated]
	private bool LMMKNCANCPA(KeepsakeRoomListDTO JMDPDGBMGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF480", Offset = "0x1FEE280", VA = "0x181FEF480")]
	[CompilerGenerated]
	private void DDKHDHBJADA(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> PFKCJHDBJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF0D0", Offset = "0x1FEDED0", VA = "0x181FEF0D0")]
	[CompilerGenerated]
	private void CNIACNLJPHP(string HMOPFJALLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1810", Offset = "0x1FF0610", VA = "0x181FF1810")]
	[CompilerGenerated]
	private Task JKBGJBJCLBE(CancellationToken ICBJOELHGPI)
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
	public class KeepsakesConfig : ScriptableObject, global::PAAMOCEGACM<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			[CompilerGenerated]
			private sealed class OKBLILIDGEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
				public OKBLILIDGEH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x1FF7CF0", Offset = "0x1FF6AF0", VA = "0x181FF7CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] JPDCACNBBBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x1FF7830", Offset = "0x1FF6630", VA = "0x181FF7830")]
			public KeepsakeTheme CLMDGBJLFLE(string DACHFIJGIAP)
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
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1FF77B0", Offset = "0x1FF65B0", VA = "0x181FF77B0")]
		[EJICMPGFCBP(CIKEJIGJNLD.None)]
		private static void PMFNJDEOCIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x77E460", Offset = "0x77D260", VA = "0x18077E460")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF74D0", Offset = "0x1FF62D0", VA = "0x181FF74D0")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7180", Offset = "0x1FF5F80", VA = "0x181FF7180")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
