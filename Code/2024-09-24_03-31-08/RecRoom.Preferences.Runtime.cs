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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E50450", Offset = "0x6E4EE50", VA = "0x186E50450", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OCLLPAHIFJJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class DNGJGNFNIAL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void DOPAPKBKMNB(NFGPPKOAKKH NPBOJOHIEHM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E48760", Offset = "0x6E47160", VA = "0x186E48760")]
	private static void FNAFMMIJDPI(NFGPPKOAKKH NPBOJOHIEHM, DOPAPKBKMNB BHJCFKNOFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E48D20", Offset = "0x6E47720", VA = "0x186E48D20")]
	public static bool PMEEIHCEKOF(this NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, [Optional] DOPAPKBKMNB BHJCFKNOFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E48A90", Offset = "0x6E47490", VA = "0x186E48A90")]
	public static OEIACICMCOD MNAEONIPFKJ(this NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, string IPHMAHBENGI, [Optional] DOPAPKBKMNB BHJCFKNOFBG)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E487E0", Offset = "0x6E471E0", VA = "0x186E487E0")]
	public static OEIACICMCOD HOICFKHLLLH(this NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, int IPHMAHBENGI, [Optional] DOPAPKBKMNB BHJCFKNOFBG)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E484C0", Offset = "0x6E46EC0", VA = "0x186E484C0")]
	public static OEIACICMCOD EHAIIANNGIB(this NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, bool IPHMAHBENGI, [Optional] DOPAPKBKMNB BHJCFKNOFBG)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E48610", Offset = "0x6E47010", VA = "0x186E48610")]
	public static OEIACICMCOD FMJPPNBNPKD(this NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, float IPHMAHBENGI, [Optional] DOPAPKBKMNB BHJCFKNOFBG)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E48920", Offset = "0x6E47320", VA = "0x186E48920")]
	public static OEIACICMCOD IKPGNIKDHNB(this NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, DateTime IPHMAHBENGI, [Optional] DOPAPKBKMNB BHJCFKNOFBG)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E48BE0", Offset = "0x6E475E0", VA = "0x186E48BE0")]
	public static OEIACICMCOD PFHGJDAHFBH(this NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, long IPHMAHBENGI, [Optional] DOPAPKBKMNB BHJCFKNOFBG)
	{
		return default(OEIACICMCOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MJKKMOJANMK : POKPAFIAAMA, NFGPPKOAKKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IOBBFHCKJHF AKBECICBOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> OFFIADODFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> FPPEIGFFOIO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> PNDCHFCNLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E4C160", Offset = "0x6E4AB60", VA = "0x186E4C160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action PLPIBKBACML
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D1A0", Offset = "0x6E4BBA0", VA = "0x186E4D1A0")]
	[UnityEngine.Scripting.Preserve]
	public MJKKMOJANMK([LKKACOOMNBP(null)] IOBBFHCKJHF AKBECICBOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "8")]
	public void NNJCLADGAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B6F0", Offset = "0x6E4A0F0", VA = "0x186E4B6F0")]
	private DirectoryInfo BDCHEHAFAPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BCB0", Offset = "0x6E4A6B0", VA = "0x186E4BCB0", Slot = "6")]
	public Task DFMKMHBLCKG(long LFGKLELCCBE, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CA10", Offset = "0x6E4B410", VA = "0x186E4CA10", Slot = "14")]
	public float HHCMKODEPKN(string COMNIKKFEEB, float FABNMHPKJIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CA80", Offset = "0x6E4B480", VA = "0x186E4CA80", Slot = "13")]
	public void JFEBCMDJKFD(string COMNIKKFEEB, bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B7F0", Offset = "0x6E4A1F0", VA = "0x186E4B7F0", Slot = "12")]
	public bool BGOJILMPPEB(string COMNIKKFEEB, bool FABNMHPKJIP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C1A0", Offset = "0x6E4ABA0", VA = "0x186E4C1A0", Slot = "10")]
	public int GGDBFJNBLOK(string COMNIKKFEEB, int FABNMHPKJIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CE90", Offset = "0x6E4B890", VA = "0x186E4CE90", Slot = "18")]
	public DateTime LABCKPGOLDM(string PCFKMOBOMBL, [Optional] DateTime FABNMHPKJIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BDF0", Offset = "0x6E4A7F0", VA = "0x186E4BDF0", Slot = "19")]
	public void EEFBFLNCAAA(string COMNIKKFEEB, DateTime IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CF00", Offset = "0x6E4B900", VA = "0x186E4CF00", Slot = "15")]
	public void LADDBAFAEFG(string COMNIKKFEEB, float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D130", Offset = "0x6E4BB30", VA = "0x186E4D130", Slot = "11")]
	public void OMIMMMAMDPJ(string COMNIKKFEEB, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BC40", Offset = "0x6E4A640", VA = "0x186E4BC40", Slot = "20")]
	public long DEIDOJLHEHH(string PCFKMOBOMBL, long FABNMHPKJIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D000", Offset = "0x6E4BA00", VA = "0x186E4D000", Slot = "21")]
	public void MNCOHDLCBMG(string PCFKMOBOMBL, long IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2E18940", Offset = "0x2E17340", VA = "0x182E18940", Slot = "22")]
	public T OPPBGLFLHPF<T>(string PCFKMOBOMBL, T FABNMHPKJIP, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E18940", Offset = "0x2E17340", VA = "0x182E18940", Slot = "23")]
	public void EKLOHDBEHJK<T>(string PCFKMOBOMBL, T IPHMAHBENGI, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BD40", Offset = "0x6E4A740", VA = "0x186E4BD40", Slot = "16")]
	public string DIDEJAGADEK(string COMNIKKFEEB, string FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CE20", Offset = "0x6E4B820", VA = "0x186E4CE20", Slot = "17")]
	public void KEPHGLBKCFP(string COMNIKKFEEB, string IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D070", Offset = "0x6E4BA70", VA = "0x186E4D070", Slot = "24")]
	public void NNFNAPOJKIJ(string COMNIKKFEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CF70", Offset = "0x6E4B970", VA = "0x186E4CF70", Slot = "9")]
	public bool MGCFLBOLAML(string COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CAF0", Offset = "0x6E4B4F0", VA = "0x186E4CAF0", Slot = "25")]
	public Task KADEGNINIOH(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B8B0", Offset = "0x6E4A2B0", VA = "0x186E4B8B0")]
	private void CDMGNPFBGGJ(DirectoryInfo CEHBCIMOILE, string GGIGGMINDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BE60", Offset = "0x6E4A860", VA = "0x186E4BE60")]
	private static string EPNNOGHHOBK(string COMNIKKFEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C060", Offset = "0x6E4AA60", VA = "0x186E4C060")]
	private static string FCNBLDOPONC(byte[] MGCOGNAKONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2E73810", Offset = "0x2E72210", VA = "0x182E73810")]
	private T GJMIFHLLDMF<T>(string PCFKMOBOMBL, T FABNMHPKJIP, [Optional] DPPPIBINEGF<T> JEHGHMHDOEI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2E74B00", Offset = "0x2E73500", VA = "0x182E74B00")]
	private void ODIPBPJKHHK<T>(string PCFKMOBOMBL, T IPHMAHBENGI, [Optional] DPPPIBINEGF<T> JEHGHMHDOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C210", Offset = "0x6E4AC10", VA = "0x186E4C210")]
	private Dictionary<string, string> GKKHGBPEIPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class DCHFGBCJIND
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E47F30", Offset = "0x6E46930", VA = "0x186E47F30")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void NBLEEGPPBCG(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NEDPOOKLLFL : GNKDDBAOGBF
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E496E0", Offset = "0x6E480E0", VA = "0x186E496E0")]
	[UnityEngine.Scripting.Preserve]
	public NEDPOOKLLFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GNKDDBAOGBF : POKPAFIAAMA, NFGPPKOAKKH, IGNBCCEAHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> IECCFMFIDLP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PLPIBKBACML
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "8")]
	public void NNJCLADGAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E49140", Offset = "0x6E47B40", VA = "0x186E49140", Slot = "6")]
	public Task DFMKMHBLCKG(long LFGKLELCCBE, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E49560", Offset = "0x6E47F60", VA = "0x186E49560", Slot = "9")]
	public bool MGCFLBOLAML(string PCFKMOBOMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E49290", Offset = "0x6E47C90", VA = "0x186E49290", Slot = "10")]
	public int GGDBFJNBLOK(string PCFKMOBOMBL, int FABNMHPKJIP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E49680", Offset = "0x6E48080", VA = "0x186E49680", Slot = "11")]
	public void OMIMMMAMDPJ(string PCFKMOBOMBL, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E49080", Offset = "0x6E47A80", VA = "0x186E49080", Slot = "12")]
	public bool BGOJILMPPEB(string PCFKMOBOMBL, bool FABNMHPKJIP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E49350", Offset = "0x6E47D50", VA = "0x186E49350", Slot = "13")]
	public void JFEBCMDJKFD(string PCFKMOBOMBL, bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E492F0", Offset = "0x6E47CF0", VA = "0x186E492F0", Slot = "14")]
	public float HHCMKODEPKN(string PCFKMOBOMBL, float FABNMHPKJIP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E49500", Offset = "0x6E47F00", VA = "0x186E49500", Slot = "15")]
	public void LADDBAFAEFG(string PCFKMOBOMBL, float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E491D0", Offset = "0x6E47BD0", VA = "0x186E491D0", Slot = "16")]
	public string DIDEJAGADEK(string PCFKMOBOMBL, [Optional] string FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E49440", Offset = "0x6E47E40", VA = "0x186E49440", Slot = "17")]
	public void KEPHGLBKCFP(string PCFKMOBOMBL, string IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E494A0", Offset = "0x6E47EA0", VA = "0x186E494A0", Slot = "18")]
	public DateTime LABCKPGOLDM(string PCFKMOBOMBL, [Optional] DateTime FABNMHPKJIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E49230", Offset = "0x6E47C30", VA = "0x186E49230", Slot = "19")]
	public void EEFBFLNCAAA(string PCFKMOBOMBL, DateTime IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E490E0", Offset = "0x6E47AE0", VA = "0x186E490E0", Slot = "20")]
	public long DEIDOJLHEHH(string PCFKMOBOMBL, long FABNMHPKJIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E495C0", Offset = "0x6E47FC0", VA = "0x186E495C0", Slot = "21")]
	public void MNCOHDLCBMG(string PCFKMOBOMBL, long IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D71B50", Offset = "0x2D70550", VA = "0x182D71B50", Slot = "22")]
	public T OPPBGLFLHPF<T>(string PCFKMOBOMBL, T FABNMHPKJIP, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D70D40", Offset = "0x2D6F740", VA = "0x182D70D40", Slot = "23")]
	public void EKLOHDBEHJK<T>(string PCFKMOBOMBL, T IPHMAHBENGI, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D70E20", Offset = "0x2D6F820", VA = "0x182D70E20")]
	public T GJMIFHLLDMF<T>(string PCFKMOBOMBL, T FABNMHPKJIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D71660", Offset = "0x2D70060", VA = "0x182D71660")]
	public void ODIPBPJKHHK<T>(string PCFKMOBOMBL, T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E49620", Offset = "0x6E48020", VA = "0x186E49620", Slot = "24")]
	public void NNFNAPOJKIJ(string PCFKMOBOMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E493B0", Offset = "0x6E47DB0", VA = "0x186E493B0", Slot = "25")]
	public Task KADEGNINIOH(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E496E0", Offset = "0x6E480E0", VA = "0x186E496E0")]
	public GNKDDBAOGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class NHAFMLMHNDE<TParent> where TParent : NFGPPKOAKKH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<NHAFMLMHNDE<TParent>> KDNABNKDPBI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x47EABE0", Offset = "0x47E95E0", VA = "0x1847EABE0")]
	protected NHAFMLMHNDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void ODPBLJHKGDP();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void LKPLJBMDOCB(string COMNIKKFEEB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x47EA870", Offset = "0x47E9270", VA = "0x1847EA870")]
	public static void CBFBHFCHAIN(string COMNIKKFEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x47EA640", Offset = "0x47E9040", VA = "0x1847EA640")]
	public static void AAKEBBALGBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BJAFJFKOAOI<TParent, TValue> : NHAFMLMHNDE<TParent> where TParent : NFGPPKOAKKH
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly BJAFJFKOAOI<TParent, TValue> ANDDCLMCCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> EKGCBLEFLAM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x50EC2E0", Offset = "0x50EACE0", VA = "0x1850EC2E0")]
	public bool FJHIBPMOMDE(string LOHNBJHDMGO, [Out] TValue ICDGAKENEDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x50EC390", Offset = "0x50EAD90", VA = "0x1850EC390")]
	public void IEGPOPCLCBM(string LOHNBJHDMGO, TValue IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x40D9AE0", Offset = "0x40D84E0", VA = "0x1840D9AE0", Slot = "4")]
	protected override void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x406FF50", Offset = "0x406E950", VA = "0x18406FF50", Slot = "5")]
	protected override void LKPLJBMDOCB(string LOHNBJHDMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x50EC5D0", Offset = "0x50EAFD0", VA = "0x1850EC5D0")]
	public BJAFJFKOAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NFGPPKOAKKH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNJCLADGAFK();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MGCFLBOLAML(string PCFKMOBOMBL);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GGDBFJNBLOK(string PCFKMOBOMBL, int FABNMHPKJIP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMIMMMAMDPJ(string PCFKMOBOMBL, int IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BGOJILMPPEB(string PCFKMOBOMBL, bool FABNMHPKJIP = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JFEBCMDJKFD(string PCFKMOBOMBL, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float HHCMKODEPKN(string PCFKMOBOMBL, float FABNMHPKJIP = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LADDBAFAEFG(string PCFKMOBOMBL, float IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string DIDEJAGADEK(string PCFKMOBOMBL, [Optional] string FABNMHPKJIP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KEPHGLBKCFP(string PCFKMOBOMBL, string IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime LABCKPGOLDM(string PCFKMOBOMBL, [Optional] DateTime ADEKKIIFFAK);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EEFBFLNCAAA(string PCFKMOBOMBL, DateTime ADEKKIIFFAK);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long DEIDOJLHEHH(string PCFKMOBOMBL, long FABNMHPKJIP);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MNCOHDLCBMG(string PCFKMOBOMBL, long IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T OPPBGLFLHPF<T>(string PCFKMOBOMBL, T FABNMHPKJIP, DPPPIBINEGF<T> DAOHJLBNEHL);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EKLOHDBEHJK<T>(string PCFKMOBOMBL, T IPHMAHBENGI, DPPPIBINEGF<T> DAOHJLBNEHL);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NNFNAPOJKIJ(string PCFKMOBOMBL);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task KADEGNINIOH([Optional] CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface POKPAFIAAMA : NFGPPKOAKKH
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PLPIBKBACML;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DFMKMHBLCKG(long LFGKLELCCBE, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IGNBCCEAHOA : NFGPPKOAKKH
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BGCFFDKDIGM : POKPAFIAAMA, NFGPPKOAKKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HNIMBIBOINL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public BGCFFDKDIGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6E49940", Offset = "0x6E48340", VA = "0x186E49940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E49AD0", Offset = "0x6E484D0", VA = "0x186E49AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MIEKPIDFEID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public BGCFFDKDIGM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6E4B3A0", Offset = "0x6E49DA0", VA = "0x186E4B3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E4B690", Offset = "0x6E4A090", VA = "0x186E4B690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly POKPAFIAAMA MHADEOHKIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly MJKKMOJANMK JMGKLLDEOPC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6E47A10", Offset = "0x6E46410", VA = "0x186E47A10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action PLPIBKBACML
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E46C00", Offset = "0x6E45600", VA = "0x186E46C00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E47230", Offset = "0x6E45C30", VA = "0x186E47230", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E47AE0", Offset = "0x6E464E0", VA = "0x186E47AE0")]
	[UnityEngine.Scripting.Preserve]
	public BGCFFDKDIGM([LKKACOOMNBP(null)] IOBBFHCKJHF AKBECICBOGF, [LKKACOOMNBP("Disk_Unity")] POKPAFIAAMA MHADEOHKIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E479B0", Offset = "0x6E463B0", VA = "0x186E479B0", Slot = "8")]
	public void NNJCLADGAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E477A0", Offset = "0x6E461A0", VA = "0x186E477A0", Slot = "9")]
	public bool MGCFLBOLAML(string PCFKMOBOMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E470E0", Offset = "0x6E45AE0", VA = "0x186E470E0", Slot = "10")]
	public int GGDBFJNBLOK(string PCFKMOBOMBL, int FABNMHPKJIP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E47A70", Offset = "0x6E46470", VA = "0x186E47A70", Slot = "11")]
	public void OMIMMMAMDPJ(string PCFKMOBOMBL, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E46A70", Offset = "0x6E45470", VA = "0x186E46A70", Slot = "12")]
	public bool BGOJILMPPEB(string PCFKMOBOMBL, bool FABNMHPKJIP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E47400", Offset = "0x6E45E00", VA = "0x186E47400", Slot = "13")]
	public void JFEBCMDJKFD(string PCFKMOBOMBL, bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E472A0", Offset = "0x6E45CA0", VA = "0x186E472A0", Slot = "14")]
	public float HHCMKODEPKN(string PCFKMOBOMBL, float FABNMHPKJIP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E47730", Offset = "0x6E46130", VA = "0x186E47730", Slot = "15")]
	public void LADDBAFAEFG(string PCFKMOBOMBL, float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E46ED0", Offset = "0x6E458D0", VA = "0x186E46ED0", Slot = "16")]
	public string DIDEJAGADEK(string PCFKMOBOMBL, [Optional] string FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E47560", Offset = "0x6E45F60", VA = "0x186E47560", Slot = "17")]
	public void KEPHGLBKCFP(string PCFKMOBOMBL, string IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E475D0", Offset = "0x6E45FD0", VA = "0x186E475D0", Slot = "18")]
	public DateTime LABCKPGOLDM(string PCFKMOBOMBL, [Optional] DateTime FABNMHPKJIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E47070", Offset = "0x6E45A70", VA = "0x186E47070", Slot = "19")]
	public void EEFBFLNCAAA(string PCFKMOBOMBL, DateTime ADEKKIIFFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E46C60", Offset = "0x6E45660", VA = "0x186E46C60", Slot = "20")]
	public long DEIDOJLHEHH(string PCFKMOBOMBL, long FABNMHPKJIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E47830", Offset = "0x6E46230", VA = "0x186E47830", Slot = "21")]
	public void MNCOHDLCBMG(string PCFKMOBOMBL, long IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE7F0", Offset = "0x2AED1F0", VA = "0x182AEE7F0", Slot = "22")]
	public T OPPBGLFLHPF<T>(string PCFKMOBOMBL, T FABNMHPKJIP, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE6B0", Offset = "0x2AED0B0", VA = "0x182AEE6B0", Slot = "23")]
	public void EKLOHDBEHJK<T>(string PCFKMOBOMBL, T IPHMAHBENGI, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E478A0", Offset = "0x6E462A0", VA = "0x186E478A0", Slot = "24")]
	public void NNFNAPOJKIJ(string PCFKMOBOMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E47470", Offset = "0x6E45E70", VA = "0x186E47470", Slot = "25")]
	[AsyncStateMachine(typeof(HNIMBIBOINL))]
	public Task KADEGNINIOH([Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E46DC0", Offset = "0x6E457C0", VA = "0x186E46DC0", Slot = "6")]
	[AsyncStateMachine(typeof(MIEKPIDFEID))]
	public Task DFMKMHBLCKG(long LFGKLELCCBE, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BABMFPGFFCM : POKPAFIAAMA, NFGPPKOAKKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DMNDACJFABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public BABMFPGFFCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E48090", Offset = "0x6E46A90", VA = "0x186E48090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E48460", Offset = "0x6E46E60", VA = "0x186E48460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class AGGFMJMPHPB : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BABMFPGFFCM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public AGGFMJMPHPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E460B0", Offset = "0x6E44AB0", VA = "0x186E460B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E46120", Offset = "0x6E44B20", VA = "0x186E46120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IOBBFHCKJHF AKBECICBOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool PNJJNBBJFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool FJNFFDABCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PNEIPMIIOFI FFMJCGBLNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CHBCKIOGPHP IENCLPFOHBJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action PLPIBKBACML
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6E46980", Offset = "0x6E45380", VA = "0x186E46980")]
	[UnityEngine.Scripting.Preserve]
	public BABMFPGFFCM([LKKACOOMNBP(null)] IOBBFHCKJHF AKBECICBOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "8")]
	public void NNJCLADGAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E46320", Offset = "0x6E44D20", VA = "0x186E46320", Slot = "6")]
	public Task DFMKMHBLCKG(long LFGKLELCCBE, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1447100", Offset = "0x1445B00", VA = "0x181447100")]
	private static int DHMFCBLACDM(bool IPHMAHBENGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E46830", Offset = "0x6E45230", VA = "0x186E46830", Slot = "9")]
	public bool MGCFLBOLAML(string PCFKMOBOMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6E464D0", Offset = "0x6E44ED0", VA = "0x186E464D0", Slot = "10")]
	public int GGDBFJNBLOK(string PCFKMOBOMBL, int FABNMHPKJIP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6E46950", Offset = "0x6E45350", VA = "0x186E46950", Slot = "11")]
	public void OMIMMMAMDPJ(string PCFKMOBOMBL, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6E46210", Offset = "0x6E44C10", VA = "0x186E46210", Slot = "12")]
	public bool BGOJILMPPEB(string PCFKMOBOMBL, bool FABNMHPKJIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E46600", Offset = "0x6E45000", VA = "0x186E46600", Slot = "13")]
	public void JFEBCMDJKFD(string PCFKMOBOMBL, bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6E46570", Offset = "0x6E44F70", VA = "0x186E46570", Slot = "14")]
	public float HHCMKODEPKN(string PCFKMOBOMBL, float FABNMHPKJIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E467E0", Offset = "0x6E451E0", VA = "0x186E467E0", Slot = "15")]
	public void LADDBAFAEFG(string PCFKMOBOMBL, float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6E46770", Offset = "0x6E45170", VA = "0x186E46770", Slot = "18")]
	public DateTime LABCKPGOLDM(string PCFKMOBOMBL, [Optional] DateTime FABNMHPKJIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6E463E0", Offset = "0x6E44DE0", VA = "0x186E463E0", Slot = "19")]
	public void EEFBFLNCAAA(string PCFKMOBOMBL, DateTime ADEKKIIFFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E462B0", Offset = "0x6E44CB0", VA = "0x186E462B0", Slot = "20")]
	public long DEIDOJLHEHH(string PCFKMOBOMBL, long FABNMHPKJIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6E46850", Offset = "0x6E45250", VA = "0x186E46850", Slot = "21")]
	public void MNCOHDLCBMG(string PCFKMOBOMBL, long IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6290", Offset = "0x2AC4C90", VA = "0x182AC6290", Slot = "22")]
	public T OPPBGLFLHPF<T>(string PCFKMOBOMBL, T FABNMHPKJIP, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6290", Offset = "0x2AC4C90", VA = "0x182AC6290", Slot = "23")]
	public void EKLOHDBEHJK<T>(string PCFKMOBOMBL, T IPHMAHBENGI, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5750", Offset = "0x2AC4150", VA = "0x182AC5750")]
	private T AIFPBPMNGIA<T>(string PCFKMOBOMBL, T FABNMHPKJIP, [Optional] DPPPIBINEGF<T> JEHGHMHDOEI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6420", Offset = "0x2AC4E20", VA = "0x182AC6420")]
	private void LNADEPDJDFH<T>(string PCFKMOBOMBL, T IPHMAHBENGI, [Optional] DPPPIBINEGF<T> JEHGHMHDOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E463B0", Offset = "0x6E44DB0", VA = "0x186E463B0", Slot = "16")]
	public string DIDEJAGADEK(string PCFKMOBOMBL, string FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E46720", Offset = "0x6E45120", VA = "0x186E46720", Slot = "17")]
	public void KEPHGLBKCFP(string PCFKMOBOMBL, string IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E46810", Offset = "0x6E45210", VA = "0x186E46810")]
	private void LGOMKFDCOBM(string PCFKMOBOMBL, string IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E46750", Offset = "0x6E45150", VA = "0x186E46750")]
	private string KGFFJFJMMLG(string PCFKMOBOMBL, string FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6E468C0", Offset = "0x6E452C0", VA = "0x186E468C0", Slot = "24")]
	public void NNFNAPOJKIJ(string PCFKMOBOMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6E46170", Offset = "0x6E44B70", VA = "0x186E46170")]
	private string BFBHGLMLMME(string COMNIKKFEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E46630", Offset = "0x6E45030", VA = "0x186E46630", Slot = "25")]
	[AsyncStateMachine(typeof(DMNDACJFABO))]
	public Task KADEGNINIOH(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E46450", Offset = "0x6E44E50", VA = "0x186E46450")]
	[IteratorStateMachine(typeof(AGGFMJMPHPB))]
	private IEnumerator<DKMFPOPNNKA> FNMFNBOJHJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E465A0", Offset = "0x6E44FA0", VA = "0x186E465A0")]
	private void IDMFFDGLKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E46500", Offset = "0x6E44F00", VA = "0x186E46500")]
	private void GJHCMIOCKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E46240", Offset = "0x6E44C40", VA = "0x186E46240")]
	private void CEHACDKDEDA(bool GGENPFNHFGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LDDIFGPFBJH : POKPAFIAAMA, NFGPPKOAKKH
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
	private Dictionary<string, string> FPPEIGFFOIO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string MIEIIJDFEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E4B1E0", Offset = "0x6E49BE0", VA = "0x186E4B1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> PNDCHFCNLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A7D0", Offset = "0x6E491D0", VA = "0x186E4A7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action PLPIBKBACML
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	[UnityEngine.Scripting.Preserve]
	public LDDIFGPFBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "8")]
	public void NNJCLADGAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A620", Offset = "0x6E49020", VA = "0x186E4A620", Slot = "6")]
	public Task DFMKMHBLCKG(long LFGKLELCCBE, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AB60", Offset = "0x6E49560", VA = "0x186E4AB60", Slot = "14")]
	public float HHCMKODEPKN(string COMNIKKFEEB, float FABNMHPKJIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6E4ABD0", Offset = "0x6E495D0", VA = "0x186E4ABD0", Slot = "13")]
	public void JFEBCMDJKFD(string COMNIKKFEEB, bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A4F0", Offset = "0x6E48EF0", VA = "0x186E4A4F0", Slot = "12")]
	public bool BGOJILMPPEB(string COMNIKKFEEB, bool FABNMHPKJIP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A810", Offset = "0x6E49210", VA = "0x186E4A810", Slot = "10")]
	public int GGDBFJNBLOK(string COMNIKKFEEB, int FABNMHPKJIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AF40", Offset = "0x6E49940", VA = "0x186E4AF40", Slot = "18")]
	public DateTime LABCKPGOLDM(string PCFKMOBOMBL, [Optional] DateTime FABNMHPKJIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A760", Offset = "0x6E49160", VA = "0x186E4A760", Slot = "19")]
	public void EEFBFLNCAAA(string COMNIKKFEEB, DateTime IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AFB0", Offset = "0x6E499B0", VA = "0x186E4AFB0", Slot = "15")]
	public void LADDBAFAEFG(string COMNIKKFEEB, float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B250", Offset = "0x6E49C50", VA = "0x186E4B250", Slot = "11")]
	public void OMIMMMAMDPJ(string COMNIKKFEEB, int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A5B0", Offset = "0x6E48FB0", VA = "0x186E4A5B0", Slot = "20")]
	public long DEIDOJLHEHH(string PCFKMOBOMBL, long FABNMHPKJIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B0B0", Offset = "0x6E49AB0", VA = "0x186E4B0B0", Slot = "21")]
	public void MNCOHDLCBMG(string PCFKMOBOMBL, long IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2E18940", Offset = "0x2E17340", VA = "0x182E18940", Slot = "22")]
	public T OPPBGLFLHPF<T>(string PCFKMOBOMBL, T FABNMHPKJIP, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2E18940", Offset = "0x2E17340", VA = "0x182E18940", Slot = "23")]
	public void EKLOHDBEHJK<T>(string PCFKMOBOMBL, T IPHMAHBENGI, DPPPIBINEGF<T> DAOHJLBNEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A6B0", Offset = "0x6E490B0", VA = "0x186E4A6B0", Slot = "16")]
	public string DIDEJAGADEK(string COMNIKKFEEB, string FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AEA0", Offset = "0x6E498A0", VA = "0x186E4AEA0", Slot = "17")]
	public void KEPHGLBKCFP(string COMNIKKFEEB, string IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B120", Offset = "0x6E49B20", VA = "0x186E4B120", Slot = "24")]
	public void NNFNAPOJKIJ(string COMNIKKFEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B020", Offset = "0x6E49A20", VA = "0x186E4B020", Slot = "9")]
	public bool MGCFLBOLAML(string COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AC40", Offset = "0x6E49640", VA = "0x186E4AC40", Slot = "25")]
	public Task KADEGNINIOH(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2E18A40", Offset = "0x2E17440", VA = "0x182E18A40")]
	private T GJMIFHLLDMF<T>(string PCFKMOBOMBL, T FABNMHPKJIP, [Optional] DPPPIBINEGF<T> JEHGHMHDOEI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2E19D30", Offset = "0x2E18730", VA = "0x182E19D30")]
	private void ODIPBPJKHHK<T>(string PCFKMOBOMBL, T IPHMAHBENGI, [Optional] DPPPIBINEGF<T> JEHGHMHDOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A880", Offset = "0x6E49280", VA = "0x186E4A880")]
	private Dictionary<string, string> GKKHGBPEIPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GJAOPJJEKBG
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action PLPIBKBACML;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNJCLADGAFK();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task COIAIBLMECL(long LFGKLELCCBE);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FEBNIBPPFDJ(OCLLPAHIFJJ CJBOEIJKFDJ = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HOKAJODDBON(string PCFKMOBOMBL, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LBANPBDDIDH(string PCFKMOBOMBL, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string DNDKCAIPHNG(string PCFKMOBOMBL, [Optional] string FABNMHPKJIP, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OEIACICMCOD DFIGAFOPPFI(string PCFKMOBOMBL, string IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int MPAJEMJFDPL(string PCFKMOBOMBL, int FABNMHPKJIP = 0, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OEIACICMCOD FEJBLFMDJHG(string PCFKMOBOMBL, int IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HJEFCCAOIDH(string PCFKMOBOMBL, bool FABNMHPKJIP, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OEIACICMCOD CAMJLHPHLLN(string PCFKMOBOMBL, bool IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float LILGDKLFBJP(string PCFKMOBOMBL, float FABNMHPKJIP = 0f, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OEIACICMCOD CCEFBPEFHOB(string PCFKMOBOMBL, float IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime EOFBINEFJHK(string PCFKMOBOMBL, [Optional] DateTime FABNMHPKJIP, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OEIACICMCOD CPLBLGEGPBA(string PCFKMOBOMBL, DateTime IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long CEOKJNMFDJD(string PCFKMOBOMBL, long FABNMHPKJIP = 0L, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	OEIACICMCOD GEKNOIDHCNC(string PCFKMOBOMBL, long IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T BLCDHFEDDLN<T>(string PCFKMOBOMBL, [Optional] T FABNMHPKJIP, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	OEIACICMCOD LOAMIEOMIBO<T>(string PCFKMOBOMBL, T IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool HAHLGEMKMDF(string PCFKMOBOMBL);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool HAONPPGBDON(string PCFKMOBOMBL);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string GDDMDCHJEAO(string PCFKMOBOMBL, [Optional] string FABNMHPKJIP);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OEIACICMCOD IFGDMJEHOFH(string PCFKMOBOMBL, string IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int AFLBCMKHLLD(string PCFKMOBOMBL, int FABNMHPKJIP = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "26")]
	OEIACICMCOD CLALHOLNJNM(string PCFKMOBOMBL, int IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool JELEKOLDEJB(string PCFKMOBOMBL, bool FABNMHPKJIP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	OEIACICMCOD NKHIHMOAFHI(string PCFKMOBOMBL, bool IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float PPMCKEJCGOE(string PCFKMOBOMBL, float FABNMHPKJIP = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	OEIACICMCOD EPFNGLKNJEE(string PCFKMOBOMBL, float IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime PMADHJMBLAH(string PCFKMOBOMBL, [Optional] DateTime FABNMHPKJIP);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	OEIACICMCOD NAJPACLBHPH(string PCFKMOBOMBL, DateTime IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long LIANHLEFDFP(string PCFKMOBOMBL, long FABNMHPKJIP = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	OEIACICMCOD LDGCIFBIPDM(string PCFKMOBOMBL, long IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void KDELKNJOAPM<T>(DPPPIBINEGF<T> DAOHJLBNEHL, [Optional] IEqualityComparer<T> JJCIHJBGFLO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FDOFMFOMOJK<T>();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable AABOILOMCJJ();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void OAKGPGBDKGL(float PEDHHHMMIGP);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task IDMFFDGLKJD([Optional] CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum OEIACICMCOD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ODPFHGOGNCO : GJAOPJJEKBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class HEGLGLGIAGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected static readonly HashSet<HEGLGLGIAGN> NHKOCMGDPBO;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6E49770", Offset = "0x6E48170", VA = "0x186E49770")]
		public static void AAKEBBALGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ODPBLJHKGDP();

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		protected HEGLGLGIAGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class AGDPFIJINHK<T> : HEGLGLGIAGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly AGDPFIJINHK<T> GHBFIIGNNDE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DPPPIBINEGF<T> HHIBNFDAAIK
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> EFEGIEMHLOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool BKLMLHBOBAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x39F8440", Offset = "0x39F6E40", VA = "0x1839F8440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3E96C00", Offset = "0x3E95600", VA = "0x183E96C00")]
		private AGDPFIJINHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3E96660", Offset = "0x3E95060", VA = "0x183E96660")]
		public void FBIMIMMHNIB(DPPPIBINEGF<T> JEHGHMHDOEI, [Optional] IEqualityComparer<T> JJCIHJBGFLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3E969C0", Offset = "0x3E953C0", VA = "0x183E969C0", Slot = "4")]
		public override void ODPBLJHKGDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class EJMNKCIBCAN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly ODPFHGOGNCO EFKOFPPBLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly object GIKLDGGGMMH;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6E48E40", Offset = "0x6E47840", VA = "0x186E48E40")]
		public EJMNKCIBCAN(ODPFHGOGNCO EFKOFPPBLBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6E48E10", Offset = "0x6E47810", VA = "0x186E48E10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct BOEABLIFLPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ODPFHGOGNCO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6E47BF0", Offset = "0x6E465F0", VA = "0x186E47BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6E47ED0", Offset = "0x6E468D0", VA = "0x186E47ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct GGEOHGHJEBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public ODPFHGOGNCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NFGPPKOAKKH backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6E48EF0", Offset = "0x6E478F0", VA = "0x186E48EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct IJHAELDNDAD : IAsyncStateMachine
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
		public ODPFHGOGNCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6E49B30", Offset = "0x6E48530", VA = "0x186E49B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A000", Offset = "0x6E48A00", VA = "0x186E4A000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LHBBIOLEDEA : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public ODPFHGOGNCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public LHBBIOLEDEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6E4B2C0", Offset = "0x6E49CC0", VA = "0x186E4B2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6E4B350", Offset = "0x6E49D50", VA = "0x186E4B350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly POKPAFIAAMA GNLCMICNKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly POKPAFIAAMA EDPODIKBCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly IGNBCCEAHOA KKBHEMLBHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly PNEIPMIIOFI FFMJCGBLNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DNGJGNFNIAL.DOPAPKBKMNB BHJCFKNOFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly INDEDCJDEPL IFEABGLDOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HashSet<NFGPPKOAKKH> BMPCGGMLAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Task AECJJDKHLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<string, string> GADCOGIECCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private CHBCKIOGPHP DKIPPCJILON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly object CDEAPFDCMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly object IOACDNKBAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private long MMFCCNBBNFE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool BNCKCPJPCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EC60", Offset = "0x6E4D660", VA = "0x186E4EC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource LHAHFANDDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x88B2B0", Offset = "0x889CB0", VA = "0x18088B2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x88B2A0", Offset = "0x889CA0", VA = "0x18088B2A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action PLPIBKBACML
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E4DB30", Offset = "0x6E4C530", VA = "0x186E4DB30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6E4ECF0", Offset = "0x6E4D6F0", VA = "0x186E4ECF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D610", Offset = "0x6E4C010", VA = "0x186E4D610")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void BIJCGGGFNIO(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FFA0", Offset = "0x6E4E9A0", VA = "0x186E4FFA0")]
	[UnityEngine.Scripting.Preserve]
	public ODPFHGOGNCO([LKKACOOMNBP("Disk")] POKPAFIAAMA GNLCMICNKKM, [LKKACOOMNBP("Cloud")] POKPAFIAAMA EDPODIKBCBI, [LKKACOOMNBP(null)] IGNBCCEAHOA KKBHEMLBHNF, [LKKACOOMNBP(null)] PNEIPMIIOFI FFMJCGBLNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E3E0", Offset = "0x6E4CDE0", VA = "0x186E4E3E0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F0F0", Offset = "0x6E4DAF0", VA = "0x186E4F0F0")]
	private void JOJJAJELKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FA10", Offset = "0x6E4E410", VA = "0x186E4FA10", Slot = "6")]
	public void NNJCLADGAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DD10", Offset = "0x6E4C710", VA = "0x186E4DD10", Slot = "7")]
	public Task COIAIBLMECL(long LFGKLELCCBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FA90", Offset = "0x6E4E490", VA = "0x186E4FA90")]
	[AsyncStateMachine(typeof(BOEABLIFLPO))]
	private Task OBDBLBDBFOO(long LFGKLELCCBE, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E9E0", Offset = "0x6E4D3E0", VA = "0x186E4E9E0")]
	private void FPOHDBJNMJN(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EBE0", Offset = "0x6E4D5E0", VA = "0x186E4EBE0")]
	private void GFPNBPGPAIO(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E810", Offset = "0x6E4D210", VA = "0x186E4E810")]
	private string FIDAFJJEGIC(string ALBGPAMKDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FD20", Offset = "0x6E4E720", VA = "0x186E4FD20")]
	private void PICFNAENAMJ(OCLLPAHIFJJ CJBOEIJKFDJ, string COMNIKKFEEB, [Out] POKPAFIAAMA NPBOJOHIEHM, [Out] string AABCDDJDNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F000", Offset = "0x6E4DA00", VA = "0x186E4F000")]
	private POKPAFIAAMA IPIIMCIEEOG(OCLLPAHIFJJ CJBOEIJKFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E550", Offset = "0x6E4CF50", VA = "0x186E4E550", Slot = "8")]
	public bool FEBNIBPPFDJ(OCLLPAHIFJJ CJBOEIJKFDJ = OCLLPAHIFJJ.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EE40", Offset = "0x6E4D840", VA = "0x186E4EE40", Slot = "9")]
	public bool HOKAJODDBON(string PCFKMOBOMBL, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F680", Offset = "0x6E4E080", VA = "0x186E4F680", Slot = "10")]
	public bool LBANPBDDIDH(string PCFKMOBOMBL, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E340", Offset = "0x6E4CD40", VA = "0x186E4E340", Slot = "11")]
	public string DNDKCAIPHNG(string PCFKMOBOMBL, [Optional] string FABNMHPKJIP, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E080", Offset = "0x6E4CA80", VA = "0x186E4E080", Slot = "12")]
	public OEIACICMCOD DFIGAFOPPFI(string PCFKMOBOMBL, string IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F900", Offset = "0x6E4E300", VA = "0x186E4F900", Slot = "13")]
	public int MPAJEMJFDPL(string PCFKMOBOMBL, int FABNMHPKJIP = 0, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E610", Offset = "0x6E4D010", VA = "0x186E4E610", Slot = "14")]
	public OEIACICMCOD FEJBLFMDJHG(string PCFKMOBOMBL, int IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4ED90", Offset = "0x6E4D790", VA = "0x186E4ED90", Slot = "15")]
	public bool HJEFCCAOIDH(string PCFKMOBOMBL, bool FABNMHPKJIP, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D770", Offset = "0x6E4C170", VA = "0x186E4D770", Slot = "16")]
	public OEIACICMCOD CAMJLHPHLLN(string PCFKMOBOMBL, bool IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F850", Offset = "0x6E4E250", VA = "0x186E4F850", Slot = "17")]
	public float LILGDKLFBJP(string PCFKMOBOMBL, float FABNMHPKJIP = 0f, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D8E0", Offset = "0x6E4C2E0", VA = "0x186E4D8E0", Slot = "18")]
	public OEIACICMCOD CCEFBPEFHOB(string PCFKMOBOMBL, float IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E480", Offset = "0x6E4CE80", VA = "0x186E4E480", Slot = "19")]
	public DateTime EOFBINEFJHK(string PCFKMOBOMBL, [Optional] DateTime FABNMHPKJIP, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DEE0", Offset = "0x6E4C8E0", VA = "0x186E4DEE0", Slot = "20")]
	public OEIACICMCOD CPLBLGEGPBA(string PCFKMOBOMBL, DateTime IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DA60", Offset = "0x6E4C460", VA = "0x186E4DA60", Slot = "21")]
	public long CEOKJNMFDJD(string PCFKMOBOMBL, long FABNMHPKJIP = 0L, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EA70", Offset = "0x6E4D470", VA = "0x186E4EA70", Slot = "22")]
	public OEIACICMCOD GEKNOIDHCNC(string PCFKMOBOMBL, long IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2EFE560", Offset = "0x2EFCF60", VA = "0x182EFE560", Slot = "23")]
	public T BLCDHFEDDLN<T>(string PCFKMOBOMBL, [Optional] T FABNMHPKJIP, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2EFE560", Offset = "0x2EFCF60", VA = "0x182EFE560", Slot = "24")]
	public OEIACICMCOD LOAMIEOMIBO<T>(string PCFKMOBOMBL, T IPHMAHBENGI, OCLLPAHIFJJ ACAPDBNLJPM = OCLLPAHIFJJ.CLOUD)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EC80", Offset = "0x6E4D680", VA = "0x186E4EC80", Slot = "25")]
	public bool HAHLGEMKMDF(string PCFKMOBOMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E4ECE0", Offset = "0x6E4D6E0", VA = "0x186E4ECE0", Slot = "26")]
	public bool HAONPPGBDON(string PCFKMOBOMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EA00", Offset = "0x6E4D400", VA = "0x186E4EA00", Slot = "27")]
	public string GDDMDCHJEAO(string PCFKMOBOMBL, [Optional] string FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EFD0", Offset = "0x6E4D9D0", VA = "0x186E4EFD0", Slot = "28")]
	public OEIACICMCOD IFGDMJEHOFH(string PCFKMOBOMBL, string IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D5A0", Offset = "0x6E4BFA0", VA = "0x186E4D5A0", Slot = "29")]
	public int AFLBCMKHLLD(string PCFKMOBOMBL, int FABNMHPKJIP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DB00", Offset = "0x6E4C500", VA = "0x186E4DB00", Slot = "30")]
	public OEIACICMCOD CLALHOLNJNM(string PCFKMOBOMBL, int IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F080", Offset = "0x6E4DA80", VA = "0x186E4F080", Slot = "31")]
	public bool JELEKOLDEJB(string PCFKMOBOMBL, bool FABNMHPKJIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F9E0", Offset = "0x6E4E3E0", VA = "0x186E4F9E0", Slot = "32")]
	public OEIACICMCOD NKHIHMOAFHI(string PCFKMOBOMBL, bool IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FF30", Offset = "0x6E4E930", VA = "0x186E4FF30", Slot = "33")]
	public float PPMCKEJCGOE(string PCFKMOBOMBL, float FABNMHPKJIP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E520", Offset = "0x6E4CF20", VA = "0x186E4E520", Slot = "34")]
	public OEIACICMCOD EPFNGLKNJEE(string PCFKMOBOMBL, float IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FEC0", Offset = "0x6E4E8C0", VA = "0x186E4FEC0", Slot = "35")]
	public DateTime PMADHJMBLAH(string PCFKMOBOMBL, [Optional] DateTime FABNMHPKJIP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F9B0", Offset = "0x6E4E3B0", VA = "0x186E4F9B0", Slot = "36")]
	public OEIACICMCOD NAJPACLBHPH(string PCFKMOBOMBL, DateTime IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F7E0", Offset = "0x6E4E1E0", VA = "0x186E4F7E0", Slot = "37")]
	public long LIANHLEFDFP(string PCFKMOBOMBL, long FABNMHPKJIP = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F7B0", Offset = "0x6E4E1B0", VA = "0x186E4F7B0", Slot = "38")]
	public OEIACICMCOD LDGCIFBIPDM(string PCFKMOBOMBL, long IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E420", Offset = "0x6E4CE20", VA = "0x186E4E420")]
	private bool EGPALDJPGDB(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D680", Offset = "0x6E4C080", VA = "0x186E4D680")]
	private bool CAEEGCNDBBN(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F530", Offset = "0x6E4DF30", VA = "0x186E4F530")]
	private OEIACICMCOD KOILIJIABLB(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, string IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F210", Offset = "0x6E4DC10", VA = "0x186E4F210")]
	private OEIACICMCOD KEHOPIJFMFE(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, int IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DBD0", Offset = "0x6E4C5D0", VA = "0x186E4DBD0")]
	private OEIACICMCOD CNLMDOKDJCP(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, bool IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FBD0", Offset = "0x6E4E5D0", VA = "0x186E4FBD0")]
	private OEIACICMCOD OHNAMHMPGLL(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, float IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E870", Offset = "0x6E4D270", VA = "0x186E4E870")]
	private OEIACICMCOD FJHHKBMPPOA(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, DateTime IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E200", Offset = "0x6E4CC00", VA = "0x186E4E200")]
	private OEIACICMCOD DICPJJPEKJJ(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, long IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF3E0", Offset = "0x2EFDDE0", VA = "0x182EFF3E0")]
	private T IAACLIECAPM<T>(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, T FABNMHPKJIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2EFE780", Offset = "0x2EFD180", VA = "0x182EFE780")]
	private OEIACICMCOD EBCFLCKOOCP<T>(NFGPPKOAKKH NPBOJOHIEHM, string PCFKMOBOMBL, T IPHMAHBENGI)
	{
		return default(OEIACICMCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF940", Offset = "0x2EFE340", VA = "0x182EFF940", Slot = "39")]
	public void KDELKNJOAPM<T>(DPPPIBINEGF<T> DAOHJLBNEHL, [Optional] IEqualityComparer<T> JJCIHJBGFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF360", Offset = "0x2EFDD60", VA = "0x182EFF360", Slot = "40")]
	public void FDOFMFOMOJK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F140", Offset = "0x6E4DB40", VA = "0x186E4F140")]
	[AsyncStateMachine(typeof(GGEOHGHJEBB))]
	private void KADEGNINIOH(NFGPPKOAKKH FGCNAEJKIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EEE0", Offset = "0x6E4D8E0", VA = "0x186E4EEE0", Slot = "43")]
	[AsyncStateMachine(typeof(IJHAELDNDAD))]
	public Task IDMFFDGLKJD([Optional] CancellationToken OEELDHBFFAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F350", Offset = "0x6E4DD50", VA = "0x186E4F350")]
	private void KFHGKPHNAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D240", Offset = "0x6E4BC40", VA = "0x186E4D240", Slot = "41")]
	public IDisposable AABOILOMCJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FA80", Offset = "0x6E4E480", VA = "0x186E4FA80", Slot = "42")]
	public void OAKGPGBDKGL(float PEDHHHMMIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D320", Offset = "0x6E4BD20", VA = "0x186E4D320")]
	private void ABHGMPEHFCF(float EJAPFOCJHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E780", Offset = "0x6E4D180", VA = "0x186E4E780")]
	[IteratorStateMachine(typeof(LHBBIOLEDEA))]
	private IEnumerator<DKMFPOPNNKA> FFDCBEIFPBJ(float PEDHHHMMIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FBA0", Offset = "0x6E4E5A0", VA = "0x186E4FBA0")]
	[CompilerGenerated]
	private void OCMNAIDPJAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JJKKBCHBCPN : HELOAOEFPHK<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static JJKKBCHBCPN GHBFIIGNNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A3D0", Offset = "0x6E48DD0", VA = "0x186E4A3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A2E0", Offset = "0x6E48CE0", VA = "0x186E4A2E0", Slot = "9")]
	public override string BBLOJHGNHMB(bool AHBBCFFJCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A060", Offset = "0x6E48A60", VA = "0x186E4A060", Slot = "10")]
	protected override bool AEHNIJJPPAE(string AHBBCFFJCCJ, [Out] bool IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A4B0", Offset = "0x6E48EB0", VA = "0x186E4A4B0")]
	public JJKKBCHBCPN()
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
