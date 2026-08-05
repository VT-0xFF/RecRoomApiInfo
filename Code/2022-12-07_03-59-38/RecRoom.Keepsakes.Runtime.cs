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
public enum EMCIMIMBIGG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[HNFPNBBDEHE]
public class HHLEAMBODJJ : BDMHFKNKEPK, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct EJPGNENFNGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string OCNLGOLPBDE = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string PCDNONAFIJF = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string FDACDCGOBBN = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string ABJCCKNNIPB = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string AKJPBEGFOFA = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string ICBIAJOAJMN = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string FGAFOOADPGK = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string GCLMGHNFMEP = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string LHMAENDOJHD = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string LABMDJPFAIN = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string CBMJAKILADN = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class GFLACCCNDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HHLEAMBODJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GFLACCCNDPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D03540", Offset = "0x5D02140", VA = "0x185D03540")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LFMGABBLLEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public HHLEAMBODJJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public LFMGABBLLEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DD00", Offset = "0x5D0C900", VA = "0x185D0DD00")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DD90", Offset = "0x5D0C990", VA = "0x185D0DD90")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DDC0", Offset = "0x5D0C9C0", VA = "0x185D0DDC0")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DFB0", Offset = "0x5D0CBB0", VA = "0x185D0DFB0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DFB0", Offset = "0x5D0CBB0", VA = "0x185D0DFB0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GBOGBINPADC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HHLEAMBODJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GBOGBINPADC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5D03370", Offset = "0x5D01F70", VA = "0x185D03370")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5D03440", Offset = "0x5D02040", VA = "0x185D03440")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5D03440", Offset = "0x5D02040", VA = "0x185D03440")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FFKMOIHPLHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public FFKMOIHPLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x15DAE50", Offset = "0x15D9A50", VA = "0x1815DAE50")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MHCKJKJMDFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public MHCKJKJMDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DFD0", Offset = "0x5D0CBD0", VA = "0x185D0DFD0")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HEGEHAAIFDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public HEGEHAAIFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5D03980", Offset = "0x5D02580", VA = "0x185D03980")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct JPINMDCKALJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HHLEAMBODJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public MMBJADMOHGP args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D630", Offset = "0x5D0C230", VA = "0x185D0D630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DGHKFHHBDNH : IAsyncStateMachine
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
		public HHLEAMBODJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5D03130", Offset = "0x5D01D30", VA = "0x185D03130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DateTime BCIGAFHFGJP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int FDNBGKCKGEO = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DateTime DBHDOBJCEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DateTime OHHEFEFEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LFLICGCJOBI CEAHJCKDCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JMOEENOGAGB ILBAOKPHPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FIGAMFLKCCP HONJLEIBEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly PBCIJMALKDG NBACIJIACOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LOOEEAANAJA GFONEBKMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CHOIOHHGLAC PJCLPCCDNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HHGGLOOLNJE FBCIPODEIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FJJKLBCOJIJ NKGCEELNNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NNDIEODBJGP OCAHCOPOMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NEMDKCNHHPE BFLDHDIHPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly PNIFPFJNMLE HFLOFLIFPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ODFFELAKLCN DMAADCEGMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly PPKLDDKKFDA BOCEMAHNKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly DNEMBOLGCPC IOBEJOJDLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly PANKLONHMLA HOBJKFLHFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly global::CLFEJKCCEGN<KeepsakesConfig.KeepsakesOptions> IEKDCEOMNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> DEAFGHOFDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<Guid> JBPJBDOANPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HashSet<long> NAKEEHAAMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int CPJJBKHJPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<Guid> NKKGFEBGGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IDisposable CMFDEGHLJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Task MJJDBONKCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? LEBHGDDKOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO ODAHDBHBFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private global::GANDAICPPHN<KeepsakeProgressionEventInstancesDTO> BLLIGKAEJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<MGBELCGNHPL, KeepsakeCategoryConfigDTO> KFPGHPFLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO DNJBGBPMHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> AHGGBEOBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<KeepsakeRoomDTO> DHDHLFIJHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomDTO> LNFHBJLMFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomDTO> HBJAIFFBDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomDTO> OJGMEGODHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<string> AHBMLGMJHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DateTime OAFCJHOFPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IDisposable KIAFIFAPHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool FANDPGCHKDO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KKKBMIHHKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x733530", Offset = "0x732130", VA = "0x180733530", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x92F060", Offset = "0x92DC60", VA = "0x18092F060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DateTime ENAOJHNBOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A510", Offset = "0x5D09110", VA = "0x185D0A510", Slot = "11")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DateTime FOOOJDCNOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D054D0", Offset = "0x5D040D0", VA = "0x185D054D0", Slot = "12")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool GGABCDEMIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D03B40", Offset = "0x5D02740", VA = "0x185D03B40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ABNFBNAKMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D08490", Offset = "0x5D07090", VA = "0x185D08490", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long MCDPHGEFANL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A670", Offset = "0x5D09270", VA = "0x185D0A670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long? PHPOFCPJGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A5D0", Offset = "0x5D091D0", VA = "0x185D0A5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private bool EEDFNLJGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D07DF0", Offset = "0x5D069F0", VA = "0x185D07DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal bool KMPFMLIJBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2161AC0", Offset = "0x21606C0", VA = "0x182161AC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D09410", Offset = "0x5D08010", VA = "0x185D09410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> CIMENDHDGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D059E0", Offset = "0x5D045E0", VA = "0x185D059E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BEE0", Offset = "0x5D0AAE0", VA = "0x185D0BEE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BEHFNFAKHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D09200", Offset = "0x5D07E00", VA = "0x185D09200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BE40", Offset = "0x5D0AA40", VA = "0x185D0BE40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PEPHCGGMJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D087D0", Offset = "0x5D073D0", VA = "0x185D087D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D05430", Offset = "0x5D04030", VA = "0x185D05430", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BF80", Offset = "0x5D0AB80", VA = "0x185D0BF80")]
	[Preserve]
	internal HHLEAMBODJJ([NotNull][MLOIHELMKFH(null)] LFLICGCJOBI CEAHJCKDCJO, [NotNull][MLOIHELMKFH(null)] NFJHCNPIOEE GKMDPCCJCLL, [NotNull][MLOIHELMKFH(null)] JMOEENOGAGB ILBAOKPHPGB, [NotNull][MLOIHELMKFH(null)] FIGAMFLKCCP HONJLEIBEGO, [NotNull][MLOIHELMKFH(null)] PBCIJMALKDG NBACIJIACOB, [NotNull][MLOIHELMKFH(null)] LOOEEAANAJA GFONEBKMLAH, [NotNull][MLOIHELMKFH(null)] CHOIOHHGLAC PJCLPCCDNOA, [NotNull][MLOIHELMKFH(null)] HHGGLOOLNJE FBCIPODEIOK, [NotNull][MLOIHELMKFH(null)] FJJKLBCOJIJ NKGCEELNNIP, [NotNull][MLOIHELMKFH(null)] KCHJNIMEJNN NDAOPLEHIJP, [NotNull][MLOIHELMKFH(null)] NNDIEODBJGP OCAHCOPOMDA, [NotNull][MLOIHELMKFH(null)] NEMDKCNHHPE BFLDHDIHPFH, [NotNull][MLOIHELMKFH(null)] PNIFPFJNMLE HFLOFLIFPEB, [NotNull][MLOIHELMKFH(null)] ODFFELAKLCN DMAADCEGMCF, [NotNull][MLOIHELMKFH(null)] PPKLDDKKFDA BOCEMAHNKMD, [NotNull][MLOIHELMKFH(null)] DNEMBOLGCPC IOBEJOJDLDH, [NotNull][MLOIHELMKFH(null)] PANKLONHMLA HOBJKFLHFAO, [NotNull][MLOIHELMKFH(null)] global::CLFEJKCCEGN<KeepsakesConfig.KeepsakesOptions> IEKDCEOMNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D08180", Offset = "0x5D06D80", VA = "0x185D08180", Slot = "13")]
	public bool IPCIOMPMBFE(List<string> DNACHNPDOKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D08A10", Offset = "0x5D07610", VA = "0x185D08A10", Slot = "14")]
	public global::GANDAICPPHN<Guid> JMKAFEHIJII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D08550", Offset = "0x5D07150", VA = "0x185D08550", Slot = "35")]
	public CKHAEIDHOPE JDNGKAGCMIB(Guid MAPKDJHMCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AE90", Offset = "0x5D09A90", VA = "0x185D0AE90", Slot = "15")]
	public CKHAEIDHOPE OEFHGIJHCMN(Guid MAPKDJHMCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D058A0", Offset = "0x5D044A0", VA = "0x185D058A0", Slot = "16")]
	public bool DIJFHMHLOGP(Guid MAPKDJHMCGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D03A20", Offset = "0x5D02620", VA = "0x185D03A20", Slot = "17")]
	public bool ABBFJHIHPEO(Guid MAPKDJHMCGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D06FB0", Offset = "0x5D05BB0", VA = "0x185D06FB0", Slot = "18")]
	public KeepsakeTheme FOCIDGFFACF(Guid MAPKDJHMCGN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D070D0", Offset = "0x5D05CD0", VA = "0x185D070D0", Slot = "19")]
	public KeepsakeTheme FOCIDGFFACF(MGBELCGNHPL CLMDGMMPLCJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D04470", Offset = "0x5D03070", VA = "0x185D04470", Slot = "20")]
	public bool CKAPJAKGKCL(Guid MAPKDJHMCGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D07680", Offset = "0x5D06280", VA = "0x185D07680", Slot = "21")]
	public void GBKFEMCDIFL(Guid MAPKDJHMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D08CA0", Offset = "0x5D078A0", VA = "0x185D08CA0", Slot = "22")]
	public void KBKCFIEEFAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D07E00", Offset = "0x5D06A00", VA = "0x185D07E00", Slot = "23")]
	public void HPBDFIIPCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B240", Offset = "0x5D09E40", VA = "0x185D0B240", Slot = "24")]
	public int OFJINBOOMCL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A770", Offset = "0x5D09370", VA = "0x185D0A770", Slot = "25")]
	public global::GANDAICPPHN<int> MPBCMLOEIBF(long KLMDBCIHINB, long GHACHGBGCFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A320", Offset = "0x5D08F20", VA = "0x185D0A320", Slot = "27")]
	public bool MCIIBBMHANK(long KLMDBCIHINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D07290", Offset = "0x5D05E90", VA = "0x185D07290", Slot = "36")]
	public bool GAMNPGFHKMB(long KLMDBCIHINB, out PKCGJHGMLMH BDLLOIFHKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D05590", Offset = "0x5D04190", VA = "0x185D05590", Slot = "28")]
	public long DBDGJNCADMH(IAHMOPIABGI LKDIPPCAHLM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D051E0", Offset = "0x5D03DE0", VA = "0x185D051E0", Slot = "29")]
	public IEnumerable<int> CLMDLKKDCKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D092A0", Offset = "0x5D07EA0", VA = "0x185D092A0", Slot = "30")]
	public bool KJGEMFFIDLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D06470", Offset = "0x5D05070", VA = "0x185D06470", Slot = "31")]
	public IEnumerable<long> FDHJKHCCHJM(DBLAEJFJBMI OGMGIFFOKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D07EC0", Offset = "0x5D06AC0", VA = "0x185D07EC0", Slot = "32")]
	public int IECCJPLMEHN(DBLAEJFJBMI OGMGIFFOKGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D04000", Offset = "0x5D02C00", VA = "0x185D04000")]
	private void CDPJNEKNDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D06CD0", Offset = "0x5D058D0", VA = "0x185D06CD0")]
	private int FIGOAHNBCCI(KeepsakeRoomListDTO GBIEPHEHCGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D05A80", Offset = "0x5D04680", VA = "0x185D05A80")]
	private int DMFOOJHLNAF(DateTime CILEOIKJFMH, DateTime KLCNIJEIHMI, TimeSpan ACFMPECMOAB, int ODIMMGFGGDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D09570", Offset = "0x5D08170", VA = "0x185D09570")]
	private bool LAEGBGNOIOL(long BMPOEOKCLHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BC10", Offset = "0x5D0A810", VA = "0x185D0BC10")]
	private void PBKGOPJDEJM(IEnumerable<KeepsakeInstanceDTO> DEAFGHOFDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D03EA0", Offset = "0x5D02AA0", VA = "0x185D03EA0")]
	private void BNNLEIBJPLB(IEnumerable<KeepsakeCollectionRecordDTO> BHFDHOLEOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D06300", Offset = "0x5D04F00", VA = "0x185D06300")]
	private void EILGAPBDPEF(IEnumerable<long> KBFDNOBIFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D07FE0", Offset = "0x5D06BE0", VA = "0x185D07FE0")]
	private void ILBECPGKOGG(IEnumerable<KeepsakeCategoryConfigDTO> PIPGAIJJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x945CD0", Offset = "0x9448D0", VA = "0x180945CD0")]
	private void NPPIINPFOGP(KeepsakeGlobalConfigDTO DNJBGBPMHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D05FB0", Offset = "0x5D04BB0", VA = "0x185D05FB0")]
	private bool EEICNMOKNMO(out Guid BMHBCNKCLPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D046A0", Offset = "0x5D032A0", VA = "0x185D046A0")]
	private void CKEBKHOGOII(KeepsakeInstanceDTO HBGBAJHAEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D078E0", Offset = "0x5D064E0", VA = "0x185D078E0")]
	private void GHNDOFKFFPD(KeepsakeInstanceDTO HBGBAJHAEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AC40", Offset = "0x5D09840", VA = "0x185D0AC40")]
	private void NDPMKFEFHHC(Guid MAPKDJHMCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D03E40", Offset = "0x5D02A40", VA = "0x185D03E40")]
	private void BGHBKLGEJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AE70", Offset = "0x5D09A70", VA = "0x185D0AE70")]
	private void NENHJKCNCEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D09390", Offset = "0x5D07F90", VA = "0x185D09390")]
	private void KKGHCFGHFLB(KOBJCIBGGPL EDBLIFGMKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D07D90", Offset = "0x5D06990", VA = "0x185D07D90")]
	private void HNJIGBCAGHA(JFJPPIBBMKC.PIBCPDFABNJ AOEMDAGAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D06C70", Offset = "0x5D05870", VA = "0x185D06C70")]
	private void FEMJHOJGHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D09C20", Offset = "0x5D08820", VA = "0x185D09C20")]
	private void LJHKIONOGEJ(float NNIJCKDNEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B6A0", Offset = "0x5D0A2A0", VA = "0x185D0B6A0")]
	private void OJAJLGIOBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D076F0", Offset = "0x5D062F0", VA = "0x185D076F0")]
	private bool GFIJLFAACJJ(Guid MAPKDJHMCGN, out string CEKGLEPOPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D03BB0", Offset = "0x5D027B0", VA = "0x185D03BB0")]
	private bool BENJOMEKKIP(Guid MAPKDJHMCGN, out KeepsakeCategoryConfigDTO FBPLEGGBHNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D06E80", Offset = "0x5D05A80", VA = "0x185D06E80")]
	private void FIMDLDABHIG(string MJHHKEMPFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D06360", Offset = "0x5D04F60", VA = "0x185D06360")]
	private bool ELNBKMBBNCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D08CC0", Offset = "0x5D078C0", VA = "0x185D08CC0")]
	private bool KDDPBMDKPCE(Guid MAPKDJHMCGN, out string CHGFDAMICCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D04860", Offset = "0x5D03460", VA = "0x185D04860")]
	private void CKFDHOBMGDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D03D80", Offset = "0x5D02980", VA = "0x185D03D80")]
	private void BGDJMEBBCID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A380", Offset = "0x5D08F80", VA = "0x185D0A380")]
	internal static string MKEFJIJNOHL(HCBNLOOEACC IALGCKHFKBD, string PBMBHDHKLFP, bool MGNOHMGKKME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D05B50", Offset = "0x5D04750", VA = "0x185D05B50", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D07F60", Offset = "0x5D06B60", VA = "0x185D07F60")]
	private ENHABCKLLMN IHBDMKCMFJF(JCBHONMOFEO MHBPNGKFGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5D08870", Offset = "0x5D07470", VA = "0x185D08870")]
	private ABIIDIIIDBI JLNCKJDKIAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D09FE0", Offset = "0x5D08BE0", VA = "0x185D09FE0")]
	private Task LNMDPDMGONJ(MMBJADMOHGP JGHKPEFMHLD, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D090B0", Offset = "0x5D07CB0", VA = "0x185D090B0")]
	[AsyncStateMachine(typeof(JPINMDCKALJ))]
	private Task KDPDMFPCLOD(MMBJADMOHGP JGHKPEFMHLD, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5D03AB0", Offset = "0x5D026B0", VA = "0x185D03AB0")]
	private Task AOCONBNDGDF(MMBJADMOHGP JGHKPEFMHLD, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AD20", Offset = "0x5D09920", VA = "0x185D0AD20")]
	[AsyncStateMachine(typeof(DGHKFHHBDNH))]
	private Task NEIEINCFLEP(string DPNJMDFICMK, TimeSpan GBOIGLPJNJA, CancellationToken OKPCBPJCBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D03B90", Offset = "0x5D02790", VA = "0x185D03B90")]
	[CompilerGenerated]
	private void EGDKHAJIPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5D07AE0", Offset = "0x5D066E0", VA = "0x185D07AE0")]
	[CompilerGenerated]
	private void HEGHKAMKDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D09830", Offset = "0x5D08430", VA = "0x185D09830")]
	[CompilerGenerated]
	private void LIKCCDGIPOL(string CHGFDAMICCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D03B90", Offset = "0x5D02790", VA = "0x185D03B90")]
	[CompilerGenerated]
	private void BBMFACNHBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D06F60", Offset = "0x5D05B60", VA = "0x185D06F60")]
	[CompilerGenerated]
	private void FLFNMKMKHND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5D09480", Offset = "0x5D08080", VA = "0x185D09480")]
	[CompilerGenerated]
	private bool KNKFJJLJLOJ(KeepsakeInstanceDTO CCOKEBDEHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A750", Offset = "0x5D09350", VA = "0x185D0A750")]
	[CompilerGenerated]
	private bool MOOPHHOKLAD(KeepsakeRoomListDTO CCOKEBDEHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D07B30", Offset = "0x5D06730", VA = "0x185D07B30")]
	[CompilerGenerated]
	private void HILLEPNMEGH(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> PDNIALBCECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5D03A50", Offset = "0x5D02650", VA = "0x185D03A50")]
	[CompilerGenerated]
	private void AEIJHHIPFIL(string CHGFDAMICCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B4B0", Offset = "0x5D0A0B0", VA = "0x185D0B4B0")]
	[CompilerGenerated]
	private Task OHKHOKKKPEC(CancellationToken LGFGLDOAKEL)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::CLFEJKCCEGN<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class AFBNPLCLGHH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
				public AFBNPLCLGHH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5D03100", Offset = "0x5D01D00", VA = "0x185D03100")]
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
			[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] IHCBHGDPCOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5D0DBC0", Offset = "0x5D0C7C0", VA = "0x185D0DBC0")]
			public KeepsakeTheme FOCIDGFFACF(string BKGLIHGCOCF)
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DAA0", Offset = "0x5D0C6A0", VA = "0x185D0DAA0")]
		[JGJJPBKAAKL(HKPPGBCDEPD.None)]
		private static void CCOFINLLKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x71C1E0", Offset = "0x71ADE0", VA = "0x18071C1E0")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D000", Offset = "0x5D0BC00", VA = "0x185D0D000")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D110", Offset = "0x5D0BD10", VA = "0x185D0D110")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
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
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
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
