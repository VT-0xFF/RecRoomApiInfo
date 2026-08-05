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
public class EMNOGPMDAAI : IComparer<BLIIKHLKHJA>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CMMOFCLFKMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public BLIIKHLKHJA x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public BLIIKHLKHJA y;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public CMMOFCLFKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8A090", Offset = "0xA89290", VA = "0x180A8A090")]
		internal bool <Compare>b__0(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAABDE0", Offset = "0xAAAFE0", VA = "0x180AABDE0")]
		internal bool <Compare>b__1(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA8A090", Offset = "0xA89290", VA = "0x180A8A090")]
		internal bool <Compare>b__2(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAABDE0", Offset = "0xAAAFE0", VA = "0x180AABDE0")]
		internal bool <Compare>b__3(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> OIDKNGFLEGO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	public EMNOGPMDAAI(List<KeepsakeCategoryThemePair> IDGPFOHMMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5386DB0", Offset = "0x5385FB0", VA = "0x185386DB0", Slot = "4")]
	public int Compare(BLIIKHLKHJA FCCGDNMAHPA, BLIIKHLKHJA BADLFKONABM)
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
		public BLIIKHLKHJA KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BCEEECDCDFE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KALJIFHMJGE]
public class IOBLPOIAFLL : PNPHOOBLIIO, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CBJIMHFCKEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public const string DJGKBFGOPJM = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public const string JEAPKBOJKHL = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public const string MMFKLBFJJLP = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string ADBAIMGINEF = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string LDNABPHLEAP = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string ECHHJDLKMBM = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string LAPOECJLPPC = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string KAPAOGGCJDM = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string MFEOCFOPOGK = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string CLFLDLBLPED = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string AGICFMABPEP = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string CLCLEADGDDP = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string ECBEKJMDGBF = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OBMBFNMFFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public BLIIKHLKHJA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public OBMBFNMFFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5396BF0", Offset = "0x5395DF0", VA = "0x185396BF0")]
		internal void <CreateKeepsakeInstanceData>b__4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5396750", Offset = "0x5395950", VA = "0x185396750")]
		internal void <CreateKeepsakeInstanceData>b__2(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5396BC0", Offset = "0x5395DC0", VA = "0x185396BC0")]
		internal void <CreateKeepsakeInstanceData>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BFHBMKBGIBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int collectableKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public BFHBMKBGIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5385F20", Offset = "0x5385120", VA = "0x185385F20")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NHDOEBNJJAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NHDOEBNJJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5396720", Offset = "0x5395920", VA = "0x185396720")]
		internal bool <GetKeepsakeCategory>b__0(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AIPEFDDPGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public BLIIKHLKHJA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public AIPEFDDPGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5385570", Offset = "0x5384770", VA = "0x185385570")]
		internal bool <GetRemainingKeepsakeViewQuantityForCurrentRoom>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BDBGHLACFPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public BLIIKHLKHJA? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public BDBGHLACFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x53856A0", Offset = "0x53848A0", VA = "0x1853856A0")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5385730", Offset = "0x5384930", VA = "0x185385730")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5385760", Offset = "0x5384960", VA = "0x185385760")]
		internal global::NCOKFFGPIJM<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5385A70", Offset = "0x5384C70", VA = "0x185385A70")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PIEFKGBKHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BDBGHLACFPM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public PIEFKGBKHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x53970F0", Offset = "0x53962F0", VA = "0x1853970F0")]
		internal global::NCOKFFGPIJM<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LEGJBJCJONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PIEFKGBKHGM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public LEGJBJCJONB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5395C40", Offset = "0x5394E40", VA = "0x185395C40")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class FHNDLHIIECA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public LEGJBJCJONB CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public FHNDLHIIECA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5387050", Offset = "0x5386250", VA = "0x185387050")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__6(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GLDCBGJBDCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GLDCBGJBDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x53871D0", Offset = "0x53863D0", VA = "0x1853871D0")]
		internal global::NCOKFFGPIJM<IEnumerable<Guid>> <GetUncollectedKeepsakeInstanceIdsForRoom>b__0(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x31AD910", Offset = "0x31ACB10", VA = "0x1831AD910")]
		internal bool <GetUncollectedKeepsakeInstanceIdsForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BJOOJDODDGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public BJOOJDODDGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5386330", Offset = "0x5385530", VA = "0x185386330")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5385730", Offset = "0x5384930", VA = "0x185385730")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x53863C0", Offset = "0x53855C0", VA = "0x1853863C0")]
		internal global::NCOKFFGPIJM<Dictionary<Guid, BLIIKHLKHJA>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5385A70", Offset = "0x5384C70", VA = "0x185385A70")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DMKMPJALNGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public DMKMPJALNGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5386A10", Offset = "0x5385C10", VA = "0x185386A10")]
		internal global::NCOKFFGPIJM<Dictionary<Guid, BLIIKHLKHJA>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JEPKJCNFGJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public JEPKJCNFGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5395700", Offset = "0x5394900", VA = "0x185395700")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x53957F0", Offset = "0x53949F0", VA = "0x1853957F0")]
		internal KeyValuePair<Guid, BLIIKHLKHJA> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__6(Guid instanceId)
		{
			return default(KeyValuePair<Guid, BLIIKHLKHJA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CKOJCOKHHNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public CKOJCOKHHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5386970", Offset = "0x5385B70", VA = "0x185386970")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__7(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JKBBIBAHEBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public JKBBIBAHEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5395950", Offset = "0x5394B50", VA = "0x185395950")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__8(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CKDHEGLKIHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public CKDHEGLKIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5386750", Offset = "0x5385950", VA = "0x185386750")]
		internal global::NCOKFFGPIJM<Dictionary<Guid, BLIIKHLKHJA>> <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__0(Dictionary<Guid, BLIIKHLKHJA> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x31AD910", Offset = "0x31ACB10", VA = "0x1831AD910")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BKEJGODKCCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public BKEJGODKCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x53866D0", Offset = "0x53858D0", VA = "0x1853866D0")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__2(KeyValuePair<Guid, BLIIKHLKHJA> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PAHBBHPDPNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Dictionary<Guid, BLIIKHLKHJA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public PAHBBHPDPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5396EC0", Offset = "0x53960C0", VA = "0x185396EC0")]
		internal KeyValuePair<BLIIKHLKHJA, int> <GetUncollectedKeepsakeCountPerCategoryForRoom>b__1(BLIIKHLKHJA category)
		{
			return default(KeyValuePair<BLIIKHLKHJA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BMKGIGKFKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BLIIKHLKHJA category;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public BMKGIGKFKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xF42E50", Offset = "0xF42050", VA = "0x180F42E50")]
		internal bool <GetUncollectedKeepsakeCountPerCategoryForRoom>b__2(BLIIKHLKHJA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NGPHLDNNCBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Dictionary<Guid, BLIIKHLKHJA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NGPHLDNNCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x53965C0", Offset = "0x53957C0", VA = "0x1853965C0")]
		internal KeyValuePair<BLIIKHLKHJA, int> <GetTotalKeepsakeCountPerCategoryForRoom>b__1(BLIIKHLKHJA category)
		{
			return default(KeyValuePair<BLIIKHLKHJA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NCKGGLLEAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public BLIIKHLKHJA category;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NCKGGLLEAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xF42E50", Offset = "0xF42050", VA = "0x180F42E50")]
		internal bool <GetTotalKeepsakeCountPerCategoryForRoom>b__2(BLIIKHLKHJA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ELMIGBIJMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ELMIGBIJMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5386BE0", Offset = "0x5385DE0", VA = "0x185386BE0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5386CB0", Offset = "0x5385EB0", VA = "0x185386CB0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5386CB0", Offset = "0x5385EB0", VA = "0x185386CB0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KDHAFCLGPFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public KDHAFCLGPFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x98BDD0", Offset = "0x98AFD0", VA = "0x18098BDD0")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PEIFNNHHMON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public PEIFNNHHMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5397020", Offset = "0x5396220", VA = "0x185397020")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xC3DAA0", Offset = "0xC3CCA0", VA = "0x180C3DAA0")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NDOADPDDPEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NDOADPDDPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5395F20", Offset = "0x5395120", VA = "0x185395F20")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GLFHFAKONOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GLFHFAKONOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x98BDD0", Offset = "0x98AFD0", VA = "0x18098BDD0")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NCLKHPOEBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NCLKHPOEBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5395E90", Offset = "0x5395090", VA = "0x185395E90")]
		internal bool <IsKeepsakeInCurrentKeepsakeCategory>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FLAOGKJBLDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public BLIIKHLKHJA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public FLAOGKJBLDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xD2A070", Offset = "0xD29270", VA = "0x180D2A070")]
		internal bool <TryGetNextOrphanedKeepsakeInstanceFromCategory>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GICOPCFOAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GICOPCFOAIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5387140", Offset = "0x5386340", VA = "0x185387140")]
		internal bool <IncrementCollectedKeepsakeCount>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JDFOKNCALIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public BLIIKHLKHJA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public JDFOKNCALIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x53956C0", Offset = "0x53948C0", VA = "0x1853956C0")]
		internal bool <GetTotalCollectableKeepsakeCountForCategory>b__0(KeyValuePair<Guid, BLIIKHLKHJA> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HJGBJCCEJFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public BLIIKHLKHJA newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public HJGBJCCEJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xD2A070", Offset = "0xD29270", VA = "0x180D2A070")]
		internal bool <OnKeepsakeCollected>b__0(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MCNKECGOKAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public MCNKECGOKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5395D70", Offset = "0x5394F70", VA = "0x185395D70")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OOPEOMMGKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public OOPEOMMGKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5396DD0", Offset = "0x5395FD0", VA = "0x185396DD0")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MFHLCPPIFLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public OOPEOMMGKHA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public MFHLCPPIFLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5395E10", Offset = "0x5395010", VA = "0x185395E10")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct BEBFNNFLFOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AHDBIFJNDCH args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5385A90", Offset = "0x5384C90", VA = "0x185385A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct ILNMDEKFLFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IOBLPOIAFLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x53873A0", Offset = "0x53865A0", VA = "0x1853873A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int ENOLPDGPDEB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DateTime HCGEAEBHHFG;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int LFLBBHGOEGH = 3;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const long IOLILHJHJAF = -1L;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const char LNEIAFFDMJI = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KCHEHPJJMCP MBOHNPDIBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DFEJFJAJNJD INLOBJELIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HMIOFOAEOGC JCHOMCBJHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EAOCHKEGDFJ BBHMAAACAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HLNFDOBEGJO CHABDOLEEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly DIDFJMILKDE GLDINECADEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly LKFJJHJMFIB ADGPGMPOPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly JLJEJNFJIDP GCOGGHDIHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly MLCEGEIFEAK AJFLAGMMAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LEKCDGHNMIN FEHIADHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly DHAAAAKAFFD FDEMKJAIGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly FBDMPCDHLHH LDNDJAMEJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly AKOBIAIKOGE JPELKODFIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly IMLDFNOCMHL FNMIGFKCOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly KKMCCLAPGLL CCONPAMBIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly global::PKNHDECOJNJ<KeepsakesConfig.KeepsakesOptions> DMMDPMFCBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IILDCCEMGBA LCPOIILBNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> NFFKPDHGBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HashSet<Guid> DKHIALNHHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HashSet<long> EPPNFGNDNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private Dictionary<BLIIKHLKHJA, int> DKKKCBLLIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> CEGDCAJGENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IDisposable CNAGCKBFLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Task GJLDDCHCPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private global::NCOKFFGPIJM<Guid> EIIKHPLMJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private long? KPNGPKBIHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KeepsakeProgressionEventInstancesDTO OHFCPKGDGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private global::NCOKFFGPIJM<KeepsakeProgressionEventInstancesDTO> JEHDCACNAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private IReadOnlyDictionary<BLIIKHLKHJA, KeepsakeCategoryConfigDTO> PMFPJEMHIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeGlobalConfigDTO PLJPBBPNGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HashSet<long> KJDKMIGKGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HashSet<long> CGJEDOLEPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<KeepsakeRoomListDTO> KCLPPDADDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<KeepsakeRoomListDTO> AGJDDIOGCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<KeepsakeRoomListDTO> EBFDLHOGAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, string> GOPHNPHKAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<long, string> KJDKJKKDHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<long, DateTime> GGMPHOAFCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DMLODADHHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NMHMKEJMCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, long> LAGMKAAICIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<string> PCJLLGOAOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private DateTime LPHNPBOJOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IDisposable AOMHLINFADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Dictionary<Guid, BLIIKHLKHJA> COAKODADFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<BLIIKHLKHJA, int> CPLCIAPDDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private List<KeepsakeCategoryThemePair> IDGPFOHMMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EMNOGPMDAAI LIHHMHIJANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool OAKDEOFPNMC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ONAOMEHOJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x96D880", Offset = "0x96CA80", VA = "0x18096D880", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xEDA1C0", Offset = "0xED93C0", VA = "0x180EDA1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DFFOMBMEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5389450", Offset = "0x5388650", VA = "0x185389450", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DGNAEBELOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5392540", Offset = "0x5391740", VA = "0x185392540", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long HBODJBBGFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x538F400", Offset = "0x538E600", VA = "0x18538F400")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? IIGGAOALPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x538B930", Offset = "0x538AB30", VA = "0x18538B930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PPBHFCMJAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x538B510", Offset = "0x538A710", VA = "0x18538B510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GKCMGGBGENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA1DEC0", Offset = "0xA1D0C0", VA = "0x180A1DEC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> KJGJAMJEIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x953D90", Offset = "0x952F90", VA = "0x180953D90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> FFIECCBBCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90B6C0", Offset = "0x90A8C0", VA = "0x18090B6C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DJCIKMBCPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84F780", Offset = "0x84E980", VA = "0x18084F780", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> FNCEFPJBNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x90C560", Offset = "0x90B760", VA = "0x18090C560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool HDEKKPPEOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xF80AB0", Offset = "0xF7FCB0", VA = "0x180F80AB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x538BDC0", Offset = "0x538AFC0", VA = "0x18538BDC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> FFIFGEINEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x538BFE0", Offset = "0x538B1E0", VA = "0x18538BFE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x538A700", Offset = "0x5389900", VA = "0x18538A700", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PDKDOEAPELG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5389C20", Offset = "0x5388E20", VA = "0x185389C20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5388070", Offset = "0x5387270", VA = "0x185388070", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action FGNOCNGNJII
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5391470", Offset = "0x5390670", VA = "0x185391470", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5392DB0", Offset = "0x5391FB0", VA = "0x185392DB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5394420", Offset = "0x5393620", VA = "0x185394420")]
	[Preserve]
	internal IOBLPOIAFLL([NotNull][CDOANEBODFP(null)] KCHEHPJJMCP MBOHNPDIBAA, [NotNull][CDOANEBODFP(null)] INBDIKIJLGF GBIFNANKKKC, [NotNull][CDOANEBODFP(null)] DFEJFJAJNJD INLOBJELIKI, [NotNull][CDOANEBODFP(null)] HMIOFOAEOGC JCHOMCBJHPI, [NotNull][CDOANEBODFP(null)] EAOCHKEGDFJ BBHMAAACAIO, [NotNull][CDOANEBODFP(null)] HLNFDOBEGJO CHABDOLEEMD, [NotNull][CDOANEBODFP(null)] DIDFJMILKDE GLDINECADEF, [NotNull][CDOANEBODFP(null)] LKFJJHJMFIB ADGPGMPOPNJ, [NotNull][CDOANEBODFP(null)] JLJEJNFJIDP GCOGGHDIHNM, [NotNull][CDOANEBODFP(null)] BEPJOMOOILO DFBAOKDCPII, [NotNull][CDOANEBODFP(null)] MLCEGEIFEAK AJFLAGMMAIL, [NotNull][CDOANEBODFP(null)] LEKCDGHNMIN FEHIADHNJDC, [NotNull][CDOANEBODFP(null)] DHAAAAKAFFD FDEMKJAIGKN, [NotNull][CDOANEBODFP(null)] FBDMPCDHLHH LDNDJAMEJDG, [NotNull][CDOANEBODFP(null)] AKOBIAIKOGE JPELKODFIJO, [NotNull][CDOANEBODFP(null)] IMLDFNOCMHL FNMIGFKCOMI, [NotNull][CDOANEBODFP(null)] KKMCCLAPGLL CCONPAMBIDE, [NotNull][CDOANEBODFP(null)] global::PKNHDECOJNJ<KeepsakesConfig.KeepsakesOptions> DMMDPMFCBHN, [NotNull][CDOANEBODFP(null)] IILDCCEMGBA LCPOIILBNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5391070", Offset = "0x5390270", VA = "0x185391070", Slot = "15")]
	public bool LNMKIDAFHJA(List<string> MBEJMLAKMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5388110", Offset = "0x5387310", VA = "0x185388110", Slot = "16")]
	public global::NCOKFFGPIJM<Guid> BKLNJCHFIJJ(BLIIKHLKHJA OHMIKIIHJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x538A9C0", Offset = "0x5389BC0", VA = "0x18538A9C0", Slot = "17")]
	public LAHBDKNMNHN FLHEAAKAMHG(Guid OPOMJNNALCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x538DFA0", Offset = "0x538D1A0", VA = "0x18538DFA0", Slot = "18")]
	public LAHBDKNMNHN JPKANOHJKCI(Guid OPOMJNNALCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5389CC0", Offset = "0x5388EC0", VA = "0x185389CC0", Slot = "19")]
	public bool EMHFDHCBPPK(Guid OPOMJNNALCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5388A10", Offset = "0x5387C10", VA = "0x185388A10", Slot = "20")]
	public bool CFHMCFCKIAP(Guid OPOMJNNALCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5393DC0", Offset = "0x5392FC0", VA = "0x185393DC0")]
	public KeepsakeTheme PLEMIPEPCOP(Guid OPOMJNNALCB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5387EA0", Offset = "0x53870A0", VA = "0x185387EA0")]
	public bool BJDNEPMBEOL(BLIIKHLKHJA OHMIKIIHJHM, out KeepsakeTheme CCOGABOGPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x538AD40", Offset = "0x5389F40", VA = "0x18538AD40")]
	public List<KeepsakeTheme> FOBNNADNICC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x538B290", Offset = "0x538A490", VA = "0x18538B290")]
	public int GDNMCOAKBNH(BLIIKHLKHJA OHMIKIIHJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5388FA0", Offset = "0x53881A0", VA = "0x185388FA0")]
	public BLIIKHLKHJA CJFLFLJLCNF(Guid OPOMJNNALCB)
	{
		return default(BLIIKHLKHJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5387920", Offset = "0x5386B20", VA = "0x185387920", Slot = "34")]
	public List<BLIIKHLKHJA> BALGPFBEEIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5394100", Offset = "0x5393300", VA = "0x185394100", Slot = "35")]
	public IComparer<BLIIKHLKHJA> PNHDOKHIAFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5393160", Offset = "0x5392360", VA = "0x185393160", Slot = "32")]
	public string OMDDGFJEEPB(BLIIKHLKHJA OHMIKIIHJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x53894A0", Offset = "0x53886A0", VA = "0x1853894A0", Slot = "33")]
	public string DMBEFPCCCBN(BLIIKHLKHJA OHMIKIIHJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x538EF90", Offset = "0x538E190", VA = "0x18538EF90", Slot = "21")]
	public bool KNMONBDOMMM(Guid OPOMJNNALCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5387810", Offset = "0x5386A10", VA = "0x185387810", Slot = "22")]
	public void AJKMOFACEBL(Guid OPOMJNNALCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5389410", Offset = "0x5388610", VA = "0x185389410", Slot = "23")]
	public void DIKMNJCBMFG(BLIIKHLKHJA OHMIKIIHJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5387C60", Offset = "0x5386E60", VA = "0x185387C60", Slot = "24")]
	public void BHJANLAJIFK(Guid OPOMJNNALCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5390280", Offset = "0x538F480", VA = "0x185390280", Slot = "25")]
	public int LILOCOJIMHD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x538FF70", Offset = "0x538F170", VA = "0x18538FF70", Slot = "54")]
	public int LILOCOJIMHD(BLIIKHLKHJA OHMIKIIHJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x53920D0", Offset = "0x53912D0", VA = "0x1853920D0", Slot = "31")]
	public global::NCOKFFGPIJM<IEnumerable<Guid>> MMIDENPAFBI(long EPOBIFCHLNM, long LEBNGAGIGPK, BLIIKHLKHJA? OHMIKIIHJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5393930", Offset = "0x5392B30", VA = "0x185393930", Slot = "30")]
	public global::NCOKFFGPIJM<IEnumerable<Guid>> PFIHCJMAION(long EPOBIFCHLNM, long LEBNGAGIGPK, BLIIKHLKHJA? OHMIKIIHJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5391AC0", Offset = "0x5390CC0", VA = "0x185391AC0", Slot = "55")]
	public global::NCOKFFGPIJM<Dictionary<Guid, BLIIKHLKHJA>> MELKBMAMILA(long EPOBIFCHLNM, long LEBNGAGIGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5394290", Offset = "0x5393490", VA = "0x185394290", Slot = "56")]
	public global::NCOKFFGPIJM<Dictionary<Guid, BLIIKHLKHJA>> PNLCEJILEDM(long EPOBIFCHLNM, long LEBNGAGIGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5389E00", Offset = "0x5389000", VA = "0x185389E00", Slot = "26")]
	public global::NCOKFFGPIJM<int> EOGJPEFONHH(long EPOBIFCHLNM, long LEBNGAGIGPK, BLIIKHLKHJA? OHMIKIIHJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x53932D0", Offset = "0x53924D0", VA = "0x1853932D0", Slot = "27")]
	public global::NCOKFFGPIJM<int> OOMELNGPMEF(long EPOBIFCHLNM, long LEBNGAGIGPK, BLIIKHLKHJA? OHMIKIIHJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5392600", Offset = "0x5391800", VA = "0x185392600", Slot = "28")]
	public global::NCOKFFGPIJM<Dictionary<BLIIKHLKHJA, int>> NHGFFAABEBH(long EPOBIFCHLNM, long LEBNGAGIGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x538A5D0", Offset = "0x53897D0", VA = "0x18538A5D0", Slot = "29")]
	public global::NCOKFFGPIJM<Dictionary<BLIIKHLKHJA, int>> FEIEMEMNAJD(long EPOBIFCHLNM, long LEBNGAGIGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x53875E0", Offset = "0x53867E0", VA = "0x1853875E0", Slot = "37")]
	public bool AGDHEECNLOK(long EPOBIFCHLNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5393100", Offset = "0x5392300", VA = "0x185393100", Slot = "57")]
	public bool OIOFOBKLPNL(long EPOBIFCHLNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5393870", Offset = "0x5392A70", VA = "0x185393870", Slot = "38")]
	public bool PCMFJGPGNBI(long EPOBIFCHLNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x538C130", Offset = "0x538B330", VA = "0x18538C130", Slot = "58")]
	public bool IANPFOGKBMO(long EPOBIFCHLNM, out NINFCDHKBDN LNFDOHAMKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5389AD0", Offset = "0x5388CD0", VA = "0x185389AD0", Slot = "39")]
	public bool EEPMNEBONOK(long HJPNFJHJPBE, out DateTime GCNAILOLDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5393460", Offset = "0x5392660", VA = "0x185393460", Slot = "40")]
	public long PBJMMLDFEMM(long HJPNFJHJPBE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x538B520", Offset = "0x538A720", VA = "0x18538B520", Slot = "59")]
	public IEnumerable<int> HDOCNKJBBNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5393FE0", Offset = "0x53931E0", VA = "0x185393FE0", Slot = "41")]
	public long PNDKKOHCKEO(long EPOBIFCHLNM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x538CC60", Offset = "0x538BE60", VA = "0x18538CC60", Slot = "42")]
	public int ILEOOPNAJMI(long HJPNFJHJPBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x53941A0", Offset = "0x53933A0", VA = "0x1853941A0", Slot = "43")]
	public bool PNKOOLDFAJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5388750", Offset = "0x5387950", VA = "0x185388750", Slot = "44")]
	public bool CDFPCOEGAGN(long HJPNFJHJPBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5389110", Offset = "0x5388310", VA = "0x185389110", Slot = "45")]
	public IEnumerable<long> COFIHCKBOJH(long HJPNFJHJPBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5392ED0", Offset = "0x53920D0", VA = "0x185392ED0", Slot = "46")]
	public int ODOEOBELDFA(long HJPNFJHJPBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x538EC50", Offset = "0x538DE50", VA = "0x18538EC50", Slot = "50")]
	public long KJJEKIIMNFF(long FAKOICJDABG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x538F4E0", Offset = "0x538E6E0", VA = "0x18538F4E0", Slot = "51")]
	public BLIIKHLKHJA LCPLAEBPOAL()
	{
		return default(BLIIKHLKHJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x538DD80", Offset = "0x538CF80", VA = "0x18538DD80")]
	private bool JLIAEJDILOA(Guid OPOMJNNALCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x538FAD0", Offset = "0x538ECD0", VA = "0x18538FAD0")]
	private void LFPGAKMKEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5393AD0", Offset = "0x5392CD0", VA = "0x185393AD0")]
	private BLIIKHLKHJA PFKNBIHJEHC()
	{
		return default(BLIIKHLKHJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5391510", Offset = "0x5390710", VA = "0x185391510")]
	private void MDJDFOGPDFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x538BE30", Offset = "0x538B030", VA = "0x18538BE30")]
	private int HMHNKDJLGMC(KeepsakeRoomListDTO DCCFCJLPMMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5387B90", Offset = "0x5386D90", VA = "0x185387B90")]
	private int BHFFMJFIEJE(DateTime MPNJPPHOIHC, DateTime CLHJFJPJJOP, TimeSpan JDGGDDBBOFM, int FHGLNEBKJMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x538DBB0", Offset = "0x538CDB0", VA = "0x18538DBB0")]
	private void JHDEMMGNKFG(IEnumerable<KeepsakeInstanceDTO> NFFKPDHGBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x538A390", Offset = "0x5389590", VA = "0x18538A390")]
	private void FDDEDONEFAC(IEnumerable<KeepsakeCollectionRecordDTO> BHIDEPCMEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5389A70", Offset = "0x5388C70", VA = "0x185389A70")]
	private void ECHFNBGKHPK(IEnumerable<long> BHHFFFAHFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xE3ADA0", Offset = "0xE39FA0", VA = "0x180E3ADA0")]
	private void KAKCNIICAIO(KeepsakeGlobalConfigDTO PLJPBBPNGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x538BB10", Offset = "0x538AD10", VA = "0x18538BB10")]
	private bool HJONDFBPOJF(BLIIKHLKHJA OHMIKIIHJHM, out Guid DOBHAAFBCMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5388A40", Offset = "0x5387C40", VA = "0x185388A40")]
	private bool CFMGBEOOGOO(out Guid DOBHAAFBCMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x538A6A0", Offset = "0x53898A0", VA = "0x18538A6A0")]
	private bool FEJBBGLBJAG(Guid OPOMJNNALCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x538E9A0", Offset = "0x538DBA0", VA = "0x18538E9A0")]
	private IEnumerable<Guid> KFGHLDNMLIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x538F820", Offset = "0x538EA20", VA = "0x18538F820")]
	private IEnumerable<KeepsakeInstanceDTO> LDCPFNPBNGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5390FE0", Offset = "0x53901E0", VA = "0x185390FE0")]
	private void LNIDINDHPPL(Guid OPOMJNNALCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x538C080", Offset = "0x538B280", VA = "0x18538C080")]
	private bool HPBLILCKBPA(Guid OPOMJNNALCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5392C60", Offset = "0x5391E60", VA = "0x185392C60")]
	private void NLDKAFBALHM(Guid OPOMJNNALCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x538DEC0", Offset = "0x538D0C0", VA = "0x18538DEC0")]
	private void JLNFPDGMLCG(BLIIKHLKHJA JNKJFJLJKNJ, int BECMELKBGCA, ref Dictionary<BLIIKHLKHJA, int> DBBMHCDKNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x538AC40", Offset = "0x5389E40", VA = "0x18538AC40")]
	private int FMMAGABDOCH(BLIIKHLKHJA OHMIKIIHJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x538B770", Offset = "0x538A970", VA = "0x18538B770")]
	private void HEGKIEEEJNA(KeepsakeInstanceDTO PECPOAIMHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5391ED0", Offset = "0x53910D0", VA = "0x185391ED0")]
	private void MHGLKKMBIDB(KeepsakeInstanceDTO PECPOAIMHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5390C40", Offset = "0x538FE40", VA = "0x185390C40")]
	private void LNBKENENOHL(Guid OPOMJNNALCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x53924E0", Offset = "0x53916E0", VA = "0x1853924E0")]
	private void NAFFFKBLBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x538CC40", Offset = "0x538BE40", VA = "0x18538CC40")]
	private void IKFONPAHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5393090", Offset = "0x5392290", VA = "0x185393090")]
	private void OINHCBILFMK(GBAJDOHJDHJ HFEKGOLNKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5388D00", Offset = "0x5387F00", VA = "0x185388D00")]
	private void CGNPKFADIMA(EDDPDJCKOBH.HJIJLBBPCKC ICHBECDKHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5388F40", Offset = "0x5388140", VA = "0x185388F40")]
	private void CINIANPGDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x538C4F0", Offset = "0x538B6F0", VA = "0x18538C4F0")]
	private void ICIPBBENMCL(float HOHFHDNPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x53906D0", Offset = "0x538F8D0", VA = "0x1853906D0")]
	private void LJJKGFFJJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x538B090", Offset = "0x538A290", VA = "0x18538B090")]
	private bool FPKCPKAGGOM(Guid OPOMJNNALCB, out string LLOOAANCENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x538F230", Offset = "0x538E430", VA = "0x18538F230")]
	private bool KNPJGJKCPDH(Guid OPOMJNNALCB, out KeepsakeCategoryConfigDTO JNKJFJLJKNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5393F00", Offset = "0x5393100", VA = "0x185393F00")]
	private void PNCIBOMNHKO(string HLIGBKANEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5392F80", Offset = "0x5392180", VA = "0x185392F80")]
	private bool OEMBNEIIMNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x538A0B0", Offset = "0x53892B0", VA = "0x18538A0B0")]
	private IEnumerable<long> EOGPELDDANH(IEnumerable<KeepsakeRoomDTO> CCPNCEDJDGD, IEnumerable<KeepsakeRoomListDTO> NGFEBJIIMBM, long HJPNFJHJPBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x538E330", Offset = "0x538D530", VA = "0x18538E330")]
	private bool KAFANCAGGJM(Guid OPOMJNNALCB, out string NLJOHEKGNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x538F8F0", Offset = "0x538EAF0", VA = "0x18538F8F0", Slot = "47")]
	public string LDMPODLLBHN(IOEIFEGHMIF NMADGLNNHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5392820", Offset = "0x5391A20", VA = "0x185392820", Slot = "49")]
	public string NKAAKNCBICG(IOEIFEGHMIF NMADGLNNHNM, long EPOBIFCHLNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x53892F0", Offset = "0x53884F0", VA = "0x1853892F0", Slot = "48")]
	public string DAGPMIELEBO(IOEIFEGHMIF NMADGLNNHNM, int ADDEMMFIBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x538CE60", Offset = "0x538C060", VA = "0x18538CE60")]
	private void JCABCIODLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x538E860", Offset = "0x538DA60", VA = "0x18538E860")]
	private void KBOKOLOLGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5393440", Offset = "0x5392640", VA = "0x185393440")]
	private IOEIFEGHMIF OPKIBFEIHEI(KPEEPMGPOIB MDHEBLFDPKP)
	{
		return default(IOEIFEGHMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5392E50", Offset = "0x5392050", VA = "0x185392E50")]
	private IOEIFEGHMIF NPAKMEPDCFP(KPEEPMGPOIB MDHEBLFDPKP)
	{
		return default(IOEIFEGHMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5388D60", Offset = "0x5387F60", VA = "0x185388D60")]
	internal static string CHBJJJCGCDL(CCELLEEKDMJ MLDANHIGANI, string MHJMMFCPNGA, bool JFKOGIJMMCP, int BBKEAJNBCOL, int PMEKPPDOHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5389610", Offset = "0x5388810", VA = "0x185389610", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x538A940", Offset = "0x5389B40", VA = "0x18538A940")]
	private BCDAPDDMMEO FJMEMEIPMAH(JDCIJIEOFOL AHOJELKGDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x538A7A0", Offset = "0x53899A0", VA = "0x18538A7A0")]
	private ILODPOPFPAH FFBDGACNKHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x538C8B0", Offset = "0x538BAB0", VA = "0x18538C8B0")]
	private Task IEJAMDPGOPB(AHDBIFJNDCH ADCFFAJGNAM, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x538EB00", Offset = "0x538DD00", VA = "0x18538EB00")]
	[AsyncStateMachine(typeof(BEBFNNFLFOC))]
	private Task KGJJEBLMAFF(AHDBIFJNDCH ADCFFAJGNAM, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5387880", Offset = "0x5386A80", VA = "0x185387880")]
	private Task ALJFMIDGDDB(AHDBIFJNDCH ADCFFAJGNAM, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x538B9C0", Offset = "0x538ABC0", VA = "0x18538B9C0")]
	[AsyncStateMachine(typeof(ILNMDEKFLFM))]
	private Task HIHAGMJFKMN(string OFCFPGACNJB, TimeSpan FHFDDKOBFLG, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4166D40", Offset = "0x4165F40", VA = "0x184166D40")]
	[CompilerGenerated]
	private void GNJMHKHCJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x53877C0", Offset = "0x53869C0", VA = "0x1853877C0")]
	[CompilerGenerated]
	private void AHGBBCCOPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5391380", Offset = "0x5390580", VA = "0x185391380")]
	[CompilerGenerated]
	private bool MCDHFKEDGIJ(KeepsakeInstanceDTO FCCGDNMAHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x538F950", Offset = "0x538EB50", VA = "0x18538F950")]
	[CompilerGenerated]
	private global::NCOKFFGPIJM<Dictionary<BLIIKHLKHJA, int>> LEGJDAGEPCF(Dictionary<Guid, BLIIKHLKHJA> KFPFJLNAGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5387640", Offset = "0x5386840", VA = "0x185387640")]
	[CompilerGenerated]
	private global::NCOKFFGPIJM<Dictionary<BLIIKHLKHJA, int>> AHBOJOMLILH(Dictionary<Guid, BLIIKHLKHJA> KFPFJLNAGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5393910", Offset = "0x5392B10", VA = "0x185393910")]
	[CompilerGenerated]
	private bool PEHCFDMCALG(KeepsakeRoomListDTO FCCGDNMAHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x538B400", Offset = "0x538A600", VA = "0x18538B400")]
	[CompilerGenerated]
	private bool GKBIBBGNINI(KeepsakeInstanceDTO FCCGDNMAHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5387A70", Offset = "0x5386C70", VA = "0x185387A70")]
	[CompilerGenerated]
	private void BEJDIMINMOD(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<BLIIKHLKHJA, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> ILJGHKGMILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5392E70", Offset = "0x5392070", VA = "0x185392E70")]
	[CompilerGenerated]
	private void NPHADKIKCJA(string NLJOHEKGNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5388B10", Offset = "0x5387D10", VA = "0x185388B10")]
	[CompilerGenerated]
	private Task CFOIFMODFFC(CancellationToken CODLNEMGOKB)
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
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float LoopingSfxVolume;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KeepsakesConfig : ScriptableObject, global::PKNHDECOJNJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			[CompilerGenerated]
			private sealed class HNMIEBLLMNC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
				public HNMIEBLLMNC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x5387370", Offset = "0x5386570", VA = "0x185387370")]
				internal bool <TryGetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x5387370", Offset = "0x5386570", VA = "0x185387370")]
				internal bool <TryGetKeepsakeTheme>b__1(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] JILLCJNFOKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5395A70", Offset = "0x5394C70", VA = "0x185395A70")]
			public bool KJGBABEAKMB(string JNJJAGBFLFH, out KeepsakeTheme CCOGABOGPGD)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x53959F0", Offset = "0x5394BF0", VA = "0x1853959F0")]
		[IOFOCEAPGPD(NPBJMIOJGOK.None)]
		private static void KNLLJPMDCJC(MNALHHOLFGL FMPHDMAKDKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F9FF0", Offset = "0x6F91F0", VA = "0x1806F9FF0")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5395F90", Offset = "0x5395190", VA = "0x185395F90")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x53960A0", Offset = "0x53952A0", VA = "0x1853960A0")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
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

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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
