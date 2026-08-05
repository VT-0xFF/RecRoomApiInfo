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
	[Cpp2IlInjected.Address(RVA = "0x6052480", Offset = "0x6051080", VA = "0x186052480")]
	private static void GIMEGFBKNHE(NMGFAAFFNCI ODMEKLBIDGM, Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6052500", Offset = "0x6051100", VA = "0x186052500")]
	public static bool HECEOIKPNBA(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6052730", Offset = "0x6051330", VA = "0x186052730")]
	public static FHJGMNECFBO JHLBJEPNGPO(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, string GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6052340", Offset = "0x6050F40", VA = "0x186052340")]
	public static FHJGMNECFBO COIBEIPFNBB(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, int GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6052880", Offset = "0x6051480", VA = "0x186052880")]
	public static FHJGMNECFBO MMDIHENHEBA(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, bool GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60529D0", Offset = "0x60515D0", VA = "0x1860529D0")]
	public static FHJGMNECFBO NIPMIDOAKHI(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, float GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6052B20", Offset = "0x6051720", VA = "0x186052B20")]
	public static FHJGMNECFBO PGEOLLGJGJF(this NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, DateTime GCPEEAODAIB, [Optional] Action<NMGFAAFFNCI> AJJGEFADBIO)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60525F0", Offset = "0x60511F0", VA = "0x1860525F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6048ED0", Offset = "0x6047AD0", VA = "0x186048ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x604A0E0", Offset = "0x6048CE0", VA = "0x18604A0E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x60494C0", Offset = "0x60480C0", VA = "0x1860494C0")]
	private DirectoryInfo FHJKHBPEIIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6049A10", Offset = "0x6048610", VA = "0x186049A10", Slot = "6")]
	public Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6049450", Offset = "0x6048050", VA = "0x186049450", Slot = "14")]
	public float CLKPJCAGNCL(string PPNDANAOAMK, float MLNCHKABKBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6049B30", Offset = "0x6048730", VA = "0x186049B30", Slot = "13")]
	public void LAMIBMBPHCJ(string PPNDANAOAMK, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6049FA0", Offset = "0x6048BA0", VA = "0x186049FA0", Slot = "12")]
	public bool OGEAOEPLDHC(string PPNDANAOAMK, bool MLNCHKABKBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6049810", Offset = "0x6048410", VA = "0x186049810", Slot = "10")]
	public int JCEPEKBOCLO(string PPNDANAOAMK, int MLNCHKABKBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6049F30", Offset = "0x6048B30", VA = "0x186049F30", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6049930", Offset = "0x6048530", VA = "0x186049930", Slot = "19")]
	public void JDFIOPKBDDE(string PPNDANAOAMK, DateTime GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60496A0", Offset = "0x60482A0", VA = "0x1860496A0", Slot = "15")]
	public void IBNPNHHIBCC(string PPNDANAOAMK, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60495C0", Offset = "0x60481C0", VA = "0x1860495C0", Slot = "11")]
	public void FNBFDLLCFDO(string PPNDANAOAMK, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6049630", Offset = "0x6048230", VA = "0x186049630", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x604A070", Offset = "0x6048C70", VA = "0x18604A070", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22A6D40", Offset = "0x22A5940", VA = "0x1822A6D40", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22A6CA0", Offset = "0x22A58A0", VA = "0x1822A6CA0", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6049880", Offset = "0x6048480", VA = "0x186049880", Slot = "16")]
	public string JCLIFBPHEGF(string PPNDANAOAMK, string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60499A0", Offset = "0x60485A0", VA = "0x1860499A0", Slot = "17")]
	public void KMBBDELAOFH(string PPNDANAOAMK, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6048E10", Offset = "0x6047A10", VA = "0x186048E10", Slot = "24")]
	public void ACBHJNFICOE(string PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6049AA0", Offset = "0x60486A0", VA = "0x186049AA0", Slot = "9")]
	public bool LACBJOIFHKC(string PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6048F10", Offset = "0x6047B10", VA = "0x186048F10", Slot = "25")]
	public Task CGLBPEOMMNO(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6049BA0", Offset = "0x60487A0", VA = "0x186049BA0")]
	private void LDIBALAGPPJ(DirectoryInfo IBMCBOGIEME, string HLDGKGEJILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6049250", Offset = "0x6047E50", VA = "0x186049250")]
	private static string CICIGEONFPE(string PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6049710", Offset = "0x6048310", VA = "0x186049710")]
	private static string JAFJLEKLIOG(byte[] FEGEJBFJFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x22A7E10", Offset = "0x22A6A10", VA = "0x1822A7E10")]
	private T IOOJPMIEEDI<T>(string DKLHENCIMJI, T MLNCHKABKBO, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x22A6E50", Offset = "0x22A5A50", VA = "0x1822A6E50")]
	private void INLCAGHFLDH<T>(string DKLHENCIMJI, T GCPEEAODAIB, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6048650", Offset = "0x6047250", VA = "0x186048650")]
	private Dictionary<string, string> AAKELCAIOHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class MKEKFEJDEGK
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x604D150", Offset = "0x604BD50", VA = "0x18604D150")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	private static void JKFPJJDDAIM(OKOCNPPIKGG PCOJMOHPOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IFFPHPABDLB : ICKPEBNINLM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x604BEA0", Offset = "0x604AAA0", VA = "0x18604BEA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x604BC30", Offset = "0x604A830", VA = "0x18604BC30", Slot = "6")]
	public Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x604BCC0", Offset = "0x604A8C0", VA = "0x18604BCC0", Slot = "9")]
	public bool LACBJOIFHKC(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x604BAB0", Offset = "0x604A6B0", VA = "0x18604BAB0", Slot = "10")]
	public int JCEPEKBOCLO(string DKLHENCIMJI, int MLNCHKABKBO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x604B990", Offset = "0x604A590", VA = "0x18604B990", Slot = "11")]
	public void FNBFDLLCFDO(string DKLHENCIMJI, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x604BDE0", Offset = "0x604A9E0", VA = "0x18604BDE0", Slot = "12")]
	public bool OGEAOEPLDHC(string DKLHENCIMJI, bool MLNCHKABKBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x604BD20", Offset = "0x604A920", VA = "0x18604BD20", Slot = "13")]
	public void LAMIBMBPHCJ(string DKLHENCIMJI, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x604B930", Offset = "0x604A530", VA = "0x18604B930", Slot = "14")]
	public float CLKPJCAGNCL(string DKLHENCIMJI, float MLNCHKABKBO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x604BA50", Offset = "0x604A650", VA = "0x18604BA50", Slot = "15")]
	public void IBNPNHHIBCC(string DKLHENCIMJI, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x604BB10", Offset = "0x604A710", VA = "0x18604BB10", Slot = "16")]
	public string JCLIFBPHEGF(string DKLHENCIMJI, [Optional] string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x604BBD0", Offset = "0x604A7D0", VA = "0x18604BBD0", Slot = "17")]
	public void KMBBDELAOFH(string DKLHENCIMJI, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x604BD80", Offset = "0x604A980", VA = "0x18604BD80", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x604BB70", Offset = "0x604A770", VA = "0x18604BB70", Slot = "19")]
	public void JDFIOPKBDDE(string DKLHENCIMJI, DateTime GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x604B9F0", Offset = "0x604A5F0", VA = "0x18604B9F0", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x604BE40", Offset = "0x604AA40", VA = "0x18604BE40", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x252AF70", Offset = "0x2529B70", VA = "0x18252AF70", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x252AED0", Offset = "0x2529AD0", VA = "0x18252AED0", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x252B560", Offset = "0x252A160", VA = "0x18252B560")]
	public T IOOJPMIEEDI<T>(string DKLHENCIMJI, T MLNCHKABKBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x252B070", Offset = "0x2529C70", VA = "0x18252B070")]
	public void INLCAGHFLDH<T>(string DKLHENCIMJI, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x604B840", Offset = "0x604A440", VA = "0x18604B840", Slot = "24")]
	public void ACBHJNFICOE(string DKLHENCIMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x604B8A0", Offset = "0x604A4A0", VA = "0x18604B8A0", Slot = "25")]
	public Task CGLBPEOMMNO(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x604BEA0", Offset = "0x604AAA0", VA = "0x18604BEA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x371E760", Offset = "0x371D360", VA = "0x18371E760")]
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
	[Cpp2IlInjected.Address(RVA = "0x371E1B0", Offset = "0x371CDB0", VA = "0x18371E1B0")]
	public static void CAJMLGLLLHE(string PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x371E3F0", Offset = "0x371CFF0", VA = "0x18371E3F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x371E930", Offset = "0x371D530", VA = "0x18371E930")]
	public bool IKGDLKABABA(string KPCNLIOCEMG, [Out] TValue DCHFBFKHEBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x371E850", Offset = "0x371D450", VA = "0x18371E850")]
	public void CNGOCBBIINE(string KPCNLIOCEMG, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x371E900", Offset = "0x371D500", VA = "0x18371E900", Slot = "4")]
	protected override void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3708C90", Offset = "0x3707890", VA = "0x183708C90", Slot = "5")]
	protected override void NBFDKABCBBG(string KPCNLIOCEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x371EAA0", Offset = "0x371D6A0", VA = "0x18371EAA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x604A180", Offset = "0x6048D80", VA = "0x18604A180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x604A310", Offset = "0x6048F10", VA = "0x18604A310", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x604CE00", Offset = "0x604BA00", VA = "0x18604CE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x604D0F0", Offset = "0x604BCF0", VA = "0x18604D0F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x604E1C0", Offset = "0x604CDC0", VA = "0x18604E1C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LKJJBJPIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x604D7E0", Offset = "0x604C3E0", VA = "0x18604D7E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x604E220", Offset = "0x604CE20", VA = "0x18604E220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x604E4F0", Offset = "0x604D0F0", VA = "0x18604E4F0")]
	[Preserve]
	public ODGJHHNEFIK([DLBAGNNJKKK(null)] ABBFHOMHOIC BNDONJNDAPK, [DLBAGNNJKKK("Disk_Unity")] LGOMJOCAHBC BEBAKCCNOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x604E420", Offset = "0x604D020", VA = "0x18604E420", Slot = "8")]
	public void OJPFIOFHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x604DF60", Offset = "0x604CB60", VA = "0x18604DF60", Slot = "9")]
	public bool LACBJOIFHKC(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x604DA80", Offset = "0x604C680", VA = "0x18604DA80", Slot = "10")]
	public int JCEPEKBOCLO(string DKLHENCIMJI, int MLNCHKABKBO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x604D840", Offset = "0x604C440", VA = "0x18604D840", Slot = "11")]
	public void FNBFDLLCFDO(string DKLHENCIMJI, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x604E290", Offset = "0x604CE90", VA = "0x18604E290", Slot = "12")]
	public bool OGEAOEPLDHC(string DKLHENCIMJI, bool MLNCHKABKBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x604DFF0", Offset = "0x604CBF0", VA = "0x18604DFF0", Slot = "13")]
	public void LAMIBMBPHCJ(string DKLHENCIMJI, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x604D680", Offset = "0x604C280", VA = "0x18604D680", Slot = "14")]
	public float CLKPJCAGNCL(string DKLHENCIMJI, float MLNCHKABKBO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x604DA10", Offset = "0x604C610", VA = "0x18604DA10", Slot = "15")]
	public void IBNPNHHIBCC(string DKLHENCIMJI, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x604DBD0", Offset = "0x604C7D0", VA = "0x18604DBD0", Slot = "16")]
	public string JCLIFBPHEGF(string DKLHENCIMJI, [Optional] string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x604DDE0", Offset = "0x604C9E0", VA = "0x18604DDE0", Slot = "17")]
	public void KMBBDELAOFH(string DKLHENCIMJI, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x604E060", Offset = "0x604CC60", VA = "0x18604E060", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x604DD70", Offset = "0x604C970", VA = "0x18604DD70", Slot = "19")]
	public void JDFIOPKBDDE(string DKLHENCIMJI, DateTime NPCNHIGLAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x604D8B0", Offset = "0x604C4B0", VA = "0x18604D8B0", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x604E480", Offset = "0x604D080", VA = "0x18604E480", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2642030", Offset = "0x2640C30", VA = "0x182642030", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2641F60", Offset = "0x2640B60", VA = "0x182641F60", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x604D480", Offset = "0x604C080", VA = "0x18604D480", Slot = "24")]
	public void ACBHJNFICOE(string DKLHENCIMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x604D590", Offset = "0x604C190", VA = "0x18604D590", Slot = "25")]
	[AsyncStateMachine(typeof(CHMBECJALPK))]
	public Task CGLBPEOMMNO([Optional] CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x604DE50", Offset = "0x604CA50", VA = "0x18604DE50", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x604C0D0", Offset = "0x604ACD0", VA = "0x18604C0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x604C4A0", Offset = "0x604B0A0", VA = "0x18604C4A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x604BF30", Offset = "0x604AB30", VA = "0x18604BF30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x604BFA0", Offset = "0x604ABA0", VA = "0x18604BFA0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x604CD10", Offset = "0x604B910", VA = "0x18604CD10")]
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
	[Cpp2IlInjected.Address(RVA = "0x604CA80", Offset = "0x604B680", VA = "0x18604CA80", Slot = "6")]
	public Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x51BD430", Offset = "0x51BC030", VA = "0x1851BD430")]
	private static int NHBPBMPOCOL(bool GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x604CB10", Offset = "0x604B710", VA = "0x18604CB10", Slot = "9")]
	public bool LACBJOIFHKC(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x604C980", Offset = "0x604B580", VA = "0x18604C980", Slot = "10")]
	public int JCEPEKBOCLO(string DKLHENCIMJI, int MLNCHKABKBO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x604C7B0", Offset = "0x604B3B0", VA = "0x18604C7B0", Slot = "11")]
	public void FNBFDLLCFDO(string DKLHENCIMJI, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x604CC70", Offset = "0x604B870", VA = "0x18604CC70", Slot = "12")]
	public bool OGEAOEPLDHC(string DKLHENCIMJI, bool MLNCHKABKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x604CB30", Offset = "0x604B730", VA = "0x18604CB30", Slot = "13")]
	public void LAMIBMBPHCJ(string DKLHENCIMJI, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x604C6A0", Offset = "0x604B2A0", VA = "0x18604C6A0", Slot = "14")]
	public float CLKPJCAGNCL(string DKLHENCIMJI, float MLNCHKABKBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x604C930", Offset = "0x604B530", VA = "0x18604C930", Slot = "15")]
	public void IBNPNHHIBCC(string DKLHENCIMJI, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x604CC00", Offset = "0x604B800", VA = "0x18604CC00", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x604C9E0", Offset = "0x604B5E0", VA = "0x18604C9E0", Slot = "19")]
	public void JDFIOPKBDDE(string DKLHENCIMJI, DateTime NPCNHIGLAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x604C7E0", Offset = "0x604B3E0", VA = "0x18604C7E0", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x604CCA0", Offset = "0x604B8A0", VA = "0x18604CCA0", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x257AD10", Offset = "0x2579910", VA = "0x18257AD10", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x257ABE0", Offset = "0x25797E0", VA = "0x18257ABE0", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x257AED0", Offset = "0x2579AD0", VA = "0x18257AED0")]
	private T IGEOKIFFOKJ<T>(string DKLHENCIMJI, T MLNCHKABKBO, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x257B920", Offset = "0x257A520", VA = "0x18257B920")]
	private void JMBHKOOIFBM<T>(string DKLHENCIMJI, T GCPEEAODAIB, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x604C9B0", Offset = "0x604B5B0", VA = "0x18604C9B0", Slot = "16")]
	public string JCLIFBPHEGF(string DKLHENCIMJI, string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x604CA50", Offset = "0x604B650", VA = "0x18604CA50", Slot = "17")]
	public void KMBBDELAOFH(string DKLHENCIMJI, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x604C590", Offset = "0x604B190", VA = "0x18604C590")]
	private void BNBJEFFHCIP(string DKLHENCIMJI, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x604C960", Offset = "0x604B560", VA = "0x18604C960")]
	private string IELPFOKMHPH(string DKLHENCIMJI, string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x604C500", Offset = "0x604B100", VA = "0x18604C500", Slot = "24")]
	public void ACBHJNFICOE(string DKLHENCIMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x604CB60", Offset = "0x604B760", VA = "0x18604CB60")]
	private string LOADJAGPAFK(string PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x604C5B0", Offset = "0x604B1B0", VA = "0x18604C5B0", Slot = "25")]
	[AsyncStateMachine(typeof(LAABLGLKPJH))]
	public Task CGLBPEOMMNO(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x604C850", Offset = "0x604B450", VA = "0x18604C850")]
	[IteratorStateMachine(typeof(JDJOPOGIHDL))]
	private IEnumerator<MJMKCFLBGFK> HILFNGOKHJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x604C8D0", Offset = "0x604B4D0", VA = "0x18604C8D0")]
	private void HMMDNGOBMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x604C740", Offset = "0x604B340", VA = "0x18604C740")]
	private void FMAICLNKDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x604C6D0", Offset = "0x604B2D0", VA = "0x18604C6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x604B640", Offset = "0x604A240", VA = "0x18604B640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> KEIJHACBGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x604AC60", Offset = "0x6049860", VA = "0x18604AC60")]
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
	[Cpp2IlInjected.Address(RVA = "0x604B300", Offset = "0x6049F00", VA = "0x18604B300", Slot = "6")]
	public Task KNMECIIPAGJ(long PBNCAIAOMJK, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x604AF10", Offset = "0x6049B10", VA = "0x18604AF10", Slot = "14")]
	public float CLKPJCAGNCL(string PPNDANAOAMK, float MLNCHKABKBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x604B420", Offset = "0x604A020", VA = "0x18604B420", Slot = "13")]
	public void LAMIBMBPHCJ(string PPNDANAOAMK, bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x604B500", Offset = "0x604A100", VA = "0x18604B500", Slot = "12")]
	public bool OGEAOEPLDHC(string PPNDANAOAMK, bool MLNCHKABKBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x604B0D0", Offset = "0x6049CD0", VA = "0x18604B0D0", Slot = "10")]
	public int JCEPEKBOCLO(string PPNDANAOAMK, int MLNCHKABKBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x604B490", Offset = "0x604A090", VA = "0x18604B490", Slot = "18")]
	public DateTime MDJJGFIKDDE(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x604B1F0", Offset = "0x6049DF0", VA = "0x18604B1F0", Slot = "19")]
	public void JDFIOPKBDDE(string PPNDANAOAMK, DateTime GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x604B060", Offset = "0x6049C60", VA = "0x18604B060", Slot = "15")]
	public void IBNPNHHIBCC(string PPNDANAOAMK, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x604AF80", Offset = "0x6049B80", VA = "0x18604AF80", Slot = "11")]
	public void FNBFDLLCFDO(string PPNDANAOAMK, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x604AFF0", Offset = "0x6049BF0", VA = "0x18604AFF0", Slot = "20")]
	public long HADHKJPBBJE(string DKLHENCIMJI, long MLNCHKABKBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x604B5D0", Offset = "0x604A1D0", VA = "0x18604B5D0", Slot = "21")]
	public void PNGPGCFAFON(string DKLHENCIMJI, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x22A6D40", Offset = "0x22A5940", VA = "0x1822A6D40", Slot = "22")]
	public T FFKINHAHMEO<T>(string DKLHENCIMJI, T MLNCHKABKBO, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x22A6CA0", Offset = "0x22A58A0", VA = "0x1822A6CA0", Slot = "23")]
	public void ENBNIJGANKJ<T>(string DKLHENCIMJI, T GCPEEAODAIB, DEKCFLOPOMA<T> ILHGOKICPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x604B140", Offset = "0x6049D40", VA = "0x18604B140", Slot = "16")]
	public string JCLIFBPHEGF(string PPNDANAOAMK, string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x604B260", Offset = "0x6049E60", VA = "0x18604B260", Slot = "17")]
	public void KMBBDELAOFH(string PPNDANAOAMK, string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x604ABA0", Offset = "0x60497A0", VA = "0x18604ABA0", Slot = "24")]
	public void ACBHJNFICOE(string PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x604B390", Offset = "0x6049F90", VA = "0x18604B390", Slot = "9")]
	public bool LACBJOIFHKC(string PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x604ACA0", Offset = "0x60498A0", VA = "0x18604ACA0", Slot = "25")]
	public Task CGLBPEOMMNO(CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x24F6460", Offset = "0x24F5060", VA = "0x1824F6460")]
	private T IOOJPMIEEDI<T>(string DKLHENCIMJI, T MLNCHKABKBO, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x24F5520", Offset = "0x24F4120", VA = "0x1824F5520")]
	private void INLCAGHFLDH<T>(string DKLHENCIMJI, T GCPEEAODAIB, [Optional] DEKCFLOPOMA<T> JHCGDPIIHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x604A8A0", Offset = "0x60494A0", VA = "0x18604A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x604D2B0", Offset = "0x604BEB0", VA = "0x18604D2B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x314EB10", Offset = "0x314D710", VA = "0x18314EB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x35D3AA0", Offset = "0x35D26A0", VA = "0x1835D3AA0")]
		private GMCPLHBAJKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x35D34D0", Offset = "0x35D20D0", VA = "0x1835D34D0")]
		public void CFNGGCOIEBP(DEKCFLOPOMA<T> JHCGDPIIHAI, [Optional] IEqualityComparer<T> IAFEMJMABIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x35D3920", Offset = "0x35D2520", VA = "0x1835D3920", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x604C020", Offset = "0x604AC20", VA = "0x18604C020")]
		public JIEPIGGMLLH(ONDILKIKPBJ LMJMHGADJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x604BFF0", Offset = "0x604ABF0", VA = "0x18604BFF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6048310", Offset = "0x6046F10", VA = "0x186048310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x60485F0", Offset = "0x60471F0", VA = "0x1860485F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x604B6B0", Offset = "0x604A2B0", VA = "0x18604B6B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x604A370", Offset = "0x6048F70", VA = "0x18604A370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x604A840", Offset = "0x6049440", VA = "0x18604A840", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x604E600", Offset = "0x604D200", VA = "0x18604E600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x604E690", Offset = "0x604D290", VA = "0x18604E690", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x604F170", Offset = "0x604DD70", VA = "0x18604F170", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6051880", Offset = "0x6050480", VA = "0x186051880", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x60509D0", Offset = "0x604F5D0", VA = "0x1860509D0")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	private static void JDNIOJNCFAB(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x60520E0", Offset = "0x6050CE0", VA = "0x1860520E0")]
	[Preserve]
	public ONDILKIKPBJ([DLBAGNNJKKK("Disk")] LGOMJOCAHBC ODBKEKMMGCH, [DLBAGNNJKKK("Cloud")] LGOMJOCAHBC GBKHIPNHDHL, [DLBAGNNJKKK(null)] NAJEPNPMIED HHJHKAFGBBE, [DLBAGNNJKKK(null)] MBGPIBEMOCP GNLNBDCDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x604F3B0", Offset = "0x604DFB0", VA = "0x18604F3B0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E664C0", Offset = "0x5E650C0", VA = "0x185E664C0")]
	private void CJNBLFIOOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6051A60", Offset = "0x6050660", VA = "0x186051A60", Slot = "6")]
	public void OJPFIOFHICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6051450", Offset = "0x6050050", VA = "0x186051450", Slot = "7")]
	public Task NEOPHCFKHCA(long PBNCAIAOMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6051FD0", Offset = "0x6050BD0", VA = "0x186051FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6051AD0", Offset = "0x60506D0", VA = "0x186051AD0")]
	private void OKKPPMNPOFC(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6050BA0", Offset = "0x604F7A0", VA = "0x186050BA0")]
	private string KEOGDIBONHE(string CIOFGNKOFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x604EED0", Offset = "0x604DAD0", VA = "0x18604EED0")]
	private void DBIDIJMCECD(GBAECHNKLGE HOLHJALBDHM, string PPNDANAOAMK, [Out] LGOMJOCAHBC ODMEKLBIDGM, [Out] string NNANICAKNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x604EA70", Offset = "0x604D670", VA = "0x18604EA70")]
	private LGOMJOCAHBC BOPJFKEPONP(GBAECHNKLGE HOLHJALBDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6050C00", Offset = "0x604F800", VA = "0x186050C00", Slot = "8")]
	public bool LFCOOHMGAFJ(GBAECHNKLGE HOLHJALBDHM = GBAECHNKLGE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x604FD80", Offset = "0x604E980", VA = "0x18604FD80", Slot = "9")]
	public bool GKNACCKFJPJ(string DKLHENCIMJI, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6051DD0", Offset = "0x60509D0", VA = "0x186051DD0", Slot = "10")]
	public bool PLFDHLELICD(string DKLHENCIMJI, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6050A40", Offset = "0x604F640", VA = "0x186050A40", Slot = "11")]
	public string JKDJOKCNNIO(string DKLHENCIMJI, [Optional] string MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x60511D0", Offset = "0x604FDD0", VA = "0x1860511D0", Slot = "12")]
	public FHJGMNECFBO NELFOHBAGEH(string DKLHENCIMJI, string GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6050350", Offset = "0x604EF50", VA = "0x186050350", Slot = "13")]
	public int HMNLCMIFCKJ(string DKLHENCIMJI, int MLNCHKABKBO = 0, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x604F5C0", Offset = "0x604E1C0", VA = "0x18604F5C0", Slot = "14")]
	public FHJGMNECFBO EJILNAKFKLJ(string DKLHENCIMJI, int GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x604F3F0", Offset = "0x604DFF0", VA = "0x18604F3F0", Slot = "15")]
	public bool EBDKIDEFBGC(string DKLHENCIMJI, bool MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6050590", Offset = "0x604F190", VA = "0x186050590", Slot = "16")]
	public FHJGMNECFBO IMLDGAHLHBI(string DKLHENCIMJI, bool GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6050800", Offset = "0x604F400", VA = "0x186050800", Slot = "17")]
	public float INGAEPKJLMM(string DKLHENCIMJI, float MLNCHKABKBO = 0f, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6051600", Offset = "0x6050200", VA = "0x186051600", Slot = "18")]
	public FHJGMNECFBO NPFADKDLJJE(string DKLHENCIMJI, float GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x604E8E0", Offset = "0x604D4E0", VA = "0x18604E8E0", Slot = "19")]
	public DateTime BLHIKJBKFKI(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6050D90", Offset = "0x604F990", VA = "0x186050D90", Slot = "20")]
	public FHJGMNECFBO MDMALCDPBLO(string DKLHENCIMJI, DateTime GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x604E6E0", Offset = "0x604D2E0", VA = "0x18604E6E0", Slot = "21")]
	public long AFBMOGENMJB(string DKLHENCIMJI, long MLNCHKABKBO = 0L, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x604FB00", Offset = "0x604E700", VA = "0x18604FB00", Slot = "22")]
	public FHJGMNECFBO GDDPOJLHAKO(string DKLHENCIMJI, long GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x26502A0", Offset = "0x264EEA0", VA = "0x1826502A0", Slot = "23")]
	public T HBACKHAFBOD<T>(string DKLHENCIMJI, [Optional] T MLNCHKABKBO, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x26502A0", Offset = "0x264EEA0", VA = "0x1826502A0", Slot = "24")]
	public FHJGMNECFBO CDPDHCDPDFM<T>(string DKLHENCIMJI, T GCPEEAODAIB, GBAECHNKLGE BAFLPBEIOOJ = GBAECHNKLGE.CLOUD)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x604EE70", Offset = "0x604DA70", VA = "0x18604EE70", Slot = "25")]
	public bool DABFCDHDDJN(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x604F830", Offset = "0x604E430", VA = "0x18604F830", Slot = "26")]
	public bool ELNMILBEOKL(string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6050960", Offset = "0x604F560", VA = "0x186050960", Slot = "27")]
	public string JAHMLMPJAOJ(string DKLHENCIMJI, [Optional] string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6050CC0", Offset = "0x604F8C0", VA = "0x186050CC0", Slot = "28")]
	public FHJGMNECFBO LGKBLJICCEK(string DKLHENCIMJI, string GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x604ED30", Offset = "0x604D930", VA = "0x18604ED30", Slot = "29")]
	public int CDOIIGCBBIB(string DKLHENCIMJI, int MLNCHKABKBO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6050230", Offset = "0x604EE30", VA = "0x186050230", Slot = "30")]
	public FHJGMNECFBO HEDDPJNLHPG(string DKLHENCIMJI, int GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6050CF0", Offset = "0x604F8F0", VA = "0x186050CF0", Slot = "31")]
	public bool LIKIDJOKNBC(string DKLHENCIMJI, bool MLNCHKABKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x604EA40", Offset = "0x604D640", VA = "0x18604EA40", Slot = "32")]
	public FHJGMNECFBO BOCIODAGFDB(string DKLHENCIMJI, bool GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x604F9D0", Offset = "0x604E5D0", VA = "0x18604F9D0", Slot = "33")]
	public float FBNKHBCJAHP(string DKLHENCIMJI, float MLNCHKABKBO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6050D60", Offset = "0x604F960", VA = "0x186050D60", Slot = "34")]
	public FHJGMNECFBO MDGBJOIANCG(string DKLHENCIMJI, float GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x604E840", Offset = "0x604D440", VA = "0x18604E840", Slot = "35")]
	public DateTime BCNHPNKKMLL(string DKLHENCIMJI, [Optional] DateTime MLNCHKABKBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6051A30", Offset = "0x6050630", VA = "0x186051A30", Slot = "36")]
	public FHJGMNECFBO OJGMHPNBFNC(string DKLHENCIMJI, DateTime GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x604F550", Offset = "0x604E150", VA = "0x18604F550", Slot = "37")]
	public long EBNGABOFKPD(string DKLHENCIMJI, long MLNCHKABKBO = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x604FAD0", Offset = "0x604E6D0", VA = "0x18604FAD0", Slot = "38")]
	public FHJGMNECFBO FJKKBPBBFBP(string DKLHENCIMJI, long GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x604EAF0", Offset = "0x604D6F0", VA = "0x18604EAF0")]
	private bool CCAMHECNDDB(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6051920", Offset = "0x6050520", VA = "0x186051920")]
	private bool ODLJFEFJODC(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x604EFD0", Offset = "0x604DBD0", VA = "0x18604EFD0")]
	private FHJGMNECFBO DGEIKOPDNHJ(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, string GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x604F840", Offset = "0x604E440", VA = "0x18604F840")]
	private FHJGMNECFBO FBKEKJPJDHK(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, int GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x604F210", Offset = "0x604DE10", VA = "0x18604F210")]
	private FHJGMNECFBO DNMGJPNFFEN(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, bool GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x604FED0", Offset = "0x604EAD0", VA = "0x18604FED0")]
	private FHJGMNECFBO GNBEPDDPDHN(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, float GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6050070", Offset = "0x604EC70", VA = "0x186050070")]
	private FHJGMNECFBO HCNIKNADLGC(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, DateTime GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6051040", Offset = "0x604FC40", VA = "0x186051040")]
	private FHJGMNECFBO NDPAJPBOOGC(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, long GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2651160", Offset = "0x264FD60", VA = "0x182651160")]
	private T IEGPHEEFHDE<T>(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, T MLNCHKABKBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x26504C0", Offset = "0x264F0C0", VA = "0x1826504C0")]
	private FHJGMNECFBO FKECBBLKHPM<T>(NMGFAAFFNCI ODMEKLBIDGM, string DKLHENCIMJI, T GCPEEAODAIB)
	{
		return default(FHJGMNECFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2651660", Offset = "0x2650260", VA = "0x182651660", Slot = "39")]
	public void OPHAFPPMABM<T>(DEKCFLOPOMA<T> ILHGOKICPAN, [Optional] IEqualityComparer<T> IAFEMJMABIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2650440", Offset = "0x264F040", VA = "0x182650440", Slot = "40")]
	public void DFDNLELBHPN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x604EDA0", Offset = "0x604D9A0", VA = "0x18604EDA0")]
	[AsyncStateMachine(typeof(HJBAEFGOFFO))]
	private void CGLBPEOMMNO(NMGFAAFFNCI OFHLBAJCBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6050260", Offset = "0x604EE60", VA = "0x186050260", Slot = "43")]
	[AsyncStateMachine(typeof(DOPDEOLAPLI))]
	public Task HMMDNGOBMDB([Optional] CancellationToken KJCAGLABEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x604EB50", Offset = "0x604D750", VA = "0x18604EB50")]
	private void CCIMFPIECLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x60504B0", Offset = "0x604F0B0", VA = "0x1860504B0", Slot = "41")]
	public IDisposable IIDADCCGPFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x604FD70", Offset = "0x604E970", VA = "0x18604FD70", Slot = "42")]
	public void GEENGIGCNBB(float FOGEGHJNDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6051B50", Offset = "0x6050750", VA = "0x186051B50")]
	private void PIHJEAGFLLC(float BMEAPBICECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x604FA40", Offset = "0x604E640", VA = "0x18604FA40")]
	[IteratorStateMachine(typeof(OKFLBOJDNCJ))]
	private IEnumerator<MJMKCFLBGFK> FJKBIPHPLNH(float FOGEGHJNDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x604E8B0", Offset = "0x604D4B0", VA = "0x18604E8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6053000", Offset = "0x6051C00", VA = "0x186053000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6052F10", Offset = "0x6051B10", VA = "0x186052F10", Slot = "9")]
	public override string OIIEHDKDHEB(bool MAIMNHFMIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6052C90", Offset = "0x6051890", VA = "0x186052C90", Slot = "10")]
	protected override bool KNCCOFHPGOA(string MAIMNHFMIBD, [Out] bool GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x60530F0", Offset = "0x6051CF0", VA = "0x1860530F0")]
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
