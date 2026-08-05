using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86CFB80", Offset = "0x86CE580", VA = "0x1886CFB80", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D5840", Offset = "0x86D4240", VA = "0x1886D5840", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JANJDGIBAEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly FNNMMEDNKCL AEJLDGOMOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly byte AEOGKDPPBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid JPMACAOCOMP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86CF990", Offset = "0x86CE390", VA = "0x1886CF990")]
	public JANJDGIBAEN(FNNMMEDNKCL AEJLDGOMOCI, byte AEOGKDPPBBE, Guid JPMACAOCOMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate Task KLGCNLILPBP(ALPHANGLKLD GACFFBLMJOF, CancellationToken OMJKEHOJJFF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class ALPHANGLKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KNOBEKJADBE GGDBPCAHELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private List<(PersistenceView, BHOPKDGDEFN)> FCAMCKGJGLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[NotNull]
	public DJEKJMDOAHO FMPLOAHABGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[NotNull]
	public DBNKIMCJKJK LCCAPGGNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HKHBKGNJPNE JHLLEDLBILM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<HKHBKGNJPNE> FOKIHEDANOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<HKHBKGNJPNE> KHAJPJCCEME
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BKLAHIHKKHK CNOCMHPEPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
		[CompilerGenerated]
		get
		{
			return default(BKLAHIHKKHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[NotNull]
	public AJDHPEOBCFP NGLABMHDBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HEEMABDELIE DBIAAKEEMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<JANJDGIBAEN> FPCGCILMNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OBGLFNADNNH OJKHLMIFJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PJGPLILIKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA91C40", Offset = "0xA90640", VA = "0x180A91C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x86CE6C0", Offset = "0x86CD0C0", VA = "0x1886CE6C0")]
	public ALPHANGLKLD(DJEKJMDOAHO GADEDFJOCGJ, DBNKIMCJKJK GOLLOAJNBEK, HKHBKGNJPNE MKAFNCGNCPA, IReadOnlyList<HKHBKGNJPNE> DGAMNOBIJDH, IReadOnlyList<HKHBKGNJPNE> GNJNJIAJKKN, BKLAHIHKKHK BEIHJEJNGJH, bool DCGOILCELMG, AJDHPEOBCFP OBPEHAFILEK, HEEMABDELIE MFNLMEFHDNI, IEnumerable<JANJDGIBAEN> KEFFOIDAKLK, OBGLFNADNNH CCEOHFLECLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86CE630", Offset = "0x86CD030", VA = "0x1886CE630")]
	public void JOLJHIIFEBM(KNOBEKJADBE FLCPJMFAJKH, List<(PersistenceView, BHOPKDGDEFN)> OEKCFEHGHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86CE650", Offset = "0x86CD050", VA = "0x1886CE650")]
	public List<(PersistenceView, BHOPKDGDEFN)> NAKJEAANLDN(KNOBEKJADBE CEPKOIGBHDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AHLLAMLIAPD
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Incremental,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Recovery
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MIOKGJCEPIK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	CloudSave,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AutosaveRecovery,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AutosaveIncremental
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ECBNLFMBINN]
public enum KNOBEKJADBE
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	NOT_STARTED = 0,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	DOWNLOADING_DETAILS = 1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DETAILS_DOWNLOADED = 2,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DOWNLOADING_DATA = 3,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	DATA_DOWNLOADED = 4,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	SCENE_LOADED = 5,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	STUDIO_ASSET_BUNDLE_PROCESSED = 6,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	SETUP_ROOM_OBJECTS = 7,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	RUN_MIGRATIONS = 8,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	PRE_DESTROY_OLD_OBJECTS = 9,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	POST_DESTROY_OLD_OBJECTS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	DESERIALIZE_SETTINGS = 10,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	PRE_INSTANTIATE_OBJECTS = 11,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	POST_INSTANTIATE_OBJECTS = 12,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	PRE_DESERIALIZE_OBJECTS = 13,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	DESERIALIZE_OBJECTS = 14,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	DESERIALIZE_CONNECTABLES = 15,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	POST_DESERIALIZE_OBJECTS = 16,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	DESERIALIZE_OBJECTS_COMPLETE = 17,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	PRE_COMPLETE = 18,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	COMPLETE = 19
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FALDLNAGKBL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	NonAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Authority,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	All
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HKHBKGNJPNE
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Guid IAGHKHMHFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AssetBundle> JJPHJNGIBNA();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPPFLFMCOOF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BLPFMECDJMK(bool CJBLIDOAODJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CGPEAJDBKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public BKLAHIHKKHK BEIHJEJNGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public BHOPKDGDEFN HGCHPOBFDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool LKAKHCDBJCN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GALGMADDFIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<string> IBKHDNBKPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public StringBuilder PDBEMMKOCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IOMNDPDPOCC EPCKCAIBNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int CLDHLCPIGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 PKBBKJPHPDB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x86CEF20", Offset = "0x86CD920", VA = "0x1886CEF20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x86CEF70", Offset = "0x86CD970", VA = "0x1886CEF70")]
	public GALGMADDFIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KADHFDKFHPG
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	RunForAuthorityOnly,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	RunForAllDuringRoomPersistence
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JPAKOKFOBHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ONEPCFIMCOL : JPAKOKFOBHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	KADHFDKFHPG ECPNIJKIJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool LGDGKCPNJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DeserializeFrom(CGPEAJDBKFG ENNBFKHDIPP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SerializeTo(BHOPKDGDEFN HGCHPOBFDBI, GALGMADDFIP ABBMHACAOIN, StringBuilder NPBEMGGAFJI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GPNFAKOHNCK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KADHFDKFHPG BEEOOJEAMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DeserializeFrom(AJDHPEOBCFP OBPEHAFILEK, CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SerializeTo(AJDHPEOBCFP OBPEHAFILEK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HPJNGDGEPGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool LKAKHCDBJCN;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EGILABPIFCC : ONEPCFIMCOL, JPAKOKFOBHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PostDeserialize(HPJNGDGEPGJ DBMAPKMFJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HGPFGFCHFHL : ONEPCFIMCOL, JPAKOKFOBHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PreDeserialize(BKLAHIHKKHK BEIHJEJNGJH, BHOPKDGDEFN HGCHPOBFDBI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MKICHGLOMAN : JPAKOKFOBHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PreSerializeAsync(StringBuilder NPBEMGGAFJI, MIOKGJCEPIK PMPJINGFHBP, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JPFNCIEFDND
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<NNCIEOBEJLN> NMACNPAKFLA();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable CFDCCDKHPOH(object HCLPHJDKMCA, NNCIEOBEJLN LCJFNEJNIDM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IReadOnlyList<AFKECIDEIKC> BGBBGDPINPG();
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, PFKAIMLHHGG
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct ChildViewReference
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int childId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public PersistenceView persistenceView;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public delegate void PADOHOMHPOK(Guid FHNAMGOIMEM, Guid PBIMELEPEAG);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class FPJMGFCMBEE
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class DEJPPAIILPI<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : ONEPCFIMCOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				private T <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				private int <>l__initialThreadId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				private HashSet<ONEPCFIMCOL> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public HashSet<ONEPCFIMCOL> <>3__collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				private HashSet<ONEPCFIMCOL>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				T IEnumerator<T>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return (T)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
				[DebuggerHidden]
				public DEJPPAIILPI(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4E9BC70", Offset = "0x4E9A670", VA = "0x184E9BC70", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x6FF8020", Offset = "0x6FF6A20", VA = "0x186FF8020", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x6FF7FD0", Offset = "0x6FF69D0", VA = "0x186FF7FD0")]
				private void ALLLMJKJJCD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x6FF82B0", Offset = "0x6FF6CB0", VA = "0x186FF82B0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4E9D040", Offset = "0x4E9BA40", VA = "0x184E9D040", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<T> IEnumerable<T>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4E9D4C0", Offset = "0x4E9BEC0", VA = "0x184E9D4C0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private HashSet<ONEPCFIMCOL> BJJKMAGMDJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<ONEPCFIMCOL> OFDAGODAHPG;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x86CEDB0", Offset = "0x86CD7B0", VA = "0x1886CEDB0")]
			public void OIPNDJMOCGP(KADHFDKFHPG ADIGPNCHDJO, ONEPCFIMCOL AFMHNPNOFPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x86CED30", Offset = "0x86CD730", VA = "0x1886CED30")]
			private static void GJHLKHFJPHJ(HashSet<ONEPCFIMCOL> KEDANMKGBBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x43C98C0", Offset = "0x43C82C0", VA = "0x1843C98C0")]
			public IEnumerable<T> KJGEGFOEEGE<T>(bool BPKCADJNPDN) where T : ONEPCFIMCOL
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3B8ECD0", Offset = "0x3B8D6D0", VA = "0x183B8ECD0")]
			[IteratorStateMachine(typeof(DEJPPAIILPI<>))]
			private static IEnumerable<T> DPAIIDJCGLC<T>(HashSet<ONEPCFIMCOL> KEDANMKGBBA) where T : ONEPCFIMCOL
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public FPJMGFCMBEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class NJAFCFCPGEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ChildViewReference child;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public NJAFCFCPGEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x86CFC10", Offset = "0x86CE610", VA = "0x1886CFC10")]
			internal bool BKHFNIFCEOB(PIJJDDEMMCP d)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly HashSet<PersistenceView> GDCIAHCMJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool NCDAGDNODLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private ChildViewReference[] childViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private int highestChildIdAssigned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		public bool explicitlyBlockPersistence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PBKHPGOKKHK<Guid> IBGIINCIHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<ONEPCFIMCOL> FDJFELOEMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<MKICHGLOMAN> JMJOHDHGADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private FPJMGFCMBEE COPIKLBIPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid MHLPCFOLEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid FELBMLJEBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private CNFJHBAFEIK EJPJANMJNBA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> GCDDECIDONF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x86D50B0", Offset = "0x86D3AB0", VA = "0x1886D50B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid BIKKNIIFDAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x86D4C70", Offset = "0x86D3670", VA = "0x1886D4C70")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x86D5200", Offset = "0x86D3C00", VA = "0x1886D5200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KDKMFGKNHDH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1525280", Offset = "0x1523C80", VA = "0x181525280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1524B50", Offset = "0x1523550", VA = "0x181524B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LODANCNEDKE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x86D4D50", Offset = "0x86D3750", VA = "0x1886D4D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool DPDKGEJGEOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x86D1D00", Offset = "0x86D0700", VA = "0x1886D1D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView JJFEOOFPKFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool MJMJGOGEAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x86D4D00", Offset = "0x86D3700", VA = "0x1886D4D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool ANJGNCDFDKM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x86D29A0", Offset = "0x86D13A0", VA = "0x1886D29A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PADOHOMHPOK BNBBHJICNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x86D4BC0", Offset = "0x86D35C0", VA = "0x1886D4BC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x86D5150", Offset = "0x86D3B50", VA = "0x1886D5150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86D05E0", Offset = "0x86CEFE0", VA = "0x1886D05E0", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86D1BF0", Offset = "0x86D05F0", VA = "0x1886D1BF0")]
		private bool EMKGDLBJIAN([Out] Guid HIHDNEBBINF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86D2E50", Offset = "0x86D1850", VA = "0x1886D2E50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86D2A10", Offset = "0x86D1410", VA = "0x1886D2A10", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86D20A0", Offset = "0x86D0AA0", VA = "0x1886D20A0")]
		private void KOHCONDNAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86D2E50", Offset = "0x86D1850", VA = "0x1886D2E50")]
		private void OnMasterClientSwitched(POIAKMBAMML JGGGINODJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86D2810", Offset = "0x86D1210", VA = "0x1886D2810")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86D3A30", Offset = "0x86D2430", VA = "0x1886D3A30")]
		public void PreSerializeAsync(MFJNMJILDKH<Task> KJEFIMLGNLK, StringBuilder NPBEMGGAFJI, MIOKGJCEPIK PMPJINGFHBP, CancellationToken OMJKEHOJJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86D3E70", Offset = "0x86D2870", VA = "0x1886D3E70")]
		public BHOPKDGDEFN Serialize(GALGMADDFIP ABBMHACAOIN, StringBuilder NPBEMGGAFJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E60", Offset = "0x86D0860", VA = "0x1886D1E60")]
		public void InitializeDeserialization(BHOPKDGDEFN HGCHPOBFDBI, bool BNHEMLEMPPP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x86D3520", Offset = "0x86D1F20", VA = "0x1886D3520")]
		public void PreDeserialize(bool BPKCADJNPDN, BKLAHIHKKHK BEIHJEJNGJH, BHOPKDGDEFN HGCHPOBFDBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86D0E30", Offset = "0x86CF830", VA = "0x1886D0E30")]
		public void Deserialize(bool BPKCADJNPDN, CGPEAJDBKFG ENNBFKHDIPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86D30B0", Offset = "0x86D1AB0", VA = "0x1886D30B0")]
		public void PostDeserialize(bool BPKCADJNPDN, HPJNGDGEPGJ DBMAPKMFJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86D14C0", Offset = "0x86CFEC0", VA = "0x1886D14C0")]
		private void EBBHONJLIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86D2E60", Offset = "0x86D1860", VA = "0x1886D2E60")]
		private BHOPKDGDEFN PEIPCJKJNFH(BHOPKDGDEFN EFONPKKDJJJ, ChildViewReference KOAIHIGOIMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86D2740", Offset = "0x86D1140", VA = "0x1886D2740")]
		public void MarkExcludedFromRoomSave(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86D48F0", Offset = "0x86D32F0", VA = "0x1886D48F0")]
		public void UnmarkExcludedFromRoomSave(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86D0CD0", Offset = "0x86CF6D0", VA = "0x1886D0CD0", Slot = "14")]
		public void Bake(BIHHMEGLCGA HCLPHJDKMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86D4AD0", Offset = "0x86D34D0", VA = "0x1886D4AD0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86D2660", Offset = "0x86D1060", VA = "0x1886D2660")]
		[CompilerGenerated]
		private object MOBMEBMPDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86D2920", Offset = "0x86D1320", VA = "0x1886D2920")]
		[CompilerGenerated]
		private object NOJAMIABIBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x86D0C20", Offset = "0x86CF620", VA = "0x1886D0C20")]
		[CompilerGenerated]
		private object BPPCAMPECPF()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NNCIEOBEJLN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool MGHKEDIBDIG(ALPHANGLKLD GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HOCHDFKLHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action handler;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HOCHDFKLHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x86CF8F0", Offset = "0x86CE2F0", VA = "0x1886CF8F0")]
		internal Task PLEHELOKALA(ALPHANGLKLD data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KNPIDICALOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action<ALPHANGLKLD> handler;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KNPIDICALOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x86CFAD0", Offset = "0x86CE4D0", VA = "0x1886CFAD0")]
		internal Task PLEHELOKALA(ALPHANGLKLD data, CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OOHEFLMIGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FALDLNAGKBL handlerRunFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NNCIEOBEJLN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OOHEFLMIGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x86D04F0", Offset = "0x86CEEF0", VA = "0x1886D04F0")]
		internal object EBMAFFKPPLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<KNOBEKJADBE, HashSet<(FALDLNAGKBL, MGHKEDIBDIG, KLGCNLILPBP)>> NGKPEHPIACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly Guid NIKKEFEJDPB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x86D0450", Offset = "0x86CEE50", VA = "0x1886D0450")]
	public NNCIEOBEJLN(Guid BHIFHOKAMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x86D0110", Offset = "0x86CEB10", VA = "0x1886D0110")]
	public NNCIEOBEJLN ICBPPNMLINK(KNOBEKJADBE PBLNKJOAMPI, FALDLNAGKBL ADIGPNCHDJO, KLGCNLILPBP LCJFNEJNIDM, [Optional] MGHKEDIBDIG GMPNMALJHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x86D0020", Offset = "0x86CEA20", VA = "0x1886D0020")]
	public NNCIEOBEJLN ICBPPNMLINK(KNOBEKJADBE PBLNKJOAMPI, FALDLNAGKBL ADIGPNCHDJO, Action LCJFNEJNIDM, [Optional] MGHKEDIBDIG GMPNMALJHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x86D0360", Offset = "0x86CED60", VA = "0x1886D0360")]
	public NNCIEOBEJLN ICBPPNMLINK(KNOBEKJADBE PBLNKJOAMPI, FALDLNAGKBL ADIGPNCHDJO, Action<ALPHANGLKLD> LCJFNEJNIDM, [Optional] MGHKEDIBDIG GMPNMALJHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x86CFC30", Offset = "0x86CE630", VA = "0x1886CFC30")]
	public Dictionary<FALDLNAGKBL, List<KLGCNLILPBP>> HMKJANOPPBP(KNOBEKJADBE FLCPJMFAJKH, ALPHANGLKLD GPCDCFCPGFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public delegate Task AFKECIDEIKC(CancellationToken OMJKEHOJJFF);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[UnityEngine.Scripting.Preserve]
internal class GGEECGPPFGD : JPFNCIEFDND
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum INOFBHKGNDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Start,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		LoadingScene,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		LoadingSubScenes,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		LoadingPersistence,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		PersistenceLoadComplete
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class GAIFNHGOKGG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class PEFDKDBHAMB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly object HCLPHJDKMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly NNCIEOBEJLN LCJFNEJNIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action<object> JFHHGDLEAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool JNAAJFKIBLB;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xDB36D0", Offset = "0xDB20D0", VA = "0x180DB36D0")]
		public PEFDKDBHAMB(object HCLPHJDKMCA, NNCIEOBEJLN LCJFNEJNIDM, Action<object> JFHHGDLEAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86D05A0", Offset = "0x86CEFA0", VA = "0x1886D05A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, NNCIEOBEJLN> JIIEOPFHNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<AFKECIDEIKC> KHOFAPPHANN;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x86CF270", Offset = "0x86CDC70", VA = "0x1886CF270")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	internal static void EIKIOMKMPDG(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x86CF600", Offset = "0x86CE000", VA = "0x1886CF600", Slot = "4")]
	public IReadOnlyList<NNCIEOBEJLN> NMACNPAKFLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x86CF0F0", Offset = "0x86CDAF0", VA = "0x1886CF0F0", Slot = "5")]
	public IDisposable CFDCCDKHPOH(object HCLPHJDKMCA, NNCIEOBEJLN LCJFNEJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x86CF030", Offset = "0x86CDA30", VA = "0x1886CF030", Slot = "6")]
	public IReadOnlyList<AFKECIDEIKC> BGBBGDPINPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86CF450", Offset = "0x86CDE50", VA = "0x1886CF450")]
	private void IGIHDEGBBNG(object HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x86CF370", Offset = "0x86CDD70", VA = "0x1886CF370")]
	[MNIIDFGFPJH]
	internal static void HHJNICDMMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86CF4B0", Offset = "0x86CDEB0", VA = "0x1886CF4B0")]
	internal static void IMMJLLEIOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86CF070", Offset = "0x86CDA70", VA = "0x1886CF070")]
	internal void BHLLPNLFDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x86CF6D0", Offset = "0x86CE0D0", VA = "0x1886CF6D0")]
	public GGEECGPPFGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class BICLJHMHCAK
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly List<KNOBEKJADBE> AGNOFBLEHIJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public static IReadOnlyList<KNOBEKJADBE> NKLNGDNNKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86CE800", Offset = "0x86CD200", VA = "0x1886CE800")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HEJNJNBOEGM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct DPEODOJNHAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public HEJNJNBOEGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86CEAA0", Offset = "0x86CD4A0", VA = "0x1886CEAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86CECD0", Offset = "0x86CD6D0", VA = "0x1886CECD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float GJNCPBDJMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float OIMDFMEKBLB;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x86CF8B0", Offset = "0x86CE2B0", VA = "0x1886CF8B0")]
	public HEJNJNBOEGM(float OIMDFMEKBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x86CF7C0", Offset = "0x86CE1C0", VA = "0x1886CF7C0")]
	[AsyncStateMachine(typeof(DPEODOJNHAL))]
	public Task EHJDFBFADDH(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86CF7A0", Offset = "0x86CE1A0", VA = "0x1886CF7A0")]
	public void AAJENMMCLHG()
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
