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
using RecNet;
using RecRoom.DataLayer.Attributes;
using RecRoom.Keepsakes;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.AddressableAssets;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Keepsakes_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BA60E0", Offset = "0x6BA46E0", VA = "0x186BA60E0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FJALFLGAPDB : IComparer<DGKKLHHODBM>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class EGLAHMANHLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DGKKLHHODBM x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public DGKKLHHODBM y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public EGLAHMANHLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x11190A0", Offset = "0x11176A0", VA = "0x1811190A0")]
		internal bool KPMCBAHCOAF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1554D10", Offset = "0x1553310", VA = "0x181554D10")]
		internal bool IHDFAKOHFPF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x11190A0", Offset = "0x11176A0", VA = "0x1811190A0")]
		internal bool GMHMGNEMCPA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1554D10", Offset = "0x1553310", VA = "0x181554D10")]
		internal bool GIDCLNLKBOA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> FCIDBNELGOP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public FJALFLGAPDB(List<KeepsakeCategoryThemePair> MGKGNNGFCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B963D0", Offset = "0x6B949D0", VA = "0x186B963D0", Slot = "4")]
	public int Compare(DGKKLHHODBM NCPIGLMANIM, DGKKLHHODBM DJBPOPBDKAJ)
	{
		return default(int);
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public DGKKLHHODBM KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHFFCNPJGMC]
public class FLKACAKFJDI : KOEENFFKAEH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GEFCFCLNGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public FLKACAKFJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public DGKKLHHODBM keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GEFCFCLNGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4890", Offset = "0x6BA2E90", VA = "0x186BA4890")]
		internal JAGIEECCCMP<Guid> DLNANOKDACH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4A20", Offset = "0x6BA3020", VA = "0x186BA4A20")]
		internal void NAKLOPBGCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4830", Offset = "0x6BA2E30", VA = "0x186BA4830")]
		internal void DKJAGAFLPNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4A50", Offset = "0x6BA3050", VA = "0x186BA4A50")]
		internal void NIMINCKNIOJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6BA49F0", Offset = "0x6BA2FF0", VA = "0x186BA49F0")]
		internal void GGBDCJAMFBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ENIJDPPLIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public FLKACAKFJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int collectableKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ENIJDPPLIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6B959D0", Offset = "0x6B93FD0", VA = "0x186B959D0")]
		internal void HIFJOKOCBEC(MACJAHHJDBB response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6B95D80", Offset = "0x6B94380", VA = "0x186B95D80")]
		internal void JHLHHLCDGKJ(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OBJHMLHPMJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public OBJHMLHPMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5DB0", Offset = "0x6BA43B0", VA = "0x186BA5DB0")]
		internal bool NINBJADGDKE(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BOBMOFNPBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FLKACAKFJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public DGKKLHHODBM? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public BOBMOFNPBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6B94F80", Offset = "0x6B93580", VA = "0x186B94F80")]
		internal void JLPEMPHFLIG(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6B94F50", Offset = "0x6B93550", VA = "0x186B94F50")]
		internal void AMIJPEOOHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6B95010", Offset = "0x6B93610", VA = "0x186B95010")]
		internal JAGIEECCCMP<IEnumerable<Guid>> PFKEIMAEAAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x681DB70", Offset = "0x681C170", VA = "0x18681DB70")]
		internal bool JEBBLOFPCKM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EDNAEJADICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BOBMOFNPBDA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public EDNAEJADICP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6B955B0", Offset = "0x6B93BB0", VA = "0x186B955B0")]
		internal JAGIEECCCMP<IEnumerable<Guid>> KAENMHGHBGF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LFANLDCHDLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public EDNAEJADICP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public LFANLDCHDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6BA57E0", Offset = "0x6BA3DE0", VA = "0x186BA57E0")]
		internal bool HNCMFDNBDBG(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EGPJFMMDCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LFANLDCHDLP CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public EGPJFMMDCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6B95770", Offset = "0x6B93D70", VA = "0x186B95770")]
		internal bool HPKMMMPJEFK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LDBPAHHFHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FLKACAKFJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public LDBPAHHFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5670", Offset = "0x6BA3C70", VA = "0x186BA5670")]
		internal JAGIEECCCMP<IEnumerable<Guid>> CNFDAFPHEME(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4610", Offset = "0x6BA2C10", VA = "0x186BA4610")]
		internal bool AGNCIEMFLCD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MIEKELKACKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FLKACAKFJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public MIEKELKACKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5C00", Offset = "0x6BA4200", VA = "0x186BA5C00")]
		internal void IAMNOFALLHC(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6B94F50", Offset = "0x6B93550", VA = "0x186B94F50")]
		internal void GJJNENMMEEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5910", Offset = "0x6BA3F10", VA = "0x186BA5910")]
		internal JAGIEECCCMP<Dictionary<Guid, DGKKLHHODBM>> FDOEGDMKACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x681DB70", Offset = "0x681C170", VA = "0x18681DB70")]
		internal bool CNMNLFGFBBH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class ENGJKKBMKFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ENGJKKBMKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6B95820", Offset = "0x6B93E20", VA = "0x186B95820")]
		internal JAGIEECCCMP<Dictionary<Guid, DGKKLHHODBM>> AAMFINEILMH(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JCMODEECKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public JCMODEECKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5070", Offset = "0x6BA3670", VA = "0x186BA5070")]
		internal bool LJIJAOGHMAB(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4F20", Offset = "0x6BA3520", VA = "0x186BA4F20")]
		internal KeyValuePair<Guid, DGKKLHHODBM> JAEDFKKPICL(Guid instanceId)
		{
			return default(KeyValuePair<Guid, DGKKLHHODBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GFNMEDPKANJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GFNMEDPKANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1AA97B0", Offset = "0x1AA7DB0", VA = "0x181AA97B0")]
		internal bool ACIAGHMBCNM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BCMEJIOPJPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public BCMEJIOPJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1AA97B0", Offset = "0x1AA7DB0", VA = "0x181AA97B0")]
		internal bool EACHHLLDACG(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GBOCCFLFOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public FLKACAKFJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GBOCCFLFOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4630", Offset = "0x6BA2C30", VA = "0x186BA4630")]
		internal JAGIEECCCMP<Dictionary<Guid, DGKKLHHODBM>> PCJGPHCFMGK(Dictionary<Guid, DGKKLHHODBM> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4610", Offset = "0x6BA2C10", VA = "0x186BA4610")]
		internal bool KPALCKAFBJE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class EGFAAOPHEFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public EGFAAOPHEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6B956F0", Offset = "0x6B93CF0", VA = "0x186B956F0")]
		internal bool BAAJMPPFOFK(KeyValuePair<Guid, DGKKLHHODBM> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CIHJGBMCJLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, DGKKLHHODBM> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public CIHJGBMCJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6B95460", Offset = "0x6B93A60", VA = "0x186B95460")]
		internal KeyValuePair<DGKKLHHODBM, int> MINKDDKCOGN(DGKKLHHODBM category)
		{
			return default(KeyValuePair<DGKKLHHODBM, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class NCIOHONNEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public DGKKLHHODBM category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public NCIOHONNEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x149E160", Offset = "0x149C760", VA = "0x18149E160")]
		internal bool NPJFHBDFODN(DGKKLHHODBM instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CFBBFGPHDFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, DGKKLHHODBM> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public CFBBFGPHDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6B95310", Offset = "0x6B93910", VA = "0x186B95310")]
		internal KeyValuePair<DGKKLHHODBM, int> MPGMGMLMLEB(DGKKLHHODBM category)
		{
			return default(KeyValuePair<DGKKLHHODBM, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GIPEHPAEBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DGKKLHHODBM category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GIPEHPAEBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x149E160", Offset = "0x149C760", VA = "0x18149E160")]
		internal bool LOJCHOBIFIL(DGKKLHHODBM instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JGCDHMAFKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public FLKACAKFJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public JGCDHMAFKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5210", Offset = "0x6BA3810", VA = "0x186BA5210")]
		internal bool IKEEGCFMHCM(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5150", Offset = "0x6BA3750", VA = "0x186BA5150")]
		internal bool GLAKCJBIACI(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5300", Offset = "0x6BA3900", VA = "0x186BA5300")]
		internal bool PNCLPBNECLD(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5300", Offset = "0x6BA3900", VA = "0x186BA5300")]
		internal bool KOKLMPOCKEG(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CKMGBLCHAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public CKMGBLCHAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xADC630", Offset = "0xADAC30", VA = "0x180ADC630")]
		internal bool MNJIHJDMJEG(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class OEEOIPLFLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public OEEOIPLFLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5DD0", Offset = "0x6BA43D0", VA = "0x186BA5DD0")]
		internal bool FBADCADLEJO(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1A67C40", Offset = "0x1A66240", VA = "0x181A67C40")]
		internal bool KNNLKKCNAMO(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GPDGHPMALKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GPDGHPMALKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4E60", Offset = "0x6BA3460", VA = "0x186BA4E60")]
		internal bool HAPFIKNNCJJ(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PBFFGIJDCNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public PBFFGIJDCNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xADC630", Offset = "0xADAC30", VA = "0x180ADC630")]
		internal bool EPBLGHMGCFA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FGNKGNCNGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public FGNKGNCNGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6B96370", Offset = "0x6B94970", VA = "0x186B96370")]
		internal bool BMLFDJOOFIH(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ICGABEFECMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DGKKLHHODBM keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ICGABEFECMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1733690", Offset = "0x1731C90", VA = "0x181733690")]
		internal bool ENKKAOEPAFF(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HOLONCIELIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HOLONCIELIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4EC0", Offset = "0x6BA34C0", VA = "0x186BA4EC0")]
		internal bool HGMBGCMPBBG(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PBPKJNMCEJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DGKKLHHODBM keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public PBPKJNMCEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5E90", Offset = "0x6BA4490", VA = "0x186BA5E90")]
		internal bool ILAIDAHIOED(KeyValuePair<Guid, DGKKLHHODBM> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DFKJLNAGJMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DGKKLHHODBM newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public DFKJLNAGJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1733690", Offset = "0x1731C90", VA = "0x181733690")]
		internal bool ECFBFGNMCBA(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KEFDLLJCFIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public KEFDLLJCFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BA53A0", Offset = "0x6BA39A0", VA = "0x186BA53A0")]
		internal bool GDBLOHIBEHF(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NMNBOFFCJHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public NMNBOFFCJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5CC0", Offset = "0x6BA42C0", VA = "0x186BA5CC0")]
		internal bool GHNJNPCKFHO(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JJBPCEHGCFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NMNBOFFCJHE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public JJBPCEHGCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5320", Offset = "0x6BA3920", VA = "0x186BA5320")]
		internal bool EFGBJCKJCGD(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct FCBJGNPHKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FLKACAKFJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public ANLFOIKADDC args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B95DE0", Offset = "0x6B943E0", VA = "0x186B95DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6B96310", Offset = "0x6B94910", VA = "0x186B96310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct APHKMLMNPNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FLKACAKFJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6B94C50", Offset = "0x6B93250", VA = "0x186B94C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6B94EF0", Offset = "0x6B934F0", VA = "0x186B94EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime MOJGFPEMGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EEOCGMGGAPA OFPLGIAIBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CABHFBEEMLF IIBLODKLJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly FNDDDJKHPLJ JCEAGJLIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly COACONGPMNC ELDMIIALHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly BLBEHMJAFNE BPLHAJDMKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OGLNLCLBMAC DAKCFDPDLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HFHGINOGHOO BEDGHDEFIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EGBHJBCMIAK BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EJMHILFALFD KOJEBAEMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OEIIGLEEMBC HHGNNLAAGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly EEILIJBGPBA FFCMDNIHHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GEPAOFHMKFD EAKEKLLDBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly IEDPGPCJMBC ODDGCHFJOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MNJPELKAOIM BCFFMMGGNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CICIOHJMEBM LONCLMCGANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly BOPGAAOHCAO<KeepsakesConfig.KeepsakesOptions> CLJCAFMAPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly LEBBOCDPOJL JGGOGAFIBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> MFDBNIOHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> IOOMMGEHGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> JNNPNGAMAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<DGKKLHHODBM, int> MIGNEJIPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> OHPIAPDKBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable PPANMBHAFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task OCCNEBJCDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private JAGIEECCCMP<Guid> PBLINILDFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? HCHGKOAACIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO MEHPKJGJIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JAGIEECCCMP<KeepsakeProgressionEventInstancesDTO> JAAMFHHBBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<DGKKLHHODBM, KeepsakeCategoryConfigDTO> KFMBLOAJKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO PHEEMGBKGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> DMDACKMOEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> HBLJINLLBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> FAFAPDKFMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> KNHPIOEKOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> MNBCALAMHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> MELOEJLHCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> FILJLBCAAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> KDNKMHBBKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> MLAHCEHKGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NDJHJIBPKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> DPEGFCNANKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> FOKPIPOMCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime DNHOIHEJDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable NEHDBLGJLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, DGKKLHHODBM> DPBGCDJMBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<DGKKLHHODBM, int> MJENFAFGHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> MGKGNNGFCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private FJALFLGAPDB NABELELKCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool NGKHFGJPLCL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GKPMKBNBEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB77770", Offset = "0xB75D70", VA = "0x180B77770", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xC6AF80", Offset = "0xC69580", VA = "0x180C6AF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PDKDOGGNLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B9C0B0", Offset = "0x6B9A6B0", VA = "0x186B9C0B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MFNOOMAJEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6B972C0", Offset = "0x6B958C0", VA = "0x186B972C0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long FCDLGPEDEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B97810", Offset = "0x6B95E10", VA = "0x186B97810")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? GHBCAJCLELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6B97780", Offset = "0x6B95D80", VA = "0x186B97780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PAGHDAFILKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B9EDD0", Offset = "0x6B9D3D0", VA = "0x186B9EDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> DNAPJBJIEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x962360", Offset = "0x960960", VA = "0x180962360", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> FOLOPDDJPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC9D570", Offset = "0xC9BB70", VA = "0x180C9D570", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> MJPBPNJENHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E9CB0", Offset = "0x8E82B0", VA = "0x1808E9CB0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DLPFJCBFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8EC3B0", Offset = "0x8EA9B0", VA = "0x1808EC3B0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool LFFFHKBAEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x19DC890", Offset = "0x19DAE90", VA = "0x1819DC890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> MLDDBMHLAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B9FCA0", Offset = "0x6B9E2A0", VA = "0x186B9FCA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA1A40", Offset = "0x6BA0040", VA = "0x186BA1A40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GDACIDFGMML
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B97220", Offset = "0x6B95820", VA = "0x186B97220", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6B97150", Offset = "0x6B95750", VA = "0x186B97150", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JBFLPDOJMKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B97380", Offset = "0x6B95980", VA = "0x186B97380", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6B9ADD0", Offset = "0x6B993D0", VA = "0x186B9ADD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3090", Offset = "0x6BA1690", VA = "0x186BA3090")]
	[RecRoom.NoEngine.Common.Preserve]
	internal FLKACAKFJDI([OLJNBPOCBCJ(null)][NotNull] EEOCGMGGAPA OFPLGIAIBCL, [NotNull][OLJNBPOCBCJ(null)] LFGBFBPJNCH JAFFEKBAIOJ, [NotNull][OLJNBPOCBCJ(null)] CABHFBEEMLF IIBLODKLJMF, [NotNull][OLJNBPOCBCJ(null)] FNDDDJKHPLJ JCEAGJLIKKI, [OLJNBPOCBCJ(null)][NotNull] COACONGPMNC ELDMIIALHNP, [OLJNBPOCBCJ(null)][NotNull] BLBEHMJAFNE BPLHAJDMKHP, [OLJNBPOCBCJ(null)][NotNull] OGLNLCLBMAC DAKCFDPDLHM, [NotNull][OLJNBPOCBCJ(null)] HFHGINOGHOO BEDGHDEFIEF, [NotNull][OLJNBPOCBCJ(null)] EGBHJBCMIAK BPCHJLBHPKH, [NotNull][OLJNBPOCBCJ(null)] IGBFJIBAGMA NOHIIKBHFHN, [NotNull][OLJNBPOCBCJ(null)] EJMHILFALFD KOJEBAEMIJF, [NotNull][OLJNBPOCBCJ(null)] OEIIGLEEMBC HHGNNLAAGIP, [NotNull][OLJNBPOCBCJ(null)] EEILIJBGPBA FFCMDNIHHNF, [NotNull][OLJNBPOCBCJ(null)] GEPAOFHMKFD EAKEKLLDBEC, [OLJNBPOCBCJ(null)][NotNull] IEDPGPCJMBC ODDGCHFJOGF, [OLJNBPOCBCJ(null)][NotNull] MNJPELKAOIM BCFFMMGGNHH, [NotNull][OLJNBPOCBCJ(null)] CICIOHJMEBM LONCLMCGANJ, [OLJNBPOCBCJ(null)][NotNull] BOPGAAOHCAO<KeepsakesConfig.KeepsakesOptions> CLJCAFMAPFP, [NotNull][OLJNBPOCBCJ(null)] LEBBOCDPOJL JGGOGAFIBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B0A0", Offset = "0x6B996A0", VA = "0x186B9B0A0", Slot = "15")]
	public bool GEIIKGPKHPP(List<string> NOKLNKOKGBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B9A6D0", Offset = "0x6B98CD0", VA = "0x186B9A6D0", Slot = "16")]
	public JAGIEECCCMP<Guid> FOHKHLIJCPD(DGKKLHHODBM BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B97500", Offset = "0x6B95B00", VA = "0x186B97500", Slot = "17")]
	public EOHNLEPDLDE CJKIGGJOIKK(Guid OIHIGEJBGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B9E620", Offset = "0x6B9CC20", VA = "0x186B9E620", Slot = "18")]
	public EOHNLEPDLDE JPGDOHPGJGO(Guid OIHIGEJBGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B9BCF0", Offset = "0x6B9A2F0", VA = "0x186B9BCF0", Slot = "19")]
	public bool HGBHFDKCCKM(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B9BE50", Offset = "0x6B9A450", VA = "0x186B9BE50", Slot = "20")]
	public bool HGLNAGFAJOK(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B9FF90", Offset = "0x6B9E590", VA = "0x186B9FF90")]
	public KeepsakeTheme LIEDILONLCE(Guid OIHIGEJBGDG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B99750", Offset = "0x6B97D50", VA = "0x186B99750")]
	public bool EOCALIGGHOG(DGKKLHHODBM BNCHBFDCBEE, [Out] KeepsakeTheme BPCBJOFMCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B9A320", Offset = "0x6B98920", VA = "0x186B9A320")]
	public List<KeepsakeTheme> FNNLMBGMCAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2190", Offset = "0x6BA0790", VA = "0x186BA2190")]
	public int OLLAMBBHOKM(DGKKLHHODBM BNCHBFDCBEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1530", Offset = "0x6B9FB30", VA = "0x186BA1530")]
	public DGKKLHHODBM NHBLAJEMGHB(Guid OIHIGEJBGDG)
	{
		return default(DGKKLHHODBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B9BBB0", Offset = "0x6B9A1B0", VA = "0x186B9BBB0", Slot = "34")]
	public List<DGKKLHHODBM> HDIMHPBKOAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1980", Offset = "0x6B9FF80", VA = "0x186BA1980", Slot = "35")]
	public IComparer<DGKKLHHODBM> NONBDCGCLIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BA0770", Offset = "0x6B9ED70", VA = "0x186BA0770", Slot = "32")]
	public string MIJJCLHLBPK(DGKKLHHODBM BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B96680", Offset = "0x6B94C80", VA = "0x186B96680", Slot = "33")]
	public string AAIAONCJCPF(DGKKLHHODBM BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1010", Offset = "0x6B9F610", VA = "0x186BA1010", Slot = "21")]
	public bool NCEOHCNIJAB(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B98710", Offset = "0x6B96D10", VA = "0x186B98710", Slot = "22")]
	public void EANGJDPPCOE(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B97AF0", Offset = "0x6B960F0", VA = "0x186B97AF0", Slot = "23")]
	public void DBNJONCFAIC(DGKKLHHODBM BNCHBFDCBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BA0530", Offset = "0x6B9EB30", VA = "0x186BA0530", Slot = "24")]
	public void MHPLGNMPAAN(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B96800", Offset = "0x6B94E00", VA = "0x186B96800", Slot = "25")]
	public int AAJLODJKKLK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B9E270", Offset = "0x6B9C870", VA = "0x186B9E270", Slot = "31")]
	public JAGIEECCCMP<IEnumerable<Guid>> JMOMCEFCNAG(long FNKMOIJJLLC, long OHLBGNEKGCE, DGKKLHHODBM? BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B995B0", Offset = "0x6B97BB0", VA = "0x186B995B0", Slot = "30")]
	public JAGIEECCCMP<IEnumerable<Guid>> EMGLOHJOJGB(long FNKMOIJJLLC, long OHLBGNEKGCE, DGKKLHHODBM? BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2C80", Offset = "0x6BA1280", VA = "0x186BA2C80", Slot = "54")]
	public JAGIEECCCMP<Dictionary<Guid, DGKKLHHODBM>> PMPPKGAMPFC(long FNKMOIJJLLC, long OHLBGNEKGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B98120", Offset = "0x6B96720", VA = "0x186B98120", Slot = "55")]
	public JAGIEECCCMP<Dictionary<Guid, DGKKLHHODBM>> DLFBLJBHEML(long FNKMOIJJLLC, long OHLBGNEKGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B810", Offset = "0x6B99E10", VA = "0x186B9B810", Slot = "26")]
	public JAGIEECCCMP<int> GPJLCBFHGCP(long FNKMOIJJLLC, long OHLBGNEKGCE, DGKKLHHODBM? BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B520", Offset = "0x6B99B20", VA = "0x186B9B520", Slot = "27")]
	public JAGIEECCCMP<int> GODEADNIPHC(long FNKMOIJJLLC, long OHLBGNEKGCE, DGKKLHHODBM? BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B978E0", Offset = "0x6B95EE0", VA = "0x186B978E0", Slot = "28")]
	public JAGIEECCCMP<Dictionary<DGKKLHHODBM, int>> CPBCLHKGLIA(long FNKMOIJJLLC, long OHLBGNEKGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B96F40", Offset = "0x6B95540", VA = "0x186B96F40", Slot = "29")]
	public JAGIEECCCMP<Dictionary<DGKKLHHODBM, int>> APEJEGPMKKP(long FNKMOIJJLLC, long OHLBGNEKGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BA0F10", Offset = "0x6B9F510", VA = "0x186BA0F10", Slot = "37")]
	public bool NAFADOICPHK(long FNKMOIJJLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B98780", Offset = "0x6B96D80", VA = "0x186B98780", Slot = "56")]
	public bool EBLEBHHMOKG(long FNKMOIJJLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C270", Offset = "0x6B9A870", VA = "0x186B9C270", Slot = "38")]
	public bool IINCHJIBBJK(long FNKMOIJJLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BA28D0", Offset = "0x6BA0ED0", VA = "0x186BA28D0", Slot = "57")]
	public bool PLPJPHCDNEE(long FNKMOIJJLLC, [Out] DMBMPGGMCKA CDJMCODLANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B9BE80", Offset = "0x6B9A480", VA = "0x186B9BE80", Slot = "39")]
	public bool HKPEGOFBAEO(long DIBFIMAIPPP, [Out] DateTime AJIJCLKJDBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B9DD40", Offset = "0x6B9C340", VA = "0x186B9DD40", Slot = "40")]
	public long JMENIOKGKCK(long DIBFIMAIPPP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6B9D820", Offset = "0x6B9BE20", VA = "0x186B9D820", Slot = "41")]
	public long JFKELPDNEPH(long FNKMOIJJLLC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B9F190", Offset = "0x6B9D790", VA = "0x186B9F190", Slot = "42")]
	public int KLHBEFPCKCL(long DIBFIMAIPPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6B97420", Offset = "0x6B95A20", VA = "0x186B97420", Slot = "43")]
	public bool CIECOKIENDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B99BE0", Offset = "0x6B981E0", VA = "0x186B99BE0", Slot = "44")]
	public bool FDKIHGOOEMF(long DIBFIMAIPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B98D00", Offset = "0x6B97300", VA = "0x186B98D00", Slot = "45")]
	public IEnumerable<long> EJGGDKJBDIE(long DIBFIMAIPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B9D930", Offset = "0x6B9BF30", VA = "0x186B9D930", Slot = "46")]
	public int JGFBLAFPOJK(long DIBFIMAIPPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6B99EA0", Offset = "0x6B984A0", VA = "0x186B99EA0", Slot = "50")]
	public long FIMJMFAMDLD(long FADLMAAHFJA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6B9D9E0", Offset = "0x6B9BFE0", VA = "0x186B9D9E0", Slot = "51")]
	public DGKKLHHODBM JILJDIKCJKL()
	{
		return default(DGKKLHHODBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C410", Offset = "0x6B9AA10", VA = "0x186B9C410")]
	private bool IOIENKNKICD(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2310", Offset = "0x6BA0910", VA = "0x186BA2310")]
	private void OLPIKGOANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1AF0", Offset = "0x6BA00F0", VA = "0x186BA1AF0")]
	private DGKKLHHODBM OGGNBGKDJCB()
	{
		return default(DGKKLHHODBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6B9F660", Offset = "0x6B9DC60", VA = "0x186B9F660")]
	private void LBAPHJEOCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6B9AF00", Offset = "0x6B99500", VA = "0x186B9AF00")]
	private int GDEKIJOEICP(KeepsakeRoomListDTO HAFJLGPIKNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1430", Offset = "0x6B9FA30", VA = "0x186BA1430")]
	private int NCOKCPNDFOG(DateTime BJENPPNPMEA, DateTime OBMGLDAEPJM, TimeSpan GAHPKOKGNKP, int CPMLNEHKIJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6B9F3D0", Offset = "0x6B9D9D0", VA = "0x186B9F3D0")]
	private void KOINFICPHNC(IEnumerable<KeepsakeInstanceDTO> MFDBNIOHHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B96D00", Offset = "0x6B95300", VA = "0x186B96D00")]
	private void AJAAJPBDBAB(IEnumerable<KeepsakeCollectionRecordDTO> LJNAEEBEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1690", Offset = "0x6B9FC90", VA = "0x186BA1690")]
	private void NLOPDALOCNE(IEnumerable<long> MIOGOOFILBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xBE6C80", Offset = "0xBE5280", VA = "0x180BE6C80")]
	private void PKDGBPPILJK(KeepsakeGlobalConfigDTO PHEEMGBKGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6BA08F0", Offset = "0x6B9EEF0", VA = "0x186BA08F0")]
	private bool MNDMLIEAFJC(DGKKLHHODBM BNCHBFDCBEE, [Out] Guid MKDPBJDGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6BA0F70", Offset = "0x6B9F570", VA = "0x186BA0F70")]
	private bool NBGOFGIJCKO([Out] Guid MKDPBJDGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6B9F370", Offset = "0x6B9D970", VA = "0x186B9F370")]
	private bool KNNGALDAIII(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6B97000", Offset = "0x6B95600", VA = "0x186B97000")]
	private IEnumerable<Guid> BGNDKCKGKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6BA00D0", Offset = "0x6B9E6D0", VA = "0x186BA00D0")]
	private IEnumerable<KeepsakeInstanceDTO> LNEEHJFMBFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B9AE70", Offset = "0x6B99470", VA = "0x186B9AE70")]
	private void GCHNGBPMKPB(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B9FD50", Offset = "0x6B9E350", VA = "0x186B9FD50")]
	private bool LGPAOFDHBEG(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B670", Offset = "0x6B99C70", VA = "0x186B9B670")]
	private void GOMBPJOPLID(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B96C20", Offset = "0x6B95220", VA = "0x186B96C20")]
	private void ACOEJBDPIED(DGKKLHHODBM PDMFFKPECJB, int INMHMBCAIHJ, Dictionary<DGKKLHHODBM, int> NMLBMIFBKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B9BFC0", Offset = "0x6B9A5C0", VA = "0x186B9BFC0")]
	private int HLLPLCPJNAN(DGKKLHHODBM BNCHBFDCBEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1FC0", Offset = "0x6BA05C0", VA = "0x186BA1FC0")]
	private void OJDGFKNLHNH(KeepsakeInstanceDTO NNKAIEGGNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6B97F10", Offset = "0x6B96510", VA = "0x186B97F10")]
	private void DHBJFIOKJLE(KeepsakeInstanceDTO NNKAIEGGNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6B97B40", Offset = "0x6B96140", VA = "0x186B97B40")]
	private void DGHNNCOONAN(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6B971F0", Offset = "0x6B957F0", VA = "0x186B971F0")]
	private void IOANCNMJJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6B9BB90", Offset = "0x6B9A190", VA = "0x186B9BB90")]
	private void HBHPEEIKBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2840", Offset = "0x6BA0E40", VA = "0x186BA2840")]
	private void PCCGPAKBIBH(NNNIMOHICLC CFEFAAHHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6B971F0", Offset = "0x6B957F0", VA = "0x186B971F0")]
	private void CBHFOEONCCM(ELNGPOONKME GHMNBJIOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6B971F0", Offset = "0x6B957F0", VA = "0x186B971F0")]
	private void CADJJPEFODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BA0190", Offset = "0x6B9E790", VA = "0x186BA0190")]
	private void MHEJAMPKNEN(float ECEHKCOBPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B99010", Offset = "0x6B97610", VA = "0x186B99010")]
	private void ELCEPCEHPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BA0D10", Offset = "0x6B9F310", VA = "0x186BA0D10")]
	private bool MPMPAJDFJDI(Guid OIHIGEJBGDG, [Out] string EJNPJOBCHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B99A10", Offset = "0x6B98010", VA = "0x186B99A10")]
	private bool FDFFOIIJJIN(Guid OIHIGEJBGDG, [Out] KeepsakeCategoryConfigDTO PDMFFKPECJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B99930", Offset = "0x6B97F30", VA = "0x186B99930")]
	private void FCPLHMHNPKK(string FDDGJBJOOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C7F0", Offset = "0x6B9ADF0", VA = "0x186B9C7F0")]
	private bool JDIDDMBPGNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C540", Offset = "0x6B9AB40", VA = "0x186B9C540")]
	private IEnumerable<long> JDHMDMJIHAM(IEnumerable<KeepsakeRoomDTO> HLOGLAIKKAG, IEnumerable<KeepsakeRoomListDTO> JBDBODADJOP, long DIBFIMAIPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B987E0", Offset = "0x6B96DE0", VA = "0x186B987E0")]
	private bool EDDPOOJKANN(Guid OIHIGEJBGDG, [Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3030", Offset = "0x6BA1630", VA = "0x186BA3030", Slot = "47")]
	public string POFHKDOMAFH(IIFNMNBEPND GAIFEGPIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B9E9B0", Offset = "0x6B9CFB0", VA = "0x186B9E9B0", Slot = "49")]
	public string KBDIDLCJBIF(IIFNMNBEPND GAIFEGPIKGO, long FNKMOIJJLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B9BAC0", Offset = "0x6B9A0C0", VA = "0x186B9BAC0", Slot = "48")]
	public string HAIFIBKLOLB(IIFNMNBEPND GAIFEGPIKGO, int NLJEFLILLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C920", Offset = "0x6B9AF20", VA = "0x186B9C920")]
	private void JENCGBLNPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B9FE00", Offset = "0x6B9E400", VA = "0x186B9FE00")]
	private void LHKMPHANLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BA28B0", Offset = "0x6BA0EB0", VA = "0x186BA28B0")]
	private IIFNMNBEPND PGAIMJADLHM(FFDEMIDLJBC DPJCOJIAAGJ)
	{
		return default(IIFNMNBEPND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C900", Offset = "0x6B9AF00", VA = "0x186B9C900")]
	private IIFNMNBEPND JDOMJLOHLLM(FFDEMIDLJBC DPJCOJIAAGJ)
	{
		return default(IIFNMNBEPND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1DE0", Offset = "0x6BA03E0", VA = "0x186BA1DE0")]
	internal static string OHIOFEILGKI(MACJAHHJDBB AACHLKELPJJ, string MGNIBPHFOBI, bool DHPEDFAMKPM, int PKDBMBIGJLN, int DMNGLIPOFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B982B0", Offset = "0x6B968B0", VA = "0x186B982B0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BA27C0", Offset = "0x6BA0DC0", VA = "0x186BA27C0")]
	private BFFBEBDHILG ONBBPOLMNCI(PDPPFLAPOCL KEGACPFHMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B9A160", Offset = "0x6B98760", VA = "0x186B9A160")]
	private MEHHEBAJBML FKPOGNDAMLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B9EDE0", Offset = "0x6B9D3E0", VA = "0x186B9EDE0")]
	private Task KLELPKFLDFJ(ANLFOIKADDC AAAOIGBEBAB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BA16F0", Offset = "0x6B9FCF0", VA = "0x186BA16F0")]
	[AsyncStateMachine(typeof(FCBJGNPHKDC))]
	private Task NMAAJFDEBCN(ANLFOIKADDC AAAOIGBEBAB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B9AD00", Offset = "0x6B99300", VA = "0x186B9AD00")]
	private Task FPBOMBKNKIB(ANLFOIKADDC AAAOIGBEBAB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B98EE0", Offset = "0x6B974E0", VA = "0x186B98EE0")]
	[AsyncStateMachine(typeof(APHKMLMNPNO))]
	private Task EKNBCBCEOAF(string KFAOBDLOMDC, TimeSpan KLPNBIMCPFH, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1DC0", Offset = "0x6BA03C0", VA = "0x186BA1DC0")]
	[CompilerGenerated]
	private void OGJAOICMCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1800", Offset = "0x6B9FE00", VA = "0x186BA1800")]
	[CompilerGenerated]
	private void NOBCCMKLPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C310", Offset = "0x6B9A910", VA = "0x186B9C310")]
	[CompilerGenerated]
	private bool IKOLEINNDCO(KeepsakeInstanceDTO NCPIGLMANIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C100", Offset = "0x6B9A700", VA = "0x186B9C100")]
	[CompilerGenerated]
	private JAGIEECCCMP<Dictionary<DGKKLHHODBM, int>> ICABPIJDAHD(Dictionary<Guid, DGKKLHHODBM> KPMBALABHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B3B0", Offset = "0x6B999B0", VA = "0x186B9B3B0")]
	[CompilerGenerated]
	private JAGIEECCCMP<Dictionary<DGKKLHHODBM, int>> GNEICDKPDND(Dictionary<Guid, DGKKLHHODBM> KPMBALABHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B330", Offset = "0x6B99930", VA = "0x186B9B330")]
	[CompilerGenerated]
	private bool GENOAMFJICM(KeepsakeRoomListDTO NCPIGLMANIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1850", Offset = "0x6B9FE50", VA = "0x186BA1850")]
	[CompilerGenerated]
	private bool NOGLENEIDAC(KeepsakeInstanceDTO NCPIGLMANIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6BA12A0", Offset = "0x6B9F8A0", VA = "0x186BA12A0")]
	[CompilerGenerated]
	private void NCHGCHDAJFN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<DGKKLHHODBM, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NEPIFFELNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B350", Offset = "0x6B99950", VA = "0x186B9B350")]
	[CompilerGenerated]
	private void GNCDBBCMLKF(string ENDMINEHNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BA0B50", Offset = "0x6B9F150", VA = "0x186BA0B50")]
	[CompilerGenerated]
	private Task MNFGMEBKGLM(CancellationToken HDNMPBIPJCF)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, BOPGAAOHCAO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class NKMLPNAHBCA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
				public NKMLPNAHBCA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6BA5C90", Offset = "0x6BA4290", VA = "0x186BA5C90")]
				internal bool ELICNJKEKEM(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6BA5C90", Offset = "0x6BA4290", VA = "0x186BA5C90")]
				internal bool NGGJKFOOAJD(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6BA54A0", Offset = "0x6BA3AA0", VA = "0x186BA54A0")]
			public bool OFNKKAEIHCC(string CAMPMAKCDLJ, [Out] KeepsakeTheme BPCBJOFMCNF)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5420", Offset = "0x6BA3A20", VA = "0x186BA5420")]
		[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
		internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x903180", Offset = "0x901780", VA = "0x180903180")]
		public KeepsakesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AssetReference PickupPrefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float LoopingSfxVolume;
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
