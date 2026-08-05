using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x803AD40", Offset = "0x8039F40", VA = "0x18803AD40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KPAIPNKBOOF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class NCBGKLECCOI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void NMAGCCJNHAC(HCGIJFAMGPM LHLEAOBBCEG);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8038510", Offset = "0x8037710", VA = "0x188038510")]
	private static void FMJFOFBBBMB(HCGIJFAMGPM LHLEAOBBCEG, NMAGCCJNHAC NLHMEPCGJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8038270", Offset = "0x8037470", VA = "0x188038270")]
	public static bool DOALCDFCEHB(this HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, [Optional] NMAGCCJNHAC NLHMEPCGJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8038120", Offset = "0x8037320", VA = "0x188038120")]
	public static FPGKKBPJEMK BBHKGAGDDIA(this HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, string MLCDCHNOCFI, [Optional] NMAGCCJNHAC NLHMEPCGJEM)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80383D0", Offset = "0x80375D0", VA = "0x1880383D0")]
	public static FPGKKBPJEMK FKEFIEEKDNB(this HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, int MLCDCHNOCFI, [Optional] NMAGCCJNHAC NLHMEPCGJEM)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80386D0", Offset = "0x80378D0", VA = "0x1880386D0")]
	public static FPGKKBPJEMK KPHEPGLPOPJ(this HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, bool MLCDCHNOCFI, [Optional] NMAGCCJNHAC NLHMEPCGJEM)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8038990", Offset = "0x8037B90", VA = "0x188038990")]
	public static FPGKKBPJEMK PGAHAGCMNDH(this HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, float MLCDCHNOCFI, [Optional] NMAGCCJNHAC NLHMEPCGJEM)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8038820", Offset = "0x8037A20", VA = "0x188038820")]
	public static FPGKKBPJEMK OJOENEKPBEF(this HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, DateTime MLCDCHNOCFI, [Optional] NMAGCCJNHAC NLHMEPCGJEM)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8038590", Offset = "0x8037790", VA = "0x188038590")]
	public static FPGKKBPJEMK KHILMDNFOCD(this HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, long MLCDCHNOCFI, [Optional] NMAGCCJNHAC NLHMEPCGJEM)
	{
		return default(FPGKKBPJEMK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PCDOHPEMCCP : IFBDCKMAEEM, HCGIJFAMGPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly EOJHHKCIJLD ALHJBDJFADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> IOKENDIHGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> FJEKCAPAMID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> MIFBEEEHINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x803A200", Offset = "0x8039400", VA = "0x18803A200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action GEEKAEIJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x803ABC0", Offset = "0x8039DC0", VA = "0x18803ABC0")]
	[UnityEngine.Scripting.Preserve]
	public PCDOHPEMCCP([ALHAHLCGLLK(null)] EOJHHKCIJLD ALHJBDJFADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "8")]
	public void DGDBEFAKGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x803A100", Offset = "0x8039300", VA = "0x18803A100")]
	private DirectoryInfo JDBOKDCLBED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8039CB0", Offset = "0x8038EB0", VA = "0x188039CB0", Slot = "6")]
	public Task HOPOIHNNBEL(long IGJFMDPEDFC, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80390C0", Offset = "0x80382C0", VA = "0x1880390C0", Slot = "14")]
	public float BMCPEPCPNJO(string AGBHGDFILGO, float FAGKKFIFNNI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x803A5E0", Offset = "0x80397E0", VA = "0x18803A5E0", Slot = "13")]
	public void LGBIHAGFDBB(string AGBHGDFILGO, bool MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8039BF0", Offset = "0x8038DF0", VA = "0x188039BF0", Slot = "12")]
	public bool HANPJDENONC(string AGBHGDFILGO, bool FAGKKFIFNNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8039A30", Offset = "0x8038C30", VA = "0x188039A30", Slot = "10")]
	public int DPCOCHBIIFH(string AGBHGDFILGO, int FAGKKFIFNNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x803A240", Offset = "0x8039440", VA = "0x18803A240", Slot = "18")]
	public DateTime KKGNBOFJJNF(string LGOOKHKOCFM, [Optional] DateTime FAGKKFIFNNI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x803A650", Offset = "0x8039850", VA = "0x18803A650", Slot = "19")]
	public void LJNLLIGGNCJ(string AGBHGDFILGO, DateTime MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8039AA0", Offset = "0x8038CA0", VA = "0x188039AA0", Slot = "15")]
	public void FGCIOKMBNKA(string AGBHGDFILGO, float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8039050", Offset = "0x8038250", VA = "0x188039050", Slot = "11")]
	public void ABOCHNGGNDD(string AGBHGDFILGO, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8039B10", Offset = "0x8038D10", VA = "0x188039B10", Slot = "20")]
	public long GGNBNJBBIDD(string LGOOKHKOCFM, long FAGKKFIFNNI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x803AAA0", Offset = "0x8039CA0", VA = "0x18803AAA0", Slot = "21")]
	public void MOGPNOOOCFG(string LGOOKHKOCFM, long MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x361B300", Offset = "0x361A500", VA = "0x18361B300", Slot = "22")]
	public T DJEMMMLAKDL<T>(string LGOOKHKOCFM, T FAGKKFIFNNI, COFCEIGKIJD<T> KKFGHJMMBAD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x361B300", Offset = "0x361A500", VA = "0x18361B300", Slot = "23")]
	public void PJHCFIFHGHA<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, COFCEIGKIJD<T> KKFGHJMMBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x803AB10", Offset = "0x8039D10", VA = "0x18803AB10", Slot = "16")]
	public string NFNKLDLHFAN(string AGBHGDFILGO, string FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8039B80", Offset = "0x8038D80", VA = "0x188039B80", Slot = "17")]
	public void GNGPAIBPEAF(string AGBHGDFILGO, string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x803A950", Offset = "0x8039B50", VA = "0x18803A950", Slot = "24")]
	public void MBHIFAPLADI(string AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x803A8C0", Offset = "0x8039AC0", VA = "0x18803A8C0", Slot = "9")]
	public bool LPEJBEIEKEC(string AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x803A2B0", Offset = "0x80394B0", VA = "0x18803A2B0", Slot = "25")]
	public Task LBHHEHCHBLP(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8039D40", Offset = "0x8038F40", VA = "0x188039D40")]
	private void INJAFJLGOIE(DirectoryInfo JOHCCNDOINB, string HHCDHCHGKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x803A6C0", Offset = "0x80398C0", VA = "0x18803A6C0")]
	private static string LMJIGIJACFI(string AGBHGDFILGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8039930", Offset = "0x8038B30", VA = "0x188039930")]
	private static string BNOAJKDKAGD(byte[] FONJAIMABAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A08DC0", Offset = "0x3A07FC0", VA = "0x183A08DC0")]
	private T HKFPFFCEPKK<T>(string LGOOKHKOCFM, T FAGKKFIFNNI, [Optional] COFCEIGKIJD<T> GNCOBDAAGBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A07A30", Offset = "0x3A06C30", VA = "0x183A07A30")]
	private void DENBCCCLIHH<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, [Optional] COFCEIGKIJD<T> GNCOBDAAGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8039130", Offset = "0x8038330", VA = "0x188039130")]
	private Dictionary<string, string> BNBIFLBFALB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class CEEPKEKCLHE
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8032FA0", Offset = "0x80321A0", VA = "0x188032FA0")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	internal static void NPCFNJKLMBL(HILJAABEPDC NPCDKJJJIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class COFDPFCPPKC : LJOGCOPBPDN
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8033100", Offset = "0x8032300", VA = "0x188033100")]
	[UnityEngine.Scripting.Preserve]
	public COFDPFCPPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LJOGCOPBPDN : IFBDCKMAEEM, HCGIJFAMGPM, IFEDNKFCEHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> JFCILAMNCCD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GEEKAEIJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "8")]
	public void DGDBEFAKGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8037460", Offset = "0x8036660", VA = "0x188037460", Slot = "6")]
	public Task HOPOIHNNBEL(long IGJFMDPEDFC, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80376A0", Offset = "0x80368A0", VA = "0x1880376A0", Slot = "9")]
	public bool LPEJBEIEKEC(string LGOOKHKOCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8037280", Offset = "0x8036480", VA = "0x188037280", Slot = "10")]
	public int DPCOCHBIIFH(string LGOOKHKOCFM, int FAGKKFIFNNI = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x80371C0", Offset = "0x80363C0", VA = "0x1880371C0", Slot = "11")]
	public void ABOCHNGGNDD(string LGOOKHKOCFM, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8037400", Offset = "0x8036600", VA = "0x188037400", Slot = "12")]
	public bool HANPJDENONC(string LGOOKHKOCFM, bool FAGKKFIFNNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80375E0", Offset = "0x80367E0", VA = "0x1880375E0", Slot = "13")]
	public void LGBIHAGFDBB(string LGOOKHKOCFM, bool MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8037220", Offset = "0x8036420", VA = "0x188037220", Slot = "14")]
	public float BMCPEPCPNJO(string LGOOKHKOCFM, float FAGKKFIFNNI = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80372E0", Offset = "0x80364E0", VA = "0x1880372E0", Slot = "15")]
	public void FGCIOKMBNKA(string LGOOKHKOCFM, float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x80377C0", Offset = "0x80369C0", VA = "0x1880377C0", Slot = "16")]
	public string NFNKLDLHFAN(string LGOOKHKOCFM, [Optional] string FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80373A0", Offset = "0x80365A0", VA = "0x1880373A0", Slot = "17")]
	public void GNGPAIBPEAF(string LGOOKHKOCFM, string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80374F0", Offset = "0x80366F0", VA = "0x1880374F0", Slot = "18")]
	public DateTime KKGNBOFJJNF(string LGOOKHKOCFM, [Optional] DateTime FAGKKFIFNNI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8037640", Offset = "0x8036840", VA = "0x188037640", Slot = "19")]
	public void LJNLLIGGNCJ(string LGOOKHKOCFM, DateTime MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8037340", Offset = "0x8036540", VA = "0x188037340", Slot = "20")]
	public long GGNBNJBBIDD(string LGOOKHKOCFM, long FAGKKFIFNNI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8037760", Offset = "0x8036960", VA = "0x188037760", Slot = "21")]
	public void MOGPNOOOCFG(string LGOOKHKOCFM, long MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x38BD560", Offset = "0x38BC760", VA = "0x1838BD560", Slot = "22")]
	public T DJEMMMLAKDL<T>(string LGOOKHKOCFM, T FAGKKFIFNNI, COFCEIGKIJD<T> KKFGHJMMBAD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x38BDEC0", Offset = "0x38BD0C0", VA = "0x1838BDEC0", Slot = "23")]
	public void PJHCFIFHGHA<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, COFCEIGKIJD<T> KKFGHJMMBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38BD680", Offset = "0x38BC880", VA = "0x1838BD680")]
	public T HKFPFFCEPKK<T>(string LGOOKHKOCFM, T FAGKKFIFNNI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x38BD070", Offset = "0x38BC270", VA = "0x1838BD070")]
	public void DENBCCCLIHH<T>(string LGOOKHKOCFM, T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8037700", Offset = "0x8036900", VA = "0x188037700", Slot = "24")]
	public void MBHIFAPLADI(string LGOOKHKOCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8037550", Offset = "0x8036750", VA = "0x188037550", Slot = "25")]
	public Task LBHHEHCHBLP(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8033100", Offset = "0x8032300", VA = "0x188033100")]
	public LJOGCOPBPDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class IKBIPFLIKHE<TParent> where TParent : HCGIJFAMGPM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<IKBIPFLIKHE<TParent>> PHOLHOLMHJI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4C9EE40", Offset = "0x4C9E040", VA = "0x184C9EE40")]
	protected IKBIPFLIKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void FKFEALEGJFP();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void HKKACANADFK(string AGBHGDFILGO);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4C9EAD0", Offset = "0x4C9DCD0", VA = "0x184C9EAD0")]
	public static void NHJKMNGAAPD(string AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C9E8A0", Offset = "0x4C9DAA0", VA = "0x184C9E8A0")]
	public static void KCMDFAKJCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DJCCMCKDOCC<TParent, TValue> : IKBIPFLIKHE<TParent> where TParent : HCGIJFAMGPM
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DJCCMCKDOCC<TParent, TValue> EMOEMPAFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> LIOIPEGJBHB;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A27880", Offset = "0x6A26A80", VA = "0x186A27880")]
	public bool FLFGMEICIOC(string AAHHAPOLENF, [Out] TValue GPGPBGEPBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A278E0", Offset = "0x6A26AE0", VA = "0x186A278E0")]
	public void FODKPPOMJFF(string AAHHAPOLENF, TValue MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4C7D680", Offset = "0x4C7C880", VA = "0x184C7D680", Slot = "4")]
	protected override void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4C68350", Offset = "0x4C67550", VA = "0x184C68350", Slot = "5")]
	protected override void HKKACANADFK(string AAHHAPOLENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A27B70", Offset = "0x6A26D70", VA = "0x186A27B70")]
	public DJCCMCKDOCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HCGIJFAMGPM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGDBEFAKGIL();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPEJBEIEKEC(string LGOOKHKOCFM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DPCOCHBIIFH(string LGOOKHKOCFM, int FAGKKFIFNNI = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABOCHNGGNDD(string LGOOKHKOCFM, int MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HANPJDENONC(string LGOOKHKOCFM, bool FAGKKFIFNNI = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LGBIHAGFDBB(string LGOOKHKOCFM, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float BMCPEPCPNJO(string LGOOKHKOCFM, float FAGKKFIFNNI = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FGCIOKMBNKA(string LGOOKHKOCFM, float MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string NFNKLDLHFAN(string LGOOKHKOCFM, [Optional] string FAGKKFIFNNI);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GNGPAIBPEAF(string LGOOKHKOCFM, string MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime KKGNBOFJJNF(string LGOOKHKOCFM, [Optional] DateTime KEIJCGKHOOM);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LJNLLIGGNCJ(string LGOOKHKOCFM, DateTime KEIJCGKHOOM);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long GGNBNJBBIDD(string LGOOKHKOCFM, long FAGKKFIFNNI);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MOGPNOOOCFG(string LGOOKHKOCFM, long MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T DJEMMMLAKDL<T>(string LGOOKHKOCFM, T FAGKKFIFNNI, COFCEIGKIJD<T> KKFGHJMMBAD);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PJHCFIFHGHA<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, COFCEIGKIJD<T> KKFGHJMMBAD);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MBHIFAPLADI(string LGOOKHKOCFM);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task LBHHEHCHBLP([Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IFBDCKMAEEM : HCGIJFAMGPM
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GEEKAEIJKCN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HOPOIHNNBEL(long IGJFMDPEDFC, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IFEDNKFCEHI : HCGIJFAMGPM
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MHHEEGAOHPN : IFBDCKMAEEM, HCGIJFAMGPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KCOBALIJDAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MHHEEGAOHPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8036440", Offset = "0x8035640", VA = "0x188036440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8036810", Offset = "0x8035A10", VA = "0x188036810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EMBJBBPHNJA : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public MHHEEGAOHPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public EMBJBBPHNJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8033190", Offset = "0x8032390", VA = "0x188033190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8033200", Offset = "0x8032400", VA = "0x188033200", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EOJHHKCIJLD ALHJBDJFADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MLBEPCIIEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool NNEHHJGFKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private IEHEEDGPPGD ELNMJLOPIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PEFNPNHCEAP LNCLHKFEFCM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GEEKAEIJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8038030", Offset = "0x8037230", VA = "0x188038030")]
	[UnityEngine.Scripting.Preserve]
	public MHHEEGAOHPN([ALHAHLCGLLK(null)] EOJHHKCIJLD ALHJBDJFADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "8")]
	public void DGDBEFAKGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8037B10", Offset = "0x8036D10", VA = "0x188037B10", Slot = "6")]
	public Task HOPOIHNNBEL(long IGJFMDPEDFC, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1B02400", Offset = "0x1B01600", VA = "0x181B02400")]
	private static int MJACOOKKIDD(bool MLCDCHNOCFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8037E40", Offset = "0x8037040", VA = "0x188037E40", Slot = "9")]
	public bool LPEJBEIEKEC(string LGOOKHKOCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x80378F0", Offset = "0x8036AF0", VA = "0x1880378F0", Slot = "10")]
	public int DPCOCHBIIFH(string LGOOKHKOCFM, int FAGKKFIFNNI = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8037820", Offset = "0x8036A20", VA = "0x188037820", Slot = "11")]
	public void ABOCHNGGNDD(string LGOOKHKOCFM, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8037A80", Offset = "0x8036C80", VA = "0x188037A80", Slot = "12")]
	public bool HANPJDENONC(string LGOOKHKOCFM, bool FAGKKFIFNNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8037D00", Offset = "0x8036F00", VA = "0x188037D00", Slot = "13")]
	public void LGBIHAGFDBB(string LGOOKHKOCFM, bool MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x80378C0", Offset = "0x8036AC0", VA = "0x1880378C0", Slot = "14")]
	public float BMCPEPCPNJO(string LGOOKHKOCFM, float FAGKKFIFNNI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8037940", Offset = "0x8036B40", VA = "0x188037940", Slot = "15")]
	public void FGCIOKMBNKA(string LGOOKHKOCFM, float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8037BA0", Offset = "0x8036DA0", VA = "0x188037BA0", Slot = "18")]
	public DateTime KKGNBOFJJNF(string LGOOKHKOCFM, [Optional] DateTime FAGKKFIFNNI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8037DD0", Offset = "0x8036FD0", VA = "0x188037DD0", Slot = "19")]
	public void LJNLLIGGNCJ(string LGOOKHKOCFM, DateTime KEIJCGKHOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8037970", Offset = "0x8036B70", VA = "0x188037970", Slot = "20")]
	public long GGNBNJBBIDD(string LGOOKHKOCFM, long FAGKKFIFNNI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8037EF0", Offset = "0x80370F0", VA = "0x188037EF0", Slot = "21")]
	public void MOGPNOOOCFG(string LGOOKHKOCFM, long MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x38EE1A0", Offset = "0x38ED3A0", VA = "0x1838EE1A0", Slot = "22")]
	public T DJEMMMLAKDL<T>(string LGOOKHKOCFM, T FAGKKFIFNNI, COFCEIGKIJD<T> KKFGHJMMBAD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x38EE1A0", Offset = "0x38ED3A0", VA = "0x1838EE1A0", Slot = "23")]
	public void PJHCFIFHGHA<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, COFCEIGKIJD<T> KKFGHJMMBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38EE380", Offset = "0x38ED580", VA = "0x1838EE380")]
	private T FKJELNJNJCO<T>(string LGOOKHKOCFM, T FAGKKFIFNNI, [Optional] COFCEIGKIJD<T> GNCOBDAAGBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x38EEEC0", Offset = "0x38EE0C0", VA = "0x1838EEEC0")]
	private void NIJFGPODIMD<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, [Optional] COFCEIGKIJD<T> GNCOBDAAGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8037F60", Offset = "0x8037160", VA = "0x188037F60", Slot = "16")]
	public string NFNKLDLHFAN(string LGOOKHKOCFM, string FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80379E0", Offset = "0x8036BE0", VA = "0x1880379E0", Slot = "17")]
	public void GNGPAIBPEAF(string LGOOKHKOCFM, string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8037DB0", Offset = "0x8036FB0", VA = "0x188037DB0")]
	private void LIOCFILLHGH(string LGOOKHKOCFM, string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8037920", Offset = "0x8036B20", VA = "0x188037920")]
	private string FAGPBBFCFHK(string LGOOKHKOCFM, string FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8037E60", Offset = "0x8037060", VA = "0x188037E60", Slot = "24")]
	public void MBHIFAPLADI(string LGOOKHKOCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8037F90", Offset = "0x8037190", VA = "0x188037F90")]
	private string NPKFLOGDMEK(string AGBHGDFILGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8037C10", Offset = "0x8036E10", VA = "0x188037C10", Slot = "25")]
	[AsyncStateMachine(typeof(KCOBALIJDAI))]
	public Task LBHHEHCHBLP(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8037D30", Offset = "0x8036F30", VA = "0x188037D30")]
	[IteratorStateMachine(typeof(EMBJBBPHNJA))]
	private IEnumerator<EAALCCOKLJL> LHLMPOIIOCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8037AB0", Offset = "0x8036CB0", VA = "0x188037AB0")]
	private void HKLHMNACGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8037A10", Offset = "0x8036C10", VA = "0x188037A10")]
	private void HACPFEDBGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8037850", Offset = "0x8036A50", VA = "0x188037850")]
	private void BGEOEGMGOLG(bool KMAODAFICID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CCPLLNHPJGH : IFBDCKMAEEM, HCGIJFAMGPM
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Dictionary<string, string> FJEKCAPAMID;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string OBDPBEPBOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8032590", Offset = "0x8031790", VA = "0x188032590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> MIFBEEEHINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8032940", Offset = "0x8031B40", VA = "0x188032940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action GEEKAEIJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	[UnityEngine.Scripting.Preserve]
	public CCPLLNHPJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "8")]
	public void DGDBEFAKGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x80328B0", Offset = "0x8031AB0", VA = "0x1880328B0", Slot = "6")]
	public Task HOPOIHNNBEL(long IGJFMDPEDFC, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8032240", Offset = "0x8031440", VA = "0x188032240", Slot = "14")]
	public float BMCPEPCPNJO(string AGBHGDFILGO, float FAGKKFIFNNI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8032C50", Offset = "0x8031E50", VA = "0x188032C50", Slot = "13")]
	public void LGBIHAGFDBB(string AGBHGDFILGO, bool MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x80327F0", Offset = "0x80319F0", VA = "0x1880327F0", Slot = "12")]
	public bool HANPJDENONC(string AGBHGDFILGO, bool FAGKKFIFNNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8032600", Offset = "0x8031800", VA = "0x188032600", Slot = "10")]
	public int DPCOCHBIIFH(string AGBHGDFILGO, int FAGKKFIFNNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8032980", Offset = "0x8031B80", VA = "0x188032980", Slot = "18")]
	public DateTime KKGNBOFJJNF(string LGOOKHKOCFM, [Optional] DateTime FAGKKFIFNNI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8032CC0", Offset = "0x8031EC0", VA = "0x188032CC0", Slot = "19")]
	public void LJNLLIGGNCJ(string AGBHGDFILGO, DateTime MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8032670", Offset = "0x8031870", VA = "0x188032670", Slot = "15")]
	public void FGCIOKMBNKA(string AGBHGDFILGO, float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x80321D0", Offset = "0x80313D0", VA = "0x1880321D0", Slot = "11")]
	public void ABOCHNGGNDD(string AGBHGDFILGO, int MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x80326E0", Offset = "0x80318E0", VA = "0x1880326E0", Slot = "20")]
	public long GGNBNJBBIDD(string LGOOKHKOCFM, long FAGKKFIFNNI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8032E80", Offset = "0x8032080", VA = "0x188032E80", Slot = "21")]
	public void MOGPNOOOCFG(string LGOOKHKOCFM, long MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x361B300", Offset = "0x361A500", VA = "0x18361B300", Slot = "22")]
	public T DJEMMMLAKDL<T>(string LGOOKHKOCFM, T FAGKKFIFNNI, COFCEIGKIJD<T> KKFGHJMMBAD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x361B300", Offset = "0x361A500", VA = "0x18361B300", Slot = "23")]
	public void PJHCFIFHGHA<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, COFCEIGKIJD<T> KKFGHJMMBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8032EF0", Offset = "0x80320F0", VA = "0x188032EF0", Slot = "16")]
	public string NFNKLDLHFAN(string AGBHGDFILGO, string FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8032750", Offset = "0x8031950", VA = "0x188032750", Slot = "17")]
	public void GNGPAIBPEAF(string AGBHGDFILGO, string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8032DC0", Offset = "0x8031FC0", VA = "0x188032DC0", Slot = "24")]
	public void MBHIFAPLADI(string AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8032D30", Offset = "0x8031F30", VA = "0x188032D30", Slot = "9")]
	public bool LPEJBEIEKEC(string AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x80329F0", Offset = "0x8031BF0", VA = "0x1880329F0", Slot = "25")]
	public Task LBHHEHCHBLP(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x361B440", Offset = "0x361A640", VA = "0x18361B440")]
	private T HKFPFFCEPKK<T>(string LGOOKHKOCFM, T FAGKKFIFNNI, [Optional] COFCEIGKIJD<T> GNCOBDAAGBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x361A290", Offset = "0x3619490", VA = "0x18361A290")]
	private void DENBCCCLIHH<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, [Optional] COFCEIGKIJD<T> GNCOBDAAGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x80322B0", Offset = "0x80314B0", VA = "0x1880322B0")]
	private Dictionary<string, string> BNBIFLBFALB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GGLODBMJCPL
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action GEEKAEIJKCN;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGDBEFAKGIL();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JHAJEGALMAH(long IGJFMDPEDFC);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DEALAPNDMBO(KPAIPNKBOOF MGOCCHEGKDC = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AEDAPHGAJLJ(string LGOOKHKOCFM, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NPEJIOICLFJ(string LGOOKHKOCFM, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string CPNNFDOFICB(string LGOOKHKOCFM, [Optional] string FAGKKFIFNNI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FPGKKBPJEMK AFBKCMGLEIC(string LGOOKHKOCFM, string MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int OANICPGCDCM(string LGOOKHKOCFM, int FAGKKFIFNNI = 0, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FPGKKBPJEMK NGIPOJFEEIL(string LGOOKHKOCFM, int MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DADFGNKAEPM(string LGOOKHKOCFM, bool FAGKKFIFNNI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FPGKKBPJEMK JCHLMDKIHJH(string LGOOKHKOCFM, bool MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float BKGCJDCBGCE(string LGOOKHKOCFM, float FAGKKFIFNNI = 0f, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FPGKKBPJEMK ANCNLNMMNDF(string LGOOKHKOCFM, float MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime JEAHPHEIOEN(string LGOOKHKOCFM, [Optional] DateTime FAGKKFIFNNI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FPGKKBPJEMK AJPKNECGMAC(string LGOOKHKOCFM, DateTime MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long LNHHPFFGJIJ(string LGOOKHKOCFM, long FAGKKFIFNNI = 0L, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FPGKKBPJEMK AOFHHHEOHHA(string LGOOKHKOCFM, long MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T KDOODOPDOJO<T>(string LGOOKHKOCFM, [Optional] T FAGKKFIFNNI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FPGKKBPJEMK FLMJILACMNG<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OKOLNKHEAAI(string LGOOKHKOCFM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool MGMPBFLLJBE(string LGOOKHKOCFM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string NHKLIHANAIE(string LGOOKHKOCFM, [Optional] string FAGKKFIFNNI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FPGKKBPJEMK CKMFCPOMNJG(string LGOOKHKOCFM, string MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int KLIDAHPNHEL(string LGOOKHKOCFM, int FAGKKFIFNNI = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	FPGKKBPJEMK EMEAPMBDBND(string LGOOKHKOCFM, int MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool GADDICEPIFM(string LGOOKHKOCFM, bool FAGKKFIFNNI);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	FPGKKBPJEMK OBDBAOIPBPP(string LGOOKHKOCFM, bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float MBKMAJNHBKH(string LGOOKHKOCFM, float FAGKKFIFNNI = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	FPGKKBPJEMK GFEELFHODLE(string LGOOKHKOCFM, float MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime CHNGMCCHFCP(string LGOOKHKOCFM, [Optional] DateTime FAGKKFIFNNI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	FPGKKBPJEMK NPAEFBDIEHC(string LGOOKHKOCFM, DateTime MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long MJDFBDGDLAG(string LGOOKHKOCFM, long FAGKKFIFNNI = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	FPGKKBPJEMK CHAPGEGLJKN(string LGOOKHKOCFM, long MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void GNOGIHIEABF<T>(COFCEIGKIJD<T> KKFGHJMMBAD, [Optional] IEqualityComparer<T> LEABKHICHOK);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HAHGOLCKGCG<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable PKANMLPMNHO();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void NFLENPDNFFG(float ODIBCCLKMAC);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task HKLHMNACGJI([Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FPGKKBPJEMK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EMLGOABBPJA : GGLODBMJCPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class ALKJCLAKDIM
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<ALKJCLAKDIM> PMKGOMFOLBD;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8032000", Offset = "0x8031200", VA = "0x188032000")]
		public static void KCMDFAKJCJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FKFEALEGJFP();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		protected ALKJCLAKDIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class HCMBFGPECFC<T> : ALKJCLAKDIM
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly HCMBFGPECFC<T> NDDGJHHDBNJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public COFCEIGKIJD<T> FBPBLECNGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> OAIJKOAHCAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JDFNKDDKEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x451F640", Offset = "0x451E840", VA = "0x18451F640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4B0F360", Offset = "0x4B0E560", VA = "0x184B0F360")]
		private HCMBFGPECFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4B0EE50", Offset = "0x4B0E050", VA = "0x184B0EE50")]
		public void OOCHIMKFMHO(COFCEIGKIJD<T> GNCOBDAAGBC, [Optional] IEqualityComparer<T> LEABKHICHOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4B0EC10", Offset = "0x4B0DE10", VA = "0x184B0EC10", Slot = "4")]
		public override void FKFEALEGJFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class KPBCBLHCDEJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly EMLGOABBPJA NAIIHCGBICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object EFNIABDIKLL;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8036DD0", Offset = "0x8035FD0", VA = "0x188036DD0")]
		public KPBCBLHCDEJ(EMLGOABBPJA NAIIHCGBICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8036DA0", Offset = "0x8035FA0", VA = "0x188036DA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LDEHLGOOJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public EMLGOABBPJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8036E80", Offset = "0x8036080", VA = "0x188036E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8037160", Offset = "0x8036360", VA = "0x188037160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct AGBCLKCCHLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public EMLGOABBPJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HCGIJFAMGPM backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8031E70", Offset = "0x8031070", VA = "0x188031E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct KLPJKEPKCPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public EMLGOABBPJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8036870", Offset = "0x8035A70", VA = "0x188036870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8036D40", Offset = "0x8035F40", VA = "0x188036D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OGPCNLBDADK : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EMLGOABBPJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public OGPCNLBDADK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8038F70", Offset = "0x8038170", VA = "0x188038F70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8039000", Offset = "0x8038200", VA = "0x188039000", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IFBDCKMAEEM CENMJCFEBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly IFBDCKMAEEM GPFPDNNKJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly IFEDNKFCEHI PBODDHNLOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEHEEDGPPGD ELNMJLOPIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NCBGKLECCOI.NMAGCCJNHAC NLHMEPCGJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IHHCNLCAMGC CFFPIPGFMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<HCGIJFAMGPM> OEKKEKBLJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task DKMMDFCJBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> HDOLLFPICPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private PEFNPNHCEAP IPGAJDNEPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object JBHFOFCIPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object GGOBGDICPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long HFCFPOLCKFL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool HIFKGIOFEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8033D10", Offset = "0x8032F10", VA = "0x188033D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource NDNGPJNEMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GEEKAEIJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8035FD0", Offset = "0x80351D0", VA = "0x188035FD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8034450", Offset = "0x8033650", VA = "0x188034450", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x80354C0", Offset = "0x80346C0", VA = "0x1880354C0")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	internal static void LNFJKPHMEBL(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8036070", Offset = "0x8035270", VA = "0x188036070")]
	[UnityEngine.Scripting.Preserve]
	public EMLGOABBPJA([ALHAHLCGLLK("Disk")] IFBDCKMAEEM CENMJCFEBEK, [ALHAHLCGLLK("Cloud")] IFBDCKMAEEM GPFPDNNKJBO, [ALHAHLCGLLK(null)] IFEDNKFCEHI PBODDHNLOCN, [ALHAHLCGLLK(null)] IEHEEDGPPGD ELNMJLOPIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8034560", Offset = "0x8033760", VA = "0x188034560", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x80345D0", Offset = "0x80337D0", VA = "0x1880345D0")]
	private void FCGEMMIGGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x80344F0", Offset = "0x80336F0", VA = "0x1880344F0", Slot = "6")]
	public void DGDBEFAKGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8034F30", Offset = "0x8034130", VA = "0x188034F30", Slot = "7")]
	public Task JHAJEGALMAH(long IGJFMDPEDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8035100", Offset = "0x8034300", VA = "0x188035100")]
	[AsyncStateMachine(typeof(LDEHLGOOJJE))]
	private Task KEGFHFIIIMC(long IGJFMDPEDFC, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8034D00", Offset = "0x8033F00", VA = "0x188034D00")]
	private void IAPOGEDGPOJ(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8035440", Offset = "0x8034640", VA = "0x188035440")]
	private void LMCBJANBPKJ(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8033AC0", Offset = "0x8032CC0", VA = "0x188033AC0")]
	private string BJFHFHLEOBJ(string DMBFPNBNHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x80340A0", Offset = "0x80332A0", VA = "0x1880340A0")]
	private void CPIGKDIMMGB(KPAIPNKBOOF MGOCCHEGKDC, string AGBHGDFILGO, [Out] IFBDCKMAEEM LHLEAOBBCEG, [Out] string NNJBDNANBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8033250", Offset = "0x8032450", VA = "0x188033250")]
	private IFBDCKMAEEM ABLMAIPHPAJ(KPAIPNKBOOF MGOCCHEGKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8034390", Offset = "0x8033590", VA = "0x188034390", Slot = "8")]
	public bool DEALAPNDMBO(KPAIPNKBOOF MGOCCHEGKDC = KPAIPNKBOOF.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x80332D0", Offset = "0x80324D0", VA = "0x1880332D0", Slot = "9")]
	public bool AEDAPHGAJLJ(string LGOOKHKOCFM, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x80358E0", Offset = "0x8034AE0", VA = "0x1880358E0", Slot = "10")]
	public bool NPEJIOICLFJ(string LGOOKHKOCFM, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8034240", Offset = "0x8033440", VA = "0x188034240", Slot = "11")]
	public string CPNNFDOFICB(string LGOOKHKOCFM, [Optional] string FAGKKFIFNNI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8033370", Offset = "0x8032570", VA = "0x188033370", Slot = "12")]
	public FPGKKBPJEMK AFBKCMGLEIC(string LGOOKHKOCFM, string MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8035A60", Offset = "0x8034C60", VA = "0x188035A60", Slot = "13")]
	public int OANICPGCDCM(string LGOOKHKOCFM, int FAGKKFIFNNI = 0, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x80356D0", Offset = "0x80348D0", VA = "0x1880356D0", Slot = "14")]
	public FPGKKBPJEMK NGIPOJFEEIL(string LGOOKHKOCFM, int MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x80342E0", Offset = "0x80334E0", VA = "0x1880342E0", Slot = "15")]
	public bool DADFGNKAEPM(string LGOOKHKOCFM, bool FAGKKFIFNNI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8034D20", Offset = "0x8033F20", VA = "0x188034D20", Slot = "16")]
	public FPGKKBPJEMK JCHLMDKIHJH(string LGOOKHKOCFM, bool MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8033B20", Offset = "0x8032D20", VA = "0x188033B20", Slot = "17")]
	public float BKGCJDCBGCE(string LGOOKHKOCFM, float FAGKKFIFNNI = 0f, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8033690", Offset = "0x8032890", VA = "0x188033690", Slot = "18")]
	public FPGKKBPJEMK ANCNLNMMNDF(string LGOOKHKOCFM, float MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8034E90", Offset = "0x8034090", VA = "0x188034E90", Slot = "19")]
	public DateTime JEAHPHEIOEN(string LGOOKHKOCFM, [Optional] DateTime FAGKKFIFNNI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x80334F0", Offset = "0x80326F0", VA = "0x1880334F0", Slot = "20")]
	public FPGKKBPJEMK AJPKNECGMAC(string LGOOKHKOCFM, DateTime MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8035530", Offset = "0x8034730", VA = "0x188035530", Slot = "21")]
	public long LNHHPFFGJIJ(string LGOOKHKOCFM, long FAGKKFIFNNI = 0L, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8033810", Offset = "0x8032A10", VA = "0x188033810", Slot = "22")]
	public FPGKKBPJEMK AOFHHHEOHHA(string LGOOKHKOCFM, long MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x36A22C0", Offset = "0x36A14C0", VA = "0x1836A22C0", Slot = "23")]
	public T KDOODOPDOJO<T>(string LGOOKHKOCFM, [Optional] T FAGKKFIFNNI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x36A22C0", Offset = "0x36A14C0", VA = "0x1836A22C0", Slot = "24")]
	public FPGKKBPJEMK FLMJILACMNG<T>(string LGOOKHKOCFM, T MLCDCHNOCFI, KPAIPNKBOOF POMHKDJHIPG = KPAIPNKBOOF.CLOUD)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8035E60", Offset = "0x8035060", VA = "0x188035E60", Slot = "25")]
	public bool OKOLNKHEAAI(string LGOOKHKOCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8035640", Offset = "0x8034840", VA = "0x188035640", Slot = "26")]
	public bool MGMPBFLLJBE(string LGOOKHKOCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8035840", Offset = "0x8034A40", VA = "0x188035840", Slot = "27")]
	public string NHKLIHANAIE(string LGOOKHKOCFM, [Optional] string FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8034070", Offset = "0x8033270", VA = "0x188034070", Slot = "28")]
	public FPGKKBPJEMK CKMFCPOMNJG(string LGOOKHKOCFM, string MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8035270", Offset = "0x8034470", VA = "0x188035270", Slot = "29")]
	public int KLIDAHPNHEL(string LGOOKHKOCFM, int FAGKKFIFNNI = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x80345A0", Offset = "0x80337A0", VA = "0x1880345A0", Slot = "30")]
	public FPGKKBPJEMK EMEAPMBDBND(string LGOOKHKOCFM, int MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8034A10", Offset = "0x8033C10", VA = "0x188034A10", Slot = "31")]
	public bool GADDICEPIFM(string LGOOKHKOCFM, bool FAGKKFIFNNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8035B10", Offset = "0x8034D10", VA = "0x188035B10", Slot = "32")]
	public FPGKKBPJEMK OBDBAOIPBPP(string LGOOKHKOCFM, bool MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x80355D0", Offset = "0x80347D0", VA = "0x1880355D0", Slot = "33")]
	public float MBKMAJNHBKH(string LGOOKHKOCFM, float FAGKKFIFNNI = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8034A80", Offset = "0x8033C80", VA = "0x188034A80", Slot = "34")]
	public FPGKKBPJEMK GFEELFHODLE(string LGOOKHKOCFM, float MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8033D60", Offset = "0x8032F60", VA = "0x188033D60", Slot = "35")]
	public DateTime CHNGMCCHFCP(string LGOOKHKOCFM, [Optional] DateTime FAGKKFIFNNI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x80358B0", Offset = "0x8034AB0", VA = "0x1880358B0", Slot = "36")]
	public FPGKKBPJEMK NPAEFBDIEHC(string LGOOKHKOCFM, DateTime MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8035650", Offset = "0x8034850", VA = "0x188035650", Slot = "37")]
	public long MJDFBDGDLAG(string LGOOKHKOCFM, long FAGKKFIFNNI = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8033D30", Offset = "0x8032F30", VA = "0x188033D30", Slot = "38")]
	public FPGKKBPJEMK CHAPGEGLJKN(string LGOOKHKOCFM, long MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8035210", Offset = "0x8034410", VA = "0x188035210")]
	private bool KJHAPAINMEE(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8034BA0", Offset = "0x8033DA0", VA = "0x188034BA0")]
	private bool HNHNNGCDONB(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8033DD0", Offset = "0x8032FD0", VA = "0x188033DD0")]
	private FPGKKBPJEMK CIAGKLFHOBN(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, string MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8033BD0", Offset = "0x8032DD0", VA = "0x188033BD0")]
	private FPGKKBPJEMK BOKHGKEBCHF(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, int MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8035B40", Offset = "0x8034D40", VA = "0x188035B40")]
	private FPGKKBPJEMK OKGODEIEMMP(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, bool MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8033F20", Offset = "0x8033120", VA = "0x188033F20")]
	private FPGKKBPJEMK CKIBBGGJDOM(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, float MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8034620", Offset = "0x8033820", VA = "0x188034620")]
	private FPGKKBPJEMK FNGCOOPNLCB(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, DateTime MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8033980", Offset = "0x8032B80", VA = "0x188033980")]
	private FPGKKBPJEMK BHOBIPHNABI(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, long MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x36A1D60", Offset = "0x36A0F60", VA = "0x1836A1D60")]
	private T EEIMJKMGGJI<T>(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, T FAGKKFIFNNI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x36A1180", Offset = "0x36A0380", VA = "0x1836A1180")]
	private FPGKKBPJEMK CEGKPGFIKFJ<T>(HCGIJFAMGPM LHLEAOBBCEG, string LGOOKHKOCFM, T MLCDCHNOCFI)
	{
		return default(FPGKKBPJEMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x36A2490", Offset = "0x36A1690", VA = "0x1836A2490", Slot = "39")]
	public void GNOGIHIEABF<T>(COFCEIGKIJD<T> KKFGHJMMBAD, [Optional] IEqualityComparer<T> LEABKHICHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x36A2540", Offset = "0x36A1740", VA = "0x1836A2540", Slot = "40")]
	public void HAHGOLCKGCG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8035370", Offset = "0x8034570", VA = "0x188035370")]
	[AsyncStateMachine(typeof(AGBCLKCCHLI))]
	private void LBHHEHCHBLP(HCGIJFAMGPM MGLJKNNDIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8034AB0", Offset = "0x8033CB0", VA = "0x188034AB0", Slot = "43")]
	[AsyncStateMachine(typeof(KLPJKEPKCPN))]
	public Task HKLHMNACGJI([Optional] CancellationToken PPOILDCNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8035C80", Offset = "0x8034E80", VA = "0x188035C80")]
	private void OKMIJMPHEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8035EF0", Offset = "0x80350F0", VA = "0x188035EF0", Slot = "41")]
	public IDisposable PKANMLPMNHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x80356C0", Offset = "0x80348C0", VA = "0x1880356C0", Slot = "42")]
	public void NFLENPDNFFG(float ODIBCCLKMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8034790", Offset = "0x8033990", VA = "0x188034790")]
	private void FPAGJCMDCCJ(float ENGOKOHOJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x80352E0", Offset = "0x80344E0", VA = "0x1880352E0")]
	[IteratorStateMachine(typeof(OGPCNLBDADK))]
	private IEnumerator<EAALCCOKLJL> KODFLIJDAHE(float ODIBCCLKMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8035EC0", Offset = "0x80350C0", VA = "0x188035EC0")]
	[CompilerGenerated]
	private void PFGPBBMEHBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NGFJKLCGGFK : BNHGMLNCOLP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static NGFJKLCGGFK NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8038BD0", Offset = "0x8037DD0", VA = "0x188038BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8038AE0", Offset = "0x8037CE0", VA = "0x188038AE0", Slot = "9")]
	public override string CEBCPPBDNIB(bool EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8038C20", Offset = "0x8037E20", VA = "0x188038C20", Slot = "10")]
	protected override bool FLMCMOIELJG(string EEEOGOJIPGB, [Out] bool MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8038F30", Offset = "0x8038130", VA = "0x188038F30")]
	public NGFJKLCGGFK()
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
