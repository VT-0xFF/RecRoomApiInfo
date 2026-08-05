using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.PUN;
using Unity.Netcode;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C12400", Offset = "0x5C10C00", VA = "0x185C12400")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C6D40", VA = "0x1808C8540")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD79980", Offset = "0xD78180", VA = "0x180D79980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HGPNGJPCCJO : OELLBIGADPN, OODGHPHMEDM, JOCGPOGHBJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CPNPDFFGKDI : AKGEKDBLCDK
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HDEJGFGGNCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action onCompleteCallback;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public HDEJGFGGNCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2F48410", Offset = "0x2F46C10", VA = "0x182F48410")]
			internal void HBFMDAICPIC(FGJMLGPECOJ rh)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OGFAEFLMOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5C09010", Offset = "0x5C07810", VA = "0x185C09010", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CMKPIAHBOAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5C09080", Offset = "0x5C07880", VA = "0x185C09080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<DNBPKCLNCGP> GGFCDEJJGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5C091A0", Offset = "0x5C079A0", VA = "0x185C091A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C08ED0", Offset = "0x5C076D0", VA = "0x185C08ED0", Slot = "7")]
		public bool DLKADAHCLPJ(Action PNHKBJEPIPL, string GNBEMPNCJAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CPNPDFFGKDI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private DGMDFAOLBNL KFMACPCPNLA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly byte[] HFGLOAKKBDC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override bool BIDKDNOELMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBA59E0", Offset = "0xBA41E0", VA = "0x180BA59E0", Slot = "78")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override DGMDFAOLBNL MHKIIBFLFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8C3600", Offset = "0x8C1E00", VA = "0x1808C3600", Slot = "79")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override bool ECPPDPEEEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0CE20", Offset = "0x5C0B620", VA = "0x185C0CE20", Slot = "80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override bool MCDGHCEDJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D8E0", Offset = "0x5C0C0E0", VA = "0x185C0D8E0", Slot = "59")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C8E0", Offset = "0x5C0B0E0", VA = "0x185C0C8E0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override float OIPKDDBOOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D5C0", Offset = "0x5C0BDC0", VA = "0x185C0D5C0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override AKGEKDBLCDK MLHMKHLIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C3590", Offset = "0x8C1D90", VA = "0x1808C3590", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override bool BAAOGMEPFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C7D0", Offset = "0x5C0AFD0", VA = "0x185C0C7D0", Slot = "81")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C670", Offset = "0x5C0AE70", VA = "0x185C0C670", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override bool DLELAGHEFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5C0CA70", Offset = "0x5C0B270", VA = "0x185C0CA70", Slot = "83")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool LAOBPANCCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C0CF10", Offset = "0x5C0B710", VA = "0x185C0CF10", Slot = "84")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override OAOBMBOAHMN MEPANAMHEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C0CFE0", Offset = "0x5C0B7E0", VA = "0x185C0CFE0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override int AMBJOOMBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5C0CF60", Offset = "0x5C0B760", VA = "0x185C0CF60", Slot = "62")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override int GIBKMHMGHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C6D0", Offset = "0x5C0AED0", VA = "0x185C0C6D0", Slot = "63")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override IGGCDPKBFGF AGOBILJIDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D810", Offset = "0x5C0C010", VA = "0x185C0D810", Slot = "64")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int KEPCAECPIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D040", Offset = "0x5C0B840", VA = "0x185C0D040", Slot = "65")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override int CIFGLBNPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C750", Offset = "0x5C0AF50", VA = "0x185C0C750", Slot = "66")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public override event FJKGHOIPBKO HGAIJHBEINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D770", Offset = "0x5C0BF70", VA = "0x185C0D770", Slot = "55")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D1A0", Offset = "0x5C0B9A0", VA = "0x185C0D1A0", Slot = "56")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public override event Action<IGGCDPKBFGF> AEKDKGLIMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D240", Offset = "0x5C0BA40", VA = "0x185C0D240", Slot = "57")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C0CD80", Offset = "0x5C0B580", VA = "0x185C0CD80", Slot = "58")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public override event Action<DGMDFAOLBNL, DGMDFAOLBNL> PFJOHPIOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C5D0", Offset = "0x5C0ADD0", VA = "0x185C0C5D0", Slot = "76")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0CE70", Offset = "0x5C0B670", VA = "0x185C0CE70", Slot = "77")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C0CBD0", Offset = "0x5C0B3D0", VA = "0x185C0CBD0", Slot = "88")]
	public override void GBAOOILFPIJ(CPDEDBIILFH CLDJMJIFMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D0B0", Offset = "0x5C0B8B0", VA = "0x185C0D0B0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
	private static void LECKBAIJAMJ(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DAB0", Offset = "0x5C0C2B0", VA = "0x185C0DAB0")]
	[Preserve]
	public HGPNGJPCCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D620", Offset = "0x5C0BE20", VA = "0x185C0D620")]
	private void NFHGDEPLENB(bool JHACDNKHNBG, bool OCJOEBGAJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C0C820", Offset = "0x5C0B020", VA = "0x185C0C820", Slot = "67")]
	[CanBeNull]
	public override IGGCDPKBFGF DNGDHJDCGCA(int AGMAMFDBLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D330", Offset = "0x5C0BB30", VA = "0x185C0D330")]
	private static short MCBOOKOGHKC(StreamBuffer OCCOFFDGHLE, object OLHPNBBMHBL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D440", Offset = "0x5C0BC40", VA = "0x185C0D440")]
	private static object NDBJIDMMFLG(StreamBuffer KPPNKPPKIOF, short HLPFAIAMMGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C0C940", Offset = "0x5C0B140", VA = "0x185C0C940", Slot = "97")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D3E0", Offset = "0x5C0BBE0", VA = "0x185C0D3E0", Slot = "68")]
	public override bool MGONOMMEPLO(AppSettings HNOHEIJIOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C0CCB0", Offset = "0x5C0B4B0", VA = "0x185C0CCB0", Slot = "69")]
	public override void GCOOFIKLMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D930", Offset = "0x5C0C130", VA = "0x185C0D930", Slot = "70")]
	public override bool POIDEHOOANO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D6A0", Offset = "0x5C0BEA0", VA = "0x185C0D6A0", Slot = "71")]
	public override void NOAJFPPOCON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D6F0", Offset = "0x5C0BEF0", VA = "0x185C0D6F0", Slot = "72")]
	public override bool OAMKKLLHMCJ(byte PJPMIHPOMIA, Hashtable LPNMAPPAKIO, EBKGAFDELBK NAOEDGLNDNC, SendOptions PPCDNDPNNDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C0CD00", Offset = "0x5C0B500", VA = "0x185C0CD00", Slot = "86")]
	public override bool GEDPJPOFHMO(string KEGJMIDPONL, LKDKDDBBHDN FKDCDHPANOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C0CAC0", Offset = "0x5C0B2C0", VA = "0x185C0CAC0", Slot = "87")]
	public override void FBNKOHBMKHA(string GHJAEMHEDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D860", Offset = "0x5C0C060", VA = "0x185C0D860", Slot = "91")]
	public void OnEvent(EventData BIMOMPIOOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "92")]
	public void OnPlayerEnteredRoom(FDHHGKFBMIM NNOKMFJPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "93")]
	public void OnPlayerLeftRoom(FDHHGKFBMIM PJFCAJCEEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "94")]
	public void OnRoomPropertiesUpdate(Hashtable JMJNHFOPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "95")]
	public void OnPlayerPropertiesUpdate(FDHHGKFBMIM ELEGOCLCPLC, Hashtable GKDAHOCIADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D2E0", Offset = "0x5C0BAE0", VA = "0x185C0D2E0", Slot = "96")]
	private void LPGNNLKGEHA(FDHHGKFBMIM MIJJDEGFGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DBDNKFALDNM : FEPEBAKIENM, NFKMNIGHJNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyDictionary<string, int>> JFJPMMOCJAK([Optional] TimeSpan? BBNJILIHPCN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ADBEFBGBKFF
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool DPPJPHAAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PLJHKDIEDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	TimeSpan BEFNPMCJOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	TimeSpan FMNGAJBBKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AppSettings JEGOHKJDPFH(ECFHLMMEAJO GGNPIMBDEJF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OAOBMBOAHMN EDCOFAFICGK(ECFHLMMEAJO GGNPIMBDEJF);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<ECFHLMMEAJO> DPMNLLEIPLN(CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JNFDMMGFHOD : ILKPKFGJHDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly global::NAOGJOJMPFD<MLLLMININAO> DKGJIIICCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly global::NAOGJOJMPFD<MLLLMININAO> PLKOCGCAPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly global::NAOGJOJMPFD<MLLLMININAO> OIDBLAPIIAF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<MLLLMININAO> GDDDFHNAFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5C10150", Offset = "0x5C0E950", VA = "0x185C10150")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5C101B0", Offset = "0x5C0E9B0", VA = "0x185C101B0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<MLLLMININAO> JLGMAPNEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5C102D0", Offset = "0x5C0EAD0", VA = "0x185C102D0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5C10210", Offset = "0x5C0EA10", VA = "0x185C10210")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<MLLLMININAO> DOFPCEIHHLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5C10330", Offset = "0x5C0EB30", VA = "0x185C10330")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5C10270", Offset = "0x5C0EA70", VA = "0x185C10270")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5C10390", Offset = "0x5C0EB90", VA = "0x185C10390", Slot = "30")]
	public override void OnDisconnected(MLLLMININAO PNDKKGJBMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5C10490", Offset = "0x5C0EC90", VA = "0x185C10490")]
	public JNFDMMGFHOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FPALJCBONGJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5C09E90", Offset = "0x5C08690", VA = "0x185C09E90")]
	public FPALJCBONGJ(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5C09F00", Offset = "0x5C08700", VA = "0x185C09F00")]
	public FPALJCBONGJ(string DKIECHCHJFL, Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PJIONHJECMA : FPALJCBONGJ
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5C12F70", Offset = "0x5C11770", VA = "0x185C12F70")]
	public PJIONHJECMA([NotNull] Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EEEJKMFONGJ : FPALJCBONGJ
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5C09C80", Offset = "0x5C08480", VA = "0x185C09C80")]
	public EEEJKMFONGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ILCBNBHBDJC : FPALJCBONGJ
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DDA0", Offset = "0x5C0C5A0", VA = "0x185C0DDA0")]
	public ILCBNBHBDJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OODNOPCOCJN : global::DFLBHHLIEGP<EPJFONLPCOB>, DBDNKFALDNM, FEPEBAKIENM, NFKMNIGHJNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NDHKOFBHLNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public OODNOPCOCJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private CancellationToken <token>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NDHKOFBHLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5C11BC0", Offset = "0x5C103C0", VA = "0x185C11BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JBKIOGDCGNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public OODNOPCOCJN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JBKIOGDCGNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0EBB0", Offset = "0x5C0D3B0", VA = "0x185C0EBB0")]
		internal void NEENKAOBKEN(global::JAPPGKMKBNF<string> timer)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class APOPMOPGCBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, int>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TimeSpan? timeoutSpan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public OODNOPCOCJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JBKIOGDCGNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private global::JAPPGKMKBNF<string> <pingStackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private AALOEEPNEOP <pingTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private ECFHLMMEAJO <photonServerConnectionInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private AppSettings <pingAppSettings>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Stopwatch <sw>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private AALOEEPNEOP <newTimerScope>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Dictionary<string, int> <regionPings>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private ECFHLMMEAJO <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private AALOEEPNEOP <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private AALOEEPNEOP <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private AALOEEPNEOP <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<ECFHLMMEAJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private YieldAwaitable.YieldAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public APOPMOPGCBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5C06470", Offset = "0x5C04C70", VA = "0x185C06470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource NFONCMOPCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource BDIKEHLCLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private CancellationToken? HEALNFJMIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool OGFJHGNGKNL;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool PFLCKDGEJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1BCB950", Offset = "0x1BCA150", VA = "0x181BCB950")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5C12770", Offset = "0x5C10F70", VA = "0x185C12770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C12B20", Offset = "0x5C11320", VA = "0x185C12B20", Slot = "13")]
	public override bool JNCMDDKCPGI(ALKMAGMAGJP NPDJMDFNEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C12CA0", Offset = "0x5C114A0", VA = "0x185C12CA0")]
	[Preserve]
	public OODNOPCOCJN([ACEKLAKDMBL(null)] EPJFONLPCOB EKLPJDMGHDM, [ACEKLAKDMBL(null)] ADBEFBGBKFF HBBMEIHIGKG, [ACEKLAKDMBL(null)] LEPNPLCJECF NEMOLADLBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5C12D90", Offset = "0x5C11590", VA = "0x185C12D90")]
	internal OODNOPCOCJN(EPJFONLPCOB EKLPJDMGHDM, ADBEFBGBKFF HBBMEIHIGKG, LEPNPLCJECF NEMOLADLBNP, MAOHNFLGFIO EIFDNHNCIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5C12840", Offset = "0x5C11040", VA = "0x185C12840", Slot = "17")]
	protected override void DDCHFCKMEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5C12700", Offset = "0x5C10F00", VA = "0x185C12700")]
	private void CJOPAEALNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5C12490", Offset = "0x5C10C90", VA = "0x185C12490", Slot = "16")]
	protected override void BFFFOIDBKFE(ALKMAGMAGJP NEMNNIOAAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5C12B80", Offset = "0x5C11380", VA = "0x185C12B80", Slot = "14")]
	protected override void PLOBJEHJCBM(GBIEDFBPGDA JNAGFANKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5C12680", Offset = "0x5C10E80", VA = "0x185C12680", Slot = "15")]
	protected override void CICCOPPMEDM(GBIEDFBPGDA JNAGFANKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C128E0", Offset = "0x5C110E0", VA = "0x185C128E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NDHKOFBHLNC))]
	private void HKPLDEAPNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5C129C0", Offset = "0x5C111C0", VA = "0x185C129C0", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APOPMOPGCBC))]
	public Task<IReadOnlyDictionary<string, int>> JFJPMMOCJAK([Optional] TimeSpan? BBNJILIHPCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class DFLBHHLIEGP<TNetworking> : FEPEBAKIENM, NFKMNIGHJNH, IDisposable where TNetworking : class, DHBHCBJLDGJ, GNOLCLOPLMD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class MLJGCPFNBLC
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private sealed class <<ConnectToRegionInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public AsyncTaskMethodBuilder<ECFHLMMEAJO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public MLJGCPFNBLC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private ECFHLMMEAJO <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private Exception <ex>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<ECFHLMMEAJO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
			public <<ConnectToRegionInternal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2874DB0", Offset = "0x28735B0", VA = "0x182874DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ECFHLMMEAJO photonServerConnectionInfo;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public MLJGCPFNBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2F955B0", Offset = "0x2F93DB0", VA = "0x182F955B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.MLJGCPFNBLC.<<ConnectToRegionInternal>b__0>d))]
		internal Task<ECFHLMMEAJO> DHDMOFBKKHO(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ODIEKGLDFCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<ECFHLMMEAJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ECFHLMMEAJO photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private MLJGCPFNBLC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool <actionExists>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool <actionMatches>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private global::BHNGFFGEBCE<ECFHLMMEAJO> <newActionData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private ECFHLMMEAJO <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private ECFHLMMEAJO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<ECFHLMMEAJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public ODIEKGLDFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x58D7A10", Offset = "0x58D6210", VA = "0x1858D7A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IEOIPEFECOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<ECFHLMMEAJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ECFHLMMEAJO photonServerConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private AppSettings <settings>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public IEOIPEFECOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0D40", Offset = "0x1C9F540", VA = "0x181CA0D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CBMMILBONFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public CBMMILBONFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A490", Offset = "0x2D48C90", VA = "0x182D4A490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CADHFCGDJHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private GBIEDFBPGDA <actionContext>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public CADHFCGDJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3FC7B60", Offset = "0x3FC6360", VA = "0x183FC7B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JFFAMINLOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public JFFAMINLOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x32F5830", Offset = "0x32F4030", VA = "0x1832F5830")]
		internal Task<bool> POJECCIDDFC(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LMENCHOGNHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private JFFAMINLOKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isCurrentlyOfflineMode>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool <actionExists>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <actionMatches>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private string <debugStr>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private global::BHNGFFGEBCE<bool> <newActionData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public LMENCHOGNHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x49CAEA0", Offset = "0x49C96A0", VA = "0x1849CAEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GPGGPJPOMCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public TaskCompletionSource<MLLLMININAO> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public GPGGPJPOMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6740", Offset = "0x3BB4F40", VA = "0x183BB6740")]
		internal void BDBNJLKGJAE(MLLLMININAO disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3BB67F0", Offset = "0x3BB4FF0", VA = "0x183BB67F0")]
		internal void KCFOBPDAMKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BADJPOMLFGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private GPGGPJPOMCL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<MLLLMININAO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public BADJPOMLFGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4820F00", Offset = "0x481F700", VA = "0x184820F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FGCPJHALEDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<ALKMAGMAGJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public ALKMAGMAGJP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private GBIEDFBPGDA <actionContext>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private object <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private ALKMAGMAGJP <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<ALKMAGMAGJP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public FGCPJHALEDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x35EA720", Offset = "0x35E8F20", VA = "0x1835EA720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HMHBKMNMODB
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private sealed class <<ConnectToRoomInstanceInternal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public AsyncTaskMethodBuilder<ALKMAGMAGJP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public CancellationToken pToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public CancellationToken fToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public HMHBKMNMODB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private ALKMAGMAGJP <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private Exception <ex>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<ALKMAGMAGJP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
			public <<ConnectToRoomInstanceInternal>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2875090", Offset = "0x2873890", VA = "0x182875090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public ALKMAGMAGJP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public object pauseToken;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public HMHBKMNMODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3586220", Offset = "0x3584A20", VA = "0x183586220")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.HMHBKMNMODB.<<ConnectToRoomInstanceInternal>b__0>d))]
		internal Task<ALKMAGMAGJP> KEDLGECAPKP(CancellationToken pToken, CancellationToken fToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JNPLMPEJOPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<ALKMAGMAGJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ALKMAGMAGJP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private HMHBKMNMODB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private bool <actionExists>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private bool <actionMatches>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private string <debugStr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private global::BHNGFFGEBCE<ALKMAGMAGJP> <newActionData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private ALKMAGMAGJP <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private ALKMAGMAGJP <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<ALKMAGMAGJP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public JNPLMPEJOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D18FE0", Offset = "0x3D177E0", VA = "0x183D18FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LGHGIEGCBMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TaskCompletionSource<MOLCOKKIJHG> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public LGHGIEGCBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x49BEE50", Offset = "0x49BD650", VA = "0x1849BEE50")]
		internal void AFKADGOBFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x49BEED0", Offset = "0x49BD6D0", VA = "0x1849BEED0")]
		internal void CGGJHNHAKMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NEKPJBBLJJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AsyncTaskMethodBuilder<ALKMAGMAGJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public ALKMAGMAGJP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private LGHGIEGCBMD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private ECFHLMMEAJO <connectedRegionInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private LKDKDDBBHDN <roomOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private ECFHLMMEAJO <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private IDisposable <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<ECFHLMMEAJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter<MOLCOKKIJHG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public NEKPJBBLJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x29C8100", Offset = "0x29C6900", VA = "0x1829C8100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IHJLMBEBDHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task<CJCAJBEFIJH> whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter<CJCAJBEFIJH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public IHJLMBEBDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1CAF450", Offset = "0x1CADC50", VA = "0x181CAF450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class LHOFDAOOJBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public LHOFDAOOJBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x49C3AF0", Offset = "0x49C22F0", VA = "0x1849C3AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class JDJPDCPNBBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private GBIEDFBPGDA <actionContext>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public JDJPDCPNBBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x32EB3B0", Offset = "0x32E9BB0", VA = "0x1832EB3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EDKLNNIKLOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private object <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public EDKLNNIKLOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x38560F0", Offset = "0x38548F0", VA = "0x1838560F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NPONHICPBBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public NPONHICPBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x453C040", Offset = "0x453A840", VA = "0x18453C040")]
		internal Task<CJCAJBEFIJH> OJCKHOAIPNL(CancellationToken politeCancellationToken, CancellationToken forceCancellationToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class ACIOOMDLOPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private NPONHICPBBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private bool <actionExists>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private bool <actionMatches>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private global::BHNGFFGEBCE<CJCAJBEFIJH> <newData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter<CJCAJBEFIJH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public ACIOOMDLOPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3B98C70", Offset = "0x3B97470", VA = "0x183B98C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class BILFPJALIJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public BILFPJALIJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class FOIGALHMKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TaskCompletionSource<MOLCOKKIJHG> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BILFPJALIJA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public FOIGALHMKHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x36003B0", Offset = "0x35FEBB0", VA = "0x1836003B0")]
		internal void IAHFNFFBGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3600440", Offset = "0x35FEC40", VA = "0x183600440")]
		internal void LLNDEKIMBAA(MLLLMININAO disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3600110", Offset = "0x35FE910", VA = "0x183600110")]
		internal void CJKBMKLPNIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JEIEDOMBMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TaskCompletionSource<MOLCOKKIJHG> reconnectToMasterServerTcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FOIGALHMKHB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public JEIEDOMBMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x32EDBD0", Offset = "0x32EC3D0", VA = "0x1832EDBD0")]
		internal void OLLALGCMKMI(MLLLMININAO disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x32EDB40", Offset = "0x32EC340", VA = "0x1832EDB40")]
		internal void NNAPHLHIOEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EBJCPMPJEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder<CJCAJBEFIJH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken politeCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken forceCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private BILFPJALIJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private bool <wasInRoom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private FOIGALHMKHB <>8__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private JEIEDOMBMKG <>8__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private IDisposable <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter<MOLCOKKIJHG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public EBJCPMPJEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x38500D0", Offset = "0x384E8D0", VA = "0x1838500D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BGFIFNMINMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public TaskCompletionSource<MOLCOKKIJHG> reconnectToMasterServerTcs;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public BGFIFNMINMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D18AD0", Offset = "0x2D172D0", VA = "0x182D18AD0")]
		internal string FDFBOAKHKFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D18B40", Offset = "0x2D17340", VA = "0x182D18B40")]
		internal void MBBMEKCBKDD(MOLCOKKIJHG _1, MOLCOKKIJHG _2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ONEDOHFJGLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AsyncTaskMethodBuilder<MOLCOKKIJHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private BGFIFNMINMO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private MOLCOKKIJHG <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private MOLCOKKIJHG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private TaskAwaiter<MOLCOKKIJHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public ONEDOHFJGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3FE91E0", Offset = "0x3FE79E0", VA = "0x183FE91E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DJGACLBACFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public DJGACLBACFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2F7EF90", Offset = "0x2F7D790", VA = "0x182F7EF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class BLLNMECLJKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public BLLNMECLJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2EF84E0", Offset = "0x2EF6CE0", VA = "0x182EF84E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class BADIGHECKFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public MLLLMININAO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private LBOMDHDFCBJ <exception>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private StringBuilder <logStringBuilder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public BADIGHECKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x48206D0", Offset = "0x481EED0", VA = "0x1848206D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class DPLCDOGCPEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public MLLLMININAO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private StringBuilder <sb>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private HashSet<GJEMCJBNGGN>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private GJEMCJBNGGN <disconnectHandler>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public DPLCDOGCPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A370", Offset = "0x2F88B70", VA = "0x182F8A370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LNBPLOCOFDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private HashSet<OHIJBAKJFCN>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private OHIJBAKJFCN <onLeftRoomHandler>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public LNBPLOCOFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x30D8AC0", Offset = "0x30D72C0", VA = "0x1830D8AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class CNJIOENOMBC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public string timeoutMessage;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public CNJIOENOMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		internal string FOGMOKGKDBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class CJBFLCBJHCG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public Dictionary<string, string> tcsTimeoutData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public LPKIAGLKNEG.PCJLBNNPGAK timeoutMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public CJBFLCBJHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1680", Offset = "0x3AEFE80", VA = "0x183AF1680")]
		internal void PDNCNMNOCFC(string prefix, Dictionary<string, string> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0FA0", Offset = "0x3AEF7A0", VA = "0x183AF0FA0")]
		internal CEGFDCELANM KJPCGPABPMM(TimeSpan timeoutTime)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0F60", Offset = "0x3AEF760", VA = "0x183AF0F60")]
		internal void HKOMDBDHCCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JDOMBBCKIJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public TaskCompletionSource<MOLCOKKIJHG> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public JDOMBBCKIJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x32EB890", Offset = "0x32EA090", VA = "0x1832EB890")]
		internal void PFNCDDGGKFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KNJHLFIGMPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AppSettings appSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public MOLCOKKIJHG connectedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private JDOMBBCKIJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private MOLCOKKIJHG <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private IDisposable <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter<MOLCOKKIJHG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public KNJHLFIGMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4642A10", Offset = "0x4641210", VA = "0x184642A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class PFOPILENABL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public PFOPILENABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x40AA680", Offset = "0x40A8E80", VA = "0x1840AA680")]
		internal object GFMPDMHHECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class BCAKDJCPEMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public BCAKDJCPEMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2D02B00", Offset = "0x2D01300", VA = "0x182D02B00")]
		internal object FINEGCAEOEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HAJHCPOKPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public HAJHCPOKPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3FA97C0", Offset = "0x3FA7FC0", VA = "0x183FA97C0")]
		internal object EOMIPNLEFIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JKEPDDCMIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public global::DFLBHHLIEGP<TNetworking> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public string message;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public JKEPDDCMIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3989F90", Offset = "0x3988790", VA = "0x183989F90")]
		internal object NJOGLPKKPIG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly Hashtable NIHGCEDAALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly MAOHNFLGFIO EIFDNHNCIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly LEPNPLCJECF NEMOLADLBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	protected readonly string CPGELNJBKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	protected readonly ADBEFBGBKFF MKPPPLNJINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private TaskCompletionSource<CJCAJBEFIJH> JOJOOLHMIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[NotNull]
	public readonly JNFDMMGFHOD DNOOPAOIPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	protected internal readonly TNetworking HOCOJIBIFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private ushort CJCPNDFFHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private global::BHNGFFGEBCE<ECFHLMMEAJO> OOLEBFBDENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private global::BHNGFFGEBCE<bool> JAAGDOBJDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private global::BHNGFFGEBCE<ALKMAGMAGJP> LHNNJDJGHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private global::BHNGFFGEBCE<CJCAJBEFIJH> ACECHNCAKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool LAIJFLINHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool OIHGPJIIECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<OHIJBAKJFCN> BKGOEGDFMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly HashSet<GJEMCJBNGGN> CAMMHMGNHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool GHKACLCDPMJ;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LAOBPANCCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5116A20", Offset = "0x5115220", VA = "0x185116A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	[CanBeNull]
	public ALKMAGMAGJP EJPMIOENBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x51169D0", Offset = "0x51151D0", VA = "0x1851169D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected MOLCOKKIJHG NMLCIJHBLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5116FC0", Offset = "0x51157C0", VA = "0x185116FC0")]
		get
		{
			return default(MOLCOKKIJHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	[CanBeNull]
	public string KKAKDAAHNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x51180A0", Offset = "0x51168A0", VA = "0x1851180A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private TimeSpan BEFNPMCJOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5117EE0", Offset = "0x51166E0", VA = "0x185117EE0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private TimeSpan FMNGAJBBKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x51147F0", Offset = "0x5112FF0", VA = "0x1851147F0")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Task KOEBEKFFKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5116A90", Offset = "0x5115290", VA = "0x185116A90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public abstract bool JNCMDDKCPGI(ALKMAGMAGJP NPDJMDFNEOF);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5117DA0", Offset = "0x51165A0", VA = "0x185117DA0")]
	private static TimeSpan PBKGMAILDAB(TimeSpan LCKGGFKFPBM, string BPOKAAOBIOI)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5118660", Offset = "0x5116E60", VA = "0x185118660")]
	protected DFLBHHLIEGP(TNetworking EKLPJDMGHDM, ADBEFBGBKFF HBBMEIHIGKG, string HLGFOKFHPIE, LEPNPLCJECF NEMOLADLBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5118330", Offset = "0x5116B30", VA = "0x185118330")]
	internal DFLBHHLIEGP(TNetworking EKLPJDMGHDM, ADBEFBGBKFF HBBMEIHIGKG, string HLGFOKFHPIE, LEPNPLCJECF NEMOLADLBNP, [Optional] MAOHNFLGFIO EIFDNHNCIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5114500", Offset = "0x5112D00", VA = "0x185114500")]
	private void BBDFFHHFMIC(bool HDCPFIKNJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5116D80", Offset = "0x5115580", VA = "0x185116D80")]
	private void LBEKCEDFFCE(MOLCOKKIJHG KOJPIACGLKD, MOLCOKKIJHG CDMCOCLGECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5115E40", Offset = "0x5114640", VA = "0x185115E40")]
	internal GBIEDFBPGDA ICMKJJCJFJF()
	{
		return default(GBIEDFBPGDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51161F0", Offset = "0x51149F0", VA = "0x1851161F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.ODIEKGLDFCO))]
	private Task<ECFHLMMEAJO> IHHJGAFEHGB(GBIEDFBPGDA JNAGFANKFKL, ECFHLMMEAJO GGNPIMBDEJF, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51171E0", Offset = "0x51159E0", VA = "0x1851171E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.IEOIPEFECOJ))]
	protected Task<ECFHLMMEAJO> NCNLFKCICOP(GBIEDFBPGDA JNAGFANKFKL, ECFHLMMEAJO GGNPIMBDEJF, CancellationToken NMCMJBNJIOD, CancellationToken PEEMFIEFIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5115050", Offset = "0x5113850", VA = "0x185115050")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.CBMMILBONFB))]
	protected Task DLLNFMLPCLE(GBIEDFBPGDA JNAGFANKFKL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5115A10", Offset = "0x5114210", VA = "0x185115A10", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.CADHFCGDJHM))]
	public Task GCOOFIKLMGH([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5117030", Offset = "0x5115830", VA = "0x185117030")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.LMENCHOGNHM))]
	private Task MELJPNDAMML(GBIEDFBPGDA JNAGFANKFKL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5114E80", Offset = "0x5113680", VA = "0x185114E80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.BADJPOMLFGH))]
	private Task<bool> DLCMDPLPJEN(GBIEDFBPGDA JNAGFANKFKL, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5115C50", Offset = "0x5114450", VA = "0x185115C50", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.FGCPJHALEDG))]
	public Task<ALKMAGMAGJP> HONKCHJMJNF(ALKMAGMAGJP NPDJMDFNEOF, object GAEEOLALHAM, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x51177A0", Offset = "0x5115FA0", VA = "0x1851177A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.JNPLMPEJOPO))]
	private Task<ALKMAGMAGJP> ODPMLNBLGAH(GBIEDFBPGDA JNAGFANKFKL, ALKMAGMAGJP NPDJMDFNEOF, object GAEEOLALHAM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5115650", Offset = "0x5113E50", VA = "0x185115650")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.NEKPJBBLJJK))]
	private Task<ALKMAGMAGJP> FJBIHBMEBMH(GBIEDFBPGDA JNAGFANKFKL, ALKMAGMAGJP NPDJMDFNEOF, object GAEEOLALHAM, CancellationToken NMCMJBNJIOD, CancellationToken PEEMFIEFIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5118100", Offset = "0x5116900", VA = "0x185118100")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.IHJLMBEBDHG))]
	private void PPICOEICOAL(Task<CJCAJBEFIJH> PFFFAFOGMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x51175F0", Offset = "0x5115DF0", VA = "0x1851175F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.LHOFDAOOJBH))]
	private Task NODCKJNDDGB(GBIEDFBPGDA JNAGFANKFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5116070", Offset = "0x5114870", VA = "0x185116070", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.JDJPDCPNBBB))]
	public Task IHDGBKMOLDD([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5117AD0", Offset = "0x51162D0", VA = "0x185117AD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.EDKLNNIKLOA))]
	private Task OECHEDCJLGL(GBIEDFBPGDA JNAGFANKFKL, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5115EC0", Offset = "0x51146C0", VA = "0x185115EC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.ACIOOMDLOPI))]
	private Task IEGBGIMEMNH(GBIEDFBPGDA JNAGFANKFKL, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5116B20", Offset = "0x5115320", VA = "0x185116B20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.EBJCPMPJEEO))]
	private Task<CJCAJBEFIJH> KGKILPKAHID(GBIEDFBPGDA JNAGFANKFKL, CancellationToken NMCMJBNJIOD, CancellationToken PEEMFIEFIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x51163F0", Offset = "0x5114BF0", VA = "0x1851163F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.ONEDOHFJGLM))]
	private Task<MOLCOKKIJHG> JCBFPIJAPPK(GBIEDFBPGDA JNAGFANKFKL, CancellationToken GFFFFCALMCA, string FOGMDOMFJBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5117FF0", Offset = "0x51167F0", VA = "0x185117FF0", Slot = "14")]
	protected virtual void PLOBJEHJCBM(GBIEDFBPGDA JNAGFANKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5114900", Offset = "0x5113100", VA = "0x185114900", Slot = "15")]
	protected virtual void CICCOPPMEDM(GBIEDFBPGDA JNAGFANKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5114D00", Offset = "0x5113500", VA = "0x185114D00")]
	private void DFEPFHFBACM(GBIEDFBPGDA JNAGFANKFKL, HIIFBBIFBGG FOGMDOMFJBB, params object[] PFFFGKKOEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "16")]
	protected virtual void BFFFOIDBKFE(ALKMAGMAGJP NEMNNIOAAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x51179D0", Offset = "0x51161D0", VA = "0x1851179D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.DJGACLBACFC))]
	private void OEBNLAHOPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5116E70", Offset = "0x5115670", VA = "0x185116E70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.BLLNMECLJKO))]
	private Task LGINCIGLBFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5117C80", Offset = "0x5116480", VA = "0x185117C80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.BADIGHECKFJ))]
	private void PBHIJHPLFPI(MLLLMININAO PNDKKGJBMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x51158A0", Offset = "0x51140A0", VA = "0x1851158A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.DPLCDOGCPEF))]
	private Task FJLEPAJINBB(MLLLMININAO PNDKKGJBMGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x51143B0", Offset = "0x5112BB0", VA = "0x1851143B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.LNBPLOCOFDD))]
	private Task AHIHAJIKPNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5116D20", Offset = "0x5115520", VA = "0x185116D20", Slot = "10")]
	public void KHDAOHJOOBN(GJEMCJBNGGN DIDFKNPOAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2D5FCF0", Offset = "0x2D5E4F0", VA = "0x182D5FCF0")]
	private TaskCompletionSource<T> FBDKLEMLHPP<T>(GBIEDFBPGDA JNAGFANKFKL, CancellationToken GFFFFCALMCA, TimeSpan OJHABJHLHAL, string NKGPDDKHMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2D5FA90", Offset = "0x2D5E290", VA = "0x182D5FA90")]
	private TaskCompletionSource<T> FBDKLEMLHPP<T>(GBIEDFBPGDA JNAGFANKFKL, CancellationToken GFFFFCALMCA, TimeSpan OJHABJHLHAL, LPKIAGLKNEG.PCJLBNNPGAK NKGPDDKHMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x51145F0", Offset = "0x5112DF0", VA = "0x1851145F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::DFLBHHLIEGP<>.KNJHLFIGMPA))]
	protected Task BOGHOLGLOIP(GBIEDFBPGDA JNAGFANKFKL, AppSettings HNOHEIJIOEM, MOLCOKKIJHG GGPNANIIPMO, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x51151F0", Offset = "0x51139F0", VA = "0x1851151F0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x51149B0", Offset = "0x51131B0", VA = "0x1851149B0", Slot = "17")]
	protected virtual void DDCHFCKMEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5117780", Offset = "0x5115F80", VA = "0x185117780")]
	private static string OCMHHDEABKN(GBIEDFBPGDA JNAGFANKFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x51167E0", Offset = "0x5114FE0", VA = "0x1851167E0")]
	protected void JGIMFEIAGIB(string DKIECHCHJFL, [Optional] GBIEDFBPGDA JNAGFANKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x51165F0", Offset = "0x5114DF0", VA = "0x1851165F0")]
	protected void JCHGICOJJJL(string DKIECHCHJFL, [Optional] GBIEDFBPGDA JNAGFANKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5117400", Offset = "0x5115C00", VA = "0x185117400")]
	protected void NJNHBMLMKAJ(string DKIECHCHJFL, [Optional] GBIEDFBPGDA JNAGFANKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5115450", Offset = "0x5113C50", VA = "0x185115450")]
	protected void FCDHDKBAJAE(string DKIECHCHJFL, Exception BPFOEEABMGN, [Optional] GBIEDFBPGDA JNAGFANKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5115B90", Offset = "0x5114390", VA = "0x185115B90")]
	public void HKBJPKFFCOH(CPDEDBIILFH KBPMOJHNAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x51152A0", Offset = "0x5113AA0", VA = "0x1851152A0")]
	[CompilerGenerated]
	private void EIGGCDNMBIK(DGMDFAOLBNL PMPAEGNHFNK, DGMDFAOLBNL NNIDPOIFFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D5FA60", Offset = "0x2D5E260", VA = "0x182D5FA60")]
	[CompilerGenerated]
	internal static string CJGEMFOKAHA<T>(TimeSpan FMKOGHAFEMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct GBIEDFBPGDA : IEquatable<GBIEDFBPGDA>, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public readonly ushort JFMCNLAMBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public readonly string CPGELNJBKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly DHBHCBJLDGJ EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly Stopwatch BOLLGAMNJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly List<(TimeSpan, MOLCOKKIJHG, MOLCOKKIJHG)> EKHEAGPMDDE;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TimeSpan NIOADANOCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A390", Offset = "0x5C08B90", VA = "0x185C0A390")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IReadOnlyList<(TimeSpan time, MOLCOKKIJHG oldState, MOLCOKKIJHG newState)> KCCBMECKPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A3B0", Offset = "0x5C08BB0", VA = "0x185C0A3B0")]
	public GBIEDFBPGDA(ushort FGJJKANLLJB, string HLGFOKFHPIE, DHBHCBJLDGJ EKLPJDMGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A2D0", Offset = "0x5C08AD0", VA = "0x185C0A2D0")]
	private void IBODPAPICNL(MOLCOKKIJHG KOJPIACGLKD, MOLCOKKIJHG CDMCOCLGECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A290", Offset = "0x5C08A90", VA = "0x185C0A290", Slot = "4")]
	public bool Equals(GBIEDFBPGDA MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A200", Offset = "0x5C08A00", VA = "0x185C0A200", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A2B0", Offset = "0x5C08AB0", VA = "0x185C0A2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A290", Offset = "0x5C08A90", VA = "0x185C0A290")]
	public static bool FMMDKFLNNFA(GBIEDFBPGDA FDMHBFLJJHC, GBIEDFBPGDA DNGDHCADJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A0A0", Offset = "0x5C088A0", VA = "0x185C0A0A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate Task OHIJBAKJFCN();
[Cpp2IlInjected.Token(Token = "0x2000042")]
public delegate Task GJEMCJBNGGN(MLLLMININAO PNDKKGJBMGG);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class ECFHLMMEAJO : IEquatable<ECFHLMMEAJO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public readonly string OPNABNOOHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public readonly string? IOIGEAKNOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public readonly string? PMHNJGKJAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public readonly string? MOIMBHMBEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public readonly string EFLAELLMDMG;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5C09B40", Offset = "0x5C08340", VA = "0x185C09B40")]
	public ECFHLMMEAJO(string POEAFJALKAD, string? MLEJFPDKGAJ, string? CCADBCAKGJB, string? KMFEAJPEJMG, string PLMBHGOJHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5C09AE0", Offset = "0x5C082E0", VA = "0x185C09AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5C09990", Offset = "0x5C08190", VA = "0x185C09990", Slot = "4")]
	public bool Equals(ECFHLMMEAJO? MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5C098B0", Offset = "0x5C080B0", VA = "0x185C098B0", Slot = "0")]
	public override bool Equals(object? HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5C09A20", Offset = "0x5C08220", VA = "0x185C09A20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class ILKPKFGJHDM : KAPPKEOHCJL, JOCGPOGHBJN, LJMJCDNKKIJ, PPCDDHKFBOG, MNHBINHLILC, NOBFKBKEAEI, BNMAJBOOALJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly string HLGFOKFHPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public KBJOPGEOOCH MCBFNFEMMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public KBJOPGEOOCH IONJGFCKODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public global::NAOGJOJMPFD<MLLLMININAO> JIAPNPBMBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public KBJOPGEOOCH APKHONGKLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public global::NAOGJOJMPFD<string> DGOOFIHDNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public global::NAOGJOJMPFD<Dictionary<string, object>> PMAEPEOJDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public global::NAOGJOJMPFD<MLLLMININAO> JJNDLICCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public global::HJMCHKIHGED<bool, bool> MMAGLGLAHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public KBJOPGEOOCH AFLLMIJBKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public KBJOPGEOOCH NECMEFPLKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public KBJOPGEOOCH PPMLDJGGKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public KBJOPGEOOCH IKCENDIIMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public KBJOPGEOOCH DEAPNPOJKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public global::NAOGJOJMPFD<FDHHGKFBMIM> MBONJMKMIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public global::HJMCHKIHGED<PhotonView, FDHHGKFBMIM> LNNABIKLJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public global::KJIOPDDOALH<PhotonView, FDHHGKFBMIM, FDHHGKFBMIM> KPCJIELAMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public global::HJMCHKIHGED<short, string> ABFDKPOJODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public global::NAOGJOJMPFD<Hashtable> DNLIJFPINLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public global::NAOGJOJMPFD<BPAECMKGDAP> HGMENALPHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public global::HJMCHKIHGED<short, string> IMLFHOCBBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public KBJOPGEOOCH BBGOJCDGLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public global::NAOGJOJMPFD<FDHHGKFBMIM> ANENANEMHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public global::NAOGJOJMPFD<FDHHGKFBMIM> EMPPJHLODLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public global::HJMCHKIHGED<FDHHGKFBMIM, Hashtable> AHCEAFACJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public global::HJMCHKIHGED<short, string> BLGGPJIFPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public KBJOPGEOOCH CBJFEFNPIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public KBJOPGEOOCH PFMEOCBGOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public global::NAOGJOJMPFD<OperationResponse> AAKILHHGLAH;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E0F0", Offset = "0x5C0C8F0", VA = "0x185C0E0F0", Slot = "30")]
	public virtual void OnDisconnected(MLLLMININAO LDKGLFHHNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x24CBE80", Offset = "0x24CA680", VA = "0x1824CBE80", Slot = "4")]
	public void OnConnected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DFA0", Offset = "0x5C0C7A0", VA = "0x185C0DFA0", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "7")]
	public void OnRegionListReceived(FGJMLGPECOJ HBPIJPELKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E0A0", Offset = "0x5C0C8A0", VA = "0x185C0E0A0", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E050", Offset = "0x5C0C850", VA = "0x185C0E050", Slot = "9")]
	public void OnCustomAuthenticationFailed(string OFKGLGHEGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E2E0", Offset = "0x5C0CAE0", VA = "0x185C0E2E0", Slot = "10")]
	public void OnPlayerEnteredRoom(FDHHGKFBMIM NNOKMFJPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E340", Offset = "0x5C0CB40", VA = "0x185C0E340", Slot = "11")]
	public void OnPlayerLeftRoom(FDHHGKFBMIM PJFCAJCEEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E410", Offset = "0x5C0CC10", VA = "0x185C0E410", Slot = "12")]
	public void OnRoomPropertiesUpdate(Hashtable JMJNHFOPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E3A0", Offset = "0x5C0CBA0", VA = "0x185C0E3A0", Slot = "13")]
	public void OnPlayerPropertiesUpdate(FDHHGKFBMIM ELEGOCLCPLC, Hashtable GKDAHOCIADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E280", Offset = "0x5C0CA80", VA = "0x185C0E280", Slot = "14")]
	public void OnMasterClientSwitched(FDHHGKFBMIM MIJJDEGFGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x182C670", Offset = "0x182AE70", VA = "0x18182C670", Slot = "15")]
	public void OnJoinedLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x1828220", Offset = "0x1826A20", VA = "0x181828220", Slot = "16")]
	public void OnLeftLobby()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x24CBC10", Offset = "0x24CA410", VA = "0x1824CBC10", Slot = "17")]
	public void OnRoomListUpdate(List<FCLEAHJDDIJ> OFJDHFDBKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x24CBAE0", Offset = "0x24CA2E0", VA = "0x1824CBAE0", Slot = "18")]
	public void OnLobbyStatisticsUpdate(List<KKCOEGKKODI> FJMCNLJHMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x24CBC30", Offset = "0x24CA430", VA = "0x1824CBC30", Slot = "19")]
	public void OnFriendListUpdate(List<ILPBGGKLPEB> DJGIHFAJENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E030", Offset = "0x5C0C830", VA = "0x185C0E030", Slot = "20")]
	public void OnCreatedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DFC0", Offset = "0x5C0C7C0", VA = "0x185C0DFC0", Slot = "21")]
	public void OnCreateRoomFailed(short JMFOHLMJPJC, string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1828C00", Offset = "0x1827400", VA = "0x181828C00", Slot = "22")]
	public void OnJoinedRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E1F0", Offset = "0x5C0C9F0", VA = "0x185C0E1F0", Slot = "23")]
	public void OnJoinRoomFailed(short JMFOHLMJPJC, string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E180", Offset = "0x5C0C980", VA = "0x185C0E180", Slot = "24")]
	public void OnJoinRandomFailed(short JMFOHLMJPJC, string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E260", Offset = "0x5C0CA60", VA = "0x185C0E260", Slot = "25")]
	public void OnLeftRoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DEC0", Offset = "0x5C0C6C0", VA = "0x185C0DEC0", Slot = "29")]
	public void KJBAILEGKCH(BPAECMKGDAP BNKIEKDIHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DF30", Offset = "0x5C0C730", VA = "0x185C0DF30", Slot = "26")]
	public void OPMIDGKGCJK(PhotonView DLCPPBBANMC, FDHHGKFBMIM AEEBHLKEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DE30", Offset = "0x5C0C630", VA = "0x185C0DE30", Slot = "27")]
	public void JAJKBJHCDKE(PhotonView DLCPPBBANMC, FDHHGKFBMIM OGHDEOELJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E470", Offset = "0x5C0CC70", VA = "0x185C0E470", Slot = "28")]
	public void OnWebRpcResponse(OperationResponse CMAOBCBOEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5C0E4D0", Offset = "0x5C0CCD0", VA = "0x185C0E4D0")]
	public ILKPKFGJHDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class BJDFMJKKELJ : global::DFLBHHLIEGP<BJDFMJKKELJ.JPALHKJIJGF>
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface OECGNMAGBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MCBEKOBELPH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class JPALHKJIJGF : DHBHCBJLDGJ, GNOLCLOPLMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private DGMDFAOLBNL KFMACPCPNLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private bool KPGPAMOGJBN;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private PhotonVoiceNetwork MJDKGCDIMHN
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x5C107A0", Offset = "0x5C0EFA0", VA = "0x185C107A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool BIDKDNOELMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x17CC210", Offset = "0x17CAA10", VA = "0x1817CC210", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public DGMDFAOLBNL MHKIIBFLFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool ECPPDPEEEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x5C10BA0", Offset = "0x5C0F3A0", VA = "0x185C10BA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool BAAOGMEPFMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x5C10620", Offset = "0x5C0EE20", VA = "0x185C10620", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x95B500", Offset = "0x959D00", VA = "0x18095B500", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool DLELAGHEFGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool LAOBPANCCJP
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x5C10C90", Offset = "0x5C0F490", VA = "0x185C10C90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public OAOBMBOAHMN MEPANAMHEAG
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x5C10CE0", Offset = "0x5C0F4E0", VA = "0x185C10CE0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool MCDGHCEDJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x5C10F80", Offset = "0x5C0F780", VA = "0x185C10F80", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<DGMDFAOLBNL, DGMDFAOLBNL> PFJOHPIOPLN
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x5C10580", Offset = "0x5C0ED80", VA = "0x185C10580", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x5C10BF0", Offset = "0x5C0F3F0", VA = "0x185C10BF0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<bool> IOFGIAHKHGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5C10800", Offset = "0x5C0F000", VA = "0x185C10800", Slot = "9")]
		public void GBAOOILFPIJ(CPDEDBIILFH INFJLDIINGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5C110B0", Offset = "0x5C0F8B0", VA = "0x185C110B0", Slot = "16")]
		public bool POIDEHOOANO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5C10A00", Offset = "0x5C0F200", VA = "0x185C10A00", Slot = "17")]
		public bool GEDPJPOFHMO(string KEGJMIDPONL, LKDKDDBBHDN FKDCDHPANOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5C108E0", Offset = "0x5C0F0E0", VA = "0x185C108E0", Slot = "18")]
		public void GCOOFIKLMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5C10DD0", Offset = "0x5C0F5D0", VA = "0x185C10DD0", Slot = "19")]
		public bool MGONOMMEPLO(AppSettings HNOHEIJIOEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "22")]
		public void ILNAGFHCFLP(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "23")]
		public void BBNPAOAMKNC(object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "24")]
		public void GBOFAFGNPKK(object FLDJLPKNKKO, bool ALPKOFENEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5C10F20", Offset = "0x5C0F720", VA = "0x185C10F20", Slot = "25")]
		public IDisposable PAOHMNBKIOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F35F0", Offset = "0x7F1DF0", VA = "0x1807F35F0", Slot = "26")]
		private bool CGEGBBJAMFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "27")]
		public void LNOIMNGJBMF(StringBuilder OJPAJPKNCIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5C10690", Offset = "0x5C0EE90", VA = "0x185C10690", Slot = "28")]
		public bool FKEFOKOCIDM(bool INOACBMBDNM, out string FKPBDLDGFCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xBC0DE0", Offset = "0xBBF5E0", VA = "0x180BC0DE0")]
		public JPALHKJIJGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class CAKBCMBIGCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public OODNOPCOCJN clientToFollow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public BJDFMJKKELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter<ALKMAGMAGJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CAKBCMBIGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5C08720", Offset = "0x5C06F20", VA = "0x185C08720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class MPHOECFOPMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public BJDFMJKKELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MPHOECFOPMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5C11850", Offset = "0x5C10050", VA = "0x185C11850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly OODNOPCOCJN CLDJMJIFMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly OECGNMAGBEL IEIHLEGDHCA;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5C08320", Offset = "0x5C06B20", VA = "0x185C08320", Slot = "13")]
	public override bool JNCMDDKCPGI(ALKMAGMAGJP NPDJMDFNEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5C08440", Offset = "0x5C06C40", VA = "0x185C08440")]
	[Preserve]
	public BJDFMJKKELJ([ACEKLAKDMBL(null)] OODNOPCOCJN CLDJMJIFMIL, [ACEKLAKDMBL(null)] ADBEFBGBKFF HBBMEIHIGKG, [ACEKLAKDMBL(null)] OECGNMAGBEL IEIHLEGDHCA, [ACEKLAKDMBL(null)] LEPNPLCJECF NEMOLADLBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5C07FF0", Offset = "0x5C067F0", VA = "0x185C07FF0")]
	private Task HIFKGPBGJDN(MLLLMININAO PNDKKGJBMGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5C081D0", Offset = "0x5C069D0", VA = "0x185C081D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CAKBCMBIGCE))]
	public Task IKPIMKLLBHK(OODNOPCOCJN ODCEABIEOCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5C083B0", Offset = "0x5C06BB0", VA = "0x185C083B0")]
	[CompilerGenerated]
	internal static void KIMAAAFGNFF(DGMDFAOLBNL PMPAEGNHFNK, DGMDFAOLBNL NNIDPOIFFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5C07ED0", Offset = "0x5C066D0", VA = "0x185C07ED0")]
	[CompilerGenerated]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MPHOECFOPMI))]
	private Task BABCCPGAEJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class IJHKEMEMIGD
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2437B30", Offset = "0x2436330", VA = "0x182437B30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HHONHGJMPID))]
	public static Task LBJODMCHGJG<TArgs>(this global::BHNGFFGEBCE<TArgs> BCHABJMPLGL, [Optional] GBIEDFBPGDA FDENFADGFPH) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2437E40", Offset = "0x2436640", VA = "0x182437E40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OJHKBEFGMMB))]
	public static Task MEHPLBLMHCO<TArgs>(this global::BHNGFFGEBCE<TArgs> BCHABJMPLGL, TimeSpan DBMHBGFOOLI, [Optional] GBIEDFBPGDA FDENFADGFPH) where TArgs : IEquatable<TArgs>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2437770", Offset = "0x2435F70", VA = "0x182437770")]
	public static (bool, bool) JMJKCMAKDMA<TArgs>(this global::BHNGFFGEBCE<TArgs> BCHABJMPLGL, TArgs CBHLPGJGAKG, out string DOBHIEBEEAB) where TArgs : IEquatable<TArgs>
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2437430", Offset = "0x2435C30", VA = "0x182437430")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCDIICOEKDF))]
	public static Task<TArgs> HCCOCIKJGOK<TArgs>(this global::BHNGFFGEBCE<TArgs> BCHABJMPLGL, TArgs CBHLPGJGAKG, CancellationToken CNAPKECCCPI) where TArgs : IEquatable<TArgs>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class BHNGFFGEBCE<TArgs> : IDisposable where TArgs : IEquatable<TArgs>
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate Task<TArgs> OKDJCBENHEA(CancellationToken OCIKCCCHBGJ, CancellationToken LOBKLAKHIBP);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class GIEKKGKGHHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public TimeSpan forceCancelAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public GBIEDFBPGDA doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public global::BHNGFFGEBCE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public GIEKKGKGHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2BE1190", Offset = "0x2BDF990", VA = "0x182BE1190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class PFMOMGMBBAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public GBIEDFBPGDA doesNotMatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public global::BHNGFFGEBCE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public PFMOMGMBBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x40AA160", Offset = "0x40A8960", VA = "0x1840AA160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class IGFOCAMJFKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public global::BHNGFFGEBCE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public IGFOCAMJFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1CA6790", Offset = "0x1CA4F90", VA = "0x181CA6790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class DBJGAIPMHOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public OKDJCBENHEA taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public global::BHNGFFGEBCE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private CancellationTokenSource <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private CancellationTokenSource <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Task<TArgs> <wrappedTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private TArgs <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public DBJGAIPMHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3DA46D0", Offset = "0x3DA2ED0", VA = "0x183DA46D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MLMCEFLGABI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AsyncTaskMethodBuilder<TArgs> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Task<TArgs> wrappedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public global::BHNGFFGEBCE<TArgs> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private TArgs <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TArgs <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter<TArgs> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public MLMCEFLGABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2F965F0", Offset = "0x2F94DF0", VA = "0x182F965F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private bool MHKMOODMJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private bool BGMMDFLPOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private CancellationTokenSource GAMKKDIEAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private CancellationTokenSource OOHCCFFEJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly GBIEDFBPGDA JNAGFANKFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly CancellationToken KHEICKPBIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly TArgs CBHLPGJGAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private TArgs PHCHNDIKPIO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TArgs NIBFGHDNPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2EED570", Offset = "0x2EEBD70", VA = "0x182EED570")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public TArgs DCOIEKLHINM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2EEDBD0", Offset = "0x2EEC3D0", VA = "0x182EEDBD0")]
		get
		{
			return (TArgs)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	[CanBeNull]
	public Task<TArgs> BLHLPKEOBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8C35F0", Offset = "0x8C1DF0", VA = "0x1808C35F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9130B0", Offset = "0x9118B0", VA = "0x1809130B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2EEFE00", Offset = "0x2EEE600", VA = "0x182EEFE00")]
	public BHNGFFGEBCE(TArgs ICOHHMIAEFN, CancellationToken KHEICKPBIBD, GBIEDFBPGDA JNAGFANKFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDF20", Offset = "0x2EEC720", VA = "0x182EEDF20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::BHNGFFGEBCE<>.GIEKKGKGHHC))]
	public Task GIKLFEEJJGL(TimeSpan MKJCHLJCMJI, GBIEDFBPGDA GCFPIEOAGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF070", Offset = "0x2EED870", VA = "0x182EEF070")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::BHNGFFGEBCE<>.PFMOMGMBBAL))]
	public Task JPOGFMPNMFA(GBIEDFBPGDA GCFPIEOAGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2EED590", Offset = "0x2EEBD90", VA = "0x182EED590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDA70", Offset = "0x2EEC270", VA = "0x182EEDA70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::BHNGFFGEBCE<>.IGFOCAMJFKH))]
	private Task FCJPPPELIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2EEED10", Offset = "0x2EED510", VA = "0x182EEED10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::BHNGFFGEBCE<>.DBJGAIPMHOK))]
	public Task<TArgs> HHEAEHEDNEN(OKDJCBENHEA KCGDKEGFBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF3B0", Offset = "0x2EEDBB0", VA = "0x182EEF3B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::BHNGFFGEBCE<>.MLMCEFLGABI))]
	private Task<TArgs> MLMDHBPPFFD(Task<TArgs> ACEGPIHAANB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2EEFBE0", Offset = "0x2EEE3E0", VA = "0x182EEFBE0")]
	public bool NPIGCCGHNAK(TArgs PNFGEIHGKNE, out string DOBHIEBEEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE310", Offset = "0x2EECB10", VA = "0x182EEE310")]
	private bool GMJGAIIIEMO(TArgs PNFGEIHGKNE, out string DOBHIEBEEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF9B0", Offset = "0x2EEE1B0", VA = "0x182EEF9B0")]
	public void NLKIFPPDDDB(CancellationToken GFFFFCALMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2EEF390", Offset = "0x2EEDB90", VA = "0x182EEF390")]
	[CompilerGenerated]
	private void MKFBOKEBGID()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct CJCAJBEFIJH : IEquatable<CJCAJBEFIJH>
{
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static readonly CJCAJBEFIJH OAEIAFEPBFB;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x812950", Offset = "0x811150", VA = "0x180812950", Slot = "4")]
	public bool Equals(CJCAJBEFIJH MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5C08D30", Offset = "0x5C07530", VA = "0x185C08D30", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x83C8F0", Offset = "0x83B0F0", VA = "0x18083C8F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class CPCMNEBONPC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5C08DE0", Offset = "0x5C075E0", VA = "0x185C08DE0")]
	public CPCMNEBONPC(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5C08E50", Offset = "0x5C07650", VA = "0x185C08E50")]
	public CPCMNEBONPC(string DKIECHCHJFL, Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class FMCLIFFJLDJ : CPCMNEBONPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public readonly string LPFOILLOGCB;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5C09D70", Offset = "0x5C08570", VA = "0x185C09D70")]
	public FMCLIFFJLDJ(string GNGADHFNOHB, [NotNull] Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GBDAEOCHCAP : CPCMNEBONPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public readonly ALKMAGMAGJP DJDKLDKGPAE;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5C09F80", Offset = "0x5C08780", VA = "0x185C09F80")]
	public GBDAEOCHCAP(ALKMAGMAGJP EOMPAOMNNPF, [NotNull] Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class PMBFCIKJMMA : CPCMNEBONPC
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5C08DE0", Offset = "0x5C075E0", VA = "0x185C08DE0")]
	public PMBFCIKJMMA(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LBOMDHDFCBJ : CPCMNEBONPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public readonly StatusCode? MCDLKGACDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public readonly MLLLMININAO MACHFHAFMGF;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5C114B0", Offset = "0x5C0FCB0", VA = "0x185C114B0")]
	public LBOMDHDFCBJ(MLLLMININAO PNDKKGJBMGG, Exception NCFNHKNLKKM, StatusCode? KJLDDGCFMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5C111F0", Offset = "0x5C0F9F0", VA = "0x185C111F0")]
	public static LBOMDHDFCBJ HMLIEODJFMD(MLLLMININAO LDKGLFHHNAD, DGMDFAOLBNL FPMHOPKIBCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DMLOJOHHFHJ : CPCMNEBONPC
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5C08DE0", Offset = "0x5C075E0", VA = "0x185C08DE0")]
	public DMLOJOHHFHJ(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PFIHIEMGNOH : CPCMNEBONPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public readonly short JOOMDEJHLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public readonly string CCJMBOGDOPD;

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5C12E80", Offset = "0x5C11680", VA = "0x185C12E80")]
	public PFIHIEMGNOH(short EGMEOIADPFI, string OJIGDJMNHCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DJFADNFMHBN : CPCMNEBONPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public readonly short JOOMDEJHLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public readonly string CCJMBOGDOPD;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5C092C0", Offset = "0x5C07AC0", VA = "0x185C092C0")]
	public DJFADNFMHBN(short EGMEOIADPFI, string OJIGDJMNHCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class NDAJACNFDOH : CPCMNEBONPC
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5C08DE0", Offset = "0x5C075E0", VA = "0x185C08DE0")]
	public NDAJACNFDOH(string DKIECHCHJFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NMAOHGFFGMI : CPCMNEBONPC
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5C12370", Offset = "0x5C10B70", VA = "0x185C12370")]
	public NMAOHGFFGMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CEGFDCELANM : HIBDKLHBKLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public readonly Dictionary<string, string> DCLNGICOLOO;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5C08A20", Offset = "0x5C07220", VA = "0x185C08A20")]
	public CEGFDCELANM(TimeSpan OJHABJHLHAL, string DKIECHCHJFL, Dictionary<string, string> LOJDMHGAGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class ALKMAGMAGJP : ECFHLMMEAJO, IEquatable<ALKMAGMAGJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public readonly string FMMECANCDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public readonly bool JJLEKPPGGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public readonly string? COJPKPMLLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly string? LFMFKCCLPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly bool HAKPBEEEIAE;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5C06290", Offset = "0x5C04A90", VA = "0x185C06290")]
	public ALKMAGMAGJP(string POEAFJALKAD, string MLEJFPDKGAJ, string CCADBCAKGJB, string? KMFEAJPEJMG, string PLMBHGOJHBK, string KEGJMIDPONL, string? OPNPHEHBHGD, string? NOICCPPOGPI, bool GGKMJAOPNGC, bool HEDMLNDLPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5C06210", Offset = "0x5C04A10", VA = "0x185C06210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5C06060", Offset = "0x5C04860", VA = "0x185C06060", Slot = "5")]
	public bool Equals(ALKMAGMAGJP? MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5C05F40", Offset = "0x5C04740", VA = "0x185C05F40", Slot = "0")]
	public override bool Equals(object? HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5C060E0", Offset = "0x5C048E0", VA = "0x185C060E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1949400", Offset = "0x1947C00", VA = "0x181949400")]
	public static bool FMMDKFLNNFA(ALKMAGMAGJP? FDMHBFLJJHC, ALKMAGMAGJP? DNGDHCADJJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1948FD0", Offset = "0x19477D0", VA = "0x181948FD0")]
	public static bool BDPOAMCDIDB(ALKMAGMAGJP? FDMHBFLJJHC, ALKMAGMAGJP? DNGDHCADJJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface NFKMNIGHJNH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ALKMAGMAGJP EJPMIOENBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string KKAKDAAHNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Task KOEBEKFFKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JNCMDDKCPGI(ALKMAGMAGJP NPDJMDFNEOF);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GCOOFIKLMGH([Optional] CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<ALKMAGMAGJP> HONKCHJMJNF(ALKMAGMAGJP NPDJMDFNEOF, object GAEEOLALHAM, [Optional] CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IHDGBKMOLDD([Optional] CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KHDAOHJOOBN(GJEMCJBNGGN DIDFKNPOAGK);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal static class IPIEGIMCILN
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class MMIJLOKDJOM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public Action<string, GBIEDFBPGDA> log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public DGMDFAOLBNL networkClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public bool region;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public JNFDMMGFHOD photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public MMIJLOKDJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0360", Offset = "0x2F9EB60", VA = "0x182FA0360")]
		internal void KDCNNJAMGNL(MLLLMININAO disconnectCause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FF20", Offset = "0x2F9E720", VA = "0x182F9FF20")]
		internal void BIAIANPBBNG(string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2FA01E0", Offset = "0x2F9E9E0", VA = "0x182FA01E0")]
		internal void FHBEFAALIKH(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class ICBDCPPNOJK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public ILKPKFGJHDM photonCallbacks;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public ICBDCPPNOJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x51F5B90", Offset = "0x51F4390", VA = "0x1851F5B90")]
		internal void GJDAFNCEMON(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x51F5A30", Offset = "0x51F4230", VA = "0x1851F5A30")]
		internal void GDLHKMBCEAA(short errorCode, string debugMsg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x51F58E0", Offset = "0x51F40E0", VA = "0x1851F58E0")]
		internal void FIHKKKGKMAI(Task<T> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x243B5D0", Offset = "0x2439DD0", VA = "0x18243B5D0")]
	public static void HOOMCPGDGOK<T>(this JNFDMMGFHOD CKGHOFPICHO, TaskCompletionSource<T> FGGMEEAOJKP, [NotNull] DGMDFAOLBNL FPMHOPKIBCG, GBIEDFBPGDA JNAGFANKFKL, bool BEHMCPKLDHM, Action<string, GBIEDFBPGDA> HGFFDKCANPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x243BC10", Offset = "0x243A410", VA = "0x18243BC10")]
	public static void POHAHAMEMPG<T>(this ILKPKFGJHDM CKGHOFPICHO, TaskCompletionSource<T> FGGMEEAOJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class GIJKKLNMOKB : FEPEBAKIENM, NFKMNIGHJNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum PCGEDMHDNAD
	{
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		Disconnected,
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		Connected
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private NetworkManager FENGIIHLKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private TaskCompletionSource<ALKMAGMAGJP> MMMJOAGCKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	protected readonly ADBEFBGBKFF OJNMEBGBKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private readonly HashSet<GJEMCJBNGGN> CAMMHMGNHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public PCGEDMHDNAD PNPIHEBMMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ALKMAGMAGJP NPDJMDFNEOF;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly string[] OBJGMAOFLOD;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly string[] BAINFMABECG;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly string[] ACKKHBLNCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private RSACryptoServiceProvider ECJDIGALMBO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ALKMAGMAGJP EJPMIOENBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAF2320", Offset = "0xAF0B20", VA = "0x180AF2320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string KKAKDAAHNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C010", Offset = "0x5C0A810", VA = "0x185C0C010", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task KOEBEKFFKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0BCD0", Offset = "0x5C0A4D0", VA = "0x185C0BCD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5C0BD10", Offset = "0x5C0A510", VA = "0x185C0BD10", Slot = "10")]
	public void KHDAOHJOOBN(GJEMCJBNGGN DIDFKNPOAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5C0BC80", Offset = "0x5C0A480", VA = "0x185C0BC80", Slot = "6")]
	public bool JNCMDDKCPGI(ALKMAGMAGJP NPDJMDFNEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5C0C3D0", Offset = "0x5C0ABD0", VA = "0x185C0C3D0")]
	[Preserve]
	public GIJKKLNMOKB([ACEKLAKDMBL(null)] ADBEFBGBKFF FIKAEKDJEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5C0AE90", Offset = "0x5C09690", VA = "0x185C0AE90")]
	private void HMNLGCABKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A610", Offset = "0x5C08E10", VA = "0x185C0A610")]
	private void AIPMOBIEHHB(ulong HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5C0A910", Offset = "0x5C09110", VA = "0x185C0A910")]
	private void ENPJPJDMGGA(ulong HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5C0BF10", Offset = "0x5C0A710", VA = "0x185C0BF10")]
	private void PEEGINIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5C0ACF0", Offset = "0x5C094F0", VA = "0x185C0ACF0")]
	private void GBJEANODAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5C0AA60", Offset = "0x5C09260", VA = "0x185C0AA60")]
	private void FPIFJOHMPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5C0BD70", Offset = "0x5C0A570", VA = "0x185C0BD70")]
	private static (IPAddress, ushort) OHCELCBFDNJ(string IFFHFIIEICL)
	{
		return default((IPAddress, ushort));
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5C0B070", Offset = "0x5C09870", VA = "0x185C0B070", Slot = "8")]
	public Task<ALKMAGMAGJP> HONKCHJMJNF(ALKMAGMAGJP NPDJMDFNEOF, object GAEEOLALHAM, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5C0AD60", Offset = "0x5C09560", VA = "0x185C0AD60", Slot = "7")]
	public Task GCOOFIKLMGH([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5C0BB50", Offset = "0x5C0A350", VA = "0x185C0BB50", Slot = "9")]
	public Task IHDGBKMOLDD([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal interface MAOHNFLGFIO
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFEPFHFBACM(ushort FGJJKANLLJB, HIIFBBIFBGG FONNAJLMKOM, params object[] MJHMGBNMLHB);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal enum HIIFBBIFBGG
{
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Disconnect_AlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Disconnect_AlreadyDisconnected,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	DisconnectInternal,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	DisconnectInternalTask,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	DisconnectInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	DisconnectFromRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	DisconnectFromRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	DisconnectFromRoomInstance_LeavingAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	DisconnectFromRoomInstance_AlreadyLeftRoom,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	DisconnectFromRoomInstanceInternal_BeforeLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	DisconnectFromRoomInstanceInternal_AfterLeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	DisconnectFromRoomInstanceInternal_LeaveRoom,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	DisconnectFromRoomInstanceInternal_NothingToDo,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	ConnectToRegion,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	ConnectToRegion_AddedAuthValues,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	ConnectToRegion_ConnectToRegionInternal,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	ConnectToRegion_ConnectToRegionInternalTask,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	ConnectToRegion_EnteredOfflineMode,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	ConnectToRegion_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	ConnectToRegion_AlreadyConnected,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	ConnectToRegion_DisconnectDueToCancellation,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	ConnectToRegion_DisconnectDueToError,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	ConnectToRegion_Connected,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	ConnectWithAppSettings,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	ConnectToRoomInstance,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	ConnectToRoomInstance_ConnectionAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	ConnectToRoomInstance_AlreadyInRoom,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	ConnectToRoomInstanceInternal,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	ConnectToRoomInstanceInternal_Connected
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface GHOMLKKKKHM : NFKMNIGHJNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DBDNKFALDNM NEOCHEJHKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JHJAOHBMFGP : DGMDFAOLBNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private readonly CPDEDBIILFH INHFBHCDIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private readonly Func<JHJAOHBMFGP, bool> FBFBDALHLDB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MOLCOKKIJHG NMLCIJHBLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F4A0", Offset = "0x5C0DCA0", VA = "0x185C0F4A0", Slot = "4")]
		get
		{
			return default(MOLCOKKIJHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NPHMCNPJLDM HOCDGPFNDAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F420", Offset = "0x5C0DC20", VA = "0x185C0F420", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LAOBPANCCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F400", Offset = "0x5C0DC00", VA = "0x185C0F400", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ECPPDPEEEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F300", Offset = "0x5C0DB00", VA = "0x185C0F300", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool IGDOKHOOFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F160", Offset = "0x5C0D960", VA = "0x185C0F160", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Exception IBPMFKAGEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F2E0", Offset = "0x5C0DAE0", VA = "0x185C0F2E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public StatusCode MCDLKGACDII
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F4C0", Offset = "0x5C0DCC0", VA = "0x185C0F4C0", Slot = "16")]
		get
		{
			return default(StatusCode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event CPDEDBIILFH.OFBOMJAMPKF HAHFPDLJMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F220", Offset = "0x5C0DA20", VA = "0x185C0F220", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F3E0", Offset = "0x5C0DBE0", VA = "0x185C0F3E0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<MOLCOKKIJHG, MOLCOKKIJHG> OJGJCMKNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F340", Offset = "0x5C0DB40", VA = "0x185C0F340", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0F240", Offset = "0x5C0DA40", VA = "0x185C0F240", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F4E0", Offset = "0x5C0DCE0", VA = "0x185C0F4E0")]
	public JHJAOHBMFGP(CPDEDBIILFH INHFBHCDIFG, [Optional] Func<JHJAOHBMFGP, bool> FBFBDALHLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F180", Offset = "0x5C0D980", VA = "0x185C0F180", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F440", Offset = "0x5C0DC40", VA = "0x185C0F440")]
	private void LBECFNIGFDI(MOLCOKKIJHG KOJPIACGLKD, MOLCOKKIJHG CDMCOCLGECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F320", Offset = "0x5C0DB20", VA = "0x185C0F320", Slot = "13")]
	public void IJIEHKIAFOI(object CBHLPGJGAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F140", Offset = "0x5C0D940", VA = "0x185C0F140", Slot = "14")]
	public void BGDMMGPBNCH(object CBHLPGJGAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface FEPEBAKIENM : NFKMNIGHJNH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface LEPNPLCJECF
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKJGCJELDBJ(string HLGFOKFHPIE, string HAGLOFMLLNF, GBIEDFBPGDA JNAGFANKFKL, [Optional] string LOJDMHGAGAM);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MANOAIPGPIB(string HLGFOKFHPIE, string HAGLOFMLLNF, GBIEDFBPGDA JNAGFANKFKL, [Optional] string LOJDMHGAGAM);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNIOAJEFAAL(string HLGFOKFHPIE, string HAGLOFMLLNF, GBIEDFBPGDA JNAGFANKFKL, [Optional] string LOJDMHGAGAM);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDHPCIGKKHH(string HLGFOKFHPIE, string HAGLOFMLLNF, GBIEDFBPGDA JNAGFANKFKL, Exception LNDIIAIJNMN, [Optional] string LOJDMHGAGAM);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGCBJICGKKH(string HLGFOKFHPIE, LBOMDHDFCBJ GHAKDBNMDLL);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal static class LNPCGNICNJE
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class JDNEGFFPHFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public LEPNPLCJECF analytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public string clientName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public string actionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public GBIEDFBPGDA actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public string additionalInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public JDNEGFFPHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0EC80", Offset = "0x5C0D480", VA = "0x185C0EC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3557CD0", Offset = "0x35564D0", VA = "0x183557CD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GLLIOGCMNJJ))]
	public static Task<T> JDNGOFFJNDO<T>(this Task<T> GAKDIIFBLNI, [CanBeNull] LEPNPLCJECF NEMOLADLBNP, string HLGFOKFHPIE, string HAGLOFMLLNF, GBIEDFBPGDA JNAGFANKFKL, [Optional] string LOJDMHGAGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5C11650", Offset = "0x5C0FE50", VA = "0x185C11650")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JDNEGFFPHFC))]
	public static Task JDNGOFFJNDO(this Task GAKDIIFBLNI, [CanBeNull] LEPNPLCJECF NEMOLADLBNP, string HLGFOKFHPIE, string HAGLOFMLLNF, GBIEDFBPGDA JNAGFANKFKL, [Optional] string LOJDMHGAGAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JJACJPLGAPP : GHOMLKKKKHM, NFKMNIGHJNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class ACMILFOHLLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public ALKMAGMAGJP targetRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ACMILFOHLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5C05E80", Offset = "0x5C04680", VA = "0x185C05E80")]
		internal bool NBDPOAMNIPK(FEPEBAKIENM c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class FFDBKOFEEEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FFDBKOFEEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5C09D10", Offset = "0x5C08510", VA = "0x185C09D10")]
		internal Task KHKIFHJBHGG(FEPEBAKIENM c)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class NGBCFBDLLCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public JJACJPLGAPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private FFDBKOFEEEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private IEnumerable<Task> <tasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NGBCFBDLLCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5C120A0", Offset = "0x5C108A0", VA = "0x185C120A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class DOIGPJILGLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<ALKMAGMAGJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public ALKMAGMAGJP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public object pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public JJACJPLGAPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private ALKMAGMAGJP <result>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private ALKMAGMAGJP <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private TaskAwaiter<ALKMAGMAGJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DOIGPJILGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5C093B0", Offset = "0x5C07BB0", VA = "0x185C093B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class HJJNDKDNFLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HJJNDKDNFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5C0DD40", Offset = "0x5C0C540", VA = "0x185C0DD40")]
		internal Task MCGLHINDBNB(FEPEBAKIENM c)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class CIGFGAFAFEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public JJACJPLGAPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private HJJNDKDNFLB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private IEnumerable<Task> <tasks>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CIGFGAFAFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5C08A60", Offset = "0x5C07260", VA = "0x185C08A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public readonly OODNOPCOCJN NEOCHEJHKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public readonly BJDFMJKKELJ MELBNMDIAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private readonly FEPEBAKIENM[] NKCBIIAIPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public readonly GIJKKLNMOKB HDLMMILNCKD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public ALKMAGMAGJP EJPMIOENBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0FC70", Offset = "0x5C0E470", VA = "0x185C0FC70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string KKAKDAAHNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0FF30", Offset = "0x5C0E730", VA = "0x185C0FF30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private IEnumerable<FEPEBAKIENM> NOAPDPDIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0FC30", Offset = "0x5C0E430", VA = "0x185C0FC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private DBDNKFALDNM GHHOBLEBCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Task KOEBEKFFKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0FDB0", Offset = "0x5C0E5B0", VA = "0x185C0FDB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FCC0", Offset = "0x5C0E4C0", VA = "0x185C0FCC0", Slot = "7")]
	public bool JNCMDDKCPGI(ALKMAGMAGJP NPDJMDFNEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FF80", Offset = "0x5C0E780", VA = "0x185C0FF80")]
	[Preserve]
	public JJACJPLGAPP([ACEKLAKDMBL(null)] OODNOPCOCJN CLDJMJIFMIL, [ACEKLAKDMBL(null)] BJDFMJKKELJ INFJLDIINGH, [ACEKLAKDMBL(null)] GIJKKLNMOKB JPIKCOFJHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F7D0", Offset = "0x5C0DFD0", VA = "0x185C0F7D0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NGBCFBDLLCL))]
	public Task GCOOFIKLMGH([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F920", Offset = "0x5C0E120", VA = "0x185C0F920", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DOIGPJILGLH))]
	public Task<ALKMAGMAGJP> HONKCHJMJNF(ALKMAGMAGJP NPDJMDFNEOF, object GAEEOLALHAM, [Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FAE0", Offset = "0x5C0E2E0", VA = "0x185C0FAE0", Slot = "10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CIGFGAFAFEA))]
	public Task IHDGBKMOLDD([Optional] CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F5C0", Offset = "0x5C0DDC0", VA = "0x185C0F5C0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FE00", Offset = "0x5C0E600", VA = "0x185C0FE00", Slot = "11")]
	public void KHDAOHJOOBN(GJEMCJBNGGN DIDFKNPOAGK)
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
