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
[COLHLGKDEEJ]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public HOMLNOFHCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D12A10", Offset = "0x5D11A10", VA = "0x185D12A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FHKKNHOBECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D08CF0", Offset = "0x5D07CF0", VA = "0x185D08CF0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5D08D80", Offset = "0x5D07D80", VA = "0x185D08D80")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5D08DB0", Offset = "0x5D07DB0", VA = "0x185D08DB0")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D08FA0", Offset = "0x5D07FA0", VA = "0x185D08FA0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D08FA0", Offset = "0x5D07FA0", VA = "0x185D08FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public JKKNOOODANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5D12E50", Offset = "0x5D11E50", VA = "0x185D12E50")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5D12F20", Offset = "0x5D11F20", VA = "0x185D12F20")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5D12F20", Offset = "0x5D11F20", VA = "0x185D12F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public AHIMMINGMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x126AA80", Offset = "0x1269A80", VA = "0x18126AA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MGLPMMIAMAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5D13950", Offset = "0x5D12950", VA = "0x185D13950")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public MENHKHGHECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5D138B0", Offset = "0x5D128B0", VA = "0x185D138B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D08FC0", Offset = "0x5D07FC0", VA = "0x185D08FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D139F0", Offset = "0x5D129F0", VA = "0x185D139F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E030", Offset = "0x67D030", VA = "0x18067E030", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F7EA0", Offset = "0x7F6EA0", VA = "0x1807F7EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime BLJDFHLJPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F950", Offset = "0x5D0E950", VA = "0x185D0F950", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime EODLJDMHMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D530", Offset = "0x5D0C530", VA = "0x185D0D530", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JMGHANJIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E090", Offset = "0x5D0D090", VA = "0x185D0E090", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GLIJIFKJDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DB30", Offset = "0x5D0CB30", VA = "0x185D0DB30", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long KFPPAIEBNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D09F70", Offset = "0x5D08F70", VA = "0x185D09F70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? LINCALLNMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A970", Offset = "0x5D09970", VA = "0x185D0A970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool KGLBGDALAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D0CD10", Offset = "0x5D0BD10", VA = "0x185D0CD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool BCFABEJAMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1120490", Offset = "0x111F490", VA = "0x181120490")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D09680", Offset = "0x5D08680", VA = "0x185D09680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> JKCPLAIFLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A050", Offset = "0x5D09050", VA = "0x185D0A050", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D0CC20", Offset = "0x5D0BC20", VA = "0x185D0CC20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IKGAKOFBOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FB60", Offset = "0x5D0EB60", VA = "0x185D0FB60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D09430", Offset = "0x5D08430", VA = "0x185D09430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GDLBHOPLALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D490", Offset = "0x5D0C490", VA = "0x185D0D490", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D10D70", Offset = "0x5D0FD70", VA = "0x185D10D70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D11990", Offset = "0x5D10990", VA = "0x185D11990")]
	[Preserve]
	internal HLJPELBJKJH([NotNull][ELDNEOCBGIN(null)] PLICGBLNDBF IPGAALKCLME, [NotNull][ELDNEOCBGIN(null)] NNBKNCJBDJM JGINLCKHCEC, [NotNull][ELDNEOCBGIN(null)] NNOOEHACKEM PEHPPDHILHF, [NotNull][ELDNEOCBGIN(null)] HNCILPJLLMC FPFDPHNFDOB, [NotNull][ELDNEOCBGIN(null)] NIIHHPJFPBC HEIBBHCMNGN, [NotNull][ELDNEOCBGIN(null)] IOJNPFFHDDA POBEANPIGDE, [NotNull][ELDNEOCBGIN(null)] CHCONOLCGMP NEBFCGGKNED, [NotNull][ELDNEOCBGIN(null)] IFDFMCFIIAL AADAEPLNONC, [NotNull][ELDNEOCBGIN(null)] BMHJNIJKGAA GNPHKIFHPOM, [NotNull][ELDNEOCBGIN(null)] ILBGDCKAGCO KHOLADDNODB, [NotNull][ELDNEOCBGIN(null)] FCJICGFHJPI ODMLDBMOLMH, [NotNull][ELDNEOCBGIN(null)] JCJKFCJAKJJ JHNEEGJAEHG, [NotNull][ELDNEOCBGIN(null)] BMOKPGGKBJH NBDCDLMJPKG, [NotNull][ELDNEOCBGIN(null)] CLAHIEFEKPB BAHAOHEJIIM, [NotNull][ELDNEOCBGIN(null)] FNNCFBJDOIB BFCFNGALMPC, [NotNull][ELDNEOCBGIN(null)] GFEBIGHKINL ABBPIJBGMOG, [NotNull][ELDNEOCBGIN(null)] LAFFFFNKAJK LEEKMBCGDGH, [NotNull][ELDNEOCBGIN(null)] global::PAAMOCEGACM<KeepsakesConfig.KeepsakesOptions> MNDBAHHKLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BD20", Offset = "0x5D0AD20", VA = "0x185D0BD20", Slot = "13")]
	public bool DICPJJNFFIE(List<string> DGBMLENDANF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DD90", Offset = "0x5D0CD90", VA = "0x185D0DD90", Slot = "14")]
	public global::MMBCCHGMCHN<Guid> KOGGEBLCEPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D11200", Offset = "0x5D10200", VA = "0x185D11200", Slot = "35")]
	public CCBLCAIHLNA PHLHJHGKOKB(Guid FBCFPPOECDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D10850", Offset = "0x5D0F850", VA = "0x185D10850", Slot = "15")]
	public CCBLCAIHLNA OIMEMBEOEIA(Guid FBCFPPOECDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CE80", Offset = "0x5D0BE80", VA = "0x185D0CE80", Slot = "16")]
	public bool HHMBIKHOAFE(Guid FBCFPPOECDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F570", Offset = "0x5D0E570", VA = "0x185D0F570", Slot = "17")]
	public bool MJHGHABPOCI(Guid FBCFPPOECDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AE00", Offset = "0x5D09E00", VA = "0x185D0AE00", Slot = "18")]
	public KeepsakeTheme CLMDGBJLFLE(Guid FBCFPPOECDJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AC40", Offset = "0x5D09C40", VA = "0x185D0AC40", Slot = "19")]
	public KeepsakeTheme CLMDGBJLFLE(NBDKHFKDKMC LNDGLKIBPGD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C680", Offset = "0x5D0B680", VA = "0x185D0C680", Slot = "20")]
	public bool EPJBNGKDGDD(Guid FBCFPPOECDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E020", Offset = "0x5D0D020", VA = "0x185D0E020", Slot = "21")]
	public void KPHPOEHEPAA(Guid FBCFPPOECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C660", Offset = "0x5D0B660", VA = "0x185D0C660", Slot = "22")]
	public void EOINGEPDIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F7A0", Offset = "0x5D0E7A0", VA = "0x185D0F7A0", Slot = "23")]
	public void MJKEFEBILGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E4A0", Offset = "0x5D0D4A0", VA = "0x185D0E4A0", Slot = "24")]
	public int LDDEOBNKPDE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CFC0", Offset = "0x5D0BFC0", VA = "0x185D0CFC0", Slot = "25")]
	public global::MMBCCHGMCHN<int> HMJFGEOEKCC(long KPBGCMCAECK, long CLJBDGPMMEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D10E10", Offset = "0x5D0FE10", VA = "0x185D10E10", Slot = "27")]
	public bool PDCFIIFPKEK(long KPBGCMCAECK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D098E0", Offset = "0x5D088E0", VA = "0x185D098E0", Slot = "36")]
	public bool BCKAEFLINIF(long KPBGCMCAECK, out PDINJCGOPMC KLBPAOEGNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D10EF0", Offset = "0x5D0FEF0", VA = "0x185D10EF0", Slot = "28")]
	public long PFMAENBCHIA(HDFNENAAOGE OKIDLJDKFHB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D11480", Offset = "0x5D10480", VA = "0x185D11480", Slot = "29")]
	public IEnumerable<int> PMJKBIPBCNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D8A0", Offset = "0x5D0C8A0", VA = "0x185D0D8A0", Slot = "30")]
	public bool JKKPJJAOCFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A0F0", Offset = "0x5D090F0", VA = "0x185D0A0F0", Slot = "31")]
	public IEnumerable<long> CDFCPKLFEOF(GFDOHKJJBPD AGIOLPDLDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F4D0", Offset = "0x5D0E4D0", VA = "0x185D0F4D0", Slot = "32")]
	public int LOMDKDAGLNE(GFDOHKJJBPD AGIOLPDLDGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FFF0", Offset = "0x5D0EFF0", VA = "0x185D0FFF0")]
	private void OFFAOEBDKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D094D0", Offset = "0x5D084D0", VA = "0x185D094D0")]
	private int AGJODJCPDJK(KeepsakeRoomListDTO OJICMMDPCHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FA90", Offset = "0x5D0EA90", VA = "0x185D0FA90")]
	private int NLAANJNFJIP(DateTime JOCMKKHAFCP, DateTime BDHMKBEJOJA, TimeSpan DEDNEMJOKFI, int NAKMDDBMHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D116D0", Offset = "0x5D106D0", VA = "0x185D116D0")]
	private bool PPCOIFGCLNA(long HEAEJPOMKKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AA10", Offset = "0x5D09A10", VA = "0x185D0AA10")]
	private void CJMPDOBOOPI(IEnumerable<KeepsakeInstanceDTO> FGLJMINCGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CD20", Offset = "0x5D0BD20", VA = "0x185D0CD20")]
	private void HGINNJFDIIB(IEnumerable<KeepsakeCollectionRecordDTO> JCOAIOGCFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FA30", Offset = "0x5D0EA30", VA = "0x185D0FA30")]
	private void NHLEMKHGPOC(IEnumerable<long> EPPBJEKFALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C8B0", Offset = "0x5D0B8B0", VA = "0x185D0C8B0")]
	private void FEFIPAEOHGM(IEnumerable<KeepsakeCategoryConfigDTO> JFOHECKOLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xE66420", Offset = "0xE65420", VA = "0x180E66420")]
	private void GMHMMNCPEAI(KeepsakeGlobalConfigDTO FHGHBMLKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AFE0", Offset = "0x5D09FE0", VA = "0x185D0AFE0")]
	private bool DALEFGIPNPP(out Guid BAADEMODHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B590", Offset = "0x5D0A590", VA = "0x185D0B590")]
	private void DEIEFECHBIP(KeepsakeInstanceDTO NBDKCAOMBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F5A0", Offset = "0x5D0E5A0", VA = "0x185D0F5A0")]
	private void MJIDAPAADFE(KeepsakeInstanceDTO NBDKCAOMBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D10C90", Offset = "0x5D0FC90", VA = "0x185D10C90")]
	private void PBCOFPKAFAD(Guid FBCFPPOECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B750", Offset = "0x5D0A750", VA = "0x185D0B750")]
	private void DFKAKDDMLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CC00", Offset = "0x5D0BC00", VA = "0x185D0CC00")]
	private void FNPHMHCNDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D10E70", Offset = "0x5D0FE70", VA = "0x185D10E70")]
	private void PFCMMABCNEI(GDHGOFCBJHF PBPFPGHNJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AF20", Offset = "0x5D09F20", VA = "0x185D0AF20")]
	private void CNDOILOBIGH(KMBGBDJMBEI.NJAGMDIOCCG GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CA50", Offset = "0x5D0BA50", VA = "0x185D0CA50")]
	private void FNDBMEKHKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E0E0", Offset = "0x5D0D0E0", VA = "0x185D0E0E0")]
	private void LBCKGMMNHCH(float EDNHOACGHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B7B0", Offset = "0x5D0A7B0", VA = "0x185D0B7B0")]
	private void DGAJOMPGCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D096F0", Offset = "0x5D086F0", VA = "0x185D096F0")]
	private bool APDJJAOPBNF(Guid FBCFPPOECDJ, out string HNCKCNPGEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C490", Offset = "0x5D0B490", VA = "0x185D0C490")]
	private bool ENDCANKGKKL(Guid FBCFPPOECDJ, out KeepsakeCategoryConfigDTO OFDLJGEKAHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F3F0", Offset = "0x5D0E3F0", VA = "0x185D0F3F0")]
	private void LNAPPLLPMKK(string PAAKJCMCMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D09CD0", Offset = "0x5D08CD0", VA = "0x185D09CD0")]
	private bool BKGLMPMOAPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FC00", Offset = "0x5D0EC00", VA = "0x185D0FC00")]
	private bool OEAICEHKKIJ(Guid FBCFPPOECDJ, out string HMOPFJALLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EA50", Offset = "0x5D0DA50", VA = "0x185D0EA50")]
	private void LICNNMDNMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D5F0", Offset = "0x5D0C5F0", VA = "0x185D0D5F0")]
	private void JIHLNJKMOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D09DE0", Offset = "0x5D08DE0", VA = "0x185D09DE0")]
	internal static string BOGINLJGDJH(HNEBMMMEKEL EDPEPEKHABM, string JMPKIIJFBGH, bool MCNFKILMENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C030", Offset = "0x5D0B030", VA = "0x185D0C030", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A8F0", Offset = "0x5D098F0", VA = "0x185D0A8F0")]
	private NIHJKBCEGCJ CDJOHBMEBCE(DMHOAMAMDGI PPBGOFKIMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D990", Offset = "0x5D0C990", VA = "0x185D0D990")]
	private HADDBKOIJFF JOBKNHPFCGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E710", Offset = "0x5D0D710", VA = "0x185D0E710")]
	private Task LDKEMEIHMBP(MMIGNNJDMKB IJPNBHGIPKF, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CAB0", Offset = "0x5D0BAB0", VA = "0x185D0CAB0")]
	[AsyncStateMachine(typeof(HBAJNEHCACD))]
	private Task FNFHIGPMAEK(MMIGNNJDMKB IJPNBHGIPKF, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5D10C00", Offset = "0x5D0FC00", VA = "0x185D10C00")]
	private Task OLMLPJKBMHC(MMIGNNJDMKB IJPNBHGIPKF, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DBF0", Offset = "0x5D0CBF0", VA = "0x185D0DBF0")]
	[AsyncStateMachine(typeof(MHJEAPCEDGF))]
	private Task KJEAJGCKLKC(string LMLMHJKGDCH, TimeSpan ACJPLKFAGPG, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FA10", Offset = "0x5D0EA10", VA = "0x185D0FA10")]
	[CompilerGenerated]
	private void MPNKNBJCBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DD40", Offset = "0x5D0CD40", VA = "0x185D0DD40")]
	[CompilerGenerated]
	private void KKDKJDLAEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D10460", Offset = "0x5D0F460", VA = "0x185D10460")]
	[CompilerGenerated]
	private void OHCGKFOAIBI(string HMOPFJALLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FA10", Offset = "0x5D0EA10", VA = "0x185D0FA10")]
	[CompilerGenerated]
	private void PPIEOLJNIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CCC0", Offset = "0x5D0BCC0", VA = "0x185D0CCC0")]
	[CompilerGenerated]
	private void GNIALJECKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F860", Offset = "0x5D0E860", VA = "0x185D0F860")]
	[CompilerGenerated]
	private bool MLAJAANCDLG(KeepsakeInstanceDTO JMDPDGBMGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F3D0", Offset = "0x5D0E3D0", VA = "0x185D0F3D0")]
	[CompilerGenerated]
	private bool LMMKNCANCPA(KeepsakeRoomListDTO JMDPDGBMGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B330", Offset = "0x5D0A330", VA = "0x185D0B330")]
	[CompilerGenerated]
	private void DDKHDHBJADA(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> PFKCJHDBJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AF80", Offset = "0x5D09F80", VA = "0x185D0AF80")]
	[CompilerGenerated]
	private void CNIACNLJPHP(string HMOPFJALLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D6B0", Offset = "0x5D0C6B0", VA = "0x185D0D6B0")]
	[CompilerGenerated]
	private Task JKBGJBJCLBE(CancellationToken ICBJOELHGPI)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::PAAMOCEGACM<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class OKBLILIDGEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
				public OKBLILIDGEH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5D13C30", Offset = "0x5D12C30", VA = "0x185D13C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x67EF40", Offset = "0x67DF40", VA = "0x18067EF40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] JPDCACNBBBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5D13770", Offset = "0x5D12770", VA = "0x185D13770")]
			public KeepsakeTheme CLMDGBJLFLE(string DACHFIJGIAP)
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5D13650", Offset = "0x5D12650", VA = "0x185D13650")]
		[EJICMPGFCBP(CIKEJIGJNLD.None)]
		private static void PMFNJDEOCIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xDF0520", Offset = "0xDEF520", VA = "0x180DF0520")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5D13370", Offset = "0x5D12370", VA = "0x185D13370")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D13020", Offset = "0x5D12020", VA = "0x185D13020")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
