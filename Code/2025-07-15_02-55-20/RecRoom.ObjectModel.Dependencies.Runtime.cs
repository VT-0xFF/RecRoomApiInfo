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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82C03E0", Offset = "0x82BEFE0", VA = "0x1882C03E0", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x230C5A0", Offset = "0x230B1A0", VA = "0x18230C5A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82C2070", Offset = "0x82C0C70", VA = "0x1882C2070")]
		private void GAOPLNBGOGD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82C1D50", Offset = "0x82C0950", VA = "0x1882C1D50")]
		private void BBOPNMEHPCH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82C2450", Offset = "0x82C1050", VA = "0x1882C2450", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82C2500", Offset = "0x82C1100", VA = "0x1882C2500")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(MLKPGPIKNLN), new string[] { "Photon" })]
public class AELKHKBNBHO : MLKPGPIKNLN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class NBIHNHMBNIM : OIIDHFILPMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public GDFAENLHEKK CKGMOBNFAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode FGAFKJLGOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public MGOOELJJJJJ BGEIEHKAHPJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public FINICCDBPBH GJCIAOMMHGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x82C0E90", Offset = "0x82BFA90", VA = "0x1882C0E90", Slot = "4")]
			get
			{
				return default(FINICCDBPBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MKFFFMAICOP FNDAFDMPHAP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x82C1110", Offset = "0x82BFD10", VA = "0x1882C1110", Slot = "5")]
			get
			{
				return default(MKFFFMAICOP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MLNJDIKECMM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x82C0960", Offset = "0x82BF560", VA = "0x1882C0960", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool GBADHAGPCHE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x82C1160", Offset = "0x82BFD60", VA = "0x1882C1160", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82C0910", Offset = "0x82BF510", VA = "0x1882C0910", Slot = "8")]
		public object IICOCMPAFIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82C0AA0", Offset = "0x82BF6A0", VA = "0x1882C0AA0", Slot = "9")]
		private (MKFFFMAICOP, Dictionary<object, object>) KMDHKCIIKBI()
		{
			return default((MKFFFMAICOP, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82C0DA0", Offset = "0x82BF9A0", VA = "0x1882C0DA0", Slot = "10")]
		private (BPKOKGNGCMF, MKFFFMAICOP) KNHIHLDPNAF()
		{
			return default((BPKOKGNGCMF, MKFFFMAICOP));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82C0970", Offset = "0x82BF570", VA = "0x1882C0970", Slot = "11")]
		private IEHJOAHBOCP<(BPKOKGNGCMF, MKFFFMAICOP)> KJAFNAKODJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82C06F0", Offset = "0x82BF2F0", VA = "0x1882C06F0", Slot = "12")]
		private (MBKGIBNAPNI, byte[]) DKFMNLHEJDF()
		{
			return default((MBKGIBNAPNI, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82C0EE0", Offset = "0x82BFAE0", VA = "0x1882C0EE0", Slot = "13")]
		private (DDHBOPBHNJP, byte[]) NBNPFOACIFP()
		{
			return default((DDHBOPBHNJP, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x43646A0", Offset = "0x43632A0", VA = "0x1843646A0", Slot = "14")]
		public T AAJBIGJDHOE<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82C1320", Offset = "0x82BFF20", VA = "0x1882C1320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NBIHNHMBNIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class MGOOELJJJJJ : IEHJOAHBOCP<(BPKOKGNGCMF, MKFFFMAICOP)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] LGMLBJIEMPC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int PIELHOLGNLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x82C0590", Offset = "0x82BF190", VA = "0x1882C0590", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (BPKOKGNGCMF view, MKFFFMAICOP newOwner) KLGHGIBKAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x82C04F0", Offset = "0x82BF0F0", VA = "0x1882C04F0", Slot = "4")]
			get
			{
				return default((BPKOKGNGCMF, MKFFFMAICOP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public MGOOELJJJJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82BC4F0", Offset = "0x82BB0F0", VA = "0x1882BC4F0", Slot = "4")]
	public bool NEKBDFCIJDE(object CBCNBAPLLJM, OIIDHFILPMC FJKFKHLJPJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public AELKHKBNBHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class HFKIJCMBEEO
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(LPLOLPGEDME))]
[RegisterService(typeof(KLDCBAEIPDO), new string[] { "Photon" })]
public class LPLOLPGEDME : PNNOEJFPBEL, HPINOMAFHJF, KLDCBAEIPDO, FPAFPEELFNB, EFGOCCCLGDB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private DMBKBLEPJHM IEAEJIDPCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private APNHGEHCHIA FPMAODNANEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable FDEACFJBFDB;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82C0010", Offset = "0x82BEC10", VA = "0x1882C0010", Slot = "4")]
	public void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82C0220", Offset = "0x82BEE20", VA = "0x1882C0220", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82BFC40", Offset = "0x82BE840", VA = "0x1882BFC40", Slot = "6")]
	public void DGMKJCKGMKH(DDHBOPBHNJP DHCHBFGMFFD, ReadOnlySpan<byte> HGBKIACHBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82C0100", Offset = "0x82BED00", VA = "0x1882C0100", Slot = "10")]
	public void PBEFJOLOPIF(DDHBOPBHNJP CKAIILPPHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82BFE10", Offset = "0x82BEA10", VA = "0x1882BFE10", Slot = "7")]
	public void ECONNBFGDKM(ReadOnlySpan<DDHBOPBHNJP> HDPBAKHMHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82BF9E0", Offset = "0x82BE5E0", VA = "0x1882BF9E0")]
	private Hashtable DDAFPIELECD(Hashtable GFCPCAJKDCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82BFDB0", Offset = "0x82BE9B0", VA = "0x1882BFDB0")]
	public void DODJFDEHJPK(object PJIJGMLMHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82BFFA0", Offset = "0x82BEBA0", VA = "0x1882BFFA0", Slot = "8")]
	private void HMKAAGAACIK(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x12C55A0", Offset = "0x12C41A0", VA = "0x1812C55A0", Slot = "9")]
	private void GJFDCMOAOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82C0360", Offset = "0x82BEF60", VA = "0x1882C0360")]
	public LPLOLPGEDME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::JLKHNDMJKMF), new string[] { })]
internal class AJHNLPPLKJH : GLNMNKJJMBD, global::JLKHNDMJKMF
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly PEOHNMCPNIJ GPPOCCBIKEF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override PEOHNMCPNIJ[] CNIMAAFHOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82BC6D0", Offset = "0x82BB2D0", VA = "0x1882BC6D0")]
	public AJHNLPPLKJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KMKDHNJIHMG : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82BF780", Offset = "0x82BE380", VA = "0x1882BF780", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type MDCDODCGNEK, MemberSerialization AFLLEMINGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x82BF990", Offset = "0x82BE590", VA = "0x1882BF990")]
	public KMKDHNJIHMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IGNCOHJOJEC
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class MNMKIHHBEEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public MNMKIHHBEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82C05B0", Offset = "0x82BF1B0", VA = "0x1882C05B0")]
		internal string PNGCDDOBBMK(GDFAENLHEKK eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82BEDE0", Offset = "0x82BD9E0", VA = "0x1882BEDE0")]
	public static string BGDPDEOEICC(this GDFAENLHEKK CKGMOBNFAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82BF510", Offset = "0x82BE110", VA = "0x1882BF510")]
	public static FINICCDBPBH KFIKILGMAAK(this GDFAENLHEKK CKGMOBNFAKG)
	{
		return default(FINICCDBPBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82BF220", Offset = "0x82BDE20", VA = "0x1882BF220")]
	public static ViewId EFMLOJJKCBB(this GDFAENLHEKK CKGMOBNFAKG)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82BF150", Offset = "0x82BDD50", VA = "0x1882BF150")]
	public static string EDOCNCHLPIA(this GDFAENLHEKK CKGMOBNFAKG, JsonSerializerSettings OJHCHKCCNPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82BF420", Offset = "0x82BE020", VA = "0x1882BF420")]
	private static string EGFCIKJMBPB(GDFAENLHEKK CKGMOBNFAKG, Func<GDFAENLHEKK, string> KLIEOOEGDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82BEE00", Offset = "0x82BDA00", VA = "0x1882BEE00")]
	public static string DIJBIFLMHPG(this GDFAENLHEKK CKGMOBNFAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x82BEF70", Offset = "0x82BDB70", VA = "0x1882BEF70")]
	public static ViewId EAPCDGLNCJB(this GDFAENLHEKK CKGMOBNFAKG)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82BF660", Offset = "0x82BE260", VA = "0x1882BF660")]
	public static string MELCNKHNOBC(this GDFAENLHEKK CKGMOBNFAKG, JsonSerializerSettings OJHCHKCCNPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NMIJPEOOIJE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class FKMNHKFHHON
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string OFBABPGFFDF;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x82C1410", Offset = "0x82C0010", VA = "0x1882C1410")]
	public static string NOFAMNAMCFB(FINICCDBPBH MMBNDGKBEFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(CBLPPFDMPHC), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class CBLPPFDMPHC : GLNMNKJJMBD
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly PEOHNMCPNIJ FAFPBANBKPH;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly PEOHNMCPNIJ GPCEKKGNPAC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly PEOHNMCPNIJ BODFBGIGLMK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override PEOHNMCPNIJ[] CNIMAAFHOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82BE570", Offset = "0x82BD170", VA = "0x1882BE570", Slot = "9")]
	public override void BONJIOFKLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82BEA40", Offset = "0x82BD640", VA = "0x1882BEA40", Slot = "10")]
	public override void NFEBDHLMMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82BE730", Offset = "0x82BD330", VA = "0x1882BE730")]
	private void EMAGFNMPKFC(GDFAENLHEKK CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82BE700", Offset = "0x82BD300", VA = "0x1882BE700")]
	private void CPILCGBNEFN(GDFAENLHEKK CKGMOBNFAKG, OEINLGFEHLC PKCEOMNGOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x82BE7F0", Offset = "0x82BD3F0", VA = "0x1882BE7F0")]
	public void JPCPAHCFMHB(GDFAENLHEKK CKGMOBNFAKG, EPIJDMOKDKO FBPOMMKMHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x82BE740", Offset = "0x82BD340", VA = "0x1882BE740")]
	private static PEOHNMCPNIJ JIDOAMGDBME(byte IOMJLDCPLFD)
	{
		return default(PEOHNMCPNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x82BEC80", Offset = "0x82BD880", VA = "0x1882BEC80")]
	public CBLPPFDMPHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BGAMFKHKGPN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HFEJBCHIOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings DBKLBCNAMPC;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x82BC810", Offset = "0x82BB410", VA = "0x1882BC810")]
	public static ADMHFGCBEHD CAHHGIJIGLN([In] this ADMHFGCBEHD DAKAAKLHCNP, GDFAENLHEKK CKGMOBNFAKG, EPIJDMOKDKO FBPOMMKMHLA)
	{
		return default(ADMHFGCBEHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x82BDBE0", Offset = "0x82BC7E0", VA = "0x1882BDBE0")]
	public static ADMHFGCBEHD HKEMCJLLGCD([In] this ADMHFGCBEHD DAKAAKLHCNP, GDFAENLHEKK CKGMOBNFAKG)
	{
		return default(ADMHFGCBEHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82BDF50", Offset = "0x82BCB50", VA = "0x1882BDF50")]
	public static string LALEGKEOJMB(GDFAENLHEKK CKGMOBNFAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82BE140", Offset = "0x82BCD40", VA = "0x1882BE140")]
	public static string LKNIHOKOCLF(GDFAENLHEKK CKGMOBNFAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82BDA50", Offset = "0x82BC650", VA = "0x1882BDA50")]
	public static string GOKFAMBAHAC(GDFAENLHEKK CKGMOBNFAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82BC780", Offset = "0x82BB380", VA = "0x1882BC780")]
	[CompilerGenerated]
	internal static bool AEIKIFPJGLJ([Out] string ABEFNIJCBBN, HFEJBCHIOLE P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82BD8E0", Offset = "0x82BC4E0", VA = "0x1882BD8E0")]
	[CompilerGenerated]
	internal static bool CGMBPNDPKLC([Out] string ABEFNIJCBBN, HFEJBCHIOLE P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MBCOCJPKMMG
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MBCOCJPKMMG()
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
