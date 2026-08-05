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
public enum HOIMPPEAMOG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CGOOLJICOAH : CCAMCGLFCIP, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct KNGGELMCOND
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string FLGPJMGFLAP = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string MLCNDCOHHFP = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string EIHNGPHLPEO = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string KHJNINMMLHL = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string LJADJHKAILL = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string NGLFJECNFBH = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string OFAKFCCMFGH = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string KKIPMHMHPPC = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string LPJFHFGANDL = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string CFLBAKBGHAA = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string CAKBGCCILCI = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class DECNLDLCEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CGOOLJICOAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string collectionMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public DECNLDLCEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4AA0", Offset = "0x5AF3AA0", VA = "0x185AF4AA0")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class DDOOHKDKPFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CGOOLJICOAH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public DDOOHKDKPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5AF47D0", Offset = "0x5AF37D0", VA = "0x185AF47D0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4860", Offset = "0x5AF3860", VA = "0x185AF4860")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4890", Offset = "0x5AF3890", VA = "0x185AF4890")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4A80", Offset = "0x5AF3A80", VA = "0x185AF4A80")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4A80", Offset = "0x5AF3A80", VA = "0x185AF4A80")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ADFJIIIMINF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CGOOLJICOAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public ADFJIIIMINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB190", Offset = "0x5AEA190", VA = "0x185AEB190")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB260", Offset = "0x5AEA260", VA = "0x185AEB260")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB260", Offset = "0x5AEA260", VA = "0x185AEB260")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IGBCCJBOMIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public IGBCCJBOMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x10CB350", Offset = "0x10CA350", VA = "0x1810CB350")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HMKPEIEPHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public HMKPEIEPHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5580", Offset = "0x5AF4580", VA = "0x185AF5580")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BKCIDBKAHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public BKCIDBKAHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB360", Offset = "0x5AEA360", VA = "0x185AEB360")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FKMMLKPLOAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CGOOLJICOAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public HCAOAHLBICC args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5110", Offset = "0x5AF4110", VA = "0x185AF5110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E320", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EAGBKLIELON : IAsyncStateMachine
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
		public CGOOLJICOAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4ED0", Offset = "0x5AF3ED0", VA = "0x185AF4ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E320", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime AILBPADABBB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int JMOHGEJEMPO = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime KHFEFHPHKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DateTime EEIDCLKBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LNDALGFGLLI NIIGAMEPBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EIBPNDCCNNG LIFMHDEGPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KMCIKKGPHKM OCAFDCAGFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EMAEHBHJIKL NEPENNIPLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly BPKJCDGALIE GIGDLICKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ALHGGIGIAMK MGDIIIBBDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EBEKBJENPBA MAMECCODHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HCDAFHMBMGC IPDFOMJPIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly BKKOCJCOGND AFANONBMOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KHOLGOEJMAD ELBFKIGNLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly JFHDOCFCACI JAINGBLJHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MIGGKFDMCEN LNDENMLDHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly OOKIKLFCOHC LNPKFAAKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly FLLNBHMEHON PLGBJNDGFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FMAODHFOLMJ CHBPAFNLPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly global::EMAEPNKDBJO<KeepsakesConfig.KeepsakesOptions> FJDLENJCEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> MMOBFPGHLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<Guid> NLABADKCDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<long> CBJAJAJPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int OIJPELCFPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<Guid> NLGHLJGEAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IDisposable OGNFMGPFLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Task GKKMPODKILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? NPOOGGNBIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO MHEBDGKCPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private global::DGCAEBAFOOK<KeepsakeProgressionEventInstancesDTO> MIFFJBPFNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<BLDCOLANFKH, KeepsakeCategoryConfigDTO> IKEDBMECIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO NLDBFMJEALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> LEIOFNFFBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> GFPJEMKBOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> KHKCAJKDPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> DEGKKGPLJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomDTO> KBGEFCCNNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<string> BKMPJOKFHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DateTime JDHEBOIIMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IDisposable JGBKOGBNCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool IOIHAFCJEAG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HLIJNNFJBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x656030", VA = "0x180657030", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80D230", Offset = "0x80C230", VA = "0x18080D230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime NCAOMBKEOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2790", Offset = "0x5AF1790", VA = "0x185AF2790", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime DGLJPAJKKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2D50", Offset = "0x5AF1D50", VA = "0x185AF2D50", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PPJGDOOGJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2EA0", Offset = "0x5AF1EA0", VA = "0x185AF2EA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DBKPMGNHAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5AEC080", Offset = "0x5AEB080", VA = "0x185AEC080", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long FMGCJBAGHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5AF01D0", Offset = "0x5AEF1D0", VA = "0x185AF01D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? IMAGGBGIAID
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5AEC140", Offset = "0x5AEB140", VA = "0x185AEC140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool HJGPGKDBFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDA20", Offset = "0x5AECA20", VA = "0x185AEDA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool DJLJFCNJENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x131A3D0", Offset = "0x13193D0", VA = "0x18131A3D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5AEBB70", Offset = "0x5AEAB70", VA = "0x185AEBB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> LLCFFAPEKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5AECB60", Offset = "0x5AEBB60", VA = "0x185AECB60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5AEF9F0", Offset = "0x5AEE9F0", VA = "0x185AEF9F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JAAMCKCBDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5AEFA90", Offset = "0x5AEEA90", VA = "0x185AEFA90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5AEBFE0", Offset = "0x5AEAFE0", VA = "0x185AEBFE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action EOIGKEBIHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5AEBF40", Offset = "0x5AEAF40", VA = "0x185AEBF40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB880", Offset = "0x5AEA880", VA = "0x185AEB880", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3720", Offset = "0x5AF2720", VA = "0x185AF3720")]
	[Preserve]
	internal CGOOLJICOAH([NotNull][CDAJDCGEMGI(null)] LNDALGFGLLI NIIGAMEPBMO, [NotNull][CDAJDCGEMGI(null)] HCEMHNCAOAF EKHKPNNMIJG, [NotNull][CDAJDCGEMGI(null)] EIBPNDCCNNG LIFMHDEGPNL, [NotNull][CDAJDCGEMGI(null)] KMCIKKGPHKM OCAFDCAGFJO, [NotNull][CDAJDCGEMGI(null)] EMAEHBHJIKL NEPENNIPLDC, [NotNull][CDAJDCGEMGI(null)] BPKJCDGALIE GIGDLICKJEF, [NotNull][CDAJDCGEMGI(null)] ALHGGIGIAMK MGDIIIBBDKA, [NotNull][CDAJDCGEMGI(null)] EBEKBJENPBA MAMECCODHBI, [NotNull][CDAJDCGEMGI(null)] HCDAFHMBMGC IPDFOMJPIKI, [NotNull][CDAJDCGEMGI(null)] JIPMAIAPMHL GELIDEOKCEI, [NotNull][CDAJDCGEMGI(null)] BKKOCJCOGND AFANONBMOPJ, [NotNull][CDAJDCGEMGI(null)] KHOLGOEJMAD ELBFKIGNLLO, [NotNull][CDAJDCGEMGI(null)] JFHDOCFCACI JAINGBLJHCP, [NotNull][CDAJDCGEMGI(null)] MIGGKFDMCEN LNDENMLDHDN, [NotNull][CDAJDCGEMGI(null)] OOKIKLFCOHC LNPKFAAKJJA, [NotNull][CDAJDCGEMGI(null)] FLLNBHMEHON PLGBJNDGFJN, [NotNull][CDAJDCGEMGI(null)] FMAODHFOLMJ CHBPAFNLPGL, [NotNull][CDAJDCGEMGI(null)] global::EMAEPNKDBJO<KeepsakesConfig.KeepsakesOptions> FJDLENJCEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5AECC00", Offset = "0x5AEBC00", VA = "0x185AECC00", Slot = "13")]
	public bool DNLFNEKMGMM(List<string> JBEDFEDEFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2AC0", Offset = "0x5AF1AC0", VA = "0x185AF2AC0", Slot = "14")]
	public global::DGCAEBAFOOK<Guid> OCAHKEAEPKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3340", Offset = "0x5AF2340", VA = "0x185AF3340", Slot = "35")]
	public NPIGAOPELEF PJPFLJEADAH(Guid JPCNFEICICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5AEEF00", Offset = "0x5AEDF00", VA = "0x185AEEF00", Slot = "15")]
	public NPIGAOPELEF GGHPBNEEOHN(Guid JPCNFEICICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF440", Offset = "0x5AEE440", VA = "0x185AEF440", Slot = "16")]
	public bool GHFFCHJLFDA(Guid JPCNFEICICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1F70", Offset = "0x5AF0F70", VA = "0x185AF1F70", Slot = "17")]
	public bool LPDMLNMEJOL(Guid JPCNFEICICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF820", Offset = "0x5AEE820", VA = "0x185AEF820", Slot = "18")]
	public KeepsakeTheme GJCMKEIKAIJ(Guid JPCNFEICICC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF660", Offset = "0x5AEE660", VA = "0x185AEF660", Slot = "19")]
	public KeepsakeTheme GJCMKEIKAIJ(BLDCOLANFKH LKHPGACOECH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE1A0", Offset = "0x5AED1A0", VA = "0x185AEE1A0", Slot = "20")]
	public bool FMOFHBPHHBM(Guid JPCNFEICICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB810", Offset = "0x5AEA810", VA = "0x185AEB810", Slot = "21")]
	public void AGMKMFPGNJN(Guid JPCNFEICICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2AA0", Offset = "0x5AF1AA0", VA = "0x185AF2AA0", Slot = "22")]
	public void OAIHKOLPKIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0780", Offset = "0x5AEF780", VA = "0x185AF0780", Slot = "23")]
	public void JCDEJMEHFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE3D0", Offset = "0x5AED3D0", VA = "0x185AEE3D0", Slot = "24")]
	public int FOAGPNHACMM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5AEDA30", Offset = "0x5AECA30", VA = "0x185AEDA30", Slot = "25")]
	public global::DGCAEBAFOOK<int> FGGIFCADPNF(long MOLCFNPABNJ, long DFDHNNECIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0D50", Offset = "0x5AEFD50", VA = "0x185AF0D50", Slot = "27")]
	public bool KLDEKJDKLJG(long MOLCFNPABNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2F50", Offset = "0x5AF1F50", VA = "0x185AF2F50", Slot = "36")]
	public bool PFKPBPECOHE(long MOLCFNPABNJ, out MELCBLEGOFM EFHKNNEHFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2190", Offset = "0x5AF1190", VA = "0x185AF2190", Slot = "28")]
	public long MPIJDBJBINE(MJPGAPPFPAP HKOFKMKEKDH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2850", Offset = "0x5AF1850", VA = "0x185AF2850", Slot = "29")]
	public IEnumerable<int> NINNNNDIFCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE0B0", Offset = "0x5AED0B0", VA = "0x185AEE0B0", Slot = "30")]
	public bool FLMBEIEDBMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5AF15C0", Offset = "0x5AF05C0", VA = "0x185AF15C0", Slot = "31")]
	public IEnumerable<long> LJCKHOCJKOA(CDJBNKBIOMK DJEDAICGACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0840", Offset = "0x5AEF840", VA = "0x185AF0840", Slot = "32")]
	public int JPENHDBPDKD(CDJBNKBIOMK DJEDAICGACE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5AEEA00", Offset = "0x5AEDA00", VA = "0x185AEEA00")]
	private void GCCNPHACKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5AEDF00", Offset = "0x5AECF00", VA = "0x185AEDF00")]
	private int FIGDNOFDAEC(KeepsakeRoomListDTO KBKMCFIADMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5AEBCD0", Offset = "0x5AEACD0", VA = "0x185AEBCD0")]
	private int CIBMCKFHDHH(DateTime MLGMHMAJHLK, DateTime AHPEFFIHJOF, TimeSpan MMOELJJDCHE, int EADLMHOKOAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB480", Offset = "0x5AEA480", VA = "0x185AEB480")]
	private bool ABLOADJOFMF(long DPKPLBAINKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5AF24A0", Offset = "0x5AF14A0", VA = "0x185AF24A0")]
	private void NENNKKIOLMD(IEnumerable<KeepsakeInstanceDTO> MMOBFPGHLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5AF35C0", Offset = "0x5AF25C0", VA = "0x185AF35C0")]
	private void POKOHJIEBIA(IEnumerable<KeepsakeCollectionRecordDTO> LNKKHCBHCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5AF08E0", Offset = "0x5AEF8E0", VA = "0x185AF08E0")]
	private void KDGOGMELFNP(IEnumerable<long> FNIHGNFBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5AEFC80", Offset = "0x5AEEC80", VA = "0x185AEFC80")]
	private void HNKHLHALCAF(IEnumerable<KeepsakeCategoryConfigDTO> EONPIJDEEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x135DE20", Offset = "0x135CE20", VA = "0x18135DE20")]
	private void ANJOMBGNIDB(KeepsakeGlobalConfigDTO NLDBFMJEALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5AEFE20", Offset = "0x5AEEE20", VA = "0x185AEFE20")]
	private bool HOBDMMMCLEC(out Guid MFKOBEHJOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5AED520", Offset = "0x5AEC520", VA = "0x185AED520")]
	private void FFFBKKOBHEJ(KeepsakeInstanceDTO KMOFNOBANCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB970", Offset = "0x5AEA970", VA = "0x185AEB970")]
	private void BGCKMKEHEIO(KeepsakeInstanceDTO KMOFNOBANCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5AF06A0", Offset = "0x5AEF6A0", VA = "0x185AF06A0")]
	private void IMGGBCCMBNP(Guid JPCNFEICICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2EF0", Offset = "0x5AF1EF0", VA = "0x185AF2EF0")]
	private void PDIBDBFAPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1340", Offset = "0x5AF0340", VA = "0x185AF1340")]
	private void LEGCFMKMLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB400", Offset = "0x5AEA400", VA = "0x185AEB400")]
	private void ABGIKNKNEBM(KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0170", Offset = "0x5AEF170", VA = "0x185AF0170")]
	private void IACDLGKHPNL(OLIIGPFCJJO.AONNEKGCFAN CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1DC0", Offset = "0x5AF0DC0", VA = "0x185AF1DC0")]
	private void LMGBPPOIMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE640", Offset = "0x5AED640", VA = "0x185AEE640")]
	private void GAMDHNFCMNK(float IJDAILDAFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0DB0", Offset = "0x5AEFDB0", VA = "0x185AF0DB0")]
	private void KOFCDHFKIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2E10", Offset = "0x5AF1E10", VA = "0x185AF2E10")]
	private bool OJGBMBOJJCA(Guid JPCNFEICICC, out string NFEEHPBJGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5AED350", Offset = "0x5AEC350", VA = "0x185AED350")]
	private bool FCMLLJMAACH(Guid JPCNFEICICC, out KeepsakeCategoryConfigDTO JOKGHDDJJFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF580", Offset = "0x5AEE580", VA = "0x185AEF580")]
	private void GIBAJHCECOE(string MEMMBLEEGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF330", Offset = "0x5AEE330", VA = "0x185AEF330")]
	private bool GHDOEGBKOBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0940", Offset = "0x5AEF940", VA = "0x185AF0940")]
	private bool KFOEDHFGMDE(Guid JPCNFEICICC, out string EGNBEILEKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC1E0", Offset = "0x5AEB1E0", VA = "0x185AEC1E0")]
	private void DINADDGIPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5AF26D0", Offset = "0x5AF16D0", VA = "0x185AF26D0")]
	private void NFPOFKGCGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5AECEF0", Offset = "0x5AEBEF0", VA = "0x185AECEF0", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB790", Offset = "0x5AEA790", VA = "0x185AEB790")]
	private NHOKIGNMHJB ACGLPPLIBNP(NAJNLFAFJGC CGAKICCGHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5AEBDA0", Offset = "0x5AEADA0", VA = "0x185AEBDA0")]
	private BIMAAOFKEJA CLLKEPNFLPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5AED6E0", Offset = "0x5AEC6E0", VA = "0x185AED6E0")]
	private Task FFFEMIMBMOG(HCAOAHLBICC KMLLOCJHKPB, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5AEFB30", Offset = "0x5AEEB30", VA = "0x185AEFB30")]
	[AsyncStateMachine(typeof(FKMMLKPLOAD))]
	private Task HLPDOBAJJCC(HCAOAHLBICC KMLLOCJHKPB, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5AEEE70", Offset = "0x5AEDE70", VA = "0x185AEEE70")]
	private Task GFJIDCKMBOJ(HCAOAHLBICC KMLLOCJHKPB, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1E20", Offset = "0x5AF0E20", VA = "0x185AF1E20")]
	[AsyncStateMachine(typeof(EAGBKLIELON))]
	private Task LNAHIEEGMMK(string GOJKMEMCPDE, TimeSpan MKDLMEGBLBI, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0D30", Offset = "0x5AEFD30", VA = "0x185AF0D30")]
	[CompilerGenerated]
	private void NIACJEIGCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB920", Offset = "0x5AEA920", VA = "0x185AEB920")]
	[CompilerGenerated]
	private void AMKLAOOMNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5AF02B0", Offset = "0x5AEF2B0", VA = "0x185AF02B0")]
	[CompilerGenerated]
	private void ICMFDOJOLEG(string EGNBEILEKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0D30", Offset = "0x5AEFD30", VA = "0x185AF0D30")]
	[CompilerGenerated]
	private void KGDJGKIDHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB740", Offset = "0x5AEA740", VA = "0x185AEB740")]
	[CompilerGenerated]
	private void ACGGLLBDIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5AEBBE0", Offset = "0x5AEABE0", VA = "0x185AEBBE0")]
	[CompilerGenerated]
	private bool BMCGECAAEGH(KeepsakeInstanceDTO KNMKEOOODCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1320", Offset = "0x5AF0320", VA = "0x185AF1320")]
	[CompilerGenerated]
	private bool LDDKJFCJCMG(KeepsakeRoomListDTO KNMKEOOODCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1360", Offset = "0x5AF0360", VA = "0x185AF1360")]
	[CompilerGenerated]
	private void LJABJIENGAN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> OBNECILJDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF990", Offset = "0x5AEE990", VA = "0x185AEF990")]
	[CompilerGenerated]
	private void GOJADHNBIJC(string EGNBEILEKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1FA0", Offset = "0x5AF0FA0", VA = "0x185AF1FA0")]
	[CompilerGenerated]
	private Task MOMPAHDAFBC(CancellationToken CBIMPHHOMAP)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::EMAEPNKDBJO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class DCPLAFBKDLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
				public DCPLAFBKDLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x5AF47A0", Offset = "0x5AF37A0", VA = "0x185AF47A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656F40", VA = "0x180657F40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] FFNBCBBOPDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5AF5740", Offset = "0x5AF4740", VA = "0x185AF5740")]
			public KeepsakeTheme GJCMKEIKAIJ(string CBONKNPDHGM)
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5620", Offset = "0x5AF4620", VA = "0x185AF5620")]
		[IMCONJMNGLO(KJBNBKOGAAL.None)]
		private static void LGCOMGILHEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xEED600", Offset = "0xEEC600", VA = "0x180EED600")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB60", Offset = "0x5AE9B60", VA = "0x185AEAB60")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAC70", Offset = "0x5AE9C70", VA = "0x185AEAC70")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
