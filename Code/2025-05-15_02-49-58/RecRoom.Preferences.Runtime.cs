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
		[Cpp2IlInjected.Address(RVA = "0x7FD32C0", Offset = "0x7FD18C0", VA = "0x187FD32C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KAPLCGNEGKI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class ILKICLAKLCI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void FMPKBOPEANH(EJAEICGHADP NEIAGIIAPIA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC7A0", Offset = "0x7FCADA0", VA = "0x187FCC7A0")]
	private static void PJPHEHGADLN(EJAEICGHADP NEIAGIIAPIA, FMPKBOPEANH LBNAINNHMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC640", Offset = "0x7FCAC40", VA = "0x187FCC640")]
	public static bool OOOLGFFFLFM(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC230", Offset = "0x7FCA830", VA = "0x187FCC230")]
	public static OFLEGLNACKE MOPLEPLKHLB(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, string OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBE60", Offset = "0x7FCA460", VA = "0x187FCBE60")]
	public static OFLEGLNACKE DGCBKIOFEDE(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, int OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC380", Offset = "0x7FCA980", VA = "0x187FCC380")]
	public static OFLEGLNACKE NINNJAGJEMI(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, bool OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC0E0", Offset = "0x7FCA6E0", VA = "0x187FCC0E0")]
	public static OFLEGLNACKE KGJMKPIBECB(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, float OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC4D0", Offset = "0x7FCAAD0", VA = "0x187FCC4D0")]
	public static OFLEGLNACKE OKEJGLLIFLF(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, DateTime OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBFA0", Offset = "0x7FCA5A0", VA = "0x187FCBFA0")]
	public static OFLEGLNACKE GABIKIFAGMI(this EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, long OHLIHBDBKCE, [Optional] FMPKBOPEANH LBNAINNHMLH)
	{
		return default(OFLEGLNACKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PEAICNOAJON : MGBMDHHJOAM, EJAEICGHADP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FPBNEHFKCNA MAIHMBHHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> IPLBPMAIKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> HCIMFFEAFJD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> ECNEIEJJBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1800", Offset = "0x7FCFE00", VA = "0x187FD1800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3140", Offset = "0x7FD1740", VA = "0x187FD3140")]
	[UnityEngine.Scripting.Preserve]
	public PEAICNOAJON([DJIFKCCBBND(null)] FPBNEHFKCNA MAIHMBHHHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "8")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FD18B0", Offset = "0x7FCFEB0", VA = "0x187FD18B0")]
	private DirectoryInfo FLJLDGCBABH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1B90", Offset = "0x7FD0190", VA = "0x187FD1B90", Slot = "6")]
	public Task HGDKFAJHECN(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1840", Offset = "0x7FCFE40", VA = "0x187FD1840", Slot = "14")]
	public float EPIJGHEEOEF(string OEHHKNIGGMI, float JMMNJNFGHEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3010", Offset = "0x7FD1610", VA = "0x187FD3010", Slot = "13")]
	public void OFNIIOFAJPM(string OEHHKNIGGMI, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3080", Offset = "0x7FD1680", VA = "0x187FD3080", Slot = "12")]
	public bool OKLGNCIFKBA(string OEHHKNIGGMI, bool JMMNJNFGHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2FA0", Offset = "0x7FD15A0", VA = "0x187FD2FA0", Slot = "10")]
	public int NNOIHJGKKGM(string OEHHKNIGGMI, int JMMNJNFGHEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2420", Offset = "0x7FD0A20", VA = "0x187FD2420", Slot = "18")]
	public DateTime JEBJDLKHGKI(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2690", Offset = "0x7FD0C90", VA = "0x187FD2690", Slot = "19")]
	public void KCEJNGCHGLO(string OEHHKNIGGMI, DateTime OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2B70", Offset = "0x7FD1170", VA = "0x187FD2B70", Slot = "15")]
	public void NAAAPAAPMMK(string OEHHKNIGGMI, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1790", Offset = "0x7FCFD90", VA = "0x187FD1790", Slot = "11")]
	public void CMIPEDDPBGD(string OEHHKNIGGMI, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD15D0", Offset = "0x7FCFBD0", VA = "0x187FD15D0", Slot = "20")]
	public long BDDFBMHAGNG(string DEMJFJNLMJF, long JMMNJNFGHEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1B20", Offset = "0x7FD0120", VA = "0x187FD1B20", Slot = "21")]
	public void GPFDAIOONLG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x36D30A0", Offset = "0x36D16A0", VA = "0x1836D30A0", Slot = "22")]
	public T EOAGGJBDPDM<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x36D30A0", Offset = "0x36D16A0", VA = "0x1836D30A0", Slot = "23")]
	public void HJDBHKMHDFP<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2790", Offset = "0x7FD0D90", VA = "0x187FD2790", Slot = "16")]
	public string LEEDJCCMEMN(string OEHHKNIGGMI, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FD19B0", Offset = "0x7FCFFB0", VA = "0x187FD19B0", Slot = "17")]
	public void GBEIMMODMEC(string OEHHKNIGGMI, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1640", Offset = "0x7FCFC40", VA = "0x187FD1640", Slot = "24")]
	public void BPKBPKIGDMC(string OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2700", Offset = "0x7FD0D00", VA = "0x187FD2700", Slot = "9")]
	public bool KKKODMEFLHH(string OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2840", Offset = "0x7FD0E40", VA = "0x187FD2840", Slot = "25")]
	public Task LKBHDLALJNO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2BE0", Offset = "0x7FD11E0", VA = "0x187FD2BE0")]
	private void NCFKIEPADPI(DirectoryInfo GOCPDDDHFNC, string IOHNDODJOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2490", Offset = "0x7FD0A90", VA = "0x187FD2490")]
	private static string JFCFMPHHCKC(string OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1A20", Offset = "0x7FD0020", VA = "0x187FD1A20")]
	private static string GNHKHELCLNK(byte[] ACDPPDBEDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A0DF90", Offset = "0x3A0C590", VA = "0x183A0DF90")]
	private T PHDCGNDDLGA<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A0CE50", Offset = "0x3A0B450", VA = "0x183A0CE50")]
	private void DGBNDJBCMEF<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1C20", Offset = "0x7FD0220", VA = "0x187FD1C20")]
	private Dictionary<string, string> ICCEALGLFHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class AIKCFMNJEFH
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA3F0", Offset = "0x7FC89F0", VA = "0x187FCA3F0")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL NELIKBMJKPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JMGOCDGAGLG : MODBBAKCKIL
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC820", Offset = "0x7FCAE20", VA = "0x187FCC820")]
	[UnityEngine.Scripting.Preserve]
	public JMGOCDGAGLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MODBBAKCKIL : MGBMDHHJOAM, EJAEICGHADP, MIGPCMLOJNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> PECILHDMMBI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "8")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FD08B0", Offset = "0x7FCEEB0", VA = "0x187FD08B0", Slot = "6")]
	public Task HGDKFAJHECN(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0A00", Offset = "0x7FCF000", VA = "0x187FD0A00", Slot = "9")]
	public bool KKKODMEFLHH(string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0BB0", Offset = "0x7FCF1B0", VA = "0x187FD0BB0", Slot = "10")]
	public int NNOIHJGKKGM(string DEMJFJNLMJF, int JMMNJNFGHEP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0730", Offset = "0x7FCED30", VA = "0x187FD0730", Slot = "11")]
	public void CMIPEDDPBGD(string DEMJFJNLMJF, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0C70", Offset = "0x7FCF270", VA = "0x187FD0C70", Slot = "12")]
	public bool OKLGNCIFKBA(string DEMJFJNLMJF, bool JMMNJNFGHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0C10", Offset = "0x7FCF210", VA = "0x187FD0C10", Slot = "13")]
	public void OFNIIOFAJPM(string DEMJFJNLMJF, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0790", Offset = "0x7FCED90", VA = "0x187FD0790", Slot = "14")]
	public float EPIJGHEEOEF(string DEMJFJNLMJF, float JMMNJNFGHEP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0B50", Offset = "0x7FCF150", VA = "0x187FD0B50", Slot = "15")]
	public void NAAAPAAPMMK(string DEMJFJNLMJF, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0A60", Offset = "0x7FCF060", VA = "0x187FD0A60", Slot = "16")]
	public string LEEDJCCMEMN(string DEMJFJNLMJF, [Optional] string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD07F0", Offset = "0x7FCEDF0", VA = "0x187FD07F0", Slot = "17")]
	public void GBEIMMODMEC(string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0940", Offset = "0x7FCEF40", VA = "0x187FD0940", Slot = "18")]
	public DateTime JEBJDLKHGKI(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD09A0", Offset = "0x7FCEFA0", VA = "0x187FD09A0", Slot = "19")]
	public void KCEJNGCHGLO(string DEMJFJNLMJF, DateTime OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0670", Offset = "0x7FCEC70", VA = "0x187FD0670", Slot = "20")]
	public long BDDFBMHAGNG(string DEMJFJNLMJF, long JMMNJNFGHEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0850", Offset = "0x7FCEE50", VA = "0x187FD0850", Slot = "21")]
	public void GPFDAIOONLG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3944140", Offset = "0x3942740", VA = "0x183944140", Slot = "22")]
	public T EOAGGJBDPDM<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3944260", Offset = "0x3942860", VA = "0x183944260", Slot = "23")]
	public void HJDBHKMHDFP<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3944340", Offset = "0x3942940", VA = "0x183944340")]
	public T PHDCGNDDLGA<T>(string DEMJFJNLMJF, T JMMNJNFGHEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3943C50", Offset = "0x3942250", VA = "0x183943C50")]
	public void DGBNDJBCMEF<T>(string DEMJFJNLMJF, T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FD06D0", Offset = "0x7FCECD0", VA = "0x187FD06D0", Slot = "24")]
	public void BPKBPKIGDMC(string DEMJFJNLMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0AC0", Offset = "0x7FCF0C0", VA = "0x187FD0AC0", Slot = "25")]
	public Task LKBHDLALJNO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC820", Offset = "0x7FCAE20", VA = "0x187FCC820")]
	public MODBBAKCKIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class HEEJMFLFJHJ<TParent> where TParent : EJAEICGHADP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<HEEJMFLFJHJ<TParent>> MHPPHMLLBNA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4B09200", Offset = "0x4B07800", VA = "0x184B09200")]
	protected HEEJMFLFJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void INBDHNEFJBE();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void ONNIHLLFAHE(string OEHHKNIGGMI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4B08C60", Offset = "0x4B07260", VA = "0x184B08C60")]
	public static void BKAALCDLOJI(string OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4B08EA0", Offset = "0x4B074A0", VA = "0x184B08EA0")]
	public static void JKEPHKCGLAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DFINGDOPMFC<TParent, TValue> : HEEJMFLFJHJ<TParent> where TParent : EJAEICGHADP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DFINGDOPMFC<TParent, TValue> OPJKGEJPJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> DDCEHMKDAOE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A5C0", Offset = "0x6A38BC0", VA = "0x186A3A5C0")]
	public bool LKMKPGKLGLC(string KBMOAEOFKJM, [Out] TValue HOPGKAFMGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A4B0", Offset = "0x6A38AB0", VA = "0x186A3A4B0")]
	public void CDGBJDHGNGE(string KBMOAEOFKJM, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4ABB180", Offset = "0x4AB9780", VA = "0x184ABB180", Slot = "4")]
	protected override void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x49ACF80", Offset = "0x49AB580", VA = "0x1849ACF80", Slot = "5")]
	protected override void ONNIHLLFAHE(string KBMOAEOFKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A750", Offset = "0x6A38D50", VA = "0x186A3A750")]
	public DFINGDOPMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EJAEICGHADP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJHPANODDAM();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KKKODMEFLHH(string DEMJFJNLMJF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NNOIHJGKKGM(string DEMJFJNLMJF, int JMMNJNFGHEP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CMIPEDDPBGD(string DEMJFJNLMJF, int OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OKLGNCIFKBA(string DEMJFJNLMJF, bool JMMNJNFGHEP = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OFNIIOFAJPM(string DEMJFJNLMJF, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float EPIJGHEEOEF(string DEMJFJNLMJF, float JMMNJNFGHEP = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NAAAPAAPMMK(string DEMJFJNLMJF, float OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string LEEDJCCMEMN(string DEMJFJNLMJF, [Optional] string JMMNJNFGHEP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GBEIMMODMEC(string DEMJFJNLMJF, string OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime JEBJDLKHGKI(string DEMJFJNLMJF, [Optional] DateTime PLBAFGHLBPJ);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KCEJNGCHGLO(string DEMJFJNLMJF, DateTime PLBAFGHLBPJ);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long BDDFBMHAGNG(string DEMJFJNLMJF, long JMMNJNFGHEP);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GPFDAIOONLG(string DEMJFJNLMJF, long OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T EOAGGJBDPDM<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, NBHJDEFAJJO<T> BAGAKFJAGLG);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HJDBHKMHDFP<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, NBHJDEFAJJO<T> BAGAKFJAGLG);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BPKBPKIGDMC(string DEMJFJNLMJF);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task LKBHDLALJNO([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MGBMDHHJOAM : EJAEICGHADP
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MFALNFFKHGE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HGDKFAJHECN(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MIGPCMLOJNH : EJAEICGHADP
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OBJLGMNGAGE : MGBMDHHJOAM, EJAEICGHADP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ICEPJNDOHNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OBJLGMNGAGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCBA30", Offset = "0x7FCA030", VA = "0x187FCBA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FCBE00", Offset = "0x7FCA400", VA = "0x187FCBE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DBEMGJPFFOO : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public OBJLGMNGAGE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public DBEMGJPFFOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA9E0", Offset = "0x7FC8FE0", VA = "0x187FCA9E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAA50", Offset = "0x7FC9050", VA = "0x187FCAA50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FPBNEHFKCNA MAIHMBHHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool LMECHOMFIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool KBDHOAKELMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GJPCEPMOONC PCPLHHLNPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OLILOOIADED KPKLMHDDHBL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD14E0", Offset = "0x7FCFAE0", VA = "0x187FD14E0")]
	[UnityEngine.Scripting.Preserve]
	public OBJLGMNGAGE([DJIFKCCBBND(null)] FPBNEHFKCNA MAIHMBHHHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "8")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0FF0", Offset = "0x7FCF5F0", VA = "0x187FD0FF0", Slot = "6")]
	public Task HGDKFAJHECN(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1AE41D0", Offset = "0x1AE27D0", VA = "0x181AE41D0")]
	private static int IKPOKDMPCLN(bool OHLIHBDBKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1250", Offset = "0x7FCF850", VA = "0x187FD1250", Slot = "9")]
	public bool KKKODMEFLHH(string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1450", Offset = "0x7FCFA50", VA = "0x187FD1450", Slot = "10")]
	public int NNOIHJGKKGM(string DEMJFJNLMJF, int JMMNJNFGHEP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0DD0", Offset = "0x7FCF3D0", VA = "0x187FD0DD0", Slot = "11")]
	public void CMIPEDDPBGD(string DEMJFJNLMJF, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FD14B0", Offset = "0x7FCFAB0", VA = "0x187FD14B0", Slot = "12")]
	public bool OKLGNCIFKBA(string DEMJFJNLMJF, bool JMMNJNFGHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1480", Offset = "0x7FCFA80", VA = "0x187FD1480", Slot = "13")]
	public void OFNIIOFAJPM(string DEMJFJNLMJF, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0F20", Offset = "0x7FCF520", VA = "0x187FD0F20", Slot = "14")]
	public float EPIJGHEEOEF(string DEMJFJNLMJF, float JMMNJNFGHEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FD13B0", Offset = "0x7FCF9B0", VA = "0x187FD13B0", Slot = "15")]
	public void NAAAPAAPMMK(string DEMJFJNLMJF, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1100", Offset = "0x7FCF700", VA = "0x187FD1100", Slot = "18")]
	public DateTime JEBJDLKHGKI(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FD11E0", Offset = "0x7FCF7E0", VA = "0x187FD11E0", Slot = "19")]
	public void KCEJNGCHGLO(string DEMJFJNLMJF, DateTime PLBAFGHLBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0CD0", Offset = "0x7FCF2D0", VA = "0x187FD0CD0", Slot = "20")]
	public long BDDFBMHAGNG(string DEMJFJNLMJF, long JMMNJNFGHEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0F80", Offset = "0x7FCF580", VA = "0x187FD0F80", Slot = "21")]
	public void GPFDAIOONLG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x39E5BC0", Offset = "0x39E41C0", VA = "0x1839E5BC0", Slot = "22")]
	public T EOAGGJBDPDM<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x39E5BC0", Offset = "0x39E41C0", VA = "0x1839E5BC0", Slot = "23")]
	public void HJDBHKMHDFP<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x39E4920", Offset = "0x39E2F20", VA = "0x1839E4920")]
	private T CGDEEHFLOCJ<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x39E5460", Offset = "0x39E3A60", VA = "0x1839E5460")]
	private void EIOJNGJHOIM<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1270", Offset = "0x7FCF870", VA = "0x187FD1270", Slot = "16")]
	public string LEEDJCCMEMN(string DEMJFJNLMJF, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0F50", Offset = "0x7FCF550", VA = "0x187FD0F50", Slot = "17")]
	public void GBEIMMODMEC(string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0EA0", Offset = "0x7FCF4A0", VA = "0x187FD0EA0")]
	private void DHAJLODPGMO(string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1390", Offset = "0x7FCF990", VA = "0x187FD1390")]
	private string MCPGCFBLGCL(string DEMJFJNLMJF, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0D40", Offset = "0x7FCF340", VA = "0x187FD0D40", Slot = "24")]
	public void BPKBPKIGDMC(string DEMJFJNLMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0E00", Offset = "0x7FCF400", VA = "0x187FD0E00")]
	private string DDEFEIKIPED(string OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7FD12A0", Offset = "0x7FCF8A0", VA = "0x187FD12A0", Slot = "25")]
	[AsyncStateMachine(typeof(ICEPJNDOHNA))]
	public Task LKBHDLALJNO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1080", Offset = "0x7FCF680", VA = "0x187FD1080")]
	[IteratorStateMachine(typeof(DBEMGJPFFOO))]
	private IEnumerator<NFNODNEANBN> IDBAJGLGEDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0EC0", Offset = "0x7FCF4C0", VA = "0x187FD0EC0")]
	private void EIPOFNCEPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7FD13E0", Offset = "0x7FCF9E0", VA = "0x187FD13E0")]
	private void NHDMOIOBIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1170", Offset = "0x7FCF770", VA = "0x187FD1170")]
	private void JEGFEIBPGPL(bool HGOIGFMIJIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DPIDOAHFPPC : MGBMDHHJOAM, EJAEICGHADP
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
	private Dictionary<string, string> HCIMFFEAFJD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string JFMFLKALIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAEE0", Offset = "0x7FC94E0", VA = "0x187FCAEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> ECNEIEJJBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAD20", Offset = "0x7FC9320", VA = "0x187FCAD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	[UnityEngine.Scripting.Preserve]
	public DPIDOAHFPPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "8")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7FCAF50", Offset = "0x7FC9550", VA = "0x187FCAF50", Slot = "6")]
	public Task HGDKFAJHECN(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCAD60", Offset = "0x7FC9360", VA = "0x187FCAD60", Slot = "14")]
	public float EPIJGHEEOEF(string OEHHKNIGGMI, float JMMNJNFGHEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB820", Offset = "0x7FC9E20", VA = "0x187FCB820", Slot = "13")]
	public void OFNIIOFAJPM(string OEHHKNIGGMI, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB890", Offset = "0x7FC9E90", VA = "0x187FCB890", Slot = "12")]
	public bool OKLGNCIFKBA(string OEHHKNIGGMI, bool JMMNJNFGHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB7B0", Offset = "0x7FC9DB0", VA = "0x187FCB7B0", Slot = "10")]
	public int NNOIHJGKKGM(string OEHHKNIGGMI, int JMMNJNFGHEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB2C0", Offset = "0x7FC98C0", VA = "0x187FCB2C0", Slot = "18")]
	public DateTime JEBJDLKHGKI(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB330", Offset = "0x7FC9930", VA = "0x187FCB330", Slot = "19")]
	public void KCEJNGCHGLO(string OEHHKNIGGMI, DateTime OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB740", Offset = "0x7FC9D40", VA = "0x187FCB740", Slot = "15")]
	public void NAAAPAAPMMK(string OEHHKNIGGMI, float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FCACB0", Offset = "0x7FC92B0", VA = "0x187FCACB0", Slot = "11")]
	public void CMIPEDDPBGD(string OEHHKNIGGMI, int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7FCAB80", Offset = "0x7FC9180", VA = "0x187FCAB80", Slot = "20")]
	public long BDDFBMHAGNG(string DEMJFJNLMJF, long JMMNJNFGHEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FCAE70", Offset = "0x7FC9470", VA = "0x187FCAE70", Slot = "21")]
	public void GPFDAIOONLG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x36D30A0", Offset = "0x36D16A0", VA = "0x1836D30A0", Slot = "22")]
	public T EOAGGJBDPDM<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x36D30A0", Offset = "0x36D16A0", VA = "0x1836D30A0", Slot = "23")]
	public void HJDBHKMHDFP<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, NBHJDEFAJJO<T> BAGAKFJAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB430", Offset = "0x7FC9A30", VA = "0x187FCB430", Slot = "16")]
	public string LEEDJCCMEMN(string OEHHKNIGGMI, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7FCADD0", Offset = "0x7FC93D0", VA = "0x187FCADD0", Slot = "17")]
	public void GBEIMMODMEC(string OEHHKNIGGMI, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7FCABF0", Offset = "0x7FC91F0", VA = "0x187FCABF0", Slot = "24")]
	public void BPKBPKIGDMC(string OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB3A0", Offset = "0x7FC99A0", VA = "0x187FCB3A0", Slot = "9")]
	public bool KKKODMEFLHH(string OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB4E0", Offset = "0x7FC9AE0", VA = "0x187FCB4E0", Slot = "25")]
	public Task LKBHDLALJNO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x36D32A0", Offset = "0x36D18A0", VA = "0x1836D32A0")]
	private T PHDCGNDDLGA<T>(string DEMJFJNLMJF, T JMMNJNFGHEP, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x36D2030", Offset = "0x36D0630", VA = "0x1836D2030")]
	private void DGBNDJBCMEF<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, [Optional] NBHJDEFAJJO<T> PLJDBFGEJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7FCAFE0", Offset = "0x7FC95E0", VA = "0x187FCAFE0")]
	private Dictionary<string, string> ICCEALGLFHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DBENBDOGMLE
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action MFALNFFKHGE;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJHPANODDAM();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PJCMIBBHEOE(long OGCAMFNODBO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NHLHDJCGBCI(KAPLCGNEGKI EIBMKBIIOGF = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MKOAELJLNPA(string DEMJFJNLMJF, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GKGFFIMKOMO(string DEMJFJNLMJF, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string BHIFOGIADJK(string DEMJFJNLMJF, [Optional] string JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OFLEGLNACKE IFECIEBHLFN(string DEMJFJNLMJF, string OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int KGHOMABCGNF(string DEMJFJNLMJF, int JMMNJNFGHEP = 0, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OFLEGLNACKE MDOIDMCPDIG(string DEMJFJNLMJF, int OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool INOJIKEIAJG(string DEMJFJNLMJF, bool JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OFLEGLNACKE DJJIJODLAHE(string DEMJFJNLMJF, bool OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float KLBNPCGJLFH(string DEMJFJNLMJF, float JMMNJNFGHEP = 0f, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OFLEGLNACKE NCFPCFHEBNJ(string DEMJFJNLMJF, float OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime GDPAIGKBEHM(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OFLEGLNACKE JDKDCDICEJL(string DEMJFJNLMJF, DateTime OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long IAICFHMLPJG(string DEMJFJNLMJF, long JMMNJNFGHEP = 0L, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	OFLEGLNACKE NJKMGNEJJCB(string DEMJFJNLMJF, long OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T ICHKOICLOPN<T>(string DEMJFJNLMJF, [Optional] T JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	OFLEGLNACKE FANLJBMFFIC<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool HPGOCANFHFN(string DEMJFJNLMJF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool MDMJEBBGIDC(string DEMJFJNLMJF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string CLMAHFDFELF(string DEMJFJNLMJF, [Optional] string JMMNJNFGHEP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OFLEGLNACKE EKIFAPJFAED(string DEMJFJNLMJF, string OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int BADNBIINAFO(string DEMJFJNLMJF, int JMMNJNFGHEP = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	OFLEGLNACKE OOGEFPLPPOO(string DEMJFJNLMJF, int OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EEANPDMCNNF(string DEMJFJNLMJF, bool JMMNJNFGHEP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	OFLEGLNACKE LFEHEOOKCPI(string DEMJFJNLMJF, bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float HMDOHOEFEPD(string DEMJFJNLMJF, float JMMNJNFGHEP = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	OFLEGLNACKE DPEJHGKPEAE(string DEMJFJNLMJF, float OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime FBOCNFCAHEJ(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	OFLEGLNACKE PMMDODJHGPI(string DEMJFJNLMJF, DateTime OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long DBFKINJJFHI(string DEMJFJNLMJF, long JMMNJNFGHEP = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	OFLEGLNACKE IILLDJOFDFG(string DEMJFJNLMJF, long OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BGGMEOENCAN<T>(NBHJDEFAJJO<T> BAGAKFJAGLG, [Optional] IEqualityComparer<T> EFGNCEEFOAD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void KHFBGKEMANK<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable FBMCCEMFOCG();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void MFLJHJIGHAL(float EPOJNFBFHFP);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task EIPOFNCEPMA([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum OFLEGLNACKE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KJEKKKNMJGB : DBENBDOGMLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class MABDACEBFAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<MABDACEBFAF> IKCGIPBAPFL;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0310", Offset = "0x7FCE910", VA = "0x187FD0310")]
		public static void JKEPHKCGLAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void INBDHNEFJBE();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		protected MABDACEBFAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class AKEECHJFHFD<T> : MABDACEBFAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly AKEECHJFHFD<T> MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NBHJDEFAJJO<T> GACLFMFIGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> BJDDJBEMMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool FHJCOLKGBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x44F16F0", Offset = "0x44EFCF0", VA = "0x1844F16F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4C7FC10", Offset = "0x4C7E210", VA = "0x184C7FC10")]
		private AKEECHJFHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4C7F670", Offset = "0x4C7DC70", VA = "0x184C7F670")]
		public void AMBIAOGNIIF(NBHJDEFAJJO<T> PLJDBFGEJFF, [Optional] IEqualityComparer<T> EFGNCEEFOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4C7F9D0", Offset = "0x4C7DFD0", VA = "0x184C7F9D0", Slot = "4")]
		public override void INBDHNEFJBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class FFEJPBCLNGD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly KJEKKKNMJGB MLJOMODDHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object OPEADGAJBDJ;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB980", Offset = "0x7FC9F80", VA = "0x187FCB980")]
		public FFEJPBCLNGD(KJEKKKNMJGB MLJOMODDHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB950", Offset = "0x7FC9F50", VA = "0x187FCB950", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct KAJNFBAPOOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KJEKKKNMJGB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7FCC8B0", Offset = "0x7FCAEB0", VA = "0x187FCC8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCB90", Offset = "0x7FCB190", VA = "0x187FCCB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MMALPGJOHEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public KJEKKKNMJGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public EJAEICGHADP backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7FD04E0", Offset = "0x7FCEAE0", VA = "0x187FD04E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct KGMKLOMMEKH : IAsyncStateMachine
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
		public KJEKKKNMJGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCBF0", Offset = "0x7FCB1F0", VA = "0x187FCCBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD0C0", Offset = "0x7FCB6C0", VA = "0x187FCD0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DJOPLIEDHFO : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private NFNODNEANBN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public KJEKKKNMJGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public DJOPLIEDHFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAAA0", Offset = "0x7FC90A0", VA = "0x187FCAAA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAB30", Offset = "0x7FC9130", VA = "0x187FCAB30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly MGBMDHHJOAM JHIBALEOLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly MGBMDHHJOAM PNMPKMPMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly MIGPCMLOJNH FBLIMLNFLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly GJPCEPMOONC PCPLHHLNPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ILKICLAKLCI.FMPKBOPEANH LBNAINNHMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly PHIGNGELHED IKJKFELELMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<EJAEICGHADP> IELOBKAKEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task CIOFCFGNPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> LFNEHHAOOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private OLILOOIADED OKFBADGBFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object HHMPINDOBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object CALFAOCCKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long FBKKMOFHGBK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool GAINMBDPKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE9E0", Offset = "0x7FCCFE0", VA = "0x187FCE9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource PNPJLMPNADA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MFALNFFKHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE3D0", Offset = "0x7FCC9D0", VA = "0x187FCE3D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDD10", Offset = "0x7FCC310", VA = "0x187FCDD10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF9F0", Offset = "0x7FCDFF0", VA = "0x187FCF9F0")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFF40", Offset = "0x7FCE540", VA = "0x187FCFF40")]
	[UnityEngine.Scripting.Preserve]
	public KJEKKKNMJGB([DJIFKCCBBND("Disk")] MGBMDHHJOAM JHIBALEOLJM, [DJIFKCCBBND("Cloud")] MGBMDHHJOAM PNMPKMPMCBI, [DJIFKCCBBND(null)] MIGPCMLOJNH FBLIMLNFLJI, [DJIFKCCBBND(null)] GJPCEPMOONC PCPLHHLNPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD830", Offset = "0x7FCBE30", VA = "0x187FCD830", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDA00", Offset = "0x7FCC000", VA = "0x187FCDA00")]
	private void FBBNEMABKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD3F0", Offset = "0x7FCB9F0", VA = "0x187FCD3F0", Slot = "6")]
	public void CJHPANODDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFC30", Offset = "0x7FCE230", VA = "0x187FCFC30", Slot = "7")]
	public Task PJCMIBBHEOE(long OGCAMFNODBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFE30", Offset = "0x7FCE430", VA = "0x187FCFE30")]
	[AsyncStateMachine(typeof(KAJNFBAPOOF))]
	private Task POLOJCFAAPF(long OGCAMFNODBO, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEA00", Offset = "0x7FCD000", VA = "0x187FCEA00")]
	private void KAAKMMABKKF(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD120", Offset = "0x7FCB720", VA = "0x187FCD120")]
	private void AAEOFNLNFKE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE370", Offset = "0x7FCC970", VA = "0x187FCE370")]
	private string HFMICCJJBDJ(string HNIMABPKBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFA60", Offset = "0x7FCE060", VA = "0x187FCFA60")]
	private void OJHCKAEFNJL(KAPLCGNEGKI EIBMKBIIOGF, string OEHHKNIGGMI, [Out] MGBMDHHJOAM NEIAGIIAPIA, [Out] string LBFEIPBHCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF970", Offset = "0x7FCDF70", VA = "0x187FCF970")]
	private MGBMDHHJOAM NLGLCLNCNML(KAPLCGNEGKI EIBMKBIIOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF740", Offset = "0x7FCDD40", VA = "0x187FCF740", Slot = "8")]
	public bool NHLHDJCGBCI(KAPLCGNEGKI EIBMKBIIOGF = KAPLCGNEGKI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF150", Offset = "0x7FCD750", VA = "0x187FCF150", Slot = "9")]
	public bool MKOAELJLNPA(string DEMJFJNLMJF, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE1F0", Offset = "0x7FCC7F0", VA = "0x187FCE1F0", Slot = "10")]
	public bool GKGFFIMKOMO(string DEMJFJNLMJF, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD350", Offset = "0x7FCB950", VA = "0x187FCD350", Slot = "11")]
	public string BHIFOGIADJK(string DEMJFJNLMJF, [Optional] string JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE5E0", Offset = "0x7FCCBE0", VA = "0x187FCE5E0", Slot = "12")]
	public OFLEGLNACKE IFECIEBHLFN(string DEMJFJNLMJF, string OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEAB0", Offset = "0x7FCD0B0", VA = "0x187FCEAB0", Slot = "13")]
	public int KGHOMABCGNF(string DEMJFJNLMJF, int JMMNJNFGHEP = 0, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEFA0", Offset = "0x7FCD5A0", VA = "0x187FCEFA0", Slot = "14")]
	public OFLEGLNACKE MDOIDMCPDIG(string DEMJFJNLMJF, int OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE790", Offset = "0x7FCCD90", VA = "0x187FCE790", Slot = "15")]
	public bool INOJIKEIAJG(string DEMJFJNLMJF, bool JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD690", Offset = "0x7FCBC90", VA = "0x187FCD690", Slot = "16")]
	public OFLEGLNACKE DJJIJODLAHE(string DEMJFJNLMJF, bool OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEB60", Offset = "0x7FCD160", VA = "0x187FCEB60", Slot = "17")]
	public float KLBNPCGJLFH(string DEMJFJNLMJF, float JMMNJNFGHEP = 0f, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF5C0", Offset = "0x7FCDBC0", VA = "0x187FCF5C0", Slot = "18")]
	public OFLEGLNACKE NCFPCFHEBNJ(string DEMJFJNLMJF, float OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE150", Offset = "0x7FCC750", VA = "0x187FCE150", Slot = "19")]
	public DateTime GDPAIGKBEHM(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE840", Offset = "0x7FCCE40", VA = "0x187FCE840", Slot = "20")]
	public OFLEGLNACKE JDKDCDICEJL(string DEMJFJNLMJF, DateTime OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE540", Offset = "0x7FCCB40", VA = "0x187FCE540", Slot = "21")]
	public long IAICFHMLPJG(string DEMJFJNLMJF, long JMMNJNFGHEP = 0L, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF800", Offset = "0x7FCDE00", VA = "0x187FCF800", Slot = "22")]
	public OFLEGLNACKE NJKMGNEJJCB(string DEMJFJNLMJF, long OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x390A420", Offset = "0x3908A20", VA = "0x18390A420", Slot = "23")]
	public T ICHKOICLOPN<T>(string DEMJFJNLMJF, [Optional] T JMMNJNFGHEP, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x390A420", Offset = "0x3908A20", VA = "0x18390A420", Slot = "24")]
	public OFLEGLNACKE FANLJBMFFIC<T>(string DEMJFJNLMJF, T OHLIHBDBKCE, KAPLCGNEGKI AJFBNEAGHIK = KAPLCGNEGKI.CLOUD)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE4E0", Offset = "0x7FCCAE0", VA = "0x187FCE4E0", Slot = "25")]
	public bool HPGOCANFHFN(string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEF90", Offset = "0x7FCD590", VA = "0x187FCEF90", Slot = "26")]
	public bool MDMJEBBGIDC(string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD460", Offset = "0x7FCBA60", VA = "0x187FCD460", Slot = "27")]
	public string CLMAHFDFELF(string DEMJFJNLMJF, [Optional] string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD9D0", Offset = "0x7FCBFD0", VA = "0x187FCD9D0", Slot = "28")]
	public OFLEGLNACKE EKIFAPJFAED(string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD1A0", Offset = "0x7FCB7A0", VA = "0x187FCD1A0", Slot = "29")]
	public int BADNBIINAFO(string DEMJFJNLMJF, int JMMNJNFGHEP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFC00", Offset = "0x7FCE200", VA = "0x187FCFC00", Slot = "30")]
	public OFLEGLNACKE OOGEFPLPPOO(string DEMJFJNLMJF, int OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD870", Offset = "0x7FCBE70", VA = "0x187FCD870", Slot = "31")]
	public bool EEANPDMCNNF(string DEMJFJNLMJF, bool JMMNJNFGHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7FCED50", Offset = "0x7FCD350", VA = "0x187FCED50", Slot = "32")]
	public OFLEGLNACKE LFEHEOOKCPI(string DEMJFJNLMJF, bool OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE470", Offset = "0x7FCCA70", VA = "0x187FCE470", Slot = "33")]
	public float HMDOHOEFEPD(string DEMJFJNLMJF, float JMMNJNFGHEP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD800", Offset = "0x7FCBE00", VA = "0x187FCD800", Slot = "34")]
	public OFLEGLNACKE DPEJHGKPEAE(string DEMJFJNLMJF, float OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDB30", Offset = "0x7FCC130", VA = "0x187FCDB30", Slot = "35")]
	public DateTime FBOCNFCAHEJ(string DEMJFJNLMJF, [Optional] DateTime JMMNJNFGHEP)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFE00", Offset = "0x7FCE400", VA = "0x187FCFE00", Slot = "36")]
	public OFLEGLNACKE PMMDODJHGPI(string DEMJFJNLMJF, DateTime OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD4D0", Offset = "0x7FCBAD0", VA = "0x187FCD4D0", Slot = "37")]
	public long DBFKINJJFHI(string DEMJFJNLMJF, long JMMNJNFGHEP = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE760", Offset = "0x7FCCD60", VA = "0x187FCE760", Slot = "38")]
	public OFLEGLNACKE IILLDJOFDFG(string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDDB0", Offset = "0x7FCC3B0", VA = "0x187FCDDB0")]
	private bool FHEEBADODPJ(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDE10", Offset = "0x7FCC410", VA = "0x187FCDE10")]
	private bool FLNFKGAABPG(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD540", Offset = "0x7FCBB40", VA = "0x187FCD540")]
	private OFLEGLNACKE DCMLFIKLLJI(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, string OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEE50", Offset = "0x7FCD450", VA = "0x187FCEE50")]
	private OFLEGLNACKE MBAIKNNGIMK(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, int OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD210", Offset = "0x7FCB810", VA = "0x187FCD210")]
	private OFLEGLNACKE BDNIEIGJPHN(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, bool OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF1F0", Offset = "0x7FCD7F0", VA = "0x187FCF1F0")]
	private OFLEGLNACKE MMNDKJPPNOC(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, float OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDBA0", Offset = "0x7FCC1A0", VA = "0x187FCDBA0")]
	private OFLEGLNACKE FCCJLCONKNL(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, DateTime OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEC10", Offset = "0x7FCD210", VA = "0x187FCEC10")]
	private OFLEGLNACKE LCCGPLMODGL(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, long OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x390A5F0", Offset = "0x3908BF0", VA = "0x18390A5F0")]
	private T FGLLOPAHMAA<T>(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, T JMMNJNFGHEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x390AD60", Offset = "0x3909360", VA = "0x18390AD60")]
	private OFLEGLNACKE LCLLHBGLOKP<T>(EJAEICGHADP NEIAGIIAPIA, string DEMJFJNLMJF, T OHLIHBDBKCE)
	{
		return default(OFLEGLNACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x390A370", Offset = "0x3908970", VA = "0x18390A370", Slot = "39")]
	public void BGGMEOENCAN<T>(NBHJDEFAJJO<T> BAGAKFJAGLG, [Optional] IEqualityComparer<T> EFGNCEEFOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x390ACE0", Offset = "0x39092E0", VA = "0x18390ACE0", Slot = "40")]
	public void KHFBGKEMANK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7FCED80", Offset = "0x7FCD380", VA = "0x187FCED80")]
	[AsyncStateMachine(typeof(MMALPGJOHEB))]
	private void LKBHDLALJNO(EJAEICGHADP LDOMBAIIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD8E0", Offset = "0x7FCBEE0", VA = "0x187FCD8E0", Slot = "43")]
	[AsyncStateMachine(typeof(KGMKLOMMEKH))]
	public Task EIPOFNCEPMA([Optional] CancellationToken EJJDDFFADPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDF70", Offset = "0x7FCC570", VA = "0x187FCDF70")]
	private void GAKLCPDEDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDA50", Offset = "0x7FCC050", VA = "0x187FCDA50", Slot = "41")]
	public IDisposable FBMCCEMFOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF110", Offset = "0x7FCD710", VA = "0x187FCF110", Slot = "42")]
	public void MFLJHJIGHAL(float EPOJNFBFHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF340", Offset = "0x7FCD940", VA = "0x187FCF340")]
	private void MONAEHLMHGL(float LLKEPBHGFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEA20", Offset = "0x7FCD020", VA = "0x187FCEA20")]
	[IteratorStateMachine(typeof(DJOPLIEDHFO))]
	private IEnumerator<NFNODNEANBN> KAHMCELNOKA(float EPOJNFBFHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF120", Offset = "0x7FCD720", VA = "0x187FCF120")]
	[CompilerGenerated]
	private void MKMKLPDDPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DAEIJKHPCOA : ONJKNCMKDMF<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static DAEIJKHPCOA MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA8C0", Offset = "0x7FC8EC0", VA = "0x187FCA8C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA550", Offset = "0x7FC8B50", VA = "0x187FCA550", Slot = "9")]
	public override string DFNAEDFOBIJ(bool HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA640", Offset = "0x7FC8C40", VA = "0x187FCA640", Slot = "10")]
	protected override bool DPOBAFJDPAH(string HPLMFDGMJFE, [Out] bool OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA9A0", Offset = "0x7FC8FA0", VA = "0x187FCA9A0")]
	public DAEIJKHPCOA()
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
