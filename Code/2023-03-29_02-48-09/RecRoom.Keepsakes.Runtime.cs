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
public class PBADNLJIOPB : IComparer<HKHJHFEFCAI>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FGOIPEONKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HKHJHFEFCAI x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public HKHJHFEFCAI y;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public FGOIPEONKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x11E4250", Offset = "0x11E3050", VA = "0x1811E4250")]
		internal bool <Compare>b__0(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x15C4DF0", Offset = "0x15C3BF0", VA = "0x1815C4DF0")]
		internal bool <Compare>b__1(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x11E4250", Offset = "0x11E3050", VA = "0x1811E4250")]
		internal bool <Compare>b__2(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x15C4DF0", Offset = "0x15C3BF0", VA = "0x1815C4DF0")]
		internal bool <Compare>b__3(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> LEKMIPCIJCA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
	public PBADNLJIOPB(List<KeepsakeCategoryThemePair> DDDPGCCKEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x55EFD70", Offset = "0x55EEB70", VA = "0x1855EFD70", Slot = "4")]
	public int Compare(HKHJHFEFCAI PAMKNJCGOGK, HKHJHFEFCAI IOAMOMOPNDK)
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
		public HKHJHFEFCAI KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KBMLJLLCCLC
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DBJDBDKBAOF]
public class IECBPDHLCAC : GCAGGPINOLE, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct JHGLAIOANBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string CDJKPEKLOGP = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public const string BIGJDHLLDBO = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public const string KALPJAHDOLC = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public const string IEJAMIEPOLM = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string AEDMFLCAHCL = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string MJOIPEJAFLO = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string INFGIMIPJIO = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string KILHJDCMBEK = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string POLAHLBGHJA = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string ACHOKKJNINB = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string MPMNCBFAIBO = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string LJCGGKOLAJF = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ABDFCOBMFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IECBPDHLCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public HKHJHFEFCAI keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ABDFCOBMFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x55DF220", Offset = "0x55DE020", VA = "0x1855DF220")]
		internal void <CreateKeepsakeInstanceData>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x55DEF30", Offset = "0x55DDD30", VA = "0x1855DEF30")]
		internal void <CreateKeepsakeInstanceData>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IMACCPAHEFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IECBPDHLCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public IMACCPAHEFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x55EE810", Offset = "0x55ED610", VA = "0x1855EE810")]
		internal void <DeleteKeepsakeInstanceData>b__0()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x55EE9F0", Offset = "0x55ED7F0", VA = "0x1855EE9F0")]
		internal void <DeleteKeepsakeInstanceData>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NIIPMDHNPLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IECBPDHLCAC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public NIIPMDHNPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x55EF810", Offset = "0x55EE610", VA = "0x1855EF810")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DMMEDKDNFPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public DMMEDKDNFPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x55DFF50", Offset = "0x55DED50", VA = "0x1855DFF50")]
		internal bool <GetKeepsakeCategory>b__0(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NBIHIODCBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IECBPDHLCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public HKHJHFEFCAI keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public NBIHIODCBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x55EF6E0", Offset = "0x55EE4E0", VA = "0x1855EF6E0")]
		internal bool <GetRemainingKeepsakeViewQuantityForCurrentRoom>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FKJPALEHFEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public IECBPDHLCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HKHJHFEFCAI? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public FKJPALEHFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x55E0010", Offset = "0x55DEE10", VA = "0x1855E0010")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x55DF920", Offset = "0x55DE720", VA = "0x1855DF920")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x55E00A0", Offset = "0x55DEEA0", VA = "0x1855E00A0")]
		internal global::ONJEHKCKOLK<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x55DFC60", Offset = "0x55DEA60", VA = "0x1855DFC60")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OICEGCOICLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public FKJPALEHFEK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public OICEGCOICLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x55EFC20", Offset = "0x55EEA20", VA = "0x1855EFC20")]
		internal global::ONJEHKCKOLK<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class ICIJFEEFLCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OICEGCOICLB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ICIJFEEFLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x55E0F00", Offset = "0x55DFD00", VA = "0x1855E0F00")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DHDANDGLMKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public ICIJFEEFLCE CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public DHDANDGLMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x55DFC80", Offset = "0x55DEA80", VA = "0x1855DFC80")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__6(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class HBJCBKALCBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IECBPDHLCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public HBJCBKALCBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x55E0910", Offset = "0x55DF710", VA = "0x1855E0910")]
		internal global::ONJEHKCKOLK<IEnumerable<Guid>> <GetUncollectedKeepsakeInstanceIdsForRoom>b__0(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E93810", Offset = "0x3E92610", VA = "0x183E93810")]
		internal bool <GetUncollectedKeepsakeInstanceIdsForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class CJMHECMPOJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public IECBPDHLCAC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public CJMHECMPOJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x55DF890", Offset = "0x55DE690", VA = "0x1855DF890")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x55DF920", Offset = "0x55DE720", VA = "0x1855DF920")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x55DF950", Offset = "0x55DE750", VA = "0x1855DF950")]
		internal global::ONJEHKCKOLK<Dictionary<Guid, HKHJHFEFCAI>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x55DFC60", Offset = "0x55DEA60", VA = "0x1855DFC60")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class CDENLBIJAHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public CDENLBIJAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x55DF6C0", Offset = "0x55DE4C0", VA = "0x1855DF6C0")]
		internal global::ONJEHKCKOLK<Dictionary<Guid, HKHJHFEFCAI>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HKMFDJAMHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public HKMFDJAMHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x55E0C10", Offset = "0x55DFA10", VA = "0x1855E0C10")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x55E0D00", Offset = "0x55DFB00", VA = "0x1855E0D00")]
		internal KeyValuePair<Guid, HKHJHFEFCAI> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__6(Guid instanceId)
		{
			return default(KeyValuePair<Guid, HKHJHFEFCAI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KGFHBNPOOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public KGFHBNPOOLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x55EED40", Offset = "0x55EDB40", VA = "0x1855EED40")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__7(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BJNCPCMPBCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public BJNCPCMPBCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x55DF620", Offset = "0x55DE420", VA = "0x1855DF620")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__8(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PGHHEMDPDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public IECBPDHLCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PGHHEMDPDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x55F0010", Offset = "0x55EEE10", VA = "0x1855F0010")]
		internal global::ONJEHKCKOLK<Dictionary<Guid, HKHJHFEFCAI>> <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__0(Dictionary<Guid, HKHJHFEFCAI> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E93810", Offset = "0x3E92610", VA = "0x183E93810")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MOEHHALKNFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public MOEHHALKNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x55EF660", Offset = "0x55EE460", VA = "0x1855EF660")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__2(KeyValuePair<Guid, HKHJHFEFCAI> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HBKNGDPPMAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Dictionary<Guid, HKHJHFEFCAI> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public HBKNGDPPMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x55E0AB0", Offset = "0x55DF8B0", VA = "0x1855E0AB0")]
		internal KeyValuePair<HKHJHFEFCAI, int> <GetUncollectedKeepsakeCountPerCategoryForRoom>b__1(HKHJHFEFCAI category)
		{
			return default(KeyValuePair<HKHJHFEFCAI, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BKOOHPMCAMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HKHJHFEFCAI category;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public BKOOHPMCAMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1B2C3A0", Offset = "0x1B2B1A0", VA = "0x181B2C3A0")]
		internal bool <GetUncollectedKeepsakeCountPerCategoryForRoom>b__2(HKHJHFEFCAI instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DIFKNJMPNEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Dictionary<Guid, HKHJHFEFCAI> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public DIFKNJMPNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x55DFD70", Offset = "0x55DEB70", VA = "0x1855DFD70")]
		internal KeyValuePair<HKHJHFEFCAI, int> <GetTotalKeepsakeCountPerCategoryForRoom>b__1(HKHJHFEFCAI category)
		{
			return default(KeyValuePair<HKHJHFEFCAI, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class AKDNFNLBKAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HKHJHFEFCAI category;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public AKDNFNLBKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1B2C3A0", Offset = "0x1B2B1A0", VA = "0x181B2C3A0")]
		internal bool <GetTotalKeepsakeCountPerCategoryForRoom>b__2(HKHJHFEFCAI instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IOJCHCCGGNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public IECBPDHLCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public IOJCHCCGGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x55EEA50", Offset = "0x55ED850", VA = "0x1855EEA50")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x55EEB20", Offset = "0x55ED920", VA = "0x1855EEB20")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x55EEB20", Offset = "0x55ED920", VA = "0x1855EEB20")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FLPMJOKOCBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public FLPMJOKOCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1265A90", Offset = "0x1264890", VA = "0x181265A90")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GCJFKACOEDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public GCJFKACOEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x55E03B0", Offset = "0x55DF1B0", VA = "0x1855E03B0")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1670A40", Offset = "0x166F840", VA = "0x181670A40")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IDCLNOJLIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public IDCLNOJLIHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x55E1030", Offset = "0x55DFE30", VA = "0x1855E1030")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PNJLHBGJCGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PNJLHBGJCGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1265A90", Offset = "0x1264890", VA = "0x181265A90")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ENDHONCBAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ENDHONCBAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x55DFF80", Offset = "0x55DED80", VA = "0x1855DFF80")]
		internal bool <IsKeepsakeInCurrentKeepsakeCategory>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AJEPODIPFNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public AJEPODIPFNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x55DF2B0", Offset = "0x55DE0B0", VA = "0x1855DF2B0")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AJJLNPIHOON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public AJJLNPIHOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x55DF350", Offset = "0x55DE150", VA = "0x1855DF350")]
		internal bool <IncrementCollectedKeepsakeCount>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class GGNAOBFPCGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public HKHJHFEFCAI newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public GGNAOBFPCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x166BC00", Offset = "0x166AA00", VA = "0x18166BC00")]
		internal bool <OnKeepsakeCollected>b__0(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HNONDDFAPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public HNONDDFAPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x55E0E60", Offset = "0x55DFC60", VA = "0x1855E0E60")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class JFGKBMOKBCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public JFGKBMOKBCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x55EEC20", Offset = "0x55EDA20", VA = "0x1855EEC20")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class DKHODCEEAII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public JFGKBMOKBCB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public DKHODCEEAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x55DFED0", Offset = "0x55DECD0", VA = "0x1855DFED0")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct GCJJGHBEHGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IECBPDHLCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public FLICEPDFAIO args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x55E0480", Offset = "0x55DF280", VA = "0x1855E0480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct BIOOCFPKOGA : IAsyncStateMachine
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
		public IECBPDHLCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x55DF3E0", Offset = "0x55DE1E0", VA = "0x1855DF3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int EPCJANGHFIP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DateTime LIEMCKOMGKN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int MNIOMINCMKI = 3;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const long GFDIIMKBKIG = -1L;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const char MNIENLMAFMO = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GMPMLGIMDLO FCCLBDKFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PJICDOOCOHC PMELPPCFABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NJNNODCIDJD MPFFPJLAMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly DBEBDPCAEAB LEINDJIGMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FLPHKBJMCML JHOPMPCAHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly KNJLMONIPIE IGPHNJGAOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EIIMJHFPKEK PEDDOBLFJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly ICDGJDNIION OMPBKLEJOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly LOJMJBKDJBC EGKPOHPOBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IPDNOEOEBJF OEFIGJOENDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly PINOKNFGFNL NHHLKKLFMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly FONFBAKHLFC NLPPDLJDDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly PBGOFIPNIHI ENJGNAFGMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly PDNCCKMKMFH HLDBOKPBKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly ENCPAGENDDF JMMEFKEMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly global::LJOLNNMPFLC<KeepsakesConfig.KeepsakesOptions> IPBHLLDFLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly GEBHNHBDLKD LJGNPDJMFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> PEGFJKPCFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HashSet<Guid> KGKPPEGAHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HashSet<long> BNKONDKCPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private Dictionary<HKHJHFEFCAI, int> JMMAGEKLEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> AANAPMHHMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IDisposable GCNNBJLNBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Task KFFDDNLCHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private long? OKFPNKBNGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KeepsakeProgressionEventInstancesDTO EAFJACJCFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private global::ONJEHKCKOLK<KeepsakeProgressionEventInstancesDTO> GCIDDFHCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private IReadOnlyDictionary<HKHJHFEFCAI, KeepsakeCategoryConfigDTO> PHGJGMBMMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private KeepsakeGlobalConfigDTO GEKMKEHJEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HashSet<long> KCBIDDHGPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HashSet<long> LNAEIPMJMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private List<KeepsakeRoomListDTO> GDEFHBHDPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<KeepsakeRoomListDTO> FKLGBPIOJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<KeepsakeRoomListDTO> HFPFFNMHBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, string> IHODKBJDHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, string> KHDJKAIIMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<long, DateTime> NFEMPCLNGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<long, List<KeepsakeRoomDTO>> BBJFFFDOLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, List<KeepsakeRoomDTO>> JCPNEKKKBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, long> HJBGLJCFBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<string> CINEBGIJPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private DateTime NJCLEJBOAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly IDisposable ILPFPAHFEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<HKHJHFEFCAI, int> LEADCFLGBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Dictionary<HKHJHFEFCAI, int> KAFMJMDKNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private List<KeepsakeCategoryThemePair> DDDPGCCKEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private PBADNLJIOPB OCEDLHFAGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool OBNCEDAOOJP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FPKGHADBPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x893DC0", VA = "0x180894FC0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x944F40", Offset = "0x943D40", VA = "0x180944F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KDMOEMMNELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x55E1460", Offset = "0x55E0260", VA = "0x1855E1460", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GOLGAEKEECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x55E42D0", Offset = "0x55E30D0", VA = "0x1855E42D0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long PIPNOMHBFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x55E9890", Offset = "0x55E8690", VA = "0x1855E9890")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? CHHHCPGLFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55EC500", Offset = "0x55EB300", VA = "0x1855EC500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool GCOKEKDNDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x55E5390", Offset = "0x55E4190", VA = "0x1855E5390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GHGDIICICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x745A90", Offset = "0x744890", VA = "0x180745A90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> PNJADNEPMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x745AA0", Offset = "0x7448A0", VA = "0x180745AA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> CBPAHAJFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9512C0", Offset = "0x9500C0", VA = "0x1809512C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> JHLINAPBGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1143580", Offset = "0x1142380", VA = "0x181143580", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> LHPLEPJEEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x73BEB0", Offset = "0x73ACB0", VA = "0x18073BEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool BGFNBPOIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FC950", Offset = "0x8FB750", VA = "0x1808FC950")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55E9560", Offset = "0x55E8360", VA = "0x1855E9560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> KPOLGDEPLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x55EC710", Offset = "0x55EB510", VA = "0x1855EC710", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x55E4230", Offset = "0x55E3030", VA = "0x1855E4230", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EKNONNNPKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x55E6620", Offset = "0x55E5420", VA = "0x1855E6620", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55E1850", Offset = "0x55E0650", VA = "0x1855E1850", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MOGEGKKENML
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x55ECB10", Offset = "0x55EB910", VA = "0x1855ECB10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x55E2870", Offset = "0x55E1670", VA = "0x1855E2870", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x55ED590", Offset = "0x55EC390", VA = "0x1855ED590")]
	[Preserve]
	internal IECBPDHLCAC([NotNull][KIJADEHPJBH(null)] GMPMLGIMDLO FCCLBDKFINP, [NotNull][KIJADEHPJBH(null)] JPPFPFBLMCE FIFNGMHKNOB, [NotNull][KIJADEHPJBH(null)] PJICDOOCOHC PMELPPCFABI, [NotNull][KIJADEHPJBH(null)] NJNNODCIDJD MPFFPJLAMPM, [NotNull][KIJADEHPJBH(null)] DBEBDPCAEAB LEINDJIGMJD, [NotNull][KIJADEHPJBH(null)] FLPHKBJMCML JHOPMPCAHFP, [NotNull][KIJADEHPJBH(null)] KNJLMONIPIE IGPHNJGAOPI, [NotNull][KIJADEHPJBH(null)] EIIMJHFPKEK PEDDOBLFJLN, [NotNull][KIJADEHPJBH(null)] ICDGJDNIION OMPBKLEJOBH, [NotNull][KIJADEHPJBH(null)] HBNIHCBKEFL OFNOKLCOIBA, [NotNull][KIJADEHPJBH(null)] LOJMJBKDJBC EGKPOHPOBFA, [NotNull][KIJADEHPJBH(null)] IPDNOEOEBJF OEFIGJOENDD, [NotNull][KIJADEHPJBH(null)] PINOKNFGFNL NHHLKKLFMCD, [NotNull][KIJADEHPJBH(null)] FONFBAKHLFC NLPPDLJDDOI, [NotNull][KIJADEHPJBH(null)] PBGOFIPNIHI ENJGNAFGMBD, [NotNull][KIJADEHPJBH(null)] PDNCCKMKMFH HLDBOKPBKCE, [NotNull][KIJADEHPJBH(null)] ENCPAGENDDF JMMEFKEMNPB, [NotNull][KIJADEHPJBH(null)] global::LJOLNNMPFLC<KeepsakesConfig.KeepsakesOptions> IPBHLLDFLHP, [NotNull][KIJADEHPJBH(null)] GEBHNHBDLKD LJGNPDJMFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x55E6160", Offset = "0x55E4F60", VA = "0x1855E6160", Slot = "15")]
	public bool HKMDPLJLHLG(List<string> MCNNDLCJCOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x55EBFD0", Offset = "0x55EADD0", VA = "0x1855EBFD0", Slot = "16")]
	public global::ONJEHKCKOLK<Guid> OHENKAOKAJN(HKHJHFEFCAI AFNJJGDFFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x55E3E10", Offset = "0x55E2C10", VA = "0x1855E3E10", Slot = "17")]
	public LMAPELGHNPL ECPBNOKHEGO(Guid LOLLNBGLCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55E4FE0", Offset = "0x55E3DE0", VA = "0x1855E4FE0", Slot = "18")]
	public LMAPELGHNPL FKKDLGEMHOL(Guid LOLLNBGLCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55E40F0", Offset = "0x55E2EF0", VA = "0x1855E40F0", Slot = "19")]
	public bool EDEIAAEELDC(Guid LOLLNBGLCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x55E5C70", Offset = "0x55E4A70", VA = "0x1855E5C70", Slot = "20")]
	public bool GOKNDICAMDG(Guid LOLLNBGLCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x55E64E0", Offset = "0x55E52E0", VA = "0x1855E64E0")]
	public KeepsakeTheme HLPLCIJGEAL(Guid LOLLNBGLCPK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x55E22E0", Offset = "0x55E10E0", VA = "0x1855E22E0")]
	public bool CCAEJIOOHAL(HKHJHFEFCAI AFNJJGDFFOE, out KeepsakeTheme LGPGMPLPIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x55E46C0", Offset = "0x55E34C0", VA = "0x1855E46C0")]
	public List<KeepsakeTheme> EPKCOMGOHMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x55E4410", Offset = "0x55E3210", VA = "0x1855E4410")]
	public int EOIKGICCEAJ(HKHJHFEFCAI AFNJJGDFFOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x55ED420", Offset = "0x55EC220", VA = "0x1855ED420")]
	public HKHJHFEFCAI PJJCBPEEMOA(Guid LOLLNBGLCPK)
	{
		return default(HKHJHFEFCAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x55EBA80", Offset = "0x55EA880", VA = "0x1855EBA80", Slot = "34")]
	public List<HKHJHFEFCAI> NOEGBNBBKIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x55ED380", Offset = "0x55EC180", VA = "0x1855ED380", Slot = "35")]
	public IComparer<HKHJHFEFCAI> PIGFKDOGPCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x55E9970", Offset = "0x55E8770", VA = "0x1855E9970", Slot = "32")]
	public string KNAPGIILGAE(HKHJHFEFCAI AFNJJGDFFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x55E3840", Offset = "0x55E2640", VA = "0x1855E3840", Slot = "33")]
	public string DPOGOBKNJDL(HKHJHFEFCAI AFNJJGDFFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x55E7960", Offset = "0x55E6760", VA = "0x1855E7960", Slot = "21")]
	public bool JIEJLEKMMED(Guid LOLLNBGLCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x55E6AC0", Offset = "0x55E58C0", VA = "0x1855E6AC0", Slot = "22")]
	public void INMLPENILDA(Guid LOLLNBGLCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x55E58F0", Offset = "0x55E46F0", VA = "0x1855E58F0", Slot = "23")]
	public void GKMJKEOHDKC(HKHJHFEFCAI AFNJJGDFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x55ECBB0", Offset = "0x55EB9B0", VA = "0x1855ECBB0", Slot = "24")]
	public void PDNNKEJCKGO(HKHJHFEFCAI AFNJJGDFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x55E6FA0", Offset = "0x55E5DA0", VA = "0x1855E6FA0", Slot = "25")]
	public int JAEHJBNEPOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x55E6C90", Offset = "0x55E5A90", VA = "0x1855E6C90", Slot = "54")]
	public int JAEHJBNEPOP(HKHJHFEFCAI AFNJJGDFFOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x55E1B10", Offset = "0x55E0910", VA = "0x1855E1B10", Slot = "31")]
	public global::ONJEHKCKOLK<IEnumerable<Guid>> BDPBMCPAMNI(long JNEOKPAKAMP, long CBMNOMNPHCG, HKHJHFEFCAI? AFNJJGDFFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x55E5400", Offset = "0x55E4200", VA = "0x1855E5400", Slot = "30")]
	public global::ONJEHKCKOLK<IEnumerable<Guid>> GHEHBOIBODF(long JNEOKPAKAMP, long CBMNOMNPHCG, HKHJHFEFCAI? AFNJJGDFFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x55E3430", Offset = "0x55E2230", VA = "0x1855E3430", Slot = "55")]
	public global::ONJEHKCKOLK<Dictionary<Guid, HKHJHFEFCAI>> DPKHJMHGCDH(long JNEOKPAKAMP, long CBMNOMNPHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55EAC20", Offset = "0x55E9A20", VA = "0x1855EAC20", Slot = "56")]
	public global::ONJEHKCKOLK<Dictionary<Guid, HKHJHFEFCAI>> MDFNMNOPDKF(long JNEOKPAKAMP, long CBMNOMNPHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x55EBD20", Offset = "0x55EAB20", VA = "0x1855EBD20", Slot = "26")]
	public global::ONJEHKCKOLK<int> OEEOJJOOAKI(long JNEOKPAKAMP, long CBMNOMNPHCG, HKHJHFEFCAI? AFNJJGDFFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x55E4E10", Offset = "0x55E3C10", VA = "0x1855E4E10", Slot = "27")]
	public global::ONJEHKCKOLK<int> FHAJHHKJCEK(long JNEOKPAKAMP, long CBMNOMNPHCG, HKHJHFEFCAI? AFNJJGDFFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x55EA260", Offset = "0x55E9060", VA = "0x1855EA260", Slot = "28")]
	public global::ONJEHKCKOLK<Dictionary<HKHJHFEFCAI, int>> LLIOFEMFMIO(long JNEOKPAKAMP, long CBMNOMNPHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x55E5BA0", Offset = "0x55E49A0", VA = "0x1855E5BA0", Slot = "29")]
	public global::ONJEHKCKOLK<Dictionary<HKHJHFEFCAI, int>> GNJEGHKEMLI(long JNEOKPAKAMP, long CBMNOMNPHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x55EA9E0", Offset = "0x55E97E0", VA = "0x1855EA9E0", Slot = "37")]
	public bool MBFBMADKDJH(long JNEOKPAKAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x55E53A0", Offset = "0x55E41A0", VA = "0x1855E53A0", Slot = "57")]
	public bool GDBIKKOHMFH(long JNEOKPAKAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x55E6810", Offset = "0x55E5610", VA = "0x1855E6810", Slot = "38")]
	public bool IDIDJNGIFCC(long JNEOKPAKAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x55EA480", Offset = "0x55E9280", VA = "0x1855EA480", Slot = "58")]
	public bool LNIGBPPIJAF(long JNEOKPAKAMP, out IJFMCBCIMMO KBCKLKJGBEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x55E66C0", Offset = "0x55E54C0", VA = "0x1855E66C0", Slot = "39")]
	public bool HNBNBKMDNCH(long HCAEJPEDEBA, out DateTime HJACLKNFMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x55E9CE0", Offset = "0x55E8AE0", VA = "0x1855E9CE0", Slot = "40")]
	public long LEHKPDGGMNG(long HCAEJPEDEBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x55EB130", Offset = "0x55E9F30", VA = "0x1855EB130", Slot = "59")]
	public IEnumerable<int> MHOOKMNNIEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x55E69A0", Offset = "0x55E57A0", VA = "0x1855E69A0", Slot = "41")]
	public long ILEICPICPKM(long JNEOKPAKAMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x55E18F0", Offset = "0x55E06F0", VA = "0x1855E18F0", Slot = "42")]
	public int AOJHKCFNKKP(long HCAEJPEDEBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x55E2600", Offset = "0x55E1400", VA = "0x1855E2600", Slot = "43")]
	public bool CDDALLLAHEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x55E95D0", Offset = "0x55E83D0", VA = "0x1855E95D0", Slot = "44")]
	public bool KJNDBDODEDJ(long HCAEJPEDEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x55E9B00", Offset = "0x55E8900", VA = "0x1855E9B00", Slot = "45")]
	public IEnumerable<long> LCMKANBCCEH(long HCAEJPEDEBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x55ECD20", Offset = "0x55EBB20", VA = "0x1855ECD20", Slot = "46")]
	public int PGAFLBIBAAN(long HCAEJPEDEBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x55E5E20", Offset = "0x55E4C20", VA = "0x1855E5E20", Slot = "50")]
	public long HHOCNIAEOJC(long KAFNAJPEKNO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x55E55A0", Offset = "0x55E43A0", VA = "0x1855E55A0", Slot = "51")]
	public HKHJHFEFCAI GIIJHGFANAF()
	{
		return default(HKHJHFEFCAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x55EA120", Offset = "0x55E8F20", VA = "0x1855EA120")]
	private bool LJJGPEAAFPG(Guid LOLLNBGLCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x55EB380", Offset = "0x55EA180", VA = "0x1855EB380")]
	private void MIBHFKACLLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x55E4A10", Offset = "0x55E3810", VA = "0x1855E4A10")]
	private HKHJHFEFCAI FBAAPJIEACL()
	{
		return default(HKHJHFEFCAI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x55ECDD0", Offset = "0x55EBBD0", VA = "0x1855ECDD0")]
	private void PGLLNICDLEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x55E16A0", Offset = "0x55E04A0", VA = "0x1855E16A0")]
	private int AOEADCEANAC(KeepsakeRoomListDTO KBAKAJJGBIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x55E4D40", Offset = "0x55E3B40", VA = "0x1855E4D40")]
	private int FBHJJFAOJAN(DateTime KPBOJAACLJF, DateTime JBNMACJOBKC, TimeSpan JIKPNPKIDEF, int JLNHACABEAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x55E14B0", Offset = "0x55E02B0", VA = "0x1855E14B0")]
	private void AJPGFNENONM(IEnumerable<KeepsakeInstanceDTO> PEGFJKPCFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x55E2C50", Offset = "0x55E1A50", VA = "0x1855E2C50")]
	private void DKLHJEFOALN(IEnumerable<KeepsakeCollectionRecordDTO> INFBCDNDFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x55EC7B0", Offset = "0x55EB5B0", VA = "0x1855EC7B0")]
	private void OKPCAGIONHI(IEnumerable<long> OHGGLOAAAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7460D0", Offset = "0x744ED0", VA = "0x1807460D0")]
	private void OAFHEBAEKJL(KeepsakeGlobalConfigDTO GEKMKEHJEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x55E2910", Offset = "0x55E1710", VA = "0x1855E2910")]
	private bool DDHENGPHIMA(out Guid BCEIBOLEJCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x55EA0F0", Offset = "0x55E8EF0", VA = "0x1855EA0F0")]
	private void LGHGEMIHIIG(HKHJHFEFCAI HBJNOEGOHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x55E9250", Offset = "0x55E8050", VA = "0x1855E9250")]
	private void JNDLINCIPBM(HKHJHFEFCAI HBJNOEGOHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x55E5A50", Offset = "0x55E4850", VA = "0x1855E5A50")]
	private void GMDJMANDAML(Guid LOLLNBGLCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x55E2030", Offset = "0x55E0E30", VA = "0x1855E2030")]
	private void BLJEDMCJEKJ(HKHJHFEFCAI HBJNOEGOHMC, int MFICLFGJOCO, ref Dictionary<HKHJHFEFCAI, int> KCAMAFBEBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x55E9360", Offset = "0x55E8160", VA = "0x1855E9360")]
	private void KDKFCJAMCDJ(KeepsakeInstanceDTO IHJHFOMKNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x55E3230", Offset = "0x55E2030", VA = "0x1855E3230")]
	private void DPBNFPOEGNO(KeepsakeInstanceDTO IHJHFOMKNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x55E2E90", Offset = "0x55E1C90", VA = "0x1855E2E90")]
	private void DLFBKNHBOED(Guid LOLLNBGLCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x55E4F80", Offset = "0x55E3D80", VA = "0x1855E4F80")]
	private void FJAAGBLKEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x55E5370", Offset = "0x55E4170", VA = "0x1855E5370")]
	private void FPDKJOAIOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55E6470", Offset = "0x55E5270", VA = "0x1855E6470")]
	private void HLMNKDGJBME(OMCCBIFDHJH NGIHFNNEBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x55E6B90", Offset = "0x55E5990", VA = "0x1855E6B90")]
	private void IPHGGLJGFFL(EBLIJPPLEKA.PPGEOEPACHN BLIKPCIFNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x55E6B30", Offset = "0x55E5930", VA = "0x1855E6B30")]
	private void IOABAPOIPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x55E10A0", Offset = "0x55DFEA0", VA = "0x1855E10A0")]
	private void AADJBMPBCHD(float KCDNFIFGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x55E73F0", Offset = "0x55E61F0", VA = "0x1855E73F0")]
	private void JBDCDDCHANE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55EB820", Offset = "0x55EA620", VA = "0x1855EB820")]
	private bool MOBEPKEHCIA(Guid LOLLNBGLCPK, out string AGDMKGIHJEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x55E2110", Offset = "0x55E0F10", VA = "0x1855E2110")]
	private bool BOEONAIDNEP(Guid LOLLNBGLCPK, out KeepsakeCategoryConfigDTO HBJNOEGOHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x55E9280", Offset = "0x55E8080", VA = "0x1855E9280")]
	private void KAFELPCCCMD(string OOGEFLICJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55E1F20", Offset = "0x55E0D20", VA = "0x1855E1F20")]
	private bool BJIHFEGDKLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55EC810", Offset = "0x55EB610", VA = "0x1855EC810")]
	private IEnumerable<long> OOADNFMAPEJ(IEnumerable<KeepsakeRoomDTO> PAOFIFLFNGE, IEnumerable<KeepsakeRoomListDTO> IIOBEKLOBMJ, long HCAEJPEDEBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x55E8D20", Offset = "0x55E7B20", VA = "0x1855E8D20")]
	private bool JNCJNLCAAFA(Guid LOLLNBGLCPK, out string EDMHEICKIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x55E5DC0", Offset = "0x55E4BC0", VA = "0x1855E5DC0", Slot = "47")]
	public string HFJHGOJPPPF(JLKKPHGCGDF KOHGKHKIJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55E7B90", Offset = "0x55E6990", VA = "0x1855E7B90", Slot = "49")]
	public string JILGNFBDKBN(JLKKPHGCGDF KOHGKHKIJGI, long JNEOKPAKAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x55E5CA0", Offset = "0x55E4AA0", VA = "0x1855E5CA0", Slot = "48")]
	public string GPJAHPFFCGA(JLKKPHGCGDF KOHGKHKIJGI, int ILICGHCMOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x55E7FD0", Offset = "0x55E6DD0", VA = "0x1855E7FD0")]
	private void JMKIDLFPOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55E4580", Offset = "0x55E3380", VA = "0x1855E4580")]
	private void EOJKHEIJINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55E1AF0", Offset = "0x55E08F0", VA = "0x1855E1AF0")]
	private JLKKPHGCGDF BDJJECMFGGM(JEDPECJCFGP CPHGKIDPOCG)
	{
		return default(JLKKPHGCGDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55E9AE0", Offset = "0x55E88E0", VA = "0x1855E9AE0")]
	private JLKKPHGCGDF LBJILMDMFEH(JEDPECJCFGP CPHGKIDPOCG)
	{
		return default(JLKKPHGCGDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55EAA40", Offset = "0x55E9840", VA = "0x1855EAA40")]
	internal static string MCOLIBKIFOP(ONCNLEEOGBG NGBJBBKHPBH, string OELNECCAFHL, bool FNAEIJDELLN, int KINAMMGCDNC, int BAGCICGLNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55E39B0", Offset = "0x55E27B0", VA = "0x1855E39B0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55E4390", Offset = "0x55E3190", VA = "0x1855E4390")]
	private JFGMCGGLFKI ELHIBAPAOGG(CJKNNGNCCII IEBNIMCOCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55EA840", Offset = "0x55E9640", VA = "0x1855EA840")]
	private NNJLLEMIDDF LPOOIBBJCOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x55EADB0", Offset = "0x55E9BB0", VA = "0x1855EADB0")]
	private Task MGNHOPBMJMJ(FLICEPDFAIO GLNACLILDAP, CancellationToken ONFKFAAPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x55E24B0", Offset = "0x55E12B0", VA = "0x1855E24B0")]
	[AsyncStateMachine(typeof(GCJJGHBEHGN))]
	private Task CCNCOLALJCG(FLICEPDFAIO GLNACLILDAP, CancellationToken ONFKFAAPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x55E6BF0", Offset = "0x55E59F0", VA = "0x1855E6BF0")]
	private Task IPPOAEOJPDF(FLICEPDFAIO GLNACLILDAP, CancellationToken ONFKFAAPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x55EBBD0", Offset = "0x55EA9D0", VA = "0x1855EBBD0")]
	[AsyncStateMachine(typeof(BIOOCFPKOGA))]
	private Task OADAHNELEDH(string GNDOGDAIOKH, TimeSpan OLCFPKCDAPF, CancellationToken ONFKFAAPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x55E68B0", Offset = "0x55E56B0", VA = "0x1855E68B0")]
	[CompilerGenerated]
	private bool IKILIMJBFBB(KeepsakeInstanceDTO PAMKNJCGOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x55EC590", Offset = "0x55EB390", VA = "0x1855EC590")]
	[CompilerGenerated]
	private global::ONJEHKCKOLK<Dictionary<HKHJHFEFCAI, int>> OJCENOFHKCO(Dictionary<Guid, HKHJHFEFCAI> NAJGGIJHPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x55E26F0", Offset = "0x55E14F0", VA = "0x1855E26F0")]
	[CompilerGenerated]
	private global::ONJEHKCKOLK<Dictionary<HKHJHFEFCAI, int>> CHIJGMDAMFC(Dictionary<Guid, HKHJHFEFCAI> NAJGGIJHPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55ECAF0", Offset = "0x55EB8F0", VA = "0x1855ECAF0")]
	[CompilerGenerated]
	private bool PCKCJBCJNKI(KeepsakeRoomListDTO PAMKNJCGOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55E5930", Offset = "0x55E4730", VA = "0x1855E5930")]
	[CompilerGenerated]
	private void GLIFGOPAKLL(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<HKHJHFEFCAI, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> KHKFOKFHHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x55EBA20", Offset = "0x55EA820", VA = "0x1855EBA20")]
	[CompilerGenerated]
	private void NFNLNHICJIC(string EDMHEICKIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x55EC310", Offset = "0x55EB110", VA = "0x1855EC310")]
	[CompilerGenerated]
	private Task OHLPFNEOOPK(CancellationToken CNLOEIFPPML)
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
	public class KeepsakesConfig : ScriptableObject, global::LJOLNNMPFLC<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			[CompilerGenerated]
			private sealed class JLILLCGFMNI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
				public JLILLCGFMNI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x55EED10", Offset = "0x55EDB10", VA = "0x1855EED10")]
				internal bool <TryGetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x55EED10", Offset = "0x55EDB10", VA = "0x1855EED10")]
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
			[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] NHIGKHMMLCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x55EF490", Offset = "0x55EE290", VA = "0x1855EF490")]
			public bool IFHEBBFIFAC(string DANANDBCFIA, out KeepsakeTheme LGPGMPLPIAK)
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
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x55EF410", Offset = "0x55EE210", VA = "0x1855EF410")]
		[NPBDMCLHPNM(AIJEIIPHIJH.None)]
		private static void GLHKHMBBLAI(HKDBAIGILEN DHPFLPHCDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x79C840", Offset = "0x79B640", VA = "0x18079C840")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x55EEDE0", Offset = "0x55EDBE0", VA = "0x1855EEDE0")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x55EEEF0", Offset = "0x55EDCF0", VA = "0x1855EEEF0")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
