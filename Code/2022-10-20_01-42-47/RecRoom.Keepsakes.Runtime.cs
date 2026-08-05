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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DECNLDLCEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5ADF080", Offset = "0x5ADDE80", VA = "0x185ADF080")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public DDOOHKDKPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5ADEDB0", Offset = "0x5ADDBB0", VA = "0x185ADEDB0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5ADEE40", Offset = "0x5ADDC40", VA = "0x185ADEE40")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5ADEE70", Offset = "0x5ADDC70", VA = "0x185ADEE70")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5ADF060", Offset = "0x5ADDE60", VA = "0x185ADF060")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5ADF060", Offset = "0x5ADDE60", VA = "0x185ADF060")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ADFJIIIMINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5770", Offset = "0x5AD4570", VA = "0x185AD5770")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5840", Offset = "0x5AD4640", VA = "0x185AD5840")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5840", Offset = "0x5AD4640", VA = "0x185AD5840")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public IGBCCJBOMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xEF1F20", Offset = "0xEF0D20", VA = "0x180EF1F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HMKPEIEPHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5ADFB60", Offset = "0x5ADE960", VA = "0x185ADFB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public BKCIDBKAHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5940", Offset = "0x5AD4740", VA = "0x185AD5940")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADF6F0", Offset = "0x5ADE4F0", VA = "0x185ADF6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADF4B0", Offset = "0x5ADE2B0", VA = "0x185ADF4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F6830", Offset = "0x7F5630", VA = "0x1807F6830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime NCAOMBKEOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5ADCD70", Offset = "0x5ADBB70", VA = "0x185ADCD70", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime DGLJPAJKKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5ADD330", Offset = "0x5ADC130", VA = "0x185ADD330", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PPJGDOOGJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5ADD480", Offset = "0x5ADC280", VA = "0x185ADD480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DBKPMGNHAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6660", Offset = "0x5AD5460", VA = "0x185AD6660", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long FMGCJBAGHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5ADA7B0", Offset = "0x5AD95B0", VA = "0x185ADA7B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? IMAGGBGIAID
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6720", Offset = "0x5AD5520", VA = "0x185AD6720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool HJGPGKDBFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8000", Offset = "0x5AD6E00", VA = "0x185AD8000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool DJLJFCNJENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1141240", Offset = "0x1140040", VA = "0x181141240")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6150", Offset = "0x5AD4F50", VA = "0x185AD6150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> LLCFFAPEKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7140", Offset = "0x5AD5F40", VA = "0x185AD7140", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9FD0", Offset = "0x5AD8DD0", VA = "0x185AD9FD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JAAMCKCBDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5ADA070", Offset = "0x5AD8E70", VA = "0x185ADA070", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5AD65C0", Offset = "0x5AD53C0", VA = "0x185AD65C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action EOIGKEBIHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6520", Offset = "0x5AD5320", VA = "0x185AD6520", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5E60", Offset = "0x5AD4C60", VA = "0x185AD5E60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5ADDD00", Offset = "0x5ADCB00", VA = "0x185ADDD00")]
	[Preserve]
	internal CGOOLJICOAH([NotNull][CDAJDCGEMGI(null)] LNDALGFGLLI NIIGAMEPBMO, [NotNull][CDAJDCGEMGI(null)] HCEMHNCAOAF EKHKPNNMIJG, [NotNull][CDAJDCGEMGI(null)] EIBPNDCCNNG LIFMHDEGPNL, [NotNull][CDAJDCGEMGI(null)] KMCIKKGPHKM OCAFDCAGFJO, [NotNull][CDAJDCGEMGI(null)] EMAEHBHJIKL NEPENNIPLDC, [NotNull][CDAJDCGEMGI(null)] BPKJCDGALIE GIGDLICKJEF, [NotNull][CDAJDCGEMGI(null)] ALHGGIGIAMK MGDIIIBBDKA, [NotNull][CDAJDCGEMGI(null)] EBEKBJENPBA MAMECCODHBI, [NotNull][CDAJDCGEMGI(null)] HCDAFHMBMGC IPDFOMJPIKI, [NotNull][CDAJDCGEMGI(null)] JIPMAIAPMHL GELIDEOKCEI, [NotNull][CDAJDCGEMGI(null)] BKKOCJCOGND AFANONBMOPJ, [NotNull][CDAJDCGEMGI(null)] KHOLGOEJMAD ELBFKIGNLLO, [NotNull][CDAJDCGEMGI(null)] JFHDOCFCACI JAINGBLJHCP, [NotNull][CDAJDCGEMGI(null)] MIGGKFDMCEN LNDENMLDHDN, [NotNull][CDAJDCGEMGI(null)] OOKIKLFCOHC LNPKFAAKJJA, [NotNull][CDAJDCGEMGI(null)] FLLNBHMEHON PLGBJNDGFJN, [NotNull][CDAJDCGEMGI(null)] FMAODHFOLMJ CHBPAFNLPGL, [NotNull][CDAJDCGEMGI(null)] global::EMAEPNKDBJO<KeepsakesConfig.KeepsakesOptions> FJDLENJCEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5AD71E0", Offset = "0x5AD5FE0", VA = "0x185AD71E0", Slot = "13")]
	public bool DNLFNEKMGMM(List<string> JBEDFEDEFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD0A0", Offset = "0x5ADBEA0", VA = "0x185ADD0A0", Slot = "14")]
	public global::DGCAEBAFOOK<Guid> OCAHKEAEPKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD920", Offset = "0x5ADC720", VA = "0x185ADD920", Slot = "35")]
	public NPIGAOPELEF PJPFLJEADAH(Guid JPCNFEICICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5AD94E0", Offset = "0x5AD82E0", VA = "0x185AD94E0", Slot = "15")]
	public NPIGAOPELEF GGHPBNEEOHN(Guid JPCNFEICICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9A20", Offset = "0x5AD8820", VA = "0x185AD9A20", Slot = "16")]
	public bool GHFFCHJLFDA(Guid JPCNFEICICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC550", Offset = "0x5ADB350", VA = "0x185ADC550", Slot = "17")]
	public bool LPDMLNMEJOL(Guid JPCNFEICICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9E00", Offset = "0x5AD8C00", VA = "0x185AD9E00", Slot = "18")]
	public KeepsakeTheme GJCMKEIKAIJ(Guid JPCNFEICICC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9C40", Offset = "0x5AD8A40", VA = "0x185AD9C40", Slot = "19")]
	public KeepsakeTheme GJCMKEIKAIJ(BLDCOLANFKH LKHPGACOECH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8780", Offset = "0x5AD7580", VA = "0x185AD8780", Slot = "20")]
	public bool FMOFHBPHHBM(Guid JPCNFEICICC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5DF0", Offset = "0x5AD4BF0", VA = "0x185AD5DF0", Slot = "21")]
	public void AGMKMFPGNJN(Guid JPCNFEICICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD080", Offset = "0x5ADBE80", VA = "0x185ADD080", Slot = "22")]
	public void OAIHKOLPKIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5ADAD60", Offset = "0x5AD9B60", VA = "0x185ADAD60", Slot = "23")]
	public void JCDEJMEHFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD89B0", Offset = "0x5AD77B0", VA = "0x185AD89B0", Slot = "24")]
	public int FOAGPNHACMM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8010", Offset = "0x5AD6E10", VA = "0x185AD8010", Slot = "25")]
	public global::DGCAEBAFOOK<int> FGGIFCADPNF(long MOLCFNPABNJ, long DFDHNNECIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB330", Offset = "0x5ADA130", VA = "0x185ADB330", Slot = "27")]
	public bool KLDEKJDKLJG(long MOLCFNPABNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD530", Offset = "0x5ADC330", VA = "0x185ADD530", Slot = "36")]
	public bool PFKPBPECOHE(long MOLCFNPABNJ, out MELCBLEGOFM EFHKNNEHFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC770", Offset = "0x5ADB570", VA = "0x185ADC770", Slot = "28")]
	public long MPIJDBJBINE(MJPGAPPFPAP HKOFKMKEKDH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5ADCE30", Offset = "0x5ADBC30", VA = "0x185ADCE30", Slot = "29")]
	public IEnumerable<int> NINNNNDIFCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8690", Offset = "0x5AD7490", VA = "0x185AD8690", Slot = "30")]
	public bool FLMBEIEDBMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ADBBA0", Offset = "0x5ADA9A0", VA = "0x185ADBBA0", Slot = "31")]
	public IEnumerable<long> LJCKHOCJKOA(CDJBNKBIOMK DJEDAICGACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5ADAE20", Offset = "0x5AD9C20", VA = "0x185ADAE20", Slot = "32")]
	public int JPENHDBPDKD(CDJBNKBIOMK DJEDAICGACE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8FE0", Offset = "0x5AD7DE0", VA = "0x185AD8FE0")]
	private void GCCNPHACKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5AD84E0", Offset = "0x5AD72E0", VA = "0x185AD84E0")]
	private int FIGDNOFDAEC(KeepsakeRoomListDTO KBKMCFIADMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD62B0", Offset = "0x5AD50B0", VA = "0x185AD62B0")]
	private int CIBMCKFHDHH(DateTime MLGMHMAJHLK, DateTime AHPEFFIHJOF, TimeSpan MMOELJJDCHE, int EADLMHOKOAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5A60", Offset = "0x5AD4860", VA = "0x185AD5A60")]
	private bool ABLOADJOFMF(long DPKPLBAINKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5ADCA80", Offset = "0x5ADB880", VA = "0x185ADCA80")]
	private void NENNKKIOLMD(IEnumerable<KeepsakeInstanceDTO> MMOBFPGHLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5ADDBA0", Offset = "0x5ADC9A0", VA = "0x185ADDBA0")]
	private void POKOHJIEBIA(IEnumerable<KeepsakeCollectionRecordDTO> LNKKHCBHCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5ADAEC0", Offset = "0x5AD9CC0", VA = "0x185ADAEC0")]
	private void KDGOGMELFNP(IEnumerable<long> FNIHGNFBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA260", Offset = "0x5AD9060", VA = "0x185ADA260")]
	private void HNKHLHALCAF(IEnumerable<KeepsakeCategoryConfigDTO> EONPIJDEEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1184CE0", Offset = "0x1183AE0", VA = "0x181184CE0")]
	private void ANJOMBGNIDB(KeepsakeGlobalConfigDTO NLDBFMJEALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA400", Offset = "0x5AD9200", VA = "0x185ADA400")]
	private bool HOBDMMMCLEC(out Guid MFKOBEHJOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7B00", Offset = "0x5AD6900", VA = "0x185AD7B00")]
	private void FFFBKKOBHEJ(KeepsakeInstanceDTO KMOFNOBANCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5F50", Offset = "0x5AD4D50", VA = "0x185AD5F50")]
	private void BGCKMKEHEIO(KeepsakeInstanceDTO KMOFNOBANCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5ADAC80", Offset = "0x5AD9A80", VA = "0x185ADAC80")]
	private void IMGGBCCMBNP(Guid JPCNFEICICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD4D0", Offset = "0x5ADC2D0", VA = "0x185ADD4D0")]
	private void PDIBDBFAPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB920", Offset = "0x5ADA720", VA = "0x185ADB920")]
	private void LEGCFMKMLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5AD59E0", Offset = "0x5AD47E0", VA = "0x185AD59E0")]
	private void ABGIKNKNEBM(KMCFCCDNIEO AEPPKPHGPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA750", Offset = "0x5AD9550", VA = "0x185ADA750")]
	private void IACDLGKHPNL(OLIIGPFCJJO.AONNEKGCFAN CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC3A0", Offset = "0x5ADB1A0", VA = "0x185ADC3A0")]
	private void LMGBPPOIMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8C20", Offset = "0x5AD7A20", VA = "0x185AD8C20")]
	private void GAMDHNFCMNK(float IJDAILDAFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB390", Offset = "0x5ADA190", VA = "0x185ADB390")]
	private void KOFCDHFKIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD3F0", Offset = "0x5ADC1F0", VA = "0x185ADD3F0")]
	private bool OJGBMBOJJCA(Guid JPCNFEICICC, out string NFEEHPBJGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7930", Offset = "0x5AD6730", VA = "0x185AD7930")]
	private bool FCMLLJMAACH(Guid JPCNFEICICC, out KeepsakeCategoryConfigDTO JOKGHDDJJFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9B60", Offset = "0x5AD8960", VA = "0x185AD9B60")]
	private void GIBAJHCECOE(string MEMMBLEEGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9910", Offset = "0x5AD8710", VA = "0x185AD9910")]
	private bool GHDOEGBKOBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5ADAF20", Offset = "0x5AD9D20", VA = "0x185ADAF20")]
	private bool KFOEDHFGMDE(Guid JPCNFEICICC, out string EGNBEILEKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5AD67C0", Offset = "0x5AD55C0", VA = "0x185AD67C0")]
	private void DINADDGIPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5ADCCB0", Offset = "0x5ADBAB0", VA = "0x185ADCCB0")]
	private void NFPOFKGCGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5AD74D0", Offset = "0x5AD62D0", VA = "0x185AD74D0", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5D70", Offset = "0x5AD4B70", VA = "0x185AD5D70")]
	private NHOKIGNMHJB ACGLPPLIBNP(NAJNLFAFJGC CGAKICCGHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6380", Offset = "0x5AD5180", VA = "0x185AD6380")]
	private BIMAAOFKEJA CLLKEPNFLPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7CC0", Offset = "0x5AD6AC0", VA = "0x185AD7CC0")]
	private Task FFFEMIMBMOG(HCAOAHLBICC KMLLOCJHKPB, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA110", Offset = "0x5AD8F10", VA = "0x185ADA110")]
	[AsyncStateMachine(typeof(FKMMLKPLOAD))]
	private Task HLPDOBAJJCC(HCAOAHLBICC KMLLOCJHKPB, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9450", Offset = "0x5AD8250", VA = "0x185AD9450")]
	private Task GFJIDCKMBOJ(HCAOAHLBICC KMLLOCJHKPB, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC400", Offset = "0x5ADB200", VA = "0x185ADC400")]
	[AsyncStateMachine(typeof(EAGBKLIELON))]
	private Task LNAHIEEGMMK(string GOJKMEMCPDE, TimeSpan MKDLMEGBLBI, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB310", Offset = "0x5ADA110", VA = "0x185ADB310")]
	[CompilerGenerated]
	private void NIACJEIGCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5F00", Offset = "0x5AD4D00", VA = "0x185AD5F00")]
	[CompilerGenerated]
	private void AMKLAOOMNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA890", Offset = "0x5AD9690", VA = "0x185ADA890")]
	[CompilerGenerated]
	private void ICMFDOJOLEG(string EGNBEILEKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB310", Offset = "0x5ADA110", VA = "0x185ADB310")]
	[CompilerGenerated]
	private void KGDJGKIDHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5D20", Offset = "0x5AD4B20", VA = "0x185AD5D20")]
	[CompilerGenerated]
	private void ACGGLLBDIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD61C0", Offset = "0x5AD4FC0", VA = "0x185AD61C0")]
	[CompilerGenerated]
	private bool BMCGECAAEGH(KeepsakeInstanceDTO KNMKEOOODCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB900", Offset = "0x5ADA700", VA = "0x185ADB900")]
	[CompilerGenerated]
	private bool LDDKJFCJCMG(KeepsakeRoomListDTO KNMKEOOODCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB940", Offset = "0x5ADA740", VA = "0x185ADB940")]
	[CompilerGenerated]
	private void LJABJIENGAN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> OBNECILJDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9F70", Offset = "0x5AD8D70", VA = "0x185AD9F70")]
	[CompilerGenerated]
	private void GOJADHNBIJC(string EGNBEILEKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC580", Offset = "0x5ADB380", VA = "0x185ADC580")]
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
				[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
				public DCPLAFBKDLJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x5ADED80", Offset = "0x5ADDB80", VA = "0x185ADED80")]
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
			[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656D40", VA = "0x180657F40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] FFNBCBBOPDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5ADFD20", Offset = "0x5ADEB20", VA = "0x185ADFD20")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5ADFC00", Offset = "0x5ADEA00", VA = "0x185ADFC00")]
		[IMCONJMNGLO(KJBNBKOGAAL.None)]
		private static void LGCOMGILHEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xD12960", Offset = "0xD11760", VA = "0x180D12960")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5140", Offset = "0x5AD3F40", VA = "0x185AD5140")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5250", Offset = "0x5AD4050", VA = "0x185AD5250")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
