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
public class LFNDPALLBMO : IComparer<FBNLAPOEIEP>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class EEDFGFMIFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public FBNLAPOEIEP x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public FBNLAPOEIEP y;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EEDFGFMIFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xFB89F0", Offset = "0xFB79F0", VA = "0x180FB89F0")]
		internal bool <Compare>b__0(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x11CFF40", Offset = "0x11CEF40", VA = "0x1811CFF40")]
		internal bool <Compare>b__1(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xFB89F0", Offset = "0xFB79F0", VA = "0x180FB89F0")]
		internal bool <Compare>b__2(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x11CFF40", Offset = "0x11CEF40", VA = "0x1811CFF40")]
		internal bool <Compare>b__3(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> KJLJLGDECJD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	public LFNDPALLBMO(List<KeepsakeCategoryThemePair> DJJMCEDLLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5598A80", Offset = "0x5597A80", VA = "0x185598A80", Slot = "4")]
	public int Compare(FBNLAPOEIEP PMEDGJGANML, FBNLAPOEIEP NIPKEFBPNPH)
	{
		return default(int);
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public FBNLAPOEIEP KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LFLPGECEFAF
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[FMPNEILFHMB]
public class PMIBAFCDKAJ : FDNDICKDGCJ, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct GLOHBEKGIDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string KLFIEHCCDIH = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public const string OKPGLNGIFHO = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public const string CJPPLKDOFAA = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public const string DBAMIHECBFP = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string AGFBBAHHAFH = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string JFMIGPDNLPA = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string DAFJIFBJBEF = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string MPCOMOIAGAP = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string HEBKICBKNAL = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string ACAEJLIKEOJ = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string MAKELJPAMFI = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string ODPGOIHLBHL = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EJBCNFNHAKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public FBNLAPOEIEP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EJBCNFNHAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5596FD0", Offset = "0x5595FD0", VA = "0x185596FD0")]
		internal void <CreateKeepsakeInstanceData>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5596CE0", Offset = "0x5595CE0", VA = "0x185596CE0")]
		internal void <CreateKeepsakeInstanceData>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PDLEMFEOLFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PDLEMFEOLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5599C80", Offset = "0x5598C80", VA = "0x185599C80")]
		internal void <DeleteKeepsakeInstanceData>b__0()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5599E60", Offset = "0x5598E60", VA = "0x185599E60")]
		internal void <DeleteKeepsakeInstanceData>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IBDMOHANIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int uncollectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public IBDMOHANIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5597EF0", Offset = "0x5596EF0", VA = "0x185597EF0")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PHMDMGHFOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PHMDMGHFOFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5599EC0", Offset = "0x5598EC0", VA = "0x185599EC0")]
		internal bool <GetKeepsakeCategory>b__0(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class APJIBBAEFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public FBNLAPOEIEP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public APJIBBAEFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x55965F0", Offset = "0x55955F0", VA = "0x1855965F0")]
		internal bool <GetRemainingKeepsakeViewQuantityForCurrentRoom>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NELJODBHOPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FBNLAPOEIEP? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public NELJODBHOPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5599490", Offset = "0x5598490", VA = "0x185599490")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5597270", Offset = "0x5596270", VA = "0x185597270")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5599520", Offset = "0x5598520", VA = "0x185599520")]
		internal global::MLDKKGKEACN<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x55975B0", Offset = "0x55965B0", VA = "0x1855975B0")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class DLCMNANEICF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NELJODBHOPP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public DLCMNANEICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5596AC0", Offset = "0x5595AC0", VA = "0x185596AC0")]
		internal global::MLDKKGKEACN<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IHDMEPLNGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DLCMNANEICF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public IHDMEPLNGIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5598300", Offset = "0x5597300", VA = "0x185598300")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IMKOCACCKFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public IHDMEPLNGIC CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public IMKOCACCKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5598430", Offset = "0x5597430", VA = "0x185598430")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__6(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OELHFHJFLNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public OELHFHJFLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5599A60", Offset = "0x5598A60", VA = "0x185599A60")]
		internal global::MLDKKGKEACN<IEnumerable<Guid>> <GetUncollectedKeepsakeInstanceIdsForRoom>b__0(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x31C36D0", Offset = "0x31C26D0", VA = "0x1831C36D0")]
		internal bool <GetUncollectedKeepsakeInstanceIdsForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FONPFGKBCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public FONPFGKBCIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x55971E0", Offset = "0x55961E0", VA = "0x1855971E0")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5597270", Offset = "0x5596270", VA = "0x185597270")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x55972A0", Offset = "0x55962A0", VA = "0x1855972A0")]
		internal global::MLDKKGKEACN<Dictionary<Guid, FBNLAPOEIEP>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x55975B0", Offset = "0x55965B0", VA = "0x1855975B0")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IOMDOOFLECG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public IOMDOOFLECG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5598520", Offset = "0x5597520", VA = "0x185598520")]
		internal global::MLDKKGKEACN<Dictionary<Guid, FBNLAPOEIEP>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class MEODLBKAOHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public MEODLBKAOHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x55991B0", Offset = "0x55981B0", VA = "0x1855991B0")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x55992A0", Offset = "0x55982A0", VA = "0x1855992A0")]
		internal KeyValuePair<Guid, FBNLAPOEIEP> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__6(Guid instanceId)
		{
			return default(KeyValuePair<Guid, FBNLAPOEIEP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KLLFJNIHFEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public KLLFJNIHFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x55986F0", Offset = "0x55976F0", VA = "0x1855986F0")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__7(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NIMGHCMMFBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public NIMGHCMMFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5599830", Offset = "0x5598830", VA = "0x185599830")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__8(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PJABNHNKFOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PJABNHNKFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5599EF0", Offset = "0x5598EF0", VA = "0x185599EF0")]
		internal global::MLDKKGKEACN<Dictionary<Guid, FBNLAPOEIEP>> <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__0(Dictionary<Guid, FBNLAPOEIEP> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x31C36D0", Offset = "0x31C26D0", VA = "0x1831C36D0")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GLGPDIJBLIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public GLGPDIJBLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5597840", Offset = "0x5596840", VA = "0x185597840")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__2(KeyValuePair<Guid, FBNLAPOEIEP> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BPNNGBKPKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Dictionary<Guid, FBNLAPOEIEP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public BPNNGBKPKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5596720", Offset = "0x5595720", VA = "0x185596720")]
		internal KeyValuePair<FBNLAPOEIEP, int> <GetUncollectedKeepsakeCountPerCategoryForRoom>b__1(FBNLAPOEIEP category)
		{
			return default(KeyValuePair<FBNLAPOEIEP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DGBBPJOIJFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FBNLAPOEIEP category;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public DGBBPJOIJFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1521CD0", Offset = "0x1520CD0", VA = "0x181521CD0")]
		internal bool <GetUncollectedKeepsakeCountPerCategoryForRoom>b__2(FBNLAPOEIEP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NOAJGJFCLHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Dictionary<Guid, FBNLAPOEIEP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public NOAJGJFCLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x55998D0", Offset = "0x55988D0", VA = "0x1855998D0")]
		internal KeyValuePair<FBNLAPOEIEP, int> <GetTotalKeepsakeCountPerCategoryForRoom>b__1(FBNLAPOEIEP category)
		{
			return default(KeyValuePair<FBNLAPOEIEP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GCBLADEEEKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public FBNLAPOEIEP category;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public GCBLADEEEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1521CD0", Offset = "0x1520CD0", VA = "0x181521CD0")]
		internal bool <GetTotalKeepsakeCountPerCategoryForRoom>b__2(FBNLAPOEIEP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GJOABMHAPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public GJOABMHAPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5597670", Offset = "0x5596670", VA = "0x185597670")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5597740", Offset = "0x5596740", VA = "0x185597740")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5597740", Offset = "0x5596740", VA = "0x185597740")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ACGGFBNOHHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ACGGFBNOHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1048690", Offset = "0x1047690", VA = "0x181048690")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DLIDGKOGJAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public DLIDGKOGJAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5596C10", Offset = "0x5595C10", VA = "0x185596C10")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x124DAE0", Offset = "0x124CAE0", VA = "0x18124DAE0")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PNGNJNKEFDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PNGNJNKEFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x55A7880", Offset = "0x55A6880", VA = "0x1855A7880")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KECPCOBMPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public KECPCOBMPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1048690", Offset = "0x1047690", VA = "0x181048690")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FMDGHDIPLIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public FMDGHDIPLIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5597150", Offset = "0x5596150", VA = "0x185597150")]
		internal bool <IsKeepsakeInCurrentKeepsakeCategory>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LDHOKFKEOBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public LDHOKFKEOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x55989E0", Offset = "0x55979E0", VA = "0x1855989E0")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MFAAOGGPPPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public MFAAOGGPPPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5599400", Offset = "0x5598400", VA = "0x185599400")]
		internal bool <IncrementCollectedKeepsakeCount>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NKOHIPPNGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public FBNLAPOEIEP newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public NKOHIPPNGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1249460", Offset = "0x1248460", VA = "0x181249460")]
		internal bool <OnKeepsakeCollected>b__0(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class GIOCFKCGAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public GIOCFKCGAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x55975D0", Offset = "0x55965D0", VA = "0x1855975D0")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class EOPOEFLNMFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EOPOEFLNMFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5597060", Offset = "0x5596060", VA = "0x185597060")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class OKFBJBEDLNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public EOPOEFLNMFD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public OKFBJBEDLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5599C00", Offset = "0x5598C00", VA = "0x185599C00")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct LMOBHNAFEAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CFHLAPPAJEA args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5598D20", Offset = "0x5597D20", VA = "0x185598D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct CGAFILDKIPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public PMIBAFCDKAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5596880", Offset = "0x5595880", VA = "0x185596880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int NMEDIICFOKE = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DateTime EIEJNOPPJAM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int EDGLFKKJLCE = 3;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const long BPBLNOLMFLM = -1L;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const char LJNBDIAAEPA = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly AOACPKJAGKK EMOIHNNHJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KKPAJPAEEIC PDJJMCADICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly AOMKHEJEIEB IEJAMHODHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GNDOIFNPIIE GLGHFHMLMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly KGDENEBHHDJ COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MKDGOPHFAHL CBFGFNIJKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly BOKMOHADHNB DEKNPAMPDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly AAIJNBNHFAC COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FDONALBFGFD IJFBOOJHOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KEIAOPMBLPD BHPKJNPMCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly ELJBHGBOPDM MKALAAPBFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly OJEIHFMKMDN BNHOJJJNNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly BOHHGEFMIEP MODJLGGJALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly BOANNILCNKG KLKIAHEMFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly JIENPLKFJBP LJOCFDIHGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly global::PNKNMHKICEJ<KeepsakesConfig.KeepsakesOptions> PPHOLEMBGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly JGEBMMLMDCN PNLBPGFBHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> KCFLJAEKCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HashSet<Guid> EMJFKNNJCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HashSet<long> MJEMFCPHJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private Dictionary<FBNLAPOEIEP, int> HCLDECKMCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> CPLCPFHAMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IDisposable BJECEHNHFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Task GMHFHDADEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private long? JEBAJMHODOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KeepsakeProgressionEventInstancesDTO AKDAJLFBEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private global::MLDKKGKEACN<KeepsakeProgressionEventInstancesDTO> LHEAJCHFEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private IReadOnlyDictionary<FBNLAPOEIEP, KeepsakeCategoryConfigDTO> CPJMDFBNCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private KeepsakeGlobalConfigDTO BCNKAHCKMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HashSet<long> IIPDOHPPKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HashSet<long> IHPPPPLONGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private List<KeepsakeRoomListDTO> PKDNKCHAFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<KeepsakeRoomListDTO> JPEAFBJLFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<KeepsakeRoomListDTO> HEDMGCNEHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, string> POHNELNPJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, string> KEHBHKMHFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<long, DateTime> GLKIMBBPCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NKAKJAMKGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, List<KeepsakeRoomDTO>> KKOGNADMFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, long> AOLLJPNNJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<string> IMBIBNIJKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private DateTime BMGFMOGJJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly IDisposable BINNILHFEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<FBNLAPOEIEP, int> OHKLOHJOMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Dictionary<FBNLAPOEIEP, int> BOFJDNMHCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private List<KeepsakeCategoryThemePair> DJJMCEDLLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private LFNDPALLBMO EICPAEPKCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool LKBAOFJFKBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CAHOFACFJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF030", Offset = "0x6DE030", VA = "0x1806DF030", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA49830", Offset = "0xA48830", VA = "0x180A49830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AEKMDPGPAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x559FAC0", Offset = "0x559EAC0", VA = "0x18559FAC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HBDKJHCFOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x559C800", Offset = "0x559B800", VA = "0x18559C800", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long EANEOHFCHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x559C0E0", Offset = "0x559B0E0", VA = "0x18559C0E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? LBOLECJGDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55A3F40", Offset = "0x55A2F40", VA = "0x1855A3F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool OGMLOCPILMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x559EE30", Offset = "0x559DE30", VA = "0x18559EE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GFMLPANINIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCD4210", Offset = "0xCD3210", VA = "0x180CD4210", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> CDGBFFGMNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x91EEB0", Offset = "0x91DEB0", VA = "0x18091EEB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> POGKPJDAMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x91EEC0", Offset = "0x91DEC0", VA = "0x18091EEC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> IKHOAIDOOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x91EE70", Offset = "0x91DE70", VA = "0x18091EE70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> ACPEMDNFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xDD5F40", Offset = "0xDD4F40", VA = "0x180DD5F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool COJJGLCMFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x115CFE0", Offset = "0x115BFE0", VA = "0x18115CFE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55A58C0", Offset = "0x55A48C0", VA = "0x1855A58C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> BDOIJHGNJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x559F2E0", Offset = "0x559E2E0", VA = "0x18559F2E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x55A0F30", Offset = "0x559FF30", VA = "0x1855A0F30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NIPIOCBACJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x559B7E0", Offset = "0x559A7E0", VA = "0x18559B7E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x559F1E0", Offset = "0x559E1E0", VA = "0x18559F1E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action HCDPLHFEJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x559E600", Offset = "0x559D600", VA = "0x18559E600", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x55A0500", Offset = "0x559F500", VA = "0x1855A0500", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x55A6600", Offset = "0x55A5600", VA = "0x1855A6600")]
	[Preserve]
	internal PMIBAFCDKAJ([NotNull][KCHLPHCLLFB(null)] AOACPKJAGKK EMOIHNNHJHN, [NotNull][KCHLPHCLLFB(null)] NBOCNEHEBNI IIFHCFCAGLK, [NotNull][KCHLPHCLLFB(null)] KKPAJPAEEIC PDJJMCADICN, [NotNull][KCHLPHCLLFB(null)] AOMKHEJEIEB IEJAMHODHLC, [NotNull][KCHLPHCLLFB(null)] GNDOIFNPIIE GLGHFHMLMBI, [NotNull][KCHLPHCLLFB(null)] KGDENEBHHDJ COCGOKADOBB, [NotNull][KCHLPHCLLFB(null)] MKDGOPHFAHL CBFGFNIJKLM, [NotNull][KCHLPHCLLFB(null)] BOKMOHADHNB DEKNPAMPDAO, [NotNull][KCHLPHCLLFB(null)] AAIJNBNHFAC COOCGBJBNBF, [NotNull][KCHLPHCLLFB(null)] GELMFPINIAK GAJJJAPNPDN, [NotNull][KCHLPHCLLFB(null)] FDONALBFGFD IJFBOOJHOLE, [NotNull][KCHLPHCLLFB(null)] KEIAOPMBLPD BHPKJNPMCGD, [NotNull][KCHLPHCLLFB(null)] ELJBHGBOPDM MKALAAPBFHE, [NotNull][KCHLPHCLLFB(null)] OJEIHFMKMDN BNHOJJJNNNO, [NotNull][KCHLPHCLLFB(null)] BOHHGEFMIEP MODJLGGJALA, [NotNull][KCHLPHCLLFB(null)] BOANNILCNKG KLKIAHEMFFM, [NotNull][KCHLPHCLLFB(null)] JIENPLKFJBP LJOCFDIHGLJ, [NotNull][KCHLPHCLLFB(null)] global::PNKNMHKICEJ<KeepsakesConfig.KeepsakesOptions> PPHOLEMBGPL, [NotNull][KCHLPHCLLFB(null)] JGEBMMLMDCN PNLBPGFBHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x55A2480", Offset = "0x55A1480", VA = "0x1855A2480", Slot = "15")]
	public bool KGFDCEMPIAH(List<string> CMPPOBGBJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x55A62C0", Offset = "0x55A52C0", VA = "0x1855A62C0", Slot = "16")]
	public global::MLDKKGKEACN<Guid> PJHNPMGPDNC(FBNLAPOEIEP PDABEOHHMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x559A7B0", Offset = "0x55997B0", VA = "0x18559A7B0", Slot = "17")]
	public LLEFGLIPMKI AFMHHKPPIED(Guid HJMKLGECFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55A4FB0", Offset = "0x55A3FB0", VA = "0x1855A4FB0", Slot = "18")]
	public LLEFGLIPMKI OJDCKNCMALN(Guid HJMKLGECFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55A49A0", Offset = "0x55A39A0", VA = "0x1855A49A0", Slot = "19")]
	public bool NMJBNDNJHDG(Guid HJMKLGECFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x55A05A0", Offset = "0x559F5A0", VA = "0x1855A05A0", Slot = "20")]
	public bool HHIGELIGLDK(Guid HJMKLGECFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x55A5340", Offset = "0x55A4340", VA = "0x1855A5340")]
	public KeepsakeTheme OLEPLMIOBPB(Guid HJMKLGECFPL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x559E140", Offset = "0x559D140", VA = "0x18559E140")]
	public bool DALEPJONING(FBNLAPOEIEP PDABEOHHMMM, out KeepsakeTheme IMIPKJHHOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x559A110", Offset = "0x5599110", VA = "0x18559A110")]
	public List<KeepsakeTheme> ACHDIPOIGEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x559F380", Offset = "0x559E380", VA = "0x18559F380")]
	public int FAEIFIIHGLD(FBNLAPOEIEP PDABEOHHMMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x559BBA0", Offset = "0x559ABA0", VA = "0x18559BBA0")]
	public FBNLAPOEIEP BDIODBDEKNH(Guid HJMKLGECFPL)
	{
		return default(FBNLAPOEIEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x559BA50", Offset = "0x559AA50", VA = "0x18559BA50", Slot = "34")]
	public List<FBNLAPOEIEP> BCKFGHCPAED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x559BD10", Offset = "0x559AD10", VA = "0x18559BD10", Slot = "35")]
	public IComparer<FBNLAPOEIEP> BEHKHAJNMJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x55A1550", Offset = "0x55A0550", VA = "0x1855A1550", Slot = "32")]
	public string JFDJAKGPOEN(FBNLAPOEIEP PDABEOHHMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x55A4670", Offset = "0x55A3670", VA = "0x1855A4670", Slot = "33")]
	public string NGPDBICFKFK(FBNLAPOEIEP PDABEOHHMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x55A02D0", Offset = "0x559F2D0", VA = "0x1855A02D0", Slot = "21")]
	public bool GPHBGHLBEDB(Guid HJMKLGECFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x55A0FD0", Offset = "0x559FFD0", VA = "0x1855A0FD0", Slot = "22")]
	public void INHLKBJLIMJ(Guid HJMKLGECFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x55A0A80", Offset = "0x559FA80", VA = "0x1855A0A80", Slot = "23")]
	public void HMCHMDMOFCC(FBNLAPOEIEP PDABEOHHMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x55A3730", Offset = "0x55A2730", VA = "0x1855A3730", Slot = "24")]
	public void LLCDFCPKAOG(FBNLAPOEIEP PDABEOHHMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x55A1AE0", Offset = "0x55A0AE0", VA = "0x1855A1AE0", Slot = "25")]
	public int KCPBBDAMBDJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x55A1F30", Offset = "0x55A0F30", VA = "0x1855A1F30", Slot = "54")]
	public int KCPBBDAMBDJ(FBNLAPOEIEP PDABEOHHMMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x55A5EB0", Offset = "0x55A4EB0", VA = "0x1855A5EB0", Slot = "31")]
	public global::MLDKKGKEACN<IEnumerable<Guid>> PJDFGAFDJHE(long BAOKNFPKMNE, long DMOCKHNJMOB, FBNLAPOEIEP? PDABEOHHMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x559EE40", Offset = "0x559DE40", VA = "0x18559EE40", Slot = "30")]
	public global::MLDKKGKEACN<IEnumerable<Guid>> EEDPICKAMDB(long BAOKNFPKMNE, long DMOCKHNJMOB, FBNLAPOEIEP? PDABEOHHMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x55A2D40", Offset = "0x55A1D40", VA = "0x1855A2D40", Slot = "55")]
	public global::MLDKKGKEACN<Dictionary<Guid, FBNLAPOEIEP>> KKPMAEICOGH(long BAOKNFPKMNE, long DMOCKHNJMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55A5C50", Offset = "0x55A4C50", VA = "0x1855A5C50", Slot = "56")]
	public global::MLDKKGKEACN<Dictionary<Guid, FBNLAPOEIEP>> PHBGFAMOAPG(long BAOKNFPKMNE, long DMOCKHNJMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x559D920", Offset = "0x559C920", VA = "0x18559D920", Slot = "26")]
	public global::MLDKKGKEACN<int> CKOFMODFENE(long BAOKNFPKMNE, long DMOCKHNJMOB, FBNLAPOEIEP? PDABEOHHMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x55A05D0", Offset = "0x559F5D0", VA = "0x1855A05D0", Slot = "27")]
	public global::MLDKKGKEACN<int> HIMOKEKFODG(long BAOKNFPKMNE, long DMOCKHNJMOB, FBNLAPOEIEP? PDABEOHHMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x55A59D0", Offset = "0x55A49D0", VA = "0x1855A59D0", Slot = "28")]
	public global::MLDKKGKEACN<Dictionary<FBNLAPOEIEP, int>> PFLECNFKMAA(long BAOKNFPKMNE, long DMOCKHNJMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x559E900", Offset = "0x559D900", VA = "0x18559E900", Slot = "29")]
	public global::MLDKKGKEACN<Dictionary<FBNLAPOEIEP, int>> DNDPJGGHEJO(long BAOKNFPKMNE, long DMOCKHNJMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x559B780", Offset = "0x559A780", VA = "0x18559B780", Slot = "37")]
	public bool BADACNCBFNA(long BAOKNFPKMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x55A5BF0", Offset = "0x55A4BF0", VA = "0x1855A5BF0", Slot = "57")]
	public bool PFLJCHFNEAO(long BAOKNFPKMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x55A5930", Offset = "0x55A4930", VA = "0x1855A5930", Slot = "38")]
	public bool PFGAJPDBKAA(long BAOKNFPKMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x55A16C0", Offset = "0x55A06C0", VA = "0x1855A16C0", Slot = "58")]
	public bool JPEGJNHLKLI(long BAOKNFPKMNE, out MNHBHGPELLB LPEJOPAAHMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x559CA60", Offset = "0x559BA60", VA = "0x18559CA60", Slot = "39")]
	public bool CELPHGNEPMN(long DMMOICLIJJP, out DateTime ANCOKIGDCCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x55A3A20", Offset = "0x55A2A20", VA = "0x1855A3A20", Slot = "40")]
	public long LNDCHFIFAPF(long DMMOICLIJJP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x559F4F0", Offset = "0x559E4F0", VA = "0x18559F4F0", Slot = "59")]
	public IEnumerable<int> FDHIFOJCFHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x559AC90", Offset = "0x5599C90", VA = "0x18559AC90", Slot = "41")]
	public long AHDODFAEEGD(long BAOKNFPKMNE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x559EFE0", Offset = "0x559DFE0", VA = "0x18559EFE0", Slot = "42")]
	public int EHEJOAMAMEM(long DMMOICLIJJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x55A57D0", Offset = "0x55A47D0", VA = "0x1855A57D0", Slot = "43")]
	public bool PAOPFEGKOIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x559C1C0", Offset = "0x559B1C0", VA = "0x18559C1C0", Slot = "44")]
	public bool BMBPHPFIEJE(long DMMOICLIJJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x559FEB0", Offset = "0x559EEB0", VA = "0x18559FEB0", Slot = "45")]
	public IEnumerable<long> GLNMLEKBMGC(long DMMOICLIJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x55A3FD0", Offset = "0x55A2FD0", VA = "0x1855A3FD0", Slot = "46")]
	public int MJAOBDIJNOD(long DMMOICLIJJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x55A3150", Offset = "0x55A2150", VA = "0x1855A3150", Slot = "50")]
	public long LHFDCKJHEFB(long JHALHACMGMJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x559A460", Offset = "0x5599460", VA = "0x18559A460", Slot = "51")]
	public FBNLAPOEIEP AFMAGKCPFBL()
	{
		return default(FBNLAPOEIEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x559BFA0", Offset = "0x559AFA0", VA = "0x18559BFA0")]
	private bool BGGDCGCPPEB(Guid HJMKLGECFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x559B0F0", Offset = "0x559A0F0", VA = "0x18559B0F0")]
	private void AJNCODGOINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x55A4AE0", Offset = "0x55A3AE0", VA = "0x1855A4AE0")]
	private FBNLAPOEIEP OBBNNIPOIBJ()
	{
		return default(FBNLAPOEIEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x55A2790", Offset = "0x55A1790", VA = "0x1855A2790")]
	private void KKNJGGOCNHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x559F910", Offset = "0x559E910", VA = "0x18559F910")]
	private int GBJHCHDKLFJ(KeepsakeRoomListDTO EGFCLPPDOLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x55A5DE0", Offset = "0x55A4DE0", VA = "0x1855A5DE0")]
	private int PJCOEPABAOJ(DateTime APBGNCJJOBP, DateTime FPEBPGFKEOC, TimeSpan FPBNHKHJMNB, int DMALPMIEEPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x559BDB0", Offset = "0x559ADB0", VA = "0x18559BDB0")]
	private void BFGIEFFFOEL(IEnumerable<KeepsakeInstanceDTO> KCFLJAEKCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x55A0090", Offset = "0x559F090", VA = "0x1855A0090")]
	private void GNCHCPPLPAD(IEnumerable<KeepsakeCollectionRecordDTO> EFNCAMJEIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x559B880", Offset = "0x559A880", VA = "0x18559B880")]
	private void BBLCNCFMPJH(IEnumerable<long> BPGBPEIAKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x10D6B50", Offset = "0x10D5B50", VA = "0x1810D6B50")]
	private void ODAABPKIMKG(KeepsakeGlobalConfigDTO BCNKAHCKMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x559ADB0", Offset = "0x5599DB0", VA = "0x18559ADB0")]
	private bool AJHJPDFCKKB(out Guid NCDMPDICOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x55A0F00", Offset = "0x559FF00", VA = "0x1855A0F00")]
	private void HPPFBOFKFEN(FBNLAPOEIEP FEEAMAGEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x559E6A0", Offset = "0x559D6A0", VA = "0x18559E6A0")]
	private void DKMFFDEKLIH(FBNLAPOEIEP FEEAMAGEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x559E7B0", Offset = "0x559D7B0", VA = "0x18559E7B0")]
	private void DLMHLAEJBKL(Guid HJMKLGECFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x559E6D0", Offset = "0x559D6D0", VA = "0x18559E6D0")]
	private void DLGDNOKPJKL(FBNLAPOEIEP FEEAMAGEPJO, int CPFNGBEBEDB, ref Dictionary<FBNLAPOEIEP, int> KHEIJEFKPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x559AA90", Offset = "0x5599A90", VA = "0x18559AA90")]
	private void AGEGFDGFOKG(KeepsakeInstanceDTO APPFBADEKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x55A0880", Offset = "0x559F880", VA = "0x1855A0880")]
	private void HJLIPLFPEPA(KeepsakeInstanceDTO APPFBADEKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x559FB10", Offset = "0x559EB10", VA = "0x18559FB10")]
	private void GKMPAINLDGH(Guid HJMKLGECFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x559F280", Offset = "0x559E280", VA = "0x18559F280")]
	private void EILKGFFHPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x559BA30", Offset = "0x559AA30", VA = "0x18559BA30")]
	private void BCEBAJOEPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55A5480", Offset = "0x55A4480", VA = "0x1855A5480")]
	private void OPHJFAMMJHO(HEBGCJNBOAC ADAHMABAIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x55A2420", Offset = "0x55A1420", VA = "0x1855A2420")]
	private void KEAKLAGAPEO(FJOIFEIJFJB.EDBAINKGJMB AELIHOPICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x55A1A80", Offset = "0x55A0A80", VA = "0x1855A1A80")]
	private void JPHHFMOKBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x55A1190", Offset = "0x55A0190", VA = "0x1855A1190")]
	private void JCHELEIJHBG(float OAFPBCOAIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x559DBD0", Offset = "0x559CBD0", VA = "0x18559DBD0")]
	private void CNCMGAGGJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x559E400", Offset = "0x559D400", VA = "0x18559E400")]
	private bool DIGDMMPELCH(Guid HJMKLGECFPL, out string MKJIOKDPDFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x559F740", Offset = "0x559E740", VA = "0x18559F740")]
	private bool FILKPPJFIND(Guid HJMKLGECFPL, out KeepsakeCategoryConfigDTO FEEAMAGEPJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x55A07A0", Offset = "0x559F7A0", VA = "0x1855A07A0")]
	private void HJBMAKBGNLH(string CHPNEJPOGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55A3E30", Offset = "0x55A2E30", VA = "0x1855A3E30")]
	private bool LOFGBCNFNPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55A54F0", Offset = "0x55A44F0", VA = "0x1855A54F0")]
	private IEnumerable<long> OPMIMDHJFEK(IEnumerable<KeepsakeRoomDTO> IECGAKGGLHP, IEnumerable<KeepsakeRoomListDTO> HKNHNEBOKIK, long DMMOICLIJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x55A40A0", Offset = "0x55A30A0", VA = "0x1855A40A0")]
	private bool MPKLPOKJIGF(Guid HJMKLGECFPL, out string CNMFEBEOFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x55A0740", Offset = "0x559F740", VA = "0x1855A0740", Slot = "47")]
	public string HJAJADJLHMG(EFIGCOHIBCN DBPLLMECNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55A0AC0", Offset = "0x559FAC0", VA = "0x1855A0AC0", Slot = "49")]
	public string HPJPNDHAJLN(EFIGCOHIBCN DBPLLMECNHO, long BAOKNFPKMNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x55A3490", Offset = "0x55A2490", VA = "0x1855A3490", Slot = "48")]
	public string LKCHKGJEGEF(EFIGCOHIBCN DBPLLMECNHO, int GLPKMAHJBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x559CBB0", Offset = "0x559BBB0", VA = "0x18559CBB0")]
	private void CGDKFPIFNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55A47E0", Offset = "0x55A37E0", VA = "0x1855A47E0")]
	private void NKIAAIKMHAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x559D900", Offset = "0x559C900", VA = "0x18559D900")]
	private EFIGCOHIBCN CHDJGCJDKIG(MJODDCFAIHO GFPDCAIDFFK)
	{
		return default(EFIGCOHIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55A4080", Offset = "0x55A3080", VA = "0x1855A4080")]
	private EFIGCOHIBCN MNGINNJGEDL(MJODDCFAIHO GFPDCAIDFFK)
	{
		return default(EFIGCOHIBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55A2240", Offset = "0x55A1240", VA = "0x1855A2240")]
	internal static string KDOPOJACBGP(CPNAAMKIELG PEMGHFHLHDL, string BHPJLNLCNBI, bool BGCOBPPDCEN, int HMAICEOPBGC, int JNDNGGKEHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x559E9D0", Offset = "0x559D9D0", VA = "0x18559E9D0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55A4920", Offset = "0x55A3920", VA = "0x1855A4920")]
	private BOFLHNLEOJF NLOEFPCGCBL(HHHLLJHNCOK BLHPEGMEJLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x559C8C0", Offset = "0x559B8C0", VA = "0x18559C8C0")]
	private JBINPNMDLBH CCAAFEJDLPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x559C480", Offset = "0x559B480", VA = "0x18559C480")]
	private Task BNNMEDCOGEL(CFHLAPPAJEA KCPODLJODHA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x559B8E0", Offset = "0x559A8E0", VA = "0x18559B8E0")]
	[AsyncStateMachine(typeof(LMOBHNAFEAA))]
	private Task BBNAHCNKBOM(CFHLAPPAJEA KCPODLJODHA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x55A45D0", Offset = "0x55A35D0", VA = "0x1855A45D0")]
	private Task NCMCNCFCLGD(CFHLAPPAJEA KCPODLJODHA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x55A1040", Offset = "0x55A0040", VA = "0x1855A1040")]
	[AsyncStateMachine(typeof(CGAFILDKIPK))]
	private Task JBHGGFFEKHN(string GOMILMNIGIC, TimeSpan NJMCMBDPBBG, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x559E310", Offset = "0x559D310", VA = "0x18559E310")]
	[CompilerGenerated]
	private bool DHEHPFLBCBG(KeepsakeInstanceDTO PMEDGJGANML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x55A35B0", Offset = "0x55A25B0", VA = "0x1855A35B0")]
	[CompilerGenerated]
	private global::MLDKKGKEACN<Dictionary<FBNLAPOEIEP, int>> LKJFBFJAMIF(Dictionary<Guid, FBNLAPOEIEP> LPILOKCFHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x55A38A0", Offset = "0x55A28A0", VA = "0x1855A38A0")]
	[CompilerGenerated]
	private global::MLDKKGKEACN<Dictionary<FBNLAPOEIEP, int>> LLLJLCMKIFH(Dictionary<Guid, FBNLAPOEIEP> LPILOKCFHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55A4E10", Offset = "0x55A3E10", VA = "0x1855A4E10")]
	[CompilerGenerated]
	private bool OCGIPKIKFHE(KeepsakeRoomListDTO PMEDGJGANML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55A4E90", Offset = "0x55A3E90", VA = "0x1855A4E90")]
	[CompilerGenerated]
	private void OIMBMDLAFKD(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<FBNLAPOEIEP, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> DBIGCGIMDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x55A4E30", Offset = "0x55A3E30", VA = "0x1855A4E30")]
	[CompilerGenerated]
	private void OIIJMBOKONN(string CNMFEBEOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x559B590", Offset = "0x559A590", VA = "0x18559B590")]
	[CompilerGenerated]
	private Task ALJLFCFPLDA(CancellationToken JPCKMJGCPOO)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public float LoopingSfxVolume;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KeepsakesConfig : ScriptableObject, global::PNKNMHKICEJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			[CompilerGenerated]
			private sealed class OCKDINGEGMD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
				public OCKDINGEGMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x5599A30", Offset = "0x5598A30", VA = "0x185599A30")]
				internal bool <TryGetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x5599A30", Offset = "0x5598A30", VA = "0x185599A30")]
				internal bool <TryGetKeepsakeTheme>b__1(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] GONCBKJFDKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5598810", Offset = "0x5597810", VA = "0x185598810")]
			public bool DEEJFABJECC(string OLLINLFPDIK, out KeepsakeTheme IMIPKJHHOPG)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5598790", Offset = "0x5597790", VA = "0x185598790")]
		[JDLBAGCFHIO(MEDANDNEHIF.None)]
		private static void KFLICAKIADO(DDFGGHLLPGI MBIOGPPGEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xE23C60", Offset = "0xE22C60", VA = "0x180E23C60")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x55978C0", Offset = "0x55968C0", VA = "0x1855978C0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x55979D0", Offset = "0x55969D0", VA = "0x1855979D0")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
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
