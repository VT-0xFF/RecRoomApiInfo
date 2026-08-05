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
		[Cpp2IlInjected.Address(RVA = "0x84DB160", Offset = "0x84D9D60", VA = "0x1884DB160", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BEGBAFEMPHB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class OFDKGPKCAHL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void EMHOCIAJJDL(OKAILOMGBBJ DFHGGMNKAGD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84DA6B0", Offset = "0x84D92B0", VA = "0x1884DA6B0")]
	private static void DBHMFJPLJDK(OKAILOMGBBJ DFHGGMNKAGD, EMHOCIAJJDL OBCKEJIDOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84DADC0", Offset = "0x84D99C0", VA = "0x1884DADC0")]
	public static bool MLAHEIBPBFB(this OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, [Optional] EMHOCIAJJDL OBCKEJIDOEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84DA880", Offset = "0x84D9480", VA = "0x1884DA880")]
	public static ICHJMHKKPNN HJPNKOLEBHO(this OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, string BKMPCFIAHIG, [Optional] EMHOCIAJJDL OBCKEJIDOEK)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84DAB10", Offset = "0x84D9710", VA = "0x1884DAB10")]
	public static ICHJMHKKPNN JJALMPEMNAB(this OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, int BKMPCFIAHIG, [Optional] EMHOCIAJJDL OBCKEJIDOEK)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84DA730", Offset = "0x84D9330", VA = "0x1884DA730")]
	public static ICHJMHKKPNN HCGOKEJOLLJ(this OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, bool BKMPCFIAHIG, [Optional] EMHOCIAJJDL OBCKEJIDOEK)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84DAF20", Offset = "0x84D9B20", VA = "0x1884DAF20")]
	public static ICHJMHKKPNN NOKDGMDOBMA(this OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, float BKMPCFIAHIG, [Optional] EMHOCIAJJDL OBCKEJIDOEK)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84DAC50", Offset = "0x84D9850", VA = "0x1884DAC50")]
	public static ICHJMHKKPNN MFALDGDJBAL(this OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, DateTime BKMPCFIAHIG, [Optional] EMHOCIAJJDL OBCKEJIDOEK)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84DA9D0", Offset = "0x84D95D0", VA = "0x1884DA9D0")]
	public static ICHJMHKKPNN IEIGIHMJPGC(this OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, long BKMPCFIAHIG, [Optional] EMHOCIAJJDL OBCKEJIDOEK)
	{
		return default(ICHJMHKKPNN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LOPFICCGLDF : DNEMAKENCAL, OKAILOMGBBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GNCGEBOJKHB MJKJJLCHIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> GMDEJCFIMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> OGJJGGEBLBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MIILNIMFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> PBFFGPIPALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84D9510", Offset = "0x84D8110", VA = "0x1884D9510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action JAPFNKKCABN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84DA1E0", Offset = "0x84D8DE0", VA = "0x1884DA1E0")]
	[UnityEngine.Scripting.Preserve]
	public LOPFICCGLDF([HAKCNCGPHPD(null)] GNCGEBOJKHB MJKJJLCHIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
	public void FLIHNOPMMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84D9410", Offset = "0x84D8010", VA = "0x1884D9410")]
	private DirectoryInfo LBGMKEBEHPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x84D92A0", Offset = "0x84D7EA0", VA = "0x1884D92A0", Slot = "6")]
	public Task IKFNEHMKFLN(long ELIHGHLIGIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84D8C10", Offset = "0x84D7810", VA = "0x1884D8C10", Slot = "14")]
	public float BFCMMMIGKJH(string DHCHBFGMFFD, float PLEDLJICBFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84DA100", Offset = "0x84D8D00", VA = "0x1884DA100", Slot = "13")]
	public void PGOANGEHJEE(string DHCHBFGMFFD, bool BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84D8CF0", Offset = "0x84D78F0", VA = "0x1884D8CF0", Slot = "12")]
	public bool CLCPILEFEGA(string DHCHBFGMFFD, bool PLEDLJICBFM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84D9890", Offset = "0x84D8490", VA = "0x1884D9890", Slot = "10")]
	public int MGLLFAFCJDK(string DHCHBFGMFFD, int PLEDLJICBFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84DA170", Offset = "0x84D8D70", VA = "0x1884DA170", Slot = "18")]
	public DateTime PNDCDEDCHNF(string BABLEGNKCCH, [Optional] DateTime PLEDLJICBFM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84D9130", Offset = "0x84D7D30", VA = "0x1884D9130", Slot = "19")]
	public void HNPFFJBFBAN(string DHCHBFGMFFD, DateTime BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84D9230", Offset = "0x84D7E30", VA = "0x1884D9230", Slot = "15")]
	public void IGJJCLJJPIM(string DHCHBFGMFFD, float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84D9330", Offset = "0x84D7F30", VA = "0x1884D9330", Slot = "11")]
	public void KBJNKOJDBCG(string DHCHBFGMFFD, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84D93A0", Offset = "0x84D7FA0", VA = "0x1884D93A0", Slot = "20")]
	public long LAPGEGDJHBG(string BABLEGNKCCH, long PLEDLJICBFM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84D8C80", Offset = "0x84D7880", VA = "0x1884D8C80", Slot = "21")]
	public void CKKEJPEAKLG(string BABLEGNKCCH, long BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C32720", Offset = "0x3C31320", VA = "0x183C32720", Slot = "22")]
	public T ALIEGMMOCHH<T>(string BABLEGNKCCH, T PLEDLJICBFM, GALLHJHCGIC<T> BDGFOPLKCFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D3C0", Offset = "0x3D1BFC0", VA = "0x183D1D3C0", Slot = "23")]
	public void HLJKONHNKOC<T>(string BABLEGNKCCH, T BKMPCFIAHIG, GALLHJHCGIC<T> BDGFOPLKCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84D9010", Offset = "0x84D7C10", VA = "0x1884D9010", Slot = "16")]
	public string FIHKHAPHEHN(string DHCHBFGMFFD, string PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84D90C0", Offset = "0x84D7CC0", VA = "0x1884D90C0", Slot = "17")]
	public void GBEKBMBDJJG(string DHCHBFGMFFD, string BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84D8EC0", Offset = "0x84D7AC0", VA = "0x1884D8EC0", Slot = "24")]
	public void FHKIHDIICLI(string DHCHBFGMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84D91A0", Offset = "0x84D7DA0", VA = "0x1884D91A0", Slot = "9")]
	public bool ICIAFPDOLDB(string DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84D9550", Offset = "0x84D8150", VA = "0x1884D9550", Slot = "25")]
	public Task LPLFHCIMBCB(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84D8650", Offset = "0x84D7250", VA = "0x1884D8650")]
	private void AOCOOHEPOHD(DirectoryInfo LIMJANIHEEA, string NIBFNEALCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84D8A10", Offset = "0x84D7610", VA = "0x1884D8A10")]
	private static string BEFJCIMIIPN(string DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84D8DC0", Offset = "0x84D79C0", VA = "0x1884D8DC0")]
	private static string FHBFGKIMNEI(byte[] LNEJCNPADCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D33B30", Offset = "0x3D32730", VA = "0x183D33B30")]
	private T LGFPFICEOKK<T>(string BABLEGNKCCH, T PLEDLJICBFM, [Optional] GALLHJHCGIC<T> MEDADPJKCFG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D328F0", Offset = "0x3D314F0", VA = "0x183D328F0")]
	private void IEFFBEILLPC<T>(string BABLEGNKCCH, T BKMPCFIAHIG, [Optional] GALLHJHCGIC<T> MEDADPJKCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84D9900", Offset = "0x84D8500", VA = "0x1884D9900")]
	private Dictionary<string, string> NFFGEEALGFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class GHIJBJKHHCB
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84D28C0", Offset = "0x84D14C0", VA = "0x1884D28C0")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void AMOEJCEGAKO(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MNBBJMCLAII : JJGCFANBIOB
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84D71A0", Offset = "0x84D5DA0", VA = "0x1884D71A0")]
	[UnityEngine.Scripting.Preserve]
	public MNBBJMCLAII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JJGCFANBIOB : DNEMAKENCAL, OKAILOMGBBJ, LJBNAKEOEEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> FPDCGHEOBJI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MIILNIMFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JAPFNKKCABN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
	public void FLIHNOPMMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84D6EA0", Offset = "0x84D5AA0", VA = "0x1884D6EA0", Slot = "6")]
	public Task IKFNEHMKFLN(long ELIHGHLIGIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84D6DE0", Offset = "0x84D59E0", VA = "0x1884D6DE0", Slot = "9")]
	public bool ICIAFPDOLDB(string BABLEGNKCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84D7080", Offset = "0x84D5C80", VA = "0x1884D7080", Slot = "10")]
	public int MGLLFAFCJDK(string BABLEGNKCCH, int PLEDLJICBFM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84D6F30", Offset = "0x84D5B30", VA = "0x1884D6F30", Slot = "11")]
	public void KBJNKOJDBCG(string BABLEGNKCCH, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84D6C00", Offset = "0x84D5800", VA = "0x1884D6C00", Slot = "12")]
	public bool CLCPILEFEGA(string BABLEGNKCCH, bool PLEDLJICBFM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84D70E0", Offset = "0x84D5CE0", VA = "0x1884D70E0", Slot = "13")]
	public void PGOANGEHJEE(string BABLEGNKCCH, bool BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84D6B40", Offset = "0x84D5740", VA = "0x1884D6B40", Slot = "14")]
	public float BFCMMMIGKJH(string BABLEGNKCCH, float PLEDLJICBFM = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84D6E40", Offset = "0x84D5A40", VA = "0x1884D6E40", Slot = "15")]
	public void IGJJCLJJPIM(string BABLEGNKCCH, float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84D6CC0", Offset = "0x84D58C0", VA = "0x1884D6CC0", Slot = "16")]
	public string FIHKHAPHEHN(string BABLEGNKCCH, [Optional] string PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84D6D20", Offset = "0x84D5920", VA = "0x1884D6D20", Slot = "17")]
	public void GBEKBMBDJJG(string BABLEGNKCCH, string BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84D7140", Offset = "0x84D5D40", VA = "0x1884D7140", Slot = "18")]
	public DateTime PNDCDEDCHNF(string BABLEGNKCCH, [Optional] DateTime PLEDLJICBFM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84D6D80", Offset = "0x84D5980", VA = "0x1884D6D80", Slot = "19")]
	public void HNPFFJBFBAN(string BABLEGNKCCH, DateTime BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84D6F90", Offset = "0x84D5B90", VA = "0x1884D6F90", Slot = "20")]
	public long LAPGEGDJHBG(string BABLEGNKCCH, long PLEDLJICBFM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84D6BA0", Offset = "0x84D57A0", VA = "0x1884D6BA0", Slot = "21")]
	public void CKKEJPEAKLG(string BABLEGNKCCH, long BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8530", Offset = "0x3CC7130", VA = "0x183CC8530", Slot = "22")]
	public T ALIEGMMOCHH<T>(string BABLEGNKCCH, T PLEDLJICBFM, GALLHJHCGIC<T> BDGFOPLKCFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8630", Offset = "0x3CC7230", VA = "0x183CC8630", Slot = "23")]
	public void HLJKONHNKOC<T>(string BABLEGNKCCH, T BKMPCFIAHIG, GALLHJHCGIC<T> BDGFOPLKCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8BC0", Offset = "0x3CC77C0", VA = "0x183CC8BC0")]
	public T LGFPFICEOKK<T>(string BABLEGNKCCH, T PLEDLJICBFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3CC86D0", Offset = "0x3CC72D0", VA = "0x183CC86D0")]
	public void IEFFBEILLPC<T>(string BABLEGNKCCH, T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84D6C60", Offset = "0x84D5860", VA = "0x1884D6C60", Slot = "24")]
	public void FHKIHDIICLI(string BABLEGNKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84D6FF0", Offset = "0x84D5BF0", VA = "0x1884D6FF0", Slot = "25")]
	public Task LPLFHCIMBCB(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84D71A0", Offset = "0x84D5DA0", VA = "0x1884D71A0")]
	public JJGCFANBIOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class NLKGKGDEDAE<TParent> where TParent : OKAILOMGBBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<NLKGKGDEDAE<TParent>> ENKPABAAICP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5722EC0", Offset = "0x5721AC0", VA = "0x185722EC0")]
	protected NLKGKGDEDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void HAGLLFMPLGJ();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void HBNNMJIKPNK(string DHCHBFGMFFD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5722950", Offset = "0x5721550", VA = "0x185722950")]
	public static void EIMFDONFFID(string DHCHBFGMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5722B80", Offset = "0x5721780", VA = "0x185722B80")]
	public static void IPEBIKKPDNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HHHOMAPAEJN<TParent, TValue> : NLKGKGDEDAE<TParent> where TParent : OKAILOMGBBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HHHOMAPAEJN<TParent, TValue> JOFMPALJJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> OCINPOOMNIJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4F90120", Offset = "0x4F8ED20", VA = "0x184F90120")]
	public bool GLNNPKODOFD(string JKIPLLMBEPO, [Out] TValue GFFLPNHOMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4F900F0", Offset = "0x4F8ECF0", VA = "0x184F900F0")]
	public void AOKAOOPOEEJ(string JKIPLLMBEPO, TValue BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4F90160", Offset = "0x4F8ED60", VA = "0x184F90160", Slot = "4")]
	protected override void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4F90190", Offset = "0x4F8ED90", VA = "0x184F90190", Slot = "5")]
	protected override void HBNNMJIKPNK(string JKIPLLMBEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4F902F0", Offset = "0x4F8EEF0", VA = "0x184F902F0")]
	public HHHOMAPAEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OKAILOMGBBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MIILNIMFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLIHNOPMMPB();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ICIAFPDOLDB(string BABLEGNKCCH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MGLLFAFCJDK(string BABLEGNKCCH, int PLEDLJICBFM = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBJNKOJDBCG(string BABLEGNKCCH, int BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CLCPILEFEGA(string BABLEGNKCCH, bool PLEDLJICBFM = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PGOANGEHJEE(string BABLEGNKCCH, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float BFCMMMIGKJH(string BABLEGNKCCH, float PLEDLJICBFM = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IGJJCLJJPIM(string BABLEGNKCCH, float BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string FIHKHAPHEHN(string BABLEGNKCCH, [Optional] string PLEDLJICBFM);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GBEKBMBDJJG(string BABLEGNKCCH, string BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime PNDCDEDCHNF(string BABLEGNKCCH, [Optional] DateTime PAOIPEAAMIA);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HNPFFJBFBAN(string BABLEGNKCCH, DateTime PAOIPEAAMIA);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long LAPGEGDJHBG(string BABLEGNKCCH, long PLEDLJICBFM);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CKKEJPEAKLG(string BABLEGNKCCH, long BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T ALIEGMMOCHH<T>(string BABLEGNKCCH, T PLEDLJICBFM, GALLHJHCGIC<T> BDGFOPLKCFL);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HLJKONHNKOC<T>(string BABLEGNKCCH, T BKMPCFIAHIG, GALLHJHCGIC<T> BDGFOPLKCFL);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FHKIHDIICLI(string BABLEGNKCCH);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task LPLFHCIMBCB([Optional] CancellationToken JHCOCAANJDL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DNEMAKENCAL : OKAILOMGBBJ
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JAPFNKKCABN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task IKFNEHMKFLN(long ELIHGHLIGIO, CancellationToken JHCOCAANJDL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LJBNAKEOEEP : OKAILOMGBBJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ICJJGLHBHHO : DNEMAKENCAL, OKAILOMGBBJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BMEDBDODEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ICJJGLHBHHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x84D2200", Offset = "0x84D0E00", VA = "0x1884D2200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84D25D0", Offset = "0x84D11D0", VA = "0x1884D25D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EKCADLICLNO : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ICJJGLHBHHO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public EKCADLICLNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84D2800", Offset = "0x84D1400", VA = "0x1884D2800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84D2870", Offset = "0x84D1470", VA = "0x1884D2870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GNCGEBOJKHB MJKJJLCHIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool OBDECANLPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool GBFKEEKGMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private IELPNMNGABM MCBAOPMMIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private CCGDPHBOCPE GNJDOOHGLFM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MIILNIMFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JAPFNKKCABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84D3860", Offset = "0x84D2460", VA = "0x1884D3860")]
	[UnityEngine.Scripting.Preserve]
	public ICJJGLHBHHO([HAKCNCGPHPD(null)] GNCGEBOJKHB MJKJJLCHIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
	public void FLIHNOPMMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x84D3460", Offset = "0x84D2060", VA = "0x1884D3460", Slot = "6")]
	public Task IKFNEHMKFLN(long ELIHGHLIGIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D5FA10", Offset = "0x1D5E610", VA = "0x181D5FA10")]
	private static int MIMPDFNAFBF(bool BKMPCFIAHIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84D3410", Offset = "0x84D2010", VA = "0x1884D3410", Slot = "9")]
	public bool ICIAFPDOLDB(string BABLEGNKCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84D36F0", Offset = "0x84D22F0", VA = "0x1884D36F0", Slot = "10")]
	public int MGLLFAFCJDK(string BABLEGNKCCH, int PLEDLJICBFM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84D34F0", Offset = "0x84D20F0", VA = "0x1884D34F0", Slot = "11")]
	public void KBJNKOJDBCG(string BABLEGNKCCH, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84D3160", Offset = "0x84D1D60", VA = "0x1884D3160", Slot = "12")]
	public bool CLCPILEFEGA(string BABLEGNKCCH, bool PLEDLJICBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84D37C0", Offset = "0x84D23C0", VA = "0x1884D37C0", Slot = "13")]
	public void PGOANGEHJEE(string BABLEGNKCCH, bool BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84D3050", Offset = "0x84D1C50", VA = "0x1884D3050", Slot = "14")]
	public float BFCMMMIGKJH(string BABLEGNKCCH, float PLEDLJICBFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84D3430", Offset = "0x84D2030", VA = "0x1884D3430", Slot = "15")]
	public void IGJJCLJJPIM(string BABLEGNKCCH, float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x84D37F0", Offset = "0x84D23F0", VA = "0x1884D37F0", Slot = "18")]
	public DateTime PNDCDEDCHNF(string BABLEGNKCCH, [Optional] DateTime PLEDLJICBFM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84D33A0", Offset = "0x84D1FA0", VA = "0x1884D33A0", Slot = "19")]
	public void HNPFFJBFBAN(string BABLEGNKCCH, DateTime PAOIPEAAMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84D3590", Offset = "0x84D2190", VA = "0x1884D3590", Slot = "20")]
	public long LAPGEGDJHBG(string BABLEGNKCCH, long PLEDLJICBFM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84D30F0", Offset = "0x84D1CF0", VA = "0x1884D30F0", Slot = "21")]
	public void CKKEJPEAKLG(string BABLEGNKCCH, long BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9A6C0", Offset = "0x3C992C0", VA = "0x183C9A6C0", Slot = "22")]
	public T ALIEGMMOCHH<T>(string BABLEGNKCCH, T PLEDLJICBFM, GALLHJHCGIC<T> BDGFOPLKCFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AF50", Offset = "0x3C99B50", VA = "0x183C9AF50", Slot = "23")]
	public void HLJKONHNKOC<T>(string BABLEGNKCCH, T BKMPCFIAHIG, GALLHJHCGIC<T> BDGFOPLKCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B080", Offset = "0x3C99C80", VA = "0x183C9B080")]
	private T JKFIMNAINIB<T>(string BABLEGNKCCH, T PLEDLJICBFM, [Optional] GALLHJHCGIC<T> MEDADPJKCFG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3C9A880", Offset = "0x3C99480", VA = "0x183C9A880")]
	private void CFEGGGOHFGM<T>(string BABLEGNKCCH, T BKMPCFIAHIG, [Optional] GALLHJHCGIC<T> MEDADPJKCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84D32A0", Offset = "0x84D1EA0", VA = "0x1884D32A0", Slot = "16")]
	public string FIHKHAPHEHN(string BABLEGNKCCH, string PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84D32D0", Offset = "0x84D1ED0", VA = "0x1884D32D0", Slot = "17")]
	public void GBEKBMBDJJG(string BABLEGNKCCH, string BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x84D3720", Offset = "0x84D2320", VA = "0x1884D3720")]
	private void MNMNDLNGEKG(string BABLEGNKCCH, string BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84D3190", Offset = "0x84D1D90", VA = "0x1884D3190")]
	private string CPFMLNKIALK(string BABLEGNKCCH, string PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x84D3210", Offset = "0x84D1E10", VA = "0x1884D3210", Slot = "24")]
	public void FHKIHDIICLI(string BABLEGNKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84D3300", Offset = "0x84D1F00", VA = "0x1884D3300")]
	private string HIAFHHCIPMA(string DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84D3600", Offset = "0x84D2200", VA = "0x1884D3600", Slot = "25")]
	[AsyncStateMachine(typeof(BMEDBDODEME))]
	public Task LPLFHCIMBCB(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x84D3740", Offset = "0x84D2340", VA = "0x1884D3740")]
	[IteratorStateMachine(typeof(EKCADLICLNO))]
	private IEnumerator<LIPOFPKAEIK> NOJMGJCHHGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x84D31B0", Offset = "0x84D1DB0", VA = "0x1884D31B0")]
	private void FAHGGLDKBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x84D3520", Offset = "0x84D2120", VA = "0x1884D3520")]
	private void KEBOPCHDKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84D3080", Offset = "0x84D1C80", VA = "0x1884D3080")]
	private void CGDBAFLNNKB(bool ELLHPJHPNFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LCPEOMIPAJF : DNEMAKENCAL, OKAILOMGBBJ
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
	private Dictionary<string, string> OGJJGGEBLBP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MIILNIMFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string AMLLBCLLLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84D73E0", Offset = "0x84D5FE0", VA = "0x1884D73E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> PBFFGPIPALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x84D7940", Offset = "0x84D6540", VA = "0x1884D7940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action JAPFNKKCABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	[UnityEngine.Scripting.Preserve]
	public LCPEOMIPAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
	public void FLIHNOPMMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x84D77D0", Offset = "0x84D63D0", VA = "0x1884D77D0", Slot = "6")]
	public Task IKFNEHMKFLN(long ELIHGHLIGIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x84D7230", Offset = "0x84D5E30", VA = "0x1884D7230", Slot = "14")]
	public float BFCMMMIGKJH(string DHCHBFGMFFD, float PLEDLJICBFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x84D7F60", Offset = "0x84D6B60", VA = "0x1884D7F60", Slot = "13")]
	public void PGOANGEHJEE(string DHCHBFGMFFD, bool BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x84D7310", Offset = "0x84D5F10", VA = "0x1884D7310", Slot = "12")]
	public bool CLCPILEFEGA(string DHCHBFGMFFD, bool PLEDLJICBFM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x84D7BF0", Offset = "0x84D67F0", VA = "0x1884D7BF0", Slot = "10")]
	public int MGLLFAFCJDK(string DHCHBFGMFFD, int PLEDLJICBFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x84D7FD0", Offset = "0x84D6BD0", VA = "0x1884D7FD0", Slot = "18")]
	public DateTime PNDCDEDCHNF(string BABLEGNKCCH, [Optional] DateTime PLEDLJICBFM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x84D7660", Offset = "0x84D6260", VA = "0x1884D7660", Slot = "19")]
	public void HNPFFJBFBAN(string DHCHBFGMFFD, DateTime BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x84D7760", Offset = "0x84D6360", VA = "0x1884D7760", Slot = "15")]
	public void IGJJCLJJPIM(string DHCHBFGMFFD, float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x84D7860", Offset = "0x84D6460", VA = "0x1884D7860", Slot = "11")]
	public void KBJNKOJDBCG(string DHCHBFGMFFD, int BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x84D78D0", Offset = "0x84D64D0", VA = "0x1884D78D0", Slot = "20")]
	public long LAPGEGDJHBG(string BABLEGNKCCH, long PLEDLJICBFM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x84D72A0", Offset = "0x84D5EA0", VA = "0x1884D72A0", Slot = "21")]
	public void CKKEJPEAKLG(string BABLEGNKCCH, long BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C32720", Offset = "0x3C31320", VA = "0x183C32720", Slot = "22")]
	public T ALIEGMMOCHH<T>(string BABLEGNKCCH, T PLEDLJICBFM, GALLHJHCGIC<T> BDGFOPLKCFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D3C0", Offset = "0x3D1BFC0", VA = "0x183D1D3C0", Slot = "23")]
	public void HLJKONHNKOC<T>(string BABLEGNKCCH, T BKMPCFIAHIG, GALLHJHCGIC<T> BDGFOPLKCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x84D7510", Offset = "0x84D6110", VA = "0x1884D7510", Slot = "16")]
	public string FIHKHAPHEHN(string DHCHBFGMFFD, string PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x84D75C0", Offset = "0x84D61C0", VA = "0x1884D75C0", Slot = "17")]
	public void GBEKBMBDJJG(string DHCHBFGMFFD, string BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x84D7450", Offset = "0x84D6050", VA = "0x1884D7450", Slot = "24")]
	public void FHKIHDIICLI(string DHCHBFGMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x84D76D0", Offset = "0x84D62D0", VA = "0x1884D76D0", Slot = "9")]
	public bool ICIAFPDOLDB(string DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x84D7980", Offset = "0x84D6580", VA = "0x1884D7980", Slot = "25")]
	public Task LPLFHCIMBCB(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3D1E390", Offset = "0x3D1CF90", VA = "0x183D1E390")]
	private T LGFPFICEOKK<T>(string BABLEGNKCCH, T PLEDLJICBFM, [Optional] GALLHJHCGIC<T> MEDADPJKCFG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D1D460", Offset = "0x3D1C060", VA = "0x183D1D460")]
	private void IEFFBEILLPC<T>(string BABLEGNKCCH, T BKMPCFIAHIG, [Optional] GALLHJHCGIC<T> MEDADPJKCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x84D7C60", Offset = "0x84D6860", VA = "0x1884D7C60")]
	private Dictionary<string, string> NFFGEEALGFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IFMJLEBMFFE
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action JAPFNKKCABN;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLIHNOPMMPB();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HGGDLOIHJIC(long ELIHGHLIGIO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JAPMGBMEBBE(BEGBAFEMPHB KMFEELHNGEM = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LAGMPDJMGBP(string BABLEGNKCCH, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CBBHKMJPEHD(string BABLEGNKCCH, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string CALLIDDNFLB(string BABLEGNKCCH, [Optional] string PLEDLJICBFM, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ICHJMHKKPNN FILDENOLJCM(string BABLEGNKCCH, string BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int IIOMHOMNGDP(string BABLEGNKCCH, int PLEDLJICBFM = 0, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ICHJMHKKPNN KBKAIMFGDML(string BABLEGNKCCH, int BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LHODGMLIAKO(string BABLEGNKCCH, bool PLEDLJICBFM, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ICHJMHKKPNN HDPLKOHAAGO(string BABLEGNKCCH, bool BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float DANLACGGNGC(string BABLEGNKCCH, float PLEDLJICBFM = 0f, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ICHJMHKKPNN MDBMJLKPHKL(string BABLEGNKCCH, float BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime OIGAKEAIIEG(string BABLEGNKCCH, [Optional] DateTime PLEDLJICBFM, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	ICHJMHKKPNN JIHBBIFINKF(string BABLEGNKCCH, DateTime BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long PBBACCKPLKE(string BABLEGNKCCH, long PLEDLJICBFM = 0L, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ICHJMHKKPNN ELLAOOIMIKL(string BABLEGNKCCH, long BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T BDCBBIOMEAP<T>(string BABLEGNKCCH, [Optional] T PLEDLJICBFM, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	ICHJMHKKPNN OGEIGEAPIGP<T>(string BABLEGNKCCH, T BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool PKECCJIBLOJ(string BABLEGNKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool HIHHCMOENAB(string BABLEGNKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string FDJINDDDMOC(string BABLEGNKCCH, [Optional] string PLEDLJICBFM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ICHJMHKKPNN FHMKPNABJMM(string BABLEGNKCCH, string BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int CHLLCKKJGDB(string BABLEGNKCCH, int PLEDLJICBFM = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	ICHJMHKKPNN ICIKLHKKOPD(string BABLEGNKCCH, int BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool OOJLNKCEJEM(string BABLEGNKCCH, bool PLEDLJICBFM);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	ICHJMHKKPNN LMOAJBLJEEM(string BABLEGNKCCH, bool BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float JNOCAFCFFGI(string BABLEGNKCCH, float PLEDLJICBFM = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	ICHJMHKKPNN LIBCEEGKNHI(string BABLEGNKCCH, float BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime AKLJDLMCMHB(string BABLEGNKCCH, [Optional] DateTime PLEDLJICBFM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	ICHJMHKKPNN NOEAHNEHLHD(string BABLEGNKCCH, DateTime BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long FCNDCILEOMM(string BABLEGNKCCH, long PLEDLJICBFM = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	ICHJMHKKPNN DKKIBCIDILE(string BABLEGNKCCH, long BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void HFJJCFPGHFL<T>(GALLHJHCGIC<T> BDGFOPLKCFL, [Optional] IEqualityComparer<T> FLFBEHPGIBM);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EIMBDCHHAFA<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable BCJICHANIAJ();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JLGDFBGIOHG(float DJMONOPAJCJ);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task FAHGGLDKBOE([Optional] CancellationToken JHCOCAANJDL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum ICHJMHKKPNN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IFALKIGHHOL : IFMJLEBMFFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class CJHBMCMELHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<CJHBMCMELHL> LHAPOLGDPIF;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x84D2630", Offset = "0x84D1230", VA = "0x1884D2630")]
		public static void IPEBIKKPDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void HAGLLFMPLGJ();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		protected CJHBMCMELHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class ODKLMEKFPJO<T> : CJHBMCMELHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly ODKLMEKFPJO<T> MFAGMJBMEEP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GALLHJHCGIC<T> KAIDGJFCBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> CPMMHOJBAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool CCDKDBCBAFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x48BEC00", Offset = "0x48BD800", VA = "0x1848BEC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x584FA70", Offset = "0x584E670", VA = "0x18584FA70")]
		private ODKLMEKFPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x584F450", Offset = "0x584E050", VA = "0x18584F450")]
		public void AMHLLDBNIFP(GALLHJHCGIC<T> MEDADPJKCFG, [Optional] IEqualityComparer<T> FLFBEHPGIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x584F870", Offset = "0x584E470", VA = "0x18584F870", Slot = "4")]
		public override void HAGLLFMPLGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class LKGMGNCICOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly IFALKIGHHOL CPKMIEIDGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object FJMECDINFHB;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x84D8070", Offset = "0x84D6C70", VA = "0x1884D8070")]
		public LKGMGNCICOI(IFALKIGHHOL CPKMIEIDGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x84D8040", Offset = "0x84D6C40", VA = "0x1884D8040", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct MLFIKBIDADC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public IFALKIGHHOL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84DA280", Offset = "0x84D8E80", VA = "0x1884DA280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x84DA570", Offset = "0x84D9170", VA = "0x1884DA570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct HNPPKMNMDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IFALKIGHHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public OKAILOMGBBJ backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84D2EC0", Offset = "0x84D1AC0", VA = "0x1884D2EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct LLEIDDFMEMG : IAsyncStateMachine
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
		public IFALKIGHHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x84D8120", Offset = "0x84D6D20", VA = "0x1884D8120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x84D85F0", Offset = "0x84D71F0", VA = "0x1884D85F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NMJHALCMOJK : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IFALKIGHHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public NMJHALCMOJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x84DA5D0", Offset = "0x84D91D0", VA = "0x1884DA5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x84DA660", Offset = "0x84D9260", VA = "0x1884DA660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly DNEMAKENCAL PHBAJNEOHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly DNEMAKENCAL PGAMFNLCALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly LJBNAKEOEEP GDKHPAHAGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IELPNMNGABM MCBAOPMMIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly OFDKGPKCAHL.EMHOCIAJJDL OBCKEJIDOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IACMJMJNBEK KGDBOCACIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<OKAILOMGBBJ> HCKMMHGIDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task IONNENOPPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> HNLONJJKPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CCGDPHBOCPE MJCPFCGLAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object NEJGOKJLKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object CAIKOMPKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long EKBFJEKJBGI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool GEACDLOLNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84D3F50", Offset = "0x84D2B50", VA = "0x1884D3F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource LMFBDBHBEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA5B580", Offset = "0xA5A180", VA = "0x180A5B580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action JAPFNKKCABN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x84D57F0", Offset = "0x84D43F0", VA = "0x1884D57F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84D5750", Offset = "0x84D4350", VA = "0x1884D5750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x84D5640", Offset = "0x84D4240", VA = "0x1884D5640")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x84D6770", Offset = "0x84D5370", VA = "0x1884D6770")]
	[UnityEngine.Scripting.Preserve]
	public IFALKIGHHOL([HAKCNCGPHPD("Disk")] DNEMAKENCAL PHBAJNEOHEF, [HAKCNCGPHPD("Cloud")] DNEMAKENCAL PGAMFNLCALP, [HAKCNCGPHPD(null)] LJBNAKEOEEP GDKHPAHAGGC, [HAKCNCGPHPD(null)] IELPNMNGABM MCBAOPMMIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x84D42D0", Offset = "0x84D2ED0", VA = "0x1884D42D0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x84D5DC0", Offset = "0x84D49C0", VA = "0x1884D5DC0")]
	private void NNHFJGPKDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x84D4880", Offset = "0x84D3480", VA = "0x1884D4880", Slot = "6")]
	public void FLIHNOPMMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84D4A60", Offset = "0x84D3660", VA = "0x1884D4A60", Slot = "7")]
	public Task HGGDLOIHJIC(long ELIHGHLIGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x84D3950", Offset = "0x84D2550", VA = "0x1884D3950")]
	[AsyncStateMachine(typeof(MLFIKBIDADC))]
	private Task AGGEHBNNJLA(long ELIHGHLIGIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x84D6470", Offset = "0x84D5070", VA = "0x1884D6470")]
	private void PHHLFBNBAPN(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x84D4650", Offset = "0x84D3250", VA = "0x1884D4650")]
	private void FGBGHGMMJAB(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x84D3BB0", Offset = "0x84D27B0", VA = "0x1884D3BB0")]
	private string CACGIPLPIPI(string NENJOAMKFLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x84D52C0", Offset = "0x84D3EC0", VA = "0x1884D52C0")]
	private void JMENHDCPLCG(BEGBAFEMPHB KMFEELHNGEM, string DHCHBFGMFFD, [Out] DNEMAKENCAL DFHGGMNKAGD, [Out] string IMGMPAAGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x84D4C70", Offset = "0x84D3870", VA = "0x1884D4C70")]
	private DNEMAKENCAL IGPCAOMELOO(BEGBAFEMPHB KMFEELHNGEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x84D4DA0", Offset = "0x84D39A0", VA = "0x1884D4DA0", Slot = "8")]
	public bool JAPMGBMEBBE(BEGBAFEMPHB KMFEELHNGEM = BEGBAFEMPHB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x84D56B0", Offset = "0x84D42B0", VA = "0x1884D56B0", Slot = "9")]
	public bool LAGMPDJMGBP(string BABLEGNKCCH, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x84D3CB0", Offset = "0x84D28B0", VA = "0x1884D3CB0", Slot = "10")]
	public bool CBBHKMJPEHD(string BABLEGNKCCH, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x84D3C10", Offset = "0x84D2810", VA = "0x1884D3C10", Slot = "11")]
	public string CALLIDDNFLB(string BABLEGNKCCH, [Optional] string PLEDLJICBFM, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x84D4700", Offset = "0x84D3300", VA = "0x1884D4700", Slot = "12")]
	public ICHJMHKKPNN FILDENOLJCM(string BABLEGNKCCH, string BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x84D4CF0", Offset = "0x84D38F0", VA = "0x1884D4CF0", Slot = "13")]
	public int IIOMHOMNGDP(string BABLEGNKCCH, int PLEDLJICBFM = 0, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x84D54D0", Offset = "0x84D40D0", VA = "0x1884D54D0", Slot = "14")]
	public ICHJMHKKPNN KBKAIMFGDML(string BABLEGNKCCH, int BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x84D5890", Offset = "0x84D4490", VA = "0x1884D5890", Slot = "15")]
	public bool LHODGMLIAKO(string BABLEGNKCCH, bool PLEDLJICBFM, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x84D48F0", Offset = "0x84D34F0", VA = "0x1884D48F0", Slot = "16")]
	public ICHJMHKKPNN HDPLKOHAAGO(string BABLEGNKCCH, bool BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x84D3EA0", Offset = "0x84D2AA0", VA = "0x1884D3EA0", Slot = "17")]
	public float DANLACGGNGC(string BABLEGNKCCH, float PLEDLJICBFM = 0f, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x84D5A70", Offset = "0x84D4670", VA = "0x1884D5A70", Slot = "18")]
	public ICHJMHKKPNN MDBMJLKPHKL(string BABLEGNKCCH, float BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x84D5EA0", Offset = "0x84D4AA0", VA = "0x1884D5EA0", Slot = "19")]
	public DateTime OIGAKEAIIEG(string BABLEGNKCCH, [Optional] DateTime PLEDLJICBFM, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x84D5110", Offset = "0x84D3D10", VA = "0x1884D5110", Slot = "20")]
	public ICHJMHKKPNN JIHBBIFINKF(string BABLEGNKCCH, DateTime BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x84D63D0", Offset = "0x84D4FD0", VA = "0x1884D63D0", Slot = "21")]
	public long PBBACCKPLKE(string BABLEGNKCCH, long PLEDLJICBFM = 0L, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x84D4310", Offset = "0x84D2F10", VA = "0x1884D4310", Slot = "22")]
	public ICHJMHKKPNN ELLAOOIMIKL(string BABLEGNKCCH, long BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EAF0", Offset = "0x3C9D6F0", VA = "0x183C9EAF0", Slot = "23")]
	public T BDCBBIOMEAP<T>(string BABLEGNKCCH, [Optional] T PLEDLJICBFM, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EAF0", Offset = "0x3C9D6F0", VA = "0x183C9EAF0", Slot = "24")]
	public ICHJMHKKPNN OGEIGEAPIGP<T>(string BABLEGNKCCH, T BKMPCFIAHIG, BEGBAFEMPHB JJBPHJBODPL = BEGBAFEMPHB.CLOUD)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x84D6710", Offset = "0x84D5310", VA = "0x1884D6710", Slot = "25")]
	public bool PKECCJIBLOJ(string BABLEGNKCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x84D4C30", Offset = "0x84D3830", VA = "0x1884D4C30", Slot = "26")]
	public bool HIHHCMOENAB(string BABLEGNKCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x84D45E0", Offset = "0x84D31E0", VA = "0x1884D45E0", Slot = "27")]
	public string FDJINDDDMOC(string BABLEGNKCCH, [Optional] string PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x84D46D0", Offset = "0x84D32D0", VA = "0x1884D46D0", Slot = "28")]
	public ICHJMHKKPNN FHMKPNABJMM(string BABLEGNKCCH, string BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x84D3E30", Offset = "0x84D2A30", VA = "0x1884D3E30", Slot = "29")]
	public int CHLLCKKJGDB(string BABLEGNKCCH, int PLEDLJICBFM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x84D4C40", Offset = "0x84D3840", VA = "0x1884D4C40", Slot = "30")]
	public ICHJMHKKPNN ICIKLHKKOPD(string BABLEGNKCCH, int BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x84D6090", Offset = "0x84D4C90", VA = "0x1884D6090", Slot = "31")]
	public bool OOJLNKCEJEM(string BABLEGNKCCH, bool PLEDLJICBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x84D5970", Offset = "0x84D4570", VA = "0x1884D5970", Slot = "32")]
	public ICHJMHKKPNN LMOAJBLJEEM(string BABLEGNKCCH, bool BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x84D5460", Offset = "0x84D4060", VA = "0x1884D5460", Slot = "33")]
	public float JNOCAFCFFGI(string BABLEGNKCCH, float PLEDLJICBFM = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x84D5940", Offset = "0x84D4540", VA = "0x1884D5940", Slot = "34")]
	public ICHJMHKKPNN LIBCEEGKNHI(string BABLEGNKCCH, float BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x84D3A60", Offset = "0x84D2660", VA = "0x1884D3A60", Slot = "35")]
	public DateTime AKLJDLMCMHB(string BABLEGNKCCH, [Optional] DateTime PLEDLJICBFM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x84D5E10", Offset = "0x84D4A10", VA = "0x1884D5E10", Slot = "36")]
	public ICHJMHKKPNN NOEAHNEHLHD(string BABLEGNKCCH, DateTime BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x84D4570", Offset = "0x84D3170", VA = "0x1884D4570", Slot = "37")]
	public long FCNDCILEOMM(string BABLEGNKCCH, long PLEDLJICBFM = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x84D42A0", Offset = "0x84D2EA0", VA = "0x1884D42A0", Slot = "38")]
	public ICHJMHKKPNN DKKIBCIDILE(string BABLEGNKCCH, long BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x84D5E40", Offset = "0x84D4A40", VA = "0x1884D5E40")]
	private bool ODEKLMCHDBG(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x84D6100", Offset = "0x84D4D00", VA = "0x1884D6100")]
	private bool OPGNKDPPHAE(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x84D3F70", Offset = "0x84D2B70", VA = "0x1884D3F70")]
	private ICHJMHKKPNN DEPJJEPLNDK(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, string BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x84D4E90", Offset = "0x84D3A90", VA = "0x1884D4E90")]
	private ICHJMHKKPNN JCKPLNIDBEM(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, int BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x84D5C80", Offset = "0x84D4880", VA = "0x1884D5C80")]
	private ICHJMHKKPNN MMIEFMBJFHI(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, bool BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x84D5F40", Offset = "0x84D4B40", VA = "0x1884D5F40")]
	private ICHJMHKKPNN OKAKOPDPBNM(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, float BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x84D6260", Offset = "0x84D4E60", VA = "0x1884D6260")]
	private ICHJMHKKPNN PACNPICBGEL(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, DateTime BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x84D4FD0", Offset = "0x84D3BD0", VA = "0x1884D4FD0")]
	private ICHJMHKKPNN JIADOPMPMII(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, long BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F930", Offset = "0x3C9E530", VA = "0x183C9F930")]
	private T IMEGMEHCNDA<T>(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, T PLEDLJICBFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EE10", Offset = "0x3C9DA10", VA = "0x183C9EE10")]
	private ICHJMHKKPNN HMHNEBGCAOE<T>(OKAILOMGBBJ DFHGGMNKAGD, string BABLEGNKCCH, T BKMPCFIAHIG)
	{
		return default(ICHJMHKKPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3C9ED70", Offset = "0x3C9D970", VA = "0x183C9ED70", Slot = "39")]
	public void HFJJCFPGHFL<T>(GALLHJHCGIC<T> BDGFOPLKCFL, [Optional] IEqualityComparer<T> FLFBEHPGIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3C9ECF0", Offset = "0x3C9D8F0", VA = "0x183C9ECF0", Slot = "40")]
	public void EIMBDCHHAFA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x84D59A0", Offset = "0x84D45A0", VA = "0x1884D59A0")]
	[AsyncStateMachine(typeof(HNPPKMNMDEM))]
	private void LPLFHCIMBCB(OKAILOMGBBJ ONNKIECCGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x84D4480", Offset = "0x84D3080", VA = "0x1884D4480", Slot = "43")]
	[AsyncStateMachine(typeof(LLEIDDFMEMG))]
	public Task FAHGGLDKBOE([Optional] CancellationToken DANCOEFIHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x84D40C0", Offset = "0x84D2CC0", VA = "0x1884D40C0")]
	private void DKBPNFDHAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x84D3AD0", Offset = "0x84D26D0", VA = "0x1884D3AD0", Slot = "41")]
	public IDisposable BCJICHANIAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x84D52B0", Offset = "0x84D3EB0", VA = "0x1884D52B0", Slot = "42")]
	public void JLGDFBGIOHG(float DJMONOPAJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x84D6490", Offset = "0x84D5090", VA = "0x1884D6490")]
	private void PJLPKAHFIIB(float GDGOGJDILBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x84D5BF0", Offset = "0x84D47F0", VA = "0x1884D5BF0")]
	[IteratorStateMachine(typeof(NMJHALCMOJK))]
	private IEnumerator<LIPOFPKAEIK> MKENINJKFGG(float DJMONOPAJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x84D4E60", Offset = "0x84D3A60", VA = "0x1884D4E60")]
	[CompilerGenerated]
	private void JBLJECDDFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HICKBBGLJIO : JAFMKCHMNCM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static HICKBBGLJIO MFAGMJBMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x84D2CA0", Offset = "0x84D18A0", VA = "0x1884D2CA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x84D2CF0", Offset = "0x84D18F0", VA = "0x1884D2CF0", Slot = "9")]
	public override string PBHGMJKEMBG(bool HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x84D2A20", Offset = "0x84D1620", VA = "0x1884D2A20", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] bool BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x84D2E80", Offset = "0x84D1A80", VA = "0x1884D2E80")]
	public HICKBBGLJIO()
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
