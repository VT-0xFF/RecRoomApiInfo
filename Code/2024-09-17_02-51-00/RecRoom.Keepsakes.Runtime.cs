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
		[Cpp2IlInjected.Address(RVA = "0x6C8D370", Offset = "0x6C8BD70", VA = "0x186C8D370", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EGLAHMANHLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x11F3380", Offset = "0x11F1D80", VA = "0x1811F3380")]
		internal bool KPMCBAHCOAF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x16A6EE0", Offset = "0x16A58E0", VA = "0x1816A6EE0")]
		internal bool IHDFAKOHFPF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x11F3380", Offset = "0x11F1D80", VA = "0x1811F3380")]
		internal bool GMHMGNEMCPA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x16A6EE0", Offset = "0x16A58E0", VA = "0x1816A6EE0")]
		internal bool GIDCLNLKBOA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> FCIDBNELGOP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public FJALFLGAPDB(List<KeepsakeCategoryThemePair> MGKGNNGFCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D660", Offset = "0x6C7C060", VA = "0x186C7D660", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GEFCFCLNGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BB20", Offset = "0x6C8A520", VA = "0x186C8BB20")]
		internal JAGIEECCCMP<Guid> DLNANOKDACH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BCB0", Offset = "0x6C8A6B0", VA = "0x186C8BCB0")]
		internal void NAKLOPBGCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BAC0", Offset = "0x6C8A4C0", VA = "0x186C8BAC0")]
		internal void DKJAGAFLPNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BCE0", Offset = "0x6C8A6E0", VA = "0x186C8BCE0")]
		internal void NIMINCKNIOJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BC80", Offset = "0x6C8A680", VA = "0x186C8BC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ENIJDPPLIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CC60", Offset = "0x6C7B660", VA = "0x186C7CC60")]
		internal void HIFJOKOCBEC(MACJAHHJDBB response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D010", Offset = "0x6C7BA10", VA = "0x186C7D010")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OBJHMLHPMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D040", Offset = "0x6C8BA40", VA = "0x186C8D040")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public BOBMOFNPBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C210", Offset = "0x6C7AC10", VA = "0x186C7C210")]
		internal void JLPEMPHFLIG(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C1E0", Offset = "0x6C7ABE0", VA = "0x186C7C1E0")]
		internal void AMIJPEOOHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C2A0", Offset = "0x6C7ACA0", VA = "0x186C7C2A0")]
		internal JAGIEECCCMP<IEnumerable<Guid>> PFKEIMAEAAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69014D0", Offset = "0x68FFED0", VA = "0x1869014D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EDNAEJADICP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C840", Offset = "0x6C7B240", VA = "0x186C7C840")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LFANLDCHDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CA70", Offset = "0x6C8B470", VA = "0x186C8CA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EGPJFMMDCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CA00", Offset = "0x6C7B400", VA = "0x186C7CA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LDBPAHHFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C900", Offset = "0x6C8B300", VA = "0x186C8C900")]
		internal JAGIEECCCMP<IEnumerable<Guid>> CNFDAFPHEME(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B8A0", Offset = "0x6C8A2A0", VA = "0x186C8B8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MIEKELKACKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CE90", Offset = "0x6C8B890", VA = "0x186C8CE90")]
		internal void IAMNOFALLHC(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C1E0", Offset = "0x6C7ABE0", VA = "0x186C7C1E0")]
		internal void GJJNENMMEEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CBA0", Offset = "0x6C8B5A0", VA = "0x186C8CBA0")]
		internal JAGIEECCCMP<Dictionary<Guid, DGKKLHHODBM>> FDOEGDMKACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69014D0", Offset = "0x68FFED0", VA = "0x1869014D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ENGJKKBMKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CAB0", Offset = "0x6C7B4B0", VA = "0x186C7CAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JCMODEECKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C300", Offset = "0x6C8AD00", VA = "0x186C8C300")]
		internal bool LJIJAOGHMAB(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C1B0", Offset = "0x6C8ABB0", VA = "0x186C8C1B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GFNMEDPKANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1BE2310", Offset = "0x1BE0D10", VA = "0x181BE2310")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public BCMEJIOPJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1BE2310", Offset = "0x1BE0D10", VA = "0x181BE2310")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GBOCCFLFOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B8C0", Offset = "0x6C8A2C0", VA = "0x186C8B8C0")]
		internal JAGIEECCCMP<Dictionary<Guid, DGKKLHHODBM>> PCJGPHCFMGK(Dictionary<Guid, DGKKLHHODBM> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B8A0", Offset = "0x6C8A2A0", VA = "0x186C8B8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EGFAAOPHEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C980", Offset = "0x6C7B380", VA = "0x186C7C980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CIHJGBMCJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C6F0", Offset = "0x6C7B0F0", VA = "0x186C7C6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NCIOHONNEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x154B020", Offset = "0x1549A20", VA = "0x18154B020")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CFBBFGPHDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C5A0", Offset = "0x6C7AFA0", VA = "0x186C7C5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GIPEHPAEBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x154B020", Offset = "0x1549A20", VA = "0x18154B020")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JGCDHMAFKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C4A0", Offset = "0x6C8AEA0", VA = "0x186C8C4A0")]
		internal bool IKEEGCFMHCM(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C3E0", Offset = "0x6C8ADE0", VA = "0x186C8C3E0")]
		internal bool GLAKCJBIACI(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C590", Offset = "0x6C8AF90", VA = "0x186C8C590")]
		internal bool PNCLPBNECLD(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C590", Offset = "0x6C8AF90", VA = "0x186C8C590")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CKMGBLCHAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x955340", Offset = "0x953D40", VA = "0x180955340")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OEEOIPLFLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D060", Offset = "0x6C8BA60", VA = "0x186C8D060")]
		internal bool FBADCADLEJO(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1BA0790", Offset = "0x1B9F190", VA = "0x181BA0790")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GPDGHPMALKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C0F0", Offset = "0x6C8AAF0", VA = "0x186C8C0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public PBFFGIJDCNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x955340", Offset = "0x953D40", VA = "0x180955340")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FGNKGNCNGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D600", Offset = "0x6C7C000", VA = "0x186C7D600")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ICGABEFECMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x18915C0", Offset = "0x188FFC0", VA = "0x1818915C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HOLONCIELIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C150", Offset = "0x6C8AB50", VA = "0x186C8C150")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public PBPKJNMCEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D120", Offset = "0x6C8BB20", VA = "0x186C8D120")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public DFKJLNAGJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x18915C0", Offset = "0x188FFC0", VA = "0x1818915C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public KEFDLLJCFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C630", Offset = "0x6C8B030", VA = "0x186C8C630")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NMNBOFFCJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CF50", Offset = "0x6C8B950", VA = "0x186C8CF50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JJBPCEHGCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C5B0", Offset = "0x6C8AFB0", VA = "0x186C8C5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7D070", Offset = "0x6C7BA70", VA = "0x186C7D070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D5A0", Offset = "0x6C7BFA0", VA = "0x186C7D5A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7BEE0", Offset = "0x6C7A8E0", VA = "0x186C7BEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C180", Offset = "0x6C7AB80", VA = "0x186C7C180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xC46710", Offset = "0xC45110", VA = "0x180C46710", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD234D0", Offset = "0xD21ED0", VA = "0x180D234D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PDKDOGGNLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C83340", Offset = "0x6C81D40", VA = "0x186C83340", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MFNOOMAJEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E550", Offset = "0x6C7CF50", VA = "0x186C7E550", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long FCDLGPEDEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C7EAA0", Offset = "0x6C7D4A0", VA = "0x186C7EAA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? GHBCAJCLELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C7EA10", Offset = "0x6C7D410", VA = "0x186C7EA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PAGHDAFILKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C86060", Offset = "0x6C84A60", VA = "0x186C86060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> DNAPJBJIEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA0A960", Offset = "0xA09360", VA = "0x180A0A960", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> FOLOPDDJPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x997EC0", Offset = "0x9968C0", VA = "0x180997EC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> MJPBPNJENHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x995B70", Offset = "0x994570", VA = "0x180995B70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DLPFJCBFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x995800", Offset = "0x994200", VA = "0x180995800", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool LFFFHKBAEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1B32980", Offset = "0x1B31380", VA = "0x181B32980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> MLDDBMHLAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C86F30", Offset = "0x6C85930", VA = "0x186C86F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C88CD0", Offset = "0x6C876D0", VA = "0x186C88CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GDACIDFGMML
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E4B0", Offset = "0x6C7CEB0", VA = "0x186C7E4B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E3E0", Offset = "0x6C7CDE0", VA = "0x186C7E3E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JBFLPDOJMKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E610", Offset = "0x6C7D010", VA = "0x186C7E610", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C82060", Offset = "0x6C80A60", VA = "0x186C82060", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A320", Offset = "0x6C88D20", VA = "0x186C8A320")]
	[RecRoom.NoEngine.Common.Preserve]
	internal FLKACAKFJDI([OLJNBPOCBCJ(null)][NotNull] EEOCGMGGAPA OFPLGIAIBCL, [NotNull][OLJNBPOCBCJ(null)] LFGBFBPJNCH JAFFEKBAIOJ, [NotNull][OLJNBPOCBCJ(null)] CABHFBEEMLF IIBLODKLJMF, [NotNull][OLJNBPOCBCJ(null)] FNDDDJKHPLJ JCEAGJLIKKI, [OLJNBPOCBCJ(null)][NotNull] COACONGPMNC ELDMIIALHNP, [OLJNBPOCBCJ(null)][NotNull] BLBEHMJAFNE BPLHAJDMKHP, [OLJNBPOCBCJ(null)][NotNull] OGLNLCLBMAC DAKCFDPDLHM, [NotNull][OLJNBPOCBCJ(null)] HFHGINOGHOO BEDGHDEFIEF, [NotNull][OLJNBPOCBCJ(null)] EGBHJBCMIAK BPCHJLBHPKH, [NotNull][OLJNBPOCBCJ(null)] IGBFJIBAGMA NOHIIKBHFHN, [NotNull][OLJNBPOCBCJ(null)] EJMHILFALFD KOJEBAEMIJF, [NotNull][OLJNBPOCBCJ(null)] OEIIGLEEMBC HHGNNLAAGIP, [NotNull][OLJNBPOCBCJ(null)] EEILIJBGPBA FFCMDNIHHNF, [NotNull][OLJNBPOCBCJ(null)] GEPAOFHMKFD EAKEKLLDBEC, [OLJNBPOCBCJ(null)][NotNull] IEDPGPCJMBC ODDGCHFJOGF, [OLJNBPOCBCJ(null)][NotNull] MNJPELKAOIM BCFFMMGGNHH, [NotNull][OLJNBPOCBCJ(null)] CICIOHJMEBM LONCLMCGANJ, [OLJNBPOCBCJ(null)][NotNull] BOPGAAOHCAO<KeepsakesConfig.KeepsakesOptions> CLJCAFMAPFP, [NotNull][OLJNBPOCBCJ(null)] LEBBOCDPOJL JGGOGAFIBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C82330", Offset = "0x6C80D30", VA = "0x186C82330", Slot = "15")]
	public bool GEIIKGPKHPP(List<string> NOKLNKOKGBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C81960", Offset = "0x6C80360", VA = "0x186C81960", Slot = "16")]
	public JAGIEECCCMP<Guid> FOHKHLIJCPD(DGKKLHHODBM BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E790", Offset = "0x6C7D190", VA = "0x186C7E790", Slot = "17")]
	public EOHNLEPDLDE CJKIGGJOIKK(Guid OIHIGEJBGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C858B0", Offset = "0x6C842B0", VA = "0x186C858B0", Slot = "18")]
	public EOHNLEPDLDE JPGDOHPGJGO(Guid OIHIGEJBGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C82F80", Offset = "0x6C81980", VA = "0x186C82F80", Slot = "19")]
	public bool HGBHFDKCCKM(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C830E0", Offset = "0x6C81AE0", VA = "0x186C830E0", Slot = "20")]
	public bool HGLNAGFAJOK(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C87220", Offset = "0x6C85C20", VA = "0x186C87220")]
	public KeepsakeTheme LIEDILONLCE(Guid OIHIGEJBGDG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C809E0", Offset = "0x6C7F3E0", VA = "0x186C809E0")]
	public bool EOCALIGGHOG(DGKKLHHODBM BNCHBFDCBEE, [Out] KeepsakeTheme BPCBJOFMCNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C815B0", Offset = "0x6C7FFB0", VA = "0x186C815B0")]
	public List<KeepsakeTheme> FNNLMBGMCAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C89420", Offset = "0x6C87E20", VA = "0x186C89420")]
	public int OLLAMBBHOKM(DGKKLHHODBM BNCHBFDCBEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C887C0", Offset = "0x6C871C0", VA = "0x186C887C0")]
	public DGKKLHHODBM NHBLAJEMGHB(Guid OIHIGEJBGDG)
	{
		return default(DGKKLHHODBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C82E40", Offset = "0x6C81840", VA = "0x186C82E40", Slot = "34")]
	public List<DGKKLHHODBM> HDIMHPBKOAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C88C10", Offset = "0x6C87610", VA = "0x186C88C10", Slot = "35")]
	public IComparer<DGKKLHHODBM> NONBDCGCLIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C87A00", Offset = "0x6C86400", VA = "0x186C87A00", Slot = "32")]
	public string MIJJCLHLBPK(DGKKLHHODBM BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D910", Offset = "0x6C7C310", VA = "0x186C7D910", Slot = "33")]
	public string AAIAONCJCPF(DGKKLHHODBM BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C882A0", Offset = "0x6C86CA0", VA = "0x186C882A0", Slot = "21")]
	public bool NCEOHCNIJAB(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F9A0", Offset = "0x6C7E3A0", VA = "0x186C7F9A0", Slot = "22")]
	public void EANGJDPPCOE(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7ED80", Offset = "0x6C7D780", VA = "0x186C7ED80", Slot = "23")]
	public void DBNJONCFAIC(DGKKLHHODBM BNCHBFDCBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C877C0", Offset = "0x6C861C0", VA = "0x186C877C0", Slot = "24")]
	public void MHPLGNMPAAN(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DA90", Offset = "0x6C7C490", VA = "0x186C7DA90", Slot = "25")]
	public int AAJLODJKKLK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C85500", Offset = "0x6C83F00", VA = "0x186C85500", Slot = "31")]
	public JAGIEECCCMP<IEnumerable<Guid>> JMOMCEFCNAG(long FNKMOIJJLLC, long OHLBGNEKGCE, DGKKLHHODBM? BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C80840", Offset = "0x6C7F240", VA = "0x186C80840", Slot = "30")]
	public JAGIEECCCMP<IEnumerable<Guid>> EMGLOHJOJGB(long FNKMOIJJLLC, long OHLBGNEKGCE, DGKKLHHODBM? BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C89F10", Offset = "0x6C88910", VA = "0x186C89F10", Slot = "54")]
	public JAGIEECCCMP<Dictionary<Guid, DGKKLHHODBM>> PMPPKGAMPFC(long FNKMOIJJLLC, long OHLBGNEKGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F3B0", Offset = "0x6C7DDB0", VA = "0x186C7F3B0", Slot = "55")]
	public JAGIEECCCMP<Dictionary<Guid, DGKKLHHODBM>> DLFBLJBHEML(long FNKMOIJJLLC, long OHLBGNEKGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C82AA0", Offset = "0x6C814A0", VA = "0x186C82AA0", Slot = "26")]
	public JAGIEECCCMP<int> GPJLCBFHGCP(long FNKMOIJJLLC, long OHLBGNEKGCE, DGKKLHHODBM? BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C827B0", Offset = "0x6C811B0", VA = "0x186C827B0", Slot = "27")]
	public JAGIEECCCMP<int> GODEADNIPHC(long FNKMOIJJLLC, long OHLBGNEKGCE, DGKKLHHODBM? BNCHBFDCBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C7EB70", Offset = "0x6C7D570", VA = "0x186C7EB70", Slot = "28")]
	public JAGIEECCCMP<Dictionary<DGKKLHHODBM, int>> CPBCLHKGLIA(long FNKMOIJJLLC, long OHLBGNEKGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E1D0", Offset = "0x6C7CBD0", VA = "0x186C7E1D0", Slot = "29")]
	public JAGIEECCCMP<Dictionary<DGKKLHHODBM, int>> APEJEGPMKKP(long FNKMOIJJLLC, long OHLBGNEKGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C881A0", Offset = "0x6C86BA0", VA = "0x186C881A0", Slot = "37")]
	public bool NAFADOICPHK(long FNKMOIJJLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FA10", Offset = "0x6C7E410", VA = "0x186C7FA10", Slot = "56")]
	public bool EBLEBHHMOKG(long FNKMOIJJLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C83500", Offset = "0x6C81F00", VA = "0x186C83500", Slot = "38")]
	public bool IINCHJIBBJK(long FNKMOIJJLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C89B60", Offset = "0x6C88560", VA = "0x186C89B60", Slot = "57")]
	public bool PLPJPHCDNEE(long FNKMOIJJLLC, [Out] DMBMPGGMCKA CDJMCODLANK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C83110", Offset = "0x6C81B10", VA = "0x186C83110", Slot = "39")]
	public bool HKPEGOFBAEO(long DIBFIMAIPPP, [Out] DateTime AJIJCLKJDBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C84FD0", Offset = "0x6C839D0", VA = "0x186C84FD0", Slot = "40")]
	public long JMENIOKGKCK(long DIBFIMAIPPP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C84AB0", Offset = "0x6C834B0", VA = "0x186C84AB0", Slot = "41")]
	public long JFKELPDNEPH(long FNKMOIJJLLC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C86420", Offset = "0x6C84E20", VA = "0x186C86420", Slot = "42")]
	public int KLHBEFPCKCL(long DIBFIMAIPPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E6B0", Offset = "0x6C7D0B0", VA = "0x186C7E6B0", Slot = "43")]
	public bool CIECOKIENDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C80E70", Offset = "0x6C7F870", VA = "0x186C80E70", Slot = "44")]
	public bool FDKIHGOOEMF(long DIBFIMAIPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FF90", Offset = "0x6C7E990", VA = "0x186C7FF90", Slot = "45")]
	public IEnumerable<long> EJGGDKJBDIE(long DIBFIMAIPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C84BC0", Offset = "0x6C835C0", VA = "0x186C84BC0", Slot = "46")]
	public int JGFBLAFPOJK(long DIBFIMAIPPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C81130", Offset = "0x6C7FB30", VA = "0x186C81130", Slot = "50")]
	public long FIMJMFAMDLD(long FADLMAAHFJA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C84C70", Offset = "0x6C83670", VA = "0x186C84C70", Slot = "51")]
	public DGKKLHHODBM JILJDIKCJKL()
	{
		return default(DGKKLHHODBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C836A0", Offset = "0x6C820A0", VA = "0x186C836A0")]
	private bool IOIENKNKICD(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C895A0", Offset = "0x6C87FA0", VA = "0x186C895A0")]
	private void OLPIKGOANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C88D80", Offset = "0x6C87780", VA = "0x186C88D80")]
	private DGKKLHHODBM OGGNBGKDJCB()
	{
		return default(DGKKLHHODBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C868F0", Offset = "0x6C852F0", VA = "0x186C868F0")]
	private void LBAPHJEOCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C82190", Offset = "0x6C80B90", VA = "0x186C82190")]
	private int GDEKIJOEICP(KeepsakeRoomListDTO HAFJLGPIKNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C886C0", Offset = "0x6C870C0", VA = "0x186C886C0")]
	private int NCOKCPNDFOG(DateTime BJENPPNPMEA, DateTime OBMGLDAEPJM, TimeSpan GAHPKOKGNKP, int CPMLNEHKIJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C86660", Offset = "0x6C85060", VA = "0x186C86660")]
	private void KOINFICPHNC(IEnumerable<KeepsakeInstanceDTO> MFDBNIOHHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DF90", Offset = "0x6C7C990", VA = "0x186C7DF90")]
	private void AJAAJPBDBAB(IEnumerable<KeepsakeCollectionRecordDTO> LJNAEEBEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C88920", Offset = "0x6C87320", VA = "0x186C88920")]
	private void NLOPDALOCNE(IEnumerable<long> MIOGOOFILBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xCB7530", Offset = "0xCB5F30", VA = "0x180CB7530")]
	private void PKDGBPPILJK(KeepsakeGlobalConfigDTO PHEEMGBKGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C87B80", Offset = "0x6C86580", VA = "0x186C87B80")]
	private bool MNDMLIEAFJC(DGKKLHHODBM BNCHBFDCBEE, [Out] Guid MKDPBJDGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C88200", Offset = "0x6C86C00", VA = "0x186C88200")]
	private bool NBGOFGIJCKO([Out] Guid MKDPBJDGBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C86600", Offset = "0x6C85000", VA = "0x186C86600")]
	private bool KNNGALDAIII(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E290", Offset = "0x6C7CC90", VA = "0x186C7E290")]
	private IEnumerable<Guid> BGNDKCKGKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C87360", Offset = "0x6C85D60", VA = "0x186C87360")]
	private IEnumerable<KeepsakeInstanceDTO> LNEEHJFMBFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C82100", Offset = "0x6C80B00", VA = "0x186C82100")]
	private void GCHNGBPMKPB(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C86FE0", Offset = "0x6C859E0", VA = "0x186C86FE0")]
	private bool LGPAOFDHBEG(Guid OIHIGEJBGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C82900", Offset = "0x6C81300", VA = "0x186C82900")]
	private void GOMBPJOPLID(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DEB0", Offset = "0x6C7C8B0", VA = "0x186C7DEB0")]
	private void ACOEJBDPIED(DGKKLHHODBM PDMFFKPECJB, int INMHMBCAIHJ, Dictionary<DGKKLHHODBM, int> NMLBMIFBKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C83250", Offset = "0x6C81C50", VA = "0x186C83250")]
	private int HLLPLCPJNAN(DGKKLHHODBM BNCHBFDCBEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C89250", Offset = "0x6C87C50", VA = "0x186C89250")]
	private void OJDGFKNLHNH(KeepsakeInstanceDTO NNKAIEGGNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F1A0", Offset = "0x6C7DBA0", VA = "0x186C7F1A0")]
	private void DHBJFIOKJLE(KeepsakeInstanceDTO NNKAIEGGNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C7EDD0", Offset = "0x6C7D7D0", VA = "0x186C7EDD0")]
	private void DGHNNCOONAN(Guid OIHIGEJBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E480", Offset = "0x6C7CE80", VA = "0x186C7E480")]
	private void IOANCNMJJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C82E20", Offset = "0x6C81820", VA = "0x186C82E20")]
	private void HBHPEEIKBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C89AD0", Offset = "0x6C884D0", VA = "0x186C89AD0")]
	private void PCCGPAKBIBH(NNNIMOHICLC CFEFAAHHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E480", Offset = "0x6C7CE80", VA = "0x186C7E480")]
	private void CBHFOEONCCM(ELNGPOONKME GHMNBJIOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E480", Offset = "0x6C7CE80", VA = "0x186C7E480")]
	private void CADJJPEFODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C87420", Offset = "0x6C85E20", VA = "0x186C87420")]
	private void MHEJAMPKNEN(float ECEHKCOBPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C802A0", Offset = "0x6C7ECA0", VA = "0x186C802A0")]
	private void ELCEPCEHPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C87FA0", Offset = "0x6C869A0", VA = "0x186C87FA0")]
	private bool MPMPAJDFJDI(Guid OIHIGEJBGDG, [Out] string EJNPJOBCHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C80CA0", Offset = "0x6C7F6A0", VA = "0x186C80CA0")]
	private bool FDFFOIIJJIN(Guid OIHIGEJBGDG, [Out] KeepsakeCategoryConfigDTO PDMFFKPECJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C80BC0", Offset = "0x6C7F5C0", VA = "0x186C80BC0")]
	private void FCPLHMHNPKK(string FDDGJBJOOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C83A80", Offset = "0x6C82480", VA = "0x186C83A80")]
	private bool JDIDDMBPGNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C837D0", Offset = "0x6C821D0", VA = "0x186C837D0")]
	private IEnumerable<long> JDHMDMJIHAM(IEnumerable<KeepsakeRoomDTO> HLOGLAIKKAG, IEnumerable<KeepsakeRoomListDTO> JBDBODADJOP, long DIBFIMAIPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FA70", Offset = "0x6C7E470", VA = "0x186C7FA70")]
	private bool EDDPOOJKANN(Guid OIHIGEJBGDG, [Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A2C0", Offset = "0x6C88CC0", VA = "0x186C8A2C0", Slot = "47")]
	public string POFHKDOMAFH(IIFNMNBEPND GAIFEGPIKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C85C40", Offset = "0x6C84640", VA = "0x186C85C40", Slot = "49")]
	public string KBDIDLCJBIF(IIFNMNBEPND GAIFEGPIKGO, long FNKMOIJJLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C82D50", Offset = "0x6C81750", VA = "0x186C82D50", Slot = "48")]
	public string HAIFIBKLOLB(IIFNMNBEPND GAIFEGPIKGO, int NLJEFLILLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C83BB0", Offset = "0x6C825B0", VA = "0x186C83BB0")]
	private void JENCGBLNPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C87090", Offset = "0x6C85A90", VA = "0x186C87090")]
	private void LHKMPHANLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6C89B40", Offset = "0x6C88540", VA = "0x186C89B40")]
	private IIFNMNBEPND PGAIMJADLHM(FFDEMIDLJBC DPJCOJIAAGJ)
	{
		return default(IIFNMNBEPND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C83B90", Offset = "0x6C82590", VA = "0x186C83B90")]
	private IIFNMNBEPND JDOMJLOHLLM(FFDEMIDLJBC DPJCOJIAAGJ)
	{
		return default(IIFNMNBEPND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C89070", Offset = "0x6C87A70", VA = "0x186C89070")]
	internal static string OHIOFEILGKI(MACJAHHJDBB AACHLKELPJJ, string MGNIBPHFOBI, bool DHPEDFAMKPM, int PKDBMBIGJLN, int DMNGLIPOFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F540", Offset = "0x6C7DF40", VA = "0x186C7F540", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C89A50", Offset = "0x6C88450", VA = "0x186C89A50")]
	private BFFBEBDHILG ONBBPOLMNCI(PDPPFLAPOCL KEGACPFHMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C813F0", Offset = "0x6C7FDF0", VA = "0x186C813F0")]
	private MEHHEBAJBML FKPOGNDAMLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C86070", Offset = "0x6C84A70", VA = "0x186C86070")]
	private Task KLELPKFLDFJ(ANLFOIKADDC AAAOIGBEBAB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C88980", Offset = "0x6C87380", VA = "0x186C88980")]
	[AsyncStateMachine(typeof(FCBJGNPHKDC))]
	private Task NMAAJFDEBCN(ANLFOIKADDC AAAOIGBEBAB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C81F90", Offset = "0x6C80990", VA = "0x186C81F90")]
	private Task FPBOMBKNKIB(ANLFOIKADDC AAAOIGBEBAB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C80170", Offset = "0x6C7EB70", VA = "0x186C80170")]
	[AsyncStateMachine(typeof(APHKMLMNPNO))]
	private Task EKNBCBCEOAF(string KFAOBDLOMDC, TimeSpan KLPNBIMCPFH, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C89050", Offset = "0x6C87A50", VA = "0x186C89050")]
	[CompilerGenerated]
	private void OGJAOICMCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C88A90", Offset = "0x6C87490", VA = "0x186C88A90")]
	[CompilerGenerated]
	private void NOBCCMKLPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C835A0", Offset = "0x6C81FA0", VA = "0x186C835A0")]
	[CompilerGenerated]
	private bool IKOLEINNDCO(KeepsakeInstanceDTO NCPIGLMANIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C83390", Offset = "0x6C81D90", VA = "0x186C83390")]
	[CompilerGenerated]
	private JAGIEECCCMP<Dictionary<DGKKLHHODBM, int>> ICABPIJDAHD(Dictionary<Guid, DGKKLHHODBM> KPMBALABHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C82640", Offset = "0x6C81040", VA = "0x186C82640")]
	[CompilerGenerated]
	private JAGIEECCCMP<Dictionary<DGKKLHHODBM, int>> GNEICDKPDND(Dictionary<Guid, DGKKLHHODBM> KPMBALABHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C825C0", Offset = "0x6C80FC0", VA = "0x186C825C0")]
	[CompilerGenerated]
	private bool GENOAMFJICM(KeepsakeRoomListDTO NCPIGLMANIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C88AE0", Offset = "0x6C874E0", VA = "0x186C88AE0")]
	[CompilerGenerated]
	private bool NOGLENEIDAC(KeepsakeInstanceDTO NCPIGLMANIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C88530", Offset = "0x6C86F30", VA = "0x186C88530")]
	[CompilerGenerated]
	private void NCHGCHDAJFN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<DGKKLHHODBM, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NEPIFFELNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C825E0", Offset = "0x6C80FE0", VA = "0x186C825E0")]
	[CompilerGenerated]
	private void GNCDBBCMLKF(string ENDMINEHNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C87DE0", Offset = "0x6C867E0", VA = "0x186C87DE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
				public NKMLPNAHBCA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6C8CF20", Offset = "0x6C8B920", VA = "0x186C8CF20")]
				internal bool ELICNJKEKEM(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6C8CF20", Offset = "0x6C8B920", VA = "0x186C8CF20")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8C730", Offset = "0x6C8B130", VA = "0x186C8C730")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C6B0", Offset = "0x6C8B0B0", VA = "0x186C8C6B0")]
		[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
		internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9A74A0", Offset = "0x9A5EA0", VA = "0x1809A74A0")]
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
