using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84720E0", Offset = "0x84714E0", VA = "0x1884720E0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Type[] bindTypeSet3;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2353DC0", Offset = "0x23531C0", VA = "0x182353DC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8473AB0", Offset = "0x8472EB0", VA = "0x188473AB0")]
		private void GBFKFENBIAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8473E90", Offset = "0x8473290", VA = "0x188473E90")]
		private void NKKCCHCKNGM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84741B0", Offset = "0x84735B0", VA = "0x1884741B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8474260", Offset = "0x8473660", VA = "0x188474260")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(EMEFAIEEHNG), new string[] { "Photon" })]
public class BBHECHLFNHB : EMEFAIEEHNG
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class DBIKOCFFHBM : KMOGAEBEGPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public APFDEDCIGGF FCGKHKJBFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode DFGEBBMFJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public BJLPNOFKLJC JBLFDCNMAKI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public FMGMOFJMBLC GBFFBDIJNIN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x846F950", Offset = "0x846ED50", VA = "0x18846F950", Slot = "4")]
			get
			{
				return default(FMGMOFJMBLC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NNAECDFEPDN CBOFALAFBKG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x846F540", Offset = "0x846E940", VA = "0x18846F540", Slot = "5")]
			get
			{
				return default(NNAECDFEPDN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OLBMKKBEIAE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x846F530", Offset = "0x846E930", VA = "0x18846F530", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool ALJBEDFOGPH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x846F370", Offset = "0x846E770", VA = "0x18846F370", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x846F1F0", Offset = "0x846E5F0", VA = "0x18846F1F0", Slot = "8")]
		public object APLLMCNAMLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x846F7C0", Offset = "0x846EBC0", VA = "0x18846F7C0", Slot = "9")]
		private (NNAECDFEPDN, object) HCHMLHGOHOC()
		{
			return default((NNAECDFEPDN, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x846F9A0", Offset = "0x846EDA0", VA = "0x18846F9A0", Slot = "10")]
		private (DNOIABBOEPJ, NNAECDFEPDN) OGPNMDIKONH()
		{
			return default((DNOIABBOEPJ, NNAECDFEPDN));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x846F240", Offset = "0x846E640", VA = "0x18846F240", Slot = "11")]
		private OFDAKGDMHMK<(DNOIABBOEPJ, NNAECDFEPDN)> CFHENNLEPML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x846EFD0", Offset = "0x846E3D0", VA = "0x18846EFD0", Slot = "12")]
		private (NKPPOELGPAG, byte[]) APFJDDELLKF()
		{
			return default((NKPPOELGPAG, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x846F590", Offset = "0x846E990", VA = "0x18846F590", Slot = "13")]
		private (MBEDCBJABND, byte[]) GINMDCFLJAJ()
		{
			return default((MBEDCBJABND, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4404E30", Offset = "0x4404230", VA = "0x184404E30", Slot = "14")]
		public T OOMPOFEJKHM<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x846FA90", Offset = "0x846EE90", VA = "0x18846FA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DBIKOCFFHBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class BJLPNOFKLJC : OFDAKGDMHMK<(DNOIABBOEPJ, NNAECDFEPDN)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] ELHBBMCFOOI;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int DGIEKOECJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x846E510", Offset = "0x846D910", VA = "0x18846E510", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (DNOIABBOEPJ view, NNAECDFEPDN newOwner) FMHPKKMCCLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x846E530", Offset = "0x846D930", VA = "0x18846E530", Slot = "4")]
			get
			{
				return default((DNOIABBOEPJ, NNAECDFEPDN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BJLPNOFKLJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x846E380", Offset = "0x846D780", VA = "0x18846E380", Slot = "4")]
	public bool MDNPGNBFALF(object NGIAGNLBILI, KMOGAEBEGPF DBCHIOJILOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BBHECHLFNHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class EBENLLKIGEP
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(BONILAJCDLA))]
[RegisterService(typeof(BEIIGJGHNLL), new string[] { "Photon" })]
public class BONILAJCDLA : FMPNPCDDCKO, HOHCEPPJBFD, BEIIGJGHNLL, GIBCNELDPEH, OBNIMLJGHNG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private ODHKBNJBHLC ANBICBPBIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private GFJCHHGAMMA EGLGEBDBDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable GALOKDCMNPH;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x846E930", Offset = "0x846DD30", VA = "0x18846E930", Slot = "4")]
	public void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x846EE10", Offset = "0x846E210", VA = "0x18846EE10", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x846E760", Offset = "0x846DB60", VA = "0x18846E760", Slot = "6")]
	public void IBNFBGCHIMH(MBEDCBJABND PEENICAIFOP, ReadOnlySpan<byte> JPPAFNCCIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x846ECF0", Offset = "0x846E0F0", VA = "0x18846ECF0", Slot = "10")]
	public void OJBOKBBOFEN(MBEDCBJABND HOGFNCBJHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x846E5D0", Offset = "0x846D9D0", VA = "0x18846E5D0", Slot = "7")]
	public void CCHJGDOHFCN(ReadOnlySpan<MBEDCBJABND> MMJNHKPCMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x846EA20", Offset = "0x846DE20", VA = "0x18846EA20")]
	private Hashtable LGGFNDMKHBB(Hashtable JNBJOEPKPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x846E8D0", Offset = "0x846DCD0", VA = "0x18846E8D0")]
	public void IGLCHAOGPNA(object EGMDPKHDKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x846EC80", Offset = "0x846E080", VA = "0x18846EC80", Slot = "8")]
	private void LOIPDCNMFAN(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xFAB3B0", Offset = "0xFAA7B0", VA = "0x180FAB3B0", Slot = "9")]
	private void IBPLCLLIMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x846EF50", Offset = "0x846E350", VA = "0x18846EF50")]
	public BONILAJCDLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::GPHOMEGCLMD), new string[] { })]
internal class LPMHLHOLJEJ : EGENBPAAGHG, global::GPHOMEGCLMD
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly AKNCNLDICPO LGMBKMGAIMJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override AKNCNLDICPO[] HOBCIBFFONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8472030", Offset = "0x8471430", VA = "0x188472030")]
	public LPMHLHOLJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OPHPNMGAEEK : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84733E0", Offset = "0x84727E0", VA = "0x1884733E0", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type IIHAKBEOLJD, MemberSerialization CPENKCCMCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84735F0", Offset = "0x84729F0", VA = "0x1884735F0")]
	public OPHPNMGAEEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MOMNEOFANIN
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PAPOEDDDNIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PAPOEDDDNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8473640", Offset = "0x8472A40", VA = "0x188473640")]
		internal string CNIIJFFAPKN(APFDEDCIGGF eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84721F0", Offset = "0x84715F0", VA = "0x1884721F0")]
	public static string AKGNNJAIDIH(this APFDEDCIGGF FCGKHKJBFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8472960", Offset = "0x8471D60", VA = "0x188472960")]
	public static FMGMOFJMBLC LFKPJPJPCMC(this APFDEDCIGGF FCGKHKJBFED)
	{
		return default(FMGMOFJMBLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8472760", Offset = "0x8471B60", VA = "0x188472760")]
	public static ViewId JKIKGEMNFOF(this APFDEDCIGGF FCGKHKJBFED)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8472AA0", Offset = "0x8471EA0", VA = "0x188472AA0")]
	public static string PDMMKONINIF(this APFDEDCIGGF FCGKHKJBFED, JsonSerializerSettings GAGNDFPGCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8472500", Offset = "0x8471900", VA = "0x188472500")]
	private static string HBLCBGODMEH(APFDEDCIGGF FCGKHKJBFED, Func<APFDEDCIGGF, string> ENDEKEOKCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84725F0", Offset = "0x84719F0", VA = "0x1884725F0")]
	public static string IHPFIJOGAAA(this APFDEDCIGGF FCGKHKJBFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8472330", Offset = "0x8471730", VA = "0x188472330")]
	public static ViewId GIHJBGGILGK(this APFDEDCIGGF FCGKHKJBFED)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8472210", Offset = "0x8471610", VA = "0x188472210")]
	public static string CHJPJFMLICI(this APFDEDCIGGF FCGKHKJBFED, JsonSerializerSettings GAGNDFPGCJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HHJDAOJNGPM
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class NMJOHHDJELI
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string MFICIHFFFKF;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84719D0", Offset = "0x8470DD0", VA = "0x1884719D0")]
	public static string CJLAEFOBHON(FMGMOFJMBLC IBOOIFDLFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(OPGEICFDBEK), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class OPGEICFDBEK : EGENBPAAGHG
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly AKNCNLDICPO NHPFPAKBMKL;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly AKNCNLDICPO FFFIKGOOBKK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly AKNCNLDICPO IHFPEOAEJLA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override AKNCNLDICPO[] HOBCIBFFONO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8472E30", Offset = "0x8472230", VA = "0x188472E30", Slot = "9")]
	public override void DHKJLAFONKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8473080", Offset = "0x8472480", VA = "0x188473080", Slot = "10")]
	public override void IBPAEEDCKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8473070", Offset = "0x8472470", VA = "0x188473070")]
	private void FEGJNFJLKPH(APFDEDCIGGF FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8473210", Offset = "0x8472610", VA = "0x188473210")]
	private void KPNHEKHJNOB(APFDEDCIGGF FCGKHKJBFED, MIAGGALJIMC DPDKHCNMKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8472BE0", Offset = "0x8471FE0", VA = "0x188472BE0")]
	public void CHJBPCDNKIK(APFDEDCIGGF FCGKHKJBFED, FMKJKLCDMGB ADNLODBNCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8472FC0", Offset = "0x84723C0", VA = "0x188472FC0")]
	private static AKNCNLDICPO FBFPIJNKMOD(byte AINAMMEFIOC)
	{
		return default(AKNCNLDICPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84732F0", Offset = "0x84726F0", VA = "0x1884732F0")]
	public OPGEICFDBEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EKEPCFJBGNJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JJNKECAPKGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings BMJFKIKLIMP;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x846FF50", Offset = "0x846F350", VA = "0x18846FF50")]
	public static NPGJJAOPLDO DFKKNCBJJLG([In] this NPGJJAOPLDO FLOCCDKNNLL, APFDEDCIGGF FCGKHKJBFED, FMKJKLCDMGB ADNLODBNCLK)
	{
		return default(NPGJJAOPLDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8471490", Offset = "0x8470890", VA = "0x188471490")]
	public static NPGJJAOPLDO ICHLCJIOADP([In] this NPGJJAOPLDO FLOCCDKNNLL, APFDEDCIGGF FCGKHKJBFED)
	{
		return default(NPGJJAOPLDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84712A0", Offset = "0x84706A0", VA = "0x1884712A0")]
	public static string FPKLJAHNMJA(APFDEDCIGGF FCGKHKJBFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x846FB80", Offset = "0x846EF80", VA = "0x18846FB80")]
	public static string CBEKKIOKJPJ(APFDEDCIGGF FCGKHKJBFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8471110", Offset = "0x8470510", VA = "0x188471110")]
	public static string EEJMCPBPBNM(APFDEDCIGGF FCGKHKJBFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8471080", Offset = "0x8470480", VA = "0x188471080")]
	[CompilerGenerated]
	internal static bool DONKKLBHFHK([Out] string HJBCDFKDKBA, JJNKECAPKGB P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x846FDE0", Offset = "0x846F1E0", VA = "0x18846FDE0")]
	[CompilerGenerated]
	internal static bool CCOGEKKGAFF([Out] string HJBCDFKDKBA, JJNKECAPKGB P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FCNBKKGCIKA
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FCNBKKGCIKA()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
