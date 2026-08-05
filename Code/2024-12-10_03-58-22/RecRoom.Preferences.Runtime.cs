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
		[Cpp2IlInjected.Address(RVA = "0x6F22600", Offset = "0x6F21200", VA = "0x186F22600", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JBNCBGIFMGD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class AEELMLFEKIC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void BDOFPNACHGH(LDPNCHONDCB AFGMFLLEFFO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F185C0", Offset = "0x6F171C0", VA = "0x186F185C0")]
	private static void IEIDKGOMGDB(LDPNCHONDCB AFGMFLLEFFO, BDOFPNACHGH DBDAHEDMICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F18380", Offset = "0x6F16F80", VA = "0x186F18380")]
	public static bool CNJFCNGILPH(this LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, [Optional] BDOFPNACHGH DBDAHEDMICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F18470", Offset = "0x6F17070", VA = "0x186F18470")]
	public static MKBLPAGAGKI DBHOGFEPCKE(this LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, string CABLCDOIFFL, [Optional] BDOFPNACHGH DBDAHEDMICN)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F18790", Offset = "0x6F17390", VA = "0x186F18790")]
	public static MKBLPAGAGKI IPANLBHJNNF(this LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, int CABLCDOIFFL, [Optional] BDOFPNACHGH DBDAHEDMICN)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F18640", Offset = "0x6F17240", VA = "0x186F18640")]
	public static MKBLPAGAGKI IONENCOKCDM(this LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, bool CABLCDOIFFL, [Optional] BDOFPNACHGH DBDAHEDMICN)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F18230", Offset = "0x6F16E30", VA = "0x186F18230")]
	public static MKBLPAGAGKI AKDNLMDLDAK(this LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, float CABLCDOIFFL, [Optional] BDOFPNACHGH DBDAHEDMICN)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F18A10", Offset = "0x6F17610", VA = "0x186F18A10")]
	public static MKBLPAGAGKI PJMKKNKPAAE(this LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, DateTime CABLCDOIFFL, [Optional] BDOFPNACHGH DBDAHEDMICN)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F188D0", Offset = "0x6F174D0", VA = "0x186F188D0")]
	public static MKBLPAGAGKI MGEOFDIFOFM(this LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, long CABLCDOIFFL, [Optional] BDOFPNACHGH DBDAHEDMICN)
	{
		return default(MKBLPAGAGKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PMOHBLBGBOF : ECHKFOGFNPL, LDPNCHONDCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OOPAPAAJMFA CNNOFBMNGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> DGPCAJCCNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> LJEPIPDKBDN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> FPKNJOAPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F20D20", Offset = "0x6F1F920", VA = "0x186F20D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LDECAEIJMID
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F223C0", Offset = "0x6F20FC0", VA = "0x186F223C0")]
	[UnityEngine.Scripting.Preserve]
	public PMOHBLBGBOF([JGAMIMHCGFI(null)] OOPAPAAJMFA CNNOFBMNGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "8")]
	public void HLNGMJMHDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F21520", Offset = "0x6F20120", VA = "0x186F21520")]
	private DirectoryInfo KLPLOGJHMGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F222C0", Offset = "0x6F20EC0", VA = "0x186F222C0", Slot = "6")]
	public Task OFNMLNOEEMP(long POOPEFGIGIA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F20B40", Offset = "0x6F1F740", VA = "0x186F20B40", Slot = "14")]
	public float CALEEBLFHJD(string NONKDEOLPHL, float IEDAFAANJNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F21620", Offset = "0x6F20220", VA = "0x186F21620", Slot = "13")]
	public void KPGAPGMHCMA(string NONKDEOLPHL, bool CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F20F20", Offset = "0x6F1FB20", VA = "0x186F20F20", Slot = "12")]
	public bool HGELKCDCFEH(string NONKDEOLPHL, bool IEDAFAANJNE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F20D60", Offset = "0x6F1F960", VA = "0x186F20D60", Slot = "10")]
	public int GGKFJHLJPCF(string NONKDEOLPHL, int IEDAFAANJNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F20DD0", Offset = "0x6F1F9D0", VA = "0x186F20DD0", Slot = "18")]
	public DateTime GJMOFDCPLAC(string NMDOFAJBOFG, [Optional] DateTime IEDAFAANJNE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F20EB0", Offset = "0x6F1FAB0", VA = "0x186F20EB0", Slot = "19")]
	public void HDFDMBEAEDA(string NONKDEOLPHL, DateTime CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F22350", Offset = "0x6F20F50", VA = "0x186F22350", Slot = "15")]
	public void PBBOAGBAPOJ(string NONKDEOLPHL, float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F22250", Offset = "0x6F20E50", VA = "0x186F22250", Slot = "11")]
	public void NIJKAILIBMH(string NONKDEOLPHL, int CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F20C20", Offset = "0x6F1F820", VA = "0x186F20C20", Slot = "20")]
	public long CCHKHNPGIGC(string NMDOFAJBOFG, long IEDAFAANJNE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F20BB0", Offset = "0x6F1F7B0", VA = "0x186F20BB0", Slot = "21")]
	public void CBKOAIOMBJB(string NMDOFAJBOFG, long CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B90500", Offset = "0x2B8F100", VA = "0x182B90500", Slot = "22")]
	public T IFKPIKLGHCM<T>(string NMDOFAJBOFG, T IEDAFAANJNE, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B90500", Offset = "0x2B8F100", VA = "0x182B90500", Slot = "23")]
	public void LNOHOFNLLHL<T>(string NMDOFAJBOFG, T CABLCDOIFFL, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F20FE0", Offset = "0x6F1FBE0", VA = "0x186F20FE0", Slot = "16")]
	public string HGNDIIOKDHA(string NONKDEOLPHL, string IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F20E40", Offset = "0x6F1FA40", VA = "0x186F20E40", Slot = "17")]
	public void GPLEJEOGPMG(string NONKDEOLPHL, string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F21690", Offset = "0x6F20290", VA = "0x186F21690", Slot = "24")]
	public void LLADFFBNDDF(string NONKDEOLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F20C90", Offset = "0x6F1F890", VA = "0x186F20C90", Slot = "9")]
	public bool DMENHBCMHJN(string NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F21750", Offset = "0x6F20350", VA = "0x186F21750", Slot = "25")]
	public Task MHCAPJOGJND(CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F21090", Offset = "0x6F1FC90", VA = "0x186F21090")]
	private void HJCFBEIALJJ(DirectoryInfo PAKGLMCGHIL, string CGNOGAHODAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F20940", Offset = "0x6F1F540", VA = "0x186F20940")]
	private static string BNODBENPFNJ(string NONKDEOLPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F21420", Offset = "0x6F20020", VA = "0x186F21420")]
	private static string KGDOODNCOLE(byte[] NDKFLGEBABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2FDB520", Offset = "0x2FDA120", VA = "0x182FDB520")]
	private T IBIJBNAFKLE<T>(string NMDOFAJBOFG, T IEDAFAANJNE, [Optional] FJLACOEIDDK<T> ODGLLBDCAPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2FDA190", Offset = "0x2FD8D90", VA = "0x182FDA190")]
	private void GAOLHIMCFIN<T>(string NMDOFAJBOFG, T CABLCDOIFFL, [Optional] FJLACOEIDDK<T> ODGLLBDCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F21A80", Offset = "0x6F20680", VA = "0x186F21A80")]
	private Dictionary<string, string> MOJFJFKIGFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class PLGPEMADAHG
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F207E0", Offset = "0x6F1F3E0", VA = "0x186F207E0")]
	[BOLBLOCFHKO.ENGLBNKHCKK]
	internal static void NPEAJDJKCFF(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CGLIPAGAPNG : JPBJLBFLGCJ
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F18B80", Offset = "0x6F17780", VA = "0x186F18B80")]
	[UnityEngine.Scripting.Preserve]
	public CGLIPAGAPNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JPBJLBFLGCJ : ECHKFOGFNPL, LDPNCHONDCB, EJEDPNOBHBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> JBKFFEBHFCC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LDECAEIJMID
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "8")]
	public void HLNGMJMHDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CBA0", Offset = "0x6F1B7A0", VA = "0x186F1CBA0", Slot = "6")]
	public Task OFNMLNOEEMP(long POOPEFGIGIA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C750", Offset = "0x6F1B350", VA = "0x186F1C750", Slot = "9")]
	public bool DMENHBCMHJN(string NMDOFAJBOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C7B0", Offset = "0x6F1B3B0", VA = "0x186F1C7B0", Slot = "10")]
	public int GGKFJHLJPCF(string NMDOFAJBOFG, int IEDAFAANJNE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CB40", Offset = "0x6F1B740", VA = "0x186F1CB40", Slot = "11")]
	public void NIJKAILIBMH(string NMDOFAJBOFG, int CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C930", Offset = "0x6F1B530", VA = "0x186F1C930", Slot = "12")]
	public bool HGELKCDCFEH(string NMDOFAJBOFG, bool IEDAFAANJNE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C9F0", Offset = "0x6F1B5F0", VA = "0x186F1C9F0", Slot = "13")]
	public void KPGAPGMHCMA(string NMDOFAJBOFG, bool CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C630", Offset = "0x6F1B230", VA = "0x186F1C630", Slot = "14")]
	public float CALEEBLFHJD(string NMDOFAJBOFG, float IEDAFAANJNE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CC30", Offset = "0x6F1B830", VA = "0x186F1CC30", Slot = "15")]
	public void PBBOAGBAPOJ(string NMDOFAJBOFG, float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C990", Offset = "0x6F1B590", VA = "0x186F1C990", Slot = "16")]
	public string HGNDIIOKDHA(string NMDOFAJBOFG, [Optional] string IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C870", Offset = "0x6F1B470", VA = "0x186F1C870", Slot = "17")]
	public void GPLEJEOGPMG(string NMDOFAJBOFG, string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C810", Offset = "0x6F1B410", VA = "0x186F1C810", Slot = "18")]
	public DateTime GJMOFDCPLAC(string NMDOFAJBOFG, [Optional] DateTime IEDAFAANJNE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C8D0", Offset = "0x6F1B4D0", VA = "0x186F1C8D0", Slot = "19")]
	public void HDFDMBEAEDA(string NMDOFAJBOFG, DateTime CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C6F0", Offset = "0x6F1B2F0", VA = "0x186F1C6F0", Slot = "20")]
	public long CCHKHNPGIGC(string NMDOFAJBOFG, long IEDAFAANJNE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C690", Offset = "0x6F1B290", VA = "0x186F1C690", Slot = "21")]
	public void CBKOAIOMBJB(string NMDOFAJBOFG, long CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5510", Offset = "0x2EA4110", VA = "0x182EA5510", Slot = "22")]
	public T IFKPIKLGHCM<T>(string NMDOFAJBOFG, T IEDAFAANJNE, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5630", Offset = "0x2EA4230", VA = "0x182EA5630", Slot = "23")]
	public void LNOHOFNLLHL<T>(string NMDOFAJBOFG, T CABLCDOIFFL, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4CD0", Offset = "0x2EA38D0", VA = "0x182EA4CD0")]
	public T IBIJBNAFKLE<T>(string NMDOFAJBOFG, T IEDAFAANJNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2EA47E0", Offset = "0x2EA33E0", VA = "0x182EA47E0")]
	public void GAOLHIMCFIN<T>(string NMDOFAJBOFG, T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CA50", Offset = "0x6F1B650", VA = "0x186F1CA50", Slot = "24")]
	public void LLADFFBNDDF(string NMDOFAJBOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CAB0", Offset = "0x6F1B6B0", VA = "0x186F1CAB0", Slot = "25")]
	public Task MHCAPJOGJND(CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F18B80", Offset = "0x6F17780", VA = "0x186F18B80")]
	public JPBJLBFLGCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class GJLODBNJIFB<TParent> where TParent : LDPNCHONDCB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<GJLODBNJIFB<TParent>> GLPAONPJFPN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB4C0", Offset = "0x3EEA0C0", VA = "0x183EEB4C0")]
	protected GJLODBNJIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void ANKOMBFBDGF();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void KNMNKNCCGLF(string NONKDEOLPHL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEAF20", Offset = "0x3EE9B20", VA = "0x183EEAF20")]
	public static void IAAPFBEEFND(string NONKDEOLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB160", Offset = "0x3EE9D60", VA = "0x183EEB160")]
	public static void PFKFMPEAACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DBGDMPCHIKK<TParent, TValue> : GJLODBNJIFB<TParent> where TParent : LDPNCHONDCB
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DBGDMPCHIKK<TParent, TValue> GHFEJGGLAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> FIJOPIBGPHC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5AB7970", Offset = "0x5AB6570", VA = "0x185AB7970")]
	public bool NNAAPMJPMIH(string EFGPCFMPHGL, [Out] TValue DHDEAMIFJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5AB7870", Offset = "0x5AB6470", VA = "0x185AB7870")]
	public void JCFCDEBIPMN(string EFGPCFMPHGL, TValue CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8670", Offset = "0x3EE7270", VA = "0x183EE8670", Slot = "4")]
	protected override void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3F30DF0", Offset = "0x3F2F9F0", VA = "0x183F30DF0", Slot = "5")]
	protected override void KNMNKNCCGLF(string EFGPCFMPHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5AB7B00", Offset = "0x5AB6700", VA = "0x185AB7B00")]
	public DBGDMPCHIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LDPNCHONDCB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLNGMJMHDCE();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DMENHBCMHJN(string NMDOFAJBOFG);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GGKFJHLJPCF(string NMDOFAJBOFG, int IEDAFAANJNE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NIJKAILIBMH(string NMDOFAJBOFG, int CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HGELKCDCFEH(string NMDOFAJBOFG, bool IEDAFAANJNE = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPGAPGMHCMA(string NMDOFAJBOFG, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float CALEEBLFHJD(string NMDOFAJBOFG, float IEDAFAANJNE = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PBBOAGBAPOJ(string NMDOFAJBOFG, float CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string HGNDIIOKDHA(string NMDOFAJBOFG, [Optional] string IEDAFAANJNE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GPLEJEOGPMG(string NMDOFAJBOFG, string CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime GJMOFDCPLAC(string NMDOFAJBOFG, [Optional] DateTime EABLOHJKDLL);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HDFDMBEAEDA(string NMDOFAJBOFG, DateTime EABLOHJKDLL);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long CCHKHNPGIGC(string NMDOFAJBOFG, long IEDAFAANJNE);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CBKOAIOMBJB(string NMDOFAJBOFG, long CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T IFKPIKLGHCM<T>(string NMDOFAJBOFG, T IEDAFAANJNE, FJLACOEIDDK<T> BBGIEFEBOGO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LNOHOFNLLHL<T>(string NMDOFAJBOFG, T CABLCDOIFFL, FJLACOEIDDK<T> BBGIEFEBOGO);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LLADFFBNDDF(string NMDOFAJBOFG);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task MHCAPJOGJND([Optional] CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ECHKFOGFNPL : LDPNCHONDCB
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LDECAEIJMID;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OFNMLNOEEMP(long POOPEFGIGIA, CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EJEDPNOBHBG : LDPNCHONDCB
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OGLOMBBEGAG : ECHKFOGFNPL, LDPNCHONDCB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ELNNJJMMDEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public OGLOMBBEGAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F18F60", Offset = "0x6F17B60", VA = "0x186F18F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F190F0", Offset = "0x6F17CF0", VA = "0x186F190F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EKGIHDFEMKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public OGLOMBBEGAG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6F18C10", Offset = "0x6F17810", VA = "0x186F18C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F18F00", Offset = "0x6F17B00", VA = "0x186F18F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly ECHKFOGFNPL IOJPJKDCEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly PMOHBLBGBOF FKEFKJNNLKH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F20280", Offset = "0x6F1EE80", VA = "0x186F20280", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LDECAEIJMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F990", Offset = "0x6F1E590", VA = "0x186F1F990", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FA80", Offset = "0x6F1E680", VA = "0x186F1FA80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F206D0", Offset = "0x6F1F2D0", VA = "0x186F206D0")]
	[UnityEngine.Scripting.Preserve]
	public OGLOMBBEGAG([JGAMIMHCGFI(null)] OOPAPAAJMFA CNNOFBMNGEH, [JGAMIMHCGFI("Disk_Unity")] ECHKFOGFNPL IOJPJKDCEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F201B0", Offset = "0x6F1EDB0", VA = "0x186F201B0", Slot = "8")]
	public void HLNGMJMHDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F9F0", Offset = "0x6F1E5F0", VA = "0x186F1F9F0", Slot = "9")]
	public bool DMENHBCMHJN(string NMDOFAJBOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FAF0", Offset = "0x6F1E6F0", VA = "0x186F1FAF0", Slot = "10")]
	public int GGKFJHLJPCF(string NMDOFAJBOFG, int IEDAFAANJNE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6F204E0", Offset = "0x6F1F0E0", VA = "0x186F204E0", Slot = "11")]
	public void NIJKAILIBMH(string NMDOFAJBOFG, int CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FE80", Offset = "0x6F1EA80", VA = "0x186F1FE80", Slot = "12")]
	public bool HGELKCDCFEH(string NMDOFAJBOFG, bool IEDAFAANJNE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F20210", Offset = "0x6F1EE10", VA = "0x186F20210", Slot = "13")]
	public void KPGAPGMHCMA(string NMDOFAJBOFG, bool CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F660", Offset = "0x6F1E260", VA = "0x186F1F660", Slot = "14")]
	public float CALEEBLFHJD(string NMDOFAJBOFG, float IEDAFAANJNE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F20660", Offset = "0x6F1F260", VA = "0x186F20660", Slot = "15")]
	public void PBBOAGBAPOJ(string NMDOFAJBOFG, float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F20010", Offset = "0x6F1EC10", VA = "0x186F20010", Slot = "16")]
	public string HGNDIIOKDHA(string NMDOFAJBOFG, [Optional] string IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FDA0", Offset = "0x6F1E9A0", VA = "0x186F1FDA0", Slot = "17")]
	public void GPLEJEOGPMG(string NMDOFAJBOFG, string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FC40", Offset = "0x6F1E840", VA = "0x186F1FC40", Slot = "18")]
	public DateTime GJMOFDCPLAC(string NMDOFAJBOFG, [Optional] DateTime IEDAFAANJNE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FE10", Offset = "0x6F1EA10", VA = "0x186F1FE10", Slot = "19")]
	public void HDFDMBEAEDA(string NMDOFAJBOFG, DateTime EABLOHJKDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F830", Offset = "0x6F1E430", VA = "0x186F1F830", Slot = "20")]
	public long CCHKHNPGIGC(string NMDOFAJBOFG, long IEDAFAANJNE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F7C0", Offset = "0x6F1E3C0", VA = "0x186F1F7C0", Slot = "21")]
	public void CBKOAIOMBJB(string NMDOFAJBOFG, long CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7D40", Offset = "0x2FC6940", VA = "0x182FC7D40", Slot = "22")]
	public T IFKPIKLGHCM<T>(string NMDOFAJBOFG, T IEDAFAANJNE, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8430", Offset = "0x2FC7030", VA = "0x182FC8430", Slot = "23")]
	public void LNOHOFNLLHL<T>(string NMDOFAJBOFG, T CABLCDOIFFL, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F202E0", Offset = "0x6F1EEE0", VA = "0x186F202E0", Slot = "24")]
	public void LLADFFBNDDF(string NMDOFAJBOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F203F0", Offset = "0x6F1EFF0", VA = "0x186F203F0", Slot = "25")]
	[AsyncStateMachine(typeof(ELNNJJMMDEG))]
	public Task MHCAPJOGJND([Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F20550", Offset = "0x6F1F150", VA = "0x186F20550", Slot = "6")]
	[AsyncStateMachine(typeof(EKGIHDFEMKI))]
	public Task OFNMLNOEEMP(long POOPEFGIGIA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MKLLGIEGGOK : ECHKFOGFNPL, LDPNCHONDCB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct NOAIACPFJFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MKLLGIEGGOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E370", Offset = "0x6F1CF70", VA = "0x186F1E370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E750", Offset = "0x6F1D350", VA = "0x186F1E750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PPMPBEBNLCI : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private HGHICIBNEGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public MKLLGIEGGOK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
		[DebuggerHidden]
		public PPMPBEBNLCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F22460", Offset = "0x6F21060", VA = "0x186F22460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F224D0", Offset = "0x6F210D0", VA = "0x186F224D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OOPAPAAJMFA CNNOFBMNGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool KKPNGCMEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool FJIPHLCOGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NBBNPMBEEMP JOKDCDNAGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EIIBBDFHPAD MOPDLAJOJDF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LDECAEIJMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DF40", Offset = "0x6F1CB40", VA = "0x186F1DF40")]
	[UnityEngine.Scripting.Preserve]
	public MKLLGIEGGOK([JGAMIMHCGFI(null)] OOPAPAAJMFA CNNOFBMNGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "8")]
	public void HLNGMJMHDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DE60", Offset = "0x6F1CA60", VA = "0x186F1DE60", Slot = "6")]
	public Task OFNMLNOEEMP(long POOPEFGIGIA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x13D7CF0", Offset = "0x13D68F0", VA = "0x1813D7CF0")]
	private static int AMJFEMMLEAC(bool CABLCDOIFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D8A0", Offset = "0x6F1C4A0", VA = "0x186F1D8A0", Slot = "9")]
	public bool DMENHBCMHJN(string NMDOFAJBOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D8E0", Offset = "0x6F1C4E0", VA = "0x186F1D8E0", Slot = "10")]
	public int GGKFJHLJPCF(string NMDOFAJBOFG, int IEDAFAANJNE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DE30", Offset = "0x6F1CA30", VA = "0x186F1DE30", Slot = "11")]
	public void NIJKAILIBMH(string NMDOFAJBOFG, int CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DB40", Offset = "0x6F1C740", VA = "0x186F1DB40", Slot = "12")]
	public bool HGELKCDCFEH(string NMDOFAJBOFG, bool IEDAFAANJNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DC10", Offset = "0x6F1C810", VA = "0x186F1DC10", Slot = "13")]
	public void KPGAPGMHCMA(string NMDOFAJBOFG, bool CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D730", Offset = "0x6F1C330", VA = "0x186F1D730", Slot = "14")]
	public float CALEEBLFHJD(string NMDOFAJBOFG, float IEDAFAANJNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DF10", Offset = "0x6F1CB10", VA = "0x186F1DF10", Slot = "15")]
	public void PBBOAGBAPOJ(string NMDOFAJBOFG, float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D990", Offset = "0x6F1C590", VA = "0x186F1D990", Slot = "18")]
	public DateTime GJMOFDCPLAC(string NMDOFAJBOFG, [Optional] DateTime IEDAFAANJNE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DAD0", Offset = "0x6F1C6D0", VA = "0x186F1DAD0", Slot = "19")]
	public void HDFDMBEAEDA(string NMDOFAJBOFG, DateTime EABLOHJKDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D7D0", Offset = "0x6F1C3D0", VA = "0x186F1D7D0", Slot = "20")]
	public long CCHKHNPGIGC(string NMDOFAJBOFG, long IEDAFAANJNE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D760", Offset = "0x6F1C360", VA = "0x186F1D760", Slot = "21")]
	public void CBKOAIOMBJB(string NMDOFAJBOFG, long CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2EFD830", Offset = "0x2EFC430", VA = "0x182EFD830", Slot = "22")]
	public T IFKPIKLGHCM<T>(string NMDOFAJBOFG, T IEDAFAANJNE, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2EFD830", Offset = "0x2EFC430", VA = "0x182EFD830", Slot = "23")]
	public void LNOHOFNLLHL<T>(string NMDOFAJBOFG, T CABLCDOIFFL, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC560", Offset = "0x2EFB160", VA = "0x182EFC560")]
	private T AEALCCDKNNL<T>(string NMDOFAJBOFG, T IEDAFAANJNE, [Optional] FJLACOEIDDK<T> ODGLLBDCAPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2EFD0C0", Offset = "0x2EFBCC0", VA = "0x182EFD0C0")]
	private void EHJJCHGLCFF<T>(string NMDOFAJBOFG, T CABLCDOIFFL, [Optional] FJLACOEIDDK<T> ODGLLBDCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DB70", Offset = "0x6F1C770", VA = "0x186F1DB70", Slot = "16")]
	public string HGNDIIOKDHA(string NMDOFAJBOFG, string IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DAA0", Offset = "0x6F1C6A0", VA = "0x186F1DAA0", Slot = "17")]
	public void GPLEJEOGPMG(string NMDOFAJBOFG, string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DEF0", Offset = "0x6F1CAF0", VA = "0x186F1DEF0")]
	private void OPMKBMLFOEE(string NMDOFAJBOFG, string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D8C0", Offset = "0x6F1C4C0", VA = "0x186F1D8C0")]
	private string GBMNIMCCIJD(string NMDOFAJBOFG, string IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DCB0", Offset = "0x6F1C8B0", VA = "0x186F1DCB0", Slot = "24")]
	public void LLADFFBNDDF(string NMDOFAJBOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DA00", Offset = "0x6F1C600", VA = "0x186F1DA00")]
	private string GKFIFPHFHNA(string NONKDEOLPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DD40", Offset = "0x6F1C940", VA = "0x186F1DD40", Slot = "25")]
	[AsyncStateMachine(typeof(NOAIACPFJFD))]
	public Task MHCAPJOGJND(CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D910", Offset = "0x6F1C510", VA = "0x186F1D910")]
	[IteratorStateMachine(typeof(PPMPBEBNLCI))]
	private IEnumerator<HGHICIBNEGP> GIDADLEBJOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D840", Offset = "0x6F1C440", VA = "0x186F1D840")]
	private void DLPOMDLLKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DBA0", Offset = "0x6F1C7A0", VA = "0x186F1DBA0")]
	private void KDPDOFGDHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DC40", Offset = "0x6F1C840", VA = "0x186F1DC40")]
	private void LKBJJHGMCIH(bool DLCMNFMMLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NPEAIILOHKG : ECHKFOGFNPL, LDPNCHONDCB
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
	private Dictionary<string, string> LJEPIPDKBDN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string EGMDFHMNPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EA40", Offset = "0x6F1D640", VA = "0x186F1EA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> FPKNJOAPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E990", Offset = "0x6F1D590", VA = "0x186F1E990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action LDECAEIJMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	[UnityEngine.Scripting.Preserve]
	public NPEAIILOHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "8")]
	public void HLNGMJMHDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F480", Offset = "0x6F1E080", VA = "0x186F1F480", Slot = "6")]
	public Task OFNMLNOEEMP(long POOPEFGIGIA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E7B0", Offset = "0x6F1D3B0", VA = "0x186F1E7B0", Slot = "14")]
	public float CALEEBLFHJD(string NONKDEOLPHL, float IEDAFAANJNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EDA0", Offset = "0x6F1D9A0", VA = "0x186F1EDA0", Slot = "13")]
	public void KPGAPGMHCMA(string NONKDEOLPHL, bool CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EC30", Offset = "0x6F1D830", VA = "0x186F1EC30", Slot = "12")]
	public bool HGELKCDCFEH(string NONKDEOLPHL, bool IEDAFAANJNE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E9D0", Offset = "0x6F1D5D0", VA = "0x186F1E9D0", Slot = "10")]
	public int GGKFJHLJPCF(string NONKDEOLPHL, int IEDAFAANJNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EAB0", Offset = "0x6F1D6B0", VA = "0x186F1EAB0", Slot = "18")]
	public DateTime GJMOFDCPLAC(string NMDOFAJBOFG, [Optional] DateTime IEDAFAANJNE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EBC0", Offset = "0x6F1D7C0", VA = "0x186F1EBC0", Slot = "19")]
	public void HDFDMBEAEDA(string NONKDEOLPHL, DateTime CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F510", Offset = "0x6F1E110", VA = "0x186F1F510", Slot = "15")]
	public void PBBOAGBAPOJ(string NONKDEOLPHL, float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F410", Offset = "0x6F1E010", VA = "0x186F1F410", Slot = "11")]
	public void NIJKAILIBMH(string NONKDEOLPHL, int CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E890", Offset = "0x6F1D490", VA = "0x186F1E890", Slot = "20")]
	public long CCHKHNPGIGC(string NMDOFAJBOFG, long IEDAFAANJNE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E820", Offset = "0x6F1D420", VA = "0x186F1E820", Slot = "21")]
	public void CBKOAIOMBJB(string NMDOFAJBOFG, long CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2B90500", Offset = "0x2B8F100", VA = "0x182B90500", Slot = "22")]
	public T IFKPIKLGHCM<T>(string NMDOFAJBOFG, T IEDAFAANJNE, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B90500", Offset = "0x2B8F100", VA = "0x182B90500", Slot = "23")]
	public void LNOHOFNLLHL<T>(string NMDOFAJBOFG, T CABLCDOIFFL, FJLACOEIDDK<T> BBGIEFEBOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ECF0", Offset = "0x6F1D8F0", VA = "0x186F1ECF0", Slot = "16")]
	public string HGNDIIOKDHA(string NONKDEOLPHL, string IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EB20", Offset = "0x6F1D720", VA = "0x186F1EB20", Slot = "17")]
	public void GPLEJEOGPMG(string NONKDEOLPHL, string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EE10", Offset = "0x6F1DA10", VA = "0x186F1EE10", Slot = "24")]
	public void LLADFFBNDDF(string NONKDEOLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E900", Offset = "0x6F1D500", VA = "0x186F1E900", Slot = "9")]
	public bool DMENHBCMHJN(string NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EED0", Offset = "0x6F1DAD0", VA = "0x186F1EED0", Slot = "25")]
	public Task MHCAPJOGJND(CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AE50", Offset = "0x2F89A50", VA = "0x182F8AE50")]
	private T IBIJBNAFKLE<T>(string NMDOFAJBOFG, T IEDAFAANJNE, [Optional] FJLACOEIDDK<T> ODGLLBDCAPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2F89E40", Offset = "0x2F88A40", VA = "0x182F89E40")]
	private void GAOLHIMCFIN<T>(string NMDOFAJBOFG, T CABLCDOIFFL, [Optional] FJLACOEIDDK<T> ODGLLBDCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F130", Offset = "0x6F1DD30", VA = "0x186F1F130")]
	private Dictionary<string, string> MOJFJFKIGFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HCOCEAMGNIJ
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LDECAEIJMID;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLNGMJMHDCE();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DABMGEALPCM(long POOPEFGIGIA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EDLFECFPCPL(JBNCBGIFMGD PAFIPCDPFAO = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OMHLOODBODA(string NMDOFAJBOFG, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool APHENDEJJGC(string NMDOFAJBOFG, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string EONHBELBLHJ(string NMDOFAJBOFG, [Optional] string IEDAFAANJNE, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MKBLPAGAGKI BMMLMGAALEK(string NMDOFAJBOFG, string CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int HCDDBOPMMDH(string NMDOFAJBOFG, int IEDAFAANJNE = 0, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MKBLPAGAGKI AKLEGFEDJMC(string NMDOFAJBOFG, int CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EMFFFKBBMOB(string NMDOFAJBOFG, bool IEDAFAANJNE, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MKBLPAGAGKI PGMOLOBHLPI(string NMDOFAJBOFG, bool CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float LOKAEPBBCEK(string NMDOFAJBOFG, float IEDAFAANJNE = 0f, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MKBLPAGAGKI NOOMIIICIOJ(string NMDOFAJBOFG, float CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime GPDNDEKMKBO(string NMDOFAJBOFG, [Optional] DateTime IEDAFAANJNE, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MKBLPAGAGKI DPHNBJPDKOM(string NMDOFAJBOFG, DateTime CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long IJGHBKCOGNC(string NMDOFAJBOFG, long IEDAFAANJNE = 0L, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	MKBLPAGAGKI FCHJDAPLIBG(string NMDOFAJBOFG, long CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T BFOFJLAIJDG<T>(string NMDOFAJBOFG, [Optional] T IEDAFAANJNE, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	MKBLPAGAGKI BKIDMAFCKMN<T>(string NMDOFAJBOFG, T CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool KMMCHEPIIDI(string NMDOFAJBOFG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool BJDOBNIOOHO(string NMDOFAJBOFG);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string NFPFJEKBAGE(string NMDOFAJBOFG, [Optional] string IEDAFAANJNE);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MKBLPAGAGKI FOIPKGNLOHL(string NMDOFAJBOFG, string CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int BPMKLPJPLNL(string NMDOFAJBOFG, int IEDAFAANJNE = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MKBLPAGAGKI NMNOBFFNGHJ(string NMDOFAJBOFG, int CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool NCJMJOFDICO(string NMDOFAJBOFG, bool IEDAFAANJNE);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	MKBLPAGAGKI OHIJOECADGD(string NMDOFAJBOFG, bool CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float OFGLKKOJMEN(string NMDOFAJBOFG, float IEDAFAANJNE = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	MKBLPAGAGKI KGNKNOOAGGJ(string NMDOFAJBOFG, float CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime MGGOKENDHNC(string NMDOFAJBOFG, [Optional] DateTime IEDAFAANJNE);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	MKBLPAGAGKI LHKAAKBGEMJ(string NMDOFAJBOFG, DateTime CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long MBAGHKGLDNK(string NMDOFAJBOFG, long IEDAFAANJNE = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	MKBLPAGAGKI PJCGBHOMDPC(string NMDOFAJBOFG, long CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void AKNFLLBELPE<T>(FJLACOEIDDK<T> BBGIEFEBOGO, [Optional] IEqualityComparer<T> DMMDHIPDEFD);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MPOPNELLJEG<T>();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable MBGHFKNMLOO();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FLKDLHLIINM(float KEFCDGNOKGL);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task DLPOMDLLKNM([Optional] CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum MKBLPAGAGKI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FALFHHGPLEG : HCOCEAMGNIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class GFBIECBIJIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected static readonly HashSet<GFBIECBIJIG> FAKBEHJOGBG;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C460", Offset = "0x6F1B060", VA = "0x186F1C460")]
		public static void PFKFMPEAACJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ANKOMBFBDGF();

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		protected GFBIECBIJIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class DKAKDIJPFMK<T> : GFBIECBIJIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly DKAKDIJPFMK<T> AAGIFLNDKEI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FJLACOEIDDK<T> COKNAAPEGDP
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> GPMCOFJGJNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PDLKFHFOMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3A59A90", Offset = "0x3A58690", VA = "0x183A59A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5AFA3B0", Offset = "0x5AF8FB0", VA = "0x185AFA3B0")]
		private DKAKDIJPFMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5AF9D70", Offset = "0x5AF8970", VA = "0x185AF9D70")]
		public void PEGPHNFMEDB(FJLACOEIDDK<T> ODGLLBDCAPA, [Optional] IEqualityComparer<T> DMMDHIPDEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5AF9CE0", Offset = "0x5AF88E0", VA = "0x185AF9CE0", Slot = "4")]
		public override void ANKOMBFBDGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class OGEAMHPPLGM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly FALFHHGPLEG HLCNLJHDNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly object PIGDMBFJHAO;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F5B0", Offset = "0x6F1E1B0", VA = "0x186F1F5B0")]
		public OGEAMHPPLGM(FALFHHGPLEG HLCNLJHDNMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F580", Offset = "0x6F1E180", VA = "0x186F1F580", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct NANLPKHJODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public FALFHHGPLEG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6F1E030", Offset = "0x6F1CC30", VA = "0x186F1E030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E310", Offset = "0x6F1CF10", VA = "0x186F1E310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct FELLFMAEOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FALFHHGPLEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LDPNCHONDCB backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C2D0", Offset = "0x6F1AED0", VA = "0x186F1C2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct KJLOLBKGJKJ : IAsyncStateMachine
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
		public FALFHHGPLEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D120", Offset = "0x6F1BD20", VA = "0x186F1D120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D5F0", Offset = "0x6F1C1F0", VA = "0x186F1D5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LFEBGILJDDM : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private HGHICIBNEGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public FALFHHGPLEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
		[DebuggerHidden]
		public LFEBGILJDDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D650", Offset = "0x6F1C250", VA = "0x186F1D650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D6E0", Offset = "0x6F1C2E0", VA = "0x186F1D6E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly ECHKFOGFNPL FAGGALDDBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly ECHKFOGFNPL CCOKIINGIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EJEDPNOBHBG MKKFFPGMAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly NBBNPMBEEMP JOKDCDNAGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly AEELMLFEKIC.BDOFPNACHGH DBDAHEDMICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GFFNOHKJGNM ILBPBIJJKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HashSet<LDPNCHONDCB> BJJODIJOGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Task GKIHPDPBLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<string, string> AHKBDHNLOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EIIBBDFHPAD LJPCBJAMJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly object FPADJGCOABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly object LMGHKMFBPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private long JLJDCDAFFNB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool DNMHAGHLAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F19CD0", Offset = "0x6F188D0", VA = "0x186F19CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource PBCDAGLIKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x88C740", Offset = "0x88B340", VA = "0x18088C740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x88C6D0", Offset = "0x88B2D0", VA = "0x18088C6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action LDECAEIJMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F198C0", Offset = "0x6F184C0", VA = "0x186F198C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A750", Offset = "0x6F19350", VA = "0x186F1A750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BE90", Offset = "0x6F1AA90", VA = "0x186F1BE90")]
	[BOLBLOCFHKO.ENGLBNKHCKK]
	internal static void PKCPHNKIBBJ(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BF00", Offset = "0x6F1AB00", VA = "0x186F1BF00")]
	[UnityEngine.Scripting.Preserve]
	public FALFHHGPLEG([JGAMIMHCGFI("Disk")] ECHKFOGFNPL FAGGALDDBAE, [JGAMIMHCGFI("Cloud")] ECHKFOGFNPL CCOKIINGIAD, [JGAMIMHCGFI(null)] EJEDPNOBHBG MKKFFPGMAMM, [JGAMIMHCGFI(null)] NBBNPMBEEMP JOKDCDNAGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A110", Offset = "0x6F18D10", VA = "0x186F1A110", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A6D0", Offset = "0x6F192D0", VA = "0x186F1A6D0")]
	private void FMNKJFMCKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ACD0", Offset = "0x6F198D0", VA = "0x186F1ACD0", Slot = "6")]
	public void HLNGMJMHDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6F19B00", Offset = "0x6F18700", VA = "0x186F19B00", Slot = "7")]
	public Task DABMGEALPCM(long POOPEFGIGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ABC0", Offset = "0x6F197C0", VA = "0x186F1ABC0")]
	[AsyncStateMachine(typeof(NANLPKHJODI))]
	private Task HEENPMFIJFL(long POOPEFGIGIA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B150", Offset = "0x6F19D50", VA = "0x186F1B150")]
	private void LFKLIDPCHND(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AD70", Offset = "0x6F19970", VA = "0x186F1AD70")]
	private void IBANCMPNGHM(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6F19AA0", Offset = "0x6F186A0", VA = "0x186F19AA0")]
	private string CPPJGILNDAC(string HKCLEGJNLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BA00", Offset = "0x6F1A600", VA = "0x186F1BA00")]
	private void OAPFMPCJPMC(JBNCBGIFMGD PAFIPCDPFAO, string NONKDEOLPHL, [Out] ECHKFOGFNPL AFGMFLLEFFO, [Out] string DCDNOEOMLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ADF0", Offset = "0x6F199F0", VA = "0x186F1ADF0")]
	private ECHKFOGFNPL IECLHMCKDIN(JBNCBGIFMGD PAFIPCDPFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A150", Offset = "0x6F18D50", VA = "0x186F1A150", Slot = "8")]
	public bool EDLFECFPCPL(JBNCBGIFMGD PAFIPCDPFAO = JBNCBGIFMGD.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BC40", Offset = "0x6F1A840", VA = "0x186F1BC40", Slot = "9")]
	public bool OMHLOODBODA(string NMDOFAJBOFG, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6F19410", Offset = "0x6F18010", VA = "0x186F19410", Slot = "10")]
	public bool APHENDEJJGC(string NMDOFAJBOFG, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A2C0", Offset = "0x6F18EC0", VA = "0x186F1A2C0", Slot = "11")]
	public string EONHBELBLHJ(string NMDOFAJBOFG, [Optional] string IEDAFAANJNE, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F19550", Offset = "0x6F18150", VA = "0x186F19550", Slot = "12")]
	public MKBLPAGAGKI BMMLMGAALEK(string NMDOFAJBOFG, string CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AB10", Offset = "0x6F19710", VA = "0x186F1AB10", Slot = "13")]
	public int HCDDBOPMMDH(string NMDOFAJBOFG, int IEDAFAANJNE = 0, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6F19290", Offset = "0x6F17E90", VA = "0x186F19290", Slot = "14")]
	public MKBLPAGAGKI AKLEGFEDJMC(string NMDOFAJBOFG, int CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A210", Offset = "0x6F18E10", VA = "0x186F1A210", Slot = "15")]
	public bool EMFFFKBBMOB(string NMDOFAJBOFG, bool IEDAFAANJNE, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BCE0", Offset = "0x6F1A8E0", VA = "0x186F1BCE0", Slot = "16")]
	public MKBLPAGAGKI PGMOLOBHLPI(string NMDOFAJBOFG, bool CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B2F0", Offset = "0x6F19EF0", VA = "0x186F1B2F0", Slot = "17")]
	public float LOKAEPBBCEK(string NMDOFAJBOFG, float IEDAFAANJNE = 0f, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B880", Offset = "0x6F1A480", VA = "0x186F1B880", Slot = "18")]
	public MKBLPAGAGKI NOOMIIICIOJ(string NMDOFAJBOFG, float CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AA70", Offset = "0x6F19670", VA = "0x186F1AA70", Slot = "19")]
	public DateTime GPDNDEKMKBO(string NMDOFAJBOFG, [Optional] DateTime IEDAFAANJNE, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6F19F60", Offset = "0x6F18B60", VA = "0x186F19F60", Slot = "20")]
	public MKBLPAGAGKI DPHNBJPDKOM(string NMDOFAJBOFG, DateTime CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AE70", Offset = "0x6F19A70", VA = "0x186F1AE70", Slot = "21")]
	public long IJGHBKCOGNC(string NMDOFAJBOFG, long IEDAFAANJNE = 0L, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A360", Offset = "0x6F18F60", VA = "0x186F1A360", Slot = "22")]
	public MKBLPAGAGKI FCHJDAPLIBG(string NMDOFAJBOFG, long CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6BD0", Offset = "0x2DE57D0", VA = "0x182DE6BD0", Slot = "23")]
	public T BFOFJLAIJDG<T>(string NMDOFAJBOFG, [Optional] T IEDAFAANJNE, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6BD0", Offset = "0x2DE57D0", VA = "0x182DE6BD0", Slot = "24")]
	public MKBLPAGAGKI BKIDMAFCKMN<T>(string NMDOFAJBOFG, T CABLCDOIFFL, JBNCBGIFMGD EIOJGLNMOKE = JBNCBGIFMGD.CLOUD)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B0F0", Offset = "0x6F19CF0", VA = "0x186F1B0F0", Slot = "25")]
	public bool KMMCHEPIIDI(string NMDOFAJBOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6F19540", Offset = "0x6F18140", VA = "0x186F19540", Slot = "26")]
	public bool BJDOBNIOOHO(string NMDOFAJBOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B7E0", Offset = "0x6F1A3E0", VA = "0x186F1B7E0", Slot = "27")]
	public string NFPFJEKBAGE(string NMDOFAJBOFG, [Optional] string IEDAFAANJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A720", Offset = "0x6F19320", VA = "0x186F1A720", Slot = "28")]
	public MKBLPAGAGKI FOIPKGNLOHL(string NMDOFAJBOFG, string CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6F196E0", Offset = "0x6F182E0", VA = "0x186F196E0", Slot = "29")]
	public int BPMKLPJPLNL(string NMDOFAJBOFG, int IEDAFAANJNE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B850", Offset = "0x6F1A450", VA = "0x186F1B850", Slot = "30")]
	public MKBLPAGAGKI NMNOBFFNGHJ(string NMDOFAJBOFG, int CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B770", Offset = "0x6F1A370", VA = "0x186F1B770", Slot = "31")]
	public bool NCJMJOFDICO(string NMDOFAJBOFG, bool IEDAFAANJNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BC10", Offset = "0x6F1A810", VA = "0x186F1BC10", Slot = "32")]
	public MKBLPAGAGKI OHIJOECADGD(string NMDOFAJBOFG, bool CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BBA0", Offset = "0x6F1A7A0", VA = "0x186F1BBA0", Slot = "33")]
	public float OFGLKKOJMEN(string NMDOFAJBOFG, float IEDAFAANJNE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B0C0", Offset = "0x6F19CC0", VA = "0x186F1B0C0", Slot = "34")]
	public MKBLPAGAGKI KGNKNOOAGGJ(string NMDOFAJBOFG, float CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B4F0", Offset = "0x6F1A0F0", VA = "0x186F1B4F0", Slot = "35")]
	public DateTime MGGOKENDHNC(string NMDOFAJBOFG, [Optional] DateTime IEDAFAANJNE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B170", Offset = "0x6F19D70", VA = "0x186F1B170", Slot = "36")]
	public MKBLPAGAGKI LHKAAKBGEMJ(string NMDOFAJBOFG, DateTime CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B3A0", Offset = "0x6F19FA0", VA = "0x186F1B3A0", Slot = "37")]
	public long MBAGHKGLDNK(string NMDOFAJBOFG, long IEDAFAANJNE = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BE60", Offset = "0x6F1AA60", VA = "0x186F1BE60", Slot = "38")]
	public MKBLPAGAGKI PJCGBHOMDPC(string NMDOFAJBOFG, long CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B060", Offset = "0x6F19C60", VA = "0x186F1B060")]
	private bool JDMEFMEBGEC(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6F19E70", Offset = "0x6F18A70", VA = "0x186F19E70")]
	private bool DPBKFMGBNJA(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AF10", Offset = "0x6F19B10", VA = "0x186F1AF10")]
	private MKBLPAGAGKI JCPNBNOHLKF(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, string CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6F19960", Offset = "0x6F18560", VA = "0x186F19960")]
	private MKBLPAGAGKI CMCLHGEMOPC(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, int CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B630", Offset = "0x6F1A230", VA = "0x186F1B630")]
	private MKBLPAGAGKI NBPNLLIBHGI(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, bool CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B1A0", Offset = "0x6F19DA0", VA = "0x186F1B1A0")]
	private MKBLPAGAGKI LMDEENOGIOG(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, float CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6F19750", Offset = "0x6F18350", VA = "0x186F19750")]
	private MKBLPAGAGKI CACNAFHGACJ(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, DateTime CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F19150", Offset = "0x6F17D50", VA = "0x186F19150")]
	private MKBLPAGAGKI ADPAGDPAIBE(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, long CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7D00", Offset = "0x2DE6900", VA = "0x182DE7D00")]
	private T NDPECGFAAAC<T>(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, T IEDAFAANJNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6F30", Offset = "0x2DE5B30", VA = "0x182DE6F30")]
	private MKBLPAGAGKI EEOCDFJIHOG<T>(LDPNCHONDCB AFGMFLLEFFO, string NMDOFAJBOFG, T CABLCDOIFFL)
	{
		return default(MKBLPAGAGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6B20", Offset = "0x2DE5720", VA = "0x182DE6B20", Slot = "39")]
	public void AKNFLLBELPE<T>(FJLACOEIDDK<T> BBGIEFEBOGO, [Optional] IEqualityComparer<T> DMMDHIPDEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7C80", Offset = "0x2DE6880", VA = "0x182DE7C80", Slot = "40")]
	public void MPOPNELLJEG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B560", Offset = "0x6F1A160", VA = "0x186F1B560")]
	[AsyncStateMachine(typeof(FELLFMAEOGM))]
	private void MHCAPJOGJND(LDPNCHONDCB LKLHIDAPJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6F19CF0", Offset = "0x6F188F0", VA = "0x186F19CF0", Slot = "43")]
	[AsyncStateMachine(typeof(KJLOLBKGJKJ))]
	public Task DLPOMDLLKNM([Optional] CancellationToken DGGGDIFONNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A4E0", Offset = "0x6F190E0", VA = "0x186F1A4E0")]
	private void FDCJPLHCJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B410", Offset = "0x6F1A010", VA = "0x186F1B410", Slot = "41")]
	public IDisposable MBGHFKNMLOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A6C0", Offset = "0x6F192C0", VA = "0x186F1A6C0", Slot = "42")]
	public void FLKDLHLIINM(float KEFCDGNOKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A7F0", Offset = "0x6F193F0", VA = "0x186F1A7F0")]
	private void GIFCEBIPKDM(float BHDKMNHGFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6F19DE0", Offset = "0x6F189E0", VA = "0x186F19DE0")]
	[IteratorStateMachine(typeof(LFEBGILJDDM))]
	private IEnumerator<HGHICIBNEGP> DOKACJDCJON(float KEFCDGNOKGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AD40", Offset = "0x6F19940", VA = "0x186F1AD40")]
	[CompilerGenerated]
	private void HMIGIPBHMBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KJFIHGCBGON : EPBLMOPKMBJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static KJFIHGCBGON AAGIFLNDKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CC90", Offset = "0x6F1B890", VA = "0x186F1CC90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CF60", Offset = "0x6F1BB60", VA = "0x186F1CF60", Slot = "9")]
	public override string IMPFBNFMBKJ(bool GKMKPBACAOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CCE0", Offset = "0x6F1B8E0", VA = "0x186F1CCE0", Slot = "10")]
	protected override bool EDEPEOFHMAG(string GKMKPBACAOC, [Out] bool CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D0E0", Offset = "0x6F1BCE0", VA = "0x186F1D0E0")]
	public KJFIHGCBGON()
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
