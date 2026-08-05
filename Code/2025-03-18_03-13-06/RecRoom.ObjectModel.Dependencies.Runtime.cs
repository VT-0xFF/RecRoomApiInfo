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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x77641F0", Offset = "0x77633F0", VA = "0x1877641F0", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7536370", Offset = "0x7535570", VA = "0x187536370", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7765710", Offset = "0x7764910", VA = "0x187765710")]
		private void BCKFAMNGJJN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77653F0", Offset = "0x77645F0", VA = "0x1877653F0")]
		private void APGEGEPOGIN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7765AE0", Offset = "0x7764CE0", VA = "0x187765AE0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7765B90", Offset = "0x7764D90", VA = "0x187765B90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(CADBONHKHDL), new string[] { "Photon" })]
public class POEJLHLKLBE : CADBONHKHDL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class PFFNBFCNBEB : IPJBHKAHKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public EventData ELLEMLBGHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode MOCNMAFDBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public PLBMIHGIAGO CECGAFBABHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CKENGCGKALA BCGFJIAPEDD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CKEAPBMAGIE FCLHHMOEMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7764DE0", Offset = "0x7763FE0", VA = "0x187764DE0", Slot = "4")]
			get
			{
				return default(CKEAPBMAGIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NEPEIILKAIK NBEGENOKFHC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x77645B0", Offset = "0x77637B0", VA = "0x1877645B0", Slot = "5")]
			get
			{
				return default(NEPEIILKAIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DCCOPJABDHI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7764360", Offset = "0x7763560", VA = "0x187764360", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool JFAEFLFNLGF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7764C70", Offset = "0x7763E70", VA = "0x187764C70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77645D0", Offset = "0x77637D0", VA = "0x1877645D0", Slot = "8")]
		private (NEPEIILKAIK, Dictionary<object, object>) IBOOEINDNBA()
		{
			return default((NEPEIILKAIK, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77644E0", Offset = "0x77636E0", VA = "0x1877644E0", Slot = "9")]
		private (GLJKKHGGAPE, NEPEIILKAIK) CJCJHAKGHNP()
		{
			return default((GLJKKHGGAPE, NEPEIILKAIK));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7764B50", Offset = "0x7763D50", VA = "0x187764B50", Slot = "10")]
		private KJMHJLLAHBO<(GLJKKHGGAPE, NEPEIILKAIK)> NIBICADAJCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7764370", Offset = "0x7763570", VA = "0x187764370", Slot = "11")]
		private KJMHJLLAHBO<LKIMPABLPLJ> BPOOHBLBCGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7764730", Offset = "0x7763930", VA = "0x187764730", Slot = "12")]
		private (PIFIDBIGLCI, byte[]) LDDOHDGLCJC()
		{
			return default((PIFIDBIGLCI, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7764930", Offset = "0x7763B30", VA = "0x187764930", Slot = "13")]
		private (JHKAHMFECBN, byte[]) MPPLINIKNKO()
		{
			return default((JHKAHMFECBN, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7764E00", Offset = "0x7764000", VA = "0x187764E00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PFFNBFCNBEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class PLBMIHGIAGO : KJMHJLLAHBO<(GLJKKHGGAPE, NEPEIILKAIK)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int[] GABJMLPBBDC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MCIABBAIGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7764F50", Offset = "0x7764150", VA = "0x187764F50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (GLJKKHGGAPE view, NEPEIILKAIK newOwner) EPCJHJAGLJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7764EB0", Offset = "0x77640B0", VA = "0x187764EB0", Slot = "4")]
			get
			{
				return default((GLJKKHGGAPE, NEPEIILKAIK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PLBMIHGIAGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DefaultMember("Item")]
	private class CKENGCGKALA : KJMHJLLAHBO<LKIMPABLPLJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public object[] GABJMLPBBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public HHNLGLKOJJH CKELCLKNKPN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int MCIABBAIGFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7760250", Offset = "0x775F450", VA = "0x187760250", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LKIMPABLPLJ EPCJHJAGLJO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7760140", Offset = "0x775F340", VA = "0x187760140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7760270", Offset = "0x775F470", VA = "0x187760270")]
		public CKENGCGKALA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DefaultMember("Item")]
	private class HHNLGLKOJJH : LKIMPABLPLJ, KJMHJLLAHBO<OKPLFGOCHNG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GLJKKHGGAPE MEEPADKGNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public object[] ALKPNNHBNLO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GLJKKHGGAPE CNBBGJKBFML
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "4")]
			get
			{
				return default(GLJKKHGGAPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int MCIABBAIGFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x77624C0", Offset = "0x77616C0", VA = "0x1877624C0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public OKPLFGOCHNG EPCJHJAGLJO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7762400", Offset = "0x7761600", VA = "0x187762400", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HHNLGLKOJJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7764F70", Offset = "0x7764170", VA = "0x187764F70", Slot = "4")]
	public bool MMIDNNJDGGE(object LJELDKAOCJM, IPJBHKAHKNB KAPFMBGNJFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public POEJLHLKLBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class EOGHIIICIEK
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(OBAOHPKJKFM), new string[] { "Photon" })]
[AlsoBindServiceAs(typeof(EACDNNJOCMG))]
public class EACDNNJOCMG : ANAKBJKCMDF, CKMNDLDGHIM, OBAOHPKJKFM, HECAJAGMFIA, ACFHKDFELAE, CBKDENAGIHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[DependsOn]
	private IIANCKHEFNL OCNNBPCACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[DependsOn]
	private OFECPPMLMIA FEMMCDFLHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Hashtable PBKGIMHJLME;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77614B0", Offset = "0x77606B0", VA = "0x1877614B0", Slot = "4")]
	public void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7761460", Offset = "0x7760660", VA = "0x187761460", Slot = "5")]
	public void INAPGGJAMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77615C0", Offset = "0x77607C0", VA = "0x1877615C0", Slot = "6")]
	public void LHLDKBGECPO(JHKAHMFECBN MBDBONINAPC, ReadOnlySpan<byte> FKKLLADNDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7761340", Offset = "0x7760540", VA = "0x187761340", Slot = "11")]
	public void EOBJJABIPFP(JHKAHMFECBN GCLGBNJHNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x77611B0", Offset = "0x77603B0", VA = "0x1877611B0", Slot = "7")]
	public void BOOPHEHKJPJ(ReadOnlySpan<JHKAHMFECBN> DKKOEIKAHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7761790", Offset = "0x7760990", VA = "0x187761790")]
	private Hashtable PMPDBECNDBH(Hashtable ONNHADHIAAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7761730", Offset = "0x7760930", VA = "0x187761730", Slot = "8")]
	public void OnEvent(EventData ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7761550", Offset = "0x7760750", VA = "0x187761550", Slot = "9")]
	private void LAHBCOILANO(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1005EC0", Offset = "0x10050C0", VA = "0x181005EC0", Slot = "10")]
	private void HCHPEMCKIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7761A70", Offset = "0x7760C70", VA = "0x187761A70")]
	public EACDNNJOCMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[RegisterService(typeof(global::CGBCKBMOOCE), new string[] { })]
internal class HFBDHJHBOLN : ENGIOFMPICN, global::CGBCKBMOOCE
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly PBBCGFNIILA OEFACHFNBFD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	protected override PBBCGFNIILA[] AMNNCGPPBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7762100", Offset = "0x7761300", VA = "0x187762100")]
	public HFBDHJHBOLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HHMFCBGKKLJ : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x77621B0", Offset = "0x77613B0", VA = "0x1877621B0", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type NNILCBOLNDI, MemberSerialization LIMFMNDCKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x77623B0", Offset = "0x77615B0", VA = "0x1877623B0")]
	public HHMFCBGKKLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CMIFAOJMCKA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class MPBABEKCNCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static string LPFNAMNEONF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class LIMJNAPCOKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LIMJNAPCOKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77640C0", Offset = "0x77632C0", VA = "0x1877640C0")]
		internal string CMMHOIAPLGD(EventData eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7760CA0", Offset = "0x775FEA0", VA = "0x187760CA0")]
	public static string KAABOCNLJBF(this EventData ELLEMLBGHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7760BF0", Offset = "0x775FDF0", VA = "0x187760BF0")]
	public static CKEAPBMAGIE HABKPKKGKEI(this EventData ELLEMLBGHOH)
	{
		return default(CKEAPBMAGIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77605E0", Offset = "0x775F7E0", VA = "0x1877605E0")]
	public static string GIKCAJOGAMK(CKEAPBMAGIE BHACABOKOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77604C0", Offset = "0x775F6C0", VA = "0x1877604C0")]
	public static string GCIBLOOHLCF(this EventData ELLEMLBGHOH, JsonSerializerSettings EGIPBPHHIHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x77602F0", Offset = "0x775F4F0", VA = "0x1877602F0")]
	public static ViewId CNEJHAFBGLC(this EventData ELLEMLBGHOH)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7760CC0", Offset = "0x775FEC0", VA = "0x187760CC0")]
	public static string KLIEPIKFNDN(this EventData ELLEMLBGHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7760FF0", Offset = "0x77601F0", VA = "0x187760FF0")]
	public static ViewId PGNOMJGOMAJ(this EventData ELLEMLBGHOH)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7760F20", Offset = "0x7760120", VA = "0x187760F20")]
	public static string NINHJCDBNGC(this EventData ELLEMLBGHOH, JsonSerializerSettings EGIPBPHHIHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7760E30", Offset = "0x7760030", VA = "0x187760E30")]
	private static string MHNNPDGKEAD(EventData ELLEMLBGHOH, Func<EventData, string> GJDAMJHNAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(FDOCCFOLDHI), new string[] { })]
internal class FDOCCFOLDHI : ENGIOFMPICN, HECAJAGMFIA, MNNMOCAGFLL
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly PBBCGFNIILA JJMDIKAANFF;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly PBBCGFNIILA PKGGPPJPABL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly PBBCGFNIILA EJMOOIEAPIM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override PBBCGFNIILA[] AMNNCGPPBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7761E60", Offset = "0x7761060", VA = "0x187761E60", Slot = "9")]
	public override void FCMOOEKHBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7761BB0", Offset = "0x7760DB0", VA = "0x187761BB0", Slot = "10")]
	public override void DPIOMIOOGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7761F20", Offset = "0x7761120", VA = "0x187761F20", Slot = "11")]
	private void JGAFNKENPPJ(EventData ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7761EF0", Offset = "0x77610F0", VA = "0x187761EF0", Slot = "12")]
	private void IMLFIPOOPFA(EventData ELLEMLBGHOH, HCBDIFBPMFO PBMCEFOCHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7761EF0", Offset = "0x77610F0", VA = "0x187761EF0")]
	private void KGDCBAKOIJL(EventData ELLEMLBGHOH, HCBDIFBPMFO PBMCEFOCHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7761C40", Offset = "0x7760E40", VA = "0x187761C40")]
	public void EINPMKEFHJA(EventData ELLEMLBGHOH, CKMCMBKAMAC IHIDLOGGJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7761AF0", Offset = "0x7760CF0", VA = "0x187761AF0")]
	private static PBBCGFNIILA BGKMGHMJEOJ(EventData ELLEMLBGHOH)
	{
		return default(PBBCGFNIILA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7761FD0", Offset = "0x77611D0", VA = "0x187761FD0")]
	public FDOCCFOLDHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JLPMCEFABKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct MGPCCOJCDGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly JsonSerializerSettings ADDLDLKLLIN;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7762650", Offset = "0x7761850", VA = "0x187762650")]
	public static PDNKDGIJINL BHIFICMELDK([In] this PDNKDGIJINL CDNHPBIABBJ, EventData ELLEMLBGHOH, CKMCMBKAMAC IHIDLOGGJNA)
	{
		return default(PDNKDGIJINL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7763A40", Offset = "0x7762C40", VA = "0x187763A40")]
	public static PDNKDGIJINL ONBCNHCCBNE([In] this PDNKDGIJINL CDNHPBIABBJ, EventData ELLEMLBGHOH)
	{
		return default(PDNKDGIJINL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x77637E0", Offset = "0x77629E0", VA = "0x1877637E0")]
	public static string KFELEGPJAFI(EventData ELLEMLBGHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7763590", Offset = "0x7762790", VA = "0x187763590")]
	public static string HCCNMJHOKOD(EventData ELLEMLBGHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7763D80", Offset = "0x7762F80", VA = "0x187763D80")]
	public static string ONDOCIPCOGG(EventData ELLEMLBGHOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x77639B0", Offset = "0x7762BB0", VA = "0x1877639B0")]
	[CompilerGenerated]
	internal static bool OHHCEJEEHGP([Out] string CMLOHOMLNDL, MGPCCOJCDGA P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x77624E0", Offset = "0x77616E0", VA = "0x1877624E0")]
	[CompilerGenerated]
	internal static bool BCEICEIENDO([Out] string CMLOHOMLNDL, MGPCCOJCDGA P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DCKHMIAOKJO
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DCKHMIAOKJO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
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
