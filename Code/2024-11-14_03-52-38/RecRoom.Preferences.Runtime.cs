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
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x701CE10", Offset = "0x701C210", VA = "0x18701CE10", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BPPCCALHMLC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class NKBDOKAKKMO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void AKFMJIDFGJK(NFMNLLACFOA OPMNAGFLJCD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x701C550", Offset = "0x701B950", VA = "0x18701C550")]
	private static void CBHIKLAOPBJ(NFMNLLACFOA OPMNAGFLJCD, AKFMJIDFGJK NPGPMMEDAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x701C710", Offset = "0x701BB10", VA = "0x18701C710")]
	public static bool FCBNPLEMLOJ(this NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, [Optional] AKFMJIDFGJK NPGPMMEDAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x701C950", Offset = "0x701BD50", VA = "0x18701C950")]
	public static JFNBJADMBKH MINAGPECIKE(this NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, string PFKKDHPJFEH, [Optional] AKFMJIDFGJK NPGPMMEDAGI)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x701CBE0", Offset = "0x701BFE0", VA = "0x18701CBE0")]
	public static JFNBJADMBKH OEGBLGAEILM(this NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, int PFKKDHPJFEH, [Optional] AKFMJIDFGJK NPGPMMEDAGI)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x701CAA0", Offset = "0x701BEA0", VA = "0x18701CAA0")]
	public static JFNBJADMBKH NDCCKHBKPDG(this NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, bool PFKKDHPJFEH, [Optional] AKFMJIDFGJK NPGPMMEDAGI)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x701C800", Offset = "0x701BC00", VA = "0x18701C800")]
	public static JFNBJADMBKH IDMMFNPMGED(this NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, float PFKKDHPJFEH, [Optional] AKFMJIDFGJK NPGPMMEDAGI)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x701C3E0", Offset = "0x701B7E0", VA = "0x18701C3E0")]
	public static JFNBJADMBKH AJAFELPMJOL(this NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, DateTime PFKKDHPJFEH, [Optional] AKFMJIDFGJK NPGPMMEDAGI)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x701C5D0", Offset = "0x701B9D0", VA = "0x18701C5D0")]
	public static JFNBJADMBKH EAAAHIJDPON(this NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, long PFKKDHPJFEH, [Optional] AKFMJIDFGJK NPGPMMEDAGI)
	{
		return default(JFNBJADMBKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FBANNHKJEHC : ICIELIJKIJL, NFMNLLACFOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LLCNKAICICK GHGJNKBNBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> ACDMKDPMHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> DBJBLFBNBPH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> CLACKEHHBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7018070", Offset = "0x7017470", VA = "0x187018070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action GLAGFAPGLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7019020", Offset = "0x7018420", VA = "0x187019020")]
	[UnityEngine.Scripting.Preserve]
	public FBANNHKJEHC([NDMEANGLJKD(null)] LLCNKAICICK GHGJNKBNBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "8")]
	public void MOBONOCICCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70186B0", Offset = "0x7017AB0", VA = "0x1870186B0")]
	private DirectoryInfo GOGEODBDAHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7018F90", Offset = "0x7018390", VA = "0x187018F90", Slot = "6")]
	public Task OGHDKHKGMAA(long OPFNEKCHELM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7017DE0", Offset = "0x70171E0", VA = "0x187017DE0", Slot = "14")]
	public float CHKDAKFAEFB(string PBFBBOFLBNL, float POOOEFHFGKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7018640", Offset = "0x7017A40", VA = "0x187018640", Slot = "13")]
	public void GAHMFCEIDOI(string PBFBBOFLBNL, bool PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7017F30", Offset = "0x7017330", VA = "0x187017F30", Slot = "12")]
	public bool DGIKIJIPGGD(string PBFBBOFLBNL, bool POOOEFHFGKB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7018000", Offset = "0x7017400", VA = "0x187018000", Slot = "10")]
	public int DGKHAFAELME(string PBFBBOFLBNL, int POOOEFHFGKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7017EC0", Offset = "0x70172C0", VA = "0x187017EC0", Slot = "18")]
	public DateTime DBAECBNIOBB(string CIOJHADPGDL, [Optional] DateTime POOOEFHFGKB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7018E40", Offset = "0x7018240", VA = "0x187018E40", Slot = "19")]
	public void MGEOGLNJBNG(string PBFBBOFLBNL, DateTime PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x70185D0", Offset = "0x70179D0", VA = "0x1870185D0", Slot = "15")]
	public void FOKNMGFAJCH(string PBFBBOFLBNL, float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7018560", Offset = "0x7017960", VA = "0x187018560", Slot = "11")]
	public void FJAFLJDMDKC(string PBFBBOFLBNL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7017E50", Offset = "0x7017250", VA = "0x187017E50", Slot = "20")]
	public long CPDCFFCPFMJ(string CIOJHADPGDL, long POOOEFHFGKB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7018F20", Offset = "0x7018320", VA = "0x187018F20", Slot = "21")]
	public void NBNDIGHOAED(string CIOJHADPGDL, long PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2E95EC0", Offset = "0x2E952C0", VA = "0x182E95EC0", Slot = "22")]
	public T JJPAOOOLOCE<T>(string CIOJHADPGDL, T POOOEFHFGKB, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E95EC0", Offset = "0x2E952C0", VA = "0x182E95EC0", Slot = "23")]
	public void KCAHMNCNNKD<T>(string CIOJHADPGDL, T PFKKDHPJFEH, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7018170", Offset = "0x7017570", VA = "0x187018170", Slot = "16")]
	public string ELKHKOCNMHE(string PBFBBOFLBNL, string POOOEFHFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7018EB0", Offset = "0x70182B0", VA = "0x187018EB0", Slot = "17")]
	public void MKFJHLOJFOP(string PBFBBOFLBNL, string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x70180B0", Offset = "0x70174B0", VA = "0x1870180B0", Slot = "24")]
	public void EKPDCIHPFOP(string PBFBBOFLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7017580", Offset = "0x7016980", VA = "0x187017580", Slot = "9")]
	public bool ANENMNGNBDJ(string PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7018220", Offset = "0x7017620", VA = "0x187018220", Slot = "25")]
	public Task FGKCLOOILCO(CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x70189B0", Offset = "0x7017DB0", VA = "0x1870189B0")]
	private void HGGMNCLGKPD(DirectoryInfo BDLDGMHAIPM, string PFINCGLOIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x70187B0", Offset = "0x7017BB0", VA = "0x1870187B0")]
	private static string HEALGABJHHF(string PBFBBOFLBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7018D40", Offset = "0x7018140", VA = "0x187018D40")]
	private static string LIECFAIPCFJ(byte[] HFBIMFCNCFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2E94BA0", Offset = "0x2E93FA0", VA = "0x182E94BA0")]
	private T GEKLBPFDDHO<T>(string CIOJHADPGDL, T POOOEFHFGKB, [Optional] NLOJLFDHIMD<T> GBJHCOMHPLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2E960C0", Offset = "0x2E954C0", VA = "0x182E960C0")]
	private void NBJJIKECOBK<T>(string CIOJHADPGDL, T PFKKDHPJFEH, [Optional] NLOJLFDHIMD<T> GBJHCOMHPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7017610", Offset = "0x7016A10", VA = "0x187017610")]
	private Dictionary<string, string> BNKGMCJMMMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class GENKLEKKDKG
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7019290", Offset = "0x7018690", VA = "0x187019290")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void GIDGJLHOKMO(MCLDCOGKKML HOCJPKACMFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HELBIJGJIMF : KONPFIENNNA
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x70193E0", Offset = "0x70187E0", VA = "0x1870193E0")]
	[UnityEngine.Scripting.Preserve]
	public HELBIJGJIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KONPFIENNNA : ICIELIJKIJL, NFMNLLACFOA, PKLDIMIAFKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> PLLHLIFGBGI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GLAGFAPGLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "8")]
	public void MOBONOCICCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x701B990", Offset = "0x701AD90", VA = "0x18701B990", Slot = "6")]
	public Task OGHDKHKGMAA(long OPFNEKCHELM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x701B3C0", Offset = "0x701A7C0", VA = "0x18701B3C0", Slot = "9")]
	public bool ANENMNGNBDJ(string CIOJHADPGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x701B5A0", Offset = "0x701A9A0", VA = "0x18701B5A0", Slot = "10")]
	public int DGKHAFAELME(string CIOJHADPGDL, int POOOEFHFGKB = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x701B750", Offset = "0x701AB50", VA = "0x18701B750", Slot = "11")]
	public void FJAFLJDMDKC(string CIOJHADPGDL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x701B540", Offset = "0x701A940", VA = "0x18701B540", Slot = "12")]
	public bool DGIKIJIPGGD(string CIOJHADPGDL, bool POOOEFHFGKB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x701B810", Offset = "0x701AC10", VA = "0x18701B810", Slot = "13")]
	public void GAHMFCEIDOI(string CIOJHADPGDL, bool PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x701B420", Offset = "0x701A820", VA = "0x18701B420", Slot = "14")]
	public float CHKDAKFAEFB(string CIOJHADPGDL, float POOOEFHFGKB = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x701B7B0", Offset = "0x701ABB0", VA = "0x18701B7B0", Slot = "15")]
	public void FOKNMGFAJCH(string CIOJHADPGDL, float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x701B660", Offset = "0x701AA60", VA = "0x18701B660", Slot = "16")]
	public string ELKHKOCNMHE(string CIOJHADPGDL, [Optional] string POOOEFHFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x701B8D0", Offset = "0x701ACD0", VA = "0x18701B8D0", Slot = "17")]
	public void MKFJHLOJFOP(string CIOJHADPGDL, string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x701B4E0", Offset = "0x701A8E0", VA = "0x18701B4E0", Slot = "18")]
	public DateTime DBAECBNIOBB(string CIOJHADPGDL, [Optional] DateTime POOOEFHFGKB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x701B870", Offset = "0x701AC70", VA = "0x18701B870", Slot = "19")]
	public void MGEOGLNJBNG(string CIOJHADPGDL, DateTime PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x701B480", Offset = "0x701A880", VA = "0x18701B480", Slot = "20")]
	public long CPDCFFCPFMJ(string CIOJHADPGDL, long POOOEFHFGKB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x701B930", Offset = "0x701AD30", VA = "0x18701B930", Slot = "21")]
	public void NBNDIGHOAED(string CIOJHADPGDL, long PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C050", Offset = "0x2F7B450", VA = "0x182F7C050", Slot = "22")]
	public T JJPAOOOLOCE<T>(string CIOJHADPGDL, T POOOEFHFGKB, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C170", Offset = "0x2F7B570", VA = "0x182F7C170", Slot = "23")]
	public void KCAHMNCNNKD<T>(string CIOJHADPGDL, T PFKKDHPJFEH, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B810", Offset = "0x2F7AC10", VA = "0x182F7B810")]
	public T GEKLBPFDDHO<T>(string CIOJHADPGDL, T POOOEFHFGKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C250", Offset = "0x2F7B650", VA = "0x182F7C250")]
	public void NBJJIKECOBK<T>(string CIOJHADPGDL, T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x701B600", Offset = "0x701AA00", VA = "0x18701B600", Slot = "24")]
	public void EKPDCIHPFOP(string CIOJHADPGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x701B6C0", Offset = "0x701AAC0", VA = "0x18701B6C0", Slot = "25")]
	public Task FGKCLOOILCO(CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70193E0", Offset = "0x70187E0", VA = "0x1870193E0")]
	public KONPFIENNNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class ECCMKJEKONK<TParent> where TParent : NFMNLLACFOA
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<ECCMKJEKONK<TParent>> AJNCBHCKMMM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B68F60", Offset = "0x3B68360", VA = "0x183B68F60")]
	protected ECCMKJEKONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void FEPOBOIDOBF();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void DGGDDGOGPBI(string PBFBBOFLBNL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B689B0", Offset = "0x3B67DB0", VA = "0x183B689B0")]
	public static void FOCCDECOHMH(string PBFBBOFLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B68BF0", Offset = "0x3B67FF0", VA = "0x183B68BF0")]
	public static void PLENNPKEMBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BFMLPLNNGEL<TParent, TValue> : ECCMKJEKONK<TParent> where TParent : NFMNLLACFOA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly BFMLPLNNGEL<TParent, TValue> JDAIBLFKEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> IOCJIPDCNED;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5230D60", Offset = "0x5230160", VA = "0x185230D60")]
	public bool NKKJANMEMGN(string BLBBJJCCKGD, [Out] TValue OODGNCKBIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5230DC0", Offset = "0x52301C0", VA = "0x185230DC0")]
	public void NLJIEPFPBGO(string BLBBJJCCKGD, TValue PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4240960", Offset = "0x423FD60", VA = "0x184240960", Slot = "4")]
	protected override void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x41FACE0", Offset = "0x41FA0E0", VA = "0x1841FACE0", Slot = "5")]
	protected override void DGGDDGOGPBI(string BLBBJJCCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5231060", Offset = "0x5230460", VA = "0x185231060")]
	public BFMLPLNNGEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NFMNLLACFOA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOBONOCICCE();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANENMNGNBDJ(string CIOJHADPGDL);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DGKHAFAELME(string CIOJHADPGDL, int POOOEFHFGKB = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJAFLJDMDKC(string CIOJHADPGDL, int PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DGIKIJIPGGD(string CIOJHADPGDL, bool POOOEFHFGKB = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GAHMFCEIDOI(string CIOJHADPGDL, bool PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float CHKDAKFAEFB(string CIOJHADPGDL, float POOOEFHFGKB = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FOKNMGFAJCH(string CIOJHADPGDL, float PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string ELKHKOCNMHE(string CIOJHADPGDL, [Optional] string POOOEFHFGKB);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MKFJHLOJFOP(string CIOJHADPGDL, string PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime DBAECBNIOBB(string CIOJHADPGDL, [Optional] DateTime GDKLFIEDMAE);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MGEOGLNJBNG(string CIOJHADPGDL, DateTime GDKLFIEDMAE);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long CPDCFFCPFMJ(string CIOJHADPGDL, long POOOEFHFGKB);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NBNDIGHOAED(string CIOJHADPGDL, long PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T JJPAOOOLOCE<T>(string CIOJHADPGDL, T POOOEFHFGKB, NLOJLFDHIMD<T> HDKGLHCGBCB);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KCAHMNCNNKD<T>(string CIOJHADPGDL, T PFKKDHPJFEH, NLOJLFDHIMD<T> HDKGLHCGBCB);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EKPDCIHPFOP(string CIOJHADPGDL);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task FGKCLOOILCO([Optional] CancellationToken GBOOEEMCFEA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ICIELIJKIJL : NFMNLLACFOA
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GLAGFAPGLHN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OGHDKHKGMAA(long OPFNEKCHELM, CancellationToken GBOOEEMCFEA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PKLDIMIAFKG : NFMNLLACFOA
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DALBMFLLBGC : ICIELIJKIJL, NFMNLLACFOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct COFDIKNBIKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public DALBMFLLBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7015CF0", Offset = "0x70150F0", VA = "0x187015CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7015E80", Offset = "0x7015280", VA = "0x187015E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IHBOHKNHOGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public DALBMFLLBGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x70197B0", Offset = "0x7018BB0", VA = "0x1870197B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7019AA0", Offset = "0x7018EA0", VA = "0x187019AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly ICIELIJKIJL NOBCPPOECGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly FBANNHKJEHC DBLDEAHCCII;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7015F70", Offset = "0x7015370", VA = "0x187015F70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GLAGFAPGLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7016EF0", Offset = "0x70162F0", VA = "0x187016EF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7016D70", Offset = "0x7016170", VA = "0x187016D70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7016F50", Offset = "0x7016350", VA = "0x187016F50")]
	[UnityEngine.Scripting.Preserve]
	public DALBMFLLBGC([NDMEANGLJKD(null)] LLCNKAICICK GHGJNKBNBNH, [NDMEANGLJKD("Disk_Unity")] ICIELIJKIJL NOBCPPOECGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7016CA0", Offset = "0x70160A0", VA = "0x187016CA0", Slot = "8")]
	public void MOBONOCICCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7015EE0", Offset = "0x70152E0", VA = "0x187015EE0", Slot = "9")]
	public bool ANENMNGNBDJ(string CIOJHADPGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7016580", Offset = "0x7015980", VA = "0x187016580", Slot = "10")]
	public int DGKHAFAELME(string CIOJHADPGDL, int POOOEFHFGKB = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7016A70", Offset = "0x7015E70", VA = "0x187016A70", Slot = "11")]
	public void FJAFLJDMDKC(string CIOJHADPGDL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x70163F0", Offset = "0x70157F0", VA = "0x1870163F0", Slot = "12")]
	public bool DGIKIJIPGGD(string CIOJHADPGDL, bool POOOEFHFGKB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7016B50", Offset = "0x7015F50", VA = "0x187016B50", Slot = "13")]
	public void GAHMFCEIDOI(string CIOJHADPGDL, bool PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7015FD0", Offset = "0x70153D0", VA = "0x187015FD0", Slot = "14")]
	public float CHKDAKFAEFB(string CIOJHADPGDL, float POOOEFHFGKB = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7016AE0", Offset = "0x7015EE0", VA = "0x187016AE0", Slot = "15")]
	public void FOKNMGFAJCH(string CIOJHADPGDL, float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x70167E0", Offset = "0x7015BE0", VA = "0x1870167E0", Slot = "16")]
	public string ELKHKOCNMHE(string CIOJHADPGDL, [Optional] string POOOEFHFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7016C30", Offset = "0x7016030", VA = "0x187016C30", Slot = "17")]
	public void MKFJHLOJFOP(string CIOJHADPGDL, string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7016290", Offset = "0x7015690", VA = "0x187016290", Slot = "18")]
	public DateTime DBAECBNIOBB(string CIOJHADPGDL, [Optional] DateTime POOOEFHFGKB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7016BC0", Offset = "0x7015FC0", VA = "0x187016BC0", Slot = "19")]
	public void MGEOGLNJBNG(string CIOJHADPGDL, DateTime GDKLFIEDMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7016130", Offset = "0x7015530", VA = "0x187016130", Slot = "20")]
	public long CPDCFFCPFMJ(string CIOJHADPGDL, long POOOEFHFGKB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7016D00", Offset = "0x7016100", VA = "0x187016D00", Slot = "21")]
	public void NBNDIGHOAED(string CIOJHADPGDL, long PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2CDDE10", Offset = "0x2CDD210", VA = "0x182CDDE10", Slot = "22")]
	public T JJPAOOOLOCE<T>(string CIOJHADPGDL, T POOOEFHFGKB, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE5A0", Offset = "0x2CDD9A0", VA = "0x182CDE5A0", Slot = "23")]
	public void KCAHMNCNNKD<T>(string CIOJHADPGDL, T PFKKDHPJFEH, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x70166D0", Offset = "0x7015AD0", VA = "0x1870166D0", Slot = "24")]
	public void EKPDCIHPFOP(string CIOJHADPGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7016980", Offset = "0x7015D80", VA = "0x187016980", Slot = "25")]
	[AsyncStateMachine(typeof(COFDIKNBIKL))]
	public Task FGKCLOOILCO([Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7016DE0", Offset = "0x70161E0", VA = "0x187016DE0", Slot = "6")]
	[AsyncStateMachine(typeof(IHBOHKNHOGK))]
	public Task OGHDKHKGMAA(long OPFNEKCHELM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NAKHGFKNEHI : ICIELIJKIJL, NFMNLLACFOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ELGCFOJLKJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public NAKHGFKNEHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7017060", Offset = "0x7016460", VA = "0x187017060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7017440", Offset = "0x7016840", VA = "0x187017440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class MDFDCJKDKIC : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public NAKHGFKNEHI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public MDFDCJKDKIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x701BA20", Offset = "0x701AE20", VA = "0x18701BA20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x701BA90", Offset = "0x701AE90", VA = "0x18701BA90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LLCNKAICICK GHGJNKBNBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool EGAKBCKACKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool LEKAPHLDNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private KBBANPCOGCH FLDNENGOFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private IDFKLKAPHIN MIHLKPPNAHP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action GLAGFAPGLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x701C2F0", Offset = "0x701B6F0", VA = "0x18701C2F0")]
	[UnityEngine.Scripting.Preserve]
	public NAKHGFKNEHI([NDMEANGLJKD(null)] LLCNKAICICK GHGJNKBNBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "8")]
	public void MOBONOCICCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x701C1D0", Offset = "0x701B5D0", VA = "0x18701C1D0", Slot = "6")]
	public Task OGHDKHKGMAA(long OPFNEKCHELM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x153BFF0", Offset = "0x153B3F0", VA = "0x18153BFF0")]
	private static int NLGKOIDEDAH(bool PFKKDHPJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x701BAE0", Offset = "0x701AEE0", VA = "0x18701BAE0", Slot = "9")]
	public bool ANENMNGNBDJ(string CIOJHADPGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x701BCC0", Offset = "0x701B0C0", VA = "0x18701BCC0", Slot = "10")]
	public int DGKHAFAELME(string CIOJHADPGDL, int POOOEFHFGKB = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x701BEA0", Offset = "0x701B2A0", VA = "0x18701BEA0", Slot = "11")]
	public void FJAFLJDMDKC(string CIOJHADPGDL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x701BC90", Offset = "0x701B090", VA = "0x18701BC90", Slot = "12")]
	public bool DGIKIJIPGGD(string CIOJHADPGDL, bool POOOEFHFGKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x701BF00", Offset = "0x701B300", VA = "0x18701BF00", Slot = "13")]
	public void GAHMFCEIDOI(string CIOJHADPGDL, bool PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x701BB20", Offset = "0x701AF20", VA = "0x18701BB20", Slot = "14")]
	public float CHKDAKFAEFB(string CIOJHADPGDL, float POOOEFHFGKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x701BED0", Offset = "0x701B2D0", VA = "0x18701BED0", Slot = "15")]
	public void FOKNMGFAJCH(string CIOJHADPGDL, float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x701BC20", Offset = "0x701B020", VA = "0x18701BC20", Slot = "18")]
	public DateTime DBAECBNIOBB(string CIOJHADPGDL, [Optional] DateTime POOOEFHFGKB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x701C0C0", Offset = "0x701B4C0", VA = "0x18701C0C0", Slot = "19")]
	public void MGEOGLNJBNG(string CIOJHADPGDL, DateTime GDKLFIEDMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x701BBB0", Offset = "0x701AFB0", VA = "0x18701BBB0", Slot = "20")]
	public long CPDCFFCPFMJ(string CIOJHADPGDL, long POOOEFHFGKB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x701C160", Offset = "0x701B560", VA = "0x18701C160", Slot = "21")]
	public void NBNDIGHOAED(string CIOJHADPGDL, long PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x303C3B0", Offset = "0x303B7B0", VA = "0x18303C3B0", Slot = "22")]
	public T JJPAOOOLOCE<T>(string CIOJHADPGDL, T POOOEFHFGKB, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x303C3B0", Offset = "0x303B7B0", VA = "0x18303C3B0", Slot = "23")]
	public void KCAHMNCNNKD<T>(string CIOJHADPGDL, T PFKKDHPJFEH, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x303CE10", Offset = "0x303C210", VA = "0x18303CE10")]
	private T PEEKILNMIIG<T>(string CIOJHADPGDL, T POOOEFHFGKB, [Optional] NLOJLFDHIMD<T> GBJHCOMHPLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x303C6B0", Offset = "0x303BAB0", VA = "0x18303C6B0")]
	private void KGACGICCOAJ<T>(string CIOJHADPGDL, T PFKKDHPJFEH, [Optional] NLOJLFDHIMD<T> GBJHCOMHPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x701BD80", Offset = "0x701B180", VA = "0x18701BD80", Slot = "16")]
	public string ELKHKOCNMHE(string CIOJHADPGDL, string POOOEFHFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x701C130", Offset = "0x701B530", VA = "0x18701C130", Slot = "17")]
	public void MKFJHLOJFOP(string CIOJHADPGDL, string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x701C260", Offset = "0x701B660", VA = "0x18701C260")]
	private void OJMIFGKPAGG(string CIOJHADPGDL, string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x701BB00", Offset = "0x701AF00", VA = "0x18701BB00")]
	private string BDFIGDCEJBG(string CIOJHADPGDL, string POOOEFHFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x701BCF0", Offset = "0x701B0F0", VA = "0x18701BCF0", Slot = "24")]
	public void EKPDCIHPFOP(string CIOJHADPGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x701C020", Offset = "0x701B420", VA = "0x18701C020")]
	private string KPFLBOFKDDI(string PBFBBOFLBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x701BDB0", Offset = "0x701B1B0", VA = "0x18701BDB0", Slot = "25")]
	[AsyncStateMachine(typeof(ELGCFOJLKJG))]
	public Task FGKCLOOILCO(CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x701BF30", Offset = "0x701B330", VA = "0x18701BF30")]
	[IteratorStateMachine(typeof(MDFDCJKDKIC))]
	private IEnumerator<MLEAAPMIINP> HAOFOHIGLGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x701BB50", Offset = "0x701AF50", VA = "0x18701BB50")]
	private void CMMPBPBLDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x701BFB0", Offset = "0x701B3B0", VA = "0x18701BFB0")]
	private void KCIMHAKFIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x701C280", Offset = "0x701B680", VA = "0x18701C280")]
	private void PFIMIGCPENI(bool LFBALLLBCLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class INEHKODFAMM : ICIELIJKIJL, NFMNLLACFOA
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
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
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Dictionary<string, string> DBJBLFBNBPH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PEHHLBMDPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string IJGDMOPGMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x701A690", Offset = "0x7019A90", VA = "0x18701A690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> CLACKEHHBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x701A120", Offset = "0x7019520", VA = "0x18701A120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action GLAGFAPGLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	[UnityEngine.Scripting.Preserve]
	public INEHKODFAMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "8")]
	public void MOBONOCICCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x701A880", Offset = "0x7019C80", VA = "0x18701A880", Slot = "6")]
	public Task OGHDKHKGMAA(long OPFNEKCHELM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7019E90", Offset = "0x7019290", VA = "0x187019E90", Slot = "14")]
	public float CHKDAKFAEFB(string PBFBBOFLBNL, float POOOEFHFGKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x701A620", Offset = "0x7019A20", VA = "0x18701A620", Slot = "13")]
	public void GAHMFCEIDOI(string PBFBBOFLBNL, bool PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7019FE0", Offset = "0x70193E0", VA = "0x187019FE0", Slot = "12")]
	public bool DGIKIJIPGGD(string PBFBBOFLBNL, bool POOOEFHFGKB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x701A0B0", Offset = "0x70194B0", VA = "0x18701A0B0", Slot = "10")]
	public int DGKHAFAELME(string PBFBBOFLBNL, int POOOEFHFGKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7019F70", Offset = "0x7019370", VA = "0x187019F70", Slot = "18")]
	public DateTime DBAECBNIOBB(string CIOJHADPGDL, [Optional] DateTime POOOEFHFGKB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x701A700", Offset = "0x7019B00", VA = "0x18701A700", Slot = "19")]
	public void MGEOGLNJBNG(string PBFBBOFLBNL, DateTime PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x701A5B0", Offset = "0x70199B0", VA = "0x18701A5B0", Slot = "15")]
	public void FOKNMGFAJCH(string PBFBBOFLBNL, float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x701A540", Offset = "0x7019940", VA = "0x18701A540", Slot = "11")]
	public void FJAFLJDMDKC(string PBFBBOFLBNL, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7019F00", Offset = "0x7019300", VA = "0x187019F00", Slot = "20")]
	public long CPDCFFCPFMJ(string CIOJHADPGDL, long POOOEFHFGKB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x701A810", Offset = "0x7019C10", VA = "0x18701A810", Slot = "21")]
	public void NBNDIGHOAED(string CIOJHADPGDL, long PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2E95EC0", Offset = "0x2E952C0", VA = "0x182E95EC0", Slot = "22")]
	public T JJPAOOOLOCE<T>(string CIOJHADPGDL, T POOOEFHFGKB, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2E95EC0", Offset = "0x2E952C0", VA = "0x182E95EC0", Slot = "23")]
	public void KCAHMNCNNKD<T>(string CIOJHADPGDL, T PFKKDHPJFEH, NLOJLFDHIMD<T> HDKGLHCGBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x701A220", Offset = "0x7019620", VA = "0x18701A220", Slot = "16")]
	public string ELKHKOCNMHE(string PBFBBOFLBNL, string POOOEFHFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x701A770", Offset = "0x7019B70", VA = "0x18701A770", Slot = "17")]
	public void MKFJHLOJFOP(string PBFBBOFLBNL, string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x701A160", Offset = "0x7019560", VA = "0x18701A160", Slot = "24")]
	public void EKPDCIHPFOP(string PBFBBOFLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7019B00", Offset = "0x7018F00", VA = "0x187019B00", Slot = "9")]
	public bool ANENMNGNBDJ(string PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x701A2D0", Offset = "0x70196D0", VA = "0x18701A2D0", Slot = "25")]
	public Task FGKCLOOILCO(CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2EED9F0", Offset = "0x2EECDF0", VA = "0x182EED9F0")]
	private T GEKLBPFDDHO<T>(string CIOJHADPGDL, T POOOEFHFGKB, [Optional] NLOJLFDHIMD<T> GBJHCOMHPLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2EEED10", Offset = "0x2EEE110", VA = "0x182EEED10")]
	private void NBJJIKECOBK<T>(string CIOJHADPGDL, T PFKKDHPJFEH, [Optional] NLOJLFDHIMD<T> GBJHCOMHPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7019B90", Offset = "0x7018F90", VA = "0x187019B90")]
	private Dictionary<string, string> BNKGMCJMMMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CNGBPDIKJMG
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action GLAGFAPGLHN;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOBONOCICCE();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task IOJCEKAJNJN(long OPFNEKCHELM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JOJBNPAFHOK(BPPCCALHMLC BAMIKKPOGMN = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool POIEHOHIECH(string CIOJHADPGDL, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BNLHAFEDGEO(string CIOJHADPGDL, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string BGNKDIOINHM(string CIOJHADPGDL, [Optional] string POOOEFHFGKB, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JFNBJADMBKH FOFLIDEPIOO(string CIOJHADPGDL, string PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int IALFPKJHBON(string CIOJHADPGDL, int POOOEFHFGKB = 0, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JFNBJADMBKH DPLFDJCHBGM(string CIOJHADPGDL, int PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IGMLFFLPFLH(string CIOJHADPGDL, bool POOOEFHFGKB, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JFNBJADMBKH KKLKJFAKNCB(string CIOJHADPGDL, bool PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float KLGMHKCKECK(string CIOJHADPGDL, float POOOEFHFGKB = 0f, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JFNBJADMBKH IJLIKLIFOCG(string CIOJHADPGDL, float PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime KOBGPDOOJKJ(string CIOJHADPGDL, [Optional] DateTime POOOEFHFGKB, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JFNBJADMBKH PGCMEPNEKKJ(string CIOJHADPGDL, DateTime PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long JFJEHANFNBC(string CIOJHADPGDL, long POOOEFHFGKB = 0L, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	JFNBJADMBKH DFDIFPJHGCJ(string CIOJHADPGDL, long PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T GNHGNODLMJK<T>(string CIOJHADPGDL, [Optional] T POOOEFHFGKB, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	JFNBJADMBKH HKMNAMNOMMJ<T>(string CIOJHADPGDL, T PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool PHKFFLCKCFK(string CIOJHADPGDL);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool HBJFPHJEKGH(string CIOJHADPGDL);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string CKMGOHEFGPE(string CIOJHADPGDL, [Optional] string POOOEFHFGKB);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	JFNBJADMBKH ABEAKAPOMKJ(string CIOJHADPGDL, string PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int MPIEPCHJANN(string CIOJHADPGDL, int POOOEFHFGKB = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "26")]
	JFNBJADMBKH PGGHHFAHGNE(string CIOJHADPGDL, int PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IJNBHFEHAGI(string CIOJHADPGDL, bool POOOEFHFGKB);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	JFNBJADMBKH NHHANKKHFLN(string CIOJHADPGDL, bool PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float HAPKGHLINOC(string CIOJHADPGDL, float POOOEFHFGKB = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	JFNBJADMBKH DFLODCHEAHH(string CIOJHADPGDL, float PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime ODMCCLNJDCB(string CIOJHADPGDL, [Optional] DateTime POOOEFHFGKB);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	JFNBJADMBKH CADBHJHOAGG(string CIOJHADPGDL, DateTime PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long FPKAJOPHDOI(string CIOJHADPGDL, long POOOEFHFGKB = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	JFNBJADMBKH AELBEBDGIJN(string CIOJHADPGDL, long PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void OJNFHGEEGMA<T>(NLOJLFDHIMD<T> HDKGLHCGBCB, [Optional] IEqualityComparer<T> LFBKIIFECDJ);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CKLHBBFLGFA<T>();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable EBOHKKCBBDB();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JEDKPLBDPIE(float FOPCLCJOGBF);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task CMMPBPBLDEO([Optional] CancellationToken GBOOEEMCFEA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum JFNBJADMBKH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AHDPAAAPGKH : CNGBPDIKJMG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class FIEDJEOHINE
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected static readonly HashSet<FIEDJEOHINE> EBMHLDOPMPB;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x70190C0", Offset = "0x70184C0", VA = "0x1870190C0")]
		public static void PLENNPKEMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FEPOBOIDOBF();

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		protected FIEDJEOHINE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class EMJFHKIAHIA<T> : FIEDJEOHINE
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly EMJFHKIAHIA<T> GHDNHBBFDEB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NLOJLFDHIMD<T> OKLKHEFAEHE
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> MAHOOJIOPCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OKPDOKKJAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3B5FA60", Offset = "0x3B5EE60", VA = "0x183B5FA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC900", Offset = "0x3BABD00", VA = "0x183BAC900")]
		private EMJFHKIAHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC2D0", Offset = "0x3BAB6D0", VA = "0x183BAC2D0")]
		public void CIGOIKFLIDO(NLOJLFDHIMD<T> GBJHCOMHPLO, [Optional] IEqualityComparer<T> LFBKIIFECDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC630", Offset = "0x3BABA30", VA = "0x183BAC630", Slot = "4")]
		public override void FEPOBOIDOBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KHAADHMMHNC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly AHDPAAAPGKH PMKHFAKFGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly object LDIEOCJJHKD;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x701B310", Offset = "0x701A710", VA = "0x18701B310")]
		public KHAADHMMHNC(AHDPAAAPGKH PMKHFAKFGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x701B2E0", Offset = "0x701A6E0", VA = "0x18701B2E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct IEMOLBFNJCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AHDPAAAPGKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7019470", Offset = "0x7018870", VA = "0x187019470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7019750", Offset = "0x7018B50", VA = "0x187019750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct BPEALJDFGFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AHDPAAAPGKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NFMNLLACFOA backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7015B60", Offset = "0x7014F60", VA = "0x187015B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct JENODDGIHOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AHDPAAAPGKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x701A910", Offset = "0x7019D10", VA = "0x18701A910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x701ADE0", Offset = "0x701A1E0", VA = "0x18701ADE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FABHLMNIFOP : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private MLEAAPMIINP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AHDPAAAPGKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public FABHLMNIFOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x70174A0", Offset = "0x70168A0", VA = "0x1870174A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7017530", Offset = "0x7016930", VA = "0x187017530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly ICIELIJKIJL NNLEHNNPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly ICIELIJKIJL OCICKHMOEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly PKLDIMIAFKG LDJINJAOFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly KBBANPCOGCH FLDNENGOFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NKBDOKAKKMO.AKFMJIDFGJK NPGPMMEDAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JLCPCMNKJOG BMNCPJIPHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HashSet<NFMNLLACFOA> HAHDLGHGCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Task DFCELJPGOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<string, string> JLAPHLKOJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private IDFKLKAPHIN INDPHEKPOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly object OAMLGBMJBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly object OOALCDBPECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private long APKDFOIBAPG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool FBOALBLNBME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7013770", Offset = "0x7012B70", VA = "0x187013770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource JCBFPPIDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x89D950", Offset = "0x89CD50", VA = "0x18089D950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x89D970", Offset = "0x89CD70", VA = "0x18089D970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action GLAGFAPGLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x70156F0", Offset = "0x7014AF0", VA = "0x1870156F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7015200", Offset = "0x7014600", VA = "0x187015200", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x70132A0", Offset = "0x70126A0", VA = "0x1870132A0")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void DJNFEGBLBOB(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7015790", Offset = "0x7014B90", VA = "0x187015790")]
	[UnityEngine.Scripting.Preserve]
	public AHDPAAAPGKH([NDMEANGLJKD("Disk")] ICIELIJKIJL NNLEHNNPBPA, [NDMEANGLJKD("Cloud")] ICIELIJKIJL OCICKHMOEFG, [NDMEANGLJKD(null)] PKLDIMIAFKG LDJINJAOFHM, [NDMEANGLJKD(null)] KBBANPCOGCH FLDNENGOFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x70134F0", Offset = "0x70128F0", VA = "0x1870134F0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7014390", Offset = "0x7013790", VA = "0x187014390")]
	private void IODMPGAEKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7014E80", Offset = "0x7014280", VA = "0x187014E80", Slot = "6")]
	public void MOBONOCICCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x70143E0", Offset = "0x70137E0", VA = "0x1870143E0", Slot = "7")]
	public Task IOJCEKAJNJN(long OPFNEKCHELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7015540", Offset = "0x7014940", VA = "0x187015540")]
	[AsyncStateMachine(typeof(IEMOLBFNJCO))]
	private Task PKOOEEKENGA(long OPFNEKCHELM, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7013610", Offset = "0x7012A10", VA = "0x187013610")]
	private void EBOLHOJPCOP(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7014870", Offset = "0x7013C70", VA = "0x187014870")]
	private void KAMJBCLAECJ(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x70151A0", Offset = "0x70145A0", VA = "0x1870151A0")]
	private string OCHENACGOGH(string FGGFDAFLOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7013790", Offset = "0x7012B90", VA = "0x187013790")]
	private void FDCFGEAELNP(BPPCCALHMLC BAMIKKPOGMN, string PBFBBOFLBNL, [Out] ICIELIJKIJL OPMNAGFLJCD, [Out] string ENBJPKINEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7012D90", Offset = "0x7012190", VA = "0x187012D90")]
	private ICIELIJKIJL CCEMCKLIIHO(BPPCCALHMLC BAMIKKPOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x70147B0", Offset = "0x7013BB0", VA = "0x1870147B0", Slot = "8")]
	public bool JOJBNPAFHOK(BPPCCALHMLC BAMIKKPOGMN = BPPCCALHMLC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7015650", Offset = "0x7014A50", VA = "0x187015650", Slot = "9")]
	public bool POIEHOHIECH(string CIOJHADPGDL, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7012C30", Offset = "0x7012030", VA = "0x187012C30", Slot = "10")]
	public bool BNLHAFEDGEO(string CIOJHADPGDL, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7012A50", Offset = "0x7011E50", VA = "0x187012A50", Slot = "11")]
	public string BGNKDIOINHM(string CIOJHADPGDL, [Optional] string POOOEFHFGKB, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7013B40", Offset = "0x7012F40", VA = "0x187013B40", Slot = "12")]
	public JFNBJADMBKH FOFLIDEPIOO(string CIOJHADPGDL, string PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7013DC0", Offset = "0x70131C0", VA = "0x187013DC0", Slot = "13")]
	public int IALFPKJHBON(string CIOJHADPGDL, int POOOEFHFGKB = 0, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7013370", Offset = "0x7012770", VA = "0x187013370", Slot = "14")]
	public JFNBJADMBKH DPLFDJCHBGM(string CIOJHADPGDL, int PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7013E70", Offset = "0x7013270", VA = "0x187013E70", Slot = "15")]
	public bool IGMLFFLPFLH(string CIOJHADPGDL, bool POOOEFHFGKB, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x70148F0", Offset = "0x7013CF0", VA = "0x1870148F0", Slot = "16")]
	public JFNBJADMBKH KKLKJFAKNCB(string CIOJHADPGDL, bool PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7014A70", Offset = "0x7013E70", VA = "0x187014A70", Slot = "17")]
	public float KLGMHKCKECK(string CIOJHADPGDL, float POOOEFHFGKB = 0f, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7013F20", Offset = "0x7013320", VA = "0x187013F20", Slot = "18")]
	public JFNBJADMBKH IJLIKLIFOCG(string CIOJHADPGDL, float PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7014B20", Offset = "0x7013F20", VA = "0x187014B20", Slot = "19")]
	public DateTime KOBGPDOOJKJ(string CIOJHADPGDL, [Optional] DateTime POOOEFHFGKB, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7015310", Offset = "0x7014710", VA = "0x187015310", Slot = "20")]
	public JFNBJADMBKH PGCMEPNEKKJ(string CIOJHADPGDL, DateTime PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7014710", Offset = "0x7013B10", VA = "0x187014710", Slot = "21")]
	public long JFJEHANFNBC(string CIOJHADPGDL, long POOOEFHFGKB = 0L, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7013060", Offset = "0x7012460", VA = "0x187013060", Slot = "22")]
	public JFNBJADMBKH DFDIFPJHGCJ(string CIOJHADPGDL, long PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x35C5990", Offset = "0x35C4D90", VA = "0x1835C5990", Slot = "23")]
	public T GNHGNODLMJK<T>(string CIOJHADPGDL, [Optional] T POOOEFHFGKB, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x35C5990", Offset = "0x35C4D90", VA = "0x1835C5990", Slot = "24")]
	public JFNBJADMBKH HKMNAMNOMMJ<T>(string CIOJHADPGDL, T PFKKDHPJFEH, BPPCCALHMLC PCAEHFMGJLO = BPPCCALHMLC.CLOUD)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x70154E0", Offset = "0x70148E0", VA = "0x1870154E0", Slot = "25")]
	public bool PHKFFLCKCFK(string CIOJHADPGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7013DB0", Offset = "0x70131B0", VA = "0x187013DB0", Slot = "26")]
	public bool HBJFPHJEKGH(string CIOJHADPGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7012E10", Offset = "0x7012210", VA = "0x187012E10", Slot = "27")]
	public string CKMGOHEFGPE(string CIOJHADPGDL, [Optional] string POOOEFHFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x70129F0", Offset = "0x7011DF0", VA = "0x1870129F0", Slot = "28")]
	public JFNBJADMBKH ABEAKAPOMKJ(string CIOJHADPGDL, string PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7014EF0", Offset = "0x70142F0", VA = "0x187014EF0", Slot = "29")]
	public int MPIEPCHJANN(string CIOJHADPGDL, int POOOEFHFGKB = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x70154B0", Offset = "0x70148B0", VA = "0x1870154B0", Slot = "30")]
	public JFNBJADMBKH PGGHHFAHGNE(string CIOJHADPGDL, int PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x70140A0", Offset = "0x70134A0", VA = "0x1870140A0", Slot = "31")]
	public bool IJNBHFEHAGI(string CIOJHADPGDL, bool POOOEFHFGKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7014F90", Offset = "0x7014390", VA = "0x187014F90", Slot = "32")]
	public JFNBJADMBKH NHHANKKHFLN(string CIOJHADPGDL, bool PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7013D40", Offset = "0x7013140", VA = "0x187013D40", Slot = "33")]
	public float HAPKGHLINOC(string CIOJHADPGDL, float POOOEFHFGKB = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x70131E0", Offset = "0x70125E0", VA = "0x1870131E0", Slot = "34")]
	public JFNBJADMBKH DFLODCHEAHH(string CIOJHADPGDL, float PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x70152A0", Offset = "0x70146A0", VA = "0x1870152A0", Slot = "35")]
	public DateTime ODMCCLNJDCB(string CIOJHADPGDL, [Optional] DateTime POOOEFHFGKB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7012D60", Offset = "0x7012160", VA = "0x187012D60", Slot = "36")]
	public JFNBJADMBKH CADBHJHOAGG(string CIOJHADPGDL, DateTime PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7013CD0", Offset = "0x70130D0", VA = "0x187013CD0", Slot = "37")]
	public long FPKAJOPHDOI(string CIOJHADPGDL, long POOOEFHFGKB = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7012A20", Offset = "0x7011E20", VA = "0x187012A20", Slot = "38")]
	public JFNBJADMBKH AELBEBDGIJN(string CIOJHADPGDL, long PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7013310", Offset = "0x7012710", VA = "0x187013310")]
	private bool DOFNEMBPGON(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7012F70", Offset = "0x7012370", VA = "0x187012F70")]
	private bool DEENFBHMGDO(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x70145B0", Offset = "0x70139B0", VA = "0x1870145B0")]
	private JFNBJADMBKH JDPKJDLGIOH(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, string PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7013630", Offset = "0x7012A30", VA = "0x187013630")]
	private JFNBJADMBKH EFECKCPEKEJ(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, int PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7013A00", Offset = "0x7012E00", VA = "0x187013A00")]
	private JFNBJADMBKH FIJBAANJPLO(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, bool PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7014D30", Offset = "0x7014130", VA = "0x187014D30")]
	private JFNBJADMBKH MINDJCHJNGH(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, float PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7014BC0", Offset = "0x7013FC0", VA = "0x187014BC0")]
	private JFNBJADMBKH LGJDDEAKIGK(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, DateTime PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7012AF0", Offset = "0x7011EF0", VA = "0x187012AF0")]
	private JFNBJADMBKH BJNNDGPOPMP(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, long PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x35C68D0", Offset = "0x35C5CD0", VA = "0x1835C68D0")]
	private T KNJKKHIBLIJ<T>(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, T POOOEFHFGKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x35C5CF0", Offset = "0x35C50F0", VA = "0x1835C5CF0")]
	private JFNBJADMBKH JEKGIJAOJEE<T>(NFMNLLACFOA OPMNAGFLJCD, string CIOJHADPGDL, T PFKKDHPJFEH)
	{
		return default(JFNBJADMBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x35C6E40", Offset = "0x35C6240", VA = "0x1835C6E40", Slot = "39")]
	public void OJNFHGEEGMA<T>(NLOJLFDHIMD<T> HDKGLHCGBCB, [Optional] IEqualityComparer<T> LFBKIIFECDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x35C5910", Offset = "0x35C4D10", VA = "0x1835C5910", Slot = "40")]
	public void CKLHBBFLGFA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7013930", Offset = "0x7012D30", VA = "0x187013930")]
	[AsyncStateMachine(typeof(BPEALJDFGFM))]
	private void FGKCLOOILCO(NFMNLLACFOA HBEGCCIFKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7012E80", Offset = "0x7012280", VA = "0x187012E80", Slot = "43")]
	[AsyncStateMachine(typeof(JENODDGIHOO))]
	public Task CMMPBPBLDEO([Optional] CancellationToken CFGHNHCDKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7014FC0", Offset = "0x70143C0", VA = "0x187014FC0")]
	private void NPKOFICLAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7013530", Offset = "0x7012930", VA = "0x187013530", Slot = "41")]
	public IDisposable EBOHKKCBBDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7014700", Offset = "0x7013B00", VA = "0x187014700", Slot = "42")]
	public void JEDKPLBDPIE(float FOPCLCJOGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7014110", Offset = "0x7013510", VA = "0x187014110")]
	private void ILAFGKECECP(float POAPONMMMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7013210", Offset = "0x7012610", VA = "0x187013210")]
	[IteratorStateMachine(typeof(FABHLMNIFOP))]
	private IEnumerator<MLEAAPMIINP> DILOEDAJMLJ(float FOPCLCJOGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7014F60", Offset = "0x7014360", VA = "0x187014F60")]
	[CompilerGenerated]
	private void NHECNJGKCKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JONMLAAPKBD : DBCAJGLBKLB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static JONMLAAPKBD GHDNHBBFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x701B1B0", Offset = "0x701A5B0", VA = "0x18701B1B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x701B0C0", Offset = "0x701A4C0", VA = "0x18701B0C0", Slot = "9")]
	public override string IJIPNHCCMND(bool CMILLOOAKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x701AE40", Offset = "0x701A240", VA = "0x18701AE40", Slot = "10")]
	protected override bool BKECIFEODPM(string CMILLOOAKEN, [Out] bool PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x701B2A0", Offset = "0x701A6A0", VA = "0x18701B2A0")]
	public JONMLAAPKBD()
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
