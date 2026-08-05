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
		[Cpp2IlInjected.Address(RVA = "0x7C79DE0", Offset = "0x7C787E0", VA = "0x187C79DE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PNLFOFIOFNO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class ALGDBOCCFII
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void MGENHFFMPPC(JFHODCKKLCG NIJIKENEFEJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C71180", Offset = "0x7C6FB80", VA = "0x187C71180")]
	private static void AFMDCONHAMO(JFHODCKKLCG NIJIKENEFEJ, MGENHFFMPPC JKILPDGNJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C71490", Offset = "0x7C6FE90", VA = "0x187C71490")]
	public static bool EMLDNPGJDKN(this JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, [Optional] MGENHFFMPPC JKILPDGNJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C715F0", Offset = "0x7C6FFF0", VA = "0x187C715F0")]
	public static FFPLIJKDHDF LDDOONIGIMP(this JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, string PPJFMHBDGNA, [Optional] MGENHFFMPPC JKILPDGNJBK)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C719F0", Offset = "0x7C703F0", VA = "0x187C719F0")]
	public static FFPLIJKDHDF PFIFNHMOBNE(this JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, int PPJFMHBDGNA, [Optional] MGENHFFMPPC JKILPDGNJBK)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C71200", Offset = "0x7C6FC00", VA = "0x187C71200")]
	public static FFPLIJKDHDF ANHLBPGNLOM(this JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, bool PPJFMHBDGNA, [Optional] MGENHFFMPPC JKILPDGNJBK)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C71340", Offset = "0x7C6FD40", VA = "0x187C71340")]
	public static FFPLIJKDHDF BIOOFOFMLML(this JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, float PPJFMHBDGNA, [Optional] MGENHFFMPPC JKILPDGNJBK)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C71880", Offset = "0x7C70280", VA = "0x187C71880")]
	public static FFPLIJKDHDF OPHCEKFCHBM(this JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, DateTime PPJFMHBDGNA, [Optional] MGENHFFMPPC JKILPDGNJBK)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C71740", Offset = "0x7C70140", VA = "0x187C71740")]
	public static FFPLIJKDHDF NBCLJMLODLE(this JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, long PPJFMHBDGNA, [Optional] MGENHFFMPPC JKILPDGNJBK)
	{
		return default(FFPLIJKDHDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MJNMMCGDPHG : PLPGNEJKGBC, JFHODCKKLCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HDPJIAPIFKL BGMFJLMAAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> NLNEANBGDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> MKEPOPCCCHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BHLAOEGENBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> MCGBHPEFFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C783F0", Offset = "0x7C76DF0", VA = "0x187C783F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action FNBHPPKBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C78A90", Offset = "0x7C77490", VA = "0x187C78A90")]
	[UnityEngine.Scripting.Preserve]
	public MJNMMCGDPHG([GJJKIKPKKBJ(null)] HDPJIAPIFKL BGMFJLMAAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "8")]
	public void DFMKECCOBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C77C70", Offset = "0x7C76670", VA = "0x187C77C70")]
	private DirectoryInfo FFFOIHGLLEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C78710", Offset = "0x7C77110", VA = "0x187C78710", Slot = "6")]
	public Task NBNPJALLIMK(long KPIHMFKNFNG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C78A20", Offset = "0x7C77420", VA = "0x187C78A20", Slot = "14")]
	public float PNAAKJBNGLB(string NJBPFCDJFGD, float LPJIMLBFHAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C773C0", Offset = "0x7C75DC0", VA = "0x187C773C0", Slot = "13")]
	public void CDJKBAKAPIE(string NJBPFCDJFGD, bool PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C78960", Offset = "0x7C77360", VA = "0x187C78960", Slot = "12")]
	public bool PMMCHGOFMJN(string NJBPFCDJFGD, bool LPJIMLBFHAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C77F70", Offset = "0x7C76970", VA = "0x187C77F70", Slot = "10")]
	public int GOOKALLNIBE(string NJBPFCDJFGD, int LPJIMLBFHAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C78430", Offset = "0x7C76E30", VA = "0x187C78430", Slot = "18")]
	public DateTime IEKEEHCACAK(string JHOCOFAFAFH, [Optional] DateTime LPJIMLBFHAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C77E70", Offset = "0x7C76870", VA = "0x187C77E70", Slot = "19")]
	public void FNFJIJECLCI(string NJBPFCDJFGD, DateTime PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C78310", Offset = "0x7C76D10", VA = "0x187C78310", Slot = "15")]
	public void HKAILOOBDPH(string NJBPFCDJFGD, float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C788F0", Offset = "0x7C772F0", VA = "0x187C788F0", Slot = "11")]
	public void OHFIGGPPBNN(string NJBPFCDJFGD, int PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C786A0", Offset = "0x7C770A0", VA = "0x187C786A0", Slot = "20")]
	public long MBEKGFOBLMF(string JHOCOFAFAFH, long LPJIMLBFHAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C77430", Offset = "0x7C75E30", VA = "0x187C77430", Slot = "21")]
	public void CJBPIKKOHAN(string JHOCOFAFAFH, long PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3728AA0", Offset = "0x37274A0", VA = "0x183728AA0", Slot = "22")]
	public T DBGAGFIAPDK<T>(string JHOCOFAFAFH, T LPJIMLBFHAO, DNOCHDMNPCJ<T> PLDHCHFPPFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3728AA0", Offset = "0x37274A0", VA = "0x183728AA0", Slot = "23")]
	public void AEHAJOEANLL<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, DNOCHDMNPCJ<T> PLDHCHFPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C77310", Offset = "0x7C75D10", VA = "0x187C77310", Slot = "16")]
	public string APGCIBCFEHL(string NJBPFCDJFGD, string LPJIMLBFHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C78380", Offset = "0x7C76D80", VA = "0x187C78380", Slot = "17")]
	public void IAAEKBAAAFE(string NJBPFCDJFGD, string PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C787A0", Offset = "0x7C771A0", VA = "0x187C787A0", Slot = "24")]
	public void OCOOJAAPJGH(string NJBPFCDJFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C77EE0", Offset = "0x7C768E0", VA = "0x187C77EE0", Slot = "9")]
	public bool GJKOJOLMICK(string NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C77FE0", Offset = "0x7C769E0", VA = "0x187C77FE0", Slot = "25")]
	public Task HCDPAGDGILI(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C76F50", Offset = "0x7C75950", VA = "0x187C76F50")]
	private void ALILKNJPGMD(DirectoryInfo OBBDCBOCMEA, string LEEFLGPFANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C784A0", Offset = "0x7C76EA0", VA = "0x187C784A0")]
	private static string LKPAGEJHMHM(string NJBPFCDJFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C77D70", Offset = "0x7C76770", VA = "0x187C77D70")]
	private static string FILGGJMPIHO(byte[] OHAFLBCBHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3750E70", Offset = "0x374F870", VA = "0x183750E70")]
	private T BLCCCENAIKI<T>(string JHOCOFAFAFH, T LPJIMLBFHAO, [Optional] DNOCHDMNPCJ<T> GJEMGEADPAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3752160", Offset = "0x3750B60", VA = "0x183752160")]
	private void PMHEFKOCJCJ<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, [Optional] DNOCHDMNPCJ<T> GJEMGEADPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C774A0", Offset = "0x7C75EA0", VA = "0x187C774A0")]
	private Dictionary<string, string> DKMLECCLACE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class FKMNBMFGOLD
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C72880", Offset = "0x7C71280", VA = "0x187C72880")]
	[EFEOGKEOEKD.IHENNBHNBPA]
	internal static void LMIBOGDHNKD(LKOLOODKMPF MCJDMILNGAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OACMLFAPNIK : DNFODIFFAGB
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C72190", Offset = "0x7C70B90", VA = "0x187C72190")]
	[UnityEngine.Scripting.Preserve]
	public OACMLFAPNIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DNFODIFFAGB : PLPGNEJKGBC, JFHODCKKLCG, KLKONJFDDGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> HLEJBJKBELK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BHLAOEGENBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FNBHPPKBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "8")]
	public void DFMKECCOBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C71F80", Offset = "0x7C70980", VA = "0x187C71F80", Slot = "6")]
	public Task NBNPJALLIMK(long KPIHMFKNFNG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C71CB0", Offset = "0x7C706B0", VA = "0x187C71CB0", Slot = "9")]
	public bool GJKOJOLMICK(string JHOCOFAFAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C71D10", Offset = "0x7C70710", VA = "0x187C71D10", Slot = "10")]
	public int GOOKALLNIBE(string JHOCOFAFAFH, int LPJIMLBFHAO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C72070", Offset = "0x7C70A70", VA = "0x187C72070", Slot = "11")]
	public void OHFIGGPPBNN(string JHOCOFAFAFH, int PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C720D0", Offset = "0x7C70AD0", VA = "0x187C720D0", Slot = "12")]
	public bool PMMCHGOFMJN(string JHOCOFAFAFH, bool LPJIMLBFHAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C71B90", Offset = "0x7C70590", VA = "0x187C71B90", Slot = "13")]
	public void CDJKBAKAPIE(string JHOCOFAFAFH, bool PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C72130", Offset = "0x7C70B30", VA = "0x187C72130", Slot = "14")]
	public float PNAAKJBNGLB(string JHOCOFAFAFH, float LPJIMLBFHAO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C71E00", Offset = "0x7C70800", VA = "0x187C71E00", Slot = "15")]
	public void HKAILOOBDPH(string JHOCOFAFAFH, float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C71B30", Offset = "0x7C70530", VA = "0x187C71B30", Slot = "16")]
	public string APGCIBCFEHL(string JHOCOFAFAFH, [Optional] string LPJIMLBFHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C71E60", Offset = "0x7C70860", VA = "0x187C71E60", Slot = "17")]
	public void IAAEKBAAAFE(string JHOCOFAFAFH, string PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C71EC0", Offset = "0x7C708C0", VA = "0x187C71EC0", Slot = "18")]
	public DateTime IEKEEHCACAK(string JHOCOFAFAFH, [Optional] DateTime LPJIMLBFHAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C71C50", Offset = "0x7C70650", VA = "0x187C71C50", Slot = "19")]
	public void FNFJIJECLCI(string JHOCOFAFAFH, DateTime PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C71F20", Offset = "0x7C70920", VA = "0x187C71F20", Slot = "20")]
	public long MBEKGFOBLMF(string JHOCOFAFAFH, long LPJIMLBFHAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C71BF0", Offset = "0x7C705F0", VA = "0x187C71BF0", Slot = "21")]
	public void CJBPIKKOHAN(string JHOCOFAFAFH, long PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x346C1C0", Offset = "0x346ABC0", VA = "0x18346C1C0", Slot = "22")]
	public T DBGAGFIAPDK<T>(string JHOCOFAFAFH, T LPJIMLBFHAO, DNOCHDMNPCJ<T> PLDHCHFPPFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x346B8A0", Offset = "0x346A2A0", VA = "0x18346B8A0", Slot = "23")]
	public void AEHAJOEANLL<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, DNOCHDMNPCJ<T> PLDHCHFPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x346B980", Offset = "0x346A380", VA = "0x18346B980")]
	public T BLCCCENAIKI<T>(string JHOCOFAFAFH, T LPJIMLBFHAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x346C2E0", Offset = "0x346ACE0", VA = "0x18346C2E0")]
	public void PMHEFKOCJCJ<T>(string JHOCOFAFAFH, T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C72010", Offset = "0x7C70A10", VA = "0x187C72010", Slot = "24")]
	public void OCOOJAAPJGH(string JHOCOFAFAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C71D70", Offset = "0x7C70770", VA = "0x187C71D70", Slot = "25")]
	public Task HCDPAGDGILI(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C72190", Offset = "0x7C70B90", VA = "0x187C72190")]
	public DNFODIFFAGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class MHMDIOIDLHL<TParent> where TParent : JFHODCKKLCG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<MHMDIOIDLHL<TParent>> JBPFFJEFLJD;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x51322E0", Offset = "0x5130CE0", VA = "0x1851322E0")]
	protected MHMDIOIDLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void OPINELCICKH();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void OHGOLENMDNE(string NJBPFCDJFGD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5131F70", Offset = "0x5130970", VA = "0x185131F70")]
	public static void MOJKOOHEHOG(string NJBPFCDJFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5131D40", Offset = "0x5130740", VA = "0x185131D40")]
	public static void HBIENOLMHOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JFLMDBEBFBN<TParent, TValue> : MHMDIOIDLHL<TParent> where TParent : JFHODCKKLCG
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JFLMDBEBFBN<TParent, TValue> JKECEEFIAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> OBOHKLCPIML;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4CC5EB0", Offset = "0x4CC48B0", VA = "0x184CC5EB0")]
	public bool OCHHJJBEIMP(string EBIFOIFHMFN, [Out] TValue FEPDJABPAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4CC5D50", Offset = "0x4CC4750", VA = "0x184CC5D50")]
	public void CBGGNBCGFOJ(string EBIFOIFHMFN, TValue PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3EEA660", Offset = "0x3EE9060", VA = "0x183EEA660", Slot = "4")]
	protected override void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x435B210", Offset = "0x4359C10", VA = "0x18435B210", Slot = "5")]
	protected override void OHGOLENMDNE(string EBIFOIFHMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4CC6040", Offset = "0x4CC4A40", VA = "0x184CC6040")]
	public JFLMDBEBFBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JFHODCKKLCG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BHLAOEGENBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFMKECCOBEN();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GJKOJOLMICK(string JHOCOFAFAFH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GOOKALLNIBE(string JHOCOFAFAFH, int LPJIMLBFHAO = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHFIGGPPBNN(string JHOCOFAFAFH, int PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PMMCHGOFMJN(string JHOCOFAFAFH, bool LPJIMLBFHAO = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CDJKBAKAPIE(string JHOCOFAFAFH, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float PNAAKJBNGLB(string JHOCOFAFAFH, float LPJIMLBFHAO = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HKAILOOBDPH(string JHOCOFAFAFH, float PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string APGCIBCFEHL(string JHOCOFAFAFH, [Optional] string LPJIMLBFHAO);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IAAEKBAAAFE(string JHOCOFAFAFH, string PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime IEKEEHCACAK(string JHOCOFAFAFH, [Optional] DateTime MHOKDDPEPDF);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FNFJIJECLCI(string JHOCOFAFAFH, DateTime MHOKDDPEPDF);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long MBEKGFOBLMF(string JHOCOFAFAFH, long LPJIMLBFHAO);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CJBPIKKOHAN(string JHOCOFAFAFH, long PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T DBGAGFIAPDK<T>(string JHOCOFAFAFH, T LPJIMLBFHAO, DNOCHDMNPCJ<T> PLDHCHFPPFK);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AEHAJOEANLL<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, DNOCHDMNPCJ<T> PLDHCHFPPFK);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OCOOJAAPJGH(string JHOCOFAFAFH);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task HCDPAGDGILI([Optional] CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PLPGNEJKGBC : JFHODCKKLCG
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FNBHPPKBDBF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task NBNPJALLIMK(long KPIHMFKNFNG, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KLKONJFDDGG : JFHODCKKLCG
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LCNCIMPDFGN : PLPGNEJKGBC, JFHODCKKLCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LELCLJMLHAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public LCNCIMPDFGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C765E0", Offset = "0x7C74FE0", VA = "0x187C765E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C769C0", Offset = "0x7C753C0", VA = "0x187C769C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class PJIIFCLEKKD : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public LCNCIMPDFGN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public PJIIFCLEKKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C79C40", Offset = "0x7C78640", VA = "0x187C79C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C79CB0", Offset = "0x7C786B0", VA = "0x187C79CB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HDPJIAPIFKL BGMFJLMAAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MFOPHLNCHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool OMNLICALEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GOHHNGJKPGH OBCJAOHMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NBLJJLKPDOF FCFDFKMHHGJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BHLAOEGENBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FNBHPPKBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C764F0", Offset = "0x7C74EF0", VA = "0x187C764F0")]
	[UnityEngine.Scripting.Preserve]
	public LCNCIMPDFGN([GJJKIKPKKBJ(null)] HDPJIAPIFKL BGMFJLMAAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "8")]
	public void DFMKECCOBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7C76240", Offset = "0x7C74C40", VA = "0x187C76240", Slot = "6")]
	public Task NBNPJALLIMK(long KPIHMFKNFNG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C2C0", Offset = "0x1A0ACC0", VA = "0x181A0C2C0")]
	private static int JMLDKCFEOOM(bool PPJFMHBDGNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C75EB0", Offset = "0x7C748B0", VA = "0x187C75EB0", Slot = "9")]
	public bool GJKOJOLMICK(string JHOCOFAFAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C75ED0", Offset = "0x7C748D0", VA = "0x187C75ED0", Slot = "10")]
	public int GOOKALLNIBE(string JHOCOFAFAFH, int LPJIMLBFHAO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C763C0", Offset = "0x7C74DC0", VA = "0x187C763C0", Slot = "11")]
	public void OHFIGGPPBNN(string JHOCOFAFAFH, int PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C76490", Offset = "0x7C74E90", VA = "0x187C76490", Slot = "12")]
	public bool PMMCHGOFMJN(string JHOCOFAFAFH, bool LPJIMLBFHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C75D80", Offset = "0x7C74780", VA = "0x187C75D80", Slot = "13")]
	public void CDJKBAKAPIE(string JHOCOFAFAFH, bool PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C764C0", Offset = "0x7C74EC0", VA = "0x187C764C0", Slot = "14")]
	public float PNAAKJBNGLB(string JHOCOFAFAFH, float LPJIMLBFHAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C75FF0", Offset = "0x7C749F0", VA = "0x187C75FF0", Slot = "15")]
	public void HKAILOOBDPH(string JHOCOFAFAFH, float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C76050", Offset = "0x7C74A50", VA = "0x187C76050", Slot = "18")]
	public DateTime IEKEEHCACAK(string JHOCOFAFAFH, [Optional] DateTime LPJIMLBFHAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C75E40", Offset = "0x7C74840", VA = "0x187C75E40", Slot = "19")]
	public void FNFJIJECLCI(string JHOCOFAFAFH, DateTime MHOKDDPEPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C761B0", Offset = "0x7C74BB0", VA = "0x187C761B0", Slot = "20")]
	public long MBEKGFOBLMF(string JHOCOFAFAFH, long LPJIMLBFHAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C75DB0", Offset = "0x7C747B0", VA = "0x187C75DB0", Slot = "21")]
	public void CJBPIKKOHAN(string JHOCOFAFAFH, long PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3723F90", Offset = "0x3722990", VA = "0x183723F90", Slot = "22")]
	public T DBGAGFIAPDK<T>(string JHOCOFAFAFH, T LPJIMLBFHAO, DNOCHDMNPCJ<T> PLDHCHFPPFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3723F90", Offset = "0x3722990", VA = "0x183723F90", Slot = "23")]
	public void AEHAJOEANLL<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, DNOCHDMNPCJ<T> PLDHCHFPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3724290", Offset = "0x3722C90", VA = "0x183724290")]
	private T KECKOIOGECE<T>(string JHOCOFAFAFH, T LPJIMLBFHAO, [Optional] DNOCHDMNPCJ<T> GJEMGEADPAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3725040", Offset = "0x3723A40", VA = "0x183725040")]
	private void MHBNECMNHFK<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, [Optional] DNOCHDMNPCJ<T> GJEMGEADPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C75CE0", Offset = "0x7C746E0", VA = "0x187C75CE0", Slot = "16")]
	public string APGCIBCFEHL(string JHOCOFAFAFH, string LPJIMLBFHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C76020", Offset = "0x7C74A20", VA = "0x187C76020", Slot = "17")]
	public void IAAEKBAAAFE(string JHOCOFAFAFH, string PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C76220", Offset = "0x7C74C20", VA = "0x187C76220")]
	private void MCEFACIENPE(string JHOCOFAFAFH, string PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C75E20", Offset = "0x7C74820", VA = "0x187C75E20")]
	private string CNILGEFLBHL(string JHOCOFAFAFH, string LPJIMLBFHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C76330", Offset = "0x7C74D30", VA = "0x187C76330", Slot = "24")]
	public void OCOOJAAPJGH(string JHOCOFAFAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7C763F0", Offset = "0x7C74DF0", VA = "0x187C763F0")]
	private string OJKHHELOFFM(string NJBPFCDJFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7C75F00", Offset = "0x7C74900", VA = "0x187C75F00", Slot = "25")]
	[AsyncStateMachine(typeof(LELCLJMLHAB))]
	public Task HCDPAGDGILI(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C760C0", Offset = "0x7C74AC0", VA = "0x187C760C0")]
	[IteratorStateMachine(typeof(PJIIFCLEKKD))]
	private IEnumerator<HKMFJDMPEMN> JGCGKJKKOKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7C762D0", Offset = "0x7C74CD0", VA = "0x187C762D0")]
	private void NLKKDCHMPNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C75D10", Offset = "0x7C74710", VA = "0x187C75D10")]
	private void BNEJKCJPIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C76140", Offset = "0x7C74B40", VA = "0x187C76140")]
	private void LFFFEEPIFID(bool OPPBACHGCJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NGHKJHJPDMD : PLPGNEJKGBC, JFHODCKKLCG
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
	private Dictionary<string, string> MKEPOPCCCHI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BHLAOEGENBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string NAGCFBPGNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C79630", Offset = "0x7C78030", VA = "0x187C79630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> MCGBHPEFFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C79480", Offset = "0x7C77E80", VA = "0x187C79480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action FNBHPPKBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	[UnityEngine.Scripting.Preserve]
	public NGHKJHJPDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "8")]
	public void DFMKECCOBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7C795A0", Offset = "0x7C77FA0", VA = "0x187C795A0", Slot = "6")]
	public Task NBNPJALLIMK(long KPIHMFKNFNG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C79890", Offset = "0x7C78290", VA = "0x187C79890", Slot = "14")]
	public float PNAAKJBNGLB(string NJBPFCDJFGD, float LPJIMLBFHAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7C78BE0", Offset = "0x7C775E0", VA = "0x187C78BE0", Slot = "13")]
	public void CDJKBAKAPIE(string NJBPFCDJFGD, bool PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C797D0", Offset = "0x7C781D0", VA = "0x187C797D0", Slot = "12")]
	public bool PMMCHGOFMJN(string NJBPFCDJFGD, bool LPJIMLBFHAO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C790A0", Offset = "0x7C77AA0", VA = "0x187C790A0", Slot = "10")]
	public int GOOKALLNIBE(string NJBPFCDJFGD, int LPJIMLBFHAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C794C0", Offset = "0x7C77EC0", VA = "0x187C794C0", Slot = "18")]
	public DateTime IEKEEHCACAK(string JHOCOFAFAFH, [Optional] DateTime LPJIMLBFHAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C78FA0", Offset = "0x7C779A0", VA = "0x187C78FA0", Slot = "19")]
	public void FNFJIJECLCI(string NJBPFCDJFGD, DateTime PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C79370", Offset = "0x7C77D70", VA = "0x187C79370", Slot = "15")]
	public void HKAILOOBDPH(string NJBPFCDJFGD, float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C79760", Offset = "0x7C78160", VA = "0x187C79760", Slot = "11")]
	public void OHFIGGPPBNN(string NJBPFCDJFGD, int PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C79530", Offset = "0x7C77F30", VA = "0x187C79530", Slot = "20")]
	public long MBEKGFOBLMF(string JHOCOFAFAFH, long LPJIMLBFHAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C78C50", Offset = "0x7C77650", VA = "0x187C78C50", Slot = "21")]
	public void CJBPIKKOHAN(string JHOCOFAFAFH, long PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3728AA0", Offset = "0x37274A0", VA = "0x183728AA0", Slot = "22")]
	public T DBGAGFIAPDK<T>(string JHOCOFAFAFH, T LPJIMLBFHAO, DNOCHDMNPCJ<T> PLDHCHFPPFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3728AA0", Offset = "0x37274A0", VA = "0x183728AA0", Slot = "23")]
	public void AEHAJOEANLL<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, DNOCHDMNPCJ<T> PLDHCHFPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C78B30", Offset = "0x7C77530", VA = "0x187C78B30", Slot = "16")]
	public string APGCIBCFEHL(string NJBPFCDJFGD, string LPJIMLBFHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C793E0", Offset = "0x7C77DE0", VA = "0x187C793E0", Slot = "17")]
	public void IAAEKBAAAFE(string NJBPFCDJFGD, string PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C796A0", Offset = "0x7C780A0", VA = "0x187C796A0", Slot = "24")]
	public void OCOOJAAPJGH(string NJBPFCDJFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C79010", Offset = "0x7C77A10", VA = "0x187C79010", Slot = "9")]
	public bool GJKOJOLMICK(string NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C79110", Offset = "0x7C77B10", VA = "0x187C79110", Slot = "25")]
	public Task HCDPAGDGILI(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x37E9B10", Offset = "0x37E8510", VA = "0x1837E9B10")]
	private T BLCCCENAIKI<T>(string JHOCOFAFAFH, T LPJIMLBFHAO, [Optional] DNOCHDMNPCJ<T> GJEMGEADPAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37EAE00", Offset = "0x37E9800", VA = "0x1837EAE00")]
	private void PMHEFKOCJCJ<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, [Optional] DNOCHDMNPCJ<T> GJEMGEADPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C78CC0", Offset = "0x7C776C0", VA = "0x187C78CC0")]
	private Dictionary<string, string> DKMLECCLACE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BEPPBPCKNFL
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action FNBHPPKBDBF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFMKECCOBEN();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NOEKNMNKDBD(long KPIHMFKNFNG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EHDGOJHKFHF(PNLFOFIOFNO JJDKCKKIMHD = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DEFGDIJKDDO(string JHOCOFAFAFH, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FMDIAMOBHIA(string JHOCOFAFAFH, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string MCBDJHBCJPG(string JHOCOFAFAFH, [Optional] string LPJIMLBFHAO, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FFPLIJKDHDF IJKPDMMGJCK(string JHOCOFAFAFH, string PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int KOHIEHDCHID(string JHOCOFAFAFH, int LPJIMLBFHAO = 0, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FFPLIJKDHDF CDLNCBJPBIJ(string JHOCOFAFAFH, int PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NKFHPOGHPOI(string JHOCOFAFAFH, bool LPJIMLBFHAO, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FFPLIJKDHDF BNHHKCKOHLL(string JHOCOFAFAFH, bool PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float ONBCIEBLKDB(string JHOCOFAFAFH, float LPJIMLBFHAO = 0f, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FFPLIJKDHDF CPCFMNDIIPP(string JHOCOFAFAFH, float PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime PGJAPJOEFNE(string JHOCOFAFAFH, [Optional] DateTime LPJIMLBFHAO, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FFPLIJKDHDF LCLFNIFHNNM(string JHOCOFAFAFH, DateTime PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long MKOAACJEBBO(string JHOCOFAFAFH, long LPJIMLBFHAO = 0L, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FFPLIJKDHDF OFLADCPDNLO(string JHOCOFAFAFH, long PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T CKFHJFHNACH<T>(string JHOCOFAFAFH, [Optional] T LPJIMLBFHAO, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FFPLIJKDHDF PDFLICGOBPB<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool LMDJMIMMOKA(string JHOCOFAFAFH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool PCNHAOEGDAH(string JHOCOFAFAFH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string POOGDJEFFDH(string JHOCOFAFAFH, [Optional] string LPJIMLBFHAO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FFPLIJKDHDF AMOPADKPDIF(string JHOCOFAFAFH, string PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int JDEICHNDMGG(string JHOCOFAFAFH, int LPJIMLBFHAO = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	FFPLIJKDHDF CPJONPPAOON(string JHOCOFAFAFH, int PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool GBLHEMOJMCG(string JHOCOFAFAFH, bool LPJIMLBFHAO);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	FFPLIJKDHDF FKKDLIIPAKJ(string JHOCOFAFAFH, bool PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float PFHPLHOMOOG(string JHOCOFAFAFH, float LPJIMLBFHAO = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	FFPLIJKDHDF FDCLLIIIGAP(string JHOCOFAFAFH, float PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime PPJFAOMNHGJ(string JHOCOFAFAFH, [Optional] DateTime LPJIMLBFHAO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	FFPLIJKDHDF OFFDBFELBMC(string JHOCOFAFAFH, DateTime PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long ICOOEMICBGO(string JHOCOFAFAFH, long LPJIMLBFHAO = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	FFPLIJKDHDF EFFJLOIEEEN(string JHOCOFAFAFH, long PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void CGPOPOLJFFO<T>(DNOCHDMNPCJ<T> PLDHCHFPPFK, [Optional] IEqualityComparer<T> KADCJBCBGFI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MDHGMIFNJCG<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable EHMBHMLLNIP();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FPIHKPJLNEI(float KFGHOINKLDG);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task NLKKDCHMPNF([Optional] CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FFPLIJKDHDF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IBOMPGGACKL : BEPPBPCKNFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class FJADJBAKDBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<FJADJBAKDBM> IKEKHCIOGKI;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7C72220", Offset = "0x7C70C20", VA = "0x187C72220")]
		public static void HBIENOLMHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void OPINELCICKH();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		protected FJADJBAKDBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class HEKEOFBLELA<T> : FJADJBAKDBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly HEKEOFBLELA<T> LALLOKGAEJH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DNOCHDMNPCJ<T> FAKBMGMENBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> APDJOELABFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DJIAIGDNHLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4347790", Offset = "0x4346190", VA = "0x184347790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x494A770", Offset = "0x4949170", VA = "0x18494A770")]
		private HEKEOFBLELA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x494A020", Offset = "0x4948A20", VA = "0x18494A020")]
		public void BLLBFFICICF(DNOCHDMNPCJ<T> GJEMGEADPAH, [Optional] IEqualityComparer<T> KADCJBCBGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x494A530", Offset = "0x4948F30", VA = "0x18494A530", Slot = "4")]
		public override void OPINELCICKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class AAEGMCFIFMN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly IBOMPGGACKL ACGEJPCHNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object HCHLLHNAGEH;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7C70F40", Offset = "0x7C6F940", VA = "0x187C70F40")]
		public AAEGMCFIFMN(IBOMPGGACKL ACGEJPCHNKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7C70F10", Offset = "0x7C6F910", VA = "0x187C70F10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct OPIBODGLAAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public IBOMPGGACKL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7C79900", Offset = "0x7C78300", VA = "0x187C79900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7C79BE0", Offset = "0x7C785E0", VA = "0x187C79BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct AAJMGPNCIGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IBOMPGGACKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public JFHODCKKLCG backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C70FF0", Offset = "0x7C6F9F0", VA = "0x187C70FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A10", Offset = "0x9F8410", VA = "0x1809F9A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct MDOACNOGCBM : IAsyncStateMachine
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
		public IBOMPGGACKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7C76A20", Offset = "0x7C75420", VA = "0x187C76A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7C76EF0", Offset = "0x7C758F0", VA = "0x187C76EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HFAGLGMGBLD : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IBOMPGGACKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public HFAGLGMGBLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C729D0", Offset = "0x7C713D0", VA = "0x187C729D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7C72A60", Offset = "0x7C71460", VA = "0x187C72A60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly PLPGNEJKGBC KKLPKMKPNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly PLPGNEJKGBC KKHODAIPGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly KLKONJFDDGG DFFLKDPKKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly GOHHNGJKPGH OBCJAOHMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ALGDBOCCFII.MGENHFFMPPC JKILPDGNJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly OPHEEGEKGGC FFFMMOPJEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<JFHODCKKLCG> ACPGBDANEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task KLHCEJMCHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> PIEBHCMFBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NBLJJLKPDOF FLBKGGPFKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object JBCHPFILJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object AEDPJLHPKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long ABHMLBBMIPH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool BBLKJOOGLFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C74880", Offset = "0x7C73280", VA = "0x187C74880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource GMLCPFJHLNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4F0", Offset = "0x9AAEF0", VA = "0x1809AC4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4D0", Offset = "0x9AAED0", VA = "0x1809AC4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FNBHPPKBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C74AF0", Offset = "0x7C734F0", VA = "0x187C74AF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C72DE0", Offset = "0x7C717E0", VA = "0x187C72DE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C731D0", Offset = "0x7C71BD0", VA = "0x187C731D0")]
	[EFEOGKEOEKD.IHENNBHNBPA]
	internal static void CEMBNDEBLBN(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C75910", Offset = "0x7C74310", VA = "0x187C75910")]
	[UnityEngine.Scripting.Preserve]
	public IBOMPGGACKL([GJJKIKPKKBJ("Disk")] PLPGNEJKGBC KKLPKMKPNIN, [GJJKIKPKKBJ("Cloud")] PLPGNEJKGBC KKHODAIPGHO, [GJJKIKPKKBJ(null)] KLKONJFDDGG DFFLKDPKKPP, [GJJKIKPKKBJ(null)] GOHHNGJKPGH OBCJAOHMKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C73A50", Offset = "0x7C72450", VA = "0x187C73A50", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C72E80", Offset = "0x7C71880", VA = "0x187C72E80")]
	private void BIFGOOHEGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C73850", Offset = "0x7C72250", VA = "0x187C73850", Slot = "6")]
	public void DFMKECCOBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C74ED0", Offset = "0x7C738D0", VA = "0x187C74ED0", Slot = "7")]
	public Task NOEKNMNKDBD(long KPIHMFKNFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C73940", Offset = "0x7C72340", VA = "0x187C73940")]
	[AsyncStateMachine(typeof(OPIBODGLAAE))]
	private Task DLKGGNDIAFA(long KPIHMFKNFNG, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C75490", Offset = "0x7C73E90", VA = "0x187C75490")]
	private void OBMLCMFLGIN(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C73A90", Offset = "0x7C72490", VA = "0x187C73A90")]
	private void EACMBKEJJNN(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C747F0", Offset = "0x7C731F0", VA = "0x187C747F0")]
	private string KBJABEALEJM(string GDCANAGIJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C72C40", Offset = "0x7C71640", VA = "0x187C72C40")]
	private void BEELEECENBN(PNLFOFIOFNO JJDKCKKIMHD, string NJBPFCDJFGD, [Out] PLPGNEJKGBC NIJIKENEFEJ, [Out] string BHNLDEONACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C738C0", Offset = "0x7C722C0", VA = "0x187C738C0")]
	private PLPGNEJKGBC DLGLOEFBEEF(PNLFOFIOFNO JJDKCKKIMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C73B40", Offset = "0x7C72540", VA = "0x187C73B40", Slot = "8")]
	public bool EHDGOJHKFHF(PNLFOFIOFNO JJDKCKKIMHD = PNLFOFIOFNO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C737B0", Offset = "0x7C721B0", VA = "0x187C737B0", Slot = "9")]
	public bool DEFGDIJKDDO(string JHOCOFAFAFH, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C73E90", Offset = "0x7C72890", VA = "0x187C73E90", Slot = "10")]
	public bool FMDIAMOBHIA(string JHOCOFAFAFH, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C74BF0", Offset = "0x7C735F0", VA = "0x187C74BF0", Slot = "11")]
	public string MCBDJHBCJPG(string JHOCOFAFAFH, [Optional] string LPJIMLBFHAO, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C74440", Offset = "0x7C72E40", VA = "0x187C74440", Slot = "12")]
	public FFPLIJKDHDF IJKPDMMGJCK(string JHOCOFAFAFH, string PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C748A0", Offset = "0x7C732A0", VA = "0x187C748A0", Slot = "13")]
	public int KOHIEHDCHID(string JHOCOFAFAFH, int LPJIMLBFHAO = 0, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C73050", Offset = "0x7C71A50", VA = "0x187C73050", Slot = "14")]
	public FFPLIJKDHDF CDLNCBJPBIJ(string JHOCOFAFAFH, int PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C74D30", Offset = "0x7C73730", VA = "0x187C74D30", Slot = "15")]
	public bool NKFHPOGHPOI(string JHOCOFAFAFH, bool LPJIMLBFHAO, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C72ED0", Offset = "0x7C718D0", VA = "0x187C72ED0", Slot = "16")]
	public FFPLIJKDHDF BNHHKCKOHLL(string JHOCOFAFAFH, bool PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C75660", Offset = "0x7C74060", VA = "0x187C75660", Slot = "17")]
	public float ONBCIEBLKDB(string JHOCOFAFAFH, float LPJIMLBFHAO = 0f, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C734C0", Offset = "0x7C71EC0", VA = "0x187C734C0", Slot = "18")]
	public FFPLIJKDHDF CPCFMNDIIPP(string JHOCOFAFAFH, float PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C75790", Offset = "0x7C74190", VA = "0x187C75790", Slot = "19")]
	public DateTime PGJAPJOEFNE(string JHOCOFAFAFH, [Optional] DateTime LPJIMLBFHAO, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C74950", Offset = "0x7C73350", VA = "0x187C74950", Slot = "20")]
	public FFPLIJKDHDF LCLFNIFHNNM(string JHOCOFAFAFH, DateTime PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C74C90", Offset = "0x7C73690", VA = "0x187C74C90", Slot = "21")]
	public long MKOAACJEBBO(string JHOCOFAFAFH, long LPJIMLBFHAO = 0L, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C754E0", Offset = "0x7C73EE0", VA = "0x187C754E0", Slot = "22")]
	public FFPLIJKDHDF OFLADCPDNLO(string JHOCOFAFAFH, long PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x36B1CA0", Offset = "0x36B06A0", VA = "0x1836B1CA0", Slot = "23")]
	public T CKFHJFHNACH<T>(string JHOCOFAFAFH, [Optional] T LPJIMLBFHAO, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x36B1CA0", Offset = "0x36B06A0", VA = "0x1836B1CA0", Slot = "24")]
	public FFPLIJKDHDF PDFLICGOBPB<T>(string JHOCOFAFAFH, T PPJFMHBDGNA, PNLFOFIOFNO NCLAGDJADOC = PNLFOFIOFNO.CLOUD)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C74B90", Offset = "0x7C73590", VA = "0x187C74B90", Slot = "25")]
	public bool LMDJMIMMOKA(string JHOCOFAFAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C75710", Offset = "0x7C74110", VA = "0x187C75710", Slot = "26")]
	public bool PCNHAOEGDAH(string JHOCOFAFAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C75830", Offset = "0x7C74230", VA = "0x187C75830", Slot = "27")]
	public string POOGDJEFFDH(string JHOCOFAFAFH, [Optional] string LPJIMLBFHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7C72C10", Offset = "0x7C71610", VA = "0x187C72C10", Slot = "28")]
	public FFPLIJKDHDF AMOPADKPDIF(string JHOCOFAFAFH, string PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C74720", Offset = "0x7C73120", VA = "0x187C74720", Slot = "29")]
	public int JDEICHNDMGG(string JHOCOFAFAFH, int LPJIMLBFHAO = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7C73640", Offset = "0x7C72040", VA = "0x187C73640", Slot = "30")]
	public FFPLIJKDHDF CPJONPPAOON(string JHOCOFAFAFH, int PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7C74290", Offset = "0x7C72C90", VA = "0x187C74290", Slot = "31")]
	public bool GBLHEMOJMCG(string JHOCOFAFAFH, bool LPJIMLBFHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7C73E60", Offset = "0x7C72860", VA = "0x187C73E60", Slot = "32")]
	public FFPLIJKDHDF FKKDLIIPAKJ(string JHOCOFAFAFH, bool PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C75720", Offset = "0x7C74120", VA = "0x187C75720", Slot = "33")]
	public float PFHPLHOMOOG(string JHOCOFAFAFH, float LPJIMLBFHAO = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7C73E30", Offset = "0x7C72830", VA = "0x187C73E30", Slot = "34")]
	public FFPLIJKDHDF FDCLLIIIGAP(string JHOCOFAFAFH, float PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C758A0", Offset = "0x7C742A0", VA = "0x187C758A0", Slot = "35")]
	public DateTime PPJFAOMNHGJ(string JHOCOFAFAFH, [Optional] DateTime LPJIMLBFHAO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C754B0", Offset = "0x7C73EB0", VA = "0x187C754B0", Slot = "36")]
	public FFPLIJKDHDF OFFDBFELBMC(string JHOCOFAFAFH, DateTime PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C743D0", Offset = "0x7C72DD0", VA = "0x187C743D0", Slot = "37")]
	public long ICOOEMICBGO(string JHOCOFAFAFH, long LPJIMLBFHAO = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C73B10", Offset = "0x7C72510", VA = "0x187C73B10", Slot = "38")]
	public FFPLIJKDHDF EFFJLOIEEEN(string JHOCOFAFAFH, long PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7C74790", Offset = "0x7C73190", VA = "0x187C74790")]
	private bool JFCEEMCDHKP(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7C72AB0", Offset = "0x7C714B0", VA = "0x187C72AB0")]
	private bool ADHAPBDGCAN(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C745D0", Offset = "0x7C72FD0", VA = "0x187C745D0")]
	private FFPLIJKDHDF JBNNHMGNKNF(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, string PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C73670", Offset = "0x7C72070", VA = "0x187C73670")]
	private FFPLIJKDHDF DCPIJJCFEAF(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, int PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C73240", Offset = "0x7C71C40", VA = "0x187C73240")]
	private FFPLIJKDHDF CJKHGFKBJNE(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, bool PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7C73CE0", Offset = "0x7C726E0", VA = "0x187C73CE0")]
	private FFPLIJKDHDF FBJLDECMPNM(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, float PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7C750A0", Offset = "0x7C73AA0", VA = "0x187C750A0")]
	private FFPLIJKDHDF NPGLPABIPOH(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, DateTime PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7C73380", Offset = "0x7C71D80", VA = "0x187C73380")]
	private FFPLIJKDHDF CNIIGJCGOFM(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, long PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x36B1EC0", Offset = "0x36B08C0", VA = "0x1836B1EC0")]
	private T EIGIKBMGICA<T>(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, T LPJIMLBFHAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x36B2420", Offset = "0x36B0E20", VA = "0x1836B2420")]
	private FFPLIJKDHDF HBLBLHPOGOB<T>(JFHODCKKLCG NIJIKENEFEJ, string JHOCOFAFAFH, T PPJFMHBDGNA)
	{
		return default(FFPLIJKDHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x36B1BF0", Offset = "0x36B05F0", VA = "0x1836B1BF0", Slot = "39")]
	public void CGPOPOLJFFO<T>(DNOCHDMNPCJ<T> PLDHCHFPPFK, [Optional] IEqualityComparer<T> KADCJBCBGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x36B3000", Offset = "0x36B1A00", VA = "0x1836B3000", Slot = "40")]
	public void MDHGMIFNJCG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7C74300", Offset = "0x7C72D00", VA = "0x187C74300")]
	[AsyncStateMachine(typeof(AAJMGPNCIGI))]
	private void HCDPAGDGILI(JFHODCKKLCG ACIINAKEHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7C74DE0", Offset = "0x7C737E0", VA = "0x187C74DE0", Slot = "43")]
	[AsyncStateMachine(typeof(MDOACNOGCBM))]
	public Task NLKKDCHMPNF([Optional] CancellationToken GNAAILLDOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7C740B0", Offset = "0x7C72AB0", VA = "0x187C740B0")]
	private void GANOGELEHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7C73C00", Offset = "0x7C72600", VA = "0x187C73C00", Slot = "41")]
	public IDisposable EHMBHMLLNIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7C740A0", Offset = "0x7C72AA0", VA = "0x187C740A0", Slot = "42")]
	public void FPIHKPJLNEI(float KFGHOINKLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7C75210", Offset = "0x7C73C10", VA = "0x187C75210")]
	private void OBGCPGKHGKO(float LLNFKHAJEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7C74010", Offset = "0x7C72A10", VA = "0x187C74010")]
	[IteratorStateMachine(typeof(HFAGLGMGBLD))]
	private IEnumerator<HKMFJDMPEMN> FNLJAFPDNAF(float KFGHOINKLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7C74850", Offset = "0x7C73250", VA = "0x187C74850")]
	[CompilerGenerated]
	private void KDGNCMKEMNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FJHNEPIFCNG : NFMMBNJABEI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static FJHNEPIFCNG LALLOKGAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7C72760", Offset = "0x7C71160", VA = "0x187C72760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7C723F0", Offset = "0x7C70DF0", VA = "0x187C723F0", Slot = "9")]
	public override string CFLEALCFLNK(bool OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7C724E0", Offset = "0x7C70EE0", VA = "0x187C724E0", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] bool PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7C72840", Offset = "0x7C71240", VA = "0x187C72840")]
	public FJHNEPIFCNG()
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
