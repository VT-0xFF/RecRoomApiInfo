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
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GBAECHNKLGE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class OOEODOABGDL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6052510", Offset = "0x6051110", VA = "0x186052510")]
	private static void GIMEGFBKNHE(NMGFAAFFNCI ODMEKLBIDGM, Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6052590", Offset = "0x6051190", VA = "0x186052590")]
	public static bool HECEOIKPNBA(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60527C0", Offset = "0x60513C0", VA = "0x1860527C0")]
	public static FHJGMNECFBO JHLBJEPNGPO(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, string GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60523D0", Offset = "0x6050FD0", VA = "0x1860523D0")]
	public static FHJGMNECFBO COIBEIPFNBB(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, int GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6052910", Offset = "0x6051510", VA = "0x186052910")]
	public static FHJGMNECFBO MMDIHENHEBA(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, bool GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6052A60", Offset = "0x6051660", VA = "0x186052A60")]
	public static FHJGMNECFBO NIPMIDOAKHI(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, float GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6052BB0", Offset = "0x60517B0", VA = "0x186052BB0")]
	public static FHJGMNECFBO PGEOLLGJGJF(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, DateTime GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6052680", Offset = "0x6051280", VA = "0x186052680")]
	public static FHJGMNECFBO JGAKLIFKAMI(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, long GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BAAKCPEGEKE : LGOMJOCAHBC, NMGFAAFFNCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ABBFHOMHOIC BNDONJNDAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> KNAKJGJKFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> BOCPDCCFDGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> KEIJHACBGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6048F60", Offset = "0x6047B60", VA = "0x186048F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LKJJBJPIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x604A170", Offset = "0x6048D70", VA = "0x18604A170")]
	[Preserve]
	public BAAKCPEGEKE([DLBAGNNJKKK(null)] ABBFHOMHOIC BNDONJNDAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "8")]
	public void OJPFIOFHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6049550", Offset = "0x6048150", VA = "0x186049550")]
	private DirectoryInfo FHJKHBPEIIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6049AA0", Offset = "0x60486A0", VA = "0x186049AA0", Slot = "6")]
	public Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60494E0", Offset = "0x60480E0", VA = "0x1860494E0", Slot = "14")]
	public float CLKPJCAGNCL(string PPNDANAOAMK, float MLNCHKABKBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6049BC0", Offset = "0x60487C0", VA = "0x186049BC0", Slot = "13")]
	public void LAMIBMBPHCJ(string PPNDANAOAMK, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x604A030", Offset = "0x6048C30", VA = "0x18604A030", Slot = "12")]
	public bool OGEAOEPLDHC(string PPNDANAOAMK, bool MLNCHKABKBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60498A0", Offset = "0x60484A0", VA = "0x1860498A0", Slot = "10")]
	public int JCEPEKBOCLO(string PPNDANAOAMK, int MLNCHKABKBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6049FC0", Offset = "0x6048BC0", VA = "0x186049FC0", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60499C0", Offset = "0x60485C0", VA = "0x1860499C0", Slot = "19")]
	public void JDFIOPKBDDE(string PPNDANAOAMK, DateTime GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6049730", Offset = "0x6048330", VA = "0x186049730", Slot = "15")]
	public void IBNPNHHIBCC(string PPNDANAOAMK, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6049650", Offset = "0x6048250", VA = "0x186049650", Slot = "11")]
	public void FNBFDLLCFDO(string PPNDANAOAMK, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60496C0", Offset = "0x60482C0", VA = "0x1860496C0", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x604A100", Offset = "0x6048D00", VA = "0x18604A100", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22A6DD0", Offset = "0x22A59D0", VA = "0x1822A6DD0", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22A6D30", Offset = "0x22A5930", VA = "0x1822A6D30", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6049910", Offset = "0x6048510", VA = "0x186049910", Slot = "16")]
	public string JCLIFBPHEGF(string PPNDANAOAMK, string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6049A30", Offset = "0x6048630", VA = "0x186049A30", Slot = "17")]
	public void KMBBDELAOFH(string PPNDANAOAMK, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6048EA0", Offset = "0x6047AA0", VA = "0x186048EA0", Slot = "24")]
	public void ACBHJNFICOE(string PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6049B30", Offset = "0x6048730", VA = "0x186049B30", Slot = "9")]
	public bool LACBJOIFHKC(string PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6048FA0", Offset = "0x6047BA0", VA = "0x186048FA0", Slot = "25")]
	public Task CGLBPEOMMNO(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6049C30", Offset = "0x6048830", VA = "0x186049C30")]
	private void LDIBALAGPPJ(DirectoryInfo IBMCBOGIEME, string HLDGKGEJILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60492E0", Offset = "0x6047EE0", VA = "0x1860492E0")]
	private static string CICIGEONFPE(string PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60497A0", Offset = "0x60483A0", VA = "0x1860497A0")]
	private static string JAFJLEKLIOG(byte[] FEGEJBFJFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x22A7EA0", Offset = "0x22A6AA0", VA = "0x1822A7EA0")]
	private T IOOJPMIEEDI<T>(string DKLHENCIMJI, T MLNCHKABKBO, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x22A6EE0", Offset = "0x22A5AE0", VA = "0x1822A6EE0")]
	private void INLCAGHFLDH<T>(string DKLHENCIMJI, T GCPEEAODAIB, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60486E0", Offset = "0x60472E0", VA = "0x1860486E0")]
	private Dictionary<string, string> AAKELCAIOHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class MKEKFEJDEGK
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x604D1E0", Offset = "0x604BDE0", VA = "0x18604D1E0")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	private static void JKFPJJDDAIM(OKOCNPPIKGG PCOJMOHPOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IFFPHPABDLB : ICKPEBNINLM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x604BF30", Offset = "0x604AB30", VA = "0x18604BF30")]
	[Preserve]
	public IFFPHPABDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ICKPEBNINLM : LGOMJOCAHBC, NMGFAAFFNCI, NAJEPNPMIED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> NIPEIMHBDEB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LKJJBJPIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "8")]
	public void OJPFIOFHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x604BCC0", Offset = "0x604A8C0", VA = "0x18604BCC0", Slot = "6")]
	public Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x604BD50", Offset = "0x604A950", VA = "0x18604BD50", Slot = "9")]
	public bool LACBJOIFHKC(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x604BB40", Offset = "0x604A740", VA = "0x18604BB40", Slot = "10")]
	public int JCEPEKBOCLO(string DKLHENCIMJI, int MLNCHKABKBO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x604BA20", Offset = "0x604A620", VA = "0x18604BA20", Slot = "11")]
	public void FNBFDLLCFDO(string DKLHENCIMJI, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x604BE70", Offset = "0x604AA70", VA = "0x18604BE70", Slot = "12")]
	public bool OGEAOEPLDHC(string DKLHENCIMJI, bool MLNCHKABKBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x604BDB0", Offset = "0x604A9B0", VA = "0x18604BDB0", Slot = "13")]
	public void LAMIBMBPHCJ(string DKLHENCIMJI, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x604B9C0", Offset = "0x604A5C0", VA = "0x18604B9C0", Slot = "14")]
	public float CLKPJCAGNCL(string DKLHENCIMJI, float MLNCHKABKBO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x604BAE0", Offset = "0x604A6E0", VA = "0x18604BAE0", Slot = "15")]
	public void IBNPNHHIBCC(string DKLHENCIMJI, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x604BBA0", Offset = "0x604A7A0", VA = "0x18604BBA0", Slot = "16")]
	public string JCLIFBPHEGF(string DKLHENCIMJI, [Optional] string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x604BC60", Offset = "0x604A860", VA = "0x18604BC60", Slot = "17")]
	public void KMBBDELAOFH(string DKLHENCIMJI, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x604BE10", Offset = "0x604AA10", VA = "0x18604BE10", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x604BC00", Offset = "0x604A800", VA = "0x18604BC00", Slot = "19")]
	public void JDFIOPKBDDE(string DKLHENCIMJI, DateTime GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x604BA80", Offset = "0x604A680", VA = "0x18604BA80", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x604BED0", Offset = "0x604AAD0", VA = "0x18604BED0", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x252B000", Offset = "0x2529C00", VA = "0x18252B000", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x252AF60", Offset = "0x2529B60", VA = "0x18252AF60", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x252B5F0", Offset = "0x252A1F0", VA = "0x18252B5F0")]
	public T IOOJPMIEEDI<T>(string DKLHENCIMJI, T MLNCHKABKBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x252B100", Offset = "0x2529D00", VA = "0x18252B100")]
	public void INLCAGHFLDH<T>(string DKLHENCIMJI, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x604B8D0", Offset = "0x604A4D0", VA = "0x18604B8D0", Slot = "24")]
	public void ACBHJNFICOE(string DKLHENCIMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x604B930", Offset = "0x604A530", VA = "0x18604B930", Slot = "25")]
	public Task CGLBPEOMMNO(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x604BF30", Offset = "0x604AB30", VA = "0x18604BF30")]
	public ICKPEBNINLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class AMCLONDHIPI<TParent> where TParent : NMGFAAFFNCI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<AMCLONDHIPI<TParent>> LJLGKHCPKCK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x371E7F0", Offset = "0x371D3F0", VA = "0x18371E7F0")]
	protected AMCLONDHIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void GMINFKPEKLF();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void NBFDKABCBBG(string PPNDANAOAMK);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x371E240", Offset = "0x371CE40", VA = "0x18371E240")]
	public static void CAJMLGLLLHE(string PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x371E480", Offset = "0x371D080", VA = "0x18371E480")]
	public static void FGBCCKGKKPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AMHIJICICPO<TParent, TValue> : AMCLONDHIPI<TParent> where TParent : NMGFAAFFNCI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly AMHIJICICPO<TParent, TValue> IJJIHHKLCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> LKHGJLBEKMJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x371E9C0", Offset = "0x371D5C0", VA = "0x18371E9C0")]
	public bool IKGDLKABABA(string KPCNLIOCEMG, [Out] TValue DCHFBFKHEBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x371E8E0", Offset = "0x371D4E0", VA = "0x18371E8E0")]
	public void CNGOCBBIINE(string KPCNLIOCEMG, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x371E990", Offset = "0x371D590", VA = "0x18371E990", Slot = "4")]
	protected override void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3708D20", Offset = "0x3707920", VA = "0x183708D20", Slot = "5")]
	protected override void NBFDKABCBBG(string KPCNLIOCEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x371EB30", Offset = "0x371D730", VA = "0x18371EB30")]
	public AMHIJICICPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NMGFAAFFNCI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJPFIOFHICO();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LACBJOIFHKC(string DKLHENCIMJI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JCEPEKBOCLO(string DKLHENCIMJI, int MLNCHKABKBO = 0);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNBFDLLCFDO(string DKLHENCIMJI, int GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OGEAOEPLDHC(string DKLHENCIMJI, bool MLNCHKABKBO = false);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LAMIBMBPHCJ(string DKLHENCIMJI, bool GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float CLKPJCAGNCL(string DKLHENCIMJI, float MLNCHKABKBO = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IBNPNHHIBCC(string DKLHENCIMJI, float GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string JCLIFBPHEGF(string DKLHENCIMJI, [Optional] string MLNCHKABKBO);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KMBBDELAOFH(string DKLHENCIMJI, string GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime NPCNHIGLAOD);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JDFIOPKBDDE(string DKLHENCIMJI, DateTime NPCNHIGLAOD);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ACBHJNFICOE(string DKLHENCIMJI);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task CGLBPEOMMNO([Optional] CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LGOMJOCAHBC : NMGFAAFFNCI
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LKJJBJPIBOB;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NAJEPNPMIED : NMGFAAFFNCI
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ODGJHHNEFIK : LGOMJOCAHBC, NMGFAAFFNCI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct CHMBECJALPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ODGJHHNEFIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x604A210", Offset = "0x6048E10", VA = "0x18604A210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x604A3A0", Offset = "0x6048FA0", VA = "0x18604A3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct MBKNIIMFBBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public ODGJHHNEFIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x604CE90", Offset = "0x604BA90", VA = "0x18604CE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x604D180", Offset = "0x604BD80", VA = "0x18604D180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LGOMJOCAHBC BEBAKCCNOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly BAAKCPEGEKE DGONBAIMOLD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x604E250", Offset = "0x604CE50", VA = "0x18604E250", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LKJJBJPIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x604D870", Offset = "0x604C470", VA = "0x18604D870", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x604E2B0", Offset = "0x604CEB0", VA = "0x18604E2B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x604E580", Offset = "0x604D180", VA = "0x18604E580")]
	[Preserve]
	public ODGJHHNEFIK([DLBAGNNJKKK(null)] ABBFHOMHOIC BNDONJNDAPK, [DLBAGNNJKKK("Disk_Unity")] LGOMJOCAHBC BEBAKCCNOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x604E4B0", Offset = "0x604D0B0", VA = "0x18604E4B0", Slot = "8")]
	public void OJPFIOFHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x604DFF0", Offset = "0x604CBF0", VA = "0x18604DFF0", Slot = "9")]
	public bool LACBJOIFHKC(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x604DB10", Offset = "0x604C710", VA = "0x18604DB10", Slot = "10")]
	public int JCEPEKBOCLO(string DKLHENCIMJI, int MLNCHKABKBO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x604D8D0", Offset = "0x604C4D0", VA = "0x18604D8D0", Slot = "11")]
	public void FNBFDLLCFDO(string DKLHENCIMJI, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x604E320", Offset = "0x604CF20", VA = "0x18604E320", Slot = "12")]
	public bool OGEAOEPLDHC(string DKLHENCIMJI, bool MLNCHKABKBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x604E080", Offset = "0x604CC80", VA = "0x18604E080", Slot = "13")]
	public void LAMIBMBPHCJ(string DKLHENCIMJI, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x604D710", Offset = "0x604C310", VA = "0x18604D710", Slot = "14")]
	public float CLKPJCAGNCL(string DKLHENCIMJI, float MLNCHKABKBO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x604DAA0", Offset = "0x604C6A0", VA = "0x18604DAA0", Slot = "15")]
	public void IBNPNHHIBCC(string DKLHENCIMJI, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x604DC60", Offset = "0x604C860", VA = "0x18604DC60", Slot = "16")]
	public string JCLIFBPHEGF(string DKLHENCIMJI, [Optional] string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x604DE70", Offset = "0x604CA70", VA = "0x18604DE70", Slot = "17")]
	public void KMBBDELAOFH(string DKLHENCIMJI, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x604E0F0", Offset = "0x604CCF0", VA = "0x18604E0F0", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x604DE00", Offset = "0x604CA00", VA = "0x18604DE00", Slot = "19")]
	public void JDFIOPKBDDE(string DKLHENCIMJI, DateTime NPCNHIGLAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x604D940", Offset = "0x604C540", VA = "0x18604D940", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x604E510", Offset = "0x604D110", VA = "0x18604E510", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x26420C0", Offset = "0x2640CC0", VA = "0x1826420C0", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2641FF0", Offset = "0x2640BF0", VA = "0x182641FF0", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x604D510", Offset = "0x604C110", VA = "0x18604D510", Slot = "24")]
	public void ACBHJNFICOE(string DKLHENCIMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x604D620", Offset = "0x604C220", VA = "0x18604D620", Slot = "25")]
	[AsyncStateMachine(typeof(CHMBECJALPK))]
	public Task CGLBPEOMMNO([Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x604DEE0", Offset = "0x604CAE0", VA = "0x18604DEE0", Slot = "6")]
	[AsyncStateMachine(typeof(MBKNIIMFBBE))]
	public Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LOJDHJGIBDO : LGOMJOCAHBC, NMGFAAFFNCI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LAABLGLKPJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public LOJDHJGIBDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x604C160", Offset = "0x604AD60", VA = "0x18604C160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x604C530", Offset = "0x604B130", VA = "0x18604C530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JDJOPOGIHDL : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public LOJDHJGIBDO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public JDJOPOGIHDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x604BFC0", Offset = "0x604ABC0", VA = "0x18604BFC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x604C030", Offset = "0x604AC30", VA = "0x18604C030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ABBFHOMHOIC BNDONJNDAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool NNMONLKGFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool DCDKALHBMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MBGPIBEMOCP GNLNBDCDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private IHPHLOENKON BGPCBOKDGKJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LKJJBJPIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x604CDA0", Offset = "0x604B9A0", VA = "0x18604CDA0")]
	[Preserve]
	public LOJDHJGIBDO([DLBAGNNJKKK(null)] ABBFHOMHOIC BNDONJNDAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "8")]
	public void OJPFIOFHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x604CB10", Offset = "0x604B710", VA = "0x18604CB10", Slot = "6")]
	public Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x51BD4C0", Offset = "0x51BC0C0", VA = "0x1851BD4C0")]
	private static int NHBPBMPOCOL(bool GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x604CBA0", Offset = "0x604B7A0", VA = "0x18604CBA0", Slot = "9")]
	public bool LACBJOIFHKC(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x604CA10", Offset = "0x604B610", VA = "0x18604CA10", Slot = "10")]
	public int JCEPEKBOCLO(string DKLHENCIMJI, int MLNCHKABKBO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x604C840", Offset = "0x604B440", VA = "0x18604C840", Slot = "11")]
	public void FNBFDLLCFDO(string DKLHENCIMJI, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x604CD00", Offset = "0x604B900", VA = "0x18604CD00", Slot = "12")]
	public bool OGEAOEPLDHC(string DKLHENCIMJI, bool MLNCHKABKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x604CBC0", Offset = "0x604B7C0", VA = "0x18604CBC0", Slot = "13")]
	public void LAMIBMBPHCJ(string DKLHENCIMJI, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x604C730", Offset = "0x604B330", VA = "0x18604C730", Slot = "14")]
	public float CLKPJCAGNCL(string DKLHENCIMJI, float MLNCHKABKBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x604C9C0", Offset = "0x604B5C0", VA = "0x18604C9C0", Slot = "15")]
	public void IBNPNHHIBCC(string DKLHENCIMJI, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x604CC90", Offset = "0x604B890", VA = "0x18604CC90", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x604CA70", Offset = "0x604B670", VA = "0x18604CA70", Slot = "19")]
	public void JDFIOPKBDDE(string DKLHENCIMJI, DateTime NPCNHIGLAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x604C870", Offset = "0x604B470", VA = "0x18604C870", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x604CD30", Offset = "0x604B930", VA = "0x18604CD30", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x257ADA0", Offset = "0x25799A0", VA = "0x18257ADA0", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x257AC70", Offset = "0x2579870", VA = "0x18257AC70", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x257AF60", Offset = "0x2579B60", VA = "0x18257AF60")]
	private T IGEOKIFFOKJ<T>(string DKLHENCIMJI, T MLNCHKABKBO, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x257B9B0", Offset = "0x257A5B0", VA = "0x18257B9B0")]
	private void JMBHKOOIFBM<T>(string DKLHENCIMJI, T GCPEEAODAIB, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x604CA40", Offset = "0x604B640", VA = "0x18604CA40", Slot = "16")]
	public string JCLIFBPHEGF(string DKLHENCIMJI, string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x604CAE0", Offset = "0x604B6E0", VA = "0x18604CAE0", Slot = "17")]
	public void KMBBDELAOFH(string DKLHENCIMJI, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x604C620", Offset = "0x604B220", VA = "0x18604C620")]
	private void BNBJEFFHCIP(string DKLHENCIMJI, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x604C9F0", Offset = "0x604B5F0", VA = "0x18604C9F0")]
	private string IELPFOKMHPH(string DKLHENCIMJI, string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x604C590", Offset = "0x604B190", VA = "0x18604C590", Slot = "24")]
	public void ACBHJNFICOE(string DKLHENCIMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x604CBF0", Offset = "0x604B7F0", VA = "0x18604CBF0")]
	private string LOADJAGPAFK(string PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x604C640", Offset = "0x604B240", VA = "0x18604C640", Slot = "25")]
	[AsyncStateMachine(typeof(LAABLGLKPJH))]
	public Task CGLBPEOMMNO(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x604C8E0", Offset = "0x604B4E0", VA = "0x18604C8E0")]
	[IteratorStateMachine(typeof(JDJOPOGIHDL))]
	private IEnumerator<MJMKCFLBGFK> HILFNGOKHJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x604C960", Offset = "0x604B560", VA = "0x18604C960")]
	private void HMMDNGOBMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x604C7D0", Offset = "0x604B3D0", VA = "0x18604C7D0")]
	private void FMAICLNKDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x604C760", Offset = "0x604B360", VA = "0x18604C760")]
	private void FIJIAJLEDBO(bool MBPENCGBADO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GBKPCAOFPJK : LGOMJOCAHBC, NMGFAAFFNCI
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Dictionary<string, string> BOCPDCCFDGI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BKIHKFDKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x78C390", Offset = "0x78AF90", VA = "0x18078C390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string JDDIIIIEBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x604B6D0", Offset = "0x604A2D0", VA = "0x18604B6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> KEIJHACBGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x604ACF0", Offset = "0x60498F0", VA = "0x18604ACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action LKJJBJPIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	[Preserve]
	public GBKPCAOFPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "8")]
	public void OJPFIOFHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x604B390", Offset = "0x6049F90", VA = "0x18604B390", Slot = "6")]
	public Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x604AFA0", Offset = "0x6049BA0", VA = "0x18604AFA0", Slot = "14")]
	public float CLKPJCAGNCL(string PPNDANAOAMK, float MLNCHKABKBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x604B4B0", Offset = "0x604A0B0", VA = "0x18604B4B0", Slot = "13")]
	public void LAMIBMBPHCJ(string PPNDANAOAMK, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x604B590", Offset = "0x604A190", VA = "0x18604B590", Slot = "12")]
	public bool OGEAOEPLDHC(string PPNDANAOAMK, bool MLNCHKABKBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x604B160", Offset = "0x6049D60", VA = "0x18604B160", Slot = "10")]
	public int JCEPEKBOCLO(string PPNDANAOAMK, int MLNCHKABKBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x604B520", Offset = "0x604A120", VA = "0x18604B520", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x604B280", Offset = "0x6049E80", VA = "0x18604B280", Slot = "19")]
	public void JDFIOPKBDDE(string PPNDANAOAMK, DateTime GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x604B0F0", Offset = "0x6049CF0", VA = "0x18604B0F0", Slot = "15")]
	public void IBNPNHHIBCC(string PPNDANAOAMK, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x604B010", Offset = "0x6049C10", VA = "0x18604B010", Slot = "11")]
	public void FNBFDLLCFDO(string PPNDANAOAMK, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x604B080", Offset = "0x6049C80", VA = "0x18604B080", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x604B660", Offset = "0x604A260", VA = "0x18604B660", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x22A6DD0", Offset = "0x22A59D0", VA = "0x1822A6DD0", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x22A6D30", Offset = "0x22A5930", VA = "0x1822A6D30", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x604B1D0", Offset = "0x6049DD0", VA = "0x18604B1D0", Slot = "16")]
	public string JCLIFBPHEGF(string PPNDANAOAMK, string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x604B2F0", Offset = "0x6049EF0", VA = "0x18604B2F0", Slot = "17")]
	public void KMBBDELAOFH(string PPNDANAOAMK, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x604AC30", Offset = "0x6049830", VA = "0x18604AC30", Slot = "24")]
	public void ACBHJNFICOE(string PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x604B420", Offset = "0x604A020", VA = "0x18604B420", Slot = "9")]
	public bool LACBJOIFHKC(string PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x604AD30", Offset = "0x6049930", VA = "0x18604AD30", Slot = "25")]
	public Task CGLBPEOMMNO(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x24F64F0", Offset = "0x24F50F0", VA = "0x1824F64F0")]
	private T IOOJPMIEEDI<T>(string DKLHENCIMJI, T MLNCHKABKBO, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x24F55B0", Offset = "0x24F41B0", VA = "0x1824F55B0")]
	private void INLCAGHFLDH<T>(string DKLHENCIMJI, T GCPEEAODAIB, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x604A930", Offset = "0x6049530", VA = "0x18604A930")]
	private Dictionary<string, string> AAKELCAIOHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ECKJGDJNJNM
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LKJJBJPIBOB;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJPFIOFHICO();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NEOPHCFKHCA(long PBNCAIAOMJK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LFCOOHMGAFJ(GBAECHNKLGE HOLHJALBDHM = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GKNACCKFJPJ(string DKLHENCIMJI, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PLFDHLELICD(string DKLHENCIMJI, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string JKDJOKCNNIO(string DKLHENCIMJI, [Optional] string MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FHJGMNECFBO NELFOHBAGEH(string DKLHENCIMJI, string GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int HMNLCMIFCKJ(string DKLHENCIMJI, int MLNCHKABKBO = 0, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FHJGMNECFBO EJILNAKFKLJ(string DKLHENCIMJI, int GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EBDKIDEFBGC(string DKLHENCIMJI, bool MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FHJGMNECFBO IMLDGAHLHBI(string DKLHENCIMJI, bool GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float INGAEPKJLMM(string DKLHENCIMJI, float MLNCHKABKBO = 0f, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FHJGMNECFBO NPFADKDLJJE(string DKLHENCIMJI, float GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime BLHIKJBKFKI(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FHJGMNECFBO MDMALCDPBLO(string DKLHENCIMJI, DateTime GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long AFBMOGENMJB(string DKLHENCIMJI, long MLNCHKABKBO = 0L, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FHJGMNECFBO GDDPOJLHAKO(string DKLHENCIMJI, long GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T HBACKHAFBOD<T>(string DKLHENCIMJI, [Optional] T MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FHJGMNECFBO CDPDHCDPDFM<T>(string DKLHENCIMJI, T GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool DABFCDHDDJN(string DKLHENCIMJI);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool ELNMILBEOKL(string DKLHENCIMJI);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string JAHMLMPJAOJ(string DKLHENCIMJI, [Optional] string MLNCHKABKBO);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FHJGMNECFBO LGKBLJICCEK(string DKLHENCIMJI, string GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int CDOIIGCBBIB(string DKLHENCIMJI, int MLNCHKABKBO = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	FHJGMNECFBO HEDDPJNLHPG(string DKLHENCIMJI, int GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LIKIDJOKNBC(string DKLHENCIMJI, bool MLNCHKABKBO);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "28")]
	FHJGMNECFBO BOCIODAGFDB(string DKLHENCIMJI, bool GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float FBNKHBCJAHP(string DKLHENCIMJI, float MLNCHKABKBO = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "30")]
	FHJGMNECFBO MDGBJOIANCG(string DKLHENCIMJI, float GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime BCNHPNKKMLL(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "32")]
	FHJGMNECFBO OJGMHPNBFNC(string DKLHENCIMJI, DateTime GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long EBNGABOFKPD(string DKLHENCIMJI, long MLNCHKABKBO = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "34")]
	FHJGMNECFBO FJKKBPBBFBP(string DKLHENCIMJI, long GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void OPHAFPPMABM<T>(DEKCFLOPOMA<T> ILHGOKICPAN, [Optional] IEqualityComparer<T> IAFEMJMABIL);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DFDNLELBHPN<T>();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable IIDADCCGPFP();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void GEENGIGCNBB(float FOGEGHJNDKP);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task HMMDNGOBMDB([Optional] CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum FHJGMNECFBO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ONDILKIKPBJ : ECKJGDJNJNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class NBPOPMNBPLI
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		protected static readonly HashSet<NBPOPMNBPLI> BKJAGKLNLGN;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x604D340", Offset = "0x604BF40", VA = "0x18604D340")]
		public static void FGBCCKGKKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void GMINFKPEKLF();

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		protected NBPOPMNBPLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class GMCPLHBAJKI<T> : NBPOPMNBPLI
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly GMCPLHBAJKI<T> IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DEKCFLOPOMA<T> GACHHMCBBEB
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> LPIAIPLEHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CMPKPHKKMMI
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x314EBA0", Offset = "0x314D7A0", VA = "0x18314EBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x35D3B30", Offset = "0x35D2730", VA = "0x1835D3B30")]
		private GMCPLHBAJKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x35D3560", Offset = "0x35D2160", VA = "0x1835D3560")]
		public void CFNGGCOIEBP(DEKCFLOPOMA<T> JHCGDPIIHAI, [Optional] IEqualityComparer<T> IAFEMJMABIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x35D39B0", Offset = "0x35D25B0", VA = "0x1835D39B0", Slot = "4")]
		public override void GMINFKPEKLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class JIEPIGGMLLH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly ONDILKIKPBJ LMJMHGADJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly object JEKMEGHGDAD;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x604C0B0", Offset = "0x604ACB0", VA = "0x18604C0B0")]
		public JIEPIGGMLLH(ONDILKIKPBJ LMJMHGADJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x604C080", Offset = "0x604AC80", VA = "0x18604C080", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct ANJFEPCHMNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ONDILKIKPBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x60483A0", Offset = "0x6046FA0", VA = "0x1860483A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6048680", Offset = "0x6047280", VA = "0x186048680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct HJBAEFGOFFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ONDILKIKPBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NMGFAAFFNCI backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x604B740", Offset = "0x604A340", VA = "0x18604B740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0C0", Offset = "0x7E9CC0", VA = "0x1807EB0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct DOPDEOLAPLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ONDILKIKPBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x604A400", Offset = "0x6049000", VA = "0x18604A400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x604A8D0", Offset = "0x60494D0", VA = "0x18604A8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OKFLBOJDNCJ : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private MJMKCFLBGFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ONDILKIKPBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public OKFLBOJDNCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x604E690", Offset = "0x604D290", VA = "0x18604E690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x604E720", Offset = "0x604D320", VA = "0x18604E720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly LGOMJOCAHBC ODBKEKMMGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly LGOMJOCAHBC GBKHIPNHDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly NAJEPNPMIED HHJHKAFGBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly MBGPIBEMOCP GNLNBDCDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FBHLHHEDNEC IBFOIDEOIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<NMGFAAFFNCI> DFGLBCJJIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Task NFKPHJLAJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private IHPHLOENKON PNKFOEEECFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly object FMICEKGGENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly object EJIHEPMCLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private long PDBPFLKBEPA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool JBBIAGEKJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xC2D750", Offset = "0xC2C350", VA = "0x180C2D750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource FBMILLBCCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x776710", Offset = "0x775310", VA = "0x180776710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x776640", Offset = "0x775240", VA = "0x180776640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action LKJJBJPIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x604F200", Offset = "0x604DE00", VA = "0x18604F200", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6051910", Offset = "0x6050510", VA = "0x186051910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6050A60", Offset = "0x604F660", VA = "0x186050A60")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	private static void JDNIOJNCFAB(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6052170", Offset = "0x6050D70", VA = "0x186052170")]
	[Preserve]
	public ONDILKIKPBJ([DLBAGNNJKKK("Disk")] LGOMJOCAHBC ODBKEKMMGCH, [DLBAGNNJKKK("Cloud")] LGOMJOCAHBC GBKHIPNHDHL, [DLBAGNNJKKK(null)] NAJEPNPMIED HHJHKAFGBBE, [DLBAGNNJKKK(null)] MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x604F440", Offset = "0x604E040", VA = "0x18604F440", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E66550", Offset = "0x5E65150", VA = "0x185E66550")]
	private void CJNBLFIOOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6051AF0", Offset = "0x60506F0", VA = "0x186051AF0", Slot = "6")]
	public void OJPFIOFHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x60514E0", Offset = "0x60500E0", VA = "0x1860514E0", Slot = "7")]
	public Task NEOPHCFKHCA(long PBNCAIAOMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6052060", Offset = "0x6050C60", VA = "0x186052060")]
	[AsyncStateMachine(typeof(ANJFEPCHMNN))]
	private Task PMOLIIGBGKC(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1621B20", Offset = "0x1620720", VA = "0x181621B20")]
	private void ABAENDAKAAK(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6051B60", Offset = "0x6050760", VA = "0x186051B60")]
	private void OKKPPMNPOFC(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6050C30", Offset = "0x604F830", VA = "0x186050C30")]
	private string KEOGDIBONHE(string CIOFGNKOFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x604EF60", Offset = "0x604DB60", VA = "0x18604EF60")]
	private void DBIDIJMCECD(GBAECHNKLGE HOLHJALBDHM, string PPNDANAOAMK, [Out] LGOMJOCAHBC ODMEKLBIDGM, [Out] string NNANICAKNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x604EB00", Offset = "0x604D700", VA = "0x18604EB00")]
	private LGOMJOCAHBC BOPJFKEPONP(GBAECHNKLGE HOLHJALBDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6050C90", Offset = "0x604F890", VA = "0x186050C90", Slot = "8")]
	public bool LFCOOHMGAFJ(GBAECHNKLGE HOLHJALBDHM = GBAECHNKLGE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x604FE10", Offset = "0x604EA10", VA = "0x18604FE10", Slot = "9")]
	public bool GKNACCKFJPJ(string DKLHENCIMJI, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6051E60", Offset = "0x6050A60", VA = "0x186051E60", Slot = "10")]
	public bool PLFDHLELICD(string DKLHENCIMJI, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6050AD0", Offset = "0x604F6D0", VA = "0x186050AD0", Slot = "11")]
	public string JKDJOKCNNIO(string DKLHENCIMJI, [Optional] string MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6051260", Offset = "0x604FE60", VA = "0x186051260", Slot = "12")]
	public FHJGMNECFBO NELFOHBAGEH(string DKLHENCIMJI, string GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60503E0", Offset = "0x604EFE0", VA = "0x1860503E0", Slot = "13")]
	public int HMNLCMIFCKJ(string DKLHENCIMJI, int MLNCHKABKBO = 0, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x604F650", Offset = "0x604E250", VA = "0x18604F650", Slot = "14")]
	public FHJGMNECFBO EJILNAKFKLJ(string DKLHENCIMJI, int GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x604F480", Offset = "0x604E080", VA = "0x18604F480", Slot = "15")]
	public bool EBDKIDEFBGC(string DKLHENCIMJI, bool MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6050620", Offset = "0x604F220", VA = "0x186050620", Slot = "16")]
	public FHJGMNECFBO IMLDGAHLHBI(string DKLHENCIMJI, bool GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6050890", Offset = "0x604F490", VA = "0x186050890", Slot = "17")]
	public float INGAEPKJLMM(string DKLHENCIMJI, float MLNCHKABKBO = 0f, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6051690", Offset = "0x6050290", VA = "0x186051690", Slot = "18")]
	public FHJGMNECFBO NPFADKDLJJE(string DKLHENCIMJI, float GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x604E970", Offset = "0x604D570", VA = "0x18604E970", Slot = "19")]
	public DateTime BLHIKJBKFKI(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6050E20", Offset = "0x604FA20", VA = "0x186050E20", Slot = "20")]
	public FHJGMNECFBO MDMALCDPBLO(string DKLHENCIMJI, DateTime GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x604E770", Offset = "0x604D370", VA = "0x18604E770", Slot = "21")]
	public long AFBMOGENMJB(string DKLHENCIMJI, long MLNCHKABKBO = 0L, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x604FB90", Offset = "0x604E790", VA = "0x18604FB90", Slot = "22")]
	public FHJGMNECFBO GDDPOJLHAKO(string DKLHENCIMJI, long GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2650330", Offset = "0x264EF30", VA = "0x182650330", Slot = "23")]
	public T HBACKHAFBOD<T>(string DKLHENCIMJI, [Optional] T MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2650330", Offset = "0x264EF30", VA = "0x182650330", Slot = "24")]
	public FHJGMNECFBO CDPDHCDPDFM<T>(string DKLHENCIMJI, T GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x604EF00", Offset = "0x604DB00", VA = "0x18604EF00", Slot = "25")]
	public bool DABFCDHDDJN(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x604F8C0", Offset = "0x604E4C0", VA = "0x18604F8C0", Slot = "26")]
	public bool ELNMILBEOKL(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60509F0", Offset = "0x604F5F0", VA = "0x1860509F0", Slot = "27")]
	public string JAHMLMPJAOJ(string DKLHENCIMJI, [Optional] string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6050D50", Offset = "0x604F950", VA = "0x186050D50", Slot = "28")]
	public FHJGMNECFBO LGKBLJICCEK(string DKLHENCIMJI, string GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x604EDC0", Offset = "0x604D9C0", VA = "0x18604EDC0", Slot = "29")]
	public int CDOIIGCBBIB(string DKLHENCIMJI, int MLNCHKABKBO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60502C0", Offset = "0x604EEC0", VA = "0x1860502C0", Slot = "30")]
	public FHJGMNECFBO HEDDPJNLHPG(string DKLHENCIMJI, int GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6050D80", Offset = "0x604F980", VA = "0x186050D80", Slot = "31")]
	public bool LIKIDJOKNBC(string DKLHENCIMJI, bool MLNCHKABKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x604EAD0", Offset = "0x604D6D0", VA = "0x18604EAD0", Slot = "32")]
	public FHJGMNECFBO BOCIODAGFDB(string DKLHENCIMJI, bool GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x604FA60", Offset = "0x604E660", VA = "0x18604FA60", Slot = "33")]
	public float FBNKHBCJAHP(string DKLHENCIMJI, float MLNCHKABKBO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6050DF0", Offset = "0x604F9F0", VA = "0x186050DF0", Slot = "34")]
	public FHJGMNECFBO MDGBJOIANCG(string DKLHENCIMJI, float GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x604E8D0", Offset = "0x604D4D0", VA = "0x18604E8D0", Slot = "35")]
	public DateTime BCNHPNKKMLL(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6051AC0", Offset = "0x60506C0", VA = "0x186051AC0", Slot = "36")]
	public FHJGMNECFBO OJGMHPNBFNC(string DKLHENCIMJI, DateTime GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x604F5E0", Offset = "0x604E1E0", VA = "0x18604F5E0", Slot = "37")]
	public long EBNGABOFKPD(string DKLHENCIMJI, long MLNCHKABKBO = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x604FB60", Offset = "0x604E760", VA = "0x18604FB60", Slot = "38")]
	public FHJGMNECFBO FJKKBPBBFBP(string DKLHENCIMJI, long GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x604EB80", Offset = "0x604D780", VA = "0x18604EB80")]
	private bool CCAMHECNDDB(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60519B0", Offset = "0x60505B0", VA = "0x1860519B0")]
	private bool ODLJFEFJODC(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x604F060", Offset = "0x604DC60", VA = "0x18604F060")]
	private FHJGMNECFBO DGEIKOPDNHJ(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, string GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x604F8D0", Offset = "0x604E4D0", VA = "0x18604F8D0")]
	private FHJGMNECFBO FBKEKJPJDHK(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, int GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x604F2A0", Offset = "0x604DEA0", VA = "0x18604F2A0")]
	private FHJGMNECFBO DNMGJPNFFEN(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, bool GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x604FF60", Offset = "0x604EB60", VA = "0x18604FF60")]
	private FHJGMNECFBO GNBEPDDPDHN(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, float GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6050100", Offset = "0x604ED00", VA = "0x186050100")]
	private FHJGMNECFBO HCNIKNADLGC(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, DateTime GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x60510D0", Offset = "0x604FCD0", VA = "0x1860510D0")]
	private FHJGMNECFBO NDPAJPBOOGC(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, long GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x26511F0", Offset = "0x264FDF0", VA = "0x1826511F0")]
	private T IEGPHEEFHDE<T>(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, T MLNCHKABKBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2650550", Offset = "0x264F150", VA = "0x182650550")]
	private FHJGMNECFBO FKECBBLKHPM<T>(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, T GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x26516F0", Offset = "0x26502F0", VA = "0x1826516F0", Slot = "39")]
	public void OPHAFPPMABM<T>(DEKCFLOPOMA<T> ILHGOKICPAN, [Optional] IEqualityComparer<T> IAFEMJMABIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x26504D0", Offset = "0x264F0D0", VA = "0x1826504D0", Slot = "40")]
	public void DFDNLELBHPN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x604EE30", Offset = "0x604DA30", VA = "0x18604EE30")]
	[AsyncStateMachine(typeof(HJBAEFGOFFO))]
	private void CGLBPEOMMNO(NMGFAAFFNCI OFHLBAJCBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x60502F0", Offset = "0x604EEF0", VA = "0x1860502F0", Slot = "43")]
	[AsyncStateMachine(typeof(DOPDEOLAPLI))]
	public Task HMMDNGOBMDB([Optional] CancellationToken KJCAGLABEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x604EBE0", Offset = "0x604D7E0", VA = "0x18604EBE0")]
	private void CCIMFPIECLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6050540", Offset = "0x604F140", VA = "0x186050540", Slot = "41")]
	public IDisposable IIDADCCGPFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x604FE00", Offset = "0x604EA00", VA = "0x18604FE00", Slot = "42")]
	public void GEENGIGCNBB(float FOGEGHJNDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6051BE0", Offset = "0x60507E0", VA = "0x186051BE0")]
	private void PIHJEAGFLLC(float BMEAPBICECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x604FAD0", Offset = "0x604E6D0", VA = "0x18604FAD0")]
	[IteratorStateMachine(typeof(OKFLBOJDNCJ))]
	private IEnumerator<MJMKCFLBGFK> FJKBIPHPLNH(float FOGEGHJNDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x604E940", Offset = "0x604D540", VA = "0x18604E940")]
	[CompilerGenerated]
	private void BKHPDPKCCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OPDPDDKPPAK : COFOKCABMPJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static OPDPDDKPPAK IDAIJJLMAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6053090", Offset = "0x6051C90", VA = "0x186053090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6052FA0", Offset = "0x6051BA0", VA = "0x186052FA0", Slot = "9")]
	public override string OIIEHDKDHEB(bool MAIMNHFMIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6052D20", Offset = "0x6051920", VA = "0x186052D20", Slot = "10")]
	protected override bool KNCCOFHPGOA(string MAIMNHFMIBD, [Out] bool GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6053180", Offset = "0x6051D80", VA = "0x186053180")]
	public OPDPDDKPPAK()
	{
	}
}
namespace Cpp2IlInjected;

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
